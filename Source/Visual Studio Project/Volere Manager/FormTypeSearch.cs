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
    public partial class FormTypesSearch: Form
    {
        FormMain mainForm;
        String lastSearch = "";
        Boolean initMode;

        public FormTypesSearch(FormMain _mainForm)
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
                           where r.Used == true
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in reqTypesTree.Nodes)
            {
                 if (node.Checked)
                    {
                        node.Expand();
                    }
            }
        }

    }
}
