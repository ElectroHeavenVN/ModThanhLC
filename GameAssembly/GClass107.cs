using System.Runtime.CompilerServices;
using ns1;

public class GClass107 : GInterface1
{
	private static GClass107 gclass107_0;

	public GClass136 gclass136_0;

	public bool bool_0;

	public GInterface3 ginterface3_0;

	private long long_0;

	public GClass118 gclass118_0;

	public GClass118 gclass118_1;

	public GClass118 gclass118_2;

	public GClass118 gclass118_3;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private bool bool_1;

	public GClass118 gclass118_4;

	public int int_4;

	public int int_5;

	public int int_6;

	public string string_0;

	public string string_1 = "Chat ";

	public GClass107()
	{
		gclass136_0 = new GClass136();
		if (Main.isWindowsPhone)
			gclass136_0.bool_8 = false;
		if (Main.isIPhone)
			gclass136_0.bool_6 = false;
		gclass136_0.string_7 = "chat";
		if (Main.isWindowsPhone)
			gclass136_0.string_9 = gclass136_0.string_7;
		gclass136_0.int_2 = GClass14.int_10 - 6;
		if (Main.isPC && gclass136_0.int_2 > 250)
			gclass136_0.int_2 = 250;
		gclass136_0.int_3 = GClass160.int_0 + 2;
		gclass136_0.int_0 = GClass14.int_10 / 2 - gclass136_0.int_2 / 2;
		gclass136_0.bool_0 = true;
		gclass136_0.method_26(80);
	}

	public void method_0()
	{
		gclass118_0 = new GClass118(mResources.OK, this, 8000, null, 1, GClass14.int_11 - GClass160.int_3 + 1);
		gclass118_2 = new GClass118(mResources.DELETE, this, 8001, null, GClass14.int_10 - 70, GClass14.int_11 - GClass160.int_3 + 1);
		gclass118_3 = null;
		int_2 = gclass136_0.int_2 + 20;
		int_3 = gclass136_0.int_3 + 26;
		int_0 = GClass14.int_10 / 2 - int_2 / 2;
		int_1 = gclass136_0.int_1 - 18;
		if (Main.isPC && int_2 > 320)
			int_2 = 320;
		gclass118_0.int_1 = int_0;
		gclass118_2.int_1 = int_0 + int_2 - 68;
		if (GClass14.bool_5)
		{
			gclass136_0.int_1 -= 5;
			int_1 -= 20;
			int_3 += 30;
			gclass118_0.int_1 = GClass14.int_10 / 2 - 68 - 5;
			gclass118_2.int_1 = GClass14.int_10 / 2 + 5;
			gclass118_0.int_2 = GClass14.int_11 - 30;
			gclass118_2.int_2 = GClass14.int_11 - 30;
		}
		gclass118_1 = new GClass118();
		GDelegate0 gdelegate0_ = delegate(string string_2)
		{
			gclass136_0.bool_2 = false;
			gclass136_0.method_23(string_2);
			ginterface3_0.onChatFromMe(string_2, string_0);
			gclass136_0.method_23(string.Empty);
			gclass118_2.string_0 = mResources.CLOSE;
		};
		gclass118_1.gdelegate0_0 = gdelegate0_;
		gclass118_4 = new GClass118();
		gclass118_4.gdelegate0_0 = delegate(string string_2)
		{
			gclass136_0.bool_2 = false;
			if (ginterface3_0 != null)
			{
				gclass136_0.method_23(string_2);
				ginterface3_0.onChatFromMe(string_2, string_0);
				gclass136_0.method_23(string.Empty);
				gclass136_0.method_22();
				if (gclass118_2 != null)
					gclass118_2.method_1();
			}
			bool_0 = false;
		};
		int_4 = gclass136_0.int_1;
		int_5 = GClass14.int_11 / 2 - 2 * gclass136_0.int_3;
		if (Main.isWindowsPhone)
			gclass136_0.bool_8 = false;
		if (Main.isIPhone)
			gclass136_0.bool_6 = false;
	}

	public void method_1()
	{
	}

	public void method_2(int keyCode)
	{
		if (bool_0)
			gclass136_0.method_10(keyCode);
		if (!gclass136_0.method_21().Equals(string.Empty))
			gclass118_2.string_0 = mResources.DELETE;
		else
			gclass118_2.string_0 = mResources.CLOSE;
	}

	public static GClass107 smethod_0()
	{
		return (gclass107_0 != null) ? gclass107_0 : (gclass107_0 = new GClass107());
	}

	public void method_3(int firstCharacter, GInterface3 parentScreen, string to)
	{
		if (!GClass57.smethod_0().bool_0)
		{
			if (this == smethod_0())
				Class7.smethod_0().method_0();
			gclass118_2.string_0 = mResources.CLOSE;
			string_0 = to;
			if (Main.isWindowsPhone)
				gclass136_0.bool_8 = false;
			if (Main.isIPhone)
				gclass136_0.bool_6 = false;
			gclass136_0.method_10(firstCharacter);
			if (!gclass136_0.method_21().Equals(string.Empty) && GClass14.gclass183_0 == null)
			{
				ginterface3_0 = parentScreen;
				bool_0 = true;
			}
		}
	}

	public void method_4(GInterface3 parentScreen, string to)
	{
		if (GClass57.smethod_0().bool_0)
			return;
		gclass118_2.string_0 = mResources.CLOSE;
		string_0 = to;
		if (Main.isWindowsPhone)
			gclass136_0.bool_8 = false;
		if (Main.isIPhone)
			gclass136_0.bool_6 = false;
		if (GClass14.gclass183_0 == null)
		{
			bool_0 = true;
			gclass136_0.bool_0 = true;
			if (!Main.isPC)
			{
				GClass132.smethod_0(string_1, GClass132.int_0, string.Empty, gclass118_1);
				gclass136_0.method_20(true);
			}
		}
		gclass136_0.method_23(string.Empty);
		gclass136_0.method_5();
		bool_1 = false;
	}

	public void method_5(GInterface3 parentScreen, string to)
	{
		if (GClass57.smethod_0().bool_0)
			return;
		gclass136_0.method_20(true);
		string_0 = to;
		ginterface3_0 = parentScreen;
		if (Main.isWindowsPhone)
			gclass136_0.bool_8 = false;
		if (Main.isIPhone)
			gclass136_0.bool_6 = false;
		if (GClass14.gclass183_0 == null)
		{
			bool_0 = true;
			if (!Main.isPC)
			{
				GClass132.smethod_0(string_1, GClass132.int_0, string.Empty, gclass118_4);
				gclass136_0.method_20(true);
			}
		}
		gclass136_0.method_23(string.Empty);
		gclass136_0.method_5();
		bool_1 = false;
	}

	public void method_6()
	{
	}

	public void method_7()
	{
		if (!bool_0)
			return;
		gclass136_0.method_17();
		if (Main.isWindowsPhone)
			method_1();
		if (gclass136_0.bool_2)
		{
			gclass136_0.bool_2 = false;
			ginterface3_0.onChatFromMe(gclass136_0.method_21(), string_0);
			gclass136_0.method_23(string.Empty);
			gclass118_2.string_0 = mResources.CLOSE;
		}
		if (!Main.isPC)
			return;
		if (GClass14.bool_11[15])
		{
			if (gclass118_0 != null && gclass136_0.method_21() != string.Empty)
				gclass118_0.method_1();
			GClass14.bool_11[15] = false;
			GClass14.bool_11[(!Main.isPC) ? 5 : 25] = false;
		}
		if (GClass14.bool_11[14])
		{
			if (gclass118_2 != null)
				gclass118_2.method_1();
			GClass14.bool_11[14] = false;
		}
	}

	public void method_8()
	{
		gclass136_0.method_23(string.Empty);
		bool_0 = false;
	}

	public void method_9(GClass193 g)
	{
		if (bool_0 && !Main.isIPhone)
		{
			int y = ((!Main.isWindowsPhone) ? (int_1 - int_6) : (gclass136_0.int_1 - 5));
			GClass139.smethod_4(g, (!Main.isWindowsPhone) ? int_0 : 0, y, Main.isWindowsPhone ? GClass14.int_10 : int_2, int_3, -1, true);
			if (Main.isPC)
			{
				GClass104.gclass104_7.method_6(g, string_1 + string_0, gclass136_0.int_0, gclass136_0.int_1 - (GClass14.bool_5 ? 17 : 12), 0);
				GClass14.gclass97_0.method_7(g, gclass118_0, gclass118_3, gclass118_2);
			}
			gclass136_0.method_13(g);
			Class7.smethod_0().method_2(g);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8000:
			GClass92.smethod_2("perform chat 8000");
			if (ginterface3_0 != null)
			{
				long num = GClass77.smethod_18();
				if (num - long_0 >= 1000L)
				{
					long_0 = num;
					ginterface3_0.onChatFromMe(gclass136_0.method_21(), string_0);
					gclass136_0.method_23(string.Empty);
					gclass118_2.string_0 = mResources.CLOSE;
					gclass136_0.method_22();
				}
			}
			break;
		case 8001:
			GClass92.smethod_2("perform chat 8001");
			if (gclass136_0.method_21().Equals(string.Empty))
			{
				bool_0 = false;
				ginterface3_0.onCancelChat();
			}
			gclass136_0.method_4();
			break;
		case 8002:
			break;
		}
	}
}
