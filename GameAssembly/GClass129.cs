public class GClass129
{
	public GClass2 gclass2_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass129(GClass2 img, int id)
	{
		gclass2_0 = img;
		int_0 = id;
		int_1 = 0;
		int_2 = 0;
	}

	public void method_0(GClass76 g, int transform, int x, int y, int anchor)
	{
		g.method_23(gclass2_0, 0, 0, GClass76.smethod_0(gclass2_0), GClass76.smethod_1(gclass2_0), transform, x, y, anchor);
		if (GClass39.int_8 % 1000 == 0)
		{
			int_1++;
			int_2 = int_1;
		}
	}

	public void method_1(GClass76 g, int transform, int f, int x, int y, int w, int h, int anchor)
	{
		method_2(g, transform, f, x, y, w, h, anchor, false);
	}

	public void method_2(GClass76 g, int transform, int f, int x, int y, int w, int h, int anchor, bool isClip)
	{
		if (GClass76.smethod_0(gclass2_0) != 1)
		{
			g.method_25(gclass2_0, 0, f * w, w, h, transform, x, y, anchor, isClip);
			if (GClass39.int_8 % 1000 == 0)
			{
				int_1++;
				int_2 = int_1;
			}
		}
	}

	public void method_3()
	{
		int_2++;
		if (int_2 - int_1 > 1 && !GClass58.smethod_1().method_93(int_0))
			GClass96.gclass129_0[int_0] = null;
	}
}
