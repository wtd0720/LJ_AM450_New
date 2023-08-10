using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGraphics.UControls
{
    public partial class CircleLabel : Label
    {
        public CircleLabel()
        {
            InitializeComponent();
            //ControlStyles设置
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Size = new Size(150, 50);
            BackColor = Color.Transparent;//背景透明
            rect = this.ClientRectangle;
        }
        Rectangle rect;//工作区

        //背景色   边框色   边框粗细
        private Color bgColor = Color.LightGray;
        /// <summary>
        /// 背景画刷
        /// </summary>
        public Color BgColor
        {
            get { return bgColor; }
            set
            {
                bgColor = value;
                Invalidate();
            }
        }

        private Color borderColor = Color.Gray;
        /// <summary>
        /// 边框画刷
        /// </summary>
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        private int borderWidth = 0;
        /// <summary>
        /// 边框粗细
        /// </summary>
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
        }

        /// <summary>
        /// 重绘控件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            //边框   背景
            Rectangle rectBg;
            if (borderWidth > 0)//有边框
            {
                g.FillEllipse(new SolidBrush(BorderColor), rect);//边框椭圆
                rectBg = new Rectangle(rect.X + borderWidth, rect.Y + borderWidth, rect.Width - 2 * borderWidth, rect.Height - 2 * borderWidth);
            }
            else
                rectBg = rect;

            //背景填充
            g.FillEllipse(new SolidBrush(BgColor), rectBg);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            //文本绘制
            SolidBrush fontBrush = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, fontBrush, rect, format);
        }
    }
}
