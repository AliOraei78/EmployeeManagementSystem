public class EmployeeFactory
{
    public static Employee CreateEmployee(string type, string name, int age, int id, decimal salary, string extra = "")
    {
        Employee employee = type.ToLower() switch
        {
            "developer" => new Developer()
            {
                Name = name,
                Age = age,
                Id = id,
                Salary = salary,
                ProgrammingLang = extra
            },
            "manager" => new Manager()
            {
                Name = name,
                Age = age,
                Id = id,
                Salary = salary,
                TeamSize = int.Parse(extra)
            },
            "consultant" => new Consultant()
            {
                Name = name,
                Age = age,
                Id = id,
                Salary = salary,
                Field = extra
            }
        };

        employee.SalaryStrategy = type.ToLower() switch
        {
            "developer" => new DeveloperSalaryStrategy(),
            "manager" => new DeveloperSalaryStrategy(),
            "consultant" => new ConsultantSalaryStrategy(),
            _ => new DefaultSalaryStrategy()
        };

        return employee;
    }
}