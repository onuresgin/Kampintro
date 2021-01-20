using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(product urun)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urun.Adi);


        }

        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokAdeti) 
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urunadi);



        }
        

        
      



    }
}
