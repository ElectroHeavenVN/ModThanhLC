using AssemblyCSharp.Functions;

public class GClass57
{
	public static GClass88 gclass88_0 = new GClass88();

	public static void smethod_0(GClass81 me)
	{
		gclass88_0.method_0(me);
	}

	public static void smethod_1(int id)
	{
		if (smethod_2(id) != null)
			gclass88_0.method_8(smethod_2(id));
	}

	public static GClass81 smethod_2(int id)
	{
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			GClass81 gClass = (GClass81)gclass88_0.method_3(i);
			if (gClass.int_0 == id)
				return gClass;
		}
		return null;
	}

	public static void smethod_3(GClass122 g, int x, int y, int layer)
	{
		if (GClass167.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			if (((GClass81)gclass88_0.method_3(i)).int_46 == -layer)
				((GClass81)gclass88_0.method_3(i)).method_1(g, x, y);
		}
	}

	public static void smethod_4(GClass122 g)
	{
		if (GClass167.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			if (((GClass81)gclass88_0.method_3(i)).int_46 == 1)
				((GClass81)gclass88_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_5(GClass122 g)
	{
		if (GClass167.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			if (((GClass81)gclass88_0.method_3(i)).int_46 == 2)
				((GClass81)gclass88_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_6(GClass122 g)
	{
		if (GClass167.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			if (((GClass81)gclass88_0.method_3(i)).int_46 == 3)
				((GClass81)gclass88_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_7(GClass122 g)
	{
		if (GClass167.smethod_0().bool_10)
			return;
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			if (((GClass81)gclass88_0.method_3(i)).int_46 == 4)
				((GClass81)gclass88_0.method_3(i)).method_3(g);
		}
	}

	public static void smethod_8()
	{
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			((GClass81)gclass88_0.method_3(i)).method_4();
		}
	}
}
