using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ClipperHelper
{ 
    public class SliceReader
    {
        public static bool LoadSLCFile(string path,out AllCountors OutLines)
        {
            OutLines = new AllCountors();

            try
            {
                using (FileStream fp = new FileStream(path, FileMode.Open))
                {
                    // header string 最大字符串2048
                    // header string 结束字符 0x0d,0x0a,0x1a
                    int b;
                    StringBuilder builder = new StringBuilder();
                    while (builder.Length < 2048)
                    {
                        b = fp.ReadByte();
                        builder.Append(Convert.ToChar(b));
                        if (b == 0x0d)
                        {
                            b = fp.ReadByte();
                            builder.Append(Convert.ToChar(b));
                            if (b == 0x0a)
                            {
                                b = fp.ReadByte();
                                builder.Append(Convert.ToChar(b));
                                if (b == 0x1a)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    List<string> strList = new List<string>(builder.ToString().Split('S').ToList());
                    string[] strList1 = strList[strList.Count - 1].Split(' ');
                    string[] xlist = strList1[1].Split(',');
                    string[] ylist = strList1[2].Split(',');
                    string[] zlist = strList1[3].Split(',');
                    float zmi, zma;
                    zmi = float.Parse(zlist[0]);
                    zma = float.Parse(zlist[1]);
                    OutLines.zmax = zma;
                    OutLines.zmin = zmi;
                    OutLines.ymax = float.Parse(ylist[1]); 
                    OutLines.ymin = float.Parse(ylist[0]);
                    OutLines.xmax = float.Parse(xlist[1]);
                    OutLines.xmin = float.Parse(xlist[0]);
                    // reserved section 跳过预留的256byte
                    fp.Seek(256, SeekOrigin.Current);
                    // sampleing table section
                    // sampleing table 每个entry 1 byte size
                    // sampleing table 每个entry 4 float ,将minZ和thickness 保存
                    b = fp.ReadByte();
                    byte[] entry = new byte[4];
                    float dh = 0;
                    for (int i = 0; i < b; i++)
                    {
                        fp.Read(entry, 0, 4);
                        zmi = System.BitConverter.ToSingle(entry, 0); // 最小z
                        fp.Read(entry, 0, 4);
                        dh = System.BitConverter.ToSingle(entry, 0); // 切片厚度
                        fp.Read(entry, 0, 4); // 读取线宽补偿
                        fp.Read(entry, 0, 4); // 读取保留位
                    }
                    OutLines.LayerHeight = dh;
                    OutLines.LayNum = Convert.ToInt32((zma - zmi) / dh + 1);
                    
                    // Contour Data Section
                    // 如果是最后一层 `z layer`和终止符  2 float , 打印结束
                    // 如果不是 `z layer`和边界数量
                    float zh = 0;//层高
                    uint bn = 0;//轮廓数量，boundary num
                    while (true)
                    {//每次读取四个字节
                        List<PointF[]> mrs  =new List<PointF[]>();//ring数组用于存放轮廓
                        fp.Read(entry,0,4);
                        zh = BitConverter.ToSingle(entry,0);//层高
                        fp.Read(entry, 0, 4);
                        bn = BitConverter.ToUInt32(entry,0);//轮廓数量，boundary num
                        if (bn == 4294967295)//读到最后，结束读取
                            break;
                        for (uint i = 0; i < bn; i++)
                        {
                            fp.Read(entry, 0, 4); //读取轮廓上点的数量
                            uint bpn = BitConverter.ToUInt32(entry,0);//轮廓点数量，boundary point number
                            fp.Read(entry, 0, 4); //轮廓间隔，boundary gap
                            PointF[] pt =new PointF[bpn];//存放读取点坐标值
                            for (uint j = 0; j < bpn; j++)
                            {
                                PointF p = new PointF();
                                fp.Read(entry, 0, 4);//x坐标
                                p.X = BitConverter.ToSingle(entry, 0);
                                fp.Read(entry, 0, 4);//y坐标
                                p.Y = BitConverter.ToSingle(entry, 0);
                                pt[j] = p;
                            }
                            mrs.Add(pt);
                        }
                        OutLines.allCountors.Add(mrs);
                    }
                }
                return true;                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
