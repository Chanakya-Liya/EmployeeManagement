using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public interface IEmployeeDatabase
    {
        public async Task<Employee> AddEmployeeEntry(Employee employee);
        public async Task<Employee> UpdateTaxScheme(Employee employee);
        public async Task<Employee> UpdateHolidays(Employee employee);
    }
}
