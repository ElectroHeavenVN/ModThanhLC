public class GClass68
{
	public int int_0;

	public string string_0;

	public short[] short_0;

	public int int_1;

	public int int_2;

	public static GClass122 gclass122_0 = new GClass122();

	public static GClass175 gclass175_0 = new GClass175();

	public static void smethod_0(GClass68 cm)
	{
		GClass2.smethod_0().method_16((sbyte)cm.int_0);
		gclass122_0.method_0(cm);
	}

	public static GClass68 smethod_1(short ID)
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			GClass68 gClass = (GClass68)gclass122_0.method_3(i);
			if (gClass.int_0 == ID)
				return gClass;
		}
		return null;
	}

	public static bool smethod_2(int ID)
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			if (((GClass68)gclass122_0.method_3(i)).int_0 == ID)
				return true;
		}
		return false;
	}
}
