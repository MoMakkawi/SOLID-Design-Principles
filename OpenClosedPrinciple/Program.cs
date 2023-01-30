//Open/Closed Principle (OCP) : Classes should be open for extension but closed for modification.

/*
The main idea of this principle is to keep existing code from
breaking when you implement new features.
A class is open if you can extend it, produce a subclass and
do whatever you want with it—add new methods or fields,
override base behavior, etc. 
- Alexander Shvets

when Aritcle class have sooo many validation :
befor OCP: 
    I implement My Validations in setters of Article class , Over time it will become difficult to maintain .
After OCP:
    I Apply OCP by implement Pipline Pattern to validate , It is now easy to add any validations to any field in the class
 */


#region Before

//var veryOldArticle = new OpenClosedPrinciple.Before.Article(
//    "OCP",
//    "Makkai",
//    "Open/Closed Design principle ," +
//    "I am confuse because the words open & closed sound mutually exclusive.",
//    new DateTime(2019, 10, 10));

//codebase wasn't good
//will throw excption becouse the date pass from more than year 

#endregion


#region After
var newArticle = new OpenClosedPrinciple.After.Article(
    "OCP",
    "Makkai",
    "Open/Closed Design principle ," +
    " Classes should be open for extension but closed for \r\n modification.",
    new DateTime(2003, 10, 10));

if(!newArticle.IsValid)
    Console.WriteLine(newArticle.msg);

//codebase very good
#endregion


