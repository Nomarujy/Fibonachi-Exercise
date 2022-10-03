using Fibonachi;
using Fibonachi.Utilites;

partial class Program
{
    static void Main()
    {
        Console.Write("Введите модуль:");
        string? input = Console.ReadLine();

        int module;

        if (int.TryParse(input, out module))
        {
            FibanochiLenghtFinder finder = new(module);

            var value = finder.Find();

            Console.WriteLine($"Sequence lenght is {value}");
        }
        else
        {
            Console.WriteLine("некорректный ввод");
        }

        Console.ReadKey();
    } 
}