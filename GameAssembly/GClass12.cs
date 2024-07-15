public class GClass12
{
	public sbyte sbyte_0;

	public int int_0;

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

	public int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	public int int_18;

	public int int_19;

	public int int_20;

	public int int_21;

	public int int_22;

	public int int_23;

	public int int_24;

	public int int_25;

	public int int_26;

	public int int_27;

	public int int_28;

	public int int_29;

	public int int_30;

	public int int_31 = 1;

	public int int_32;

	public int int_33;

	public int int_34;

	public int int_35;

	public int int_36;

	public int int_37;

	public int int_38;

	public int int_39;

	public int int_40;

	public long long_0;

	public long long_1;

	public GClass122 gclass122_0;

	public string string_0;

	public string string_1;

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public static GClass117[] gclass117_0;

	public GClass117 gclass117_1;

	public GClass117 gclass117_2;

	public short short_0;

	public byte[] byte_0 = new byte[24]
	{
		12, 11, 10, 9, 8, 7, 6, 5, 4, 3,
		2, 1, 0, 23, 22, 21, 20, 19, 18, 17,
		16, 15, 14, 13
	};

	public byte[] byte_1 = new byte[24]
	{
		0, 0, 2, 1, 1, 2, 0, 0, 2, 1,
		1, 2, 0, 0, 2, 1, 1, 2, 0, 0,
		2, 1, 1, 2
	};

	public byte[] byte_2 = new byte[24]
	{
		2, 2, 3, 3, 3, 4, 5, 5, 5, 5,
		5, 1, 0, 0, 0, 0, 0, 7, 6, 6,
		6, 6, 6, 2
	};

	public GClass12()
	{
	}

	public GClass12(int x, int y)
	{
		int_0 = x;
		int_1 = y;
	}

	public GClass12(int x, int y, int goc)
	{
		int_0 = x;
		int_1 = y;
		int_22 = goc;
	}

	public void method_0()
	{
		int_16++;
		int_0 += int_9;
		int_1 += int_10;
	}

	public void method_1()
	{
		int_0 += int_9;
		int_1 += int_10;
	}

	public void method_2(GClass193 g)
	{
		if (!bool_0)
		{
			int num = 0;
			if (bool_1 && int_16 >= int_21)
				num = 1;
			gclass117_0[int_7].method_0(int_19 / 2 + num, int_0, int_1, int_15, 3, g);
		}
	}

	public void method_3()
	{
		int_16++;
		if (int_20 > 1)
		{
			int_19++;
			if (int_19 / 2 >= int_20)
				int_19 = 0;
		}
		if (int_16 >= int_18)
			bool_0 = true;
	}

	public int method_4(int goc)
	{
		if (goc > 15 && goc <= 345)
		{
			int num = (goc - 15) / 15 + 1;
			if (num > 24)
				num = 24;
			return byte_0[num];
		}
		return 12;
	}

	public void method_5(int vMax)
	{
		int_4 = vMax;
		int num = 0;
		int num2 = 0;
		num = int_13 - int_0;
		num2 = int_14 - int_1;
		if (int_0 > int_13)
		{
			int_26 = 2;
			int_27 = 0;
		}
		else
		{
			int_26 = 0;
			int_27 = 2;
		}
		method_6(num, num2);
	}

	public void method_6(int dx, int dy)
	{
		int_19 = method_4(GClass191.smethod_5(dx, dy));
		int num = 0;
		int num2 = 0;
		int num3 = GClass191.smethod_25(dx, dy) / int_4;
		if (num3 == 0)
			num3 = 1;
		num = dx / num3;
		num2 = dy / num3;
		if (num == 0 && dx < num3)
			num = ((dx >= 0) ? 1 : (-1));
		if (num2 == 0 && dy < num3)
			num2 = ((dy >= 0) ? 1 : (-1));
		if (GClass191.smethod_28(num) > GClass191.smethod_28(dx))
			num = dx;
		if (GClass191.smethod_28(num2) > GClass191.smethod_28(dy))
			num2 = dy;
		int_9 = num;
		int_10 = num2;
	}

	public void method_7(int toX, int toY)
	{
		int num = toX - int_0;
		int dy = toY - int_1;
		if (num > 1)
			int_19 = method_4(GClass191.smethod_5(num, dy));
		if (GClass191.smethod_28(int_9) > 0)
		{
			if (GClass191.smethod_28(int_0 - toX) >= GClass191.smethod_28(int_9))
				int_0 += int_9;
			else
			{
				int_0 = toX;
				int_9 = 0;
			}
		}
		else
		{
			int_0 = toX;
			int_9 = 0;
		}
		if (GClass191.smethod_28(int_10) > 0)
		{
			if (GClass191.smethod_28(int_1 - toY) >= GClass191.smethod_28(int_10))
			{
				int_1 += int_10;
				return;
			}
			int_1 = toY;
			int_10 = 0;
		}
		else
		{
			int_1 = toY;
			int_10 = 0;
		}
	}

	public void method_8(GClass193 g, GClass117 frm, int anchor, bool isCountFr)
	{
		if (frm != null)
		{
			int num = frm.int_2 / 3;
			if (num < 1)
				num = 1;
			int num2 = 0;
			int num3 = 3;
			int num4 = ((frm.int_2 <= 3) ? (int_16 % num) : ((int_16 / num3 % 2 != 0) ? 3 : 0));
			int idx = num * byte_1[int_19] + num4;
			if (frm.int_2 < 3)
				idx = int_16 / num3 % frm.int_2;
			if (isCountFr)
				idx = int_16 / num3 % frm.int_2;
			frm.method_0(idx, int_0, int_1, byte_2[int_19], anchor, g);
		}
	}
}
