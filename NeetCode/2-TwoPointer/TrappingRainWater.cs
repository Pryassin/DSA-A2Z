public class Solution {
    public int Trap(int[] height) {
        int n=height.Length;
        int [] leftMax = new int [n];
        int [] rightMax = new int [n];
        leftMax[0]=height[0];
        rightMax[n-1]=height[n-1];

        // /[0,1,0,2,1,0,1,3,2,1,2,1]
        for(int i=1;i<n;i++)
        {
            leftMax[i]=Math.Max(leftMax[i-1],height[i]);
        }
        for(int i=n-2;i>=0;i--)
        {
            rightMax[i]=Math.Max(rightMax[i+1],height[i]);
        }

        int total=0;
        for(int i=0;i<n;i++)
        {
            total += Math.Min(rightMax[i],leftMax[i])-height[i];
        }
        return total;

    }
}