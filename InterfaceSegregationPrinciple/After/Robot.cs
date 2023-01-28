namespace InterfaceSegregationPrinciple.After;

internal class Robot 
    : IWorkable
{
    public void Work() => Console.WriteLine($"{nameof(Human)} {nameof(Work)}");
}
