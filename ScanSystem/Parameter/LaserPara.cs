using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanSystem
{
    [Serializable]
    public class LaserPara
    {
        [Category("参数"), DisplayName("名称")]
        [Description("参数名称")]
        public string Name { get; set; }

        [Category("激光参数"), DisplayName("拐点抑制时间")]
        [Description("拐点抑制时间： 单位ms")]
        public int polygonKillerTime { set; get; }

        [Category("激光参数"), DisplayName("激光频率")]
        [Description("激光频率： 单位Hz")]
        public int LaserFrequency { set; get; }

        [Category("激光参数"), DisplayName("激光脉冲宽")]
        [Description("激光脉冲宽： 单位无")]
        public int LaserPulseWidth { set; get; }

        [Category("修正参数"), DisplayName("x修正系数")]
        [Description("x修正系数： 单位无")]
        public int xCorrection { set; get; }

        [Category("激光参数"), DisplayName("y修正系数")]
        [Description("y修正系数： 单位无")]
        public double yCorrection { set; get; }

        [Category("激光参数"), DisplayName("x剪切系数")]
        [Description("x剪切系数： 单位无")]
        public double xShear { set; get; }

        [Category("激光参数"), DisplayName("y梯度系数")]
        [Description("y梯度系数： 单位无")]
        public double yShear { set; get; }

        [Category("激光参数"), DisplayName("x梯度系数")]
        [Description("x梯度系数： 单位无")]
        public double xLadder { set; get; }

        [Category("激光参数"), DisplayName("y梯度系数")]
        [Description("y梯度系数： 单位无")]
        public double yLadder { set; get; }

        [Category("尺寸比率参数"), DisplayName("x比率")]
        [Description("x比率： 单位无")]
        public double ratioX { set; get; }

        [Category("尺寸比率参数"), DisplayName("y比率")]
        [Description("y比率： 单位无")]
        public double ratioY { set; get; }

        [Category("尺寸比率参数"), DisplayName("z比率")]
        [Description("z比率： 单位无")]
        public double ratioZ { set; get; }

        public LaserPara()
        {
            Name = "激光参数";
            polygonKillerTime = 20;  //拐点抑制时间(us)

            LaserFrequency = 100; //激光频率(kHZ)（50-20000HZ）
            LaserPulseWidth = 1000;//激光脉冲宽度

            xCorrection = 0;
            yCorrection = 0;
            xShear = 0;
            yShear = 0;
            xLadder = 0;
            yLadder = 0;
            ratioX = 1;
            ratioY = 1;
            ratioZ = 1;
        }
    }
}
