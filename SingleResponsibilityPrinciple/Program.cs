//The Single Responsibility Principle (SRP) is a SOLID principle
//that states that a class or module should have only one reason to change.
//This means that a class should have a single, well-defined responsibility,
//and that responsibility should be entirely encapsulated by the class.
//This principle helps to promote loose coupling and high cohesion in software design,
//making the code more maintainable and less prone to bugs.By adhering to SRP,
//a developer can make changes to a class without affecting other parts of the codebase,
//and can also more easily test and understand the class's behavior.

#region Before SRP
//using SingleResponsibilityPrinciple.Before;

//var tree1 = new Tree("Oak", 20, 10, 15, "Backyard");
//var tree2 = new Tree("Pine", 30, 15, 20, "Park");
//var tree3 = new Tree("Maple", 25, 12, 18, "Street");
//var tree4 = new Tree("Birch", 18, 8, 12, "Garden");
//var tree5 = new Tree("Hickory", 40, 25, 30, "Backyard");
//var tree6 = new Tree("Oak", 20, 10, 15, "Backyard");

//List<Tree> trees = new() { tree1 , tree2, tree3, tree4, tree5, tree6 };

//trees.ForEach(t => Console.WriteLine(t));
#endregion

/*
 * The Tree previous code does not fully adhere to the Single Responsibility Principle (SRP)
 * The class has methods that are responsible for different actions 
 * such as growing the tree, pruning the tree, calculating the area of the tree,
 * adding and removing a location.
 */

#region After SRP
using SingleResponsibilityPrinciple.After.Models;
using SingleResponsibilityPrinciple.After.Services;

var tree1 = new Tree("Oak", 20, 10, 15, "Backyard");
var tree2 = new Tree("Pine", 30, 15, 20, "Park");
var tree3 = new Tree("Maple", 25, 12, 18, "Street");
var tree4 = new Tree("Birch", 18, 8, 12, "Garden");
var tree5 = new Tree("Hickory", 40, 25, 30, "Backyard");
var tree6 = new Tree("Oak", 20, 10, 15, "Backyard");

List<Tree> trees = new() { tree1, tree2, tree3, tree4, tree5, tree6 };

LocationService.Remove(tree2);

trees.ForEach(t => Console.WriteLine(t.ToString() + " Area = " + TreeService.CalculateArea(t))) ;

#endregion

/*There are 2 Folders :
 * 1': Models contain Tree sealed class 
 * 2': Services contain TreeService and LocationService sealed classes
 *      2'.1: TreeService contain Grow , Prune , CalculateArea static functions
 *      2'.2: LocationService contain Add , Remove static functions
 *____________
 *
 * The 'Tree' class only contains data, we can assume it does not have any behavior.
 * This class can be used for storing information about a tree,
 * but it does not have any logic for growing,
 * pruning or calculating the area of the tree.
 * 
 * The 'TreeService' sealed class contain static helper methods 
 * The 'LocationService' sealed class contain static helper methods 
 * 
 * Note : Adding a 'ToString' function to a class is considered as adding behavior to the class,
 * but it is not necessarily a violation of the Single Responsibility Principle (SRP).
 * The ToString method is used to convert an object's properties to a string representation,
 * which is often used for debugging or logging purposes.
 * As long as the ToString method is only responsible for this specific behavior
 * and does not include any other logic or functionality,
 * it should not be considered a violation of SRP.
 */