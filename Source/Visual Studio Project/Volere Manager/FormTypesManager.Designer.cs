namespace Volere_Manager
{
    partial class FormTypesManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reqTypesTree = new System.Windows.Forms.TreeView();
            this.ctxMenuReqTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandWhereSelectedStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBoxAutoExpand = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pDelete = new System.Windows.Forms.PictureBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.selectSearchResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.ctxMenuReqTree.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reqTypesTree);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 507);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requirement Types";
            // 
            // reqTypesTree
            // 
            this.reqTypesTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reqTypesTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reqTypesTree.CheckBoxes = true;
            this.reqTypesTree.ContextMenuStrip = this.ctxMenuReqTree;
            this.reqTypesTree.FullRowSelect = true;
            this.reqTypesTree.Location = new System.Drawing.Point(6, 19);
            this.reqTypesTree.Name = "reqTypesTree";
            this.reqTypesTree.Size = new System.Drawing.Size(372, 482);
            this.reqTypesTree.TabIndex = 8;
            this.reqTypesTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.reqTypesTree_AfterCheck);
            // 
            // ctxMenuReqTree
            // 
            this.ctxMenuReqTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.selectSearchResultsToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.toolStripSeparator1,
            this.expandAllToolStripMenuItem,
            this.expandWhereSelectedStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.ctxMenuReqTree.Name = "ctxMenuReqTree";
            this.ctxMenuReqTree.Size = new System.Drawing.Size(201, 164);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectNoneToolStripMenuItem.Text = "Select None";
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // expandWhereSelectedStripMenuItem
            // 
            this.expandWhereSelectedStripMenuItem.Name = "expandWhereSelectedStripMenuItem";
            this.expandWhereSelectedStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.expandWhereSelectedStripMenuItem.Text = "Expand Where Selected";
            this.expandWhereSelectedStripMenuItem.Click += new System.EventHandler(this.expandWhereSelextedStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(302, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(221, 580);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 24);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chBoxAutoExpand);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(2, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 55);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // chBoxAutoExpand
            // 
            this.chBoxAutoExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chBoxAutoExpand.AutoSize = true;
            this.chBoxAutoExpand.Checked = true;
            this.chBoxAutoExpand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxAutoExpand.Location = new System.Drawing.Point(285, 25);
            this.chBoxAutoExpand.Name = "chBoxAutoExpand";
            this.chBoxAutoExpand.Size = new System.Drawing.Size(87, 17);
            this.chBoxAutoExpand.TabIndex = 2;
            this.chBoxAutoExpand.Text = "Auto Expand";
            this.chBoxAutoExpand.UseVisualStyleBackColor = true;
            this.chBoxAutoExpand.CheckedChanged += new System.EventHandler(this.chBoxAutoExpand_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(48, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pDelete
            // 
            this.pDelete.Image = global::Volere_Manager.Properties.Resources.bullet_error;
            this.pDelete.Location = new System.Drawing.Point(12, 580);
            this.pDelete.Name = "pDelete";
            this.pDelete.Size = new System.Drawing.Size(16, 16);
            this.pDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pDelete.TabIndex = 21;
            this.pDelete.TabStop = false;
            this.pDelete.Visible = false;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDelete.Location = new System.Drawing.Point(31, 581);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(175, 13);
            this.lblDelete.TabIndex = 22;
            this.lblDelete.Text = "Some Requirements will be deleted!";
            this.lblDelete.Visible = false;
            // 
            // selectSearchResultsToolStripMenuItem
            // 
            this.selectSearchResultsToolStripMenuItem.Name = "selectSearchResultsToolStripMenuItem";
            this.selectSearchResultsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectSearchResultsToolStripMenuItem.Text = "Select Search Results";
            this.selectSearchResultsToolStripMenuItem.Click += new System.EventHandler(this.selectSearchResultsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // FormTypesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 616);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.pDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MinimizeBox = false;
            this.Name = "FormTypesManager";
            this.ShowInTaskbar = false;
            this.Text = "Requirement Types Manager";
            this.Load += new System.EventHandler(this.FormTypesManager_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTypesManager_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ctxMenuReqTree.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView reqTypesTree;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chBoxAutoExpand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.ContextMenuStrip ctxMenuReqTree;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandWhereSelectedStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSearchResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}