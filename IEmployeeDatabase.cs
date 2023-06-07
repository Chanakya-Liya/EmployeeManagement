using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal interface IEmployeeDatabase
    {
        public Task<Employees> AddEmployeeEntry(Employees employee);
        public Task<Employees> UpdateTaxScheme(Employees employee);
        public Task<Employees> UpdateHolidays(Employees employee);
    }
}
