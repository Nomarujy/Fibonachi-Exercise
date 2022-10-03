using Fibonachi;
using Fibonachi.Utilites;

partial class Program
{
    static void Main()
    {
        FibanochiLenghtFinder finder = new(5);

        var value = finder.Find();

        Console.WriteLine($"Sequence lenght is {value}");
    } 
}