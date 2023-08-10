using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    public class Dictonary
    {
        public static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int,string>();
            numberNames.Add(1, "One"); //adding key/value using the Add() method
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");

            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<int, string>(){
            {1,"London, Manchester, Birmingham"},
            {2,"Chicago, New York, Washington"},
            {3,"Mumbai, New Delhi, Pune"}
        };

            foreach (var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value:{1} ", kvp.Key, kvp.Value);
            }

        }
    }

}
