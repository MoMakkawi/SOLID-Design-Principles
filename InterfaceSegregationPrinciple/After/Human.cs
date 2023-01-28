namespace InterfaceSegregationPrinciple.After;

internal class Human 
    : IEatable , IWorkable
{
    public void Eat() => Console.WriteLine($"{nameof(Human)} {nameof(Eat)}");
    public void Work() => Console.WriteLine($"{nameof(Human)} {nameof(Work)}");
}
