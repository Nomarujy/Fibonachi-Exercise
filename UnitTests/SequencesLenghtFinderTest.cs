using Fibonachi.Utilites;

namespace UnitTests
{
    public class SequencesLenghtFinderTest
    {
        private readonly SequenceLenghtFinder Finder;

        public SequencesLenghtFinderTest()
        {
            Finder = new();
        }

        [Fact]
        public void ReturnNegativeIfSequenceNotRepetable()
        {
            List<int> nums = new List<int>() { 5, 5, 5, 6, 5, 5 };

            int lenght = Finder.FindByList(nums);

            Assert.Equal(-1, lenght);
        }

        [Fact]
        public void ReturnMinimalSequenceLenght()
        {
            List<int> nums = new List<int>() { 5, 5, 5, 5, 5, 5 };
            Finder.MinimalSequenceLenght = 2;

            int lenght = Finder.FindByList(nums);

            Assert.Equal(2, lenght);
        }

        [Fact]
        public void ReturnNegativeIfSizeNotEnough()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 1, 2, 3 };

            int lenght = Finder.FindByList(nums);

            Assert.Equal(-1, lenght);
        }

        [Fact]
        public void ReturnSizeIfSizeEnough()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 1, 2, 3, 4 };

            int lenght = Finder.FindByList(nums);

            Assert.Equal(4, lenght);
        }
    }
}
