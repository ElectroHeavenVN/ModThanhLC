public class GClass168 : GClass160, GInterface1
{
	private int int_6;

	private GClass122 gclass122_0 = new GClass122();

	private GClass118 gclass118_4;

	public const int int_7 = 100;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private GClass118 gclass118_5;

	private GClass118 gclass118_6;

	public GClass168()
	{
		GClass137.int_40 = (byte)(GClass77.smethod_18() % 9L);
		if (GClass137.int_40 == 5 || GClass137.int_40 == 6)
			GClass137.int_40 = 4;
		GClass167.smethod_10(true, -1, -1);
		GClass167.int_22 = 100;
		GClass167.int_23 = 200;
	}

	public override void switchToMe()
	{
		GClass147.smethod_1().method_51();
		base.switchToMe();
		gclass118_5 = new GClass118("VIỆT NAM", this, 98, null);
		gclass118_5.int_1 = 0;
		gclass118_5.int_2 = 0;
		gclass118_6 = new GClass118("GLOBAL", this, 97, null);
		gclass118_6.int_1 = 50;
		gclass118_6.int_2 = 0;
		gclass122_0 = new GClass122();
		gclass122_0.method_0(gclass118_5);
		gclass122_0.method_0(gclass118_6);
		method_0();
	}

	private void method_0()
	{
		int_6 = GClass170.int_14;
		int_10 = 5;
		int_8 = 76;
		int_9 = GClass160.int_3;
		int_11 = 2;
		if (GClass14.int_10 > 3 * (int_8 + int_10))
			int_11 = 3;
		if (gclass122_0.method_2() < 3)
			int_11 = 2;
		int_12 = gclass122_0.method_2() / int_11 + ((gclass122_0.method_2() % int_11 != 0) ? 1 : 0);
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			GClass118 gClass = (GClass118)gclass122_0.method_3(i);
			if (gClass != null)
			{
				int num = GClass14.int_12 - int_11 * (int_8 + int_10) / 2 + i % int_11 * (int_8 + int_10);
				int num2 = GClass14.int_13 - int_12 * (int_9 + int_10) / 2 + i / int_11 * (int_9 + int_10);
				gClass.int_1 = num;
				gClass.int_2 = num2;
			}
		}
	}

	public override void update()
	{
		GClass167.int_22++;
		if (GClass167.int_22 > GClass14.int_10 * 3 + 100)
			GClass167.int_22 = 100;
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			GClass118 gClass = (GClass118)gclass122_0.method_3(i);
			if (GClass14.bool_5)
			{
				if (gClass != null && gClass.method_4())
					gClass.method_1();
			}
			else if (i == int_6)
			{
				if (GClass14.int_8 % 10 < 4)
					gClass.bool_2 = true;
				else
					gClass.bool_2 = false;
				gclass118_4 = new GClass118(mResources.SELECT, this, gClass.int_0, null);
				gclass118_1 = gclass118_4;
			}
			else
			{
				gClass.bool_2 = false;
			}
		}
	}

	public override void paint(GClass193 g)
	{
		GClass14.smethod_18(g);
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			if (gclass122_0.method_3(i) != null)
				((GClass118)gclass122_0.method_3(i)).method_3(g);
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		base.updateKey();
		int num = int_6 % int_11;
		int num2 = int_6 / int_11;
		if (GClass14.bool_11[4])
		{
			if (num > 0)
				int_6--;
			GClass14.bool_11[4] = false;
		}
		else if (!GClass14.bool_11[6])
		{
			if (GClass14.bool_11[2])
			{
				if (num2 > 0)
					int_6 -= int_11;
				GClass14.bool_11[2] = false;
			}
			else if (GClass14.bool_11[8])
			{
				if (num2 < int_12 - 1)
					int_6 += int_11;
				GClass14.bool_11[8] = false;
			}
		}
		else
		{
			if (num < int_11 - 1)
				int_6++;
			GClass14.bool_11[6] = false;
		}
		if (int_6 < 0)
			int_6 = 0;
		if (int_6 >= gclass122_0.method_2())
			int_6 = gclass122_0.method_2() - 1;
		if (GClass14.bool_11[5])
		{
			((GClass118)gclass122_0.method_3(num)).method_1();
			GClass14.bool_11[5] = false;
		}
		GClass14.smethod_26();
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		default:
			GClass179.smethod_0().method_0();
			GClass170.int_14 = idAction - 100;
			GClass191.smethod_8("Default:    ServerListScreen.ipSelect " + GClass170.int_14);
			GClass14.gclass170_0.method_1();
			GClass14.gclass170_0.switchToMe();
			break;
		case 97:
		{
			gclass122_0.method_9();
			for (int j = 0; j < GClass170.string_0.Length; j++)
			{
				if (GClass170.sbyte_1[j] != 0)
					gclass122_0.method_0(new GClass118(GClass170.string_0[j], this, 100 + j, null));
			}
			method_0();
			break;
		}
		case 98:
		{
			gclass122_0.method_9();
			for (int i = 0; i < GClass170.string_0.Length; i++)
			{
				if (GClass170.sbyte_1[i] == 0)
					gclass122_0.method_0(new GClass118(GClass170.string_0[i], this, 100 + i, null));
			}
			method_0();
			break;
		}
		case 99:
			GClass179.smethod_0().method_0();
			GClass170.int_14 = int_6;
			GClass14.gclass170_0.method_1();
			GClass14.gclass170_0.switchToMe();
			break;
		}
	}
}
