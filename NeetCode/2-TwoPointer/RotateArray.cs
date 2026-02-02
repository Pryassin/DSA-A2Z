public class Solution {
    
public void Rotate(int[] nums, int k) {
    int n = nums.Length;
    k = k % n;
    int [] leftArr= new int [n-k];
    int [] rightArr= new int [k];

    //fill the left array
    for(int i=0;i<n-k;i++)
    {
       leftArr[i]=nums[i];
    }
    //fill the right array
    for(int i=0;i<k;i++)
    {
        rightArr[i]=nums[n-k+i];
    }
    //rotate the array
    for(int i=0;i<n;i++)
    {
        if(i<k)
        {
            nums[i]=rightArr[i];
        }
        else{
            nums[i]=leftArr[i-k];
        }

    }




}
}