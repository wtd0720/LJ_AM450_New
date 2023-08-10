using ClipperLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipperHelper
{
    public class CurrentSlicePlane
    {
        public List<List<IntPoint>> PreCountors;
        public List<List<IntPoint>> CurrentCountors;
        public List<List<IntPoint>> NextCountors;
        public List<List<IntPoint>> SupportCountors;
        private List<List<IntPoint>> currentClosed;
        public int scale = 10000;
        public CurrentSlicePlane()
        {
            PreCountors = new List<List<IntPoint>>();
            CurrentCountors = new List<List<IntPoint>>();
            NextCountors = new List<List<IntPoint>>();
            SupportCountors = new List<List<IntPoint>>();
            currentClosed = new List<List<IntPoint>>();
        }
        public CurrentSlicePlane(CurrentSlicePlane scp ,int expandScale)
        {
            PreCountors = Helper.Expand(scp.PreCountors, expandScale);
            CurrentCountors = Helper.Expand(scp.CurrentCountors, expandScale);
            NextCountors = Helper.Expand(scp.NextCountors, expandScale);
            SupportCountors = scp.SupportCountors;
            currentClosed = ToClosedCountors();
        }
        public CurrentSlicePlane(List<List<double[]>> r1, List<List<double[]>> r2, List<List<double[]>> r3, List<List<double[]>> r4) :this()
        {
            PreCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.DoubleToIntPoints(r1, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            CurrentCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.DoubleToIntPoints(r2, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            NextCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.DoubleToIntPoints(r3, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            SupportCountors = Helper.DoubleToIntPoints(r4, scale);
            currentClosed = ToClosedCountors();
        }
        public CurrentSlicePlane(List<List<double[]>> r1, List<List<double[]>> r2, List<List<double[]>> r3) : this()
        {
            PreCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.DoubleToIntPoints(r1, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            CurrentCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.DoubleToIntPoints(r2, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            NextCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.DoubleToIntPoints(r3, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            currentClosed = ToClosedCountors();
        }
        public CurrentSlicePlane(List<PointF[]> r1, List<PointF[]> r2, List<PointF[]> r3, List<PointF[]> r4) : this()
        {
            PreCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.PointFToInts(r1, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            CurrentCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.PointFToInts(r2, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            NextCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.PointFToInts(r3, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            SupportCountors = Helper.PointFToInts(r4, scale);
            currentClosed = ToClosedCountors();
        }
        public CurrentSlicePlane(List<PointF[]> r1, List<PointF[]> r2, List<PointF[]> r3) : this()
        {
            PreCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.PointFToInts(r1, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            CurrentCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.PointFToInts(r2, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            NextCountors = Clipper.ClosedPathsFromPolyTree(Helper.ClipPolygonByRect(Helper.PointFToInts(r3, scale), -500, 500, 500, -500, ClipType.ctIntersection));
            currentClosed = ToClosedCountors();
        }

        public List<FillRegion> GetLowerSurface(int threshold)
        {
            if (PreCountors.Count == 0)
                return FillRegion.ConvertToFillRegions(CurrentCountors);
            PolyTree plt = Helper.ClipPolygon(CurrentCountors, PreCountors, ClipType.ctDifference);
            List<FillRegion> fillRegions = FillRegion.ConvertToFillRegions(Clipper.CleanPolygons(Clipper.PolyTreeToPaths(plt)));
            List<FillRegion> finalRegions = new List<FillRegion>();
            foreach (var fg in fillRegions)
            {
                if (fg.Area / (fg.Perimeter / 2) > threshold)
                    finalRegions.Add(fg);
            }
            return finalRegions;
        }
        public List<FillRegion> GetUpperSurface(int threshold)
        {
            if (NextCountors.Count == 0)
                return FillRegion.ConvertToFillRegions(CurrentCountors);
            PolyTree plt = Helper.ClipPolygon(CurrentCountors, NextCountors, ClipType.ctDifference);
            List<FillRegion> fillRegions = FillRegion.ConvertToFillRegions(Clipper.CleanPolygons(Clipper.PolyTreeToPaths(plt)));
            List<FillRegion> finalRegions = new List<FillRegion>();
            foreach (var fg in fillRegions)
            {
                if (fg.Area / (fg.Perimeter / 2) > threshold)
                    finalRegions.Add(fg);
            }
            return finalRegions;
        }
        public List<List<IntPoint>> GetBaseRegion(int upperthreshold,int lowerthreshold)
        {
            List<FillRegion> LowerSurface = GetLowerSurface(lowerthreshold);
            List<FillRegion> UpperSurface = GetUpperSurface(upperthreshold);
            List<List<IntPoint>> intPointsLower = FillRegion.GetAllRings(LowerSurface);
            List<List<IntPoint>> intPointsUpper = FillRegion.GetAllRings(UpperSurface);
            PolyTree plt = Helper.ClipPolygon(intPointsLower, intPointsUpper, ClipType.ctUnion);
            PolyTree plt2 = Helper.ClipPolygon(CurrentCountors, Clipper.PolyTreeToPaths(plt), ClipType.ctDifference);        
            return Clipper.CleanPolygons(Clipper.PolyTreeToPaths(plt2));
        }

        public List<List<IntPoint>> GetLowerCountors(int lowerthreshold)
        {
            List<FillRegion> LowerSurface = GetLowerSurface(lowerthreshold);
            List<List<IntPoint>> intPointsLower = Helper.Expand(FillRegion.GetAllRings(LowerSurface), 10);
            return Clipper.PolyTreeToPaths(Helper.ClipLines(currentClosed, intPointsLower, ClipType.ctIntersection));
        }
        public List<List<IntPoint>> GetUpperCountors(int Upperthreshold)
        {
            List<FillRegion> UpperSurface = GetUpperSurface(Upperthreshold);
            List<List<IntPoint>> intPointsUpper = Helper.Expand(FillRegion.GetAllRings(UpperSurface), 10);
            return Clipper.PolyTreeToPaths(Helper.ClipLines(currentClosed, intPointsUpper, ClipType.ctIntersection));
        }

        public List<List<IntPoint>> GetBaseCountors(int upperthreshold, int lowerthreshold)
        {
            List<List<IntPoint>> intPointsBase = Helper.Expand(GetBaseRegion(upperthreshold, lowerthreshold), 10);
            return Clipper.PolyTreeToPaths(Helper.ClipLines(currentClosed, intPointsBase, ClipType.ctIntersection));           
        }
        public List<List<IntPoint>> ToClosedCountors()
        {
            List<List<IntPoint>> closedCountors = new List<List<IntPoint>>();
            foreach (var intPoints in CurrentCountors)
            {
                if (intPoints.Count > 0)
                {
                    List<IntPoint> temp = intPoints;
                    temp.Add(intPoints.First());
                    closedCountors.Add(temp);
                }
            }
            return closedCountors;
        }
    }
}
