public class GClass185 : GClass183
{
	public string[] string_0;

	public bool bool_0;

	private int int_1;

	private int int_2;

	private long long_0 = -1L;

	public GClass185()
	{
		int_2 = 35;
		if (GClass14.int_10 <= 176)
			int_2 = 10;
		if (GClass14.int_10 > 320)
			int_2 = 80;
	}

	public void method_0()
	{
		method_2(mResources.PLEASEWAIT, null, null, null);
		GClass14.gclass183_0 = this;
		long_0 = GClass77.smethod_18() + 5000L;
	}

	public override void show()
	{
		GClass14.gclass183_0 = this;
		long_0 = -1L;
	}

	public void method_1(string info)
	{
		string_0 = GClass104.gclass104_21.method_15(info, GClass14.int_10 - (int_2 * 2 + 20));
		int_1 = 80;
		if (string_0.Length >= 5)
			int_1 = string_0.Length * GClass104.gclass104_21.method_20() + 20;
	}

	public void method_2(string info, GClass118 left, GClass118 center, GClass118 right)
	{
		string_0 = GClass104.gclass104_21.method_15(info, GClass14.int_10 - (int_2 * 2 + 20));
		gclass118_0 = left;
		gclass118_1 = center;
		gclass118_2 = right;
		int_1 = 80;
		if (string_0.Length >= 5)
			int_1 = string_0.Length * GClass104.gclass104_21.method_20() + 20;
		if (GClass14.bool_5)
		{
			if (left != null)
			{
				gclass118_0.int_1 = GClass14.int_10 / 2 - 68 - 5;
				gclass118_0.int_2 = GClass14.int_11 - 50;
			}
			if (right != null)
			{
				gclass118_2.int_1 = GClass14.int_10 / 2 + 5;
				gclass118_2.int_2 = GClass14.int_11 - 50;
			}
			if (center != null)
			{
				gclass118_1.int_1 = GClass14.int_10 / 2 - 35;
				gclass118_1.int_2 = GClass14.int_11 - 50;
			}
		}
		bool_0 = false;
		long_0 = -1L;
	}

	public override void paint(GClass193 g)
	{
		g.method_5(0, 0, GClass14.int_10, GClass14.int_11);
		if (!GClass173.bool_0)
		{
			int num = GClass14.int_11 - int_1 - 38;
			int w = GClass14.int_10 - int_2 * 2;
			GClass14.gclass97_0.method_33(int_2, num, w, int_1, g);
			int num2 = num + (int_1 - string_0.Length * GClass104.gclass104_21.method_20()) / 2 - 2;
			if (bool_0)
			{
				num2 += 8;
				GClass14.smethod_47(GClass14.int_12, num2 - 12, g);
			}
			int num3 = 0;
			int num4 = num2;
			while (num3 < string_0.Length)
			{
				GClass104.gclass104_6.method_6(g, string_0[num3], GClass14.int_12, num4, 2);
				num3++;
				num4 += GClass104.gclass104_21.method_20();
			}
			base.paint(g);
		}
	}

	public override void update()
	{
		base.update();
		if (long_0 != -1L && GClass77.smethod_18() > long_0)
			GClass14.smethod_29();
	}
}
