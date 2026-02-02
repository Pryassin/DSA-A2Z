

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict= new Dictionary<string,List<string>>();
        foreach(string str in strs)
        {
           char[] unsarr = str.ToCharArray();
            Array.Sort(unsarr);
            string SortedStr=new string(unsarr);
            if(!dict.ContainsKey(SortedStr))
            {  
                 dict[SortedStr]=new List<string>();
            }
           
              dict[SortedStr].Add(str);
            
        }
        
        return dict.Values.Cast<IList<string>>().ToList();
    }
}

public class Solution
{
	public IList<IList<string>> GroupAnagrams(string[] strs)
	{
		Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
		foreach (string str in strs)
		{
			int[] count = new int[26];
			foreach (char c in str)
			{
				count[c - 'a']++;
			}
			string key = string.Join(",", count);
			if (!dict.ContainsKey(key))
			{
				dict[key] = new List<string>();
			}
			dict[key].Add(str);
		}

		return dict.Values.Cast<IList<string>>().ToList();
	}
}

