using ns1;

public class GClass210
{
	public static GClass210 gclass210_0;

	public int[][] int_0 = new int[3][];

	public GClass205 gclass205_0 = new GClass205();

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

	public GClass14 gclass14_0;

	public bool bool_2;

	public GClass210()
	{
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = new int[3];
		}
	}

	public static GClass210 smethod_0()
	{
		if (gclass210_0 == null)
			gclass210_0 = new GClass210();
		return gclass210_0;
	}

	public void method_0()
	{
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = new int[3];
		}
	}

	public void method_1(GClass76 g)
	{
		if ((Equals(GClass154.gclass210_1) && GClass154.smethod_8().method_93()) || (Equals(GClass154.gclass210_1) && GClass154.smethod_8().gclass52_0 != null) || !GClass154.bool_72 || (GClass39.gclass145_0 != GClass154.smethod_8() && GClass39.gclass145_0 != GClass150.smethod_2()) || GClass70.gclass70_1 != null || !bool_1 || GClass58.bool_33 || (GClass39.gclass45_0.bool_0 && Equals(GClass154.gclass210_1)))
			return;
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		if (gclass205_0 != null)
		{
			gclass205_0.method_1(g, int_10, int_5, int_1);
			if (gclass205_0.gclass43_0 == null || gclass205_0.gclass43_0.gclass58_0 == null || gclass14_0 != null || !GClass39.bool_5)
				;
			if (gclass205_0.gclass43_0 != null && gclass205_0.gclass43_0.gclass58_0 != null && gclass14_0 != null)
				;
		}
		if (gclass205_0.gclass43_0 != null && gclass205_0.gclass43_0.gclass58_0 == null && int_0 != null)
			GClass96.smethod_6(g, int_0[GClass58.smethod_1().int_14][int_2], int_10, int_5 + 3 + ((GClass39.int_8 % 10 > 5) ? 1 : 0), (int_1 != 1) ? 2 : 0, GClass169.int_6);
		g.method_1(-g.method_3(), -g.method_4());
	}

	public void method_2()
	{
		gclass205_0.method_0();
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
			if (int_2 == 0)
				int_2 = 1;
			else
				int_2 = 0;
		}
	}

	public void method_4(int t)
	{
		int_14 = t;
	}

	public void method_5()
	{
		if (gclass205_0 != null && gclass205_0.gclass63_0 != null && gclass205_0.gclass63_0.method_2() == 0 && int_5 != -40)
		{
			gclass205_0.int_17--;
			if (gclass205_0.int_17 <= 0)
			{
				int_5 = -40;
				gclass205_0.int_16 = 0;
				gclass205_0.gclass63_0.method_9();
				gclass205_0.string_0 = null;
				gclass205_0.int_17 = 200;
			}
		}
		if ((Equals(GClass154.gclass210_1) && GClass154.smethod_8().gclass52_0 != null) || !bool_1)
			return;
		method_3();
		if (gclass205_0 == null || (gclass205_0 != null && gclass205_0.gclass43_0 == null))
			return;
		if (!bool_0)
		{
			if (int_14 > 0)
			{
				int_14--;
				if (int_14 == 0)
				{
					GClass39.gclass45_0.method_31();
					GClass39.gclass45_0.method_50();
				}
			}
			if (GClass39.int_8 % 3 == 0)
			{
				if (GClass58.smethod_1().int_12 == 1)
					int_9 = GClass58.smethod_1().int_4 - 20 - GClass154.int_22;
				if (GClass58.smethod_1().int_12 == -1)
					int_9 = GClass58.smethod_1().int_4 + 20 - GClass154.int_22;
				if (int_9 <= 24)
					int_9 += gclass205_0.int_9 / 2;
				if (int_9 >= GClass39.int_10 - 24)
					int_9 -= gclass205_0.int_9 / 2;
				int_4 = GClass58.smethod_1().int_5 - 40 - GClass154.int_23;
				if (gclass205_0.string_0 != null && int_4 < (gclass205_0.string_0.Length + 1) * 12 + 10)
					int_4 = (gclass205_0.string_0.Length + 1) * 12 + 10;
				if (gclass205_0.gclass43_0.gclass58_0 != null)
				{
					if (GClass39.int_10 - 50 > 155 + gclass205_0.int_21)
					{
						int_9 = GClass39.int_10 - 60 - gclass205_0.int_21 / 2;
						int_4 = gclass205_0.int_22 + 10;
					}
					else
					{
						int_9 = GClass39.int_10 - 20 - gclass205_0.int_21 / 2;
						int_4 = 45 + gclass205_0.int_22;
						if (GClass39.int_10 > GClass39.int_11 || GClass39.int_10 < 220)
						{
							int_9 = GClass39.int_10 - 20 - gclass205_0.int_21 / 2;
							int_4 = gclass205_0.int_22 + 10;
						}
					}
				}
			}
			if (int_10 > GClass58.smethod_1().int_4 - GClass154.int_22)
				int_1 = -1;
			else
				int_1 = 1;
		}
		if (gclass205_0.gclass43_0 == null)
			return;
		if (gclass205_0.gclass63_0.method_2() > 1)
		{
			if (gclass205_0.gclass43_0.int_1 == 0)
			{
				gclass205_0.int_16++;
				if (gclass205_0.int_16 >= gclass205_0.gclass43_0.int_0)
				{
					gclass205_0.int_16 = 0;
					gclass205_0.gclass63_0.method_7(0);
					GClass43 gclass43_ = (GClass43)gclass205_0.gclass63_0.method_11();
					gclass205_0.gclass43_0 = gclass43_;
					gclass205_0.method_3();
				}
				return;
			}
			gclass205_0.gclass43_0.long_1 = GClass138.smethod_18();
			if (gclass205_0.gclass43_0.long_1 - gclass205_0.gclass43_0.long_0 >= 100L)
			{
				gclass205_0.gclass43_0.long_0 = GClass138.smethod_18();
				gclass205_0.gclass43_0.int_1--;
			}
			if (gclass205_0.gclass43_0.int_1 == 0)
			{
				gclass205_0.gclass63_0.method_7(0);
				if (gclass205_0.gclass63_0.method_2() != 0)
				{
					GClass43 gclass43_2 = (GClass43)gclass205_0.gclass63_0.method_11();
					gclass205_0.gclass43_0 = gclass43_2;
					gclass205_0.method_3();
				}
			}
		}
		else
		{
			if (gclass205_0.gclass63_0.method_2() != 1)
				return;
			if (gclass205_0.gclass43_0.int_1 == 0)
			{
				gclass205_0.int_16++;
				if (gclass205_0.int_16 >= gclass205_0.gclass43_0.int_0)
					bool_0 = true;
				if (gclass205_0.int_16 == gclass205_0.gclass43_0.int_0)
				{
					int_4 = -40;
					int_9 = GClass58.smethod_1().int_4 - GClass154.int_22 + ((GClass58.smethod_1().int_12 != 1) ? 20 : (-20));
				}
				if (gclass205_0.int_16 >= gclass205_0.gclass43_0.int_0 + 20)
				{
					gclass205_0.int_16 = 0;
					gclass205_0.gclass63_0.method_9();
					gclass205_0.string_0 = null;
					gclass205_0.int_17 = 200;
				}
			}
			else
			{
				gclass205_0.gclass43_0.long_1 = GClass138.smethod_18();
				if (gclass205_0.gclass43_0.long_1 - gclass205_0.gclass43_0.long_0 >= 100L)
				{
					gclass205_0.gclass43_0.long_0 = GClass138.smethod_18();
					gclass205_0.gclass43_0.int_1--;
				}
				if (gclass205_0.gclass43_0.int_1 == 0)
				{
					bool_0 = true;
					int_4 = -40;
					int_9 = GClass58.smethod_1().int_4 - GClass154.int_22 + ((GClass58.smethod_1().int_12 != 1) ? 20 : (-20));
					gclass205_0.int_16 = 0;
					gclass205_0.gclass63_0.method_9();
					gclass205_0.string_0 = null;
					gclass14_0 = null;
				}
			}
		}
	}

	public void method_6(string s, GClass58 c, bool isChatServer)
	{
		int_15 = c.int_13;
		gclass205_0.method_4(s, 3, c, isChatServer);
		bool_0 = false;
	}

	public void method_7(string s, int Type)
	{
		try
		{
			GClass172.smethod_0().method_6(s);
		}
		catch
		{
		}
		if (s.ToLower().Contains((mResources.language == 0) ? "nhiệm vụ của bạn" : "your mission"))
			return;
		s = GClass56.smethod_15(s);
		if (gclass205_0.gclass63_0.method_2() > 0 && s.Equals(((GClass43)gclass205_0.gclass63_0.method_12()).string_0))
			return;
		if (gclass205_0.gclass63_0.method_2() > 10)
		{
			for (int i = 0; i < 5; i++)
			{
				gclass205_0.gclass63_0.method_7(0);
			}
		}
		gclass205_0.method_4(s, Type, null, false);
		if (gclass205_0.gclass63_0.method_2() == 1)
		{
			int_5 = 0;
			int_10 = GClass58.smethod_1().int_4 - GClass154.int_22 + ((GClass58.smethod_1().int_12 != 1) ? 20 : (-20));
		}
		bool_0 = false;
	}
}
