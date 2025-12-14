public class InsuranceDecorator : EmployeeDecorator
{
    public InsuranceDecorator(Employee employee) : base(employee)
    {
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("Has full health insurance.");
    }
}