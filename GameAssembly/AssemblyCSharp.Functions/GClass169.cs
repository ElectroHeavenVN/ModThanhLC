using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace AssemblyCSharp.Functions
{
	public class GClass169
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class20
		{
			public static readonly Class20 class20_0 = new Class20();

			public static ThreadStart threadStart_0;

			public static ThreadStart threadStart_1;

			public static ThreadStart threadStart_2;

			public static ThreadStart threadStart_3;

			public static ThreadStart threadStart_4;

			public static ThreadStart threadStart_5;

			public static ThreadStart threadStart_6;

			public static ThreadStart threadStart_7;

			public static ThreadStart threadStart_8;

			public static ThreadStart threadStart_9;

			public static ThreadStart threadStart_10;

			public static ThreadStart threadStart_11;

			public static ThreadStart threadStart_12;

			public static ThreadStart threadStart_13;

			internal void method_0()
			{
				GClass159.smethod_0().method_46();
			}

			internal void method_1()
			{
				GClass159.smethod_0().method_48();
			}

			internal void method_2()
			{
				GClass160.smethod_0().method_17(1, 4);
			}

			internal void method_3()
			{
				GClass160.smethod_0().method_17(2, 4);
			}

			internal void method_4()
			{
				GClass159.smethod_0().method_46();
			}

			internal void method_5()
			{
				GClass160.smethod_0().method_17(1, 6);
			}

			internal void method_6()
			{
				GClass160.smethod_0().method_17(2, 6);
			}

			internal void method_7()
			{
				GClass159.smethod_0().method_46();
			}

			internal void method_8()
			{
				GClass159.smethod_0().method_48();
			}

			internal void method_9()
			{
				GClass160.smethod_0().method_17(1, 4);
			}

			internal void method_10()
			{
				GClass160.smethod_0().method_17(2, 4);
			}

			internal void method_11()
			{
				GClass159.smethod_0().method_46();
			}

			internal void method_12()
			{
				GClass160.smethod_0().method_17(1, 6);
			}

			internal void method_13()
			{
				GClass160.smethod_0().method_17(2, 6);
			}
		}

		public bool bool_0;

		private static GClass169 gclass169_0;

		public static string string_0 = "Data/QLTK/HotKey.ini";

		public string string_1 = "Data/QLTK/NormalKey.ini";

		public string string_2 = "Data/QLTK/NRSDKey.ini";

		public static bool bool_1;

		public static List<string> list_0 = new List<string>();

		public static List<string> list_1 = new List<string>();

		public static List<string> list_2 = new List<string>();

		public static GClass169 smethod_0()
		{
			return (gclass169_0 != null) ? gclass169_0 : (gclass169_0 = new GClass169());
		}

		public static int smethod_1()
		{
			if (!GClass153.smethod_0().method_6())
				return 0;
			return 1;
		}

		public static void smethod_2()
		{
			if (File.Exists(smethod_0().string_1))
			{
				string[] array = File.ReadAllLines(smethod_0().string_1);
				for (int i = 0; i < array.Length; i++)
				{
					list_1.Add(array[i]);
				}
			}
			if (File.Exists(smethod_0().string_2))
			{
				string[] array2 = File.ReadAllLines(smethod_0().string_2);
				for (int j = 0; j < array2.Length; j++)
				{
					list_2.Add(array2[j]);
				}
			}
		}

		public static bool smethod_3(int AsciiKey)
		{
			int num = smethod_1();
			if (num == 0)
			{
				if (AsciiKey != 47)
				{
					if (AsciiKey != 113)
					{
						for (int i = 0; i < list_1.Count; i++)
						{
							if (!list_1[i].StartsWith(((char)AsciiKey).ToString()))
								continue;
							switch (int.Parse(list_1[i].Split('|')[1].Split(']')[0].Replace("[", "")))
							{
							case 0:
								GClass164.smethod_0().bool_0 = !GClass164.smethod_0().bool_0;
								GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto Attack: " + GClass154.smethod_0().method_6(GClass164.smethod_0().bool_0)) : ("Tự động đánh: " + GClass154.smethod_0().method_6(GClass164.smethod_0().bool_0)), 0);
								break;
							case 1:
								GClass7.smethod_0().method_78("/oinf");
								break;
							case 2:
								if (GClass148.smethod_0().bool_0)
								{
									Class21.smethod_0().method_9();
									GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
								}
								else
									Class21.smethod_0().method_3();
								break;
							case 3:
							{
								GClass88 gClass4 = new GClass88();
								gClass4.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nTrain quái" : "Function\nTrain mob", GClass166.smethod_0(), 10000, null));
								gClass4.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\n Săn Boss" : "Function\nBoss", GClass158.smethod_0(), 10001, null));
								gClass4.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nUp Bí kíp\nYardart" : "Function\nSupport\nYardart", GClass159.smethod_0(), 10002, null));
								gClass4.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nHỗ trợ\nUp Đệ tử" : "Function\nSupport\nDisciple", GClass168.smethod_0(), 10003, null));
								gClass4.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nSkill" : "Chức năng\nSkill", GClass164.smethod_0(), 10004, null));
								gClass4.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nHỗ trợ\nPK/NRSĐ" : "Function\nSupport\nPK/BSDB", GClass159.smethod_0(), 10005, null));
								gClass4.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nMap" : "Chức năng\nMap", GClass157.smethod_0(), 10006, null));
								gClass4.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nkhác..." : "Another\nFunction...", GClass159.smethod_0(), 10007, null));
								GClass73.gclass145_0.method_2(gClass4, 0);
								break;
							}
							case 4:
								GClass73.gclass76_1 = new GClass76();
								GClass73.gclass76_1.method_50();
								GClass73.gclass76_0.method_41();
								GClass73.gclass76_0.method_50();
								break;
							case 5:
								GClass7.smethod_0().method_13(0, -1);
								break;
							case 6:
								GClass7.smethod_0().method_20(0, 1, -1, 193);
								GClass7.smethod_0().method_20(0, 1, -1, 194);
								break;
							case 7:
								GClass109.smethod_1().method_35();
								GClass78.smethod_1().gclass29_0 = null;
								GClass73.smethod_49();
								GClass73.gclass76_1 = new GClass76();
								GClass73.gclass76_1.method_50();
								GClass73.gclass76_0.method_34();
								GClass73.gclass76_0.method_50();
								break;
							case 8:
								GClass157.smethod_0().method_18(0);
								break;
							case 9:
								if (GClass20.int_37 != 135 && GClass20.int_37 != 138 && GClass20.int_37 != 136)
									GClass157.smethod_0().method_18(2);
								else if (GClass20.int_37 != 135)
								{
									if (GClass20.int_37 == 138)
										Class21.smethod_0().method_24(360, 336);
									else if (GClass20.int_37 == 136)
									{
										Class21.smethod_0().method_24(720, 576);
									}
								}
								else
								{
									Class21.smethod_0().method_24(600, 600);
								}
								break;
							case 10:
								GClass157.smethod_0().method_18(1);
								break;
							case 11:
								GClass158.smethod_0().method_8();
								break;
							case 12:
								if (!GClass159.smethod_0().method_50())
									new Thread((ThreadStart)delegate
									{
										GClass159.smethod_0().method_48();
									}).Start();
								else
									new Thread((ThreadStart)delegate
									{
										GClass159.smethod_0().method_46();
									}).Start();
								break;
							case 13:
							{
								GClass78 gClass5 = GClass78.smethod_1();
								if (gClass5.gclass78_0 != null)
								{
									gClass5.int_4 = gClass5.gclass78_0.int_4;
									gClass5.int_5 = gClass5.gclass78_0.int_5;
									GClass7.smethod_0().method_44();
									gClass5.int_4 = gClass5.gclass78_0.int_4;
									gClass5.int_5 = gClass5.gclass78_0.int_5 + 3;
									GClass7.smethod_0().method_44();
									gClass5.int_4 = gClass5.gclass78_0.int_4;
									gClass5.int_5 = gClass5.gclass78_0.int_5;
									GClass7.smethod_0().method_44();
								}
								else if (gClass5.gclass194_0 != null)
								{
									gClass5.int_4 = gClass5.gclass194_0.int_8;
									gClass5.int_5 = gClass5.gclass194_0.int_9 + 1;
									GClass7.smethod_0().method_44();
									gClass5.int_4 = gClass5.gclass194_0.int_8;
									gClass5.int_5 = gClass5.gclass194_0.int_9;
									GClass7.smethod_0().method_44();
									gClass5.int_4 = gClass5.gclass194_0.int_8;
									gClass5.int_5 = gClass5.gclass194_0.int_9 + 1;
									GClass7.smethod_0().method_44();
								}
								else if (gClass5.gclass79_0 != null)
								{
									gClass5.int_4 = gClass5.gclass79_0.int_4;
									gClass5.int_5 = gClass5.gclass79_0.int_5 - 3;
									GClass7.smethod_0().method_44();
									gClass5.int_4 = gClass5.gclass79_0.int_4;
									gClass5.int_5 = gClass5.gclass79_0.int_5;
									GClass7.smethod_0().method_44();
									gClass5.int_4 = gClass5.gclass79_0.int_4;
									gClass5.int_5 = gClass5.gclass79_0.int_5 - 3;
									GClass7.smethod_0().method_44();
								}
								break;
							}
							case 14:
								GClass153.smethod_0().method_18();
								break;
							case 15:
							{
								for (int l = 0; l < GClass78.smethod_1().gclass128_0.Length; l++)
								{
									GClass128 gClass3 = GClass78.smethod_1().gclass128_0[l];
									if (gClass3 != null && (gClass3.gclass117_0.short_0 == 454 || gClass3.gclass117_0.short_0 == 921))
										GClass7.smethod_0().method_20(0, 1, -1, gClass3.gclass117_0.short_0);
								}
								break;
							}
							case 16:
								new Thread((ThreadStart)delegate
								{
									GClass160.smethod_0().method_17(1, 4);
								}).Start();
								break;
							case 17:
								new Thread((ThreadStart)delegate
								{
									GClass160.smethod_0().method_17(2, 4);
								}).Start();
								break;
							case 18:
								GClass7.smethod_0().method_78("/unikey");
								break;
							case 19:
								GClass7.smethod_0().method_78("/dsq");
								break;
							case 20:
								GClass159.smethod_0().method_21(-1);
								break;
							case 21:
								GClass164.smethod_0().method_5();
								break;
							case 22:
								if (!GClass78.smethod_1().bool_62 && GClass78.smethod_1().gclass163_0.bool_0 && GClass153.smethod_0().method_6())
								{
									GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto get x7 HP: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_1)) : ("Tự động phù x7 HP: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_1)), 0);
									new Thread(GClass153.smethod_0().method_13).Start();
								}
								break;
							case 23:
								if (!GClass151.bool_3)
								{
									GClass149.smethod_1((GClass151.int_0 != 0) ? "Contact admin to unlock this function!" : "Liên hệ admin để mở khóa chức năng này!", 1);
									break;
								}
								GClass153.smethod_0().bool_4 = !GClass153.smethod_0().bool_4;
								GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động cắm vệ tinh HP: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_4)) : ("Auto use Sattelite HP: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_4)), 0);
								break;
							case 24:
								GClass7.smethod_0().method_78("/anhat");
								break;
							case 25:
							{
								for (int k = 0; k < GClass78.smethod_1().gclass128_0.Length; k++)
								{
									GClass128 gClass2 = GClass78.smethod_1().gclass128_0[k];
									if (gClass2 != null && gClass2.gclass117_0.short_0 == 521)
										GClass7.smethod_0().method_20(0, 1, -1, gClass2.gclass117_0.short_0);
								}
								break;
							}
							case 26:
								if (GClass153.smethod_0().method_6())
								{
									GClass166.smethod_0().bool_5 = false;
									GClass7.smethod_0().method_42(GClass20.int_39, -1);
								}
								else
									GClass7.smethod_0().method_6(0, GClass78.smethod_1().gclass78_0.int_13, -1, -1);
								break;
							case 27:
								GClass7.smethod_0().method_78("/rcvs");
								break;
							case 28:
								GClass7.smethod_0().method_78("/optm");
								break;
							case 29:
								GClass7.smethod_0().method_78("/hide");
								break;
							case 30:
								if (GClass157.smethod_0().int_0 == -1)
									GClass7.smethod_0().method_78($"/kz{((GClass20.int_39 == 0) ? GClass20.int_39 : (GClass20.int_39 - 1))}");
								else if (GClass157.smethod_0().int_0 <= 0)
								{
									GClass149.smethod_1((GClass151.int_0 != 0) ? "Minimum zone is [0]" : "Khu bé nhất là [0]", 0);
								}
								else
								{
									GClass7.smethod_0().method_78($"/kz{GClass20.int_39 - 1}");
								}
								break;
							case 31:
								if (GClass157.smethod_0().int_0 == -1)
									GClass7.smethod_0().method_78($"/kz{((GClass20.int_39 != 0) ? (GClass20.int_39 + 1) : GClass20.int_39)}");
								else if (GClass157.smethod_0().int_0 < GClass144.smethod_8().int_61.Length - 1)
								{
									GClass7.smethod_0().method_78($"/kz{GClass20.int_39 + 1}");
								}
								else
								{
									GClass149.smethod_1((GClass151.int_0 == 0) ? $"Khu lớn nhất là [{GClass144.smethod_8().int_61.Length - 1}]" : $"Maximum zone is [{GClass144.smethod_8().int_61.Length - 1}]", 0);
								}
								break;
							case 32:
								GClass7.smethod_0().method_78("/dsnv");
								break;
							case 33:
								GClass7.smethod_0().method_78("/tbb");
								break;
							case 34:
								new Thread((ThreadStart)delegate
								{
									GClass159.smethod_0().method_46();
								}).Start();
								break;
							case 35:
								GClass7.smethod_0().method_78("/abt50");
								break;
							case 36:
								GClass7.smethod_0().method_78("/cobj");
								break;
							case 37:
								GClass7.smethod_0().method_78("/ahs");
								break;
							case 38:
								GClass7.smethod_0().method_78("/xd");
								break;
							case 39:
								GClass7.smethod_0().method_78("/td");
								break;
							case 40:
								GClass7.smethod_0().method_78("/cd");
								break;
							case 41:
								GClass7.smethod_0().method_78("/gohome");
								break;
							case 42:
								new Thread((ThreadStart)delegate
								{
									GClass160.smethod_0().method_17(1, 6);
								}).Start();
								break;
							case 43:
								new Thread((ThreadStart)delegate
								{
									GClass160.smethod_0().method_17(2, 6);
								}).Start();
								break;
							case 44:
								GClass7.smethod_0().method_78("/dsn");
								break;
							case 45:
								GClass7.smethod_0().method_78("/dsb");
								break;
							case 46:
								GClass7.smethod_0().method_78("/addchar");
								break;
							case 47:
								GClass7.smethod_0().method_78("/addclan");
								break;
							case 48:
								GClass7.smethod_0().method_78("/addboss");
								break;
							case 49:
								GClass7.smethod_0().method_78("/vqtd");
								break;
							case 50:
								GClass171.smethod_0().method_22();
								break;
							case 51:
								GClass7.smethod_0().method_78("/ats9");
								break;
							case 52:
								GClass166.smethod_0().bool_5 = false;
								GClass7.smethod_0().method_42(GClass20.int_39, -1);
								break;
							case 53:
							{
								for (int j = 0; j < GClass144.gclass63_0.Length; j++)
								{
									GClass63 gClass = GClass144.gclass63_0[j];
									if (gClass != null && gClass.gclass47_0.sbyte_0 == 19)
									{
										if (!GClass164.smethod_0().gclass88_0.method_1(gClass))
										{
											GClass164.smethod_0().gclass88_0.method_0(gClass);
											GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? ("Đã thêm skill " + gClass.gclass47_0.string_0) : ("Added skill " + gClass.gclass47_0.string_0), 0);
										}
										else
										{
											GClass164.smethod_0().gclass88_0.method_8(gClass);
											GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? ("Đã xóa skill " + gClass.gclass47_0.string_0) : ("Deleted skill " + gClass.gclass47_0.string_0), 0);
										}
									}
								}
								break;
							}
							case 54:
								new Thread(GClass153.smethod_0().method_0).Start();
								break;
							case 55:
								GClass7.smethod_0().method_78("/autowhis");
								break;
							}
						}
					}
					else
					{
						if (!GClass150.smethod_0().bool_0)
						{
							GClass150.smethod_0().method_0(GClass172.int_0);
							GClass150.smethod_0().bool_0 = true;
						}
						else
						{
							GClass150.smethod_0().method_2(new vMessage
							{
								cmd = 3,
								data = Encoding.ASCII.GetBytes(GClass150.int_0.ToString())
							});
							GClass150.smethod_0().bool_2 = false;
							GClass150.smethod_0().bool_0 = false;
						}
						GClass149.smethod_1((GClass151.int_0 == 0) ? ("Liên kết với QLTK: " + GClass154.smethod_0().method_6(GClass150.smethod_0().bool_0)) : ("Connect to game mannager: " + GClass154.smethod_0().method_6(GClass150.smethod_0().bool_0)), 0);
					}
				}
				else
					GClass91.smethod_0().method_3(47, GClass144.smethod_8(), "");
			}
			else
			{
				if (num != 1)
					return false;
				if (AsciiKey != 47)
				{
					if (AsciiKey != 113)
					{
						for (int m = 0; m < list_1.Count; m++)
						{
							if (!list_1[m].StartsWith(((char)AsciiKey).ToString()))
								continue;
							switch (int.Parse(list_1[m].Split('|')[1].Split(']')[0].Replace("[", "")))
							{
							case 0:
								GClass164.smethod_0().bool_0 = !GClass164.smethod_0().bool_0;
								GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động đánh: " + GClass154.smethod_0().method_6(GClass164.smethod_0().bool_0)) : ("Auto Attack: " + GClass154.smethod_0().method_6(GClass164.smethod_0().bool_0)), 0);
								break;
							case 1:
								GClass7.smethod_0().method_78("/oinf");
								break;
							case 2:
								if (!GClass148.smethod_0().bool_0)
								{
									Class21.smethod_0().method_3();
									break;
								}
								Class21.smethod_0().method_9();
								GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
								break;
							case 3:
							{
								GClass88 gClass7 = new GClass88();
								gClass7.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nTrain mob" : "Chức năng\nTrain quái", GClass166.smethod_0(), 10000, null));
								gClass7.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nBoss" : "Chức năng\n Săn Boss", GClass158.smethod_0(), 10001, null));
								gClass7.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nUp Bí kíp\nYardart" : "Function\nSupport\nYardart", GClass159.smethod_0(), 10002, null));
								gClass7.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nHỗ trợ\nUp Đệ tử" : "Function\nSupport\nDisciple", GClass168.smethod_0(), 10003, null));
								gClass7.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nSkill" : "Chức năng\nSkill", GClass164.smethod_0(), 10004, null));
								gClass7.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nSupport\nPK/BSDB" : "Chức năng\nHỗ trợ\nPK/NRSĐ", GClass159.smethod_0(), 10005, null));
								gClass7.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nMap" : "Function\nMap", GClass157.smethod_0(), 10006, null));
								gClass7.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nkhác..." : "Another\nFunction...", GClass159.smethod_0(), 10007, null));
								GClass73.gclass145_0.method_2(gClass7, 0);
								break;
							}
							case 4:
								GClass73.gclass76_1 = new GClass76();
								GClass73.gclass76_1.method_50();
								GClass73.gclass76_0.method_41();
								GClass73.gclass76_0.method_50();
								break;
							case 5:
								GClass7.smethod_0().method_13(0, -1);
								break;
							case 6:
								GClass7.smethod_0().method_20(0, 1, -1, 193);
								GClass7.smethod_0().method_20(0, 1, -1, 194);
								break;
							case 7:
								GClass109.smethod_1().method_35();
								GClass78.smethod_1().gclass29_0 = null;
								GClass73.smethod_49();
								GClass73.gclass76_1 = new GClass76();
								GClass73.gclass76_1.method_50();
								GClass73.gclass76_0.method_34();
								GClass73.gclass76_0.method_50();
								break;
							case 8:
								GClass157.smethod_0().method_18(0);
								break;
							case 9:
								if (GClass20.int_37 == 135 || GClass20.int_37 == 138 || GClass20.int_37 == 136)
								{
									if (GClass20.int_37 == 135)
										Class21.smethod_0().method_24(600, 600);
									else if (GClass20.int_37 != 138)
									{
										if (GClass20.int_37 == 136)
											Class21.smethod_0().method_24(720, 576);
									}
									else
									{
										Class21.smethod_0().method_24(360, 336);
									}
								}
								else
									GClass157.smethod_0().method_18(2);
								break;
							case 10:
								GClass157.smethod_0().method_18(1);
								break;
							case 11:
								GClass158.smethod_0().method_8();
								break;
							case 12:
								if (GClass159.smethod_0().method_50())
									new Thread((ThreadStart)delegate
									{
										GClass159.smethod_0().method_46();
									}).Start();
								else
									new Thread((ThreadStart)delegate
									{
										GClass159.smethod_0().method_48();
									}).Start();
								break;
							case 13:
							{
								GClass78 gClass10 = GClass78.smethod_1();
								if (gClass10.gclass78_0 == null)
								{
									if (gClass10.gclass194_0 != null)
									{
										gClass10.int_4 = gClass10.gclass194_0.int_8;
										gClass10.int_5 = gClass10.gclass194_0.int_9 + 1;
										GClass7.smethod_0().method_44();
										gClass10.int_4 = gClass10.gclass194_0.int_8;
										gClass10.int_5 = gClass10.gclass194_0.int_9;
										GClass7.smethod_0().method_44();
										gClass10.int_4 = gClass10.gclass194_0.int_8;
										gClass10.int_5 = gClass10.gclass194_0.int_9 + 1;
										GClass7.smethod_0().method_44();
									}
									else if (gClass10.gclass79_0 != null)
									{
										gClass10.int_4 = gClass10.gclass79_0.int_4;
										gClass10.int_5 = gClass10.gclass79_0.int_5 - 3;
										GClass7.smethod_0().method_44();
										gClass10.int_4 = gClass10.gclass79_0.int_4;
										gClass10.int_5 = gClass10.gclass79_0.int_5;
										GClass7.smethod_0().method_44();
										gClass10.int_4 = gClass10.gclass79_0.int_4;
										gClass10.int_5 = gClass10.gclass79_0.int_5 - 3;
										GClass7.smethod_0().method_44();
									}
								}
								else
								{
									gClass10.int_4 = gClass10.gclass78_0.int_4;
									gClass10.int_5 = gClass10.gclass78_0.int_5;
									GClass7.smethod_0().method_44();
									gClass10.int_4 = gClass10.gclass78_0.int_4;
									gClass10.int_5 = gClass10.gclass78_0.int_5 + 3;
									GClass7.smethod_0().method_44();
									gClass10.int_4 = gClass10.gclass78_0.int_4;
									gClass10.int_5 = gClass10.gclass78_0.int_5;
									GClass7.smethod_0().method_44();
								}
								break;
							}
							case 14:
								GClass153.smethod_0().method_18();
								break;
							case 15:
							{
								for (int num3 = 0; num3 < GClass78.smethod_1().gclass128_0.Length; num3++)
								{
									GClass128 gClass9 = GClass78.smethod_1().gclass128_0[num3];
									if (gClass9 != null && (gClass9.gclass117_0.short_0 == 454 || gClass9.gclass117_0.short_0 == 921))
										GClass7.smethod_0().method_20(0, 1, -1, gClass9.gclass117_0.short_0);
								}
								break;
							}
							case 16:
								new Thread((ThreadStart)delegate
								{
									GClass160.smethod_0().method_17(1, 4);
								}).Start();
								break;
							case 17:
								new Thread((ThreadStart)delegate
								{
									GClass160.smethod_0().method_17(2, 4);
								}).Start();
								break;
							case 18:
								GClass7.smethod_0().method_78("/unikey");
								break;
							case 19:
								GClass7.smethod_0().method_78("/dsq");
								break;
							case 20:
								GClass159.smethod_0().method_21(-1);
								break;
							case 21:
								GClass164.smethod_0().method_5();
								break;
							case 22:
								if (!GClass78.smethod_1().bool_62 && GClass78.smethod_1().gclass163_0.bool_0 && GClass153.smethod_0().method_6())
								{
									GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto get x7 HP: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_1)) : ("Tự động phù x7 HP: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_1)), 0);
									new Thread(GClass153.smethod_0().method_13).Start();
								}
								break;
							case 23:
								if (GClass151.bool_3)
								{
									GClass153.smethod_0().bool_4 = !GClass153.smethod_0().bool_4;
									GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động cắm vệ tinh HP: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_4)) : ("Auto use Sattelite HP: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_4)), 0);
								}
								else
									GClass149.smethod_1((GClass151.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
								break;
							case 24:
								GClass7.smethod_0().method_78("/anhat");
								break;
							case 25:
							{
								for (int num2 = 0; num2 < GClass78.smethod_1().gclass128_0.Length; num2++)
								{
									GClass128 gClass8 = GClass78.smethod_1().gclass128_0[num2];
									if (gClass8 != null && gClass8.gclass117_0.short_0 == 521)
										GClass7.smethod_0().method_20(0, 1, -1, gClass8.gclass117_0.short_0);
								}
								break;
							}
							case 26:
								if (!GClass153.smethod_0().method_6())
								{
									GClass7.smethod_0().method_6(0, GClass78.smethod_1().gclass78_0.int_13, -1, -1);
									break;
								}
								GClass166.smethod_0().bool_5 = false;
								GClass7.smethod_0().method_42(GClass20.int_39, -1);
								break;
							case 27:
								GClass7.smethod_0().method_78("/rcvs");
								break;
							case 28:
								GClass7.smethod_0().method_78("/optm");
								break;
							case 29:
								GClass7.smethod_0().method_78("/hide");
								break;
							case 30:
								if (GClass157.smethod_0().int_0 != -1)
								{
									if (GClass157.smethod_0().int_0 > 0)
										GClass7.smethod_0().method_78($"/kz{GClass20.int_39 - 1}");
									else
										GClass149.smethod_1((GClass151.int_0 == 0) ? "Khu bé nhất là [0]" : "Minimum zone is [0]", 0);
								}
								else
									GClass7.smethod_0().method_78($"/kz{((GClass20.int_39 == 0) ? GClass20.int_39 : (GClass20.int_39 - 1))}");
								break;
							case 31:
								if (GClass157.smethod_0().int_0 == -1)
									GClass7.smethod_0().method_78($"/kz{((GClass20.int_39 == 0) ? GClass20.int_39 : (GClass20.int_39 + 1))}");
								else if (GClass157.smethod_0().int_0 < GClass144.smethod_8().int_61.Length - 1)
								{
									GClass7.smethod_0().method_78($"/kz{GClass20.int_39 + 1}");
								}
								else
								{
									GClass149.smethod_1((GClass151.int_0 != 0) ? $"Maximum zone is [{GClass144.smethod_8().int_61.Length - 1}]" : $"Khu lớn nhất là [{GClass144.smethod_8().int_61.Length - 1}]", 0);
								}
								break;
							case 32:
								GClass7.smethod_0().method_78("/dsnv");
								break;
							case 33:
								GClass7.smethod_0().method_78("/tbb");
								break;
							case 34:
								new Thread((ThreadStart)delegate
								{
									GClass159.smethod_0().method_46();
								}).Start();
								break;
							case 35:
								GClass7.smethod_0().method_78("/abt50");
								break;
							case 36:
								GClass7.smethod_0().method_78("/cobj");
								break;
							case 37:
								GClass7.smethod_0().method_78("/ahs");
								break;
							case 38:
								GClass7.smethod_0().method_78("/xd");
								break;
							case 39:
								GClass7.smethod_0().method_78("/td");
								break;
							case 40:
								GClass7.smethod_0().method_78("/cd");
								break;
							case 41:
								GClass7.smethod_0().method_78("/gohome");
								break;
							case 42:
								new Thread((ThreadStart)delegate
								{
									GClass160.smethod_0().method_17(1, 6);
								}).Start();
								break;
							case 43:
								new Thread((ThreadStart)delegate
								{
									GClass160.smethod_0().method_17(2, 6);
								}).Start();
								break;
							case 44:
								GClass7.smethod_0().method_78("/dsn");
								break;
							case 45:
								GClass7.smethod_0().method_78("/dsb");
								break;
							case 46:
								GClass7.smethod_0().method_78("/addchar");
								break;
							case 47:
								GClass7.smethod_0().method_78("/addclan");
								break;
							case 48:
								GClass7.smethod_0().method_78("/addboss");
								break;
							case 49:
								GClass7.smethod_0().method_78("/vqtd");
								break;
							case 50:
								GClass171.smethod_0().method_22();
								break;
							case 51:
								GClass7.smethod_0().method_78("/ats9");
								break;
							case 52:
								GClass166.smethod_0().bool_5 = false;
								GClass7.smethod_0().method_42(GClass20.int_39, -1);
								break;
							case 53:
							{
								for (int n = 0; n < GClass144.gclass63_0.Length; n++)
								{
									GClass63 gClass6 = GClass144.gclass63_0[n];
									if (gClass6 != null && gClass6.gclass47_0.sbyte_0 == 19)
									{
										if (!GClass164.smethod_0().gclass88_0.method_1(gClass6))
										{
											GClass164.smethod_0().gclass88_0.method_0(gClass6);
											GClass144.gclass52_0.method_7((GClass151.int_0 != 0) ? ("Added skill " + gClass6.gclass47_0.string_0) : ("Đã thêm skill " + gClass6.gclass47_0.string_0), 0);
										}
										else
										{
											GClass164.smethod_0().gclass88_0.method_8(gClass6);
											GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? ("Đã xóa skill " + gClass6.gclass47_0.string_0) : ("Deleted skill " + gClass6.gclass47_0.string_0), 0);
										}
									}
								}
								break;
							}
							case 54:
								new Thread(GClass153.smethod_0().method_0).Start();
								break;
							case 55:
								GClass7.smethod_0().method_78("/autowhis");
								break;
							}
						}
					}
					else
					{
						if (GClass150.smethod_0().bool_0)
						{
							GClass150.smethod_0().method_2(new vMessage
							{
								cmd = 3,
								data = Encoding.ASCII.GetBytes(GClass150.int_0.ToString())
							});
							GClass150.smethod_0().bool_2 = false;
							GClass150.smethod_0().bool_0 = false;
						}
						else
						{
							GClass150.smethod_0().method_0(GClass172.int_0);
							GClass150.smethod_0().bool_0 = true;
						}
						GClass149.smethod_1((GClass151.int_0 != 0) ? ("Connect to game mannager: " + GClass154.smethod_0().method_6(GClass150.smethod_0().bool_0)) : ("Liên kết với QLTK: " + GClass154.smethod_0().method_6(GClass150.smethod_0().bool_0)), 0);
					}
				}
				else
					GClass91.smethod_0().method_3(47, GClass144.smethod_8(), "");
			}
			return true;
		}
	}
}
