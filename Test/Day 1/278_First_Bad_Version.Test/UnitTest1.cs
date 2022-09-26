using FirstBadVersion;

namespace _278_First_Bad_Version.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        static object[] TestCases =
        {
            new object[] { 5, 4, 4 },
            new object[] { 1, 1, 1 }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int versions, int bad, int expected)
        {
            Solution solution = new Solution() { Bad = bad };
            var actual = solution.FirstBadVersion(versions);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}