public abstract class GClass183
{
	public GClass118 gclass118_0;

	public GClass118 gclass118_1;

	public GClass118 gclass118_2;

	private int int_0;

	public virtual void paint(GClass193 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass14.int_10, GClass14.int_11);
		GClass14.gclass97_0.method_8(g);
		GClass14.gclass97_0.method_7(g, gclass118_0, gclass118_1, gclass118_2);
	}

	public virtual void keyPress(int keyCode)
	{
		if (keyCode > -22)
		{
			if (keyCode != -21)
			{
				switch (keyCode)
				{
				default:
					if (keyCode != 10)
						return;
					goto case -5;
				case -5:
					GClass14.bool_13[Main.isPC ? 25 : 5] = true;
					GClass14.bool_11[(!Main.isPC) ? 5 : 25] = true;
					return;
				case -6:
					break;
				case -7:
					goto IL_0097;
				case -1:
					goto IL_00ab;
				case -2:
					goto IL_00d3;
				case -4:
				case -3:
					return;
				}
			}
			GClass14.bool_13[12] = true;
			GClass14.bool_11[12] = true;
			return;
		}
		if (keyCode != -39)
		{
			if (keyCode != -38)
			{
				if (keyCode != -22)
					return;
				goto IL_0097;
			}
			goto IL_00ab;
		}
		goto IL_00d3;
		IL_0097:
		GClass14.bool_13[13] = true;
		GClass14.bool_11[13] = true;
		return;
		IL_00d3:
		GClass14.bool_13[Main.isPC ? 22 : 8] = true;
		GClass14.bool_11[Main.isPC ? 22 : 8] = true;
		return;
		IL_00ab:
		GClass14.bool_13[(!Main.isPC) ? 2 : 21] = true;
		GClass14.bool_11[(!Main.isPC) ? 2 : 21] = true;
	}

	public virtual void update()
	{
		if (gclass118_1 != null && (GClass14.bool_11[Main.isPC ? 25 : 5] || GClass160.smethod_1(gclass118_1)))
		{
			GClass14.bool_11[Main.isPC ? 25 : 5] = false;
			GClass14.bool_15 = false;
			GClass160.int_4 = -1;
			GClass14.bool_16 = false;
			if (gclass118_1 != null)
				gclass118_1.method_1();
			GClass160.int_4 = -1;
		}
		if (gclass118_0 != null && (GClass14.bool_11[12] || GClass160.smethod_1(gclass118_0)))
		{
			GClass14.bool_11[12] = false;
			GClass14.bool_15 = false;
			GClass160.int_4 = -1;
			GClass14.bool_16 = false;
			if (gclass118_0 != null)
				gclass118_0.method_1();
			GClass160.int_4 = -1;
		}
		if (gclass118_2 != null && (GClass14.bool_11[13] || GClass160.smethod_1(gclass118_2)))
		{
			GClass14.bool_11[13] = false;
			GClass14.bool_15 = false;
			GClass14.bool_16 = false;
			GClass160.int_4 = -1;
			if (gclass118_2 != null)
				gclass118_2.method_1();
			GClass160.int_4 = -1;
		}
		GClass14.smethod_26();
		GClass14.smethod_27();
	}

	public virtual void show()
	{
	}
}
