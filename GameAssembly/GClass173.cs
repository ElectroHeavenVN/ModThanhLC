using System;
using System.Runtime.CompilerServices;

public class GClass173 : GClass160, GInterface1
{
	public GClass136 gclass136_0;

	public GClass136 gclass136_1;

	public static bool bool_0 = false;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	public bool bool_1;

	public bool bool_2;

	public GClass118 gclass118_4;

	public GClass118 gclass118_5;

	public GClass118 gclass118_6;

	public GClass118 gclass118_7;

	public GClass118 gclass118_8;

	public GClass118 gclass118_9;

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

	public static GClass20 gclass20_0;

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

	private GClass118 gclass118_10;

	private GClass118 gclass118_11;

	private int int_19;

	private int int_20;

	public static GClass206 gclass206_0;

	private int int_21 = GClass14.int_13 - GClass160.int_0 - 5;

	private int int_22;

	private int int_23;

	private int int_24;

	private int int_25;

	private int int_26;

	private int int_27 = 20;

	private bool bool_10;

	private string string_5 = string.Empty;

	public bool bool_11;

	private int int_28 = -1;

	public bool bool_12;

	private int int_29 = 2;

	private int int_30;

	private int int_31 = -40;

	private int int_32 = 1;

	private GClass118 gclass118_12;

	public static bool bool_13;

	public GClass173()
	{
		int_20 = GClass14.int_13 - 30;
		GClass137.int_40 = (sbyte)(GClass77.smethod_18() % 9L);
		if (GClass137.int_40 == 5 || GClass137.int_40 == 6)
			GClass137.int_40 = 4;
		GClass167.smethod_10(true, -1, -1);
		GClass167.int_22 = 100;
		GClass167.int_23 = 200;
		Main.closeKeyBoard();
		if (GClass14.int_11 <= 200)
			int_9 = GClass14.int_13 - 65;
		else
			int_9 = GClass14.int_13 - 80;
		method_13();
		int_7 = ((GClass14.int_10 >= 200) ? 160 : 140);
		int_18 = GClass14.int_13 - GClass160.int_0 - 5;
		if (GClass14.int_11 <= 160)
			int_18 = 20;
		gclass136_0 = new GClass136();
		gclass136_0.int_1 = GClass14.int_13 - GClass160.int_0 - 9;
		gclass136_0.int_2 = int_7;
		gclass136_0.int_3 = GClass160.int_0 + 2;
		gclass136_0.bool_0 = true;
		gclass136_0.method_28(GClass136.int_11);
		gclass136_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
		gclass136_1 = new GClass136();
		gclass136_1.int_1 = GClass14.int_13 - 4;
		gclass136_1.method_28(GClass136.int_13);
		gclass136_1.int_2 = int_7;
		gclass136_1.int_3 = GClass160.int_0 + 2;
		int_18 += 35;
		bool_1 = true;
		int num = GClass141.smethod_8("check");
		if (num != 1)
		{
			if (num == 2)
				bool_1 = false;
		}
		else
			bool_1 = true;
		gclass136_0.method_23(GClass141.smethod_2("acc"));
		gclass136_1.method_23(GClass141.smethod_2("pass"));
		if (gclass118_12 == null)
		{
			gclass118_12 = new GClass118("Gọi hotline", this, 13, null);
			gclass118_12.int_1 = GClass14.int_10 - 75;
			if (GClass77.int_0 == 1 && !GClass14.bool_5)
				gclass118_12.int_2 = GClass14.int_11 - 20;
			else
				gclass118_12.int_2 = 8;
		}
		int_6 = 0;
		gclass118_4 = new GClass118((GClass14.int_10 > 200) ? mResources.login : mResources.login2, GClass14.gclass14_0, 888393, null);
		gclass118_5 = new GClass118(mResources.remember, this, 2001, null);
		gclass118_7 = new GClass118(mResources.register, this, 2002, null);
		gclass118_9 = new GClass118(mResources.CANCEL, this, 10021, null);
		gclass118_0 = (gclass118_8 = new GClass118(mResources.MENU, this, 2003, null));
		int_22 = gclass136_0.int_1 - 2 * gclass136_0.int_3;
		if (GClass14.bool_5)
		{
			gclass118_4.int_1 = GClass14.int_10 / 2 + 8;
			gclass118_8.int_1 = GClass14.int_10 / 2 - GClass160.int_2 - 8;
			if (GClass14.int_11 >= 200)
			{
				gclass118_4.int_2 = int_20 + 110;
				gclass118_8.int_2 = int_20 + 110;
			}
			gclass118_9.int_1 = GClass14.int_10 / 2 + 3;
			gclass118_9.int_2 = int_20 + 110;
			gclass118_7.int_1 = GClass14.int_10 / 2 - 84;
			gclass118_7.int_2 = gclass118_8.int_2;
		}
		int_25 = 170;
		int_26 = (bool_2 ? 110 : 100);
		int_23 = GClass14.int_12 - int_25 / 2;
		int_24 = gclass136_0.int_1 - 15;
		int num2 = 4;
		int num3 = 184;
		if (184 >= GClass14.int_10)
			num3 = (num2 - 1) * 32 + 23 + 33;
		int_19 = GClass14.int_10 / 2 - num3 / 2;
		int_20 = GClass14.int_13 - 30;
		int_12 = ((GClass14.int_10 < 200) ? (gclass136_0.int_1 - 30) : (int_20 - 30));
		gclass136_0.int_0 = int_19 + 10;
		gclass136_0.int_1 = int_20 + 20;
		gclass118_11 = new GClass118(mResources.OK, this, 2008, null);
		gclass118_11.int_1 = GClass14.int_10 / 2 - 84;
		gclass118_11.int_2 = gclass118_4.int_2;
		gclass118_6 = new GClass118(mResources.forgetPass, this, 1003, null);
		gclass118_6.int_1 = GClass14.int_10 / 2 + 3;
		gclass118_6.int_2 = gclass118_4.int_2;
		gclass118_1 = gclass118_11;
		gclass118_0 = gclass118_6;
	}

	public static void smethod_2()
	{
		try
		{
			if (bool_9)
				return;
			GClass118 gClass = new GClass118();
			gClass.gdelegate0_0 = delegate(string str)
			{
				try
				{
					if (str != null && !(str == string.Empty))
					{
						GClass141.smethod_19(str);
						if (str.Contains(":"))
						{
							int num = str.IndexOf(":");
							string host = str.Substring(0, num);
							string s = str.Substring(num + 1);
							GClass206.string_0 = host;
							GClass206.int_0 = int.Parse(s);
							GClass179.smethod_0().connect(host, int.Parse(s));
							bool_9 = true;
						}
					}
				}
				catch (Exception)
				{
				}
			};
			Class18.smethod_1(GClass170.string_8, gClass);
		}
		catch (Exception)
		{
		}
	}

	public override void switchToMe()
	{
		bool_10 = false;
		GClass147.smethod_1().method_51();
		gclass136_0.bool_0 = true;
		gclass136_1.bool_0 = false;
		if (GClass14.bool_5)
			gclass136_0.bool_0 = false;
		GClass14.smethod_21(0);
		base.switchToMe();
	}

	public void method_0()
	{
		string text = GClass141.smethod_2("acc");
		if (text != null && !text.Equals(string.Empty))
			gclass136_0.method_23(text);
		string text2 = GClass141.smethod_2("pass");
		if (text2 != null && !text2.Equals(string.Empty))
			gclass136_1.method_23(text2);
	}

	public void method_1()
	{
	}

	protected void method_2()
	{
		GClass122 gClass = new GClass122();
		gClass.method_0(new GClass118(mResources.registerNewAcc, this, 2004, null));
		if (!bool_12)
			gClass.method_0(new GClass118(mResources.selectServer, this, 1004, null));
		gClass.method_0(new GClass118(mResources.forgetPass, this, 1003, null));
		gClass.method_0(new GClass118(mResources.website, this, 1005, null));
		if (Main.isPC)
			gClass.method_0(new GClass118(mResources.EXIT, GClass14.gclass14_0, 8885, null));
		GClass14.gclass116_0.method_2(gClass, 0);
	}

	protected void method_3()
	{
		if (!gclass136_0.method_21().Equals(string.Empty))
		{
			gclass136_0.method_21().ToCharArray();
			if (!gclass136_1.method_21().Equals(string.Empty))
			{
				if (gclass136_0.method_21().Length >= 5)
				{
					int num = 0;
					string text = null;
					if (mResources.language == 2)
					{
						if (gclass136_0.method_21().IndexOf("@") == -1 || gclass136_0.method_21().IndexOf(".") == -1)
							text = mResources.emailInvalid;
						num = 0;
					}
					else
						try
						{
							long.Parse(gclass136_0.method_21());
							if (gclass136_0.method_21().Length < 8 || gclass136_0.method_21().Length > 12 || (!gclass136_0.method_21().StartsWith("0") && !gclass136_0.method_21().StartsWith("84")))
								text = mResources.phoneInvalid;
							num = 1;
						}
						catch (Exception)
						{
							if (gclass136_0.method_21().IndexOf("@") == -1 || gclass136_0.method_21().IndexOf(".") == -1)
								text = mResources.emailInvalid;
							num = 0;
						}
					if (text == null)
						GClass14.gclass185_0.method_2(mResources.plsCheckAcc + ((num != 1) ? (mResources.email + ": ") : (mResources.phone + ": ")) + gclass136_0.method_21() + "\n" + mResources.password + ": " + gclass136_1.method_21(), new GClass118(mResources.ACCEPT, this, 4000, null), null, new GClass118(mResources.NO, GClass14.gclass14_0, 8882, null));
					else
						GClass14.smethod_30(text);
					GClass14.gclass183_0 = GClass14.gclass185_0;
				}
				else
					GClass14.smethod_30(mResources.accTooShort);
			}
			else
				GClass14.smethod_30(mResources.passwordBlank);
		}
		else
			GClass14.smethod_30(mResources.userBlank);
	}

	protected void method_4(string user)
	{
		bool_11 = false;
		GClass14.smethod_31(mResources.CONNECTING);
		GClass14.smethod_4();
		GClass14.smethod_31(mResources.REGISTERING);
		string_5 = gclass136_1.method_21();
		GClass2.smethod_0().method_39(user, gclass136_1.method_21(), GClass141.smethod_2("userAo" + GClass170.int_14), GClass141.smethod_2("passAo" + GClass170.int_14), GClass206.string_2);
		GClass141.smethod_4("acc", user);
		GClass141.smethod_4("pass", gclass136_1.method_21());
		int_27 = 20;
		bool_10 = true;
	}

	public void method_5()
	{
		if (!string_0.Equals(string.Empty) || !string_0.Equals(string.Empty))
			;
		if (!GClass179.bool_1)
		{
			bool_11 = true;
			GClass14.smethod_4();
		}
		GClass14.smethod_33();
	}

	protected void method_6()
	{
		GClass122 gClass = new GClass122();
		if (bool_3)
			gClass.method_0(new GClass118("Server LOCAL", this, 20004, null));
		gClass.method_0(new GClass118("Server Bokken", this, 20001, null));
		gClass.method_0(new GClass118("Server Shuriken", this, 20002, null));
		gClass.method_0(new GClass118("Server Tessen (mới)", this, 20003, null));
		GClass14.gclass116_0.method_2(gClass, 0);
		if (method_8() != -1 && !GClass14.bool_5)
			GClass14.gclass116_0.int_0 = method_8();
	}

	protected void method_7(int index)
	{
		GClass141.smethod_9("indServer", index);
	}

	protected int method_8()
	{
		return GClass141.smethod_8("indServer");
	}

	public void method_9()
	{
		string text = GClass141.smethod_2("acc");
		string text2 = GClass141.smethod_2("pass");
		if (text != null && !text.Equals(string.Empty))
			bool_12 = false;
		else if (GClass141.smethod_2("userAo" + GClass170.int_14) == null || GClass141.smethod_2("userAo" + GClass170.int_14).Equals(string.Empty))
		{
			bool_12 = false;
		}
		else
		{
			bool_12 = true;
		}
		if ((text == null || text.Equals(string.Empty)) && bool_12)
		{
			text = GClass141.smethod_2("userAo" + GClass170.int_14);
			text2 = "a";
		}
		if (text == null || text2 == null || GClass206.string_2 == null || text.Equals(string.Empty))
			return;
		if (text2.Equals(string.Empty))
		{
			int_6 = 1;
			gclass136_0.bool_0 = false;
			gclass136_1.bool_0 = true;
			if (!GClass14.bool_5)
				gclass118_2 = gclass136_1.gclass118_0;
			return;
		}
		if (!GClass179.smethod_0().isConnected())
			GClass14.smethod_4();
		GClass191.smethod_8("ccccccc " + text + " " + text2 + " " + GClass206.string_2 + " " + (sbyte)(bool_12 ? 1 : 0));
		GClass2.smethod_0().method_38(text, text2, GClass206.string_2, (sbyte)(bool_12 ? 1 : 0));
		if (!GClass179.bool_1)
			GClass14.smethod_30(mResources.maychutathoacmatsong);
		else
			GClass14.smethod_33();
		int_6 = 0;
		if (!bool_12)
			method_14();
		GClass14.long_6 = GClass77.smethod_18() + 30000L;
	}

	public void method_10()
	{
		if (bool_1)
		{
			GClass141.smethod_9("check", 1);
			GClass141.smethod_4("acc", gclass136_0.method_21().ToLower().Trim());
			GClass141.smethod_4("pass", gclass136_1.method_21().ToLower().Trim());
		}
		else
		{
			GClass141.smethod_9("check", 2);
			GClass141.smethod_4("acc", string.Empty);
			GClass141.smethod_4("pass", string.Empty);
		}
	}

	public override void update()
	{
		if (Main.isWindowsPhone && bool_10)
		{
			if (int_27 < 0)
			{
				GClass14.smethod_29();
				GClass179.smethod_0().close();
				GClass14.gclass170_0.switchToMe();
				bool_10 = false;
			}
			else
				int_27--;
		}
		if (short_0 > 0)
		{
			GClass14.smethod_33();
			long_1 = GClass77.smethod_18();
			if (long_1 - long_0 >= 1000L)
			{
				short_0--;
				if (short_0 == 0)
					GClass14.gclass173_0.method_9();
				long_0 = long_1;
			}
		}
		if (bool_12 && !bool_2)
		{
			gclass136_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			gclass136_1.string_7 = mResources.password;
			gclass136_0.bool_7 = false;
			gclass136_1.bool_7 = false;
			gclass136_0.method_17();
			gclass136_1.method_17();
		}
		else
		{
			gclass136_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			gclass136_1.string_7 = mResources.password;
			gclass136_0.method_17();
			gclass136_1.method_17();
		}
		if (GClass196.bool_1)
			GClass193.int_24 = 50;
		for (int i = 0; i < GClass86.gclass122_1.method_2(); i++)
		{
			((GClass86)GClass86.gclass122_1.method_3(i)).update();
		}
		if (bool_4 && !bool_5 && !bool_8 && !bool_6 && !bool_7)
		{
			bool_4 = false;
			GClass77.smethod_26();
			GClass2.smethod_0().method_115();
		}
		GClass167.int_22++;
		if (GClass167.int_22 > GClass14.int_10 * 3 + 100)
			GClass167.int_22 = 100;
		if (GClass88.gclass88_0 != null)
			return;
		GClass14.smethod_8("LGU1", 0);
		GClass14.smethod_8("LGU2", 0);
		GClass14.smethod_8("LGU3", 0);
		method_12();
		GClass14.smethod_8("LGU4", 0);
		GClass14.smethod_8("LGU5", 0);
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
		GClass14.smethod_8("LGU6", 0);
		if (int_28 >= 0 && GClass14.int_8 % 100 == 0)
			method_11();
		if (!bool_12 || bool_2)
		{
			gclass136_0.string_7 = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			gclass136_1.string_7 = mResources.password;
			gclass136_0.method_17();
			gclass136_1.method_17();
		}
		else
		{
			gclass136_0.bool_7 = false;
			gclass136_1.bool_7 = false;
			gclass136_0.method_17();
			gclass136_1.method_17();
		}
		if (!GClass14.bool_5)
		{
			if (!bool_2)
			{
				gclass118_1 = gclass118_11;
				gclass118_0 = gclass118_6;
			}
			else
			{
				gclass118_1 = gclass118_7;
				gclass118_0 = gclass118_9;
			}
		}
		else if (!bool_2)
		{
			gclass118_1 = gclass118_11;
			gclass118_0 = gclass118_6;
		}
		else
		{
			gclass118_1 = gclass118_7;
			gclass118_0 = gclass118_9;
		}
		if (!Main.isPC && !GClass196.bool_1 && !Main.isMiniApp && !Main.isWindowsPhone)
		{
			string text = gclass136_0.method_21().ToLower().Trim();
			string text2 = gclass136_1.method_21().ToLower().Trim();
			if (!text.Equals(string.Empty) && !text2.Equals(string.Empty))
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
		if (GClass14.gclass183_0 == GClass14.gclass185_0 && GClass14.gclass185_0.bool_0)
			GClass14.gclass185_0.method_1(mResources.tips[int_28]);
	}

	public void method_12()
	{
		if (int_9 != int_8)
			int_8 += int_9 - int_8 >> 1;
	}

	public override void keyPress(int keyCode)
	{
		if (!gclass136_0.bool_0)
		{
			if (gclass136_1.bool_0)
				gclass136_1.method_10(keyCode);
		}
		else
			gclass136_0.method_10(keyCode);
		base.keyPress(keyCode);
	}

	public override void unLoad()
	{
		base.unLoad();
	}

	public override void paint(GClass193 g)
	{
		GClass14.smethod_8("PLG1", 1);
		GClass14.smethod_18(g);
		GClass14.smethod_8("PLG2", 2);
		int num = gclass136_0.int_1 - 50;
		if (GClass14.int_11 <= 220)
			num += 5;
		GClass104.gclass104_20.method_10(g, "v" + GClass206.string_2, GClass14.int_10 - 2, 17, 1, GClass104.gclass104_16);
		if (GClass77.int_0 == 1 && !GClass14.bool_5)
			GClass104.gclass104_20.method_10(g, GClass170.string_10, GClass14.int_10 - 2, GClass14.int_11 - 15, 1, GClass104.gclass104_16);
		else
			GClass104.gclass104_20.method_10(g, GClass170.string_10, GClass14.int_10 - 2, 2, 1, GClass104.gclass104_16);
		if (GClass88.gclass88_0 != null || GClass88.gclass88_1 != null)
			return;
		if (GClass14.gclass183_0 == null)
		{
			int h = 105;
			int w = ((GClass14.int_10 < 200) ? 160 : 180);
			GClass139.smethod_4(g, int_19, int_20 - 10, w, h, -1, true);
			if (GClass14.int_11 > 160 && gclass20_0 != null)
				g.method_31(gclass20_0, GClass14.int_12, num, 3);
			GClass14.smethod_8("PLG4", 1);
			int num2 = 4;
			int num3 = 184;
			if (184 >= GClass14.int_10)
				num3 = (num2 - 1) * 32 + 23 + 33;
			int_19 = GClass14.int_10 / 2 - num3 / 2;
			gclass136_0.int_0 = int_19 + 10;
			gclass136_0.int_1 = int_20 + 20;
			gclass136_1.int_0 = int_19 + 10;
			gclass136_1.int_1 = int_20 + 55;
			gclass136_0.method_13(g);
			gclass136_1.method_13(g);
			if (GClass14.int_10 < 176)
			{
				GClass104.gclass104_7.method_6(g, mResources.acc + ":", gclass136_0.int_0 - 35, gclass136_0.int_1 + 7, 0);
				GClass104.gclass104_7.method_6(g, mResources.pwd + ":", gclass136_1.int_0 - 35, gclass136_1.int_1 + 7, 0);
				GClass104.gclass104_7.method_6(g, mResources.server + ":" + string_4, GClass14.int_10 / 2, gclass136_1.int_1 + 32, 2);
			}
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		if (!GClass14.bool_5)
		{
			if (GClass77.int_0 == 1 && GClass14.bool_11[13])
			{
				GClass14.bool_11[13] = false;
				gclass118_12.method_1();
			}
		}
		else if (gclass118_12 != null && gclass118_12.method_4())
		{
			gclass118_12.method_1();
		}
		if (bool_0)
			return;
		if (!GClass14.bool_5)
		{
			if (!gclass136_0.bool_0)
				gclass118_2 = gclass136_1.gclass118_0;
			else
				gclass118_2 = gclass136_0.gclass118_0;
		}
		if (GClass14.bool_11[(!Main.isPC) ? 2 : 21])
		{
			int_6--;
			if (int_6 < 0)
				int_6 = 1;
		}
		else if (GClass14.bool_11[(!Main.isPC) ? 8 : 22] || GClass14.bool_11[16])
		{
			int_6++;
			if (int_6 > 1)
				int_6 = 0;
		}
		if (GClass14.bool_11[(!Main.isPC) ? 2 : 21] || GClass14.bool_11[Main.isPC ? 22 : 8] || GClass14.bool_11[16])
		{
			GClass14.smethod_26();
			if (!bool_12 || bool_2)
			{
				if (int_6 != 1)
				{
					if (int_6 != 0)
					{
						gclass136_0.bool_0 = false;
						gclass136_1.bool_0 = false;
					}
					else
					{
						gclass136_0.bool_0 = true;
						gclass136_1.bool_0 = false;
					}
				}
				else
				{
					gclass136_0.bool_0 = false;
					gclass136_1.bool_0 = true;
				}
			}
		}
		if (GClass14.bool_5)
		{
			if (!bool_2)
			{
				gclass118_1 = gclass118_11;
				gclass118_0 = gclass118_6;
			}
			else
			{
				gclass118_1 = gclass118_7;
				gclass118_0 = gclass118_9;
			}
		}
		else if (!bool_2)
		{
			gclass118_1 = gclass118_11;
			gclass118_0 = gclass118_6;
		}
		else
		{
			gclass118_1 = gclass118_7;
			gclass118_0 = gclass118_9;
		}
		if (GClass14.bool_16 && (!bool_12 || bool_2))
		{
			if (GClass14.smethod_24(gclass136_0.int_0, gclass136_0.int_1, gclass136_0.int_2, gclass136_0.int_3))
				int_6 = 0;
			else if (GClass14.smethod_24(gclass136_1.int_0, gclass136_1.int_1, gclass136_1.int_2, gclass136_1.int_3))
			{
				int_6 = 1;
			}
		}
		if (Main.isPC && GClass14.bool_11[Main.isPC ? 25 : 5] && gclass118_2 != null)
			gclass118_2.method_1();
		base.updateKey();
		GClass14.smethod_26();
	}

	public void method_13()
	{
		int_8 = -50;
	}

	public void perform(int idAction, object p)
	{
		if (idAction > 2008)
		{
			if (idAction > 10021)
			{
				if (idAction != 10041)
				{
					if (idAction == 10042)
					{
						GClass141.smethod_9("lowGraphic", 1);
						GClass14.smethod_34(mResources.plsRestartGame, 8885, null);
					}
				}
				else
				{
					GClass141.smethod_9("lowGraphic", 0);
					GClass14.smethod_34(mResources.plsRestartGame, 8885, null);
				}
			}
			else if (idAction != 4000)
			{
				if (idAction == 10021)
					method_14();
			}
			else
			{
				method_4(gclass136_0.method_21());
			}
		}
		else if (idAction != 13)
		{
			switch (idAction)
			{
			case 1000:
				try
				{
					GClass206.gclass206_0.method_3((string)p);
				}
				catch (Exception)
				{
				}
				GClass14.smethod_29();
				return;
			case 1001:
				GClass14.smethod_29();
				bool_2 = false;
				return;
			case 1002:
			{
				GClass14.smethod_33();
				string text = GClass141.smethod_2("userAo" + GClass170.int_14);
				if (text != null && !text.Equals(string.Empty))
				{
					GClass14.gclass173_0.bool_12 = true;
					GClass14.smethod_4();
					GClass2.smethod_0().method_34();
					GClass2.smethod_0().method_38(text, string.Empty, GClass206.string_2, 1);
				}
				else
					GClass2.smethod_0().method_122(string.Empty);
				return;
			}
			case 1003:
				GClass14.smethod_30(mResources.goToWebForPassword);
				return;
			case 1004:
				GClass170.smethod_3();
				GClass14.gclass170_0.switchToMe();
				return;
			case 1005:
				try
				{
					GClass206.gclass206_0.method_3("http://ngocrongonline.com");
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
				GClass141.smethod_4("acc", gclass136_0.method_21().Trim());
				GClass141.smethod_4("pass", gclass136_1.method_21().Trim());
				if (GClass170.bool_6)
					GClass14.gclass170_0.switchToMe();
				else
					GClass14.gclass170_0.method_7();
				break;
			case 2005:
			case 2006:
			case 2007:
				break;
			}
		}
		else
		{
			switch (GClass77.int_0)
			{
			case 1:
				GClass77.smethod_8();
				break;
			case 4:
				GClass77.smethod_7();
				break;
			case 3:
			case 5:
				GClass77.smethod_9();
				break;
			case 6:
				GClass77.smethod_10();
				break;
			case 2:
				break;
			}
		}
	}

	public void method_14()
	{
		if (!bool_12)
		{
			bool_2 = false;
			gclass136_1.bool_0 = false;
			gclass136_0.bool_0 = true;
			gclass118_0 = gclass118_8;
		}
		else
			method_9();
	}

	public void method_15()
	{
		GClass14.smethod_29();
		bool_2 = true;
		gclass136_1.bool_0 = false;
		gclass136_0.bool_0 = true;
	}

	public void method_16()
	{
		GClass14.long_6 = GClass77.smethod_18() + 30000L;
		GClass170.int_11 = 0;
		if (GClass14.gclass173_0.bool_12)
		{
			GClass14.smethod_36(mResources.note, new GClass118(mResources.YES, GClass14.gclass113_0, 10019, null), new GClass118(mResources.NO, GClass14.gclass113_0, 10020, null));
			return;
		}
		if (Main.isWindowsPhone)
			GClass206.bool_1 = true;
		GClass14.gclass14_0.bool_33 = false;
		GClass14.gclass14_0.method_9(GClass14.gclass173_0);
	}
}
