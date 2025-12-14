public class Developer : Employee, IDevelop
{
    public string ProgrammingLang { get; set; } = string.Empty;

    public override void Work()
    {
        Console.WriteLine($"I am working with C#.");
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I like programming.");
    }

    public void WriteCode()
    {
        Console.WriteLine($"I am programming with {ProgrammingLang} language.");
    }
}