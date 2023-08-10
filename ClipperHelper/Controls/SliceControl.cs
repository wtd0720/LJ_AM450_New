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
    public partial class SliceControl : UserControl
    {
        public float moveX, moveY, zoom;
        public static int scale = 10000;
        public SlcModel sm = null;
        public SlicePara para = null;
        public List<SlicePlane> sps = null;
        public int laserNum = 1;
        public int xspace, yspace;

        public SliceControl(SlcModel slcModel,SlicePara _para  , int LaserNum,int xSpace,int ySpace)
        {
            sm = slcModel;
            moveX = 0;
            moveY = 0;
            zoom = 1.0F;
            para = _para;
            laserNum = LaserNum;
            xspace = xSpace;
            yspace = ySpace;
            InitializeComponent();
            for (int i = 0; i < sm.LayNum; i++)
            {
                this.CurrentLayer.Items.Add((i+1).ToString());
            }
            this.CurrentLayer.SelectedIndex = 0;
            this.LaserReigon.Items.Add("全部");          
            for (int i = 0; i < LaserNum; i++)
            {
                this.LaserReigon.Items.Add("激光"+(i + 1).ToString());
            }
            LaserReigon.SelectedIndex = 0;
            propertyGrid1.SelectedObject = para.BaseSlicePara;
        }
        private void Painter_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.White);
            float x = Painter.Width / 2;
            float y = Painter.Height / 2;
            //// Then to scale, appending to world transform.
            graphics.TranslateTransform(x+moveX, y+moveY);
            graphics.ScaleTransform(zoom, -zoom);
            DrawPlat(xspace,yspace, graphics);
            if (sps == null)
                return;
            if (LaserReigon.SelectedIndex == 0)
            {
                foreach (var i in sps)
                {
                    DrawSlicePlane(i, graphics, 0);
                }
            }
            else
            {
                DrawSlicePlane(sps[LaserReigon.SelectedIndex -1 ], graphics, 0);
            }
            
        }

        private void zoomin_Click(object sender, EventArgs e)
        {
            this.zoom -= 0.5f;
            if (zoom < 0.1)
            {
                zoom = 0.1F;
            }
            this.Painter.Refresh();
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            this.zoom += 0.5f;
            this.Painter.Refresh();
        }

        private void moveup_Click(object sender, EventArgs e)
        {
            this.moveY -= 100;
            this.Painter.Refresh();
        }

        private void movedown_Click(object sender, EventArgs e)
        {
            this.moveY += 100;
            this.Painter.Refresh();
        }

        private void moveleft_Click(object sender, EventArgs e)
        {
            this.moveX -= 100;
            this.Painter.Refresh();
        }

        private void moveright_Click(object sender, EventArgs e)
        {
            this.moveX += 100;
            this.Painter.Refresh();
        }
        private void UpDate_Click(object sender, EventArgs e)
        {
            moveX = 0;
            moveY = 0;
            zoom = 1.0F;
            UpdateSlicePlane();
            this.Painter.Refresh();
        }
        private void BaseSlicePara_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = para.BaseSlicePara;
        }

        private void BasePara_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = para.BaseRegionSlicePare;
        }

        private void UpperPara_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = para.UpperSurfaceSlicePara;
        }

        private void LowerPara_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = para.LowerSurfaceSlicePara;
        }

        private void SupportPara_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = para.SupportSlicePare;
        }

        private void BaseCountor_Click(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void BathScanPath_Click(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void UpperCountor_Click(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void UpperScanPath_Click(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void LowerCountor_Click(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void LowerScanpath_Click(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void SupportC_Click(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void SupportS_Click(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void CurrentLayer_TextChanged(object sender, EventArgs e)
        {           
            UpdateSlicePlane();
            this.HeightLabel.Text = "层高"+(sm.LayerHeight* CurrentLayer.SelectedIndex).ToString()+"mm";
            this.Painter.Refresh();
        }


        private void Painter_Resize(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        public void UpdateSlicePlane()
        {
            int i = CurrentLayer.SelectedIndex;
            CurrentSlicePlane csp = null;
            if (sm.SupportCountors == null)
            {
                csp = new CurrentSlicePlane(sm.ModelCountors.allCountors[i], sm.ModelCountors.allCountors[i + 1], sm.ModelCountors.allCountors[i + 2]);
            }
            else
            {
                csp = new CurrentSlicePlane(sm.ModelCountors.allCountors[i], sm.ModelCountors.allCountors[i + 1], sm.ModelCountors.allCountors[i + 2], sm.SupportCountors.allCountors[i]);
            }
            SlicePlane sp = new SlicePlane(csp,para,i);
            sps = SlicePlane.DivideByLaserRegion(sp, para.BaseSlicePara, laserNum, xspace, yspace);
        }

        private void LaserReigon_TextChanged(object sender, EventArgs e)
        {
            this.Painter.Refresh();
        }

        private void PreLayer_Click(object sender, EventArgs e)
        {
            if(CurrentLayer.SelectedIndex>1)
                CurrentLayer.SelectedIndex -= 1;
        }

        private void NextLayer_Click(object sender, EventArgs e)
        {
            if (CurrentLayer.SelectedIndex < sm.LayNum - 1)
                CurrentLayer.SelectedIndex += 1;
        }

        private void PreView_Click(object sender, EventArgs e)
        {
            timerView.Start();
        }

        private void timerView_Tick(object sender, EventArgs e)
        {
            CurrentLayer.SelectedIndex = 0;
            for (int i = 1; i < sm.LayNum - 1;i++)
            {
                CurrentLayer.SelectedIndex = i;
            }
        }

        private void ViewStop_Click(object sender, EventArgs e)
        {
            timerView.Stop();
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
        private void Painter_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;
            zoom += delta / 1200.0f; // 缩放因子
            if (zoom < 0.1)
            {
                zoom = 0.1F;
            }               
            this.Painter.Refresh();
        }
        private void DrawSlicePlane(SlicePlane sp, Graphics graphics, int voidindex)
        {
            if (BaseCountor.Checked)
            {
                foreach (var countors in sp.BaseRegionsCountors)
                {
                    List<PointF[]> ps = Helper.IntToPointFs(countors, scale);
                    foreach (var ring in ps)
                    {
                        if (ring.Count() > 0)
                            graphics.DrawLines(new Pen(Color.Black, 0.01F), ring);
                    }
                }
            }
            if (UpperCountor.Checked)
            {
                foreach (var countors in sp.UpperSurfacesCountors)
                {
                    foreach (var ring in Helper.IntToPointFs(countors, scale))
                    {
                        graphics.DrawLines(new Pen(Color.Pink, 0.01F), ring);
                    }
                }
            }
            if (LowerCountor.Checked)
            {
                foreach (var countors in sp.LowerSurfacesCountors)
                {
                    foreach (var ring in Helper.IntToPointFs(countors, scale))
                    {
                        graphics.DrawLines(new Pen(Color.Green, 0.01F), ring);
                    }
                }
            }
          
            if (voidindex == 0)
            {
                if(BathScanPath.Checked)
                    foreach (var scanpaths in sp.BaseRegionsScanPath)
                    {
                        foreach (var ring in Helper.IntToPointFs(scanpaths, scale))
                        {
                            graphics.DrawLines(new Pen(Color.Purple, 0.01F), ring);
                        }
                    }
                if (LowerScanpath.Checked)
                    foreach (var scanpaths in sp.LowerSurfacesScanPath)
                    {
                        foreach (var ring in Helper.IntToPointFs(scanpaths, scale))
                        {
                            graphics.DrawLines(new Pen(Color.Purple, 0.01F), ring);
                        }
                    }
                if (UpperScanPath.Checked)
                    foreach (var scanpaths in sp.UpperSurfacesScanPath)
                    {
                        foreach (var ring in Helper.IntToPointFs(scanpaths, scale))
                        {
                            graphics.DrawLines(new Pen(Color.Purple, 0.01F), ring);
                        }
                    }
            }
            else
            {
                if (BathScanPath.Checked)
                    foreach (var ring in Helper.IntToPointFs(sp.BaseRegionsScanPath[voidindex - 1], scale))
                    {
                        graphics.DrawLines(new Pen(Color.Purple, 0.01F), ring);
                    }
                if (LowerScanpath.Checked)
                    foreach (var ring in Helper.IntToPointFs(sp.LowerSurfacesScanPath[voidindex - 1], scale))
                    {
                        graphics.DrawLines(new Pen(Color.Purple, 0.01F), ring);
                    }
                if (UpperScanPath.Checked)
                    foreach (var ring in Helper.IntToPointFs(sp.UpperSurfacesScanPath[voidindex - 1], scale))
                    {
                        graphics.DrawLines(new Pen(Color.Purple, 0.01F), ring);
                    }
            }
            
            if (SupportC.Checked)
            {
                foreach (var ring in Helper.IntToPointFs(sp.SupportCountors, scale))
                {
                    if (ring.Length >0)
                        graphics.DrawLines(new Pen(Color.Red, 0.01F), ring);
                }
            }

        }

    }
}
