using System;

namespace static_sinif_ve_uyeler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan1 = new Calisan("Derya", "Yıldırım", "IK"),
                calisan2 = new Calisan("Vahdet", "Savcı", "IT");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Console.WriteLine("Toplama işleminin sonucu: {0}", Islemler.Topla(100,200));
        Console.WriteLine("Çıkarma işleminin sonucu: {0}", Islemler.Cikar(400,50));
    }
}

class Calisan
{
    private static int calisanSayisi;

    internal static int CalisanSayisi { get => calisanSayisi;}

    private string isim;
    private string soyisim;
    private string departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }

    internal Calisan(string isim, string soyisim, string departman)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.departman = departman;
        calisanSayisi++;
    }
}

static class Islemler
{
    internal static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    internal static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}