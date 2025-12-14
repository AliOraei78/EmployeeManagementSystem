public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Name = "Employee",
                Age = 19,
                Id = 1,
                Salary = 34333
            },
            new Developer()
            {
                Name = "Developer",
                Age = 24,
                Id = 2,
                Salary = 565555,
                ProgrammingLang = "C++"
            },
            new Manager()
            {
                Name = "Manager",
                Age = 27,
                Id = 3,
                Salary = 43433333,
                TeamSize = 22
            }
        };
        foreach( var employee in employees)
        {
            employee.Introduce();
            employee.Work();
            Console.WriteLine("---------");
        }
    }
}