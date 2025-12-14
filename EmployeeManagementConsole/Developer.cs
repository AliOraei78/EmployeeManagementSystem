public class Developer : Employee
{
    public string ProgrammingLang { get; set; } = string.Empty;

    public override void Work()
    {
        Console.WriteLine($"I am programming with {ProgrammingLang} language.");
    }
}