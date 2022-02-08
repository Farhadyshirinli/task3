using System;

namespace task_3._7
{
    internal class Program
    {
        //7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir

        static void Main(string[] args)
        {
            int a = 4628;

            int qaliq;

            int saygac = a % 2;

            int yenieded;
            if (a>=1000&&a<10000)
            {
                while (a>0)
                {
                    qaliq = a%10;//8

                    
                    a = (a - qaliq) / 10;//462

                   //qaliq = qaliq * 1000 + a;

                   yenieded = qaliq*1000+qaliq;

                    


                    Console.WriteLine(yenieded);







                }




            }



            
        }
    }
}
