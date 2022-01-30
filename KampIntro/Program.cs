using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //type safety - tip güvenliği
            //Do not repeat your self - Kendini tekrarkama
            //"KategoriEtiketi" değer tutucu, alias

            stringtegoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double ondalikliSayi = 1.50;

            bool sistemeGirisYapmisMi = true; //şart blok
            
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Yükseliş butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(ondalikliSayi);




        }
    }
}