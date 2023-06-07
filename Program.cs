using Employee;
EmployeeDatabase employeeDatabase = new EmployeeDatabase();
EmployeeHoliday employeeHoliday = new EmployeeHoliday();
EmployeeMailing employeeMailing = new EmployeeMailing();
EmployeeTax employeeTax = new EmployeeTax();
EmployeeManager employeeManager = new EmployeeManager(employeeDatabase, employeeHoliday, employeeMailing, employeeTax);

