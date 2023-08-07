using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    [Serializable]
    internal class FileMethodsMeet
    {
        public int id;
        public string name;
        static void Main(string[] args)
        {
            FileMethodsMeet file1 = new FileMethodsMeet();
            file1.id = 1;
            file1.name= "Test";

            //(IFormatter is an interface)(BinaryFormatter is buildin class)Interface  to serialization 2abstractMethod(seralizer and deserializer)
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(@"D:\Basic\fileSerialize.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            formatter.Serialize(s, file1);
            s.Close();

           // Stream s1 = new FileStream(@"D:\Basic\fileSerialize.txt", FileMode.Open, FileAccess.Read);
           //f2=(FileMethodsMeet)formatter.Deserialize(s1);
           // formatter.Deserialize(s1);
           // s.Close();
        }
    }
}
