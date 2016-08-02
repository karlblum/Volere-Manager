namespace Volere_Manager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newReqStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporttxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementsManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tSSCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(898, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "msMainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.newReqStripMenuItem,
            this.saveStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newProjectToolStripMenuItem.Image")));
            this.newProjectToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newProjectToolStripMenuItem.Text = "&New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openProjectToolStripMenuItem.Image")));
            this.openProjectToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openProjectToolStripMenuItem.Text = "&Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Image = global::Volere_Manager.Properties.Resources.folder;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeToolStripMenuItem.Text = "C&lose Project";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // newReqStripMenuItem
            // 
            this.newReqStripMenuItem.Enabled = false;
            this.newReqStripMenuItem.Name = "newReqStripMenuItem";
            this.newReqStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newReqStripMenuItem.Text = "New &Requirement";
            this.newReqStripMenuItem.Click += new System.EventHandler(this.newReqStripMenuItem_Click);
            // 
            // saveStripMenuItem
            // 
            this.saveStripMenuItem.Enabled = false;
            this.saveStripMenuItem.Name = "saveStripMenuItem";
            this.saveStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveStripMenuItem.Text = "&Save Requirement";
            this.saveStripMenuItem.Click += new System.EventHandler(this.saveStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.exporttxtToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Visible = false;
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.customizeToolStripMenuItem.Text = "&Types Manager";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // exporttxtToolStripMenuItem
            // 
            this.exporttxtToolStripMenuItem.Name = "exporttxtToolStripMenuItem";
            this.exporttxtToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exporttxtToolStripMenuItem.Text = "Export Active Requirements";
            this.exporttxtToolStripMenuItem.Click += new System.EventHandler(this.exporttxtToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requirementsManagerToolStripMenuItem,
            this.advisorToolStripMenuItem,
            this.previewerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Visible = false;
            // 
            // requirementsManagerToolStripMenuItem
            // 
            this.requirementsManagerToolStripMenuItem.Name = "requirementsManagerToolStripMenuItem";
            this.requirementsManagerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.requirementsManagerToolStripMenuItem.Text = "Requirements Manager";
            this.requirementsManagerToolStripMenuItem.Click += new System.EventHandler(this.requirementsManagerToolStripMenuItem_Click);
            // 
            // advisorToolStripMenuItem
            // 
            this.advisorToolStripMenuItem.Name = "advisorToolStripMenuItem";
            this.advisorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.advisorToolStripMenuItem.Text = "Advisor";
            this.advisorToolStripMenuItem.Visible = false;
            this.advisorToolStripMenuItem.Click += new System.EventHandler(this.advisorToolStripMenuItem_Click);
            // 
            // previewerToolStripMenuItem
            // 
            this.previewerToolStripMenuItem.Name = "previewerToolStripMenuItem";
            this.previewerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.previewerToolStripMenuItem.Text = "&Preview";
            this.previewerToolStripMenuItem.Click += new System.EventHandler(this.previewerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSCounter});
            this.ssMain.Location = new System.Drawing.Point(0, 701);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(898, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "ssMain";
            // 
            // tSSCounter
            // 
            this.tSSCounter.Name = "tSSCounter";
            this.tSSCounter.Size = new System.Drawing.Size(0, 17);
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBottomPortion = 150;
            this.dockPanel.DockLeftPortion = 200;
            this.dockPanel.DockRightPortion = 200;
            this.dockPanel.DockTopPortion = 150;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(898, 677);
            this.dockPanel.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "export.html";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 723);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "FormMain";
            this.Text = "Volere Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementsManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advisorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem newReqStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel tSSCounter;
        private System.Windows.Forms.ToolStripMenuItem exporttxtToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

