using ns1;

public class GClass81
{
	public static GClass63 gclass63_0 = new GClass63();

	public static void smethod_0(GClass33 me)
	{
		gclass63_0.method_0(me);
	}

	public static void smethod_1(int id)
	{
		if (smethod_2(id) != null)
			gclass63_0.method_8(smethod_2(id));
	}

	public static GClass33 smethod_2(int id)
	{
		int num = 0;
		GClass33 gClass;
		while (true)
		{
			if (num < gclass63_0.method_2())
			{
				gClass = (GClass33)gclass63_0.method_3(num);
				if (gClass.int_0 == id)
					break;
				num++;
				continue;
			}
			return null;
		}
		return gClass;
	}

	public static void smethod_3(GClass76 g, int x, int y, int layer)
	{
		if (GClass173.smethod_0().bool_9)
			return;
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			if (((GClass33)gclass63_0.method_3(i)).int_46 == -layer)
				((GClass33)gclass63_0.method_3(i)).method_1(g, x, y);
		}
	}

	public static void smethod_4(GClass76 g)
	{
		if (GClass173.smethod_0().bool_9)
			return;
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			if (((GClass33)gclass63_0.method_3(i)).int_46 == 1)
				((GClass33)gclass63_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_5(GClass76 g)
	{
		if (GClass173.smethod_0().bool_9)
			return;
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			if (((GClass33)gclass63_0.method_3(i)).int_46 == 2)
				((GClass33)gclass63_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_6(GClass76 g)
	{
		if (GClass173.smethod_0().bool_9)
			return;
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			if (((GClass33)gclass63_0.method_3(i)).int_46 == 3)
				((GClass33)gclass63_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_7(GClass76 g)
	{
		if (GClass173.smethod_0().bool_9)
			return;
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			if (((GClass33)gclass63_0.method_3(i)).int_46 == 4)
				((GClass33)gclass63_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_8()
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			((GClass33)gclass63_0.method_3(i)).method_4();
		}
	}
}
