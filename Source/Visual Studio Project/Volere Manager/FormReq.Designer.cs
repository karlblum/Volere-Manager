namespace Volere_Manager
{
    partial class FormReq
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxReqType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtModified = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCreated = new System.Windows.Forms.TextBox();
            this.ctxMenuReq = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createDuplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnAddModify = new System.Windows.Forms.Button();
            this.lBoxResources = new System.Windows.Forms.ListBox();
            this.cBoxResMod = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBoxCustomerDissatisfaction = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxCustomerSatisfaction = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConflictAdd = new System.Windows.Forms.TextBox();
            this.btnRemoveConflict = new System.Windows.Forms.Button();
            this.btnAddConflict = new System.Windows.Forms.Button();
            this.lBoxConflicts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFitCriterion = new System.Windows.Forms.TextBox();
            this.txtRationale = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUseCases = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxOriginator = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ctxMenuReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(16, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 20);
            this.txtId.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Requirement Type:";
            // 
            // cBoxReqType
            // 
            this.cBoxReqType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxReqType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBoxReqType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxReqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxReqType.FormattingEnabled = true;
            this.cBoxReqType.Location = new System.Drawing.Point(258, 20);
            this.cBoxReqType.Name = "cBoxReqType";
            this.cBoxReqType.Size = new System.Drawing.Size(347, 21);
            this.cBoxReqType.TabIndex = 0;
            this.cBoxReqType.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Created:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "#";
            // 
            // txtModified
            // 
            this.txtModified.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModified.Enabled = false;
            this.txtModified.Location = new System.Drawing.Point(139, 23);
            this.txtModified.Multiline = true;
            this.txtModified.Name = "txtModified";
            this.txtModified.Size = new System.Drawing.Size(98, 17);
            this.txtModified.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Last Edited:";
            // 
            // txtCreated
            // 
            this.txtCreated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreated.Enabled = false;
            this.txtCreated.Location = new System.Drawing.Point(139, 3);
            this.txtCreated.Multiline = true;
            this.txtCreated.Name = "txtCreated";
            this.txtCreated.Size = new System.Drawing.Size(98, 17);
            this.txtCreated.TabIndex = 22;
            // 
            // ctxMenuReq
            // 
            this.ctxMenuReq.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdfToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.createDuplicateToolStripMenuItem});
            this.ctxMenuReq.Name = "ctxMenuReq";
            this.ctxMenuReq.Size = new System.Drawing.Size(148, 142);
            // 
            // asdfToolStripMenuItem
            // 
            this.asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            this.asdfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asdfToolStripMenuItem.Text = "&Save";
            this.asdfToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeThisToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem1.Text = "Close All";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeAllToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Close Others";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // createDuplicateToolStripMenuItem
            // 
            this.createDuplicateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.createDuplicateToolStripMenuItem.Name = "createDuplicateToolStripMenuItem";
            this.createDuplicateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createDuplicateToolStripMenuItem.Text = "&Create...";
            this.createDuplicateToolStripMenuItem.Click += new System.EventHandler(this.createDuplicateToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Volere_Manager.Properties.Resources.zoom;
            this.pictureBox1.Location = new System.Drawing.Point(607, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btnCancelEdit);
            this.tabPage2.Controls.Add(this.btnAddModify);
            this.tabPage2.Controls.Add(this.lBoxResources);
            this.tabPage2.Controls.Add(this.cBoxResMod);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resources";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelEdit.Location = new System.Drawing.Point(593, 303);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 27);
            this.btnCancelEdit.TabIndex = 36;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnAddModify
            // 
            this.btnAddModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddModify.Location = new System.Drawing.Point(512, 303);
            this.btnAddModify.Name = "btnAddModify";
            this.btnAddModify.Size = new System.Drawing.Size(75, 27);
            this.btnAddModify.TabIndex = 35;
            this.btnAddModify.Text = "Add";
            this.btnAddModify.UseVisualStyleBackColor = true;
            this.btnAddModify.Click += new System.EventHandler(this.btnAddModify_Click);
            // 
            // lBoxResources
            // 
            this.lBoxResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxResources.ContextMenuStrip = this.contextMenuStrip1;
            this.lBoxResources.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxResources.FormattingEnabled = true;
            this.lBoxResources.ItemHeight = 18;
            this.lBoxResources.Location = new System.Drawing.Point(7, 0);
            this.lBoxResources.Name = "lBoxResources";
            this.lBoxResources.Size = new System.Drawing.Size(665, 292);
            this.lBoxResources.TabIndex = 34;
            // 
            // cBoxResMod
            // 
            this.cBoxResMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxResMod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxResMod.FormattingEnabled = true;
            this.cBoxResMod.Items.AddRange(new object[] {
            "www.neti.ee"});
            this.cBoxResMod.Location = new System.Drawing.Point(6, 304);
            this.cBoxResMod.Name = "cBoxResMod";
            this.cBoxResMod.Size = new System.Drawing.Size(500, 26);
            this.cBoxResMod.TabIndex = 30;
            this.cBoxResMod.SelectedIndexChanged += new System.EventHandler(this.cBoxResMod_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFitCriterion);
            this.tabPage1.Controls.Add(this.txtRationale);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.txtUseCases);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cBoxOriginator);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Requirement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cBoxCustomerDissatisfaction);
            this.groupBox4.Location = new System.Drawing.Point(444, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 51);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Dissatisfaction";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // cBoxCustomerDissatisfaction
            // 
            this.cBoxCustomerDissatisfaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxCustomerDissatisfaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCustomerDissatisfaction.FormattingEnabled = true;
            this.cBoxCustomerDissatisfaction.Location = new System.Drawing.Point(22, 19);
            this.cBoxCustomerDissatisfaction.Name = "cBoxCustomerDissatisfaction";
            this.cBoxCustomerDissatisfaction.Size = new System.Drawing.Size(83, 21);
            this.cBoxCustomerDissatisfaction.TabIndex = 0;
            this.cBoxCustomerDissatisfaction.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cBoxCustomerSatisfaction);
            this.groupBox3.Location = new System.Drawing.Point(444, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 51);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Satisfaction";
            // 
            // cBoxCustomerSatisfaction
            // 
            this.cBoxCustomerSatisfaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxCustomerSatisfaction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBoxCustomerSatisfaction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCustomerSatisfaction.CausesValidation = false;
            this.cBoxCustomerSatisfaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCustomerSatisfaction.Location = new System.Drawing.Point(22, 19);
            this.cBoxCustomerSatisfaction.MaxDropDownItems = 5;
            this.cBoxCustomerSatisfaction.Name = "cBoxCustomerSatisfaction";
            this.cBoxCustomerSatisfaction.Size = new System.Drawing.Size(83, 21);
            this.cBoxCustomerSatisfaction.TabIndex = 0;
            this.cBoxCustomerSatisfaction.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtConflictAdd);
            this.groupBox2.Controls.Add(this.btnRemoveConflict);
            this.groupBox2.Controls.Add(this.btnAddConflict);
            this.groupBox2.Controls.Add(this.lBoxConflicts);
            this.groupBox2.Location = new System.Drawing.Point(599, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(70, 186);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conflicts";
            // 
            // txtConflictAdd
            // 
            this.txtConflictAdd.Location = new System.Drawing.Point(7, 105);
            this.txtConflictAdd.Name = "txtConflictAdd";
            this.txtConflictAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtConflictAdd.Size = new System.Drawing.Size(56, 20);
            this.txtConflictAdd.TabIndex = 0;
            this.txtConflictAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemoveConflict
            // 
            this.btnRemoveConflict.Location = new System.Drawing.Point(7, 157);
            this.btnRemoveConflict.Name = "btnRemoveConflict";
            this.btnRemoveConflict.Size = new System.Drawing.Size(56, 23);
            this.btnRemoveConflict.TabIndex = 23;
            this.btnRemoveConflict.Text = "Remove";
            this.btnRemoveConflict.UseVisualStyleBackColor = true;
            this.btnRemoveConflict.Click += new System.EventHandler(this.btnRemoveConflict_Click);
            // 
            // btnAddConflict
            // 
            this.btnAddConflict.Location = new System.Drawing.Point(6, 131);
            this.btnAddConflict.Name = "btnAddConflict";
            this.btnAddConflict.Size = new System.Drawing.Size(57, 23);
            this.btnAddConflict.TabIndex = 21;
            this.btnAddConflict.Text = "Add";
            this.btnAddConflict.UseVisualStyleBackColor = true;
            this.btnAddConflict.Click += new System.EventHandler(this.btnAddConflict_Click);
            // 
            // lBoxConflicts
            // 
            this.lBoxConflicts.FormattingEnabled = true;
            this.lBoxConflicts.Location = new System.Drawing.Point(6, 20);
            this.lBoxConflicts.Name = "lBoxConflicts";
            this.lBoxConflicts.Size = new System.Drawing.Size(57, 82);
            this.lBoxConflicts.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cBoxPriority);
            this.groupBox1.Location = new System.Drawing.Point(444, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 51);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priority";
            // 
            // cBoxPriority
            // 
            this.cBoxPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriority.FormattingEnabled = true;
            this.cBoxPriority.Location = new System.Drawing.Point(22, 20);
            this.cBoxPriority.Name = "cBoxPriority";
            this.cBoxPriority.Size = new System.Drawing.Size(83, 21);
            this.cBoxPriority.TabIndex = 0;
            this.cBoxPriority.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description:";
            // 
            // txtFitCriterion
            // 
            this.txtFitCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFitCriterion.Location = new System.Drawing.Point(6, 302);
            this.txtFitCriterion.Multiline = true;
            this.txtFitCriterion.Name = "txtFitCriterion";
            this.txtFitCriterion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFitCriterion.Size = new System.Drawing.Size(432, 77);
            this.txtFitCriterion.TabIndex = 2;
            this.txtFitCriterion.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // txtRationale
            // 
            this.txtRationale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRationale.Location = new System.Drawing.Point(6, 206);
            this.txtRationale.Multiline = true;
            this.txtRationale.Name = "txtRationale";
            this.txtRationale.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRationale.Size = new System.Drawing.Size(432, 77);
            this.txtRationale.TabIndex = 1;
            this.txtRationale.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(6, 27);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(660, 160);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // txtUseCases
            // 
            this.txtUseCases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUseCases.Location = new System.Drawing.Point(335, 389);
            this.txtUseCases.Name = "txtUseCases";
            this.txtUseCases.Size = new System.Drawing.Size(334, 20);
            this.txtUseCases.TabIndex = 4;
            this.txtUseCases.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fit Criterion:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rationale:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Originator:";
            // 
            // cBoxOriginator
            // 
            this.cBoxOriginator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxOriginator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxOriginator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxOriginator.FormattingEnabled = true;
            this.cBoxOriginator.Location = new System.Drawing.Point(67, 389);
            this.cBoxOriginator.Name = "cBoxOriginator";
            this.cBoxOriginator.Size = new System.Drawing.Size(196, 21);
            this.cBoxOriginator.TabIndex = 3;
            this.cBoxOriginator.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Use cases:";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(5, 46);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(699, 424);
            this.tabControl.TabIndex = 30;
            // 
            // FormReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(707, 473);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModified);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cBoxReqType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCreated);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "FormReq";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.TabPageContextMenuStrip = this.ctxMenuReq;
            this.TabText = "New";
            this.Text = "New";
            this.Enter += new System.EventHandler(this.FormReq_Enter);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReq_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReq_FormClosing);
            this.ctxMenuReq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxReqType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCreated;
        private System.Windows.Forms.TextBox txtModified;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuReq;
        private System.Windows.Forms.ToolStripMenuItem asdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDuplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnAddModify;
        private System.Windows.Forms.ListBox lBoxResources;
        private System.Windows.Forms.ComboBox cBoxResMod;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFitCriterion;
        private System.Windows.Forms.TextBox txtRationale;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUseCases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxOriginator;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lBoxConflicts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cBoxCustomerDissatisfaction;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxCustomerSatisfaction;
        private System.Windows.Forms.ComboBox cBoxPriority;
        private System.Windows.Forms.Button btnRemoveConflict;
        private System.Windows.Forms.Button btnAddConflict;
        private System.Windows.Forms.TextBox txtConflictAdd;
    }
}