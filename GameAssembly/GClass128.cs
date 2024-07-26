using AssemblyCSharp.Functions;

public class GClass128
{
	public const int int_0 = 34;

	public const int int_1 = 35;

	public const int int_2 = 36;

	public const int int_3 = 41;

	public const int int_4 = 72;

	public const int int_5 = 102;

	public const int int_6 = 107;

	public const int int_7 = 0;

	public const int int_8 = 6;

	public const int int_9 = 0;

	public const int int_10 = 1;

	public const int int_11 = 2;

	public const int int_12 = 3;

	public const int int_13 = 4;

	public const int int_14 = 5;

	public const int int_15 = 6;

	public const int int_16 = 12;

	public const int int_17 = 7;

	public const int int_18 = 8;

	public const int int_19 = 9;

	public const int int_20 = 10;

	public const int int_21 = 11;

	public const int int_22 = 23;

	public const int int_23 = 24;

	public const int int_24 = 34;

	public const int int_25 = 32;

	public const int int_26 = 35;

	public const sbyte sbyte_0 = 2;

	public const sbyte sbyte_1 = 3;

	public const sbyte sbyte_2 = 4;

	public const sbyte sbyte_3 = 5;

	public const sbyte sbyte_4 = 6;

	public const sbyte sbyte_5 = 7;

	public const sbyte sbyte_6 = 8;

	public const sbyte sbyte_7 = 9;

	public const sbyte sbyte_8 = 10;

	public const sbyte sbyte_9 = 11;

	public const sbyte sbyte_10 = 12;

	public const sbyte sbyte_11 = 13;

	public const sbyte sbyte_12 = 14;

	public const sbyte sbyte_13 = 15;

	public const sbyte sbyte_14 = 16;

	public const sbyte sbyte_15 = 17;

	public const sbyte sbyte_16 = 18;

	public const sbyte sbyte_17 = 19;

	public const sbyte sbyte_18 = 20;

	public const sbyte sbyte_19 = 21;

	public const sbyte sbyte_20 = 22;

	public const sbyte sbyte_21 = 23;

	public const sbyte sbyte_22 = 24;

	public const sbyte sbyte_23 = 25;

	public const sbyte sbyte_24 = 26;

	public const sbyte sbyte_25 = 27;

	public const sbyte sbyte_26 = 28;

	public const sbyte sbyte_27 = 29;

	public const sbyte sbyte_28 = 30;

	public const sbyte sbyte_29 = 31;

	public const sbyte sbyte_30 = 32;

	public const sbyte sbyte_31 = 33;

	public GClass120[] gclass120_0;

	public GClass117 gclass117_0;

	public GClass88 gclass88_0;

	public int int_27;

	public int int_28;

	public bool bool_0;

	public int int_29;

	public int int_30;

	public int int_31;

	public long long_0;

	public bool bool_1;

	public int int_32;

	public int int_33;

	public int int_34;

	public int int_35;

	public int int_36;

	public int int_37;

	public int int_38;

	public int int_39;

	public int int_40;

	public short short_0 = -1;

	public sbyte sbyte_32 = -1;

	public int int_41;

	public bool bool_2;

	public bool bool_3;

	public GClass124 gclass124_0;

	public int int_42;

	public GClass70 gclass70_0;

	public string string_0;

	public string string_1;

	public string string_2 = "";

	public int int_43;

	public sbyte sbyte_33;

	public bool bool_4;

	public int int_44 = -1;

	public int int_45 = -1;

	public int int_46 = -1;

	public int int_47 = -1;

	public int int_48 = -1;

	public string string_3 = "";

	private int[] int_49 = new int[18]
	{
		0, 0, 0, 0, 600841, 600841, 667658, 667658, 3346944, 3346688,
		4199680, 5052928, 3276851, 3932211, 4587571, 5046280, 6684682, 3359744
	};

	private int[][] int_50 = new int[5][]
	{
		new int[6] { 18687, 16869, 15052, 13235, 11161, 9344 },
		new int[6] { 45824, 39168, 32768, 26112, 19712, 13056 },
		new int[6] { 16744192, 15037184, 13395456, 11753728, 10046464, 8404992 },
		new int[6] { 13500671, 12058853, 10682572, 9371827, 7995545, 6684800 },
		new int[6] { 16711705, 15007767, 13369364, 11730962, 10027023, 8388621 }
	};

	private int[] int_51 = new int[6] { 2, 1, 1, 1, 1, 1 };

	public bool method_0()
	{
		if (gclass120_0 != null)
		{
			for (int i = 0; i < gclass120_0.Length; i++)
			{
				if (gclass120_0[i] != null && gclass120_0[i].method_0().StartsWith("Set"))
					return true;
			}
		}
		return false;
	}

	public bool method_1()
	{
		for (int i = 0; i < gclass120_0.Length; i++)
		{
			if (gclass120_0[i].gclass126_0.int_0 == 93)
				return true;
		}
		return false;
	}

	public string method_2()
	{
		return (!method_1()) ? "" : ((GClass151.int_0 == 0) ? " [HSD]" : " [Expr]");
	}

	public void method_3(GClass122 g, int p1, int p2, int p3)
	{
		if (GClass167.smethod_0().bool_8 || p3 < 4 || GClass167.smethod_0().bool_20)
			return;
		if (p3 > 8)
			p3 = 8;
		if (p3 < 0)
			p3 = 0;
		int[] array = new int[8] { 0, 0, 1, 1, 2, 3, 4, 4 };
		int[] array2 = new int[9] { 0, 0, 0, 0, 600841, 3346944, 3932211, 6684682, 3342438 };
		int[] array3 = new int[4] { 0, 68, 68, 0 };
		int[] array4 = new int[4] { 0, 48, 0, 48 };
		if (p3 >= 4)
		{
			g.method_16(array2[p3]);
			g.method_15(p1 - 18, p2 - 12, 34, 23);
		}
		if (p3 < 4 && p3 != 2)
		{
			if (p3 != 1)
			{
				for (int i = 0; i < 2; i++)
				{
					for (int j = 0; j < int_51.Length; j++)
					{
						int num = p1 - 17 + method_4(GClass73.int_8 + array3[i] - j * 4);
						int num2 = p2 - 12 + method_5(GClass73.int_8 + array4[i] - j * 4);
						g.method_16(GClass160.smethod_0().method_23(this) ? 16776960 : int_50[0][j]);
						g.method_15(num - int_51[j] / 2, num2 - int_51[j] / 2, int_51[j], int_51[j]);
					}
				}
				for (int k = 2; k < 4; k++)
				{
					for (int l = 0; l < int_51.Length; l++)
					{
						int num3 = p1 - 17 + method_4(GClass73.int_8 + array3[k] - l * 4);
						int num4 = p2 - 12 + method_5(GClass73.int_8 + array4[k] - l * 4);
						g.method_16((!GClass160.smethod_0().method_23(this)) ? int_50[1][l] : 16776960);
						g.method_15(num3 - int_51[l] / 2, num4 - int_51[l] / 2, int_51[l], int_51[l]);
					}
				}
				return;
			}
			for (int m = 0; m < 2; m++)
			{
				for (int n = 0; n < int_51.Length; n++)
				{
					int num5 = p1 - 17 + method_4(GClass73.int_8 + array3[m] - n * 4);
					int num6 = p2 - 12 + method_5(GClass73.int_8 + array4[m] - n * 4);
					g.method_16((!GClass160.smethod_0().method_23(this)) ? ((p3 >= 7) ? 16777215 : int_50[array[p3 - 1]][n]) : 16776960);
					g.method_15(num5 - int_51[n] / 2, num6 - int_51[n] / 2, int_51[n], int_51[n]);
				}
			}
			return;
		}
		for (int num7 = 0; num7 < 4; num7++)
		{
			for (int num8 = 0; num8 < int_51.Length; num8++)
			{
				int num9 = p1 - 17 + method_4(GClass73.int_8 + array3[num7] - num8 * 4);
				int num10 = p2 - 12 + method_5(GClass73.int_8 + array4[num7] - num8 * 4);
				int num11 = int_50[array[p3 - 1]][num8];
				for (int num12 = 0; num12 < gclass120_0.Length; num12++)
				{
					int num13 = 0;
					if (gclass120_0[num12].int_0 > 0)
					{
						if (gclass120_0[num12].gclass126_0.int_0 == 102)
							num13 = gclass120_0[num12].int_0;
						else if (gclass120_0[num12].gclass126_0.int_0 == 107)
						{
							num13 = gclass120_0[num12].int_0;
						}
						if (num13 >= 7)
							num11 = 16777215;
					}
				}
				g.method_16((!GClass160.smethod_0().method_23(this)) ? num11 : 16776960);
				g.method_15(num9 - int_51[num8] / 2, num10 - int_51[num8] / 2, int_51[num8], int_51[num8]);
			}
		}
	}

	public int method_4(int p0)
	{
		int num = 32;
		int num2 = p0 % 128;
		if (0 > num2 || num2 >= num)
		{
			if (num > num2 || num2 >= num * 2)
			{
				if (num * 2 <= num2 && num2 < num * 3)
					return num - num2 % num;
				return 0;
			}
			return num;
		}
		return num2 % num;
	}

	public int method_5(int p0)
	{
		int num = 22;
		int num2 = p0 % 88;
		if (0 <= num2 && num2 < num)
			return 0;
		if (num > num2 || num2 >= num * 2)
		{
			if (num * 2 > num2 || num2 >= num * 3)
				return num - num2 % num;
			return num;
		}
		return num2 % num;
	}

	public void method_6()
	{
		int_43 = GClass73.gclass76_0.method_131(this);
	}

	public string method_7()
	{
		string result = "";
		if (int_34 > 0 || int_36 > 0)
		{
			if (int_34 <= 0 || int_36 > 0)
			{
				if (int_36 > 0 && int_34 <= 0)
					result = int_36 + mResources.LUONG;
				else if (int_34 > 0 && int_36 > 0)
				{
					result = int_34 + mResources.XU + "/" + int_36 + mResources.LUONG;
				}
			}
			else
				result = int_34 + mResources.XU;
			return result;
		}
		return null;
	}

	public void method_8(int x, int y, int upgrade, GClass122 g)
	{
		int num = GClass144.int_42 - 2;
		int num2 = 0;
		int num3 = ((upgrade >= 4) ? ((upgrade < 8) ? 1 : ((upgrade < 12) ? 2 : ((upgrade <= 14) ? 3 : 4))) : 0);
		for (int i = num2; i < int_51.Length; i++)
		{
			int num4 = x - num / 2 + method_10(GClass73.int_8 - i * 4);
			int num5 = y - num / 2 + method_9(GClass73.int_8 - i * 4);
			g.method_16(int_50[num3][i]);
			g.method_15(num4 - int_51[i] / 2, num5 - int_51[i] / 2, int_51[i], int_51[i]);
		}
		if (upgrade == 4 || upgrade == 8)
		{
			for (int j = num2; j < int_51.Length; j++)
			{
				int num6 = x - num / 2 + method_10(GClass73.int_8 - num * 2 - j * 4);
				int num7 = y - num / 2 + method_9(GClass73.int_8 - num * 2 - j * 4);
				g.method_16(int_50[num3 - 1][j]);
				g.method_15(num6 - int_51[j] / 2, num7 - int_51[j] / 2, int_51[j], int_51[j]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8)
		{
			for (int k = num2; k < int_51.Length; k++)
			{
				int num8 = x - num / 2 + method_10(GClass73.int_8 - num * 2 - k * 4);
				int num9 = y - num / 2 + method_9(GClass73.int_8 - num * 2 - k * 4);
				g.method_16(int_50[num3][k]);
				g.method_15(num8 - int_51[k] / 2, num9 - int_51[k] / 2, int_51[k], int_51[k]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8 && upgrade != 12 && upgrade != 2 && upgrade != 5 && upgrade != 9)
		{
			for (int l = num2; l < int_51.Length; l++)
			{
				int num10 = x - num / 2 + method_10(GClass73.int_8 - num - l * 4);
				int num11 = y - num / 2 + method_9(GClass73.int_8 - num - l * 4);
				g.method_16(int_50[num3][l]);
				g.method_15(num10 - int_51[l] / 2, num11 - int_51[l] / 2, int_51[l], int_51[l]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8 && upgrade != 12 && upgrade != 2 && upgrade != 5 && upgrade != 9 && upgrade != 13 && upgrade != 3 && upgrade != 6 && upgrade != 10 && upgrade != 15)
		{
			for (int m = num2; m < int_51.Length; m++)
			{
				int num12 = x - num / 2 + method_10(GClass73.int_8 - num * 3 - m * 4);
				int num13 = y - num / 2 + method_9(GClass73.int_8 - num * 3 - m * 4);
				g.method_16(int_50[num3][m]);
				g.method_15(num12 - int_51[m] / 2, num13 - int_51[m] / 2, int_51[m], int_51[m]);
			}
		}
	}

	private int method_9(int int_52)
	{
		int num = GClass144.int_42 - 2;
		int num2 = int_52 % (4 * num);
		if (0 > num2 || num2 >= num)
		{
			if (num <= num2 && num2 < num * 2)
				return num2 % num;
			if (num * 2 > num2 || num2 >= num * 3)
				return num - num2 % num;
			return num;
		}
		return 0;
	}

	private int method_10(int int_52)
	{
		int num = GClass144.int_42 - 2;
		int num2 = int_52 % (4 * num);
		if (0 <= num2 && num2 < num)
			return num2 % num;
		if (num <= num2 && num2 < num * 2)
			return num;
		if (num * 2 > num2 || num2 >= num * 3)
			return 0;
		return num - num2 % num;
	}

	public bool method_11(int id)
	{
		for (int i = 0; i < gclass120_0.Length; i++)
		{
			GClass120 gClass = gclass120_0[i];
			if (gClass != null && gClass.gclass126_0.int_0 == id)
				return true;
		}
		return false;
	}

	public GClass128 method_12()
	{
		GClass128 gClass = new GClass128();
		gClass.gclass117_0 = gclass117_0;
		if (gclass88_0 != null)
		{
			gClass.gclass88_0 = new GClass88();
			for (int i = 0; i < gclass88_0.method_2(); i++)
			{
				GClass120 gClass2 = new GClass120();
				gClass2.gclass126_0 = ((GClass120)gclass88_0.method_3(i)).gclass126_0;
				gClass2.int_0 = ((GClass120)gclass88_0.method_3(i)).int_0;
				gClass.gclass88_0.method_0(gClass2);
			}
		}
		gClass.int_27 = int_27;
		gClass.int_28 = int_28;
		gClass.int_29 = int_29;
		gClass.int_30 = int_30;
		gClass.bool_1 = bool_1;
		gClass.int_32 = int_32;
		gClass.int_33 = int_33;
		gClass.int_34 = int_34;
		gClass.int_35 = int_35;
		gClass.int_36 = int_36;
		gClass.int_37 = int_37;
		gClass.int_38 = int_38;
		gClass.int_41 = int_41;
		gClass.bool_2 = bool_2;
		return gClass;
	}

	public bool method_13()
	{
		if ((0 <= gclass117_0.sbyte_0 && gclass117_0.sbyte_0 < 6) || gclass117_0.sbyte_0 == 32 || gclass117_0.sbyte_0 == 35 || gclass117_0.sbyte_0 == 11 || gclass117_0.sbyte_0 == 23)
			return true;
		return false;
	}

	public string method_14()
	{
		return bool_1 ? mResources.LOCKED : mResources.NOLOCK;
	}

	public string method_15()
	{
		if (gclass117_0.sbyte_2 < 10 || gclass117_0.sbyte_0 >= 10)
			return mResources.NOTUPGRADE;
		if (int_33 == 0)
			return mResources.NOUPGRADE;
		return null;
	}

	public bool method_16()
	{
		if (int_41 != 5 && int_41 != 3 && int_41 != 4)
			return false;
		return true;
	}

	public bool method_17()
	{
		if (!method_18())
		{
			if (method_20() || method_21() || method_22())
				return true;
			return false;
		}
		return true;
	}

	public bool method_18()
	{
		if (int_41 == 20 || int_41 == 21 || int_41 == 22 || int_41 == 23 || int_41 == 24 || int_41 == 25 || int_41 == 26 || int_41 == 27 || int_41 == 28 || int_41 == 29 || int_41 == 16 || int_41 == 17 || int_41 == 18 || int_41 == 19 || int_41 == 2 || int_41 == 6 || int_41 == 8)
			return true;
		return false;
	}

	public bool method_19()
	{
		if (int_41 == 7 || int_41 == 9)
			return true;
		return false;
	}

	public bool method_20()
	{
		if (int_41 != 14)
			return false;
		return true;
	}

	public bool method_21()
	{
		if (int_41 != 15)
			return false;
		return true;
	}

	public bool method_22()
	{
		if (int_41 == 32)
			return true;
		return false;
	}

	public bool method_23()
	{
		if (method_24() == int_33)
			return true;
		return false;
	}

	public int method_24()
	{
		if (gclass117_0.sbyte_2 >= 1 && gclass117_0.sbyte_2 < 20)
			return 4;
		if (gclass117_0.sbyte_2 < 20 || gclass117_0.sbyte_2 >= 40)
		{
			if (gclass117_0.sbyte_2 < 40 || gclass117_0.sbyte_2 >= 50)
			{
				if (gclass117_0.sbyte_2 < 50 || gclass117_0.sbyte_2 >= 60)
					return 16;
				return 14;
			}
			return 12;
		}
		return 8;
	}

	public void method_25(int headTemp, int bodyTemp, int legTemp, int bagTemp)
	{
		int_44 = headTemp;
		int_45 = bodyTemp;
		int_46 = legTemp;
		int_47 = bagTemp;
	}
}
