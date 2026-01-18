
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}

//Alternative and better way :
// 3,4,2,3,2,3

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int res = 0, count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                res = num;
            }
            count += (num == res) ? 1 : -1;
        }

        return res;
    }
}