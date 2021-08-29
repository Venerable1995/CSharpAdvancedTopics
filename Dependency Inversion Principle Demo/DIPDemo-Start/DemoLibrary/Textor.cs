using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Textor : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"I am Texting {person.FirstName} to say {message}");
        }
    }
}
