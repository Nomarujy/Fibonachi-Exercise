using Fibonachi;

namespace UnitTests
{
    public class FibanochiGeneratorTest
    {
        private readonly FibonachiGenerator Generator;

        public FibanochiGeneratorTest()
        {
            Generator = new();
        }


        [Theory, MemberData(nameof(TestData))]
        public void WithModule3(int x, int expect)
        {
            Generator.Module = 3;

            var res = Generator.FindNumber(x);

            Assert.Equal(expect, res);
        }

        private static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 0, 1 };
            yield return new object[] { 1, 1 };
            yield return new object[] { 2, 2 };
            yield return new object[] { 3, 0 };
            yield return new object[] { 4, 2 };
            yield return new object[] { 5, 2 };
            yield return new object[] { 6, 1 };
            yield return new object[] { 7, 0 };
            yield return new object[] { 8, 1 };
            yield return new object[] { 9, 1 };
        }
    }
}