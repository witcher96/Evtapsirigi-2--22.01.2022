using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // 1) 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333= 73338
            int a = 1234;
            int b;
            if(a>999 && a < 10000)
            {
                b = ((7 * 10000) + a) * 10 + 8;
                Console.WriteLine($"Cavab:{b}");
            }
            else
            {
                Console.WriteLine("Verilen eded 4 reqemli deyil");
            
            
            
            //NOTE Flowchartlar ve Pseudocode ler 1,3 ve 9 tapsiriqlari ucun yazilib
            }
        }
    }
}
