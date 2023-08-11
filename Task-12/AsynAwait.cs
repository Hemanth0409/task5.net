using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class AsynAwait
    {

        static int sum;
        static int mul = 1;
        static async Task<int> MethodSum(int n)
        {
            await Task.Delay(1000);

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.Write($"Sum of {n}:");
            return sum;
        }
        static async Task<int> MethodMultiply(int z)
        {
            await Task.Delay(2000);

            for (int j = 1; j <= z; j++)
            {
                mul *= j;
            }
            Console.Write($"Product of {z}:");
            return mul;
        }
        static async Task Main(string[] args)
        {
            Console.Write("Number :");
            int x = Convert.ToInt32(Console.ReadLine());
            int s = await MethodSum(x);
            int p = await MethodMultiply(x);
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
