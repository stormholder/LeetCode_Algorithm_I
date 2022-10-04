using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using PopulatingNext;

namespace _116_PopulatingNext.Test
{
    public class Tests
    {
        static object[] TestCases =
        {
            new object[]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                new char[] { '1', '#', '2', '3', '#', '4', '5', '6', '7', '#' }
            },
            new object[]
            {
                new int[] { },
                new char[] { }
            }
        };
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] root, char[] expected)
        {
            Solution solution = new Solution();
            var r = solution.ArrayToNode(root);
            var actual = solution.Connect(r);
            var act = solution.NodeToArray(actual);
            Assert.That(act, Is.EqualTo(expected));
        }
    }
}