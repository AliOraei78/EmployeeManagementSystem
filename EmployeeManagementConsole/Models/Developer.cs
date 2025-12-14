public class Developer : Employee, IDevelop
{
    public string ProgrammingLang { get; set; } = string.Empty;

    public override void Work() => Console.WriteLine($"I want to learn C#.");

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I like dogs.");
    }

    public void WriteCode() => Console.WriteLine($"I am programming with {ProgrammingLang} language.");
}