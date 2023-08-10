using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{

    delegate int NumberChanger(int n);

    class TestDelegate
    {
        static int num = 1;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            nc1 += new NumberChanger(MultNum);
            //calling the methods using the delegate object
            nc1(25);
           
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}



