public abstract class GClass99
{
	public GClass14 gclass14_0;

	public GClass14 gclass14_1;

	public GClass14 gclass14_2;

	private int int_0;

	public virtual void paint(GClass76 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		GClass39.gclass37_0.method_8(g);
		GClass39.gclass37_0.method_7(g, gclass14_0, gclass14_1, gclass14_2);
	}

	public virtual void keyPress(int keyCode)
	{
		if (keyCode <= -22)
		{
			if (keyCode == -39)
				goto IL_0099;
			if (keyCode == -38)
				goto IL_00c1;
			if (keyCode != -22)
				return;
		}
		else
		{
			if (keyCode == -21)
				goto IL_00e9;
			switch (keyCode)
			{
			default:
				if (keyCode != 10)
					return;
				goto case -5;
			case -7:
				break;
			case -5:
				GClass39.bool_13[(!Main.isPC) ? 5 : 25] = true;
				GClass39.bool_11[(!Main.isPC) ? 5 : 25] = true;
				return;
			case -2:
				goto IL_0099;
			case -1:
				goto IL_00c1;
			case -6:
				goto IL_00e9;
			case -4:
			case -3:
				return;
			}
		}
		GClass39.bool_13[13] = true;
		GClass39.bool_11[13] = true;
		return;
		IL_0099:
		GClass39.bool_13[(!Main.isPC) ? 8 : 22] = true;
		GClass39.bool_11[(!Main.isPC) ? 8 : 22] = true;
		return;
		IL_00c1:
		GClass39.bool_13[(!Main.isPC) ? 2 : 21] = true;
		GClass39.bool_11[(!Main.isPC) ? 2 : 21] = true;
		return;
		IL_00e9:
		GClass39.bool_13[12] = true;
		GClass39.bool_11[12] = true;
	}

	public virtual void update()
	{
		if (gclass14_1 != null && (GClass39.bool_11[(!Main.isPC) ? 5 : 25] || GClass145.smethod_1(gclass14_1)))
		{
			GClass39.bool_11[(!Main.isPC) ? 5 : 25] = false;
			GClass39.bool_15 = false;
			GClass145.int_4 = -1;
			GClass39.bool_16 = false;
			if (gclass14_1 != null)
				gclass14_1.method_1();
			GClass145.int_4 = -1;
		}
		if (gclass14_0 != null && (GClass39.bool_11[12] || GClass145.smethod_1(gclass14_0)))
		{
			GClass39.bool_11[12] = false;
			GClass39.bool_15 = false;
			GClass145.int_4 = -1;
			GClass39.bool_16 = false;
			if (gclass14_0 != null)
				gclass14_0.method_1();
			GClass145.int_4 = -1;
		}
		if (gclass14_2 != null && (GClass39.bool_11[13] || GClass145.smethod_1(gclass14_2)))
		{
			GClass39.bool_11[13] = false;
			GClass39.bool_15 = false;
			GClass39.bool_16 = false;
			GClass145.int_4 = -1;
			if (gclass14_2 != null)
				gclass14_2.method_1();
			GClass145.int_4 = -1;
		}
		GClass39.smethod_26();
		GClass39.smethod_27();
	}

	public virtual void show()
	{
	}
}
