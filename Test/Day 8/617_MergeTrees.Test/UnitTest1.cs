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

        static object[] TestCasesNodes =
        {
            new object[]
            {
                new int?[] { 1, 3, 2, 5 },
                new TreeNode(1, new TreeNode(3, new TreeNode(5)), new TreeNode(2))
            },
            new object[]
            {
                new int?[] { 2, 1, 3, null, 4, null, 7 },
                new TreeNode(2, new TreeNode(1, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(7)))
            }
        };

        static object[] TestCasesNodesArray =
        {
            new object[]
            {
                new TreeNode(1, new TreeNode(3, new TreeNode(5)), new TreeNode(2)),
                new int?[] { 1, 3, 2, 5 }
            },
            new object[]
            {
                new TreeNode(2, new TreeNode(1, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(7))),
                new int?[] { 2, 1, 3, null, 4, null, 7 }
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
            TreeNode node = new();
            var t1 = node.FromArray(ref root1);
            var t2 = node.FromArray(ref root2);
            var actual = solution.MergeTrees(t1, t2);
            var act = actual.ToArray();
            Assert.That(act, Is.EqualTo(expected));
        }

        [TestCaseSource(nameof(TestCasesNodes))]
        public void Test2(int?[] arr, TreeNode expected)
        {
            TreeNode node = new();
            var actual = node.FromArray(ref arr);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCaseSource(nameof(TestCasesNodesArray))]
        public void Test3(TreeNode node, int?[] expected)
        {
            var actual = node.ToArray();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}