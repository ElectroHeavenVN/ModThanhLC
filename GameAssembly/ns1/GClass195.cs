using System.Collections.Generic;
using UnityEngine;

namespace ns1
{
	public class GClass195 : GInterface0, GInterface5
	{
		public bool bool_0;

		public long long_0;

		public bool bool_1;

		public long long_1;

		public List<string> list_0 = new List<string>();

		public bool bool_2;

		public long long_2;

		public long long_3;

		public bool bool_3;

		public long long_4;

		public bool bool_4;

		public int int_0;

		public int int_1 = 0;

		public bool bool_5;

		public bool bool_6;

		public bool bool_7;

		public long long_5;

		public bool bool_8;

		public int int_2;

		public bool bool_9;

		public List<int> list_1 = new List<int>();

		public int int_3 = 0;

		public long long_6;

		public bool bool_10;

		public long long_7 = 0L;

		public bool bool_11;

		public long long_8;

		private static GClass195 gclass195_0;

		public long long_9;

		public static GClass195 smethod_0()
		{
			return (gclass195_0 != null) ? gclass195_0 : (gclass195_0 = new GClass195());
		}

		private void method_0()
		{
			GClass7.smethod_0().string_1 = "Chat";
			GClass7.smethod_0().gclass67_0.string_7 = "chat";
			GClass7.smethod_0().bool_0 = false;
		}

		public void onCancelChat()
		{
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass7.smethod_0().gclass67_0.method_21() == null || GClass7.smethod_0().gclass67_0.method_21().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
				GClass7.smethod_0().bool_0 = false;
			else if (GClass7.smethod_0().string_1.Equals((GClass192.int_0 == 0) ? "Nhập sức mạnh đệ tử muốn giới hạn" : "Fill power of disciple want to limited"))
			{
				method_2($"/petsm{int.Parse(GClass7.smethod_0().gclass67_0.method_21())}");
				method_0();
			}
			else if (GClass7.smethod_0().string_1.Equals((GClass192.int_0 == 0) ? "Nhập % HP đệ tử sử dụng đậu thần" : "Fill % HP Disciple auto use bean"))
			{
				method_2($"/pethp{int.Parse(GClass7.smethod_0().gclass67_0.method_21())}");
				method_0();
			}
			method_0();
		}

		public void method_1(string text)
		{
			GClass7.smethod_0().string_1 = text;
			GClass7.smethod_0().gclass67_0.string_7 = mResources.CHAT;
			GClass39.gclass45_0.bool_0 = false;
			GClass7.smethod_0().method_5(smethod_0(), string.Empty);
		}

		public void perform(int idAction, object p)
		{
			if (idAction != 10003)
			{
				switch (idAction)
				{
				case 101401:
				{
					GClass63 gClass = new GClass63();
					gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Tự động\nxin đậu:\n" + GClass193.smethod_0().method_7(bool_0)) : ("Auto Request\nBean:\n" + GClass193.smethod_0().method_7(bool_0)), this, 1000001, null));
					gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Tự động\nthu đậu:\n" + GClass193.smethod_0().method_7(bool_2)) : ("Auto Collect\nBean:\n" + GClass193.smethod_0().method_7(bool_2)), this, 1000002, null));
					gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Tự động\ncho đậu:\n" + GClass193.smethod_0().method_7(bool_1)) : ("Auto Give\nBean:\n" + GClass193.smethod_0().method_7(bool_1)), this, 1000003, null));
					gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Xin đậu\nđặc biệt:\n" + GClass193.smethod_0().method_7(bool_8)) : ("Special\nRequest Bean:\n" + GClass193.smethod_0().method_7(bool_8)), this, 1000004, null));
					GClass39.gclass0_0.method_2(gClass, 0);
					return;
				}
				case 101402:
					method_2("/ajump");
					return;
				case 101403:
					method_2("/petinfo");
					return;
				case 101404:
					method_2("/aflag");
					return;
				case 101405:
					method_2("/dtnsq");
					return;
				case 101406:
					method_2("/gohome");
					return;
				case 101407:
					method_2("/att");
					return;
				case 101408:
					smethod_0().method_1((GClass192.int_0 == 0) ? "Nhập sức mạnh đệ tử muốn giới hạn" : "Fill power of disciple want to limited");
					return;
				case 101409:
					smethod_0().method_1((GClass192.int_0 == 0) ? "Nhập % HP đệ tử sử dụng đậu thần" : "Fill % HP Disciple auto use bean");
					return;
				}
				switch (idAction)
				{
				case 1000001:
					method_2("/xd");
					break;
				case 1000002:
					method_2("/td");
					break;
				case 1000003:
					method_2("/cd");
					break;
				case 1000004:
					method_2("/xddb");
					break;
				}
			}
			else
			{
				GClass63 gClass2 = new GClass63();
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nđậu thần\n" : "Function\nBean", this, 101401, null));
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Auto Jump\n" + GClass193.smethod_0().method_7(bool_3)) : ("Auto Jump\n" + GClass193.smethod_0().method_7(bool_3)), this, 101402, null));
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Hiển thị\nT.tin Đ.tử:\n" + GClass193.smethod_0().method_7(bool_4)) : ("Show disciple\nInformation:\n" + GClass193.smethod_0().method_7(bool_4)), this, 101403, null));
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Auto bật\nCờ xám:\n" + GClass193.smethod_0().method_7(bool_7)) : ("Auto get\ngrey flag:\n" + GClass193.smethod_0().method_7(bool_7)), this, 101404, null));
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Train đ.tử\nné s.quái:\n" + GClass193.smethod_0().method_7(bool_6)) : ("Train disciple:\n" + GClass193.smethod_0().method_7(bool_6)), this, 101405, null));
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Auto cho\nĐ.tử về:\n" + GClass193.smethod_0().method_7(bool_10)) : ("Auto disciple\nGo home:\n" + GClass193.smethod_0().method_7(bool_10)), this, 101406, null));
				if (GClass58.smethod_1().int_14 == 1 && list_1.Count > 0)
					gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Trị thương\ntheo d.sách:\n" + GClass193.smethod_0().method_7(bool_9)) : ("Healing\nby list:\n" + GClass193.smethod_0().method_7(bool_9)), this, 101407, null));
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("G.hạn SM\nĐệ tử:\n" + ((long_7 == 0L) ? "KO G.HẠN" : GClass95.smethod_9(long_7))) : ("LIMITE DISCIPLE\nPOWER:\n" + ((long_7 == 0L) ? "UNLIMITED" : GClass95.smethod_9(long_7))), this, 101408, null));
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Sài đậu\n" + ((int_3 == 0) ? "%HP Đ.tử\nĐang tắt" : $"khi Đệ tử\ndưới {long_7}% HP")) : ("Use bean\n" + ((int_3 == 0) ? "%HP Disciple\nIs Off" : $"when Disciple\nlower than{long_7}% HP")), this, 101409, null));
				GClass39.gclass0_0.method_2(gClass2, 0);
			}
		}

		public bool method_2(string text)
		{
			switch (text)
			{
			case "/xd":
				smethod_0().bool_0 = !smethod_0().bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động xin đậu: " + GClass193.smethod_0().method_6(smethod_0().bool_0)) : ("Auto request bean: " + GClass193.smethod_0().method_6(smethod_0().bool_0)), 0);
				goto IL_06c9;
			case "/td":
				smethod_0().bool_2 = !smethod_0().bool_2;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động thu đậu: " + GClass193.smethod_0().method_6(smethod_0().bool_2)) : ("Auto collect bean: " + GClass193.smethod_0().method_6(smethod_0().bool_2)), 0);
				goto IL_06c9;
			case "/cd":
				smethod_0().bool_1 = !smethod_0().bool_1;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động cho đậu: " + GClass193.smethod_0().method_6(smethod_0().bool_1)) : ("Auto give bean: " + GClass193.smethod_0().method_6(smethod_0().bool_1)), 0);
				goto IL_06c9;
			case "/att":
				smethod_0().bool_9 = !smethod_0().bool_9;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Trị thương theo d/s: " + GClass193.smethod_0().method_6(smethod_0().bool_9)) : ("Healing by List: " + GClass193.smethod_0().method_6(smethod_0().bool_9)), 0);
				goto IL_06c9;
			case "/xddb":
				smethod_0().bool_8 = !smethod_0().bool_8;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Xin đậu đặc biệt: " + GClass193.smethod_0().method_6(smethod_0().bool_8)) : ("Special Request bean: " + GClass193.smethod_0().method_6(smethod_0().bool_8)), 0);
				goto IL_06c9;
			case "/aflag":
				bool_7 = !bool_7;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động bật cờ xám: " + GClass193.smethod_0().method_6(bool_7)) : ("Auto get grey flag: " + GClass193.smethod_0().method_6(bool_7)), 0);
				goto IL_06c9;
			case "/ttadd":
				method_22(-1);
				goto IL_06c9;
			case "/ajump":
				smethod_0().bool_3 = !smethod_0().bool_3;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động nhảy: " + GClass193.smethod_0().method_6(smethod_0().bool_3)) : ("Auto jump: " + GClass193.smethod_0().method_6(smethod_0().bool_3)), 0);
				goto IL_06c9;
			case "/dtnsq":
				smethod_0().bool_6 = !smethod_0().bool_6;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Up đệ tử né siêu quái: " + GClass193.smethod_0().method_6(smethod_0().bool_6)) : ("Train disciple: " + GClass193.smethod_0().method_6(smethod_0().bool_6)), 0);
				goto IL_06c9;
			case "/gohome":
				smethod_0().bool_10 = !smethod_0().bool_10;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động cho đệ về nhà khi tách hợp thể: " + GClass193.smethod_0().method_6(smethod_0().bool_10)) : ("Auto let disciple go home: " + GClass193.smethod_0().method_6(smethod_0().bool_10)), 0);
				goto IL_06c9;
			case "/petinfo":
				smethod_0().bool_4 = !smethod_0().bool_4;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Hiển thị thông tin đệ tử: " + GClass193.smethod_0().method_6(smethod_0().bool_4)) : ("Show disciple informations: " + GClass193.smethod_0().method_6(smethod_0().bool_4)), 0);
				goto IL_06c9;
			default:
				{
					if (GClass193.smethod_0().method_10<int>(text, "/ttadd"))
						method_22(GClass193.smethod_0().method_11<int>(text, "/ttadd"));
					else if (GClass193.smethod_0().method_10<int>(text, "/pethp"))
					{
						if (GClass193.smethod_0().method_11<int>(text, "/pethp") > 0)
						{
							int_3 = GClass193.smethod_0().method_11<int>(text, "/pethp");
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động dùng đậu khi đệ tử dưới [{int_3}%] HP" : $"Auto use bean when disciple lower than [{int_3}%] HP", 0);
						}
						else
						{
							int_3 = GClass193.smethod_0().method_11<int>(text, "/pethp");
							GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã tắt tự động dùng đậu theo %HP đệ tử" : "Turn off auto use bean by disciple %HP", 0);
						}
					}
					else
					{
						if (!GClass193.smethod_0().method_10<long>(text, "/petsm"))
							return false;
						if (GClass193.smethod_0().method_11<long>(text, "/petsm") > 0L)
						{
							long_7 = GClass193.smethod_0().method_11<long>(text, "/petsm");
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Giới hạn sức mạnh đệ tử [{long_7}]" : $"Limited disciple power to [{long_7}]", 0);
						}
						else
						{
							long_7 = GClass193.smethod_0().method_11<long>(text, "/petsm");
							GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã tắt giới hạn sức mạnh đệ tử" : "Turn off limit disciple power", 0);
						}
					}
					goto IL_06c9;
				}
				IL_06c9:
				return true;
			}
		}

		public void method_3()
		{
			method_13();
			method_14();
			method_15();
			method_12();
			method_21();
			method_9();
			method_23();
			method_24();
			method_25();
			method_26();
			method_8();
			method_7();
		}

		public void method_4(GClass76 g)
		{
			if (!GClass39.gclass45_0.bool_0 && GClass58.smethod_1().bool_38 && !GClass173.smethod_0().bool_2 && GClass39.gclass145_0 != GClass150.gclass150_0)
				g.method_31(GClass154.gclass2_11, 0, 150, 0);
			if (!bool_4)
				return;
			string[] array = new string[6]
			{
				(GClass192.int_0 == 0) ? ("- Sức mạnh: " + GClass95.smethod_9(GClass58.smethod_2().long_2)) : ("- Power: " + GClass95.smethod_9(GClass58.smethod_2().long_2)),
				(GClass192.int_0 == 0) ? ("- Tiềm năng: " + GClass95.smethod_9(GClass58.smethod_2().long_4)) : ("- Potential: " + GClass95.smethod_9(GClass58.smethod_2().long_4)),
				(GClass192.int_0 == 0) ? $"- HP: {GClass95.smethod_9(GClass58.smethod_2().int_25)}/{GClass95.smethod_9(GClass58.smethod_2().int_35)} ({GClass26.smethod_0(GClass58.smethod_2().int_25 * 100 / GClass58.smethod_2().int_35)}%)" : $"- HP: {GClass95.smethod_9(GClass58.smethod_2().int_25)}/{GClass95.smethod_9(GClass58.smethod_2().int_35)} ({GClass26.smethod_0(GClass58.smethod_2().int_25 * 100 / GClass58.smethod_2().int_35)}%)",
				(GClass192.int_0 == 0) ? $"- KI: {GClass95.smethod_9(GClass58.smethod_2().int_24)}/{GClass95.smethod_9(GClass58.smethod_2().int_36)} ({GClass26.smethod_0(GClass58.smethod_2().int_24 * 100 / GClass58.smethod_2().int_36)}%)" : $"- MP: {GClass95.smethod_9(GClass58.smethod_2().int_24)}/{GClass95.smethod_9(GClass58.smethod_2().int_36)} ({GClass26.smethod_0(GClass58.smethod_2().int_24 * 100 / GClass58.smethod_2().int_36)}%)",
				(GClass192.int_0 == 0) ? ("- SĐ: " + GClass95.smethod_9(GClass58.smethod_2().int_20) + " - Giáp: " + GClass95.smethod_9(GClass58.smethod_2().int_21)) : ("- DMG: " + GClass95.smethod_9(GClass58.smethod_2().int_20) + " - DEF: " + GClass95.smethod_9(GClass58.smethod_2().int_21)),
				null
			};
			if (GClass58.smethod_2().short_24 > 0)
				array[5] = ((GClass192.int_0 == 0) ? ("- Thể lực: " + GClass95.smethod_9(GClass58.smethod_2().int_77) + "/" + GClass95.smethod_9(GClass58.smethod_2().short_24)) : ("- STM: " + GClass95.smethod_9(GClass58.smethod_2().int_77) + "/" + GClass95.smethod_9(GClass58.smethod_2().short_24)));
			if (GClass76.int_12 == 2)
			{
				GUIStyle[] array2 = new GUIStyle[array.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = new GUIStyle(GUI.skin.label)
					{
						alignment = TextAnchor.UpperLeft,
						fontSize = 6 * GClass76.int_12,
						fontStyle = FontStyle.Bold
					};
					array2[i].normal.textColor = Color.yellow;
				}
				for (int j = 0; j < array.Length; j++)
				{
					int_0 = GClass26.smethod_2(GClass193.smethod_0().method_4(array2[j], array[j]), int_0);
					int num = int_1 + 8 * j;
					g.method_20(0, 0.8f);
					g.method_15(10, num + 1, int_0, 7);
					g.method_19(array[j], 12f, GClass76.int_12 - 3 + num, array2[j]);
				}
			}
			else
			{
				for (int k = 0; k < array.Length; k++)
				{
					int num2 = int_1 + 10 * k;
					GClass49.gclass49_15.method_6(g, array[k], 6, GClass76.int_12 - 3 + num2 + 1, GClass49.int_0);
				}
			}
		}

		public void method_5()
		{
			if (!GClass58.smethod_1().bool_38)
				return;
			try
			{
				if (GClass39.smethod_24(0, 150, GClass76.smethod_0(GClass154.gclass2_11), GClass76.smethod_1(GClass154.gclass2_11)) && !GClass39.bool_14)
				{
					GClass29.smethod_1().method_35();
					GClass39.gclass45_0.int_29 = 4;
					GClass39.gclass45_0.method_40();
					GClass39.gclass45_0.method_50();
					GClass166.smethod_0().method_127();
					GClass39.gclass45_1 = new GClass45();
					GClass39.gclass45_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
					GClass39.gclass45_1.method_15();
					GClass39.gclass45_1.method_50();
					if (GClass39.gclass45_1.bool_0)
					{
						GClass39.gclass45_0.int_29 = 0;
						GClass39.gclass45_0.string_17[21] = mResources.petMainTab;
						GClass39.gclass45_0.method_39();
						GClass39.gclass45_0.method_50();
					}
					GClass58.smethod_1().gclass136_0 = null;
					GClass39.smethod_49();
				}
			}
			catch
			{
			}
		}

		public void method_6(string s)
		{
			if (s.ToLower().Contains((mResources.language == 0) ? "sao sư phụ không đánh" : "why don't you attack, master?"))
			{
				bool_5 = true;
				method_11();
			}
		}

		public void method_7()
		{
			if (!bool_11 || !GClass58.smethod_1().bool_38)
				return;
			if (!GClass58.smethod_1().bool_4)
			{
				if (GClass138.smethod_18() - long_8 <= 1000L)
					return;
				for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
				{
					GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
					if (gClass != null)
					{
						if (gClass.gclass118_0.short_0 == 454 || gClass.gclass118_0.short_0 == 921)
						{
							GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
							long_8 = GClass138.smethod_18();
						}
						else
							bool_11 = false;
					}
				}
			}
			else
				bool_11 = false;
		}

		public void method_8()
		{
			if (!bool_8 || GClass39.int_8 % 25 != 0)
				return;
			if (int_2 == 0)
			{
				int_2++;
				GClass166.smethod_0().method_19(1, "", -1);
				return;
			}
			int_2 = 0;
			if (GClass39.gclass149_0 == null)
				GClass39.gclass149_0 = new GClass149();
			GClass162.smethod_0().close();
			GClass39.gclass145_0 = GClass39.gclass149_0;
		}

		public void method_9()
		{
			if (bool_7 && GClass58.smethod_1().sbyte_28 != 8 && GClass138.smethod_18() - long_5 > 1000L)
			{
				GClass166.smethod_0().method_131(1, 8);
				long_5 = GClass138.smethod_18();
			}
		}

		public GClass85 method_10()
		{
			GClass85 result = null;
			int num = 9999;
			for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
			{
				GClass85 gClass = (GClass85)GClass154.gclass63_9.method_3(i);
				if (gClass.int_12 != 0 && gClass.int_12 != 1 && gClass.int_6 > 0 && !gClass.bool_13 && gClass.sbyte_14 == 0 && gClass.method_16().sbyte_3 != 4)
				{
					int num2 = GClass56.smethod_24(gClass.int_8, gClass.int_9, GClass58.smethod_1().int_4, GClass58.smethod_1().int_5);
					if (num > num2)
					{
						num = num2;
						result = gClass;
					}
				}
			}
			return result;
		}

		public void method_11()
		{
			if (!bool_5)
				return;
			for (int i = 0; i < GClass154.gclass74_0.Length; i++)
			{
				GClass74 gClass = GClass154.gclass74_0[i];
				if (gClass != null && gClass.gclass53_0.sbyte_0 == 19)
					GClass154.smethod_8().method_64(gClass);
			}
			GClass63 gClass2 = new GClass63();
			bool_5 = false;
			gClass2.method_0(method_10());
			GClass154.smethod_8().method_64(GClass154.gclass74_1[0]);
			GClass166.smethod_0().method_73(gClass2, new GClass63(), 1);
		}

		public void method_12()
		{
			if (bool_3 && !GClass58.smethod_1().bool_62 && GClass58.smethod_1().int_11 == 1 && !GClass171.smethod_0().bool_0 && (GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 != 23 || GClass58.smethod_1().gclass58_4 == null) && GClass138.smethod_18() - long_4 > (GClass177.smethod_0().method_5() ? 7000 : 1000))
			{
				GClass58.smethod_1().int_4 = GClass58.smethod_1().int_4 - 5;
				GClass58.smethod_1().int_5 = GClass58.smethod_1().int_5 - 5;
				GClass166.smethod_0().method_44();
				GClass58.smethod_1().int_4 = GClass58.smethod_1().int_4 + 5;
				GClass58.smethod_1().int_5 = GClass58.smethod_1().int_5 + 5;
				GClass166.smethod_0().method_44();
				long_4 = GClass138.smethod_18();
			}
		}

		public void method_13()
		{
			if (bool_0 && GClass138.smethod_18() - long_0 > 302000L)
			{
				GClass166.smethod_0().method_19(1, "", -1);
				long_0 = GClass138.smethod_18();
			}
		}

		public void method_14()
		{
			if (!bool_1 || GClass138.smethod_18() - long_1 <= 1000L)
				return;
			if (list_0.Count <= 0)
			{
				for (int i = 0; i < GClass62.gclass63_0.method_2(); i++)
				{
					GClass62 gClass = (GClass62)GClass62.gclass63_0.method_3(i);
					if (gClass.int_6 != 0 && gClass.string_0 != GClass58.smethod_1().string_3 && gClass.int_5 != gClass.int_6)
					{
						for (int j = 0; j < 5 - gClass.int_5; j++)
						{
							GClass166.smethod_0().method_18(gClass.int_0);
						}
					}
				}
				long_1 = GClass138.smethod_18();
				return;
			}
			for (int k = 0; k < list_0.Count; k++)
			{
				string text = list_0[k];
				for (int l = 0; l < GClass62.gclass63_0.method_2(); l++)
				{
					GClass62 gClass2 = (GClass62)GClass62.gclass63_0.method_3(l);
					if (gClass2.int_6 != 0 && gClass2.string_0 == text && gClass2.int_5 != gClass2.int_6)
					{
						for (int m = 0; m < 5 - gClass2.int_5; m++)
						{
							GClass166.smethod_0().method_18(gClass2.int_0);
						}
					}
				}
				long_1 = GClass138.smethod_18();
			}
		}

		public void method_15()
		{
			if (!bool_2 || GClass1.int_37 != 21 + GClass58.smethod_1().int_14 || GClass138.smethod_18() - long_2 <= 1000L)
				return;
			int num = 0;
			for (int i = 0; i < GClass58.smethod_1().gclass121_1.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_1[i];
				if (gClass != null && gClass.gclass118_0.sbyte_0 == 6)
					num = gClass.int_30;
			}
			if (num < 20)
			{
				for (int j = 0; j < GClass58.smethod_1().gclass121_0.Length; j++)
				{
					GClass121 gClass2 = GClass58.smethod_1().gclass121_0[j];
					if (gClass2 != null && gClass2.gclass118_0.sbyte_0 == 6)
						GClass166.smethod_0().method_30(1, (sbyte)j);
				}
			}
			if (GClass154.smethod_8().gclass60_0.int_195 > 0 && (GClass154.int_37 < 20 || num < 30))
			{
				GClass166.smethod_0().method_60(4);
				GClass166.smethod_0().method_59(4, 0);
			}
			long_2 = GClass138.smethod_18();
		}

		public bool method_16(GClass85 mob)
		{
			if (mob.int_12 == 0 || mob.int_12 == 1 || mob.int_6 <= 0 || mob.bool_13)
				return false;
			bool num = bool_6 && !GClass82.smethod_0(4387);
			if (mob.sbyte_14 != 0 && num)
				return false;
			if (!method_17(mob))
				return false;
			return true;
		}

		public bool method_17(GClass85 mob)
		{
			if (GClass197.list_0.Count != 0 && !GClass197.list_0.Contains(mob.int_25))
				return false;
			if (GClass197.list_1.Count != 0 && !GClass197.list_1.Contains(mob.int_26))
				return false;
			return true;
		}

		public GClass85 method_18()
		{
			GClass85 result = null;
			int num = int.MaxValue;
			GClass58 gClass = GClass58.smethod_1();
			for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
			{
				GClass85 gClass2 = (GClass85)GClass154.gclass63_9.method_3(i);
				int num2 = (gClass2.int_16 - gClass.int_4) * (gClass2.int_16 - gClass.int_4) + (gClass2.int_17 - gClass.int_5) * (gClass2.int_17 - gClass.int_5);
				if (method_16(gClass2) && num2 < num && gClass2.method_16().sbyte_3 != 4)
				{
					result = gClass2;
					num = num2;
				}
			}
			return result;
		}

		public GClass85 method_19()
		{
			GClass85 result = null;
			long num = GClass138.smethod_18();
			for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
			{
				GClass85 gClass = (GClass85)GClass154.gclass63_9.method_3(i);
				if (method_16(gClass) && gClass.long_0 < num)
				{
					result = gClass;
					num = gClass.long_0;
				}
			}
			return result;
		}

		public bool method_20(GClass85 mob)
		{
			if (mob.bool_13)
				return false;
			if (!method_17(mob))
				return false;
			if (bool_6 && !GClass82.smethod_0(4387) && mob.method_16().int_0 >= 3000)
			{
				if (mob.sbyte_14 != 0)
				{
					GClass85 gClass = null;
					bool flag = false;
					for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
					{
						gClass = (GClass85)GClass154.gclass63_9.method_3(i);
						if (gClass.int_0 == 10 && (gClass.int_12 == 0 || gClass.int_12 == 1))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
						return false;
					mob.long_0 = gClass.long_0;
				}
				else if (mob.int_0 == 10 && (mob.int_12 == 0 || mob.int_12 == 1))
				{
					return false;
				}
			}
			return true;
		}

		public void method_21()
		{
			if (!bool_6 || !GClass58.smethod_1().bool_38)
				return;
			bool flag = GClass154.smethod_14(-GClass58.smethod_1().int_13) != null;
			bool flag2 = GClass58.smethod_2().sbyte_15 == 1;
			if (GClass138.smethod_18() - long_9 > 1000L)
			{
				if (!flag2)
				{
					GClass166.smethod_0().method_133(1);
					long_9 = GClass138.smethod_18();
					return;
				}
				if (!flag)
				{
					for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
					{
						GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
						if (gClass != null)
						{
							if (gClass.gclass118_0.short_0 == 454)
							{
								GClass166.smethod_0().method_20(0, 1, -1, 454);
								long_9 = GClass138.smethod_18();
							}
							else if (gClass.gclass118_0.short_0 == 921)
							{
								GClass166.smethod_0().method_20(0, 1, -1, 921);
								long_9 = GClass138.smethod_18();
							}
							else
							{
								GClass166.smethod_0().method_42(GClass1.int_39, -1);
								long_9 = GClass138.smethod_18();
							}
							return;
						}
					}
				}
			}
			bool flag3 = GClass82.smethod_0(4387);
			GClass58 gClass2 = GClass58.smethod_1();
			gClass2.method_102(0);
			if (gClass2.gclass85_0 != null && !method_16(gClass2.gclass85_0))
				gClass2.gclass85_0 = null;
			if (gClass2.gclass85_0 == null)
			{
				gClass2.gclass85_0 = method_18();
				if (flag3 && gClass2.gclass85_0 != null)
					GClass191.smethod_0().method_25(gClass2.gclass85_0.int_16 - 24, gClass2.gclass85_0.int_17);
			}
			if (gClass2.gclass85_0 != null)
			{
				GClass85 gclass85_ = gClass2.gclass85_0;
				gclass85_.int_8 = gclass85_.int_16;
				gclass85_.int_9 = gclass85_.int_17;
				if (GClass56.smethod_24(gclass85_.int_16, gclass85_.int_17, gClass2.int_4, gClass2.int_5) > 48 || gclass85_.int_6 <= 1)
					GClass197.smethod_0().method_11(gclass85_.int_16, gclass85_.int_17);
			}
			else if (!flag3)
			{
				GClass85 gClass3 = method_19();
				if (gClass3 != null)
					GClass197.smethod_0().method_11(gClass3.int_16 - 24, gClass3.int_17);
			}
		}

		public void method_22(int index)
		{
			if (index != -1)
			{
				if (list_1.Contains(index))
				{
					list_1.Remove(index);
					GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa [{index}] khỏi d/s trị thương" : $"Deleted [{index}] from list healing", 0);
				}
				else
				{
					list_1.Add(index);
					GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm [{index}] vào d/s trị thương" : $"Added [{index}] to list healing", 0);
				}
			}
			else if (GClass58.smethod_1().gclass58_0 != null)
			{
				GClass58 gclass58_ = GClass58.smethod_1().gclass58_0;
				if (list_1.Contains(gclass58_.int_13))
				{
					list_1.Remove(gclass58_.int_13);
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã xóa [" + gclass58_.string_3 + "] khỏi d/s trị thương") : ("Deleted [" + gclass58_.string_3 + "] from list healing"), 0);
				}
				else
				{
					list_1.Add(gclass58_.int_13);
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm [" + gclass58_.string_3 + "] vào d/s trị thương") : ("Added [" + gclass58_.string_3 + "] to list healing"), 0);
				}
			}
		}

		public void method_23()
		{
			if (!bool_9)
				return;
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				if (!(GClass154.gclass63_5.method_3(i) is GClass58 gClass) || !list_1.Contains(gClass.int_13) || (gClass.int_25 >= gClass.int_35 * 10 / 100 && gClass.int_25 > 1 && !gClass.bool_62))
					continue;
				for (int j = 0; j < GClass154.gclass74_0.Length; j++)
				{
					GClass74 gClass2 = GClass154.gclass74_0[j];
					if (gClass2 == null || GClass138.smethod_18() - gClass2.long_1 <= gClass2.int_1 + 100 || gClass2.gclass53_0.int_3 != 2)
						continue;
					int num = 0;
					int num2 = ((gClass2.gclass53_0.int_2 == 2) ? 1 : ((gClass2.gclass53_0.int_2 == 1) ? (gClass2.int_5 * GClass58.smethod_1().int_36 / 100) : gClass2.int_5));
					if (GClass58.smethod_1().int_24 >= num2)
					{
						if (gClass2 == GClass58.smethod_1().gclass74_0)
						{
							GClass63 gClass3 = new GClass63();
							gClass3.method_0(GClass58.smethod_1());
							GClass166.smethod_0().method_73(new GClass63(), gClass3, -1);
							gClass2.long_1 = GClass138.smethod_18();
							break;
						}
						GClass154.smethod_8().method_62(gClass2, true);
						return;
					}
				}
			}
		}

		public void method_24()
		{
			if (int_3 != 0 && GClass58.smethod_1().bool_38 && GClass138.smethod_18() - long_6 > 5000L && GClass58.smethod_2().int_25 <= GClass58.smethod_2().int_35 * int_3 / 100)
			{
				GClass154.smethod_8().method_50();
				long_6 = GClass138.smethod_18();
			}
		}

		public void method_25()
		{
			if (GClass39.int_8 % 10 == 0 && GClass58.smethod_1().bool_38 && bool_10 && !GClass58.smethod_1().bool_4 && GClass58.smethod_2().sbyte_15 != 3 && GClass58.smethod_2().sbyte_15 != 3)
				GClass166.smethod_0().method_133(3);
		}

		public void method_26()
		{
			if (long_7 != 0L && GClass58.smethod_1().bool_38 && GClass58.smethod_2().long_2 >= long_7)
				Application.Quit();
		}
	}
}
