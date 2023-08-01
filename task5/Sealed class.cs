using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    sealed class Sealed_class
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class sealedFunc
    {
        static void Main(string[] args)
        {
            Console.Write("Sealed Class:");
            Console.Write("\n");
            Sealed_class slc = new Sealed_class();
            Console.Write("num1:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2:");
            int y = Convert.ToInt32(Console.ReadLine());

            int total = slc.Add(x, y);
            Console.WriteLine("Total = " + total.ToString());
        }
    }
}

