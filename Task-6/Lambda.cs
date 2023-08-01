using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Lambda
    {

        static void Main(string[] args)
        {
            var simpleInterest = (double p, double r, int n) =>
          {
              Console.WriteLine("Simple interest:"+ p * n * r / 100);
          };
            Console.Write("Enter your Name:");
            string a = Console.ReadLine();
            Console.Write("Salary:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("No of Year:");
            int y = Convert.ToInt32(Console.ReadLine());
            double z = 9;

            simpleInterest(x, z, y);
            Console.ReadKey();
        }
    }
}
