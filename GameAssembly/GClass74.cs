public class GClass74
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public GClass78 gclass78_0;

	public GClass3 gclass3_0;

	public static sbyte[] sbyte_0 = new sbyte[25]
	{
		0, 1, 2, 1, 0, 1, 2, 1, 0, 1,
		2, 1, 0, 1, 2, 1, 0, 1, 2, 1,
		0, 1, 2, 1, 0
	};

	public static int[] int_9 = new int[18]
	{
		0, 15, 37, 52, 75, 105, 127, 142, 165, 195,
		217, 232, 255, 285, 307, 322, 345, 370
	};

	public static int[] int_10 = new int[16]
	{
		0, 0, 0, 7, 6, 6, 6, 2, 2, 3,
		3, 4, 5, 5, 5, 1
	};

	public GClass74(GClass78 charBelong, GClass3 arrp)
	{
		gclass78_0 = charBelong;
		gclass3_0 = arrp;
	}

	public void method_0()
	{
		if (gclass78_0.gclass194_0 == null && gclass78_0.gclass78_0 == null)
		{
			method_1();
			return;
		}
		if (gclass78_0.gclass194_0 != null)
		{
			int_3 = gclass78_0.gclass194_0.int_8;
			int_4 = gclass78_0.gclass194_0.int_9 - gclass78_0.gclass194_0.int_21 / 4;
		}
		else if (gclass78_0.gclass78_0 != null)
		{
			int_3 = gclass78_0.gclass78_0.int_4;
			int_4 = gclass78_0.gclass78_0.int_5 - gclass78_0.gclass78_0.int_58 / 4;
		}
		int num = int_3 - int_1;
		int num2 = int_4 - int_2;
		int num3 = 5;
		int num4 = 4;
		if (num + num2 >= 60)
		{
			if (num + num2 < 30)
				num4 = 2;
		}
		else
			num4 = 3;
		if (int_1 != int_3)
		{
			if (num > 0 && num < num3)
				int_1 = int_3;
			else if (num < 0 && num > -num3)
			{
				int_1 = int_3;
			}
			else
			{
				int_5 = int_3 - int_1 << 2;
				int_7 += int_5;
				int_1 += int_7 >> num4;
				int_7 &= 15;
			}
		}
		if (int_2 != int_4)
		{
			if (num2 > 0 && num2 < num3)
				int_2 = int_4;
			else if (num2 < 0 && num2 > -num3)
			{
				int_2 = int_4;
			}
			else
			{
				int_6 = int_4 - int_2 << 2;
				int_8 += int_6;
				int_2 += int_8 >> num4;
				int_8 &= 15;
			}
		}
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		if (gclass78_0.gclass194_0 == null)
		{
			if (gclass78_0.gclass78_0 != null)
			{
				num5 = int_3 - gclass78_0.gclass78_0.int_57 / 4;
				num7 = int_3 + gclass78_0.gclass78_0.int_57 / 4;
				num6 = int_4 - gclass78_0.gclass78_0.int_58 / 4;
				num8 = int_4 + gclass78_0.gclass78_0.int_58 / 4;
			}
		}
		else
		{
			num5 = int_3 - gclass78_0.gclass194_0.int_20 / 4;
			num7 = int_3 + gclass78_0.gclass194_0.int_20 / 4;
			num6 = int_4 - gclass78_0.gclass194_0.int_21 / 4;
			num8 = int_4 + gclass78_0.gclass194_0.int_21 / 4;
		}
		if (int_0 > 0)
			int_0--;
		if (int_0 == 0 || (int_1 >= num5 && int_1 <= num7 && int_2 >= num6 && int_2 <= num8))
			method_1();
	}

	private void method_1()
	{
		gclass78_0.gclass74_0 = null;
		int_8 = 0;
		int_7 = 0;
		int_6 = 0;
		int_5 = 0;
		int_4 = 0;
		int_3 = 0;
		int_2 = 0;
		int_1 = 0;
		gclass78_0.method_76();
		if (gclass78_0.bool_10)
			gclass78_0.method_28();
	}

	public void method_2(GClass122 g)
	{
		int num = smethod_0(GClass50.smethod_5(int_3 - int_1, -(int_4 - int_2)));
		GClass28.smethod_6(g, gclass3_0.int_10[sbyte_0[num]], int_1, int_2, int_10[num], GClass122.int_1 | GClass122.int_0);
	}

	public static int smethod_0(int angle)
	{
		int num = 0;
		while (true)
		{
			if (num < int_9.Length - 1)
			{
				if (angle >= int_9[num] && angle <= int_9[num + 1])
					break;
				num++;
				continue;
			}
			return 0;
		}
		if (num < 16)
			return num;
		return 0;
	}
}
