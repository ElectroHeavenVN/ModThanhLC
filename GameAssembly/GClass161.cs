using System;

public class GClass161 : GClass160, GInterface1
{
	public GClass118[] gclass118_4;

	public static GClass152[] gclass152_0;

	private int int_6;

	private int[] int_7 = new int[2]
	{
		GClass14.int_10 / 2 - 100,
		GClass14.int_10 / 2 - 100
	};

	private int int_8;

	private int[] int_9 = new int[2];

	private int[] int_10 = new int[4]
	{
		GClass14.int_10 / 2 - 150,
		GClass14.int_11 / 2 - 100,
		300,
		200
	};

	private int int_11 = -35;

	private int int_12 = -35;

	public override void switchToMe()
	{
		GClass170.bool_1 = false;
		GClass124.bool_35 = false;
		GClass173.bool_0 = false;
		GClass170.bool_3 = false;
		GClass167.smethod_8().method_0();
		base.switchToMe();
	}

	public override void update()
	{
		if (GClass14.int_8 % 10 <= 2)
			int_6 = 0;
		else
			int_6 = 1;
		for (int i = 0; i < gclass118_4.Length; i++)
		{
			if (gclass118_4[i].method_4())
				gclass118_4[i].method_1();
		}
		for (int j = 0; j < int_7.Length; j++)
		{
			if (GClass14.smethod_24(int_7[j] + int_12, int_9[j] + int_11, int_10[2], 60))
			{
				if (GClass14.bool_14)
				{
					int_8 = j;
					break;
				}
				if (GClass14.bool_16 && GClass14.bool_15)
					;
			}
		}
		base.update();
	}

	public override void paint(GClass193 g)
	{
		GClass14.smethod_18(g);
		try
		{
			GClass139.smethod_4(g, int_10[0] - 10, int_10[1], int_10[2] + 20, int_10[3], 16777215, true);
			if (gclass118_4 != null)
			{
				for (int i = 0; i < gclass118_4.Length; i++)
				{
					gclass118_4[i].method_3(g);
				}
			}
			if (gclass152_0 != null)
			{
				for (int j = 0; j < gclass152_0.Length; j++)
				{
					GClass139.smethod_4(g, int_7[j] - 20, int_9[j] + int_11, int_10[2], 60, 16777215, false);
					GClass29 gClass = GClass167.gclass29_0[gclass152_0[j].short_0];
					GClass29 gClass2 = GClass167.gclass29_0[gclass152_0[j].short_2];
					GClass29 gClass3 = GClass167.gclass29_0[gclass152_0[j].short_1];
					GClass72.smethod_6(g, gClass.gclass21_0[GClass124.int_94[int_6][0][0]].short_0, int_7[j] + GClass124.int_94[int_6][0][1] + gClass.gclass21_0[GClass124.int_94[int_6][0][0]].sbyte_0, int_9[j] - GClass124.int_94[int_6][0][2] + gClass.gclass21_0[GClass124.int_94[int_6][0][0]].sbyte_1, 0, 0);
					GClass72.smethod_6(g, gClass2.gclass21_0[GClass124.int_94[int_6][1][0]].short_0, int_7[j] + GClass124.int_94[int_6][1][1] + gClass2.gclass21_0[GClass124.int_94[int_6][1][0]].sbyte_0, int_9[j] - GClass124.int_94[int_6][1][2] + gClass2.gclass21_0[GClass124.int_94[int_6][1][0]].sbyte_1, 0, 0);
					GClass72.smethod_6(g, gClass3.gclass21_0[GClass124.int_94[int_6][2][0]].short_0, int_7[j] + GClass124.int_94[int_6][2][1] + gClass3.gclass21_0[GClass124.int_94[int_6][2][0]].sbyte_0, int_9[j] - GClass124.int_94[int_6][2][2] + gClass3.gclass21_0[GClass124.int_94[int_6][2][0]].sbyte_1, 0, 0);
					if (int_8 == j)
					{
						GClass104.gclass104_4.method_6(g, gclass152_0[j].string_0, int_7[j] + int_10[2] - 25, int_9[j] + int_11, 1);
						GClass104.gclass104_4.method_6(g, mResources.power_point + " " + GClass191.smethod_32(gclass152_0[j].long_0), int_7[j] + int_10[2] - 25, int_9[j] + int_11 + GClass104.gclass104_4.method_20(), 1);
					}
					else
					{
						GClass104.gclass104_6.method_6(g, gclass152_0[j].string_0, int_7[j] + int_10[2] - 25, int_9[j] + int_11, 1);
						GClass104.gclass104_6.method_6(g, mResources.power_point + " " + GClass191.smethod_32(gclass152_0[j].long_0), int_7[j] + int_10[2] - 25, int_9[j] + int_11 + GClass104.gclass104_6.method_20(), 1);
					}
				}
			}
		}
		catch (Exception ex)
		{
			GClass191.smethod_8(ex.StackTrace);
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
		gclass118_4 = new GClass118[2];
		gclass118_4[1] = new GClass118("Vào game", this, 1, null, int_10[0] + int_10[2] - 80 - 80, int_10[1] + int_10[3] - 30);
		gclass118_4[0] = new GClass118("Trờ ra", this, 2, null, int_10[0] + int_10[2] - 80, int_10[1] + int_10[3] - 30);
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1)
		{
			if (idAction == 2)
				GClass14.gclass14_0.method_9(GClass14.gclass170_0);
		}
		else if (int_8 != -1)
		{
			GClass14.smethod_33();
			GClass2.smethod_0().method_116(gclass152_0[int_8].int_0);
		}
	}
}
