public class GClass74
{
	public const sbyte sbyte_0 = 0;

	public const sbyte sbyte_1 = 1;

	public const sbyte sbyte_2 = 0;

	public const sbyte sbyte_3 = 1;

	public const sbyte sbyte_4 = 2;

	public const sbyte sbyte_5 = 3;

	public const sbyte sbyte_6 = 4;

	public GClass53 gclass53_0;

	public short short_0;

	public int int_0;

	public long long_0;

	public int int_1;

	public long long_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public GClass130[] gclass130_0;

	public bool bool_0;

	public short short_1;

	public string string_0;

	public short short_2;

	public short short_3;

	public string method_0()
	{
		if (short_3 / 10 >= 100)
			return "MAX";
		if (short_3 % 10 == 0)
			return short_3 / 10 + "%";
		return string.Concat(str2: (short_3 % 10 % 10).ToString(), str0: (short_3 / 10).ToString(), str1: ".", str3: "%");
	}

	public string method_1()
	{
		if (int_1 % 1000 == 0)
			return int_1 / 1000 + string.Empty;
		int num = int_1 % 1000;
		return int_1 / 1000 + "." + ((num % 100 != 0) ? (num / 10) : (num / 100));
	}

	public void method_2(int x, int y, GClass76 g)
	{
		GClass96.smethod_6(g, gclass53_0.int_4, x, y, 0, GClass169.int_6);
		long num = GClass138.smethod_18() - long_1;
		if (num < int_1)
		{
			g.method_20(2721889, 0.7f);
			if (bool_0 && GClass39.int_8 % 6 > 2)
				g.method_16(876862);
			int num2 = (int)(num * 20L / int_1);
			g.method_15(x - 10, y - 10 + num2, 20, 20 - num2);
		}
		else
			bool_0 = false;
	}
}
