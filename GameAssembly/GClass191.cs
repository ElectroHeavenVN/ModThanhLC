using UnityEngine;

public class GClass191
{
	private static short[] short_0 = new short[91]
	{
		0, 18, 36, 54, 71, 89, 107, 125, 143, 160,
		178, 195, 213, 230, 248, 265, 282, 299, 316, 333,
		350, 367, 384, 400, 416, 433, 449, 465, 481, 496,
		512, 527, 543, 558, 573, 587, 602, 616, 630, 644,
		658, 672, 685, 698, 711, 724, 737, 749, 761, 773,
		784, 796, 807, 818, 828, 839, 849, 859, 868, 878,
		887, 896, 904, 912, 920, 928, 935, 943, 949, 956,
		962, 968, 974, 979, 984, 989, 994, 998, 1002, 1005,
		1008, 1011, 1014, 1016, 1018, 1020, 1022, 1023, 1023, 1024,
		1024
	};

	private static short[] short_1;

	private static int[] int_0;

	public static string[] string_0 = new string[5]
	{
		"<color=#ff0000ff>[  LOG_CAT  ]</color>",
		"<color=#ff0000ff>[LOG_SESSION]</color>",
		"<color=#ffff00ff>[LOG_SESSION]</color>",
		"<color=#ff0000ff>[LOG_MOBILE ]</color>",
		string.Empty
	};

	public static int int_1;

	public static bool bool_0;

	public static bool bool_1;

	public static GClass122 gclass122_0 = new GClass122();

	public static GClass134 gclass134_0 = new GClass134();

	public static void smethod_0()
	{
		short_1 = new short[91];
		int_0 = new int[91];
		for (int i = 0; i <= 90; i++)
		{
			short_1[i] = short_0[90 - i];
			if (short_1[i] != 0)
				int_0[i] = (short_0[i] << 10) / short_1[i];
			else
				int_0[i] = int.MaxValue;
		}
	}

	public static int smethod_1(int a)
	{
		a = smethod_6(a);
		if (a < 0 || a >= 90)
		{
			if (a >= 90 && a < 180)
				return short_0[180 - a];
			if (a < 180 || a >= 270)
				return -short_0[360 - a];
			return -short_0[a - 180];
		}
		return short_0[a];
	}

	public static int smethod_2(int a)
	{
		a = smethod_6(a);
		if (a < 0 || a >= 90)
		{
			if (a < 90 || a >= 180)
			{
				if (a < 180 || a >= 270)
					return short_1[360 - a];
				return -short_1[a - 180];
			}
			return -short_1[180 - a];
		}
		return short_1[a];
	}

	public static int smethod_3(int a)
	{
		a = smethod_6(a);
		if (a < 0 || a >= 90)
		{
			if (a < 90 || a >= 180)
			{
				if (a < 180 || a >= 270)
					return -int_0[360 - a];
				return int_0[a - 180];
			}
			return -int_0[180 - a];
		}
		return int_0[a];
	}

	public static int smethod_4(int a)
	{
		for (int i = 0; i <= 90; i++)
		{
			if (int_0[i] >= a)
				return i;
		}
		return 0;
	}

	public static int smethod_5(int dx, int dy)
	{
		int num;
		if (dx != 0)
		{
			num = smethod_4(GClass13.smethod_0((dy << 10) / dx));
			if (dy >= 0 && dx < 0)
				num = 180 - num;
			if (dy < 0 && dx < 0)
				num = 180 + num;
			if (dy < 0 && dx >= 0)
				num = 360 - num;
		}
		else
			num = ((dy > 0) ? 90 : 270);
		return num;
	}

	public static int smethod_6(int angle)
	{
		if (angle >= 360)
			angle -= 360;
		if (angle < 0)
			angle += 360;
		return angle;
	}

	public static sbyte[] smethod_7()
	{
		return null;
	}

	public static void smethod_8(string s)
	{
		if (GClass77.bool_0)
			Debug.Log(s);
	}

	public static void smethod_9(string s, int logIndex)
	{
		if (GClass77.bool_0)
			Debug.Log(string_0[logIndex] + s);
	}

	public static void smethod_10(string s)
	{
		if (GClass77.bool_0)
			Debug.LogError(s);
	}

	public static void smethod_11(string s)
	{
	}

	public static void smethod_12(string s)
	{
	}

	public static void smethod_13(GClass193 g)
	{
	}

	public static void smethod_14()
	{
	}

	public static string smethod_15(string str)
	{
		return str;
	}

	public static string smethod_16(string _text, string _searchStr, string _replacementStr)
	{
		return _text.Replace(_searchStr, _replacementStr);
	}

	public static int smethod_17(int goc, int d)
	{
		return smethod_2(smethod_6(goc)) * d >> 10;
	}

	public static int smethod_18(int goc, int d)
	{
		return smethod_1(smethod_6(goc)) * d >> 10;
	}

	public static int smethod_19(int a, int b)
	{
		if (a == b)
			return a;
		return a + gclass134_0.method_1(b - a);
	}

	public static int smethod_20(int a)
	{
		return gclass134_0.method_1(a);
	}

	public static int smethod_21(int a, int b)
	{
		int num = a + gclass134_0.method_1(b - a);
		if (smethod_20(2) == 0)
			num = -num;
		return num;
	}

	public static int smethod_22(int a)
	{
		int num;
		for (num = 0; num == 0; num = gclass134_0.method_0() % a)
		{
		}
		return num;
	}

	public static int smethod_23(int currentTimeMillis)
	{
		int num = 0;
		num = currentTimeMillis * 16 / 1000;
		if (currentTimeMillis * 16 % 1000 >= 5)
			num++;
		return num;
	}

	public static int smethod_24(int x1, int y1, int x2, int y2)
	{
		return smethod_26((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
	}

	public static int smethod_25(int x, int y)
	{
		return smethod_26(x * x + y * y);
	}

	public static int smethod_26(int a)
	{
		if (a > 0)
		{
			int num = (a + 1) / 2;
			int num2;
			do
			{
				num2 = num;
				num = num / 2 + a / (2 * num);
			}
			while (GClass13.smethod_0(num2 - num) > 1);
			return num;
		}
		return 0;
	}

	public static int smethod_27(int a)
	{
		return gclass134_0.method_1(a);
	}

	public static int smethod_28(int i)
	{
		return (i > 0) ? i : (-i);
	}

	public static bool smethod_29(int x1, int y1, int width, int height, int x2, int y2)
	{
		return x2 >= x1 && x2 <= x1 + width && y2 >= y1 && y2 <= y1 + height;
	}

	public static string[] smethod_30(string original, string separator, int count)
	{
		int num = original.IndexOf(separator);
		string[] array;
		if (num >= 0)
			array = smethod_30(original.Substring(num + separator.Length), separator, count + 1);
		else
		{
			array = new string[count + 1];
			num = original.Length;
		}
		array[count] = original.Substring(0, num);
		return array;
	}

	public static string smethod_31(long number)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		empty = string.Empty;
		if (number < 1000000000L)
		{
			if (number < 1000000L)
				return number + string.Empty;
			empty2 = mResources.million;
			long num = number % 1000000L / 100000L;
			number /= 1000000L;
			empty = number + string.Empty;
			if (num <= 0L)
				return empty + empty2;
			return empty + "," + num + empty2;
		}
		empty2 = mResources.billion;
		long num2 = number % 1000000000L / 100000000L;
		number /= 1000000000L;
		empty = number + string.Empty;
		if (num2 > 0L)
			return empty + "," + num2 + empty2;
		return empty + empty2;
	}

	public static string smethod_32(long number)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		empty = string.Empty;
		if (number >= 1000000000L)
		{
			empty2 = mResources.billion;
			long num = number % 1000000000L / 10000000L;
			number /= 1000000000L;
			empty = number + string.Empty;
			if (num >= 10L)
			{
				if (num % 10L == 0L)
					num /= 10L;
				return empty + "," + num + empty2;
			}
			if (num > 0L)
				return empty + ",0" + num + empty2;
			return empty + empty2;
		}
		if (number >= 1000000L)
		{
			empty2 = mResources.million;
			long num2 = number % 1000000L / 10000L;
			number /= 1000000L;
			empty = number + string.Empty;
			if (num2 < 10L)
			{
				if (num2 > 0L)
					return empty + ",0" + num2 + empty2;
				return empty + empty2;
			}
			if (num2 % 10L == 0L)
				num2 /= 10L;
			return empty + "," + num2 + empty2;
		}
		if (number >= 10000L)
		{
			empty2 = "k";
			long num3 = number % 1000L / 10L;
			number /= 1000L;
			empty = number + string.Empty;
			if (num3 >= 10L)
			{
				if (num3 % 10L == 0L)
					num3 /= 10L;
				return empty + "," + num3 + empty2;
			}
			if (num3 > 0L)
				return empty + ",0" + num3 + empty2;
			return empty + empty2;
		}
		return number + string.Empty;
	}
}
