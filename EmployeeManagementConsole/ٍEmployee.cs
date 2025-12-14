public class Employee : Person
{
    public int Id { get; set; }
    public long Salary { get; set; }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"My id is {Id} and my salary is {Salary}.");
    }

    public virtual void Work()
    {
        Console.WriteLine($"I am working.");
    }
}
