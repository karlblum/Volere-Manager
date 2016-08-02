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
    public partial class FormReqManager : DockContent
    {
        private FormMain mainForm;
        private List<HeaderItem> headerItems = new List<HeaderItem>();
        public List<Req> filteredReqs = new List<Req>();

        public FormReqManager(FormMain mf)
        {
            InitializeComponent();
            this.mainForm = mf;
            initData();
        }

        public void initData()
        {
            if (mainForm.dc != null)
            {
                if (FilterState.filterActive)
                {
                    var reqQuery = from requirements in mainForm.dc.Req
                                   where !FilterState.unCheckedIds.Contains(requirements.Req_Types.Id)
                                   select requirements;

                    if (FilterState.createdFrom != DateTime.MinValue)
                    {
                        reqQuery = from requirements in reqQuery
                                   where requirements.Created > FilterState.createdFrom
                                   select requirements;
                    }

                    if (FilterState.createdTo != DateTime.MaxValue)
                    {
                        reqQuery = from requirements in reqQuery
                                   where requirements.Created < FilterState.createdTo
                                   select requirements;
                    }

                    if (FilterState.lastFrom != DateTime.MinValue)
                    {
                        reqQuery = from requirements in reqQuery
                                   where requirements.Modified > FilterState.lastFrom
                                   select requirements;
                    }

                    if (FilterState.lastTo != DateTime.MaxValue)
                    {
                        reqQuery = from requirements in reqQuery
                                   where requirements.Modified < FilterState.lastTo
                                   select requirements;
                    }
                    
                    if(FilterState.priority != -1){

                        if (FilterState.priority == 0)
                        {

                            reqQuery = from requirements in reqQuery
                                       where requirements.Priority == 0
                                       select requirements;
                        }
                        else
                        {
                            reqQuery = from requirements in reqQuery
                                       where requirements.Priority == FilterState.priority
                                       select requirements;
                        }
                    }

                    if (FilterState.satisfaction != -1)
                    {

                        if (FilterState.satisfaction == 0)
                        {

                            reqQuery = from requirements in reqQuery
                                       where requirements.Satisfaction == 0
                                       select requirements;
                        }
                        else
                        {
                            reqQuery = from requirements in reqQuery
                                       where requirements.Satisfaction == FilterState.satisfaction
                                       select requirements;
                        }
                    }

                    if (FilterState.dissatisfaction != -1)
                    {
                        if (FilterState.dissatisfaction == 0)
                        {

                            reqQuery = from requirements in reqQuery
                                       where requirements.Dissatisfaction == 0
                                       select requirements;
                        }
                        else
                        {
                            reqQuery = from requirements in reqQuery
                                       where requirements.Dissatisfaction == FilterState.dissatisfaction
                                       select requirements;
                        }
                    }

                    if (FilterState.searchString.Length > 0)
                    {
                        reqQuery = from requirements in reqQuery
                                   where requirements.Description.Contains(FilterState.searchString)
                                   select requirements;
                    }

                    if (FilterState.conflictingIds.Count() > 0)
                    {
                        List<Int64> cfQuery = ((from conflict in mainForm.dc.Conflicts
                                       where FilterState.conflictingIds.Contains(conflict.Req_id1)
                                       select conflict.Req_id2).Union(
                                   from conflict in mainForm.dc.Conflicts
                                   where FilterState.conflictingIds.Contains(conflict.Req_id2)
                                   select conflict.Req_id1)).ToList<Int64>();

                       reqQuery = from requirements in reqQuery
                                   where cfQuery.Contains(requirements.Id)
                                   select requirements;
                        
                    }
                    if (FilterState.conflictAny){
                        var allConflictingIds = ((from reqs in mainForm.dc.Conflicts
                                              select reqs.Req_id1).Union(
                                              from reqs in mainForm.dc.Conflicts
                                              select reqs.Req_id2)).Distinct();

                        reqQuery = from requirements in reqQuery
                                   where allConflictingIds.Contains(requirements.Id)
                                   select requirements;
                    }
                    if (FilterState.conflictNone)
                    {
                        var allConflictingIds = ((from reqs in mainForm.dc.Conflicts
                                                          select reqs.Req_id1).Union(
                                              from reqs in mainForm.dc.Conflicts
                                              select reqs.Req_id2)).Distinct();

                        reqQuery = from requirements in reqQuery
                                   where !allConflictingIds.Contains(requirements.Id)
                                   select requirements;
                    }

                    if (FilterState.originator.Length > 0)
                    {
                        reqQuery = from requirements in reqQuery
                                   where requirements.Originator_id == FilterState.originator
                                   select requirements;
                    }

                    this.dataGridRequirements.DataSource = reqQuery;
                    filteredReqs = reqQuery.ToList<Req>();
                    mainForm.setStatusText("Active Requirements:" + reqQuery.Count());
                }
                else
                {
                    var reqQuery = from requirements in mainForm.dc.Req
                                   select requirements;
                    this.dataGridRequirements.DataSource = reqQuery;
                    filteredReqs = reqQuery.ToList<Req>();
                    mainForm.setStatusText("Active Requirements:" + reqQuery.Count());
                }


            }
            else
            {
                this.dataGridRequirements.DataSource = null;

            }

        }

        public void setHeaderItems(List<HeaderItem> _headerItems)
        {
            this.headerItems = _headerItems;
            resetDataGridHeader();
        }

        private void resetDataGridHeader()
        {
            this.headerMenu.Items.Clear();
            foreach (var hi in headerItems)
            {
                if (!hi.disabled)
                {
                    this.dataGridRequirements.Columns[hi.colDbName].HeaderText = hi.colHeaderName;
                    ToolStripMenuItem tItem = new ToolStripMenuItem(hi.colHeaderName);
                    if (hi.colHint != null) tItem.Text = "(" + hi.colHeaderName + ") " + hi.colHint;
                    tItem.Name = hi.colDbName;


                    tItem.Click += new EventHandler(tItem_Click);
                    if (hi.selected)
                    {
                        tItem.Checked = true;
                        this.dataGridRequirements.Columns[hi.colDbName].Visible = true;
                        this.dataGridRequirements.Columns[hi.colDbName].Width = hi.width;
                    }
                    else
                    {
                        tItem.Checked = false;
                        this.dataGridRequirements.Columns[hi.colDbName].Visible = false;
                    }
                    tItem.CheckedChanged += new EventHandler(tItem_CheckedChanged);
                    this.headerMenu.Items.Add(tItem);
                }
                else
                {
                    this.dataGridRequirements.Columns[hi.colDbName].Visible = false;
                }


            }

        }

        void tItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
        }

        void tItem_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var hi in headerItems)
            {
                if (hi.colDbName.Equals(((ToolStripMenuItem)sender).Name))
                {
                    hi.selected = !hi.selected;
                }
            }
            resetDataGridHeader();
        }

        private void tsBtnFilter_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = false;
            mainForm.showReqManagerFilter();
        }

        private void dataGridRequirements_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var selectedReq = ((Req)this.dataGridRequirements.Rows[e.RowIndex].DataBoundItem);
                this.mainForm.showReq(selectedReq);
            }
        }

        private void reqMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton_Click(sender, e);

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mainForm.showReq(null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in this.dataGridRequirements.SelectedRows)
            {
                var req = (Req)row.DataBoundItem;
                if (req != null)
                {
                    mainForm.deleteReq(req, true);
                }
            }

            mainForm.initDataUpdate();
        }

        private void dataGridRequirements_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridRequirements.SelectedRows.Count != 0 &&
                dataGridRequirements.SelectedRows[0].DataBoundItem != null &&
                mainForm.formPreview.Enabled)
            {
                mainForm.formPreview.showPreview((Req)dataGridRequirements.SelectedRows[0].DataBoundItem);
            }
        }

        private void qOtoolStripTextBox_Click(object sender, EventArgs e)
        {
            qOtoolStripTextBox.SelectAll();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridRequirements.SelectedRows.Count > 100)
            {
    
                    MessageBox.Show("Only <100 requirements can be opened at once!",
                "No can do!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                foreach (DataGridViewRow row in dataGridRequirements.SelectedRows)
                {
                    mainForm.showReq((Req)row.DataBoundItem);
                }
            }
        }





        internal void setFilterBtnState()
        {
            if (FilterState.filterActive)
            {
                this.tsBtnFilter.Image = global::Volere_Manager.Properties.Resources.database_connect;
            }
            else
            {
                this.tsBtnFilter.Image = global::Volere_Manager.Properties.Resources.database;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRemove_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mainForm.showReqById(qOtoolStripTextBox.Text);
        }
    }
}
