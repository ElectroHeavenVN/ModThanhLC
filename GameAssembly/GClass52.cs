public class GClass52 : GInterface0
{
	public GClass14 gclass14_0;

	public GClass14 gclass14_1;

	public string[] string_0;

	private int int_0;

	private int int_1;

	private int int_2 = 120;

	private int evtZbyPgRD;

	private int int_3;

	private long long_0;

	private long long_1;

	public void method_0(string info, GClass14 cmdYes, GClass14 cmdNo)
	{
		string_0 = new string[1] { info };
		evtZbyPgRD = 29;
		gclass14_0 = cmdYes;
		gclass14_1 = cmdNo;
		gclass14_0.gclass2_0 = (gclass14_1.gclass2_0 = GClass154.gclass2_42);
		gclass14_0.gclass2_1 = (gclass14_1.gclass2_1 = GClass154.gclass2_43);
		gclass14_0.int_3 = GClass76.smethod_0(cmdYes.gclass2_0);
		gclass14_1.int_3 = GClass76.smethod_0(cmdYes.gclass2_0);
		gclass14_0.int_4 = GClass76.smethod_1(cmdYes.gclass2_0);
		gclass14_1.int_4 = GClass76.smethod_1(cmdYes.gclass2_0);
		long_0 = GClass138.smethod_18();
		int_3 = string_0[0].Length / 3;
		if (int_3 < 15)
			int_3 = 15;
		GClass164.smethod_0();
	}

	public void method_1(GClass76 g)
	{
		GClass24.smethod_4(g, int_0, int_1, int_2, evtZbyPgRD + ((!GClass39.bool_5) ? 10 : 0), 16777215, false);
		if (string_0 != null)
		{
			GClass164.smethod_1(g, string_0[0], int_0 + 5, int_1 + evtZbyPgRD / 2 - ((!GClass39.bool_5) ? 6 : 4), int_2 - 10, evtZbyPgRD, GClass49.gclass49_11);
			if (GClass39.bool_5)
			{
				gclass14_0.method_3(g);
				GClass49.gclass49_15.method_10(g, int_3 + string.Empty, gclass14_0.int_1 + gclass14_0.int_3 / 2, gclass14_0.int_2 + gclass14_0.int_4 + 5, 2, GClass49.gclass49_16);
			}
			else if (GClass67.bool_4)
			{
				GClass49.gclass49_2.method_6(g, mResources.do_accept_qwerty + int_3 + ")", int_0 + int_2 / 2, int_1 + evtZbyPgRD - 6, 2);
			}
			else
			{
				GClass49.gclass49_2.method_6(g, mResources.do_accept + int_3 + ")", int_0 + int_2 / 2, int_1 + evtZbyPgRD - 6, 2);
			}
		}
	}

	public void method_2()
	{
		if (string_0 != null)
		{
			int_0 = GClass39.int_10 - 5 - int_2;
			int_1 = 45;
			if (GClass39.int_10 - 50 > 155 + int_2)
			{
				int_0 = GClass39.int_10 - 55 - int_2;
				int_1 = 5;
			}
			gclass14_0.int_1 = int_0 - 35;
			gclass14_0.int_2 = int_1;
			long_1 = GClass138.smethod_18();
			GClass56.smethod_8("curr - last= " + (long_1 - long_0));
			if (long_1 - long_0 >= 1000L)
			{
				long_0 = GClass138.smethod_18();
				int_3--;
			}
			if (int_3 == 0)
				GClass154.smethod_8().gclass52_0 = null;
		}
	}

	public void perform(int idAction, object p)
	{
	}
}
