//Interface Segregation Principle (ISP) :
//Clients shouldn’t be forced to depend on methods they do not use.

//Before :
//IWorker interface have 2 methods (Eat , Work) 
//we find 2 classes :
//  1 - 'Human' inheret IWorker interface so there implementation of Work and Eat Methods
//  2 - 'Robot' inheret IWorker interface
//          so there implementation of Work and NotImplementedException when you call Eat Methods

//After :
//old IWorker separation interface to 2 interfaces
//  1.'IWorkable' have Work method
//  2.'IEatable' have Eat method

//we find 2 classes :
//  1 - 'Human' inheret IWorkable interface so there implementation of Work Method
//          and inheret IEatable interface so there implementation of Eat Method
//  2 - 'Robot' inheret IWorkable interface so JUST there implementation of Work Method


#region Before

//InterfaceSegregationPrinciple
//    .Before.Robot Robot = new();

//Robot.Eat(); //throw exception ...

#endregion


#region After

InterfaceSegregationPrinciple
    .After.Robot Robot = new();

Robot.Eat(); //Compiled Time error ...

#endregion


