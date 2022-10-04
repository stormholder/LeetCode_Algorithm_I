using MergeTrees;

namespace _617_MergeTrees.Test
{
    public class Tests
    {
        static object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 3, 2, 5 },
                new int?[] { 2, 1, 3, null, 4, null, 7 },
                new int?[] { 3, 4, 5, 5, 4, null, 7 }
            },
            new object[]
            {
                new int?[] { 1 },
                new int?[] { 1, 2 },
                new int?[] { 2, 2 }
            }
        };

        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int?[] root1, int?[] root2, int?[] expected)
        {
            Solution solution = new();
            var actual = solution.MergeTrees(solution.ArrayToTreeNode(root1), solution.ArrayToTreeNode(root2));
            Assert.That(solution.TreeNodeToArray(actual), Is.EqualTo(expected));
        }
    }
}