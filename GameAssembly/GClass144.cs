public class GClass144 : GInterface1
{
	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private GClass118 gclass118_0;

	private GClass118 gclass118_1;

	private GClass118 gclass118_2;

	private int int_4 = 24;

	public int int_5;

	private int int_6 = 50;

	public static GClass1 gclass1_0;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public bool bool_0;

	public bool bool_1;

	public string string_0;

	private bool bool_2;

	private bool bool_3;

	public GClass122 gclass122_0 = new GClass122();

	private int int_11;

	private int int_12;

	private int int_13;

	private GClass159 gclass159_0;

	public GClass144()
	{
		gclass118_0 = new GClass118(mResources.SELECT, this, 1, null);
		gclass118_1 = new GClass118(mResources.CLOSE, this, 2, null);
	}

	public void method_0()
	{
		if (!bool_1)
		{
			int_2 = 170;
			int_3 = 170;
			int_0 = GClass14.int_10 / 2 - int_2 / 2;
			int_1 = GClass14.int_11 / 2 - int_3 / 2;
			if (GClass14.int_11 < 240)
				int_1 -= 10;
		}
		else
		{
			int_2 = 170;
			int_3 = 118;
			int_0 = GClass14.int_10 / 2 - int_2 / 2;
			int_1 = GClass14.int_11 / 2 - int_3 / 2;
		}
		int_8 = int_0;
		int_7 = 0;
		if (!bool_2)
			int_5 = GClass68.gclass122_0.method_2();
		else
			int_5 = gclass122_0.method_2();
		if (GClass14.bool_5)
		{
			gclass118_0.int_1 = int_0;
			gclass118_0.int_2 = int_1 + int_3 + 5;
			gclass118_1.int_1 = int_0 + int_2 - 68;
			gclass118_1.int_2 = int_1 + int_3 + 5;
		}
		gclass1_0 = new GClass1();
		gclass1_0.method_6(int_5, int_4, int_0, int_1 + int_6, int_2, int_3 - int_6, true, 1);
	}

	public void method_1(bool isGetName)
	{
		if (GClass124.smethod_1().gclass187_0 != null)
			bool_3 = true;
		bool_0 = true;
		bool_1 = isGetName;
		method_0();
	}

	public void method_2(int msgID)
	{
		bool_0 = true;
		bool_2 = true;
		int_11 = msgID;
		method_0();
	}

	public void method_3()
	{
		int_7 = int_0 + int_2;
		GClass72.smethod_4();
	}

	public void method_4(GClass193 g)
	{
	}

	public void method_5(GClass193 g)
	{
		g.method_1(-int_8, 0);
		GClass139.smethod_4(g, int_0, int_1 - 17, int_2, int_3 + 17, -1, true);
		GClass104.gclass104_6.method_6(g, mResources.select_clan_icon, int_0 + int_2 / 2, int_1 - 7, 2);
		if (int_13 >= 0 && int_13 <= GClass68.gclass122_0.method_2() - 1)
		{
			GClass68 gClass = (GClass68)GClass68.gclass122_0.method_3(int_13);
			if (gClass.short_0 != null)
				GClass124.smethod_1().method_94(g, gClass.short_0, GClass14.int_10 / 2, int_1 + 45, 1, false);
		}
		GClass124.smethod_1().method_98(g, GClass14.int_10 / 2, int_1 + 45, 1, GClass124.smethod_1().int_63, false);
		g.method_5(int_0, int_1 + int_6, int_2, int_3 - int_6 - 10);
		if (gclass1_0 != null)
			g.method_1(0, -gclass1_0.int_3);
		for (int i = 0; i < int_5; i++)
		{
			int num = int_0 + 10;
			int num2 = int_1 + i * int_4 + int_6;
			if (num2 + int_4 - ((gclass1_0 != null) ? gclass1_0.int_3 : 0) < int_1 + int_6 || num2 - ((gclass1_0 != null) ? gclass1_0.int_3 : 0) > int_1 + int_6 + int_3)
				continue;
			GClass68 gClass2 = (GClass68)GClass68.gclass122_0.method_3(i);
			GClass104 gClass3 = GClass104.gclass104_16;
			if (i == int_13)
				gClass3 = GClass104.gclass104_18;
			if (gClass2.string_0 != null)
				gClass3.method_6(g, gClass2.string_0, num + 20, num2, 0);
			if (gClass2.int_1 <= 0)
			{
				if (gClass2.int_2 > 0)
					gClass3.method_6(g, gClass2.int_2 + " " + mResources.LUONG, num + int_2 - 20, num2, GClass104.int_1);
			}
			else
				gClass3.method_6(g, gClass2.int_1 + " " + mResources.XU, num + int_2 - 20, num2, GClass104.int_1);
			if (gClass2.short_0 != null)
				GClass72.smethod_6(g, gClass2.short_0[0], num, num2, 0, 0);
		}
		g.method_1(0, -g.method_4());
		g.method_5(0, 0, GClass14.int_10, GClass14.int_11);
		GClass14.gclass97_0.method_7(g, gclass118_0, gclass118_2, gclass118_1);
	}

	public void method_6(GClass193 g)
	{
		if (!bool_2)
			method_5(g);
		else
			method_4(g);
	}

	public void method_7()
	{
		if (gclass1_0 != null)
			gclass1_0.method_5();
		if (int_8 != int_7)
		{
			int_9 = int_7 - int_8 << 2;
			int_10 += int_9;
			int_8 += int_10 >> 3;
			int_10 &= 15;
		}
		if (GClass13.smethod_0(int_7 - int_8) < 10)
			int_8 = int_7;
		if (int_8 >= int_0 + int_2 - 10 && int_7 >= int_0 + int_2 - 10)
			bool_0 = false;
	}

	public void method_8()
	{
		if (gclass118_0 != null && (GClass14.bool_11[12] || GClass160.smethod_1(gclass118_0)))
			gclass118_0.method_1();
		if (gclass118_1 != null && (GClass14.bool_11[13] || GClass160.smethod_1(gclass118_1)))
			gclass118_1.method_1();
		if (gclass118_2 != null && (GClass14.bool_11[Main.isPC ? 25 : 5] || GClass160.smethod_1(gclass118_2)))
			gclass118_2.method_1();
		if (!bool_1)
		{
			if (gclass1_0 == null)
				return;
			if (GClass14.bool_5)
			{
				gclass1_0.method_1();
				int_12 = gclass1_0.int_18;
			}
			if (GClass14.bool_11[(!Main.isPC) ? 2 : 21])
			{
				GClass14.bool_11[Main.isPC ? 21 : 2] = false;
				int_12--;
				if (int_12 < 0)
					int_12 = int_5 - 1;
				gclass1_0.method_7(int_12 * gclass1_0.int_19);
			}
			if (GClass14.bool_11[Main.isPC ? 22 : 8])
			{
				GClass14.bool_11[(!Main.isPC) ? 8 : 22] = false;
				int_12++;
				if (int_12 > int_5 - 1)
					int_12 = 0;
				gclass1_0.method_7(int_12 * gclass1_0.int_19);
			}
			if (int_12 != -1)
				int_13 = int_12;
		}
		GClass14.smethod_27();
		GClass14.smethod_26();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 2)
			method_3();
		if (idAction != 1 || bool_1)
			return;
		if (!bool_2)
		{
			if (int_13 >= 0)
			{
				method_3();
				if (GClass124.smethod_1().gclass187_0 == null)
					GClass2.smethod_0().method_28(2, (sbyte)((GClass68)GClass68.gclass122_0.method_3(int_13)).int_0, string_0);
				else
					GClass2.smethod_0().method_28(4, (sbyte)((GClass68)GClass68.gclass122_0.method_3(int_13)).int_0, string.Empty);
			}
		}
		else if (int_13 >= 0)
		{
			_ = (GClass0)gclass122_0.method_3(int_12);
		}
	}
}
