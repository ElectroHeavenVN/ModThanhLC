using ns1;

public class GClass59 : GClass58
{
	public const sbyte sbyte_40 = 0;

	public const sbyte sbyte_41 = 1;

	public const sbyte sbyte_42 = 2;

	public const sbyte sbyte_43 = 3;

	public const sbyte sbyte_44 = 4;

	public const sbyte sbyte_45 = 5;

	public const sbyte sbyte_46 = 6;

	public GClass90 gclass90_0;

	public int int_181;

	public bool bool_80 = true;

	public static GClass90[] gclass90_1;

	public int int_182;

	public bool bool_81;

	private int earwrVthdM;

	private int int_183;

	public static bool bool_82;

	public static int int_184;

	private static int[] int_185 = new int[4] { 1, -1, 1, -1 };

	private static int[] int_186 = new int[4] { 1, -1, -1, 1 };

	public static int int_187;

	public int[] int_188;

	public int int_189;

	public long long_18;

	public long long_19;

	public int int_190;

	public GClass59(int npcId, int status, int cx, int cy, int templateId, int avatar)
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
			gclass90_0 = gclass90_1[templateId];
		if (templateId == 23 || templateId == 42)
			int_58 = 45;
		if (templateId == 51)
		{
			bool_21 = false;
			earwrVthdM = status;
		}
		if (gclass90_0 != null)
		{
			if (gclass90_0.string_0 == null)
				gclass90_0.string_0 = string.Empty;
			gclass90_0.string_0 = GClass56.smethod_15(gclass90_0.string_0);
		}
	}

	public void method_164(sbyte s, int sc)
	{
		earwrVthdM = s;
		long_18 = (long_19 = GClass138.smethod_18());
		int_189 = sc;
	}

	public static void smethod_10()
	{
		for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
		{
			GClass59 gClass = (GClass59)GClass154.gclass63_10.method_3(i);
			gClass.gclass42_1 = null;
			gClass.int_125 = -1;
		}
	}

	public override void update()
	{
		if (gclass90_0.int_0 == 51)
		{
			long_19 = GClass138.smethod_18();
			if (long_19 - long_18 >= 1000L)
			{
				int_189--;
				long_18 = long_19;
				if (int_189 < 0)
					int_189 = 0;
			}
		}
		if (bool_21)
			method_90();
		if (gclass42_1 == null)
		{
			sbyte[] array = new sbyte[7] { -1, 9, 9, 10, 10, 11, 11 };
			if (GClass58.smethod_1().int_15 >= 9 && GClass58.smethod_1().int_15 <= 10 && GClass58.smethod_1().gclass109_0.int_0 > 0 && array[GClass58.smethod_1().gclass109_0.int_0] == gclass90_0.int_0)
			{
				if (GClass58.smethod_1().gclass36_0 == null)
				{
					gclass42_1 = GClass154.gclass42_0[57];
					int_125 = 0;
				}
				else if (GClass58.smethod_1().gclass36_0 != null && GClass58.smethod_1().gclass36_0.int_0 + 1 == GClass58.smethod_1().gclass36_0.string_2.Length)
				{
					gclass42_1 = GClass154.gclass42_0[62];
					int_125 = 0;
				}
			}
			else
			{
				sbyte b = GClass154.smethod_28();
				if (GClass58.smethod_1().gclass36_0 == null && b == gclass90_0.int_0)
					int_125 = 0;
				else if (GClass58.smethod_1().gclass36_0 != null && b == gclass90_0.int_0)
				{
					if (GClass58.smethod_1().gclass36_0.int_0 + 1 == GClass58.smethod_1().gclass36_0.string_2.Length)
						gclass42_1 = GClass154.gclass42_0[98];
					else
						gclass42_1 = GClass154.gclass42_0[98];
					int_125 = 0;
				}
			}
		}
		base.update();
		if (GClass1.int_37 != 51)
			return;
		if (int_4 > GClass58.smethod_1().int_4)
			int_12 = -1;
		else
			int_12 = 1;
		if (gclass90_0.int_0 % 2 == 0)
		{
			if (int_63 == 1)
				int_63 = 0;
			else
				int_63 = 1;
		}
	}

	public void method_165(GClass76 g, int xStart, int yStart)
	{
		GClass44 gClass = GClass154.gclass44_0[gclass90_0.int_1];
		if (int_12 == 1)
			GClass96.smethod_6(g, gClass.gclass161_0[GClass58.int_94[int_63][0][0]].short_0, GClass39.int_10 - 31 - g.method_3(), 2 - g.method_4(), 0, 0);
		else
			GClass96.smethod_6(g, gClass.gclass161_0[GClass58.int_94[int_63][0][0]].short_0, GClass39.int_10 - 31 - g.method_3(), 2 - g.method_4(), 2, 24);
	}

	public override void paint(GClass76 g)
	{
		if (GClass173.smethod_0().bool_5 || GClass58.bool_35 || bool_81 || !method_77() || int_11 == 15)
			return;
		if (sbyte_19 != 0)
			base.paint(g);
		else
		{
			if (gclass90_0 == null)
				return;
			if (gclass90_0.int_0 != 4 && gclass90_0.int_0 != 51 && gclass90_0.int_0 != 50)
				g.method_31(GClass1.gclass2_10, int_4, int_5, 3);
			if (gclass90_0.int_0 == 3)
			{
				GClass96.smethod_6(g, 265, int_4, int_5, 0, GClass76.int_5 | GClass76.int_0);
				if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this) && GClass70.gclass70_0 == null)
					g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 + 4, GClass76.int_5 | GClass76.int_0);
				int_183 = 60;
			}
			else if (gclass90_0.int_0 != 4)
			{
				if (gclass90_0.int_0 == 50 || gclass90_0.int_0 == 51)
				{
					if (int_188 != null)
					{
						if (gclass90_0.int_0 == 50 && bool_82)
						{
							int_184++;
							if (GClass39.int_8 % 3 == 0)
								GClass81.smethod_0(new GClass33(19, int_4 + GClass56.smethod_19(-50, 50), int_5, 2, 1, -1));
							if (GClass39.int_8 % 15 == 0)
								GClass81.smethod_0(new GClass33(18, int_4 + GClass56.smethod_19(-5, 5), int_5 + GClass56.smethod_19(-90, 0), 2, 1, -1));
							if (int_184 == 100)
								GClass154.smethod_8().method_51(int_4, int_5);
							if (int_184 == 110)
							{
								bool_82 = false;
								gclass90_0.int_0 = 4;
							}
						}
						int num = 0;
						if (GClass96.gclass129_0[int_188[earwrVthdM]] != null && GClass96.gclass129_0[int_188[earwrVthdM]].gclass2_0 != null)
							num = GClass76.smethod_1(GClass96.gclass129_0[int_188[earwrVthdM]].gclass2_0);
						GClass96.smethod_6(g, int_188[earwrVthdM], int_4 + GClass56.smethod_19(-1, 1), int_5, 0, GClass76.int_5 | GClass76.int_0);
						if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this))
						{
							if (GClass70.gclass70_0 == null)
								g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 - 9 + 16 - num, GClass76.int_5 | GClass76.int_0);
							GClass49.gclass49_3.method_10(g, GClass95.smethod_8(int_189), int_4, int_5 - int_58 - 16 - GClass49.gclass49_11.method_20() - 20 - num + 16, GClass49.int_2, GClass49.gclass49_6);
						}
						else
							GClass49.gclass49_3.method_10(g, GClass95.smethod_8(int_189), int_4, int_5 - int_58 - 8 - GClass49.gclass49_11.method_20() - 20 - num + 16, GClass49.int_2, GClass49.gclass49_6);
					}
				}
				else if (gclass90_0.int_0 == 6)
				{
					GClass96.smethod_6(g, 545, int_4, int_5 + 5, 0, GClass76.int_5 | GClass76.int_0);
					if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this) && GClass70.gclass70_0 == null)
						g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 0, int_4, int_5 - int_58 - 9, GClass76.int_5 | GClass76.int_0);
					GClass49.gclass49_3.method_6(g, GClass1.int_39 + string.Empty, int_4, int_5 - int_58 + 19 - GClass49.gclass49_11.method_20(), GClass49.int_2);
				}
				else
				{
					int num2 = gclass90_0.int_1;
					int num3 = gclass90_0.int_3;
					int num4 = gclass90_0.int_2;
					GClass44 gClass = GClass154.gclass44_0[num2];
					GClass44 gClass2 = GClass154.gclass44_0[num3];
					GClass44 gClass3 = GClass154.gclass44_0[num4];
					if (int_12 == 1)
					{
						GClass96.smethod_6(g, gClass.gclass161_0[GClass58.int_94[int_63][0][0]].short_0, int_4 + GClass58.int_94[int_63][0][1] + gClass.gclass161_0[GClass58.int_94[int_63][0][0]].sbyte_0, int_5 - GClass58.int_94[int_63][0][2] + gClass.gclass161_0[GClass58.int_94[int_63][0][0]].sbyte_1, 0, 0);
						GClass96.smethod_6(g, gClass2.gclass161_0[GClass58.int_94[int_63][1][0]].short_0, int_4 + GClass58.int_94[int_63][1][1] + gClass2.gclass161_0[GClass58.int_94[int_63][1][0]].sbyte_0, int_5 - GClass58.int_94[int_63][1][2] + gClass2.gclass161_0[GClass58.int_94[int_63][1][0]].sbyte_1, 0, 0);
						GClass96.smethod_6(g, gClass3.gclass161_0[GClass58.int_94[int_63][2][0]].short_0, int_4 + GClass58.int_94[int_63][2][1] + gClass3.gclass161_0[GClass58.int_94[int_63][2][0]].sbyte_0, int_5 - GClass58.int_94[int_63][2][2] + gClass3.gclass161_0[GClass58.int_94[int_63][2][0]].sbyte_1, 0, 0);
					}
					else
					{
						GClass96.smethod_6(g, gClass.gclass161_0[GClass58.int_94[int_63][0][0]].short_0, int_4 - GClass58.int_94[int_63][0][1] - gClass.gclass161_0[GClass58.int_94[int_63][0][0]].sbyte_0, int_5 - GClass58.int_94[int_63][0][2] + gClass.gclass161_0[GClass58.int_94[int_63][0][0]].sbyte_1, 2, 24);
						GClass96.smethod_6(g, gClass2.gclass161_0[GClass58.int_94[int_63][1][0]].short_0, int_4 - GClass58.int_94[int_63][1][1] - gClass2.gclass161_0[GClass58.int_94[int_63][1][0]].sbyte_0, int_5 - GClass58.int_94[int_63][1][2] + gClass2.gclass161_0[GClass58.int_94[int_63][1][0]].sbyte_1, 2, 24);
						GClass96.smethod_6(g, gClass3.gclass161_0[GClass58.int_94[int_63][2][0]].short_0, int_4 - GClass58.int_94[int_63][2][1] - gClass3.gclass161_0[GClass58.int_94[int_63][2][0]].sbyte_0, int_5 - GClass58.int_94[int_63][2][2] + gClass3.gclass161_0[GClass58.int_94[int_63][2][0]].sbyte_1, 2, 24);
					}
					if (GClass1.int_37 != 51)
					{
						int num5 = 15;
						if (gclass90_0.int_0 == 47)
							num5 = 47;
						if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this))
						{
							if (GClass70.gclass70_0 == null)
							{
								int num6 = 0;
								int num7 = 0;
								if (GClass58.smethod_1().gclass59_0.gclass90_0.int_0 == 28 || GClass58.smethod_1().gclass59_0.gclass90_0.int_0 == 41)
								{
									num6 = 3;
									num7 = -12;
								}
								g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 0, int_4 + num6, int_5 - int_58 - (num5 - 8) + num7, GClass76.int_5 | GClass76.int_0);
							}
						}
						else
						{
							num5 = 8;
							if (gclass90_0.int_0 == 47)
								num5 = 40;
						}
					}
					int_183 = 65;
				}
			}
			if (int_125 < 0 || gclass42_1 == null || sbyte_19 != 0)
				return;
			GClass96.smethod_6(g, gclass42_1.gclass142_0[int_125].int_2, int_4 + gclass42_1.gclass142_0[int_125].int_0, int_5 + gclass42_1.gclass142_0[int_125].int_1 - int_183, 0, GClass76.int_1 | GClass76.int_0);
			if (GClass39.int_8 % 2 == 0)
			{
				int_125++;
				if (int_125 >= gclass42_1.gclass142_0.Length)
					int_125 = 0;
			}
		}
	}

	public void method_166(GClass76 g)
	{
		if (GClass58.bool_35 || bool_81 || !method_77() || int_11 == 15 || gclass90_0 == null)
			return;
		if (gclass90_0.int_0 == 3)
		{
			if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this))
				GClass49.gclass49_15.method_10(g, gclass90_0.string_0, int_4, int_5 - int_58 - GClass49.gclass49_11.method_20() - 5, GClass49.int_2, GClass49.gclass49_16);
			else
				GClass49.gclass49_15.method_10(g, gclass90_0.string_0, int_4, int_5 - int_58 - 3 - GClass49.gclass49_11.method_20(), GClass49.int_2, GClass49.gclass49_16);
			int_183 = 60;
		}
		else
		{
			if (gclass90_0.int_0 == 4)
				return;
			if (gclass90_0.int_0 == 50 || gclass90_0.int_0 == 51)
			{
				if (int_188 != null)
				{
					int num = 0;
					if (GClass96.gclass129_0[int_188[earwrVthdM]] != null && GClass96.gclass129_0[int_188[earwrVthdM]].gclass2_0 != null)
						num = GClass76.smethod_1(GClass96.gclass129_0[int_188[earwrVthdM]].gclass2_0);
					if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this))
						GClass49.gclass49_15.method_10(g, gclass90_0.string_0, int_4, int_5 - int_58 - GClass49.gclass49_11.method_20() - num, GClass49.int_2, GClass49.gclass49_16);
					else
						GClass49.gclass49_15.method_10(g, gclass90_0.string_0, int_4, int_5 - int_58 - 8 - GClass49.gclass49_11.method_20() - num + 16, GClass49.int_2, GClass49.gclass49_16);
				}
				return;
			}
			if (gclass90_0.int_0 == 6)
			{
				if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this))
					GClass49.gclass49_15.method_10(g, gclass90_0.string_0, int_4, int_5 - int_58 - GClass49.gclass49_11.method_20() - 16, GClass49.int_2, GClass49.gclass49_16);
				else
					GClass49.gclass49_15.method_10(g, gclass90_0.string_0, int_4, int_5 - int_58 - 8 - GClass49.gclass49_11.method_20(), GClass49.int_2, GClass49.gclass49_16);
				return;
			}
			if (GClass1.int_37 != 51)
			{
				int num2 = 15;
				if (gclass90_0.int_0 == 47)
					num2 = 47;
				if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this))
				{
					if (GClass1.int_37 != 113)
					{
						int num3 = 0;
						int num4 = 0;
						if (GClass58.smethod_1().gclass59_0.gclass90_0.int_0 == 28 || GClass58.smethod_1().gclass59_0.gclass90_0.int_0 == 41)
						{
							num3 = 3;
							num4 = -12;
						}
						GClass49.gclass49_15.method_10(g, gclass90_0.string_0, int_4 + num3, int_5 - int_58 - GClass49.gclass49_11.method_20() - num2 + num4, GClass49.int_2, GClass49.gclass49_16);
					}
				}
				else
				{
					num2 = 8;
					if (gclass90_0.int_0 == 47)
						num2 = 40;
					if (GClass1.int_37 != 113)
					{
						int num5 = 0;
						int num6 = 0;
						if (gclass90_0.int_0 == 28 || gclass90_0.int_0 == 41)
						{
							num5 = 3;
							num6 = -12;
						}
						GClass49.gclass49_15.method_10(g, gclass90_0.string_0, int_4 + num5, int_5 - int_58 - num2 - GClass49.gclass49_11.method_20() + num6, GClass49.int_2, GClass49.gclass49_16);
					}
				}
			}
			int_183 = 65;
		}
	}

	public void method_167()
	{
		int_11 = 15;
		GClass58.gclass70_0 = null;
	}
}
