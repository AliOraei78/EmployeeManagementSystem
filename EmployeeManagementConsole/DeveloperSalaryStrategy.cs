public class DeveloperSalaryStrategy : ISalaryCalculationStrategy
{
    public decimal CalculateAnnualSalary(Employee employee)
    {
        decimal baseAnnual = employee.Salary * 12;

        decimal bonus = baseAnnual * 0.20m;

        if (employee is Developer dev && (dev.ProgrammingLang == "C#" || dev.ProgrammingLang == "Java"))
            bonus += baseAnnual * 0.10m;

        return baseAnnual + bonus;
    }
}