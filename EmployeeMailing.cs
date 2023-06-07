using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeMailing : IEmployeeMailing
    {
        public Task AddEmployeeToMailingServer(Employee employee)
        {
            //Adding the employee to the mailing server
            return Task.CompletedTask;
        }
    }
}
