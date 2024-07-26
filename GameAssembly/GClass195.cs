using System;

public class GClass195 : GClass194, GInterface1
{
	public static GClass70 gclass70_2 = GClass73.smethod_43("/mainImage/shadowBig.png");

	public static GClass72 gclass72_0;

	public int int_55;

	public int int_56;

	public bool bool_24;

	public bool bool_25;

	private GClass194 gclass194_1;

	public int int_57;

	public int int_58;

	private bool bool_26;

	private int int_59;

	public bool bool_27 = true;

	private int int_60;

	private int int_61;

	public static GClass70 gclass70_3 = GClass73.smethod_43("/mainImage/myTexture2dmobHP.png");

	private bool bool_28;

	private int int_62;

	private int int_63;

	private int int_64;

	public int int_65;

	private GClass78 gclass78_2;

	private bool bool_29;

	private bool bool_30;

	private int int_66;

	public bool bool_31;

	private int int_67;

	public bool bool_32 = true;

	private int int_68;

	private GClass78[] gclass78_3;

	private int[] int_69;

	private sbyte sbyte_17;

	public int[] int_70 = new int[12]
	{
		0, 0, 0, 0, 0, 0, 1, 1, 1, 1,
		1, 1
	};

	public int[] int_71 = new int[12]
	{
		0, 0, 0, 2, 2, 2, 3, 3, 3, 4,
		4, 4
	};

	public int[] int_72 = new int[12]
	{
		0, 0, 0, 4, 4, 4, 5, 5, 5, 6,
		6, 6
	};

	public int[] int_73 = new int[17]
	{
		0, 0, 0, 7, 7, 7, 8, 8, 8, 9,
		9, 9, 10, 10, 10, 11, 11
	};

	public int[] int_74 = new int[4] { 1, 1, 7, 7 };

	private bool bool_33;

	private sbyte[] sbyte_18 = new sbyte[2] { -1, 1 };

	public GClass78 gclass78_4;

	public bool bool_34;

	public GClass194 gclass194_2;

	public int int_75;

	public bool bool_35;

	public bool bool_36;

	public GClass195(int id, short px, short py, int templateID, int hp, int maxHp, int s)
	{
		int_25 = id;
		int_16 = (int_8 = px + 20);
		int_17 = (int_9 = py);
		int_55 = int_8;
		int_56 = int_9;
		int_7 = maxHp;
		int_6 = hp;
		int_26 = templateID;
		int_49 = 100;
		byte_0 = 6;
		int_48 = int_49;
		method_20();
		method_29();
		int_12 = 2;
	}

	public void method_29()
	{
		gclass72_0 = null;
		gclass72_0 = new GClass72();
		string patch = "/x" + GClass122.int_12 + "/effectdata/" + 108 + "/data";
		try
		{
			gclass72_0.method_4(patch);
			gclass72_0.gclass70_0 = GClass73.smethod_43("/effectdata/" + 108 + "/img.png");
		}
		catch (Exception)
		{
			GClass7.smethod_0().method_48(int_26);
		}
		int_20 = gclass72_0.int_2;
		int_21 = gclass72_0.int_3;
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
		for (int i = 0; i < GClass194.gclass88_2.method_2(); i++)
		{
			if (((string)GClass194.gclass88_2.method_3(i)).Equals(id))
				return true;
		}
		return false;
	}

	public void method_30(int[] array)
	{
		int_60++;
		if (int_60 > array.Length - 1)
			int_60 = 0;
		int_61 = array[int_60];
	}

	private void method_31()
	{
		int num = GClass20.sbyte_0;
		int_57 = int_8;
		int_59 = 0;
		if (int_58 <= 0 || GClass20.smethod_28(int_57, int_58, 2))
			return;
		if (GClass20.smethod_26(int_57 / num, int_58 / num) != 0)
		{
			if (GClass20.smethod_26(int_57 / num, int_58 / num) != 0 && !GClass20.smethod_28(int_57, int_58, 2))
			{
				int_57 = int_8;
				int_58 = int_9;
				bool_26 = false;
			}
		}
		else
			bool_26 = true;
		while (bool_26 && int_59 < 10)
		{
			int_59++;
			int_58 += 24;
			if (GClass20.smethod_28(int_57, int_58, 2))
			{
				if (int_58 % 24 != 0)
					int_58 -= int_58 % 24;
				break;
			}
		}
	}

	private void method_32(GClass122 gclass122_0)
	{
		gclass122_0.method_31(gclass70_2, int_57, int_17, 3);
		gclass122_0.method_5(GClass144.int_22, GClass144.int_23 - GClass73.int_58, GClass144.int_6, GClass144.int_7 + 2 * GClass73.int_58);
	}

	public void method_33()
	{
	}

	public override void update()
	{
		if (!method_45())
			return;
		method_31();
		switch (int_12)
		{
		case 0:
		case 1:
			method_34();
			break;
		case 2:
			method_39();
			break;
		case 3:
			method_42();
			break;
		case 5:
			int_24 = 0;
			method_43();
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
			method_38();
			break;
		case 4:
			break;
		}
	}

	private void method_34()
	{
		method_30(int_70);
		if (GClass73.int_8 % 5 == 0)
			GClass97.smethod_0(167, GClass50.smethod_19(int_8 - getW() / 2, int_8 + getW() / 2), GClass50.smethod_19(getY() + getH() / 2, getY() + getH()), 1);
		if (int_8 != int_55 || int_9 != int_56)
		{
			int_8 += (int_55 - int_8) / 4;
			int_9 += (int_56 - int_9) / 4;
		}
	}

	public void method_35()
	{
	}

	public void method_36(GClass78 cFocus)
	{
		bool_32 = true;
		gclass194_2 = null;
		gclass78_0 = cFocus;
		int_13 = 0;
		int_14 = 0;
		int_12 = 3;
		int_60 = 0;
		int_10 = ((cFocus.int_4 > int_8) ? 1 : (-1));
		int num = cFocus.int_4;
		int num2 = cFocus.int_5;
		if (GClass50.smethod_28(num - int_8) >= int_20 * 2 || GClass50.smethod_28(num2 - int_9) >= int_21 * 2)
		{
			int_15 = 1;
			return;
		}
		if (int_8 >= num)
			int_8 = num + int_20;
		else
			int_8 = num - int_20;
		int_15 = 0;
	}

	private bool method_37()
	{
		if ((int_26 < 58 || int_26 > 65) && int_26 != 67 && int_26 != 68)
			return false;
		return true;
	}

	private void method_38()
	{
	}

	private void method_39()
	{
		method_30(int_70);
		if (int_8 != int_55 || int_9 != int_56)
		{
			int_8 += (int_55 - int_8) / 4;
			int_9 += (int_56 - int_9) / 4;
		}
	}

	public void method_40()
	{
		int_12 = 4;
		bool_29 = true;
	}

	public void method_41(GClass78[] cAttack, int[] dame, sbyte type)
	{
		gclass78_3 = cAttack;
		int_69 = dame;
		sbyte_17 = type;
		int_12 = 3;
	}

	public void method_42()
	{
		if (sbyte_17 == 3)
		{
			if (int_60 == int_72.Length - 1)
				int_12 = 2;
			int_10 = ((int_8 < gclass78_3[0].int_4) ? 1 : (-1));
			method_30(int_72);
			int_8 += (gclass78_3[0].int_4 - int_8) / 4;
			int_9 += (gclass78_3[0].int_5 - int_9) / 4;
			int_55 = int_8;
			if (int_60 == 8)
			{
				for (int i = 0; i < gclass78_3.Length; i++)
				{
					gclass78_3[i].method_112(int_69[i], 0, false, false);
					GClass97.smethod_0(102, gclass78_3[i].int_4, gclass78_3[i].int_5, 1);
				}
			}
		}
		if (sbyte_17 != 4)
			return;
		if (int_60 == int_73.Length - 1)
			int_12 = 2;
		int_10 = ((int_8 < gclass78_3[0].int_4) ? 1 : (-1));
		method_30(int_73);
		if (int_60 == 8)
		{
			for (int j = 0; j < gclass78_3.Length; j++)
			{
				gclass78_3[j].method_112(int_69[j], 0, false, false);
				GClass97.smethod_0(102, gclass78_3[j].int_4, gclass78_3[j].int_5, 1);
			}
		}
	}

	public void method_43()
	{
		method_30(int_71);
		int_8 += ((int_8 < int_55) ? 2 : (-2));
		int_9 = int_56;
		int_10 = ((int_8 < int_55) ? 1 : (-1));
		if (GClass50.smethod_28(int_8 - int_55) <= 1)
		{
			int_8 = int_55;
			int_12 = 2;
		}
	}

	public bool method_44()
	{
		if (int_8 >= GClass144.int_22)
		{
			if (int_8 <= GClass144.int_22 + GClass144.int_6)
			{
				if (int_9 < GClass144.int_23)
					return false;
				if (int_9 > GClass144.int_23 + GClass144.int_7 + 30)
					return false;
				if (int_12 == 0)
					return false;
				return true;
			}
			return false;
		}
		return false;
	}

	public bool method_45()
	{
		if (int_12 == 0)
			return false;
		return true;
	}

	public bool method_46()
	{
		if (!bool_12 && sbyte_14 <= 0)
			return false;
		return true;
	}

	public override void paint(GClass122 g)
	{
		if (gclass72_0 == null || bool_19)
			return;
		if (!bool_14)
		{
			if (bool_27 && int_12 != 0)
				method_32(g);
			g.method_1(0, GClass73.int_58);
			if (bool_0)
				GClass28.smethod_6(g, short_0, int_8, int_9 + int_63 - 9, (int_10 != 1) ? 2 : 0, GClass122.int_5 | GClass122.int_0);
			else
				gclass72_0.method_9(g, int_61, int_8, int_9 + int_63, (int_10 != 1) ? 1 : 0, 2);
			g.method_1(0, -GClass73.int_58);
			int num = GClass122.smethod_0(gclass70_1);
			int h = GClass122.smethod_1(gclass70_1);
			int num2 = num;
			int num3 = num;
			int num4 = int_8 - num;
			int y = int_9 - int_21 - 5;
			int num5 = num * 2 * int_50 / 100;
			if (num5 <= num2)
			{
				num2 = num5;
				num3 = 0;
			}
			else
			{
				num3 = num5 - num2;
				if (num3 <= 0)
					num3 = 0;
			}
			g.method_31(GClass144.gclass70_37, num4, y, GClass122.int_4 | GClass122.int_2);
			g.method_31(GClass144.gclass70_37, num4 + num, y, GClass122.int_4 | GClass122.int_2);
			g.method_23(gclass70_1, 0, 0, num2, h, 0, num4, y, GClass122.int_4 | GClass122.int_2);
			g.method_23(gclass70_1, 0, 0, num3, h, 0, num4 + num, y, GClass122.int_4 | GClass122.int_2);
			if (bool_33)
			{
				int_67++;
				GClass57.smethod_0(new GClass81((sbyte_17 != 2) ? 22 : 19, int_8 + int_67 * 50, int_9 + 25, 2, 1, -1));
				GClass57.smethod_0(new GClass81((sbyte_17 != 2) ? 22 : 19, int_8 - int_67 * 50, int_9 + 25, 2, 1, -1));
				if (int_67 == 50)
				{
					int_67 = 0;
					bool_33 = false;
				}
			}
		}
		else if (bool_0)
		{
			GClass28.smethod_6(g, short_0, int_30, int_31, (int_10 != 1) ? 2 : 0, GClass122.int_5 | GClass122.int_0);
		}
		else
		{
			gclass72_0.method_9(g, int_61, int_30, int_31, (int_10 != 1) ? 1 : 0, 2);
		}
	}

	public int method_47()
	{
		return 16711680;
	}

	public void method_48()
	{
		int_6 = 0;
		bool_34 = true;
		int_6 = 0;
		int_12 = 1;
		int_13 = -3;
		int_14 = -int_10;
		int_15 = 0;
	}

	public void method_49(GClass194 mobToAttack)
	{
		gclass194_2 = mobToAttack;
		bool_32 = true;
		gclass78_0 = null;
		int_13 = 0;
		int_14 = 0;
		int_12 = 3;
		int_60 = 0;
		int_10 = ((mobToAttack.int_8 > int_8) ? 1 : (-1));
		int num = mobToAttack.int_8;
		int num2 = mobToAttack.int_9;
		if (GClass50.smethod_28(num - int_8) < int_20 * 2 && GClass50.smethod_28(num2 - int_9) < int_21 * 2)
		{
			if (int_8 < num)
				int_8 = num - int_20;
			else
				int_8 = num + int_20;
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
		return int_9 - 40;
	}

	public new int getH()
	{
		return 40;
	}

	public new int getW()
	{
		return 40;
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

	public void method_50()
	{
		if (int_5 != 0)
			int_5 = 0;
	}

	public void method_51()
	{
		bool_35 = false;
	}

	public void method_52()
	{
		bool_36 = false;
	}

	public void method_53(short xMoveTo)
	{
		int_55 = xMoveTo;
		int_12 = 5;
	}
}
