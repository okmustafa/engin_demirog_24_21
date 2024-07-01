using System;

namespace Workaround
{

    class Program
    {
        static void Main(string[] args)

        {
            SelamVer("Mustafa");
            SelamVer("Yusuf");
            int sonuc = Topla(6, 58);

            Console.ReadLine();

        }

        static void SelamVer(string isim = "isimsiz") //void hicbir şey döndürmeyecek sadece işi yapar. Sadece şuna yap
                                                      //deger return eden bir işlem yapmak istiyorsan 
        {

            Console.WriteLine("Merhaba " + isim);
        }



        static int Topla(int sayi1 = 5, int sayi2 = 10)    //Metot ile fonksiyon aynı şey
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;

        }

        //    //string mesaj = "Merhaba";
        //    //double tutar = 152.56;
        //    //int sayi = 452;
        //    //bool girisYapmisMi = false;


        //    //Console.Write(mesaj);
        //    //Console.WriteLine(mesaj); Console.WriteLine(mesaj);
        //    //Console.WriteLine(tutar*sayi);

        //    // V si büyük olan Vatandas sınıftır. vatandas1 e instance deniyor
        //    // bunu genelde vatandas diye belirtirlerdi ayrımı kolay olsun diye sonuna 1 ekledim ben.
        //    // Büyük küçük harf duyarlılığı olduğu için Vatandas ile vatandas farklı şey

        //    // Vatandas vatandas1 = new Vatandas();

        //    // vatandas1.ad dediğimde ad gelebilmesi için Vatandas classında Adı Public olarak tanımlamamız gereklidir.
        //    // public olarak tanımlandığı zaman ise değişkenin ilk harfi büyük olmalı
        //    // string ad= "Mustafa"; => public string Ad= "Mustafa";
        //    // Publiclerde de tanımlama büyük harfle olmalı bu sebeple ad yerine Ad yazmalıyız.

        //    //**************
        //    //Classların defaultu internal arkadaşlar değişkenlerin değil.
        //    //değişkenler private diye konuştu Engin hoca 
        //    //bu public konusunun değişken ve class için farklı olduğu ile alakalı konu galiba bunu sonradan bak                     ???????


        //    //Entities katmanı yani klasörü nesneleri tutar. Varlık nesnelerini tutat veri tabanı tablosu gibi 
        //    //Business katmanı iş kurallarını tutar. Yani yazılım geliştirirken en çok kullandığımız en çok yazdığımız komutlar if bloklarını tutar
        //    // Abstract bizim soyut nesnelerimizi tutacak 
        //    // Concrete ise somut nesneleri tutacak
        //    //Person manager classı bazı projelerde Service olarak da yer almakta benzer işleri görüyorlar

        //    Console.ReadLine();

        ////Pascal Casing ilk harfin büyük olması kuralı
        //public class Vatandas

        //    {
        //        // prop yaz taba bas

        //        public string Ad { get; set; }

        //        public string Soyad { get; set; }
        //        public int DogumYili { get; set; }
        //        public long TcNo { get; set; }


        //    }
    }
}