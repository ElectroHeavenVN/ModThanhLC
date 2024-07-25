public class GClass139
{
	public static GClass122 gclass122_0 = new GClass122();

	public int int_0;

	public int int_1;

	public string[] string_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public bool bool_0;

	public int int_9;

	private int int_10;

	public GClass118 gclass118_0;

	public bool bool_1 = true;

	public bool bool_2;

	public static GClass20 gclass20_0;

	public static GClass20 gclass20_1;

	public static GClass20 gclass20_2;

	public GClass20 gclass20_3;

	public GClass20 gclass20_4;

	public GClass139(string info, int x, int y)
	{
		int_0 = 100;
		if (info.Length < 10)
			int_0 = 60;
		if (GClass14.int_10 == 128)
			int_0 = 128;
		string_0 = GClass104.gclass104_6.method_15(info, int_0 - 10);
		int_1 = 7;
		int_2 = x - int_0 / 2 - 1;
		int_3 = y - 15 + int_1 - string_0.Length * 12 - 10;
		int_4 = int_0 + 2;
		int_5 = (string_0.Length + 1) * 12 + 1;
		while (int_4 % 10 != 0)
		{
			int_4++;
		}
		while (int_5 % 10 != 0)
		{
			int_5++;
		}
		if (x >= 0 && x <= 24)
			int_2 += int_4 / 2 + 30;
		if (x <= GClass137.int_21 * 24 && x >= GClass137.int_21 * 24 - 24)
			int_2 -= int_4 / 2 + 6;
		while (int_2 <= 30)
		{
			int_2 += 2;
		}
		while (int_2 + int_4 >= GClass137.int_21 * 24 - 30)
		{
			int_2 -= 2;
		}
	}

	public static void smethod_0()
	{
		if (gclass20_0 == null)
			gclass20_0 = GClass14.smethod_43("/mainImage/myTexture2dbd3.png");
		if (gclass20_1 == null)
			gclass20_1 = GClass14.smethod_43("/mainImage/myTexture2dimgPopup.png");
		if (gclass20_2 == null)
			gclass20_2 = GClass14.smethod_43("/mainImage/myTexture2dimgPopup2.png");
	}

	public void method_0(string[] info, int x, int y)
	{
		int_0 = 0;
		for (int i = 0; i < info.Length; i++)
		{
			if (int_0 < GClass104.gclass104_6.method_17(info[i]))
				int_0 = GClass104.gclass104_6.method_17(info[i]);
		}
		int_0 += 20;
		string_0 = info;
		int_1 = 7;
		int_2 = x - int_0 / 2 - 1;
		int_3 = y - 15 + int_1 - string_0.Length * 12 - 10;
		int_4 = int_0 + 2;
		int_5 = (string_0.Length + 1) * 12 + 1;
		while (int_4 % 10 != 0)
		{
			int_4++;
		}
		while (int_5 % 10 != 0)
		{
			int_5++;
		}
		if (x >= 0 && x <= 24)
			int_2 += int_4 / 2 + 30;
		if (x <= GClass137.int_21 * 24 && x >= GClass137.int_21 * 24 - 24)
			int_2 -= int_4 / 2 + 6;
		while (int_2 <= 30)
		{
			int_2 += 2;
		}
		while (int_2 + int_4 >= GClass137.int_21 * 24 - 30)
		{
			int_2 -= 2;
		}
	}

	public static void smethod_1(int x, int y, string info)
	{
		gclass122_0.method_0(new GClass139(info, x, y));
	}

	public static void smethod_2(GClass139 p)
	{
		gclass122_0.method_0(p);
	}

	public static void smethod_3(GClass139 p)
	{
		gclass122_0.method_8(p);
	}

	public void method_1(GClass193 g, int x, int y, int w, int h, int color, bool isFocus)
	{
		if (color != 1)
			g.method_10(x, y, w, h, 0, 77);
		else
			g.method_10(x, y, w, h, 16777215, 90);
	}

	public static void smethod_4(GClass193 g, int x, int y, int w, int h, int color, bool isButton)
	{
		if (!isButton)
		{
			g.method_16(0);
			g.method_15(x + 6, y, w - 14 + 1, h);
			g.method_15(x, y + 6, w, h - 12 + 1);
			g.method_16(color);
			g.method_15(x + 6, y + 1, w - 12, h - 2);
			g.method_15(x + 1, y + 6, w - 2, h - 12);
			g.method_23(gclass20_0, 0, 0, 7, 6, 0, x, y, 0);
			g.method_23(gclass20_0, 0, 0, 7, 6, 2, x + w - 7, y, 0);
			g.method_23(gclass20_0, 0, 0, 7, 6, 1, x, y + h - 6, 0);
			g.method_23(gclass20_0, 0, 0, 7, 6, 3, x + w - 7, y + h - 6, 0);
			return;
		}
		GClass20 arg = ((color != 1) ? gclass20_1 : gclass20_2);
		g.method_23(arg, 0, 0, 10, 10, 0, x, y, 0);
		g.method_23(arg, 0, 20, 10, 10, 0, x + w - 10, y, 0);
		g.method_23(arg, 0, 50, 10, 10, 0, x, y + h - 10, 0);
		g.method_23(arg, 0, 70, 10, 10, 0, x + w - 10, y + h - 10, 0);
		int num = (((w - 20) % 10 == 0) ? ((w - 20) / 10) : ((w - 20) / 10 + 1));
		int num2 = (((h - 20) % 10 != 0) ? ((h - 20) / 10 + 1) : ((h - 20) / 10));
		for (int i = 0; i < num; i++)
		{
			g.method_23(arg, 0, 10, 10, 10, 0, x + 10 + i * 10, y, 0);
		}
		for (int j = 0; j < num2; j++)
		{
			g.method_23(arg, 0, 30, 10, 10, 0, x, y + 10 + j * 10, 0);
		}
		for (int k = 0; k < num; k++)
		{
			g.method_23(arg, 0, 60, 10, 10, 0, x + 10 + k * 10, y + h - 10, 0);
		}
		for (int l = 0; l < num2; l++)
		{
			g.method_23(arg, 0, 40, 10, 10, 0, x + w - 10, y + 10 + l * 10, 0);
		}
		g.method_16((color != 1) ? 16770503 : 12052656);
		g.method_15(x + 10, y + 10, w - 20, h - 20);
	}

	public void method_2(GClass193 g)
	{
		if (bool_1 && string_0 != null && GClass88.gclass88_0 == null && !bool_2)
		{
			method_1(g, int_2, int_3 - GClass14.int_58, int_4, int_5, (int_10 != 0) ? 1 : 0, true);
			for (int i = 0; i < string_0.Length; i++)
			{
				((int_10 != 0) ? GClass104.gclass104_7 : GClass104.gclass104_3).method_6(g, string_0[i], int_2 + int_4 / 2, int_3 + (int_5 / 2 - string_0.Length * 12 / 2) + i * 12 - GClass14.int_58, 2);
			}
		}
	}

	private void method_3()
	{
		if (GClass124.smethod_1().gclass70_0 != null && GClass124.smethod_1().gclass70_0.short_1 == 0)
		{
			if (int_2 + int_4 >= GClass167.int_22 && int_2 <= GClass14.int_10 + GClass167.int_22 && int_3 + int_5 >= GClass167.int_23 && int_3 <= GClass14.int_11 + GClass167.int_23)
				bool_2 = false;
			else
				bool_2 = true;
		}
		if (GClass124.smethod_1().gclass70_0 == null || (GClass124.smethod_1().gclass70_0 != null && GClass124.smethod_1().gclass70_0.short_1 != 0))
		{
			if (int_2 + int_4 / 2 < GClass124.smethod_1().int_4 - 100 || int_2 + int_4 / 2 > GClass124.smethod_1().int_4 + 100 || int_3 + int_5 < GClass167.int_23 || int_3 > GClass14.int_11 + GClass167.int_23)
				bool_2 = true;
			else
				bool_2 = false;
		}
		if (int_10 > 0)
		{
			int_10--;
			if (int_10 == 0 && gclass118_0 != null)
				gclass118_0.method_1();
		}
		if (!bool_0)
			return;
		if (GClass124.smethod_1().gclass70_0 != null)
		{
			if (GClass124.smethod_1().gclass70_0.short_1 != 0)
			{
				if (!bool_1)
				{
					int_9++;
					if (int_9 == 50)
						bool_1 = true;
				}
				return;
			}
			if (GClass124.smethod_1().gclass70_0.int_0 == 0)
				bool_1 = false;
			if (GClass124.smethod_1().gclass70_0.int_0 == 1)
				bool_1 = true;
			if (GClass124.smethod_1().gclass70_0.int_0 > 1 && GClass124.smethod_1().gclass70_0.int_0 < 6)
				bool_1 = false;
		}
		else if (!bool_1)
		{
			GClass34.bool_5 = false;
			int_9++;
			if (int_9 == 50)
			{
				bool_1 = true;
				GClass34.bool_5 = true;
			}
		}
	}

	public void method_4(int timeDelay)
	{
		int_10 = timeDelay;
	}

	public static void smethod_5(GClass193 g)
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			((GClass139)gclass122_0.method_3(i)).method_2(g);
		}
	}

	public static void smethod_6()
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			((GClass139)gclass122_0.method_3(i)).method_3();
		}
	}
}
