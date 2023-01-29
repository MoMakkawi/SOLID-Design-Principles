namespace DependencyInversionPrinciple.After;

internal class Repository : IRepository
{
    public void Save()
    {
        Console.WriteLine("Saved to the database");
    }
}
