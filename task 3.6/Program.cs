using System;

namespace task_4._6
{
    internal class Program
    {
        //6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
        static void Main(string[] args)
        {
            int a = 78921425;
            bool Issucces = (a >= 10000000 && a < 100000000);
            int qaliq;
            int b;




            if (!(Issucces))
            {
                while (a>1000000)
                {


                    qaliq = a % 10;
                    b = (a % 10000000 - qaliq) / 10;


                    Console.WriteLine($"{b}");
                    
                }

               Console.WriteLine("8 reqemli deyil");
                return;

            }


        }
    }
}
