using System;

namespace ConsoleApp3._2
{
    internal class Program
    {
        // verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3
        static void Main(string[] args)
        {
            int a = 465838;
            int qaliq;
            int qaliq1;

            int cem = 0;

            bool isSucces = (a >= 100000 && a < 1000000);

            if (isSucces)
            {
                
                    qaliq = a % 1000;//838
                    a = (a - qaliq) / 1000;
                    
                int b = a;

                // Console.WriteLine(a);
                while (b>0)
                {
                    qaliq1 = b % 10;//5
                    b= (b - qaliq1) / 10;
                    cem = cem + qaliq1;



                }
                Console.WriteLine(cem);




            }

            else
            {
                Console.WriteLine("6 reqemli deyil");
                return;

            }
        }
    }
}
