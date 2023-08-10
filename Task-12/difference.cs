using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    public class MyClass
    {
        public readonly int readonlyvar1 = 10, readonlyvar2;
        public const int constvar = 20;
        public static int staticvar = 0;
        public MyClass(int i)
        {
            readonlyvar2 = i; // valid
                              //z = i; //compile-time error
            staticvar = i; // valid
        }

        public void ChangeVal(int val)
        {
            //x = val;
            //z = i; //compile-time error
            staticvar = val; // valid
        }

        public void Display()
        {
            Console.WriteLine(staticvar);
            Console.WriteLine(readonlyvar1);
            Console.WriteLine(constvar);
        }
    }
    internal class difference
    {
        public static void Main()
        {
            MyClass mc = new MyClass(50);
            mc.ChangeVal(45);
            mc.Display();

            Console.WriteLine("MyClass.constvar = {0}", MyClass.constvar);
            Console.WriteLine("MyClass.staticvar = {0}", MyClass.staticvar);
        }
    }
}
