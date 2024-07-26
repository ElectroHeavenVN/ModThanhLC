using System;
using AssemblyCSharp.Functions;

public class GClass81
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

	public GClass78 gclass78_0;

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

	public static GClass88 gclass88_0 = new GClass88();

	public int int_48;

	public long long_0;

	public static GClass88 gclass88_1 = new GClass88();

	public static GClass88 gclass88_2 = new GClass88();

	private int[] int_49 = new int[10] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

	private int[] int_50 = new int[10] { 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 };

	private int[] int_51 = new int[10] { 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

	private int[] int_52 = new int[10] { 6, 6, 6, 6, 6, 7, 7, 7, 7, 7 };

	private int[] int_53 = new int[10] { 8, 8, 8, 8, 8, 9, 9, 9, 9, 9 };

	private bool bool_2;

	private short[] short_0;

	public int int_54;

	public long long_1;

	public GClass81()
	{
	}

	public GClass81(int id, GClass78 c, int layer, int loop, int loopCount, sbyte isStand)
	{
		gclass78_0 = c;
		int_0 = id;
		int_46 = layer;
		int_43 = loop;
		int_44 = loopCount;
		int_47 = isStand;
		if (smethod_2(id) == null)
		{
			GClass72 gClass = new GClass72
			{
				int_0 = id
			};
			if (id >= 42 && id <= 46)
				id = 106;
			string text = "/x" + GClass122.int_12 + "/effectdata/" + id + "/data";
			if (GClass200.smethod_0(text) != null)
			{
				if (id > 100 && id < 200)
					gClass.method_4(text);
				else
					gClass.method_3(text);
				gClass.gclass70_0 = GClass73.smethod_43("/effectdata/" + id + "/img.png");
			}
			else
				GClass7.smethod_0().method_57((short)id);
			smethod_1(gClass);
		}
		int_2 = -1;
		int_3 = -1;
		int_48 = -1;
		int_1 = 4;
		if (id == 78)
			int_1 = 5;
	}

	public GClass81(int id, int x, int y, int layer, int loop, int loopCount)
	{
		int_41 = x;
		int_42 = y;
		int_0 = id;
		int_46 = layer;
		int_43 = loop;
		int_44 = loopCount;
		if (smethod_2(id) == null)
		{
			GClass72 gClass = new GClass72
			{
				int_0 = id
			};
			if (id >= 42 && id <= 46)
				id = 106;
			string text = "/x" + GClass122.int_12 + "/effectdata/" + id + "/data";
			if (GClass200.smethod_0(text) == null)
				GClass7.smethod_0().method_57((short)id);
			else
			{
				if (id > 100 && id < 200)
					gClass.method_4(text);
				else
					gClass.method_3(text);
				gClass.gclass70_0 = GClass73.smethod_43("/effectdata/" + id + "/img.png");
			}
			smethod_1(gClass);
			if (gclass88_1.method_2() > 20)
			{
				smethod_0(int.Parse((string)gclass88_1.method_3(0)));
				gclass88_1.method_7(0);
			}
			gclass88_1.method_0(int_0 + "");
		}
		int_2 = -1;
		int_3 = -1;
		if (id != 78)
			int_1 = 1;
		else
			int_1 = 5;
		if (!smethod_3(int_0 + ""))
			gclass88_2.method_0(int_0 + "");
	}

	public static void smethod_0(int id)
	{
		int num = 0;
		GClass72 gClass;
		while (true)
		{
			if (num < gclass88_0.method_2())
			{
				gClass = (GClass72)gclass88_0.method_3(num);
				if (gClass.int_0 == id)
					break;
				num++;
				continue;
			}
			return;
		}
		gclass88_0.method_8(gClass);
	}

	public static void smethod_1(GClass72 eff)
	{
		gclass88_0.method_0(eff);
		if (GClass20.int_37 != 130 && gclass88_0.method_2() > 10)
		{
			for (int i = 0; i < 5; i++)
			{
				gclass88_0.method_7(0);
			}
		}
	}

	public static GClass72 smethod_2(int id)
	{
		int num = 0;
		GClass72 gClass;
		while (true)
		{
			if (num < gclass88_0.method_2())
			{
				gClass = (GClass72)gclass88_0.method_3(num);
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
		for (int i = 0; i < gclass88_2.method_2(); i++)
		{
			if (((string)gclass88_2.method_3(i)).Equals(id))
				return true;
		}
		return false;
	}

	public bool method_0()
	{
		if (bool_1)
			return true;
		return false;
	}

	public void method_1(GClass122 g, int xLayer, int yLayer)
	{
		if (method_0() && smethod_2(int_0).gclass70_0 != null)
			smethod_2(int_0).method_9(g, int_40, int_41 + xLayer, int_42 + yLayer, int_48, int_46);
	}

	public void method_2()
	{
		if (!GClass167.smethod_0().bool_10)
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

	public void method_3(GClass122 g)
	{
		if (bool_1 && smethod_2(int_0) != null && smethod_2(int_0).gclass70_0 != null)
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
				if (smethod_2(int_0) == null || smethod_2(int_0).gclass70_0 == null)
					return;
				if (int_1 == 5)
					short_0 = smethod_2(int_0).method_2(gclass78_0.int_11);
				else
					short_0 = smethod_2(int_0).method_1();
				if (short_0 != null)
				{
					if (!bool_2)
					{
						bool_2 = true;
						int num = short_0.Length - 1;
						if (num > 0 && int_1 != 1)
							int_39 = GClass50.smethod_19(0, num);
						if (int_1 == 0)
							int_39 = GClass50.smethod_19(int_2, int_3);
					}
					switch (int_1)
					{
					case 0:
						if (GClass50.smethod_29(int_41 - 50, int_42 - 50, 100, 100, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5) && int_39 > int_2 && int_39 < int_3)
						{
							if (int_39 < int_3)
								int_39 = int_3;
							bool_0 = true;
						}
						if (bool_0)
						{
							if (int_39 < short_0.Length)
								int_39++;
							break;
						}
						int_39++;
						if (int_39 == int_3)
							int_39 = int_2;
						break;
					case 2:
						if (int_39 < short_0.Length)
							int_39++;
						int_45++;
						if (int_45 == int_44)
						{
							int_45 = 0;
							int_48 = GClass50.smethod_19(0, 2);
						}
						break;
					case 1:
					case 3:
						if (int_39 < short_0.Length)
							int_39++;
						break;
					case 4:
						int_41 = gclass78_0.int_4;
						int_42 = gclass78_0.int_5;
						if (int_39 < short_0.Length)
							int_39++;
						break;
					case 5:
						int_48 = ((gclass78_0.int_12 != 1) ? 1 : 0);
						if (gclass78_0.int_12 == 1)
							int_41 = gclass78_0.int_4 - 15;
						else
							int_41 = gclass78_0.int_4 + 15;
						if (gclass78_0.sbyte_35 != 0)
							int_42 = gclass78_0.int_5 - 35;
						else
							int_42 = gclass78_0.int_5 - 25;
						if (int_39 < short_0.Length)
							int_39++;
						break;
					}
					if (int_39 == short_0.Length / 2 && (int_0 == 62 || int_0 == 63 || int_0 == 64 || int_0 == 65))
						GClass109.smethod_2(int_41, int_42, GClass109.int_35, GClass109.float_0);
					if (int_39 <= short_0.Length - 1)
						int_40 = short_0[int_39];
				}
				if (int_39 >= short_0.Length - 1)
				{
					if (int_1 == 0 || int_1 == 3)
						bool_1 = false;
					if (int_44 == -1)
						GClass57.gclass88_0.method_8(this);
					if (int_1 != 2)
					{
						if (int_1 == 1 && int_43 == 1)
							bool_1 = false;
						if (int_1 != 4 && int_1 != 5)
						{
							bool_0 = false;
							if (int_43 == -1)
							{
								int_45++;
								int_39 = 0;
								if (int_45 == int_44)
								{
									int_45 = 0;
									if (int_44 > 1)
										int_48 = GClass50.smethod_19(0, 2);
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
									GClass57.gclass88_0.method_8(this);
							}
						}
						else if (int_43 != -1)
						{
							int_45++;
							if (int_45 == int_44)
							{
								int_45 = 0;
								int_43--;
								int_39 = 0;
								if (int_43 == 0)
									gclass78_0.method_141(0, int_0);
							}
						}
						else
						{
							int_39 = 0;
						}
					}
					else
						int_39 = 0;
				}
				else
					bool_1 = true;
			}
		}
		catch (Exception)
		{
			GClass57.gclass88_0.method_8(this);
		}
	}

	public int method_5()
	{
		return short_0.Length;
	}
}
