using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LJ_AM450_New
{
    [DefaultPropertyAttribute("Name")]
    [Serializable]
    public class MyProject
    {
        public string Name { get; set; }

        public ParaAll para;

        public string _modelfile;
        public string _supportfile;

        public MyProject()
        {
            this.Name = "Project1";
            _modelfile = null;
            _supportfile = null;
            para = new ParaAll();
        }
        public MyProject(string name) : this()
        {
            this.Name = name;
        }
        public void AddModel(string modelfile)
        {
            _modelfile = modelfile;
        }
        public void RemoveModel()
        {
            _modelfile = null;
        }
        public void AddSupport(string modelfile)
        {
            _supportfile = modelfile;
        }
        public void RemoveSupport()
        {
            _supportfile = null;
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
        public static MyProject DeserializeObject(string filename)
        {
            // 打开文件流
            FileStream fileStream = new FileStream(filename, FileMode.Open);

            // 创建一个BinaryFormatter来反序列化对象
            BinaryFormatter formatter = new BinaryFormatter();
            MyProject obj = (MyProject)formatter.Deserialize(fileStream);

            // 关闭文件流
            fileStream.Close();

            // 返回反序列化后的对象
            return obj;
        }
    }
}
