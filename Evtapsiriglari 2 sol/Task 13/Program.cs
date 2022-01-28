using System;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             13) 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
            Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.
             */

            int a = 12345;
            int b = 54321;
            int c = 12346;
            int d = 123;
            int e = 321;
            int f;
            bool isSucces=a>=10000 && a<100000 && b>=10000 && b<100000 && c>=10000 && c<100000 && d>=100 && d<1000 && e>=100 && e<1000;

            if (isSucces)
            {
                a = a * 5 / 100;
                b = b * 5 / 100;
                c = c * 5 / 100;
                ////////////////
                d = d * 3 / 100;
                e = e * 3 / 100;
                ////////////////
                c = a * b * c;
                c = c * 10 / 100;
                ////////////////
                e = d + e;
                e= e * 10 / 100;
                ////////////////
                f = e + c;

                Console.WriteLine($"Cavab: {f}");

            }
            else
            {
                Console.WriteLine("Verilenler dogru deyil");
            }
        }
    }
}
