using System;
using System.Text.RegularExpressions;

public class Solution 
{
    /// <summary>
    /// Recursively checks if a string is a palindrome
    /// </summary>
    /// <param name="s">The string to check</param>
    /// <param name="i">Current index from start</param>
    /// <returns>True if palindrome, false otherwise</returns>
    public bool IsPalindromeRecursive(string s, int i)
    {
        // Base case: checked half the string
        if (i >= s.Length / 2) 
            return true;
        
        // Characters don't match
        if (s[i] != s[s.Length - 1 - i]) 
            return false;
        
        // Check next pair
        return IsPalindromeRecursive(s, i + 1);
    }
    
    /// <summary>
    /// Main palindrome checker with preprocessing
    /// </summary>
    /// <param name="s">Input string</param>
    /// <returns>True if valid palindrome</returns>
    public bool IsPalindrome(string s)
    {
        // Convert to lowercase
        s = s.ToLower();
        
        // Remove non-alphanumeric characters
        s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
        
        // Start recursive check
        return IsPalindromeRecursive(s, 0);
    }
}
