using UnityEngine;

public class GClass82
{
	public int int_0;

	public bool bool_0;

	public bool bool_1;

	public short short_0;

	public int int_1;

	public int int_2;

	private long long_0;

	private long long_1;

	private bool bool_2;

	private bool bool_3;

	public string string_0;

	private bool bool_4;

	public int int_3;

	public int int_4;

	private int int_5 = 100;

	public GClass82(short idIcon, int time, bool isEquivalence)
		: this(idIcon, time)
	{
		bool_0 = isEquivalence;
	}

	public GClass82()
	{
	}

	public GClass82(short idIcon, int s)
	{
		short_0 = idIcon;
		int_2 = s / 60;
		int_1 = s % 60;
		int_0 = 0;
		int_3 = s;
		int_4 = s;
		long_0 = (long_1 = GClass77.smethod_18());
		bool_4 = idIcon == 14;
	}

	public void method_0(sbyte id, string text, int time)
	{
		if (time == -1)
			bool_3 = true;
		else
			bool_3 = false;
		bool_2 = true;
		int_2 = time / 60;
		int_1 = time % 60;
		int_0 = 0;
		short_0 = id;
		int_3 = time;
		int_4 = time;
		string_0 = text;
		long_0 = (long_1 = GClass77.smethod_18());
		bool_4 = short_0 == 14;
	}

	public void method_1(int time, bool isText)
	{
		int_2 = time / 60;
		int_1 = time % 60;
		int_0 = 0;
		int_3 = time;
		int_4 = time;
		bool_2 = isText;
		long_0 = (long_1 = GClass77.smethod_18());
	}

	public static bool smethod_0(int id)
	{
		for (int i = 0; i < GClass124.gclass122_5.method_2(); i++)
		{
			if (((GClass82)GClass124.gclass122_5.method_3(i)).short_0 == id)
				return true;
		}
		return false;
	}

	public static GClass82 smethod_1(int id)
	{
		for (int i = 0; i < GClass167.gclass122_0.method_2(); i++)
		{
			GClass82 gClass = (GClass82)GClass167.gclass122_0.method_3(i);
			if (gClass.short_0 == id)
				return gClass;
		}
		return null;
	}

	public static bool smethod_2(int id)
	{
		int num = 0;
		while (true)
		{
			if (num < GClass167.gclass122_0.method_2())
			{
				if (((GClass82)GClass167.gclass122_0.method_3(num)).short_0 == id)
					break;
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static GClass82 smethod_3(int id)
	{
		for (int i = 0; i < GClass124.gclass122_5.method_2(); i++)
		{
			GClass82 gClass = (GClass82)GClass124.gclass122_5.method_3(i);
			if (gClass.short_0 == id)
				return gClass;
		}
		return null;
	}

	public void method_2(int time)
	{
		int_2 = time / 60;
		int_1 = time % 60;
		int_4 = time;
		int_0 = 0;
		long_0 = (long_1 = GClass77.smethod_18());
	}

	public void method_3(GClass193 g, int x, int y)
	{
		GClass72.smethod_6(g, short_0, x, y, 0, 3);
		string text = string.Empty;
		if (!bool_1)
		{
			text = int_2 + "'" + int_1;
			if (int_2 == 0)
			{
				text = int_1 + "s";
				if (int_1 < 10)
					text = int_1 + "." + int_0 + "s";
			}
			if (bool_0)
				text = "~" + text;
		}
		GClass104.gclass104_20.method_10(g, text, x, y + 15, 2, GClass104.gclass104_6);
	}

	public void method_4(GClass193 g, int x, int y)
	{
		if (bool_4)
		{
			if (GClass124.smethod_1() != null)
			{
				int num = 80;
				int x2 = GClass14.int_10 / 2 - 40;
				int y2 = GClass14.int_11 - 80;
				g.method_16(8421504);
				g.method_15(x2, y2, 80, 2);
				g.method_16(16777215);
				if (int_5 > 0)
					g.method_15(x2, y2, num * int_5 / 100, 2);
			}
			return;
		}
		string empty = string.Empty;
		empty = int_2 + "'";
		if (int_2 < 1)
			empty = int_1 + "s";
		if (int_2 < 0)
			empty = string.Empty;
		if (bool_3)
			empty = string.Empty;
		GClass104.gclass104_20.method_10(g, string_0 + " " + empty, x, y, 0, GClass104.gclass104_6);
	}

	public void method_5()
	{
		if (GClass137.int_37 == 21 + GClass124.smethod_1().int_14 && short_0 != 2295 && short_0 != 722 && short_0 != 3779 && short_0 != 717 && short_0 != 718)
			return;
		int_0 = Mathf.Clamp((int)(9L - (long_0 - long_1) / 100L), 0, 9);
		long_0 = GClass77.smethod_18();
		if (long_0 - long_1 >= 1000L)
		{
			long_1 = GClass77.smethod_18();
			int_1--;
			int_4--;
			if (int_1 <= 0)
			{
				int_1 = 60;
				int_2--;
			}
			if (int_3 > 0)
				int_5 = int_4 * 100 / int_3;
		}
		if (int_2 < 0 && !bool_2)
			GClass124.gclass122_5.method_8(this);
		if (int_2 < 0 && bool_2 && !bool_3)
			GClass167.gclass122_0.method_8(this);
	}
}
