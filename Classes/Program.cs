using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args, Customer customer)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer
            {
                City = "Ankara",
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ"
            };
            Customer customer2 = new Customer() { Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ" };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    internal class CustomerManager
    {
        public CustomerManager()
        {

        }


    }
}
