public class GClass192
{
	public static int int_0 = 15787715;

	public static int int_1 = 16383818;

	public static int int_2 = 3937280;

	public static int int_3 = 15224576;

	public static int int_4 = 16777215;

	public static GClass70 gclass70_0;

	public static GClass70 gclass70_1;

	public static GClass70 gclass70_2;

	public static GClass70 gclass70_3;

	public static GClass70 gclass70_4;

	public static GClass70 gclass70_5;

	public static GClass70 gclass70_6;

	public static GClass70 gclass70_7;

	public static GClass70 gclass70_8;

	public static GClass70 gclass70_9;

	public static GClass70 gclass70_10;

	public static GClass70[] gclass70_11 = new GClass70[2];

	public static GClass70[] gclass70_12 = new GClass70[2];

	public static GClass70[] gclass70_13 = new GClass70[6];

	public static int int_5 = 24;

	public static int int_6 = 0;

	public int[] int_7 = new int[7] { 15970400, 13479911, 2250052, 16374659, 15906669, 12931125, 3108954 };

	public static GClass70 gclass70_14 = GClass73.smethod_43("/mainImage/myTexture2dcheck.png");

	public static void smethod_0()
	{
		for (int i = 0; i < gclass70_13.Length; i++)
		{
			gclass70_13[i] = GClass73.smethod_43("/mainImage/myTexture2dgoc" + (i + 1) + ".png");
		}
	}

	public void method_0(GClass122 g)
	{
		g.method_16(8916494);
		g.method_15(0, 0, GClass73.int_10, GClass73.int_11);
		g.method_31(gclass70_0, GClass73.int_10 / 2, GClass73.int_11 / 2 - int_5 / 2 - 1, 3);
		g.method_31(gclass70_3, 0, 0, 0);
		g.method_31(gclass70_5, GClass73.int_10, 0, GClass122.int_4 | GClass122.int_3);
		g.method_31(gclass70_2, 0, GClass73.int_11 - int_5 - 2, GClass122.int_5 | GClass122.int_2);
		g.method_31(gclass70_4, GClass73.int_10, GClass73.int_11 - int_5 - 2, GClass122.int_5 | GClass122.int_3);
		g.method_16(16774843);
		g.method_14(0, 0, GClass73.int_10, 0);
		g.method_14(0, GClass73.int_11 - int_5 - 2, GClass73.int_10, 0);
		g.method_14(0, 0, 0, GClass73.int_11 - int_5);
		g.method_14(GClass73.int_10 - 1, 0, 0, GClass73.int_11 - int_5);
	}

	public void method_1(GClass122 g)
	{
		g.method_16(205314);
		g.method_15(0, 0, GClass73.int_10, GClass73.int_11);
	}

	public void method_2()
	{
	}

	public void method_3(GClass122 g)
	{
	}

	public void method_4(GClass122 g, int x, int y, int w, int h)
	{
		g.method_16(8411138);
		g.method_15(x, y, w, h);
		g.method_16(13606712);
		g.method_14(x, y, w, h);
	}

	public void method_5(GClass122 g, int y, int x, int width, int height)
	{
		g.method_16(16776363);
		g.method_15(x, y, width, height);
		g.method_16(0);
		g.method_14(x - 1, y - 1, width + 1, height + 1);
	}

	public void method_6(GClass122 g, int h)
	{
		g.method_16(14279153);
		g.method_15(8, GClass73.int_11 - (h + 37), GClass73.int_10 - 16, h + 4);
		g.method_16(4682453);
		g.method_15(10, GClass73.int_11 - (h + 35), GClass73.int_10 - 20, h);
	}

	public void method_7(GClass122 g, GClass87 left, GClass87 center, GClass87 right)
	{
		GClass4 gClass = ((!GClass73.bool_5) ? GClass4.gclass4_6 : GClass4.gclass4_6);
		int num = 3;
		if (left != null)
		{
			int_6 = gClass.method_17(left.string_0);
			if (int_6 > 0)
			{
				if (left.int_1 >= 0 && left.int_2 > 0)
					left.method_3(g);
				else
				{
					g.method_31((GClass131.int_4 != 0) ? GClass144.gclass70_22 : GClass144.gclass70_23, 1, GClass73.int_11 - GClass131.int_3 - 1, 0);
					gClass.method_6(g, left.string_0, 35, GClass73.int_11 - GClass131.int_3 + 3 + num, 2);
				}
			}
		}
		if (center != null)
		{
			int_6 = gClass.method_17(center.string_0);
			if (int_6 > 0)
			{
				if (center.int_1 <= 0 || center.int_2 <= 0)
				{
					g.method_31((GClass131.int_4 != 1) ? GClass144.gclass70_22 : GClass144.gclass70_23, GClass73.int_12 - 35, GClass73.int_11 - GClass131.int_3 - 1, 0);
					gClass.method_6(g, center.string_0, GClass73.int_12, GClass73.int_11 - GClass131.int_3 + 3 + num, 2);
				}
				else
					center.method_3(g);
			}
		}
		if (right == null)
			return;
		int_6 = gClass.method_17(right.string_0);
		if (int_6 > 0)
		{
			if (right.int_1 > 0 && right.int_2 > 0)
			{
				right.method_3(g);
				return;
			}
			g.method_31((GClass131.int_4 != 2) ? GClass144.gclass70_22 : GClass144.gclass70_23, GClass73.int_10 - 71, GClass73.int_11 - GClass131.int_3 - 1, 0);
			gClass.method_6(g, right.string_0, GClass73.int_10 - 35, GClass73.int_11 - GClass131.int_3 + 3 + num, 2);
		}
	}

	public void method_8(GClass122 g)
	{
	}

	public void method_9(GClass122 g, int x, int y, int w, int h)
	{
		g.method_16(16774843);
		g.method_15(x, y, w, h);
	}

	public void method_10(GClass122 g, int x, int y)
	{
		g.method_31(gclass70_1, x, y, 3);
	}

	public void method_11(GClass122 g, string number)
	{
	}

	public void method_12(GClass122 g, int x, int y, int w, int h, bool iss)
	{
		if (!iss)
		{
			g.method_16(16775097);
			g.method_36(x, y, w, h, 10, 10);
			g.method_16(16775097);
		}
		else
		{
			g.method_16(16646144);
			g.method_36(x, y, w, h, 10, 10);
			g.method_16(16770612);
		}
		g.method_36(x + 3, y + 3, w - 6, h - 6, 10, 10);
	}

	public void method_13(GClass122 g, int x, int y, int w, int h, string title, string subTitle, string check)
	{
	}

	public void method_14(GClass122 g, string title, string subTitle, string check)
	{
	}

	public void method_15(GClass122 g, int x, int y, int index)
	{
		g.method_31(gclass70_11[1], x, y, 3);
		if (index == 1)
			g.method_31(gclass70_11[0], x + 1, y - 3, 3);
	}

	public void method_16(GClass122 g, int x, int y, int index)
	{
		g.method_31(gclass70_12[index], x, y, 0);
	}

	public void method_17(GClass122 g, int roomId)
	{
		method_0(g);
	}

	public void method_18(GClass122 g, int x, int y, bool check, bool focus)
	{
		if (!focus)
			g.method_23(gclass70_14, 0, (check ? 2 : 0) * 18, 20, 18, 0, x, y, 0);
		else
			g.method_23(gclass70_14, 0, ((!check) ? 1 : 3) * 18, 20, 18, 0, x, y, 0);
	}

	public void method_19(GClass122 g, int x, int y, int w, int h, string[] str)
	{
		method_34(x, y, w, h, g);
		int num = y + 20 - GClass4.gclass4_21.method_20();
		int num2 = 0;
		int num3 = num;
		while (num2 < str.Length)
		{
			GClass4.gclass4_21.method_6(g, str[num2], x + w / 2, num3, 2);
			num2++;
			num3 += GClass4.gclass4_21.method_20();
		}
	}

	public void method_20(GClass122 g, int x, int y, bool iss, bool isSe, int i, int wStr)
	{
	}

	public void method_21(GClass122 g, int x, int y, int xTo, int yTo)
	{
		g.method_16(16774843);
		g.method_11(x, y, xTo, yTo);
	}

	public void method_22(GClass122 g, int x, int y, int w, int h, bool iss)
	{
		if (iss)
		{
			g.method_16(13132288);
			g.method_15(x + 2, y + 2, w - 3, w - 3);
		}
		g.method_16(3502080);
		g.method_14(x, y, w, w);
	}

	public void method_23(GClass122 g, int x, int y, int h)
	{
		g.method_16(3847752);
		g.method_15(x, y, 4, h);
	}

	public int[] method_24()
	{
		return int_7;
	}

	public void method_25(GClass122 g)
	{
		g.method_16(8916494);
		g.method_15(0, 0, GClass73.int_10, GClass73.int_11);
		g.method_31(gclass70_1, GClass73.int_11 >> 1, GClass73.int_10 >> 1, 3);
	}

	public void method_26(GClass122 g, bool isRes)
	{
		int num = 0;
		if (!isRes && GClass73.int_11 <= 240)
			num = 15;
		GClass4.gclass4_7.method_6(g, mResources.LOGINLABELS[0], GClass73.int_12, GClass73.int_13 + 60 - num, 2);
		GClass4.gclass4_7.method_6(g, mResources.LOGINLABELS[1], GClass73.int_12, GClass73.int_13 + 73 - num, 2);
	}

	public void method_27(GClass122 g, int x, int y, int w, int h)
	{
		g.method_31(gclass70_7, x - 7, y, 0);
	}

	public int method_28()
	{
		return 0;
	}

	public string method_29()
	{
		return "/vmg/card.on";
	}

	public void method_30(GClass122 g, int x, int y, int w, int h)
	{
		g.method_16(16777215);
		g.method_14(x, y, 40, 40);
		g.method_14(x + 1, y + 1, 38, 38);
	}

	public string method_31()
	{
		return "http://wap.teamobi.com?info=checkupdate&game=3&version=" + GClass187.string_2 + "&provider=" + GClass187.sbyte_0;
	}

	public void method_32(int focus)
	{
	}

	public void method_33(int x, int y, int w, int h, GClass122 g)
	{
		g.method_16(9340251);
		g.method_14(x + 18, y, (w - 36) / 2 - 32, h);
		g.method_14(x + 18 + (w - 36) / 2 + 32, y, (w - 36) / 2 - 22, h);
		g.method_14(x, y + 8, w, h - 17);
		g.method_16(int_0);
		g.method_15(x + 18, y + 3, (w - 36) / 2 - 32, h - 4);
		g.method_15(x + 18 + (w - 36) / 2 + 31, y + 3, (w - 38) / 2 - 22, h - 4);
		g.method_15(x + 1, y + 6, w - 1, h - 11);
		g.method_16(14667919);
		g.method_15(x + 18, y + 1, (w - 36) / 2 - 32, 2);
		g.method_15(x + 18 + (w - 36) / 2 + 32, y + 1, (w - 36) / 2 - 12, 2);
		g.method_15(x + 18, y + h - 2, (w - 36) / 2 - 31, 2);
		g.method_15(x + 18 + (w - 36) / 2 + 32, y + h - 2, (w - 36) / 2 - 31, 2);
		g.method_15(x + 1, y + 11, 2, h - 18);
		g.method_15(x + w - 2, y + 11, 2, h - 18);
		g.method_31(gclass70_13[0], x - 3, y - 2, GClass122.int_4 | GClass122.int_2);
		g.method_31(gclass70_13[2], x + w + 3, y - 2, GClass188.int_2);
		g.method_31(gclass70_13[1], x - 3, y + h + 3, GClass188.int_4);
		g.method_31(gclass70_13[3], x + w + 4, y + h + 2, GClass188.int_5);
		g.method_31(gclass70_13[4], x + w / 2, y, GClass188.int_0);
		g.method_31(gclass70_13[5], x + w / 2, y + h + 1, GClass188.int_3);
	}

	public void method_34(int x, int y, int w, int h, GClass122 g)
	{
		g.method_16(13524492);
		g.method_14(x + 6, y, w - 12, h);
		g.method_14(x, y + 6, w, h - 12);
		g.method_14(x + 7, y + 1, w - 14, h - 2);
		g.method_14(x + 1, y + 7, w - 2, h - 14);
		g.method_16(14338484);
		g.method_15(x + 8, y + 2, w - 16, h - 3);
		g.method_15(x + 2, y + 8, w - 3, h - 14);
		g.method_31(GClass73.gclass70_8[2], x, y, GClass122.int_4 | GClass122.int_2);
		g.method_23(GClass73.gclass70_8[2], 0, 0, 16, 16, 2, x + w + 1, y, GClass188.int_2);
		g.method_23(GClass73.gclass70_8[2], 0, 0, 16, 16, 1, x, y + h + 1, GClass188.int_4);
		g.method_23(GClass73.gclass70_8[2], 0, 0, 16, 16, 3, x + w + 1, y + h + 1, GClass188.int_5);
	}

	public void method_35(int x, int y, int w, int h, GClass122 g)
	{
		g.method_16(6702080);
		g.method_15(x, y, w, h);
		g.method_16(14338484);
		g.method_15(x + 1, y + 1, w - 2, h - 2);
	}

	public void method_36(int x, int y, int w, int h, GClass122 g)
	{
		method_34(x, y, w, h, g);
	}

	public void method_37(int x, int y, int w, int h, GClass122 g)
	{
		g.method_16(int_0);
		g.method_15(x, y, w, h);
	}

	public void method_38(int x, int y, int w, int h, GClass122 g)
	{
		g.method_16(int_1);
		g.method_15(x, y, w, h);
	}
}
