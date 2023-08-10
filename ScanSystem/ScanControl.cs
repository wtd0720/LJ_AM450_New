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

namespace ScanSystem
{
    public partial class ScanControl : UserControl
    {
        public float moveX, moveY, zoom;
        public List<PointF[]> ScanGraph;
        public List<PointF[]> FillPath;
        public ScanPara para = new ScanPara(0);
        public LaserPara lpara = new LaserPara();
        public Scan sc = null;
        public ScanControl(Scan _sc)
        {
            zoom = 1.2F;
            sc = _sc;

            InitializeComponent();
            Label.CheckForIllegalCrossThreadCalls=false;
            ParaGrid.SelectedObject = para;
            if (sc.isconct)
            {
                this.StateLabel.Text = "已连接";
                this.PicState.Image = ScanSystem.Properties.Resources.connectstate;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (!sc.isconct)
            {
                if (sc.init())
                {
                    this.StateLabel.Text = "已连接";
                    this.PicState.Image = ScanSystem.Properties.Resources.connectstate;
                }
            }
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            if (!sc.isconct)
            {
                MessageBox.Show("未连接振镜");
                this.PicState.Image = ScanSystem.Properties.Resources.errorstate;
                return;
            }
            await Task.Run(() =>
            {
                this.StateLabel.Text = "运行中";
                this.PicState.Image = ScanSystem.Properties.Resources.running;
                if (FillPath != null)
                {
                    sc.StartScan(FillPath, para, lpara, false);
                }
                sc.StartScan(ScanGraph, para,lpara, true);                
                this.StateLabel.Text = "已就绪";
                this.PicState.Image = ScanSystem.Properties.Resources.complete;
            });
        }

        private void Pause_Click(object sender, EventArgs e)
        {

        }

        private void Input_Click(object sender, EventArgs e)
        {

        }

        private void Strech_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.White);
            float x = Strech.Width / 2;
            float y = Strech.Height / 2;
            

            //// Then to scale, appending to world transform.
            graphics.TranslateTransform(x,y);
            graphics.ScaleTransform(zoom, -zoom);
            //// Draw rotated, scaled rectangle to screen.
            //graphics.DrawRectangle(new Pen(Color.Blue, 2), -100, -50, 200, 100);


            DrawPlat(250, 250, graphics);
            int graph = PicSelect.SelectedIndex;
            ScanGraph = GenerateGraph(graph, (float)PicSize.Value);
            if (IsFill.Checked)
            {
                FillPath = GenerateFillPath(graph, (float)PicSize.Value, (float)ScanSpace.Value);
            }
            else
            {
                FillPath = null;
            }
            PaintGraph(graphics);


        }

        private void PaintGraph(Graphics g)
        {
            foreach (var countors in ScanGraph)
            {
                g.DrawLines(new Pen(Color.Black,0.01F), countors);
            }
            if (FillPath != null)
            {
                foreach (var countors in FillPath)
                {
                    g.DrawLines(new Pen(Color.Pink, 0.01F), countors);
                }
            }
            
        }
        private void DrawPlat(int x, int y, Graphics g)
        {
            float a = 20;
            Pen pen = new Pen(Color.Black);//画笔颜色      
            g.DrawLine(pen, -(x - a), - y , x - a , - y);
            g.DrawLine(pen, x, -(y-a), x , y-a);
            g.DrawLine(pen, x - a, y, -(x - a), y);
            g.DrawLine(pen, -x, y - a, -x, -y + a);
            g.DrawArc(pen, -x, - y, 2*a , 2*a , 180, 90);
            g.DrawArc(pen, (x - 2 * a), - y , 2*a , 2*a, 270, 90);
            g.DrawArc(pen, -x, (y - 2 * a), 2*a, 2*a , 90, 90);
            g.DrawArc(pen, (x - 2 * a),(y - 2 * a),2* a ,2* a, 0, 90);
            g.DrawEllipse(pen, -(x - a) , (y - 2 * a), a , a );
            g.DrawEllipse(pen, (x - 2 * a)+ moveX, (y - 2 * a)  , a , a );
            g.DrawEllipse(pen, (x - 2 * a), - (y - a) , a , a );
            g.DrawEllipse(pen, -(x - a), - (y - a), a , a);
        }

        private void Strech_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;
            zoom += delta / 1200.0f; // 缩放因子
            if (zoom < 0.1)
            {
                zoom = 0.1F;
            }
            this.Strech.Refresh();
        }

        private void PicSize_ValueChanged(object sender, EventArgs e)
        {
            Strech.Refresh();
        }

        private void ScanSpace_ValueChanged(object sender, EventArgs e)
        {
            Strech.Refresh();
        }

        private void PicSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Strech.Refresh();
        }

        private void IsFill_CheckedChanged(object sender, EventArgs e)
        {
            Strech.Refresh();
        }

        private List<PointF[]> GenerateGraph(int type, float size)
        {
            List<PointF[]> pointFs = new List<PointF[]>();
            switch (type)
            {
                case 0:
                    {
                        PointF[] points =new PointF[361];
                        float PI = 3.1415926F;
                        for (int i = 0; i < 361; i++)
                        {
                            float x = (float)(size * Math.Cos((i * PI) / 180.0));
                            float y = (float)(size * Math.Sin((i * PI) / 180.0)) ;
                            points[i] = new PointF(x,y);                         
                        }
                        pointFs.Add(points);
                        break;
                    }
                case 1:
                    {
                        float l = size;
                        PointF[] rect = new PointF[5];
                        rect[0] = new PointF(-l, -l);
                        rect[1] = new PointF(-l, l);
                        rect[2] = new PointF(l, l);
                        rect[3] = new PointF(l, -l);
                        rect[4] = new PointF(-l, -l);
                        pointFs.Add(rect);
                        break;
                    }
                case 2:
                    {
                        float l = size;
                        for (int i = 0; i < 2 * l / 20 + 1; i++)
                        {
                            for (int j = 0; j < 2 * l / 20 + 1; j++)
                            {
                                PointF[] line = new PointF[2];
                                var x1 = -l + i * 20 - 5;
                                var y1 = -l + 5 + j * 20 - 5;
                                line[0] = new PointF(x1, y1);
                                var x2 = -l + 10 + i * 20 - 5;
                                var y2 = -l + 5 + j * 20 - 5;
                                line[1] = new PointF(x2, y2);
                                pointFs.Add(line);

                                line = new PointF[2];
                                x1 = -l + 5 + i * 20 - 5;
                                y1 = -l + j * 20 - 5;
                                line[0] = new PointF(x1, y1);
                                x2 = -l + 5 + i * 20 - 5;
                                y2 = -l + 10 + j * 20 - 5;
                                line[1] = new PointF(x2, y2);
                                pointFs.Add(line);                                
                            }
                        }
                        break;
                    }
                default:
                    break;
            }
            return pointFs;
        }
        private List<PointF[]> GenerateFillPath(int type, float size ,float gap)
        {
            List<PointF[]> pointFs = new List<PointF[]>();
            var laynum =(int) (2 * size / gap);
            switch (type)
            {
                case 0:
                    {                       
                        for (int i = 1; i < laynum+1; i++)
                        {
                            PointF[] points = new PointF[2];
                            float y = (float)( - size + i * gap);
                            float x1 = (float)(Math.Pow(-1, i)*Math.Sqrt(Math.Pow(size, 2) - Math.Pow(y, 2)));
                            float x2 = (float)(Math.Pow(-1, i-1) * Math.Sqrt(Math.Pow(size, 2) - Math.Pow(y, 2)));
                            points[0] = new PointF(x1, y);
                            points[1] = new PointF(x2, y);
                            pointFs.Add(points);
                        }                       
                        break;
                    }
                case 1:
                    {
                        float l = size;
                        for (int i = 1; i < laynum + 1; i++)
                        {
                            PointF[] points = new PointF[2];
                            float y = (float)(-size + i * gap);
                            float x1 = (float)Math.Pow(-1, i) *l;
                            float x2 = (float)Math.Pow(-1, i - 1) * l;
                            points[0] = new PointF(x1, y);
                            points[1] = new PointF(x2, y);
                            pointFs.Add(points);
                        }
                        break;
                    }
                case 2:
                    {
                        return null;
                    }
                default:
                    break;
            }
            return pointFs;
        }
    }
}
