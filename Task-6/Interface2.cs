using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    interface ICircle
    {
        double radius { get; set; }

        void Area(double radius);
    }
    interface IRectangle
    {
        double width { get; set; }
        double length { get; set; }
        void Area(double width, double length);
    }

    public class Area1 : ICircle, IRectangle
    {
        public double radius { get; set; }

        void ICircle.Area(double radius)
        {
            Console.WriteLine("Area of Circle:" + 22 / 7 * radius * radius);
        }
        public double width { get; set; }
        public double length { get; set; }
        void IRectangle.Area(double width, double length)
        {
            Console.WriteLine("Area of Circle:" + width * length);
        }
    }
    internal class Interface2
    {
        static void Main(string[] args)
        {
            Console.Write("Radius :");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.Write("width :");
            int wid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length :");
            int len = Convert.ToInt32(Console.ReadLine());

           ICircle circle = new Area1();
            circle.Area(rad);
            IRectangle rect = new Area1();
            rect.Area(wid, len);
        }

    }
}
