public class Solution {
    public bool IsPalindrom(string s ,int l,int r)
    {
        while(l<r)
        {
            if(s[l]!=s[r])
            return false;
            else{
                l++;
                r--;
            }
        }
        return true;
    }
    public bool ValidPalindrome(string s) {
        int l=0;
        int r= s.Length-1;
        // abcbba  l-->c   r-->b2
        while(l<r)
        {
            if(s[l]!=s[r])
            {
                return IsPalindrom(s,l+1,r)|| IsPalindrom(s,l,r-1);
            }
          l++;r--;
        }
        return true;
    }
}