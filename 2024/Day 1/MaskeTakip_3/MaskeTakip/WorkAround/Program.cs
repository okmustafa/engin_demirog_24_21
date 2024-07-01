using System;
using System.Dynamic;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer("ali");
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();

            int sonuc = Topla();
            //int sonuc = Topla(3,5);




            Console.ReadLine();
        }


        static void SelamVer(string isim ="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);

        }

        static int Topla(int sayi1=5, int sayi2=10)
        {   
            int sonuc =sayi1 + sayi2;
            Console.WriteLine("Toplam: "+ sonuc.ToString());
            return sonuc;
        }







        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000; // db'den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demirog";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int DogumYili { get; set; }
        public long TcNo { get; set; }







    }


}
