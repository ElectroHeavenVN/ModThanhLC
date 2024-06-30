using System;
using ns1;

public class GClass116
{
	public const sbyte sbyte_0 = -1;

	public const sbyte sbyte_1 = 0;

	public const sbyte sbyte_2 = 1;

	public const sbyte sbyte_3 = 2;

	public const sbyte sbyte_4 = 3;

	public const short short_0 = 0;

	public const short short_1 = 1;

	public const short short_2 = 2;

	public const short short_3 = 3;

	public const short short_4 = 9;

	public const short short_5 = 10;

	public const short short_6 = 11;

	public const short short_7 = 16;

	public const short short_8 = 17;

	public const short short_9 = 18;

	public const short short_10 = 19;

	public const short short_11 = 20;

	public const short short_12 = 21;

	public const short short_13 = 22;

	public const short short_14 = 23;

	public const short short_15 = 24;

	public const short short_16 = 25;

	public const short short_17 = 26;

	private GClass63 gclass63_0 = new GClass63("EffectEnd VecEffEnd");

	public GClass125 gclass125_0;

	public byte[] byte_0 = new byte[10];

	public byte[] byte_1 = new byte[10];

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public short short_18;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int int_12;

	public int int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	public int int_18;

	public int int_19;

	public int int_20;

	public int int_21;

	public int int_22;

	public int int_23;

	public int int_24;

	public int int_25;

	public int int_26;

	public int int_27;

	public int int_28;

	public int int_29;

	public short short_19;

	public long long_0;

	public bool bool_0;

	public bool bool_1;

	public GClass58 gclass58_0;

	public GClass84[] gclass84_0;

	public GClass84 gclass84_1;

	public static short[][] short_20 = new short[29][]
	{
		new short[3] { 68, 264, 4 },
		new short[3] { 30, 120, 4 },
		new short[3] { 66, 280, 4 },
		new short[3] { 0, 0, 1 },
		new short[3] { 111, 68, 2 },
		new short[3] { 90, 68, 2 },
		new short[3] { 125, 68, 2 },
		new short[3] { 47, 282, 6 },
		new short[3] { 10, 40, 4 },
		new short[3] { 92, 525, 7 },
		new short[3] { 62, 372, 6 },
		new short[3] { 80, 352, 4 },
		new short[3] { 80, 352, 4 },
		new short[3] { 80, 352, 4 },
		new short[3] { 72, 240, 3 },
		new short[3] { 20, 42, 3 },
		new short[3] { 65, 160, 4 },
		new short[3] { 50, 300, 6 },
		new short[3] { 84, 168, 2 },
		new short[3] { 90, 540, 6 },
		new short[3] { 180, 900, 6 },
		new short[3] { 62, 186, 3 },
		new short[3] { 34, 80, 4 },
		new short[3] { 140, 560, 4 },
		new short[3] { 64, 600, 6 },
		new short[3] { 36, 200, 5 },
		new short[3] { 35, 200, 5 },
		new short[3] { 50, 250, 5 },
		new short[3] { 50, 240, 6 }
	};

	public int int_30;

	public int int_31;

	public int int_32;

	public int int_33;

	public byte[] byte_2 = new byte[24]
	{
		12, 11, 10, 9, 8, 7, 6, 5, 4, 3,
		2, 1, 0, 23, 22, 21, 20, 19, 18, 17,
		16, 15, 14, 13
	};

	public byte[] byte_3 = new byte[24]
	{
		0, 0, 2, 1, 1, 2, 0, 0, 2, 1,
		1, 2, 0, 0, 2, 1, 1, 2, 0, 0,
		2, 1, 1, 2
	};

	public byte[] byte_4 = new byte[24]
	{
		2, 2, 3, 3, 3, 4, 5, 5, 5, 5,
		5, 1, 0, 0, 0, 0, 0, 7, 6, 6,
		6, 6, 6, 2
	};

	private int int_34;

	private int int_35;

	private int int_36;

	private int int_37;

	private int int_38;

	private int[] int_39;

	private int[] int_40;

	private int[] int_41;

	private int[] int_42;

	public static int[][] int_43 = new int[3][]
	{
		new int[3] { 16310304, 16298056, 16777215 },
		new int[3] { 7045120, 12643960, 16777215 },
		new int[3] { 2407423, 11987199, 16777215 }
	};

	private int[] int_44;

	private int int_45;

	private int int_46;

	private int int_47;

	private GClass125[] gclass125_1;

	public GClass116(int type, int typeSub, int x, int y, int levelPaint, int dir, short timeRemove, GClass84[] listObj)
	{
		int_14 = 0;
		int_27 = 0;
		int_1 = type;
		int_2 = typeSub;
		int_7 = x;
		int_8 = y;
		int_13 = levelPaint;
		int_11 = dir;
		int_12 = ((dir == -1) ? 2 : 0);
		long_0 = GClass138.smethod_18();
		short_19 = timeRemove;
		bool_1 = false;
		bool_0 = false;
		int_6 = 4;
		if (listObj != null)
		{
			gclass84_0 = new GClass84[listObj.Length];
			for (int i = 0; i < gclass84_0.Length; i++)
			{
				gclass84_0[i] = listObj[i];
			}
		}
		method_38();
		method_0();
	}

	public GClass116(int type, int typeSub, int typePaint, GClass58 charUse, GClass84 target, int levelPaint, short timeRemove, short range)
	{
		int_14 = 0;
		int_27 = 0;
		int_1 = type;
		int_2 = typeSub;
		int_0 = typePaint;
		gclass58_0 = charUse;
		if (charUse.method_161(1265))
		{
			if (int_1 == 21 || int_1 == 22 || int_1 == 23)
				gclass58_0.int_4 += 10 * gclass58_0.int_12;
			else if (int_1 == 18 || int_1 == 19 || int_1 == 20)
			{
				gclass58_0.int_4 += -15 * gclass58_0.int_12;
			}
			else
			{
				gclass58_0.int_4 += 15 * gclass58_0.int_12;
			}
		}
		int_7 = gclass58_0.int_4;
		int_8 = gclass58_0.int_5;
		int_11 = gclass58_0.int_12;
		int_12 = ((int_11 == -1) ? 2 : 0);
		gclass84_1 = target;
		int_13 = levelPaint;
		long_0 = GClass138.smethod_18();
		short_19 = timeRemove;
		int_3 = range;
		bool_1 = false;
		bool_0 = false;
		int_6 = 4;
		method_38();
		method_0();
	}

	public GClass116(int type, int typeSub, int typePaint, int x, int y, int levelPaint, int dir, short timeRemove, GClass84[] listObj)
	{
		int_14 = 0;
		int_27 = 0;
		int_1 = type;
		int_2 = typeSub;
		int_0 = typePaint;
		int_7 = x;
		int_8 = y;
		int_13 = levelPaint;
		int_11 = dir;
		int_12 = ((dir == -1) ? 2 : 0);
		long_0 = GClass138.smethod_18();
		short_19 = timeRemove;
		bool_1 = false;
		bool_0 = false;
		int_6 = 4;
		if (listObj != null)
		{
			gclass84_0 = new GClass84[listObj.Length];
			for (int i = 0; i < gclass84_0.Length; i++)
			{
				gclass84_0[i] = listObj[i];
			}
		}
		method_38();
		method_0();
	}

	public static GClass2 smethod_0(int id)
	{
		if (id < 0)
			return null;
		string path = "/e/e_" + id + ".png";
		GClass2 result = null;
		try
		{
			result = GClass138.smethod_35(path);
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	public static void smethod_1(int x, int y, int typeEffect)
	{
		try
		{
			GClass56.smethod_20(3);
		}
		catch (Exception ex)
		{
			GClass56.smethod_10("ERR setSoundSkill_END: " + ex.ToString());
		}
	}

	public void method_0()
	{
		try
		{
			smethod_1(int_7, int_8, int_1);
			switch (int_1)
			{
			case 0:
			case 1:
			case 2:
				method_11(int_1);
				break;
			case 3:
				method_14();
				break;
			case 9:
				method_29();
				break;
			case 10:
			case 11:
				method_33();
				break;
			case 16:
			case 17:
				method_45();
				break;
			case 18:
			case 19:
			case 20:
				method_42();
				break;
			case 21:
			case 22:
			case 23:
				method_39();
				break;
			case 24:
				method_17();
				break;
			case 25:
				method_20();
				break;
			case 26:
				method_23();
				break;
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 12:
			case 13:
			case 14:
			case 15:
				break;
			}
		}
		catch (Exception ex)
		{
			GClass56.smethod_10("ERR create_Effect: " + ex.ToString());
			method_3();
		}
	}

	public void method_1()
	{
		try
		{
			int_14++;
			switch (int_1)
			{
			case 0:
			case 1:
			case 2:
				method_12();
				break;
			case 3:
				method_15();
				break;
			case 9:
				method_30();
				break;
			case 10:
			case 11:
				method_34();
				break;
			case 16:
			case 17:
				method_46();
				break;
			case 18:
			case 19:
			case 20:
				method_43();
				break;
			case 21:
			case 22:
			case 23:
				method_40();
				break;
			case 24:
				method_18();
				break;
			case 25:
				method_21();
				break;
			case 26:
				method_26();
				break;
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 12:
			case 13:
			case 14:
			case 15:
				break;
			}
		}
		catch (Exception ex)
		{
			GClass56.smethod_10("ERR update: " + ex.ToString());
			method_3();
		}
	}

	public void method_2(GClass76 g)
	{
		try
		{
			if (bool_0 || int_14 < 0)
				return;
			switch (int_1)
			{
			case 0:
			case 1:
			case 2:
				if (GClass173.smethod_0().bool_9)
					method_13(g);
				break;
			case 3:
				if (GClass173.smethod_0().bool_9)
					method_16(g);
				break;
			case 9:
				method_32(g);
				break;
			case 10:
			case 11:
				method_35(g);
				break;
			case 16:
				if (GClass173.smethod_0().bool_9)
				{
					if (int_2 == 0)
						method_47(g, GClass76.int_5 | GClass76.int_0);
					else
						method_47(g, GClass76.int_1 | GClass76.int_0);
				}
				break;
			case 17:
				if (GClass173.smethod_0().bool_9)
					method_47(g, GClass76.int_1);
				break;
			case 18:
			case 19:
			case 20:
				method_44(g, GClass76.int_5 | GClass76.int_0);
				break;
			case 21:
			case 22:
			case 23:
				method_41(g, GClass76.int_1 | GClass76.int_0);
				break;
			case 24:
				method_19(g);
				break;
			case 25:
				method_22(g);
				break;
			case 26:
				method_27(g);
				break;
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 12:
			case 13:
			case 14:
			case 15:
				break;
			}
		}
		catch (Exception ex)
		{
			GClass56.smethod_10(ex.ToString());
			method_3();
		}
	}

	public void method_3()
	{
		bool_0 = true;
	}

	public void method_4(bool isRandom, GClass58 obj)
	{
		if (isRandom)
		{
			switch (GClass56.smethod_20(4))
			{
			case 0:
				int_33 = 90;
				break;
			case 1:
				int_33 = 270;
				break;
			case 2:
				int_33 = 180;
				break;
			case 3:
				int_33 = 0;
				break;
			}
		}
		else if (obj.int_12 == 1)
		{
			int_33 = 0;
		}
		else
		{
			int_33 = 180;
		}
		int_32 = (short)(256 * int_24);
		int_17 = 0;
		int_18 = 0;
		int_30 = 0;
		int_21 = int_32 * GClass56.smethod_2(int_33) >> 10;
		int_22 = int_32 * GClass56.smethod_1(int_33) >> 10;
	}

	public void method_5(int fmove)
	{
		if (int_14 < fmove)
			return;
		if (gclass58_0 == null || gclass84_1 == null || int_14 >= int_4)
		{
			int_14 = int_4;
			return;
		}
		int num = gclass84_1.int_0 - gclass58_0.int_4;
		int num2 = gclass84_1.int_1 - gclass58_0.int_5;
		int_30++;
		if ((GClass56.smethod_28(num) < 10 && GClass56.smethod_28(num2) < 10) || int_30 > int_4)
		{
			int_14 = int_4;
			return;
		}
		int num3 = GClass56.smethod_5(num, num2);
		if (GClass56.smethod_28(num3 - int_33) < 90 || num * num + num2 * num2 > 4096)
		{
			if (GClass56.smethod_28(num3 - int_33) < 15)
				int_33 = num3;
			else if ((num3 - int_33 >= 0 && num3 - int_33 < 180) || num3 - int_33 < -180)
			{
				int_33 = GClass56.smethod_6(int_33 + 15);
			}
			else
			{
				int_33 = GClass56.smethod_6(int_33 - 15);
			}
		}
		if (int_14 > int_4 * 2 / 3 && int_32 < 8192)
			int_32 += 3096;
		int_21 = int_32 * GClass56.smethod_2(int_33) >> 10;
		int_22 = int_32 * GClass56.smethod_1(int_33) >> 10;
		num += int_21;
		int_7 += num >> 10;
		num &= 0x3FF;
		num2 += int_22;
		int_8 += num2 >> 10;
		num2 &= 0x3FF;
	}

	public int method_6(int goc)
	{
		if (goc <= 15 || goc > 345)
			return 12;
		int num = (goc - 15) / 15 + 1;
		if (num > 24)
			num = 24;
		return byte_2[num];
	}

	public void method_7(int vMax, GClass84 targetPoint)
	{
		int_24 = vMax;
		int num = 0;
		int num2 = 0;
		if (targetPoint != null)
		{
			num = targetPoint.int_0 - int_7;
			num2 = targetPoint.int_1 - int_8;
			int_25 = targetPoint.int_0;
			int_26 = targetPoint.int_1;
		}
		else
		{
			num = int_25 - int_7;
			num2 = int_26 - int_8;
		}
		if (int_7 > int_25)
		{
			int_11 = 2;
			int_12 = 0;
		}
		else
		{
			int_11 = 0;
			int_12 = 2;
		}
		int_15 = method_6(GClass56.smethod_5(num, num2));
		int_16 = int_15;
		method_8(num, num2);
	}

	public void method_8(int dx, int dy)
	{
		int num = 0;
		int num2 = 0;
		int num3 = GClass56.smethod_25(dx, dy) / int_24;
		if (num3 == 0)
			num3 = 1;
		num = dx / num3;
		num2 = dy / num3;
		if (num == 0 && dx < num3)
			num = ((dx >= 0) ? 1 : (-1));
		if (num2 == 0 && dy < num3)
			num2 = ((dy >= 0) ? 1 : (-1));
		if (GClass56.smethod_28(num) > GClass56.smethod_28(dx))
			num = dx;
		if (GClass56.smethod_28(num2) > GClass56.smethod_28(dy))
			num2 = dy;
		int_17 = num;
		int_18 = num2;
	}

	public void method_9(int toX, int toY, int fMove, int typeEff_End, int rangeEnd)
	{
		if (int_14 < fMove)
		{
			int_15 = method_6((int_11 == -1) ? 180 : 0);
			return;
		}
		int_15 = int_16;
		if (GClass56.smethod_28(int_7 - toX) < GClass56.smethod_28(int_17))
		{
			int_7 = toX;
			int_17 = 0;
		}
		else
			int_7 += int_17;
		if (GClass56.smethod_28(int_8 - toY) < GClass56.smethod_28(int_18))
		{
			int_8 = toY;
			int_18 = 0;
		}
		else
			int_8 += int_18;
		if (GClass56.smethod_28(int_7 - toX) >= GClass56.smethod_28(int_24) || GClass56.smethod_28(int_8 - toY) >= GClass56.smethod_28(int_24) || typeEff_End < 0)
			return;
		if (gclass84_1 != null)
		{
			int num = gclass84_1.int_0;
			int num2 = gclass84_1.int_1;
			if (rangeEnd > 0)
			{
				num += GClass56.smethod_21(0, rangeEnd);
				num2 += GClass56.smethod_21(0, rangeEnd);
			}
			GClass154.smethod_35(typeEff_End, 0, 0, num, num2, 1, 0, -1, null);
			method_3();
		}
		else if (bool_1)
		{
			bool_1 = false;
			int num3 = int_7;
			int num4 = int_8;
			if (rangeEnd > 1)
			{
				num3 += GClass56.smethod_22(rangeEnd);
				num4 += GClass56.smethod_22(rangeEnd);
			}
			GClass154.smethod_35(typeEff_End, 0, 0, num3, num4, 1, 0, -1, null);
		}
	}

	public void method_10(GClass76 g, GClass125 frm, int index, int x, int y, int anchor, bool isCountFr)
	{
		if (frm != null)
		{
			int num = frm.int_2 / 3;
			if (num < 1)
				num = 1;
			int num2 = 0;
			int num3 = 3;
			if (frm.int_2 <= 6)
				num2 = ((frm.int_2 <= 3) ? (int_14 % num) : ((int_14 / num3 % 2 != 0) ? 3 : 0));
			else
			{
				num = 1;
				num2 = ((int_14 / num3 - int_5 > 8) ? 6 : ((int_14 / num3 - int_5 > 4) ? 3 : 0));
			}
			int idx = num * byte_3[index] + num2;
			if (frm.int_2 < 3)
				idx = int_14 / num3 % frm.int_2;
			if (isCountFr)
				idx = int_14 / num3 % frm.int_2;
			frm.method_0(idx, x, y, byte_4[index], anchor, g);
		}
	}

	private void method_11(int int_48)
	{
		switch (int_48)
		{
		case 0:
			gclass125_0 = new GClass125(4);
			break;
		case 1:
			gclass125_0 = new GClass125(5);
			break;
		case 2:
			gclass125_0 = new GClass125(6);
			break;
		}
		int_4 = 100;
		int_23 = GClass39.int_11 / 3 + 10;
		int_18 = 10;
		int_20 = 0;
		bool_1 = false;
	}

	private void method_12()
	{
		int_7 = GClass39.int_12;
		int_8 = int_20;
		if (int_14 > int_4)
			method_3();
		int_18++;
		if (int_18 > 15)
			int_18 = 15;
		if (int_20 + int_18 < int_23)
		{
			int_20 += int_18;
			return;
		}
		int_20 = int_23;
		if (!bool_1)
		{
			bool_1 = true;
			if (int_2 != -1)
				GClass154.smethod_35(int_2, 0, 0, int_7, int_8, int_13, 0, -1, null);
		}
	}

	private void method_13(GClass76 gclass76_0)
	{
		if (gclass125_0 != null)
			gclass125_0.method_0(int_14 / 5 % gclass125_0.int_2, int_7, int_8, 0, 33, gclass76_0);
	}

	private void method_14()
	{
		int num = 0;
		num = GClass56.smethod_19(3, 5);
		int_4 = 90;
		for (int i = 0; i < num; i++)
		{
			GClass84 gClass = new GClass84();
			gClass.int_0 = int_7 + GClass56.smethod_22(4);
			gClass.int_1 = int_8 + GClass56.smethod_22(5);
			if (int_2 == 0)
			{
				gClass.int_18 = GClass56.smethod_20(10);
				int num2 = 1;
				if (i % 2 == 0)
					num2 = -1;
				gClass.int_0 = int_7 + GClass56.smethod_20(short_20[5][0] / 2) * num2;
				gClass.int_1 = int_8 - GClass56.smethod_20(short_20[5][1] / 2);
				gClass.gclass125_1 = new GClass125(7);
			}
			gclass63_0.method_0(gClass);
		}
	}

	private void method_15()
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass84 gClass = (GClass84)gclass63_0.method_3(i);
			gClass.method_0();
			if (gClass.int_16 == gClass.int_18)
				GClass29.smethod_2(gClass.int_0, gClass.int_1, GClass29.int_35, GClass29.float_0);
			if (gClass.int_16 - gClass.int_18 <= gClass.gclass125_1.int_2 * 3 - 1)
				continue;
			gClass.int_16 = 0;
			if (int_2 == 0)
			{
				gClass.int_18 = GClass56.smethod_20(10);
				int num = 1;
				if (i % 2 == 0)
					num = -1;
				gClass.int_0 = int_7 + GClass56.smethod_20(short_20[5][0] / 2) * num;
				gClass.int_1 = int_8 - GClass56.smethod_20(short_20[5][1] / 2);
			}
		}
		if (int_14 >= int_4)
			method_3();
	}

	private void method_16(GClass76 gclass76_0)
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass84 gClass = (GClass84)gclass63_0.method_3(i);
			if (gClass.int_16 - gClass.int_18 > -1 && gClass.gclass125_1 != null)
				gClass.gclass125_1.method_0((gClass.int_16 - gClass.int_18) / 3 % gClass.gclass125_1.int_2, gClass.int_0, gClass.int_1, 0, 3, gclass76_0);
		}
	}

	private void method_17()
	{
		int_9 = gclass125_1[0].int_0;
		int_10 = gclass125_1[0].int_1;
		int_24 = GClass56.smethod_28(int_7 - gclass84_1.int_0);
		byte_0 = new byte[6] { 0, 0, 0, 1, 1, 1 };
		bool_1 = false;
		GClass29.smethod_2(int_7, int_8, GClass29.int_37, GClass29.float_0);
	}

	private void method_18()
	{
		int_16++;
		int_9 += 20;
		if (int_9 > int_24)
			int_9 = int_24;
		int_7 = gclass58_0.int_4 + 10;
		int_8 = gclass58_0.int_5 - 3;
		if (int_11 == -1)
			int_7 = gclass58_0.int_4 - int_9 - 10;
		if (!bool_1 && GClass39.long_0 - long_0 >= short_19)
		{
			int_14 = 0;
			byte_0 = new byte[6] { 2, 2, 2, 3, 3, 3 };
			bool_1 = true;
		}
		if (int_14 > byte_0.Length - 1)
		{
			if (bool_1)
				method_3();
			else
				int_14 = 0;
		}
	}

	private void method_19(GClass76 gclass76_0)
	{
		if (gclass125_1 != null)
		{
			gclass76_0.method_5(int_7, int_8 - int_10 / 2, int_9, int_10);
			method_28(gclass76_0, gclass125_1[0], gclass125_1[1], gclass125_1[2], byte_0[int_14], int_7, int_8, int_24);
			GClass39.smethod_7(gclass76_0);
			if (int_11 == -1 && gclass125_1[0] != null)
				gclass125_1[0].method_0(byte_0[int_14], int_7 + int_9 - gclass125_1[0].int_0, int_8 - gclass125_1[0].int_1 / 2 - 1, 2, 0, gclass76_0);
		}
	}

	private void method_20()
	{
		int_7 = gclass58_0.int_4 + 20 * gclass58_0.int_12;
		int num = 15;
		int_5 = short_19 / 15;
		if (gclass84_1 != null)
		{
			for (int i = 0; i < num; i++)
			{
				GClass84 gClass = new GClass84();
				gClass.gclass125_1 = gclass125_1[0];
				gClass.gclass125_2 = gclass125_1[2];
				gClass.int_0 = int_7;
				gClass.int_1 = int_8;
				if (gclass84_1 != null)
				{
					gClass.int_13 = gclass84_1.int_0;
					gClass.int_14 = gclass84_1.int_1;
					if (int_3 > 0)
					{
						gClass.int_13 += GClass56.smethod_21(0, int_3);
						gClass.int_14 += GClass56.smethod_21(0, int_3);
					}
				}
				int_24 = GClass56.smethod_19(9, 12);
				if (i == num - 1)
				{
					gClass.gclass125_1 = gclass125_1[1];
					gClass.gclass125_2 = gclass125_1[3];
					gClass.int_13 = gclass84_1.int_0;
					gClass.int_14 = gclass84_1.int_1;
					int_24 = 9;
				}
				gClass.bool_2 = false;
				gClass.bool_3 = false;
				gClass.bool_0 = false;
				gClass.method_5(int_24);
				gclass63_0.method_0(gClass);
			}
		}
		else
			method_3();
	}

	private void method_21()
	{
		int num = 0;
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass84 gClass = (GClass84)gclass63_0.method_3(i);
			if (!gClass.bool_2 && GClass39.long_0 - long_0 >= i * int_5)
			{
				gClass.bool_2 = true;
				GClass154.smethod_35(17, 0, int_0, gclass58_0.int_4, gclass58_0.int_5 - 3, 2, int_12, -1, null);
				if (i == gclass63_0.method_2() - 1)
					GClass29.smethod_2(gClass.int_0, gClass.int_1, GClass29.int_39, GClass29.float_0);
				else
					GClass29.smethod_2(gClass.int_0, gClass.int_1, GClass29.int_38, GClass29.float_0);
			}
			if (gClass.bool_2 && !gClass.bool_0)
			{
				gClass.int_16++;
				if (!gClass.bool_3)
				{
					if (gClass.int_16 < 10 && i == gclass63_0.method_2() - 1 && gclass58_0 != null && !GClass1.smethod_27(gclass58_0.int_4 - (gclass58_0.int_59 + 1) * gclass58_0.int_12, gclass58_0.int_5, (gclass58_0.int_12 != 1) ? 4 : 8))
						gclass58_0.int_4 -= gclass58_0.int_12;
					gClass.method_7(gClass.int_13, gClass.int_14);
					if (gClass.int_0 == gClass.int_13)
					{
						gClass.bool_3 = true;
						gClass.int_16 = 0;
					}
				}
				if (gClass.bool_3 && gClass.int_16 >= int_6 * gClass.gclass125_2.int_2)
					gClass.bool_0 = true;
			}
			if (gClass.bool_0)
				num++;
		}
		if (num == gclass63_0.method_2())
			method_3();
	}

	private void method_22(GClass76 gclass76_0)
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass84 gClass = (GClass84)gclass63_0.method_3(i);
			if (gClass.bool_2 && !gClass.bool_0)
			{
				if (!gClass.bool_3)
					gClass.method_8(gclass76_0, gClass.gclass125_1, GClass76.int_1 | GClass76.int_0, false);
				if (gClass.bool_3)
					gClass.gclass125_2.method_0(gClass.int_16 / int_6 % gClass.gclass125_2.int_2, gClass.int_0, gClass.int_1, int_12, GClass76.int_1 | GClass76.int_0, gclass76_0);
			}
		}
	}

	private void method_23()
	{
		byte_0 = new byte[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };
		bool_1 = false;
		int_5 = 10;
		int_19 = int_7;
		int_20 = int_8 + 12;
		int_29 = 25;
		int_23 = 19;
		if (int_2 == 1)
			int_23 = 21;
		else if (int_2 == 2)
		{
			int_23 = 31;
		}
		int_10 = gclass125_1[1].int_1 + 50 - int_23;
		int_18 = 1;
		int_22 = 1;
		int_8 = int_20 - int_10;
		int_34 = 90;
		int_24 = 1;
		int_36 = 25;
		int_35 = 25;
		int_38 = 1;
		if (gclass84_0 != null && gclass84_0.Length != 0)
			int_38 = gclass84_0.Length;
		int_37 = 360 / int_38;
		int_39 = new int[int_38];
		int_40 = new int[int_38];
		int_41 = new int[int_38];
		int_42 = new int[int_38];
		GClass154.smethod_35(16, 0, int_0, int_19, int_20, 1, 0, -1, null);
		GClass29.smethod_2(int_7, int_8, GClass29.int_40, GClass29.float_0);
	}

	private void method_24()
	{
		if (int_24 < 40)
			int_24 += 2;
		int_35 = int_36;
		int_35 -= int_24;
		if (int_35 >= 360)
			int_35 -= 360;
		if (int_35 < 0)
			int_35 = 360 + int_35;
		int_36 = int_35;
	}

	private void method_25()
	{
		for (int i = 0; i < int_40.Length; i++)
		{
			if (int_35 >= 360)
				int_35 -= 360;
			if (int_35 < 0)
				int_35 = 360 + int_35;
			int_40[i] = GClass56.smethod_28(int_34 * GClass56.smethod_1(int_35) / 1024);
			int_39[i] = GClass56.smethod_28(int_34 * GClass56.smethod_2(int_35) / 1024);
			if (int_35 < 90)
			{
				int_41[i] = int_7 + int_39[i];
				int_42[i] = int_8 - int_40[i];
			}
			else if (int_35 >= 90 && int_35 < 180)
			{
				int_41[i] = int_7 - int_39[i];
				int_42[i] = int_8 - int_40[i];
			}
			else if (int_35 >= 180 && int_35 < 270)
			{
				int_41[i] = int_7 - int_39[i];
				int_42[i] = int_8 + int_40[i];
			}
			else
			{
				int_41[i] = int_7 + int_39[i];
				int_42[i] = int_8 + int_40[i];
			}
			int_35 -= int_37;
		}
	}

	private void method_26()
	{
		if (int_27 == 0)
		{
			if (int_14 == 3)
				GClass29.smethod_2(int_7, int_8, GClass29.int_41, GClass29.float_0);
			int_15++;
			if (int_15 > byte_0.Length - 1)
				int_15 = byte_0.Length - 1;
			if (int_14 == int_5 + 4)
				GClass154.smethod_35(16, 1, int_0, int_7, int_8, 3, 0, 2945, null);
			if (int_14 > int_5 + 4)
			{
				int_34--;
				if (int_34 < 0)
				{
					int_34 = 0;
					int_14 = 0;
					int_16 = 0;
					byte_1 = new byte[22]
					{
						1, 1, 0, 0, 0, 0, 1, 1, 1, 1,
						0, 0, 0, 1, 1, 1, 0, 0, 1, 1,
						1, 2
					};
					method_37(true);
					int_27 = 1;
				}
				else
				{
					method_24();
					method_25();
					method_36(true);
				}
			}
		}
		else if (int_27 == 1)
		{
			int_16++;
			if (int_16 > byte_1.Length - 1)
			{
				int_16 = byte_1.Length - 1;
				if (GClass39.int_8 % 2 == 0)
					int_22++;
				int_18 += int_22;
				if (int_18 >= int_10 - gclass125_1[0].int_1 - int_29 + int_23)
				{
					int_18 = int_10 - gclass125_1[0].int_1 - int_29 + int_23;
					int_14 = 0;
					int_16 = 0;
					int_27 = 2;
					byte_1 = new byte[11]
					{
						3, 3, 3, 3, 3, 4, 4, 4, 5, 5,
						5
					};
				}
			}
		}
		else if (int_27 == 2)
		{
			int_16++;
			if (int_16 > byte_1.Length - 1)
			{
				int_27 = 3;
				int_15 = 0;
				byte_0 = new byte[17]
				{
					2, 2, 1, 1, 0, 0, 3, 3, 3, 0,
					0, 0, 4, 4, 4, 0, 0
				};
			}
		}
		else if (int_27 == 3)
		{
			int_15++;
			if (int_15 == 3)
				GClass29.smethod_2(int_7, int_8, GClass29.int_41, GClass29.float_0);
			if (int_15 > byte_0.Length - 1)
			{
				int_15 = 0;
				int_27 = 4;
				byte_0 = new byte[51]
				{
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 3, 3, 3,
					0, 0, 0, 4, 4, 4, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 3, 3, 0, 0, 4,
					4
				};
			}
		}
		else
		{
			int_15++;
			if (int_15 > byte_0.Length - 1)
				int_15 = 0;
			if (GClass39.long_0 - long_0 >= short_19)
			{
				GClass154.smethod_35(16, 0, int_0, int_19, int_20, 1, 0, -1, null);
				method_36(false);
				method_3();
			}
		}
	}

	private void method_27(GClass76 gclass76_0)
	{
		if (gclass125_1 == null)
			return;
		if (byte_0 != null)
			gclass125_1[0].method_0(byte_0[int_15], int_19, int_20, 0, GClass76.int_5 | GClass76.int_0, gclass76_0);
		if (int_27 == 1 || int_27 == 2)
		{
			int anchor = GClass76.int_5 | GClass76.int_0;
			int num = int_29;
			if (byte_1[int_16] == 0 || byte_1[int_16] == 1)
			{
				anchor = GClass76.int_1 | GClass76.int_0;
				num = 0;
			}
			gclass125_1[1].method_0(byte_1[int_16], int_7, int_8 + num + int_18, 0, anchor, gclass76_0);
		}
	}

	private void method_28(GClass76 gclass76_0, GClass125 gclass125_2, GClass125 gclass125_3, GClass125 gclass125_4, int int_48, int int_49, int int_50, int int_51)
	{
		int num = 0;
		int num2 = int_51;
		bool flag = false;
		if (gclass125_2 != null && gclass125_4 != null)
		{
			flag = true;
			num2 = int_51 - (gclass125_2.int_0 + gclass125_4.int_0);
		}
		if (num2 > 0)
		{
			num = num2 / gclass125_3.int_0;
			if (num2 % gclass125_3.int_0 > 0)
				num++;
			if (int_11 == -1)
			{
				for (int i = 0; i < num; i++)
				{
					int num3 = 0;
					gclass125_3.method_0(int_48, (i != num - 1) ? ((!flag) ? (int_49 + i * gclass125_3.int_0) : (int_49 + gclass125_4.int_0 + gclass125_3.int_0 + i * gclass125_3.int_0)) : ((!flag) ? (int_49 + int_51 - gclass125_3.int_0) : (int_49 + gclass125_4.int_0)), int_50 - gclass125_3.int_1 / 2, 2, 0, gclass76_0);
				}
			}
			else
			{
				for (int j = 0; j < num; j++)
				{
					int num4 = 0;
					gclass125_3.method_0(int_48, (j != num - 1) ? ((!flag) ? (int_49 + j * gclass125_3.int_0) : (int_49 + j * gclass125_3.int_0 + gclass125_2.int_0)) : ((!flag) ? (int_49 + int_51 - gclass125_3.int_0) : (int_49 + int_51 - (gclass125_3.int_0 + gclass125_4.int_0))), int_50 - gclass125_3.int_1 / 2, 0, 0, gclass76_0);
				}
			}
		}
		if (int_11 == -1)
		{
			gclass125_2?.method_0(int_48, int_49 + int_51 - gclass125_2.int_0, int_50 - gclass125_2.int_1 / 2, 2, 0, gclass76_0);
			gclass125_4?.method_0(int_48, int_49, int_50 - gclass125_4.int_1 / 2, 2, 0, gclass76_0);
		}
		else
		{
			gclass125_2?.method_0(int_48, int_49, int_50 - gclass125_2.int_1 / 2, 0, 0, gclass76_0);
			gclass125_4?.method_0(int_48, int_49 + int_51 - gclass125_4.int_0 - 1, int_50 - gclass125_4.int_1 / 2, 0, 0, gclass76_0);
		}
	}

	private void method_29()
	{
		int_45 = int_2;
		int_19 = int_7 * 1000;
		int_20 = int_8 * 1000;
		int_4 = GClass56.smethod_19(4, 6);
		int_24 = 5;
		int_46 = 10;
		int_47 = 20;
		method_31(int_24, int_46, int_47, 0);
	}

	private void method_30()
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass139 gClass = (GClass139)gclass63_0.method_3(i);
			gClass.method_1();
			if (int_14 >= int_4)
			{
				gclass63_0.method_8(gClass);
				i--;
			}
		}
		if (int_14 >= int_4)
		{
			if (GClass39.long_0 - long_0 >= short_19)
			{
				gclass63_0.method_9();
				method_3();
			}
			else
			{
				int_4 = GClass56.smethod_19(4, 6);
				int_14 = 0;
				method_31(int_24, int_46, int_47, 0);
			}
		}
	}

	private void method_31(int int_48, int int_49, int int_50, int int_51)
	{
		if (int_14 == -1)
			gclass63_0.method_9();
		int num = 4;
		int_44 = new int[4];
		if (int_50 <= int_49)
			int_50 = int_49 + 1;
		for (int i = 0; i < num; i++)
		{
			if (GClass56.smethod_20(2) == 0)
				int_44[i] = int_43[int_45][GClass56.smethod_20(3)];
			else
				int_44[i] = int_43[int_45][2];
		}
		for (int j = 0; j < num; j++)
		{
			GClass139 gClass = new GClass139();
			int num2 = 5 + 180 / num * j;
			int num3 = 180 / num + 180 / num * j - 5;
			if (num3 <= num2)
				num3 = num2 + 1;
			int num4 = GClass56.smethod_19(int_49, int_50);
			int num5 = GClass56.smethod_19(int_48, int_48 + 3);
			int num6 = GClass56.smethod_19(num2, num3);
			int num7 = GClass56.smethod_19(13, 23);
			bool is2Line = GClass56.smethod_20(4) == 0;
			num6 = GClass56.smethod_6(num6 % 360);
			gClass.method_0(int_19 - GClass56.smethod_1(num6) * (num4 + num7), int_20 - GClass56.smethod_2(num6) * (num4 + num7), int_19 - GClass56.smethod_1(num6) * num7, int_20 - GClass56.smethod_2(num6) * num7, GClass56.smethod_1(num6) * num5, GClass56.smethod_2(num6) * num5, is2Line);
			if (int_51 > 0)
				gClass.int_9 = GClass56.smethod_20(int_51);
			gclass63_0.method_0(gClass);
			gClass = new GClass139();
			num6 = GClass56.smethod_6((num6 + (180 + GClass56.smethod_21(2, 5))) % 360);
			gClass.method_0(int_19 - GClass56.smethod_1(num6) * (num4 + num7), int_20 - GClass56.smethod_2(num6) * (num4 + num7), int_19 - GClass56.smethod_1(num6) * num7, int_20 - GClass56.smethod_2(num6) * num7, GClass56.smethod_1(num6) * num5, GClass56.smethod_2(num6) * num5, is2Line);
			if (int_51 > 0)
				gClass.int_9 = GClass56.smethod_20(int_51);
			gclass63_0.method_0(gClass);
		}
	}

	private void method_32(GClass76 gclass76_0)
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass139 gClass = (GClass139)gclass63_0.method_3(i);
			if (gClass != null)
			{
				int rgb = 0;
				if (i / 2 < int_44.Length)
					rgb = int_44[i / 2];
				gclass76_0.method_16(rgb);
				gclass76_0.method_11(gClass.int_0 / 1000, gClass.int_1 / 1000, gClass.int_2 / 1000, gClass.int_3 / 1000);
				if (gClass.bool_0)
					gclass76_0.method_11(gClass.int_0 / 1000 + 1, gClass.int_1 / 1000, gClass.int_2 / 1000 + 1, gClass.int_3 / 1000);
			}
		}
	}

	private void method_33()
	{
		gclass125_0 = new GClass125(8);
		int_4 = GClass56.smethod_19(23, 27);
		int num = GClass56.smethod_19(1, 3);
		int_26 = int_8 - 40;
		for (int i = 0; i < num; i++)
		{
			GClass84 gClass = new GClass84();
			gClass.int_0 = int_7 + GClass56.smethod_21(0, 20);
			gClass.int_1 = int_8 + GClass56.smethod_22(7);
			if (int_1 == 10)
				gClass.int_19 = GClass56.smethod_19(0, gclass125_0.int_2 - 2);
			else if (int_1 == 11)
			{
				gClass.int_19 = GClass56.smethod_19(2, gclass125_0.int_2);
			}
			else
			{
				gClass.int_19 = GClass56.smethod_19(0, gclass125_0.int_2);
			}
			gClass.int_15 = GClass56.smethod_20(2);
			gClass.int_10 = -GClass56.smethod_19(1, 4);
			gclass63_0.method_0(gClass);
		}
	}

	private void method_34()
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass84 gClass = (GClass84)gclass63_0.method_3(i);
			gClass.method_0();
			if (gClass.int_1 < int_26)
			{
				gclass63_0.method_7(i);
				i--;
			}
		}
		if (int_14 >= int_4)
			method_3();
	}

	private void method_35(GClass76 gclass76_0)
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass84 gClass = (GClass84)gclass63_0.method_3(i);
			if (gclass125_0 != null)
				gclass125_0.method_0(gClass.int_19, gClass.int_0, gClass.int_1, 0, GClass76.int_1 | GClass76.int_0, gclass76_0);
		}
	}

	private void method_36(bool bool_2)
	{
		if (gclass84_0 == null)
			return;
		for (int i = 0; i < gclass84_0.Length; i++)
		{
			if (gclass84_0[i] == null)
				continue;
			if (gclass84_0[i].sbyte_0 == 0)
			{
				GClass85 gClass = GClass154.smethod_16(gclass84_0[i].int_29);
				if (gClass != null)
				{
					gClass.bool_14 = bool_2;
					gClass.bool_19 = false;
					gClass.int_30 = int_41[i];
					gClass.int_31 = int_42[i];
				}
				continue;
			}
			GClass58 gClass2 = null;
			gClass2 = ((GClass58.smethod_1().int_13 != gclass84_0[i].int_29) ? GClass154.smethod_14(gclass84_0[i].int_29) : GClass58.smethod_1());
			if (gClass2 != null)
			{
				gClass2.bool_79 = bool_2;
				gClass2.bool_42 = false;
				gClass2.int_178 = int_41[i];
				gClass2.int_179 = int_42[i];
			}
		}
	}

	private void method_37(bool bool_2)
	{
		if (gclass84_0 == null)
			return;
		for (int i = 0; i < gclass84_0.Length; i++)
		{
			if (gclass84_0[i] == null)
				continue;
			if (gclass84_0[i].sbyte_0 == 0)
			{
				GClass85 gClass = GClass154.smethod_16(gclass84_0[i].int_29);
				if (gClass != null)
					gClass.bool_19 = bool_2;
				continue;
			}
			GClass58 gClass2 = null;
			gClass2 = ((GClass58.smethod_1().int_13 != gclass84_0[i].int_29) ? GClass154.smethod_14(gclass84_0[i].int_29) : GClass58.smethod_1());
			if (gClass2 != null)
				gClass2.bool_42 = bool_2;
		}
	}

	private void method_38()
	{
		int num = 0;
		int[] array = null;
		int[] array2 = null;
		switch (int_1)
		{
		case 16:
			num = 26;
			if (int_2 == 0)
			{
				array = new int[1] { 7 };
				array2 = new int[1] { 28 };
			}
			if (int_2 == 1)
			{
				array = new int[1] { 2 };
				array2 = new int[1] { 23 };
			}
			break;
		case 17:
			num = 25;
			array = new int[1] { 2 };
			array2 = new int[1] { 16 };
			break;
		case 18:
			num = 24;
			array = new int[1];
			array2 = new int[1] { 9 };
			break;
		case 19:
			num = 25;
			array = new int[1];
			array2 = new int[1] { 14 };
			break;
		case 20:
			num = 26;
			array = new int[1];
			array2 = new int[1] { 21 };
			break;
		case 21:
			num = 24;
			array = new int[1] { 1 };
			array2 = new int[1] { 10 };
			break;
		case 22:
			num = 25;
			array = new int[1] { 1 };
			array2 = new int[1] { 15 };
			break;
		case 23:
			num = 26;
			array = new int[1] { 1 };
			array2 = new int[1] { 22 };
			break;
		case 24:
			num = 24;
			array = new int[3] { 2, 3, 4 };
			array2 = new int[3] { 11, 12, 13 };
			break;
		case 25:
			num = 25;
			array = new int[4] { 3, 4, 5, 6 };
			array2 = new int[4] { 17, 18, 19, 20 };
			break;
		case 26:
		{
			num = 26;
			int num2 = 0;
			int num3 = 0;
			if (int_2 == 0)
			{
				num2 = 4;
				num3 = 25;
			}
			else if (int_2 == 1)
			{
				num2 = 5;
				num3 = 26;
			}
			else if (int_2 == 2)
			{
				num2 = 6;
				num3 = 27;
			}
			array = new int[2] { num2, 3 };
			array2 = new int[2] { num3, 24 };
			break;
		}
		}
		if (array == null || array2 == null)
			return;
		gclass125_1 = new GClass125[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			GClass125 gClass = GClass138.smethod_34("Skills_" + num + "_" + int_0 + "_" + array[i]);
			if (gClass == null)
				gClass = new GClass125(array2[i]);
			if (gClass != null)
				gclass125_1[i] = gClass;
		}
	}

	private void method_39()
	{
		if (gclass58_0 != null)
		{
			if (int_1 == 21)
			{
				int_7 = gclass58_0.int_4 - 3 * gclass58_0.int_12;
				int_8 = gclass58_0.int_5;
				GClass29.smethod_2(int_7, int_8, GClass29.int_36, GClass29.float_0);
			}
			else if (int_1 == 22)
			{
				int_7 = gclass58_0.int_4 + 20 * gclass58_0.int_12;
				int_8 = gclass58_0.int_5 - 4;
				GClass29.smethod_2(int_7, int_8, GClass29.int_43, GClass29.float_0);
			}
			else if (int_1 == 23)
			{
				int_7 = gclass58_0.int_4;
				int_8 = gclass58_0.int_5 - 50;
				GClass29.smethod_2(int_7, int_8, GClass29.int_42, GClass29.float_0);
			}
			else
			{
				int_7 = gclass58_0.int_4;
				int_8 = gclass58_0.int_5;
			}
		}
	}

	private void method_40()
	{
		if (gclass58_0 != null)
		{
			if (int_1 == 21)
			{
				int_7 = gclass58_0.int_4 - 3 * gclass58_0.int_12;
				int_8 = gclass58_0.int_5;
			}
			else if (int_1 == 22)
			{
				int_7 = gclass58_0.int_4 + 20 * gclass58_0.int_12;
				int_8 = gclass58_0.int_5 - 4;
			}
			else if (int_1 == 23)
			{
				int_7 = gclass58_0.int_4;
				int_8 = gclass58_0.int_5 - 50;
			}
			else
			{
				int_7 = gclass58_0.int_4;
				int_8 = gclass58_0.int_5;
			}
		}
		if (short_19 > 0)
		{
			if (GClass39.long_0 - long_0 >= short_19)
				method_3();
		}
		else if (int_14 >= gclass125_1[0].int_2 * int_6)
		{
			method_3();
		}
	}

	private void method_41(GClass76 gclass76_0, int int_48)
	{
		if (gclass125_1[0] != null)
			gclass125_1[0].method_0(int_14 / int_6 % gclass125_1[0].int_2, int_7, int_8, int_12, int_48, gclass76_0);
	}

	private void method_42()
	{
		byte_0 = null;
		int_6 = 3;
		if (int_1 == 18)
		{
			if (int_2 == 0)
				byte_0 = new byte[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };
			else
				byte_0 = new byte[12]
				{
					3, 3, 3, 4, 4, 4, 5, 5, 5, 6,
					6, 6
				};
		}
	}

	private void method_43()
	{
		if (gclass58_0 != null)
		{
			int_7 = gclass58_0.int_4;
			int_8 = gclass58_0.int_5 + 13;
		}
		if (short_19 > 0)
		{
			if (GClass39.long_0 - long_0 >= short_19)
				method_3();
		}
		else if (byte_0 != null)
		{
			if (int_14 > byte_0.Length)
				method_3();
		}
		else if (int_14 >= gclass125_1[0].int_2 * int_6)
		{
			method_3();
		}
	}

	private void method_44(GClass76 gclass76_0, int int_48)
	{
		if (gclass125_1[0] != null)
		{
			if (byte_0 != null)
				gclass125_1[0].method_0(byte_0[int_14 % byte_0.Length], int_7, int_8, int_12, int_48, gclass76_0);
			else
				gclass125_1[0].method_0(int_14 / int_6 % gclass125_1[0].int_2, int_7, int_8, int_12, int_48, gclass76_0);
		}
	}

	private void method_45()
	{
		if (int_1 == 17)
			int_7 += ((int_11 != 0) ? (-gclass125_1[0].int_0) : 0);
	}

	private void method_46()
	{
		if (short_19 > 0)
		{
			if (GClass39.long_0 - long_0 >= short_19)
				method_3();
		}
		else if (int_14 >= gclass125_1[0].int_2 * int_6)
		{
			method_3();
		}
	}

	private void method_47(GClass76 gclass76_0, int int_48)
	{
		gclass125_1[0].method_0(int_14 / int_6 % gclass125_1[0].int_2, int_7, int_8, int_11, int_48, gclass76_0);
	}

	private void method_48()
	{
	}

	private void method_49()
	{
	}

	private void method_50(GClass76 gclass76_0)
	{
	}
}
