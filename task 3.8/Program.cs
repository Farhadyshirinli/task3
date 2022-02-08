using System;

namespace task_3._8
{
    internal class Program
    {
     //   Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap
        static void Main(string[] args)
        {
            int a = 468531;
            int qaliq;
                while (a>1000)
            {
                qaliq = (a % 1000);//531

                a=(a-qaliq)/1000;

                a = a % 10;

                int b=qaliq;

                b = b % 10;


                int c = a + b ;

                Console.WriteLine($"{a}+{b}={c}");

               
                return;
            }

        }
    }
}
