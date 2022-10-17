namespace UnitTests.Data
{
    public static class GeneratorDataProvider
    {
        public static IEnumerable<int[]> TestData()
        {
            yield return new int[] { 0, 1 };
            yield return new int[] { 1, 1 };
            yield return new int[] { 2, 2 };
            yield return new int[] { 3, 0 };
            yield return new int[] { 4, 2 };
            yield return new int[] { 5, 2 };
            yield return new int[] { 6, 1 };
            yield return new int[] { 7, 0 };
            yield return new int[] { 8, 1 };
            yield return new int[] { 9, 1 };
        }
    }
}
