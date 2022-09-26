using BinarySearch;

namespace _704_Binary_Search.Test
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
                new int[] {-1,0,3,5,9,12},
                9,
                4
            },
            new object[]
            {
                new int[] {-1,0,3,5,9,12},
                2,
                -1
            },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] nums, int target, int expected)
        {
            Solution solution = new();
            var actual = solution.Search(nums, target);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}