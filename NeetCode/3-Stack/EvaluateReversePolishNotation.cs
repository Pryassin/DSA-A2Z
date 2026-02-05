public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack <int> stack=new Stack<int>();
       HashSet<string> set = new() { "*", "+", "/", "-" };
        foreach(string c in tokens)
        {
            if(set.Contains(c))
            {
               int second=stack.Pop();
               int first=stack.Pop();
               if(c=="*")
               {
                  stack.Push(second*first);
               }
               else if(c=="+")
               {
                 stack.Push(second+first);
               }
               else if(c=="-")
               {
                 stack.Push(first-second);
               }
               else 
               {
                stack.Push(first/second);
                  
               }
            }
            else{
                stack.Push(int.Parse(c));
            }
        }
        int result=stack.Pop();
        return result;
    }
}