using System;

public class GClass152 : GClass145, GInterface0
{
	public static string[] string_0;

	public static string[] string_1;

	public static sbyte sbyte_0;

	public static bool[] bool_0;

	public static short[] short_0;

	public static int int_6;

	public static bool bool_1;

	public static GClass14 gclass14_4;

	public static sbyte[] sbyte_1;

	private GClass14[] gclass14_5;

	private GClass14 gclass14_6;

	private int int_7;

	public static GClass14 gclass14_7;

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

	public static GClass14 gclass14_8;

	private GClass14 gclass14_9;

	public string string_12;

	public static int int_21;

	public static int int_22 = -1;

	public static bool bool_6;

	public static bool bool_7 = true;

	public GClass152()
	{
		int num = 4;
		if (184 >= GClass39.int_10)
			num--;
		method_0();
		if (!GClass39.bool_5)
		{
			int_6 = 0;
			method_2();
		}
		GClass154.smethod_10(true, -1, -1);
		GClass154.int_22 = 100;
		GClass154.int_23 = 200;
		if (gclass14_6 == null)
		{
			gclass14_6 = new GClass14("Gọi hotline", this, 13, null);
			gclass14_6.int_1 = GClass39.int_10 - 75;
			if (GClass138.int_0 == 1 && !GClass39.bool_5)
				gclass14_6.int_2 = GClass39.int_11 - 20;
			else
				gclass14_6.int_2 = 8;
		}
		gclass14_4 = new GClass14();
		gclass14_4.gdelegate1_0 = delegate(string str)
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
					if (text.Length > text2.Length)
						smethod_4(text);
					else
						smethod_4(text2);
				}
			}
		};
		method_8(GClass138.sbyte_0);
	}

	public static void smethod_2()
	{
		if (gclass14_7 == null)
		{
			if (GClass39.gclass152_0 == null)
				GClass39.gclass152_0 = new GClass152();
			gclass14_7 = new GClass14(string.Empty, GClass39.gclass152_0, 14, null);
			gclass14_7.int_1 = GClass39.int_10 - 78;
			gclass14_7.int_2 = GClass39.int_11 - 26;
		}
	}

	private void method_0()
	{
		int_7 = 0;
		string text = GClass120.smethod_2("acc");
		if (text == null)
		{
			if (GClass120.smethod_1("userAo" + int_14) != null)
				int_7 = 1;
		}
		else if (text.Equals(string.Empty))
		{
			if (GClass120.smethod_1("userAo" + int_14) != null)
				int_7 = 1;
		}
		else
		{
			int_7 = 1;
		}
		gclass14_5 = new GClass14[(GClass76.int_12 <= 1) ? (4 + int_7) : (3 + int_7)];
		int num = GClass39.int_13 - 15 * gclass14_5.Length + 28;
		for (int i = 0; i < gclass14_5.Length; i++)
		{
			switch (i)
			{
			case 0:
				gclass14_5[0] = new GClass14(string.Empty, this, 3, null);
				if (text == null)
				{
					gclass14_5[0].string_0 = mResources.playNew;
					if (GClass120.smethod_1("userAo" + int_14) != null)
						gclass14_5[0].string_0 = mResources.choitiep;
					break;
				}
				if (text.Equals(string.Empty))
				{
					gclass14_5[0].string_0 = mResources.playNew;
					if (GClass120.smethod_1("userAo" + int_14) != null)
						gclass14_5[0].string_0 = mResources.choitiep;
					break;
				}
				gclass14_5[0].string_0 = mResources.playAcc + ": " + text;
				if (gclass14_5[0].string_0.Length > 23)
				{
					gclass14_5[0].string_0 = gclass14_5[0].string_0.Substring(0, 23);
					gclass14_5[0].string_0 += "...";
				}
				break;
			case 1:
				if (int_7 == 1)
				{
					gclass14_5[1] = new GClass14(string.Empty, this, 10100, null);
					gclass14_5[1].string_0 = mResources.playNew;
				}
				else
					gclass14_5[1] = new GClass14(mResources.change_account, this, 7, null);
				break;
			case 2:
				if (int_7 == 1)
					gclass14_5[2] = new GClass14(mResources.change_account, this, 7, null);
				else
					gclass14_5[2] = new GClass14(string.Empty, this, 17, null);
				break;
			case 3:
				if (int_7 == 1)
					gclass14_5[3] = new GClass14(string.Empty, this, 17, null);
				else
					gclass14_5[3] = new GClass14(mResources.option, this, 8, null);
				break;
			case 4:
				gclass14_5[4] = new GClass14(mResources.option, this, 8, null);
				break;
			}
			gclass14_5[i].int_2 = num;
			gclass14_5[i].method_2();
			gclass14_5[i].int_1 = (GClass39.int_10 - gclass14_5[i].int_3) / 2;
			num += 30;
		}
	}

	public static void smethod_3()
	{
		if (gclass14_4 == null && GClass39.gclass152_0 == null)
			GClass39.gclass152_0 = new GClass152();
		Class11.smethod_2(string_9, gclass14_4);
	}

	public static void smethod_4(string str)
	{
		int_13 = new int[3];
		string[] array = GClass56.smethod_30(str.Trim(), ",", 0);
		GClass56.smethod_8("tem leng= " + array.Length);
		mResources.loadLanguague(sbyte.Parse(array[array.Length - 2]));
		string_0 = new string[array.Length - 2];
		string_1 = new string[array.Length - 2];
		short_0 = new short[array.Length - 2];
		sbyte_1 = new sbyte[array.Length - 2];
		bool_0 = new bool[2];
		for (int i = 0; i < array.Length - 2; i++)
		{
			string[] array2 = GClass56.smethod_30(array[i].Trim(), ":", 0);
			string_0[i] = array2[0];
			string_1[i] = array2[1];
			short_0[i] = short.Parse(array2[2]);
			sbyte_1[i] = sbyte.Parse(array2[3].Trim());
			int_13[sbyte_1[i]]++;
		}
		sbyte_0 = sbyte.Parse(array[array.Length - 1]);
		smethod_6();
	}

	public override void paint(GClass76 g)
	{
		if (!bool_6)
		{
			g.method_16(0);
			g.method_15(0, 0, GClass39.int_10, GClass39.int_11);
			if (!bool_4)
				;
		}
		else
			GClass39.smethod_18(g);
		int num = 2;
		GClass49.gclass49_20.method_10(g, "v" + GClass113.string_2 + "(" + GClass76.int_12 + ")", GClass39.int_10 - 2, 17, 1, GClass49.gclass49_16);
		string empty = string.Empty;
		empty = ((int_22 != 0) ? (empty + string_0[int_14] + " connected") : (empty + string_0[int_14] + " disconnect"));
		if (GClass138.bool_0)
			GClass49.gclass49_20.method_10(g, empty, GClass39.int_10 - 2, num + 15 + 15, 1, GClass49.gclass49_16);
		if (!bool_5 || bool_6)
		{
			if (GClass138.int_0 == 1 && !GClass39.bool_5)
				GClass49.gclass49_20.method_10(g, string_10, GClass39.int_10 - 2, GClass39.int_11 - 15, 1, GClass49.gclass49_16);
			else
				GClass49.gclass49_20.method_10(g, string_10, GClass39.int_10 - 2, num, 1, GClass49.gclass49_16);
		}
		else
			GClass49.gclass49_20.method_10(g, string_10, GClass39.int_10 - 2, num, 1, GClass49.gclass49_16);
		if (GClass39.int_10 < 200)
			_ = 160;
		else
			_ = 180;
		if (gclass14_7 != null)
			GClass49.gclass49_20.method_10(g, mResources.xoadulieu, GClass39.int_10 - 2, GClass39.int_11 - 15, 1, GClass49.gclass49_16);
		if (GClass39.gclass99_0 == null)
		{
			if (!bool_6)
			{
				if (!bool_4)
				{
					g.method_31(GClass149.gclass2_0, GClass39.int_12, GClass39.int_13 - 32, 3);
					if (!bool_5)
					{
						GClass166.smethod_0().method_125(1, null);
						bool_5 = true;
						if (!bool_5)
						{
							GClass49.gclass49_3.method_6(g, mResources.taidulieudechoi, GClass39.int_12, GClass39.int_13 + 24, 2);
							if (gclass14_8 != null)
								gclass14_8.method_3(g);
						}
					}
					else
					{
						if (!bool_5 && gclass14_8 != null)
							gclass14_8.method_3(g);
						GClass49.gclass49_3.method_6(g, mResources.downloading_data + int_16 + "%", GClass39.int_10 / 2, GClass39.int_13 + 24, 2);
						GClass154.smethod_3(GClass154.gclass2_4, GClass154.gclass2_5, GClass154.gclass2_6, GClass39.int_10 / 2 - 50, GClass39.int_13 + 45, 100, 100f, g);
						GClass154.smethod_3(GClass154.gclass2_1, GClass154.gclass2_2, GClass154.gclass2_3, GClass39.int_10 / 2 - 50, GClass39.int_13 + 45, 100, int_16, g);
					}
				}
			}
			else
			{
				int num2 = GClass39.int_13 - 15 * gclass14_5.Length - 15;
				if (num2 < 25)
					num2 = 25;
				if (GClass149.gclass2_0 != null)
					g.method_31(GClass149.gclass2_0, GClass39.int_12, num2, 3);
				for (int i = 0; i < gclass14_5.Length; i++)
				{
					gclass14_5[i].method_3(g);
				}
				g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
				if (int_22 == -1)
				{
					if (GClass39.int_8 % 20 > 10)
						g.method_23(GClass154.gclass2_0, 0, 14, 7, 7, 0, (GClass39.int_10 - GClass49.gclass49_6.method_17(gclass14_5[2 + int_7].string_0) >> 1) - 10, gclass14_5[2 + int_7].int_2 + 10, 0);
				}
				else
					g.method_23(GClass154.gclass2_0, 0, int_22 * 7, 7, 7, 0, (GClass39.int_10 - GClass49.gclass49_6.method_17(gclass14_5[2 + int_7].string_0) >> 1) - 10, gclass14_5[2 + int_7].int_2 + 9, 0);
			}
		}
		base.paint(g);
	}

	public void method_1()
	{
		int_15 = 30;
		GClass39.smethod_31(mResources.PLEASEWAIT);
		GClass162.smethod_0().close();
		GClass113.string_0 = string_1[int_14];
		GClass113.int_0 = short_0[int_14];
		GClass113.int_2 = sbyte_1[int_14];
		GClass120.smethod_9("svselect", int_14);
		if (sbyte_1[int_14] != mResources.language)
			mResources.loadLanguague(sbyte_1[int_14]);
		GClass149.string_4 = string_0[int_14];
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
				GClass39.gclass152_0.method_1();
			if (int_12 == 100)
			{
				if (GClass39.gclass149_0 == null)
					GClass39.gclass149_0 = new GClass149();
				GClass39.gclass149_0.method_9();
				GClass166.smethod_0().method_115();
				bool_3 = false;
			}
		}
		if (int_15 > 0)
		{
			int_15--;
			if (int_15 == 0)
				GClass39.smethod_29();
			if (int_22 == 2)
			{
				int_15 = 0;
				GClass39.smethod_29();
			}
		}
		if (int_15 <= 0 && bool_7)
		{
			int_11++;
			if (int_11 > 100000)
				int_11 = 0;
		}
		for (int i = 0; i < gclass14_5.Length; i++)
		{
			if (i == int_6)
				gclass14_5[i].bool_2 = true;
			else
				gclass14_5[i].bool_2 = false;
		}
		GClass154.int_22++;
		if (!bool_6 && (bool_4 || int_16 == 100))
			gclass14_8 = null;
		base.update();
		if (GClass58.bool_35 || !bool_6 || !bool_7 || GClass39.gclass145_0 != this || int_22 == 2)
			return;
		if (int_11 < ((GClass138.int_0 != 1) ? 5 : 2))
		{
			if (int_15 <= 0)
			{
				int_15 = 30;
				GClass39.smethod_31(mResources.PLEASEWAIT);
				GClass39.smethod_4();
			}
		}
		else if (!GClass162.smethod_0().isConnected())
		{
			if (int_15 <= 0)
			{
				GClass39.smethod_36(cmdYes: new GClass14(mResources.YES, GClass39.gclass152_0, 18, null), cmdNo: new GClass14(mResources.NO, GClass39.gclass152_0, 19, null), info: mResources.maychutathoacmatsong + "." + mResources.confirmChangeServer);
				int_15 = 30;
			}
		}
		else if (int_15 <= 0)
		{
			int_11 = 0;
		}
	}

	private void method_2()
	{
		if (bool_6)
			gclass14_1 = new GClass14(string.Empty, this, gclass14_5[int_6].int_0, null);
		else
			gclass14_1 = gclass14_8;
	}

	public static void smethod_5()
	{
		if (gclass14_7 != null && gclass14_7.method_4())
			gclass14_7.method_1();
	}

	public override void updateKey()
	{
		if (GClass39.bool_5)
		{
			smethod_5();
			if (gclass14_6 != null && gclass14_6.method_4())
				gclass14_6.method_1();
			if (!bool_6)
			{
				if (gclass14_8 != null && gclass14_8.method_4())
					gclass14_8.method_1();
				base.updateKey();
				return;
			}
			for (int i = 0; i < gclass14_5.Length; i++)
			{
				if (gclass14_5[i] == null || !gclass14_5[i].method_4())
					continue;
				if (int_22 == -1 || int_22 == 0)
				{
					if (gclass14_5[i].string_0.IndexOf(mResources.server) != -1)
						gclass14_5[i].method_1();
				}
				else
					gclass14_5[i].method_1();
			}
		}
		else if (bool_6)
		{
			if (GClass39.bool_11[8])
			{
				int num = ((GClass76.int_12 <= 1) ? 4 : 2);
				GClass39.bool_11[8] = false;
				int_6++;
				if (int_6 > num)
					int_6 = 0;
				method_2();
			}
			if (GClass39.bool_11[2])
			{
				int num2 = ((GClass76.int_12 <= 1) ? 4 : 2);
				GClass39.bool_11[2] = false;
				int_6--;
				if (int_6 < 0)
					int_6 = num2;
				method_2();
			}
		}
		if (!bool_1)
			base.updateKey();
	}

	public static void smethod_6()
	{
		GClass27 gClass = new GClass27();
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
			sbyte_0 = (sbyte)((!GClass138.bool_0) ? sbyte_0 : (sbyte_0 + 5));
			gClass.method_5(sbyte_0);
			GClass120.smethod_0("NRlink2", gClass.method_3());
			gClass.method_4();
			GClass148.smethod_3();
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_7()
	{
		int num = 0;
		while (true)
		{
			if (num < 2)
			{
				if (!bool_0[num])
					break;
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static void smethod_8()
	{
		sbyte[] array = GClass120.smethod_1("NRlink2");
		if (array == null)
		{
			smethod_4(string_9);
			return;
		}
		GClass11 gClass = new GClass11(array);
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
			GClass148.smethod_3();
		}
		catch (Exception)
		{
		}
	}

	public static string[] smethod_9()
	{
		string[] array = null;
		sbyte[] array2 = GClass120.smethod_1("NRlink2");
		if (array2 == null)
			return null;
		GClass11 gClass = new GClass11(array2);
		if (gClass == null)
			return null;
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
			GClass56.smethod_8("len sv == " + b);
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
	}

	public override void switchToMe()
	{
		GClass64.smethod_1();
		GClass154.int_23 = 0;
		GClass154.int_22 = 0;
		method_0();
		bool_1 = false;
		GClass39.gclass149_0 = null;
		string text = GClass120.smethod_2("ResVersion");
		if (((text == null || !(text != string.Empty)) ? (-1) : int.Parse(text)) > 0)
		{
			bool_6 = true;
			GClass39.smethod_21(0);
		}
		bool_4 = true;
		gclass14_5[2 + int_7].string_0 = mResources.server + ": " + string_0[int_14];
		gclass14_1 = new GClass14(string.Empty, this, gclass14_5[int_6].int_0, null);
		gclass14_5[1 + int_7].string_0 = mResources.change_account;
		if (gclass14_5.Length == 4 + int_7)
			gclass14_5[3 + int_7].string_0 = mResources.option;
		GClass58.bool_35 = false;
		GClass138.smethod_1();
		base.switchToMe();
	}

	public void method_3()
	{
		GClass154.int_23 = 0;
		GClass154.int_22 = 0;
		method_0();
		bool_1 = false;
		GClass39.gclass149_0 = null;
		string text = GClass120.smethod_2("ResVersion");
		if (((text == null || !(text != string.Empty)) ? (-1) : int.Parse(text)) > 0)
		{
			bool_6 = true;
			GClass39.smethod_21(0);
		}
		bool_4 = true;
		gclass14_5[2 + int_7].string_0 = mResources.server + ": " + string_0[int_14];
		gclass14_1 = new GClass14(string.Empty, this, gclass14_5[int_6].int_0, null);
		gclass14_5[1 + int_7].string_0 = mResources.change_account;
		if (gclass14_5.Length == 4 + int_7)
			gclass14_5[3 + int_7].string_0 = mResources.option;
		GClass138.smethod_1();
		base.switchToMe();
	}

	public void method_4()
	{
	}

	public void method_5()
	{
		if (GClass39.gclass152_0 == null)
			GClass39.gclass152_0 = new GClass152();
		int_19 = 0;
		int_16 = 0;
		bool_2 = true;
		GClass39.gclass152_0.method_7();
		bool_5 = false;
		gclass14_8.bool_2 = true;
		gclass14_1 = new GClass14(string.Empty, this, 2, null);
	}

	public void perform(int idAction, object p)
	{
		GClass56.smethod_8("perform " + idAction);
		if (idAction == 1000)
			GClass39.smethod_4();
		if (idAction == 1 || idAction == 4)
		{
			GClass162.smethod_0().close();
			bool_7 = false;
			int_11 = 0;
			bool_6 = true;
			int_22 = 0;
			bool_5 = false;
			GClass120.smethod_13();
			switchToMe();
		}
		if (idAction == 2)
		{
			bool_2 = false;
			gclass14_8 = new GClass14(mResources.huy, this, 4, null);
			gclass14_8.int_1 = GClass39.int_10 / 2 - GClass145.int_2 / 2;
			gclass14_8.int_2 = GClass39.int_13 + 65;
			gclass14_2 = null;
			if (!GClass39.bool_5)
			{
				gclass14_8.int_1 = GClass39.int_10 / 2 - GClass145.int_2 / 2;
				gclass14_8.int_2 = GClass39.int_11 - GClass145.int_3 - 1;
			}
			gclass14_1 = new GClass14(string.Empty, this, 4, null);
			if (!bool_5)
			{
				GClass166.smethod_0().method_125(1, null);
				if (!GClass39.bool_5)
				{
					gclass14_8.bool_2 = true;
					gclass14_1 = new GClass14(string.Empty, this, 4, null);
				}
				bool_5 = true;
			}
		}
		if (idAction == 3)
		{
			GClass56.smethod_8("toi day");
			if (GClass39.gclass149_0 == null)
				GClass39.gclass149_0 = new GClass149();
			GClass39.gclass149_0.switchToMe();
			bool flag = GClass120.smethod_2("acc") != null && !GClass120.smethod_2("acc").Equals(string.Empty);
			bool flag2 = GClass120.smethod_2("userAo" + int_14) != null && !GClass120.smethod_2("userAo" + int_14).Equals(string.Empty);
			if (!flag && !flag2)
			{
				GClass39.smethod_4();
				string text = GClass120.smethod_2("userAo" + int_14);
				if (text == null || text.Equals(string.Empty))
					GClass166.smethod_0().method_122(string.Empty);
				else
				{
					GClass39.gclass149_0.bool_12 = true;
					GClass39.smethod_4();
					GClass166.smethod_0().method_34();
					GClass166.smethod_0().method_38(text, string.Empty, GClass113.string_2, 1);
				}
				if (GClass162.bool_1)
					GClass39.smethod_33();
				else
					GClass39.smethod_30(mResources.maychutathoacmatsong);
			}
			else
				GClass39.gclass149_0.method_9();
			GClass149.string_4 = string_0[int_14];
		}
		if (idAction == 10100)
		{
			if (GClass39.gclass149_0 == null)
				GClass39.gclass149_0 = new GClass149();
			GClass39.gclass149_0.switchToMe();
			GClass39.smethod_4();
			GClass166.smethod_0().method_122(string.Empty);
			GClass56.smethod_8("tao user ao");
			GClass39.smethod_33();
			GClass149.string_4 = string_0[int_14];
		}
		if (idAction == 5)
		{
			smethod_3();
			if (string_0.Length == 1)
				return;
			GClass63 gClass = new GClass63(string.Empty);
			for (int i = 0; i < string_0.Length; i++)
			{
				gClass.method_0(new GClass14(string_0[i], this, 6, null));
			}
			GClass39.gclass0_0.method_2(gClass, 0);
			if (!GClass39.bool_5)
				GClass39.gclass0_0.int_0 = int_14;
		}
		if (idAction == 6)
		{
			int_14 = GClass39.gclass0_0.int_0;
			method_1();
		}
		if (idAction == 7)
		{
			if (GClass39.gclass149_0 == null)
				GClass39.gclass149_0 = new GClass149();
			GClass39.gclass149_0.switchToMe();
		}
		if (idAction == 8)
		{
			bool flag3 = GClass120.smethod_8("lowGraphic") == 1;
			GClass63 gClass2 = new GClass63("cau hinh");
			gClass2.method_0(new GClass14(mResources.cauhinhthap, this, 9, null));
			gClass2.method_0(new GClass14(mResources.cauhinhcao, this, 10, null));
			GClass39.gclass0_0.method_2(gClass2, 0);
			if (flag3)
				GClass39.gclass0_0.int_0 = 0;
			else
				GClass39.gclass0_0.int_0 = 1;
		}
		if (idAction == 9)
		{
			GClass120.smethod_9("lowGraphic", 1);
			GClass39.smethod_34(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 10)
		{
			GClass120.smethod_9("lowGraphic", 0);
			GClass39.smethod_34(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 11)
		{
			if (GClass39.gclass149_0 == null)
				GClass39.gclass149_0 = new GClass149();
			GClass39.gclass149_0.switchToMe();
			string text2 = GClass120.smethod_2("userAo" + int_14);
			if (text2 == null || text2.Equals(string.Empty))
				GClass166.smethod_0().method_122(string.Empty);
			else
			{
				GClass39.gclass149_0.bool_12 = true;
				GClass39.smethod_4();
				GClass166.smethod_0().method_34();
				GClass166.smethod_0().method_38(text2, string.Empty, GClass113.string_2, 1);
			}
			GClass39.smethod_31(mResources.PLEASEWAIT);
			GClass56.smethod_8("tao user ao");
		}
		if (idAction == 12)
			GClass113.gclass113_0.method_1();
		if (idAction == 13 && (!bool_5 || bool_6))
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
			}
		}
		if (idAction == 14)
			GClass39.smethod_36(cmdYes: new GClass14(mResources.YES, GClass39.gclass152_0, 15, null), cmdNo: new GClass14(mResources.NO, GClass39.gclass152_0, 16, null), info: mResources.deletaDataNote);
		if (idAction == 15)
		{
			GClass120.smethod_13();
			GClass39.smethod_34(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 16)
		{
			GClass57.smethod_5();
			GClass39.gclass99_0 = null;
		}
		if (idAction == 17)
		{
			if (GClass39.gclass157_0 == null)
				GClass39.gclass157_0 = new GClass157();
			GClass39.gclass157_0.switchToMe();
		}
		if (idAction == 18)
		{
			GClass39.smethod_29();
			GClass57.smethod_5();
			if (GClass39.gclass157_0 == null)
				GClass39.gclass157_0 = new GClass157();
			GClass39.gclass157_0.switchToMe();
		}
		if (idAction == 19)
		{
			if (GClass138.int_0 == 1)
			{
				GClass57.smethod_5();
				GClass39.gclass99_0 = null;
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
			gclass14_8 = new GClass14(mResources.taidulieu, this, 2, null);
			gclass14_8.bool_2 = true;
			gclass14_8.int_1 = GClass39.int_10 / 2 - GClass145.int_2 / 2;
			gclass14_8.int_2 = GClass39.int_13 + 45;
			if (gclass14_8.int_2 > GClass39.int_11 - 26)
				gclass14_8.int_2 = GClass39.int_11 - 26;
		}
		if (!GClass39.bool_5)
		{
			int_6 = 0;
			method_2();
		}
	}

	public void method_7()
	{
		GClass154.int_22 = 0;
		GClass154.int_23 = 0;
		method_0();
		bool_6 = false;
		int_16 = 0;
		bool_4 = false;
		bool_5 = false;
		int_21 = 0;
		int_19 = 0;
		string_11 = mResources.PLEASEWAIT;
		GClass58.bool_35 = false;
		method_6();
		base.switchToMe();
	}

	public void method_8(sbyte language)
	{
		if (language == 2)
		{
			if (GClass138.int_0 == 1)
				string_9 = string_5;
			else
				string_9 = string_4;
		}
		else if (language == 1)
		{
			string_9 = string_7;
			if (GClass138.int_0 == 1)
				string_9 = string_7;
			else
				string_9 = string_6;
		}
		else
		{
			string_9 = string_3;
			if (GClass138.int_0 == 1)
				string_9 = string_3;
			else
				string_9 = string_2;
		}
		GClass138.smethod_0();
	}
}
