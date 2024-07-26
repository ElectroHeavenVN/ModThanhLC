using AssemblyCSharp.Functions;

public class GClass145
{
	public bool bool_0;

	public GClass88 gclass88_0;

	public bool bool_1 = false;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public static int[] int_5;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public static int int_9;

	public static int int_10;

	public static int int_11;

	private GClass87 gclass87_0 = new GClass87(mResources.SELECT, 0);

	private GClass87 gclass87_1 = new GClass87(mResources.CLOSE, 0, GClass73.int_10 - 71, GClass73.int_11 - GClass131.int_3 + 1);

	private GClass87 gclass87_2;

	public static GClass70 gclass70_0;

	public static GClass70 gclass70_1;

	private bool bool_2;

	public int int_12;

	public int int_13;

	private int int_14;

	private bool bool_3;

	private int int_15;

	private int int_16;

	private int[] int_17 = new int[3];

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private int int_18;

	private int int_19;

	private bool bool_7;

	private bool bool_8;

	private int int_20;

	private int int_21;

	private bool bool_9;

	public bool[] bool_10;

	public static void smethod_0()
	{
		gclass70_0 = ((!GClass167.smethod_0().bool_22) ? GClass73.smethod_43("/mainImage/myTexture2dbtMenu1.png") : GClass167.smethod_0().method_5("menu1"));
		gclass70_1 = ((!GClass167.smethod_0().bool_22) ? GClass73.smethod_43("/mainImage/myTexture2dbtMenu2.png") : GClass167.smethod_0().method_5("menu2"));
	}

	public void method_0(GClass88 menuItems, int pos)
	{
		method_2(menuItems, pos);
		bool_2 = true;
	}

	public void method_1(GClass88 menuItems, int x, int y)
	{
		method_2(menuItems, 0);
		int_1 = x;
		int_2 = y;
		while (int_2 + int_4 > GClass73.int_11)
		{
			int_2 -= 2;
		}
	}

	public void method_2(GClass88 menuItems, int pos)
	{
		if (bool_0)
			return;
		bool_9 = false;
		bool_7 = false;
		bool_8 = false;
		int_12 = 0;
		if (menuItems.method_2() == 1)
		{
			int_0 = 0;
			GClass87 gClass = (GClass87)menuItems.method_3(0);
			if (gClass != null && gClass.string_0.Equals(mResources.saying))
			{
				gClass.method_1();
				bool_0 = false;
				GClass130.smethod_1();
				return;
			}
		}
		GClass109.smethod_1().method_39();
		bool_10 = new bool[menuItems.method_2()];
		for (int i = 0; i < bool_10.Length; i++)
		{
			bool_10[i] = false;
		}
		bool_2 = false;
		GClass96.gclass96_0 = null;
		GClass93.gclass88_1.method_9();
		GClass93.gclass88_3.method_9();
		GClass130.smethod_5();
		if (menuItems.method_2() != 0)
		{
			gclass88_0 = menuItems;
			int_3 = 60;
			int_4 = 60;
			for (int j = 0; j < menuItems.method_2(); j++)
			{
				GClass87 gClass2 = (GClass87)menuItems.method_3(j);
				gClass2.bool_1 = false;
				GClass4.gclass4_15.method_17(gClass2.string_0);
				gClass2.string_1 = GClass4.gclass4_15.method_15(gClass2.string_0, int_3 - 10);
			}
			int_5 = new int[menuItems.method_2()];
			int_1 = (GClass73.int_10 - menuItems.method_2() * int_3) / 2;
			if (int_1 < 1)
				int_1 = 1;
			int_2 = GClass73.int_11 - int_4 - (GClass192.int_5 + 1) - 1;
			if (GClass73.bool_5)
				int_2 -= 3;
			int_2 += 27;
			for (int k = 0; k < int_5.Length; k++)
			{
				int_5[k] = GClass73.int_11;
			}
			bool_0 = true;
			int_0 = 0;
			int_10 = gclass88_0.method_2() * int_3 - GClass73.int_10;
			if (int_10 < 0)
				int_10 = 0;
			int_6 = 0;
			int_7 = 0;
			int_11 = 50;
			int_13 = menuItems.method_2() * int_3 - 1;
			if (int_13 > GClass73.int_10 - 2)
				int_13 = GClass73.int_10 - 2;
			if (GClass73.bool_5 && !Main.isPC)
				int_0 = -1;
		}
	}

	public bool method_3()
	{
		if ((bool_9 || int_5[int_5.Length - 1] <= int_2) && (!bool_9 || int_5[int_5.Length - 1] >= GClass73.int_11))
			return false;
		return true;
	}

	public void method_4()
	{
		if ((GClass144.smethod_8().bool_66 && GClass144.smethod_8().bool_62) || !bool_0 || method_3())
			return;
		bool flag = false;
		if (GClass73.bool_11[Main.isPC ? 21 : 2] || GClass73.bool_11[Main.isPC ? 23 : 4])
		{
			flag = true;
			int_0--;
			if (int_0 < 0)
				int_0 = gclass88_0.method_2() - 1;
		}
		else if (GClass73.bool_11[Main.isPC ? 22 : 8] || GClass73.bool_11[Main.isPC ? 24 : 6])
		{
			flag = true;
			int_0++;
			if (int_0 > gclass88_0.method_2() - 1)
				int_0 = 0;
		}
		else if (GClass73.bool_11[Main.isPC ? 25 : 5])
		{
			if (gclass87_2 != null)
			{
				if (gclass87_2.int_0 > 0)
				{
					if (gclass87_2.ginterface6_0 != GClass144.smethod_8())
						method_10(gclass87_2.int_0, gclass87_2.object_0);
					else
						GClass144.smethod_8().method_117(gclass87_2.int_0, gclass87_2.object_0);
				}
			}
			else
				int_18 = 2;
		}
		else if (!GClass73.bool_11[12] || GClass144.smethod_8().method_77())
		{
			if (!GClass144.smethod_8().method_77() && !bool_2 && (GClass73.bool_11[13] || GClass131.smethod_1(gclass87_1)))
			{
				if (method_3())
					return;
				if (!bool_8)
					bool_8 = true;
				bool_9 = true;
				GClass109.smethod_1().method_34();
			}
		}
		else
		{
			if (method_3())
				return;
			if (gclass87_0.int_0 > 0)
				method_10(gclass87_0.int_0, gclass87_0.object_0);
			else
				int_18 = 2;
			GClass109.smethod_1().method_34();
		}
		if (flag)
		{
			int_6 = int_0 * int_3 + int_3 - GClass73.int_10 / 2;
			if (int_6 > int_10)
				int_6 = int_10;
			if (int_6 < 0)
				int_6 = 0;
			if (int_0 == gclass88_0.method_2() - 1 || int_0 == 0)
				int_7 = int_6;
		}
		bool flag2 = true;
		if (GClass73.gclass76_0.gclass96_0 != null && GClass73.gclass76_0.gclass96_0.bool_3)
		{
			if (!GClass73.smethod_24(GClass73.gclass76_0.gclass96_0.int_3, 0, GClass73.gclass76_0.gclass96_0.int_0 + 2, GClass73.gclass76_0.gclass96_0.int_5))
				flag2 = true;
			else
			{
				flag2 = false;
				GClass73.gclass76_0.gclass96_0.method_2();
			}
		}
		if (!bool_2 && GClass73.bool_16 && !GClass73.smethod_48(int_1, int_2, int_13, int_4) && !bool_4 && !GClass144.smethod_8().method_77() && flag2)
		{
			if (!method_3())
			{
				int_16 = 0;
				int_15 = 0;
				bool_4 = false;
				GClass73.smethod_49();
				GClass50.smethod_8("menu select= " + int_0);
				bool_9 = true;
				bool_8 = true;
				GClass109.smethod_1().method_34();
			}
			return;
		}
		if (GClass73.bool_14)
		{
			if (bool_4 || !GClass73.smethod_48(int_1, int_2, int_13, int_4))
			{
				if (bool_4)
				{
					int_15++;
					if (int_15 > 5 && int_16 == GClass73.int_0 && !bool_5)
					{
						int_16 = -1000;
						int_0 = (int_6 + GClass73.int_0 - int_1) / int_3;
					}
					int num = GClass73.int_0 - int_17[0];
					if (num != 0 && int_0 != -1)
						int_0 = -1;
					for (int num2 = int_17.Length - 1; num2 > 0; num2--)
					{
						int_17[num2] = int_17[num2 - 1];
					}
					int_17[0] = GClass73.int_0;
					int_6 -= num;
					if (int_6 < 0)
						int_6 = 0;
					if (int_6 > int_10)
						int_6 = int_10;
					if (int_7 < 0 || int_7 > int_10)
						num /= 2;
					int_7 -= num;
					if (int_7 < -(GClass73.int_11 / 3))
						bool_6 = true;
					else
						bool_6 = false;
				}
			}
			else
			{
				for (int i = 0; i < int_17.Length; i++)
				{
					int_17[0] = GClass73.int_0;
				}
				int_16 = GClass73.int_0;
				bool_4 = true;
				bool_5 = int_19 != 0;
				int_19 = 0;
			}
		}
		if (GClass73.bool_16 && bool_4)
		{
			int i2 = GClass73.int_0 - int_17[0];
			GClass73.bool_16 = false;
			if (GClass50.smethod_28(i2) >= 20 || GClass50.smethod_28(GClass73.int_0 - int_16) >= 20 || bool_5)
			{
				if (int_0 != -1 && int_15 > 5)
				{
					int_15 = 0;
					int_18 = 1;
				}
				else if (int_0 == -1 && !bool_5)
				{
					if (int_7 < 0)
						int_6 = 0;
					else if (int_7 > int_10)
					{
						int_6 = int_10;
					}
					else
					{
						int num3 = GClass73.int_0 - int_17[0] + (int_17[0] - int_17[1]) + (int_17[1] - int_17[2]);
						int_19 = -((num3 > 10) ? 10 : ((num3 < -10) ? (-10) : 0)) * 100;
					}
				}
			}
			else
			{
				int_19 = 0;
				int_6 = int_7;
				int_16 = -1000;
				int_0 = (int_6 + GClass73.int_0 - int_1) / int_3;
				int_15 = 0;
				int_18 = 10;
			}
			bool_4 = false;
			int_15 = 0;
			GClass73.bool_16 = false;
		}
		GClass73.smethod_26();
		GClass73.smethod_27();
	}

	public void method_5()
	{
		if (int_19 != 0 && !bool_4)
		{
			int_6 += int_19 / 100;
			if (int_6 >= 0)
			{
				if (int_6 <= int_10)
					int_7 = int_6;
				else
					int_6 = int_10;
			}
			else
				int_6 = 0;
			int_19 = int_19 * 9 / 10;
			if (int_19 < 100 && int_19 > -100)
				int_19 = 0;
		}
		if (int_7 != int_6 && !bool_4)
		{
			int_20 = int_6 - int_7 << 2;
			int_21 += int_20;
			int_7 += int_21 >> 4;
			int_21 &= 15;
		}
	}

	public void method_6(GClass122 g)
	{
		if (GClass144.smethod_8().bool_66 && GClass144.smethod_8().bool_62)
			return;
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass73.int_10, GClass73.int_11);
		g.method_1(-int_7, 0);
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			if (i == int_0)
				g.method_31(gclass70_1, int_1 + i * int_3 + 1, int_5[i], 0);
			else
				g.method_31(gclass70_0, int_1 + i * int_3 + 1, int_5[i], 0);
			GClass87 gClass = (GClass87)gclass88_0.method_3(i);
			string[] array = gClass.string_1;
			if (array == null)
				array = new string[1] { ((GClass87)gclass88_0.method_3(i)).string_0 };
			int num = int_5[i] + (int_4 - array.Length * 14) / 2 + 1;
			for (int j = 0; j < array.Length; j++)
			{
				if (i != int_0)
				{
					if (!gClass.bool_0)
						GClass4.gclass4_6.method_6(g, array[j], int_1 + i * int_3 + int_3 / 2, num + j * 14, 2);
					else
						GClass4.gclass4_1.method_6(g, array[j], int_1 + i * int_3 + int_3 / 2, num + j * 14, 2);
				}
				else
					GClass4.gclass4_7.method_6(g, array[j], int_1 + i * int_3 + int_3 / 2, num + j * 14, 2);
				GClass154.smethod_0().method_2(GClass4.gclass4_20, g, (i + 1).ToString(), int_1 + i * int_3 + 50, int_5[i], 0, GClass4.gclass4_6, "border");
			}
		}
		g.method_1(-g.method_3(), -g.method_4());
	}

	public void method_7()
	{
		GClass50.smethod_8("CLOSE MENU");
		bool_9 = false;
		bool_0 = false;
		bool_1 = false;
		GClass130.smethod_5();
		if (bool_8)
		{
			GClass73.gclass76_0.gclass96_0 = null;
			GClass78.gclass96_0 = null;
			if (GClass73.gclass76_1 != null && GClass73.gclass76_1.gclass96_0 != null)
				GClass73.gclass76_1.gclass96_0 = null;
		}
		else
		{
			if (!bool_7)
				return;
			GClass73.gclass76_0.gclass96_0 = null;
			if (GClass73.gclass76_1 != null && GClass73.gclass76_1.gclass96_0 != null)
				GClass73.gclass76_1.gclass96_0 = null;
			if (int_0 >= 0)
			{
				GClass87 gClass = (GClass87)gclass88_0.method_3(int_0);
				if (gClass != null)
				{
					GClass109.smethod_1().method_34();
					gClass.method_1();
				}
			}
		}
	}

	public void method_8()
	{
		GClass130.smethod_5();
		if (int_0 >= 0)
			((GClass87)gclass88_0.method_3(int_0))?.method_1();
	}

	public void method_9()
	{
		method_5();
		if (bool_9)
		{
			int_12++;
			for (int i = 0; i < int_5.Length; i++)
			{
				if (int_5[i] < GClass73.int_11)
				{
					int num = (GClass73.int_11 - int_5[i] >> 1) + 2;
					if (num < 1)
						num = 1;
					if (int_12 > i)
						int_5[i] += num;
				}
			}
			if (int_5[int_5.Length - 1] >= GClass73.int_11)
			{
				int_12 = 0;
				method_7();
			}
		}
		else
		{
			int_12++;
			for (int j = 0; j < int_5.Length; j++)
			{
				if (int_5[j] > int_2)
				{
					int num2 = int_5[j] - int_2 >> 1;
					if (num2 < 1)
						num2 = 1;
					if (int_12 > j)
						int_5[j] -= num2;
				}
			}
			if (int_5[int_5.Length - 1] <= int_2)
				int_12 = 0;
		}
		if (int_11 != 0)
		{
			int_11 >>= 1;
			if (int_11 < 0)
				int_11 = 0;
		}
		if (method_3() || int_18 <= 0)
			return;
		int_18--;
		if (int_18 == 0)
		{
			if (int_0 < 0 || bool_10[int_0])
			{
				method_8();
				return;
			}
			bool_9 = true;
			bool_7 = true;
			GClass73.gclass76_0.gclass96_0 = null;
		}
	}

	public void method_10(int idAction, object p)
	{
	}
}
