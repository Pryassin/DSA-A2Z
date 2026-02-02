public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[i] != nums[nums[i] - 1])
            {
                int temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            }
        }
        int count = 1;
        foreach (int num in nums)
        {
            if (num != count)
            {
                return count;
            }
            count++;
        }
        return n + 1;
    }
}