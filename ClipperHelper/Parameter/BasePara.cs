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
    public class BasePara
    {
        [Category(""), DisplayName("名称")]
        [Description("参数名称")]
        public string Name { get; set; }

        [Browsable(false),Category("切片参数"), DisplayName("层间高度")]
        [Description("层间高度  单位： mm")]
        public double LayerHeight { get; set; }

        [Category("轮廓参数"), DisplayName("轮廓偏移")]
        [Description("轮廓偏移量  单位： mm")]
        public double CountorOffset { get; set; }

        [Category("轮廓参数"), DisplayName("轮廓偏移数量")]
        [Description("轮廓偏移数量  单位： 个")]
        public int CountorCount { get; set; }

        [Category("上下表面参数"), DisplayName("上表面阈值")]
        [Description("上表面识别阈值  单位： mm")]
        public double UpperThreshold { get; set; }

        [Category("上下表面参数"), DisplayName("下表面阈值")]
        [Description("下表面识别阈值  单位： mm")]
        public double LowerThreshold { get; set; }

        [Category("激光搭接参数"), DisplayName("搭接区域宽度")]
        [Description("激光搭接区域宽度  单位： mm")]
        public double LaserLapLength{ get; set; }

        [Category("激光平面搭接参数"), DisplayName("平面搭接策略")]
        [Description("平面内激光搭接策略")]
        public RegionInterStratege LaserLapStra { get; set; }

        [Category("激光纵向搭接参数"), DisplayName("搭接策略")]
        [Description("Z方向激光搭接策略")]
        public RegionInterStratege LaserLapStra_z { get; set; }


        [Category("激光纵向搭接参数"), DisplayName("搭接振幅")]
        [Description("Z方向激光搭接周期振幅 单位： mm")]
        public double LaserLapViber_z { get; set; }

        [Category("激光纵向搭接参数"), DisplayName("搭接循环半周期层数")]
        [Description("Z方向激光搭接半周期层数 单位： 层")]
        public int LaserLapGapLayer { get; set; }

        [Category("激光平面搭接参数"), DisplayName("搭接循环半周期")]
        [Description("平面激光搭接半周期长度 单位： mm")]
        public double LaserLapGap { get; set; }

        [Category("激光平面搭接参数"), DisplayName("搭接振幅")]
        [Description("平面激光搭接周期振幅 单位： mm")]
        public double LaserLapViber { get; set; }

        [Category("避风分区"), DisplayName("分区数量")]
        [Description("避风分区数量 单位： 个")]
        public int VoidWindRegionNum { get; set; }

        public BasePara()
        {
            Name = "基本切片参数";
            LayerHeight = 0.03;
            CountorOffset = 0.1;
            CountorCount = 1;
            UpperThreshold = 0.01;
            LowerThreshold = 0.01;
            LaserLapLength = 0.05;
            VoidWindRegionNum = 1;
            LaserLapGap = 1;
            LaserLapViber = 1;
            LaserLapGapLayer = 5;
            LaserLapViber_z = 1;
            LaserLapStra = RegionInterStratege.LineInter;
            LaserLapStra_z = RegionInterStratege.LineInter;

        }
    }
}
