﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //name convation
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi: " + urun.Adi);

        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("sepete eklendi: " + urunAdi);
            
        }
    }
}
