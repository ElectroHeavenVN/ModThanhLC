public class GClass195
{
	private int int_0;

	private int int_1;

	private int int_2 = 1;

	private int int_3 = 360;

	private GClass134 gclass134_0 = new GClass134();

	private GClass122 gclass122_0 = new GClass122();

	private int[] int_4 = new int[8] { 16711680, 16776960, 65280, 16777215, 255, 65535, 15790320, 12632256 };

	public GClass195(int x, int y, int goc, int n)
	{
		int_0 = x;
		int_1 = y;
		int_2 = goc;
		int_3 = n;
		for (int i = 0; i < n; i++)
		{
			gclass122_0.method_0(new GClass156(x, y, GClass13.smethod_0(gclass134_0.method_0() % 8) + 3, i * goc, int_4[GClass13.smethod_0(gclass134_0.method_0() % int_4.Length)]));
		}
	}

	public void method_0(GClass193 g)
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			GClass156 gClass = (GClass156)gclass122_0.method_3(i);
			if (gClass.int_5 < -200)
				gclass122_0.method_7(i);
			gClass.method_1(g);
		}
	}
}
