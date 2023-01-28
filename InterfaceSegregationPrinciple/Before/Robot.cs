namespace InterfaceSegregationPrinciple.Before;

internal class Robot : IWorker
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Work() => Console.WriteLine($"{nameof(Human)} {nameof(Work)}");
}
