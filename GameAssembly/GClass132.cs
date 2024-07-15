using System;

public class GClass132
{
	private static GClass196 gclass196_0;

	public static int int_0;

	public static int int_1 = 1;

	public static int int_2 = 2;

	private static GClass118 gclass118_0;

	public static void smethod_0(string caption, int type, string text, GClass118 action)
	{
		gclass118_0 = action;
		GEnum2 t = ((type == 0 || type == 2) ? GEnum2.const_1 : GEnum2.const_2);
		GClass196.bool_0 = false;
		gclass196_0 = GClass196.smethod_0(text, t, false, false, type == 2, false, caption);
	}

	public static void smethod_1()
	{
		try
		{
			if (gclass196_0 != null && gclass196_0.bool_2)
			{
				if (gclass118_0 != null)
					gclass118_0.method_0(gclass196_0.string_0);
				gclass196_0.string_0 = string.Empty;
				gclass196_0 = null;
			}
		}
		catch (Exception)
		{
		}
	}
}
