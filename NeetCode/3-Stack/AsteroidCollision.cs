public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack=new Stack<int>();
        foreach(int ast in asteroids)
        {   bool destroyed=false;
            while(stack.Count>0 && ast<0 && stack.Peek()>0)
            {    int last=stack.Pop();
                if(-ast<last)
                {
                  destroyed=true;
                  stack.Push(last);
                  break;
                }
                else if (-ast==last)
                {
                    destroyed=true;
                    break;
                }
            }
            if(!destroyed)
            { 
               stack.Push(ast);
            }
        }
      int [] arr =stack.ToArray();
      Array.Reverse(arr);
      return arr;
    }
}