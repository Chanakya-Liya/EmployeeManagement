using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeManager : IEmployeeManager
    {
        public IEmployeeDatabase EmployeeDatabase { get; set; }
        public IEmployeeHoliday EmployeeHoliday { get; set; }
        public IEmployeeMailing EmployeeMailing { get; set; }
        public IEmployeeTax EmployeeTax { get; set; }

        public EmployeeManager(IEmployeeDatabase EmployeeDatabase, IEmployeeHoliday EmployeeHoliday, IEmployeeMailing EmployeeMailing, IEmployeeTax EmployeeTax)
        {
            this.EmployeeDatabase = EmployeeDatabase;
            this.EmployeeHoliday = EmployeeHoliday;
            this.EmployeeMailing = EmployeeMailing;
            this.EmployeeTax = EmployeeTax;
        }

        public Task HireEmployee(Employee employee)
        {
            //Hire Employee
            return Task.CompletedTask;
        }
    }
}
