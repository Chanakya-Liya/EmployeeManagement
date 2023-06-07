using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeDatabase : IEmployeeDatabase
    {
        public async Task<Employees> AddEmployeeEntry(Employees employee)
        {
            //Add employee details to the database
            return employee;
        }

        public async Task<Employees> UpdateTaxScheme(Employees employee)
        {
            //Update tax schema in the database
            return employee;
        }

        public async Task<Employees> UpdateHolidays(Employees employee)
        {
            //Update holidays in the database
            return employee;
        }
    }
}
