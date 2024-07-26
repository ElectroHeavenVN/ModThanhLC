using System;
using AssemblyCSharp.Functions;
using Assets.src.e;

public class GClass28
{
	public static int[][] int_0;

	public static GClass28 gclass28_0;

	public static GClass70[] gclass70_0;

	public static GClass83[] gclass83_0;

	public static GClass88 gclass88_0 = new GClass88();

	public static GClass70 gclass70_1 = null;

	public static sbyte[] sbyte_0;

	public static int int_1;

	public static short short_0;

	public GClass28()
	{
		method_1();
	}

	public static void smethod_0()
	{
		if (gclass70_0 == null)
			gclass70_0 = new GClass70[5]
			{
				GClass73.smethod_42("/img/Big0.png"),
				GClass73.smethod_42("/img/Big1.png"),
				GClass73.smethod_42("/img/Big2.png"),
				GClass73.smethod_42("/img/Big3.png"),
				GClass73.smethod_42("/img/Big4.png")
			};
	}

	public static void smethod_1()
	{
		gclass70_0 = null;
		GClass203.smethod_26();
	}

	public static void smethod_2()
	{
		gclass70_1 = GClass70.smethod_9(new int[1], 1, 1, true);
	}

	public static void smethod_3()
	{
		gclass28_0 = null;
		gclass28_0 = new GClass28();
	}

	public void method_0(byte[] data)
	{
	}

	public void method_1()
	{
		int num = 0;
		try
		{
			GClass108 gClass = new GClass108(GClass1.smethod_1("NR_image"));
			short num2 = gClass.method_0();
			int_0 = new int[num2][];
			for (int i = 0; i < int_0.Length; i++)
			{
				int_0[i] = new int[5];
			}
			for (int j = 0; j < num2; j++)
			{
				num++;
				int_0[j][0] = gClass.method_10();
				int_0[j][1] = gClass.method_0();
				int_0[j][2] = gClass.method_0();
				int_0[j][3] = gClass.method_0();
				int_0[j][4] = gClass.method_0();
			}
		}
		catch (Exception ex)
		{
			GClass36.smethod_4("Loi readImage: " + ex.ToString() + "i= " + num);
		}
	}

	public static void smethod_4()
	{
	}

	public static void smethod_5(int id)
	{
		GClass50.smethod_8("is request =" + id + " zoom=" + GClass122.int_12);
		GClass70 gClass = GClass73.smethod_43("/SmallImage/Small" + id + ".png");
		if (gClass != null)
		{
			gclass83_0[id] = new GClass83(gClass, id);
			return;
		}
		bool flag = false;
		sbyte[] array = GClass1.smethod_1(GClass122.int_12 + "Small" + id);
		if (array != null)
		{
			if (sbyte_0 != null && array.Length % 127 != sbyte_0[id])
				flag = true;
			if (!flag)
			{
				GClass70 gClass2 = GClass70.smethod_6(array, 0, array.Length);
				if (gClass2 != null)
					gclass83_0[id] = new GClass83(gClass2, id);
				else
					flag = true;
			}
		}
		else
			flag = true;
		if (flag)
		{
			gclass83_0[id] = new GClass83(gclass70_1, id);
			GClass7.smethod_0().method_105(id);
		}
	}

	public static void smethod_6(GClass122 g, int id, int x, int y, int transform, int anchor)
	{
		if (GClass167.smethod_0().bool_21)
			return;
		if (gclass70_0 == null)
		{
			GClass83 gClass = gclass83_0[id];
			if (gClass == null)
				smethod_5(id);
			else
				g.method_46(gClass, 0, 0, GClass122.smethod_0(gClass.gclass70_0), GClass122.smethod_1(gClass.gclass70_0), transform, x, y, anchor);
		}
		else if (int_0 != null)
		{
			if (id < int_0.Length && int_0[id][1] < 256 && int_0[id][3] < 256 && int_0[id][2] < 256 && int_0[id][4] < 256)
			{
				if (gclass70_0[int_0[id][0]] != null)
					g.method_23(gclass70_0[int_0[id][0]], int_0[id][1], int_0[id][2], int_0[id][3], int_0[id][4], transform, x, y, anchor);
				return;
			}
			GClass83 gClass2 = gclass83_0[id];
			if (gClass2 != null)
				gClass2.method_0(g, transform, x, y, anchor);
			else
				smethod_5(id);
		}
		else if (GClass73.gclass131_0 != GClass144.smethod_8())
		{
			GClass83 gClass3 = gclass83_0[id];
			if (gClass3 != null)
				gClass3.method_0(g, transform, x, y, anchor);
			else
				smethod_5(id);
		}
	}

	public static void smethod_7(GClass122 g, int id, int f, int x, int y, int w, int h, int transform, int anchor)
	{
		if (gclass70_0 == null)
		{
			GClass83 gClass = gclass83_0[id];
			if (gClass != null)
				g.method_23(gClass.gclass70_0, 0, f * w, w, h, transform, x, y, anchor);
			else
				smethod_5(id);
		}
		else if (int_0 != null)
		{
			if (id < int_0.Length && int_0[id] != null && int_0[id][1] < 256 && int_0[id][3] < 256 && int_0[id][2] < 256 && int_0[id][4] < 256)
			{
				if (int_0[id][0] != 4 && gclass70_0[int_0[id][0]] != null)
				{
					g.method_23(gclass70_0[int_0[id][0]], 0, f * w, w, h, transform, x, y, anchor);
					return;
				}
				GClass83 gClass2 = gclass83_0[id];
				if (gClass2 == null)
					smethod_5(id);
				else
					gClass2.method_1(g, transform, f, x, y, w, h, anchor);
			}
			else
			{
				GClass83 gClass3 = gclass83_0[id];
				if (gClass3 == null)
					smethod_5(id);
				else
					gClass3.method_1(g, transform, f, x, y, w, h, anchor);
			}
		}
		else if (GClass73.gclass131_0 != GClass144.smethod_8())
		{
			GClass83 gClass4 = gclass83_0[id];
			if (gClass4 != null)
				gClass4.method_1(g, transform, f, x, y, w, h, anchor);
			else
				smethod_5(id);
		}
	}

	public static void smethod_8()
	{
		int num = 0;
		if (GClass73.int_8 % 1000 != 0)
			return;
		for (int i = 0; i < gclass83_0.Length; i++)
		{
			if (gclass83_0[i] != null)
			{
				num++;
				gclass83_0[i].method_3();
				int_1++;
			}
		}
		if (num > 200 && GClass73.bool_1)
			gclass83_0 = new GClass83[short_0];
	}
}
