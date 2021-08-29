using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class excutiveAccounts : IAccounts
    {
        public EmployeeModel Create(iApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName }.{person.LastName}@acmeorp.com";
            output.IsExecutive = true;
            output.IsManager = true;
            return output;
        }
    }
}
