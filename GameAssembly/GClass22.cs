public class GClass22
{
	public GClass58 gclass58_0;

	public GClass40 gclass40_0;

	public GClass63 gclass63_0 = new GClass63();

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	public bool bool_0 = true;

	public bool bool_1;

	public GClass75 gclass75_0;

	public GClass22(GClass58 charBelong, int dartType, GClass75 sp, int x, int y)
	{
		gclass75_0 = sp;
		gclass58_0 = charBelong;
		gclass40_0 = GClass154.gclass40_0[dartType];
		int_3 = gclass40_0.int_0;
		int_4 = x;
		int_5 = y;
		GInterface4 gInterface = ((charBelong.gclass85_0 != null) ? ((GInterface4)charBelong.gclass85_0) : ((GInterface4)charBelong.gclass58_0));
		method_0(GClass56.smethod_5(gInterface.getX() - x, gInterface.getY() - y));
	}

	public void method_0(int angle)
	{
		int_0 = angle;
		int_1 = int_3 * GClass56.smethod_2(angle) >> 10;
		int_2 = int_3 * GClass56.smethod_1(angle) >> 10;
	}

	public void method_1()
	{
		if (!bool_0)
			return;
		if (gclass58_0.gclass85_0 == null && gclass58_0.gclass58_0 == null)
		{
			EdlfUinyWP();
			return;
		}
		GInterface4 gInterface = ((gclass58_0.gclass85_0 != null) ? ((GInterface4)gclass58_0.gclass85_0) : ((GInterface4)gclass58_0.gclass58_0));
		int num = 0;
		while (true)
		{
			if (num < gclass40_0.short_8)
			{
				if (gclass40_0.short_3.Length != 0)
					gclass63_0.method_0(new GClass47(int_4, int_5));
				int num2 = ((gclass58_0.getX() <= gInterface.getX()) ? (-10) : 10);
				int_8 = gInterface.getX() + num2 - int_4;
				int_9 = gInterface.getY() - gInterface.getH() / 2 - int_5;
				int_7++;
				if (GClass56.smethod_28(int_8) < 20 && GClass56.smethod_28(int_9) < 20)
					break;
				int num3 = GClass56.smethod_5(int_8, int_9);
				if (GClass26.smethod_0(num3 - int_0) < 90 || int_8 * int_8 + int_9 * int_9 > 4096)
				{
					if (GClass26.smethod_0(num3 - int_0) < 15)
						int_0 = num3;
					else if ((num3 - int_0 >= 0 && num3 - int_0 < 180) || num3 - int_0 < -180)
					{
						int_0 = GClass56.smethod_6(int_0 + 15);
					}
					else
					{
						int_0 = GClass56.smethod_6(int_0 - 15);
					}
				}
				if (!bool_1 && int_3 < 8192)
					int_3 += 1024;
				int_1 = int_3 * GClass56.smethod_2(int_0) >> 10;
				int_2 = int_3 * GClass56.smethod_1(int_0) >> 10;
				int_8 += int_1;
				int_4 += int_8 >> 10;
				int_8 &= 1023;
				int_9 += int_2;
				int_5 += int_9 >> 10;
				int_9 &= 1023;
				num++;
				continue;
			}
			for (int i = 0; i < gclass63_0.method_2(); i++)
			{
				GClass47 gClass = (GClass47)gclass63_0.method_3(i);
				gClass.int_0++;
				if (gClass.int_0 >= gclass40_0.short_3.Length)
					gclass63_0.method_7(i);
			}
			return;
		}
		if (gclass58_0.gclass58_0 != null && gclass58_0.gclass58_0.bool_10)
			gclass58_0.gclass58_0.method_110(gclass58_0.gclass58_0.int_39, 0, gclass58_0.gclass58_0.bool_6, gclass58_0.gclass58_0.bool_5);
		EdlfUinyWP();
	}

	private void EdlfUinyWP()
	{
		if (!gclass58_0.bool_45 && int_4 >= GClass154.int_22 && int_4 <= GClass154.int_22 + GClass39.int_10)
			GClass29.smethod_1().method_22();
		gclass58_0.method_75();
		if (gclass58_0.bool_10)
			gclass58_0.method_27();
		if (gclass58_0.bool_45)
		{
			gclass58_0.bool_45 = false;
			if (gclass58_0.bool_36 && gclass58_0.bool_10 && gclass58_0.int_11 != 14 && gclass58_0.int_11 != 5)
				gclass58_0.bool_36 = false;
			GClass154.smethod_8().method_51(int_4, int_5);
		}
		gclass58_0.gclass22_0 = null;
		gclass58_0.bool_44 = false;
		gclass58_0.gclass75_0 = null;
		gclass58_0.gclass75_1 = null;
	}

	public void method_2(GClass76 g)
	{
		if (!bool_0)
			return;
		int num = GClass73.smethod_2(360 - int_0);
		int num2 = GClass73.sbyte_0[num];
		int transform = GClass73.int_15[num];
		for (int i = gclass63_0.method_2() / 2; i < gclass63_0.method_2(); i++)
		{
			GClass47 gClass = (GClass47)gclass63_0.method_3(i);
			GClass96.smethod_6(g, gclass40_0.short_4[gClass.int_0], gClass.int_1, gClass.int_2, 0, 3);
		}
		int num3 = GClass39.int_8 % gclass40_0.short_2.Length;
		GClass96.smethod_6(g, gclass40_0.short_2[num3][num2], int_4, int_5, transform, 3);
		for (int j = 0; j < gclass63_0.method_2(); j++)
		{
			GClass47 gClass2 = (GClass47)gclass63_0.method_3(j);
			GClass96.smethod_6(g, gclass40_0.short_3[gClass2.int_0], gClass2.int_1, gClass2.int_2, 0, 3);
		}
		GClass96.smethod_6(g, gclass40_0.short_1[num3][num2], int_4, int_5, transform, 3);
		for (int k = 0; k < gclass63_0.method_2(); k++)
		{
			GClass47 gClass3 = (GClass47)gclass63_0.method_3(k);
			if (GClass56.smethod_28(GClass73.gclass91_0.method_1(100)) < gclass40_0.short_7)
				GClass96.smethod_6(g, (GClass39.int_8 % 2 != 0) ? gclass40_0.short_6[gClass3.int_0] : gclass40_0.short_5[gClass3.int_0], gClass3.int_1, gClass3.int_2, 0, 3);
		}
		g.method_16(16711680);
	}
}
