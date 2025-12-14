public class Program
{
    public static void Main(string[] args)
    {
        IEmployeeRepository repository = new InMemoryEmployeeRepository();
        var printer = new EmployeePrinter();

        repository.Add(new Developer()
        {
            Name = "Java Developer",
            Age = 24,
            Id = 2,
            Salary = 565555,
            ProgrammingLang = "Java"
        });
        repository.Add(new Manager()
        {
            Name = "Regional Managers)",
            Age = 27,
            Id = 3,
            Salary = 43433333,
            TeamSize = 22
        });
        repository.Add(new Intern()
        {
            Name = "Intern",
            Age = 14,
            Id = 222,
            Salary = 90
        });
        repository.Add(new Consultant()
        {
            Name = "Data Consultant",
            Age = 60,
            Id = 21,
            Salary = 893773,
            Field = "Income"
        });

        var employees = repository.GetAll();

        foreach ( var employee in employees )
        {
            printer.PrintWork(employee);
            printer.PrintIntroduce(employee);
            if(employee is Developer)
                (employee as Developer)?.WriteCode();
            if( employee is Manager)
                (employee as Manager)?.ManageTeam();
            if( employee is Consultant)
                (employee as Consultant)?.Advise();
            Console.WriteLine("---------");
        }

        var employeeById = repository.GetById(2);
        printer.PrintWork(employeeById);
        Console.WriteLine("---------");

        List<IManageable> manageables = new List<IManageable>()
        {
            new Manager()
            {
                Name = "Tech Manager",
                Age = 31,
                Id = 4,
                Salary = 1112,
                TeamSize = 5
            },
            new Manager()
            {
                Name = "General Manager",
                Age = 22,
                Id = 5,
                Salary = 32332,
                TeamSize = 2
            }
        };
        foreach( var manageable in manageables  )
        {
            manageable.ManageTeam();
            Console.WriteLine("---------");
        }

        List<IDevelop> developers = new List<IDevelop>()
        {
            new Developer()
            {
                Name = "C# Developer",
                Age = 24,
                Id = 2,
                Salary = 565555,
                ProgrammingLang = "C#"
            },
            new Developer()
            {
                Name = "Django Developer",
                Age = 24,
                Id = 2,
                Salary = 565555,
                ProgrammingLang = "Django"
            }
        };
        foreach (var developer in developers)
        {
            developer.WriteCode();
            Console.WriteLine("---------");
        }
    }
}