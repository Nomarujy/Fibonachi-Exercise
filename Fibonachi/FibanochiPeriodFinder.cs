using Fibonachi.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int FindPeriodByModule(int module)
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
            for (int i = NumStorage.Count; i < NumStorage.Count + count; i++)
            {
                int number = generator.FindNumber(i);
                Console.WriteLine($"Generated {i}: {number}");
                NumStorage.Add(number);
            }
        }
    }
}
