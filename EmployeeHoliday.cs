using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeHoliday : IEmployeeHoliday
    {
        public Task CalculateEmployeeHolidays(Employee employee)
        {
            //Do the mathematical operations required
            return Task.CompletedTask;
        }
    }
}
