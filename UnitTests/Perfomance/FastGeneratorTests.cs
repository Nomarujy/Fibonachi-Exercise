using Fibonachi.Perfomace.Generator;
using UnitTests.Data;

namespace UnitTests.Perfomance
{
    public class FastGeneratorTests
    {
        private readonly FastGenerator generator;

        public FastGeneratorTests()
        {
            generator = new();
        }

        [Fact]
        public void Get_WithModule3_CorrectResult()
        {
            generator.Module = 3;

            foreach (var item in GeneratorDataProvider.TestData())
            {
                var result = generator.Get(item[0]);

                Assert.Equal(item[1], result);
            }
        }
    }
}
