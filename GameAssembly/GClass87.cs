using AssemblyCSharp.Functions;

public class GClass87
{
	public bool bool_0;

	public GDelegate1 gdelegate1_0;

	public string string_0;

	public string[] string_1;

	public GInterface6 ginterface6_0;

	public int int_0;

	public bool bool_1 = true;

	public GClass70 gclass70_0;

	public GClass70 gclass70_1;

	public int int_1;

	public int int_2;

	public int int_3 = GClass131.int_2;

	public int int_4 = GClass131.int_3;

	public int int_5;

	private int int_6;

	public bool bool_2;

	public object object_0;

	public int int_7;

	public string string_2 = "";

	public static GClass70 gclass70_2;

	public static GClass70 gclass70_3;

	public static GClass70 gclass70_4;

	public static GClass70 gclass70_5;

	public static GClass70 gclass70_6;

	public static GClass70 gclass70_7;

	public bool bool_3;

	public GClass87(string caption, GInterface6 actionListener, int action, object p, int x, int y)
	{
		string_0 = caption;
		int_0 = action;
		ginterface6_0 = actionListener;
		object_0 = p;
		int_1 = x;
		int_2 = y;
	}

	public GClass87()
	{
	}

	public GClass87(string caption, GInterface6 actionListener, int action, object p)
	{
		string_0 = caption;
		int_0 = action;
		ginterface6_0 = actionListener;
		object_0 = p;
	}

	public GClass87(string caption, int action, object p)
	{
		string_0 = caption;
		int_0 = action;
		object_0 = p;
	}

	public GClass87(string caption, int action)
	{
		string_0 = caption;
		int_0 = action;
	}

	public GClass87(string caption, int action, int x, int y)
	{
		string_0 = caption;
		int_0 = action;
		int_1 = x;
		int_2 = y;
	}

	public void method_0(string str)
	{
		if (gdelegate1_0 != null)
			gdelegate1_0(str);
	}

	public void method_1()
	{
		GClass73.smethod_49();
		if (bool_1 && ((string_0 != null && !string_0.Equals("") && !string_0.Equals(mResources.saying)) || gclass70_0 != null))
			GClass109.smethod_1().method_35();
		if (int_0 > 0)
		{
			if (ginterface6_0 != null)
				ginterface6_0.perform(int_0, object_0);
			else
				GClass144.smethod_8().method_117(int_0, object_0);
		}
	}

	public void method_2()
	{
		int_7 = 1;
		int_3 = 160;
		int_5 = 80;
	}

	public void method_3(GClass122 g)
	{
		if (GClass167.smethod_0().bool_17)
			return;
		if (gclass70_0 != null)
		{
			g.method_31(gclass70_0, int_1, int_2 + GClass122.int_24, 0);
			if (bool_2)
			{
				if (gclass70_1 != null)
					g.method_31(gclass70_1, int_1, int_2 + GClass122.int_24, 0);
				else if (bool_3)
				{
					g.method_31(GClass64.gclass70_0, int_1 + 8, int_2 + GClass122.int_24 + 8, 3);
				}
				else
				{
					g.method_31(GClass64.gclass70_0, int_1 - (gclass70_0.Equals(GClass144.gclass70_11) ? 10 : 0), int_2 + GClass122.int_24, 0);
				}
			}
			if (string_0 != "menu" && string_0 != null)
			{
				if (!bool_2)
					GClass4.gclass4_6.method_6(g, string_0, int_1 + GClass122.smethod_0(gclass70_0) / 2, int_2 + GClass122.smethod_1(gclass70_0) / 2 - 5, 2);
				else
					GClass4.gclass4_7.method_6(g, string_0, int_1 + GClass122.smethod_0(gclass70_0) / 2, int_2 + GClass122.smethod_1(gclass70_0) / 2 - 5, 2);
			}
			return;
		}
		if (string_0 != "")
		{
			if (int_7 != 1)
			{
				if (!bool_2)
					smethod_0(gclass70_2, gclass70_3, gclass70_4, int_1, int_2, 76, g);
				else
					smethod_0(gclass70_5, gclass70_6, gclass70_7, int_1, int_2, 76, g);
			}
			else if (!bool_2)
			{
				smethod_0(gclass70_2, gclass70_3, gclass70_4, int_1, int_2, 160, g);
			}
			else
			{
				smethod_0(gclass70_5, gclass70_6, gclass70_7, int_1, int_2, 160, g);
			}
		}
		int x = ((int_7 != 1) ? (int_1 + 38) : (int_1 + int_5));
		if (!bool_2)
			GClass4.gclass4_6.method_6(g, string_0, x, int_2 + 7, 2);
		else
			GClass4.gclass4_7.method_6(g, string_0, x, int_2 + 7, 2);
	}

	public static void smethod_0(GClass70 img0, GClass70 img1, GClass70 img2, int x, int y, int size, GClass122 g)
	{
		for (int i = 10; i <= size - 20; i += 10)
		{
			g.method_31(img1, x + i, y, 0);
		}
		int num = size % 10;
		if (num > 0)
			g.method_23(img1, 0, 0, num, 24, 0, x + size - 10 - num, y, 0);
		g.method_31(img0, x, y, 0);
		g.method_31(img2, x + size - 10, y, 0);
	}

	public bool method_4()
	{
		bool_2 = false;
		if (GClass73.smethod_24(int_1, int_2, int_3, int_4))
		{
			if (GClass73.bool_14)
				bool_2 = true;
			if (GClass73.bool_16 && GClass73.bool_15)
				return true;
		}
		return false;
	}

	public bool method_5(int cmx, int cmy)
	{
		bool_2 = false;
		if (GClass73.smethod_24(int_1 - cmx, int_2 - cmy, int_3, int_4))
		{
			GClass50.smethod_8("w= " + int_3);
			if (GClass73.bool_14)
				bool_2 = true;
			if (GClass73.bool_16 && GClass73.bool_15)
				return true;
		}
		return false;
	}
}
