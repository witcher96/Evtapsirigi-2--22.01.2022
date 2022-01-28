using System;

namespace Evtapsiriglari_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 7;
            int c = 8;

            if (a > 999 && a < 10000)
            {
                a = (b * 10000) + a;
                c = a * 10 + c;

                Console.WriteLine($"Cavab: {c}");
            }
            else
            {
                Console.WriteLine("Verilen eded 4 reqemli deyil");
            }
        }
    }
}
