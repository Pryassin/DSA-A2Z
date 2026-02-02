public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int LongestStreak = 0;
        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentStreak = 1;
                int currentnum = num;
                while (set.Contains(currentnum + 1))
                {
                    currentStreak++;
                    currentnum++;
                }
                LongestStreak = Math.Max(LongestStreak, currentStreak);
            }
        }
        return LongestStreak;
    }
}