using ReverseString;

namespace _344_Reverse_String.Test
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
                new char[] { 'h', 'e', 'l', 'l', 'o' },
                new char[] { 'o', 'l', 'l', 'e', 'h' }
            },
            new object[]
            {
                new char[] { 'H', 'a', 'n', 'n', 'a', 'h' },
                new char[] { 'h', 'a', 'n', 'n', 'a', 'H' }
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(char[] s, char[] expected)
        {
            Solution solution = new();
            solution.ReverseString(s);
            Assert.That(s.SequenceEqual(expected));
        }
    }
}