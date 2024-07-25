public class GClass172 : GClass160
{
	public static int int_6;

	private bool bool_0;

	private bool bool_1;

	public static int int_7 = -1;

	public static int int_8 = -1;

	public static GClass172 gclass172_0;

	public static GClass20 gclass20_0;

	private int int_9 = 10;

	public long long_0;

	public GClass172()
	{
		gclass172_0 = this;
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
			if (GClass141.smethod_8("serverchat") != -1)
				GClass167.bool_83 = GClass141.smethod_8("serverchat") == 0;
			if (GClass141.smethod_8("isPlaySound") != -1)
				GClass14.bool_21 = GClass141.smethod_8("isPlaySound") == 1;
			if (GClass14.bool_21)
				GClass147.smethod_1().method_0(GClass137.int_37);
			GClass147.smethod_1().method_2();
			GClass170.smethod_8();
		}
		int_6++;
		GClass170.smethod_5();
		if (int_6 >= 150)
		{
			GClass191.smethod_8("cho man hinh nay qa lau");
			if (!GClass179.smethod_0().isConnected())
			{
				GClass77.smethod_30();
				return;
			}
			GClass170.bool_6 = true;
			GClass14.gclass170_0.switchToMe();
		}
	}

	public static void smethod_3()
	{
		if (GClass141.smethod_8("svselect") == -1)
		{
			int num = 0;
			if (mResources.language > 0)
			{
				for (int i = 0; i < mResources.language; i++)
				{
					num += GClass170.int_13[i];
				}
			}
			if (GClass170.sbyte_0 == -1)
				GClass170.int_14 = num + GClass191.smethod_19(0, GClass170.int_13[mResources.language]);
			else
				GClass170.int_14 = GClass170.sbyte_0;
			GClass141.smethod_9("svselect", GClass170.int_14);
			GClass206.string_0 = GClass170.string_1[GClass170.int_14];
			GClass206.int_0 = GClass170.short_0[GClass170.int_14];
			mResources.loadLanguague(GClass170.sbyte_1[GClass170.int_14]);
			GClass173.string_4 = GClass170.string_0[GClass170.int_14];
			GClass14.smethod_4();
		}
		else
		{
			GClass170.int_14 = GClass141.smethod_8("svselect");
			if (GClass170.int_14 > GClass170.string_0.Length - 1)
			{
				GClass170.int_14 = GClass170.sbyte_0;
				GClass141.smethod_9("svselect", GClass170.int_14);
			}
			GClass206.string_0 = GClass170.string_1[GClass170.int_14];
			GClass206.int_0 = GClass170.short_0[GClass170.int_14];
			mResources.loadLanguague(GClass170.sbyte_1[GClass170.int_14]);
			GClass173.string_4 = GClass170.string_0[GClass170.int_14];
			GClass14.smethod_4();
		}
	}

	public override void paint(GClass193 g)
	{
		if (gclass20_0 != null && int_6 < 30)
		{
			g.method_16(16777215);
			g.method_15(0, 0, GClass14.int_10, GClass14.int_11);
			g.method_31(gclass20_0, GClass14.int_10 / 2, GClass14.int_11 / 2, 3);
		}
		if (int_7 == -1)
		{
			if (int_6 >= 30)
			{
				g.method_16(0);
				g.method_15(0, 0, GClass14.int_10, GClass14.int_11);
				GClass14.smethod_47(GClass14.int_12, GClass14.int_13, g);
				if (GClass170.gclass118_7 != null)
					GClass104.gclass104_20.method_10(g, mResources.xoadulieu, GClass14.int_10 - 2, GClass14.int_11 - 15, 1, GClass104.gclass104_16);
			}
		}
		else
		{
			g.method_16(0);
			g.method_15(0, 0, GClass14.int_10, GClass14.int_11);
			g.method_31(GClass173.gclass20_0, GClass14.int_10 / 2, GClass14.int_11 / 2 - 24, GClass73.int_3);
			GClass14.smethod_47(GClass14.int_12, GClass14.int_11 / 2 + 24, g);
			GClass104.gclass104_3.method_6(g, mResources.downloading_data + int_7 * 100 / int_8 + "%", GClass14.int_10 / 2, GClass14.int_11 / 2, 2);
		}
	}

	public static void smethod_4()
	{
		gclass20_0 = GClass14.smethod_43("/gamelogo.png");
	}
}
