using System;

namespace task_3._12
{
    internal class Program
    {
    //    2 dene 5 reqemli eded daxil et.
    //I ededin reqemleri ceminin usutne
    //II ededin reqemleri hasilini gel.
    //Neticenin axirina I ededin en axiinci reqemini artir.
        static void Main(string[] args)
        {
            int a = 32564;
            int b = 15248;
            int qaliq;
            int qaliq1;
            int cem = 0;

            int cem1 = 1;
            

            if (a>=10000&&a<100000 && b >= 10000 && b < 100000)
            {
                
                while (a>0&&b>0)
                {

                    qaliq = a % 10;//4
                    a = (a - qaliq) / 10;//3256

                    cem = cem + qaliq;

                    qaliq1 = b % 10;//5

                    b = (b - qaliq1) / 10;  

                    cem1= cem1 * qaliq1;


                   

                    
                }
                int toplam = (cem + cem1)*10+4;
                Console.WriteLine($"{toplam} ");
            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }

        }
    }
}
