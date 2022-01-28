using System;

namespace Task_15_Boss_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               15)* 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
              3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
              Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
              Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
              Sonra alinan cavabin ustune gel 6 reqemli ededi.
              Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
              Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
              Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
             */
            int a = 123;
            int b = 321;
            int c = 1234;
            int d = 4321;
            int e = 12345;
            int f = 54321;
            long g = 123456;
            long h;

            bool dogru = a >= 100 && a < 1000 && b >= 100 && b < 1000 && c >= 1000 && c < 10000 && d >= 1000 && d < 10000 && e >= 10000 && e < 100000 && f >= 10000 && f < 100000 && g >= 100000 && g < 1000000;
            if (dogru)
            {
                //STEP 1
                h = (a + b) + (c * d);
                //STEP 2
                h = (h * 10 + 7)+(e+f);
                //STEP 3
                h = h - ((a * b) * 10 + 1);
                //STEP 4
                h = h + g;
                //STEP 5
                h = h - (a + b + c + d);
                //STEP 6
                h=(((h*18/100)*3/100)*1/100);
                //STEP 7
                h = h + (e + f);
                Console.WriteLine($"Cavab: {h}");

            }
            else
            {
                Console.WriteLine("Verilenler dogru deyil");
            }
        }
    }
}
