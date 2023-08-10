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
    public partial class lamp : UserControl
    {
        Color lampColor = Color.DarkRed;
        public bool isOpen = false;
        public lamp()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;

        }
        public void SetColor(bool b)
        {
            isOpen = b;
            if (b)
            {
                lampColor = Color.Green;
            }
            else
            {
                lampColor = Color.DarkRed;
            }
            this.Refresh();
        }
        private void lamp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(new SolidBrush(lampColor), 0, 0, this.Width-1, this.Height-1);
        }

        private void lamp_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
