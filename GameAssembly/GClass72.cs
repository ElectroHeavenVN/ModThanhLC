public class GClass72 : GClass68
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
		GClass72 gClass = new GClass72();
		gClass.gclass42_0 = GClass154.gclass42_0[id - 1];
		gClass.int_3 = cx;
		gClass.int_4 = cy;
		gClass.short_0 = (short)loopCount;
		GClass68.gclass63_0.method_0(gClass);
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
			GClass96.smethod_6(x: int_3 + int_1 + gclass42_0.gclass142_0[int_0].int_0, y: int_4 + int_2 + gclass42_0.gclass142_0[int_0].int_1, g: g, id: gclass42_0.gclass142_0[int_0].int_2, transform: int_5, anchor: GClass76.int_1 | GClass76.int_0);
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
				GClass68.gclass63_0.method_8(this);
		}
		else
		{
			int_0++;
			if (int_0 >= gclass42_0.gclass142_0.Length)
			{
				short_0--;
				if (short_0 <= 0)
					GClass68.gclass63_0.method_8(this);
				else
					int_0 = 0;
			}
		}
		if (GClass39.int_8 % 11 == 0 && gclass58_0 != null && gclass58_0 != GClass58.smethod_1() && !GClass154.gclass63_5.method_1(gclass58_0))
			GClass68.gclass63_0.method_8(this);
	}
}
