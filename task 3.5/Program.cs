using System;

namespace task_3._5
{
    internal class Program
    {
        //5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
        static void Main(string[] args)
        {
            int a = 532476;
            int b;


            int qaliq;

            if (a>=100000&&a<1000000)
            {

                qaliq = a % 100000;
                 b = (a - qaliq) / 100000;

                qaliq = qaliq * 10 + b;

               

                Console.WriteLine(qaliq);
            }
        }
    }
}
