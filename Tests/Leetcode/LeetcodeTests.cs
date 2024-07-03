using DSA.Src.Leetcode;

namespace DSA.Tests.Leetcode;

public class LeetcodeTests
{
    [Fact]
    public void TwoSum1()
    {
        var input = new int[] { 1, 2, 3, 5, 6, 7 };
        var test1 = TwoSum.TooSum(input, 3);
        var test2 = TwoSum.TooSumChallenge(input, 6);
        Console.WriteLine("Lazy test writing");
    }


    /*
    var l1 = new ListNode()
        {
            val = 1,
            next = new ListNode()
            {
                val = 2,
            }
        };

        var l2 = new ListNode()
        {
            val = 0,
            next = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 8,
                }
            }
        };
    */
    [Fact]
    public void AddTooNumbers2()
    {
        var l1 = new ListNode()
        {
            val = 2,
            next = new ListNode()
            {
                val = 4,
                next = new ListNode()
                {
                    val = 5,
                }
            }
        };

        var l2 = new ListNode()
        {
            val = 5,
            next = new ListNode()
            {
                val = 6,
                next = new ListNode()
                {
                    val = 4,
                }
            }
        };
        var l3 = AddTwoNumbers.AddTooNumbers(l1, l2);
        Console.WriteLine("");
    }
}
