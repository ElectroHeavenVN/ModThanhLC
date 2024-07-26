using System;

public class GClass48
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

	public GClass48()
	{
		int_6 = 28;
		if (GClass73.int_10 < 300)
		{
			bool_1 = true;
			bool_2 = false;
			bool_3 = false;
		}
		if (GClass73.int_10 >= 300 && GClass73.int_10 <= 380)
		{
			bool_1 = false;
			bool_2 = true;
			bool_3 = false;
		}
		if (GClass73.int_10 > 380)
		{
			bool_1 = false;
			bool_2 = false;
			bool_3 = true;
		}
		if (bool_3)
		{
			int_15 = 0;
			int_17 = GClass73.int_12 / 4 * 3 - 20;
			int_16 = GClass73.int_13 >> 1;
			int_18 = GClass73.int_11;
			if (GClass203.int_0 == 2)
			{
				int_15 = 0;
				int_16 = (GClass73.int_11 >> 1) + 40;
				int_17 = GClass73.int_12 / 4 * 3 - 40;
				int_18 = GClass73.int_11;
			}
		}
		else
		{
			int_15 = 0;
			int_17 = GClass73.int_12;
			int_16 = GClass73.int_13 >> 1;
			int_18 = GClass73.int_11 - 80;
		}
	}

	public void method_0()
	{
		try
		{
			if (GClass144.int_80 == 0)
				return;
			if (GClass73.bool_14 && !GClass73.bool_16)
			{
				int_9 = GClass73.int_2;
				int_10 = GClass73.int_3;
				if (int_9 < int_15 || int_9 > int_17 || int_10 < int_16 || int_10 > int_18)
					return;
				if (!bool_0)
				{
					int_0 = (int_2 = int_9);
					int_1 = (int_3 = int_10);
				}
				bool_0 = true;
				int_11 = GClass73.int_0 - int_0;
				int_12 = GClass73.int_1 - int_1;
				int_13 = GClass118.smethod_3(int_11, 2) + GClass118.smethod_3(int_12, 2);
				int_8 = GClass50.smethod_26(int_13);
				if (GClass118.smethod_0(int_11) <= 4 && GClass118.smethod_0(int_12) <= 4)
					return;
				int_14 = GClass50.smethod_5(int_11, int_12);
				if (!GClass73.smethod_24(int_0 - int_6, int_1 - int_6, 2 * int_6, 2 * int_6))
				{
					if (int_8 != 0)
					{
						int_3 = int_12 * int_6 / int_8;
						int_2 = int_11 * int_6 / int_8;
						int_2 += int_0;
						int_3 += int_1;
						if (!GClass50.smethod_29(int_0 - int_6, int_1 - int_6, 2 * int_6, 2 * int_6, int_2, int_3))
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
					int_2 = GClass73.int_0;
					int_3 = GClass73.int_1;
				}
				method_2();
				if (method_1(2))
				{
					if ((int_14 > 360 || int_14 < 340) && (int_14 < 0 || int_14 > 20))
					{
						if (int_14 <= 40 || int_14 >= 70)
						{
							if (int_14 < 70 || int_14 > 110)
							{
								if (int_14 <= 110 || int_14 >= 120)
								{
									if (int_14 >= 120 && int_14 <= 200)
									{
										GClass73.bool_13[Main.isPC ? 23 : 4] = true;
										GClass73.bool_11[(!Main.isPC) ? 4 : 23] = true;
									}
									else if (int_14 <= 200 || int_14 >= 250)
									{
										if (int_14 < 250 || int_14 > 290)
										{
											if (int_14 > 290 && int_14 < 340)
											{
												GClass73.bool_13[Main.isPC ? 21 : 2] = true;
												GClass73.bool_11[(!Main.isPC) ? 2 : 21] = true;
												GClass73.bool_13[(!Main.isPC) ? 6 : 24] = true;
												GClass73.bool_11[Main.isPC ? 24 : 6] = true;
											}
										}
										else
										{
											GClass73.bool_13[(!Main.isPC) ? 2 : 21] = true;
											GClass73.bool_11[(!Main.isPC) ? 2 : 21] = true;
										}
									}
									else
									{
										GClass73.bool_13[(!Main.isPC) ? 2 : 21] = true;
										GClass73.bool_11[Main.isPC ? 21 : 2] = true;
										GClass73.bool_13[Main.isPC ? 23 : 4] = true;
										GClass73.bool_11[(!Main.isPC) ? 4 : 23] = true;
									}
								}
								else
								{
									GClass73.bool_13[(!Main.isPC) ? 4 : 23] = true;
									GClass73.bool_11[Main.isPC ? 23 : 4] = true;
								}
							}
							else
							{
								GClass73.bool_13[Main.isPC ? 22 : 8] = true;
								GClass73.bool_11[Main.isPC ? 22 : 8] = true;
							}
						}
						else
						{
							GClass73.bool_13[Main.isPC ? 24 : 6] = true;
							GClass73.bool_11[(!Main.isPC) ? 6 : 24] = true;
						}
					}
					else
					{
						GClass73.bool_13[Main.isPC ? 24 : 6] = true;
						GClass73.bool_11[(!Main.isPC) ? 6 : 24] = true;
					}
				}
				else
					method_2();
			}
			else
			{
				int num = 45;
				int_0 = 45;
				int_2 = 45;
				if (bool_3)
					int_3 = (int_1 = GClass73.int_11 - 45);
				else
					int_3 = (int_1 = GClass73.int_11 - 90);
				bool_0 = false;
				method_2();
			}
		}
		catch (Exception)
		{
		}
	}

	private bool method_1(int int_19)
	{
		if (GClass144.int_80 == 0)
			return false;
		if (GClass78.smethod_1().int_11 != 3)
		{
			try
			{
				int num = 2;
				while (num > 0)
				{
					int i = GClass73.gclass125_0[num].int_0 - GClass73.gclass125_0[num - 1].int_0;
					int i2 = GClass73.gclass125_0[num].int_1 - GClass73.gclass125_0[num - 1].int_1;
					if (GClass50.smethod_28(i) <= int_19 || GClass50.smethod_28(i2) <= int_19)
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
		return true;
	}

	private void method_2()
	{
		GClass73.smethod_27();
	}

	public void method_3(GClass122 g)
	{
		if (GClass144.int_80 != 0)
		{
			g.method_31(GClass144.gclass70_26, int_0, int_1, GClass122.int_0 | GClass122.int_1);
			g.method_31(GClass144.gclass70_27, int_2, int_3, GClass122.int_0 | GClass122.int_1);
		}
	}

	public bool method_4()
	{
		if (GClass144.int_80 == 0)
			return false;
		return bool_0;
	}

	public bool method_5()
	{
		try
		{
			if (GClass144.int_80 != 0)
			{
				if ((GClass73.int_0 >= int_15 && GClass73.int_0 <= int_17 && GClass73.int_1 >= int_16 && GClass73.int_1 <= int_18) || GClass73.int_0 >= GClass73.int_10 - 50)
					return true;
				return false;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
