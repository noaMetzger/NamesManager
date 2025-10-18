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
    public class JsonFile:ISource
    {
       public string FilePath { get; set; }
        public JsonFile(string filePath)
        {
            FilePath = filePath;
        }
        public List<Person> Read()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Person>>(json);
            }
            return null;
        }

        public void Write(List<Object> objects)
        {
            string json = JsonSerializer.Serialize(objects);
            File.WriteAllText(FilePath, json);
        }
    }
}
