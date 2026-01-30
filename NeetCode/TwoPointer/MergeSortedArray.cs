public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
           int l=0;
           int r=0;
           int [] arr= new int[n+m];

           for(int i=0;i<n+m;i++)
           {
            if(l>=m)
            {
               arr[i]=nums2[r++];
            }
            else if(r>=n)
            {
                arr[i]=nums1[l++];
            }
           else if(nums1[l]<nums2[r])
            {
                arr[i]=nums1[l++];
            }
            else{
                arr[i]=nums2[r++];
            }
           }

           for(int i=0;i<n+m;i++)
           {
            nums1[i]=arr[i];
           }
}}