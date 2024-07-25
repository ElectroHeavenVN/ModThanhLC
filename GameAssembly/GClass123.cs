public class GClass123 : GClass122
{
	public static GClass123 gclass123_0 = new GClass123();

	public static GClass123 gclass123_1 = new GClass123();

	public static GClass123 gclass123_2 = new GClass123();

	public static GClass123 gclass123_3 = new GClass123();

	public void method_13()
	{
		for (int num = method_2() - 1; num >= 0; num--)
		{
			GClass101 gClass = (GClass101)method_3(num);
			if (gClass != null)
			{
				gClass.method_1();
				if (gClass.bool_0)
					method_7(num);
			}
		}
	}

	public static void smethod_0()
	{
		gclass123_3.method_13();
		gclass123_1.method_13();
		gclass123_2.method_13();
		gclass123_0.method_13();
	}

	public void method_14(GClass193 g)
	{
		for (int i = 0; i < method_2(); i++)
		{
			GClass101 gClass = (GClass101)method_3(i);
			if (gClass != null && !gClass.bool_0)
				((GClass101)method_3(i)).method_2(g);
		}
	}

	public void method_15()
	{
		for (int num = method_2() - 1; num >= 0; num--)
		{
			GClass101 gClass = (GClass101)method_3(num);
			if (gClass != null)
			{
				gClass.bool_0 = true;
				method_7(num);
			}
		}
	}

	public static void smethod_1()
	{
		gclass123_3.method_15();
		gclass123_0.method_15();
		gclass123_2.method_15();
		gclass123_1.method_15();
	}

	public static void smethod_2(GClass101 eff)
	{
		gclass123_3.method_0(eff);
	}

	public static void smethod_3(GClass101 eff)
	{
		gclass123_2.method_0(eff);
	}

	public static void smethod_4(GClass101 eff)
	{
		gclass123_1.method_0(eff);
	}

	public static void smethod_5(GClass101 eff)
	{
		gclass123_0.method_0(eff);
	}
}
