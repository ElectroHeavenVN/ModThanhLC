using System;

public class GClass94
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

	public int int_9 = 16711680;

	private float float_0;

	private long long_0;

	private long long_1 = 150L;

	private bool bool_0 = true;

	private int[] int_10 = new int[2];

	private int[] int_11 = new int[2];

	public GClass94(int x0, int y0, int v, int angle, int cl)
	{
		int_6 = y0;
		int_3 = x0;
		float_0 = 1f;
		int_2 = v;
		int_7 = angle;
		int_0 = GClass39.int_10;
		int_1 = GClass39.int_11;
		long_0 = method_2();
		for (int i = 0; i < 2; i++)
		{
			int_10[i] = x0;
			int_11[i] = y0;
		}
		int_9 = cl;
	}

	public void method_0()
	{
		if (method_2() - long_0 >= long_1)
		{
			int_8++;
			long_0 = method_2();
			int_10[1] = int_10[0];
			int_11[1] = int_11[0];
			int_10[0] = int_4;
			int_11[0] = int_5;
			int_4 = GClass56.smethod_2((int)((double)int_7 * Math.PI / 180.0)) * int_2 * int_8 + int_3;
			int_5 = (int)((float)(int_2 * GClass56.smethod_1((int)((double)int_7 * Math.PI / 180.0)) * int_8) - float_0 * (float)int_8 * (float)int_8 / 2f) + int_6;
		}
	}

	public void method_1(GClass76 g)
	{
		method_3(g, int_0 - int_4, int_1 - int_5, int_9);
		for (int i = 0; i < 2; i++)
		{
			method_3(g, int_0 - int_10[i], int_1 - int_11[i], int_9);
		}
		if (bool_0)
			method_0();
	}

	public long method_2()
	{
		return GClass138.smethod_18();
	}

	public void method_3(GClass76 g, int x, int y, int color)
	{
		g.method_16(color);
		g.method_15(x, y, 1, 2);
	}
}
