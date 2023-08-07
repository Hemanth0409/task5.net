using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    /// <summary>
    /// Event : 
    /// An event is a notification sent by an object to signal the ocurrence  of  an
    /// Events in .Net follow the observer design pattern .
    /// The class who raises  events is called publisher,and the class who receivers the notification is called subscriber.
    /// There can be multiple subscribers of a single event. 
    /// 
    /// += more than one reference
    /// </summary>

    //OrderEventArgs -Publisher
    class OrderEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Phone { get; set; }


    }
    class Order
    {
        public event EventHandler<OrderEventArgs> OnCreated;
        int count = 0;

        public void Create(string email, string phone, int amount)
        {
            if (OnCreated != null)
            {
                Console.WriteLine("Order Created:");
                Console.WriteLine($"Order id{++count} created with amt {amount}");
                OnCreated(this, new OrderEventArgs { Email = email, Phone = phone, });
            }
        }
    }
    class Email
    {
        public static void Send(object sender, OrderEventArgs e)

        {
            Console.WriteLine($"Sent an Email to {e.Email}");

        }
    }
    class SMS
    {
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Sent an Email to {e.Phone}");

        }
    }
    class ProgramEvent
    {
        static void Main(string[] args)
        {
            var Order = new Order();
            Order.OnCreated += Email.Send;
            Order.OnCreated += SMS.Send;

            int order;
            string mail;
            string phone;
            int amount;
            Console.WriteLine("Enter the no of Employees:");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter the Order Id:");
                order= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Mail :");
                mail = Console.ReadLine();
                Console.WriteLine("Enter a phone number");
                phone = Console.ReadLine();
                Console.WriteLine("Enter the amount :");
                amount = Convert.ToInt32(Console.ReadLine());

            }
        }

    }
}
