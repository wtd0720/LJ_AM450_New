
using ClipperHelper;
//using Manufacture;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LJ_AM450_New
{
    [Serializable]
    public class ParaAll
    {
        public SlicePara slicePara = null;
        //public ManuPara manuPara = null;

        public ParaAll(string file)
        {
            if (file != null && file != "")
            {
                ParaAll p = ParaAll.DeserializeObject(file);
                slicePara = p.slicePara;
                //manuPara =p.manuPara;
            }
            else
            {
                slicePara = new SlicePara();
                //manuPara = new ManuPara();
            }
        }
        public ParaAll()
        {
            slicePara = new SlicePara();
            //manuPara = new ManuPara();
        }
        public ParaAll(string spFile , string mpFile)
        {
            if (spFile != null && spFile != "")
            {
                slicePara = SlicePara.DeserializeObject(spFile);
            }
            else {
                slicePara = new SlicePara();
            }

            if (mpFile != null && mpFile != "")
            {
                //manuPara = ManuPara.DeserializeObject(mpFile);
            }
            else
            {
                //manuPara = new ManuPara();
            }
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
        public static ParaAll DeserializeObject(string filename)
        {
            // 打开文件流
            FileStream fileStream = new FileStream(filename, FileMode.Open);

            // 创建一个BinaryFormatter来反序列化对象
            BinaryFormatter formatter = new BinaryFormatter();
            ParaAll obj = (ParaAll)formatter.Deserialize(fileStream);

            // 关闭文件流
            fileStream.Close();

            // 返回反序列化后的对象
            return obj;
        }
    }
}
