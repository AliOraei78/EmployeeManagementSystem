public class Manager : Employee, IManageable
{
    public int TeamSize { get; set; }
    
    public override void Work()
    {
        Console.WriteLine($"I am managing the tech team.");
    }
    
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I like cats.");
    }

    public void ManageTeam()
    {
        Console.WriteLine($"I am managing {TeamSize} members.");
    }
}