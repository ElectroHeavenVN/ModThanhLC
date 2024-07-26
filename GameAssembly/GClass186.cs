public class GClass186
{
	private int int_0;

	private int int_1;

	private int int_2 = 1;

	private int int_3 = 360;

	private GClass2 gclass2_0 = new GClass2();

	private GClass88 gclass88_0 = new GClass88();

	private int[] int_4 = new int[8] { 16711680, 16776960, 65280, 16777215, 255, 65535, 15790320, 12632256 };

	public GClass186(int x, int y, int goc, int n)
	{
		int_0 = x;
		int_1 = y;
		int_2 = goc;
		int_3 = n;
		for (int i = 0; i < n; i++)
		{
			gclass88_0.method_0(new GClass13(x, y, GClass118.smethod_0(gclass2_0.method_0() % 8) + 3, i * goc, int_4[GClass118.smethod_0(gclass2_0.method_0() % int_4.Length)]));
		}
	}

	public void method_0(GClass122 g)
	{
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			GClass13 gClass = (GClass13)gclass88_0.method_3(i);
			if (gClass.int_5 < -200)
				gclass88_0.method_7(i);
			gClass.method_1(g);
		}
	}
}
