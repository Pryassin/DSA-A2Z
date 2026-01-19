public class Solution
{
    public int[] SortArray(int[] nums)
    {
        mergeSort(nums);
        return nums;
    }

    public void mergeSort(int[] nums)
    {
        if (nums.Length == 1) return;
        int mid = nums.Length / 2;
        int[] leftArr = new int[mid];
        int[] rightArr = new int[nums.Length - mid];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i < mid)
            {
                leftArr[i] = nums[i];
            }
            else
            {
                rightArr[i - mid] = nums[i];
            }
        }

        mergeSort(leftArr);
        mergeSort(rightArr);
        merge(leftArr, rightArr, nums);
    }

    public void merge(int[] leftArr, int[] rightArr, int[] array)
    {
        int i = 0; int l = 0; int r = 0;
        while (l < leftArr.Length && r < rightArr.Length)
        {
            if (leftArr[l] < rightArr[r])
            {
                array[i++] = leftArr[l++];
            }
            else
            {
                array[i++] = rightArr[r++];
            }
        }
        while (l < leftArr.Length)
        {
            array[i++] = leftArr[l++];
        }
        while (r < rightArr.Length)
        {
            array[i++] = rightArr[r++];
        }
    }
}
// Quick Sort
