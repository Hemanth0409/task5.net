using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class CommandLine
    {
        static void Main(string[] args)
        {
            int arg1 = Convert.ToInt32(args[0]);
            Console.WriteLine("Enter your Id:"+arg1);
            string arg2= Convert.ToString(args[1]);
            Console.WriteLine("Name:" + arg2);
            if (arg1 <= 10)
            {
                Console.WriteLine("Development sector");
            }
            else
            {
                Console.WriteLine("Testing");
            }
            Console.ReadKey();
        }
    }
}
