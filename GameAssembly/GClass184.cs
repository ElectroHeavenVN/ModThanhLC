public class GClass184 : GClass183
{
	protected string[] string_0;

	public GClass136 gclass136_0;

	private int int_1;

	public GClass184()
	{
		int_1 = 40;
		if (GClass14.int_10 <= 176)
			int_1 = 10;
		gclass136_0 = new GClass136();
		gclass136_0.int_0 = int_1 + 10;
		gclass136_0.int_1 = GClass14.int_11 - GClass160.int_0 - 43;
		gclass136_0.int_2 = GClass14.int_10 - 2 * (int_1 + 10);
		gclass136_0.int_3 = GClass160.int_0 + 2;
		gclass136_0.bool_0 = true;
		gclass118_2 = gclass136_0.gclass118_0;
	}

	public void method_0(string info, GClass118 ok, int type)
	{
		gclass136_0.method_23(string.Empty);
		gclass136_0.method_28(type);
		string_0 = GClass104.gclass104_21.method_15(info, GClass14.int_10 - int_1 * 2);
		gclass118_0 = new GClass118(mResources.CLOSE, GClass14.smethod_1(), 8882, null);
		gclass118_1 = ok;
		show();
	}

	public override void paint(GClass193 g)
	{
		GClass14.gclass97_0.method_19(g, int_1, GClass14.int_11 - 77 - GClass160.int_3, GClass14.int_10 - int_1 * 2, 69, string_0);
		gclass136_0.method_13(g);
		base.paint(g);
	}

	public override void keyPress(int keyCode)
	{
		gclass136_0.method_10(keyCode);
		base.keyPress(keyCode);
	}

	public override void update()
	{
		gclass136_0.method_17();
		base.update();
	}

	public override void show()
	{
		GClass14.gclass183_0 = this;
	}

	public void method_1()
	{
		GClass14.smethod_29();
	}
}
