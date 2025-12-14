public class CompanyLogger
{
    public static readonly Lazy<CompanyLogger> _instance = new Lazy<CompanyLogger>(() => new CompanyLogger());

    private CompanyLogger() 
    { 
    }

    public static CompanyLogger Instance => _instance.Value;

    public void Log(string message)
    {
        Console.WriteLine($"[LOG {DateTime.Now:HH:mm:ss}] {message}");
    }
}