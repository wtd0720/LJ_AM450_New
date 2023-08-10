using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureSystem
{
    public partial class TemperatureControl : UserControl
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
            btnJBJRPB.Visible = value;
            btnFXJRPB.Visible = value;
            this.Refresh();
        }
        public TemperatureControl(bool _admin)
        {
            InitializeComponent();
            beginTime = DateTime.Now;
            Admin = _admin;
            timerTime.Start();        
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            this.RunTimeLabel.Text = DateTime.Now.Subtract(beginTime).ToString("hh':'mm':'ss");
        }
    }
}
