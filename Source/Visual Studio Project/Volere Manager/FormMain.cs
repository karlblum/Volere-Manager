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
using System.Data.SqlServerCe;

namespace Volere_Manager
{
    public partial class FormMain : Form
    {

        private FormAdvisor formAdvisor;
        private DeserializeDockContent m_deserializeDockContent;
        public FormReqManager formReqManager;
        public List<FormReq> reqList = new List<FormReq>();
        public FormReq activeReq = null;
        public FormPreview formPreview;
        public FormReqManagerFilters formReqManagerFilter;

        private String dataFile = null;
        public Blank dc = null;

        public FormMain()
        {
            InitializeComponent();
            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            formAdvisor = new FormAdvisor();
            formReqManager = new FormReqManager(this);
            formPreview = new FormPreview(this);
            formReqManagerFilter = new FormReqManagerFilters(this);
        }

        private void initReqManagerHeader()
        {
            List<HeaderItem> headerItems = new List<HeaderItem>();
            headerItems.Add(new HeaderItem("Type_id"));
            headerItems.Add(new HeaderItem("Id", "#","Requirement ID", 40,true));
            headerItems.Add(new HeaderItem("Req_types", "Type", 200, true));
            headerItems.Add(new HeaderItem("Description", 300, true));
            headerItems.Add(new HeaderItem("Rationale", 100, false));
            headerItems.Add(new HeaderItem("Fit_criterion", "Fit Criterion", 100, false));
            headerItems.Add(new HeaderItem("use_cases", "Use Cases", 100, false));
            headerItems.Add(new HeaderItem("Originator_id", "Originator", 100, false));
            headerItems.Add(new HeaderItem("Satisfaction", "S", "Satisfaction", 20, true));
            headerItems.Add(new HeaderItem("Dissatisfaction", "D", "Dissatisfaction", 20, true));
            headerItems.Add(new HeaderItem("Priority", "P", "Priority", 20, true));
            headerItems.Add(new HeaderItem("Created",100, false));
            headerItems.Add(new HeaderItem("Modified","Last edited",100,false));
            formReqManager.setHeaderItems(headerItems);
        }

        public void filterStateChanged()
        {
            this.formReqManager.initData();
            this.formReqManager.setFilterBtnState();
        }

        public void initDataUpdate()
        {
            this.formReqManager.initData();
            this.formReqManagerFilter.initData();
            this.updateOpenReqs();
        }

        private void updateOpenReqs()
        {
            foreach (FormReq fr in reqList)
            {
               fr.updateReqTypesCBox();
            }
        }

        public void openProject(String dbPath)
        {
            Boolean closingOK = true;
            if (dataFile != null)
            {
                closingOK = closeProject();
            }

            if (closingOK)
            {
                this.dataFile = dbPath;
                this.Text = "Volere Manager - " + dbPath;
                SqlCeConnection _sqlCeConnnectionString = new SqlCeConnection(@"Data Source=" + this.dataFile);
                this.dc = new Blank(_sqlCeConnnectionString);
                formReqManager.Show();
                initDataUpdate();
                initReqManagerHeader();
                viewToolStripMenuItem.Visible = true;
                projectToolStripMenuItem.Visible = true;
                formPreview.Visible = true;
                closeToolStripMenuItem.Enabled = true;
                newReqStripMenuItem.Enabled = true;
                formPreview.Show(dockPanel);
            }
        }

        public Boolean closeProject()
        {
            Boolean closingInterrupted = false;

            foreach (var reqForm in reqList)
            {
                reqForm.serialClosing = true;
                reqForm.Close();
                if (!reqForm.IsDisposed)
                {
                    closingInterrupted = true;
                    reqForm.serialClosing = false;
                    break;
                }
            }


            if (!(closingInterrupted))
            {
                dataFile = null;
                dc.Connection.Close();
                formReqManager.Hide();
                viewToolStripMenuItem.Visible = false;
                projectToolStripMenuItem.Visible = false;
                newReqStripMenuItem.Enabled = false;
                closeToolStripMenuItem.Enabled = false;
                formPreview.Hide();
                tSSCounter.Text = "";
                return true;
            }
            return false;
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FormReqManager).ToString())
            {
                return formReqManager;
            }
            if (persistString == typeof(FormPreview).ToString())
            {
                return formPreview;
            }
            if (persistString == typeof(FormReqManagerFilters).ToString())
            {
                return formReqManagerFilter;
            }
            else
            {
                return null;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "layout.cfg");

            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);

            formReqManager.Hide();
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean closeInterrupted = false;

            if (dataFile != null) closeInterrupted = !closeProject();

            if (closeInterrupted)
            {
              e.Cancel = true;

            } else {
                string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "layout.cfg");
                dockPanel.SaveAsXml(configFile);
            }

        }

        private void requirementsManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReqManager.Show(dockPanel);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

            showReq(null);
        }

        public void closeReqFormAllOthers(FormReq requirement)
        {
            var reqToClose = new List<FormReq>();

            foreach (var reqForm in reqList)
            {
                reqForm.serialClosing = true;
                if (requirement == null || reqForm != requirement) reqToClose.Add(reqForm);
             }
            foreach (var r in reqToClose)
            {
                closeReqFrom(r,false);
            }

        }

        public void closeReqFrom(FormReq requirement, Boolean force)
        {
            
            if (force)
            {
                requirement.forcedClose();
            }
            else
            {
                requirement.Close();
            }

            if (requirement.IsDisposed) reqList.Remove(requirement);
            if (reqList.Count == 0) saveStripMenuItem.Enabled = false;

        }

        public void closeReq(Req requirement, Boolean force)
        {
            foreach (var rf in reqList)
            {
                if (rf.getReq() == requirement)
                {
                        closeReqFrom(rf, true);
                        break;
                }
            }


        }

        public void showReq(Req requirement)
        {

            if (requirement != null)
            {
                Boolean alreadyOpen = false;
                foreach (var reqForm in reqList)
                {
                    if (reqForm.getReq() == requirement)
                    {
                        reqForm.Focus();
                        alreadyOpen = true;
                    }
                }
                if (!alreadyOpen)
                {
                    FormReq formReq = new FormReq(this, requirement);
                    reqList.Add(formReq);
                    formReq.Show(dockPanel, DockState.Document);
                }
                
            }
            else
            {
                FormReq formReq = new FormReq(this);
                formReq.Show(dockPanel, DockState.Document);
                reqList.Add(formReq);
            }
            if (reqList.Count != 0) saveStripMenuItem.Enabled = true;
        }

        private void advisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdvisor.Show(dockPanel);
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWizard nw = new NewWizard(this);
            nw.Show();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.openProject(this.openFileDialog.FileName);
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTypesManager ftm = new FormTypesManager(this);
            ftm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeProject();
        }

        public void deleteReq(FormReq reqForm, Boolean force)
        {
            if (reqForm.getReq() != null)
            {
                closeReqFrom(reqForm, true);
                dc.Req.DeleteOnSubmit(reqForm.getReq());
                dc.SubmitChanges();
            }
            else
            {
                closeReqFrom(reqForm, true);
            }
        }

        public void deleteReq(Req req, Boolean force)
        {
            closeReq(req, true);
            dc.Req.DeleteOnSubmit(req);
            dc.SubmitChanges();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormAbout()).Show();
        }

        private void newReqStripMenuItem_Click(object sender, EventArgs e)
        {
            showReq(null);
        }

        private void saveStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeReq != null)
            {
                activeReq.saveToolStripMenuItem_Click(sender, e);
            }
        }

        private void previewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPreview.Show(dockPanel);
        }

        public void showReqManagerFilter()
        {
            formReqManagerFilter.Show(dockPanel);
        }

        internal void showReqById(string p)
        {
            Int64 reqId = 0;
            try
            {
                reqId = Convert.ToInt64(p);
                Req req = (from r in dc.Req
                           where r.Id == reqId
                           select r).First();

                showReq(req);
            }
            catch (Exception)
            {

            }

        }

        internal void setStatusText(string p)
        {
            this.tSSCounter.Text = p;
        }

        private void exporttxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataGenerator dg = new DataGenerator(dc);
            dg.exportTxt(formReqManager.filteredReqs, saveFileDialog.FileName);
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
            System.Diagnostics.Process.Start(Application.StartupPath+"\\vmhelp.chm");
            }
            catch (Exception)
            {
            }
        }


    }
}
