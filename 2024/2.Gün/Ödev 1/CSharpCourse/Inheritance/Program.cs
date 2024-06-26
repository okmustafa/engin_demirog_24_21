using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[3]
                {
                    new Customer{
                        FirstName="Engin" 
                    },new Student{ 
                        FirstName = "Derin" 
                    },new Person{ 
                        FirstName = "Salih" 
                    }
                };

            foreach (Person person in persons) 
            {
                Console.WriteLine(person.FirstName);
            }
            
            Console.ReadLine();

        }
    }


    class Person

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {
    
    
    }

    class Customer : Person   // Buraya Person2 yide ekleyemeyiz. Bir nesneyi bir kere inheritance alabilirsiniz. Ama birden fazla implemantasyon yapabilirsiniz.
    {                         // Yani IPerson,IPerson2 filan diye ekleyebilirim.
                              // Ama dikkat etmem gereken konu önce inheritance yazılır Sonr ainterfaceler kaç tane varsa
                              //**
                              // Classların tek başına bir anlamı vardır. Ama interfacelerin yoktur.
                              // İkiside inheritance gibi kullanılabiliyor. Aslında interfaceler bir implemantasyondur. Fakat yeni nesil dillerde inheritance gibide
                              // kullanım senaryoları söz konusudur.
                              //**
                              //**
                              //    bunların ikiside benzer farkları ne // abstract classlar inheritance için önemli

                              // Eğer İneritance kullanmaya gerek yok diye düşünüyorsan zorunlu değilsen interfaceden gitmeye çalış.
                              // interfaccelerde inheritance mantığında çalışıyor sonuçta
        public string City { get; set; }    
    }

    class Student : Person 
    {


        public string Department { get; set; }  
    }







}
