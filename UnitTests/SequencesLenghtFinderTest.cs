using Fibonachi.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class SequencesLenghtFinderTest
    {
        SequencesLenghtFinder Finder;

        public SequencesLenghtFinderTest()
        {
            Finder = new();
        }

        [Fact]
        public void FindSeqenceWithsameNumbers()
        {
            List<int> nums = new List<int>() { 5, 5, 5, 5, 5, 5};

            int lenght = Finder.FindSequenceLenght(nums);

            Assert.Equal(3, lenght);
        }

        [Fact]
        public void FindSeqenceWithDifferentNumbers()
        {
            List<int> nums = new List<int>() { 5, 5, 6, 6, 5, 5, 6, 6 };

            int lenght = Finder.FindSequenceLenght(nums);

            Assert.Equal(4, lenght);
        }
    }
}
