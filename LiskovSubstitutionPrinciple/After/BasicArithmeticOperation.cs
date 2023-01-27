namespace LiskovSubstitutionPrinciple.After;

internal abstract class BasicArithmeticOperation
{
    private int number;

    public virtual int Number
    {
        get { return number; }
        set { number = value; }
    }


    protected BasicArithmeticOperation(int number)
    {
        this.number = number;
    }

    public abstract int Add();
    public abstract int Subtract();
    public abstract int Multiply();

}
