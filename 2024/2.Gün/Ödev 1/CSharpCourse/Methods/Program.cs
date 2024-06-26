using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var result = Add2(20);

            //int number1=20;            // deger verme burada 20 veriyoruz degerine
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);


            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(3, 5, 8));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));   //21
            Console.WriteLine(Add5(1, 2, 3, 4, 5, 6));   //18
            Console.ReadLine();
        }

        static void Add()  //void sadece yap et buyur geri bir şey döndürmüyor
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30)  //number2 nin default değeri 30 oldu. default degerleri sona dogru yazılır.başa yazıp son boş bırakılmaz
        {
            //return number1 + number2;

            var result = number1 + number2;
            return result;

        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;             //number1 deger tiplerdir.burada sadece degeri degişti geri 20 oldu.
                                      //Ama ref yazılırsa referans deger olur ve degeri kalıcı olarak degisir
                                      //ref keywordü deger tiplerinin referans tip gibi kullanılmasını sağlar
                                      //refde number1 set etmiş olmanız gerek illa bir deger vermeniz gerekti 
                                      //outta ise basta vermenin anlamı yok ilk kullanım anında set edilmesi lazım
                                      //burada 30 ile set edildi kaldırırsan hata verir.basta 20 vermenin anlamı yok burada 30la set etmek gerek ama
            return number1 + number2;

        }


        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)    //ismini Multiply2 yapmana gerek yok method overloading yapılıyor
        {                                                             //Ama burayı aynı isimde de olsa yazman gerek overload yapmak için
            return number1 * number2 * number3;
        }


        static int Add4(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Add4(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }


        //4,5,6,..100 sayı içinde mi overload yazacağız hayır params kullanacağız   


        static int Add4(params int[] numbers)  //params ile istedigimiz kadar parametre gönderebiliriz

        {
            return numbers.Sum();                               //21
        }

        static int Add5(int number, int number2, params int[] numbers)  //burada number degeri 1 oluyor number2 de 2 oluyor {} kullanılmadığı içinde bunları dahil etmiyor.

        {
            return numbers.Sum();                   //18
        }
    }
}
