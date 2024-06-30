using System;

public class GClass26
{
	public const double double_0 = Math.PI;

	public static int smethod_0(int i)
	{
		return (i <= 0) ? (-i) : i;
	}

	public static int smethod_1(int x, int y)
	{
		return (x >= y) ? y : x;
	}

	public static int smethod_2(int x, int y)
	{
		return (x <= y) ? y : x;
	}

	public static int smethod_3(int data, int x)
	{
		int num = 1;
		for (int i = 0; i < x; i++)
		{
			num *= data;
		}
		return num;
	}
}
