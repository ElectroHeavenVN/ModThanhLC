using ns1;

public class GClass0
{
	public bool bool_0;

	public GClass63 gclass63_0;

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

	private GClass14 gclass14_0 = new GClass14(mResources.SELECT, 0);

	private GClass14 gclass14_1 = new GClass14(mResources.CLOSE, 0, GClass39.int_10 - 71, GClass39.int_11 - GClass145.int_3 + 1);

	private GClass14 gclass14_2;

	public static GClass2 gclass2_0;

	public static GClass2 gclass2_1;

	private bool bool_1;

	public int int_12;

	public int int_13;

	private int int_14;

	private bool bool_2;

	private int int_15;

	private int int_16;

	private int[] int_17 = new int[3];

	private bool bool_3;

	private bool TmpFdnieC;

	private bool bool_4;

	private int int_18;

	private int int_19;

	private bool bool_5;

	private bool bool_6;

	private int int_20;

	private int int_21;

	private bool bool_7;

	public bool[] bool_8;

	public static void smethod_0()
	{
		gclass2_0 = (GClass173.smethod_0().bool_19 ? GClass173.smethod_0().method_4("menu1") : GClass39.smethod_43("/mainImage/myTexture2dbtMenu1.png"));
		gclass2_1 = (GClass173.smethod_0().bool_19 ? GClass173.smethod_0().method_4("menu2") : GClass39.smethod_43("/mainImage/myTexture2dbtMenu2.png"));
	}

	public void method_0(GClass63 menuItems, int pos)
	{
		method_2(menuItems, pos);
		bool_1 = true;
	}

	public void method_1(GClass63 menuItems, int x, int y)
	{
		method_2(menuItems, 0);
		int_1 = x;
		int_2 = y;
		while (int_2 + int_4 > GClass39.int_11)
		{
			int_2 -= 2;
		}
	}

	public void method_2(GClass63 menuItems, int pos)
	{
		if (bool_0)
			return;
		bool_7 = false;
		bool_5 = false;
		bool_6 = false;
		int_12 = 0;
		if (menuItems.method_2() == 1)
		{
			int_0 = 0;
			GClass14 gClass = (GClass14)menuItems.method_3(0);
			if (gClass != null && gClass.string_0.Equals(mResources.saying))
			{
				gClass.method_1();
				bool_0 = false;
				GClass57.smethod_1();
				return;
			}
		}
		GClass29.smethod_1().method_39();
		bool_8 = new bool[menuItems.method_2()];
		for (int i = 0; i < bool_8.Length; i++)
		{
			bool_8[i] = false;
		}
		bool_1 = false;
		GClass70.gclass70_0 = null;
		GClass68.gclass63_1.method_9();
		GClass68.gclass63_3.method_9();
		GClass57.smethod_5();
		if (menuItems.method_2() != 0)
		{
			gclass63_0 = menuItems;
			int_3 = 60;
			int_4 = 60;
			for (int j = 0; j < menuItems.method_2(); j++)
			{
				GClass14 gClass2 = (GClass14)menuItems.method_3(j);
				gClass2.bool_1 = false;
				GClass49.gclass49_15.method_17(gClass2.string_0);
				gClass2.string_1 = GClass49.gclass49_15.method_15(gClass2.string_0, int_3 - 10);
			}
			int_5 = new int[menuItems.method_2()];
			int_1 = (GClass39.int_10 - menuItems.method_2() * int_3) / 2;
			if (int_1 < 1)
				int_1 = 1;
			int_2 = GClass39.int_11 - int_4 - (GClass37.int_5 + 1) - 1;
			if (GClass39.bool_5)
				int_2 -= 3;
			int_2 += 27;
			for (int k = 0; k < int_5.Length; k++)
			{
				int_5[k] = GClass39.int_11;
			}
			bool_0 = true;
			int_0 = 0;
			int_10 = gclass63_0.method_2() * int_3 - GClass39.int_10;
			if (int_10 < 0)
				int_10 = 0;
			int_6 = 0;
			int_7 = 0;
			int_11 = 50;
			int_13 = menuItems.method_2() * int_3 - 1;
			if (int_13 > GClass39.int_10 - 2)
				int_13 = GClass39.int_10 - 2;
			if (GClass39.bool_5 && !Main.isPC)
				int_0 = -1;
		}
	}

	public bool method_3()
	{
		if ((!bool_7 && int_5[int_5.Length - 1] > int_2) || (bool_7 && int_5[int_5.Length - 1] < GClass39.int_11))
			return true;
		return false;
	}

	public void method_4()
	{
		if ((GClass154.smethod_8().bool_65 && GClass154.smethod_8().bool_61) || !bool_0 || method_3())
			return;
		bool flag = false;
		if (GClass39.bool_11[(!Main.isPC) ? 2 : 21] || GClass39.bool_11[(!Main.isPC) ? 4 : 23])
		{
			flag = true;
			int_0--;
			if (int_0 < 0)
				int_0 = gclass63_0.method_2() - 1;
		}
		else if (GClass39.bool_11[(!Main.isPC) ? 8 : 22] || GClass39.bool_11[(!Main.isPC) ? 6 : 24])
		{
			flag = true;
			int_0++;
			if (int_0 > gclass63_0.method_2() - 1)
				int_0 = 0;
		}
		else if (GClass39.bool_11[(!Main.isPC) ? 5 : 25])
		{
			if (gclass14_2 != null)
			{
				if (gclass14_2.int_0 > 0)
				{
					if (gclass14_2.ginterface0_0 == GClass154.smethod_8())
						GClass154.smethod_8().method_115(gclass14_2.int_0, gclass14_2.object_0);
					else
						method_10(gclass14_2.int_0, gclass14_2.object_0);
				}
			}
			else
				int_18 = 2;
		}
		else if (GClass39.bool_11[12] && !GClass154.smethod_8().method_77())
		{
			if (method_3())
				return;
			if (gclass14_0.int_0 > 0)
				method_10(gclass14_0.int_0, gclass14_0.object_0);
			else
				int_18 = 2;
			GClass29.smethod_1().method_34();
		}
		else if (!GClass154.smethod_8().method_77() && !bool_1 && (GClass39.bool_11[13] || GClass145.smethod_1(gclass14_1)))
		{
			if (method_3())
				return;
			if (!bool_6)
				bool_6 = true;
			bool_7 = true;
			GClass29.smethod_1().method_34();
		}
		if (flag)
		{
			int_6 = int_0 * int_3 + int_3 - GClass39.int_10 / 2;
			if (int_6 > int_10)
				int_6 = int_10;
			if (int_6 < 0)
				int_6 = 0;
			if (int_0 == gclass63_0.method_2() - 1 || int_0 == 0)
				int_7 = int_6;
		}
		bool flag2 = true;
		if (GClass39.gclass45_0.gclass70_0 != null && GClass39.gclass45_0.gclass70_0.bool_3)
		{
			if (!GClass39.smethod_24(GClass39.gclass45_0.gclass70_0.int_3, 0, GClass39.gclass45_0.gclass70_0.int_0 + 2, GClass39.gclass45_0.gclass70_0.int_5))
				flag2 = true;
			else
			{
				flag2 = false;
				GClass39.gclass45_0.gclass70_0.method_2();
			}
		}
		if (!bool_1 && GClass39.bool_16 && !GClass39.smethod_48(int_1, int_2, int_13, int_4) && !bool_3 && !GClass154.smethod_8().method_77() && flag2)
		{
			if (!method_3())
			{
				int_16 = 0;
				int_15 = 0;
				bool_3 = false;
				GClass39.smethod_49();
				GClass56.smethod_8("menu select= " + int_0);
				bool_7 = true;
				bool_6 = true;
				GClass29.smethod_1().method_34();
			}
			return;
		}
		if (GClass39.bool_14)
		{
			if (!bool_3 && GClass39.smethod_48(int_1, int_2, int_13, int_4))
			{
				for (int i = 0; i < int_17.Length; i++)
				{
					int_17[0] = GClass39.int_0;
				}
				int_16 = GClass39.int_0;
				bool_3 = true;
				TmpFdnieC = int_19 != 0;
				int_19 = 0;
			}
			else if (bool_3)
			{
				int_15++;
				if (int_15 > 5 && int_16 == GClass39.int_0 && !TmpFdnieC)
				{
					int_16 = -1000;
					int_0 = (int_6 + GClass39.int_0 - int_1) / int_3;
				}
				int num = GClass39.int_0 - int_17[0];
				if (num != 0 && int_0 != -1)
					int_0 = -1;
				for (int num2 = int_17.Length - 1; num2 > 0; num2--)
				{
					int_17[num2] = int_17[num2 - 1];
				}
				int_17[0] = GClass39.int_0;
				int_6 -= num;
				if (int_6 < 0)
					int_6 = 0;
				if (int_6 > int_10)
					int_6 = int_10;
				if (int_7 < 0 || int_7 > int_10)
					num /= 2;
				int_7 -= num;
				if (int_7 < -(GClass39.int_11 / 3))
					bool_4 = true;
				else
					bool_4 = false;
			}
		}
		if (GClass39.bool_16 && bool_3)
		{
			int i2 = GClass39.int_0 - int_17[0];
			GClass39.bool_16 = false;
			if (GClass56.smethod_28(i2) < 20 && GClass56.smethod_28(GClass39.int_0 - int_16) < 20 && !TmpFdnieC)
			{
				int_19 = 0;
				int_6 = int_7;
				int_16 = -1000;
				int_0 = (int_6 + GClass39.int_0 - int_1) / int_3;
				int_15 = 0;
				int_18 = 10;
			}
			else if (int_0 != -1 && int_15 > 5)
			{
				int_15 = 0;
				int_18 = 1;
			}
			else if (int_0 == -1 && !TmpFdnieC)
			{
				if (int_7 < 0)
					int_6 = 0;
				else if (int_7 > int_10)
				{
					int_6 = int_10;
				}
				else
				{
					int num3 = GClass39.int_0 - int_17[0] + (int_17[0] - int_17[1]) + (int_17[1] - int_17[2]);
					int_19 = -((num3 > 10) ? 10 : ((num3 < -10) ? (-10) : 0)) * 100;
				}
			}
			bool_3 = false;
			int_15 = 0;
			GClass39.bool_16 = false;
		}
		GClass39.smethod_26();
		GClass39.smethod_27();
	}

	public void method_5()
	{
		if (int_19 != 0 && !bool_3)
		{
			int_6 += int_19 / 100;
			if (int_6 < 0)
				int_6 = 0;
			else if (int_6 > int_10)
			{
				int_6 = int_10;
			}
			else
			{
				int_7 = int_6;
			}
			int_19 = int_19 * 9 / 10;
			if (int_19 < 100 && int_19 > -100)
				int_19 = 0;
		}
		if (int_7 != int_6 && !bool_3)
		{
			int_20 = int_6 - int_7 << 2;
			int_21 += int_20;
			int_7 += int_21 >> 4;
			int_21 &= 15;
		}
	}

	public void method_6(GClass76 g)
	{
		if (GClass154.smethod_8().bool_65 && GClass154.smethod_8().bool_61)
			return;
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		g.method_1(-int_7, 0);
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			if (i == int_0)
				g.method_31(gclass2_1, int_1 + i * int_3 + 1, int_5[i], 0);
			else
				g.method_31(gclass2_0, int_1 + i * int_3 + 1, int_5[i], 0);
			GClass14 gClass = (GClass14)gclass63_0.method_3(i);
			string[] array = gClass.string_1;
			if (array == null)
				array = new string[1] { ((GClass14)gclass63_0.method_3(i)).string_0 };
			int num = int_5[i] + (int_4 - array.Length * 14) / 2 + 1;
			for (int j = 0; j < array.Length; j++)
			{
				if (i == int_0)
					GClass49.gclass49_7.method_6(g, array[j], int_1 + i * int_3 + int_3 / 2, num + j * 14, 2);
				else if (gClass.bool_0)
				{
					GClass49.gclass49_1.method_6(g, array[j], int_1 + i * int_3 + int_3 / 2, num + j * 14, 2);
				}
				else
				{
					GClass49.gclass49_6.method_6(g, array[j], int_1 + i * int_3 + int_3 / 2, num + j * 14, 2);
				}
				GClass193.smethod_0().method_3(GClass49.gclass49_20, g, (i + 1).ToString(), int_1 + i * int_3 + 50, int_5[i], 0, GClass49.gclass49_6, "border");
			}
		}
		g.method_1(-g.method_3(), -g.method_4());
	}

	public void method_7()
	{
		GClass56.smethod_8("CLOSE MENU");
		bool_7 = false;
		bool_0 = false;
		GClass57.smethod_5();
		if (bool_6)
		{
			GClass39.gclass45_0.gclass70_0 = null;
			GClass58.gclass70_0 = null;
			if (GClass39.gclass45_1 != null && GClass39.gclass45_1.gclass70_0 != null)
				GClass39.gclass45_1.gclass70_0 = null;
		}
		else
		{
			if (!bool_5)
				return;
			GClass39.gclass45_0.gclass70_0 = null;
			if (GClass39.gclass45_1 != null && GClass39.gclass45_1.gclass70_0 != null)
				GClass39.gclass45_1.gclass70_0 = null;
			if (int_0 >= 0)
			{
				GClass14 gClass = (GClass14)gclass63_0.method_3(int_0);
				if (gClass != null)
				{
					GClass29.smethod_1().method_34();
					gClass.method_1();
				}
			}
		}
	}

	public void method_8()
	{
		GClass57.smethod_5();
		if (int_0 >= 0)
			((GClass14)gclass63_0.method_3(int_0))?.method_1();
	}

	public void method_9()
	{
		method_5();
		if (!bool_7)
		{
			int_12++;
			for (int i = 0; i < int_5.Length; i++)
			{
				if (int_5[i] > int_2)
				{
					int num = int_5[i] - int_2 >> 1;
					if (num < 1)
						num = 1;
					if (int_12 > i)
						int_5[i] -= num;
				}
			}
			if (int_5[int_5.Length - 1] <= int_2)
				int_12 = 0;
		}
		else
		{
			int_12++;
			for (int j = 0; j < int_5.Length; j++)
			{
				if (int_5[j] < GClass39.int_11)
				{
					int num2 = (GClass39.int_11 - int_5[j] >> 1) + 2;
					if (num2 < 1)
						num2 = 1;
					if (int_12 > j)
						int_5[j] += num2;
				}
			}
			if (int_5[int_5.Length - 1] >= GClass39.int_11)
			{
				int_12 = 0;
				method_7();
			}
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
			if (int_0 >= 0 && !bool_8[int_0])
			{
				bool_7 = true;
				bool_5 = true;
				GClass39.gclass45_0.gclass70_0 = null;
			}
			else
				method_8();
		}
	}

	public void method_10(int idAction, object p)
	{
	}
}
