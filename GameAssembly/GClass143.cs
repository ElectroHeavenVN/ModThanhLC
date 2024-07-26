public class GClass143 : GClass131, GInterface6
{
	public static GClass143 gclass143_0;

	public GClass191 gclass191_0;

	public GClass191 gclass191_1;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private string[] string_0;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13 = GClass73.int_13 - GClass131.int_0 - 5;

	private int int_14;

	public GClass143()
	{
		int_8 = GClass73.int_10 - 20;
		if (int_8 > 320)
			int_8 = 320;
		string_0 = GClass4.gclass4_7.method_15(mResources.pay_card, int_8 - 20);
		int_6 = (GClass73.int_10 - int_8) / 2;
		int_7 = GClass73.int_11 - 150 - (string_0.Length - 1) * 20;
		int_9 = 110 + (string_0.Length - 1) * 20;
		int_14 = int_7;
		gclass191_0 = new GClass191();
		gclass191_0.string_7 = mResources.SERI_NUM;
		gclass191_0.int_0 = int_6 + 10;
		gclass191_0.int_1 = int_7 + 35 + (string_0.Length - 1) * 20;
		int_11 = gclass191_0.int_1;
		gclass191_0.int_2 = int_8 - 20;
		gclass191_0.int_3 = GClass131.int_0 + 2;
		if (GClass73.bool_5)
			gclass191_0.bool_0 = false;
		else
			gclass191_0.bool_0 = true;
		gclass191_0.method_28(GClass191.int_11);
		if (Main.isWindowsPhone)
			gclass191_0.bool_8 = false;
		if (Main.isIPhone)
			gclass191_0.bool_6 = false;
		if (!GClass73.bool_5)
			gclass87_2 = gclass191_0.gclass87_0;
		gclass191_1 = new GClass191();
		gclass191_1.string_7 = mResources.CARD_CODE;
		gclass191_1.int_0 = int_6 + 10;
		gclass191_1.int_1 = gclass191_0.int_1 + 35;
		gclass191_1.int_2 = int_8 - 20;
		gclass191_1.int_3 = GClass131.int_0 + 2;
		gclass191_1.bool_0 = false;
		gclass191_1.method_28(GClass191.int_11);
		if (Main.isWindowsPhone)
			gclass191_1.bool_8 = false;
		if (Main.isIPhone)
			gclass191_1.bool_6 = false;
		gclass87_0 = new GClass87(mResources.CLOSE, this, 1, null);
		gclass87_1 = new GClass87(mResources.pay_card2, this, 2, null);
		if (GClass73.bool_5)
		{
			gclass87_1.int_1 = GClass73.int_10 / 2 + 18;
			gclass87_0.int_1 = GClass73.int_10 / 2 - 85;
			gclass87_1.int_2 = (gclass87_0.int_2 = int_7 + int_9 + 5);
		}
		int_12 = gclass191_0.int_1 - (4 * gclass191_0.int_3 - 10);
		int_14 = gclass191_0.int_1;
	}

	public static GClass143 smethod_2()
	{
		if (gclass143_0 == null)
			gclass143_0 = new GClass143();
		return gclass143_0;
	}

	public override void switchToMe()
	{
		int_10 = 0;
		base.switchToMe();
	}

	public void method_0()
	{
	}

	public override void paint(GClass122 g)
	{
		GClass144.smethod_8().paint(g);
		GClass45.smethod_4(g, int_6, int_7, int_8, int_9, -1, true);
		for (int i = 0; i < string_0.Length; i++)
		{
			GClass4.gclass4_7.method_6(g, string_0[i], GClass73.int_10 / 2, int_7 + 15 + i * 20, GClass4.int_2);
		}
		gclass191_0.method_13(g);
		gclass191_1.method_13(g);
		base.paint(g);
	}

	public override void update()
	{
		GClass144.smethod_8().update();
		gclass191_0.method_17();
		gclass191_1.method_17();
		if (Main.isWindowsPhone)
			method_0();
	}

	public override void keyPress(int keyCode)
	{
		if (!gclass191_0.bool_0)
		{
			if (gclass191_1.bool_0)
				gclass191_1.method_10(keyCode);
		}
		else
			gclass191_0.method_10(keyCode);
		base.keyPress(keyCode);
	}

	public override void updateKey()
	{
		if (!GClass73.bool_11[(!Main.isPC) ? 2 : 21])
		{
			if (GClass73.bool_11[Main.isPC ? 22 : 8])
			{
				int_10++;
				if (int_10 > 1)
					int_10 = 1;
			}
		}
		else
		{
			int_10--;
			if (int_10 < 0)
				int_10 = 1;
		}
		if (GClass73.bool_11[Main.isPC ? 21 : 2] || GClass73.bool_11[(!Main.isPC) ? 8 : 22])
		{
			GClass73.smethod_26();
			if (int_10 != 1)
			{
				if (int_10 != 0)
				{
					gclass191_0.bool_0 = false;
					gclass191_1.bool_0 = false;
				}
				else
				{
					gclass191_0.bool_0 = true;
					gclass191_1.bool_0 = false;
					if (!GClass73.bool_5)
						gclass87_2 = gclass191_0.gclass87_0;
				}
			}
			else
			{
				gclass191_0.bool_0 = false;
				gclass191_1.bool_0 = true;
				if (!GClass73.bool_5)
					gclass87_2 = gclass191_1.gclass87_0;
			}
		}
		if (GClass73.bool_16)
		{
			if (!GClass73.smethod_24(gclass191_0.int_0, gclass191_0.int_1, gclass191_0.int_2, gclass191_0.int_3))
			{
				if (GClass73.smethod_24(gclass191_1.int_0, gclass191_1.int_1, gclass191_1.int_2, gclass191_1.int_3))
					int_10 = 1;
			}
			else
				int_10 = 0;
		}
		base.updateKey();
		GClass73.smethod_26();
	}

	public void method_1()
	{
		gclass143_0 = null;
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			GClass144.gclass144_0.switchToMe();
			method_1();
		}
		if (idAction != 2)
			return;
		if (gclass191_0.method_21() != null && !gclass191_0.method_21().Equals(""))
		{
			if (gclass191_1.method_21() == null || gclass191_1.method_21().Equals(""))
			{
				GClass73.smethod_30(mResources.card_code_blank);
				return;
			}
			GClass7.smethod_0().method_100(gclass191_0.method_21(), gclass191_1.method_21());
			GClass144.gclass144_0.switchToMe();
			method_1();
		}
		else
			GClass73.smethod_30(mResources.serial_blank);
	}
}
