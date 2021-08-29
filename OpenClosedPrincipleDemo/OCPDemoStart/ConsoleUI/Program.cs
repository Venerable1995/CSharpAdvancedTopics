using OCPLibrary;
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
            List<iApplicantModel> applicants = new List<iApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new exuctiveModel{ FirstName = "Nancy", LastName = "Roman" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
           

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager :{emp.IsManager}  ISExecutive {emp.IsExecutive} ");
            }

            Console.ReadLine();
        }
    }
}
