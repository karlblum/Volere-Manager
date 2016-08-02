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
    public partial class FormReqManagerFilters : DockContent
    {
        FormMain mainForm;
        String lastSearch = "";
        Boolean initMode;
        Boolean filterStateChanged = false;

        public FormReqManagerFilters(FormMain mf)
        {
            mainForm = mf;
            InitializeComponent();

        }

        public void initData()
        {
            setReqTree();
        }

        public void setReqTree()
        {
            this.reqTypesTree.Nodes.Clear();
            var reqTypes = from r in mainForm.dc.Req_Types
                           orderby r.Nr ascending,
                           r.SubNr ascending
                           where r.Used == true || r.SubNr == 0
                           select r;

            TreeNode mainNode = new TreeNode();
            TreeNode subNode = null;
            foreach (var r in reqTypes)
            {
                if (r.SubNr == 0)
                {
                    if (subNode == null) this.reqTypesTree.Nodes.Remove(mainNode);
                    mainNode = new TreeNode(r.ToString());
                    mainNode.Checked = true;
                    this.reqTypesTree.Nodes.Add(mainNode);
                    subNode = null;
                    continue;
                }

                subNode = new TreeNode();
                subNode.Text = r.ToString();
                subNode.Tag = r.Id.ToString();
                subNode.Checked = true;
                mainNode.Nodes.Add(subNode);

            } 
            if (subNode == null) this.reqTypesTree.Nodes.Remove(mainNode);
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (validateConflictings() && validateSearchString())
            {
                this.saveFilterState();
                FilterState.filterActive = true;
                mainForm.filterStateChanged();
                mainForm.Enabled = true;
                this.Hide();
            }
        }

        private bool validateSearchString()
        {
            FilterState.searchString = txtSearchStrings.Text;
            return true;
        }

        private bool validateConflictings()
        {
            List<Int64> cIds = new List<Int64>();
            try
            {
                if (cBoxConflicts.SelectedIndex == 3)
                {
                    List<string> ids = txtConflictsIDs.Text.Split(';').ToList();
                    foreach (var i in ids)
                    {
                        cIds.Add(Convert.ToInt64(i));
                    }
                    FilterState.conflictingIds.Clear();
                    FilterState.conflictingIds.AddRange(cIds);
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Conflicting IDs not properly set",
"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void saveFilterState()
        {
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            timer1.Start();
        }

        private void reqTypesTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (!initMode)
            {
                filterStateChanged = true;
            }

            if (e.Node.Checked && !initMode)
            {
                FilterState.unCheckedIds.Remove(Convert.ToInt64(e.Node.Tag));
            }
            else if(!e.Node.Checked && !initMode)
            {
                FilterState.unCheckedIds.Add(Convert.ToInt64(e.Node.Tag));
            }

            if (e.Node.Parent != null && e.Node.Checked)
            {
                if (!initMode)
                {
                    initMode = true;
                    e.Node.Parent.Checked = true;
                    initMode = false;
                }
            }
            else if (e.Node.Parent == null && !initMode)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = e.Node.Checked;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Hide();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            FilterState.filterActive = false;
            mainForm.Enabled = true;
            mainForm.filterStateChanged();
            this.Hide();
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



        private void clearPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cBoxPriority.SelectedIndex = 0;
            cBoxSatisfaction.SelectedIndex = 0;
            cBoxDissatisfaction.SelectedIndex = 0;
        }

        private void dateCreatedFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!initMode)
            {
                filterStateChanged = true;
                if (dateCreatedFrom.Checked)
                {
                    FilterState.createdFrom = dateCreatedFrom.Value;
                }
                else
                {
                    FilterState.lastFrom = DateTime.MinValue;
                }
            }
        }

        private void dateCreatedTo_ValueChanged(object sender, EventArgs e)
        {
            if (!initMode)
            {
                filterStateChanged = true;
                if (dateCreatedTo.Checked)
                {
                    FilterState.createdTo = dateCreatedTo.Value;
                }
                else
                {
                    FilterState.createdTo = DateTime.MaxValue;
                }
            }
        }

        private void dateLastFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!initMode)
            {
                filterStateChanged = true;
                if (dateLastFrom.Checked)
                {
                    FilterState.lastFrom = dateLastFrom.Value;
                }
                else
                {
                    FilterState.lastFrom = DateTime.MinValue;
                }
            }
        }

        private void dateLastTo_ValueChanged(object sender, EventArgs e)
        {
            if (!initMode)
            {
                filterStateChanged = true;
                if (dateLastTo.Checked)
                {
                    FilterState.lastTo = dateLastTo.Value;
                }
                else
                {
                    FilterState.lastTo = DateTime.MaxValue;
                }
            }
        }
        private void txtSearchStrings_TextChanged(object sender, EventArgs e)
        {
            if (!initMode) filterStateChanged = true;
        }

        private void cBoxDissatisfaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initMode)
            {
                filterStateChanged = true;
                switch (cBoxDissatisfaction.SelectedIndex)
                {
                    case 0: FilterState.dissatisfaction = -1; break;
                    case 1: FilterState.dissatisfaction = 0; break;
                    default: FilterState.dissatisfaction = Convert.ToByte(cBoxDissatisfaction.SelectedItem); break;

                }
            }
        }

        private void cBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initMode)
            {
                filterStateChanged = true;
                switch (cBoxPriority.SelectedIndex)
                {
                    case 0: FilterState.priority = -1; break;
                    case 1: FilterState.priority = 0; break;
                    default: FilterState.priority = Convert.ToByte(cBoxPriority.SelectedItem); break;

                }
            }
        }

        private void cBoxSatisfaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initMode)
            {
                filterStateChanged = true;
                switch (cBoxSatisfaction.SelectedIndex)
                {
                    case 0: FilterState.satisfaction = -1; break;
                    case 1: FilterState.satisfaction = 0; break;
                    default: FilterState.satisfaction = Convert.ToByte(cBoxSatisfaction.SelectedItem); break;

                }
            }
        }

        private void FormReqManagerFilters_Load(object sender, EventArgs e)
        {

        }

        private void txtConflictsIDs_Leave(object sender, EventArgs e)
        {
 
        }

        private void cBoxConflicts_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cBoxConflicts.SelectedIndex)
            {
                case 1:
                    txtConflictsIDs.Enabled = false;
                    FilterState.conflictAny = false;
                    FilterState.conflictNone = true;
                    FilterState.conflictingIds.Clear();
                    break;
                case 2:
                    txtConflictsIDs.Enabled = false;
                    FilterState.conflictAny = true;
                    FilterState.conflictNone = false;
                    FilterState.conflictingIds.Clear();
                    break;
                case 3:
                    txtConflictsIDs.Enabled = true;
                    FilterState.conflictAny = false;
                    FilterState.conflictNone = false;
                    break;
                default:
                    txtConflictsIDs.Enabled = false;
                    FilterState.conflictAny = false;
                    FilterState.conflictNone = false;
                    FilterState.conflictingIds.Clear();
                    break;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cBoxOriginator.Text = "";
        }

        private void clearConflictsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cBoxConflicts.SelectedIndex = 0;
            txtConflictsIDs.Text = "";
        }

        private void cBoxOriginator_TextChanged(object sender, EventArgs e)
        {
            FilterState.originator = cBoxOriginator.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearConflictsToolStripMenuItem_Click(sender, e);
            clearPToolStripMenuItem_Click(sender, e);
            selectAllToolStripMenuItem1_Click(sender, e);
            clearPToolStripMenuItem_Click(sender, e);
            clearAllToolStripMenuItem_Click(sender, e);
            clearLastEditedDatesToolStripMenuItem_Click(sender, e);
            clearSearchStringsToolStripMenuItem_Click(sender, e);
            toolStripMenuItem1_Click(sender, e);
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateCreatedFrom.Checked = false;
            dateCreatedTo.Checked = false;
        }

        private void clearLastEditedDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateLastFrom.Checked = false;
            dateLastTo.Checked = false;
        }

        private void clearSearchStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSearchStrings.Text = "";
        }

    }
}
