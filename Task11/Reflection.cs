using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class AttributeDemo1 : Attribute
    {
        private string name;
        private string city;

        public AttributeDemo1(string name, string city)
        {
         
         
        }
        public static void Display(Type classType)
        {
            Console.WriteLine("All the methods inside the class {0} are ", classType.Name);
            MethodInfo[] methods = classType.GetMethods();
            for (int i = 0; i < methods.GetLength(0); i++)
            {
                object[] attrarray = methods[i].GetCustomAttributes(true);
                foreach (Attribute item in attrarray)
                {
                    if (item is AttributeDemo1)
                    {
                        AttributeDemo1 attrobj = (AttributeDemo1)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name, attrobj.name, attrobj.city);
                    }
                }
            }
        }
    }
    class Trainer
    {
        int id;
        string name;


        public Trainer(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        [AttributeDemo1("Method", "Activate")]
        public int getID()
        {
            return id;
        }
    }

    internal class Reflection
    {
        static void Main(string[] args)
        {
            int a = 10;
            string name = "Jackie";
            char c = 'D';
            double d = 12378389232;
            float f = 13.06F;
            bool s = false;
            int[] arr = { 10, 20, 30, 40 };
            Type type1 = a.GetType();
            Type type2 = name.GetType();
            Type type3 = c.GetType();
            Type type4 = d.GetType();
            Type type5 = f.GetType();
            Type type6 = s.GetType();
            Type type7 = arr.GetType();
            Console.WriteLine($"Type of {a} : " + type1.FullName);
            Console.WriteLine($"Type of {name} : " + type2.FullName);
            Console.WriteLine($"Type of {c} : " + type3.FullName);
            Console.WriteLine($"Type of {d} : " + type4.FullName);
            Console.WriteLine($"Type of {f} : " + type5.FullName);
            Console.WriteLine($"Type of {s} : " + type6.FullName);
            Console.WriteLine($"Type of {arr} : " + type7.FullName);
            Console.WriteLine("****************");
            Console.WriteLine("Math Class methods");
            Console.WriteLine("--------------");
            Console.WriteLine("All the methods inside the Math class are ");
            Type tp = typeof(Math);
            MethodInfo[] mathmethods = tp.GetMethods();
            List<string> names = new List<string>();
            foreach (MethodInfo mi in mathmethods)
            {
                if (!names.Contains(mi.Name))
                {
                    names.Add(mi.Name);
                    Console.WriteLine( "Math func : {0}", mi.Name);
                }
            }

            Console.WriteLine("Current Class methods");

            AttributeDemo1.Display(typeof(Trainer));

            Console.ReadLine();
        }
    }
}