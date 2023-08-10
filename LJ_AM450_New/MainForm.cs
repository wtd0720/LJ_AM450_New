using ClipperHelper;
using PaveSystem;
using ProcessSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendSystem;
using TopSendSystem;
using TemperatureSystem;
using PaveSystem.UControls;
using ProjectSystem;

namespace LJ_AM450_New
{
    public partial class MainForm : Form
    {
		MyProject myProject = null;
        DateTime beginTime;
        bool endRead = false;
        public SlcModel sm = null;
        SliceControl_New sc = null;

        PaveControl paveControl = null;
        Pave pave = null;

        ProcessControl processControl = null;
        Process process = null;

        SendControl sendControl = null;
        Send send = null;

        TopSendControl topSendControl = null;
        TopSend topSend = null;

        TemperatureControl temperatureControl = null;
        Temperature temperature = null;

        ProjectControl projectControl = null;
        Project project = null;

        //用于工程师界面的布尔值
        private bool adminMainForm = false;


        UC_Print uC_Print = null;
        UC_Piston uC_Piston = null;
        UC_Blade uC_Blade = null;
        UC_Home uC_Home = null;

        public bool Admin
        {
            set { adminMainForm = value;
                ChangeAdmin(value);
            }
            get { return adminMainForm; }
        }
        public MainForm()
        {
            InitializeComponent();
            beginTime = DateTime.Now;
            this.timerNow.Start();
            pave = new Pave();

            projectControl = new ProjectControl();
            paveControl = new PaveControl(adminMainForm , pave);
            processControl = new ProcessControl(adminMainForm);
            sendControl = new SendControl(adminMainForm);
            topSendControl = new TopSendControl(adminMainForm);
            temperatureControl = new TemperatureControl(adminMainForm);
            uC_Print = new UC_Print(adminMainForm, pave);
            uC_Piston = new UC_Piston(adminMainForm, pave);
            uC_Blade = new UC_Blade(adminMainForm, pave);
            uC_Home = new UC_Home(pave);

            this.timerRead.Start();
            panelSide.Visible = false;
            ChangeControl(projectControl);
        }
        private void ChangeAdmin(bool value)
        {
            paveControl.Admin= value;
            processControl.Admin = value; 
            sendControl.Admin = value;
            topSendControl.Admin = value;
            temperatureControl.Admin = value;
        }
        private void ChangeControl(Control ctl)
        {
            ctl.Dock = DockStyle.Fill;
            this.CenterPanel.Controls.Clear();
            this.CenterPanel.Controls.Add(ctl);
        }

        private void PaveSystem_Click(object sender, EventArgs e)
        {
            ChangeControl(paveControl);
            panelSide.Visible = true;
            moveSidePanel(PaveSystem);
        }

        private void pBKey_Click(object sender, EventArgs e)
        {
            if(Admin == false)
                using (Login login = new Login()) 
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Admin = login.admin;
                    }
                }
            else
            {
                DialogResult dr = MessageBox.Show("是否退出登录？", "退出登录", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Admin = false;
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            this.RunTimeLabel.Text = DateTime.Now.Subtract(beginTime).ToString("hh':'mm':'ss");
        }

        private void PowderSender_Click(object sender, EventArgs e)
        {
            ChangeControl(sendControl);
            panelSide.Visible = true;
            moveSidePanel(PowderSender);
        }

        private void processingEnvironment_Click(object sender, EventArgs e)
        {
            ChangeControl(processControl);
            panelSide.Visible = true;
            moveSidePanel(processingEnvironment);
        }

        private void feedingMechanism_Click(object sender, EventArgs e)
        {
            ChangeControl(topSendControl);
            panelSide.Visible = true;
            moveSidePanel(feedingMechanism);
        }

        private void moveSidePanel(Control btn) 
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void timerNow_Tick(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.RunTimeLabel.Text = DateTime.Now.Subtract(beginTime).ToString("hh':'mm':'ss");
        }

        private void NewItem_Click(object sender, EventArgs e)
        {
            myProject = new MyProject();
            ProjectCreate pc = new ProjectCreate(myProject);
            pc.Owner = this;
            pc.ShowDialog();
        }
        internal void LoadData(MyProject mp)
        {
            timerRead.Start();
            Task.Run(() =>
            {
                if (mp._supportfile == null || mp._supportfile == "")
                {
                    this.sm = new SlcModel(mp._modelfile);
                }
                else
                {
                    this.sm = new SlcModel(mp._modelfile, mp._supportfile, false);
                }
                if (sm.ModelCountors == null)
                {
                    MessageBox.Show(this, "文件导入失败");
                    return;
                }
                if (!sm.right)
                {
                    MessageBox.Show(this, "支撑文件与模型层厚不匹配");
                    return;
                }
                endRead = true;
            });
        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 1;
            if (progressBar1.Value > 90)
            {
                progressBar1.Value = 90;
            }
            if (endRead)
            {
                this.progressBar1.Value = 100;
                timerRead.Stop();
                if (sm == null && sc == null)
                {
                    MessageBox.Show(this, "未加载模型");
                    return;
                }
                //manuControl = new ManuControl(sm, pave, scan, myProject.para.slicePara, myProject.para.manuPara);
                //manuControl.StartPrint += new ManuControl.StartEventHandler(GetPrintProgress);
                sc = new SliceControl_New(sm, myProject.para.slicePara,2,450, 450);
                //PanelMove(this.SliceView);
                ChangeControl(sc);
             }
            uC_Print.SetStatus();
            uC_Print.Refresh();
            uC_Piston.SetStatus();
            uC_Piston.Refresh();
            uC_Blade.SetStatus();
            uC_Blade.Refresh();
            uC_Home.SetStatus();
            uC_Home.Refresh();
        }

        private void TemControl_Click(object sender, EventArgs e)
        {
            ChangeControl(temperatureControl);
            panelSide.Visible = true;
            moveSidePanel(TemControl);
        }

        private void EngineerUI_Click(object sender, EventArgs e)
        {
            if (Admin == false)
            {
                EngineerUI.Text = "工程师界面";
                using (Login login = new Login())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Admin = login.admin;
                        EngineerUI.Text = "用户界面  ";
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("是否退出登录？", "退出登录", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Admin = false;
                    EngineerUI.Text = "工程师界面  ";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ChangeControl(projectControl);
            panelSide.Visible = true;
        }
    }
}
