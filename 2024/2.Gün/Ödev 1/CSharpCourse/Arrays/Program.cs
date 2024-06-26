using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////string student1 = "Engin";
            ////string student2 = "Derin";
            ////string student3 = "Salih";

            //string[] students = new string[3];

            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            //string[] students4 = new string[3] { "Enginnnn", "Derinnnn", "Salihhnn" };

            //// string[] students4 = new string[3] { "Enginnnn", "Derinnnn", 4 };   // hata verecek  4 string değil

            //string[] students2 = new[] { "Enginn", "Derinn", "Salihh" };

            //string[] students3 = { "Enginnn", "Derinnn", "Salihhh" };





            //foreach (string student in students2)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine();
            //Console.ReadLine();


            string[,] regions = new string[5, 3]
             {
                 {"İstanbul ","İzmit ","Balıkesir "},
                {"Ankara ","Konya ","Kırıkkale "},
                {"Antalya ","Hatay ","Adana "},
                {"Rize ","Trabzon ","Samsun "},
                {"İzmir ","Muğla ","Manisa "},
             };



            for(int i=0; i<=regions.GetUpperBound(0);i++)
            {
                for ( int j = 0;j <= regions.GetUpperBound(1);j++)
                {

                    Console.Write(regions[i,j]);
                    Console.Write("|");
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
