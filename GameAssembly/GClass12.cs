using System;
using AssemblyCSharp.Functions;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using UnityEngine;

public class GClass12 : GInterface3
{
	protected static GClass12 gclass12_0;

	protected static GClass12 gclass12_1;

	public GClass208 gclass208_0;

	public static bool bool_0 = false;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	private float float_0;

	private int int_0;

	private int int_1;

	public static bool bool_5;

	public static GClass113 gclass113_0 = new GClass113();

	public const sbyte sbyte_0 = 0;

	public const sbyte sbyte_1 = 0;

	public const sbyte sbyte_2 = 1;

	public const sbyte sbyte_3 = 2;

	public const sbyte sbyte_4 = 4;

	public const sbyte sbyte_5 = 5;

	public static GClass12 smethod_0()
	{
		if (gclass12_0 == null)
			gclass12_0 = new GClass12();
		return gclass12_0;
	}

	public static GClass12 smethod_1()
	{
		if (gclass12_1 == null)
			gclass12_1 = new GClass12();
		return gclass12_1;
	}

	public void onConnectOK(bool isMain1)
	{
		bool_4 = isMain1;
		GClass203.smethod_28();
	}

	public void onConnectionFail(bool isMain1)
	{
		bool_4 = isMain1;
		GClass203.smethod_29();
	}

	public void onDisconnected(bool isMain1)
	{
		bool_4 = isMain1;
		GClass203.smethod_30();
	}

	public void method_0(GClass208 msg)
	{
		try
		{
			int num = msg.method_1().method_5();
			GClass128 gClass = GClass144.gclass78_0.gclass128_2[num];
			gClass.int_38 = msg.method_1().method_8();
			gClass.int_32 = msg.method_1().method_2();
			gClass.gclass88_0 = new GClass88();
			try
			{
				while (true)
				{
					gClass.gclass88_0.method_0(new GClass120(msg.method_1().method_5(), msg.method_1().method_7()));
				}
			}
			catch (Exception ex)
			{
				GClass36.smethod_0("Loi tairequestItemPlayer 1" + ex.ToString());
			}
		}
		catch (Exception ex2)
		{
			GClass36.smethod_0("Loi tairequestItemPlayer 2" + ex2.ToString());
		}
	}

	public void onMessage(GClass208 msg)
	{
		GClass73.gclass88_5.method_9();
		GClass73.smethod_8("SA1", 2);
		try
		{
			if (msg.sbyte_0 != -74)
				GClass50.smethod_8("=========> [READ] cmd= " + msg.sbyte_0);
			GClass78 gClass = null;
			GClass194 gClass2 = null;
			GClass88 gClass3 = new GClass88();
			int num = 0;
			GClass73.int_100 = 15;
			Controller2.smethod_0(msg);
			sbyte b = msg.sbyte_0;
			switch (b)
			{
			default:
			{
				if (b != 112)
					break;
				sbyte b51 = msg.method_1().method_2();
				GClass50.smethod_8("spec type= " + b51);
				if (b51 != 0)
				{
					if (b51 != 1)
						break;
					sbyte b52 = msg.method_1().method_2();
					GClass78.smethod_1().string_4 = new string[b52][];
					GClass78.smethod_1().short_1 = new short[b52][];
					GClass73.gclass76_0.string_28 = new string[b52][];
					for (int num157 = 0; num157 < b52; num157++)
					{
						GClass73.gclass76_0.string_28[num157] = new string[2];
						string[] array17 = GClass50.smethod_30(msg.method_1().method_14(), "\n", 0);
						if (array17.Length == 2)
							GClass73.gclass76_0.string_28[num157] = array17;
						if (array17.Length == 1)
						{
							GClass73.gclass76_0.string_28[num157][0] = array17[0];
							GClass73.gclass76_0.string_28[num157][1] = "";
						}
						int num158 = msg.method_1().method_2();
						GClass78.smethod_1().string_4[num157] = new string[num158];
						GClass78.smethod_1().short_1[num157] = new short[num158];
						for (int num159 = 0; num159 < num158; num159++)
						{
							GClass78.smethod_1().short_1[num157][num159] = msg.method_1().method_6();
							GClass78.smethod_1().string_4[num157][num159] = msg.method_1().method_14();
						}
					}
					GClass73.gclass76_0.string_17[25] = GClass73.gclass76_0.string_28;
					GClass73.gclass76_0.method_210();
					GClass73.gclass76_0.method_50();
				}
				else
				{
					GClass76.short_0 = msg.method_1().method_6();
					GClass76.string_1 = msg.method_1().method_14();
				}
				break;
			}
			case -112:
			{
				sbyte b25 = msg.method_1().method_2();
				if (b25 == 0)
					GClass144.smethod_15(msg.method_1().method_2()).clearBody();
				if (b25 == 1)
					GClass144.smethod_15(msg.method_1().method_2()).setBody(msg.method_1().method_6());
				break;
			}
			case -107:
			{
				sbyte b38 = msg.method_1().method_2();
				if (b38 == 0)
					GClass78.smethod_1().bool_38 = false;
				if (b38 == 1)
					GClass78.smethod_1().bool_38 = true;
				if (b38 != 2)
					break;
				GClass130.smethod_5();
				GClass78.smethod_2().int_119 = msg.method_1().method_6();
				GClass78.smethod_2().method_61();
				int num108 = msg.method_1().method_5();
				GClass50.smethod_8("num body = " + num108);
				GClass78.smethod_2().gclass128_2 = new GClass128[num108];
				for (int num109 = 0; num109 < num108; num109++)
				{
					short num110 = msg.method_1().method_6();
					GClass50.smethod_8("template id= " + num110);
					if (num110 == -1)
						continue;
					GClass50.smethod_8("1");
					GClass78.smethod_2().gclass128_2[num109] = new GClass128();
					GClass78.smethod_2().gclass128_2[num109].gclass117_0 = GClass0.smethod_1(num110);
					int num111 = GClass78.smethod_2().gclass128_2[num109].gclass117_0.sbyte_0;
					GClass78.smethod_2().gclass128_2[num109].int_30 = msg.method_1().method_8();
					GClass50.smethod_8("3");
					GClass78.smethod_2().gclass128_2[num109].string_0 = msg.method_1().method_14();
					GClass78.smethod_2().gclass128_2[num109].string_1 = msg.method_1().method_14();
					int num112 = msg.method_1().method_5();
					GClass50.smethod_8("option size= " + num112);
					if (num112 != 0)
					{
						GClass78.smethod_2().gclass128_2[num109].gclass120_0 = new GClass120[num112];
						for (int num113 = 0; num113 < GClass78.smethod_2().gclass128_2[num109].gclass120_0.Length; num113++)
						{
							int optionTemplateId5 = msg.method_1().method_5();
							int param5 = msg.method_1().method_7();
							GClass78.smethod_2().gclass128_2[num109].gclass120_0[num113] = new GClass120(optionTemplateId5, param5);
						}
					}
					int num114 = num111;
					if (num114 == 0)
						GClass78.smethod_2().int_121 = GClass78.smethod_2().gclass128_2[num109].gclass117_0.short_2;
					else if (num114 == 1)
					{
						GClass78.smethod_2().int_120 = GClass78.smethod_2().gclass128_2[num109].gclass117_0.short_2;
					}
				}
				GClass78.smethod_2().int_25 = msg.method_3();
				GClass78.smethod_2().int_35 = msg.method_3();
				GClass78.smethod_2().int_24 = msg.method_3();
				GClass78.smethod_2().int_36 = msg.method_3();
				GClass78.smethod_2().int_20 = msg.method_3();
				GClass78.smethod_2().string_3 = msg.method_1().method_14();
				GClass78.smethod_2().string_6 = msg.method_1().method_14();
				GClass78.smethod_2().long_2 = msg.method_1().method_9();
				GClass78.smethod_2().long_4 = msg.method_1().method_9();
				GClass78.smethod_2().sbyte_15 = msg.method_1().method_2();
				GClass78.smethod_2().int_77 = msg.method_1().method_6();
				GClass78.smethod_2().short_24 = msg.method_1().method_6();
				GClass78.smethod_2().int_22 = msg.method_1().method_2();
				GClass78.smethod_2().int_21 = msg.method_1().method_6();
				GClass78.smethod_2().gclass63_1 = new GClass63[msg.method_1().method_2()];
				GClass50.smethod_8("SKILLENT = " + GClass78.smethod_2().gclass63_1);
				for (int num115 = 0; num115 < GClass78.smethod_2().gclass63_1.Length; num115++)
				{
					short num116 = msg.method_1().method_6();
					if (num116 != -1)
					{
						GClass78.smethod_2().gclass63_1[num115] = GClass99.smethod_1(num116);
						continue;
					}
					GClass78.smethod_2().gclass63_1[num115] = new GClass63();
					GClass78.smethod_2().gclass63_1[num115].gclass47_0 = null;
					GClass78.smethod_2().gclass63_1[num115].string_0 = msg.method_1().method_14();
				}
				break;
			}
			case -99:
				GClass130.smethod_5();
				if (msg.method_1().method_2() == 0)
				{
					GClass73.gclass76_0.gclass88_9.method_9();
					int num163 = msg.method_1().method_5();
					for (int num164 = 0; num164 < num163; num164++)
					{
						GClass78 gClass49 = new GClass78();
						gClass49.int_13 = msg.method_1().method_8();
						gClass49.int_119 = msg.method_1().method_6();
						gClass49.int_118 = msg.method_1().method_6();
						gClass49.int_121 = msg.method_1().method_6();
						gClass49.int_120 = msg.method_1().method_6();
						gClass49.int_122 = msg.method_1().method_6();
						gClass49.string_3 = msg.method_1().method_14();
						GClass16 gClass50 = new GClass16(msg.method_1().method_14());
						bool flag12 = msg.method_1().method_11();
						gClass50.gclass78_0 = gClass49;
						gClass50.bool_1 = flag12;
						GClass50.smethod_8("isonline = " + flag12);
						GClass73.gclass76_0.gclass88_9.method_0(gClass50);
					}
					GClass73.gclass76_0.method_26();
					GClass73.gclass76_0.method_50();
				}
				break;
			case -98:
			{
				sbyte b29 = msg.method_1().method_2();
				GClass73.gclass145_0.bool_0 = false;
				if (b29 == 0)
					GClass73.smethod_36(msg.method_1().method_14(), new GClass87(mResources.YES, GClass73.gclass73_0, 888397, msg.method_1().method_14()), new GClass87(mResources.NO, GClass73.gclass73_0, 888396, null));
				break;
			}
			case -97:
				GClass78.smethod_1().long_5 = msg.method_1().method_8();
				break;
			case -96:
			{
				sbyte t = msg.method_1().method_2();
				GClass73.gclass76_0.gclass88_8.method_9();
				string string_ = msg.method_1().method_14();
				sbyte b16 = msg.method_1().method_2();
				for (int num29 = 0; num29 < b16; num29++)
				{
					int int_4 = msg.method_1().method_8();
					int int_5 = msg.method_1().method_8();
					short num30 = msg.method_1().method_6();
					short num31 = msg.method_1().method_6();
					short short_ = msg.method_1().method_6();
					short short_2 = msg.method_1().method_6();
					string string_2 = msg.method_1().method_14();
					string string_3 = msg.method_1().method_14();
					GClass114 gClass16 = new GClass114();
					gClass16.int_3 = int_4;
					gClass16.int_0 = num30;
					gClass16.int_1 = num31;
					gClass16.short_0 = short_;
					gClass16.short_1 = short_2;
					gClass16.string_0 = string_2;
					gClass16.string_1 = string_3;
					gClass16.string_2 = msg.method_1().method_14();
					gClass16.int_2 = int_5;
					GClass73.gclass76_0.gclass88_8.method_0(gClass16);
				}
				GClass73.gclass76_0.string_0 = string_;
				GClass73.gclass76_0.method_27(t);
				GClass73.gclass76_0.method_50();
				break;
			}
			case -95:
			{
				sbyte b26 = msg.method_1().method_2();
				GClass50.smethod_8("type= " + b26);
				if (b26 == 0)
				{
					int num63 = msg.method_1().method_8();
					short templateId = msg.method_1().method_6();
					int num64 = msg.method_3();
					GClass109.smethod_1().method_22();
					if (num63 == GClass78.smethod_1().int_13)
					{
						GClass78.smethod_1().gclass194_1 = new GClass194(num63, false, false, false, false, false, templateId, 1, num64, 0, num64, (short)(GClass78.smethod_1().int_4 + ((GClass78.smethod_1().int_12 != 1) ? (-40) : 40)), (short)GClass78.smethod_1().int_5, 4, 0);
						GClass78.smethod_1().gclass194_1.bool_13 = true;
						GClass57.smethod_0(new GClass81(18, GClass78.smethod_1().gclass194_1.int_8, GClass78.smethod_1().gclass194_1.int_9, 2, 10, -1));
						GClass78.smethod_1().int_72 = 30;
						GClass144.gclass88_9.method_0(GClass78.smethod_1().gclass194_1);
					}
					else
					{
						gClass = GClass144.smethod_14(num63);
						if (gClass == null)
						{
							if (GClass144.smethod_16(num63) == null)
							{
								GClass194 gClass22 = new GClass194(num63, false, false, false, false, false, templateId, 1, num64, 0, num64, -100, -100, 4, 0);
								gClass22.bool_13 = true;
								GClass144.gclass88_9.method_0(gClass22);
							}
						}
						else
						{
							GClass194 gClass23 = new GClass194(num63, false, false, false, false, false, templateId, 1, num64, 0, num64, (short)gClass.int_4, (short)gClass.int_5, 4, 0);
							gClass23.bool_13 = true;
							gClass.gclass194_1 = gClass23;
							GClass144.gclass88_9.method_0(gClass.gclass194_1);
						}
					}
				}
				if (b26 == 1)
				{
					int num65 = msg.method_1().method_8();
					int mobId = msg.method_1().method_2();
					GClass50.smethod_8("mod attack id= " + num65);
					if (num65 != GClass78.smethod_1().int_13)
					{
						gClass = GClass144.smethod_14(num65);
						if (gClass != null && GClass144.smethod_16(mobId) != null)
							gClass.gclass194_1.method_23(GClass144.smethod_16(mobId));
					}
					else if (GClass144.smethod_16(mobId) != null)
					{
						GClass78.smethod_1().gclass194_1.method_23(GClass144.smethod_16(mobId));
					}
				}
				if (b26 == 2)
				{
					int num66 = msg.method_1().method_8();
					int num67 = msg.method_1().method_8();
					int num68 = msg.method_3();
					int int_10 = msg.method_3();
					if (num66 == GClass78.smethod_1().int_13)
					{
						GClass50.smethod_8("mob dame= " + num68);
						gClass = GClass144.smethod_14(num67);
						if (gClass != null)
						{
							gClass.int_26 = int_10;
							if (!GClass78.smethod_1().gclass194_1.bool_18)
							{
								GClass78.smethod_1().gclass194_1.int_27 = num68;
								GClass78.smethod_1().gclass194_1.method_8(gClass);
							}
							else
								gClass.method_112(num68, 0, false, true);
						}
					}
					else
					{
						gClass2 = GClass144.smethod_16(num66);
						if (gClass2 != null)
						{
							if (num67 == GClass78.smethod_1().int_13)
							{
								GClass78.smethod_1().int_26 = int_10;
								if (gClass2.bool_18)
									GClass78.smethod_1().method_112(num68, 0, false, true);
								else
								{
									gClass2.int_27 = num68;
									gClass2.method_8(GClass78.smethod_1());
								}
							}
							else
							{
								gClass = GClass144.smethod_14(num67);
								if (gClass != null)
								{
									gClass.int_26 = int_10;
									if (gClass2.bool_18)
										gClass.method_112(num68, 0, false, true);
									else
									{
										gClass2.int_27 = num68;
										gClass2.method_8(gClass);
									}
								}
							}
						}
					}
				}
				if (b26 == 3)
				{
					int num69 = msg.method_1().method_8();
					int mobId2 = msg.method_1().method_8();
					int int_11 = msg.method_3();
					int num70 = msg.method_3();
					gClass = null;
					gClass = ((GClass78.smethod_1().int_13 != num69) ? GClass144.smethod_14(num69) : GClass78.smethod_1());
					if (gClass != null)
					{
						gClass2 = GClass144.smethod_16(mobId2);
						if (gClass.gclass194_1 != null)
							gClass.gclass194_1.method_23(gClass2);
						if (gClass2 != null)
						{
							gClass2.int_6 = int_11;
							gClass2.method_20();
							if (num70 == 0)
							{
								gClass2.int_8 = gClass2.int_16;
								gClass2.int_9 = gClass2.int_17;
								GClass144.smethod_19(mResources.miss, gClass2.int_8, gClass2.int_9 - gClass2.int_21, 0, -2, GClass4.int_7);
							}
							else
								GClass144.smethod_19("-" + GClass65.smethod_9(num70), gClass2.int_8, gClass2.int_9 - gClass2.int_21, 0, -2, GClass4.int_8);
						}
					}
				}
				if (b26 != 4)
					;
				if (b26 == 5)
				{
					int num71 = msg.method_1().method_8();
					sbyte b27 = msg.method_1().method_2();
					int mobId3 = msg.method_1().method_8();
					int num72 = msg.method_3();
					int int_12 = msg.method_3();
					gClass = null;
					gClass = ((num71 != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num71) : GClass78.smethod_1());
					if (gClass == null)
						return;
					if ((GClass20.smethod_27(gClass.int_4, gClass.int_5) & 2) != 2)
						gClass.method_69(GClass144.gclass39_0[b27], 1);
					else
						gClass.method_69(GClass144.gclass39_0[b27], 0);
					GClass194 gClass24 = GClass144.smethod_16(mobId3);
					if (gClass.int_4 <= gClass24.int_8)
						gClass.int_12 = 1;
					else
						gClass.int_12 = -1;
					gClass.gclass194_0 = gClass24;
					gClass24.int_6 = int_12;
					gClass24.method_20();
					GClass73.smethod_8("SA83v2", 2);
					if (num72 == 0)
					{
						gClass24.int_8 = gClass24.int_16;
						gClass24.int_9 = gClass24.int_17;
						GClass144.smethod_19(mResources.miss, gClass24.int_8, gClass24.int_9 - gClass24.int_21, 0, -2, GClass4.int_7);
					}
					else
						GClass144.smethod_19("-" + GClass65.smethod_9(num72), gClass24.int_8, gClass24.int_9 - gClass24.int_21, 0, -2, GClass4.int_8);
				}
				if (b26 == 6)
				{
					int num73 = msg.method_1().method_8();
					if (num73 == GClass78.smethod_1().int_13)
						GClass78.smethod_1().gclass194_1.method_22();
					else
						GClass144.smethod_14(num73)?.gclass194_1.method_22();
				}
				if (b26 != 7)
					break;
				int num74 = msg.method_1().method_8();
				if (num74 == GClass78.smethod_1().int_13)
				{
					GClass78.smethod_1().gclass194_1 = null;
					for (int num75 = 0; num75 < GClass144.gclass88_9.method_2(); num75++)
					{
						if (((GClass194)GClass144.gclass88_9.method_3(num75)).int_25 == num74)
							GClass144.gclass88_9.method_7(num75);
					}
					break;
				}
				gClass = GClass144.smethod_14(num74);
				for (int num76 = 0; num76 < GClass144.gclass88_9.method_2(); num76++)
				{
					if (((GClass194)GClass144.gclass88_9.method_3(num76)).int_25 == num74)
						GClass144.gclass88_9.method_7(num76);
				}
				if (gClass != null)
					gClass.gclass194_1 = null;
				break;
			}
			case -94:
				while (msg.method_1().method_18() > 0)
				{
					short num118 = msg.method_1().method_6();
					int num119 = msg.method_1().method_8();
					for (int num120 = 0; num120 < GClass78.smethod_1().gclass88_0.method_2(); num120++)
					{
						GClass63 gClass35 = (GClass63)GClass78.smethod_1().gclass88_0.method_3(num120);
						if (gClass35 != null && gClass35.short_0 == num118)
						{
							if (num119 < gClass35.int_1)
								gClass35.long_1 = GClass203.smethod_18() - (gClass35.int_1 - num119);
							GClass50.smethod_8("1 chieu id= " + gClass35.gclass47_0.sbyte_0 + " cooldown= " + num119 + "curr cool down= " + gClass35.int_1);
						}
					}
				}
				break;
			case -93:
			{
				short num96 = msg.method_1().method_6();
				GClass10.sbyte_1 = new sbyte[num96];
				for (int num97 = 0; num97 < num96; num97++)
				{
					GClass10.sbyte_1[num97] = msg.method_1().method_2();
				}
				break;
			}
			case -92:
				Main.typeClient = msg.method_1().method_2();
				if (GClass1.smethod_2("ResVersion") == null)
					GClass1.smethod_13();
				GClass1.smethod_9("clienttype", Main.typeClient);
				GClass1.smethod_9("lastZoomlevel", GClass122.int_12);
				if (GClass1.smethod_2("ResVersion") == null)
					GClass73.smethod_34(mResources.plsRestartGame, 8885, null);
				break;
			case -91:
			{
				sbyte b11 = msg.method_1().method_2();
				GClass73.gclass76_0.string_4 = new string[b11];
				GClass73.gclass76_0.string_5 = new string[b11];
				for (int num15 = 0; num15 < b11; num15++)
				{
					GClass73.gclass76_0.string_4[num15] = msg.method_1().method_14();
					GClass73.gclass76_0.string_5[num15] = msg.method_1().method_14();
				}
				GClass148.smethod_0().method_6();
				break;
			}
			case -90:
			{
				sbyte b19 = msg.method_1().method_2();
				int num47 = msg.method_1().method_8();
				GClass50.smethod_8("===> UPDATE_BODY:    type = " + b19);
				gClass = ((GClass78.smethod_1().int_13 != num47) ? GClass144.smethod_14(num47) : GClass78.smethod_1());
				if (b19 != -1)
				{
					short num48 = msg.method_1().method_6();
					short num49 = msg.method_1().method_6();
					short num50 = msg.method_1().method_6();
					sbyte sbyte_ = msg.method_1().method_2();
					if (gClass != null)
					{
						if (gClass.int_13 == num47)
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
						if (num48 != -1)
							gClass.int_119 = num48;
						if (num49 != -1)
							gClass.int_121 = num49;
						if (num50 != -1)
							gClass.int_120 = num50;
					}
				}
				if (b19 == -1 && gClass != null)
				{
					gClass.bool_1 = false;
					gClass.sbyte_35 = 0;
				}
				if (gClass == null)
					;
				break;
			}
			case -88:
				GClass73.smethod_29();
				GClass73.gclass134_0.switchToMe();
				break;
			case -87:
			{
				GClass50.smethod_8("GET UPDATE_DATA " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_5(msg.method_1(), true);
				msg.method_1().method_4();
				sbyte[] data = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data);
				GClass1.smethod_0("NRdataVersion", new sbyte[1] { GClass144.sbyte_0 });
				GClass133.bool_5 = false;
				if (GClass144.sbyte_4 == GClass144.sbyte_0 && GClass144.sbyte_5 == GClass144.sbyte_1 && GClass144.sbyte_6 == GClass144.sbyte_2 && GClass144.sbyte_7 == GClass144.sbyte_3)
				{
					GClass50.smethod_8(GClass144.sbyte_4 + "," + GClass144.sbyte_5 + "," + GClass144.sbyte_6 + "," + GClass144.sbyte_7);
					GClass144.smethod_8().method_22();
					GClass144.smethod_8().method_20();
					GClass144.smethod_8().method_21();
					GClass144.smethod_8().method_23();
					GClass7.smethod_0().method_83();
					return;
				}
				break;
			}
			case -86:
			{
				sbyte b12 = msg.method_1().method_2();
				GClass50.smethod_8("server gui ve giao dich action = " + b12);
				if (b12 == 0)
				{
					int playerID = msg.method_1().method_8();
					GClass144.smethod_8().method_115(playerID);
				}
				if (b12 == 1)
				{
					int num22 = msg.method_1().method_8();
					GClass78 gClass13 = GClass144.smethod_14(num22);
					if (gClass13 == null)
						return;
					GClass73.gclass76_0.method_62(gClass13);
					GClass73.gclass76_0.method_50();
					GClass7.smethod_0().method_15(num22);
				}
				if (b12 == 2)
				{
					sbyte b13 = msg.method_1().method_2();
					for (int num23 = 0; num23 < GClass73.gclass76_0.gclass88_6.method_2(); num23++)
					{
						GClass128 gClass14 = (GClass128)GClass73.gclass76_0.gclass88_6.method_3(num23);
						if (gClass14.int_29 == b13)
						{
							GClass73.gclass76_0.gclass88_6.method_8(gClass14);
							break;
						}
					}
				}
				if (b12 != 5)
					;
				if (b12 == 6)
				{
					GClass73.gclass76_0.bool_2 = true;
					if (GClass73.gclass76_1 != null)
						GClass73.gclass76_1.bool_2 = true;
					GClass73.gclass76_0.gclass88_7.method_9();
					if (GClass73.gclass76_1 != null)
						GClass73.gclass76_1.gclass88_7.method_9();
					int int_3 = msg.method_1().method_8();
					sbyte b14 = msg.method_1().method_2();
					GClass50.smethod_8("item size = " + b14);
					for (int num24 = 0; num24 < b14; num24++)
					{
						GClass128 gClass15 = new GClass128();
						gClass15.gclass117_0 = GClass0.smethod_1(msg.method_1().method_6());
						gClass15.int_30 = msg.method_1().method_8();
						int num25 = msg.method_1().method_5();
						if (num25 != 0)
						{
							gClass15.gclass120_0 = new GClass120[num25];
							for (int num26 = 0; num26 < gClass15.gclass120_0.Length; num26++)
							{
								int optionTemplateId = msg.method_1().method_5();
								int param = msg.method_1().method_7();
								gClass15.gclass120_0[num26] = new GClass120(optionTemplateId, param);
								gClass15.int_43 = GClass73.gclass76_0.method_131(gClass15);
							}
						}
						if (GClass73.gclass76_1 == null)
							GClass73.gclass76_0.gclass88_7.method_0(gClass15);
						else
							GClass73.gclass76_1.gclass88_7.method_0(gClass15);
					}
					if (GClass73.gclass76_1 == null)
					{
						GClass73.gclass76_0.int_23 = int_3;
						if (GClass73.gclass76_0.int_29 == 2)
							GClass73.gclass76_0.method_61(false);
					}
					else
					{
						GClass73.gclass76_1.method_61(false);
						GClass73.gclass76_1.int_23 = int_3;
					}
				}
				if (b12 == 7)
				{
					GClass130.smethod_5();
					if (GClass73.gclass76_0.bool_0)
						GClass73.gclass76_0.method_151();
				}
				break;
			}
			case -85:
			{
				GClass50.smethod_8("CAP CHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
				sbyte b15 = msg.method_1().method_2();
				if (b15 == 0)
				{
					int num28 = msg.method_1().method_7();
					GClass50.smethod_8("lent =" + num28);
					sbyte[] data3 = new sbyte[num28];
					msg.method_1().method_21(ref data3, 0, num28);
					GClass144.gclass70_44 = GClass70.smethod_6(data3, 0, num28);
					GClass144.smethod_8().string_8 = "-----";
					GClass144.smethod_8().string_7 = msg.method_1().method_14();
					GClass144.smethod_8().int_118 = new int[GClass144.smethod_8().string_7.Length];
					GClass144.smethod_8().gclass194_0 = new GClass194();
					GClass144.smethod_8().gclass87_2 = null;
				}
				if (b15 == 1)
					GClass30.bool_2 = true;
				if (b15 == 2)
				{
					GClass30.bool_0 = true;
					GClass144.smethod_8().gclass87_2 = GClass144.smethod_8().gclass87_10;
				}
				break;
			}
			case -84:
			{
				int index2 = msg.method_1().method_5();
				GClass194 gClass36 = null;
				try
				{
					gClass36 = (GClass194)GClass144.gclass88_9.method_3(index2);
				}
				catch (Exception)
				{
				}
				if (gClass36 != null)
					gClass36.int_7 = msg.method_1().method_8();
				break;
			}
			case -83:
			{
				sbyte b48 = msg.method_1().method_2();
				if (b48 == 0)
				{
					int num147 = msg.method_1().method_6();
					int int_13 = msg.method_1().method_6();
					int num148 = msg.method_1().method_5();
					int num149 = msg.method_1().method_8();
					msg.method_1().method_14();
					int int_14 = msg.method_1().method_6();
					int int_15 = msg.method_1().method_6();
					if (msg.method_1().method_2() != 1)
						GClass144.smethod_8().bool_64 = false;
					else
						GClass144.smethod_8().bool_64 = true;
					GClass144.smethod_8().int_129 = int_14;
					GClass144.smethod_8().int_130 = int_15;
					GClass50.smethod_8("xR= " + int_14 + " yR= " + int_15 + " +++++++++++++++++++++++++++++++++++++++");
					if (GClass78.smethod_1().int_13 != num149)
					{
						if (GClass20.int_37 == num147 && GClass20.int_39 == num148)
							GClass144.smethod_8().method_52(false);
						else if (GClass122.int_12 > 1)
						{
							GClass144.smethod_8().method_54();
						}
					}
					else
					{
						GClass73.gclass76_0.method_150();
						GClass144.smethod_8().method_52(true);
					}
					GClass144.smethod_8().int_104 = num147;
					GClass144.smethod_8().int_106 = int_13;
					GClass144.smethod_8().int_105 = num148;
				}
				if (b48 == 1)
				{
					GClass50.smethod_8("map RID = " + GClass144.smethod_8().int_104 + " zone RID= " + GClass144.smethod_8().int_105);
					GClass50.smethod_8("map ID = " + GClass20.int_37 + " zone ID= " + GClass20.int_39);
					if (GClass20.int_37 == GClass144.smethod_8().int_104 && GClass20.int_39 == GClass144.smethod_8().int_105)
						GClass144.smethod_8().method_53();
					else
					{
						GClass144.smethod_8().bool_63 = false;
						if (GClass144.smethod_8().bool_64)
							GClass144.smethod_8().bool_64 = false;
					}
				}
				if (b48 == 2)
					;
				break;
			}
			case -82:
			{
				sbyte b54 = msg.method_1().method_2();
				GClass20.int_65 = new int[b54][][];
				GClass20.int_64 = new int[b54][];
				for (int num169 = 0; num169 < b54; num169++)
				{
					sbyte b55 = msg.method_1().method_2();
					GClass20.int_64[num169] = new int[b55];
					GClass20.int_65[num169] = new int[b55][];
					for (int num170 = 0; num170 < b55; num170++)
					{
						GClass20.int_64[num169][num170] = msg.method_1().method_8();
						sbyte b56 = msg.method_1().method_2();
						GClass20.int_65[num169][num170] = new int[b56];
						for (int num171 = 0; num171 < b56; num171++)
						{
							GClass20.int_65[num169][num170][num171] = msg.method_1().method_2();
						}
					}
				}
				break;
			}
			case -81:
			{
				sbyte b31 = msg.method_1().method_2();
				if (b31 == 0)
				{
					string src = msg.method_1().method_14();
					string src2 = msg.method_1().method_14();
					GClass73.gclass76_0.method_35();
					GClass73.gclass76_0.string_24 = GClass4.gclass4_2.method_15(src, GClass76.int_55);
					GClass73.gclass76_0.string_25 = GClass4.gclass4_11.method_15(src2, GClass76.int_55);
					GClass73.gclass76_0.method_50();
				}
				if (b31 == 1)
				{
					GClass73.gclass76_0.gclass88_0.method_9();
					sbyte b32 = msg.method_1().method_2();
					for (int num85 = 0; num85 < b32; num85++)
					{
						sbyte b33 = msg.method_1().method_2();
						for (int num86 = 0; num86 < GClass78.smethod_1().gclass128_0.Length; num86++)
						{
							GClass128 gClass30 = GClass78.smethod_1().gclass128_0[num86];
							if (gClass30 != null && gClass30.int_29 == b33)
							{
								gClass30.bool_0 = true;
								GClass73.gclass76_0.gclass88_0.method_0(gClass30);
							}
						}
					}
					if (GClass73.gclass76_0.bool_0)
						GClass73.gclass76_0.method_36();
				}
				if (b31 == 2)
				{
					GClass73.gclass76_0.sbyte_8 = 0;
					GClass73.gclass76_0.method_195(0);
				}
				if (b31 == 3)
				{
					GClass73.gclass76_0.sbyte_8 = 1;
					GClass73.gclass76_0.method_195(0);
				}
				if (b31 == 4)
				{
					short short_3 = msg.method_1().method_6();
					GClass73.gclass76_0.short_3 = short_3;
					GClass73.gclass76_0.sbyte_8 = 0;
					GClass73.gclass76_0.method_195(1);
				}
				if (b31 == 5)
				{
					short short_4 = msg.method_1().method_6();
					GClass73.gclass76_0.short_3 = short_4;
					GClass73.gclass76_0.sbyte_8 = 0;
					GClass73.gclass76_0.method_195(2);
				}
				if (b31 == 6)
				{
					short short_5 = msg.method_1().method_6();
					short short_6 = msg.method_1().method_6();
					GClass73.gclass76_0.sbyte_8 = 0;
					GClass73.gclass76_0.method_195(3);
					GClass73.gclass76_0.short_1 = short_5;
					GClass73.gclass76_0.short_3 = short_6;
				}
				if (b31 == 7)
				{
					short short_7 = msg.method_1().method_6();
					GClass73.gclass76_0.short_3 = short_7;
					GClass73.gclass76_0.sbyte_8 = 0;
					GClass73.gclass76_0.method_195(4);
				}
				if (b31 == 8)
				{
					GClass73.gclass76_0.short_3 = -1;
					GClass73.gclass76_0.sbyte_8 = 1;
					GClass73.gclass76_0.method_195(4);
				}
				short num87 = 21;
				int num88 = 0;
				int num89 = 0;
				try
				{
					num87 = msg.method_1().method_6();
					num88 = msg.method_1().method_6();
					num89 = msg.method_1().method_6();
					GClass73.gclass76_0.int_153 = num88 - GClass144.int_22;
					GClass73.gclass76_0.int_154 = num89 - GClass144.int_23;
				}
				catch (Exception)
				{
				}
				for (int num90 = 0; num90 < GClass144.gclass88_10.method_2(); num90++)
				{
					GClass79 gClass31 = (GClass79)GClass144.gclass88_10.method_3(num90);
					if (gClass31.gclass127_0.int_0 == num87)
					{
						GClass73.gclass76_0.int_153 = gClass31.int_4 - GClass144.int_22;
						GClass73.gclass76_0.int_154 = gClass31.int_5 - GClass144.int_23;
						GClass73.gclass76_0.int_152 = num87;
						break;
					}
				}
				break;
			}
			case -80:
			{
				sbyte b6 = msg.method_1().method_2();
				GClass130.smethod_5();
				if (b6 == 0)
				{
					GClass73.gclass76_0.gclass88_5.method_9();
					int num7 = msg.method_1().method_5();
					for (int k = 0; k < num7; k++)
					{
						GClass78 gClass5 = new GClass78();
						gClass5.int_13 = msg.method_1().method_8();
						gClass5.int_119 = msg.method_1().method_6();
						gClass5.int_118 = msg.method_1().method_6();
						gClass5.int_121 = msg.method_1().method_6();
						gClass5.int_120 = msg.method_1().method_6();
						gClass5.int_122 = msg.method_1().method_5();
						gClass5.string_3 = msg.method_1().method_14();
						bool flag2 = msg.method_1().method_11();
						GClass16 gClass6 = new GClass16(mResources.power + ": " + msg.method_1().method_14());
						gClass6.gclass78_0 = gClass5;
						gClass6.bool_1 = flag2;
						GClass73.gclass76_0.gclass88_5.method_0(gClass6);
					}
					GClass73.gclass76_0.method_25();
					GClass73.gclass76_0.method_50();
				}
				if (b6 == 3)
				{
					GClass88 gclass88_ = GClass73.gclass76_0.gclass88_5;
					int num8 = msg.method_1().method_8();
					GClass50.smethod_8("online offline id=" + num8);
					for (int l = 0; l < gclass88_.method_2(); l++)
					{
						GClass16 gClass7 = (GClass16)gclass88_.method_3(l);
						if (gClass7.gclass78_0 != null && gClass7.gclass78_0.int_13 == num8)
						{
							GClass50.smethod_8("online= " + gClass7.bool_1);
							gClass7.bool_1 = msg.method_1().method_11();
							break;
						}
					}
				}
				if (b6 != 2)
					break;
				GClass88 gclass88_2 = GClass73.gclass76_0.gclass88_5;
				int num9 = msg.method_1().method_8();
				for (int m = 0; m < gclass88_2.method_2(); m++)
				{
					GClass16 gClass8 = (GClass16)gclass88_2.method_3(m);
					if (gClass8.gclass78_0 != null && gClass8.gclass78_0.int_13 == num9)
					{
						gclass88_2.method_8(gClass8);
						break;
					}
				}
				if (GClass73.gclass76_0.bool_0)
					GClass73.gclass76_0.method_29();
				break;
			}
			case -79:
			{
				GClass130.smethod_5();
				msg.method_1().method_8();
				GClass78 gclass78_ = GClass73.gclass76_0.gclass78_0;
				if (gclass78_ != null)
				{
					gclass78_.long_2 = msg.method_1().method_9();
					gclass78_.string_6 = msg.method_1().method_14();
					break;
				}
				return;
			}
			case -77:
			{
				short num153 = msg.method_1().method_6();
				GClass28.sbyte_0 = new sbyte[num153];
				GClass28.short_0 = num153;
				GClass28.gclass83_0 = new GClass83[num153];
				for (int num154 = 0; num154 < num153; num154++)
				{
					GClass28.sbyte_0[num154] = msg.method_1().method_2();
				}
				break;
			}
			case -76:
			{
				sbyte b45 = msg.method_1().method_2();
				if (b45 != 0)
				{
					if (b45 == 1)
					{
						int num142 = msg.method_1().method_5();
						if (GClass78.smethod_1().gclass6_0[num142] != null)
							GClass78.smethod_1().gclass6_0[num142].bool_1 = true;
					}
					break;
				}
				sbyte b46 = msg.method_1().method_2();
				if (b46 <= 0)
					return;
				GClass78.smethod_1().gclass6_0 = new GClass6[b46];
				for (int num143 = 0; num143 < b46; num143++)
				{
					GClass78.smethod_1().gclass6_0[num143] = new GClass6();
					GClass78.smethod_1().gclass6_0[num143].string_0 = num143 + 1 + ". " + msg.method_1().method_14();
					GClass78.smethod_1().gclass6_0[num143].string_1 = msg.method_1().method_14();
					GClass78.smethod_1().gclass6_0[num143].int_0 = msg.method_1().method_6();
					GClass78.smethod_1().gclass6_0[num143].bool_0 = msg.method_1().method_11();
					GClass78.smethod_1().gclass6_0[num143].bool_1 = msg.method_1().method_11();
				}
				GClass73.gclass76_0.method_9();
				GClass73.gclass76_0.method_50();
				break;
			}
			case -74:
				if (GClass134.bool_2)
					return;
				if (GClass73.smethod_41())
				{
					bool flag = true;
					sbyte b5 = msg.method_1().method_2();
					if (b5 == 0)
					{
						int num3 = msg.method_1().method_8();
						string text3 = GClass1.smethod_2("ResVersion");
						int num4 = ((text3 == null || !(text3 != "")) ? (-1) : int.Parse(text3));
						if (!GClass14.smethod_0().method_3())
						{
							GClass14.smethod_0().close();
							GClass134.bool_6 = true;
							GClass134.bool_7 = false;
							GClass134.int_11 = 1000;
							GClass73.gclass134_0.switchToMe();
						}
						else if (num4 == -1 || num4 != num3)
						{
							GClass73.gclass134_0.method_7();
						}
						else
						{
							GClass50.smethod_8("login ngay");
							GClass28.smethod_0();
							GClass142.gclass70_0 = null;
							GClass134.bool_6 = true;
							if (GClass73.gclass131_0 != GClass73.gclass133_0)
								GClass73.gclass134_0.switchToMe();
						}
					}
					if (b5 == 1)
					{
						GClass134.string_11 = mResources.downloading_data;
						_ = (short)(GClass134.int_17 = msg.method_1().method_6());
						GClass7.smethod_0().method_125(2, null);
					}
					if (b5 == 2)
						try
						{
							bool_0 = true;
							GClass73.smethod_29();
							GClass134.int_19++;
							GClass134.int_16 = GClass134.int_19 * 100 / GClass134.int_17;
							string[] array2 = GClass50.smethod_30(msg.method_1().method_14(), "/", 0);
							string filename = "x" + GClass122.int_12 + array2[array2.Length - 1];
							int num5 = msg.method_1().method_8();
							sbyte[] data2 = new sbyte[num5];
							msg.method_1().method_21(ref data2, 0, num5);
							GClass1.smethod_0(filename, data2);
						}
						catch (Exception)
						{
							GClass73.smethod_34(mResources.pls_restart_game_error, 8885, null);
						}
					if (b5 == 3 && flag)
					{
						bool_0 = false;
						int num6 = msg.method_1().method_8();
						GClass50.smethod_8("last version= " + num6);
						GClass1.smethod_4("ResVersion", num6 + "");
						GClass7.smethod_0().method_125(3, null);
						GClass73.smethod_29();
						GClass142.gclass70_0 = null;
						GClass28.smethod_0();
						GClass203.smethod_26();
						GClass134.bool_4 = true;
						GClass134.bool_6 = true;
						GClass144.smethod_8().method_24();
						if (GClass73.gclass131_0 != GClass73.gclass133_0)
							GClass73.gclass134_0.switchToMe();
					}
					break;
				}
				GClass7.smethod_0().method_125(3, null);
				GClass28.smethod_0();
				GClass142.gclass70_0 = null;
				if (GClass1.smethod_2("acc") != null || GClass1.smethod_2("userAo" + GClass134.int_14) != null)
					GClass133.bool_0 = true;
				GClass73.gclass133_0 = new GClass133();
				GClass73.gclass133_0.switchToMe();
				return;
			case -70:
			{
				GClass50.smethod_8("BIG MESSAGE .......................................");
				GClass73.smethod_29();
				int int_16 = msg.method_1().method_6();
				string chat4 = msg.method_1().method_14();
				GClass79 gClass54 = new GClass79(-1, 0, 0, 0, 0, 0);
				gClass54.int_70 = int_16;
				GClass96.smethod_1(chat4, 100000, gClass54);
				sbyte b57 = msg.method_1().method_2();
				if (b57 == 0)
				{
					GClass96.gclass96_1.gclass87_1 = new GClass87(mResources.CLOSE, GClass96.gclass96_1, 1001, null);
					GClass96.gclass96_1.gclass87_1.int_1 = GClass73.int_10 / 2 - 35;
					GClass96.gclass96_1.gclass87_1.int_2 = GClass73.int_11 - 35;
				}
				if (b57 == 1)
				{
					string p = msg.method_1().method_14();
					string caption2 = msg.method_1().method_14();
					GClass96.gclass96_1.gclass87_1 = new GClass87(caption2, GClass96.gclass96_1, 1000, p);
					GClass96.gclass96_1.gclass87_1.int_1 = GClass73.int_10 / 2 - 75;
					GClass96.gclass96_1.gclass87_1.int_2 = GClass73.int_11 - 35;
					GClass96.gclass96_1.gclass87_2 = new GClass87(mResources.CLOSE, GClass96.gclass96_1, 1001, null);
					GClass96.gclass96_1.gclass87_2.int_1 = GClass73.int_10 / 2 + 11;
					GClass96.gclass96_1.gclass87_2.int_2 = GClass73.int_11 - 35;
				}
				break;
			}
			case -69:
				GClass78.smethod_1().short_24 = msg.method_1().method_6();
				break;
			case -68:
				GClass78.smethod_1().int_77 = msg.method_1().method_6();
				break;
			case -67:
			{
				float_0 += 1f;
				int num129 = msg.method_1().method_8();
				sbyte[] array11 = null;
				try
				{
					array11 = GClass65.smethod_2(msg);
					if (num129 == 3896)
						;
					GClass28.gclass83_0[num129].gclass70_0 = method_6(array11);
				}
				catch (Exception)
				{
					array11 = null;
					GClass28.gclass83_0[num129].gclass70_0 = GClass70.smethod_9(new int[1], 1, 1, true);
				}
				if (array11 != null)
					GClass1.smethod_0(GClass122.int_12 + "Small" + num129, array11);
				break;
			}
			case -66:
			{
				short id = msg.method_1().method_6();
				sbyte[] data4 = GClass65.smethod_2(msg);
				GClass72 gClass21 = GClass81.smethod_2(id);
				sbyte b21 = msg.method_1().method_0();
				if (b21 == 0)
					gClass21.method_7(data4);
				else
					gClass21.method_8(data4, b21);
				sbyte[] array6 = GClass65.smethod_2(msg);
				gClass21.gclass70_0 = GClass70.smethod_6(array6, 0, array6.Length);
				break;
			}
			case -65:
			{
				GClass130.smethod_5();
				int num131 = msg.method_1().method_8();
				sbyte b42 = msg.method_1().method_2();
				if (b42 == 0)
					break;
				if (GClass78.smethod_1().int_13 == num131)
				{
					bool_5 = true;
					GClass144.int_38 = 500;
					GClass144.smethod_8().gclass87_1 = null;
					if (b42 == 0 || b42 == 1 || b42 == 3)
						GClass23.smethod_0(new GClass23(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, GClass78.smethod_1().int_119, GClass78.smethod_1().int_12, 0, true, (b42 != 1) ? b42 : GClass78.smethod_1().int_14));
					if (b42 == 2)
					{
						GClass144.int_38 = 50;
						GClass78.smethod_1().method_36();
					}
				}
				else
				{
					GClass78 gClass37 = GClass144.smethod_14(num131);
					if ((b42 == 0 || b42 == 1 || b42 == 3) && gClass37 != null)
					{
						gClass37.bool_3 = true;
						GClass23 gClass38 = new GClass23(gClass37.int_4, gClass37.int_5, gClass37.int_119, gClass37.int_12, 0, false, (b42 != 1) ? b42 : gClass37.int_14);
						gClass38.int_5 = num131;
						GClass23.smethod_0(gClass38);
					}
					if (b42 == 2)
						gClass37.method_36();
				}
				break;
			}
			case -64:
			{
				int num38 = msg.method_1().method_8();
				int int_7 = msg.method_1().method_5();
				gClass = null;
				gClass = ((num38 != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num38) : GClass78.smethod_1());
				if (gClass != null)
				{
					gClass.int_122 = int_7;
					for (int num39 = 0; num39 < 54; num39++)
					{
						gClass.method_141(0, 201 + num39);
					}
					if (gClass.int_122 >= 201 && gClass.int_122 < 255)
					{
						GClass81 gClass17 = new GClass81(gClass.int_122, gClass, 2, -1, 10, 1);
						gClass17.int_1 = 5;
						gClass.method_140(gClass17);
					}
					GClass50.smethod_8("cmd:-64 UPDATE BAG PLAER = " + ((gClass == null) ? "" : gClass.string_3) + num38 + " BAG ID= " + int_7);
					break;
				}
				return;
			}
			case -63:
			{
				GClass50.smethod_8("GET BAG");
				int num80 = msg.method_1().method_5();
				sbyte b30 = msg.method_1().method_2();
				GClass68 gClass27 = new GClass68();
				gClass27.int_0 = num80;
				if (b30 > 0)
				{
					gClass27.short_0 = new short[b30];
					for (int num81 = 0; num81 < b30; num81++)
					{
						gClass27.short_0[num81] = msg.method_1().method_6();
						GClass50.smethod_8("ID=  " + num80 + " frame= " + gClass27.short_0[num81]);
					}
					GClass68.gclass113_0.method_4(num80 + "", gClass27);
				}
				break;
			}
			case -62:
			{
				int num51 = msg.method_1().method_5();
				sbyte b20 = msg.method_1().method_2();
				if (b20 <= 0)
					break;
				GClass68 gClass19 = GClass68.smethod_1((short)num51);
				if (gClass19 == null)
					break;
				gClass19.short_0 = new short[b20];
				for (int num52 = 0; num52 < b20; num52++)
				{
					gClass19.short_0[num52] = msg.method_1().method_6();
					if (gClass19.short_0[num52] > 0)
						GClass28.gclass88_0.method_0(gClass19.short_0[num52] + "");
				}
				break;
			}
			case -61:
			{
				int num2 = msg.method_1().method_8();
				if (num2 == GClass78.smethod_1().int_13)
				{
					if (GClass78.smethod_1().gclass106_0 != null)
						GClass78.smethod_1().gclass106_0.int_0 = msg.method_1().method_8();
				}
				else if (GClass144.smethod_14(num2) != null)
				{
					GClass144.smethod_14(num2).int_56 = msg.method_1().method_8();
					if (GClass144.smethod_14(num2).int_56 == -2)
						GClass144.smethod_14(num2).bool_59 = true;
				}
				break;
			}
			case -60:
			{
				GClass73.smethod_8("SA7666", 2);
				int num137 = msg.method_1().method_8();
				int num138 = -1;
				if (num137 != GClass78.smethod_1().int_13)
				{
					GClass78 gClass42 = GClass144.smethod_14(num137);
					if (gClass42 == null)
						return;
					if (gClass42.gclass29_0 != null)
					{
						gClass42.method_79(gClass42.int_4, gClass42.int_5, 10);
						gClass42.int_4 = gClass42.gclass29_0.int_0;
						gClass42.int_5 = gClass42.gclass29_0.int_1;
					}
					int num139 = msg.method_1().method_5();
					if ((GClass20.smethod_27(gClass42.int_4, gClass42.int_5) & 2) != 2)
						gClass42.method_69(GClass144.gclass39_0[num139], 1);
					else
						gClass42.method_69(GClass144.gclass39_0[num139], 0);
					GClass78[] array13 = new GClass78[msg.method_1().method_2()];
					for (num = 0; num < array13.Length; num++)
					{
						num138 = msg.method_1().method_8();
						GClass78 gClass43;
						if (num138 == GClass78.smethod_1().int_13)
						{
							gClass43 = GClass78.smethod_1();
							if (!GClass144.bool_70 && GClass144.bool_68 && GClass144.bool_69)
							{
								GClass7.smethod_0().method_42(-1, -1);
								GClass144.bool_70 = true;
							}
						}
						else
							gClass43 = GClass144.smethod_14(num138);
						array13[num] = gClass43;
						if (num == 0)
						{
							if (gClass42.int_4 <= gClass43.int_4)
								gClass42.int_12 = 1;
							else
								gClass42.int_12 = -1;
						}
					}
					if (num > 0)
					{
						gClass42.gclass78_1 = new GClass78[num];
						for (num = 0; num < gClass42.gclass78_1.Length; num++)
						{
							gClass42.gclass78_1[num] = array13[num];
						}
						gClass42.gclass194_0 = null;
						gClass42.gclass78_0 = gClass42.gclass78_1[0];
					}
				}
				else
				{
					msg.method_1().method_2();
					msg.method_1().method_2();
					num138 = msg.method_1().method_8();
				}
				try
				{
					sbyte b43 = msg.method_1().method_2();
					GClass50.smethod_8("isRead continue = " + b43);
					if (b43 != 1)
						break;
					sbyte b44 = msg.method_1().method_2();
					GClass50.smethod_8("type skill = " + b44);
					if (num138 != GClass78.smethod_1().int_13)
					{
						gClass = GClass144.smethod_14(num138);
						if (gClass == null)
							return;
						bool flag9 = false;
						int num140 = msg.method_3();
						GClass50.smethod_8("dame hit= " + num140);
						gClass.bool_7 = msg.method_1().method_11();
						GClass50.smethod_8("isDie=" + gClass.bool_7 + "---------------------------------------");
						flag9 = (gClass.bool_6 = msg.method_1().method_11());
						gClass.bool_5 = false;
						num140 = (gClass.int_39 = num140 + 0);
						if (b44 == 0)
							gClass.method_112(num140, 0, flag9, false);
					}
					else
					{
						bool flag10 = false;
						gClass = GClass78.smethod_1();
						int num141 = msg.method_3();
						GClass50.smethod_8("dame hit = " + num141);
						gClass.bool_7 = msg.method_1().method_11();
						if (gClass.bool_7)
							GClass78.bool_34 = true;
						GClass50.smethod_8("isDie=" + gClass.bool_7 + "---------------------------------------");
						flag10 = (gClass.bool_6 = msg.method_1().method_11());
						gClass.bool_5 = false;
						num141 = (gClass.int_39 = num141 + 0);
						if (b44 == 0)
							gClass.method_112(num141, 0, flag10, false);
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
				GClass144.smethod_8().method_114(msg.method_1().method_8(), msg.method_1().method_8(), msg.method_1().method_14(), typePK);
				break;
			}
			case -57:
			{
				string strInvite = msg.method_1().method_14();
				int clanID = msg.method_1().method_8();
				int code = msg.method_1().method_8();
				GClass144.smethod_8().method_28(strInvite, clanID, code);
				break;
			}
			case -53:
			{
				GClass130.smethod_5();
				bool flag3 = false;
				int num40 = msg.method_1().method_8();
				GClass50.smethod_8("clanId= " + num40);
				if (num40 != -1)
				{
					GClass73.gclass76_0.gclass84_0 = null;
					if (GClass78.smethod_1().gclass106_0 == null)
						GClass78.smethod_1().gclass106_0 = new GClass106();
					GClass78.smethod_1().gclass106_0.int_0 = num40;
					GClass78.smethod_1().gclass106_0.string_0 = msg.method_1().method_14();
					GClass78.smethod_1().gclass106_0.string_1 = msg.method_1().method_14();
					GClass78.smethod_1().gclass106_0.int_1 = msg.method_1().method_5();
					GClass78.smethod_1().gclass106_0.string_2 = msg.method_1().method_14();
					GClass78.smethod_1().gclass106_0.string_3 = msg.method_1().method_14();
					GClass78.smethod_1().gclass106_0.int_3 = msg.method_1().method_5();
					GClass78.smethod_1().gclass106_0.int_4 = msg.method_1().method_5();
					GClass78.smethod_1().sbyte_17 = msg.method_1().method_2();
					GClass78.smethod_1().gclass106_0.int_7 = msg.method_1().method_8();
					GClass78.smethod_1().gclass106_0.int_6 = msg.method_1().method_2();
					GClass73.gclass76_0.gclass88_2 = new GClass88();
					for (int num41 = 0; num41 < GClass78.smethod_1().gclass106_0.int_3; num41++)
					{
						GClass38 gClass18 = new GClass38();
						gClass18.int_0 = msg.method_1().method_8();
						gClass18.short_0 = msg.method_1().method_6();
						gClass18.short_1 = msg.method_1().method_6();
						gClass18.short_2 = msg.method_1().method_6();
						gClass18.short_3 = msg.method_1().method_6();
						gClass18.string_0 = msg.method_1().method_14();
						gClass18.sbyte_0 = msg.method_1().method_2();
						gClass18.string_1 = msg.method_1().method_14();
						gClass18.int_1 = msg.method_1().method_8();
						gClass18.int_2 = msg.method_1().method_8();
						gClass18.int_4 = msg.method_1().method_8();
						gClass18.int_3 = msg.method_1().method_8();
						gClass18.string_2 = GClass65.smethod_6(msg.method_1().method_8());
						GClass73.gclass76_0.gclass88_2.method_0(gClass18);
					}
					int num42 = msg.method_1().method_5();
					for (int num43 = 0; num43 < num42; num43++)
					{
						method_8(msg, -1);
					}
					if (GClass73.gclass76_0.bool_10 || GClass73.gclass76_0.bool_12 || GClass73.gclass76_0.bool_11)
						GClass73.gclass76_0.method_79();
					if (flag3)
						GClass73.gclass76_0.method_79();
					GClass50.smethod_8("=>>>>>>>>>>>>>>>>>>>>>> -537 MY CLAN INFO");
					break;
				}
				flag3 = true;
				GClass78.smethod_1().gclass106_0 = null;
				GClass189.gclass88_0.method_9();
				if (GClass73.gclass76_0.gclass88_1 != null)
					GClass73.gclass76_0.gclass88_1.method_9();
				if (GClass73.gclass76_0.gclass88_2 != null)
					GClass73.gclass76_0.gclass88_2.method_9();
				if (GClass73.gclass131_0 == GClass144.smethod_8())
					GClass73.gclass76_0.method_79();
				return;
			}
			case -52:
			{
				sbyte b50 = msg.method_1().method_2();
				if (b50 == 0)
				{
					GClass38 gClass45 = new GClass38();
					gClass45.int_0 = msg.method_1().method_8();
					gClass45.short_0 = msg.method_1().method_6();
					gClass45.short_1 = msg.method_1().method_6();
					gClass45.short_2 = msg.method_1().method_6();
					gClass45.short_3 = msg.method_1().method_6();
					gClass45.string_0 = msg.method_1().method_14();
					gClass45.sbyte_0 = msg.method_1().method_2();
					gClass45.string_1 = msg.method_1().method_14();
					gClass45.int_1 = msg.method_1().method_8();
					gClass45.int_2 = msg.method_1().method_8();
					gClass45.int_4 = msg.method_1().method_8();
					gClass45.string_2 = GClass65.smethod_6(msg.method_1().method_8());
					if (GClass73.gclass76_0.gclass88_2 == null)
						GClass73.gclass76_0.gclass88_2 = new GClass88();
					GClass73.gclass76_0.gclass88_2.method_0(gClass45);
					GClass73.gclass76_0.method_78();
				}
				if (b50 == 1)
				{
					GClass73.gclass76_0.gclass88_2.method_7(msg.method_1().method_2());
					GClass73.gclass76_0.int_41--;
					GClass73.gclass76_0.method_78();
				}
				if (b50 == 2)
				{
					GClass38 gClass46 = new GClass38();
					gClass46.int_0 = msg.method_1().method_8();
					gClass46.short_0 = msg.method_1().method_6();
					gClass46.short_1 = msg.method_1().method_6();
					gClass46.short_2 = msg.method_1().method_6();
					gClass46.short_3 = msg.method_1().method_6();
					gClass46.string_0 = msg.method_1().method_14();
					gClass46.sbyte_0 = msg.method_1().method_2();
					gClass46.string_1 = msg.method_1().method_14();
					gClass46.int_1 = msg.method_1().method_8();
					gClass46.int_2 = msg.method_1().method_8();
					gClass46.int_4 = msg.method_1().method_8();
					gClass46.string_2 = GClass65.smethod_6(msg.method_1().method_8());
					for (int num151 = 0; num151 < GClass73.gclass76_0.gclass88_2.method_2(); num151++)
					{
						GClass38 gClass47 = (GClass38)GClass73.gclass76_0.gclass88_2.method_3(num151);
						if (gClass47.int_0 == gClass46.int_0)
						{
							if (GClass78.smethod_1().int_13 == gClass46.int_0)
								GClass78.smethod_1().sbyte_17 = gClass46.sbyte_0;
							GClass38 o = gClass46;
							GClass73.gclass76_0.gclass88_2.method_8(gClass47);
							GClass73.gclass76_0.gclass88_2.method_10(o, num151);
							return;
						}
					}
				}
				GClass50.smethod_8("=>>>>>>>>>>>>>>>>>>>>>> -52  MY CLAN UPDSTE");
				break;
			}
			case -51:
				GClass130.smethod_5();
				method_8(msg, 0);
				if (GClass73.gclass76_0.bool_11 && GClass73.gclass76_0.int_28 == 5)
					GClass73.gclass76_0.method_78();
				break;
			case -50:
			{
				GClass130.smethod_5();
				GClass73.gclass76_0.gclass88_1 = new GClass88();
				sbyte b47 = msg.method_1().method_2();
				for (int num146 = 0; num146 < b47; num146++)
				{
					GClass38 gClass44 = new GClass38();
					gClass44.int_0 = msg.method_1().method_8();
					gClass44.short_0 = msg.method_1().method_6();
					gClass44.short_1 = msg.method_1().method_6();
					gClass44.short_2 = msg.method_1().method_6();
					gClass44.short_3 = msg.method_1().method_6();
					gClass44.string_0 = msg.method_1().method_14();
					gClass44.sbyte_0 = msg.method_1().method_2();
					gClass44.string_1 = msg.method_1().method_14();
					gClass44.int_1 = msg.method_1().method_8();
					gClass44.int_2 = msg.method_1().method_8();
					gClass44.int_4 = msg.method_1().method_8();
					gClass44.string_2 = GClass65.smethod_6(msg.method_1().method_8());
					GClass73.gclass76_0.gclass88_1.method_0(gClass44);
				}
				GClass73.gclass76_0.bool_12 = true;
				GClass73.gclass76_0.bool_10 = false;
				GClass73.gclass76_0.bool_11 = false;
				GClass73.gclass76_0.int_41 = GClass73.gclass76_0.gclass88_1.method_2() + 2;
				GClass73.gclass76_0.method_78();
				break;
			}
			case -47:
			{
				GClass130.smethod_5();
				sbyte b39 = msg.method_1().method_2();
				GClass50.smethod_8("clan = " + b39);
				if (b39 == 0)
				{
					GClass73.gclass76_0.string_21 = mResources.cannot_find_clan;
					GClass73.gclass76_0.gclass106_1 = null;
				}
				else
				{
					GClass73.gclass76_0.gclass106_1 = new GClass106[b39];
					GClass50.smethod_8("clan search lent= " + GClass73.gclass76_0.gclass106_1.Length);
					for (int num117 = 0; num117 < GClass73.gclass76_0.gclass106_1.Length; num117++)
					{
						GClass73.gclass76_0.gclass106_1[num117] = new GClass106();
						GClass73.gclass76_0.gclass106_1[num117].int_0 = msg.method_1().method_8();
						GClass73.gclass76_0.gclass106_1[num117].string_0 = msg.method_1().method_14();
						GClass73.gclass76_0.gclass106_1[num117].string_1 = msg.method_1().method_14();
						GClass73.gclass76_0.gclass106_1[num117].int_1 = msg.method_1().method_5();
						GClass73.gclass76_0.gclass106_1[num117].string_2 = msg.method_1().method_14();
						GClass73.gclass76_0.gclass106_1[num117].string_3 = msg.method_1().method_14();
						GClass73.gclass76_0.gclass106_1[num117].int_3 = msg.method_1().method_5();
						GClass73.gclass76_0.gclass106_1[num117].int_4 = msg.method_1().method_5();
						GClass73.gclass76_0.gclass106_1[num117].int_2 = msg.method_1().method_8();
					}
				}
				GClass73.gclass76_0.bool_10 = true;
				GClass73.gclass76_0.bool_12 = false;
				GClass73.gclass76_0.bool_11 = false;
				if (GClass73.gclass76_0.bool_10)
					GClass73.gclass76_0.method_78();
				break;
			}
			case -46:
			{
				GClass130.smethod_5();
				sbyte b28 = msg.method_1().method_2();
				if (b28 == 1 || b28 == 3)
				{
					GClass73.smethod_29();
					GClass68.gclass88_0.method_9();
					int num78 = msg.method_1().method_5();
					for (int num79 = 0; num79 < num78; num79++)
					{
						GClass68 gClass26 = new GClass68();
						gClass26.int_0 = msg.method_1().method_5();
						gClass26.string_0 = msg.method_1().method_14();
						gClass26.int_1 = msg.method_1().method_8();
						gClass26.int_2 = msg.method_1().method_8();
						if (!GClass68.smethod_2(gClass26.int_0))
						{
							GClass68.smethod_0(gClass26);
							continue;
						}
						GClass68.smethod_1((short)gClass26.int_0).string_0 = gClass26.string_0;
						GClass68.smethod_1((short)gClass26.int_0).int_1 = gClass26.int_1;
						GClass68.smethod_1((short)gClass26.int_0).int_2 = gClass26.int_2;
					}
					if (GClass78.smethod_1().gclass106_0 != null)
						GClass73.gclass76_0.method_177();
				}
				if (b28 == 4)
				{
					GClass78.smethod_1().gclass106_0.int_1 = msg.method_1().method_5();
					GClass78.smethod_1().gclass106_0.string_1 = msg.method_1().method_14();
				}
				break;
			}
			case -45:
			{
				sbyte b7 = msg.method_1().method_2();
				int num10 = msg.method_1().method_8();
				short num11 = msg.method_1().method_6();
				GClass50.smethod_8(">.SKILL_NOT_FOCUS      skillNotFocusID: " + num11 + " skill type= " + b7 + "   player use= " + num10);
				if (b7 == 20)
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
					GClass50.smethod_8(">.SKILL_NOT_FOCUS  skill typeFrame= " + typeFrame);
					((GClass78.smethod_1().int_13 != num10) ? GClass144.smethod_14(num10) : GClass78.smethod_1()).method_159(num11, isFly, typeFrame, typePaint, dir, timeGong, typeItem);
				}
				if (b7 == 21)
				{
					GClass40 gClass9 = new GClass40();
					gClass9.int_0 = msg.method_1().method_6();
					gClass9.int_1 = msg.method_1().method_6();
					short timeDame = msg.method_1().method_6();
					short rangeDame = msg.method_1().method_6();
					sbyte typePaint2 = 0;
					sbyte typeItem2 = -1;
					GClass40[] array3 = null;
					gClass = ((GClass78.smethod_1().int_13 != num10) ? GClass144.smethod_14(num10) : GClass78.smethod_1());
					try
					{
						typePaint2 = msg.method_1().method_2();
						array3 = new GClass40[msg.method_1().method_2()];
						for (int n = 0; n < array3.Length; n++)
						{
							array3[n] = new GClass40();
							array3[n].sbyte_0 = msg.method_1().method_2();
							if (array3[n].sbyte_0 == 0)
								array3[n].int_29 = msg.method_1().method_2();
							else
								array3[n].int_29 = msg.method_1().method_8();
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
					GClass50.smethod_8(">.SKILL_NOT_FOCUS  skill targetDame= " + gClass9.int_0 + ":" + gClass9.int_1 + "    c:" + gClass.int_4 + ":" + gClass.int_5 + "   cdir:" + gClass.int_12);
					gClass.method_160(1, num11, gClass9, timeDame, rangeDame, typePaint2, array3, typeItem2);
				}
				if (b7 == 0)
				{
					GClass50.smethod_8("id use= " + num10);
					if (GClass78.smethod_1().int_13 == num10)
					{
						GClass78.smethod_1().method_28();
						GClass50.smethod_8("LOAD LAST SKILL");
					}
					else
					{
						gClass = GClass144.smethod_14(num10);
						if ((GClass20.smethod_27(gClass.int_4, gClass.int_5) & 2) == 2)
							gClass.method_69(GClass144.gclass39_0[num11], 0);
						else
						{
							gClass.method_69(GClass144.gclass39_0[num11], 1);
							gClass.int_109 = 20;
						}
					}
					sbyte b8 = msg.method_1().method_2();
					GClass50.smethod_8("npc size= " + b8);
					for (int num12 = 0; num12 < b8; num12++)
					{
						sbyte index = msg.method_1().method_2();
						sbyte int_ = msg.method_1().method_2();
						GClass50.smethod_8("index= " + index);
						if (num11 >= 42 && num11 <= 48)
						{
							((GClass194)GClass144.gclass88_9.method_3(index)).bool_2 = true;
							((GClass194)GClass144.gclass88_9.method_3(index)).int_4 = int_;
							((GClass194)GClass144.gclass88_9.method_3(index)).long_1 = (((GClass194)GClass144.gclass88_9.method_3(index)).long_2 = GClass203.smethod_18());
						}
					}
					sbyte b9 = msg.method_1().method_2();
					for (int num13 = 0; num13 < b9; num13++)
					{
						int num14 = msg.method_1().method_8();
						sbyte b10 = msg.method_1().method_2();
						GClass50.smethod_8("player ID= " + num14 + " my ID= " + GClass78.smethod_1().int_13);
						if (num11 < 42 || num11 > 48)
							continue;
						if (num14 != GClass78.smethod_1().int_13)
						{
							gClass = GClass144.smethod_14(num14);
							if (gClass != null && !gClass.bool_46 && !gClass.bool_47)
							{
								gClass.bool_22 = true;
								gClass.int_79 = b10;
								gClass.int_80 = b10;
								gClass.long_9 = (GClass144.smethod_14(num14).long_10 = GClass203.smethod_18());
							}
						}
						else if (!GClass78.smethod_1().bool_46 && !GClass78.smethod_1().bool_47)
						{
							GClass144.smethod_8().bool_61 = true;
							GClass78.smethod_1().bool_22 = true;
							GClass78.smethod_1().int_80 = b10;
							GClass78.smethod_1().long_9 = (GClass78.smethod_1().long_10 = GClass203.smethod_18());
							GClass78.smethod_1().bool_36 = true;
						}
					}
				}
				if (b7 == 1 && num10 != GClass78.smethod_1().int_13)
					GClass144.smethod_14(num10).bool_23 = true;
				if (b7 == 3)
				{
					if (num10 != GClass78.smethod_1().int_13)
						GClass144.smethod_14(num10).bool_23 = false;
					else
					{
						GClass78.smethod_1().bool_23 = false;
						GClass109.smethod_1().method_45();
						GClass78.smethod_1().method_28();
					}
				}
				if (b7 == 4)
				{
					if (num10 == GClass78.smethod_1().int_13)
					{
						GClass78.smethod_1().int_79 = msg.method_1().method_6() - 1000;
						GClass78.smethod_1().long_7 = GClass203.smethod_18();
						GClass50.smethod_8("second= " + GClass78.smethod_1().int_79 + " last= " + GClass78.smethod_1().long_7);
					}
					else if (GClass144.smethod_14(num10) != null)
					{
						int int_2 = GClass144.smethod_14(num10).int_14;
						if (int_2 == 0)
							GClass144.smethod_14(num10).method_73(false);
						else if (int_2 == 1)
						{
							GClass144.smethod_14(num10).method_73(true);
						}
						GClass144.smethod_14(num10).int_71 = num11;
						GClass144.smethod_14(num10).bool_45 = true;
						GClass144.smethod_14(num10).int_79 = msg.method_1().method_6();
						GClass144.smethod_14(num10).long_7 = GClass203.smethod_18();
					}
				}
				if (b7 == 5)
				{
					if (num10 != GClass78.smethod_1().int_13)
					{
						if (GClass144.smethod_14(num10) != null)
							GClass144.smethod_14(num10).method_72();
					}
					else
						GClass78.smethod_1().method_72();
				}
				if (b7 == 6)
				{
					if (num10 == GClass78.smethod_1().int_13)
						GClass78.smethod_1().method_74(GClass144.gclass39_0[num11], 0);
					else if (GClass144.smethod_14(num10) != null)
					{
						GClass144.smethod_14(num10).method_74(GClass144.gclass39_0[num11], 0);
						GClass109.smethod_1().method_8();
					}
				}
				if (b7 == 7)
				{
					if (num10 == GClass78.smethod_1().int_13)
					{
						GClass78.smethod_1().int_79 = msg.method_1().method_6();
						GClass50.smethod_8("second = " + GClass78.smethod_1().int_79);
						GClass78.smethod_1().long_7 = GClass203.smethod_18();
					}
					else if (GClass144.smethod_14(num10) != null)
					{
						GClass144.smethod_14(num10).method_73(true);
						GClass144.smethod_14(num10).int_79 = msg.method_1().method_6();
						GClass144.smethod_14(num10).long_7 = GClass203.smethod_18();
						GClass109.smethod_1().method_8();
					}
				}
				if (b7 == 8 && num10 != GClass78.smethod_1().int_13 && GClass144.smethod_14(num10) != null)
					GClass144.smethod_14(num10).method_74(GClass144.gclass39_0[num11], 0);
				break;
			}
			case -44:
			{
				bool flag8 = false;
				if (GClass73.int_10 > 2 * GClass76.int_55)
					flag8 = true;
				sbyte b40 = msg.method_1().method_2();
				int num121 = msg.method_1().method_5();
				GClass78.smethod_1().gclass128_3 = new GClass128[num121][];
				GClass73.gclass76_0.string_10 = new string[num121 + ((!flag8) ? 1 : 0)][];
				for (int num122 = 0; num122 < GClass73.gclass76_0.string_10.Length; num122++)
				{
					GClass73.gclass76_0.string_10[num122] = new string[2];
				}
				if (b40 == 2)
				{
					GClass73.gclass76_0.int_37 = new int[num121];
					GClass73.gclass76_0.int_38 = new int[num121];
				}
				if (!flag8)
					GClass73.gclass76_0.string_10[num121] = mResources.inventory;
				for (int num123 = 0; num123 < num121; num123++)
				{
					string[] array9 = GClass50.smethod_30(msg.method_1().method_14(), "\n", 0);
					if (b40 == 2)
						GClass73.gclass76_0.int_37[num123] = msg.method_1().method_5();
					if (array9.Length == 2)
						GClass73.gclass76_0.string_10[num123] = array9;
					if (array9.Length == 1)
					{
						GClass73.gclass76_0.string_10[num123][0] = array9[0];
						GClass73.gclass76_0.string_10[num123][1] = "";
					}
					int num124 = msg.method_1().method_5();
					GClass78.smethod_1().gclass128_3[num123] = new GClass128[num124];
					GClass76.string_26 = mResources.say_wat_do_u_want_to_buy;
					if (b40 == 1)
						GClass76.string_26 = mResources.say_wat_do_u_want_to_buy2;
					for (int num125 = 0; num125 < num124; num125++)
					{
						short num126 = msg.method_1().method_6();
						if (num126 == -1)
							continue;
						GClass78.smethod_1().gclass128_3[num123][num125] = new GClass128();
						GClass78.smethod_1().gclass128_3[num123][num125].gclass117_0 = GClass0.smethod_1(num126);
						GClass50.smethod_8("name " + num123 + " = " + GClass78.smethod_1().gclass128_3[num123][num125].gclass117_0.string_0 + " id templat= " + GClass78.smethod_1().gclass128_3[num123][num125].gclass117_0.short_0);
						if (b40 != 8)
						{
							if (b40 == 4)
								GClass78.smethod_1().gclass128_3[num123][num125].string_2 = msg.method_1().method_14();
							else if (b40 == 0)
							{
								GClass78.smethod_1().gclass128_3[num123][num125].int_34 = msg.method_1().method_8();
								GClass78.smethod_1().gclass128_3[num123][num125].int_36 = msg.method_1().method_8();
							}
							else if (b40 == 1)
							{
								GClass78.smethod_1().gclass128_3[num123][num125].long_0 = msg.method_1().method_9();
							}
							else if (b40 == 2)
							{
								GClass78.smethod_1().gclass128_3[num123][num125].int_27 = msg.method_1().method_6();
								GClass78.smethod_1().gclass128_3[num123][num125].int_34 = msg.method_1().method_8();
								GClass78.smethod_1().gclass128_3[num123][num125].int_36 = msg.method_1().method_8();
								GClass78.smethod_1().gclass128_3[num123][num125].sbyte_32 = msg.method_1().method_2();
								GClass78.smethod_1().gclass128_3[num123][num125].int_30 = msg.method_1().method_8();
								GClass78.smethod_1().gclass128_3[num123][num125].sbyte_33 = msg.method_1().method_2();
							}
							else if (b40 == 3)
							{
								GClass78.smethod_1().gclass128_3[num123][num125].bool_3 = true;
								GClass78.smethod_1().gclass128_3[num123][num125].short_0 = msg.method_1().method_6();
								GClass78.smethod_1().gclass128_3[num123][num125].int_39 = msg.method_1().method_8();
							}
						}
						else
						{
							GClass78.smethod_1().gclass128_3[num123][num125].int_34 = msg.method_1().method_8();
							GClass78.smethod_1().gclass128_3[num123][num125].int_36 = msg.method_1().method_8();
							GClass78.smethod_1().gclass128_3[num123][num125].int_30 = msg.method_1().method_8();
						}
						int num127 = msg.method_1().method_5();
						if (num127 != 0)
						{
							GClass78.smethod_1().gclass128_3[num123][num125].gclass120_0 = new GClass120[num127];
							for (int num128 = 0; num128 < GClass78.smethod_1().gclass128_3[num123][num125].gclass120_0.Length; num128++)
							{
								int optionTemplateId6 = msg.method_1().method_5();
								int param6 = msg.method_1().method_7();
								GClass78.smethod_1().gclass128_3[num123][num125].gclass120_0[num128] = new GClass120(optionTemplateId6, param6);
								GClass78.smethod_1().gclass128_3[num123][num125].int_43 = GClass73.gclass76_0.method_131(GClass78.smethod_1().gclass128_3[num123][num125]);
							}
						}
						sbyte b41 = msg.method_1().method_2();
						GClass78.smethod_1().gclass128_3[num123][num125].bool_4 = ((b41 != 0) ? true : false);
						if (msg.method_1().method_2() == 1)
						{
							int headTemp = msg.method_1().method_6();
							int bodyTemp = msg.method_1().method_6();
							int legTemp = msg.method_1().method_6();
							int bagTemp = msg.method_1().method_6();
							GClass78.smethod_1().gclass128_3[num123][num125].method_25(headTemp, bodyTemp, legTemp, bagTemp);
						}
						if (b40 == 2 && GClass187.int_3 >= 237)
						{
							GClass78.smethod_1().gclass128_3[num123][num125].string_3 = msg.method_1().method_14();
							GClass50.smethod_10("nguoi ki gui  " + GClass78.smethod_1().gclass128_3[num123][num125].string_3);
						}
					}
				}
				if (flag8)
				{
					if (b40 == 2)
					{
						GClass73.gclass76_1 = new GClass76();
						GClass73.gclass76_1.method_10();
						GClass73.gclass76_1.method_50();
					}
					else
					{
						GClass73.gclass76_1 = new GClass76();
						GClass73.gclass76_1.string_17[7] = new string[1][] { new string[1] { "" } };
						GClass73.gclass76_1.method_15();
						GClass73.gclass76_1.method_50();
					}
				}
				GClass73.gclass76_0.string_17[1] = GClass73.gclass76_0.string_10;
				if (b40 == 2)
				{
					string[][] array10 = GClass73.gclass76_0.string_17[1];
					if (!flag8)
						GClass73.gclass76_0.string_17[1] = new string[5][]
						{
							array10[0],
							array10[1],
							array10[2],
							array10[3],
							array10[4]
						};
					else
						GClass73.gclass76_0.string_17[1] = new string[4][]
						{
							array10[0],
							array10[1],
							array10[2],
							array10[3]
						};
				}
				GClass73.gclass76_0.method_33(b40);
				GClass73.gclass76_0.method_50();
				break;
			}
			case -43:
			{
				sbyte itemAction = msg.method_1().method_2();
				sbyte where = msg.method_1().method_2();
				sbyte index3 = msg.method_1().method_2();
				string info3 = msg.method_1().method_14();
				GClass73.gclass76_0.method_193(itemAction, info3, where, index3);
				break;
			}
			case -42:
				GClass78.smethod_1().int_155 = msg.method_3();
				GClass78.smethod_1().int_156 = msg.method_3();
				GClass78.smethod_1().int_154 = msg.method_1().method_8();
				GClass78.smethod_1().int_35 = msg.method_3();
				GClass78.smethod_1().int_36 = msg.method_3();
				GClass78.smethod_1().int_25 = msg.method_3();
				GClass78.smethod_1().int_24 = msg.method_3();
				GClass78.smethod_1().int_18 = msg.method_1().method_2();
				GClass78.smethod_1().sbyte_30 = msg.method_1().method_2();
				GClass78.smethod_1().sbyte_31 = msg.method_1().method_2();
				GClass78.smethod_1().sbyte_32 = msg.method_1().method_2();
				GClass78.smethod_1().int_20 = msg.method_1().method_8();
				GClass78.smethod_1().int_21 = msg.method_1().method_8();
				GClass78.smethod_1().int_22 = msg.method_1().method_2();
				GClass78.smethod_1().long_4 = msg.method_1().method_9();
				GClass78.smethod_1().short_25 = msg.method_1().method_6();
				GClass78.smethod_1().int_157 = msg.method_1().method_6();
				GClass78.smethod_1().int_158 = msg.method_1().method_2();
				GClass130.smethod_5();
				break;
			case -41:
			{
				sbyte b37 = msg.method_1().method_2();
				GClass78.smethod_1().string_5 = new string[b37];
				for (int num107 = 0; num107 < b37; num107++)
				{
					string text5 = msg.method_1().method_14();
					GClass78.smethod_1().string_5[num107] = text5;
				}
				GClass50.smethod_8("---   xong  level caption cmd : " + msg.sbyte_0);
				break;
			}
			case -37:
			{
				sbyte b36 = msg.method_1().method_2();
				GClass50.smethod_8("cAction= " + b36);
				if (b36 != 0)
					break;
				GClass78.smethod_1().int_119 = msg.method_1().method_6();
				GClass78.smethod_1().method_61();
				int num100 = msg.method_1().method_5();
				GClass50.smethod_8("num body = " + num100);
				GClass78.smethod_1().gclass128_2 = new GClass128[num100];
				for (int num101 = 0; num101 < num100; num101++)
				{
					short num102 = msg.method_1().method_6();
					if (num102 == -1)
						continue;
					GClass78.smethod_1().gclass128_2[num101] = new GClass128();
					GClass78.smethod_1().gclass128_2[num101].gclass117_0 = GClass0.smethod_1(num102);
					int num103 = GClass78.smethod_1().gclass128_2[num101].gclass117_0.sbyte_0;
					GClass78.smethod_1().gclass128_2[num101].int_30 = msg.method_1().method_8();
					GClass78.smethod_1().gclass128_2[num101].string_0 = msg.method_1().method_14();
					GClass78.smethod_1().gclass128_2[num101].string_1 = msg.method_1().method_14();
					int num104 = msg.method_1().method_5();
					if (num104 != 0)
					{
						GClass78.smethod_1().gclass128_2[num101].gclass120_0 = new GClass120[num104];
						for (int num105 = 0; num105 < GClass78.smethod_1().gclass128_2[num101].gclass120_0.Length; num105++)
						{
							int optionTemplateId4 = msg.method_1().method_5();
							int param4 = msg.method_1().method_7();
							GClass78.smethod_1().gclass128_2[num101].gclass120_0[num105] = new GClass120(optionTemplateId4, param4);
						}
					}
					int num106 = num103;
					if (num106 == 0)
						GClass78.smethod_1().int_121 = GClass78.smethod_1().gclass128_2[num101].gclass117_0.short_2;
					else if (num106 == 1)
					{
						GClass78.smethod_1().int_120 = GClass78.smethod_1().gclass128_2[num101].gclass117_0.short_2;
					}
				}
				break;
			}
			case -36:
			{
				sbyte b23 = msg.method_1().method_2();
				GClass50.smethod_8("cAction= " + b23);
				if (b23 == 0)
				{
					int num58 = msg.method_1().method_5();
					GClass78.smethod_1().gclass128_0 = new GClass128[num58];
					GClass144.int_37 = 0;
					GClass50.smethod_8("numC=" + num58);
					for (int num59 = 0; num59 < num58; num59++)
					{
						short num60 = msg.method_1().method_6();
						if (num60 == -1)
							continue;
						GClass78.smethod_1().gclass128_0[num59] = new GClass128();
						GClass78.smethod_1().gclass128_0[num59].gclass117_0 = GClass0.smethod_1(num60);
						GClass78.smethod_1().gclass128_0[num59].int_30 = msg.method_1().method_8();
						GClass78.smethod_1().gclass128_0[num59].string_0 = msg.method_1().method_14();
						GClass78.smethod_1().gclass128_0[num59].string_1 = msg.method_1().method_14();
						GClass78.smethod_1().gclass128_0[num59].int_29 = num59;
						int num61 = msg.method_1().method_5();
						if (num61 != 0)
						{
							GClass78.smethod_1().gclass128_0[num59].gclass120_0 = new GClass120[num61];
							for (int num62 = 0; num62 < GClass78.smethod_1().gclass128_0[num59].gclass120_0.Length; num62++)
							{
								int optionTemplateId3 = msg.method_1().method_5();
								int param3 = msg.method_1().method_7();
								GClass78.smethod_1().gclass128_0[num59].gclass120_0[num62] = new GClass120(optionTemplateId3, param3);
							}
							GClass78.smethod_1().gclass128_0[num59].int_43 = GClass73.gclass76_0.method_131(GClass78.smethod_1().gclass128_0[num59]);
						}
						if (GClass78.smethod_1().gclass128_0[num59].gclass117_0.sbyte_0 == 11)
							;
						if (GClass78.smethod_1().gclass128_0[num59].gclass117_0.sbyte_0 == 6)
							GClass144.int_37 += GClass78.smethod_1().gclass128_0[num59].int_30;
					}
				}
				if (b23 == 2)
				{
					sbyte b24 = msg.method_1().method_2();
					int int_8 = msg.method_1().method_8();
					int int_9 = GClass78.smethod_1().gclass128_0[b24].int_30;
					GClass78.smethod_1().gclass128_0[b24].int_30 = int_8;
					if (GClass78.smethod_1().gclass128_0[b24].int_30 < int_9 && GClass78.smethod_1().gclass128_0[b24].gclass117_0.sbyte_0 == 6)
						GClass144.int_37 -= int_9 - GClass78.smethod_1().gclass128_0[b24].int_30;
					if (GClass78.smethod_1().gclass128_0[b24].int_30 == 0)
						GClass78.smethod_1().gclass128_0[b24] = null;
				}
				break;
			}
			case -35:
			{
				sbyte b17 = msg.method_1().method_2();
				GClass50.smethod_8("cAction= " + b17);
				if (b17 == 0)
				{
					int num32 = msg.method_1().method_5();
					GClass78.smethod_1().gclass128_1 = new GClass128[num32];
					GClass73.gclass76_0.int_39 = 0;
					for (int num33 = 0; num33 < num32; num33++)
					{
						short num34 = msg.method_1().method_6();
						if (num34 == -1)
							continue;
						GClass78.smethod_1().gclass128_1[num33] = new GClass128();
						GClass78.smethod_1().gclass128_1[num33].gclass117_0 = GClass0.smethod_1(num34);
						GClass78.smethod_1().gclass128_1[num33].int_30 = msg.method_1().method_8();
						GClass78.smethod_1().gclass128_1[num33].string_0 = msg.method_1().method_14();
						GClass78.smethod_1().gclass128_1[num33].string_1 = msg.method_1().method_14();
						int num35 = msg.method_1().method_5();
						if (num35 != 0)
						{
							GClass78.smethod_1().gclass128_1[num33].gclass120_0 = new GClass120[num35];
							for (int num36 = 0; num36 < GClass78.smethod_1().gclass128_1[num33].gclass120_0.Length; num36++)
							{
								int optionTemplateId2 = msg.method_1().method_5();
								int param2 = msg.method_1().method_7();
								GClass78.smethod_1().gclass128_1[num33].gclass120_0[num36] = new GClass120(optionTemplateId2, param2);
							}
						}
						GClass73.gclass76_0.int_39++;
					}
				}
				if (b17 == 1)
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
					GClass73.gclass76_0.method_34();
					GClass73.gclass76_0.bool_8 = bool_;
					GClass73.gclass76_0.method_50();
				}
				if (b17 == 2)
				{
					sbyte b18 = msg.method_1().method_2();
					int int_6 = msg.method_1().method_8();
					GClass78.smethod_1().gclass128_1[b18].int_30 = int_6;
					if (GClass78.smethod_1().gclass128_1[b18].int_30 == 0)
						GClass78.smethod_1().gclass128_1[b18] = null;
				}
				break;
			}
			case -34:
			{
				sbyte b3 = msg.method_1().method_2();
				GClass50.smethod_8("act= " + b3);
				if (b3 == 0 && GClass144.smethod_8().gclass80_0 != null)
				{
					GClass50.smethod_8("toi duoc day");
					GClass80 gclass80_ = GClass144.smethod_8().gclass80_0;
					gclass80_.int_192 = msg.method_1().method_6();
					gclass80_.string_16 = msg.method_1().method_14();
					gclass80_.string_16 = GClass50.smethod_15(gclass80_.string_16);
					gclass80_.int_194 = msg.method_1().method_6();
					gclass80_.int_195 = msg.method_1().method_6();
					gclass80_.int_193 = msg.method_1().method_2();
					gclass80_.int_196 = msg.method_1().method_6();
					gclass80_.int_198 = msg.method_1().method_6();
					GClass50.smethod_8("curr Peas= " + gclass80_.int_196);
					gclass80_.string_15 = msg.method_1().method_14();
					gclass80_.int_203 = msg.method_1().method_8();
					gclass80_.int_199 = gclass80_.int_203;
					sbyte b4 = msg.method_1().method_2();
					gclass80_.int_200 = new int[b4];
					gclass80_.int_201 = new int[b4];
					for (int i = 0; i < b4; i++)
					{
						gclass80_.int_200[i] = msg.method_1().method_2();
						gclass80_.int_201[i] = msg.method_1().method_2();
					}
					gclass80_.bool_83 = msg.method_1().method_10();
					gclass80_.long_20 = (gclass80_.long_21 = GClass203.smethod_18());
					GClass144.smethod_8().gclass80_0.bool_84 = true;
				}
				if (b3 == 1)
				{
					gClass3 = new GClass88();
					try
					{
						while (msg.method_1().method_18() > 0)
						{
							gClass3.method_0(new GClass87(msg.method_1().method_14(), GClass73.gclass73_0, 888392, null));
						}
					}
					catch (Exception ex)
					{
						GClass36.smethod_0("Loi MAGIC_TREE " + ex.ToString());
					}
					GClass73.gclass145_0.method_2(gClass3, 3);
				}
				if (b3 == 2)
				{
					GClass144.smethod_8().gclass80_0.int_197 = msg.method_1().method_6();
					GClass144.smethod_8().gclass80_0.int_203 = msg.method_1().method_8();
					GClass144.smethod_8().gclass80_0.long_20 = (GClass144.smethod_8().gclass80_0.long_21 = GClass203.smethod_18());
					GClass144.smethod_8().gclass80_0.bool_84 = true;
					GClass144.smethod_8().gclass80_0.bool_86 = true;
				}
				break;
			}
			case -32:
			{
				short id4 = msg.method_1().method_6();
				int num167 = msg.method_1().method_8();
				sbyte[] array18 = null;
				GClass70 gClass53 = null;
				try
				{
					array18 = new sbyte[num167];
					for (int num168 = 0; num168 < num167; num168++)
					{
						array18[num168] = msg.method_1().method_2();
					}
					gClass53 = GClass70.smethod_6(array18, 0, num167);
					GClass10.gclass113_0.method_4(id4 + "", gClass53);
				}
				catch (Exception)
				{
					array18 = null;
					GClass10.gclass113_0.method_4(id4 + "", GClass70.smethod_9(new int[1], 1, 1, true));
				}
				if (array18 != null)
				{
					if (GClass122.int_12 > 1)
						GClass1.smethod_0(GClass122.int_12 + "bgItem" + id4, array18);
					GClass129.smethod_2(id4, gClass53);
				}
				break;
			}
			case -31:
			{
				GClass20.gclass88_1.method_9();
				short num160 = msg.method_1().method_6();
				GClass50.smethod_10("[ITEM_BACKGROUND] nItem= " + num160);
				for (int num161 = 0; num161 < num160; num161++)
				{
					GClass10 gClass48 = new GClass10();
					gClass48.int_0 = num161;
					gClass48.short_0 = msg.method_1().method_6();
					gClass48.sbyte_0 = msg.method_1().method_2();
					gClass48.int_4 = msg.method_1().method_6();
					gClass48.int_5 = msg.method_1().method_6();
					sbyte b53 = msg.method_1().method_2();
					gClass48.int_7 = new int[b53];
					gClass48.int_8 = new int[b53];
					for (int num162 = 0; num162 < b53; num162++)
					{
						gClass48.int_7[num161] = msg.method_1().method_2();
						gClass48.int_8[num161] = msg.method_1().method_2();
					}
					GClass20.gclass88_1.method_0(gClass48);
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
				GClass134.int_22 = 2;
				GClass73.smethod_8("SA2", 2);
				GClass73.smethod_30(msg.method_1().method_14());
				GClass130.smethod_5();
				GClass133.bool_0 = false;
				GClass78.bool_35 = false;
				if (GClass73.gclass131_0 == GClass73.gclass133_0)
					GClass73.gclass134_0.switchToMe();
				break;
			case -25:
				GClass73.smethod_8("SA3", 2);
				GClass144.gclass52_0.method_7(msg.method_1().method_14(), 0);
				break;
			case -24:
				if (!(GClass73.gclass131_0 is GClass144))
					GClass73.long_6 = GClass203.smethod_18() + 30000L;
				else
					GClass73.long_6 = GClass203.smethod_18() + 3000L;
				GClass78.bool_35 = true;
				GClass36.smethod_0("GET MAP INFO");
				GClass144.smethod_8().gclass80_0 = null;
				GClass73.bool_4 = true;
				GClass73.smethod_8("SA75", 2);
				GClass144.smethod_5();
				GClass73.smethod_29();
				GClass20.gclass88_0.method_9();
				GClass45.gclass88_0.method_9();
				GClass203.smethod_26();
				GClass20.int_37 = msg.method_1().method_5();
				GClass20.sbyte_2 = msg.method_1().method_2();
				GClass20.int_25 = msg.method_1().method_2();
				GClass20.int_40 = msg.method_1().method_2();
				GClass36.smethod_0("load planet from server: " + GClass20.sbyte_2 + "bgType= " + GClass20.int_41 + ".............................");
				GClass20.int_43 = msg.method_1().method_2();
				GClass20.string_1 = msg.method_1().method_14();
				GClass20.int_39 = msg.method_1().method_2();
				GClass73.smethod_8("SA75x1", 2);
				try
				{
					GClass20.smethod_24(GClass20.int_37);
				}
				catch (Exception)
				{
					GClass7.smethod_0().method_92(GClass20.int_37);
					gclass208_0 = msg;
					return;
				}
				method_10(msg);
				try
				{
					GClass20.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
				}
				catch (Exception)
				{
				}
				GClass144.int_22 = GClass144.int_28;
				GClass144.int_23 = GClass144.int_29;
				break;
			case -22:
				GClass73.smethod_8("SA65", 2);
				GClass78.bool_34 = true;
				GClass78.bool_33 = true;
				GClass144.smethod_8().int_78 = 0;
				GClass144.smethod_8().int_77 = 0;
				GClass78.smethod_1().gclass194_0 = null;
				GClass78.smethod_1().gclass79_0 = null;
				GClass78.smethod_1().gclass78_0 = null;
				GClass78.smethod_1().gclass64_0 = null;
				GClass78.smethod_1().gclass88_3.method_9();
				GClass78.smethod_1().int_73 = -9999;
				GClass78.smethod_1().int_74 = -9999;
				GClass73.smethod_19();
				GClass144.smethod_8().method_34();
				GClass144.smethod_8().gclass87_1 = null;
				break;
			case -21:
			{
				GClass73.smethod_8("SA60", 2);
				short num144 = msg.method_1().method_6();
				for (int num145 = 0; num145 < GClass144.gclass88_6.method_2(); num145++)
				{
					if (((GClass64)GClass144.gclass88_6.method_3(num145)).int_9 == num144)
					{
						GClass144.gclass88_6.method_7(num145);
						break;
					}
				}
				break;
			}
			case -20:
			{
				GClass73.smethod_8("SA61", 2);
				GClass78.smethod_1().gclass64_0 = null;
				short num132 = msg.method_1().method_6();
				for (int num133 = 0; num133 < GClass144.gclass88_6.method_2(); num133++)
				{
					GClass64 gClass39 = (GClass64)GClass144.gclass88_6.method_3(num133);
					if (gClass39.int_9 != num132)
						continue;
					gClass39.method_0(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - 10);
					string text6 = msg.method_1().method_14();
					num = 0;
					try
					{
						num = msg.method_1().method_6();
						if (gClass39.gclass117_0.sbyte_0 == 9)
						{
							num = msg.method_1().method_6();
							GClass78.smethod_1().long_6 += num;
							GClass78.smethod_1().string_0 = GClass203.smethod_6(GClass78.smethod_1().long_6);
						}
						else if (gClass39.gclass117_0.sbyte_0 == 10)
						{
							num = msg.method_1().method_6();
							GClass78.smethod_1().int_68 += num;
							GClass78.smethod_1().string_1 = GClass203.smethod_6(GClass78.smethod_1().int_68);
						}
						else if (gClass39.gclass117_0.sbyte_0 == 34)
						{
							num = msg.method_1().method_6();
							GClass78.smethod_1().int_69 += num;
							GClass78.smethod_1().string_2 = GClass203.smethod_6(GClass78.smethod_1().int_69);
						}
					}
					catch (Exception)
					{
					}
					if (text6.Equals(""))
					{
						if (gClass39.gclass117_0.sbyte_0 != 9)
						{
							if (gClass39.gclass117_0.sbyte_0 == 10)
							{
								GClass144.smethod_19(((num >= 0) ? "+" : "") + num, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58, 0, -2, GClass4.int_5);
								GClass109.smethod_1().method_9();
							}
							else if (gClass39.gclass117_0.sbyte_0 == 34)
							{
								GClass144.smethod_19(((num >= 0) ? "+" : "") + num, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58, 0, -2, GClass4.int_3);
								GClass109.smethod_1().method_9();
							}
							else
							{
								GClass144.gclass52_0.method_7(mResources.you_receive + " " + ((num <= 0) ? "" : (num + " ")) + gClass39.gclass117_0.string_0, 0);
								GClass109.smethod_1().method_9();
							}
						}
						else
						{
							GClass144.smethod_19(((num >= 0) ? "+" : "") + num, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58, 0, -2, GClass4.int_4);
							GClass109.smethod_1().method_9();
						}
						if (num > 0 && GClass78.smethod_1().gclass82_0 != null && GClass78.smethod_1().gclass82_0.short_0 == 4683)
						{
							GClass97.smethod_0(55, GClass78.smethod_1().gclass82_0.int_9, GClass78.smethod_1().gclass82_0.int_4, 1);
							GClass97.smethod_0(55, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, 1);
						}
					}
					else if (text6.Length != 1)
					{
						GClass144.gclass52_0.method_7(text6, 0);
					}
					else
					{
						GClass36.smethod_4("strInf.Length =1:  " + text6);
					}
					break;
				}
				break;
			}
			case -19:
			{
				GClass73.smethod_8("SA62", 2);
				short num134 = msg.method_1().method_6();
				gClass = GClass144.smethod_14(msg.method_1().method_8());
				for (int num135 = 0; num135 < GClass144.gclass88_6.method_2(); num135++)
				{
					GClass64 gClass40 = (GClass64)GClass144.gclass88_6.method_3(num135);
					if (gClass40.int_9 != num134)
						continue;
					if (gClass != null)
					{
						gClass40.method_0(gClass.int_4, gClass.int_5 - 10);
						if (gClass40.int_1 < gClass.int_4)
							gClass.int_12 = -1;
						else if (gClass40.int_1 > gClass.int_4)
						{
							gClass.int_12 = 1;
						}
						break;
					}
					return;
				}
				break;
			}
			case -18:
			{
				GClass73.smethod_8("SA63", 2);
				int num130 = msg.method_1().method_2();
				GClass144.gclass88_6.method_0(new GClass64(msg.method_1().method_6(), GClass78.smethod_1().gclass128_0[num130].gclass117_0.short_0, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, msg.method_1().method_6(), msg.method_1().method_6()));
				GClass78.smethod_1().gclass128_0[num130] = null;
				break;
			}
			case -14:
				GClass73.smethod_8("SA64", 2);
				gClass = GClass144.smethod_14(msg.method_1().method_8());
				if (gClass != null)
				{
					GClass144.gclass88_6.method_0(new GClass64(msg.method_1().method_6(), msg.method_1().method_6(), gClass.int_4, gClass.int_5, msg.method_1().method_6(), msg.method_1().method_6()));
					break;
				}
				return;
			case -4:
			{
				GClass73.smethod_8("SA76", 2);
				gClass = GClass144.smethod_14(msg.method_1().method_8());
				if (gClass == null)
					return;
				GClass73.smethod_8("SA76v1", 2);
				if ((GClass20.smethod_27(gClass.int_4, gClass.int_5) & 2) == 2)
					gClass.method_69(GClass144.gclass39_0[msg.method_1().method_5()], 0);
				else
					gClass.method_69(GClass144.gclass39_0[msg.method_1().method_5()], 1);
				GClass73.smethod_8("SA76v2", 2);
				gClass.gclass194_2 = new GClass194[msg.method_1().method_2()];
				for (int num98 = 0; num98 < gClass.gclass194_2.Length; num98++)
				{
					GClass194 gClass33 = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_2());
					gClass.gclass194_2[num98] = gClass33;
					if (num98 == 0)
					{
						if (gClass.int_4 <= gClass33.int_8)
							gClass.int_12 = 1;
						else
							gClass.int_12 = -1;
					}
				}
				GClass73.smethod_8("SA76v3", 2);
				gClass.gclass78_0 = null;
				gClass.gclass194_0 = gClass.gclass194_2[0];
				GClass78[] array8 = new GClass78[10];
				num = 0;
				try
				{
					for (num = 0; num < array8.Length; num++)
					{
						int num99 = msg.method_1().method_8();
						GClass78 gClass34 = (array8[num] = ((num99 != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num99) : GClass78.smethod_1()));
						if (num == 0)
						{
							if (gClass.int_4 > gClass34.int_4)
								gClass.int_12 = -1;
							else
								gClass.int_12 = 1;
						}
					}
				}
				catch (Exception ex14)
				{
					GClass36.smethod_0("Loi PLAYER_ATTACK_N_P " + ex14.ToString());
				}
				GClass73.smethod_8("SA76v4", 2);
				if (num > 0)
				{
					gClass.gclass78_1 = new GClass78[num];
					for (num = 0; num < gClass.gclass78_1.Length; num++)
					{
						gClass.gclass78_1[num] = array8[num];
					}
					gClass.gclass78_0 = gClass.gclass78_1[0];
					gClass.gclass194_0 = null;
				}
				GClass73.smethod_8("SA76v5", 2);
				break;
			}
			case 0:
				method_1(msg);
				break;
			case 1:
			{
				bool flag5 = msg.method_1().method_10();
				GClass50.smethod_8("isRes= " + flag5);
				if (!flag5)
				{
					GClass73.smethod_30(msg.method_1().method_14());
					break;
				}
				GClass73.gclass133_0.bool_12 = false;
				GClass1.smethod_4("userAo" + GClass134.int_14, "");
				GClass73.smethod_29();
				GClass73.gclass133_0.method_9();
				break;
			}
			case 2:
				GClass78.bool_35 = false;
				GClass133.bool_13 = false;
				if (!GClass144.bool_2)
					GClass144.smethod_8().method_0();
				GClass10.smethod_0();
				GClass73.smethod_29();
				GClass140.bool_0 = true;
				GClass140.smethod_2().switchToMe();
				break;
			case 6:
				GClass73.smethod_8("SA70", 2);
				GClass78.smethod_1().long_6 = msg.method_1().method_9();
				GClass78.smethod_1().int_68 = msg.method_1().method_8();
				GClass78.smethod_1().int_69 = msg.method_1().method_8();
				GClass78.smethod_1().string_0 = GClass203.smethod_6(GClass78.smethod_1().long_6);
				GClass78.smethod_1().string_1 = GClass203.smethod_6(GClass78.smethod_1().int_68);
				GClass78.smethod_1().string_2 = GClass203.smethod_6(GClass78.smethod_1().int_69);
				GClass73.smethod_29();
				break;
			case 7:
			{
				sbyte type = msg.method_1().method_2();
				short id3 = msg.method_1().method_6();
				string info2 = msg.method_1().method_14();
				GClass73.gclass76_0.method_194(type, info2, id3);
				break;
			}
			case 11:
			{
				GClass73.smethod_8("SA9", 2);
				int num55 = msg.method_1().method_2();
				sbyte b22 = msg.method_1().method_2();
				if (b22 != 0)
					GClass194.gclass177_0[num55].gclass72_0.method_8(GClass65.smethod_2(msg), b22);
				else
					GClass194.gclass177_0[num55].gclass72_0.method_7(GClass65.smethod_2(msg));
				for (int num56 = 0; num56 < GClass144.gclass88_9.method_2(); num56++)
				{
					gClass2 = (GClass194)GClass144.gclass88_9.method_3(num56);
					if (gClass2.int_26 == num55)
					{
						gClass2.int_20 = GClass194.gclass177_0[num55].gclass72_0.int_2;
						gClass2.int_21 = GClass194.gclass177_0[num55].gclass72_0.int_3;
					}
				}
				sbyte[] array7 = GClass65.smethod_2(msg);
				GClass70 gclass70_ = GClass70.smethod_6(array7, 0, array7.Length);
				GClass194.gclass177_0[num55].gclass72_0.gclass70_0 = gclass70_;
				int num57 = msg.method_1().method_2();
				GClass194.gclass177_0[num55].gclass72_0.int_1 = num57;
				if (num57 == 1 || num57 == 2)
					method_20(msg, num55);
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
				gClass3 = new GClass88();
				msg.method_1().method_14();
				int num44 = msg.method_1().method_2();
				for (int num45 = 0; num45 < num44; num45++)
				{
					string caption = msg.method_1().method_14();
					short num46 = msg.method_1().method_6();
					gClass3.method_0(new GClass87(caption, GClass73.gclass73_0, 88819, num46));
				}
				GClass73.gclass145_0.method_0(gClass3, 3);
				break;
			}
			case 29:
				GClass73.smethod_8("SA58", 2);
				GClass144.smethod_8().method_110(msg);
				break;
			case 32:
			{
				GClass73.smethod_8("SA68", 2);
				int num16 = msg.method_1().method_6();
				for (int num17 = 0; num17 < GClass144.gclass88_10.method_2(); num17++)
				{
					GClass79 gClass10 = (GClass79)GClass144.gclass88_10.method_3(num17);
					if (gClass10.gclass127_0.int_0 == num16 && gClass10.Equals(GClass78.smethod_1().gclass79_0))
					{
						string chat = msg.method_1().method_14();
						string[] array4 = new string[msg.method_1().method_2()];
						for (int num18 = 0; num18 < array4.Length; num18++)
						{
							array4[num18] = msg.method_1().method_14();
						}
						GClass144.smethod_8().method_18(array4, gClass10);
						GClass96.smethod_4(chat, 100000, gClass10);
						return;
					}
				}
				GClass79 gClass11 = new GClass79(num16, 0, -100, 100, num16, GClass144.gclass52_0.int_0[GClass78.smethod_1().int_14][2]);
				GClass50.smethod_8((GClass78.smethod_1().gclass79_0 != null) ? "!null" : "null");
				string chat2 = msg.method_1().method_14();
				string[] array5 = new string[msg.method_1().method_2()];
				for (int num19 = 0; num19 < array5.Length; num19++)
				{
					array5[num19] = msg.method_1().method_14();
				}
				try
				{
					int num20 = (gClass11.int_70 = msg.method_1().method_6());
				}
				catch (Exception)
				{
				}
				GClass50.smethod_8((GClass78.smethod_1().gclass79_0 == null) ? "null" : "!null");
				GClass144.smethod_8().method_18(array5, gClass11);
				GClass96.smethod_4(chat2, 100000, gClass11);
				break;
			}
			case 33:
				GClass73.smethod_8("SA51", 2);
				GClass130.smethod_5();
				GClass73.smethod_27();
				GClass73.smethod_26();
				gClass3 = new GClass88();
				try
				{
					while (true)
					{
						gClass3.method_0(new GClass87(msg.method_1().method_14(), GClass73.gclass73_0, 88822, null));
					}
				}
				catch (Exception ex2)
				{
					GClass36.smethod_0("Loi OPEN_UI_MENU " + ex2.ToString());
				}
				if (GClass78.smethod_1().gclass79_0 != null)
				{
					for (int j = 0; j < GClass78.smethod_1().gclass79_0.gclass127_0.string_1.Length; j++)
					{
						string[] array = GClass78.smethod_1().gclass79_0.gclass127_0.string_1[j];
						gClass3.method_0(new GClass87(array[0], GClass73.gclass73_0, 88820, array));
					}
					GClass73.gclass145_0.method_2(gClass3, 3);
					break;
				}
				return;
			case 38:
			{
				GClass73.smethod_8("SA67", 2);
				GClass130.smethod_5();
				int num165 = msg.method_1().method_6();
				GClass50.smethod_8("OPEN_UI_SAY ID= " + num165);
				string chat3 = GClass50.smethod_15(msg.method_1().method_14());
				for (int num166 = 0; num166 < GClass144.gclass88_10.method_2(); num166++)
				{
					GClass79 gClass51 = (GClass79)GClass144.gclass88_10.method_3(num166);
					GClass50.smethod_8("npc id= " + gClass51.gclass127_0.int_0);
					if (gClass51.gclass127_0.int_0 == num165)
					{
						GClass96.smethod_2(chat3, 100000, gClass51);
						GClass73.gclass76_0.method_150();
						return;
					}
				}
				GClass79 gClass52 = new GClass79(num165, 0, 0, 0, num165, GClass144.gclass52_0.int_0[GClass78.smethod_1().int_14][2]);
				if (gClass52.gclass127_0.int_0 == 5)
					gClass52.int_13 = 5;
				try
				{
					gClass52.int_70 = msg.method_1().method_6();
				}
				catch (Exception)
				{
				}
				GClass96.smethod_2(chat3, 100000, gClass52);
				GClass73.gclass76_0.method_150();
				break;
			}
			case 39:
				GClass73.smethod_8("SA49", 2);
				GClass144.smethod_8().int_68 = 2;
				if (GClass144.smethod_8().int_67 >= 2 && GClass144.smethod_8().int_68 >= 2)
					GClass130.smethod_1();
				break;
			case 40:
			{
				GClass73.smethod_8("SA52", 2);
				GClass73.int_9 = 150;
				short taskId = msg.method_1().method_6();
				sbyte index4 = msg.method_1().method_2();
				string name = GClass50.smethod_15(msg.method_1().method_14());
				string detail = GClass50.smethod_15(msg.method_1().method_14());
				string[] array14 = new string[msg.method_1().method_2()];
				string[] array15 = new string[array14.Length];
				GClass144.int_75 = new int[array14.Length];
				GClass144.int_76 = new int[array14.Length];
				short[] array16 = new short[array14.Length];
				short count = -1;
				for (int num155 = 0; num155 < array14.Length; num155++)
				{
					string text7 = GClass50.smethod_15(msg.method_1().method_14());
					GClass144.int_75[num155] = msg.method_1().method_2();
					GClass144.int_76[num155] = msg.method_1().method_6();
					string text8 = GClass50.smethod_15(msg.method_1().method_14());
					array16[num155] = -1;
					if (!text7.Equals(""))
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
					GClass36.smethod_0("Loi TASK_GET " + ex23.ToString());
				}
				GClass78.smethod_1().gclass56_0 = new GClass56(taskId, index4, name, detail, array14, array16, count, array15);
				if (GClass78.smethod_1().gclass79_0 != null)
					GClass79.smethod_10();
				GClass78.smethod_0(false);
				break;
			}
			case 41:
				GClass73.smethod_8("SA53", 2);
				GClass73.int_9 = 100;
				GClass50.smethod_8("TASK NEXT");
				GClass78.smethod_1().gclass56_0.int_0++;
				GClass78.smethod_1().gclass56_0.short_2 = 0;
				GClass79.smethod_10();
				GClass78.smethod_0(true);
				break;
			case 43:
				GClass73.int_9 = 50;
				GClass73.smethod_8("SA55", 2);
				GClass78.smethod_1().gclass56_0.short_2 = msg.method_1().method_6();
				if (GClass78.smethod_1().gclass79_0 != null)
					GClass79.smethod_10();
				try
				{
					short short_8 = msg.method_1().method_6();
					short short_9 = msg.method_1().method_6();
					GClass78.smethod_1().short_16 = short_8;
					GClass78.smethod_1().short_17 = short_9;
					GClass50.smethod_8("CMD   TASK_UPDATE:43_mapID =    x|y " + short_8 + "|" + short_9);
					for (int num152 = 0; num152 < GClass20.gclass88_0.method_2(); num152++)
					{
						GClass50.smethod_8("===> " + GClass20.gclass88_0.method_3(num152));
					}
				}
				catch (Exception)
				{
				}
				break;
			case 46:
				GClass73.smethod_8("SA5", 2);
				GClass36.smethod_5("Controler RESET_POINT  " + GClass78.bool_33);
				GClass78.bool_34 = false;
				GClass78.smethod_1().method_29(msg.method_1().method_6(), msg.method_1().method_6());
				break;
			case 47:
				GClass73.smethod_8("SA4", 2);
				GClass144.smethod_8().method_34();
				break;
			case 50:
			{
				sbyte b49 = msg.method_1().method_2();
				GClass76.gclass88_12.method_9();
				for (int num150 = 0; num150 < b49; num150++)
				{
					Class9 @class = new Class9();
					@class.short_0 = msg.method_1().method_6();
					@class.string_0 = msg.method_1().method_14();
					@class.string_1 = msg.method_1().method_14();
					GClass76.gclass88_12.method_0(@class);
					bool flag11 = (@class.bool_0 = ((GClass1.smethod_8(@class.short_0 + "") != -1) ? true : false));
				}
				break;
			}
			case 54:
			{
				gClass = GClass144.smethod_14(msg.method_1().method_8());
				if (gClass == null)
					return;
				int num136 = msg.method_1().method_5();
				if ((GClass20.smethod_27(gClass.int_4, gClass.int_5) & 2) == 2)
					gClass.method_69(GClass144.gclass39_0[num136], 0);
				else
					gClass.method_69(GClass144.gclass39_0[num136], 1);
				GClass194[] array12 = new GClass194[10];
				num = 0;
				try
				{
					for (num = 0; num < array12.Length; num++)
					{
						GClass194 gClass41 = (array12[num] = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_2()));
						if (num == 0)
						{
							if (gClass.int_4 <= gClass41.int_8)
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
					gClass.gclass194_2 = new GClass194[num];
					for (num = 0; num < gClass.gclass194_2.Length; num++)
					{
						gClass.gclass194_2[num] = array12[num];
					}
					gClass.gclass78_0 = null;
					gClass.gclass194_0 = gClass.gclass194_2[0];
				}
				break;
			}
			case 56:
			{
				GClass73.smethod_8("SXX6", 2);
				gClass = null;
				int num91 = msg.method_1().method_8();
				if (num91 == GClass78.smethod_1().int_13)
				{
					bool flag6 = false;
					gClass = GClass78.smethod_1();
					gClass.int_25 = msg.method_3();
					int num92 = msg.method_3();
					GClass50.smethod_8("dame hit = " + num92);
					if (num92 != 0)
						gClass.method_113();
					int num93 = 0;
					try
					{
						flag6 = msg.method_1().method_11();
						sbyte b34 = msg.method_1().method_2();
						if (b34 != -1)
						{
							GClass50.smethod_8("hit eff= " + b34);
							GClass57.smethod_0(new GClass81(b34, gClass.int_4, gClass.int_5, 3, 1, -1));
						}
					}
					catch (Exception)
					{
					}
					num92 += num93;
					if (GClass78.smethod_1().sbyte_19 != 4)
					{
						if (num92 != 0)
							GClass144.smethod_19("-" + GClass65.smethod_9(num92), gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, (!flag6) ? GClass4.int_3 : GClass4.int_6);
						else
							GClass144.smethod_19(mResources.miss, gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, GClass4.int_10);
					}
					break;
				}
				gClass = GClass144.smethod_14(num91);
				if (gClass == null)
					return;
				gClass.int_25 = msg.method_3();
				bool flag7 = false;
				int num94 = msg.method_3();
				if (num94 != 0)
					gClass.method_113();
				int num95 = 0;
				try
				{
					flag7 = msg.method_1().method_11();
					sbyte b35 = msg.method_1().method_2();
					if (b35 != -1)
					{
						GClass50.smethod_8("hit eff= " + b35);
						GClass57.smethod_0(new GClass81(b35, gClass.int_4, gClass.int_5, 3, 1, -1));
					}
				}
				catch (Exception)
				{
				}
				num94 += num95;
				if (gClass.sbyte_19 != 4)
				{
					if (num94 == 0)
						GClass144.smethod_19(mResources.miss, gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, GClass4.int_7);
					else
						GClass144.smethod_19("-" + GClass65.smethod_9(num94), gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, flag7 ? GClass4.int_6 : GClass4.int_8);
				}
				break;
			}
			case 57:
			{
				GClass73.smethod_8("SZ6", 2);
				GClass88 gClass32 = new GClass88();
				gClass32.method_0(new GClass87(msg.method_1().method_14(), GClass73.gclass73_0, 88817, null));
				GClass73.gclass145_0.method_2(gClass32, 3);
				break;
			}
			case 58:
			{
				GClass73.smethod_8("SZ7", 2);
				int num82 = msg.method_1().method_8();
				GClass78 gClass28 = ((num82 != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num82) : GClass78.smethod_1());
				gClass28.short_11 = new short[3];
				gClass28.short_11[0] = 0;
				short num83 = msg.method_1().method_6();
				short num84 = msg.method_1().method_6();
				gClass28.short_11[1] = num83;
				gClass28.short_11[2] = num84;
				try
				{
					num82 = msg.method_1().method_8();
					GClass78 gClass29 = ((num82 != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num82) : GClass78.smethod_1());
					gClass29.int_4 = num83;
					gClass29.int_5 = num84;
				}
				catch (Exception ex10)
				{
					GClass36.smethod_0("Loi MOVE_FAST " + ex10.ToString());
				}
				break;
			}
			case 62:
				GClass73.smethod_8("SZ3", 2);
				gClass = GClass144.smethod_14(msg.method_1().method_8());
				if (gClass != null)
				{
					gClass.int_74 = GClass78.smethod_1().int_13;
					GClass78.smethod_1().gclass79_0 = null;
					GClass78.smethod_1().gclass194_0 = null;
					GClass78.smethod_1().gclass64_0 = null;
					GClass78.smethod_1().gclass78_0 = gClass;
					GClass78.bool_56 = true;
					GClass144.gclass52_0.method_7(gClass.string_3 + mResources.CUU_SAT, 0);
				}
				break;
			case 63:
				GClass73.smethod_8("SZ4", 2);
				GClass78.smethod_1().int_74 = msg.method_1().method_8();
				GClass78.smethod_1().gclass79_0 = null;
				GClass78.smethod_1().gclass194_0 = null;
				GClass78.smethod_1().gclass64_0 = null;
				GClass78.smethod_1().gclass78_0 = GClass144.smethod_14(GClass78.smethod_1().int_74);
				GClass78.bool_56 = true;
				break;
			case 64:
				GClass73.smethod_8("SZ5", 2);
				gClass = GClass78.smethod_1();
				try
				{
					gClass = GClass144.smethod_14(msg.method_1().method_8());
				}
				catch (Exception ex9)
				{
					GClass36.smethod_0("Loi CLEAR_CUU_SAT " + ex9.ToString());
				}
				gClass.int_74 = -9999;
				break;
			case 65:
			{
				sbyte id2 = msg.method_1().method_0();
				string text4 = msg.method_1().method_14();
				short num77 = msg.method_1().method_6();
				if (!GClass19.smethod_2(id2))
				{
					GClass19 gClass25 = new GClass19();
					gClass25.method_0(id2, text4, num77);
					GClass144.gclass88_0.method_0(gClass25);
				}
				else if (num77 != 0)
				{
					GClass19.smethod_1(id2).method_0(id2, text4, num77);
				}
				else
				{
					GClass144.gclass88_0.method_8(GClass19.smethod_1(id2));
				}
				break;
			}
			case 66:
				method_17(msg);
				break;
			case 68:
			{
				GClass50.smethod_8("ADD ITEM TO MAP --------------------------------------");
				GClass73.smethod_8("SA6333", 2);
				short itemMapID = msg.method_1().method_6();
				short itemTemplateID = msg.method_1().method_6();
				int x = msg.method_1().method_6();
				int y = msg.method_1().method_6();
				int num53 = msg.method_1().method_8();
				short r = 0;
				if (num53 == -2)
					r = msg.method_1().method_6();
				GClass64 gClass20 = new GClass64(num53, itemMapID, itemTemplateID, x, y, r);
				bool flag4 = false;
				for (int num54 = 0; num54 < GClass144.gclass88_6.method_2(); num54++)
				{
					if (((GClass64)GClass144.gclass88_6.method_3(num54)).int_9 == gClass20.int_9)
					{
						flag4 = true;
						break;
					}
				}
				if (!flag4)
					GClass144.gclass88_6.method_0(gClass20);
				break;
			}
			case 69:
				GClass109.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
				break;
			case 81:
				GClass73.smethod_8("SXX4", 2);
				((GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5())).bool_5 = msg.method_1().method_10();
				break;
			case 82:
				GClass73.smethod_8("SXX5", 2);
				((GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5())).bool_6 = msg.method_1().method_10();
				break;
			case 83:
			{
				GClass73.smethod_8("SXX8", 2);
				int num37 = msg.method_1().method_8();
				gClass = ((num37 != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num37) : GClass78.smethod_1());
				if (gClass == null)
					return;
				GClass194 mobToAttack = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5());
				if (gClass.gclass194_1 != null)
					gClass.gclass194_1.method_23(mobToAttack);
				break;
			}
			case 84:
			{
				int num27 = msg.method_1().method_8();
				if (num27 == GClass78.smethod_1().int_13)
					gClass = GClass78.smethod_1();
				else
				{
					gClass = GClass144.smethod_14(num27);
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
				GClass73.smethod_8("SXX5", 2);
				((GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5())).bool_7 = msg.method_1().method_10();
				break;
			case 86:
			{
				GClass73.smethod_8("SXX5", 2);
				GClass194 gClass12 = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5());
				gClass12.bool_8 = msg.method_1().method_10();
				if (!gClass12.bool_8)
					GClass97.smethod_0(77, gClass12.int_8, gClass12.int_9 - 9, 1);
				break;
			}
			case 87:
				GClass73.smethod_8("SXX5", 2);
				((GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5())).bool_9 = msg.method_1().method_10();
				break;
			case 88:
			{
				string info = msg.method_1().method_14();
				short num21 = msg.method_1().method_6();
				GClass73.gclass43_0.method_0(info, new GClass87(mResources.ACCEPT, GClass73.gclass73_0, 88818, num21), GClass191.int_11);
				break;
			}
			case 90:
				GClass73.smethod_8("SA577", 2);
				method_0(msg);
				break;
			case 92:
			{
				if (GClass73.gclass131_0 == GClass144.gclass144_0)
					GClass73.smethod_29();
				string text = msg.method_1().method_14();
				string text2 = GClass50.smethod_15(msg.method_1().method_14());
				string empty = "";
				GClass78 gClass4 = null;
				sbyte b2 = 0;
				if (!text.Equals(""))
				{
					gClass4 = new GClass78();
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
				GClass130.smethod_5();
				if (!text.Equals(""))
				{
					GClass144.gclass52_1.method_6(empty, gClass4, b2 == 0);
					if (GClass73.gclass76_0.bool_0 && GClass73.gclass76_0.int_28 == 8)
						GClass73.gclass76_0.method_80();
				}
				else
					GClass144.gclass52_0.method_7(empty, 0);
				break;
			}
			case 94:
				GClass73.smethod_8("SA3", 2);
				GClass144.gclass52_0.method_7(msg.method_1().method_14(), 0);
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
							for (int num172 = 0; num172 < GClass144.gclass88_10.method_2(); num172++)
							{
								GClass79 gClass55 = (GClass79)GClass144.gclass88_10.method_3(num172);
								if (gClass55.gclass127_0.int_0 == b59)
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
						GClass194 gClass56 = null;
						try
						{
							gClass56 = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						if (gClass56 != null)
						{
							gClass56.sbyte_14 = msg.method_1().method_2();
							if (gClass56.sbyte_14 > 0)
								gClass56.int_40 = GClass50.smethod_19(0, 3);
						}
					}
				}
				else
				{
					GClass78 gClass58;
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
								GClass78.smethod_1().int_75 = msg.method_1().method_7();
								GClass78.smethod_1().int_76 = msg.method_1().method_7();
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
							GClass78 gClass62 = GClass144.smethod_14(charId);
							if (gClass62 != null)
							{
								gClass62.int_4 = int_18;
								gClass62.int_5 = int_19;
								gClass62.int_25 = (gClass62.int_28 = int_20);
								gClass62.long_1 = GClass203.smethod_18();
							}
						}
						break;
					}
					case -17:
						GClass73.smethod_8("SA88", 2);
						GClass78.smethod_1().bool_62 = true;
						GClass78.smethod_1().sbyte_18 = msg.method_1().method_2();
						GClass78.smethod_1().method_114(msg.method_1().method_6(), msg.method_1().method_6());
						try
						{
							GClass78.smethod_1().long_2 = msg.method_1().method_9();
							GClass78.smethod_1().method_4();
						}
						catch (Exception)
						{
							GClass36.smethod_0("Loi tai ME_DIE " + msg.sbyte_0);
						}
						GClass78.smethod_1().int_75 = 0;
						break;
					case -16:
						GClass73.smethod_8("SA90", 2);
						if (GClass78.smethod_1().short_22 != 0 || GClass78.smethod_1().short_23 != 0)
						{
							GClass78.smethod_1().int_4 = GClass78.smethod_1().short_22;
							GClass78.smethod_1().int_5 = GClass78.smethod_1().short_23;
							GClass78 gClass63 = GClass78.smethod_1();
							GClass78.smethod_1().short_23 = 0;
							gClass63.short_22 = 0;
						}
						GClass78.smethod_1().method_116();
						GClass78.smethod_1().bool_36 = false;
						GClass78.smethod_1().bool_62 = false;
						break;
					case -13:
					{
						GClass73.smethod_8("SA82", 2);
						int num192 = msg.method_1().method_5();
						if (num192 <= GClass144.gclass88_9.method_2() - 1 && num192 >= 0)
						{
							GClass194 gClass70 = (GClass194)GClass144.gclass88_9.method_3(num192);
							gClass70.int_29 = msg.method_1().method_2();
							gClass70.sbyte_14 = msg.method_1().method_2();
							if (gClass70.sbyte_14 != 0)
								gClass70.int_40 = GClass50.smethod_19(0, 3);
							gClass70.int_8 = gClass70.int_16;
							gClass70.int_9 = gClass70.int_17;
							gClass70.int_12 = 5;
							gClass70.bool_20 = false;
							gClass70.int_6 = msg.method_1().method_8();
							gClass70.int_7 = gClass70.int_6;
							gClass70.method_20();
							GClass97.smethod_0(60, gClass70.int_8, gClass70.int_9, 1);
							break;
						}
						return;
					}
					case -12:
					{
						GClass50.smethod_8("SERVER SEND MOB DIE");
						GClass73.smethod_8("SA85", 2);
						GClass194 gClass66 = null;
						try
						{
							gClass66 = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
							GClass36.smethod_0("LOi tai NPC_DIE cmd " + msg.sbyte_0);
						}
						if (gClass66 == null || gClass66.int_12 == 0 || gClass66.int_12 == 0)
							break;
						gClass66.method_22();
						try
						{
							int num187 = msg.method_3();
							if (!msg.method_1().method_10())
								GClass144.smethod_19("-" + GClass65.smethod_9(num187), gClass66.int_8, gClass66.int_9 - gClass66.int_21, 0, -2, GClass4.int_8);
							else
								GClass144.smethod_19("-" + GClass65.smethod_9(num187), gClass66.int_8, gClass66.int_9 - gClass66.int_21, 0, -2, GClass4.int_6);
							sbyte b63 = msg.method_1().method_2();
							for (int num188 = 0; num188 < b63; num188++)
							{
								GClass64 gClass67 = new GClass64(msg.method_1().method_6(), msg.method_1().method_6(), gClass66.int_8, gClass66.int_9, msg.method_1().method_6(), msg.method_1().method_6());
								GClass50.smethod_8("playerid= " + (int)(gClass67.int_8 = msg.method_1().method_8()) + " my id= " + GClass78.smethod_1().int_13);
								GClass144.gclass88_6.method_0(gClass67);
								if (GClass50.smethod_28(gClass67.int_2 - GClass78.smethod_1().int_5) < 24 && GClass50.smethod_28(gClass67.int_1 - GClass78.smethod_1().int_4) < 24)
									GClass78.smethod_1().gclass78_0 = null;
							}
						}
						catch (Exception)
						{
						}
						break;
					}
					case -11:
					{
						GClass73.smethod_8("SA86", 2);
						GClass194 gClass65 = null;
						try
						{
							int index5 = msg.method_1().method_5();
							gClass65 = (GClass194)GClass144.gclass88_9.method_3(index5);
						}
						catch (Exception ex31)
						{
							GClass50.smethod_8("Loi tai NPC_ATTACK_ME " + msg.sbyte_0 + " err= " + ex31.StackTrace);
						}
						if (gClass65 != null)
						{
							GClass78.smethod_1().bool_7 = false;
							GClass78.bool_34 = false;
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
							if (gClass65.bool_18)
							{
								GClass78.smethod_1().method_112(num185, num186, false, true);
								break;
							}
							gClass65.int_27 = num185;
							gClass65.int_28 = num186;
							gClass65.method_8(GClass78.smethod_1());
						}
						break;
					}
					case -10:
					{
						GClass73.smethod_8("SA87", 2);
						GClass194 gClass57 = null;
						try
						{
							gClass57 = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						GClass73.smethod_8("SA87x1", 2);
						if (gClass57 != null)
						{
							GClass73.smethod_8("SA87x2", 2);
							gClass = GClass144.smethod_14(msg.method_1().method_8());
							if (gClass == null)
								return;
							GClass73.smethod_8("SA87x3", 2);
							int num175 = msg.method_3();
							gClass57.int_27 = gClass.int_25 - num175;
							gClass.int_26 = num175;
							GClass73.smethod_8("SA87x4", 2);
							try
							{
								gClass.int_24 = msg.method_3();
							}
							catch (Exception)
							{
							}
							GClass73.smethod_8("SA87x5", 2);
							if (!gClass57.bool_18)
								gClass57.method_8(gClass);
							else
								gClass.method_112(gClass57.int_27, 0, false, true);
							GClass73.smethod_8("SA87x6", 2);
						}
						break;
					}
					case -9:
					{
						GClass73.smethod_8("SA83", 2);
						GClass194 gClass69 = null;
						try
						{
							gClass69 = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						GClass73.smethod_8("SA83v1", 2);
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
								GClass57.smethod_0(new GClass81(b64, gClass69.int_8, gClass69.getY(), 3, 1, -1));
							GClass73.smethod_8("SA83v2", 2);
							if (flag13)
								GClass144.smethod_19("-" + GClass65.smethod_9(num191), gClass69.int_8, gClass69.getY() - gClass69.getH(), 0, -2, GClass4.int_6);
							else if (num191 == 0)
							{
								gClass69.int_8 = gClass69.int_16;
								gClass69.int_9 = gClass69.int_17;
								GClass144.smethod_19(mResources.miss, gClass69.int_8, gClass69.getY() - gClass69.getH(), 0, -2, GClass4.int_7);
							}
							else if (num191 > 1)
							{
								GClass144.smethod_19("-" + GClass65.smethod_9(num191), gClass69.int_8, gClass69.getY() - gClass69.getH(), 0, -2, GClass4.int_8);
							}
						}
						GClass73.smethod_8("SA83v3", 2);
						break;
					}
					case -8:
						GClass73.smethod_8("SA89", 2);
						gClass = GClass144.smethod_14(msg.method_1().method_8());
						if (gClass == null)
							return;
						gClass.sbyte_18 = msg.method_1().method_2();
						gClass.method_115(msg.method_1().method_6(), msg.method_1().method_6());
						break;
					case -7:
					{
						GClass73.smethod_8("SA80", 2);
						int num180 = msg.method_1().method_8();
						for (int num181 = 0; num181 < GClass144.gclass88_5.method_2(); num181++)
						{
							GClass78 gClass61 = null;
							try
							{
								gClass61 = (GClass78)GClass144.gclass88_5.method_3(num181);
							}
							catch (Exception)
							{
							}
							if (gClass61 != null)
							{
								if (gClass61.int_13 == num180)
								{
									GClass73.smethod_8("SA8x2y" + num181, 2);
									gClass61.method_100(msg.method_1().method_6(), msg.method_1().method_6(), 0);
									gClass61.long_1 = GClass203.smethod_18();
									break;
								}
								continue;
							}
							break;
						}
						GClass73.smethod_8("SA80x3", 2);
						break;
					}
					case -6:
					{
						GClass73.smethod_8("SA81", 2);
						int num189 = msg.method_1().method_8();
						for (int num190 = 0; num190 < GClass144.gclass88_5.method_2(); num190++)
						{
							GClass78 gClass68 = (GClass78)GClass144.gclass88_5.method_3(num190);
							if (gClass68 != null && gClass68.int_13 == num189)
							{
								if (!gClass68.bool_20 && !gClass68.bool_3)
									GClass97.smethod_0(60, gClass68.int_4, gClass68.int_5, 1);
								if (!gClass68.bool_3)
									GClass144.gclass88_5.method_7(num190);
								return;
							}
						}
						break;
					}
					case -5:
					{
						GClass73.smethod_8("SA79", 2);
						int int_17 = msg.method_1().method_8();
						int num176 = msg.method_1().method_8();
						if (num176 != -100)
						{
							gClass58 = new GClass78();
							gClass58.int_13 = int_17;
							gClass58.int_56 = num176;
						}
						else
						{
							gClass58 = new Class7();
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
								GClass50.smethod_8("nhân vật bay trên trời xuống x= " + gClass58.int_4 + " y= " + gClass58.int_5);
								GClass23 gClass59 = new GClass23(gClass58.int_4, gClass58.int_5, gClass58.int_119, gClass58.int_12, 1, false, (b60 != 1) ? b60 : gClass58.int_14);
								gClass59.int_5 = gClass58.int_13;
								gClass58.bool_2 = true;
								GClass23.smethod_0(gClass59);
							}
							if (b60 == 2)
								gClass58.method_37();
							for (int num177 = 0; num177 < GClass144.gclass88_9.method_2(); num177++)
							{
								GClass194 gClass60 = (GClass194)GClass144.gclass88_9.method_3(num177);
								if (gClass60 != null && gClass60.bool_13 && gClass60.int_25 == gClass58.int_13)
								{
									GClass50.smethod_8("co 1 con quai");
									gClass58.gclass194_1 = gClass60;
									gClass58.gclass194_1.int_8 = gClass58.int_4;
									gClass58.gclass194_1.int_9 = gClass58.int_5 - 40;
									break;
								}
							}
							if (GClass144.smethod_14(gClass58.int_13) == null)
								GClass144.gclass88_5.method_0(gClass58);
							gClass58.sbyte_35 = msg.method_1().method_2();
							num178 = msg.method_1().method_6();
							GClass50.smethod_8("mount id= " + num178 + "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
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
											goto IL_a2a0;
										gClass58.bool_26 = true;
									}
									else
										gClass58.bool_26 = false;
								}
								else if (num179 != 396)
								{
									if (num179 != 532)
										goto IL_a2a0;
									gClass58.bool_28 = true;
								}
								else
								{
									gClass58.bool_27 = true;
								}
							}
						}
						goto IL_a2d5;
					}
					case -3:
					{
						GClass73.smethod_8("SA78", 2);
						sbyte b61 = msg.method_1().method_2();
						int num182 = msg.method_1().method_8();
						if (b61 == 0)
							GClass78.smethod_1().long_2 += num182;
						if (b61 == 1)
							GClass78.smethod_1().long_4 += num182;
						if (b61 == 2)
						{
							GClass78.smethod_1().long_2 += num182;
							GClass78.smethod_1().long_4 += num182;
						}
						GClass78.smethod_1().method_4();
						if (GClass78.smethod_1().sbyte_19 != 3)
						{
							GClass144.smethod_19(((num182 <= 0) ? "" : "+") + GClass65.smethod_9(num182), GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58, 0, -4, GClass4.int_5);
							if (num182 > 0 && GClass78.smethod_1().gclass82_0 != null && GClass78.smethod_1().gclass82_0.short_0 == 5002)
							{
								GClass97.smethod_0(55, GClass78.smethod_1().gclass82_0.int_9, GClass78.smethod_1().gclass82_0.int_4, 1);
								GClass97.smethod_0(55, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, 1);
							}
						}
						break;
					}
					case -2:
					{
						GClass73.smethod_8("SA77", 22);
						int num174 = msg.method_1().method_8();
						GClass78.smethod_1().int_66 += num174;
						GClass144.smethod_19((num174 <= 0) ? ("" + GClass65.smethod_9(num174)) : ("+" + num174), GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58 - 10, 0, -2, GClass4.int_4);
						break;
					}
					case -1:
					{
						GClass73.smethod_8("SA77", 222);
						int num173 = msg.method_1().method_8();
						GClass78.smethod_1().long_6 += num173;
						GClass78.smethod_1().string_0 = GClass203.smethod_6(GClass78.smethod_1().long_6);
						GClass78.smethod_1().int_66 -= num173;
						GClass144.smethod_19("+" + GClass65.smethod_9(num173), GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58 - 10, 0, -2, GClass4.int_4);
						break;
					}
					case -15:
					case -14:
					case -4:
						break;
						IL_a2d5:
						sbyte_2 = msg.method_1().method_2();
						GClass50.smethod_8("addplayer:   " + sbyte_2);
						gClass58.sbyte_28 = sbyte_2;
						gClass58.bool_4 = msg.method_1().method_2() == 1;
						try
						{
							gClass58.short_28 = msg.method_1().method_6();
							gClass58.short_29 = msg.method_1().method_0();
							gClass58.short_30 = msg.method_1().method_6();
							if (gClass58.int_122 >= 201 && gClass58.int_122 < 255)
							{
								GClass81 gClass64 = new GClass81(gClass58.int_122, gClass58, 2, -1, 10, 1);
								gClass64.int_1 = 5;
								gClass58.method_140(gClass64);
							}
							else
							{
								for (int num184 = 0; num184 < 54; num184++)
								{
									gClass58.method_141(0, 201 + num184);
								}
							}
						}
						catch (Exception ex30)
						{
							GClass50.smethod_8("cmd: -5 err: " + ex30.StackTrace);
						}
						GClass144.smethod_8().method_116(gClass58.int_13, gClass58.sbyte_28);
						break;
						IL_a2a0:
						if (num178 >= GClass78.short_14)
							gClass58.short_15 = num178;
						goto IL_a2d5;
					}
				}
			}
			else if (b58 <= 45)
			{
				if (b58 != 44)
				{
					if (b58 == 45)
					{
						GClass73.smethod_8("SA84", 2);
						GClass194 gClass71 = null;
						try
						{
							gClass71 = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5());
						}
						catch (Exception ex38)
						{
							GClass36.smethod_0("Loi tai NPC_MISS  " + ex38.ToString());
						}
						if (gClass71 != null)
						{
							gClass71.int_6 = msg.method_1().method_8();
							gClass71.method_20();
							GClass144.smethod_19(mResources.miss, gClass71.int_8, gClass71.int_9 - gClass71.int_21, 0, -2, GClass4.int_7);
						}
					}
				}
				else
				{
					GClass73.smethod_8("SA91", 2);
					int num193 = msg.method_1().method_8();
					string text9 = msg.method_1().method_14();
					GClass50.smethod_8("user id= " + num193 + " text= " + text9);
					gClass = ((GClass78.smethod_1().int_13 != num193) ? GClass144.smethod_14(num193) : GClass78.smethod_1());
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
						GClass73.smethod_8("SA77", 22);
						int num195 = msg.method_1().method_8();
						GClass78.smethod_1().long_6 += num195;
						GClass78.smethod_1().string_0 = GClass203.smethod_6(GClass78.smethod_1().long_6);
						GClass144.smethod_19((num195 <= 0) ? ("" + GClass65.smethod_9(num195)) : ("+" + num195), GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58 - 10, 0, -2, GClass4.int_4);
						break;
					}
					case 96:
						GClass73.smethod_8("SA77a", 22);
						GClass78.smethod_1().gclass88_4.method_0(new GClass62(msg.method_1().method_2(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_14(), msg.method_1().method_14(), msg.method_1().method_2(), msg.method_1().method_2()));
						break;
					case 97:
					{
						sbyte b65 = msg.method_1().method_2();
						for (int num194 = 0; num194 < GClass78.smethod_1().gclass88_4.method_2(); num194++)
						{
							GClass62 gClass72 = (GClass62)GClass78.smethod_1().gclass88_4.method_3(num194);
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
					GClass73.smethod_8("SA85", 2);
					GClass194 gClass73 = null;
					try
					{
						gClass73 = (GClass194)GClass144.gclass88_9.method_3(msg.method_1().method_5());
					}
					catch (Exception)
					{
						GClass36.smethod_0("Loi tai NPC CHANGE " + msg.sbyte_0);
					}
					if (gClass73 != null && gClass73.int_12 != 0 && gClass73.int_12 != 0)
					{
						gClass73.int_12 = 0;
						GClass97.smethod_0(60, gClass73.int_8, gClass73.int_9, 1);
						GClass64 gClass74 = new GClass64(msg.method_1().method_6(), msg.method_1().method_6(), gClass73.int_8, gClass73.int_9, msg.method_1().method_6(), msg.method_1().method_6());
						GClass144.gclass88_6.method_0(gClass74);
						if (GClass50.smethod_28(gClass74.int_2 - GClass78.smethod_1().int_5) < 24 && GClass50.smethod_28(gClass74.int_1 - GClass78.smethod_1().int_4) < 24)
							GClass78.smethod_1().gclass78_0 = null;
					}
				}
			}
			else
			{
				GClass50.smethod_8("ME DIE XP DOWN NOT IMPLEMENT YET!!!!!!!!!!!!!!!!!!!!!!!!!!");
			}
			GClass73.smethod_8("SA92", 2);
		}
		catch (Exception ex40)
		{
			GClass50.smethod_10("[Controller] [error] " + ex40.StackTrace + " msg: " + ex40.Message + " cause " + ex40.Data);
		}
		finally
		{
			msg?.method_4();
		}
	}

	private void method_1(GClass208 gclass208_1)
	{
		sbyte b = gclass208_1.method_1().method_2();
		GClass137.gclass115_0 = new GClass115[b];
		GClass50.smethod_8("[LEN] sl nguoi choi " + b);
		for (int i = 0; i < b; i++)
		{
			int playerID = gclass208_1.method_1().method_8();
			string name = gclass208_1.method_1().method_14();
			short head = gclass208_1.method_1().method_6();
			short body = gclass208_1.method_1().method_6();
			short leg = gclass208_1.method_1().method_6();
			long ppoint = gclass208_1.method_1().method_9();
			GClass137.gclass115_0[i] = new GClass115(playerID, name, head, body, leg, ppoint);
		}
		GClass73.gclass137_0.switchToMe();
		GClass73.gclass137_0.method_0((byte)b);
	}

	private void method_2(GClass100 gclass100_0)
	{
		GClass144.sbyte_3 = gclass100_0.method_2();
		GClass0.gclass113_0.method_1();
		GClass144.smethod_8().gclass126_0 = new GClass126[gclass100_0.method_5()];
		for (int i = 0; i < GClass144.smethod_8().gclass126_0.Length; i++)
		{
			GClass144.smethod_8().gclass126_0[i] = new GClass126();
			GClass144.smethod_8().gclass126_0[i].int_0 = i;
			GClass144.smethod_8().gclass126_0[i].string_0 = gclass100_0.method_14();
			GClass144.smethod_8().gclass126_0[i].int_1 = gclass100_0.method_2();
		}
		int num = gclass100_0.method_6();
		for (int j = 0; j < num; j++)
		{
			GClass0.smethod_0(new GClass117((short)j, gclass100_0.method_2(), gclass100_0.method_2(), gclass100_0.method_14(), gclass100_0.method_14(), gclass100_0.method_2(), gclass100_0.method_8(), gclass100_0.method_6(), gclass100_0.method_6(), gclass100_0.method_10()));
		}
	}

	private void method_3(GClass100 gclass100_0)
	{
		GClass144.sbyte_2 = gclass100_0.method_2();
		GClass144.smethod_8().gclass58_0 = new GClass58[gclass100_0.method_2()];
		for (int i = 0; i < GClass144.smethod_8().gclass58_0.Length; i++)
		{
			GClass144.smethod_8().gclass58_0[i] = new GClass58();
			GClass144.smethod_8().gclass58_0[i].int_0 = i;
			GClass144.smethod_8().gclass58_0[i].string_0 = gclass100_0.method_14();
		}
		GClass144.gclass176_0 = new GClass176[gclass100_0.method_2()];
		for (int j = 0; j < GClass144.gclass176_0.Length; j++)
		{
			GClass144.gclass176_0[j] = new GClass176();
			GClass144.gclass176_0[j].int_0 = j;
			GClass144.gclass176_0[j].string_0 = gclass100_0.method_14();
			GClass144.gclass176_0[j].gclass47_0 = new GClass47[gclass100_0.method_2()];
			for (int k = 0; k < GClass144.gclass176_0[j].gclass47_0.Length; k++)
			{
				GClass144.gclass176_0[j].gclass47_0[k] = new GClass47();
				GClass144.gclass176_0[j].gclass47_0[k].sbyte_0 = gclass100_0.method_2();
				GClass144.gclass176_0[j].gclass47_0[k].string_0 = gclass100_0.method_14();
				GClass144.gclass176_0[j].gclass47_0[k].int_1 = gclass100_0.method_2();
				GClass144.gclass176_0[j].gclass47_0[k].int_2 = gclass100_0.method_2();
				GClass144.gclass176_0[j].gclass47_0[k].int_3 = gclass100_0.method_2();
				GClass144.gclass176_0[j].gclass47_0[k].int_4 = gclass100_0.method_6();
				GClass144.gclass176_0[j].gclass47_0[k].string_2 = gclass100_0.method_14();
				int lineWidth = 130;
				if (GClass73.int_10 == 128 || GClass73.int_11 <= 208)
					lineWidth = 100;
				GClass144.gclass176_0[j].gclass47_0[k].string_1 = GClass4.gclass4_14.method_15(gclass100_0.method_14(), lineWidth);
				GClass144.gclass176_0[j].gclass47_0[k].gclass63_0 = new GClass63[gclass100_0.method_2()];
				for (int l = 0; l < GClass144.gclass176_0[j].gclass47_0[k].gclass63_0.Length; l++)
				{
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l] = new GClass63();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].short_0 = gclass100_0.method_6();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].gclass47_0 = GClass144.gclass176_0[j].gclass47_0[k];
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].int_0 = gclass100_0.method_2();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].long_0 = gclass100_0.method_9();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].int_5 = gclass100_0.method_6();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].int_1 = gclass100_0.method_8();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].int_2 = gclass100_0.method_6();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].int_3 = gclass100_0.method_6();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].int_4 = gclass100_0.method_2();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].short_1 = gclass100_0.method_6();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].short_2 = gclass100_0.method_6();
					GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l].string_0 = gclass100_0.method_14();
					GClass99.smethod_0(GClass144.gclass176_0[j].gclass47_0[k].gclass63_0[l]);
				}
			}
		}
	}

	private void method_4(GClass100 gclass100_0)
	{
		GClass144.sbyte_1 = gclass100_0.method_2();
		GClass20.string_2 = new string[gclass100_0.method_5()];
		for (int i = 0; i < GClass20.string_2.Length; i++)
		{
			GClass20.string_2[i] = gclass100_0.method_14();
		}
		GClass79.gclass127_1 = new GClass127[gclass100_0.method_2()];
		for (sbyte b = 0; b < GClass79.gclass127_1.Length; b++)
		{
			GClass79.gclass127_1[b] = new GClass127();
			GClass79.gclass127_1[b].int_0 = b;
			GClass79.gclass127_1[b].string_0 = gclass100_0.method_14();
			GClass79.gclass127_1[b].int_1 = gclass100_0.method_6();
			GClass79.gclass127_1[b].int_2 = gclass100_0.method_6();
			GClass79.gclass127_1[b].int_3 = gclass100_0.method_6();
			GClass79.gclass127_1[b].string_1 = new string[gclass100_0.method_2()][];
			for (int j = 0; j < GClass79.gclass127_1[b].string_1.Length; j++)
			{
				GClass79.gclass127_1[b].string_1[j] = new string[gclass100_0.method_2()];
				for (int k = 0; k < GClass79.gclass127_1[b].string_1[j].Length; k++)
				{
					GClass79.gclass127_1[b].string_1[j][k] = gclass100_0.method_14();
				}
			}
		}
		GClass194.gclass177_0 = new GClass177[gclass100_0.method_2()];
		for (sbyte b2 = 0; b2 < GClass194.gclass177_0.Length; b2++)
		{
			GClass194.gclass177_0[b2] = new GClass177();
			GClass194.gclass177_0[b2].sbyte_0 = b2;
			GClass194.gclass177_0[b2].sbyte_3 = gclass100_0.method_2();
			GClass194.gclass177_0[b2].string_0 = gclass100_0.method_14();
			GClass194.gclass177_0[b2].int_0 = gclass100_0.method_8();
			GClass194.gclass177_0[b2].sbyte_1 = gclass100_0.method_2();
			GClass194.gclass177_0[b2].sbyte_2 = gclass100_0.method_2();
			GClass194.gclass177_0[b2].sbyte_4 = gclass100_0.method_2();
		}
	}

	private void method_5(GClass100 gclass100_0, bool bool_6)
	{
		GClass144.sbyte_0 = gclass100_0.method_2();
		if (bool_6)
		{
			GClass1.smethod_0("NR_dart", GClass65.smethod_3(gclass100_0));
			GClass1.smethod_0("NR_arrow", GClass65.smethod_3(gclass100_0));
			GClass1.smethod_0("NR_effect", GClass65.smethod_3(gclass100_0));
			GClass1.smethod_0("NR_image", GClass65.smethod_3(gclass100_0));
			GClass1.smethod_0("NR_part", GClass65.smethod_3(gclass100_0));
			GClass1.smethod_0("NR_skill", GClass65.smethod_3(gclass100_0));
			GClass1.smethod_14("NRdata");
		}
	}

	private GClass70 method_6(sbyte[] sbyte_6)
	{
		try
		{
			return GClass70.smethod_6(sbyte_6, 0, sbyte_6.Length);
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

	public void method_8(GClass208 msg, int index)
	{
		try
		{
			GClass189 gClass = new GClass189();
			sbyte b = (sbyte)(gClass.int_1 = msg.method_1().method_2());
			gClass.int_0 = msg.method_1().method_8();
			gClass.int_2 = msg.method_1().method_8();
			gClass.string_0 = msg.method_1().method_14();
			gClass.sbyte_1 = msg.method_1().method_2();
			gClass.long_0 = msg.method_1().method_8() + 1000000000;
			bool upToTop = false;
			GClass144.bool_60 = false;
			if (b != 0)
			{
				if (b != 1)
				{
					if (b == 2 && GClass78.smethod_1().sbyte_17 == 0)
					{
						GClass144.bool_60 = true;
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
						GClass144.bool_60 = true;
					if (gClass.int_2 != GClass78.smethod_1().int_13)
					{
						if (gClass.int_5 >= gClass.int_6)
							gClass.string_2 = null;
						else
							gClass.string_2 = new string[1] { mResources.donate };
					}
					if (GClass73.gclass76_0.gclass96_0 != null)
						GClass73.gclass76_0.method_191(gClass.int_5, gClass.int_6);
				}
			}
			else
			{
				string text = msg.method_1().method_14();
				GClass144.bool_60 = true;
				if (GClass4.gclass4_11.method_17(text) > GClass76.int_55 - 60)
					gClass.string_1 = GClass4.gclass4_11.method_15(text, GClass76.int_55 - 10);
				else
				{
					gClass.string_1 = new string[1];
					gClass.string_1[0] = text;
				}
				gClass.sbyte_0 = msg.method_1().method_2();
			}
			if (GClass73.gclass131_0 != GClass144.gclass144_0)
				GClass144.bool_60 = false;
			else if (GClass73.gclass76_0.bool_0 && GClass73.gclass76_0.int_28 == 0 && GClass73.gclass76_0.int_29 == 3)
			{
				GClass144.bool_60 = false;
			}
			GClass189.smethod_0(gClass, index, upToTop);
		}
		catch (Exception)
		{
			GClass36.smethod_0("LOI TAI CMD -= " + msg.sbyte_0);
		}
	}

	public void method_9(sbyte teleport3)
	{
		GClass50.smethod_8("[CONTROLER] start load map " + teleport3);
		GClass144.smethod_8().int_96 = 0;
		GClass144.bool_70 = false;
		GClass140.gclass140_0 = null;
		GClass144.gclass52_0.bool_1 = false;
		GClass144.gclass52_1.bool_1 = false;
		GClass144.int_38 = 0;
		GClass73.gclass76_0.bool_0 = false;
		GClass109.smethod_1().method_51();
		if (!GClass144.bool_2 && !GClass140.bool_0)
			GClass144.smethod_8().method_0();
		GClass144.smethod_10(false, (teleport3 != 1) ? (-1) : GClass78.smethod_1().int_4, (teleport3 == 0) ? (-1) : 0);
		GClass20.smethod_34();
		GClass20.smethod_13(GClass20.int_25);
		GClass50.smethod_8("LOAD GAMESCR 2");
		GClass78.smethod_1().int_6 = 0;
		GClass78.smethod_1().int_11 = 4;
		GClass78.smethod_1().gclass29_0 = null;
		GClass78.smethod_1().gclass194_0 = null;
		GClass78.smethod_1().gclass78_0 = null;
		GClass78.smethod_1().gclass79_0 = null;
		GClass78.smethod_1().gclass64_0 = null;
		GClass78.smethod_1().gclass39_0 = null;
		GClass78.smethod_1().method_80(false);
		GClass78.smethod_1().gclass39_1 = null;
		GClass73.smethod_49();
		if (GClass78.smethod_1().int_5 >= GClass20.int_24 - 100)
		{
			GClass78.smethod_1().bool_24 = true;
			GClass78.smethod_1().int_4 += GClass50.smethod_28(GClass50.smethod_19(0, 80));
			GClass7.smethod_0().method_44();
		}
		GClass144.smethod_8().method_24();
		GClass73.smethod_21(GClass20.int_40);
		GClass78.bool_34 = false;
		GClass50.smethod_8("cy= " + GClass78.smethod_1().int_5 + "---------------------------------------------");
		for (int i = 0; i < GClass78.smethod_1().gclass88_2.method_2(); i++)
		{
			if (((GClass25)GClass78.smethod_1().gclass88_2.method_3(i)).gclass67_1.sbyte_1 == 10)
			{
				GClass78.bool_34 = true;
				break;
			}
		}
		GClass73.smethod_27();
		GClass73.smethod_26();
		GClass144.smethod_8().int_146 = GClass78.smethod_1().int_25;
		GClass144.smethod_8().int_144 = GClass78.smethod_1().int_24;
		GClass78.bool_33 = false;
		GClass144.smethod_8().switchToMe();
		if (GClass78.smethod_1().int_5 <= 10 && teleport3 != 0 && teleport3 != 2)
		{
			GClass23.smethod_0(new GClass23(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, GClass78.smethod_1().int_119, GClass78.smethod_1().int_12, 1, true, (teleport3 != 1) ? teleport3 : GClass78.smethod_1().int_14));
			GClass78.smethod_1().bool_2 = true;
		}
		if (teleport3 == 2)
			GClass78.smethod_1().method_37();
		if (GClass144.smethod_8().bool_63)
		{
			if (GClass20.int_37 == GClass144.smethod_8().int_104 && GClass20.int_39 == GClass144.smethod_8().int_105)
				GClass144.smethod_8().method_55(GClass144.smethod_8().int_129, GClass144.smethod_8().int_130);
			if (GClass122.int_12 > 1)
				GClass144.smethod_8().method_54();
		}
		GClass130.smethod_5();
		GClass130.smethod_0(GClass20.string_1, mResources.zone + " " + GClass20.int_39, 30);
		GClass73.smethod_29();
		GClass73.bool_4 = false;
		GClass31.smethod_4();
		GClass31.smethod_2();
		GClass73.smethod_8("SA75x9", 2);
		GClass50.smethod_8("[CONTROLLER] loadMap DONE!!!!!!!!!");
	}

	public void method_10(GClass208 msg)
	{
		try
		{
			if (GClass122.int_12 == 1)
				GClass28.smethod_4();
			GClass78.smethod_1().int_4 = (GClass78.smethod_1().int_101 = (GClass78.smethod_1().int_104 = msg.method_1().method_6()));
			GClass78.smethod_1().int_5 = (GClass78.smethod_1().int_102 = (GClass78.smethod_1().int_105 = msg.method_1().method_6()));
			GClass78.smethod_1().int_147 = GClass78.smethod_1().int_4;
			GClass78.smethod_1().int_148 = GClass78.smethod_1().int_5;
			GClass50.smethod_8("head= " + GClass78.smethod_1().int_119 + " body= " + GClass78.smethod_1().int_121 + " left= " + GClass78.smethod_1().int_120 + " x= " + GClass78.smethod_1().int_4 + " y= " + GClass78.smethod_1().int_5 + " chung toc= " + GClass78.smethod_1().int_14);
			if (GClass78.smethod_1().int_4 >= 0 && GClass78.smethod_1().int_4 <= 100)
				GClass78.smethod_1().int_12 = 1;
			else if (GClass78.smethod_1().int_4 >= GClass20.int_21 - 100 && GClass78.smethod_1().int_4 <= GClass20.int_21)
			{
				GClass78.smethod_1().int_12 = -1;
			}
			GClass73.smethod_8("SA75x4", 2);
			int num = msg.method_1().method_2();
			GClass50.smethod_8("vGo size= " + num);
			if (!GClass144.gclass52_0.bool_0)
			{
				GClass144.gclass52_0.int_10 = GClass78.smethod_1().int_4 - GClass144.int_22;
				GClass144.gclass52_0.int_5 = GClass78.smethod_1().int_5 - GClass144.int_23;
			}
			for (int i = 0; i < num; i++)
			{
				GClass181 gClass = new GClass181(msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_14());
				if ((GClass20.int_37 != 21 && GClass20.int_37 != 22 && GClass20.int_37 != 23) || gClass.short_0 < 0 || gClass.short_0 > 24)
					;
			}
			Resources.UnloadUnusedAssets();
			GC.Collect();
			GClass73.smethod_8("SA75x5", 2);
			num = msg.method_1().method_2();
			GClass194.gclass88_2.method_9();
			for (sbyte b = 0; b < num; b++)
			{
				GClass194 gClass2 = new GClass194(b, msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_2(), msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_2(), msg.method_1().method_2());
				gClass2.int_32 = gClass2.int_8;
				gClass2.int_33 = gClass2.int_9;
				gClass2.bool_12 = msg.method_1().method_11();
				if (GClass194.gclass177_0[gClass2.int_26].sbyte_3 != 0)
				{
					if (b % 3 != 0)
						gClass2.int_10 = 1;
					else
						gClass2.int_10 = -1;
					gClass2.int_8 += 10 - b % 20;
				}
				gClass2.bool_13 = false;
				GClass196 gClass3 = null;
				GClass195 gClass4 = null;
				GClass198 gClass5 = null;
				GClass197 gClass6 = null;
				if (gClass2.int_26 == 70)
					gClass3 = new GClass196(b, (short)gClass2.int_8, (short)gClass2.int_9, 70, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass2.int_26 == 71)
					gClass4 = new GClass195(b, (short)gClass2.int_8, (short)gClass2.int_9, 71, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass2.int_26 == 72)
					gClass5 = new GClass198(b, (short)gClass2.int_8, (short)gClass2.int_9, 72, gClass2.int_6, gClass2.int_7, 3);
				if (gClass2.bool_12)
					gClass6 = new GClass197(b, (short)gClass2.int_8, (short)gClass2.int_9, gClass2.int_26, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass6 != null)
					GClass144.gclass88_9.method_0(gClass6);
				else if (gClass3 != null)
				{
					GClass144.gclass88_9.method_0(gClass3);
				}
				else if (gClass4 == null)
				{
					if (gClass5 != null)
						GClass144.gclass88_9.method_0(gClass5);
					else
						GClass144.gclass88_9.method_0(gClass2);
				}
				else
				{
					GClass144.gclass88_9.method_0(gClass4);
				}
			}
			if (GClass78.smethod_1().gclass194_1 != null && GClass144.smethod_16(GClass78.smethod_1().gclass194_1.int_25) == null)
			{
				GClass78.smethod_1().gclass194_1.method_1();
				GClass78.smethod_1().gclass194_1.int_8 = GClass78.smethod_1().int_4;
				GClass78.smethod_1().gclass194_1.int_9 = GClass78.smethod_1().int_5 - 40;
				GClass144.gclass88_9.method_0(GClass78.smethod_1().gclass194_1);
			}
			num = msg.method_1().method_2();
			for (byte b2 = 0; b2 < num; b2++)
			{
			}
			GClass73.smethod_8("SA75x6", 2);
			num = msg.method_1().method_2();
			GClass50.smethod_8("NPC size= " + num);
			for (int j = 0; j < num; j++)
			{
				sbyte status = msg.method_1().method_2();
				short cx = msg.method_1().method_6();
				short num2 = msg.method_1().method_6();
				sbyte b3 = msg.method_1().method_2();
				short num3 = msg.method_1().method_6();
				if (b3 != 6 && ((GClass78.smethod_1().gclass56_0.short_1 >= 7 && (GClass78.smethod_1().gclass56_0.short_1 != 7 || GClass78.smethod_1().gclass56_0.int_0 > 1)) || (b3 != 7 && b3 != 8 && b3 != 9)) && (GClass78.smethod_1().gclass56_0.short_1 >= 6 || b3 != 16))
				{
					if (b3 != 4)
					{
						GClass79 o = new GClass79(j, status, cx, num2 + 3, b3, num3);
						GClass144.gclass88_10.method_0(o);
					}
					else
					{
						GClass144.smethod_8().gclass80_0 = new GClass80(j, status, cx, num2, b3, num3);
						GClass7.smethod_0().method_41(2);
						GClass144.gclass88_10.method_0(GClass144.smethod_8().gclass80_0);
					}
				}
			}
			GClass73.smethod_8("SA75x7", 2);
			num = msg.method_1().method_2();
			string empty = "";
			GClass50.smethod_8("item size = " + num);
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
				GClass64 gClass7 = new GClass64(num4, itemMapID, itemTemplateID, x, y, r);
				bool flag = false;
				for (int l = 0; l < GClass144.gclass88_6.method_2(); l++)
				{
					if (((GClass64)GClass144.gclass88_6.method_3(l)).int_9 == gClass7.int_9)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
					GClass144.gclass88_6.method_0(gClass7);
				empty = empty + itemTemplateID + ",";
			}
			GClass50.smethod_10("sl item on map " + empty + "\n");
			GClass20.gclass88_2.method_9();
			if (GClass122.int_12 == 1)
				GClass10.smethod_0();
			GClass10.gclass88_0.method_9();
			if (GClass73.bool_1 && (!GClass73.bool_1 || !GClass20.smethod_1()) && GClass20.int_37 != 45 && GClass20.int_37 != 46 && GClass20.int_37 != 47 && GClass20.int_37 != 48)
			{
				short num5 = msg.method_1().method_6();
				for (int m = 0; m < num5; m++)
				{
					msg.method_1().method_6();
					msg.method_1().method_6();
					msg.method_1().method_6();
				}
				short num6 = msg.method_1().method_6();
				for (int n = 0; n < num6; n++)
				{
					msg.method_1().method_14();
					msg.method_1().method_14();
				}
			}
			else
			{
				short num7 = msg.method_1().method_6();
				empty = "item high graphic: ";
				for (int num8 = 0; num8 < num7; num8++)
				{
					short id = msg.method_1().method_6();
					short num9 = msg.method_1().method_6();
					short num10 = msg.method_1().method_6();
					if (GClass20.smethod_4(id) != null)
					{
						GClass10 gClass8 = GClass20.smethod_4(id);
						GClass10 gClass9 = new GClass10();
						gClass9.int_0 = id;
						gClass9.short_0 = gClass8.short_0;
						gClass9.int_4 = gClass8.int_4;
						gClass9.int_5 = gClass8.int_5;
						gClass9.int_2 = num9 * GClass20.sbyte_0;
						gClass9.int_3 = num10 * GClass20.sbyte_0;
						gClass9.sbyte_0 = gClass8.sbyte_0;
						if (GClass20.smethod_10(gClass9.int_0))
						{
							gClass9.int_1 = ((num8 % 2 != 0) ? 2 : 0);
							if (GClass20.int_37 == 45)
								gClass9.int_1 = 0;
						}
						GClass70 gClass10 = null;
						if (!GClass10.gclass113_0.method_7(gClass9.short_0 + ""))
						{
							if (GClass122.int_12 == 1)
							{
								gClass10 = GClass73.smethod_43("/mapBackGround/" + gClass9.short_0 + ".png");
								if (gClass10 == null)
								{
									gClass10 = GClass70.smethod_9(new int[1], 1, 1, true);
									GClass7.smethod_0().method_113(gClass9.short_0);
								}
								GClass10.gclass113_0.method_4(gClass9.short_0 + "", gClass10);
							}
							else
							{
								bool flag2 = false;
								sbyte[] array = GClass1.smethod_1(GClass122.int_12 + "bgItem" + gClass9.short_0);
								if (array == null)
									flag2 = true;
								else
								{
									if (GClass10.sbyte_1 != null)
									{
										GClass50.smethod_8("Small  last= " + array.Length % 127 + "new Version= " + GClass10.sbyte_1[gClass9.short_0]);
										if (array.Length % 127 != GClass10.sbyte_1[gClass9.short_0])
											flag2 = true;
									}
									if (!flag2)
									{
										gClass10 = GClass70.smethod_6(array, 0, array.Length);
										if (gClass10 == null)
											flag2 = true;
										else
											GClass10.gclass113_0.method_4(gClass9.short_0 + "", gClass10);
									}
								}
								if (flag2)
								{
									gClass10 = GClass73.smethod_43("/mapBackGround/" + gClass9.short_0 + ".png");
									if (gClass10 == null)
									{
										gClass10 = GClass70.smethod_9(new int[1], 1, 1, true);
										GClass7.smethod_0().method_113(gClass9.short_0);
									}
									GClass10.gclass113_0.method_4(gClass9.short_0 + "", gClass10);
								}
							}
							GClass10.gclass88_1.method_0(gClass9.short_0 + "");
						}
						if (!GClass10.smethod_1(gClass9.short_0 + ""))
							GClass10.gclass88_0.method_0(gClass9.short_0 + "");
						gClass9.method_2();
						GClass20.gclass88_2.method_0(gClass9);
					}
					empty = empty + id + ",";
				}
				GClass50.smethod_10("item High Graphics: " + empty);
				for (int num11 = 0; num11 < GClass10.gclass88_1.method_2(); num11++)
				{
					string text = (string)GClass10.gclass88_1.method_3(num11);
					if (!GClass10.smethod_1(text))
					{
						GClass10.gclass113_0.method_5(text);
						if (GClass10.gclass113_0.method_7(text + "blend" + 1))
							GClass10.gclass113_0.method_5(text + "blend" + 1);
						if (GClass10.gclass113_0.method_7(text + "blend" + 3))
							GClass10.gclass113_0.method_5(text + "blend" + 3);
						GClass10.gclass88_1.method_7(num11);
						num11--;
					}
				}
				GClass34.bool_3 = false;
				GClass34.int_40 = 0;
				GClass57.gclass88_0.method_9();
				GClass34.gclass88_0.method_9();
				GClass81.gclass88_2.method_9();
				short num12 = msg.method_1().method_6();
				for (int num13 = 0; num13 < num12; num13++)
				{
					method_11(msg.method_1().method_14(), msg.method_1().method_14());
				}
			}
			GClass20.int_41 = msg.method_1().method_2();
			method_9(msg.method_1().method_2());
			GClass78.bool_35 = false;
			GClass73.smethod_8("SA75x8", 2);
			Resources.UnloadUnusedAssets();
			GC.Collect();
			GClass50.smethod_8("[ LOAD INFO MAP ]    [DONE]   in game");
		}
		catch (Exception ex)
		{
			GClass148.smethod_0().method_7();
			GClass50.smethod_10("[error] [TAI LOADMAP INFO]" + ex.StackTrace + ex.Message);
		}
	}

	public void method_11(string key, string value)
	{
		if (!key.Equals("eff"))
		{
			if (key.Equals("beff") && GClass76.int_36 <= 1)
				GClass34.smethod_7(int.Parse(value));
		}
		else
		{
			if (GClass76.int_36 > 0)
				return;
			string[] array = GClass50.smethod_30(value, ".", 0);
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
			GClass81 gClass = new GClass81(id, x, y, layer, loop, loopCount);
			if (array.Length > 6)
			{
				gClass.int_1 = int.Parse(array[6]);
				if (array.Length > 7)
				{
					gClass.int_2 = int.Parse(array[7]);
					gClass.int_3 = int.Parse(array[8]);
				}
			}
			GClass57.smethod_0(gClass);
		}
	}

	public void method_12(GClass208 msg)
	{
		GClass73.smethod_8("SA6", 2);
		try
		{
			sbyte b = msg.method_1().method_2();
			GClass50.smethod_8("---messageNotMap : " + b);
			sbyte b2 = b;
			switch (b2)
			{
			case 4:
			{
				GClass73.smethod_8("SA8", 2);
				GClass73.gclass133_0.method_10();
				GClass144.bool_68 = false;
				GClass144.bool_69 = false;
				GClass133.bool_4 = true;
				GClass133.bool_5 = true;
				GClass133.bool_6 = true;
				GClass133.bool_7 = true;
				GClass133.bool_8 = true;
				GClass144.sbyte_4 = msg.method_1().method_2();
				GClass144.sbyte_5 = msg.method_1().method_2();
				GClass144.sbyte_6 = msg.method_1().method_2();
				GClass144.sbyte_7 = msg.method_1().method_2();
				msg.method_1().method_2();
				if (GClass73.gclass133_0.bool_12)
				{
					GClass1.smethod_4("acc", "");
					GClass1.smethod_4("pass", "");
				}
				else
					GClass1.smethod_4("userAo" + GClass134.int_14, "");
				if (GClass144.sbyte_4 != GClass144.sbyte_0)
				{
					GClass144.bool_2 = false;
					GClass7.smethod_0().method_79();
				}
				else
					try
					{
						GClass133.bool_5 = false;
					}
					catch (Exception)
					{
						GClass144.sbyte_0 = -1;
						GClass7.smethod_0().method_79();
					}
				if (GClass144.sbyte_5 != GClass144.sbyte_1)
				{
					GClass144.bool_2 = false;
					GClass7.smethod_0().method_80();
				}
				else
					try
					{
						if (!GClass144.bool_2)
							method_4(new GClass108(GClass1.smethod_1("NRmap")).gclass100_0);
						GClass133.bool_6 = false;
					}
					catch (Exception)
					{
						GClass144.sbyte_1 = -1;
						GClass7.smethod_0().method_80();
					}
				if (GClass144.sbyte_6 != GClass144.sbyte_2)
				{
					GClass144.bool_2 = false;
					GClass7.smethod_0().method_81();
				}
				else
					try
					{
						if (!GClass144.bool_2)
							method_3(new GClass108(GClass1.smethod_1("NRskill")).gclass100_0);
						GClass133.bool_7 = false;
					}
					catch (Exception)
					{
						GClass144.sbyte_2 = -1;
						GClass7.smethod_0().method_81();
					}
				if (GClass144.sbyte_7 == GClass144.sbyte_3)
					try
					{
						method_19(new GClass108(GClass1.smethod_1("NRitem0")).gclass100_0, 0, false);
						method_19(new GClass108(GClass1.smethod_1("NRitem1")).gclass100_0, 1, false);
						method_19(new GClass108(GClass1.smethod_1("NRitem2")).gclass100_0, 2, false);
						method_19(new GClass108(GClass1.smethod_1("NRitem100")).gclass100_0, 100, false);
						GClass133.bool_8 = false;
					}
					catch (Exception)
					{
						GClass144.sbyte_3 = -1;
						GClass7.smethod_0().method_82();
					}
				else
				{
					GClass144.bool_2 = false;
					GClass7.smethod_0().method_82();
				}
				if (GClass144.sbyte_4 == GClass144.sbyte_0 && GClass144.sbyte_5 == GClass144.sbyte_1 && GClass144.sbyte_6 == GClass144.sbyte_2 && GClass144.sbyte_7 == GClass144.sbyte_3)
				{
					if (!GClass144.bool_2)
					{
						GClass144.smethod_8().method_22();
						GClass144.smethod_8().method_20();
						GClass144.smethod_8().method_21();
						GClass144.smethod_8().method_23();
					}
					GClass7.smethod_0().method_83();
				}
				sbyte b3 = msg.method_1().method_2();
				GClass50.smethod_8("CAPTION LENT= " + b3);
				GClass144.long_2 = new long[b3];
				for (int j = 0; j < GClass144.long_2.Length; j++)
				{
					GClass144.long_2[j] = msg.method_1().method_9();
				}
				return;
			}
			case 6:
			{
				GClass50.smethod_8("GET UPDATE_MAP " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_4(msg.method_1());
				msg.method_1().method_4();
				sbyte[] data2 = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data2);
				GClass1.smethod_0("NRmap", data2);
				GClass1.smethod_0("NRmapVersion", new sbyte[1] { GClass144.sbyte_1 });
				GClass133.bool_6 = false;
				if (GClass144.sbyte_4 == GClass144.sbyte_0 && GClass144.sbyte_5 == GClass144.sbyte_1 && GClass144.sbyte_6 == GClass144.sbyte_2 && GClass144.sbyte_7 == GClass144.sbyte_3)
				{
					GClass144.smethod_8().method_22();
					GClass144.smethod_8().method_20();
					GClass144.smethod_8().method_21();
					GClass144.smethod_8().method_23();
					GClass7.smethod_0().method_83();
				}
				return;
			}
			case 7:
			{
				GClass50.smethod_8("GET UPDATE_SKILL " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_3(msg.method_1());
				msg.method_1().method_4();
				sbyte[] data = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data);
				GClass1.smethod_0("NRskill", data);
				GClass1.smethod_0("NRskillVersion", new sbyte[1] { GClass144.sbyte_2 });
				GClass133.bool_7 = false;
				if (GClass144.sbyte_4 == GClass144.sbyte_0 && GClass144.sbyte_5 == GClass144.sbyte_1 && GClass144.sbyte_6 == GClass144.sbyte_2 && GClass144.sbyte_7 == GClass144.sbyte_3)
				{
					GClass144.smethod_8().method_22();
					GClass144.smethod_8().method_20();
					GClass144.smethod_8().method_21();
					GClass144.smethod_8().method_23();
					GClass7.smethod_0().method_83();
				}
				return;
			}
			case 8:
				GClass50.smethod_8("GET UPDATE_ITEM " + msg.method_1().method_18() + " bytes");
				method_18(msg.method_1());
				return;
			case 9:
				GClass73.smethod_8("SA11", 2);
				return;
			case 10:
				try
				{
					GClass78.bool_35 = true;
					GClass50.smethod_8("REQUEST MAP TEMPLATE");
					GClass73.bool_4 = true;
					GClass20.int_27 = null;
					GClass20.int_28 = null;
					GClass203.smethod_26();
					GClass73.smethod_8("SA99", 2);
					GClass20.int_21 = msg.method_1().method_2();
					GClass20.int_22 = msg.method_1().method_2();
					GClass20.int_27 = new int[GClass20.int_21 * GClass20.int_22];
					GClass50.smethod_10("   M apsize= " + GClass20.int_21 * GClass20.int_22);
					for (int i = 0; i < GClass20.int_27.Length; i++)
					{
						int num2 = msg.method_1().method_2();
						if (num2 < 0)
							num2 += 256;
						GClass20.int_27[i] = (ushort)num2;
					}
					GClass20.int_28 = new int[GClass20.int_27.Length];
					msg = gclass208_0;
					method_10(msg);
					try
					{
						GClass20.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
					}
					catch (Exception ex)
					{
						GClass50.smethod_10(" 1 LOI TAI CASE REQUEST_MAPTEMPLATE " + ex.ToString());
					}
				}
				catch (Exception ex2)
				{
					GClass50.smethod_10("2 LOI TAI CASE REQUEST_MAPTEMPLATE " + ex2.ToString());
				}
				msg.method_4();
				gclass208_0.method_4();
				msg = (gclass208_0 = null);
				GClass144.smethod_8().switchToMe();
				return;
			case 12:
				GClass73.smethod_8("SA10", 2);
				return;
			case 16:
				GClass143.smethod_2().switchToMe();
				return;
			case 17:
				GClass73.smethod_8("SYB123", 2);
				GClass78.smethod_1().method_120();
				return;
			case 18:
			{
				GClass73.bool_4 = false;
				GClass73.smethod_29();
				int num = msg.method_1().method_8();
				GClass73.gclass43_0.method_0(mResources.changeNameChar, new GClass87(mResources.OK, GClass73.gclass73_0, 88829, num), GClass191.int_11);
				return;
			}
			case 20:
				GClass78.smethod_1().sbyte_18 = msg.method_1().method_2();
				GClass144.gclass52_0.method_7(mResources.PK_NOW + " " + GClass78.smethod_1().sbyte_18, 0);
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
					GClass144.sbyte_10 = msg.method_1().method_2();
					GClass50.smethod_8("load Me Active: " + GClass144.sbyte_10);
				}
			}
			else
			{
				GClass73.smethod_29();
				GClass144.smethod_8().method_34();
				GClass144.gclass52_0.method_7(msg.method_1().method_14(), 0);
			}
		}
		catch (Exception)
		{
			GClass36.smethod_2("LOI TAI messageNotMap + " + msg.sbyte_0);
		}
		finally
		{
			msg?.method_4();
		}
	}

	public void method_13(GClass208 msg)
	{
		try
		{
			sbyte b = msg.method_1().method_2();
			GClass50.smethod_8("---messageNotLogin : " + b);
			if (b != 2)
				return;
			string string_ = msg.method_1().method_14();
			if (GClass1.smethod_8("AdminLink") != 1)
			{
				if (GClass203.int_0 == 1)
					GClass134.string_9 = string_;
				else
					GClass134.string_9 = string_;
				GClass203.smethod_0();
				GClass134.smethod_4(GClass134.string_9);
				try
				{
					GClass76.bool_6 = msg.method_1().method_2() == 1;
					GClass1.smethod_9("AdminLink", msg.method_1().method_2());
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

	public void method_14(GClass208 msg)
	{
		try
		{
			GClass73.smethod_8("SA12", 2);
			sbyte b = msg.method_1().method_2();
			GClass50.smethod_8("---messageSubCommand : " + b);
			sbyte b2 = b;
			switch (b2)
			{
			case 0:
			{
				GClass73.smethod_8("SA21", 2);
				GClass135.gclass88_0 = new GClass88();
				GClass23.gclass88_0.method_9();
				GClass144.gclass88_5.method_9();
				GClass144.gclass88_6.method_9();
				GClass78.gclass88_5.method_9();
				GClass144.smethod_26();
				GClass144.gclass78_0 = GClass78.smethod_1();
				GClass78.smethod_1().int_13 = msg.method_1().method_8();
				GClass78.smethod_1().int_15 = msg.method_1().method_2();
				GClass78.smethod_1().int_14 = msg.method_1().method_2();
				GClass78.smethod_1().int_119 = msg.method_1().method_6();
				GClass78.smethod_1().string_3 = msg.method_1().method_14();
				GClass78.smethod_1().sbyte_18 = msg.method_1().method_2();
				GClass78.smethod_1().sbyte_19 = msg.method_1().method_2();
				GClass78.smethod_1().long_2 = msg.method_1().method_9();
				GClass78.smethod_1().method_4();
				GClass78.smethod_1().int_33 = msg.method_1().method_6();
				GClass78.smethod_1().int_34 = msg.method_1().method_6();
				GClass78.smethod_1().gclass176_0 = GClass144.gclass176_0[msg.method_1().method_2()];
				GClass78.smethod_1().gclass88_0.method_9();
				GClass78.smethod_1().gclass88_1.method_9();
				GClass144.smethod_8().int_146 = GClass78.smethod_1().int_25;
				GClass144.smethod_8().int_144 = GClass78.smethod_1().int_24;
				sbyte b4 = msg.method_1().method_2();
				for (sbyte b5 = 0; b5 < b4; b5++)
				{
					method_15(GClass99.smethod_1(msg.method_1().method_6()));
				}
				GClass144.smethod_8().method_65();
				GClass144.smethod_8().method_4();
				GClass78.smethod_1().long_6 = msg.method_1().method_9();
				GClass78.smethod_1().int_69 = msg.method_1().method_8();
				GClass78.smethod_1().int_68 = msg.method_1().method_8();
				GClass78.smethod_1().string_0 = GClass203.smethod_6(GClass78.smethod_1().long_6);
				GClass78.smethod_1().string_1 = GClass203.smethod_6(GClass78.smethod_1().int_68);
				GClass78.smethod_1().string_2 = GClass203.smethod_6(GClass78.smethod_1().int_69);
				GClass78.smethod_1().gclass128_2 = new GClass128[msg.method_1().method_2()];
				try
				{
					GClass78.smethod_1().method_61();
					for (int j = 0; j < GClass78.smethod_1().gclass128_2.Length; j++)
					{
						short num2 = msg.method_1().method_6();
						if (num2 == -1)
							continue;
						GClass117 gClass6 = GClass0.smethod_1(num2);
						int num3 = gClass6.sbyte_0;
						GClass78.smethod_1().gclass128_2[j] = new GClass128();
						GClass78.smethod_1().gclass128_2[j].gclass117_0 = gClass6;
						GClass78.smethod_1().gclass128_2[j].int_30 = msg.method_1().method_8();
						GClass78.smethod_1().gclass128_2[j].string_0 = msg.method_1().method_14();
						GClass78.smethod_1().gclass128_2[j].string_1 = msg.method_1().method_14();
						int num4 = msg.method_1().method_5();
						if (num4 != 0)
						{
							GClass78.smethod_1().gclass128_2[j].gclass120_0 = new GClass120[num4];
							for (int k = 0; k < GClass78.smethod_1().gclass128_2[j].gclass120_0.Length; k++)
							{
								int optionTemplateId = msg.method_1().method_5();
								int param = msg.method_1().method_7();
								GClass78.smethod_1().gclass128_2[j].gclass120_0[k] = new GClass120(optionTemplateId, param);
							}
						}
						int num5 = num3;
						if (num5 == 0)
						{
							GClass50.smethod_8("toi day =======================================" + GClass78.smethod_1().int_121);
							GClass78.smethod_1().int_121 = GClass78.smethod_1().gclass128_2[j].gclass117_0.short_2;
						}
						else if (num5 == 1)
						{
							GClass78.smethod_1().int_120 = GClass78.smethod_1().gclass128_2[j].gclass117_0.short_2;
							GClass50.smethod_8("toi day =======================================" + GClass78.smethod_1().int_120);
						}
					}
				}
				catch (Exception)
				{
				}
				GClass78.smethod_1().gclass128_0 = new GClass128[msg.method_1().method_2()];
				GClass144.int_37 = 0;
				for (int l = 0; l < GClass78.smethod_1().gclass128_0.Length; l++)
				{
					short num6 = msg.method_1().method_6();
					if (num6 == -1)
						continue;
					GClass78.smethod_1().gclass128_0[l] = new GClass128();
					GClass78.smethod_1().gclass128_0[l].gclass117_0 = GClass0.smethod_1(num6);
					GClass78.smethod_1().gclass128_0[l].int_30 = msg.method_1().method_8();
					GClass78.smethod_1().gclass128_0[l].string_0 = msg.method_1().method_14();
					GClass78.smethod_1().gclass128_0[l].string_1 = msg.method_1().method_14();
					GClass78.smethod_1().gclass128_0[l].int_29 = l;
					sbyte b6 = msg.method_1().method_2();
					if (b6 != 0)
					{
						GClass78.smethod_1().gclass128_0[l].gclass120_0 = new GClass120[b6];
						for (int m = 0; m < GClass78.smethod_1().gclass128_0[l].gclass120_0.Length; m++)
						{
							int optionTemplateId2 = msg.method_1().method_5();
							int param2 = msg.method_1().method_7();
							GClass78.smethod_1().gclass128_0[l].gclass120_0[m] = new GClass120(optionTemplateId2, param2);
							GClass78.smethod_1().gclass128_0[l].method_6();
						}
					}
					if (GClass78.smethod_1().gclass128_0[l].gclass117_0.sbyte_0 == 6)
						GClass144.int_37 += GClass78.smethod_1().gclass128_0[l].int_30;
				}
				GClass78.smethod_1().gclass128_1 = new GClass128[msg.method_1().method_2()];
				GClass73.gclass76_0.int_39 = 0;
				for (int n = 0; n < GClass78.smethod_1().gclass128_1.Length; n++)
				{
					short num7 = msg.method_1().method_6();
					if (num7 != -1)
					{
						GClass78.smethod_1().gclass128_1[n] = new GClass128();
						GClass78.smethod_1().gclass128_1[n].gclass117_0 = GClass0.smethod_1(num7);
						GClass78.smethod_1().gclass128_1[n].int_30 = msg.method_1().method_8();
						GClass78.smethod_1().gclass128_1[n].string_0 = msg.method_1().method_14();
						GClass78.smethod_1().gclass128_1[n].string_1 = msg.method_1().method_14();
						GClass78.smethod_1().gclass128_1[n].gclass120_0 = new GClass120[msg.method_1().method_2()];
						for (int num8 = 0; num8 < GClass78.smethod_1().gclass128_1[n].gclass120_0.Length; num8++)
						{
							int optionTemplateId3 = msg.method_1().method_5();
							int param3 = msg.method_1().method_7();
							GClass78.smethod_1().gclass128_1[n].gclass120_0[num8] = new GClass120(optionTemplateId3, param3);
							GClass78.smethod_1().gclass128_1[n].method_6();
						}
						GClass73.gclass76_0.int_39++;
					}
				}
				GClass78.smethod_1().int_11 = 4;
				if (GClass1.smethod_8(GClass78.smethod_1().string_3 + "vci") >= 1)
					GClass144.bool_8 = true;
				else
					GClass144.bool_8 = false;
				short num9 = msg.method_1().method_6();
				GClass78.short_12 = new short[num9];
				GClass78.short_13 = new short[num9];
				for (int num10 = 0; num10 < num9; num10++)
				{
					GClass78.short_12[num10] = msg.method_1().method_6();
					GClass78.short_13[num10] = msg.method_1().method_6();
				}
				for (int num11 = 0; num11 < GClass144.gclass52_0.int_0.Length; num11++)
				{
					GClass144.gclass52_0.int_0[num11] = new int[3];
				}
				GClass144.gclass52_0.int_0[GClass78.smethod_1().int_14][0] = msg.method_1().method_6();
				GClass144.gclass52_0.int_0[GClass78.smethod_1().int_14][1] = msg.method_1().method_6();
				GClass144.gclass52_0.int_0[GClass78.smethod_1().int_14][2] = msg.method_1().method_6();
				GClass78.smethod_1().bool_4 = msg.method_1().method_2() == 1;
				GClass50.smethod_8("NHAP THE= " + GClass78.smethod_1().bool_4);
				GClass144.long_3 = GClass203.smethod_18() - msg.method_1().method_8() * 1000L;
				GClass144.sbyte_13 = msg.method_1().method_2();
				GClass7.smethod_0().method_29((sbyte)GClass78.smethod_1().int_14);
				GClass7.smethod_0().method_1();
				try
				{
					GClass78.smethod_1().short_28 = msg.method_1().method_6();
					GClass78.smethod_1().short_29 = msg.method_1().method_0();
					GClass78.smethod_1().short_30 = msg.method_1().method_6();
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			case 1:
				GClass73.smethod_8("SA13", 2);
				GClass78.smethod_1().gclass176_0 = GClass144.gclass176_0[msg.method_1().method_2()];
				GClass78.smethod_1().long_4 = msg.method_1().method_9();
				GClass78.smethod_1().gclass88_0.method_9();
				GClass78.smethod_1().gclass88_1.method_9();
				GClass78.smethod_1().gclass63_0 = null;
				return;
			case 2:
			{
				GClass73.smethod_8("SA14", 2);
				if (GClass78.smethod_1().int_11 != 14 && GClass78.smethod_1().int_11 != 5)
				{
					GClass78.smethod_1().int_25 = GClass78.smethod_1().int_35;
					GClass78.smethod_1().int_24 = GClass78.smethod_1().int_36;
					GClass36.smethod_3(" ME_LOAD_SKILL");
				}
				GClass78.smethod_1().gclass88_0.method_9();
				GClass78.smethod_1().gclass88_1.method_9();
				sbyte b7 = msg.method_1().method_2();
				for (sbyte b8 = 0; b8 < b7; b8++)
				{
					method_15(GClass99.smethod_1(msg.method_1().method_6()));
				}
				GClass144.smethod_8().method_65();
				if (GClass144.bool_19)
				{
					GClass144.int_45 = -1;
					GClass144.smethod_8().gclass87_0 = (GClass144.smethod_8().gclass87_1 = null);
				}
				return;
			}
			case 4:
				GClass73.smethod_8("SA23", 2);
				GClass78.smethod_1().long_6 = msg.method_1().method_9();
				GClass78.smethod_1().int_68 = msg.method_1().method_8();
				GClass78.smethod_1().int_25 = msg.method_3();
				GClass78.smethod_1().int_24 = msg.method_3();
				GClass78.smethod_1().int_69 = msg.method_1().method_8();
				GClass78.smethod_1().string_0 = GClass203.smethod_6(GClass78.smethod_1().long_6);
				GClass78.smethod_1().string_1 = GClass203.smethod_6(GClass78.smethod_1().int_68);
				GClass78.smethod_1().string_2 = GClass203.smethod_6(GClass78.smethod_1().int_69);
				return;
			case 5:
			{
				GClass73.smethod_8("SA24", 2);
				int int_ = GClass78.smethod_1().int_25;
				GClass78.smethod_1().int_25 = msg.method_3();
				if (GClass78.smethod_1().int_25 > int_ && GClass78.smethod_1().sbyte_19 != 4)
				{
					GClass144.smethod_19("+" + (GClass78.smethod_1().int_25 - int_) + " " + mResources.HP, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58 - 20, 0, -1, GClass4.int_12);
					GClass109.smethod_1().method_3();
					if (GClass78.smethod_1().gclass82_0 != null && GClass78.smethod_1().gclass82_0.short_0 == 5003)
						GClass94.smethod_0(GClass78.smethod_1().gclass82_0.int_9 + ((GClass78.smethod_1().gclass82_0.int_0 != 1) ? (-10) : 10), GClass78.smethod_1().gclass82_0.int_4 + 10, true, -1, -1, GClass78.smethod_1(), 29);
				}
				if (GClass78.smethod_1().int_25 < int_)
					GClass144.smethod_19("-" + (int_ - GClass78.smethod_1().int_25) + " " + mResources.HP, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58 - 20, 0, -1, GClass4.int_12);
				GClass144.smethod_8().int_146 = GClass78.smethod_1().int_25;
				if (GClass144.bool_19)
					;
				return;
			}
			case 6:
			{
				GClass73.smethod_8("SA25", 2);
				if (GClass78.smethod_1().int_11 == 14 || GClass78.smethod_1().int_11 == 5)
					return;
				int int_2 = GClass78.smethod_1().int_24;
				GClass78.smethod_1().int_24 = msg.method_3();
				if (GClass78.smethod_1().int_24 > int_2)
				{
					GClass144.smethod_19("+" + (GClass78.smethod_1().int_24 - int_2) + " " + mResources.KI, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58 - 23, 0, -2, GClass4.int_13);
					GClass109.smethod_1().method_3();
					if (GClass78.smethod_1().gclass82_0 != null && GClass78.smethod_1().gclass82_0.short_0 == 5001)
						GClass94.smethod_0(GClass78.smethod_1().gclass82_0.int_9 + ((GClass78.smethod_1().gclass82_0.int_0 != 1) ? (-10) : 10), GClass78.smethod_1().gclass82_0.int_4 + 10, true, -1, -1, GClass78.smethod_1(), 29);
				}
				if (GClass78.smethod_1().int_24 < int_2)
					GClass144.smethod_19("-" + (int_2 - GClass78.smethod_1().int_24) + " " + mResources.KI, GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - GClass78.smethod_1().int_58 - 23, 0, -2, GClass4.int_13);
				GClass50.smethod_8("curr MP= " + GClass78.smethod_1().int_24);
				GClass144.smethod_8().int_144 = GClass78.smethod_1().int_24;
				if (!GClass144.bool_19)
					;
				return;
			}
			case 7:
			{
				GClass78 gClass13 = GClass144.smethod_14(msg.method_1().method_8());
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
					GClass81 gClass14 = new GClass81(gClass13.int_122, gClass13, 2, -1, 10, 1);
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
				GClass73.smethod_8("SA26", 2);
				GClass78 gClass8 = GClass144.smethod_14(msg.method_1().method_8());
				if (gClass8 != null)
					gClass8.int_18 = msg.method_1().method_2();
				return;
			}
			case 9:
			{
				GClass73.smethod_8("SA27", 2);
				GClass78 gClass10 = GClass144.smethod_14(msg.method_1().method_8());
				if (gClass10 != null)
				{
					gClass10.int_25 = msg.method_3();
					gClass10.int_35 = msg.method_3();
				}
				return;
			}
			case 10:
			{
				GClass73.smethod_8("SA28", 2);
				GClass78 gClass5 = GClass144.smethod_14(msg.method_1().method_8());
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
				GClass73.smethod_8("SA29", 2);
				GClass78 gClass9 = GClass144.smethod_14(msg.method_1().method_8());
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
				GClass73.smethod_8("SA30", 2);
				GClass78 gClass12 = GClass144.smethod_14(msg.method_1().method_8());
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
				GClass73.smethod_8("SA31", 2);
				int num12 = msg.method_1().method_8();
				GClass78 gClass7 = ((num12 != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num12) : GClass78.smethod_1());
				if (gClass7 != null)
				{
					gClass7.int_25 = msg.method_3();
					gClass7.int_35 = msg.method_3();
					gClass7.int_33 = msg.method_1().method_6();
					gClass7.int_34 = msg.method_1().method_6();
				}
				return;
			}
			case 14:
			{
				GClass73.smethod_8("SA32", 2);
				GClass78 gClass4 = GClass144.smethod_14(msg.method_1().method_8());
				if (gClass4 != null)
				{
					gClass4.int_25 = msg.method_3();
					sbyte b3 = msg.method_1().method_2();
					GClass50.smethod_8("player load hp type= " + b3);
					if (b3 == 1)
					{
						GClass97.smethod_3(11, gClass4, 5);
						GClass97.smethod_3(104, gClass4, 4);
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
				GClass73.smethod_8("SA33", 2);
				GClass78 gClass3 = GClass144.smethod_14(msg.method_1().method_8());
				if (gClass3 != null)
				{
					gClass3.int_25 = msg.method_3();
					gClass3.int_35 = msg.method_3();
					gClass3.int_4 = msg.method_1().method_6();
					gClass3.int_5 = msg.method_1().method_6();
					gClass3.int_11 = 1;
					gClass3.int_10 = 3;
					GClass97.smethod_3(109, gClass3, 2);
				}
				return;
			}
			case 19:
				GClass73.smethod_8("SA17", 2);
				GClass78.smethod_1().method_14();
				return;
			case 21:
			{
				GClass73.smethod_8("SA19", 2);
				int num14 = msg.method_1().method_8();
				GClass78.smethod_1().int_65 -= num14;
				GClass78.smethod_1().long_6 += num14;
				GClass78.smethod_1().string_0 = GClass203.smethod_6(GClass78.smethod_1().long_6);
				return;
			}
			case 23:
			{
				short num13 = msg.method_1().method_6();
				GClass63 gClass11 = GClass99.smethod_1(num13);
				method_15(gClass11);
				if (num13 != 0 && num13 != 14 && num13 != 28)
					GClass144.gclass52_0.method_7(mResources.LEARN_SKILL + " " + gClass11.gclass47_0.string_0, 0);
				return;
			}
			case 35:
			{
				GClass73.smethod_8("SY3", 2);
				int num = msg.method_1().method_8();
				GClass50.smethod_8("CID = " + num);
				if (GClass20.int_37 == 130)
					GClass144.smethod_8().method_91();
				if (num != GClass78.smethod_1().int_13)
				{
					GClass78 gClass = GClass144.smethod_14(num);
					if (gClass != null)
					{
						GClass50.smethod_8("type pk= " + gClass.sbyte_19);
						gClass.sbyte_19 = msg.method_1().method_2();
						if (gClass.method_105())
							GClass78.smethod_1().gclass78_0 = gClass;
					}
				}
				else
				{
					GClass78.smethod_1().sbyte_19 = msg.method_1().method_2();
					if (GClass144.smethod_8().method_95() && GClass78.smethod_1().sbyte_19 != 0)
						GClass144.smethod_8().method_91();
					GClass50.smethod_8("type pk= " + GClass78.smethod_1().sbyte_19);
					GClass78.smethod_1().gclass79_0 = null;
					if (!GClass144.smethod_8().method_31(GClass78.smethod_1().gclass194_0))
						GClass78.smethod_1().gclass194_0 = null;
					GClass78.smethod_1().gclass64_0 = null;
				}
				for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
				{
					GClass78 gClass2 = GClass144.smethod_14(i);
					if (gClass2 != null && gClass2.sbyte_19 != 0 && gClass2.sbyte_19 == GClass78.smethod_1().sbyte_19)
					{
						if (!GClass78.smethod_1().gclass194_0.bool_13)
							GClass78.smethod_1().gclass194_0 = null;
						GClass78.smethod_1().gclass79_0 = null;
						GClass78.smethod_1().gclass64_0 = null;
						break;
					}
				}
				GClass50.smethod_8("update type pk= ");
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
					GClass144.smethod_8().method_6(data);
				else if (text.Equals("OSkill"))
				{
					GClass144.smethod_8().method_5(data);
				}
				else if (text.Equals("CSkill"))
				{
					GClass144.smethod_8().method_7(data);
				}
				break;
			}
			case 62:
				GClass50.smethod_8("ME UPDATE SKILL");
				method_25(msg);
				break;
			case 63:
			{
				sbyte b9 = msg.method_1().method_2();
				if (b9 > 0)
				{
					GClass73.gclass76_0.gclass88_11.method_9();
					GClass130.smethod_1();
					GClass88 gclass88_ = GClass73.gclass76_0.gclass88_4;
					for (int num15 = 0; num15 < b9; num15++)
					{
						string caption = msg.method_1().method_14();
						string string_ = msg.method_1().method_14();
						short int_3 = msg.method_1().method_6();
						GClass73.gclass76_0.gclass88_11.method_0(int_3 + "");
						GClass78.smethod_1().gclass78_0.int_16 = int_3;
						GClass87 gClass15 = new GClass87(caption, 11115, GClass78.smethod_1().gclass78_0);
						gClass15.string_2 = string_;
						gclass88_.method_0(gClass15);
					}
					GClass130.smethod_5();
					GClass73.gclass76_0.method_21();
				}
				break;
			}
			}
		}
		catch (Exception ex5)
		{
			GClass36.smethod_0("Loi tai Sub : " + ex5.ToString());
		}
		finally
		{
			msg?.method_4();
		}
	}

	private void method_15(GClass63 gclass63_0)
	{
		if (GClass78.smethod_1().gclass63_0 != null)
		{
			if (gclass63_0.gclass47_0.Equals(GClass78.smethod_1().gclass63_0.gclass47_0))
				GClass78.smethod_1().gclass63_0 = gclass63_0;
		}
		else
			GClass78.smethod_1().gclass63_0 = gclass63_0;
		GClass78.smethod_1().gclass88_0.method_0(gclass63_0);
		if ((gclass63_0.gclass47_0.int_3 == 1 || gclass63_0.gclass47_0.int_3 == 4 || gclass63_0.gclass47_0.int_3 == 2 || gclass63_0.gclass47_0.int_3 == 3) && (gclass63_0.gclass47_0.int_1 == 0 || (gclass63_0.gclass47_0.int_1 > 0 && gclass63_0.int_0 > 0)))
		{
			if (gclass63_0.gclass47_0.sbyte_0 == GClass78.smethod_1().int_71)
				GClass7.smethod_0().method_56(GClass78.smethod_1().int_71);
			GClass78.smethod_1().gclass88_1.method_0(gclass63_0);
		}
	}

	public bool method_16(GClass78 c, GClass208 msg)
	{
		try
		{
			c.int_23 = msg.method_1().method_2();
			c.bool_20 = msg.method_1().method_11();
			c.sbyte_19 = msg.method_1().method_2();
			GClass50.smethod_8("ADD TYPE PK= " + c.sbyte_19 + " to player " + c.int_13 + " @@ " + c.string_3);
			c.gclass176_0 = GClass144.gclass176_0[msg.method_1().method_2()];
			c.int_14 = msg.method_1().method_2();
			c.int_119 = msg.method_1().method_6();
			c.string_3 = msg.method_1().method_14();
			c.int_25 = msg.method_3();
			c.int_163 = c.int_25;
			if (c.int_25 == 0)
				c.int_11 = 14;
			c.int_35 = msg.method_3();
			if (c.int_5 >= GClass20.int_24 - 100)
				c.bool_24 = true;
			c.int_121 = msg.method_1().method_6();
			c.int_120 = msg.method_1().method_6();
			c.int_122 = msg.method_1().method_5();
			GClass50.smethod_8(" body= " + c.int_121 + " leg= " + c.int_120 + " bag=" + c.int_122 + "BAG ==" + c.int_122 + "*********************************");
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
				GClass25 gClass = new GClass25(msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_8(), msg.method_1().method_6());
				c.gclass88_2.method_0(gClass);
				if (gClass.gclass67_1.sbyte_1 == 12 || gClass.gclass67_1.sbyte_1 == 11)
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

	private void method_17(GClass208 gclass208_1)
	{
		try
		{
			string text = gclass208_1.method_1().method_14();
			sbyte nFrame = gclass208_1.method_1().method_2();
			sbyte[] array = null;
			array = GClass65.smethod_2(gclass208_1);
			GClass55.smethod_0(text, method_6(array), nFrame);
			if (array != null)
				GClass55.smethod_3(text, nFrame, array);
		}
		catch (Exception)
		{
		}
	}

	private void method_18(GClass100 gclass100_0)
	{
		try
		{
			method_19(gclass100_0, -1, true);
		}
		catch (Exception)
		{
		}
	}

	private void method_19(GClass100 gclass100_0, sbyte sbyte_6, bool bool_6)
	{
		try
		{
			gclass100_0.method_3(100000);
			GClass144.sbyte_3 = gclass100_0.method_2();
			sbyte_6 = gclass100_0.method_2();
			if (sbyte_6 == 0)
			{
				GClass144.smethod_8().gclass126_0 = new GClass126[gclass100_0.method_5()];
				for (int i = 0; i < GClass144.smethod_8().gclass126_0.Length; i++)
				{
					GClass144.smethod_8().gclass126_0[i] = new GClass126();
					GClass144.smethod_8().gclass126_0[i].int_0 = i;
					GClass144.smethod_8().gclass126_0[i].string_0 = gclass100_0.method_14();
					GClass144.smethod_8().gclass126_0[i].int_1 = gclass100_0.method_2();
				}
				if (bool_6)
				{
					gclass100_0.method_4();
					sbyte[] data = new sbyte[gclass100_0.method_18()];
					gclass100_0.method_17(ref data);
					GClass1.smethod_0("NRitem0", data);
				}
			}
			else if (sbyte_6 == 1)
			{
				GClass0.gclass113_0.method_1();
				int num = gclass100_0.method_6();
				for (int j = 0; j < num; j++)
				{
					GClass0.smethod_0(new GClass117((short)j, gclass100_0.method_2(), gclass100_0.method_2(), gclass100_0.method_14(), gclass100_0.method_14(), gclass100_0.method_2(), gclass100_0.method_8(), gclass100_0.method_6(), gclass100_0.method_6(), gclass100_0.method_11()));
				}
				if (bool_6)
				{
					gclass100_0.method_4();
					sbyte[] data2 = new sbyte[gclass100_0.method_18()];
					gclass100_0.method_17(ref data2);
					GClass1.smethod_0("NRitem1", data2);
				}
			}
			else if (sbyte_6 == 2)
			{
				int num2 = gclass100_0.method_6();
				int num3 = gclass100_0.method_6();
				for (int k = num2; k < num3; k++)
				{
					GClass0.smethod_0(new GClass117((short)k, gclass100_0.method_2(), gclass100_0.method_2(), gclass100_0.method_14(), gclass100_0.method_14(), gclass100_0.method_2(), gclass100_0.method_8(), gclass100_0.method_6(), gclass100_0.method_6(), gclass100_0.method_11()));
				}
				if (bool_6)
				{
					gclass100_0.method_4();
					sbyte[] data3 = new sbyte[gclass100_0.method_18()];
					gclass100_0.method_17(ref data3);
					GClass1.smethod_0("NRitem2", data3);
					GClass1.smethod_0("NRitemVersion", new sbyte[1] { GClass144.sbyte_3 });
					GClass133.bool_8 = false;
					if (GClass144.sbyte_4 == GClass144.sbyte_0 && GClass144.sbyte_5 == GClass144.sbyte_1 && GClass144.sbyte_6 == GClass144.sbyte_2 && GClass144.sbyte_7 == GClass144.sbyte_3)
					{
						GClass144.smethod_8().method_22();
						GClass144.smethod_8().method_20();
						GClass144.smethod_8().method_21();
						GClass144.smethod_8().method_23();
						GClass7.smethod_0().method_83();
					}
				}
			}
			else if (sbyte_6 == 100)
			{
				GClass78.int_173 = method_21(gclass100_0);
				if (bool_6)
				{
					gclass100_0.method_4();
					sbyte[] data4 = new sbyte[gclass100_0.method_18()];
					gclass100_0.method_17(ref data4);
					GClass1.smethod_0("NRitem100", data4);
				}
			}
		}
		catch (Exception ex)
		{
			ex.ToString();
		}
	}

	private void method_20(GClass208 gclass208_1, int int_2)
	{
		try
		{
			int num = gclass208_1.method_1().method_2();
			int[][] array = new int[num][];
			for (int i = 0; i < num; i++)
			{
				int num2 = gclass208_1.method_1().method_2();
				array[i] = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					array[i][j] = gclass208_1.method_1().method_2();
				}
			}
			gclass113_0.method_4(int_2 + "", array);
		}
		catch (Exception)
		{
		}
	}

	private int[][] method_21(GClass100 gclass100_0)
	{
		int[][] array = new int[1][] { new int[2] { 542, 543 } };
		try
		{
			array = new int[gclass100_0.method_6()][];
			for (int i = 0; i < array.Length; i++)
			{
				int num = gclass100_0.method_2();
				array[i] = new int[num];
				for (int j = 0; j < num; j++)
				{
					array[i][j] = gclass100_0.method_6();
				}
			}
			return array;
		}
		catch (Exception)
		{
			return array;
		}
	}

	public void method_22(GClass208 msg)
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

	private void method_23(GClass208 gclass208_1, int int_2)
	{
		try
		{
			sbyte b = gclass208_1.method_1().method_2();
			if (b != 0)
			{
				if (b != 1)
				{
					if (b == 2)
					{
						sbyte b2 = gclass208_1.method_1().method_2();
						short type = 0;
						if (b2 != 1)
						{
							if (b2 == 2)
								type = 2;
						}
						else
							type = 1;
						GClass144.gclass24_0 = null;
						GClass144.smethod_35(type, -1, 0, GClass73.int_12, GClass73.int_13, 0, 0, -1, null);
					}
					else if (b != 5)
					{
						if (b == 4)
						{
							int lifeTeam = gclass208_1.method_1().method_2();
							int lifeTeam2 = gclass208_1.method_1().method_2();
							if (GClass144.gclass24_0 != null)
								GClass144.gclass24_0.method_2(int_2, lifeTeam, lifeTeam2);
						}
					}
					else
					{
						short timeSecond = gclass208_1.method_1().method_6();
						if (GClass144.gclass24_0 != null)
							GClass144.gclass24_0.method_0(int_2, timeSecond);
					}
				}
				else
				{
					int pointTeam = gclass208_1.method_1().method_8();
					int pointTeam2 = gclass208_1.method_1().method_8();
					if (GClass144.gclass24_0 != null)
						GClass144.gclass24_0.method_1(int_2, pointTeam, pointTeam2);
				}
			}
			else
			{
				short idmapPaint = gclass208_1.method_1().method_6();
				string nameTeam = gclass208_1.method_1().method_14();
				string nameTeam2 = gclass208_1.method_1().method_14();
				int maxPoint = gclass208_1.method_1().method_8();
				short timeSecond2 = gclass208_1.method_1().method_6();
				int int_3 = gclass208_1.method_1().method_2();
				GClass144.gclass24_0 = new GClass24(int_2, idmapPaint, nameTeam, nameTeam2, maxPoint, timeSecond2);
				GClass144.gclass24_0.int_6 = int_3;
				GClass144.gclass24_0.method_2(int_2, 0, 0);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_24(GClass208 msg)
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
					GClass55.smethod_1("banner_" + num2, GClass55.gclass113_0);
					GClass73.gclass113_0.method_4(num + "", v);
				}
				else if (b != 3)
				{
					if (b == 4)
					{
						string o = msg.method_1().method_14();
						GClass73.gclass88_2.method_0(o);
					}
				}
				else
				{
					short num3 = msg.method_1().method_6();
					GClass28.smethod_5(num3);
					GClass34.short_0 = num3;
				}
			}
			else
			{
				short short_ = msg.method_1().method_6();
				GClass78.smethod_1().short_30 = short_;
				GClass109.smethod_1().method_2();
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_25(GClass208 msg)
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
				for (int i = 0; i < GClass78.smethod_1().gclass88_0.method_2(); i++)
				{
					GClass63 gClass = (GClass63)GClass78.smethod_1().gclass88_0.method_3(i);
					if (gClass.short_0 == num)
					{
						gClass.short_3 = short_;
						break;
					}
				}
				return;
			}
			if (b != 1)
			{
				if (b != -1)
					return;
				GClass63 gClass2 = GClass99.smethod_1(num);
				for (int j = 0; j < GClass78.smethod_1().gclass88_0.method_2(); j++)
				{
					if (((GClass63)GClass78.smethod_1().gclass88_0.method_3(j)).gclass47_0.sbyte_0 == gClass2.gclass47_0.sbyte_0)
					{
						GClass78.smethod_1().gclass88_0.method_5(gClass2, j);
						break;
					}
				}
				for (int k = 0; k < GClass78.smethod_1().gclass88_1.method_2(); k++)
				{
					if (((GClass63)GClass78.smethod_1().gclass88_1.method_3(k)).gclass47_0.sbyte_0 == gClass2.gclass47_0.sbyte_0)
					{
						GClass78.smethod_1().gclass88_1.method_5(gClass2, k);
						break;
					}
				}
				for (int l = 0; l < GClass144.gclass63_1.Length; l++)
				{
					if (GClass144.gclass63_1[l] != null && GClass144.gclass63_1[l].gclass47_0.sbyte_0 == gClass2.gclass47_0.sbyte_0)
					{
						GClass144.gclass63_1[l] = gClass2;
						break;
					}
				}
				for (int m = 0; m < GClass144.gclass63_0.Length; m++)
				{
					if (GClass144.gclass63_0[m] != null && GClass144.gclass63_0[m].gclass47_0.sbyte_0 == gClass2.gclass47_0.sbyte_0)
					{
						GClass144.gclass63_0[m] = gClass2;
						break;
					}
				}
				if (GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == gClass2.gclass47_0.sbyte_0)
					GClass78.smethod_1().gclass63_0 = gClass2;
				GClass144.gclass52_0.method_7(mResources.hasJustUpgrade1 + gClass2.gclass47_0.string_0 + mResources.hasJustUpgrade2 + gClass2.int_0, 0);
				return;
			}
			sbyte b2 = msg.method_1().method_2();
			for (int n = 0; n < GClass78.smethod_1().gclass88_0.method_2(); n++)
			{
				GClass63 gClass3 = (GClass63)GClass78.smethod_1().gclass88_0.method_3(n);
				if (gClass3.short_0 == num)
				{
					for (int num2 = 0; num2 < 20; num2++)
					{
						GClass55.smethod_1("Skills_" + gClass3.gclass47_0.sbyte_0 + "_" + b2 + "_" + num2, GClass55.gclass113_0);
					}
					break;
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
