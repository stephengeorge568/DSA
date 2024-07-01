namespace DSA.Src.Leetcode;

public class TwoSum
{
    /*
        https://leetcode.com/problems/two-sum/
        Given:
            1 valid answer in nums
            nums length >= 2
            targets and nums values big negative and small positive
        First Solution: 
            check each element sequentially, and try to find a subsequent element 
            that adds up to target.
            O(n^2)
    */
    public static int[] TooSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i,j];
                }
            }
        }
        throw new Exception("Bad input?");
    }

    // O(n)
    // much better. remembers what value to look for so only 1 loop over array is necessary
    // only about 70-80% efficency though so what am i missing.
    // looks like this is as good as it gets. :thumbsup:
    public static int[] TooSumChallenge(int[] nums, int target)
    {
        var intsToLookFor = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (intsToLookFor.ContainsKey(nums[i]))
            {
                return [intsToLookFor[nums[i]],i];
            }
            intsToLookFor[target - nums[i]] = i;
        }
        throw new Exception("Bad input?");
    }
}
