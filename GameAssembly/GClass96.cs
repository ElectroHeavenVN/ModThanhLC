public class GClass96
{
	public static bool bool_0;

	private static string string_0;

	private static string string_1;

	public static int int_0;

	public static bool bool_1;

	public static void smethod_0(string title, string subtitle, int delay)
	{
		if (title != null)
		{
			bool_0 = true;
			string_0 = title;
			string_1 = subtitle;
			int_0 = delay;
		}
	}

	public static void smethod_1()
	{
	}

	public static void smethod_2(string str)
	{
		smethod_0(str, null, 700);
		bool_1 = true;
	}

	public static void smethod_3(GClass193 g)
	{
		if (bool_0 && (!bool_1 || int_0 <= 4990) && !GClass167.bool_10)
		{
			int num = 10;
			GClass14.gclass97_0.method_33(GClass14.int_12 - 75, 10, 150, 55, g);
			if (bool_1)
			{
				GClass14.smethod_47(GClass14.int_12 - GClass104.gclass104_21.method_17(string_0) / 2 - 10, num + 28, g);
				GClass104.gclass104_21.method_6(g, string_0, GClass14.int_12 + 5, num + 21, 2);
			}
			else if (string_1 != null)
			{
				GClass104.gclass104_21.method_6(g, string_0, GClass14.int_12, num + 13, 2);
				GClass104.gclass104_14.method_6(g, string_1, GClass14.int_12, num + 30, 2);
			}
			else
			{
				GClass104.gclass104_21.method_6(g, string_0, GClass14.int_12, num + 21, 2);
			}
		}
	}

	public static void smethod_4()
	{
		if (int_0 > 0)
		{
			int_0--;
			if (int_0 == 0)
				smethod_5();
		}
	}

	public static void smethod_5()
	{
		string_0 = string.Empty;
		string_1 = null;
		bool_1 = false;
		int_0 = 0;
		bool_0 = false;
	}
}
