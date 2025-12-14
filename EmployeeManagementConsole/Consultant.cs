public class Consultant : Employee, IAdvise
{
    public string Field { get; set; } = string.Empty;

    public override void Work() => Console.WriteLine($"I am a data and statistics consultant.");

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I like birds.");
    }

    public void Advise() => Console.WriteLine($"I am advising the company to achieve better {Field}.");
}