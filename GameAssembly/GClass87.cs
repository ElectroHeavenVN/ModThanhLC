public class GClass87 : GClass86
{
	public GClass80 gclass80_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private GClass124 gclass124_0;

	private GClass6 gclass6_0;

	private short short_0;

	private long long_0;

	private int int_5;

	public static void smethod_0(int id, int cx, int cy, int loopCount)
	{
		GClass87 gClass = new GClass87();
		gClass.gclass80_0 = GClass167.gclass80_0[id - 1];
		gClass.int_3 = cx;
		gClass.int_4 = cy;
		gClass.short_0 = (short)loopCount;
		GClass86.gclass122_0.method_0(gClass);
	}

	public override void paint(GClass193 g)
	{
		if (GClass193.int_12 == 1)
			GClass167.int_79++;
		if (GClass167.int_79 < 8)
		{
			if (gclass124_0 != null)
			{
				int_3 = gclass124_0.int_4;
				int_4 = gclass124_0.int_5 + GClass14.int_58;
			}
			if (gclass6_0 != null)
			{
				int_3 = gclass6_0.int_8;
				int_4 = gclass6_0.int_9 + GClass14.int_58;
			}
			int x = int_3 + int_1 + gclass80_0.gclass31_0[int_0].int_0;
			int y = int_4 + int_2 + gclass80_0.gclass31_0[int_0].int_1;
			GClass72.smethod_6(g, gclass80_0.gclass31_0[int_0].int_2, x, y, int_5, GClass193.int_1 | GClass193.int_0);
		}
	}

	public override void update()
	{
		if ((ulong)long_0 > 0uL)
		{
			int_0++;
			if (int_0 >= gclass80_0.gclass31_0.Length)
				int_0 = 0;
			if (GClass77.smethod_18() - long_0 > 0L)
				GClass86.gclass122_0.method_8(this);
		}
		else
		{
			int_0++;
			if (int_0 >= gclass80_0.gclass31_0.Length)
			{
				short_0--;
				if (short_0 > 0)
					int_0 = 0;
				else
					GClass86.gclass122_0.method_8(this);
			}
		}
		if (GClass14.int_8 % 11 == 0 && gclass124_0 != null && gclass124_0 != GClass124.smethod_1() && !GClass167.gclass122_5.method_1(gclass124_0))
			GClass86.gclass122_0.method_8(this);
	}
}
