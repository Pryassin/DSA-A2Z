public class Solution {
    public int MySqrt(int x) {
        int l=0;
        int r=x;
        int res=0;
        while(l<=r)
        {
           int mid=l+(r-l)/2;
           long sq=(long) mid*mid;
           if(sq<x)
           {
            l=mid+1;
            res=mid;
           }
           else if(sq>x)
           {
            r=mid-1;
           }
           else{
            return mid;
           }
        }
        return res;
    }
}