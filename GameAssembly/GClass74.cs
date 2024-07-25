using System;

public class GClass74
{
	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	public int int_18;

	private bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public GClass74()
	{
		int_6 = 28;
		if (GClass14.int_10 < 300)
		{
			bool_1 = true;
			bool_2 = false;
			bool_3 = false;
		}
		if (GClass14.int_10 >= 300 && GClass14.int_10 <= 380)
		{
			bool_1 = false;
			bool_2 = true;
			bool_3 = false;
		}
		if (GClass14.int_10 > 380)
		{
			bool_1 = false;
			bool_2 = false;
			bool_3 = true;
		}
		if (!bool_3)
		{
			int_15 = 0;
			int_17 = GClass14.int_12;
			int_16 = GClass14.int_13 >> 1;
			int_18 = GClass14.int_11 - 80;
			return;
		}
		int_15 = 0;
		int_17 = GClass14.int_12 / 4 * 3 - 20;
		int_16 = GClass14.int_13 >> 1;
		int_18 = GClass14.int_11;
		if (GClass77.int_0 == 2)
		{
			int_15 = 0;
			int_16 = (GClass14.int_11 >> 1) + 40;
			int_17 = GClass14.int_12 / 4 * 3 - 40;
			int_18 = GClass14.int_11;
		}
	}

	public void method_0()
	{
		try
		{
			if (GClass167.int_80 == 0)
				return;
			if (GClass14.bool_14 && !GClass14.bool_16)
			{
				int_9 = GClass14.int_2;
				int_10 = GClass14.int_3;
				if (int_9 < int_15 || int_9 > int_17 || int_10 < int_16 || int_10 > int_18)
					return;
				if (!bool_0)
				{
					int_0 = (int_2 = int_9);
					int_1 = (int_3 = int_10);
				}
				bool_0 = true;
				int_11 = GClass14.int_0 - int_0;
				int_12 = GClass14.int_1 - int_1;
				int_13 = GClass13.smethod_3(int_11, 2) + GClass13.smethod_3(int_12, 2);
				int_8 = GClass191.smethod_26(int_13);
				if (GClass13.smethod_0(int_11) <= 4 && GClass13.smethod_0(int_12) <= 4)
					return;
				int_14 = GClass191.smethod_5(int_11, int_12);
				if (!GClass14.smethod_24(int_0 - int_6, int_1 - int_6, 2 * int_6, 2 * int_6))
				{
					if (int_8 != 0)
					{
						int_3 = int_12 * int_6 / int_8;
						int_2 = int_11 * int_6 / int_8;
						int_2 += int_0;
						int_3 += int_1;
						if (!GClass191.smethod_29(int_0 - int_6, int_1 - int_6, 2 * int_6, 2 * int_6, int_2, int_3))
						{
							int_2 = int_4;
							int_3 = int_5;
						}
						else
						{
							int_4 = int_2;
							int_5 = int_3;
						}
					}
					else
					{
						int_2 = int_4;
						int_3 = int_5;
					}
				}
				else
				{
					int_2 = GClass14.int_0;
					int_3 = GClass14.int_1;
				}
				method_2();
				if (!method_1(2))
					method_2();
				else if ((int_14 <= 360 && int_14 >= 340) || (int_14 >= 0 && int_14 <= 20))
				{
					GClass14.bool_13[Main.isPC ? 24 : 6] = true;
					GClass14.bool_11[(!Main.isPC) ? 6 : 24] = true;
				}
				else if (int_14 > 40 && int_14 < 70)
				{
					GClass14.bool_13[(!Main.isPC) ? 6 : 24] = true;
					GClass14.bool_11[Main.isPC ? 24 : 6] = true;
				}
				else if (int_14 >= 70 && int_14 <= 110)
				{
					GClass14.bool_13[Main.isPC ? 22 : 8] = true;
					GClass14.bool_11[Main.isPC ? 22 : 8] = true;
				}
				else if (int_14 <= 110 || int_14 >= 120)
				{
					if (int_14 >= 120 && int_14 <= 200)
					{
						GClass14.bool_13[Main.isPC ? 23 : 4] = true;
						GClass14.bool_11[(!Main.isPC) ? 4 : 23] = true;
					}
					else if (int_14 <= 200 || int_14 >= 250)
					{
						if (int_14 >= 250 && int_14 <= 290)
						{
							GClass14.bool_13[Main.isPC ? 21 : 2] = true;
							GClass14.bool_11[Main.isPC ? 21 : 2] = true;
						}
						else if (int_14 > 290 && int_14 < 340)
						{
							GClass14.bool_13[Main.isPC ? 21 : 2] = true;
							GClass14.bool_11[Main.isPC ? 21 : 2] = true;
							GClass14.bool_13[(!Main.isPC) ? 6 : 24] = true;
							GClass14.bool_11[(!Main.isPC) ? 6 : 24] = true;
						}
					}
					else
					{
						GClass14.bool_13[(!Main.isPC) ? 2 : 21] = true;
						GClass14.bool_11[Main.isPC ? 21 : 2] = true;
						GClass14.bool_13[Main.isPC ? 23 : 4] = true;
						GClass14.bool_11[Main.isPC ? 23 : 4] = true;
					}
				}
				else
				{
					GClass14.bool_13[(!Main.isPC) ? 4 : 23] = true;
					GClass14.bool_11[Main.isPC ? 23 : 4] = true;
				}
			}
			else
			{
				int num = 45;
				int_0 = 45;
				int_2 = 45;
				if (bool_3)
					int_3 = (int_1 = GClass14.int_11 - 45);
				else
					int_3 = (int_1 = GClass14.int_11 - 90);
				bool_0 = false;
				method_2();
			}
		}
		catch (Exception)
		{
		}
	}

	private bool method_1(int int_18)
	{
		if (GClass167.int_80 != 0)
		{
			if (GClass124.smethod_1().int_11 == 3)
				return true;
			try
			{
				int num = 2;
				while (num > 0)
				{
					int i = GClass14.gclass198_0[num].int_0 - GClass14.gclass198_0[num - 1].int_0;
					int i2 = GClass14.gclass198_0[num].int_1 - GClass14.gclass198_0[num - 1].int_1;
					if (GClass191.smethod_28(i) <= int_18 || GClass191.smethod_28(i2) <= int_18)
					{
						num--;
						continue;
					}
					return false;
				}
			}
			catch (Exception)
			{
			}
			return true;
		}
		return false;
	}

	private void method_2()
	{
		GClass14.smethod_27();
	}

	public void method_3(GClass193 g)
	{
		if (GClass167.int_80 != 0)
		{
			g.method_31(GClass167.gclass20_26, int_0, int_1, GClass193.int_0 | GClass193.int_1);
			g.method_31(GClass167.gclass20_27, int_2, int_3, GClass193.int_0 | GClass193.int_1);
		}
	}

	public bool method_4()
	{
		if (GClass167.int_80 == 0)
			return false;
		return bool_0;
	}

	public bool method_5()
	{
		try
		{
			if (GClass167.int_80 != 0)
			{
				if ((GClass14.int_0 < int_15 || GClass14.int_0 > int_17 || GClass14.int_1 < int_16 || GClass14.int_1 > int_18) && GClass14.int_0 < GClass14.int_10 - 50)
					return false;
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
