using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{

    public class BonusCalculation
    {
        public int Id;
        public string Name;
        public double salary;
        public double bonus;

        public BonusCalculation(int id, string name, double salary, double bonus)
        {
            this.Id = id;
            this.Name = name;
            this.salary = salary;
            this.bonus = bonus;
        }

        static void DisplayContent(double salary, string name, int id, double bonus)
        {
            BonusCalculation[] bon =
            {
            new BonusCalculation(id, name, salary,bonus )
        };
            String file = @"D:\Basic\angular Files Demo\BonusCalculation.csv";
            String seperator = ",";
            StringBuilder sb = new StringBuilder();
            //String[] heading = { "ID", "Name", "Salary", "Bonus" };
            //sb.AppendLine(string.Join(seperator, heading));
            foreach (BonusCalculation cal in bon)
            {
                string newLine = string.Format($"{cal.Id},{cal.Name},{cal.salary},{cal.bonus}");

                sb.AppendLine(string.Join(seperator, newLine));

            }
            try
            {
                File.AppendAllText(file, sb.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.Write("\n");
            Console.WriteLine("Stored Successfully");
        }
        public static void CsvReader()
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false
            };

            using var streamReader = File.OpenText(@"D:\Basic\angular Files Demo\BonusCalculation.csv");
            using var csvReader = new CsvReader(streamReader, csvConfig);

            string value;

            while (csvReader.Read())
            {
                for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
                {
                    Console.Write($"{value,-10}");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
           // Console.Write("Enter number of Employees:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < x; i++)
            //{
            //    Console.Write("Id:");
            //    int id = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Name:");
            //    string name = Console.ReadLine();
            //    Console.Write("Salary");
            //    double salary = Convert.ToDouble(Console.ReadLine());
            //    double bonus;
            //    if (salary > 20000)
            //    {
            //        bonus = salary + salary * 10 / 100;
            //        Console.Write("Bonus:" + bonus);


            //    }
            //    else if (salary > 5000)
            //    {
            //        bonus = salary + salary * 15 / 100;
            //        Console.Write("Bonus:" + bonus);
            //    }
            //    else
            //    {
            //        bonus = salary + salary;
            //        Console.Write("Bonus:" + bonus);
            //    };
            //    DisplayContent(salary, name, id, bonus);
            //}
            CsvReader();
            Console.ReadLine();
        }
    }
}