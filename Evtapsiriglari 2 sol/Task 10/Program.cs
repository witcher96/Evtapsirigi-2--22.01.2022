using System;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             10) 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
                    Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel
             */

            double a = 1234;
            double b = 4321;
            double c = 1254;
            double d;
            double e;
            bool isSucces = a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000;
            
            
            if (isSucces)
            {
                a = a * 1 / 100;
                b = b * 2 / 100;
                c = c * 3 / 100;
                d = a - b - c;
                e = c * 7 / 100;
                d = d + e;
                Console.WriteLine($"Cavab: {d}");
            }
            else
            {
                Console.WriteLine("Verilen 4 reqemli deyil");
            }
        }
    }
}
