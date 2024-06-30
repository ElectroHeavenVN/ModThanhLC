using System;

public class GClass170
{
	private static int int_0;

	private static int int_1;

	private static GClass91 gclass91_0 = new GClass91();

	private static GClass63 gclass63_0 = new GClass63();

	private static int int_2 = 17;

	private static int int_3;

	private static int int_4;

	private static int int_5;

	private static int int_6;

	private static int int_7;

	private static int int_8;

	private static int int_9;

	private static int int_10 = 269;

	private static float float_0;

	private static int[] int_11 = new int[3];

	private static int[] int_12 = new int[3];

	private static bool UbybFhgmsZ = false;

	private static long long_0 = 0L;

	private static long jkAblNncyG = 150L;

	public static void smethod_0()
	{
		if (UbybFhgmsZ)
			smethod_4();
		if (int_8 > 32 && UbybFhgmsZ)
		{
			UbybFhgmsZ = false;
			gclass63_0.method_9();
			gclass63_0.method_0(new GClass77(GClass56.smethod_19(50, GClass39.int_10 - 50), GClass56.smethod_19(GClass39.int_11 - 100, GClass39.int_11), 5, 72));
		}
	}

	public static void smethod_1(GClass76 g)
	{
		smethod_0();
		g.method_16(0);
		g.method_15(0, 0, int_0, int_1);
		g.method_16(16711680);
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			((GClass77)gclass63_0.method_3(i)).method_0(g);
		}
		if (!UbybFhgmsZ)
			smethod_2(-(GClass26.smethod_0(gclass91_0.method_0() % 3) + 5));
	}

	public static void smethod_2(int k)
	{
		if (k == -5 && !UbybFhgmsZ)
		{
			int_6 = int_0 / 2;
			int_5 = 80;
			UbybFhgmsZ = true;
			smethod_3();
		}
		else if (k == -7 && !UbybFhgmsZ)
		{
			int_5 = 60;
			int_6 = 0;
			UbybFhgmsZ = true;
			smethod_3();
		}
		else if (k == -6 && !UbybFhgmsZ)
		{
			int_5 = 120;
			int_6 = int_0;
			UbybFhgmsZ = true;
			smethod_3();
		}
	}

	public static void smethod_3()
	{
		int_7 = 0;
		int_9 = 16;
		int_8 = 0;
		float_0 = 0f;
		for (int i = 0; i < 3; i++)
		{
			int_12[i] = 0;
			int_11[i] = int_6;
		}
		UbybFhgmsZ = true;
	}

	public static void smethod_4()
	{
		int_12[2] = int_12[1];
		int_11[2] = int_11[1];
		int_12[1] = int_12[0];
		int_11[1] = int_11[0];
		int_12[0] = int_4;
		int_11[0] = int_3;
		int_3 = GClass56.smethod_2((int)((double)int_5 * Math.PI / 180.0)) * int_9 * int_8 + int_6;
		int_4 = (int)((float)(int_9 * GClass56.smethod_1((int)((double)int_5 * Math.PI / 180.0)) * int_8) - float_0 * (float)int_8 * (float)int_8 / 2f) + int_7;
		if (smethod_5() - long_0 >= jkAblNncyG)
		{
			int_8++;
			long_0 = smethod_5();
		}
	}

	public static long smethod_5()
	{
		return GClass138.smethod_18();
	}
}
