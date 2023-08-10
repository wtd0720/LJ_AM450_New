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
    public partial class HomeCondition : UserControl
    {
        Graphics g = null;
        public float zoom, moveX, moveY;
        float yP = 0,zP =0;
        Pen border = new Pen(Color.Black, 0.01F);
        public HomeCondition()
        {
            zoom = 0.5F;
            moveX = 0;
            moveY = -50;
            InitializeComponent();
        }
        public void SetPosition(float y,float z)
        {
            yP = y;
            zP = z;
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
            DrawPiston();
            DrawLimit();
        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;
            zoom += delta / 1200.0f; // 缩放因子
            if (zoom < 0.1)
            {
                zoom = 0.1F;
            }
            this.Refresh();
        }
        private void DrawPiston()
        {
            RectangleF[] rectangles = new RectangleF[9];
            rectangles[0] = new RectangleF(-675 + 388.5F, 300-300 + zP, 468, 20);
            rectangles[1] = new RectangleF(-675 + 388.5F, 300-280 + zP, 468, 60);
            rectangles[2] = new RectangleF(-675 + 388.5F, 300-220 + zP, 468, 60);
            rectangles[3] = new RectangleF(-675 + 388.5F, 300-160 + zP, 468, 10);
            rectangles[4] = new RectangleF(-675 + 388.5F, 300-150 + zP, 468, 60);
            rectangles[5] = new RectangleF(-675 + 388.5F, 300-90 + zP, 468, 60);
            rectangles[6] = new RectangleF(-675 + 388.5F, 300-30 + zP, 468, 180);
            rectangles[7] = new RectangleF(-675 + 388.5F, 300+150 + zP, 60, 50);
            rectangles[8] = new RectangleF(-675 + 388.5F+468-60, 300 + 150 + zP, 60, 50);

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
        }

        private void DrawLimit()
        {
            //g.FillEllipse(Brushes.DarkRed, 445, -525, 50, 50);

            //g.FillEllipse(Brushes.DarkRed, 445, -500 + 75-25, 50, 50);

            //g.FillEllipse(Brushes.DarkRed, 445, -25, 50, 50);

            //g.FillEllipse(Brushes.DarkRed, 445, 405-25, 50, 50);



            //if (Math.Abs(yP) < 5)
            //{
            //    g.FillEllipse(Brushes.Green, 445, -525, 50, 50);
            //}
            //if (Math.Abs(yP-75) < 5)
            //{
            //    g.FillEllipse(Brushes.Green, 445, -500 + 75 - 25, 50, 50);
            //}
            //if (yP< 733 && yP >265)
            //{
            //    g.FillEllipse(Brushes.Green, 445, -25, 50, 50);
            //}
            //if (Math.Abs(yP-905) < 5)
            //{
            //    g.FillEllipse(Brushes.Green, 445, -25, 50, 50);
            //}
        }

        private void DrawBlade()
        {
            Brush brush = new SolidBrush(Color.FromArgb(100, 103, 118));
            g.FillRectangle(brush, 426 -yP-55, -194.5F, 50,12);
            g.DrawRectangle(border,426 -yP -55, -194.5F, 50, 12);
            g.FillRectangle(brush, 426 -yP+5, -194.5F, 50, 12);
            g.DrawRectangle(border,426 -yP+ 5, -194.5F, 50, 12);

            g.FillRectangle(brush, 426 -yP-55, -182.5F, 110, 38);
            g.DrawRectangle(border,426 -yP -55, -182.5F, 110, 38);

            g.FillRectangle(brush, 426 -yP-32, -182.5F+38, 64, 18.5F);
            g.DrawRectangle(border,426 -yP -32, -182.5F +38, 64, 18.5F);

            g.FillRectangle(brush, 426 -yP-35, -126, 70, 30F);
            g.DrawRectangle(border,426 -yP -35, -126, 70, 30F);

            g.FillRectangle(Brushes.Gray, 426 - yP - 38, -107F, 76, 48);
            g.DrawRectangle(border,426 -yP -38, -107F, 76, 48F);

            g.FillRectangle(brush, 426 -yP-38, -59, 76, 25);
            g.DrawRectangle(border,426 -yP -38, -59, 76, 25);
            //两边挡板            
            g.FillRectangle(brush, 426 -yP-38, -102, 3, 98);
            g.DrawRectangle(border,426 -yP -38, -102, 3, 98);
            g.FillRectangle(brush, 426 -yP+35, -102, 3, 98);
            g.DrawRectangle(border,426 -yP+ 35, -102, 3, 98);
                           
            g.FillRectangle(brush, 426 -yP-12.25F, -34, 24.5F, 20);
            g.DrawRectangle(border,426 -yP -12.25F, -34, 24.5F, 20);
                              
            //刮刀                
            g.FillRectangle(brush, 426 -yP-5, -23, 10, 21);
            g.DrawRectangle(border,426 -yP -5, -23, 10, 21);
        }

        private void DrawBackGround()
        {
            //腔体最外层轮廓
            PointF[] outlines = new PointF[6];
            outlines[0] = new PointF(-675,20);
            outlines[1] = new PointF(-675, -534);
            outlines[2] = new PointF(290, -534);
            outlines[3] = new PointF(290, -380);
            outlines[4] = new PointF(675, -380);
            outlines[5] = new PointF(675, 20);

            g.FillPolygon(Brushes.Gray, outlines);
            g.DrawPolygon(border, outlines);

            //腔体内层轮廓
            outlines = new PointF[6];
            outlines[0] = new PointF(-645, 20);
            outlines[1] = new PointF(-645, -499);
            outlines[2] = new PointF(275, -499);
            outlines[3] = new PointF(275, -350);
            outlines[4] = new PointF(645, -350);
            outlines[5] = new PointF(645, 20);
            g.FillPolygon(Brushes.LightGray, outlines);
            g.DrawPolygon(border, outlines);

            //底部基板
            outlines = new PointF[8];
            outlines[0] = new PointF(-700, 20);
            outlines[1] = new PointF(-645, 20);
            outlines[2] = new PointF(-645, 0);
            outlines[3] = new PointF(645, 0);
            outlines[4] = new PointF(645, 20);
            outlines[5] = new PointF(700, 20);
            outlines[6] = new PointF(700, 45);
            outlines[7] = new PointF(-700, 45);
            g.FillPolygon(Brushes.Gray, outlines);
            g.DrawPolygon(border, outlines);


            //前溢粉槽           
            g.FillRectangle(Brushes.LightGray, -500,0,88,8.5F);
            g.DrawRectangle(border, -500, 0, 88, 8.5F);
            g.FillRectangle(Brushes.LightGray, -485, 8.5F, 40, 36.5F);
            g.DrawRectangle(border, -485, 8.5F, 40, 36.5F);

            //后溢粉槽           
            g.FillRectangle(Brushes.LightGray, 675 - 293, 0, 88, 8.5F);
            g.DrawRectangle(border, 675 - 293, 0, 88, 8.5F);
            g.FillRectangle(Brushes.LightGray, 675 - 293+33, 8.5F, 40, 36.5F);
            g.DrawRectangle(border, 675 - 293 + 33, 8.5F, 40, 36.5F);

            //工作缸槽
            g.FillRectangle(Brushes.LightGray, -675+388.5F, 0, 468, 45);
            g.DrawRectangle(border, -675 + 388.5F, 0, 468, 45);

            //滑带
            Brush brush = new SolidBrush(Color.FromArgb(95, 95, 95));
            //左带块
            g.FillRectangle(brush, -675 + 65F, -263.5F, 65, 96);
            g.DrawRectangle(border, -675 + 65F, -263.5F, 65, 96);
            //上皮带
            g.FillRectangle(brush, -675 + 105F, -248.3F, 1168, 3.6F);
            g.DrawRectangle(border, -675 + 105F, -248.3F, 1168, 3.6F);
            //下皮带
            g.FillRectangle(brush, -675 + 105F, -186.3F, 1168, 3.6F);
            g.DrawRectangle(border, -675 + 105F, -186.3F, 1168, 3.6F);
            //左滑轮
            g.FillEllipse(brush, -675 + 105F - 33, -215.5F- 33, 66, 66);
            g.DrawEllipse(border, -675 + 105F - 33, -215.5F - 33, 66, 66);

            g.FillEllipse(Brushes.LightGray, -675 + 105F - 13.5F, -215.5F - 13.5F, 27, 27);
            g.DrawEllipse(border, -675 + 105F - 13.5F, -215.5F - 13.5F, 27, 27);
            //右滑轮
            g.FillEllipse(brush, -675 + 105F - 33+1168, -215.5F - 33, 66, 66);
            g.DrawEllipse(border, -675 + 105F - 33+1168,- 215.5F - 33, 66, 66);
            g.FillEllipse(Brushes.LightGray, -675 + 105F - 13.5F + 1168, -215.5F - 13.5F, 27, 27);
            g.DrawEllipse(border, -675 + 105F - 13.5F + 1168, -215.5F - 13.5F, 27, 27);

            //下部滑块
            g.FillRectangle(brush, -675 + 75F, -143.5F, 1176, 60F);
            g.DrawRectangle(border, -675 + 75F, -143.5F, 1176, 60F);

            //几个方孔
            RectangleF[] rectangleFs = new RectangleF[8];
            rectangleFs[0] = new RectangleF(-675 + 347.5F,-339,135,60);
            rectangleFs[1] = new RectangleF(-675 + 347.5F+140, -339, 135, 60);
            rectangleFs[2] = new RectangleF(-675 + 347.5F+280, -339, 135, 60);
            rectangleFs[3] = new RectangleF(-675 + 347.5F+420, -339, 135, 60);

            rectangleFs[4] = new RectangleF(-675 + 347.5F,-60, 135, 40);
            rectangleFs[5] = new RectangleF(-675 + 347.5F + 140, -60, 135, 40);
            rectangleFs[6] = new RectangleF(-675 + 347.5F + 280, -60, 135, 40);
            rectangleFs[7] = new RectangleF(-675 + 347.5F + 420, -60, 135, 40);
            g.FillRectangles(Brushes.White, rectangleFs);
            g.DrawRectangles(border, rectangleFs);

            //活塞槽
            //整体
            g.FillRectangle(Brushes.LightGray, -675 + 388.5F, 45, 468, 1665);
            g.DrawRectangle(border, -675 + 388.5F, 45, 468, 1665);
            g.DrawRectangle(border, -675 + 388.5F + 234-137.5F, 45, 275, 1665);

            //上边小块
            g.FillRectangle(Brushes.LightGray, -675 + 388.5F- 166F, 45, 166, 25);
            g.DrawRectangle(border, -675 + 388.5F - 166F, 45, 166, 25);
            g.FillRectangle(Brushes.LightGray, -675 + 388.5F - 166F, 70, 166, 30);
            g.DrawRectangle(border, -675 + 388.5F - 166F, 70, 166, 30);

            g.FillRectangle(Brushes.LightGray, -675 + 388.5F +468, 45, 166, 25);
            g.DrawRectangle(border, -675 + 388.5F + 468, 45, 166, 25);
            g.FillRectangle(Brushes.LightGray, -675 + 388.5F + 468, 70, 166, 30);
            g.DrawRectangle(border, -675 + 388.5F + 468, 70, 166, 30);

            g.FillRectangle(Brushes.LightGray, -675 + 388.5F -5, 45, 5, 30);
            g.DrawRectangle(border, -675 + 388.5F - 5, 45, 5, 30);

            g.FillRectangle(Brushes.LightGray, -675 + 388.5F + 468, 45, 5, 30);
            g.DrawRectangle(border, -675 + 388.5F + 468, 45, 5, 30);
            //两侧边
            g.FillRectangle(Brushes.LightGray, -675 + 388.5F -25, 98, 25, 1665-98+45);
            g.DrawRectangle(border, -675 + 388.5F - 25, 98, 25, 1665 - 98+45);

            g.FillRectangle(Brushes.LightGray, -675 + 388.5F +468 , 98, 25, 1665 - 98+45);
            g.DrawRectangle(border, -675 + 388.5F + 468, 98, 25, 1665 - 98+45);
        }

    }
}
