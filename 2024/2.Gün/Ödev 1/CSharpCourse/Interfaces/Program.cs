using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //InterfacesDemo();


            ICustomerDal[] customerDals = new ICustomerDal[3]

            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MysqlCustomerDal()
            };


            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void InterfacesDemo()
        {
            // IPerson person=new IPerson();  // sen bir interface sin instance ini oluşturamazsın ama alttakiler gibi worker,student,customer oluşturabilir
            // Interface ve Abstract bu tip soyut nesneleri new lememiz mümkün değildir.
            // IPerson person=new Customer();
            // IPerson person= new Student();
            //IPerson person3 = new Worker();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }



        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Engin",              //altttakinin aynısı
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            manager.Add(customer);

            //manager.Add(new Customer {Id=1, FirstName="Engin",LastName="Demiroğ", Address="Ankara" });   // yukarıdakinin aynısı


            //**************************

            Student student = new Student()
            {
                Id = 2,
                FirstName = "Derin",
                LastName = "DEmiroğ",
                Departmant = "Computer Sciences"

            };
            manager.Add(student);
            manager.Add(new Worker { Id = 3, FirstName = "Ahmet", LastName = "YILMAZ", Departmant = "İnşaat" });
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }


    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }



    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);

        }


    }

}
