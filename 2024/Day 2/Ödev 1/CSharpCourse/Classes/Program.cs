using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();  //CustomerManager classının bir örneğini (customerManager) oluşturdum.Bir referansınıda oluşturdum diyebilir.                                                              
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();

            productManager.Add();
            productManager.Update();


            Customer customer = new Customer();

            customer.ID = 1;
            customer.City = "Ankara";
            customer.FirstName = "Engin";           //Buralarda Set bloğu çalışıyor
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                ID = 2,
                FirstName = "Derin",                //Buralarda Set bloğu çalışıyor
                LastName = "Demiroğ",
                City = "İstanbul"
            };
            Console.WriteLine(customer2.FirstName);  //Buralarda Get bloğu çalışıyor



            Console.ReadLine();

        }
    }





}
