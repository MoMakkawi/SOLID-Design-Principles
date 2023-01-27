//Liskov Substitution Principle (LSP) :
//A subclass should be able to replace its superclass
//without affecting the correctness of the program.

/*
Proplem : we want to add 2 classes class to apply arithmetic operations 
          (add , Subtract , Multiply , Divide , Modulo )
            1': apply those operations on 11 
            2': apply those operations on Zero except Divide and Modulo 
*/

/*
- Befor - Bad way :

    create ArithmeticOperation abstract class have :
arithmetic operations(add, Subtract, Multiply, Divide, Modulo) as abstract methods

    create 2 classes: inherets from ArithmeticOperation
ArithmeticOperationWith11 seald class : override all operations
ArithmeticOperationWithZero seald class : override all operations, throw exception on Divide and Modulo
 */




#region Befor


//LiskovSubstitutionPrinciple.
//    Before.ArithmeticOperationWithZero OperationTenWithZero= new(10);

//Console.WriteLine("Add 10 to 0 = "+ OperationTenWithZero.Add());
//Console.WriteLine("Divide 10 by 0 = "+OperationTenWithZero.Divide()); //throw ArithmeticException
#endregion

/*
- After - good way :

    splite old ArithmeticOperation abstract class to 2 abstract classes :
BasicArithmeticOperation contains (add, Subtract, Multiply) as abstract methods
AdvancedArithmeticOperations contains (Divide, Modulo) as abstract methods 

Note: AdvancedArithmeticOperations inheret BasicArithmeticOperation

    create 2 classes:
ArithmeticOperationWith11 seald class : 
    inhert AdvancedArithmeticOperations so override all operations 
    (add, Subtract, Multiply, Divide, Modulo)
ArithmeticOperationWithZero seald class :
    inhert BasicArithmeticOperation so override just (add, Subtract, Multiply) operations
 */

#region After
LiskovSubstitutionPrinciple.
    After.ArithmeticOperationWithZero OperationTenWithZero = new(10);

Console.WriteLine("Add 10 to 0 = " + OperationTenWithZero.Add());
Console.WriteLine("Divide 10 by 0 = " + OperationTenWithZero.Divide()); //Compiled time error 

#endregion