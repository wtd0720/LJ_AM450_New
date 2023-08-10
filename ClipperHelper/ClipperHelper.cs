using ClipperLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipperHelper
{
    public class Helper
    {
        public static List<List<IntPoint>> DoubleToIntPoints(List<List<double[]>> dPs, int scale)
        {
            List<IntPoint>[] intPoints = dPs.Select(p => DoubleToIntPoints(p, scale)).ToArray();
            return new List<List<IntPoint>>(intPoints);
        }
        public static List<IntPoint> DoubleToIntPoints(List<double[]> dPs, int scale)
        {
            IntPoint[] intPoints = dPs.Select(p => new IntPoint(p[0]*scale, p[1]*scale)).ToArray();
            return new List<IntPoint>(intPoints);
        }
        public static List<PointF[]> DoubleToPointFs(List<List<double[]>> dPs)
        {
            PointF[][] PointFs = dPs.Select(p => DoubleToPointFs(p)).ToArray();
            return new List<PointF[]>(PointFs);
        }
        public static PointF[] DoubleToPointFs(List<double[]> dPs)
        {
            PointF[] PointFs = dPs.Select(p => new PointF((float)p[0], (float)p[1] )).ToArray();
            return PointFs;
        }
        public static List<List<double[]>> IntToDoublePoints(List<List<IntPoint>> dPs, int scale)
        {
            List<double[]>[] intPoints = dPs.Select(p => DoubleToIntPoints(p, scale)).ToArray();
            return new List<List<double[]>>(intPoints);
        }
        public static List<double[]> DoubleToIntPoints(List<IntPoint> dPs, int scale)
        {
            double[][] intPoints = dPs.Select(p => new double[2] { (double)p.X/(double)scale , p.Y /scale}).ToArray();
            return new List<double[]>(intPoints);
        }
        public static List<List<PointF[]>> IntToPointFs(List<List<List<IntPoint>>> dPs, int scale)
        {
            List<PointF[]>[] pointFs = dPs.Select(p => IntToPointFs(p, scale)).ToArray();
            return new List<List<PointF[]>>(pointFs);
        }
        public static List<PointF[]> IntToPointFs(List<List<IntPoint>> dPs, int scale)
        {
            PointF[][] pointFs = dPs.Select(p => IntToPointFs(p, scale)).ToArray();
            return new List<PointF[]>(pointFs);
        }
        public static PointF[] IntToPointFs(List<IntPoint> dPs, int scale)
        {
            PointF[] pointFs = dPs.Select(p => new PointF(((float)p.X / scale ), ((float)p.Y / scale) )).ToArray();
            return pointFs;
        }

        public static List<List<IntPoint>> PointFToInts(List<PointF[]> dPs, int scale)
        {
            List<IntPoint>[] intpoints = dPs.Select(p => PointFToInts(p, scale)).ToArray();
            return new List<List<IntPoint>>(intpoints);
        }
        public static List<IntPoint> PointFToInts(PointF[] dPs, int scale)
        {
            IntPoint[] intpoints = dPs.Select(p => new IntPoint((int)(p.X * scale),(int)(p.Y * scale ))).ToArray();
            return new List<IntPoint>(intpoints);
        }
        public static List<List<IntPoint>> ClipPolygon(List<IntPoint> subject, List<IntPoint> clip, ClipType clipType)
        {
            // 创建Clipper实例
            Clipper clipper = new Clipper();
            // 将多边形和裁剪窗口添加到Clipper实例中
            clipper.AddPath(subject, PolyType.ptSubject,false);
            clipper.AddPath(clip, PolyType.ptClip,true);
            // 执行裁剪操作
            ClipperLib.PolyTree polyTree = new ClipperLib.PolyTree();
            clipper.Execute(clipType, polyTree);
            return Clipper.PolyTreeToPaths(polyTree);
        }
        public static List<List<IntPoint>> ClipPolygon(List<List<IntPoint>> subject, List<IntPoint> clip, ClipType clipType)
        {
            // 创建Clipper实例
            Clipper clipper = new Clipper();

            // 将多边形和裁剪窗口添加到Clipper实例中
            clipper.AddPaths(subject, PolyType.ptSubject,true);
            clipper.AddPath(clip, PolyType.ptClip,true);

            // 执行裁剪操作
            List<List<IntPoint>> solution = new List<List<IntPoint>>();
            clipper.Execute(clipType, solution);

            // 将结果转换为List<List<IntPoint>>
            //List<List<IntPoint>> result = new List<List<IntPoint>>();
            //foreach (ClipperLib.PolyNode node in polyTree.Childs)
            //{
            //    result.Add(node.Contour);
            //}
            return solution;
        }
        public static PolyTree ClipPolygon(List<List<IntPoint>> subject, List<List<IntPoint>> clip, ClipType clipType,PolyFillType polyFillType = PolyFillType.pftEvenOdd)
        {
            // 创建Clipper实例
            Clipper clipper = new Clipper();

            // 将多边形和裁剪窗口添加到Clipper实例中
            clipper.AddPaths(subject, PolyType.ptSubject,true);
            clipper.AddPaths(clip, PolyType.ptClip,true);

            // 执行裁剪操作
            //List<List<IntPoint>> solution = new List<List<IntPoint>>();
            //clipper.Execute(clipType, solution);
            PolyTree polyTree = new PolyTree();
            clipper.Execute(clipType, polyTree, polyFillType);
            //// 将结果转换为List<List<IntPoint>>
            //List<List<IntPoint>> result = new List<List<IntPoint>>();
            //foreach (ClipperLib.PolyNode node in polyTree.Childs)
            //{
            //    result.Add(node.Contour);
            //}
            return polyTree;
        }
        public static PolyTree ClipLines(List<List<IntPoint>> subject, List<List<IntPoint>> clip, ClipType clipType, PolyFillType polyFillType = PolyFillType.pftEvenOdd)
        {
            // 创建Clipper实例
            Clipper clipper = new Clipper();

            // 将多边形和裁剪窗口添加到Clipper实例中
            clipper.AddPaths(subject, PolyType.ptSubject, false);
            clipper.AddPaths(clip, PolyType.ptClip, true);

            // 执行裁剪操作
            //List<List<IntPoint>> solution = new List<List<IntPoint>>();
            //clipper.Execute(clipType, solution);
            PolyTree polyTree = new PolyTree();
            clipper.Execute(clipType, polyTree, polyFillType);
            //// 将结果转换为List<List<IntPoint>>
            return polyTree;
        }
        public static List<List<IntPoint>> ClipLines(List<List<IntPoint>> subject, List<IntPoint> clip, ClipType clipType, PolyFillType polyFillType = PolyFillType.pftEvenOdd)
        {
            // 创建Clipper实例
            Clipper clipper = new Clipper();

            // 将多边形和裁剪窗口添加到Clipper实例中
            clipper.AddPaths(subject, PolyType.ptSubject, false);
            clipper.AddPath(clip, PolyType.ptClip, true);

            // 执行裁剪操作
            //List<List<IntPoint>> solution = new List<List<IntPoint>>();
            //clipper.Execute(clipType, solution);
            PolyTree polyTree = new PolyTree();
            clipper.Execute(clipType, polyTree, polyFillType);
            //// 将结果转换为List<List<IntPoint>>
            return Clipper.PolyTreeToPaths(polyTree);
        }
        public static List<List<List<IntPoint>>> ClipLines(List<List<List<IntPoint>>> subject, List<IntPoint> clip, ClipType clipType, PolyFillType polyFillType = PolyFillType.pftEvenOdd)
        {
            List<List<List<IntPoint>>> sulotion = new List<List<List<IntPoint>>>();
            foreach (var i in subject)
            {
                sulotion.Add(Helper.ClipLines(i, clip, clipType, polyFillType));
            }
            return sulotion;
        }
        public static PolyTree ClipPolygonByRect(List<List<IntPoint>> subject, double xleft, double xright, double yup, double ydown, ClipType clipType)
        {
            // 创建Clipper实例
            Clipper clipper = new Clipper();
            int scale = 10000;
            IntPoint p1, p2, p3, p4;
            p1 = new IntPoint(xleft * scale, yup * scale);
            p2 = new IntPoint(xright * scale, yup * scale);
            p3 = new IntPoint(xright * scale, ydown * scale);
            p4 = new IntPoint(xleft * scale, ydown * scale);
            List<IntPoint> clip = new List<IntPoint>();
            clip.Add(p1);
            clip.Add(p2);
            clip.Add(p3);
            clip.Add(p4);
            // 将多边形和裁剪窗口添加到Clipper实例中
            clipper.AddPaths(subject, PolyType.ptSubject,true);
            clipper.AddPath(clip, PolyType.ptClip,true);

            // 执行裁剪操作
            PolyTree polyTree = new PolyTree();
            clipper.Execute(clipType, polyTree);
            return polyTree;
        }
        public static List<List<IntPoint>> Expand(List<List<IntPoint>> subject,int parallelDistance)
        {
            // 创建Clipper实例
            ClipperLib.ClipperOffset offset = new ClipperLib.ClipperOffset();
            offset.AddPaths(subject , ClipperLib.JoinType.jtRound, ClipperLib.EndType.etClosedPolygon);
            List<List<IntPoint>> solution = new List<List<IntPoint>>();
            offset.Execute(ref solution, parallelDistance);
            return solution;
        }
        public static PolyTree Expand(List<IntPoint> subject, int parallelDistance)
        {
            // 创建Clipper实例
            ClipperLib.ClipperOffset offset = new ClipperLib.ClipperOffset();
            offset.AddPath(subject, ClipperLib.JoinType.jtMiter, ClipperLib.EndType.etClosedPolygon);
            PolyTree solution = new PolyTree();
            offset.Execute(ref solution, parallelDistance);
            return solution;
        }

        public static List<List<IntPoint>> Demmo()
        {
            List<IntPoint> l1 = new List<IntPoint>();
            List<IntPoint> l2 = new List<IntPoint>();
            l1.Add(new IntPoint(0, 0));
            l1.Add(new IntPoint(100000, 0));
            l1.Add(new IntPoint(100000, 150000));
            l1.Add(new IntPoint(0, 150000));
            l1.Add(new IntPoint(0, 0));

            l2.Add(new IntPoint(500000, 0));
            l2.Add(new IntPoint(100000, 0));
            l2.Add(new IntPoint(100000, 140000));
            l2.Add(new IntPoint(50000, 140000));
            l2.Add(new IntPoint(50000, 0));

            Clipper clipper = new Clipper();

            // 将多边形和裁剪窗口添加到Clipper实例中
            clipper.AddPath(l1, PolyType.ptSubject, false);
            clipper.AddPath(l2, PolyType.ptClip, true);

            // 执行裁剪操作
            ClipperLib.PolyTree polyTree = new ClipperLib.PolyTree();
            clipper.Execute(ClipType.ctIntersection, polyTree);

            return Clipper.PolyTreeToPaths(polyTree);
        }
        public static List<List<IntPoint>> Rotate(List<List<IntPoint>> intPoints,double angle)
        {
            List<List<IntPoint>> rotatedPolygon = new List<List<IntPoint>>();
            foreach (List<IntPoint> p in intPoints)
            {
                rotatedPolygon.Add(Rotate(p, angle));
            }
            return rotatedPolygon;
        }
        public static List<IntPoint> Rotate(List<IntPoint>   intPoints, double angle)
        {
            double radians = angle * Math.PI / 180.0;

            List<IntPoint> rotatedPolygon = new List<IntPoint>();
            foreach (IntPoint p in intPoints)
            {
                int x = (int)(Math.Cos(radians) * p.X - Math.Sin(radians) * p.Y);
                int y = (int)(Math.Sin(radians) * p.X + Math.Cos(radians) * p.Y);
                rotatedPolygon.Add(new IntPoint(x, y));
            }
            return rotatedPolygon;
        }
        public static List<IntPoint> CreateRectRegion(int left ,int right, int top,int bottom, int gap, int viber, RegionInterStratege rIS = RegionInterStratege.LineInter)
        {
            List<IntPoint> rect = new List<IntPoint>();
            rect.AddRange(GeneratePolyLine_X(left, right, top, gap, viber,rIS));
            List<IntPoint> polylines = GeneratePolyLine_Y(bottom, top, right, gap, viber, rIS);
            polylines.Reverse();
            rect.AddRange(polylines);
            polylines = GeneratePolyLine_X(left, right, bottom, gap, viber, rIS);
            polylines.Reverse();
            rect.AddRange(polylines);
            rect.AddRange(GeneratePolyLine_Y(bottom, top, left, gap, viber, rIS));
            return rect;
        }

        public static List<IntPoint> GeneratePolyLine_X(int startx, int endx, int Y,int gap, int viber, RegionInterStratege rIS)
        {
            List<IntPoint> polyLine = new List<IntPoint>();

            polyLine.Add(new IntPoint(startx,Y));
            int distance = endx -startx;
            int segments = (int)(distance / gap);
            Random rd = new Random(10);
            switch (rIS)
            {
                case RegionInterStratege.LineInter:
                    break;
                case RegionInterStratege.PolyInter:
                    for (int i = 1; i <= segments; i++)
                    {
                        int x = startx + i * gap;
                        int y = Y + (int)(Math.Pow(-1, i)) * viber;
                        polyLine.Add(new IntPoint(x, y));
                    }
                    break;
                case RegionInterStratege.TriFucInter:
                    double pi = 3.14159;
                    int n = 5;
                    for (int i = 1; i <= segments; i++)
                    {
                        for (int j = 1; j < n; j++)
                        {
                            int x = startx + (i - 1) * gap+ j* gap / n;
                            int y = Y+ (int)((Math.Pow(-1, i)) * Math.Sin(j*pi/n)*viber);
                            polyLine.Add(new IntPoint(x, y));
                        }                       
                    }
                    break;
                case RegionInterStratege.RecToothInter:
                    for (int i = 1; i <= segments; i++)
                    {
                        int x1 = startx + (i -1)* gap;
                        int x2 = startx + i * gap;
                        int y = Y + (int)(Math.Pow(-1, i)) * viber;
                        polyLine.Add(new IntPoint(x1, y));
                        polyLine.Add(new IntPoint(x2, y));
                    }
                    int xend = startx + segments * gap;
                    int yend = Y + (int)(Math.Pow(-1, segments+1)) * viber;
                    polyLine.Add(new IntPoint(xend, yend));
                    polyLine.Add(new IntPoint(endx, yend));
                    break;
                case RegionInterStratege.RandomInter:
                    for (int i = 1; i <= segments; i++)
                    {
                        int x = startx + i * gap; 
                        int y = Y +  (int)(2 * (rd.NextDouble() - 0.5) * viber);
                        polyLine.Add(new IntPoint(x, y));
                    }
                    break;
                default:
                    break;
            }
            
            polyLine.Add(new IntPoint(endx, Y));
            return polyLine;
        }
        public static List<IntPoint> GeneratePolyLine_Y(int starty, int endy, int X, int gap, int viber, RegionInterStratege rIS)
        {
            List<IntPoint> polyLine = new List<IntPoint>();

            polyLine.Add(new IntPoint(X, starty));
            int distance = endy - starty;
            int segments = (int)(distance / gap);
            Random rd = new Random(10);
            switch (rIS)
            {
                case RegionInterStratege.LineInter:
                    break;
                case RegionInterStratege.PolyInter:
                    for (int i = 1; i <= segments; i++)
                    {
                        int y = starty + i * gap;
                        int x = X + (int)(Math.Pow(-1, i)) * viber;
                        polyLine.Add(new IntPoint(x, y));
                    }
                    break;
                case RegionInterStratege.TriFucInter:
                    double pi = 3.14159;
                    int n = 5;
                    for (int i = 1; i <= segments; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            int y = starty + (i-1) * gap + j * gap / n;
                            int x = X + (int)((Math.Pow(-1, i)) * Math.Sin(j * pi / n) * viber);
                            polyLine.Add(new IntPoint(x, y));
                        }
                    }
                    break;
                case RegionInterStratege.RecToothInter:
                    for (int i = 1; i <= segments; i++)
                    {
                        int y1 = starty + (i - 1) * gap;
                        int y2 = starty + i * gap;
                        int x = X + (int)(Math.Pow(-1, i)) * viber;
                        polyLine.Add(new IntPoint(x, y1));
                        polyLine.Add(new IntPoint(x, y2));
                    }
                    int yend = starty + segments * gap;
                    int xend = X + (int)(Math.Pow(-1, segments + 1)) * viber;
                    polyLine.Add(new IntPoint(xend, yend));
                    polyLine.Add(new IntPoint(xend, endy));
                    break;
                case RegionInterStratege.RandomInter:
                    for (int i = 1; i <= segments; i++)
                    {                        
                        int y = starty + i * gap;
                        int x = X + (int)(2 * (rd.NextDouble() - 0.5) * viber);
                        polyLine.Add(new IntPoint(x, y));
                    }
                    break;
                default:
                    break;
            }
            
            polyLine.Add(new IntPoint(X, endy));
            return polyLine;
        }


        public static List<List<IntPoint>> GetScanPath(List<List<IntPoint>> countors, IntSlicePara sp ,double startAngle)
        {
            List<List<IntPoint>> scanPaths = new List<List<IntPoint>>();
            List<List<IntPoint>> subject = Rotate(countors, sp.RegionAngle);
            IntRect bound = ClipperBase.GetBounds(subject);
            long divideByYNum = (bound.bottom - bound.top) / sp.RegionHeight+1;
            long divideByXNum = (bound.right - bound.left) / sp.RegionLength+1;
            for (long i = 0; i < divideByYNum; i++)
            {
                int bottom = (int)(bound.top + i * sp.RegionHeight) - sp.RegionInterGap/2;
                int top = bottom + sp.RegionHeight + sp.RegionInterGap / 2;
                double angle = startAngle+sp.PathAngleBetweenRegion * i;
                for (long j = 0; j < divideByXNum; j++)
                {
                    int left = (int)(bound.left + j * sp.RegionLength) - sp.RegionInterGap / 2;
                    int right = left + sp.RegionLength + sp.RegionInterGap / 2;
                    List<IntPoint> rectRegion = CreateRectRegion(left, right, top, bottom,sp.RegionLapGap,sp.RegionViber,sp.InterStratege);
                    Clipper clipper = new Clipper();
                    clipper.AddPaths(subject, PolyType.ptSubject, true);
                    clipper.AddPath(rectRegion, PolyType.ptClip, true);
                    List<List<IntPoint>> solution = new List<List<IntPoint>>();
                    clipper.Execute(ClipType.ctIntersection, solution);
                    scanPaths.AddRange(GetScanPathFromRegion(solution, sp.ScanSpace, angle+j* sp.PathAngleBetweenRegion));
                }
            }
            List<List<IntPoint>> scanPathss = CleanLines(scanPaths, sp.LineLengthLimited);
            return Rotate(scanPathss, -sp.RegionAngle);

        }
        public static List<List<IntPoint>> CleanLines(List<List<IntPoint>> Lines, int gap)
        {
            List<List<IntPoint>> CleanedLines = new List<List<IntPoint>>();
            foreach (var line in Lines)
            {
                if (Math.Sqrt(Math.Pow(line[1].Y - line[0].Y, 2) + Math.Pow(line[1].X - line[0].X, 2)) > gap)
                    CleanedLines.Add(line);
            }
            return CleanedLines;
        }
        public static List<List<IntPoint>> GetScanPathFromRegion(List<List<IntPoint>> countors,int parallelDistance, double degree)
        {

            List<List<IntPoint>> subject = Rotate(countors, degree);
            IntRect bound = ClipperBase.GetBounds(subject);
            long layNum = (bound.bottom - bound.top) / parallelDistance;
            Clipper clipper = new Clipper();
            clipper.AddPaths(subject, PolyType.ptClip, true);
            for (long i = 0; i < layNum + 1; i++)
            {
                List<IntPoint> clipline = new List<IntPoint>();
                if (i % 2 == 0)
                {
                    clipline.Add(new IntPoint(bound.left, bound.top + parallelDistance * i));
                    clipline.Add(new IntPoint(bound.right, bound.top + parallelDistance * i));
                }
                else {                   
                    clipline.Add(new IntPoint(bound.right, bound.top + parallelDistance * i));
                    clipline.Add(new IntPoint(bound.left, bound.top + parallelDistance * i));
                }
                clipper.AddPath(clipline, PolyType.ptSubject, false);
            }
            PolyTree polytree = new PolyTree();
            clipper.Execute(ClipType.ctIntersection, polytree);
            return Rotate(Clipper.PolyTreeToPaths(polytree), -degree);           
        }

        public static bool IsLineOnCountors(IntPoint p1, IntPoint p2, List<List<IntPoint>> countors)
        {
            foreach (List<IntPoint> intPoints in countors)
            {              
                if (IsLineOnCountor(p1,p2,intPoints))
                    return true;
            }
            return false;
        }
        public static bool IsLineOnCountor(IntPoint p1, IntPoint p2, List<IntPoint> countor)
        {
            for (int i = 0; i < countor.Count; i++)
            {
                IntPoint p3 = countor[i];
                IntPoint p4 = countor[(i + 1) % countor.Count];
                if (IsLineOnLine(p1,p2,p3,p4))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsLineOnLine(IntPoint p1, IntPoint p2, IntPoint p3, IntPoint p4)
        {
            // 计算线段所在直线的一般式方程的系数
            return IsPointOnLine(p1, p3, p4) && IsPointOnLine(p2, p3, p4);
        }
        public static bool IsPointOnLine(IntPoint p, IntPoint p1, IntPoint p2)
        {
            // 计算线段所在直线的一般式方程的系数
            double a = p2.Y - p1.Y;
            double b = p1.X - p2.X;
            double c = p2.X * p1.Y - p1.X * p2.Y;

            // 计算点到直线的距离
            double d = Math.Abs(a * p.X + b * p.Y + c) / Math.Sqrt(a * a + b * b);

            // 计算点在直线上的投影点
            double xp = (b * b * p.X - a * b * p.Y - a * c) / (a * a + b * b);
            double yp = (a * a * p.Y - a * b * p.X - b * c) / (a * a + b * b);

            // 判断投影点是否在线段上
            return xp >= Math.Min(p1.X, p2.X) && xp <= Math.Max(p1.X, p2.X) &&
                   yp >= Math.Min(p1.Y, p2.Y) && yp <= Math.Max(p1.Y, p2.Y) &&
                   d < 1e-3; // 可以添加一个误差范围
        }
    }
}
