namespace Polymorphism_CompanyAdministrativeSystem;

public class Company
{
    public List<Employee> Employees { get; set; }
    public Company()
    {
        Employees = new List<Employee>();
    }
    
    //Hire a new employee
    public void HireEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
    
    //Get the total monthly salary of all employees
    public double GetTotalMonthlySalary()
    {
        double total = 0;
        foreach (Employee employee in Employees)
        {
            total += employee.GetMonthlySalary();
        }
        return total;
    }
    
    //Display the name and monthly salary of all employees
    public void DisplayAllEmployees()
    {
        foreach (Employee employee in Employees)
        {
            Console.WriteLine($"Name: {employee.Name}, Monthly Salary: {employee.GetMonthlySalary()}");
        }
    }
    
    //Display the employee with the highest monthly salary
    public void DisplayEmployeeWithHighestSalary()
    {
        Employee mostExpensiveEmployee = null;
        double highestSalary = 0;

        foreach (var employee in Employees)
        {
            double salary = employee.GetMonthlySalary();
            if (salary > highestSalary)
            {
                highestSalary = salary;
                mostExpensiveEmployee = employee;
            }
        }

        if (mostExpensiveEmployee != null)
        {
            Console.WriteLine($"The most expensive employee is {mostExpensiveEmployee.Name} with a monthly salary of {highestSalary}");
        }
    }
    
}