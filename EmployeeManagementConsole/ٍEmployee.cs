public abstract class Employee : Person
{
    public int Id { get; set; }
    public decimal Salary { get; set; }
    public ISalaryCalculationStrategy SalaryStrategy {  get; set; }

    public abstract void Work();

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"My Id: {Id} and my Salary: {Salary:C}");
    }

    public virtual decimal GetAnnualSalary() => SalaryStrategy.CalculateAnnualSalary(this);
}
