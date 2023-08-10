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

namespace PaveSystem
{
    public partial class PaveCondition : UserControl
    {
        public float WorkPosX, BladePos, WorkPosZ, PistonPos;
        public float moveX, moveY, zoom;
        public PaveCondition()
        {
            WorkPosX = 0;
            BladePos = 0;
            WorkPosZ = 0;
            PistonPos = 0;
            moveX = -50;
            moveY = 0;
            zoom = 0.5F;
            InitializeComponent();
        }
        public void SetPos(float p1, float p2, float p3, float p4)
        {
            BladePos = p1;
            PistonPos = p2;
            WorkPosX = p3;
            WorkPosZ = p4;
            this.pictureBox1.Refresh();
        }
        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;
            zoom += delta / 1200.0f; // 缩放因子
            if (zoom < 0.1)
            {
                zoom = 0.1F;
            }
            this.pictureBox1.Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.White);
            float x = pictureBox1.Width / 2;
            float y = pictureBox1.Height / 2;
            //// Then to scale, appending to world transform.
            graphics.TranslateTransform(x + moveX, y + moveY);
            graphics.ScaleTransform(zoom, -zoom);
            DrawLeftPowder(graphics);
            DrawWork(graphics);
            DrawRightPowder(graphics);
            DrawPlat(graphics);
            DrawBlade(graphics);
        }

        private void DrawBlade(Graphics graphics)
        {
            PointF[] pf;
            pf = GenParaLo(new PointF(142 + BladePos - 403, 463), -180, -360, 76, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.LightGreen, pf);

            //PointF[] pfs = new PointF[8];
            //pfs[0] = new PointF(-10 + BladePos - 300, 30);
            //pfs[1] = new PointF(-10 + BladePos - 300, 25);
            //pfs[2] = new PointF(-5 + BladePos - 300, 25);
            //pfs[3] = new PointF(-5 + BladePos - 300, 15);
            //pfs[4] = new PointF( 5 + BladePos - 300, 15);
            //pfs[5] = new PointF( 5 + BladePos - 300, 25);
            //pfs[6] = new PointF(10 + BladePos - 300, 25);
            //pfs[7] = new PointF(10 + BladePos - 300, 30);
            //graphics.DrawPolygon(new Pen(Color.Red), pfs);
            //graphics.FillPolygon(Brushes.DarkRed, pfs);


            pf = GenParaLo(new PointF(-38 + BladePos - 403, 103), 0, -98, 76, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.Green, pf);

            pf = GenParaLo(new PointF(38 + BladePos - 403, 103), 0, -98, 180, 360);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.DarkGreen, pf);
        }

        private void DrawWork(Graphics graphics)
        {
            PointF[] pf;
            //成型缸后侧
            pf = GenParaLo(new PointF(-84 + WorkPosX, 300 - WorkPosZ), 0, -500, 468, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.LightGray, pf);
            //成型缸左侧
            pf = GenParaLo(new PointF(-234 + WorkPosX, 0 - WorkPosZ), 0, -500, 150, 300);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.DarkGray, pf);
            //成型缸下侧
            pf = GenParaLo(new PointF(-84 + WorkPosX, -200 - WorkPosZ), -150, -300, 468, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.Gray, pf);

            //成型缸活塞
            pf = GenParaLo(new PointF(-84 + WorkPosX, -PistonPos + 300 - WorkPosZ), -150, -300, 468, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.LightBlue, pf);

            pf = GenParaLo(new PointF(-234 + WorkPosX, -PistonPos - WorkPosZ), 0, -30, 468, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.Blue, pf);

            //成型缸右侧
            pf = GenParaLo(new PointF(234 + WorkPosX, 0 - WorkPosZ), 0, -500, 150, 300);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.DarkGray, pf);
        }

        private void DrawRightPowder(Graphics graphics)
        {
            PointF[] pf;
            //粉缸左侧
            pf = GenParaLo(new PointF(434, 0), 0, -200, 150, 300);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.LightGray, pf);
            //粉缸后侧
            pf = GenParaLo(new PointF(584, 300), 0, -200, 88, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.DarkGray, pf);
            //粉缸下侧
            pf = GenParaLo(new PointF(584, 100), -150, -300, 88, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.Gray, pf);
            //粉缸右侧
            pf = GenParaLo(new PointF(522, 0), 0, -200, 150, 300);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.DarkGray, pf);
        }

        private void DrawLeftPowder(Graphics graphics)
        {
            PointF[] pf;
            //粉缸左侧
            pf = GenParaLo(new PointF(-447, 0), 0, -200, 150, 300);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.LightGray, pf);
            //粉缸后侧
            pf = GenParaLo(new PointF(-297, 300), 0, -200, 88, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.DarkGray, pf);
            //粉缸下侧
            pf = GenParaLo(new PointF(-297, 100), -150, -300, 88, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.Gray, pf);
            //粉缸右侧
            pf = GenParaLo(new PointF(-359, 0), 0, -200, 150, 300);
            graphics.DrawPolygon(new Pen(Color.Black), pf);
            graphics.FillPolygon(Brushes.DarkGray, pf);
        }
        private void DrawPlat(Graphics graphics)
        {
            PointF[] pfs = new PointF[16];
            pfs[0] = new PointF(-507, 0);
            pfs[1] = new PointF(-327, 360);
            pfs[02] = new PointF(762, 360);
            pfs[03] = new PointF(582, 0);
            pfs[04] = new PointF(522, 0);
            pfs[05] = new PointF(672, 300);
            pfs[06] = new PointF(584, 300);
            pfs[07] = new PointF(434, 0);
            pfs[08] = new PointF(234, 0);
            pfs[09] = new PointF(384, 300);
            pfs[10] = new PointF(-84, 300);
            pfs[11] = new PointF(-234, 0);
            pfs[12] = new PointF(-359, 0);
            pfs[13] = new PointF(-209, 300);
            pfs[14] = new PointF(-297, 300);
            pfs[15] = new PointF(-447, 0);
            graphics.DrawPolygon(new Pen(Color.Black), pfs);
            graphics.FillPolygon(Brushes.Gray, pfs);

        }

        private PointF[] GenParaLo(PointF pF, float v1, float v2, float v3, float v4)
        {
            PointF[] pf = new PointF[4];
            //成型缸后侧
            pf[0] = pF;
            pf[1] = new PointF(pF.X + v1, pF.Y + v2);
            pf[2] = new PointF(pF.X + v1 + v3, pF.Y + v2 + v4);
            pf[3] = new PointF(pF.X + v3, pF.Y + v4);
            return pf;
        }
    }
}
