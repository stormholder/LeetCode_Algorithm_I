using Squares;

namespace _977_Squares.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        static object[] TestCases =
        {
            new object[]
            {
                new int[] { -4, -1, 0, 3, 10 },
                new int[] { 0, 1, 9, 16, 100 }
            },
            new object[]
            {
                new int[] { -7, -3, 2, 3, 11 },
                new int[] { 4, 9, 9, 49, 121 }
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] nums, int[] expected)
        {
            Solution solution = new();
            var actual = solution.SortedSquares(nums);
            Assert.That(actual.Length, Is.EqualTo(expected.Length));
            Assert.That(actual.SequenceEqual(expected));
        }
    }
}