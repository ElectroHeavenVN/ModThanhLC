using System;
using ns0;

internal class Class5
{
	public static void smethod_0(GClass110 gclass110_0)
	{
		try
		{
			sbyte sbyte_ = gclass110_0.sbyte_0;
			if (sbyte_ <= 42)
			{
				switch (sbyte_)
				{
				case sbyte.MinValue:
					smethod_3(gclass110_0);
					return;
				case -127:
					smethod_1(gclass110_0);
					return;
				case -126:
				{
					sbyte b10 = gclass110_0.method_1().method_2();
					GClass56.smethod_8("type quay= " + b10);
					if (b10 == 1)
					{
						gclass110_0.method_1().method_2();
						string num11 = gclass110_0.method_1().method_14();
						string finish = gclass110_0.method_1().method_14();
						GClass154.smethod_8().method_118(num11, finish);
					}
					if (b10 == 0)
						GClass154.smethod_8().method_123(gclass110_0.method_1().method_14());
					return;
				}
				case -125:
				{
					GClass7.smethod_0().bool_0 = false;
					string text2 = gclass110_0.method_1().method_14();
					GClass56.smethod_8("titile= " + text2);
					sbyte b14 = gclass110_0.method_1().method_2();
					GClass155.smethod_2().method_1(b14, text2);
					for (int num20 = 0; num20 < b14; num20++)
					{
						GClass155.smethod_2().gclass67_0[num20].string_7 = gclass110_0.method_1().method_14();
						sbyte b15 = gclass110_0.method_1().method_2();
						if (b15 == 0)
							GClass155.smethod_2().gclass67_0[num20].method_28(GClass67.int_12);
						if (b15 == 1)
							GClass155.smethod_2().gclass67_0[num20].method_28(GClass67.int_11);
						if (b15 == 2)
							GClass155.smethod_2().gclass67_0[num20].method_28(GClass67.int_13);
					}
					return;
				}
				case -124:
				{
					sbyte b11 = gclass110_0.method_1().method_2();
					sbyte b12 = gclass110_0.method_1().method_2();
					if (b12 == 0)
					{
						if (b11 == 2)
						{
							int num12 = gclass110_0.method_1().method_8();
							if (num12 == GClass58.smethod_1().int_13)
								GClass58.smethod_1().method_128();
							else if (GClass154.smethod_14(num12) != null)
							{
								GClass154.smethod_14(num12).method_128();
							}
						}
						int num13 = gclass110_0.method_1().method_5();
						int num14 = gclass110_0.method_1().method_8();
						if (num13 == 32)
						{
							if (b11 == 1)
							{
								int num15 = gclass110_0.method_1().method_8();
								if (num14 == GClass58.smethod_1().int_13)
								{
									GClass58.smethod_1().int_159 = num13;
									GClass154.smethod_14(num15).method_104(GClass58.smethod_1());
								}
								else if (GClass154.smethod_14(num14) != null && num15 != GClass58.smethod_1().int_13)
								{
									GClass154.smethod_14(num14).int_159 = num13;
									GClass154.smethod_14(num15).method_104(GClass154.smethod_14(num14));
								}
								else if (GClass154.smethod_14(num14) != null && num15 == GClass58.smethod_1().int_13)
								{
									GClass154.smethod_14(num14).int_159 = num13;
									GClass58.smethod_1().method_104(GClass154.smethod_14(num14));
								}
							}
							else if (num14 == GClass58.smethod_1().int_13)
							{
								GClass58.smethod_1().method_125();
							}
							else if (GClass154.smethod_14(num14) != null)
							{
								GClass154.smethod_14(num14).method_125();
							}
						}
						if (num13 == 33)
						{
							if (b11 == 1)
							{
								if (num14 == GClass58.smethod_1().int_13)
									GClass58.smethod_1().bool_64 = true;
								else if (GClass154.smethod_14(num14) != null)
								{
									GClass154.smethod_14(num14).bool_64 = true;
								}
							}
							else if (num14 == GClass58.smethod_1().int_13)
							{
								GClass58.smethod_1().method_126();
							}
							else if (GClass154.smethod_14(num14) != null)
							{
								GClass154.smethod_14(num14).method_126();
							}
						}
						if (num13 == 39)
						{
							if (b11 == 1)
							{
								if (num14 == GClass58.smethod_1().int_13)
									GClass58.smethod_1().bool_69 = true;
								else if (GClass154.smethod_14(num14) != null)
								{
									GClass154.smethod_14(num14).bool_69 = true;
								}
							}
							else if (num14 == GClass58.smethod_1().int_13)
							{
								GClass58.smethod_1().method_130();
							}
							else if (GClass154.smethod_14(num14) != null)
							{
								GClass154.smethod_14(num14).method_130();
							}
						}
						if (num13 == 40)
						{
							if (b11 == 1)
							{
								if (num14 == GClass58.smethod_1().int_13)
									GClass58.smethod_1().bool_70 = true;
								else if (GClass154.smethod_14(num14) != null)
								{
									GClass154.smethod_14(num14).bool_70 = true;
								}
							}
							else if (num14 == GClass58.smethod_1().int_13)
							{
								GClass58.smethod_1().method_127();
							}
							else if (GClass154.smethod_14(num14) != null)
							{
								GClass154.smethod_14(num14).method_127();
							}
						}
						if (num13 == 41)
						{
							if (b11 == 1)
							{
								if (num14 == GClass58.smethod_1().int_13)
									GClass58.smethod_1().bool_72 = true;
								else if (GClass154.smethod_14(num14) != null)
								{
									GClass154.smethod_14(num14).bool_72 = true;
								}
							}
							else if (num14 == GClass58.smethod_1().int_13)
							{
								GClass58.smethod_1().method_133();
							}
							else if (GClass154.smethod_14(num14) != null)
							{
								GClass154.smethod_14(num14).method_133();
							}
						}
						if (num13 == 42)
						{
							if (b11 == 1)
							{
								if (num14 == GClass58.smethod_1().int_13)
									GClass58.smethod_1().bool_73 = true;
							}
							else if (num14 == GClass58.smethod_1().int_13)
							{
								GClass58.smethod_1().bool_73 = false;
							}
						}
					}
					if (b12 != 1)
						return;
					int num16 = gclass110_0.method_1().method_5();
					sbyte mobIndex = gclass110_0.method_1().method_2();
					GClass56.smethod_8("modbHoldID= " + mobIndex + " skillID= " + num16 + "eff ID= " + b11);
					if (num16 == 32)
					{
						if (b11 == 1)
						{
							int num17 = gclass110_0.method_1().method_8();
							if (num17 == GClass58.smethod_1().int_13)
							{
								GClass154.smethod_15(mobIndex).int_5 = num16;
								GClass58.smethod_1().method_105(GClass154.smethod_15(mobIndex));
							}
							else if (GClass154.smethod_14(num17) != null)
							{
								GClass154.smethod_15(mobIndex).int_5 = num16;
								GClass154.smethod_14(num17).method_105(GClass154.smethod_15(mobIndex));
							}
						}
						else
							GClass154.smethod_15(mobIndex).method_24();
					}
					if (num16 == 40)
					{
						if (b11 == 1)
							GClass154.smethod_15(mobIndex).bool_21 = true;
						else
							GClass154.smethod_15(mobIndex).method_25();
					}
					if (num16 == 41)
					{
						if (b11 == 1)
							GClass154.smethod_15(mobIndex).bool_22 = true;
						else
							GClass154.smethod_15(mobIndex).method_26();
					}
					return;
				}
				case -123:
				{
					int charId = gclass110_0.method_1().method_8();
					if (GClass154.smethod_14(charId) != null)
						GClass154.smethod_14(charId).int_162 = gclass110_0.method_1().method_2();
					return;
				}
				case -122:
				{
					GClass59 gClass = GClass154.smethod_13(gclass110_0.method_1().method_6());
					sbyte b3 = gclass110_0.method_1().method_2();
					gClass.int_188 = new int[b3];
					GClass56.smethod_8("N DUA HAU= " + b3);
					for (int l = 0; l < b3; l++)
					{
						gClass.int_188[l] = gclass110_0.method_1().method_6();
					}
					gClass.method_164(gclass110_0.method_1().method_2(), gclass110_0.method_1().method_8());
					return;
				}
				case -121:
					GClass166.long_3 = GClass138.smethod_18() - GClass166.long_1;
					GClass166.smethod_0().method_37();
					return;
				case -120:
					GClass166.long_2 = GClass138.smethod_18() - GClass166.long_0;
					GClass166.smethod_0().method_36();
					return;
				case -119:
					GClass58.smethod_1().int_3 = gclass110_0.method_1().method_8();
					return;
				case -117:
					GClass154.smethod_8().int_229 = 0;
					GClass154.smethod_8().sbyte_11 = gclass110_0.method_1().method_2();
					if (GClass154.smethod_8().sbyte_11 == 100)
						GClass154.smethod_8().bool_81 = true;
					if (GClass154.smethod_8().sbyte_11 == 101)
						GClass59.bool_82 = true;
					return;
				case -116:
					GClass154.bool_68 = gclass110_0.method_1().method_2() == 1;
					return;
				case -115:
					GClass58.smethod_1().method_9(gclass110_0.method_1().method_14(), gclass110_0.method_1().method_6(), gclass110_0.method_1().method_6(), gclass110_0.method_1().method_6());
					return;
				case -113:
				{
					sbyte[] array = new sbyte[10];
					for (int i = 0; i < 10; i++)
					{
						array[i] = gclass110_0.method_1().method_2();
						GClass56.smethod_8("vlue i= " + array[i]);
					}
					GClass154.smethod_8().method_6(array);
					GClass154.smethod_8().method_5(array);
					GClass154.smethod_8().method_7(array);
					return;
				}
				case -111:
				{
					short num21 = gclass110_0.method_1().method_6();
					Class3.gclass63_0 = new GClass63();
					for (int num22 = 0; num22 < num21; num22++)
					{
						string string_ = gclass110_0.method_1().method_14();
						sbyte sbyte_2 = gclass110_0.method_1().method_2();
						Class3.gclass63_0.method_0(new Class3(string_, sbyte_2));
					}
					Class3.smethod_0();
					Class3.smethod_4();
					return;
				}
				case -110:
				{
					sbyte b13 = gclass110_0.method_1().method_2();
					if (b13 == 1)
					{
						int id = gclass110_0.method_1().method_8();
						sbyte[] array2 = GClass120.smethod_1(id + string.Empty);
						if (array2 == null)
							GClass166.smethod_0().method_138(1, -1, null);
						else
							GClass166.smethod_0().method_138(1, id, array2);
					}
					if (b13 == 0)
					{
						int num18 = gclass110_0.method_1().method_8();
						short num19 = gclass110_0.method_1().method_6();
						sbyte[] data = new sbyte[num19];
						gclass110_0.method_1().method_21(ref data, 0, num19);
						GClass120.smethod_0(num18 + string.Empty, data);
					}
					return;
				}
				case -106:
				{
					short num4 = gclass110_0.method_1().method_6();
					int num5 = gclass110_0.method_1().method_6();
					if (GClass82.smethod_0(num4))
					{
						GClass82.smethod_3(num4).method_2(num5);
						return;
					}
					GClass82 o = new GClass82(num4, num5);
					GClass58.gclass63_5.method_0(o);
					return;
				}
				case -105:
					GClass153.smethod_2().short_0 = 0;
					GClass153.smethod_2().short_1 = gclass110_0.method_1().method_6();
					GClass153.smethod_2().long_0 = (GClass153.smethod_2().long_1 = GClass138.smethod_18());
					GClass153.smethod_2().sbyte_0 = gclass110_0.method_1().method_2();
					GClass153.smethod_2().switchToMe();
					return;
				case -103:
				{
					sbyte b5 = gclass110_0.method_1().method_2();
					if (b5 == 0)
					{
						GClass39.gclass45_0.gclass63_10.method_9();
						sbyte b6 = gclass110_0.method_1().method_2();
						for (int m = 0; m < b6; m++)
						{
							GClass121 gClass2 = new GClass121();
							short num6 = gclass110_0.method_1().method_6();
							if (num6 != -1)
							{
								gClass2.gclass118_0 = GClass83.smethod_1(num6);
								sbyte b7 = gclass110_0.method_1().method_2();
								if (b7 != -1)
								{
									gClass2.gclass20_0 = new GClass20[b7];
									for (int n = 0; n < gClass2.gclass20_0.Length; n++)
									{
										int optionTemplateId2 = gclass110_0.method_1().method_5();
										int param2 = gclass110_0.method_1().method_7();
										gClass2.gclass20_0[n] = new GClass20(optionTemplateId2, param2);
									}
								}
							}
							GClass39.gclass45_0.gclass63_10.method_0(gClass2);
						}
						GClass39.gclass45_0.method_22();
						GClass39.gclass45_0.method_50();
					}
					else if (b5 == 1)
					{
						int num7 = gclass110_0.method_1().method_8();
						sbyte b8 = gclass110_0.method_1().method_2();
						GClass56.smethod_8("---------------actionFlag1:  " + num7 + " : " + b8);
						if (num7 == GClass58.smethod_1().int_13)
							GClass58.smethod_1().sbyte_28 = b8;
						else if (GClass154.smethod_14(num7) != null)
						{
							GClass154.smethod_14(num7).sbyte_28 = b8;
						}
						GClass154.smethod_8().method_114(num7, b8);
					}
					else
					{
						if (b5 != 2)
							return;
						sbyte b9 = gclass110_0.method_1().method_2();
						int num8 = gclass110_0.method_1().method_6();
						GClass207 gClass3 = new GClass207();
						gClass3.sbyte_0 = b9;
						gClass3.int_0 = num8;
						GClass154.gclass63_11.method_0(gClass3);
						for (int num9 = 0; num9 < GClass154.gclass63_11.method_2(); num9++)
						{
							GClass207 gClass4 = (GClass207)GClass154.gclass63_11.method_3(num9);
							GClass56.smethod_8("i: " + num9 + "  cflag: " + gClass4.sbyte_0 + "   IDimageFlag: " + gClass4.int_0);
						}
						for (int num10 = 0; num10 < GClass154.gclass63_5.method_2(); num10++)
						{
							GClass58 gClass5 = (GClass58)GClass154.gclass63_5.method_3(num10);
							if (gClass5 != null && gClass5.sbyte_28 == b9)
								gClass5.int_93 = num8;
						}
						if (GClass58.smethod_1().sbyte_28 == b9)
							GClass58.smethod_1().int_93 = num8;
					}
					return;
				}
				case -102:
				{
					sbyte b4 = gclass110_0.method_1().method_2();
					if (b4 != 0 && b4 == 1)
					{
						GClass39.gclass149_0.bool_12 = false;
						GClass166.smethod_0().method_38(GClass120.smethod_2("acc"), GClass120.smethod_2("pass"), GClass113.string_2, 0);
						GClass149.bool_13 = true;
					}
					return;
				}
				case -101:
				{
					GClass39.gclass149_0.bool_12 = true;
					GClass39.smethod_4();
					string text = gclass110_0.method_1().method_14();
					GClass120.smethod_4("userAo" + GClass152.int_14, text);
					GClass166.smethod_0().method_34();
					GClass166.smethod_0().method_38(text, string.Empty, GClass113.string_2, 1);
					return;
				}
				case -100:
				{
					GClass57.smethod_5();
					bool flag = false;
					if (GClass39.int_10 > 2 * GClass45.int_55)
						flag = true;
					sbyte b = gclass110_0.method_1().method_2();
					GClass56.smethod_8("t Indxe= " + b);
					GClass39.gclass45_0.int_37[b] = gclass110_0.method_1().method_2();
					GClass39.gclass45_0.int_38[b] = gclass110_0.method_1().method_2();
					GClass56.smethod_8("max page= " + GClass39.gclass45_0.int_37[b] + " curr page= " + GClass39.gclass45_0.int_38[b]);
					int num = gclass110_0.method_1().method_5();
					GClass58.smethod_1().gclass121_3[b] = new GClass121[num];
					for (int j = 0; j < num; j++)
					{
						short num2 = gclass110_0.method_1().method_6();
						if (num2 == -1)
							continue;
						GClass56.smethod_8("template id= " + num2);
						GClass58.smethod_1().gclass121_3[b][j] = new GClass121();
						GClass58.smethod_1().gclass121_3[b][j].gclass118_0 = GClass83.smethod_1(num2);
						GClass58.smethod_1().gclass121_3[b][j].int_27 = gclass110_0.method_1().method_6();
						GClass58.smethod_1().gclass121_3[b][j].int_34 = gclass110_0.method_1().method_8();
						GClass58.smethod_1().gclass121_3[b][j].int_36 = gclass110_0.method_1().method_8();
						GClass58.smethod_1().gclass121_3[b][j].sbyte_32 = gclass110_0.method_1().method_2();
						GClass58.smethod_1().gclass121_3[b][j].int_30 = gclass110_0.method_1().method_8();
						GClass58.smethod_1().gclass121_3[b][j].sbyte_33 = gclass110_0.method_1().method_2();
						GClass45.string_26 = mResources.say_wat_do_u_want_to_buy;
						sbyte b2 = gclass110_0.method_1().method_2();
						if (b2 != -1)
						{
							GClass58.smethod_1().gclass121_3[b][j].gclass20_0 = new GClass20[b2];
							for (int k = 0; k < GClass58.smethod_1().gclass121_3[b][j].gclass20_0.Length; k++)
							{
								int optionTemplateId = gclass110_0.method_1().method_5();
								int param = gclass110_0.method_1().method_7();
								GClass58.smethod_1().gclass121_3[b][j].gclass20_0[k] = new GClass20(optionTemplateId, param);
								GClass58.smethod_1().gclass121_3[b][j].int_43 = GClass39.gclass45_0.method_131(GClass58.smethod_1().gclass121_3[b][j]);
							}
						}
						if (gclass110_0.method_1().method_2() == 1)
						{
							int headTemp = gclass110_0.method_1().method_6();
							int bodyTemp = gclass110_0.method_1().method_6();
							int legTemp = gclass110_0.method_1().method_6();
							int bagTemp = gclass110_0.method_1().method_6();
							GClass58.smethod_1().gclass121_3[b][j].method_23(headTemp, bodyTemp, legTemp, bagTemp);
						}
						if (GClass113.int_3 >= 237)
						{
							GClass58.smethod_1().gclass121_3[b][j].string_3 = gclass110_0.method_1().method_14();
							GClass56.smethod_10("nguoi ki gui  " + GClass58.smethod_1().gclass121_3[b][j].string_3);
						}
					}
					if (flag)
						GClass39.gclass45_1.method_14();
					GClass39.gclass45_0.method_82();
					GClass45 gclass45_ = GClass39.gclass45_0;
					GClass45 gclass45_2 = GClass39.gclass45_0;
					int num3 = 0;
					gclass45_2.int_7 = 0;
					gclass45_.int_8 = 0;
					return;
				}
				case -89:
					GClass39.bool_0 = gclass110_0.method_1().method_2() == 1;
					return;
				case -118:
				case -114:
				case -112:
				case -109:
				case -108:
				case -107:
				case -104:
				case -99:
				case -98:
				case -97:
				case -96:
				case -95:
				case -94:
				case -93:
				case -92:
				case -91:
				case -90:
					return;
				}
				if (sbyte_ != 31)
				{
					if (sbyte_ == 42)
					{
						GClass39.smethod_29();
						GClass149.bool_0 = false;
						GClass58.bool_35 = false;
						sbyte haveName = gclass110_0.method_1().method_2();
						if (GClass39.gclass156_0 == null)
							GClass39.gclass156_0 = new GClass156(haveName);
						GClass39.gclass156_0.method_0();
					}
					return;
				}
				int num23 = gclass110_0.method_1().method_8();
				if (gclass110_0.method_1().method_2() == 1)
				{
					short short_ = gclass110_0.method_1().method_6();
					sbyte b16 = -1;
					int[] array3 = null;
					short wimg = 0;
					short himg = 0;
					try
					{
						b16 = gclass110_0.method_1().method_2();
						if (b16 > 0)
						{
							sbyte b17 = gclass110_0.method_1().method_2();
							array3 = new int[b17];
							for (int num24 = 0; num24 < b17; num24++)
							{
								array3[num24] = gclass110_0.method_1().method_2();
							}
							wimg = gclass110_0.method_1().method_6();
							himg = gclass110_0.method_1().method_6();
						}
					}
					catch (Exception)
					{
					}
					if (num23 == GClass58.smethod_1().int_13)
					{
						GClass58.smethod_1().gclass128_0 = new GClass128();
						GClass58.smethod_1().gclass128_0.short_0 = short_;
						if (b16 > 0)
							GClass58.smethod_1().gclass128_0.method_0(b16, array3, wimg, himg);
						return;
					}
					GClass58 gClass6 = GClass154.smethod_14(num23);
					gClass6.gclass128_0 = new GClass128();
					gClass6.gclass128_0.short_0 = short_;
					if (b16 > 0)
						gClass6.gclass128_0.method_0(b16, array3, wimg, himg);
				}
				else if (num23 == GClass58.smethod_1().int_13)
				{
					GClass58.smethod_1().gclass128_0.method_3();
					GClass58.smethod_1().gclass128_0 = null;
				}
				else
				{
					GClass58 gClass7 = GClass154.smethod_14(num23);
					gClass7.gclass128_0.method_3();
					gClass7.gclass128_0 = null;
				}
				return;
			}
			if (sbyte_ <= 93)
			{
				switch (sbyte_)
				{
				default:
					if (sbyte_ == 93)
					{
						string chatVip = GClass56.smethod_15(gclass110_0.method_1().method_14());
						GClass154.smethod_8().method_119(chatVip);
					}
					break;
				case 48:
					GClass152.int_14 = gclass110_0.method_1().method_2();
					GClass39.gclass39_0.method_9(GClass39.gclass152_0);
					GClass162.smethod_0().close();
					GClass39.smethod_29();
					GClass152.bool_3 = true;
					break;
				case 51:
				{
					Class1 @class = (Class1)GClass154.smethod_14(gclass110_0.method_1().method_8());
					sbyte sbyte_3 = gclass110_0.method_1().method_2();
					short short_2 = gclass110_0.method_1().method_6();
					short short_3 = gclass110_0.method_1().method_6();
					sbyte b19 = gclass110_0.method_1().method_2();
					GClass58[] array4 = new GClass58[b19];
					int[] array5 = new int[b19];
					for (int num27 = 0; num27 < b19; num27++)
					{
						int num28 = gclass110_0.method_1().method_8();
						GClass56.smethod_8("char ID=" + num28);
						array4[num27] = null;
						if (num28 != GClass58.smethod_1().int_13)
							array4[num27] = GClass154.smethod_14(num28);
						else
							array4[num27] = GClass58.smethod_1();
						array5[num27] = gclass110_0.method_1().method_8();
					}
					@class.method_167(sbyte_3, short_2, short_3, array4, array5);
					break;
				}
				case 52:
				{
					sbyte b18 = gclass110_0.method_1().method_2();
					if (b18 == 1)
					{
						int num25 = gclass110_0.method_1().method_8();
						if (num25 == GClass58.smethod_1().int_13)
						{
							GClass58.smethod_1().method_79(true);
							GClass58.smethod_1().int_4 = gclass110_0.method_1().method_6();
							GClass58.smethod_1().int_5 = gclass110_0.method_1().method_6();
						}
						else
						{
							GClass58 gClass8 = GClass154.smethod_14(num25);
							if (gClass8 != null)
							{
								gClass8.method_79(true);
								gClass8.int_4 = gclass110_0.method_1().method_6();
								gClass8.int_5 = gclass110_0.method_1().method_6();
							}
						}
					}
					if (b18 == 0)
					{
						int num26 = gclass110_0.method_1().method_8();
						if (num26 == GClass58.smethod_1().int_13)
							GClass58.smethod_1().method_79(false);
						else
							GClass154.smethod_14(num26)?.method_79(false);
					}
					if (b18 == 2)
					{
						int charId2 = gclass110_0.method_1().method_8();
						int int_ = gclass110_0.method_1().method_8();
						((Class1)GClass154.smethod_14(charId2)).method_164(int_);
					}
					if (b18 == 3)
						GClass154.sbyte_12 = gclass110_0.method_1().method_2();
					break;
				}
				case 49:
				case 50:
					break;
				}
				return;
			}
			switch (sbyte_)
			{
			case 100:
			{
				sbyte b25 = gclass110_0.method_1().method_2();
				sbyte b26 = gclass110_0.method_1().method_2();
				GClass121 gClass12 = null;
				if (b25 == 0)
					gClass12 = GClass58.smethod_1().gclass121_2[b26];
				if (b25 == 1)
					gClass12 = GClass58.smethod_1().gclass121_0[b26];
				short num35 = gclass110_0.method_1().method_6();
				if (num35 == -1)
					return;
				gClass12.gclass118_0 = GClass83.smethod_1(num35);
				gClass12.int_30 = gclass110_0.method_1().method_8();
				gClass12.string_0 = gclass110_0.method_1().method_14();
				gClass12.string_1 = gclass110_0.method_1().method_14();
				sbyte b27 = gclass110_0.method_1().method_2();
				if (b27 != 0)
				{
					gClass12.gclass20_0 = new GClass20[b27];
					for (int num36 = 0; num36 < gClass12.gclass20_0.Length; num36++)
					{
						int num37 = gclass110_0.method_1().method_5();
						GClass56.smethod_8("id o= " + num37);
						int param3 = gclass110_0.method_1().method_7();
						if (num37 != -1)
							gClass12.gclass20_0[num36] = new GClass20(num37, param3);
					}
				}
				if (gClass12.int_30 <= 0)
					gClass12 = null;
				return;
			}
			case 101:
			{
				GClass56.smethod_8("big boss--------------------------------------------------");
				GClass89 gClass11 = GClass85.smethod_1();
				if (gClass11 == null)
					return;
				sbyte b23 = gclass110_0.method_1().method_2();
				if (b23 == 0 || b23 == 1 || b23 == 2 || b23 == 4 || b23 == 3)
				{
					if (b23 == 3)
					{
						gClass11.int_55 = (gClass11.int_16 = gclass110_0.method_1().method_6());
						gClass11.int_56 = (gClass11.int_17 = gclass110_0.method_1().method_6());
						gClass11.method_42();
					}
					else
					{
						sbyte b24 = gclass110_0.method_1().method_2();
						GClass56.smethod_8("CHUONG nChar= " + b24);
						GClass58[] array10 = new GClass58[b24];
						int[] array11 = new int[b24];
						for (int num33 = 0; num33 < b24; num33++)
						{
							int num34 = gclass110_0.method_1().method_8();
							GClass56.smethod_8("char ID=" + num34);
							array10[num33] = null;
							if (num34 != GClass58.smethod_1().int_13)
								array10[num33] = GClass154.smethod_14(num34);
							else
								array10[num33] = GClass58.smethod_1();
							array11[num33] = gclass110_0.method_1().method_8();
						}
						gClass11.method_43(array10, array11, b23);
					}
				}
				if (b23 == 5)
				{
					gClass11.bool_24 = true;
					gClass11.int_12 = 2;
				}
				if (b23 == 6)
				{
					gClass11.method_29();
					gClass11.int_8 = gclass110_0.method_1().method_6();
					gClass11.int_9 = gclass110_0.method_1().method_6();
				}
				if (b23 == 7)
					gClass11.method_43(null, null, b23);
				if (b23 == 8)
				{
					gClass11.int_55 = (gClass11.int_16 = gclass110_0.method_1().method_6());
					gClass11.int_56 = (gClass11.int_17 = gclass110_0.method_1().method_6());
					gClass11.int_12 = 2;
				}
				if (b23 == 9)
				{
					int num3 = -1000;
					gClass11.int_17 = -1000;
					num3 = -1000;
					gClass11.int_16 = -1000;
					num3 = -1000;
					gClass11.int_56 = -1000;
					num3 = -1000;
					gClass11.int_55 = -1000;
					num3 = -1000;
					gClass11.int_9 = -1000;
					gClass11.int_8 = -1000;
				}
				return;
			}
			case 102:
			{
				sbyte b20 = gclass110_0.method_1().method_2();
				if (b20 == 0 || b20 == 1 || b20 == 2 || b20 == 6)
				{
					GClass88 gClass9 = GClass85.smethod_2();
					if (gClass9 == null)
						return;
					if (b20 == 6)
					{
						int num3 = -1000;
						gClass9.int_17 = -1000;
						num3 = -1000;
						gClass9.int_16 = -1000;
						num3 = -1000;
						gClass9.int_56 = -1000;
						num3 = -1000;
						gClass9.int_55 = -1000;
						num3 = -1000;
						gClass9.int_9 = -1000;
						gClass9.int_8 = -1000;
						return;
					}
					sbyte b21 = gclass110_0.method_1().method_2();
					GClass58[] array6 = new GClass58[b21];
					int[] array7 = new int[b21];
					for (int num29 = 0; num29 < b21; num29++)
					{
						int num30 = gclass110_0.method_1().method_8();
						array6[num29] = null;
						if (num30 != GClass58.smethod_1().int_13)
							array6[num29] = GClass154.smethod_14(num30);
						else
							array6[num29] = GClass58.smethod_1();
						array7[num29] = gclass110_0.method_1().method_8();
					}
					gClass9.method_42(array6, array7, b20);
				}
				if (b20 == 3 || b20 == 4 || b20 == 5 || b20 == 7)
				{
					GClass86 gClass10 = GClass85.smethod_3();
					if (gClass10 == null)
						return;
					if (b20 == 7)
					{
						int num3 = -1000;
						gClass10.int_17 = -1000;
						num3 = -1000;
						gClass10.int_16 = -1000;
						num3 = -1000;
						gClass10.int_56 = -1000;
						num3 = -1000;
						gClass10.int_55 = -1000;
						num3 = -1000;
						gClass10.int_9 = -1000;
						gClass10.int_8 = -1000;
						return;
					}
					if (b20 == 3 || b20 == 4)
					{
						sbyte b22 = gclass110_0.method_1().method_2();
						GClass58[] array8 = new GClass58[b22];
						int[] array9 = new int[b22];
						for (int num31 = 0; num31 < b22; num31++)
						{
							int num32 = gclass110_0.method_1().method_8();
							array8[num31] = null;
							if (num32 != GClass58.smethod_1().int_13)
								array8[num31] = GClass154.smethod_14(num32);
							else
								array8[num31] = GClass58.smethod_1();
							array9[num31] = gclass110_0.method_1().method_8();
						}
						gClass10.method_41(array8, array9, b20);
					}
					if (b20 == 5)
						gClass10.method_53(gclass110_0.method_1().method_6());
				}
				if (b20 > 9 && b20 < 30)
					smethod_4(gclass110_0, b20);
				return;
			}
			}
			switch (sbyte_)
			{
			case 113:
			{
				int loop = 0;
				int layer = 0;
				int id2 = 0;
				short x = 0;
				short y = 0;
				short loopCount = -1;
				try
				{
					loop = gclass110_0.method_1().method_2();
					layer = gclass110_0.method_1().method_2();
					id2 = gclass110_0.method_1().method_5();
					x = gclass110_0.method_1().method_6();
					y = gclass110_0.method_1().method_6();
					loopCount = gclass110_0.method_1().method_6();
				}
				catch (Exception)
				{
				}
				GClass81.smethod_0(new GClass33(id2, x, y, layer, loop, loopCount));
				break;
			}
			case 114:
				try
				{
					gclass110_0.method_1().method_14();
					GClass138.sbyte_1 = gclass110_0.method_1().method_2();
					GClass138.sbyte_2 = gclass110_0.method_1().method_2();
					break;
				}
				catch (Exception)
				{
					break;
				}
			case 121:
				GClass138.string_1 = gclass110_0.method_1().method_14();
				GClass138.string_0 = gclass110_0.method_1().method_14();
				GClass56.smethod_8("SHOW AD public ID= " + GClass138.string_1);
				GClass138.smethod_13();
				break;
			case 122:
			{
				short short_4 = gclass110_0.method_1().method_6();
				GClass56.smethod_8("second login = " + short_4);
				GClass149.short_0 = short_4;
				GClass149.long_1 = (GClass149.long_0 = GClass138.smethod_18());
				GClass39.smethod_29();
				break;
			}
			case 123:
			{
				GClass56.smethod_8("SET POSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSss");
				int num39 = gclass110_0.method_1().method_8();
				short xPos = gclass110_0.method_1().method_6();
				short yPos = gclass110_0.method_1().method_6();
				sbyte b28 = gclass110_0.method_1().method_2();
				GClass58 gClass13 = null;
				if (num39 == GClass58.smethod_1().int_13)
					gClass13 = GClass58.smethod_1();
				else if (GClass154.smethod_14(num39) != null)
				{
					gClass13 = GClass154.smethod_14(num39);
				}
				if (gClass13 != null)
				{
					GClass71.smethod_3((b28 != 0) ? 173 : 60, gClass13, 1);
					gClass13.method_129(xPos, yPos, b28);
				}
				break;
			}
			case 124:
			{
				short id3 = gclass110_0.method_1().method_6();
				string text3 = gclass110_0.method_1().method_14();
				GClass56.smethod_8("noi chuyen = " + text3 + "npc ID= " + id3);
				GClass154.smethod_13(id3)?.method_10(text3);
				break;
			}
			case 125:
			{
				sbyte fusion = gclass110_0.method_1().method_2();
				int num38 = gclass110_0.method_1().method_8();
				if (num38 == GClass58.smethod_1().int_13)
					GClass58.smethod_1().method_132(fusion);
				else if (GClass154.smethod_14(num38) != null)
				{
					GClass154.smethod_14(num38).method_132(fusion);
				}
				break;
			}
			case sbyte.MaxValue:
				smethod_2(gclass110_0);
				break;
			case 115:
			case 116:
			case 117:
			case 118:
			case 119:
			case 120:
			case 126:
				break;
			}
		}
		catch (Exception ex4)
		{
			GClass56.smethod_8("=====> Controller2 " + ex4.StackTrace);
		}
	}

	private static void smethod_1(GClass110 gclass110_0)
	{
		try
		{
			sbyte b = gclass110_0.method_1().method_2();
			if (b == 0)
			{
				sbyte b2 = gclass110_0.method_1().method_2();
				short[] array = new short[b2];
				for (int i = 0; i < b2; i++)
				{
					array[i] = gclass110_0.method_1().method_6();
				}
				sbyte b3 = gclass110_0.method_1().method_2();
				int price = gclass110_0.method_1().method_8();
				short idTicket = gclass110_0.method_1().method_6();
				GClass150.smethod_2().method_0(array, (byte)b3, price, idTicket);
			}
			else if (b == 1)
			{
				sbyte b4 = gclass110_0.method_1().method_2();
				short[] array2 = new short[b4];
				for (int j = 0; j < b4; j++)
				{
					array2[j] = gclass110_0.method_1().method_6();
				}
				GClass150.smethod_2().method_7(array2);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_2(GClass110 gclass110_0)
	{
		try
		{
			sbyte b = gclass110_0.method_1().method_2();
			if (b == 0)
			{
				GClass146.smethod_2();
				GClass63 gClass = new GClass63(string.Empty);
				short num = gclass110_0.method_1().method_6();
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					GClass97 gClass2 = new GClass97();
					int id = gclass110_0.method_1().method_6();
					int no = i + 1;
					int idIcon = gclass110_0.method_1().method_6();
					sbyte rank = gclass110_0.method_1().method_2();
					sbyte amount = gclass110_0.method_1().method_2();
					sbyte max_amount = gclass110_0.method_1().method_2();
					short templateId = -1;
					GClass58 charInfo = null;
					sbyte b2 = gclass110_0.method_1().method_2();
					if (b2 == 0)
						templateId = gclass110_0.method_1().method_6();
					else
						charInfo = GClass97.smethod_0(gclass110_0.method_1().method_6(), gclass110_0.method_1().method_6(), gclass110_0.method_1().method_6(), gclass110_0.method_1().method_6());
					string name = gclass110_0.method_1().method_14();
					string info = gclass110_0.method_1().method_14();
					sbyte b3 = gclass110_0.method_1().method_2();
					sbyte isUse = gclass110_0.method_1().method_2();
					sbyte b4 = gclass110_0.method_1().method_2();
					GClass20[] array = null;
					if (b4 != 0)
					{
						array = new GClass20[b4];
						for (int j = 0; j < array.Length; j++)
						{
							int optionTemplateId = gclass110_0.method_1().method_5();
							int param = gclass110_0.method_1().method_7();
							sbyte sbyte_ = gclass110_0.method_1().method_2();
							array[j] = new GClass20(optionTemplateId, param);
							array[j].sbyte_1 = sbyte_;
						}
					}
					gClass2.method_0(id, no, idIcon, rank, b2, templateId, name, info, charInfo, array);
					gClass2.method_2(b3);
					gClass2.method_3(isUse);
					gClass2.method_1(amount, max_amount);
					gClass.method_0(gClass2);
					if (b3 > 0)
						num2++;
				}
				GClass146.smethod_2().method_0(gClass, num2, num);
				GClass146.smethod_2().switchToMe();
			}
			else if (b == 1)
			{
				int id2 = gclass110_0.method_1().method_6();
				sbyte isUse2 = gclass110_0.method_1().method_2();
				if (GClass97.smethod_1(GClass146.gclass63_0, id2) != null)
					GClass97.smethod_1(GClass146.gclass63_0, id2).method_3(isUse2);
				GClass146.smethod_4();
			}
			else if (b == 2)
			{
				int num3 = gclass110_0.method_1().method_6();
				sbyte level = gclass110_0.method_1().method_2();
				int num4 = 0;
				for (int k = 0; k < GClass146.gclass63_0.method_2(); k++)
				{
					GClass97 gClass3 = (GClass97)GClass146.gclass63_0.method_3(k);
					if (gClass3 != null)
					{
						if (gClass3.int_0 == num3)
							gClass3.method_2(level);
						if (gClass3.sbyte_6 > 0)
							num4++;
					}
				}
				GClass146.smethod_3(num4, GClass146.gclass63_0.method_2());
				if (GClass97.smethod_1(GClass146.gclass63_1, num3) != null)
					GClass97.smethod_1(GClass146.gclass63_1, num3).method_2(level);
			}
			else if (b == 3)
			{
				int id3 = gclass110_0.method_1().method_6();
				sbyte amount2 = gclass110_0.method_1().method_2();
				sbyte max_amount2 = gclass110_0.method_1().method_2();
				if (GClass97.smethod_1(GClass146.gclass63_0, id3) != null)
					GClass97.smethod_1(GClass146.gclass63_0, id3).method_1(amount2, max_amount2);
				if (GClass97.smethod_1(GClass146.gclass63_1, id3) != null)
					GClass97.smethod_1(GClass146.gclass63_1, id3).method_1(amount2, max_amount2);
			}
			else if (b == 4)
			{
				int num5 = gclass110_0.method_1().method_8();
				short short_ = gclass110_0.method_1().method_6();
				GClass58 gClass4 = null;
				gClass4 = ((num5 != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num5) : GClass58.smethod_1());
				if (gClass4 != null)
				{
					gClass4.short_28 = short_;
					gClass4.short_29 = gclass110_0.method_1().method_2();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_3(GClass110 gclass110_0)
	{
		try
		{
			sbyte b = gclass110_0.method_1().method_2();
			int num = gclass110_0.method_1().method_8();
			GClass58 gClass = null;
			gClass = ((num != GClass58.smethod_1().int_13) ? GClass154.smethod_14(num) : GClass58.smethod_1());
			if (b == 0)
			{
				int id = gclass110_0.method_1().method_6();
				int layer = gclass110_0.method_1().method_2();
				int loop = gclass110_0.method_1().method_2();
				short loopCount = gclass110_0.method_1().method_6();
				sbyte isStand = gclass110_0.method_1().method_2();
				gClass?.method_138(new GClass33(id, gClass, layer, loop, loopCount, isStand));
			}
			else if (b == 1)
			{
				int id2 = gclass110_0.method_1().method_6();
				gClass?.method_139(0, id2);
			}
			else if (b == 2)
			{
				gClass?.method_139(-1, 0);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_4(GClass110 gclass110_0, int int_0)
	{
		try
		{
			GClass87 gClass = GClass85.smethod_4(gclass110_0.method_1().method_2());
			if (gClass == null)
				return;
			if (int_0 == 10)
				gClass.method_50(gclass110_0.method_1().method_6(), gclass110_0.method_1().method_6());
			if (int_0 >= 11 && int_0 <= 20)
			{
				sbyte b = gclass110_0.method_1().method_2();
				GClass58[] array = new GClass58[b];
				int[] array2 = new int[b];
				for (int i = 0; i < b; i++)
				{
					int num = gclass110_0.method_1().method_8();
					array[i] = null;
					if (num != GClass58.smethod_1().int_13)
						array[i] = GClass154.smethod_14(num);
					else
						array[i] = GClass58.smethod_1();
					array2[i] = gclass110_0.method_1().method_8();
				}
				gClass.method_39(array, array2, (sbyte)(int_0 - 10), gclass110_0.method_1().method_2());
			}
			if (int_0 == 21)
			{
				gClass.int_55 = gclass110_0.method_1().method_6();
				gClass.int_56 = gclass110_0.method_1().method_6();
				gClass.method_38();
			}
			if (int_0 == 22)
				;
			if (int_0 == 23)
				gClass.method_52();
		}
		catch (Exception)
		{
		}
	}
}
