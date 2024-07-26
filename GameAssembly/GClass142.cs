public class GClass142 : GClass131
{
	public static int int_6;

	private bool bool_0;

	private bool bool_1;

	public static int int_7 = -1;

	public static int int_8 = -1;

	public static GClass142 gclass142_0;

	public static GClass70 gclass70_0;

	private int int_9 = 10;

	public long long_0;

	public GClass142()
	{
		gclass142_0 = this;
	}

	public static void smethod_2()
	{
		int_6 = 0;
	}

	public override void update()
	{
		if (int_6 == 30 && !bool_0)
		{
			bool_0 = true;
			if (GClass1.smethod_8("serverchat") != -1)
				GClass144.bool_83 = GClass1.smethod_8("serverchat") == 0;
			if (GClass1.smethod_8("isPlaySound") != -1)
				GClass73.bool_21 = GClass1.smethod_8("isPlaySound") == 1;
			if (GClass73.bool_21)
				GClass109.smethod_1().method_0(GClass20.int_37);
			GClass109.smethod_1().method_2();
			GClass134.smethod_8();
		}
		int_6++;
		GClass134.smethod_5();
		if (int_6 >= 150)
		{
			GClass50.smethod_8("cho man hinh nay qa lau");
			if (GClass14.smethod_0().isConnected())
			{
				GClass134.bool_6 = true;
				GClass73.gclass134_0.switchToMe();
			}
			else
				GClass203.smethod_30();
		}
	}

	public static void smethod_3()
	{
		if (GClass1.smethod_8("svselect") != -1)
		{
			GClass134.int_14 = GClass1.smethod_8("svselect");
			if (GClass134.int_14 > GClass134.string_0.Length - 1)
			{
				GClass134.int_14 = GClass134.sbyte_0;
				GClass1.smethod_9("svselect", GClass134.int_14);
			}
			GClass187.string_0 = GClass134.string_1[GClass134.int_14];
			GClass187.int_0 = GClass134.short_0[GClass134.int_14];
			mResources.loadLanguague(GClass134.sbyte_1[GClass134.int_14]);
			GClass133.string_4 = GClass134.string_0[GClass134.int_14];
			GClass73.smethod_4();
			return;
		}
		int num = 0;
		if (mResources.language > 0)
		{
			for (int i = 0; i < mResources.language; i++)
			{
				num += GClass134.int_13[i];
			}
		}
		if (GClass134.sbyte_0 == -1)
			GClass134.int_14 = num + GClass50.smethod_19(0, GClass134.int_13[mResources.language]);
		else
			GClass134.int_14 = GClass134.sbyte_0;
		GClass1.smethod_9("svselect", GClass134.int_14);
		GClass187.string_0 = GClass134.string_1[GClass134.int_14];
		GClass187.int_0 = GClass134.short_0[GClass134.int_14];
		mResources.loadLanguague(GClass134.sbyte_1[GClass134.int_14]);
		GClass133.string_4 = GClass134.string_0[GClass134.int_14];
		GClass73.smethod_4();
	}

	public override void paint(GClass122 g)
	{
		if (gclass70_0 != null && int_6 < 30)
		{
			g.method_16(16777215);
			g.method_15(0, 0, GClass73.int_10, GClass73.int_11);
			g.method_31(gclass70_0, GClass73.int_10 / 2, GClass73.int_11 / 2, 3);
		}
		if (int_7 != -1)
		{
			g.method_16(0);
			g.method_15(0, 0, GClass73.int_10, GClass73.int_11);
			g.method_31(GClass133.gclass70_0, GClass73.int_10 / 2, GClass73.int_11 / 2 - 24, GClass188.int_3);
			GClass73.smethod_47(GClass73.int_12, GClass73.int_11 / 2 + 24, g);
			GClass4.gclass4_3.method_6(g, mResources.downloading_data + int_7 * 100 / int_8 + "%", GClass73.int_10 / 2, GClass73.int_11 / 2, 2);
		}
		else if (int_6 >= 30)
		{
			g.method_16(0);
			g.method_15(0, 0, GClass73.int_10, GClass73.int_11);
			GClass73.smethod_47(GClass73.int_12, GClass73.int_13, g);
			if (GClass134.gclass87_7 != null)
				GClass4.gclass4_20.method_10(g, mResources.xoadulieu, GClass73.int_10 - 2, GClass73.int_11 - 15, 1, GClass4.gclass4_16);
		}
	}

	public static void smethod_4()
	{
		gclass70_0 = GClass73.smethod_43("/gamelogo.png");
	}
}
