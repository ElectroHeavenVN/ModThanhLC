using System.Threading;
using ns1;

public class GClass3
{
	public static GClass20 gclass20_0;

	public static int int_0;

	public static int int_1;

	public static int int_2;

	public static int int_3;

	public static int int_4;

	public static int int_5;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public static int int_9;

	public static bool bool_0;

	public static int int_10;

	public static bool bool_1;

	public static int int_11;

	public static int int_12;

	public static int int_13;

	public static bool bool_2;

	public static void smethod_0()
	{
		gclass20_0 = GClass14.smethod_43("/mainImage/myTexture2dmobCapcha.png");
	}

	public static void smethod_1(GClass193 g, int x, int y)
	{
		if (GClass56.smethod_0().bool_1 && GClass56.smethod_0().bool_0 && GClass193.int_12 == 1)
		{
			GClass56.smethod_0().bool_1 = false;
			new Thread(GClass56.smethod_0().method_0).Start();
		}
		if (!bool_2)
		{
			if (GClass14.int_8 % 3 == 0)
			{
				if (GClass124.smethod_1().int_12 == 1)
					int_5 = x - 20 - GClass167.int_22;
				if (GClass124.smethod_1().int_12 == -1)
					int_5 = x + 20 - GClass167.int_22;
			}
			int_0 = GClass124.smethod_1().int_5 - 40 - GClass167.int_23;
		}
		else
		{
			int_10++;
			if (int_10 == 5)
			{
				bool_2 = false;
				int_10 = 0;
			}
			int_5 = x - GClass167.int_22;
			int_0 = y - GClass167.int_23;
		}
		if (int_6 <= x - GClass167.int_22)
			int_13 = 1;
		else
			int_13 = -1;
		g.method_31(GClass167.gclass20_44, int_6, int_1 - 40, 3);
		GClass139.smethod_4(g, int_6 - 25, int_1 - 70, 50, 20, 16777215, false);
		GClass104.gclass104_6.method_6(g, GClass167.smethod_8().string_8, int_6, int_1 - 65, 2);
		if (bool_1)
		{
			bool_1 = false;
			GClass98.smethod_0(new GClass85(18, int_6 + GClass167.int_22, int_1 + GClass167.int_23, 2, 10, -1));
		}
		if (bool_0)
		{
			bool_0 = false;
			GClass98.smethod_0(new GClass85(18, int_6 + GClass167.int_22, int_1 + GClass167.int_23, 2, 10, -1));
			GClass167.smethod_8().gclass6_0 = null;
			int_5 = -GClass167.int_22;
			int_0 = -GClass167.int_23;
		}
		g.method_23(gclass20_0, 0, int_12 * 40, 40, 40, (int_13 != 1) ? 2 : 0, int_6, int_1 + 3 + ((GClass14.int_8 % 10 > 5) ? 1 : 0), 3);
		smethod_2();
	}

	public static void smethod_2()
	{
		if (int_1 != int_0)
		{
			int_3 = int_0 - int_1 << 2;
			int_2 += int_3;
			int_1 += int_2 >> 4;
			int_2 &= 15;
		}
		if (int_6 != int_5)
		{
			int_8 = int_5 - int_6 << 2;
			int_7 += int_8;
			int_6 += int_7 >> 4;
			int_7 &= 15;
		}
		int_11++;
		if (int_11 == 5)
		{
			int_11 = 0;
			int_12++;
			if (int_12 > 2)
				int_12 = 0;
		}
	}
}
