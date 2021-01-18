using System;

namespace ClassMetotDemo
{
    class Program
    {
       public static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Akif";
            musteri1.MusteriHesabNo = "7879878754";
            
            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Yunus";
            musteri2.MusteriHesabNo = "4564456456";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 4;
            musteri3.MusteriAdi = "Hakan";
            musteri3.MusteriHesabNo = "4564456456";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 3;
            musteri4.MusteriAdi = "Mehmet";
            musteri4.MusteriHesabNo = "4564456456";

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.MusteriEkleme(new Musteri[] { musteri1, musteri2, musteri3, musteri4 });
            
            Console.WriteLine("-----------------------------------------------");

            musteriManager.MusteriSil(new Musteri[] { musteri1 });

            Console.WriteLine("----------------------- MÜŞTERİ LİSTESİ ------------------------");
            
            musteriManager.MusteriListeleme(new Musteri[] { musteri2, musteri3, musteri4 });



            
        }
    }
}
