public class DefaultSalaryStrategy : ISalaryCalculationStrategy
{
    public decimal CalculateAnnualSalary(Employee employee)
    {
        decimal baseAnnual = employee.Salary * 12;

        decimal bonus = baseAnnual * 0.05m;

        return baseAnnual + bonus;
    }
}