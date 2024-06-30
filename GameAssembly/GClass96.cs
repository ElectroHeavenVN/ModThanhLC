using System;
using ns1;

public class GClass96
{
	public static int[][] int_0;

	public static GClass96 gclass96_0;

	public static GClass2[] gclass2_0;

	public static GClass129[] gclass129_0;

	public static GClass63 gclass63_0 = new GClass63();

	public static GClass2 gclass2_1 = null;

	public static sbyte[] sbyte_0;

	public static int int_1;

	public static short short_0;

	public GClass96()
	{
		method_1();
	}

	public static void smethod_0()
	{
		if (gclass2_0 == null)
			gclass2_0 = new GClass2[5]
			{
				GClass39.smethod_42("/img/Big0.png"),
				GClass39.smethod_42("/img/Big1.png"),
				GClass39.smethod_42("/img/Big2.png"),
				GClass39.smethod_42("/img/Big3.png"),
				GClass39.smethod_42("/img/Big4.png")
			};
	}

	public static void smethod_1()
	{
		gclass2_0 = null;
		GClass138.smethod_26();
	}

	public static void smethod_2()
	{
		gclass2_1 = GClass2.smethod_9(new int[1], 1, 1, true);
	}

	public static void smethod_3()
	{
		gclass96_0 = null;
		gclass96_0 = new GClass96();
	}

	public void method_0(byte[] data)
	{
	}

	public void method_1()
	{
		int num = 0;
		try
		{
			GClass11 gClass = new GClass11(GClass120.smethod_1("NR_image"));
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
			GClass5.smethod_4("Loi readImage: " + ex.ToString() + "i= " + num);
		}
	}

	public static void smethod_4()
	{
	}

	public static void smethod_5(int id)
	{
		GClass56.smethod_8("is request =" + id + " zoom=" + GClass76.int_12);
		GClass2 gClass = GClass39.smethod_43("/SmallImage/Small" + id + ".png");
		if (gClass != null)
		{
			gclass129_0[id] = new GClass129(gClass, id);
			return;
		}
		bool flag = false;
		sbyte[] array = GClass120.smethod_1(GClass76.int_12 + "Small" + id);
		if (array != null)
		{
			if (sbyte_0 != null && array.Length % 127 != sbyte_0[id])
				flag = true;
			if (!flag)
			{
				GClass2 gClass2 = GClass2.smethod_6(array, 0, array.Length);
				if (gClass2 != null)
					gclass129_0[id] = new GClass129(gClass2, id);
				else
					flag = true;
			}
		}
		else
			flag = true;
		if (flag)
		{
			gclass129_0[id] = new GClass129(gclass2_1, id);
			GClass166.smethod_0().method_105(id);
		}
	}

	public static void smethod_6(GClass76 g, int id, int x, int y, int transform, int anchor)
	{
		if (GClass173.smethod_0().bool_18)
			return;
		if (GClass173.smethod_0().gclass2_4 == null)
			GClass173.smethod_0().gclass2_4 = GClass173.smethod_0().method_4("vegettoBlueHeadStand");
		if (GClass173.smethod_0().gclass2_3 == null)
			GClass173.smethod_0().gclass2_3 = GClass173.smethod_0().method_4("vegettoBlueHeadMove");
		if (GClass173.smethod_0().gclass2_5 == null)
			GClass173.smethod_0().gclass2_5 = GClass173.smethod_0().method_4("vegettoBlueAvatar");
		if (gclass2_0 == null)
		{
			GClass129 gClass = gclass129_0[id];
			if (gClass == null)
				smethod_5(id);
			else
				g.method_46(gClass, 0, 0, GClass76.smethod_0(gClass.gclass2_0), GClass76.smethod_1(gClass.gclass2_0), transform, x, y, anchor);
		}
		else if (int_0 != null)
		{
			if (id >= int_0.Length || int_0[id][1] >= 256 || int_0[id][3] >= 256 || int_0[id][2] >= 256 || int_0[id][4] >= 256)
			{
				GClass129 gClass2 = gclass129_0[id];
				if (gClass2 == null)
				{
					smethod_5(id);
					return;
				}
				if (gClass2.int_0 == 7994)
				{
					if (GClass173.smethod_0().gclass2_4 != null)
						gClass2.gclass2_0 = GClass173.smethod_0().gclass2_4;
				}
				else if (gClass2.int_0 == 7995)
				{
					if (GClass173.smethod_0().gclass2_3 != null)
						gClass2.gclass2_0 = GClass173.smethod_0().gclass2_3;
				}
				else if (gClass2.int_0 == 8025 && GClass173.smethod_0().gclass2_5 != null)
				{
					gClass2.gclass2_0 = GClass173.smethod_0().gclass2_5;
				}
				gClass2.method_0(g, transform, x, y, anchor);
			}
			else if (gclass2_0[int_0[id][0]] != null)
			{
				g.method_23(gclass2_0[int_0[id][0]], int_0[id][1], int_0[id][2], int_0[id][3], int_0[id][4], transform, x, y, anchor);
			}
		}
		else if (GClass39.gclass145_0 != GClass154.smethod_8())
		{
			GClass129 gClass3 = gclass129_0[id];
			if (gClass3 == null)
				smethod_5(id);
			else
				gClass3.method_0(g, transform, x, y, anchor);
		}
	}

	public static void smethod_7(GClass76 g, int id, int f, int x, int y, int w, int h, int transform, int anchor)
	{
		if (gclass2_0 == null)
		{
			GClass129 gClass = gclass129_0[id];
			if (gClass == null)
				smethod_5(id);
			else
				g.method_23(gClass.gclass2_0, 0, f * w, w, h, transform, x, y, anchor);
		}
		else if (int_0 != null)
		{
			if (id >= int_0.Length || int_0[id] == null || int_0[id][1] >= 256 || int_0[id][3] >= 256 || int_0[id][2] >= 256 || int_0[id][4] >= 256)
			{
				GClass129 gClass2 = gclass129_0[id];
				if (gClass2 == null)
					smethod_5(id);
				else
					gClass2.method_1(g, transform, f, x, y, w, h, anchor);
			}
			else if (int_0[id][0] != 4 && gclass2_0[int_0[id][0]] != null)
			{
				g.method_23(gclass2_0[int_0[id][0]], 0, f * w, w, h, transform, x, y, anchor);
			}
			else
			{
				GClass129 gClass3 = gclass129_0[id];
				if (gClass3 == null)
					smethod_5(id);
				else
					gClass3.method_1(g, transform, f, x, y, w, h, anchor);
			}
		}
		else if (GClass39.gclass145_0 != GClass154.smethod_8())
		{
			GClass129 gClass4 = gclass129_0[id];
			if (gClass4 == null)
				smethod_5(id);
			else
				gClass4.method_1(g, transform, f, x, y, w, h, anchor);
		}
	}

	public static void smethod_8()
	{
		int num = 0;
		if (GClass39.int_8 % 1000 != 0)
			return;
		for (int i = 0; i < gclass129_0.Length; i++)
		{
			if (gclass129_0[i] != null)
			{
				num++;
				gclass129_0[i].method_3();
				int_1++;
			}
		}
		if (num > 200 && GClass39.bool_1)
			gclass129_0 = new GClass129[short_0];
	}
}
