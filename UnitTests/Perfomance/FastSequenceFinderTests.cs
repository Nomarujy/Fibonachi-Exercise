using Fibonachi.Perfomace.SequenceFinder;

namespace UnitTests.FirstSolution
{
    public class FastSequenceFinderTests
    {
        private readonly FastSequenceFinder sequenceLenghtFinder;

        public FastSequenceFinderTests()
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

            var res = sequenceLenghtFinder.FindBySameList(nums);

            Assert.Equal(3, res);
        }

        [Fact]
        public void FindByList_Return5()
        {
            List<int> nums = new()
            {
                1, 1, 2, 3, 5, 1, 1, 2, 3, 5
            };

            var res = sequenceLenghtFinder.FindBySameList(nums);

            Assert.Equal(5, res);
        }

        [Fact]
        public void FindByList_SmallList_ReturnNegative()
        {
            List<int> nums = new()
            {
                1, 1, 2, 3, 5, 1, 1, 2, 3
            };

            var res = sequenceLenghtFinder.FindBySameList(nums);

            Assert.Equal(-1, res);
        }
    }
}
