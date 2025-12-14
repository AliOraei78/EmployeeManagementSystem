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
                TeamSize = int.TryParse(extra, out int teamSize) ? teamSize : 0,
            },
            "consultant" => new Consultant()
            {
                Name = name,
                Age = age,
                Id = id,
                Salary = salary,
                Field = extra
            },
            _ => new Intern()
            {
                Name = name,
                Age= age,
                Id = id,
                Salary = salary
            }
        };

        employee.SalaryStrategy = type.ToLower() switch
        {
            "developer" => new DeveloperSalaryStrategy(),
            "manager" => new ManagerSalaryStrategy(),
            "consultant" => new ConsultantSalaryStrategy(),
            _ => new DefaultSalaryStrategy()
        };

        CompanyLogger.Instance.Log($"{type} created!");

        return employee;
    }
}