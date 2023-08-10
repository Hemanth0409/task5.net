using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class BonusCalculation : EventArgs
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }

    }
    class BonusCalEvent
    {
        public event EventHandler<BonusCalculation> OnBonusCalculation;

        public void display(string name, double salary, double bonus)
        {
            if (OnBonusCalculation != null)
            {
                Console.Write("\n");
                Console.WriteLine($"Bonus amount:{bonus}");
                OnBonusCalculation(this, new BonusCalculation { Name = name, Salary = salary, Bonus = bonus });
            }
        }
    }
    class Cal
    {
        public static void Calculate(object bonus, BonusCalculation e)
        {
            Console.WriteLine($"Employee Name: {e.Name} and salary with bonus {e.Salary + e.Bonus}");
        }
    }
    class DisplayBonus
    {

        static void Main(string[] args)
        {
            var Emp = new BonusCalEvent();
            Emp.OnBonusCalculation += Cal.Calculate;
            Console.Write("No of Employees:");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter Your Name:");
                string n = Console.ReadLine();
                Console.WriteLine("Salary:");
                double s = Convert.ToDouble(Console.ReadLine());
                double bonus;
                if (s >= 20000)
                {
                    bonus = s * 10 / 100;
                }
                else if (s >= 50000)
                {
                    bonus = s * 15 / 100;
                }
                else
                {
                    bonus = s;
                }
                Emp.display(n, s, bonus);
            }
            Console.ReadKey();
        }
    }
}

