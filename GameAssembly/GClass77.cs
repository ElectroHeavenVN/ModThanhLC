public class GClass77
{
	private int int_0;

	private int int_1;

	private int int_2 = 1;

	private int int_3 = 360;

	private GClass91 gclass91_0 = new GClass91();

	private GClass63 gclass63_0 = new GClass63();

	private int[] int_4 = new int[8] { 16711680, 16776960, 65280, 16777215, 255, 65535, 15790320, 12632256 };

	public GClass77(int x, int y, int goc, int n)
	{
		int_0 = x;
		int_1 = y;
		int_2 = goc;
		int_3 = n;
		for (int i = 0; i < n; i++)
		{
			gclass63_0.method_0(new GClass94(x, y, GClass26.smethod_0(gclass91_0.method_0() % 8) + 3, i * goc, int_4[GClass26.smethod_0(gclass91_0.method_0() % int_4.Length)]));
		}
	}

	public void method_0(GClass76 g)
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass94 gClass = (GClass94)gclass63_0.method_3(i);
			if (gClass.int_5 < -200)
				gclass63_0.method_7(i);
			gClass.method_1(g);
		}
	}
}
