public class GClass97 : GClass93
{
	public GClass124 gclass124_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private GClass78 gclass78_0;

	private GClass194 gclass194_0;

	private short short_0;

	private long long_0;

	private int int_5;

	public static void smethod_0(int id, int cx, int cy, int loopCount)
	{
		GClass97 gClass = new GClass97();
		gClass.gclass124_0 = GClass144.gclass124_0[id - 1];
		gClass.int_3 = cx;
		gClass.int_4 = cy;
		gClass.short_0 = (short)loopCount;
		GClass93.gclass88_1.method_0(gClass);
	}

	public static void smethod_1(int id, int cx, int cy, int loopCount, int trans)
	{
		GClass97 gClass = new GClass97();
		gClass.gclass124_0 = GClass144.gclass124_0[id - 1];
		gClass.int_3 = cx;
		gClass.int_4 = cy;
		gClass.short_0 = (short)loopCount;
		gClass.int_5 = trans;
		GClass93.gclass88_1.method_0(gClass);
	}

	public static void smethod_2(int id, GClass194 m, int loopCount)
	{
		GClass97 gClass = new GClass97();
		gClass.gclass124_0 = GClass144.gclass124_0[id - 1];
		gClass.gclass194_0 = m;
		gClass.short_0 = (short)loopCount;
		GClass93.gclass88_1.method_0(gClass);
	}

	public static void smethod_3(int id, GClass78 c, int loopCount)
	{
		GClass97 gClass = new GClass97();
		gClass.gclass124_0 = GClass144.gclass124_0[id - 1];
		gClass.gclass78_0 = c;
		gClass.short_0 = (short)loopCount;
		GClass93.gclass88_1.method_0(gClass);
	}

	public static void smethod_4(int id, GClass78 c, int loopCount, int trans)
	{
		GClass97 gClass = new GClass97();
		gClass.gclass124_0 = GClass144.gclass124_0[id - 1];
		gClass.gclass78_0 = c;
		gClass.short_0 = (short)loopCount;
		gClass.int_5 = trans;
		GClass93.gclass88_1.method_0(gClass);
	}

	public static void smethod_5(int id, int cx, int cy, int timeLengthInSecond)
	{
		GClass97 gClass = new GClass97();
		gClass.gclass124_0 = GClass144.gclass124_0[id - 1];
		gClass.int_3 = cx;
		gClass.int_4 = cy;
		gClass.long_0 = GClass203.smethod_18() + timeLengthInSecond * 1000;
		GClass93.gclass88_1.method_0(gClass);
	}

	public static void smethod_6(int id, GClass78 c, int timeLengthInSecond)
	{
		GClass97 gClass = new GClass97();
		gClass.gclass124_0 = GClass144.gclass124_0[id - 1];
		gClass.gclass78_0 = c;
		gClass.long_0 = GClass203.smethod_18() + timeLengthInSecond * 1000;
		GClass93.gclass88_1.method_0(gClass);
	}

	public override void paint(GClass122 g)
	{
		if (GClass122.int_12 == 1)
			GClass144.int_79++;
		if (GClass144.int_79 < 8)
		{
			if (gclass78_0 != null)
			{
				int_3 = gclass78_0.int_4;
				int_4 = gclass78_0.int_5 + GClass73.int_58;
			}
			if (gclass194_0 != null)
			{
				int_3 = gclass194_0.int_8;
				int_4 = gclass194_0.int_9 + GClass73.int_58;
			}
			int x = int_3 + int_1 + gclass124_0.gclass209_0[int_0].int_0;
			int y = int_4 + int_2 + gclass124_0.gclass209_0[int_0].int_1;
			if (GClass73.smethod_46(x, y))
				GClass28.smethod_6(g, gclass124_0.gclass209_0[int_0].int_2, x, y, int_5, GClass122.int_1 | GClass122.int_0);
		}
	}

	public override void update()
	{
		if ((ulong)long_0 > 0uL)
		{
			int_0++;
			if (int_0 >= gclass124_0.gclass209_0.Length)
				int_0 = 0;
			if (GClass203.smethod_18() - long_0 > 0L)
				GClass93.gclass88_1.method_8(this);
		}
		else
		{
			int_0++;
			if (int_0 >= gclass124_0.gclass209_0.Length)
			{
				short_0--;
				if (short_0 <= 0)
					GClass93.gclass88_1.method_8(this);
				else
					int_0 = 0;
			}
		}
		if (GClass73.int_8 % 11 == 0 && gclass78_0 != null && gclass78_0 != GClass78.smethod_1() && !GClass144.gclass88_5.method_1(gclass78_0))
			GClass93.gclass88_1.method_8(this);
	}
}
