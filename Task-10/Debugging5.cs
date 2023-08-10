using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    public class DivNumbers
    {

        public void division(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Exception caught: {e}");
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;
            DivNumbers d = new DivNumbers();
            d.division(x, y);
            Console.ReadKey();
        }
    }

}
