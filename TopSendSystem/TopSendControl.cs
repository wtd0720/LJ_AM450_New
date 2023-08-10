using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSendSystem
{
    public partial class TopSendControl : UserControl
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
            fallFan.Visible = value;
            cycloneWind.Visible = value;
            cycloneGIveFan.Visible = value;
            cycloneFallFan.Visible = value;
            this.Refresh();
        }
        public TopSendControl(bool _admin)
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
