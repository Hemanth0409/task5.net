using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public double salary;

        // public  void  Details()
        public virtual void  Details()
        {
            Console.WriteLine("Salary: " + salary);

        }
    }
    internal class HR : Employee
    {
        public double Bonus;

        //public override void Details()
        public new void Details()
        {
            Console.WriteLine("Salary: " + salary + "Bonus: " + Bonus);
        }

        internal class main_class
        {
            static void Main(string[] args)
            {
                HR employee = new HR() { salary = 45000, Bonus = 3000 };
                Employee employee1 = employee;

                employee1.Details();

                employee.Details();
                Console.ReadKey();

            }
        }
    }

}
