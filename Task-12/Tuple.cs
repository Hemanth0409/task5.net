using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Tuple
    {
        //static List <int> cg = new List<int>() ;
        static Hashtable cg = new Hashtable();
        static Hashtable g2 = new Hashtable();

        public static void Company(Tuple<int, string, string> tup)
        {
            if (tup.Item3.ToLower() == "cg-vak")
            {
                cg.Add(tup.Item1, tup.Item2);

            }
            else if (tup.Item3.ToLower() == "g2")
            {
                g2.Add(tup.Item1, tup.Item2);

            }
            else
            {
                Console.WriteLine("Sry");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("No of employees:");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Emp_id");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Emp_Name:");
                string z = Console.ReadLine();
                Console.WriteLine("Company:");
                string c = Console.ReadLine();
                var tup = new Tuple<int, string, string>(y, z, c);
                Company(tup);
                //Console.WriteLine($"Employee:{tup.Item1}-{tup.Item2}");/

            }
            Console.WriteLine("\n");
            Console.WriteLine("CG employee");
            foreach (DictionaryEntry val in cg)
            {

                Console.WriteLine($"Id:{val.Key},Name:{val.Value}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("G2 employee");
            foreach (DictionaryEntry val1 in g2)
            {

                Console.WriteLine($"Id:{val1.Key},Name:{val1.Value}");
            }
            Console.ReadKey();
        }
    }
}
