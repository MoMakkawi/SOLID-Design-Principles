//Dependency Inversion Principle (DIP) :
//High-level classes shouldn’t depend on low-level classes.
//Both should depend on abstractions.
//Abstractions shouldn’t depend on details.
//Details should depend on abstractions.


//Before : 
//the 'Service' class has a hard-coded dependency on the 'Repository' class.
//The 'Service' class creates an instance of the 'Repository' class within its constructor.
//This tight coupling makes it difficult to change or test the Service class
//without affecting the 'Repository' class.


//After : 
//the 'IRepository' interface is introduced to decouple the 'Service' class from the 'Repository' class.
//The 'Service' class accepts an instance of 'IRepository' as a parameter in its constructor,
//making it less tightly coupled to the 'Repository' class.
//This makes it easier to change or test the 'Service' class without affecting the 'Repository' class.


#region Before

//DependencyInversionPrinciple
//    .Before.Service service = new();

//service.DoWork();

#endregion


#region After

using DependencyInversionPrinciple.After;

Repository repository = new();
Service service = new(repository);

service.DoWork();

#endregion

