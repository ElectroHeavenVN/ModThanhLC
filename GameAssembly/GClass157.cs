public class GClass157 : GClass145, GInterface0
{
	private int int_6;

	private GClass63 gclass63_0 = new GClass63();

	private GClass14 qLbtoCupBi;

	public const int int_7 = 100;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private GClass14 gclass14_4;

	private GClass14 gclass14_5;

	public GClass157()
	{
		GClass1.int_40 = (byte)(GClass138.smethod_18() % 9L);
		if (GClass1.int_40 == 5 || GClass1.int_40 == 6)
			GClass1.int_40 = 4;
		GClass154.smethod_10(true, -1, -1);
		GClass154.int_22 = 100;
		GClass154.int_23 = 200;
	}

	public override void switchToMe()
	{
		GClass29.smethod_1().method_51();
		base.switchToMe();
		gclass14_4 = new GClass14("VIỆT NAM", this, 98, null);
		gclass14_4.int_1 = 0;
		gclass14_4.int_2 = 0;
		gclass14_5 = new GClass14("GLOBAL", this, 97, null);
		gclass14_5.int_1 = 50;
		gclass14_5.int_2 = 0;
		gclass63_0 = new GClass63();
		gclass63_0.method_0(gclass14_4);
		gclass63_0.method_0(gclass14_5);
		tWbtttjeOb();
	}

	private void tWbtttjeOb()
	{
		int_6 = GClass152.int_14;
		int_10 = 5;
		int_8 = 76;
		int_9 = GClass145.int_3;
		int_11 = 2;
		if (GClass39.int_10 > 3 * (int_8 + int_10))
			int_11 = 3;
		if (gclass63_0.method_2() < 3)
			int_11 = 2;
		int_12 = gclass63_0.method_2() / int_11 + ((gclass63_0.method_2() % int_11 != 0) ? 1 : 0);
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass14 gClass = (GClass14)gclass63_0.method_3(i);
			if (gClass != null)
			{
				int num = GClass39.int_12 - int_11 * (int_8 + int_10) / 2 + i % int_11 * (int_8 + int_10);
				int num2 = GClass39.int_13 - int_12 * (int_9 + int_10) / 2 + i / int_11 * (int_9 + int_10);
				gClass.int_1 = num;
				gClass.int_2 = num2;
			}
		}
	}

	public override void update()
	{
		GClass154.int_22++;
		if (GClass154.int_22 > GClass39.int_10 * 3 + 100)
			GClass154.int_22 = 100;
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass14 gClass = (GClass14)gclass63_0.method_3(i);
			if (!GClass39.bool_5)
			{
				if (i == int_6)
				{
					if (GClass39.int_8 % 10 < 4)
						gClass.bool_2 = true;
					else
						gClass.bool_2 = false;
					qLbtoCupBi = new GClass14(mResources.SELECT, this, gClass.int_0, null);
					gclass14_1 = qLbtoCupBi;
				}
				else
					gClass.bool_2 = false;
			}
			else if (gClass != null && gClass.method_4())
			{
				gClass.method_1();
			}
		}
	}

	public override void paint(GClass76 g)
	{
		GClass39.smethod_18(g);
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			if (gclass63_0.method_3(i) != null)
				((GClass14)gclass63_0.method_3(i)).method_3(g);
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		base.updateKey();
		int num = int_6 % int_11;
		int num2 = int_6 / int_11;
		if (GClass39.bool_11[4])
		{
			if (num > 0)
				int_6--;
			GClass39.bool_11[4] = false;
		}
		else if (GClass39.bool_11[6])
		{
			if (num < int_11 - 1)
				int_6++;
			GClass39.bool_11[6] = false;
		}
		else if (GClass39.bool_11[2])
		{
			if (num2 > 0)
				int_6 -= int_11;
			GClass39.bool_11[2] = false;
		}
		else if (GClass39.bool_11[8])
		{
			if (num2 < int_12 - 1)
				int_6 += int_11;
			GClass39.bool_11[8] = false;
		}
		if (int_6 < 0)
			int_6 = 0;
		if (int_6 >= gclass63_0.method_2())
			int_6 = gclass63_0.method_2() - 1;
		if (GClass39.bool_11[5])
		{
			((GClass14)gclass63_0.method_3(num)).method_1();
			GClass39.bool_11[5] = false;
		}
		GClass39.smethod_26();
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		default:
			GClass162.smethod_0().method_0();
			GClass152.int_14 = idAction - 100;
			GClass56.smethod_8("Default:    ServerListScreen.ipSelect " + GClass152.int_14);
			GClass39.gclass152_0.method_1();
			GClass39.gclass152_0.switchToMe();
			break;
		case 97:
		{
			gclass63_0.method_9();
			for (int j = 0; j < GClass152.string_0.Length; j++)
			{
				if (GClass152.sbyte_1[j] != 0)
					gclass63_0.method_0(new GClass14(GClass152.string_0[j], this, 100 + j, null));
			}
			tWbtttjeOb();
			break;
		}
		case 98:
		{
			gclass63_0.method_9();
			for (int i = 0; i < GClass152.string_0.Length; i++)
			{
				if (GClass152.sbyte_1[i] == 0)
					gclass63_0.method_0(new GClass14(GClass152.string_0[i], this, 100 + i, null));
			}
			tWbtttjeOb();
			break;
		}
		case 99:
			GClass162.smethod_0().method_0();
			GClass152.int_14 = int_6;
			GClass39.gclass152_0.method_1();
			GClass39.gclass152_0.switchToMe();
			break;
		}
	}
}
