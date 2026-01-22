public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] res = new int[nums.Length];
        int prefix = 1;
        //[1,2,3,4] [1]   pref=1
        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = prefix;
            prefix *= nums[i];
        }
        int suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= suffix;
            suffix *= nums[i];
        }
        return res;
    }
}
