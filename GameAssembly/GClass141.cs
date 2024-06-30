public class GClass141 : GInterface0
{
	private int int_0;

	private int int_1;

	private int mipTgsfvMc;

	private int int_2;

	private GClass14 gclass14_0;

	private GClass14 gclass14_1;

	private GClass14 gclass14_2;

	private int int_3 = 24;

	public int int_4;

	private int int_5 = 50;

	public static GClass105 gclass105_0;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public bool bool_0;

	public bool bool_1;

	public string string_0;

	private bool bool_2;

	private bool bool_3;

	public GClass63 gclass63_0 = new GClass63();

	private int int_10;

	private int int_11;

	private int int_12;

	private GClass98 gclass98_0;

	public GClass141()
	{
		gclass14_0 = new GClass14(mResources.SELECT, this, 1, null);
		gclass14_1 = new GClass14(mResources.CLOSE, this, 2, null);
	}

	public void method_0()
	{
		if (bool_1)
		{
			mipTgsfvMc = 170;
			int_2 = 118;
			int_0 = GClass39.int_10 / 2 - mipTgsfvMc / 2;
			int_1 = GClass39.int_11 / 2 - int_2 / 2;
		}
		else
		{
			mipTgsfvMc = 170;
			int_2 = 170;
			int_0 = GClass39.int_10 / 2 - mipTgsfvMc / 2;
			int_1 = GClass39.int_11 / 2 - int_2 / 2;
			if (GClass39.int_11 < 240)
				int_1 -= 10;
		}
		int_7 = int_0;
		int_6 = 0;
		if (!bool_2)
			int_4 = GClass137.gclass63_0.method_2();
		else
			int_4 = gclass63_0.method_2();
		if (GClass39.bool_5)
		{
			gclass14_0.int_1 = int_0;
			gclass14_0.int_2 = int_1 + int_2 + 5;
			gclass14_1.int_1 = int_0 + mipTgsfvMc - 68;
			gclass14_1.int_2 = int_1 + int_2 + 5;
		}
		gclass105_0 = new GClass105();
		gclass105_0.method_6(int_4, int_3, int_0, int_1 + int_5, mipTgsfvMc, int_2 - int_5, true, 1);
	}

	public void method_1(bool isGetName)
	{
		if (GClass58.smethod_1().gclass21_0 != null)
			bool_3 = true;
		bool_0 = true;
		bool_1 = isGetName;
		method_0();
	}

	public void method_2(int msgID)
	{
		bool_0 = true;
		bool_2 = true;
		int_10 = msgID;
		method_0();
	}

	public void method_3()
	{
		int_6 = int_0 + mipTgsfvMc;
		GClass96.smethod_4();
	}

	public void method_4(GClass76 g)
	{
	}

	public void method_5(GClass76 g)
	{
		g.method_1(-int_7, 0);
		GClass24.smethod_4(g, int_0, int_1 - 17, mipTgsfvMc, int_2 + 17, -1, true);
		GClass49.gclass49_6.method_6(g, mResources.select_clan_icon, int_0 + mipTgsfvMc / 2, int_1 - 7, 2);
		if (int_12 >= 0 && int_12 <= GClass137.gclass63_0.method_2() - 1)
		{
			GClass137 gClass = (GClass137)GClass137.gclass63_0.method_3(int_12);
			if (gClass.short_0 != null)
				GClass58.smethod_1().method_92(g, gClass.short_0, GClass39.int_10 / 2, int_1 + 45, 1, false);
		}
		GClass58.smethod_1().method_96(g, GClass39.int_10 / 2, int_1 + 45, 1, GClass58.smethod_1().int_63, false);
		g.method_5(int_0, int_1 + int_5, mipTgsfvMc, int_2 - int_5 - 10);
		if (gclass105_0 != null)
			g.method_1(0, -gclass105_0.int_3);
		for (int i = 0; i < int_4; i++)
		{
			int num = int_0 + 10;
			int num2 = int_1 + i * int_3 + int_5;
			if (num2 + int_3 - ((gclass105_0 != null) ? gclass105_0.int_3 : 0) >= int_1 + int_5 && num2 - ((gclass105_0 != null) ? gclass105_0.int_3 : 0) <= int_1 + int_5 + int_2)
			{
				GClass137 gClass2 = (GClass137)GClass137.gclass63_0.method_3(i);
				GClass49 gClass3 = GClass49.gclass49_16;
				if (i == int_12)
					gClass3 = GClass49.gclass49_18;
				if (gClass2.string_0 != null)
					gClass3.method_6(g, gClass2.string_0, num + 20, num2, 0);
				if (gClass2.int_1 > 0)
					gClass3.method_6(g, gClass2.int_1 + " " + mResources.XU, num + mipTgsfvMc - 20, num2, GClass49.int_1);
				else if (gClass2.int_2 > 0)
				{
					gClass3.method_6(g, gClass2.int_2 + " " + mResources.LUONG, num + mipTgsfvMc - 20, num2, GClass49.int_1);
				}
				if (gClass2.short_0 != null)
					GClass96.smethod_6(g, gClass2.short_0[0], num, num2, 0, 0);
			}
		}
		g.method_1(0, -g.method_4());
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		GClass39.gclass37_0.method_7(g, gclass14_0, gclass14_2, gclass14_1);
	}

	public void method_6(GClass76 g)
	{
		if (!bool_2)
			method_5(g);
		else
			method_4(g);
	}

	public void method_7()
	{
		if (gclass105_0 != null)
			gclass105_0.method_5();
		if (int_7 != int_6)
		{
			int_8 = int_6 - int_7 << 2;
			int_9 += int_8;
			int_7 += int_9 >> 3;
			int_9 &= 15;
		}
		if (GClass26.smethod_0(int_6 - int_7) < 10)
			int_7 = int_6;
		if (int_7 >= int_0 + mipTgsfvMc - 10 && int_6 >= int_0 + mipTgsfvMc - 10)
			bool_0 = false;
	}

	public void method_8()
	{
		if (gclass14_0 != null && (GClass39.bool_11[12] || GClass145.smethod_1(gclass14_0)))
			gclass14_0.method_1();
		if (gclass14_1 != null && (GClass39.bool_11[13] || GClass145.smethod_1(gclass14_1)))
			gclass14_1.method_1();
		if (gclass14_2 != null && (GClass39.bool_11[(!Main.isPC) ? 5 : 25] || GClass145.smethod_1(gclass14_2)))
			gclass14_2.method_1();
		if (!bool_1)
		{
			if (gclass105_0 == null)
				return;
			if (GClass39.bool_5)
			{
				gclass105_0.method_1();
				int_11 = gclass105_0.int_18;
			}
			if (GClass39.bool_11[(!Main.isPC) ? 2 : 21])
			{
				GClass39.bool_11[(!Main.isPC) ? 2 : 21] = false;
				int_11--;
				if (int_11 < 0)
					int_11 = int_4 - 1;
				gclass105_0.method_7(int_11 * gclass105_0.int_19);
			}
			if (GClass39.bool_11[(!Main.isPC) ? 8 : 22])
			{
				GClass39.bool_11[(!Main.isPC) ? 8 : 22] = false;
				int_11++;
				if (int_11 > int_4 - 1)
					int_11 = 0;
				gclass105_0.method_7(int_11 * gclass105_0.int_19);
			}
			if (int_11 != -1)
				int_12 = int_11;
		}
		GClass39.smethod_27();
		GClass39.smethod_26();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 2)
			method_3();
		if (idAction != 1 || bool_1)
			return;
		if (!bool_2)
		{
			if (int_12 >= 0)
			{
				method_3();
				if (GClass58.smethod_1().gclass21_0 == null)
					GClass166.smethod_0().method_28(2, (sbyte)((GClass137)GClass137.gclass63_0.method_3(int_12)).int_0, string_0);
				else
					GClass166.smethod_0().method_28(4, (sbyte)((GClass137)GClass137.gclass63_0.method_3(int_12)).int_0, string.Empty);
			}
		}
		else if (int_12 >= 0)
		{
			_ = (GClass121)gclass63_0.method_3(int_11);
		}
	}
}
