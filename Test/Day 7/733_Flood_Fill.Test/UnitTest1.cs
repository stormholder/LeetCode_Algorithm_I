using FloodFill;

namespace _733_Flood_Fill.Test
{
    public class Tests
    {
        static object[] TestCases =
        {
            new object[]
            {
                new int[][] {
                    new int[] { 1, 1, 1 },
                    new int[] { 1, 1, 0 },
                    new int[] { 1, 0, 1 }
                },
                1,
                1,
                2,
                new int[][] {
                    new int[] { 2, 2, 2 },
                    new int[] { 2, 2, 0 },
                    new int[] { 2, 0, 1 }
                }
            },
            new object[]
            {
                new int[][] {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 0, 0 }
                },
                0,
                0,
                0,
                new int[][] {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 0, 0 }
                }
            }
        };

        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[][] image, int sr, int sc, int color, int[][] expected)
        {
            Solution solution = new();
            var actual = solution.FloodFill(image, sr, sc, color);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}