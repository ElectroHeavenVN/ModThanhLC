using System;
using ns1;

public class GClass33
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;

	public const int int_4 = 0;

	public const int int_5 = 1;

	public const int int_6 = 2;

	public const int int_7 = 3;

	public const int int_8 = 4;

	public const int int_9 = 5;

	public const int int_10 = 0;

	public const int int_11 = 1;

	public const int int_12 = 2;

	public const int int_13 = 3;

	public const int int_14 = 5;

	public const int int_15 = 4;

	public const int int_16 = 6;

	public const int int_17 = 7;

	public const int int_18 = 8;

	public const int int_19 = 9;

	public const int int_20 = 10;

	public const int int_21 = 11;

	public const int int_22 = 12;

	public const int int_23 = 13;

	public const int int_24 = 14;

	public const int int_25 = 15;

	public const int int_26 = 16;

	public const int int_27 = 17;

	public const int int_28 = 26;

	public const int int_29 = 27;

	public const int int_30 = 28;

	public const int int_31 = 29;

	public const int int_32 = 30;

	public const int int_33 = 31;

	public const int int_34 = 42;

	public const int int_35 = 43;

	public const int int_36 = 44;

	public const int int_37 = 45;

	public const int int_38 = 46;

	public GClass58 gclass58_0;

	public int int_39;

	public int int_40;

	public int int_41;

	public int int_42;

	public int int_43;

	public int int_44;

	public int int_45;

	private bool bool_1 = true;

	public int int_46;

	public int int_47;

	public static GClass63 gclass63_0 = new GClass63();

	public int int_48;

	public long long_0;

	public static GClass63 gclass63_1 = new GClass63();

	public static GClass63 gclass63_2 = new GClass63();

	private int[] int_49 = new int[10] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

	private int[] int_50 = new int[10] { 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 };

	private int[] int_51 = new int[10] { 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

	private int[] int_52 = new int[10] { 6, 6, 6, 6, 6, 7, 7, 7, 7, 7 };

	private int[] int_53 = new int[10] { 8, 8, 8, 8, 8, 9, 9, 9, 9, 9 };

	private bool bool_2;

	private short[] short_0;

	public int int_54;

	public long long_1;

	public GClass33()
	{
	}

	public GClass33(int id, GClass58 c, int layer, int loop, int loopCount, sbyte isStand)
	{
		gclass58_0 = c;
		int_0 = id;
		int_46 = layer;
		int_43 = loop;
		int_44 = loopCount;
		int_47 = isStand;
		if (smethod_2(id) == null)
		{
			GClass167 gClass = new GClass167
			{
				int_0 = id
			};
			if (id >= 42 && id <= 46)
				id = 106;
			string text = "/x" + GClass76.int_12 + "/effectdata/" + id + "/data";
			if (GClass208.smethod_0(text) != null)
			{
				if (id > 100 && id < 200)
					gClass.method_4(text);
				else
					gClass.method_3(text);
				gClass.gclass2_0 = GClass39.smethod_43("/effectdata/" + id + "/img.png");
			}
			else
				GClass166.smethod_0().method_57((short)id);
			smethod_1(gClass);
		}
		int_2 = -1;
		int_3 = -1;
		int_48 = -1;
		int_1 = 4;
		if (id == 78)
			int_1 = 5;
	}

	public GClass33(int id, int x, int y, int layer, int loop, int loopCount)
	{
		int_41 = x;
		int_42 = y;
		int_0 = id;
		int_46 = layer;
		int_43 = loop;
		int_44 = loopCount;
		if (smethod_2(id) == null)
		{
			GClass167 gClass = new GClass167
			{
				int_0 = id
			};
			if (id >= 42 && id <= 46)
				id = 106;
			string text = "/x" + GClass76.int_12 + "/effectdata/" + id + "/data";
			if (GClass208.smethod_0(text) != null)
			{
				if (id > 100 && id < 200)
					gClass.method_4(text);
				else
					gClass.method_3(text);
				gClass.gclass2_0 = GClass39.smethod_43("/effectdata/" + id + "/img.png");
			}
			else
				GClass166.smethod_0().method_57((short)id);
			smethod_1(gClass);
			if (gclass63_1.method_2() > 20)
			{
				smethod_0(int.Parse((string)gclass63_1.method_3(0)));
				gclass63_1.method_7(0);
			}
			gclass63_1.method_0(int_0 + string.Empty);
		}
		int_2 = -1;
		int_3 = -1;
		if (id == 78)
			int_1 = 5;
		else
			int_1 = 1;
		if (!smethod_3(int_0 + string.Empty))
			gclass63_2.method_0(int_0 + string.Empty);
	}

	public static void smethod_0(int id)
	{
		int num = 0;
		GClass167 gClass;
		while (true)
		{
			if (num < gclass63_0.method_2())
			{
				gClass = (GClass167)gclass63_0.method_3(num);
				if (gClass.int_0 == id)
					break;
				num++;
				continue;
			}
			return;
		}
		gclass63_0.method_8(gClass);
	}

	public static void smethod_1(GClass167 eff)
	{
		gclass63_0.method_0(eff);
		if (GClass1.int_37 != 130 && gclass63_0.method_2() > 10)
		{
			for (int i = 0; i < 5; i++)
			{
				gclass63_0.method_7(0);
			}
		}
	}

	public static GClass167 smethod_2(int id)
	{
		int num = 0;
		GClass167 gClass;
		while (true)
		{
			if (num < gclass63_0.method_2())
			{
				gClass = (GClass167)gclass63_0.method_3(num);
				if (gClass.int_0 == id)
					break;
				num++;
				continue;
			}
			return null;
		}
		return gClass;
	}

	public static bool smethod_3(string id)
	{
		int num = 0;
		while (true)
		{
			if (num < gclass63_2.method_2())
			{
				if (((string)gclass63_2.method_3(num)).Equals(id))
					break;
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public bool method_0()
	{
		if (!bool_1)
			return false;
		return true;
	}

	public void method_1(GClass76 g, int xLayer, int yLayer)
	{
		if (method_0() && smethod_2(int_0).gclass2_0 != null)
			smethod_2(int_0).method_9(g, int_40, int_41 + xLayer, int_42 + yLayer, int_48, int_46);
	}

	public void method_2()
	{
		if (!GClass173.smethod_0().bool_9)
		{
			if (int_0 == 42)
				int_40 = int_49[int_39];
			if (int_0 == 43)
				int_40 = int_50[int_39];
			if (int_0 == 44)
				int_40 = int_51[int_39];
			if (int_0 == 45)
				int_40 = int_52[int_39];
			if (int_0 == 46)
				int_40 = int_53[int_39];
			int_39++;
			if (int_39 > int_49.Length - 1)
				int_39 = 0;
		}
	}

	public void method_3(GClass76 g)
	{
		if (bool_1 && smethod_2(int_0) != null && smethod_2(int_0).gclass2_0 != null)
			try
			{
				smethod_2(int_0).method_9(g, int_40, int_41, int_42, int_48, int_46);
			}
			catch (Exception)
			{
			}
	}

	public void method_4()
	{
		try
		{
			if (int_0 >= 42 && int_0 <= 46)
				method_2();
			else
			{
				if (smethod_2(int_0) == null || smethod_2(int_0).gclass2_0 == null)
					return;
				if (int_1 == 5)
					short_0 = smethod_2(int_0).method_2(gclass58_0.int_11);
				else
					short_0 = smethod_2(int_0).method_1();
				if (short_0 != null)
				{
					if (!bool_2)
					{
						bool_2 = true;
						int num = short_0.Length - 1;
						if (num > 0 && int_1 != 1)
							int_39 = GClass56.smethod_19(0, num);
						if (int_1 == 0)
							int_39 = GClass56.smethod_19(int_2, int_3);
					}
					switch (int_1)
					{
					case 0:
						if (GClass56.smethod_29(int_41 - 50, int_42 - 50, 100, 100, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5) && int_39 > int_2 && int_39 < int_3)
						{
							if (int_39 < int_3)
								int_39 = int_3;
							bool_0 = true;
						}
						if (!bool_0)
						{
							int_39++;
							if (int_39 == int_3)
								int_39 = int_2;
						}
						else if (int_39 < short_0.Length)
						{
							int_39++;
						}
						break;
					case 2:
						if (int_39 < short_0.Length)
							int_39++;
						int_45++;
						if (int_45 == int_44)
						{
							int_45 = 0;
							int_48 = GClass56.smethod_19(0, 2);
						}
						break;
					case 1:
					case 3:
						if (int_39 < short_0.Length)
							int_39++;
						break;
					case 4:
						int_41 = gclass58_0.int_4;
						int_42 = gclass58_0.int_5;
						if (int_39 < short_0.Length)
							int_39++;
						break;
					case 5:
						int_48 = ((gclass58_0.int_12 != 1) ? 1 : 0);
						if (gclass58_0.int_12 == 1)
							int_41 = gclass58_0.int_4 - 15;
						else
							int_41 = gclass58_0.int_4 + 15;
						if (gclass58_0.sbyte_35 == 0)
							int_42 = gclass58_0.int_5 - 25;
						else
							int_42 = gclass58_0.int_5 - 35;
						if (int_39 < short_0.Length)
							int_39++;
						break;
					}
					if (int_39 == short_0.Length / 2 && (int_0 == 62 || int_0 == 63 || int_0 == 64 || int_0 == 65))
						GClass29.smethod_2(int_41, int_42, GClass29.int_35, GClass29.float_0);
					if (int_39 <= short_0.Length - 1)
						int_40 = short_0[int_39];
				}
				if (int_39 >= short_0.Length - 1)
				{
					if (int_1 == 0 || int_1 == 3)
						bool_1 = false;
					if (int_44 == -1)
						GClass81.gclass63_0.method_8(this);
					if (int_1 == 2)
					{
						int_39 = 0;
						return;
					}
					if (int_1 == 1 && int_43 == 1)
						bool_1 = false;
					if (int_1 == 4 || int_1 == 5)
					{
						if (int_43 == -1)
						{
							int_39 = 0;
							return;
						}
						int_45++;
						if (int_45 == int_44)
						{
							int_45 = 0;
							int_43--;
							int_39 = 0;
							if (int_43 == 0)
								gclass58_0.method_139(0, int_0);
						}
						return;
					}
					bool_0 = false;
					if (int_43 == -1)
					{
						int_45++;
						int_39 = 0;
						if (int_45 == int_44)
						{
							int_45 = 0;
							if (int_44 > 1)
								int_48 = GClass56.smethod_19(0, 2);
						}
						return;
					}
					int_45++;
					int_39 = 0;
					if (int_45 == int_44)
					{
						int_45 = 0;
						int_43--;
						if (int_43 == 0)
							GClass81.gclass63_0.method_8(this);
					}
				}
				else
					bool_1 = true;
			}
		}
		catch (Exception)
		{
			GClass81.gclass63_0.method_8(this);
		}
	}

	public int method_5()
	{
		return short_0.Length;
	}
}
