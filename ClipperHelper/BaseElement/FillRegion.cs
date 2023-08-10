using ClipperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipperHelper
{

    public class FillRegion
    {
        //private List<IntPoint> _outerRing;
        private List<List<IntPoint>> _countors;
        private List<List<IntPoint>> _remainCountors;
        private List<List<IntPoint>> _scanPath;
        public double Area, Perimeter;

        //public List<IntPoint> OuterRing
        //{
        //    get { return _outerRing; }
        //    set { _outerRing = value; }
        //} 
        public List<List<IntPoint>> Countors
        {
            get { return _countors; }
            set { _countors = value; }
        }
        public List<List<IntPoint>> ScanPath
        {
            get { return _scanPath; }
            set { _scanPath = value; }
        }

        public List<List<IntPoint>> RemainCountors
        {
            get { return _remainCountors; }
            set { _remainCountors = value; }
        }


        public FillRegion()
        {
            //OuterRing = new List<IntPoint>();
            Countors = new List<List<IntPoint>>();
            ScanPath = new List<List<IntPoint>>();
            RemainCountors = new List<List<IntPoint>>();
            Area = 0;
            Perimeter = 0;
        }
        public static List<FillRegion> ConvertToFillRegions(PolyTree plt)
        {
            List<FillRegion> fgs = new List<FillRegion>();
            foreach (PolyNode node in plt.Childs)
            {
                fgs.AddRange(GetRegionFromPolyNode(node));
            }
            return fgs;
        }
        public static List<FillRegion> GetRegionFromPolyNode(PolyNode pn)
        {
            List<FillRegion> fgs = new List<FillRegion>();
            FillRegion fg = new FillRegion();
            fg.Countors.Add(pn.Contour);
            fg.Area += Math.Abs(Clipper.Area(pn.Contour));
            fg.Perimeter += GetPerimeter(pn.Contour);
            foreach (var childnode in pn.Childs)
            {
                fg.Countors.Add(childnode.Contour);
                fg.Area -= Math.Abs(Clipper.Area(childnode.Contour));
                fg.Perimeter += GetPerimeter(childnode.Contour);
                foreach (var childchildnode in childnode.Childs)
                {
                    fgs.AddRange(GetRegionFromPolyNode(childchildnode));
                }
            }
            fgs.Add(fg);
            return fgs;
        }
        public static List<FillRegion> ConvertToFillRegions(List<List<IntPoint>> intPoints)
        {
            PolyTree plt = Helper.ClipPolygonByRect(intPoints, -500, 500, 500, -500, ClipType.ctIntersection);
            return ConvertToFillRegions(plt);
        }

        public void GetScanPath(int parallelDistance, double degree)
        {

            ScanPath.Clear();
            List<List<IntPoint>> subject = Helper.Rotate(Countors, degree);
            //subject.Add(this.OuterRing);
            //subject.AddRange(Countors);
            IntRect bound = ClipperBase.GetBounds(subject);
            long layNum = (bound.bottom - bound.top) / parallelDistance;
            Clipper clipper = new Clipper();
            clipper.AddPaths(subject, PolyType.ptClip, true);
            for (long i = 0; i < layNum + 1; i++)
            {
                List<IntPoint> clipline = new List<IntPoint>();
                clipline.Add(new IntPoint(bound.left, bound.top + parallelDistance * i));
                clipline.Add(new IntPoint(bound.right, bound.top + parallelDistance * i));
                clipper.AddPath(clipline, PolyType.ptSubject, false);
            }
            PolyTree polytree = new PolyTree();
            clipper.Execute(ClipType.ctIntersection, polytree);
            ScanPath = Helper.Rotate(Clipper.PolyTreeToPaths(polytree), -degree);
        }
        public static List<List<IntPoint>> GetRing2DsFromNode(PolyNode node)
        {
            List<List<IntPoint>> lines = new List<List<IntPoint>>();
            lines.Add(node.Contour);
            foreach (PolyNode childNode in node.Childs)
            {
                lines.AddRange(GetRing2DsFromNode(childNode));
            }
            return lines;
        }
        public static double GetPerimeter(List<IntPoint> polygon)
        {
            double perimeter = 0;
            for (int i = 0; i < polygon.Count - 1; i++)
            {
                perimeter += Math.Sqrt(Math.Pow(polygon[i + 1].X - polygon[i].X, 2) + Math.Pow(polygon[i + 1].Y - polygon[i].Y, 2));
            }
            perimeter += Math.Sqrt(Math.Pow(polygon[0].X - polygon[polygon.Count - 1].X, 2) + Math.Pow(polygon[0].Y - polygon[polygon.Count - 1].Y, 2));
            return perimeter;
        }

        public static List<List<IntPoint>> GetAllRings(List<FillRegion> fgs)
        {
            List<List<IntPoint>> intPoints = new List<List<IntPoint>>();
            foreach (var fg in fgs)
            {
                intPoints.AddRange(fg.Countors);
            }
            return intPoints;
        }

    }
}
