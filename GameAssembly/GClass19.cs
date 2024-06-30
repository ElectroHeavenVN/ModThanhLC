using System;

public class GClass19
{
	public static GInterface0 ginterface0_0;

	public static int int_0;

	public static long long_0;

	public static bool bool_0;

	public static void smethod_0(GInterface0 actionListener, int action, long timeEllapse)
	{
		ginterface0_0 = actionListener;
		int_0 = action;
		long_0 = GClass138.smethod_18() + timeEllapse;
		bool_0 = true;
	}

	public static void smethod_1()
	{
		long num = GClass138.smethod_18();
		if (!bool_0 || num <= long_0)
			return;
		bool_0 = false;
		try
		{
			if (int_0 > 0)
				GClass154.smethod_8().method_115(int_0, null);
		}
		catch (Exception)
		{
		}
	}
}
