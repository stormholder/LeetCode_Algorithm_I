using TwoSum2;

namespace _167_Two_Sum_2.Test
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
                new int[] { 2, 7, 11, 15 },
                9,
                new int[] { 1, 2 }
            },
            new object[]
            {
                new int[] { 2, 3, 4 },
                6,
                new int[] { 1, 3 }
            },
            new object[]
            {
                new int[] { -1, 0 },
                -1,
                new int[] { 1, 2 }
            },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] numbers, int target, int[] expected)
        {
            Solution solution = new();
            var actual = solution.TwoSum(numbers, target);
            Console.WriteLine( $"{string.Join(',', actual)} =?= {string.Join(',', expected)}" );
            Assert.That(actual.SequenceEqual(expected));
        }
    }
}