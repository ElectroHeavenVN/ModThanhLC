public class GClass43 : GClass42
{
	protected string[] string_0;

	public GClass191 gclass191_0;

	private int int_1;

	public GClass43()
	{
		int_1 = 40;
		if (GClass73.int_10 <= 176)
			int_1 = 10;
		gclass191_0 = new GClass191();
		gclass191_0.int_0 = int_1 + 10;
		gclass191_0.int_1 = GClass73.int_11 - GClass131.int_0 - 43;
		gclass191_0.int_2 = GClass73.int_10 - 2 * (int_1 + 10);
		gclass191_0.int_3 = GClass131.int_0 + 2;
		gclass191_0.bool_0 = true;
		gclass87_2 = gclass191_0.gclass87_0;
	}

	public void method_0(string info, GClass87 ok, int type)
	{
		gclass191_0.method_23("");
		gclass191_0.method_28(type);
		string_0 = GClass4.gclass4_21.method_15(info, GClass73.int_10 - int_1 * 2);
		gclass87_0 = new GClass87(mResources.CLOSE, GClass73.smethod_1(), 8882, null);
		gclass87_1 = ok;
		show();
	}

	public override void paint(GClass122 g)
	{
		GClass73.gclass192_0.method_19(g, int_1, GClass73.int_11 - 77 - GClass131.int_3, GClass73.int_10 - int_1 * 2, 69, string_0);
		gclass191_0.method_13(g);
		base.paint(g);
	}

	public override void keyPress(int keyCode)
	{
		gclass191_0.method_10(keyCode);
		base.keyPress(keyCode);
	}

	public override void update()
	{
		gclass191_0.method_17();
		base.update();
	}

	public override void show()
	{
		GClass73.gclass42_0 = this;
	}

	public void method_1()
	{
		GClass73.smethod_29();
	}
}
