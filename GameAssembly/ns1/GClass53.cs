using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns1
{
	public class GClass53
	{
		public const int int_0 = 23;

		public string[][] string_0 = new string[5][]
		{
			(GClass62.int_0 == 0) ? new string[2] { "D.sách", "Item" } : new string[2] { "List", "Item" },
			(GClass62.int_0 != 0) ? new string[2] { "Graphic", "Setting" } : new string[2] { "Cài đặt", "Đồ họa" },
			(GClass62.int_0 == 0) ? new string[2] { "T.báo", "Boss" } : new string[2] { "Boss", "Nofiti.." },
			(GClass62.int_0 == 0) ? new string[2] { "D.sách", "Map" } : new string[2] { "Menu", "Xmap" },
			(GClass62.int_0 != 0) ? new string[2] { "Version", "Info" } : new string[2] { "Thông", "tin" }
		};

		public int[] int_2 = new int[23]
		{
			521, 382, 383, 381, 384, 385, 663, 664, 665, 666,
			667, 379, 764, 880, 881, 882, 1152, 1151, 1150, 1153,
			1154, 1517, 1518
		};

		public string[] string_1 = new string[20]
		{
			(GClass62.int_0 != 0) ? "Hide Character" : "Ẩn nhân vật",
			(GClass62.int_0 != 0) ? "Hide Mob" : "Ẩn quái",
			(GClass62.int_0 == 0) ? "Ẩn Npc" : "Hide Npc",
			(GClass62.int_0 == 0) ? "Ẩn item" : "Hide item",
			(GClass62.int_0 != 0) ? "Hide effects" : "Ẩn hiệu ứng",
			(GClass62.int_0 == 0) ? "Ẩn cây cối, đá, ..." : "Hide Tilemap",
			(GClass62.int_0 != 0) ? "Hide backpack" : "Ẩn phụ kiện đeo lưng",
			(GClass62.int_0 == 0) ? "Ẩn thông báo máy chủ" : "Hide server notification",
			(GClass62.int_0 == 0) ? "Ẩn giao diện game" : "Hide game UI",
			(GClass62.int_0 == 0) ? "Ẩn địa hình" : "Hide terrain",
			(GClass62.int_0 != 0) ? "Optimize terrain" : "Tinh giảm địa hình",
			(GClass62.int_0 != 0) ? "Hide game Image" : "Ẩn hình ảnh game",
			(GClass62.int_0 == 0) ? "Bật nền màu RGB" : "Turn on RGB Color wallpaper",
			(GClass62.int_0 == 0) ? "Bật hình nền" : "Turn on Image wallpaper",
			(GClass62.int_0 == 0) ? "Tối ưu CPU" : "Optimize CPU",
			(GClass62.int_0 != 0) ? "Freeze Mob Image" : "Đóng băng quái",
			(GClass62.int_0 != 0) ? "Show FPS" : "Hiển thị FPS",
			(GClass62.int_0 != 0) ? "Hide World's chat" : "Ẩn chat thế giới",
			(GClass62.int_0 != 0) ? "Hide mount" : "Ẩn thú cưỡi",
			(GClass62.int_0 != 0) ? "Hide chat multi-server" : "Ẩn chat liên server"
		};

		public string[] string_2 = new string[5] { "Dragon Ball Pro [2.3.7]", "Facebook", "Youtube", "Website", "Version Information" };

		private static GClass53 gclass53_0;

		public int int_3 = 0;

		public static List<GClass44> list_0 = new List<GClass44>();

		public static List<GClass203> list_1 = new List<GClass203>();

		public int Int32_0 { get; set; }

        public static GClass53 smethod_0()
		{
			return (gclass53_0 != null) ? gclass53_0 : (gclass53_0 = new GClass53());
		}

		public void method_0()
		{
			GClass88.gclass88_0 = null;
			GClass86.gclass122_1.method_9();
			GClass86.gclass122_3.method_9();
			GClass96.smethod_5();
			if (GClass14.gclass116_0 != null)
				GClass14.gclass116_0.method_7();
			GClass14.gclass113_0.gclass88_0 = null;
		}

		public void method_1(int type)
		{
			GClass14.gclass113_0.int_28 = 23;
			Int32_0 = type;
			method_2();
		}

		public void method_2()
		{
			GClass147.smethod_1().method_1();
			GClass14.gclass113_0.method_5(0);
			if (Int32_0 == 0)
			{
				GClass14.gclass113_0.string_17[23] = string_0;
				GClass14.gclass113_0.method_5(0);
				method_3();
			}
		}

		public void method_3()
		{
			if (Int32_0 == 0)
				method_4();
		}

		public void method_4()
		{
			GClass14.gclass113_0.int_4 = 24;
			switch (GClass14.gclass113_0.int_29)
			{
			case 0:
				GClass14.gclass113_0.int_41 = int_2.Length;
				break;
			case 1:
				GClass14.gclass113_0.int_41 = string_1.Length;
				break;
			case 2:
				GClass14.gclass113_0.int_41 = GClass44.string_2.Length;
				GClass14.gclass113_0.int_4 = 18;
				break;
			case 3:
				GClass46.smethod_0().method_4();
				GClass14.gclass113_0.int_41 = GClass46.smethod_0().list_0.Count;
				GClass14.gclass113_0.int_4 = 18;
				break;
			case 4:
				GClass14.gclass113_0.int_41 = string_2.Length;
				break;
			}
			GClass14.gclass113_0.int_67 = (GClass14.bool_5 ? (-1) : 0);
			GClass14.gclass113_0.int_11 = GClass14.gclass113_0.int_41 * GClass14.gclass113_0.int_4 - GClass14.gclass113_0.int_61;
			if (GClass14.gclass113_0.int_11 < 0)
				GClass14.gclass113_0.int_11 = 0;
			GClass14.gclass113_0.int_8 = (GClass14.gclass113_0.int_7 = GClass14.gclass113_0.int_13[GClass14.gclass113_0.int_29]);
			if (GClass14.gclass113_0.int_8 < 0)
			{
				GClass113 gclass113_ = GClass14.gclass113_0;
				GClass113 gclass113_2 = GClass14.gclass113_0;
				int num = 0;
				gclass113_2.int_7 = 0;
				gclass113_.int_8 = 0;
			}
			if (GClass14.gclass113_0.int_8 > GClass14.gclass113_0.int_11)
				GClass14.gclass113_0.int_8 = (GClass14.gclass113_0.int_7 = GClass14.gclass113_0.int_11);
		}

		public void method_5(GClass193 g)
		{
			if (Int32_0 == 0)
				method_7(g);
		}

		public void method_6()
		{
			switch (GClass14.gclass113_0.int_29)
			{
			case 0:
				method_9(GClass14.gclass113_0.int_67);
				break;
			case 1:
				method_12(GClass14.gclass113_0.int_67);
				break;
			case 2:
				method_14(GClass14.gclass113_0.int_67);
				break;
			case 3:
				method_22(GClass14.gclass113_0.int_67);
				break;
			case 4:
				method_20(GClass14.gclass113_0.int_67);
				break;
			}
		}

		public void method_7(GClass193 g)
		{
			switch (GClass14.gclass113_0.int_29)
			{
			case 0:
				method_8(g);
				break;
			case 1:
				method_11(g);
				break;
			case 2:
				method_13(g);
				break;
			case 3:
				method_21(g);
				break;
			case 4:
				method_19(g);
				break;
			}
		}

		public void method_8(GClass193 g)
		{
			g.method_5(GClass14.gclass113_0.int_58, GClass14.gclass113_0.int_59, GClass14.gclass113_0.int_60, GClass14.gclass113_0.int_61);
			g.method_1(0, -GClass14.gclass113_0.int_8);
			for (int i = 0; i < int_2.Length; i++)
			{
				int int_ = GClass14.gclass113_0.int_58;
				int num = GClass14.gclass113_0.int_59 + i * GClass14.gclass113_0.int_4;
				int w = GClass14.gclass113_0.int_60 - 1;
				int h = GClass14.gclass113_0.int_4 - 1;
				if (num - GClass14.gclass113_0.int_8 > GClass14.gclass113_0.int_59 + GClass14.gclass113_0.int_61 || num - GClass14.gclass113_0.int_8 < GClass14.gclass113_0.int_59 - GClass14.gclass113_0.int_4)
					continue;
				g.method_20((i != GClass14.gclass113_0.int_67) ? 0 : 0, 0.5f);
				g.method_15(int_, num, w, h);
				if (GClass193.int_12 != 2)
				{
					if (GClass193.int_12 == 1)
						GClass104.gclass104_3.method_6(g, GClass17.smethod_1((short)int_2[i]).string_0 + " " + ((GClass42.smethod_0().method_20(int_2[i], "id") > 0) ? string.Format("(x{0})", GClass42.smethod_0().method_20(int_2[i], "id")) : string.Empty), int_ + 30, num, 0);
				}
				else
					GClass104.gclass104_20.method_9(g, GClass17.smethod_1((short)int_2[i]).string_0 + " " + ((GClass42.smethod_0().method_20(int_2[i], "id") > 0) ? string.Format("(x{0})", GClass42.smethod_0().method_20(int_2[i], "id")) : string.Empty), int_ + 30, num, 0, GClass104.gclass104_6);
				GClass72.smethod_6(g, GClass17.smethod_1((short)int_2[i]).short_1, int_ + 2, num + 2, 0, 0);
				string st = ((GClass62.int_0 != 0) ? "CLICK TO AUTO USE" : "ẤN ĐỂ TỰ ĐỘNG DÙNG");
				GClass104 gClass = ((GClass42.smethod_0().method_20(int_2[i], "id") > 0) ? GClass104.gclass104_15 : GClass104.gclass104_6);
				foreach (GClass42.GStruct6 item in GClass42.smethod_0().list_6)
				{
					if (item.int_0 == GClass17.smethod_1((short)int_2[i]).short_1)
					{
						gClass = GClass104.gclass104_1;
						g.method_20((i != GClass14.gclass113_0.int_67) ? 0 : 0, 0.5f);
						g.method_15(int_, num, w, h);
						st = ((GClass62.int_0 != 0) ? "CLICK TO STOP AUTO" : "ẤN ĐỂ DỪNG TỰ ĐỘNG");
					}
				}
				if (GClass42.smethod_0().method_20(int_2[i], "id") > 0)
					gClass.method_6(g, st, int_ + 30, num + 11, 0);
			}
			GClass14.gclass113_0.method_100(g);
		}

		public void method_9(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass != null)
				{
					if (!GClass42.smethod_0().method_20(int_2[selected], "id").Equals(0))
					{
						if (GClass42.smethod_0().method_20(int_2[selected], "id") > 0 && gClass.gclass203_0.short_1 == GClass17.smethod_1((short)int_2[selected]).short_1)
							GClass42.smethod_0().method_18(gClass);
						continue;
					}
					GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? "You don't have this item" : "Mày làm đéo gì có Item ?", 0);
					break;
				}
				break;
			}
		}

		public string method_10(int index)
		{
			int num = GClass62.int_0;
			if (num == 0)
			{
				switch (index)
				{
				default:
					return string.Empty;
				case 0:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_5);
				case 1:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_7);
				case 2:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_6);
				case 3:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_8);
				case 4:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_9);
				case 5:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_10);
				case 6:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_11);
				case 7:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_13);
				case 8:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_17);
				case 9:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_18);
				case 10:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_19);
				case 11:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_21);
				case 12:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_14);
				case 13:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_15);
				case 14:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_20);
				case 15:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_4);
				case 16:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_1);
				case 17:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_16);
				case 18:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_12);
				case 19:
					return "Trạng thái: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_0);
				}
			}
			if (num != 1)
				return string.Empty;
			switch (index)
			{
			default:
				return string.Empty;
			case 0:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_5);
			case 1:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_7);
			case 2:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_6);
			case 3:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_8);
			case 4:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_9);
			case 5:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_10);
			case 6:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_11);
			case 7:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_13);
			case 8:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_17);
			case 9:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_18);
			case 10:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_19);
			case 11:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_21);
			case 12:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_14);
			case 13:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_15);
			case 14:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_20);
			case 15:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_4);
			case 16:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_1);
			case 17:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_16);
			case 18:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_12);
			case 19:
				return "Status: " + GClass45.smethod_0().method_7(GClass66.smethod_0().bool_0);
			}
		}

		public void method_11(GClass193 g)
		{
			g.method_5(GClass14.gclass113_0.int_58, GClass14.gclass113_0.int_59, GClass14.gclass113_0.int_60, GClass14.gclass113_0.int_61);
			g.method_1(0, -GClass14.gclass113_0.int_8);
			for (int i = 0; i < string_1.Length; i++)
			{
				int int_ = GClass14.gclass113_0.int_58;
				int num = GClass14.gclass113_0.int_59 + i * GClass14.gclass113_0.int_4;
				int w = GClass14.gclass113_0.int_60 - 1;
				int h = GClass14.gclass113_0.int_4 - 1;
				if (num - GClass14.gclass113_0.int_8 <= GClass14.gclass113_0.int_59 + GClass14.gclass113_0.int_61 && num - GClass14.gclass113_0.int_8 >= GClass14.gclass113_0.int_59 - GClass14.gclass113_0.int_4)
				{
					g.method_20((i != GClass14.gclass113_0.int_67) ? 0 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass104.gclass104_20.method_6(g, i + 1 + ". " + string_1[i], int_ + 5, num, 0);
					if (method_10(i).Contains((GClass62.int_0 == 0) ? "Trạng thái: Đang bật" : "Status: Is On"))
					{
						g.method_20((i != GClass14.gclass113_0.int_67) ? 0 : 0, 0.5f);
						g.method_15(int_, num, w, h);
					}
					((method_10(i) == ((GClass62.int_0 != 0) ? "Status: Is On" : "Trạng thái: Đang bật")) ? GClass104.gclass104_15 : GClass104.gclass104_11).method_6(g, method_10(i), int_ + 5, num + 11, 0);
				}
			}
		}

		public void method_12(int selected)
		{
			if (selected == -1)
				return;
			switch (selected)
			{
			case 0:
				GClass66.smethod_0().bool_5 = !GClass66.smethod_0().bool_5;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide character: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_5)) : ("Ẩn người: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_5)), 0);
				break;
			case 1:
				GClass66.smethod_0().bool_7 = !GClass66.smethod_0().bool_7;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide mob: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_7)) : ("Ẩn quái: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_7)), 0);
				break;
			case 2:
				GClass66.smethod_0().bool_6 = !GClass66.smethod_0().bool_6;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide Npc: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_6)) : ("Ẩn NPC: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_6)), 0);
				break;
			case 3:
				GClass66.smethod_0().bool_8 = !GClass66.smethod_0().bool_8;
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Ẩn Item: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_8)) : ("Hide Item: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_8)), 0);
				break;
			case 4:
				GClass66.smethod_0().bool_9 = !GClass66.smethod_0().bool_9;
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Ẩn hiệu ứng: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_9)) : ("Hide Effects: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_9)), 0);
				break;
			case 5:
				GClass66.smethod_0().bool_10 = !GClass66.smethod_0().bool_10;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide TileMaps,....: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_10)) : ("Ẩn cây cối, đá,....: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_10)), 0);
				break;
			case 6:
				GClass66.smethod_0().bool_11 = !GClass66.smethod_0().bool_11;
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Ẩn phụ kiện đeo lưng: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_11)) : ("Hide Backpack: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_11)), 0);
				break;
			case 7:
				GClass66.smethod_0().bool_13 = !GClass66.smethod_0().bool_13;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide server nofitication: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_13)) : ("Ẩn thông báo máy chủ: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_13)), 0);
				break;
			case 8:
				GClass66.smethod_0().bool_17 = !GClass66.smethod_0().bool_17;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide game UI: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_17)) : ("Ẩn giao diện game: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_17)), 0);
				break;
			case 9:
				GClass66.smethod_0().bool_18 = !GClass66.smethod_0().bool_18;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide Terrain: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_18)) : ("Ẩn địa hình: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_18)), 0);
				break;
			case 10:
				GClass66.smethod_0().bool_19 = !GClass66.smethod_0().bool_19;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Optimize Terrain: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_19)) : ("Tinh giảm địa hình: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_19)), 0);
				break;
			case 11:
				GClass66.smethod_0().bool_21 = !GClass66.smethod_0().bool_21;
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Ẩn hình ảnh game: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_21)) : ("Hide game Image: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_21)), 0);
				break;
			case 12:
				if (!GClass66.smethod_0().bool_14)
				{
					GClass66.smethod_0().method_1((GClass62.int_0 != 0) ? "Fill color code R,G,B" : "Nhập mã màu R,G,B");
					GClass66.smethod_0().bool_14 = true;
				}
				else
					GClass66.smethod_0().bool_14 = false;
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Bật hình nền Color RGB: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_14)) : ("Wallpaper Color RGB: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_14)), 0);
				break;
			case 13:
				GClass66.smethod_0().bool_15 = !GClass66.smethod_0().bool_15;
				if (File.Exists("Data/wallpaper.png"))
					GClass66.smethod_0().gclass20_0 = GClass66.smethod_0().method_4("Data/wallpaper.png", GClass193.int_12);
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Image wallpaper: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_15)) : ("Bật hình nền ảnh: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_15)), 0);
				break;
			case 14:
				GClass66.smethod_0().bool_20 = !GClass66.smethod_0().bool_20;
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tối ưu CPU: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_20)) : ("Optimize CPU: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_20)), 0);
				break;
			case 15:
				GClass66.smethod_0().bool_4 = !GClass66.smethod_0().bool_4;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Freeze Mob Image: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_4)) : ("Đóng băng quái: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_4)), 0);
				break;
			case 16:
				GClass66.smethod_0().bool_1 = !GClass66.smethod_0().bool_1;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Show FPS: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_1)) : ("Hiển thị FPS: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_1)), 0);
				break;
			case 17:
				GClass66.smethod_0().bool_16 = !GClass66.smethod_0().bool_16;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide world's chat: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_16)) : ("Ẩn kênh chat thế giới: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_16)), 0);
				break;
			case 18:
				GClass66.smethod_0().bool_12 = !GClass66.smethod_0().bool_12;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Hide mount: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_12)) : ("Ẩn thú cưỡi: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_12)), 0);
				break;
			case 19:
				GClass66.smethod_0().bool_0 = !GClass66.smethod_0().bool_0;
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Ẩn chat liên vũ trụ: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_0)) : ("Hide multi-server chat: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_0)), 0);
				break;
			}
		}

		public void method_13(GClass193 g)
		{
			g.method_5(GClass14.gclass113_0.int_58, GClass14.gclass113_0.int_59, GClass14.gclass113_0.int_60, GClass14.gclass113_0.int_61);
			g.method_1(0, -GClass14.gclass113_0.int_8);
			for (int i = 0; i < ((GClass62.int_0 != 0) ? GClass44.string_3.Length : GClass44.string_2.Length); i++)
			{
				int int_ = GClass14.gclass113_0.int_58;
				int num = GClass14.gclass113_0.int_59 + i * GClass14.gclass113_0.int_4;
				int w = GClass14.gclass113_0.int_60 - 1;
				int h = GClass14.gclass113_0.int_4 - 1;
				if (num - GClass14.gclass113_0.int_8 <= GClass14.gclass113_0.int_59 + GClass14.gclass113_0.int_61 && num - GClass14.gclass113_0.int_8 >= GClass14.gclass113_0.int_59 - GClass14.gclass113_0.int_4)
				{
					g.method_16((i != GClass14.gclass113_0.int_67) ? 15260884 : 16383818);
					g.method_15(int_, num, w, h);
					GClass104.gclass104_6.method_6(g, (GClass62.int_0 == 0) ? GClass44.string_2[i] : GClass44.string_3[i], GClass14.gclass113_0.int_58 + GClass14.gclass113_0.int_60 / 2, num + 3, GClass104.int_2);
				}
			}
			GClass14.gclass113_0.method_100(g);
		}

		public void method_14(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < ((GClass62.int_0 != 0) ? GClass44.string_3.Length : GClass44.string_2.Length); i++)
			{
				if (i == selected)
				{
					method_16(i);
					int_3 = i;
				}
			}
		}

		public void method_15(GClass193 g)
		{
			g.method_5(GClass14.gclass113_0.int_58, GClass14.gclass113_0.int_59, GClass14.gclass113_0.int_60, GClass14.gclass113_0.int_61);
			g.method_1(0, -GClass14.gclass113_0.int_8);
			for (int i = 0; i < list_0.Count; i++)
			{
				int int_ = GClass14.gclass113_0.int_58;
				int num = GClass14.gclass113_0.int_59 + i * 36;
				int w = GClass14.gclass113_0.int_60 - 1;
				int h = 35;
				if (num - GClass14.gclass113_0.int_8 <= GClass14.gclass113_0.int_59 + GClass14.gclass113_0.int_61 && num - GClass14.gclass113_0.int_8 >= GClass14.gclass113_0.int_59 - 36)
				{
					g.method_16(15260884);
					g.method_15(int_, num, w, h);
					GClass45.smethod_0().method_2(GClass104.gclass104_6, g, list_0[i].string_0 ?? "", int_ + 5, num, 0, GClass104.gclass104_3, "border");
					GClass104.gclass104_11.method_6(g, (GClass62.int_0 != 0) ? ("Location: " + list_0[i].string_1) : ("Địa điểm: " + list_0[i].string_1), int_ + 5, num + 11, 0);
					GClass104.gclass104_11.method_6(g, (GClass62.int_0 == 0) ? ("Thời gian xuất hiện: " + list_0[i].dateTime_0.ToString("HH:mm:ss")) : ("Time Appear: " + list_0[i].dateTime_0.ToString("HH:mm:ss")), int_ + 5, num + 22, 0);
					GClass45.smethod_0().method_2(GClass104.gclass104_1, g, (GClass62.int_0 != 0) ? ("[" + GClass44.smethod_4(list_0[i]) + " ago]") : ("[" + GClass44.smethod_4(list_0[i]) + " trước]"), GClass14.gclass113_0.int_58 + GClass14.gclass113_0.int_60, GClass14.gclass113_0.int_59 + i * 36, GClass104.int_1, GClass104.gclass104_6, "noborder");
				}
			}
		}

		public void method_16(int selected)
		{
			List<GClass44> list = new List<GClass44>();
			switch (selected)
			{
			case 0:
				method_17(GClass44.list_2);
				GClass14.gclass113_0.method_50();
				break;
			case 1:
				method_17(GClass44.list_3);
				GClass14.gclass113_0.method_50();
				break;
			case 2:
				method_17(GClass44.list_4);
				GClass14.gclass113_0.method_50();
				break;
			case 3:
				method_17(GClass44.list_5);
				GClass14.gclass113_0.method_50();
				break;
			case 4:
				method_17(GClass44.list_6);
				GClass14.gclass113_0.method_50();
				break;
			case 5:
				method_17(GClass44.list_7);
				GClass14.gclass113_0.method_50();
				break;
			case 6:
				method_17(GClass44.list_8);
				GClass14.gclass113_0.method_50();
				break;
			case 7:
				method_17(GClass44.list_9);
				GClass14.gclass113_0.method_50();
				break;
			case 8:
				method_17(GClass44.list_10);
				GClass14.gclass113_0.method_50();
				break;
			case 9:
				method_17(GClass44.list_11);
				GClass14.gclass113_0.method_50();
				break;
			case 10:
				method_17(GClass44.list_12);
				GClass14.gclass113_0.method_50();
				break;
			case 11:
				method_17(GClass44.list_13);
				GClass14.gclass113_0.method_50();
				break;
			case 12:
				method_17(GClass44.list_14);
				GClass14.gclass113_0.method_50();
				break;
			case 13:
				method_17(GClass44.list_15);
				GClass14.gclass113_0.method_50();
				break;
			case 14:
				method_17(GClass44.list_16);
				GClass14.gclass113_0.method_50();
				break;
			case 15:
				method_17(GClass44.list_17);
				GClass14.gclass113_0.method_50();
				break;
			case 16:
				method_17(GClass44.list_18);
				GClass14.gclass113_0.method_50();
				break;
			case 17:
				method_17(GClass44.list_19);
				GClass14.gclass113_0.method_50();
				break;
			case 18:
				method_17(GClass44.list_20);
				GClass14.gclass113_0.method_50();
				break;
			}
		}

		private void method_17(List<GClass44> list_2)
		{
			list_0 = list_2;
			GClass14.gclass113_0.int_41 = list_2.Count;
			GClass14.gclass113_0.int_4 = 36;
			GClass14.gclass113_0.int_11 = GClass14.gclass113_0.int_41 * 36 - GClass14.gclass113_0.int_61;
			if (GClass14.gclass113_0.int_11 < 0)
				GClass14.gclass113_0.int_11 = 0;
			if (GClass14.gclass113_0.int_8 < 0)
			{
				GClass113 gclass113_ = GClass14.gclass113_0;
				GClass113 gclass113_2 = GClass14.gclass113_0;
				int num = 0;
				gclass113_2.int_7 = 0;
				gclass113_.int_8 = 0;
			}
			if (GClass14.gclass113_0.int_8 > GClass14.gclass113_0.int_11)
				GClass14.gclass113_0.int_8 = (GClass14.gclass113_0.int_7 = GClass14.gclass113_0.int_11);
			GClass14.gclass113_0.int_28 = 100;
			GClass14.gclass113_0.method_5(0);
		}

		public string method_18(int index)
		{
			switch (index)
			{
			default:
				return string.Empty;
			case 0:
				return "Dragon Boy Pro Released";
			case 1:
				return (GClass62.int_0 == 0) ? "Ấn vào để xem thêm" : "View";
			case 2:
				return (GClass62.int_0 != 0) ? "View" : "Ấn vào để xem thêm";
			case 3:
				return (GClass62.int_0 == 0) ? "Ấn vào để xem thêm" : "View";
			case 4:
				return (GClass62.int_0 != 0) ? ("Newest Update: " + GClass62.string_0) : ("Cập nhật mới nhất: " + GClass62.string_0);
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < 2000; i++)
			{
				if (GClass17.smethod_1((short)i) != null)
					list_1.Add(GClass17.smethod_1((short)i));
			}
		}

		public void method_19(GClass193 g)
		{
			g.method_5(GClass14.gclass113_0.int_58, GClass14.gclass113_0.int_59, GClass14.gclass113_0.int_60, GClass14.gclass113_0.int_61);
			g.method_1(0, -GClass14.gclass113_0.int_8);
			for (int i = 0; i < string_2.Length; i++)
			{
				int int_ = GClass14.gclass113_0.int_58;
				int num = GClass14.gclass113_0.int_59 + i * GClass14.gclass113_0.int_4;
				int w = GClass14.gclass113_0.int_60 - 1;
				int h = GClass14.gclass113_0.int_4 - 1;
				if (num - GClass14.gclass113_0.int_8 <= GClass14.gclass113_0.int_59 + GClass14.gclass113_0.int_61 && num - GClass14.gclass113_0.int_8 >= GClass14.gclass113_0.int_59 - GClass14.gclass113_0.int_4)
				{
					g.method_20((i != GClass14.gclass113_0.int_67) ? 0 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass104.gclass104_20.method_6(g, i + 1 + ". " + string_2[i], int_ + 5, num, 0);
					GClass104.gclass104_15.method_6(g, method_18(i), int_ + 5, num + 11, 0);
				}
			}
		}

		public void method_20(int selected)
		{
			if (selected != -1)
			{
				switch (selected)
				{
				case 0:
					GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? "Wish you have fun playing the game" : "Chúc quý khách chơi game vui vẻ!", 0);
					break;
				case 1:
					Process.Start("https://www.facebook.com/lcthanh172");
					break;
				case 2:
					Process.Start("https://www.youtube.com/channel/UCTF2eynRVCyKpzWRWIkzAyQ");
					break;
				case 3:
					Process.Start("https://thanhlc.com/");
					break;
				}
			}
		}

		public void method_21(GClass193 g)
		{
			g.method_5(GClass14.gclass113_0.int_58, GClass14.gclass113_0.int_59, GClass14.gclass113_0.int_60, GClass14.gclass113_0.int_61);
			g.method_1(0, -GClass14.gclass113_0.int_8);
			for (int i = 0; i < GClass46.smethod_0().list_0.Count; i++)
			{
				int int_ = GClass14.gclass113_0.int_58;
				int num = GClass14.gclass113_0.int_59 + i * GClass14.gclass113_0.int_4;
				int w = GClass14.gclass113_0.int_60 - 1;
				int h = GClass14.gclass113_0.int_4 - 1;
				if (num - GClass14.gclass113_0.int_8 <= GClass14.gclass113_0.int_59 + GClass14.gclass113_0.int_61 && num - GClass14.gclass113_0.int_8 >= GClass14.gclass113_0.int_59 - GClass14.gclass113_0.int_4)
				{
					g.method_20((i == GClass14.gclass113_0.int_67) ? 16383818 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass104.gclass104_3.method_6(g, $"[{i + 1}]", 10, num + 3, GClass104.int_0);
					GClass104.gclass104_3.method_6(g, GClass46.smethod_0().list_0[i].string_0, GClass14.gclass113_0.int_58 + GClass14.gclass113_0.int_60 / 2, num + 3, GClass104.int_2);
				}
			}
			GClass14.gclass113_0.method_100(g);
		}

		public void method_22(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < GClass46.smethod_0().list_0.Count; i++)
			{
				if (i == selected)
				{
					List<int> list = GClass46.smethod_0().list_0[i].list_0;
					Class11.smethod_0().method_7(list);
				}
			}
		}
	}
}
