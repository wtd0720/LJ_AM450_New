using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PaveSystem.UControls
{
    public partial class UC_Print : UserControl
    {
        PrintCondition pc = new PrintCondition();
        float position = 0;
        bool Reverse = false;
        bool admin = false;

        Pave pa = null;
        Status status;

        public bool Admin
        {
            set { admin = value; SetVisible(value); }
            get { return admin; }
        }

        private void SetVisible(bool value)
        {
            printFanClearSet.Visible = value;
            printGetSet.Visible = value;
            this.Refresh();
        }
        public UC_Print(bool _admin , Pave _pa)
        {
            InitializeComponent();
            Admin = _admin;
            pa = _pa;
            status = new Status();
            pc.Dock = DockStyle.Fill;
            uPanelCenter.Controls.Add(pc);
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* position = Reverse ? position - 10 : position + 10;

            pc.SetPosition(position);
            pc.Refresh();
            if (position == 2460 || position == 0)
            {
                Reverse = !Reverse;
            }*/
        }

        //读取各轴的状态
        public void SetStatus()
        {          
            this.printConnect.Text = "伺服状态:  " + (status.GetServoStatus(Pave.DYCPYDJ) ? "正常" : "报警");
            this.printSpeed.Text = "速度:  " + status.GetSpeed(Pave.DYCPYDJ).ToString("0.00") + "mm/s";
            this.printDistance.Text = "扭矩:  " + status.GetTorque(Pave.DYCPYDJ) + "N· M";
            this.pc.SetPosition((float)status.GetPosition(Pave.DYCPYDJ));
        }

        private void UC_Print_Load(object sender, EventArgs e)
        {
            SetStatus();
        }
    }
}
