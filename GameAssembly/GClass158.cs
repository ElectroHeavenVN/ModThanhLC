using System;

public class GClass158 : GClass145, GInterface0
{
	public static GClass158 gclass158_0;

	private GClass24 gclass24_0;

	public static bool bool_0 = false;

	public static GClass67 gclass67_0;

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

	public GClass158()
	{
		try
		{
			if (!GClass39.bool_1)
				smethod_4(new sbyte[3] { 39, 40, 41 });
			method_0(new sbyte[3] { 39, 40, 41 });
		}
		catch (Exception ex)
		{
			GClass5.smethod_2("Tao char loi " + ex.ToString());
		}
		if (GClass39.int_10 <= 200)
		{
			GClass154.smethod_25(128, 100);
			GClass154.int_177 = (GClass39.int_10 - 128) / 2;
			GClass154.int_176 = 10;
			int_18 += 15;
			int_19 -= 15;
		}
		int_6 = 1;
		gclass67_0 = new GClass67();
		gclass67_0.int_2 = GClass39.gclass149_0.gclass67_0.int_2;
		if (GClass39.int_10 < 200)
			gclass67_0.int_2 = 60;
		gclass67_0.int_3 = GClass145.int_0 + 2;
		if (GClass39.int_10 < 200)
		{
			gclass67_0.int_0 = GClass154.int_177 + 45;
			gclass67_0.int_1 = GClass154.int_176 + 12;
		}
		else
		{
			gclass67_0.int_0 = GClass39.int_10 / 2 - gclass67_0.int_2 / 2;
			gclass67_0.int_1 = 35;
		}
		if (!GClass39.bool_5)
			gclass67_0.bool_0 = true;
		gclass67_0.method_28(GClass67.int_11);
		gclass67_0.bool_8 = false;
		gclass67_0.string_9 = mResources.char_name;
		if (gclass67_0.method_21().Equals("@"))
			gclass67_0.method_23(GClass39.gclass149_0.gclass67_0.method_21().Substring(0, GClass39.gclass149_0.gclass67_0.method_21().IndexOf("@")));
		gclass67_0.string_7 = mResources.char_name;
		int_6 = 1;
		int_7 = 0;
		gclass14_1 = new GClass14(mResources.NEWCHAR, this, 8000, null);
		gclass14_0 = new GClass14(mResources.BACK, this, 8001, null);
		if (!GClass39.bool_5)
			gclass14_2 = gclass67_0.gclass14_0;
		int_15 = gclass67_0.int_1;
	}

	public static GClass158 smethod_2()
	{
		if (gclass158_0 == null)
			gclass158_0 = new GClass158();
		return gclass158_0;
	}

	public static void smethod_3()
	{
	}

	public static void smethod_4(sbyte[] mapID)
	{
		GClass56.smethod_8("newwwwwwwwww =============");
		GClass11 gClass = null;
		for (int i = 0; i < mapID.Length; i++)
		{
			gClass = GClass208.smethod_0("/mymap/" + mapID[i]);
			GClass80.int_0[i] = (ushort)gClass.method_2();
			GClass80.int_1[i] = (ushort)gClass.method_2();
			GClass5.smethod_2("Thong TIn : " + GClass80.int_0[i] + "::" + GClass80.int_1[i]);
			GClass80.int_5[i] = new int[gClass.method_13()];
			GClass5.smethod_2("lent= " + GClass80.int_5[i].Length);
			for (int j = 0; j < GClass80.int_0[i] * GClass80.int_1[i]; j++)
			{
				GClass80.int_5[i][j] = gClass.method_2();
			}
			GClass80.int_6[i] = new int[GClass80.int_5[i].Length];
		}
	}

	public void method_0(sbyte[] mapID)
	{
		if (GClass39.bool_1)
			return;
		GClass11 gClass = null;
		try
		{
			for (int i = 0; i < mapID.Length; i++)
			{
				gClass = GClass208.smethod_0("/mymap/mapTable" + mapID[i]);
				GClass5.smethod_2("mapTable : " + mapID[i]);
				short num = gClass.method_0();
				GClass80.gclass63_0[i] = new GClass63();
				GClass56.smethod_8("nItem= " + num);
				for (int j = 0; j < num; j++)
				{
					short id = gClass.method_0();
					short num2 = gClass.method_0();
					short num3 = gClass.method_0();
					if (GClass1.smethod_4(id) != null)
					{
						GClass107 gClass2 = GClass1.smethod_4(id);
						GClass107 gClass3 = new GClass107();
						gClass3.int_0 = id;
						gClass3.short_0 = gClass2.short_0;
						gClass3.int_4 = gClass2.int_4;
						gClass3.int_5 = gClass2.int_5;
						gClass3.int_2 = num2 * GClass1.sbyte_0;
						gClass3.int_3 = num3 * GClass1.sbyte_0;
						gClass3.sbyte_0 = gClass2.sbyte_0;
						GClass80.gclass63_0[i].method_0(gClass3);
						if (!GClass107.gclass9_0.method_7(gClass3.short_0 + string.Empty))
						{
							try
							{
								GClass2 gClass4 = GClass39.smethod_43("/mapBackGround/" + gClass3.short_0 + ".png");
								if (gClass4 == null)
								{
									GClass107.gclass9_0.method_4(gClass3.short_0 + string.Empty, GClass2.smethod_9(new int[1], 1, 1, true));
									GClass166.smethod_0().method_113(gClass3.short_0);
								}
								else
									GClass107.gclass9_0.method_4(gClass3.short_0 + string.Empty, gClass4);
							}
							catch (Exception)
							{
								GClass2 gClass5 = GClass39.smethod_43("/mapBackGround/" + gClass3.short_0 + ".png");
								if (gClass5 == null)
								{
									gClass5 = GClass2.smethod_9(new int[1], 1, 1, true);
									GClass166.smethod_0().method_113(gClass3.short_0);
								}
								GClass107.gclass9_0.method_4(gClass3.short_0 + string.Empty, gClass5);
							}
							GClass107.gclass63_1.method_0(gClass3.short_0 + string.Empty);
						}
						if (!GClass107.smethod_1(gClass3.short_0 + string.Empty))
							GClass107.gclass63_0.method_0(gClass3.short_0 + string.Empty);
						gClass3.method_2();
					}
					else
						GClass56.smethod_8("item null");
				}
			}
		}
		catch (Exception ex2)
		{
			GClass5.smethod_0("LOI TAI loadMapTableFromResource" + ex2.ToString());
		}
	}

	public override void switchToMe()
	{
		GClass149.bool_0 = false;
		GClass39.gclass0_0.bool_0 = false;
		GClass39.smethod_29();
		base.switchToMe();
		int_6 = GClass56.smethod_19(0, 3);
		int_7 = GClass56.smethod_19(0, 3);
		method_1();
		GClass58.bool_35 = false;
		gclass67_0.method_20(true);
		GClass152.int_11 = 0;
	}

	public void method_1()
	{
		GClass1.int_27 = new int[GClass80.int_5[int_6].Length];
		for (int i = 0; i < GClass80.int_5[int_6].Length; i++)
		{
			GClass1.int_27[i] = GClass80.int_5[int_6][i];
		}
		GClass1.int_28 = GClass80.int_6[int_6];
		GClass1.int_24 = GClass80.int_3[int_6];
		GClass1.int_23 = GClass80.int_2[int_6];
		GClass1.int_25 = GClass80.int_2[int_6];
		GClass1.int_21 = GClass80.int_0[int_6];
		GClass1.int_22 = GClass80.int_1[int_6];
		GClass1.int_25 = int_14[int_6] + 1;
		GClass1.smethod_33();
		GClass1.smethod_9();
		GClass39.smethod_21(int_14[int_6]);
		GClass154.smethod_10(false, int_17, int_18);
	}

	public override void keyPress(int keyCode)
	{
		gclass67_0.method_10(keyCode);
	}

	public override void update()
	{
		int_20++;
		if (int_20 > 30)
			int_20 = 0;
		if (int_20 % 15 < 5)
			int_21 = 0;
		else
			int_21 = 1;
		gclass67_0.method_17();
		if (int_8 != 0)
			gclass67_0.bool_0 = false;
	}

	public override void updateKey()
	{
		if (GClass39.bool_11[(!Main.isPC) ? 2 : 21])
		{
			int_8--;
			if (int_8 < 0)
				int_8 = mResources.MENUNEWCHAR.Length - 1;
		}
		if (GClass39.bool_11[(!Main.isPC) ? 8 : 22])
		{
			int_8++;
			if (int_8 >= mResources.MENUNEWCHAR.Length)
				int_8 = 0;
		}
		if (int_8 == 0)
		{
			if (!GClass39.bool_5)
				gclass14_2 = gclass67_0.gclass14_0;
			gclass67_0.method_17();
		}
		if (int_8 == 1)
		{
			if (GClass39.bool_11[(!Main.isPC) ? 4 : 23])
			{
				int_6--;
				if (int_6 < 0)
					int_6 = mResources.MENUGENDER.Length - 1;
				method_1();
			}
			if (GClass39.bool_11[(!Main.isPC) ? 6 : 24])
			{
				int_6++;
				if (int_6 > mResources.MENUGENDER.Length - 1)
					int_6 = 0;
				method_1();
			}
			gclass14_2 = null;
		}
		if (int_8 == 2)
		{
			if (GClass39.bool_11[(!Main.isPC) ? 4 : 23])
			{
				int_7--;
				if (int_7 < 0)
					int_7 = mResources.hairStyleName[0].Length - 1;
			}
			if (GClass39.bool_11[(!Main.isPC) ? 6 : 24])
			{
				int_7++;
				if (int_7 > mResources.hairStyleName[0].Length - 1)
					int_7 = 0;
			}
			gclass14_2 = null;
		}
		if (GClass39.bool_16)
		{
			int num = 110;
			int num2 = 60;
			int num3 = 78;
			if (GClass39.int_10 > GClass39.int_11)
			{
				num = 100;
				num2 = 40;
			}
			if (GClass39.smethod_24(GClass39.int_10 / 2 - 3 * num3 / 2, 15, num3 * 3, 80))
			{
				int_8 = 0;
				gclass67_0.bool_0 = true;
			}
			if (GClass39.smethod_24(GClass39.int_10 / 2 - 3 * num3 / 2, num - 30, num3 * 3, num2 + 5))
			{
				int_8 = 1;
				int num4 = int_6;
				int_6 = (GClass39.int_0 - (GClass39.int_10 / 2 - 3 * num3 / 2)) / num3;
				if (int_6 < 0)
					int_6 = 0;
				if (int_6 > mResources.MENUGENDER.Length - 1)
					int_6 = mResources.MENUGENDER.Length - 1;
				if (num4 != int_6)
					method_1();
			}
			if (GClass39.smethod_24(GClass39.int_10 / 2 - 3 * num3 / 2, num - 30 + num2 + 5, num3 * 3, 65))
			{
				int_8 = 2;
				int num5 = int_7;
				int_7 = (GClass39.int_0 - (GClass39.int_10 / 2 - 3 * num3 / 2)) / num3;
				if (int_7 < 0)
					int_7 = 0;
				if (int_7 > mResources.hairStyleName[0].Length - 1)
					int_7 = mResources.hairStyleName[0].Length - 1;
				if (num5 != int_8)
					method_1();
			}
		}
		if (!GClass111.bool_1)
			base.updateKey();
		GClass39.smethod_27();
		GClass39.smethod_26();
	}

	public override void paint(GClass76 g)
	{
		if (GClass58.bool_35)
			return;
		GClass39.smethod_18(g);
		g.method_1(-GClass154.int_22, -GClass154.int_23);
		if (!GClass39.bool_1)
		{
			for (int i = 0; i < GClass80.gclass63_0[int_6].method_2(); i++)
			{
				GClass107 gClass = (GClass107)GClass80.gclass63_0[int_6].method_3(i);
				if (gClass.short_0 != -1 && gClass.sbyte_0 == 1)
					gClass.method_3(g);
			}
		}
		GClass1.smethod_20(g);
		int num = 30;
		if (GClass39.int_10 == 128)
			num = 20;
		int num2 = int_9[int_6][int_7];
		int num3 = int_10[int_6];
		int num4 = int_11[int_6];
		g.method_31(GClass1.gclass2_10, int_17, int_18 + int_19, 3);
		GClass44 gClass2 = GClass154.gclass44_0[num2];
		GClass44 gClass3 = GClass154.gclass44_0[num3];
		GClass44 gClass4 = GClass154.gclass44_0[num4];
		GClass96.smethod_6(g, gClass2.gclass161_0[GClass58.int_94[int_21][0][0]].short_0, int_17 + GClass58.int_94[int_21][0][1] + gClass2.gclass161_0[GClass58.int_94[int_21][0][0]].sbyte_0, int_18 - GClass58.int_94[int_21][0][2] + gClass2.gclass161_0[GClass58.int_94[int_21][0][0]].sbyte_1 + int_19, 0, 0);
		GClass96.smethod_6(g, gClass3.gclass161_0[GClass58.int_94[int_21][1][0]].short_0, int_17 + GClass58.int_94[int_21][1][1] + gClass3.gclass161_0[GClass58.int_94[int_21][1][0]].sbyte_0, int_18 - GClass58.int_94[int_21][1][2] + gClass3.gclass161_0[GClass58.int_94[int_21][1][0]].sbyte_1 + int_19, 0, 0);
		GClass96.smethod_6(g, gClass4.gclass161_0[GClass58.int_94[int_21][2][0]].short_0, int_17 + GClass58.int_94[int_21][2][1] + gClass4.gclass161_0[GClass58.int_94[int_21][2][0]].sbyte_0, int_18 - GClass58.int_94[int_21][2][2] + gClass4.gclass161_0[GClass58.int_94[int_21][2][0]].sbyte_1 + int_19, 0, 0);
		if (!GClass39.bool_1)
		{
			for (int j = 0; j < GClass80.gclass63_0[int_6].method_2(); j++)
			{
				GClass107 gClass5 = (GClass107)GClass80.gclass63_0[int_6].method_3(j);
				if (gClass5.short_0 != -1 && gClass5.sbyte_0 == 3)
					gClass5.method_3(g);
			}
		}
		g.method_1(-g.method_3(), -g.method_4());
		if (GClass39.int_10 < 200)
		{
			GClass39.gclass37_0.method_34(GClass154.int_177, GClass154.int_176, GClass154.int_191, GClass154.int_192, g);
			GClass96.smethod_6(g, gClass2.gclass161_0[GClass58.int_94[0][0][0]].short_0, GClass39.int_10 / 2 + GClass58.int_94[0][0][1] + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_0, GClass154.int_176 + 30 + 3 * num - GClass58.int_94[0][0][2] + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_1 + int_19, 0, 0);
			GClass96.smethod_6(g, gClass3.gclass161_0[GClass58.int_94[0][1][0]].short_0, GClass39.int_10 / 2 + GClass58.int_94[0][1][1] + gClass3.gclass161_0[GClass58.int_94[0][1][0]].sbyte_0, GClass154.int_176 + 30 + 3 * num - GClass58.int_94[0][1][2] + gClass3.gclass161_0[GClass58.int_94[0][1][0]].sbyte_1 + int_19, 0, 0);
			GClass96.smethod_6(g, gClass4.gclass161_0[GClass58.int_94[0][2][0]].short_0, GClass39.int_10 / 2 + GClass58.int_94[0][2][1] + gClass4.gclass161_0[GClass58.int_94[0][2][0]].sbyte_0, GClass154.int_176 + 30 + 3 * num - GClass58.int_94[0][2][2] + gClass4.gclass161_0[GClass58.int_94[0][2][0]].sbyte_1 + int_19, 0, 0);
			for (int k = 0; k < mResources.MENUNEWCHAR.Length; k++)
			{
				if (int_8 == k)
				{
					g.method_23(GClass154.gclass2_45, 0, 0, 13, 16, 2, GClass154.int_177 + 10 + ((GClass39.int_8 % 7 > 3) ? 1 : 0), GClass154.int_176 + 35 + k * num, GClass169.int_6);
					g.method_23(GClass154.gclass2_45, 0, 0, 13, 16, 0, GClass154.int_177 + GClass154.int_191 - 10 - ((GClass39.int_8 % 7 > 3) ? 1 : 0), GClass154.int_176 + 35 + k * num, GClass169.int_6);
				}
				GClass49.gclass49_6.method_6(g, mResources.MENUNEWCHAR[k], GClass154.int_177 + 20, GClass154.int_176 + 30 + k * num, 0);
			}
			GClass49.gclass49_6.method_6(g, mResources.MENUGENDER[int_6], GClass154.int_177 + 70, GClass154.int_176 + 30 + num, GClass49.int_0);
			GClass49.gclass49_6.method_6(g, mResources.hairStyleName[int_6][int_7], GClass154.int_177 + 55, GClass154.int_176 + 30 + 2 * num, GClass49.int_0);
			gclass67_0.method_13(g);
		}
		else
		{
			if (!Main.isPC)
			{
				if (GClass76.int_24 != 0)
				{
					int_12 = 110;
					int_13 = 60;
					if (GClass39.int_10 > GClass39.int_11)
					{
						int_12 = GClass154.int_176 + 30 + 3 * num + gClass4.gclass161_0[GClass58.int_94[0][2][0]].sbyte_1 + int_19 - 15;
						int_13 = 35;
					}
				}
				else
				{
					int_12 = 110;
					int_13 = 60;
					if (GClass39.int_10 > GClass39.int_11)
					{
						int_12 = 100;
						int_13 = 45;
					}
				}
				gclass67_0.int_1 = int_12 - gclass67_0.int_3 - int_13 + 5;
			}
			else
			{
				int_12 = 110;
				int_13 = 60;
				if (GClass39.int_10 > GClass39.int_11)
				{
					int_12 = 100;
					int_13 = 45;
				}
				gclass67_0.int_1 = int_15;
			}
			for (int l = 0; l < 3; l++)
			{
				int num5 = 78;
				if (l != int_6)
					g.method_31(GClass154.gclass2_22, GClass39.int_10 / 2 - num5 + l * num5, int_12, 3);
				else
				{
					if (int_8 == 1)
						g.method_23(GClass154.gclass2_45, 0, 0, 13, 16, 4, GClass39.int_10 / 2 - num5 + l * num5, int_12 - 20 + ((GClass39.int_8 % 7 > 3) ? 1 : 0), GClass169.int_6);
					g.method_31(GClass154.gclass2_23, GClass39.int_10 / 2 - num5 + l * num5, int_12, 3);
				}
				GClass49.gclass49_6.method_6(g, mResources.MENUGENDER[l], GClass39.int_10 / 2 - num5 + l * num5, int_12 - 5, GClass49.int_2);
			}
			for (int m = 0; m < 3; m++)
			{
				int num6 = 78;
				if (m != int_7)
					g.method_31(GClass154.gclass2_22, GClass39.int_10 / 2 - num6 + m * num6, int_12 + int_13, 3);
				else
				{
					if (int_8 == 2)
						g.method_23(GClass154.gclass2_45, 0, 0, 13, 16, 4, GClass39.int_10 / 2 - num6 + m * num6, int_12 + int_13 - 20 + ((GClass39.int_8 % 7 > 3) ? 1 : 0), GClass169.int_6);
					g.method_31(GClass154.gclass2_23, GClass39.int_10 / 2 - num6 + m * num6, int_12 + int_13, 3);
				}
				GClass49.gclass49_6.method_6(g, mResources.hairStyleName[int_6][m], GClass39.int_10 / 2 - num6 + m * num6, int_12 + int_13 - 5, GClass49.int_2);
			}
			gclass67_0.method_13(g);
		}
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		GClass49.gclass49_3.method_10(g, mResources.server + " " + GClass149.string_4, 5, 5, 0, GClass49.gclass49_6);
		if (!GClass111.bool_1)
			base.paint(g);
	}

	public void perform(int idAction, object p)
	{
		if (idAction <= 8001)
		{
			if (idAction != 8000)
			{
				if (idAction != 8001)
					return;
				if (GClass39.gclass149_0.bool_12)
				{
					GClass39.smethod_36(mResources.note, new GClass14(mResources.YES, this, 10019, null), new GClass14(mResources.NO, this, 10020, null));
					return;
				}
				if (Main.isWindowsPhone)
					GClass113.bool_1 = true;
				GClass162.smethod_0().close();
				GClass39.gclass152_0.switchToMe();
			}
			else if (gclass67_0.method_21().Equals(string.Empty))
			{
				GClass39.smethod_30(mResources.char_name_blank);
			}
			else if (gclass67_0.method_21().Length < 5)
			{
				GClass39.smethod_30(mResources.char_name_short);
			}
			else if (gclass67_0.method_21().Length > 15)
			{
				GClass39.smethod_30(mResources.char_name_long);
			}
			else
			{
				GClass57.smethod_1();
				GClass166.smethod_0().method_47(gclass67_0.method_21(), int_6, int_9[int_6][int_7]);
			}
		}
		else if (idAction != 10019)
		{
			if (idAction == 10020)
				GClass39.smethod_29();
		}
		else
		{
			GClass162.smethod_0().close();
			GClass39.smethod_29();
			GClass39.gclass152_0.switchToMe();
		}
	}
}
