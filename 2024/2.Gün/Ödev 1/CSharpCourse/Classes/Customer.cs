using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    // 38. ders Classlar içinde Property tanımlamak
    //
    internal class Customer
    {
        //field  / değişken, alan tanımlamak
        // public string FirstName;


        //Property  /Özellik tanımlamak
        public int ID { get; set; }
        //public string FirstName { get; set; }  //genelde bu versiiyon kullanılıyor

        //
        //
        // 
        //
        private string _firstName;

        public string FirstName     //39.ders Encapsulation
        {
            get
            { return "Mrs. " + _firstName; }

            set
            { _firstName = value; }
        }





        public string LastName { get; set; }
        public string City { get; set; }

        






    }
}
