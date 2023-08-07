using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    /// <summary>
    /// Degate -reference type holds the ref of a method -runtime
    /// delegate can be used to hold the reference of the method
    /// common set of value pass to any method is known as delegate
    ///  multicast Delegate(+= add the delegate )(-= remove the delegate)
    /// = single cast
    /// we can also pass delegate as a parameter
    /// 
    /// 
    /// 2 method in delegate -function delegate and action delegate 
    /// 
    /// func delegate is a generic delegate included in the system namespace
    /// function delegate takes one parameter as input and one parameter as the output paramaeter
    /// to return a set of value 
    /// 
    /// 
    /// </summary>

    public delegate void Delegate1(int id, string name);
    internal class Delegates1
    {
        public void TraineeDetails(int tid,string tname) {
            Console.WriteLine($"{tname}{tid}");
                }
        public void pro(int tid, string tname)
        {
            Console.WriteLine($"{tname}{tid}bro");
        }
        static void Main(string[] args)
        {
            Delegates1 instance1 = new Delegates1();
            instance1.TraineeDetails(100, "hemanth");
            Delegate1 delegateInstance = instance1.TraineeDetails;
            delegateInstance += instance1.pro;
            delegateInstance(2000, "darshan");
            Console.ReadKey();
        }
    }
  

  
}
