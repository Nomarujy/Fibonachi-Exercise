using Fibonachi.Utilites;

namespace Fibonachi
{
    public class FibanochiPeriodFinder
    {
        private readonly FibonachiGenerator generator;
        private readonly SequenceLenghtFinder sequenceLenghtFinder;

        public FibanochiPeriodFinder()
        {
            generator = new();
            sequenceLenghtFinder = new();
        }

        public int FindByModule(int module)
        {
            List<int> NumStorage = new();
            generator.Module = module;

            int period;
            do
            {
                GenerateNumbers(NumStorage, 10);

                period = sequenceLenghtFinder.FindByList(NumStorage);

            } while (period == -1);

            return period;
        }

        private void GenerateNumbers(List<int> NumStorage, int count)
        {
            int countAfterGenerating = NumStorage.Count + count;

            for (int i = NumStorage.Count; i < countAfterGenerating; i++)
            {
                int number = generator.FindNumber(i);
                Console.WriteLine($"Generated {i}: {number}");
                NumStorage.Add(number);
            }
        }
    }
}
