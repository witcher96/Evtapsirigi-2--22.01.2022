using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

            double a = 1234;

            if (a > 999&& a< 10000)
            {
                a = ((4 * 10000) + a)*100+44;
                a = (a * 7) / 100;

                Console.WriteLine($"Cavab:{a}");
            }
            else
            {
                Console.WriteLine("Verilen eded 4 reqemli deyil");
            }
        }
    }
}
