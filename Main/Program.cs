
using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool soru = true;

            double dolarDun = 14;
            double dolarBugun = 13;

            if (soru ==false)
            {

                Console.WriteLine("aga doru bildin adamsın");
            }
            else
            {
                Console.WriteLine("olm o kadar anlatıyoz. yine mi bilemedin");
            }

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("dolar artmış. bu devirde pc alınmaz");
            }
            else if (dolarDun> dolarBugun)
            {
                Console.WriteLine("aga dolar düşüo");

            }
            else
            {
                Console.WriteLine("ee noldu şimdi");
            }


            int bakiye = 1000;
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("bakiyeniz: " + bakiye);
                    Console.ReadLine();
                   break;


                case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

                    if (cekilecekTutar>bakiye)
                    {
                        Console.WriteLine("bakiyenizden fazla para çekemezsiniz");
                        Console.ReadLine();

                    }

                    else
                    {
                        Console.WriteLine("kalan bakiyeniz: " + (bakiye-cekilecekTutar));
                        Console.ReadLine();

                    }

                    break;

                case "3":

                    Console.WriteLine("yatırılacak tutarı giriniz");
                    int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());

                     Console.WriteLine("kalan bakiyeniz: " + (bakiye+yatirilacakTutar));
                     Console.ReadLine();


                    break;

                case "4":

                    Console.WriteLine("hesabınızdan çıkış yapılıyor");
                    Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("lütfen geçerli bir işlem giriniz");
                    Console.ReadLine();

                    break;
              
            }




        }
    }
}


