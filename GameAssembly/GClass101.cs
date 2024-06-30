public class GClass101 : GClass99
{
	protected string[] string_0;

	public GClass67 gclass67_0;

	private int int_1;

	public GClass101()
	{
		int_1 = 40;
		if (GClass39.int_10 <= 176)
			int_1 = 10;
		gclass67_0 = new GClass67();
		gclass67_0.int_0 = int_1 + 10;
		gclass67_0.int_1 = GClass39.int_11 - GClass145.int_0 - 43;
		gclass67_0.int_2 = GClass39.int_10 - 2 * (int_1 + 10);
		gclass67_0.int_3 = GClass145.int_0 + 2;
		gclass67_0.bool_0 = true;
		gclass14_2 = gclass67_0.gclass14_0;
	}

	public void method_0(string info, GClass14 ok, int type)
	{
		gclass67_0.method_23(string.Empty);
		gclass67_0.method_28(type);
		string_0 = GClass49.gclass49_21.method_15(info, GClass39.int_10 - int_1 * 2);
		gclass14_0 = new GClass14(mResources.CLOSE, GClass39.smethod_1(), 8882, null);
		gclass14_1 = ok;
		show();
	}

	public override void paint(GClass76 g)
	{
		GClass39.gclass37_0.method_19(g, int_1, GClass39.int_11 - 77 - GClass145.int_3, GClass39.int_10 - int_1 * 2, 69, string_0);
		gclass67_0.method_13(g);
		base.paint(g);
	}

	public override void keyPress(int keyCode)
	{
		gclass67_0.method_10(keyCode);
		base.keyPress(keyCode);
	}

	public override void update()
	{
		gclass67_0.method_17();
		base.update();
	}

	public override void show()
	{
		GClass39.gclass99_0 = this;
	}

	public void method_1()
	{
		GClass39.smethod_29();
	}
}
