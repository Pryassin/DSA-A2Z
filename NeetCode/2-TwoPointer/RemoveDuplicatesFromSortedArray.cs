public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // 0,0,1,1,1,2,2,3,3,4
        int w=0;
        for(int e=1;e<nums.Length;e++)
        {
         if(nums[e]!=nums[e-1])
         {  
            w++;
            nums[w]=nums[e];
           
         }   
        }
        return w+1;
    }
}