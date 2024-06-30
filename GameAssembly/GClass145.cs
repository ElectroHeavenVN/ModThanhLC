public class GClass145
{
	public GClass14 gclass14_0;

	public GClass14 gclass14_1;

	public GClass14 gclass14_2;

	public GClass14 gclass14_3;

	public static int int_0;

	public static int int_1 = 100;

	public static int int_2 = 68;

	public static int int_3 = 26;

	public static int int_4 = -1;

	public static int int_5 = -1;

	public virtual void switchToMe()
	{
		GClass39.smethod_26();
		GClass39.smethod_27();
		if (GClass39.gclass145_0 != null)
			GClass39.gclass145_0.unLoad();
		GClass39.gclass145_0 = this;
		GClass5.smethod_4("cur Screen: " + GClass39.gclass145_0);
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
		if (GClass39.bool_11[(!Main.isPC) ? 5 : 25] || smethod_1(GClass39.gclass145_0.gclass14_1))
		{
			GClass39.bool_11[(!Main.isPC) ? 5 : 25] = false;
			int_4 = -1;
			GClass39.bool_16 = false;
			if (gclass14_1 != null)
				gclass14_1.method_1();
		}
		if (GClass39.bool_11[12] || smethod_1(GClass39.gclass145_0.gclass14_0))
		{
			GClass39.bool_11[12] = false;
			int_4 = -1;
			GClass39.bool_16 = false;
			if (GClass7.smethod_0().bool_0)
			{
				if (GClass7.smethod_0().gclass14_0 != null)
					GClass7.smethod_0().gclass14_0.method_1();
			}
			else if (gclass14_0 != null)
			{
				gclass14_0.method_1();
			}
		}
		if (!GClass39.bool_11[13] && !smethod_1(GClass39.gclass145_0.gclass14_2))
			return;
		GClass39.bool_11[13] = false;
		int_4 = -1;
		GClass39.bool_16 = false;
		if (GClass7.smethod_0().bool_0)
		{
			if (GClass7.smethod_0().gclass14_2 != null)
				GClass7.smethod_0().gclass14_2.method_1();
		}
		else if (gclass14_2 != null)
		{
			gclass14_2.method_1();
		}
	}

	public static bool smethod_1(GClass14 cmd)
	{
		if (cmd == null)
			return false;
		if (cmd.int_1 >= 0 && cmd.int_2 != 0)
			return cmd.method_4();
		if (GClass39.gclass99_0 != null)
		{
			if (GClass39.gclass99_0.gclass14_1 != null && GClass39.smethod_24(GClass39.int_10 - int_2 >> 1, GClass39.int_11 - int_3 - 5, int_2, int_3 + 10))
			{
				int_4 = 1;
				if (cmd == GClass39.gclass99_0.gclass14_1 && GClass39.bool_15 && GClass39.bool_16)
					return true;
			}
			if (GClass39.gclass99_0.gclass14_0 != null && GClass39.smethod_24(0, GClass39.int_11 - int_3 - 5, int_2, int_3 + 10))
			{
				int_4 = 0;
				if (cmd == GClass39.gclass99_0.gclass14_0 && GClass39.bool_15 && GClass39.bool_16)
					return true;
			}
			if (GClass39.gclass99_0.gclass14_2 != null && GClass39.smethod_24(GClass39.int_10 - int_2, GClass39.int_11 - int_3 - 5, int_2, int_3 + 10))
			{
				int_4 = 2;
				if ((cmd == GClass39.gclass99_0.gclass14_2 || cmd == GClass7.smethod_0().gclass14_2) && GClass39.bool_15 && GClass39.bool_16)
					return true;
			}
		}
		else
		{
			if (cmd == GClass39.gclass145_0.gclass14_0 && GClass39.smethod_24(0, GClass39.int_11 - int_3 - 5, int_2, int_3 + 10))
			{
				int_4 = 0;
				if (GClass39.bool_15 && GClass39.bool_16)
					return true;
			}
			if (cmd == GClass39.gclass145_0.gclass14_2 && GClass39.smethod_24(GClass39.int_10 - int_2, GClass39.int_11 - int_3 - 5, int_2, int_3 + 10))
			{
				int_4 = 2;
				if (GClass39.bool_15 && GClass39.bool_16)
					return true;
			}
			if ((cmd == GClass39.gclass145_0.gclass14_1 || GClass70.gclass70_0 != null) && GClass39.smethod_24(GClass39.int_10 - int_2 >> 1, GClass39.int_11 - int_3 - 5, int_2, int_3 + 10))
			{
				int_4 = 1;
				if (GClass39.bool_15 && GClass39.bool_16)
					return true;
			}
		}
		return false;
	}

	public virtual void paint(GClass76 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11 + 1);
		if ((!GClass7.smethod_0().bool_0 || !Main.isPC) && GClass39.gclass99_0 == null && !GClass39.gclass0_0.bool_0)
			GClass39.gclass37_0.method_7(g, gclass14_0, gclass14_1, gclass14_2);
	}
}
