using MaxIsland;

namespace _695_Max_Island.Test
{
    public class Tests
    {
        static object[] TestCases =
        {
            new object[]
            {
                new int[][] {
                    new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                    new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                    new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                    new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                    new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                    new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
                },
                6
            },
            new object[]
            {
                new int[][] {
                    new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }
                },
                0
            },
            new object[]
            {
                new int[][] {
                    new int[] { 1, 1, 0, 0, 0 },
                    new int[] { 1, 1, 0, 0, 0 },
                    new int[] { 0, 0, 0, 1, 1 },
                    new int[] { 0, 0, 0, 1, 1 }
                },
                4
            }
        };

        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[][] grid, int expected)
        {
            Solution solution = new();
            var actual = solution.MaxAreaOfIsland(grid);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}