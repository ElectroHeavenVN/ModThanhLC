public abstract class GClass42
{
	public GClass87 gclass87_0;

	public GClass87 gclass87_1;

	public GClass87 gclass87_2;

	private int int_0;

	public virtual void paint(GClass122 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass73.int_10, GClass73.int_11);
		GClass73.gclass192_0.method_8(g);
		GClass73.gclass192_0.method_7(g, gclass87_0, gclass87_1, gclass87_2);
	}

	public virtual void keyPress(int keyCode)
	{
		if (keyCode <= -22)
		{
			if (keyCode == -39)
				goto IL_00a3;
			if (keyCode == -38)
				goto IL_00cb;
			if (keyCode != -22)
				return;
		}
		else
		{
			if (keyCode == -21)
				goto IL_00f3;
			switch (keyCode)
			{
			default:
				if (keyCode != 10)
					return;
				goto case -5;
			case -7:
				break;
			case -5:
				GClass73.bool_13[(!Main.isPC) ? 5 : 25] = true;
				GClass73.bool_11[(!Main.isPC) ? 5 : 25] = true;
				return;
			case -2:
				goto IL_00a3;
			case -1:
				goto IL_00cb;
			case -6:
				goto IL_00f3;
			case -4:
			case -3:
				return;
			}
		}
		GClass73.bool_13[13] = true;
		GClass73.bool_11[13] = true;
		return;
		IL_00a3:
		GClass73.bool_13[Main.isPC ? 22 : 8] = true;
		GClass73.bool_11[(!Main.isPC) ? 8 : 22] = true;
		return;
		IL_00cb:
		GClass73.bool_13[(!Main.isPC) ? 2 : 21] = true;
		GClass73.bool_11[(!Main.isPC) ? 2 : 21] = true;
		return;
		IL_00f3:
		GClass73.bool_13[12] = true;
		GClass73.bool_11[12] = true;
	}

	public virtual void update()
	{
		if (gclass87_1 != null && (GClass73.bool_11[(!Main.isPC) ? 5 : 25] || GClass131.smethod_1(gclass87_1)))
		{
			GClass73.bool_11[(!Main.isPC) ? 5 : 25] = false;
			GClass73.bool_15 = false;
			GClass131.int_4 = -1;
			GClass73.bool_16 = false;
			if (gclass87_1 != null)
				gclass87_1.method_1();
			GClass131.int_4 = -1;
		}
		if (gclass87_0 != null && (GClass73.bool_11[12] || GClass131.smethod_1(gclass87_0)))
		{
			GClass73.bool_11[12] = false;
			GClass73.bool_15 = false;
			GClass131.int_4 = -1;
			GClass73.bool_16 = false;
			if (gclass87_0 != null)
				gclass87_0.method_1();
			GClass131.int_4 = -1;
		}
		if (gclass87_2 != null && (GClass73.bool_11[13] || GClass131.smethod_1(gclass87_2)))
		{
			GClass73.bool_11[13] = false;
			GClass73.bool_15 = false;
			GClass73.bool_16 = false;
			GClass131.int_4 = -1;
			if (gclass87_2 != null)
				gclass87_2.method_1();
			GClass131.int_4 = -1;
		}
		GClass73.smethod_26();
		GClass73.smethod_27();
	}

	public virtual void show()
	{
	}
}
