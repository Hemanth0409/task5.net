using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class DisplayGenericIndexer<T1>
    {
        private T1[] details = new T1[10];
 
        public T1 this[int index]
        {
            get
            {
                return details[index];
            }
            set
            {
                details[index] = value;
            }
        }
        
    }
    class GenericIndexer
    {
        public static void Display()
        {
            DisplayGenericIndexer<int> section = new DisplayGenericIndexer<int>();
            for (int i = 1; i <= 10; i++)
            {
                section[i] = i;
                if (section[i] <= 5)
                {
                    Console.WriteLine($"Section {section[i]}:primary class");
                }
                else
                {
                    Console.WriteLine($"Section {section[i]}:Higher secondary class");
                }
            }
        }
        public static void AgeVerification() { 
            DisplayGenericIndexer<int> ageVerification = new DisplayGenericIndexer<int>();
            ageVerification[0] = 12;
            ageVerification[1] = 16;
            ageVerification[2] = 21;
            for (int i = 0; i < ageVerification[i]; i++)
            {
                if (ageVerification[i] >= 18)
                {
                    Console.WriteLine("He/She is Elegible for Voting,Apply for driving licence ");
                }
                else
                {
                    Console.WriteLine("Byee!!,Meet u at the age of 18");
                }
            }
        }
        public static void PasswordVerification()
        {

        }
        static void Main(string[] args)
        {
            Display();
            //AgeVerification();
            Console.ReadLine();

        }
    }
}
