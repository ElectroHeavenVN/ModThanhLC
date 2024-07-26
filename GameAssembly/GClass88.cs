using System.Collections;

public class GClass88
{
	private ArrayList arrayList_0;

	public GClass88()
	{
		arrayList_0 = new ArrayList();
	}

	public GClass88(string s)
	{
		arrayList_0 = new ArrayList();
	}

	public GClass88(ArrayList a)
	{
		arrayList_0 = a;
	}

	public void method_0(object o)
	{
		arrayList_0.Add(o);
	}

	public bool method_1(object o)
	{
		if (arrayList_0.Contains(o))
			return true;
		return false;
	}

	public int method_2()
	{
		if (arrayList_0 != null)
			return arrayList_0.Count;
		return 0;
	}

	public object method_3(int index)
	{
		if (index <= -1 || index >= arrayList_0.Count)
			return null;
		return arrayList_0[index];
	}

	public void method_4(int index, object obj)
	{
		if (index > -1 && index < arrayList_0.Count)
			arrayList_0[index] = obj;
	}

	public void method_5(object obj, int index)
	{
		if (index > -1 && index < arrayList_0.Count)
			arrayList_0[index] = obj;
	}

	public int method_6(object o)
	{
		return arrayList_0.IndexOf(o);
	}

	public void method_7(int index)
	{
		if (index > -1 && index < arrayList_0.Count)
			arrayList_0.RemoveAt(index);
	}

	public void method_8(object o)
	{
		arrayList_0.Remove(o);
	}

	public void method_9()
	{
		arrayList_0.Clear();
	}

	public void method_10(object o, int i)
	{
		arrayList_0.Insert(i, o);
	}

	public object method_11()
	{
		return arrayList_0[0];
	}

	public object method_12()
	{
		return arrayList_0[arrayList_0.Count - 1];
	}
}
