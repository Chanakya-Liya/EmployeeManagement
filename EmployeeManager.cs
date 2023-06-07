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

        public EmployeeManager(IEmployeeDatabase employeeDatabase, IEmployeeMailing employeeMailing, IEmployeeTax employeeTax, IEmployeeHoliday employeeHoliday)
        {
            EmployeeDatabase = employeeDatabase;
            EmployeeMailing = employeeMailing;
            EmployeeTax = employeeTax;
            EmployeeHoliday = employeeHoliday;
        }

        public async Task<Employees> HireEmployee(Employees employee)
        {
            //Hire Employee
            return employee;
        }
    }
}
