using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public delegate bool IsValid(customerList valid);
    public class customerList
    {
        public string Name;
        public double purchasedAmt;
        public string couponCode;

        public static void CouponValid(List<customerList> validCoupon, IsValid couponValid)
        {
            foreach (customerList valid in validCoupon)
            {
                if (couponValid(valid) && valid.couponCode == "Cg-123")
                {

                    Console.WriteLine("reduced amt:" + (valid.purchasedAmt - 500));
                }
                else if (valid.couponCode != "Cg-123" && couponValid(valid))
                {
                    Console.WriteLine($"Sry your purchased Amount is valid but coupon code {valid.couponCode} does not match the code ");
                }
                else
                {
                    Console.WriteLine($"Sry your purchased Amount rs{valid.purchasedAmt} is lesser than 2000 ");
                }
            }
        }
        public static bool validateCoupon(customerList valid)
        {
            if (valid.purchasedAmt >= 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter Your Name:");
          
            string a = Console.ReadLine();
            Console.Write("Purchased Amount:");
            int x = Convert.ToInt32(Console.ReadLine());
      
            Console.Write("Coupon Code:");
            string y = Console.ReadLine();
     
           ;
            List<customerList> custList = new List<customerList>();
            custList.Add(new customerList() { couponCode = y, purchasedAmt = x});


            IsValid validity = new IsValid(validateCoupon);
            customerList.CouponValid(custList, validity);
            Console.ReadKey();
        }
    }
}
