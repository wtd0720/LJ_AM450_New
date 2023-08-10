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
    public partial class UPictureBox : PictureBox
    {
        public UPictureBox()
        {
            InitializeComponent();
        }

        private Image normalImage;
        private Image hoverImage;
        public Image ImageNormal
        {
            get { return normalImage; }
            set { normalImage = value; }
        }

        public Image ImageHover
        {
            get { return hoverImage; }
            set { hoverImage = value; }
        }

        private void UPictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.Width += 5;
            this.Height += 5;
            this.Image = hoverImage;
        }

        private void UPictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Width -= 5;
            this.Height -= 5;
            this.Image = normalImage;
        }
    }
}
