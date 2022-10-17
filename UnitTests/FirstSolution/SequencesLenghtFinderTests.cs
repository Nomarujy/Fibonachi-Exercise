using Fibonachi.FirtSolution;

namespace UnitTests.FirstSolution
{
    public class SequencesLenghtFinderTests
    {
        private readonly SequenceLenghtFinder sequenceLenghtFinder;

        public SequencesLenghtFinderTests()
        {
            sequenceLenghtFinder = new();
        }

        [Fact]
        public void FindByList_Return3()
        {
            List<int> nums = new()
            {
                1, 1, 2, 1, 1, 2
            };

            var res = sequenceLenghtFinder.FindByList(nums);

            Assert.Equal(3, res);
        }

        [Fact]
        public void FindByList_Return5()
        {
            List<int> nums = new()
            {
                1, 1, 2, 3, 5, 1, 1, 2, 3, 5
            };

            var res = sequenceLenghtFinder.FindByList(nums);

            Assert.Equal(5, res);
        }
    }
}
