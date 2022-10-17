using Fibonachi.Perfomace.Generator;
using Fibonachi.Perfomace.SequenceFinder;

namespace Fibonachi.Perfomace
{
    public class PeriodFinder
    {
        private readonly IFibanochiGenerator fibanochiGenerator;
        private readonly ISequenceFinder sequenceFinder;

        public PeriodFinder()
        {
            fibanochiGenerator = new FastGenerator();
            sequenceFinder = new FastSequenceFinder();
        }

        public int FindPeriod(int module)
        {
            fibanochiGenerator.Module = module;
            currentIndex = 0;

            int res = -1;
            do
            {
                Generate();

                res = sequenceFinder.FindBySameList(fibanochiGenerator.Sequence);

            } while (res == -1);

            return res;
        }

        private int currentIndex = 0;
        private void Generate(int count = 100)
        {
            currentIndex += count;
            fibanochiGenerator.Get(currentIndex);
        }
    }
}
