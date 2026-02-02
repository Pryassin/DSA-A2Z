public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> res= new List<IList<int>>();
        Array.Sort(nums);

        int n=nums.Length;
        for(int a=0;a<n;a++)
        {
            if(a>0&&nums[a]==nums[a-1]) continue;

            for(int b=a+1;b<n;b++)
            {
                if(b>a+1&&nums[b]==nums[b-1]) continue;

                int l=b+1;
                int r=n-1;
                while(l<r)
                {
                    long sum=(long)nums[a]+nums[b]+nums[l]+nums[r];
                    if(sum==target)
                    {
                        res.Add(new List<int>{nums[a],nums[b],nums[l],nums[r]});
                        l++;
                        r--;
                        while(l<r&&nums[l]==nums[l-1])
                        {
                            l++;
                        }
                        while(l<r&&nums[r]==nums[r+1])
                        {
                            r--;
                        }

                    }
                    else if(sum>target)
                    {
                        r--;
                    }
                    else{
                        l++;
                    }
                }
            }
           
        }
         return res;
    }
}