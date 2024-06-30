public class GClass62 : GInterface0
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

	public static GClass63 gclass63_0 = new GClass63();

	public static void smethod_0(GClass62 cm, int index, bool upToTop)
	{
		int num = 0;
		while (true)
		{
			if (num < gclass63_0.method_2())
			{
				GClass62 gClass = (GClass62)gclass63_0.method_3(num);
				if (gClass.int_0 != cm.int_0)
				{
					if (gClass.int_6 != 0 && gClass.int_5 == gClass.int_6)
						gclass63_0.method_8(gClass);
					num++;
					continue;
				}
				gclass63_0.method_8(gClass);
				if (!upToTop)
					gclass63_0.method_10(cm, num);
				else
					gclass63_0.method_10(cm, 0);
				break;
			}
			if (index == -1)
				gclass63_0.method_0(cm);
			else
				gclass63_0.method_10(cm, 0);
			if (gclass63_0.method_2() > 20)
				gclass63_0.method_7(gclass63_0.method_2() - 1);
			break;
		}
	}

	public void method_0(GClass76 g, int x, int y)
	{
		GClass49 gClass = GClass49.gclass49_6;
		if (sbyte_1 == 0)
			gClass = GClass49.gclass49_1;
		else if (sbyte_1 == 1)
		{
			gClass = GClass49.gclass49_8;
		}
		else if (sbyte_1 == 2)
		{
			gClass = GClass49.gclass49_7;
		}
		if (int_1 == 0)
		{
			gClass.method_6(g, string_0, x + 3, y + 1, 0);
			if (sbyte_0 == 0)
				GClass49.gclass49_16.method_6(g, string_1[0] + ((string_1.Length <= 1) ? string.Empty : "..."), x + 3, y + 11, 0);
			else
				GClass49.gclass49_17.method_6(g, string_1[0] + ((string_1.Length <= 1) ? string.Empty : "..."), x + 3, y + 11, 0);
			GClass49.gclass49_16.method_6(g, GClass95.smethod_10(int_4) + " " + mResources.ago, x + GClass39.gclass45_0.int_59 - 3, y + 1, GClass49.int_1);
		}
		if (int_1 == 1)
		{
			gClass.method_6(g, string_0 + " (" + int_5 + "/" + int_6 + ")", x + 3, y + 1, 0);
			GClass49.gclass49_18.method_6(g, mResources.request_pea + " " + GClass95.smethod_10(int_4) + " " + mResources.ago, x + 3, y + 11, 0);
		}
		if (int_1 == 2)
		{
			gClass.method_6(g, string_0, x + 3, y + 1, 0);
			GClass49.gclass49_18.method_6(g, mResources.request_join_clan, x + 3, y + 11, 0);
		}
	}

	public void perform(int idAction, object p)
	{
	}

	public void method_1()
	{
		if ((ulong)long_0 > 0uL)
			int_4 = (int)(GClass138.smethod_18() / 1000L - long_0);
	}
}
