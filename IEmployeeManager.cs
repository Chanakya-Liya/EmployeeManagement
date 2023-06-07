﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public interface IEmployeeManager
    {
        public async Task<Employee> HireEmployee(Employee employee);
    }

}
