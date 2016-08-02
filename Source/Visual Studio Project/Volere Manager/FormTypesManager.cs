using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Volere_Manager
{
    public partial class FormTypesManager : Form
    {
        FormMain mainForm;
        String lastSearch = "";
        Boolean initMode;
        List<string> currentReqTypes = new List<string>();
        List<string> currentReqTypesRemoved = new List<string>();
        List<string> currentReqTypesAdded = new List<string>();

        List<string> usedReqTypes = new List<string>();
        List<string> usedReqTypesRemoved = new List<string>();

        public FormTypesManager(FormMain _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            initMode = true;
            setReqTree();
            initMode = false;
        }

        private void setReqTree()
        {
            var reqTypes = from r in mainForm.dc.Req_Types
                           orderby r.Nr ascending,
                           r.SubNr ascending
                           select r;

            TreeNode mainNode = new TreeNode();
            foreach (var r in reqTypes)
            {
                if (r.SubNr == 0)
                {
                    mainNode = this.reqTypesTree.Nodes.Add(r.Nr + ". " + r.Name);
                    mainNode.Tag = r.Id.ToString();
                    continue;
                }
                TreeNode node = new TreeNode();
                if (r.Used.Value)
                {
                    node.Checked = true;
                    mainNode.Checked = true;
                }
                node.Text = r.Nr + "." + r.SubNr + ". " + r.Name;
                node.Tag = r.Id.ToString();
                mainNode.Nodes.Add(node);
            }

            var used = (from req in mainForm.dc.Req
                        select req.Req_Types.Id.ToString()).Distinct();


            usedReqTypes.AddRange(used);

            var allSelected =  from req in mainForm.dc.Req_Types
                               where req.Used == true
                               select req.Id.ToString();
            currentReqTypes.AddRange(allSelected);

        }

        private void FormTypesManager_Load(object sender, EventArgs e)
        {
            mainForm.Enabled = false;
        }

        private void FormTypesManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lastSearch != txtSearch.Text)
            {
                search();
            }
        }

        private void search()
        {
            foreach (TreeNode node in reqTypesTree.Nodes)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    node.Collapse();
                    subNode.ForeColor = Color.Black;
                }

                if (txtSearch.Text != "")
                {
                    foreach (TreeNode subNode in node.Nodes)
                    {
                        if (subNode.Text.ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            if (chBoxAutoExpand.Checked)
                            {
                                node.Expand();
                            }
                            subNode.ForeColor = Color.Blue;
                        }
                    }
                }
            }

            lastSearch = txtSearch.Text;
            timer1.Stop();
        }
        private void alertRequirementsDelete(String nodeId, Boolean add)
        {
            if (add)
            {
                usedReqTypesRemoved.Remove(nodeId);
                currentReqTypesRemoved.Remove(nodeId);
                if (!currentReqTypes.Contains(nodeId) && !currentReqTypesAdded.Contains(nodeId))   {
                    currentReqTypesAdded.Add(nodeId);
                }
            }
            else
            {
                if(currentReqTypesAdded.Contains(nodeId)){
                    currentReqTypesAdded.Remove(nodeId);
                } else {
                    currentReqTypesRemoved.Add(nodeId);
                    if (usedReqTypes.Contains(nodeId)) usedReqTypesRemoved.Add(nodeId);
                }
            }


            if (usedReqTypesRemoved.Count == 0)
            {
                pDelete.Visible = false;
                lblDelete.Visible = false;
            }
            else
            {
                pDelete.Visible = true;
                lblDelete.Visible = true;
            }

        }

        private void chBoxAutoExpand_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            timer1.Start();
        }

        private void reqTypesTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null && e.Node.Checked)
            {
                if (!initMode)
                {
                    alertRequirementsDelete(e.Node.Tag.ToString(), true);
                    initMode = true;
                    e.Node.Parent.Checked = true;
                    initMode = false;
                }
            }
            else if (e.Node.Parent != null && !e.Node.Checked)
            {
                alertRequirementsDelete(e.Node.Tag.ToString(), false);
            }
            else if (e.Node.Parent == null && !initMode)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = e.Node.Checked;
                }
            }
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in reqTypesTree.Nodes)
            {
                tn.Checked = true;
            }
        }

        private void selectNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in reqTypesTree.Nodes)
            {
                tn.Checked = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Boolean deleteInterrupted = false;
            if (lblDelete.Visible)
            {
                DialogResult result = MessageBox.Show("Some requirements will be deleted!",
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                }
                else
                {
                    deleteInterrupted = true;
                }
            }

            if (!deleteInterrupted)
            {
                updateSelectedReqTypes();
                this.Close();
            }

        }

        private void updateSelectedReqTypes()
        {
            foreach (string added in currentReqTypesAdded)
            {
                var type = (from r in mainForm.dc.Req_Types
                                where r.Id == Convert.ToInt64(added)
                                select r).First<Req_Types>();
                type.Used = true;
            }
            mainForm.dc.SubmitChanges();

            foreach (string removed in currentReqTypesRemoved)
            {
                var type = (from r in mainForm.dc.Req_Types
                                 where r.Id == Convert.ToInt64(removed)
                                 select r).First<Req_Types>();
                type.Used = false;
            }
            mainForm.dc.SubmitChanges();

            var del = from r in mainForm.dc.Req
                             where r.Req_Types.Used == false
                             select r;

            foreach (Req r in del)
            {
                mainForm.closeReq(r, true);
            }

                mainForm.dc.Req.DeleteAllOnSubmit(del);
                mainForm.dc.SubmitChanges();
                mainForm.initDataUpdate();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in reqTypesTree.Nodes)
            {
                node.Expand();
            }
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in reqTypesTree.Nodes)
            {
                node.Collapse();
            }
        }

        private void expandWhereSelextedStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in reqTypesTree.Nodes)
            {
                 if (node.Checked)
                    {
                        node.Expand();
                    }
            }
        }

        private void selectSearchResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (TreeNode node in reqTypesTree.Nodes)
            {
                if (txtSearch.Text != "")
                {
                    foreach (TreeNode subNode in node.Nodes)
                    {
                        if (subNode.Text.ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            subNode.Checked = true;
                        }
                    }
                }
            }
        }

    }
}
