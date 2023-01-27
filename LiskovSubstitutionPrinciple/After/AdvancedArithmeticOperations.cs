namespace LiskovSubstitutionPrinciple.After;

internal abstract class AdvancedArithmeticOperations : BasicArithmeticOperation
{
    protected AdvancedArithmeticOperations(int number) 
        : base(number)
    {
    }

    public abstract float Divide();
    public abstract float Modulo();
}
