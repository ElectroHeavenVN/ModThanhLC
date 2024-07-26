public class GClass123
{
	public static int int_0;

	public static int int_1;

	public static int int_2;

	public static bool bool_0;

	public static string string_0 = "";

	public static void smethod_0()
	{
		int_0 = 0;
		int_1 = 0;
		bool_0 = false;
	}

	public static void smethod_1(GClass122 g, string str, int x, int y, int w, int h, GClass4 f)
	{
		if (int_2 != f.method_17(str) || !string_0.Equals(str))
		{
			string_0 = str;
			int_0 = 0;
			int_2 = f.method_17(str);
			bool_0 = false;
			int_1 = 0;
		}
		g.method_5(x, y, w, h);
		if (int_2 > w)
			f.method_6(g, str, x - int_0, y, 0);
		else
			f.method_6(g, str, x + w / 2, y, 2);
		GClass73.smethod_6(g);
		if (int_2 <= w)
			return;
		if (bool_0)
		{
			if (int_0 < 0)
				int_0 += w + int_0 >> 1;
			if (int_0 > 0)
				int_0 = 0;
			if (int_0 == 0)
			{
				int_1++;
				if (int_1 == 50)
				{
					int_1 = 0;
					bool_0 = false;
				}
			}
			return;
		}
		int_1++;
		if (int_1 > 50)
		{
			int_0++;
			if (int_0 >= int_2)
			{
				int_1 = 0;
				int_0 = -w + 30;
				bool_0 = true;
			}
		}
	}
}
