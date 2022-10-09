using Matrix;

namespace _542_Matrix.Test
{
    public class Tests
    {
        static object[] TestCases =
        {
            new object[]
            {
                new int[][]
                {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 1, 0 },
                    new int[] { 0, 0, 0 }
                },
                new int[][]
                {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 1, 0 },
                    new int[] { 0, 0, 0 }
                }
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 1, 0 },
                    new int[] { 1, 1, 1 }
                },
                new int[][]
                {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 1, 0 },
                    new int[] { 1, 2, 1 }
                }
            }
        };

        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[][] grid, int[][] expected)
        {
            Solution solution = new();
            var actual = solution.UpdateMatrix(grid);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}