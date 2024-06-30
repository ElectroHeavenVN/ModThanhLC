using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ns1
{
    public class GClass198
	{
		public const int int_0 = 23;

		public string[][] string_0 = new string[5][]
		{
			(GClass192.int_0 != 0) ? new string[2] { "List", "Item" } : new string[2] { "D.sách", "Item" },
			(GClass192.int_0 != 0) ? new string[2] { "Graphic", "Setting" } : new string[2] { "Cài đặt", "Đồ họa" },
			(GClass192.int_0 != 0) ? new string[2] { "Boss", "Nofiti.." } : new string[2] { "T.báo", "Boss" },
			(GClass192.int_0 != 0) ? new string[2] { "Menu", "Xmap" } : new string[2] { "D.sách", "Map" },
			(GClass192.int_0 != 0) ? new string[2] { "Version", "Info" } : new string[2] { "Thông", "tin" }
		};

		public int[] int_2 = new int[23]
		{
			521, 382, 383, 381, 384, 385, 663, 664, 665, 666,
			667, 379, 764, 880, 881, 882, 1152, 1151, 1150, 1153,
			1154, 1517, 1518
		};

		public string[] string_1 = new string[17]
		{
			(GClass192.int_0 == 0) ? "Ẩn nhân vật" : "Hide Character",
			(GClass192.int_0 == 0) ? "Ẩn quái" : "Hide Mob",
			(GClass192.int_0 == 0) ? "Ẩn Npc" : "Hide Npc",
			(GClass192.int_0 == 0) ? "Ẩn item" : "Hide item",
			(GClass192.int_0 == 0) ? "Ẩn hiệu ứng" : "Hide effects",
			(GClass192.int_0 == 0) ? "Ẩn cây cối, đá, ..." : "Hide Tilemap",
			(GClass192.int_0 == 0) ? "Ẩn phụ kiện đeo lưng" : "Hide backpack",
			(GClass192.int_0 == 0) ? "Ẩn thông báo máy chủ" : "Hide server notification",
			(GClass192.int_0 == 0) ? "Ẩn giao diện game" : "Hide game UI",
			(GClass192.int_0 == 0) ? "Ẩn địa hình" : "Hide terrain",
			(GClass192.int_0 == 0) ? "Tinh giảm địa hình" : "Optimize terrain",
			(GClass192.int_0 == 0) ? "Ẩn hình ảnh game" : "Hide game Image",
			(GClass192.int_0 == 0) ? "Bật nền màu RGB" : "Turn on RGB Color wallpaper",
			(GClass192.int_0 == 0) ? "Bật hình nền" : "Turn on Image wallpaper",
			(GClass192.int_0 == 0) ? "Tối ưu CPU" : "Optimize CPU",
			(GClass192.int_0 == 0) ? "Đóng băng quái" : "Freeze Mob Image",
			(GClass192.int_0 == 0) ? "Hiển thị FPS" : "Show FPS"
		};

		public string[] string_2 = new string[5] { "Dragon Ball Pro [2.3.7]", "Facebook", "Youtube", "Website", "Version Information" };

		private static GClass198 gclass198_0;

		public int int_3 = 0;

		public static List<GClass179> list_0 = new List<GClass179>();

		public static List<GClass118> list_1 = new List<GClass118>();

		public int Int32_0 { get; set; }

		public static GClass198 smethod_0()
		{
			return (gclass198_0 != null) ? gclass198_0 : (gclass198_0 = new GClass198());
		}

		public void method_0()
		{
			GClass70.gclass70_0 = null;
			GClass68.gclass63_1.method_9();
			GClass68.gclass63_3.method_9();
			GClass57.smethod_5();
			GClass39.gclass0_0.method_7();
			GClass39.gclass45_0.gclass70_0 = null;
		}

		public void method_1(int type)
		{
			GClass39.gclass45_0.int_28 = 23;
			Int32_0 = type;
			method_2();
		}

		public void method_2()
		{
			GClass29.smethod_1().method_1();
			GClass39.gclass45_0.method_5(0);
			if (Int32_0 == 0)
			{
				GClass39.gclass45_0.string_17[23] = string_0;
				GClass39.gclass45_0.method_5(0);
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
			GClass39.gclass45_0.int_4 = 24;
			switch (GClass39.gclass45_0.int_29)
			{
			case 0:
				GClass39.gclass45_0.int_41 = int_2.Length;
				break;
			case 1:
				GClass39.gclass45_0.int_41 = string_1.Length;
				break;
			case 2:
				GClass39.gclass45_0.int_41 = GClass179.string_2.Length;
				GClass39.gclass45_0.int_4 = 18;
				break;
			case 3:
				GClass178.smethod_0().method_4();
				GClass39.gclass45_0.int_41 = GClass178.smethod_0().list_0.Count;
				GClass39.gclass45_0.int_4 = 18;
				break;
			case 4:
				GClass39.gclass45_0.int_41 = string_2.Length;
				break;
			}
			GClass39.gclass45_0.int_66 = (GClass39.bool_5 ? (-1) : 0);
			GClass39.gclass45_0.int_11 = GClass39.gclass45_0.int_41 * GClass39.gclass45_0.int_4 - GClass39.gclass45_0.int_60;
			if (GClass39.gclass45_0.int_11 < 0)
				GClass39.gclass45_0.int_11 = 0;
			GClass39.gclass45_0.int_8 = (GClass39.gclass45_0.int_7 = GClass39.gclass45_0.int_13[GClass39.gclass45_0.int_29]);
			if (GClass39.gclass45_0.int_8 < 0)
			{
				GClass45 gclass45_ = GClass39.gclass45_0;
				GClass45 gclass45_2 = GClass39.gclass45_0;
				int num = 0;
				gclass45_2.int_7 = 0;
				gclass45_.int_8 = 0;
			}
			if (GClass39.gclass45_0.int_8 > GClass39.gclass45_0.int_11)
				GClass39.gclass45_0.int_8 = (GClass39.gclass45_0.int_7 = GClass39.gclass45_0.int_11);
		}

		public void method_5(GClass76 g)
		{
			if (Int32_0 == 0)
				method_7(g);
		}

		public void method_6()
		{
			switch (GClass39.gclass45_0.int_29)
			{
			case 0:
				method_9(GClass39.gclass45_0.int_66);
				break;
			case 1:
				method_12(GClass39.gclass45_0.int_66);
				break;
			case 2:
				method_14(GClass39.gclass45_0.int_66);
				break;
			case 3:
				method_22(GClass39.gclass45_0.int_66);
				break;
			case 4:
				method_20(GClass39.gclass45_0.int_66);
				break;
			}
		}

		public void method_7(GClass76 g)
		{
			switch (GClass39.gclass45_0.int_29)
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

		public void method_8(GClass76 g)
		{
			g.method_5(GClass39.gclass45_0.int_57, GClass39.gclass45_0.int_58, GClass39.gclass45_0.int_59, GClass39.gclass45_0.int_60);
			g.method_1(0, -GClass39.gclass45_0.int_8);
			for (int i = 0; i < int_2.Length; i++)
			{
				int int_ = GClass39.gclass45_0.int_57;
				int num = GClass39.gclass45_0.int_58 + i * GClass39.gclass45_0.int_4;
				int w = GClass39.gclass45_0.int_59 - 1;
				int h = GClass39.gclass45_0.int_4 - 1;
				if (num - GClass39.gclass45_0.int_8 > GClass39.gclass45_0.int_58 + GClass39.gclass45_0.int_60 || num - GClass39.gclass45_0.int_8 < GClass39.gclass45_0.int_58 - GClass39.gclass45_0.int_4)
					continue;
				g.method_20((i != GClass39.gclass45_0.int_66) ? 0 : 0, 0.5f);
				g.method_15(int_, num, w, h);
				if (GClass76.int_12 == 2)
					GClass49.gclass49_20.method_9(g, GClass83.smethod_1((short)int_2[i]).string_0 + " " + ((GClass183.smethod_0().method_16(int_2[i], "id") > 0) ? string.Format("(x{0})", GClass183.smethod_0().method_16(int_2[i], "id")) : string.Empty), int_ + 30, num, 0, GClass49.gclass49_6);
				else if (GClass76.int_12 == 1)
				{
					GClass49.gclass49_3.method_6(g, GClass83.smethod_1((short)int_2[i]).string_0 + " " + ((GClass183.smethod_0().method_16(int_2[i], "id") > 0) ? string.Format("(x{0})", GClass183.smethod_0().method_16(int_2[i], "id")) : string.Empty), int_ + 30, num, 0);
				}
				GClass96.smethod_6(g, GClass83.smethod_1((short)int_2[i]).short_1, int_ + 2, num + 2, 0, 0);
				string st = ((GClass192.int_0 == 0) ? "ẤN ĐỂ TỰ ĐỘNG DÙNG" : "CLICK TO AUTO USE");
				GClass49 gClass = ((GClass183.smethod_0().method_16(int_2[i], "id") > 0) ? GClass49.gclass49_15 : GClass49.gclass49_6);
				foreach (GClass183.GStruct4 item in GClass183.smethod_0().list_6)
				{
					if (item.int_0 == GClass83.smethod_1((short)int_2[i]).short_1)
					{
						gClass = GClass49.gclass49_1;
						g.method_20((i != GClass39.gclass45_0.int_66) ? 0 : 0, 0.5f);
						g.method_15(int_, num, w, h);
						st = ((GClass192.int_0 == 0) ? "ẤN ĐỂ DỪNG TỰ ĐỘNG" : "CLICK TO STOP AUTO");
					}
				}
				if (GClass183.smethod_0().method_16(int_2[i], "id") > 0)
					gClass.method_6(g, st, int_ + 30, num + 11, 0);
			}
			GClass39.gclass45_0.method_100(g);
		}

		public void method_9(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass != null)
				{
					if (!GClass183.smethod_0().method_16(int_2[selected], "id").Equals(0))
					{
						if (GClass183.smethod_0().method_16(int_2[selected], "id") > 0 && gClass.gclass118_0.short_1 == GClass83.smethod_1((short)int_2[selected]).short_1)
							GClass183.smethod_0().method_14(gClass);
						continue;
					}
					GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? "Mày làm đéo gì có Item ?" : "You don't have this item", 0);
					break;
				}
				break;
			}
		}

		public string method_10(int index)
		{
			int num = GClass192.int_0;
			if (num != 0)
			{
				if (num != 1)
					return string.Empty;
				switch (index)
				{
				default:
					return string.Empty;
				case 0:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_4);
				case 1:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_6);
				case 2:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_5);
				case 3:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_7);
				case 4:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_8);
				case 5:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_9);
				case 6:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_10);
				case 7:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_11);
				case 8:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_14);
				case 9:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_15);
				case 10:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_16);
				case 11:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_18);
				case 12:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_12);
				case 13:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_13);
				case 14:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_17);
				case 15:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_3);
				case 16:
					return "Status: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_0);
				}
			}
			switch (index)
			{
			default:
				return string.Empty;
			case 0:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_4);
			case 1:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_6);
			case 2:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_5);
			case 3:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_7);
			case 4:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_8);
			case 5:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_9);
			case 6:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_10);
			case 7:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_11);
			case 8:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_14);
			case 9:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_15);
			case 10:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_16);
			case 11:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_18);
			case 12:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_12);
			case 13:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_13);
			case 14:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_17);
			case 15:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_3);
			case 16:
				return "Trạng thái: " + GClass193.smethod_0().method_7(GClass173.smethod_0().bool_0);
			}
		}

		public void method_11(GClass76 g)
		{
			g.method_5(GClass39.gclass45_0.int_57, GClass39.gclass45_0.int_58, GClass39.gclass45_0.int_59, GClass39.gclass45_0.int_60);
			g.method_1(0, -GClass39.gclass45_0.int_8);
			for (int i = 0; i < string_1.Length; i++)
			{
				int int_ = GClass39.gclass45_0.int_57;
				int num = GClass39.gclass45_0.int_58 + i * GClass39.gclass45_0.int_4;
				int w = GClass39.gclass45_0.int_59 - 1;
				int h = GClass39.gclass45_0.int_4 - 1;
				if (num - GClass39.gclass45_0.int_8 <= GClass39.gclass45_0.int_58 + GClass39.gclass45_0.int_60 && num - GClass39.gclass45_0.int_8 >= GClass39.gclass45_0.int_58 - GClass39.gclass45_0.int_4)
				{
					g.method_20((i != GClass39.gclass45_0.int_66) ? 0 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass49.gclass49_20.method_6(g, i + 1 + ". " + string_1[i], int_ + 5, num, 0);
					if (method_10(i).Contains((GClass192.int_0 == 0) ? "Trạng thái: Đang bật" : "Status: Is On"))
					{
						g.method_20((i != GClass39.gclass45_0.int_66) ? 0 : 0, 0.5f);
						g.method_15(int_, num, w, h);
					}
					((method_10(i) == ((GClass192.int_0 == 0) ? "Trạng thái: Đang bật" : "Status: Is On")) ? GClass49.gclass49_15 : GClass49.gclass49_11).method_6(g, method_10(i), int_ + 5, num + 11, 0);
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
				GClass173.smethod_0().bool_4 = !GClass173.smethod_0().bool_4;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn người: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_4)) : ("Hide character: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_4)), 0);
				break;
			case 1:
				GClass173.smethod_0().bool_6 = !GClass173.smethod_0().bool_6;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn quái: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_6)) : ("Hide mob: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_6)), 0);
				break;
			case 2:
				GClass173.smethod_0().bool_5 = !GClass173.smethod_0().bool_5;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn NPC: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_5)) : ("Hide Npc: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_5)), 0);
				break;
			case 3:
				GClass173.smethod_0().bool_7 = !GClass173.smethod_0().bool_7;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn Item: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_7)) : ("Hide Item: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_7)), 0);
				break;
			case 4:
				GClass173.smethod_0().bool_8 = !GClass173.smethod_0().bool_8;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn hiệu ứng: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_8)) : ("Hide Effects: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_8)), 0);
				break;
			case 5:
				GClass173.smethod_0().bool_9 = !GClass173.smethod_0().bool_9;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn cây cối, đá,....: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_9)) : ("Hide TileMaps,....: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_9)), 0);
				break;
			case 6:
				GClass173.smethod_0().bool_10 = !GClass173.smethod_0().bool_10;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn phụ kiện đeo lưng: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_10)) : ("Hide Backpack: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_10)), 0);
				break;
			case 7:
				GClass173.smethod_0().bool_11 = !GClass173.smethod_0().bool_11;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn thông báo máy chủ: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_11)) : ("Hide server nofitication: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_11)), 0);
				break;
			case 8:
				GClass173.smethod_0().bool_14 = !GClass173.smethod_0().bool_14;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn giao diện game: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_14)) : ("Hide game UI: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_14)), 0);
				break;
			case 9:
				GClass173.smethod_0().bool_15 = !GClass173.smethod_0().bool_15;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn địa hình: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_15)) : ("Hide Terrain: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_15)), 0);
				break;
			case 10:
				GClass173.smethod_0().bool_16 = !GClass173.smethod_0().bool_16;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tinh giảm địa hình: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_16)) : ("Optimize Terrain: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_16)), 0);
				break;
			case 11:
				GClass173.smethod_0().bool_18 = !GClass173.smethod_0().bool_18;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Ẩn hình ảnh game: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_18)) : ("Hide game Image: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_18)), 0);
				break;
			case 12:
				if (!GClass173.smethod_0().bool_12)
				{
					GClass173.smethod_0().method_0((GClass192.int_0 == 0) ? "Nhập mã màu R,G,B" : "Fill color code R,G,B");
					GClass173.smethod_0().bool_12 = true;
				}
				else
					GClass173.smethod_0().bool_12 = false;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Bật hình nền Color RGB: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_12)) : ("Wallpaper Color RGB: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_12)), 0);
				break;
			case 13:
				GClass173.smethod_0().bool_13 = !GClass173.smethod_0().bool_13;
				if (File.Exists("Data/wallpaper.png"))
					GClass173.smethod_0().gclass2_0 = GClass173.smethod_0().method_3("Data/wallpaper.png", GClass76.int_12);
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Bật hình nền ảnh: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_13)) : ("Image wallpaper: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_13)), 0);
				break;
			case 14:
				GClass173.smethod_0().bool_17 = !GClass173.smethod_0().bool_17;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tối ưu CPU: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_17)) : ("Optimize CPU: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_17)), 0);
				break;
			case 15:
				GClass173.smethod_0().bool_3 = !GClass173.smethod_0().bool_3;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đóng băng quái: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_3)) : ("Freeze Mob Image: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_3)), 0);
				break;
			case 16:
				GClass173.smethod_0().bool_0 = !GClass173.smethod_0().bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Hiển thị FPS: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_0)) : ("Show FPS: " + GClass193.smethod_0().method_6(GClass173.smethod_0().bool_0)), 0);
				break;
			}
		}

		public void method_13(GClass76 g)
		{
			g.method_5(GClass39.gclass45_0.int_57, GClass39.gclass45_0.int_58, GClass39.gclass45_0.int_59, GClass39.gclass45_0.int_60);
			g.method_1(0, -GClass39.gclass45_0.int_8);
			for (int i = 0; i < ((GClass192.int_0 == 0) ? GClass179.string_2.Length : GClass179.string_3.Length); i++)
			{
				int int_ = GClass39.gclass45_0.int_57;
				int num = GClass39.gclass45_0.int_58 + i * GClass39.gclass45_0.int_4;
				int w = GClass39.gclass45_0.int_59 - 1;
				int h = GClass39.gclass45_0.int_4 - 1;
				if (num - GClass39.gclass45_0.int_8 <= GClass39.gclass45_0.int_58 + GClass39.gclass45_0.int_60 && num - GClass39.gclass45_0.int_8 >= GClass39.gclass45_0.int_58 - GClass39.gclass45_0.int_4)
				{
					g.method_16((i != GClass39.gclass45_0.int_66) ? 15260884 : 16383818);
					g.method_15(int_, num, w, h);
					GClass49.gclass49_6.method_6(g, (GClass192.int_0 == 0) ? GClass179.string_2[i] : GClass179.string_3[i], GClass39.gclass45_0.int_57 + GClass39.gclass45_0.int_59 / 2, num + 3, GClass49.int_2);
				}
			}
			GClass39.gclass45_0.method_100(g);
		}

		public void method_14(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < ((GClass192.int_0 == 0) ? GClass179.string_2.Length : GClass179.string_3.Length); i++)
			{
				if (i == selected)
				{
					method_16(i);
					int_3 = i;
				}
			}
		}

		public void method_15(GClass76 g)
		{
			g.method_5(GClass39.gclass45_0.int_57, GClass39.gclass45_0.int_58, GClass39.gclass45_0.int_59, GClass39.gclass45_0.int_60);
			g.method_1(0, -GClass39.gclass45_0.int_8);
			for (int i = 0; i < list_0.Count; i++)
			{
				int int_ = GClass39.gclass45_0.int_57;
				int num = GClass39.gclass45_0.int_58 + i * 36;
				int w = GClass39.gclass45_0.int_59 - 1;
				int h = 35;
				if (num - GClass39.gclass45_0.int_8 <= GClass39.gclass45_0.int_58 + GClass39.gclass45_0.int_60 && num - GClass39.gclass45_0.int_8 >= GClass39.gclass45_0.int_58 - 36)
				{
					g.method_16(15260884);
					g.method_15(int_, num, w, h);
					GClass193.smethod_0().method_3(GClass49.gclass49_6, g, list_0[i].string_0 ?? "", int_ + 5, num, 0, GClass49.gclass49_3, "border");
					GClass49.gclass49_11.method_6(g, (GClass192.int_0 == 0) ? ("Địa điểm: " + list_0[i].string_1) : ("Location: " + list_0[i].string_1), int_ + 5, num + 11, 0);
					GClass49.gclass49_11.method_6(g, (GClass192.int_0 == 0) ? ("Thời gian xuất hiện: " + list_0[i].dateTime_0.ToString("HH:mm:ss")) : ("Time Appear: " + list_0[i].dateTime_0.ToString("HH:mm:ss")), int_ + 5, num + 22, 0);
					GClass193.smethod_0().method_3(GClass49.gclass49_1, g, (GClass192.int_0 == 0) ? ("[" + GClass179.smethod_4(list_0[i]) + " trước]") : ("[" + GClass179.smethod_4(list_0[i]) + " ago]"), GClass39.gclass45_0.int_57 + GClass39.gclass45_0.int_59, GClass39.gclass45_0.int_58 + i * 36, GClass49.int_1, GClass49.gclass49_6, "noborder");
				}
			}
		}

		public void method_16(int selected)
		{
			List<GClass179> list = new List<GClass179>();
			switch (selected)
			{
			case 0:
				method_17(GClass179.list_2);
				GClass39.gclass45_0.method_50();
				break;
			case 1:
				method_17(GClass179.list_3);
				GClass39.gclass45_0.method_50();
				break;
			case 2:
				method_17(GClass179.list_4);
				GClass39.gclass45_0.method_50();
				break;
			case 3:
				method_17(GClass179.list_5);
				GClass39.gclass45_0.method_50();
				break;
			case 4:
				method_17(GClass179.list_6);
				GClass39.gclass45_0.method_50();
				break;
			case 5:
				method_17(GClass179.list_7);
				GClass39.gclass45_0.method_50();
				break;
			case 6:
				method_17(GClass179.list_8);
				GClass39.gclass45_0.method_50();
				break;
			case 7:
				method_17(GClass179.list_9);
				GClass39.gclass45_0.method_50();
				break;
			case 8:
				method_17(GClass179.list_10);
				GClass39.gclass45_0.method_50();
				break;
			case 9:
				method_17(GClass179.list_11);
				GClass39.gclass45_0.method_50();
				break;
			case 10:
				method_17(GClass179.list_12);
				GClass39.gclass45_0.method_50();
				break;
			case 11:
				method_17(GClass179.list_13);
				GClass39.gclass45_0.method_50();
				break;
			case 12:
				method_17(GClass179.list_14);
				GClass39.gclass45_0.method_50();
				break;
			case 13:
				method_17(GClass179.list_15);
				GClass39.gclass45_0.method_50();
				break;
			case 14:
				method_17(GClass179.list_16);
				GClass39.gclass45_0.method_50();
				break;
			case 15:
				method_17(GClass179.list_17);
				GClass39.gclass45_0.method_50();
				break;
			case 16:
				method_17(GClass179.list_18);
				GClass39.gclass45_0.method_50();
				break;
			case 17:
				method_17(GClass179.list_19);
				GClass39.gclass45_0.method_50();
				break;
			case 18:
				method_17(GClass179.list_20);
				GClass39.gclass45_0.method_50();
				break;
			}
		}

		private void method_17(List<GClass179> list_2)
		{
			list_0 = list_2;
			GClass39.gclass45_0.int_41 = list_2.Count;
			GClass39.gclass45_0.int_4 = 36;
			GClass39.gclass45_0.int_11 = GClass39.gclass45_0.int_41 * 36 - GClass39.gclass45_0.int_60;
			if (GClass39.gclass45_0.int_11 < 0)
				GClass39.gclass45_0.int_11 = 0;
			if (GClass39.gclass45_0.int_8 < 0)
			{
				GClass45 gclass45_ = GClass39.gclass45_0;
				GClass45 gclass45_2 = GClass39.gclass45_0;
				int num = 0;
				gclass45_2.int_7 = 0;
				gclass45_.int_8 = 0;
			}
			if (GClass39.gclass45_0.int_8 > GClass39.gclass45_0.int_11)
				GClass39.gclass45_0.int_8 = (GClass39.gclass45_0.int_7 = GClass39.gclass45_0.int_11);
			GClass39.gclass45_0.int_28 = 100;
			GClass39.gclass45_0.method_5(0);
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
				return (GClass192.int_0 == 0) ? "Ấn vào để xem thêm" : "Click ?";
			case 2:
				return (GClass192.int_0 == 0) ? "Ấn vào để xem thêm" : "Click ?";
			case 3:
				return (GClass192.int_0 == 0) ? "Ấn vào để xem thêm" : "Click ?";
			case 4:
				return (GClass192.int_0 == 0) ? "Cập nhật mới nhất: 20/4/2024" : "Newest Update: 20/4/2024";
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < 2000; i++)
			{
				if (GClass83.smethod_1((short)i) != null)
					list_1.Add(GClass83.smethod_1((short)i));
			}
		}

		public void method_19(GClass76 g)
		{
			g.method_5(GClass39.gclass45_0.int_57, GClass39.gclass45_0.int_58, GClass39.gclass45_0.int_59, GClass39.gclass45_0.int_60);
			g.method_1(0, -GClass39.gclass45_0.int_8);
			for (int i = 0; i < string_2.Length; i++)
			{
				int int_ = GClass39.gclass45_0.int_57;
				int num = GClass39.gclass45_0.int_58 + i * GClass39.gclass45_0.int_4;
				int w = GClass39.gclass45_0.int_59 - 1;
				int h = GClass39.gclass45_0.int_4 - 1;
				if (num - GClass39.gclass45_0.int_8 <= GClass39.gclass45_0.int_58 + GClass39.gclass45_0.int_60 && num - GClass39.gclass45_0.int_8 >= GClass39.gclass45_0.int_58 - GClass39.gclass45_0.int_4)
				{
					g.method_20((i != GClass39.gclass45_0.int_66) ? 0 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass49.gclass49_20.method_6(g, i + 1 + ". " + string_2[i], int_ + 5, num, 0);
					GClass49.gclass49_15.method_6(g, method_18(i), int_ + 5, num + 11, 0);
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
					GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? "Chúc quý khách chơi game vui vẻ!" : "Wish you have fun playing the game", 0);
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

		public void method_21(GClass76 g)
		{
			g.method_5(GClass39.gclass45_0.int_57, GClass39.gclass45_0.int_58, GClass39.gclass45_0.int_59, GClass39.gclass45_0.int_60);
			g.method_1(0, -GClass39.gclass45_0.int_8);
			for (int i = 0; i < GClass178.smethod_0().list_0.Count; i++)
			{
				int int_ = GClass39.gclass45_0.int_57;
				int num = GClass39.gclass45_0.int_58 + i * GClass39.gclass45_0.int_4;
				int w = GClass39.gclass45_0.int_59 - 1;
				int h = GClass39.gclass45_0.int_4 - 1;
				if (num - GClass39.gclass45_0.int_8 <= GClass39.gclass45_0.int_58 + GClass39.gclass45_0.int_60 && num - GClass39.gclass45_0.int_8 >= GClass39.gclass45_0.int_58 - GClass39.gclass45_0.int_4)
				{
					g.method_20((i == GClass39.gclass45_0.int_66) ? 16383818 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass49.gclass49_3.method_6(g, $"[{i + 1}]", 10, num + 3, GClass49.int_0);
					GClass49.gclass49_3.method_6(g, GClass178.smethod_0().list_0[i].string_0, GClass39.gclass45_0.int_57 + GClass39.gclass45_0.int_59 / 2, num + 3, GClass49.int_2);
				}
			}
			GClass39.gclass45_0.method_100(g);
		}

		public void method_22(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < GClass178.smethod_0().list_0.Count; i++)
			{
				if (i == selected)
				{
					List<int> list = GClass178.smethod_0().list_0[i].list_0;
					Class14.smethod_0().method_6(list);
				}
			}
		}
	}
}
