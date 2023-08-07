using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public class FuncDelegate1
    {
        public static int Multiply(int x)
        {
            return x;
        }
        static void Main(string[] args)
        {
            Func<int, int> multiply1 = Multiply;
           
           
        }
    }
}
