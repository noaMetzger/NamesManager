using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using NamesManager.Interface;

namespace NamesManager.Class
{
    public class JsonFile<T>:ISource<T>
    {
       public string FilePath { get; set; }
        public JsonFile(string filePath)
        {
            FilePath = filePath;
        }
        public List<T> Read()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<T>>(json);
            }
            return null;
        }

        public void Write(List<T> objects)
        {
            string json = JsonSerializer.Serialize(objects);
            File.WriteAllText(FilePath, json);
        }
    }
}
