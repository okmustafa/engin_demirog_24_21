using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");
            //GENELLİKLE   

            double number5 = 10.4;                              //8 byte =64 bit
            decimal number6 = 10.4M;                            //16 byte=8 bit
            char charecter = 'A';                               //1 byte=8 bit
            bool condotion = false;                             //1 byte =8 bit
            byte number4 = 255;                                 //1 byte= 87 bit
            short number3 = 32767;                                //2 byte =16 bit
            int number1 = 2147483647;                             //4 byte =32 bit
            long number2 = 9223372036854775807;                 //8 byte =64 bit
            var number7 = 10;                                   // değiken bunun biti verdiğine göre
            number7 = 'A';         //charın int değerini verecek A için 65
                                   // number7 = "Ankara";   //number7 charoldu en son


            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number1 is {0}", number2);
            Console.WriteLine("Number1 is {0}", number3);
            Console.WriteLine("Number1 is {0}", number4);
            Console.WriteLine("Number1 is {0}", number5);
            Console.WriteLine("Number1 is {0}", number6);
            Console.WriteLine("Number1 is {0}", number7);
            Console.WriteLine("Condotion is {0}", condotion);
            Console.WriteLine("Charecter is : {0}", (int)charecter);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }


    }

    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
