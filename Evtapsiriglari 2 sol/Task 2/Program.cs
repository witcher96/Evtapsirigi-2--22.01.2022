using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2) 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;

            int a = 987;


            if (a>99 && a < 1000)
            {
                a = (a*1000000)+((a * 1000) + a);
                Console.WriteLine($"Cavab: {a}");
            }
            else
            {
                Console.WriteLine("Verilen eded 3 reqemli deyil");
            }
        }
    }
}
