using AssemblyCSharp.Functions;

public class GClass98 : GClass93
{
	private int int_0;

	private int int_1;

	private int int_2;

	private long long_0;

	private bool bool_0;

	public static GClass70 gclass70_0 = GClass73.smethod_43("/mainImage/myTexture2dmove-1.png");

	public static GClass70 gclass70_1 = GClass73.smethod_43("/mainImage/myTexture2dmove-3.png");

	public static void smethod_0(int cx, int cy, int ctrans, int timeLengthInSecond, bool isCF)
	{
		GClass98 gClass = new GClass98();
		gClass.int_0 = cx;
		gClass.int_1 = cy;
		gClass.int_2 = ctrans;
		gClass.bool_0 = isCF;
		gClass.long_0 = GClass203.smethod_18() + timeLengthInSecond * 1000;
		GClass93.gclass88_5.method_0(gClass);
	}

	public override void update()
	{
		if (GClass203.smethod_18() - long_0 > 0L)
			GClass93.gclass88_5.method_8(this);
	}

	public override void paint(GClass122 g)
	{
		if (GClass167.smethod_0().bool_9)
			return;
		int sbyte_ = GClass20.sbyte_0;
		if (!GClass20.smethod_28(int_0 + sbyte_ / 2, int_1 + 1, 4))
		{
			if (GClass20.smethod_26((int_0 - sbyte_ / 2) / sbyte_, (int_1 + 1) / sbyte_) == 0)
				g.method_5(int_0 / sbyte_ * sbyte_, (int_1 - 30) / sbyte_ * sbyte_, 100, 100);
			else if (GClass20.smethod_26((int_0 + sbyte_ / 2) / sbyte_, (int_1 + 1) / sbyte_) == 0)
			{
				g.method_5(int_0 / sbyte_ * sbyte_, (int_1 - 30) / sbyte_ * sbyte_, sbyte_, 100);
			}
			else if (GClass20.smethod_28(int_0 - sbyte_ / 2, int_1 + 1, 8))
			{
				g.method_5(int_0 / 24 * sbyte_, (int_1 - 30) / sbyte_ * sbyte_, sbyte_, 100);
			}
		}
		else
			g.method_5(int_0 / sbyte_ * sbyte_, (int_1 - 30) / sbyte_ * sbyte_, sbyte_, 100);
		g.method_23(bool_0 ? gclass70_0 : gclass70_1, 0, 0, gclass70_0.method_0(), gclass70_0.method_1(), int_2, int_0, int_1, GClass122.int_5 | GClass122.int_0);
		g.method_5(GClass144.int_22, GClass144.int_23 - GClass73.int_58, GClass144.int_6, GClass144.int_7 + 2 * GClass73.int_58);
	}
}
