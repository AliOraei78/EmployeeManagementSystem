public class Intern : Employee
{
    public override void Work()
    {
        //throw new Exception("Intern does not work!"); => LSP violation
        Console.WriteLine("Intern is educating...");
    }
}
