using System;

namespace task_3._4
{
    //verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 46289;
            int qaliq;
            int a1;
            int toplam;

            if (a>=10000&&a<100000)
            {
                qaliq = a % 10;//9
                a1 = a % 10000;//6289
                a = (a - a1) / 10000;
                
                toplam=(a+qaliq)*(a+qaliq);
                Console.WriteLine(toplam);

            }

            else
            {
                Console.WriteLine("5reqemli deyil");
            }
        }
    }
}
