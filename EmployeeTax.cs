using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeTax : IEmployeeTax
    {
        public Task CalculateEmployeeTaxSchema(Employee employee)
        {
            //Do the mathematical operations required
            return Task.CompletedTask;
        }
    }
}
