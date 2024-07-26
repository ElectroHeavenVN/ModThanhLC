using System;

public class GClass2
{
	public Random random_0;

	public GClass2()
	{
		random_0 = new Random();
	}

	public int method_0()
	{
		return random_0.Next();
	}

	public int method_1(int a)
	{
		return random_0.Next(a);
	}

	public int method_2(int a, int b)
	{
		return random_0.Next(a, b);
	}
}
