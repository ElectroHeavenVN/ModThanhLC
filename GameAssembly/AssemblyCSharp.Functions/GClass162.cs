using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace AssemblyCSharp.Functions
{
	public class GClass162
	{
		public const int int_0 = 23;

		[CompilerGenerated]
		private int int_1;

		public string[][] string_0 = new string[5][]
		{
			(GClass151.int_0 == 0) ? new string[2] { "D.sách", "Item" } : new string[2] { "List", "Item" },
			(GClass151.int_0 != 0) ? new string[2] { "Graphic", "Setting" } : new string[2] { "Cài đặt", "Đồ họa" },
			(GClass151.int_0 != 0) ? new string[2] { "Boss", "Nofiti.." } : new string[2] { "T.báo", "Boss" },
			(GClass151.int_0 != 0) ? new string[2] { "Menu", "Xmap" } : new string[2] { "D.sách", "Map" },
			(GClass151.int_0 != 0) ? new string[2] { "Version", "Info" } : new string[2] { "Thông", "tin" }
		};

		public int[] int_2 = new int[23]
		{
			521, 382, 383, 381, 384, 385, 663, 664, 665, 666,
			667, 379, 764, 880, 881, 882, 1152, 1151, 1150, 1153,
			1154, 1517, 1518
		};

		public string[] string_1 = new string[20]
		{
			(GClass151.int_0 != 0) ? "Hide Character" : "Ẩn nhân vật",
			(GClass151.int_0 != 0) ? "Hide Mob" : "Ẩn quái",
			(GClass151.int_0 == 0) ? "Ẩn Npc" : "Hide Npc",
			(GClass151.int_0 == 0) ? "Ẩn item" : "Hide item",
			(GClass151.int_0 == 0) ? "Ẩn hiệu ứng" : "Hide effects",
			(GClass151.int_0 == 0) ? "Ẩn cây cối, đá, ..." : "Hide Tilemap",
			(GClass151.int_0 != 0) ? "Hide backpack" : "Ẩn phụ kiện đeo lưng",
			(GClass151.int_0 != 0) ? "Hide server notification" : "Ẩn thông báo máy chủ",
			(GClass151.int_0 != 0) ? "Hide game UI" : "Ẩn giao diện game",
			(GClass151.int_0 == 0) ? "Ẩn địa hình" : "Hide terrain",
			(GClass151.int_0 == 0) ? "Tinh giảm địa hình" : "Optimize terrain",
			(GClass151.int_0 != 0) ? "Hide game Image" : "Ẩn hình ảnh game",
			(GClass151.int_0 != 0) ? "Turn on RGB Color wallpaper" : "Bật nền màu RGB",
			(GClass151.int_0 == 0) ? "Bật hình nền" : "Turn on Image wallpaper",
			(GClass151.int_0 != 0) ? "Optimize CPU" : "Tối ưu CPU",
			(GClass151.int_0 == 0) ? "Đóng băng quái" : "Freeze Mob Image",
			(GClass151.int_0 != 0) ? "Show FPS" : "Hiển thị FPS",
			(GClass151.int_0 != 0) ? "Hide World's chat" : "Ẩn chat thế giới",
			(GClass151.int_0 == 0) ? "Ẩn thú cưỡi" : "Hide mount",
			(GClass151.int_0 == 0) ? "Ẩn chat liên server" : "Hide chat multi-server"
		};

		public string[] string_2 = new string[5] { "Dragon Ball Pro [2.3.7]", "Facebook", "Youtube", "Website", "Version Information" };

		private static GClass162 gclass162_0;

		public int int_3 = 0;

		public static List<GClass156> list_0 = new List<GClass156>();

		public static List<GClass117> list_1 = new List<GClass117>();

		public int Int32_0
		{
			[CompilerGenerated]
			get
			{
				return int_1;
			}
			[CompilerGenerated]
			set
			{
				int_1 = value;
			}
		}

		public static GClass162 smethod_0()
		{
			return (gclass162_0 != null) ? gclass162_0 : (gclass162_0 = new GClass162());
		}

		public void method_0()
		{
			GClass96.gclass96_0 = null;
			GClass93.gclass88_1.method_9();
			GClass93.gclass88_3.method_9();
			GClass130.smethod_5();
			if (GClass73.gclass145_0 != null)
				GClass73.gclass145_0.method_7();
			GClass73.gclass76_0.gclass96_0 = null;
		}

		public void method_1(int type)
		{
			GClass73.gclass76_0.int_28 = 23;
			Int32_0 = type;
			method_2();
		}

		public void method_2()
		{
			GClass109.smethod_1().method_1();
			GClass73.gclass76_0.method_5(0);
			if (Int32_0 == 0)
			{
				GClass73.gclass76_0.string_17[23] = string_0;
				GClass73.gclass76_0.method_5(0);
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
			GClass73.gclass76_0.int_4 = 24;
			switch (GClass73.gclass76_0.int_29)
			{
			case 0:
				GClass73.gclass76_0.int_41 = int_2.Length;
				break;
			case 1:
				GClass73.gclass76_0.int_41 = string_1.Length;
				break;
			case 2:
				GClass73.gclass76_0.int_41 = GClass156.string_2.Length;
				GClass73.gclass76_0.int_4 = 18;
				break;
			case 3:
				GClass174.smethod_0().method_4();
				GClass73.gclass76_0.int_41 = GClass174.smethod_0().list_0.Count;
				GClass73.gclass76_0.int_4 = 18;
				break;
			case 4:
				GClass73.gclass76_0.int_41 = string_2.Length;
				break;
			}
			GClass73.gclass76_0.int_67 = (GClass73.bool_5 ? (-1) : 0);
			GClass73.gclass76_0.int_11 = GClass73.gclass76_0.int_41 * GClass73.gclass76_0.int_4 - GClass73.gclass76_0.int_61;
			if (GClass73.gclass76_0.int_11 < 0)
				GClass73.gclass76_0.int_11 = 0;
			GClass73.gclass76_0.int_8 = (GClass73.gclass76_0.int_7 = GClass73.gclass76_0.int_13[GClass73.gclass76_0.int_29]);
			if (GClass73.gclass76_0.int_8 < 0)
			{
				GClass76 gclass76_ = GClass73.gclass76_0;
				GClass76 gclass76_2 = GClass73.gclass76_0;
				int num = 0;
				gclass76_2.int_7 = 0;
				gclass76_.int_8 = 0;
			}
			if (GClass73.gclass76_0.int_8 > GClass73.gclass76_0.int_11)
				GClass73.gclass76_0.int_8 = (GClass73.gclass76_0.int_7 = GClass73.gclass76_0.int_11);
		}

		public void method_5(GClass122 g)
		{
			if (Int32_0 == 0)
				method_7(g);
		}

		public void method_6()
		{
			switch (GClass73.gclass76_0.int_29)
			{
			case 0:
				method_9(GClass73.gclass76_0.int_67);
				break;
			case 1:
				method_12(GClass73.gclass76_0.int_67);
				break;
			case 2:
				method_14(GClass73.gclass76_0.int_67);
				break;
			case 3:
				method_22(GClass73.gclass76_0.int_67);
				break;
			case 4:
				method_20(GClass73.gclass76_0.int_67);
				break;
			}
		}

		public void method_7(GClass122 g)
		{
			switch (GClass73.gclass76_0.int_29)
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

		public void method_8(GClass122 g)
		{
			g.method_5(GClass73.gclass76_0.int_58, GClass73.gclass76_0.int_59, GClass73.gclass76_0.int_60, GClass73.gclass76_0.int_61);
			g.method_1(0, -GClass73.gclass76_0.int_8);
			for (int i = 0; i < int_2.Length; i++)
			{
				int int_ = GClass73.gclass76_0.int_58;
				int num = GClass73.gclass76_0.int_59 + i * GClass73.gclass76_0.int_4;
				int w = GClass73.gclass76_0.int_60 - 1;
				int h = GClass73.gclass76_0.int_4 - 1;
				if (num - GClass73.gclass76_0.int_8 > GClass73.gclass76_0.int_59 + GClass73.gclass76_0.int_61 || num - GClass73.gclass76_0.int_8 < GClass73.gclass76_0.int_59 - GClass73.gclass76_0.int_4)
					continue;
				g.method_20((i != GClass73.gclass76_0.int_67) ? 0 : 0, 0.5f);
				g.method_15(int_, num, w, h);
				if (GClass122.int_12 == 2)
					GClass4.gclass4_20.method_9(g, GClass0.smethod_1((short)int_2[i]).string_0 + " " + ((GClass160.smethod_0().method_20(int_2[i], "id") > 0) ? string.Format("(x{0})", GClass160.smethod_0().method_20(int_2[i], "id")) : ""), int_ + 30, num, 0, GClass4.gclass4_6);
				else if (GClass122.int_12 == 1)
				{
					GClass4.gclass4_3.method_6(g, GClass0.smethod_1((short)int_2[i]).string_0 + " " + ((GClass160.smethod_0().method_20(int_2[i], "id") > 0) ? string.Format("(x{0})", GClass160.smethod_0().method_20(int_2[i], "id")) : ""), int_ + 30, num, 0);
				}
				GClass28.smethod_6(g, GClass0.smethod_1((short)int_2[i]).short_1, int_ + 2, num + 2, 0, 0);
				string st = ((GClass151.int_0 != 0) ? "CLICK TO AUTO USE" : "ẤN ĐỂ TỰ ĐỘNG DÙNG");
				GClass4 gClass = ((GClass160.smethod_0().method_20(int_2[i], "id") > 0) ? GClass4.gclass4_15 : GClass4.gclass4_6);
				foreach (GClass160.GStruct7 item in GClass160.smethod_0().list_6)
				{
					if (item.int_0 == GClass0.smethod_1((short)int_2[i]).short_1)
					{
						gClass = GClass4.gclass4_1;
						g.method_20((i != GClass73.gclass76_0.int_67) ? 0 : 0, 0.5f);
						g.method_15(int_, num, w, h);
						st = ((GClass151.int_0 == 0) ? "ẤN ĐỂ DỪNG TỰ ĐỘNG" : "CLICK TO STOP AUTO");
					}
				}
				if (GClass160.smethod_0().method_20(int_2[i], "id") > 0)
					gClass.method_6(g, st, int_ + 30, num + 11, 0);
			}
			GClass73.gclass76_0.method_100(g);
		}

		public void method_9(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass != null)
				{
					if (!GClass160.smethod_0().method_20(int_2[selected], "id").Equals(0))
					{
						if (GClass160.smethod_0().method_20(int_2[selected], "id") > 0 && gClass.gclass117_0.short_1 == GClass0.smethod_1((short)int_2[selected]).short_1)
							GClass160.smethod_0().method_18(gClass);
						continue;
					}
					GClass144.gclass52_0.method_7((GClass151.int_0 != 0) ? "You don't have this item" : "Mày làm đéo gì có Item ?", 0);
					break;
				}
				break;
			}
		}

		public string method_10(int index)
		{
			int num = GClass151.int_0;
			if (num != 0)
			{
				if (num != 1)
					return "";
				switch (index)
				{
				default:
					return "";
				case 0:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_5);
				case 1:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_7);
				case 2:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_6);
				case 3:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_8);
				case 4:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_9);
				case 5:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_10);
				case 6:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_11);
				case 7:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_13);
				case 8:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_17);
				case 9:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_18);
				case 10:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_19);
				case 11:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_21);
				case 12:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_14);
				case 13:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_15);
				case 14:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_20);
				case 15:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_4);
				case 16:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_1);
				case 17:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_16);
				case 18:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_12);
				case 19:
					return "Status: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_0);
				}
			}
			switch (index)
			{
			default:
				return "";
			case 0:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_5);
			case 1:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_7);
			case 2:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_6);
			case 3:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_8);
			case 4:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_9);
			case 5:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_10);
			case 6:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_11);
			case 7:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_13);
			case 8:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_17);
			case 9:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_18);
			case 10:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_19);
			case 11:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_21);
			case 12:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_14);
			case 13:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_15);
			case 14:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_20);
			case 15:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_4);
			case 16:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_1);
			case 17:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_16);
			case 18:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_12);
			case 19:
				return "Trạng thái: " + GClass154.smethod_0().method_7(GClass167.smethod_0().bool_0);
			}
		}

		public void method_11(GClass122 g)
		{
			g.method_5(GClass73.gclass76_0.int_58, GClass73.gclass76_0.int_59, GClass73.gclass76_0.int_60, GClass73.gclass76_0.int_61);
			g.method_1(0, -GClass73.gclass76_0.int_8);
			for (int i = 0; i < string_1.Length; i++)
			{
				int int_ = GClass73.gclass76_0.int_58;
				int num = GClass73.gclass76_0.int_59 + i * GClass73.gclass76_0.int_4;
				int w = GClass73.gclass76_0.int_60 - 1;
				int h = GClass73.gclass76_0.int_4 - 1;
				if (num - GClass73.gclass76_0.int_8 <= GClass73.gclass76_0.int_59 + GClass73.gclass76_0.int_61 && num - GClass73.gclass76_0.int_8 >= GClass73.gclass76_0.int_59 - GClass73.gclass76_0.int_4)
				{
					g.method_20((i != GClass73.gclass76_0.int_67) ? 0 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass4.gclass4_20.method_6(g, i + 1 + ". " + string_1[i], int_ + 5, num, 0);
					if (method_10(i).Contains((GClass151.int_0 == 0) ? "Trạng thái: Đang bật" : "Status: Is On"))
					{
						g.method_20((i != GClass73.gclass76_0.int_67) ? 0 : 0, 0.5f);
						g.method_15(int_, num, w, h);
					}
					((!(method_10(i) == ((GClass151.int_0 == 0) ? "Trạng thái: Đang bật" : "Status: Is On"))) ? GClass4.gclass4_11 : GClass4.gclass4_15).method_6(g, method_10(i), int_ + 5, num + 11, 0);
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
				GClass167.smethod_0().bool_5 = !GClass167.smethod_0().bool_5;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Ẩn người: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_5)) : ("Hide character: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_5)), 0);
				break;
			case 1:
				GClass167.smethod_0().bool_7 = !GClass167.smethod_0().bool_7;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Ẩn quái: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_7)) : ("Hide mob: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_7)), 0);
				break;
			case 2:
				GClass167.smethod_0().bool_6 = !GClass167.smethod_0().bool_6;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Ẩn NPC: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_6)) : ("Hide Npc: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_6)), 0);
				break;
			case 3:
				GClass167.smethod_0().bool_8 = !GClass167.smethod_0().bool_8;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Hide Item: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_8)) : ("Ẩn Item: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_8)), 0);
				break;
			case 4:
				GClass167.smethod_0().bool_9 = !GClass167.smethod_0().bool_9;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Hide Effects: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_9)) : ("Ẩn hiệu ứng: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_9)), 0);
				break;
			case 5:
				GClass167.smethod_0().bool_10 = !GClass167.smethod_0().bool_10;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Hide TileMaps,....: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_10)) : ("Ẩn cây cối, đá,....: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_10)), 0);
				break;
			case 6:
				GClass167.smethod_0().bool_11 = !GClass167.smethod_0().bool_11;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Hide Backpack: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_11)) : ("Ẩn phụ kiện đeo lưng: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_11)), 0);
				break;
			case 7:
				GClass167.smethod_0().bool_13 = !GClass167.smethod_0().bool_13;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Hide server nofitication: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_13)) : ("Ẩn thông báo máy chủ: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_13)), 0);
				break;
			case 8:
				GClass167.smethod_0().bool_17 = !GClass167.smethod_0().bool_17;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Ẩn giao diện game: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_17)) : ("Hide game UI: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_17)), 0);
				break;
			case 9:
				GClass167.smethod_0().bool_18 = !GClass167.smethod_0().bool_18;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Hide Terrain: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_18)) : ("Ẩn địa hình: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_18)), 0);
				break;
			case 10:
				GClass167.smethod_0().bool_19 = !GClass167.smethod_0().bool_19;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Optimize Terrain: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_19)) : ("Tinh giảm địa hình: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_19)), 0);
				break;
			case 11:
				GClass167.smethod_0().bool_21 = !GClass167.smethod_0().bool_21;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Ẩn hình ảnh game: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_21)) : ("Hide game Image: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_21)), 0);
				break;
			case 12:
				if (!GClass167.smethod_0().bool_14)
				{
					GClass167.smethod_0().method_1((GClass151.int_0 != 0) ? "Fill color code R,G,B" : "Nhập mã màu R,G,B");
					GClass167.smethod_0().bool_14 = true;
				}
				else
					GClass167.smethod_0().bool_14 = false;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Bật hình nền Color RGB: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_14)) : ("Wallpaper Color RGB: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_14)), 0);
				break;
			case 13:
				GClass167.smethod_0().bool_15 = !GClass167.smethod_0().bool_15;
				if (File.Exists("Data/wallpaper.png"))
					GClass167.smethod_0().gclass70_0 = GClass167.smethod_0().method_4("Data/wallpaper.png", GClass122.int_12);
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Image wallpaper: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_15)) : ("Bật hình nền ảnh: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_15)), 0);
				break;
			case 14:
				GClass167.smethod_0().bool_20 = !GClass167.smethod_0().bool_20;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Optimize CPU: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_20)) : ("Tối ưu CPU: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_20)), 0);
				break;
			case 15:
				GClass167.smethod_0().bool_4 = !GClass167.smethod_0().bool_4;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đóng băng quái: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_4)) : ("Freeze Mob Image: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_4)), 0);
				break;
			case 16:
				GClass167.smethod_0().bool_1 = !GClass167.smethod_0().bool_1;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Hiển thị FPS: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_1)) : ("Show FPS: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_1)), 0);
				break;
			case 17:
				GClass167.smethod_0().bool_16 = !GClass167.smethod_0().bool_16;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Hide world's chat: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_16)) : ("Ẩn kênh chat thế giới: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_16)), 0);
				break;
			case 18:
				GClass167.smethod_0().bool_12 = !GClass167.smethod_0().bool_12;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Hide mount: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_12)) : ("Ẩn thú cưỡi: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_12)), 0);
				break;
			case 19:
				GClass167.smethod_0().bool_0 = !GClass167.smethod_0().bool_0;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Ẩn chat liên vũ trụ: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_0)) : ("Hide multi-server chat: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_0)), 0);
				break;
			}
		}

		public void method_13(GClass122 g)
		{
			g.method_5(GClass73.gclass76_0.int_58, GClass73.gclass76_0.int_59, GClass73.gclass76_0.int_60, GClass73.gclass76_0.int_61);
			g.method_1(0, -GClass73.gclass76_0.int_8);
			for (int i = 0; i < ((GClass151.int_0 != 0) ? GClass156.string_3.Length : GClass156.string_2.Length); i++)
			{
				int int_ = GClass73.gclass76_0.int_58;
				int num = GClass73.gclass76_0.int_59 + i * GClass73.gclass76_0.int_4;
				int w = GClass73.gclass76_0.int_60 - 1;
				int h = GClass73.gclass76_0.int_4 - 1;
				if (num - GClass73.gclass76_0.int_8 <= GClass73.gclass76_0.int_59 + GClass73.gclass76_0.int_61 && num - GClass73.gclass76_0.int_8 >= GClass73.gclass76_0.int_59 - GClass73.gclass76_0.int_4)
				{
					g.method_16((i != GClass73.gclass76_0.int_67) ? 15260884 : 16383818);
					g.method_15(int_, num, w, h);
					GClass4.gclass4_6.method_6(g, (GClass151.int_0 == 0) ? GClass156.string_2[i] : GClass156.string_3[i], GClass73.gclass76_0.int_58 + GClass73.gclass76_0.int_60 / 2, num + 3, GClass4.int_2);
				}
			}
			GClass73.gclass76_0.method_100(g);
		}

		public void method_14(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < ((GClass151.int_0 != 0) ? GClass156.string_3.Length : GClass156.string_2.Length); i++)
			{
				if (i == selected)
				{
					method_16(i);
					int_3 = i;
				}
			}
		}

		public void method_15(GClass122 g)
		{
			g.method_5(GClass73.gclass76_0.int_58, GClass73.gclass76_0.int_59, GClass73.gclass76_0.int_60, GClass73.gclass76_0.int_61);
			g.method_1(0, -GClass73.gclass76_0.int_8);
			for (int i = 0; i < list_0.Count; i++)
			{
				int int_ = GClass73.gclass76_0.int_58;
				int num = GClass73.gclass76_0.int_59 + i * 36;
				int w = GClass73.gclass76_0.int_60 - 1;
				int h = 35;
				if (num - GClass73.gclass76_0.int_8 <= GClass73.gclass76_0.int_59 + GClass73.gclass76_0.int_61 && num - GClass73.gclass76_0.int_8 >= GClass73.gclass76_0.int_59 - 36)
				{
					g.method_16(15260884);
					g.method_15(int_, num, w, h);
					GClass154.smethod_0().method_2(GClass4.gclass4_6, g, list_0[i].string_0 ?? "", int_ + 5, num, 0, GClass4.gclass4_3, "border");
					GClass4.gclass4_11.method_6(g, (GClass151.int_0 != 0) ? ("Location: " + list_0[i].string_1) : ("Địa điểm: " + list_0[i].string_1), int_ + 5, num + 11, 0);
					GClass4.gclass4_11.method_6(g, (GClass151.int_0 == 0) ? ("Thời gian xuất hiện: " + list_0[i].dateTime_0.ToString("HH:mm:ss")) : ("Time Appear: " + list_0[i].dateTime_0.ToString("HH:mm:ss")), int_ + 5, num + 22, 0);
					GClass154.smethod_0().method_2(GClass4.gclass4_1, g, (GClass151.int_0 == 0) ? ("[" + GClass156.smethod_4(list_0[i]) + " trước]") : ("[" + GClass156.smethod_4(list_0[i]) + " ago]"), GClass73.gclass76_0.int_58 + GClass73.gclass76_0.int_60, GClass73.gclass76_0.int_59 + i * 36, GClass4.int_1, GClass4.gclass4_6, "noborder");
				}
			}
		}

		public void method_16(int selected)
		{
			List<GClass156> list = new List<GClass156>();
			switch (selected)
			{
			case 0:
				method_17(GClass156.list_2);
				GClass73.gclass76_0.method_50();
				break;
			case 1:
				method_17(GClass156.list_3);
				GClass73.gclass76_0.method_50();
				break;
			case 2:
				method_17(GClass156.list_4);
				GClass73.gclass76_0.method_50();
				break;
			case 3:
				method_17(GClass156.list_5);
				GClass73.gclass76_0.method_50();
				break;
			case 4:
				method_17(GClass156.list_6);
				GClass73.gclass76_0.method_50();
				break;
			case 5:
				method_17(GClass156.list_7);
				GClass73.gclass76_0.method_50();
				break;
			case 6:
				method_17(GClass156.list_8);
				GClass73.gclass76_0.method_50();
				break;
			case 7:
				method_17(GClass156.list_9);
				GClass73.gclass76_0.method_50();
				break;
			case 8:
				method_17(GClass156.list_10);
				GClass73.gclass76_0.method_50();
				break;
			case 9:
				method_17(GClass156.list_11);
				GClass73.gclass76_0.method_50();
				break;
			case 10:
				method_17(GClass156.list_12);
				GClass73.gclass76_0.method_50();
				break;
			case 11:
				method_17(GClass156.list_13);
				GClass73.gclass76_0.method_50();
				break;
			case 12:
				method_17(GClass156.list_14);
				GClass73.gclass76_0.method_50();
				break;
			case 13:
				method_17(GClass156.list_15);
				GClass73.gclass76_0.method_50();
				break;
			case 14:
				method_17(GClass156.list_16);
				GClass73.gclass76_0.method_50();
				break;
			case 15:
				method_17(GClass156.list_17);
				GClass73.gclass76_0.method_50();
				break;
			case 16:
				method_17(GClass156.list_18);
				GClass73.gclass76_0.method_50();
				break;
			case 17:
				method_17(GClass156.list_19);
				GClass73.gclass76_0.method_50();
				break;
			case 18:
				method_17(GClass156.list_20);
				GClass73.gclass76_0.method_50();
				break;
			}
		}

		private void method_17(List<GClass156> list_2)
		{
			list_0 = list_2;
			GClass73.gclass76_0.int_41 = list_2.Count;
			GClass73.gclass76_0.int_4 = 36;
			GClass73.gclass76_0.int_11 = GClass73.gclass76_0.int_41 * 36 - GClass73.gclass76_0.int_61;
			if (GClass73.gclass76_0.int_11 < 0)
				GClass73.gclass76_0.int_11 = 0;
			if (GClass73.gclass76_0.int_8 < 0)
			{
				GClass76 gclass76_ = GClass73.gclass76_0;
				GClass76 gclass76_2 = GClass73.gclass76_0;
				int num = 0;
				gclass76_2.int_7 = 0;
				gclass76_.int_8 = 0;
			}
			if (GClass73.gclass76_0.int_8 > GClass73.gclass76_0.int_11)
				GClass73.gclass76_0.int_8 = (GClass73.gclass76_0.int_7 = GClass73.gclass76_0.int_11);
			GClass73.gclass76_0.int_28 = 100;
			GClass73.gclass76_0.method_5(0);
		}

		public string method_18(int index)
		{
			switch (index)
			{
			default:
				return "";
			case 0:
				return "Dragon Boy Pro Released";
			case 1:
				return (GClass151.int_0 == 0) ? "Ấn vào để xem thêm" : "View";
			case 2:
				return (GClass151.int_0 != 0) ? "View" : "Ấn vào để xem thêm";
			case 3:
				return (GClass151.int_0 == 0) ? "Ấn vào để xem thêm" : "View";
			case 4:
				return (GClass151.int_0 == 0) ? ("Cập nhật mới nhất: " + GClass151.string_0) : ("Newest Update: " + GClass151.string_0);
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < 2000; i++)
			{
				if (GClass0.smethod_1((short)i) != null)
					list_1.Add(GClass0.smethod_1((short)i));
			}
		}

		public void method_19(GClass122 g)
		{
			g.method_5(GClass73.gclass76_0.int_58, GClass73.gclass76_0.int_59, GClass73.gclass76_0.int_60, GClass73.gclass76_0.int_61);
			g.method_1(0, -GClass73.gclass76_0.int_8);
			for (int i = 0; i < string_2.Length; i++)
			{
				int int_ = GClass73.gclass76_0.int_58;
				int num = GClass73.gclass76_0.int_59 + i * GClass73.gclass76_0.int_4;
				int w = GClass73.gclass76_0.int_60 - 1;
				int h = GClass73.gclass76_0.int_4 - 1;
				if (num - GClass73.gclass76_0.int_8 <= GClass73.gclass76_0.int_59 + GClass73.gclass76_0.int_61 && num - GClass73.gclass76_0.int_8 >= GClass73.gclass76_0.int_59 - GClass73.gclass76_0.int_4)
				{
					g.method_20((i != GClass73.gclass76_0.int_67) ? 0 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass4.gclass4_20.method_6(g, i + 1 + ". " + string_2[i], int_ + 5, num, 0);
					GClass4.gclass4_15.method_6(g, method_18(i), int_ + 5, num + 11, 0);
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
					GClass144.gclass52_0.method_7((GClass151.int_0 != 0) ? "Wish you have fun playing the game" : "Chúc quý khách chơi game vui vẻ!", 0);
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

		public void method_21(GClass122 g)
		{
			g.method_5(GClass73.gclass76_0.int_58, GClass73.gclass76_0.int_59, GClass73.gclass76_0.int_60, GClass73.gclass76_0.int_61);
			g.method_1(0, -GClass73.gclass76_0.int_8);
			for (int i = 0; i < GClass174.smethod_0().list_0.Count; i++)
			{
				int int_ = GClass73.gclass76_0.int_58;
				int num = GClass73.gclass76_0.int_59 + i * GClass73.gclass76_0.int_4;
				int w = GClass73.gclass76_0.int_60 - 1;
				int h = GClass73.gclass76_0.int_4 - 1;
				if (num - GClass73.gclass76_0.int_8 <= GClass73.gclass76_0.int_59 + GClass73.gclass76_0.int_61 && num - GClass73.gclass76_0.int_8 >= GClass73.gclass76_0.int_59 - GClass73.gclass76_0.int_4)
				{
					g.method_20((i == GClass73.gclass76_0.int_67) ? 16383818 : 0, 0.5f);
					g.method_15(int_, num, w, h);
					GClass4.gclass4_3.method_6(g, $"[{i + 1}]", 10, num + 3, GClass4.int_0);
					GClass4.gclass4_3.method_6(g, GClass174.smethod_0().list_0[i].string_0, GClass73.gclass76_0.int_58 + GClass73.gclass76_0.int_60 / 2, num + 3, GClass4.int_2);
				}
			}
			GClass73.gclass76_0.method_100(g);
		}

		public void method_22(int selected)
		{
			if (selected == -1)
				return;
			for (int i = 0; i < GClass174.smethod_0().list_0.Count; i++)
			{
				if (i == selected)
				{
					List<int> list = GClass174.smethod_0().list_0[i].list_0;
					Class21.smethod_0().method_7(list);
				}
			}
		}
	}
}
