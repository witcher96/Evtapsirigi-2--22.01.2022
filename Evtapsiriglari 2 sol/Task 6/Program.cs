using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) 4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.

            double a = 1234;

            if (a > 999 && a < 10000)
            {
                a = a * 20 / 100;
                a = a * 10 / 100;
                a = a * a;

                Console.WriteLine($"Cavab:{a}");
            }
            else
            {
                Console.WriteLine("Verilen eded 4 reqemli deyil");
            }
        }
    }
}
