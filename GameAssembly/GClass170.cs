using System;
using System.Runtime.CompilerServices;
using ns1;

public class GClass170 : GClass160, GInterface1
{
	public static string[] string_0;

	public static string[] string_1;

	public static sbyte sbyte_0;

	public static bool[] bool_0;

	public static short[] short_0;

	public static int int_6;

	public static bool bool_1;

	public static GClass118 gclass118_4;

	public static sbyte[] sbyte_1;

	private GClass118[] gclass118_5;

	private GClass118 gclass118_6;

	private int int_7;

	public static GClass118 gclass118_7;

	private int int_8;

	public static string string_2 = "Vũ trụ 1:dragon1.teamobi.com:14445:0,Vũ trụ 2:dragon2.teamobi.com:14445:0,Vũ trụ 3:dragon3.teamobi.com:14445:0,Vũ trụ 4:dragon4.teamobi.com:14445:0,Vũ trụ 5:dragon5.teamobi.com:14445:0,Vũ trụ 6:dragon6.teamobi.com:14445:0,Vũ trụ 7:dragon7.teamobi.com:14445:0,Vũ trụ 8:dragon10.teamobi.com:14446:0,Vũ trụ 9:dragon10.teamobi.com:14447:0,Vũ trụ 10:dragon10.teamobi.com:14445:0,Vũ trụ 11:dragon11.teamobi.com:14445:0,Vũ trụ 12:dragon12.teamobi.com:14445:0,Võ đài liên vũ trụ:dragonwar.teamobi.com:20000:0,Universe 1:dragon.indonaga.com:14445:1,Naga:dragon.indonaga.com:14446:2,0,0";

	public static string string_3 = "Vũ trụ 1:112.213.94.23:14445:0,Vũ trụ 2:210.211.109.199:14445:0,Vũ trụ 3:112.213.85.88:14445:0,Vũ trụ 4:27.0.12.164:14445:0,Vũ trụ 5:27.0.12.16:14445:0,Vũ trụ 6:27.0.12.173:14445:0,Vũ trụ 7:112.213.94.223:14445:0,Vũ trụ 8:27.0.14.66:14446:0,Vũ trụ 9:27.0.14.66:14447:0,Vũ trụ 10:27.0.14.66:14445:0,Vũ trụ 11:112.213.85.35:14445:0,Võ đài liên vũ trụ:27.0.12.173:20000:0,Universe 1:52.74.230.22:14445:1,Naga:52.74.230.22:14446:2,0,0";

	public static string string_4 = "Naga:dragon.indonaga.com:14446:2,2,0";

	public static string string_5 = "Naga:52.74.230.22:14446:2,2,0";

	public static string string_6 = "Universe 1:dragon.indonaga.com:14445:1,1,0";

	public static string string_7 = "Universe 1:52.74.230.22:14445:1,1,0";

	public static string string_8 = "http://sv1.ngocrongonline.com/game/ngocrong031_t.php";

	public static string string_9 = string_3;

	public const sbyte sbyte_2 = 2;

	public int int_9 = -1;

	private int int_10;

	public static bool bool_2;

	public static string string_10 = "http://ngocrongonline.com";

	public static int int_11;

	public static bool bool_3;

	public static int int_12;

	public static int[] int_13 = new int[3];

	public static int int_14;

	public static int int_15;

	public static bool bool_4;

	public static int int_16;

	public static string string_11;

	public static int int_17;

	public static int int_18;

	public static int int_19;

	public static int int_20;

	public static bool bool_5 = false;

	public static GClass118 gclass118_8;

	private GClass118 gclass118_9;

	public string string_12;

	public static int int_21;

	public static int int_22 = -1;

	public static bool bool_6;

	public static bool bool_7 = true;

	public GClass170()
	{
		int num = 4;
		if (184 >= GClass14.int_10)
			num--;
		method_0();
		if (!GClass14.bool_5)
		{
			int_6 = 0;
			method_2();
		}
		GClass167.smethod_10(true, -1, -1);
		GClass167.int_22 = 100;
		GClass167.int_23 = 200;
		if (gclass118_6 == null)
		{
			gclass118_6 = new GClass118("Gọi hotline", this, 13, null);
			gclass118_6.int_1 = GClass14.int_10 - 75;
			if (GClass77.int_0 != 1 || GClass14.bool_5)
				gclass118_6.int_2 = 8;
			else
				gclass118_6.int_2 = GClass14.int_11 - 20;
		}
		gclass118_4 = new GClass118();
		gclass118_4.gdelegate0_0 = delegate(string str)
		{
			string text = str;
			string text2 = str;
			if (text == null)
				text = string_9;
			else
			{
				if (text == null && text2 != null)
				{
					if (text2.Equals(string.Empty) || text2.Length < 20)
						text2 = string_9;
					smethod_4(text2);
				}
				if (text != null && text2 == null)
				{
					if (text.Equals(string.Empty) || text.Length < 20)
						text = string_9;
					smethod_4(text);
				}
				if (text != null && text2 != null)
				{
					if (text.Length <= text2.Length)
						smethod_4(text2);
					else
						smethod_4(text);
				}
			}
		};
		method_8(GClass77.sbyte_0);
	}

	public static void smethod_2()
	{
		if (gclass118_7 == null)
		{
			if (GClass14.gclass170_0 == null)
				GClass14.gclass170_0 = new GClass170();
			gclass118_7 = new GClass118(string.Empty, GClass14.gclass170_0, 14, null);
			gclass118_7.int_1 = GClass14.int_10 - 78;
			gclass118_7.int_2 = GClass14.int_11 - 26;
		}
	}

	private void method_0()
	{
		int_7 = 0;
		string text = GClass141.smethod_2("acc");
		if (text != null)
		{
			if (text.Equals(string.Empty))
			{
				if (GClass141.smethod_1("userAo" + int_14) != null)
					int_7 = 1;
			}
			else
				int_7 = 1;
		}
		else if (GClass141.smethod_1("userAo" + int_14) != null)
		{
			int_7 = 1;
		}
		gclass118_5 = new GClass118[(GClass193.int_12 > 1) ? (3 + int_7) : (4 + int_7)];
		int num = GClass14.int_13 - 15 * gclass118_5.Length + 28;
		for (int i = 0; i < gclass118_5.Length; i++)
		{
			switch (i)
			{
			case 0:
				gclass118_5[0] = new GClass118(string.Empty, this, 3, null);
				if (text != null)
				{
					if (!text.Equals(string.Empty))
					{
						gclass118_5[0].string_0 = mResources.playAcc + ": " + text;
						if (gclass118_5[0].string_0.Length > 23)
						{
							gclass118_5[0].string_0 = gclass118_5[0].string_0.Substring(0, 23);
							gclass118_5[0].string_0 += "...";
						}
					}
					else
					{
						gclass118_5[0].string_0 = mResources.playNew;
						if (GClass141.smethod_1("userAo" + int_14) != null)
							gclass118_5[0].string_0 = mResources.choitiep;
					}
				}
				else
				{
					gclass118_5[0].string_0 = mResources.playNew;
					if (GClass141.smethod_1("userAo" + int_14) != null)
						gclass118_5[0].string_0 = mResources.choitiep;
				}
				break;
			case 1:
				if (int_7 == 1)
				{
					gclass118_5[1] = new GClass118(string.Empty, this, 10100, null);
					gclass118_5[1].string_0 = mResources.playNew;
				}
				else
					gclass118_5[1] = new GClass118(mResources.change_account, this, 7, null);
				break;
			case 2:
				if (int_7 == 1)
					gclass118_5[2] = new GClass118(mResources.change_account, this, 7, null);
				else
					gclass118_5[2] = new GClass118(string.Empty, this, 17, null);
				break;
			case 3:
				if (int_7 != 1)
					gclass118_5[3] = new GClass118(mResources.option, this, 8, null);
				else
					gclass118_5[3] = new GClass118(string.Empty, this, 17, null);
				break;
			case 4:
				gclass118_5[4] = new GClass118(mResources.option, this, 8, null);
				break;
			}
			gclass118_5[i].int_2 = num;
			gclass118_5[i].method_2();
			gclass118_5[i].int_1 = (GClass14.int_10 - gclass118_5[i].int_3) / 2;
			num += 30;
		}
	}

	public static void smethod_3()
	{
		if (gclass118_4 == null && GClass14.gclass170_0 == null)
			GClass14.gclass170_0 = new GClass170();
		Class18.smethod_2(string_9, gclass118_4);
	}

	public static void smethod_4(string str)
	{
		int_13 = new int[3];
		string[] array = GClass191.smethod_30(str.Trim(), ",", 0);
		GClass191.smethod_8("tem leng= " + array.Length);
		mResources.loadLanguague(sbyte.Parse(array[array.Length - 2]));
		string_0 = new string[array.Length - 2];
		string_1 = new string[array.Length - 2];
		short_0 = new short[array.Length - 2];
		sbyte_1 = new sbyte[array.Length - 2];
		bool_0 = new bool[2];
		for (int i = 0; i < array.Length - 2; i++)
		{
			string[] array2 = GClass191.smethod_30(array[i].Trim(), ":", 0);
			string_0[i] = array2[0];
			string_1[i] = array2[1];
			short_0[i] = short.Parse(array2[2]);
			sbyte_1[i] = sbyte.Parse(array2[3].Trim());
			int_13[sbyte_1[i]]++;
		}
		sbyte_0 = sbyte.Parse(array[array.Length - 1]);
		smethod_6();
	}

	public override void paint(GClass193 g)
	{
		if (bool_6)
			GClass14.smethod_18(g);
		else
		{
			g.method_16(0);
			g.method_15(0, 0, GClass14.int_10, GClass14.int_11);
			if (!bool_4)
				;
		}
		int num = 2;
		GClass104.gclass104_20.method_10(g, "v" + GClass206.string_2 + "(" + GClass193.int_12 + ")", GClass14.int_10 - 2, 17, 1, GClass104.gclass104_16);
		string empty = string.Empty;
		empty = ((int_22 == 0) ? (empty + string_0[int_14] + " disconnect") : (empty + string_0[int_14] + " connected"));
		if (GClass77.bool_0)
			GClass104.gclass104_20.method_10(g, empty, GClass14.int_10 - 2, num + 15 + 15, 1, GClass104.gclass104_16);
		if (!bool_5 || bool_6)
		{
			if (GClass77.int_0 == 1 && !GClass14.bool_5)
				GClass104.gclass104_20.method_10(g, string_10, GClass14.int_10 - 2, GClass14.int_11 - 15, 1, GClass104.gclass104_16);
			else
				GClass104.gclass104_20.method_10(g, string_10, GClass14.int_10 - 2, num, 1, GClass104.gclass104_16);
		}
		else
			GClass104.gclass104_20.method_10(g, string_10, GClass14.int_10 - 2, num, 1, GClass104.gclass104_16);
		if (GClass14.int_10 < 200)
			_ = 160;
		else
			_ = 180;
		if (gclass118_7 != null)
			GClass104.gclass104_20.method_10(g, mResources.xoadulieu, GClass14.int_10 - 2, GClass14.int_11 - 15, 1, GClass104.gclass104_16);
		if (GClass14.gclass183_0 == null)
		{
			if (!bool_6)
			{
				if (!bool_4)
				{
					g.method_31(GClass173.gclass20_0, GClass14.int_12, GClass14.int_13 - 32, 3);
					if (bool_5)
					{
						if (!bool_5 && gclass118_8 != null)
							gclass118_8.method_3(g);
						GClass104.gclass104_3.method_6(g, (GClass62.int_0 == 0) ? "Vui lòng thoát game mở lại sau khi tải dữ liệu" : "Please quit game, reopen after downloaded data", GClass14.int_10 / 2, GClass14.int_13 + 11, 2);
						GClass104.gclass104_3.method_6(g, mResources.downloading_data + int_16 + "%", GClass14.int_10 / 2, GClass14.int_13 + 24, 2);
						GClass167.smethod_3(GClass167.gclass20_4, GClass167.gclass20_5, GClass167.gclass20_6, GClass14.int_10 / 2 - 50, GClass14.int_13 + 45, 100, 100f, g);
						GClass167.smethod_3(GClass167.gclass20_1, GClass167.gclass20_2, GClass167.gclass20_3, GClass14.int_10 / 2 - 50, GClass14.int_13 + 45, 100, int_16, g);
					}
					else
					{
						GClass2.smethod_0().method_125(1, null);
						bool_5 = true;
						if (!bool_5)
						{
							GClass104.gclass104_3.method_6(g, mResources.taidulieudechoi, GClass14.int_12, GClass14.int_13 + 24, 2);
							if (gclass118_8 != null)
								gclass118_8.method_3(g);
						}
					}
				}
			}
			else
			{
				int num2 = GClass14.int_13 - 15 * gclass118_5.Length - 15;
				if (num2 < 25)
					num2 = 25;
				if (GClass173.gclass20_0 != null)
					g.method_31(GClass173.gclass20_0, GClass14.int_12, num2, 3);
				for (int i = 0; i < gclass118_5.Length; i++)
				{
					gclass118_5[i].method_3(g);
				}
				g.method_5(0, 0, GClass14.int_10, GClass14.int_11);
				if (int_22 != -1)
					g.method_23(GClass167.gclass20_0, 0, int_22 * 7, 7, 7, 0, (GClass14.int_10 - GClass104.gclass104_6.method_17(gclass118_5[2 + int_7].string_0) >> 1) - 10, gclass118_5[2 + int_7].int_2 + 9, 0);
				else if (GClass14.int_8 % 20 > 10)
				{
					g.method_23(GClass167.gclass20_0, 0, 14, 7, 7, 0, (GClass14.int_10 - GClass104.gclass104_6.method_17(gclass118_5[2 + int_7].string_0) >> 1) - 10, gclass118_5[2 + int_7].int_2 + 10, 0);
				}
			}
		}
		base.paint(g);
	}

	public void method_1()
	{
		int_15 = 30;
		GClass14.smethod_31(mResources.PLEASEWAIT);
		GClass179.smethod_0().close();
		GClass206.string_0 = string_1[int_14];
		GClass206.int_0 = short_0[int_14];
		GClass206.int_2 = sbyte_1[int_14];
		GClass141.smethod_9("svselect", int_14);
		if (sbyte_1[int_14] != mResources.language)
			mResources.loadLanguague(sbyte_1[int_14]);
		GClass173.string_4 = string_0[int_14];
		method_0();
		bool_6 = true;
		int_11 = 0;
		int_22 = -1;
		bool_7 = true;
	}

	public override void update()
	{
		if (bool_3)
		{
			int_12++;
			if (int_12 == 50)
				GClass14.gclass170_0.method_1();
			if (int_12 == 100)
			{
				if (GClass14.gclass173_0 == null)
					GClass14.gclass173_0 = new GClass173();
				GClass14.gclass173_0.method_9();
				GClass2.smethod_0().method_115();
				bool_3 = false;
			}
		}
		if (int_15 > 0)
		{
			int_15--;
			if (int_15 == 0)
				GClass14.smethod_29();
			if (int_22 == 2)
			{
				int_15 = 0;
				GClass14.smethod_29();
			}
		}
		if (int_15 <= 0 && bool_7)
		{
			int_11++;
			if (int_11 > 100000)
				int_11 = 0;
		}
		for (int i = 0; i < gclass118_5.Length; i++)
		{
			if (i == int_6)
				gclass118_5[i].bool_2 = true;
			else
				gclass118_5[i].bool_2 = false;
		}
		GClass167.int_22++;
		if (!bool_6 && (bool_4 || int_16 == 100))
			gclass118_8 = null;
		base.update();
		if (GClass124.bool_35 || !bool_6 || !bool_7 || GClass14.gclass160_0 != this || int_22 == 2)
			return;
		if (int_11 < ((GClass77.int_0 != 1) ? 5 : 2))
		{
			if (int_15 <= 0)
			{
				int_15 = 30;
				GClass14.smethod_31(mResources.PLEASEWAIT);
				GClass14.smethod_4();
			}
		}
		else if (GClass179.smethod_0().isConnected())
		{
			if (int_15 <= 0)
				int_11 = 0;
		}
		else if (int_15 <= 0)
		{
			GClass118 cmdYes = new GClass118(mResources.YES, GClass14.gclass170_0, 18, null);
			GClass118 cmdNo = new GClass118(mResources.NO, GClass14.gclass170_0, 19, null);
			GClass14.smethod_36(mResources.maychutathoacmatsong + "." + mResources.confirmChangeServer, cmdYes, cmdNo);
			int_15 = 30;
		}
	}

	private void method_2()
	{
		if (bool_6)
			gclass118_1 = new GClass118(string.Empty, this, gclass118_5[int_6].int_0, null);
		else
			gclass118_1 = gclass118_8;
	}

	public static void smethod_5()
	{
		if (gclass118_7 != null && gclass118_7.method_4())
			gclass118_7.method_1();
	}

	public override void updateKey()
	{
		if (!GClass14.bool_5)
		{
			if (bool_6)
			{
				if (GClass14.bool_11[8])
				{
					int num = ((GClass193.int_12 <= 1) ? 4 : 2);
					GClass14.bool_11[8] = false;
					int_6++;
					if (int_6 > num)
						int_6 = 0;
					method_2();
				}
				if (GClass14.bool_11[2])
				{
					int num2 = ((GClass193.int_12 <= 1) ? 4 : 2);
					GClass14.bool_11[2] = false;
					int_6--;
					if (int_6 < 0)
						int_6 = num2;
					method_2();
				}
			}
		}
		else
		{
			smethod_5();
			if (gclass118_6 != null && gclass118_6.method_4())
				gclass118_6.method_1();
			if (!bool_6)
			{
				if (gclass118_8 != null && gclass118_8.method_4())
					gclass118_8.method_1();
				base.updateKey();
				return;
			}
			for (int i = 0; i < gclass118_5.Length; i++)
			{
				if (gclass118_5[i] != null && gclass118_5[i].method_4())
				{
					if (int_22 != -1 && int_22 != 0)
						gclass118_5[i].method_1();
					else if (gclass118_5[i].string_0.IndexOf(mResources.server) != -1)
					{
						gclass118_5[i].method_1();
					}
				}
			}
		}
		if (!bool_1)
			base.updateKey();
	}

	public static void smethod_6()
	{
		GClass102 gClass = new GClass102();
		try
		{
			gClass.method_5(mResources.language);
			gClass.method_5((sbyte)string_0.Length);
			for (int i = 0; i < string_0.Length; i++)
			{
				gClass.method_6(string_0[i]);
				gClass.method_6(string_1[i]);
				gClass.method_0(short_0[i]);
				gClass.method_5(sbyte_1[i]);
			}
			sbyte_0 = (sbyte)((!GClass77.bool_0) ? sbyte_0 : (sbyte_0 + 5));
			gClass.method_5(sbyte_0);
			GClass141.smethod_0("NRlink2", gClass.method_3());
			gClass.method_4();
			GClass172.smethod_3();
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_7()
	{
		for (int i = 0; i < 2; i++)
		{
			if (!bool_0[i])
				return false;
		}
		return true;
	}

	public static void smethod_8()
	{
		sbyte[] array = GClass141.smethod_1("NRlink2");
		if (array != null)
		{
			GClass188 gClass = new GClass188(array);
			if (gClass == null)
				return;
			try
			{
				int_13 = new int[3];
				mResources.loadLanguague(gClass.method_7());
				sbyte b = gClass.method_7();
				string_0 = new string[b];
				string_1 = new string[b];
				short_0 = new short[b];
				sbyte_1 = new sbyte[b];
				for (int i = 0; i < b; i++)
				{
					string_0[i] = gClass.method_6();
					string_1[i] = gClass.method_6();
					short_0[i] = gClass.method_0();
					sbyte_1[i] = gClass.method_7();
					int_13[sbyte_1[i]]++;
				}
				sbyte_0 = gClass.method_7();
				gClass.method_4();
				GClass172.smethod_3();
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		smethod_4(string_9);
	}

	public static string[] smethod_9()
	{
		string[] array = null;
		sbyte[] array2 = GClass141.smethod_1("NRlink2");
		if (array2 == null)
			return null;
		GClass188 gClass = new GClass188(array2);
		if (gClass != null)
			try
			{
				int_13 = new int[3];
				gClass.method_7();
				sbyte b = gClass.method_7();
				string_0 = new string[b];
				string_1 = new string[b];
				short_0 = new short[b];
				sbyte_1 = new sbyte[b];
				array = new string[b];
				GClass191.smethod_8("len sv == " + b);
				for (int i = 0; i < b; i++)
				{
					string_0[i] = gClass.method_6();
					string_1[i] = gClass.method_6();
					short_0[i] = gClass.method_0();
					sbyte_1[i] = gClass.method_7();
					int_13[sbyte_1[i]]++;
					array[i] = string_0[i] + ":" + string_1[i] + ":" + short_0[i] + ":" + sbyte_1[i];
				}
				sbyte_0 = gClass.method_7();
				gClass.method_4();
				return array;
			}
			catch (Exception)
			{
				return array;
			}
		return null;
	}

	public override void switchToMe()
	{
		GClass123.smethod_1();
		GClass167.int_23 = 0;
		GClass167.int_22 = 0;
		method_0();
		bool_1 = false;
		GClass14.gclass173_0 = null;
		string text = GClass141.smethod_2("ResVersion");
		if (((text == null || !(text != string.Empty)) ? (-1) : int.Parse(text)) > 0)
		{
			bool_6 = true;
			GClass14.smethod_21(0);
		}
		bool_4 = true;
		gclass118_5[2 + int_7].string_0 = mResources.server + ": " + string_0[int_14];
		gclass118_1 = new GClass118(string.Empty, this, gclass118_5[int_6].int_0, null);
		gclass118_5[1 + int_7].string_0 = mResources.change_account;
		if (gclass118_5.Length == 4 + int_7)
			gclass118_5[3 + int_7].string_0 = mResources.option;
		GClass124.bool_35 = false;
		GClass77.smethod_1();
		base.switchToMe();
	}

	public void method_3()
	{
		GClass167.int_23 = 0;
		GClass167.int_22 = 0;
		method_0();
		bool_1 = false;
		GClass14.gclass173_0 = null;
		string text = GClass141.smethod_2("ResVersion");
		if (((text == null || !(text != string.Empty)) ? (-1) : int.Parse(text)) > 0)
		{
			bool_6 = true;
			GClass14.smethod_21(0);
		}
		bool_4 = true;
		gclass118_5[2 + int_7].string_0 = mResources.server + ": " + string_0[int_14];
		gclass118_1 = new GClass118(string.Empty, this, gclass118_5[int_6].int_0, null);
		gclass118_5[1 + int_7].string_0 = mResources.change_account;
		if (gclass118_5.Length == 4 + int_7)
			gclass118_5[3 + int_7].string_0 = mResources.option;
		GClass77.smethod_1();
		base.switchToMe();
	}

	public void method_4()
	{
	}

	public void method_5()
	{
		if (GClass14.gclass170_0 == null)
			GClass14.gclass170_0 = new GClass170();
		int_19 = 0;
		int_16 = 0;
		bool_2 = true;
		GClass14.gclass170_0.method_7();
		bool_5 = false;
		gclass118_8.bool_2 = true;
		gclass118_1 = new GClass118(string.Empty, this, 2, null);
	}

	public void perform(int idAction, object p)
	{
		GClass191.smethod_8("perform " + idAction);
		if (idAction == 1000)
			GClass14.smethod_4();
		if (idAction == 1 || idAction == 4)
		{
			GClass179.smethod_0().close();
			bool_7 = false;
			int_11 = 0;
			bool_6 = true;
			int_22 = 0;
			bool_5 = false;
			GClass141.smethod_13();
			switchToMe();
		}
		if (idAction == 2)
		{
			bool_2 = false;
			gclass118_8 = new GClass118(mResources.huy, this, 4, null);
			gclass118_8.int_1 = GClass14.int_10 / 2 - GClass160.int_2 / 2;
			gclass118_8.int_2 = GClass14.int_13 + 65;
			gclass118_2 = null;
			if (!GClass14.bool_5)
			{
				gclass118_8.int_1 = GClass14.int_10 / 2 - GClass160.int_2 / 2;
				gclass118_8.int_2 = GClass14.int_11 - GClass160.int_3 - 1;
			}
			gclass118_1 = new GClass118(string.Empty, this, 4, null);
			if (!bool_5)
			{
				GClass2.smethod_0().method_125(1, null);
				if (!GClass14.bool_5)
				{
					gclass118_8.bool_2 = true;
					gclass118_1 = new GClass118(string.Empty, this, 4, null);
				}
				bool_5 = true;
			}
		}
		if (idAction == 3)
		{
			GClass191.smethod_8("toi day");
			if (GClass14.gclass173_0 == null)
				GClass14.gclass173_0 = new GClass173();
			GClass14.gclass173_0.switchToMe();
			bool flag = GClass141.smethod_2("acc") != null && !GClass141.smethod_2("acc").Equals(string.Empty);
			bool flag2 = GClass141.smethod_2("userAo" + int_14) != null && !GClass141.smethod_2("userAo" + int_14).Equals(string.Empty);
			if (flag || flag2)
				GClass14.gclass173_0.method_9();
			else
			{
				GClass14.smethod_4();
				string text = GClass141.smethod_2("userAo" + int_14);
				if (text == null || text.Equals(string.Empty))
					GClass2.smethod_0().method_122(string.Empty);
				else
				{
					GClass14.gclass173_0.bool_12 = true;
					GClass14.smethod_4();
					GClass2.smethod_0().method_34();
					GClass2.smethod_0().method_38(text, string.Empty, GClass206.string_2, 1);
				}
				if (GClass179.bool_1)
					GClass14.smethod_33();
				else
					GClass14.smethod_30(mResources.maychutathoacmatsong);
			}
			GClass173.string_4 = string_0[int_14];
		}
		if (idAction == 10100)
		{
			if (GClass14.gclass173_0 == null)
				GClass14.gclass173_0 = new GClass173();
			GClass14.gclass173_0.switchToMe();
			GClass14.smethod_4();
			GClass2.smethod_0().method_122(string.Empty);
			GClass191.smethod_8("tao user ao");
			GClass14.smethod_33();
			GClass173.string_4 = string_0[int_14];
		}
		if (idAction == 5)
		{
			smethod_3();
			if (string_0.Length == 1)
				return;
			GClass122 gClass = new GClass122(string.Empty);
			for (int i = 0; i < string_0.Length; i++)
			{
				gClass.method_0(new GClass118(string_0[i], this, 6, null));
			}
			GClass14.gclass116_0.method_2(gClass, 0);
			if (!GClass14.bool_5)
				GClass14.gclass116_0.int_0 = int_14;
		}
		if (idAction == 6)
		{
			int_14 = GClass14.gclass116_0.int_0;
			method_1();
		}
		if (idAction == 7)
		{
			if (GClass14.gclass173_0 == null)
				GClass14.gclass173_0 = new GClass173();
			GClass14.gclass173_0.switchToMe();
		}
		if (idAction == 8)
		{
			bool flag3 = GClass141.smethod_8("lowGraphic") == 1;
			GClass122 gClass2 = new GClass122("cau hinh");
			gClass2.method_0(new GClass118(mResources.cauhinhthap, this, 9, null));
			gClass2.method_0(new GClass118(mResources.cauhinhcao, this, 10, null));
			GClass14.gclass116_0.method_2(gClass2, 0);
			if (!flag3)
				GClass14.gclass116_0.int_0 = 1;
			else
				GClass14.gclass116_0.int_0 = 0;
		}
		if (idAction == 9)
		{
			GClass141.smethod_9("lowGraphic", 1);
			GClass14.smethod_34(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 10)
		{
			GClass141.smethod_9("lowGraphic", 0);
			GClass14.smethod_34(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 11)
		{
			if (GClass14.gclass173_0 == null)
				GClass14.gclass173_0 = new GClass173();
			GClass14.gclass173_0.switchToMe();
			string text2 = GClass141.smethod_2("userAo" + int_14);
			if (text2 != null && !text2.Equals(string.Empty))
			{
				GClass14.gclass173_0.bool_12 = true;
				GClass14.smethod_4();
				GClass2.smethod_0().method_34();
				GClass2.smethod_0().method_38(text2, string.Empty, GClass206.string_2, 1);
			}
			else
				GClass2.smethod_0().method_122(string.Empty);
			GClass14.smethod_31(mResources.PLEASEWAIT);
			GClass191.smethod_8("tao user ao");
		}
		if (idAction == 12)
			GClass206.gclass206_0.method_1();
		if (idAction == 13 && (!bool_5 || bool_6))
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
			}
		}
		if (idAction == 14)
		{
			GClass118 cmdYes = new GClass118(mResources.YES, GClass14.gclass170_0, 15, null);
			GClass118 cmdNo = new GClass118(mResources.NO, GClass14.gclass170_0, 16, null);
			GClass14.smethod_36(mResources.deletaDataNote, cmdYes, cmdNo);
		}
		if (idAction == 15)
		{
			GClass141.smethod_13();
			GClass14.smethod_34(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 16)
		{
			GClass96.smethod_5();
			GClass14.gclass183_0 = null;
		}
		if (idAction == 17)
		{
			if (GClass14.gclass168_0 == null)
				GClass14.gclass168_0 = new GClass168();
			GClass14.gclass168_0.switchToMe();
		}
		if (idAction == 18)
		{
			GClass14.smethod_29();
			GClass96.smethod_5();
			if (GClass14.gclass168_0 == null)
				GClass14.gclass168_0 = new GClass168();
			GClass14.gclass168_0.switchToMe();
		}
		if (idAction == 19)
		{
			if (GClass77.int_0 == 1)
			{
				GClass96.smethod_5();
				GClass14.gclass183_0 = null;
			}
			else
			{
				int_11 = 0;
				int_22 = 0;
				bool_7 = true;
			}
		}
	}

	public void method_6()
	{
		if (!bool_6)
		{
			gclass118_8 = new GClass118(mResources.taidulieu, this, 2, null);
			gclass118_8.bool_2 = true;
			gclass118_8.int_1 = GClass14.int_10 / 2 - GClass160.int_2 / 2;
			gclass118_8.int_2 = GClass14.int_13 + 45;
			if (gclass118_8.int_2 > GClass14.int_11 - 26)
				gclass118_8.int_2 = GClass14.int_11 - 26;
		}
		if (!GClass14.bool_5)
		{
			int_6 = 0;
			method_2();
		}
	}

	public void method_7()
	{
		GClass167.int_22 = 0;
		GClass167.int_23 = 0;
		method_0();
		bool_6 = false;
		int_16 = 0;
		bool_4 = false;
		bool_5 = false;
		int_21 = 0;
		int_19 = 0;
		string_11 = mResources.PLEASEWAIT;
		GClass124.bool_35 = false;
		method_6();
		base.switchToMe();
	}

	public void method_8(sbyte language)
	{
		if (language == 2)
		{
			if (GClass77.int_0 == 1)
				string_9 = string_5;
			else
				string_9 = string_4;
		}
		else if (language == 1)
		{
			string_9 = string_7;
			if (GClass77.int_0 != 1)
				string_9 = string_6;
			else
				string_9 = string_7;
		}
		else
		{
			string_9 = string_3;
			if (GClass77.int_0 != 1)
				string_9 = string_2;
			else
				string_9 = string_3;
		}
		GClass77.smethod_0();
	}
}
