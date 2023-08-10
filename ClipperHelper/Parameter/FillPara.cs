using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipperHelper
{
    [Serializable]
    public enum RegionInterStratege
    {
        NONE = 0,
        LineInter = 1,
        PolyInter = 2,
        TriFucInter = 3,
        RecToothInter = 4,
        RandomInter = 5
    }
    [Serializable]
    public class FillPara
    {
        [Category("参数"), DisplayName("名称")]
        [Description("参数名称")]
        public string Name { get; set; }

        [Category("填充参数"), DisplayName("填充间距")]
        [Description("填充间距：单位：mm")]
        public double ScanSpace { get; set; }

        [Category("填充参数"), DisplayName("填充线阈值")]
        [Description("填充线阈值：填充线长度低于该值被删除 单位：mm")]
        public double LineLengthLimited { get; set; }

        [Category("填充参数"), DisplayName("层间填充角度")]
        [Description("层间填充角度：z方向层间扫描线旋转角度 单位： 角度°")]
        public double PathAngleBetweenLayer { get; set; }

        [Category("分区参数"), DisplayName("区间填充角度")]
        [Description("区间填充角度：平面分区间扫描线旋转角度 单位： 角度°")]
        public double PathAngleBetweenRegion { get; set; }

        [Category("分区参数"), DisplayName("区间角度")]
        [Description("区间角度：平面分区旋转角度 单位： 角度°")]
        public double RegionAngle { get; set; }

        [Category("分区参数"), DisplayName("分区长度")]
        [Description("分区长度：平面分区区间长度 单位： mm")]
        public double RegionLength { get; set; }

        [Category("分区参数"), DisplayName("分区高度")]
        [Description("分区高度：平面分区区间高度 单位： mm")]
        public double RegionHeight { get; set; }

        [Category("分区参数"), DisplayName("区间搭接间隔")]
        [Description("区间搭接间隔：平面分区区间搭接间隔 单位： mm")]
        public double RegionInterGap { get; set; }

        [Category("分区参数"), DisplayName("区间搭接策略")]
        [Description("区间搭接间隔：平面分区区间搭接策略")]
        public RegionInterStratege InterStratege { get; set; }

        [Category("分区参数"), DisplayName("区间搭接周期")]
        [Description("区间搭接周期：平面分区区间搭接周期 单位：mm")]
        public double RegionLapGap { get; set; }

        [Category("分区参数"), DisplayName("区间搭接振幅")]
        [Description("区间搭接振幅：平面分区区间搭接振幅 单位：mm")]
        public double RegionViber { get; set; }

        [Category("填充参数"), DisplayName("是否填充")]
        [Description("是否填充扫描")]
        public bool isFill { get; set; }
        public FillPara(int i)
        {
            switch (i)
            {
                case 0:
                    Name = "主体参数";
                    break;
                case 1:
                    Name = "上表面参数";
                    break;
                case 2:
                    Name = "下表面参数";
                    break;
                case 3:
                    Name = "支撑参数";
                    break;

            }
            ScanSpace = 0.3;
            LineLengthLimited = 0.1;
            PathAngleBetweenLayer = 0;
            PathAngleBetweenRegion = 60;
            RegionAngle = 60;
            RegionLength = 100;
            RegionHeight = 20;
            RegionInterGap = 1;
            RegionLapGap = 1;
            RegionViber = 1;
            InterStratege = RegionInterStratege.LineInter;
            isFill = true;
        }
        public void WriteBinary(BinaryWriter bw)
        {
            bw.Write(Name);
            bw.Write(ScanSpace);
            bw.Write(LineLengthLimited);
            bw.Write(PathAngleBetweenLayer);
            bw.Write(PathAngleBetweenRegion);
            bw.Write(RegionAngle);
            bw.Write(RegionLength);
            bw.Write(RegionHeight);
            bw.Write(RegionInterGap);
            bw.Write(RegionLapGap);
            bw.Write(RegionViber);
            bw.Write((int)InterStratege);
            bw.Write(isFill);
        }
    }

    public class IntSlicePara
    {

        [Category("填充参数"), DisplayName("填充间距")]
        public int ScanSpace { get; set; }

        [Category("填充参数"), DisplayName("填充线阈值")]
        public int LineLengthLimited { get; set; }

        [Category("填充参数"), DisplayName("层间填充角度")]
        public double PathAngleBetweenLayer { get; set; }

        [Category("分区参数"), DisplayName("区间填充角度")]
        public double PathAngleBetweenRegion { get; set; }

        [Category("分区参数"), DisplayName("区间角度")]
        public double RegionAngle { get; set; }

        [Category("分区参数"), DisplayName("分区长度")]
        public int RegionLength { get; set; }

        [Category("分区参数"), DisplayName("分区高度")]
        public int RegionHeight { get; set; }

        [Category("分区参数"), DisplayName("区间搭接间隔")]
        public int RegionInterGap { get; set; }

        [Category("分区参数"), DisplayName("区间搭接策略")]
        public RegionInterStratege InterStratege { get; set; }

        [Category("分区参数"), DisplayName("区间搭接周期")]
        public int RegionLapGap { get; set; }

        [Category("分区参数"), DisplayName("区间搭接振幅")]
        public int RegionViber { get; set; }

        [Category("填充参数"), DisplayName("是否填充")]
        public bool isFill { get; set; }
        public IntSlicePara(FillPara slicePara, int scale)
        {
            ScanSpace = (int)(slicePara.ScanSpace * scale);
            LineLengthLimited = (int)(slicePara.LineLengthLimited * scale);
            PathAngleBetweenLayer = slicePara.PathAngleBetweenLayer ;
            PathAngleBetweenRegion = slicePara.PathAngleBetweenRegion ;
            RegionAngle = slicePara.RegionAngle;
            RegionLength = (int)(slicePara.RegionLength * scale);
            RegionHeight = (int)(slicePara.RegionHeight * scale);
            RegionInterGap = (int)(slicePara.RegionInterGap * scale);
            InterStratege = slicePara.InterStratege;
            isFill = slicePara.isFill;
            RegionLapGap = (int)(slicePara.RegionLapGap * scale);
            RegionViber = (int)(slicePara.RegionViber * scale);
        }

    }
}
