using System;

internal class Class0
{
	public sbyte sbyte_0;

	public string string_0;

	public static GClass122 gclass122_0 = new GClass122();

	public static GClass122 gclass122_1 = new GClass122();

	public Class0(string string_1, sbyte sbyte_1)
	{
		string_0 = string_1;
		sbyte_0 = sbyte_1;
	}

	public static void smethod_0()
	{
		GClass122 vID = new GClass122();
		sbyte[] array = GClass141.smethod_1("ImageSource");
		if (array == null)
		{
			GClass2.smethod_0().method_136(vID);
			return;
		}
		gclass122_1 = new GClass122();
		GClass188 gClass = new GClass188(array);
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
				gclass122_1.method_0(new Class0(array2[i], array3[i]));
			}
			gClass.method_4();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		GClass191.smethod_8("vS size= " + gclass122_0.method_2() + " vRMS size= " + gclass122_1.method_2());
		GClass2.smethod_0().method_136(vID);
	}

	public static sbyte smethod_1(string string_1)
	{
		for (int i = 0; i < gclass122_1.method_2(); i++)
		{
			if (string_1.Equals(((Class0)gclass122_1.method_3(i)).string_0))
				return ((Class0)gclass122_1.method_3(i)).sbyte_0;
		}
		return -1;
	}

	public static sbyte smethod_2(string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < gclass122_0.method_2())
			{
				if (string_1.Equals(((Class0)gclass122_0.method_3(num)).string_0))
					break;
				num++;
				continue;
			}
			return -1;
		}
		return ((Class0)gclass122_0.method_3(num)).sbyte_0;
	}

	public static bool smethod_3(string string_1)
	{
		for (int i = 0; i < gclass122_1.method_2(); i++)
		{
			if (string_1.Equals(((Class0)gclass122_1.method_3(i)).string_0))
				return true;
		}
		return false;
	}

	public static void smethod_4()
	{
		GClass102 gClass = new GClass102();
		try
		{
			gClass.method_0((short)gclass122_0.method_2());
			for (int i = 0; i < gclass122_0.method_2(); i++)
			{
				gClass.method_6(((Class0)gclass122_0.method_3(i)).string_0);
				gClass.method_5(((Class0)gclass122_0.method_3(i)).sbyte_0);
			}
			GClass141.smethod_0("ImageSource", gClass.method_3());
			gClass.method_4();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
	}
}
