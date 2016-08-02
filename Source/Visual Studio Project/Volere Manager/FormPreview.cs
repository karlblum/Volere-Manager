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
    public partial class FormPreview : DockContent
    {
        FormMain mainForm;
        Req req;

        public FormPreview(FormMain mf)
        {
            InitializeComponent();
            this.mainForm = mf;
            cBoxPreview.SelectedIndex = 0;
        }

        public void showPreview(Req r)
        {
            req = r;
            if (r != null)
            {
                switch (cBoxPreview.SelectedIndex)
                {
                    case 0:
                        this.txtPreview.Text = r.Description.ToString();
                        break;
                    case 1:
                        this.txtPreview.Text = r.Rationale.ToString();
                        break;
                    case 2:
                        this.txtPreview.Text = r.Fit_criterion.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private void cBoxPreview_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPreview(req);
        }
    }
}
