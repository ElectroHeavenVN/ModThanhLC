using UnityEngine;

public class GClass206
{
	public static string string_0 = "112.213.94.23";

	public static int int_0 = 14445;

	public static string string_1;

	public static int int_1;

	public static sbyte sbyte_0;

	public static int int_2;

	public static string string_2 = "2.3.7";

	public static int int_3 = 237;

	public static GClass14 gclass14_0;

	public static GClass206 gclass206_0;

	public static bool bool_0;

	public static bool bool_1;

	public GClass206()
	{
		method_0();
	}

	public void method_0()
	{
		gclass206_0 = this;
		GClass178.gclass178_0 = new GClass178();
		GClass179.smethod_0().setHandler(GClass93.smethod_0());
		GClass32.smethod_0().setHandler(GClass93.smethod_0());
		GClass32.bool_0 = false;
		gclass206_0 = this;
		gclass14_0 = new GClass14();
		gclass14_0.method_6();
		GClass172.smethod_4();
		GClass172.smethod_2();
		GClass14.gclass160_0 = new GClass172();
	}

	public void method_1()
	{
		if (Main.typeClient != 6)
		{
			GClass14.bool_10 = false;
			GClass77.smethod_26();
			method_2();
		}
		else
			GClass77.smethod_31();
	}

	public static void smethod_0(string data, string to, GClass118 successAction, GClass118 failAction)
	{
		GClass92.smethod_0("SEND SMS");
	}

	public static void smethod_1(string url)
	{
		GClass92.smethod_5("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}

	public void method_2()
	{
		Main.exit();
	}

	public void method_3(string url)
	{
		GClass92.smethod_5("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}
}
