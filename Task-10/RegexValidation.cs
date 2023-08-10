using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_10
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base($"Invalid:{message}") { }
    }
    internal class PasswordException : Exception
    {
        public PasswordException(string message) : base($"Invalid password:{message}") { }
    }


    class RegexValidation : EventArgs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    class RegexEvent
    {
        public event EventHandler<RegexValidation> OnRegexEvent;
        public void Check(int id, string name, int salary, int age, string email, string password)
        {
            if (OnRegexEvent != null)
            {
                Console.Write("\n");
                Console.WriteLine($"After validation:the user {name}");
                OnRegexEvent(this, new RegexValidation { Id = id, Name = name, Salary = salary, Age = age, Email = email, Password = password });
            }
        }
    }
    class DisplayDetails
    {
        public static void Display(object info, RegexValidation e)
        {
            Console.WriteLine($"Id{e.Id},Name{e.Name},Email:{e.Email}Pass:{e.Password},Age:{e.Age}Salary{e.Salary}");
        }
    }
    class Validation
    {
        static void Main(string[] args)
        {
            

            var emp = new RegexEvent();
            emp.OnRegexEvent += DisplayDetails.Display;
            Regex idReg = new Regex("[0-9]$");
            Regex nameReg = new Regex("[a-zA-z_]+$");
            Regex salaryReg = new Regex("[0-9]+$");
            Regex emailReg = new Regex("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$");
            Regex password = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            try
            {
                Console.Write("Name:");
                string name1 = Console.ReadLine();
                Console.Write("id:");
                int id1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("age:");
                int age1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Salary:");
                int salary1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Email:");
                string email1 = Console.ReadLine();
                Console.WriteLine("PassWord:");
                string password1 = Console.ReadLine();
                if (!idReg.IsMatch(id1.ToString()))
                {
                    throw new FormatException(id1.ToString());
                }
                else if (!nameReg.IsMatch(name1))
                {
                    throw new InvalidNameException(name1);
                }
                else if (!salaryReg.IsMatch(salary1.ToString()))
                {
                    throw new FormatException(salary1.ToString());
                }
                else if (!emailReg.IsMatch(email1))
                {
                    throw new InvalidNameException(email1);
                }
                else if (!password.IsMatch(password1))
                {
                    throw new InvalidNameException(password1);
                }
                emp.Check(id1, name1, salary1, age1, email1, password1);
            }
            catch (InvalidNameException Name)
            {
                Console.WriteLine(Name.Message);
            }
            catch (FormatException IntFormate)
            {
                Console.WriteLine(IntFormate.Message);
            }
            
       
            Console.ReadKey();
        }
    }
}
