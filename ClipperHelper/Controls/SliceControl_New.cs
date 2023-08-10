using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipperHelper
{
    public partial class SliceControl_New : UserControl
    {
        public SlcModel sm = null;
        public SlicePara para = null;
        public List<SlicePlane> sps = null;
        public int laserNum = 1;
        public int xspace, yspace;
        private SliceView sliceView = null;

        public SliceControl_New(SlcModel slcModel, SlicePara _para, int LaserNum, int xSpace, int ySpace)
        {
            sm = slcModel;
            para = _para;
            laserNum = LaserNum;
            xspace = xSpace;
            yspace = ySpace;
            InitializeComponent();
            sliceView = new SliceView(sps, LaserNum,xspace, yspace);
            LayerSelect.Maximum = sm.LayNum;
            AllLayerNum.Text = "共" + sm.LayNum.ToString() + "层";
            UpdateSlicePlane();

            sliceView.Dock = DockStyle.Fill;
            ViewPanel.Controls.Add(sliceView);
        }

        private void PreButton_Click(object sender, EventArgs e)
        {
            if (LayerSelect.Value > 0)
                LayerSelect.Value -= 1;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (LayerSelect.Value < LayerSelect.Maximum)
                LayerSelect.Value += 1;
        }

        private void PreViewButton_Click(object sender, EventArgs e)
        {

        }

        private void StopView_Click(object sender, EventArgs e)
        {

        }

        private void SetPara_Click(object sender, EventArgs e)
        {

        }

        private void LayerSelect_ValueChanged(object sender, EventArgs e)
        {
            UpdateSlicePlane();
        }

        public void UpdateSlicePlane()
        {
            int i = LayerSelect.Value;
            CurrentLayerNum.Text = "第" + i.ToString() + "层";
            CurrentHeight.Text = "层高：" + i * sm.LayerHeight + " mm";

            CurrentSlicePlane csp = null;
            if (sm.SupportCountors == null)
            {
                csp = new CurrentSlicePlane(sm.ModelCountors.allCountors[i], sm.ModelCountors.allCountors[i + 1], sm.ModelCountors.allCountors[i + 2]);
            }
            else
            {
                csp = new CurrentSlicePlane(sm.ModelCountors.allCountors[i], sm.ModelCountors.allCountors[i + 1], sm.ModelCountors.allCountors[i + 2], sm.SupportCountors.allCountors[i]);
            }
            SlicePlane sp = new SlicePlane(csp, para, i);
            sps = SlicePlane.DivideByLaserRegion(sp, para.BaseSlicePara, laserNum, xspace, yspace);
            sliceView.UpdareSlicePlane(sps);
        }
    }
}
