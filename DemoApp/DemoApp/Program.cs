using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer cust = new Customer
            {
                ID = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            Console.WriteLine("Created a new customer.");

            //change the customer's name.
            cust.FirstName = "Jane";
            cust.LastName = "Smith";

            //create a second customer.
            Customer cust2 = new Customer
            {
                ID = 2,
                FirstName = "Shane",
                LastName = "West"
            };
                        
        }
    }
}
