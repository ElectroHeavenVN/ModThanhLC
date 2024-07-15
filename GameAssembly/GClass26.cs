public class GClass26
{
	public GClass20 gclass20_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass26(GClass20 img, int id)
	{
		gclass20_0 = img;
		int_0 = id;
		int_1 = 0;
		int_2 = 0;
	}

	public void method_0(GClass193 g, int transform, int x, int y, int anchor)
	{
		g.method_23(gclass20_0, 0, 0, GClass193.smethod_0(gclass20_0), GClass193.smethod_1(gclass20_0), transform, x, y, anchor);
		if (GClass14.int_8 % 1000 == 0)
		{
			int_1++;
			int_2 = int_1;
		}
	}

	public void method_1(GClass193 g, int transform, int f, int x, int y, int w, int h, int anchor)
	{
		method_2(g, transform, f, x, y, w, h, anchor, false);
	}

	public void method_2(GClass193 g, int transform, int f, int x, int y, int w, int h, int anchor, bool isClip)
	{
		if (GClass193.smethod_0(gclass20_0) != 1)
		{
			g.method_25(gclass20_0, 0, f * w, w, h, transform, x, y, anchor, isClip);
			if (GClass14.int_8 % 1000 == 0)
			{
				int_1++;
				int_2 = int_1;
			}
		}
	}

	public void method_3()
	{
		int_2++;
		if (int_2 - int_1 > 1 && !GClass124.smethod_1().method_95(int_0))
			GClass72.gclass26_0[int_0] = null;
	}
}
