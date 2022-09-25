using RemoveNthNode;

namespace _19_Remove_Nth_Node.Test
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
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
                2,
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))))
            },
            new object[]
            {
                new ListNode(1),
                1,
                new ListNode()
            },
            new object[]
            {
                new ListNode(1, new ListNode(2)),
                1,
                new ListNode(1)
            },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(ListNode head, int n, ListNode expected)
        {
            Solution solution = new();
            var actual = solution.RemoveNthFromEnd(head, n);
            List<int> exp = new();
            List<int> act = new();
            solution.ToList(ref exp, expected);
            solution.ToList(ref act, actual);
            Assert.That(exp, Is.EquivalentTo(act));
        }
    }
}