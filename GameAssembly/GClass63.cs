public class GClass63
{
	public const sbyte sbyte_0 = 0;

	public const sbyte sbyte_1 = 1;

	public const sbyte sbyte_2 = 0;

	public const sbyte sbyte_3 = 1;

	public const sbyte sbyte_4 = 2;

	public const sbyte sbyte_5 = 3;

	public const sbyte sbyte_6 = 4;

	public GClass47 gclass47_0;

	public short short_0;

	public int int_0;

	public long long_0;

	public int int_1;

	public long long_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public GClass54[] gclass54_0;

	public bool bool_0;

	public short short_1;

	public string string_0;

	public short short_2;

	public short short_3;

	public string method_0()
	{
		if (short_3 / 10 >= 100)
			return "MAX";
		if (short_3 % 10 != 0)
		{
			int num = short_3 % 10;
			return short_3 / 10 + "." + num % 10 + "%";
		}
		return short_3 / 10 + "%";
	}

	public string method_1()
	{
		if (int_1 % 1000 == 0)
			return int_1 / 1000 + "";
		int num = int_1 % 1000;
		return int_1 / 1000 + "." + ((num % 100 == 0) ? (num / 100) : (num / 10));
	}

	public void method_2(int x, int y, GClass122 g)
	{
		GClass28.smethod_6(g, gclass47_0.int_4, x, y, 0, GClass188.int_6);
		long num = GClass203.smethod_18() - long_1;
		if (num < int_1)
		{
			g.method_20(2721889, 0.7f);
			if (bool_0 && GClass73.int_8 % 6 > 2)
				g.method_16(876862);
			int num2 = (int)(num * 20L / int_1);
			g.method_15(x - 10, y - 10 + num2, 20, 20 - num2);
		}
		else
			bool_0 = false;
	}
}
