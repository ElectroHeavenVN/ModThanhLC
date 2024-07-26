using UnityEngine;

public class GClass187
{
	public static string string_0 = "112.213.94.23";

	public static int int_0 = 14445;

	public static string string_1;

	public static int int_1;

	public static sbyte sbyte_0;

	public static int int_2;

	public static string string_2 = "2.3.7";

	public static int int_3 = 237;

	public static GClass73 gclass73_0;

	public static GClass187 gclass187_0;

	public static bool bool_0;

	public static bool bool_1;

	public GClass187()
	{
		method_0();
	}

	public void method_0()
	{
		gclass187_0 = this;
		GClass204.gclass204_0 = new GClass204();
		GClass14.smethod_0().setHandler(GClass12.smethod_0());
		GClass85.smethod_0().setHandler(GClass12.smethod_0());
		GClass85.bool_0 = false;
		gclass187_0 = this;
		gclass73_0 = new GClass73();
		gclass73_0.method_6();
		GClass142.smethod_4();
		GClass142.smethod_2();
		GClass73.gclass131_0 = new GClass142();
	}

	public void method_1()
	{
		if (Main.typeClient != 6)
		{
			GClass73.bool_10 = false;
			GClass203.smethod_26();
			method_2();
		}
		else
			GClass203.smethod_31();
	}

	public static void smethod_0(string data, string to, GClass87 successAction, GClass87 failAction)
	{
		GClass36.smethod_0("SEND SMS");
	}

	public static void smethod_1(string url)
	{
		GClass36.smethod_5("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}

	public void method_2()
	{
		Main.exit();
	}

	public void method_3(string url)
	{
		GClass36.smethod_5("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}
}
