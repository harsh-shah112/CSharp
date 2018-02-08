using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
       {
           

        List<Product> P = new List<Product>();

            P.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            P.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            P.Add(new Product("pumpkin", 30,30,"Marrow"));
            P.Add(new Product("cauliflower",10,25, "Cruciferous"));
            P.Add(new Product("zucchini",20.5,50,"Marrow"));
            P.Add(new Product("yam", 30, 50, "Root"));
            P.Add(new Product("spinach", 10, 100, "Leafy green"));
            P.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            P.Add(new Product("Garlic", 30, 20, "Leafy green"));
            P.Add(new Product("silverbeet", 10, 50, "Marrow"));

            Console.WriteLine("total number of product in the list =" + " " + P.Count);
            Console.WriteLine("");
            P.Add(new Product("Patato", 10, 50, "Root"));
            foreach (var Product in P)
            {
                Console.WriteLine("Product: {0},{1},{2},{3}", Product.Name, Product.Price, Product.Qauntity, Product.Type);
            }
            Console.WriteLine("");
            Console.WriteLine("total number of product in the list =" + " " + P.Count);
            Console.WriteLine("");

            var All = P.Where(n => n.Type == "Leafy green").ToList();
            foreach (Product xyz in All)
            { Console.WriteLine("All the products of which have the type Leafy green:" + xyz.Name + " " + xyz.Price + " " + xyz.Qauntity + " " + xyz.Type); }

            Console.WriteLine("");

            P.RemoveAt(8);
            foreach (var Product in P)
            {
                Console.WriteLine("Product: {0},{1},{2},{3}", Product.Name, Product.Price, Product.Qauntity, Product.Type);
            }
            Console.WriteLine("total number of product in the list after removal =" + " " + P.Count);
            Console.WriteLine("");

            var user = P.FirstOrDefault(n => n.Name == "cabbage");
            user.Qauntity = user.Qauntity + 50;
            Console.WriteLine("the final quantity of cabbage in the inventory:" + user.Qauntity);
            Console.WriteLine("");

            var t1 = P.FirstOrDefault(n => n.Name == "lettuce");
            var t2 = P.FirstOrDefault(n => n.Name == "zucchini");
            var t3 = P.FirstOrDefault(n=> n.Name == "broccoli");
            double total = t1.Price + t2.Price * 2 + t3.Price;
            Console.WriteLine("If user purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli the round figure that user need to pay =" + " " + total);
            
        }

        public class Product
        {
            private string name;
            private double price;
            private int quantity;
            private string type;

            public Product(string name, double price, int quantity, string type)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
                this.type = type;

            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }
            public int Qauntity
            {
                get { return quantity; }
                set { quantity = value; }
            }
            public string Type
            {
                get { return type; }
                set { type = value; }
            }
        }

    }







    /*


    int ctotal = 50+int.Parse(Quantity[1]);
    Console.WriteLine("If user add 50 cabbages in the inventory, print the final quantity of cabbage in the inventory =" + " "+ctotal);


    */
}



