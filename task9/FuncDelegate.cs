using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public class FuncDelegate1
    {
        public static int Multiply(int x,int y)
        {
            return x*y;
        }
        static void Main(string[] args)
        {
            int result;
            Func<int, int,int > multiply1 = Multiply;
           Console.WriteLine("Enter a number:");

int x=Convert.ToInt32(Console.ReadLine());
            for(int y=1; y<=10; y++)
            {
                result = multiply1(x,y);
                Console.WriteLine($"{x}*{y}={result}");
            }
        }
    }
}
