using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

       public void MusteriListeleme(Musteri[] musteris)
        {
            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine(musteri.MusteriId + " -- " + musteri.MusteriAdi + " -- " + musteri.MusteriHesabNo );
            }
        }

        public void MusteriEkleme(Musteri[] musteris)
        {
            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine(musteri.MusteriId + " -- " + musteri.MusteriAdi + " -- " + musteri.MusteriHesabNo + " hesap açıldı...");
            }
        }

        public void MusteriSil(Musteri[] musteris)
        {
            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine(musteri.MusteriId + " -- " + musteri.MusteriAdi + " -- " + musteri.MusteriHesabNo + " hesap silindi...");
            }
        }



    }
}
