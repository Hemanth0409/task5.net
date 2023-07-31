using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5;

namespace task5
{

    public abstract class details
    {
        public abstract string Name { get; set; }
        public abstract double Salary { get; set; }
        protected double salary;
        protected double tax;
        protected string name;
        public abstract void calculateTax();


    }
    public class taxPercentage1 : details
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public override void calculateTax()
        {

            tax = 15 * salary / 100;
            Console.WriteLine($"Tax:{tax}"); 
        }
    }
    public class taxPercentage2 : details
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public override void calculateTax()
        {

            tax = 16 * salary / 100;
            Console.WriteLine($"Tax:{tax}");
        }
    }
    public class taxPercentage3 : details
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public override void calculateTax()
        {

             
            Console.WriteLine($"Tax:No tax ");
        }
    }

    public class TaxCalculation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name1=Console.ReadLine();
            Console.Write("Salary:");
            double salary1=Convert.ToDouble(Console.ReadLine());
            if (salary1 > 10000)
            {
                taxPercentage1 tax = new taxPercentage1();
                tax.Name = name1;
                tax.Salary = salary1;
                tax.calculateTax();
            }
            else if (salary1 > 20000)
            {
                taxPercentage2 tax = new taxPercentage2();
                tax.Name = name1;
                tax.Salary = salary1;
                tax.calculateTax();
            }
            else
            {
                taxPercentage3 tax = new taxPercentage3();
                tax.Name = name1;
                tax.Salary = salary1;
                tax.calculateTax();
            }
            Console.ReadLine();

        }
    }
}

