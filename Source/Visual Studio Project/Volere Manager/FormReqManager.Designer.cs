namespace Volere_Manager
{
    partial class FormReqManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsReq = new System.Windows.Forms.ToolStrip();
            this.tsBtnFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.qOtoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridRequirements = new System.Windows.Forms.DataGridView();
            this.headerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reqMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reqMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequirements)).BeginInit();
            this.reqMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsReq
            // 
            this.tsReq.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFilter,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnRemove,
            this.btnOpen,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.qOtoolStripTextBox,
            this.toolStripButton1});
            this.tsReq.Location = new System.Drawing.Point(0, 0);
            this.tsReq.Name = "tsReq";
            this.tsReq.Size = new System.Drawing.Size(400, 25);
            this.tsReq.TabIndex = 0;
            this.tsReq.Text = "tsReq";
            // 
            // tsBtnFilter
            // 
            this.tsBtnFilter.Image = global::Volere_Manager.Properties.Resources.database;
            this.tsBtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilter.Name = "tsBtnFilter";
            this.tsBtnFilter.Size = new System.Drawing.Size(51, 22);
            this.tsBtnFilter.Text = "Filter";
            this.tsBtnFilter.Click += new System.EventHandler(this.tsBtnFilter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Volere_Manager.Properties.Resources.database_add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::Volere_Manager.Properties.Resources.database_delete;
            this.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(66, 22);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::Volere_Manager.Properties.Resources.database_go;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(53, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel1.Text = "#";
            // 
            // qOtoolStripTextBox
            // 
            this.qOtoolStripTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.qOtoolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qOtoolStripTextBox.MaxLength = 5;
            this.qOtoolStripTextBox.Name = "qOtoolStripTextBox";
            this.qOtoolStripTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qOtoolStripTextBox.Size = new System.Drawing.Size(60, 25);
            this.qOtoolStripTextBox.Click += new System.EventHandler(this.qOtoolStripTextBox_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Volere_Manager.Properties.Resources.database_go;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridRequirements
            // 
            this.dataGridRequirements.AllowUserToAddRows = false;
            this.dataGridRequirements.AllowUserToDeleteRows = false;
            this.dataGridRequirements.AllowUserToOrderColumns = true;
            this.dataGridRequirements.AllowUserToResizeRows = false;
            this.dataGridRequirements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRequirements.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridRequirements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRequirements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRequirements.ContextMenuStrip = this.headerMenu;
            this.dataGridRequirements.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRequirements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRequirements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRequirements.Location = new System.Drawing.Point(0, 25);
            this.dataGridRequirements.Name = "dataGridRequirements";
            this.dataGridRequirements.ReadOnly = true;
            this.dataGridRequirements.RowHeadersVisible = false;
            this.dataGridRequirements.RowTemplate.ContextMenuStrip = this.reqMenu;
            this.dataGridRequirements.RowTemplate.Height = 17;
            this.dataGridRequirements.RowTemplate.ReadOnly = true;
            this.dataGridRequirements.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRequirements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRequirements.Size = new System.Drawing.Size(400, 248);
            this.dataGridRequirements.TabIndex = 1;
            this.dataGridRequirements.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRequirements_CellContentDoubleClick);
            this.dataGridRequirements.SelectionChanged += new System.EventHandler(this.dataGridRequirements_SelectionChanged);
            // 
            // headerMenu
            // 
            this.headerMenu.Name = "headerMenu";
            this.headerMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // reqMenu
            // 
            this.reqMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reqMenuToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.reqMenu.Name = "reqMenu";
            this.reqMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // reqMenuToolStripMenuItem
            // 
            this.reqMenuToolStripMenuItem.Name = "reqMenuToolStripMenuItem";
            this.reqMenuToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.reqMenuToolStripMenuItem.Text = "Open";
            this.reqMenuToolStripMenuItem.Click += new System.EventHandler(this.reqMenuToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // FormReqManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 273);
            this.Controls.Add(this.dataGridRequirements);
            this.Controls.Add(this.tsReq);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.HideOnClose = true;
            this.Name = "FormReqManager";
            this.TabText = "Requirements Manager";
            this.Text = "Requirements Manager";
            this.tsReq.ResumeLayout(false);
            this.tsReq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequirements)).EndInit();
            this.reqMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsReq;
        private System.Windows.Forms.ToolStripButton tsBtnFilter;
        private System.Windows.Forms.DataGridView dataGridRequirements;
        private System.Windows.Forms.ContextMenuStrip reqMenu;
        private System.Windows.Forms.ToolStripMenuItem reqMenuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip headerMenu;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox qOtoolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}