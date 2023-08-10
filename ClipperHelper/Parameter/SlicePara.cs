using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClipperHelper
{
    [Serializable]
    public class SlicePara
    {
        public FillPara UpperSurfaceSlicePara;

        public FillPara LowerSurfaceSlicePara;

        public FillPara BaseRegionSlicePare;

        public FillPara SupportSlicePare;

        public BasePara BaseSlicePara;
        public SlicePara()
        {
            UpperSurfaceSlicePara = new FillPara(1);
            LowerSurfaceSlicePara = new FillPara(2);
            BaseRegionSlicePare = new FillPara(0);
            SupportSlicePare = new FillPara(3);
            BaseSlicePara = new BasePara();
            SupportSlicePare.isFill = false;
        }
        public void Save(string filename)
        {
            // 创建一个文件流
            FileStream fileStream = new FileStream(filename, FileMode.Create);

            // 创建一个BinaryFormatter来序列化对象并将其写入文件
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, this);

            // 关闭文件流
            fileStream.Close();
        }
        public static SlicePara DeserializeObject(string filename)
        {
            // 打开文件流
            FileStream fileStream = new FileStream(filename, FileMode.Open);

            // 创建一个BinaryFormatter来反序列化对象
            BinaryFormatter formatter = new BinaryFormatter();
            SlicePara obj = (SlicePara)formatter.Deserialize(fileStream);

            // 关闭文件流
            fileStream.Close();

            // 返回反序列化后的对象
            return obj;
        }
    }
}
