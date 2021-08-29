using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
   public class DigitalProductModel :IDigitalProductModel
    {
        public  String Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }
        public int TotalDownloadLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer) 
        {

            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress}");
                TotalDownloadLeft -= 1;
                if (TotalDownloadLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadLeft = 0;

                }
            } 

        }
    }
}
