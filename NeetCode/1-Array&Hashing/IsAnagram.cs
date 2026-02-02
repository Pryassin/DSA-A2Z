public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        // Count characters in s
        Dictionary<char, int> freqS = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (!freqS.ContainsKey(s[i]))
                freqS.Add(s[i], 0);
            freqS[s[i]]++;
        }

        // Count characters in t
        Dictionary<char, int> freqT = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++) {
            if (!freqT.ContainsKey(t[i]))
                freqT.Add(t[i], 0);
            freqT[t[i]]++;
        }

        // Compare dictionaries
        if (freqS.Count != freqT.Count)
            return false;

        foreach (var pair in freqS) {
            if (!freqT.ContainsKey(pair.Key) || freqT[pair.Key] != pair.Value)
                return false;
        }

        return true;
    }
}
