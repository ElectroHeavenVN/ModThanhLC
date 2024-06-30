using System;

public class GClass151 : GClass145, GInterface0
{
	public GClass14[] gclass14_4;

	public static GClass209[] gclass209_0;

	private int int_6;

	private int[] int_7 = new int[2]
	{
		GClass39.int_10 / 2 - 100,
		GClass39.int_10 / 2 - 100
	};

	private int int_8;

	private int[] int_9 = new int[2];

	private int[] int_10 = new int[4]
	{
		GClass39.int_10 / 2 - 150,
		GClass39.int_11 / 2 - 100,
		300,
		200
	};

	private int int_11 = -35;

	private int int_12 = -35;

	public override void switchToMe()
	{
		GClass152.bool_1 = false;
		GClass58.bool_35 = false;
		GClass149.bool_0 = false;
		GClass152.bool_3 = false;
		GClass154.smethod_8().method_0();
		base.switchToMe();
	}

	public override void update()
	{
		if (GClass39.int_8 % 10 > 2)
			int_6 = 1;
		else
			int_6 = 0;
		for (int i = 0; i < gclass14_4.Length; i++)
		{
			if (gclass14_4[i].method_4())
				gclass14_4[i].method_1();
		}
		for (int j = 0; j < int_7.Length; j++)
		{
			if (GClass39.smethod_24(int_7[j] + int_12, int_9[j] + int_11, int_10[2], 60))
			{
				if (GClass39.bool_14)
				{
					int_8 = j;
					break;
				}
				if (GClass39.bool_16 && GClass39.bool_15)
					;
			}
		}
		base.update();
	}

	public override void paint(GClass76 g)
	{
		GClass39.smethod_18(g);
		try
		{
			GClass24.smethod_4(g, int_10[0] - 10, int_10[1], int_10[2] + 20, int_10[3], 16777215, true);
			if (gclass14_4 != null)
			{
				for (int i = 0; i < gclass14_4.Length; i++)
				{
					gclass14_4[i].method_3(g);
				}
			}
			if (gclass209_0 != null)
			{
				for (int j = 0; j < gclass209_0.Length; j++)
				{
					GClass24.smethod_4(g, int_7[j] - 20, int_9[j] + int_11, int_10[2], 60, 16777215, false);
					GClass44 gClass = GClass154.gclass44_0[gclass209_0[j].short_0];
					GClass44 gClass2 = GClass154.gclass44_0[gclass209_0[j].short_2];
					GClass44 gClass3 = GClass154.gclass44_0[gclass209_0[j].short_1];
					GClass96.smethod_6(g, gClass.gclass161_0[GClass58.int_94[int_6][0][0]].short_0, int_7[j] + GClass58.int_94[int_6][0][1] + gClass.gclass161_0[GClass58.int_94[int_6][0][0]].sbyte_0, int_9[j] - GClass58.int_94[int_6][0][2] + gClass.gclass161_0[GClass58.int_94[int_6][0][0]].sbyte_1, 0, 0);
					GClass96.smethod_6(g, gClass2.gclass161_0[GClass58.int_94[int_6][1][0]].short_0, int_7[j] + GClass58.int_94[int_6][1][1] + gClass2.gclass161_0[GClass58.int_94[int_6][1][0]].sbyte_0, int_9[j] - GClass58.int_94[int_6][1][2] + gClass2.gclass161_0[GClass58.int_94[int_6][1][0]].sbyte_1, 0, 0);
					GClass96.smethod_6(g, gClass3.gclass161_0[GClass58.int_94[int_6][2][0]].short_0, int_7[j] + GClass58.int_94[int_6][2][1] + gClass3.gclass161_0[GClass58.int_94[int_6][2][0]].sbyte_0, int_9[j] - GClass58.int_94[int_6][2][2] + gClass3.gclass161_0[GClass58.int_94[int_6][2][0]].sbyte_1, 0, 0);
					if (int_8 == j)
					{
						GClass49.gclass49_4.method_6(g, gclass209_0[j].string_0, int_7[j] + int_10[2] - 25, int_9[j] + int_11, 1);
						GClass49.gclass49_4.method_6(g, mResources.power_point + " " + GClass56.smethod_32(gclass209_0[j].long_0), int_7[j] + int_10[2] - 25, int_9[j] + int_11 + GClass49.gclass49_4.method_20(), 1);
					}
					else
					{
						GClass49.gclass49_6.method_6(g, gclass209_0[j].string_0, int_7[j] + int_10[2] - 25, int_9[j] + int_11, 1);
						GClass49.gclass49_6.method_6(g, mResources.power_point + " " + GClass56.smethod_32(gclass209_0[j].long_0), int_7[j] + int_10[2] - 25, int_9[j] + int_11 + GClass49.gclass49_6.method_20(), 1);
					}
				}
			}
		}
		catch (Exception ex)
		{
			GClass56.smethod_8(ex.StackTrace);
		}
		base.paint(g);
	}

	internal void method_0(byte byte_0)
	{
		int_7 = new int[byte_0];
		int_9 = new int[byte_0];
		for (int i = 0; i < byte_0; i++)
		{
			int_7[i] = int_10[0] + 20;
			int_9[i] = i * 70 + int_10[1] + 50;
		}
		gclass14_4 = new GClass14[2];
		gclass14_4[1] = new GClass14("Vào game", this, 1, null, int_10[0] + int_10[2] - 80 - 80, int_10[1] + int_10[3] - 30);
		gclass14_4[0] = new GClass14("Trờ ra", this, 2, null, int_10[0] + int_10[2] - 80, int_10[1] + int_10[3] - 30);
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1)
		{
			if (idAction == 2)
				GClass39.gclass39_0.method_9(GClass39.gclass152_0);
		}
		else if (int_8 != -1)
		{
			GClass39.smethod_33();
			GClass166.smethod_0().method_116(gclass209_0[int_8].int_0);
		}
	}
}
