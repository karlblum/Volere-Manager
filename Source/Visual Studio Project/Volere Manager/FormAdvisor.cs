using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace Volere_Manager
{
    public partial class FormAdvisor : DockContent
    {
        public FormAdvisor()
        {
            InitializeComponent();
        }

        private void FormAdvisor_Load(object sender, EventArgs e)
        {
            String path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "vreq.rtf");
            richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
        }
    }
}
