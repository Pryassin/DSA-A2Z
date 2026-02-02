public class Solution
{
    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    public void SortColors(int[] nums)
    {
        // [2,0,2,1,1,0]
        int r = nums.Length - 1;
        int l = 0;
        int i = 0;
        while (i <= r)
        {
            if (nums[i] == 0)
            {
                Swap(nums, i, l);
                l++; i++;
            }
            else if (nums[i] == 2)
            {
                Swap(nums, i, r);
                r--;

            }
            else
            {
                i++;
            }
        }

    }
}
