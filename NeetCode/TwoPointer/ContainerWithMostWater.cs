public class Solution {
    public int MaxArea(int[] height) {
        int res=0;
        int r=height.Length-1;
        int l=0;
        while(l<r)
        {
          int area=(r-l)*(Math.Min(height[r],height[l]));
          res= Math.Max(res,area);
          //if height[l] smaller that we should keep the bigger one and move the less to get the max 
          if(height[l]<height[r])
          {
            l++;
          }
          else
            r--;
          
        }
        return res;
        
    }
}