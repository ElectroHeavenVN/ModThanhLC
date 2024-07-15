public class GClass171 : GClass160, GInterface1
{
	public static GClass171 gclass171_0;

	public static GClass20 gclass20_0;

	public static GClass20 gclass20_1;

	public sbyte sbyte_0;

	public int int_6 = 5;

	public int[] int_7;

	public int[] int_8;

	public int[] int_9;

	public int[] int_10;

	private int int_11;

	private int int_12 = 20;

	public short short_0;

	public short short_1;

	public long long_0;

	public long long_1;

	private bool bool_0;

	private bool bool_1;

	private int int_13;

	public GClass171()
	{
		int_7 = new int[int_12];
		int_8 = new int[int_12];
		for (int i = 0; i < int_12; i++)
		{
			int_7[i] = GClass191.smethod_19(0, GClass14.int_10);
			int_8[i] = i * (GClass14.int_11 / int_12);
		}
		int_9 = new int[int_12];
		int_10 = new int[int_12];
		for (int j = 0; j < int_12; j++)
		{
			int_9[j] = GClass191.smethod_19(0, GClass14.int_10);
			int_10[j] = j * (GClass14.int_11 / int_12);
		}
	}

	public static GClass171 smethod_2()
	{
		if (gclass171_0 == null)
			gclass171_0 = new GClass171();
		return gclass171_0;
	}

	public override void switchToMe()
	{
		if (gclass20_0 == null)
			gclass20_0 = GClass14.smethod_43("/mainImage/myTexture2dfutherShip.png");
		if (gclass20_1 == null)
			gclass20_1 = GClass14.smethod_43("/mainImage/taungam.png");
		bool_0 = false;
		bool_1 = false;
		if (GClass124.smethod_1().method_145() > 0 && sbyte_0 == 0)
			gclass118_1 = new GClass118(mResources.faster, this, 1, null);
		else
			gclass118_1 = null;
		int_13 = 0;
		base.switchToMe();
	}

	public override void paint(GClass193 g)
	{
		g.method_16((sbyte_0 != 0) ? 3056895 : 0);
		g.method_15(0, 0, GClass14.int_10, GClass14.int_11);
		for (int i = 0; i < int_12; i++)
		{
			g.method_16((sbyte_0 != 0) ? 11140863 : 14802654);
			g.method_15(int_7[i], int_8[i], 10, 2);
		}
		if (sbyte_0 == 0)
			g.method_23(gclass20_0, 0, 0, 72, 95, 7, int_11 + int_13, GClass14.int_11 / 2, 3);
		if (sbyte_0 == 1)
			g.method_23(gclass20_1, 0, 0, 144, 79, 2, int_11 + int_13, GClass14.int_11 / 2, 3);
		for (int j = 0; j < int_12; j++)
		{
			g.method_16((sbyte_0 != 0) ? 7536127 : 14935011);
			g.method_15(int_9[j], int_10[j], 18, 3);
		}
		base.paint(g);
	}

	public override void update()
	{
		if (sbyte_0 == 0)
		{
			if (!bool_0)
				int_13 = GClass14.int_10 / 2 * short_0 / short_1;
		}
		else
			int_13 += 2;
		GClass93.bool_5 = false;
		int_11 = (((GClass14.int_10 / 2 + int_11) / 2 + int_11) / 2 + int_11) / 2;
		if (sbyte_0 == 1)
			int_11 = 0;
		for (int i = 0; i < int_12; i++)
		{
			int_7[i] -= int_6 / 2;
			if (int_7[i] < -20)
				int_7[i] = GClass14.int_10;
		}
		for (int j = 0; j < int_12; j++)
		{
			int_9[j] -= int_6;
			if (int_9[j] < -20)
				int_9[j] = GClass14.int_10;
		}
		if (GClass14.int_8 % 3 == 0)
			int_6 += ((!bool_0) ? 1 : 2);
		if (int_6 > ((!bool_0) ? 25 : 80))
			int_6 = (bool_0 ? 80 : 25);
		long_1 = GClass77.smethod_18();
		if (long_1 - long_0 >= 1000L)
		{
			short_0++;
			long_0 = long_1;
		}
		if (bool_0)
			int_13 += 3;
		if (int_13 >= GClass14.int_10 / 2 + 30 && !bool_1)
		{
			bool_1 = true;
			GClass2.smethod_0().method_134();
		}
		base.update();
	}

	public override void updateKey()
	{
		base.updateKey();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
			GClass14.smethod_36(mResources.fasterQuestion, new GClass118(mResources.YES, this, 2, null), new GClass118(mResources.NO, this, 3, null));
		if (idAction == 2 && GClass124.smethod_1().method_145() > 0)
		{
			bool_0 = true;
			GClass14.smethod_29();
			gclass118_1 = null;
		}
		if (idAction == 3)
			GClass14.smethod_29();
	}
}
