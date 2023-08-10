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
            Console.WriteLine("Cleared");
        }

        static void Main(string[] args)
        {  
            TodoList t = new TodoList();
            Console.WriteLine("Enter the task:");
            string x= Console.ReadLine();

            Console.WriteLine("Enter 1 to add the task/2 to remove the task /3 to clear the task");
            int a = Convert.ToInt32(Console.ReadLine());

            Action<string> adding= t.Add;
            Action<string> removeing= t.Remove;
          Action clearing= t.Clear;

            if (a == 1)
            {
                adding(x);
            }
            else if(a==2)
            {
                removeing(x);
            }
            else
            {
                clearing();
            }
            Console.ReadLine();
        }
    }
}
