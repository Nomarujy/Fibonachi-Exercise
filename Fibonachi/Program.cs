using Fibonachi;
using Fibonachi.Utilites;

partial class Program
{
    static void Main()
    {
        Console.Write("Введите модуль:");
        string? input = Console.ReadLine();

        int module;

        /*if (int.TryParse(input, out module))
        {
            FibanochiPeriodFinder finder = new();

            var value = finder.Find(module);

            Console.WriteLine($"Sequence lenght is {value}");
        }
        else
        {
            Console.WriteLine("некорректный ввод");
        }*/

        Console.ReadKey();
    } 
}