using Fibonachi;

internal partial class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.Write("Введите модуль:");
            string? input = Console.ReadLine();

            int module;

            if (int.TryParse(input, out module))
            {
                FibanochiPeriodFinder finder = new();

                try
                {
                    var value = finder.FindByModule(module);

                    Console.WriteLine($"Период последовательности: {value}");
                    Console.Write("\n\n\n");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            else
            {
                Console.WriteLine("некорректный ввод");
            }
        }
    }
}