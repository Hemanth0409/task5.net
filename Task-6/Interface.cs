using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{

    interface IArea1
    {

        public void area(int x);

    }
    public interface IArea2
    {
        public void area(int x);
    }

    class Area : IArea1, IArea2
    {
        void IArea1.area(int x)
        {

            Console.WriteLine("Area of circle :" + 3.14 * x * x);
        }
        void IArea2.area(int x)
        {

            Console.WriteLine("Area of Square :" + x * x);


        }
    }
    internal class Interface
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the a number to find the area :");
            int n = Convert.ToInt32(Console.ReadLine());

            IArea1 area = new Area();
            area.area(n);
            IArea2 area1 = new Area();
            area1.area(n);

            Console.ReadKey();
        }
    }
}
