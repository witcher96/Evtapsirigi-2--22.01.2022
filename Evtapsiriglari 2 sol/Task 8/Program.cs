using System;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8) 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
                    I ededin 4%-ni tap.
                    Sonra II ededin 9% ni tap.
                    Sonra Cavalari toplayib 10 %ni tap.
             */

            double a = 1234;
            double b = 1234567;
            double c;
            
            if((a>999 && a<10000)&&(b>999999 && b < 10000000))
            {
                a = a * 4 / 100;
                b = b * 9 / 100;
                c = (a + b) * 10 / 100;
                Console.WriteLine($"Cavab {c}");
            }
            else
            {
                Console.WriteLine("Verilen ededler doğru deyil");
            }
        }
    }
}
