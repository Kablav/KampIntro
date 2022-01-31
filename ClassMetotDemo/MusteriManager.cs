using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd + " müşterisi sisteme eklendi.");
            Console.WriteLine("-----------------------------");
        }

        public void listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.SoyAd);
            }
            Console.WriteLine("-----------------------------");
        }

        public void silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd + " müşterisi sistemden silindi.");

        }
    }
}

