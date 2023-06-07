using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeDatabase : IEmployeeDatabase
    {
        public Task AddEmployeeEntry(Employee employee)
        {
            //Add employee details to the database
            return Task.CompletedTask;
        }

        public Task UpdateTaxScheme(Employee employee)
        {
            //Update tax schema in the database
            return Task.CompletedTask;
        }

        public Task UpdateHolidays(Employee employee)
        {
            //Update holidays in the database
            return Task.CompletedTask;
        }
    }
}
