using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;

namespace ns1
{
	public class GClass52
	{
		public bool bool_0;

		private static GClass52 gclass52_0;

		public static string string_0 = "Data/QLTK/HotKey.ini";

		public static bool bool_1;

		public static List<string> list_0 = new List<string>();

		public static GClass52 smethod_0()
		{
			return (gclass52_0 != null) ? gclass52_0 : (gclass52_0 = new GClass52());
		}

		public static int smethod_1()
		{
			if (!GClass54.smethod_0().method_5())
				return 0;
			return 1;
		}

		public static void smethod_2()
		{
			if (!File.Exists(string_0))
				return;
			string[] array = File.ReadAllLines(string_0);
			for (int i = 0; i < array.Length; i++)
			{
				if (!list_0.Contains(array[i]))
					list_0.Add(array[i]);
			}
		}

		public static bool smethod_3(int AsciiKey)
		{
			int num = smethod_1();
			if (num == 0)
			{
				string value = "Key:" + AsciiKey;
				string text = string.Empty;
				foreach (string item in list_0)
				{
					if (item != null && item.StartsWith(value) && item.Contains("MapType:0"))
						text = item;
				}
				int num2 = AsciiKey;
				if (num2 != 47)
				{
					if (num2 != 113)
					{
						if (text != string.Empty)
						{
							switch (int.Parse(text.ToString().Split('|')[1].Split(':')[1]))
							{
							case 0:
								GClass41.smethod_0().bool_0 = !GClass41.smethod_0().bool_0;
								GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto Attack: " + GClass45.smethod_0().method_6(GClass41.smethod_0().bool_0)) : ("Tự động đánh: " + GClass45.smethod_0().method_6(GClass41.smethod_0().bool_0)), 0);
								break;
							case 1:
								GClass2.smethod_0().method_78("/oinf");
								break;
							case 2:
								if (GClass57.smethod_0().bool_0)
								{
									Class11.smethod_0().method_9();
									GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
								}
								else
									Class11.smethod_0().method_3();
								break;
							case 3:
							{
								GClass122 gClass = new GClass122();
								gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nTrain mob" : "Chức năng\nTrain quái", GClass48.smethod_0(), 10000, null));
								gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\n Săn Boss" : "Function\nBoss", GClass58.smethod_0(), 10001, null));
								gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nUp Bí kíp\nYardart" : "Function\nSupport\nYardart", GClass47.smethod_0(), 10002, null));
								gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nHỗ trợ\nUp Đệ tử" : "Function\nSupport\nDisciple", GClass65.smethod_0(), 10003, null));
								gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nSkill" : "Function\nSkill", GClass41.smethod_0(), 10004, null));
								gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nSupport\nPK/BSDB" : "Chức năng\nHỗ trợ\nPK/NRSĐ", GClass47.smethod_0(), 10005, null));
								gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nMap" : "Chức năng\nMap", GClass61.smethod_0(), 10006, null));
								gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nkhác..." : "Another\nFunction...", GClass47.smethod_0(), 10007, null));
								GClass14.gclass116_0.method_2(gClass, 0);
								break;
							}
							case 4:
								GClass14.gclass113_1 = new GClass113();
								GClass14.gclass113_1.method_50();
								GClass14.gclass113_0.method_41();
								GClass14.gclass113_0.method_50();
								break;
							case 5:
								GClass2.smethod_0().method_13(0, -1);
								break;
							case 6:
								GClass2.smethod_0().method_20(0, 1, -1, 193);
								GClass2.smethod_0().method_20(0, 1, -1, 194);
								break;
							case 7:
								GClass147.smethod_1().method_35();
								GClass124.smethod_1().gclass119_0 = null;
								GClass14.smethod_49();
								GClass14.gclass113_1 = new GClass113();
								GClass14.gclass113_1.method_50();
								GClass14.gclass113_0.method_34();
								GClass14.gclass113_0.method_50();
								break;
							case 8:
								GClass61.smethod_0().method_17(0);
								break;
							case 9:
								if (GClass137.int_37 != 135 && GClass137.int_37 != 138 && GClass137.int_37 != 136)
									GClass61.smethod_0().method_17(2);
								else if (GClass137.int_37 == 135)
								{
									Class11.smethod_0().method_24(600, 600);
								}
								else if (GClass137.int_37 != 138)
								{
									if (GClass137.int_37 == 136)
										Class11.smethod_0().method_24(720, 576);
								}
								else
								{
									Class11.smethod_0().method_24(360, 336);
								}
								break;
							case 10:
								GClass61.smethod_0().method_17(1);
								break;
							case 11:
								GClass58.smethod_0().method_8();
								break;
							case 12:
								if (!GClass47.smethod_0().method_50())
									new Thread((ThreadStart)delegate
									{
										GClass47.smethod_0().method_48();
									}).Start();
								else
									new Thread((ThreadStart)delegate
									{
										GClass47.smethod_0().method_46();
									}).Start();
								break;
							case 13:
							{
								GClass124 gClass4 = GClass124.smethod_1();
								if (gClass4.gclass124_0 == null)
								{
									if (gClass4.gclass6_0 == null)
									{
										if (gClass4.gclass125_0 != null)
										{
											gClass4.int_4 = gClass4.gclass125_0.int_4;
											gClass4.int_5 = gClass4.gclass125_0.int_5 - 3;
											GClass2.smethod_0().method_44();
											gClass4.int_4 = gClass4.gclass125_0.int_4;
											gClass4.int_5 = gClass4.gclass125_0.int_5;
											GClass2.smethod_0().method_44();
											gClass4.int_4 = gClass4.gclass125_0.int_4;
											gClass4.int_5 = gClass4.gclass125_0.int_5 - 3;
											GClass2.smethod_0().method_44();
										}
									}
									else
									{
										gClass4.int_4 = gClass4.gclass6_0.int_8;
										gClass4.int_5 = gClass4.gclass6_0.int_9 + 1;
										GClass2.smethod_0().method_44();
										gClass4.int_4 = gClass4.gclass6_0.int_8;
										gClass4.int_5 = gClass4.gclass6_0.int_9;
										GClass2.smethod_0().method_44();
										gClass4.int_4 = gClass4.gclass6_0.int_8;
										gClass4.int_5 = gClass4.gclass6_0.int_9 + 1;
										GClass2.smethod_0().method_44();
									}
								}
								else
								{
									gClass4.int_4 = gClass4.gclass124_0.int_4;
									gClass4.int_5 = gClass4.gclass124_0.int_5;
									GClass2.smethod_0().method_44();
									gClass4.int_4 = gClass4.gclass124_0.int_4;
									gClass4.int_5 = gClass4.gclass124_0.int_5 + 3;
									GClass2.smethod_0().method_44();
									gClass4.int_4 = gClass4.gclass124_0.int_4;
									gClass4.int_5 = gClass4.gclass124_0.int_5;
									GClass2.smethod_0().method_44();
								}
								break;
							}
							case 14:
								GClass54.smethod_0().method_16();
								break;
							case 15:
							{
								for (int j = 0; j < GClass124.smethod_1().gclass0_0.Length; j++)
								{
									GClass0 gClass3 = GClass124.smethod_1().gclass0_0[j];
									if (gClass3 != null && (gClass3.gclass203_0.short_0 == 454 || gClass3.gclass203_0.short_0 == 921))
										GClass2.smethod_0().method_20(0, 1, -1, gClass3.gclass203_0.short_0);
								}
								break;
							}
							case 16:
								new Thread((ThreadStart)delegate
								{
									GClass42.smethod_0().method_17(1, 4);
								}).Start();
								break;
							case 17:
								new Thread((ThreadStart)delegate
								{
									GClass42.smethod_0().method_17(2, 4);
								}).Start();
								break;
							case 18:
								GClass2.smethod_0().method_78("/unikey");
								break;
							case 19:
								GClass2.smethod_0().method_78("/dsq");
								break;
							case 20:
								GClass47.smethod_0().method_21(-1);
								break;
							case 21:
								GClass41.smethod_0().method_5();
								break;
							case 22:
								if (!GClass124.smethod_1().bool_62 && GClass124.smethod_1().gclass60_0.bool_0 && GClass54.smethod_0().method_5())
								{
									GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động phù x7 HP: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_1)) : ("Auto get x7 HP: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_1)), 0);
									new Thread(GClass54.smethod_0().method_12).Start();
								}
								break;
							case 23:
								if (GClass62.bool_3)
								{
									GClass54.smethod_0().bool_4 = !GClass54.smethod_0().bool_4;
									GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto use Sattelite HP: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_4)) : ("Tự động cắm vệ tinh HP: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_4)), 0);
								}
								else
									GClass51.smethod_1((GClass62.int_0 != 0) ? "Contact admin to unlock this function!" : "Liên hệ admin để mở khóa chức năng này!", 1);
								break;
							case 24:
								GClass2.smethod_0().method_78("/anhat");
								break;
							case 25:
							{
								for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
								{
									GClass0 gClass2 = GClass124.smethod_1().gclass0_0[i];
									if (gClass2 != null && gClass2.gclass203_0.short_0 == 521)
										GClass2.smethod_0().method_20(0, 1, -1, gClass2.gclass203_0.short_0);
								}
								break;
							}
							case 26:
								if (!GClass54.smethod_0().method_5())
								{
									GClass2.smethod_0().method_6(0, GClass124.smethod_1().gclass124_0.int_13, -1, -1);
									break;
								}
								GClass48.smethod_0().bool_5 = false;
								GClass2.smethod_0().method_42(GClass137.int_39, -1);
								break;
							case 27:
								GClass2.smethod_0().method_78("/rcvs");
								break;
							case 28:
								GClass2.smethod_0().method_78("/optm");
								break;
							case 29:
								GClass2.smethod_0().method_78("/hide");
								break;
							case 30:
								if (GClass61.smethod_0().int_0 == -1)
									GClass2.smethod_0().method_78($"/kz{((GClass137.int_39 != 0) ? (GClass137.int_39 - 1) : GClass137.int_39)}");
								else if (GClass61.smethod_0().int_0 <= 0)
								{
									GClass51.smethod_1((GClass62.int_0 == 0) ? "Khu bé nhất là [0]" : "Minimum zone is [0]", 0);
								}
								else
								{
									GClass2.smethod_0().method_78($"/kz{GClass137.int_39 - 1}");
								}
								break;
							case 31:
								if (GClass61.smethod_0().int_0 == -1)
									GClass2.smethod_0().method_78($"/kz{((GClass137.int_39 != 0) ? (GClass137.int_39 + 1) : GClass137.int_39)}");
								else if (GClass61.smethod_0().int_0 >= GClass167.smethod_8().int_61.Length - 1)
								{
									GClass51.smethod_1((GClass62.int_0 != 0) ? $"Maximum zone is [{GClass167.smethod_8().int_61.Length - 1}]" : $"Khu lớn nhất là [{GClass167.smethod_8().int_61.Length - 1}]", 0);
								}
								else
								{
									GClass2.smethod_0().method_78($"/kz{GClass137.int_39 + 1}");
								}
								break;
							case 32:
								GClass2.smethod_0().method_78("/dsnv");
								break;
							case 33:
								GClass2.smethod_0().method_78("/tbb");
								break;
							case 34:
								new Thread((ThreadStart)delegate
								{
									GClass47.smethod_0().method_46();
								}).Start();
								break;
							case 35:
								GClass2.smethod_0().method_78("/abt50");
								break;
							case 36:
								GClass2.smethod_0().method_78("/cobj");
								break;
							case 37:
								GClass2.smethod_0().method_78("/ahs");
								break;
							case 38:
								GClass2.smethod_0().method_78("/xd");
								break;
							case 39:
								GClass2.smethod_0().method_78("/td");
								break;
							case 40:
								GClass2.smethod_0().method_78("/cd");
								break;
							case 41:
								GClass2.smethod_0().method_78("/gohome");
								break;
							case 42:
								new Thread((ThreadStart)delegate
								{
									GClass42.smethod_0().method_17(1, 6);
								}).Start();
								break;
							case 43:
								new Thread((ThreadStart)delegate
								{
									GClass42.smethod_0().method_17(2, 6);
								}).Start();
								break;
							case 44:
								GClass2.smethod_0().method_78("/dsn");
								break;
							case 45:
								GClass2.smethod_0().method_78("/dsb");
								break;
							case 46:
								GClass2.smethod_0().method_78("/addchar");
								break;
							case 47:
								GClass2.smethod_0().method_78("/addclan");
								break;
							case 48:
								GClass2.smethod_0().method_78("/addboss");
								break;
							case 49:
								GClass2.smethod_0().method_78("/vqtd");
								break;
							case 50:
								GClass49.smethod_0().method_22();
								break;
							case 51:
								GClass2.smethod_0().method_78("/ats9");
								break;
							case 52:
								GClass48.smethod_0().bool_5 = false;
								GClass2.smethod_0().method_42(GClass137.int_39, -1);
								break;
							}
						}
					}
					else
					{
						if (!GClass55.smethod_0().bool_0)
						{
							GClass55.smethod_0().method_0(GClass50.int_0);
							GClass55.smethod_0().bool_0 = true;
						}
						else
						{
							GClass55.smethod_0().method_2(new vMessage
							{
								cmd = 3,
								data = Encoding.ASCII.GetBytes(GClass55.int_0.ToString())
							});
							GClass55.smethod_0().bool_2 = false;
							GClass55.smethod_0().bool_0 = false;
						}
						GClass51.smethod_1((GClass62.int_0 == 0) ? ("Liên kết với QLTK: " + GClass45.smethod_0().method_6(GClass55.smethod_0().bool_0)) : ("Connect to game mannager: " + GClass45.smethod_0().method_6(GClass55.smethod_0().bool_0)), 0);
					}
				}
				else
					GClass107.smethod_0().method_3(47, GClass167.smethod_8(), string.Empty);
			}
			else
			{
				if (num != 1)
					return false;
				string value2 = "Key:" + AsciiKey;
				string text2 = string.Empty;
				foreach (string item2 in list_0)
				{
					if (item2 != null && item2.StartsWith(value2) && item2.Contains("MapType:1"))
						text2 = item2;
				}
				int num3 = AsciiKey;
				if (num3 != 47)
				{
					if (num3 != 113)
					{
						if (text2 != string.Empty)
						{
							switch (int.Parse(text2.ToString().Split('|')[1].Split(':')[1]))
							{
							case 0:
								GClass41.smethod_0().bool_0 = !GClass41.smethod_0().bool_0;
								GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto Attack: " + GClass45.smethod_0().method_6(GClass41.smethod_0().bool_0)) : ("Tự động đánh: " + GClass45.smethod_0().method_6(GClass41.smethod_0().bool_0)), 0);
								break;
							case 1:
								GClass2.smethod_0().method_78("/oinf");
								break;
							case 2:
								if (GClass57.smethod_0().bool_0)
								{
									Class11.smethod_0().method_9();
									GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
								}
								else
									Class11.smethod_0().method_3();
								break;
							case 3:
							{
								GClass122 gClass5 = new GClass122();
								gClass5.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nTrain mob" : "Chức năng\nTrain quái", GClass48.smethod_0(), 10000, null));
								gClass5.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nBoss" : "Chức năng\n Săn Boss", GClass58.smethod_0(), 10001, null));
								gClass5.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nUp Bí kíp\nYardart" : "Function\nSupport\nYardart", GClass47.smethod_0(), 10002, null));
								gClass5.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nSupport\nDisciple" : "Chức năng\nHỗ trợ\nUp Đệ tử", GClass65.smethod_0(), 10003, null));
								gClass5.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nSkill" : "Chức năng\nSkill", GClass41.smethod_0(), 10004, null));
								gClass5.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nHỗ trợ\nPK/NRSĐ" : "Function\nSupport\nPK/BSDB", GClass47.smethod_0(), 10005, null));
								gClass5.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nMap" : "Chức năng\nMap", GClass61.smethod_0(), 10006, null));
								gClass5.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nkhác..." : "Another\nFunction...", GClass47.smethod_0(), 10007, null));
								GClass14.gclass116_0.method_2(gClass5, 0);
								break;
							}
							case 4:
								GClass14.gclass113_1 = new GClass113();
								GClass14.gclass113_1.method_50();
								GClass14.gclass113_0.method_41();
								GClass14.gclass113_0.method_50();
								break;
							case 5:
								GClass2.smethod_0().method_13(0, -1);
								break;
							case 6:
								GClass2.smethod_0().method_20(0, 1, -1, 193);
								GClass2.smethod_0().method_20(0, 1, -1, 194);
								break;
							case 7:
								GClass147.smethod_1().method_35();
								GClass124.smethod_1().gclass119_0 = null;
								GClass14.smethod_49();
								GClass14.gclass113_1 = new GClass113();
								GClass14.gclass113_1.method_50();
								GClass14.gclass113_0.method_34();
								GClass14.gclass113_0.method_50();
								break;
							case 8:
								GClass61.smethod_0().method_17(0);
								break;
							case 9:
								if (GClass137.int_37 == 135 || GClass137.int_37 == 138 || GClass137.int_37 == 136)
								{
									if (GClass137.int_37 == 135)
										Class11.smethod_0().method_24(600, 600);
									else if (GClass137.int_37 != 138)
									{
										if (GClass137.int_37 == 136)
											Class11.smethod_0().method_24(720, 576);
									}
									else
									{
										Class11.smethod_0().method_24(360, 336);
									}
								}
								else
									GClass61.smethod_0().method_17(2);
								break;
							case 10:
								GClass61.smethod_0().method_17(1);
								break;
							case 11:
								GClass58.smethod_0().method_8();
								break;
							case 12:
								if (GClass47.smethod_0().method_50())
									new Thread((ThreadStart)delegate
									{
										GClass47.smethod_0().method_46();
									}).Start();
								else
									new Thread((ThreadStart)delegate
									{
										GClass47.smethod_0().method_48();
									}).Start();
								break;
							case 13:
							{
								GClass124 gClass8 = GClass124.smethod_1();
								if (gClass8.gclass124_0 == null)
								{
									if (gClass8.gclass6_0 == null)
									{
										if (gClass8.gclass125_0 != null)
										{
											gClass8.int_4 = gClass8.gclass125_0.int_4;
											gClass8.int_5 = gClass8.gclass125_0.int_5 - 3;
											GClass2.smethod_0().method_44();
											gClass8.int_4 = gClass8.gclass125_0.int_4;
											gClass8.int_5 = gClass8.gclass125_0.int_5;
											GClass2.smethod_0().method_44();
											gClass8.int_4 = gClass8.gclass125_0.int_4;
											gClass8.int_5 = gClass8.gclass125_0.int_5 - 3;
											GClass2.smethod_0().method_44();
										}
									}
									else
									{
										gClass8.int_4 = gClass8.gclass6_0.int_8;
										gClass8.int_5 = gClass8.gclass6_0.int_9 + 1;
										GClass2.smethod_0().method_44();
										gClass8.int_4 = gClass8.gclass6_0.int_8;
										gClass8.int_5 = gClass8.gclass6_0.int_9;
										GClass2.smethod_0().method_44();
										gClass8.int_4 = gClass8.gclass6_0.int_8;
										gClass8.int_5 = gClass8.gclass6_0.int_9 + 1;
										GClass2.smethod_0().method_44();
									}
								}
								else
								{
									gClass8.int_4 = gClass8.gclass124_0.int_4;
									gClass8.int_5 = gClass8.gclass124_0.int_5;
									GClass2.smethod_0().method_44();
									gClass8.int_4 = gClass8.gclass124_0.int_4;
									gClass8.int_5 = gClass8.gclass124_0.int_5 + 3;
									GClass2.smethod_0().method_44();
									gClass8.int_4 = gClass8.gclass124_0.int_4;
									gClass8.int_5 = gClass8.gclass124_0.int_5;
									GClass2.smethod_0().method_44();
								}
								break;
							}
							case 14:
								GClass54.smethod_0().method_16();
								break;
							case 15:
							{
								for (int l = 0; l < GClass124.smethod_1().gclass0_0.Length; l++)
								{
									GClass0 gClass7 = GClass124.smethod_1().gclass0_0[l];
									if (gClass7 != null && (gClass7.gclass203_0.short_0 == 454 || gClass7.gclass203_0.short_0 == 921))
										GClass2.smethod_0().method_20(0, 1, -1, gClass7.gclass203_0.short_0);
								}
								break;
							}
							case 16:
								new Thread((ThreadStart)delegate
								{
									GClass42.smethod_0().method_17(1, 4);
								}).Start();
								break;
							case 17:
								new Thread((ThreadStart)delegate
								{
									GClass42.smethod_0().method_17(2, 4);
								}).Start();
								break;
							case 18:
								GClass2.smethod_0().method_78("/unikey");
								break;
							case 19:
								GClass2.smethod_0().method_78("/dsq");
								break;
							case 20:
								GClass47.smethod_0().method_21(-1);
								break;
							case 21:
								GClass41.smethod_0().method_5();
								break;
							case 22:
								if (!GClass124.smethod_1().bool_62 && GClass124.smethod_1().gclass60_0.bool_0 && GClass54.smethod_0().method_5())
								{
									GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto get x7 HP: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_1)) : ("Tự động phù x7 HP: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_1)), 0);
									new Thread(GClass54.smethod_0().method_12).Start();
								}
								break;
							case 23:
								if (!GClass62.bool_3)
								{
									GClass51.smethod_1((GClass62.int_0 != 0) ? "Contact admin to unlock this function!" : "Liên hệ admin để mở khóa chức năng này!", 1);
									break;
								}
								GClass54.smethod_0().bool_4 = !GClass54.smethod_0().bool_4;
								GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động cắm vệ tinh HP: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_4)) : ("Auto use Sattelite HP: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_4)), 0);
								break;
							case 24:
								GClass2.smethod_0().method_78("/anhat");
								break;
							case 25:
							{
								for (int k = 0; k < GClass124.smethod_1().gclass0_0.Length; k++)
								{
									GClass0 gClass6 = GClass124.smethod_1().gclass0_0[k];
									if (gClass6 != null && gClass6.gclass203_0.short_0 == 521)
										GClass2.smethod_0().method_20(0, 1, -1, gClass6.gclass203_0.short_0);
								}
								break;
							}
							case 26:
								if (!GClass54.smethod_0().method_5())
								{
									GClass2.smethod_0().method_6(0, GClass124.smethod_1().gclass124_0.int_13, -1, -1);
									break;
								}
								GClass48.smethod_0().bool_5 = false;
								GClass2.smethod_0().method_42(GClass137.int_39, -1);
								break;
							case 27:
								GClass2.smethod_0().method_78("/rcvs");
								break;
							case 28:
								GClass2.smethod_0().method_78("/optm");
								break;
							case 29:
								GClass2.smethod_0().method_78("/hide");
								break;
							case 30:
								if (GClass61.smethod_0().int_0 != -1)
								{
									if (GClass61.smethod_0().int_0 <= 0)
										GClass51.smethod_1((GClass62.int_0 == 0) ? "Khu bé nhất là [0]" : "Minimum zone is [0]", 0);
									else
										GClass2.smethod_0().method_78($"/kz{GClass137.int_39 - 1}");
								}
								else
									GClass2.smethod_0().method_78($"/kz{((GClass137.int_39 == 0) ? GClass137.int_39 : (GClass137.int_39 - 1))}");
								break;
							case 31:
								if (GClass61.smethod_0().int_0 != -1)
								{
									if (GClass61.smethod_0().int_0 >= GClass167.smethod_8().int_61.Length - 1)
										GClass51.smethod_1((GClass62.int_0 != 0) ? $"Maximum zone is [{GClass167.smethod_8().int_61.Length - 1}]" : $"Khu lớn nhất là [{GClass167.smethod_8().int_61.Length - 1}]", 0);
									else
										GClass2.smethod_0().method_78($"/kz{GClass137.int_39 + 1}");
								}
								else
									GClass2.smethod_0().method_78($"/kz{((GClass137.int_39 == 0) ? GClass137.int_39 : (GClass137.int_39 + 1))}");
								break;
							case 32:
								GClass2.smethod_0().method_78("/dsnv");
								break;
							case 33:
								GClass2.smethod_0().method_78("/tbb");
								break;
							case 34:
								new Thread((ThreadStart)delegate
								{
									GClass47.smethod_0().method_46();
								}).Start();
								break;
							case 35:
								GClass2.smethod_0().method_78("/abt50");
								break;
							case 36:
								GClass2.smethod_0().method_78("/cobj");
								break;
							case 37:
								GClass2.smethod_0().method_78("/ahs");
								break;
							case 38:
								GClass2.smethod_0().method_78("/xd");
								break;
							case 39:
								GClass2.smethod_0().method_78("/td");
								break;
							case 40:
								GClass2.smethod_0().method_78("/cd");
								break;
							case 41:
								GClass2.smethod_0().method_78("/gohome");
								break;
							case 42:
								new Thread((ThreadStart)delegate
								{
									GClass42.smethod_0().method_17(1, 6);
								}).Start();
								break;
							case 43:
								new Thread((ThreadStart)delegate
								{
									GClass42.smethod_0().method_17(2, 6);
								}).Start();
								break;
							case 44:
								GClass2.smethod_0().method_78("/dsn");
								break;
							case 45:
								GClass2.smethod_0().method_78("/dsb");
								break;
							case 46:
								GClass2.smethod_0().method_78("/addchar");
								break;
							case 47:
								GClass2.smethod_0().method_78("/addclan");
								break;
							case 48:
								GClass2.smethod_0().method_78("/addboss");
								break;
							case 49:
								GClass2.smethod_0().method_78("/vqtd");
								break;
							case 50:
								GClass49.smethod_0().method_22();
								break;
							case 51:
								GClass2.smethod_0().method_78("/ats9");
								break;
							case 52:
								GClass48.smethod_0().bool_5 = false;
								GClass2.smethod_0().method_42(GClass137.int_39, -1);
								break;
							}
						}
					}
					else
					{
						if (!GClass55.smethod_0().bool_0)
						{
							GClass55.smethod_0().method_0(GClass50.int_0);
							GClass55.smethod_0().bool_0 = true;
						}
						else
						{
							GClass55.smethod_0().method_2(new vMessage
							{
								cmd = 3,
								data = Encoding.ASCII.GetBytes(GClass55.int_0.ToString())
							});
							GClass55.smethod_0().bool_2 = false;
							GClass55.smethod_0().bool_0 = false;
						}
						GClass51.smethod_1((GClass62.int_0 == 0) ? ("Liên kết với QLTK: " + GClass45.smethod_0().method_6(GClass55.smethod_0().bool_0)) : ("Connect to game mannager: " + GClass45.smethod_0().method_6(GClass55.smethod_0().bool_0)), 0);
					}
				}
				else
					GClass107.smethod_0().method_3(47, GClass167.smethod_8(), string.Empty);
			}
			return true;
		}
	}
}
