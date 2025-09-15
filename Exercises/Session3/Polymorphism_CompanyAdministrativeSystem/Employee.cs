namespace Polymorphism_CompanyAdministrativeSystem;

public abstract class Employee: IEmployee
{
    public string Name { get; set; }
    public Employee(string name)
    {
        Name = name;
    }
    public abstract double GetMonthlySalary();
    
}