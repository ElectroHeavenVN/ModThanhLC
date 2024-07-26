using System;

public class GClass109
{
	public class GClass110
	{
	}

	public class GClass111
	{
	}

	public class GClass112
	{
	}

	public static bool bool_0;

	public static GClass109 gclass109_0;

	public static bool bool_1 = true;

	public static float float_0 = 0.5f;

	private static int int_0 = 10;

	public static GClass112[] gclass112_0;

	public static GClass110[] gclass110_0;

	public static int[] int_1;

	public static int int_2;

	public static int int_3 = 1;

	public static int int_4 = 2;

	public static int int_5;

	public static int int_6 = 1;

	public static int int_7 = 2;

	public static int int_8 = 3;

	public static int int_9 = 4;

	public static int int_10 = 5;

	public static int int_11 = 6;

	public static int int_12 = 7;

	public static int int_13 = 8;

	public static int int_14 = 9;

	public static int int_15 = 10;

	public static int int_16 = 11;

	public static int int_17 = 12;

	public static int int_18 = 13;

	public static int int_19 = 14;

	public static int int_20 = 15;

	public static int int_21 = 16;

	public static int int_22 = 17;

	public static int int_23 = 18;

	public static int int_24 = 19;

	public static int int_25 = 20;

	public static int int_26 = 21;

	public static int int_27 = 22;

	public static int int_28 = 23;

	public static int int_29 = 24;

	public static int int_30 = 25;

	public static int int_31 = 26;

	public static int int_32 = 27;

	public static int int_33 = 28;

	public static int int_34 = 29;

	public static int int_35 = 30;

	public static int int_36 = 31;

	public static int int_37 = 32;

	public static int int_38 = 33;

	public static int int_39 = 34;

	public static int int_40 = 35;

	public static int int_41 = 36;

	public static int int_42 = 37;

	public static int int_43 = 38;

	public bool bool_2;

	public int int_44;

	public static int int_45 = 1;

	public static void smethod_0(GClass111 ac)
	{
		GClass22.smethod_0(ac);
	}

	public static GClass109 smethod_1()
	{
		if (gclass109_0 == null)
			gclass109_0 = new GClass109();
		return gclass109_0;
	}

	public void method_0(int mapID)
	{
		GClass22.smethod_4(new int[3] { int_2, int_3, int_4 }, new int[39]
		{
			int_5, int_6, int_7, int_8, int_9, int_10, int_11, int_12, int_13, int_14,
			int_15, int_11, int_17, int_18, int_19, int_20, int_21, int_22, int_23, int_24,
			int_25, int_26, int_27, int_28, int_29, int_30, int_31, int_32, int_33, int_34,
			int_35, int_36, int_37, int_38, int_39, int_40, int_41, int_42, int_43
		});
	}

	public void method_1()
	{
		if (GClass73.gclass133_0.bool_12 && GClass78.smethod_1().gclass56_0 != null && GClass78.smethod_1().gclass56_0.short_1 >= 2)
		{
			GClass76.string_6 = new string[10]
			{
				mResources.radaCard,
				mResources.quayso,
				mResources.gameInfo,
				mResources.change_flag,
				mResources.change_zone,
				mResources.chat_world,
				mResources.account,
				mResources.option,
				mResources.change_account,
				mResources.REGISTOPROTECT
			};
			if (GClass78.smethod_1().bool_38)
				GClass76.string_6 = new string[11]
				{
					mResources.radaCard,
					mResources.quayso,
					mResources.gameInfo,
					mResources.pet,
					mResources.change_flag,
					mResources.change_zone,
					mResources.chat_world,
					mResources.account,
					mResources.option,
					mResources.change_account,
					mResources.REGISTOPROTECT
				};
		}
		else
		{
			GClass76.string_6 = new string[9]
			{
				mResources.radaCard,
				mResources.quayso,
				mResources.gameInfo,
				mResources.change_flag,
				mResources.change_zone,
				mResources.chat_world,
				mResources.account,
				mResources.option,
				mResources.change_account
			};
			if (GClass78.smethod_1().bool_38)
				GClass76.string_6 = new string[10]
				{
					mResources.radaCard,
					mResources.quayso,
					mResources.gameInfo,
					mResources.pet,
					mResources.change_flag,
					mResources.change_zone,
					mResources.chat_world,
					mResources.account,
					mResources.option,
					mResources.change_account
				};
		}
		if (bool_0)
		{
			string[] array = new string[GClass76.string_6.Length + 1];
			for (int i = 0; i < GClass76.string_6.Length; i++)
			{
				array[i] = GClass76.string_6[i];
			}
			array[GClass76.string_6.Length] = mResources.delacc;
			GClass76.string_6 = array;
		}
	}

	public void method_2()
	{
		string text = "[x]   ";
		string text2 = "[  ]   ";
		if (Main.isPC)
		{
			GClass76.string_7 = new string[4]
			{
				GClass78.bool_75 ? (text2 + mResources.aura_off) : (text + mResources.aura_off),
				GClass78.bool_76 ? (text2 + mResources.aura_off_2) : (text + mResources.aura_off_2),
				GClass73.bool_21 ? (text + mResources.turnOffSound) : (text2 + mResources.turnOffSound),
				(GClass122.int_12 > 1) ? (text + mResources.x1Screen) : (text2 + mResources.x2Screen)
			};
			return;
		}
		string text3 = ((GClass144.int_80 != 0) ? (text + mResources.turnOffAnalog) : (text2 + mResources.turnOnAnalog));
		if (!GClass73.bool_5)
			text3 = (GClass144.bool_83 ? (text + mResources.serverchat_off) : (text2 + mResources.serverchat_off));
		GClass76.string_7 = new string[5]
		{
			(!GClass78.bool_75) ? (text + mResources.aura_off) : (text2 + mResources.aura_off),
			GClass78.bool_76 ? (text2 + mResources.aura_off_2) : (text + mResources.aura_off_2),
			GClass73.bool_21 ? (text + mResources.turnOffSound) : (text2 + mResources.turnOffSound),
			GClass73.bool_1 ? (text + mResources.cauhinhthap) : (text2 + mResources.cauhinhthap),
			text3
		};
	}

	public void method_3()
	{
		GClass22.smethod_5(int_25, 0.5f);
	}

	public void method_4(bool isKick, float volumn)
	{
		if (!GClass78.smethod_1().bool_10)
			float_0 /= 2f;
		if (volumn <= 0f)
			volumn = 0.01f;
		int num = GClass50.smethod_19(0, 3);
		if (isKick)
			GClass22.smethod_5((num != 0) ? int_15 : int_8, 0.1f);
		else
			GClass22.smethod_5((num != 0) ? int_14 : int_7, 0.1f);
		int_44++;
	}

	public void method_5()
	{
		GClass22.smethod_5(int_26, 0.5f);
		int_44++;
	}

	public void method_6()
	{
		GClass22.smethod_19(int_3, 0.3f, true);
	}

	public void method_7()
	{
		GClass22.smethod_5(int_32, 0.3f);
		int_44++;
	}

	public void method_8()
	{
		GClass22.smethod_5(int_28, 0.2f);
		int_44++;
	}

	public void method_9()
	{
		GClass22.smethod_5(int_5, 0.3f);
		int_44++;
	}

	public void method_10()
	{
		GClass73.bool_21 = !GClass73.bool_21;
		if (GClass73.bool_21)
		{
			smethod_1().method_0(GClass20.int_37);
			GClass1.smethod_9("isPlaySound", 1);
		}
		else
		{
			smethod_1().method_19();
			GClass1.smethod_9("isPlaySound", 0);
		}
		method_2();
	}

	public void method_11()
	{
		GClass144.bool_83 = !GClass144.bool_83;
		if (!GClass144.bool_83)
			GClass1.smethod_9("serverchat", 1);
		else
			GClass1.smethod_9("serverchat", 0);
		method_2();
	}

	public void method_12()
	{
		if (GClass144.int_80 != 0)
		{
			GClass144.int_80 = 0;
			GClass1.smethod_9("analog", GClass144.int_80);
			GClass144.smethod_11();
		}
		else
		{
			GClass144.int_80 = 1;
			GClass1.smethod_9("analog", GClass144.int_80);
			GClass144.smethod_11();
		}
		method_2();
	}

	public void method_13()
	{
		if (!Main.isPC)
		{
			if (GClass73.bool_5)
				method_12();
			else
				method_11();
		}
	}

	public void method_14()
	{
		if (GClass73.bool_1)
		{
			GClass1.smethod_9("lowGraphic", 0);
			GClass73.smethod_34(mResources.plsRestartGame, 8885, null);
		}
		else
		{
			GClass1.smethod_9("lowGraphic", 1);
			GClass73.smethod_34(mResources.plsRestartGame, 8885, null);
		}
		method_2();
	}

	public void method_15()
	{
		if (!GClass78.bool_75)
		{
			GClass1.smethod_9("isPaintAura", 1);
			GClass78.bool_75 = true;
		}
		else
		{
			GClass1.smethod_9("isPaintAura", 0);
			GClass78.bool_75 = false;
		}
		method_2();
	}

	public void method_16()
	{
		if (!GClass78.bool_76)
		{
			GClass1.smethod_9("isPaintAura2", 1);
			GClass78.bool_76 = true;
		}
		else
		{
			GClass1.smethod_9("isPaintAura2", 0);
			GClass78.bool_76 = false;
		}
		method_2();
	}

	public void method_17()
	{
		GClass7.smethod_0().method_147(0);
	}

	public void method_18()
	{
	}

	public void method_19()
	{
		GClass22.bool_2 = true;
		method_51();
	}

	public void method_20()
	{
		if (GClass22.audioClip_0 == null)
			method_0(0);
		GClass22.bool_2 = false;
	}

	public void method_21()
	{
		GClass22.smethod_5(int_30, 0.5f);
		int_44++;
	}

	public void method_22()
	{
		GClass22.smethod_5(int_22, 0.5f);
		int_44++;
	}

	public void method_23()
	{
		GClass22.smethod_5(int_22, 0.5f);
		int_44++;
	}

	public void method_24()
	{
		GClass22.smethod_5(int_24, 1f);
		int_44++;
	}

	public void method_25()
	{
		GClass22.smethod_5(int_20, 0.3f);
		int_44++;
	}

	public void method_26()
	{
		GClass22.smethod_5(int_31, 0.3f);
		int_44++;
	}

	public void method_27()
	{
		GClass22.smethod_5(int_21, 0.3f);
		int_44++;
	}

	public void method_28(int type)
	{
		int id = int_21;
		if (type == 13)
			id = int_19;
		GClass22.smethod_5(id, 0.1f);
		int_44++;
	}

	public void method_29(float volumn)
	{
		if (!GClass78.smethod_1().bool_10)
		{
			float_0 /= 2f;
			if (volumn <= 0f)
				volumn = 0.01f;
		}
		if (GClass73.int_8 % 8 == 0)
		{
			GClass22.smethod_5(int_6, volumn);
			int_44++;
		}
	}

	public void method_30(float volumn)
	{
		if (GClass73.int_8 % 8 == 0)
		{
			GClass22.smethod_5(int_29, 0.2f);
			int_44++;
		}
	}

	public void method_31()
	{
		GClass22.smethod_5(int_6, 0.1f);
		int_44++;
	}

	public void method_32()
	{
		GClass22.smethod_5(int_6, 0.2f);
		int_44++;
	}

	public void method_33()
	{
		GClass22.smethod_5(int_11, 0.5f);
		int_44++;
	}

	public void method_34()
	{
		GClass22.smethod_5(int_12, 0.5f);
		int_44++;
	}

	public void method_35()
	{
		GClass22.smethod_5(int_13, 0.5f);
		int_44++;
	}

	public void method_36()
	{
	}

	public void method_37()
	{
		GClass22.smethod_5(int_9, 0.2f);
		int_44++;
	}

	public void method_38()
	{
	}

	public void method_39()
	{
		GClass22.smethod_5(int_12, 0.5f);
		int_44++;
	}

	public void method_40()
	{
		GClass22.smethod_5(int_16, 0.5f);
		int_44++;
	}

	public void method_41()
	{
		GClass22.smethod_5(int_17, 0.5f);
		int_44++;
	}

	public void method_42()
	{
		GClass22.smethod_5(int_18, 0.5f);
	}

	public void method_43()
	{
		GClass22.smethod_5(int_27, 0.5f);
		int_44++;
	}

	public void method_44()
	{
		GClass22.smethod_19(int_4, 0.5f, true);
	}

	public void method_45()
	{
	}

	public bool method_46()
	{
		try
		{
			return GClass22.smethod_15();
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool method_47()
	{
		return false;
	}

	public void method_48()
	{
		int_45++;
		if (int_45 % 2 == 0)
			GClass22.smethod_19(int_2, 0.3f, false);
	}

	public void method_49()
	{
	}

	public void method_50()
	{
	}

	public void method_51()
	{
		GClass22.smethod_8();
	}

	public void method_52()
	{
		GClass14.smethod_0().close();
		GClass73.gclass76_0.method_151();
		GClass73.gclass133_0.method_15();
		GClass73.gclass133_0.switchToMe();
	}

	public void method_53()
	{
		int_44++;
		if (int_44 % 15 == 0)
			GClass22.smethod_5(int_24, 0.5f);
	}

	public void method_54()
	{
		GClass22.smethod_5(int_33, 0.5f);
	}

	public void method_55()
	{
		GClass22.smethod_5(int_34, 0.5f);
	}

	public static void smethod_2(int x, int y, int id, float volume)
	{
		GClass22.smethod_5(id, volume);
	}
}
