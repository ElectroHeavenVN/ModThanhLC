using UnityEngine;

internal class Class18
{
	public static WWW www_0;

	public static GClass118 gclass118_0;

	public static void smethod_0()
	{
		if (www_0 != null && www_0.isDone)
		{
			string str = string.Empty;
			if (www_0.error == null || www_0.error.Equals(string.Empty))
				str = www_0.text;
			www_0 = null;
			if (gclass118_0 != null)
				gclass118_0.method_0(str);
		}
	}

	public static void smethod_1(string string_0, GClass118 gclass118_1)
	{
		if (www_0 != null)
			GClass92.smethod_2("GET HTTP BUSY");
		www_0 = new WWW(string_0);
		gclass118_0 = gclass118_1;
	}

	public static void smethod_2(string string_0, GClass118 gclass118_1)
	{
		gclass118_0 = gclass118_1;
		if (string_0 != null)
			gclass118_1.method_0(string_0);
	}
}
