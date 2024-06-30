using System;
using ns0;
using ns1;
using UnityEngine;

public class GClass65 : GInterface1
{
	protected static GClass65 gclass65_0;

	protected static GClass65 gclass65_1;

	public GClass110 gclass110_0;

	public static bool bool_0 = false;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	private float float_0;

	private int int_0;

	private int int_1;

	public static bool bool_5;

	public static GClass9 gclass9_0 = new GClass9();

	public const sbyte sbyte_0 = 0;

	public const sbyte sbyte_1 = 0;

	public const sbyte sbyte_2 = 1;

	public const sbyte sbyte_3 = 2;

	public const sbyte sbyte_4 = 4;

	public const sbyte sbyte_5 = 5;

	public static GClass65 smethod_0()
	{
		if (gclass65_0 == null)
			gclass65_0 = new GClass65();
		return gclass65_0;
	}

	public static GClass65 smethod_1()
	{
		if (gclass65_1 == null)
			gclass65_1 = new GClass65();
		return gclass65_1;
	}

	public void onConnectOK(bool isMain1)
	{
		bool_4 = isMain1;
		GClass138.smethod_28();
	}

	public void onConnectionFail(bool isMain1)
	{
		bool_4 = isMain1;
		GClass138.smethod_29();
	}

	public void onDisconnected(bool isMain1)
	{
		bool_4 = isMain1;
		GClass138.smethod_30();
	}

	public void method_0(GClass110 msg)
	{
		try
		{
			int num = msg.method_1().method_5();
			GClass121 gClass = GClass154.gclass58_0.gclass121_2[num];
			gClass.int_38 = msg.method_1().method_8();
			gClass.int_32 = msg.method_1().method_2();
			gClass.gclass63_0 = new GClass63();
			try
			{
				while (true)
				{
					gClass.gclass63_0.method_0(new GClass20(msg.method_1().method_5(), msg.method_1().method_7()));
				}
			}
			catch (Exception ex)
			{
				GClass5.smethod_0("Loi tairequestItemPlayer 1" + ex.ToString());
			}
		}
		catch (Exception ex2)
		{
			GClass5.smethod_0("Loi tairequestItemPlayer 2" + ex2.ToString());
		}
	}

	public void onMessage(GClass110 msg)
	{
		GClass39.gclass63_5.method_9();
		GClass39.smethod_8("SA1", 2);
		try
		{
			if (msg.sbyte_0 != -74)
				GClass56.smethod_8("=========> [READ] cmd= " + msg.sbyte_0);
			GClass58 gClass = null;
			GClass85 gClass2 = null;
			GClass63 gClass3 = new GClass63();
			int num = 0;
			GClass39.int_100 = 15;
			Class5.smethod_0(msg);
			sbyte b = msg.sbyte_0;
			switch (b)
			{
			default:
			{
				if (b != 112)
					break;
				sbyte b27 = msg.method_1().method_2();
				GClass56.smethod_8("spec type= " + b27);
				if (b27 == 0)
				{
					GClass45.short_0 = msg.method_1().method_6();
					GClass45.string_1 = msg.method_1().method_14();
				}
				else
				{
					if (b27 != 1)
						break;
					sbyte b28 = msg.method_1().method_2();
					GClass58.smethod_1().string_4 = new string[b28][];
					GClass58.smethod_1().short_1 = new short[b28][];
					GClass39.gclass45_0.string_28 = new string[b28][];
					for (int num81 = 0; num81 < b28; num81++)
					{
						GClass39.gclass45_0.string_28[num81] = new string[2];
						string[] array9 = GClass56.smethod_30(msg.method_1().method_14(), "\n", 0);
						if (array9.Length == 2)
							GClass39.gclass45_0.string_28[num81] = array9;
						if (array9.Length == 1)
						{
							GClass39.gclass45_0.string_28[num81][0] = array9[0];
							GClass39.gclass45_0.string_28[num81][1] = string.Empty;
						}
						int num82 = msg.method_1().method_2();
						GClass58.smethod_1().string_4[num81] = new string[num82];
						GClass58.smethod_1().short_1[num81] = new short[num82];
						for (int num83 = 0; num83 < num82; num83++)
						{
							GClass58.smethod_1().short_1[num81][num83] = msg.method_1().method_6();
							GClass58.smethod_1().string_4[num81][num83] = msg.method_1().method_14();
						}
					}
					GClass39.gclass45_0.string_17[25] = GClass39.gclass45_0.string_28;
					GClass39.gclass45_0.method_210();
					GClass39.gclass45_0.method_50();
				}
				break;
			}
			case -112:
			{
				sbyte b13 = msg.method_1().method_2();
				if (b13 == 0)
					GClass154.smethod_15(msg.method_1().method_2()).clearBody();
				if (b13 == 1)
					GClass154.smethod_15(msg.method_1().method_2()).setBody(msg.method_1().method_6());
				break;
			}
			case -107:
			{
				sbyte b50 = msg.method_1().method_2();
				if (b50 == 0)
					GClass58.smethod_1().bool_38 = false;
				if (b50 == 1)
					GClass58.smethod_1().bool_38 = true;
				if (b50 != 2)
					break;
				GClass57.smethod_5();
				GClass58.smethod_2().int_119 = msg.method_1().method_6();
				GClass58.smethod_2().method_60();
				int num144 = msg.method_1().method_5();
				GClass56.smethod_8("num body = " + num144);
				GClass58.smethod_2().gclass121_2 = new GClass121[num144];
				for (int num145 = 0; num145 < num144; num145++)
				{
					short num146 = msg.method_1().method_6();
					GClass56.smethod_8("template id= " + num146);
					if (num146 == -1)
						continue;
					GClass56.smethod_8("1");
					GClass58.smethod_2().gclass121_2[num145] = new GClass121();
					GClass58.smethod_2().gclass121_2[num145].gclass118_0 = GClass83.smethod_1(num146);
					int num147 = GClass58.smethod_2().gclass121_2[num145].gclass118_0.sbyte_0;
					GClass58.smethod_2().gclass121_2[num145].int_30 = msg.method_1().method_8();
					GClass56.smethod_8("3");
					GClass58.smethod_2().gclass121_2[num145].string_0 = msg.method_1().method_14();
					GClass58.smethod_2().gclass121_2[num145].string_1 = msg.method_1().method_14();
					int num148 = msg.method_1().method_5();
					GClass56.smethod_8("option size= " + num148);
					if (num148 != 0)
					{
						GClass58.smethod_2().gclass121_2[num145].gclass20_0 = new GClass20[num148];
						for (int num149 = 0; num149 < GClass58.smethod_2().gclass121_2[num145].gclass20_0.Length; num149++)
						{
							int optionTemplateId6 = msg.method_1().method_5();
							int param6 = msg.method_1().method_7();
							GClass58.smethod_2().gclass121_2[num145].gclass20_0[num149] = new GClass20(optionTemplateId6, param6);
						}
					}
					int num150 = num147;
					if (num150 != 0)
					{
						if (num150 == 1)
							GClass58.smethod_2().int_120 = GClass58.smethod_2().gclass121_2[num145].gclass118_0.short_2;
					}
					else
						GClass58.smethod_2().int_121 = GClass58.smethod_2().gclass121_2[num145].gclass118_0.short_2;
				}
				GClass58.smethod_2().int_25 = msg.method_3();
				GClass58.smethod_2().int_35 = msg.method_3();
				GClass58.smethod_2().int_24 = msg.method_3();
				GClass58.smethod_2().int_36 = msg.method_3();
				GClass58.smethod_2().int_20 = msg.method_3();
				GClass58.smethod_2().string_3 = msg.method_1().method_14();
				GClass58.smethod_2().string_6 = msg.method_1().method_14();
				GClass58.smethod_2().long_2 = msg.method_1().method_9();
				GClass58.smethod_2().long_4 = msg.method_1().method_9();
				GClass58.smethod_2().sbyte_15 = msg.method_1().method_2();
				GClass58.smethod_2().int_77 = msg.method_1().method_6();
				GClass58.smethod_2().short_24 = msg.method_1().method_6();
				GClass58.smethod_2().int_22 = msg.method_1().method_2();
				GClass58.smethod_2().int_21 = msg.method_1().method_6();
				GClass58.smethod_2().gclass74_1 = new GClass74[msg.method_1().method_2()];
				GClass56.smethod_8("SKILLENT = " + GClass58.smethod_2().gclass74_1);
				for (int num151 = 0; num151 < GClass58.smethod_2().gclass74_1.Length; num151++)
				{
					short num152 = msg.method_1().method_6();
					if (num152 != -1)
					{
						GClass58.smethod_2().gclass74_1[num151] = GClass61.smethod_1(num152);
						continue;
					}
					GClass58.smethod_2().gclass74_1[num151] = new GClass74();
					GClass58.smethod_2().gclass74_1[num151].gclass53_0 = null;
					GClass58.smethod_2().gclass74_1[num151].string_0 = msg.method_1().method_14();
				}
				break;
			}
			case -99:
				GClass57.smethod_5();
				if (msg.method_1().method_2() == 0)
				{
					GClass39.gclass45_0.gclass63_9.method_9();
					int num35 = msg.method_1().method_5();
					for (int num36 = 0; num36 < num35; num36++)
					{
						GClass58 gClass12 = new GClass58();
						gClass12.int_13 = msg.method_1().method_8();
						gClass12.int_119 = msg.method_1().method_6();
						gClass12.int_118 = msg.method_1().method_6();
						gClass12.int_121 = msg.method_1().method_6();
						gClass12.int_120 = msg.method_1().method_6();
						gClass12.int_122 = msg.method_1().method_6();
						gClass12.string_3 = msg.method_1().method_14();
						GClass43 gClass13 = new GClass43(msg.method_1().method_14());
						bool flag3 = msg.method_1().method_11();
						gClass13.gclass58_0 = gClass12;
						gClass13.bool_1 = flag3;
						GClass56.smethod_8("isonline = " + flag3);
						GClass39.gclass45_0.gclass63_9.method_0(gClass13);
					}
					GClass39.gclass45_0.method_26();
					GClass39.gclass45_0.method_50();
				}
				break;
			case -98:
			{
				sbyte b10 = msg.method_1().method_2();
				GClass39.gclass0_0.bool_0 = false;
				if (b10 == 0)
					GClass39.smethod_36(msg.method_1().method_14(), new GClass14(mResources.YES, GClass39.gclass39_0, 888397, msg.method_1().method_14()), new GClass14(mResources.NO, GClass39.gclass39_0, 888396, null));
				break;
			}
			case -97:
				GClass58.smethod_1().long_5 = msg.method_1().method_8();
				break;
			case -96:
			{
				sbyte t = msg.method_1().method_2();
				GClass39.gclass45_0.gclass63_8.method_9();
				string string_ = msg.method_1().method_14();
				sbyte b12 = msg.method_1().method_2();
				for (int num23 = 0; num23 < b12; num23++)
				{
					int int_3 = msg.method_1().method_8();
					int int_4 = msg.method_1().method_8();
					short num24 = msg.method_1().method_6();
					short num25 = msg.method_1().method_6();
					short short_ = msg.method_1().method_6();
					short short_2 = msg.method_1().method_6();
					string string_2 = msg.method_1().method_14();
					string string_3 = msg.method_1().method_14();
					GClass8 gClass10 = new GClass8();
					gClass10.int_3 = int_3;
					gClass10.int_0 = num24;
					gClass10.int_1 = num25;
					gClass10.short_0 = short_;
					gClass10.short_1 = short_2;
					gClass10.string_0 = string_2;
					gClass10.string_1 = string_3;
					gClass10.string_2 = msg.method_1().method_14();
					gClass10.int_2 = int_4;
					GClass39.gclass45_0.gclass63_8.method_0(gClass10);
				}
				GClass39.gclass45_0.string_0 = string_;
				GClass39.gclass45_0.method_27(t);
				GClass39.gclass45_0.method_50();
				break;
			}
			case -95:
			{
				sbyte b25 = msg.method_1().method_2();
				GClass56.smethod_8("type= " + b25);
				if (b25 == 0)
				{
					int num63 = msg.method_1().method_8();
					short templateId = msg.method_1().method_6();
					int num64 = msg.method_3();
					GClass29.smethod_1().method_22();
					if (num63 == GClass58.smethod_1().int_13)
					{
						GClass58.smethod_1().gclass85_1 = new GClass85(num63, false, false, false, false, false, templateId, 1, num64, 0, num64, (short)(GClass58.smethod_1().int_4 + ((GClass58.smethod_1().int_12 != 1) ? (-40) : 40)), (short)GClass58.smethod_1().int_5, 4, 0);
						GClass58.smethod_1().gclass85_1.bool_13 = true;
						GClass81.smethod_0(new GClass33(18, GClass58.smethod_1().gclass85_1.int_8, GClass58.smethod_1().gclass85_1.int_9, 2, 10, -1));
						GClass58.smethod_1().int_72 = 30;
						GClass154.gclass63_9.method_0(GClass58.smethod_1().gclass85_1);
					}
					else
					{
						gClass = GClass154.smethod_14(num63);
						if (gClass != null)
						{
							GClass85 gClass24 = new GClass85(num63, false, false, false, false, false, templateId, 1, num64, 0, num64, (short)gClass.int_4, (short)gClass.int_5, 4, 0);
							gClass24.bool_13 = true;
							gClass.gclass85_1 = gClass24;
							GClass154.gclass63_9.method_0(gClass.gclass85_1);
						}
						else if (GClass154.smethod_16(num63) == null)
						{
							GClass85 gClass25 = new GClass85(num63, false, false, false, false, false, templateId, 1, num64, 0, num64, -100, -100, 4, 0);
							gClass25.bool_13 = true;
							GClass154.gclass63_9.method_0(gClass25);
						}
					}
				}
				if (b25 == 1)
				{
					int num65 = msg.method_1().method_8();
					int mobId = msg.method_1().method_2();
					GClass56.smethod_8("mod attack id= " + num65);
					if (num65 == GClass58.smethod_1().int_13)
					{
						if (GClass154.smethod_16(mobId) != null)
							GClass58.smethod_1().gclass85_1.method_23(GClass154.smethod_16(mobId));
					}
					else
					{
						gClass = GClass154.smethod_14(num65);
						if (gClass != null && GClass154.smethod_16(mobId) != null)
							gClass.gclass85_1.method_23(GClass154.smethod_16(mobId));
					}
				}
				if (b25 == 2)
				{
					int num66 = msg.method_1().method_8();
					int num67 = msg.method_1().method_8();
					int num68 = msg.method_3();
					int int_9 = msg.method_3();
					if (num66 == GClass58.smethod_1().int_13)
					{
						GClass56.smethod_8("mob dame= " + num68);
						gClass = GClass154.smethod_14(num67);
						if (gClass != null)
						{
							gClass.int_26 = int_9;
							if (GClass58.smethod_1().gclass85_1.bool_18)
								gClass.method_110(num68, 0, false, true);
							else
							{
								GClass58.smethod_1().gclass85_1.int_27 = num68;
								GClass58.smethod_1().gclass85_1.method_8(gClass);
							}
						}
					}
					else
					{
						gClass2 = GClass154.smethod_16(num66);
						if (gClass2 != null)
						{
							if (num67 == GClass58.smethod_1().int_13)
							{
								GClass58.smethod_1().int_26 = int_9;
								if (gClass2.bool_18)
									GClass58.smethod_1().method_110(num68, 0, false, true);
								else
								{
									gClass2.int_27 = num68;
									gClass2.method_8(GClass58.smethod_1());
								}
							}
							else
							{
								gClass = GClass154.smethod_14(num67);
								if (gClass != null)
								{
									gClass.int_26 = int_9;
									if (gClass2.bool_18)
										gClass.method_110(num68, 0, false, true);
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
				if (b25 == 3)
				{
					int num69 = msg.method_1().method_8();
					int mobId2 = msg.method_1().method_8();
					int int_10 = msg.method_3();
					int num70 = msg.method_3();
					gClass = null;
					gClass = ((GClass58.smethod_1().int_13 != num69) ? GClass154.smethod_14(num69) : GClass58.smethod_1());
					if (gClass != null)
					{
						gClass2 = GClass154.smethod_16(mobId2);
						if (gClass.gclass85_1 != null)
							gClass.gclass85_1.method_23(gClass2);
						if (gClass2 != null)
						{
							gClass2.int_6 = int_10;
							gClass2.method_20();
							if (num70 == 0)
							{
								gClass2.int_8 = gClass2.int_16;
								gClass2.int_9 = gClass2.int_17;
								GClass154.smethod_19(mResources.miss, gClass2.int_8, gClass2.int_9 - gClass2.int_21, 0, -2, GClass49.int_7);
							}
							else
								GClass154.smethod_19("-" + num70, gClass2.int_8, gClass2.int_9 - gClass2.int_21, 0, -2, GClass49.int_8);
						}
					}
				}
				if (b25 == 4)
					;
				if (b25 == 5)
				{
					int num71 = msg.method_1().method_8();
					sbyte b26 = msg.method_1().method_2();
					int mobId3 = msg.method_1().method_8();
					int num72 = msg.method_3();
					int int_11 = msg.method_3();
					gClass = null;
					gClass = ((num71 != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num71) : GClass58.smethod_1());
					if (gClass == null)
						return;
					if ((GClass1.smethod_26(gClass.int_4, gClass.int_5) & 2) == 2)
						gClass.method_68(GClass154.gclass75_0[b26], 0);
					else
						gClass.method_68(GClass154.gclass75_0[b26], 1);
					GClass85 gClass26 = GClass154.smethod_16(mobId3);
					if (gClass.int_4 <= gClass26.int_8)
						gClass.int_12 = 1;
					else
						gClass.int_12 = -1;
					gClass.gclass85_0 = gClass26;
					gClass26.int_6 = int_11;
					gClass26.method_20();
					GClass39.smethod_8("SA83v2", 2);
					if (num72 == 0)
					{
						gClass26.int_8 = gClass26.int_16;
						gClass26.int_9 = gClass26.int_17;
						GClass154.smethod_19(mResources.miss, gClass26.int_8, gClass26.int_9 - gClass26.int_21, 0, -2, GClass49.int_7);
					}
					else
						GClass154.smethod_19("-" + num72, gClass26.int_8, gClass26.int_9 - gClass26.int_21, 0, -2, GClass49.int_8);
				}
				if (b25 == 6)
				{
					int num73 = msg.method_1().method_8();
					if (num73 == GClass58.smethod_1().int_13)
						GClass58.smethod_1().gclass85_1.method_22();
					else
						GClass154.smethod_14(num73)?.gclass85_1.method_22();
				}
				if (b25 != 7)
					break;
				int num74 = msg.method_1().method_8();
				if (num74 == GClass58.smethod_1().int_13)
				{
					GClass58.smethod_1().gclass85_1 = null;
					for (int num75 = 0; num75 < GClass154.gclass63_9.method_2(); num75++)
					{
						if (((GClass85)GClass154.gclass63_9.method_3(num75)).int_25 == num74)
							GClass154.gclass63_9.method_7(num75);
					}
					break;
				}
				gClass = GClass154.smethod_14(num74);
				for (int num76 = 0; num76 < GClass154.gclass63_9.method_2(); num76++)
				{
					if (((GClass85)GClass154.gclass63_9.method_3(num76)).int_25 == num74)
						GClass154.gclass63_9.method_7(num76);
				}
				if (gClass != null)
					gClass.gclass85_1 = null;
				break;
			}
			case -94:
				while (msg.method_1().method_18() > 0)
				{
					short num103 = msg.method_1().method_6();
					int num104 = msg.method_1().method_8();
					for (int num105 = 0; num105 < GClass58.smethod_1().gclass63_0.method_2(); num105++)
					{
						GClass74 gClass35 = (GClass74)GClass58.smethod_1().gclass63_0.method_3(num105);
						if (gClass35 != null && gClass35.short_0 == num103)
						{
							if (num104 < gClass35.int_1)
								gClass35.long_1 = GClass138.smethod_18() - (gClass35.int_1 - num104);
							GClass56.smethod_8("1 chieu id= " + gClass35.gclass53_0.sbyte_0 + " cooldown= " + num104 + "curr cool down= " + gClass35.int_1);
						}
					}
				}
				break;
			case -93:
			{
				short num122 = msg.method_1().method_6();
				GClass107.sbyte_1 = new sbyte[num122];
				for (int num123 = 0; num123 < num122; num123++)
				{
					GClass107.sbyte_1[num123] = msg.method_1().method_2();
				}
				break;
			}
			case -92:
				Main.typeClient = msg.method_1().method_2();
				if (GClass120.smethod_2("ResVersion") == null)
					GClass120.smethod_13();
				GClass120.smethod_9("clienttype", Main.typeClient);
				GClass120.smethod_9("lastZoomlevel", GClass76.int_12);
				if (GClass120.smethod_2("ResVersion") == null)
					GClass39.smethod_34(mResources.plsRestartGame, 8885, null);
				break;
			case -91:
			{
				sbyte b51 = msg.method_1().method_2();
				GClass39.gclass45_0.string_4 = new string[b51];
				GClass39.gclass45_0.string_5 = new string[b51];
				for (int num155 = 0; num155 < b51; num155++)
				{
					GClass39.gclass45_0.string_4[num155] = msg.method_1().method_14();
					GClass39.gclass45_0.string_5[num155] = msg.method_1().method_14();
				}
				GClass171.smethod_0().method_6();
				break;
			}
			case -90:
			{
				sbyte b11 = msg.method_1().method_2();
				int num18 = msg.method_1().method_8();
				GClass56.smethod_8("===> UPDATE_BODY:    type = " + b11);
				gClass = ((GClass58.smethod_1().int_13 != num18) ? GClass154.smethod_14(num18) : GClass58.smethod_1());
				if (b11 != -1)
				{
					short num19 = msg.method_1().method_6();
					short num20 = msg.method_1().method_6();
					short num21 = msg.method_1().method_6();
					sbyte sbyte_ = msg.method_1().method_2();
					if (gClass != null)
					{
						if (gClass.int_13 == num18)
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
						if (num19 != -1)
							gClass.int_119 = num19;
						if (num20 != -1)
							gClass.int_121 = num20;
						if (num21 != -1)
							gClass.int_120 = num21;
					}
				}
				if (b11 == -1 && gClass != null)
				{
					gClass.bool_1 = false;
					gClass.sbyte_35 = 0;
				}
				if (gClass != null)
					;
				break;
			}
			case -88:
				GClass39.smethod_29();
				GClass39.gclass152_0.switchToMe();
				break;
			case -87:
			{
				GClass56.smethod_8("GET UPDATE_DATA " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_5(msg.method_1(), true);
				msg.method_1().method_4();
				sbyte[] data = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data);
				GClass120.smethod_0("NRdataVersion", new sbyte[1] { GClass154.sbyte_0 });
				GClass149.bool_5 = false;
				if (GClass154.sbyte_4 == GClass154.sbyte_0 && GClass154.sbyte_5 == GClass154.sbyte_1 && GClass154.sbyte_6 == GClass154.sbyte_2 && GClass154.sbyte_7 == GClass154.sbyte_3)
				{
					GClass56.smethod_8(GClass154.sbyte_4 + "," + GClass154.sbyte_5 + "," + GClass154.sbyte_6 + "," + GClass154.sbyte_7);
					GClass154.smethod_8().method_22();
					GClass154.smethod_8().method_20();
					GClass154.smethod_8().method_21();
					GClass154.smethod_8().method_23();
					GClass166.smethod_0().method_83();
					return;
				}
				break;
			}
			case -86:
			{
				sbyte b31 = msg.method_1().method_2();
				GClass56.smethod_8("server gui ve giao dich action = " + b31);
				if (b31 == 0)
				{
					int playerID = msg.method_1().method_8();
					GClass154.smethod_8().method_113(playerID);
				}
				if (b31 == 1)
				{
					int num89 = msg.method_1().method_8();
					GClass58 gClass30 = GClass154.smethod_14(num89);
					if (gClass30 == null)
						return;
					GClass39.gclass45_0.method_62(gClass30);
					GClass39.gclass45_0.method_50();
					GClass166.smethod_0().method_15(num89);
				}
				if (b31 == 2)
				{
					sbyte b32 = msg.method_1().method_2();
					for (int num90 = 0; num90 < GClass39.gclass45_0.gclass63_6.method_2(); num90++)
					{
						GClass121 gClass31 = (GClass121)GClass39.gclass45_0.gclass63_6.method_3(num90);
						if (gClass31.int_29 == b32)
						{
							GClass39.gclass45_0.gclass63_6.method_8(gClass31);
							break;
						}
					}
				}
				if (b31 == 5)
					;
				if (b31 == 6)
				{
					GClass39.gclass45_0.bool_2 = true;
					if (GClass39.gclass45_1 != null)
						GClass39.gclass45_1.bool_2 = true;
					GClass39.gclass45_0.gclass63_7.method_9();
					if (GClass39.gclass45_1 != null)
						GClass39.gclass45_1.gclass63_7.method_9();
					int int_12 = msg.method_1().method_8();
					sbyte b33 = msg.method_1().method_2();
					GClass56.smethod_8("item size = " + b33);
					for (int num91 = 0; num91 < b33; num91++)
					{
						GClass121 gClass32 = new GClass121();
						gClass32.gclass118_0 = GClass83.smethod_1(msg.method_1().method_6());
						gClass32.int_30 = msg.method_1().method_8();
						int num92 = msg.method_1().method_5();
						if (num92 != 0)
						{
							gClass32.gclass20_0 = new GClass20[num92];
							for (int num93 = 0; num93 < gClass32.gclass20_0.Length; num93++)
							{
								int optionTemplateId3 = msg.method_1().method_5();
								int param3 = msg.method_1().method_7();
								gClass32.gclass20_0[num93] = new GClass20(optionTemplateId3, param3);
								gClass32.int_43 = GClass39.gclass45_0.method_131(gClass32);
							}
						}
						if (GClass39.gclass45_1 != null)
							GClass39.gclass45_1.gclass63_7.method_0(gClass32);
						else
							GClass39.gclass45_0.gclass63_7.method_0(gClass32);
					}
					if (GClass39.gclass45_1 != null)
					{
						GClass39.gclass45_1.method_61(false);
						GClass39.gclass45_1.int_23 = int_12;
					}
					else
					{
						GClass39.gclass45_0.int_23 = int_12;
						if (GClass39.gclass45_0.int_29 == 2)
							GClass39.gclass45_0.method_61(false);
					}
				}
				if (b31 == 7)
				{
					GClass57.smethod_5();
					if (GClass39.gclass45_0.bool_0)
						GClass39.gclass45_0.method_151();
				}
				break;
			}
			case -85:
			{
				GClass56.smethod_8("CAP CHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
				sbyte b24 = msg.method_1().method_2();
				if (b24 == 0)
				{
					int num62 = msg.method_1().method_7();
					GClass56.smethod_8("lent =" + num62);
					sbyte[] data4 = new sbyte[num62];
					msg.method_1().method_21(ref data4, 0, num62);
					GClass154.gclass2_44 = GClass2.smethod_6(data4, 0, num62);
					GClass154.smethod_8().string_8 = "-----";
					GClass154.smethod_8().string_7 = msg.method_1().method_14();
					GClass154.smethod_8().int_116 = new int[GClass154.smethod_8().string_7.Length];
					GClass154.smethod_8().gclass85_0 = new GClass85();
					GClass154.smethod_8().gclass14_2 = null;
				}
				if (b24 == 1)
					GClass165.bool_2 = true;
				if (b24 == 2)
				{
					GClass165.bool_0 = true;
					GClass154.smethod_8().gclass14_2 = GClass154.smethod_8().gclass14_10;
				}
				break;
			}
			case -84:
			{
				int index2 = msg.method_1().method_5();
				GClass85 gClass36 = null;
				try
				{
					gClass36 = (GClass85)GClass154.gclass63_9.method_3(index2);
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
				sbyte b53 = msg.method_1().method_2();
				if (b53 == 0)
				{
					int num159 = msg.method_1().method_6();
					int int_13 = msg.method_1().method_6();
					int num160 = msg.method_1().method_5();
					int num161 = msg.method_1().method_8();
					msg.method_1().method_14();
					int int_14 = msg.method_1().method_6();
					int int_15 = msg.method_1().method_6();
					if (msg.method_1().method_2() == 1)
						GClass154.smethod_8().bool_63 = true;
					else
						GClass154.smethod_8().bool_63 = false;
					GClass154.smethod_8().int_126 = int_14;
					GClass154.smethod_8().int_127 = int_15;
					GClass56.smethod_8("xR= " + int_14 + " yR= " + int_15 + " +++++++++++++++++++++++++++++++++++++++");
					if (GClass58.smethod_1().int_13 == num161)
					{
						GClass39.gclass45_0.method_150();
						GClass154.smethod_8().method_52(true);
					}
					else if (GClass1.int_37 == num159 && GClass1.int_39 == num160)
					{
						GClass154.smethod_8().method_52(false);
					}
					else if (GClass76.int_12 > 1)
					{
						GClass154.smethod_8().method_54();
					}
					GClass154.smethod_8().int_102 = num159;
					GClass154.smethod_8().int_104 = int_13;
					GClass154.smethod_8().int_103 = num160;
				}
				if (b53 == 1)
				{
					GClass56.smethod_8("map RID = " + GClass154.smethod_8().int_102 + " zone RID= " + GClass154.smethod_8().int_103);
					GClass56.smethod_8("map ID = " + GClass1.int_37 + " zone ID= " + GClass1.int_39);
					if (GClass1.int_37 == GClass154.smethod_8().int_102 && GClass1.int_39 == GClass154.smethod_8().int_103)
						GClass154.smethod_8().method_53();
					else
					{
						GClass154.smethod_8().bool_62 = false;
						if (GClass154.smethod_8().bool_63)
							GClass154.smethod_8().bool_63 = false;
					}
				}
				if (b53 == 2)
					;
				break;
			}
			case -82:
			{
				sbyte b55 = msg.method_1().method_2();
				GClass1.int_65 = new int[b55][][];
				GClass1.int_64 = new int[b55][];
				for (int num166 = 0; num166 < b55; num166++)
				{
					sbyte b56 = msg.method_1().method_2();
					GClass1.int_64[num166] = new int[b56];
					GClass1.int_65[num166] = new int[b56][];
					for (int num167 = 0; num167 < b56; num167++)
					{
						GClass1.int_64[num166][num167] = msg.method_1().method_8();
						sbyte b57 = msg.method_1().method_2();
						GClass1.int_65[num166][num167] = new int[b57];
						for (int num168 = 0; num168 < b57; num168++)
						{
							GClass1.int_65[num166][num167][num168] = msg.method_1().method_2();
						}
					}
				}
				break;
			}
			case -81:
			{
				sbyte b39 = msg.method_1().method_2();
				if (b39 == 0)
				{
					string src = msg.method_1().method_14();
					string src2 = msg.method_1().method_14();
					GClass39.gclass45_0.method_35();
					GClass39.gclass45_0.string_24 = GClass49.gclass49_2.method_15(src, GClass45.int_55);
					GClass39.gclass45_0.string_25 = GClass49.gclass49_11.method_15(src2, GClass45.int_55);
					GClass39.gclass45_0.method_50();
				}
				if (b39 == 1)
				{
					GClass39.gclass45_0.gclass63_0.method_9();
					sbyte b40 = msg.method_1().method_2();
					for (int num116 = 0; num116 < b40; num116++)
					{
						sbyte b41 = msg.method_1().method_2();
						for (int num117 = 0; num117 < GClass58.smethod_1().gclass121_0.Length; num117++)
						{
							GClass121 gClass37 = GClass58.smethod_1().gclass121_0[num117];
							if (gClass37 != null && gClass37.int_29 == b41)
							{
								gClass37.bool_0 = true;
								GClass39.gclass45_0.gclass63_0.method_0(gClass37);
							}
						}
					}
					if (GClass39.gclass45_0.bool_0)
						GClass39.gclass45_0.method_36();
				}
				if (b39 == 2)
				{
					GClass39.gclass45_0.sbyte_7 = 0;
					GClass39.gclass45_0.method_195(0);
				}
				if (b39 == 3)
				{
					GClass39.gclass45_0.sbyte_7 = 1;
					GClass39.gclass45_0.method_195(0);
				}
				if (b39 == 4)
				{
					short short_3 = msg.method_1().method_6();
					GClass39.gclass45_0.short_3 = short_3;
					GClass39.gclass45_0.sbyte_7 = 0;
					GClass39.gclass45_0.method_195(1);
				}
				if (b39 == 5)
				{
					short short_4 = msg.method_1().method_6();
					GClass39.gclass45_0.short_3 = short_4;
					GClass39.gclass45_0.sbyte_7 = 0;
					GClass39.gclass45_0.method_195(2);
				}
				if (b39 == 6)
				{
					short short_5 = msg.method_1().method_6();
					short short_6 = msg.method_1().method_6();
					GClass39.gclass45_0.sbyte_7 = 0;
					GClass39.gclass45_0.method_195(3);
					GClass39.gclass45_0.short_1 = short_5;
					GClass39.gclass45_0.short_3 = short_6;
				}
				if (b39 == 7)
				{
					short short_7 = msg.method_1().method_6();
					GClass39.gclass45_0.short_3 = short_7;
					GClass39.gclass45_0.sbyte_7 = 0;
					GClass39.gclass45_0.method_195(4);
				}
				if (b39 == 8)
				{
					GClass39.gclass45_0.short_3 = -1;
					GClass39.gclass45_0.sbyte_7 = 1;
					GClass39.gclass45_0.method_195(4);
				}
				short num118 = 21;
				int num119 = 0;
				int num120 = 0;
				try
				{
					num118 = msg.method_1().method_6();
					num119 = msg.method_1().method_6();
					num120 = msg.method_1().method_6();
					GClass39.gclass45_0.int_149 = num119 - GClass154.int_22;
					GClass39.gclass45_0.int_150 = num120 - GClass154.int_23;
				}
				catch (Exception)
				{
				}
				for (int num121 = 0; num121 < GClass154.gclass63_10.method_2(); num121++)
				{
					GClass59 gClass38 = (GClass59)GClass154.gclass63_10.method_3(num121);
					if (gClass38.gclass90_0.int_0 == num118)
					{
						GClass39.gclass45_0.int_149 = gClass38.int_4 - GClass154.int_22;
						GClass39.gclass45_0.int_150 = gClass38.int_5 - GClass154.int_23;
						GClass39.gclass45_0.int_148 = num118;
						break;
					}
				}
				break;
			}
			case -80:
			{
				sbyte b17 = msg.method_1().method_2();
				GClass57.smethod_5();
				if (b17 == 0)
				{
					GClass39.gclass45_0.gclass63_5.method_9();
					int num39 = msg.method_1().method_5();
					for (int num40 = 0; num40 < num39; num40++)
					{
						GClass58 gClass14 = new GClass58();
						gClass14.int_13 = msg.method_1().method_8();
						gClass14.int_119 = msg.method_1().method_6();
						gClass14.int_118 = msg.method_1().method_6();
						gClass14.int_121 = msg.method_1().method_6();
						gClass14.int_120 = msg.method_1().method_6();
						gClass14.int_122 = msg.method_1().method_5();
						gClass14.string_3 = msg.method_1().method_14();
						bool flag4 = msg.method_1().method_11();
						GClass43 gClass15 = new GClass43(mResources.power + ": " + msg.method_1().method_14());
						gClass15.gclass58_0 = gClass14;
						gClass15.bool_1 = flag4;
						GClass39.gclass45_0.gclass63_5.method_0(gClass15);
					}
					GClass39.gclass45_0.method_25();
					GClass39.gclass45_0.method_50();
				}
				if (b17 == 3)
				{
					GClass63 gclass63_ = GClass39.gclass45_0.gclass63_5;
					int num41 = msg.method_1().method_8();
					GClass56.smethod_8("online offline id=" + num41);
					for (int num42 = 0; num42 < gclass63_.method_2(); num42++)
					{
						GClass43 gClass16 = (GClass43)gclass63_.method_3(num42);
						if (gClass16.gclass58_0 != null && gClass16.gclass58_0.int_13 == num41)
						{
							GClass56.smethod_8("online= " + gClass16.bool_1);
							gClass16.bool_1 = msg.method_1().method_11();
							break;
						}
					}
				}
				if (b17 != 2)
					break;
				GClass63 gclass63_2 = GClass39.gclass45_0.gclass63_5;
				int num43 = msg.method_1().method_8();
				for (int num44 = 0; num44 < gclass63_2.method_2(); num44++)
				{
					GClass43 gClass17 = (GClass43)gclass63_2.method_3(num44);
					if (gClass17.gclass58_0 != null && gClass17.gclass58_0.int_13 == num43)
					{
						gclass63_2.method_8(gClass17);
						break;
					}
				}
				if (GClass39.gclass45_0.bool_0)
					GClass39.gclass45_0.method_29();
				break;
			}
			case -79:
			{
				GClass57.smethod_5();
				msg.method_1().method_8();
				GClass58 gclass58_ = GClass39.gclass45_0.gclass58_0;
				if (gclass58_ == null)
					return;
				gclass58_.long_2 = msg.method_1().method_9();
				gclass58_.string_6 = msg.method_1().method_14();
				break;
			}
			case -77:
			{
				short num169 = msg.method_1().method_6();
				GClass96.sbyte_0 = new sbyte[num169];
				GClass96.short_0 = num169;
				GClass96.gclass129_0 = new GClass129[num169];
				for (int num170 = 0; num170 < num169; num170++)
				{
					GClass96.sbyte_0[num170] = msg.method_1().method_2();
				}
				break;
			}
			case -76:
			{
				sbyte b45 = msg.method_1().method_2();
				if (b45 == 0)
				{
					sbyte b46 = msg.method_1().method_2();
					if (b46 <= 0)
						return;
					GClass58.smethod_1().gclass79_0 = new GClass79[b46];
					for (int num136 = 0; num136 < b46; num136++)
					{
						GClass58.smethod_1().gclass79_0[num136] = new GClass79();
						GClass58.smethod_1().gclass79_0[num136].string_0 = num136 + 1 + ". " + msg.method_1().method_14();
						GClass58.smethod_1().gclass79_0[num136].string_1 = msg.method_1().method_14();
						GClass58.smethod_1().gclass79_0[num136].int_0 = msg.method_1().method_6();
						GClass58.smethod_1().gclass79_0[num136].bool_0 = msg.method_1().method_11();
						GClass58.smethod_1().gclass79_0[num136].bool_1 = msg.method_1().method_11();
					}
					GClass39.gclass45_0.method_9();
					GClass39.gclass45_0.method_50();
				}
				else if (b45 == 1)
				{
					int num137 = msg.method_1().method_5();
					if (GClass58.smethod_1().gclass79_0[num137] != null)
						GClass58.smethod_1().gclass79_0[num137].bool_1 = true;
				}
				break;
			}
			case -74:
			{
				if (GClass152.bool_2)
					return;
				if (!GClass39.smethod_41())
				{
					GClass166.smethod_0().method_125(3, null);
					GClass96.smethod_0();
					GClass148.gclass2_0 = null;
					if (GClass120.smethod_2("acc") != null || GClass120.smethod_2("userAo" + GClass152.int_14) != null)
						GClass149.bool_0 = true;
					GClass39.gclass149_0 = new GClass149();
					GClass39.gclass149_0.switchToMe();
					return;
				}
				bool flag2 = true;
				sbyte b5 = msg.method_1().method_2();
				if (b5 == 0)
				{
					int num8 = msg.method_1().method_8();
					string text3 = GClass120.smethod_2("ResVersion");
					int num9 = ((text3 == null || !(text3 != string.Empty)) ? (-1) : int.Parse(text3));
					if (GClass162.smethod_0().method_3())
					{
						if (num9 == -1 || num9 != num8)
							GClass39.gclass152_0.method_7();
						else
						{
							GClass56.smethod_8("login ngay");
							GClass96.smethod_0();
							GClass148.gclass2_0 = null;
							GClass152.bool_6 = true;
							if (GClass39.gclass145_0 != GClass39.gclass149_0)
								GClass39.gclass152_0.switchToMe();
						}
					}
					else
					{
						GClass162.smethod_0().close();
						GClass152.bool_6 = true;
						GClass152.bool_7 = false;
						GClass152.int_11 = 1000;
						GClass39.gclass152_0.switchToMe();
					}
				}
				if (b5 == 1)
				{
					GClass152.string_11 = mResources.downloading_data;
					_ = (short)(GClass152.int_17 = msg.method_1().method_6());
					GClass166.smethod_0().method_125(2, null);
				}
				if (b5 == 2)
					try
					{
						bool_0 = true;
						GClass39.smethod_29();
						GClass152.int_19++;
						GClass152.int_16 = GClass152.int_19 * 100 / GClass152.int_17;
						string[] array4 = GClass56.smethod_30(msg.method_1().method_14(), "/", 0);
						string filename = "x" + GClass76.int_12 + array4[array4.Length - 1];
						int num10 = msg.method_1().method_8();
						sbyte[] data2 = new sbyte[num10];
						msg.method_1().method_21(ref data2, 0, num10);
						GClass120.smethod_0(filename, data2);
					}
					catch (Exception)
					{
						GClass39.smethod_34(mResources.pls_restart_game_error, 8885, null);
					}
				if (b5 == 3 && flag2)
				{
					bool_0 = false;
					int num11 = msg.method_1().method_8();
					GClass56.smethod_8("last version= " + num11);
					GClass120.smethod_4("ResVersion", num11 + string.Empty);
					GClass166.smethod_0().method_125(3, null);
					GClass39.smethod_29();
					GClass148.gclass2_0 = null;
					GClass96.smethod_0();
					GClass138.smethod_26();
					GClass152.bool_4 = true;
					GClass152.bool_6 = true;
					GClass154.smethod_8().method_24();
					if (GClass39.gclass145_0 != GClass39.gclass149_0)
						GClass39.gclass152_0.switchToMe();
				}
				break;
			}
			case -70:
			{
				GClass56.smethod_8("BIG MESSAGE .......................................");
				GClass39.smethod_29();
				int int_16 = msg.method_1().method_6();
				string chat4 = msg.method_1().method_14();
				GClass59 gClass54 = new GClass59(-1, 0, 0, 0, 0, 0);
				gClass54.int_70 = int_16;
				GClass70.smethod_1(chat4, 100000, gClass54);
				sbyte b54 = msg.method_1().method_2();
				if (b54 == 0)
				{
					GClass70.gclass70_1.gclass14_1 = new GClass14(mResources.CLOSE, GClass70.gclass70_1, 1001, null);
					GClass70.gclass70_1.gclass14_1.int_1 = GClass39.int_10 / 2 - 35;
					GClass70.gclass70_1.gclass14_1.int_2 = GClass39.int_11 - 35;
				}
				if (b54 == 1)
				{
					string p2 = msg.method_1().method_14();
					string caption2 = msg.method_1().method_14();
					GClass70.gclass70_1.gclass14_1 = new GClass14(caption2, GClass70.gclass70_1, 1000, p2);
					GClass70.gclass70_1.gclass14_1.int_1 = GClass39.int_10 / 2 - 75;
					GClass70.gclass70_1.gclass14_1.int_2 = GClass39.int_11 - 35;
					GClass70.gclass70_1.gclass14_2 = new GClass14(mResources.CLOSE, GClass70.gclass70_1, 1001, null);
					GClass70.gclass70_1.gclass14_2.int_1 = GClass39.int_10 / 2 + 11;
					GClass70.gclass70_1.gclass14_2.int_2 = GClass39.int_11 - 35;
				}
				break;
			}
			case -69:
				GClass58.smethod_1().short_24 = msg.method_1().method_6();
				break;
			case -68:
				GClass58.smethod_1().int_77 = msg.method_1().method_6();
				break;
			case -67:
			{
				float_0 += 1f;
				int num80 = msg.method_1().method_8();
				sbyte[] array8 = null;
				try
				{
					array8 = GClass95.smethod_2(msg);
					if (num80 == 3896)
						;
					GClass96.gclass129_0[num80].gclass2_0 = method_6(array8);
				}
				catch (Exception)
				{
					array8 = null;
					GClass96.gclass129_0[num80].gclass2_0 = GClass2.smethod_9(new int[1], 1, 1, true);
				}
				if (array8 != null)
					GClass120.smethod_0(GClass76.int_12 + "Small" + num80, array8);
				break;
			}
			case -66:
			{
				short id = msg.method_1().method_6();
				sbyte[] data3 = GClass95.smethod_2(msg);
				GClass167 gClass20 = GClass33.smethod_2(id);
				sbyte b19 = msg.method_1().method_0();
				if (b19 == 0)
					gClass20.method_7(data3);
				else
					gClass20.method_8(data3, b19);
				sbyte[] array6 = GClass95.smethod_2(msg);
				gClass20.gclass2_0 = GClass2.smethod_6(array6, 0, array6.Length);
				break;
			}
			case -65:
			{
				GClass57.smethod_5();
				int num125 = msg.method_1().method_8();
				sbyte b42 = msg.method_1().method_2();
				if (b42 == 0)
					break;
				if (GClass58.smethod_1().int_13 == num125)
				{
					bool_5 = true;
					GClass154.int_38 = 500;
					GClass154.smethod_8().gclass14_1 = null;
					if (b42 == 0 || b42 == 1 || b42 == 3)
						GClass202.smethod_0(new GClass202(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, GClass58.smethod_1().int_119, GClass58.smethod_1().int_12, 0, true, (b42 != 1) ? b42 : GClass58.smethod_1().int_14));
					if (b42 == 2)
					{
						GClass154.int_38 = 50;
						GClass58.smethod_1().method_35();
					}
				}
				else
				{
					GClass58 gClass39 = GClass154.smethod_14(num125);
					if ((b42 == 0 || b42 == 1 || b42 == 3) && gClass39 != null)
					{
						gClass39.bool_3 = true;
						GClass202 gClass40 = new GClass202(gClass39.int_4, gClass39.int_5, gClass39.int_119, gClass39.int_12, 0, false, (b42 != 1) ? b42 : gClass39.int_14);
						gClass40.int_5 = num125;
						GClass202.smethod_0(gClass40);
					}
					if (b42 == 2)
						gClass39.method_35();
				}
				break;
			}
			case -64:
			{
				int num57 = msg.method_1().method_8();
				int int_8 = msg.method_1().method_5();
				gClass = null;
				gClass = ((num57 != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num57) : GClass58.smethod_1());
				if (gClass == null)
					return;
				gClass.int_122 = int_8;
				for (int num58 = 0; num58 < 54; num58++)
				{
					gClass.method_139(0, 201 + num58);
				}
				if (gClass.int_122 >= 201 && gClass.int_122 < 255)
				{
					GClass33 gClass21 = new GClass33(gClass.int_122, gClass, 2, -1, 10, 1);
					gClass21.int_1 = 5;
					gClass.method_138(gClass21);
				}
				GClass56.smethod_8("cmd:-64 UPDATE BAG PLAER = " + ((gClass != null) ? gClass.string_3 : string.Empty) + num57 + " BAG ID= " + int_8);
				break;
			}
			case -63:
			{
				GClass56.smethod_8("GET BAG");
				int num33 = msg.method_1().method_5();
				sbyte b16 = msg.method_1().method_2();
				GClass137 gClass11 = new GClass137();
				gClass11.int_0 = num33;
				if (b16 > 0)
				{
					gClass11.short_0 = new short[b16];
					for (int num34 = 0; num34 < b16; num34++)
					{
						gClass11.short_0[num34] = msg.method_1().method_6();
						GClass56.smethod_8("ID=  " + num33 + " frame= " + gClass11.short_0[num34]);
					}
					GClass137.gclass9_0.method_4(num33 + string.Empty, gClass11);
				}
				break;
			}
			case -62:
			{
				int num45 = msg.method_1().method_5();
				sbyte b18 = msg.method_1().method_2();
				if (b18 <= 0)
					break;
				GClass137 gClass18 = GClass137.smethod_1((short)num45);
				if (gClass18 == null)
					break;
				gClass18.short_0 = new short[b18];
				for (int num46 = 0; num46 < b18; num46++)
				{
					gClass18.short_0[num46] = msg.method_1().method_6();
					if (gClass18.short_0[num46] > 0)
						GClass96.gclass63_0.method_0(gClass18.short_0[num46] + string.Empty);
				}
				break;
			}
			case -61:
			{
				int num4 = msg.method_1().method_8();
				if (num4 != GClass58.smethod_1().int_13)
				{
					if (GClass154.smethod_14(num4) != null)
					{
						GClass154.smethod_14(num4).int_56 = msg.method_1().method_8();
						if (GClass154.smethod_14(num4).int_56 == -2)
							GClass154.smethod_14(num4).bool_59 = true;
					}
				}
				else if (GClass58.smethod_1().gclass21_0 != null)
				{
					GClass58.smethod_1().gclass21_0.int_0 = msg.method_1().method_8();
				}
				break;
			}
			case -60:
			{
				GClass39.smethod_8("SA7666", 2);
				int num131 = msg.method_1().method_8();
				int num132 = -1;
				if (num131 != GClass58.smethod_1().int_13)
				{
					GClass58 gClass44 = GClass154.smethod_14(num131);
					if (gClass44 == null)
						return;
					if (gClass44.gclass136_0 != null)
					{
						gClass44.method_78(gClass44.int_4, gClass44.int_5, 10);
						gClass44.int_4 = gClass44.gclass136_0.int_0;
						gClass44.int_5 = gClass44.gclass136_0.int_1;
					}
					int num133 = msg.method_1().method_5();
					if ((GClass1.smethod_26(gClass44.int_4, gClass44.int_5) & 2) == 2)
						gClass44.method_68(GClass154.gclass75_0[num133], 0);
					else
						gClass44.method_68(GClass154.gclass75_0[num133], 1);
					GClass58[] array14 = new GClass58[msg.method_1().method_2()];
					for (num = 0; num < array14.Length; num++)
					{
						num132 = msg.method_1().method_8();
						GClass58 gClass45;
						if (num132 == GClass58.smethod_1().int_13)
						{
							gClass45 = GClass58.smethod_1();
							if (!GClass154.bool_69 && GClass154.bool_67 && GClass154.bool_68)
							{
								GClass166.smethod_0().method_42(-1, -1);
								GClass154.bool_69 = true;
							}
						}
						else
							gClass45 = GClass154.smethod_14(num132);
						array14[num] = gClass45;
						if (num == 0)
						{
							if (gClass44.int_4 <= gClass45.int_4)
								gClass44.int_12 = 1;
							else
								gClass44.int_12 = -1;
						}
					}
					if (num > 0)
					{
						gClass44.gclass58_1 = new GClass58[num];
						for (num = 0; num < gClass44.gclass58_1.Length; num++)
						{
							gClass44.gclass58_1[num] = array14[num];
						}
						gClass44.gclass85_0 = null;
						gClass44.gclass58_0 = gClass44.gclass58_1[0];
					}
				}
				else
				{
					msg.method_1().method_2();
					msg.method_1().method_2();
					num132 = msg.method_1().method_8();
				}
				try
				{
					sbyte b43 = msg.method_1().method_2();
					GClass56.smethod_8("isRead continue = " + b43);
					if (b43 != 1)
						break;
					sbyte b44 = msg.method_1().method_2();
					GClass56.smethod_8("type skill = " + b44);
					if (num132 == GClass58.smethod_1().int_13)
					{
						bool flag10 = false;
						gClass = GClass58.smethod_1();
						int num134 = msg.method_3();
						GClass56.smethod_8("dame hit = " + num134);
						gClass.bool_7 = msg.method_1().method_11();
						if (gClass.bool_7)
							GClass58.bool_34 = true;
						GClass56.smethod_8("isDie=" + gClass.bool_7 + "---------------------------------------");
						flag10 = (gClass.bool_6 = msg.method_1().method_11());
						gClass.bool_5 = false;
						num134 = (gClass.int_39 = num134 + 0);
						if (b44 == 0)
							gClass.method_110(num134, 0, flag10, false);
					}
					else
					{
						gClass = GClass154.smethod_14(num132);
						if (gClass == null)
							return;
						bool flag11 = false;
						int num135 = msg.method_3();
						GClass56.smethod_8("dame hit= " + num135);
						gClass.bool_7 = msg.method_1().method_11();
						GClass56.smethod_8("isDie=" + gClass.bool_7 + "---------------------------------------");
						flag11 = (gClass.bool_6 = msg.method_1().method_11());
						gClass.bool_5 = false;
						num135 = (gClass.int_39 = num135 + 0);
						if (b44 == 0)
							gClass.method_110(num135, 0, flag11, false);
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
				GClass154.smethod_8().method_112(msg.method_1().method_8(), msg.method_1().method_8(), msg.method_1().method_14(), typePK);
				break;
			}
			case -57:
			{
				string strInvite = msg.method_1().method_14();
				int clanID = msg.method_1().method_8();
				int code = msg.method_1().method_8();
				GClass154.smethod_8().method_28(strInvite, clanID, code);
				break;
			}
			case -53:
			{
				GClass57.smethod_5();
				bool flag = false;
				int num2 = msg.method_1().method_8();
				GClass56.smethod_8("clanId= " + num2);
				if (num2 == -1)
				{
					flag = true;
					GClass58.smethod_1().gclass21_0 = null;
					GClass62.gclass63_0.method_9();
					if (GClass39.gclass45_0.gclass63_1 != null)
						GClass39.gclass45_0.gclass63_1.method_9();
					if (GClass39.gclass45_0.gclass63_2 != null)
						GClass39.gclass45_0.gclass63_2.method_9();
					if (GClass39.gclass145_0 == GClass154.smethod_8())
						GClass39.gclass45_0.method_79();
					return;
				}
				GClass39.gclass45_0.gclass141_0 = null;
				if (GClass58.smethod_1().gclass21_0 == null)
					GClass58.smethod_1().gclass21_0 = new GClass21();
				GClass58.smethod_1().gclass21_0.int_0 = num2;
				GClass58.smethod_1().gclass21_0.string_0 = msg.method_1().method_14();
				GClass58.smethod_1().gclass21_0.string_1 = msg.method_1().method_14();
				GClass58.smethod_1().gclass21_0.int_1 = msg.method_1().method_5();
				GClass58.smethod_1().gclass21_0.string_2 = msg.method_1().method_14();
				GClass58.smethod_1().gclass21_0.string_3 = msg.method_1().method_14();
				GClass58.smethod_1().gclass21_0.int_3 = msg.method_1().method_5();
				GClass58.smethod_1().gclass21_0.int_4 = msg.method_1().method_5();
				GClass58.smethod_1().sbyte_17 = msg.method_1().method_2();
				GClass58.smethod_1().gclass21_0.int_7 = msg.method_1().method_8();
				GClass58.smethod_1().gclass21_0.int_6 = msg.method_1().method_2();
				GClass39.gclass45_0.gclass63_2 = new GClass63();
				for (int k = 0; k < GClass58.smethod_1().gclass21_0.int_3; k++)
				{
					GClass206 gClass5 = new GClass206();
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
					gClass5.string_2 = GClass95.smethod_6(msg.method_1().method_8());
					GClass39.gclass45_0.gclass63_2.method_0(gClass5);
				}
				int num3 = msg.method_1().method_5();
				for (int l = 0; l < num3; l++)
				{
					method_8(msg, -1);
				}
				if (GClass39.gclass45_0.bool_10 || GClass39.gclass45_0.bool_12 || GClass39.gclass45_0.bool_11)
					GClass39.gclass45_0.method_79();
				if (flag)
					GClass39.gclass45_0.method_79();
				GClass56.smethod_8("=>>>>>>>>>>>>>>>>>>>>>> -537 MY CLAN INFO");
				break;
			}
			case -52:
			{
				sbyte b49 = msg.method_1().method_2();
				if (b49 == 0)
				{
					GClass206 gClass47 = new GClass206();
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
					gClass47.string_2 = GClass95.smethod_6(msg.method_1().method_8());
					if (GClass39.gclass45_0.gclass63_2 == null)
						GClass39.gclass45_0.gclass63_2 = new GClass63();
					GClass39.gclass45_0.gclass63_2.method_0(gClass47);
					GClass39.gclass45_0.method_78();
				}
				if (b49 == 1)
				{
					GClass39.gclass45_0.gclass63_2.method_7(msg.method_1().method_2());
					GClass39.gclass45_0.int_41--;
					GClass39.gclass45_0.method_78();
				}
				if (b49 == 2)
				{
					GClass206 gClass48 = new GClass206();
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
					gClass48.string_2 = GClass95.smethod_6(msg.method_1().method_8());
					for (int num142 = 0; num142 < GClass39.gclass45_0.gclass63_2.method_2(); num142++)
					{
						GClass206 gClass49 = (GClass206)GClass39.gclass45_0.gclass63_2.method_3(num142);
						if (gClass49.int_0 == gClass48.int_0)
						{
							if (GClass58.smethod_1().int_13 == gClass48.int_0)
								GClass58.smethod_1().sbyte_17 = gClass48.sbyte_0;
							GClass206 o = gClass48;
							GClass39.gclass45_0.gclass63_2.method_8(gClass49);
							GClass39.gclass45_0.gclass63_2.method_10(o, num142);
							return;
						}
					}
				}
				GClass56.smethod_8("=>>>>>>>>>>>>>>>>>>>>>> -52  MY CLAN UPDSTE");
				break;
			}
			case -51:
				GClass57.smethod_5();
				method_8(msg, 0);
				if (GClass39.gclass45_0.bool_11 && GClass39.gclass45_0.int_28 == 5)
					GClass39.gclass45_0.method_78();
				break;
			case -50:
			{
				GClass57.smethod_5();
				GClass39.gclass45_0.gclass63_1 = new GClass63();
				sbyte b47 = msg.method_1().method_2();
				for (int num140 = 0; num140 < b47; num140++)
				{
					GClass206 gClass46 = new GClass206();
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
					gClass46.string_2 = GClass95.smethod_6(msg.method_1().method_8());
					GClass39.gclass45_0.gclass63_1.method_0(gClass46);
				}
				GClass39.gclass45_0.bool_12 = true;
				GClass39.gclass45_0.bool_10 = false;
				GClass39.gclass45_0.bool_11 = false;
				GClass39.gclass45_0.int_41 = GClass39.gclass45_0.gclass63_1.method_2() + 2;
				GClass39.gclass45_0.method_78();
				break;
			}
			case -47:
			{
				GClass57.smethod_5();
				sbyte b36 = msg.method_1().method_2();
				GClass56.smethod_8("clan = " + b36);
				if (b36 == 0)
				{
					GClass39.gclass45_0.string_21 = mResources.cannot_find_clan;
					GClass39.gclass45_0.gclass21_1 = null;
				}
				else
				{
					GClass39.gclass45_0.gclass21_1 = new GClass21[b36];
					GClass56.smethod_8("clan search lent= " + GClass39.gclass45_0.gclass21_1.Length);
					for (int num107 = 0; num107 < GClass39.gclass45_0.gclass21_1.Length; num107++)
					{
						GClass39.gclass45_0.gclass21_1[num107] = new GClass21();
						GClass39.gclass45_0.gclass21_1[num107].int_0 = msg.method_1().method_8();
						GClass39.gclass45_0.gclass21_1[num107].string_0 = msg.method_1().method_14();
						GClass39.gclass45_0.gclass21_1[num107].string_1 = msg.method_1().method_14();
						GClass39.gclass45_0.gclass21_1[num107].int_1 = msg.method_1().method_5();
						GClass39.gclass45_0.gclass21_1[num107].string_2 = msg.method_1().method_14();
						GClass39.gclass45_0.gclass21_1[num107].string_3 = msg.method_1().method_14();
						GClass39.gclass45_0.gclass21_1[num107].int_3 = msg.method_1().method_5();
						GClass39.gclass45_0.gclass21_1[num107].int_4 = msg.method_1().method_5();
						GClass39.gclass45_0.gclass21_1[num107].int_2 = msg.method_1().method_8();
					}
				}
				GClass39.gclass45_0.bool_10 = true;
				GClass39.gclass45_0.bool_12 = false;
				GClass39.gclass45_0.bool_11 = false;
				if (GClass39.gclass45_0.bool_10)
					GClass39.gclass45_0.method_78();
				break;
			}
			case -46:
			{
				GClass57.smethod_5();
				sbyte b23 = msg.method_1().method_2();
				if (b23 == 1 || b23 == 3)
				{
					GClass39.smethod_29();
					GClass137.gclass63_0.method_9();
					int num60 = msg.method_1().method_5();
					for (int num61 = 0; num61 < num60; num61++)
					{
						GClass137 gClass23 = new GClass137();
						gClass23.int_0 = msg.method_1().method_5();
						gClass23.string_0 = msg.method_1().method_14();
						gClass23.int_1 = msg.method_1().method_8();
						gClass23.int_2 = msg.method_1().method_8();
						if (!GClass137.smethod_2(gClass23.int_0))
						{
							GClass137.smethod_0(gClass23);
							continue;
						}
						GClass137.smethod_1((short)gClass23.int_0).string_0 = gClass23.string_0;
						GClass137.smethod_1((short)gClass23.int_0).int_1 = gClass23.int_1;
						GClass137.smethod_1((short)gClass23.int_0).int_2 = gClass23.int_2;
					}
					if (GClass58.smethod_1().gclass21_0 != null)
						GClass39.gclass45_0.method_177();
				}
				if (b23 == 4)
				{
					GClass58.smethod_1().gclass21_0.int_1 = msg.method_1().method_5();
					GClass58.smethod_1().gclass21_0.string_1 = msg.method_1().method_14();
				}
				break;
			}
			case -45:
			{
				sbyte b6 = msg.method_1().method_2();
				int num12 = msg.method_1().method_8();
				short num13 = msg.method_1().method_6();
				GClass56.smethod_8(">.SKILL_NOT_FOCUS      skillNotFocusID: " + num13 + " skill type= " + b6 + "   player use= " + num12);
				if (b6 == 20)
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
					GClass56.smethod_8(">.SKILL_NOT_FOCUS  skill typeFrame= " + typeFrame);
					((GClass58.smethod_1().int_13 != num12) ? GClass154.smethod_14(num12) : GClass58.smethod_1()).method_157(num13, isFly, typeFrame, typePaint, dir, timeGong, typeItem);
				}
				if (b6 == 21)
				{
					GClass84 gClass8 = new GClass84();
					gClass8.int_0 = msg.method_1().method_6();
					gClass8.int_1 = msg.method_1().method_6();
					short timeDame = msg.method_1().method_6();
					short rangeDame = msg.method_1().method_6();
					sbyte typePaint2 = 0;
					sbyte typeItem2 = -1;
					GClass84[] array5 = null;
					gClass = ((GClass58.smethod_1().int_13 != num12) ? GClass154.smethod_14(num12) : GClass58.smethod_1());
					try
					{
						typePaint2 = msg.method_1().method_2();
						array5 = new GClass84[msg.method_1().method_2()];
						for (int num14 = 0; num14 < array5.Length; num14++)
						{
							array5[num14] = new GClass84();
							array5[num14].sbyte_0 = msg.method_1().method_2();
							if (array5[num14].sbyte_0 == 0)
								array5[num14].int_29 = msg.method_1().method_2();
							else
								array5[num14].int_29 = msg.method_1().method_8();
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
					GClass56.smethod_8(">.SKILL_NOT_FOCUS  skill targetDame= " + gClass8.int_0 + ":" + gClass8.int_1 + "    c:" + gClass.int_4 + ":" + gClass.int_5 + "   cdir:" + gClass.int_12);
					gClass.method_158(1, num13, gClass8, timeDame, rangeDame, typePaint2, array5, typeItem2);
				}
				if (b6 == 0)
				{
					GClass56.smethod_8("id use= " + num12);
					if (GClass58.smethod_1().int_13 != num12)
					{
						gClass = GClass154.smethod_14(num12);
						if ((GClass1.smethod_26(gClass.int_4, gClass.int_5) & 2) == 2)
							gClass.method_68(GClass154.gclass75_0[num13], 0);
						else
						{
							gClass.method_68(GClass154.gclass75_0[num13], 1);
							gClass.int_109 = 20;
						}
					}
					else
					{
						GClass58.smethod_1().method_27();
						GClass56.smethod_8("LOAD LAST SKILL");
					}
					sbyte b7 = msg.method_1().method_2();
					GClass56.smethod_8("npc size= " + b7);
					for (int num15 = 0; num15 < b7; num15++)
					{
						sbyte index = msg.method_1().method_2();
						sbyte int_ = msg.method_1().method_2();
						GClass56.smethod_8("index= " + index);
						if (num13 >= 42 && num13 <= 48)
						{
							((GClass85)GClass154.gclass63_9.method_3(index)).bool_2 = true;
							((GClass85)GClass154.gclass63_9.method_3(index)).int_4 = int_;
							((GClass85)GClass154.gclass63_9.method_3(index)).long_1 = (((GClass85)GClass154.gclass63_9.method_3(index)).long_2 = GClass138.smethod_18());
						}
					}
					sbyte b8 = msg.method_1().method_2();
					for (int num16 = 0; num16 < b8; num16++)
					{
						int num17 = msg.method_1().method_8();
						sbyte b9 = msg.method_1().method_2();
						GClass56.smethod_8("player ID= " + num17 + " my ID= " + GClass58.smethod_1().int_13);
						if (num13 < 42 || num13 > 48)
							continue;
						if (num17 == GClass58.smethod_1().int_13)
						{
							if (!GClass58.smethod_1().bool_46 && !GClass58.smethod_1().bool_47)
							{
								GClass154.smethod_8().bool_60 = true;
								GClass58.smethod_1().bool_22 = true;
								GClass58.smethod_1().int_80 = b9;
								GClass58.smethod_1().long_9 = (GClass58.smethod_1().long_10 = GClass138.smethod_18());
								GClass58.smethod_1().bool_36 = true;
							}
						}
						else
						{
							gClass = GClass154.smethod_14(num17);
							if (gClass != null && !gClass.bool_46 && !gClass.bool_47)
							{
								gClass.bool_22 = true;
								gClass.int_79 = b9;
								gClass.int_80 = b9;
								gClass.long_9 = (GClass154.smethod_14(num17).long_10 = GClass138.smethod_18());
							}
						}
					}
				}
				if (b6 == 1 && num12 != GClass58.smethod_1().int_13)
					GClass154.smethod_14(num12).bool_23 = true;
				if (b6 == 3)
				{
					if (num12 == GClass58.smethod_1().int_13)
					{
						GClass58.smethod_1().bool_23 = false;
						GClass29.smethod_1().method_45();
						GClass58.smethod_1().method_27();
					}
					else
						GClass154.smethod_14(num12).bool_23 = false;
				}
				if (b6 == 4)
				{
					if (num12 == GClass58.smethod_1().int_13)
					{
						GClass58.smethod_1().int_79 = msg.method_1().method_6() - 1000;
						GClass58.smethod_1().long_7 = GClass138.smethod_18();
						GClass56.smethod_8("second= " + GClass58.smethod_1().int_79 + " last= " + GClass58.smethod_1().long_7);
					}
					else if (GClass154.smethod_14(num12) != null)
					{
						int int_2 = GClass154.smethod_14(num12).int_14;
						if (int_2 != 0)
						{
							if (int_2 == 1)
								GClass154.smethod_14(num12).method_72(true);
						}
						else
							GClass154.smethod_14(num12).method_72(false);
						GClass154.smethod_14(num12).int_71 = num13;
						GClass154.smethod_14(num12).bool_45 = true;
						GClass154.smethod_14(num12).int_79 = msg.method_1().method_6();
						GClass154.smethod_14(num12).long_7 = GClass138.smethod_18();
					}
				}
				if (b6 == 5)
				{
					if (num12 == GClass58.smethod_1().int_13)
						GClass58.smethod_1().method_71();
					else if (GClass154.smethod_14(num12) != null)
					{
						GClass154.smethod_14(num12).method_71();
					}
				}
				if (b6 == 6)
				{
					if (num12 == GClass58.smethod_1().int_13)
						GClass58.smethod_1().method_73(GClass154.gclass75_0[num13], 0);
					else if (GClass154.smethod_14(num12) != null)
					{
						GClass154.smethod_14(num12).method_73(GClass154.gclass75_0[num13], 0);
						GClass29.smethod_1().method_8();
					}
				}
				if (b6 == 7)
				{
					if (num12 == GClass58.smethod_1().int_13)
					{
						GClass58.smethod_1().int_79 = msg.method_1().method_6();
						GClass56.smethod_8("second = " + GClass58.smethod_1().int_79);
						GClass58.smethod_1().long_7 = GClass138.smethod_18();
					}
					else if (GClass154.smethod_14(num12) != null)
					{
						GClass154.smethod_14(num12).method_72(true);
						GClass154.smethod_14(num12).int_79 = msg.method_1().method_6();
						GClass154.smethod_14(num12).long_7 = GClass138.smethod_18();
						GClass29.smethod_1().method_8();
					}
				}
				if (b6 == 8 && num12 != GClass58.smethod_1().int_13 && GClass154.smethod_14(num12) != null)
					GClass154.smethod_14(num12).method_73(GClass154.gclass75_0[num13], 0);
				break;
			}
			case -44:
			{
				bool flag9 = false;
				if (GClass39.int_10 > 2 * GClass45.int_55)
					flag9 = true;
				sbyte b37 = msg.method_1().method_2();
				int num108 = msg.method_1().method_5();
				GClass58.smethod_1().gclass121_3 = new GClass121[num108][];
				GClass39.gclass45_0.string_10 = new string[num108 + ((!flag9) ? 1 : 0)][];
				for (int num109 = 0; num109 < GClass39.gclass45_0.string_10.Length; num109++)
				{
					GClass39.gclass45_0.string_10[num109] = new string[2];
				}
				if (b37 == 2)
				{
					GClass39.gclass45_0.int_37 = new int[num108];
					GClass39.gclass45_0.int_38 = new int[num108];
				}
				if (!flag9)
					GClass39.gclass45_0.string_10[num108] = mResources.inventory;
				for (int num110 = 0; num110 < num108; num110++)
				{
					string[] array11 = GClass56.smethod_30(msg.method_1().method_14(), "\n", 0);
					if (b37 == 2)
						GClass39.gclass45_0.int_37[num110] = msg.method_1().method_5();
					if (array11.Length == 2)
						GClass39.gclass45_0.string_10[num110] = array11;
					if (array11.Length == 1)
					{
						GClass39.gclass45_0.string_10[num110][0] = array11[0];
						GClass39.gclass45_0.string_10[num110][1] = string.Empty;
					}
					int num111 = msg.method_1().method_5();
					GClass58.smethod_1().gclass121_3[num110] = new GClass121[num111];
					GClass45.string_26 = mResources.say_wat_do_u_want_to_buy;
					if (b37 == 1)
						GClass45.string_26 = mResources.say_wat_do_u_want_to_buy2;
					for (int num112 = 0; num112 < num111; num112++)
					{
						short num113 = msg.method_1().method_6();
						if (num113 == -1)
							continue;
						GClass58.smethod_1().gclass121_3[num110][num112] = new GClass121();
						GClass58.smethod_1().gclass121_3[num110][num112].gclass118_0 = GClass83.smethod_1(num113);
						GClass56.smethod_8("name " + num110 + " = " + GClass58.smethod_1().gclass121_3[num110][num112].gclass118_0.string_0 + " id templat= " + GClass58.smethod_1().gclass121_3[num110][num112].gclass118_0.short_0);
						if (b37 == 8)
						{
							GClass58.smethod_1().gclass121_3[num110][num112].int_34 = msg.method_1().method_8();
							GClass58.smethod_1().gclass121_3[num110][num112].int_36 = msg.method_1().method_8();
							GClass58.smethod_1().gclass121_3[num110][num112].int_30 = msg.method_1().method_8();
						}
						else if (b37 == 4)
						{
							GClass58.smethod_1().gclass121_3[num110][num112].string_2 = msg.method_1().method_14();
						}
						else if (b37 == 0)
						{
							GClass58.smethod_1().gclass121_3[num110][num112].int_34 = msg.method_1().method_8();
							GClass58.smethod_1().gclass121_3[num110][num112].int_36 = msg.method_1().method_8();
						}
						else if (b37 == 1)
						{
							GClass58.smethod_1().gclass121_3[num110][num112].long_0 = msg.method_1().method_9();
						}
						else if (b37 == 2)
						{
							GClass58.smethod_1().gclass121_3[num110][num112].int_27 = msg.method_1().method_6();
							GClass58.smethod_1().gclass121_3[num110][num112].int_34 = msg.method_1().method_8();
							GClass58.smethod_1().gclass121_3[num110][num112].int_36 = msg.method_1().method_8();
							GClass58.smethod_1().gclass121_3[num110][num112].sbyte_32 = msg.method_1().method_2();
							GClass58.smethod_1().gclass121_3[num110][num112].int_30 = msg.method_1().method_8();
							GClass58.smethod_1().gclass121_3[num110][num112].sbyte_33 = msg.method_1().method_2();
						}
						else if (b37 == 3)
						{
							GClass58.smethod_1().gclass121_3[num110][num112].bool_3 = true;
							GClass58.smethod_1().gclass121_3[num110][num112].short_0 = msg.method_1().method_6();
							GClass58.smethod_1().gclass121_3[num110][num112].int_39 = msg.method_1().method_8();
						}
						int num114 = msg.method_1().method_5();
						if (num114 != 0)
						{
							GClass58.smethod_1().gclass121_3[num110][num112].gclass20_0 = new GClass20[num114];
							for (int num115 = 0; num115 < GClass58.smethod_1().gclass121_3[num110][num112].gclass20_0.Length; num115++)
							{
								int optionTemplateId5 = msg.method_1().method_5();
								int param5 = msg.method_1().method_7();
								GClass58.smethod_1().gclass121_3[num110][num112].gclass20_0[num115] = new GClass20(optionTemplateId5, param5);
								GClass58.smethod_1().gclass121_3[num110][num112].int_43 = GClass39.gclass45_0.method_131(GClass58.smethod_1().gclass121_3[num110][num112]);
							}
						}
						sbyte b38 = msg.method_1().method_2();
						GClass58.smethod_1().gclass121_3[num110][num112].bool_4 = ((b38 != 0) ? true : false);
						if (msg.method_1().method_2() == 1)
						{
							int headTemp = msg.method_1().method_6();
							int bodyTemp = msg.method_1().method_6();
							int legTemp = msg.method_1().method_6();
							int bagTemp = msg.method_1().method_6();
							GClass58.smethod_1().gclass121_3[num110][num112].method_23(headTemp, bodyTemp, legTemp, bagTemp);
						}
						if (b37 == 2 && GClass113.int_3 >= 237)
						{
							GClass58.smethod_1().gclass121_3[num110][num112].string_3 = msg.method_1().method_14();
							GClass56.smethod_10("nguoi ki gui  " + GClass58.smethod_1().gclass121_3[num110][num112].string_3);
						}
					}
				}
				if (flag9)
				{
					if (b37 != 2)
					{
						GClass39.gclass45_1 = new GClass45();
						GClass39.gclass45_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
						GClass39.gclass45_1.method_15();
						GClass39.gclass45_1.method_50();
					}
					else
					{
						GClass39.gclass45_1 = new GClass45();
						GClass39.gclass45_1.method_10();
						GClass39.gclass45_1.method_50();
					}
				}
				GClass39.gclass45_0.string_17[1] = GClass39.gclass45_0.string_10;
				if (b37 == 2)
				{
					string[][] array12 = GClass39.gclass45_0.string_17[1];
					if (flag9)
						GClass39.gclass45_0.string_17[1] = new string[4][]
						{
							array12[0],
							array12[1],
							array12[2],
							array12[3]
						};
					else
						GClass39.gclass45_0.string_17[1] = new string[5][]
						{
							array12[0],
							array12[1],
							array12[2],
							array12[3],
							array12[4]
						};
				}
				GClass39.gclass45_0.method_33(b37);
				GClass39.gclass45_0.method_50();
				break;
			}
			case -43:
			{
				sbyte itemAction = msg.method_1().method_2();
				sbyte where = msg.method_1().method_2();
				sbyte index3 = msg.method_1().method_2();
				string info3 = msg.method_1().method_14();
				GClass39.gclass45_0.method_193(itemAction, info3, where, index3);
				break;
			}
			case -42:
				GClass58.smethod_1().int_155 = msg.method_3();
				GClass58.smethod_1().int_156 = msg.method_3();
				GClass58.smethod_1().int_154 = msg.method_1().method_8();
				GClass58.smethod_1().int_35 = msg.method_3();
				GClass58.smethod_1().int_36 = msg.method_3();
				GClass58.smethod_1().int_25 = msg.method_3();
				GClass58.smethod_1().int_24 = msg.method_3();
				GClass58.smethod_1().int_18 = msg.method_1().method_2();
				GClass58.smethod_1().sbyte_30 = msg.method_1().method_2();
				GClass58.smethod_1().sbyte_31 = msg.method_1().method_2();
				GClass58.smethod_1().sbyte_32 = msg.method_1().method_2();
				GClass58.smethod_1().int_20 = msg.method_1().method_8();
				GClass58.smethod_1().int_21 = msg.method_1().method_8();
				GClass58.smethod_1().int_22 = msg.method_1().method_2();
				GClass58.smethod_1().long_4 = msg.method_1().method_9();
				GClass58.smethod_1().short_25 = msg.method_1().method_6();
				GClass58.smethod_1().int_157 = msg.method_1().method_6();
				GClass58.smethod_1().int_158 = msg.method_1().method_2();
				GClass57.smethod_5();
				break;
			case -41:
			{
				sbyte b35 = msg.method_1().method_2();
				GClass58.smethod_1().string_5 = new string[b35];
				for (int num106 = 0; num106 < b35; num106++)
				{
					string text5 = msg.method_1().method_14();
					GClass58.smethod_1().string_5[num106] = text5;
				}
				GClass56.smethod_8("---   xong  level caption cmd : " + msg.sbyte_0);
				break;
			}
			case -37:
			{
				sbyte b34 = msg.method_1().method_2();
				GClass56.smethod_8("cAction= " + b34);
				if (b34 != 0)
					break;
				GClass58.smethod_1().int_119 = msg.method_1().method_6();
				GClass58.smethod_1().method_60();
				int num96 = msg.method_1().method_5();
				GClass56.smethod_8("num body = " + num96);
				GClass58.smethod_1().gclass121_2 = new GClass121[num96];
				for (int num97 = 0; num97 < num96; num97++)
				{
					short num98 = msg.method_1().method_6();
					if (num98 == -1)
						continue;
					GClass58.smethod_1().gclass121_2[num97] = new GClass121();
					GClass58.smethod_1().gclass121_2[num97].gclass118_0 = GClass83.smethod_1(num98);
					int num99 = GClass58.smethod_1().gclass121_2[num97].gclass118_0.sbyte_0;
					GClass58.smethod_1().gclass121_2[num97].int_30 = msg.method_1().method_8();
					GClass58.smethod_1().gclass121_2[num97].string_0 = msg.method_1().method_14();
					GClass58.smethod_1().gclass121_2[num97].string_1 = msg.method_1().method_14();
					int num100 = msg.method_1().method_5();
					if (num100 != 0)
					{
						GClass58.smethod_1().gclass121_2[num97].gclass20_0 = new GClass20[num100];
						for (int num101 = 0; num101 < GClass58.smethod_1().gclass121_2[num97].gclass20_0.Length; num101++)
						{
							int optionTemplateId4 = msg.method_1().method_5();
							int param4 = msg.method_1().method_7();
							GClass58.smethod_1().gclass121_2[num97].gclass20_0[num101] = new GClass20(optionTemplateId4, param4);
						}
					}
					int num102 = num99;
					if (num102 != 0)
					{
						if (num102 == 1)
							GClass58.smethod_1().int_120 = GClass58.smethod_1().gclass121_2[num97].gclass118_0.short_2;
					}
					else
						GClass58.smethod_1().int_121 = GClass58.smethod_1().gclass121_2[num97].gclass118_0.short_2;
				}
				break;
			}
			case -36:
			{
				sbyte b21 = msg.method_1().method_2();
				GClass56.smethod_8("cAction= " + b21);
				if (b21 == 0)
				{
					int num52 = msg.method_1().method_5();
					GClass58.smethod_1().gclass121_0 = new GClass121[num52];
					GClass154.int_37 = 0;
					GClass56.smethod_8("numC=" + num52);
					for (int num53 = 0; num53 < num52; num53++)
					{
						short num54 = msg.method_1().method_6();
						if (num54 == -1)
							continue;
						GClass58.smethod_1().gclass121_0[num53] = new GClass121();
						GClass58.smethod_1().gclass121_0[num53].gclass118_0 = GClass83.smethod_1(num54);
						GClass58.smethod_1().gclass121_0[num53].int_30 = msg.method_1().method_8();
						GClass58.smethod_1().gclass121_0[num53].string_0 = msg.method_1().method_14();
						GClass58.smethod_1().gclass121_0[num53].string_1 = msg.method_1().method_14();
						GClass58.smethod_1().gclass121_0[num53].int_29 = num53;
						int num55 = msg.method_1().method_5();
						if (num55 != 0)
						{
							GClass58.smethod_1().gclass121_0[num53].gclass20_0 = new GClass20[num55];
							for (int num56 = 0; num56 < GClass58.smethod_1().gclass121_0[num53].gclass20_0.Length; num56++)
							{
								int optionTemplateId2 = msg.method_1().method_5();
								int param2 = msg.method_1().method_7();
								GClass58.smethod_1().gclass121_0[num53].gclass20_0[num56] = new GClass20(optionTemplateId2, param2);
							}
							GClass58.smethod_1().gclass121_0[num53].int_43 = GClass39.gclass45_0.method_131(GClass58.smethod_1().gclass121_0[num53]);
						}
						if (GClass58.smethod_1().gclass121_0[num53].gclass118_0.sbyte_0 == 11)
							;
						if (GClass58.smethod_1().gclass121_0[num53].gclass118_0.sbyte_0 == 6)
							GClass154.int_37 += GClass58.smethod_1().gclass121_0[num53].int_30;
					}
				}
				if (b21 == 2)
				{
					sbyte b22 = msg.method_1().method_2();
					int int_6 = msg.method_1().method_8();
					int int_7 = GClass58.smethod_1().gclass121_0[b22].int_30;
					GClass58.smethod_1().gclass121_0[b22].int_30 = int_6;
					if (GClass58.smethod_1().gclass121_0[b22].int_30 < int_7 && GClass58.smethod_1().gclass121_0[b22].gclass118_0.sbyte_0 == 6)
						GClass154.int_37 -= int_7 - GClass58.smethod_1().gclass121_0[b22].int_30;
					if (GClass58.smethod_1().gclass121_0[b22].int_30 == 0)
						GClass58.smethod_1().gclass121_0[b22] = null;
				}
				break;
			}
			case -35:
			{
				sbyte b14 = msg.method_1().method_2();
				GClass56.smethod_8("cAction= " + b14);
				if (b14 == 0)
				{
					int num27 = msg.method_1().method_5();
					GClass58.smethod_1().gclass121_1 = new GClass121[num27];
					GClass39.gclass45_0.int_39 = 0;
					for (int num28 = 0; num28 < num27; num28++)
					{
						short num29 = msg.method_1().method_6();
						if (num29 == -1)
							continue;
						GClass58.smethod_1().gclass121_1[num28] = new GClass121();
						GClass58.smethod_1().gclass121_1[num28].gclass118_0 = GClass83.smethod_1(num29);
						GClass58.smethod_1().gclass121_1[num28].int_30 = msg.method_1().method_8();
						GClass58.smethod_1().gclass121_1[num28].string_0 = msg.method_1().method_14();
						GClass58.smethod_1().gclass121_1[num28].string_1 = msg.method_1().method_14();
						int num30 = msg.method_1().method_5();
						if (num30 != 0)
						{
							GClass58.smethod_1().gclass121_1[num28].gclass20_0 = new GClass20[num30];
							for (int num31 = 0; num31 < GClass58.smethod_1().gclass121_1[num28].gclass20_0.Length; num31++)
							{
								int optionTemplateId = msg.method_1().method_5();
								int param = msg.method_1().method_7();
								GClass58.smethod_1().gclass121_1[num28].gclass20_0[num31] = new GClass20(optionTemplateId, param);
							}
						}
						GClass39.gclass45_0.int_39++;
					}
				}
				if (b14 == 1)
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
					GClass39.gclass45_0.method_34();
					GClass39.gclass45_0.bool_8 = bool_;
					GClass39.gclass45_0.method_50();
				}
				if (b14 == 2)
				{
					sbyte b15 = msg.method_1().method_2();
					int int_5 = msg.method_1().method_8();
					GClass58.smethod_1().gclass121_1[b15].int_30 = int_5;
					if (GClass58.smethod_1().gclass121_1[b15].int_30 == 0)
						GClass58.smethod_1().gclass121_1[b15] = null;
				}
				break;
			}
			case -34:
			{
				sbyte b3 = msg.method_1().method_2();
				GClass56.smethod_8("act= " + b3);
				if (b3 == 0 && GClass154.smethod_8().gclass60_0 != null)
				{
					GClass56.smethod_8("toi duoc day");
					GClass60 gclass60_ = GClass154.smethod_8().gclass60_0;
					gclass60_.int_191 = msg.method_1().method_6();
					gclass60_.string_16 = msg.method_1().method_14();
					gclass60_.string_16 = GClass56.smethod_15(gclass60_.string_16);
					gclass60_.int_193 = msg.method_1().method_6();
					gclass60_.int_194 = msg.method_1().method_6();
					gclass60_.int_192 = msg.method_1().method_2();
					gclass60_.int_195 = msg.method_1().method_6();
					gclass60_.int_197 = msg.method_1().method_6();
					GClass56.smethod_8("curr Peas= " + gclass60_.int_195);
					gclass60_.string_15 = msg.method_1().method_14();
					gclass60_.int_202 = msg.method_1().method_8();
					gclass60_.int_198 = gclass60_.int_202;
					sbyte b4 = msg.method_1().method_2();
					gclass60_.int_199 = new int[b4];
					gclass60_.int_200 = new int[b4];
					for (int i = 0; i < b4; i++)
					{
						gclass60_.int_199[i] = msg.method_1().method_2();
						gclass60_.int_200[i] = msg.method_1().method_2();
					}
					gclass60_.bool_83 = msg.method_1().method_10();
					gclass60_.long_20 = (gclass60_.long_21 = GClass138.smethod_18());
					GClass154.smethod_8().gclass60_0.bool_84 = true;
				}
				if (b3 == 1)
				{
					gClass3 = new GClass63();
					try
					{
						while (msg.method_1().method_18() > 0)
						{
							gClass3.method_0(new GClass14(msg.method_1().method_14(), GClass39.gclass39_0, 888392, null));
						}
					}
					catch (Exception ex)
					{
						GClass5.smethod_0("Loi MAGIC_TREE " + ex.ToString());
					}
					GClass39.gclass0_0.method_2(gClass3, 3);
				}
				if (b3 == 2)
				{
					GClass154.smethod_8().gclass60_0.int_196 = msg.method_1().method_6();
					GClass154.smethod_8().gclass60_0.int_202 = msg.method_1().method_8();
					GClass154.smethod_8().gclass60_0.long_20 = (GClass154.smethod_8().gclass60_0.long_21 = GClass138.smethod_18());
					GClass154.smethod_8().gclass60_0.bool_84 = true;
					GClass154.smethod_8().gclass60_0.bool_86 = true;
				}
				break;
			}
			case -32:
			{
				short id4 = msg.method_1().method_6();
				int num164 = msg.method_1().method_8();
				sbyte[] array18 = null;
				GClass2 gClass53 = null;
				try
				{
					array18 = new sbyte[num164];
					for (int num165 = 0; num165 < num164; num165++)
					{
						array18[num165] = msg.method_1().method_2();
					}
					gClass53 = GClass2.smethod_6(array18, 0, num164);
					GClass107.gclass9_0.method_4(id4 + string.Empty, gClass53);
				}
				catch (Exception)
				{
					array18 = null;
					GClass107.gclass9_0.method_4(id4 + string.Empty, GClass2.smethod_9(new int[1], 1, 1, true));
				}
				if (array18 != null)
				{
					if (GClass76.int_12 > 1)
						GClass120.smethod_0(GClass76.int_12 + "bgItem" + id4, array18);
					GClass108.smethod_2(id4, gClass53);
				}
				break;
			}
			case -31:
			{
				GClass1.gclass63_1.method_9();
				short num156 = msg.method_1().method_6();
				GClass56.smethod_10("[ITEM_BACKGROUND] nItem= " + num156);
				for (int num157 = 0; num157 < num156; num157++)
				{
					GClass107 gClass50 = new GClass107();
					gClass50.int_0 = num157;
					gClass50.short_0 = msg.method_1().method_6();
					gClass50.sbyte_0 = msg.method_1().method_2();
					gClass50.int_4 = msg.method_1().method_6();
					gClass50.int_5 = msg.method_1().method_6();
					sbyte b52 = msg.method_1().method_2();
					gClass50.int_7 = new int[b52];
					gClass50.int_8 = new int[b52];
					for (int num158 = 0; num158 < b52; num158++)
					{
						gClass50.int_7[num157] = msg.method_1().method_2();
						gClass50.int_8[num157] = msg.method_1().method_2();
					}
					GClass1.gclass63_1.method_0(gClass50);
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
				GClass152.int_22 = 2;
				GClass39.smethod_8("SA2", 2);
				GClass39.smethod_30(msg.method_1().method_14());
				GClass57.smethod_5();
				GClass149.bool_0 = false;
				GClass58.bool_35 = false;
				if (GClass39.gclass145_0 == GClass39.gclass149_0)
					GClass39.gclass152_0.switchToMe();
				break;
			case -25:
				GClass39.smethod_8("SA3", 2);
				GClass154.gclass210_0.method_7(msg.method_1().method_14(), 0);
				break;
			case -24:
				if (GClass39.gclass145_0 is GClass154)
					GClass39.long_6 = GClass138.smethod_18() + 3000L;
				else
					GClass39.long_6 = GClass138.smethod_18() + 30000L;
				GClass58.bool_35 = true;
				GClass5.smethod_0("GET MAP INFO");
				GClass154.smethod_8().gclass60_0 = null;
				GClass39.bool_4 = true;
				GClass39.smethod_8("SA75", 2);
				GClass154.smethod_5();
				GClass39.smethod_29();
				GClass1.gclass63_0.method_9();
				GClass24.gclass63_0.method_9();
				GClass138.smethod_26();
				GClass1.int_37 = msg.method_1().method_5();
				GClass1.sbyte_2 = msg.method_1().method_2();
				GClass1.int_25 = msg.method_1().method_2();
				GClass1.int_40 = msg.method_1().method_2();
				GClass5.smethod_0("load planet from server: " + GClass1.sbyte_2 + "bgType= " + GClass1.int_41 + ".............................");
				GClass1.int_43 = msg.method_1().method_2();
				GClass1.string_1 = msg.method_1().method_14();
				GClass1.int_39 = msg.method_1().method_2();
				GClass39.smethod_8("SA75x1", 2);
				try
				{
					GClass1.smethod_23(GClass1.int_37);
				}
				catch (Exception)
				{
					GClass166.smethod_0().method_92(GClass1.int_37);
					gclass110_0 = msg;
					return;
				}
				method_10(msg);
				try
				{
					GClass1.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
				}
				catch (Exception)
				{
				}
				GClass154.int_22 = GClass154.int_28;
				GClass154.int_23 = GClass154.int_29;
				break;
			case -22:
				GClass39.smethod_8("SA65", 2);
				GClass58.bool_34 = true;
				GClass58.bool_33 = true;
				GClass154.smethod_8().int_78 = 0;
				GClass154.smethod_8().int_77 = 0;
				GClass58.smethod_1().gclass85_0 = null;
				GClass58.smethod_1().gclass59_0 = null;
				GClass58.smethod_1().gclass58_0 = null;
				GClass58.smethod_1().gclass134_0 = null;
				GClass58.smethod_1().gclass63_3.method_9();
				GClass58.smethod_1().int_73 = -9999;
				GClass58.smethod_1().int_74 = -9999;
				GClass39.smethod_19();
				GClass154.smethod_8().method_34();
				GClass154.smethod_8().gclass14_1 = null;
				break;
			case -21:
			{
				GClass39.smethod_8("SA60", 2);
				short num138 = msg.method_1().method_6();
				for (int num139 = 0; num139 < GClass154.gclass63_6.method_2(); num139++)
				{
					if (((GClass134)GClass154.gclass63_6.method_3(num139)).int_9 == num138)
					{
						GClass154.gclass63_6.method_7(num139);
						break;
					}
				}
				break;
			}
			case -20:
			{
				GClass39.smethod_8("SA61", 2);
				GClass58.smethod_1().gclass134_0 = null;
				short num126 = msg.method_1().method_6();
				for (int num127 = 0; num127 < GClass154.gclass63_6.method_2(); num127++)
				{
					GClass134 gClass41 = (GClass134)GClass154.gclass63_6.method_3(num127);
					if (gClass41.int_9 != num126)
						continue;
					gClass41.method_0(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - 10);
					string text6 = msg.method_1().method_14();
					num = 0;
					try
					{
						num = msg.method_1().method_6();
						if (gClass41.gclass118_0.sbyte_0 == 9)
						{
							num = msg.method_1().method_6();
							GClass58.smethod_1().long_6 += num;
							GClass58.smethod_1().string_0 = GClass138.smethod_6(GClass58.smethod_1().long_6);
						}
						else if (gClass41.gclass118_0.sbyte_0 == 10)
						{
							num = msg.method_1().method_6();
							GClass58.smethod_1().int_68 += num;
							GClass58.smethod_1().string_1 = GClass138.smethod_6(GClass58.smethod_1().int_68);
						}
						else if (gClass41.gclass118_0.sbyte_0 == 34)
						{
							num = msg.method_1().method_6();
							GClass58.smethod_1().int_69 += num;
							GClass58.smethod_1().string_2 = GClass138.smethod_6(GClass58.smethod_1().int_69);
						}
					}
					catch (Exception)
					{
					}
					if (text6.Equals(string.Empty))
					{
						if (gClass41.gclass118_0.sbyte_0 == 9)
						{
							GClass154.smethod_19(((num >= 0) ? "+" : string.Empty) + num, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58, 0, -2, GClass49.int_4);
							GClass29.smethod_1().method_9();
						}
						else if (gClass41.gclass118_0.sbyte_0 == 10)
						{
							GClass154.smethod_19(((num >= 0) ? "+" : string.Empty) + num, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58, 0, -2, GClass49.int_5);
							GClass29.smethod_1().method_9();
						}
						else if (gClass41.gclass118_0.sbyte_0 == 34)
						{
							GClass154.smethod_19(((num >= 0) ? "+" : string.Empty) + num, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58, 0, -2, GClass49.int_3);
							GClass29.smethod_1().method_9();
						}
						else
						{
							GClass154.gclass210_0.method_7(mResources.you_receive + " " + ((num <= 0) ? string.Empty : (num + " ")) + gClass41.gclass118_0.string_0, 0);
							GClass29.smethod_1().method_9();
						}
						if (num > 0 && GClass58.smethod_1().gclass128_0 != null && GClass58.smethod_1().gclass128_0.short_0 == 4683)
						{
							GClass71.smethod_0(55, GClass58.smethod_1().gclass128_0.int_9, GClass58.smethod_1().gclass128_0.int_4, 1);
							GClass71.smethod_0(55, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, 1);
						}
					}
					else if (text6.Length == 1)
					{
						GClass5.smethod_4("strInf.Length =1:  " + text6);
					}
					else
					{
						GClass154.gclass210_0.method_7(text6, 0);
					}
					break;
				}
				break;
			}
			case -19:
			{
				GClass39.smethod_8("SA62", 2);
				short num128 = msg.method_1().method_6();
				gClass = GClass154.smethod_14(msg.method_1().method_8());
				for (int num129 = 0; num129 < GClass154.gclass63_6.method_2(); num129++)
				{
					GClass134 gClass42 = (GClass134)GClass154.gclass63_6.method_3(num129);
					if (gClass42.int_9 != num128)
						continue;
					if (gClass == null)
						return;
					gClass42.method_0(gClass.int_4, gClass.int_5 - 10);
					if (gClass42.int_1 < gClass.int_4)
						gClass.int_12 = -1;
					else if (gClass42.int_1 > gClass.int_4)
					{
						gClass.int_12 = 1;
					}
					break;
				}
				break;
			}
			case -18:
			{
				GClass39.smethod_8("SA63", 2);
				int num124 = msg.method_1().method_2();
				GClass154.gclass63_6.method_0(new GClass134(msg.method_1().method_6(), GClass58.smethod_1().gclass121_0[num124].gclass118_0.short_0, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, msg.method_1().method_6(), msg.method_1().method_6()));
				GClass58.smethod_1().gclass121_0[num124] = null;
				break;
			}
			case -14:
				GClass39.smethod_8("SA64", 2);
				gClass = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass == null)
					return;
				GClass154.gclass63_6.method_0(new GClass134(msg.method_1().method_6(), msg.method_1().method_6(), gClass.int_4, gClass.int_5, msg.method_1().method_6(), msg.method_1().method_6()));
				break;
			case -4:
			{
				GClass39.smethod_8("SA76", 2);
				gClass = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass == null)
					return;
				GClass39.smethod_8("SA76v1", 2);
				if ((GClass1.smethod_26(gClass.int_4, gClass.int_5) & 2) == 2)
					gClass.method_68(GClass154.gclass75_0[msg.method_1().method_5()], 0);
				else
					gClass.method_68(GClass154.gclass75_0[msg.method_1().method_5()], 1);
				GClass39.smethod_8("SA76v2", 2);
				gClass.gclass85_2 = new GClass85[msg.method_1().method_2()];
				for (int num94 = 0; num94 < gClass.gclass85_2.Length; num94++)
				{
					GClass85 gClass33 = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_2());
					gClass.gclass85_2[num94] = gClass33;
					if (num94 == 0)
					{
						if (gClass.int_4 <= gClass33.int_8)
							gClass.int_12 = 1;
						else
							gClass.int_12 = -1;
					}
				}
				GClass39.smethod_8("SA76v3", 2);
				gClass.gclass58_0 = null;
				gClass.gclass85_0 = gClass.gclass85_2[0];
				GClass58[] array10 = new GClass58[10];
				num = 0;
				try
				{
					for (num = 0; num < array10.Length; num++)
					{
						int num95 = msg.method_1().method_8();
						GClass58 gClass34 = (array10[num] = ((num95 != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num95) : GClass58.smethod_1()));
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
					GClass5.smethod_0("Loi PLAYER_ATTACK_N_P " + ex14.ToString());
				}
				GClass39.smethod_8("SA76v4", 2);
				if (num > 0)
				{
					gClass.gclass58_1 = new GClass58[num];
					for (num = 0; num < gClass.gclass58_1.Length; num++)
					{
						gClass.gclass58_1[num] = array10[num];
					}
					gClass.gclass58_0 = gClass.gclass58_1[0];
					gClass.gclass85_0 = null;
				}
				GClass39.smethod_8("SA76v5", 2);
				break;
			}
			case 0:
				method_1(msg);
				break;
			case 1:
			{
				bool flag6 = msg.method_1().method_10();
				GClass56.smethod_8("isRes= " + flag6);
				if (!flag6)
				{
					GClass39.smethod_30(msg.method_1().method_14());
					break;
				}
				GClass39.gclass149_0.bool_12 = false;
				GClass120.smethod_4("userAo" + GClass152.int_14, string.Empty);
				GClass39.smethod_29();
				GClass39.gclass149_0.method_9();
				break;
			}
			case 2:
				GClass58.bool_35 = false;
				GClass149.bool_13 = false;
				if (!GClass154.bool_2)
					GClass154.smethod_8().method_0();
				GClass107.smethod_0();
				GClass39.smethod_29();
				GClass158.bool_0 = true;
				GClass158.smethod_2().switchToMe();
				break;
			case 6:
				GClass39.smethod_8("SA70", 2);
				GClass58.smethod_1().long_6 = msg.method_1().method_9();
				GClass58.smethod_1().int_68 = msg.method_1().method_8();
				GClass58.smethod_1().int_69 = msg.method_1().method_8();
				GClass58.smethod_1().string_0 = GClass138.smethod_6(GClass58.smethod_1().long_6);
				GClass58.smethod_1().string_1 = GClass138.smethod_6(GClass58.smethod_1().int_68);
				GClass58.smethod_1().string_2 = GClass138.smethod_6(GClass58.smethod_1().int_69);
				GClass39.smethod_29();
				break;
			case 7:
			{
				sbyte type = msg.method_1().method_2();
				short id3 = msg.method_1().method_6();
				string info2 = msg.method_1().method_14();
				GClass39.gclass45_0.method_194(type, info2, id3);
				break;
			}
			case 11:
			{
				GClass39.smethod_8("SA9", 2);
				int num49 = msg.method_1().method_2();
				sbyte b20 = msg.method_1().method_2();
				if (b20 != 0)
					GClass85.gclass204_0[num49].gclass167_0.method_8(GClass95.smethod_2(msg), b20);
				else
					GClass85.gclass204_0[num49].gclass167_0.method_7(GClass95.smethod_2(msg));
				for (int num50 = 0; num50 < GClass154.gclass63_9.method_2(); num50++)
				{
					gClass2 = (GClass85)GClass154.gclass63_9.method_3(num50);
					if (gClass2.int_26 == num49)
					{
						gClass2.int_20 = GClass85.gclass204_0[num49].gclass167_0.int_2;
						gClass2.int_21 = GClass85.gclass204_0[num49].gclass167_0.int_3;
					}
				}
				sbyte[] array7 = GClass95.smethod_2(msg);
				GClass2 gclass2_ = GClass2.smethod_6(array7, 0, array7.Length);
				GClass85.gclass204_0[num49].gclass167_0.gclass2_0 = gclass2_;
				int num51 = msg.method_1().method_2();
				GClass85.gclass204_0[num49].gclass167_0.int_1 = num51;
				if (num51 == 1 || num51 == 2)
					method_20(msg, num49);
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
				gClass3 = new GClass63();
				msg.method_1().method_14();
				int num37 = msg.method_1().method_2();
				for (int num38 = 0; num38 < num37; num38++)
				{
					gClass3.method_0(new GClass14(msg.method_1().method_14(), p: msg.method_1().method_6(), actionListener: GClass39.gclass39_0, action: 88819));
				}
				GClass39.gclass0_0.method_0(gClass3, 3);
				break;
			}
			case 29:
				GClass39.smethod_8("SA58", 2);
				GClass154.smethod_8().method_108(msg);
				break;
			case 32:
			{
				GClass39.smethod_8("SA68", 2);
				int num5 = msg.method_1().method_6();
				for (int m = 0; m < GClass154.gclass63_10.method_2(); m++)
				{
					GClass59 gClass6 = (GClass59)GClass154.gclass63_10.method_3(m);
					if (gClass6.gclass90_0.int_0 == num5 && gClass6.Equals(GClass58.smethod_1().gclass59_0))
					{
						string chat = msg.method_1().method_14();
						string[] array2 = new string[msg.method_1().method_2()];
						for (int n = 0; n < array2.Length; n++)
						{
							array2[n] = msg.method_1().method_14();
						}
						GClass154.smethod_8().method_18(array2, gClass6);
						GClass70.smethod_4(chat, 100000, gClass6);
						return;
					}
				}
				GClass59 gClass7 = new GClass59(num5, 0, -100, 100, num5, GClass154.gclass210_0.int_0[GClass58.smethod_1().int_14][2]);
				GClass56.smethod_8((GClass58.smethod_1().gclass59_0 == null) ? "null" : "!null");
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
				GClass56.smethod_8((GClass58.smethod_1().gclass59_0 == null) ? "null" : "!null");
				GClass154.smethod_8().method_18(array3, gClass7);
				GClass70.smethod_4(chat2, 100000, gClass7);
				break;
			}
			case 33:
			{
				GClass39.smethod_8("SA51", 2);
				GClass57.smethod_5();
				GClass39.smethod_27();
				GClass39.smethod_26();
				gClass3 = new GClass63();
				try
				{
					while (true)
					{
						gClass3.method_0(new GClass14(msg.method_1().method_14(), GClass39.gclass39_0, 88822, null));
					}
				}
				catch (Exception ex2)
				{
					GClass5.smethod_0("Loi OPEN_UI_MENU " + ex2.ToString());
				}
				if (GClass58.smethod_1().gclass59_0 == null)
					return;
				for (int j = 0; j < GClass58.smethod_1().gclass59_0.gclass90_0.string_1.Length; j++)
				{
					string[] array = GClass58.smethod_1().gclass59_0.gclass90_0.string_1[j];
					gClass3.method_0(new GClass14(array[0], GClass39.gclass39_0, 88820, array));
				}
				GClass39.gclass0_0.method_2(gClass3, 3);
				break;
			}
			case 38:
			{
				GClass39.smethod_8("SA67", 2);
				GClass57.smethod_5();
				int num162 = msg.method_1().method_6();
				GClass56.smethod_8("OPEN_UI_SAY ID= " + num162);
				string chat3 = GClass56.smethod_15(msg.method_1().method_14());
				for (int num163 = 0; num163 < GClass154.gclass63_10.method_2(); num163++)
				{
					GClass59 gClass51 = (GClass59)GClass154.gclass63_10.method_3(num163);
					GClass56.smethod_8("npc id= " + gClass51.gclass90_0.int_0);
					if (gClass51.gclass90_0.int_0 == num162)
					{
						GClass70.smethod_2(chat3, 100000, gClass51);
						GClass39.gclass45_0.method_150();
						return;
					}
				}
				GClass59 gClass52 = new GClass59(num162, 0, 0, 0, num162, GClass154.gclass210_0.int_0[GClass58.smethod_1().int_14][2]);
				if (gClass52.gclass90_0.int_0 == 5)
					gClass52.int_13 = 5;
				try
				{
					gClass52.int_70 = msg.method_1().method_6();
				}
				catch (Exception)
				{
				}
				GClass70.smethod_2(chat3, 100000, gClass52);
				GClass39.gclass45_0.method_150();
				break;
			}
			case 39:
				GClass39.smethod_8("SA49", 2);
				GClass154.smethod_8().int_68 = 2;
				if (GClass154.smethod_8().int_67 >= 2 && GClass154.smethod_8().int_68 >= 2)
					GClass57.smethod_1();
				break;
			case 40:
			{
				GClass39.smethod_8("SA52", 2);
				GClass39.int_9 = 150;
				short taskId = msg.method_1().method_6();
				sbyte index4 = msg.method_1().method_2();
				string name = GClass56.smethod_15(msg.method_1().method_14());
				string detail = GClass56.smethod_15(msg.method_1().method_14());
				string[] array15 = new string[msg.method_1().method_2()];
				string[] array16 = new string[array15.Length];
				GClass154.int_75 = new int[array15.Length];
				GClass154.int_76 = new int[array15.Length];
				short[] array17 = new short[array15.Length];
				short count = -1;
				for (int num153 = 0; num153 < array15.Length; num153++)
				{
					string text7 = GClass56.smethod_15(msg.method_1().method_14());
					GClass154.int_75[num153] = msg.method_1().method_2();
					GClass154.int_76[num153] = msg.method_1().method_6();
					string text8 = GClass56.smethod_15(msg.method_1().method_14());
					array17[num153] = -1;
					if (!text7.Equals(string.Empty))
					{
						array15[num153] = text7;
						array16[num153] = text8;
					}
				}
				try
				{
					count = msg.method_1().method_6();
					for (int num154 = 0; num154 < array15.Length; num154++)
					{
						array17[num154] = msg.method_1().method_6();
					}
				}
				catch (Exception ex23)
				{
					GClass5.smethod_0("Loi TASK_GET " + ex23.ToString());
				}
				GClass58.smethod_1().gclass36_0 = new GClass36(taskId, index4, name, detail, array15, array17, count, array16);
				if (GClass58.smethod_1().gclass59_0 != null)
					GClass59.smethod_10();
				GClass58.smethod_0(false);
				break;
			}
			case 41:
				GClass39.smethod_8("SA53", 2);
				GClass39.int_9 = 100;
				GClass56.smethod_8("TASK NEXT");
				GClass58.smethod_1().gclass36_0.int_0++;
				GClass58.smethod_1().gclass36_0.short_2 = 0;
				GClass59.smethod_10();
				GClass58.smethod_0(true);
				break;
			case 43:
				GClass39.int_9 = 50;
				GClass39.smethod_8("SA55", 2);
				GClass58.smethod_1().gclass36_0.short_2 = msg.method_1().method_6();
				if (GClass58.smethod_1().gclass59_0 != null)
					GClass59.smethod_10();
				try
				{
					short short_8 = msg.method_1().method_6();
					short short_9 = msg.method_1().method_6();
					GClass58.smethod_1().short_16 = short_8;
					GClass58.smethod_1().short_17 = short_9;
					GClass56.smethod_8("CMD   TASK_UPDATE:43_mapID =    x|y " + short_8 + "|" + short_9);
					for (int num143 = 0; num143 < GClass1.gclass63_0.method_2(); num143++)
					{
						GClass56.smethod_8("===> " + GClass1.gclass63_0.method_3(num143));
					}
				}
				catch (Exception)
				{
				}
				break;
			case 46:
				GClass39.smethod_8("SA5", 2);
				GClass5.smethod_5("Controler RESET_POINT  " + GClass58.bool_33);
				GClass58.bool_34 = false;
				GClass58.smethod_1().method_28(msg.method_1().method_6(), msg.method_1().method_6());
				break;
			case 47:
				GClass39.smethod_8("SA4", 2);
				GClass154.smethod_8().method_34();
				break;
			case 50:
			{
				sbyte b48 = msg.method_1().method_2();
				GClass45.gclass63_12.method_9();
				for (int num141 = 0; num141 < b48; num141++)
				{
					Class4 @class = new Class4();
					@class.short_0 = msg.method_1().method_6();
					@class.string_0 = msg.method_1().method_14();
					@class.string_1 = msg.method_1().method_14();
					GClass45.gclass63_12.method_0(@class);
					bool flag12 = (@class.bool_0 = ((GClass120.smethod_8(@class.short_0 + string.Empty) != -1) ? true : false));
				}
				break;
			}
			case 54:
			{
				gClass = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass == null)
					return;
				int num130 = msg.method_1().method_5();
				if ((GClass1.smethod_26(gClass.int_4, gClass.int_5) & 2) == 2)
					gClass.method_68(GClass154.gclass75_0[num130], 0);
				else
					gClass.method_68(GClass154.gclass75_0[num130], 1);
				GClass85[] array13 = new GClass85[10];
				num = 0;
				try
				{
					for (num = 0; num < array13.Length; num++)
					{
						GClass85 gClass43 = (array13[num] = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_2()));
						if (num == 0)
						{
							if (gClass.int_4 <= gClass43.int_8)
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
					gClass.gclass85_2 = new GClass85[num];
					for (num = 0; num < gClass.gclass85_2.Length; num++)
					{
						gClass.gclass85_2[num] = array13[num];
					}
					gClass.gclass58_0 = null;
					gClass.gclass85_0 = gClass.gclass85_2[0];
				}
				break;
			}
			case 56:
			{
				GClass39.smethod_8("SXX6", 2);
				gClass = null;
				int num84 = msg.method_1().method_8();
				if (num84 == GClass58.smethod_1().int_13)
				{
					bool flag7 = false;
					gClass = GClass58.smethod_1();
					gClass.int_25 = msg.method_3();
					int num85 = msg.method_3();
					GClass56.smethod_8("dame hit = " + num85);
					if (num85 != 0)
						gClass.method_111();
					int num86 = 0;
					try
					{
						flag7 = msg.method_1().method_11();
						sbyte b29 = msg.method_1().method_2();
						if (b29 != -1)
						{
							GClass56.smethod_8("hit eff= " + b29);
							GClass81.smethod_0(new GClass33(b29, gClass.int_4, gClass.int_5, 3, 1, -1));
						}
					}
					catch (Exception)
					{
					}
					num85 += num86;
					if (GClass58.smethod_1().sbyte_19 != 4)
					{
						if (num85 == 0)
							GClass154.smethod_19(mResources.miss, gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, GClass49.int_10);
						else
							GClass154.smethod_19("-" + num85, gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, flag7 ? GClass49.int_6 : GClass49.int_3);
					}
					break;
				}
				gClass = GClass154.smethod_14(num84);
				if (gClass == null)
					return;
				gClass.int_25 = msg.method_3();
				bool flag8 = false;
				int num87 = msg.method_3();
				if (num87 != 0)
					gClass.method_111();
				int num88 = 0;
				try
				{
					flag8 = msg.method_1().method_11();
					sbyte b30 = msg.method_1().method_2();
					if (b30 != -1)
					{
						GClass56.smethod_8("hit eff= " + b30);
						GClass81.smethod_0(new GClass33(b30, gClass.int_4, gClass.int_5, 3, 1, -1));
					}
				}
				catch (Exception)
				{
				}
				num87 += num88;
				if (gClass.sbyte_19 != 4)
				{
					if (num87 == 0)
						GClass154.smethod_19(mResources.miss, gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, GClass49.int_7);
					else
						GClass154.smethod_19("-" + num87, gClass.int_4, gClass.int_5 - gClass.int_58, 0, -3, flag8 ? GClass49.int_6 : GClass49.int_8);
				}
				break;
			}
			case 57:
			{
				GClass39.smethod_8("SZ6", 2);
				GClass63 gClass29 = new GClass63();
				gClass29.method_0(new GClass14(msg.method_1().method_14(), GClass39.gclass39_0, 88817, null));
				GClass39.gclass0_0.method_2(gClass29, 3);
				break;
			}
			case 58:
			{
				GClass39.smethod_8("SZ7", 2);
				int num77 = msg.method_1().method_8();
				GClass58 gClass27 = ((num77 != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num77) : GClass58.smethod_1());
				gClass27.short_11 = new short[3];
				gClass27.short_11[0] = 0;
				short num78 = msg.method_1().method_6();
				short num79 = msg.method_1().method_6();
				gClass27.short_11[1] = num78;
				gClass27.short_11[2] = num79;
				try
				{
					num77 = msg.method_1().method_8();
					GClass58 gClass28 = ((num77 != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num77) : GClass58.smethod_1());
					gClass28.int_4 = num78;
					gClass28.int_5 = num79;
				}
				catch (Exception ex10)
				{
					GClass5.smethod_0("Loi MOVE_FAST " + ex10.ToString());
				}
				break;
			}
			case 62:
				GClass39.smethod_8("SZ3", 2);
				gClass = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass != null)
				{
					gClass.int_74 = GClass58.smethod_1().int_13;
					GClass58.smethod_1().gclass59_0 = null;
					GClass58.smethod_1().gclass85_0 = null;
					GClass58.smethod_1().gclass134_0 = null;
					GClass58.smethod_1().gclass58_0 = gClass;
					GClass58.bool_56 = true;
					GClass154.gclass210_0.method_7(gClass.string_3 + mResources.CUU_SAT, 0);
				}
				break;
			case 63:
				GClass39.smethod_8("SZ4", 2);
				GClass58.smethod_1().int_74 = msg.method_1().method_8();
				GClass58.smethod_1().gclass59_0 = null;
				GClass58.smethod_1().gclass85_0 = null;
				GClass58.smethod_1().gclass134_0 = null;
				GClass58.smethod_1().gclass58_0 = GClass154.smethod_14(GClass58.smethod_1().int_74);
				GClass58.bool_56 = true;
				break;
			case 64:
				GClass39.smethod_8("SZ5", 2);
				gClass = GClass58.smethod_1();
				try
				{
					gClass = GClass154.smethod_14(msg.method_1().method_8());
				}
				catch (Exception ex9)
				{
					GClass5.smethod_0("Loi CLEAR_CUU_SAT " + ex9.ToString());
				}
				gClass.int_74 = -9999;
				break;
			case 65:
			{
				sbyte id2 = msg.method_1().method_0();
				string text4 = msg.method_1().method_14();
				short num59 = msg.method_1().method_6();
				if (GClass82.smethod_2(id2))
				{
					if (num59 != 0)
						GClass82.smethod_1(id2).method_0(id2, text4, num59);
					else
						GClass154.gclass63_0.method_8(GClass82.smethod_1(id2));
				}
				else
				{
					GClass82 gClass22 = new GClass82();
					gClass22.method_0(id2, text4, num59);
					GClass154.gclass63_0.method_0(gClass22);
				}
				break;
			}
			case 66:
				method_17(msg);
				break;
			case 68:
			{
				GClass56.smethod_8("ADD ITEM TO MAP --------------------------------------");
				GClass39.smethod_8("SA6333", 2);
				short itemMapID = msg.method_1().method_6();
				short itemTemplateID = msg.method_1().method_6();
				int x = msg.method_1().method_6();
				int y = msg.method_1().method_6();
				int num47 = msg.method_1().method_8();
				short r = 0;
				if (num47 == -2)
					r = msg.method_1().method_6();
				GClass134 gClass19 = new GClass134(num47, itemMapID, itemTemplateID, x, y, r);
				bool flag5 = false;
				for (int num48 = 0; num48 < GClass154.gclass63_6.method_2(); num48++)
				{
					if (((GClass134)GClass154.gclass63_6.method_3(num48)).int_9 == gClass19.int_9)
					{
						flag5 = true;
						break;
					}
				}
				if (!flag5)
					GClass154.gclass63_6.method_0(gClass19);
				break;
			}
			case 69:
				GClass29.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
				break;
			case 81:
				GClass39.smethod_8("SXX4", 2);
				((GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5())).bool_5 = msg.method_1().method_10();
				break;
			case 82:
				GClass39.smethod_8("SXX5", 2);
				((GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5())).bool_6 = msg.method_1().method_10();
				break;
			case 83:
			{
				GClass39.smethod_8("SXX8", 2);
				int num32 = msg.method_1().method_8();
				gClass = ((num32 != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num32) : GClass58.smethod_1());
				if (gClass == null)
					return;
				GClass85 mobToAttack = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5());
				if (gClass.gclass85_1 != null)
					gClass.gclass85_1.method_23(mobToAttack);
				break;
			}
			case 84:
			{
				int num26 = msg.method_1().method_8();
				if (num26 == GClass58.smethod_1().int_13)
					gClass = GClass58.smethod_1();
				else
				{
					gClass = GClass154.smethod_14(num26);
					if (gClass == null)
						return;
				}
				gClass.int_25 = gClass.int_35;
				gClass.int_24 = gClass.int_36;
				gClass.int_4 = msg.method_1().method_6();
				gClass.int_5 = msg.method_1().method_6();
				gClass.method_114();
				break;
			}
			case 85:
				GClass39.smethod_8("SXX5", 2);
				((GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5())).bool_7 = msg.method_1().method_10();
				break;
			case 86:
			{
				GClass39.smethod_8("SXX5", 2);
				GClass85 gClass9 = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5());
				gClass9.bool_8 = msg.method_1().method_10();
				if (!gClass9.bool_8)
					GClass71.smethod_0(77, gClass9.int_8, gClass9.int_9 - 9, 1);
				break;
			}
			case 87:
				GClass39.smethod_8("SXX5", 2);
				((GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5())).bool_9 = msg.method_1().method_10();
				break;
			case 88:
			{
				string info = msg.method_1().method_14();
				short num22 = msg.method_1().method_6();
				GClass39.gclass101_0.method_0(info, new GClass14(mResources.ACCEPT, GClass39.gclass39_0, 88818, num22), GClass67.int_11);
				break;
			}
			case 90:
				GClass39.smethod_8("SA577", 2);
				method_0(msg);
				break;
			case 92:
			{
				if (GClass39.gclass145_0 == GClass154.gclass154_0)
					GClass39.smethod_29();
				string text = msg.method_1().method_14();
				string text2 = GClass56.smethod_15(msg.method_1().method_14());
				string empty = string.Empty;
				GClass58 gClass4 = null;
				sbyte b2 = 0;
				if (!text.Equals(string.Empty))
				{
					gClass4 = new GClass58();
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
				GClass57.smethod_5();
				if (text.Equals(string.Empty))
				{
					GClass154.gclass210_0.method_7(empty, 0);
					break;
				}
				GClass154.gclass210_1.method_6(empty, gClass4, b2 == 0);
				if (GClass39.gclass45_0.bool_0 && GClass39.gclass45_0.int_28 == 8)
					GClass39.gclass45_0.method_80();
				break;
			}
			case 94:
				GClass39.smethod_8("SA3", 2);
				GClass154.gclass210_0.method_7(msg.method_1().method_14(), 0);
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
							for (int num171 = 0; num171 < GClass154.gclass63_10.method_2(); num171++)
							{
								GClass59 gClass55 = (GClass59)GClass154.gclass63_10.method_3(num171);
								if (gClass55.gclass90_0.int_0 == b59)
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
						GClass85 gClass56 = null;
						try
						{
							gClass56 = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						if (gClass56 != null)
						{
							gClass56.sbyte_14 = msg.method_1().method_2();
							if (gClass56.sbyte_14 > 0)
								gClass56.int_40 = GClass56.smethod_19(0, 3);
						}
					}
				}
				else
				{
					GClass58 gClass58;
					short num177;
					sbyte sbyte_2;
					switch (b58)
					{
					default:
					{
						if (b58 != 18)
						{
							if (b58 == 19)
							{
								GClass58.smethod_1().int_75 = msg.method_1().method_7();
								GClass58.smethod_1().int_76 = msg.method_1().method_7();
							}
							break;
						}
						sbyte b62 = msg.method_1().method_2();
						for (int num181 = 0; num181 < b62; num181++)
						{
							int charId = msg.method_1().method_8();
							int int_18 = msg.method_1().method_6();
							int int_19 = msg.method_1().method_6();
							int int_20 = msg.method_3();
							GClass58 gClass62 = GClass154.smethod_14(charId);
							if (gClass62 != null)
							{
								gClass62.int_4 = int_18;
								gClass62.int_5 = int_19;
								gClass62.int_25 = (gClass62.int_28 = int_20);
								gClass62.long_1 = GClass138.smethod_18();
							}
						}
						break;
					}
					case -17:
						GClass39.smethod_8("SA88", 2);
						GClass58.smethod_1().bool_62 = true;
						GClass58.smethod_1().sbyte_18 = msg.method_1().method_2();
						GClass58.smethod_1().method_112(msg.method_1().method_6(), msg.method_1().method_6());
						try
						{
							GClass58.smethod_1().long_2 = msg.method_1().method_9();
							GClass58.smethod_1().method_3();
						}
						catch (Exception)
						{
							GClass5.smethod_0("Loi tai ME_DIE " + msg.sbyte_0);
						}
						GClass58.smethod_1().int_75 = 0;
						break;
					case -16:
						GClass39.smethod_8("SA90", 2);
						if (GClass58.smethod_1().short_22 != 0 || GClass58.smethod_1().short_23 != 0)
						{
							GClass58.smethod_1().int_4 = GClass58.smethod_1().short_22;
							GClass58.smethod_1().int_5 = GClass58.smethod_1().short_23;
							GClass58 gClass70 = GClass58.smethod_1();
							GClass58.smethod_1().short_23 = 0;
							gClass70.short_22 = 0;
						}
						GClass58.smethod_1().method_114();
						GClass58.smethod_1().bool_36 = false;
						GClass58.smethod_1().bool_62 = false;
						break;
					case -13:
					{
						GClass39.smethod_8("SA82", 2);
						int num189 = msg.method_1().method_5();
						if (num189 > GClass154.gclass63_9.method_2() - 1 || num189 < 0)
							return;
						GClass85 gClass68 = (GClass85)GClass154.gclass63_9.method_3(num189);
						gClass68.int_29 = msg.method_1().method_2();
						gClass68.sbyte_14 = msg.method_1().method_2();
						if (gClass68.sbyte_14 != 0)
							gClass68.int_40 = GClass56.smethod_19(0, 3);
						gClass68.int_8 = gClass68.int_16;
						gClass68.int_9 = gClass68.int_17;
						gClass68.int_12 = 5;
						gClass68.bool_20 = false;
						gClass68.int_6 = msg.method_1().method_8();
						gClass68.int_7 = gClass68.int_6;
						gClass68.method_20();
						GClass71.smethod_0(60, gClass68.int_8, gClass68.int_9, 1);
						break;
					}
					case -12:
					{
						GClass56.smethod_8("SERVER SEND MOB DIE");
						GClass39.smethod_8("SA85", 2);
						GClass85 gClass63 = null;
						try
						{
							gClass63 = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
							GClass5.smethod_0("LOi tai NPC_DIE cmd " + msg.sbyte_0);
						}
						if (gClass63 == null || gClass63.int_12 == 0 || gClass63.int_12 == 0)
							break;
						gClass63.method_22();
						try
						{
							int num182 = msg.method_3();
							if (msg.method_1().method_10())
								GClass154.smethod_19("-" + num182, gClass63.int_8, gClass63.int_9 - gClass63.int_21, 0, -2, GClass49.int_6);
							else
								GClass154.smethod_19("-" + num182, gClass63.int_8, gClass63.int_9 - gClass63.int_21, 0, -2, GClass49.int_8);
							sbyte b63 = msg.method_1().method_2();
							for (int num183 = 0; num183 < b63; num183++)
							{
								GClass134 gClass64 = new GClass134(msg.method_1().method_6(), msg.method_1().method_6(), gClass63.int_8, gClass63.int_9, msg.method_1().method_6(), msg.method_1().method_6());
								GClass56.smethod_8("playerid= " + (int)(gClass64.int_8 = msg.method_1().method_8()) + " my id= " + GClass58.smethod_1().int_13);
								GClass154.gclass63_6.method_0(gClass64);
								if (GClass56.smethod_28(gClass64.int_2 - GClass58.smethod_1().int_5) < 24 && GClass56.smethod_28(gClass64.int_1 - GClass58.smethod_1().int_4) < 24)
									GClass58.smethod_1().gclass58_0 = null;
							}
						}
						catch (Exception)
						{
						}
						break;
					}
					case -11:
					{
						GClass39.smethod_8("SA86", 2);
						GClass85 gClass65 = null;
						try
						{
							int index5 = msg.method_1().method_5();
							gClass65 = (GClass85)GClass154.gclass63_9.method_3(index5);
						}
						catch (Exception ex33)
						{
							GClass56.smethod_8("Loi tai NPC_ATTACK_ME " + msg.sbyte_0 + " err= " + ex33.StackTrace);
						}
						if (gClass65 != null)
						{
							GClass58.smethod_1().bool_7 = false;
							GClass58.bool_34 = false;
							int num184 = msg.method_3();
							int num185;
							try
							{
								num185 = msg.method_3();
							}
							catch (Exception)
							{
								num185 = 0;
							}
							if (gClass65.bool_18)
							{
								GClass58.smethod_1().method_110(num184, num185, false, true);
								break;
							}
							gClass65.int_27 = num184;
							gClass65.int_28 = num185;
							gClass65.method_8(GClass58.smethod_1());
						}
						break;
					}
					case -10:
					{
						GClass39.smethod_8("SA87", 2);
						GClass85 gClass57 = null;
						try
						{
							gClass57 = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						GClass39.smethod_8("SA87x1", 2);
						if (gClass57 != null)
						{
							GClass39.smethod_8("SA87x2", 2);
							gClass = GClass154.smethod_14(msg.method_1().method_8());
							if (gClass == null)
								return;
							GClass39.smethod_8("SA87x3", 2);
							int num174 = msg.method_3();
							gClass57.int_27 = gClass.int_25 - num174;
							gClass.int_26 = num174;
							GClass39.smethod_8("SA87x4", 2);
							try
							{
								gClass.int_24 = msg.method_3();
							}
							catch (Exception)
							{
							}
							GClass39.smethod_8("SA87x5", 2);
							if (gClass57.bool_18)
								gClass.method_110(gClass57.int_27, 0, false, true);
							else
								gClass57.method_8(gClass);
							GClass39.smethod_8("SA87x6", 2);
						}
						break;
					}
					case -9:
					{
						GClass39.smethod_8("SA83", 2);
						GClass85 gClass66 = null;
						try
						{
							gClass66 = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5());
						}
						catch (Exception)
						{
						}
						GClass39.smethod_8("SA83v1", 2);
						if (gClass66 != null)
						{
							gClass66.int_6 = msg.method_3();
							gClass66.method_20();
							int num186 = msg.method_3();
							if (num186 == 1)
								return;
							if (num186 > 1)
								gClass66.method_7();
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
								GClass81.smethod_0(new GClass33(b64, gClass66.int_8, gClass66.getY(), 3, 1, -1));
							GClass39.smethod_8("SA83v2", 2);
							if (flag13)
								GClass154.smethod_19("-" + num186, gClass66.int_8, gClass66.getY() - gClass66.getH(), 0, -2, GClass49.int_6);
							else if (num186 == 0)
							{
								gClass66.int_8 = gClass66.int_16;
								gClass66.int_9 = gClass66.int_17;
								GClass154.smethod_19(mResources.miss, gClass66.int_8, gClass66.getY() - gClass66.getH(), 0, -2, GClass49.int_7);
							}
							else if (num186 > 1)
							{
								GClass154.smethod_19("-" + num186, gClass66.int_8, gClass66.getY() - gClass66.getH(), 0, -2, GClass49.int_8);
							}
						}
						GClass39.smethod_8("SA83v3", 2);
						break;
					}
					case -8:
						GClass39.smethod_8("SA89", 2);
						gClass = GClass154.smethod_14(msg.method_1().method_8());
						if (gClass == null)
							return;
						gClass.sbyte_18 = msg.method_1().method_2();
						gClass.method_113(msg.method_1().method_6(), msg.method_1().method_6());
						break;
					case -7:
					{
						GClass39.smethod_8("SA80", 2);
						int num187 = msg.method_1().method_8();
						for (int num188 = 0; num188 < GClass154.gclass63_5.method_2(); num188++)
						{
							GClass58 gClass67 = null;
							try
							{
								gClass67 = (GClass58)GClass154.gclass63_5.method_3(num188);
							}
							catch (Exception)
							{
							}
							if (gClass67 != null)
							{
								if (gClass67.int_13 == num187)
								{
									GClass39.smethod_8("SA8x2y" + num188, 2);
									gClass67.method_98(msg.method_1().method_6(), msg.method_1().method_6(), 0);
									gClass67.long_1 = GClass138.smethod_18();
									break;
								}
								continue;
							}
							break;
						}
						GClass39.smethod_8("SA80x3", 2);
						break;
					}
					case -6:
					{
						GClass39.smethod_8("SA81", 2);
						int num190 = msg.method_1().method_8();
						for (int num191 = 0; num191 < GClass154.gclass63_5.method_2(); num191++)
						{
							GClass58 gClass69 = (GClass58)GClass154.gclass63_5.method_3(num191);
							if (gClass69 != null && gClass69.int_13 == num190)
							{
								if (!gClass69.bool_20 && !gClass69.bool_3)
									GClass71.smethod_0(60, gClass69.int_4, gClass69.int_5, 1);
								if (!gClass69.bool_3)
									GClass154.gclass63_5.method_7(num191);
								return;
							}
						}
						break;
					}
					case -5:
					{
						GClass39.smethod_8("SA79", 2);
						int int_17 = msg.method_1().method_8();
						int num175 = msg.method_1().method_8();
						if (num175 != -100)
						{
							gClass58 = new GClass58();
							gClass58.int_13 = int_17;
							gClass58.int_56 = num175;
						}
						else
						{
							gClass58 = new Class1();
							gClass58.int_13 = int_17;
							gClass58.int_56 = num175;
						}
						if (gClass58.int_56 == -2)
							gClass58.bool_59 = true;
						if (method_16(gClass58, msg))
						{
							sbyte b60 = msg.method_1().method_2();
							if (gClass58.int_5 <= 10 && b60 != 0 && b60 != 2)
							{
								GClass56.smethod_8("nhân vật bay trên trời xuống x= " + gClass58.int_4 + " y= " + gClass58.int_5);
								GClass202 gClass59 = new GClass202(gClass58.int_4, gClass58.int_5, gClass58.int_119, gClass58.int_12, 1, false, (b60 != 1) ? b60 : gClass58.int_14);
								gClass59.int_5 = gClass58.int_13;
								gClass58.bool_2 = true;
								GClass202.smethod_0(gClass59);
							}
							if (b60 == 2)
								gClass58.method_36();
							for (int num176 = 0; num176 < GClass154.gclass63_9.method_2(); num176++)
							{
								GClass85 gClass60 = (GClass85)GClass154.gclass63_9.method_3(num176);
								if (gClass60 != null && gClass60.bool_13 && gClass60.int_25 == gClass58.int_13)
								{
									GClass56.smethod_8("co 1 con quai");
									gClass58.gclass85_1 = gClass60;
									gClass58.gclass85_1.int_8 = gClass58.int_4;
									gClass58.gclass85_1.int_9 = gClass58.int_5 - 40;
									break;
								}
							}
							if (GClass154.smethod_14(gClass58.int_13) == null)
								GClass154.gclass63_5.method_0(gClass58);
							gClass58.sbyte_35 = msg.method_1().method_2();
							num177 = msg.method_1().method_6();
							GClass56.smethod_8("mount id= " + num177 + "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
							if (num177 != -1)
							{
								gClass58.bool_25 = true;
								short num178 = num177;
								if (num178 <= 351)
								{
									if ((uint)(num178 - 346) > 2u)
									{
										if ((uint)(num178 - 349) > 2u)
											goto IL_a130;
										gClass58.bool_26 = true;
									}
									else
										gClass58.bool_26 = false;
								}
								else if (num178 != 396)
								{
									if (num178 != 532)
										goto IL_a130;
									gClass58.bool_28 = true;
								}
								else
								{
									gClass58.bool_27 = true;
								}
							}
							else
								gClass58.bool_25 = false;
						}
						goto IL_a171;
					}
					case -3:
					{
						GClass39.smethod_8("SA78", 2);
						sbyte b61 = msg.method_1().method_2();
						int num179 = msg.method_1().method_8();
						if (b61 == 0)
							GClass58.smethod_1().long_2 += num179;
						if (b61 == 1)
							GClass58.smethod_1().long_4 += num179;
						if (b61 == 2)
						{
							GClass58.smethod_1().long_2 += num179;
							GClass58.smethod_1().long_4 += num179;
						}
						GClass58.smethod_1().method_3();
						if (GClass58.smethod_1().sbyte_19 != 3)
						{
							GClass154.smethod_19(((num179 <= 0) ? string.Empty : "+") + num179, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58, 0, -4, GClass49.int_5);
							if (num179 > 0 && GClass58.smethod_1().gclass128_0 != null && GClass58.smethod_1().gclass128_0.short_0 == 5002)
							{
								GClass71.smethod_0(55, GClass58.smethod_1().gclass128_0.int_9, GClass58.smethod_1().gclass128_0.int_4, 1);
								GClass71.smethod_0(55, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, 1);
							}
						}
						break;
					}
					case -2:
					{
						GClass39.smethod_8("SA77", 22);
						int num173 = msg.method_1().method_8();
						GClass58.smethod_1().int_66 += num173;
						GClass154.smethod_19((num173 <= 0) ? (string.Empty + num173) : ("+" + num173), GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58 - 10, 0, -2, GClass49.int_4);
						break;
					}
					case -1:
					{
						GClass39.smethod_8("SA77", 222);
						int num172 = msg.method_1().method_8();
						GClass58.smethod_1().long_6 += num172;
						GClass58.smethod_1().string_0 = GClass138.smethod_6(GClass58.smethod_1().long_6);
						GClass58.smethod_1().int_66 -= num172;
						GClass154.smethod_19("+" + num172, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58 - 10, 0, -2, GClass49.int_4);
						break;
					}
					case -15:
					case -14:
					case -4:
						break;
						IL_a130:
						if (num177 >= GClass58.short_14)
							gClass58.short_15 = num177;
						goto IL_a171;
						IL_a171:
						sbyte_2 = msg.method_1().method_2();
						GClass56.smethod_8("addplayer:   " + sbyte_2);
						gClass58.sbyte_28 = sbyte_2;
						gClass58.bool_4 = msg.method_1().method_2() == 1;
						try
						{
							gClass58.short_28 = msg.method_1().method_6();
							gClass58.short_29 = msg.method_1().method_0();
							gClass58.short_30 = msg.method_1().method_6();
							if (gClass58.int_122 >= 201 && gClass58.int_122 < 255)
							{
								GClass33 gClass61 = new GClass33(gClass58.int_122, gClass58, 2, -1, 10, 1);
								gClass61.int_1 = 5;
								gClass58.method_138(gClass61);
							}
							else
							{
								for (int num180 = 0; num180 < 54; num180++)
								{
									gClass58.method_139(0, 201 + num180);
								}
							}
						}
						catch (Exception ex30)
						{
							GClass56.smethod_8("cmd: -5 err: " + ex30.StackTrace);
						}
						GClass154.smethod_8().method_114(gClass58.int_13, gClass58.sbyte_28);
						break;
					}
				}
			}
			else if (b58 <= 45)
			{
				if (b58 != 44)
				{
					if (b58 == 45)
					{
						GClass39.smethod_8("SA84", 2);
						GClass85 gClass71 = null;
						try
						{
							gClass71 = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5());
						}
						catch (Exception ex38)
						{
							GClass5.smethod_0("Loi tai NPC_MISS  " + ex38.ToString());
						}
						if (gClass71 != null)
						{
							gClass71.int_6 = msg.method_1().method_8();
							gClass71.method_20();
							GClass154.smethod_19(mResources.miss, gClass71.int_8, gClass71.int_9 - gClass71.int_21, 0, -2, GClass49.int_7);
						}
					}
				}
				else
				{
					GClass39.smethod_8("SA91", 2);
					int num192 = msg.method_1().method_8();
					string text9 = msg.method_1().method_14();
					GClass56.smethod_8("user id= " + num192 + " text= " + text9);
					gClass = ((GClass58.smethod_1().int_13 != num192) ? GClass154.smethod_14(num192) : GClass58.smethod_1());
					if (gClass == null)
						return;
					gClass.method_10(text9);
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
						GClass39.smethod_8("SA77", 22);
						int num194 = msg.method_1().method_8();
						GClass58.smethod_1().long_6 += num194;
						GClass58.smethod_1().string_0 = GClass138.smethod_6(GClass58.smethod_1().long_6);
						GClass154.smethod_19((num194 <= 0) ? (string.Empty + num194) : ("+" + num194), GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58 - 10, 0, -2, GClass49.int_4);
						break;
					}
					case 96:
						GClass39.smethod_8("SA77a", 22);
						GClass58.smethod_1().gclass63_4.method_0(new GClass127(msg.method_1().method_2(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_14(), msg.method_1().method_14(), msg.method_1().method_2(), msg.method_1().method_2()));
						break;
					case 97:
					{
						sbyte b65 = msg.method_1().method_2();
						for (int num193 = 0; num193 < GClass58.smethod_1().gclass63_4.method_2(); num193++)
						{
							GClass127 gClass72 = (GClass127)GClass58.smethod_1().gclass63_4.method_3(num193);
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
					GClass39.smethod_8("SA85", 2);
					GClass85 gClass73 = null;
					try
					{
						gClass73 = (GClass85)GClass154.gclass63_9.method_3(msg.method_1().method_5());
					}
					catch (Exception)
					{
						GClass5.smethod_0("Loi tai NPC CHANGE " + msg.sbyte_0);
					}
					if (gClass73 != null && gClass73.int_12 != 0 && gClass73.int_12 != 0)
					{
						gClass73.int_12 = 0;
						GClass71.smethod_0(60, gClass73.int_8, gClass73.int_9, 1);
						GClass134 gClass74 = new GClass134(msg.method_1().method_6(), msg.method_1().method_6(), gClass73.int_8, gClass73.int_9, msg.method_1().method_6(), msg.method_1().method_6());
						GClass154.gclass63_6.method_0(gClass74);
						if (GClass56.smethod_28(gClass74.int_2 - GClass58.smethod_1().int_5) < 24 && GClass56.smethod_28(gClass74.int_1 - GClass58.smethod_1().int_4) < 24)
							GClass58.smethod_1().gclass58_0 = null;
					}
				}
			}
			else
			{
				GClass56.smethod_8("ME DIE XP DOWN NOT IMPLEMENT YET!!!!!!!!!!!!!!!!!!!!!!!!!!");
			}
			GClass39.smethod_8("SA92", 2);
		}
		catch (Exception ex40)
		{
			GClass56.smethod_10("[Controller] [error] " + ex40.StackTrace + " msg: " + ex40.Message + " cause " + ex40.Data);
		}
		finally
		{
			msg?.method_4();
		}
	}

	private void method_1(GClass110 gclass110_1)
	{
		sbyte b = gclass110_1.method_1().method_2();
		GClass151.gclass209_0 = new GClass209[b];
		GClass56.smethod_8("[LEN] sl nguoi choi " + b);
		for (int i = 0; i < b; i++)
		{
			int playerID = gclass110_1.method_1().method_8();
			string name = gclass110_1.method_1().method_14();
			short head = gclass110_1.method_1().method_6();
			short body = gclass110_1.method_1().method_6();
			short leg = gclass110_1.method_1().method_6();
			long ppoint = gclass110_1.method_1().method_9();
			GClass151.gclass209_0[i] = new GClass209(playerID, name, head, body, leg, ppoint);
		}
		GClass39.gclass151_0.switchToMe();
		GClass39.gclass151_0.method_0((byte)b);
	}

	private void method_2(GClass131 gclass131_0)
	{
		GClass154.sbyte_3 = gclass131_0.method_2();
		GClass83.gclass9_0.method_1();
		GClass154.smethod_8().gclass114_0 = new GClass114[gclass131_0.method_5()];
		for (int i = 0; i < GClass154.smethod_8().gclass114_0.Length; i++)
		{
			GClass154.smethod_8().gclass114_0[i] = new GClass114();
			GClass154.smethod_8().gclass114_0[i].int_0 = i;
			GClass154.smethod_8().gclass114_0[i].string_0 = gclass131_0.method_14();
			GClass154.smethod_8().gclass114_0[i].int_1 = gclass131_0.method_2();
		}
		int num = gclass131_0.method_6();
		for (int j = 0; j < num; j++)
		{
			GClass83.smethod_0(new GClass118((short)j, gclass131_0.method_2(), gclass131_0.method_2(), gclass131_0.method_14(), gclass131_0.method_14(), gclass131_0.method_2(), gclass131_0.method_8(), gclass131_0.method_6(), gclass131_0.method_6(), gclass131_0.method_10()));
		}
	}

	private void method_3(GClass131 gclass131_0)
	{
		GClass154.sbyte_2 = gclass131_0.method_2();
		GClass154.smethod_8().gclass106_0 = new GClass106[gclass131_0.method_2()];
		for (int i = 0; i < GClass154.smethod_8().gclass106_0.Length; i++)
		{
			GClass154.smethod_8().gclass106_0[i] = new GClass106();
			GClass154.smethod_8().gclass106_0[i].int_0 = i;
			GClass154.smethod_8().gclass106_0[i].string_0 = gclass131_0.method_14();
		}
		GClass154.gclass109_0 = new GClass109[gclass131_0.method_2()];
		for (int j = 0; j < GClass154.gclass109_0.Length; j++)
		{
			GClass154.gclass109_0[j] = new GClass109();
			GClass154.gclass109_0[j].int_0 = j;
			GClass154.gclass109_0[j].string_0 = gclass131_0.method_14();
			GClass154.gclass109_0[j].gclass53_0 = new GClass53[gclass131_0.method_2()];
			for (int k = 0; k < GClass154.gclass109_0[j].gclass53_0.Length; k++)
			{
				GClass154.gclass109_0[j].gclass53_0[k] = new GClass53();
				GClass154.gclass109_0[j].gclass53_0[k].sbyte_0 = gclass131_0.method_2();
				GClass154.gclass109_0[j].gclass53_0[k].string_0 = gclass131_0.method_14();
				GClass154.gclass109_0[j].gclass53_0[k].int_1 = gclass131_0.method_2();
				GClass154.gclass109_0[j].gclass53_0[k].int_2 = gclass131_0.method_2();
				GClass154.gclass109_0[j].gclass53_0[k].int_3 = gclass131_0.method_2();
				GClass154.gclass109_0[j].gclass53_0[k].int_4 = gclass131_0.method_6();
				GClass154.gclass109_0[j].gclass53_0[k].string_2 = gclass131_0.method_14();
				int lineWidth = 130;
				if (GClass39.int_10 == 128 || GClass39.int_11 <= 208)
					lineWidth = 100;
				GClass154.gclass109_0[j].gclass53_0[k].string_1 = GClass49.gclass49_14.method_15(gclass131_0.method_14(), lineWidth);
				GClass154.gclass109_0[j].gclass53_0[k].gclass74_0 = new GClass74[gclass131_0.method_2()];
				for (int l = 0; l < GClass154.gclass109_0[j].gclass53_0[k].gclass74_0.Length; l++)
				{
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l] = new GClass74();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].short_0 = gclass131_0.method_6();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].gclass53_0 = GClass154.gclass109_0[j].gclass53_0[k];
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].int_0 = gclass131_0.method_2();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].long_0 = gclass131_0.method_9();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].int_5 = gclass131_0.method_6();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].int_1 = gclass131_0.method_8();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].int_2 = gclass131_0.method_6();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].int_3 = gclass131_0.method_6();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].int_4 = gclass131_0.method_2();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].short_1 = gclass131_0.method_6();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].short_2 = gclass131_0.method_6();
					GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l].string_0 = gclass131_0.method_14();
					GClass61.smethod_0(GClass154.gclass109_0[j].gclass53_0[k].gclass74_0[l]);
				}
			}
		}
	}

	private void method_4(GClass131 gclass131_0)
	{
		GClass154.sbyte_1 = gclass131_0.method_2();
		GClass1.string_2 = new string[gclass131_0.method_5()];
		for (int i = 0; i < GClass1.string_2.Length; i++)
		{
			GClass1.string_2[i] = gclass131_0.method_14();
		}
		GClass59.gclass90_1 = new GClass90[gclass131_0.method_2()];
		for (sbyte b = 0; b < GClass59.gclass90_1.Length; b++)
		{
			GClass59.gclass90_1[b] = new GClass90();
			GClass59.gclass90_1[b].int_0 = b;
			GClass59.gclass90_1[b].string_0 = gclass131_0.method_14();
			GClass59.gclass90_1[b].int_1 = gclass131_0.method_6();
			GClass59.gclass90_1[b].int_2 = gclass131_0.method_6();
			GClass59.gclass90_1[b].int_3 = gclass131_0.method_6();
			GClass59.gclass90_1[b].string_1 = new string[gclass131_0.method_2()][];
			for (int j = 0; j < GClass59.gclass90_1[b].string_1.Length; j++)
			{
				GClass59.gclass90_1[b].string_1[j] = new string[gclass131_0.method_2()];
				for (int k = 0; k < GClass59.gclass90_1[b].string_1[j].Length; k++)
				{
					GClass59.gclass90_1[b].string_1[j][k] = gclass131_0.method_14();
				}
			}
		}
		GClass85.gclass204_0 = new GClass204[gclass131_0.method_2()];
		for (sbyte b2 = 0; b2 < GClass85.gclass204_0.Length; b2++)
		{
			GClass85.gclass204_0[b2] = new GClass204();
			GClass85.gclass204_0[b2].sbyte_0 = b2;
			GClass85.gclass204_0[b2].sbyte_3 = gclass131_0.method_2();
			GClass85.gclass204_0[b2].string_0 = gclass131_0.method_14();
			GClass85.gclass204_0[b2].int_0 = gclass131_0.method_8();
			GClass85.gclass204_0[b2].sbyte_1 = gclass131_0.method_2();
			GClass85.gclass204_0[b2].sbyte_2 = gclass131_0.method_2();
			GClass85.gclass204_0[b2].sbyte_4 = gclass131_0.method_2();
		}
	}

	private void method_5(GClass131 gclass131_0, bool bool_6)
	{
		GClass154.sbyte_0 = gclass131_0.method_2();
		if (bool_6)
		{
			GClass120.smethod_0("NR_dart", GClass95.smethod_3(gclass131_0));
			GClass120.smethod_0("NR_arrow", GClass95.smethod_3(gclass131_0));
			GClass120.smethod_0("NR_effect", GClass95.smethod_3(gclass131_0));
			GClass120.smethod_0("NR_image", GClass95.smethod_3(gclass131_0));
			GClass120.smethod_0("NR_part", GClass95.smethod_3(gclass131_0));
			GClass120.smethod_0("NR_skill", GClass95.smethod_3(gclass131_0));
			GClass120.smethod_14("NRdata");
		}
	}

	private GClass2 method_6(sbyte[] sbyte_6)
	{
		try
		{
			return GClass2.smethod_6(sbyte_6, 0, sbyte_6.Length);
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

	public void method_8(GClass110 msg, int index)
	{
		try
		{
			GClass62 gClass = new GClass62();
			sbyte b = (sbyte)(gClass.int_1 = msg.method_1().method_2());
			gClass.int_0 = msg.method_1().method_8();
			gClass.int_2 = msg.method_1().method_8();
			gClass.string_0 = msg.method_1().method_14();
			gClass.sbyte_1 = msg.method_1().method_2();
			gClass.long_0 = msg.method_1().method_8() + 1000000000;
			bool upToTop = false;
			GClass154.bool_59 = false;
			if (b == 0)
			{
				string text = msg.method_1().method_14();
				GClass154.bool_59 = true;
				if (GClass49.gclass49_11.method_17(text) > GClass45.int_55 - 60)
					gClass.string_1 = GClass49.gclass49_11.method_15(text, GClass45.int_55 - 10);
				else
				{
					gClass.string_1 = new string[1];
					gClass.string_1[0] = text;
				}
				gClass.sbyte_0 = msg.method_1().method_2();
			}
			else if (b == 1)
			{
				gClass.int_5 = msg.method_1().method_2();
				gClass.int_6 = msg.method_1().method_2();
				if (upToTop = msg.method_1().method_2() == 1)
					GClass154.bool_59 = true;
				if (gClass.int_2 != GClass58.smethod_1().int_13)
				{
					if (gClass.int_5 < gClass.int_6)
						gClass.string_2 = new string[1] { mResources.donate };
					else
						gClass.string_2 = null;
				}
				if (GClass39.gclass45_0.gclass70_0 != null)
					GClass39.gclass45_0.method_191(gClass.int_5, gClass.int_6);
			}
			else if (b == 2 && GClass58.smethod_1().sbyte_17 == 0)
			{
				GClass154.bool_59 = true;
				gClass.string_2 = new string[2]
				{
					mResources.CANCEL,
					mResources.receive
				};
			}
			if (GClass39.gclass145_0 != GClass154.gclass154_0)
				GClass154.bool_59 = false;
			else if (GClass39.gclass45_0.bool_0 && GClass39.gclass45_0.int_28 == 0 && GClass39.gclass45_0.int_29 == 3)
			{
				GClass154.bool_59 = false;
			}
			GClass62.smethod_0(gClass, index, upToTop);
		}
		catch (Exception)
		{
			GClass5.smethod_0("LOI TAI CMD -= " + msg.sbyte_0);
		}
	}

	public void method_9(sbyte teleport3)
	{
		GClass56.smethod_8("[CONTROLER] start load map " + teleport3);
		GClass154.smethod_8().int_95 = 0;
		GClass154.bool_69 = false;
		GClass158.gclass158_0 = null;
		GClass154.gclass210_0.bool_1 = false;
		GClass154.gclass210_1.bool_1 = false;
		GClass154.int_38 = 0;
		GClass39.gclass45_0.bool_0 = false;
		GClass29.smethod_1().method_51();
		if (!GClass154.bool_2 && !GClass158.bool_0)
			GClass154.smethod_8().method_0();
		GClass154.smethod_10(false, (teleport3 != 1) ? (-1) : GClass58.smethod_1().int_4, (teleport3 == 0) ? (-1) : 0);
		GClass1.smethod_33();
		GClass1.smethod_13(GClass1.int_25);
		GClass56.smethod_8("LOAD GAMESCR 2");
		GClass58.smethod_1().int_6 = 0;
		GClass58.smethod_1().int_11 = 4;
		GClass58.smethod_1().gclass136_0 = null;
		GClass58.smethod_1().gclass85_0 = null;
		GClass58.smethod_1().gclass58_0 = null;
		GClass58.smethod_1().gclass59_0 = null;
		GClass58.smethod_1().gclass134_0 = null;
		GClass58.smethod_1().gclass75_0 = null;
		GClass58.smethod_1().method_79(false);
		GClass58.smethod_1().gclass75_1 = null;
		GClass39.smethod_49();
		if (GClass58.smethod_1().int_5 >= GClass1.int_24 - 100)
		{
			GClass58.smethod_1().bool_24 = true;
			GClass58.smethod_1().int_4 += GClass56.smethod_28(GClass56.smethod_19(0, 80));
			GClass166.smethod_0().method_44();
		}
		GClass154.smethod_8().method_24();
		GClass39.smethod_21(GClass1.int_40);
		GClass58.bool_34 = false;
		GClass56.smethod_8("cy= " + GClass58.smethod_1().int_5 + "---------------------------------------------");
		for (int i = 0; i < GClass58.smethod_1().gclass63_2.method_2(); i++)
		{
			if (((GClass159)GClass58.smethod_1().gclass63_2.method_3(i)).gclass168_1.sbyte_1 == 10)
			{
				GClass58.bool_34 = true;
				break;
			}
		}
		GClass39.smethod_27();
		GClass39.smethod_26();
		GClass154.smethod_8().int_143 = GClass58.smethod_1().int_25;
		GClass154.smethod_8().int_141 = GClass58.smethod_1().int_24;
		GClass58.bool_33 = false;
		GClass154.smethod_8().switchToMe();
		if (GClass58.smethod_1().int_5 <= 10 && teleport3 != 0 && teleport3 != 2)
		{
			GClass202.smethod_0(new GClass202(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, GClass58.smethod_1().int_119, GClass58.smethod_1().int_12, 1, true, (teleport3 != 1) ? teleport3 : GClass58.smethod_1().int_14));
			GClass58.smethod_1().bool_2 = true;
		}
		if (teleport3 == 2)
			GClass58.smethod_1().method_36();
		if (GClass154.smethod_8().bool_62)
		{
			if (GClass1.int_37 == GClass154.smethod_8().int_102 && GClass1.int_39 == GClass154.smethod_8().int_103)
				GClass154.smethod_8().method_55(GClass154.smethod_8().int_126, GClass154.smethod_8().int_127);
			if (GClass76.int_12 > 1)
				GClass154.smethod_8().method_54();
		}
		GClass57.smethod_5();
		GClass57.smethod_0(GClass1.string_1, mResources.zone + " " + GClass1.int_39, 30);
		GClass39.smethod_29();
		GClass39.bool_4 = false;
		GClass23.smethod_4();
		GClass23.smethod_2();
		GClass39.smethod_8("SA75x9", 2);
		GClass56.smethod_8("[CONTROLLER] loadMap DONE!!!!!!!!!");
	}

	public void method_10(GClass110 msg)
	{
		try
		{
			if (GClass76.int_12 == 1)
				GClass96.smethod_4();
			GClass58.smethod_1().int_4 = (GClass58.smethod_1().int_101 = (GClass58.smethod_1().int_104 = msg.method_1().method_6()));
			GClass58.smethod_1().int_5 = (GClass58.smethod_1().int_102 = (GClass58.smethod_1().int_105 = msg.method_1().method_6()));
			GClass58.smethod_1().int_147 = GClass58.smethod_1().int_4;
			GClass58.smethod_1().int_148 = GClass58.smethod_1().int_5;
			GClass56.smethod_8("head= " + GClass58.smethod_1().int_119 + " body= " + GClass58.smethod_1().int_121 + " left= " + GClass58.smethod_1().int_120 + " x= " + GClass58.smethod_1().int_4 + " y= " + GClass58.smethod_1().int_5 + " chung toc= " + GClass58.smethod_1().int_14);
			if (GClass58.smethod_1().int_4 >= 0 && GClass58.smethod_1().int_4 <= 100)
				GClass58.smethod_1().int_12 = 1;
			else if (GClass58.smethod_1().int_4 >= GClass1.int_21 - 100 && GClass58.smethod_1().int_4 <= GClass1.int_21)
			{
				GClass58.smethod_1().int_12 = -1;
			}
			GClass39.smethod_8("SA75x4", 2);
			int num = msg.method_1().method_2();
			GClass56.smethod_8("vGo size= " + num);
			if (!GClass154.gclass210_0.bool_0)
			{
				GClass154.gclass210_0.int_10 = GClass58.smethod_1().int_4 - GClass154.int_22;
				GClass154.gclass210_0.int_5 = GClass58.smethod_1().int_5 - GClass154.int_23;
			}
			for (int i = 0; i < num; i++)
			{
				GClass48 gClass = new GClass48(msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_14());
				if ((GClass1.int_37 != 21 && GClass1.int_37 != 22 && GClass1.int_37 != 23) || gClass.short_0 < 0 || gClass.short_0 <= 24)
					;
			}
			Resources.UnloadUnusedAssets();
			GC.Collect();
			GClass39.smethod_8("SA75x5", 2);
			num = msg.method_1().method_2();
			GClass85.gclass63_2.method_9();
			for (sbyte b = 0; b < num; b++)
			{
				GClass85 gClass2 = new GClass85(b, msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_11(), msg.method_1().method_2(), msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_6(), msg.method_1().method_6(), msg.method_1().method_2(), msg.method_1().method_2());
				gClass2.int_32 = gClass2.int_8;
				gClass2.int_33 = gClass2.int_9;
				gClass2.bool_12 = msg.method_1().method_11();
				if (GClass85.gclass204_0[gClass2.int_26].sbyte_3 != 0)
				{
					if (b % 3 == 0)
						gClass2.int_10 = -1;
					else
						gClass2.int_10 = 1;
					gClass2.int_8 += 10 - b % 20;
				}
				gClass2.bool_13 = false;
				GClass89 gClass3 = null;
				GClass86 gClass4 = null;
				GClass88 gClass5 = null;
				GClass87 gClass6 = null;
				if (gClass2.int_26 == 70)
					gClass3 = new GClass89(b, (short)gClass2.int_8, (short)gClass2.int_9, 70, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass2.int_26 == 71)
					gClass4 = new GClass86(b, (short)gClass2.int_8, (short)gClass2.int_9, 71, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass2.int_26 == 72)
					gClass5 = new GClass88(b, (short)gClass2.int_8, (short)gClass2.int_9, 72, gClass2.int_6, gClass2.int_7, 3);
				if (gClass2.bool_12)
					gClass6 = new GClass87(b, (short)gClass2.int_8, (short)gClass2.int_9, gClass2.int_26, gClass2.int_6, gClass2.int_7, gClass2.int_29);
				if (gClass6 != null)
					GClass154.gclass63_9.method_0(gClass6);
				else if (gClass3 != null)
				{
					GClass154.gclass63_9.method_0(gClass3);
				}
				else if (gClass4 != null)
				{
					GClass154.gclass63_9.method_0(gClass4);
				}
				else if (gClass5 != null)
				{
					GClass154.gclass63_9.method_0(gClass5);
				}
				else
				{
					GClass154.gclass63_9.method_0(gClass2);
				}
			}
			if (GClass58.smethod_1().gclass85_1 != null && GClass154.smethod_16(GClass58.smethod_1().gclass85_1.int_25) == null)
			{
				GClass58.smethod_1().gclass85_1.method_1();
				GClass58.smethod_1().gclass85_1.int_8 = GClass58.smethod_1().int_4;
				GClass58.smethod_1().gclass85_1.int_9 = GClass58.smethod_1().int_5 - 40;
				GClass154.gclass63_9.method_0(GClass58.smethod_1().gclass85_1);
			}
			num = msg.method_1().method_2();
			for (byte b2 = 0; b2 < num; b2++)
			{
			}
			GClass39.smethod_8("SA75x6", 2);
			num = msg.method_1().method_2();
			GClass56.smethod_8("NPC size= " + num);
			for (int j = 0; j < num; j++)
			{
				sbyte status = msg.method_1().method_2();
				short cx = msg.method_1().method_6();
				short num2 = msg.method_1().method_6();
				sbyte b3 = msg.method_1().method_2();
				short num3 = msg.method_1().method_6();
				if (b3 != 6 && ((GClass58.smethod_1().gclass36_0.short_1 >= 7 && (GClass58.smethod_1().gclass36_0.short_1 != 7 || GClass58.smethod_1().gclass36_0.int_0 > 1)) || (b3 != 7 && b3 != 8 && b3 != 9)) && (GClass58.smethod_1().gclass36_0.short_1 >= 6 || b3 != 16))
				{
					if (b3 == 4)
					{
						GClass154.smethod_8().gclass60_0 = new GClass60(j, status, cx, num2, b3, num3);
						GClass166.smethod_0().method_41(2);
						GClass154.gclass63_10.method_0(GClass154.smethod_8().gclass60_0);
					}
					else
					{
						GClass59 o = new GClass59(j, status, cx, num2 + 3, b3, num3);
						GClass154.gclass63_10.method_0(o);
					}
				}
			}
			GClass39.smethod_8("SA75x7", 2);
			num = msg.method_1().method_2();
			string empty = string.Empty;
			GClass56.smethod_8("item size = " + num);
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
				GClass134 gClass7 = new GClass134(num4, itemMapID, itemTemplateID, x, y, r);
				bool flag = false;
				for (int l = 0; l < GClass154.gclass63_6.method_2(); l++)
				{
					if (((GClass134)GClass154.gclass63_6.method_3(l)).int_9 == gClass7.int_9)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
					GClass154.gclass63_6.method_0(gClass7);
				empty = empty + itemTemplateID + ",";
			}
			GClass56.smethod_10("sl item on map " + empty + "\n");
			GClass1.gclass63_2.method_9();
			if (GClass76.int_12 == 1)
				GClass107.smethod_0();
			GClass107.gclass63_0.method_9();
			if (!GClass39.bool_1 || (GClass39.bool_1 && GClass1.smethod_1()) || GClass1.int_37 == 45 || GClass1.int_37 == 46 || GClass1.int_37 == 47 || GClass1.int_37 == 48)
			{
				short num5 = msg.method_1().method_6();
				empty = "item high graphic: ";
				for (int m = 0; m < num5; m++)
				{
					short id = msg.method_1().method_6();
					short num6 = msg.method_1().method_6();
					short num7 = msg.method_1().method_6();
					if (GClass1.smethod_4(id) != null)
					{
						GClass107 gClass8 = GClass1.smethod_4(id);
						GClass107 gClass9 = new GClass107();
						gClass9.int_0 = id;
						gClass9.short_0 = gClass8.short_0;
						gClass9.int_4 = gClass8.int_4;
						gClass9.int_5 = gClass8.int_5;
						gClass9.int_2 = num6 * GClass1.sbyte_0;
						gClass9.int_3 = num7 * GClass1.sbyte_0;
						gClass9.sbyte_0 = gClass8.sbyte_0;
						if (GClass1.smethod_10(gClass9.int_0))
						{
							gClass9.int_1 = ((m % 2 != 0) ? 2 : 0);
							if (GClass1.int_37 == 45)
								gClass9.int_1 = 0;
						}
						GClass2 gClass10 = null;
						if (!GClass107.gclass9_0.method_7(gClass9.short_0 + string.Empty))
						{
							if (GClass76.int_12 == 1)
							{
								gClass10 = GClass39.smethod_43("/mapBackGround/" + gClass9.short_0 + ".png");
								if (gClass10 == null)
								{
									gClass10 = GClass2.smethod_9(new int[1], 1, 1, true);
									GClass166.smethod_0().method_113(gClass9.short_0);
								}
								GClass107.gclass9_0.method_4(gClass9.short_0 + string.Empty, gClass10);
							}
							else
							{
								bool flag2 = false;
								sbyte[] array = GClass120.smethod_1(GClass76.int_12 + "bgItem" + gClass9.short_0);
								if (array != null)
								{
									if (GClass107.sbyte_1 != null)
									{
										GClass56.smethod_8("Small  last= " + array.Length % 127 + "new Version= " + GClass107.sbyte_1[gClass9.short_0]);
										if (array.Length % 127 != GClass107.sbyte_1[gClass9.short_0])
											flag2 = true;
									}
									if (!flag2)
									{
										gClass10 = GClass2.smethod_6(array, 0, array.Length);
										if (gClass10 != null)
											GClass107.gclass9_0.method_4(gClass9.short_0 + string.Empty, gClass10);
										else
											flag2 = true;
									}
								}
								else
									flag2 = true;
								if (flag2)
								{
									gClass10 = GClass39.smethod_43("/mapBackGround/" + gClass9.short_0 + ".png");
									if (gClass10 == null)
									{
										gClass10 = GClass2.smethod_9(new int[1], 1, 1, true);
										GClass166.smethod_0().method_113(gClass9.short_0);
									}
									GClass107.gclass9_0.method_4(gClass9.short_0 + string.Empty, gClass10);
								}
							}
							GClass107.gclass63_1.method_0(gClass9.short_0 + string.Empty);
						}
						if (!GClass107.smethod_1(gClass9.short_0 + string.Empty))
							GClass107.gclass63_0.method_0(gClass9.short_0 + string.Empty);
						gClass9.method_2();
						GClass1.gclass63_2.method_0(gClass9);
					}
					empty = empty + id + ",";
				}
				GClass56.smethod_10("item High Graphics: " + empty);
				for (int n = 0; n < GClass107.gclass63_1.method_2(); n++)
				{
					string text = (string)GClass107.gclass63_1.method_3(n);
					if (!GClass107.smethod_1(text))
					{
						GClass107.gclass9_0.method_5(text);
						if (GClass107.gclass9_0.method_7(text + "blend" + 1))
							GClass107.gclass9_0.method_5(text + "blend" + 1);
						if (GClass107.gclass9_0.method_7(text + "blend" + 3))
							GClass107.gclass9_0.method_5(text + "blend" + 3);
						GClass107.gclass63_1.method_7(n);
						n--;
					}
				}
				GClass16.bool_3 = false;
				GClass16.int_40 = 0;
				GClass81.gclass63_0.method_9();
				GClass16.gclass63_0.method_9();
				GClass33.gclass63_2.method_9();
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
			GClass1.int_41 = msg.method_1().method_2();
			method_9(msg.method_1().method_2());
			GClass58.bool_35 = false;
			GClass39.smethod_8("SA75x8", 2);
			Resources.UnloadUnusedAssets();
			GC.Collect();
			GClass56.smethod_8("[ LOAD INFO MAP ]    [DONE]   in game");
		}
		catch (Exception ex)
		{
			GClass171.smethod_0().method_7();
			GClass56.smethod_10("[error] [TAI LOADMAP INFO]" + ex.StackTrace + ex.Message);
		}
	}

	public void method_11(string key, string value)
	{
		if (key.Equals("eff"))
		{
			if (GClass45.int_36 > 0)
				return;
			string[] array = GClass56.smethod_30(value, ".", 0);
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
			GClass33 gClass = new GClass33(id, x, y, layer, loop, loopCount);
			if (array.Length > 6)
			{
				gClass.int_1 = int.Parse(array[6]);
				if (array.Length > 7)
				{
					gClass.int_2 = int.Parse(array[7]);
					gClass.int_3 = int.Parse(array[8]);
				}
			}
			GClass81.smethod_0(gClass);
		}
		else if (key.Equals("beff") && GClass45.int_36 <= 1)
		{
			GClass16.smethod_7(int.Parse(value));
		}
	}

	public void method_12(GClass110 msg)
	{
		GClass39.smethod_8("SA6", 2);
		try
		{
			sbyte b = msg.method_1().method_2();
			GClass56.smethod_8("---messageNotMap : " + b);
			sbyte b2 = b;
			switch (b2)
			{
			case 4:
			{
				GClass39.smethod_8("SA8", 2);
				GClass39.gclass149_0.method_10();
				GClass154.bool_67 = false;
				GClass154.bool_68 = false;
				GClass149.bool_4 = true;
				GClass149.bool_5 = true;
				GClass149.bool_6 = true;
				GClass149.bool_7 = true;
				GClass149.bool_8 = true;
				GClass154.sbyte_4 = msg.method_1().method_2();
				GClass154.sbyte_5 = msg.method_1().method_2();
				GClass154.sbyte_6 = msg.method_1().method_2();
				GClass154.sbyte_7 = msg.method_1().method_2();
				msg.method_1().method_2();
				if (GClass39.gclass149_0.bool_12)
				{
					GClass120.smethod_4("acc", string.Empty);
					GClass120.smethod_4("pass", string.Empty);
				}
				else
					GClass120.smethod_4("userAo" + GClass152.int_14, string.Empty);
				if (GClass154.sbyte_4 != GClass154.sbyte_0)
				{
					GClass154.bool_2 = false;
					GClass166.smethod_0().method_79();
				}
				else
					try
					{
						GClass149.bool_5 = false;
					}
					catch (Exception)
					{
						GClass154.sbyte_0 = -1;
						GClass166.smethod_0().method_79();
					}
				if (GClass154.sbyte_5 != GClass154.sbyte_1)
				{
					GClass154.bool_2 = false;
					GClass166.smethod_0().method_80();
				}
				else
					try
					{
						if (!GClass154.bool_2)
							method_4(new GClass11(GClass120.smethod_1("NRmap")).gclass131_0);
						GClass149.bool_6 = false;
					}
					catch (Exception)
					{
						GClass154.sbyte_1 = -1;
						GClass166.smethod_0().method_80();
					}
				if (GClass154.sbyte_6 != GClass154.sbyte_2)
				{
					GClass154.bool_2 = false;
					GClass166.smethod_0().method_81();
				}
				else
					try
					{
						if (!GClass154.bool_2)
							method_3(new GClass11(GClass120.smethod_1("NRskill")).gclass131_0);
						GClass149.bool_7 = false;
					}
					catch (Exception)
					{
						GClass154.sbyte_2 = -1;
						GClass166.smethod_0().method_81();
					}
				if (GClass154.sbyte_7 != GClass154.sbyte_3)
				{
					GClass154.bool_2 = false;
					GClass166.smethod_0().method_82();
				}
				else
					try
					{
						method_19(new GClass11(GClass120.smethod_1("NRitem0")).gclass131_0, 0, false);
						method_19(new GClass11(GClass120.smethod_1("NRitem1")).gclass131_0, 1, false);
						method_19(new GClass11(GClass120.smethod_1("NRitem2")).gclass131_0, 2, false);
						method_19(new GClass11(GClass120.smethod_1("NRitem100")).gclass131_0, 100, false);
						GClass149.bool_8 = false;
					}
					catch (Exception)
					{
						GClass154.sbyte_3 = -1;
						GClass166.smethod_0().method_82();
					}
				if (GClass154.sbyte_4 == GClass154.sbyte_0 && GClass154.sbyte_5 == GClass154.sbyte_1 && GClass154.sbyte_6 == GClass154.sbyte_2 && GClass154.sbyte_7 == GClass154.sbyte_3)
				{
					if (!GClass154.bool_2)
					{
						GClass154.smethod_8().method_22();
						GClass154.smethod_8().method_20();
						GClass154.smethod_8().method_21();
						GClass154.smethod_8().method_23();
					}
					GClass166.smethod_0().method_83();
				}
				sbyte b3 = msg.method_1().method_2();
				GClass56.smethod_8("CAPTION LENT= " + b3);
				GClass154.long_2 = new long[b3];
				for (int j = 0; j < GClass154.long_2.Length; j++)
				{
					GClass154.long_2[j] = msg.method_1().method_9();
				}
				return;
			}
			case 6:
			{
				GClass56.smethod_8("GET UPDATE_MAP " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_4(msg.method_1());
				msg.method_1().method_4();
				sbyte[] data2 = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data2);
				GClass120.smethod_0("NRmap", data2);
				GClass120.smethod_0("NRmapVersion", new sbyte[1] { GClass154.sbyte_1 });
				GClass149.bool_6 = false;
				if (GClass154.sbyte_4 == GClass154.sbyte_0 && GClass154.sbyte_5 == GClass154.sbyte_1 && GClass154.sbyte_6 == GClass154.sbyte_2 && GClass154.sbyte_7 == GClass154.sbyte_3)
				{
					GClass154.smethod_8().method_22();
					GClass154.smethod_8().method_20();
					GClass154.smethod_8().method_21();
					GClass154.smethod_8().method_23();
					GClass166.smethod_0().method_83();
				}
				return;
			}
			case 7:
			{
				GClass56.smethod_8("GET UPDATE_SKILL " + msg.method_1().method_18() + " bytes");
				msg.method_1().method_3(100000);
				method_3(msg.method_1());
				msg.method_1().method_4();
				sbyte[] data = new sbyte[msg.method_1().method_18()];
				msg.method_1().method_17(ref data);
				GClass120.smethod_0("NRskill", data);
				GClass120.smethod_0("NRskillVersion", new sbyte[1] { GClass154.sbyte_2 });
				GClass149.bool_7 = false;
				if (GClass154.sbyte_4 == GClass154.sbyte_0 && GClass154.sbyte_5 == GClass154.sbyte_1 && GClass154.sbyte_6 == GClass154.sbyte_2 && GClass154.sbyte_7 == GClass154.sbyte_3)
				{
					GClass154.smethod_8().method_22();
					GClass154.smethod_8().method_20();
					GClass154.smethod_8().method_21();
					GClass154.smethod_8().method_23();
					GClass166.smethod_0().method_83();
				}
				return;
			}
			case 8:
				GClass56.smethod_8("GET UPDATE_ITEM " + msg.method_1().method_18() + " bytes");
				method_18(msg.method_1());
				return;
			case 9:
				GClass39.smethod_8("SA11", 2);
				return;
			case 10:
				try
				{
					GClass58.bool_35 = true;
					GClass56.smethod_8("REQUEST MAP TEMPLATE");
					GClass39.bool_4 = true;
					GClass1.int_27 = null;
					GClass1.int_28 = null;
					GClass138.smethod_26();
					GClass39.smethod_8("SA99", 2);
					GClass1.int_21 = msg.method_1().method_2();
					GClass1.int_22 = msg.method_1().method_2();
					GClass1.int_27 = new int[GClass1.int_21 * GClass1.int_22];
					GClass56.smethod_10("   M apsize= " + GClass1.int_21 * GClass1.int_22);
					for (int i = 0; i < GClass1.int_27.Length; i++)
					{
						int num2 = msg.method_1().method_2();
						if (num2 < 0)
							num2 += 256;
						GClass1.int_27[i] = (ushort)num2;
					}
					GClass1.int_28 = new int[GClass1.int_27.Length];
					msg = gclass110_0;
					method_10(msg);
					try
					{
						GClass1.bool_0 = ((msg.method_1().method_2() != 0) ? true : false);
					}
					catch (Exception ex)
					{
						GClass56.smethod_10(" 1 LOI TAI CASE REQUEST_MAPTEMPLATE " + ex.ToString());
					}
				}
				catch (Exception ex2)
				{
					GClass56.smethod_10("2 LOI TAI CASE REQUEST_MAPTEMPLATE " + ex2.ToString());
				}
				msg.method_4();
				gclass110_0.method_4();
				msg = (gclass110_0 = null);
				GClass154.smethod_8().switchToMe();
				return;
			case 12:
				GClass39.smethod_8("SA10", 2);
				return;
			case 16:
				GClass147.smethod_2().switchToMe();
				return;
			case 17:
				GClass39.smethod_8("SYB123", 2);
				GClass58.smethod_1().method_118();
				return;
			case 18:
			{
				GClass39.bool_4 = false;
				GClass39.smethod_29();
				int num = msg.method_1().method_8();
				GClass39.gclass101_0.method_0(mResources.changeNameChar, new GClass14(mResources.OK, GClass39.gclass39_0, 88829, num), GClass67.int_11);
				return;
			}
			case 20:
				GClass58.smethod_1().sbyte_18 = msg.method_1().method_2();
				GClass154.gclass210_0.method_7(mResources.PK_NOW + " " + GClass58.smethod_1().sbyte_18, 0);
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
					GClass154.sbyte_10 = msg.method_1().method_2();
					GClass56.smethod_8("load Me Active: " + GClass154.sbyte_10);
				}
			}
			else
			{
				GClass39.smethod_29();
				GClass154.smethod_8().method_34();
				GClass154.gclass210_0.method_7(msg.method_1().method_14(), 0);
			}
		}
		catch (Exception)
		{
			GClass5.smethod_2("LOI TAI messageNotMap + " + msg.sbyte_0);
		}
		finally
		{
			msg?.method_4();
		}
	}

	public void method_13(GClass110 msg)
	{
		try
		{
			sbyte b = msg.method_1().method_2();
			GClass56.smethod_8("---messageNotLogin : " + b);
			if (b != 2)
				return;
			string string_ = msg.method_1().method_14();
			if (GClass120.smethod_8("AdminLink") == 1)
				return;
			if (GClass138.int_0 == 1)
				GClass152.string_9 = string_;
			else
				GClass152.string_9 = string_;
			GClass138.smethod_0();
			GClass152.smethod_4(GClass152.string_9);
			try
			{
				GClass45.bool_6 = msg.method_1().method_2() == 1;
				GClass120.smethod_9("AdminLink", msg.method_1().method_2());
			}
			catch (Exception)
			{
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

	public void method_14(GClass110 msg)
	{
		try
		{
			GClass39.smethod_8("SA12", 2);
			sbyte b = msg.method_1().method_2();
			GClass56.smethod_8("---messageSubCommand : " + b);
			sbyte b2 = b;
			switch (b2)
			{
			case 0:
			{
				GClass39.smethod_8("SA21", 2);
				GClass146.gclass63_0 = new GClass63();
				GClass202.gclass63_0.method_9();
				GClass154.gclass63_5.method_9();
				GClass154.gclass63_6.method_9();
				GClass58.gclass63_5.method_9();
				GClass154.smethod_26();
				GClass154.gclass58_0 = GClass58.smethod_1();
				GClass58.smethod_1().int_13 = msg.method_1().method_8();
				GClass58.smethod_1().int_15 = msg.method_1().method_2();
				GClass58.smethod_1().int_14 = msg.method_1().method_2();
				GClass58.smethod_1().int_119 = msg.method_1().method_6();
				GClass58.smethod_1().string_3 = msg.method_1().method_14();
				GClass58.smethod_1().sbyte_18 = msg.method_1().method_2();
				GClass58.smethod_1().sbyte_19 = msg.method_1().method_2();
				GClass58.smethod_1().long_2 = msg.method_1().method_9();
				GClass58.smethod_1().method_3();
				GClass58.smethod_1().int_33 = msg.method_1().method_6();
				GClass58.smethod_1().int_34 = msg.method_1().method_6();
				GClass58.smethod_1().gclass109_0 = GClass154.gclass109_0[msg.method_1().method_2()];
				GClass58.smethod_1().gclass63_0.method_9();
				GClass58.smethod_1().gclass63_1.method_9();
				GClass154.smethod_8().int_143 = GClass58.smethod_1().int_25;
				GClass154.smethod_8().int_141 = GClass58.smethod_1().int_24;
				sbyte b4 = msg.method_1().method_2();
				for (sbyte b5 = 0; b5 < b4; b5++)
				{
					method_15(GClass61.smethod_1(msg.method_1().method_6()));
				}
				GClass154.smethod_8().method_65();
				GClass154.smethod_8().method_4();
				GClass58.smethod_1().long_6 = msg.method_1().method_9();
				GClass58.smethod_1().int_69 = msg.method_1().method_8();
				GClass58.smethod_1().int_68 = msg.method_1().method_8();
				GClass58.smethod_1().string_0 = GClass138.smethod_6(GClass58.smethod_1().long_6);
				GClass58.smethod_1().string_1 = GClass138.smethod_6(GClass58.smethod_1().int_68);
				GClass58.smethod_1().string_2 = GClass138.smethod_6(GClass58.smethod_1().int_69);
				GClass58.smethod_1().gclass121_2 = new GClass121[msg.method_1().method_2()];
				try
				{
					GClass58.smethod_1().method_60();
					for (int j = 0; j < GClass58.smethod_1().gclass121_2.Length; j++)
					{
						short num3 = msg.method_1().method_6();
						if (num3 == -1)
							continue;
						GClass118 gClass7 = GClass83.smethod_1(num3);
						int num4 = gClass7.sbyte_0;
						GClass58.smethod_1().gclass121_2[j] = new GClass121();
						GClass58.smethod_1().gclass121_2[j].gclass118_0 = gClass7;
						GClass58.smethod_1().gclass121_2[j].int_30 = msg.method_1().method_8();
						GClass58.smethod_1().gclass121_2[j].string_0 = msg.method_1().method_14();
						GClass58.smethod_1().gclass121_2[j].string_1 = msg.method_1().method_14();
						int num5 = msg.method_1().method_5();
						if (num5 != 0)
						{
							GClass58.smethod_1().gclass121_2[j].gclass20_0 = new GClass20[num5];
							for (int k = 0; k < GClass58.smethod_1().gclass121_2[j].gclass20_0.Length; k++)
							{
								int optionTemplateId = msg.method_1().method_5();
								int param = msg.method_1().method_7();
								GClass58.smethod_1().gclass121_2[j].gclass20_0[k] = new GClass20(optionTemplateId, param);
							}
						}
						int num6 = num4;
						if (num6 != 0)
						{
							if (num6 == 1)
							{
								GClass58.smethod_1().int_120 = GClass58.smethod_1().gclass121_2[j].gclass118_0.short_2;
								GClass56.smethod_8("toi day =======================================" + GClass58.smethod_1().int_120);
							}
						}
						else
						{
							GClass56.smethod_8("toi day =======================================" + GClass58.smethod_1().int_121);
							GClass58.smethod_1().int_121 = GClass58.smethod_1().gclass121_2[j].gclass118_0.short_2;
						}
					}
				}
				catch (Exception)
				{
				}
				GClass58.smethod_1().gclass121_0 = new GClass121[msg.method_1().method_2()];
				GClass154.int_37 = 0;
				for (int l = 0; l < GClass58.smethod_1().gclass121_0.Length; l++)
				{
					short num7 = msg.method_1().method_6();
					if (num7 == -1)
						continue;
					GClass58.smethod_1().gclass121_0[l] = new GClass121();
					GClass58.smethod_1().gclass121_0[l].gclass118_0 = GClass83.smethod_1(num7);
					GClass58.smethod_1().gclass121_0[l].int_30 = msg.method_1().method_8();
					GClass58.smethod_1().gclass121_0[l].string_0 = msg.method_1().method_14();
					GClass58.smethod_1().gclass121_0[l].string_1 = msg.method_1().method_14();
					GClass58.smethod_1().gclass121_0[l].int_29 = l;
					sbyte b6 = msg.method_1().method_2();
					if (b6 != 0)
					{
						GClass58.smethod_1().gclass121_0[l].gclass20_0 = new GClass20[b6];
						for (int m = 0; m < GClass58.smethod_1().gclass121_0[l].gclass20_0.Length; m++)
						{
							int optionTemplateId2 = msg.method_1().method_5();
							int param2 = msg.method_1().method_7();
							GClass58.smethod_1().gclass121_0[l].gclass20_0[m] = new GClass20(optionTemplateId2, param2);
							GClass58.smethod_1().gclass121_0[l].method_4();
						}
					}
					if (GClass58.smethod_1().gclass121_0[l].gclass118_0.sbyte_0 == 6)
						GClass154.int_37 += GClass58.smethod_1().gclass121_0[l].int_30;
				}
				GClass58.smethod_1().gclass121_1 = new GClass121[msg.method_1().method_2()];
				GClass39.gclass45_0.int_39 = 0;
				for (int n = 0; n < GClass58.smethod_1().gclass121_1.Length; n++)
				{
					short num8 = msg.method_1().method_6();
					if (num8 != -1)
					{
						GClass58.smethod_1().gclass121_1[n] = new GClass121();
						GClass58.smethod_1().gclass121_1[n].gclass118_0 = GClass83.smethod_1(num8);
						GClass58.smethod_1().gclass121_1[n].int_30 = msg.method_1().method_8();
						GClass58.smethod_1().gclass121_1[n].string_0 = msg.method_1().method_14();
						GClass58.smethod_1().gclass121_1[n].string_1 = msg.method_1().method_14();
						GClass58.smethod_1().gclass121_1[n].gclass20_0 = new GClass20[msg.method_1().method_2()];
						for (int num9 = 0; num9 < GClass58.smethod_1().gclass121_1[n].gclass20_0.Length; num9++)
						{
							int optionTemplateId3 = msg.method_1().method_5();
							int param3 = msg.method_1().method_7();
							GClass58.smethod_1().gclass121_1[n].gclass20_0[num9] = new GClass20(optionTemplateId3, param3);
							GClass58.smethod_1().gclass121_1[n].method_4();
						}
						GClass39.gclass45_0.int_39++;
					}
				}
				GClass58.smethod_1().int_11 = 4;
				if (GClass120.smethod_8(GClass58.smethod_1().string_3 + "vci") < 1)
					GClass154.bool_7 = false;
				else
					GClass154.bool_7 = true;
				short num10 = msg.method_1().method_6();
				GClass58.short_12 = new short[num10];
				GClass58.short_13 = new short[num10];
				for (int num11 = 0; num11 < num10; num11++)
				{
					GClass58.short_12[num11] = msg.method_1().method_6();
					GClass58.short_13[num11] = msg.method_1().method_6();
				}
				for (int num12 = 0; num12 < GClass154.gclass210_0.int_0.Length; num12++)
				{
					GClass154.gclass210_0.int_0[num12] = new int[3];
				}
				GClass154.gclass210_0.int_0[GClass58.smethod_1().int_14][0] = msg.method_1().method_6();
				GClass154.gclass210_0.int_0[GClass58.smethod_1().int_14][1] = msg.method_1().method_6();
				GClass154.gclass210_0.int_0[GClass58.smethod_1().int_14][2] = msg.method_1().method_6();
				GClass58.smethod_1().bool_4 = msg.method_1().method_2() == 1;
				GClass56.smethod_8("NHAP THE= " + GClass58.smethod_1().bool_4);
				GClass154.long_3 = GClass138.smethod_18() - msg.method_1().method_8() * 1000L;
				GClass154.sbyte_13 = msg.method_1().method_2();
				GClass166.smethod_0().method_29((sbyte)GClass58.smethod_1().int_14);
				GClass166.smethod_0().method_1();
				try
				{
					GClass58.smethod_1().short_28 = msg.method_1().method_6();
					GClass58.smethod_1().short_29 = msg.method_1().method_0();
					GClass58.smethod_1().short_30 = msg.method_1().method_6();
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			case 1:
				GClass39.smethod_8("SA13", 2);
				GClass58.smethod_1().gclass109_0 = GClass154.gclass109_0[msg.method_1().method_2()];
				GClass58.smethod_1().long_4 = msg.method_1().method_9();
				GClass58.smethod_1().gclass63_0.method_9();
				GClass58.smethod_1().gclass63_1.method_9();
				GClass58.smethod_1().gclass74_0 = null;
				return;
			case 2:
			{
				GClass39.smethod_8("SA14", 2);
				if (GClass58.smethod_1().int_11 != 14 && GClass58.smethod_1().int_11 != 5)
				{
					GClass58.smethod_1().int_25 = GClass58.smethod_1().int_35;
					GClass58.smethod_1().int_24 = GClass58.smethod_1().int_36;
					GClass5.smethod_3(" ME_LOAD_SKILL");
				}
				GClass58.smethod_1().gclass63_0.method_9();
				GClass58.smethod_1().gclass63_1.method_9();
				sbyte b7 = msg.method_1().method_2();
				for (sbyte b8 = 0; b8 < b7; b8++)
				{
					method_15(GClass61.smethod_1(msg.method_1().method_6()));
				}
				GClass154.smethod_8().method_65();
				if (GClass154.bool_18)
				{
					GClass154.int_45 = -1;
					GClass154.smethod_8().gclass14_0 = (GClass154.smethod_8().gclass14_1 = null);
				}
				return;
			}
			case 4:
				GClass39.smethod_8("SA23", 2);
				GClass58.smethod_1().long_6 = msg.method_1().method_9();
				GClass58.smethod_1().int_68 = msg.method_1().method_8();
				GClass58.smethod_1().int_25 = msg.method_3();
				GClass58.smethod_1().int_24 = msg.method_3();
				GClass58.smethod_1().int_69 = msg.method_1().method_8();
				GClass58.smethod_1().string_0 = GClass138.smethod_6(GClass58.smethod_1().long_6);
				GClass58.smethod_1().string_1 = GClass138.smethod_6(GClass58.smethod_1().int_68);
				GClass58.smethod_1().string_2 = GClass138.smethod_6(GClass58.smethod_1().int_69);
				return;
			case 5:
			{
				GClass39.smethod_8("SA24", 2);
				int int_ = GClass58.smethod_1().int_25;
				GClass58.smethod_1().int_25 = msg.method_3();
				if (GClass58.smethod_1().int_25 > int_ && GClass58.smethod_1().sbyte_19 != 4)
				{
					GClass154.smethod_19("+" + (GClass58.smethod_1().int_25 - int_) + " " + mResources.HP, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58 - 20, 0, -1, GClass49.int_12);
					GClass29.smethod_1().method_3();
					if (GClass58.smethod_1().gclass128_0 != null && GClass58.smethod_1().gclass128_0.short_0 == 5003)
						GClass73.smethod_0(GClass58.smethod_1().gclass128_0.int_9 + ((GClass58.smethod_1().gclass128_0.int_0 != 1) ? (-10) : 10), GClass58.smethod_1().gclass128_0.int_4 + 10, true, -1, -1, GClass58.smethod_1(), 29);
				}
				if (GClass58.smethod_1().int_25 < int_)
					GClass154.smethod_19("-" + (int_ - GClass58.smethod_1().int_25) + " " + mResources.HP, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58 - 20, 0, -1, GClass49.int_12);
				GClass154.smethod_8().int_143 = GClass58.smethod_1().int_25;
				if (!GClass154.bool_18)
					;
				return;
			}
			case 6:
			{
				GClass39.smethod_8("SA25", 2);
				if (GClass58.smethod_1().int_11 == 14 || GClass58.smethod_1().int_11 == 5)
					return;
				int int_2 = GClass58.smethod_1().int_24;
				GClass58.smethod_1().int_24 = msg.method_3();
				if (GClass58.smethod_1().int_24 > int_2)
				{
					GClass154.smethod_19("+" + (GClass58.smethod_1().int_24 - int_2) + " " + mResources.KI, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58 - 23, 0, -2, GClass49.int_13);
					GClass29.smethod_1().method_3();
					if (GClass58.smethod_1().gclass128_0 != null && GClass58.smethod_1().gclass128_0.short_0 == 5001)
						GClass73.smethod_0(GClass58.smethod_1().gclass128_0.int_9 + ((GClass58.smethod_1().gclass128_0.int_0 != 1) ? (-10) : 10), GClass58.smethod_1().gclass128_0.int_4 + 10, true, -1, -1, GClass58.smethod_1(), 29);
				}
				if (GClass58.smethod_1().int_24 < int_2)
					GClass154.smethod_19("-" + (int_2 - GClass58.smethod_1().int_24) + " " + mResources.KI, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - GClass58.smethod_1().int_58 - 23, 0, -2, GClass49.int_13);
				GClass56.smethod_8("curr MP= " + GClass58.smethod_1().int_24);
				GClass154.smethod_8().int_141 = GClass58.smethod_1().int_24;
				if (!GClass154.bool_18)
					;
				return;
			}
			case 7:
			{
				GClass58 gClass13 = GClass154.smethod_14(msg.method_1().method_8());
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
					if (gClass13.int_122 >= 201)
					{
						GClass33 gClass14 = new GClass33(gClass13.int_122, gClass13, 2, -1, 10, 1);
						gClass14.int_1 = 5;
						gClass13.method_138(gClass14);
					}
					else
						gClass13.method_139(0, 201);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			case 8:
			{
				GClass39.smethod_8("SA26", 2);
				GClass58 gClass8 = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass8 != null)
					gClass8.int_18 = msg.method_1().method_2();
				return;
			}
			case 9:
			{
				GClass39.smethod_8("SA27", 2);
				GClass58 gClass10 = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass10 != null)
				{
					gClass10.int_25 = msg.method_3();
					gClass10.int_35 = msg.method_3();
				}
				return;
			}
			case 10:
			{
				GClass39.smethod_8("SA28", 2);
				GClass58 gClass5 = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass5 != null)
				{
					gClass5.int_25 = msg.method_3();
					gClass5.int_35 = msg.method_3();
					gClass5.int_33 = msg.method_1().method_6();
					gClass5.int_34 = msg.method_1().method_6();
					gClass5.int_123 = msg.method_1().method_6();
					if (gClass5.int_123 == -1)
						gClass5.method_61();
				}
				return;
			}
			case 11:
			{
				GClass39.smethod_8("SA29", 2);
				GClass58 gClass9 = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass9 != null)
				{
					gClass9.int_25 = msg.method_3();
					gClass9.int_35 = msg.method_3();
					gClass9.int_33 = msg.method_1().method_6();
					gClass9.int_34 = msg.method_1().method_6();
					gClass9.int_121 = msg.method_1().method_6();
					if (gClass9.int_121 == -1)
						gClass9.method_62();
				}
				return;
			}
			case 12:
			{
				GClass39.smethod_8("SA30", 2);
				GClass58 gClass12 = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass12 != null)
				{
					gClass12.int_25 = msg.method_3();
					gClass12.int_35 = msg.method_3();
					gClass12.int_33 = msg.method_1().method_6();
					gClass12.int_34 = msg.method_1().method_6();
					gClass12.int_120 = msg.method_1().method_6();
					if (gClass12.int_120 == -1)
						gClass12.method_63();
				}
				return;
			}
			case 13:
			{
				GClass39.smethod_8("SA31", 2);
				int num2 = msg.method_1().method_8();
				GClass58 gClass6 = ((num2 != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num2) : GClass58.smethod_1());
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
				GClass39.smethod_8("SA32", 2);
				GClass58 gClass4 = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass4 != null)
				{
					gClass4.int_25 = msg.method_3();
					sbyte b3 = msg.method_1().method_2();
					GClass56.smethod_8("player load hp type= " + b3);
					if (b3 == 1)
					{
						GClass71.smethod_3(11, gClass4, 5);
						GClass71.smethod_3(104, gClass4, 4);
					}
					if (b3 == 2)
						gClass4.method_111();
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
				GClass39.smethod_8("SA33", 2);
				GClass58 gClass3 = GClass154.smethod_14(msg.method_1().method_8());
				if (gClass3 != null)
				{
					gClass3.int_25 = msg.method_3();
					gClass3.int_35 = msg.method_3();
					gClass3.int_4 = msg.method_1().method_6();
					gClass3.int_5 = msg.method_1().method_6();
					gClass3.int_11 = 1;
					gClass3.int_10 = 3;
					GClass71.smethod_3(109, gClass3, 2);
				}
				return;
			}
			case 19:
				GClass39.smethod_8("SA17", 2);
				GClass58.smethod_1().method_13();
				return;
			case 21:
			{
				GClass39.smethod_8("SA19", 2);
				int num14 = msg.method_1().method_8();
				GClass58.smethod_1().int_65 -= num14;
				GClass58.smethod_1().long_6 += num14;
				GClass58.smethod_1().string_0 = GClass138.smethod_6(GClass58.smethod_1().long_6);
				return;
			}
			case 23:
			{
				short num13 = msg.method_1().method_6();
				GClass74 gClass11 = GClass61.smethod_1(num13);
				method_15(gClass11);
				if (num13 != 0 && num13 != 14 && num13 != 28)
					GClass154.gclass210_0.method_7(mResources.LEARN_SKILL + " " + gClass11.gclass53_0.string_0, 0);
				return;
			}
			case 35:
			{
				GClass39.smethod_8("SY3", 2);
				int num = msg.method_1().method_8();
				GClass56.smethod_8("CID = " + num);
				if (GClass1.int_37 == 130)
					GClass154.smethod_8().method_91();
				if (num == GClass58.smethod_1().int_13)
				{
					GClass58.smethod_1().sbyte_19 = msg.method_1().method_2();
					if (GClass154.smethod_8().method_93() && GClass58.smethod_1().sbyte_19 != 0)
						GClass154.smethod_8().method_91();
					GClass56.smethod_8("type pk= " + GClass58.smethod_1().sbyte_19);
					GClass58.smethod_1().gclass59_0 = null;
					if (!GClass154.smethod_8().method_31(GClass58.smethod_1().gclass85_0))
						GClass58.smethod_1().gclass85_0 = null;
					GClass58.smethod_1().gclass134_0 = null;
				}
				else
				{
					GClass58 gClass = GClass154.smethod_14(num);
					if (gClass != null)
					{
						GClass56.smethod_8("type pk= " + gClass.sbyte_19);
						gClass.sbyte_19 = msg.method_1().method_2();
						if (gClass.method_103())
							GClass58.smethod_1().gclass58_0 = gClass;
					}
				}
				for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
				{
					GClass58 gClass2 = GClass154.smethod_14(i);
					if (gClass2 != null && gClass2.sbyte_19 != 0 && gClass2.sbyte_19 == GClass58.smethod_1().sbyte_19)
					{
						if (!GClass58.smethod_1().gclass85_0.bool_13)
							GClass58.smethod_1().gclass85_0 = null;
						GClass58.smethod_1().gclass59_0 = null;
						GClass58.smethod_1().gclass134_0 = null;
						break;
					}
				}
				GClass56.smethod_8("update type pk= ");
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
					GClass154.smethod_8().method_6(data);
				else if (text.Equals("OSkill"))
				{
					GClass154.smethod_8().method_5(data);
				}
				else if (text.Equals("CSkill"))
				{
					GClass154.smethod_8().method_7(data);
				}
				break;
			}
			case 62:
				GClass56.smethod_8("ME UPDATE SKILL");
				method_25(msg);
				break;
			case 63:
			{
				sbyte b9 = msg.method_1().method_2();
				if (b9 > 0)
				{
					GClass39.gclass45_0.gclass63_11.method_9();
					GClass57.smethod_1();
					GClass63 gclass63_ = GClass39.gclass45_0.gclass63_4;
					for (int num15 = 0; num15 < b9; num15++)
					{
						string caption = msg.method_1().method_14();
						string string_ = msg.method_1().method_14();
						short int_3 = msg.method_1().method_6();
						GClass39.gclass45_0.gclass63_11.method_0(int_3 + string.Empty);
						GClass58.smethod_1().gclass58_0.int_16 = int_3;
						GClass14 gClass15 = new GClass14(caption, 11115, GClass58.smethod_1().gclass58_0);
						gClass15.string_2 = string_;
						gclass63_.method_0(gClass15);
					}
					GClass57.smethod_5();
					GClass39.gclass45_0.method_21();
				}
				break;
			}
			}
		}
		catch (Exception ex5)
		{
			GClass5.smethod_0("Loi tai Sub : " + ex5.ToString());
		}
		finally
		{
			msg?.method_4();
		}
	}

	private void method_15(GClass74 gclass74_0)
	{
		if (GClass58.smethod_1().gclass74_0 == null)
			GClass58.smethod_1().gclass74_0 = gclass74_0;
		else if (gclass74_0.gclass53_0.Equals(GClass58.smethod_1().gclass74_0.gclass53_0))
		{
			GClass58.smethod_1().gclass74_0 = gclass74_0;
		}
		GClass58.smethod_1().gclass63_0.method_0(gclass74_0);
		if ((gclass74_0.gclass53_0.int_3 == 1 || gclass74_0.gclass53_0.int_3 == 4 || gclass74_0.gclass53_0.int_3 == 2 || gclass74_0.gclass53_0.int_3 == 3) && (gclass74_0.gclass53_0.int_1 == 0 || (gclass74_0.gclass53_0.int_1 > 0 && gclass74_0.int_0 > 0)))
		{
			if (gclass74_0.gclass53_0.sbyte_0 == GClass58.smethod_1().int_71)
				GClass166.smethod_0().method_56(GClass58.smethod_1().int_71);
			GClass58.smethod_1().gclass63_1.method_0(gclass74_0);
		}
	}

	public bool method_16(GClass58 c, GClass110 msg)
	{
		try
		{
			c.int_23 = msg.method_1().method_2();
			c.bool_20 = msg.method_1().method_11();
			c.sbyte_19 = msg.method_1().method_2();
			GClass56.smethod_8("ADD TYPE PK= " + c.sbyte_19 + " to player " + c.int_13 + " @@ " + c.string_3);
			c.gclass109_0 = GClass154.gclass109_0[msg.method_1().method_2()];
			c.int_14 = msg.method_1().method_2();
			c.int_119 = msg.method_1().method_6();
			c.string_3 = msg.method_1().method_14();
			c.int_25 = msg.method_3();
			c.int_163 = c.int_25;
			if (c.int_25 == 0)
				c.int_11 = 14;
			c.int_35 = msg.method_3();
			if (c.int_5 >= GClass1.int_24 - 100)
				c.bool_24 = true;
			c.int_121 = msg.method_1().method_6();
			c.int_120 = msg.method_1().method_6();
			c.int_122 = msg.method_1().method_5();
			GClass56.smethod_8(" body= " + c.int_121 + " leg= " + c.int_120 + " bag=" + c.int_122 + "BAG ==" + c.int_122 + "*********************************");
			c.bool_21 = true;
			msg.method_1().method_2();
			if (c.int_123 == -1)
				c.method_61();
			if (c.int_121 == -1)
				c.method_62();
			if (c.int_120 == -1)
				c.method_63();
			c.int_4 = msg.method_1().method_6();
			c.int_5 = msg.method_1().method_6();
			c.int_147 = c.int_4;
			c.int_148 = c.int_5;
			c.int_33 = msg.method_1().method_6();
			c.int_34 = msg.method_1().method_6();
			int num = msg.method_1().method_2();
			for (int i = 0; i < num; i++)
			{
				GClass159 gClass = new GClass159(msg.method_1().method_2(), msg.method_1().method_8(), msg.method_1().method_8(), msg.method_1().method_6());
				c.gclass63_2.method_0(gClass);
				if (gClass.gclass168_1.sbyte_1 == 12 || gClass.gclass168_1.sbyte_1 == 11)
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

	private void method_17(GClass110 gclass110_1)
	{
		try
		{
			string text = gclass110_1.method_1().method_14();
			sbyte nFrame = gclass110_1.method_1().method_2();
			sbyte[] array = null;
			array = GClass95.smethod_2(gclass110_1);
			GClass35.smethod_0(text, method_6(array), nFrame);
			if (array != null)
				GClass35.smethod_3(text, nFrame, array);
		}
		catch (Exception)
		{
		}
	}

	private void method_18(GClass131 gclass131_0)
	{
		try
		{
			method_19(gclass131_0, -1, true);
		}
		catch (Exception)
		{
		}
	}

	private void method_19(GClass131 gclass131_0, sbyte sbyte_6, bool bool_6)
	{
		try
		{
			gclass131_0.method_3(100000);
			GClass154.sbyte_3 = gclass131_0.method_2();
			sbyte_6 = gclass131_0.method_2();
			if (sbyte_6 == 0)
			{
				GClass154.smethod_8().gclass114_0 = new GClass114[gclass131_0.method_5()];
				for (int i = 0; i < GClass154.smethod_8().gclass114_0.Length; i++)
				{
					GClass154.smethod_8().gclass114_0[i] = new GClass114();
					GClass154.smethod_8().gclass114_0[i].int_0 = i;
					GClass154.smethod_8().gclass114_0[i].string_0 = gclass131_0.method_14();
					GClass154.smethod_8().gclass114_0[i].int_1 = gclass131_0.method_2();
				}
				if (bool_6)
				{
					gclass131_0.method_4();
					sbyte[] data = new sbyte[gclass131_0.method_18()];
					gclass131_0.method_17(ref data);
					GClass120.smethod_0("NRitem0", data);
				}
			}
			else if (sbyte_6 == 1)
			{
				GClass83.gclass9_0.method_1();
				int num = gclass131_0.method_6();
				for (int j = 0; j < num; j++)
				{
					GClass83.smethod_0(new GClass118((short)j, gclass131_0.method_2(), gclass131_0.method_2(), gclass131_0.method_14(), gclass131_0.method_14(), gclass131_0.method_2(), gclass131_0.method_8(), gclass131_0.method_6(), gclass131_0.method_6(), gclass131_0.method_11()));
				}
				if (bool_6)
				{
					gclass131_0.method_4();
					sbyte[] data2 = new sbyte[gclass131_0.method_18()];
					gclass131_0.method_17(ref data2);
					GClass120.smethod_0("NRitem1", data2);
				}
			}
			else if (sbyte_6 == 2)
			{
				int num2 = gclass131_0.method_6();
				int num3 = gclass131_0.method_6();
				for (int k = num2; k < num3; k++)
				{
					GClass83.smethod_0(new GClass118((short)k, gclass131_0.method_2(), gclass131_0.method_2(), gclass131_0.method_14(), gclass131_0.method_14(), gclass131_0.method_2(), gclass131_0.method_8(), gclass131_0.method_6(), gclass131_0.method_6(), gclass131_0.method_11()));
				}
				if (bool_6)
				{
					gclass131_0.method_4();
					sbyte[] data3 = new sbyte[gclass131_0.method_18()];
					gclass131_0.method_17(ref data3);
					GClass120.smethod_0("NRitem2", data3);
					GClass120.smethod_0("NRitemVersion", new sbyte[1] { GClass154.sbyte_3 });
					GClass149.bool_8 = false;
					if (GClass154.sbyte_4 == GClass154.sbyte_0 && GClass154.sbyte_5 == GClass154.sbyte_1 && GClass154.sbyte_6 == GClass154.sbyte_2 && GClass154.sbyte_7 == GClass154.sbyte_3)
					{
						GClass154.smethod_8().method_22();
						GClass154.smethod_8().method_20();
						GClass154.smethod_8().method_21();
						GClass154.smethod_8().method_23();
						GClass166.smethod_0().method_83();
					}
				}
			}
			else if (sbyte_6 == 100)
			{
				GClass58.int_173 = method_21(gclass131_0);
				if (bool_6)
				{
					gclass131_0.method_4();
					sbyte[] data4 = new sbyte[gclass131_0.method_18()];
					gclass131_0.method_17(ref data4);
					GClass120.smethod_0("NRitem100", data4);
				}
			}
		}
		catch (Exception ex)
		{
			ex.ToString();
		}
	}

	private void method_20(GClass110 gclass110_1, int int_2)
	{
		try
		{
			int num = gclass110_1.method_1().method_2();
			int[][] array = new int[num][];
			for (int i = 0; i < num; i++)
			{
				int num2 = gclass110_1.method_1().method_2();
				array[i] = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					array[i][j] = gclass110_1.method_1().method_2();
				}
			}
			gclass9_0.method_4(int_2 + string.Empty, array);
		}
		catch (Exception)
		{
		}
	}

	private int[][] method_21(GClass131 gclass131_0)
	{
		int[][] array = new int[1][] { new int[2] { 542, 543 } };
		try
		{
			array = new int[gclass131_0.method_6()][];
			for (int i = 0; i < array.Length; i++)
			{
				int num = gclass131_0.method_2();
				array[i] = new int[num];
				for (int j = 0; j < num; j++)
				{
					array[i][j] = gclass131_0.method_6();
				}
			}
			return array;
		}
		catch (Exception)
		{
			return array;
		}
	}

	public void method_22(GClass110 msg)
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

	private void method_23(GClass110 gclass110_1, int int_2)
	{
		try
		{
			sbyte b = gclass110_1.method_1().method_2();
			if (b == 0)
			{
				short idmapPaint = gclass110_1.method_1().method_6();
				string nameTeam = gclass110_1.method_1().method_14();
				string nameTeam2 = gclass110_1.method_1().method_14();
				int maxPoint = gclass110_1.method_1().method_8();
				short timeSecond = gclass110_1.method_1().method_6();
				int int_3 = gclass110_1.method_1().method_2();
				GClass154.gclass51_0 = new GClass51(int_2, idmapPaint, nameTeam, nameTeam2, maxPoint, timeSecond);
				GClass154.gclass51_0.int_6 = int_3;
				GClass154.gclass51_0.method_2(int_2, 0, 0);
			}
			else if (b == 1)
			{
				int pointTeam = gclass110_1.method_1().method_8();
				int pointTeam2 = gclass110_1.method_1().method_8();
				if (GClass154.gclass51_0 != null)
					GClass154.gclass51_0.method_1(int_2, pointTeam, pointTeam2);
			}
			else if (b == 2)
			{
				sbyte b2 = gclass110_1.method_1().method_2();
				short type = 0;
				if (b2 == 1)
					type = 1;
				else if (b2 == 2)
				{
					type = 2;
				}
				GClass154.gclass51_0 = null;
				GClass154.smethod_35(type, -1, 0, GClass39.int_12, GClass39.int_13, 0, 0, -1, null);
			}
			else if (b == 5)
			{
				short timeSecond2 = gclass110_1.method_1().method_6();
				if (GClass154.gclass51_0 != null)
					GClass154.gclass51_0.method_0(int_2, timeSecond2);
			}
			else if (b == 4)
			{
				int lifeTeam = gclass110_1.method_1().method_2();
				int lifeTeam2 = gclass110_1.method_1().method_2();
				if (GClass154.gclass51_0 != null)
					GClass154.gclass51_0.method_2(int_2, lifeTeam, lifeTeam2);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_24(GClass110 msg)
	{
		try
		{
			sbyte b = msg.method_1().method_2();
			if (b == 0)
			{
				short short_ = msg.method_1().method_6();
				GClass58.smethod_1().short_30 = short_;
				GClass29.smethod_1().method_2();
			}
			else if (b == 2)
			{
				int num = msg.method_1().method_8();
				sbyte b2 = msg.method_1().method_2();
				short num2 = msg.method_1().method_6();
				string v = num2 + "," + b2;
				GClass35.smethod_1("banner_" + num2, GClass35.gclass9_0);
				GClass39.gclass9_0.method_4(num + string.Empty, v);
			}
			else if (b == 3)
			{
				short num3 = msg.method_1().method_6();
				GClass96.smethod_5(num3);
				GClass16.short_0 = num3;
			}
			else if (b == 4)
			{
				string o = msg.method_1().method_14();
				GClass39.gclass63_2.method_0(o);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_25(GClass110 msg)
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
				GClass74 gClass;
				while (true)
				{
					if (num2 < GClass58.smethod_1().gclass63_0.method_2())
					{
						gClass = (GClass74)GClass58.smethod_1().gclass63_0.method_3(num2);
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
				int num3 = 0;
				GClass74 gClass2;
				while (true)
				{
					if (num3 < GClass58.smethod_1().gclass63_0.method_2())
					{
						gClass2 = (GClass74)GClass58.smethod_1().gclass63_0.method_3(num3);
						if (gClass2.short_0 == num)
							break;
						num3++;
						continue;
					}
					return;
				}
				for (int i = 0; i < 20; i++)
				{
					GClass35.smethod_1("Skills_" + gClass2.gclass53_0.sbyte_0 + "_" + b2 + "_" + i, GClass35.gclass9_0);
				}
			}
			else
			{
				if (b != -1)
					return;
				GClass74 gClass3 = GClass61.smethod_1(num);
				for (int j = 0; j < GClass58.smethod_1().gclass63_0.method_2(); j++)
				{
					if (((GClass74)GClass58.smethod_1().gclass63_0.method_3(j)).gclass53_0.sbyte_0 == gClass3.gclass53_0.sbyte_0)
					{
						GClass58.smethod_1().gclass63_0.method_5(gClass3, j);
						break;
					}
				}
				for (int k = 0; k < GClass58.smethod_1().gclass63_1.method_2(); k++)
				{
					if (((GClass74)GClass58.smethod_1().gclass63_1.method_3(k)).gclass53_0.sbyte_0 == gClass3.gclass53_0.sbyte_0)
					{
						GClass58.smethod_1().gclass63_1.method_5(gClass3, k);
						break;
					}
				}
				for (int l = 0; l < GClass154.gclass74_1.Length; l++)
				{
					if (GClass154.gclass74_1[l] != null && GClass154.gclass74_1[l].gclass53_0.sbyte_0 == gClass3.gclass53_0.sbyte_0)
					{
						GClass154.gclass74_1[l] = gClass3;
						break;
					}
				}
				for (int m = 0; m < GClass154.gclass74_0.Length; m++)
				{
					if (GClass154.gclass74_0[m] != null && GClass154.gclass74_0[m].gclass53_0.sbyte_0 == gClass3.gclass53_0.sbyte_0)
					{
						GClass154.gclass74_0[m] = gClass3;
						break;
					}
				}
				if (GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == gClass3.gclass53_0.sbyte_0)
					GClass58.smethod_1().gclass74_0 = gClass3;
				GClass154.gclass210_0.method_7(mResources.hasJustUpgrade1 + gClass3.gclass53_0.string_0 + mResources.hasJustUpgrade2 + gClass3.int_0, 0);
			}
		}
		catch (Exception)
		{
		}
	}
}
