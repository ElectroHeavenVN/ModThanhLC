using ns1;

public class GClass36
{
	public static GClass122 gclass122_0 = new GClass122();

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public static GClass20[] gclass20_0 = new GClass20[5];

	public static GClass20 gclass20_1;

	public bool bool_1;

	public bool bool_2;

	private bool bool_3;

	public bool bool_4;

	private bool bool_5;

	private int int_8;

	private int int_9 = 1;

	private int int_10;

	private int int_11;

	private bool bool_6;

	private bool bool_7;

	public GClass36(int x, int y, int headId, int dir, int type, bool isMe, int planet)
	{
		int_0 = x;
		int_1 = 5;
		int_4 = y;
		int_2 = headId;
		int_3 = type;
		bool_0 = isMe;
		int_6 = dir;
		int_7 = planet;
		int_8 = 0;
		int num = 0;
		while (num < 100)
		{
			num++;
			int_4 += 12;
			if (GClass137.smethod_28(x, int_4, 2))
			{
				if (int_4 % 24 != 0)
					int_4 -= int_4 % 24;
				break;
			}
		}
		bool_2 = true;
		bool_1 = false;
		if (int_7 > 2)
		{
			int_4 += 4;
			if (gclass20_0[3] == null)
				gclass20_0[3] = GClass14.smethod_43("/mainImage/myTexture2dmaybay4a.png");
			if (gclass20_0[4] == null)
				gclass20_0[4] = GClass14.smethod_43("/mainImage/myTexture2dmaybay4b.png");
			if (gclass20_1 == null)
				gclass20_1 = GClass14.smethod_43("/mainImage/hole.png");
		}
		else if (gclass20_0[planet] == null)
		{
			gclass20_0[planet] = GClass14.smethod_43("/mainImage/myTexture2dmaybay" + (planet + 1) + ".png");
		}
		if (x > GClass167.int_22 && x < GClass167.int_22 + GClass14.int_10 && int_4 > 100 && !GClass147.smethod_1().method_47() && !GClass147.smethod_1().method_46())
		{
			bool_3 = true;
			GClass147.smethod_1().method_48();
		}
	}

	public static void smethod_0(GClass36 p)
	{
		gclass122_0.method_0(p);
	}

	public void method_0(GClass193 g)
	{
		if (int_7 > 2 && bool_6)
			g.method_31(gclass20_1, int_0, int_4 + 20, GClass73.int_3);
	}

	public void method_1(GClass193 g)
	{
		if (GClass124.bool_35 || int_0 < GClass167.int_22 || int_0 > GClass167.int_22 + GClass14.int_10)
			return;
		GClass29 gClass = GClass167.gclass29_0[int_2];
		int num = 0;
		int num2 = 0;
		if (int_7 == 0)
		{
			num = 15;
			num2 = 40;
		}
		if (int_7 == 1)
		{
			num = 7;
			num2 = 55;
		}
		if (int_7 == 2)
		{
			num = 18;
			num2 = 52;
		}
		if (bool_5 && int_7 < 3)
			GClass72.smethod_6(g, gClass.gclass21_0[GClass124.int_94[0][0][0]].short_0, int_0 + ((int_6 != 1) ? (-num) : num), int_1 - num2, (int_6 != 1) ? 2 : 0, GClass73.int_0);
		if (int_7 >= 3)
		{
			if (bool_2)
			{
				if (int_8 > 10)
					g.method_23(gclass20_0[4], 0, 0, GClass193.smethod_0(gclass20_0[4]), GClass193.smethod_1(gclass20_0[4]), (int_6 == 1) ? 2 : 0, (int_6 != 1) ? (int_0 + 11) : (int_0 - 11), int_1 + 2, GClass73.int_3);
				else
					g.method_23(gclass20_0[3], 0, 0, GClass193.smethod_0(gclass20_0[3]), GClass193.smethod_1(gclass20_0[3]), (int_6 == 1) ? 2 : 0, int_0, int_1, GClass73.int_3);
			}
			else if (int_8 >= 20)
			{
				g.method_23(gclass20_0[3], 0, 0, GClass193.smethod_0(gclass20_0[3]), GClass193.smethod_1(gclass20_0[3]), (int_6 == 1) ? 2 : 0, int_0, int_1, GClass73.int_3);
			}
			else
			{
				g.method_23(gclass20_0[4], 0, 0, GClass193.smethod_0(gclass20_0[4]), GClass193.smethod_1(gclass20_0[4]), (int_6 == 1) ? 2 : 0, (int_6 != 1) ? (int_0 + 11) : (int_0 - 11), int_1 + 2, GClass73.int_3);
			}
		}
		else
			g.method_23(gclass20_0[int_7], 0, 0, GClass193.smethod_0(gclass20_0[int_7]), GClass193.smethod_1(gclass20_0[int_7]), (int_6 == 1) ? 2 : 0, int_0, int_1, GClass73.int_3);
	}

	public void method_2()
	{
		if (GClass57.smethod_0().method_4(this))
			return;
		if (int_7 > 2 && bool_4 && int_1 != -80)
		{
			if (bool_2 && int_8 == 0)
			{
				if (GClass14.int_8 % 3 == 0)
					GClass91.smethod_1(1, int_0, int_1, 1, 0);
			}
			else if (bool_1 && GClass14.int_8 % 3 == 0)
			{
				GClass91.smethod_1(1, int_0, int_1 + 16, 1, 1);
			}
		}
		int_10++;
		if (int_10 > 3)
			int_10 = 0;
		if (!bool_2)
		{
			if (bool_1)
			{
				int_8++;
				if (int_8 > 30)
				{
					int num = int_4 + 24 - int_1 >> 3;
					if (num > 30)
						num = 30;
					int_1 -= num;
					bool_4 = true;
				}
				else
				{
					if (int_8 == 14 && bool_3)
						GClass147.smethod_1().method_50();
					if (int_8 > 0 && int_3 == 0)
					{
						if (bool_0)
						{
							GClass124.smethod_1().bool_2 = false;
							if (GClass124.smethod_1().int_11 != 14)
								GClass124.smethod_1().int_11 = 3;
							GClass124.smethod_1().int_7 = -3;
						}
						else if (GClass167.smethod_14(int_5) != null)
						{
							GClass167.smethod_14(int_5).bool_2 = false;
							if (GClass167.smethod_14(int_5).int_11 != 14)
								GClass167.smethod_14(int_5).int_11 = 3;
							GClass167.smethod_14(int_5).int_7 = -3;
						}
						bool_5 = false;
					}
					if (int_8 > 12 && int_3 == 0)
					{
						if (bool_0)
							GClass124.smethod_1().bool_2 = true;
						else if (GClass167.smethod_14(int_5) != null)
						{
							GClass167.smethod_14(int_5).int_4 = int_0;
							GClass167.smethod_14(int_5).int_5 = int_1;
							GClass167.smethod_14(int_5).bool_2 = true;
						}
						bool_5 = true;
					}
				}
				if (bool_0)
				{
					if (int_3 == 0)
					{
						GClass167.int_28 = int_0 - GClass167.int_8;
						GClass167.int_29 = int_1 - GClass167.int_14;
					}
					if (int_3 == 1)
						GClass167.gclass130_0.bool_1 = true;
				}
				if (int_1 <= -80)
				{
					if (bool_0 && int_3 == 0)
					{
						GClass93.bool_5 = false;
						GClass124.bool_33 = true;
					}
					if (!bool_0 && GClass167.smethod_14(int_5) != null && int_3 == 0)
						GClass167.gclass122_5.method_8(GClass167.smethod_14(int_5));
					if (int_7 >= 3)
					{
						int_1 = -80;
						int_11++;
						if (int_11 > 80)
						{
							int_11 = 0;
							gclass122_0.method_8(this);
						}
					}
					else
						gclass122_0.method_8(this);
				}
			}
		}
		else
		{
			bool_4 = true;
			bool_5 = ((int_3 != 0) ? true : false);
			if (int_7 < 3)
			{
				int num2 = int_4 - int_1 >> 3;
				if (num2 < 1)
				{
					num2 = 1;
					bool_4 = false;
				}
				int_1 += num2;
			}
			else
			{
				if (GClass14.int_8 % 2 == 0)
					int_9++;
				if (int_4 - int_1 >= int_9)
					int_1 += int_9;
				else
				{
					int_1 = int_4;
					bool_4 = false;
				}
			}
			if (bool_0 && int_3 == 1 && GClass124.smethod_1().bool_2)
			{
				GClass124.smethod_1().int_4 = int_0;
				GClass124.smethod_1().int_5 = int_1 - 30;
				GClass124.smethod_1().int_11 = 4;
				GClass167.int_28 = int_0 - GClass167.int_8;
				GClass167.int_29 = int_1 - GClass167.int_14;
				GClass167.gclass130_0.bool_1 = false;
			}
			if (GClass167.smethod_14(int_5) != null && !bool_0 && int_3 == 1 && GClass167.smethod_14(int_5).bool_2)
			{
				GClass167.smethod_14(int_5).int_4 = int_0;
				GClass167.smethod_14(int_5).int_5 = int_1 - 30;
				GClass167.smethod_14(int_5).int_11 = 4;
			}
			if (GClass191.smethod_28(int_1 - int_4) < 50 && GClass137.smethod_28(int_0, int_1, 2))
			{
				bool_6 = true;
				if (int_7 < 3)
				{
					GClass147.smethod_1().method_49();
					if (int_1 % 24 != 0)
						int_1 -= int_1 % 24;
					int_8++;
					if (int_8 > 10)
					{
						int_8 = 0;
						bool_2 = false;
						bool_1 = true;
						bool_4 = false;
					}
					if (int_3 == 1)
					{
						if (!bool_0)
						{
							if (GClass167.smethod_14(int_5) != null)
								GClass167.smethod_14(int_5).bool_2 = false;
						}
						else
							GClass124.smethod_1().bool_2 = false;
						bool_5 = false;
					}
				}
				else
				{
					int_1 = int_4;
					if (!bool_7)
					{
						GClass91.smethod_1(92, int_0 + 4, int_1 + 14, 1, 0);
						GClass167.int_120 = 10;
						bool_7 = true;
					}
					int_8++;
					if (int_8 > 30)
					{
						int_8 = 0;
						bool_2 = false;
						bool_1 = true;
						bool_4 = false;
					}
					if (int_3 == 1)
					{
						if (!bool_0)
						{
							if (GClass167.smethod_14(int_5) != null)
								GClass167.smethod_14(int_5).bool_2 = false;
						}
						else
							GClass124.smethod_1().bool_2 = false;
						bool_5 = false;
					}
				}
			}
		}
		if (bool_4 && int_7 < 3 && GClass191.smethod_28(int_1 - int_4) <= 50 && GClass14.int_8 % 5 == 0)
			GClass98.smethod_0(new GClass85(19, int_0, int_4 + 20, 2, 1, -1));
	}
}
