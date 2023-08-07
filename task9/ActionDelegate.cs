using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
  
    public class TodoList
    {
        List<string> todoMsg = new List<string>();
        public delegate void myAdd(string msg);

        public void  Add(string Msg)
        {
            todoMsg.Add(Msg);
            Console.WriteLine(Msg);
        }
        public void  Remove(string Msg)
        {
            todoMsg.Remove(Msg);
            Console.WriteLine("Removed");
        }
        public void Clear()
        {
            todoMsg.Clear();
        }

        static void Main(string[] args)
        {  
            TodoList t = new TodoList();
            Console.WriteLine("Enter the task:");
            string x= Console.ReadLine();

            Console.WriteLine("Enter 1/2");
            int a = Convert.ToInt32(Console.ReadLine());

            myAdd todoAdd = t.Add; 
            
           myAdd todoRemove = t.Remove;

            if (a == 1)
            {
                todoAdd(x);
            }
            else
            {
                todoRemove(x);
            }
            Console.ReadLine();
        }
    }
}
