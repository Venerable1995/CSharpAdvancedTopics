using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadLeft} downloads left.");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Mohamed",
                LastName = "Saeed",
                City = "Giza",
                EmailAddress = "Mohamed@saeed.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Head Phone" });
            output.Add(new PhysicalProductModel { Title = " T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel {Title = "Lesson Source Code " });
            output.Add(new CourseProductModel {Title = ".Net Corse start to finish " });
            return output;
        }
    }
}
