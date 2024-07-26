public class GClass179
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int int_12;

	public int int_13;

	public static GClass179 gclass179_0;

	private int int_14;

	private int int_15;

	private int[] int_16 = new int[3];

	public bool bool_0;

	public bool bool_1;

	private int int_17;

	public int int_18;

	public int int_19;

	public int int_20;

	public int int_21;

	public bool bool_2 = true;

	public void method_0()
	{
		int_0 = 0;
		int_1 = 0;
		int_2 = 0;
		int_3 = 0;
		int_4 = 0;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		int_12 = 0;
		int_13 = 0;
		int_10 = 0;
		int_11 = 0;
	}

	public GClass11 method_1()
	{
		if (!bool_2)
			return method_4();
		return method_3(false);
	}

	public GClass11 method_2(bool isGetSelectNow)
	{
		if (!bool_2)
			return method_4();
		return method_3(isGetSelectNow);
	}

	private GClass11 method_3(bool bool_3)
	{
		int num = int_8;
		int num2 = int_9;
		int w = int_10;
		int h = int_11;
		if (GClass73.bool_14)
		{
			if (!bool_0 && GClass73.smethod_48(num, num2, w, h))
			{
				for (int i = 0; i < int_16.Length; i++)
				{
					int_16[0] = GClass73.int_1;
				}
				int_15 = GClass73.int_1;
				bool_0 = true;
				if (!bool_3)
					int_18 = -1;
				bool_1 = int_17 != 0;
				int_17 = 0;
			}
			else if (bool_0)
			{
				int_14++;
				if (int_14 > 5 && int_15 == GClass73.int_1 && !bool_1)
				{
					int_15 = -1000;
					if (int_21 <= 1)
						int_18 = (int_1 + GClass73.int_1 - num2) / int_19;
					else
					{
						int num3 = (int_1 + GClass73.int_1 - num2) / int_19;
						int num4 = (int_0 + GClass73.int_0 - num) / int_19;
						int_18 = num3 * int_21 + num4;
					}
				}
				int num5 = GClass73.int_1 - int_16[0];
				if (bool_3)
					int_18 = (int_1 + GClass73.int_1 - num2) / int_19;
				else if (num5 != 0 && int_18 != -1)
				{
					int_18 = -1;
				}
				for (int num6 = int_16.Length - 1; num6 > 0; num6--)
				{
					int_16[num6] = int_16[num6 - 1];
				}
				int_16[0] = GClass73.int_1;
				int_1 -= num5;
				if (int_1 < 0)
					int_1 = 0;
				if (int_1 > int_13)
					int_1 = int_13;
				if (int_3 < 0 || int_3 > int_13)
					num5 /= 2;
				int_3 -= num5;
			}
		}
		bool flag = false;
		if (GClass73.bool_16 && bool_0)
		{
			int i2 = GClass73.int_1 - int_16[0];
			GClass73.bool_16 = false;
			if (GClass50.smethod_28(i2) < 20 && GClass50.smethod_28(GClass73.int_1 - int_15) < 20 && !bool_1)
			{
				int_17 = 0;
				int_1 = int_3;
				int_15 = -1000;
				if (int_21 > 1)
				{
					int num7 = (int_1 + GClass73.int_1 - num2) / int_19;
					int num8 = (int_0 + GClass73.int_0 - num) / int_19;
					int_18 = num7 * int_21 + num8;
				}
				else
					int_18 = (int_1 + GClass73.int_1 - num2) / int_19;
				int_14 = 0;
				flag = true;
			}
			else if (int_18 != -1 && int_14 > 5)
			{
				int_14 = 0;
				flag = true;
			}
			else if ((int_18 == -1 && !bool_1) || (bool_3 && int_18 != -1 && !bool_1))
			{
				if (int_3 >= 0)
				{
					if (int_3 <= int_13)
					{
						int num9 = GClass73.int_1 - int_16[0] + (int_16[0] - int_16[1]) + (int_16[1] - int_16[2]);
						int_17 = -((num9 > 10) ? 10 : ((num9 < -10) ? (-10) : 0)) * 100;
					}
					else
						int_1 = int_13;
				}
				else
					int_1 = 0;
			}
			bool_0 = false;
			int_14 = 0;
			GClass73.bool_16 = false;
		}
		GClass11 gClass = new GClass11();
		gClass.int_0 = int_18;
		gClass.bool_1 = flag;
		gClass.bool_0 = bool_0;
		return gClass;
	}

	private GClass11 method_4()
	{
		int num = int_8;
		int y = int_9;
		int w = int_10;
		int h = int_11;
		if (GClass73.bool_14)
		{
			if (bool_0 || !GClass73.smethod_48(num, y, w, h))
			{
				if (bool_0)
				{
					int_14++;
					if (int_14 > 5 && int_15 == GClass73.int_0 && !bool_1)
					{
						int_15 = -1000;
						int_18 = (int_0 + GClass73.int_0 - num) / int_19;
					}
					int num2 = GClass73.int_0 - int_16[0];
					if (num2 != 0 && int_18 != -1)
						int_18 = -1;
					for (int num3 = int_16.Length - 1; num3 > 0; num3--)
					{
						int_16[num3] = int_16[num3 - 1];
					}
					int_16[0] = GClass73.int_0;
					int_0 -= num2;
					if (int_0 < 0)
						int_0 = 0;
					if (int_0 > int_12)
						int_0 = int_12;
					if (int_2 < 0 || int_2 > int_12)
						num2 /= 2;
					int_2 -= num2;
				}
			}
			else
			{
				for (int i = 0; i < int_16.Length; i++)
				{
					int_16[0] = GClass73.int_0;
				}
				int_15 = GClass73.int_0;
				bool_0 = true;
				int_18 = -1;
				bool_1 = int_17 != 0;
				int_17 = 0;
			}
		}
		bool flag = false;
		if (GClass73.bool_16 && bool_0)
		{
			int i2 = GClass73.int_0 - int_16[0];
			GClass73.bool_16 = false;
			if (GClass50.smethod_28(i2) < 20 && GClass50.smethod_28(GClass73.int_0 - int_15) < 20 && !bool_1)
			{
				int_17 = 0;
				int_0 = int_2;
				int_15 = -1000;
				int_18 = (int_0 + GClass73.int_0 - num) / int_19;
				int_14 = 0;
				flag = true;
			}
			else if (int_18 == -1 || int_14 <= 5)
			{
				if (int_18 == -1 && !bool_1)
				{
					if (int_2 >= 0)
					{
						if (int_2 <= int_12)
						{
							int num4 = GClass73.int_0 - int_16[0] + (int_16[0] - int_16[1]) + (int_16[1] - int_16[2]);
							int_17 = -((num4 > 10) ? 10 : ((num4 < -10) ? (-10) : 0)) * 100;
						}
						else
							int_0 = int_12;
					}
					else
						int_0 = 0;
				}
			}
			else
			{
				int_14 = 0;
				flag = true;
			}
			bool_0 = false;
			int_14 = 0;
			GClass73.bool_16 = false;
		}
		GClass11 gClass = new GClass11();
		gClass.int_0 = int_18;
		gClass.bool_1 = flag;
		gClass.bool_0 = bool_0;
		return gClass;
	}

	public void method_5()
	{
		if (int_17 != 0 && !bool_0)
		{
			if (bool_2)
			{
				int_1 += int_17 / 100;
				if (int_1 >= 0)
				{
					if (int_1 <= int_13)
						int_3 = int_1;
					else
						int_1 = int_13;
				}
				else
					int_1 = 0;
			}
			else
			{
				int_0 += int_17 / 100;
				if (int_0 >= 0)
				{
					if (int_0 <= int_12)
						int_2 = int_0;
					else
						int_0 = int_12;
				}
				else
					int_0 = 0;
			}
			int_17 = int_17 * 9 / 10;
			if (int_17 < 100 && int_17 > -100)
				int_17 = 0;
		}
		if (int_2 != int_0 && !bool_0)
		{
			int_4 = int_0 - int_2 << 2;
			int_6 += int_4;
			int_2 += int_6 >> 4;
			int_6 &= 15;
		}
		if (int_3 != int_1 && !bool_0)
		{
			int_5 = int_1 - int_3 << 2;
			int_7 += int_5;
			int_3 += int_7 >> 4;
			int_7 &= 15;
		}
	}

	public void method_6(int nItem, int ITEM_SIZE, int xPos, int yPos, int width, int height, bool styleUPDOWN, int ITEM_PER_LINE)
	{
		int_8 = xPos;
		int_9 = yPos;
		int_19 = ITEM_SIZE;
		int_20 = nItem;
		int_10 = width;
		int_11 = height;
		bool_2 = styleUPDOWN;
		int_21 = ITEM_PER_LINE;
		GClass50.smethod_8("nItem= " + nItem + " ITEMSIZE= " + ITEM_SIZE + " heghit= " + height);
		if (styleUPDOWN)
		{
			int num = nItem / ITEM_PER_LINE;
			if (nItem % ITEM_PER_LINE != 0)
				num++;
			int_13 = num * ITEM_SIZE - height;
		}
		else
			int_12 = ITEM_PER_LINE * ITEM_SIZE - width;
		if (int_13 < 0)
			int_13 = 0;
		if (int_12 < 0)
			int_12 = 0;
	}

	public void method_7(int to)
	{
		if (bool_2)
		{
			to -= (int_11 - int_19) / 2;
			int_1 = to;
			if (int_1 < 0)
				int_1 = 0;
			if (int_1 > int_13)
				int_1 = int_13;
		}
		else
		{
			to -= (int_10 - int_19) / 2;
			int_0 = to;
			if (int_0 < 0)
				int_0 = 0;
			if (int_0 > int_12)
				int_0 = int_12;
		}
	}

	public static GClass179 smethod_0()
	{
		if (gclass179_0 == null)
			gclass179_0 = new GClass179();
		return gclass179_0;
	}
}
