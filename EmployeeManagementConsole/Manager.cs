public class Manager : Employee
{
    public int TeamSize { get; set; }
    
    public override void Work()
    {
        Console.WriteLine($"I am managing {TeamSize} members.");
    }
}