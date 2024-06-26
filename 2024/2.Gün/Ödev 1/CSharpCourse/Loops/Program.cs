using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeEchLoop();

            int number = -5;
            if (IsPrimeNumber(number))
            {
                Console.WriteLine("{0} is a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", number);
            }


            Console.ReadLine();


        }





        private static bool IsPrimeNumber(int number)
        {



            bool result = true;
            if (number < 2)
                result = false;
            for (int i = 2; i < number - 1; i++)
            {

                if (number % i == 0)
                {

                    result = false;
                    i = number;
                }

            }
            return result;

        }


        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            for (int i = 0; i < students.Length; i++) { Console.WriteLine(students[i]); }
        }

        private static void DoWhileLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);              //illa bir kere çalıştırır.
                number--;

            } while (number >= 11);  //number =0
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine("  {0}", i);

            }
            Console.WriteLine("Finihed..");
        }
    }
}
