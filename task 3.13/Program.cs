using System;

namespace task_3._13
{
    internal class Program
    {
    //    3 dene 5 reqemli eded var.
    //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet.Alinan neticeleri topla
    //Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.
        static void Main(string[] args)
        {
           
            int a = 42865;
            int b = 14238;
            int c = 97522;

            double cem;
            double cem1;

            int a1;
            int b1;
            int c1;

            bool isSuccess = ((a >= 10000 && a < 100000) && (b >= 10000 && b < 100000) && (c >= 10000 && c < 100000));
            if ((isSuccess))
            {
                while (a > 0 && b > 0 && c > 0)
                {


                    a1 = (a - (a % 10000)) / 10000;
                    b1 = (b - (b % 10000)) / 10000;
                    c1 = (c - (c % 10000)) / 10000;

                    a = a % 10;
                    b = b % 10;
                    c = c % 10;

                    a1 = a1 * 10 + a;
                    b1 = b1 * 10 + b;
                    c1 = c1 * 10 + c;

                    cem = a1 + b1 + c1;
                    cem1 = cem * 0.5;

                    cem = cem + cem1;

                    Console.WriteLine(cem);

                    return;

                }
               


            }



               else
                {
                    Console.WriteLine("ededler 5 reqemli deyildir");
                }




            }

        }
    }

