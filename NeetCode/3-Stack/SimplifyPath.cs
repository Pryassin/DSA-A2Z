public class Solution {
    public string SimplifyPath(string path) {
        string[] dircs=path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        Stack<string> simppath= new Stack<string>();

        foreach(var dirc in dircs)
        {
            if(dirc==".") continue;
            else if(dirc==".."){
                if(simppath.Count>0)
                {
                    simppath.Pop();
                }
            }
            else{
                simppath.Push(dirc);
            }
        }
        string result = "/" + string.Join("/", simppath.Reverse());
        return result;
    }
}