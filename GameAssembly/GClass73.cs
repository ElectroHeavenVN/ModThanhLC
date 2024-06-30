public class GClass73 : GClass68
{
	public int int_0;

	private GClass40 gclass40_0;

	public static GClass91 gclass91_0 = new GClass91();

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

	public GClass58 gclass58_0;

	public bool bool_1;

	public GClass63 gclass63_6 = new GClass63();

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

	public GClass73(int x, int y, bool isBoss, int dame, int dameMp, GClass58 c, int dartType)
	{
		gclass40_0 = GClass154.gclass40_0[dartType];
		int_4 = x;
		int_5 = y;
		bool_1 = isBoss;
		int_10 = dame;
		int_11 = dameMp;
		gclass58_0 = c;
		int_0 = gclass40_0.int_0;
		method_0(GClass56.smethod_5(c.int_4 - x, c.int_5 - y));
		if (x >= GClass154.int_22 && x <= GClass154.int_22 + GClass39.int_10)
			GClass29.smethod_1().method_28(dartType);
	}

	public GClass73(int x, int y, bool isBoss, int dame, int dameMp, int xTo, int yTo, int dartType)
	{
		gclass40_0 = GClass154.gclass40_0[dartType];
		int_4 = x;
		int_5 = y;
		bool_1 = isBoss;
		int_10 = dame;
		int_11 = dameMp;
		int_7 = xTo;
		int_8 = yTo;
		int_0 = gclass40_0.int_0;
		method_0(GClass56.smethod_5(xTo - x, yTo - y));
		if (x >= GClass154.int_22 && x <= GClass154.int_22 + GClass39.int_10)
			GClass29.smethod_1().method_28(dartType);
		gclass58_0 = null;
	}

	public void method_0(int angle)
	{
		int_1 = angle;
		int_2 = int_0 * GClass56.smethod_2(angle) >> 10;
		int_3 = int_0 * GClass56.smethod_1(angle) >> 10;
	}

	public static void smethod_0(int x, int y, bool isBoss, int dame, int dameMp, GClass58 c, int dartType)
	{
		GClass68.gclass63_1.method_0(new GClass73(x, y, isBoss, dame, dameMp, c, dartType));
	}

	public static void smethod_1(int x, int y, bool isBoss, int dame, int dameMp, int xTo, int yTo, int dartType)
	{
		GClass68.gclass63_1.method_0(new GClass73(x, y, isBoss, dame, dameMp, xTo, yTo, dartType));
	}

	public override void update()
	{
		for (int i = 0; i < gclass40_0.short_8; i++)
		{
			if (gclass40_0.short_3.Length != 0)
				gclass63_6.method_0(new GClass47(int_4, int_5));
			int_12 = ((gclass58_0 == null) ? int_7 : gclass58_0.int_4) - int_4;
			int_13 = ((gclass58_0 == null) ? int_8 : gclass58_0.int_5) - 10 - int_5;
			int num = 60;
			if (GClass1.int_37 == 0)
				num = 600;
			int_9++;
			if ((gclass58_0 != null && (gclass58_0.int_11 == 5 || gclass58_0.int_11 == 14)) || gclass58_0 == null)
			{
				int_4 += (((gclass58_0 == null) ? int_7 : gclass58_0.int_4) - int_4) / 2;
				int_5 += (((gclass58_0 == null) ? int_8 : gclass58_0.int_5) - int_5) / 2;
			}
			if ((GClass56.smethod_28(int_12) < 16 && GClass56.smethod_28(int_13) < 16) || int_9 > num)
			{
				if (gclass58_0 != null && gclass58_0.int_13 >= 0 && int_11 != -1)
				{
					if (int_11 != -100)
						gclass58_0.method_110(int_10, int_11, false, true);
					else
						GClass71.smethod_3(80, gclass58_0, 1);
				}
				GClass68.gclass63_1.method_8(this);
				if (int_11 != -100)
				{
					GClass71.smethod_3(81, gclass58_0, 1);
					if (int_4 >= GClass154.int_22 && int_4 <= GClass154.int_22 + GClass39.int_10)
						GClass29.smethod_1().method_23();
				}
			}
			int num2 = GClass56.smethod_5(int_12, int_13);
			if (GClass26.smethod_0(num2 - int_1) < 90 || int_12 * int_12 + int_13 * int_13 > 4096)
			{
				if (GClass26.smethod_0(num2 - int_1) < 15)
					int_1 = num2;
				else if ((num2 - int_1 >= 0 && num2 - int_1 < 180) || num2 - int_1 < -180)
				{
					int_1 = GClass56.smethod_6(int_1 + 15);
				}
				else
				{
					int_1 = GClass56.smethod_6(int_1 - 15);
				}
			}
			if (!bool_0 && int_0 < 8192)
				int_0 += 1024;
			int_2 = int_0 * GClass56.smethod_2(int_1) >> 10;
			int_3 = int_0 * GClass56.smethod_1(int_1) >> 10;
			int_12 += int_2;
			int_4 += int_12 >> 10;
			int_12 &= 1023;
			int_13 += int_3;
			int_5 += int_13 >> 10;
			int_13 &= 1023;
		}
		for (int j = 0; j < gclass63_6.method_2(); j++)
		{
			GClass47 gClass = (GClass47)gclass63_6.method_3(j);
			gClass.int_0++;
			if (gClass.int_0 >= gclass40_0.short_3.Length)
				gclass63_6.method_7(j);
		}
	}

	public static int smethod_2(int angle)
	{
		int num = 0;
		while (true)
		{
			if (num < int_14.Length - 1)
			{
				if (angle >= int_14[num] && angle <= int_14[num + 1])
					break;
				num++;
				continue;
			}
			return 0;
		}
		if (num >= 16)
			return 0;
		return num;
	}

	public override void paint(GClass76 g)
	{
		int num = smethod_2(360 - int_1);
		int num2 = sbyte_0[num];
		int transform = int_15[num];
		for (int i = gclass63_6.method_2() / 2; i < gclass63_6.method_2(); i++)
		{
			GClass47 gClass = (GClass47)gclass63_6.method_3(i);
			GClass96.smethod_6(g, gclass40_0.short_4[gClass.int_0], gClass.int_1, gClass.int_2, 0, 3);
		}
		int num3 = GClass39.int_8 % gclass40_0.short_2.Length;
		GClass96.smethod_6(g, gclass40_0.short_2[num3][num2], int_4, int_5, transform, 3);
		for (int j = 0; j < gclass63_6.method_2(); j++)
		{
			GClass47 gClass2 = (GClass47)gclass63_6.method_3(j);
			GClass96.smethod_6(g, gclass40_0.short_3[gClass2.int_0], gClass2.int_1, gClass2.int_2, 0, 3);
		}
		GClass96.smethod_6(g, gclass40_0.short_1[num3][num2], int_4, int_5, transform, 3);
		for (int k = 0; k < gclass63_6.method_2(); k++)
		{
			GClass47 gClass3 = (GClass47)gclass63_6.method_3(k);
			if (GClass56.smethod_28(gclass91_0.method_1(100)) < gclass40_0.short_7)
				GClass96.smethod_6(g, (GClass39.int_8 % 2 != 0) ? gclass40_0.short_6[gClass3.int_0] : gclass40_0.short_5[gClass3.int_0], gClass3.int_1, gClass3.int_2, 0, 3);
		}
	}

	public static void smethod_3(int x2, int y2, bool checkIsBoss, int dame2, int dameMp2, GClass85 mobToAttack, sbyte dartType)
	{
		smethod_1(x2, y2, checkIsBoss, dame2, dameMp2, mobToAttack.int_8, mobToAttack.int_9, dartType);
	}
}
