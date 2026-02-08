public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
          Stack<(int value, int index)> stack = new Stack<(int, int)>();
          int [] result=new int [n];
          for(int i=n-1;i>=0;i--)
          {
            while(stack.Count>0&&temperatures[i]>=stack.Peek().value)
            {
                stack.Pop();
            }
            if(stack.Count>0)
            {
                result[i]=stack.Peek().index-i;
            }
            else{
                result[i]=0;
            }
            stack.Push((temperatures[i],i));
          }

          return result;
        }
}