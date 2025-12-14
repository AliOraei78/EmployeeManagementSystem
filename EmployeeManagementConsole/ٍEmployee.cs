public abstract class Employee : Person
{
    public int Id { get; set; }
    public long Salary { get; set; }

    public override void Introduce() 
    {
        base.Introduce();
    }

    public abstract void Work();
}
