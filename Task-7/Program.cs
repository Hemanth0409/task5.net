using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a your Password:");
            //string x = Console.ReadLine();
            //var password = new List<string> { x };
            //password.ForEach(passCheck => Console.WriteLine(Regex.IsMatch(passCheck, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")));

            //Console.Write("Enter a your Telephone number:");
            //string y = Console.ReadLine();
            //var tel = new List<string> { y };
            //tel.ForEach(telCheck => Console.WriteLine(Regex.IsMatch(telCheck, "^\\d{3}-\\d{4}-\\d{3}")));

            Console.Write("Enter a your Telephone number:");
            long z = Convert.ToInt64(Console.ReadLine());
            var mobileNum = new List<long> { z };
            mobileNum.ForEach(numCheck => Console.WriteLine(Regex.IsMatch(numCheck.ToString(), "^[1-8]{10}")));
            Console.ReadKey();
        }
    }
}
