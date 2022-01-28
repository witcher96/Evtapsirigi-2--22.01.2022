using System;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             12) 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
                Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.
             */
            int a = 123456;
            int b = 123546;
            int c = 543216;
            int d = 451236;
            int e;
            int f;
            bool isSucces = (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000);

            if (isSucces)
            {
                e=(a*10/100)+(b*10/100)+(c*10/100)+(d*10/100);
                f = (a * 15 / 100) + (b * 15 / 100) + (c * 15 / 100) + (d * 15 / 100);
                f = (e * f)*10/100;
                f = f * 11 / 100;
                Console.WriteLine($"Cavab: {f}");

            }
            else
            {
                Console.WriteLine("Verilen 6 reqemli deyil");
            }
        
        }
    }
}
