public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int n in nums)
        {
            if (dict.ContainsKey(n))
            {
                dict[n]++;
            }
            else
                dict[n] = 1;
        }
        var valuesArray = dict
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(x => x.Key)
        .ToArray();

        return valuesArray;
    }
}