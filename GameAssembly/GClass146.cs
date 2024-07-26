public class GClass146 : GInterface6
{
	public GClass87 gclass87_0;

	public GClass87 gclass87_1;

	public string[] string_0;

	private int int_0;

	private int int_1;

	private int int_2 = 120;

	private int int_3;

	private int int_4;

	private long long_0;

	private long long_1;

	public void method_0(string info, GClass87 cmdYes, GClass87 cmdNo)
	{
		string_0 = new string[1] { info };
		int_3 = 29;
		gclass87_0 = cmdYes;
		gclass87_1 = cmdNo;
		gclass87_0.gclass70_0 = (gclass87_1.gclass70_0 = GClass144.gclass70_42);
		gclass87_0.gclass70_1 = (gclass87_1.gclass70_1 = GClass144.gclass70_43);
		gclass87_0.int_3 = GClass122.smethod_0(cmdYes.gclass70_0);
		gclass87_1.int_3 = GClass122.smethod_0(cmdYes.gclass70_0);
		gclass87_0.int_4 = GClass122.smethod_1(cmdYes.gclass70_0);
		gclass87_1.int_4 = GClass122.smethod_1(cmdYes.gclass70_0);
		long_0 = GClass203.smethod_18();
		int_4 = string_0[0].Length / 3;
		if (int_4 < 15)
			int_4 = 15;
		GClass123.smethod_0();
	}

	public void method_1(GClass122 g)
	{
		GClass45.smethod_4(g, int_0, int_1, int_2, int_3 + ((!GClass73.bool_5) ? 10 : 0), 16777215, false);
		if (string_0 != null)
		{
			GClass123.smethod_1(g, string_0[0], int_0 + 5, int_1 + int_3 / 2 - ((!GClass73.bool_5) ? 6 : 4), int_2 - 10, int_3, GClass4.gclass4_11);
			if (GClass73.bool_5)
			{
				gclass87_0.method_3(g);
				GClass4.gclass4_15.method_10(g, int_4 + "", gclass87_0.int_1 + gclass87_0.int_3 / 2, gclass87_0.int_2 + gclass87_0.int_4 + 5, 2, GClass4.gclass4_16);
			}
			else if (!GClass191.bool_4)
			{
				GClass4.gclass4_2.method_6(g, mResources.do_accept + int_4 + ")", int_0 + int_2 / 2, int_1 + int_3 - 6, 2);
			}
			else
			{
				GClass4.gclass4_2.method_6(g, mResources.do_accept_qwerty + int_4 + ")", int_0 + int_2 / 2, int_1 + int_3 - 6, 2);
			}
		}
	}

	public void method_2()
	{
		if (string_0 != null)
		{
			int_0 = GClass73.int_10 - 5 - int_2;
			int_1 = 45;
			if (GClass73.int_10 - 50 > 155 + int_2)
			{
				int_0 = GClass73.int_10 - 55 - int_2;
				int_1 = 5;
			}
			gclass87_0.int_1 = int_0 - 35;
			gclass87_0.int_2 = int_1;
			long_1 = GClass203.smethod_18();
			GClass50.smethod_8("curr - last= " + (long_1 - long_0));
			if (long_1 - long_0 >= 1000L)
			{
				long_0 = GClass203.smethod_18();
				int_4--;
			}
			if (int_4 == 0)
				GClass144.smethod_8().gclass146_0 = null;
		}
	}

	public void perform(int idAction, object p)
	{
	}
}
