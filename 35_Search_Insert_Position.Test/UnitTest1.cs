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
                new int[] { 1,3,5,6 },
                2,
                1
            },
            new object[]
            {
                new int[] { 1,3,5,6 },
                7,
                4
            },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] nums, int target, int expenced)
        {
            Assert.Pass();
        }
    }
}