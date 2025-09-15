using Polymorphism_CompanyAdministrativeSystem;

class Program
{
    static void Main(string[] args)
    {
        // Create a company
        Company company = new Company();

        // Hire some employees
        company.HireEmployee(new PartTimeEmployee("Alice", 80, 15));  // 80 hours at $15 per hour
        company.HireEmployee(new FullTimeEmployee("Bob", 4000));      // $4000 per month
        company.HireEmployee(new PartTimeEmployee("Charlie", 100, 20));  // 100 hours at $20 per hour

        // Display total salary
        Console.WriteLine($"Total monthly salary: {company.GetTotalMonthlySalary()}");

        // Display most expensive employee
        company.DisplayEmployeeWithHighestSalary();
    }
    
}