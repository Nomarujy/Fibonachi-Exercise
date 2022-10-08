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
                if (module < 1)
                {
                    PrintIncorectInput();
                    continue;
                }

                try
                {
                    FibanochiPeriodFinder finder = new();

                    var value = finder.FindByModule(module);

                    Console.WriteLine($"Период последовательности: {value}\n");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            else
            {
                PrintIncorectInput();
            }
        }
    }

    private static void PrintIncorectInput() => Console.WriteLine("Некорректный ввод\n");
}