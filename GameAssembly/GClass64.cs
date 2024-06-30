using ns1;

public class GClass64 : GClass63
{
	public static GClass64 gclass64_0 = new GClass64();

	public static GClass64 gclass64_1 = new GClass64();

	public static GClass64 gclass64_2 = new GClass64();

	public static GClass64 gclass64_3 = new GClass64();

	public void method_13()
	{
		for (int num = method_2() - 1; num >= 0; num--)
		{
			GClass116 gClass = (GClass116)method_3(num);
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
		gclass64_3.method_13();
		gclass64_1.method_13();
		gclass64_2.method_13();
		gclass64_0.method_13();
	}

	public void method_14(GClass76 g)
	{
		if (GClass173.smethod_0().bool_9)
			return;
		for (int i = 0; i < method_2(); i++)
		{
			GClass116 gClass = (GClass116)method_3(i);
			if (gClass != null && !gClass.bool_0)
				((GClass116)method_3(i)).method_2(g);
		}
	}

	public void method_15()
	{
		for (int num = method_2() - 1; num >= 0; num--)
		{
			GClass116 gClass = (GClass116)method_3(num);
			if (gClass != null)
			{
				gClass.bool_0 = true;
				method_7(num);
			}
		}
	}

	public static void smethod_1()
	{
		gclass64_3.method_15();
		gclass64_0.method_15();
		gclass64_2.method_15();
		gclass64_1.method_15();
	}

	public static void smethod_2(GClass116 eff)
	{
		gclass64_3.method_0(eff);
	}

	public static void smethod_3(GClass116 eff)
	{
		gclass64_2.method_0(eff);
	}

	public static void smethod_4(GClass116 eff)
	{
		gclass64_1.method_0(eff);
	}

	public static void smethod_5(GClass116 eff)
	{
		gclass64_0.method_0(eff);
	}
}
