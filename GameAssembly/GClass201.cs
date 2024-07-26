public class GClass201
{
	public GClass78 gclass78_0;

	public GClass180 gclass180_0;

	public GClass88 gclass88_0 = new GClass88();

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

	public GClass39 gclass39_0;

	public GClass201(GClass78 charBelong, int dartType, GClass39 sp, int x, int y)
	{
		gclass39_0 = sp;
		gclass78_0 = charBelong;
		gclass180_0 = GClass144.gclass180_0[dartType];
		int_3 = gclass180_0.int_0;
		int_4 = x;
		int_5 = y;
		GInterface1 gInterface = ((charBelong.gclass194_0 == null) ? ((GInterface1)charBelong.gclass78_0) : ((GInterface1)charBelong.gclass194_0));
		method_0(GClass50.smethod_5(gInterface.getX() - x, gInterface.getY() - y));
	}

	public void method_0(int angle)
	{
		int_0 = angle;
		int_1 = int_3 * GClass50.smethod_2(angle) >> 10;
		int_2 = int_3 * GClass50.smethod_1(angle) >> 10;
	}

	public void method_1()
	{
		if (!bool_0)
			return;
		if (gclass78_0.gclass194_0 != null || gclass78_0.gclass78_0 != null)
		{
			GInterface1 gInterface = ((gclass78_0.gclass194_0 == null) ? ((GInterface1)gclass78_0.gclass78_0) : ((GInterface1)gclass78_0.gclass194_0));
			for (int i = 0; i < gclass180_0.short_8; i++)
			{
				if (gclass180_0.short_3.Length != 0)
					gclass88_0.method_0(new GClass193(int_4, int_5));
				int num = ((gclass78_0.getX() <= gInterface.getX()) ? (-10) : 10);
				int_8 = gInterface.getX() + num - int_4;
				int_9 = gInterface.getY() - gInterface.getH() / 2 - int_5;
				int_7++;
				if (GClass50.smethod_28(int_8) >= 20 || GClass50.smethod_28(int_9) >= 20)
				{
					int num2 = GClass50.smethod_5(int_8, int_9);
					if (GClass118.smethod_0(num2 - int_0) < 90 || int_8 * int_8 + int_9 * int_9 > 4096)
					{
						if (GClass118.smethod_0(num2 - int_0) < 15)
							int_0 = num2;
						else if ((num2 - int_0 >= 0 && num2 - int_0 < 180) || num2 - int_0 < -180)
						{
							int_0 = GClass50.smethod_6(int_0 + 15);
						}
						else
						{
							int_0 = GClass50.smethod_6(int_0 - 15);
						}
					}
					if (!bool_1 && int_3 < 8192)
						int_3 += 1024;
					int_1 = int_3 * GClass50.smethod_2(int_0) >> 10;
					int_2 = int_3 * GClass50.smethod_1(int_0) >> 10;
					int_8 += int_1;
					int_4 += int_8 >> 10;
					int_8 &= 1023;
					int_9 += int_2;
					int_5 += int_9 >> 10;
					int_9 &= 1023;
					continue;
				}
				if (gclass78_0.gclass78_0 != null && gclass78_0.gclass78_0.bool_10)
					gclass78_0.gclass78_0.method_112(gclass78_0.gclass78_0.int_39, 0, gclass78_0.gclass78_0.bool_6, gclass78_0.gclass78_0.bool_5);
				method_2();
				return;
			}
			for (int j = 0; j < gclass88_0.method_2(); j++)
			{
				GClass193 gClass = (GClass193)gclass88_0.method_3(j);
				gClass.int_0++;
				if (gClass.int_0 >= gclass180_0.short_3.Length)
					gclass88_0.method_7(j);
			}
		}
		else
			method_2();
	}

	private void method_2()
	{
		if (!gclass78_0.bool_45 && int_4 >= GClass144.int_22 && int_4 <= GClass144.int_22 + GClass73.int_10)
			GClass109.smethod_1().method_22();
		gclass78_0.method_76();
		if (gclass78_0.bool_10)
			gclass78_0.method_28();
		if (gclass78_0.bool_45)
		{
			gclass78_0.bool_45 = false;
			if (gclass78_0.bool_36 && gclass78_0.bool_10 && gclass78_0.int_11 != 14 && gclass78_0.int_11 != 5)
				gclass78_0.bool_36 = false;
			GClass144.smethod_8().method_51(int_4, int_5);
		}
		gclass78_0.gclass201_0 = null;
		gclass78_0.bool_44 = false;
		gclass78_0.gclass39_0 = null;
		gclass78_0.gclass39_1 = null;
	}

	public void method_3(GClass122 g)
	{
		if (!bool_0)
			return;
		int num = GClass94.smethod_2(360 - int_0);
		int num2 = GClass94.sbyte_0[num];
		int transform = GClass94.int_15[num];
		for (int i = gclass88_0.method_2() / 2; i < gclass88_0.method_2(); i++)
		{
			GClass193 gClass = (GClass193)gclass88_0.method_3(i);
			GClass28.smethod_6(g, gclass180_0.short_4[gClass.int_0], gClass.int_1, gClass.int_2, 0, 3);
		}
		int num3 = GClass73.int_8 % gclass180_0.short_2.Length;
		GClass28.smethod_6(g, gclass180_0.short_2[num3][num2], int_4, int_5, transform, 3);
		for (int j = 0; j < gclass88_0.method_2(); j++)
		{
			GClass193 gClass2 = (GClass193)gclass88_0.method_3(j);
			GClass28.smethod_6(g, gclass180_0.short_3[gClass2.int_0], gClass2.int_1, gClass2.int_2, 0, 3);
		}
		GClass28.smethod_6(g, gclass180_0.short_1[num3][num2], int_4, int_5, transform, 3);
		for (int k = 0; k < gclass88_0.method_2(); k++)
		{
			GClass193 gClass3 = (GClass193)gclass88_0.method_3(k);
			if (GClass50.smethod_28(GClass94.gclass2_0.method_1(100)) < gclass180_0.short_7)
				GClass28.smethod_6(g, (GClass73.int_8 % 2 != 0) ? gclass180_0.short_6[gClass3.int_0] : gclass180_0.short_5[gClass3.int_0], gClass3.int_1, gClass3.int_2, 0, 3);
		}
		g.method_16(16711680);
	}
}
