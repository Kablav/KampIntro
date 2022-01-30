
using System;

namespace Calısma 
{
    internal class Ödev
    {
        static void Main(string[] args)
        { 
            Product urun1 = new Product();
            urun1.urunAdi = "Hat  ";
            urun1.urunSahibi = "Yusuf ";
            urun1.urunMiktari =  30;

            Product urun2 = new Product();
            urun2.urunAdi = "shirt";
            urun2.urunSahibi = "Mehmet";
            urun2.urunMiktari = 20;

            Product urun3 = new Product();
            urun3.urunAdi = "pant ";
            urun3.urunSahibi = "Ensar ";
            urun3.urunMiktari =  35;

            Product urun4 = new Product();
            urun4.urunAdi = "shoes";
            urun4.urunSahibi = "Atlas ";
            urun4.urunMiktari = 60;

            Product urun5 = new Product();
            urun5.urunAdi = "neckle";
            urun5.urunSahibi = "Semih ";
            urun5.urunMiktari = 45;

            
            Product[] Urunler = new Product[] { urun1, urun2, urun3, urun4 };

            //Foreach
            Console.WriteLine("Ürün kategorileri");
            Console.WriteLine("Urun adı | Urun sahibi | Ürün miktarı");

            foreach (var urun in Urunler)
            {        
                Console.WriteLine(urun.urunAdi + "    |" + urun.urunSahibi + "       |" + urun.urunMiktari);
            }


            //For
            Console.WriteLine("Ürün kategorileri");
            Console.WriteLine("Urun adı | Urun sahibi | Ürün miktarı");

            for (int i = 0; i < Urunler.Length; i++)
            {

                Console.WriteLine(Urunler[i].urunAdi + "    |" + Urunler[i].urunSahibi + "       |" + Urunler[i].urunMiktari);

            }

            switch (1)
            {
                case 0:

                    //kodlar

                    break;

            }


        }
    }
}

class Product
{
    
    public string urunAdi { get; set; }
    public string urunSahibi { get; set; }
    public int urunMiktari { get; set; }

}










