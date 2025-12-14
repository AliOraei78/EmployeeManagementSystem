public class ManagerSalaryStrategy : ISalaryCalculationStrategy
{
    public decimal CalculateAnnualSalary(Employee employee)
    {
        decimal baseAnnual = employee.Salary * 12;

        decimal bonus = baseAnnual * 0.15m;

        if (employee is Manager mgr && (mgr.TeamSize > 0))
            bonus += baseAnnual * 0.2m;

        return baseAnnual + bonus;
    }
}