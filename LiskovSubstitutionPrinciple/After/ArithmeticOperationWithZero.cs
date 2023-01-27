namespace LiskovSubstitutionPrinciple.After
{
    internal sealed class ArithmeticOperationWithZero : BasicArithmeticOperation
    {
        public override int Number { get => base.Number ; set => base.Number = value; }
        public ArithmeticOperationWithZero(int number) 
            : base(number)
        {
        }

        public override int Add() => Number + 0;
        public override int Multiply() => Number * 0;
        public override int Subtract() => Number - 0;
    }
}
