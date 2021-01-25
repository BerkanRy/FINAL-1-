using System;

class MainClass
{
    public static void Main(string[] args)
    {

        int üretimBandı = 400;         // m
        double paketUzunlugu = 0.3;    // m   1m 100cm
        double paketArası = 0.5;       //m       50cm 
        double maxPaketSayisi = üretimBandı / (paketUzunlugu + paketArası);
        Console.Write("maxPaketSayisi={0}\n", maxPaketSayisi);

        // 2 saat sonunda 10km ilerleyecek
        int toplamIlerleyis = 10000;
        int toplamTur = toplamIlerleyis / üretimBandı;
        Console.Write("toplamTur={0}\n", toplamTur);
        double toplamPaketSayisi = maxPaketSayisi * toplamTur;
        Console.Write("toplamPaketSayisi={0}\n", toplamPaketSayisi);

        double toplamHataliPaket = toplamPaketSayisi / 5;
        double basariliPaketSayısı = (toplamPaketSayisi - toplamHataliPaket);
        Console.Write("Başarılı Paket Sayısı {0}\n", basariliPaketSayısı);
        Console.Write("Hatalı Paket Sayısı {0}\n", toplamHataliPaket);

    }
}

        
    

    

   

