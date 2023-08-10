using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipperHelper
{
    public class AllCountors
    {
        public List<List<PointF[]>> allCountors;
        public int LayNum;
        public float LayerHeight;
        public float zmin, zmax, xmin, xmax, ymin, ymax;

        public AllCountors()
        {
            allCountors = new List<List<PointF[]>>();
            LayNum = 0;
            LayerHeight = 0;
            zmin = 0;
            xmin = 0;
            xmax = 0;
            zmax = 0;
            ymin = 0;
            ymax = 0;
        }
        public AllCountors(AllCountors ac , int AddPre,int AddEnd)
        {
            allCountors = new List<List<PointF[]>>();
            for (int i = 0; i < AddPre; i++)
            {
                PointF[] pointFs = new PointF[0];
                List<PointF[]> points = new List<PointF[]>();
                points.Add(pointFs);
                allCountors.Add(points);
            }
            //allCountors = new List<List<PointF[]>>(new List<PointF[]>[Add]);
            allCountors.AddRange(ac.allCountors);
            for (int i = 0; i < AddEnd; i++)
            {
                PointF[] pointFs = new PointF[0];
                List<PointF[]> points = new List<PointF[]>();
                points.Add(pointFs);
                allCountors.Add(points);
            }
            LayNum = allCountors.Count;
            LayerHeight = ac.LayerHeight;
            zmin = ac.zmin;
            xmin = ac.xmin;
            xmax = ac.xmax;
            zmax = ac.zmax;
            ymin = ac.ymin;
            ymax = ac.ymax;
        }
        public AllCountors(float h):this()
        {
            LayerHeight = h;
        }
    }
}
