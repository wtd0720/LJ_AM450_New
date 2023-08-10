using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessSystem
{
    public partial class ProcessControl : UserControl
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
            printPressureSet.Visible = value;
            this.Refresh();
        }

        public ProcessControl(bool admin)
        {
            InitializeComponent();
            Admin = admin;
            beginTime = DateTime.Now;
        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            this.RunTimeLabel.Text = DateTime.Now.Subtract(beginTime).ToString("hh':'mm':'ss");
        }
    }
}
