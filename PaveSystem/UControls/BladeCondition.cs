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

namespace PaveSystem.UControls
{
    public partial class BladeCondition : UserControl
    {
        Graphics g = null;
        public float zoom, moveX, moveY;
        float yP = 0;
        Pen border = new Pen(Color.Black, 0.01F);
        public BladeCondition()
        {
            zoom = 0.5F;
            moveX = 0;
            moveY = 0;
            InitializeComponent();
        }
        public void SetPosition(float y)
        {
            yP = y;
            this.pictureBox1.Refresh();

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            float x = this.Width / 2;
            float y = this.Height / 2;

            //// Then to scale, appending to world transform.
            g.TranslateTransform(x + moveX, y + moveY);
            g.ScaleTransform(zoom, zoom);

            DrawBackGround();
            DrawBlade();
            DrawLimit();
        }

        private void DrawLimit()
        {
            g.FillEllipse(Brushes.DarkRed, 445, -525, 50, 50);

            g.FillEllipse(Brushes.DarkRed, 445, -500 + 75-25, 50, 50);

            g.FillEllipse(Brushes.DarkRed, 445, -25, 50, 50);

            g.FillEllipse(Brushes.DarkRed, 445, 405-25, 50, 50);



            if (Math.Abs(yP) < 5)
            {
                g.FillEllipse(Brushes.Green, 445, -525, 50, 50);
            }
            if (Math.Abs(yP-75) < 5)
            {
                g.FillEllipse(Brushes.Green, 445, -500 + 75 - 25, 50, 50);
            }
            if (yP< 733 && yP >265)
            {
                g.FillEllipse(Brushes.Green, 445, -25, 50, 50);
            }
            if (Math.Abs(yP-905) < 5)
            {
                g.FillEllipse(Brushes.Green, 445, -25, 50, 50);
            }
        }

        private void DrawBlade()
        {
            RectangleF[] rectangles = new RectangleF[5];
            //刮刀
            rectangles[0] = new RectangleF(-350, -15-500 + yP, 30, 30);
            rectangles[1] = new RectangleF( 320, -15 - 500 + yP, 30, 30);

            rectangles[2] = new RectangleF(-320, -40-500 + yP, 640, 80);
            rectangles[3] = new RectangleF(-310, -30 - 500 + yP, 620, 60);

            rectangles[4] = new RectangleF(-260, -24 - 500 + yP, 520, 48);
            //rectangles[4] = new Rectangle(-330, 375, 660, 60);
            //rectangles[5] = new Rectangle(-300, -510, 600, 20);
            //rectangles[6] = new Rectangle(-300, 395, 600, 20);
            g.FillRectangle(new SolidBrush(Color.FromArgb(51,51,51)), rectangles[0]);
            g.FillRectangle(new SolidBrush(Color.FromArgb(51, 51, 51)), rectangles[1]);
            g.FillRectangle(Brushes.Gray, rectangles[2]);
            g.FillRectangle(Brushes.LightGray, rectangles[3]);
            g.FillRectangle(Brushes.LightGray, rectangles[4]);

            g.DrawRectangles(border, rectangles);

            string pos = "当前位置：" + (yP).ToString() + " mm";
            //g.DrawString("当前位置：", new Font("微软雅黑", 30), new SolidBrush(Color.Black), new PointF(-100 , -500+30+yP));
            g.DrawString(pos, new Font("微软雅黑", 30), new SolidBrush(Color.Black), new PointF(-200, -500-25+ yP));
        }

        private void DrawBackGround()
        {
            Rectangle[] rectangles = new Rectangle[10];
            //外侧大长方形
            rectangles[0] = new Rectangle(-550, -650, 1100, 1300);
            rectangles[1] = new Rectangle(-500, -600, 1000, 1200);
            //活塞槽
            rectangles[2] = new Rectangle(-234, -235, 468, 468);

            //溢粉槽
            rectangles[3] = new Rectangle(-330, -530, 660, 60);
            rectangles[4] = new Rectangle(-330, 375, 660, 60);
            rectangles[5] = new Rectangle(-300, -510, 600, 20);
            rectangles[6] = new Rectangle(-300, 395, 600, 20);

            //两边矩形
            rectangles[7] = new Rectangle(-495, -590, 50, 1180);
            rectangles[8] = new Rectangle( 445, -590, 50, 1180);

            g.FillRectangle(Brushes.LightGray, rectangles[0]);
            g.FillRectangle(Brushes.Gray, rectangles[1]);
            g.FillRectangle(Brushes.LightGray, rectangles[2]);
            g.FillRectangle(Brushes.LightGray, rectangles[3]);
            g.FillRectangle(Brushes.LightGray, rectangles[4]);
            g.FillRectangle(new SolidBrush(Color.White), rectangles[5]);
            g.FillRectangle(new SolidBrush(Color.White), rectangles[6]);
            g.FillRectangle(Brushes.LightGray, rectangles[7]);
            g.FillRectangle(Brushes.LightGray, rectangles[8]);

            g.DrawRectangles(border, rectangles);
            //四周圆形
            g.DrawString("下极限", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(560, -500-15));
            g.DrawString("接粉位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(560, -500+75-15));
            g.DrawString("打印位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(560, -15));
            g.DrawString("上极限", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(560, 405-15));
        }

    }
}
