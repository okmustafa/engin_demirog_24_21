using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 101;
            //int number1 = 20;
            //int number2 = 20;
            //int number3 = 20;
            //int number4 = 20;

            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{

            //    Console.WriteLine("Number is 20");   //Ctrl d ile başına geldiğin satırı aşağı kopyaayabilirsin 
            //    Console.WriteLine("Number is 20");   //Ctrl d ile başına geldiğin satırı aşağı kopyaayabilirsin 


            //}

            //else Console.WriteLine("Number is 10 or 20");


            //Console.ReadLine();

            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                case 30:
                    Console.WriteLine("number is 30");
                    break;

                case 40:
                    Console.WriteLine("number is 30");
                    break;
                case 50:
                    Console.WriteLine("number is 30");
                    break;
                case 55:
                    Console.WriteLine("number is 30");
                    break;
                case 60:
                    Console.WriteLine("number is 30");
                    break;
                case 70:
                    Console.WriteLine("number is 30");
                    break;
                case 80:
                    Console.WriteLine("number is 30");
                    break;
                case 90:
                    Console.WriteLine("number is 30");
                    break;

                default:
                    Console.WriteLine("number is 10,20,30");
                    Console.WriteLine("number is 10,20,30");
                    break;

            }
            Console.ReadLine();



            if (number >= 0 && number <= 100) { Console.WriteLine("Number is between 0-100"); }

            else if (number > 100 && number <= 200) { Console.WriteLine("Number is between 101-200"); }

            else if (number < 0 || number > 200) { Console.WriteLine("Number is less than 0 or greater than 200 "); }
            Console.ReadLine();
        }

    }
}
