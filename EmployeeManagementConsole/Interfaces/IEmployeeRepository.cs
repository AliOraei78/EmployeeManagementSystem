public interface IEmployeeRepository
{
    List<Employee> GetAll();
    void Add(Employee employee);
    Employee GetById(int id);
}