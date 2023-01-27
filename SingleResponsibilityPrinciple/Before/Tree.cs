namespace SingleResponsibilityPrinciple.Before;

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


    public void Grow()
    {
        Height++ ;
        Width++;

    }
    public void Prune()
    {
        Width -= 1;
    }
    public double CalculateArea() => Width * Height;
    public void AddLocation(string location)
    {
        Location = location;
    }
    public void RemoveLocation()
    {
        Location = string.Empty;
    }

    public override string? ToString()
    {
        return
            $"Tree Species = {Species} ," +
            $"Height = {Height} ," +
            $"Width = {Width} ," +
            $"Age = {Age} ," +
            $"Location = {Location} ," +
            $"Area = {CalculateArea()}";
    }
}

