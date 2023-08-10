using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaveSystem.UControls
{
    public partial class UC_Home : UserControl
    {
        HomeCondition hc;
        float bladeposition = 0;
        float pistonposition = 0;
        bool Reverseb = false;
        bool Reversep = false;

        Pave pa = null;
        Status status;

        public UC_Home(Pave _pa)
        {
            InitializeComponent();
            pa = _pa;
            status = new Status();
            hc = new HomeCondition();
            hc.Dock = DockStyle.Fill;
            uPanelCenter.Controls.Add(hc);
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
         /*   bladeposition = Reverseb ? bladeposition - 5 : bladeposition + 5;
            pistonposition = Reversep ? pistonposition - 10 : pistonposition + 10;
            hc.SetPosition(bladeposition, pistonposition);
            //bc.Refresh();
            if (bladeposition == 905 || bladeposition == 0)
            {
                Reverseb = !Reverseb;
            }
            if (pistonposition == 800 || pistonposition == 0)
            {
                Reversep = !Reversep;
            }*/
        }

        public void SetStatus()
        {                  
            this.bladeConnect.Text = "伺服状态:  " + (status.GetServoStatus(Pave.GDDJ) ? "正常" : "报警");
            this.bladeSpeed.Text = "实际速度:  " + status.GetSpeed(Pave.GDDJ).ToString("0.00") + "mm/s";
            this.bladeDistance.Text = "扭矩:  " + status.GetTorque(Pave.GDDJ) + "N· M";
            this.pistonConnect.Text = "伺服状态:  " + (status.GetServoStatus(Pave.HSSJZ) ? "正常" : "报警");
            this.pistonSpeed.Text = "实际速度:  " + status.GetSpeed(Pave.HSSJZ).ToString("0.00") + "mm/s";
            this.pistonDistance.Text = "扭矩:  " + status.GetTorque(Pave.HSSJZ) + "N· M";
            this.hc.SetPosition((float)status.GetPosition(Pave.GDDJ), (float)status.GetPosition(Pave.HSSJZ));
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            SetStatus();
        }

        private void bladeRight_MouseDown(object sender, MouseEventArgs e)
        {
            pa.MoveForwardDown(Pave.GDDJ, 1.0, 0.5, 0.5, 0.5);
        }

        private void bladeRight_MouseUp(object sender, MouseEventArgs e)
        {
            pa.MoveForwardUp(Pave.GDDJ);
        }

        private void bladePause_Click(object sender, EventArgs e)
        {
            pa.StopMovement(Pave.GDDJ);
        }

        private void bladeLeft_MouseDown(object sender, MouseEventArgs e)
        {
            pa.MoveBackDown(Pave.GDDJ, 1.0, 0.5, 0.5, 0.5);
        }

        private void bladeLeft_MouseUp(object sender, MouseEventArgs e)
        {
            pa.MoveBackUp(Pave.GDDJ);
        }

        private void pistonUp_MouseDown(object sender, MouseEventArgs e)
        {
            pa.MoveForwardDown(Pave.HSSJZ, 1.0, 0.5, 0.5, 0.5);
        }

        private void pistonUp_MouseUp(object sender, MouseEventArgs e)
        {
            pa.MoveForwardUp(Pave.HSSJZ);
        }

        private void pistonPause_Click(object sender, EventArgs e)
        {
            pa.StopMovement(Pave.HSSJZ);
        }

        private void pistonDown_MouseDown(object sender, MouseEventArgs e)
        {
            pa.MoveBackDown(Pave.HSSJZ, 1.0, 0.5, 0.5, 0.5);
        }

        private void pistonDown_MouseUp(object sender, MouseEventArgs e)
        {
            pa.MoveBackUp(Pave.HSSJZ);
        }
    }
}
