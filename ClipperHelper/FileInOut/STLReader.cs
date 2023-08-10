using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitware.VTK;

namespace ClipperHelper
{
    public class STLReader
    {
        public static AllCountors LoadSTLFile(string path,float height)
        {
            AllCountors OutLines = new AllCountors(height);
            vtkSTLReader reader = vtkSTLReader.New();
            reader.SetFileName(path);
            reader.Update();
            double[] bounds = reader.GetOutput().GetBounds();
            OutLines.zmax = (float)bounds[5];
            OutLines.zmin = (float)bounds[4];
            OutLines.ymax = (float)bounds[3];
            OutLines.ymin = (float)bounds[2];
            OutLines.xmax = (float)bounds[1];
            OutLines.xmin = (float)bounds[0];
            OutLines.LayNum = (int)((OutLines.zmax - OutLines.zmin) / height + 1);

            vtkPolyDataNormals normals = vtkPolyDataNormals.New();
            normals.SetInputConnection(reader.GetOutputPort());
            normals.ComputeCellNormalsOn();
            normals.ComputePointNormalsOn();
            normals.FlipNormalsOff();
            normals.ConsistencyOn();
            normals.Update();

            // 修复表面拓扑错误
            vtkCleanPolyData clean = vtkCleanPolyData.New();
            clean.SetInputConnection(normals.GetOutputPort());
            clean.Update();

            //vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            //mapper.SetInputConnection(clean.GetOutputPort());

            //vtkActor actor = vtkActor.New();
            //actor.SetMapper(mapper);
            for (int i = 0; i < OutLines.LayNum; i++)
            {
                double z = i * OutLines.LayerHeight + OutLines.zmin + 0.01;
                vtkCutter cutter = vtkCutter.New();
                cutter.SetInput(clean.GetOutput());
                
                vtkPlane cutterPlane = vtkPlane.New();
                cutterPlane.SetOrigin(0, 0, z);
                cutterPlane.SetNormal(0, 0, -1);
                cutter.SetCutFunction(cutterPlane);
                cutter.Update();
                OutLines.allCountors.Add(Helper.DoubleToPointFs(GetLinesFromCutter(cutter)));
            }
            return OutLines;
        }
        public static List<List<double[]>> GetLinesFromCutter(vtkCutter cutter)
        {
            vtkStripper stripper = vtkStripper.New();
            stripper.SetInputConnection(cutter.GetOutputPort());
            stripper.Update();
            vtkPolyData output = stripper.GetOutput();
            vtkCellArray cells = output.GetLines();
            vtkIdList ids = vtkIdList.New();

            List<List<double[]>> lines = new List<List<double[]>>(); //修改

            // 遍历每一个line，并将其放入List中
            for (cells.InitTraversal(); cells.GetNextCell(ids) != 0;)
            {
                // 获取这条线的点数
                long numPoints = ids.GetNumberOfIds();

                // 创建一个新的List来存储这条线的点
                List<double[]> line = new List<double[]>(); //修改

                // 遍历这条线的每个点，并将其添加到List中
                for (long i = 0; i < numPoints; i++)
                {
                    double[] point = output.GetPoint(ids.GetId(i));
                    //output.GetPoint(ids.GetId(i), point);
                    line.Add(point);
                }

                // 将这条线添加到List中
                lines.Add(line);
            }
            return lines;
        }
        public List<List<double[]>> GetClosedLinesFromLines(List<List<double[]>> lines)
        {
            List<List<double[]>> closedLoops = new List<List<double[]>>();
            int count = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                var polyline = lines[i];
                // 获取多段线的首尾点
                if (IsSamePoint(polyline[0], polyline[polyline.Count - 1]))
                {
                    closedLoops.Add(polyline);
                    lines.RemoveAt(i);
                    i--;
                    continue;
                }
            }
            for (int i = 0; i < lines.Count; i++)
            {
                var polyline = lines[i];
                lines.RemoveAt(i);
                i--;
                for (int j = 0; j < lines.Count; j++)
                {
                    var otherPolyline = lines[j];
                    if (polyline == otherPolyline)
                        continue;
                    // 判断是否有与首尾点重合的点
                    // 头和头重合
                    if (IsSamePoint(polyline[0], otherPolyline[0]))
                    {
                        polyline.Reverse();
                        // 将当前多段线的点按顺序加入闭合环
                        polyline.AddRange(otherPolyline.Skip(1));
                        lines.RemoveAt(j);
                        j = -1;
                        count++;
                    }
                    // 头和尾重合
                    else if (IsSamePoint(polyline[0], otherPolyline[otherPolyline.Count - 1]))
                    {
                        // 将当前多段线的点按顺序加入闭合环
                        otherPolyline.AddRange(polyline.Skip(1));
                        polyline = otherPolyline;
                        lines.RemoveAt(j);
                        j = -1;
                    }
                    // 尾和尾重合
                    else if (IsSamePoint(polyline[polyline.Count - 1], otherPolyline[otherPolyline.Count - 1]))
                    {
                        // 将当前多段线的点按相反顺序加入闭合环
                        otherPolyline.Reverse();
                        polyline.AddRange(otherPolyline.Skip(1));
                        lines.RemoveAt(j);
                        j = -1;
                        count++;
                    }
                    // 尾和头重合
                    else if (IsSamePoint(polyline[polyline.Count - 1], otherPolyline[0]))
                    {
                        // 将当前多段线的点直接加入闭合环
                        polyline.AddRange(otherPolyline.Skip(1));
                        lines.RemoveAt(j);
                        j = -1;
                    }

                    if (IsSamePoint(polyline[0], polyline[polyline.Count - 1]))
                    {
                        closedLoops.Add(polyline);
                        break;
                    }
                }
            }
            return closedLoops;
        }
        public bool IsSamePoint(double[] p1, double[] p2)
        {
            double distance = Math.Sqrt(Math.Pow((p1[0] - p2[0]), 2) + Math.Pow((p1[0] - p2[0]), 2) + Math.Pow((p1[0] - p2[0]), 2));
            return distance < 0.0005;
        }
    }
}
