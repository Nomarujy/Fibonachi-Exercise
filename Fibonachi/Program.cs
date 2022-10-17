using Fibonachi.Perfomace;

internal partial class Program
{
    private static void Main()
    {
        PeriodFinder finder = new();

        while (true)
        {
            Console.Write("Введите модуль:");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int module))
            {
                if (module < 2)
                {
                    PrintIncorectInput();
                    continue;
                }

                int value = finder.FindPeriod(module);

                Console.WriteLine($"Период последовательности: {value}\n");
            }
            else
            {
                PrintIncorectInput();
            }
        }
    }

    private static void PrintIncorectInput() => Console.WriteLine("Некорректный ввод\n");
}