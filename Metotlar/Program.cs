
using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] uruns = new Urun[] {urun1, urun2};

            foreach (Urun urun in uruns)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");
            }



            Console.WriteLine("----------------Metotlar------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "yeşil elma", 12, 9);
            sepetManager.Ekle2("karpuz", "yeşil karpuz", 12, 13);


        }
    }
}


// Dont repeat yourself - DRY