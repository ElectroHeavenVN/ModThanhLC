public class GClass169 : GClass160, GInterface1
{
	public static GClass169 gclass169_0;

	public GClass136 gclass136_0;

	public GClass136 gclass136_1;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private string[] string_0;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13 = GClass14.int_13 - GClass160.int_0 - 5;

	private int int_14;

	public GClass169()
	{
		int_8 = GClass14.int_10 - 20;
		if (int_8 > 320)
			int_8 = 320;
		string_0 = GClass104.gclass104_7.method_15(mResources.pay_card, int_8 - 20);
		int_6 = (GClass14.int_10 - int_8) / 2;
		int_7 = GClass14.int_11 - 150 - (string_0.Length - 1) * 20;
		int_9 = 110 + (string_0.Length - 1) * 20;
		int_14 = int_7;
		gclass136_0 = new GClass136();
		gclass136_0.string_7 = mResources.SERI_NUM;
		gclass136_0.int_0 = int_6 + 10;
		gclass136_0.int_1 = int_7 + 35 + (string_0.Length - 1) * 20;
		int_11 = gclass136_0.int_1;
		gclass136_0.int_2 = int_8 - 20;
		gclass136_0.int_3 = GClass160.int_0 + 2;
		if (!GClass14.bool_5)
			gclass136_0.bool_0 = true;
		else
			gclass136_0.bool_0 = false;
		gclass136_0.method_28(GClass136.int_11);
		if (Main.isWindowsPhone)
			gclass136_0.bool_8 = false;
		if (Main.isIPhone)
			gclass136_0.bool_6 = false;
		if (!GClass14.bool_5)
			gclass118_2 = gclass136_0.gclass118_0;
		gclass136_1 = new GClass136();
		gclass136_1.string_7 = mResources.CARD_CODE;
		gclass136_1.int_0 = int_6 + 10;
		gclass136_1.int_1 = gclass136_0.int_1 + 35;
		gclass136_1.int_2 = int_8 - 20;
		gclass136_1.int_3 = GClass160.int_0 + 2;
		gclass136_1.bool_0 = false;
		gclass136_1.method_28(GClass136.int_11);
		if (Main.isWindowsPhone)
			gclass136_1.bool_8 = false;
		if (Main.isIPhone)
			gclass136_1.bool_6 = false;
		gclass118_0 = new GClass118(mResources.CLOSE, this, 1, null);
		gclass118_1 = new GClass118(mResources.pay_card2, this, 2, null);
		if (GClass14.bool_5)
		{
			gclass118_1.int_1 = GClass14.int_10 / 2 + 18;
			gclass118_0.int_1 = GClass14.int_10 / 2 - 85;
			gclass118_1.int_2 = (gclass118_0.int_2 = int_7 + int_9 + 5);
		}
		int_12 = gclass136_0.int_1 - (4 * gclass136_0.int_3 - 10);
		int_14 = gclass136_0.int_1;
	}

	public static GClass169 smethod_2()
	{
		if (gclass169_0 == null)
			gclass169_0 = new GClass169();
		return gclass169_0;
	}

	public override void switchToMe()
	{
		int_10 = 0;
		base.switchToMe();
	}

	public void method_0()
	{
	}

	public override void paint(GClass193 g)
	{
		GClass167.smethod_8().paint(g);
		GClass139.smethod_4(g, int_6, int_7, int_8, int_9, -1, true);
		for (int i = 0; i < string_0.Length; i++)
		{
			GClass104.gclass104_7.method_6(g, string_0[i], GClass14.int_10 / 2, int_7 + 15 + i * 20, GClass104.int_2);
		}
		gclass136_0.method_13(g);
		gclass136_1.method_13(g);
		base.paint(g);
	}

	public override void update()
	{
		GClass167.smethod_8().update();
		gclass136_0.method_17();
		gclass136_1.method_17();
		if (Main.isWindowsPhone)
			method_0();
	}

	public override void keyPress(int keyCode)
	{
		if (!gclass136_0.bool_0)
		{
			if (gclass136_1.bool_0)
				gclass136_1.method_10(keyCode);
		}
		else
			gclass136_0.method_10(keyCode);
		base.keyPress(keyCode);
	}

	public override void updateKey()
	{
		if (!GClass14.bool_11[(!Main.isPC) ? 2 : 21])
		{
			if (GClass14.bool_11[Main.isPC ? 22 : 8])
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
		if (GClass14.bool_11[(!Main.isPC) ? 2 : 21] || GClass14.bool_11[Main.isPC ? 22 : 8])
		{
			GClass14.smethod_26();
			if (int_10 != 1)
			{
				if (int_10 == 0)
				{
					gclass136_0.bool_0 = true;
					gclass136_1.bool_0 = false;
					if (!GClass14.bool_5)
						gclass118_2 = gclass136_0.gclass118_0;
				}
				else
				{
					gclass136_0.bool_0 = false;
					gclass136_1.bool_0 = false;
				}
			}
			else
			{
				gclass136_0.bool_0 = false;
				gclass136_1.bool_0 = true;
				if (!GClass14.bool_5)
					gclass118_2 = gclass136_1.gclass118_0;
			}
		}
		if (GClass14.bool_16)
		{
			if (!GClass14.smethod_24(gclass136_0.int_0, gclass136_0.int_1, gclass136_0.int_2, gclass136_0.int_3))
			{
				if (GClass14.smethod_24(gclass136_1.int_0, gclass136_1.int_1, gclass136_1.int_2, gclass136_1.int_3))
					int_10 = 1;
			}
			else
				int_10 = 0;
		}
		base.updateKey();
		GClass14.smethod_26();
	}

	public void method_1()
	{
		gclass169_0 = null;
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			GClass167.gclass167_0.switchToMe();
			method_1();
		}
		if (idAction != 2)
			return;
		if (gclass136_0.method_21() != null && !gclass136_0.method_21().Equals(string.Empty))
		{
			if (gclass136_1.method_21() != null && !gclass136_1.method_21().Equals(string.Empty))
			{
				GClass2.smethod_0().method_100(gclass136_0.method_21(), gclass136_1.method_21());
				GClass167.gclass167_0.switchToMe();
				method_1();
			}
			else
				GClass14.smethod_30(mResources.card_code_blank);
		}
		else
			GClass14.smethod_30(mResources.serial_blank);
	}
}
