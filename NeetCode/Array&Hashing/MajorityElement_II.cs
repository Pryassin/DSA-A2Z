public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        int k = nums.Length / 3;
        List<int> res = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 1;
            }
            else
                dict[num]++;
            if (dict[num] > k && !res.Contains(num))
            {
                res.Add(num);
            }
        }
        return res.ToArray();
    }
}