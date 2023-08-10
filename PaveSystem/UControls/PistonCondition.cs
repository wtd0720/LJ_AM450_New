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
    public partial class PistonCondition : UserControl
    {
        Graphics g = null;
        public float zoom,moveX,moveY;
        float zP = 0;
        Rectangle[] r_LightGrays, r_Grays, r_DarkGrays;
        public PistonCondition()
        {
            zoom = 0.4F;
            moveX = 0;
            moveY = 0;
            InitializeComponent();
            InitRect();
            //g = this.CreateGraphics();
        }

        private void InitRect()
        {
            r_LightGrays = new Rectangle[11];
            //中间矩形
            r_LightGrays[0] = new Rectangle(-225, -800, 450, 1600);
            r_LightGrays[1] = new Rectangle(-130, -800, 260, 1600);

            //两侧长矩形
            r_LightGrays[2] = new Rectangle(-255, -755, 30, 1555);
            r_LightGrays[3] = new Rectangle(225, -755, 30, 1555);

            //顶部两侧矩形
            r_LightGrays[4] = new Rectangle(-385, -780, 160, 30);
            r_LightGrays[5] = new Rectangle(-385, -800, 160, 20);

            r_LightGrays[6] = new Rectangle(225, -780, 160, 30);
            r_LightGrays[7] = new Rectangle(225, -800, 160, 20);

            r_LightGrays[8] = new Rectangle(-235, -800, 10, 30);
            r_LightGrays[9] = new Rectangle(225, -800, 10, 30);

            //底部矩形
            r_LightGrays[10] = new Rectangle(-515, 800, 1030, 50);
           

            r_Grays = new Rectangle[6];
            //两侧灰色矩形
            r_Grays[0] = new Rectangle(-515,-740, 260, 1540);
            r_Grays[1] = new Rectangle(255, -740, 260, 1540);

            //中间灰色
            r_Grays[2] = new Rectangle(-210, 480, 180, 200);
            r_Grays[3] = new Rectangle( 30, 480, 180, 200);
            r_Grays[4] = new Rectangle(-135, 775, 110, 25);
            r_Grays[5] = new Rectangle( 25, 775, 110, 25);


            r_DarkGrays = new Rectangle[4];
            r_DarkGrays[0] = new Rectangle(-515, -770, 110, 30);
            r_DarkGrays[1] = new Rectangle(405, -770, 110, 30);
            r_DarkGrays[2] = new Rectangle(-510, -770, 100, 30);
            r_DarkGrays[3] = new Rectangle(410, -770, 100, 30);
        }

        public void SetPosition(float z)
        {
            zP = -z;
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
            DrawPiston();
            DrawLimit();
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //int delta = e.Delta;
            //zoom += delta / 1200.0f; // 缩放因子
            //if (zoom < 0.1)
            //{
            //    zoom = 0.1F;
            //}
            this.Refresh();
        }
        private void DrawLimit()
        {
            g.FillEllipse(Brushes.DarkRed, -400, -630, 90, 90);
            g.FillEllipse(Brushes.DarkRed, 310, -630, 90, 90);

            g.FillEllipse(Brushes.DarkRed, -400, 170, 90, 90);
            g.FillEllipse(Brushes.DarkRed, 310, 170, 90, 90);

            if (zP == -500)
            {
                g.FillEllipse(Brushes.Green, -400, -630, 90, 90);
                g.FillEllipse(Brushes.Green, 310, -630, 90, 90);
            }
            if (zP == 0)
            {
                g.FillEllipse(Brushes.Green, -400, 170, 90, 90);
                g.FillEllipse(Brushes.Green, 310, 170, 90, 90);
            }
        }


        private void DrawPiston()
        {
            RectangleF[] rectangles = new RectangleF[9];
            rectangles[0] = new RectangleF(-225, -300+zP, 450, 20);
            rectangles[1] = new RectangleF(-225, -280+zP, 450, 60);
            rectangles[2] = new RectangleF(-225, -220+zP, 450, 60);
            rectangles[3] = new RectangleF(-225, -160+zP, 450, 10);
            rectangles[4] = new RectangleF(-225, -150+zP, 450, 60);
            rectangles[5] = new RectangleF(-225, -90+zP, 450, 60);
            rectangles[6] = new RectangleF(-225, -30+zP, 450, 180);
            rectangles[7] = new RectangleF(-225, 150 + zP, 60, 50);
            rectangles[8] = new RectangleF( 165, 150 + zP, 60, 50);
            
            g.FillRectangle(Brushes.LightGray, rectangles[0]);
            g.FillRectangle(Brushes.Gray, rectangles[1]);
            g.FillRectangle(new SolidBrush(Color.FromArgb(97, 102, 108)), rectangles[2]);
            g.FillRectangle(Brushes.PowderBlue, rectangles[3]);
            g.FillRectangle(Brushes.Gray, rectangles[4]);
            g.FillRectangle(Brushes.LightGray, rectangles[5]);
            g.FillRectangle(Brushes.Gray, rectangles[6]);
            g.FillRectangle(Brushes.Gray, rectangles[7]);
            g.FillRectangle(Brushes.Gray, rectangles[8]);

            g.DrawRectangles(new Pen(Color.Black, 0.01F), rectangles);
            string pos = "当前位置：" + (-zP).ToString() + " mm";
            g.DrawString(pos, new Font("微软雅黑", 30), new SolidBrush(Color.Black), new PointF(-180, 100 + zP));

            //g.DrawRectangle(new Pen(Color.Red, 0.1F),-225, 300 - 500 + zP, 450,500);
        }

        private void DrawBackGround()
        {

            g.FillRectangles(Brushes.LightGray, r_LightGrays);
            g.FillRectangles(Brushes.Gray, r_Grays);
            g.FillRectangles(Brushes.DarkGray, r_DarkGrays);


            g.DrawRectangles(new Pen(Color.Black, 0.01F), r_Grays);
            g.DrawRectangles(new Pen(Color.Black, 0.01F), r_LightGrays);
            g.DrawRectangles(new Pen(Color.Black, 0.01F), r_DarkGrays);

            g.FillRectangle(Brushes.LightGray, r_LightGrays[2]);
            g.FillRectangle(Brushes.LightGray, r_LightGrays[3]);
            g.FillRectangle(Brushes.LightGray, r_LightGrays[8]);
            g.FillRectangle(Brushes.LightGray, r_LightGrays[9]);
            g.DrawRectangle(new Pen(Color.Black, 0.01F), r_LightGrays[2]);
            g.DrawRectangle(new Pen(Color.Black, 0.01F), r_LightGrays[3]);
            g.DrawRectangle(new Pen(Color.Black, 0.01F), r_LightGrays[8]);
            g.DrawRectangle(new Pen(Color.Black, 0.01F), r_LightGrays[9]);

            g.FillRectangle(Brushes.Gray, r_Grays[2]);
            g.FillRectangle(Brushes.Gray, r_Grays[3]);
            g.FillRectangle(Brushes.Gray, r_Grays[4]);
            g.FillRectangle(Brushes.Gray, r_Grays[5]);

            g.DrawString("上限位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(-650, -600));
            g.DrawString("上限位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(515, -600));
            g.DrawString("下限位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(-650, 200));
            g.DrawString("下限位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(515, 200));
        }
    }
}
