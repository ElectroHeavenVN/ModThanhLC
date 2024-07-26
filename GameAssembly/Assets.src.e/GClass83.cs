namespace Assets.src.e
{
	public class GClass83
	{
		public GClass70 gclass70_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public GClass83(GClass70 img, int id)
		{
			gclass70_0 = img;
			int_0 = id;
			int_1 = 0;
			int_2 = 0;
		}

		public void method_0(GClass122 g, int transform, int x, int y, int anchor)
		{
			g.method_23(gclass70_0, 0, 0, GClass122.smethod_0(gclass70_0), GClass122.smethod_1(gclass70_0), transform, x, y, anchor);
			if (GClass73.int_8 % 1000 == 0)
			{
				int_1++;
				int_2 = int_1;
			}
		}

		public void method_1(GClass122 g, int transform, int f, int x, int y, int w, int h, int anchor)
		{
			method_2(g, transform, f, x, y, w, h, anchor, false);
		}

		public void method_2(GClass122 g, int transform, int f, int x, int y, int w, int h, int anchor, bool isClip)
		{
			if (GClass122.smethod_0(gclass70_0) != 1)
			{
				g.method_25(gclass70_0, 0, f * w, w, h, transform, x, y, anchor, isClip);
				if (GClass73.int_8 % 1000 == 0)
				{
					int_1++;
					int_2 = int_1;
				}
			}
		}

		public void method_3()
		{
			int_2++;
			if (int_2 - int_1 > 1 && !GClass78.smethod_1().method_95(int_0))
				GClass28.gclass83_0[int_0] = null;
		}
	}
}
