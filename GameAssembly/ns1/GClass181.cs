using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;

namespace ns1
{
	public class GClass181
	{
		public bool bool_0;

		private static GClass181 gclass181_0;

		public static string string_0 = "Data/QLTK/HotKey.ini";

		public static bool bool_1;

		public static List<string> list_0 = new List<string>();

		public static GClass181 smethod_0()
		{
			return (gclass181_0 != null) ? gclass181_0 : (gclass181_0 = new GClass181());
		}

		public static int smethod_1()
		{
			if (GClass177.smethod_0().method_5())
				return 1;
			return 0;
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
			if (num != 0)
			{
				if (num != 1)
					return false;
				string value = "Key:" + AsciiKey;
				string text = string.Empty;
				foreach (string item in list_0)
				{
					if (item != null && item.StartsWith(value) && item.Contains("MapType:1"))
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
								GClass196.smethod_0().bool_0 = !GClass196.smethod_0().bool_0;
								GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động đánh: " + GClass193.smethod_0().method_6(GClass196.smethod_0().bool_0)) : ("Auto Attack: " + GClass193.smethod_0().method_6(GClass196.smethod_0().bool_0)), 0);
								break;
							case 1:
								GClass166.smethod_0().method_78("/oinf");
								break;
							case 2:
								if (GClass171.smethod_0().bool_0)
								{
									Class14.smethod_0().method_8();
									GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
								}
								else
									Class14.smethod_0().ivEoIuqQfu();
								break;
							case 3:
							{
								GClass63 gClass = new GClass63();
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nTrain quái" : "Function\nTrain mob", GClass197.smethod_0(), 10000, null));
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\n Săn Boss" : "Function\nBoss", GClass189.smethod_0(), 10001, null));
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nUp Bí kíp\nYardart" : "Function\nSupport\nYardart", GClass191.smethod_0(), 10002, null));
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nHỗ trợ\nUp Đệ tử" : "Function\nSupport\nDisciple", GClass195.smethod_0(), 10003, null));
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nSkill" : "Function\nSkill", GClass196.smethod_0(), 10004, null));
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nHỗ trợ\nPK/NRSĐ" : "Function\nSupport\nPK/BSDB", GClass191.smethod_0(), 10005, null));
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nMap" : "Function\nMap", GClass175.smethod_0(), 10006, null));
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nkhác..." : "Another\nFunction...", GClass191.smethod_0(), 10007, null));
								GClass39.gclass0_0.method_2(gClass, 0);
								break;
							}
							case 4:
								GClass39.gclass45_1 = new GClass45();
								GClass39.gclass45_1.method_50();
								GClass39.gclass45_0.method_41();
								GClass39.gclass45_0.method_50();
								break;
							case 5:
								GClass166.smethod_0().method_13(0, -1);
								break;
							case 6:
								GClass166.smethod_0().method_20(0, 1, -1, 193);
								GClass166.smethod_0().method_20(0, 1, -1, 194);
								break;
							case 7:
								GClass29.smethod_1().method_35();
								GClass58.smethod_1().gclass136_0 = null;
								GClass39.smethod_49();
								GClass39.gclass45_1 = new GClass45();
								GClass39.gclass45_1.method_50();
								GClass39.gclass45_0.method_34();
								GClass39.gclass45_0.method_50();
								break;
							case 8:
								GClass175.smethod_0().method_17(0);
								break;
							case 9:
								if (GClass1.int_37 != 135 && GClass1.int_37 != 138 && GClass1.int_37 != 136)
									GClass175.smethod_0().method_17(2);
								else if (GClass1.int_37 == 135)
								{
									Class14.smethod_0().method_23(600, 600);
								}
								else if (GClass1.int_37 == 138)
								{
									Class14.smethod_0().method_23(360, 336);
								}
								else if (GClass1.int_37 == 136)
								{
									Class14.smethod_0().method_23(720, 576);
								}
								break;
							case 10:
								GClass175.smethod_0().method_17(1);
								break;
							case 11:
								GClass189.smethod_0().method_8();
								break;
							case 12:
								if (GClass191.smethod_0().method_47())
									new Thread((ThreadStart)delegate
									{
										GClass191.smethod_0().method_43();
									}).Start();
								else
									new Thread((ThreadStart)delegate
									{
										GClass191.smethod_0().method_45();
									}).Start();
								break;
							case 13:
							{
								GClass58 gClass4 = GClass58.smethod_1();
								if (gClass4.gclass58_0 != null)
								{
									gClass4.int_4 = gClass4.gclass58_0.int_4;
									gClass4.int_5 = gClass4.gclass58_0.int_5;
									GClass166.smethod_0().method_44();
									gClass4.int_4 = gClass4.gclass58_0.int_4;
									gClass4.int_5 = gClass4.gclass58_0.int_5 + 3;
									GClass166.smethod_0().method_44();
									gClass4.int_4 = gClass4.gclass58_0.int_4;
									gClass4.int_5 = gClass4.gclass58_0.int_5;
									GClass166.smethod_0().method_44();
								}
								else if (gClass4.gclass85_0 != null)
								{
									gClass4.int_4 = gClass4.gclass85_0.int_8;
									gClass4.int_5 = gClass4.gclass85_0.int_9 + 1;
									GClass166.smethod_0().method_44();
									gClass4.int_4 = gClass4.gclass85_0.int_8;
									gClass4.int_5 = gClass4.gclass85_0.int_9;
									GClass166.smethod_0().method_44();
									gClass4.int_4 = gClass4.gclass85_0.int_8;
									gClass4.int_5 = gClass4.gclass85_0.int_9 + 1;
									GClass166.smethod_0().method_44();
								}
								else if (gClass4.gclass59_0 != null)
								{
									gClass4.int_4 = gClass4.gclass59_0.int_4;
									gClass4.int_5 = gClass4.gclass59_0.int_5 - 3;
									GClass166.smethod_0().method_44();
									gClass4.int_4 = gClass4.gclass59_0.int_4;
									gClass4.int_5 = gClass4.gclass59_0.int_5;
									GClass166.smethod_0().method_44();
									gClass4.int_4 = gClass4.gclass59_0.int_4;
									gClass4.int_5 = gClass4.gclass59_0.int_5 - 3;
									GClass166.smethod_0().method_44();
								}
								break;
							}
							case 14:
								GClass177.smethod_0().method_17();
								break;
							case 15:
							{
								for (int j = 0; j < GClass58.smethod_1().gclass121_0.Length; j++)
								{
									GClass121 gClass3 = GClass58.smethod_1().gclass121_0[j];
									if (gClass3 != null && (gClass3.gclass118_0.short_0 == 454 || gClass3.gclass118_0.short_0 == 921))
										GClass166.smethod_0().method_20(0, 1, -1, gClass3.gclass118_0.short_0);
								}
								break;
							}
							case 16:
								new Thread((ThreadStart)delegate
								{
									GClass183.smethod_0().method_13(1, 4);
								}).Start();
								break;
							case 17:
								new Thread((ThreadStart)delegate
								{
									GClass183.smethod_0().method_13(2, 4);
								}).Start();
								break;
							case 18:
								GClass166.smethod_0().method_78("/unikey");
								break;
							case 19:
								GClass166.smethod_0().method_78("/dsq");
								break;
							case 20:
								GClass191.smethod_0().method_20(-1);
								break;
							case 21:
								GClass196.smethod_0().method_4();
								break;
							case 22:
								if (!GClass58.smethod_1().bool_62 && GClass58.smethod_1().gclass176_0.bool_0 && GClass177.smethod_0().method_5())
								{
									GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động phù x7 HP: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_1)) : ("Auto get x7 HP: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_1)), 0);
									new Thread(GClass177.smethod_0().method_13).Start();
								}
								break;
							case 23:
								if (GClass192.bool_3)
								{
									GClass177.smethod_0().bool_4 = !GClass177.smethod_0().bool_4;
									GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động cắm vệ tinh HP: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_4)) : ("Auto use Sattelite HP: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_4)), 0);
								}
								else
									GClass188.smethod_1((GClass192.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
								break;
							case 24:
								GClass166.smethod_0().method_78("/anhat");
								break;
							case 25:
							{
								for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
								{
									GClass121 gClass2 = GClass58.smethod_1().gclass121_0[i];
									if (gClass2 != null && gClass2.gclass118_0.short_0 == 521)
										GClass166.smethod_0().method_20(0, 1, -1, gClass2.gclass118_0.short_0);
								}
								break;
							}
							case 26:
								if (!GClass177.smethod_0().method_5())
								{
									GClass166.smethod_0().method_6(0, GClass58.smethod_1().gclass58_0.int_13, -1, -1);
									break;
								}
								GClass197.smethod_0().bool_5 = false;
								GClass166.smethod_0().method_42(GClass1.int_39, -1);
								break;
							case 27:
								GClass166.smethod_0().method_78("/rcvs");
								break;
							case 28:
								GClass166.smethod_0().method_78("/optm");
								break;
							case 29:
								GClass166.smethod_0().method_78("/hide");
								break;
							case 30:
								if (GClass175.smethod_0().int_0 != -1)
								{
									if (GClass175.smethod_0().int_0 > 0)
										GClass166.smethod_0().method_78($"/kz{GClass1.int_39 - 1}");
									else
										GClass188.smethod_1((GClass192.int_0 == 0) ? "Khu bé nhất là [0]" : "Minimum zone is [0]", 0);
								}
								else
									GClass166.smethod_0().method_78($"/kz{((GClass1.int_39 == 0) ? GClass1.int_39 : (GClass1.int_39 - 1))}");
								break;
							case 31:
								if (GClass175.smethod_0().int_0 != -1)
								{
									if (GClass175.smethod_0().int_0 < GClass154.smethod_8().int_61.Length - 1)
										GClass166.smethod_0().method_78($"/kz{GClass1.int_39 + 1}");
									else
										GClass188.smethod_1((GClass192.int_0 == 0) ? $"Khu lớn nhất là [{GClass154.smethod_8().int_61.Length - 1}]" : $"Maximum zone is [{GClass154.smethod_8().int_61.Length - 1}]", 0);
								}
								else
									GClass166.smethod_0().method_78($"/kz{((GClass1.int_39 == 0) ? GClass1.int_39 : (GClass1.int_39 + 1))}");
								break;
							case 32:
								GClass166.smethod_0().method_78("/dsnv");
								break;
							case 33:
								GClass166.smethod_0().method_78("/tbb");
								break;
							case 34:
								GClass166.smethod_0().method_78("/autoitem");
								break;
							case 35:
								GClass166.smethod_0().method_78("/abt50");
								break;
							case 36:
								GClass166.smethod_0().method_78("/cobj");
								break;
							case 37:
								GClass166.smethod_0().method_78("/ahs");
								break;
							case 38:
								GClass166.smethod_0().method_78("/xd");
								break;
							case 39:
								GClass166.smethod_0().method_78("/td");
								break;
							case 40:
								GClass166.smethod_0().method_78("/cd");
								break;
							case 41:
								GClass166.smethod_0().method_78("/gohome");
								break;
							case 42:
								new Thread((ThreadStart)delegate
								{
									GClass183.smethod_0().method_13(1, 6);
								}).Start();
								break;
							case 43:
								new Thread((ThreadStart)delegate
								{
									GClass183.smethod_0().method_13(2, 6);
								}).Start();
								break;
							case 44:
								GClass166.smethod_0().method_78("/dsn");
								break;
							case 45:
								GClass166.smethod_0().method_78("/dsb");
								break;
							case 46:
								GClass166.smethod_0().method_78("/cadd");
								break;
							case 47:
								GClass166.smethod_0().method_78("/clanadd");
								break;
							case 48:
								GClass166.smethod_0().method_78("/badd");
								break;
							case 49:
								GClass166.smethod_0().method_78("/vqtd");
								break;
							case 50:
								GClass172.smethod_0().method_22();
								break;
							case 51:
								GClass166.smethod_0().method_78("/ats9");
								break;
							case 52:
								GClass175.smethod_0().bool_3 = !GClass175.smethod_0().bool_3;
								GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động mở BĐKB: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_3)) : ("Auto open treasure dungeon: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_3)), 0);
								break;
							case 53:
								GClass175.smethod_0().bool_4 = !GClass175.smethod_0().bool_4;
								GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động mở DTĐN: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_4)) : ("Auto open one eye dungeon: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_4)), 0);
								break;
							}
						}
					}
					else
					{
						if (GClass174.smethod_0().bool_0)
						{
							GClass174.smethod_0().method_2(new vMessage
							{
								cmd = 3,
								data = Encoding.ASCII.GetBytes(GClass174.string_0)
							});
							GClass174.smethod_0().bool_2 = false;
							GClass174.smethod_0().bool_0 = false;
						}
						else
						{
							GClass174.smethod_0().method_0(GClass199.int_0);
							GClass174.smethod_0().bool_0 = true;
						}
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Liên kết với QLTK: " + GClass193.smethod_0().method_6(GClass174.smethod_0().bool_0)) : ("Connect to game mannager: " + GClass193.smethod_0().method_6(GClass174.smethod_0().bool_0)), 0);
					}
				}
				else
					GClass7.smethod_0().method_3(47, GClass154.smethod_8(), string.Empty);
			}
			else
			{
				string value2 = "Key:" + AsciiKey;
				string text2 = string.Empty;
				foreach (string item2 in list_0)
				{
					if (item2 != null && item2.StartsWith(value2) && item2.Contains("MapType:0"))
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
								GClass196.smethod_0().bool_0 = !GClass196.smethod_0().bool_0;
								GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động đánh: " + GClass193.smethod_0().method_6(GClass196.smethod_0().bool_0)) : ("Auto Attack: " + GClass193.smethod_0().method_6(GClass196.smethod_0().bool_0)), 0);
								break;
							case 1:
								GClass166.smethod_0().method_78("/oinf");
								break;
							case 2:
								if (GClass171.smethod_0().bool_0)
								{
									Class14.smethod_0().method_8();
									GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
								}
								else
									Class14.smethod_0().ivEoIuqQfu();
								break;
							case 3:
							{
								GClass63 gClass5 = new GClass63();
								gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nTrain quái" : "Function\nTrain mob", GClass197.smethod_0(), 10000, null));
								gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\n Săn Boss" : "Function\nBoss", GClass189.smethod_0(), 10001, null));
								gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nUp Bí kíp\nYardart" : "Function\nSupport\nYardart", GClass191.smethod_0(), 10002, null));
								gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nHỗ trợ\nUp Đệ tử" : "Function\nSupport\nDisciple", GClass195.smethod_0(), 10003, null));
								gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nSkill" : "Function\nSkill", GClass196.smethod_0(), 10004, null));
								gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nHỗ trợ\nPK/NRSĐ" : "Function\nSupport\nPK/BSDB", GClass191.smethod_0(), 10005, null));
								gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nMap" : "Function\nMap", GClass175.smethod_0(), 10006, null));
								gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nkhác..." : "Another\nFunction...", GClass191.smethod_0(), 10007, null));
								GClass39.gclass0_0.method_2(gClass5, 0);
								break;
							}
							case 4:
								GClass39.gclass45_1 = new GClass45();
								GClass39.gclass45_1.method_50();
								GClass39.gclass45_0.method_41();
								GClass39.gclass45_0.method_50();
								break;
							case 5:
								GClass166.smethod_0().method_13(0, -1);
								break;
							case 6:
								GClass166.smethod_0().method_20(0, 1, -1, 193);
								GClass166.smethod_0().method_20(0, 1, -1, 194);
								break;
							case 7:
								GClass29.smethod_1().method_35();
								GClass58.smethod_1().gclass136_0 = null;
								GClass39.smethod_49();
								GClass39.gclass45_1 = new GClass45();
								GClass39.gclass45_1.method_50();
								GClass39.gclass45_0.method_34();
								GClass39.gclass45_0.method_50();
								break;
							case 8:
								GClass175.smethod_0().method_17(0);
								break;
							case 9:
								if (GClass1.int_37 != 135 && GClass1.int_37 != 138 && GClass1.int_37 != 136)
									GClass175.smethod_0().method_17(2);
								else if (GClass1.int_37 == 135)
								{
									Class14.smethod_0().method_23(600, 600);
								}
								else if (GClass1.int_37 == 138)
								{
									Class14.smethod_0().method_23(360, 336);
								}
								else if (GClass1.int_37 == 136)
								{
									Class14.smethod_0().method_23(720, 576);
								}
								break;
							case 10:
								GClass175.smethod_0().method_17(1);
								break;
							case 11:
								GClass189.smethod_0().method_8();
								break;
							case 12:
								if (GClass191.smethod_0().method_47())
									new Thread((ThreadStart)delegate
									{
										GClass191.smethod_0().method_43();
									}).Start();
								else
									new Thread((ThreadStart)delegate
									{
										GClass191.smethod_0().method_45();
									}).Start();
								break;
							case 13:
							{
								GClass58 gClass8 = GClass58.smethod_1();
								if (gClass8.gclass58_0 != null)
								{
									gClass8.int_4 = gClass8.gclass58_0.int_4;
									gClass8.int_5 = gClass8.gclass58_0.int_5;
									GClass166.smethod_0().method_44();
									gClass8.int_4 = gClass8.gclass58_0.int_4;
									gClass8.int_5 = gClass8.gclass58_0.int_5 + 3;
									GClass166.smethod_0().method_44();
									gClass8.int_4 = gClass8.gclass58_0.int_4;
									gClass8.int_5 = gClass8.gclass58_0.int_5;
									GClass166.smethod_0().method_44();
								}
								else if (gClass8.gclass85_0 != null)
								{
									gClass8.int_4 = gClass8.gclass85_0.int_8;
									gClass8.int_5 = gClass8.gclass85_0.int_9 + 1;
									GClass166.smethod_0().method_44();
									gClass8.int_4 = gClass8.gclass85_0.int_8;
									gClass8.int_5 = gClass8.gclass85_0.int_9;
									GClass166.smethod_0().method_44();
									gClass8.int_4 = gClass8.gclass85_0.int_8;
									gClass8.int_5 = gClass8.gclass85_0.int_9 + 1;
									GClass166.smethod_0().method_44();
								}
								else if (gClass8.gclass59_0 != null)
								{
									gClass8.int_4 = gClass8.gclass59_0.int_4;
									gClass8.int_5 = gClass8.gclass59_0.int_5 - 3;
									GClass166.smethod_0().method_44();
									gClass8.int_4 = gClass8.gclass59_0.int_4;
									gClass8.int_5 = gClass8.gclass59_0.int_5;
									GClass166.smethod_0().method_44();
									gClass8.int_4 = gClass8.gclass59_0.int_4;
									gClass8.int_5 = gClass8.gclass59_0.int_5 - 3;
									GClass166.smethod_0().method_44();
								}
								break;
							}
							case 14:
								GClass177.smethod_0().method_17();
								break;
							case 15:
							{
								for (int l = 0; l < GClass58.smethod_1().gclass121_0.Length; l++)
								{
									GClass121 gClass7 = GClass58.smethod_1().gclass121_0[l];
									if (gClass7 != null && (gClass7.gclass118_0.short_0 == 454 || gClass7.gclass118_0.short_0 == 921))
										GClass166.smethod_0().method_20(0, 1, -1, gClass7.gclass118_0.short_0);
								}
								break;
							}
							case 16:
								new Thread((ThreadStart)delegate
								{
									GClass183.smethod_0().method_13(1, 4);
								}).Start();
								break;
							case 17:
								new Thread((ThreadStart)delegate
								{
									GClass183.smethod_0().method_13(2, 4);
								}).Start();
								break;
							case 18:
								GClass166.smethod_0().method_78("/unikey");
								break;
							case 19:
								GClass166.smethod_0().method_78("/dsq");
								break;
							case 20:
								GClass191.smethod_0().method_20(-1);
								break;
							case 21:
								GClass196.smethod_0().method_4();
								break;
							case 22:
								if (!GClass58.smethod_1().bool_62 && GClass58.smethod_1().gclass176_0.bool_0 && GClass177.smethod_0().method_5())
								{
									GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động phù x7 HP: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_1)) : ("Auto get x7 HP: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_1)), 0);
									new Thread(GClass177.smethod_0().method_13).Start();
								}
								break;
							case 23:
								if (GClass192.bool_3)
								{
									GClass177.smethod_0().bool_4 = !GClass177.smethod_0().bool_4;
									GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động cắm vệ tinh HP: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_4)) : ("Auto use Sattelite HP: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_4)), 0);
								}
								else
									GClass188.smethod_1((GClass192.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
								break;
							case 24:
								GClass166.smethod_0().method_78("/anhat");
								break;
							case 25:
							{
								for (int k = 0; k < GClass58.smethod_1().gclass121_0.Length; k++)
								{
									GClass121 gClass6 = GClass58.smethod_1().gclass121_0[k];
									if (gClass6 != null && gClass6.gclass118_0.short_0 == 521)
										GClass166.smethod_0().method_20(0, 1, -1, gClass6.gclass118_0.short_0);
								}
								break;
							}
							case 26:
								if (!GClass177.smethod_0().method_5())
								{
									GClass166.smethod_0().method_6(0, GClass58.smethod_1().gclass58_0.int_13, -1, -1);
									break;
								}
								GClass197.smethod_0().bool_5 = false;
								GClass166.smethod_0().method_42(GClass1.int_39, -1);
								break;
							case 27:
								GClass166.smethod_0().method_78("/rcvs");
								break;
							case 28:
								GClass166.smethod_0().method_78("/optm");
								break;
							case 29:
								GClass166.smethod_0().method_78("/hide");
								break;
							case 30:
								if (GClass175.smethod_0().int_0 != -1)
								{
									if (GClass175.smethod_0().int_0 > 0)
										GClass166.smethod_0().method_78($"/kz{GClass1.int_39 - 1}");
									else
										GClass188.smethod_1((GClass192.int_0 == 0) ? "Khu bé nhất là [0]" : "Minimum zone is [0]", 0);
								}
								else
									GClass166.smethod_0().method_78($"/kz{((GClass1.int_39 == 0) ? GClass1.int_39 : (GClass1.int_39 - 1))}");
								break;
							case 31:
								if (GClass175.smethod_0().int_0 != -1)
								{
									if (GClass175.smethod_0().int_0 < GClass154.smethod_8().int_61.Length - 1)
										GClass166.smethod_0().method_78($"/kz{GClass1.int_39 + 1}");
									else
										GClass188.smethod_1((GClass192.int_0 == 0) ? $"Khu lớn nhất là [{GClass154.smethod_8().int_61.Length - 1}]" : $"Maximum zone is [{GClass154.smethod_8().int_61.Length - 1}]", 0);
								}
								else
									GClass166.smethod_0().method_78($"/kz{((GClass1.int_39 == 0) ? GClass1.int_39 : (GClass1.int_39 + 1))}");
								break;
							case 32:
								GClass166.smethod_0().method_78("/dsnv");
								break;
							case 33:
								GClass166.smethod_0().method_78("/tbb");
								break;
							case 34:
								GClass166.smethod_0().method_78("/autoitem");
								break;
							case 35:
								GClass166.smethod_0().method_78("/abt50");
								break;
							case 36:
								GClass166.smethod_0().method_78("/cobj");
								break;
							case 37:
								GClass166.smethod_0().method_78("/ahs");
								break;
							case 38:
								GClass166.smethod_0().method_78("/xd");
								break;
							case 39:
								GClass166.smethod_0().method_78("/td");
								break;
							case 40:
								GClass166.smethod_0().method_78("/cd");
								break;
							case 41:
								GClass166.smethod_0().method_78("/gohome");
								break;
							case 42:
								new Thread((ThreadStart)delegate
								{
									GClass183.smethod_0().method_13(1, 6);
								}).Start();
								break;
							case 43:
								new Thread((ThreadStart)delegate
								{
									GClass183.smethod_0().method_13(2, 6);
								}).Start();
								break;
							case 44:
								GClass166.smethod_0().method_78("/dsn");
								break;
							case 45:
								GClass166.smethod_0().method_78("/dsb");
								break;
							case 46:
								GClass166.smethod_0().method_78("/cadd");
								break;
							case 47:
								GClass166.smethod_0().method_78("/clanadd");
								break;
							case 48:
								GClass166.smethod_0().method_78("/badd");
								break;
							case 49:
								GClass166.smethod_0().method_78("/vqtd");
								break;
							case 50:
								GClass172.smethod_0().method_22();
								break;
							case 51:
								GClass166.smethod_0().method_78("/ats9");
								break;
							case 52:
								GClass175.smethod_0().bool_3 = !GClass175.smethod_0().bool_3;
								GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động mở BĐKB: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_3)) : ("Auto open treasure dungeon: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_3)), 0);
								break;
							case 53:
								GClass175.smethod_0().bool_4 = !GClass175.smethod_0().bool_4;
								GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động mở DTĐN: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_4)) : ("Auto open one eye dungeon: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_4)), 0);
								break;
							}
						}
					}
					else
					{
						if (GClass174.smethod_0().bool_0)
						{
							GClass174.smethod_0().method_2(new vMessage
							{
								cmd = 3,
								data = Encoding.ASCII.GetBytes(GClass174.string_0)
							});
							GClass174.smethod_0().bool_2 = false;
							GClass174.smethod_0().bool_0 = false;
						}
						else
						{
							GClass174.smethod_0().method_0(GClass199.int_0);
							GClass174.smethod_0().bool_0 = true;
						}
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Liên kết với QLTK: " + GClass193.smethod_0().method_6(GClass174.smethod_0().bool_0)) : ("Connect to game mannager: " + GClass193.smethod_0().method_6(GClass174.smethod_0().bool_0)), 0);
					}
				}
				else
					GClass7.smethod_0().method_3(47, GClass154.smethod_8(), string.Empty);
			}
			return true;
		}
	}
}
