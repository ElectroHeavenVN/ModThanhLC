using System.Runtime.CompilerServices;
using AssemblyCSharp.Functions;
using UnityEngine;

public class GClass91 : GInterface6
{
	private static GClass91 gclass91_0;

	public GClass191 gclass191_0;

	public bool bool_0;

	public GInterface4 ginterface4_0;

	private long long_0;

	public GClass87 gclass87_0;

	public GClass87 gclass87_1;

	public GClass87 gclass87_2;

	public GClass87 gclass87_3;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private bool bool_1;

	public GClass87 gclass87_4;

	public int int_4;

	public int int_5;

	public int int_6;

	public string string_0;

	public string string_1 = "Chat ";

	public GClass91()
	{
		gclass191_0 = new GClass191();
		if (Main.isWindowsPhone)
			gclass191_0.bool_8 = false;
		if (Main.isIPhone)
			gclass191_0.bool_6 = false;
		gclass191_0.string_7 = "chat";
		if (Main.isWindowsPhone)
			gclass191_0.string_9 = gclass191_0.string_7;
		gclass191_0.int_2 = GClass73.int_10 - 6;
		if (Main.isPC && gclass191_0.int_2 > 250)
			gclass191_0.int_2 = 250;
		gclass191_0.int_3 = GClass131.int_0 + 2;
		gclass191_0.int_0 = GClass73.int_10 / 2 - gclass191_0.int_2 / 2;
		gclass191_0.bool_0 = true;
		gclass191_0.method_26(80);
	}

	public void method_0()
	{
		gclass87_0 = new GClass87(mResources.OK, this, 8000, null, 1, GClass73.int_11 - GClass131.int_3 + 1);
		gclass87_2 = new GClass87(mResources.DELETE, this, 8001, null, GClass73.int_10 - 70, GClass73.int_11 - GClass131.int_3 + 1);
		gclass87_3 = null;
		int_2 = gclass191_0.int_2 + 20;
		int_3 = gclass191_0.int_3 + 26;
		int_0 = GClass73.int_10 / 2 - int_2 / 2;
		int_1 = gclass191_0.int_1 - 18;
		if (Main.isPC && int_2 > 320)
			int_2 = 320;
		gclass87_0.int_1 = int_0;
		gclass87_2.int_1 = int_0 + int_2 - 68;
		if (GClass73.bool_5)
		{
			gclass191_0.int_1 -= 5;
			int_1 -= 20;
			int_3 += 30;
			gclass87_0.int_1 = GClass73.int_10 / 2 - 68 - 5;
			gclass87_2.int_1 = GClass73.int_10 / 2 + 5;
			gclass87_0.int_2 = GClass73.int_11 - 30;
			gclass87_2.int_2 = GClass73.int_11 - 30;
		}
		gclass87_1 = new GClass87();
		GDelegate1 gdelegate1_ = delegate(string string_2)
		{
			gclass191_0.bool_2 = false;
			gclass191_0.method_23(string_2);
			ginterface4_0.onChatFromMe(string_2, string_0);
			gclass191_0.method_23("");
			gclass87_2.string_0 = mResources.CLOSE;
		};
		gclass87_1.gdelegate1_0 = gdelegate1_;
		gclass87_4 = new GClass87();
		gclass87_4.gdelegate1_0 = delegate(string string_2)
		{
			gclass191_0.bool_2 = false;
			if (ginterface4_0 != null)
			{
				gclass191_0.method_23(string_2);
				ginterface4_0.onChatFromMe(string_2, string_0);
				gclass191_0.method_23("");
				gclass191_0.method_22();
				if (gclass87_2 != null)
					gclass87_2.method_1();
			}
			bool_0 = false;
		};
		int_4 = gclass191_0.int_1;
		int_5 = GClass73.int_11 / 2 - 2 * gclass191_0.int_3;
		if (Main.isWindowsPhone)
			gclass191_0.bool_8 = false;
		if (Main.isIPhone)
			gclass191_0.bool_6 = false;
	}

	public void method_1()
	{
	}

	public void method_2(int keyCode)
	{
		if (bool_0)
			gclass191_0.method_10(keyCode);
		if (gclass191_0.method_21().Equals(""))
			gclass87_2.string_0 = mResources.CLOSE;
		else
			gclass87_2.string_0 = mResources.DELETE;
	}

	public static GClass91 smethod_0()
	{
		return (gclass91_0 != null) ? gclass91_0 : (gclass91_0 = new GClass91());
	}

	public void method_3(int firstCharacter, GInterface4 parentScreen, string to)
	{
		if (!GClass148.smethod_0().bool_0)
		{
			if (this == smethod_0())
				Class16.k4qKbAJZyI().method_0();
			gclass87_2.string_0 = mResources.CLOSE;
			string_0 = to;
			if (Main.isWindowsPhone)
				gclass191_0.bool_8 = false;
			if (Main.isIPhone)
				gclass191_0.bool_6 = false;
			gclass191_0.method_10(firstCharacter);
			if (!gclass191_0.method_21().Equals("") && GClass73.gclass42_0 == null)
			{
				ginterface4_0 = parentScreen;
				bool_0 = true;
			}
		}
	}

	public void method_4(GInterface4 parentScreen, string to)
	{
		if (GClass148.smethod_0().bool_0)
			return;
		gclass87_2.string_0 = mResources.CLOSE;
		string_0 = to;
		if (Main.isWindowsPhone)
			gclass191_0.bool_8 = false;
		if (Main.isIPhone)
			gclass191_0.bool_6 = false;
		if (GClass73.gclass42_0 == null)
		{
			bool_0 = true;
			gclass191_0.bool_0 = true;
			if (!Main.isPC)
			{
				GClass105.smethod_0(string_1, GClass105.int_0, "", gclass87_1);
				gclass191_0.method_20(true);
			}
		}
		gclass191_0.method_23("");
		gclass191_0.method_5();
		bool_1 = false;
	}

	public void method_5(GInterface4 parentScreen, string to)
	{
		if (GClass148.smethod_0().bool_0)
			return;
		gclass191_0.method_20(true);
		string_0 = to;
		ginterface4_0 = parentScreen;
		if (Main.isWindowsPhone)
			gclass191_0.bool_8 = false;
		if (Main.isIPhone)
			gclass191_0.bool_6 = false;
		if (GClass73.gclass42_0 == null)
		{
			bool_0 = true;
			if (!Main.isPC)
			{
				GClass105.smethod_0(string_1, GClass105.int_0, "", gclass87_4);
				gclass191_0.method_20(true);
			}
		}
		gclass191_0.method_23("");
		gclass191_0.method_5();
		bool_1 = false;
	}

	public void method_6()
	{
	}

	public void method_7()
	{
		if (!bool_0)
			return;
		gclass191_0.method_17();
		if (Main.isWindowsPhone)
			method_1();
		if (gclass191_0.bool_2)
		{
			gclass191_0.bool_2 = false;
			ginterface4_0.onChatFromMe(gclass191_0.method_21(), string_0);
			gclass191_0.method_23("");
			gclass87_2.string_0 = mResources.CLOSE;
		}
		if (!Main.isPC)
			return;
		if (GClass73.bool_11[15])
		{
			if (gclass87_0 != null && gclass191_0.method_21() != "")
				gclass87_0.method_1();
			GClass73.bool_11[15] = false;
			GClass73.bool_11[Main.isPC ? 25 : 5] = false;
		}
		if (GClass73.bool_11[14])
		{
			if (gclass87_2 != null)
				gclass87_2.method_1();
			GClass73.bool_11[14] = false;
		}
	}

	public void method_8()
	{
		gclass191_0.method_23("");
		bool_0 = false;
	}

	public void method_9(GClass122 g)
	{
		if (!bool_0 || Main.isIPhone)
			return;
		int y = ((!Main.isWindowsPhone) ? (int_1 - int_6) : (gclass191_0.int_1 - 5));
		GClass45.smethod_4(g, (!Main.isWindowsPhone) ? int_0 : 0, y, Main.isWindowsPhone ? GClass73.int_10 : int_2, int_3, -1, true);
		if (Main.isPC)
		{
			GClass4.gclass4_7.method_6(g, string_1 + string_0, gclass191_0.int_0, gclass191_0.int_1 - ((!GClass73.bool_5) ? 12 : 17), 0);
			if (!string.IsNullOrEmpty(GUIUtility.systemCopyBuffer) && string_1.Contains("Chat"))
				GClass4.gclass4_7.method_6(g, (GClass151.int_0 == 0) ? "[Ctrl + V để dán]" : "[Ctrl + V to paste]", gclass191_0.int_0 + 60, gclass191_0.int_1 - ((!GClass73.bool_5) ? 12 : 17), 0);
			GClass73.gclass192_0.method_7(g, gclass87_0, gclass87_3, gclass87_2);
		}
		gclass191_0.method_13(g);
		Class16.k4qKbAJZyI().method_2(g);
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8000:
			GClass36.smethod_2("perform chat 8000");
			if (ginterface4_0 != null)
			{
				long num = GClass203.smethod_18();
				if (num - long_0 >= 1000L)
				{
					long_0 = num;
					ginterface4_0.onChatFromMe(gclass191_0.method_21(), string_0);
					gclass191_0.method_23("");
					gclass87_2.string_0 = mResources.CLOSE;
					gclass191_0.method_22();
				}
			}
			break;
		case 8001:
			GClass36.smethod_2("perform chat 8001");
			if (gclass191_0.method_21().Equals(""))
			{
				bool_0 = false;
				ginterface4_0.onCancelChat();
			}
			gclass191_0.method_4();
			break;
		case 8002:
			break;
		}
	}

	[CompilerGenerated]
	private void method_10(string string_2)
	{
		gclass191_0.bool_2 = false;
		gclass191_0.method_23(string_2);
		ginterface4_0.onChatFromMe(string_2, string_0);
		gclass191_0.method_23("");
		gclass87_2.string_0 = mResources.CLOSE;
	}

	[CompilerGenerated]
	private void method_11(string string_2)
	{
		gclass191_0.bool_2 = false;
		if (ginterface4_0 != null)
		{
			gclass191_0.method_23(string_2);
			ginterface4_0.onChatFromMe(string_2, string_0);
			gclass191_0.method_23("");
			gclass191_0.method_22();
			if (gclass87_2 != null)
				gclass87_2.method_1();
		}
		bool_0 = false;
	}
}
