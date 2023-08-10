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
    public class ScanPara
    {
        [Category("参数"), DisplayName("名称")]
        [Description("参数名称")]
        public string Name { get; set; }

        [Category("填充参数"), DisplayName("填充功率")]
        [Description("填充功率百分比： 单位 %")]
        public int ScanPower { set; get; }

        [Category("轮廓参数"), DisplayName("轮廓功率")]
        [Description("轮廓功率百分比： 单位 %")]
        public int FramePower { set; get; }

        [Category("填充参数"), DisplayName("填充速度")]
        [Description("填充区域扫描速度： 单位 mm/s")]
        public int ScanSpeed { set; get; }

        [Category("轮廓参数"), DisplayName("轮廓速度")]
        [Description("轮廓扫描速度： 单位 mm/s")]
        public int FrameSpeed { set; get; }

        [Category("填充参数"), DisplayName("填充次数")]
        [Description("填充区域扫描次数： 单位 次")]
        public int ScanTime { set; get; }

        [Category("轮廓参数"), DisplayName("轮廓次数")]
        [Description("轮廓扫描次数： 单位 次")]
        public int FrameTime { set; get; }

        [Category("跳转参数"), DisplayName("跳转速度")]
        [Description("激光跳转速度： 单位 mm/s")]
        public int JumpSpeed { set; get; }

        [Category("延迟参数"), DisplayName("跳转延迟")]
        [Description("激光跳转延时： 单位 ms")]
        public int JumpDelay { set; get; }

        [Category("延迟参数"), DisplayName("扫描延时")]
        [Description("激光扫描延时： 单位 ms")]
        public int MarkDelay { set; get; }

        [Category("延迟参数"), DisplayName("多边形延时")]
        [Description("多边形延时： 单位 ms")]
        public int polygonDelay { set; get; }

        [Category("延迟参数"), DisplayName("激光开延时")]
        [Description("激光开延时： 单位 ms")]
        public int laserOnDelay { set; get; }

        [Category("延迟参数"), DisplayName("激光关延时")]
        [Description("激光关延时： 单位 ms")]
        public int laserOffDelay { set; get; }

        

        public ScanPara(int i)
        {
            switch (i)
            {
                case 0:
                    Name = "主体制造参数";
                    break;
                case 1:
                    Name = "上表面制造参数";
                    break;
                case 2:
                    Name = "下表面制造参数";
                    break;
                case 3:
                    Name = "支撑制造参数";
                    break;

            }
            ScanPower = 12;
            FramePower = 12;

            ScanSpeed = 400;
            FrameSpeed = 400;

            ScanTime = 1;
            FrameTime = 1;

            JumpSpeed = 2000;
            JumpDelay = 400; //跳转延时(us)

            MarkDelay = 400;
            polygonDelay = 50; //拐点延时(us)
            laserOnDelay = 50; //开光延时(us)
            laserOffDelay = 300; //关光延时(us)
            
        }
    }
}
