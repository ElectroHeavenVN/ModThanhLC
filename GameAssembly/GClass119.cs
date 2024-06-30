public class GClass119
{
	public static GClass119 gclass119_0;

	public GClass39 gclass39_0;

	public int int_0 = 1;

	public GClass2 gclass2_0;

	private int[] int_1;

	private int int_2;

	private int int_3;

	private int[] int_4;

	private int int_5 = 20;

	public GClass119()
	{
		method_0(method_1(), method_2());
	}

	public void method_0(int w, int h)
	{
		if (Main.isWindowsPhone)
		{
			GClass76.int_12 = 2;
			if (w * h >= 2073600)
				GClass76.int_12 = 4;
			else if (w * h > 384000)
			{
				GClass76.int_12 = 3;
			}
		}
		else if (!Main.isPC)
		{
			if (Main.isIpod)
				GClass76.int_12 = 2;
			else if (w * h >= 2073600)
			{
				GClass76.int_12 = 4;
			}
			else if (w * h >= 691200)
			{
				GClass76.int_12 = 3;
			}
			else if (w * h > 153600)
			{
				GClass76.int_12 = 2;
			}
		}
		else
		{
			GClass76.int_12 = 2;
			if (w * h < 450000)
				GClass76.int_12 = 1;
		}
	}

	public int method_1()
	{
		return (int)GClass4.float_0;
	}

	public int method_2()
	{
		return (int)GClass4.float_1;
	}

	public void method_3(GClass39 tCanvas)
	{
		gclass39_0 = tCanvas;
	}

	protected void method_4(GClass76 g)
	{
		gclass39_0.method_20(g);
	}

	protected void method_5(int keyCode)
	{
		gclass39_0.method_10(keyCode);
	}

	protected void method_6(int keyCode)
	{
		gclass39_0.method_12(keyCode);
	}

	protected void method_7(int x, int y)
	{
		x /= GClass76.int_12;
		y /= GClass76.int_12;
		gclass39_0.method_16(x, y);
	}

	protected void method_8(int x, int y)
	{
		x /= GClass76.int_12;
		y /= GClass76.int_12;
		gclass39_0.method_17(x, y);
	}

	protected void method_9(int x, int y)
	{
		x /= GClass76.int_12;
		y /= GClass76.int_12;
		gclass39_0.method_18(x, y);
	}

	public int method_10()
	{
		int num = method_1();
		return num / GClass76.int_12 + num % GClass76.int_12;
	}

	public int method_11()
	{
		int num = method_2();
		return num / GClass76.int_12 + num % GClass76.int_12;
	}
}
