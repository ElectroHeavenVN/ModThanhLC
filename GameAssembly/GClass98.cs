using ns1;

public class GClass98
{
	public static GClass122 gclass122_0 = new GClass122();

	public static void smethod_0(GClass85 me)
	{
		gclass122_0.method_0(me);
	}

	public static void smethod_1(int id)
	{
		if (smethod_2(id) != null)
			gclass122_0.method_8(smethod_2(id));
	}

	public static GClass85 smethod_2(int id)
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			GClass85 gClass = (GClass85)gclass122_0.method_3(i);
			if (gClass.int_0 == id)
				return gClass;
		}
		return null;
	}

	public static void smethod_3(GClass193 g, int x, int y, int layer)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			if (((GClass85)gclass122_0.method_3(i)).int_46 == -layer)
				((GClass85)gclass122_0.method_3(i)).method_1(g, x, y);
		}
	}

	public static void smethod_4(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			if (((GClass85)gclass122_0.method_3(i)).int_46 == 1)
				((GClass85)gclass122_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_5(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			if (((GClass85)gclass122_0.method_3(i)).int_46 == 2)
				((GClass85)gclass122_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_6(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			if (((GClass85)gclass122_0.method_3(i)).int_46 == 3)
				((GClass85)gclass122_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_7(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			if (((GClass85)gclass122_0.method_3(i)).int_46 == 4)
				((GClass85)gclass122_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_8()
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			((GClass85)gclass122_0.method_3(i)).method_4();
		}
	}
}
