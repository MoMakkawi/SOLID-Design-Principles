namespace SingleResponsibilityPrinciple.After.Models;

internal sealed class Tree
{
    public string Species { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public int Age { get; set; }
    public string Location { get; set; }

    public Tree(string species, double height, double width, int age, string location)
    {
        Species = species;
        Height = height;
        Width = width;
        Age = age;
        Location = location;
    }
    public override string? ToString()
    {
        return
            $"Tree Species = {Species} ," +
            $"Height = {Height} ," +
            $"Width = {Width} ," +
            $"Age = {Age} ," +
            $"Location = {Location} ,";
    }
}


