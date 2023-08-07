using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class read_writeFile
    {
        public static void  readwriteFile(int x) {
            FileInfo fileInfo = new FileInfo(@"D:\Basic\angular Files Demo\readWrite.txt");

            //write and read File
           // FileStream fileStream= fileInfo.Open(FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);

            //Append the content
            //FileStream fileStream= fileInfo.Open(FileMode.Append,FileAccess.Write,FileShare.ReadWrite);
            //StreamWriter sw = new StreamWriter(fileStream);
            //read only file
           //StreamReader sr = new StreamReader(fileStream);
            try
            {
                //for (int i = 0; i < x; i++)
                //{
                //    Console.WriteLine("Enter your Name:");
                //    string a = Console.ReadLine();
                //    Console.WriteLine("Enter your Age:");
                //    string b = Console.ReadLine();
                //    sw.WriteLine("Name:" + a + "\n" + "Age:" + b);
                //}
                //string data = sr.ReadToEnd();
                // Console.WriteLine(data);

                //copy File
                //File.Copy(@"D:\Basic\angular Files Demo\readWrite.txt", @"D:\Basic\angular Files Demo\CopiedFile.txt");

                //move File
                File.Move(@"D:\Basic\angular Files Demo\CopiedFile.txt", @"D:\Basic\angular Files Demo\file\CopiedFile.txt");
            }
            catch (Exception ex) { 
            Console.WriteLine(ex.Message);
            }
            finally
            {

               // sr.Close(); 
                //sw.Close();
                //fileStream.Close();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Employee:");
            int x = Convert.ToInt32(Console.ReadLine());
            readwriteFile(x);
        }
    }
}
