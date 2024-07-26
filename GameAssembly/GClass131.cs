public class GClass131
{
	public GClass87 gclass87_0;

	public GClass87 gclass87_1;

	public GClass87 gclass87_2;

	public GClass87 gclass87_3;

	public static int int_0;

	public static int int_1 = 100;

	public static int int_2 = 68;

	public static int int_3 = 26;

	public static int int_4 = -1;

	public static int int_5 = -1;

	public virtual void switchToMe()
	{
		GClass73.smethod_26();
		GClass73.smethod_27();
		if (GClass73.gclass131_0 != null)
			GClass73.gclass131_0.unLoad();
		GClass73.gclass131_0 = this;
		GClass36.smethod_4("cur Screen: " + GClass73.gclass131_0);
	}

	public virtual void unLoad()
	{
	}

	public static void smethod_0()
	{
	}

	public virtual void keyPress(int keyCode)
	{
	}

	public virtual void update()
	{
	}

	public virtual void updateKey()
	{
		if (GClass73.bool_11[(!Main.isPC) ? 5 : 25] || smethod_1(GClass73.gclass131_0.gclass87_1))
		{
			GClass73.bool_11[(!Main.isPC) ? 5 : 25] = false;
			int_4 = -1;
			GClass73.bool_16 = false;
			if (gclass87_1 != null)
				gclass87_1.method_1();
		}
		if (GClass73.bool_11[12] || smethod_1(GClass73.gclass131_0.gclass87_0))
		{
			GClass73.bool_11[12] = false;
			int_4 = -1;
			GClass73.bool_16 = false;
			if (GClass91.smethod_0().bool_0)
			{
				if (GClass91.smethod_0().gclass87_0 != null)
					GClass91.smethod_0().gclass87_0.method_1();
			}
			else if (gclass87_0 != null)
			{
				gclass87_0.method_1();
			}
		}
		if (!GClass73.bool_11[13] && !smethod_1(GClass73.gclass131_0.gclass87_2))
			return;
		GClass73.bool_11[13] = false;
		int_4 = -1;
		GClass73.bool_16 = false;
		if (!GClass91.smethod_0().bool_0)
		{
			if (gclass87_2 != null)
				gclass87_2.method_1();
		}
		else if (GClass91.smethod_0().gclass87_2 != null)
		{
			GClass91.smethod_0().gclass87_2.method_1();
		}
	}

	public static bool smethod_1(GClass87 cmd)
	{
		if (cmd != null)
		{
			if (cmd.int_1 < 0 || cmd.int_2 == 0)
			{
				if (GClass73.gclass42_0 == null)
				{
					if (cmd == GClass73.gclass131_0.gclass87_0 && GClass73.smethod_24(0, GClass73.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 0;
						if (GClass73.bool_15 && GClass73.bool_16)
							return true;
					}
					if (cmd == GClass73.gclass131_0.gclass87_2 && GClass73.smethod_24(GClass73.int_10 - int_2, GClass73.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 2;
						if (GClass73.bool_15 && GClass73.bool_16)
							return true;
					}
					if ((cmd == GClass73.gclass131_0.gclass87_1 || GClass96.gclass96_0 != null) && GClass73.smethod_24(GClass73.int_10 - int_2 >> 1, GClass73.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 1;
						if (GClass73.bool_15 && GClass73.bool_16)
							return true;
					}
				}
				else
				{
					if (GClass73.gclass42_0.gclass87_1 != null && GClass73.smethod_24(GClass73.int_10 - int_2 >> 1, GClass73.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 1;
						if (cmd == GClass73.gclass42_0.gclass87_1 && GClass73.bool_15 && GClass73.bool_16)
							return true;
					}
					if (GClass73.gclass42_0.gclass87_0 != null && GClass73.smethod_24(0, GClass73.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 0;
						if (cmd == GClass73.gclass42_0.gclass87_0 && GClass73.bool_15 && GClass73.bool_16)
							return true;
					}
					if (GClass73.gclass42_0.gclass87_2 != null && GClass73.smethod_24(GClass73.int_10 - int_2, GClass73.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 2;
						if ((cmd == GClass73.gclass42_0.gclass87_2 || cmd == GClass91.smethod_0().gclass87_2) && GClass73.bool_15 && GClass73.bool_16)
							return true;
					}
				}
				return false;
			}
			return cmd.method_4();
		}
		return false;
	}

	public virtual void paint(GClass122 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass73.int_10, GClass73.int_11 + 1);
		if ((!GClass91.smethod_0().bool_0 || !Main.isPC) && GClass73.gclass42_0 == null && !GClass73.gclass145_0.bool_0)
			GClass73.gclass192_0.method_7(g, gclass87_0, gclass87_1, gclass87_2);
	}
}
