using System;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap
            int a = 12345;
            int b = 54321;
            double c;

            if ((a > 9999 && a<100000) &&(b >999 && b < 100000))
            {
                c = (a + b) + (100000 * 5);
                c = (c * 10 + 5)*5/100;

                Console.WriteLine($"Cavab: {c}");
            }
            else
            {
                Console.WriteLine("Verilen eded 5 reqemli deyil");
            }
            {

            }
        }
    }
}
