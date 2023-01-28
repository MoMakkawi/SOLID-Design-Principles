namespace InterfaceSegregationPrinciple.Before;

internal class Human : IWorker
{
    public void Eat() => Console.WriteLine($"{nameof(Human)} {nameof(Eat)}");
    public void Work() => Console.WriteLine($"{nameof(Human)} {nameof(Work)}");
}
