using ns1;

public class GClass190 : GInterface6
{
	public int int_0 = 0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public GClass203 gclass203_0;

	public sbyte sbyte_0;

	public bool bool_0;

	public int int_11;

	public int int_12;

	public int int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public int[] int_17;

	public int[] int_18;

	public int[] int_19;

	public int[] int_20;

	public int int_21;

	public int int_22;

	public static GClass20 gclass20_0 = GClass14.smethod_43("/mainImage/myTexture2dflare.png");

	public static GClass20 gclass20_1 = GClass14.smethod_43("/mainImage/myTexture2ditemaura1.png");

	public static GClass20 gclass20_2 = GClass14.smethod_43("/mainImage/myTexture2ditemaura2.png");

	public static GClass20 gclass20_3 = GClass14.smethod_43("/mainImage/myTexture2ditemaura3.png");

	public GClass190(short itemMapID, short itemTemplateID, int x, int y, int xEnd, int yEnd)
	{
		int_9 = itemMapID;
		gclass203_0 = GClass17.smethod_1(itemTemplateID);
		int_1 = xEnd;
		int_2 = y;
		int_3 = xEnd;
		int_4 = yEnd;
		int_6 = xEnd - x >> 2;
		int_7 = 5;
		GClass191.smethod_8("playerid=  " + int_8 + " myid= " + GClass124.smethod_1().int_13);
	}

	public GClass190(int playerId, short itemMapID, short itemTemplateID, int x, int y, short r)
	{
		GClass191.smethod_8("item map item= " + itemMapID + " template= " + itemTemplateID + " x= " + x + " y= " + y);
		int_9 = itemMapID;
		gclass203_0 = GClass17.smethod_1(itemTemplateID);
		GClass191.smethod_8("playerid=  " + playerId + " myid= " + GClass124.smethod_1().int_13);
		int_1 = (int_3 = x);
		int_2 = (int_4 = y);
		sbyte_0 = 1;
		int_8 = playerId;
		if (method_3())
		{
			int_11 = r;
			method_4();
		}
	}

	public void method_0(int xEnd, int yEnd)
	{
		int_3 = xEnd;
		int_4 = yEnd;
		int_6 = xEnd - int_1 >> 2;
		int_7 = yEnd - int_2 >> 2;
		sbyte_0 = 2;
	}

	public void method_1()
	{
		if (sbyte_0 != 2 || int_1 != int_3 || int_2 != int_4)
		{
			if (sbyte_0 <= 0)
			{
				sbyte_0 -= 4;
				if (sbyte_0 < -12)
				{
					int_2 -= 12;
					sbyte_0 = 1;
				}
			}
			else
			{
				if (int_6 == 0)
					int_1 = int_3;
				if (int_7 == 0)
					int_2 = int_4;
				if (int_1 != int_3)
				{
					int_1 += int_6;
					if ((int_6 > 0 && int_1 > int_3) || (int_6 < 0 && int_1 < int_3))
						int_1 = int_3;
				}
				if (int_2 != int_4)
				{
					int_2 += int_7;
					if ((int_7 > 0 && int_2 > int_4) || (int_7 < 0 && int_2 < int_4))
						int_2 = int_4;
				}
			}
			if (method_3())
				method_5();
		}
		else
		{
			GClass167.gclass122_6.method_8(this);
			if (GClass124.smethod_1().gclass190_0 != null && GClass124.smethod_1().gclass190_0.Equals(this))
				GClass124.smethod_1().gclass190_0 = null;
		}
	}

	public void method_2(GClass193 g)
	{
		if (GClass66.smethod_0().bool_8)
			return;
		if (!method_3())
		{
			if (!method_3())
			{
				if (GClass14.int_8 % 4 == 0)
					g.method_31(gclass20_0, int_1, int_2 + sbyte_0 + 13, GClass193.int_5 | GClass193.int_0);
				if (sbyte_0 > 0)
					GClass72.smethod_6(g, gclass203_0.short_1, int_1, int_2 + 3, 0, GClass193.int_5 | GClass193.int_0);
				else
					GClass72.smethod_6(g, gclass203_0.short_1, int_1, int_2 + sbyte_0 + 3, 0, GClass193.int_5 | GClass193.int_0);
				if (GClass124.smethod_1().gclass190_0 != null && GClass124.smethod_1().gclass190_0.Equals(this) && sbyte_0 != 2)
					g.method_23(GClass6.gclass20_0, 0, 24, 9, 6, 0, int_1, int_2 - 17, 3);
			}
			return;
		}
		g.method_31(GClass137.gclass20_10, int_1 + 3, int_2, GClass193.int_1 | GClass193.int_0);
		if (sbyte_0 <= 0)
		{
			if (int_22 < 10)
				g.method_31(gclass20_1, int_1, int_2 + sbyte_0 + 3, GClass193.int_5 | GClass193.int_0);
			else
				g.method_31(gclass20_2, int_1, int_2 + sbyte_0 + 3, GClass193.int_5 | GClass193.int_0);
		}
		else if (int_22 >= 10)
		{
			g.method_31(gclass20_2, int_1, int_2 + 3, GClass193.int_5 | GClass193.int_0);
		}
		else
		{
			g.method_31(gclass20_1, int_1, int_2 + 3, GClass193.int_5 | GClass193.int_0);
		}
	}

	private bool method_3()
	{
		if (gclass203_0.sbyte_0 == 22)
			return true;
		return false;
	}

	private void method_4()
	{
		int_12 = int_1;
		int_13 = int_2;
		int_16 = 120;
		int_14 = 0;
		if (!GClass14.bool_1)
		{
			int_15 = 360 / int_16;
			int_17 = new int[int_16];
			int_18 = new int[int_16];
			int_19 = new int[int_16];
			int_20 = new int[int_16];
			method_7();
		}
	}

	private void method_5()
	{
		int_21++;
		int_22++;
		if (int_22 >= 40)
			int_22 = 0;
		if (int_21 >= int_16)
			int_21 = 0;
		if (int_21 % 10 == 0 && !GClass14.bool_1)
			GClass91.smethod_0(114, int_1 - 5, int_2 - 30, 1);
	}

	public void method_6(GClass193 g)
	{
		if (GClass14.bool_1 || !method_3())
			return;
		for (int i = 0; i < int_18.Length; i++)
		{
			if (int_21 == i)
			{
				if (int_22 <= 20)
					g.method_31(gclass20_3, int_19[i], int_20[i] + 3, GClass193.int_5 | GClass193.int_0);
				else
					GClass72.smethod_6(g, gclass203_0.short_1, int_19[i], int_20[i] + 3, 0, GClass193.int_5 | GClass193.int_0);
			}
		}
	}

	private void method_7()
	{
		if (GClass14.bool_1)
			return;
		for (int i = 0; i < int_18.Length; i++)
		{
			int_18[i] = GClass191.smethod_28(int_11 * GClass191.smethod_1(int_14) / 1024);
			int_17[i] = GClass191.smethod_28(int_11 * GClass191.smethod_2(int_14) / 1024);
			if (int_14 < 90)
			{
				int_19[i] = int_12 + int_17[i];
				int_20[i] = int_13 - int_18[i];
			}
			else if (int_14 >= 90 && int_14 < 180)
			{
				int_19[i] = int_12 - int_17[i];
				int_20[i] = int_13 - int_18[i];
			}
			else if (int_14 >= 180 && int_14 < 270)
			{
				int_19[i] = int_12 - int_17[i];
				int_20[i] = int_13 + int_18[i];
			}
			else
			{
				int_19[i] = int_12 + int_17[i];
				int_20[i] = int_13 + int_18[i];
			}
			int_14 += int_15;
		}
	}

	public int getX()
	{
		return int_1;
	}

	public int getY()
	{
		return int_2;
	}

	public int getH()
	{
		return 20;
	}

	public int getW()
	{
		return 20;
	}

	public void stopMoving()
	{
	}

	public bool isInvisible()
	{
		return false;
	}
}
