using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Utilities
{
    class configObj
    {
        public string name;
        public int value;

        public configObj(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
    }
    class Config
    {
        private static Config instance;
        private static List<configObj> objList;
        public static int load(string key)
        {
            reload();
            return readLocal(key);
        }
        public static void save(string key, int value)
        {
            writeLocal(key, value);
            writeToFile();
        }
        private static void reload()
        {
            if (objList == null) objList = new List<configObj>();
            string obj;
            using (StreamReader r = new StreamReader(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\Configuration.txt"))
            {
                obj = r.ReadToEnd();
                objList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<configObj>>(obj);
                if (objList == null) objList = new List<configObj>();
            }
        }
        private static int readLocal(string key)
        {
            foreach (configObj obj in objList)
            {
                if (obj.name.Equals(key)) return obj.value;
            }
            return 0;
        }
        private static void writeLocal(string key, int value)
        {
            if (objList == null) reload();
            foreach (configObj obj in objList)
            {
                if (obj.name.Equals(key))
                {
                    obj.value = value;
                    return;
                }
            }
            objList.Add(new configObj(key, value));
        }
        private static void writeToFile()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(objList.ToArray());
            System.IO.File.WriteAllText(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\Configuration.txt", json);
        }
    }
}
