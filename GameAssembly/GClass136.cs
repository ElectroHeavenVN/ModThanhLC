public class GClass136 : GClass131, GInterface6
{
	private int int_6;

	private GClass88 gclass88_0 = new GClass88();

	private GClass87 gclass87_4;

	public const int int_7 = 100;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private GClass87 gclass87_5;

	private GClass87 gclass87_6;

	public GClass136()
	{
		GClass20.int_40 = (byte)(GClass203.smethod_18() % 9L);
		if (GClass20.int_40 == 5 || GClass20.int_40 == 6)
			GClass20.int_40 = 4;
		GClass144.smethod_10(true, -1, -1);
		GClass144.int_22 = 100;
		GClass144.int_23 = 200;
	}

	public override void switchToMe()
	{
		GClass109.smethod_1().method_51();
		base.switchToMe();
		gclass87_5 = new GClass87("VIỆT NAM", this, 98, null);
		gclass87_5.int_1 = 0;
		gclass87_5.int_2 = 0;
		gclass87_6 = new GClass87("GLOBAL", this, 97, null);
		gclass87_6.int_1 = 50;
		gclass87_6.int_2 = 0;
		gclass88_0 = new GClass88();
		gclass88_0.method_0(gclass87_5);
		gclass88_0.method_0(gclass87_6);
		method_0();
	}

	private void method_0()
	{
		int_6 = GClass134.int_14;
		int_10 = 5;
		int_8 = 76;
		int_9 = GClass131.int_3;
		int_11 = 2;
		if (GClass73.int_10 > 3 * (int_8 + int_10))
			int_11 = 3;
		if (gclass88_0.method_2() < 3)
			int_11 = 2;
		int_12 = gclass88_0.method_2() / int_11 + ((gclass88_0.method_2() % int_11 != 0) ? 1 : 0);
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			GClass87 gClass = (GClass87)gclass88_0.method_3(i);
			if (gClass != null)
			{
				int num = GClass73.int_12 - int_11 * (int_8 + int_10) / 2 + i % int_11 * (int_8 + int_10);
				int num2 = GClass73.int_13 - int_12 * (int_9 + int_10) / 2 + i / int_11 * (int_9 + int_10);
				gClass.int_1 = num;
				gClass.int_2 = num2;
			}
		}
	}

	public override void update()
	{
		GClass144.int_22++;
		if (GClass144.int_22 > GClass73.int_10 * 3 + 100)
			GClass144.int_22 = 100;
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			GClass87 gClass = (GClass87)gclass88_0.method_3(i);
			if (GClass73.bool_5)
			{
				if (gClass != null && gClass.method_4())
					gClass.method_1();
			}
			else if (i == int_6)
			{
				if (GClass73.int_8 % 10 < 4)
					gClass.bool_2 = true;
				else
					gClass.bool_2 = false;
				gclass87_4 = new GClass87(mResources.SELECT, this, gClass.int_0, null);
				gclass87_1 = gclass87_4;
			}
			else
			{
				gClass.bool_2 = false;
			}
		}
	}

	public override void paint(GClass122 g)
	{
		GClass73.smethod_18(g);
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			if (gclass88_0.method_3(i) != null)
				((GClass87)gclass88_0.method_3(i)).method_3(g);
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		base.updateKey();
		int num = int_6 % int_11;
		int num2 = int_6 / int_11;
		if (GClass73.bool_11[4])
		{
			if (num > 0)
				int_6--;
			GClass73.bool_11[4] = false;
		}
		else if (!GClass73.bool_11[6])
		{
			if (!GClass73.bool_11[2])
			{
				if (GClass73.bool_11[8])
				{
					if (num2 < int_12 - 1)
						int_6 += int_11;
					GClass73.bool_11[8] = false;
				}
			}
			else
			{
				if (num2 > 0)
					int_6 -= int_11;
				GClass73.bool_11[2] = false;
			}
		}
		else
		{
			if (num < int_11 - 1)
				int_6++;
			GClass73.bool_11[6] = false;
		}
		if (int_6 < 0)
			int_6 = 0;
		if (int_6 >= gclass88_0.method_2())
			int_6 = gclass88_0.method_2() - 1;
		if (GClass73.bool_11[5])
		{
			((GClass87)gclass88_0.method_3(num)).method_1();
			GClass73.bool_11[5] = false;
		}
		GClass73.smethod_26();
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		default:
			GClass14.smethod_0().method_0();
			GClass134.int_14 = idAction - 100;
			GClass50.smethod_8("Default:    ServerListScreen.ipSelect " + GClass134.int_14);
			GClass73.gclass134_0.method_1();
			GClass73.gclass134_0.switchToMe();
			break;
		case 97:
		{
			gclass88_0.method_9();
			for (int j = 0; j < GClass134.string_0.Length; j++)
			{
				if (GClass134.sbyte_1[j] != 0)
					gclass88_0.method_0(new GClass87(GClass134.string_0[j], this, 100 + j, null));
			}
			method_0();
			break;
		}
		case 98:
		{
			gclass88_0.method_9();
			for (int i = 0; i < GClass134.string_0.Length; i++)
			{
				if (GClass134.sbyte_1[i] == 0)
					gclass88_0.method_0(new GClass87(GClass134.string_0[i], this, 100 + i, null));
			}
			method_0();
			break;
		}
		case 99:
			GClass14.smethod_0().method_0();
			GClass134.int_14 = int_6;
			GClass73.gclass134_0.method_1();
			GClass73.gclass134_0.switchToMe();
			break;
		}
	}
}
