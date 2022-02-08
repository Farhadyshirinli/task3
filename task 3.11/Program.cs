using System;

namespace task_3._11
{
    internal class Program
    {
    //    8 reqemli ededin reqemlerini iki -iki qruplashdir.
    //Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
    //Sonra cavabin ozunden onun 18% ni cix;
        static void Main(string[] args)
        {
            int a = 16385457;
            int qaliq;
            int cem = 0;


            bool isSuccess = (a >= 10000000 && a < 100000000);

            if (isSuccess)
            {



                while (a > 0)
                {
                    qaliq = a % 100;//57

                    a = (a - qaliq) / 100;

                    cem = cem + qaliq;

                    
                   
                    
                    

                  
                  
                }
                
              
                cem = cem * 100 + 99;
                double yeniEded = cem * 0.18;

                double yeniEded1 = cem;

                yeniEded1 = cem - yeniEded;
                Console.WriteLine(yeniEded1);
            }
            else
            {
                Console.WriteLine("8 reqemli deyil");
            }
       
        }
    }
}
