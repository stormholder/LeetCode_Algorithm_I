using RotateArray;

namespace _189_Rotate_Array.Test
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
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                3,
                new int[] { 5, 6, 7, 1, 2, 3, 4 }
            },
            new object[]
            {
                new int[] { -1, -100, 3, 99 },
                2,
                new int[] { 3, 99, -1, -100 }
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] nums, int k, int[] expected)
        {
            Solution solution = new();
            solution.Rotate(nums, k);
            Assert.That(nums.SequenceEqual(expected));
        }
    }
}