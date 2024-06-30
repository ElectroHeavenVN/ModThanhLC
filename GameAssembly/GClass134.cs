using ns1;

public class GClass134 : GInterface4
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

	public GClass118 gclass118_0;

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

	public static GClass2 gclass2_0 = GClass39.smethod_43("/mainImage/myTexture2dflare.png");

	public static GClass2 gclass2_1 = GClass39.smethod_43("/mainImage/myTexture2ditemaura1.png");

	public static GClass2 gclass2_2 = GClass39.smethod_43("/mainImage/myTexture2ditemaura2.png");

	public static GClass2 gclass2_3 = GClass39.smethod_43("/mainImage/myTexture2ditemaura3.png");

	public GClass134(short itemMapID, short itemTemplateID, int x, int y, int xEnd, int yEnd)
	{
		int_9 = itemMapID;
		gclass118_0 = GClass83.smethod_1(itemTemplateID);
		int_1 = xEnd;
		int_2 = y;
		int_3 = xEnd;
		int_4 = yEnd;
		int_6 = xEnd - x >> 2;
		int_7 = 5;
		GClass56.smethod_8("playerid=  " + int_8 + " myid= " + GClass58.smethod_1().int_13);
	}

	public GClass134(int playerId, short itemMapID, short itemTemplateID, int x, int y, short r)
	{
		GClass56.smethod_8("item map item= " + itemMapID + " template= " + itemTemplateID + " x= " + x + " y= " + y);
		int_9 = itemMapID;
		gclass118_0 = GClass83.smethod_1(itemTemplateID);
		GClass56.smethod_8("playerid=  " + playerId + " myid= " + GClass58.smethod_1().int_13);
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
		if (sbyte_0 == 2 && int_1 == int_3 && int_2 == int_4)
		{
			GClass154.gclass63_6.method_8(this);
			if (GClass58.smethod_1().gclass134_0 != null && GClass58.smethod_1().gclass134_0.Equals(this))
				GClass58.smethod_1().gclass134_0 = null;
			return;
		}
		if (sbyte_0 > 0)
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
		else
		{
			sbyte_0 -= 4;
			if (sbyte_0 < -12)
			{
				int_2 -= 12;
				sbyte_0 = 1;
			}
		}
		if (method_3())
			method_5();
	}

	public void method_2(GClass76 g)
	{
		if (GClass173.smethod_0().bool_7)
			return;
		if (method_3())
		{
			g.method_31(GClass1.gclass2_10, int_1 + 3, int_2, GClass76.int_1 | GClass76.int_0);
			if (sbyte_0 <= 0)
			{
				if (int_22 < 10)
					g.method_31(gclass2_1, int_1, int_2 + sbyte_0 + 3, GClass76.int_5 | GClass76.int_0);
				else
					g.method_31(gclass2_2, int_1, int_2 + sbyte_0 + 3, GClass76.int_5 | GClass76.int_0);
			}
			else if (int_22 < 10)
			{
				g.method_31(gclass2_1, int_1, int_2 + 3, GClass76.int_5 | GClass76.int_0);
			}
			else
			{
				g.method_31(gclass2_2, int_1, int_2 + 3, GClass76.int_5 | GClass76.int_0);
			}
		}
		else if (!method_3())
		{
			if (GClass39.int_8 % 4 == 0)
				g.method_31(gclass2_0, int_1, int_2 + sbyte_0 + 13, GClass76.int_5 | GClass76.int_0);
			if (sbyte_0 <= 0)
				GClass96.smethod_6(g, gclass118_0.short_1, int_1, int_2 + sbyte_0 + 3, 0, GClass76.int_5 | GClass76.int_0);
			else
				GClass96.smethod_6(g, gclass118_0.short_1, int_1, int_2 + 3, 0, GClass76.int_5 | GClass76.int_0);
			if (GClass58.smethod_1().gclass134_0 != null && GClass58.smethod_1().gclass134_0.Equals(this) && sbyte_0 != 2)
				g.method_23(GClass85.gclass2_0, 0, 24, 9, 6, 0, int_1, int_2 - 17, 3);
		}
	}

	private bool method_3()
	{
		if (gclass118_0.sbyte_0 == 22)
			return true;
		return false;
	}

	private void method_4()
	{
		int_12 = int_1;
		int_13 = int_2;
		int_16 = 120;
		int_14 = 0;
		if (!GClass39.bool_1)
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
		if (int_21 % 10 == 0 && !GClass39.bool_1)
			GClass71.smethod_0(114, int_1 - 5, int_2 - 30, 1);
	}

	public void method_6(GClass76 g)
	{
		if (GClass39.bool_1 || !method_3())
			return;
		for (int i = 0; i < int_18.Length; i++)
		{
			if (int_21 == i)
			{
				if (int_22 <= 20)
					g.method_31(gclass2_3, int_19[i], int_20[i] + 3, GClass76.int_5 | GClass76.int_0);
				else
					GClass96.smethod_6(g, gclass118_0.short_1, int_19[i], int_20[i] + 3, 0, GClass76.int_5 | GClass76.int_0);
			}
		}
	}

	private void method_7()
	{
		if (GClass39.bool_1)
			return;
		for (int i = 0; i < int_18.Length; i++)
		{
			int_18[i] = GClass56.smethod_28(int_11 * GClass56.smethod_1(int_14) / 1024);
			int_17[i] = GClass56.smethod_28(int_11 * GClass56.smethod_2(int_14) / 1024);
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
