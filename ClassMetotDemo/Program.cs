using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Fatma Güler";
            musteri1.Ulke = "Türkiye";
            musteri1.DogumYili = 1974;
            musteri1.Yas = 47;

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Simione Panda";
            musteri2.Ulke = "USA";
            musteri2.DogumYili = 1987;
            musteri2.Yas = 34;

            Musteri musteri3 = new Musteri();
            musteri3.AdSoyad = "Usain Bolt";
            musteri3.Ulke = "Jameika";
            musteri3.DogumYili = 1880;
            musteri3.Yas = 41;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.AdSoyad);
                Console.WriteLine(musteri.Ulke);
                Console.WriteLine(musteri.DogumYili);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine("-------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);


            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

        }
    }
}
