using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4) 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
            double a = 123;
            if(a>99 && a < 1000)
            {
                a = (a * 10 + 7) * 7 / 100;
                Console.WriteLine($"Cavab: {a}");
            }
            else
            {
                Console.WriteLine("Verilen eded 3 reqemli deyil");
            }
        }
    }
}
