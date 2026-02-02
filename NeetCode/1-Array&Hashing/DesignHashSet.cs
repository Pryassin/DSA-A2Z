public class MyHashSet
{
	private readonly Dictionary<int, int> dict;
	public MyHashSet()
	{
		dict = new Dictionary<int, int>();
	}

	public void Add(int key)
	{
		dict[key] = 1;
	}

	public void Remove(int key)
	{
		dict.Remove(key);
	}

	public bool Contains(int key)
	{
		return dict.ContainsKey(key);
	}
}