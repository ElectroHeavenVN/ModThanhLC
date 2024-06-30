public class GClass137
{
	public int int_0;

	public string string_0;

	public short[] short_0;

	public int int_1;

	public int int_2;

	public static GClass63 gclass63_0 = new GClass63();

	public static GClass9 gclass9_0 = new GClass9();

	public static void smethod_0(GClass137 cm)
	{
		GClass166.smethod_0().method_16((sbyte)cm.int_0);
		gclass63_0.method_0(cm);
	}

	public static GClass137 smethod_1(short ID)
	{
		int num = 0;
		GClass137 gClass;
		while (true)
		{
			if (num < gclass63_0.method_2())
			{
				gClass = (GClass137)gclass63_0.method_3(num);
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
		int num = 0;
		while (true)
		{
			if (num < gclass63_0.method_2())
			{
				if (((GClass137)gclass63_0.method_3(num)).int_0 == ID)
					break;
				num++;
				continue;
			}
			return false;
		}
		return true;
	}
}
