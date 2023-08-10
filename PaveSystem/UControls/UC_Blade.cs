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
    public partial class UC_Blade : UserControl
    {
        BladeCondition bc;
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
        private void timer1_Tick(object sender, EventArgs e)
        {
          /*  position = Reverse ? position - 5 : position + 5;

            bc.SetPosition(position);
            //bc.Refresh();
            if (position == 905 || position == 0)
            {
                Reverse = !Reverse;
            }*/
        }
        public UC_Blade(bool _admin, Pave _pa)
        {

            bc = new BladeCondition();
            bc.Dock = DockStyle.Fill;
            InitializeComponent();
            status = new Status();
            pa = _pa;
            Admin = _admin;
            this.uPanelCenter.Controls.Add(bc);
            timer1.Start();
        }
        public void SetVisible(bool b)
        {
            bladeFanGetSet.Visible = b;
            bladeFanUpSet.Visible = b;
            bladeFanDownSet.Visible = b;
            this.Refresh();          
        }
        public void SetStatus()
        {
            this.bladeConnect.Text = "伺服状态:  " + (status.GetServoStatus(Pave.GDDJ) ? "正常" : "报警");
            this.bladeSpeed.Text = "速度:  " + status.GetSpeed(Pave.GDDJ).ToString("0.00") + "mm/s";
            this.bladeDistance.Text = "扭矩:  " + status.GetTorque(Pave.GDDJ) + "N· M";
            this.bc.SetPosition((float)status.GetPosition(Pave.GDDJ));

        }

        private void UC_Blade_Load(object sender, EventArgs e)
        {
            SetStatus();
        }
    }
}
