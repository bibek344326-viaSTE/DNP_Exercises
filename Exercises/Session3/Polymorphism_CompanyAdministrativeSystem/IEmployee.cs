namespace Polymorphism_CompanyAdministrativeSystem;

public interface IEmployee
{
    string Name { get; set; }
    double GetMonthlySalary();
}