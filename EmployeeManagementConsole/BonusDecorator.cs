public class BonusDecorator : EmployeeDecorator
{
    private readonly decimal _bonusPercentage;

    public BonusDecorator(Employee employee, decimal bonusPercentage = 0.20m) : base(employee)
    {
        _bonusPercentage = bonusPercentage;
    }

    public override decimal GetAnnualSalary()
    {
        decimal baseSalary = base.GetAnnualSalary();
        return baseSalary * (1 + _bonusPercentage);
    }

    public override void Introduce() 
    { 
        base.Introduce();
        Console.WriteLine($"Has {_bonusPercentage:P0} annual bonus");
    }
}