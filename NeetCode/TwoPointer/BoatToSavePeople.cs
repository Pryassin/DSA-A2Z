public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int l=0;
        int n=people.Length;
        int r=n-1;
        int res=0;
        //[3,3,4,5]
        while(l<=r)
        {
            int sum=people[l]+people[r];
           if(sum<=limit)
           {
            l++;
           }
           r--;
           res++;
        }
        return res;
    }
}