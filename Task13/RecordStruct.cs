using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    public record struct RecordStruct
    {
        public int id { get; init; }
        public string name { get; init; }
        public double salary { get; set; }
        public double Bonus { get; set; }
        public RecordStruct(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
                this.salary = salary;
        }
    }
    public class cal
    {
        public double CalBonus(RecordStruct record)
        {
            double bon = record.salary * 10/100;
            return bon;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name:");
            string x = Console.ReadLine();
            Console.WriteLine("Salary");
            double sal=Convert.ToDouble(Console.ReadLine());
            RecordStruct rec= new RecordStruct(id,x,sal);
            cal functi = new cal();

            RecordStruct recDetails= rec with { Bonus= functi.CalBonus(rec)  } ;
            Console.WriteLine(recDetails);
            Console.ReadKey();
        }
    }
}
