using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {          
            List<string> a = new List<string>()
            {"Tomato",
             "Potato",
             "ToMato",
             "Potato",
             "Red Tomato",
             "Tomato  Catchup",
             "Grapes",
             "grapes",
             "potato" };
            
            int c = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].Equals("tomato", StringComparison.OrdinalIgnoreCase))
                {
                    c++;
                }
                    
             }
            Console.WriteLine("count of tomato="+c);
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].Equals("Potato"))
                {
                    Console.WriteLine("index of Potato="+i);
                }
            }
        }
    }
}