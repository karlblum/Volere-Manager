using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Volere_Manager
{
    public partial class NewWizard : Form
    {
        String lastSearch = "";
        FormMain mfSender;
        Boolean initMode;
        Boolean dbFileOK;
        public NewWizard(FormMain sender)
        {
            InitializeComponent();
            mfSender = sender;
            initMode = true;
            setReqTree();
            initMode = false;
            
        }

        private void setReqTree()
        {
            using (Blank db = new Blank(Application.StartupPath + "\\blank.sdf"))
            {
                var reqTypes = from r in db.Req_Types
                               orderby r.Nr ascending,
                               r.SubNr ascending
                               select r;

                TreeNode mainNode = new TreeNode();
                foreach (var r in reqTypes)
                {
                    
                if (r.SubNr == 0)
                {
                    mainNode = this.reqTypesTree.Nodes.Add(r.Nr + ". " + r.Name);
                    continue;
                }
                TreeNode node = new TreeNode();
                node.Text = r.Nr + "." + r.SubNr + ". " + r.Name;
                node.Tag = r.Id.ToString();
                mainNode.Nodes.Add(node);


                }   
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dbFileOK)
            {
                var blankDatabaseLocation = Application.StartupPath.ToString() + "/blank.sdf";
                System.IO.File.Copy(blankDatabaseLocation, saveDialog.FileName, true);

                SqlCeConnection _sqlCeConnnectionString = new SqlCeConnection(@"Data Source=" + saveDialog.FileName);

                using (Blank db = new Blank(_sqlCeConnnectionString))
                {
                    foreach (TreeNode node in this.reqTypesTree.Nodes)
                    {
                        foreach (TreeNode subNode in node.Nodes)
                        {
                            if (subNode.Checked)
                            {
                                //Märgistame algväärtustatud valikud uues salvestatud failis
                                var reqType = from reqTypes in db.Req_Types
                                              where reqTypes.Id == Convert.ToDouble(subNode.Tag.ToString())
                                              select reqTypes;

                                reqType.First().Used = true;
                            }

                        }

                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    mfSender.openProject(saveDialog.FileName);
                    this.Close();

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveDialog.ShowDialog();
        }

        private void saveDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtBoxFilename.Text = saveDialog.FileName.ToString();
            dbFileOK = true;
            btnCreate.Enabled = true;
        }

        private void NewWizard_Load(object sender, EventArgs e)
        {
            mfSender.Enabled = false;
        }

        private void NewWizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            mfSender.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            timer1.Start();
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

        private void reqTypesTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
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
    }
}
