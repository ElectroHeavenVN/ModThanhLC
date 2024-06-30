public class GClass82
{
	public bool bool_0;

	public bool bool_1;

	public short short_0;

	public int int_0;

	public int int_1;

	private long long_0;

	private long long_1;

	private bool bool_2;

	private bool bool_3;

	public string string_0;

	private bool bool_4;

	public int int_2;

	public int int_3;

	private int int_4 = 100;

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
		int_1 = s / 60;
		int_0 = s % 60;
		int_2 = s;
		int_3 = s;
		long_0 = (long_1 = GClass138.smethod_18());
		bool_4 = idIcon == 14;
	}

	public void method_0(sbyte id, string text, int time)
	{
		if (time == -1)
			bool_3 = true;
		else
			bool_3 = false;
		bool_2 = true;
		int_1 = time / 60;
		int_0 = time % 60;
		short_0 = id;
		int_2 = time;
		int_3 = time;
		string_0 = text;
		long_0 = (long_1 = GClass138.smethod_18());
		bool_4 = short_0 == 14;
	}

	public void method_1(int time, bool isText)
	{
		int_1 = time / 60;
		int_0 = time % 60;
		int_2 = time;
		int_3 = time;
		bool_2 = isText;
		long_0 = (long_1 = GClass138.smethod_18());
	}

	public static bool smethod_0(int id)
	{
		int num = 0;
		while (true)
		{
			if (num < GClass58.gclass63_5.method_2())
			{
				if (((GClass82)GClass58.gclass63_5.method_3(num)).short_0 == id)
					break;
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static GClass82 smethod_1(int id)
	{
		int num = 0;
		GClass82 gClass;
		while (true)
		{
			if (num < GClass154.gclass63_0.method_2())
			{
				gClass = (GClass82)GClass154.gclass63_0.method_3(num);
				if (gClass.short_0 == id)
					break;
				num++;
				continue;
			}
			return null;
		}
		return gClass;
	}

	public static bool smethod_2(int id)
	{
		int num = 0;
		while (true)
		{
			if (num < GClass154.gclass63_0.method_2())
			{
				if (((GClass82)GClass154.gclass63_0.method_3(num)).short_0 == id)
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
		int num = 0;
		GClass82 gClass;
		while (true)
		{
			if (num < GClass58.gclass63_5.method_2())
			{
				gClass = (GClass82)GClass58.gclass63_5.method_3(num);
				if (gClass.short_0 == id)
					break;
				num++;
				continue;
			}
			return null;
		}
		return gClass;
	}

	public void method_2(int time)
	{
		int_1 = time / 60;
		int_0 = time % 60;
		int_3 = time;
		long_0 = (long_1 = GClass138.smethod_18());
	}

	public void method_3(GClass76 g, int x, int y)
	{
		GClass96.smethod_6(g, short_0, x, y, 0, 3);
		string empty = string.Empty;
		empty = int_1 + "'";
		if (int_1 == 0)
			empty = int_0 + "s";
		GClass49.gclass49_3.method_10(g, empty, x, y + 15, 2, GClass49.gclass49_6);
	}

	public void method_4(GClass76 g, int x, int y)
	{
		if (bool_4)
		{
			if (GClass58.smethod_1() != null)
			{
				int num = 80;
				int x2 = GClass39.int_10 / 2 - 40;
				int y2 = GClass39.int_11 - 80;
				g.method_16(8421504);
				g.method_15(x2, y2, 80, 2);
				g.method_16(16777215);
				if (int_4 > 0)
					g.method_15(x2, y2, num * int_4 / 100, 2);
			}
			return;
		}
		string empty = string.Empty;
		empty = int_1 + "'";
		if (int_1 < 1)
			empty = int_0 + "s";
		if (int_1 < 0)
			empty = string.Empty;
		if (bool_3)
			empty = string.Empty;
		GClass49.gclass49_3.method_10(g, string_0 + " " + empty, x, y, 0, GClass49.gclass49_6);
	}

	public void method_5()
	{
		long_0 = GClass138.smethod_18();
		if (long_0 - long_1 >= 1000L)
		{
			long_1 = GClass138.smethod_18();
			int_0--;
			int_3--;
			if (int_0 <= 0)
			{
				int_0 = 60;
				int_1--;
			}
			if (int_2 > 0)
				int_4 = int_3 * 100 / int_2;
		}
		if (int_1 < 0 && !bool_2)
			GClass58.gclass63_5.method_8(this);
		if (int_1 < 0 && bool_2 && !bool_3)
			GClass154.gclass63_0.method_8(this);
	}
}
