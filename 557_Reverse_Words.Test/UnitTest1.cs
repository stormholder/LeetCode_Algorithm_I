using ReverseWords;

namespace _557_Reverse_Words.Test
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
                "Let's take LeetCode contest",
                "s'teL ekat edoCteeL tsetnoc"
            },
            new object[]
            {
                "God Ding",
                "doG gniD"
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(string s, string expected)
        {
            Solution solution = new();
            var actual = solution.ReverseWords(s);
            Assert.That(actual.Equals(expected));
        }
    }
}