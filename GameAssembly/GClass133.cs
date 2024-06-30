public class GClass133
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public GClass126 gclass126_0;

	public short short_0;

	public short short_1;

	public short short_2;

	public GClass133()
	{
		int_0 = 0;
		int_1 = 0;
	}

	public GClass133(int x, int y, int anchor)
	{
		int_0 = x;
		int_1 = y;
		int_2 = anchor;
	}

	public GClass133(int x, int y)
	{
		int_0 = x;
		int_1 = y;
	}

	public void method_0(int xT, int yT)
	{
		short_1 = (short)xT;
		short_0 = (short)yT;
		short_2 = (short)GClass56.smethod_24(int_0, int_1, short_1, short_0);
	}

	public int method_1()
	{
		if (int_0 == short_1 && int_1 == short_0)
			return -1;
		if (GClass26.smethod_0((short_1 - int_0) / 2) <= 1 && GClass26.smethod_0((short_0 - int_1) / 2) <= 1)
		{
			int_0 = short_1;
			int_1 = short_0;
			return 0;
		}
		if (int_0 != short_1)
			int_0 += (short_1 - int_0) / 2;
		if (int_1 != short_0)
			int_1 += (short_0 - int_1) / 2;
		if (GClass56.smethod_24(int_0, int_1, short_1, short_0) <= short_2 / 5)
			return 2;
		return 1;
	}

	public void method_2()
	{
		gclass126_0.method_0();
	}

	public void method_3(GClass76 g)
	{
		gclass126_0.method_1(g, int_0, int_1);
	}
}
