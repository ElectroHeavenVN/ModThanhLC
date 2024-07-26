using AssemblyCSharp.Functions;

public class GClass79 : GClass78
{
	public const sbyte sbyte_40 = 0;

	public const sbyte sbyte_41 = 1;

	public const sbyte sbyte_42 = 2;

	public const sbyte sbyte_43 = 3;

	public const sbyte sbyte_44 = 4;

	public const sbyte sbyte_45 = 5;

	public const sbyte sbyte_46 = 6;

	public GClass127 gclass127_0;

	public int int_181;

	public bool bool_80 = true;

	public static GClass127[] gclass127_1;

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

	public GClass79(int npcId, int status, int cx, int cy, int templateId, int avatar)
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
			gclass127_0 = gclass127_1[templateId];
		if (templateId == 23 || templateId == 42)
			int_58 = 45;
		if (templateId == 51)
		{
			bool_21 = false;
			int_183 = status;
		}
		if (gclass127_0 != null)
		{
			if (gclass127_0.string_0 == null)
				gclass127_0.string_0 = "";
			gclass127_0.string_0 = GClass50.smethod_15(gclass127_0.string_0);
		}
	}

	public void method_166(sbyte s, int sc)
	{
		int_183 = s;
		long_18 = (long_19 = GClass203.smethod_18());
		int_190 = sc;
	}

	public static void smethod_10()
	{
		for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
		{
			GClass79 gClass = (GClass79)GClass144.gclass88_10.method_3(i);
			gClass.gclass124_1 = null;
			gClass.int_125 = -1;
		}
	}

	public override void update()
	{
		if (gclass127_0.int_0 == 51)
		{
			long_19 = GClass203.smethod_18();
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
		if (gclass124_1 == null)
		{
			sbyte[] array = new sbyte[7] { -1, 9, 9, 10, 10, 11, 11 };
			if (GClass78.smethod_1().int_15 >= 9 && GClass78.smethod_1().int_15 <= 10 && GClass78.smethod_1().gclass176_0.int_0 > 0 && array[GClass78.smethod_1().gclass176_0.int_0] == gclass127_0.int_0)
			{
				if (GClass78.smethod_1().gclass56_0 != null)
				{
					if (GClass78.smethod_1().gclass56_0 != null && GClass78.smethod_1().gclass56_0.int_0 + 1 == GClass78.smethod_1().gclass56_0.string_2.Length)
					{
						gclass124_1 = GClass144.gclass124_0[62];
						int_125 = 0;
					}
				}
				else
				{
					gclass124_1 = GClass144.gclass124_0[57];
					int_125 = 0;
				}
			}
			else
			{
				sbyte b = GClass144.smethod_28();
				if (GClass78.smethod_1().gclass56_0 != null || b != gclass127_0.int_0)
				{
					if (GClass78.smethod_1().gclass56_0 != null && b == gclass127_0.int_0)
					{
						if (GClass78.smethod_1().gclass56_0.int_0 + 1 != GClass78.smethod_1().gclass56_0.string_2.Length)
							gclass124_1 = GClass144.gclass124_0[98];
						else
							gclass124_1 = GClass144.gclass124_0[98];
						int_125 = 0;
					}
				}
				else
					int_125 = 0;
			}
		}
		base.update();
		if (GClass20.int_37 != 51)
			return;
		if (int_4 > GClass78.smethod_1().int_4)
			int_12 = -1;
		else
			int_12 = 1;
		if (gclass127_0.int_0 % 2 == 0)
		{
			if (int_63 != 1)
				int_63 = 1;
			else
				int_63 = 0;
		}
	}

	public void method_167(GClass122 g, int xStart, int yStart)
	{
		GClass116 gClass = GClass144.gclass116_0[gclass127_0.int_1];
		if (int_12 != 1)
			GClass28.smethod_6(g, gClass.gclass66_0[GClass78.int_94[int_63][0][0]].short_0, GClass73.int_10 - 31 - g.method_3(), 2 - g.method_4(), 2, 24);
		else
			GClass28.smethod_6(g, gClass.gclass66_0[GClass78.int_94[int_63][0][0]].short_0, GClass73.int_10 - 31 - g.method_3(), 2 - g.method_4(), 0, 0);
	}

	public override void paint(GClass122 g)
	{
		if (GClass167.smethod_0().bool_6 || GClass78.bool_35 || bool_81 || !method_78() || int_11 == 15)
			return;
		if (sbyte_19 == 0)
		{
			if (gclass127_0 == null)
				return;
			if (gclass127_0.int_0 != 4 && gclass127_0.int_0 != 51 && gclass127_0.int_0 != 50)
				g.method_31(GClass20.gclass70_10, int_4, int_5, 3);
			if (gclass127_0.int_0 != 3)
			{
				if (gclass127_0.int_0 != 4)
				{
					if (gclass127_0.int_0 == 50 || gclass127_0.int_0 == 51)
					{
						if (int_189 != null)
						{
							if (gclass127_0.int_0 == 50 && bool_82)
							{
								int_185++;
								if (GClass73.int_8 % 3 == 0)
									GClass57.smethod_0(new GClass81(19, int_4 + GClass50.smethod_19(-50, 50), int_5, 2, 1, -1));
								if (GClass73.int_8 % 15 == 0)
									GClass57.smethod_0(new GClass81(18, int_4 + GClass50.smethod_19(-5, 5), int_5 + GClass50.smethod_19(-90, 0), 2, 1, -1));
								if (int_185 == 100)
									GClass144.smethod_8().method_51(int_4, int_5);
								if (int_185 == 110)
								{
									bool_82 = false;
									gclass127_0.int_0 = 4;
								}
							}
							int num = 0;
							if (GClass28.gclass83_0[int_189[int_183]] != null && GClass28.gclass83_0[int_189[int_183]].gclass70_0 != null)
								num = GClass122.smethod_1(GClass28.gclass83_0[int_189[int_183]].gclass70_0);
							GClass28.smethod_6(g, int_189[int_183], int_4 + GClass50.smethod_19(-1, 1), int_5, 0, GClass122.int_5 | GClass122.int_0);
							if (GClass78.smethod_1().gclass79_0 == null || !GClass78.smethod_1().gclass79_0.Equals(this))
								GClass4.gclass4_3.method_10(g, GClass65.smethod_8(int_190), int_4, int_5 - int_58 - 8 - GClass4.gclass4_11.method_20() - 20 - num + 16, GClass4.int_2, GClass4.gclass4_6);
							else
							{
								if (GClass96.gclass96_0 == null)
									g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 - 9 + 16 - num, GClass122.int_5 | GClass122.int_0);
								GClass4.gclass4_3.method_10(g, GClass65.smethod_8(int_190), int_4, int_5 - int_58 - 16 - GClass4.gclass4_11.method_20() - 20 - num + 16, GClass4.int_2, GClass4.gclass4_6);
							}
						}
					}
					else if (gclass127_0.int_0 == 6)
					{
						GClass28.smethod_6(g, 545, int_4, int_5 + 5, 0, GClass122.int_5 | GClass122.int_0);
						if (GClass78.smethod_1().gclass79_0 != null && GClass78.smethod_1().gclass79_0.Equals(this) && GClass96.gclass96_0 == null)
							g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 - 9, GClass122.int_5 | GClass122.int_0);
						GClass4.gclass4_3.method_6(g, GClass20.int_39 + "", int_4, int_5 - int_58 + 19 - GClass4.gclass4_11.method_20(), GClass4.int_2);
					}
					else
					{
						int num2 = gclass127_0.int_1;
						int num3 = gclass127_0.int_3;
						int num4 = gclass127_0.int_2;
						GClass116 gClass = GClass144.gclass116_0[num2];
						GClass116 gClass2 = GClass144.gclass116_0[num3];
						GClass116 gClass3 = GClass144.gclass116_0[num4];
						if (int_12 != 1)
						{
							GClass28.smethod_6(g, gClass.gclass66_0[GClass78.int_94[int_63][0][0]].short_0, int_4 - GClass78.int_94[int_63][0][1] - gClass.gclass66_0[GClass78.int_94[int_63][0][0]].sbyte_0, int_5 - GClass78.int_94[int_63][0][2] + gClass.gclass66_0[GClass78.int_94[int_63][0][0]].sbyte_1, 2, 24);
							GClass28.smethod_6(g, gClass2.gclass66_0[GClass78.int_94[int_63][1][0]].short_0, int_4 - GClass78.int_94[int_63][1][1] - gClass2.gclass66_0[GClass78.int_94[int_63][1][0]].sbyte_0, int_5 - GClass78.int_94[int_63][1][2] + gClass2.gclass66_0[GClass78.int_94[int_63][1][0]].sbyte_1, 2, 24);
							GClass28.smethod_6(g, gClass3.gclass66_0[GClass78.int_94[int_63][2][0]].short_0, int_4 - GClass78.int_94[int_63][2][1] - gClass3.gclass66_0[GClass78.int_94[int_63][2][0]].sbyte_0, int_5 - GClass78.int_94[int_63][2][2] + gClass3.gclass66_0[GClass78.int_94[int_63][2][0]].sbyte_1, 2, 24);
						}
						else
						{
							GClass28.smethod_6(g, gClass.gclass66_0[GClass78.int_94[int_63][0][0]].short_0, int_4 + GClass78.int_94[int_63][0][1] + gClass.gclass66_0[GClass78.int_94[int_63][0][0]].sbyte_0, int_5 - GClass78.int_94[int_63][0][2] + gClass.gclass66_0[GClass78.int_94[int_63][0][0]].sbyte_1, 0, 0);
							GClass28.smethod_6(g, gClass2.gclass66_0[GClass78.int_94[int_63][1][0]].short_0, int_4 + GClass78.int_94[int_63][1][1] + gClass2.gclass66_0[GClass78.int_94[int_63][1][0]].sbyte_0, int_5 - GClass78.int_94[int_63][1][2] + gClass2.gclass66_0[GClass78.int_94[int_63][1][0]].sbyte_1, 0, 0);
							GClass28.smethod_6(g, gClass3.gclass66_0[GClass78.int_94[int_63][2][0]].short_0, int_4 + GClass78.int_94[int_63][2][1] + gClass3.gclass66_0[GClass78.int_94[int_63][2][0]].sbyte_0, int_5 - GClass78.int_94[int_63][2][2] + gClass3.gclass66_0[GClass78.int_94[int_63][2][0]].sbyte_1, 0, 0);
						}
						if (GClass20.int_37 != 51)
						{
							int num5 = 15;
							if (gclass127_0.int_0 == 47)
								num5 = 47;
							if (GClass78.smethod_1().gclass79_0 != null && GClass78.smethod_1().gclass79_0.Equals(this))
							{
								if (GClass96.gclass96_0 == null)
								{
									int num6 = 0;
									int num7 = 0;
									if (GClass78.smethod_1().gclass79_0.gclass127_0.int_0 == 28 || GClass78.smethod_1().gclass79_0.gclass127_0.int_0 == 41)
									{
										num6 = 3;
										num7 = -12;
									}
									g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 0, int_4 + num6, int_5 - int_58 - (num5 - 8) + num7, GClass122.int_5 | GClass122.int_0);
								}
							}
							else
							{
								num5 = 8;
								if (gclass127_0.int_0 == 47)
									num5 = 40;
							}
						}
						int_184 = 65;
					}
				}
			}
			else
			{
				GClass28.smethod_6(g, 265, int_4, int_5, 0, GClass122.int_5 | GClass122.int_0);
				if (GClass78.smethod_1().gclass79_0 != null && GClass78.smethod_1().gclass79_0.Equals(this) && GClass96.gclass96_0 == null)
					g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 + 4, GClass122.int_5 | GClass122.int_0);
				int_184 = 60;
			}
			if (int_125 < 0 || gclass124_1 == null || sbyte_19 != 0)
				return;
			GClass28.smethod_6(g, gclass124_1.gclass209_0[int_125].int_2, int_4 + gclass124_1.gclass209_0[int_125].int_0, int_5 + gclass124_1.gclass209_0[int_125].int_1 - int_184, 0, GClass122.int_1 | GClass122.int_0);
			if (GClass73.int_8 % 2 == 0)
			{
				int_125++;
				if (int_125 >= gclass124_1.gclass209_0.Length)
					int_125 = 0;
			}
		}
		else
			base.paint(g);
	}

	public void method_168(GClass122 g)
	{
		if (GClass78.bool_35 || bool_81 || !method_78() || int_11 == 15 || gclass127_0 == null)
			return;
		if (gclass127_0.int_0 == 3)
		{
			if (GClass78.smethod_1().gclass79_0 == null || !GClass78.smethod_1().gclass79_0.Equals(this))
				GClass4.gclass4_15.method_10(g, gclass127_0.string_0, int_4, int_5 - int_58 - 3 - GClass4.gclass4_11.method_20(), GClass4.int_2, GClass4.gclass4_16);
			else
				GClass4.gclass4_15.method_10(g, gclass127_0.string_0, int_4, int_5 - int_58 - GClass4.gclass4_11.method_20() - 5, GClass4.int_2, GClass4.gclass4_16);
			int_184 = 60;
		}
		else
		{
			if (gclass127_0.int_0 == 4)
				return;
			if (gclass127_0.int_0 == 50 || gclass127_0.int_0 == 51)
			{
				if (int_189 != null)
				{
					int num = 0;
					if (GClass28.gclass83_0[int_189[int_183]] != null && GClass28.gclass83_0[int_189[int_183]].gclass70_0 != null)
						num = GClass122.smethod_1(GClass28.gclass83_0[int_189[int_183]].gclass70_0);
					if (GClass78.smethod_1().gclass79_0 != null && GClass78.smethod_1().gclass79_0.Equals(this))
						GClass4.gclass4_15.method_10(g, gclass127_0.string_0, int_4, int_5 - int_58 - GClass4.gclass4_11.method_20() - num, GClass4.int_2, GClass4.gclass4_16);
					else
						GClass4.gclass4_15.method_10(g, gclass127_0.string_0, int_4, int_5 - int_58 - 8 - GClass4.gclass4_11.method_20() - num + 16, GClass4.int_2, GClass4.gclass4_16);
				}
				return;
			}
			if (gclass127_0.int_0 == 6)
			{
				if (GClass78.smethod_1().gclass79_0 != null && GClass78.smethod_1().gclass79_0.Equals(this))
					GClass4.gclass4_15.method_10(g, gclass127_0.string_0, int_4, int_5 - int_58 - GClass4.gclass4_11.method_20() - 16, GClass4.int_2, GClass4.gclass4_16);
				else
					GClass4.gclass4_15.method_10(g, gclass127_0.string_0, int_4, int_5 - int_58 - 8 - GClass4.gclass4_11.method_20(), GClass4.int_2, GClass4.gclass4_16);
				return;
			}
			if (GClass20.int_37 != 51)
			{
				int num2 = 15;
				if (gclass127_0.int_0 == 47)
					num2 = 47;
				if (GClass78.smethod_1().gclass79_0 == null || !GClass78.smethod_1().gclass79_0.Equals(this))
				{
					num2 = 8;
					if (gclass127_0.int_0 == 47)
						num2 = 40;
					if (GClass20.int_37 != 113)
					{
						int num3 = 0;
						int num4 = 0;
						if (gclass127_0.int_0 == 28 || gclass127_0.int_0 == 41)
						{
							num3 = 3;
							num4 = -12;
						}
						GClass4.gclass4_15.method_10(g, gclass127_0.string_0, int_4 + num3, int_5 - int_58 - num2 - GClass4.gclass4_11.method_20() + num4, GClass4.int_2, GClass4.gclass4_16);
					}
				}
				else if (GClass20.int_37 != 113)
				{
					int num5 = 0;
					int num6 = 0;
					if (GClass78.smethod_1().gclass79_0.gclass127_0.int_0 == 28 || GClass78.smethod_1().gclass79_0.gclass127_0.int_0 == 41)
					{
						num5 = 3;
						num6 = -12;
					}
					GClass4.gclass4_15.method_10(g, gclass127_0.string_0, int_4 + num5, int_5 - int_58 - GClass4.gclass4_11.method_20() - num2 + num6, GClass4.int_2, GClass4.gclass4_16);
				}
			}
			int_184 = 65;
		}
	}

	public void method_169()
	{
		int_11 = 15;
		GClass78.gclass96_0 = null;
	}
}
