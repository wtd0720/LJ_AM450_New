using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaveSystem.UControls;

namespace PaveSystem
{
    public partial class PaveControl : UserControl
    {
        DateTime beginTime;
        UC_Home uch;
        UC_Blade ucb;
        UC_Piston ucpi;
        UC_Print ucpr;
        bool admin = false;

        Pave pa = null;
        Status status;

        public bool Admin
        {
            set { admin = value; ChangeAdmin(value); }
            get { return admin; }
        }

        private void ChangeAdmin(bool value)
        {
            ucb.Admin = value;
            ucpi.Admin = value;
            ucpr.Admin = value;
        }

        public PaveControl(bool admin , Pave _pa)
        {
            InitializeComponent();
            pa = _pa;
            status = new Status();
            beginTime = DateTime.Now;
            timerTime.Start();
            uch = new UC_Home(pa);
            ucb = new UC_Blade(admin,pa);
            ucpi = new UC_Piston(admin ,pa);
            ucpr = new UC_Print(admin ,pa);
            AddControlsToPanel(uch);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pavePanelCenter.Controls.Clear();
            pavePanelCenter.Controls.Add(c);
        
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(uch);
        }

        private void btnBlade_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucb);
        }

        private void btnPiston_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucpi);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucpr);
          
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            this.RunTimeLabel.Text = DateTime.Now.Subtract(beginTime).ToString("hh':'mm':'ss");
            this.labRunControl.Text = Convert.ToString(status.GetClock()) + " s";
        }       

    }
}
