using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Ad = "Percy";
            musteri1.SoyAd = "Jackson";
            musteri1.TelNo = 321;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 456;
            musteri2.Ad = "Sally";
            musteri2.SoyAd = "Jackson";
            musteri2.TelNo = 654;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 789;
            musteri3.Ad = "Annabeth";
            musteri3.SoyAd = "Chase";
            musteri3.TelNo = 987;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager mustermanager = new MusteriManager();
            mustermanager.ekleme(musteri1);
            mustermanager.listeleme(musteriler);
            mustermanager.silme(musteri3);

        }
    }
}