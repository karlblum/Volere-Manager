namespace Volere_Manager
{
    partial class FormPreview
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
            this.cBoxPreview = new System.Windows.Forms.ComboBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBoxPreview
            // 
            this.cBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxPreview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPreview.FormattingEnabled = true;
            this.cBoxPreview.Items.AddRange(new object[] {
            "Description",
            "Rationale",
            "Fit Criterion"});
            this.cBoxPreview.Location = new System.Drawing.Point(2, 2);
            this.cBoxPreview.Name = "cBoxPreview";
            this.cBoxPreview.Size = new System.Drawing.Size(290, 21);
            this.cBoxPreview.TabIndex = 0;
            this.cBoxPreview.SelectedIndexChanged += new System.EventHandler(this.cBoxPreview_SelectedIndexChanged);
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreview.Location = new System.Drawing.Point(1, 29);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(290, 244);
            this.txtPreview.TabIndex = 1;
            // 
            // FormPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.cBoxPreview);
            this.HideOnClose = true;
            this.Name = "FormPreview";
            this.TabText = "Preview";
            this.Text = "Preview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxPreview;
        private System.Windows.Forms.TextBox txtPreview;
    }
}