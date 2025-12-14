public class InMemoryEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employees = new List<Employee>();

    public List<Employee> GetAll() => _employees;

    public void Add(Employee employee) => _employees.Add(employee);

    public Employee GetById(int id) => _employees.Find(x => x.Id == id);
}