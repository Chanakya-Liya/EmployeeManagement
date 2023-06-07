using Employee;
using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.Write("To add an employee enter add or to quit enter quit: ");
            string command = Console.ReadLine().ToLower();
            if (command == "add")
            {
                IEmployeeDatabase employeeDatabase = new EmployeeDatabase();
                IEmployeeMailing employeeMailing = new EmployeeMailing();
                IEmployeeTax employeeTax = new EmployeeTax();
                IEmployeeHoliday employeeHoliday = new EmployeeHoliday();

                IEmployeeManager employeeManager = new EmployeeManager(employeeDatabase, employeeMailing, employeeTax, employeeHoliday);

                Console.Write("Employees first name: ");
                string fName = Console.ReadLine();
                Console.Write("Employees last name: ");
                string lName = Console.ReadLine();
                Console.Write("Employees email: ");
                string email = Console.ReadLine();
                Employees employee = new Employees(fName, lName, email);



                Employees hiredEmployee = await employeeManager.HireEmployee(employee);
                Console.WriteLine("Employee hired successfully");
                Console.WriteLine($"Name: {hiredEmployee.FirstName} {hiredEmployee.LastName}");
                Console.WriteLine($"Email: {hiredEmployee.Email}");
            }else if(command == "quit")
            {
                Console.WriteLine("Program ended");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}