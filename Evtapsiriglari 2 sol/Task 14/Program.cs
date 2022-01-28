using System;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             14) 6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.
                I neticeden II neticeni cix. Alinan cavabin 10% tap. Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap.
             */
            long a = 123456;
            long b = 123465;
            long c = 123645;
            long d = 126345;
            long e = 162345;
            long f = 612345;
            long g;
            long h;

            bool isSuccess = (a>=100000 && a<1000000 && b>=100000 && b< 1000000 && c>= 100000 && c< 1000000 && d>= 100000 && d< 1000000 && e>= 100000 && e< 1000000 && f>= 100000 && f< 1000000);
            if (isSuccess)
            {
                g = a + b + c + d + e + f;
                h = (a * 1000000) + c;
                a = a - b;
                a = a * 10 / 100;
                a = a + e + f;
                a = a * 11 / 100;
                
                Console.WriteLine($"Cavab: {a}");
            }
            else
            {
                Console.WriteLine("Verilen 6 reqemli deyil");
            }




        }
    }
}
