using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "565465555";
            musteri1.Id = 1;
            musteri1.Adi = "Burak";
            musteri1.Soyadi = "Akdeniz";
            musteri1.TcNo = "19061815652";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "4654544444";
            musteri2.VergiNo = "44477777";
            musteri2.SirketAdi = "SoSoft";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
