using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaveSystem.UControls
{
    public class UPanel : Panel
    {
        public UPanel()
        {

            //ControlStyles设置
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Size = new Size(100, 50);
            BackColor = Color.Transparent;//背景透明
            rect = this.ClientRectangle;
        }
        Rectangle rect;//工作区

        private Color bgColor = Color.LightGray;
        /// <summary>
        /// 背景色1
        /// </summary>
        [DefaultValue(typeof(Color), "LightGray"), Description("按钮的背景颜色1"), Category("自定义")]
        public Color BgColor
        {
            get { return bgColor; }
            set
            {
                bgColor = value;
                Invalidate();
            }
        }

        private Color bgColor2 = Color.White;
        /// <summary>
        /// 背景色2
        /// </summary>
        public Color BgColor2
        {
            get { return bgColor2; }
            set
            {
                bgColor2 = value;
                Invalidate();
            }
        }

        private Color borderColor = Color.Gray;
        /// <summary>
        /// 边框色
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

        private int radius = 5;
        /// <summary>
        /// 边框圆角半径
        /// </summary>
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
        /// <summary>
        /// 渐变模式
        /// </summary>
        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            rect = ClientRectangle;
            this.Region = new Region(rect);
            rect.Width -= 1;
            rect.Height -= 1;
        }


        /// <summary>
        /// 控件重绘
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            //边框   背景
            Rectangle rectBg;
            //路径 path  pathbg
            GraphicsPath path = new GraphicsPath();//边框的路径
            GraphicsPath pathBg = new GraphicsPath();//背景的路径 
            if (radius > 0)
            {
                //边框的路径 
                path = PaintHelper.GetRoundRect(rect, radius);
                if (borderWidth > 0)
                {
                    g.FillPath(new SolidBrush(borderColor), path);//填充边框路径
                    //背景区域
                    rectBg = new Rectangle(rect.X + borderWidth, rect.Y + borderWidth, rect.Width - 2 * borderWidth, rect.Height - 2 * borderWidth);
                    //背景路径 
                    pathBg = PaintHelper.GetRoundRect(rectBg, radius);
                }
                else
                {
                    pathBg = path;
                    rectBg = rect;
                }
                if (bgColor2 != Color.Transparent)//渐变填充
                {
                    LinearGradientBrush bgBrush = new LinearGradientBrush(rectBg, bgColor, bgColor2, gradientMode);
                    g.FillPath(bgBrush, pathBg);//背景填充
                }
                else
                {
                    SolidBrush bgBrush = new SolidBrush(bgColor);
                    g.FillPath(bgBrush, pathBg);
                }
            }
            else
            {
                if (borderWidth > 0)
                {
                    g.FillRectangle(new SolidBrush(borderColor), rect);
                    rectBg = new Rectangle(rect.X + borderWidth, rect.Y + borderWidth, rect.Width - 2 * borderWidth, rect.Height - 2 * borderWidth);
                }
                else
                {
                    rectBg = rect;
                }
                if (bgColor2 != Color.Transparent)//渐变填充
                {
                    LinearGradientBrush bgBrush = new LinearGradientBrush(rectBg, bgColor, bgColor2, gradientMode);
                    g.FillRectangle(bgBrush, rectBg);//背景填充
                }
                else
                {
                    SolidBrush bgBrush = new SolidBrush(bgColor);
                    g.FillRectangle(bgBrush, rectBg);
                }
            }
        }
    }
}
