using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Program
    {
        public enum shapes
        {
            circle,
            rectangle,
            square
        }
        public static void areaCalculation(int number1, shapes structure,params object[] number2)
        {
            Console.WriteLine("Enum AreaCalculation:");
            if ((int) structure == 0) 
            {
                Console.WriteLine("Area of circle:"+3.14*number1*number1);
            }
           else if ((int) structure == 2)
            {
                Console.WriteLine("Area of square:" + number1 * number1);
            }
            else if ((int)structure == 1)
            {
                foreach (int i in number2)
                Console.WriteLine("Area of rectangle:"+ number1*i);
            }

        }
        public static void iteration(int number1, params object[] number2)
        {
            foreach (Enum shape in Enum.GetValues(typeof(shapes))) 
            {
                if (shape.ToString() == "circle")
                {
                    Console.WriteLine("Area of circle:" + 3.14 * number1 * number1);
                }
                else if (shape.ToString() == "rectangle")
                {
                    foreach (int i in number2)
                        Console.WriteLine("Area of rectangle:" + number1 * i);
                }
                else if(shape.ToString() =="square")
                {
                    Console.WriteLine("Area of square:" + number1 * number1);
                }
            }
        }
        static void Main(string[] args)
        {
            areaCalculation( 10,shapes.circle);
            areaCalculation(10,  shapes.square);
            areaCalculation(10, shapes.rectangle, 11);


            iteration(11,21);
            Console.ReadKey();
        }
    }
}
