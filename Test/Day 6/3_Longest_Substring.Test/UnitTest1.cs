using LongestSubstring;

namespace _3_Longest_Substring.Test
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
                "abcabcbb",
                3
            },
            new object[]
            {
               "bbbbb",
                1
            },
            new object[]
            {
                "pwwkew",
                3
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(string s, int expected)
        {
            Solution solution = new();
            var actual = solution.LengthOfLongestSubstring(s);
            Assert.That(actual,Is.EqualTo(expected));
        }
    }
}