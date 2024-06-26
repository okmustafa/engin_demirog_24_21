using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int, decimal, float, enum, boolean => value types(deger tipler) 

            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;
            //Console.WriteLine("Sayi1 : " + sayi1);

            ///
            ////***********
            /// 
            ////arrays, class, interface ... reference types (referans tipler)

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayilar1[0]= " + sayilar1[0]);

            //Deger tiplerde sadece Stack tablosu var referans tiplerde ise hem Stack tablosu var hemde Heap tablosu var          /-/ 1.video 09:45 
            //new dediğim zaman Heap de bir adres olusuyor ve degerleri oraya yerlestiriyor.
            ///Burada ki new onemli öyle aklına kalsın new lenenlerde deger tipi ve bu deger tipine adres olusturuyor değişkenleri eşitleyip değiştirdiğimiz zaman değişkenler sayilar1=sayilar2 oluyor.


            //***********

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName="Engin";

            person2 = person1;    // Yukarıdaki arraylarde olduğu gibi burada değer eşitlemesi değil adres eşitlemesi yapıyoruz.
               // person1 in referans numarasını person2 ye aktarmış olduk. ikiside aynı yere gidiyor bellekte adresler aynı
            person1.FirstName = "Derin";

            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager= new PersonManager();
            personManager.Add(customer);


        }

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



    }


    class Customer : Person  //inheritance yaptık  // base classımız Person ebeveyn gibi düsünebilirs   => Miras
    {
        public string CreditCardNumber { get; set; }
    }


    class Employee :Person
    {        
         public int EmployeeNumber { get; set; }
    }


    class PersonManager
    {

        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);

        }
    
    }

}
