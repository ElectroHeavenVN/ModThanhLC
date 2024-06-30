public class GClass148 : GClass145
{
	public static int int_6;

	private bool bool_0;

	private bool bool_1;

	public static int int_7 = -1;

	public static int int_8 = -1;

	public static GClass148 gclass148_0;

	public static GClass2 gclass2_0;

	private int int_9 = 10;

	public long long_0;

	public GClass148()
	{
		gclass148_0 = this;
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
			if (GClass120.smethod_8("serverchat") != -1)
				GClass154.bool_82 = GClass120.smethod_8("serverchat") == 0;
			if (GClass120.smethod_8("isPlaySound") != -1)
				GClass39.bool_21 = GClass120.smethod_8("isPlaySound") == 1;
			if (GClass39.bool_21)
				GClass29.smethod_1().method_0(GClass1.int_37);
			GClass29.smethod_1().method_2();
			GClass152.smethod_8();
		}
		int_6++;
		GClass152.smethod_5();
		if (int_6 >= 150)
		{
			GClass56.smethod_8("cho man hinh nay qa lau");
			if (GClass162.smethod_0().isConnected())
			{
				GClass152.bool_6 = true;
				GClass39.gclass152_0.switchToMe();
			}
			else
				GClass138.smethod_30();
		}
	}

	public static void smethod_3()
	{
		if (GClass120.smethod_8("svselect") == -1)
		{
			int num = 0;
			if (mResources.language > 0)
			{
				for (int i = 0; i < mResources.language; i++)
				{
					num += GClass152.int_13[i];
				}
			}
			if (GClass152.sbyte_0 == -1)
				GClass152.int_14 = num + GClass56.smethod_19(0, GClass152.int_13[mResources.language]);
			else
				GClass152.int_14 = GClass152.sbyte_0;
			GClass120.smethod_9("svselect", GClass152.int_14);
			GClass113.string_0 = GClass152.string_1[GClass152.int_14];
			GClass113.int_0 = GClass152.short_0[GClass152.int_14];
			mResources.loadLanguague(GClass152.sbyte_1[GClass152.int_14]);
			GClass149.string_4 = GClass152.string_0[GClass152.int_14];
			GClass39.smethod_4();
		}
		else
		{
			GClass152.int_14 = GClass120.smethod_8("svselect");
			if (GClass152.int_14 > GClass152.string_0.Length - 1)
			{
				GClass152.int_14 = GClass152.sbyte_0;
				GClass120.smethod_9("svselect", GClass152.int_14);
			}
			GClass113.string_0 = GClass152.string_1[GClass152.int_14];
			GClass113.int_0 = GClass152.short_0[GClass152.int_14];
			mResources.loadLanguague(GClass152.sbyte_1[GClass152.int_14]);
			GClass149.string_4 = GClass152.string_0[GClass152.int_14];
			GClass39.smethod_4();
		}
	}

	public override void paint(GClass76 g)
	{
		if (gclass2_0 != null && int_6 < 30)
		{
			g.method_16(16777215);
			g.method_15(0, 0, GClass39.int_10, GClass39.int_11);
			g.method_31(gclass2_0, GClass39.int_10 / 2, GClass39.int_11 / 2, 3);
		}
		if (int_7 != -1)
		{
			g.method_16(0);
			g.method_15(0, 0, GClass39.int_10, GClass39.int_11);
			g.method_31(GClass149.gclass2_0, GClass39.int_10 / 2, GClass39.int_11 / 2 - 24, GClass169.int_3);
			GClass39.smethod_47(GClass39.int_12, GClass39.int_11 / 2 + 24, g);
			GClass49.gclass49_3.method_6(g, mResources.downloading_data + int_7 * 100 / int_8 + "%", GClass39.int_10 / 2, GClass39.int_11 / 2, 2);
		}
		else if (int_6 >= 30)
		{
			g.method_16(0);
			g.method_15(0, 0, GClass39.int_10, GClass39.int_11);
			GClass39.smethod_47(GClass39.int_12, GClass39.int_13, g);
			if (GClass152.gclass14_7 != null)
				GClass49.gclass49_20.method_10(g, mResources.xoadulieu, GClass39.int_10 - 2, GClass39.int_11 - 15, 1, GClass49.gclass49_16);
		}
	}

	public static void smethod_4()
	{
		gclass2_0 = GClass39.smethod_43("/gamelogo.png");
	}
}
