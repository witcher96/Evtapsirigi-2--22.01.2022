using System;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap
            int a = 123405;
            int b = 654321;
            int c = 124365;
            int d;
            bool isSucceed = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000;

            if (isSucceed){
                a = a * 10 / 100;
                b = b * 10 / 100;
                c = c * 10 / 100;
                d = (a + b + c) * 10 / 100;
                Console.WriteLine($"Cavab: {d}");
            }
            else
            {
                Console.WriteLine("Verilen eded 6 reqemli deyil");
            }
        }
    }
}
