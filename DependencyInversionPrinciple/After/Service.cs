namespace DependencyInversionPrinciple.After;

internal class Service
{
    private readonly IRepository _repository;

    public Service(IRepository repository)
    {
        _repository = repository;
    }

    public void DoWork()
    {
        Console.WriteLine("Work Done");
        _repository.Save();
    }
}
