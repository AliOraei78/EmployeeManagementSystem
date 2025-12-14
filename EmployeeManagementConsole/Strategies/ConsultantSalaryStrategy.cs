public class ConsultantSalaryStrategy : ISalaryCalculationStrategy
{
    public decimal CalculateAnnualSalary(Employee employee)
    {
        decimal baseAnnual = employee.Salary * 12;

        decimal bonus = baseAnnual * 0.12m;

        if (employee is Consultant con && (con.Field == "outcome"))
            bonus += baseAnnual * 0.08m;

        return baseAnnual + bonus;
    }
}