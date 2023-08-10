using ClipperLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks; 

namespace ClipperHelper
{
    [Serializable]
    public class SlicePlane
    {        
        public static int scale = 10000;
        public int ZValue { get; set; }

        public CurrentSlicePlane csp;
        public List<List<List<IntPoint>>> LowerSurfacesCountors { get; set; }
        public List<List<List<IntPoint>>> UpperSurfacesCountors { get; set; }
        public List<List<List<IntPoint>>> UpperSurfacesScanPath { get; set; }
        public List<List<List<IntPoint>>> LowerSurfacesScanPath { get; set; }
        public List<List<List<IntPoint>>> BaseRegionsCountors { get; set; }
        public List<List<List<IntPoint>>> BaseRegionsScanPath { get; set; }
        public List<List<IntPoint>> SupportCountors { get; set; }
        public List<List<List<IntPoint>>> SupportScanPath { get; set; }
        public SlicePlane(int Z)
        {
            ZValue = Z;
            csp = new CurrentSlicePlane();
            LowerSurfacesCountors = new List<List<List<IntPoint>>>();
            UpperSurfacesCountors = new List<List<List<IntPoint>>>();
            UpperSurfacesScanPath = new List<List<List<IntPoint>>>();
            LowerSurfacesScanPath = new List<List<List<IntPoint>>>();
            BaseRegionsCountors = new List<List<List<IntPoint>>>();
            BaseRegionsScanPath = new List<List<List<IntPoint>>>();
            SupportCountors = new List<List<IntPoint>>();
            SupportScanPath = new List<List<List<IntPoint>>>();
        }
        //将sp分为小的sp，其中start为避风分区的起始y，end为结束y，dividenum为避风分区数量，divideRegion为划分的区域；
        public SlicePlane(SlicePlane sp, int start ,int end,int dividenum ,List<IntPoint> divideRegion):this(sp.ZValue)
        {            
            LowerSurfacesCountors = Helper.ClipLines(sp.LowerSurfacesCountors, divideRegion,ClipType.ctIntersection);
            UpperSurfacesCountors = Helper.ClipLines(sp.UpperSurfacesCountors, divideRegion, ClipType.ctIntersection);
            BaseRegionsCountors = Helper.ClipLines(sp.BaseRegionsCountors, divideRegion, ClipType.ctIntersection);
            SupportCountors = Helper.ClipLines(sp.SupportCountors, divideRegion, ClipType.ctIntersection);

            List<List<List<IntPoint>>> US = Helper.ClipLines(sp.UpperSurfacesScanPath, divideRegion, ClipType.ctIntersection);
            List<List<List<IntPoint>>> LS = Helper.ClipLines(sp.LowerSurfacesScanPath, divideRegion, ClipType.ctIntersection);
            List<List<List<IntPoint>>> BS = Helper.ClipLines(sp.BaseRegionsScanPath, divideRegion, ClipType.ctIntersection);
            List<List<List<IntPoint>>> SS = Helper.ClipLines(sp.SupportScanPath, divideRegion, ClipType.ctIntersection);

            int gap = (end - start) / dividenum;
            for(int  i = 0;i < dividenum; i++)
            {
                List<IntPoint> voidregion = Helper.CreateRectRegion(-3000000, 3000000, start + gap * (i + 1), start+gap * i, 1000, 1000, RegionInterStratege.LineInter);
                if (US.Count > 0)
                    UpperSurfacesScanPath.Add(Helper.ClipLines(US[0], voidregion, ClipType.ctIntersection));
                if (LS.Count > 0)
                    LowerSurfacesScanPath.Add(Helper.ClipLines(LS[0], voidregion, ClipType.ctIntersection));
                if (BS.Count > 0)
                    BaseRegionsScanPath.Add(Helper.ClipLines(BS[0], voidregion, ClipType.ctIntersection));
                if (SS.Count > 0)
                    SupportScanPath.Add(Helper.ClipLines(SS[0], voidregion, ClipType.ctIntersection));
            }
        }
        public SlicePlane(CurrentSlicePlane _csp,SlicePara para,int Z) : this(Z)
        {
            int upperThreshold = (int)((double)para.BaseSlicePara.UpperThreshold * scale);
            int lowerThreshold = (int)((double)para.BaseSlicePara.LowerThreshold * scale);
            int Offset = (int)(para.BaseSlicePara.CountorOffset * scale);
            for(int i  =0; i < para.BaseSlicePara.CountorCount;i++)
            { 
                CurrentSlicePlane CSP_offset = new CurrentSlicePlane(_csp, Offset*(i+1));
                BaseRegionsCountors.Add(CSP_offset.GetBaseCountors(upperThreshold, lowerThreshold));
                LowerSurfacesCountors.Add(CSP_offset.GetLowerCountors(lowerThreshold));
                UpperSurfacesCountors.Add(CSP_offset.GetUpperCountors(upperThreshold));
                csp = CSP_offset;
            }
            SupportCountors = _csp.SupportCountors;
            CurrentSlicePlane CSP = new CurrentSlicePlane(_csp, Offset);

            if (para.BaseRegionSlicePare.isFill)
            {
                BaseRegionsScanPath.Add(Helper.GetScanPath(CSP.GetBaseRegion(upperThreshold, lowerThreshold), new IntSlicePara(para.BaseRegionSlicePare, scale), Z * para.BaseRegionSlicePare.PathAngleBetweenLayer));
            }


            if (para.UpperSurfaceSlicePara.isFill)
            {
                UpperSurfacesScanPath.Add(Helper.GetScanPath(FillRegion.GetAllRings(CSP.GetUpperSurface(upperThreshold)), new IntSlicePara(para.UpperSurfaceSlicePara, scale), Z * para.UpperSurfaceSlicePara.PathAngleBetweenLayer));
            }


            if (para.LowerSurfaceSlicePara.isFill)
            {
                LowerSurfacesScanPath.Add(Helper.GetScanPath(FillRegion.GetAllRings(CSP.GetLowerSurface(upperThreshold)), new IntSlicePara(para.LowerSurfaceSlicePara, scale), Z * para.LowerSurfaceSlicePara.PathAngleBetweenLayer));
            }


            if (para.SupportSlicePare.isFill)
                SupportScanPath.Add(Helper.GetScanPath(csp.SupportCountors, new IntSlicePara(para.SupportSlicePare, scale), Z * para.SupportSlicePare.PathAngleBetweenLayer));

        }
        //将sp分为按照多激光分为多个小的sp，laserNum为激光数量，printL，printH为打印区域；
        public static List<SlicePlane> DivideByLaserRegion(SlicePlane sp, BasePara para , int laserNum , int printL ,int printH)
        {
            int left = -printL*scale / 2;
            int right = printL * scale / 2;
            int top = printH * scale / 2;
            int bottom = -printL * scale / 2;
            int divinum = para.VoidWindRegionNum;
            List<SlicePlane> slicePlanes = new List<SlicePlane>();
            int laynum = (int)(sp.ZValue / para.LayerHeight);
            Random rd = new Random();
            int position = (int)(para.LaserLapLength * scale);
            int offset = 0;
            switch (para.LaserLapStra_z)
            {
                case RegionInterStratege.LineInter:
                    break;
                case RegionInterStratege.PolyInter:
                    offset = (int)(Math.Pow(-1, laynum / para.LaserLapGapLayer) * (laynum % para.LaserLapGapLayer) * para.LaserLapViber_z * scale / para.LaserLapGapLayer);
                    break;
                case RegionInterStratege.RecToothInter:
                    offset = (int)(Math.Pow(-1, laynum / para.LaserLapGapLayer) * para.LaserLapViber_z * scale);
                    break;
                case RegionInterStratege.TriFucInter:
                    offset = (int)(Math.Pow(-1, laynum / para.LaserLapGapLayer) * Math.Sin((laynum % para.LaserLapGapLayer) * 3.14159 / para.LaserLapGapLayer) * para.LaserLapViber_z * scale);
                    break;
                case RegionInterStratege.RandomInter:
                    offset = (int)(2 * (rd.NextDouble() - 0.5) * para.LaserLapViber_z * scale);
                    break;
                default:
                    break;
            }
            int gap = (int)(para.LaserLapGap * scale);
            int viber = (int)(para.LaserLapViber * scale);
            switch (laserNum)
            {
                case 1:
                    slicePlanes.Add(sp);
                    break;
                case 2:                   
                    
                    List<IntPoint> rect = Helper.CreateRectRegion(left, right, top, bottom, gap, viber, para.LaserLapStra);
                    IntRect bound = ClipperBase.GetBounds(Helper.ClipLines(sp.csp.CurrentCountors, rect, ClipType.ctIntersection));
                    SlicePlane sp0 = new SlicePlane(sp, (int)bound.top, (int)bound.bottom, divinum, Helper.CreateRectRegion(left, offset + position, top, bottom, gap, viber, para.LaserLapStra));
                    SlicePlane sp01 = new SlicePlane(sp, (int)bound.top, (int)bound.bottom, divinum, Helper.CreateRectRegion(offset - position, right, top, bottom, gap, viber, para.LaserLapStra));
                    slicePlanes.Add(sp0);
                    slicePlanes.Add(sp01);
                    break;                   
                case 4:
                    List<IntPoint> rect1 = Helper.CreateRectRegion(left, right, top, offset - position, gap, viber, para.LaserLapStra);
                    List<IntPoint> rect2 = Helper.CreateRectRegion(left, right, offset + position, bottom, gap, viber, para.LaserLapStra);
                    IntRect bound1 = ClipperBase.GetBounds(Helper.ClipLines(sp.csp.CurrentCountors, rect1, ClipType.ctIntersection));
                    IntRect bound2 = ClipperBase.GetBounds(Helper.ClipLines(sp.csp.CurrentCountors, rect2, ClipType.ctIntersection));
                    SlicePlane sp1 = new SlicePlane(sp,(int) bound1.top, (int)bound1.bottom, divinum, Helper.CreateRectRegion(left, offset+ position, top , offset - position, gap, viber,para.LaserLapStra));
                    SlicePlane sp2 = new SlicePlane(sp, (int)bound1.top, (int)bound1.bottom, divinum, Helper.CreateRectRegion(offset - position, right, top, offset - position, gap, viber, para.LaserLapStra));
                    SlicePlane sp3 = new SlicePlane(sp, (int)bound2.top, (int)bound2.bottom, divinum, Helper.CreateRectRegion(left, offset+position, offset+position, bottom, gap, viber, para.LaserLapStra));
                    SlicePlane sp4 = new SlicePlane(sp, (int)bound2.top, (int)bound2.bottom, divinum, Helper.CreateRectRegion(offset - position, right, offset+position, bottom, gap, viber, para.LaserLapStra));
                    slicePlanes.Add(sp1);
                    slicePlanes.Add(sp2);
                    slicePlanes.Add(sp3);
                    slicePlanes.Add(sp4);
                    break;
                default: 
                    break;


            }
            return slicePlanes;
        }
       
    }

    [Serializable]
    public class SlicePlaneF
    {
        public int ZValue { get; set; }
        public List<List<PointF[]>> LowerSurfacesCountors { get; set; }
        public List<List<PointF[]>> UpperSurfacesCountors { get; set; }
        public List<List<PointF[]>> UpperSurfacesScanPath { get; set; }
        public List<List<PointF[]>> LowerSurfacesScanPath { get; set; }
        public List<List<PointF[]>> BaseRegionsCountors { get; set; }
        public List<List<PointF[]>> BaseRegionsScanPath { get; set; }
        public List<PointF[]> SupportCountors { get; set; }
        public List<List<PointF[]>> SupportScanPath { get; set; }

        public SlicePlaneF(SlicePlane sp)
        {
            ZValue = sp.ZValue;
            LowerSurfacesCountors = Helper.IntToPointFs(sp.LowerSurfacesCountors, SlicePlane.scale);
            UpperSurfacesCountors = Helper.IntToPointFs(sp.UpperSurfacesCountors, SlicePlane.scale);
            LowerSurfacesScanPath = Helper.IntToPointFs(sp.LowerSurfacesScanPath, SlicePlane.scale);
            UpperSurfacesScanPath = Helper.IntToPointFs(sp.UpperSurfacesScanPath, SlicePlane.scale);
            BaseRegionsCountors = Helper.IntToPointFs(sp.BaseRegionsCountors, SlicePlane.scale);
            BaseRegionsScanPath = Helper.IntToPointFs(sp.BaseRegionsScanPath, SlicePlane.scale);
            SupportCountors = Helper.IntToPointFs(sp.SupportCountors, SlicePlane.scale);
            SupportScanPath = Helper.IntToPointFs(sp.SupportScanPath, SlicePlane.scale);
        }
        public static List<SlicePlaneF> TranToFloats(List<SlicePlane> sps)
        {
            SlicePlaneF[] spfs = sps.Select(i=>new SlicePlaneF(i)).ToArray();
            return new List<SlicePlaneF>(spfs);
        }
        public void WriteBinary(BinaryWriter sw, List<List<PointF[]>> pointFs)
        {
            sw.Write(pointFs.Count);
            foreach (var p in pointFs)
            {
                WriteBinary(sw, p);
            }
        }
        public void WriteBinary(BinaryWriter sw, List<PointF[]> pointFs)
        {
            sw.Write(pointFs.Count);
            foreach (var p in pointFs)
            {
                WriteBinary(sw, p);
            }
        }
        public void WriteBinary(BinaryWriter sw, PointF[] pointFs)
        {
            sw.Write(pointFs.Length);
            foreach (var p in pointFs)
            {
                sw.Write(p.X);
                sw.Write(p.Y);
            }
        }
        public void WriteLinesBinary(BinaryWriter sw, List<List<PointF[]>> pointFs)
        {
            sw.Write(pointFs.Count);
            foreach (var p in pointFs)
            {
                WriteLinesBinary(sw, p);
            }
        }
        public void WriteLinesBinary(BinaryWriter sw, List<PointF[]> pointFs)
        {
            sw.Write(pointFs.Count);
            foreach (var p in pointFs)
            {
                WriteLinesBinary(sw, p);
            }
        }
        public void WriteLinesBinary(BinaryWriter sw, PointF[] p)
        {
            sw.Write(p[0].X);
            sw.Write(p[0].Y);
            sw.Write(p[1].X);
            sw.Write(p[1].Y);
        }
        public void BinaryFileSav(BinaryWriter sw)
        {
            //-----二进制文件写入并存储  
             
            sw.Write(ZValue);
            WriteBinary(sw, LowerSurfacesCountors);
            WriteBinary(sw, UpperSurfacesCountors);
            WriteLinesBinary(sw, LowerSurfacesScanPath);
            WriteLinesBinary(sw, UpperSurfacesScanPath);
            WriteBinary(sw, BaseRegionsCountors);
            WriteLinesBinary(sw, BaseRegionsScanPath);
            WriteBinary(sw, SupportCountors);
            WriteLinesBinary(sw, SupportScanPath);
        
        }

       
    }
}
