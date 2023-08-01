using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{

    public class product
    {
        public int id;
        public string product_name;
        public int price;
        public string type;
        public int stocks;
    }
        public class Product_insertion
        {
            public static void Main(string[] args)
            {

                List<product> products = new List<product>();
                products.Add(new product()
                {
                    id = 1,
                    product_name = "Lays",
                    price = 5,
                    type = "Snacks",
                    stocks = 5
                });
                products.Add(new product()
                {
                    id = 2,
                    product_name = "Diary Milk",
                    price = 10,
                    type = "Chocolate",
                    stocks = 10
                });
                products.Add(new product()
                {
                    id = 3,
                    product_name = "Peanut Bar",
                    price = 5,
                    type = "Snacks",
                    stocks = 15
                });

                var Iteration = products.Select(p => new { p.id, p.product_name, p.price, p.type, p.stocks }).OrderByDescending(p => p.product_name);
                foreach (var item in Iteration)

                {
                    Console.WriteLine(item);
                    Console.WriteLine(item.product_name[0]);
                }
            }
        }
    }
