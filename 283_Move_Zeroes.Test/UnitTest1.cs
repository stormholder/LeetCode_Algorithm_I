using MoveZeroes;

namespace _283_Move_Zeroes.Test
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
                new int[] { 0, 1, 0, 3, 12 },
                new int[] { 1, 3, 12, 0, 0 }
            },
            new object[]
            {
                new int[] { 0 },
                new int[] { 0 }
            },
            new object[]
            {
                new int[] { 1 },
                new int[] { 1 }
            },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] nums, int[] expected)
        {
            Solution solution = new();
            solution.MoveZeroes(nums);
            Assert.That(nums.SequenceEqual(expected));
        }
    }
}