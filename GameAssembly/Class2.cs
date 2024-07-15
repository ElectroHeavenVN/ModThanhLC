using System;
using ns0;

internal class Class2
{
	public static void smethod_0(GClass100 gclass100_0)
	{
		try
		{
			sbyte sbyte_ = gclass100_0.sbyte_0;
			if (sbyte_ <= 42)
			{
				switch (sbyte_)
				{
				case sbyte.MinValue:
					smethod_3(gclass100_0);
					return;
				case -127:
					smethod_1(gclass100_0);
					return;
				case -126:
				{
					sbyte b15 = gclass100_0.method_1().method_2();
					GClass191.smethod_8("type quay= " + b15);
					if (b15 == 1)
					{
						gclass100_0.method_1().method_2();
						string num20 = gclass100_0.method_1().method_14();
						string finish = gclass100_0.method_1().method_14();
						GClass167.smethod_8().method_120(num20, finish);
					}
					if (b15 == 0)
						GClass167.smethod_8().method_125(gclass100_0.method_1().method_14());
					return;
				}
				case -125:
				{
					GClass107.smethod_0().bool_0 = false;
					string text2 = gclass100_0.method_1().method_14();
					GClass191.smethod_8("titile= " + text2);
					sbyte b13 = gclass100_0.method_1().method_2();
					GClass164.smethod_2().method_1(b13, text2);
					for (int num19 = 0; num19 < b13; num19++)
					{
						GClass164.smethod_2().gclass136_0[num19].string_7 = gclass100_0.method_1().method_14();
						sbyte b14 = gclass100_0.method_1().method_2();
						if (b14 == 0)
							GClass164.smethod_2().gclass136_0[num19].method_28(GClass136.int_12);
						if (b14 == 1)
							GClass164.smethod_2().gclass136_0[num19].method_28(GClass136.int_11);
						if (b14 == 2)
							GClass164.smethod_2().gclass136_0[num19].method_28(GClass136.int_13);
					}
					return;
				}
				case -124:
				{
					sbyte b2 = gclass100_0.method_1().method_2();
					sbyte b3 = gclass100_0.method_1().method_2();
					if (b3 == 0)
					{
						if (b2 == 2)
						{
							int num = gclass100_0.method_1().method_8();
							if (num == GClass124.smethod_1().int_13)
								GClass124.smethod_1().method_130();
							else if (GClass167.smethod_14(num) != null)
							{
								GClass167.smethod_14(num).method_130();
							}
						}
						int num2 = gclass100_0.method_1().method_5();
						int num3 = gclass100_0.method_1().method_8();
						if (num2 == 32)
						{
							if (b2 != 1)
							{
								if (num3 != GClass124.smethod_1().int_13)
								{
									if (GClass167.smethod_14(num3) != null)
										GClass167.smethod_14(num3).method_127();
								}
								else
									GClass124.smethod_1().method_127();
							}
							else
							{
								int num4 = gclass100_0.method_1().method_8();
								if (num3 == GClass124.smethod_1().int_13)
								{
									GClass124.smethod_1().int_159 = num2;
									GClass167.smethod_14(num4).method_106(GClass124.smethod_1());
								}
								else if (GClass167.smethod_14(num3) == null || num4 == GClass124.smethod_1().int_13)
								{
									if (GClass167.smethod_14(num3) != null && num4 == GClass124.smethod_1().int_13)
									{
										GClass167.smethod_14(num3).int_159 = num2;
										GClass124.smethod_1().method_106(GClass167.smethod_14(num3));
									}
								}
								else
								{
									GClass167.smethod_14(num3).int_159 = num2;
									GClass167.smethod_14(num4).method_106(GClass167.smethod_14(num3));
								}
							}
						}
						if (num2 == 33)
						{
							if (b2 == 1)
							{
								if (num3 == GClass124.smethod_1().int_13)
									GClass124.smethod_1().bool_64 = true;
								else if (GClass167.smethod_14(num3) != null)
								{
									GClass167.smethod_14(num3).bool_64 = true;
								}
							}
							else if (num3 != GClass124.smethod_1().int_13)
							{
								if (GClass167.smethod_14(num3) != null)
									GClass167.smethod_14(num3).method_128();
							}
							else
							{
								GClass124.smethod_1().method_128();
							}
						}
						if (num2 == 39)
						{
							if (b2 != 1)
							{
								if (num3 != GClass124.smethod_1().int_13)
								{
									if (GClass167.smethod_14(num3) != null)
										GClass167.smethod_14(num3).method_132();
								}
								else
									GClass124.smethod_1().method_132();
							}
							else if (num3 == GClass124.smethod_1().int_13)
							{
								GClass124.smethod_1().bool_69 = true;
							}
							else if (GClass167.smethod_14(num3) != null)
							{
								GClass167.smethod_14(num3).bool_69 = true;
							}
						}
						if (num2 == 40)
						{
							if (b2 != 1)
							{
								if (num3 == GClass124.smethod_1().int_13)
									GClass124.smethod_1().method_129();
								else if (GClass167.smethod_14(num3) != null)
								{
									GClass167.smethod_14(num3).method_129();
								}
							}
							else if (num3 == GClass124.smethod_1().int_13)
							{
								GClass124.smethod_1().bool_70 = true;
							}
							else if (GClass167.smethod_14(num3) != null)
							{
								GClass167.smethod_14(num3).bool_70 = true;
							}
						}
						if (num2 == 41)
						{
							if (b2 == 1)
							{
								if (num3 != GClass124.smethod_1().int_13)
								{
									if (GClass167.smethod_14(num3) != null)
										GClass167.smethod_14(num3).bool_72 = true;
								}
								else
									GClass124.smethod_1().bool_72 = true;
							}
							else if (num3 == GClass124.smethod_1().int_13)
							{
								GClass124.smethod_1().method_135();
							}
							else if (GClass167.smethod_14(num3) != null)
							{
								GClass167.smethod_14(num3).method_135();
							}
						}
						if (num2 == 42)
						{
							if (b2 == 1)
							{
								if (num3 == GClass124.smethod_1().int_13)
									GClass124.smethod_1().bool_73 = true;
							}
							else if (num3 == GClass124.smethod_1().int_13)
							{
								GClass124.smethod_1().bool_73 = false;
							}
						}
					}
					if (b3 != 1)
						return;
					int num5 = gclass100_0.method_1().method_5();
					sbyte mobIndex = gclass100_0.method_1().method_2();
					GClass191.smethod_8("modbHoldID= " + mobIndex + " skillID= " + num5 + "eff ID= " + b2);
					if (num5 == 32)
					{
						if (b2 == 1)
						{
							int num6 = gclass100_0.method_1().method_8();
							if (num6 == GClass124.smethod_1().int_13)
							{
								GClass167.smethod_15(mobIndex).int_5 = num5;
								GClass124.smethod_1().method_107(GClass167.smethod_15(mobIndex));
							}
							else if (GClass167.smethod_14(num6) != null)
							{
								GClass167.smethod_15(mobIndex).int_5 = num5;
								GClass167.smethod_14(num6).method_107(GClass167.smethod_15(mobIndex));
							}
						}
						else
							GClass167.smethod_15(mobIndex).method_24();
					}
					if (num5 == 40)
					{
						if (b2 == 1)
							GClass167.smethod_15(mobIndex).bool_21 = true;
						else
							GClass167.smethod_15(mobIndex).method_25();
					}
					if (num5 == 41)
					{
						if (b2 == 1)
							GClass167.smethod_15(mobIndex).bool_22 = true;
						else
							GClass167.smethod_15(mobIndex).method_26();
					}
					return;
				}
				case -123:
				{
					int charId = gclass100_0.method_1().method_8();
					if (GClass167.smethod_14(charId) != null)
						GClass167.smethod_14(charId).int_162 = gclass100_0.method_1().method_2();
					return;
				}
				case -122:
				{
					GClass125 gClass = GClass167.smethod_13(gclass100_0.method_1().method_6());
					sbyte b = gclass100_0.method_1().method_2();
					gClass.int_189 = new int[b];
					GClass191.smethod_8("N DUA HAU= " + b);
					for (int i = 0; i < b; i++)
					{
						gClass.int_189[i] = gclass100_0.method_1().method_6();
					}
					gClass.method_166(gclass100_0.method_1().method_2(), gclass100_0.method_1().method_8());
					return;
				}
				case -121:
					GClass2.long_3 = GClass77.smethod_18() - GClass2.long_1;
					GClass2.smethod_0().method_37();
					return;
				case -120:
					GClass2.long_2 = GClass77.smethod_18() - GClass2.long_0;
					GClass2.smethod_0().method_36();
					return;
				case -119:
					GClass124.smethod_1().int_3 = gclass100_0.method_1().method_8();
					return;
				case -117:
					GClass167.smethod_8().int_232 = 0;
					GClass167.smethod_8().sbyte_11 = gclass100_0.method_1().method_2();
					if (GClass167.smethod_8().sbyte_11 == 100)
						GClass167.smethod_8().bool_82 = true;
					if (GClass167.smethod_8().sbyte_11 == 101)
						GClass125.bool_82 = true;
					return;
				case -116:
					GClass167.bool_69 = gclass100_0.method_1().method_2() == 1;
					return;
				case -115:
					GClass124.smethod_1().method_10(gclass100_0.method_1().method_14(), gclass100_0.method_1().method_6(), gclass100_0.method_1().method_6(), gclass100_0.method_1().method_6());
					return;
				case -113:
				{
					sbyte[] array = new sbyte[10];
					for (int l = 0; l < 10; l++)
					{
						array[l] = gclass100_0.method_1().method_2();
						GClass191.smethod_8("vlue i= " + array[l]);
					}
					GClass167.smethod_8().method_6(array);
					GClass167.smethod_8().method_5(array);
					GClass167.smethod_8().method_7(array);
					return;
				}
				case -111:
				{
					short num21 = gclass100_0.method_1().method_6();
					Class0.gclass122_0 = new GClass122();
					for (int num22 = 0; num22 < num21; num22++)
					{
						string string_ = gclass100_0.method_1().method_14();
						sbyte sbyte_2 = gclass100_0.method_1().method_2();
						Class0.gclass122_0.method_0(new Class0(string_, sbyte_2));
					}
					Class0.smethod_0();
					Class0.smethod_4();
					return;
				}
				case -110:
				{
					sbyte b6 = gclass100_0.method_1().method_2();
					if (b6 == 1)
					{
						int id = gclass100_0.method_1().method_8();
						sbyte[] array2 = GClass141.smethod_1(id + string.Empty);
						if (array2 == null)
							GClass2.smethod_0().method_138(1, -1, null);
						else
							GClass2.smethod_0().method_138(1, id, array2);
					}
					if (b6 == 0)
					{
						int num10 = gclass100_0.method_1().method_8();
						short num11 = gclass100_0.method_1().method_6();
						sbyte[] data = new sbyte[num11];
						gclass100_0.method_1().method_21(ref data, 0, num11);
						GClass141.smethod_0(num10 + string.Empty, data);
					}
					return;
				}
				case -106:
				{
					short num12 = gclass100_0.method_1().method_6();
					int num13 = gclass100_0.method_1().method_6();
					if (!GClass82.smethod_0(num12))
					{
						GClass82 o = new GClass82(num12, num13);
						GClass124.gclass122_5.method_0(o);
					}
					else
						GClass82.smethod_3(num12).method_2(num13);
					return;
				}
				case -105:
					GClass171.smethod_2().short_0 = 0;
					GClass171.smethod_2().short_1 = gclass100_0.method_1().method_6();
					GClass171.smethod_2().long_0 = (GClass171.smethod_2().long_1 = GClass77.smethod_18());
					GClass171.smethod_2().sbyte_0 = gclass100_0.method_1().method_2();
					GClass171.smethod_2().switchToMe();
					return;
				case -103:
				{
					sbyte b8 = gclass100_0.method_1().method_2();
					if (b8 != 0)
					{
						if (b8 != 1)
						{
							if (b8 != 2)
								return;
							sbyte b9 = gclass100_0.method_1().method_2();
							int num14 = gclass100_0.method_1().method_6();
							GClass157 gClass2 = new GClass157();
							gClass2.sbyte_0 = b9;
							gClass2.int_0 = num14;
							GClass167.gclass122_11.method_0(gClass2);
							for (int m = 0; m < GClass167.gclass122_11.method_2(); m++)
							{
								GClass157 gClass3 = (GClass157)GClass167.gclass122_11.method_3(m);
								GClass191.smethod_8("i: " + m + "  cflag: " + gClass3.sbyte_0 + "   IDimageFlag: " + gClass3.int_0);
							}
							for (int n = 0; n < GClass167.gclass122_5.method_2(); n++)
							{
								GClass124 gClass4 = (GClass124)GClass167.gclass122_5.method_3(n);
								if (gClass4 != null && gClass4.sbyte_28 == b9)
									gClass4.int_93 = num14;
							}
							if (GClass124.smethod_1().sbyte_28 == b9)
								GClass124.smethod_1().int_93 = num14;
						}
						else
						{
							int num15 = gclass100_0.method_1().method_8();
							sbyte b10 = gclass100_0.method_1().method_2();
							GClass191.smethod_8("---------------actionFlag1:  " + num15 + " : " + b10);
							if (num15 == GClass124.smethod_1().int_13)
								GClass124.smethod_1().sbyte_28 = b10;
							else if (GClass167.smethod_14(num15) != null)
							{
								GClass167.smethod_14(num15).sbyte_28 = b10;
							}
							GClass167.smethod_8().method_116(num15, b10);
						}
						return;
					}
					GClass14.gclass113_0.gclass122_10.method_9();
					sbyte b11 = gclass100_0.method_1().method_2();
					for (int num16 = 0; num16 < b11; num16++)
					{
						GClass0 gClass5 = new GClass0();
						short num17 = gclass100_0.method_1().method_6();
						if (num17 != -1)
						{
							gClass5.gclass203_0 = GClass17.smethod_1(num17);
							sbyte b12 = gclass100_0.method_1().method_2();
							if (b12 != -1)
							{
								gClass5.gclass5_0 = new GClass5[b12];
								for (int num18 = 0; num18 < gClass5.gclass5_0.Length; num18++)
								{
									int optionTemplateId2 = gclass100_0.method_1().method_5();
									int param2 = gclass100_0.method_1().method_7();
									gClass5.gclass5_0[num18] = new GClass5(optionTemplateId2, param2);
								}
							}
						}
						GClass14.gclass113_0.gclass122_10.method_0(gClass5);
					}
					GClass14.gclass113_0.method_22();
					GClass14.gclass113_0.method_50();
					return;
				}
				case -102:
				{
					sbyte b7 = gclass100_0.method_1().method_2();
					if (b7 != 0 && b7 == 1)
					{
						GClass14.gclass173_0.bool_12 = false;
						GClass2.smethod_0().method_38(GClass141.smethod_2("acc"), GClass141.smethod_2("pass"), GClass206.string_2, 0);
						GClass173.bool_13 = true;
					}
					return;
				}
				case -101:
				{
					GClass14.gclass173_0.bool_12 = true;
					GClass14.smethod_4();
					string text = gclass100_0.method_1().method_14();
					GClass141.smethod_4("userAo" + GClass170.int_14, text);
					GClass2.smethod_0().method_34();
					GClass2.smethod_0().method_38(text, string.Empty, GClass206.string_2, 1);
					return;
				}
				case -100:
				{
					GClass96.smethod_5();
					bool flag = false;
					if (GClass14.int_10 > 2 * GClass113.int_55)
						flag = true;
					sbyte b4 = gclass100_0.method_1().method_2();
					GClass191.smethod_8("t Indxe= " + b4);
					GClass14.gclass113_0.int_37[b4] = gclass100_0.method_1().method_2();
					GClass14.gclass113_0.int_38[b4] = gclass100_0.method_1().method_2();
					GClass191.smethod_8("max page= " + GClass14.gclass113_0.int_37[b4] + " curr page= " + GClass14.gclass113_0.int_38[b4]);
					int num7 = gclass100_0.method_1().method_5();
					GClass124.smethod_1().gclass0_3[b4] = new GClass0[num7];
					for (int j = 0; j < num7; j++)
					{
						short num8 = gclass100_0.method_1().method_6();
						if (num8 == -1)
							continue;
						GClass191.smethod_8("template id= " + num8);
						GClass124.smethod_1().gclass0_3[b4][j] = new GClass0();
						GClass124.smethod_1().gclass0_3[b4][j].gclass203_0 = GClass17.smethod_1(num8);
						GClass124.smethod_1().gclass0_3[b4][j].int_27 = gclass100_0.method_1().method_6();
						GClass124.smethod_1().gclass0_3[b4][j].int_34 = gclass100_0.method_1().method_8();
						GClass124.smethod_1().gclass0_3[b4][j].int_36 = gclass100_0.method_1().method_8();
						GClass124.smethod_1().gclass0_3[b4][j].sbyte_32 = gclass100_0.method_1().method_2();
						GClass124.smethod_1().gclass0_3[b4][j].int_30 = gclass100_0.method_1().method_8();
						GClass124.smethod_1().gclass0_3[b4][j].sbyte_33 = gclass100_0.method_1().method_2();
						GClass113.string_26 = mResources.say_wat_do_u_want_to_buy;
						sbyte b5 = gclass100_0.method_1().method_2();
						if (b5 != -1)
						{
							GClass124.smethod_1().gclass0_3[b4][j].gclass5_0 = new GClass5[b5];
							for (int k = 0; k < GClass124.smethod_1().gclass0_3[b4][j].gclass5_0.Length; k++)
							{
								int optionTemplateId = gclass100_0.method_1().method_5();
								int param = gclass100_0.method_1().method_7();
								GClass124.smethod_1().gclass0_3[b4][j].gclass5_0[k] = new GClass5(optionTemplateId, param);
								GClass124.smethod_1().gclass0_3[b4][j].int_43 = GClass14.gclass113_0.method_131(GClass124.smethod_1().gclass0_3[b4][j]);
							}
						}
						if (gclass100_0.method_1().method_2() == 1)
						{
							int headTemp = gclass100_0.method_1().method_6();
							int bodyTemp = gclass100_0.method_1().method_6();
							int legTemp = gclass100_0.method_1().method_6();
							int bagTemp = gclass100_0.method_1().method_6();
							GClass124.smethod_1().gclass0_3[b4][j].method_25(headTemp, bodyTemp, legTemp, bagTemp);
						}
						if (GClass206.int_3 >= 237)
						{
							GClass124.smethod_1().gclass0_3[b4][j].string_3 = gclass100_0.method_1().method_14();
							GClass191.smethod_10("nguoi ki gui  " + GClass124.smethod_1().gclass0_3[b4][j].string_3);
						}
					}
					if (flag)
						GClass14.gclass113_1.method_14();
					GClass14.gclass113_0.method_82();
					GClass113 gclass113_ = GClass14.gclass113_0;
					GClass113 gclass113_2 = GClass14.gclass113_0;
					int num9 = 0;
					gclass113_2.int_7 = 0;
					gclass113_.int_8 = 0;
					return;
				}
				case -89:
					GClass14.bool_0 = gclass100_0.method_1().method_2() == 1;
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
						GClass14.smethod_29();
						GClass173.bool_0 = false;
						GClass124.bool_35 = false;
						sbyte haveName = gclass100_0.method_1().method_2();
						if (GClass14.gclass165_0 == null)
							GClass14.gclass165_0 = new GClass165(haveName);
						GClass14.gclass165_0.method_0();
					}
					return;
				}
				int num23 = gclass100_0.method_1().method_8();
				if (gclass100_0.method_1().method_2() == 1)
				{
					short short_ = gclass100_0.method_1().method_6();
					sbyte b16 = -1;
					int[] array3 = null;
					short wimg = 0;
					short himg = 0;
					try
					{
						b16 = gclass100_0.method_1().method_2();
						if (b16 > 0)
						{
							sbyte b17 = gclass100_0.method_1().method_2();
							array3 = new int[b17];
							for (int num24 = 0; num24 < b17; num24++)
							{
								array3[num24] = gclass100_0.method_1().method_2();
							}
							wimg = gclass100_0.method_1().method_6();
							himg = gclass100_0.method_1().method_6();
						}
					}
					catch (Exception)
					{
					}
					if (num23 != GClass124.smethod_1().int_13)
					{
						GClass124 gClass6 = GClass167.smethod_14(num23);
						gClass6.gclass25_0 = new GClass25();
						gClass6.gclass25_0.short_0 = short_;
						if (b16 > 0)
							gClass6.gclass25_0.method_0(b16, array3, wimg, himg);
					}
					else
					{
						GClass124.smethod_1().gclass25_0 = new GClass25();
						GClass124.smethod_1().gclass25_0.short_0 = short_;
						if (b16 > 0)
							GClass124.smethod_1().gclass25_0.method_0(b16, array3, wimg, himg);
					}
				}
				else if (num23 != GClass124.smethod_1().int_13)
				{
					GClass124 gClass7 = GClass167.smethod_14(num23);
					gClass7.gclass25_0.method_3();
					gClass7.gclass25_0 = null;
				}
				else
				{
					GClass124.smethod_1().gclass25_0.method_3();
					GClass124.smethod_1().gclass25_0 = null;
				}
				return;
			}
			if (sbyte_ > 93)
			{
				switch (sbyte_)
				{
				case 100:
				{
					sbyte b23 = gclass100_0.method_1().method_2();
					sbyte b24 = gclass100_0.method_1().method_2();
					GClass0 gClass11 = null;
					if (b23 == 0)
						gClass11 = GClass124.smethod_1().gclass0_2[b24];
					if (b23 == 1)
						gClass11 = GClass124.smethod_1().gclass0_0[b24];
					short num31 = gclass100_0.method_1().method_6();
					if (num31 == -1)
						return;
					gClass11.gclass203_0 = GClass17.smethod_1(num31);
					gClass11.int_30 = gclass100_0.method_1().method_8();
					gClass11.string_0 = gclass100_0.method_1().method_14();
					gClass11.string_1 = gclass100_0.method_1().method_14();
					sbyte b25 = gclass100_0.method_1().method_2();
					if (b25 != 0)
					{
						gClass11.gclass5_0 = new GClass5[b25];
						for (int num32 = 0; num32 < gClass11.gclass5_0.Length; num32++)
						{
							int num33 = gclass100_0.method_1().method_5();
							GClass191.smethod_8("id o= " + num33);
							int param3 = gclass100_0.method_1().method_7();
							if (num33 != -1)
								gClass11.gclass5_0[num32] = new GClass5(num33, param3);
						}
					}
					if (gClass11.int_30 <= 0)
						gClass11 = null;
					return;
				}
				case 101:
				{
					GClass191.smethod_8("big boss--------------------------------------------------");
					GClass7 gClass10 = GClass6.smethod_1();
					if (gClass10 == null)
						return;
					sbyte b21 = gclass100_0.method_1().method_2();
					if (b21 == 0 || b21 == 1 || b21 == 2 || b21 == 4 || b21 == 3)
					{
						if (b21 == 3)
						{
							gClass10.int_55 = (gClass10.int_16 = gclass100_0.method_1().method_6());
							gClass10.int_56 = (gClass10.int_17 = gclass100_0.method_1().method_6());
							gClass10.method_42();
						}
						else
						{
							sbyte b22 = gclass100_0.method_1().method_2();
							GClass191.smethod_8("CHUONG nChar= " + b22);
							GClass124[] array8 = new GClass124[b22];
							int[] array9 = new int[b22];
							for (int num29 = 0; num29 < b22; num29++)
							{
								int num30 = gclass100_0.method_1().method_8();
								GClass191.smethod_8("char ID=" + num30);
								array8[num29] = null;
								if (num30 != GClass124.smethod_1().int_13)
									array8[num29] = GClass167.smethod_14(num30);
								else
									array8[num29] = GClass124.smethod_1();
								array9[num29] = gclass100_0.method_1().method_8();
							}
							gClass10.method_43(array8, array9, b21);
						}
					}
					if (b21 == 5)
					{
						gClass10.bool_24 = true;
						gClass10.int_12 = 2;
					}
					if (b21 == 6)
					{
						gClass10.method_29();
						gClass10.int_8 = gclass100_0.method_1().method_6();
						gClass10.int_9 = gclass100_0.method_1().method_6();
					}
					if (b21 == 7)
						gClass10.method_43(null, null, b21);
					if (b21 == 8)
					{
						gClass10.int_55 = (gClass10.int_16 = gclass100_0.method_1().method_6());
						gClass10.int_56 = (gClass10.int_17 = gclass100_0.method_1().method_6());
						gClass10.int_12 = 2;
					}
					if (b21 == 9)
					{
						int num9 = -1000;
						gClass10.int_17 = -1000;
						num9 = -1000;
						gClass10.int_16 = -1000;
						num9 = -1000;
						gClass10.int_56 = -1000;
						num9 = -1000;
						gClass10.int_55 = -1000;
						num9 = -1000;
						gClass10.int_9 = -1000;
						gClass10.int_8 = -1000;
					}
					return;
				}
				case 102:
				{
					sbyte b18 = gclass100_0.method_1().method_2();
					if (b18 == 0 || b18 == 1 || b18 == 2 || b18 == 6)
					{
						GClass8 gClass8 = GClass6.smethod_2();
						if (gClass8 == null)
							return;
						if (b18 == 6)
						{
							int num9 = -1000;
							gClass8.int_17 = -1000;
							num9 = -1000;
							gClass8.int_16 = -1000;
							num9 = -1000;
							gClass8.int_56 = -1000;
							num9 = -1000;
							gClass8.int_55 = -1000;
							num9 = -1000;
							gClass8.int_9 = -1000;
							gClass8.int_8 = -1000;
							return;
						}
						sbyte b19 = gclass100_0.method_1().method_2();
						GClass124[] array4 = new GClass124[b19];
						int[] array5 = new int[b19];
						for (int num25 = 0; num25 < b19; num25++)
						{
							int num26 = gclass100_0.method_1().method_8();
							array4[num25] = null;
							if (num26 != GClass124.smethod_1().int_13)
								array4[num25] = GClass167.smethod_14(num26);
							else
								array4[num25] = GClass124.smethod_1();
							array5[num25] = gclass100_0.method_1().method_8();
						}
						gClass8.method_42(array4, array5, b18);
					}
					if (b18 == 3 || b18 == 4 || b18 == 5 || b18 == 7)
					{
						GClass9 gClass9 = GClass6.smethod_3();
						if (gClass9 == null)
							return;
						if (b18 == 7)
						{
							int num9 = -1000;
							gClass9.int_17 = -1000;
							num9 = -1000;
							gClass9.int_16 = -1000;
							num9 = -1000;
							gClass9.int_56 = -1000;
							num9 = -1000;
							gClass9.int_55 = -1000;
							num9 = -1000;
							gClass9.int_9 = -1000;
							gClass9.int_8 = -1000;
							return;
						}
						if (b18 == 3 || b18 == 4)
						{
							sbyte b20 = gclass100_0.method_1().method_2();
							GClass124[] array6 = new GClass124[b20];
							int[] array7 = new int[b20];
							for (int num27 = 0; num27 < b20; num27++)
							{
								int num28 = gclass100_0.method_1().method_8();
								array6[num27] = null;
								if (num28 != GClass124.smethod_1().int_13)
									array6[num27] = GClass167.smethod_14(num28);
								else
									array6[num27] = GClass124.smethod_1();
								array7[num27] = gclass100_0.method_1().method_8();
							}
							gClass9.method_41(array6, array7, b18);
						}
						if (b18 == 5)
							gClass9.method_53(gclass100_0.method_1().method_6());
					}
					if (b18 > 9 && b18 < 30)
						smethod_4(gclass100_0, b18);
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
						loop = gclass100_0.method_1().method_2();
						layer = gclass100_0.method_1().method_2();
						id2 = gclass100_0.method_1().method_5();
						x = gclass100_0.method_1().method_6();
						y = gclass100_0.method_1().method_6();
						loopCount = gclass100_0.method_1().method_6();
					}
					catch (Exception)
					{
					}
					GClass98.smethod_0(new GClass85(id2, x, y, layer, loop, loopCount));
					break;
				}
				case 114:
					try
					{
						gclass100_0.method_1().method_14();
						GClass77.sbyte_1 = gclass100_0.method_1().method_2();
						GClass77.sbyte_2 = gclass100_0.method_1().method_2();
						break;
					}
					catch (Exception)
					{
						break;
					}
				case 121:
					GClass77.string_1 = gclass100_0.method_1().method_14();
					GClass77.string_0 = gclass100_0.method_1().method_14();
					GClass191.smethod_8("SHOW AD public ID= " + GClass77.string_1);
					GClass77.smethod_13();
					break;
				case 122:
				{
					short short_2 = gclass100_0.method_1().method_6();
					GClass191.smethod_8("second login = " + short_2);
					GClass173.short_0 = short_2;
					GClass173.long_1 = (GClass173.long_0 = GClass77.smethod_18());
					GClass14.smethod_29();
					break;
				}
				case 123:
				{
					GClass191.smethod_8("SET POSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSss");
					int num35 = gclass100_0.method_1().method_8();
					short xPos = gclass100_0.method_1().method_6();
					short yPos = gclass100_0.method_1().method_6();
					sbyte b26 = gclass100_0.method_1().method_2();
					GClass124 gClass12 = null;
					if (num35 == GClass124.smethod_1().int_13)
						gClass12 = GClass124.smethod_1();
					else if (GClass167.smethod_14(num35) != null)
					{
						gClass12 = GClass167.smethod_14(num35);
					}
					if (gClass12 != null)
					{
						GClass91.smethod_3((b26 != 0) ? 173 : 60, gClass12, 1);
						gClass12.method_131(xPos, yPos, b26);
					}
					break;
				}
				case 124:
				{
					short id3 = gclass100_0.method_1().method_6();
					string text3 = gclass100_0.method_1().method_14();
					GClass191.smethod_8("noi chuyen = " + text3 + "npc ID= " + id3);
					GClass167.smethod_13(id3)?.method_11(text3);
					break;
				}
				case 125:
				{
					sbyte fusion = gclass100_0.method_1().method_2();
					int num34 = gclass100_0.method_1().method_8();
					if (num34 == GClass124.smethod_1().int_13)
						GClass124.smethod_1().method_134(fusion);
					else if (GClass167.smethod_14(num34) != null)
					{
						GClass167.smethod_14(num34).method_134(fusion);
					}
					break;
				}
				case sbyte.MaxValue:
					smethod_2(gclass100_0);
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
				return;
			}
			switch (sbyte_)
			{
			default:
				if (sbyte_ == 93)
				{
					string chatVip = GClass191.smethod_15(gclass100_0.method_1().method_14());
					GClass167.smethod_8().method_121(chatVip);
				}
				break;
			case 48:
				GClass170.int_14 = gclass100_0.method_1().method_2();
				GClass14.gclass14_0.method_9(GClass14.gclass170_0);
				GClass179.smethod_0().close();
				GClass14.smethod_29();
				GClass170.bool_3 = true;
				break;
			case 51:
			{
				Class19 @class = (Class19)GClass167.smethod_14(gclass100_0.method_1().method_8());
				sbyte sbyte_3 = gclass100_0.method_1().method_2();
				short short_3 = gclass100_0.method_1().method_6();
				short short_4 = gclass100_0.method_1().method_6();
				sbyte b28 = gclass100_0.method_1().method_2();
				GClass124[] array10 = new GClass124[b28];
				int[] array11 = new int[b28];
				for (int num38 = 0; num38 < b28; num38++)
				{
					int num39 = gclass100_0.method_1().method_8();
					GClass191.smethod_8("char ID=" + num39);
					array10[num38] = null;
					if (num39 == GClass124.smethod_1().int_13)
						array10[num38] = GClass124.smethod_1();
					else
						array10[num38] = GClass167.smethod_14(num39);
					array11[num38] = gclass100_0.method_1().method_8();
				}
				@class.method_169(sbyte_3, short_3, short_4, array10, array11);
				break;
			}
			case 52:
			{
				sbyte b27 = gclass100_0.method_1().method_2();
				if (b27 == 1)
				{
					int num36 = gclass100_0.method_1().method_8();
					if (num36 != GClass124.smethod_1().int_13)
					{
						GClass124 gClass13 = GClass167.smethod_14(num36);
						if (gClass13 != null)
						{
							gClass13.method_80(true);
							gClass13.int_4 = gclass100_0.method_1().method_6();
							gClass13.int_5 = gclass100_0.method_1().method_6();
						}
					}
					else
					{
						GClass124.smethod_1().method_80(true);
						GClass124.smethod_1().int_4 = gclass100_0.method_1().method_6();
						GClass124.smethod_1().int_5 = gclass100_0.method_1().method_6();
					}
				}
				if (b27 == 0)
				{
					int num37 = gclass100_0.method_1().method_8();
					if (num37 == GClass124.smethod_1().int_13)
						GClass124.smethod_1().method_80(false);
					else
						GClass167.smethod_14(num37)?.method_80(false);
				}
				if (b27 == 2)
				{
					int charId2 = gclass100_0.method_1().method_8();
					int int_ = gclass100_0.method_1().method_8();
					((Class19)GClass167.smethod_14(charId2)).method_166(int_);
				}
				if (b27 == 3)
					GClass167.sbyte_12 = gclass100_0.method_1().method_2();
				break;
			}
			case 49:
			case 50:
				break;
			}
		}
		catch (Exception ex4)
		{
			GClass191.smethod_8("=====> Controller2 " + ex4.StackTrace);
		}
	}

	private static void smethod_1(GClass100 gclass100_0)
	{
		try
		{
			sbyte b = gclass100_0.method_1().method_2();
			if (b == 0)
			{
				sbyte b2 = gclass100_0.method_1().method_2();
				short[] array = new short[b2];
				for (int i = 0; i < b2; i++)
				{
					array[i] = gclass100_0.method_1().method_6();
				}
				sbyte b3 = gclass100_0.method_1().method_2();
				int price = gclass100_0.method_1().method_8();
				short idTicket = gclass100_0.method_1().method_6();
				GClass162.smethod_2().method_0(array, (byte)b3, price, idTicket);
			}
			else if (b == 1)
			{
				sbyte b4 = gclass100_0.method_1().method_2();
				short[] array2 = new short[b4];
				for (int j = 0; j < b4; j++)
				{
					array2[j] = gclass100_0.method_1().method_6();
				}
				GClass162.smethod_2().method_7(array2);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_2(GClass100 gclass100_0)
	{
		try
		{
			sbyte b = gclass100_0.method_1().method_2();
			if (b == 0)
			{
				GClass166.smethod_2();
				GClass122 gClass = new GClass122(string.Empty);
				short num = gclass100_0.method_1().method_6();
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					GClass81 gClass2 = new GClass81();
					int id = gclass100_0.method_1().method_6();
					int no = i + 1;
					int idIcon = gclass100_0.method_1().method_6();
					sbyte rank = gclass100_0.method_1().method_2();
					sbyte amount = gclass100_0.method_1().method_2();
					sbyte max_amount = gclass100_0.method_1().method_2();
					short templateId = -1;
					GClass124 charInfo = null;
					sbyte b2 = gclass100_0.method_1().method_2();
					if (b2 == 0)
						templateId = gclass100_0.method_1().method_6();
					else
						charInfo = GClass81.smethod_0(gclass100_0.method_1().method_6(), gclass100_0.method_1().method_6(), gclass100_0.method_1().method_6(), gclass100_0.method_1().method_6());
					string name = gclass100_0.method_1().method_14();
					string info = gclass100_0.method_1().method_14();
					sbyte b3 = gclass100_0.method_1().method_2();
					sbyte isUse = gclass100_0.method_1().method_2();
					sbyte b4 = gclass100_0.method_1().method_2();
					GClass5[] array = null;
					if (b4 != 0)
					{
						array = new GClass5[b4];
						for (int j = 0; j < array.Length; j++)
						{
							int optionTemplateId = gclass100_0.method_1().method_5();
							int param = gclass100_0.method_1().method_7();
							sbyte sbyte_ = gclass100_0.method_1().method_2();
							array[j] = new GClass5(optionTemplateId, param);
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
				GClass166.smethod_2().method_0(gClass, num2, num);
				GClass166.smethod_2().switchToMe();
			}
			else if (b != 1)
			{
				if (b == 2)
				{
					int num3 = gclass100_0.method_1().method_6();
					sbyte level = gclass100_0.method_1().method_2();
					int num4 = 0;
					for (int k = 0; k < GClass166.gclass122_0.method_2(); k++)
					{
						GClass81 gClass3 = (GClass81)GClass166.gclass122_0.method_3(k);
						if (gClass3 != null)
						{
							if (gClass3.int_0 == num3)
								gClass3.method_2(level);
							if (gClass3.sbyte_6 > 0)
								num4++;
						}
					}
					GClass166.smethod_3(num4, GClass166.gclass122_0.method_2());
					if (GClass81.smethod_1(GClass166.gclass122_1, num3) != null)
						GClass81.smethod_1(GClass166.gclass122_1, num3).method_2(level);
				}
				else if (b == 3)
				{
					int id2 = gclass100_0.method_1().method_6();
					sbyte amount2 = gclass100_0.method_1().method_2();
					sbyte max_amount2 = gclass100_0.method_1().method_2();
					if (GClass81.smethod_1(GClass166.gclass122_0, id2) != null)
						GClass81.smethod_1(GClass166.gclass122_0, id2).method_1(amount2, max_amount2);
					if (GClass81.smethod_1(GClass166.gclass122_1, id2) != null)
						GClass81.smethod_1(GClass166.gclass122_1, id2).method_1(amount2, max_amount2);
				}
				else if (b == 4)
				{
					int num5 = gclass100_0.method_1().method_8();
					short short_ = gclass100_0.method_1().method_6();
					GClass124 gClass4 = null;
					gClass4 = ((num5 != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num5) : GClass124.smethod_1());
					if (gClass4 != null)
					{
						gClass4.short_28 = short_;
						gClass4.short_29 = gclass100_0.method_1().method_2();
					}
				}
			}
			else
			{
				int id3 = gclass100_0.method_1().method_6();
				sbyte isUse2 = gclass100_0.method_1().method_2();
				if (GClass81.smethod_1(GClass166.gclass122_0, id3) != null)
					GClass81.smethod_1(GClass166.gclass122_0, id3).method_3(isUse2);
				GClass166.smethod_4();
			}
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_3(GClass100 gclass100_0)
	{
		try
		{
			sbyte b = gclass100_0.method_1().method_2();
			int num = gclass100_0.method_1().method_8();
			GClass124 gClass = null;
			gClass = ((num != GClass124.smethod_1().int_13) ? GClass167.smethod_14(num) : GClass124.smethod_1());
			if (b != 0)
			{
				if (b != 1)
				{
					if (b == 2)
						gClass?.method_141(-1, 0);
				}
				else
				{
					int id = gclass100_0.method_1().method_6();
					gClass?.method_141(0, id);
				}
			}
			else
			{
				int id2 = gclass100_0.method_1().method_6();
				int layer = gclass100_0.method_1().method_2();
				int loop = gclass100_0.method_1().method_2();
				short loopCount = gclass100_0.method_1().method_6();
				sbyte isStand = gclass100_0.method_1().method_2();
				gClass?.method_140(new GClass85(id2, gClass, layer, loop, loopCount, isStand));
			}
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_4(GClass100 gclass100_0, int int_0)
	{
		try
		{
			GClass10 gClass = GClass6.smethod_4(gclass100_0.method_1().method_2());
			if (gClass == null)
				return;
			if (int_0 == 10)
				gClass.method_50(gclass100_0.method_1().method_6(), gclass100_0.method_1().method_6());
			if (int_0 >= 11 && int_0 <= 20)
			{
				sbyte b = gclass100_0.method_1().method_2();
				GClass124[] array = new GClass124[b];
				int[] array2 = new int[b];
				for (int i = 0; i < b; i++)
				{
					int num = gclass100_0.method_1().method_8();
					array[i] = null;
					if (num != GClass124.smethod_1().int_13)
						array[i] = GClass167.smethod_14(num);
					else
						array[i] = GClass124.smethod_1();
					array2[i] = gclass100_0.method_1().method_8();
				}
				gClass.method_39(array, array2, (sbyte)(int_0 - 10), gclass100_0.method_1().method_2());
			}
			if (int_0 == 21)
			{
				gClass.int_55 = gclass100_0.method_1().method_6();
				gClass.int_56 = gclass100_0.method_1().method_6();
				gClass.method_38();
			}
			if (int_0 != 22)
				;
			if (int_0 == 23)
				gClass.method_52();
		}
		catch (Exception)
		{
		}
	}
}
