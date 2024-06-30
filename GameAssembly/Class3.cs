using System;

internal class Class3
{
	public sbyte sbyte_0;

	public string ehhIbedujh;

	public static GClass63 gclass63_0 = new GClass63();

	public static GClass63 gclass63_1 = new GClass63();

	public Class3(string string_0, sbyte sbyte_1)
	{
		ehhIbedujh = string_0;
		sbyte_0 = sbyte_1;
	}

	public static void smethod_0()
	{
		GClass63 vID = new GClass63();
		sbyte[] array = GClass120.smethod_1("ImageSource");
		if (array == null)
		{
			GClass166.smethod_0().method_136(vID);
			return;
		}
		gclass63_1 = new GClass63();
		GClass11 gClass = new GClass11(array);
		if (gClass == null)
			return;
		try
		{
			short num = gClass.method_0();
			string[] array2 = new string[num];
			sbyte[] array3 = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = gClass.method_6();
				array3[i] = gClass.method_7();
				gclass63_1.method_0(new Class3(array2[i], array3[i]));
			}
			gClass.method_4();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		GClass56.smethod_8("vS size= " + gclass63_0.method_2() + " vRMS size= " + gclass63_1.method_2());
		GClass166.smethod_0().method_136(vID);
	}

	public static sbyte smethod_1(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < gclass63_1.method_2())
			{
				if (string_0.Equals(((Class3)gclass63_1.method_3(num)).ehhIbedujh))
					break;
				num++;
				continue;
			}
			return -1;
		}
		return ((Class3)gclass63_1.method_3(num)).sbyte_0;
	}

	public static sbyte smethod_2(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < gclass63_0.method_2())
			{
				if (string_0.Equals(((Class3)gclass63_0.method_3(num)).ehhIbedujh))
					break;
				num++;
				continue;
			}
			return -1;
		}
		return ((Class3)gclass63_0.method_3(num)).sbyte_0;
	}

	public static bool smethod_3(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < gclass63_1.method_2())
			{
				if (string_0.Equals(((Class3)gclass63_1.method_3(num)).ehhIbedujh))
					break;
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void smethod_4()
	{
		GClass27 gClass = new GClass27();
		try
		{
			gClass.method_0((short)gclass63_0.method_2());
			for (int i = 0; i < gclass63_0.method_2(); i++)
			{
				gClass.method_6(((Class3)gclass63_0.method_3(i)).ehhIbedujh);
				gClass.method_5(((Class3)gclass63_0.method_3(i)).sbyte_0);
			}
			GClass120.smethod_0("ImageSource", gClass.method_3());
			gClass.method_4();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
	}
}
