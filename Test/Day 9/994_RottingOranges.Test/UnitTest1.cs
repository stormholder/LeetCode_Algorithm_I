using RottingOranges;

namespace _994_RottingOranges.Test
{
    public class Tests
    {
        static object[] TestCases =
        {
            new object[]
            {
                new int[][]
                {
                    new int[] { 2, 1, 1 },
                    new int[] { 1, 1, 0 },
                    new int[] { 0, 1, 1 },
                },
                4
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 2, 1, 1 },
                    new int[] { 1, 1, 0 },
                    new int[] { 1, 0, 1 },
                },
                -1
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 0, 2 }
                },
                0
            },
        };

        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[][] grid, int expected)
        {
            Solution solution = new();
            var actual = solution.OrangesRotting(grid);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}