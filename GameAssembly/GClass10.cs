using System;

public class GClass10 : GClass6, GInterface6
{
	public static GClass20 gclass20_2 = GClass77.smethod_35("/mainImage/shadowBig.png");

	public int int_55;

	public int int_56;

	public bool bool_24;

	public bool bool_25;

	public int int_57;

	public int int_58;

	private int int_59;

	public bool bool_26 = true;

	private int int_60;

	private int int_61;

	public static GClass20 gclass20_3 = GClass77.smethod_35("/mainImage/myTexture2dmobHP.png");

	private bool bool_27;

	private int int_62;

	private int int_63;

	private int int_64;

	public int int_65;

	private GClass124 gclass124_2;

	private bool bool_28;

	private bool bool_29;

	private int int_66;

	public bool bool_30;

	private int int_67;

	public bool bool_31 = true;

	private int int_68;

	private GClass124[] gclass124_3;

	private int[] int_69;

	private sbyte sbyte_17;

	private int int_70;

	private int int_71;

	private int int_72 = -1;

	private int int_73 = -1;

	private int int_74 = -1;

	private sbyte[] sbyte_18 = new sbyte[2] { -1, 1 };

	public GClass124 gclass124_4;

	public bool bool_32;

	public GClass6 gclass6_1;

	public int int_75;

	public bool bool_33;

	public bool bool_34;

	private int[][] int_76 = new int[17][]
	{
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 }
	};

	public const sbyte sbyte_19 = 0;

	public const sbyte sbyte_20 = 1;

	public const sbyte sbyte_21 = 2;

	public const sbyte sbyte_22 = 3;

	public const sbyte sbyte_23 = 4;

	public const sbyte sbyte_24 = 5;

	public const sbyte sbyte_25 = 6;

	public const sbyte sbyte_26 = 7;

	public const sbyte sbyte_27 = 8;

	public const sbyte sbyte_28 = 9;

	public const sbyte sbyte_29 = 10;

	public const sbyte sbyte_30 = 11;

	public const sbyte sbyte_31 = 12;

	public const sbyte sbyte_32 = 13;

	public const sbyte sbyte_33 = 14;

	public const sbyte sbyte_34 = 15;

	public const sbyte sbyte_35 = 16;

	public GClass10(int id, short px, short py, int templateID, int hp, int maxHp, int s)
	{
		int_25 = id;
		int_8 = (int_16 = px + 20);
		int_9 = (int_17 = py);
		int_55 = int_8;
		int_56 = int_9;
		int_7 = maxHp;
		int_6 = hp;
		int_26 = templateID;
		byte_0 = 6;
		int_49 = 100;
		int_48 = int_49;
		method_20();
		if (GClass6.gclass76_0[int_26].gclass194_0 == null)
			GClass2.smethod_0().method_48(int_26);
		int_12 = 2;
		int_76 = null;
	}

	public override void setBody(short id)
	{
		bool_0 = true;
		short_0 = id;
	}

	public override void clearBody()
	{
		bool_0 = false;
	}

	public static bool smethod_6(string id)
	{
		int num = 0;
		while (true)
		{
			if (num < GClass6.gclass122_2.method_2())
			{
				if (((string)GClass6.gclass122_2.method_3(num)).Equals(id))
					break;
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public void method_29(int[] array)
	{
		int_60++;
		if (int_60 > array.Length - 1)
			int_60 = 0;
		int_61 = array[int_60];
	}

	public void method_30()
	{
		int num = 0;
		int_57 = int_8;
		if (GClass137.smethod_28(int_8, int_9, 2))
		{
			int_58 = int_9;
			return;
		}
		int_58 = int_9;
		do
		{
			if (num < 30)
			{
				num++;
				int_58 += 24;
				continue;
			}
			return;
		}
		while (!GClass137.smethod_28(int_57, int_58, 2));
		if (int_58 % 24 != 0)
			int_58 -= int_58 % 24;
	}

	private void method_31(GClass193 gclass193_0)
	{
		int num = GClass137.sbyte_0;
		if ((GClass137.int_37 < 114 || GClass137.int_37 > 120) && GClass137.int_37 != 127 && GClass137.int_37 != 128)
		{
			if (GClass137.smethod_28(int_57 + num / 2, int_58 + 1, 4))
				gclass193_0.method_5(int_57 / num * num, (int_58 - 30) / num * num, num, 100);
			else if (GClass137.smethod_26((int_57 - num / 2) / num, (int_58 + 1) / num) != 0)
			{
				if (GClass137.smethod_26((int_57 + num / 2) / num, (int_58 + 1) / num) == 0)
					gclass193_0.method_5(int_57 / num * num, (int_58 - 30) / num * num, num, 100);
				else if (GClass137.smethod_28(int_57 - num / 2, int_58 + 1, 8))
				{
					gclass193_0.method_5(int_57 / 24 * num, (int_58 - 30) / num * num, num, 100);
				}
			}
			else
			{
				gclass193_0.method_5(int_57 / num * num, (int_58 - 30) / num * num, 100, 100);
			}
		}
		gclass193_0.method_31(gclass20_2, int_57, int_58 - 5, 3);
		gclass193_0.method_5(GClass167.int_22, GClass167.int_23 - GClass14.int_58, GClass167.int_6, GClass167.int_7 + 2 * GClass14.int_58);
	}

	public void method_32()
	{
	}

	public override void update()
	{
		if (int_76 == null && GClass6.gclass76_0[int_26].gclass194_0 != null)
			method_51();
		if (int_76 == null || !method_43())
			return;
		method_30();
		switch (int_12)
		{
		case 0:
		case 1:
			method_33();
			break;
		case 2:
			method_37();
			break;
		case 3:
			method_40();
			break;
		case 4:
			method_34();
			break;
		case 5:
			int_24 = 0;
			method_41();
			break;
		case 6:
			int_24 = 0;
			int_13++;
			int_9 += int_13;
			if (int_9 >= int_17)
			{
				int_9 = int_17;
				int_13 = 0;
				int_12 = 5;
			}
			break;
		case 7:
			method_36();
			base.update();
			break;
		}
	}

	private void method_33()
	{
		int_60++;
		if (int_60 > int_76[13].Length - 1)
			int_60 = int_76[13].Length - 1;
		int_61 = int_76[13][int_60];
		if (int_8 != int_55 || int_9 != int_56)
		{
			int_8 += (int_55 - int_8) / 4;
			int_9 += (int_56 - int_9) / 4;
		}
	}

	private void method_34()
	{
	}

	public void method_35(GClass124 cFocus)
	{
		bool_31 = true;
		gclass6_1 = null;
		gclass124_0 = cFocus;
		int_13 = 0;
		int_14 = 0;
		int_12 = 3;
		int_60 = 0;
		int num = cFocus.int_4;
		int num2 = cFocus.int_5;
		if (GClass191.smethod_28(num - int_8) < int_20 * 2 && GClass191.smethod_28(num2 - int_9) < int_21 * 2)
		{
			if (int_8 >= num)
				int_8 = num + int_20;
			else
				int_8 = num - int_20;
			int_15 = 0;
		}
		else
			int_15 = 1;
	}

	private void method_36()
	{
	}

	private void method_37()
	{
		method_29(int_76[0]);
		if (int_8 != int_55 || int_9 != int_56)
		{
			int_8 += (int_55 - int_8) / 4;
			int_9 += (int_56 - int_9) / 4;
		}
	}

	public void method_38()
	{
		int_12 = 4;
		bool_28 = true;
	}

	public void method_39(GClass124[] cAttack, int[] dame, sbyte type, sbyte dir)
	{
		gclass124_3 = cAttack;
		int_69 = dame;
		sbyte_17 = type;
		int_10 = dir;
		int_12 = 3;
		if (int_8 != int_55 || int_9 != int_56)
		{
			int_8 += (int_55 - int_8) / 4;
			int_9 += (int_56 - int_9) / 4;
		}
	}

	public void method_40()
	{
		if (int_60 == int_76[sbyte_17 + 1].Length - 1)
			int_12 = 2;
		method_29(int_76[sbyte_17 + 1]);
		if (int_60 == int_76[15][sbyte_17 - 1])
		{
			for (int i = 0; i < gclass124_3.Length; i++)
			{
				gclass124_3[i].method_112(int_69[i], 0, false, false);
				GClass91.smethod_0(int_76[16][sbyte_17 - 1], gclass124_3[i].int_4, gclass124_3[i].int_5, 1);
			}
		}
	}

	public void method_41()
	{
		method_29(int_76[1]);
		sbyte b = GClass6.gclass76_0[int_26].sbyte_2;
		int num = b;
		if (GClass191.smethod_28(int_8 - int_55) < b)
			num = GClass191.smethod_28(int_8 - int_55);
		int_8 += ((int_8 >= int_55) ? (-num) : num);
		int_9 = int_56;
		if (int_8 >= int_55)
		{
			if (int_8 > int_55)
				int_10 = -1;
		}
		else
			int_10 = 1;
		if (GClass191.smethod_28(int_8 - int_55) <= 1)
		{
			int_8 = int_55;
			int_12 = 2;
		}
	}

	public bool method_42()
	{
		if (int_8 >= GClass167.int_22)
		{
			if (int_8 > GClass167.int_22 + GClass167.int_6)
				return false;
			if (int_9 < GClass167.int_23)
				return false;
			if (int_9 <= GClass167.int_23 + GClass167.int_7 + 30)
			{
				if (int_12 == 0)
					return false;
				return true;
			}
			return false;
		}
		return false;
	}

	public bool method_43()
	{
		if (int_12 == 0)
			return false;
		return true;
	}

	public override void paint(GClass193 g)
	{
		if (GClass6.gclass76_0[int_26].gclass194_0 == null || bool_19)
			return;
		if (bool_14)
		{
			if (bool_0)
				GClass72.smethod_6(g, short_0, int_30, int_31, (int_10 != 1) ? 2 : 0, GClass193.int_5 | GClass193.int_0);
			else
				GClass6.gclass76_0[int_26].gclass194_0.method_9(g, int_61, int_30, int_31, (int_10 != 1) ? 1 : 0, 2);
			return;
		}
		if (bool_26)
			method_31(g);
		g.method_1(0, GClass14.int_58);
		if (!bool_0)
		{
			int num = 33;
			if (int_74 == -1)
				int_74 = int_9;
			if (GClass137.smethod_28(int_8 + num, int_9 + int_63, 4))
			{
				int_73 = GClass137.smethod_33(int_8 + num) - num;
				int_72 = GClass137.smethod_33(int_8 + num);
				if (int_8 > int_73 && int_8 < int_72 && int_72 != -1)
					int_8 = int_73;
			}
			if (int_9 < int_74 && int_74 != -1)
			{
				int_74 = int_9;
				int_8 += num;
			}
			if (int_9 > int_74)
			{
				int_74 = int_9;
				int_8 -= num;
			}
			GClass6.gclass76_0[int_26].gclass194_0.method_9(g, int_61, int_8, int_9 + int_63, (int_10 != 1) ? 1 : 0, 2);
		}
		else
			GClass72.smethod_6(g, short_0, int_8, int_9 + int_63 - 9, (int_10 != 1) ? 2 : 0, GClass193.int_5 | GClass193.int_0);
		g.method_1(0, -GClass14.int_58);
		if (int_6 <= 0)
			return;
		int num2 = GClass193.smethod_0(gclass20_1);
		int h = GClass193.smethod_1(gclass20_1);
		int num3 = num2;
		int num4 = num2;
		int num5 = int_8 - num2;
		int y = int_9 - int_21 - 5;
		int num6 = num2 * 2 * int_50 / 100;
		int w = num6;
		if (int_51 >= int_50)
		{
			w = num2 * (int_51 -= ((GClass14.int_8 % 6 <= 3) ? int_71 : int_71++)) / 100;
			if (int_51 <= 0)
				int_51 = 0;
			if (int_51 < int_50)
				int_51 = int_50;
			if (int_71 >= 3)
				int_71 = 3;
		}
		if (num6 > num3)
		{
			num4 = num6 - num3;
			if (num4 <= 0)
				num4 = 0;
		}
		else
		{
			num3 = num6;
			num4 = 0;
		}
		g.method_31(GClass167.gclass20_37, num5, y, GClass193.int_4 | GClass193.int_2);
		g.method_31(GClass167.gclass20_37, num5 + num2, y, GClass193.int_4 | GClass193.int_2);
		g.method_16(16777215);
		g.method_15(num5, y, w, 2);
		g.method_23(gclass20_1, 0, 0, num3, h, 0, num5, y, GClass193.int_4 | GClass193.int_2);
		g.method_23(gclass20_1, 0, 0, num4, h, 0, num5 + num2, y, GClass193.int_4 | GClass193.int_2);
	}

	public int method_44()
	{
		return 16711680;
	}

	public void method_45()
	{
		int_6 = 0;
		bool_32 = true;
		int_6 = 0;
		int_12 = 1;
		int_13 = -3;
		int_14 = -int_10;
		int_15 = 0;
	}

	public void method_46(GClass6 mobToAttack)
	{
		gclass6_1 = mobToAttack;
		bool_31 = true;
		gclass124_0 = null;
		int_13 = 0;
		int_14 = 0;
		int_12 = 3;
		int_60 = 0;
		int num = mobToAttack.int_8;
		int num2 = mobToAttack.int_9;
		if (GClass191.smethod_28(num - int_8) < int_20 * 2 && GClass191.smethod_28(num2 - int_9) < int_21 * 2)
		{
			if (int_8 >= num)
				int_8 = num + int_20;
			else
				int_8 = num - int_20;
			int_15 = 0;
		}
		else
			int_15 = 1;
	}

	public new int getX()
	{
		return int_8;
	}

	public new int getY()
	{
		return int_9;
	}

	public new int getH()
	{
		return int_21;
	}

	public new int getW()
	{
		return int_20;
	}

	public new void stopMoving()
	{
		if (int_12 == 5)
		{
			int_12 = 2;
			int_15 = 0;
			int_14 = 0;
			int_13 = 0;
			int_75 = 50;
		}
	}

	public new bool isInvisible()
	{
		return int_12 == 0 || int_12 == 1;
	}

	public void method_47()
	{
		if (int_5 != 0)
			int_5 = 0;
	}

	public void method_48()
	{
		bool_33 = false;
	}

	public void method_49()
	{
		bool_34 = false;
	}

	public void method_50(short xMoveTo, short yMoveTo)
	{
		if (yMoveTo == -1)
		{
			int_55 = xMoveTo;
			int_12 = 5;
		}
		else if (GClass191.smethod_24(int_8, int_9, int_55, int_56) > 100)
		{
			int_8 = xMoveTo;
			int_9 = yMoveTo;
			int_12 = 2;
		}
		else
		{
			int_55 = xMoveTo;
			int_56 = yMoveTo;
			int_12 = 5;
		}
	}

	public void method_51()
	{
		try
		{
			int_76 = (int[][])GClass93.gclass175_0.method_0(int_26 + string.Empty);
			int_20 = GClass6.gclass76_0[int_26].gclass194_0.int_2;
			int_21 = GClass6.gclass76_0[int_26].gclass194_0.int_3;
		}
		catch (Exception)
		{
		}
	}

	public void method_52()
	{
		int_12 = 0;
	}
}
