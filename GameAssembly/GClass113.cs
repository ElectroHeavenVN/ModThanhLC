using UnityEngine;

public class GClass113
{
	public static string string_0 = "112.213.94.23";

	public static int int_0 = 14445;

	public static string string_1;

	public static int int_1;

	public static sbyte sbyte_0;

	public static int int_2;

	public static string string_2 = "2.3.7";

	public static int int_3 = 237;

	public static GClass39 gclass39_0;

	public static GClass113 gclass113_0;

	public static bool bool_0;

	public static bool bool_1;

	public GClass113()
	{
		method_0();
	}

	public void method_0()
	{
		gclass113_0 = this;
		GClass119.gclass119_0 = new GClass119();
		GClass162.smethod_0().setHandler(GClass65.smethod_0());
		GClass143.smethod_0().setHandler(GClass65.smethod_0());
		GClass143.bool_0 = false;
		gclass113_0 = this;
		gclass39_0 = new GClass39();
		gclass39_0.method_6();
		GClass148.smethod_4();
		GClass148.smethod_2();
		GClass39.gclass145_0 = new GClass148();
	}

	public void method_1()
	{
		if (Main.typeClient == 6)
		{
			GClass138.smethod_31();
			return;
		}
		GClass39.bool_10 = false;
		GClass138.smethod_26();
		method_2();
	}

	public static void smethod_0(string data, string to, GClass14 successAction, GClass14 failAction)
	{
		GClass5.smethod_0("SEND SMS");
	}

	public static void smethod_1(string url)
	{
		GClass5.smethod_5("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}

	public void method_2()
	{
		Main.exit();
	}

	public void method_3(string url)
	{
		GClass5.smethod_5("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}
}
