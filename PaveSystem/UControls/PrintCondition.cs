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
    public partial class PrintCondition : UserControl
    {
        Graphics g = null;
        public float zoom, moveX, moveY;
        float xP = 0 ,xT=0;
        //Rectangle[] r_LightGrays, r_Grays, r_DarkGrays;
        Pen border = new Pen(Color.Black, 0.01F);
        public PrintCondition()
        {
            InitializeComponent();
            zoom = 0.35F;
            moveX = 0;
            moveY = 0;
            InitializeComponent();
            InitRect();
        }
        private void InitRect()
        {

        }

        public void SetPosition(float x)
        {
            xT = x;
            xP = x*1600/2460;
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
            DrawPrint();
            DrawLimit();
        }

        private void DrawLimit()
        {
            g.FillEllipse(Brushes.DarkRed, -825,515, 90, 90);

            g.FillEllipse(Brushes.DarkRed, -125, 515, 90, 90);

            g.FillEllipse(Brushes.DarkRed, 775, 515, 90, 90);



            if (Math.Abs(-xP+800 + 800) < 5)
            {
                g.FillEllipse(Brushes.Green, -825, 515, 90, 90);
            }
            if (Math.Abs(-xP+800 + 100) < 5)
            {
                g.FillEllipse(Brushes.Green, -125, 515, 90, 90);
            }
            if (Math.Abs(-xP+800 - 800) < 5)
            {
                g.FillEllipse(Brushes.Green, 775, 515, 90, 90);
            }
        }

        private void DrawPrint()
        {
            float start = -800;
            RectangleF[] rectangles = new RectangleF[12];
            //正中间
            rectangles[0] = new RectangleF(-150 - start - xP, -450, 300, 790);
                                                        
            //两侧                                      
            rectangles[1] = new RectangleF(-265 - start - xP, -450, 115, 790);
            rectangles[2] = new RectangleF( 150 - start - xP, -450, 115, 790);
                                                        
            //底部                                      
            rectangles[3] = new RectangleF(-265 - start - xP, 340, 530,20);
                                                        
            //上部                                      
            rectangles[4] = new RectangleF(-200 - start - xP, -470, 400, 20);
            rectangles[5] = new RectangleF(-200 - start - xP, -490, 400, 20);
                                                        
            //上部两侧                                  
            rectangles[6] = new RectangleF(-265 - start - xP, -470, 55, 20);
            rectangles[7] = new RectangleF( 210 - start - xP, -470, 55, 20);
                                                        
            //两侧装饰                                  
            rectangles[8] = new RectangleF(-255 - start - xP, -440, 95, 570);
            rectangles[9] = new RectangleF( 160 - start - xP, -440, 95, 570);
            rectangles[10] = new RectangleF(-255- start - xP, 140, 95, 190);
            rectangles[11] = new RectangleF(160 - start - xP, 140, 95, 190);

            //底部滑轮
            RectangleF[] r_bottom = new RectangleF[12];
            r_bottom[0] = new RectangleF(-235 - start - xP, 360, 15, 20);
            r_bottom[1] = new RectangleF(-220 - start - xP, 362, 10, 16);
            r_bottom[2] = new RectangleF(-210 - start - xP, 363, 10, 14);
            r_bottom[3] = new RectangleF(-170 - start - xP, 363, 10, 14);
            r_bottom[4] = new RectangleF(-160 - start - xP, 362, 10, 16);
            r_bottom[5] = new RectangleF(-150 - start - xP, 360, 15, 20);
                                                      
            r_bottom[6] = new RectangleF( 135 - start - xP, 360, 15, 20);
            r_bottom[7] = new RectangleF( 150 - start - xP, 362, 10, 16);
            r_bottom[8] = new RectangleF( 160 - start - xP, 363, 10, 14);
            r_bottom[9] = new RectangleF( 200 - start - xP, 363, 10, 14);
            r_bottom[10] = new RectangleF(210 - start - xP, 362, 10, 16);
            r_bottom[11] = new RectangleF(220 - start - xP, 360, 15, 20);

            Brush dark = new SolidBrush(Color.FromArgb(81, 81, 81));
            g.FillRectangle(Brushes.LightGray, rectangles[0]);
            g.FillRectangle(Brushes.Gray, rectangles[1]);
            g.FillRectangle(Brushes.Gray, rectangles[2]);
            g.FillRectangle(Brushes.LightGray, rectangles[3]);
            g.FillRectangle(Brushes.LightGray, rectangles[4]);
            g.FillRectangle(Brushes.LightGray, rectangles[5]);
            g.FillRectangle(dark, rectangles[6]);
            g.FillRectangle(dark, rectangles[7]);
            g.FillRectangle(dark, rectangles[8]);
            g.FillRectangle(dark, rectangles[9]);
            g.FillRectangle(dark, rectangles[10]);
            g.FillRectangle(dark, rectangles[11]);

            g.DrawRectangles(border, rectangles);

            g.FillRectangles(Brushes.DarkGray, r_bottom);

            g.DrawRectangles(border, r_bottom);

            string pos = "当前位置：" + (xP).ToString() + " mm";
            g.DrawString("当前位置：", new Font("微软雅黑", 30), new SolidBrush(Color.Black), new PointF(-100 - start - xP, 160));
            g.DrawString(xT.ToString() + " mm", new Font("微软雅黑", 30), new SolidBrush(Color.Black), new PointF(-100-  start - xP, 210));
        }

        private void DrawBackGround()
        {
            Rectangle[] rectangles = new Rectangle[15];
            //两侧短矩形
            rectangles[0] = new Rectangle(-1125, 350, 20, 115);
            rectangles[1] = new Rectangle(1105, 350, 20, 115);
            //最底下矩形
            rectangles[2] = new Rectangle( -1125,465,2250,10);
            //倒数第二个
            rectangles[3] = new Rectangle(-1105, 415, 2210, 50);
            //倒数第三个
            rectangles[4] = new Rectangle(-1105, 385, 2210, 20);
            //倒数第四个
            rectangles[5] = new Rectangle( -1100, 365, 2200, 20);
            //倒数第五个
            rectangles[6] = new Rectangle(-1105, 350, 2210, 10);
            //底部限位
            rectangles[7] = new Rectangle(-1125 + 210, 475, 70, 10);
            rectangles[8] = new Rectangle(-1125 + 750, 475, 70, 10);
            rectangles[9] = new Rectangle(-1125 + 1320, 475, 70, 10);
            rectangles[10] = new Rectangle(-1125+ 1880, 475, 70, 10);
            rectangles[11] = new Rectangle(-1125 + 210 +10, 485 , 50, 30);
            rectangles[12] = new Rectangle(-1125 + 750  +10, 485 , 50, 30);
            rectangles[13] = new Rectangle(-1125 + 1320 +10, 485 , 50, 30);
            rectangles[14] = new Rectangle(-1125 + 1880+10, 485 , 50, 30);

            g.FillRectangle(Brushes.Gray, rectangles[0]);
            g.FillRectangle(Brushes.Gray, rectangles[1]);
            g.FillRectangle(Brushes.Black, rectangles[2]);
            g.FillRectangle(Brushes.Gray, rectangles[3]);
            g.FillRectangle(Brushes.Gray, rectangles[4]);
            g.FillRectangle(Brushes.Black, rectangles[5]);
            g.FillRectangle(Brushes.Black, rectangles[6]);

            g.FillRectangle(Brushes.Gray, rectangles[7]);
            g.FillRectangle(Brushes.Gray, rectangles[8]);
            g.FillRectangle(Brushes.Gray, rectangles[9]);
            g.FillRectangle(Brushes.Gray, rectangles[10]);
            Brush brush = new SolidBrush(Color.FromArgb(65, 74, 161));
            g.FillRectangle(brush, rectangles[11]);
            g.FillRectangle(brush, rectangles[12]);
            g.FillRectangle(brush, rectangles[13]);
            g.FillRectangle(brush, rectangles[14]);

            g.DrawRectangles(border, rectangles);


            //左侧电机
            g.FillRectangle(Brushes.Gray, -1125-35, 350, 35, 50);
            g.DrawRectangle(border, -1125-35, 350, 35, 50);

            g.FillEllipse(Brushes.Gray, -1160-25, 375-25, 50, 50);
            g.DrawEllipse(border, -1160 - 25, 375 - 25, 50, 50);
            g.DrawEllipse(border, new RectangleF(-1160 - 17.5F, 375 - 17.5F, 35, 35));
            g.DrawEllipse(border, new RectangleF(-1160 - 10, 375 - 10, 20, 20));

            //右侧电机
            g.FillRectangle(Brushes.Gray, 1125, 350, 60, 50);
            g.DrawRectangle(border, 1125, 350, 60, 50);

            g.FillEllipse(Brushes.Gray,1135+25-25, 375 - 25, 50, 50);
            g.DrawEllipse(border, 1135, 375 - 25, 50, 50);
            g.DrawEllipse(border, new RectangleF( 1160 - 17.5F, 375 - 17.5F, 35, 35));
            g.DrawEllipse(border, new RectangleF( 1160 - 10, 375 - 10, 20, 20));

            g.DrawString("取件位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(-850, 620));
            g.DrawString("清粉位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(-150, 620));
            g.DrawString("打印位", new Font("微软雅黑", 30), new SolidBrush(Color.DarkRed), new PointF(750, 620));
        }
    }
}
