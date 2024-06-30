using ns1;

public class GClass69 : GClass68
{
	private int int_0;

	private int int_1;

	private int int_2;

	private long long_0;

	private bool bool_0;

	public static GClass2 gclass2_0 = GClass39.smethod_43("/mainImage/myTexture2dmove-1.png");

	public static GClass2 gclass2_1 = GClass39.smethod_43("/mainImage/myTexture2dmove-3.png");

	public static void smethod_0(int cx, int cy, int ctrans, int timeLengthInSecond, bool isCF)
	{
		GClass69 gClass = new GClass69();
		gClass.int_0 = cx;
		gClass.int_1 = cy;
		gClass.int_2 = ctrans;
		gClass.bool_0 = isCF;
		gClass.long_0 = GClass138.smethod_18() + timeLengthInSecond * 1000;
		GClass68.gclass63_5.method_0(gClass);
	}

	public override void update()
	{
		if (GClass138.smethod_18() - long_0 > 0L)
			GClass68.gclass63_5.method_8(this);
	}

	public override void paint(GClass76 g)
	{
		if (!GClass173.smethod_0().bool_8)
		{
			int sbyte_ = GClass1.sbyte_0;
			if (GClass1.smethod_27(int_0 + sbyte_ / 2, int_1 + 1, 4))
				g.method_5(int_0 / sbyte_ * sbyte_, (int_1 - 30) / sbyte_ * sbyte_, sbyte_, 100);
			else if (GClass1.smethod_25((int_0 - sbyte_ / 2) / sbyte_, (int_1 + 1) / sbyte_) == 0)
			{
				g.method_5(int_0 / sbyte_ * sbyte_, (int_1 - 30) / sbyte_ * sbyte_, 100, 100);
			}
			else if (GClass1.smethod_25((int_0 + sbyte_ / 2) / sbyte_, (int_1 + 1) / sbyte_) == 0)
			{
				g.method_5(int_0 / sbyte_ * sbyte_, (int_1 - 30) / sbyte_ * sbyte_, sbyte_, 100);
			}
			else if (GClass1.smethod_27(int_0 - sbyte_ / 2, int_1 + 1, 8))
			{
				g.method_5(int_0 / 24 * sbyte_, (int_1 - 30) / sbyte_ * sbyte_, sbyte_, 100);
			}
			g.method_23((!bool_0) ? gclass2_1 : gclass2_0, 0, 0, gclass2_0.method_0(), gclass2_0.method_1(), int_2, int_0, int_1, GClass76.int_5 | GClass76.int_0);
			g.method_5(GClass154.int_22, GClass154.int_23 - GClass39.int_58, GClass154.int_6, GClass154.int_7 + 2 * GClass39.int_58);
		}
	}
}
