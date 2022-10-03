using Fibonachi.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    public class FibanochiLenghtFinder
    {
        private readonly FibonachiGenerator generator;
        private readonly SequencesLenghtFinder Finder;
        private readonly List<int> NumStorage;

        private int generatorIndex;

        public FibanochiLenghtFinder(int module)
        {
            generator = new(module);
            Finder = new();
            NumStorage = new();

            generatorIndex = 0;
        }

        public int Find()
        {
            while (true)
            {
                GenerateNumber(25);

                try
                {
                    int lenght = Finder.FindSequenceLenght(NumStorage);

                    if (lenght != -1)
                    {
                        return lenght;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void GenerateNumber(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int number = generator.FindNumber(generatorIndex++);
                Console.WriteLine($"Generated {generatorIndex}: {number}");
                NumStorage.Add(number);
            }
        }
    }
}
