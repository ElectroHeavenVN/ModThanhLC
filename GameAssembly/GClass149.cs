using System;

public class GClass149 : GClass145, GInterface0
{
	public GClass67 gclass67_0;

	public GClass67 gclass67_1;

	public static bool bool_0 = false;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	public bool bool_1;

	public bool bool_2;

	public GClass14 gclass14_4;

	public GClass14 gclass14_5;

	public GClass14 gclass14_6;

	public GClass14 gclass14_7;

	public GClass14 gclass14_8;

	public GClass14 gclass14_9;

	public string string_0 = string.Empty;

	public string string_1;

	public string string_2;

	private string string_3 = string.Empty;

	public static bool bool_3 = false;

	public static bool bool_4;

	public static bool bool_5;

	public static bool bool_6;

	public static bool bool_7;

	public static bool bool_8;

	public static string string_4;

	public static GClass2 gclass2_0;

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

	private GClass14 gclass14_10;

	private GClass14 gclass14_11;

	private int int_19;

	private int int_20;

	public static GClass113 gclass113_0;

	private int int_21 = GClass39.int_13 - GClass145.int_0 - 5;

	private int int_22;

	private int int_23;

	private int PdsNchOgp3;

	private int int_24;

	private int int_25;

	private int int_26 = 20;

	private bool bool_10;

	private string string_5 = string.Empty;

	public bool bool_11;

	private int int_27 = -1;

	public bool bool_12;

	private int int_28 = 2;

	private int int_29;

	private int int_30 = -40;

	private int int_31 = 1;

	private GClass14 gclass14_12;

	public static bool bool_13;

	public GClass149()
	{
		int_20 = GClass39.int_13 - 30;
		GClass1.int_40 = (sbyte)(GClass138.smethod_18() % 9L);
		if (GClass1.int_40 == 5 || GClass1.int_40 == 6)
			GClass1.int_40 = 4;
		GClass154.smethod_10(true, -1, -1);
		GClass154.int_22 = 100;
		GClass154.int_23 = 200;
		Main.closeKeyBoard();
		if (GClass39.int_11 > 200)
			int_9 = GClass39.int_13 - 80;
		else
			int_9 = GClass39.int_13 - 65;
		method_13();
		int_7 = ((GClass39.int_10 < 200) ? 140 : 160);
		int_18 = GClass39.int_13 - GClass145.int_0 - 5;
		if (GClass39.int_11 <= 160)
			int_18 = 20;
		gclass67_0 = new GClass67();
		gclass67_0.int_1 = GClass39.int_13 - GClass145.int_0 - 9;
		gclass67_0.int_2 = int_7;
		gclass67_0.int_3 = GClass145.int_0 + 2;
		gclass67_0.bool_0 = true;
		gclass67_0.method_28(GClass67.int_11);
		gclass67_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
		gclass67_1 = new GClass67();
		gclass67_1.int_1 = GClass39.int_13 - 4;
		gclass67_1.method_28(GClass67.int_13);
		gclass67_1.int_2 = int_7;
		gclass67_1.int_3 = GClass145.int_0 + 2;
		int_18 += 35;
		bool_1 = true;
		int num = GClass120.smethod_8("check");
		if (num != 1)
		{
			if (num == 2)
				bool_1 = false;
		}
		else
			bool_1 = true;
		gclass67_0.method_23(GClass120.smethod_2("acc"));
		gclass67_1.method_23(GClass120.smethod_2("pass"));
		if (gclass14_12 == null)
		{
			gclass14_12 = new GClass14("Gọi hotline", this, 13, null);
			gclass14_12.int_1 = GClass39.int_10 - 75;
			if (GClass138.int_0 == 1 && !GClass39.bool_5)
				gclass14_12.int_2 = GClass39.int_11 - 20;
			else
				gclass14_12.int_2 = 8;
		}
		int_6 = 0;
		gclass14_4 = new GClass14((GClass39.int_10 <= 200) ? mResources.login2 : mResources.login, GClass39.gclass39_0, 888393, null);
		gclass14_5 = new GClass14(mResources.remember, this, 2001, null);
		gclass14_7 = new GClass14(mResources.register, this, 2002, null);
		gclass14_9 = new GClass14(mResources.CANCEL, this, 10021, null);
		gclass14_0 = (gclass14_8 = new GClass14(mResources.MENU, this, 2003, null));
		int_22 = gclass67_0.int_1 - 2 * gclass67_0.int_3;
		if (GClass39.bool_5)
		{
			gclass14_4.int_1 = GClass39.int_10 / 2 + 8;
			gclass14_8.int_1 = GClass39.int_10 / 2 - GClass145.int_2 - 8;
			if (GClass39.int_11 >= 200)
			{
				gclass14_4.int_2 = int_20 + 110;
				gclass14_8.int_2 = int_20 + 110;
			}
			gclass14_9.int_1 = GClass39.int_10 / 2 + 3;
			gclass14_9.int_2 = int_20 + 110;
			gclass14_7.int_1 = GClass39.int_10 / 2 - 84;
			gclass14_7.int_2 = gclass14_8.int_2;
		}
		int_24 = 170;
		int_25 = ((!bool_2) ? 100 : 110);
		int_23 = GClass39.int_12 - int_24 / 2;
		PdsNchOgp3 = gclass67_0.int_1 - 15;
		int num2 = 4;
		int num3 = 184;
		if (184 >= GClass39.int_10)
			num3 = (num2 - 1) * 32 + 23 + 33;
		int_19 = GClass39.int_10 / 2 - num3 / 2;
		int_20 = GClass39.int_13 - 30;
		int_12 = ((GClass39.int_10 < 200) ? (gclass67_0.int_1 - 30) : (int_20 - 30));
		gclass67_0.int_0 = int_19 + 10;
		gclass67_0.int_1 = int_20 + 20;
		gclass14_11 = new GClass14(mResources.OK, this, 2008, null);
		gclass14_11.int_1 = GClass39.int_10 / 2 - 84;
		gclass14_11.int_2 = gclass14_4.int_2;
		gclass14_6 = new GClass14(mResources.forgetPass, this, 1003, null);
		gclass14_6.int_1 = GClass39.int_10 / 2 + 3;
		gclass14_6.int_2 = gclass14_4.int_2;
		gclass14_1 = gclass14_11;
		gclass14_0 = gclass14_6;
	}

	public static void smethod_2()
	{
		try
		{
			if (bool_9)
				return;
			GClass14 gClass = new GClass14();
			gClass.gdelegate1_0 = delegate(string str)
			{
				try
				{
					if (str != null && !(str == string.Empty))
					{
						GClass120.smethod_19(str);
						if (str.Contains(":"))
						{
							int num = str.IndexOf(":");
							string host = str.Substring(0, num);
							string s = str.Substring(num + 1);
							GClass113.string_0 = host;
							GClass113.int_0 = int.Parse(s);
							GClass162.smethod_0().connect(host, int.Parse(s));
							bool_9 = true;
						}
					}
				}
				catch (Exception)
				{
				}
			};
			Class11.smethod_1(GClass152.string_8, gClass);
		}
		catch (Exception)
		{
		}
	}

	public override void switchToMe()
	{
		bool_10 = false;
		GClass29.smethod_1().method_51();
		gclass67_0.bool_0 = true;
		gclass67_1.bool_0 = false;
		if (GClass39.bool_5)
			gclass67_0.bool_0 = false;
		GClass39.smethod_21(0);
		base.switchToMe();
	}

	public void method_0()
	{
		string text = GClass120.smethod_2("acc");
		if (text != null && !text.Equals(string.Empty))
			gclass67_0.method_23(text);
		string text2 = GClass120.smethod_2("pass");
		if (text2 != null && !text2.Equals(string.Empty))
			gclass67_1.method_23(text2);
	}

	public void method_1()
	{
	}

	protected void method_2()
	{
		GClass63 gClass = new GClass63();
		gClass.method_0(new GClass14(mResources.registerNewAcc, this, 2004, null));
		if (!bool_12)
			gClass.method_0(new GClass14(mResources.selectServer, this, 1004, null));
		gClass.method_0(new GClass14(mResources.forgetPass, this, 1003, null));
		gClass.method_0(new GClass14(mResources.website, this, 1005, null));
		if (Main.isPC)
			gClass.method_0(new GClass14(mResources.EXIT, GClass39.gclass39_0, 8885, null));
		GClass39.gclass0_0.method_2(gClass, 0);
	}

	protected void method_3()
	{
		if (gclass67_0.method_21().Equals(string.Empty))
		{
			GClass39.smethod_30(mResources.userBlank);
			return;
		}
		gclass67_0.method_21().ToCharArray();
		if (gclass67_1.method_21().Equals(string.Empty))
		{
			GClass39.smethod_30(mResources.passwordBlank);
			return;
		}
		if (gclass67_0.method_21().Length < 5)
		{
			GClass39.smethod_30(mResources.accTooShort);
			return;
		}
		int num = 0;
		string text = null;
		if (mResources.language == 2)
		{
			if (gclass67_0.method_21().IndexOf("@") == -1 || gclass67_0.method_21().IndexOf(".") == -1)
				text = mResources.emailInvalid;
			num = 0;
		}
		else
			try
			{
				long.Parse(gclass67_0.method_21());
				if (gclass67_0.method_21().Length < 8 || gclass67_0.method_21().Length > 12 || (!gclass67_0.method_21().StartsWith("0") && !gclass67_0.method_21().StartsWith("84")))
					text = mResources.phoneInvalid;
				num = 1;
			}
			catch (Exception)
			{
				if (gclass67_0.method_21().IndexOf("@") == -1 || gclass67_0.method_21().IndexOf(".") == -1)
					text = mResources.emailInvalid;
				num = 0;
			}
		if (text != null)
			GClass39.smethod_30(text);
		else
			GClass39.gclass100_0.method_2(mResources.plsCheckAcc + ((num != 1) ? (mResources.email + ": ") : (mResources.phone + ": ")) + gclass67_0.method_21() + "\n" + mResources.password + ": " + gclass67_1.method_21(), new GClass14(mResources.ACCEPT, this, 4000, null), null, new GClass14(mResources.NO, GClass39.gclass39_0, 8882, null));
		GClass39.gclass99_0 = GClass39.gclass100_0;
	}

	protected void method_4(string user)
	{
		bool_11 = false;
		GClass39.smethod_31(mResources.CONNECTING);
		GClass39.smethod_4();
		GClass39.smethod_31(mResources.REGISTERING);
		string_5 = gclass67_1.method_21();
		GClass166.smethod_0().method_39(user, gclass67_1.method_21(), GClass120.smethod_2("userAo" + GClass152.int_14), GClass120.smethod_2("passAo" + GClass152.int_14), GClass113.string_2);
		GClass120.smethod_4("acc", user);
		GClass120.smethod_4("pass", gclass67_1.method_21());
		int_26 = 20;
		bool_10 = true;
	}

	public void method_5()
	{
		if (!string_0.Equals(string.Empty) || !string_0.Equals(string.Empty))
			;
		if (!GClass162.bool_1)
		{
			bool_11 = true;
			GClass39.smethod_4();
		}
		GClass39.smethod_33();
	}

	protected void method_6()
	{
		GClass63 gClass = new GClass63();
		if (bool_3)
			gClass.method_0(new GClass14("Server LOCAL", this, 20004, null));
		gClass.method_0(new GClass14("Server Bokken", this, 20001, null));
		gClass.method_0(new GClass14("Server Shuriken", this, 20002, null));
		gClass.method_0(new GClass14("Server Tessen (mới)", this, 20003, null));
		GClass39.gclass0_0.method_2(gClass, 0);
		if (method_8() != -1 && !GClass39.bool_5)
			GClass39.gclass0_0.int_0 = method_8();
	}

	protected void method_7(int index)
	{
		GClass120.smethod_9("indServer", index);
	}

	protected int method_8()
	{
		return GClass120.smethod_8("indServer");
	}

	public void method_9()
	{
		string text = GClass120.smethod_2("acc");
		string text2 = GClass120.smethod_2("pass");
		if (text != null && !text.Equals(string.Empty))
			bool_12 = false;
		else if (GClass120.smethod_2("userAo" + GClass152.int_14) != null && !GClass120.smethod_2("userAo" + GClass152.int_14).Equals(string.Empty))
		{
			bool_12 = true;
		}
		else
		{
			bool_12 = false;
		}
		if ((text == null || text.Equals(string.Empty)) && bool_12)
		{
			text = GClass120.smethod_2("userAo" + GClass152.int_14);
			text2 = "a";
		}
		if (text == null || text2 == null || GClass113.string_2 == null || text.Equals(string.Empty))
			return;
		if (text2.Equals(string.Empty))
		{
			int_6 = 1;
			gclass67_0.bool_0 = false;
			gclass67_1.bool_0 = true;
			if (!GClass39.bool_5)
				gclass14_2 = gclass67_1.gclass14_0;
			return;
		}
		if (!GClass162.smethod_0().isConnected())
			GClass39.smethod_4();
		GClass56.smethod_8("ccccccc " + text + " " + text2 + " " + GClass113.string_2 + " " + (sbyte)(bool_12 ? 1 : 0));
		GClass166.smethod_0().method_38(text, text2, GClass113.string_2, (sbyte)(bool_12 ? 1 : 0));
		if (GClass162.bool_1)
			GClass39.smethod_33();
		else
			GClass39.smethod_30(mResources.maychutathoacmatsong);
		int_6 = 0;
		if (!bool_12)
			method_14();
		GClass39.long_6 = GClass138.smethod_18() + 30000L;
	}

	public void method_10()
	{
		if (bool_1)
		{
			GClass120.smethod_9("check", 1);
			GClass120.smethod_4("acc", gclass67_0.method_21().ToLower().Trim());
			GClass120.smethod_4("pass", gclass67_1.method_21().ToLower().Trim());
		}
		else
		{
			GClass120.smethod_9("check", 2);
			GClass120.smethod_4("acc", string.Empty);
			GClass120.smethod_4("pass", string.Empty);
		}
	}

	public override void update()
	{
		if (Main.isWindowsPhone && bool_10)
		{
			if (int_26 < 0)
			{
				GClass39.smethod_29();
				GClass162.smethod_0().close();
				GClass39.gclass152_0.switchToMe();
				bool_10 = false;
			}
			else
				int_26--;
		}
		if (short_0 > 0)
		{
			GClass39.smethod_33();
			long_1 = GClass138.smethod_18();
			if (long_1 - long_0 >= 1000L)
			{
				short_0--;
				if (short_0 == 0)
					GClass39.gclass149_0.method_9();
				long_0 = long_1;
			}
		}
		if (bool_12 && !bool_2)
		{
			gclass67_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			gclass67_1.string_7 = mResources.password;
			gclass67_0.bool_7 = false;
			gclass67_1.bool_7 = false;
			gclass67_0.method_17();
			gclass67_1.method_17();
		}
		else
		{
			gclass67_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			gclass67_1.string_7 = mResources.password;
			gclass67_0.method_17();
			gclass67_1.method_17();
		}
		if (GClass111.bool_1)
			GClass76.int_24 = 50;
		for (int i = 0; i < GClass68.gclass63_1.method_2(); i++)
		{
			((GClass68)GClass68.gclass63_1.method_3(i)).update();
		}
		if (bool_4 && !bool_5 && !bool_8 && !bool_6 && !bool_7)
		{
			bool_4 = false;
			GClass138.smethod_26();
			GClass166.smethod_0().method_115();
		}
		GClass154.int_22++;
		if (GClass154.int_22 > GClass39.int_10 * 3 + 100)
			GClass154.int_22 = 100;
		if (GClass70.gclass70_0 != null)
			return;
		GClass39.smethod_8("LGU1", 0);
		GClass39.smethod_8("LGU2", 0);
		GClass39.smethod_8("LGU3", 0);
		method_12();
		GClass39.smethod_8("LGU4", 0);
		GClass39.smethod_8("LGU5", 0);
		if (int_29 >= 0)
		{
			int_30 += int_31 * int_29;
			int_29 += int_31 * int_28;
			if (int_29 <= 0)
				int_31 *= -1;
			if (int_30 > 0)
			{
				int_31 *= -1;
				int_29 -= 2 * int_28;
			}
		}
		GClass39.smethod_8("LGU6", 0);
		if (int_27 >= 0 && GClass39.int_8 % 100 == 0)
			method_11();
		if (bool_12 && !bool_2)
		{
			gclass67_0.bool_7 = false;
			gclass67_1.bool_7 = false;
			gclass67_0.method_17();
			gclass67_1.method_17();
		}
		else
		{
			gclass67_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			gclass67_1.string_7 = mResources.password;
			gclass67_0.method_17();
			gclass67_1.method_17();
		}
		if (GClass39.bool_5)
		{
			if (bool_2)
			{
				gclass14_1 = gclass14_7;
				gclass14_0 = gclass14_9;
			}
			else
			{
				gclass14_1 = gclass14_11;
				gclass14_0 = gclass14_6;
			}
		}
		else if (bool_2)
		{
			gclass14_1 = gclass14_7;
			gclass14_0 = gclass14_9;
		}
		else
		{
			gclass14_1 = gclass14_11;
			gclass14_0 = gclass14_6;
		}
		if (!Main.isPC && !GClass111.bool_1 && !Main.isMiniApp && !Main.isWindowsPhone)
		{
			string text = gclass67_0.method_21().ToLower().Trim();
			string text2 = gclass67_1.method_21().ToLower().Trim();
			if (!text.Equals(string.Empty) && !text2.Equals(string.Empty))
				method_9();
			Main.isMiniApp = true;
		}
		method_1();
	}

	private void method_11()
	{
		int_27++;
		if (int_27 >= mResources.tips.Length)
			int_27 = 0;
		if (GClass39.gclass99_0 == GClass39.gclass100_0 && GClass39.gclass100_0.bool_0)
			GClass39.gclass100_0.method_1(mResources.tips[int_27]);
	}

	public void method_12()
	{
		if (int_9 != int_8)
			int_8 += int_9 - int_8 >> 1;
	}

	public override void keyPress(int keyCode)
	{
		if (gclass67_0.bool_0)
			gclass67_0.method_10(keyCode);
		else if (gclass67_1.bool_0)
		{
			gclass67_1.method_10(keyCode);
		}
		base.keyPress(keyCode);
	}

	public override void unLoad()
	{
		base.unLoad();
	}

	public override void paint(GClass76 g)
	{
		GClass39.smethod_8("PLG1", 1);
		GClass39.smethod_18(g);
		GClass39.smethod_8("PLG2", 2);
		int num = gclass67_0.int_1 - 50;
		if (GClass39.int_11 <= 220)
			num += 5;
		GClass49.gclass49_20.method_10(g, "v" + GClass113.string_2, GClass39.int_10 - 2, 17, 1, GClass49.gclass49_16);
		if (GClass138.int_0 == 1 && !GClass39.bool_5)
			GClass49.gclass49_20.method_10(g, GClass152.string_10, GClass39.int_10 - 2, GClass39.int_11 - 15, 1, GClass49.gclass49_16);
		else
			GClass49.gclass49_20.method_10(g, GClass152.string_10, GClass39.int_10 - 2, 2, 1, GClass49.gclass49_16);
		if (GClass70.gclass70_0 != null || GClass70.gclass70_1 != null)
			return;
		if (GClass39.gclass99_0 == null)
		{
			GClass24.smethod_4(h: 105, w: (GClass39.int_10 < 200) ? 160 : 180, g: g, x: int_19, y: int_20 - 10, color: -1, isButton: true);
			if (GClass39.int_11 > 160 && gclass2_0 != null)
				g.method_31(gclass2_0, GClass39.int_12, num, 3);
			GClass39.smethod_8("PLG4", 1);
			int num2 = 4;
			int num3 = 184;
			if (184 >= GClass39.int_10)
				num3 = (num2 - 1) * 32 + 23 + 33;
			int_19 = GClass39.int_10 / 2 - num3 / 2;
			gclass67_0.int_0 = int_19 + 10;
			gclass67_0.int_1 = int_20 + 20;
			gclass67_1.int_0 = int_19 + 10;
			gclass67_1.int_1 = int_20 + 55;
			gclass67_0.method_13(g);
			gclass67_1.method_13(g);
			if (GClass39.int_10 < 176)
			{
				GClass49.gclass49_7.method_6(g, mResources.acc + ":", gclass67_0.int_0 - 35, gclass67_0.int_1 + 7, 0);
				GClass49.gclass49_7.method_6(g, mResources.pwd + ":", gclass67_1.int_0 - 35, gclass67_1.int_1 + 7, 0);
				GClass49.gclass49_7.method_6(g, mResources.server + ":" + string_4, GClass39.int_10 / 2, gclass67_1.int_1 + 32, 2);
			}
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		if (GClass39.bool_5)
		{
			if (gclass14_12 != null && gclass14_12.method_4())
				gclass14_12.method_1();
		}
		else if (GClass138.int_0 == 1 && GClass39.bool_11[13])
		{
			GClass39.bool_11[13] = false;
			gclass14_12.method_1();
		}
		if (bool_0)
			return;
		if (!GClass39.bool_5)
		{
			if (gclass67_0.bool_0)
				gclass14_2 = gclass67_0.gclass14_0;
			else
				gclass14_2 = gclass67_1.gclass14_0;
		}
		if (GClass39.bool_11[(!Main.isPC) ? 2 : 21])
		{
			int_6--;
			if (int_6 < 0)
				int_6 = 1;
		}
		else if (GClass39.bool_11[(!Main.isPC) ? 8 : 22] || GClass39.bool_11[16])
		{
			int_6++;
			if (int_6 > 1)
				int_6 = 0;
		}
		if (GClass39.bool_11[(!Main.isPC) ? 2 : 21] || GClass39.bool_11[(!Main.isPC) ? 8 : 22] || GClass39.bool_11[16])
		{
			GClass39.smethod_26();
			if (!bool_12 || bool_2)
			{
				if (int_6 == 1)
				{
					gclass67_0.bool_0 = false;
					gclass67_1.bool_0 = true;
				}
				else if (int_6 == 0)
				{
					gclass67_0.bool_0 = true;
					gclass67_1.bool_0 = false;
				}
				else
				{
					gclass67_0.bool_0 = false;
					gclass67_1.bool_0 = false;
				}
			}
		}
		if (GClass39.bool_5)
		{
			if (bool_2)
			{
				gclass14_1 = gclass14_7;
				gclass14_0 = gclass14_9;
			}
			else
			{
				gclass14_1 = gclass14_11;
				gclass14_0 = gclass14_6;
			}
		}
		else if (bool_2)
		{
			gclass14_1 = gclass14_7;
			gclass14_0 = gclass14_9;
		}
		else
		{
			gclass14_1 = gclass14_11;
			gclass14_0 = gclass14_6;
		}
		if (GClass39.bool_16 && (!bool_12 || bool_2))
		{
			if (GClass39.smethod_24(gclass67_0.int_0, gclass67_0.int_1, gclass67_0.int_2, gclass67_0.int_3))
				int_6 = 0;
			else if (GClass39.smethod_24(gclass67_1.int_0, gclass67_1.int_1, gclass67_1.int_2, gclass67_1.int_3))
			{
				int_6 = 1;
			}
		}
		if (Main.isPC && GClass39.bool_11[(!Main.isPC) ? 5 : 25] && gclass14_2 != null)
			gclass14_2.method_1();
		base.updateKey();
		GClass39.smethod_26();
	}

	public void method_13()
	{
		int_8 = -50;
	}

	public void perform(int idAction, object p)
	{
		if (idAction <= 2008)
		{
			if (idAction != 13)
			{
				switch (idAction)
				{
				case 1000:
					try
					{
						GClass113.gclass113_0.method_3((string)p);
					}
					catch (Exception)
					{
					}
					GClass39.smethod_29();
					return;
				case 1001:
					GClass39.smethod_29();
					bool_2 = false;
					return;
				case 1002:
				{
					GClass39.smethod_33();
					string text = GClass120.smethod_2("userAo" + GClass152.int_14);
					if (text == null || text.Equals(string.Empty))
					{
						GClass166.smethod_0().method_122(string.Empty);
						return;
					}
					GClass39.gclass149_0.bool_12 = true;
					GClass39.smethod_4();
					GClass166.smethod_0().method_34();
					GClass166.smethod_0().method_38(text, string.Empty, GClass113.string_2, 1);
					return;
				}
				case 1003:
					GClass39.smethod_30(mResources.goToWebForPassword);
					return;
				case 1004:
					GClass152.smethod_3();
					GClass39.gclass152_0.switchToMe();
					return;
				case 1005:
					try
					{
						GClass113.gclass113_0.method_3("http://ngocrongonline.com");
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
					GClass120.smethod_4("acc", gclass67_0.method_21().Trim());
					GClass120.smethod_4("pass", gclass67_1.method_21().Trim());
					if (GClass152.bool_6)
						GClass39.gclass152_0.switchToMe();
					else
						GClass39.gclass152_0.method_7();
					break;
				case 2005:
				case 2006:
				case 2007:
					break;
				}
			}
			else
			{
				switch (GClass138.int_0)
				{
				case 1:
					GClass138.smethod_8();
					break;
				case 4:
					GClass138.smethod_7();
					break;
				case 3:
				case 5:
					GClass138.smethod_9();
					break;
				case 6:
					GClass138.smethod_10();
					break;
				case 2:
					break;
				}
			}
		}
		else if (idAction <= 10021)
		{
			if (idAction != 4000)
			{
				if (idAction == 10021)
					method_14();
			}
			else
				method_4(gclass67_0.method_21());
		}
		else if (idAction != 10041)
		{
			if (idAction == 10042)
			{
				GClass120.smethod_9("lowGraphic", 1);
				GClass39.smethod_34(mResources.plsRestartGame, 8885, null);
			}
		}
		else
		{
			GClass120.smethod_9("lowGraphic", 0);
			GClass39.smethod_34(mResources.plsRestartGame, 8885, null);
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
		gclass67_1.bool_0 = false;
		gclass67_0.bool_0 = true;
		gclass14_0 = gclass14_8;
	}

	public void method_15()
	{
		GClass39.smethod_29();
		bool_2 = true;
		gclass67_1.bool_0 = false;
		gclass67_0.bool_0 = true;
	}

	public void method_16()
	{
		GClass39.long_6 = GClass138.smethod_18() + 30000L;
		GClass152.int_11 = 0;
		if (GClass39.gclass149_0.bool_12)
		{
			GClass39.smethod_36(mResources.note, new GClass14(mResources.YES, GClass39.gclass45_0, 10019, null), new GClass14(mResources.NO, GClass39.gclass45_0, 10020, null));
			return;
		}
		if (Main.isWindowsPhone)
			GClass113.bool_1 = true;
		GClass39.gclass39_0.bool_33 = false;
		GClass39.gclass39_0.method_9(GClass39.gclass149_0);
	}
}
