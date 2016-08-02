namespace Volere_Manager
{
    partial class FormReqManagerFilters
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ctxMenuSearchStrings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearSearchStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchStrings = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ctxMenuConflicts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearConflictsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConflictsIDs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxConflicts = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ctxMenuPriorities = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxDissatisfaction = new System.Windows.Forms.ComboBox();
            this.cBoxPriority = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxSatisfaction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctxMenuCreated = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateCreatedFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCreatedTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBoxAutoExpand = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.reqTypesTree = new System.Windows.Forms.TreeView();
            this.ctxMenuReqTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSearchResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandWhereSelectedStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDisable = new System.Windows.Forms.Button();
            this.ctxMenuLast = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLastEditedDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dateLastFrom = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateLastTo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ctxMenuOriginator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxOriginator = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.ctxMenuSearchStrings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.ctxMenuConflicts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ctxMenuPriorities.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctxMenuCreated.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.ctxMenuReqTree.SuspendLayout();
            this.ctxMenuLast.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.ctxMenuOriginator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.ContextMenuStrip = this.ctxMenuSearchStrings;
            this.groupBox5.Controls.Add(this.txtSearchStrings);
            this.groupBox5.Location = new System.Drawing.Point(260, 396);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 61);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contains String";
            // 
            // ctxMenuSearchStrings
            // 
            this.ctxMenuSearchStrings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSearchStringsToolStripMenuItem});
            this.ctxMenuSearchStrings.Name = "ctxMenuSearchStrings";
            this.ctxMenuSearchStrings.Size = new System.Drawing.Size(183, 48);
            // 
            // clearSearchStringsToolStripMenuItem
            // 
            this.clearSearchStringsToolStripMenuItem.Name = "clearSearchStringsToolStripMenuItem";
            this.clearSearchStringsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.clearSearchStringsToolStripMenuItem.Text = "&Clear Search Strings";
            this.clearSearchStringsToolStripMenuItem.Click += new System.EventHandler(this.clearSearchStringsToolStripMenuItem_Click);
            // 
            // txtSearchStrings
            // 
            this.txtSearchStrings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchStrings.ContextMenuStrip = this.ctxMenuSearchStrings;
            this.txtSearchStrings.Location = new System.Drawing.Point(10, 20);
            this.txtSearchStrings.Multiline = true;
            this.txtSearchStrings.Name = "txtSearchStrings";
            this.txtSearchStrings.Size = new System.Drawing.Size(188, 35);
            this.txtSearchStrings.TabIndex = 0;
            this.txtSearchStrings.TextChanged += new System.EventHandler(this.txtSearchStrings_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.ContextMenuStrip = this.ctxMenuConflicts;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtConflictsIDs);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cBoxConflicts);
            this.groupBox4.Location = new System.Drawing.Point(260, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 89);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Conflicts:";
            // 
            // ctxMenuConflicts
            // 
            this.ctxMenuConflicts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearConflictsToolStripMenuItem});
            this.ctxMenuConflicts.Name = "ctxMenuConflicts";
            this.ctxMenuConflicts.Size = new System.Drawing.Size(155, 26);
            // 
            // clearConflictsToolStripMenuItem
            // 
            this.clearConflictsToolStripMenuItem.Name = "clearConflictsToolStripMenuItem";
            this.clearConflictsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clearConflictsToolStripMenuItem.Text = "Clear Conflicts";
            this.clearConflictsToolStripMenuItem.Click += new System.EventHandler(this.clearConflictsToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "(e.g. \"5;10,33;16\")";
            // 
            // txtConflictsIDs
            // 
            this.txtConflictsIDs.Enabled = false;
            this.txtConflictsIDs.Location = new System.Drawing.Point(72, 42);
            this.txtConflictsIDs.Name = "txtConflictsIDs";
            this.txtConflictsIDs.Size = new System.Drawing.Size(122, 20);
            this.txtConflictsIDs.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Conflicting:";
            // 
            // cBoxConflicts
            // 
            this.cBoxConflicts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxConflicts.FormattingEnabled = true;
            this.cBoxConflicts.Items.AddRange(new object[] {
            "",
            "None",
            "Any",
            "Following:"});
            this.cBoxConflicts.Location = new System.Drawing.Point(72, 19);
            this.cBoxConflicts.Name = "cBoxConflicts";
            this.cBoxConflicts.Size = new System.Drawing.Size(124, 21);
            this.cBoxConflicts.TabIndex = 0;
            this.cBoxConflicts.SelectedIndexChanged += new System.EventHandler(this.cBoxConflicts_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.ContextMenuStrip = this.ctxMenuPriorities;
            this.groupBox3.Controls.Add(this.cBoxDissatisfaction);
            this.groupBox3.Controls.Add(this.cBoxPriority);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cBoxSatisfaction);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(260, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 102);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Priorities";
            // 
            // ctxMenuPriorities
            // 
            this.ctxMenuPriorities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearPToolStripMenuItem});
            this.ctxMenuPriorities.Name = "ctxMenuPriorities";
            this.ctxMenuPriorities.Size = new System.Drawing.Size(155, 26);
            // 
            // clearPToolStripMenuItem
            // 
            this.clearPToolStripMenuItem.Name = "clearPToolStripMenuItem";
            this.clearPToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clearPToolStripMenuItem.Text = "&Clear Priorities";
            this.clearPToolStripMenuItem.Click += new System.EventHandler(this.clearPToolStripMenuItem_Click);
            // 
            // cBoxDissatisfaction
            // 
            this.cBoxDissatisfaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDissatisfaction.FormattingEnabled = true;
            this.cBoxDissatisfaction.Items.AddRange(new object[] {
            "",
            "(blank)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBoxDissatisfaction.Location = new System.Drawing.Point(137, 45);
            this.cBoxDissatisfaction.Name = "cBoxDissatisfaction";
            this.cBoxDissatisfaction.Size = new System.Drawing.Size(59, 21);
            this.cBoxDissatisfaction.TabIndex = 10;
            this.cBoxDissatisfaction.SelectedIndexChanged += new System.EventHandler(this.cBoxDissatisfaction_SelectedIndexChanged);
            // 
            // cBoxPriority
            // 
            this.cBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriority.FormattingEnabled = true;
            this.cBoxPriority.Items.AddRange(new object[] {
            "",
            "(blank)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBoxPriority.Location = new System.Drawing.Point(137, 72);
            this.cBoxPriority.Name = "cBoxPriority";
            this.cBoxPriority.Size = new System.Drawing.Size(59, 21);
            this.cBoxPriority.TabIndex = 9;
            this.cBoxPriority.SelectedIndexChanged += new System.EventHandler(this.cBoxPriority_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Customer Dissatisfaction:";
            // 
            // cBoxSatisfaction
            // 
            this.cBoxSatisfaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSatisfaction.FormattingEnabled = true;
            this.cBoxSatisfaction.Items.AddRange(new object[] {
            "",
            "(blank)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBoxSatisfaction.Location = new System.Drawing.Point(137, 18);
            this.cBoxSatisfaction.Name = "cBoxSatisfaction";
            this.cBoxSatisfaction.Size = new System.Drawing.Size(59, 21);
            this.cBoxSatisfaction.TabIndex = 4;
            this.cBoxSatisfaction.SelectedIndexChanged += new System.EventHandler(this.cBoxSatisfaction_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Satisfaction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Priority:";
            // 
            // btnEnable
            // 
            this.btnEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnable.Location = new System.Drawing.Point(272, 531);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(56, 32);
            this.btnEnable.TabIndex = 15;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.ContextMenuStrip = this.ctxMenuCreated;
            this.groupBox1.Controls.Add(this.dateCreatedFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateCreatedTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(260, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 89);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Created";
            // 
            // ctxMenuCreated
            // 
            this.ctxMenuCreated.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
            this.ctxMenuCreated.Name = "ctxMenuPriorities";
            this.ctxMenuCreated.Size = new System.Drawing.Size(184, 26);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearAllToolStripMenuItem.Text = "&Clear Created Dates";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // dateCreatedFrom
            // 
            this.dateCreatedFrom.Checked = false;
            this.dateCreatedFrom.Location = new System.Drawing.Point(43, 19);
            this.dateCreatedFrom.Name = "dateCreatedFrom";
            this.dateCreatedFrom.ShowCheckBox = true;
            this.dateCreatedFrom.Size = new System.Drawing.Size(153, 20);
            this.dateCreatedFrom.TabIndex = 2;
            this.dateCreatedFrom.ValueChanged += new System.EventHandler(this.dateCreatedFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // dateCreatedTo
            // 
            this.dateCreatedTo.Checked = false;
            this.dateCreatedTo.Location = new System.Drawing.Point(43, 45);
            this.dateCreatedTo.Name = "dateCreatedTo";
            this.dateCreatedTo.ShowCheckBox = true;
            this.dateCreatedTo.Size = new System.Drawing.Size(153, 20);
            this.dateCreatedTo.TabIndex = 1;
            this.dateCreatedTo.ValueChanged += new System.EventHandler(this.dateCreatedTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chBoxAutoExpand);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(5, 521);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 55);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // chBoxAutoExpand
            // 
            this.chBoxAutoExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chBoxAutoExpand.AutoSize = true;
            this.chBoxAutoExpand.Checked = true;
            this.chBoxAutoExpand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxAutoExpand.Location = new System.Drawing.Point(150, 25);
            this.chBoxAutoExpand.Name = "chBoxAutoExpand";
            this.chBoxAutoExpand.Size = new System.Drawing.Size(87, 17);
            this.chBoxAutoExpand.TabIndex = 2;
            this.chBoxAutoExpand.Text = "Auto Expand";
            this.chBoxAutoExpand.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Text:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(48, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(96, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.reqTypesTree);
            this.groupBox6.Location = new System.Drawing.Point(6, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(248, 513);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Requirement Types";
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
            this.reqTypesTree.Size = new System.Drawing.Size(233, 488);
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
            this.ctxMenuReqTree.Size = new System.Drawing.Size(201, 142);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // selectSearchResultsToolStripMenuItem
            // 
            this.selectSearchResultsToolStripMenuItem.Name = "selectSearchResultsToolStripMenuItem";
            this.selectSearchResultsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectSearchResultsToolStripMenuItem.Text = "Select Search Results";
            this.selectSearchResultsToolStripMenuItem.Click += new System.EventHandler(this.selectSearchResultsToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectNoneToolStripMenuItem.Text = "Select None";
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDisable
            // 
            this.btnDisable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisable.Location = new System.Drawing.Point(334, 531);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(56, 32);
            this.btnDisable.TabIndex = 24;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // ctxMenuLast
            // 
            this.ctxMenuLast.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLastEditedDatesToolStripMenuItem});
            this.ctxMenuLast.Name = "ctxMenuPriorities";
            this.ctxMenuLast.Size = new System.Drawing.Size(198, 26);
            // 
            // clearLastEditedDatesToolStripMenuItem
            // 
            this.clearLastEditedDatesToolStripMenuItem.Name = "clearLastEditedDatesToolStripMenuItem";
            this.clearLastEditedDatesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.clearLastEditedDatesToolStripMenuItem.Text = "Clear Last Edited Dates";
            this.clearLastEditedDatesToolStripMenuItem.Click += new System.EventHandler(this.clearLastEditedDatesToolStripMenuItem_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.ContextMenuStrip = this.ctxMenuLast;
            this.groupBox7.Controls.Add(this.dateLastFrom);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.dateLastTo);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(260, 206);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(204, 89);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Last Edited";
            // 
            // dateLastFrom
            // 
            this.dateLastFrom.Checked = false;
            this.dateLastFrom.Location = new System.Drawing.Point(43, 19);
            this.dateLastFrom.Name = "dateLastFrom";
            this.dateLastFrom.ShowCheckBox = true;
            this.dateLastFrom.Size = new System.Drawing.Size(153, 20);
            this.dateLastFrom.TabIndex = 2;
            this.dateLastFrom.ValueChanged += new System.EventHandler(this.dateLastFrom_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "From:";
            // 
            // dateLastTo
            // 
            this.dateLastTo.Checked = false;
            this.dateLastTo.Location = new System.Drawing.Point(43, 45);
            this.dateLastTo.Name = "dateLastTo";
            this.dateLastTo.ShowCheckBox = true;
            this.dateLastTo.Size = new System.Drawing.Size(153, 20);
            this.dateLastTo.TabIndex = 1;
            this.dateLastTo.ValueChanged += new System.EventHandler(this.dateLastTo_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "To:";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.ContextMenuStrip = this.ctxMenuOriginator;
            this.groupBox8.Controls.Add(this.cBoxOriginator);
            this.groupBox8.Location = new System.Drawing.Point(260, 463);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(204, 51);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Originator";
            // 
            // ctxMenuOriginator
            // 
            this.ctxMenuOriginator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ctxMenuOriginator.Name = "ctxMenuOriginator";
            this.ctxMenuOriginator.Size = new System.Drawing.Size(162, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem1.Text = "Clear Originator";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cBoxOriginator
            // 
            this.cBoxOriginator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxOriginator.FormattingEnabled = true;
            this.cBoxOriginator.Location = new System.Drawing.Point(12, 20);
            this.cBoxOriginator.Name = "cBoxOriginator";
            this.cBoxOriginator.Size = new System.Drawing.Size(186, 21);
            this.cBoxOriginator.TabIndex = 0;
            this.cBoxOriginator.TextChanged += new System.EventHandler(this.cBoxOriginator_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(396, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReqManagerFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(476, 578);
            this.CloseButton = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnEnable);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Float;
            this.HideOnClose = true;
            this.MinimumSize = new System.Drawing.Size(448, 470);
            this.Name = "FormReqManagerFilters";
            this.TabText = "Requirements Filter";
            this.Text = "Requirements Filter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormReqManagerFilters_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ctxMenuSearchStrings.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ctxMenuConflicts.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ctxMenuPriorities.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ctxMenuCreated.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ctxMenuReqTree.ResumeLayout(false);
            this.ctxMenuLast.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ctxMenuOriginator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSearchStrings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConflictsIDs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxConflicts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxDissatisfaction;
        private System.Windows.Forms.ComboBox cBoxPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxSatisfaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateCreatedFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateCreatedTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chBoxAutoExpand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TreeView reqTypesTree;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.ContextMenuStrip ctxMenuReqTree;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSearchResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandWhereSelectedStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMenuPriorities;
        private System.Windows.Forms.ContextMenuStrip ctxMenuCreated;
        private System.Windows.Forms.ContextMenuStrip ctxMenuLast;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dateLastFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateLastTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem clearPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLastEditedDatesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMenuSearchStrings;
        private System.Windows.Forms.ToolStripMenuItem clearSearchStringsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cBoxOriginator;
        private System.Windows.Forms.ContextMenuStrip ctxMenuConflicts;
        private System.Windows.Forms.ToolStripMenuItem clearConflictsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMenuOriginator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}