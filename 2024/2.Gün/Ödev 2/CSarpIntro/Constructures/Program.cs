using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };   // burayı yazınca (new yazınca ) aşagıdaki işaretli yer çalışıyor


            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);




            // Method(2,"dsd","sdfsdfe","dsadse");
        }


        /* static void Method(int id, string firstName, string lastName, string city)
         { 

         }*/


    }

    class Customer
    {
        //ctor yaz tabe bas kısa yolu
        public Customer()  //default constructor => parametresi olmayan cstructor yani () içi boş 
        {

        }

        public Customer(int id, string firstName, string lastName, string city)    //<= burası bu blok çalıştı.
        {

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;




            Console.WriteLine("Yapıcı blok çalıştııı");   // bunu önce yazıyor yani customer new yazınca bu metoda geliyor sonra cw(firstname)' e gelip Derin i yazdırıyor.
        }



        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

    }
}
