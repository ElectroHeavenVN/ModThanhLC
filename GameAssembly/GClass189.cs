public class GClass189 : GInterface6
{
	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public long long_0;

	public int int_3;

	public string[] string_1;

	public sbyte sbyte_0;

	public sbyte sbyte_1;

	private int int_4;

	public int int_5;

	public int int_6;

	public string[] string_2;

	public static GClass88 gclass88_0 = new GClass88();

	public static void smethod_0(GClass189 cm, int index, bool upToTop)
	{
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			GClass189 gClass = (GClass189)gclass88_0.method_3(i);
			if (gClass.int_0 != cm.int_0)
			{
				if (gClass.int_6 != 0 && gClass.int_5 == gClass.int_6)
					gclass88_0.method_8(gClass);
				continue;
			}
			gclass88_0.method_8(gClass);
			if (upToTop)
				gclass88_0.method_10(cm, 0);
			else
				gclass88_0.method_10(cm, i);
			return;
		}
		if (index == -1)
			gclass88_0.method_0(cm);
		else
			gclass88_0.method_10(cm, 0);
		if (gclass88_0.method_2() > 20)
			gclass88_0.method_7(gclass88_0.method_2() - 1);
	}

	public void method_0(GClass122 g, int x, int y)
	{
		GClass4 gClass = GClass4.gclass4_6;
		if (sbyte_1 == 0)
			gClass = GClass4.gclass4_1;
		else if (sbyte_1 == 1)
		{
			gClass = GClass4.gclass4_8;
		}
		else if (sbyte_1 == 2)
		{
			gClass = GClass4.gclass4_7;
		}
		if (int_1 == 0)
		{
			gClass.method_6(g, string_0, x + 3, y + 1, 0);
			if (sbyte_0 != 0)
				GClass4.gclass4_17.method_6(g, string_1[0] + ((string_1.Length > 1) ? "..." : ""), x + 3, y + 11, 0);
			else
				GClass4.gclass4_16.method_6(g, string_1[0] + ((string_1.Length <= 1) ? "" : "..."), x + 3, y + 11, 0);
			GClass4.gclass4_16.method_6(g, GClass65.smethod_10(int_4) + " " + mResources.ago, x + GClass73.gclass76_0.int_60 - 3, y + 1, GClass4.int_1);
		}
		if (int_1 == 1)
		{
			gClass.method_6(g, string_0 + " (" + int_5 + "/" + int_6 + ")", x + 3, y + 1, 0);
			GClass4.gclass4_18.method_6(g, mResources.request_pea + " " + GClass65.smethod_10(int_4) + " " + mResources.ago, x + 3, y + 11, 0);
		}
		if (int_1 == 2)
		{
			gClass.method_6(g, string_0, x + 3, y + 1, 0);
			GClass4.gclass4_18.method_6(g, mResources.request_join_clan, x + 3, y + 11, 0);
		}
	}

	public void perform(int idAction, object p)
	{
	}

	public void method_1()
	{
		if ((ulong)long_0 > 0uL)
			int_4 = (int)(GClass203.smethod_18() / 1000L - long_0);
	}
}
