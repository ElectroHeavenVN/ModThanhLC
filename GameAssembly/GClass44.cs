public class GClass44 : GClass42
{
	public string[] string_0;

	public bool bool_0;

	private int int_1;

	private int int_2;

	private long long_0 = -1L;

	public GClass44()
	{
		int_2 = 35;
		if (GClass73.int_10 <= 176)
			int_2 = 10;
		if (GClass73.int_10 > 320)
			int_2 = 80;
	}

	public void method_0()
	{
		method_2(mResources.PLEASEWAIT, null, null, null);
		GClass73.gclass42_0 = this;
		long_0 = GClass203.smethod_18() + 5000L;
	}

	public override void show()
	{
		GClass73.gclass42_0 = this;
		long_0 = -1L;
	}

	public void method_1(string info)
	{
		string_0 = GClass4.gclass4_21.method_15(info, GClass73.int_10 - (int_2 * 2 + 20));
		int_1 = 80;
		if (string_0.Length >= 5)
			int_1 = string_0.Length * GClass4.gclass4_21.method_20() + 20;
	}

	public void method_2(string info, GClass87 left, GClass87 center, GClass87 right)
	{
		string_0 = GClass4.gclass4_21.method_15(info, GClass73.int_10 - (int_2 * 2 + 20));
		gclass87_0 = left;
		gclass87_1 = center;
		gclass87_2 = right;
		int_1 = 80;
		if (string_0.Length >= 5)
			int_1 = string_0.Length * GClass4.gclass4_21.method_20() + 20;
		if (GClass73.bool_5)
		{
			if (left != null)
			{
				gclass87_0.int_1 = GClass73.int_10 / 2 - 68 - 5;
				gclass87_0.int_2 = GClass73.int_11 - 50;
			}
			if (right != null)
			{
				gclass87_2.int_1 = GClass73.int_10 / 2 + 5;
				gclass87_2.int_2 = GClass73.int_11 - 50;
			}
			if (center != null)
			{
				gclass87_1.int_1 = GClass73.int_10 / 2 - 35;
				gclass87_1.int_2 = GClass73.int_11 - 50;
			}
		}
		bool_0 = false;
		long_0 = -1L;
	}

	public override void paint(GClass122 g)
	{
		g.method_5(0, 0, GClass73.int_10, GClass73.int_11);
		if (!GClass133.bool_0)
		{
			int num = GClass73.int_11 - int_1 - 38;
			int w = GClass73.int_10 - int_2 * 2;
			GClass73.gclass192_0.method_33(int_2, num, w, int_1, g);
			int num2 = num + (int_1 - string_0.Length * GClass4.gclass4_21.method_20()) / 2 - 2;
			if (bool_0)
			{
				num2 += 8;
				GClass73.smethod_47(GClass73.int_12, num2 - 12, g);
			}
			int num3 = 0;
			int num4 = num2;
			while (num3 < string_0.Length)
			{
				GClass4.gclass4_6.method_6(g, string_0[num3], GClass73.int_12, num4, 2);
				num3++;
				num4 += GClass4.gclass4_21.method_20();
			}
			base.paint(g);
		}
	}

	public override void update()
	{
		base.update();
		if (long_0 != -1L && GClass203.smethod_18() > long_0)
			GClass73.smethod_29();
	}
}
