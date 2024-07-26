public class GClass94 : GClass93
{
	public int int_0;

	private GClass180 gclass180_0;

	public static GClass2 gclass2_0 = new GClass2();

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	private int int_9;

	public bool bool_0;

	public int int_10;

	public int int_11;

	public GClass78 gclass78_0;

	public bool bool_1;

	public GClass88 gclass88_6 = new GClass88();

	private int int_12;

	private int int_13;

	public static int[] int_14 = new int[18]
	{
		0, 15, 37, 52, 75, 105, 127, 142, 165, 195,
		217, 232, 255, 285, 307, 322, 345, 370
	};

	public static int[] int_15 = new int[16]
	{
		0, 0, 0, 7, 6, 6, 6, 2, 2, 3,
		3, 4, 5, 5, 5, 1
	};

	public static sbyte[] sbyte_0 = new sbyte[25]
	{
		0, 1, 2, 1, 0, 1, 2, 1, 0, 1,
		2, 1, 0, 1, 2, 1, 0, 1, 2, 1,
		0, 1, 2, 1, 0
	};

	public GClass94(int x, int y, bool isBoss, int dame, int dameMp, GClass78 c, int dartType)
	{
		gclass180_0 = GClass144.gclass180_0[dartType];
		int_4 = x;
		int_5 = y;
		bool_1 = isBoss;
		int_10 = dame;
		int_11 = dameMp;
		gclass78_0 = c;
		int_0 = gclass180_0.int_0;
		method_0(GClass50.smethod_5(c.int_4 - x, c.int_5 - y));
		if (x >= GClass144.int_22 && x <= GClass144.int_22 + GClass73.int_10)
			GClass109.smethod_1().method_28(dartType);
	}

	public GClass94(int x, int y, bool isBoss, int dame, int dameMp, int xTo, int yTo, int dartType)
	{
		gclass180_0 = GClass144.gclass180_0[dartType];
		int_4 = x;
		int_5 = y;
		bool_1 = isBoss;
		int_10 = dame;
		int_11 = dameMp;
		int_7 = xTo;
		int_8 = yTo;
		int_0 = gclass180_0.int_0;
		method_0(GClass50.smethod_5(xTo - x, yTo - y));
		if (x >= GClass144.int_22 && x <= GClass144.int_22 + GClass73.int_10)
			GClass109.smethod_1().method_28(dartType);
		gclass78_0 = null;
	}

	public void method_0(int angle)
	{
		int_1 = angle;
		int_2 = int_0 * GClass50.smethod_2(angle) >> 10;
		int_3 = int_0 * GClass50.smethod_1(angle) >> 10;
	}

	public static void smethod_0(int x, int y, bool isBoss, int dame, int dameMp, GClass78 c, int dartType)
	{
		GClass93.gclass88_1.method_0(new GClass94(x, y, isBoss, dame, dameMp, c, dartType));
	}

	public static void smethod_1(int x, int y, bool isBoss, int dame, int dameMp, int xTo, int yTo, int dartType)
	{
		GClass93.gclass88_1.method_0(new GClass94(x, y, isBoss, dame, dameMp, xTo, yTo, dartType));
	}

	public override void update()
	{
		for (int i = 0; i < gclass180_0.short_8; i++)
		{
			if (gclass180_0.short_3.Length != 0)
				gclass88_6.method_0(new GClass193(int_4, int_5));
			int_12 = ((gclass78_0 != null) ? gclass78_0.int_4 : int_7) - int_4;
			int_13 = ((gclass78_0 == null) ? int_8 : gclass78_0.int_5) - 10 - int_5;
			int num = 60;
			if (GClass20.int_37 == 0)
				num = 600;
			int_9++;
			if ((gclass78_0 != null && (gclass78_0.int_11 == 5 || gclass78_0.int_11 == 14)) || gclass78_0 == null)
			{
				int_4 += (((gclass78_0 == null) ? int_7 : gclass78_0.int_4) - int_4) / 2;
				int_5 += (((gclass78_0 != null) ? gclass78_0.int_5 : int_8) - int_5) / 2;
			}
			if ((GClass50.smethod_28(int_12) < 16 && GClass50.smethod_28(int_13) < 16) || int_9 > num)
			{
				if (gclass78_0 != null && gclass78_0.int_13 >= 0 && int_11 != -1)
				{
					if (int_11 != -100)
						gclass78_0.method_112(int_10, int_11, false, true);
					else
						GClass97.smethod_3(80, gclass78_0, 1);
				}
				GClass93.gclass88_1.method_8(this);
				if (int_11 != -100)
				{
					GClass97.smethod_3(81, gclass78_0, 1);
					if (int_4 >= GClass144.int_22 && int_4 <= GClass144.int_22 + GClass73.int_10)
						GClass109.smethod_1().method_23();
				}
			}
			int num2 = GClass50.smethod_5(int_12, int_13);
			if (GClass118.smethod_0(num2 - int_1) < 90 || int_12 * int_12 + int_13 * int_13 > 4096)
			{
				if (GClass118.smethod_0(num2 - int_1) >= 15)
				{
					if ((num2 - int_1 >= 0 && num2 - int_1 < 180) || num2 - int_1 < -180)
						int_1 = GClass50.smethod_6(int_1 + 15);
					else
						int_1 = GClass50.smethod_6(int_1 - 15);
				}
				else
					int_1 = num2;
			}
			if (!bool_0 && int_0 < 8192)
				int_0 += 1024;
			int_2 = int_0 * GClass50.smethod_2(int_1) >> 10;
			int_3 = int_0 * GClass50.smethod_1(int_1) >> 10;
			int_12 += int_2;
			int_4 += int_12 >> 10;
			int_12 &= 1023;
			int_13 += int_3;
			int_5 += int_13 >> 10;
			int_13 &= 1023;
		}
		for (int j = 0; j < gclass88_6.method_2(); j++)
		{
			GClass193 gClass = (GClass193)gclass88_6.method_3(j);
			gClass.int_0++;
			if (gClass.int_0 >= gclass180_0.short_3.Length)
				gclass88_6.method_7(j);
		}
	}

	public static int smethod_2(int angle)
	{
		for (int i = 0; i < int_14.Length - 1; i++)
		{
			if (angle >= int_14[i] && angle <= int_14[i + 1])
			{
				if (i < 16)
					return i;
				return 0;
			}
		}
		return 0;
	}

	public override void paint(GClass122 g)
	{
		int num = smethod_2(360 - int_1);
		int num2 = sbyte_0[num];
		int transform = int_15[num];
		for (int i = gclass88_6.method_2() / 2; i < gclass88_6.method_2(); i++)
		{
			GClass193 gClass = (GClass193)gclass88_6.method_3(i);
			GClass28.smethod_6(g, gclass180_0.short_4[gClass.int_0], gClass.int_1, gClass.int_2, 0, 3);
		}
		int num3 = GClass73.int_8 % gclass180_0.short_2.Length;
		GClass28.smethod_6(g, gclass180_0.short_2[num3][num2], int_4, int_5, transform, 3);
		for (int j = 0; j < gclass88_6.method_2(); j++)
		{
			GClass193 gClass2 = (GClass193)gclass88_6.method_3(j);
			GClass28.smethod_6(g, gclass180_0.short_3[gClass2.int_0], gClass2.int_1, gClass2.int_2, 0, 3);
		}
		GClass28.smethod_6(g, gclass180_0.short_1[num3][num2], int_4, int_5, transform, 3);
		for (int k = 0; k < gclass88_6.method_2(); k++)
		{
			GClass193 gClass3 = (GClass193)gclass88_6.method_3(k);
			if (GClass50.smethod_28(gclass2_0.method_1(100)) < gclass180_0.short_7)
				GClass28.smethod_6(g, (GClass73.int_8 % 2 != 0) ? gclass180_0.short_6[gClass3.int_0] : gclass180_0.short_5[gClass3.int_0], gClass3.int_1, gClass3.int_2, 0, 3);
		}
	}

	public static void smethod_3(int x2, int y2, bool checkIsBoss, int dame2, int dameMp2, GClass194 mobToAttack, sbyte dartType)
	{
		smethod_1(x2, y2, checkIsBoss, dame2, dameMp2, mobToAttack.int_8, mobToAttack.int_9, dartType);
	}
}
