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

namespace ClipperHelper
{
    public partial class SliceView : UserControl
    {
        public float moveX, moveY, moveXT, moveYT, zoom;
        public static int scale = 10000;
        public int xspace, yspace;
        private bool buttonDown = false;
        public Point startPoint,currentPoint;
        Color[][] colors = null;
        List<SlicePlane> sps = null;
        Graphics gph;
        public SliceView(List<SlicePlane> _sps, int _lasernum,int xSpace, int ySpace)
        {
            sps = _sps;
            int lasernum = _lasernum;
            InitColor(_lasernum);
        
            moveX = 0;
            moveY = 0;
            moveXT = 0;
            moveYT = 0;
            zoom = 1.0F;
            xspace = xSpace;
            yspace = ySpace;
            currentPoint = new Point(0, 0);
            InitializeComponent();

            this.LaserSelect.Items.Add("全部");
            for (int i = 0; i < lasernum; i++)
            {
                this.LaserSelect.Items.Add("激光" + (i + 1).ToString());
            }
            LaserSelect.SelectedIndex = 0;
        }

        private void InitColor(int num)
        {
            colors = new Color[num][];
            for (int i = 0; i < num; ++i)
            {
                colors[i] = new Color[8];
                colors[i][0] = Color.Black;
                colors[i][1] = Color.Purple;
                colors[i][2] = Color.DarkBlue;
                colors[i][3] = Color.Blue;
                colors[i][4] = Color.DarkGreen;
                colors[i][5] = Color.Green;
                colors[i][6] = Color.Red;
                colors[i][7] = Color.Pink;
            }
        }

        public void UpdareSlicePlane(List<SlicePlane> _sps)
        {
            sps = _sps;
            //int lasernum = sps.Count;
            //for (int i = 0; i < lasernum; i++)
            //{
            //    this.LaserSelect.Items.Add("激光" + (i + 1).ToString());
            //}
            //LaserSelect.SelectedIndex = 0;
            this.Viewer.Refresh();
        }
        private void Viewer_Resize(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void UpDate_Click(object sender, EventArgs e)
        {
            moveX = 0;
            moveY = 0;
            zoom = 1.0F;
            this.Viewer.Refresh();
        }

        private void LaserSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void MB_CheckedChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void MF_CheckedChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void UB_CheckedChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void UF_CheckedChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void DB_CheckedChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void DF_CheckedChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void SB_CheckedChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void SF_CheckedChanged(object sender, EventArgs e)
        {
            this.Viewer.Refresh();
        }

        private void Viewer_Paint(object sender, PaintEventArgs e)
        {
            gph = e.Graphics;
            gph.SmoothingMode = SmoothingMode.AntiAlias;
            gph.Clear(Color.White);
            float x = Viewer.Width / 2;
            float y = Viewer.Height / 2;
            string position = ((currentPoint.X-moveX-x - moveXT) /zoom).ToString("0.00") + "," + ((currentPoint.Y - moveY - y - moveYT) / zoom).ToString("0.00");
            gph.DrawString(position, new Font("微软雅黑",10),new SolidBrush(Color.Black),new PointF(20,y*2-20)) ;
            //// Then to scale, appending to world transform.
            gph.TranslateTransform(x + moveX + moveXT, y + moveY + moveYT);
            gph.ScaleTransform(zoom, -zoom);
            DrawPlat(xspace/2, yspace/2, gph);
            if (sps == null)
                return;
            if (LaserSelect.SelectedIndex == 0)
            {
                for(int i = 0; i < sps.Count; i++)
                {
                    DrawSlicePlane(sps[i], gph, 0, colors[i]);
                }
            }
            else
            {
                DrawSlicePlane(sps[LaserSelect.SelectedIndex - 1], gph, 0, colors[LaserSelect.SelectedIndex - 1]);
            }
        }

        private void ColorChange_Click(object sender, EventArgs e)
        {
            ColorChangeControl ccc = new ColorChangeControl(colors);
            ccc.ShowDialog();
            if (ccc.DialogResult == DialogResult.OK)
            {
                colors = ccc.colors;
            }
            this.Viewer.Refresh();
        }

        private void Viewer_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            buttonDown = true;
        }

        private void Viewer_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDown = false;
            moveX += moveXT;
            moveY += moveYT;
            moveXT = 0;
            moveYT = 0;
            this.Viewer.Refresh();
        }

        private void Viewer_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            if (buttonDown)
            {
                moveXT = currentPoint.X - startPoint.X;
                moveYT = currentPoint.Y - startPoint.Y;
            }
            this.Viewer.Refresh();
        }

        private void DrawSlicePlane(SlicePlane sp, Graphics graphics, int voidindex ,Color[] color)
        {
            if (MB.Checked)
            {
                foreach (var countors in sp.BaseRegionsCountors)
                {
                    List<PointF[]> ps = Helper.IntToPointFs(countors, scale);
                    foreach (var ring in ps)
                    {
                        if (ring.Count() > 0)
                            graphics.DrawLines(new Pen(color[0], 0.01F), ring);
                    }
                }
            }
            if (UB.Checked)
            {
                foreach (var countors in sp.UpperSurfacesCountors)
                {
                    foreach (var ring in Helper.IntToPointFs(countors, scale))
                    {
                        graphics.DrawLines(new Pen(color[2], 0.01F), ring);
                    }
                }
            }
            if (DB.Checked)
            {
                foreach (var countors in sp.LowerSurfacesCountors)
                {
                    foreach (var ring in Helper.IntToPointFs(countors, scale))
                    {
                        graphics.DrawLines(new Pen(color[4], 0.01F), ring);
                    }
                }
            }

            if (voidindex == 0)
            {
                if (MF.Checked)
                    foreach (var scanpaths in sp.BaseRegionsScanPath)
                    {
                        foreach (var ring in Helper.IntToPointFs(scanpaths, scale))
                        {
                            graphics.DrawLines(new Pen(color[1], 0.01F), ring);
                        }
                    }
                if (DF.Checked)
                    foreach (var scanpaths in sp.LowerSurfacesScanPath)
                    {
                        foreach (var ring in Helper.IntToPointFs(scanpaths, scale))
                        {
                            graphics.DrawLines(new Pen(color[3], 0.01F), ring);
                        }
                    }
                if (UF.Checked)
                    foreach (var scanpaths in sp.UpperSurfacesScanPath)
                    {
                        foreach (var ring in Helper.IntToPointFs(scanpaths, scale))
                        {
                            graphics.DrawLines(new Pen(color[5], 0.01F), ring);
                        }
                    }
            }
            else
            {
                if (MF.Checked)
                    foreach (var ring in Helper.IntToPointFs(sp.BaseRegionsScanPath[voidindex - 1], scale))
                    {
                        graphics.DrawLines(new Pen(color[1], 0.01F), ring);
                    }
                if (DF.Checked)
                    foreach (var ring in Helper.IntToPointFs(sp.LowerSurfacesScanPath[voidindex - 1], scale))
                    {
                        graphics.DrawLines(new Pen(color[3], 0.01F), ring);
                    }
                if (UF.Checked)
                    foreach (var ring in Helper.IntToPointFs(sp.UpperSurfacesScanPath[voidindex - 1], scale))
                    {
                        graphics.DrawLines(new Pen(color[5], 0.01F), ring);
                    }
            }

            if (SB.Checked)
            {
                foreach (var ring in Helper.IntToPointFs(sp.SupportCountors, scale))
                {
                    if (ring.Length > 0)
                        graphics.DrawLines(new Pen(color[6], 0.01F), ring);
                }
            }
            if (SF.Checked)
            {
                foreach (var rings in sp.SupportScanPath)
                {
                    foreach (var ring in Helper.IntToPointFs(rings, scale))
                    {
                        graphics.DrawLines(new Pen(color[7], 0.01F), ring);
                    }
                }
            }
        }

        private void DrawPlat(int x, int y, Graphics g)
        {
            float a = 20;
            Pen pen = new Pen(Color.Black);//画笔颜色      
            g.DrawLine(pen, -(x - a), -y, x - a, -y);
            g.DrawLine(pen, x, -(y - a), x, y - a);
            g.DrawLine(pen, x - a, y, -(x - a), y);
            g.DrawLine(pen, -x, y - a, -x, -y + a);
            g.DrawArc(pen, -x, -y, 2 * a, 2 * a, 180, 90);
            g.DrawArc(pen, (x - 2 * a), -y, 2 * a, 2 * a, 270, 90);
            g.DrawArc(pen, -x, (y - 2 * a), 2 * a, 2 * a, 90, 90);
            g.DrawArc(pen, (x - 2 * a), (y - 2 * a), 2 * a, 2 * a, 0, 90);
            g.DrawEllipse(pen, -(x - a), (y - 2 * a), a, a);
            g.DrawEllipse(pen, (x - 2 * a), (y - 2 * a), a, a);
            g.DrawEllipse(pen, (x - 2 * a), -(y - a), a, a);
            g.DrawEllipse(pen, -(x - a), -(y - a), a, a);
        }

        private void Viewer_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;
            zoom += delta / 1200.0f; // 缩放因子
            if (zoom < 0.1)
            {
                zoom = 0.1F;
            }
            this.Viewer.Refresh();
        }
    }
}
