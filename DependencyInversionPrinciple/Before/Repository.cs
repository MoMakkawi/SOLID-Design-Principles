namespace DependencyInversionPrinciple.Before;

internal class Repository
{
    public void Save()
    {
        Console.WriteLine("Saved to the database");
    }
}
