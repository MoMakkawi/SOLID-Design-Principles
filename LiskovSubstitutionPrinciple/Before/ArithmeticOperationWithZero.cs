namespace LiskovSubstitutionPrinciple.Before
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

        public override float Divide()
        {
            throw new ArithmeticException($"You cannot do {nameof(Divide)} on Zero");
        }

        public override float Modulo()
        {
            throw new ArithmeticException($"You cannot do {nameof(Modulo)} on Zero");
        }


    }
}
