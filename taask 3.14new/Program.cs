using System;

namespace taask_3._14new
{
    // 4 dene eded daxil et.Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
    //6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
    //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
    //Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
    //Neticenin 60 % tap.Cavabin axirina 60 artir.
    //Neticeden 18% cix.
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 468289;
            int b = 746528;
            int c = 123685;
            int d = 4562825;
            int d1;
            int qaliq;
            double cem1 = 1;

            double cem = 0;

            bool isSuccess = (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000);


            if (isSuccess)
            {
                qaliq = a % 1000;
                a = (a - qaliq) / 1000;

                qaliq = b % 1000;
                b = (b - qaliq) / 1000;

                qaliq = (c - qaliq) / 1000;
                c = (c - qaliq) / 1000;



                int toplam = a + b + c;
                //Console.WriteLine(toplam);//1334


                while (d > 1000)
                {
                    qaliq = d % 10;
                    d = (d - qaliq) / 10;
                    cem = cem + qaliq;//17

                
                }

                cem = cem + toplam;
                Console.WriteLine(cem);

                if (d>1)
                {
                    qaliq = d % 10;
                    d = (d - qaliq) / 10;
                    cem1 = cem1 * qaliq;

                    qaliq = d % 10;
                    d = (d - qaliq) / 10;
                    cem1 = cem1 * qaliq;
                    qaliq = d % 10;
                    d = (d - qaliq) / 10;
                    cem1 = cem1 * qaliq;




                    Console.WriteLine(cem1);

                }
                cem1 = cem - cem1;
                
                cem1 = cem1 * 0.6;
                cem = cem1 /1.0;
                
                Console.WriteLine(cem);





            }
            
        }
    }
}
