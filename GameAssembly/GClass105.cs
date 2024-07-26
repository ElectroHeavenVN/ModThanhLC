using System;

public class GClass105
{
	private static GClass60 gclass60_0;

	public static int int_0;

	public static int int_1 = 1;

	public static int int_2 = 2;

	private static GClass87 gclass87_0;

	public static void smethod_0(string caption, int type, string text, GClass87 action)
	{
		gclass87_0 = action;
		GEnum0 t = ((type == 0 || type == 2) ? GEnum0.const_1 : GEnum0.const_2);
		GClass60.bool_0 = false;
		gclass60_0 = GClass60.smethod_0(text, t, false, false, type == 2, false, caption);
	}

	public static void smethod_1()
	{
		try
		{
			if (gclass60_0 != null && gclass60_0.bool_2)
			{
				if (gclass87_0 != null)
					gclass87_0.method_0(gclass60_0.string_0);
				gclass60_0.string_0 = "";
				gclass60_0 = null;
			}
		}
		catch (Exception)
		{
		}
	}
}
