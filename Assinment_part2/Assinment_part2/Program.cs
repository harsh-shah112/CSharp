using System;

namespace Assinment_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            float X = 0.06f;
            float Y = 5.94f;
            float sum = X + Y;
            Console.WriteLine("Sum of X AND Y ="+" "+sum);

            if(sum == 6)
            { Console.WriteLine("the summation of X & Y are equal to 6"); }
            else
            { Console.WriteLine("the summation of X & Y are not equal to 6"); }

            if(X>Y)
            { Console.WriteLine("Greater Value="+X); }
            else
            { Console.WriteLine("Greater Value="+Y); }
        }
    }
}