
using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();

            int sonuc = Topla(6, 58);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 1;


            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        //resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

    }
}

/*using System;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelamVer("Mustafa");
            SelamVer("Yusuf");
            int sonuc = Topla(6, 58);

            Console.ReadLine();

        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

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


       // Person person = new Person();

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



*/