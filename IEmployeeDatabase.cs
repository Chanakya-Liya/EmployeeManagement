using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public interface IEmployeeDatabase
    {
        public Task AddEmployeeEntry(Employee employee);
        public Task UpdateTaxScheme(Employee employee);
        public Task UpdateHolidays(Employee employee);
    }
}
