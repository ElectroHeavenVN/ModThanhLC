using System.Collections;

public class GClass113
{
	public Hashtable hashtable_0 = new Hashtable();

	public object method_0(object k)
	{
		return hashtable_0[k];
	}

	public void method_1()
	{
		hashtable_0.Clear();
	}

	public IDictionaryEnumerator method_2()
	{
		return hashtable_0.GetEnumerator();
	}

	public int method_3()
	{
		return hashtable_0.Count;
	}

	public void method_4(object k, object v)
	{
		if (hashtable_0.ContainsKey(k))
			hashtable_0.Remove(k);
		hashtable_0.Add(k, v);
	}

	public void method_5(object k)
	{
		hashtable_0.Remove(k);
	}

	public void method_6(string key)
	{
		hashtable_0.Remove(key);
	}

	public bool method_7(object key)
	{
		return hashtable_0.ContainsKey(key);
	}
}
