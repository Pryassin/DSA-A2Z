public class Solution {
      bool IsAlphaNum(char c)
    {
        return c>='A'&&c<='Z'||c>='a'&&c<='z'||c>='0'&&c<='9';
    }

    public bool IsPalindrome(string s) {
        int r=s.Length-1;
        int l=0;
        while(l<r)
        {
            while(!IsAlphaNum(s[l])&&l<r)
            {
                l++;
            }
            while(!IsAlphaNum(s[r])&&l<r)
            {
                r--;
            }
            if(char.ToLower(s[l])!=char.ToLower(s[r]))
            {
                return false;
            }
            else{
            l++;
            r--;
            }
        }
        return true;
    }
  
}