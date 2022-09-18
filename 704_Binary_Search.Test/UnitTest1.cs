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
                new object[] {-1,0,3,5,9,12},
                9,
                4
            },
            new object[]
            {
                new object[] {-1,0,3,5,9,12},
                2,
                -1
            },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1()
        {
            Solution solution = new();
            Assert.Pass();
        }
    }
}