using System;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             11) 4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel.
                Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix.

             */

            int a = 12345;
            int b = 12354;
            int c = 54321;
            int d = 45123;
            int e;
            bool isSucces = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d>=10000 && d<100000;

            if (isSucces)
            {
                a = a + c;
                b = b + d;
                e = c * 3 / 100;
                a = a * b-e;
                Console.WriteLine($"Cavab: {a}");
            }
            else
            {
                Console.WriteLine("Verilen eded 5 reqemli deyil");
            }

        }
    }
}
