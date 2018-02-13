using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {      
            List<Product> P = new List<Product>();

            P.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            P.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            P.Add(new Product("pumpkin", 30, 30, "Marrow"));
            P.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            P.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            P.Add(new Product("yam", 30, 50, "Root"));
            P.Add(new Product("spinach", 10, 100, "Leafy green"));
            P.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            P.Add(new Product("Garlic", 30, 20, "Leafy green"));
            P.Add(new Product("silverbeet", 10, 50, "Marrow"));

            int input;
            double totalp = 0;
            double average = 0;
            Console.WriteLine("(1)Type of products based on list");
            Console.WriteLine("(2)Total prize of whole Inventory including the quantities of products");
            Console.WriteLine("(3)Average prize of product");
            Console.WriteLine("(4)Costly products and cheap product list");
            Console.WriteLine("Press 0 for exit");           
      do
          {   Console.WriteLine("please enter valid input");
                 input = int.Parse(Console.ReadLine());

           switch (input)
            {     case 1:

                        Console.Write("Press 1 for Leafy green     ");
                        Console.WriteLine("Press 2 for Cruciferous");
                        Console.Write("Press 3 for Marrow        ");
                        Console.WriteLine("Press 4 forRoot");
                        Console.Write("Please enter number=");
                        int type = int.Parse(Console.ReadLine());

                   switch (type)
                        {
                            case 1:

                                foreach (var Product in P)
                                { if (Product.Type.Equals("Leafy green"))
                                    {
                                        Console.WriteLine("Product: {0},{1},{2},{3}", Product.Name, Product.Price, Product.Qauntity, Product.Type);
                                    }
                                }
                                break;
                            case 2:

                                foreach (var Product in P)
                                { if (Product.Type.Equals("Cruciferous"))
                                    {
                                        Console.WriteLine("Product: {0},{1},{2},{3}", Product.Name, Product.Price, Product.Qauntity, Product.Type);
                                    }
                                }
                                break;
                            case 3:

                                foreach (var Product in P)
                                {if (Product.Type.Equals("Marrow"))
                                    {
                                        Console.WriteLine("Product: {0},{1},{2},{3}", Product.Name, Product.Price, Product.Qauntity, Product.Type);
                                    }
                                }
                                break;
                            case 4:

                                foreach (var Product in P)
                                {if (Product.Type.Equals("Root"))
                                    {
                                        Console.WriteLine("Product: {0},{1},{2},{3}", Product.Name, Product.Price, Product.Qauntity, Product.Type);
                                    }
                                }
                                break;                           
                        }
                        break;
                    case 2:

                        foreach (var Product in P)
                        {
                            totalp = totalp + (Product.Qauntity * Product.Price);
                        }
                        Console.WriteLine("Total price of whole Inventory including the quantities of products="+totalp);
                        break;

                    case 3:

                        average = totalp / P.Count;
                        Console.WriteLine("Average price of product="+average);
                        break;

                    case 4:
                        foreach (var Product in P)
                        {
                            if (Product.Price > 50)
                            { Console.WriteLine("List of costly products={0},{1},{2},{3}", Product.Name, Product.Price, Product.Qauntity, Product.Type); }
                            else
                            { Console.WriteLine("List of cheap products: {0},{1},{2},{3}", Product.Name, Product.Price, Product.Qauntity, Product.Type); }


                           }                    
                       
                        break;

                    default:

                        Console.WriteLine("Your choice is invalid please try again");
                        break;
                }
            }
     while (input != 0);
        }

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