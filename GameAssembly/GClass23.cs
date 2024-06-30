using System;

public class GClass23
{
	public static int int_0;

	public static int int_1;

	public static int int_2;

	public static int int_3;

	public static int int_4;

	public static int int_5;

	public static bool bool_0;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	public static bool bool_5;

	public static bool bool_6;

	public static int int_6;

	public static bool bool_7;

	public static bool bool_8;

	private int int_7 = 2;

	public static bool smethod_0(int tastId, int index)
	{
		if (GClass58.smethod_1().gclass36_0 != null && GClass58.smethod_1().gclass36_0.short_1 == tastId && GClass58.smethod_1().gclass36_0.int_0 == index)
			return true;
		return false;
	}

	public static bool smethod_1()
	{
		if (smethod_0(0, 3) && GClass39.gclass45_0.int_29 == 0 && (GClass39.gclass45_0.int_8 < 0 || GClass39.gclass45_0.int_8 > 30))
			return false;
		if (smethod_0(2, 0) && GClass39.gclass45_0.bool_0 && GClass39.gclass45_0.int_29 != 0)
			return false;
		return true;
	}

	public static void smethod_2()
	{
		if (GClass39.gclass45_0.bool_0)
			bool_5 = false;
		if (GClass154.smethod_17() != null)
		{
			int_0 = GClass154.smethod_17().int_4;
			int_1 = GClass154.smethod_17().int_5;
			int_6 = 0;
			bool_6 = true;
			int_2 = (GClass39.bool_5 ? 1 : 0);
		}
	}

	public static void smethod_3(int index)
	{
		if (!GClass39.gclass45_0.bool_0 && GClass24.gclass63_0.method_2() - 1 >= index)
		{
			GClass24 gClass = (GClass24)GClass24.gclass63_0.method_3(index);
			int_0 = gClass.int_2 + gClass.int_0 / 2;
			int_1 = gClass.int_3 + 30;
			if (gClass.bool_2 || !gClass.bool_1)
				bool_5 = false;
			else
				bool_5 = true;
			int_2 = 0;
			bool_6 = true;
			int_6 = 0;
			if (!GClass39.bool_5)
				bool_5 = false;
		}
	}

	public static void smethod_4()
	{
		int_2 = 1;
		if (GClass39.gclass45_0.bool_0)
			bool_5 = false;
		bool flag = false;
		for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
		{
			if (((GClass85)GClass154.gclass63_9.method_3(i)).bool_1)
			{
				flag = true;
				break;
			}
		}
		int num = 0;
		GClass85 gClass;
		while (true)
		{
			if (num >= GClass154.gclass63_9.method_2())
				return;
			gClass = (GClass85)GClass154.gclass63_9.method_3(num);
			if (gClass.bool_1)
				break;
			if (!flag)
			{
				if (gClass.int_12 != 0)
				{
					gClass.bool_1 = true;
					return;
				}
				gClass.bool_1 = false;
			}
			num++;
		}
		int_0 = gClass.int_8;
		int_1 = gClass.int_9 + 5;
		bool_6 = true;
		if (gClass.int_12 == 0)
			gClass.bool_1 = false;
	}

	public static bool smethod_5()
	{
		if (GClass39.gclass45_0.bool_0)
			bool_5 = false;
		int num = 0;
		GClass134 gClass;
		while (true)
		{
			if (num < GClass154.gclass63_6.method_2())
			{
				gClass = (GClass134)GClass154.gclass63_6.method_3(num);
				if (gClass.int_8 == GClass58.smethod_1().int_13 && gClass.gclass118_0.short_0 == 73)
					break;
				num++;
				continue;
			}
			return false;
		}
		int_2 = 1;
		int_0 = gClass.int_1;
		int_1 = gClass.int_2 + 5;
		bool_6 = true;
		return true;
	}

	public static void smethod_6(GClass76 g)
	{
		try
		{
			if (!bool_8 || (int_0 > GClass154.int_22 && int_0 < GClass154.int_22 + GClass154.int_6 && int_1 > GClass154.int_23 && int_1 < GClass154.int_23 + GClass154.int_7) || GClass39.int_8 % 10 < 5 || GClass70.gclass70_0 != null || GClass70.gclass70_1 != null || GClass39.gclass45_0.bool_0 || !bool_6)
				return;
			int num = int_0 - GClass58.smethod_1().int_4;
			int num2 = int_1 - GClass58.smethod_1().int_5;
			int x = 0;
			int y = 0;
			int arg = 0;
			if (num > 0 && num2 >= 0)
			{
				if (GClass56.smethod_28(num) >= GClass56.smethod_28(num2))
				{
					x = GClass154.int_6 - 10;
					y = GClass154.int_7 / 2 + 30;
					if (GClass39.bool_5)
						y = GClass154.int_7 / 2 + 10;
					arg = 0;
				}
				else
				{
					x = GClass154.int_6 / 2;
					y = GClass154.int_7 - 10;
					arg = 5;
				}
			}
			else if (num >= 0 && num2 < 0)
			{
				if (GClass56.smethod_28(num) >= GClass56.smethod_28(num2))
				{
					x = GClass154.int_6 - 10;
					y = GClass154.int_7 / 2 + 30;
					if (GClass39.bool_5)
						y = GClass154.int_7 / 2 + 10;
					arg = 0;
				}
				else
				{
					x = GClass154.int_6 / 2;
					y = 10;
					arg = 6;
				}
			}
			if (num < 0 && num2 >= 0)
			{
				if (GClass56.smethod_28(num) >= GClass56.smethod_28(num2))
				{
					x = 10;
					y = GClass154.int_7 / 2 + 30;
					if (GClass39.bool_5)
						y = GClass154.int_7 / 2 + 10;
					arg = 3;
				}
				else
				{
					x = GClass154.int_6 / 2;
					y = GClass154.int_7 - 10;
					arg = 5;
				}
			}
			else if (num <= 0 && num2 < 0)
			{
				if (GClass56.smethod_28(num) >= GClass56.smethod_28(num2))
				{
					x = 10;
					y = GClass154.int_7 / 2 + 30;
					if (GClass39.bool_5)
						y = GClass154.int_7 / 2 + 10;
					arg = 3;
				}
				else
				{
					x = GClass154.int_6 / 2;
					y = 10;
					arg = 6;
				}
			}
			GClass154.smethod_18(g);
			g.method_23(GClass154.gclass2_45, 0, 0, 13, 16, arg, x, y, GClass169.int_6);
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_7(GClass76 g)
	{
		if (GClass70.gclass70_1 == null && !GClass58.smethod_1().bool_3 && !GClass58.smethod_1().bool_2 && GClass39.gclass0_0.int_12 == 0 && bool_5 && GClass70.gclass105_0 == null && !GClass58.bool_33 && GClass39.gclass145_0 == GClass154.smethod_8() && (!GClass39.gclass45_0.bool_0 || GClass39.gclass45_0.int_15 == 0))
		{
			if (bool_6)
				g.method_1(-GClass154.int_22, -GClass154.int_23);
			if (int_6 == 0)
				g.method_31(GClass45.gclass2_0, int_0 - 15, int_1, 0);
			if (int_6 == 1)
				g.method_23(GClass45.gclass2_0, 0, 0, 14, 16, 2, int_0 + 15, int_1, GClass169.int_2);
			if (bool_7)
				g.method_31(GClass134.gclass2_0, int_0, int_1, 3);
		}
	}

	public static void smethod_8()
	{
		if (GClass58.smethod_1().gclass36_0 != null && GClass39.gclass145_0 == GClass154.gclass154_0)
		{
			int short_ = GClass58.smethod_1().gclass36_0.short_1;
			int num = GClass58.smethod_1().gclass36_0.int_0;
			bool_6 = false;
			int_6 = 0;
			int_2 = 0;
			bool_5 = true;
			bool_8 = true;
			if (GClass39.gclass0_0.bool_0 && short_ > 0)
				bool_5 = false;
			switch (short_)
			{
			case 0:
				if (GClass70.gclass70_0 != null || GClass58.smethod_1().int_11 == 14)
				{
					int_0 = GClass39.int_10 / 2;
					int_1 = GClass39.int_11 - 15;
					return;
				}
				if (num == 0 && GClass1.gclass63_0.method_2() != 0)
				{
					int_0 = ((GClass48)GClass1.gclass63_0.method_3(0)).short_0 - 100;
					int_1 = ((GClass48)GClass1.gclass63_0.method_3(0)).short_1 + 40;
					bool_6 = true;
				}
				if (num == 1)
					smethod_3(0);
				if (num == 2)
					smethod_2();
				if (num == 3)
				{
					if (!GClass39.gclass45_0.bool_0)
						smethod_2();
					else if (GClass39.gclass45_0.int_29 == 0)
					{
						if (GClass39.gclass45_0.gclass70_0 == null)
						{
							int_0 = GClass39.gclass45_0.int_57 + GClass39.gclass45_0.int_59 / 2;
							int_1 = GClass39.gclass45_0.int_58 + 20;
						}
						else if (GClass39.gclass0_0.int_12 != 0)
						{
							int_0 = GClass39.gclass45_0.int_57 + 25;
							int_1 = GClass39.gclass45_0.int_58 + 60;
						}
					}
					else if (GClass39.gclass45_0.int_29 == 1)
					{
						int_0 = GClass39.gclass45_0.int_30 + 10;
						int_1 = 65;
					}
				}
				if (num == 4)
				{
					if (GClass39.gclass45_0.bool_0)
					{
						int_0 = GClass39.gclass45_0.gclass14_1.int_1 + 5;
						int_1 = GClass39.gclass45_0.gclass14_1.int_2 + 5;
					}
					else if (GClass39.gclass0_0.bool_0)
					{
						int_0 = GClass39.int_10 / 2;
						int_1 = GClass39.int_11 - 20;
					}
					else
					{
						smethod_2();
					}
				}
				if (num == 5)
					smethod_2();
				return;
			case 1:
				if (GClass70.gclass70_0 != null || GClass58.smethod_1().int_11 == 14)
				{
					int_0 = GClass39.int_10 / 2;
					int_1 = GClass39.int_11 - 15;
					return;
				}
				if (num == 0)
				{
					if (GClass1.smethod_5())
						smethod_3(0);
					else
						smethod_4();
				}
				if (num == 1)
				{
					if (!GClass1.smethod_5())
						smethod_3(1);
					else
						smethod_2();
				}
				return;
			case 2:
				if (GClass70.gclass70_0 != null || GClass58.smethod_1().int_11 == 14)
				{
					int_0 = GClass39.int_10 / 2;
					int_1 = GClass39.int_11 - 15;
					return;
				}
				if (num == 0)
				{
					if (!GClass1.smethod_5())
						bool_2 = true;
					if (!GClass39.gclass45_0.bool_0)
					{
						if (!bool_2)
						{
							int_0 = GClass154.smethod_8().gclass14_12.int_1;
							int_1 = GClass154.smethod_8().gclass14_12.int_2 + 13;
							int_6 = 1;
						}
						else
						{
							if (GClass154.smethod_27() == GClass1.int_37)
							{
								if (!smethod_5())
									smethod_4();
							}
							else
								smethod_3(0);
							if (bool_2)
								bool_3 = true;
						}
					}
					else if (!bool_2)
					{
						if (GClass39.gclass45_0.int_29 == 0)
						{
							int num2 = ((GClass39.int_11 <= 300) ? 10 : 15);
							int_0 = GClass39.gclass45_0.int_57 + GClass39.gclass45_0.int_59 / 2;
							int_1 = GClass39.gclass45_0.int_58 + GClass39.gclass45_0.int_60 - num2;
						}
						else
						{
							int_0 = GClass39.gclass45_0.int_30 + 10;
							int_1 = 65;
						}
					}
					else if (!bool_3)
					{
						int_0 = GClass39.gclass45_0.gclass14_1.int_1 + 5;
						int_1 = GClass39.gclass45_0.gclass14_1.int_2 + 5;
					}
					else
					{
						bool_5 = false;
					}
					if (GClass58.smethod_1().int_24 <= 0)
					{
						int_0 = GClass154.int_132 + 5;
						int_1 = GClass154.int_133 + 13;
						bool_6 = false;
					}
				}
				if (num == 1)
				{
					bool_5 = false;
					bool_8 = false;
				}
				return;
			case 3:
				if (GClass70.gclass70_0 != null || GClass58.smethod_1().int_11 == 14)
				{
					int_0 = GClass39.int_10 / 2;
					int_1 = GClass39.int_11 - 15;
				}
				else if (num == 0)
				{
					if (!GClass39.gclass45_0.bool_0)
					{
						if (!bool_4)
						{
							int_0 = GClass154.smethod_8().gclass14_12.int_1;
							int_1 = GClass154.smethod_8().gclass14_12.int_2 + 13;
							int_6 = 1;
						}
						else
						{
							if (GClass154.smethod_27() == GClass1.int_37)
							{
								if (!smethod_5())
									smethod_4();
							}
							else
								smethod_3(0);
							if (bool_2)
								bool_3 = true;
						}
					}
					else if (!bool_4)
					{
						if (GClass39.int_11 <= 300)
							_ = 10;
						else
							_ = 15;
						int_0 = GClass39.gclass45_0.int_57 + 10 + 108 - 18;
						int_1 = 65;
					}
					else if (!bool_3)
					{
						int_0 = GClass39.gclass45_0.gclass14_1.int_1 + 5;
						int_1 = GClass39.gclass45_0.gclass14_1.int_2 + 5;
					}
					else
					{
						bool_5 = false;
					}
					if (GClass58.smethod_1().int_24 <= 0)
					{
						int_0 = GClass154.int_132 + 5;
						int_1 = GClass154.int_133 + 13;
						bool_6 = false;
					}
				}
				else
				{
					bool_5 = false;
					bool_8 = false;
				}
				return;
			}
			if (GClass58.smethod_1().gclass36_0.short_1 == 9 && GClass58.smethod_1().gclass36_0.int_0 == 2)
			{
				for (int i = 0; i < GClass24.gclass63_0.method_2(); i++)
				{
					GClass24 gClass = (GClass24)GClass24.gclass63_0.method_3(i);
					if (gClass.int_3 <= 24)
					{
						int_0 = gClass.int_2 + gClass.int_0 / 2;
						int_1 = gClass.int_3 + 30;
						bool_6 = true;
						bool_5 = false;
						bool_8 = true;
						return;
					}
				}
			}
			bool_5 = false;
			bool_8 = false;
		}
		else
		{
			bool_5 = false;
			bool_8 = false;
		}
	}

	public static void smethod_9()
	{
		smethod_8();
		int num = ((int_6 != 0) ? (-2) : 2);
		if (!bool_1)
		{
			bool_7 = false;
			int_3++;
			if (int_3 == 50)
			{
				int_3 = 0;
				bool_1 = true;
			}
			return;
		}
		int_3++;
		if (int_2 == 0)
		{
			if (int_3 == 2)
			{
				int_0 += 2 * num;
				int_1 -= 4;
				bool_7 = true;
			}
			if (int_3 == 4)
			{
				int_0 -= 2 * num;
				int_1 += 4;
				bool_1 = false;
				bool_7 = false;
				int_3 = 0;
			}
			if (int_3 > 4)
				bool_1 = false;
		}
		if (int_2 != 1)
			return;
		if (int_3 == 2)
		{
			if (GClass39.bool_5)
				GClass154.smethod_19(mResources.press_twice, int_0, int_1 + 10, 0, 20, GClass49.int_10);
			bool_7 = true;
			int_0 += 2 * num;
			int_1 -= 4;
		}
		if (int_3 == 4)
		{
			bool_7 = false;
			int_0 -= num;
			int_1 += 2;
		}
		if (int_3 == 6)
		{
			bool_7 = true;
			int_0 += num;
			int_1 -= 2;
		}
		if (int_3 == 8)
		{
			bool_7 = false;
			int_0 -= num;
			int_1 += 2;
		}
		if (int_3 == 10)
		{
			int_0 -= num;
			int_1 += 2;
			bool_1 = false;
			int_3 = 0;
		}
	}
}
