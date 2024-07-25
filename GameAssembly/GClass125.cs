using ns1;

public class GClass125 : GClass124
{
	public const sbyte sbyte_40 = 0;

	public const sbyte sbyte_41 = 1;

	public const sbyte sbyte_42 = 2;

	public const sbyte sbyte_43 = 3;

	public const sbyte sbyte_44 = 4;

	public const sbyte sbyte_45 = 5;

	public const sbyte sbyte_46 = 6;

	public GClass120 gclass120_0;

	public int int_181;

	public bool bool_80 = true;

	public static GClass120[] gclass120_1;

	public int int_182;

	public bool bool_81;

	private int int_183;

	private int int_184;

	public static bool bool_82;

	public static int int_185;

	private static int[] int_186 = new int[4] { 1, -1, 1, -1 };

	private static int[] int_187 = new int[4] { 1, -1, -1, 1 };

	public static int int_188;

	public int[] int_189;

	public int int_190;

	public long long_18;

	public long long_19;

	public int int_191;

	public GClass125(int npcId, int status, int cx, int cy, int templateId, int avatar)
	{
		bool_21 = true;
		int_181 = npcId;
		int_70 = avatar;
		int_4 = cx;
		int_5 = cy;
		int_147 = cx;
		int_148 = cy;
		int_11 = status;
		if (npcId != -1)
			gclass120_0 = gclass120_1[templateId];
		if (templateId == 23 || templateId == 42)
			int_58 = 45;
		if (templateId == 51)
		{
			bool_21 = false;
			int_183 = status;
		}
		if (gclass120_0 != null)
		{
			if (gclass120_0.string_0 == null)
				gclass120_0.string_0 = string.Empty;
			gclass120_0.string_0 = GClass191.smethod_15(gclass120_0.string_0);
		}
	}

	public void method_166(sbyte s, int sc)
	{
		int_183 = s;
		long_18 = (long_19 = GClass77.smethod_18());
		int_190 = sc;
	}

	public static void smethod_10()
	{
		for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
		{
			GClass125 gClass = (GClass125)GClass167.gclass122_10.method_3(i);
			gClass.gclass80_1 = null;
			gClass.int_125 = -1;
		}
	}

	public override void update()
	{
		if (gclass120_0.int_0 == 51)
		{
			long_19 = GClass77.smethod_18();
			if (long_19 - long_18 >= 1000L)
			{
				int_190--;
				long_18 = long_19;
				if (int_190 < 0)
					int_190 = 0;
			}
		}
		if (bool_21)
			method_92();
		if (gclass80_1 == null)
		{
			sbyte[] array = new sbyte[7] { -1, 9, 9, 10, 10, 11, 11 };
			if (GClass124.smethod_1().int_15 < 9 || GClass124.smethod_1().int_15 > 10 || GClass124.smethod_1().gclass94_0.int_0 <= 0 || array[GClass124.smethod_1().gclass94_0.int_0] != gclass120_0.int_0)
			{
				sbyte b = GClass167.smethod_28();
				if (GClass124.smethod_1().gclass70_0 == null && b == gclass120_0.int_0)
					int_125 = 0;
				else if (GClass124.smethod_1().gclass70_0 != null && b == gclass120_0.int_0)
				{
					if (GClass124.smethod_1().gclass70_0.int_0 + 1 == GClass124.smethod_1().gclass70_0.string_2.Length)
						gclass80_1 = GClass167.gclass80_0[98];
					else
						gclass80_1 = GClass167.gclass80_0[98];
					int_125 = 0;
				}
			}
			else if (GClass124.smethod_1().gclass70_0 != null)
			{
				if (GClass124.smethod_1().gclass70_0 != null && GClass124.smethod_1().gclass70_0.int_0 + 1 == GClass124.smethod_1().gclass70_0.string_2.Length)
				{
					gclass80_1 = GClass167.gclass80_0[62];
					int_125 = 0;
				}
			}
			else
			{
				gclass80_1 = GClass167.gclass80_0[57];
				int_125 = 0;
			}
		}
		base.update();
		if (GClass137.int_37 != 51)
			return;
		if (int_4 <= GClass124.smethod_1().int_4)
			int_12 = 1;
		else
			int_12 = -1;
		if (gclass120_0.int_0 % 2 == 0)
		{
			if (int_63 == 1)
				int_63 = 0;
			else
				int_63 = 1;
		}
	}

	public void method_167(GClass193 g, int xStart, int yStart)
	{
		GClass29 gClass = GClass167.gclass29_0[gclass120_0.int_1];
		if (int_12 != 1)
			GClass72.smethod_6(g, gClass.gclass21_0[GClass124.int_94[int_63][0][0]].short_0, GClass14.int_10 - 31 - g.method_3(), 2 - g.method_4(), 2, 24);
		else
			GClass72.smethod_6(g, gClass.gclass21_0[GClass124.int_94[int_63][0][0]].short_0, GClass14.int_10 - 31 - g.method_3(), 2 - g.method_4(), 0, 0);
	}

	public override void paint(GClass193 g)
	{
		if (GClass66.smethod_0().bool_6 || GClass124.bool_35 || bool_81 || !method_78() || int_11 == 15)
			return;
		if (sbyte_19 == 0)
		{
			if (gclass120_0 == null)
				return;
			if (gclass120_0.int_0 != 4 && gclass120_0.int_0 != 51 && gclass120_0.int_0 != 50)
				g.method_31(GClass137.gclass20_10, int_4, int_5, 3);
			if (gclass120_0.int_0 == 3)
			{
				GClass72.smethod_6(g, 265, int_4, int_5, 0, GClass193.int_5 | GClass193.int_0);
				if (GClass124.smethod_1().gclass125_0 != null && GClass124.smethod_1().gclass125_0.Equals(this) && GClass88.gclass88_0 == null)
					g.method_23(GClass6.gclass20_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 + 4, GClass193.int_5 | GClass193.int_0);
				int_184 = 60;
			}
			else if (gclass120_0.int_0 != 4)
			{
				if (gclass120_0.int_0 != 50 && gclass120_0.int_0 != 51)
				{
					if (gclass120_0.int_0 != 6)
					{
						int num = gclass120_0.int_1;
						int num2 = gclass120_0.int_3;
						int num3 = gclass120_0.int_2;
						GClass29 gClass = GClass167.gclass29_0[num];
						GClass29 gClass2 = GClass167.gclass29_0[num2];
						GClass29 gClass3 = GClass167.gclass29_0[num3];
						if (int_12 == 1)
						{
							GClass72.smethod_6(g, gClass.gclass21_0[GClass124.int_94[int_63][0][0]].short_0, int_4 + GClass124.int_94[int_63][0][1] + gClass.gclass21_0[GClass124.int_94[int_63][0][0]].sbyte_0, int_5 - GClass124.int_94[int_63][0][2] + gClass.gclass21_0[GClass124.int_94[int_63][0][0]].sbyte_1, 0, 0);
							GClass72.smethod_6(g, gClass2.gclass21_0[GClass124.int_94[int_63][1][0]].short_0, int_4 + GClass124.int_94[int_63][1][1] + gClass2.gclass21_0[GClass124.int_94[int_63][1][0]].sbyte_0, int_5 - GClass124.int_94[int_63][1][2] + gClass2.gclass21_0[GClass124.int_94[int_63][1][0]].sbyte_1, 0, 0);
							GClass72.smethod_6(g, gClass3.gclass21_0[GClass124.int_94[int_63][2][0]].short_0, int_4 + GClass124.int_94[int_63][2][1] + gClass3.gclass21_0[GClass124.int_94[int_63][2][0]].sbyte_0, int_5 - GClass124.int_94[int_63][2][2] + gClass3.gclass21_0[GClass124.int_94[int_63][2][0]].sbyte_1, 0, 0);
						}
						else
						{
							GClass72.smethod_6(g, gClass.gclass21_0[GClass124.int_94[int_63][0][0]].short_0, int_4 - GClass124.int_94[int_63][0][1] - gClass.gclass21_0[GClass124.int_94[int_63][0][0]].sbyte_0, int_5 - GClass124.int_94[int_63][0][2] + gClass.gclass21_0[GClass124.int_94[int_63][0][0]].sbyte_1, 2, 24);
							GClass72.smethod_6(g, gClass2.gclass21_0[GClass124.int_94[int_63][1][0]].short_0, int_4 - GClass124.int_94[int_63][1][1] - gClass2.gclass21_0[GClass124.int_94[int_63][1][0]].sbyte_0, int_5 - GClass124.int_94[int_63][1][2] + gClass2.gclass21_0[GClass124.int_94[int_63][1][0]].sbyte_1, 2, 24);
							GClass72.smethod_6(g, gClass3.gclass21_0[GClass124.int_94[int_63][2][0]].short_0, int_4 - GClass124.int_94[int_63][2][1] - gClass3.gclass21_0[GClass124.int_94[int_63][2][0]].sbyte_0, int_5 - GClass124.int_94[int_63][2][2] + gClass3.gclass21_0[GClass124.int_94[int_63][2][0]].sbyte_1, 2, 24);
						}
						if (GClass137.int_37 != 51)
						{
							int num4 = 15;
							if (gclass120_0.int_0 == 47)
								num4 = 47;
							if (GClass124.smethod_1().gclass125_0 != null && GClass124.smethod_1().gclass125_0.Equals(this))
							{
								if (GClass88.gclass88_0 == null)
								{
									int num5 = 0;
									int num6 = 0;
									if (GClass124.smethod_1().gclass125_0.gclass120_0.int_0 == 28 || GClass124.smethod_1().gclass125_0.gclass120_0.int_0 == 41)
									{
										num5 = 3;
										num6 = -12;
									}
									g.method_23(GClass6.gclass20_0, 0, 0, 9, 6, 0, int_4 + num5, int_5 - int_58 - (num4 - 8) + num6, GClass193.int_5 | GClass193.int_0);
								}
							}
							else
							{
								num4 = 8;
								if (gclass120_0.int_0 == 47)
									num4 = 40;
							}
						}
						int_184 = 65;
					}
					else
					{
						GClass72.smethod_6(g, 545, int_4, int_5 + 5, 0, GClass193.int_5 | GClass193.int_0);
						if (GClass124.smethod_1().gclass125_0 != null && GClass124.smethod_1().gclass125_0.Equals(this) && GClass88.gclass88_0 == null)
							g.method_23(GClass6.gclass20_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 - 9, GClass193.int_5 | GClass193.int_0);
						GClass104.gclass104_3.method_6(g, GClass137.int_39 + string.Empty, int_4, int_5 - int_58 + 19 - GClass104.gclass104_11.method_20(), GClass104.int_2);
					}
				}
				else if (int_189 != null)
				{
					if (gclass120_0.int_0 == 50 && bool_82)
					{
						int_185++;
						if (GClass14.int_8 % 3 == 0)
							GClass98.smethod_0(new GClass85(19, int_4 + GClass191.smethod_19(-50, 50), int_5, 2, 1, -1));
						if (GClass14.int_8 % 15 == 0)
							GClass98.smethod_0(new GClass85(18, int_4 + GClass191.smethod_19(-5, 5), int_5 + GClass191.smethod_19(-90, 0), 2, 1, -1));
						if (int_185 == 100)
							GClass167.smethod_8().method_51(int_4, int_5);
						if (int_185 == 110)
						{
							bool_82 = false;
							gclass120_0.int_0 = 4;
						}
					}
					int num7 = 0;
					if (GClass72.gclass26_0[int_189[int_183]] != null && GClass72.gclass26_0[int_189[int_183]].gclass20_0 != null)
						num7 = GClass193.smethod_1(GClass72.gclass26_0[int_189[int_183]].gclass20_0);
					GClass72.smethod_6(g, int_189[int_183], int_4 + GClass191.smethod_19(-1, 1), int_5, 0, GClass193.int_5 | GClass193.int_0);
					if (GClass124.smethod_1().gclass125_0 == null || !GClass124.smethod_1().gclass125_0.Equals(this))
						GClass104.gclass104_3.method_10(g, GClass138.smethod_8(int_190), int_4, int_5 - int_58 - 8 - GClass104.gclass104_11.method_20() - 20 - num7 + 16, GClass104.int_2, GClass104.gclass104_6);
					else
					{
						if (GClass88.gclass88_0 == null)
							g.method_23(GClass6.gclass20_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 - 9 + 16 - num7, GClass193.int_5 | GClass193.int_0);
						GClass104.gclass104_3.method_10(g, GClass138.smethod_8(int_190), int_4, int_5 - int_58 - 16 - GClass104.gclass104_11.method_20() - 20 - num7 + 16, GClass104.int_2, GClass104.gclass104_6);
					}
				}
			}
			if (int_125 < 0 || gclass80_1 == null || sbyte_19 != 0)
				return;
			GClass72.smethod_6(g, gclass80_1.gclass31_0[int_125].int_2, int_4 + gclass80_1.gclass31_0[int_125].int_0, int_5 + gclass80_1.gclass31_0[int_125].int_1 - int_184, 0, GClass193.int_1 | GClass193.int_0);
			if (GClass14.int_8 % 2 == 0)
			{
				int_125++;
				if (int_125 >= gclass80_1.gclass31_0.Length)
					int_125 = 0;
			}
		}
		else
			base.paint(g);
	}

	public void method_168(GClass193 g)
	{
		if (GClass124.bool_35 || bool_81 || !method_78() || int_11 == 15 || gclass120_0 == null)
			return;
		if (gclass120_0.int_0 == 3)
		{
			if (GClass124.smethod_1().gclass125_0 == null || !GClass124.smethod_1().gclass125_0.Equals(this))
				GClass104.gclass104_15.method_10(g, gclass120_0.string_0, int_4, int_5 - int_58 - 3 - GClass104.gclass104_11.method_20(), GClass104.int_2, GClass104.gclass104_16);
			else
				GClass104.gclass104_15.method_10(g, gclass120_0.string_0, int_4, int_5 - int_58 - GClass104.gclass104_11.method_20() - 5, GClass104.int_2, GClass104.gclass104_16);
			int_184 = 60;
		}
		else
		{
			if (gclass120_0.int_0 == 4)
				return;
			if (gclass120_0.int_0 != 50 && gclass120_0.int_0 != 51)
			{
				if (gclass120_0.int_0 != 6)
				{
					if (GClass137.int_37 != 51)
					{
						int num = 15;
						if (gclass120_0.int_0 == 47)
							num = 47;
						if (GClass124.smethod_1().gclass125_0 != null && GClass124.smethod_1().gclass125_0.Equals(this))
						{
							if (GClass137.int_37 != 113)
							{
								int num2 = 0;
								int num3 = 0;
								if (GClass124.smethod_1().gclass125_0.gclass120_0.int_0 == 28 || GClass124.smethod_1().gclass125_0.gclass120_0.int_0 == 41)
								{
									num2 = 3;
									num3 = -12;
								}
								GClass104.gclass104_15.method_10(g, gclass120_0.string_0, int_4 + num2, int_5 - int_58 - GClass104.gclass104_11.method_20() - num + num3, GClass104.int_2, GClass104.gclass104_16);
							}
						}
						else
						{
							num = 8;
							if (gclass120_0.int_0 == 47)
								num = 40;
							if (GClass137.int_37 != 113)
							{
								int num4 = 0;
								int num5 = 0;
								if (gclass120_0.int_0 == 28 || gclass120_0.int_0 == 41)
								{
									num4 = 3;
									num5 = -12;
								}
								GClass104.gclass104_15.method_10(g, gclass120_0.string_0, int_4 + num4, int_5 - int_58 - num - GClass104.gclass104_11.method_20() + num5, GClass104.int_2, GClass104.gclass104_16);
							}
						}
					}
					int_184 = 65;
				}
				else if (GClass124.smethod_1().gclass125_0 == null || !GClass124.smethod_1().gclass125_0.Equals(this))
				{
					GClass104.gclass104_15.method_10(g, gclass120_0.string_0, int_4, int_5 - int_58 - 8 - GClass104.gclass104_11.method_20(), GClass104.int_2, GClass104.gclass104_16);
				}
				else
				{
					GClass104.gclass104_15.method_10(g, gclass120_0.string_0, int_4, int_5 - int_58 - GClass104.gclass104_11.method_20() - 16, GClass104.int_2, GClass104.gclass104_16);
				}
			}
			else if (int_189 != null)
			{
				int num6 = 0;
				if (GClass72.gclass26_0[int_189[int_183]] != null && GClass72.gclass26_0[int_189[int_183]].gclass20_0 != null)
					num6 = GClass193.smethod_1(GClass72.gclass26_0[int_189[int_183]].gclass20_0);
				if (GClass124.smethod_1().gclass125_0 != null && GClass124.smethod_1().gclass125_0.Equals(this))
					GClass104.gclass104_15.method_10(g, gclass120_0.string_0, int_4, int_5 - int_58 - GClass104.gclass104_11.method_20() - num6, GClass104.int_2, GClass104.gclass104_16);
				else
					GClass104.gclass104_15.method_10(g, gclass120_0.string_0, int_4, int_5 - int_58 - 8 - GClass104.gclass104_11.method_20() - num6 + 16, GClass104.int_2, GClass104.gclass104_16);
			}
		}
	}

	public void method_169()
	{
		int_11 = 15;
		GClass124.gclass88_0 = null;
	}
}
