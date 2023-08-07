using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_7
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base($"Invalid Name :{message} (only alphabets)") { }
    }
    internal class InvalidAvgScoreException : Exception
    {
        public InvalidAvgScoreException(string message) : base($"Invalid Score :{message} (Average must be greater or equal to than 70)") { }
    }
    public class Trainee
    {
        public string Name;
        public double CSharpScore;
        public double UIScore;
        public double AverageScore;
        public int TotalScore;
    }
    internal class CustomException
    {
        static void Main(string[] args)
        {
            Trainee traineeDetails;
            traineeDetails = new Trainee();
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Csharp Score:");
            int csharp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ui score:");
            int ui = Convert.ToInt32(Console.ReadLine());
            try
            {
              
                traineeDetails.Name = name;
                traineeDetails.CSharpScore = csharp;
                traineeDetails.UIScore = ui;
                traineeDetails.TotalScore = 100;
                traineeDetails.AverageScore = (traineeDetails.CSharpScore + traineeDetails.UIScore) / 2;
                Validation(traineeDetails);
                Console.WriteLine("Trainee Info:");
                Console.WriteLine($"Trainee {traineeDetails.Name}'s Average is {traineeDetails.AverageScore}/{traineeDetails.TotalScore}");

            }
            catch (InvalidNameException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                traineeDetails.Name = name;
                traineeDetails.CSharpScore = csharp;
                traineeDetails.UIScore = ui;
                traineeDetails.TotalScore = 100;
                traineeDetails.AverageScore = (traineeDetails.CSharpScore + traineeDetails.UIScore) / 2;
                Validation(traineeDetails);
                Console.WriteLine("Trainee Info:");
                Console.WriteLine($"Trainee {traineeDetails.Name}'s Average is {traineeDetails.AverageScore}/{traineeDetails.TotalScore}");
            }
            catch (InvalidAvgScoreException e1)
            {
                Console.WriteLine(e1.Message);
            }
            Console.ReadLine();
        }
        public static void Validation(Trainee trainee)
        {

            Regex regex = new Regex("^[A-Za-z_]+$");
            if (!regex.IsMatch(trainee.Name))
            {
                throw new InvalidNameException(trainee.Name);
            }

            if (trainee.AverageScore < 70)
            {
                throw new InvalidAvgScoreException(trainee.AverageScore.ToString());
            }
        }
    }
}

