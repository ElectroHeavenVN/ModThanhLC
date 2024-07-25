using ns1;

public class GClass130
{
	public static GClass130 gclass130_0;

	public int[][] int_0 = new int[3][];

	public GClass209 gclass209_0 = new GClass209();

	public int int_1;

	public int int_2;

	public int int_3;

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

	public bool bool_0;

	public bool bool_1 = true;

	public int int_14;

	public int int_15;

	public int int_16;

	public GClass118 gclass118_0;

	public bool bool_2;

	public GClass130()
	{
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = new int[3];
		}
	}

	public static GClass130 smethod_0()
	{
		if (gclass130_0 == null)
			gclass130_0 = new GClass130();
		return gclass130_0;
	}

	public void method_0()
	{
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = new int[3];
		}
	}

	public void method_1(GClass193 g)
	{
		if ((Equals(GClass167.gclass130_1) && GClass167.smethod_8().method_95()) || (Equals(GClass167.gclass130_1) && GClass167.smethod_8().gclass200_0 != null) || !GClass167.bool_73 || (GClass14.gclass160_0 != GClass167.smethod_8() && GClass14.gclass160_0 != GClass162.smethod_2()) || GClass88.gclass88_1 != null || !bool_1 || GClass124.bool_33 || (GClass14.gclass113_0.bool_0 && Equals(GClass167.gclass130_1)))
			return;
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass14.int_10, GClass14.int_11);
		if (gclass209_0 != null)
		{
			gclass209_0.method_1(g, int_10, int_5, int_1);
			if (gclass209_0.gclass142_0 == null || gclass209_0.gclass142_0.gclass124_0 == null || gclass118_0 != null || GClass14.bool_5)
				;
			if (gclass209_0.gclass142_0 != null && gclass209_0.gclass142_0.gclass124_0 != null && gclass118_0 != null)
				;
		}
		if (gclass209_0.gclass142_0 != null && gclass209_0.gclass142_0.gclass124_0 == null && int_0 != null)
			GClass72.smethod_6(g, int_0[GClass124.smethod_1().int_14][int_2], int_10, int_5 + 3 + ((GClass14.int_8 % 10 > 5) ? 1 : 0), (int_1 != 1) ? 2 : 0, GClass73.int_6);
		g.method_1(-g.method_3(), -g.method_4());
	}

	public void method_2()
	{
		gclass209_0.method_0();
	}

	public void method_3()
	{
		if (int_5 != int_4)
		{
			int_7 = int_4 - int_5 << 2;
			int_6 += int_7;
			int_5 += int_6 >> 4;
			int_6 &= 15;
		}
		if (int_10 != int_9)
		{
			int_12 = int_9 - int_10 << 2;
			int_11 += int_12;
			int_10 += int_11 >> 4;
			int_11 &= 15;
		}
		int_3++;
		if (int_3 == 5)
		{
			int_3 = 0;
			if (int_2 != 0)
				int_2 = 0;
			else
				int_2 = 1;
		}
	}

	public void method_4(int t)
	{
		int_14 = t;
	}

	public void method_5()
	{
		if (gclass209_0 != null && gclass209_0.gclass122_0 != null && gclass209_0.gclass122_0.method_2() == 0 && int_5 != -40)
		{
			gclass209_0.int_17--;
			if (gclass209_0.int_17 <= 0)
			{
				int_5 = -40;
				gclass209_0.int_16 = 0;
				gclass209_0.gclass122_0.method_9();
				gclass209_0.string_0 = null;
				gclass209_0.int_17 = 200;
			}
		}
		if ((Equals(GClass167.gclass130_1) && GClass167.smethod_8().gclass200_0 != null) || !bool_1)
			return;
		method_3();
		if (gclass209_0 == null || (gclass209_0 != null && gclass209_0.gclass142_0 == null))
			return;
		if (!bool_0)
		{
			if (int_14 > 0)
			{
				int_14--;
				if (int_14 == 0)
				{
					GClass14.gclass113_0.method_31();
					GClass14.gclass113_0.method_50();
				}
			}
			if (GClass14.int_8 % 3 == 0)
			{
				if (GClass124.smethod_1().int_12 == 1)
					int_9 = GClass124.smethod_1().int_4 - 20 - GClass167.int_22;
				if (GClass124.smethod_1().int_12 == -1)
					int_9 = GClass124.smethod_1().int_4 + 20 - GClass167.int_22;
				if (int_9 <= 24)
					int_9 += gclass209_0.int_9 / 2;
				if (int_9 >= GClass14.int_10 - 24)
					int_9 -= gclass209_0.int_9 / 2;
				int_4 = GClass124.smethod_1().int_5 - 40 - GClass167.int_23;
				if (gclass209_0.string_0 != null && int_4 < (gclass209_0.string_0.Length + 1) * 12 + 10)
					int_4 = (gclass209_0.string_0.Length + 1) * 12 + 10;
				if (gclass209_0.gclass142_0.gclass124_0 != null)
				{
					if (GClass14.int_10 - 50 <= 155 + gclass209_0.int_21)
					{
						int_9 = GClass14.int_10 - 20 - gclass209_0.int_21 / 2;
						int_4 = 45 + gclass209_0.int_22;
						if (GClass14.int_10 > GClass14.int_11 || GClass14.int_10 < 220)
						{
							int_9 = GClass14.int_10 - 20 - gclass209_0.int_21 / 2;
							int_4 = gclass209_0.int_22 + 10;
						}
					}
					else
					{
						int_9 = GClass14.int_10 - 60 - gclass209_0.int_21 / 2;
						int_4 = gclass209_0.int_22 + 10;
					}
				}
			}
			if (int_10 <= GClass124.smethod_1().int_4 - GClass167.int_22)
				int_1 = 1;
			else
				int_1 = -1;
		}
		if (gclass209_0.gclass142_0 == null)
			return;
		if (gclass209_0.gclass122_0.method_2() <= 1)
		{
			if (gclass209_0.gclass122_0.method_2() != 1)
				return;
			if (gclass209_0.gclass142_0.int_1 == 0)
			{
				gclass209_0.int_16++;
				if (gclass209_0.int_16 >= gclass209_0.gclass142_0.int_0)
					bool_0 = true;
				if (gclass209_0.int_16 == gclass209_0.gclass142_0.int_0)
				{
					int_4 = -40;
					int_9 = GClass124.smethod_1().int_4 - GClass167.int_22 + ((GClass124.smethod_1().int_12 != 1) ? 20 : (-20));
				}
				if (gclass209_0.int_16 >= gclass209_0.gclass142_0.int_0 + 20)
				{
					gclass209_0.int_16 = 0;
					gclass209_0.gclass122_0.method_9();
					gclass209_0.string_0 = null;
					gclass209_0.int_17 = 200;
				}
			}
			else
			{
				gclass209_0.gclass142_0.long_1 = GClass77.smethod_18();
				if (gclass209_0.gclass142_0.long_1 - gclass209_0.gclass142_0.long_0 >= 100L)
				{
					gclass209_0.gclass142_0.long_0 = GClass77.smethod_18();
					gclass209_0.gclass142_0.int_1--;
				}
				if (gclass209_0.gclass142_0.int_1 == 0)
				{
					bool_0 = true;
					int_4 = -40;
					int_9 = GClass124.smethod_1().int_4 - GClass167.int_22 + ((GClass124.smethod_1().int_12 != 1) ? 20 : (-20));
					gclass209_0.int_16 = 0;
					gclass209_0.gclass122_0.method_9();
					gclass209_0.string_0 = null;
					gclass118_0 = null;
				}
			}
		}
		else if (gclass209_0.gclass142_0.int_1 != 0)
		{
			gclass209_0.gclass142_0.long_1 = GClass77.smethod_18();
			if (gclass209_0.gclass142_0.long_1 - gclass209_0.gclass142_0.long_0 >= 100L)
			{
				gclass209_0.gclass142_0.long_0 = GClass77.smethod_18();
				gclass209_0.gclass142_0.int_1--;
			}
			if (gclass209_0.gclass142_0.int_1 == 0)
			{
				gclass209_0.gclass122_0.method_7(0);
				if (gclass209_0.gclass122_0.method_2() != 0)
				{
					GClass142 gclass142_ = (GClass142)gclass209_0.gclass122_0.method_11();
					gclass209_0.gclass142_0 = gclass142_;
					gclass209_0.method_3();
				}
			}
		}
		else
		{
			gclass209_0.int_16++;
			if (gclass209_0.int_16 >= gclass209_0.gclass142_0.int_0)
			{
				gclass209_0.int_16 = 0;
				gclass209_0.gclass122_0.method_7(0);
				GClass142 gclass142_2 = (GClass142)gclass209_0.gclass122_0.method_11();
				gclass209_0.gclass142_0 = gclass142_2;
				gclass209_0.method_3();
			}
		}
	}

	public void method_6(string s, GClass124 c, bool isChatServer)
	{
		int_15 = c.int_13;
		gclass209_0.method_4(s, 3, c, isChatServer);
		bool_0 = false;
	}

	public void method_7(string s, int Type)
	{
		try
		{
			GClass49.smethod_0().method_6(s);
		}
		catch
		{
		}
		if (s.ToLower().Contains((mResources.language == 0) ? "nhiệm vụ của bạn" : "your mission") || s.ToLower().Contains((mResources.language != 0) ? "not enough power required" : "không đủ sức mạnh yêu cầu"))
			return;
		s = GClass191.smethod_15(s);
		if (gclass209_0.gclass122_0.method_2() > 0 && s.Equals(((GClass142)gclass209_0.gclass122_0.method_12()).string_0))
			return;
		if (gclass209_0.gclass122_0.method_2() > 10)
		{
			for (int i = 0; i < 5; i++)
			{
				gclass209_0.gclass122_0.method_7(0);
			}
		}
		gclass209_0.method_4(s, Type, null, false);
		if (gclass209_0.gclass122_0.method_2() == 1)
		{
			int_5 = 0;
			int_10 = GClass124.smethod_1().int_4 - GClass167.int_22 + ((GClass124.smethod_1().int_12 != 1) ? 20 : (-20));
		}
		bool_0 = false;
	}
}
