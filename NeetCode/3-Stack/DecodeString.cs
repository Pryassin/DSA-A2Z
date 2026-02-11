public class Solution {
    public string DecodeString(string s) {
        Stack<string>stack=new Stack<string>();
        for(int i=0;i<s.Length;i++)
        {
            if(s[i].ToString()!="]")
            {
                stack.Push(s[i].ToString());
            }
            //3[a
            else{
                string word="";
               while(stack.Peek()!="[")
               {
                 word=stack.Pop()+word;
               }
               //remove "["
               stack.Pop();
               string k="";
               while (stack.Count > 0 && char.IsDigit(stack.Peek()[0]))
               {
                 k=stack.Pop()+k;
               }
               int rep=int.Parse(k);
               var expanded= new StringBuilder().Insert(0,word,rep).ToString();
               stack.Push(expanded);
            }
        }
              var res= new StringBuilder();
            foreach(var s1 in stack)
            {
                 res.Insert(0,s1);
            }
            return res.ToString();
    }
}