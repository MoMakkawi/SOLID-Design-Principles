using SingleResponsibilityPrinciple.After.Models;

namespace SingleResponsibilityPrinciple.After.Services;

internal class TreeService
{
    public static void Grow(Tree tree)
    {
        tree.Height++;
        tree.Width++;
    }

    public static void Prune(Tree tree)
    {
        tree.Height--;
    }

    public static double CalculateArea(Tree tree)
    {
        return tree.Width * tree.Height;
    }

}
