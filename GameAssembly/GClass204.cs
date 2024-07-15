public class GClass204
{
	public GClass124 gclass124_0;

	public GClass28 gclass28_0;

	public GClass122 gclass122_0 = new GClass122();

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

	public GClass135 gclass135_0;

	public GClass204(GClass124 charBelong, int dartType, GClass135 sp, int x, int y)
	{
		gclass135_0 = sp;
		gclass124_0 = charBelong;
		gclass28_0 = GClass167.gclass28_0[dartType];
		int_3 = gclass28_0.int_0;
		int_4 = x;
		int_5 = y;
		GInterface6 gInterface = ((charBelong.gclass6_0 == null) ? ((GInterface6)charBelong.gclass124_0) : ((GInterface6)charBelong.gclass6_0));
		method_0(GClass191.smethod_5(gInterface.getX() - x, gInterface.getY() - y));
	}

	public void method_0(int angle)
	{
		int_0 = angle;
		int_1 = int_3 * GClass191.smethod_2(angle) >> 10;
		int_2 = int_3 * GClass191.smethod_1(angle) >> 10;
	}

	public void method_1()
	{
		if (!bool_0)
			return;
		if (gclass124_0.gclass6_0 != null || gclass124_0.gclass124_0 != null)
		{
			GInterface6 gInterface = ((gclass124_0.gclass6_0 != null) ? ((GInterface6)gclass124_0.gclass6_0) : ((GInterface6)gclass124_0.gclass124_0));
			int num = 0;
			while (true)
			{
				if (num < gclass28_0.short_8)
				{
					if (gclass28_0.short_3.Length != 0)
						gclass122_0.method_0(new GClass129(int_4, int_5));
					int num2 = ((gclass124_0.getX() > gInterface.getX()) ? 10 : (-10));
					int_8 = gInterface.getX() + num2 - int_4;
					int_9 = gInterface.getY() - gInterface.getH() / 2 - int_5;
					int_7++;
					if (GClass191.smethod_28(int_8) < 20 && GClass191.smethod_28(int_9) < 20)
						break;
					int num3 = GClass191.smethod_5(int_8, int_9);
					if (GClass13.smethod_0(num3 - int_0) < 90 || int_8 * int_8 + int_9 * int_9 > 4096)
					{
						if (GClass13.smethod_0(num3 - int_0) >= 15)
						{
							if ((num3 - int_0 < 0 || num3 - int_0 >= 180) && num3 - int_0 >= -180)
								int_0 = GClass191.smethod_6(int_0 - 15);
							else
								int_0 = GClass191.smethod_6(int_0 + 15);
						}
						else
							int_0 = num3;
					}
					if (!bool_1 && int_3 < 8192)
						int_3 += 1024;
					int_1 = int_3 * GClass191.smethod_2(int_0) >> 10;
					int_2 = int_3 * GClass191.smethod_1(int_0) >> 10;
					int_8 += int_1;
					int_4 += int_8 >> 10;
					int_8 &= 1023;
					int_9 += int_2;
					int_5 += int_9 >> 10;
					int_9 &= 1023;
					num++;
					continue;
				}
				for (int i = 0; i < gclass122_0.method_2(); i++)
				{
					GClass129 gClass = (GClass129)gclass122_0.method_3(i);
					gClass.int_0++;
					if (gClass.int_0 >= gclass28_0.short_3.Length)
						gclass122_0.method_7(i);
				}
				return;
			}
			if (gclass124_0.gclass124_0 != null && gclass124_0.gclass124_0.bool_10)
				gclass124_0.gclass124_0.method_112(gclass124_0.gclass124_0.int_39, 0, gclass124_0.gclass124_0.bool_6, gclass124_0.gclass124_0.bool_5);
			method_2();
		}
		else
			method_2();
	}

	private void method_2()
	{
		if (!gclass124_0.bool_45 && int_4 >= GClass167.int_22 && int_4 <= GClass167.int_22 + GClass14.int_10)
			GClass147.smethod_1().method_22();
		gclass124_0.method_76();
		if (gclass124_0.bool_10)
			gclass124_0.method_28();
		if (gclass124_0.bool_45)
		{
			gclass124_0.bool_45 = false;
			if (gclass124_0.bool_36 && gclass124_0.bool_10 && gclass124_0.int_11 != 14 && gclass124_0.int_11 != 5)
				gclass124_0.bool_36 = false;
			GClass167.smethod_8().method_51(int_4, int_5);
		}
		gclass124_0.gclass204_0 = null;
		gclass124_0.bool_44 = false;
		gclass124_0.gclass135_0 = null;
		gclass124_0.gclass135_1 = null;
	}

	public void method_3(GClass193 g)
	{
		if (!bool_0)
			return;
		int num = GClass89.smethod_2(360 - int_0);
		int num2 = GClass89.sbyte_0[num];
		int transform = GClass89.int_15[num];
		for (int i = gclass122_0.method_2() / 2; i < gclass122_0.method_2(); i++)
		{
			GClass129 gClass = (GClass129)gclass122_0.method_3(i);
			GClass72.smethod_6(g, gclass28_0.short_4[gClass.int_0], gClass.int_1, gClass.int_2, 0, 3);
		}
		int num3 = GClass14.int_8 % gclass28_0.short_2.Length;
		GClass72.smethod_6(g, gclass28_0.short_2[num3][num2], int_4, int_5, transform, 3);
		for (int j = 0; j < gclass122_0.method_2(); j++)
		{
			GClass129 gClass2 = (GClass129)gclass122_0.method_3(j);
			GClass72.smethod_6(g, gclass28_0.short_3[gClass2.int_0], gClass2.int_1, gClass2.int_2, 0, 3);
		}
		GClass72.smethod_6(g, gclass28_0.short_1[num3][num2], int_4, int_5, transform, 3);
		for (int k = 0; k < gclass122_0.method_2(); k++)
		{
			GClass129 gClass3 = (GClass129)gclass122_0.method_3(k);
			if (GClass191.smethod_28(GClass89.gclass134_0.method_1(100)) < gclass28_0.short_7)
				GClass72.smethod_6(g, (GClass14.int_8 % 2 != 0) ? gclass28_0.short_6[gClass3.int_0] : gclass28_0.short_5[gClass3.int_0], gClass3.int_1, gClass3.int_2, 0, 3);
		}
		g.method_16(16711680);
	}
}
