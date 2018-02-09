using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Primeministers = new Dictionary<string,PrimeMinister>
            {
                {"a", new PrimeMinister("Atal bihari vajpayee",1998) },
                {"b", new PrimeMinister("Narendra Modi",2014) },
                {"c", new PrimeMinister("Manmohan Singh",2004) }

            };

           Console.WriteLine("Prime Minister in 2004:");
           foreach (var p in Primeministers.Values)
           {
               if (p.YearElected == 2004)
               {
                   Console.WriteLine(p);
               }
            }

           Console.WriteLine(" ");
           Primeministers.Add("d",new PrimeMinister("narendra modi",2014));

            foreach (var pm in Primeministers)
            { Console.WriteLine(pm.Value); }

            Console.WriteLine(" ");
            Console.WriteLine("ReadOnly");
            var pmsReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(Primeministers);
            foreach (var pm in pmsReadOnly)
            { Console.WriteLine(pm.Value); }
           
             Console.WriteLine(" ");
              Console.WriteLine("\nSorted:-");
           Primeministers = Primeministers.OrderBy(r => r.Value.YearElected).ToDictionary(r => r.Key, r => r.Value);
            foreach (var px in Primeministers.Values)
            {
                Console.WriteLine(px); }
             Console.ReadKey();
          }  
         
 
    }


    public class PrimeMinister
    {
        public string Name { get; private set; }
        public int YearElected { get; private set; }
           
        public PrimeMinister(string name, int yearElected)
        {
            this.Name = name;
            this.YearElected = yearElected;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}", Name, YearElected);
        }

    }
}
