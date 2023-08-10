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
    [DefaultEvent("CheckedChanged")]
    public class USwitch : Control
    {

        public USwitch()
        {
            //ControlStyles设置
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Size = new Size(100, 30);
            this.Click += USwitch_Click;
        }

        private void USwitch_Click(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(this, new EventArgs());
        }

        public event EventHandler CheckedChanged;//开关状态改变后触发

        private Color trueColor = Color.FromArgb(34, 163, 169);
        [Description("打开时的颜色"), Category("自定义")]
        public Color TrueColor
        {
            get { return trueColor; }
            set
            {
                trueColor = value;
                Invalidate();
            }
        }

        private Color falseColor = Color.FromArgb(111, 122, 126);
        [Description("关闭时的颜色"), Category("自定义")]
        public Color FalseColor
        {
            get { return falseColor; }
            set
            {
                falseColor = value;
                Invalidate();
            }
        }

        private bool swChecked;
        [Description("当前开关的状态"), Category("自定义")]
        public bool Checked
        {
            get { return swChecked; }
            set
            {
                swChecked = value;
                Invalidate();
            }
        }

        private string[] texts = new string[] { "On", "Off" };
        [Description("开关文本值，两个值，一个是开的文本，一个是关的文本"), Category("自定义")]
        public string[] Texts
        {
            get { return texts; }
            set
            {
                texts = value;
                Invalidate();
            }
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            //背景填充色
            var fillColor = swChecked ? trueColor : falseColor;
            //路径
            GraphicsPath path = new GraphicsPath();
            //上边线    x:height/2,y:1      x:width-height/2,y:1
            path.AddLine(this.Height / 2, 1, this.Width - this.Height / 2, 1);
            //右边半圆弧
            path.AddArc(new Rectangle(Width - Height - 1, 1, this.Height - 2, Height - 2), 270, 180);
            //下边线    x:width-height/2,y:height-1      x:height/2,y:height-1 
            path.AddLine(this.Width - this.Height / 2, Height - 1, this.Height / 2, Height - 1);
            //左边半圆弧
            path.AddArc(new Rectangle(1, 1, this.Height - 2, Height - 2), 90, 180);
            //路径填充
            g.FillPath(new SolidBrush(fillColor), path);
            string text = "";//要画的文字
            if (texts != null && texts.Length == 2)
            {
                if (swChecked)
                    text = texts[0];
                else
                    text = texts[1];
            }

            if (swChecked)
            {
                //右边画圆，左边画文本
                //圆的直径：Height-2-4
                g.FillEllipse(Brushes.White, new Rectangle(Width - Height - 1 + 2, 1 + 2, Height - 2 - 4, Height - 2 - 4));
                //画文本
                SizeF sizeFont = g.MeasureString(text.Replace(" ", "A"), Font);
                //计算文本左上角的y坐标
                int fPointY = (this.Height - (int)sizeFont.Height) / 2 + 2;
                int fPointX = (Height - 2 - 4) / 2;
                g.DrawString(text, Font, Brushes.White, fPointX, fPointY);
            }
            else
            {
                //左边画圆，右边画文本
                g.FillEllipse(Brushes.White, new Rectangle(1 + 2, 1 + 2, Height - 2 - 4, Height - 2 - 4));
                //画文本
                SizeF sizeFont = g.MeasureString(text.Replace(" ", "A"), Font);
                //计算文本左上角的y坐标
                int fPointY = (this.Height - (int)sizeFont.Height) / 2 + 2;
                int fPointX = Width - 2 - Height / 2 - ((int)sizeFont.Width) + 10;
                g.DrawString(text, Font, Brushes.White, fPointX, fPointY);
            }
        }


    }
}
