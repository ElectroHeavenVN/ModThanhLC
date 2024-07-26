using System;

public class GClass140 : GClass131, GInterface6
{
	public static GClass140 gclass140_0;

	private GClass45 gclass45_0;

	public static bool bool_0 = false;

	public static GClass191 gclass191_0;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public static int[][] int_9 = new int[3][]
	{
		new int[3] { 64, 30, 31 },
		new int[3] { 9, 29, 32 },
		new int[3] { 6, 27, 28 }
	};

	public static int[] int_10 = new int[3] { 2, 13, 8 };

	public static int[] int_11 = new int[3] { 1, 12, 7 };

	private int int_12;

	private int int_13;

	private int[] int_14 = new int[3] { 0, 4, 8 };

	public int int_15;

	private int int_16;

	private int int_17 = 168;

	private int int_18 = 350;

	private int int_19 = 45;

	private int int_20;

	private int int_21;

	public GClass140()
	{
		try
		{
			if (!GClass73.bool_1)
				smethod_4(new sbyte[3] { 39, 40, 41 });
			method_0(new sbyte[3] { 39, 40, 41 });
		}
		catch (Exception ex)
		{
			GClass36.smethod_2("Tao char loi " + ex.ToString());
		}
		if (GClass73.int_10 <= 200)
		{
			GClass144.smethod_25(128, 100);
			GClass144.int_180 = (GClass73.int_10 - 128) / 2;
			GClass144.int_179 = 10;
			int_18 += 15;
			int_19 -= 15;
		}
		int_6 = 1;
		gclass191_0 = new GClass191();
		gclass191_0.int_2 = GClass73.gclass133_0.gclass191_0.int_2;
		if (GClass73.int_10 < 200)
			gclass191_0.int_2 = 60;
		gclass191_0.int_3 = GClass131.int_0 + 2;
		if (GClass73.int_10 < 200)
		{
			gclass191_0.int_0 = GClass144.int_180 + 45;
			gclass191_0.int_1 = GClass144.int_179 + 12;
		}
		else
		{
			gclass191_0.int_0 = GClass73.int_10 / 2 - gclass191_0.int_2 / 2;
			gclass191_0.int_1 = 35;
		}
		if (!GClass73.bool_5)
			gclass191_0.bool_0 = true;
		gclass191_0.method_28(GClass191.int_11);
		gclass191_0.bool_8 = false;
		gclass191_0.string_9 = mResources.char_name;
		if (gclass191_0.method_21().Equals("@"))
			gclass191_0.method_23(GClass73.gclass133_0.gclass191_0.method_21().Substring(0, GClass73.gclass133_0.gclass191_0.method_21().IndexOf("@")));
		gclass191_0.string_7 = mResources.char_name;
		int_6 = 1;
		int_7 = 0;
		gclass87_1 = new GClass87(mResources.NEWCHAR, this, 8000, null);
		gclass87_0 = new GClass87(mResources.BACK, this, 8001, null);
		if (!GClass73.bool_5)
			gclass87_2 = gclass191_0.gclass87_0;
		int_15 = gclass191_0.int_1;
	}

	public static GClass140 smethod_2()
	{
		if (gclass140_0 == null)
			gclass140_0 = new GClass140();
		return gclass140_0;
	}

	public static void smethod_3()
	{
	}

	public static void smethod_4(sbyte[] mapID)
	{
		GClass50.smethod_8("newwwwwwwwww =============");
		GClass108 gClass = null;
		for (int i = 0; i < mapID.Length; i++)
		{
			gClass = GClass200.smethod_0("/mymap/" + mapID[i]);
			GClass71.int_0[i] = (ushort)gClass.method_2();
			GClass71.int_1[i] = (ushort)gClass.method_2();
			GClass36.smethod_2("Thong TIn : " + GClass71.int_0[i] + "::" + GClass71.int_1[i]);
			GClass71.int_5[i] = new int[gClass.method_13()];
			GClass36.smethod_2("lent= " + GClass71.int_5[i].Length);
			for (int j = 0; j < GClass71.int_0[i] * GClass71.int_1[i]; j++)
			{
				GClass71.int_5[i][j] = gClass.method_2();
			}
			GClass71.int_6[i] = new int[GClass71.int_5[i].Length];
		}
	}

	public void method_0(sbyte[] mapID)
	{
		if (GClass73.bool_1)
			return;
		GClass108 gClass = null;
		try
		{
			for (int i = 0; i < mapID.Length; i++)
			{
				gClass = GClass200.smethod_0("/mymap/mapTable" + mapID[i]);
				GClass36.smethod_2("mapTable : " + mapID[i]);
				short num = gClass.method_0();
				GClass71.gclass88_0[i] = new GClass88();
				GClass50.smethod_8("nItem= " + num);
				for (int j = 0; j < num; j++)
				{
					short id = gClass.method_0();
					short num2 = gClass.method_0();
					short num3 = gClass.method_0();
					if (GClass20.smethod_4(id) == null)
					{
						GClass50.smethod_8("item null");
						continue;
					}
					GClass10 gClass2 = GClass20.smethod_4(id);
					GClass10 gClass3 = new GClass10();
					gClass3.int_0 = id;
					gClass3.short_0 = gClass2.short_0;
					gClass3.int_4 = gClass2.int_4;
					gClass3.int_5 = gClass2.int_5;
					gClass3.int_2 = num2 * GClass20.sbyte_0;
					gClass3.int_3 = num3 * GClass20.sbyte_0;
					gClass3.sbyte_0 = gClass2.sbyte_0;
					GClass71.gclass88_0[i].method_0(gClass3);
					if (!GClass10.gclass113_0.method_7(gClass3.short_0 + ""))
					{
						try
						{
							GClass70 gClass4 = GClass73.smethod_43("/mapBackGround/" + gClass3.short_0 + ".png");
							if (gClass4 != null)
								GClass10.gclass113_0.method_4(gClass3.short_0 + "", gClass4);
							else
							{
								GClass10.gclass113_0.method_4(gClass3.short_0 + "", GClass70.smethod_9(new int[1], 1, 1, true));
								GClass7.smethod_0().method_113(gClass3.short_0);
							}
						}
						catch (Exception)
						{
							GClass70 gClass5 = GClass73.smethod_43("/mapBackGround/" + gClass3.short_0 + ".png");
							if (gClass5 == null)
							{
								gClass5 = GClass70.smethod_9(new int[1], 1, 1, true);
								GClass7.smethod_0().method_113(gClass3.short_0);
							}
							GClass10.gclass113_0.method_4(gClass3.short_0 + "", gClass5);
						}
						GClass10.gclass88_1.method_0(gClass3.short_0 + "");
					}
					if (!GClass10.smethod_1(gClass3.short_0 + ""))
						GClass10.gclass88_0.method_0(gClass3.short_0 + "");
					gClass3.method_2();
				}
			}
		}
		catch (Exception ex2)
		{
			GClass36.smethod_0("LOI TAI loadMapTableFromResource" + ex2.ToString());
		}
	}

	public override void switchToMe()
	{
		GClass133.bool_0 = false;
		GClass73.gclass145_0.bool_0 = false;
		GClass73.smethod_29();
		base.switchToMe();
		int_6 = GClass50.smethod_19(0, 3);
		int_7 = GClass50.smethod_19(0, 3);
		method_1();
		GClass78.bool_35 = false;
		gclass191_0.method_20(true);
		GClass134.int_11 = 0;
	}

	public void method_1()
	{
		GClass20.int_27 = new int[GClass71.int_5[int_6].Length];
		for (int i = 0; i < GClass71.int_5[int_6].Length; i++)
		{
			GClass20.int_27[i] = GClass71.int_5[int_6][i];
		}
		GClass20.int_28 = GClass71.int_6[int_6];
		GClass20.int_24 = GClass71.int_3[int_6];
		GClass20.int_23 = GClass71.int_2[int_6];
		GClass20.int_25 = GClass71.int_2[int_6];
		GClass20.int_21 = GClass71.int_0[int_6];
		GClass20.int_22 = GClass71.int_1[int_6];
		GClass20.int_25 = int_14[int_6] + 1;
		GClass20.smethod_34();
		GClass20.smethod_9();
		GClass73.smethod_21(int_14[int_6]);
		GClass144.smethod_10(false, int_17, int_18);
	}

	public override void keyPress(int keyCode)
	{
		gclass191_0.method_10(keyCode);
	}

	public override void update()
	{
		int_20++;
		if (int_20 > 30)
			int_20 = 0;
		if (int_20 % 15 >= 5)
			int_21 = 1;
		else
			int_21 = 0;
		gclass191_0.method_17();
		if (int_8 != 0)
			gclass191_0.bool_0 = false;
	}

	public override void updateKey()
	{
		if (GClass73.bool_11[(!Main.isPC) ? 2 : 21])
		{
			int_8--;
			if (int_8 < 0)
				int_8 = mResources.MENUNEWCHAR.Length - 1;
		}
		if (GClass73.bool_11[Main.isPC ? 22 : 8])
		{
			int_8++;
			if (int_8 >= mResources.MENUNEWCHAR.Length)
				int_8 = 0;
		}
		if (int_8 == 0)
		{
			if (!GClass73.bool_5)
				gclass87_2 = gclass191_0.gclass87_0;
			gclass191_0.method_17();
		}
		if (int_8 == 1)
		{
			if (GClass73.bool_11[Main.isPC ? 23 : 4])
			{
				int_6--;
				if (int_6 < 0)
					int_6 = mResources.MENUGENDER.Length - 1;
				method_1();
			}
			if (GClass73.bool_11[Main.isPC ? 24 : 6])
			{
				int_6++;
				if (int_6 > mResources.MENUGENDER.Length - 1)
					int_6 = 0;
				method_1();
			}
			gclass87_2 = null;
		}
		if (int_8 == 2)
		{
			if (GClass73.bool_11[(!Main.isPC) ? 4 : 23])
			{
				int_7--;
				if (int_7 < 0)
					int_7 = mResources.hairStyleName[0].Length - 1;
			}
			if (GClass73.bool_11[Main.isPC ? 24 : 6])
			{
				int_7++;
				if (int_7 > mResources.hairStyleName[0].Length - 1)
					int_7 = 0;
			}
			gclass87_2 = null;
		}
		if (GClass73.bool_16)
		{
			int num = 110;
			int num2 = 60;
			int num3 = 78;
			if (GClass73.int_10 > GClass73.int_11)
			{
				num = 100;
				num2 = 40;
			}
			if (GClass73.smethod_24(GClass73.int_10 / 2 - 3 * num3 / 2, 15, num3 * 3, 80))
			{
				int_8 = 0;
				gclass191_0.bool_0 = true;
			}
			if (GClass73.smethod_24(GClass73.int_10 / 2 - 3 * num3 / 2, num - 30, num3 * 3, num2 + 5))
			{
				int_8 = 1;
				int num4 = int_6;
				int_6 = (GClass73.int_0 - (GClass73.int_10 / 2 - 3 * num3 / 2)) / num3;
				if (int_6 < 0)
					int_6 = 0;
				if (int_6 > mResources.MENUGENDER.Length - 1)
					int_6 = mResources.MENUGENDER.Length - 1;
				if (num4 != int_6)
					method_1();
			}
			if (GClass73.smethod_24(GClass73.int_10 / 2 - 3 * num3 / 2, num - 30 + num2 + 5, num3 * 3, 65))
			{
				int_8 = 2;
				int num5 = int_7;
				int_7 = (GClass73.int_0 - (GClass73.int_10 / 2 - 3 * num3 / 2)) / num3;
				if (int_7 < 0)
					int_7 = 0;
				if (int_7 > mResources.hairStyleName[0].Length - 1)
					int_7 = mResources.hairStyleName[0].Length - 1;
				if (num5 != int_8)
					method_1();
			}
		}
		if (!GClass60.bool_1)
			base.updateKey();
		GClass73.smethod_27();
		GClass73.smethod_26();
	}

	public override void paint(GClass122 g)
	{
		if (GClass78.bool_35)
			return;
		GClass73.smethod_18(g);
		g.method_1(-GClass144.int_22, -GClass144.int_23);
		if (!GClass73.bool_1)
		{
			for (int i = 0; i < GClass71.gclass88_0[int_6].method_2(); i++)
			{
				GClass10 gClass = (GClass10)GClass71.gclass88_0[int_6].method_3(i);
				if (gClass.short_0 != -1 && gClass.sbyte_0 == 1)
					gClass.method_3(g);
			}
		}
		GClass20.smethod_20(g);
		int num = 30;
		if (GClass73.int_10 == 128)
			num = 20;
		int num2 = int_9[int_6][int_7];
		int num3 = int_10[int_6];
		int num4 = int_11[int_6];
		g.method_31(GClass20.gclass70_10, int_17, int_18 + int_19, 3);
		GClass116 gClass2 = GClass144.gclass116_0[num2];
		GClass116 gClass3 = GClass144.gclass116_0[num3];
		GClass116 gClass4 = GClass144.gclass116_0[num4];
		GClass28.smethod_6(g, gClass2.gclass66_0[GClass78.int_94[int_21][0][0]].short_0, int_17 + GClass78.int_94[int_21][0][1] + gClass2.gclass66_0[GClass78.int_94[int_21][0][0]].sbyte_0, int_18 - GClass78.int_94[int_21][0][2] + gClass2.gclass66_0[GClass78.int_94[int_21][0][0]].sbyte_1 + int_19, 0, 0);
		GClass28.smethod_6(g, gClass3.gclass66_0[GClass78.int_94[int_21][1][0]].short_0, int_17 + GClass78.int_94[int_21][1][1] + gClass3.gclass66_0[GClass78.int_94[int_21][1][0]].sbyte_0, int_18 - GClass78.int_94[int_21][1][2] + gClass3.gclass66_0[GClass78.int_94[int_21][1][0]].sbyte_1 + int_19, 0, 0);
		GClass28.smethod_6(g, gClass4.gclass66_0[GClass78.int_94[int_21][2][0]].short_0, int_17 + GClass78.int_94[int_21][2][1] + gClass4.gclass66_0[GClass78.int_94[int_21][2][0]].sbyte_0, int_18 - GClass78.int_94[int_21][2][2] + gClass4.gclass66_0[GClass78.int_94[int_21][2][0]].sbyte_1 + int_19, 0, 0);
		if (!GClass73.bool_1)
		{
			for (int j = 0; j < GClass71.gclass88_0[int_6].method_2(); j++)
			{
				GClass10 gClass5 = (GClass10)GClass71.gclass88_0[int_6].method_3(j);
				if (gClass5.short_0 != -1 && gClass5.sbyte_0 == 3)
					gClass5.method_3(g);
			}
		}
		g.method_1(-g.method_3(), -g.method_4());
		if (GClass73.int_10 < 200)
		{
			GClass73.gclass192_0.method_34(GClass144.int_180, GClass144.int_179, GClass144.int_194, GClass144.int_195, g);
			GClass28.smethod_6(g, gClass2.gclass66_0[GClass78.int_94[0][0][0]].short_0, GClass73.int_10 / 2 + GClass78.int_94[0][0][1] + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_0, GClass144.int_179 + 30 + 3 * num - GClass78.int_94[0][0][2] + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_1 + int_19, 0, 0);
			GClass28.smethod_6(g, gClass3.gclass66_0[GClass78.int_94[0][1][0]].short_0, GClass73.int_10 / 2 + GClass78.int_94[0][1][1] + gClass3.gclass66_0[GClass78.int_94[0][1][0]].sbyte_0, GClass144.int_179 + 30 + 3 * num - GClass78.int_94[0][1][2] + gClass3.gclass66_0[GClass78.int_94[0][1][0]].sbyte_1 + int_19, 0, 0);
			GClass28.smethod_6(g, gClass4.gclass66_0[GClass78.int_94[0][2][0]].short_0, GClass73.int_10 / 2 + GClass78.int_94[0][2][1] + gClass4.gclass66_0[GClass78.int_94[0][2][0]].sbyte_0, GClass144.int_179 + 30 + 3 * num - GClass78.int_94[0][2][2] + gClass4.gclass66_0[GClass78.int_94[0][2][0]].sbyte_1 + int_19, 0, 0);
			for (int k = 0; k < mResources.MENUNEWCHAR.Length; k++)
			{
				if (int_8 == k)
				{
					g.method_23(GClass144.gclass70_45, 0, 0, 13, 16, 2, GClass144.int_180 + 10 + ((GClass73.int_8 % 7 > 3) ? 1 : 0), GClass144.int_179 + 35 + k * num, GClass188.int_6);
					g.method_23(GClass144.gclass70_45, 0, 0, 13, 16, 0, GClass144.int_180 + GClass144.int_194 - 10 - ((GClass73.int_8 % 7 > 3) ? 1 : 0), GClass144.int_179 + 35 + k * num, GClass188.int_6);
				}
				GClass4.gclass4_6.method_6(g, mResources.MENUNEWCHAR[k], GClass144.int_180 + 20, GClass144.int_179 + 30 + k * num, 0);
			}
			GClass4.gclass4_6.method_6(g, mResources.MENUGENDER[int_6], GClass144.int_180 + 70, GClass144.int_179 + 30 + num, GClass4.int_0);
			GClass4.gclass4_6.method_6(g, mResources.hairStyleName[int_6][int_7], GClass144.int_180 + 55, GClass144.int_179 + 30 + 2 * num, GClass4.int_0);
			gclass191_0.method_13(g);
		}
		else
		{
			if (Main.isPC)
			{
				int_12 = 110;
				int_13 = 60;
				if (GClass73.int_10 > GClass73.int_11)
				{
					int_12 = 100;
					int_13 = 45;
				}
				gclass191_0.int_1 = int_15;
			}
			else
			{
				if (GClass122.int_24 == 0)
				{
					int_12 = 110;
					int_13 = 60;
					if (GClass73.int_10 > GClass73.int_11)
					{
						int_12 = 100;
						int_13 = 45;
					}
				}
				else
				{
					int_12 = 110;
					int_13 = 60;
					if (GClass73.int_10 > GClass73.int_11)
					{
						int_12 = GClass144.int_179 + 30 + 3 * num + gClass4.gclass66_0[GClass78.int_94[0][2][0]].sbyte_1 + int_19 - 15;
						int_13 = 35;
					}
				}
				gclass191_0.int_1 = int_12 - gclass191_0.int_3 - int_13 + 5;
			}
			for (int l = 0; l < 3; l++)
			{
				int num5 = 78;
				if (l != int_6)
					g.method_31(GClass144.gclass70_22, GClass73.int_10 / 2 - num5 + l * num5, int_12, 3);
				else
				{
					if (int_8 == 1)
						g.method_23(GClass144.gclass70_45, 0, 0, 13, 16, 4, GClass73.int_10 / 2 - num5 + l * num5, int_12 - 20 + ((GClass73.int_8 % 7 > 3) ? 1 : 0), GClass188.int_6);
					g.method_31(GClass144.gclass70_23, GClass73.int_10 / 2 - num5 + l * num5, int_12, 3);
				}
				GClass4.gclass4_6.method_6(g, mResources.MENUGENDER[l], GClass73.int_10 / 2 - num5 + l * num5, int_12 - 5, GClass4.int_2);
			}
			for (int m = 0; m < 3; m++)
			{
				int num6 = 78;
				if (m != int_7)
					g.method_31(GClass144.gclass70_22, GClass73.int_10 / 2 - num6 + m * num6, int_12 + int_13, 3);
				else
				{
					if (int_8 == 2)
						g.method_23(GClass144.gclass70_45, 0, 0, 13, 16, 4, GClass73.int_10 / 2 - num6 + m * num6, int_12 + int_13 - 20 + ((GClass73.int_8 % 7 > 3) ? 1 : 0), GClass188.int_6);
					g.method_31(GClass144.gclass70_23, GClass73.int_10 / 2 - num6 + m * num6, int_12 + int_13, 3);
				}
				GClass4.gclass4_6.method_6(g, mResources.hairStyleName[int_6][m], GClass73.int_10 / 2 - num6 + m * num6, int_12 + int_13 - 5, GClass4.int_2);
			}
			gclass191_0.method_13(g);
		}
		g.method_5(0, 0, GClass73.int_10, GClass73.int_11);
		GClass4.gclass4_3.method_10(g, mResources.server + " " + GClass133.string_4, 5, 5, 0, GClass4.gclass4_6);
		if (!GClass60.bool_1)
			base.paint(g);
	}

	public void perform(int idAction, object p)
	{
		if (idAction > 8001)
		{
			if (idAction != 10019)
			{
				if (idAction == 10020)
					GClass73.smethod_29();
			}
			else
			{
				GClass14.smethod_0().close();
				GClass73.smethod_29();
				GClass73.gclass134_0.switchToMe();
			}
		}
		else if (idAction != 8000)
		{
			if (idAction != 8001)
				return;
			if (!GClass73.gclass133_0.bool_12)
			{
				if (Main.isWindowsPhone)
					GClass187.bool_1 = true;
				GClass14.smethod_0().close();
				GClass73.gclass134_0.switchToMe();
			}
			else
				GClass73.smethod_36(mResources.note, new GClass87(mResources.YES, this, 10019, null), new GClass87(mResources.NO, this, 10020, null));
		}
		else if (!gclass191_0.method_21().Equals(""))
		{
			if (gclass191_0.method_21().Length < 5)
			{
				GClass73.smethod_30(mResources.char_name_short);
				return;
			}
			if (gclass191_0.method_21().Length > 15)
			{
				GClass73.smethod_30(mResources.char_name_long);
				return;
			}
			GClass130.smethod_1();
			GClass7.smethod_0().method_47(gclass191_0.method_21(), int_6, int_9[int_6][int_7]);
		}
		else
		{
			GClass73.smethod_30(mResources.char_name_blank);
		}
	}
}
