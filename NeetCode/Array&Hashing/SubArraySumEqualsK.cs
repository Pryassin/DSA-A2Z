public class Solution
{
	public int SubarraySum(int[] nums, int k)
	{
		Dictionary<int, int> map = new Dictionary<int, int>();
		map[0] = 1;
		int count = 0;
		int sum = 0;
		foreach (int num in nums)
		{
			sum += num;
			int diff = sum - k;
			if (map.ContainsKey(diff))
			{
				count += map[diff];
			}
			if (map.ContainsKey(sum))
			{
				map[sum]++;
			}
			else
			{
				map[sum] = 1;
			}

		}
		return count;
	}
}