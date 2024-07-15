public class GClass160
{
	public GClass118 gclass118_0;

	public GClass118 gclass118_1;

	public GClass118 gclass118_2;

	public GClass118 gclass118_3;

	public static int int_0;

	public static int int_1 = 100;

	public static int int_2 = 68;

	public static int int_3 = 26;

	public static int int_4 = -1;

	public static int int_5 = -1;

	public virtual void switchToMe()
	{
		GClass14.smethod_26();
		GClass14.smethod_27();
		if (GClass14.gclass160_0 != null)
			GClass14.gclass160_0.unLoad();
		GClass14.gclass160_0 = this;
		GClass92.smethod_4("cur Screen: " + GClass14.gclass160_0);
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
		if (GClass14.bool_11[(!Main.isPC) ? 5 : 25] || smethod_1(GClass14.gclass160_0.gclass118_1))
		{
			GClass14.bool_11[Main.isPC ? 25 : 5] = false;
			int_4 = -1;
			GClass14.bool_16 = false;
			if (gclass118_1 != null)
				gclass118_1.method_1();
		}
		if (GClass14.bool_11[12] || smethod_1(GClass14.gclass160_0.gclass118_0))
		{
			GClass14.bool_11[12] = false;
			int_4 = -1;
			GClass14.bool_16 = false;
			if (GClass107.smethod_0().bool_0)
			{
				if (GClass107.smethod_0().gclass118_0 != null)
					GClass107.smethod_0().gclass118_0.method_1();
			}
			else if (gclass118_0 != null)
			{
				gclass118_0.method_1();
			}
		}
		if (!GClass14.bool_11[13] && !smethod_1(GClass14.gclass160_0.gclass118_2))
			return;
		GClass14.bool_11[13] = false;
		int_4 = -1;
		GClass14.bool_16 = false;
		if (GClass107.smethod_0().bool_0)
		{
			if (GClass107.smethod_0().gclass118_2 != null)
				GClass107.smethod_0().gclass118_2.method_1();
		}
		else if (gclass118_2 != null)
		{
			gclass118_2.method_1();
		}
	}

	public static bool smethod_1(GClass118 cmd)
	{
		if (cmd != null)
		{
			if (cmd.int_1 < 0 || cmd.int_2 == 0)
			{
				if (GClass14.gclass183_0 == null)
				{
					if (cmd == GClass14.gclass160_0.gclass118_0 && GClass14.smethod_24(0, GClass14.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 0;
						if (GClass14.bool_15 && GClass14.bool_16)
							return true;
					}
					if (cmd == GClass14.gclass160_0.gclass118_2 && GClass14.smethod_24(GClass14.int_10 - int_2, GClass14.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 2;
						if (GClass14.bool_15 && GClass14.bool_16)
							return true;
					}
					if ((cmd == GClass14.gclass160_0.gclass118_1 || GClass88.gclass88_0 != null) && GClass14.smethod_24(GClass14.int_10 - int_2 >> 1, GClass14.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 1;
						if (GClass14.bool_15 && GClass14.bool_16)
							return true;
					}
				}
				else
				{
					if (GClass14.gclass183_0.gclass118_1 != null && GClass14.smethod_24(GClass14.int_10 - int_2 >> 1, GClass14.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 1;
						if (cmd == GClass14.gclass183_0.gclass118_1 && GClass14.bool_15 && GClass14.bool_16)
							return true;
					}
					if (GClass14.gclass183_0.gclass118_0 != null && GClass14.smethod_24(0, GClass14.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 0;
						if (cmd == GClass14.gclass183_0.gclass118_0 && GClass14.bool_15 && GClass14.bool_16)
							return true;
					}
					if (GClass14.gclass183_0.gclass118_2 != null && GClass14.smethod_24(GClass14.int_10 - int_2, GClass14.int_11 - int_3 - 5, int_2, int_3 + 10))
					{
						int_4 = 2;
						if ((cmd == GClass14.gclass183_0.gclass118_2 || cmd == GClass107.smethod_0().gclass118_2) && GClass14.bool_15 && GClass14.bool_16)
							return true;
					}
				}
				return false;
			}
			return cmd.method_4();
		}
		return false;
	}

	public virtual void paint(GClass193 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass14.int_10, GClass14.int_11 + 1);
		if ((!GClass107.smethod_0().bool_0 || !Main.isPC) && GClass14.gclass183_0 == null && !GClass14.gclass116_0.bool_0)
			GClass14.gclass97_0.method_7(g, gclass118_0, gclass118_1, gclass118_2);
	}
}
