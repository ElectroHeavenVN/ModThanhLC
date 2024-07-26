using System;

public class GClass207
{
	private static int int_0;

	private static int int_1;

	private static GClass2 gclass2_0 = new GClass2();

	private static GClass88 gclass88_0 = new GClass88();

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

	private static bool bool_0 = false;

	private static long long_0 = 0L;

	private static long long_1 = 150L;

	public static void smethod_0()
	{
		if (bool_0)
			smethod_4();
		if (int_8 > 32 && bool_0)
		{
			bool_0 = false;
			gclass88_0.method_9();
			gclass88_0.method_0(new GClass186(GClass50.smethod_19(50, GClass73.int_10 - 50), GClass50.smethod_19(GClass73.int_11 - 100, GClass73.int_11), 5, 72));
		}
	}

	public static void smethod_1(GClass122 g)
	{
		smethod_0();
		g.method_16(0);
		g.method_15(0, 0, int_0, int_1);
		g.method_16(16711680);
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			((GClass186)gclass88_0.method_3(i)).method_0(g);
		}
		if (!bool_0)
			smethod_2(-(GClass118.smethod_0(gclass2_0.method_0() % 3) + 5));
	}

	public static void smethod_2(int k)
	{
		if (k != -5 || bool_0)
		{
			if (k != -7 || bool_0)
			{
				if (k == -6 && !bool_0)
				{
					int_5 = 120;
					int_6 = int_0;
					bool_0 = true;
					smethod_3();
				}
			}
			else
			{
				int_5 = 60;
				int_6 = 0;
				bool_0 = true;
				smethod_3();
			}
		}
		else
		{
			int_6 = int_0 / 2;
			int_5 = 80;
			bool_0 = true;
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
		bool_0 = true;
	}

	public static void smethod_4()
	{
		int_12[2] = int_12[1];
		int_11[2] = int_11[1];
		int_12[1] = int_12[0];
		int_11[1] = int_11[0];
		int_12[0] = int_4;
		int_11[0] = int_3;
		int_3 = GClass50.smethod_2((int)((double)int_5 * Math.PI / 180.0)) * int_9 * int_8 + int_6;
		int_4 = (int)((float)(int_9 * GClass50.smethod_1((int)((double)int_5 * Math.PI / 180.0)) * int_8) - float_0 * (float)int_8 * (float)int_8 / 2f) + int_7;
		if (smethod_5() - long_0 >= long_1)
		{
			int_8++;
			long_0 = smethod_5();
		}
	}

	public static long smethod_5()
	{
		return GClass203.smethod_18();
	}
}
