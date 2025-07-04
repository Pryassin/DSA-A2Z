Valid Palindrome - Recursive Solution
LeetCode Problem: 125. Valid Palindrome
Problem
Check if a string is a palindrome after removing non-alphanumeric characters and converting to lowercase.
Solution





public class Solution 
{
    public bool IsPalindromeRecursive(string s, int i)
    {
        if (i >= s.Length / 2) return true;
        if (s[i] != s[s.Length - 1 - i]) return false;
        return IsPalindromeRecursive(s, i + 1);
    }
    
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
        return IsPalindromeRecursive(s, 0);
    }
}


Clean the string (lowercase + remove non-alphanumeric)
Compare characters from both ends recursively
Return true if all pairs match

Examples

"A man, a plan, a canal: Panama" → true
"race a car" → false

Complexity

Time: O(n)
Space: O(n) due to recursion
