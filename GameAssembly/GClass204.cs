public class GClass204
{
	public static GClass204 gclass204_0;

	public GClass73 gclass73_0;

	public int int_0 = 1;

	public GClass70 gclass70_0;

	private int[] int_1;

	private int int_2;

	private int int_3;

	private int[] int_4;

	private int int_5 = 20;

	public GClass204()
	{
		method_0(method_1(), method_2());
	}

	public void method_0(int w, int h)
	{
		if (!Main.isWindowsPhone)
		{
			if (Main.isPC)
			{
				GClass122.int_12 = 2;
				if (w * h < 380000)
					GClass122.int_12 = 1;
			}
			else if (!Main.isIpod)
			{
				if (w * h < 2073600)
				{
					if (w * h >= 691200)
						GClass122.int_12 = 3;
					else if (w * h > 153600)
					{
						GClass122.int_12 = 2;
					}
				}
				else
					GClass122.int_12 = 4;
			}
			else
			{
				GClass122.int_12 = 2;
			}
			return;
		}
		GClass122.int_12 = 2;
		if (w * h < 2073600)
		{
			if (w * h > 384000)
				GClass122.int_12 = 3;
		}
		else
			GClass122.int_12 = 4;
	}

	public int method_1()
	{
		return (int)GClass69.float_0;
	}

	public int method_2()
	{
		return (int)GClass69.float_1;
	}

	public void method_3(GClass73 tCanvas)
	{
		gclass73_0 = tCanvas;
	}

	protected void method_4(GClass122 g)
	{
		gclass73_0.method_20(g);
	}

	protected void method_5(int keyCode)
	{
		gclass73_0.method_10(keyCode);
	}

	protected void method_6(int keyCode)
	{
		gclass73_0.method_12(keyCode);
	}

	protected void method_7(int x, int y)
	{
		x /= GClass122.int_12;
		y /= GClass122.int_12;
		gclass73_0.method_16(x, y);
	}

	protected void method_8(int x, int y)
	{
		x /= GClass122.int_12;
		y /= GClass122.int_12;
		gclass73_0.method_17(x, y);
	}

	protected void method_9(int x, int y)
	{
		x /= GClass122.int_12;
		y /= GClass122.int_12;
		gclass73_0.method_18(x, y);
	}

	public int method_10()
	{
		int num = method_1();
		return num / GClass122.int_12 + num % GClass122.int_12;
	}

	public int method_11()
	{
		int num = method_2();
		return num / GClass122.int_12 + num % GClass122.int_12;
	}
}
