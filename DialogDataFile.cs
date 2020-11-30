using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Spool
{
    [Serializable]
    public class DialogDataFile
    {
        public JsonSerializer SerializerSettings {
            get {
                JsonSerializer serializer = new JsonSerializer();
                serializer.ContractResolver = new CamelCasePropertyNamesContractResolver();
                return serializer;
            }
        }
        public Dictionary<object, DialogDataNode> Data { get; set; }
        public TreeNode[] Nodes { get; set; }

        public DialogDataFile(Dictionary<object, DialogDataNode> data, TreeNodeCollection nodes)
        {
            Nodes = nodes.Cast<TreeNode>().ToArray();
            Data = data;
        }

        public DialogDataFile(string file)
        {
            using (Stream stream = File.Open(file, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                DialogDataFile dialog = formatter.Deserialize(stream) as DialogDataFile;
                Data = dialog.Data;
                Nodes = dialog.Nodes;
            }
        }

        public void Save(string file)
        {
            using (Stream stream = File.Open(file, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }
        }

        public void Export(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                JArray array = new JArray();
                foreach (DialogDataNode node in Data.Values.ToArray())
                    array.Add(JObject.FromObject(node, SerializerSettings));
                writer.Write(array.ToString());
            }
        }
    }
}
