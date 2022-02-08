using System;

namespace task_3._3
{
    internal class Program
    {
        //3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi

        static void Main(string[] args)
        {
            int a = 164279326;
            int qaliq;

            if (a>=100000000&&a<1000000000)
            {
                qaliq = a % 1000;
                a = (a - qaliq) / 1000; //164279
                int cem = 0;


                int b = a;

                while (b > 1000)
                {

                    int qaliq1;



                    qaliq1 = b % 10;
                    b = (b - qaliq1) / 10;
                    cem = cem + qaliq1;//2+7+9=18

                }
                Console.WriteLine(cem);



            }
            else
            {
                Console.WriteLine("eded 9reqemli deyil");
            }



        }
    }
}
