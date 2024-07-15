public class GClass200 : GInterface1
{
	public GClass118 gclass118_0;

	public GClass118 gclass118_1;

	public string[] string_0;

	private int int_0;

	private int int_1;

	private int int_2 = 120;

	private int int_3;

	private int int_4;

	private long long_0;

	private long long_1;

	public void method_0(string info, GClass118 cmdYes, GClass118 cmdNo)
	{
		string_0 = new string[1] { info };
		int_3 = 29;
		gclass118_0 = cmdYes;
		gclass118_1 = cmdNo;
		gclass118_0.gclass20_0 = (gclass118_1.gclass20_0 = GClass167.gclass20_42);
		gclass118_0.gclass20_1 = (gclass118_1.gclass20_1 = GClass167.gclass20_43);
		gclass118_0.int_3 = GClass193.smethod_0(cmdYes.gclass20_0);
		gclass118_1.int_3 = GClass193.smethod_0(cmdYes.gclass20_0);
		gclass118_0.int_4 = GClass193.smethod_1(cmdYes.gclass20_0);
		gclass118_1.int_4 = GClass193.smethod_1(cmdYes.gclass20_0);
		long_0 = GClass77.smethod_18();
		int_4 = string_0[0].Length / 3;
		if (int_4 < 15)
			int_4 = 15;
		GClass83.smethod_0();
	}

	public void method_1(GClass193 g)
	{
		GClass139.smethod_4(g, int_0, int_1, int_2, int_3 + ((!GClass14.bool_5) ? 10 : 0), 16777215, false);
		if (string_0 == null)
			return;
		GClass83.smethod_1(g, string_0[0], int_0 + 5, int_1 + int_3 / 2 - (GClass14.bool_5 ? 4 : 6), int_2 - 10, int_3, GClass104.gclass104_11);
		if (!GClass14.bool_5)
		{
			if (!GClass136.bool_4)
				GClass104.gclass104_2.method_6(g, mResources.do_accept + int_4 + ")", int_0 + int_2 / 2, int_1 + int_3 - 6, 2);
			else
				GClass104.gclass104_2.method_6(g, mResources.do_accept_qwerty + int_4 + ")", int_0 + int_2 / 2, int_1 + int_3 - 6, 2);
		}
		else
		{
			gclass118_0.method_3(g);
			GClass104.gclass104_15.method_10(g, int_4 + string.Empty, gclass118_0.int_1 + gclass118_0.int_3 / 2, gclass118_0.int_2 + gclass118_0.int_4 + 5, 2, GClass104.gclass104_16);
		}
	}

	public void method_2()
	{
		if (string_0 != null)
		{
			int_0 = GClass14.int_10 - 5 - int_2;
			int_1 = 45;
			if (GClass14.int_10 - 50 > 155 + int_2)
			{
				int_0 = GClass14.int_10 - 55 - int_2;
				int_1 = 5;
			}
			gclass118_0.int_1 = int_0 - 35;
			gclass118_0.int_2 = int_1;
			long_1 = GClass77.smethod_18();
			GClass191.smethod_8("curr - last= " + (long_1 - long_0));
			if (long_1 - long_0 >= 1000L)
			{
				long_0 = GClass77.smethod_18();
				int_4--;
			}
			if (int_4 == 0)
				GClass167.smethod_8().gclass200_0 = null;
		}
	}

	public void perform(int idAction, object p)
	{
	}
}
