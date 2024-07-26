public class GClass89 : GClass88
{
	public static GClass89 gclass89_0 = new GClass89();

	public static GClass89 gclass89_1 = new GClass89();

	public static GClass89 gclass89_2 = new GClass89();

	public static GClass89 gclass89_3 = new GClass89();

	public void method_13()
	{
		for (int num = method_2() - 1; num >= 0; num--)
		{
			GClass107 gClass = (GClass107)method_3(num);
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
		gclass89_3.method_13();
		gclass89_1.method_13();
		gclass89_2.method_13();
		gclass89_0.method_13();
	}

	public void method_14(GClass122 g)
	{
		for (int i = 0; i < method_2(); i++)
		{
			GClass107 gClass = (GClass107)method_3(i);
			if (gClass != null && !gClass.bool_0)
				((GClass107)method_3(i)).method_2(g);
		}
	}

	public void method_15()
	{
		for (int num = method_2() - 1; num >= 0; num--)
		{
			GClass107 gClass = (GClass107)method_3(num);
			if (gClass != null)
			{
				gClass.bool_0 = true;
				method_7(num);
			}
		}
	}

	public static void smethod_1()
	{
		gclass89_3.method_15();
		gclass89_0.method_15();
		gclass89_2.method_15();
		gclass89_1.method_15();
	}

	public static void smethod_2(GClass107 eff)
	{
		gclass89_3.method_0(eff);
	}

	public static void smethod_3(GClass107 eff)
	{
		gclass89_2.method_0(eff);
	}

	public static void smethod_4(GClass107 eff)
	{
		gclass89_1.method_0(eff);
	}

	public static void smethod_5(GClass107 eff)
	{
		gclass89_0.method_0(eff);
	}
}
