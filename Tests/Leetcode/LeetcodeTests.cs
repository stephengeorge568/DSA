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
}
