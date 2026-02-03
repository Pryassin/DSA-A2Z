public class Solution {
    public bool IsValid(string s) {
        // Mapping closing brackets (keys) to opening brackets (values)
        Dictionary<char, char> dic = new Dictionary<char, char> {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }
        };
        
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in s) { 
            // Check if the character is a CLOSING bracket
            if (dic.ContainsKey(c)) {
                // If stack is empty or top doesn't match, it's invalid
                if (stack.Count > 0 && stack.Peek() == dic[c]) {
                    stack.Pop();
                }
                else {
                    return false;
                }
            }
            else {
                // It's an OPENING bracket, push it to the stack
                stack.Push(c);
            }
        }
        
        // If stack is empty, all brackets were matched correctly
        return stack.Count == 0;
    }
}