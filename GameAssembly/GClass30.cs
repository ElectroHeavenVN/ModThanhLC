using System.Threading;
using AssemblyCSharp.Functions;

public class GClass30
{
	public static GClass70 gclass70_0;

	public static int int_0;

	public static int int_1;

	public static int int_2;

	public static int int_3;

	public static int int_4;

	public static int int_5;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public static int int_9;

	public static bool bool_0;

	public static int int_10;

	public static bool bool_1;

	public static int int_11;

	public static int int_12;

	public static int int_13;

	public static bool bool_2;

	public static void smethod_0()
	{
		gclass70_0 = GClass73.smethod_43("/mainImage/myTexture2dmobCapcha.png");
	}

	public static void smethod_1(GClass122 g, int x, int y)
	{
		if (GClass165.smethod_0().bool_1 && GClass165.smethod_0().bool_0 && GClass122.int_12 == 1)
		{
			GClass165.smethod_0().bool_1 = false;
			new Thread(GClass165.smethod_0().method_0).Start();
		}
		if (!bool_2)
		{
			if (GClass73.int_8 % 3 == 0)
			{
				if (GClass78.smethod_1().int_12 == 1)
					int_5 = x - 20 - GClass144.int_22;
				if (GClass78.smethod_1().int_12 == -1)
					int_5 = x + 20 - GClass144.int_22;
			}
			int_0 = GClass78.smethod_1().int_5 - 40 - GClass144.int_23;
		}
		else
		{
			int_10++;
			if (int_10 == 5)
			{
				bool_2 = false;
				int_10 = 0;
			}
			int_5 = x - GClass144.int_22;
			int_0 = y - GClass144.int_23;
		}
		if (int_6 <= x - GClass144.int_22)
			int_13 = 1;
		else
			int_13 = -1;
		g.method_31(GClass144.gclass70_44, int_6, int_1 - 40, 3);
		GClass45.smethod_4(g, int_6 - 25, int_1 - 70, 50, 20, 16777215, false);
		GClass4.gclass4_6.method_6(g, GClass144.smethod_8().string_8, int_6, int_1 - 65, 2);
		if (bool_1)
		{
			bool_1 = false;
			GClass57.smethod_0(new GClass81(18, int_6 + GClass144.int_22, int_1 + GClass144.int_23, 2, 10, -1));
		}
		if (bool_0)
		{
			bool_0 = false;
			GClass57.smethod_0(new GClass81(18, int_6 + GClass144.int_22, int_1 + GClass144.int_23, 2, 10, -1));
			GClass144.smethod_8().gclass194_0 = null;
			int_5 = -GClass144.int_22;
			int_0 = -GClass144.int_23;
		}
		g.method_23(gclass70_0, 0, int_12 * 40, 40, 40, (int_13 != 1) ? 2 : 0, int_6, int_1 + 3 + ((GClass73.int_8 % 10 > 5) ? 1 : 0), 3);
		smethod_2();
	}

	public static void smethod_2()
	{
		if (int_1 != int_0)
		{
			int_3 = int_0 - int_1 << 2;
			int_2 += int_3;
			int_1 += int_2 >> 4;
			int_2 &= 15;
		}
		if (int_6 != int_5)
		{
			int_8 = int_5 - int_6 << 2;
			int_7 += int_8;
			int_6 += int_7 >> 4;
			int_7 &= 15;
		}
		int_11++;
		if (int_11 == 5)
		{
			int_11 = 0;
			int_12++;
			if (int_12 > 2)
				int_12 = 0;
		}
	}
}
