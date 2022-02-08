using System;

namespace task3._1
{
    internal class Program
    {
        //verilmish 4 reqemli ededin reqemlerinin cemini tap
        static void Main(string[] args)
        {
            int a = 4682;
            int qaliq;
            int cem = 0;
            bool isSuccess = (a >= 1000 && a < 10000);

;            if (isSuccess)
            {

                while (a>0)
                {
                    qaliq = a % 10;//2

                    a = (a - qaliq) / 10;//468

                    cem = cem + qaliq;

                   

                }

                Console.WriteLine(cem);

            }
            else
            {
                Console.WriteLine("eded 4reqemli deyildir");

            }
        }
    }
}
