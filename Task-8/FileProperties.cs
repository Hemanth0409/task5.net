using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class FileProperties
    {
        static void Main(string[] args)
        {
            string file = @"D:\Basic\angular Files Demo\BonusCalculation.csv";

            FileInfo oFileInfo = new FileInfo(file);
            Console.WriteLine("My File's Name: \"" + oFileInfo.Name + "\"");
            DateTime dtCreationTime = oFileInfo.CreationTime;
            Console.WriteLine("Date and Time File Created: " + dtCreationTime.ToString());
            Console.WriteLine("myFile Extension: " + oFileInfo.Extension);
            Console.WriteLine("myFile total Size: " + oFileInfo.Length.ToString());
            Console.WriteLine("myFile filepath: " + oFileInfo.DirectoryName);
            Console.WriteLine("My File's Full Name: \"" + oFileInfo.FullName + "\"");
            Console.WriteLine("My File's Directory: \"" + oFileInfo.Directory);
            Console.WriteLine("My File's LastAccessTime: \"" + oFileInfo.LastAccessTime);
            Console.WriteLine("My File's LastWriteTime: \"" + oFileInfo.LastWriteTime);
        }
    }
}
