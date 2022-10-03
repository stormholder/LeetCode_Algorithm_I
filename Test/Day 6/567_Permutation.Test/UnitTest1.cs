using Permutation;

namespace _567_Permutation.Test
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
                "ab",
                "eidbaooo",
                true
            },
            new object[]
            {
                "ab",
                "eidboaoo",
                false
            },
            new object[]
            {
                "adc",
                "dcda",
                true
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(string s1, string s2, bool expected)
        {
            Solution solution = new();
            var actual = solution.CheckInclusion(s1, s2);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}