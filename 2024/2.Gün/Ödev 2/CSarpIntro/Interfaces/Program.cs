using System;

namespace Interfaces
{
    class Program
    {


        //interfacesler new'lenemez
        static void Main(string[] args)
        {

            /*
            IPersonManager customerManager = new CustomerManager();            

            IPersonManager employeeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(customerManager);

            */

            // yukarıdaki daha iyi anlaşılsın diye

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(new CustomerManager());

            projectManager.Add(new EmployeeManager());

            projectManager.Add(new InternManager());

            projectManager.Update(new InternManager());
        }
    }




    /*
    class PersonManager
   {

       public void Add()
       {                                                   //*   
           Console.WriteLine("Eklendi");                   //* yıldızlılar sayesinde implemented operaation oldu yani içi doldurulmuş demek
       }                                                   //*

   }


   class CustomerManager : PersonManager
   {

   }

    */





    interface IPersonManager
    {

        void Add();   //unimplemented operation oldu  //interface üyeleri dışarıdan erişilebilir olmalıdır bu sebeple default olarak public'tir zaten bi daha public yazmamalısın 
        void Update();

    }

    //  inherits - class ------------- implements - interface

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // müşteri ekleme kodları yazılır
            Console.WriteLine("Müşteri Eklendi.");
        }

        void IPersonManager.Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }


    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // personel ekleme kodları yazılır
            Console.WriteLine("Personel Eklendi.");
        }

        void IPersonManager.Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {

            personManager.Add();

        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }

    }



}