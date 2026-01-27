public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder res = new StringBuilder();
        int l=0;
        int r=0;
        while( l < word1.Length && r < word2.Length )
        {
           res.Append(word1[l]);
           res.Append(word2[r]);
           l++;
           r++;
        }
        while(l<word1.Length)
        {
            res.Append(word1[l]);
            l++;
        }
          while(r<word2.Length)
        {
            res.Append(word2[r]);
            r++;
        }
        return res.ToString();
    }
}