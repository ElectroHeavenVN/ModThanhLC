using System;

public class GClass34
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
		if (GClass124.smethod_1().gclass70_0 != null && GClass124.smethod_1().gclass70_0.short_1 == tastId && GClass124.smethod_1().gclass70_0.int_0 == index)
			return true;
		return false;
	}

	public static bool smethod_1()
	{
		if (!smethod_0(0, 3) || GClass14.gclass113_0.int_29 != 0 || (GClass14.gclass113_0.int_8 >= 0 && GClass14.gclass113_0.int_8 <= 30))
		{
			if (!smethod_0(2, 0) || !GClass14.gclass113_0.bool_0 || GClass14.gclass113_0.int_29 == 0)
				return true;
			return false;
		}
		return false;
	}

	public static void smethod_2()
	{
		if (GClass14.gclass113_0.bool_0)
			bool_5 = false;
		if (GClass167.smethod_17() != null)
		{
			int_0 = GClass167.smethod_17().int_4;
			int_1 = GClass167.smethod_17().int_5;
			int_6 = 0;
			bool_6 = true;
			int_2 = (GClass14.bool_5 ? 1 : 0);
		}
	}

	public static void smethod_3(int index)
	{
		if (!GClass14.gclass113_0.bool_0 && GClass139.gclass122_0.method_2() - 1 >= index)
		{
			GClass139 gClass = (GClass139)GClass139.gclass122_0.method_3(index);
			int_0 = gClass.int_2 + gClass.int_0 / 2;
			int_1 = gClass.int_3 + 30;
			if (!gClass.bool_2 && gClass.bool_1)
				bool_5 = true;
			else
				bool_5 = false;
			int_2 = 0;
			bool_6 = true;
			int_6 = 0;
			if (!GClass14.bool_5)
				bool_5 = false;
		}
	}

	public static void smethod_4()
	{
		int_2 = 1;
		if (GClass14.gclass113_0.bool_0)
			bool_5 = false;
		bool flag = false;
		for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
		{
			if (((GClass6)GClass167.gclass122_9.method_3(i)).bool_1)
			{
				flag = true;
				break;
			}
		}
		for (int j = 0; j < GClass167.gclass122_9.method_2(); j++)
		{
			GClass6 gClass = (GClass6)GClass167.gclass122_9.method_3(j);
			if (!gClass.bool_1)
			{
				if (!flag)
				{
					if (gClass.int_12 != 0)
					{
						gClass.bool_1 = true;
						break;
					}
					gClass.bool_1 = false;
				}
				continue;
			}
			int_0 = gClass.int_8;
			int_1 = gClass.int_9 + 5;
			bool_6 = true;
			if (gClass.int_12 == 0)
				gClass.bool_1 = false;
			break;
		}
	}

	public static bool smethod_5()
	{
		if (GClass14.gclass113_0.bool_0)
			bool_5 = false;
		int num = 0;
		GClass190 gClass;
		while (true)
		{
			if (num < GClass167.gclass122_6.method_2())
			{
				gClass = (GClass190)GClass167.gclass122_6.method_3(num);
				if (gClass.int_8 == GClass124.smethod_1().int_13 && gClass.gclass203_0.short_0 == 73)
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

	public static void smethod_6(GClass193 g)
	{
		try
		{
			if (!bool_8 || (int_0 > GClass167.int_22 && int_0 < GClass167.int_22 + GClass167.int_6 && int_1 > GClass167.int_23 && int_1 < GClass167.int_23 + GClass167.int_7) || GClass14.int_8 % 10 < 5 || GClass88.gclass88_0 != null || GClass88.gclass88_1 != null || GClass14.gclass113_0.bool_0 || !bool_6)
				return;
			int num = int_0 - GClass124.smethod_1().int_4;
			int num2 = int_1 - GClass124.smethod_1().int_5;
			int x = 0;
			int y = 0;
			int arg = 0;
			if (num > 0 && num2 >= 0)
			{
				if (GClass191.smethod_28(num) < GClass191.smethod_28(num2))
				{
					x = GClass167.int_6 / 2;
					y = GClass167.int_7 - 10;
					arg = 5;
				}
				else
				{
					x = GClass167.int_6 - 10;
					y = GClass167.int_7 / 2 + 30;
					if (GClass14.bool_5)
						y = GClass167.int_7 / 2 + 10;
					arg = 0;
				}
			}
			else if (num >= 0 && num2 < 0)
			{
				if (GClass191.smethod_28(num) < GClass191.smethod_28(num2))
				{
					x = GClass167.int_6 / 2;
					y = 10;
					arg = 6;
				}
				else
				{
					x = GClass167.int_6 - 10;
					y = GClass167.int_7 / 2 + 30;
					if (GClass14.bool_5)
						y = GClass167.int_7 / 2 + 10;
					arg = 0;
				}
			}
			if (num >= 0 || num2 < 0)
			{
				if (num <= 0 && num2 < 0)
				{
					if (GClass191.smethod_28(num) < GClass191.smethod_28(num2))
					{
						x = GClass167.int_6 / 2;
						y = 10;
						arg = 6;
					}
					else
					{
						x = 10;
						y = GClass167.int_7 / 2 + 30;
						if (GClass14.bool_5)
							y = GClass167.int_7 / 2 + 10;
						arg = 3;
					}
				}
			}
			else if (GClass191.smethod_28(num) < GClass191.smethod_28(num2))
			{
				x = GClass167.int_6 / 2;
				y = GClass167.int_7 - 10;
				arg = 5;
			}
			else
			{
				x = 10;
				y = GClass167.int_7 / 2 + 30;
				if (GClass14.bool_5)
					y = GClass167.int_7 / 2 + 10;
				arg = 3;
			}
			GClass167.smethod_18(g);
			g.method_23(GClass167.gclass20_45, 0, 0, 13, 16, arg, x, y, GClass73.int_6);
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_7(GClass193 g)
	{
		if (GClass88.gclass88_1 == null && !GClass124.smethod_1().bool_3 && !GClass124.smethod_1().bool_2 && GClass14.gclass116_0.int_12 == 0 && bool_5 && GClass88.gclass1_0 == null && !GClass124.bool_33 && GClass14.gclass160_0 == GClass167.smethod_8() && (!GClass14.gclass113_0.bool_0 || GClass14.gclass113_0.int_15 == 0))
		{
			if (bool_6)
				g.method_1(-GClass167.int_22, -GClass167.int_23);
			if (int_6 == 0)
				g.method_31(GClass113.gclass20_0, int_0 - 15, int_1, 0);
			if (int_6 == 1)
				g.method_23(GClass113.gclass20_0, 0, 0, 14, 16, 2, int_0 + 15, int_1, GClass73.int_2);
			if (bool_7)
				g.method_31(GClass190.gclass20_0, int_0, int_1, 3);
		}
	}

	public static void smethod_8()
	{
		if (GClass124.smethod_1().gclass70_0 == null || GClass14.gclass160_0 != GClass167.gclass167_0)
		{
			bool_5 = false;
			bool_8 = false;
			return;
		}
		int short_ = GClass124.smethod_1().gclass70_0.short_1;
		int num = GClass124.smethod_1().gclass70_0.int_0;
		bool_6 = false;
		int_6 = 0;
		int_2 = 0;
		bool_5 = true;
		bool_8 = true;
		if (GClass14.gclass116_0.bool_0 && short_ > 0)
			bool_5 = false;
		switch (short_)
		{
		case 0:
			if (GClass88.gclass88_0 == null && GClass124.smethod_1().int_11 != 14)
			{
				if (num == 0 && GClass137.gclass122_0.method_2() != 0)
				{
					int_0 = ((GClass15)GClass137.gclass122_0.method_3(0)).short_0 - 100;
					int_1 = ((GClass15)GClass137.gclass122_0.method_3(0)).short_1 + 40;
					bool_6 = true;
				}
				if (num == 1)
					smethod_3(0);
				if (num == 2)
					smethod_2();
				if (num == 3)
				{
					if (!GClass14.gclass113_0.bool_0)
						smethod_2();
					else if (GClass14.gclass113_0.int_29 != 0)
					{
						if (GClass14.gclass113_0.int_29 == 1)
						{
							int_0 = GClass14.gclass113_0.int_30 + 10;
							int_1 = 65;
						}
					}
					else if (GClass14.gclass113_0.gclass88_0 != null)
					{
						if (GClass14.gclass116_0.int_12 != 0)
						{
							int_0 = GClass14.gclass113_0.int_58 + 25;
							int_1 = GClass14.gclass113_0.int_59 + 60;
						}
					}
					else
					{
						int_0 = GClass14.gclass113_0.int_58 + GClass14.gclass113_0.int_60 / 2;
						int_1 = GClass14.gclass113_0.int_59 + 20;
					}
				}
				if (num == 4)
				{
					if (!GClass14.gclass113_0.bool_0)
					{
						if (GClass14.gclass116_0.bool_0)
						{
							int_0 = GClass14.int_10 / 2;
							int_1 = GClass14.int_11 - 20;
						}
						else
							smethod_2();
					}
					else
					{
						int_0 = GClass14.gclass113_0.gclass118_1.int_1 + 5;
						int_1 = GClass14.gclass113_0.gclass118_1.int_2 + 5;
					}
				}
				if (num == 5)
					smethod_2();
			}
			else
			{
				int_0 = GClass14.int_10 / 2;
				int_1 = GClass14.int_11 - 15;
			}
			return;
		case 1:
			if (GClass88.gclass88_0 != null || GClass124.smethod_1().int_11 == 14)
			{
				int_0 = GClass14.int_10 / 2;
				int_1 = GClass14.int_11 - 15;
				return;
			}
			if (num == 0)
			{
				if (GClass137.smethod_5())
					smethod_3(0);
				else
					smethod_4();
			}
			if (num == 1)
			{
				if (GClass137.smethod_5())
					smethod_2();
				else
					smethod_3(1);
			}
			return;
		case 2:
			if (GClass88.gclass88_0 == null && GClass124.smethod_1().int_11 != 14)
			{
				if (num == 0)
				{
					if (!GClass137.smethod_5())
						bool_2 = true;
					if (GClass14.gclass113_0.bool_0)
					{
						if (!bool_2)
						{
							if (GClass14.gclass113_0.int_29 == 0)
							{
								int num2 = ((GClass14.int_11 > 300) ? 15 : 10);
								int_0 = GClass14.gclass113_0.int_58 + GClass14.gclass113_0.int_60 / 2;
								int_1 = GClass14.gclass113_0.int_59 + GClass14.gclass113_0.int_61 - num2;
							}
							else
							{
								int_0 = GClass14.gclass113_0.int_30 + 10;
								int_1 = 65;
							}
						}
						else if (bool_3)
						{
							bool_5 = false;
						}
						else
						{
							int_0 = GClass14.gclass113_0.gclass118_1.int_1 + 5;
							int_1 = GClass14.gclass113_0.gclass118_1.int_2 + 5;
						}
					}
					else if (bool_2)
					{
						if (GClass167.smethod_27() != GClass137.int_37)
							smethod_3(0);
						else if (!smethod_5())
						{
							smethod_4();
						}
						if (bool_2)
							bool_3 = true;
					}
					else
					{
						int_0 = GClass167.smethod_8().gclass118_12.int_1;
						int_1 = GClass167.smethod_8().gclass118_12.int_2 + 13;
						int_6 = 1;
					}
					if (GClass124.smethod_1().int_24 <= 0)
					{
						int_0 = GClass167.int_135 + 5;
						int_1 = GClass167.int_136 + 13;
						bool_6 = false;
					}
				}
				if (num == 1)
				{
					bool_5 = false;
					bool_8 = false;
				}
			}
			else
			{
				int_0 = GClass14.int_10 / 2;
				int_1 = GClass14.int_11 - 15;
			}
			return;
		case 3:
			if (GClass88.gclass88_0 == null && GClass124.smethod_1().int_11 != 14)
			{
				if (num == 0)
				{
					if (GClass14.gclass113_0.bool_0)
					{
						if (bool_4)
						{
							if (!bool_3)
							{
								int_0 = GClass14.gclass113_0.gclass118_1.int_1 + 5;
								int_1 = GClass14.gclass113_0.gclass118_1.int_2 + 5;
							}
							else
								bool_5 = false;
						}
						else
						{
							if (GClass14.int_11 <= 300)
								_ = 10;
							else
								_ = 15;
							int_0 = GClass14.gclass113_0.int_58 + 10 + 108 - 18;
							int_1 = 65;
						}
					}
					else if (!bool_4)
					{
						int_0 = GClass167.smethod_8().gclass118_12.int_1;
						int_1 = GClass167.smethod_8().gclass118_12.int_2 + 13;
						int_6 = 1;
					}
					else
					{
						if (GClass167.smethod_27() != GClass137.int_37)
							smethod_3(0);
						else if (!smethod_5())
						{
							smethod_4();
						}
						if (bool_2)
							bool_3 = true;
					}
					if (GClass124.smethod_1().int_24 <= 0)
					{
						int_0 = GClass167.int_135 + 5;
						int_1 = GClass167.int_136 + 13;
						bool_6 = false;
					}
				}
				else
				{
					bool_5 = false;
					bool_8 = false;
				}
			}
			else
			{
				int_0 = GClass14.int_10 / 2;
				int_1 = GClass14.int_11 - 15;
			}
			return;
		}
		if (GClass124.smethod_1().gclass70_0.short_1 == 9 && GClass124.smethod_1().gclass70_0.int_0 == 2)
		{
			for (int i = 0; i < GClass139.gclass122_0.method_2(); i++)
			{
				GClass139 gClass = (GClass139)GClass139.gclass122_0.method_3(i);
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

	public static void smethod_9()
	{
		smethod_8();
		int num = ((int_6 != 0) ? (-2) : 2);
		if (bool_1)
		{
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
				if (GClass14.bool_5)
					GClass167.smethod_19(mResources.press_twice, int_0, int_1 + 10, 0, 20, GClass104.int_10);
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
		else
		{
			bool_7 = false;
			int_3++;
			if (int_3 == 50)
			{
				int_3 = 0;
				bool_1 = true;
			}
		}
	}
}
