using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Yeni müşteri eklendi :" + musteri.AdSoyad);

        }

        public void Sil(Musteri musteri) 
        {
            Console.WriteLine("Müşterinin hesabı silindi :" + musteri.AdSoyad); 

        
        }



    }
}
