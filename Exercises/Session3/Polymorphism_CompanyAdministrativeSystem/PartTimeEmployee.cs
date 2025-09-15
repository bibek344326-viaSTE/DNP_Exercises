namespace Polymorphism_CompanyAdministrativeSystem;

public class PartTimeEmployee: Employee
{
    public int HoursPerMonth { get; set; }
    public double HourlyWage { get; set; }
    public PartTimeEmployee(string name, int hoursPerMonth, double hourlyWage): base(name)
    {
        HoursPerMonth = hoursPerMonth;
        HourlyWage = hourlyWage;
    }
    public override double GetMonthlySalary()
    {
        return HoursPerMonth * HourlyWage;
    }
    
}