public class GClass100 : GClass99
{
	public string[] string_0;

	public bool bool_0;

	private int int_1;

	private int int_2;

	private long long_0 = -1L;

	public GClass100()
	{
		int_2 = 35;
		if (GClass39.int_10 <= 176)
			int_2 = 10;
		if (GClass39.int_10 > 320)
			int_2 = 80;
	}

	public void method_0()
	{
		method_2(mResources.PLEASEWAIT, null, null, null);
		GClass39.gclass99_0 = this;
		long_0 = GClass138.smethod_18() + 5000L;
	}

	public override void show()
	{
		GClass39.gclass99_0 = this;
		long_0 = -1L;
	}

	public void method_1(string info)
	{
		string_0 = GClass49.gclass49_21.method_15(info, GClass39.int_10 - (int_2 * 2 + 20));
		int_1 = 80;
		if (string_0.Length >= 5)
			int_1 = string_0.Length * GClass49.gclass49_21.method_20() + 20;
	}

	public void method_2(string info, GClass14 left, GClass14 center, GClass14 right)
	{
		string_0 = GClass49.gclass49_21.method_15(info, GClass39.int_10 - (int_2 * 2 + 20));
		gclass14_0 = left;
		gclass14_1 = center;
		gclass14_2 = right;
		int_1 = 80;
		if (string_0.Length >= 5)
			int_1 = string_0.Length * GClass49.gclass49_21.method_20() + 20;
		if (GClass39.bool_5)
		{
			if (left != null)
			{
				gclass14_0.int_1 = GClass39.int_10 / 2 - 68 - 5;
				gclass14_0.int_2 = GClass39.int_11 - 50;
			}
			if (right != null)
			{
				gclass14_2.int_1 = GClass39.int_10 / 2 + 5;
				gclass14_2.int_2 = GClass39.int_11 - 50;
			}
			if (center != null)
			{
				gclass14_1.int_1 = GClass39.int_10 / 2 - 35;
				gclass14_1.int_2 = GClass39.int_11 - 50;
			}
		}
		bool_0 = false;
		long_0 = -1L;
	}

	public override void paint(GClass76 g)
	{
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		if (!GClass149.bool_0)
		{
			int num = GClass39.int_11 - int_1 - 38;
			int w = GClass39.int_10 - int_2 * 2;
			GClass39.gclass37_0.method_33(int_2, num, w, int_1, g);
			int num2 = num + (int_1 - string_0.Length * GClass49.gclass49_21.method_20()) / 2 - 2;
			if (bool_0)
			{
				num2 += 8;
				GClass39.smethod_47(GClass39.int_12, num2 - 12, g);
			}
			int num3 = 0;
			int num4 = num2;
			while (num3 < string_0.Length)
			{
				GClass49.gclass49_6.method_6(g, string_0[num3], GClass39.int_12, num4, 2);
				num3++;
				num4 += GClass49.gclass49_21.method_20();
			}
			base.paint(g);
		}
	}

	public override void update()
	{
		base.update();
		if (long_0 != -1L && GClass138.smethod_18() > long_0)
			GClass39.smethod_29();
	}
}
