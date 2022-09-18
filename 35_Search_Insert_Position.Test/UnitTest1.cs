using SearchInsertPosition;

namespace _35_Search_Insert_Position.Test
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
                new int[] { 1,3,5,6 },
                5,
                2
            },
            new object[]
            {
                new int[] { 1, 3, 5, 6 },
                2,
                1
            },
            new object[]
            {
                new int[] { 1, 3, 5, 6 },
                7,
                4
            },
            new object[]
            {
                new int[] { 1, 3 },
                1,
                0
            },
            new object[]
            {
                new int[] { 1, 3 },
                0,
                0
            },
            new object[]
            {
                new int[] { 1, 3, 5 },
                2,
                1
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] nums, int target, int expenced)
        {
            Solution solution = new();
            var actual = solution.SearchInsert(nums, target);
            Assert.That(actual, Is.EqualTo(expenced));
        }
    }
}