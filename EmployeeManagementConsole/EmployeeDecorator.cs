public abstract class EmployeeDecorator : Employee
{
    protected Employee _employee;

    protected EmployeeDecorator(Employee employee) 
    {  _employee = employee; 
        Name = employee.Name;
        Age = employee.Age;
        Id = employee.Id;
        Salary = employee.Salary;
        SalaryStrategy = employee.SalaryStrategy;
    }

    public override void Introduce()
    {
        _employee.Introduce();
    }

    public override void Work()
    {
        _employee.Work();
    }

    public override decimal GetAnnualSalary()
    {
        return _employee.GetAnnualSalary();
    }
}