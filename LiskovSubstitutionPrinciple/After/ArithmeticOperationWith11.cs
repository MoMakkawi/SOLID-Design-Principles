namespace LiskovSubstitutionPrinciple.After;

internal sealed class ArithmeticOperationWith11 : AdvancedArithmeticOperations
{
    public override int Number { get => base.Number ; set => base.Number = value; }
    public ArithmeticOperationWith11(int number) 
        : base(number)
    {
    }

    public override int Add() => Number + 11;
    public override int Subtract() => Number - 11;
    public override float Divide() => Number / 11;
    public override float Modulo() => Number % 11;
    public override int Multiply() => Number * 11;
}
