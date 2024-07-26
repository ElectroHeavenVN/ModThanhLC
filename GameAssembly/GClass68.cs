public class GClass68
{
	public int int_0;

	public string string_0;

	public short[] short_0;

	public int int_1;

	public int int_2;

	public static GClass88 gclass88_0 = new GClass88();

	public static GClass113 gclass113_0 = new GClass113();

	public static void smethod_0(GClass68 cm)
	{
		GClass7.smethod_0().method_16((sbyte)cm.int_0);
		gclass88_0.method_0(cm);
	}

	public static GClass68 smethod_1(short ID)
	{
		int num = 0;
		GClass68 gClass;
		while (true)
		{
			if (num < gclass88_0.method_2())
			{
				gClass = (GClass68)gclass88_0.method_3(num);
				if (gClass.int_0 == ID)
					break;
				num++;
				continue;
			}
			return null;
		}
		return gClass;
	}

	public static bool smethod_2(int ID)
	{
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			if (((GClass68)gclass88_0.method_3(i)).int_0 == ID)
				return true;
		}
		return false;
	}
}
