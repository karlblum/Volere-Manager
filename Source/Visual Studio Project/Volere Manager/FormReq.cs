using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Volere_Manager
{
    public partial class FormReq : DockContent
    {
        FormMain mainForm;

        private Req thisReq = null;
        private bool modified = false;
        private bool initMode = false;
        private bool fClose = false;
        private bool resourceEditMode = false;
        List<string> resourceRows = null;
        List<string> conflicts = null;
        public Boolean serialClosing = false;

        public void forcedClose()
        {
            this.fClose = true;
            this.Close();
        }

        private void FormReq_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (modified && !fClose)
            {
                DialogResult result = MessageBox.Show("Close without saving?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if(!serialClosing) mainForm.reqList.Remove(this) ;
                }
                else
                {
                    e.Cancel = true;
                }

            }
            if (!serialClosing) mainForm.reqList.Remove(this);

        }


        public Req getReq()
        {
            return this.thisReq;
        }

        public FormReq(FormMain mf)
        {
            this.mainForm = mf;
            InitializeComponent();
            initData();
        }

        public FormReq(FormMain mf, Req requirement)
        {
            this.mainForm = mf;
            this.thisReq = requirement;
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            initMode = true;
            String[] listOfBytes = new String[] { "1", "2", "3", "4", "5" };

            cBoxPriority.Items.AddRange(listOfBytes);
            cBoxCustomerSatisfaction.Items.AddRange(listOfBytes);
            cBoxCustomerDissatisfaction.Items.AddRange(listOfBytes);

            updateReqTypesCBox();
            updateResourcesCBox();
            initOriginatorList();

            if (thisReq != null)
            {
                this.txtDescription.Text = thisReq.Description;
                this.txtRationale.Text = thisReq.Rationale;
                this.txtFitCriterion.Text = thisReq.Fit_criterion;
                this.txtCreated.Text = thisReq.Created.ToString();
                this.txtModified.Text = thisReq.Modified.ToString();
                if (thisReq.Use_cases != null)
                {
                    this.txtUseCases.Text = thisReq.Use_cases.ToString();
                }
                this.cBoxPriority.SelectedItem = thisReq.Priority.ToString();
                this.cBoxCustomerSatisfaction.SelectedItem = thisReq.Satisfaction.Value.ToString();
                this.cBoxCustomerDissatisfaction.SelectedItem = thisReq.Dissatisfaction.Value.ToString();

                this.txtId.Text = thisReq.Id.ToString();
                this.TabText = "#" + this.txtId.Text + " " + this.txtDescription.Text.Substring(0, Math.Min(this.txtDescription.Text.Length, 7)) + "...";
                initResourcesTab();
                initConflicts();
                
            }
            else
            {

            }

            initMode = false;
        }

        private void updateResourcesCBox()
        {
            var resources = (from res in mainForm.dc.Resources
                             select res.Description.ToString()).Distinct();

            this.cBoxResMod.Items.Clear();
            this.cBoxResMod.Items.AddRange(resources.ToArray());
        }

        private void initOriginatorList()
        {
            List<string> originatorList = new List<string>();
            originatorList = (from ol in mainForm.dc.Req
                              select ol.Originator_id).Distinct().ToList<string>();
            originatorList.Remove(null);

            this.cBoxOriginator.Items.Clear();
            this.cBoxOriginator.Items.AddRange(originatorList.ToArray());
            if (thisReq != null &&thisReq.Originator_id != null)
                this.cBoxOriginator.SelectedItem = thisReq.Originator_id.ToString();
        }

        private void initConflicts()
        {
            List<string> conflictings = new List<string>();
            var cfList = from cf in mainForm.dc.Conflicts
                         where cf.Req_id1 == thisReq.Id || cf.Req_id2 == thisReq.Id
                         select cf;

            foreach (var i in cfList)
            {
                if (i.Req_id1 == thisReq.Id)
                {
                    if(!conflictings.Contains(i.Req_id2.ToString()))
                    conflictings.Add(i.Req_id2.ToString());
                }
                else
                {
                    if (!conflictings.Contains(i.Req_id1.ToString()))
                    conflictings.Add(i.Req_id1.ToString());
                }
            }
            lBoxConflicts.Items.Clear();
            lBoxConflicts.Items.AddRange(conflictings.ToArray());
        }

        private void initResourcesTab()
        {

            IQueryable<Resources> reqResources = from res in mainForm.dc.Req_Resources
                                                 where res.Req == this.thisReq
                                                 select res.Resources;

            if (reqResources.Count() > 0)
            {
                resourceRows = new List<string>();
                int counter = 0;
                foreach (var item in reqResources)
                {
                    counter++;
                    resourceRows.Add(item.Description.ToString());

                }
                updateReqResListbox();
            }

        }

        private void dataChanged(object sender, EventArgs e)
        {
            if (!modified && !initMode)
            {
                this.TabText += "*";
                modified = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void insertOrUpdate()
        {

            if (thisReq == null) thisReq = new Req();

            thisReq.Req_Types = (Req_Types)cBoxReqType.SelectedItem;
            thisReq.Description = txtDescription.Text;
            thisReq.Dissatisfaction = Convert.ToByte(cBoxCustomerDissatisfaction.SelectedItem);
            thisReq.Satisfaction = Convert.ToByte(cBoxCustomerSatisfaction.SelectedItem);
            thisReq.Fit_criterion = txtFitCriterion.Text;
            thisReq.Priority = Convert.ToByte(cBoxPriority.SelectedItem);
            thisReq.Rationale = txtRationale.Text;
            thisReq.Originator_id = cBoxOriginator.Text;
            thisReq.Rationale = txtRationale.Text;
            thisReq.Use_cases = txtUseCases.Text;


            if (!(thisReq.Id > 0))
            {
                mainForm.dc.Req.InsertOnSubmit(thisReq);
                thisReq.Created = DateTime.Now;
            }
            else
            {
                thisReq.Modified = DateTime.Now;
            }

            this.txtId.Text = this.thisReq.Id.ToString();
            this.TabText = "#" + this.thisReq.Id.ToString() + " " + this.txtDescription.Text.Substring(0, Math.Min(this.txtDescription.Text.Length, 30));

            if (resourceRows != null)
            {
                thisReq.Req_Resources.Clear();
                foreach (var item in resourceRows)
                {
                    Resources res = new Resources();
                    Req_Resources rrs = new Req_Resources();
                    rrs.Resources = res;
                    rrs.Req = thisReq;
                    res.Description = item;
                    thisReq.Req_Resources.Add(rrs);
                }
            }

            DifferentialList dl = new DifferentialList(conflicts, lBoxConflicts.Items);

            foreach (var i in dl.getAdds())
            {
                Conflicts newConflict = new Conflicts();
                newConflict.Req_id1 = thisReq.Id;
                newConflict.Req_id2 = i;
                thisReq.Conflicts.Add(newConflict);
            }
            foreach (var i in dl.getRemoves())
            {

                var conflict = (from req in mainForm.dc.Conflicts
                                where req.Req_id1 == i || req.Req_id2 == i
                                select req).First();

                thisReq.Conflicts.Remove(conflict);
            }

            mainForm.dc.SubmitChanges();
            this.modified = false;
        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertOrUpdate();
            this.mainForm.initDataUpdate();
        }

        private void createDuplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        internal void updateReqTypesCBox()
        {
            Boolean currentMode = initMode;
            if (!currentMode) initMode = true;
            this.cBoxReqType.Items.Clear();
            var reqTypes = from r in mainForm.dc.Req_Types
                           orderby r.Nr ascending,
                           r.SubNr ascending
                           where r.Used == true &&
                           r.SubNr != null
                           select r;

            foreach (var r in reqTypes)
            {
                this.cBoxReqType.Items.Add(r);
            }
            if (thisReq != null)
            {
                cBoxReqType.SelectedItem = thisReq.Req_Types;
            }
            else if (cBoxReqType.Items.Count != 0)
            {
                cBoxReqType.SelectedIndex = 0;
            }

            initMode = currentMode;

        }

        private void closeThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.closeReqFrom(this, false);
        }

        private void closeAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainForm.closeReqFormAllOthers(null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainForm.closeReqFormAllOthers(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.showReq(null);
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.deleteReq(this, false);
            mainForm.initDataUpdate();
        }

        private void FormReq_Enter(object sender, EventArgs e)
        {
            this.mainForm.activeReq = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void updateReqResListbox()
        {
            lBoxResources.Items.Clear();
            int counter = 0;
            foreach (var item in resourceRows)
            {
                counter++;
                lBoxResources.Items.Add(counter + ". " + item.ToString());
            }

        }

        private void cBoxResMod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddModify_Click(object sender, EventArgs e)
        {
            modified = true;

            String rTxt = cBoxResMod.Text;
            if (resourceRows == null) resourceRows = new List<string>();
            if (resourceEditMode && rTxt.Length > 0 && lBoxResources.SelectedIndex > -1)
            {
                String lTxt = lBoxResources.Items[lBoxResources.SelectedIndex].ToString();
                resourceRows.Remove(lTxt.Substring(lTxt.IndexOf('.') + 2));
                resourceRows.Add(rTxt);
                updateReqResListbox();

            }
            else if (rTxt.Length > 0)
            {
                resourceRows.Add(rTxt);
                updateReqResListbox();

            }
            btnAddModify.Text = "Add";
            cBoxResMod.Text = "";

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (lBoxResources.SelectedIndex > -1)
            {
                modified = true;
                String lTxt = lBoxResources.Items[lBoxResources.SelectedIndex].ToString();
                resourceRows.Remove(lTxt.Substring(lTxt.IndexOf('.') + 2));
                updateReqResListbox();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lBoxResources.SelectedIndex > -1)
            {
                resourceEditMode = true;
                String lTxt = lBoxResources.Items[lBoxResources.SelectedIndex].ToString();
                cBoxResMod.Text = lTxt.Substring(lTxt.IndexOf('.') + 2);
                btnAddModify.Text = "Modify";
                btnCancelEdit.Visible = true;

            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            resourceEditMode = false;
            btnCancelEdit.Visible = false;
            btnAddModify.Text = "Add";
            cBoxResMod.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddConflict_Click(object sender, EventArgs e)
        {
            if (txtConflictAdd.Text == thisReq.Id.ToString())
            {
                MessageBox.Show("Requirement cannot conflict itself!", "Impossible!", MessageBoxButtons.OK);
            }
            else
            {
                Int16 reqId = 0;

                try
                {
                    reqId = Convert.ToInt16(txtConflictAdd.Text);
                }
                catch (Exception ex)
                {

                }

                if (!lBoxConflicts.Items.Contains(txtConflictAdd.Text))
                {
                    var conflictingReq = from req in mainForm.dc.Req
                                         where req.Id == Convert.ToInt64(txtConflictAdd.Text)
                                         select req;



                    if (conflictingReq.Count() > 0)
                    {
                        modified = true;
                        lBoxConflicts.Items.Add(txtConflictAdd.Text);
                    }
                    else
                    {
                        MessageBox.Show("Requirement: " + txtConflictAdd.Text + " not found!", "Not found!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Requirement: " + txtConflictAdd.Text + " already listed!", "Already listed!", MessageBoxButtons.OK);
                }
            }
            txtConflictAdd.Text = "";
        }

        private void btnRemoveConflict_Click(object sender, EventArgs e)
        {
            if (lBoxConflicts.SelectedIndex > -1)
            {
                lBoxConflicts.Items.RemoveAt(lBoxConflicts.SelectedIndex);
                modified = true;
            }
        }

        private void FormReq_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormReq_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar.ToString());
        }

        private void FormReq_KeyDown(object sender, KeyEventArgs e)
        {

        }


    }
}
