using SingleResponsibilityPrinciple.After.Models;

namespace SingleResponsibilityPrinciple.After.Services;

internal class LocationService
{
    public static void Add(Tree tree, string location)
    {
        tree.Location = location;
    }
    public static void Remove(Tree tree)
    {
         tree.Location = string.Empty;
    }
}
