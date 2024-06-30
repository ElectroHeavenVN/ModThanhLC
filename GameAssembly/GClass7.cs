using ns1;

public class GClass7 : GInterface0
{
	private static GClass7 gclass7_0;

	public GClass67 gclass67_0;

	public bool bool_0;

	public GInterface5 ginterface5_0;

	private long long_0;

	public GClass14 gclass14_0;

	public GClass14 gclass14_1;

	public GClass14 gclass14_2;

	public GClass14 gclass14_3;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private bool bool_1;

	public GClass14 gclass14_4;

	public int int_4;

	public int int_5;

	public int int_6;

	public string string_0;

	public string string_1 = "Chat ";

	public GClass7()
	{
		gclass67_0 = new GClass67();
		if (Main.isWindowsPhone)
			gclass67_0.bool_8 = false;
		if (Main.isIPhone)
			gclass67_0.bool_6 = false;
		gclass67_0.string_7 = "chat";
		if (Main.isWindowsPhone)
			gclass67_0.string_9 = gclass67_0.string_7;
		gclass67_0.int_2 = GClass39.int_10 - 6;
		if (Main.isPC && gclass67_0.int_2 > 250)
			gclass67_0.int_2 = 250;
		gclass67_0.int_3 = GClass145.int_0 + 2;
		gclass67_0.int_0 = GClass39.int_10 / 2 - gclass67_0.int_2 / 2;
		gclass67_0.bool_0 = true;
		gclass67_0.method_26(80);
	}

	public void method_0()
	{
		gclass14_0 = new GClass14(mResources.OK, this, 8000, null, 1, GClass39.int_11 - GClass145.int_3 + 1);
		gclass14_2 = new GClass14(mResources.DELETE, this, 8001, null, GClass39.int_10 - 70, GClass39.int_11 - GClass145.int_3 + 1);
		gclass14_3 = null;
		int_2 = gclass67_0.int_2 + 20;
		int_3 = gclass67_0.int_3 + 26;
		int_0 = GClass39.int_10 / 2 - int_2 / 2;
		int_1 = gclass67_0.int_1 - 18;
		if (Main.isPC && int_2 > 320)
			int_2 = 320;
		gclass14_0.int_1 = int_0;
		gclass14_2.int_1 = int_0 + int_2 - 68;
		if (GClass39.bool_5)
		{
			gclass67_0.int_1 -= 5;
			int_1 -= 20;
			int_3 += 30;
			gclass14_0.int_1 = GClass39.int_10 / 2 - 68 - 5;
			gclass14_2.int_1 = GClass39.int_10 / 2 + 5;
			gclass14_0.int_2 = GClass39.int_11 - 30;
			gclass14_2.int_2 = GClass39.int_11 - 30;
		}
		gclass14_1 = new GClass14();
		GDelegate1 gdelegate1_ = delegate(string string_2)
		{
			gclass67_0.bool_2 = false;
			gclass67_0.method_23(string_2);
			ginterface5_0.onChatFromMe(string_2, string_0);
			gclass67_0.method_23(string.Empty);
			gclass14_2.string_0 = mResources.CLOSE;
		};
		gclass14_1.gdelegate1_0 = gdelegate1_;
		gclass14_4 = new GClass14();
		gclass14_4.gdelegate1_0 = delegate(string string_2)
		{
			gclass67_0.bool_2 = false;
			if (ginterface5_0 != null)
			{
				gclass67_0.method_23(string_2);
				ginterface5_0.onChatFromMe(string_2, string_0);
				gclass67_0.method_23(string.Empty);
				gclass67_0.method_22();
				if (gclass14_2 != null)
					gclass14_2.method_1();
			}
			bool_0 = false;
		};
		int_4 = gclass67_0.int_1;
		int_5 = GClass39.int_11 / 2 - 2 * gclass67_0.int_3;
		if (Main.isWindowsPhone)
			gclass67_0.bool_8 = false;
		if (Main.isIPhone)
			gclass67_0.bool_6 = false;
	}

	public void method_1()
	{
	}

	public void method_2(int keyCode)
	{
		if (bool_0)
			gclass67_0.method_10(keyCode);
		if (gclass67_0.method_21().Equals(string.Empty))
			gclass14_2.string_0 = mResources.CLOSE;
		else
			gclass14_2.string_0 = mResources.DELETE;
	}

	public static GClass7 smethod_0()
	{
		return (gclass7_0 != null) ? gclass7_0 : (gclass7_0 = new GClass7());
	}

	public void method_3(int firstCharacter, GInterface5 parentScreen, string to)
	{
		if (!GClass171.smethod_0().bool_0)
		{
			if (this == smethod_0())
				Class15.smethod_0().method_2();
			gclass14_2.string_0 = mResources.CLOSE;
			string_0 = to;
			if (Main.isWindowsPhone)
				gclass67_0.bool_8 = false;
			if (Main.isIPhone)
				gclass67_0.bool_6 = false;
			gclass67_0.method_10(firstCharacter);
			if (!gclass67_0.method_21().Equals(string.Empty) && GClass39.gclass99_0 == null)
			{
				ginterface5_0 = parentScreen;
				bool_0 = true;
			}
		}
	}

	public void method_4(GInterface5 parentScreen, string to)
	{
		if (GClass171.smethod_0().bool_0)
			return;
		gclass14_2.string_0 = mResources.CLOSE;
		string_0 = to;
		if (Main.isWindowsPhone)
			gclass67_0.bool_8 = false;
		if (Main.isIPhone)
			gclass67_0.bool_6 = false;
		if (GClass39.gclass99_0 == null)
		{
			bool_0 = true;
			gclass67_0.bool_0 = true;
			if (!Main.isPC)
			{
				GClass123.smethod_0(string_1, GClass123.int_0, string.Empty, gclass14_1);
				gclass67_0.method_20(true);
			}
		}
		gclass67_0.method_23(string.Empty);
		gclass67_0.method_5();
		bool_1 = false;
	}

	public void method_5(GInterface5 parentScreen, string to)
	{
		if (GClass171.smethod_0().bool_0)
			return;
		gclass67_0.method_20(true);
		string_0 = to;
		ginterface5_0 = parentScreen;
		if (Main.isWindowsPhone)
			gclass67_0.bool_8 = false;
		if (Main.isIPhone)
			gclass67_0.bool_6 = false;
		if (GClass39.gclass99_0 == null)
		{
			bool_0 = true;
			if (!Main.isPC)
			{
				GClass123.smethod_0(string_1, GClass123.int_0, string.Empty, gclass14_4);
				gclass67_0.method_20(true);
			}
		}
		gclass67_0.method_23(string.Empty);
		gclass67_0.method_5();
		bool_1 = false;
	}

	public void method_6()
	{
	}

	public void method_7()
	{
		if (!bool_0)
			return;
		gclass67_0.method_17();
		if (Main.isWindowsPhone)
			method_1();
		if (gclass67_0.bool_2)
		{
			gclass67_0.bool_2 = false;
			ginterface5_0.onChatFromMe(gclass67_0.method_21(), string_0);
			gclass67_0.method_23(string.Empty);
			gclass14_2.string_0 = mResources.CLOSE;
		}
		if (!Main.isPC)
			return;
		if (GClass39.bool_11[15])
		{
			if (gclass14_0 != null && gclass67_0.method_21() != string.Empty)
				gclass14_0.method_1();
			GClass39.bool_11[15] = false;
			GClass39.bool_11[(!Main.isPC) ? 5 : 25] = false;
		}
		if (GClass39.bool_11[14])
		{
			if (gclass14_2 != null)
				gclass14_2.method_1();
			GClass39.bool_11[14] = false;
		}
	}

	public void method_8()
	{
		gclass67_0.method_23(string.Empty);
		bool_0 = false;
	}

	public void method_9(GClass76 g)
	{
		if (bool_0 && !Main.isIPhone)
		{
			GClass24.smethod_4(y: (!Main.isWindowsPhone) ? (int_1 - int_6) : (gclass67_0.int_1 - 5), g: g, x: (!Main.isWindowsPhone) ? int_0 : 0, w: (!Main.isWindowsPhone) ? int_2 : GClass39.int_10, h: int_3, color: -1, isButton: true);
			if (Main.isPC)
			{
				GClass49.gclass49_7.method_6(g, string_1 + string_0, gclass67_0.int_0, gclass67_0.int_1 - ((!GClass39.bool_5) ? 12 : 17), 0);
				GClass39.gclass37_0.method_7(g, gclass14_0, gclass14_3, gclass14_2);
			}
			gclass67_0.method_13(g);
			Class15.smethod_0().method_4(g);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8000:
			GClass5.smethod_2("perform chat 8000");
			if (ginterface5_0 != null)
			{
				long num = GClass138.smethod_18();
				if (num - long_0 >= 1000L)
				{
					long_0 = num;
					ginterface5_0.onChatFromMe(gclass67_0.method_21(), string_0);
					gclass67_0.method_23(string.Empty);
					gclass14_2.string_0 = mResources.CLOSE;
					gclass67_0.method_22();
				}
			}
			break;
		case 8001:
			GClass5.smethod_2("perform chat 8001");
			if (gclass67_0.method_21().Equals(string.Empty))
			{
				bool_0 = false;
				ginterface5_0.onCancelChat();
			}
			gclass67_0.method_4();
			break;
		case 8002:
			break;
		}
	}
}
