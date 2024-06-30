public class GClass147 : GClass145, GInterface0
{
	public static GClass147 gclass147_0;

	public GClass67 gclass67_0;

	public GClass67 gclass67_1;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private string[] string_0;

	private int int_10;

	private int YlmfFaOhBa;

	private int int_11;

	private int int_12 = GClass39.int_13 - GClass145.int_0 - 5;

	private int int_13;

	public GClass147()
	{
		int_8 = GClass39.int_10 - 20;
		if (int_8 > 320)
			int_8 = 320;
		string_0 = GClass49.gclass49_7.method_15(mResources.pay_card, int_8 - 20);
		int_6 = (GClass39.int_10 - int_8) / 2;
		int_7 = GClass39.int_11 - 150 - (string_0.Length - 1) * 20;
		int_9 = 110 + (string_0.Length - 1) * 20;
		int_13 = int_7;
		gclass67_0 = new GClass67();
		gclass67_0.string_7 = mResources.SERI_NUM;
		gclass67_0.int_0 = int_6 + 10;
		gclass67_0.int_1 = int_7 + 35 + (string_0.Length - 1) * 20;
		YlmfFaOhBa = gclass67_0.int_1;
		gclass67_0.int_2 = int_8 - 20;
		gclass67_0.int_3 = GClass145.int_0 + 2;
		if (GClass39.bool_5)
			gclass67_0.bool_0 = false;
		else
			gclass67_0.bool_0 = true;
		gclass67_0.method_28(GClass67.int_11);
		if (Main.isWindowsPhone)
			gclass67_0.bool_8 = false;
		if (Main.isIPhone)
			gclass67_0.bool_6 = false;
		if (!GClass39.bool_5)
			gclass14_2 = gclass67_0.gclass14_0;
		gclass67_1 = new GClass67();
		gclass67_1.string_7 = mResources.CARD_CODE;
		gclass67_1.int_0 = int_6 + 10;
		gclass67_1.int_1 = gclass67_0.int_1 + 35;
		gclass67_1.int_2 = int_8 - 20;
		gclass67_1.int_3 = GClass145.int_0 + 2;
		gclass67_1.bool_0 = false;
		gclass67_1.method_28(GClass67.int_11);
		if (Main.isWindowsPhone)
			gclass67_1.bool_8 = false;
		if (Main.isIPhone)
			gclass67_1.bool_6 = false;
		gclass14_0 = new GClass14(mResources.CLOSE, this, 1, null);
		gclass14_1 = new GClass14(mResources.pay_card2, this, 2, null);
		if (GClass39.bool_5)
		{
			gclass14_1.int_1 = GClass39.int_10 / 2 + 18;
			gclass14_0.int_1 = GClass39.int_10 / 2 - 85;
			gclass14_1.int_2 = (gclass14_0.int_2 = int_7 + int_9 + 5);
		}
		int_11 = gclass67_0.int_1 - (4 * gclass67_0.int_3 - 10);
		int_13 = gclass67_0.int_1;
	}

	public static GClass147 smethod_2()
	{
		if (gclass147_0 == null)
			gclass147_0 = new GClass147();
		return gclass147_0;
	}

	public override void switchToMe()
	{
		int_10 = 0;
		base.switchToMe();
	}

	public void method_0()
	{
	}

	public override void paint(GClass76 g)
	{
		GClass154.smethod_8().paint(g);
		GClass24.smethod_4(g, int_6, int_7, int_8, int_9, -1, true);
		for (int i = 0; i < string_0.Length; i++)
		{
			GClass49.gclass49_7.method_6(g, string_0[i], GClass39.int_10 / 2, int_7 + 15 + i * 20, GClass49.int_2);
		}
		gclass67_0.method_13(g);
		gclass67_1.method_13(g);
		base.paint(g);
	}

	public override void update()
	{
		GClass154.smethod_8().update();
		gclass67_0.method_17();
		gclass67_1.method_17();
		if (Main.isWindowsPhone)
			method_0();
	}

	public override void keyPress(int keyCode)
	{
		if (gclass67_0.bool_0)
			gclass67_0.method_10(keyCode);
		else if (gclass67_1.bool_0)
		{
			gclass67_1.method_10(keyCode);
		}
		base.keyPress(keyCode);
	}

	public override void updateKey()
	{
		if (GClass39.bool_11[(!Main.isPC) ? 2 : 21])
		{
			int_10--;
			if (int_10 < 0)
				int_10 = 1;
		}
		else if (GClass39.bool_11[(!Main.isPC) ? 8 : 22])
		{
			int_10++;
			if (int_10 > 1)
				int_10 = 1;
		}
		if (GClass39.bool_11[(!Main.isPC) ? 2 : 21] || GClass39.bool_11[(!Main.isPC) ? 8 : 22])
		{
			GClass39.smethod_26();
			if (int_10 == 1)
			{
				gclass67_0.bool_0 = false;
				gclass67_1.bool_0 = true;
				if (!GClass39.bool_5)
					gclass14_2 = gclass67_1.gclass14_0;
			}
			else if (int_10 == 0)
			{
				gclass67_0.bool_0 = true;
				gclass67_1.bool_0 = false;
				if (!GClass39.bool_5)
					gclass14_2 = gclass67_0.gclass14_0;
			}
			else
			{
				gclass67_0.bool_0 = false;
				gclass67_1.bool_0 = false;
			}
		}
		if (GClass39.bool_16)
		{
			if (GClass39.smethod_24(gclass67_0.int_0, gclass67_0.int_1, gclass67_0.int_2, gclass67_0.int_3))
				int_10 = 0;
			else if (GClass39.smethod_24(gclass67_1.int_0, gclass67_1.int_1, gclass67_1.int_2, gclass67_1.int_3))
			{
				int_10 = 1;
			}
		}
		base.updateKey();
		GClass39.smethod_26();
	}

	public void method_1()
	{
		gclass147_0 = null;
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			GClass154.gclass154_0.switchToMe();
			method_1();
		}
		if (idAction == 2)
		{
			if (gclass67_0.method_21() == null || gclass67_0.method_21().Equals(string.Empty))
			{
				GClass39.smethod_30(mResources.serial_blank);
				return;
			}
			if (gclass67_1.method_21() == null || gclass67_1.method_21().Equals(string.Empty))
			{
				GClass39.smethod_30(mResources.card_code_blank);
				return;
			}
			GClass166.smethod_0().method_100(gclass67_0.method_21(), gclass67_1.method_21());
			GClass154.gclass154_0.switchToMe();
			method_1();
		}
	}
}
