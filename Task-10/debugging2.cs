using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class SwapExample
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a number1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            b = a / b;
            a = a / b;
        Console.Write("After swap a= " + a + " b= " + b);
        }

    }
}
