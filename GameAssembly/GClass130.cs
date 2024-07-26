public class GClass130
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

	public static void smethod_3(GClass122 g)
	{
		if (!bool_0 || (bool_1 && int_0 > 4990) || GClass144.bool_10)
			return;
		int num = 10;
		GClass73.gclass192_0.method_33(GClass73.int_12 - 75, 10, 150, 55, g);
		if (!bool_1)
		{
			if (string_1 == null)
			{
				GClass4.gclass4_21.method_6(g, string_0, GClass73.int_12, num + 21, 2);
				return;
			}
			GClass4.gclass4_21.method_6(g, string_0, GClass73.int_12, num + 13, 2);
			GClass4.gclass4_14.method_6(g, string_1, GClass73.int_12, num + 30, 2);
		}
		else
		{
			GClass73.smethod_47(GClass73.int_12 - GClass4.gclass4_21.method_17(string_0) / 2 - 10, num + 28, g);
			GClass4.gclass4_21.method_6(g, string_0, GClass73.int_12 + 5, num + 21, 2);
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
		string_0 = "";
		string_1 = null;
		bool_1 = false;
		int_0 = 0;
		bool_0 = false;
	}
}
