using System;

public class GClass123
{
	private static GClass111 gclass111_0;

	public static int int_0;

	public static int int_1 = 1;

	public static int int_2 = 2;

	private static GClass14 gclass14_0;

	public static void smethod_0(string caption, int type, string text, GClass14 action)
	{
		gclass14_0 = action;
		GEnum1 t = ((type == 0 || type == 2) ? GEnum1.const_1 : GEnum1.const_2);
		GClass111.bool_0 = false;
		gclass111_0 = GClass111.smethod_0(text, t, false, false, type == 2, false, caption);
	}

	public static void smethod_1()
	{
		try
		{
			if (gclass111_0 != null && gclass111_0.bool_2)
			{
				if (gclass14_0 != null)
					gclass14_0.method_0(gclass111_0.string_0);
				gclass111_0.string_0 = string.Empty;
				gclass111_0 = null;
			}
		}
		catch (Exception)
		{
		}
	}
}
