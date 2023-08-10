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
    public partial class UC_Piston : UserControl
    {
        PistonCondition pc = new PistonCondition();
        bool Reverse = false;
        float position = 0;
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
            pistonZero.Visible = value;
            this.Refresh();
        }
        public UC_Piston(bool _admin, Pave _pa)
        {

            InitializeComponent();
            pa = _pa;
            Admin = _admin;
            status = new Status();
            uPanelCenter.Controls.Clear();
            pc.Dock = DockStyle.Fill;
            uPanelCenter.Controls.Add(pc);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          /*  position = Reverse ? position - 10 : position + 10;
 
            pc.SetPosition(position);
            if (position == 500 || position == 0)
            {
                //Thread.Sleep(3000);
                Reverse = !Reverse;
            }*/
        }

        public void SetStatus()
        {         
            this.pistonFirstConnect.Text = "伺服状态:  " + (status.GetServoStatus(Pave.HSSJZ) ? "正常" : "报警");
            this.pistonFirstSpeed.Text = "速度:  " + status.GetSpeed(Pave.HSSJZ).ToString("0.00") + "mm/s";
            this.pistonFirstSpot.Text = "光栅位置:  " + status.GetLightPosition(Pave.HSSJZ).ToString("0.00") + "mm";
            this.pistonFirstDIstance.Text = "扭矩:  " + status.GetTorque(Pave.HSSJZ) + "N· M";
            this.pistonSecondConnect.Text = "伺服状态:  " + (status.GetServoStatus(Pave.HSSJC) ? "正常" : "报警");
            this.pistonSecondSpeed.Text = "速度:  " + status.GetSpeed(Pave.HSSJC).ToString("0.00") + "mm/s";
            this.pistonSecondSpot.Text = "光栅位置:  " + status.GetLightPosition(Pave.HSSJC).ToString("0.00") + "mm";
            this.pistonSecondDistance.Text = "扭矩:  " + status.GetTorque(Pave.HSSJC) + "N· M";
            this.pc.SetPosition((float)status.GetPosition(Pave.HSSJZ));

        }

        private void UC_Piston_Load(object sender, EventArgs e)
        {
            SetStatus();
        }
    }
}
