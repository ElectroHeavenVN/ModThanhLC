using System;

public class GClass163 : GClass160, GInterface1
{
	public static GClass163 gclass163_0;

	private GClass139 gclass139_0;

	public static bool bool_0 = false;

	public static GClass136 gclass136_0;

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

	public GClass163()
	{
		try
		{
			if (!GClass14.bool_1)
				smethod_4(new sbyte[3] { 39, 40, 41 });
			method_0(new sbyte[3] { 39, 40, 41 });
		}
		catch (Exception ex)
		{
			GClass92.smethod_2("Tao char loi " + ex.ToString());
		}
		if (GClass14.int_10 <= 200)
		{
			GClass167.smethod_25(128, 100);
			GClass167.int_180 = (GClass14.int_10 - 128) / 2;
			GClass167.int_179 = 10;
			int_18 += 15;
			int_19 -= 15;
		}
		int_6 = 1;
		gclass136_0 = new GClass136();
		gclass136_0.int_2 = GClass14.gclass173_0.gclass136_0.int_2;
		if (GClass14.int_10 < 200)
			gclass136_0.int_2 = 60;
		gclass136_0.int_3 = GClass160.int_0 + 2;
		if (GClass14.int_10 < 200)
		{
			gclass136_0.int_0 = GClass167.int_180 + 45;
			gclass136_0.int_1 = GClass167.int_179 + 12;
		}
		else
		{
			gclass136_0.int_0 = GClass14.int_10 / 2 - gclass136_0.int_2 / 2;
			gclass136_0.int_1 = 35;
		}
		if (!GClass14.bool_5)
			gclass136_0.bool_0 = true;
		gclass136_0.method_28(GClass136.int_11);
		gclass136_0.bool_8 = false;
		gclass136_0.string_9 = mResources.char_name;
		if (gclass136_0.method_21().Equals("@"))
			gclass136_0.method_23(GClass14.gclass173_0.gclass136_0.method_21().Substring(0, GClass14.gclass173_0.gclass136_0.method_21().IndexOf("@")));
		gclass136_0.string_7 = mResources.char_name;
		int_6 = 1;
		int_7 = 0;
		gclass118_1 = new GClass118(mResources.NEWCHAR, this, 8000, null);
		gclass118_0 = new GClass118(mResources.BACK, this, 8001, null);
		if (!GClass14.bool_5)
			gclass118_2 = gclass136_0.gclass118_0;
		int_15 = gclass136_0.int_1;
	}

	public static GClass163 smethod_2()
	{
		if (gclass163_0 == null)
			gclass163_0 = new GClass163();
		return gclass163_0;
	}

	public static void smethod_3()
	{
	}

	public static void smethod_4(sbyte[] mapID)
	{
		GClass191.smethod_8("newwwwwwwwww =============");
		GClass188 gClass = null;
		for (int i = 0; i < mapID.Length; i++)
		{
			gClass = GClass79.smethod_0("/mymap/" + mapID[i]);
			GClass177.int_0[i] = (ushort)gClass.method_2();
			GClass177.int_1[i] = (ushort)gClass.method_2();
			GClass92.smethod_2("Thong TIn : " + GClass177.int_0[i] + "::" + GClass177.int_1[i]);
			GClass177.int_5[i] = new int[gClass.method_13()];
			GClass92.smethod_2("lent= " + GClass177.int_5[i].Length);
			for (int j = 0; j < GClass177.int_0[i] * GClass177.int_1[i]; j++)
			{
				GClass177.int_5[i][j] = gClass.method_2();
			}
			GClass177.int_6[i] = new int[GClass177.int_5[i].Length];
		}
	}

	public void method_0(sbyte[] mapID)
	{
		if (GClass14.bool_1)
			return;
		GClass188 gClass = null;
		try
		{
			for (int i = 0; i < mapID.Length; i++)
			{
				gClass = GClass79.smethod_0("/mymap/mapTable" + mapID[i]);
				GClass92.smethod_2("mapTable : " + mapID[i]);
				short num = gClass.method_0();
				GClass177.gclass122_0[i] = new GClass122();
				GClass191.smethod_8("nItem= " + num);
				for (int j = 0; j < num; j++)
				{
					short id = gClass.method_0();
					short num2 = gClass.method_0();
					short num3 = gClass.method_0();
					if (GClass137.smethod_4(id) == null)
					{
						GClass191.smethod_8("item null");
						continue;
					}
					GClass201 gClass2 = GClass137.smethod_4(id);
					GClass201 gClass3 = new GClass201();
					gClass3.int_0 = id;
					gClass3.short_0 = gClass2.short_0;
					gClass3.int_4 = gClass2.int_4;
					gClass3.int_5 = gClass2.int_5;
					gClass3.int_2 = num2 * GClass137.sbyte_0;
					gClass3.int_3 = num3 * GClass137.sbyte_0;
					gClass3.sbyte_0 = gClass2.sbyte_0;
					GClass177.gclass122_0[i].method_0(gClass3);
					if (!GClass201.gclass175_0.method_7(gClass3.short_0 + string.Empty))
					{
						try
						{
							GClass20 gClass4 = GClass14.smethod_43("/mapBackGround/" + gClass3.short_0 + ".png");
							if (gClass4 != null)
								GClass201.gclass175_0.method_4(gClass3.short_0 + string.Empty, gClass4);
							else
							{
								GClass201.gclass175_0.method_4(gClass3.short_0 + string.Empty, GClass20.smethod_9(new int[1], 1, 1, true));
								GClass2.smethod_0().method_113(gClass3.short_0);
							}
						}
						catch (Exception)
						{
							GClass20 gClass5 = GClass14.smethod_43("/mapBackGround/" + gClass3.short_0 + ".png");
							if (gClass5 == null)
							{
								gClass5 = GClass20.smethod_9(new int[1], 1, 1, true);
								GClass2.smethod_0().method_113(gClass3.short_0);
							}
							GClass201.gclass175_0.method_4(gClass3.short_0 + string.Empty, gClass5);
						}
						GClass201.gclass122_1.method_0(gClass3.short_0 + string.Empty);
					}
					if (!GClass201.smethod_1(gClass3.short_0 + string.Empty))
						GClass201.gclass122_0.method_0(gClass3.short_0 + string.Empty);
					gClass3.method_2();
				}
			}
		}
		catch (Exception ex2)
		{
			GClass92.smethod_0("LOI TAI loadMapTableFromResource" + ex2.ToString());
		}
	}

	public override void switchToMe()
	{
		GClass173.bool_0 = false;
		GClass14.gclass116_0.bool_0 = false;
		GClass14.smethod_29();
		base.switchToMe();
		int_6 = GClass191.smethod_19(0, 3);
		int_7 = GClass191.smethod_19(0, 3);
		method_1();
		GClass124.bool_35 = false;
		gclass136_0.method_20(true);
		GClass170.int_11 = 0;
	}

	public void method_1()
	{
		GClass137.int_27 = new int[GClass177.int_5[int_6].Length];
		for (int i = 0; i < GClass177.int_5[int_6].Length; i++)
		{
			GClass137.int_27[i] = GClass177.int_5[int_6][i];
		}
		GClass137.int_28 = GClass177.int_6[int_6];
		GClass137.int_24 = GClass177.int_3[int_6];
		GClass137.int_23 = GClass177.int_2[int_6];
		GClass137.int_25 = GClass177.int_2[int_6];
		GClass137.int_21 = GClass177.int_0[int_6];
		GClass137.int_22 = GClass177.int_1[int_6];
		GClass137.int_25 = int_14[int_6] + 1;
		GClass137.smethod_34();
		GClass137.smethod_9();
		GClass14.smethod_21(int_14[int_6]);
		GClass167.smethod_10(false, int_17, int_18);
	}

	public override void keyPress(int keyCode)
	{
		gclass136_0.method_10(keyCode);
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
		gclass136_0.method_17();
		if (int_8 != 0)
			gclass136_0.bool_0 = false;
	}

	public override void updateKey()
	{
		if (GClass14.bool_11[Main.isPC ? 21 : 2])
		{
			int_8--;
			if (int_8 < 0)
				int_8 = mResources.MENUNEWCHAR.Length - 1;
		}
		if (GClass14.bool_11[Main.isPC ? 22 : 8])
		{
			int_8++;
			if (int_8 >= mResources.MENUNEWCHAR.Length)
				int_8 = 0;
		}
		if (int_8 == 0)
		{
			if (!GClass14.bool_5)
				gclass118_2 = gclass136_0.gclass118_0;
			gclass136_0.method_17();
		}
		if (int_8 == 1)
		{
			if (GClass14.bool_11[Main.isPC ? 23 : 4])
			{
				int_6--;
				if (int_6 < 0)
					int_6 = mResources.MENUGENDER.Length - 1;
				method_1();
			}
			if (GClass14.bool_11[Main.isPC ? 24 : 6])
			{
				int_6++;
				if (int_6 > mResources.MENUGENDER.Length - 1)
					int_6 = 0;
				method_1();
			}
			gclass118_2 = null;
		}
		if (int_8 == 2)
		{
			if (GClass14.bool_11[(!Main.isPC) ? 4 : 23])
			{
				int_7--;
				if (int_7 < 0)
					int_7 = mResources.hairStyleName[0].Length - 1;
			}
			if (GClass14.bool_11[Main.isPC ? 24 : 6])
			{
				int_7++;
				if (int_7 > mResources.hairStyleName[0].Length - 1)
					int_7 = 0;
			}
			gclass118_2 = null;
		}
		if (GClass14.bool_16)
		{
			int num = 110;
			int num2 = 60;
			int num3 = 78;
			if (GClass14.int_10 > GClass14.int_11)
			{
				num = 100;
				num2 = 40;
			}
			if (GClass14.smethod_24(GClass14.int_10 / 2 - 3 * num3 / 2, 15, num3 * 3, 80))
			{
				int_8 = 0;
				gclass136_0.bool_0 = true;
			}
			if (GClass14.smethod_24(GClass14.int_10 / 2 - 3 * num3 / 2, num - 30, num3 * 3, num2 + 5))
			{
				int_8 = 1;
				int num4 = int_6;
				int_6 = (GClass14.int_0 - (GClass14.int_10 / 2 - 3 * num3 / 2)) / num3;
				if (int_6 < 0)
					int_6 = 0;
				if (int_6 > mResources.MENUGENDER.Length - 1)
					int_6 = mResources.MENUGENDER.Length - 1;
				if (num4 != int_6)
					method_1();
			}
			if (GClass14.smethod_24(GClass14.int_10 / 2 - 3 * num3 / 2, num - 30 + num2 + 5, num3 * 3, 65))
			{
				int_8 = 2;
				int num5 = int_7;
				int_7 = (GClass14.int_0 - (GClass14.int_10 / 2 - 3 * num3 / 2)) / num3;
				if (int_7 < 0)
					int_7 = 0;
				if (int_7 > mResources.hairStyleName[0].Length - 1)
					int_7 = mResources.hairStyleName[0].Length - 1;
				if (num5 != int_8)
					method_1();
			}
		}
		if (!GClass196.bool_1)
			base.updateKey();
		GClass14.smethod_27();
		GClass14.smethod_26();
	}

	public override void paint(GClass193 g)
	{
		if (GClass124.bool_35)
			return;
		GClass14.smethod_18(g);
		g.method_1(-GClass167.int_22, -GClass167.int_23);
		if (!GClass14.bool_1)
		{
			for (int i = 0; i < GClass177.gclass122_0[int_6].method_2(); i++)
			{
				GClass201 gClass = (GClass201)GClass177.gclass122_0[int_6].method_3(i);
				if (gClass.short_0 != -1 && gClass.sbyte_0 == 1)
					gClass.method_3(g);
			}
		}
		GClass137.smethod_20(g);
		int num = 30;
		if (GClass14.int_10 == 128)
			num = 20;
		int num2 = int_9[int_6][int_7];
		int num3 = int_10[int_6];
		int num4 = int_11[int_6];
		g.method_31(GClass137.gclass20_10, int_17, int_18 + int_19, 3);
		GClass29 gClass2 = GClass167.gclass29_0[num2];
		GClass29 gClass3 = GClass167.gclass29_0[num3];
		GClass29 gClass4 = GClass167.gclass29_0[num4];
		GClass72.smethod_6(g, gClass2.gclass21_0[GClass124.int_94[int_21][0][0]].short_0, int_17 + GClass124.int_94[int_21][0][1] + gClass2.gclass21_0[GClass124.int_94[int_21][0][0]].sbyte_0, int_18 - GClass124.int_94[int_21][0][2] + gClass2.gclass21_0[GClass124.int_94[int_21][0][0]].sbyte_1 + int_19, 0, 0);
		GClass72.smethod_6(g, gClass3.gclass21_0[GClass124.int_94[int_21][1][0]].short_0, int_17 + GClass124.int_94[int_21][1][1] + gClass3.gclass21_0[GClass124.int_94[int_21][1][0]].sbyte_0, int_18 - GClass124.int_94[int_21][1][2] + gClass3.gclass21_0[GClass124.int_94[int_21][1][0]].sbyte_1 + int_19, 0, 0);
		GClass72.smethod_6(g, gClass4.gclass21_0[GClass124.int_94[int_21][2][0]].short_0, int_17 + GClass124.int_94[int_21][2][1] + gClass4.gclass21_0[GClass124.int_94[int_21][2][0]].sbyte_0, int_18 - GClass124.int_94[int_21][2][2] + gClass4.gclass21_0[GClass124.int_94[int_21][2][0]].sbyte_1 + int_19, 0, 0);
		if (!GClass14.bool_1)
		{
			for (int j = 0; j < GClass177.gclass122_0[int_6].method_2(); j++)
			{
				GClass201 gClass5 = (GClass201)GClass177.gclass122_0[int_6].method_3(j);
				if (gClass5.short_0 != -1 && gClass5.sbyte_0 == 3)
					gClass5.method_3(g);
			}
		}
		g.method_1(-g.method_3(), -g.method_4());
		if (GClass14.int_10 >= 200)
		{
			if (!Main.isPC)
			{
				if (GClass193.int_24 == 0)
				{
					int_12 = 110;
					int_13 = 60;
					if (GClass14.int_10 > GClass14.int_11)
					{
						int_12 = 100;
						int_13 = 45;
					}
				}
				else
				{
					int_12 = 110;
					int_13 = 60;
					if (GClass14.int_10 > GClass14.int_11)
					{
						int_12 = GClass167.int_179 + 30 + 3 * num + gClass4.gclass21_0[GClass124.int_94[0][2][0]].sbyte_1 + int_19 - 15;
						int_13 = 35;
					}
				}
				gclass136_0.int_1 = int_12 - gclass136_0.int_3 - int_13 + 5;
			}
			else
			{
				int_12 = 110;
				int_13 = 60;
				if (GClass14.int_10 > GClass14.int_11)
				{
					int_12 = 100;
					int_13 = 45;
				}
				gclass136_0.int_1 = int_15;
			}
			for (int k = 0; k < 3; k++)
			{
				int num5 = 78;
				if (k != int_6)
					g.method_31(GClass167.gclass20_22, GClass14.int_10 / 2 - num5 + k * num5, int_12, 3);
				else
				{
					if (int_8 == 1)
						g.method_23(GClass167.gclass20_45, 0, 0, 13, 16, 4, GClass14.int_10 / 2 - num5 + k * num5, int_12 - 20 + ((GClass14.int_8 % 7 > 3) ? 1 : 0), GClass73.int_6);
					g.method_31(GClass167.gclass20_23, GClass14.int_10 / 2 - num5 + k * num5, int_12, 3);
				}
				GClass104.gclass104_6.method_6(g, mResources.MENUGENDER[k], GClass14.int_10 / 2 - num5 + k * num5, int_12 - 5, GClass104.int_2);
			}
			for (int l = 0; l < 3; l++)
			{
				int num6 = 78;
				if (l != int_7)
					g.method_31(GClass167.gclass20_22, GClass14.int_10 / 2 - num6 + l * num6, int_12 + int_13, 3);
				else
				{
					if (int_8 == 2)
						g.method_23(GClass167.gclass20_45, 0, 0, 13, 16, 4, GClass14.int_10 / 2 - num6 + l * num6, int_12 + int_13 - 20 + ((GClass14.int_8 % 7 > 3) ? 1 : 0), GClass73.int_6);
					g.method_31(GClass167.gclass20_23, GClass14.int_10 / 2 - num6 + l * num6, int_12 + int_13, 3);
				}
				GClass104.gclass104_6.method_6(g, mResources.hairStyleName[int_6][l], GClass14.int_10 / 2 - num6 + l * num6, int_12 + int_13 - 5, GClass104.int_2);
			}
			gclass136_0.method_13(g);
		}
		else
		{
			GClass14.gclass97_0.method_34(GClass167.int_180, GClass167.int_179, GClass167.int_194, GClass167.int_195, g);
			GClass72.smethod_6(g, gClass2.gclass21_0[GClass124.int_94[0][0][0]].short_0, GClass14.int_10 / 2 + GClass124.int_94[0][0][1] + gClass2.gclass21_0[GClass124.int_94[0][0][0]].sbyte_0, GClass167.int_179 + 30 + 3 * num - GClass124.int_94[0][0][2] + gClass2.gclass21_0[GClass124.int_94[0][0][0]].sbyte_1 + int_19, 0, 0);
			GClass72.smethod_6(g, gClass3.gclass21_0[GClass124.int_94[0][1][0]].short_0, GClass14.int_10 / 2 + GClass124.int_94[0][1][1] + gClass3.gclass21_0[GClass124.int_94[0][1][0]].sbyte_0, GClass167.int_179 + 30 + 3 * num - GClass124.int_94[0][1][2] + gClass3.gclass21_0[GClass124.int_94[0][1][0]].sbyte_1 + int_19, 0, 0);
			GClass72.smethod_6(g, gClass4.gclass21_0[GClass124.int_94[0][2][0]].short_0, GClass14.int_10 / 2 + GClass124.int_94[0][2][1] + gClass4.gclass21_0[GClass124.int_94[0][2][0]].sbyte_0, GClass167.int_179 + 30 + 3 * num - GClass124.int_94[0][2][2] + gClass4.gclass21_0[GClass124.int_94[0][2][0]].sbyte_1 + int_19, 0, 0);
			for (int m = 0; m < mResources.MENUNEWCHAR.Length; m++)
			{
				if (int_8 == m)
				{
					g.method_23(GClass167.gclass20_45, 0, 0, 13, 16, 2, GClass167.int_180 + 10 + ((GClass14.int_8 % 7 > 3) ? 1 : 0), GClass167.int_179 + 35 + m * num, GClass73.int_6);
					g.method_23(GClass167.gclass20_45, 0, 0, 13, 16, 0, GClass167.int_180 + GClass167.int_194 - 10 - ((GClass14.int_8 % 7 > 3) ? 1 : 0), GClass167.int_179 + 35 + m * num, GClass73.int_6);
				}
				GClass104.gclass104_6.method_6(g, mResources.MENUNEWCHAR[m], GClass167.int_180 + 20, GClass167.int_179 + 30 + m * num, 0);
			}
			GClass104.gclass104_6.method_6(g, mResources.MENUGENDER[int_6], GClass167.int_180 + 70, GClass167.int_179 + 30 + num, GClass104.int_0);
			GClass104.gclass104_6.method_6(g, mResources.hairStyleName[int_6][int_7], GClass167.int_180 + 55, GClass167.int_179 + 30 + 2 * num, GClass104.int_0);
			gclass136_0.method_13(g);
		}
		g.method_5(0, 0, GClass14.int_10, GClass14.int_11);
		GClass104.gclass104_3.method_10(g, mResources.server + " " + GClass173.string_4, 5, 5, 0, GClass104.gclass104_6);
		if (!GClass196.bool_1)
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
				if (!GClass14.gclass173_0.bool_12)
				{
					if (Main.isWindowsPhone)
						GClass206.bool_1 = true;
					GClass179.smethod_0().close();
					GClass14.gclass170_0.switchToMe();
				}
				else
					GClass14.smethod_36(mResources.note, new GClass118(mResources.YES, this, 10019, null), new GClass118(mResources.NO, this, 10020, null));
			}
			else if (!gclass136_0.method_21().Equals(string.Empty))
			{
				if (gclass136_0.method_21().Length < 5)
					GClass14.smethod_30(mResources.char_name_short);
				else if (gclass136_0.method_21().Length <= 15)
				{
					GClass96.smethod_1();
					GClass2.smethod_0().method_47(gclass136_0.method_21(), int_6, int_9[int_6][int_7]);
				}
				else
				{
					GClass14.smethod_30(mResources.char_name_long);
				}
			}
			else
			{
				GClass14.smethod_30(mResources.char_name_blank);
			}
		}
		else if (idAction != 10019)
		{
			if (idAction == 10020)
				GClass14.smethod_29();
		}
		else
		{
			GClass179.smethod_0().close();
			GClass14.smethod_29();
			GClass14.gclass170_0.switchToMe();
		}
	}
}
