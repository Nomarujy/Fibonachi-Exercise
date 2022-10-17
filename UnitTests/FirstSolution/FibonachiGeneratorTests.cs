using Fibonachi.FirtSolution;
using UnitTests.Data;

namespace UnitTests.FirstSolution
{
    public class FibonachiGeneratorTests
    {
        private readonly FibonachiGenerator generator;

        public FibonachiGeneratorTests()
        {
            generator = new();
        }

        [Fact]
        public void FindNumber_Modele3_ReturnCorrectResult()
        {
            generator.Module = 3;

            foreach (var item in GeneratorDataProvider.TestData())
            {
                var result = generator.FindNumber(item[0]);

                Assert.Equal(item[1], result);
            }
        }
    }
}
