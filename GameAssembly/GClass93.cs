using System;
using ns0;
using ns1;
using UnityEngine;

public class GClass93 : GInterface4
{
	protected static GClass93 gclass93_0;

	protected static GClass93 gclass93_1;

	public GClass100 gclass100_0;

	public static bool bool_0 = false;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	private float float_0;

	private int int_0;

	private int int_1;

	public static bool bool_5;

	public static GClass175 gclass175_0 = new GClass175();

	public const sbyte sbyte_0 = 0;

	public const sbyte sbyte_1 = 0;

	public const sbyte sbyte_2 = 1;

	public const sbyte sbyte_3 = 2;

	public const sbyte sbyte_4 = 4;

	public const sbyte sbyte_5 = 5;

	public static GClass93 smethod_0()
	{
		if (gclass93_0 == null)
			gclass93_0 = new GClass93();
		return gclass93_0;
	}

	public static GClass93 smethod_1()
	{
		if (gclass93_1 == null)
			gclass93_1 = new GClass93();
		return gclass93_1;
	}

	public void onConnectOK(bool isMain1)
	{
		bool_4 = isMain1;
		GClass77.smethod_28();
	}

	public void onConnectionFail(bool isMain1)
	{
		bool_4 = isMain1;
		GClass77.smethod_29();
	}

	public void onDisconnected(bool isMain1)
	{
		bool_4 = isMain1;
		GClass77.smethod_30();
	}

	public void method_0(GClass100 msg)
	{
		try
		{
			int num = msg.method_1().method_5();
			GClass0 gClass = GClass167.gclass124_0.gclass0_2[num];
			gClass.int_38 = msg.method_1().method_8();
			gClass.int_32 = msg.method_1().method_2();
			gClass.gclass122_0 = new GClass122();
			try
			{
				while (true)
				{
					gClass.gclass122_0.method_0(new GClass5(msg.method_1().method_5(), msg.method_1().method_7()));
				}
			}
			catch (Exception ex)
			{
				GClass92.smethod_0("Loi tairequestItemPlayer 1" + ex.ToString());
			}
		}
		catch (Exception ex2)
		{
			GClass92.smethod_0("Loi tairequestItemPlayer 2" + ex2.ToString());
		}
	}

	public void onMessage(GClass100 msg)
	{
		GClass14.gclass122_5.method_9();
		GClass14.smethod_8("SA1", 2);
		try
		{
			if (msg.sbyte_0 != -74)
				GClass191.smethod_8("=========> [READ] cmd= " + msg.sbyte_0);
			GClass124 gClass = null;
			GClass6 gClass2 = null;
			GClass122 gClass3 = new GClass122();
			int num = 0;
			GClass14.int_100 = 15;
			Class2.smethod_0(msg);
			sbyte b = msg.sbyte_0;
			switch (b)
			{
			default:
			{
				if (b != 112)
					break;
				sbyte b56 = msg.method_1().method_2();
				GClass191.smethod_8("spec type= " + b56);
				if (b56 == 0)
				{
					GClass113.short_0 = msg.method_1().method_6();
					GClass113.string_1 = msg.method_1().method_14();
				}
				else
				{
					if (b56 != 1)
						break;
					sbyte b57 = msg.method_1().method_2();
					GClass124.smethod_1().string_4 = new string[b57][];
					GClass124.smethod_1().short_1 = new short[b57][];
					GClass14.gclass113_0.string_28 = new string[b57][];
					for (int num169 = 0; num169 < b57; num169++)
					{
						GClass14.gclass113_0.string_28[num169] = new string[2];
						string[] array18 = GClass191.smethod_30(msg.method_1().method_14(), "\n", 0);
						if (array18.Length == 2)
							GClass14.gclass113_0.string_28[num169] = array18;
						if (array18.Length == 1)
						{
							GClass14.gclass113_0.string_28[num169][0] = array18[0];
							GClass14.gclass113_0.string_28[num169][1] = string.Empty;
						}
						int num170 = msg.method_1().method_2();
						GClass124.smethod_1().string_4[num169] = new string[num170];
						GClass124.smethod_1().short_1[num169] = new short[num170];
						for (int num171 = 0; num171 < num170; num171++)
						{
							GClass124.smethod_1().short_1[num169][num171] = msg.method_1().method_6();
							GClass124.smethod_1().string_4[num169][num171] = msg.method_1().method_14();
						}
					}
					GClass14.gclass113_0.string_17[25] = GClass14.gclass113_0.string_28;
					GClass14.gclass113_0.method_210();
					GClass14.gclass113_0.method_50();
				}
				break;
			}
			case -112:
			{
				sbyte b29 = msg.method_1().method_2();
				if (b29 == 0)
					GClass167.smethod_15(msg.method_1().method_2()).clearBody();
				if (b29 == 1)
					GClass167.smethod_15(msg.method_1().method_2()).setBody(msg.method_1().method_6());
				break;
			}
			case -107:
			{
				sbyte b17 = msg.method_1().method_2();
				if (b17 == 0)
					GClass124.smethod_1().bool_38 = false;
				if (b17 == 1)
					GClass124.smethod_1().bool_38 = true;
				if (b17 != 2)
					break;
				GClass96.smethod_5();
				GClass124.smethod_2().int_119 = msg.method_1().method_6();
				GClass124.smethod_2().method_61();
				int num45 = msg.method_1().method_5();
				GClass191.smethod_8("num body = " + num45);
				GClass124.smethod_2().gclass0_2 = new GClass0[num45];
				for (int num46 = 0; num46 < num45; num46++)
				{
					short num47 = msg.method_1().method_6();
					GClass191.smethod_8("template id= " + num47);
					if (num47 == -1)
						continue;
					GClass191.smethod_8("1");
					GClass124.smethod_2().gclass0_2[num46] = new GClass0();
					GClass124.smethod_2().gclass0_2[num46].gclass203_0 = GClass17.smethod_1(num47);
					int num48 = GClass124.smethod_2().gclass0_2[num46].gclass203_0.sbyte_0;
					GClass124.smethod_2().gclass0_2[num46].int_30 = msg.method_1().method_8();
					GClass191.smethod_8("3");
					GClass124.smethod_2().gclass0_2[num46].string_0 = msg.method_1().method_14();
					GClass124.smethod_2().gclass0_2[num46].string_1 = msg.method_1().method_14();
					int num49 = msg.method_1().method_5();
					GClass191.smethod_8("option size= " + num49);
					if (num49 != 0)
					{
						GClass124.smethod_2().gclass0_2[num46].gclass5_0 = new GClass5[num49];
						for (int num50 = 0; num50 < GClass124.smethod_2().gclass0_2[num46].gclass5_0.Length; num50++)
						{
							int optionTemplateId = msg.method_1().method_5();
							int param = msg.method_1().method_7();
							GClass124.smethod_2().gclass0_2[num46].gclass5_0[num50] = new GClass5(optionTemplateId, param);
						}
					}
					int num51 = num48;
					if (num51 != 0)
					{
						if (num51 == 1)
							GClass124.smethod_2().int_120 = GClass124.smethod_2().gclass0_2[num46].gclass203_0.short_2;
					}
					else
						GClass124.smethod_2().int_121 = GClass124.smethod_2().gclass0_2[num46].gclass203_0.short_2;
				}
				GClass124.smethod_2().int_25 = msg.method_3();
				GClass124.smethod_2().int_35 = msg.method_3();
				GClass124.smethod_2().int_24 = msg.method_3();
				GClass124.smethod_2().int_36 = msg.method_3();
				GClass124.smethod_2().int_20 = msg.method_3();
				GClass124.smethod_2().string_3 = msg.method_1().method_14();
				GClass124.smethod_2().string_6 = msg.method_1().method_14();
				GClass124.smethod_2().long_2 = msg.method_1().method_9();
				GClass124.smethod_2().long_4 = msg.method_1().method_9();
				GClass124.smethod_2().sbyte_15 = msg.method_1().method_2();
				GClass124.smethod_2().int_77 = msg.method_1().method_6();
				GClass124.smethod_2().short_24 = msg.method_1().method_6();
				GClass124.smethod_2().int_22 = msg.method_1().method_2();
				GClass124.smethod_2().int_21 = msg.method_1().method_6();
				GClass124.smethod_2().gclass95_1 = new GClass95[msg.method_1().method_2()];
				GClass191.smethod_8("SKILLENT = " + GClass124.smethod_2().gclass95_1);
				for (int num52 = 0; num52 < GClass124.smethod_2().gclass95_1.Length; num52++)
				{
					short num53 = msg.method_1().method_6();
					if (num53 != -1)
					{
						GClass124.smethod_2().gclass95_1[num52] = GClass121.smethod_1(num53);
						continue;
					}
					GClass124.smethod_2().gclass95_1[num52] = new GClass95();
					GClass124.smethod_2().gclass95_1[num52].gclass205_0 = null;
					GClass124.smethod_2().gclass95_1[num52].string_0 = msg.method_1().method_14();
				}
				break;
			}
			case -99:
				GClass96.smethod_5();
				if (msg.method_1().method_2() == 0)
				{
					GClass14.gclass113_0.gclass122_9.method_9();
					int num120 = msg.method_1().method_5();
					for (int num121 = 0; num121 < num120; num121++)
					{
						GClass124 gClass35 = new GClass124();
						gClass35.int_13 = msg.method_1().method_8();
						gClass35.int_119 = msg.method_1().method_6();
						gClass35.int_118 = msg.method_1().method_6();
						gClass35.int_121 = msg.method_1().method_6();
						gClass35.int_120 = msg.method_1().method_6();
						gClass35.int_122 = msg.method_1().method_6();
						gClass35.string_3 = msg.method_1().method_14();
						GClass142 gClass36 = new GClass142(msg.method_1().method_14());
						bool flag8 = msg.method_1().method_11();
						gClass36.gclass124_0 = gClass35;
						gClass36.bool_1 = flag8;
						GClass191.smethod_8("isonline = " + flag8);
						GClass14.gclass113_0.gclass122_9.method_0(gClass36);
					}
					GClass14.gclass113_0.method_26();
					GClass14.gclass113_0.method_50();
				}
				break;
			case -98:
			{
				sbyte b5 = msg.method_1().method_2();
				GClass14.gclass116_0.bool_0 = false;
				if (b5 == 0)
					GClass14.smethod_36(msg.method_1().method_14(), new GClass118(mResources.YES, GClass14.gclass14_0, 888397, msg.method_1().method_14()), new GClass118(mResources.NO, GClass14.gclass14_0, 888396, null));
				break;
			}
			case -97:
				GClass124.smethod_1().long_5 = msg.method_1().method_8();
				break;
			case -96:
			{
				sbyte t = msg.method_1().method_2();
				GClass14.gclass113_0.gclass122_8.method_9();
				string string_ = msg.method_1().method_14();
				sbyte b16 = msg.method_1().method_2();
				for (int num42 = 0; num42 < b16; num42++)
				{
					int int_6 = msg.method_1().method_8();
					int int_7 = msg.method_1().method_8();
					short num43 = msg.method_1().method_6();
					short num44 = msg.method_1().method_6();
					short short_ = msg.method_1().method_6();
					short short_2 = msg.method_1().method_6();
					string string_2 = msg.method_1().method_14();
					string string_3 = msg.method_1().method_14();
					GClass153 gClass17 = new GClass153();
					gClass17.int_3 = int_6;
					gClass17.int_0 = num43;
					gClass17.int_1 = num44;
					gClass17.short_0 = short_;
					gClass17.short_1 = short_2;
					gClass17.string_0 = string_2;
					gClass17.string_1 = string_3;
					gClass17.string_2 = msg.method_1().method_14();
					gClass17.int_2 = int_7;
					GClass14.gclass113_0.gclass122_8.method_0(gClass17);
				}
				GClass14.gclass113_0.string_0 = string_;
				GClass14.gclass113_0.method_27(t);
				GClass14.gclass113_0.method_50();
				break;
			}
			case -95:
			{
				sbyte b13 = msg.method_1().method_2();
				GClass191.smethod_8("type= " + b13);
				if (b13 == 0)
				{
					int num20 = msg.method_1().method_8();
					short templateId = msg.method_1().method_6();
					int num21 = msg.method_3();
					GClass147.smethod_1().method_22();
					if (num20 != GClass124.smethod_1().int_13)
					{
						gClass = GClass167.smethod_14(num20);
						if (gClass == null)
						{
							if (GClass167.smethod_16(num20) == null)
							{
								GClass6 gClass9 = new GClass6(num20, false, false, false, false, false, templateId, 1, num21, 0, num21, -100, -100, 4, 0);
								gClass9.bool_13 = true;
								GClass167.gclass122_9.method_0(gClass9);
							}
						}
						else
						{
							GClass6 gClass10 = new GClass6(num20, false, false, false, false, false, templateId, 1, num21, 0, num21, (short)gClass.int_4, (short)gClass.int_5, 4, 0);
							gClass10.bool_13 = true;
							gClass.gclass6_1 = gClass10;
							GClass167.gclass122_9.method_0(gClass.gclass6_1);
						}
					}
					else
					{
						GClass124.smethod_1().gclass6_1 = new GClass6(num20, false, false, false, false, false, templateId, 1, num21, 0, num21, (short)(GClass124.smethod_1().int_4 + ((GClass124.smethod_1().int_12 != 1) ? (-40) : 40)), (short)GClass124.smethod_1().int_5, 4, 0);
						GClass124.smethod_1().gclass6_1.bool_13 = true;
						GClass98.smethod_0(new GClass85(18, GClass124.smethod_1().gclass6_1.int_8, GClass124.smethod_1().gclass6_1.int_9, 2, 10, -1));
						GClass124.smethod_1().int_72 = 30;
						GClass167.gclass122_9.method_0(GClass124.smethod_1().gclass6_1);
					}
				}
				if (b13 == 1)
				{
					int num22 = msg.method_1().method_8();
					int mobId = msg.method_1().method_2();
					GClass191.smethod_8("mod attack id= " + num22);
					if (num22 == GClass124.smethod_1().int_13)
					{
						if (GClass167.smethod_16(mobId) != null)
							GClass124.smethod_1().gclass6_1.method_23(GClass167.smethod_16(mobId));
					}
					else
					{
						gClass = GClass167.smethod_14(num22);
						if (gClass != null && GClass167.smethod_16(mobId) != null)
							gClass.gclass6_1.method_23(GClass167.smethod_16(mobId));
					}
				}
				if (b13 == 2)
				{
					int num23 = msg.method_1().method_8();
					int num24 = msg.method_1().method_8();
					int num25 = msg.method_3();
					int int_3 = msg.method_3();
					if (num23 == GClass124.smethod_1().int_13)
					{
						GClass191.smethod_8("mob dame= " + num25);
						gClass = GClass167.smethod_14(num24);
						if (gClass != null)
						{
							gClass.int_26 = int_3;
							if (GClass124.smethod_1().gclass6_1.bool_18)
								gClass.method_112(num25, 0, false, true);
							else
							{
								GClass124.smethod_1().gclass6_1.int_27 = num25;
								GClass124.smethod_1().gclass6_1.method_8(gClass);
							}
						}
					}
					else
					{
						gClass2 = GClass167.smethod_16(num23);
						if (gClass2 != null)
						{
							if (num24 != GClass124.smethod_1().int_13)
							{
								gClass = GClass167.smethod_14(num24);
								if (gClass != null)
								{
									gClass.int_26 = int_3;
									if (gClass2.bool_18)
										gClass.method_112(num25, 0, false, true);
									else
									{
										gClass2.int_27 = num25;
										gClass2.method_8(gClass);
									}
								}
							}
							else
							{
								GClass124.smethod_1().int_26 = int_3;
								if (gClass2.bool_18)
									GClass124.smethod_1().method_112(num25, 0, false, true);
								else
								{
									gClass2.int_27 = num25;
									gClass2.method_8(GClass124.smethod_1());
								}
							}
						}
					}
				}
				if (b13 == 3)
				{
					int num26 = msg.method_1().method_8();
					int mobId2 = msg.method_1().method_8();
					int int_4 = msg.method_3();
					int num27 = msg.method_3();
					gClass = null;
					gClass = ((GClass124.smethod_1().int_13 != num26) ? GClass167.smethod_14(num26) : GClass124.smethod_1());
					if (gClass != null)
					{
						gClass2 = GClass167.smethod_16(mobId2);
						if (gClass.gclass6_1 != null)
							gClass.gclass6_1.method_23(gClass2);
						if (gClass2 != null)
						{
							gClass2.int_6 = int_4;
							gClass2.method_20();
							if (num27 == 0)
							{
								gClass2.int_8 = gClass2.int_16;
								gClass2.int_9 = gClass2.int_17;
								GClass167.smethod_19(mResources.miss, gClass2.int_8, gClass2.int_9 - gClass2.int_21, 0, -2, GClass104.int_7);
							}
							else
								GClass167.smethod_19("-" + GClass138.smethod_9(num27), gClass2.int_8, gClass2.int_9 - gClass2.int_21, 0, -2, GClass104.int_8);
						}
					}
				}
				if (b13 == 4)
					;
				if (b13 == 5)
				{
					int num28 = msg.method_1().method_8();
					sbyte b14 = msg.method_1().method_2();
					int mobId3 = msg.method_1().method_8();
					int num29 = msg.method_3();
					int int_5 = msg.method_3();
					gClass = null;
					gClass = ((num28 != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num28) : GClass124.smethod_1());
					if (gClass == null)
						return;
					if ((GClass137.smethod_27(gClass.int_4, gClass.int_5) & 2) != 2)
						gClass.method_69(GClass167.gclass135_0[b14], 1);
					else
						gClass.method_69(GClass167.gclass135_0[b14], 0);
					GClass6 gClass11 = GClass167.smethod_16(mobId3);
					if (gClass.int_4 <= gClass11.int_8)
						gClass.int_12 = 1;
					else
						gClass.int_12 = -1;
					gClass.gclass6_0 = gClass11;
					gClass11.int_6 = int_5;
					gClass11.method_20();
					GClass14.smethod_8("SA83v2", 2);
					if (num29 != 0)
						GClass167.smethod_19("-" + GClass138.smethod_9(num29), gClass11.int_8, gClass11.int_9 - gClass11.int_21, 0, -2, GClass104.int_8);
					else
					{
						gClass11.int_8 = gClass11.int_16;
						gClass11.int_9 = gClass11.int_17;
						GClass167.smethod_19(mResources.miss, gClass11.int_8, gClass11.int_9 - gClass11.int_21, 0, -2, GClass104.int_7);
					}
				}
				if (b13 == 6)
				{
					int num30 = msg.method_1().method_8();
					if (num30 == GClass124.smethod_1().int_13)
						GClass124.smethod_1().gclass6_1.method_22();
					else
						GClass167.smethod_14(num30)?.gclass6_1.method_22();
				}
				if (b13 != 7)
					break;
				int num31 = msg.method_1().method_8();
				if (num31 == GClass124.smethod_1().int_13)
				{
					GClass124.smethod_1().gclass6_1 = null;
					for (int num32 = 0; num32 < GClass167.gclass122_9.method_2(); num32++)
					{
						if (((GClass6)GClass167.gclass122_9.method_3(num32)).int_25 == num31)
							GClass167.gclass122_9.method_7(num32);
					}
					break;
				}
				gClass = GClass167.smethod_14(num31);
				for (int num33 = 0; num33 < GClass167.gclass122_9.method_2(); num33++)
				{
					if (((GClass6)GClass167.gclass122_9.method_3(num33)).int_25 == num31)
						GClass167.gclass122_9.method_7(num33);
				}
				if (gClass != null)
					gClass.gclass6_1 = null;
				break;
			}
			case -94:
				while (msg.method_1().method_18() > 0)
				{
					short num123 = msg.method_1().method_6();
					int num124 = msg.method_1().method_8();
					for (int num125 = 0; num125 < GClass124.smethod_1().gclass122_0.method_2(); num125++)
					{
						GClass95 gClass37 = (GClass95)GClass124.smethod_1().gclass122_0.method_3(num125);
						if (gClass37 != null && gClass37.short_0 == num123)
						{
							if (num124 < gClass37.int_1)
								gClass37.long_1 = GClass77.smethod_18() - (gClass37.int_1 - num124);
							GClass191.smethod_8("1 chieu id= " + gClass37.gclass205_0.sbyte_0 + " cooldown= " + num124 + "curr cool down= " + gClass37.int_1);
						}
					}
				}
				break;
			case -93:
			{
				short num108 = msg.method_1().method_6();
				GClass201.sbyte_1 = new sbyte[num108];
				for (int num109 = 0; num109 < num108; num109++)
				{
					GClass201.sbyte_1[num109] = msg.method_1().method_2();
				}
				break;
			}
			case -92:
				Main.typeClient = msg.method_1().method_2();
				if (GClass141.smethod_2("ResVersion") == null)
					GClass141.smethod_13();
				GClass141.smethod_9("clienttype", Main.typeClient);
				GClass141.smethod_9("lastZoomlevel", GClass193.int_12);
				if (GClass141.smethod_2("ResVersion") == null)
					GClass14.smethod_34(mResources.plsRestartGame, 8885, null);
				break;
			case -91:
			{
				sbyte b12 = msg.method_1().method_2();
				GClass14.gclass113_0.string_4 = new string[b12];
				GClass14.gclass113_0.string_5 = new string[b12];
				for (int num19 = 0; num19 < b12; num19++)
				{
					GClass14.gclass113_0.string_4[num19] = msg.method_1().method_14();
					GClass14.gclass113_0.string_5[num19] = msg.method_1().method_14();
				}
				GClass57.smethod_0().method_6();
				break;
			}
			case -90:
			{
				sbyte b23 = msg.method_1().method_2();
				int num70 = msg.method_1().method_8();
				GClass191.smethod_8("===> UPDATE_BODY:    type = " + b23);
				gClass = ((GClass124.smethod_1().int_13 != num70) ? GClass167.smethod_14(num70) : GClass124.smethod_1());
				if (b23 != -1)
				{
					short num71 = msg.method_1().method_6();
					short num72 = msg.method_1().method_6();
					short num73 = msg.method_1().method_6();
					sbyte sbyte_ = msg.method_1().method_2();
					if (gClass != null)
					{
						if (gClass.int_13 == num70)
						{
							gClass.bool_1 = true;
							gClass.sbyte_35 = sbyte_;
							if (gClass.sbyte_35 != 0)
							{
								gClass.bool_60 = false;
								gClass.bool_36 = false;
							}
						}
						else if (gClass != null)
						{
							gClass.bool_1 = true;
							gClass.sbyte_35 = sbyte_;
						}
						if (num71 != -1)
							gClass.int_119 = num71;
						if (num72 != -1)
							gClass.int_121 = num72;
						if (num73 != -1)
							gClass.int_120 = num73;
					}
				}
				if (b23 == -1 && gClass != null)
				{
					gClass.bool_1 = false;
					gClass.sbyte_35 = 0;
				}
				if (gClass == null)
					;
				break;
			}
			case -88:
				GClass14.smethod_29();
				GClass14.gclass170_0.switchToMe();
				break;
			case -87:
			{
				GClass191.smethod_8("GET UPDATE_DATA " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_5(msg.method_1(), true);
				msg.method_1().method_4();
				sbyte[] data4 = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data4);
				GClass141.smethod_0("NRdataVersion", new sbyte[1] { GClass167.sbyte_0 });
				GClass173.bool_5 = false;
				if (GClass167.sbyte_4 == GClass167.sbyte_0 && GClass167.sbyte_5 == GClass167.sbyte_1 && GClass167.sbyte_6 == GClass167.sbyte_2 && GClass167.sbyte_7 == GClass167.sbyte_3)
				{
					GClass191.smethod_8(GClass167.sbyte_4 + "," + GClass167.sbyte_5 + "," + GClass167.sbyte_6 + "," + GClass167.sbyte_7);
					GClass167.smethod_8().method_22();
					GClass167.smethod_8().method_20();
					GClass167.smethod_8().method_21();
					GClass167.smethod_8().method_23();
					GClass2.smethod_0().method_83();
					return;
				}
				break;
			}
			case -86:
			{
				sbyte b20 = msg.method_1().method_2();
				GClass191.smethod_8("server gui ve giao dich action = " + b20);
				if (b20 == 0)
				{
					int playerID = msg.method_1().method_8();
					GClass167.smethod_8().method_115(playerID);
				}
				if (b20 == 1)
				{
					int num62 = msg.method_1().method_8();
					GClass124 gClass19 = GClass167.smethod_14(num62);
					if (gClass19 == null)
						return;
					GClass14.gclass113_0.method_62(gClass19);
					GClass14.gclass113_0.method_50();
					GClass2.smethod_0().method_15(num62);
				}
				if (b20 == 2)
				{
					sbyte b21 = msg.method_1().method_2();
					for (int num63 = 0; num63 < GClass14.gclass113_0.gclass122_6.method_2(); num63++)
					{
						GClass0 gClass20 = (GClass0)GClass14.gclass113_0.gclass122_6.method_3(num63);
						if (gClass20.int_29 == b21)
						{
							GClass14.gclass113_0.gclass122_6.method_8(gClass20);
							break;
						}
					}
				}
				if (b20 == 5)
					;
				if (b20 == 6)
				{
					GClass14.gclass113_0.bool_2 = true;
					if (GClass14.gclass113_1 != null)
						GClass14.gclass113_1.bool_2 = true;
					GClass14.gclass113_0.gclass122_7.method_9();
					if (GClass14.gclass113_1 != null)
						GClass14.gclass113_1.gclass122_7.method_9();
					int int_10 = msg.method_1().method_8();
					sbyte b22 = msg.method_1().method_2();
					GClass191.smethod_8("item size = " + b22);
					for (int num64 = 0; num64 < b22; num64++)
					{
						GClass0 gClass21 = new GClass0();
						gClass21.gclass203_0 = GClass17.smethod_1(msg.method_1().method_6());
						gClass21.int_30 = msg.method_1().method_8();
						int num65 = msg.method_1().method_5();
						if (num65 != 0)
						{
							gClass21.gclass5_0 = new GClass5[num65];
							for (int num66 = 0; num66 < gClass21.gclass5_0.Length; num66++)
							{
								int optionTemplateId3 = msg.method_1().method_5();
								int param3 = msg.method_1().method_7();
								gClass21.gclass5_0[num66] = new GClass5(optionTemplateId3, param3);
								gClass21.int_43 = GClass14.gclass113_0.method_131(gClass21);
							}
						}
						if (GClass14.gclass113_1 == null)
							GClass14.gclass113_0.gclass122_7.method_0(gClass21);
						else
							GClass14.gclass113_1.gclass122_7.method_0(gClass21);
					}
					if (GClass14.gclass113_1 == null)
					{
						GClass14.gclass113_0.int_23 = int_10;
						if (GClass14.gclass113_0.int_29 == 2)
							GClass14.gclass113_0.method_61(false);
					}
					else
					{
						GClass14.gclass113_1.method_61(false);
						GClass14.gclass113_1.int_23 = int_10;
					}
				}
				if (b20 == 7)
				{
					GClass96.smethod_5();
					if (GClass14.gclass113_0.bool_0)
						GClass14.gclass113_0.method_151();
				}
				break;
			}
			case -85:
			{
				GClass191.smethod_8("CAP CHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
				sbyte b7 = msg.method_1().method_2();
				if (b7 == 0)
				{
					int num12 = msg.method_1().method_7();
					GClass191.smethod_8("lent =" + num12);
					sbyte[] data2 = new sbyte[num12];
					msg.method_1().method_21(ref data2, 0, num12);
					GClass167.gclass20_44 = GClass20.smethod_6(data2, 0, num12);
					GClass167.smethod_8().string_8 = "-----";
					GClass167.smethod_8().string_7 = msg.method_1().method_14();
					GClass167.smethod_8().int_118 = new int[GClass167.smethod_8().string_7.Length];
					GClass167.smethod_8().gclass6_0 = new GClass6();
					GClass167.smethod_8().gclass118_2 = null;
				}
				if (b7 == 1)
					GClass3.bool_2 = true;
				if (b7 == 2)
				{
					GClass3.bool_0 = true;
					GClass167.smethod_8().gclass118_2 = GClass167.smethod_8().gclass118_10;
				}
				break;
			}
			case -84:
			{
				int index3 = msg.method_1().method_5();
				GClass6 gClass41 = null;
				try
				{
					gClass41 = (GClass6)GClass167.gclass122_9.method_3(index3);
				}
				catch (Exception)
				{
				}
				if (gClass41 != null)
					gClass41.int_7 = msg.method_1().method_8();
				break;
			}
			case -83:
			{
				sbyte b31 = msg.method_1().method_2();
				if (b31 == 0)
				{
					int num89 = msg.method_1().method_6();
					int int_13 = msg.method_1().method_6();
					int num90 = msg.method_1().method_5();
					int num91 = msg.method_1().method_8();
					msg.method_1().method_14();
					int int_14 = msg.method_1().method_6();
					int int_15 = msg.method_1().method_6();
					if (msg.method_1().method_2() == 1)
						GClass167.smethod_8().bool_64 = true;
					else
						GClass167.smethod_8().bool_64 = false;
					GClass167.smethod_8().int_129 = int_14;
					GClass167.smethod_8().int_130 = int_15;
					GClass191.smethod_8("xR= " + int_14 + " yR= " + int_15 + " +++++++++++++++++++++++++++++++++++++++");
					if (GClass124.smethod_1().int_13 != num91)
					{
						if (GClass137.int_37 == num89 && GClass137.int_39 == num90)
							GClass167.smethod_8().method_52(false);
						else if (GClass193.int_12 > 1)
						{
							GClass167.smethod_8().method_54();
						}
					}
					else
					{
						GClass14.gclass113_0.method_150();
						GClass167.smethod_8().method_52(true);
					}
					GClass167.smethod_8().int_104 = num89;
					GClass167.smethod_8().int_106 = int_13;
					GClass167.smethod_8().int_105 = num90;
				}
				if (b31 == 1)
				{
					GClass191.smethod_8("map RID = " + GClass167.smethod_8().int_104 + " zone RID= " + GClass167.smethod_8().int_105);
					GClass191.smethod_8("map ID = " + GClass137.int_37 + " zone ID= " + GClass137.int_39);
					if (GClass137.int_37 != GClass167.smethod_8().int_104 || GClass137.int_39 != GClass167.smethod_8().int_105)
					{
						GClass167.smethod_8().bool_63 = false;
						if (GClass167.smethod_8().bool_64)
							GClass167.smethod_8().bool_64 = false;
					}
					else
						GClass167.smethod_8().method_53();
				}
				if (b31 != 2)
					;
				break;
			}
			case -82:
			{
				sbyte b52 = msg.method_1().method_2();
				GClass137.int_65 = new int[b52][][];
				GClass137.int_64 = new int[b52][];
				for (int num157 = 0; num157 < b52; num157++)
				{
					sbyte b53 = msg.method_1().method_2();
					GClass137.int_64[num157] = new int[b53];
					GClass137.int_65[num157] = new int[b53][];
					for (int num158 = 0; num158 < b53; num158++)
					{
						GClass137.int_64[num157][num158] = msg.method_1().method_8();
						sbyte b54 = msg.method_1().method_2();
						GClass137.int_65[num157][num158] = new int[b54];
						for (int num159 = 0; num159 < b54; num159++)
						{
							GClass137.int_65[num157][num158][num159] = msg.method_1().method_2();
						}
					}
				}
				break;
			}
			case -81:
			{
				sbyte b33 = msg.method_1().method_2();
				if (b33 == 0)
				{
					string src = msg.method_1().method_14();
					string src2 = msg.method_1().method_14();
					GClass14.gclass113_0.method_35();
					GClass14.gclass113_0.string_24 = GClass104.gclass104_2.method_15(src, GClass113.int_55);
					GClass14.gclass113_0.string_25 = GClass104.gclass104_11.method_15(src2, GClass113.int_55);
					GClass14.gclass113_0.method_50();
				}
				if (b33 == 1)
				{
					GClass14.gclass113_0.gclass122_0.method_9();
					sbyte b34 = msg.method_1().method_2();
					for (int num97 = 0; num97 < b34; num97++)
					{
						sbyte b35 = msg.method_1().method_2();
						for (int num98 = 0; num98 < GClass124.smethod_1().gclass0_0.Length; num98++)
						{
							GClass0 gClass30 = GClass124.smethod_1().gclass0_0[num98];
							if (gClass30 != null && gClass30.int_29 == b35)
							{
								gClass30.bool_0 = true;
								GClass14.gclass113_0.gclass122_0.method_0(gClass30);
							}
						}
					}
					if (GClass14.gclass113_0.bool_0)
						GClass14.gclass113_0.method_36();
				}
				if (b33 == 2)
				{
					GClass14.gclass113_0.sbyte_8 = 0;
					GClass14.gclass113_0.method_195(0);
				}
				if (b33 == 3)
				{
					GClass14.gclass113_0.sbyte_8 = 1;
					GClass14.gclass113_0.method_195(0);
				}
				if (b33 == 4)
				{
					short short_3 = msg.method_1().method_6();
					GClass14.gclass113_0.short_3 = short_3;
					GClass14.gclass113_0.sbyte_8 = 0;
					GClass14.gclass113_0.method_195(1);
				}
				if (b33 == 5)
				{
					short short_4 = msg.method_1().method_6();
					GClass14.gclass113_0.short_3 = short_4;
					GClass14.gclass113_0.sbyte_8 = 0;
					GClass14.gclass113_0.method_195(2);
				}
				if (b33 == 6)
				{
					short short_5 = msg.method_1().method_6();
					short short_6 = msg.method_1().method_6();
					GClass14.gclass113_0.sbyte_8 = 0;
					GClass14.gclass113_0.method_195(3);
					GClass14.gclass113_0.short_1 = short_5;
					GClass14.gclass113_0.short_3 = short_6;
				}
				if (b33 == 7)
				{
					short short_7 = msg.method_1().method_6();
					GClass14.gclass113_0.short_3 = short_7;
					GClass14.gclass113_0.sbyte_8 = 0;
					GClass14.gclass113_0.method_195(4);
				}
				if (b33 == 8)
				{
					GClass14.gclass113_0.short_3 = -1;
					GClass14.gclass113_0.sbyte_8 = 1;
					GClass14.gclass113_0.method_195(4);
				}
				short num99 = 21;
				int num100 = 0;
				int num101 = 0;
				try
				{
					num99 = msg.method_1().method_6();
					num100 = msg.method_1().method_6();
					num101 = msg.method_1().method_6();
					GClass14.gclass113_0.int_153 = num100 - GClass167.int_22;
					GClass14.gclass113_0.int_154 = num101 - GClass167.int_23;
				}
				catch (Exception)
				{
				}
				for (int num102 = 0; num102 < GClass167.gclass122_10.method_2(); num102++)
				{
					GClass125 gClass31 = (GClass125)GClass167.gclass122_10.method_3(num102);
					if (gClass31.gclass120_0.int_0 == num99)
					{
						GClass14.gclass113_0.int_153 = gClass31.int_4 - GClass167.int_22;
						GClass14.gclass113_0.int_154 = gClass31.int_5 - GClass167.int_23;
						GClass14.gclass113_0.int_152 = num99;
						break;
					}
				}
				break;
			}
			case -80:
			{
				sbyte b15 = msg.method_1().method_2();
				GClass96.smethod_5();
				if (b15 == 0)
				{
					GClass14.gclass113_0.gclass122_5.method_9();
					int num35 = msg.method_1().method_5();
					for (int num36 = 0; num36 < num35; num36++)
					{
						GClass124 gClass13 = new GClass124();
						gClass13.int_13 = msg.method_1().method_8();
						gClass13.int_119 = msg.method_1().method_6();
						gClass13.int_118 = msg.method_1().method_6();
						gClass13.int_121 = msg.method_1().method_6();
						gClass13.int_120 = msg.method_1().method_6();
						gClass13.int_122 = msg.method_1().method_5();
						gClass13.string_3 = msg.method_1().method_14();
						bool flag3 = msg.method_1().method_11();
						GClass142 gClass14 = new GClass142(mResources.power + ": " + msg.method_1().method_14());
						gClass14.gclass124_0 = gClass13;
						gClass14.bool_1 = flag3;
						GClass14.gclass113_0.gclass122_5.method_0(gClass14);
					}
					GClass14.gclass113_0.method_25();
					GClass14.gclass113_0.method_50();
				}
				if (b15 == 3)
				{
					GClass122 gclass122_ = GClass14.gclass113_0.gclass122_5;
					int num37 = msg.method_1().method_8();
					GClass191.smethod_8("online offline id=" + num37);
					for (int num38 = 0; num38 < gclass122_.method_2(); num38++)
					{
						GClass142 gClass15 = (GClass142)gclass122_.method_3(num38);
						if (gClass15.gclass124_0 != null && gClass15.gclass124_0.int_13 == num37)
						{
							GClass191.smethod_8("online= " + gClass15.bool_1);
							gClass15.bool_1 = msg.method_1().method_11();
							break;
						}
					}
				}
				if (b15 != 2)
					break;
				GClass122 gclass122_2 = GClass14.gclass113_0.gclass122_5;
				int num39 = msg.method_1().method_8();
				for (int num40 = 0; num40 < gclass122_2.method_2(); num40++)
				{
					GClass142 gClass16 = (GClass142)gclass122_2.method_3(num40);
					if (gClass16.gclass124_0 != null && gClass16.gclass124_0.int_13 == num39)
					{
						gclass122_2.method_8(gClass16);
						break;
					}
				}
				if (GClass14.gclass113_0.bool_0)
					GClass14.gclass113_0.method_29();
				break;
			}
			case -79:
			{
				GClass96.smethod_5();
				msg.method_1().method_8();
				GClass124 gclass124_ = GClass14.gclass113_0.gclass124_0;
				if (gclass124_ != null)
				{
					gclass124_.long_2 = msg.method_1().method_9();
					gclass124_.string_6 = msg.method_1().method_14();
					break;
				}
				return;
			}
			case -77:
			{
				short num167 = msg.method_1().method_6();
				GClass72.sbyte_0 = new sbyte[num167];
				GClass72.short_0 = num167;
				GClass72.gclass26_0 = new GClass26[num167];
				for (int num168 = 0; num168 < num167; num168++)
				{
					GClass72.sbyte_0[num168] = msg.method_1().method_2();
				}
				break;
			}
			case -76:
			{
				sbyte b48 = msg.method_1().method_2();
				if (b48 == 0)
				{
					sbyte b49 = msg.method_1().method_2();
					if (b49 <= 0)
						return;
					GClass124.smethod_1().gclass105_0 = new GClass105[b49];
					for (int num150 = 0; num150 < b49; num150++)
					{
						GClass124.smethod_1().gclass105_0[num150] = new GClass105();
						GClass124.smethod_1().gclass105_0[num150].string_0 = num150 + 1 + ". " + msg.method_1().method_14();
						GClass124.smethod_1().gclass105_0[num150].string_1 = msg.method_1().method_14();
						GClass124.smethod_1().gclass105_0[num150].int_0 = msg.method_1().method_6();
						GClass124.smethod_1().gclass105_0[num150].bool_0 = msg.method_1().method_11();
						GClass124.smethod_1().gclass105_0[num150].bool_1 = msg.method_1().method_11();
					}
					GClass14.gclass113_0.method_9();
					GClass14.gclass113_0.method_50();
				}
				else if (b48 == 1)
				{
					int num151 = msg.method_1().method_5();
					if (GClass124.smethod_1().gclass105_0[num151] != null)
						GClass124.smethod_1().gclass105_0[num151].bool_1 = true;
				}
				break;
			}
			case -74:
				if (GClass170.bool_2)
					return;
				if (GClass14.smethod_41())
				{
					bool flag2 = true;
					sbyte b6 = msg.method_1().method_2();
					if (b6 == 0)
					{
						int num8 = msg.method_1().method_8();
						string text3 = GClass141.smethod_2("ResVersion");
						int num9 = ((text3 == null || !(text3 != string.Empty)) ? (-1) : int.Parse(text3));
						if (GClass179.smethod_0().method_3())
						{
							if (num9 != -1 && num9 == num8)
							{
								GClass191.smethod_8("login ngay");
								GClass72.smethod_0();
								GClass172.gclass20_0 = null;
								GClass170.bool_6 = true;
								if (GClass14.gclass160_0 != GClass14.gclass173_0)
									GClass14.gclass170_0.switchToMe();
							}
							else
								GClass14.gclass170_0.method_7();
						}
						else
						{
							GClass179.smethod_0().close();
							GClass170.bool_6 = true;
							GClass170.bool_7 = false;
							GClass170.int_11 = 1000;
							GClass14.gclass170_0.switchToMe();
						}
					}
					if (b6 == 1)
					{
						GClass170.string_11 = mResources.downloading_data;
						_ = (short)(GClass170.int_17 = msg.method_1().method_6());
						GClass2.smethod_0().method_125(2, null);
					}
					if (b6 == 2)
						try
						{
							bool_0 = true;
							GClass14.smethod_29();
							GClass170.int_19++;
							GClass170.int_16 = GClass170.int_19 * 100 / GClass170.int_17;
							string[] array4 = GClass191.smethod_30(msg.method_1().method_14(), "/", 0);
							string filename = "x" + GClass193.int_12 + array4[array4.Length - 1];
							int num10 = msg.method_1().method_8();
							sbyte[] data = new sbyte[num10];
							msg.method_1().method_21(ref data, 0, num10);
							GClass141.smethod_0(filename, data);
						}
						catch (Exception)
						{
							GClass14.smethod_34(mResources.pls_restart_game_error, 8885, null);
						}
					if (b6 == 3 && flag2)
					{
						bool_0 = false;
						int num11 = msg.method_1().method_8();
						GClass191.smethod_8("last version= " + num11);
						GClass141.smethod_4("ResVersion", num11 + string.Empty);
						GClass2.smethod_0().method_125(3, null);
						GClass14.smethod_29();
						GClass172.gclass20_0 = null;
						GClass72.smethod_0();
						GClass77.smethod_26();
						GClass170.bool_4 = true;
						GClass170.bool_6 = true;
						GClass167.smethod_8().method_24();
						if (GClass14.gclass160_0 != GClass14.gclass173_0)
							GClass14.gclass170_0.switchToMe();
					}
					break;
				}
				GClass2.smethod_0().method_125(3, null);
				GClass72.smethod_0();
				GClass172.gclass20_0 = null;
				if (GClass141.smethod_2("acc") != null || GClass141.smethod_2("userAo" + GClass170.int_14) != null)
					GClass173.bool_0 = true;
				GClass14.gclass173_0 = new GClass173();
				GClass14.gclass173_0.switchToMe();
				return;
			case -70:
			{
				GClass191.smethod_8("BIG MESSAGE .......................................");
				GClass14.smethod_29();
				int int_16 = msg.method_1().method_6();
				string chat3 = msg.method_1().method_14();
				GClass125 gClass38 = new GClass125(-1, 0, 0, 0, 0, 0);
				gClass38.int_70 = int_16;
				GClass88.smethod_1(chat3, 100000, gClass38);
				sbyte b43 = msg.method_1().method_2();
				if (b43 == 0)
				{
					GClass88.gclass88_1.gclass118_1 = new GClass118(mResources.CLOSE, GClass88.gclass88_1, 1001, null);
					GClass88.gclass88_1.gclass118_1.int_1 = GClass14.int_10 / 2 - 35;
					GClass88.gclass88_1.gclass118_1.int_2 = GClass14.int_11 - 35;
				}
				if (b43 == 1)
				{
					string p = msg.method_1().method_14();
					string caption2 = msg.method_1().method_14();
					GClass88.gclass88_1.gclass118_1 = new GClass118(caption2, GClass88.gclass88_1, 1000, p);
					GClass88.gclass88_1.gclass118_1.int_1 = GClass14.int_10 / 2 - 75;
					GClass88.gclass88_1.gclass118_1.int_2 = GClass14.int_11 - 35;
					GClass88.gclass88_1.gclass118_2 = new GClass118(mResources.CLOSE, GClass88.gclass88_1, 1001, null);
					GClass88.gclass88_1.gclass118_2.int_1 = GClass14.int_10 / 2 + 11;
					GClass88.gclass88_1.gclass118_2.int_2 = GClass14.int_11 - 35;
				}
				break;
			}
			case -69:
				GClass124.smethod_1().short_24 = msg.method_1().method_6();
				break;
			case -68:
				GClass124.smethod_1().int_77 = msg.method_1().method_6();
				break;
			case -67:
			{
				float_0 += 1f;
				int num134 = msg.method_1().method_8();
				sbyte[] array11 = null;
				try
				{
					array11 = GClass138.smethod_2(msg);
					if (num134 == 3896)
						;
					GClass72.gclass26_0[num134].gclass20_0 = method_6(array11);
				}
				catch (Exception)
				{
					array11 = null;
					GClass72.gclass26_0[num134].gclass20_0 = GClass20.smethod_9(new int[1], 1, 1, true);
				}
				if (array11 != null)
					GClass141.smethod_0(GClass193.int_12 + "Small" + num134, array11);
				break;
			}
			case -66:
			{
				short id = msg.method_1().method_6();
				sbyte[] data3 = GClass138.smethod_2(msg);
				GClass194 gClass24 = GClass85.smethod_2(id);
				sbyte b25 = msg.method_1().method_0();
				if (b25 == 0)
					gClass24.method_7(data3);
				else
					gClass24.method_8(data3, b25);
				sbyte[] array6 = GClass138.smethod_2(msg);
				gClass24.gclass20_0 = GClass20.smethod_6(array6, 0, array6.Length);
				break;
			}
			case -65:
			{
				GClass96.smethod_5();
				int num135 = msg.method_1().method_8();
				sbyte b44 = msg.method_1().method_2();
				if (b44 == 0)
					break;
				if (GClass124.smethod_1().int_13 == num135)
				{
					bool_5 = true;
					GClass167.int_38 = 500;
					GClass167.smethod_8().gclass118_1 = null;
					if (b44 == 0 || b44 == 1 || b44 == 3)
						GClass36.smethod_0(new GClass36(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, GClass124.smethod_1().int_119, GClass124.smethod_1().int_12, 0, true, (b44 != 1) ? b44 : GClass124.smethod_1().int_14));
					if (b44 == 2)
					{
						GClass167.int_38 = 50;
						GClass124.smethod_1().method_36();
					}
				}
				else
				{
					GClass124 gClass39 = GClass167.smethod_14(num135);
					if ((b44 == 0 || b44 == 1 || b44 == 3) && gClass39 != null)
					{
						gClass39.bool_3 = true;
						GClass36 gClass40 = new GClass36(gClass39.int_4, gClass39.int_5, gClass39.int_119, gClass39.int_12, 0, false, (b44 != 1) ? b44 : gClass39.int_14);
						gClass40.int_5 = num135;
						GClass36.smethod_0(gClass40);
					}
					if (b44 == 2)
						gClass39.method_36();
				}
				break;
			}
			case -64:
			{
				int num60 = msg.method_1().method_8();
				int int_9 = msg.method_1().method_5();
				gClass = null;
				gClass = ((num60 != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num60) : GClass124.smethod_1());
				if (gClass != null)
				{
					gClass.int_122 = int_9;
					for (int num61 = 0; num61 < 54; num61++)
					{
						gClass.method_141(0, 201 + num61);
					}
					if (gClass.int_122 >= 201 && gClass.int_122 < 255)
					{
						GClass85 gClass18 = new GClass85(gClass.int_122, gClass, 2, -1, 10, 1);
						gClass18.int_1 = 5;
						gClass.method_140(gClass18);
					}
					GClass191.smethod_8("cmd:-64 UPDATE BAG PLAER = " + ((gClass == null) ? string.Empty : gClass.string_3) + num60 + " BAG ID= " + int_9);
					break;
				}
				return;
			}
			case -63:
			{
				GClass191.smethod_8("GET BAG");
				int num92 = msg.method_1().method_5();
				sbyte b32 = msg.method_1().method_2();
				GClass68 gClass27 = new GClass68();
				gClass27.int_0 = num92;
				if (b32 > 0)
				{
					gClass27.short_0 = new short[b32];
					for (int num93 = 0; num93 < b32; num93++)
					{
						gClass27.short_0[num93] = msg.method_1().method_6();
						GClass191.smethod_8("ID=  " + num92 + " frame= " + gClass27.short_0[num93]);
					}
					GClass68.gclass175_0.method_4(num92 + string.Empty, gClass27);
				}
				break;
			}
			case -62:
			{
				int num74 = msg.method_1().method_5();
				sbyte b24 = msg.method_1().method_2();
				if (b24 <= 0)
					break;
				GClass68 gClass22 = GClass68.smethod_1((short)num74);
				if (gClass22 == null)
					break;
				gClass22.short_0 = new short[b24];
				for (int num75 = 0; num75 < b24; num75++)
				{
					gClass22.short_0[num75] = msg.method_1().method_6();
					if (gClass22.short_0[num75] > 0)
						GClass72.gclass122_0.method_0(gClass22.short_0[num75] + string.Empty);
				}
				break;
			}
			case -61:
			{
				int num4 = msg.method_1().method_8();
				if (num4 != GClass124.smethod_1().int_13)
				{
					if (GClass167.smethod_14(num4) != null)
					{
						GClass167.smethod_14(num4).int_56 = msg.method_1().method_8();
						if (GClass167.smethod_14(num4).int_56 == -2)
							GClass167.smethod_14(num4).bool_59 = true;
					}
				}
				else if (GClass124.smethod_1().gclass187_0 != null)
				{
					GClass124.smethod_1().gclass187_0.int_0 = msg.method_1().method_8();
				}
				break;
			}
			case -60:
			{
				GClass14.smethod_8("SA7666", 2);
				int num142 = msg.method_1().method_8();
				int num143 = -1;
				if (num142 == GClass124.smethod_1().int_13)
				{
					msg.method_1().method_2();
					msg.method_1().method_2();
					num143 = msg.method_1().method_8();
				}
				else
				{
					GClass124 gClass45 = GClass167.smethod_14(num142);
					if (gClass45 == null)
						return;
					if (gClass45.gclass119_0 != null)
					{
						gClass45.method_79(gClass45.int_4, gClass45.int_5, 10);
						gClass45.int_4 = gClass45.gclass119_0.int_0;
						gClass45.int_5 = gClass45.gclass119_0.int_1;
					}
					int num144 = msg.method_1().method_5();
					if ((GClass137.smethod_27(gClass45.int_4, gClass45.int_5) & 2) == 2)
						gClass45.method_69(GClass167.gclass135_0[num144], 0);
					else
						gClass45.method_69(GClass167.gclass135_0[num144], 1);
					GClass124[] array13 = new GClass124[msg.method_1().method_2()];
					for (num = 0; num < array13.Length; num++)
					{
						num143 = msg.method_1().method_8();
						GClass124 gClass46;
						if (num143 != GClass124.smethod_1().int_13)
							gClass46 = GClass167.smethod_14(num143);
						else
						{
							gClass46 = GClass124.smethod_1();
							if (!GClass167.bool_70 && GClass167.bool_68 && GClass167.bool_69)
							{
								GClass2.smethod_0().method_42(-1, -1);
								GClass167.bool_70 = true;
							}
						}
						array13[num] = gClass46;
						if (num == 0)
						{
							if (gClass45.int_4 <= gClass46.int_4)
								gClass45.int_12 = 1;
							else
								gClass45.int_12 = -1;
						}
					}
					if (num > 0)
					{
						gClass45.gclass124_1 = new GClass124[num];
						for (num = 0; num < gClass45.gclass124_1.Length; num++)
						{
							gClass45.gclass124_1[num] = array13[num];
						}
						gClass45.gclass6_0 = null;
						gClass45.gclass124_0 = gClass45.gclass124_1[0];
					}
				}
				try
				{
					sbyte b45 = msg.method_1().method_2();
					GClass191.smethod_8("isRead continue = " + b45);
					if (b45 != 1)
						break;
					sbyte b46 = msg.method_1().method_2();
					GClass191.smethod_8("type skill = " + b46);
					if (num143 != GClass124.smethod_1().int_13)
					{
						gClass = GClass167.smethod_14(num143);
						if (gClass == null)
							return;
						bool flag10 = false;
						int num145 = msg.method_3();
						GClass191.smethod_8("dame hit= " + num145);
						gClass.bool_7 = msg.method_1().method_11();
						GClass191.smethod_8("isDie=" + gClass.bool_7 + "---------------------------------------");
						flag10 = (gClass.bool_6 = msg.method_1().method_11());
						gClass.bool_5 = false;
						num145 = (gClass.int_39 = num145 + 0);
						if (b46 == 0)
							gClass.method_112(num145, 0, flag10, false);
					}
					else
					{
						bool flag11 = false;
						gClass = GClass124.smethod_1();
						int num146 = msg.method_3();
						GClass191.smethod_8("dame hit = " + num146);
						gClass.bool_7 = msg.method_1().method_11();
						if (gClass.bool_7)
							GClass124.bool_34 = true;
						GClass191.smethod_8("isDie=" + gClass.bool_7 + "---------------------------------------");
						flag11 = (gClass.bool_6 = msg.method_1().method_11());
						gClass.bool_5 = false;
						num146 = (gClass.int_39 = num146 + 0);
						if (b46 == 0)
							gClass.method_112(num146, 0, flag11, false);
					}
				}
				catch (Exception)
				{
				}
				break;
			}
			case -59:
			{
				sbyte typePK = msg.method_1().method_2();
				GClass167.smethod_8().method_114(msg.method_1().method_8(), msg.method_1().method_8(), msg.method_1().method_14(), typePK);
				break;
			}
			case -57:
			{
				string strInvite = msg.method_1().method_14();
				int clanID = msg.method_1().method_8();
				int code = msg.method_1().method_8();
				GClass167.smethod_8().method_28(strInvite, clanID, code);
				break;
			}
			case -53:
			{
				GClass96.smethod_5();
				bool flag = false;
				int num2 = msg.method_1().method_8();
				GClass191.smethod_8("clanId= " + num2);
				if (num2 != -1)
				{
					GClass14.gclass113_0.gclass144_0 = null;
					if (GClass124.smethod_1().gclass187_0 == null)
						GClass124.smethod_1().gclass187_0 = new GClass187();
					GClass124.smethod_1().gclass187_0.int_0 = num2;
					GClass124.smethod_1().gclass187_0.string_0 = msg.method_1().method_14();
					GClass124.smethod_1().gclass187_0.string_1 = msg.method_1().method_14();
					GClass124.smethod_1().gclass187_0.int_1 = msg.method_1().method_5();
					GClass124.smethod_1().gclass187_0.string_2 = msg.method_1().method_14();
					GClass124.smethod_1().gclass187_0.string_3 = msg.method_1().method_14();
					GClass124.smethod_1().gclass187_0.int_3 = msg.method_1().method_5();
					GClass124.smethod_1().gclass187_0.int_4 = msg.method_1().method_5();
					GClass124.smethod_1().sbyte_17 = msg.method_1().method_2();
					GClass124.smethod_1().gclass187_0.int_7 = msg.method_1().method_8();
					GClass124.smethod_1().gclass187_0.int_6 = msg.method_1().method_2();
					GClass14.gclass113_0.gclass122_2 = new GClass122();
					for (int k = 0; k < GClass124.smethod_1().gclass187_0.int_3; k++)
					{
						GClass11 gClass5 = new GClass11();
						gClass5.int_0 = msg.method_1().method_8();
						gClass5.short_0 = msg.method_1().method_6();
						gClass5.short_1 = msg.method_1().method_6();
						gClass5.short_2 = msg.method_1().method_6();
						gClass5.short_3 = msg.method_1().method_6();
						gClass5.string_0 = msg.method_1().method_14();
						gClass5.sbyte_0 = msg.method_1().method_2();
						gClass5.string_1 = msg.method_1().method_14();
						gClass5.int_1 = msg.method_1().method_8();
						gClass5.int_2 = msg.method_1().method_8();
						gClass5.int_4 = msg.method_1().method_8();
						gClass5.int_3 = msg.method_1().method_8();
						gClass5.string_2 = GClass138.smethod_6(msg.method_1().method_8());
						GClass14.gclass113_0.gclass122_2.method_0(gClass5);
					}
					int num3 = msg.method_1().method_5();
					for (int l = 0; l < num3; l++)
					{
						method_8(msg, -1);
					}
					if (GClass14.gclass113_0.bool_10 || GClass14.gclass113_0.bool_12 || GClass14.gclass113_0.bool_11)
						GClass14.gclass113_0.method_79();
					if (flag)
						GClass14.gclass113_0.method_79();
					GClass191.smethod_8("=>>>>>>>>>>>>>>>>>>>>>> -537 MY CLAN INFO");
					break;
				}
				flag = true;
				GClass124.smethod_1().gclass187_0 = null;
				GClass22.gclass122_0.method_9();
				if (GClass14.gclass113_0.gclass122_1 != null)
					GClass14.gclass113_0.gclass122_1.method_9();
				if (GClass14.gclass113_0.gclass122_2 != null)
					GClass14.gclass113_0.gclass122_2.method_9();
				if (GClass14.gclass160_0 == GClass167.smethod_8())
					GClass14.gclass113_0.method_79();
				return;
			}
			case -52:
			{
				sbyte b51 = msg.method_1().method_2();
				if (b51 == 0)
				{
					GClass11 gClass48 = new GClass11();
					gClass48.int_0 = msg.method_1().method_8();
					gClass48.short_0 = msg.method_1().method_6();
					gClass48.short_1 = msg.method_1().method_6();
					gClass48.short_2 = msg.method_1().method_6();
					gClass48.short_3 = msg.method_1().method_6();
					gClass48.string_0 = msg.method_1().method_14();
					gClass48.sbyte_0 = msg.method_1().method_2();
					gClass48.string_1 = msg.method_1().method_14();
					gClass48.int_1 = msg.method_1().method_8();
					gClass48.int_2 = msg.method_1().method_8();
					gClass48.int_4 = msg.method_1().method_8();
					gClass48.string_2 = GClass138.smethod_6(msg.method_1().method_8());
					if (GClass14.gclass113_0.gclass122_2 == null)
						GClass14.gclass113_0.gclass122_2 = new GClass122();
					GClass14.gclass113_0.gclass122_2.method_0(gClass48);
					GClass14.gclass113_0.method_78();
				}
				if (b51 == 1)
				{
					GClass14.gclass113_0.gclass122_2.method_7(msg.method_1().method_2());
					GClass14.gclass113_0.int_41--;
					GClass14.gclass113_0.method_78();
				}
				if (b51 == 2)
				{
					GClass11 gClass49 = new GClass11();
					gClass49.int_0 = msg.method_1().method_8();
					gClass49.short_0 = msg.method_1().method_6();
					gClass49.short_1 = msg.method_1().method_6();
					gClass49.short_2 = msg.method_1().method_6();
					gClass49.short_3 = msg.method_1().method_6();
					gClass49.string_0 = msg.method_1().method_14();
					gClass49.sbyte_0 = msg.method_1().method_2();
					gClass49.string_1 = msg.method_1().method_14();
					gClass49.int_1 = msg.method_1().method_8();
					gClass49.int_2 = msg.method_1().method_8();
					gClass49.int_4 = msg.method_1().method_8();
					gClass49.string_2 = GClass138.smethod_6(msg.method_1().method_8());
					for (int num153 = 0; num153 < GClass14.gclass113_0.gclass122_2.method_2(); num153++)
					{
						GClass11 gClass50 = (GClass11)GClass14.gclass113_0.gclass122_2.method_3(num153);
						if (gClass50.int_0 == gClass49.int_0)
						{
							if (GClass124.smethod_1().int_13 == gClass49.int_0)
								GClass124.smethod_1().sbyte_17 = gClass49.sbyte_0;
							GClass11 o = gClass49;
							GClass14.gclass113_0.gclass122_2.method_8(gClass50);
							GClass14.gclass113_0.gclass122_2.method_10(o, num153);
							return;
						}
					}
				}
				GClass191.smethod_8("=>>>>>>>>>>>>>>>>>>>>>> -52  MY CLAN UPDSTE");
				break;
			}
			case -51:
				GClass96.smethod_5();
				method_8(msg, 0);
				if (GClass14.gclass113_0.bool_11 && GClass14.gclass113_0.int_28 == 5)
					GClass14.gclass113_0.method_78();
				break;
			case -50:
			{
				GClass96.smethod_5();
				GClass14.gclass113_0.gclass122_1 = new GClass122();
				sbyte b47 = msg.method_1().method_2();
				for (int num149 = 0; num149 < b47; num149++)
				{
					GClass11 gClass47 = new GClass11();
					gClass47.int_0 = msg.method_1().method_8();
					gClass47.short_0 = msg.method_1().method_6();
					gClass47.short_1 = msg.method_1().method_6();
					gClass47.short_2 = msg.method_1().method_6();
					gClass47.short_3 = msg.method_1().method_6();
					gClass47.string_0 = msg.method_1().method_14();
					gClass47.sbyte_0 = msg.method_1().method_2();
					gClass47.string_1 = msg.method_1().method_14();
					gClass47.int_1 = msg.method_1().method_8();
					gClass47.int_2 = msg.method_1().method_8();
					gClass47.int_4 = msg.method_1().method_8();
					gClass47.string_2 = GClass138.smethod_6(msg.method_1().method_8());
					GClass14.gclass113_0.gclass122_1.method_0(gClass47);
				}
				GClass14.gclass113_0.bool_12 = true;
				GClass14.gclass113_0.bool_10 = false;
				GClass14.gclass113_0.bool_11 = false;
				GClass14.gclass113_0.int_41 = GClass14.gclass113_0.gclass122_1.method_2() + 2;
				GClass14.gclass113_0.method_78();
				break;
			}
			case -47:
			{
				GClass96.smethod_5();
				sbyte b40 = msg.method_1().method_2();
				GClass191.smethod_8("clan = " + b40);
				if (b40 == 0)
				{
					GClass14.gclass113_0.string_21 = mResources.cannot_find_clan;
					GClass14.gclass113_0.gclass187_1 = null;
				}
				else
				{
					GClass14.gclass113_0.gclass187_1 = new GClass187[b40];
					GClass191.smethod_8("clan search lent= " + GClass14.gclass113_0.gclass187_1.Length);
					for (int num122 = 0; num122 < GClass14.gclass113_0.gclass187_1.Length; num122++)
					{
						GClass14.gclass113_0.gclass187_1[num122] = new GClass187();
						GClass14.gclass113_0.gclass187_1[num122].int_0 = msg.method_1().method_8();
						GClass14.gclass113_0.gclass187_1[num122].string_0 = msg.method_1().method_14();
						GClass14.gclass113_0.gclass187_1[num122].string_1 = msg.method_1().method_14();
						GClass14.gclass113_0.gclass187_1[num122].int_1 = msg.method_1().method_5();
						GClass14.gclass113_0.gclass187_1[num122].string_2 = msg.method_1().method_14();
						GClass14.gclass113_0.gclass187_1[num122].string_3 = msg.method_1().method_14();
						GClass14.gclass113_0.gclass187_1[num122].int_3 = msg.method_1().method_5();
						GClass14.gclass113_0.gclass187_1[num122].int_4 = msg.method_1().method_5();
						GClass14.gclass113_0.gclass187_1[num122].int_2 = msg.method_1().method_8();
					}
				}
				GClass14.gclass113_0.bool_10 = true;
				GClass14.gclass113_0.bool_12 = false;
				GClass14.gclass113_0.bool_11 = false;
				if (GClass14.gclass113_0.bool_10)
					GClass14.gclass113_0.method_78();
				break;
			}
			case -46:
			{
				GClass96.smethod_5();
				sbyte b30 = msg.method_1().method_2();
				if (b30 == 1 || b30 == 3)
				{
					GClass14.smethod_29();
					GClass68.gclass122_0.method_9();
					int num87 = msg.method_1().method_5();
					for (int num88 = 0; num88 < num87; num88++)
					{
						GClass68 gClass26 = new GClass68();
						gClass26.int_0 = msg.method_1().method_5();
						gClass26.string_0 = msg.method_1().method_14();
						gClass26.int_1 = msg.method_1().method_8();
						gClass26.int_2 = msg.method_1().method_8();
						if (GClass68.smethod_2(gClass26.int_0))
						{
							GClass68.smethod_1((short)gClass26.int_0).string_0 = gClass26.string_0;
							GClass68.smethod_1((short)gClass26.int_0).int_1 = gClass26.int_1;
							GClass68.smethod_1((short)gClass26.int_0).int_2 = gClass26.int_2;
						}
						else
							GClass68.smethod_0(gClass26);
					}
					if (GClass124.smethod_1().gclass187_0 != null)
						GClass14.gclass113_0.method_177();
				}
				if (b30 == 4)
				{
					GClass124.smethod_1().gclass187_0.int_1 = msg.method_1().method_5();
					GClass124.smethod_1().gclass187_0.string_1 = msg.method_1().method_14();
				}
				break;
			}
			case -45:
			{
				sbyte b8 = msg.method_1().method_2();
				int num13 = msg.method_1().method_8();
				short num14 = msg.method_1().method_6();
				GClass191.smethod_8(">.SKILL_NOT_FOCUS      skillNotFocusID: " + num14 + " skill type= " + b8 + "   player use= " + num13);
				if (b8 == 20)
				{
					sbyte typeFrame = msg.method_1().method_2();
					sbyte dir = msg.method_1().method_2();
					short timeGong = msg.method_1().method_6();
					bool isFly = ((msg.method_1().method_2() != 0) ? true : false);
					sbyte typePaint = msg.method_1().method_2();
					sbyte typeItem = -1;
					try
					{
						typeItem = msg.method_1().method_2();
					}
					catch (Exception)
					{
					}
					GClass191.smethod_8(">.SKILL_NOT_FOCUS  skill typeFrame= " + typeFrame);
					((GClass124.smethod_1().int_13 != num13) ? GClass167.smethod_14(num13) : GClass124.smethod_1()).method_159(num14, isFly, typeFrame, typePaint, dir, timeGong, typeItem);
				}
				if (b8 == 21)
				{
					GClass12 gClass8 = new GClass12();
					gClass8.int_0 = msg.method_1().method_6();
					gClass8.int_1 = msg.method_1().method_6();
					short timeDame = msg.method_1().method_6();
					short rangeDame = msg.method_1().method_6();
					sbyte typePaint2 = 0;
					sbyte typeItem2 = -1;
					GClass12[] array5 = null;
					gClass = ((GClass124.smethod_1().int_13 != num13) ? GClass167.smethod_14(num13) : GClass124.smethod_1());
					try
					{
						typePaint2 = msg.method_1().method_2();
						array5 = new GClass12[msg.method_1().method_2()];
						for (int num15 = 0; num15 < array5.Length; num15++)
						{
							array5[num15] = new GClass12();
							array5[num15].sbyte_0 = msg.method_1().method_2();
							if (array5[num15].sbyte_0 == 0)
								array5[num15].int_29 = msg.method_1().method_2();
							else
								array5[num15].int_29 = msg.method_1().method_8();
						}
					}
					catch (Exception)
					{
					}
					try
					{
						typeItem2 = msg.method_1().method_2();
					}
					catch (Exception)
					{
					}
					GClass191.smethod_8(">.SKILL_NOT_FOCUS  skill targetDame= " + gClass8.int_0 + ":" + gClass8.int_1 + "    c:" + gClass.int_4 + ":" + gClass.int_5 + "   cdir:" + gClass.int_12);
					gClass.method_160(1, num14, gClass8, timeDame, rangeDame, typePaint2, array5, typeItem2);
				}
				if (b8 == 0)
				{
					GClass191.smethod_8("id use= " + num13);
					if (GClass124.smethod_1().int_13 == num13)
					{
						GClass124.smethod_1().method_28();
						GClass191.smethod_8("LOAD LAST SKILL");
					}
					else
					{
						gClass = GClass167.smethod_14(num13);
						if ((GClass137.smethod_27(gClass.int_4, gClass.int_5) & 2) != 2)
						{
							gClass.method_69(GClass167.gclass135_0[num14], 1);
							gClass.int_109 = 20;
						}
						else
							gClass.method_69(GClass167.gclass135_0[num14], 0);
					}
					sbyte b9 = msg.method_1().method_2();
					GClass191.smethod_8("npc size= " + b9);
					for (int num16 = 0; num16 < b9; num16++)
					{
						sbyte index = msg.method_1().method_2();
						sbyte int_ = msg.method_1().method_2();
						GClass191.smethod_8("index= " + index);
						if (num14 >= 42 && num14 <= 48)
						{
							((GClass6)GClass167.gclass122_9.method_3(index)).bool_2 = true;
							((GClass6)GClass167.gclass122_9.method_3(index)).int_4 = int_;
							((GClass6)GClass167.gclass122_9.method_3(index)).long_1 = (((GClass6)GClass167.gclass122_9.method_3(index)).long_2 = GClass77.smethod_18());
						}
					}
					sbyte b10 = msg.method_1().method_2();
					for (int num17 = 0; num17 < b10; num17++)
					{
						int num18 = msg.method_1().method_8();
						sbyte b11 = msg.method_1().method_2();
						GClass191.smethod_8("player ID= " + num18 + " my ID= " + GClass124.smethod_1().int_13);
						if (num14 < 42 || num14 > 48)
							continue;
						if (num18 == GClass124.smethod_1().int_13)
						{
							if (!GClass124.smethod_1().bool_46 && !GClass124.smethod_1().bool_47)
							{
								GClass167.smethod_8().bool_61 = true;
								GClass124.smethod_1().bool_22 = true;
								GClass124.smethod_1().int_80 = b11;
								GClass124.smethod_1().long_9 = (GClass124.smethod_1().long_10 = GClass77.smethod_18());
								GClass124.smethod_1().bool_36 = true;
							}
						}
						else
						{
							gClass = GClass167.smethod_14(num18);
							if (gClass != null && !gClass.bool_46 && !gClass.bool_47)
							{
								gClass.bool_22 = true;
								gClass.int_79 = b11;
								gClass.int_80 = b11;
								gClass.long_9 = (GClass167.smethod_14(num18).long_10 = GClass77.smethod_18());
							}
						}
					}
				}
				if (b8 == 1 && num13 != GClass124.smethod_1().int_13)
					GClass167.smethod_14(num13).bool_23 = true;
				if (b8 == 3)
				{
					if (num13 == GClass124.smethod_1().int_13)
					{
						GClass124.smethod_1().bool_23 = false;
						GClass147.smethod_1().method_45();
						GClass124.smethod_1().method_28();
					}
					else
						GClass167.smethod_14(num13).bool_23 = false;
				}
				if (b8 == 4)
				{
					if (num13 == GClass124.smethod_1().int_13)
					{
						GClass124.smethod_1().int_79 = msg.method_1().method_6() - 1000;
						GClass124.smethod_1().long_7 = GClass77.smethod_18();
						GClass191.smethod_8("second= " + GClass124.smethod_1().int_79 + " last= " + GClass124.smethod_1().long_7);
					}
					else if (GClass167.smethod_14(num13) != null)
					{
						int int_2 = GClass167.smethod_14(num13).int_14;
						if (int_2 == 0)
							GClass167.smethod_14(num13).method_73(false);
						else if (int_2 == 1)
						{
							GClass167.smethod_14(num13).method_73(true);
						}
						GClass167.smethod_14(num13).int_71 = num14;
						GClass167.smethod_14(num13).bool_45 = true;
						GClass167.smethod_14(num13).int_79 = msg.method_1().method_6();
						GClass167.smethod_14(num13).long_7 = GClass77.smethod_18();
					}
				}
				if (b8 == 5)
				{
					if (num13 == GClass124.smethod_1().int_13)
						GClass124.smethod_1().method_72();
					else if (GClass167.smethod_14(num13) != null)
					{
						GClass167.smethod_14(num13).method_72();
					}
				}
				if (b8 == 6)
				{
					if (num13 == GClass124.smethod_1().int_13)
						GClass124.smethod_1().method_74(GClass167.gclass135_0[num14], 0);
					else if (GClass167.smethod_14(num13) != null)
					{
						GClass167.smethod_14(num13).method_74(GClass167.gclass135_0[num14], 0);
						GClass147.smethod_1().method_8();
					}
				}
				if (b8 == 7)
				{
					if (num13 == GClass124.smethod_1().int_13)
					{
						GClass124.smethod_1().int_79 = msg.method_1().method_6();
						GClass191.smethod_8("second = " + GClass124.smethod_1().int_79);
						GClass124.smethod_1().long_7 = GClass77.smethod_18();
					}
					else if (GClass167.smethod_14(num13) != null)
					{
						GClass167.smethod_14(num13).method_73(true);
						GClass167.smethod_14(num13).int_79 = msg.method_1().method_6();
						GClass167.smethod_14(num13).long_7 = GClass77.smethod_18();
						GClass147.smethod_1().method_8();
					}
				}
				if (b8 == 8 && num13 != GClass124.smethod_1().int_13 && GClass167.smethod_14(num13) != null)
					GClass167.smethod_14(num13).method_74(GClass167.gclass135_0[num14], 0);
				break;
			}
			case -44:
			{
				bool flag9 = false;
				if (GClass14.int_10 > 2 * GClass113.int_55)
					flag9 = true;
				sbyte b41 = msg.method_1().method_2();
				int num126 = msg.method_1().method_5();
				GClass124.smethod_1().gclass0_3 = new GClass0[num126][];
				GClass14.gclass113_0.string_10 = new string[num126 + ((!flag9) ? 1 : 0)][];
				for (int num127 = 0; num127 < GClass14.gclass113_0.string_10.Length; num127++)
				{
					GClass14.gclass113_0.string_10[num127] = new string[2];
				}
				if (b41 == 2)
				{
					GClass14.gclass113_0.int_37 = new int[num126];
					GClass14.gclass113_0.int_38 = new int[num126];
				}
				if (!flag9)
					GClass14.gclass113_0.string_10[num126] = mResources.inventory;
				for (int num128 = 0; num128 < num126; num128++)
				{
					string[] array9 = GClass191.smethod_30(msg.method_1().method_14(), "\n", 0);
					if (b41 == 2)
						GClass14.gclass113_0.int_37[num128] = msg.method_1().method_5();
					if (array9.Length == 2)
						GClass14.gclass113_0.string_10[num128] = array9;
					if (array9.Length == 1)
					{
						GClass14.gclass113_0.string_10[num128][0] = array9[0];
						GClass14.gclass113_0.string_10[num128][1] = string.Empty;
					}
					int num129 = msg.method_1().method_5();
					GClass124.smethod_1().gclass0_3[num128] = new GClass0[num129];
					GClass113.string_26 = mResources.say_wat_do_u_want_to_buy;
					if (b41 == 1)
						GClass113.string_26 = mResources.say_wat_do_u_want_to_buy2;
					for (int num130 = 0; num130 < num129; num130++)
					{
						short num131 = msg.method_1().method_6();
						if (num131 == -1)
							continue;
						GClass124.smethod_1().gclass0_3[num128][num130] = new GClass0();
						GClass124.smethod_1().gclass0_3[num128][num130].gclass203_0 = GClass17.smethod_1(num131);
						GClass191.smethod_8("name " + num128 + " = " + GClass124.smethod_1().gclass0_3[num128][num130].gclass203_0.string_0 + " id templat= " + GClass124.smethod_1().gclass0_3[num128][num130].gclass203_0.short_0);
						if (b41 != 8)
						{
							if (b41 != 4)
							{
								if (b41 == 0)
								{
									GClass124.smethod_1().gclass0_3[num128][num130].int_34 = msg.method_1().method_8();
									GClass124.smethod_1().gclass0_3[num128][num130].int_36 = msg.method_1().method_8();
								}
								else if (b41 == 1)
								{
									GClass124.smethod_1().gclass0_3[num128][num130].long_0 = msg.method_1().method_9();
								}
								else if (b41 == 2)
								{
									GClass124.smethod_1().gclass0_3[num128][num130].int_27 = msg.method_1().method_6();
									GClass124.smethod_1().gclass0_3[num128][num130].int_34 = msg.method_1().method_8();
									GClass124.smethod_1().gclass0_3[num128][num130].int_36 = msg.method_1().method_8();
									GClass124.smethod_1().gclass0_3[num128][num130].sbyte_32 = msg.method_1().method_2();
									GClass124.smethod_1().gclass0_3[num128][num130].int_30 = msg.method_1().method_8();
									GClass124.smethod_1().gclass0_3[num128][num130].sbyte_33 = msg.method_1().method_2();
								}
								else if (b41 == 3)
								{
									GClass124.smethod_1().gclass0_3[num128][num130].bool_3 = true;
									GClass124.smethod_1().gclass0_3[num128][num130].short_0 = msg.method_1().method_6();
									GClass124.smethod_1().gclass0_3[num128][num130].int_39 = msg.method_1().method_8();
								}
							}
							else
								GClass124.smethod_1().gclass0_3[num128][num130].string_2 = msg.method_1().method_14();
						}
						else
						{
							GClass124.smethod_1().gclass0_3[num128][num130].int_34 = msg.method_1().method_8();
							GClass124.smethod_1().gclass0_3[num128][num130].int_36 = msg.method_1().method_8();
							GClass124.smethod_1().gclass0_3[num128][num130].int_30 = msg.method_1().method_8();
						}
						int num132 = msg.method_1().method_5();
						if (num132 != 0)
						{
							GClass124.smethod_1().gclass0_3[num128][num130].gclass5_0 = new GClass5[num132];
							for (int num133 = 0; num133 < GClass124.smethod_1().gclass0_3[num128][num130].gclass5_0.Length; num133++)
							{
								int optionTemplateId6 = msg.method_1().method_5();
								int param6 = msg.method_1().method_7();
								GClass124.smethod_1().gclass0_3[num128][num130].gclass5_0[num133] = new GClass5(optionTemplateId6, param6);
								GClass124.smethod_1().gclass0_3[num128][num130].int_43 = GClass14.gclass113_0.method_131(GClass124.smethod_1().gclass0_3[num128][num130]);
							}
						}
						sbyte b42 = msg.method_1().method_2();
						GClass124.smethod_1().gclass0_3[num128][num130].bool_4 = ((b42 != 0) ? true : false);
						if (msg.method_1().method_2() == 1)
						{
							int headTemp = msg.method_1().method_6();
							int bodyTemp = msg.method_1().method_6();
							int legTemp = msg.method_1().method_6();
							int bagTemp = msg.method_1().method_6();
							GClass124.smethod_1().gclass0_3[num128][num130].method_25(headTemp, bodyTemp, legTemp, bagTemp);
						}
						if (b41 == 2 && GClass206.int_3 >= 237)
						{
							GClass124.smethod_1().gclass0_3[num128][num130].string_3 = msg.method_1().method_14();
							GClass191.smethod_10("nguoi ki gui  " + GClass124.smethod_1().gclass0_3[num128][num130].string_3);
						}
					}
				}
				if (flag9)
				{
					if (b41 != 2)
					{
						GClass14.gclass113_1 = new GClass113();
						GClass14.gclass113_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
						GClass14.gclass113_1.method_15();
						GClass14.gclass113_1.method_50();
					}
					else
					{
						GClass14.gclass113_1 = new GClass113();
						GClass14.gclass113_1.method_10();
						GClass14.gclass113_1.method_50();
					}
				}
				GClass14.gclass113_0.string_17[1] = GClass14.gclass113_0.string_10;
				if (b41 == 2)
				{
					string[][] array10 = GClass14.gclass113_0.string_17[1];
					if (!flag9)
						GClass14.gclass113_0.string_17[1] = new string[5][]
						{
							array10[0],
							array10[1],
							array10[2],
							array10[3],
							array10[4]
						};
					else
						GClass14.gclass113_0.string_17[1] = new string[4][]
						{
							array10[0],
							array10[1],
							array10[2],
							array10[3]
						};
				}
				GClass14.gclass113_0.method_33(b41);
				GClass14.gclass113_0.method_50();
				break;
			}
			case -43:
			{
				sbyte itemAction = msg.method_1().method_2();
				sbyte where = msg.method_1().method_2();
				sbyte index2 = msg.method_1().method_2();
				string info3 = msg.method_1().method_14();
				GClass14.gclass113_0.method_193(itemAction, info3, where, index2);
				break;
			}
			case -42:
				GClass124.smethod_1().int_155 = msg.method_3();
				GClass124.smethod_1().int_156 = msg.method_3();
				GClass124.smethod_1().int_154 = msg.method_1().method_8();
				GClass124.smethod_1().int_35 = msg.method_3();
				GClass124.smethod_1().int_36 = msg.method_3();
				GClass124.smethod_1().int_25 = msg.method_3();
				GClass124.smethod_1().int_24 = msg.method_3();
				GClass124.smethod_1().int_18 = msg.method_1().method_2();
				GClass124.smethod_1().sbyte_30 = msg.method_1().method_2();
				GClass124.smethod_1().sbyte_31 = msg.method_1().method_2();
				GClass124.smethod_1().sbyte_32 = msg.method_1().method_2();
				GClass124.smethod_1().int_20 = msg.method_1().method_8();
				GClass124.smethod_1().int_21 = msg.method_1().method_8();
				GClass124.smethod_1().int_22 = msg.method_1().method_2();
				GClass124.smethod_1().long_4 = msg.method_1().method_9();
				GClass124.smethod_1().short_25 = msg.method_1().method_6();
				GClass124.smethod_1().int_157 = msg.method_1().method_6();
				GClass124.smethod_1().int_158 = msg.method_1().method_2();
				GClass96.smethod_5();
				break;
			case -41:
			{
				sbyte b39 = msg.method_1().method_2();
				GClass124.smethod_1().string_5 = new string[b39];
				for (int num119 = 0; num119 < b39; num119++)
				{
					string text5 = msg.method_1().method_14();
					GClass124.smethod_1().string_5[num119] = text5;
				}
				GClass191.smethod_8("---   xong  level caption cmd : " + msg.sbyte_0);
				break;
			}
			case -37:
			{
				sbyte b38 = msg.method_1().method_2();
				GClass191.smethod_8("cAction= " + b38);
				if (b38 != 0)
					break;
				GClass124.smethod_1().int_119 = msg.method_1().method_6();
				GClass124.smethod_1().method_61();
				int num112 = msg.method_1().method_5();
				GClass191.smethod_8("num body = " + num112);
				GClass124.smethod_1().gclass0_2 = new GClass0[num112];
				for (int num113 = 0; num113 < num112; num113++)
				{
					short num114 = msg.method_1().method_6();
					if (num114 == -1)
						continue;
					GClass124.smethod_1().gclass0_2[num113] = new GClass0();
					GClass124.smethod_1().gclass0_2[num113].gclass203_0 = GClass17.smethod_1(num114);
					int num115 = GClass124.smethod_1().gclass0_2[num113].gclass203_0.sbyte_0;
					GClass124.smethod_1().gclass0_2[num113].int_30 = msg.method_1().method_8();
					GClass124.smethod_1().gclass0_2[num113].string_0 = msg.method_1().method_14();
					GClass124.smethod_1().gclass0_2[num113].string_1 = msg.method_1().method_14();
					int num116 = msg.method_1().method_5();
					if (num116 != 0)
					{
						GClass124.smethod_1().gclass0_2[num113].gclass5_0 = new GClass5[num116];
						for (int num117 = 0; num117 < GClass124.smethod_1().gclass0_2[num113].gclass5_0.Length; num117++)
						{
							int optionTemplateId5 = msg.method_1().method_5();
							int param5 = msg.method_1().method_7();
							GClass124.smethod_1().gclass0_2[num113].gclass5_0[num117] = new GClass5(optionTemplateId5, param5);
						}
					}
					int num118 = num115;
					if (num118 == 0)
						GClass124.smethod_1().int_121 = GClass124.smethod_1().gclass0_2[num113].gclass203_0.short_2;
					else if (num118 == 1)
					{
						GClass124.smethod_1().int_120 = GClass124.smethod_1().gclass0_2[num113].gclass203_0.short_2;
					}
				}
				break;
			}
			case -36:
			{
				sbyte b27 = msg.method_1().method_2();
				GClass191.smethod_8("cAction= " + b27);
				if (b27 == 0)
				{
					int num81 = msg.method_1().method_5();
					GClass124.smethod_1().gclass0_0 = new GClass0[num81];
					GClass167.int_37 = 0;
					GClass191.smethod_8("numC=" + num81);
					for (int num82 = 0; num82 < num81; num82++)
					{
						short num83 = msg.method_1().method_6();
						if (num83 == -1)
							continue;
						GClass124.smethod_1().gclass0_0[num82] = new GClass0();
						GClass124.smethod_1().gclass0_0[num82].gclass203_0 = GClass17.smethod_1(num83);
						GClass124.smethod_1().gclass0_0[num82].int_30 = msg.method_1().method_8();
						GClass124.smethod_1().gclass0_0[num82].string_0 = msg.method_1().method_14();
						GClass124.smethod_1().gclass0_0[num82].string_1 = msg.method_1().method_14();
						GClass124.smethod_1().gclass0_0[num82].int_29 = num82;
						int num84 = msg.method_1().method_5();
						if (num84 != 0)
						{
							GClass124.smethod_1().gclass0_0[num82].gclass5_0 = new GClass5[num84];
							for (int num85 = 0; num85 < GClass124.smethod_1().gclass0_0[num82].gclass5_0.Length; num85++)
							{
								int optionTemplateId4 = msg.method_1().method_5();
								int param4 = msg.method_1().method_7();
								GClass124.smethod_1().gclass0_0[num82].gclass5_0[num85] = new GClass5(optionTemplateId4, param4);
							}
							GClass124.smethod_1().gclass0_0[num82].int_43 = GClass14.gclass113_0.method_131(GClass124.smethod_1().gclass0_0[num82]);
						}
						if (GClass124.smethod_1().gclass0_0[num82].gclass203_0.sbyte_0 != 11)
							;
						if (GClass124.smethod_1().gclass0_0[num82].gclass203_0.sbyte_0 == 6)
							GClass167.int_37 += GClass124.smethod_1().gclass0_0[num82].int_30;
					}
				}
				if (b27 == 2)
				{
					sbyte b28 = msg.method_1().method_2();
					int int_11 = msg.method_1().method_8();
					int int_12 = GClass124.smethod_1().gclass0_0[b28].int_30;
					GClass124.smethod_1().gclass0_0[b28].int_30 = int_11;
					if (GClass124.smethod_1().gclass0_0[b28].int_30 < int_12 && GClass124.smethod_1().gclass0_0[b28].gclass203_0.sbyte_0 == 6)
						GClass167.int_37 -= int_12 - GClass124.smethod_1().gclass0_0[b28].int_30;
					if (GClass124.smethod_1().gclass0_0[b28].int_30 == 0)
						GClass124.smethod_1().gclass0_0[b28] = null;
				}
				break;
			}
			case -35:
			{
				sbyte b18 = msg.method_1().method_2();
				GClass191.smethod_8("cAction= " + b18);
				if (b18 == 0)
				{
					int num54 = msg.method_1().method_5();
					GClass124.smethod_1().gclass0_1 = new GClass0[num54];
					GClass14.gclass113_0.int_39 = 0;
					for (int num55 = 0; num55 < num54; num55++)
					{
						short num56 = msg.method_1().method_6();
						if (num56 == -1)
							continue;
						GClass124.smethod_1().gclass0_1[num55] = new GClass0();
						GClass124.smethod_1().gclass0_1[num55].gclass203_0 = GClass17.smethod_1(num56);
						GClass124.smethod_1().gclass0_1[num55].int_30 = msg.method_1().method_8();
						GClass124.smethod_1().gclass0_1[num55].string_0 = msg.method_1().method_14();
						GClass124.smethod_1().gclass0_1[num55].string_1 = msg.method_1().method_14();
						int num57 = msg.method_1().method_5();
						if (num57 != 0)
						{
							GClass124.smethod_1().gclass0_1[num55].gclass5_0 = new GClass5[num57];
							for (int num58 = 0; num58 < GClass124.smethod_1().gclass0_1[num55].gclass5_0.Length; num58++)
							{
								int optionTemplateId2 = msg.method_1().method_5();
								int param2 = msg.method_1().method_7();
								GClass124.smethod_1().gclass0_1[num55].gclass5_0[num58] = new GClass5(optionTemplateId2, param2);
							}
						}
						GClass14.gclass113_0.int_39++;
					}
				}
				if (b18 == 1)
				{
					bool bool_ = false;
					try
					{
						if (msg.method_1().method_2() == 1)
							bool_ = true;
					}
					catch (Exception)
					{
					}
					GClass14.gclass113_0.method_34();
					GClass14.gclass113_0.bool_8 = bool_;
					GClass14.gclass113_0.method_50();
				}
				if (b18 == 2)
				{
					sbyte b19 = msg.method_1().method_2();
					int int_8 = msg.method_1().method_8();
					GClass124.smethod_1().gclass0_1[b19].int_30 = int_8;
					if (GClass124.smethod_1().gclass0_1[b19].int_30 == 0)
						GClass124.smethod_1().gclass0_1[b19] = null;
				}
				break;
			}
			case -34:
			{
				sbyte b3 = msg.method_1().method_2();
				GClass191.smethod_8("act= " + b3);
				if (b3 == 0 && GClass167.smethod_8().gclass126_0 != null)
				{
					GClass191.smethod_8("toi duoc day");
					GClass126 gclass126_ = GClass167.smethod_8().gclass126_0;
					gclass126_.int_192 = msg.method_1().method_6();
					gclass126_.string_16 = msg.method_1().method_14();
					gclass126_.string_16 = GClass191.smethod_15(gclass126_.string_16);
					gclass126_.int_194 = msg.method_1().method_6();
					gclass126_.int_195 = msg.method_1().method_6();
					gclass126_.int_193 = msg.method_1().method_2();
					gclass126_.int_196 = msg.method_1().method_6();
					gclass126_.int_198 = msg.method_1().method_6();
					GClass191.smethod_8("curr Peas= " + gclass126_.int_196);
					gclass126_.string_15 = msg.method_1().method_14();
					gclass126_.int_203 = msg.method_1().method_8();
					gclass126_.int_199 = gclass126_.int_203;
					sbyte b4 = msg.method_1().method_2();
					gclass126_.int_200 = new int[b4];
					gclass126_.int_201 = new int[b4];
					for (int i = 0; i < b4; i++)
					{
						gclass126_.int_200[i] = msg.method_1().method_2();
						gclass126_.int_201[i] = msg.method_1().method_2();
					}
					gclass126_.bool_83 = msg.method_1().method_10();
					gclass126_.long_20 = (gclass126_.long_21 = GClass77.smethod_18());
					GClass167.smethod_8().gclass126_0.bool_84 = true;
				}
				if (b3 == 1)
				{
					gClass3 = new GClass122();
					try
					{
						while (msg.method_1().method_18() > 0)
						{
							gClass3.method_0(new GClass118(msg.method_1().method_14(), GClass14.gclass14_0, 888392, null));
						}
					}
					catch (Exception ex)
					{
						GClass92.smethod_0("Loi MAGIC_TREE " + ex.ToString());
					}
					GClass14.gclass116_0.method_2(gClass3, 3);
				}
				if (b3 == 2)
				{
					GClass167.smethod_8().gclass126_0.int_197 = msg.method_1().method_6();
					GClass167.smethod_8().gclass126_0.int_203 = msg.method_1().method_8();
					GClass167.smethod_8().gclass126_0.long_20 = (GClass167.smethod_8().gclass126_0.long_21 = GClass77.smethod_18());
					GClass167.smethod_8().gclass126_0.bool_84 = true;
					GClass167.smethod_8().gclass126_0.bool_86 = true;
				}
				break;
			}
			case -32:
			{
				short id4 = msg.method_1().method_6();
				int num165 = msg.method_1().method_8();
				sbyte[] array17 = null;
				GClass20 gClass54 = null;
				try
				{
					array17 = new sbyte[num165];
					for (int num166 = 0; num166 < num165; num166++)
					{
						array17[num166] = msg.method_1().method_2();
					}
					gClass54 = GClass20.smethod_6(array17, 0, num165);
					GClass201.gclass175_0.method_4(id4 + string.Empty, gClass54);
				}
				catch (Exception)
				{
					array17 = null;
					GClass201.gclass175_0.method_4(id4 + string.Empty, GClass20.smethod_9(new int[1], 1, 1, true));
				}
				if (array17 != null)
				{
					if (GClass193.int_12 > 1)
						GClass141.smethod_0(GClass193.int_12 + "bgItem" + id4, array17);
					GClass158.smethod_2(id4, gClass54);
				}
				break;
			}
			case -31:
			{
				GClass137.gclass122_1.method_9();
				short num160 = msg.method_1().method_6();
				GClass191.smethod_10("[ITEM_BACKGROUND] nItem= " + num160);
				for (int num161 = 0; num161 < num160; num161++)
				{
					GClass201 gClass51 = new GClass201();
					gClass51.int_0 = num161;
					gClass51.short_0 = msg.method_1().method_6();
					gClass51.sbyte_0 = msg.method_1().method_2();
					gClass51.int_4 = msg.method_1().method_6();
					gClass51.int_5 = msg.method_1().method_6();
					sbyte b55 = msg.method_1().method_2();
					gClass51.int_7 = new int[b55];
					gClass51.int_8 = new int[b55];
					for (int num162 = 0; num162 < b55; num162++)
					{
						gClass51.int_7[num161] = msg.method_1().method_2();
						gClass51.int_8[num161] = msg.method_1().method_2();
					}
					GClass137.gclass122_1.method_0(gClass51);
				}
				break;
			}
			case -30:
				method_14(msg);
				break;
			case -29:
				method_13(msg);
				break;
			case -28:
				method_12(msg);
				break;
			case -26:
				GClass170.int_22 = 2;
				GClass14.smethod_8("SA2", 2);
				GClass14.smethod_30(msg.method_1().method_14());
				GClass96.smethod_5();
				GClass173.bool_0 = false;
				GClass124.bool_35 = false;
				if (GClass14.gclass160_0 == GClass14.gclass173_0)
					GClass14.gclass170_0.switchToMe();
				break;
			case -25:
				GClass14.smethod_8("SA3", 2);
				GClass167.gclass130_0.method_7(msg.method_1().method_14(), 0);
				break;
			case -24:
				if (GClass14.gclass160_0 is GClass167)
					GClass14.long_6 = GClass77.smethod_18() + 3000L;
				else
					GClass14.long_6 = GClass77.smethod_18() + 30000L;
				GClass124.bool_35 = true;
				GClass92.smethod_0("GET MAP INFO");
				GClass167.smethod_8().gclass126_0 = null;
				GClass14.bool_4 = true;
				GClass14.smethod_8("SA75", 2);
				GClass167.smethod_5();
				GClass14.smethod_29();
				GClass137.gclass122_0.method_9();
				GClass139.gclass122_0.method_9();
				GClass77.smethod_26();
				GClass137.int_37 = msg.method_1().method_5();
				GClass137.sbyte_2 = msg.method_1().method_2();
				GClass137.int_25 = msg.method_1().method_2();
				GClass137.int_40 = msg.method_1().method_2();
				GClass92.smethod_0("load planet from server: " + GClass137.sbyte_2 + "bgType= " + GClass137.int_41 + ".............................");
				GClass137.int_43 = msg.method_1().method_2();
				GClass137.string_1 = msg.method_1().method_14();
				GClass137.int_39 = msg.method_1().method_2();
				GClass14.smethod_8("SA75x1", 2);
				try
				{
					GClass137.smethod_24(GClass137.int_37);
				}
				catch (Exception)
				{
					GClass2.smethod_0().method_92(GClass137.int_37);
					gclass100_0 = msg;
					return;
				}
				method_10(msg);
				try
				{
					GClass137.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
				}
				catch (Exception)
				{
				}
				GClass167.int_22 = GClass167.int_28;
				GClass167.int_23 = GClass167.int_29;
				break;
			case -22:
				GClass14.smethod_8("SA65", 2);
				GClass124.bool_34 = true;
				GClass124.bool_33 = true;
				GClass167.smethod_8().int_78 = 0;
				GClass167.smethod_8().int_77 = 0;
				GClass124.smethod_1().gclass6_0 = null;
				GClass124.smethod_1().gclass125_0 = null;
				GClass124.smethod_1().gclass124_0 = null;
				GClass124.smethod_1().gclass190_0 = null;
				GClass124.smethod_1().gclass122_3.method_9();
				GClass124.smethod_1().int_73 = -9999;
				GClass124.smethod_1().int_74 = -9999;
				GClass14.smethod_19();
				GClass167.smethod_8().method_34();
				GClass167.smethod_8().gclass118_1 = null;
				break;
			case -21:
			{
				GClass14.smethod_8("SA60", 2);
				short num147 = msg.method_1().method_6();
				for (int num148 = 0; num148 < GClass167.gclass122_6.method_2(); num148++)
				{
					if (((GClass190)GClass167.gclass122_6.method_3(num148)).int_9 == num147)
					{
						GClass167.gclass122_6.method_7(num148);
						break;
					}
				}
				break;
			}
			case -20:
			{
				GClass14.smethod_8("SA61", 2);
				GClass124.smethod_1().gclass190_0 = null;
				short num137 = msg.method_1().method_6();
				for (int num138 = 0; num138 < GClass167.gclass122_6.method_2(); num138++)
				{
					GClass190 gClass42 = (GClass190)GClass167.gclass122_6.method_3(num138);
					if (gClass42.int_9 != num137)
						continue;
					gClass42.method_0(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - 10);
					string text6 = msg.method_1().method_14();
					num = 0;
					try
					{
						num = msg.method_1().method_6();
						if (gClass42.gclass203_0.sbyte_0 == 9)
						{
							num = msg.method_1().method_6();
							GClass124.smethod_1().long_6 += num;
							GClass124.smethod_1().string_0 = GClass77.smethod_6(GClass124.smethod_1().long_6);
						}
						else if (gClass42.gclass203_0.sbyte_0 == 10)
						{
							num = msg.method_1().method_6();
							GClass124.smethod_1().int_68 += num;
							GClass124.smethod_1().string_1 = GClass77.smethod_6(GClass124.smethod_1().int_68);
						}
						else if (gClass42.gclass203_0.sbyte_0 == 34)
						{
							num = msg.method_1().method_6();
							GClass124.smethod_1().int_69 += num;
							GClass124.smethod_1().string_2 = GClass77.smethod_6(GClass124.smethod_1().int_69);
						}
					}
					catch (Exception)
					{
					}
					if (!text6.Equals(string.Empty))
					{
						if (text6.Length == 1)
							GClass92.smethod_4("strInf.Length =1:  " + text6);
						else
							GClass167.gclass130_0.method_7(text6, 0);
						break;
					}
					if (gClass42.gclass203_0.sbyte_0 != 9)
					{
						if (gClass42.gclass203_0.sbyte_0 != 10)
						{
							if (gClass42.gclass203_0.sbyte_0 != 34)
							{
								GClass167.gclass130_0.method_7(mResources.you_receive + " " + ((num <= 0) ? string.Empty : (num + " ")) + gClass42.gclass203_0.string_0, 0);
								GClass147.smethod_1().method_9();
							}
							else
							{
								GClass167.smethod_19(((num >= 0) ? "+" : string.Empty) + num, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58, 0, -2, GClass104.int_3);
								GClass147.smethod_1().method_9();
							}
						}
						else
						{
							GClass167.smethod_19(((num >= 0) ? "+" : string.Empty) + num, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58, 0, -2, GClass104.int_5);
							GClass147.smethod_1().method_9();
						}
					}
					else
					{
						GClass167.smethod_19(((num >= 0) ? "+" : string.Empty) + num, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58, 0, -2, GClass104.int_4);
						GClass147.smethod_1().method_9();
					}
					if (num > 0 && GClass124.smethod_1().gclass25_0 != null && GClass124.smethod_1().gclass25_0.short_0 == 4683)
					{
						GClass91.smethod_0(55, GClass124.smethod_1().gclass25_0.int_9, GClass124.smethod_1().gclass25_0.int_4, 1);
						GClass91.smethod_0(55, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, 1);
					}
					break;
				}
				break;
			}
			case -19:
			{
				GClass14.smethod_8("SA62", 2);
				short num139 = msg.method_1().method_6();
				gClass = GClass167.smethod_14(msg.method_1().method_8());
				for (int num140 = 0; num140 < GClass167.gclass122_6.method_2(); num140++)
				{
					GClass190 gClass43 = (GClass190)GClass167.gclass122_6.method_3(num140);
					if (gClass43.int_9 != num139)
						continue;
					if (gClass == null)
						return;
					gClass43.method_0(gClass.int_4, gClass.int_5 - 10);
					if (gClass43.int_1 >= gClass.int_4)
					{
						if (gClass43.int_1 > gClass.int_4)
							gClass.int_12 = 1;
					}
					else
						gClass.int_12 = -1;
					break;
				}
				break;
			}
			case -18:
			{
				GClass14.smethod_8("SA63", 2);
				int num136 = msg.method_1().method_2();
				GClass167.gclass122_6.method_0(new GClass190(msg.method_1().method_6(), GClass124.smethod_1().gclass0_0[num136].gclass203_0.short_0, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, msg.method_1().method_6(), msg.method_1().method_6()));
				GClass124.smethod_1().gclass0_0[num136] = null;
				break;
			}
			case -14:
				GClass14.smethod_8("SA64", 2);
				gClass = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass != null)
				{
					GClass167.gclass122_6.method_0(new GClass190(msg.method_1().method_6(), msg.method_1().method_6(), gClass.int_4, gClass.int_5, msg.method_1().method_6(), msg.method_1().method_6()));
					break;
				}
				return;
			case -4:
			{
				GClass14.smethod_8("SA76", 2);
				gClass = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass == null)
					return;
				GClass14.smethod_8("SA76v1", 2);
				if ((GClass137.smethod_27(gClass.int_4, gClass.int_5) & 2) != 2)
					gClass.method_69(GClass167.gclass135_0[msg.method_1().method_5()], 1);
				else
					gClass.method_69(GClass167.gclass135_0[msg.method_1().method_5()], 0);
				GClass14.smethod_8("SA76v2", 2);
				gClass.gclass6_2 = new GClass6[msg.method_1().method_2()];
				for (int num110 = 0; num110 < gClass.gclass6_2.Length; num110++)
				{
					GClass6 gClass33 = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_2());
					gClass.gclass6_2[num110] = gClass33;
					if (num110 == 0)
					{
						if (gClass.int_4 <= gClass33.int_8)
							gClass.int_12 = 1;
						else
							gClass.int_12 = -1;
					}
				}
				GClass14.smethod_8("SA76v3", 2);
				gClass.gclass124_0 = null;
				gClass.gclass6_0 = gClass.gclass6_2[0];
				GClass124[] array8 = new GClass124[10];
				num = 0;
				try
				{
					for (num = 0; num < array8.Length; num++)
					{
						int num111 = msg.method_1().method_8();
						GClass124 gClass34 = (array8[num] = ((num111 != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num111) : GClass124.smethod_1()));
						if (num == 0)
						{
							if (gClass.int_4 <= gClass34.int_4)
								gClass.int_12 = 1;
							else
								gClass.int_12 = -1;
						}
					}
				}
				catch (Exception ex14)
				{
					GClass92.smethod_0("Loi PLAYER_ATTACK_N_P " + ex14.ToString());
				}
				GClass14.smethod_8("SA76v4", 2);
				if (num > 0)
				{
					gClass.gclass124_1 = new GClass124[num];
					for (num = 0; num < gClass.gclass124_1.Length; num++)
					{
						gClass.gclass124_1[num] = array8[num];
					}
					gClass.gclass124_0 = gClass.gclass124_1[0];
					gClass.gclass6_0 = null;
				}
				GClass14.smethod_8("SA76v5", 2);
				break;
			}
			case 0:
				method_1(msg);
				break;
			case 1:
			{
				bool flag5 = msg.method_1().method_10();
				GClass191.smethod_8("isRes= " + flag5);
				if (!flag5)
				{
					GClass14.smethod_30(msg.method_1().method_14());
					break;
				}
				GClass14.gclass173_0.bool_12 = false;
				GClass141.smethod_4("userAo" + GClass170.int_14, string.Empty);
				GClass14.smethod_29();
				GClass14.gclass173_0.method_9();
				break;
			}
			case 2:
				GClass124.bool_35 = false;
				GClass173.bool_13 = false;
				if (!GClass167.bool_2)
					GClass167.smethod_8().method_0();
				GClass201.smethod_0();
				GClass14.smethod_29();
				GClass163.bool_0 = true;
				GClass163.smethod_2().switchToMe();
				break;
			case 6:
				GClass14.smethod_8("SA70", 2);
				GClass124.smethod_1().long_6 = msg.method_1().method_9();
				GClass124.smethod_1().int_68 = msg.method_1().method_8();
				GClass124.smethod_1().int_69 = msg.method_1().method_8();
				GClass124.smethod_1().string_0 = GClass77.smethod_6(GClass124.smethod_1().long_6);
				GClass124.smethod_1().string_1 = GClass77.smethod_6(GClass124.smethod_1().int_68);
				GClass124.smethod_1().string_2 = GClass77.smethod_6(GClass124.smethod_1().int_69);
				GClass14.smethod_29();
				break;
			case 7:
			{
				sbyte type = msg.method_1().method_2();
				short id3 = msg.method_1().method_6();
				string info2 = msg.method_1().method_14();
				GClass14.gclass113_0.method_194(type, info2, id3);
				break;
			}
			case 11:
			{
				GClass14.smethod_8("SA9", 2);
				int num78 = msg.method_1().method_2();
				sbyte b26 = msg.method_1().method_2();
				if (b26 != 0)
					GClass6.gclass76_0[num78].gclass194_0.method_8(GClass138.smethod_2(msg), b26);
				else
					GClass6.gclass76_0[num78].gclass194_0.method_7(GClass138.smethod_2(msg));
				for (int num79 = 0; num79 < GClass167.gclass122_9.method_2(); num79++)
				{
					gClass2 = (GClass6)GClass167.gclass122_9.method_3(num79);
					if (gClass2.int_26 == num78)
					{
						gClass2.int_20 = GClass6.gclass76_0[num78].gclass194_0.int_2;
						gClass2.int_21 = GClass6.gclass76_0[num78].gclass194_0.int_3;
					}
				}
				sbyte[] array7 = GClass138.smethod_2(msg);
				GClass20 gclass20_ = GClass20.smethod_6(array7, 0, array7.Length);
				GClass6.gclass76_0[num78].gclass194_0.gclass20_0 = gclass20_;
				int num80 = msg.method_1().method_2();
				GClass6.gclass76_0[num78].gclass194_0.int_1 = num80;
				if (num80 == 1 || num80 == 2)
					method_20(msg, num78);
				break;
			}
			case 20:
				method_22(msg);
				break;
			case 24:
				method_24(msg);
				break;
			case 27:
			{
				gClass3 = new GClass122();
				msg.method_1().method_14();
				int num67 = msg.method_1().method_2();
				for (int num68 = 0; num68 < num67; num68++)
				{
					string caption = msg.method_1().method_14();
					short num69 = msg.method_1().method_6();
					gClass3.method_0(new GClass118(caption, GClass14.gclass14_0, 88819, num69));
				}
				GClass14.gclass116_0.method_0(gClass3, 3);
				break;
			}
			case 29:
				GClass14.smethod_8("SA58", 2);
				GClass167.smethod_8().method_110(msg);
				break;
			case 32:
			{
				GClass14.smethod_8("SA68", 2);
				int num5 = msg.method_1().method_6();
				for (int m = 0; m < GClass167.gclass122_10.method_2(); m++)
				{
					GClass125 gClass6 = (GClass125)GClass167.gclass122_10.method_3(m);
					if (gClass6.gclass120_0.int_0 == num5 && gClass6.Equals(GClass124.smethod_1().gclass125_0))
					{
						string chat = msg.method_1().method_14();
						string[] array2 = new string[msg.method_1().method_2()];
						for (int n = 0; n < array2.Length; n++)
						{
							array2[n] = msg.method_1().method_14();
						}
						GClass167.smethod_8().method_18(array2, gClass6);
						GClass88.smethod_4(chat, 100000, gClass6);
						return;
					}
				}
				GClass125 gClass7 = new GClass125(num5, 0, -100, 100, num5, GClass167.gclass130_0.int_0[GClass124.smethod_1().int_14][2]);
				GClass191.smethod_8((GClass124.smethod_1().gclass125_0 != null) ? "!null" : "null");
				string chat2 = msg.method_1().method_14();
				string[] array3 = new string[msg.method_1().method_2()];
				for (int num6 = 0; num6 < array3.Length; num6++)
				{
					array3[num6] = msg.method_1().method_14();
				}
				try
				{
					int num7 = (gClass7.int_70 = msg.method_1().method_6());
				}
				catch (Exception)
				{
				}
				GClass191.smethod_8((GClass124.smethod_1().gclass125_0 == null) ? "null" : "!null");
				GClass167.smethod_8().method_18(array3, gClass7);
				GClass88.smethod_4(chat2, 100000, gClass7);
				break;
			}
			case 33:
				GClass14.smethod_8("SA51", 2);
				GClass96.smethod_5();
				GClass14.smethod_27();
				GClass14.smethod_26();
				gClass3 = new GClass122();
				try
				{
					while (true)
					{
						gClass3.method_0(new GClass118(msg.method_1().method_14(), GClass14.gclass14_0, 88822, null));
					}
				}
				catch (Exception ex2)
				{
					GClass92.smethod_0("Loi OPEN_UI_MENU " + ex2.ToString());
				}
				if (GClass124.smethod_1().gclass125_0 != null)
				{
					for (int j = 0; j < GClass124.smethod_1().gclass125_0.gclass120_0.string_1.Length; j++)
					{
						string[] array = GClass124.smethod_1().gclass125_0.gclass120_0.string_1[j];
						gClass3.method_0(new GClass118(array[0], GClass14.gclass14_0, 88820, array));
					}
					GClass14.gclass116_0.method_2(gClass3, 3);
					break;
				}
				return;
			case 38:
			{
				GClass14.smethod_8("SA67", 2);
				GClass96.smethod_5();
				int num163 = msg.method_1().method_6();
				GClass191.smethod_8("OPEN_UI_SAY ID= " + num163);
				string chat4 = GClass191.smethod_15(msg.method_1().method_14());
				for (int num164 = 0; num164 < GClass167.gclass122_10.method_2(); num164++)
				{
					GClass125 gClass52 = (GClass125)GClass167.gclass122_10.method_3(num164);
					GClass191.smethod_8("npc id= " + gClass52.gclass120_0.int_0);
					if (gClass52.gclass120_0.int_0 == num163)
					{
						GClass88.smethod_2(chat4, 100000, gClass52);
						GClass14.gclass113_0.method_150();
						return;
					}
				}
				GClass125 gClass53 = new GClass125(num163, 0, 0, 0, num163, GClass167.gclass130_0.int_0[GClass124.smethod_1().int_14][2]);
				if (gClass53.gclass120_0.int_0 == 5)
					gClass53.int_13 = 5;
				try
				{
					gClass53.int_70 = msg.method_1().method_6();
				}
				catch (Exception)
				{
				}
				GClass88.smethod_2(chat4, 100000, gClass53);
				GClass14.gclass113_0.method_150();
				break;
			}
			case 39:
				GClass14.smethod_8("SA49", 2);
				GClass167.smethod_8().int_68 = 2;
				if (GClass167.smethod_8().int_67 >= 2 && GClass167.smethod_8().int_68 >= 2)
					GClass96.smethod_1();
				break;
			case 40:
			{
				GClass14.smethod_8("SA52", 2);
				GClass14.int_9 = 150;
				short taskId = msg.method_1().method_6();
				sbyte index4 = msg.method_1().method_2();
				string name = GClass191.smethod_15(msg.method_1().method_14());
				string detail = GClass191.smethod_15(msg.method_1().method_14());
				string[] array14 = new string[msg.method_1().method_2()];
				string[] array15 = new string[array14.Length];
				GClass167.int_75 = new int[array14.Length];
				GClass167.int_76 = new int[array14.Length];
				short[] array16 = new short[array14.Length];
				short count = -1;
				for (int num155 = 0; num155 < array14.Length; num155++)
				{
					string text7 = GClass191.smethod_15(msg.method_1().method_14());
					GClass167.int_75[num155] = msg.method_1().method_2();
					GClass167.int_76[num155] = msg.method_1().method_6();
					string text8 = GClass191.smethod_15(msg.method_1().method_14());
					array16[num155] = -1;
					if (!text7.Equals(string.Empty))
					{
						array14[num155] = text7;
						array15[num155] = text8;
					}
				}
				try
				{
					count = msg.method_1().method_6();
					for (int num156 = 0; num156 < array14.Length; num156++)
					{
						array16[num156] = msg.method_1().method_6();
					}
				}
				catch (Exception ex23)
				{
					GClass92.smethod_0("Loi TASK_GET " + ex23.ToString());
				}
				GClass124.smethod_1().gclass70_0 = new GClass70(taskId, index4, name, detail, array14, array16, count, array15);
				if (GClass124.smethod_1().gclass125_0 != null)
					GClass125.smethod_10();
				GClass124.smethod_0(false);
				break;
			}
			case 41:
				GClass14.smethod_8("SA53", 2);
				GClass14.int_9 = 100;
				GClass191.smethod_8("TASK NEXT");
				GClass124.smethod_1().gclass70_0.int_0++;
				GClass124.smethod_1().gclass70_0.short_2 = 0;
				GClass125.smethod_10();
				GClass124.smethod_0(true);
				break;
			case 43:
				GClass14.int_9 = 50;
				GClass14.smethod_8("SA55", 2);
				GClass124.smethod_1().gclass70_0.short_2 = msg.method_1().method_6();
				if (GClass124.smethod_1().gclass125_0 != null)
					GClass125.smethod_10();
				try
				{
					short short_8 = msg.method_1().method_6();
					short short_9 = msg.method_1().method_6();
					GClass124.smethod_1().short_16 = short_8;
					GClass124.smethod_1().short_17 = short_9;
					GClass191.smethod_8("CMD   TASK_UPDATE:43_mapID =    x|y " + short_8 + "|" + short_9);
					for (int num154 = 0; num154 < GClass137.gclass122_0.method_2(); num154++)
					{
						GClass191.smethod_8("===> " + GClass137.gclass122_0.method_3(num154));
					}
				}
				catch (Exception)
				{
				}
				break;
			case 46:
				GClass14.smethod_8("SA5", 2);
				GClass92.smethod_5("Controler RESET_POINT  " + GClass124.bool_33);
				GClass124.bool_34 = false;
				GClass124.smethod_1().method_29(msg.method_1().method_6(), msg.method_1().method_6());
				break;
			case 47:
				GClass14.smethod_8("SA4", 2);
				GClass167.smethod_8().method_34();
				break;
			case 50:
			{
				sbyte b50 = msg.method_1().method_2();
				GClass113.gclass122_12.method_9();
				for (int num152 = 0; num152 < b50; num152++)
				{
					Class1 @class = new Class1();
					@class.short_0 = msg.method_1().method_6();
					@class.string_0 = msg.method_1().method_14();
					@class.string_1 = msg.method_1().method_14();
					GClass113.gclass122_12.method_0(@class);
					bool flag12 = (@class.bool_0 = ((GClass141.smethod_8(@class.short_0 + string.Empty) != -1) ? true : false));
				}
				break;
			}
			case 54:
			{
				gClass = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass == null)
					return;
				int num141 = msg.method_1().method_5();
				if ((GClass137.smethod_27(gClass.int_4, gClass.int_5) & 2) == 2)
					gClass.method_69(GClass167.gclass135_0[num141], 0);
				else
					gClass.method_69(GClass167.gclass135_0[num141], 1);
				GClass6[] array12 = new GClass6[10];
				num = 0;
				try
				{
					for (num = 0; num < array12.Length; num++)
					{
						GClass6 gClass44 = (array12[num] = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_2()));
						if (num == 0)
						{
							if (gClass.int_4 <= gClass44.int_8)
								gClass.int_12 = 1;
							else
								gClass.int_12 = -1;
						}
					}
				}
				catch (Exception)
				{
				}
				if (num > 0)
				{
					gClass.gclass6_2 = new GClass6[num];
					for (num = 0; num < gClass.gclass6_2.Length; num++)
					{
						gClass.gclass6_2[num] = array12[num];
					}
					gClass.gclass124_0 = null;
					gClass.gclass6_0 = gClass.gclass6_2[0];
				}
				break;
			}
			case 56:
			{
				GClass14.smethod_8("SXX6", 2);
				gClass = null;
				int num103 = msg.method_1().method_8();
				if (num103 == GClass124.smethod_1().int_13)
				{
					bool flag6 = false;
					gClass = GClass124.smethod_1();
					gClass.int_25 = msg.method_3();
					int num104 = msg.method_3();
					GClass191.smethod_8("dame hit = " + num104);
					if (num104 != 0)
						gClass.method_113();
					int num105 = 0;
					try
					{
						flag6 = msg.method_1().method_11();
						sbyte b36 = msg.method_1().method_2();
						if (b36 != -1)
						{
							GClass191.smethod_8("hit eff= " + b36);
							GClass98.smethod_0(new GClass85(b36, gClass.int_4, gClass.int_5, 3, 1, -1));
						}
					}
					catch (Exception)
					{
					}
					num104 += num105;
					if (GClass124.smethod_1().sbyte_19 != 4)
					{
						if (num104 != 0)
							GClass167.smethod_19("-" + GClass138.smethod_9(num104), gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, (!flag6) ? GClass104.int_3 : GClass104.int_6);
						else
							GClass167.smethod_19(mResources.miss, gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, GClass104.int_10);
					}
					break;
				}
				gClass = GClass167.smethod_14(num103);
				if (gClass == null)
					return;
				gClass.int_25 = msg.method_3();
				bool flag7 = false;
				int num106 = msg.method_3();
				if (num106 != 0)
					gClass.method_113();
				int num107 = 0;
				try
				{
					flag7 = msg.method_1().method_11();
					sbyte b37 = msg.method_1().method_2();
					if (b37 != -1)
					{
						GClass191.smethod_8("hit eff= " + b37);
						GClass98.smethod_0(new GClass85(b37, gClass.int_4, gClass.int_5, 3, 1, -1));
					}
				}
				catch (Exception)
				{
				}
				num106 += num107;
				if (gClass.sbyte_19 != 4)
				{
					if (num106 == 0)
						GClass167.smethod_19(mResources.miss, gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, GClass104.int_7);
					else
						GClass167.smethod_19("-" + GClass138.smethod_9(num106), gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, flag7 ? GClass104.int_6 : GClass104.int_8);
				}
				break;
			}
			case 57:
			{
				GClass14.smethod_8("SZ6", 2);
				GClass122 gClass32 = new GClass122();
				gClass32.method_0(new GClass118(msg.method_1().method_14(), GClass14.gclass14_0, 88817, null));
				GClass14.gclass116_0.method_2(gClass32, 3);
				break;
			}
			case 58:
			{
				GClass14.smethod_8("SZ7", 2);
				int num94 = msg.method_1().method_8();
				GClass124 gClass28 = ((num94 != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num94) : GClass124.smethod_1());
				gClass28.short_11 = new short[3];
				gClass28.short_11[0] = 0;
				short num95 = msg.method_1().method_6();
				short num96 = msg.method_1().method_6();
				gClass28.short_11[1] = num95;
				gClass28.short_11[2] = num96;
				try
				{
					num94 = msg.method_1().method_8();
					GClass124 gClass29 = ((num94 != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num94) : GClass124.smethod_1());
					gClass29.int_4 = num95;
					gClass29.int_5 = num96;
				}
				catch (Exception ex10)
				{
					GClass92.smethod_0("Loi MOVE_FAST " + ex10.ToString());
				}
				break;
			}
			case 62:
				GClass14.smethod_8("SZ3", 2);
				gClass = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass != null)
				{
					gClass.int_74 = GClass124.smethod_1().int_13;
					GClass124.smethod_1().gclass125_0 = null;
					GClass124.smethod_1().gclass6_0 = null;
					GClass124.smethod_1().gclass190_0 = null;
					GClass124.smethod_1().gclass124_0 = gClass;
					GClass124.bool_56 = true;
					GClass167.gclass130_0.method_7(gClass.string_3 + mResources.CUU_SAT, 0);
				}
				break;
			case 63:
				GClass14.smethod_8("SZ4", 2);
				GClass124.smethod_1().int_74 = msg.method_1().method_8();
				GClass124.smethod_1().gclass125_0 = null;
				GClass124.smethod_1().gclass6_0 = null;
				GClass124.smethod_1().gclass190_0 = null;
				GClass124.smethod_1().gclass124_0 = GClass167.smethod_14(GClass124.smethod_1().int_74);
				GClass124.bool_56 = true;
				break;
			case 64:
				GClass14.smethod_8("SZ5", 2);
				gClass = GClass124.smethod_1();
				try
				{
					gClass = GClass167.smethod_14(msg.method_1().method_8());
				}
				catch (Exception ex9)
				{
					GClass92.smethod_0("Loi CLEAR_CUU_SAT " + ex9.ToString());
				}
				gClass.int_74 = -9999;
				break;
			case 65:
			{
				sbyte id2 = msg.method_1().method_0();
				string text4 = msg.method_1().method_14();
				short num86 = msg.method_1().method_6();
				if (!GClass82.smethod_2(id2))
				{
					GClass82 gClass25 = new GClass82();
					gClass25.method_0(id2, text4, num86);
					GClass167.gclass122_0.method_0(gClass25);
				}
				else if (num86 != 0)
				{
					GClass82.smethod_1(id2).method_0(id2, text4, num86);
				}
				else
				{
					GClass167.gclass122_0.method_8(GClass82.smethod_1(id2));
				}
				break;
			}
			case 66:
				method_17(msg);
				break;
			case 68:
			{
				GClass191.smethod_8("ADD ITEM TO MAP --------------------------------------");
				GClass14.smethod_8("SA6333", 2);
				short itemMapID = msg.method_1().method_6();
				short itemTemplateID = msg.method_1().method_6();
				int x = msg.method_1().method_6();
				int y = msg.method_1().method_6();
				int num76 = msg.method_1().method_8();
				short r = 0;
				if (num76 == -2)
					r = msg.method_1().method_6();
				GClass190 gClass23 = new GClass190(num76, itemMapID, itemTemplateID, x, y, r);
				bool flag4 = false;
				for (int num77 = 0; num77 < GClass167.gclass122_6.method_2(); num77++)
				{
					if (((GClass190)GClass167.gclass122_6.method_3(num77)).int_9 == gClass23.int_9)
					{
						flag4 = true;
						break;
					}
				}
				if (!flag4)
					GClass167.gclass122_6.method_0(gClass23);
				break;
			}
			case 69:
				GClass147.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
				break;
			case 81:
				GClass14.smethod_8("SXX4", 2);
				((GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5())).bool_5 = msg.method_1().method_10();
				break;
			case 82:
				GClass14.smethod_8("SXX5", 2);
				((GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5())).bool_6 = msg.method_1().method_10();
				break;
			case 83:
			{
				GClass14.smethod_8("SXX8", 2);
				int num59 = msg.method_1().method_8();
				gClass = ((num59 != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num59) : GClass124.smethod_1());
				if (gClass != null)
				{
					GClass6 mobToAttack = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5());
					if (gClass.gclass6_1 != null)
						gClass.gclass6_1.method_23(mobToAttack);
					break;
				}
				return;
			}
			case 84:
			{
				int num41 = msg.method_1().method_8();
				if (num41 == GClass124.smethod_1().int_13)
					gClass = GClass124.smethod_1();
				else
				{
					gClass = GClass167.smethod_14(num41);
					if (gClass == null)
						return;
				}
				gClass.int_25 = gClass.int_35;
				gClass.int_24 = gClass.int_36;
				gClass.int_4 = msg.method_1().method_6();
				gClass.int_5 = msg.method_1().method_6();
				gClass.method_116();
				break;
			}
			case 85:
				GClass14.smethod_8("SXX5", 2);
				((GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5())).bool_7 = msg.method_1().method_10();
				break;
			case 86:
			{
				GClass14.smethod_8("SXX5", 2);
				GClass6 gClass12 = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5());
				gClass12.bool_8 = msg.method_1().method_10();
				if (!gClass12.bool_8)
					GClass91.smethod_0(77, gClass12.int_8, gClass12.int_9 - 9, 1);
				break;
			}
			case 87:
				GClass14.smethod_8("SXX5", 2);
				((GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5())).bool_9 = msg.method_1().method_10();
				break;
			case 88:
			{
				string info = msg.method_1().method_14();
				short num34 = msg.method_1().method_6();
				GClass14.gclass184_0.method_0(info, new GClass118(mResources.ACCEPT, GClass14.gclass14_0, 88818, num34), GClass136.int_11);
				break;
			}
			case 90:
				GClass14.smethod_8("SA577", 2);
				method_0(msg);
				break;
			case 92:
			{
				if (GClass14.gclass160_0 == GClass167.gclass167_0)
					GClass14.smethod_29();
				string text = msg.method_1().method_14();
				string text2 = GClass191.smethod_15(msg.method_1().method_14());
				string empty = string.Empty;
				GClass124 gClass4 = null;
				sbyte b2 = 0;
				if (!text.Equals(string.Empty))
				{
					gClass4 = new GClass124();
					gClass4.int_13 = msg.method_1().method_8();
					gClass4.int_119 = msg.method_1().method_6();
					gClass4.int_118 = msg.method_1().method_6();
					gClass4.int_121 = msg.method_1().method_6();
					gClass4.int_122 = msg.method_1().method_6();
					gClass4.int_120 = msg.method_1().method_6();
					b2 = msg.method_1().method_2();
					gClass4.string_3 = text;
				}
				empty += text2;
				GClass96.smethod_5();
				if (text.Equals(string.Empty))
				{
					GClass167.gclass130_0.method_7(empty, 0);
					break;
				}
				GClass167.gclass130_1.method_6(empty, gClass4, b2 == 0);
				if (GClass14.gclass113_0.bool_0 && GClass14.gclass113_0.int_28 == 8)
					GClass14.gclass113_0.method_80();
				break;
			}
			case 94:
				GClass14.smethod_8("SA3", 2);
				GClass167.gclass130_0.method_7(msg.method_1().method_14(), 0);
				break;
			case -111:
			case -110:
			case -109:
			case -108:
			case -106:
			case -105:
			case -104:
			case -103:
			case -102:
			case -101:
			case -100:
			case -89:
			case -78:
			case -75:
			case -73:
			case -72:
			case -71:
			case -58:
			case -56:
			case -55:
			case -54:
			case -49:
			case -48:
			case -40:
			case -39:
			case -38:
			case -33:
			case -27:
			case -23:
			case -17:
			case -16:
			case -15:
			case -13:
			case -12:
			case -11:
			case -10:
			case -9:
			case -8:
			case -7:
			case -6:
			case -5:
			case -3:
			case -2:
			case -1:
			case 3:
			case 4:
			case 5:
			case 8:
			case 9:
			case 10:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 21:
			case 22:
			case 23:
			case 25:
			case 26:
			case 28:
			case 30:
			case 31:
			case 34:
			case 35:
			case 36:
			case 37:
			case 42:
			case 44:
			case 45:
			case 48:
			case 49:
			case 51:
			case 52:
			case 53:
			case 55:
			case 59:
			case 60:
			case 61:
			case 67:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 78:
			case 79:
			case 80:
			case 89:
			case 91:
			case 93:
				break;
			}
			sbyte b58 = msg.sbyte_0;
			if (b58 <= 19)
			{
				if (b58 <= -73)
				{
					if (b58 != -75)
					{
						if (b58 == -73)
						{
							sbyte b59 = msg.method_1().method_2();
							for (int num172 = 0; num172 < GClass167.gclass122_10.method_2(); num172++)
							{
								GClass125 gClass55 = (GClass125)GClass167.gclass122_10.method_3(num172);
								if (gClass55.gclass120_0.int_0 == b59)
								{
									if (msg.method_1().method_2() == 0)
										gClass55.bool_81 = true;
									else
										gClass55.bool_81 = false;
									break;
								}
							}
						}
					}
					else
					{
						GClass6 gClass56 = null;
						try
						{
							gClass56 = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						if (gClass56 != null)
						{
							gClass56.sbyte_14 = msg.method_1().method_2();
							if (gClass56.sbyte_14 > 0)
								gClass56.int_40 = GClass191.smethod_19(0, 3);
						}
					}
				}
				else
				{
					GClass124 gClass58;
					short num178;
					sbyte sbyte_2;
					switch (b58)
					{
					default:
					{
						if (b58 != 18)
						{
							if (b58 == 19)
							{
								GClass124.smethod_1().int_75 = msg.method_1().method_7();
								GClass124.smethod_1().int_76 = msg.method_1().method_7();
							}
							break;
						}
						sbyte b62 = msg.method_1().method_2();
						for (int num183 = 0; num183 < b62; num183++)
						{
							int charId = msg.method_1().method_8();
							int int_18 = msg.method_1().method_6();
							int int_19 = msg.method_1().method_6();
							int int_20 = msg.method_3();
							GClass124 gClass62 = GClass167.smethod_14(charId);
							if (gClass62 != null)
							{
								gClass62.int_4 = int_18;
								gClass62.int_5 = int_19;
								gClass62.int_25 = (gClass62.int_28 = int_20);
								gClass62.long_1 = GClass77.smethod_18();
							}
						}
						break;
					}
					case -17:
						GClass14.smethod_8("SA88", 2);
						GClass124.smethod_1().bool_62 = true;
						GClass124.smethod_1().sbyte_18 = msg.method_1().method_2();
						GClass124.smethod_1().method_114(msg.method_1().method_6(), msg.method_1().method_6());
						try
						{
							GClass124.smethod_1().long_2 = msg.method_1().method_9();
							GClass124.smethod_1().method_4();
						}
						catch (Exception)
						{
							GClass92.smethod_0("Loi tai ME_DIE " + msg.sbyte_0);
						}
						GClass124.smethod_1().int_75 = 0;
						break;
					case -16:
						GClass14.smethod_8("SA90", 2);
						if (GClass124.smethod_1().short_22 != 0 || GClass124.smethod_1().short_23 != 0)
						{
							GClass124.smethod_1().int_4 = GClass124.smethod_1().short_22;
							GClass124.smethod_1().int_5 = GClass124.smethod_1().short_23;
							GClass124 gClass68 = GClass124.smethod_1();
							GClass124.smethod_1().short_23 = 0;
							gClass68.short_22 = 0;
						}
						GClass124.smethod_1().method_116();
						GClass124.smethod_1().bool_36 = false;
						GClass124.smethod_1().bool_62 = false;
						break;
					case -13:
					{
						GClass14.smethod_8("SA82", 2);
						int num192 = msg.method_1().method_5();
						if (num192 <= GClass167.gclass122_9.method_2() - 1 && num192 >= 0)
						{
							GClass6 gClass70 = (GClass6)GClass167.gclass122_9.method_3(num192);
							gClass70.int_29 = msg.method_1().method_2();
							gClass70.sbyte_14 = msg.method_1().method_2();
							if (gClass70.sbyte_14 != 0)
								gClass70.int_40 = GClass191.smethod_19(0, 3);
							gClass70.int_8 = gClass70.int_16;
							gClass70.int_9 = gClass70.int_17;
							gClass70.int_12 = 5;
							gClass70.bool_20 = false;
							gClass70.int_6 = msg.method_1().method_8();
							gClass70.int_7 = gClass70.int_6;
							gClass70.method_20();
							GClass91.smethod_0(60, gClass70.int_8, gClass70.int_9, 1);
							break;
						}
						return;
					}
					case -12:
					{
						GClass191.smethod_8("SERVER SEND MOB DIE");
						GClass14.smethod_8("SA85", 2);
						GClass6 gClass65 = null;
						try
						{
							gClass65 = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
							GClass92.smethod_0("LOi tai NPC_DIE cmd " + msg.sbyte_0);
						}
						if (gClass65 == null || gClass65.int_12 == 0 || gClass65.int_12 == 0)
							break;
						gClass65.method_22();
						try
						{
							int num187 = msg.method_3();
							if (!msg.method_1().method_10())
								GClass167.smethod_19("-" + GClass138.smethod_9(num187), gClass65.int_8, gClass65.int_9 - gClass65.int_21, 0, -2, GClass104.int_8);
							else
								GClass167.smethod_19("-" + GClass138.smethod_9(num187), gClass65.int_8, gClass65.int_9 - gClass65.int_21, 0, -2, GClass104.int_6);
							sbyte b63 = msg.method_1().method_2();
							for (int num188 = 0; num188 < b63; num188++)
							{
								GClass190 gClass66 = new GClass190(msg.method_1().method_6(), msg.method_1().method_6(), gClass65.int_8, gClass65.int_9, msg.method_1().method_6(), msg.method_1().method_6());
								GClass191.smethod_8("playerid= " + (int)(gClass66.int_8 = msg.method_1().method_8()) + " my id= " + GClass124.smethod_1().int_13);
								GClass167.gclass122_6.method_0(gClass66);
								if (GClass191.smethod_28(gClass66.int_2 - GClass124.smethod_1().int_5) < 24 && GClass191.smethod_28(gClass66.int_1 - GClass124.smethod_1().int_4) < 24)
									GClass124.smethod_1().gclass124_0 = null;
							}
						}
						catch (Exception)
						{
						}
						break;
					}
					case -11:
					{
						GClass14.smethod_8("SA86", 2);
						GClass6 gClass64 = null;
						try
						{
							int index5 = msg.method_1().method_5();
							gClass64 = (GClass6)GClass167.gclass122_9.method_3(index5);
						}
						catch (Exception ex32)
						{
							GClass191.smethod_8("Loi tai NPC_ATTACK_ME " + msg.sbyte_0 + " err= " + ex32.StackTrace);
						}
						if (gClass64 != null)
						{
							GClass124.smethod_1().bool_7 = false;
							GClass124.bool_34 = false;
							int num185 = msg.method_3();
							int num186;
							try
							{
								num186 = msg.method_3();
							}
							catch (Exception)
							{
								num186 = 0;
							}
							if (!gClass64.bool_18)
							{
								gClass64.int_27 = num185;
								gClass64.int_28 = num186;
								gClass64.method_8(GClass124.smethod_1());
							}
							else
								GClass124.smethod_1().method_112(num185, num186, false, true);
						}
						break;
					}
					case -10:
					{
						GClass14.smethod_8("SA87", 2);
						GClass6 gClass57 = null;
						try
						{
							gClass57 = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						GClass14.smethod_8("SA87x1", 2);
						if (gClass57 != null)
						{
							GClass14.smethod_8("SA87x2", 2);
							gClass = GClass167.smethod_14(msg.method_1().method_8());
							if (gClass == null)
								return;
							GClass14.smethod_8("SA87x3", 2);
							int num175 = msg.method_3();
							gClass57.int_27 = gClass.int_25 - num175;
							gClass.int_26 = num175;
							GClass14.smethod_8("SA87x4", 2);
							try
							{
								gClass.int_24 = msg.method_3();
							}
							catch (Exception)
							{
							}
							GClass14.smethod_8("SA87x5", 2);
							if (!gClass57.bool_18)
								gClass57.method_8(gClass);
							else
								gClass.method_112(gClass57.int_27, 0, false, true);
							GClass14.smethod_8("SA87x6", 2);
						}
						break;
					}
					case -9:
					{
						GClass14.smethod_8("SA83", 2);
						GClass6 gClass69 = null;
						try
						{
							gClass69 = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						GClass14.smethod_8("SA83v1", 2);
						if (gClass69 != null)
						{
							gClass69.int_6 = msg.method_3();
							gClass69.method_20();
							int num191 = msg.method_3();
							if (num191 == 1)
								return;
							if (num191 > 1)
								gClass69.method_7();
							bool flag13 = false;
							try
							{
								flag13 = msg.method_1().method_11();
							}
							catch (Exception)
							{
							}
							sbyte b64 = msg.method_1().method_2();
							if (b64 != -1)
								GClass98.smethod_0(new GClass85(b64, gClass69.int_8, gClass69.getY(), 3, 1, -1));
							GClass14.smethod_8("SA83v2", 2);
							if (flag13)
								GClass167.smethod_19("-" + GClass138.smethod_9(num191), gClass69.int_8, gClass69.getY() - gClass69.getH(), 0, -2, GClass104.int_6);
							else if (num191 != 0)
							{
								if (num191 > 1)
									GClass167.smethod_19("-" + GClass138.smethod_9(num191), gClass69.int_8, gClass69.getY() - gClass69.getH(), 0, -2, GClass104.int_8);
							}
							else
							{
								gClass69.int_8 = gClass69.int_16;
								gClass69.int_9 = gClass69.int_17;
								GClass167.smethod_19(mResources.miss, gClass69.int_8, gClass69.getY() - gClass69.getH(), 0, -2, GClass104.int_7);
							}
						}
						GClass14.smethod_8("SA83v3", 2);
						break;
					}
					case -8:
						GClass14.smethod_8("SA89", 2);
						gClass = GClass167.smethod_14(msg.method_1().method_8());
						if (gClass != null)
						{
							gClass.sbyte_18 = msg.method_1().method_2();
							gClass.method_115(msg.method_1().method_6(), msg.method_1().method_6());
							break;
						}
						return;
					case -7:
					{
						GClass14.smethod_8("SA80", 2);
						int num180 = msg.method_1().method_8();
						for (int num181 = 0; num181 < GClass167.gclass122_5.method_2(); num181++)
						{
							GClass124 gClass61 = null;
							try
							{
								gClass61 = (GClass124)GClass167.gclass122_5.method_3(num181);
							}
							catch (Exception)
							{
							}
							if (gClass61 == null)
								break;
							if (gClass61.int_13 == num180)
							{
								GClass14.smethod_8("SA8x2y" + num181, 2);
								gClass61.method_100(msg.method_1().method_6(), msg.method_1().method_6(), 0);
								gClass61.long_1 = GClass77.smethod_18();
								break;
							}
						}
						GClass14.smethod_8("SA80x3", 2);
						break;
					}
					case -6:
					{
						GClass14.smethod_8("SA81", 2);
						int num189 = msg.method_1().method_8();
						for (int num190 = 0; num190 < GClass167.gclass122_5.method_2(); num190++)
						{
							GClass124 gClass67 = (GClass124)GClass167.gclass122_5.method_3(num190);
							if (gClass67 != null && gClass67.int_13 == num189)
							{
								if (!gClass67.bool_20 && !gClass67.bool_3)
									GClass91.smethod_0(60, gClass67.int_4, gClass67.int_5, 1);
								if (!gClass67.bool_3)
									GClass167.gclass122_5.method_7(num190);
								return;
							}
						}
						break;
					}
					case -5:
					{
						GClass14.smethod_8("SA79", 2);
						int int_17 = msg.method_1().method_8();
						int num176 = msg.method_1().method_8();
						if (num176 != -100)
						{
							gClass58 = new GClass124();
							gClass58.int_13 = int_17;
							gClass58.int_56 = num176;
						}
						else
						{
							gClass58 = new Class19();
							gClass58.int_13 = int_17;
							gClass58.int_56 = num176;
						}
						if (gClass58.int_56 == -2)
							gClass58.bool_59 = true;
						if (method_16(gClass58, msg))
						{
							sbyte b60 = msg.method_1().method_2();
							if (gClass58.int_5 <= 10 && b60 != 0 && b60 != 2)
							{
								GClass191.smethod_8("nhân vật bay trên trời xuống x= " + gClass58.int_4 + " y= " + gClass58.int_5);
								GClass36 gClass59 = new GClass36(gClass58.int_4, gClass58.int_5, gClass58.int_119, gClass58.int_12, 1, false, (b60 != 1) ? b60 : gClass58.int_14);
								gClass59.int_5 = gClass58.int_13;
								gClass58.bool_2 = true;
								GClass36.smethod_0(gClass59);
							}
							if (b60 == 2)
								gClass58.method_37();
							for (int num177 = 0; num177 < GClass167.gclass122_9.method_2(); num177++)
							{
								GClass6 gClass60 = (GClass6)GClass167.gclass122_9.method_3(num177);
								if (gClass60 != null && gClass60.bool_13 && gClass60.int_25 == gClass58.int_13)
								{
									GClass191.smethod_8("co 1 con quai");
									gClass58.gclass6_1 = gClass60;
									gClass58.gclass6_1.int_8 = gClass58.int_4;
									gClass58.gclass6_1.int_9 = gClass58.int_5 - 40;
									break;
								}
							}
							if (GClass167.smethod_14(gClass58.int_13) == null)
								GClass167.gclass122_5.method_0(gClass58);
							gClass58.sbyte_35 = msg.method_1().method_2();
							num178 = msg.method_1().method_6();
							GClass191.smethod_8("mount id= " + num178 + "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
							if (num178 == -1)
								gClass58.bool_25 = false;
							else
							{
								gClass58.bool_25 = true;
								short num179 = num178;
								if (num179 <= 351)
								{
									if ((uint)(num179 - 346) > 2u)
									{
										if ((uint)(num179 - 349) > 2u)
											goto IL_a2a8;
										gClass58.bool_26 = true;
									}
									else
										gClass58.bool_26 = false;
								}
								else if (num179 != 396)
								{
									if (num179 != 532)
										goto IL_a2a8;
									gClass58.bool_28 = true;
								}
								else
								{
									gClass58.bool_27 = true;
								}
							}
						}
						goto IL_a2dd;
					}
					case -3:
					{
						GClass14.smethod_8("SA78", 2);
						sbyte b61 = msg.method_1().method_2();
						int num182 = msg.method_1().method_8();
						if (b61 == 0)
							GClass124.smethod_1().long_2 += num182;
						if (b61 == 1)
							GClass124.smethod_1().long_4 += num182;
						if (b61 == 2)
						{
							GClass124.smethod_1().long_2 += num182;
							GClass124.smethod_1().long_4 += num182;
						}
						GClass124.smethod_1().method_4();
						if (GClass124.smethod_1().sbyte_19 != 3)
						{
							GClass167.smethod_19(((num182 <= 0) ? string.Empty : "+") + GClass138.smethod_9(num182), GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58, 0, -4, GClass104.int_5);
							if (num182 > 0 && GClass124.smethod_1().gclass25_0 != null && GClass124.smethod_1().gclass25_0.short_0 == 5002)
							{
								GClass91.smethod_0(55, GClass124.smethod_1().gclass25_0.int_9, GClass124.smethod_1().gclass25_0.int_4, 1);
								GClass91.smethod_0(55, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, 1);
							}
						}
						break;
					}
					case -2:
					{
						GClass14.smethod_8("SA77", 22);
						int num174 = msg.method_1().method_8();
						GClass124.smethod_1().int_66 += num174;
						GClass167.smethod_19((num174 <= 0) ? (string.Empty + GClass138.smethod_9(num174)) : ("+" + num174), GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58 - 10, 0, -2, GClass104.int_4);
						break;
					}
					case -1:
					{
						GClass14.smethod_8("SA77", 222);
						int num173 = msg.method_1().method_8();
						GClass124.smethod_1().long_6 += num173;
						GClass124.smethod_1().string_0 = GClass77.smethod_6(GClass124.smethod_1().long_6);
						GClass124.smethod_1().int_66 -= num173;
						GClass167.smethod_19("+" + GClass138.smethod_9(num173), GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58 - 10, 0, -2, GClass104.int_4);
						break;
					}
					case -15:
					case -14:
					case -4:
						break;
						IL_a2dd:
						sbyte_2 = msg.method_1().method_2();
						GClass191.smethod_8("addplayer:   " + sbyte_2);
						gClass58.sbyte_28 = sbyte_2;
						gClass58.bool_4 = msg.method_1().method_2() == 1;
						try
						{
							gClass58.short_28 = msg.method_1().method_6();
							gClass58.short_29 = msg.method_1().method_0();
							gClass58.short_30 = msg.method_1().method_6();
							if (gClass58.int_122 >= 201 && gClass58.int_122 < 255)
							{
								GClass85 gClass63 = new GClass85(gClass58.int_122, gClass58, 2, -1, 10, 1);
								gClass63.int_1 = 5;
								gClass58.method_140(gClass63);
							}
							else
							{
								for (int num184 = 0; num184 < 54; num184++)
								{
									gClass58.method_141(0, 201 + num184);
								}
							}
						}
						catch (Exception ex31)
						{
							GClass191.smethod_8("cmd: -5 err: " + ex31.StackTrace);
						}
						GClass167.smethod_8().method_116(gClass58.int_13, gClass58.sbyte_28);
						break;
						IL_a2a8:
						if (num178 >= GClass124.short_14)
							gClass58.short_15 = num178;
						goto IL_a2dd;
					}
				}
			}
			else if (b58 <= 45)
			{
				if (b58 != 44)
				{
					if (b58 == 45)
					{
						GClass14.smethod_8("SA84", 2);
						GClass6 gClass71 = null;
						try
						{
							gClass71 = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5());
						}
						catch (Exception ex38)
						{
							GClass92.smethod_0("Loi tai NPC_MISS  " + ex38.ToString());
						}
						if (gClass71 != null)
						{
							gClass71.int_6 = msg.method_1().method_8();
							gClass71.method_20();
							GClass167.smethod_19(mResources.miss, gClass71.int_8, gClass71.int_9 - gClass71.int_21, 0, -2, GClass104.int_7);
						}
					}
				}
				else
				{
					GClass14.smethod_8("SA91", 2);
					int num193 = msg.method_1().method_8();
					string text9 = msg.method_1().method_14();
					GClass191.smethod_8("user id= " + num193 + " text= " + text9);
					gClass = ((GClass124.smethod_1().int_13 != num193) ? GClass167.smethod_14(num193) : GClass124.smethod_1());
					if (gClass == null)
						return;
					gClass.method_11(text9);
				}
			}
			else if (b58 != 66)
			{
				if (b58 != 74)
				{
					switch (b58)
					{
					case 95:
					{
						GClass14.smethod_8("SA77", 22);
						int num195 = msg.method_1().method_8();
						GClass124.smethod_1().long_6 += num195;
						GClass124.smethod_1().string_0 = GClass77.smethod_6(GClass124.smethod_1().long_6);
						GClass167.smethod_19((num195 <= 0) ? (string.Empty + GClass138.smethod_9(num195)) : ("+" + num195), GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58 - 10, 0, -2, GClass104.int_4);
						break;
					}
					case 96:
						GClass14.smethod_8("SA77a", 22);
						GClass124.smethod_1().gclass122_4.method_0(new GClass133(msg.method_1().method_2(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_14(), msg.method_1().method_14(), msg.method_1().method_2(), msg.method_1().method_2()));
						break;
					case 97:
					{
						sbyte b65 = msg.method_1().method_2();
						for (int num194 = 0; num194 < GClass124.smethod_1().gclass122_4.method_2(); num194++)
						{
							GClass133 gClass72 = (GClass133)GClass124.smethod_1().gclass122_4.method_3(num194);
							if (gClass72.int_0 == b65)
							{
								gClass72.int_1 = msg.method_1().method_6();
								break;
							}
						}
						break;
					}
					}
				}
				else
				{
					GClass14.smethod_8("SA85", 2);
					GClass6 gClass73 = null;
					try
					{
						gClass73 = (GClass6)GClass167.gclass122_9.method_3(msg.method_1().method_5());
					}
					catch (Exception)
					{
						GClass92.smethod_0("Loi tai NPC CHANGE " + msg.sbyte_0);
					}
					if (gClass73 != null && gClass73.int_12 != 0 && gClass73.int_12 != 0)
					{
						gClass73.int_12 = 0;
						GClass91.smethod_0(60, gClass73.int_8, gClass73.int_9, 1);
						GClass190 gClass74 = new GClass190(msg.method_1().method_6(), msg.method_1().method_6(), gClass73.int_8, gClass73.int_9, msg.method_1().method_6(), msg.method_1().method_6());
						GClass167.gclass122_6.method_0(gClass74);
						if (GClass191.smethod_28(gClass74.int_2 - GClass124.smethod_1().int_5) < 24 && GClass191.smethod_28(gClass74.int_1 - GClass124.smethod_1().int_4) < 24)
							GClass124.smethod_1().gclass124_0 = null;
					}
				}
			}
			else
			{
				GClass191.smethod_8("ME DIE XP DOWN NOT IMPLEMENT YET!!!!!!!!!!!!!!!!!!!!!!!!!!");
			}
			GClass14.smethod_8("SA92", 2);
		}
		catch (Exception ex40)
		{
			GClass191.smethod_10("[Controller] [error] " + ex40.StackTrace + " msg: " + ex40.Message + " cause " + ex40.Data);
		}
		finally
		{
			msg?.method_4();
		}
	}

	private void method_1(GClass100 gclass100_1)
	{
		sbyte b = gclass100_1.method_1().method_2();
		GClass161.gclass152_0 = new GClass152[b];
		GClass191.smethod_8("[LEN] sl nguoi choi " + b);
		for (int i = 0; i < b; i++)
		{
			int playerID = gclass100_1.method_1().method_8();
			string name = gclass100_1.method_1().method_14();
			short head = gclass100_1.method_1().method_6();
			short body = gclass100_1.method_1().method_6();
			short leg = gclass100_1.method_1().method_6();
			long ppoint = gclass100_1.method_1().method_9();
			GClass161.gclass152_0[i] = new GClass152(playerID, name, head, body, leg, ppoint);
		}
		GClass14.gclass161_0.switchToMe();
		GClass14.gclass161_0.method_0((byte)b);
	}

	private void method_2(GClass145 gclass145_0)
	{
		GClass167.sbyte_3 = gclass145_0.method_2();
		GClass17.gclass175_0.method_1();
		GClass167.smethod_8().gclass151_0 = new GClass151[gclass145_0.method_5()];
		for (int i = 0; i < GClass167.smethod_8().gclass151_0.Length; i++)
		{
			GClass167.smethod_8().gclass151_0[i] = new GClass151();
			GClass167.smethod_8().gclass151_0[i].int_0 = i;
			GClass167.smethod_8().gclass151_0[i].string_0 = gclass145_0.method_14();
			GClass167.smethod_8().gclass151_0[i].int_1 = gclass145_0.method_2();
		}
		int num = gclass145_0.method_6();
		for (int j = 0; j < num; j++)
		{
			GClass17.smethod_0(new GClass203((short)j, gclass145_0.method_2(), gclass145_0.method_2(), gclass145_0.method_14(), gclass145_0.method_14(), gclass145_0.method_2(), gclass145_0.method_8(), gclass145_0.method_6(), gclass145_0.method_6(), gclass145_0.method_10()));
		}
	}

	private void method_3(GClass145 gclass145_0)
	{
		GClass167.sbyte_2 = gclass145_0.method_2();
		GClass167.smethod_8().gclass199_0 = new GClass199[gclass145_0.method_2()];
		for (int i = 0; i < GClass167.smethod_8().gclass199_0.Length; i++)
		{
			GClass167.smethod_8().gclass199_0[i] = new GClass199();
			GClass167.smethod_8().gclass199_0[i].int_0 = i;
			GClass167.smethod_8().gclass199_0[i].string_0 = gclass145_0.method_14();
		}
		GClass167.gclass94_0 = new GClass94[gclass145_0.method_2()];
		for (int j = 0; j < GClass167.gclass94_0.Length; j++)
		{
			GClass167.gclass94_0[j] = new GClass94();
			GClass167.gclass94_0[j].int_0 = j;
			GClass167.gclass94_0[j].string_0 = gclass145_0.method_14();
			GClass167.gclass94_0[j].gclass205_0 = new GClass205[gclass145_0.method_2()];
			for (int k = 0; k < GClass167.gclass94_0[j].gclass205_0.Length; k++)
			{
				GClass167.gclass94_0[j].gclass205_0[k] = new GClass205();
				GClass167.gclass94_0[j].gclass205_0[k].sbyte_0 = gclass145_0.method_2();
				GClass167.gclass94_0[j].gclass205_0[k].string_0 = gclass145_0.method_14();
				GClass167.gclass94_0[j].gclass205_0[k].int_1 = gclass145_0.method_2();
				GClass167.gclass94_0[j].gclass205_0[k].int_2 = gclass145_0.method_2();
				GClass167.gclass94_0[j].gclass205_0[k].int_3 = gclass145_0.method_2();
				GClass167.gclass94_0[j].gclass205_0[k].int_4 = gclass145_0.method_6();
				GClass167.gclass94_0[j].gclass205_0[k].string_2 = gclass145_0.method_14();
				int lineWidth = 130;
				if (GClass14.int_10 == 128 || GClass14.int_11 <= 208)
					lineWidth = 100;
				GClass167.gclass94_0[j].gclass205_0[k].string_1 = GClass104.gclass104_14.method_15(gclass145_0.method_14(), lineWidth);
				GClass167.gclass94_0[j].gclass205_0[k].gclass95_0 = new GClass95[gclass145_0.method_2()];
				for (int l = 0; l < GClass167.gclass94_0[j].gclass205_0[k].gclass95_0.Length; l++)
				{
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l] = new GClass95();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].short_0 = gclass145_0.method_6();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].gclass205_0 = GClass167.gclass94_0[j].gclass205_0[k];
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].int_0 = gclass145_0.method_2();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].long_0 = gclass145_0.method_9();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].int_5 = gclass145_0.method_6();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].int_1 = gclass145_0.method_8();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].int_2 = gclass145_0.method_6();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].int_3 = gclass145_0.method_6();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].int_4 = gclass145_0.method_2();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].short_1 = gclass145_0.method_6();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].short_2 = gclass145_0.method_6();
					GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l].string_0 = gclass145_0.method_14();
					GClass121.smethod_0(GClass167.gclass94_0[j].gclass205_0[k].gclass95_0[l]);
				}
			}
		}
	}

	private void method_4(GClass145 gclass145_0)
	{
		GClass167.sbyte_1 = gclass145_0.method_2();
		GClass137.string_2 = new string[gclass145_0.method_5()];
		for (int i = 0; i < GClass137.string_2.Length; i++)
		{
			GClass137.string_2[i] = gclass145_0.method_14();
		}
		GClass125.gclass120_1 = new GClass120[gclass145_0.method_2()];
		for (sbyte b = 0; b < GClass125.gclass120_1.Length; b++)
		{
			GClass125.gclass120_1[b] = new GClass120();
			GClass125.gclass120_1[b].int_0 = b;
			GClass125.gclass120_1[b].string_0 = gclass145_0.method_14();
			GClass125.gclass120_1[b].int_1 = gclass145_0.method_6();
			GClass125.gclass120_1[b].int_2 = gclass145_0.method_6();
			GClass125.gclass120_1[b].int_3 = gclass145_0.method_6();
			GClass125.gclass120_1[b].string_1 = new string[gclass145_0.method_2()][];
			for (int j = 0; j < GClass125.gclass120_1[b].string_1.Length; j++)
			{
				GClass125.gclass120_1[b].string_1[j] = new string[gclass145_0.method_2()];
				for (int k = 0; k < GClass125.gclass120_1[b].string_1[j].Length; k++)
				{
					GClass125.gclass120_1[b].string_1[j][k] = gclass145_0.method_14();
				}
			}
		}
		GClass6.gclass76_0 = new GClass76[gclass145_0.method_2()];
		for (sbyte b2 = 0; b2 < GClass6.gclass76_0.Length; b2++)
		{
			GClass6.gclass76_0[b2] = new GClass76();
			GClass6.gclass76_0[b2].sbyte_0 = b2;
			GClass6.gclass76_0[b2].sbyte_3 = gclass145_0.method_2();
			GClass6.gclass76_0[b2].string_0 = gclass145_0.method_14();
			GClass6.gclass76_0[b2].int_0 = gclass145_0.method_8();
			GClass6.gclass76_0[b2].sbyte_1 = gclass145_0.method_2();
			GClass6.gclass76_0[b2].sbyte_2 = gclass145_0.method_2();
			GClass6.gclass76_0[b2].sbyte_4 = gclass145_0.method_2();
		}
	}

	private void method_5(GClass145 gclass145_0, bool bool_6)
	{
		GClass167.sbyte_0 = gclass145_0.method_2();
		if (bool_6)
		{
			GClass141.smethod_0("NR_dart", GClass138.smethod_3(gclass145_0));
			GClass141.smethod_0("NR_arrow", GClass138.smethod_3(gclass145_0));
			GClass141.smethod_0("NR_effect", GClass138.smethod_3(gclass145_0));
			GClass141.smethod_0("NR_image", GClass138.smethod_3(gclass145_0));
			GClass141.smethod_0("NR_part", GClass138.smethod_3(gclass145_0));
			GClass141.smethod_0("NR_skill", GClass138.smethod_3(gclass145_0));
			GClass141.smethod_14("NRdata");
		}
	}

	private GClass20 method_6(sbyte[] sbyte_6)
	{
		try
		{
			return GClass20.smethod_6(sbyte_6, 0, sbyte_6.Length);
		}
		catch (Exception)
		{
		}
		return null;
	}

	public int[] method_7(sbyte[] b)
	{
		int[] array = new int[b.Length];
		for (int i = 0; i < b.Length; i++)
		{
			int num = b[i];
			if (num < 0)
				num += 256;
			array[i] = num;
		}
		return array;
	}

	public void method_8(GClass100 msg, int index)
	{
		try
		{
			GClass22 gClass = new GClass22();
			sbyte b = (sbyte)(gClass.int_1 = msg.method_1().method_2());
			gClass.int_0 = msg.method_1().method_8();
			gClass.int_2 = msg.method_1().method_8();
			gClass.string_0 = msg.method_1().method_14();
			gClass.sbyte_1 = msg.method_1().method_2();
			gClass.long_0 = msg.method_1().method_8() + 1000000000;
			bool upToTop = false;
			GClass167.bool_60 = false;
			if (b != 0)
			{
				if (b != 1)
				{
					if (b == 2 && GClass124.smethod_1().sbyte_17 == 0)
					{
						GClass167.bool_60 = true;
						gClass.string_2 = new string[2]
						{
							mResources.CANCEL,
							mResources.receive
						};
					}
				}
				else
				{
					gClass.int_5 = msg.method_1().method_2();
					gClass.int_6 = msg.method_1().method_2();
					if (upToTop = msg.method_1().method_2() == 1)
						GClass167.bool_60 = true;
					if (gClass.int_2 != GClass124.smethod_1().int_13)
					{
						if (gClass.int_5 >= gClass.int_6)
							gClass.string_2 = null;
						else
							gClass.string_2 = new string[1] { mResources.donate };
					}
					if (GClass14.gclass113_0.gclass88_0 != null)
						GClass14.gclass113_0.method_191(gClass.int_5, gClass.int_6);
				}
			}
			else
			{
				string text = msg.method_1().method_14();
				GClass167.bool_60 = true;
				if (GClass104.gclass104_11.method_17(text) > GClass113.int_55 - 60)
					gClass.string_1 = GClass104.gclass104_11.method_15(text, GClass113.int_55 - 10);
				else
				{
					gClass.string_1 = new string[1];
					gClass.string_1[0] = text;
				}
				gClass.sbyte_0 = msg.method_1().method_2();
			}
			if (GClass14.gclass160_0 != GClass167.gclass167_0)
				GClass167.bool_60 = false;
			else if (GClass14.gclass113_0.bool_0 && GClass14.gclass113_0.int_28 == 0 && GClass14.gclass113_0.int_29 == 3)
			{
				GClass167.bool_60 = false;
			}
			GClass22.smethod_0(gClass, index, upToTop);
		}
		catch (Exception)
		{
			GClass92.smethod_0("LOI TAI CMD -= " + msg.sbyte_0);
		}
	}

	public void method_9(sbyte teleport3)
	{
		GClass191.smethod_8("[CONTROLER] start load map " + teleport3);
		GClass167.smethod_8().int_96 = 0;
		GClass167.bool_70 = false;
		GClass163.gclass163_0 = null;
		GClass167.gclass130_0.bool_1 = false;
		GClass167.gclass130_1.bool_1 = false;
		GClass167.int_38 = 0;
		GClass14.gclass113_0.bool_0 = false;
		GClass147.smethod_1().method_51();
		if (!GClass167.bool_2 && !GClass163.bool_0)
			GClass167.smethod_8().method_0();
		GClass167.smethod_10(false, (teleport3 != 1) ? (-1) : GClass124.smethod_1().int_4, (teleport3 == 0) ? (-1) : 0);
		GClass137.smethod_34();
		GClass137.smethod_13(GClass137.int_25);
		GClass191.smethod_8("LOAD GAMESCR 2");
		GClass124.smethod_1().int_6 = 0;
		GClass124.smethod_1().int_11 = 4;
		GClass124.smethod_1().gclass119_0 = null;
		GClass124.smethod_1().gclass6_0 = null;
		GClass124.smethod_1().gclass124_0 = null;
		GClass124.smethod_1().gclass125_0 = null;
		GClass124.smethod_1().gclass190_0 = null;
		GClass124.smethod_1().gclass135_0 = null;
		GClass124.smethod_1().method_80(false);
		GClass124.smethod_1().gclass135_1 = null;
		GClass14.smethod_49();
		if (GClass124.smethod_1().int_5 >= GClass137.int_24 - 100)
		{
			GClass124.smethod_1().bool_24 = true;
			GClass124.smethod_1().int_4 += GClass191.smethod_28(GClass191.smethod_19(0, 80));
			GClass2.smethod_0().method_44();
		}
		GClass167.smethod_8().method_24();
		GClass14.smethod_21(GClass137.int_40);
		GClass124.bool_34 = false;
		GClass191.smethod_8("cy= " + GClass124.smethod_1().int_5 + "---------------------------------------------");
		for (int i = 0; i < GClass124.smethod_1().gclass122_2.method_2(); i++)
		{
			if (((GClass115)GClass124.smethod_1().gclass122_2.method_3(i)).gclass112_1.sbyte_1 == 10)
			{
				GClass124.bool_34 = true;
				break;
			}
		}
		GClass14.smethod_27();
		GClass14.smethod_26();
		GClass167.smethod_8().int_146 = GClass124.smethod_1().int_25;
		GClass167.smethod_8().int_144 = GClass124.smethod_1().int_24;
		GClass124.bool_33 = false;
		GClass167.smethod_8().switchToMe();
		if (GClass124.smethod_1().int_5 <= 10 && teleport3 != 0 && teleport3 != 2)
		{
			GClass36.smethod_0(new GClass36(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, GClass124.smethod_1().int_119, GClass124.smethod_1().int_12, 1, true, (teleport3 != 1) ? teleport3 : GClass124.smethod_1().int_14));
			GClass124.smethod_1().bool_2 = true;
		}
		if (teleport3 == 2)
			GClass124.smethod_1().method_37();
		if (GClass167.smethod_8().bool_63)
		{
			if (GClass137.int_37 == GClass167.smethod_8().int_104 && GClass137.int_39 == GClass167.smethod_8().int_105)
				GClass167.smethod_8().method_55(GClass167.smethod_8().int_129, GClass167.smethod_8().int_130);
			if (GClass193.int_12 > 1)
				GClass167.smethod_8().method_54();
		}
		GClass96.smethod_5();
		GClass96.smethod_0(GClass137.string_1, mResources.zone + " " + GClass137.int_39, 30);
		GClass14.smethod_29();
		GClass14.bool_4 = false;
		GClass34.smethod_4();
		GClass34.smethod_2();
		GClass14.smethod_8("SA75x9", 2);
		GClass191.smethod_8("[CONTROLLER] loadMap DONE!!!!!!!!!");
	}

	public void method_10(GClass100 msg)
	{
		try
		{
			if (GClass193.int_12 == 1)
				GClass72.smethod_4();
			GClass124.smethod_1().int_4 = (GClass124.smethod_1().int_101 = (GClass124.smethod_1().int_104 = msg.method_1().method_6()));
			GClass124.smethod_1().int_5 = (GClass124.smethod_1().int_102 = (GClass124.smethod_1().int_105 = msg.method_1().method_6()));
			GClass124.smethod_1().int_147 = GClass124.smethod_1().int_4;
			GClass124.smethod_1().int_148 = GClass124.smethod_1().int_5;
			GClass191.smethod_8("head= " + GClass124.smethod_1().int_119 + " body= " + GClass124.smethod_1().int_121 + " left= " + GClass124.smethod_1().int_120 + " x= " + GClass124.smethod_1().int_4 + " y= " + GClass124.smethod_1().int_5 + " chung toc= " + GClass124.smethod_1().int_14);
			if (GClass124.smethod_1().int_4 < 0 || GClass124.smethod_1().int_4 > 100)
			{
				if (GClass124.smethod_1().int_4 >= GClass137.int_21 - 100 && GClass124.smethod_1().int_4 <= GClass137.int_21)
					GClass124.smethod_1().int_12 = -1;
			}
			else
				GClass124.smethod_1().int_12 = 1;
			GClass14.smethod_8("SA75x4", 2);
			int num = msg.method_1().method_2();
			GClass191.smethod_8("vGo size= " + num);
			if (!GClass167.gclass130_0.bool_0)
			{
				GClass167.gclass130_0.int_10 = GClass124.smethod_1().int_4 - GClass167.int_22;
				GClass167.gclass130_0.int_5 = GClass124.smethod_1().int_5 - GClass167.int_23;
			}
			for (int i = 0; i < num; i++)
			{
				GClass15 gClass = new GClass15(msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_14());
				if ((GClass137.int_37 != 21 && GClass137.int_37 != 22 && GClass137.int_37 != 23) || gClass.short_0 < 0 || gClass.short_0 <= 24)
					;
			}
			Resources.UnloadUnusedAssets();
			GC.Collect();
			GClass14.smethod_8("SA75x5", 2);
			num = msg.method_1().method_2();
			GClass6.gclass122_2.method_9();
			for (sbyte b = 0; b < num; b++)
			{
				GClass6 gClass2 = new GClass6(b, msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_2(), msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_2(), msg.method_1().method_2());
				gClass2.int_32 = gClass2.int_8;
				gClass2.int_33 = gClass2.int_9;
				gClass2.bool_12 = msg.method_1().method_11();
				if (GClass6.gclass76_0[gClass2.int_26].sbyte_3 != 0)
				{
					if (b % 3 != 0)
						gClass2.int_10 = 1;
					else
						gClass2.int_10 = -1;
					gClass2.int_8 += 10 - b % 20;
				}
				gClass2.bool_13 = false;
				GClass7 gClass3 = null;
				GClass9 gClass4 = null;
				GClass8 gClass5 = null;
				GClass10 gClass6 = null;
				if (gClass2.int_26 == 70)
					gClass3 = new GClass7(b, (short)gClass2.int_8, (short)gClass2.int_9, 70, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass2.int_26 == 71)
					gClass4 = new GClass9(b, (short)gClass2.int_8, (short)gClass2.int_9, 71, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass2.int_26 == 72)
					gClass5 = new GClass8(b, (short)gClass2.int_8, (short)gClass2.int_9, 72, gClass2.int_6, gClass2.int_7, 3);
				if (gClass2.bool_12)
					gClass6 = new GClass10(b, (short)gClass2.int_8, (short)gClass2.int_9, gClass2.int_26, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass6 == null)
				{
					if (gClass3 == null)
					{
						if (gClass4 != null)
							GClass167.gclass122_9.method_0(gClass4);
						else if (gClass5 != null)
						{
							GClass167.gclass122_9.method_0(gClass5);
						}
						else
						{
							GClass167.gclass122_9.method_0(gClass2);
						}
					}
					else
						GClass167.gclass122_9.method_0(gClass3);
				}
				else
					GClass167.gclass122_9.method_0(gClass6);
			}
			if (GClass124.smethod_1().gclass6_1 != null && GClass167.smethod_16(GClass124.smethod_1().gclass6_1.int_25) == null)
			{
				GClass124.smethod_1().gclass6_1.method_1();
				GClass124.smethod_1().gclass6_1.int_8 = GClass124.smethod_1().int_4;
				GClass124.smethod_1().gclass6_1.int_9 = GClass124.smethod_1().int_5 - 40;
				GClass167.gclass122_9.method_0(GClass124.smethod_1().gclass6_1);
			}
			num = msg.method_1().method_2();
			for (byte b2 = 0; b2 < num; b2++)
			{
			}
			GClass14.smethod_8("SA75x6", 2);
			num = msg.method_1().method_2();
			GClass191.smethod_8("NPC size= " + num);
			for (int j = 0; j < num; j++)
			{
				sbyte status = msg.method_1().method_2();
				short cx = msg.method_1().method_6();
				short num2 = msg.method_1().method_6();
				sbyte b3 = msg.method_1().method_2();
				short num3 = msg.method_1().method_6();
				if (b3 != 6 && ((GClass124.smethod_1().gclass70_0.short_1 >= 7 && (GClass124.smethod_1().gclass70_0.short_1 != 7 || GClass124.smethod_1().gclass70_0.int_0 > 1)) || (b3 != 7 && b3 != 8 && b3 != 9)) && (GClass124.smethod_1().gclass70_0.short_1 >= 6 || b3 != 16))
				{
					if (b3 != 4)
					{
						GClass125 o = new GClass125(j, status, cx, num2 + 3, b3, num3);
						GClass167.gclass122_10.method_0(o);
					}
					else
					{
						GClass167.smethod_8().gclass126_0 = new GClass126(j, status, cx, num2, b3, num3);
						GClass2.smethod_0().method_41(2);
						GClass167.gclass122_10.method_0(GClass167.smethod_8().gclass126_0);
					}
				}
			}
			GClass14.smethod_8("SA75x7", 2);
			num = msg.method_1().method_2();
			string empty = string.Empty;
			GClass191.smethod_8("item size = " + num);
			empty = empty + "item: " + num;
			for (int k = 0; k < num; k++)
			{
				short itemMapID = msg.method_1().method_6();
				short itemTemplateID = msg.method_1().method_6();
				int x = msg.method_1().method_6();
				int y = msg.method_1().method_6();
				int num4 = msg.method_1().method_8();
				short r = 0;
				if (num4 == -2)
					r = msg.method_1().method_6();
				GClass190 gClass7 = new GClass190(num4, itemMapID, itemTemplateID, x, y, r);
				bool flag = false;
				for (int l = 0; l < GClass167.gclass122_6.method_2(); l++)
				{
					if (((GClass190)GClass167.gclass122_6.method_3(l)).int_9 == gClass7.int_9)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
					GClass167.gclass122_6.method_0(gClass7);
				empty = empty + itemTemplateID + ",";
			}
			GClass191.smethod_10("sl item on map " + empty + "\n");
			GClass137.gclass122_2.method_9();
			if (GClass193.int_12 == 1)
				GClass201.smethod_0();
			GClass201.gclass122_0.method_9();
			if (!GClass14.bool_1 || (GClass14.bool_1 && GClass137.smethod_1()) || GClass137.int_37 == 45 || GClass137.int_37 == 46 || GClass137.int_37 == 47 || GClass137.int_37 == 48)
			{
				short num5 = msg.method_1().method_6();
				empty = "item high graphic: ";
				for (int m = 0; m < num5; m++)
				{
					short id = msg.method_1().method_6();
					short num6 = msg.method_1().method_6();
					short num7 = msg.method_1().method_6();
					if (GClass137.smethod_4(id) != null)
					{
						GClass201 gClass8 = GClass137.smethod_4(id);
						GClass201 gClass9 = new GClass201();
						gClass9.int_0 = id;
						gClass9.short_0 = gClass8.short_0;
						gClass9.int_4 = gClass8.int_4;
						gClass9.int_5 = gClass8.int_5;
						gClass9.int_2 = num6 * GClass137.sbyte_0;
						gClass9.int_3 = num7 * GClass137.sbyte_0;
						gClass9.sbyte_0 = gClass8.sbyte_0;
						if (GClass137.smethod_10(gClass9.int_0))
						{
							gClass9.int_1 = ((m % 2 != 0) ? 2 : 0);
							if (GClass137.int_37 == 45)
								gClass9.int_1 = 0;
						}
						GClass20 gClass10 = null;
						if (!GClass201.gclass175_0.method_7(gClass9.short_0 + string.Empty))
						{
							if (GClass193.int_12 != 1)
							{
								bool flag2 = false;
								sbyte[] array = GClass141.smethod_1(GClass193.int_12 + "bgItem" + gClass9.short_0);
								if (array == null)
									flag2 = true;
								else
								{
									if (GClass201.sbyte_1 != null)
									{
										GClass191.smethod_8("Small  last= " + array.Length % 127 + "new Version= " + GClass201.sbyte_1[gClass9.short_0]);
										if (array.Length % 127 != GClass201.sbyte_1[gClass9.short_0])
											flag2 = true;
									}
									if (!flag2)
									{
										gClass10 = GClass20.smethod_6(array, 0, array.Length);
										if (gClass10 == null)
											flag2 = true;
										else
											GClass201.gclass175_0.method_4(gClass9.short_0 + string.Empty, gClass10);
									}
								}
								if (flag2)
								{
									gClass10 = GClass14.smethod_43("/mapBackGround/" + gClass9.short_0 + ".png");
									if (gClass10 == null)
									{
										gClass10 = GClass20.smethod_9(new int[1], 1, 1, true);
										GClass2.smethod_0().method_113(gClass9.short_0);
									}
									GClass201.gclass175_0.method_4(gClass9.short_0 + string.Empty, gClass10);
								}
							}
							else
							{
								gClass10 = GClass14.smethod_43("/mapBackGround/" + gClass9.short_0 + ".png");
								if (gClass10 == null)
								{
									gClass10 = GClass20.smethod_9(new int[1], 1, 1, true);
									GClass2.smethod_0().method_113(gClass9.short_0);
								}
								GClass201.gclass175_0.method_4(gClass9.short_0 + string.Empty, gClass10);
							}
							GClass201.gclass122_1.method_0(gClass9.short_0 + string.Empty);
						}
						if (!GClass201.smethod_1(gClass9.short_0 + string.Empty))
							GClass201.gclass122_0.method_0(gClass9.short_0 + string.Empty);
						gClass9.method_2();
						GClass137.gclass122_2.method_0(gClass9);
					}
					empty = empty + id + ",";
				}
				GClass191.smethod_10("item High Graphics: " + empty);
				for (int n = 0; n < GClass201.gclass122_1.method_2(); n++)
				{
					string text = (string)GClass201.gclass122_1.method_3(n);
					if (!GClass201.smethod_1(text))
					{
						GClass201.gclass175_0.method_5(text);
						if (GClass201.gclass175_0.method_7(text + "blend" + 1))
							GClass201.gclass175_0.method_5(text + "blend" + 1);
						if (GClass201.gclass175_0.method_7(text + "blend" + 3))
							GClass201.gclass175_0.method_5(text + "blend" + 3);
						GClass201.gclass122_1.method_7(n);
						n--;
					}
				}
				GClass181.bool_3 = false;
				GClass181.int_40 = 0;
				GClass98.gclass122_0.method_9();
				GClass181.gclass122_0.method_9();
				GClass85.gclass122_2.method_9();
				short num8 = msg.method_1().method_6();
				for (int num9 = 0; num9 < num8; num9++)
				{
					method_11(msg.method_1().method_14(), msg.method_1().method_14());
				}
			}
			else
			{
				short num10 = msg.method_1().method_6();
				for (int num11 = 0; num11 < num10; num11++)
				{
					msg.method_1().method_6();
					msg.method_1().method_6();
					msg.method_1().method_6();
				}
				short num12 = msg.method_1().method_6();
				for (int num13 = 0; num13 < num12; num13++)
				{
					msg.method_1().method_14();
					msg.method_1().method_14();
				}
			}
			GClass137.int_41 = msg.method_1().method_2();
			method_9(msg.method_1().method_2());
			GClass124.bool_35 = false;
			GClass14.smethod_8("SA75x8", 2);
			Resources.UnloadUnusedAssets();
			GC.Collect();
			GClass191.smethod_8("[ LOAD INFO MAP ]    [DONE]   in game");
		}
		catch (Exception ex)
		{
			GClass57.smethod_0().method_7();
			GClass191.smethod_10("[error] [TAI LOADMAP INFO]" + ex.StackTrace + ex.Message);
		}
	}

	public void method_11(string key, string value)
	{
		if (key.Equals("eff"))
		{
			if (GClass113.int_36 > 0)
				return;
			string[] array = GClass191.smethod_30(value, ".", 0);
			int id = int.Parse(array[0]);
			int layer = int.Parse(array[1]);
			int x = int.Parse(array[2]);
			int y = int.Parse(array[3]);
			int loop;
			int loopCount;
			if (array.Length <= 4)
			{
				loop = -1;
				loopCount = 1;
			}
			else
			{
				loop = int.Parse(array[4]);
				loopCount = int.Parse(array[5]);
			}
			GClass85 gClass = new GClass85(id, x, y, layer, loop, loopCount);
			if (array.Length > 6)
			{
				gClass.int_1 = int.Parse(array[6]);
				if (array.Length > 7)
				{
					gClass.int_2 = int.Parse(array[7]);
					gClass.int_3 = int.Parse(array[8]);
				}
			}
			GClass98.smethod_0(gClass);
		}
		else if (key.Equals("beff") && GClass113.int_36 <= 1)
		{
			GClass181.smethod_7(int.Parse(value));
		}
	}

	public void method_12(GClass100 msg)
	{
		GClass14.smethod_8("SA6", 2);
		try
		{
			sbyte b = msg.method_1().method_2();
			GClass191.smethod_8("---messageNotMap : " + b);
			sbyte b2 = b;
			switch (b2)
			{
			case 4:
			{
				GClass14.smethod_8("SA8", 2);
				GClass14.gclass173_0.method_10();
				GClass167.bool_68 = false;
				GClass167.bool_69 = false;
				GClass173.bool_4 = true;
				GClass173.bool_5 = true;
				GClass173.bool_6 = true;
				GClass173.bool_7 = true;
				GClass173.bool_8 = true;
				GClass167.sbyte_4 = msg.method_1().method_2();
				GClass167.sbyte_5 = msg.method_1().method_2();
				GClass167.sbyte_6 = msg.method_1().method_2();
				GClass167.sbyte_7 = msg.method_1().method_2();
				msg.method_1().method_2();
				if (!GClass14.gclass173_0.bool_12)
					GClass141.smethod_4("userAo" + GClass170.int_14, string.Empty);
				else
				{
					GClass141.smethod_4("acc", string.Empty);
					GClass141.smethod_4("pass", string.Empty);
				}
				if (GClass167.sbyte_4 == GClass167.sbyte_0)
					try
					{
						GClass173.bool_5 = false;
					}
					catch (Exception)
					{
						GClass167.sbyte_0 = -1;
						GClass2.smethod_0().method_79();
					}
				else
				{
					GClass167.bool_2 = false;
					GClass2.smethod_0().method_79();
				}
				if (GClass167.sbyte_5 == GClass167.sbyte_1)
					try
					{
						if (!GClass167.bool_2)
							method_4(new GClass188(GClass141.smethod_1("NRmap")).gclass145_0);
						GClass173.bool_6 = false;
					}
					catch (Exception)
					{
						GClass167.sbyte_1 = -1;
						GClass2.smethod_0().method_80();
					}
				else
				{
					GClass167.bool_2 = false;
					GClass2.smethod_0().method_80();
				}
				if (GClass167.sbyte_6 != GClass167.sbyte_2)
				{
					GClass167.bool_2 = false;
					GClass2.smethod_0().method_81();
				}
				else
					try
					{
						if (!GClass167.bool_2)
							method_3(new GClass188(GClass141.smethod_1("NRskill")).gclass145_0);
						GClass173.bool_7 = false;
					}
					catch (Exception)
					{
						GClass167.sbyte_2 = -1;
						GClass2.smethod_0().method_81();
					}
				if (GClass167.sbyte_7 == GClass167.sbyte_3)
					try
					{
						method_19(new GClass188(GClass141.smethod_1("NRitem0")).gclass145_0, 0, false);
						method_19(new GClass188(GClass141.smethod_1("NRitem1")).gclass145_0, 1, false);
						method_19(new GClass188(GClass141.smethod_1("NRitem2")).gclass145_0, 2, false);
						method_19(new GClass188(GClass141.smethod_1("NRitem100")).gclass145_0, 100, false);
						GClass173.bool_8 = false;
					}
					catch (Exception)
					{
						GClass167.sbyte_3 = -1;
						GClass2.smethod_0().method_82();
					}
				else
				{
					GClass167.bool_2 = false;
					GClass2.smethod_0().method_82();
				}
				if (GClass167.sbyte_4 == GClass167.sbyte_0 && GClass167.sbyte_5 == GClass167.sbyte_1 && GClass167.sbyte_6 == GClass167.sbyte_2 && GClass167.sbyte_7 == GClass167.sbyte_3)
				{
					if (!GClass167.bool_2)
					{
						GClass167.smethod_8().method_22();
						GClass167.smethod_8().method_20();
						GClass167.smethod_8().method_21();
						GClass167.smethod_8().method_23();
					}
					GClass2.smethod_0().method_83();
				}
				sbyte b3 = msg.method_1().method_2();
				GClass191.smethod_8("CAPTION LENT= " + b3);
				GClass167.long_2 = new long[b3];
				for (int j = 0; j < GClass167.long_2.Length; j++)
				{
					GClass167.long_2[j] = msg.method_1().method_9();
				}
				return;
			}
			case 6:
			{
				GClass191.smethod_8("GET UPDATE_MAP " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_4(msg.method_1());
				msg.method_1().method_4();
				sbyte[] data2 = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data2);
				GClass141.smethod_0("NRmap", data2);
				GClass141.smethod_0("NRmapVersion", new sbyte[1] { GClass167.sbyte_1 });
				GClass173.bool_6 = false;
				if (GClass167.sbyte_4 == GClass167.sbyte_0 && GClass167.sbyte_5 == GClass167.sbyte_1 && GClass167.sbyte_6 == GClass167.sbyte_2 && GClass167.sbyte_7 == GClass167.sbyte_3)
				{
					GClass167.smethod_8().method_22();
					GClass167.smethod_8().method_20();
					GClass167.smethod_8().method_21();
					GClass167.smethod_8().method_23();
					GClass2.smethod_0().method_83();
				}
				return;
			}
			case 7:
			{
				GClass191.smethod_8("GET UPDATE_SKILL " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_3(msg.method_1());
				msg.method_1().method_4();
				sbyte[] data = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data);
				GClass141.smethod_0("NRskill", data);
				GClass141.smethod_0("NRskillVersion", new sbyte[1] { GClass167.sbyte_2 });
				GClass173.bool_7 = false;
				if (GClass167.sbyte_4 == GClass167.sbyte_0 && GClass167.sbyte_5 == GClass167.sbyte_1 && GClass167.sbyte_6 == GClass167.sbyte_2 && GClass167.sbyte_7 == GClass167.sbyte_3)
				{
					GClass167.smethod_8().method_22();
					GClass167.smethod_8().method_20();
					GClass167.smethod_8().method_21();
					GClass167.smethod_8().method_23();
					GClass2.smethod_0().method_83();
				}
				return;
			}
			case 8:
				GClass191.smethod_8("GET UPDATE_ITEM " + msg.method_1().method_18() + " bytes");
				method_18(msg.method_1());
				return;
			case 9:
				GClass14.smethod_8("SA11", 2);
				return;
			case 10:
				try
				{
					GClass124.bool_35 = true;
					GClass191.smethod_8("REQUEST MAP TEMPLATE");
					GClass14.bool_4 = true;
					GClass137.int_27 = null;
					GClass137.int_28 = null;
					GClass77.smethod_26();
					GClass14.smethod_8("SA99", 2);
					GClass137.int_21 = msg.method_1().method_2();
					GClass137.int_22 = msg.method_1().method_2();
					GClass137.int_27 = new int[GClass137.int_21 * GClass137.int_22];
					GClass191.smethod_10("   M apsize= " + GClass137.int_21 * GClass137.int_22);
					for (int i = 0; i < GClass137.int_27.Length; i++)
					{
						int num2 = msg.method_1().method_2();
						if (num2 < 0)
							num2 += 256;
						GClass137.int_27[i] = (ushort)num2;
					}
					GClass137.int_28 = new int[GClass137.int_27.Length];
					msg = gclass100_0;
					method_10(msg);
					try
					{
						GClass137.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
					}
					catch (Exception ex)
					{
						GClass191.smethod_10(" 1 LOI TAI CASE REQUEST_MAPTEMPLATE " + ex.ToString());
					}
				}
				catch (Exception ex2)
				{
					GClass191.smethod_10("2 LOI TAI CASE REQUEST_MAPTEMPLATE " + ex2.ToString());
				}
				msg.method_4();
				gclass100_0.method_4();
				msg = (gclass100_0 = null);
				GClass167.smethod_8().switchToMe();
				return;
			case 12:
				GClass14.smethod_8("SA10", 2);
				return;
			case 16:
				GClass169.smethod_2().switchToMe();
				return;
			case 17:
				GClass14.smethod_8("SYB123", 2);
				GClass124.smethod_1().method_120();
				return;
			case 18:
			{
				GClass14.bool_4 = false;
				GClass14.smethod_29();
				int num = msg.method_1().method_8();
				GClass14.gclass184_0.method_0(mResources.changeNameChar, new GClass118(mResources.OK, GClass14.gclass14_0, 88829, num), GClass136.int_11);
				return;
			}
			case 20:
				GClass124.smethod_1().sbyte_18 = msg.method_1().method_2();
				GClass167.gclass130_0.method_7(mResources.PK_NOW + " " + GClass124.smethod_1().sbyte_18, 0);
				return;
			case 5:
			case 11:
			case 13:
			case 14:
			case 15:
			case 19:
				return;
			}
			if (b2 != 35)
			{
				if (b2 == 36)
				{
					GClass167.sbyte_10 = msg.method_1().method_2();
					GClass191.smethod_8("load Me Active: " + GClass167.sbyte_10);
				}
			}
			else
			{
				GClass14.smethod_29();
				GClass167.smethod_8().method_34();
				GClass167.gclass130_0.method_7(msg.method_1().method_14(), 0);
			}
		}
		catch (Exception)
		{
			GClass92.smethod_2("LOI TAI messageNotMap + " + msg.sbyte_0);
		}
		finally
		{
			msg?.method_4();
		}
	}

	public void method_13(GClass100 msg)
	{
		try
		{
			sbyte b = msg.method_1().method_2();
			GClass191.smethod_8("---messageNotLogin : " + b);
			if (b != 2)
				return;
			string string_ = msg.method_1().method_14();
			if (GClass141.smethod_8("AdminLink") != 1)
			{
				if (GClass77.int_0 == 1)
					GClass170.string_9 = string_;
				else
					GClass170.string_9 = string_;
				GClass77.smethod_0();
				GClass170.smethod_4(GClass170.string_9);
				try
				{
					GClass113.bool_6 = msg.method_1().method_2() == 1;
					GClass141.smethod_9("AdminLink", msg.method_1().method_2());
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			msg?.method_4();
		}
	}

	public void method_14(GClass100 msg)
	{
		try
		{
			GClass14.smethod_8("SA12", 2);
			sbyte b = msg.method_1().method_2();
			GClass191.smethod_8("---messageSubCommand : " + b);
			sbyte b2 = b;
			switch (b2)
			{
			case 0:
			{
				GClass14.smethod_8("SA21", 2);
				GClass166.gclass122_0 = new GClass122();
				GClass36.gclass122_0.method_9();
				GClass167.gclass122_5.method_9();
				GClass167.gclass122_6.method_9();
				GClass124.gclass122_5.method_9();
				GClass167.smethod_26();
				GClass167.gclass124_0 = GClass124.smethod_1();
				GClass124.smethod_1().int_13 = msg.method_1().method_8();
				GClass124.smethod_1().int_15 = msg.method_1().method_2();
				GClass124.smethod_1().int_14 = msg.method_1().method_2();
				GClass124.smethod_1().int_119 = msg.method_1().method_6();
				GClass124.smethod_1().string_3 = msg.method_1().method_14();
				GClass124.smethod_1().sbyte_18 = msg.method_1().method_2();
				GClass124.smethod_1().sbyte_19 = msg.method_1().method_2();
				GClass124.smethod_1().long_2 = msg.method_1().method_9();
				GClass124.smethod_1().method_4();
				GClass124.smethod_1().int_33 = msg.method_1().method_6();
				GClass124.smethod_1().int_34 = msg.method_1().method_6();
				GClass124.smethod_1().gclass94_0 = GClass167.gclass94_0[msg.method_1().method_2()];
				GClass124.smethod_1().gclass122_0.method_9();
				GClass124.smethod_1().gclass122_1.method_9();
				GClass167.smethod_8().int_146 = GClass124.smethod_1().int_25;
				GClass167.smethod_8().int_144 = GClass124.smethod_1().int_24;
				sbyte b4 = msg.method_1().method_2();
				for (sbyte b5 = 0; b5 < b4; b5++)
				{
					method_15(GClass121.smethod_1(msg.method_1().method_6()));
				}
				GClass167.smethod_8().method_65();
				GClass167.smethod_8().method_4();
				GClass124.smethod_1().long_6 = msg.method_1().method_9();
				GClass124.smethod_1().int_69 = msg.method_1().method_8();
				GClass124.smethod_1().int_68 = msg.method_1().method_8();
				GClass124.smethod_1().string_0 = GClass77.smethod_6(GClass124.smethod_1().long_6);
				GClass124.smethod_1().string_1 = GClass77.smethod_6(GClass124.smethod_1().int_68);
				GClass124.smethod_1().string_2 = GClass77.smethod_6(GClass124.smethod_1().int_69);
				GClass124.smethod_1().gclass0_2 = new GClass0[msg.method_1().method_2()];
				try
				{
					GClass124.smethod_1().method_61();
					for (int j = 0; j < GClass124.smethod_1().gclass0_2.Length; j++)
					{
						short num3 = msg.method_1().method_6();
						if (num3 == -1)
							continue;
						GClass203 gClass7 = GClass17.smethod_1(num3);
						int num4 = gClass7.sbyte_0;
						GClass124.smethod_1().gclass0_2[j] = new GClass0();
						GClass124.smethod_1().gclass0_2[j].gclass203_0 = gClass7;
						GClass124.smethod_1().gclass0_2[j].int_30 = msg.method_1().method_8();
						GClass124.smethod_1().gclass0_2[j].string_0 = msg.method_1().method_14();
						GClass124.smethod_1().gclass0_2[j].string_1 = msg.method_1().method_14();
						int num5 = msg.method_1().method_5();
						if (num5 != 0)
						{
							GClass124.smethod_1().gclass0_2[j].gclass5_0 = new GClass5[num5];
							for (int k = 0; k < GClass124.smethod_1().gclass0_2[j].gclass5_0.Length; k++)
							{
								int optionTemplateId = msg.method_1().method_5();
								int param = msg.method_1().method_7();
								GClass124.smethod_1().gclass0_2[j].gclass5_0[k] = new GClass5(optionTemplateId, param);
							}
						}
						int num6 = num4;
						if (num6 != 0)
						{
							if (num6 == 1)
							{
								GClass124.smethod_1().int_120 = GClass124.smethod_1().gclass0_2[j].gclass203_0.short_2;
								GClass191.smethod_8("toi day =======================================" + GClass124.smethod_1().int_120);
							}
						}
						else
						{
							GClass191.smethod_8("toi day =======================================" + GClass124.smethod_1().int_121);
							GClass124.smethod_1().int_121 = GClass124.smethod_1().gclass0_2[j].gclass203_0.short_2;
						}
					}
				}
				catch (Exception)
				{
				}
				GClass124.smethod_1().gclass0_0 = new GClass0[msg.method_1().method_2()];
				GClass167.int_37 = 0;
				for (int l = 0; l < GClass124.smethod_1().gclass0_0.Length; l++)
				{
					short num7 = msg.method_1().method_6();
					if (num7 == -1)
						continue;
					GClass124.smethod_1().gclass0_0[l] = new GClass0();
					GClass124.smethod_1().gclass0_0[l].gclass203_0 = GClass17.smethod_1(num7);
					GClass124.smethod_1().gclass0_0[l].int_30 = msg.method_1().method_8();
					GClass124.smethod_1().gclass0_0[l].string_0 = msg.method_1().method_14();
					GClass124.smethod_1().gclass0_0[l].string_1 = msg.method_1().method_14();
					GClass124.smethod_1().gclass0_0[l].int_29 = l;
					sbyte b6 = msg.method_1().method_2();
					if (b6 != 0)
					{
						GClass124.smethod_1().gclass0_0[l].gclass5_0 = new GClass5[b6];
						for (int m = 0; m < GClass124.smethod_1().gclass0_0[l].gclass5_0.Length; m++)
						{
							int optionTemplateId2 = msg.method_1().method_5();
							int param2 = msg.method_1().method_7();
							GClass124.smethod_1().gclass0_0[l].gclass5_0[m] = new GClass5(optionTemplateId2, param2);
							GClass124.smethod_1().gclass0_0[l].method_6();
						}
					}
					if (GClass124.smethod_1().gclass0_0[l].gclass203_0.sbyte_0 == 6)
						GClass167.int_37 += GClass124.smethod_1().gclass0_0[l].int_30;
				}
				GClass124.smethod_1().gclass0_1 = new GClass0[msg.method_1().method_2()];
				GClass14.gclass113_0.int_39 = 0;
				for (int n = 0; n < GClass124.smethod_1().gclass0_1.Length; n++)
				{
					short num8 = msg.method_1().method_6();
					if (num8 != -1)
					{
						GClass124.smethod_1().gclass0_1[n] = new GClass0();
						GClass124.smethod_1().gclass0_1[n].gclass203_0 = GClass17.smethod_1(num8);
						GClass124.smethod_1().gclass0_1[n].int_30 = msg.method_1().method_8();
						GClass124.smethod_1().gclass0_1[n].string_0 = msg.method_1().method_14();
						GClass124.smethod_1().gclass0_1[n].string_1 = msg.method_1().method_14();
						GClass124.smethod_1().gclass0_1[n].gclass5_0 = new GClass5[msg.method_1().method_2()];
						for (int num9 = 0; num9 < GClass124.smethod_1().gclass0_1[n].gclass5_0.Length; num9++)
						{
							int optionTemplateId3 = msg.method_1().method_5();
							int param3 = msg.method_1().method_7();
							GClass124.smethod_1().gclass0_1[n].gclass5_0[num9] = new GClass5(optionTemplateId3, param3);
							GClass124.smethod_1().gclass0_1[n].method_6();
						}
						GClass14.gclass113_0.int_39++;
					}
				}
				GClass124.smethod_1().int_11 = 4;
				if (GClass141.smethod_8(GClass124.smethod_1().string_3 + "vci") >= 1)
					GClass167.bool_8 = true;
				else
					GClass167.bool_8 = false;
				short num10 = msg.method_1().method_6();
				GClass124.short_12 = new short[num10];
				GClass124.short_13 = new short[num10];
				for (int num11 = 0; num11 < num10; num11++)
				{
					GClass124.short_12[num11] = msg.method_1().method_6();
					GClass124.short_13[num11] = msg.method_1().method_6();
				}
				for (int num12 = 0; num12 < GClass167.gclass130_0.int_0.Length; num12++)
				{
					GClass167.gclass130_0.int_0[num12] = new int[3];
				}
				GClass167.gclass130_0.int_0[GClass124.smethod_1().int_14][0] = msg.method_1().method_6();
				GClass167.gclass130_0.int_0[GClass124.smethod_1().int_14][1] = msg.method_1().method_6();
				GClass167.gclass130_0.int_0[GClass124.smethod_1().int_14][2] = msg.method_1().method_6();
				GClass124.smethod_1().bool_4 = msg.method_1().method_2() == 1;
				GClass191.smethod_8("NHAP THE= " + GClass124.smethod_1().bool_4);
				GClass167.long_3 = GClass77.smethod_18() - msg.method_1().method_8() * 1000L;
				GClass167.sbyte_13 = msg.method_1().method_2();
				GClass2.smethod_0().method_29((sbyte)GClass124.smethod_1().int_14);
				GClass2.smethod_0().method_1();
				try
				{
					GClass124.smethod_1().short_28 = msg.method_1().method_6();
					GClass124.smethod_1().short_29 = msg.method_1().method_0();
					GClass124.smethod_1().short_30 = msg.method_1().method_6();
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			case 1:
				GClass14.smethod_8("SA13", 2);
				GClass124.smethod_1().gclass94_0 = GClass167.gclass94_0[msg.method_1().method_2()];
				GClass124.smethod_1().long_4 = msg.method_1().method_9();
				GClass124.smethod_1().gclass122_0.method_9();
				GClass124.smethod_1().gclass122_1.method_9();
				GClass124.smethod_1().gclass95_0 = null;
				return;
			case 2:
			{
				GClass14.smethod_8("SA14", 2);
				if (GClass124.smethod_1().int_11 != 14 && GClass124.smethod_1().int_11 != 5)
				{
					GClass124.smethod_1().int_25 = GClass124.smethod_1().int_35;
					GClass124.smethod_1().int_24 = GClass124.smethod_1().int_36;
					GClass92.smethod_3(" ME_LOAD_SKILL");
				}
				GClass124.smethod_1().gclass122_0.method_9();
				GClass124.smethod_1().gclass122_1.method_9();
				sbyte b7 = msg.method_1().method_2();
				for (sbyte b8 = 0; b8 < b7; b8++)
				{
					method_15(GClass121.smethod_1(msg.method_1().method_6()));
				}
				GClass167.smethod_8().method_65();
				if (GClass167.bool_19)
				{
					GClass167.int_45 = -1;
					GClass167.smethod_8().gclass118_0 = (GClass167.smethod_8().gclass118_1 = null);
				}
				return;
			}
			case 4:
				GClass14.smethod_8("SA23", 2);
				GClass124.smethod_1().long_6 = msg.method_1().method_9();
				GClass124.smethod_1().int_68 = msg.method_1().method_8();
				GClass124.smethod_1().int_25 = msg.method_3();
				GClass124.smethod_1().int_24 = msg.method_3();
				GClass124.smethod_1().int_69 = msg.method_1().method_8();
				GClass124.smethod_1().string_0 = GClass77.smethod_6(GClass124.smethod_1().long_6);
				GClass124.smethod_1().string_1 = GClass77.smethod_6(GClass124.smethod_1().int_68);
				GClass124.smethod_1().string_2 = GClass77.smethod_6(GClass124.smethod_1().int_69);
				return;
			case 5:
			{
				GClass14.smethod_8("SA24", 2);
				int int_ = GClass124.smethod_1().int_25;
				GClass124.smethod_1().int_25 = msg.method_3();
				if (GClass124.smethod_1().int_25 > int_ && GClass124.smethod_1().sbyte_19 != 4)
				{
					GClass167.smethod_19("+" + (GClass124.smethod_1().int_25 - int_) + " " + mResources.HP, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58 - 20, 0, -1, GClass104.int_12);
					GClass147.smethod_1().method_3();
					if (GClass124.smethod_1().gclass25_0 != null && GClass124.smethod_1().gclass25_0.short_0 == 5003)
						GClass89.smethod_0(GClass124.smethod_1().gclass25_0.int_9 + ((GClass124.smethod_1().gclass25_0.int_0 != 1) ? (-10) : 10), GClass124.smethod_1().gclass25_0.int_4 + 10, true, -1, -1, GClass124.smethod_1(), 29);
				}
				if (GClass124.smethod_1().int_25 < int_)
					GClass167.smethod_19("-" + (int_ - GClass124.smethod_1().int_25) + " " + mResources.HP, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58 - 20, 0, -1, GClass104.int_12);
				GClass167.smethod_8().int_146 = GClass124.smethod_1().int_25;
				if (!GClass167.bool_19)
					;
				return;
			}
			case 6:
			{
				GClass14.smethod_8("SA25", 2);
				if (GClass124.smethod_1().int_11 == 14 || GClass124.smethod_1().int_11 == 5)
					return;
				int int_2 = GClass124.smethod_1().int_24;
				GClass124.smethod_1().int_24 = msg.method_3();
				if (GClass124.smethod_1().int_24 > int_2)
				{
					GClass167.smethod_19("+" + (GClass124.smethod_1().int_24 - int_2) + " " + mResources.KI, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58 - 23, 0, -2, GClass104.int_13);
					GClass147.smethod_1().method_3();
					if (GClass124.smethod_1().gclass25_0 != null && GClass124.smethod_1().gclass25_0.short_0 == 5001)
						GClass89.smethod_0(GClass124.smethod_1().gclass25_0.int_9 + ((GClass124.smethod_1().gclass25_0.int_0 != 1) ? (-10) : 10), GClass124.smethod_1().gclass25_0.int_4 + 10, true, -1, -1, GClass124.smethod_1(), 29);
				}
				if (GClass124.smethod_1().int_24 < int_2)
					GClass167.smethod_19("-" + (int_2 - GClass124.smethod_1().int_24) + " " + mResources.KI, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58 - 23, 0, -2, GClass104.int_13);
				GClass191.smethod_8("curr MP= " + GClass124.smethod_1().int_24);
				GClass167.smethod_8().int_144 = GClass124.smethod_1().int_24;
				if (GClass167.bool_19)
					;
				return;
			}
			case 7:
			{
				GClass124 gClass13 = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass13 == null)
					return;
				gClass13.int_56 = msg.method_1().method_8();
				if (gClass13.int_56 == -2)
					gClass13.bool_59 = true;
				method_16(gClass13, msg);
				try
				{
					gClass13.short_28 = msg.method_1().method_6();
					gClass13.short_29 = msg.method_1().method_0();
					gClass13.short_30 = msg.method_1().method_6();
					if (gClass13.int_122 < 201)
					{
						gClass13.method_141(0, 201);
						return;
					}
					GClass85 gClass14 = new GClass85(gClass13.int_122, gClass13, 2, -1, 10, 1);
					gClass14.int_1 = 5;
					gClass13.method_140(gClass14);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			case 8:
			{
				GClass14.smethod_8("SA26", 2);
				GClass124 gClass8 = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass8 != null)
					gClass8.int_18 = msg.method_1().method_2();
				return;
			}
			case 9:
			{
				GClass14.smethod_8("SA27", 2);
				GClass124 gClass10 = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass10 != null)
				{
					gClass10.int_25 = msg.method_3();
					gClass10.int_35 = msg.method_3();
				}
				return;
			}
			case 10:
			{
				GClass14.smethod_8("SA28", 2);
				GClass124 gClass5 = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass5 != null)
				{
					gClass5.int_25 = msg.method_3();
					gClass5.int_35 = msg.method_3();
					gClass5.int_33 = msg.method_1().method_6();
					gClass5.int_34 = msg.method_1().method_6();
					gClass5.int_123 = msg.method_1().method_6();
					if (gClass5.int_123 == -1)
						gClass5.method_62();
				}
				return;
			}
			case 11:
			{
				GClass14.smethod_8("SA29", 2);
				GClass124 gClass9 = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass9 != null)
				{
					gClass9.int_25 = msg.method_3();
					gClass9.int_35 = msg.method_3();
					gClass9.int_33 = msg.method_1().method_6();
					gClass9.int_34 = msg.method_1().method_6();
					gClass9.int_121 = msg.method_1().method_6();
					if (gClass9.int_121 == -1)
						gClass9.method_63();
				}
				return;
			}
			case 12:
			{
				GClass14.smethod_8("SA30", 2);
				GClass124 gClass12 = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass12 != null)
				{
					gClass12.int_25 = msg.method_3();
					gClass12.int_35 = msg.method_3();
					gClass12.int_33 = msg.method_1().method_6();
					gClass12.int_34 = msg.method_1().method_6();
					gClass12.int_120 = msg.method_1().method_6();
					if (gClass12.int_120 == -1)
						gClass12.method_64();
				}
				return;
			}
			case 13:
			{
				GClass14.smethod_8("SA31", 2);
				int num2 = msg.method_1().method_8();
				GClass124 gClass6 = ((num2 != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num2) : GClass124.smethod_1());
				if (gClass6 != null)
				{
					gClass6.int_25 = msg.method_3();
					gClass6.int_35 = msg.method_3();
					gClass6.int_33 = msg.method_1().method_6();
					gClass6.int_34 = msg.method_1().method_6();
				}
				return;
			}
			case 14:
			{
				GClass14.smethod_8("SA32", 2);
				GClass124 gClass4 = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass4 != null)
				{
					gClass4.int_25 = msg.method_3();
					sbyte b3 = msg.method_1().method_2();
					GClass191.smethod_8("player load hp type= " + b3);
					if (b3 == 1)
					{
						GClass91.smethod_3(11, gClass4, 5);
						GClass91.smethod_3(104, gClass4, 4);
					}
					if (b3 == 2)
						gClass4.method_113();
					try
					{
						gClass4.int_35 = msg.method_3();
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
				return;
			}
			case 15:
			{
				GClass14.smethod_8("SA33", 2);
				GClass124 gClass3 = GClass167.smethod_14(msg.method_1().method_8());
				if (gClass3 != null)
				{
					gClass3.int_25 = msg.method_3();
					gClass3.int_35 = msg.method_3();
					gClass3.int_4 = msg.method_1().method_6();
					gClass3.int_5 = msg.method_1().method_6();
					gClass3.int_11 = 1;
					gClass3.int_10 = 3;
					GClass91.smethod_3(109, gClass3, 2);
				}
				return;
			}
			case 19:
				GClass14.smethod_8("SA17", 2);
				GClass124.smethod_1().method_14();
				return;
			case 21:
			{
				GClass14.smethod_8("SA19", 2);
				int num14 = msg.method_1().method_8();
				GClass124.smethod_1().int_65 -= num14;
				GClass124.smethod_1().long_6 += num14;
				GClass124.smethod_1().string_0 = GClass77.smethod_6(GClass124.smethod_1().long_6);
				return;
			}
			case 23:
			{
				short num13 = msg.method_1().method_6();
				GClass95 gClass11 = GClass121.smethod_1(num13);
				method_15(gClass11);
				if (num13 != 0 && num13 != 14 && num13 != 28)
					GClass167.gclass130_0.method_7(mResources.LEARN_SKILL + " " + gClass11.gclass205_0.string_0, 0);
				return;
			}
			case 35:
			{
				GClass14.smethod_8("SY3", 2);
				int num = msg.method_1().method_8();
				GClass191.smethod_8("CID = " + num);
				if (GClass137.int_37 == 130)
					GClass167.smethod_8().method_91();
				if (num == GClass124.smethod_1().int_13)
				{
					GClass124.smethod_1().sbyte_19 = msg.method_1().method_2();
					if (GClass167.smethod_8().method_95() && GClass124.smethod_1().sbyte_19 != 0)
						GClass167.smethod_8().method_91();
					GClass191.smethod_8("type pk= " + GClass124.smethod_1().sbyte_19);
					GClass124.smethod_1().gclass125_0 = null;
					if (!GClass167.smethod_8().method_31(GClass124.smethod_1().gclass6_0))
						GClass124.smethod_1().gclass6_0 = null;
					GClass124.smethod_1().gclass190_0 = null;
				}
				else
				{
					GClass124 gClass = GClass167.smethod_14(num);
					if (gClass != null)
					{
						GClass191.smethod_8("type pk= " + gClass.sbyte_19);
						gClass.sbyte_19 = msg.method_1().method_2();
						if (gClass.method_105())
							GClass124.smethod_1().gclass124_0 = gClass;
					}
				}
				for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
				{
					GClass124 gClass2 = GClass167.smethod_14(i);
					if (gClass2 != null && gClass2.sbyte_19 != 0 && gClass2.sbyte_19 == GClass124.smethod_1().sbyte_19)
					{
						if (!GClass124.smethod_1().gclass6_0.bool_13)
							GClass124.smethod_1().gclass6_0 = null;
						GClass124.smethod_1().gclass125_0 = null;
						GClass124.smethod_1().gclass190_0 = null;
						break;
					}
				}
				GClass191.smethod_8("update type pk= ");
				return;
			}
			case 3:
			case 16:
			case 17:
			case 18:
			case 20:
			case 22:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
				return;
			}
			switch (b2)
			{
			case 61:
			{
				string text = msg.method_1().method_14();
				sbyte[] data = new sbyte[msg.method_1().method_8()];
				msg.method_1().method_16(ref data);
				if (data.Length == 0)
					data = null;
				if (text.Equals("KSkill"))
					GClass167.smethod_8().method_6(data);
				else if (!text.Equals("OSkill"))
				{
					if (text.Equals("CSkill"))
						GClass167.smethod_8().method_7(data);
				}
				else
				{
					GClass167.smethod_8().method_5(data);
				}
				break;
			}
			case 62:
				GClass191.smethod_8("ME UPDATE SKILL");
				method_25(msg);
				break;
			case 63:
			{
				sbyte b9 = msg.method_1().method_2();
				if (b9 > 0)
				{
					GClass14.gclass113_0.gclass122_11.method_9();
					GClass96.smethod_1();
					GClass122 gclass122_ = GClass14.gclass113_0.gclass122_4;
					for (int num15 = 0; num15 < b9; num15++)
					{
						string caption = msg.method_1().method_14();
						string string_ = msg.method_1().method_14();
						short int_3 = msg.method_1().method_6();
						GClass14.gclass113_0.gclass122_11.method_0(int_3 + string.Empty);
						GClass124.smethod_1().gclass124_0.int_16 = int_3;
						GClass118 gClass15 = new GClass118(caption, 11115, GClass124.smethod_1().gclass124_0);
						gClass15.string_2 = string_;
						gclass122_.method_0(gClass15);
					}
					GClass96.smethod_5();
					GClass14.gclass113_0.method_21();
				}
				break;
			}
			}
		}
		catch (Exception ex5)
		{
			GClass92.smethod_0("Loi tai Sub : " + ex5.ToString());
		}
		finally
		{
			msg?.method_4();
		}
	}

	private void method_15(GClass95 gclass95_0)
	{
		if (GClass124.smethod_1().gclass95_0 == null)
			GClass124.smethod_1().gclass95_0 = gclass95_0;
		else if (gclass95_0.gclass205_0.Equals(GClass124.smethod_1().gclass95_0.gclass205_0))
		{
			GClass124.smethod_1().gclass95_0 = gclass95_0;
		}
		GClass124.smethod_1().gclass122_0.method_0(gclass95_0);
		if ((gclass95_0.gclass205_0.int_3 == 1 || gclass95_0.gclass205_0.int_3 == 4 || gclass95_0.gclass205_0.int_3 == 2 || gclass95_0.gclass205_0.int_3 == 3) && (gclass95_0.gclass205_0.int_1 == 0 || (gclass95_0.gclass205_0.int_1 > 0 && gclass95_0.int_0 > 0)))
		{
			if (gclass95_0.gclass205_0.sbyte_0 == GClass124.smethod_1().int_71)
				GClass2.smethod_0().method_56(GClass124.smethod_1().int_71);
			GClass124.smethod_1().gclass122_1.method_0(gclass95_0);
		}
	}

	public bool method_16(GClass124 c, GClass100 msg)
	{
		try
		{
			c.int_23 = msg.method_1().method_2();
			c.bool_20 = msg.method_1().method_11();
			c.sbyte_19 = msg.method_1().method_2();
			GClass191.smethod_8("ADD TYPE PK= " + c.sbyte_19 + " to player " + c.int_13 + " @@ " + c.string_3);
			c.gclass94_0 = GClass167.gclass94_0[msg.method_1().method_2()];
			c.int_14 = msg.method_1().method_2();
			c.int_119 = msg.method_1().method_6();
			c.string_3 = msg.method_1().method_14();
			c.int_25 = msg.method_3();
			c.int_163 = c.int_25;
			if (c.int_25 == 0)
				c.int_11 = 14;
			c.int_35 = msg.method_3();
			if (c.int_5 >= GClass137.int_24 - 100)
				c.bool_24 = true;
			c.int_121 = msg.method_1().method_6();
			c.int_120 = msg.method_1().method_6();
			c.int_122 = msg.method_1().method_5();
			GClass191.smethod_8(" body= " + c.int_121 + " leg= " + c.int_120 + " bag=" + c.int_122 + "BAG ==" + c.int_122 + "*********************************");
			c.bool_21 = true;
			msg.method_1().method_2();
			if (c.int_123 == -1)
				c.method_62();
			if (c.int_121 == -1)
				c.method_63();
			if (c.int_120 == -1)
				c.method_64();
			c.int_4 = msg.method_1().method_6();
			c.int_5 = msg.method_1().method_6();
			c.int_147 = c.int_4;
			c.int_148 = c.int_5;
			c.int_33 = msg.method_1().method_6();
			c.int_34 = msg.method_1().method_6();
			int num = msg.method_1().method_2();
			for (int i = 0; i < num; i++)
			{
				GClass115 gClass = new GClass115(msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_8(), msg.method_1().method_6());
				c.gclass122_2.method_0(gClass);
				if (gClass.gclass112_1.sbyte_1 == 12 || gClass.gclass112_1.sbyte_1 == 11)
					c.bool_20 = true;
			}
			return true;
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		return false;
	}

	private void method_17(GClass100 gclass100_1)
	{
		try
		{
			string text = gclass100_1.method_1().method_14();
			sbyte nFrame = gclass100_1.method_1().method_2();
			sbyte[] array = null;
			array = GClass138.smethod_2(gclass100_1);
			GClass108.smethod_0(text, method_6(array), nFrame);
			if (array != null)
				GClass108.smethod_3(text, nFrame, array);
		}
		catch (Exception)
		{
		}
	}

	private void method_18(GClass145 gclass145_0)
	{
		try
		{
			method_19(gclass145_0, -1, true);
		}
		catch (Exception)
		{
		}
	}

	private void method_19(GClass145 gclass145_0, sbyte sbyte_6, bool bool_6)
	{
		try
		{
			gclass145_0.method_3(100000);
			GClass167.sbyte_3 = gclass145_0.method_2();
			sbyte_6 = gclass145_0.method_2();
			if (sbyte_6 != 0)
			{
				if (sbyte_6 != 1)
				{
					if (sbyte_6 != 2)
					{
						if (sbyte_6 == 100)
						{
							GClass124.int_173 = method_21(gclass145_0);
							if (bool_6)
							{
								gclass145_0.method_4();
								sbyte[] data = new sbyte[gclass145_0.method_18()];
								gclass145_0.method_17(ref data);
								GClass141.smethod_0("NRitem100", data);
							}
						}
						return;
					}
					int num = gclass145_0.method_6();
					int num2 = gclass145_0.method_6();
					for (int i = num; i < num2; i++)
					{
						GClass17.smethod_0(new GClass203((short)i, gclass145_0.method_2(), gclass145_0.method_2(), gclass145_0.method_14(), gclass145_0.method_14(), gclass145_0.method_2(), gclass145_0.method_8(), gclass145_0.method_6(), gclass145_0.method_6(), gclass145_0.method_11()));
					}
					if (bool_6)
					{
						gclass145_0.method_4();
						sbyte[] data2 = new sbyte[gclass145_0.method_18()];
						gclass145_0.method_17(ref data2);
						GClass141.smethod_0("NRitem2", data2);
						GClass141.smethod_0("NRitemVersion", new sbyte[1] { GClass167.sbyte_3 });
						GClass173.bool_8 = false;
						if (GClass167.sbyte_4 == GClass167.sbyte_0 && GClass167.sbyte_5 == GClass167.sbyte_1 && GClass167.sbyte_6 == GClass167.sbyte_2 && GClass167.sbyte_7 == GClass167.sbyte_3)
						{
							GClass167.smethod_8().method_22();
							GClass167.smethod_8().method_20();
							GClass167.smethod_8().method_21();
							GClass167.smethod_8().method_23();
							GClass2.smethod_0().method_83();
						}
					}
				}
				else
				{
					GClass17.gclass175_0.method_1();
					int num3 = gclass145_0.method_6();
					for (int j = 0; j < num3; j++)
					{
						GClass17.smethod_0(new GClass203((short)j, gclass145_0.method_2(), gclass145_0.method_2(), gclass145_0.method_14(), gclass145_0.method_14(), gclass145_0.method_2(), gclass145_0.method_8(), gclass145_0.method_6(), gclass145_0.method_6(), gclass145_0.method_11()));
					}
					if (bool_6)
					{
						gclass145_0.method_4();
						sbyte[] data3 = new sbyte[gclass145_0.method_18()];
						gclass145_0.method_17(ref data3);
						GClass141.smethod_0("NRitem1", data3);
					}
				}
			}
			else
			{
				GClass167.smethod_8().gclass151_0 = new GClass151[gclass145_0.method_5()];
				for (int k = 0; k < GClass167.smethod_8().gclass151_0.Length; k++)
				{
					GClass167.smethod_8().gclass151_0[k] = new GClass151();
					GClass167.smethod_8().gclass151_0[k].int_0 = k;
					GClass167.smethod_8().gclass151_0[k].string_0 = gclass145_0.method_14();
					GClass167.smethod_8().gclass151_0[k].int_1 = gclass145_0.method_2();
				}
				if (bool_6)
				{
					gclass145_0.method_4();
					sbyte[] data4 = new sbyte[gclass145_0.method_18()];
					gclass145_0.method_17(ref data4);
					GClass141.smethod_0("NRitem0", data4);
				}
			}
		}
		catch (Exception ex)
		{
			ex.ToString();
		}
	}

	private void method_20(GClass100 gclass100_1, int int_2)
	{
		try
		{
			int num = gclass100_1.method_1().method_2();
			int[][] array = new int[num][];
			for (int i = 0; i < num; i++)
			{
				int num2 = gclass100_1.method_1().method_2();
				array[i] = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					array[i][j] = gclass100_1.method_1().method_2();
				}
			}
			gclass175_0.method_4(int_2 + string.Empty, array);
		}
		catch (Exception)
		{
		}
	}

	private int[][] method_21(GClass145 gclass145_0)
	{
		int[][] array = new int[1][] { new int[2] { 542, 543 } };
		try
		{
			array = new int[gclass145_0.method_6()][];
			for (int i = 0; i < array.Length; i++)
			{
				int num = gclass145_0.method_2();
				array[i] = new int[num];
				for (int j = 0; j < num; j++)
				{
					array[i][j] = gclass145_0.method_6();
				}
			}
			return array;
		}
		catch (Exception)
		{
			return array;
		}
	}

	public void method_22(GClass100 msg)
	{
		try
		{
			sbyte b = msg.method_1().method_2();
			if (b == 0)
				method_23(msg, b);
		}
		catch (Exception)
		{
		}
	}

	private void method_23(GClass100 gclass100_1, int int_2)
	{
		try
		{
			sbyte b = gclass100_1.method_1().method_2();
			if (b == 0)
			{
				short idmapPaint = gclass100_1.method_1().method_6();
				string nameTeam = gclass100_1.method_1().method_14();
				string nameTeam2 = gclass100_1.method_1().method_14();
				int maxPoint = gclass100_1.method_1().method_8();
				short timeSecond = gclass100_1.method_1().method_6();
				int int_3 = gclass100_1.method_1().method_2();
				GClass167.gclass4_0 = new GClass4(int_2, idmapPaint, nameTeam, nameTeam2, maxPoint, timeSecond);
				GClass167.gclass4_0.int_6 = int_3;
				GClass167.gclass4_0.method_2(int_2, 0, 0);
			}
			else if (b == 1)
			{
				int pointTeam = gclass100_1.method_1().method_8();
				int pointTeam2 = gclass100_1.method_1().method_8();
				if (GClass167.gclass4_0 != null)
					GClass167.gclass4_0.method_1(int_2, pointTeam, pointTeam2);
			}
			else if (b == 2)
			{
				sbyte b2 = gclass100_1.method_1().method_2();
				short type = 0;
				if (b2 == 1)
					type = 1;
				else if (b2 == 2)
				{
					type = 2;
				}
				GClass167.gclass4_0 = null;
				GClass167.smethod_35(type, -1, 0, GClass14.int_12, GClass14.int_13, 0, 0, -1, null);
			}
			else if (b == 5)
			{
				short timeSecond2 = gclass100_1.method_1().method_6();
				if (GClass167.gclass4_0 != null)
					GClass167.gclass4_0.method_0(int_2, timeSecond2);
			}
			else if (b == 4)
			{
				int lifeTeam = gclass100_1.method_1().method_2();
				int lifeTeam2 = gclass100_1.method_1().method_2();
				if (GClass167.gclass4_0 != null)
					GClass167.gclass4_0.method_2(int_2, lifeTeam, lifeTeam2);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_24(GClass100 msg)
	{
		try
		{
			sbyte b = msg.method_1().method_2();
			if (b != 0)
			{
				if (b == 2)
				{
					int num = msg.method_1().method_8();
					sbyte b2 = msg.method_1().method_2();
					short num2 = msg.method_1().method_6();
					string v = num2 + "," + b2;
					GClass108.smethod_1("banner_" + num2, GClass108.gclass175_0);
					GClass14.gclass175_0.method_4(num + string.Empty, v);
				}
				else if (b != 3)
				{
					if (b == 4)
					{
						string o = msg.method_1().method_14();
						GClass14.gclass122_2.method_0(o);
					}
				}
				else
				{
					short num3 = msg.method_1().method_6();
					GClass72.smethod_5(num3);
					GClass181.short_0 = num3;
				}
			}
			else
			{
				short short_ = msg.method_1().method_6();
				GClass124.smethod_1().short_30 = short_;
				GClass147.smethod_1().method_2();
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_25(GClass100 msg)
	{
		try
		{
			short num = msg.method_1().method_6();
			sbyte b = -1;
			try
			{
				b = msg.method_1().method_0();
			}
			catch (Exception)
			{
			}
			if (b == 0)
			{
				short short_ = msg.method_1().method_6();
				int num2 = 0;
				GClass95 gClass;
				while (true)
				{
					if (num2 < GClass124.smethod_1().gclass122_0.method_2())
					{
						gClass = (GClass95)GClass124.smethod_1().gclass122_0.method_3(num2);
						if (gClass.short_0 == num)
							break;
						num2++;
						continue;
					}
					return;
				}
				gClass.short_3 = short_;
			}
			else if (b == 1)
			{
				sbyte b2 = msg.method_1().method_2();
				for (int i = 0; i < GClass124.smethod_1().gclass122_0.method_2(); i++)
				{
					GClass95 gClass2 = (GClass95)GClass124.smethod_1().gclass122_0.method_3(i);
					if (gClass2.short_0 == num)
					{
						for (int j = 0; j < 20; j++)
						{
							GClass108.smethod_1("Skills_" + gClass2.gclass205_0.sbyte_0 + "_" + b2 + "_" + j, GClass108.gclass175_0);
						}
						break;
					}
				}
			}
			else
			{
				if (b != -1)
					return;
				GClass95 gClass3 = GClass121.smethod_1(num);
				for (int k = 0; k < GClass124.smethod_1().gclass122_0.method_2(); k++)
				{
					if (((GClass95)GClass124.smethod_1().gclass122_0.method_3(k)).gclass205_0.sbyte_0 == gClass3.gclass205_0.sbyte_0)
					{
						GClass124.smethod_1().gclass122_0.method_5(gClass3, k);
						break;
					}
				}
				for (int l = 0; l < GClass124.smethod_1().gclass122_1.method_2(); l++)
				{
					if (((GClass95)GClass124.smethod_1().gclass122_1.method_3(l)).gclass205_0.sbyte_0 == gClass3.gclass205_0.sbyte_0)
					{
						GClass124.smethod_1().gclass122_1.method_5(gClass3, l);
						break;
					}
				}
				for (int m = 0; m < GClass167.gclass95_1.Length; m++)
				{
					if (GClass167.gclass95_1[m] != null && GClass167.gclass95_1[m].gclass205_0.sbyte_0 == gClass3.gclass205_0.sbyte_0)
					{
						GClass167.gclass95_1[m] = gClass3;
						break;
					}
				}
				for (int n = 0; n < GClass167.gclass95_0.Length; n++)
				{
					if (GClass167.gclass95_0[n] != null && GClass167.gclass95_0[n].gclass205_0.sbyte_0 == gClass3.gclass205_0.sbyte_0)
					{
						GClass167.gclass95_0[n] = gClass3;
						break;
					}
				}
				if (GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == gClass3.gclass205_0.sbyte_0)
					GClass124.smethod_1().gclass95_0 = gClass3;
				GClass167.gclass130_0.method_7(mResources.hasJustUpgrade1 + gClass3.gclass205_0.string_0 + mResources.hasJustUpgrade2 + gClass3.int_0, 0);
			}
		}
		catch (Exception)
		{
		}
	}
}
