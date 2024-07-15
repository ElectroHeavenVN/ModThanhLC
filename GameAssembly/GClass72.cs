using System;
using ns1;

public class GClass72
{
	public static int[][] int_0;

	public static GClass72 gclass72_0;

	public static GClass20[] gclass20_0;

	public static GClass26[] gclass26_0;

	public static GClass122 gclass122_0 = new GClass122();

	public static GClass20 gclass20_1 = null;

	public static sbyte[] sbyte_0;

	public static int int_1;

	public static short short_0;

	public GClass72()
	{
		method_1();
	}

	public static void smethod_0()
	{
		if (gclass20_0 == null)
			gclass20_0 = new GClass20[5]
			{
				GClass14.smethod_42("/img/Big0.png"),
				GClass14.smethod_42("/img/Big1.png"),
				GClass14.smethod_42("/img/Big2.png"),
				GClass14.smethod_42("/img/Big3.png"),
				GClass14.smethod_42("/img/Big4.png")
			};
	}

	public static void smethod_1()
	{
		gclass20_0 = null;
		GClass77.smethod_26();
	}

	public static void smethod_2()
	{
		gclass20_1 = GClass20.smethod_9(new int[1], 1, 1, true);
	}

	public static void smethod_3()
	{
		gclass72_0 = null;
		gclass72_0 = new GClass72();
	}

	public void method_0(byte[] data)
	{
	}

	public void method_1()
	{
		int num = 0;
		try
		{
			GClass188 gClass = new GClass188(GClass141.smethod_1("NR_image"));
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
			GClass92.smethod_4("Loi readImage: " + ex.ToString() + "i= " + num);
		}
	}

	public static void smethod_4()
	{
	}

	public static void smethod_5(int id)
	{
		GClass191.smethod_8("is request =" + id + " zoom=" + GClass193.int_12);
		GClass20 gClass = GClass14.smethod_43("/SmallImage/Small" + id + ".png");
		if (gClass == null)
		{
			bool flag = false;
			sbyte[] array = GClass141.smethod_1(GClass193.int_12 + "Small" + id);
			if (array == null)
				flag = true;
			else
			{
				if (sbyte_0 != null && array.Length % 127 != sbyte_0[id])
					flag = true;
				if (!flag)
				{
					GClass20 gClass2 = GClass20.smethod_6(array, 0, array.Length);
					if (gClass2 == null)
						flag = true;
					else
						gclass26_0[id] = new GClass26(gClass2, id);
				}
			}
			if (flag)
			{
				gclass26_0[id] = new GClass26(gclass20_1, id);
				GClass2.smethod_0().method_105(id);
			}
		}
		else
			gclass26_0[id] = new GClass26(gClass, id);
	}

	public static void smethod_6(GClass193 g, int id, int x, int y, int transform, int anchor)
	{
		if (GClass66.smethod_0().bool_21)
			return;
		if (gclass20_0 != null)
		{
			if (int_0 == null)
			{
				if (GClass14.gclass160_0 != GClass167.smethod_8())
				{
					GClass26 gClass = gclass26_0[id];
					if (gClass != null)
						gClass.method_0(g, transform, x, y, anchor);
					else
						smethod_5(id);
				}
			}
			else if (id >= int_0.Length || int_0[id][1] >= 256 || int_0[id][3] >= 256 || int_0[id][2] >= 256 || int_0[id][4] >= 256)
			{
				GClass26 gClass2 = gclass26_0[id];
				if (gClass2 == null)
					smethod_5(id);
				else
					gClass2.method_0(g, transform, x, y, anchor);
			}
			else if (gclass20_0[int_0[id][0]] != null)
			{
				g.method_23(gclass20_0[int_0[id][0]], int_0[id][1], int_0[id][2], int_0[id][3], int_0[id][4], transform, x, y, anchor);
			}
		}
		else
		{
			GClass26 gClass3 = gclass26_0[id];
			if (gClass3 == null)
				smethod_5(id);
			else
				g.method_46(gClass3, 0, 0, GClass193.smethod_0(gClass3.gclass20_0), GClass193.smethod_1(gClass3.gclass20_0), transform, x, y, anchor);
		}
	}

	public static void smethod_7(GClass193 g, int id, int f, int x, int y, int w, int h, int transform, int anchor)
	{
		if (gclass20_0 != null)
		{
			if (int_0 == null)
			{
				if (GClass14.gclass160_0 != GClass167.smethod_8())
				{
					GClass26 gClass = gclass26_0[id];
					if (gClass == null)
						smethod_5(id);
					else
						gClass.method_1(g, transform, f, x, y, w, h, anchor);
				}
			}
			else if (id >= int_0.Length || int_0[id] == null || int_0[id][1] >= 256 || int_0[id][3] >= 256 || int_0[id][2] >= 256 || int_0[id][4] >= 256)
			{
				GClass26 gClass2 = gclass26_0[id];
				if (gClass2 != null)
					gClass2.method_1(g, transform, f, x, y, w, h, anchor);
				else
					smethod_5(id);
			}
			else if (int_0[id][0] == 4 || gclass20_0[int_0[id][0]] == null)
			{
				GClass26 gClass3 = gclass26_0[id];
				if (gClass3 != null)
					gClass3.method_1(g, transform, f, x, y, w, h, anchor);
				else
					smethod_5(id);
			}
			else
			{
				g.method_23(gclass20_0[int_0[id][0]], 0, f * w, w, h, transform, x, y, anchor);
			}
		}
		else
		{
			GClass26 gClass4 = gclass26_0[id];
			if (gClass4 != null)
				g.method_23(gClass4.gclass20_0, 0, f * w, w, h, transform, x, y, anchor);
			else
				smethod_5(id);
		}
	}

	public static void smethod_8()
	{
		int num = 0;
		if (GClass14.int_8 % 1000 != 0)
			return;
		for (int i = 0; i < gclass26_0.Length; i++)
		{
			if (gclass26_0[i] != null)
			{
				num++;
				gclass26_0[i].method_3();
				int_1++;
			}
		}
		if (num > 200 && GClass14.bool_1)
			gclass26_0 = new GClass26[short_0];
	}
}
