namespace DependencyInversionPrinciple.Before;

internal class Service
{
    private Repository _repository;

    public Service()
    {
        //hard-coded dependency
        _repository = new Repository();
    }

    public void DoWork()
    {
        Console.WriteLine("Work Done");
        _repository.Save();
    }
}