using AssemblyCSharp.Functions;

public class GClass52
{
	public static GClass52 gclass52_0;

	public int[][] int_0 = new int[3][];

	public GClass92 gclass92_0 = new GClass92();

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

	public GClass87 gclass87_0;

	public bool bool_2;

	public GClass52()
	{
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = new int[3];
		}
	}

	public static GClass52 smethod_0()
	{
		if (gclass52_0 == null)
			gclass52_0 = new GClass52();
		return gclass52_0;
	}

	public void method_0()
	{
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = new int[3];
		}
	}

	public void method_1(GClass122 g)
	{
		if ((Equals(GClass144.gclass52_1) && GClass144.smethod_8().method_95()) || (Equals(GClass144.gclass52_1) && GClass144.smethod_8().gclass146_0 != null) || !GClass144.bool_73 || (GClass73.gclass131_0 != GClass144.smethod_8() && GClass73.gclass131_0 != GClass141.smethod_2()) || GClass96.gclass96_1 != null || !bool_1 || GClass78.bool_33 || (GClass73.gclass76_0.bool_0 && Equals(GClass144.gclass52_1)))
			return;
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass73.int_10, GClass73.int_11);
		if (gclass92_0 != null)
		{
			gclass92_0.method_1(g, int_10, int_5, int_1);
			if (gclass92_0.gclass16_0 == null || gclass92_0.gclass16_0.gclass78_0 == null || gclass87_0 != null || GClass73.bool_5)
				;
			if (gclass92_0.gclass16_0 != null && gclass92_0.gclass16_0.gclass78_0 != null && gclass87_0 != null)
				;
		}
		if (gclass92_0.gclass16_0 != null && gclass92_0.gclass16_0.gclass78_0 == null && int_0 != null)
			GClass28.smethod_6(g, int_0[GClass78.smethod_1().int_14][int_2], int_10, int_5 + 3 + ((GClass73.int_8 % 10 > 5) ? 1 : 0), (int_1 != 1) ? 2 : 0, GClass188.int_6);
		g.method_1(-g.method_3(), -g.method_4());
	}

	public void method_2()
	{
		gclass92_0.method_0();
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
		if (gclass92_0 != null && gclass92_0.gclass88_0 != null && gclass92_0.gclass88_0.method_2() == 0 && int_5 != -40)
		{
			gclass92_0.int_17--;
			if (gclass92_0.int_17 <= 0)
			{
				int_5 = -40;
				gclass92_0.int_16 = 0;
				gclass92_0.gclass88_0.method_9();
				gclass92_0.string_0 = null;
				gclass92_0.int_17 = 200;
			}
		}
		if ((Equals(GClass144.gclass52_1) && GClass144.smethod_8().gclass146_0 != null) || !bool_1)
			return;
		method_3();
		if (gclass92_0 == null || (gclass92_0 != null && gclass92_0.gclass16_0 == null))
			return;
		if (!bool_0)
		{
			if (int_14 > 0)
			{
				int_14--;
				if (int_14 == 0)
				{
					GClass73.gclass76_0.method_31();
					GClass73.gclass76_0.method_50();
				}
			}
			if (GClass73.int_8 % 3 == 0)
			{
				if (GClass78.smethod_1().int_12 == 1)
					int_9 = GClass78.smethod_1().int_4 - 20 - GClass144.int_22;
				if (GClass78.smethod_1().int_12 == -1)
					int_9 = GClass78.smethod_1().int_4 + 20 - GClass144.int_22;
				if (int_9 <= 24)
					int_9 += gclass92_0.int_9 / 2;
				if (int_9 >= GClass73.int_10 - 24)
					int_9 -= gclass92_0.int_9 / 2;
				int_4 = GClass78.smethod_1().int_5 - 40 - GClass144.int_23;
				if (gclass92_0.string_0 != null && int_4 < (gclass92_0.string_0.Length + 1) * 12 + 10)
					int_4 = (gclass92_0.string_0.Length + 1) * 12 + 10;
				if (gclass92_0.gclass16_0.gclass78_0 != null)
				{
					if (GClass73.int_10 - 50 <= 155 + gclass92_0.int_21)
					{
						int_9 = GClass73.int_10 - 20 - gclass92_0.int_21 / 2;
						int_4 = 45 + gclass92_0.int_22;
						if (GClass73.int_10 > GClass73.int_11 || GClass73.int_10 < 220)
						{
							int_9 = GClass73.int_10 - 20 - gclass92_0.int_21 / 2;
							int_4 = gclass92_0.int_22 + 10;
						}
					}
					else
					{
						int_9 = GClass73.int_10 - 60 - gclass92_0.int_21 / 2;
						int_4 = gclass92_0.int_22 + 10;
					}
				}
			}
			if (int_10 <= GClass78.smethod_1().int_4 - GClass144.int_22)
				int_1 = 1;
			else
				int_1 = -1;
		}
		if (gclass92_0.gclass16_0 == null)
			return;
		if (gclass92_0.gclass88_0.method_2() > 1)
		{
			if (gclass92_0.gclass16_0.int_1 != 0)
			{
				gclass92_0.gclass16_0.long_1 = GClass203.smethod_18();
				if (gclass92_0.gclass16_0.long_1 - gclass92_0.gclass16_0.long_0 >= 100L)
				{
					gclass92_0.gclass16_0.long_0 = GClass203.smethod_18();
					gclass92_0.gclass16_0.int_1--;
				}
				if (gclass92_0.gclass16_0.int_1 == 0)
				{
					gclass92_0.gclass88_0.method_7(0);
					if (gclass92_0.gclass88_0.method_2() != 0)
					{
						GClass16 gclass16_ = (GClass16)gclass92_0.gclass88_0.method_11();
						gclass92_0.gclass16_0 = gclass16_;
						gclass92_0.method_3();
					}
				}
			}
			else
			{
				gclass92_0.int_16++;
				if (gclass92_0.int_16 >= gclass92_0.gclass16_0.int_0)
				{
					gclass92_0.int_16 = 0;
					gclass92_0.gclass88_0.method_7(0);
					GClass16 gclass16_2 = (GClass16)gclass92_0.gclass88_0.method_11();
					gclass92_0.gclass16_0 = gclass16_2;
					gclass92_0.method_3();
				}
			}
		}
		else
		{
			if (gclass92_0.gclass88_0.method_2() != 1)
				return;
			if (gclass92_0.gclass16_0.int_1 == 0)
			{
				gclass92_0.int_16++;
				if (gclass92_0.int_16 >= gclass92_0.gclass16_0.int_0)
					bool_0 = true;
				if (gclass92_0.int_16 == gclass92_0.gclass16_0.int_0)
				{
					int_4 = -40;
					int_9 = GClass78.smethod_1().int_4 - GClass144.int_22 + ((GClass78.smethod_1().int_12 != 1) ? 20 : (-20));
				}
				if (gclass92_0.int_16 >= gclass92_0.gclass16_0.int_0 + 20)
				{
					gclass92_0.int_16 = 0;
					gclass92_0.gclass88_0.method_9();
					gclass92_0.string_0 = null;
					gclass92_0.int_17 = 200;
				}
			}
			else
			{
				gclass92_0.gclass16_0.long_1 = GClass203.smethod_18();
				if (gclass92_0.gclass16_0.long_1 - gclass92_0.gclass16_0.long_0 >= 100L)
				{
					gclass92_0.gclass16_0.long_0 = GClass203.smethod_18();
					gclass92_0.gclass16_0.int_1--;
				}
				if (gclass92_0.gclass16_0.int_1 == 0)
				{
					bool_0 = true;
					int_4 = -40;
					int_9 = GClass78.smethod_1().int_4 - GClass144.int_22 + ((GClass78.smethod_1().int_12 != 1) ? 20 : (-20));
					gclass92_0.int_16 = 0;
					gclass92_0.gclass88_0.method_9();
					gclass92_0.string_0 = null;
					gclass87_0 = null;
				}
			}
		}
	}

	public void method_6(string s, GClass78 c, bool isChatServer)
	{
		int_15 = c.int_13;
		gclass92_0.method_4(s, 3, c, isChatServer);
		bool_0 = false;
	}

	public void method_7(string s, int Type)
	{
		try
		{
			GClass171.smethod_0().method_6(s);
		}
		catch
		{
		}
		if (s.ToLower().Contains((mResources.language == 0) ? "nhiệm vụ của bạn" : "your mission") || s.ToLower().Contains((mResources.language != 0) ? "not enough power required" : "không đủ sức mạnh yêu cầu"))
			return;
		s = GClass50.smethod_15(s);
		if (gclass92_0.gclass88_0.method_2() > 0 && s.Equals(((GClass16)gclass92_0.gclass88_0.method_12()).string_0))
			return;
		if (gclass92_0.gclass88_0.method_2() > 10)
		{
			for (int i = 0; i < 5; i++)
			{
				gclass92_0.gclass88_0.method_7(0);
			}
		}
		gclass92_0.method_4(s, Type, null, false);
		if (gclass92_0.gclass88_0.method_2() == 1)
		{
			int_5 = 0;
			int_10 = GClass78.smethod_1().int_4 - GClass144.int_22 + ((GClass78.smethod_1().int_12 != 1) ? 20 : (-20));
		}
		bool_0 = false;
	}
}
