using System;
using System.Runtime.CompilerServices;

public class GClass133 : GClass131, GInterface6
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class2
	{
		public static readonly Class2 class2_0 = new Class2();

		public static GDelegate1 gdelegate1_0;

		internal void method_0(string str)
		{
			try
			{
				if (str != null && !(str == ""))
				{
					GClass1.smethod_19(str);
					if (str.Contains(":"))
					{
						int num = str.IndexOf(":");
						string text = str.Substring(0, num);
						string s = str.Substring(num + 1);
						GClass187.string_0 = text;
						GClass187.int_0 = int.Parse(s);
						GClass14.smethod_0().connect(text, int.Parse(s));
						bool_9 = true;
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public GClass191 gclass191_0;

	public GClass191 gclass191_1;

	public static bool bool_0 = false;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	public bool bool_1;

	public bool bool_2;

	public GClass87 gclass87_4;

	public GClass87 gclass87_5;

	public GClass87 gclass87_6;

	public GClass87 gclass87_7;

	public GClass87 gclass87_8;

	public GClass87 gclass87_9;

	public string string_0 = "";

	public string string_1;

	public string string_2;

	private string string_3 = "";

	public static bool bool_3 = false;

	public static bool bool_4;

	public static bool bool_5;

	public static bool bool_6;

	public static bool bool_7;

	public static bool bool_8;

	public static string string_4;

	public static GClass70 gclass70_0;

	public int int_10;

	public int int_11;

	public int int_12;

	public int int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public static int[] int_17 = new int[5] { 0, 8, 2, 6, 9 };

	public static bool bool_9;

	public static short short_0;

	public static long long_0;

	public static long long_1;

	private int int_18;

	private GClass87 gclass87_10;

	private GClass87 gclass87_11;

	private int int_19;

	private int int_20;

	public static GClass187 gclass187_0;

	private int int_21 = GClass73.int_13 - GClass131.int_0 - 5;

	private int int_22;

	private int int_23;

	private int int_24;

	private int int_25;

	private int int_26;

	private int int_27 = 20;

	private bool bool_10;

	private string string_5 = "";

	public bool bool_11;

	private int int_28 = -1;

	public bool bool_12;

	private int int_29 = 2;

	private int int_30;

	private int int_31 = -40;

	private int int_32 = 1;

	private GClass87 gclass87_12;

	public static bool bool_13;

	public GClass133()
	{
		int_20 = GClass73.int_13 - 30;
		GClass20.int_40 = (sbyte)(GClass203.smethod_18() % 9L);
		if (GClass20.int_40 == 5 || GClass20.int_40 == 6)
			GClass20.int_40 = 4;
		GClass144.smethod_10(true, -1, -1);
		GClass144.int_22 = 100;
		GClass144.int_23 = 200;
		Main.closeKeyBoard();
		if (GClass73.int_11 <= 200)
			int_9 = GClass73.int_13 - 65;
		else
			int_9 = GClass73.int_13 - 80;
		method_13();
		int_7 = ((GClass73.int_10 >= 200) ? 160 : 140);
		int_18 = GClass73.int_13 - GClass131.int_0 - 5;
		if (GClass73.int_11 <= 160)
			int_18 = 20;
		gclass191_0 = new GClass191();
		gclass191_0.int_1 = GClass73.int_13 - GClass131.int_0 - 9;
		gclass191_0.int_2 = int_7;
		gclass191_0.int_3 = GClass131.int_0 + 2;
		gclass191_0.bool_0 = true;
		gclass191_0.method_28(GClass191.int_11);
		gclass191_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : "") + mResources.email;
		gclass191_1 = new GClass191();
		gclass191_1.int_1 = GClass73.int_13 - 4;
		gclass191_1.method_28(GClass191.int_13);
		gclass191_1.int_2 = int_7;
		gclass191_1.int_3 = GClass131.int_0 + 2;
		int_18 += 35;
		bool_1 = true;
		int num = GClass1.smethod_8("check");
		if (num != 1)
		{
			if (num == 2)
				bool_1 = false;
		}
		else
			bool_1 = true;
		gclass191_0.method_23(GClass1.smethod_2("acc"));
		gclass191_1.method_23(GClass1.smethod_2("pass"));
		if (gclass87_12 == null)
		{
			gclass87_12 = new GClass87("Gọi hotline", this, 13, null);
			gclass87_12.int_1 = GClass73.int_10 - 75;
			if (GClass203.int_0 != 1 || GClass73.bool_5)
				gclass87_12.int_2 = 8;
			else
				gclass87_12.int_2 = GClass73.int_11 - 20;
		}
		int_6 = 0;
		gclass87_4 = new GClass87((GClass73.int_10 <= 200) ? mResources.login2 : mResources.login, GClass73.gclass73_0, 888393, null);
		gclass87_5 = new GClass87(mResources.remember, this, 2001, null);
		gclass87_7 = new GClass87(mResources.register, this, 2002, null);
		gclass87_9 = new GClass87(mResources.CANCEL, this, 10021, null);
		gclass87_0 = (gclass87_8 = new GClass87(mResources.MENU, this, 2003, null));
		int_22 = gclass191_0.int_1 - 2 * gclass191_0.int_3;
		if (GClass73.bool_5)
		{
			gclass87_4.int_1 = GClass73.int_10 / 2 + 8;
			gclass87_8.int_1 = GClass73.int_10 / 2 - GClass131.int_2 - 8;
			if (GClass73.int_11 >= 200)
			{
				gclass87_4.int_2 = int_20 + 110;
				gclass87_8.int_2 = int_20 + 110;
			}
			gclass87_9.int_1 = GClass73.int_10 / 2 + 3;
			gclass87_9.int_2 = int_20 + 110;
			gclass87_7.int_1 = GClass73.int_10 / 2 - 84;
			gclass87_7.int_2 = gclass87_8.int_2;
		}
		int_25 = 170;
		int_26 = (bool_2 ? 110 : 100);
		int_23 = GClass73.int_12 - int_25 / 2;
		int_24 = gclass191_0.int_1 - 15;
		int num2 = 4;
		int num3 = 184;
		if (184 >= GClass73.int_10)
			num3 = (num2 - 1) * 32 + 23 + 33;
		int_19 = GClass73.int_10 / 2 - num3 / 2;
		int_20 = GClass73.int_13 - 30;
		int_12 = ((GClass73.int_10 < 200) ? (gclass191_0.int_1 - 30) : (int_20 - 30));
		gclass191_0.int_0 = int_19 + 10;
		gclass191_0.int_1 = int_20 + 20;
		gclass87_11 = new GClass87(mResources.OK, this, 2008, null);
		gclass87_11.int_1 = GClass73.int_10 / 2 - 84;
		gclass87_11.int_2 = gclass87_4.int_2;
		gclass87_6 = new GClass87(mResources.forgetPass, this, 1003, null);
		gclass87_6.int_1 = GClass73.int_10 / 2 + 3;
		gclass87_6.int_2 = gclass87_4.int_2;
		gclass87_1 = gclass87_11;
		gclass87_0 = gclass87_6;
	}

	public static void smethod_2()
	{
		try
		{
			if (bool_9)
				return;
			GClass87 gClass = new GClass87();
			gClass.gdelegate1_0 = delegate(string str)
			{
				try
				{
					if (str != null && !(str == ""))
					{
						GClass1.smethod_19(str);
						if (str.Contains(":"))
						{
							int num = str.IndexOf(":");
							string host = str.Substring(0, num);
							string s = str.Substring(num + 1);
							GClass187.string_0 = host;
							GClass187.int_0 = int.Parse(s);
							GClass14.smethod_0().connect(host, int.Parse(s));
							bool_9 = true;
						}
					}
				}
				catch (Exception)
				{
				}
			};
			Class4.smethod_1(GClass134.string_8, gClass);
		}
		catch (Exception)
		{
		}
	}

	public override void switchToMe()
	{
		bool_10 = false;
		GClass109.smethod_1().method_51();
		gclass191_0.bool_0 = true;
		gclass191_1.bool_0 = false;
		if (GClass73.bool_5)
			gclass191_0.bool_0 = false;
		GClass73.smethod_21(0);
		base.switchToMe();
	}

	public void method_0()
	{
		string text = GClass1.smethod_2("acc");
		if (text != null && !text.Equals(""))
			gclass191_0.method_23(text);
		string text2 = GClass1.smethod_2("pass");
		if (text2 != null && !text2.Equals(""))
			gclass191_1.method_23(text2);
	}

	public void method_1()
	{
	}

	protected void method_2()
	{
		GClass88 gClass = new GClass88();
		gClass.method_0(new GClass87(mResources.registerNewAcc, this, 2004, null));
		if (!bool_12)
			gClass.method_0(new GClass87(mResources.selectServer, this, 1004, null));
		gClass.method_0(new GClass87(mResources.forgetPass, this, 1003, null));
		gClass.method_0(new GClass87(mResources.website, this, 1005, null));
		if (Main.isPC)
			gClass.method_0(new GClass87(mResources.EXIT, GClass73.gclass73_0, 8885, null));
		GClass73.gclass145_0.method_2(gClass, 0);
	}

	protected void method_3()
	{
		if (gclass191_0.method_21().Equals(""))
		{
			GClass73.smethod_30(mResources.userBlank);
			return;
		}
		gclass191_0.method_21().ToCharArray();
		if (gclass191_1.method_21().Equals(""))
		{
			GClass73.smethod_30(mResources.passwordBlank);
			return;
		}
		if (gclass191_0.method_21().Length < 5)
		{
			GClass73.smethod_30(mResources.accTooShort);
			return;
		}
		int num = 0;
		string text = null;
		if (mResources.language == 2)
		{
			if (gclass191_0.method_21().IndexOf("@") == -1 || gclass191_0.method_21().IndexOf(".") == -1)
				text = mResources.emailInvalid;
			num = 0;
		}
		else
			try
			{
				long.Parse(gclass191_0.method_21());
				if (gclass191_0.method_21().Length < 8 || gclass191_0.method_21().Length > 12 || (!gclass191_0.method_21().StartsWith("0") && !gclass191_0.method_21().StartsWith("84")))
					text = mResources.phoneInvalid;
				num = 1;
			}
			catch (Exception)
			{
				if (gclass191_0.method_21().IndexOf("@") == -1 || gclass191_0.method_21().IndexOf(".") == -1)
					text = mResources.emailInvalid;
				num = 0;
			}
		if (text == null)
			GClass73.gclass44_0.method_2(mResources.plsCheckAcc + ((num != 1) ? (mResources.email + ": ") : (mResources.phone + ": ")) + gclass191_0.method_21() + "\n" + mResources.password + ": " + gclass191_1.method_21(), new GClass87(mResources.ACCEPT, this, 4000, null), null, new GClass87(mResources.NO, GClass73.gclass73_0, 8882, null));
		else
			GClass73.smethod_30(text);
		GClass73.gclass42_0 = GClass73.gclass44_0;
	}

	protected void method_4(string user)
	{
		bool_11 = false;
		GClass73.smethod_31(mResources.CONNECTING);
		GClass73.smethod_4();
		GClass73.smethod_31(mResources.REGISTERING);
		string_5 = gclass191_1.method_21();
		GClass7.smethod_0().method_39(user, gclass191_1.method_21(), GClass1.smethod_2("userAo" + GClass134.int_14), GClass1.smethod_2("passAo" + GClass134.int_14), GClass187.string_2);
		GClass1.smethod_4("acc", user);
		GClass1.smethod_4("pass", gclass191_1.method_21());
		int_27 = 20;
		bool_10 = true;
	}

	public void method_5()
	{
		if (!string_0.Equals("") || string_0.Equals(""))
			;
		if (!GClass14.bool_1)
		{
			bool_11 = true;
			GClass73.smethod_4();
		}
		GClass73.smethod_33();
	}

	protected void method_6()
	{
		GClass88 gClass = new GClass88();
		if (bool_3)
			gClass.method_0(new GClass87("Server LOCAL", this, 20004, null));
		gClass.method_0(new GClass87("Server Bokken", this, 20001, null));
		gClass.method_0(new GClass87("Server Shuriken", this, 20002, null));
		gClass.method_0(new GClass87("Server Tessen (mới)", this, 20003, null));
		GClass73.gclass145_0.method_2(gClass, 0);
		if (method_8() != -1 && !GClass73.bool_5)
			GClass73.gclass145_0.int_0 = method_8();
	}

	protected void method_7(int index)
	{
		GClass1.smethod_9("indServer", index);
	}

	protected int method_8()
	{
		return GClass1.smethod_8("indServer");
	}

	public void method_9()
	{
		string text = GClass1.smethod_2("acc");
		string text2 = GClass1.smethod_2("pass");
		if (text != null && !text.Equals(""))
			bool_12 = false;
		else if (GClass1.smethod_2("userAo" + GClass134.int_14) == null || GClass1.smethod_2("userAo" + GClass134.int_14).Equals(""))
		{
			bool_12 = false;
		}
		else
		{
			bool_12 = true;
		}
		if ((text == null || text.Equals("")) && bool_12)
		{
			text = GClass1.smethod_2("userAo" + GClass134.int_14);
			text2 = "a";
		}
		if (text == null || text2 == null || GClass187.string_2 == null || text.Equals(""))
			return;
		if (!text2.Equals(""))
		{
			if (!GClass14.smethod_0().isConnected())
				GClass73.smethod_4();
			GClass50.smethod_8("ccccccc " + text + " " + text2 + " " + GClass187.string_2 + " " + (sbyte)(bool_12 ? 1 : 0));
			GClass7.smethod_0().method_38(text, text2, GClass187.string_2, (sbyte)(bool_12 ? 1 : 0));
			if (GClass14.bool_1)
				GClass73.smethod_33();
			else
				GClass73.smethod_30(mResources.maychutathoacmatsong);
			int_6 = 0;
			if (!bool_12)
				method_14();
			GClass73.long_6 = GClass203.smethod_18() + 30000L;
		}
		else
		{
			int_6 = 1;
			gclass191_0.bool_0 = false;
			gclass191_1.bool_0 = true;
			if (!GClass73.bool_5)
				gclass87_2 = gclass191_1.gclass87_0;
		}
	}

	public void method_10()
	{
		if (!bool_1)
		{
			GClass1.smethod_9("check", 2);
			GClass1.smethod_4("acc", "");
			GClass1.smethod_4("pass", "");
		}
		else
		{
			GClass1.smethod_9("check", 1);
			GClass1.smethod_4("acc", gclass191_0.method_21().ToLower().Trim());
			GClass1.smethod_4("pass", gclass191_1.method_21().ToLower().Trim());
		}
	}

	public override void update()
	{
		if (Main.isWindowsPhone && bool_10)
		{
			if (int_27 >= 0)
				int_27--;
			else
			{
				GClass73.smethod_29();
				GClass14.smethod_0().close();
				GClass73.gclass134_0.switchToMe();
				bool_10 = false;
			}
		}
		if (short_0 > 0)
		{
			GClass73.smethod_33();
			long_1 = GClass203.smethod_18();
			if (long_1 - long_0 >= 1000L)
			{
				short_0--;
				if (short_0 == 0)
					GClass73.gclass133_0.method_9();
				long_0 = long_1;
			}
		}
		if (!bool_12 || bool_2)
		{
			gclass191_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : "") + mResources.email;
			gclass191_1.string_7 = mResources.password;
			gclass191_0.method_17();
			gclass191_1.method_17();
		}
		else
		{
			gclass191_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : "") + mResources.email;
			gclass191_1.string_7 = mResources.password;
			gclass191_0.bool_7 = false;
			gclass191_1.bool_7 = false;
			gclass191_0.method_17();
			gclass191_1.method_17();
		}
		if (GClass60.bool_1)
			GClass122.int_24 = 50;
		for (int i = 0; i < GClass93.gclass88_1.method_2(); i++)
		{
			((GClass93)GClass93.gclass88_1.method_3(i)).update();
		}
		if (bool_4 && !bool_5 && !bool_8 && !bool_6 && !bool_7)
		{
			bool_4 = false;
			GClass203.smethod_26();
			GClass7.smethod_0().method_115();
		}
		GClass144.int_22++;
		if (GClass144.int_22 > GClass73.int_10 * 3 + 100)
			GClass144.int_22 = 100;
		if (GClass96.gclass96_0 != null)
			return;
		GClass73.smethod_8("LGU1", 0);
		GClass73.smethod_8("LGU2", 0);
		GClass73.smethod_8("LGU3", 0);
		method_12();
		GClass73.smethod_8("LGU4", 0);
		GClass73.smethod_8("LGU5", 0);
		if (int_30 >= 0)
		{
			int_31 += int_32 * int_30;
			int_30 += int_32 * int_29;
			if (int_30 <= 0)
				int_32 *= -1;
			if (int_31 > 0)
			{
				int_32 *= -1;
				int_30 -= 2 * int_29;
			}
		}
		GClass73.smethod_8("LGU6", 0);
		if (int_28 >= 0 && GClass73.int_8 % 100 == 0)
			method_11();
		if (bool_12 && !bool_2)
		{
			gclass191_0.bool_7 = false;
			gclass191_1.bool_7 = false;
			gclass191_0.method_17();
			gclass191_1.method_17();
		}
		else
		{
			gclass191_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : "") + mResources.email;
			gclass191_1.string_7 = mResources.password;
			gclass191_0.method_17();
			gclass191_1.method_17();
		}
		if (GClass73.bool_5)
		{
			if (!bool_2)
			{
				gclass87_1 = gclass87_11;
				gclass87_0 = gclass87_6;
			}
			else
			{
				gclass87_1 = gclass87_7;
				gclass87_0 = gclass87_9;
			}
		}
		else if (!bool_2)
		{
			gclass87_1 = gclass87_11;
			gclass87_0 = gclass87_6;
		}
		else
		{
			gclass87_1 = gclass87_7;
			gclass87_0 = gclass87_9;
		}
		if (!Main.isPC && !GClass60.bool_1 && !Main.isMiniApp && !Main.isWindowsPhone)
		{
			string text = gclass191_0.method_21().ToLower().Trim();
			string text2 = gclass191_1.method_21().ToLower().Trim();
			if (!text.Equals("") && !text2.Equals(""))
				method_9();
			Main.isMiniApp = true;
		}
		method_1();
	}

	private void method_11()
	{
		int_28++;
		if (int_28 >= mResources.tips.Length)
			int_28 = 0;
		if (GClass73.gclass42_0 == GClass73.gclass44_0 && GClass73.gclass44_0.bool_0)
			GClass73.gclass44_0.method_1(mResources.tips[int_28]);
	}

	public void method_12()
	{
		if (int_9 != int_8)
			int_8 += int_9 - int_8 >> 1;
	}

	public override void keyPress(int keyCode)
	{
		if (!gclass191_0.bool_0)
		{
			if (gclass191_1.bool_0)
				gclass191_1.method_10(keyCode);
		}
		else
			gclass191_0.method_10(keyCode);
		base.keyPress(keyCode);
	}

	public override void unLoad()
	{
		base.unLoad();
	}

	public override void paint(GClass122 g)
	{
		GClass73.smethod_8("PLG1", 1);
		GClass73.smethod_18(g);
		GClass73.smethod_8("PLG2", 2);
		int num = gclass191_0.int_1 - 50;
		if (GClass73.int_11 <= 220)
			num += 5;
		GClass4.gclass4_20.method_10(g, "v" + GClass187.string_2, GClass73.int_10 - 2, 17, 1, GClass4.gclass4_16);
		if (GClass203.int_0 != 1 || GClass73.bool_5)
			GClass4.gclass4_20.method_10(g, GClass134.string_10, GClass73.int_10 - 2, 2, 1, GClass4.gclass4_16);
		else
			GClass4.gclass4_20.method_10(g, GClass134.string_10, GClass73.int_10 - 2, GClass73.int_11 - 15, 1, GClass4.gclass4_16);
		if (GClass96.gclass96_0 != null || GClass96.gclass96_1 != null)
			return;
		if (GClass73.gclass42_0 == null)
		{
			int h = 105;
			int w = ((GClass73.int_10 >= 200) ? 180 : 160);
			GClass45.smethod_4(g, int_19, int_20 - 10, w, h, -1, true);
			if (GClass73.int_11 > 160 && gclass70_0 != null)
				g.method_31(gclass70_0, GClass73.int_12, num, 3);
			GClass73.smethod_8("PLG4", 1);
			int num2 = 4;
			int num3 = 184;
			if (184 >= GClass73.int_10)
				num3 = (num2 - 1) * 32 + 23 + 33;
			int_19 = GClass73.int_10 / 2 - num3 / 2;
			gclass191_0.int_0 = int_19 + 10;
			gclass191_0.int_1 = int_20 + 20;
			gclass191_1.int_0 = int_19 + 10;
			gclass191_1.int_1 = int_20 + 55;
			gclass191_0.method_13(g);
			gclass191_1.method_13(g);
			if (GClass73.int_10 < 176)
			{
				GClass4.gclass4_7.method_6(g, mResources.acc + ":", gclass191_0.int_0 - 35, gclass191_0.int_1 + 7, 0);
				GClass4.gclass4_7.method_6(g, mResources.pwd + ":", gclass191_1.int_0 - 35, gclass191_1.int_1 + 7, 0);
				GClass4.gclass4_7.method_6(g, mResources.server + ":" + string_4, GClass73.int_10 / 2, gclass191_1.int_1 + 32, 2);
			}
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		if (!GClass73.bool_5)
		{
			if (GClass203.int_0 == 1 && GClass73.bool_11[13])
			{
				GClass73.bool_11[13] = false;
				gclass87_12.method_1();
			}
		}
		else if (gclass87_12 != null && gclass87_12.method_4())
		{
			gclass87_12.method_1();
		}
		if (bool_0)
			return;
		if (!GClass73.bool_5)
		{
			if (!gclass191_0.bool_0)
				gclass87_2 = gclass191_1.gclass87_0;
			else
				gclass87_2 = gclass191_0.gclass87_0;
		}
		if (!GClass73.bool_11[(!Main.isPC) ? 2 : 21])
		{
			if (GClass73.bool_11[(!Main.isPC) ? 8 : 22] || GClass73.bool_11[16])
			{
				int_6++;
				if (int_6 > 1)
					int_6 = 0;
			}
		}
		else
		{
			int_6--;
			if (int_6 < 0)
				int_6 = 1;
		}
		if (GClass73.bool_11[Main.isPC ? 21 : 2] || GClass73.bool_11[Main.isPC ? 22 : 8] || GClass73.bool_11[16])
		{
			GClass73.smethod_26();
			if (!bool_12 || bool_2)
			{
				if (int_6 != 1)
				{
					if (int_6 == 0)
					{
						gclass191_0.bool_0 = true;
						gclass191_1.bool_0 = false;
					}
					else
					{
						gclass191_0.bool_0 = false;
						gclass191_1.bool_0 = false;
					}
				}
				else
				{
					gclass191_0.bool_0 = false;
					gclass191_1.bool_0 = true;
				}
			}
		}
		if (GClass73.bool_5)
		{
			if (bool_2)
			{
				gclass87_1 = gclass87_7;
				gclass87_0 = gclass87_9;
			}
			else
			{
				gclass87_1 = gclass87_11;
				gclass87_0 = gclass87_6;
			}
		}
		else if (bool_2)
		{
			gclass87_1 = gclass87_7;
			gclass87_0 = gclass87_9;
		}
		else
		{
			gclass87_1 = gclass87_11;
			gclass87_0 = gclass87_6;
		}
		if (GClass73.bool_16 && (!bool_12 || bool_2))
		{
			if (GClass73.smethod_24(gclass191_0.int_0, gclass191_0.int_1, gclass191_0.int_2, gclass191_0.int_3))
				int_6 = 0;
			else if (GClass73.smethod_24(gclass191_1.int_0, gclass191_1.int_1, gclass191_1.int_2, gclass191_1.int_3))
			{
				int_6 = 1;
			}
		}
		if (Main.isPC && GClass73.bool_11[Main.isPC ? 25 : 5] && gclass87_2 != null)
			gclass87_2.method_1();
		base.updateKey();
		GClass73.smethod_26();
	}

	public void method_13()
	{
		int_8 = -50;
	}

	public void perform(int idAction, object p)
	{
		if (idAction > 2008)
		{
			if (idAction <= 10021)
			{
				if (idAction != 4000)
				{
					if (idAction == 10021)
						method_14();
				}
				else
					method_4(gclass191_0.method_21());
			}
			else if (idAction != 10041)
			{
				if (idAction == 10042)
				{
					GClass1.smethod_9("lowGraphic", 1);
					GClass73.smethod_34(mResources.plsRestartGame, 8885, null);
				}
			}
			else
			{
				GClass1.smethod_9("lowGraphic", 0);
				GClass73.smethod_34(mResources.plsRestartGame, 8885, null);
			}
		}
		else if (idAction != 13)
		{
			switch (idAction)
			{
			case 1000:
				try
				{
					GClass187.gclass187_0.method_3((string)p);
				}
				catch (Exception)
				{
				}
				GClass73.smethod_29();
				return;
			case 1001:
				GClass73.smethod_29();
				bool_2 = false;
				return;
			case 1002:
			{
				GClass73.smethod_33();
				string text = GClass1.smethod_2("userAo" + GClass134.int_14);
				if (text != null && !text.Equals(""))
				{
					GClass73.gclass133_0.bool_12 = true;
					GClass73.smethod_4();
					GClass7.smethod_0().method_34();
					GClass7.smethod_0().method_38(text, "", GClass187.string_2, 1);
				}
				else
					GClass7.smethod_0().method_122("");
				return;
			}
			case 1003:
				GClass73.smethod_30(mResources.goToWebForPassword);
				return;
			case 1004:
				GClass134.smethod_3();
				GClass73.gclass134_0.switchToMe();
				return;
			case 1005:
				try
				{
					GClass187.gclass187_0.method_3("http://ngocrongonline.com");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			switch (idAction)
			{
			case 2001:
				if (bool_1)
					bool_1 = false;
				else
					bool_1 = true;
				break;
			case 2002:
				method_3();
				break;
			case 2003:
				method_2();
				break;
			case 2004:
				method_15();
				break;
			case 2008:
				GClass1.smethod_4("acc", gclass191_0.method_21().Trim());
				GClass1.smethod_4("pass", gclass191_1.method_21().Trim());
				if (GClass134.bool_6)
					GClass73.gclass134_0.switchToMe();
				else
					GClass73.gclass134_0.method_7();
				break;
			case 2005:
			case 2006:
			case 2007:
				break;
			}
		}
		else
		{
			switch (GClass203.int_0)
			{
			case 1:
				GClass203.smethod_8();
				break;
			case 4:
				GClass203.smethod_7();
				break;
			case 3:
			case 5:
				GClass203.smethod_9();
				break;
			case 6:
				GClass203.smethod_10();
				break;
			case 2:
				break;
			}
		}
	}

	public void method_14()
	{
		if (bool_12)
		{
			method_9();
			return;
		}
		bool_2 = false;
		gclass191_1.bool_0 = false;
		gclass191_0.bool_0 = true;
		gclass87_0 = gclass87_8;
	}

	public void method_15()
	{
		GClass73.smethod_29();
		bool_2 = true;
		gclass191_1.bool_0 = false;
		gclass191_0.bool_0 = true;
	}

	public void method_16()
	{
		GClass73.long_6 = GClass203.smethod_18() + 30000L;
		GClass134.int_11 = 0;
		if (!GClass73.gclass133_0.bool_12)
		{
			if (Main.isWindowsPhone)
				GClass187.bool_1 = true;
			GClass73.gclass73_0.bool_33 = false;
			GClass73.gclass73_0.method_9(GClass73.gclass133_0);
		}
		else
			GClass73.smethod_36(mResources.note, new GClass87(mResources.YES, GClass73.gclass76_0, 10019, null), new GClass87(mResources.NO, GClass73.gclass76_0, 10020, null));
	}
}
