using ns1;

public class GClass202
{
	public static GClass63 gclass63_0 = new GClass63();

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public static GClass2[] gclass2_0 = new GClass2[5];

	public static GClass2 gclass2_1;

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

	public GClass202(int x, int y, int headId, int dir, int type, bool isMe, int planet)
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
			if (GClass1.smethod_27(x, int_4, 2))
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
			if (gclass2_0[3] == null)
				gclass2_0[3] = GClass39.smethod_43("/mainImage/myTexture2dmaybay4a.png");
			if (gclass2_0[4] == null)
				gclass2_0[4] = GClass39.smethod_43("/mainImage/myTexture2dmaybay4b.png");
			if (gclass2_1 == null)
				gclass2_1 = GClass39.smethod_43("/mainImage/hole.png");
		}
		else if (gclass2_0[planet] == null)
		{
			gclass2_0[planet] = GClass39.smethod_43("/mainImage/myTexture2dmaybay" + (planet + 1) + ".png");
		}
		if (x > GClass154.int_22 && x < GClass154.int_22 + GClass39.int_10 && int_4 > 100 && !GClass29.smethod_1().method_47() && !GClass29.smethod_1().method_46())
		{
			bool_3 = true;
			GClass29.smethod_1().method_48();
		}
	}

	public static void smethod_0(GClass202 p)
	{
		gclass63_0.method_0(p);
	}

	public void method_0(GClass76 g)
	{
		if (int_7 > 2 && bool_6)
			g.method_31(gclass2_1, int_0, int_4 + 20, GClass169.int_3);
	}

	public void method_1(GClass76 g)
	{
		if (GClass58.bool_35 || int_0 < GClass154.int_22 || int_0 > GClass154.int_22 + GClass39.int_10)
			return;
		GClass44 gClass = GClass154.gclass44_0[int_2];
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
			GClass96.smethod_6(g, gClass.gclass161_0[GClass58.int_94[0][0][0]].short_0, int_0 + ((int_6 != 1) ? (-num) : num), int_1 - num2, (int_6 != 1) ? 2 : 0, GClass169.int_0);
		if (int_7 < 3)
			g.method_23(gclass2_0[int_7], 0, 0, GClass76.smethod_0(gclass2_0[int_7]), GClass76.smethod_1(gclass2_0[int_7]), (int_6 == 1) ? 2 : 0, int_0, int_1, GClass169.int_3);
		else if (bool_2)
		{
			if (int_8 > 10)
				g.method_23(gclass2_0[4], 0, 0, GClass76.smethod_0(gclass2_0[4]), GClass76.smethod_1(gclass2_0[4]), (int_6 == 1) ? 2 : 0, (int_6 != 1) ? (int_0 + 11) : (int_0 - 11), int_1 + 2, GClass169.int_3);
			else
				g.method_23(gclass2_0[3], 0, 0, GClass76.smethod_0(gclass2_0[3]), GClass76.smethod_1(gclass2_0[3]), (int_6 == 1) ? 2 : 0, int_0, int_1, GClass169.int_3);
		}
		else if (int_8 < 20)
		{
			g.method_23(gclass2_0[4], 0, 0, GClass76.smethod_0(gclass2_0[4]), GClass76.smethod_1(gclass2_0[4]), (int_6 == 1) ? 2 : 0, (int_6 != 1) ? (int_0 + 11) : (int_0 - 11), int_1 + 2, GClass169.int_3);
		}
		else
		{
			g.method_23(gclass2_0[3], 0, 0, GClass76.smethod_0(gclass2_0[3]), GClass76.smethod_1(gclass2_0[3]), (int_6 == 1) ? 2 : 0, int_0, int_1, GClass169.int_3);
		}
	}

	public void method_2()
	{
		if (GClass171.smethod_0().method_4(this))
			return;
		if (int_7 > 2 && bool_4 && int_1 != -80)
		{
			if (bool_2 && int_8 == 0)
			{
				if (GClass39.int_8 % 3 == 0)
					GClass71.smethod_1(1, int_0, int_1, 1, 0);
			}
			else if (bool_1 && GClass39.int_8 % 3 == 0)
			{
				GClass71.smethod_1(1, int_0, int_1 + 16, 1, 1);
			}
		}
		int_10++;
		if (int_10 > 3)
			int_10 = 0;
		if (bool_2)
		{
			bool_4 = true;
			bool_5 = ((int_3 != 0) ? true : false);
			if (int_7 < 3)
			{
				int num = int_4 - int_1 >> 3;
				if (num < 1)
				{
					num = 1;
					bool_4 = false;
				}
				int_1 += num;
			}
			else
			{
				if (GClass39.int_8 % 2 == 0)
					int_9++;
				if (int_4 - int_1 < int_9)
				{
					int_1 = int_4;
					bool_4 = false;
				}
				else
					int_1 += int_9;
			}
			if (bool_0 && int_3 == 1 && GClass58.smethod_1().bool_2)
			{
				GClass58.smethod_1().int_4 = int_0;
				GClass58.smethod_1().int_5 = int_1 - 30;
				GClass58.smethod_1().int_11 = 4;
				GClass154.int_28 = int_0 - GClass154.int_8;
				GClass154.int_29 = int_1 - GClass154.int_14;
				GClass154.gclass210_0.bool_1 = false;
			}
			if (GClass154.smethod_14(int_5) != null && !bool_0 && int_3 == 1 && GClass154.smethod_14(int_5).bool_2)
			{
				GClass154.smethod_14(int_5).int_4 = int_0;
				GClass154.smethod_14(int_5).int_5 = int_1 - 30;
				GClass154.smethod_14(int_5).int_11 = 4;
			}
			if (GClass56.smethod_28(int_1 - int_4) < 50 && GClass1.smethod_27(int_0, int_1, 2))
			{
				bool_6 = true;
				if (int_7 < 3)
				{
					GClass29.smethod_1().method_49();
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
						if (bool_0)
							GClass58.smethod_1().bool_2 = false;
						else if (GClass154.smethod_14(int_5) != null)
						{
							GClass154.smethod_14(int_5).bool_2 = false;
						}
						bool_5 = false;
					}
				}
				else
				{
					int_1 = int_4;
					if (!bool_7)
					{
						GClass71.smethod_1(92, int_0 + 4, int_1 + 14, 1, 0);
						GClass154.int_118 = 10;
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
						if (bool_0)
							GClass58.smethod_1().bool_2 = false;
						else if (GClass154.smethod_14(int_5) != null)
						{
							GClass154.smethod_14(int_5).bool_2 = false;
						}
						bool_5 = false;
					}
				}
			}
		}
		else if (bool_1)
		{
			int_8++;
			if (int_8 > 30)
			{
				int num2 = int_4 + 24 - int_1 >> 3;
				if (num2 > 30)
					num2 = 30;
				int_1 -= num2;
				bool_4 = true;
			}
			else
			{
				if (int_8 == 14 && bool_3)
					GClass29.smethod_1().method_50();
				if (int_8 > 0 && int_3 == 0)
				{
					if (bool_0)
					{
						GClass58.smethod_1().bool_2 = false;
						if (GClass58.smethod_1().int_11 != 14)
							GClass58.smethod_1().int_11 = 3;
						GClass58.smethod_1().int_7 = -3;
					}
					else if (GClass154.smethod_14(int_5) != null)
					{
						GClass154.smethod_14(int_5).bool_2 = false;
						if (GClass154.smethod_14(int_5).int_11 != 14)
							GClass154.smethod_14(int_5).int_11 = 3;
						GClass154.smethod_14(int_5).int_7 = -3;
					}
					bool_5 = false;
				}
				if (int_8 > 12 && int_3 == 0)
				{
					if (bool_0)
						GClass58.smethod_1().bool_2 = true;
					else if (GClass154.smethod_14(int_5) != null)
					{
						GClass154.smethod_14(int_5).int_4 = int_0;
						GClass154.smethod_14(int_5).int_5 = int_1;
						GClass154.smethod_14(int_5).bool_2 = true;
					}
					bool_5 = true;
				}
			}
			if (bool_0)
			{
				if (int_3 == 0)
				{
					GClass154.int_28 = int_0 - GClass154.int_8;
					GClass154.int_29 = int_1 - GClass154.int_14;
				}
				if (int_3 == 1)
					GClass154.gclass210_0.bool_1 = true;
			}
			if (int_1 <= -80)
			{
				if (bool_0 && int_3 == 0)
				{
					GClass65.bool_5 = false;
					GClass58.bool_33 = true;
				}
				if (!bool_0 && GClass154.smethod_14(int_5) != null && int_3 == 0)
					GClass154.gclass63_5.method_8(GClass154.smethod_14(int_5));
				if (int_7 < 3)
					gclass63_0.method_8(this);
				else
				{
					int_1 = -80;
					int_11++;
					if (int_11 > 80)
					{
						int_11 = 0;
						gclass63_0.method_8(this);
					}
				}
			}
		}
		if (bool_4 && int_7 < 3 && GClass56.smethod_28(int_1 - int_4) <= 50 && GClass39.int_8 % 5 == 0)
			GClass81.smethod_0(new GClass33(19, int_0, int_4 + 20, 2, 1, -1));
	}
}
