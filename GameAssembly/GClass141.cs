using System;
using AssemblyCSharp.Functions;

public class GClass141 : GClass131
{
	public static GClass141 gclass141_0;

	private GClass182[] gclass182_0;

	private byte byte_0;

	private byte byte_1;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private int int_14;

	private int int_15;

	private int int_16;

	private int int_17;

	private int int_18;

	private int int_19;

	private int int_20;

	private int int_21;

	private int int_22;

	private int int_23;

	private int int_24;

	private int int_25;

	private int[] int_26;

	private int[] int_27;

	private int[] int_28;

	private int[] int_29;

	private short[] short_0;

	private long long_0;

	private long long_1;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private short short_1;

	private static int int_30;

	private static int[] int_31;

	private static GClass17 gclass17_0;

	private static GClass17 gclass17_1;

	private static GClass17 gclass17_2;

	private static GClass70 gclass70_0;

	private static GClass70 gclass70_1;

	private byte[] byte_2 = new byte[21]
	{
		19, 19, 19, 19, 19, 19, 19, 19, 19, 19,
		19, 19, 19, 19, 19, 19, 19, 19, 19, 19,
		20
	};

	private byte[] byte_3 = new byte[12]
	{
		0, 0, 0, 1, 1, 1, 2, 2, 2, 3,
		3, 3
	};

	public GClass141()
	{
		int_31 = new int[2];
		int_31[0] = 16;
		int_30 = GClass73.int_11 - 41;
		int_31[1] = GClass73.int_10 - 40;
		gclass17_0 = new GClass17(GClass73.smethod_43("/e/e_1.png"), 30, 30);
		gclass17_1 = new GClass17(GClass73.smethod_43("/e/e_0.png"), 68, 65);
		gclass17_2 = new GClass17(GClass73.smethod_43("/e/e_2.png"), 66, 70);
		gclass70_1 = GClass73.smethod_43("/e/nut2.png");
		gclass70_0 = GClass73.smethod_43("/e/nut3.png");
		int_18 = 230;
		int_16 = GClass73.int_12 - int_18 / 2;
		int_19 = 40;
		int_17 = -int_19;
	}

	public static GClass141 smethod_2()
	{
		if (gclass141_0 == null)
			gclass141_0 = new GClass141();
		return gclass141_0;
	}

	public void method_0(short[] idImage, byte typePrice, int price, short idTicket)
	{
		if (idImage != null && idImage.Length != 0)
		{
			int_12 = GClass78.smethod_1().int_5 - 10;
			method_1();
			gclass182_0 = new GClass182[idImage.Length];
			for (int i = 0; i < gclass182_0.Length; i++)
			{
				gclass182_0[i] = new GClass182();
				gclass182_0[i].int_8 = idImage[i];
				gclass182_0[i].int_4 = i * 25;
				gclass182_0[i].int_3 = -999;
				gclass182_0[i].int_6 = GClass50.smethod_19(2, 5);
				gclass182_0[i].int_7 = GClass50.smethod_19(-1, 2);
				gclass182_0[i].method_0();
			}
			bool_1 = false;
			bool_0 = false;
			bool_2 = false;
			long_0 = GClass73.long_0 + GClass50.smethod_19(1000, 2000);
			byte_0 = 0;
			int_13 = -1;
			int_14 = -1;
			byte_1 = typePrice;
			int_20 = price;
			int_21 = 0;
			GClass78.smethod_1().method_100(470, 408, 1);
			GClass78.smethod_1().int_12 = 2;
			GClass78.smethod_1().int_11 = 1;
			int_22 = 0;
			int_23 = 0;
			int_24 = 0;
			int_25 = 0;
			int_17 = -int_19;
			short_1 = idTicket;
			int_15 = 0;
			method_10();
			switchToMe();
			GClass109.smethod_1().method_43();
		}
	}

	private void method_1()
	{
		int_6 = GClass73.int_13 / 3 + 10;
		if (int_6 > 50)
			int_6 = 50;
		int_7 = 360;
		GClass144.int_22 = GClass144.int_30 / 2;
		int_8 = GClass144.int_23 + GClass73.int_13 / 3 + 30;
		int_11 = 175;
		int_9 = 0;
		int_10 = 360 / int_11;
		int_26 = new int[int_11];
		int_27 = new int[int_11];
		int_28 = new int[int_11];
		int_29 = new int[int_11];
		method_2();
	}

	private void method_2()
	{
		if (GClass73.bool_1)
			return;
		for (int i = 0; i < int_27.Length; i++)
		{
			int_27[i] = GClass50.smethod_28(int_6 * GClass50.smethod_1(int_9) / 1024);
			int_26[i] = GClass50.smethod_28(int_6 * GClass50.smethod_2(int_9) / 1024);
			if (int_9 < 90)
			{
				int_28[i] = int_7 + int_26[i];
				int_29[i] = int_8 - int_27[i];
			}
			else if (int_9 < 90 || int_9 >= 180)
			{
				if (int_9 >= 180 && int_9 < 270)
				{
					int_28[i] = int_7 - int_26[i];
					int_29[i] = int_8 + int_27[i];
				}
				else
				{
					int_28[i] = int_7 + int_26[i];
					int_29[i] = int_8 + int_27[i];
				}
			}
			else
			{
				int_28[i] = int_7 - int_26[i];
				int_29[i] = int_8 - int_27[i];
			}
			int_9 += int_10;
		}
	}

	public void method_3(int idAction, object p)
	{
	}

	public override void update()
	{
		try
		{
			int_21 = int_20 * method_9();
			method_10();
			GClass144.smethod_8().update();
			if (long_0 - GClass73.long_0 > 0L)
			{
				for (int i = 0; i < gclass182_0.Length; i++)
				{
					gclass182_0[i].int_4 += 2;
					if (gclass182_0[i].int_4 >= int_11)
						gclass182_0[i].int_4 = 0;
					gclass182_0[i].int_0 = int_28[gclass182_0[i].int_4];
					gclass182_0[i].int_1 = int_29[gclass182_0[i].int_4];
				}
				return;
			}
			if (byte_0 == 0)
				byte_0 = 1;
			if (byte_0 == 1)
			{
				for (int j = 0; j < gclass182_0.Length; j++)
				{
					if (gclass182_0[j].int_3 == -999 || gclass182_0[j].bool_1)
						continue;
					if (gclass182_0[j].int_1 < gclass182_0[j].int_3)
					{
						if (gclass182_0[j].int_5 < 0)
							gclass182_0[j].int_5 = 0;
						if (gclass182_0[j].int_1 + gclass182_0[j].int_5 > gclass182_0[j].int_3)
							gclass182_0[j].int_1 = gclass182_0[j].int_3;
						else
							gclass182_0[j].int_1 += gclass182_0[j].int_5;
						gclass182_0[j].int_5++;
					}
					else
					{
						if (gclass182_0[j].int_5 > 0)
							gclass182_0[j].int_5 = 0;
						gclass182_0[j].int_1 += gclass182_0[j].int_5;
						gclass182_0[j].int_5--;
					}
					if (gclass182_0[j].int_1 == gclass182_0[j].int_3)
					{
						GClass57.smethod_0(new GClass81(19, gclass182_0[j].int_0 - 5, gclass182_0[j].int_1 + 25, 2, 1, -1));
						GClass109.smethod_1().method_31();
						gclass182_0[j].bool_1 = true;
						if (!bool_1)
							bool_1 = true;
					}
				}
			}
			if (byte_0 == 2)
			{
				for (int k = 0; k < gclass182_0.Length; k++)
				{
					if (gclass182_0[k].bool_1)
						continue;
					if (gclass182_0[k].int_1 > -10)
					{
						if (gclass182_0[k].int_5 > 0)
							gclass182_0[k].int_5 = 0;
						gclass182_0[k].int_1 += gclass182_0[k].int_5;
						gclass182_0[k].int_5--;
						gclass182_0[k].int_0 += gclass182_0[k].int_6 * gclass182_0[k].int_7;
						gclass182_0[k].int_6 -= 3;
					}
					if (gclass182_0[k].int_1 == -10)
						gclass182_0[k].bool_0 = false;
				}
				int_22++;
				if (int_22 > byte_2.Length - 1)
				{
					int_22 = byte_2.Length - 1;
					bool_0 = true;
					GClass109.smethod_1().method_53();
					if (!bool_2 && long_1 - GClass73.long_0 < 0L)
					{
						GClass7.smethod_0().method_145(2, (byte)(method_8() + method_9()));
						bool_2 = true;
					}
				}
				GClass78.smethod_1().int_63 = byte_2[int_22];
				int_23++;
				if (int_23 > 5)
					int_23 = 0;
				int_24 = byte_3[int_23];
			}
			if (byte_0 == 3)
			{
				if (int_23 <= 5)
					int_23 = 5;
				int_23++;
				if (int_23 > byte_3.Length - 1)
				{
					int_23 = byte_3.Length - 1;
					byte_0 = 4;
					bool_0 = false;
					int num = 0;
					for (int l = 0; l < gclass182_0.Length; l++)
					{
						if (gclass182_0[l].bool_1 && !gclass182_0[l].bool_2)
						{
							gclass182_0[l].int_8 = short_0[num];
							gclass182_0[l].bool_2 = true;
							num++;
						}
					}
				}
				int_24 = byte_3[int_23];
			}
			if (byte_0 == 4)
			{
				for (int m = 0; m < gclass182_0.Length; m++)
				{
					if (gclass182_0[m].bool_0)
						gclass182_0[m].int_2 = GClass78.smethod_1().int_4;
				}
				byte_0 = 5;
			}
			if (byte_0 != 5)
				return;
			int_25++;
			if (int_17 < GClass73.int_13 / 3)
			{
				if (int_17 + int_25 > GClass73.int_13 / 3)
					int_17 = GClass73.int_13 / 3;
				else
					int_17 += int_25;
			}
			for (int n = 0; n < gclass182_0.Length; n++)
			{
				if (!gclass182_0[n].bool_0)
					continue;
				if (gclass182_0[n].int_0 >= gclass182_0[n].int_2)
				{
					if (gclass182_0[n].int_6 > 0)
						gclass182_0[n].int_6 = 0;
					gclass182_0[n].int_0 += gclass182_0[n].int_6;
					gclass182_0[n].int_6--;
				}
				else
				{
					if (gclass182_0[n].int_6 < 0)
						gclass182_0[n].int_6 = 0;
					if (gclass182_0[n].int_0 + gclass182_0[n].int_6 > gclass182_0[n].int_2)
						gclass182_0[n].int_0 = gclass182_0[n].int_2;
					else
						gclass182_0[n].int_0 += gclass182_0[n].int_6;
					gclass182_0[n].int_6++;
				}
				if (gclass182_0[n].int_0 == gclass182_0[n].int_2)
					gclass182_0[n].bool_0 = false;
			}
		}
		catch (Exception)
		{
		}
	}

	public override void updateKey()
	{
		if (GClass130.bool_1)
			return;
		if (GClass73.bool_5 && !GClass91.smethod_0().bool_0 && !GClass73.gclass145_0.bool_0)
			method_4();
		for (int i = 1; i < 8; i++)
		{
			if (GClass73.bool_11[i])
			{
				GClass73.bool_11[i] = false;
				method_5(i - 1);
			}
		}
		if (GClass73.bool_11[12])
		{
			GClass73.bool_11[12] = false;
			method_6(0);
		}
		if (GClass73.bool_11[13])
		{
			GClass73.bool_11[13] = false;
			method_6(1);
		}
		if (GClass73.int_71 == 120)
		{
			GClass155.smethod_0().int_2 = -1;
			GClass155.smethod_0().bool_0 = false;
			GClass155.smethod_0().int_1 = -1;
			GClass155.smethod_0().int_0 = -1;
			GClass149.smethod_1("Ngừng auto quay vòng quay thượng đế !", 0);
		}
		GClass73.smethod_26();
	}

	private void method_4()
	{
		if (byte_0 == 1 && GClass73.bool_15)
		{
			for (int i = 0; i < gclass182_0.Length; i++)
			{
				if (GClass73.smethod_24(gclass182_0[i].int_0 - 20 - GClass144.int_22, gclass182_0[i].int_1 - 10 - GClass144.int_23, 30, 30) && GClass73.bool_15 && GClass73.bool_16)
					method_5(i);
			}
		}
		if (!GClass73.bool_15)
			return;
		for (int j = 0; j < int_31.Length; j++)
		{
			if (GClass73.smethod_24(int_31[j], int_30, 36, 36) && GClass73.bool_15 && GClass73.bool_16)
				method_6(j);
		}
	}

	private void method_5(int int_32)
	{
		if (!gclass182_0[int_32].bool_1)
		{
			GClass109.smethod_1().method_9();
			long num = ((byte_1 == 0) ? GClass78.smethod_1().long_6 : GClass78.smethod_1().method_145());
			if (method_8() >= int_15 && num < int_21 + int_20)
			{
				string s = mResources.not_enough_money_1 + " " + ((byte_1 != 0) ? mResources.LUONG : mResources.XU);
				GClass144.gclass52_0.method_7(s, 0);
			}
			else
			{
				int_13 = int_32;
				gclass182_0[int_13].int_3 = int_12 + GClass50.smethod_19(-3, 3);
			}
		}
	}

	private void method_6(int int_32)
	{
		int_14 = int_32;
		if (int_32 == 0)
		{
			if (byte_0 < 2)
			{
				if (method_8() + method_9() > 0)
				{
					byte_0 = 2;
					GClass109.smethod_1().method_8();
					GClass78.smethod_1().method_69(GClass144.gclass39_0[13], 0);
					long_1 = GClass73.long_0 + GClass50.smethod_19(2000, 3000);
				}
			}
			else if (int_17 == GClass73.int_13 / 3)
			{
				GClass7.smethod_0().method_145(byte_1, 0);
			}
		}
		else
		{
			GClass155.smethod_0().int_2 = -1;
			GClass155.smethod_0().bool_0 = false;
			GClass155.smethod_0().int_1 = -1;
			GClass155.smethod_0().int_0 = -1;
			GClass149.smethod_1("Ngừng auto quay vòng quay thượng đế !", 0);
			GClass144.smethod_8().bool_63 = false;
			GClass144.smethod_8().switchToMe();
		}
	}

	public override void paint(GClass122 g)
	{
		try
		{
			GClass144.smethod_8().paint(g);
			g.method_1(-GClass144.int_22, -GClass144.int_23);
			g.method_1(0, GClass73.int_58);
			for (int i = 0; i < gclass182_0.Length; i++)
			{
				if (gclass182_0[i].bool_0 && gclass182_0[i].int_1 > gclass182_0[i].int_3 - 20)
					g.method_31(GClass20.gclass70_10, gclass182_0[i].int_0, gclass182_0[i].int_3 + 7, GClass122.int_1 | GClass122.int_0);
			}
			for (int j = 0; j < gclass182_0.Length; j++)
			{
				if (gclass182_0[j].bool_0)
					GClass28.smethod_6(g, gclass182_0[j].int_8, gclass182_0[j].int_0, gclass182_0[j].int_1, 0, GClass122.int_1 | GClass122.int_0);
			}
			if (bool_0)
			{
				if (gclass17_0 != null)
				{
					int num = GClass78.smethod_1().int_4 - gclass17_0.int_0 - 28;
					for (int k = 0; k < GClass73.int_10 / gclass17_0.int_0 + 1; k++)
					{
						gclass17_0.method_0(int_24, num - k * (gclass17_0.int_0 - 1), GClass78.smethod_1().int_5 - gclass17_0.int_1 / 2 - 12 + 2, 0, 0, g);
					}
				}
				if (gclass17_1 != null)
				{
					int num2 = GClass78.smethod_1().int_4 - gclass17_1.int_0 - 10;
					gclass17_1.method_0(int_24, num2 - 5, GClass78.smethod_1().int_5 - gclass17_1.int_1 / 2 - 12, 0, 0, g);
				}
			}
			GClass144.smethod_18(g);
			int num3 = 240;
			int num4 = GClass73.int_10 - 240;
			int num5 = 15;
			g.method_16(13524492);
			g.method_15(num4, 0, 240, 15);
			g.method_31(GClass76.gclass70_7, num4 + 11, 8, 3);
			g.method_31(GClass76.gclass70_9, num4 + 90, 7, 3);
			GClass4.gclass4_15.method_10(g, GClass78.smethod_1().string_0 + "", num4 + 24, 2, GClass4.int_0, GClass4.gclass4_16);
			GClass4.gclass4_15.method_10(g, GClass78.smethod_1().string_1 + "", num4 + 100, 2, GClass4.int_0, GClass4.gclass4_16);
			g.method_31(GClass76.gclass70_10, num4 + 150, 8, 3);
			GClass4.gclass4_15.method_10(g, GClass78.smethod_1().string_2 + "", num4 + 160, 2, GClass4.int_0, GClass4.gclass4_16);
			g.method_31(GClass76.gclass70_8, num4 + 200, 8, 3);
			GClass4.gclass4_15.method_10(g, int_15 + "", num4 + 210, 2, GClass4.int_0, GClass4.gclass4_16);
			if (byte_0 < 4)
			{
				int num6 = num3 / 2 + 20;
				int num7 = GClass73.int_10 - num6;
				g.method_16(11837316);
				g.method_15(num7, num5, num6, 15);
				if (byte_1 != 0)
				{
					g.method_31(GClass76.gclass70_10, num7 + 21, num5 + 7, 3);
					g.method_31(GClass76.gclass70_9, num7 + 18, num5 + 7, 3);
				}
				else
					g.method_31(GClass76.gclass70_7, num7 + 21, num5 + 8, 3);
				GClass4.gclass4_17.method_10(g, " -" + int_21, num7 + 30, num5 + 2, GClass4.int_0, GClass4.gclass4_16);
				g.method_31(GClass76.gclass70_8, num7 + 80, num5 + 7, 3);
				GClass4.gclass4_17.method_10(g, " -" + method_8(), num7 + 90, num5 + 2, GClass4.int_0, GClass4.gclass4_16);
			}
			g.method_31(GClass144.gclass70_14, int_31[0], int_30, 0);
			if (int_14 == 0)
				g.method_31(GClass144.gclass70_15, int_31[0], int_30, 0);
			if (byte_0 >= 3)
				g.method_31(gclass70_1, int_31[0] + 14 - 10, int_30 + 14 - 10, 0);
			else
				GClass28.smethod_6(g, 540, int_31[0] + 14, int_30 + 14, 0, GClass188.int_6);
			g.method_31(GClass144.gclass70_14, int_31[1], int_30, 0);
			if (int_14 == 1)
				g.method_31(GClass144.gclass70_15, int_31[1], int_30, 0);
			g.method_31(gclass70_0, int_31[1] + 14 - 10, int_30 + 14 - 10, 0);
			if (byte_0 > 3)
			{
				GClass73.gclass192_0.method_35(int_16, int_17, int_18, int_19, g);
				int num8 = GClass73.int_12 - short_0.Length * 30 / 2;
				for (int l = 0; l < short_0.Length; l++)
				{
					GClass28.smethod_6(g, short_0[l], num8 + 5 + l * 30, int_17 + 10, 0, 0);
				}
			}
			if (GClass155.smethod_0().int_2 > 0)
				GClass4.gclass4_3.method_10(g, (GClass151.int_0 == 0) ? "Ấn X để ngưng tự động quay !" : "Press X to stop auto spinning !", 85, 50, GClass4.int_2, GClass4.gclass4_1);
		}
		catch (Exception)
		{
		}
	}

	public void method_7(short[] idImage)
	{
		byte_0 = 3;
		short_0 = idImage;
	}

	public override void switchToMe()
	{
		GClass144.bool_1 = true;
		GClass144.smethod_8().bool_63 = true;
		base.switchToMe();
	}

	private byte method_8()
	{
		byte b = 0;
		for (int i = 0; i < gclass182_0.Length; i++)
		{
			if (gclass182_0[i].bool_1)
				b++;
		}
		if (b > int_15)
			b = (byte)int_15;
		return b;
	}

	private byte method_9()
	{
		byte b = 0;
		for (int i = 0; i < gclass182_0.Length; i++)
		{
			if (gclass182_0[i].bool_1)
				b++;
		}
		b -= method_8();
		if (b <= 0)
			b = 0;
		return b;
	}

	private void method_10()
	{
		for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
		{
			if (GClass78.smethod_1().gclass128_0[i] != null && GClass78.smethod_1().gclass128_0[i].gclass117_0.short_0 == short_1)
			{
				int_15 = GClass78.smethod_1().gclass128_0[i].int_30;
				break;
			}
		}
	}
}
