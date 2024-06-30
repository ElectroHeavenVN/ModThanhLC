using System;
using UnityEngine;

public class GClass146 : GClass145
{
	public const sbyte sbyte_0 = 0;

	public const sbyte sbyte_1 = 1;

	public const sbyte sbyte_2 = 2;

	public const sbyte sbyte_3 = 3;

	public const sbyte sbyte_4 = 4;

	public static GClass146 gclass146_0;

	public static bool bool_0;

	public static GClass125 gclass125_0;

	public static GClass125 gclass125_1;

	public static GClass125 gclass125_2;

	private static GClass2 gclass2_0;

	private static GClass2 gclass2_1;

	private static GClass2 gclass2_2;

	private static GClass2 gclass2_3;

	private static GClass2 gclass2_4;

	private static GClass2 gclass2_5;

	private static GClass2 gclass2_6;

	private static GClass2 gclass2_7;

	private static GClass2 gclass2_8;

	private static GClass2 gclass2_9;

	private static GClass2 gclass2_10;

	private static GClass2 gclass2_11;

	private static GClass2 gclass2_12;

	private static GClass2 gclass2_13;

	private static GClass2[] gclass2_14;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public static int int_9;

	public static int int_10;

	public static int int_11;

	public static int int_12;

	public static int int_13;

	public static int int_14;

	public static int int_15;

	public static int int_16;

	public static int int_17;

	public static int[] int_18 = new int[0];

	public static int[] int_19 = new int[0];

	private static int[][] int_20;

	private static int[][] int_21;

	private static int[] int_22 = new int[5] { -2, -1, 0, 1, 2 };

	private int int_23;

	private int[] int_24;

	private int int_25;

	private int int_26;

	private int int_27;

	public static GClass63 gclass63_0;

	public static GClass63 gclass63_1;

	private static int int_28;

	private static int int_29;

	private GClass97 gclass97_0;

	private int int_30;

	private int int_31;

	private int int_32;

	private int int_33;

	private int int_34;

	private int int_35;

	public GClass146()
	{
		bool_0 = true;
		GClass2 img = GClass138.smethod_35("/radar/17.png");
		GClass2 img2 = GClass138.smethod_35("/radar/3.png");
		GClass2 img3 = GClass138.smethod_35("/radar/23.png");
		gclass125_0 = new GClass125(img, 28, 28);
		gclass125_1 = new GClass125(img2, 30, 30);
		gclass125_2 = new GClass125(img3, 11, 11);
		gclass2_0 = GClass138.smethod_35("/radar/0.png");
		gclass2_2 = GClass138.smethod_35("/radar/1.png");
		gclass2_3 = GClass138.smethod_35("/radar/2.png");
		gclass2_1 = GClass138.smethod_35("/radar/17.png");
		gclass2_4 = GClass138.smethod_35("/radar/4.png");
		gclass2_5 = GClass138.smethod_35("/radar/5.png");
		gclass2_6 = GClass138.smethod_35("/radar/6.png");
		gclass2_14 = new GClass2[7];
		for (int i = 0; i < 7; i++)
		{
			gclass2_14[i] = GClass138.smethod_35("/radar/" + (i + 7) + ".png");
		}
		gclass2_7 = GClass138.smethod_35("/radar/14.png");
		gclass2_8 = GClass138.smethod_35("/radar/15.png");
		gclass2_9 = GClass138.smethod_35("/radar/16.png");
		gclass2_1 = GClass138.smethod_35("/radar/18.png");
		gclass2_11 = GClass138.smethod_35("/radar/19.png");
		gclass2_12 = GClass138.smethod_35("/radar/20.png");
		gclass2_13 = GClass138.smethod_35("/radar/21.png");
		gclass2_10 = GClass138.smethod_35("/radar/22.png");
		int_8 = 200;
		int_9 = 219;
		int_6 = GClass39.int_12 - (int_8 + 40) / 2;
		int_7 = GClass39.int_13 - int_9 / 2;
		int_12 = int_6 + int_8 - 81;
		int_13 = int_7 + 29;
		int_14 = 120;
		int_16 = 80;
		int_20 = new int[3][]
		{
			new int[2]
			{
				int_6 + 34,
				int_7 + int_9 - 42
			},
			new int[2]
			{
				int_6 + int_8 / 2 - gclass2_4.method_0() / 2,
				int_7 + int_9 / 2 + 33
			},
			new int[2]
			{
				int_6 + int_8 - 41,
				int_7 + int_9 - 42
			}
		};
		int_21 = new int[5][]
		{
			new int[2]
			{
				int_6 + 25,
				int_7 + int_9 - 82
			},
			new int[2]
			{
				int_6 + 57,
				int_7 + int_9 - 62
			},
			new int[2]
			{
				int_6 + int_8 / 2 - 14,
				int_7 + int_9 - 102
			},
			new int[2]
			{
				int_6 + int_8 - 57 - 28,
				int_7 + int_9 - 62
			},
			new int[2]
			{
				int_6 + int_8 - 25 - 28,
				int_7 + int_9 - 82
			}
		};
		int_24 = new int[2];
		int_23 = 0;
		int_10 = int_6 + 73;
		int_11 = int_7 + int_9 / 2 + 5;
		int_17 = int_7 + int_9 - 22;
		int_18 = new int[3]
		{
			int_6 + int_8 / 2 - 8 - 80,
			int_6 + int_8 / 2 - 8,
			int_6 + int_8 / 2 - 8 + 80
		};
		int_19 = new int[3];
		int_34 = int_13 + 10 + 70;
		int_35 = 0;
		gclass63_0 = new GClass63();
		gclass63_1 = new GClass63();
		int_25 = 1;
		int_26 = 2;
	}

	public static GClass146 smethod_2()
	{
		if (gclass146_0 == null)
			gclass146_0 = new GClass146();
		return gclass146_0;
	}

	public void method_0(GClass63 list, int num, int numMax)
	{
		gclass63_0 = list;
		smethod_3(num, numMax);
		int_25 = 1;
		int_27 = 2;
		method_1();
		bool_0 = true;
		smethod_4();
		if (bool_0)
			int_26 = list.method_2() / 5 + ((list.method_2() % 5 > 0) ? 1 : 0);
		else
			int_26 = gclass63_1.method_2() / 5 + ((gclass63_1.method_2() % 5 > 0) ? 1 : 0);
	}

	public static void smethod_3(int num, int numMax)
	{
		int_28 = num;
		int_29 = numMax;
	}

	public static void smethod_4()
	{
		gclass63_1 = new GClass63(string.Empty);
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass97 gClass = (GClass97)gclass63_0.method_3(i);
			if (gClass != null && gClass.sbyte_7 == 1)
				gclass63_1.method_0(gClass);
		}
	}

	public void method_1()
	{
		GClass63 gClass = gclass63_1;
		if (bool_0)
			gClass = gclass63_0;
		int num = (int_25 - 1) * 5;
		int num2 = num + 5;
		for (int i = num; i < num2; i++)
		{
			if (i >= gClass.method_2())
			{
				int_22[i - num] = -1;
				continue;
			}
			GClass97 gClass2 = (GClass97)gClass.method_3(i);
			if (gClass2 != null)
				int_22[i - num] = gClass2.int_0;
		}
		int_15 = 0;
		int_16 = 0;
		GClass29.smethod_1().method_55();
	}

	public override void update()
	{
		try
		{
			if (int_16 < 80)
			{
				int_16 += 4;
				if (int_16 > 80)
					int_16 = 80;
			}
			gclass97_0 = GClass97.smethod_1(gclass63_1, int_22[int_27]);
			if (bool_0)
				gclass97_0 = GClass97.smethod_1(gclass63_0, int_22[int_27]);
			GClass154.smethod_8().update();
			if (GClass39.int_8 % 10 < 6)
			{
				if (GClass39.int_8 % 2 == 0)
					int_23--;
			}
			else
				int_23 = 0;
			if (gclass97_0 != null)
			{
				int_35 = gclass97_0.sbyte_3 * 100 / gclass97_0.sbyte_4 * gclass2_11.method_1() / 100;
				int_33 = int_28 * 100 / gclass63_0.method_2() * gclass2_13.method_0() / 100;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("-upd-radaScr-null: " + ex.ToString());
		}
	}

	public override void updateKey()
	{
		if (!GClass57.bool_1)
		{
			if (GClass39.bool_5 && !GClass7.smethod_0().bool_0 && !GClass39.gclass0_0.bool_0)
				method_3();
			if (GClass39.bool_11[(!Main.isPC) ? 8 : 22])
			{
				GClass39.bool_11[(!Main.isPC) ? 8 : 22] = false;
				brDryiitn3(1);
			}
			if (GClass39.bool_11[(!Main.isPC) ? 2 : 21])
			{
				GClass39.bool_11[(!Main.isPC) ? 2 : 21] = false;
				brDryiitn3(-1);
			}
			if (GClass39.bool_11[(!Main.isPC) ? 4 : 23])
			{
				GClass39.bool_11[(!Main.isPC) ? 4 : 23] = false;
				method_7(1);
			}
			if (GClass39.bool_11[(!Main.isPC) ? 6 : 24])
			{
				GClass39.bool_11[(!Main.isPC) ? 6 : 24] = false;
				method_7(0);
			}
			if (GClass39.bool_11[(!Main.isPC) ? 5 : 25])
			{
				GClass39.bool_11[(!Main.isPC) ? 5 : 25] = false;
				method_4(1);
			}
			if (GClass39.bool_11[13])
				method_4(2);
			if (GClass39.bool_11[12])
			{
				GClass39.bool_11[12] = false;
				method_4(0);
			}
			GClass39.smethod_26();
		}
	}

	private void method_2()
	{
		bool_0 = !bool_0;
		int_25 = 1;
		int_27 = 0;
		if (bool_0)
			int_26 = gclass63_0.method_2() / 5 + ((gclass63_0.method_2() % 5 > 0) ? 1 : 0);
		else
			int_26 = gclass63_1.method_2() / 5 + ((gclass63_1.method_2() % 5 > 0) ? 1 : 0);
		method_1();
	}

	private void method_3()
	{
		if (GClass39.bool_15)
		{
			for (int i = 0; i < 5; i++)
			{
				if (GClass39.smethod_24(int_21[i][0], int_21[i][1], 30, 30) && GClass39.bool_15 && GClass39.bool_16 && i != int_27)
					method_6(i);
			}
			if (GClass39.smethod_24(int_20[0][0] - 5, int_20[0][1] - 5, 20, 20))
			{
				if (GClass39.bool_14)
					int_24[0] = 1;
				if (GClass39.bool_15 && GClass39.bool_16)
				{
					method_5(0);
					int_24[0] = 0;
				}
			}
			if (GClass39.smethod_24(int_20[2][0] - 5, int_20[2][1] - 5, 20, 20))
			{
				if (GClass39.bool_14)
					int_24[1] = 1;
				if (GClass39.bool_15 && GClass39.bool_16)
				{
					method_5(1);
					int_24[1] = 0;
				}
			}
			for (int j = 0; j < int_18.Length; j++)
			{
				if (GClass39.smethod_24(int_18[j] - 5, int_17 - 5, 20, 20))
				{
					if (GClass39.bool_14)
						int_19[j] = 1;
					if (GClass39.bool_15 && GClass39.bool_16)
					{
						method_4(j);
						int_19[j] = 0;
					}
				}
			}
		}
		else
		{
			int_19[0] = 0;
			int_19[1] = 0;
			int_19[2] = 0;
			int_24[0] = 0;
			int_24[1] = 0;
		}
		if (!GClass39.smethod_24(int_12, 0, int_14, int_13 + int_16))
			return;
		if (GClass39.bool_17)
		{
			if (int_31 == 0)
				int_31 = GClass39.int_1;
			int_30 = int_31 - GClass39.int_1;
			if (int_30 != 0)
			{
				int_15 += int_30;
				int_31 = GClass39.int_1;
			}
			if (int_15 < 0)
				int_15 = 0;
			if (int_15 > gclass97_0.gclass70_0.int_8)
				int_15 = gclass97_0.gclass70_0.int_8;
		}
		else
		{
			int_31 = 0;
			int_31 = 0;
		}
	}

	private void method_4(int int_36)
	{
		switch (int_36)
		{
		case 0:
			method_2();
			break;
		case 1:
			if (gclass97_0 != null)
				GClass166.smethod_0().method_146(1, gclass97_0.int_0);
			break;
		case 2:
			GClass154.smethod_8().switchToMe();
			break;
		}
		GClass29.smethod_1().method_54();
	}

	private void method_5(int int_36)
	{
		if (bool_0)
			int_26 = gclass63_0.method_2() / 5 + ((gclass63_0.method_2() % 5 > 0) ? 1 : 0);
		else
			int_26 = gclass63_1.method_2() / 5 + ((gclass63_1.method_2() % 5 > 0) ? 1 : 0);
		int num = int_25;
		if (int_36 == 0)
		{
			if (int_25 == 1)
				return;
			num--;
			if (num < 1)
				num = 1;
		}
		else
		{
			if (int_25 == int_26)
				return;
			num++;
			if (num > int_26)
				num = int_26;
		}
		if (num != int_25)
		{
			int_25 = num;
			method_1();
		}
	}

	private void method_6(int int_36)
	{
		int_27 = int_36;
		method_1();
	}

	private void brDryiitn3(int int_36)
	{
		int_15 += 12 * int_36;
		if (int_15 < 0)
			int_15 = 0;
		if (int_15 > gclass97_0.gclass70_0.int_8)
			int_15 = gclass97_0.gclass70_0.int_8;
	}

	private void method_7(int int_36)
	{
		int num = int_27;
		int num2 = int_25;
		num = ((int_36 != 0) ? (num - 1) : (num + 1));
		if (num >= int_22.Length)
		{
			if (int_25 < int_26)
			{
				num = 0;
				num2++;
			}
			else
				num = int_22.Length - 1;
		}
		if (num < 0)
		{
			if (int_25 > 1)
			{
				num = int_22.Length - 1;
				num2--;
			}
			else
				num = 0;
		}
		if (num != int_27)
		{
			int_27 = num;
			int_15 = 0;
			int_16 = 0;
		}
		if (num2 != int_25)
		{
			int_25 = num2;
			method_1();
		}
	}

	public override void paint(GClass76 g)
	{
		try
		{
			GClass154.smethod_8().paint(g);
			g.method_1(-GClass154.int_22, -GClass154.int_23);
			g.method_1(0, GClass39.int_58);
			GClass154.smethod_18(g);
			g.method_31(gclass2_0, int_6, int_7, 0);
			g.method_31(gclass2_12, int_6 + int_8 / 2 - gclass2_12.method_0() / 2, int_7 - gclass2_12.method_1() / 2 - 2, 0);
			g.method_5(int_6 + int_8 / 2 - gclass2_12.method_0() / 2 + 13, int_7 - gclass2_12.method_1() / 2 + 3, int_33, gclass2_12.method_1());
			g.method_31(gclass2_13, int_6 + int_8 / 2 - gclass2_12.method_0() / 2 + 13, int_7 - gclass2_12.method_1() / 2 + 3, 0);
			GClass154.smethod_18(g);
			g.method_31(gclass2_9, int_18[0], int_17 + int_19[0], 0);
			g.method_31(gclass2_6, int_18[1], int_17 + int_19[1], 0);
			g.method_31(gclass2_8, int_18[2], int_17 + int_19[2], 0);
			if (bool_0)
				g.method_23(gclass2_7, 0, 0, 17, 17, 0, int_18[1], int_17 + int_19[1], 0);
			else
				g.method_23(gclass2_7, 0, 0, 17, 17, 1, int_18[1], int_17 + int_19[1], 0);
			if (gclass97_0 != null)
			{
				g.method_5(int_6 + 30, int_7 + 13, int_8 - 60, int_9 / 2);
				gclass97_0.method_4(g, int_10, int_11);
				GClass154.smethod_18(g);
				GClass49.gclass49_4.method_6(g, ((gclass97_0.sbyte_6 <= 0) ? " " : ("Lv." + gclass97_0.sbyte_6 + " ")) + gclass97_0.string_0, int_6 + int_8 / 2, int_7 + 15, 2);
				GClass49.gclass49_20.method_6(g, "no." + gclass97_0.int_1, int_6 + 30, int_13 - 2, 0);
				g.method_31(gclass2_10, int_6 + 36, int_13 + 10, 0);
				g.method_5(int_6 + 36, int_34 - int_35, 7, int_35);
				g.method_31(gclass2_11, int_6 + 36, int_13 + 10, 0);
				GClass154.smethod_18(g);
				g.method_31(gclass2_14[gclass97_0.sbyte_2], int_6 + 39 - 5 + 14, int_13 + 12, 0);
			}
			g.method_5(int_12, int_13, int_14 + 5, int_16 + 8);
			if (gclass97_0 != null)
				g.method_31(gclass2_1, int_12, int_13, 0);
			GClass154.smethod_18(g);
			g.method_5(int_12, int_13 + 1, int_14, int_16 + 5);
			if (gclass97_0 != null && gclass97_0.gclass70_0 != null)
			{
				if (gclass97_0.gclass70_0.string_0 == null)
					return;
				gclass97_0.gclass70_0.method_0(g, int_15);
			}
			GClass154.smethod_18(g);
			if ((!bool_0 && gclass63_1.method_2() > 5) || bool_0)
			{
				if (int_25 > 1)
					g.method_31(gclass2_2, int_20[0][0], int_20[0][1] + int_24[0], 0);
				if (int_25 < int_26)
					g.method_31(gclass2_3, int_20[2][0], int_20[2][1] + int_24[1], 0);
			}
			for (int i = 0; i < int_22.Length; i++)
			{
				int num = 0;
				int num2 = 0;
				int idx = 0;
				if (i == int_27)
				{
					num = int_23;
					num2 = -10;
					idx = 1;
					g.method_31(gclass2_4, int_21[i][0] + 10, int_21[i][1] + int_23 + 29 + -10, 0);
				}
				GClass97 gClass = GClass97.smethod_1(gclass63_1, int_22[i]);
				if (bool_0)
					gClass = GClass97.smethod_1(gclass63_0, int_22[i]);
				if (gClass != null)
				{
					gclass125_0.method_0(gClass.sbyte_2, int_21[i][0], int_21[i][1] + num + num2, 0, 0, g);
					GClass96.smethod_6(g, gClass.int_2, int_21[i][0] + 14, int_21[i][1] + 14 + num + num2, 0, GClass169.int_6);
					gClass.method_8(g, int_21[i][0], int_21[i][1] + num + num2);
					if (gClass.sbyte_6 == 0)
						g.method_31(gclass2_5, int_21[i][0], int_21[i][1] + num + num2, 0);
					if (i == int_27)
						gclass125_0.method_0(7, int_21[i][0], int_21[i][1] + num + num2, 0, 0, g);
					if (gClass.sbyte_7 == 1)
						gclass125_0.method_0(8, int_21[i][0], int_21[i][1] + num + num2, 0, 0, g);
				}
				else
					gclass125_1.method_0(idx, int_21[i][0] - 1, int_21[i][1] - 1 + num + num2, 0, 0, g);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("-pnt-radaScr-null: " + ex.ToString());
		}
	}

	public override void switchToMe()
	{
		GClass154.bool_1 = true;
		base.switchToMe();
	}
}
