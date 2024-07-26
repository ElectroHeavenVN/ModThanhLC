using System;
using Assets.src.g;

namespace Assets.src.f
{
	internal class Controller2
	{
		public static void smethod_0(GClass208 gclass208_0)
		{
			try
			{
				sbyte sbyte_ = gclass208_0.sbyte_0;
				if (sbyte_ <= 42)
				{
					switch (sbyte_)
					{
					case sbyte.MinValue:
						smethod_3(gclass208_0);
						return;
					case -127:
						smethod_1(gclass208_0);
						return;
					case -126:
					{
						sbyte b10 = gclass208_0.method_1().method_2();
						GClass50.smethod_8("type quay= " + b10);
						if (b10 == 1)
						{
							gclass208_0.method_1().method_2();
							string num14 = gclass208_0.method_1().method_14();
							string finish = gclass208_0.method_1().method_14();
							GClass144.smethod_8().method_120(num14, finish);
						}
						if (b10 == 0)
							GClass144.smethod_8().method_125(gclass208_0.method_1().method_14());
						return;
					}
					case -125:
					{
						GClass91.smethod_0().bool_0 = false;
						string text = gclass208_0.method_1().method_14();
						GClass50.smethod_8("titile= " + text);
						sbyte b2 = gclass208_0.method_1().method_2();
						GClass138.smethod_2().method_1(b2, text);
						for (int j = 0; j < b2; j++)
						{
							GClass138.smethod_2().gclass191_0[j].string_7 = gclass208_0.method_1().method_14();
							sbyte b3 = gclass208_0.method_1().method_2();
							if (b3 == 0)
								GClass138.smethod_2().gclass191_0[j].method_28(GClass191.int_12);
							if (b3 == 1)
								GClass138.smethod_2().gclass191_0[j].method_28(GClass191.int_11);
							if (b3 == 2)
								GClass138.smethod_2().gclass191_0[j].method_28(GClass191.int_13);
						}
						return;
					}
					case -124:
					{
						sbyte b4 = gclass208_0.method_1().method_2();
						sbyte b5 = gclass208_0.method_1().method_2();
						if (b5 == 0)
						{
							if (b4 == 2)
							{
								int num = gclass208_0.method_1().method_8();
								if (num == GClass78.smethod_1().int_13)
									GClass78.smethod_1().method_130();
								else if (GClass144.smethod_14(num) != null)
								{
									GClass144.smethod_14(num).method_130();
								}
							}
							int num2 = gclass208_0.method_1().method_5();
							int num3 = gclass208_0.method_1().method_8();
							if (num2 == 32)
							{
								if (b4 != 1)
								{
									if (num3 == GClass78.smethod_1().int_13)
										GClass78.smethod_1().method_127();
									else if (GClass144.smethod_14(num3) != null)
									{
										GClass144.smethod_14(num3).method_127();
									}
								}
								else
								{
									int num4 = gclass208_0.method_1().method_8();
									if (num3 == GClass78.smethod_1().int_13)
									{
										GClass78.smethod_1().int_159 = num2;
										GClass144.smethod_14(num4).method_106(GClass78.smethod_1());
									}
									else if (GClass144.smethod_14(num3) == null || num4 == GClass78.smethod_1().int_13)
									{
										if (GClass144.smethod_14(num3) != null && num4 == GClass78.smethod_1().int_13)
										{
											GClass144.smethod_14(num3).int_159 = num2;
											GClass78.smethod_1().method_106(GClass144.smethod_14(num3));
										}
									}
									else
									{
										GClass144.smethod_14(num3).int_159 = num2;
										GClass144.smethod_14(num4).method_106(GClass144.smethod_14(num3));
									}
								}
							}
							if (num2 == 33)
							{
								if (b4 == 1)
								{
									if (num3 == GClass78.smethod_1().int_13)
										GClass78.smethod_1().bool_64 = true;
									else if (GClass144.smethod_14(num3) != null)
									{
										GClass144.smethod_14(num3).bool_64 = true;
									}
								}
								else if (num3 != GClass78.smethod_1().int_13)
								{
									if (GClass144.smethod_14(num3) != null)
										GClass144.smethod_14(num3).method_128();
								}
								else
								{
									GClass78.smethod_1().method_128();
								}
							}
							if (num2 == 39)
							{
								if (b4 != 1)
								{
									if (num3 != GClass78.smethod_1().int_13)
									{
										if (GClass144.smethod_14(num3) != null)
											GClass144.smethod_14(num3).method_132();
									}
									else
										GClass78.smethod_1().method_132();
								}
								else if (num3 != GClass78.smethod_1().int_13)
								{
									if (GClass144.smethod_14(num3) != null)
										GClass144.smethod_14(num3).bool_69 = true;
								}
								else
								{
									GClass78.smethod_1().bool_69 = true;
								}
							}
							if (num2 == 40)
							{
								if (b4 == 1)
								{
									if (num3 == GClass78.smethod_1().int_13)
										GClass78.smethod_1().bool_70 = true;
									else if (GClass144.smethod_14(num3) != null)
									{
										GClass144.smethod_14(num3).bool_70 = true;
									}
								}
								else if (num3 == GClass78.smethod_1().int_13)
								{
									GClass78.smethod_1().method_129();
								}
								else if (GClass144.smethod_14(num3) != null)
								{
									GClass144.smethod_14(num3).method_129();
								}
							}
							if (num2 == 41)
							{
								if (b4 == 1)
								{
									if (num3 != GClass78.smethod_1().int_13)
									{
										if (GClass144.smethod_14(num3) != null)
											GClass144.smethod_14(num3).bool_72 = true;
									}
									else
										GClass78.smethod_1().bool_72 = true;
								}
								else if (num3 != GClass78.smethod_1().int_13)
								{
									if (GClass144.smethod_14(num3) != null)
										GClass144.smethod_14(num3).method_135();
								}
								else
								{
									GClass78.smethod_1().method_135();
								}
							}
							if (num2 == 42)
							{
								if (b4 == 1)
								{
									if (num3 == GClass78.smethod_1().int_13)
										GClass78.smethod_1().bool_73 = true;
								}
								else if (num3 == GClass78.smethod_1().int_13)
								{
									GClass78.smethod_1().bool_73 = false;
								}
							}
						}
						if (b5 != 1)
							return;
						int num5 = gclass208_0.method_1().method_5();
						sbyte mobIndex = gclass208_0.method_1().method_2();
						GClass50.smethod_8("modbHoldID= " + mobIndex + " skillID= " + num5 + "eff ID= " + b4);
						if (num5 == 32)
						{
							if (b4 == 1)
							{
								int num6 = gclass208_0.method_1().method_8();
								if (num6 == GClass78.smethod_1().int_13)
								{
									GClass144.smethod_15(mobIndex).int_5 = num5;
									GClass78.smethod_1().method_107(GClass144.smethod_15(mobIndex));
								}
								else if (GClass144.smethod_14(num6) != null)
								{
									GClass144.smethod_15(mobIndex).int_5 = num5;
									GClass144.smethod_14(num6).method_107(GClass144.smethod_15(mobIndex));
								}
							}
							else
								GClass144.smethod_15(mobIndex).method_24();
						}
						if (num5 == 40)
						{
							if (b4 != 1)
								GClass144.smethod_15(mobIndex).method_25();
							else
								GClass144.smethod_15(mobIndex).bool_21 = true;
						}
						if (num5 == 41)
						{
							if (b4 != 1)
								GClass144.smethod_15(mobIndex).method_26();
							else
								GClass144.smethod_15(mobIndex).bool_22 = true;
						}
						return;
					}
					case -123:
					{
						int charId = gclass208_0.method_1().method_8();
						if (GClass144.smethod_14(charId) != null)
							GClass144.smethod_14(charId).int_162 = gclass208_0.method_1().method_2();
						return;
					}
					case -122:
					{
						GClass79 gClass = GClass144.smethod_13(gclass208_0.method_1().method_6());
						sbyte b = gclass208_0.method_1().method_2();
						gClass.int_189 = new int[b];
						GClass50.smethod_8("N DUA HAU= " + b);
						for (int i = 0; i < b; i++)
						{
							gClass.int_189[i] = gclass208_0.method_1().method_6();
						}
						gClass.method_166(gclass208_0.method_1().method_2(), gclass208_0.method_1().method_8());
						return;
					}
					case -121:
						GClass7.long_3 = GClass203.smethod_18() - GClass7.long_1;
						GClass7.smethod_0().method_37();
						return;
					case -120:
						GClass7.long_2 = GClass203.smethod_18() - GClass7.long_0;
						GClass7.smethod_0().method_36();
						return;
					case -119:
						GClass78.smethod_1().int_3 = gclass208_0.method_1().method_8();
						return;
					case -117:
						GClass144.smethod_8().int_232 = 0;
						GClass144.smethod_8().sbyte_11 = gclass208_0.method_1().method_2();
						if (GClass144.smethod_8().sbyte_11 == 100)
							GClass144.smethod_8().bool_82 = true;
						if (GClass144.smethod_8().sbyte_11 == 101)
							GClass79.bool_82 = true;
						return;
					case -116:
						GClass144.bool_69 = gclass208_0.method_1().method_2() == 1;
						return;
					case -115:
						GClass78.smethod_1().method_10(gclass208_0.method_1().method_14(), gclass208_0.method_1().method_6(), gclass208_0.method_1().method_6(), gclass208_0.method_1().method_6());
						return;
					case -113:
					{
						sbyte[] array = new sbyte[10];
						for (int m = 0; m < 10; m++)
						{
							array[m] = gclass208_0.method_1().method_2();
							GClass50.smethod_8("vlue i= " + array[m]);
						}
						GClass144.smethod_8().method_6(array);
						GClass144.smethod_8().method_5(array);
						GClass144.smethod_8().method_7(array);
						return;
					}
					case -111:
					{
						short num21 = gclass208_0.method_1().method_6();
						Class8.gclass88_0 = new GClass88();
						for (int num22 = 0; num22 < num21; num22++)
						{
							string string_ = gclass208_0.method_1().method_14();
							sbyte sbyte_2 = gclass208_0.method_1().method_2();
							Class8.gclass88_0.method_0(new Class8(string_, sbyte_2));
						}
						Class8.smethod_0();
						Class8.smethod_4();
						return;
					}
					case -110:
					{
						sbyte b8 = gclass208_0.method_1().method_2();
						if (b8 == 1)
						{
							int id = gclass208_0.method_1().method_8();
							sbyte[] array2 = GClass1.smethod_1(id + "");
							if (array2 == null)
								GClass7.smethod_0().method_138(1, -1, null);
							else
								GClass7.smethod_0().method_138(1, id, array2);
						}
						if (b8 == 0)
						{
							int num10 = gclass208_0.method_1().method_8();
							short num11 = gclass208_0.method_1().method_6();
							sbyte[] data = new sbyte[num11];
							gclass208_0.method_1().method_21(ref data, 0, num11);
							GClass1.smethod_0(num10 + "", data);
						}
						return;
					}
					case -106:
					{
						short num12 = gclass208_0.method_1().method_6();
						int num13 = gclass208_0.method_1().method_6();
						if (!GClass19.smethod_0(num12))
						{
							GClass19 o = new GClass19(num12, num13);
							GClass78.gclass88_5.method_0(o);
						}
						else
							GClass19.smethod_3(num12).method_2(num13);
						return;
					}
					case -105:
						GClass132.smethod_2().short_0 = 0;
						GClass132.smethod_2().short_1 = gclass208_0.method_1().method_6();
						GClass132.smethod_2().long_0 = (GClass132.smethod_2().long_1 = GClass203.smethod_18());
						GClass132.smethod_2().sbyte_0 = gclass208_0.method_1().method_2();
						GClass132.smethod_2().switchToMe();
						return;
					case -103:
					{
						sbyte b11 = gclass208_0.method_1().method_2();
						if (b11 != 0)
						{
							if (b11 != 1)
							{
								if (b11 != 2)
									return;
								sbyte b12 = gclass208_0.method_1().method_2();
								int num15 = gclass208_0.method_1().method_6();
								GClass90 gClass2 = new GClass90();
								gClass2.sbyte_0 = b12;
								gClass2.int_0 = num15;
								GClass144.gclass88_11.method_0(gClass2);
								for (int n = 0; n < GClass144.gclass88_11.method_2(); n++)
								{
									GClass90 gClass3 = (GClass90)GClass144.gclass88_11.method_3(n);
									GClass50.smethod_8("i: " + n + "  cflag: " + gClass3.sbyte_0 + "   IDimageFlag: " + gClass3.int_0);
								}
								for (int num16 = 0; num16 < GClass144.gclass88_5.method_2(); num16++)
								{
									GClass78 gClass4 = (GClass78)GClass144.gclass88_5.method_3(num16);
									if (gClass4 != null && gClass4.sbyte_28 == b12)
										gClass4.int_93 = num15;
								}
								if (GClass78.smethod_1().sbyte_28 == b12)
									GClass78.smethod_1().int_93 = num15;
							}
							else
							{
								int num17 = gclass208_0.method_1().method_8();
								sbyte b13 = gclass208_0.method_1().method_2();
								GClass50.smethod_8("---------------actionFlag1:  " + num17 + " : " + b13);
								if (num17 == GClass78.smethod_1().int_13)
									GClass78.smethod_1().sbyte_28 = b13;
								else if (GClass144.smethod_14(num17) != null)
								{
									GClass144.smethod_14(num17).sbyte_28 = b13;
								}
								GClass144.smethod_8().method_116(num17, b13);
							}
							return;
						}
						GClass73.gclass76_0.gclass88_10.method_9();
						sbyte b14 = gclass208_0.method_1().method_2();
						for (int num18 = 0; num18 < b14; num18++)
						{
							GClass128 gClass5 = new GClass128();
							short num19 = gclass208_0.method_1().method_6();
							if (num19 != -1)
							{
								gClass5.gclass117_0 = GClass0.smethod_1(num19);
								sbyte b15 = gclass208_0.method_1().method_2();
								if (b15 != -1)
								{
									gClass5.gclass120_0 = new GClass120[b15];
									for (int num20 = 0; num20 < gClass5.gclass120_0.Length; num20++)
									{
										int optionTemplateId2 = gclass208_0.method_1().method_5();
										int param2 = gclass208_0.method_1().method_7();
										gClass5.gclass120_0[num20] = new GClass120(optionTemplateId2, param2);
									}
								}
							}
							GClass73.gclass76_0.gclass88_10.method_0(gClass5);
						}
						GClass73.gclass76_0.method_22();
						GClass73.gclass76_0.method_50();
						return;
					}
					case -102:
					{
						sbyte b9 = gclass208_0.method_1().method_2();
						if (b9 != 0 && b9 == 1)
						{
							GClass73.gclass133_0.bool_12 = false;
							GClass7.smethod_0().method_38(GClass1.smethod_2("acc"), GClass1.smethod_2("pass"), GClass187.string_2, 0);
							GClass133.bool_13 = true;
						}
						return;
					}
					case -101:
					{
						GClass73.gclass133_0.bool_12 = true;
						GClass73.smethod_4();
						string text2 = gclass208_0.method_1().method_14();
						GClass1.smethod_4("userAo" + GClass134.int_14, text2);
						GClass7.smethod_0().method_34();
						GClass7.smethod_0().method_38(text2, "", GClass187.string_2, 1);
						return;
					}
					case -100:
					{
						GClass130.smethod_5();
						bool flag = false;
						if (GClass73.int_10 > 2 * GClass76.int_55)
							flag = true;
						sbyte b6 = gclass208_0.method_1().method_2();
						GClass50.smethod_8("t Indxe= " + b6);
						GClass73.gclass76_0.int_37[b6] = gclass208_0.method_1().method_2();
						GClass73.gclass76_0.int_38[b6] = gclass208_0.method_1().method_2();
						GClass50.smethod_8("max page= " + GClass73.gclass76_0.int_37[b6] + " curr page= " + GClass73.gclass76_0.int_38[b6]);
						int num7 = gclass208_0.method_1().method_5();
						GClass78.smethod_1().gclass128_3[b6] = new GClass128[num7];
						for (int k = 0; k < num7; k++)
						{
							short num8 = gclass208_0.method_1().method_6();
							if (num8 == -1)
								continue;
							GClass50.smethod_8("template id= " + num8);
							GClass78.smethod_1().gclass128_3[b6][k] = new GClass128();
							GClass78.smethod_1().gclass128_3[b6][k].gclass117_0 = GClass0.smethod_1(num8);
							GClass78.smethod_1().gclass128_3[b6][k].int_27 = gclass208_0.method_1().method_6();
							GClass78.smethod_1().gclass128_3[b6][k].int_34 = gclass208_0.method_1().method_8();
							GClass78.smethod_1().gclass128_3[b6][k].int_36 = gclass208_0.method_1().method_8();
							GClass78.smethod_1().gclass128_3[b6][k].sbyte_32 = gclass208_0.method_1().method_2();
							GClass78.smethod_1().gclass128_3[b6][k].int_30 = gclass208_0.method_1().method_8();
							GClass78.smethod_1().gclass128_3[b6][k].sbyte_33 = gclass208_0.method_1().method_2();
							GClass76.string_26 = mResources.say_wat_do_u_want_to_buy;
							sbyte b7 = gclass208_0.method_1().method_2();
							if (b7 != -1)
							{
								GClass78.smethod_1().gclass128_3[b6][k].gclass120_0 = new GClass120[b7];
								for (int l = 0; l < GClass78.smethod_1().gclass128_3[b6][k].gclass120_0.Length; l++)
								{
									int optionTemplateId = gclass208_0.method_1().method_5();
									int param = gclass208_0.method_1().method_7();
									GClass78.smethod_1().gclass128_3[b6][k].gclass120_0[l] = new GClass120(optionTemplateId, param);
									GClass78.smethod_1().gclass128_3[b6][k].int_43 = GClass73.gclass76_0.method_131(GClass78.smethod_1().gclass128_3[b6][k]);
								}
							}
							if (gclass208_0.method_1().method_2() == 1)
							{
								int headTemp = gclass208_0.method_1().method_6();
								int bodyTemp = gclass208_0.method_1().method_6();
								int legTemp = gclass208_0.method_1().method_6();
								int bagTemp = gclass208_0.method_1().method_6();
								GClass78.smethod_1().gclass128_3[b6][k].method_25(headTemp, bodyTemp, legTemp, bagTemp);
							}
							if (GClass187.int_3 >= 237)
							{
								GClass78.smethod_1().gclass128_3[b6][k].string_3 = gclass208_0.method_1().method_14();
								GClass50.smethod_10("nguoi ki gui  " + GClass78.smethod_1().gclass128_3[b6][k].string_3);
							}
						}
						if (flag)
							GClass73.gclass76_1.method_14();
						GClass73.gclass76_0.method_82();
						GClass76 gclass76_ = GClass73.gclass76_0;
						GClass76 gclass76_2 = GClass73.gclass76_0;
						int num9 = 0;
						gclass76_2.int_7 = 0;
						gclass76_.int_8 = 0;
						return;
					}
					case -89:
						GClass73.bool_0 = gclass208_0.method_1().method_2() == 1;
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
							GClass73.smethod_29();
							GClass133.bool_0 = false;
							GClass78.bool_35 = false;
							sbyte haveName = gclass208_0.method_1().method_2();
							if (GClass73.gclass139_0 == null)
								GClass73.gclass139_0 = new GClass139(haveName);
							GClass73.gclass139_0.method_0();
						}
						return;
					}
					int num23 = gclass208_0.method_1().method_8();
					if (gclass208_0.method_1().method_2() != 1)
					{
						if (num23 == GClass78.smethod_1().int_13)
						{
							GClass78.smethod_1().gclass82_0.method_3();
							GClass78.smethod_1().gclass82_0 = null;
						}
						else
						{
							GClass78 gClass6 = GClass144.smethod_14(num23);
							gClass6.gclass82_0.method_3();
							gClass6.gclass82_0 = null;
						}
						return;
					}
					short short_ = gclass208_0.method_1().method_6();
					sbyte b16 = -1;
					int[] array3 = null;
					short wimg = 0;
					short himg = 0;
					try
					{
						b16 = gclass208_0.method_1().method_2();
						if (b16 > 0)
						{
							sbyte b17 = gclass208_0.method_1().method_2();
							array3 = new int[b17];
							for (int num24 = 0; num24 < b17; num24++)
							{
								array3[num24] = gclass208_0.method_1().method_2();
							}
							wimg = gclass208_0.method_1().method_6();
							himg = gclass208_0.method_1().method_6();
						}
					}
					catch (Exception)
					{
					}
					if (num23 == GClass78.smethod_1().int_13)
					{
						GClass78.smethod_1().gclass82_0 = new GClass82();
						GClass78.smethod_1().gclass82_0.short_0 = short_;
						if (b16 > 0)
							GClass78.smethod_1().gclass82_0.method_0(b16, array3, wimg, himg);
						return;
					}
					GClass78 gClass7 = GClass144.smethod_14(num23);
					gClass7.gclass82_0 = new GClass82();
					gClass7.gclass82_0.short_0 = short_;
					if (b16 > 0)
						gClass7.gclass82_0.method_0(b16, array3, wimg, himg);
					return;
				}
				if (sbyte_ > 93)
				{
					switch (sbyte_)
					{
					case 100:
					{
						sbyte b23 = gclass208_0.method_1().method_2();
						sbyte b24 = gclass208_0.method_1().method_2();
						GClass128 gClass11 = null;
						if (b23 == 0)
							gClass11 = GClass78.smethod_1().gclass128_2[b24];
						if (b23 == 1)
							gClass11 = GClass78.smethod_1().gclass128_0[b24];
						short num31 = gclass208_0.method_1().method_6();
						if (num31 == -1)
							return;
						gClass11.gclass117_0 = GClass0.smethod_1(num31);
						gClass11.int_30 = gclass208_0.method_1().method_8();
						gClass11.string_0 = gclass208_0.method_1().method_14();
						gClass11.string_1 = gclass208_0.method_1().method_14();
						sbyte b25 = gclass208_0.method_1().method_2();
						if (b25 != 0)
						{
							gClass11.gclass120_0 = new GClass120[b25];
							for (int num32 = 0; num32 < gClass11.gclass120_0.Length; num32++)
							{
								int num33 = gclass208_0.method_1().method_5();
								GClass50.smethod_8("id o= " + num33);
								int param3 = gclass208_0.method_1().method_7();
								if (num33 != -1)
									gClass11.gclass120_0[num32] = new GClass120(num33, param3);
							}
						}
						if (gClass11.int_30 <= 0)
							gClass11 = null;
						return;
					}
					case 101:
					{
						GClass50.smethod_8("big boss--------------------------------------------------");
						GClass196 gClass10 = GClass194.smethod_1();
						if (gClass10 == null)
							return;
						sbyte b21 = gclass208_0.method_1().method_2();
						if (b21 == 0 || b21 == 1 || b21 == 2 || b21 == 4 || b21 == 3)
						{
							if (b21 != 3)
							{
								sbyte b22 = gclass208_0.method_1().method_2();
								GClass50.smethod_8("CHUONG nChar= " + b22);
								GClass78[] array8 = new GClass78[b22];
								int[] array9 = new int[b22];
								for (int num29 = 0; num29 < b22; num29++)
								{
									int num30 = gclass208_0.method_1().method_8();
									GClass50.smethod_8("char ID=" + num30);
									array8[num29] = null;
									if (num30 == GClass78.smethod_1().int_13)
										array8[num29] = GClass78.smethod_1();
									else
										array8[num29] = GClass144.smethod_14(num30);
									array9[num29] = gclass208_0.method_1().method_8();
								}
								gClass10.method_43(array8, array9, b21);
							}
							else
							{
								gClass10.int_55 = (gClass10.int_16 = gclass208_0.method_1().method_6());
								gClass10.int_56 = (gClass10.int_17 = gclass208_0.method_1().method_6());
								gClass10.method_42();
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
							gClass10.int_8 = gclass208_0.method_1().method_6();
							gClass10.int_9 = gclass208_0.method_1().method_6();
						}
						if (b21 == 7)
							gClass10.method_43(null, null, b21);
						if (b21 == 8)
						{
							gClass10.int_55 = (gClass10.int_16 = gclass208_0.method_1().method_6());
							gClass10.int_56 = (gClass10.int_17 = gclass208_0.method_1().method_6());
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
						sbyte b18 = gclass208_0.method_1().method_2();
						if (b18 == 0 || b18 == 1 || b18 == 2 || b18 == 6)
						{
							GClass198 gClass8 = GClass194.smethod_2();
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
							sbyte b19 = gclass208_0.method_1().method_2();
							GClass78[] array4 = new GClass78[b19];
							int[] array5 = new int[b19];
							for (int num25 = 0; num25 < b19; num25++)
							{
								int num26 = gclass208_0.method_1().method_8();
								array4[num25] = null;
								if (num26 != GClass78.smethod_1().int_13)
									array4[num25] = GClass144.smethod_14(num26);
								else
									array4[num25] = GClass78.smethod_1();
								array5[num25] = gclass208_0.method_1().method_8();
							}
							gClass8.method_42(array4, array5, b18);
						}
						if (b18 == 3 || b18 == 4 || b18 == 5 || b18 == 7)
						{
							GClass195 gClass9 = GClass194.smethod_3();
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
								sbyte b20 = gclass208_0.method_1().method_2();
								GClass78[] array6 = new GClass78[b20];
								int[] array7 = new int[b20];
								for (int num27 = 0; num27 < b20; num27++)
								{
									int num28 = gclass208_0.method_1().method_8();
									array6[num27] = null;
									if (num28 == GClass78.smethod_1().int_13)
										array6[num27] = GClass78.smethod_1();
									else
										array6[num27] = GClass144.smethod_14(num28);
									array7[num27] = gclass208_0.method_1().method_8();
								}
								gClass9.method_41(array6, array7, b18);
							}
							if (b18 == 5)
								gClass9.method_53(gclass208_0.method_1().method_6());
						}
						if (b18 > 9 && b18 < 30)
							smethod_4(gclass208_0, b18);
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
							loop = gclass208_0.method_1().method_2();
							layer = gclass208_0.method_1().method_2();
							id2 = gclass208_0.method_1().method_5();
							x = gclass208_0.method_1().method_6();
							y = gclass208_0.method_1().method_6();
							loopCount = gclass208_0.method_1().method_6();
						}
						catch (Exception)
						{
						}
						GClass57.smethod_0(new GClass81(id2, x, y, layer, loop, loopCount));
						break;
					}
					case 114:
						try
						{
							gclass208_0.method_1().method_14();
							GClass203.sbyte_1 = gclass208_0.method_1().method_2();
							GClass203.sbyte_2 = gclass208_0.method_1().method_2();
							break;
						}
						catch (Exception)
						{
							break;
						}
					case 121:
						GClass203.string_1 = gclass208_0.method_1().method_14();
						GClass203.string_0 = gclass208_0.method_1().method_14();
						GClass50.smethod_8("SHOW AD public ID= " + GClass203.string_1);
						GClass203.smethod_13();
						break;
					case 122:
					{
						short short_2 = gclass208_0.method_1().method_6();
						GClass50.smethod_8("second login = " + short_2);
						GClass133.short_0 = short_2;
						GClass133.long_1 = (GClass133.long_0 = GClass203.smethod_18());
						GClass73.smethod_29();
						break;
					}
					case 123:
					{
						GClass50.smethod_8("SET POSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSss");
						int num35 = gclass208_0.method_1().method_8();
						short xPos = gclass208_0.method_1().method_6();
						short yPos = gclass208_0.method_1().method_6();
						sbyte b26 = gclass208_0.method_1().method_2();
						GClass78 gClass12 = null;
						if (num35 == GClass78.smethod_1().int_13)
							gClass12 = GClass78.smethod_1();
						else if (GClass144.smethod_14(num35) != null)
						{
							gClass12 = GClass144.smethod_14(num35);
						}
						if (gClass12 != null)
						{
							GClass97.smethod_3((b26 == 0) ? 60 : 173, gClass12, 1);
							gClass12.method_131(xPos, yPos, b26);
						}
						break;
					}
					case 124:
					{
						short id3 = gclass208_0.method_1().method_6();
						string text3 = gclass208_0.method_1().method_14();
						GClass50.smethod_8("noi chuyen = " + text3 + "npc ID= " + id3);
						GClass144.smethod_13(id3)?.method_11(text3);
						break;
					}
					case 125:
					{
						sbyte fusion = gclass208_0.method_1().method_2();
						int num34 = gclass208_0.method_1().method_8();
						if (num34 != GClass78.smethod_1().int_13)
						{
							if (GClass144.smethod_14(num34) != null)
								GClass144.smethod_14(num34).method_134(fusion);
						}
						else
							GClass78.smethod_1().method_134(fusion);
						break;
					}
					case sbyte.MaxValue:
						smethod_2(gclass208_0);
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
						string chatVip = GClass50.smethod_15(gclass208_0.method_1().method_14());
						GClass144.smethod_8().method_121(chatVip);
					}
					break;
				case 48:
					GClass134.int_14 = gclass208_0.method_1().method_2();
					GClass73.gclass73_0.method_9(GClass73.gclass134_0);
					GClass14.smethod_0().close();
					GClass73.smethod_29();
					GClass134.bool_3 = true;
					break;
				case 51:
				{
					Class7 @class = (Class7)GClass144.smethod_14(gclass208_0.method_1().method_8());
					sbyte sbyte_3 = gclass208_0.method_1().method_2();
					short short_3 = gclass208_0.method_1().method_6();
					short short_4 = gclass208_0.method_1().method_6();
					sbyte b28 = gclass208_0.method_1().method_2();
					GClass78[] array10 = new GClass78[b28];
					int[] array11 = new int[b28];
					for (int num38 = 0; num38 < b28; num38++)
					{
						int num39 = gclass208_0.method_1().method_8();
						GClass50.smethod_8("char ID=" + num39);
						array10[num38] = null;
						if (num39 == GClass78.smethod_1().int_13)
							array10[num38] = GClass78.smethod_1();
						else
							array10[num38] = GClass144.smethod_14(num39);
						array11[num38] = gclass208_0.method_1().method_8();
					}
					@class.method_169(sbyte_3, short_3, short_4, array10, array11);
					break;
				}
				case 52:
				{
					sbyte b27 = gclass208_0.method_1().method_2();
					if (b27 == 1)
					{
						int num36 = gclass208_0.method_1().method_8();
						if (num36 != GClass78.smethod_1().int_13)
						{
							GClass78 gClass13 = GClass144.smethod_14(num36);
							if (gClass13 != null)
							{
								gClass13.method_80(true);
								gClass13.int_4 = gclass208_0.method_1().method_6();
								gClass13.int_5 = gclass208_0.method_1().method_6();
							}
						}
						else
						{
							GClass78.smethod_1().method_80(true);
							GClass78.smethod_1().int_4 = gclass208_0.method_1().method_6();
							GClass78.smethod_1().int_5 = gclass208_0.method_1().method_6();
						}
					}
					if (b27 == 0)
					{
						int num37 = gclass208_0.method_1().method_8();
						if (num37 == GClass78.smethod_1().int_13)
							GClass78.smethod_1().method_80(false);
						else
							GClass144.smethod_14(num37)?.method_80(false);
					}
					if (b27 == 2)
					{
						int charId2 = gclass208_0.method_1().method_8();
						int int_ = gclass208_0.method_1().method_8();
						((Class7)GClass144.smethod_14(charId2)).method_166(int_);
					}
					if (b27 == 3)
						GClass144.sbyte_12 = gclass208_0.method_1().method_2();
					break;
				}
				case 49:
				case 50:
					break;
				}
			}
			catch (Exception ex4)
			{
				GClass50.smethod_8("=====> Controller2 " + ex4.StackTrace);
			}
		}

		private static void smethod_1(GClass208 gclass208_0)
		{
			try
			{
				sbyte b = gclass208_0.method_1().method_2();
				if (b == 0)
				{
					sbyte b2 = gclass208_0.method_1().method_2();
					short[] array = new short[b2];
					for (int i = 0; i < b2; i++)
					{
						array[i] = gclass208_0.method_1().method_6();
					}
					sbyte b3 = gclass208_0.method_1().method_2();
					int price = gclass208_0.method_1().method_8();
					short idTicket = gclass208_0.method_1().method_6();
					GClass141.smethod_2().method_0(array, (byte)b3, price, idTicket);
				}
				else if (b == 1)
				{
					sbyte b4 = gclass208_0.method_1().method_2();
					short[] array2 = new short[b4];
					for (int j = 0; j < b4; j++)
					{
						array2[j] = gclass208_0.method_1().method_6();
					}
					GClass141.smethod_2().method_7(array2);
				}
			}
			catch (Exception)
			{
			}
		}

		private static void smethod_2(GClass208 gclass208_0)
		{
			try
			{
				sbyte b = gclass208_0.method_1().method_2();
				if (b == 0)
				{
					GClass135.smethod_2();
					GClass88 gClass = new GClass88("");
					short num = gclass208_0.method_1().method_6();
					int num2 = 0;
					for (int i = 0; i < num; i++)
					{
						GClass202 gClass2 = new GClass202();
						int id = gclass208_0.method_1().method_6();
						int no = i + 1;
						int idIcon = gclass208_0.method_1().method_6();
						sbyte rank = gclass208_0.method_1().method_2();
						sbyte amount = gclass208_0.method_1().method_2();
						sbyte max_amount = gclass208_0.method_1().method_2();
						short templateId = -1;
						GClass78 charInfo = null;
						sbyte b2 = gclass208_0.method_1().method_2();
						if (b2 == 0)
							templateId = gclass208_0.method_1().method_6();
						else
							charInfo = GClass202.smethod_0(gclass208_0.method_1().method_6(), gclass208_0.method_1().method_6(), gclass208_0.method_1().method_6(), gclass208_0.method_1().method_6());
						string name = gclass208_0.method_1().method_14();
						string info = gclass208_0.method_1().method_14();
						sbyte b3 = gclass208_0.method_1().method_2();
						sbyte isUse = gclass208_0.method_1().method_2();
						sbyte b4 = gclass208_0.method_1().method_2();
						GClass120[] array = null;
						if (b4 != 0)
						{
							array = new GClass120[b4];
							for (int j = 0; j < array.Length; j++)
							{
								int optionTemplateId = gclass208_0.method_1().method_5();
								int param = gclass208_0.method_1().method_7();
								sbyte sbyte_ = gclass208_0.method_1().method_2();
								array[j] = new GClass120(optionTemplateId, param);
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
					GClass135.smethod_2().method_0(gClass, num2, num);
					GClass135.smethod_2().switchToMe();
				}
				else if (b == 1)
				{
					int id2 = gclass208_0.method_1().method_6();
					sbyte isUse2 = gclass208_0.method_1().method_2();
					if (GClass202.smethod_1(GClass135.gclass88_0, id2) != null)
						GClass202.smethod_1(GClass135.gclass88_0, id2).method_3(isUse2);
					GClass135.smethod_4();
				}
				else if (b == 2)
				{
					int num3 = gclass208_0.method_1().method_6();
					sbyte level = gclass208_0.method_1().method_2();
					int num4 = 0;
					for (int k = 0; k < GClass135.gclass88_0.method_2(); k++)
					{
						GClass202 gClass3 = (GClass202)GClass135.gclass88_0.method_3(k);
						if (gClass3 != null)
						{
							if (gClass3.int_0 == num3)
								gClass3.method_2(level);
							if (gClass3.sbyte_6 > 0)
								num4++;
						}
					}
					GClass135.smethod_3(num4, GClass135.gclass88_0.method_2());
					if (GClass202.smethod_1(GClass135.gclass88_1, num3) != null)
						GClass202.smethod_1(GClass135.gclass88_1, num3).method_2(level);
				}
				else if (b == 3)
				{
					int id3 = gclass208_0.method_1().method_6();
					sbyte amount2 = gclass208_0.method_1().method_2();
					sbyte max_amount2 = gclass208_0.method_1().method_2();
					if (GClass202.smethod_1(GClass135.gclass88_0, id3) != null)
						GClass202.smethod_1(GClass135.gclass88_0, id3).method_1(amount2, max_amount2);
					if (GClass202.smethod_1(GClass135.gclass88_1, id3) != null)
						GClass202.smethod_1(GClass135.gclass88_1, id3).method_1(amount2, max_amount2);
				}
				else if (b == 4)
				{
					int num5 = gclass208_0.method_1().method_8();
					short short_ = gclass208_0.method_1().method_6();
					GClass78 gClass4 = null;
					gClass4 = ((num5 != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num5) : GClass78.smethod_1());
					if (gClass4 != null)
					{
						gClass4.short_28 = short_;
						gClass4.short_29 = gclass208_0.method_1().method_2();
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private static void smethod_3(GClass208 gclass208_0)
		{
			try
			{
				sbyte b = gclass208_0.method_1().method_2();
				int num = gclass208_0.method_1().method_8();
				GClass78 gClass = null;
				gClass = ((num != GClass78.smethod_1().int_13) ? GClass144.smethod_14(num) : GClass78.smethod_1());
				if (b != 0)
				{
					if (b == 1)
					{
						int id = gclass208_0.method_1().method_6();
						gClass?.method_141(0, id);
					}
					else if (b == 2)
					{
						gClass?.method_141(-1, 0);
					}
				}
				else
				{
					int id2 = gclass208_0.method_1().method_6();
					int layer = gclass208_0.method_1().method_2();
					int loop = gclass208_0.method_1().method_2();
					short loopCount = gclass208_0.method_1().method_6();
					sbyte isStand = gclass208_0.method_1().method_2();
					gClass?.method_140(new GClass81(id2, gClass, layer, loop, loopCount, isStand));
				}
			}
			catch (Exception)
			{
			}
		}

		private static void smethod_4(GClass208 gclass208_0, int int_0)
		{
			try
			{
				GClass197 gClass = GClass194.smethod_4(gclass208_0.method_1().method_2());
				if (gClass == null)
					return;
				if (int_0 == 10)
					gClass.method_50(gclass208_0.method_1().method_6(), gclass208_0.method_1().method_6());
				if (int_0 >= 11 && int_0 <= 20)
				{
					sbyte b = gclass208_0.method_1().method_2();
					GClass78[] array = new GClass78[b];
					int[] array2 = new int[b];
					for (int i = 0; i < b; i++)
					{
						int num = gclass208_0.method_1().method_8();
						array[i] = null;
						if (num == GClass78.smethod_1().int_13)
							array[i] = GClass78.smethod_1();
						else
							array[i] = GClass144.smethod_14(num);
						array2[i] = gclass208_0.method_1().method_8();
					}
					gClass.method_39(array, array2, (sbyte)(int_0 - 10), gclass208_0.method_1().method_2());
				}
				if (int_0 == 21)
				{
					gClass.int_55 = gclass208_0.method_1().method_6();
					gClass.int_56 = gclass208_0.method_1().method_6();
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
}
