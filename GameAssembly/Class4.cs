using UnityEngine;

internal class Class4
{
	public static WWW www_0;

	public static GClass87 gclass87_0;

	public static void smethod_0()
	{
		if (www_0 != null && www_0.isDone)
		{
			string str = "";
			if (www_0.error == null || www_0.error.Equals(""))
				str = www_0.text;
			www_0 = null;
			if (gclass87_0 != null)
				gclass87_0.method_0(str);
		}
	}

	public static void smethod_1(string string_0, GClass87 gclass87_1)
	{
		if (www_0 != null)
			GClass36.smethod_2("GET HTTP BUSY");
		www_0 = new WWW(string_0);
		gclass87_0 = gclass87_1;
	}

	public static void smethod_2(string string_0, GClass87 gclass87_1)
	{
		gclass87_0 = gclass87_1;
		if (string_0 != null)
			gclass87_1.method_0(string_0);
	}
}
