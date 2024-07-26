using System;

public class GClass17
{
	public int int_0;

	public int int_1;

	public int int_2;

	public GClass70 gclass70_0;

	public int int_3 = -1;

	public int int_4;

	public int int_5;

	public GClass17(int ID)
	{
		int_3 = ID;
		GClass70 gClass = GClass107.smethod_0(ID);
		if (gClass != null)
		{
			gclass70_0 = gClass;
			int_0 = GClass107.short_20[ID][0];
			int_1 = GClass107.short_20[ID][1] / GClass107.short_20[ID][2];
			int_2 = GClass107.short_20[ID][2];
		}
	}

	public GClass17(GClass70 img, int width, int height)
	{
		if (img != null)
		{
			gclass70_0 = img;
			int_0 = width;
			int_1 = height;
			int_2 = img.method_1() / height;
			if (int_2 < 1)
				int_2 = 1;
		}
	}

	public GClass17(GClass70 img, int numW, int numH, int numNull)
	{
		if (img != null)
		{
			gclass70_0 = img;
			int_4 = numW;
			int_5 = numH;
			int_0 = gclass70_0.method_0() / numW;
			int_1 = gclass70_0.method_1() / numH;
			int_2 = numW * numH - numNull;
		}
	}

	public void method_0(int idx, int x, int y, int trans, int anchor, GClass122 g)
	{
		try
		{
			if (gclass70_0 != null)
			{
				if (idx > int_2)
					idx = int_2;
				int num = idx * int_1;
				if (num > int_1 * (int_2 - 1) || num < 0)
					num = int_1 * (int_2 - 1);
				g.method_23(gclass70_0, 0, num, int_0, int_1, trans, x, y, anchor);
			}
		}
		catch (Exception)
		{
		}
	}
}
