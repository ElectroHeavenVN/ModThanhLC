using UnityEngine;

public class GClass36
{
	public static int int_0;

	public static void smethod_0(string s)
	{
		if (GClass203.bool_0)
		{
			Debug.Log(((int_0 % 2 != 0) ? "***--- " : ">>>--- ") + s);
			int_0++;
		}
	}

	public static void smethod_1(string str)
	{
		if (GClass203.bool_0)
			Debug.Log(str);
	}

	public static void smethod_2(string str)
	{
		if (GClass203.bool_0)
			Debug.LogError(str);
	}

	public static void smethod_3(string str)
	{
		if (!GClass203.bool_0)
			;
	}

	public static void smethod_4(string str)
	{
		if (GClass203.bool_0)
			Debug.LogError(str);
	}

	public static void smethod_5(string str)
	{
		if (GClass203.bool_0)
			Debug.LogWarning(str);
	}
}
