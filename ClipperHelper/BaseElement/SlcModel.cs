using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipperHelper
{
    public class SlcModel
    {
        public AllCountors ModelCountors = null;
        public AllCountors SupportCountors = null;
        public int LayNum;
        public float LayerHeight;
        public bool isSupportEntity;
        public bool right =true;
        public SlcModel(string modelfile, string supportfile,bool isentity)
        {
            AllCountors mC;
            AllCountors sC;
            if (!SliceReader.LoadSLCFile(modelfile, out mC))
            {

                return;
            }
            if (!SliceReader.LoadSLCFile(supportfile, out sC))
            {

                return;
            }
            isSupportEntity = isentity;
            if (mC.LayerHeight != sC.LayerHeight)
            {
                right = false;
                return;
            }
            LayerHeight = mC.LayerHeight;
            
            int i = (int)(mC.zmin / LayerHeight);
            int j = (int)(sC.zmin / LayerHeight);
            //模型比支撑多两层，用于判断上下表面
            ModelCountors = new AllCountors(mC, i+1,1);
            SupportCountors = new AllCountors(sC, j,mC.LayNum+i - sC.LayNum-j +1);
            LayNum = SupportCountors.LayNum;

        }
        public SlcModel(string modelfile)
        {
            AllCountors mC;
            if (!SliceReader.LoadSLCFile(modelfile, out mC))
            {

                return;
            } 
            LayerHeight = mC.LayerHeight;
            int i = (int)(mC.zmin / LayerHeight);
            //模型比支撑多两层，用于判断上下表面
            ModelCountors = new AllCountors(mC, i + 1, 1);
            LayNum = ModelCountors.LayNum-2;

        }
    }
}
