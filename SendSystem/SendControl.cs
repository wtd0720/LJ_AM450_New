using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendSystem
{
    public partial class SendControl : UserControl
    {
        DateTime beginTime;
        bool admin = false;
        public bool Admin
        {
            set { admin = value; SetVisible(value); }
            get { return admin; }
        }

        private void SetVisible(bool value)
        {
            sendSpeedSet.Visible = value;
            sendZero.Visible= value;
            sendGiveFan.Visible = value;
            sendWind.Visible = value;
            sendDown.Visible = value;
            this.Refresh();
        }

        public SendControl(bool _admin)
        {
            InitializeComponent();
            Admin = _admin;
            beginTime = DateTime.Now;
            timerTime.Start();
        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            this.RunTimeLabel.Text = DateTime.Now.Subtract(beginTime).ToString("hh':'mm':'ss");
        }
    }
}
