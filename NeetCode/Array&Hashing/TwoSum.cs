

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> Table = new Dictionary<int, int>();
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (Table.ContainsKey(diff))
            {
                result[0] = Table[diff];
                result[1] = i;
                return result;
            }
            Table[nums[i]] = i;
        }
        return result;
    }
}