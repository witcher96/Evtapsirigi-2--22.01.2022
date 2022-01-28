using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.
            double a = 12345;
            double percent;
            double percent1;

            if(a >9999 & a < 100000)
            {
                percent = ((a * 18) / 100);
                Console.WriteLine($"Cavab: {percent}");
                percent1 = a * 3 / 100;
                Console.WriteLine($"Cavab: {percent1}");

            }
            else
            {
                Console.WriteLine("Verilen eded 5 reqemli deyil");
            }
        }
    }
}
