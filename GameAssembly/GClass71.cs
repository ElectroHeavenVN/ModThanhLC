public class GClass71 : GClass68
{
	public GClass42 gclass42_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private GClass58 gclass58_0;

	private GClass85 gclass85_0;

	private short short_0;

	private long long_0;

	private int int_5;

	public static void smethod_0(int id, int cx, int cy, int loopCount)
	{
		GClass71 gClass = new GClass71();
		gClass.gclass42_0 = GClass154.gclass42_0[id - 1];
		gClass.int_3 = cx;
		gClass.int_4 = cy;
		gClass.short_0 = (short)loopCount;
		GClass68.gclass63_1.method_0(gClass);
	}

	public static void smethod_1(int id, int cx, int cy, int loopCount, int trans)
	{
		GClass71 gClass = new GClass71();
		gClass.gclass42_0 = GClass154.gclass42_0[id - 1];
		gClass.int_3 = cx;
		gClass.int_4 = cy;
		gClass.short_0 = (short)loopCount;
		gClass.int_5 = trans;
		GClass68.gclass63_1.method_0(gClass);
	}

	public static void smethod_2(int id, GClass85 m, int loopCount)
	{
		GClass71 gClass = new GClass71();
		gClass.gclass42_0 = GClass154.gclass42_0[id - 1];
		gClass.gclass85_0 = m;
		gClass.short_0 = (short)loopCount;
		GClass68.gclass63_1.method_0(gClass);
	}

	public static void smethod_3(int id, GClass58 c, int loopCount)
	{
		GClass71 gClass = new GClass71();
		gClass.gclass42_0 = GClass154.gclass42_0[id - 1];
		gClass.gclass58_0 = c;
		gClass.short_0 = (short)loopCount;
		GClass68.gclass63_1.method_0(gClass);
	}

	public static void smethod_4(int id, GClass58 c, int loopCount, int trans)
	{
		GClass71 gClass = new GClass71();
		gClass.gclass42_0 = GClass154.gclass42_0[id - 1];
		gClass.gclass58_0 = c;
		gClass.short_0 = (short)loopCount;
		gClass.int_5 = trans;
		GClass68.gclass63_1.method_0(gClass);
	}

	public static void smethod_5(int id, int cx, int cy, int timeLengthInSecond)
	{
		GClass71 gClass = new GClass71();
		gClass.gclass42_0 = GClass154.gclass42_0[id - 1];
		gClass.int_3 = cx;
		gClass.int_4 = cy;
		gClass.long_0 = GClass138.smethod_18() + timeLengthInSecond * 1000;
		GClass68.gclass63_1.method_0(gClass);
	}

	public static void smethod_6(int id, GClass58 c, int timeLengthInSecond)
	{
		GClass71 gClass = new GClass71();
		gClass.gclass42_0 = GClass154.gclass42_0[id - 1];
		gClass.gclass58_0 = c;
		gClass.long_0 = GClass138.smethod_18() + timeLengthInSecond * 1000;
		GClass68.gclass63_1.method_0(gClass);
	}

	public override void paint(GClass76 g)
	{
		if (GClass76.int_12 == 1)
			GClass154.int_79++;
		if (GClass154.int_79 < 8)
		{
			if (gclass58_0 != null)
			{
				int_3 = gclass58_0.int_4;
				int_4 = gclass58_0.int_5 + GClass39.int_58;
			}
			if (gclass85_0 != null)
			{
				int_3 = gclass85_0.int_8;
				int_4 = gclass85_0.int_9 + GClass39.int_58;
			}
			int x = int_3 + int_1 + gclass42_0.gclass142_0[int_0].int_0;
			int y = int_4 + int_2 + gclass42_0.gclass142_0[int_0].int_1;
			if (GClass39.smethod_46(x, y))
				GClass96.smethod_6(g, gclass42_0.gclass142_0[int_0].int_2, x, y, int_5, GClass76.int_1 | GClass76.int_0);
		}
	}

	public override void update()
	{
		if ((ulong)long_0 > 0uL)
		{
			int_0++;
			if (int_0 >= gclass42_0.gclass142_0.Length)
				int_0 = 0;
			if (GClass138.smethod_18() - long_0 > 0L)
				GClass68.gclass63_1.method_8(this);
		}
		else
		{
			int_0++;
			if (int_0 >= gclass42_0.gclass142_0.Length)
			{
				short_0--;
				if (short_0 <= 0)
					GClass68.gclass63_1.method_8(this);
				else
					int_0 = 0;
			}
		}
		if (GClass39.int_8 % 11 == 0 && gclass58_0 != null && gclass58_0 != GClass58.smethod_1() && !GClass154.gclass63_5.method_1(gclass58_0))
			GClass68.gclass63_1.method_8(this);
	}
}
