using System;
using System.Text;
using ns0;

namespace ns1
{
	public class GClass175 : GInterface0
	{
		public int int_0 = -1;

		public int int_1 = -1;

		public int int_2 = -1;

		public int int_3 = -1;

		public int int_4 = -1;

		public long long_0;

		public long long_1;

		public long long_2 = -1L;

		public bool bool_0;

		public long long_3;

		public long long_4;

		public bool bool_1;

		public bool bool_2;

		public bool bool_3;

		public long long_5;

		public bool bool_4;

		public long long_6;

		private static GClass175 gclass175_0;

		private int[] int_5;

		private int[] int_6;

		private int[] int_7;

		public bool bool_5 = true;

		public static int int_8;

		public long long_7 = 500L;

		public static GClass175 smethod_0()
		{
			return (gclass175_0 != null) ? gclass175_0 : (gclass175_0 = new GClass175());
		}

		public void perform(int idAction, object p)
		{
			if (idAction != 10006)
			{
				switch (idAction)
				{
				case 50231:
					if (!GClass171.smethod_0().bool_0)
						method_0("/spos");
					break;
				case 50232:
					if (!GClass171.smethod_0().bool_0)
						method_0("/szone");
					break;
				case 50233:
					if (!GClass171.smethod_0().bool_0)
						method_0("/smap");
					break;
				case 50234:
					if (!GClass171.smethod_0().bool_0)
					{
						int_1 = GClass58.smethod_1().int_4;
						int_2 = GClass58.smethod_1().int_5;
						int_3 = GClass1.int_39;
						int_4 = GClass1.int_37;
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã lưu thông tin Goback" : "Saved goback informations", 0);
					}
					break;
				case 50235:
					if (!GClass171.smethod_0().bool_0)
					{
						int_1 = -1;
						int_2 = -1;
						int_3 = -1;
						int_4 = -1;
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã xóa thông tin Goback" : "Deleted goback informations", 0);
					}
					break;
				case 50236:
					bool_0 = !bool_0;
					GClass188.smethod_1("Goback khi hết KI: " + GClass193.smethod_0().method_6(bool_0), 0);
					break;
				}
			}
			else
			{
				GClass63 gClass = new GClass63();
				gClass.method_0(new GClass14((GClass192.int_0 != 0) ? ((int_1 == -1 || int_2 == -1) ? "Click to save\nPosition" : $"Save position\nX: {int_1}\nY: {int_2}") : ((int_1 == -1 || int_2 == -1) ? "Ấn để lưu\n Vị trí" : $"Lưu vị trí\nX: {int_1}\nY: {int_2}"), smethod_0(), 50231, null));
				gClass.method_0(new GClass14((GClass192.int_0 != 0) ? ((int_3 != -1) ? $"Save zone\nzone: {int_3}" : "Click to save\nZone") : ((int_3 != -1) ? $"Lưu khu\nKhu: {int_3}" : "Ấn để lưu\n Khu"), smethod_0(), 50232, null));
				gClass.method_0(new GClass14((GClass192.int_0 != 0) ? ((int_4 != -1) ? ("Save map\n" + GClass1.string_2[int_4]) : "Click to save\n Map") : ((int_4 != -1) ? ("Lưu map\n" + GClass1.string_2[int_4]) : "Ấn để lưu\n Map"), smethod_0(), 50233, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Lưu tất cả" : "Save all", smethod_0(), 50234, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Xóa \nthông tin" : "Delete\nInformations", smethod_0(), 50235, null));
				if (GClass192.string_2.Contains("username:9A01EF591420C1A023F1D2A1EE25EDE9") || GClass192.string_2.Contains("username:21232F297A57A5A743894A0E4A801FC3"))
					gClass.method_0(new GClass14("Goback khi\n Hết KI\n" + GClass193.smethod_0().method_7(bool_0), smethod_0(), 50236, null));
				GClass39.gclass0_0.method_2(gClass, 0);
			}
		}

		public bool method_0(string text)
		{
			switch (text)
			{
			case "/kz":
				int_0 = -1;
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã tắt tự động đổi khu" : "Turn off auto change zone", 0);
				goto IL_050e;
			case "/lcz":
				bool_2 = !bool_2;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Khóa chuyển khu: " + GClass193.smethod_0().method_6(bool_2)) : ("Lock change zone: " + GClass193.smethod_0().method_6(bool_2)), 0);
				goto IL_050e;
			case "/lcm":
				bool_1 = !bool_1;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Khóa chuyển map: " + GClass193.smethod_0().method_6(bool_1)) : ("Lock change map: " + GClass193.smethod_0().method_6(bool_1)), 0);
				goto IL_050e;
			case "/vdh":
				smethod_0().bool_5 = !smethod_0().bool_5;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Di chuyển vượt địa hình: " + GClass193.smethod_0().method_6(smethod_0().bool_5)) : ("Move cross terrain: " + GClass193.smethod_0().method_6(smethod_0().bool_5)), 0);
				goto IL_050e;
			case "/spos":
				if (int_1 == -1 && int_2 == -1)
				{
					int_1 = GClass58.smethod_1().int_4;
					int_2 = GClass58.smethod_1().int_5;
					GClass188.smethod_1((GClass192.int_0 == 0) ? $"Goback - Lưu vị trí [X: {int_1} -Y: {int_2}]" : $"Goback - Save position [X: {int_1} -Y: {int_2}]", 0);
				}
				else
				{
					int_1 = -1;
					int_2 = -1;
					GClass188.smethod_1((GClass192.int_0 == 0) ? "Goback - Xóa lưu vị trí" : "Goback - Delete position", 0);
				}
				goto IL_050e;
			case "/smap":
				if (int_4 == -1)
				{
					int_4 = GClass1.int_37;
					GClass188.smethod_1((GClass192.int_0 == 0) ? $"Goback - Lưu map [{int_4}]" : $"Goback - Save map [{int_4}]", 0);
				}
				else
				{
					int_4 = -1;
					GClass188.smethod_1((GClass192.int_0 == 0) ? "Goback - Xóa map" : "Goback - Delete map", 0);
				}
				goto IL_050e;
			case "/szone":
				if (int_3 == -1)
				{
					int_3 = GClass1.int_39;
					GClass188.smethod_1((GClass192.int_0 == 0) ? $"Goback - Lưu khu [{int_3}]" : $"Goback - Save zone [{int_3}]", 0);
				}
				else
				{
					int_3 = -1;
					GClass188.smethod_1((GClass192.int_0 == 0) ? "Goback - Xóa lưu khu" : "Goback - Delete zone", 0);
				}
				goto IL_050e;
			default:
				{
					if (GClass193.smethod_0().method_10<int>(text, "/kz"))
					{
						int_0 = GClass193.smethod_0().method_11<int>(text, "/kz");
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động đổi khu [{int_0}]" : $"Auto change zone [{int_0}]", 0);
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/abdkb"))
					{
						int_8 = GClass193.smethod_0().method_11<int>(text, "/abdkb");
						bool_3 = !bool_3;
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động mở BDKB Level [{int_8}]: {GClass193.smethod_0().method_6(bool_3)}" : $"Auto opten T.U.S Level [{int_8}]: {GClass193.smethod_0().method_6(bool_3)}", 0);
					}
					else
					{
						if (!GClass193.smethod_0().method_10<int>(text, "/k"))
							return false;
						int num = GClass193.smethod_0().method_11<int>(text, "/k");
						GClass166.smethod_0().method_42(num, -1);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đổi khu [{num}]" : $"Change zone [{num}]", 0);
					}
					goto IL_050e;
				}
				IL_050e:
				return true;
			}
		}

		public void method_1()
		{
			if (!bool_3 || int_8 <= 0 || GClass39.gclass145_0 == GClass153.gclass153_0 || GClass58.bool_33 || GClass65.bool_5 || GClass58.bool_35)
				return;
			if (GClass1.int_37 != 5)
			{
				int_8 = 0;
				bool_3 = false;
			}
			if (GClass138.smethod_18() - long_5 <= 500L)
				return;
			if (GClass155.gclass155_0 != null)
			{
				for (int i = 0; i < GClass155.gclass155_0.gclass67_0.Length; i++)
				{
					GClass155.gclass155_0.gclass67_0[i].method_23(int_8.ToString());
				}
				GClass166.smethod_0().method_7(GClass155.gclass155_0.gclass67_0);
				GClass154.gclass154_0.switchToMe();
				GClass166.smethod_0().method_59(13, 0);
				GClass198.smethod_0().method_0();
				long_5 = GClass138.smethod_18();
			}
			if (!GClass39.gclass0_0.bool_0 || GClass39.gclass0_0 == null)
			{
				GClass166.smethod_0().method_60(13);
				GClass198.smethod_0().method_0();
				long_5 = GClass138.smethod_18();
			}
			else
			{
				if (GClass39.gclass0_0 == null || !GClass39.gclass0_0.bool_0)
					return;
				int num = 0;
				while (true)
				{
					if (num < GClass39.gclass0_0.gclass63_0.method_2())
					{
						GClass14 gClass = (GClass14)GClass39.gclass0_0.gclass63_0.method_3(num);
						if (GClass193.smethod_0().method_1(gClass.string_0, (mResources.language == 0) ? "nóichuyện" : "talk"))
							break;
						if (!GClass193.smethod_0().method_1(gClass.string_0, (mResources.language == 0) ? "khobáudướibiển" : "treasureundersea"))
						{
							if (!GClass193.smethod_0().method_1(gClass.string_0, (mResources.language == 0) ? "chọncấpđộ" : "chooselevel"))
							{
								num++;
								continue;
							}
							GClass166.smethod_0().method_59(13, (sbyte)num);
							GClass198.smethod_0().method_0();
							long_5 = GClass138.smethod_18();
							return;
						}
						GClass166.smethod_0().method_59(13, (sbyte)num);
						GClass198.smethod_0().method_0();
						long_5 = GClass138.smethod_18();
						return;
					}
					return;
				}
				GClass166.smethod_0().method_59(13, (sbyte)num);
				GClass198.smethod_0().method_0();
				long_5 = GClass138.smethod_18();
			}
		}

		public void method_2()
		{
			smethod_1();
			method_10();
			method_6();
			method_5();
			method_1();
			method_4();
		}

		public void method_3()
		{
			if (bool_3 && GClass138.smethod_18() - long_5 > 200L)
			{
				if (GClass1.int_37 == 5)
				{
					GClass166.smethod_0().method_59(13, 0);
					long_5 = GClass138.smethod_18();
				}
				else if (GClass1.int_37 != 5)
				{
					bool_3 = false;
				}
			}
		}

		public void method_4()
		{
			if (bool_4 && GClass138.smethod_18() - long_6 > 100L)
			{
				if (GClass1.int_37 == 27)
				{
					GClass166.smethod_0().method_60(25);
					GClass166.smethod_0().method_59(25, 0);
					long_6 = GClass138.smethod_18();
				}
				else
					bool_4 = false;
			}
		}

		public void method_5()
		{
			try
			{
				if (int_0 != -1)
					long_7 = ((GClass1.int_37 != int_0) ? 100 : 500);
				else if (long_7 != 500L)
				{
					long_7 = 500L;
				}
				if (GClass138.smethod_18() - long_4 > long_7)
				{
					GClass166.smethod_0().method_58();
					long_4 = GClass138.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/UpdateZone.txt", ex.ToString());
			}
		}

		public void method_6()
		{
			try
			{
				if ((GClass183.smethod_0().bool_5 && !GClass183.smethod_0().bool_6) || (GClass183.smethod_0().bool_7 && !GClass183.smethod_0().bool_8) || (GClass183.smethod_0().bool_3 && GClass183.smethod_0().method_19() > 0))
					return;
				bool flag = false;
				if (int_1 == -1 && int_2 == -1 && int_3 == -1 && int_4 == -1)
					return;
				if (GClass58.smethod_1().bool_62)
				{
					flag = false;
					long_2 = -1L;
					GClass166.smethod_0().method_76();
					return;
				}
				if (bool_0 && GClass58.smethod_1().int_24 < GClass58.smethod_1().int_36 * 5 / 100 && GClass1.int_37 != GClass58.smethod_1().int_14 + 21)
				{
					flag = false;
					long_2 = -1L;
					Class14.smethod_0().method_7(21 + GClass58.smethod_1().int_14);
					return;
				}
				if (GClass1.int_37 == GClass58.smethod_1().int_14 + 21 && !flag)
				{
					for (int i = 0; i < GClass154.gclass63_6.method_2(); i++)
					{
						if ((GClass154.gclass63_6.method_3(i) as GClass134).gclass118_0.short_0 == 74)
						{
							GClass166.smethod_0().method_74(-1);
							flag = true;
							long_2 = GClass138.smethod_18();
							return;
						}
					}
				}
				if (int_4 != -1 && GClass1.int_37 != int_4 && long_2 == -1L && !flag)
					Class14.smethod_0().method_7(int_4);
				else if (int_4 != -1 && GClass1.int_37 != int_4 && GClass138.smethod_18() - long_2 > 3000L && long_2 != -1L)
				{
					Class14.smethod_0().method_7(int_4);
				}
				else
				{
					if (int_4 != -1 && GClass1.int_37 != int_4)
						return;
					if (int_3 != -1 && GClass154.smethod_8().int_63 != null && GClass138.smethod_18() - long_0 > 1000L && GClass1.int_39 != int_3 && 15 - GClass154.smethod_8().int_63[int_3] > 0)
					{
						GClass166.smethod_0().method_42(int_3, -1);
						long_0 = GClass138.smethod_18();
					}
					else
					{
						if ((int_3 != -1 && GClass1.int_39 != int_3 && GClass154.smethod_8().int_63 != null) || int_1 == -1 || int_2 == -1)
							return;
						if (GClass58.smethod_1().int_4 != int_1 || GClass58.smethod_1().int_5 != int_2)
						{
							if (long_1 == -1L)
								long_1 = GClass138.smethod_18();
							if (GClass138.smethod_18() - long_1 > 5000L && long_1 != -1L)
								method_9(int_1, int_2);
						}
						if (GClass58.smethod_1().int_4 == int_1 && GClass58.smethod_1().int_5 == int_2)
							long_1 = -1L;
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/Goback.txt", ex.ToString());
			}
		}

		public int method_7(int cx, int cy)
		{
			int num = cy;
			while (true)
			{
				if (num < GClass1.int_24 - 24)
				{
					if (GClass1.smethod_27(cx, num, 2))
						break;
					num += 24;
					continue;
				}
				int num2 = cy;
				while (true)
				{
					if (num2 > 24)
					{
						if (GClass1.smethod_27(cx, num2, 2))
							break;
						num2 -= 24;
						continue;
					}
					return cy;
				}
				return num2 - num2 % 24;
			}
			return num - num % 24;
		}

		public int method_8()
		{
			int num = 0;
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				GClass58 gClass = (GClass58)GClass154.gclass63_5.method_3(i);
				if (gClass != null && gClass.string_3 != null && gClass.string_3 != "" && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.int_13 > 0)
					num++;
			}
			return num;
		}

		public void method_9(int x, int y)
		{
			GClass58.smethod_1().int_4 = x;
			GClass58.smethod_1().int_5 = y;
			GClass166.smethod_0().method_44();
			GClass58.smethod_1().int_4 = x;
			GClass58.smethod_1().int_5 = method_7(x, y) + 12;
			GClass166.smethod_0().method_44();
			GClass58.smethod_1().int_4 = x;
			GClass58.smethod_1().int_5 = y;
			GClass166.smethod_0().method_44();
		}

		public void method_10()
		{
			if (int_0 != -1 && !GClass171.smethod_0().bool_0 && GClass154.smethod_8().int_63 != null && GClass1.int_37 != 21 + GClass58.smethod_1().int_14 && (GClass1.int_37 > 50 || GClass1.int_37 < 45) && GClass1.int_37 != 154 && GClass1.int_37 != 153 && (GClass1.int_37 > 138 || GClass1.int_37 < 135) && GClass138.smethod_18() - long_3 > 1000L && ((GClass177.smethod_0().method_5() && GClass154.smethod_8().int_63[int_0] < 25) || (!GClass177.smethod_0().method_5() && 15 - GClass154.smethod_8().int_63[int_0] > 0)) && GClass1.int_39 != int_0)
			{
				GClass166.smethod_0().method_42(int_0, -1);
				long_3 = GClass138.smethod_18();
			}
		}

		public static void smethod_1()
		{
			try
			{
				if (!smethod_0().bool_5 || (GClass58.smethod_1().int_11 != 2 && GClass58.smethod_1().int_11 != 4 && GClass58.smethod_1().int_11 != 10))
					return;
				int num = GClass58.smethod_1().int_4 + GClass58.smethod_1().int_12 * 24;
				if (GClass1.smethod_26(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5 - 24) != 0 || GClass1.smethod_26(num, GClass58.smethod_1().int_5 - 24) <= 0 || GClass1.smethod_26(num, GClass58.smethod_1().int_5 - 24) >= 14)
					return;
				int num2 = 0;
				for (int i = 6; i < GClass1.int_22; i++)
				{
					if (GClass1.smethod_25(num / GClass1.sbyte_0, i) != 0)
					{
						num2 = i;
						break;
					}
				}
				GClass58.smethod_1().int_4 = num;
				GClass58.smethod_1().int_5 = num2 * GClass1.sbyte_0;
				GClass166.smethod_0().method_44();
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/crossTerrain.txt", ex.ToString());
			}
		}

		private void method_11()
		{
			method_14();
			int num = GClass1.gclass63_0.method_2();
			if (num != 2)
			{
				for (int i = 0; i < num; i++)
				{
					GClass48 gClass = (GClass48)GClass1.gclass63_0.method_3(i);
					if (gClass.short_2 < 60)
					{
						int_5[0] = gClass.short_0 + 15;
						int_5[1] = gClass.short_3;
					}
					else if (gClass.short_2 > GClass1.int_23 - 60)
					{
						int_7[0] = gClass.short_2 - 15;
						int_7[1] = gClass.short_3;
					}
					else
					{
						int_6[0] = gClass.short_0 + 15;
						int_6[1] = gClass.short_3;
					}
				}
				return;
			}
			GClass48 gClass2 = (GClass48)GClass1.gclass63_0.method_3(0);
			GClass48 gClass3 = (GClass48)GClass1.gclass63_0.method_3(1);
			if ((gClass2.short_2 < 60 && gClass3.short_2 < 60) || (gClass2.short_0 > GClass1.int_23 - 60 && gClass3.short_0 > GClass1.int_23 - 60))
			{
				int_5[0] = gClass2.short_0 + 15;
				int_5[1] = gClass2.short_3;
				int_7[0] = gClass3.short_2 - 15;
				int_7[1] = gClass3.short_3;
			}
			else if (gClass2.short_2 < gClass3.short_2)
			{
				int_5[0] = gClass2.short_0 + 15;
				int_5[1] = gClass2.short_3;
				int_7[0] = gClass3.short_2 - 15;
				int_7[1] = gClass3.short_3;
			}
			else
			{
				int_5[0] = gClass3.short_0 + 15;
				int_5[1] = gClass3.short_3;
				int_7[0] = gClass2.short_2 - 15;
				int_7[1] = gClass2.short_3;
			}
		}

		public int method_12(int x)
		{
			int num = 50;
			int num2 = 0;
			while (num2 < 30)
			{
				num2++;
				num += 24;
				if (GClass1.smethod_27(x, num, 2))
				{
					if (num % 24 != 0)
						num -= num % 24;
					break;
				}
			}
			return num;
		}

		public void method_13(int x, int y)
		{
			if (GClass154.bool_68)
			{
				GClass58.smethod_1().int_4 = x;
				GClass58.smethod_1().int_5 = y;
				GClass166.smethod_0().method_44();
				return;
			}
			GClass58.smethod_1().int_4 = x;
			GClass58.smethod_1().int_5 = y;
			GClass166.smethod_0().method_44();
			GClass58.smethod_1().int_4 = x;
			GClass58.smethod_1().int_5 = y + 1;
			GClass166.smethod_0().method_44();
			GClass58.smethod_1().int_4 = x;
			GClass58.smethod_1().int_5 = y;
			GClass166.smethod_0().method_44();
		}

		private void method_14()
		{
			int_5 = new int[2];
			int_6 = new int[2];
			int_7 = new int[2];
		}

		public bool method_15()
		{
			return GClass1.int_37 >= 85 && GClass1.int_37 <= 91;
		}

		public static GClass48 smethod_2(int type)
		{
			if (GClass1.gclass63_0.method_2() == 1)
				return (GClass48)GClass1.gclass63_0.method_3(0);
			int num = 0;
			GClass48 gClass;
			while (true)
			{
				if (num < GClass1.gclass63_0.method_2())
				{
					gClass = (GClass48)GClass1.gclass63_0.method_3(num);
					if (type == 0)
					{
						if ((GClass1.int_37 == 70 && smethod_3(gClass.gclass24_0) == "Vực cấm") || (GClass1.int_37 == 73 && smethod_3(gClass.gclass24_0) == "Vực chết") || (GClass1.int_37 == 110 && smethod_3(gClass.gclass24_0) == "Rừng tuyết"))
							return gClass;
						if (gClass.short_2 < 60)
							return gClass;
					}
					if (type == 1)
					{
						if (((GClass1.int_37 == 106 || GClass1.int_37 == 107) && smethod_3(gClass.gclass24_0) == "Hang băng") || ((GClass1.int_37 == 105 || GClass1.int_37 == 108) && smethod_3(gClass.gclass24_0) == "Rừng băng") || (GClass1.int_37 == 109 && smethod_3(gClass.gclass24_0) == "Cánh đồng tuyết"))
							return gClass;
						if (GClass1.int_37 == 27)
							return null;
						if (gClass.short_0 < GClass1.int_23 - 60 && gClass.short_2 >= 60)
							return gClass;
					}
					if (type == 2)
					{
						if (GClass1.int_37 == 70 && smethod_3(gClass.gclass24_0) == "Căn cứ Raspberry")
							break;
						if (gClass.short_0 > GClass1.int_23 - 60)
							return gClass;
					}
					num++;
					continue;
				}
				return null;
			}
			return gClass;
		}

		public static string smethod_3(GClass24 popUp)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < popUp.string_0.Length; i++)
			{
				stringBuilder.Append(popUp.string_0[i]);
				stringBuilder.Append(" ");
			}
			return stringBuilder.ToString().Trim();
		}

		public void method_16(GClass48 waypoint)
		{
			if (waypoint.bool_1)
				GClass166.smethod_0().method_114();
			else
				GClass166.smethod_0().method_40();
		}

		public void method_17(int position)
		{
			if (method_15())
			{
				method_18(position);
				return;
			}
			method_11();
			switch (position)
			{
			case 0:
				if (GClass1.int_37 == 70)
					method_13(10, 192);
				else if (int_5[0] != 0 && int_5[1] != 0)
				{
					method_13(int_5[0], int_5[1]);
				}
				else
				{
					method_13(60, method_12(60));
				}
				break;
			case 1:
				if (int_7[0] != 0 && int_7[1] != 0)
					method_13(int_7[0], int_7[1]);
				else
					method_13(GClass1.int_23 - 60, method_12(GClass1.int_23 - 60));
				break;
			case 2:
				if (int_6[0] != 0 && int_6[1] != 0)
					method_13(int_6[0], int_6[1]);
				else
					method_13(GClass1.int_23 / 2, method_12(GClass1.int_23 / 2));
				break;
			}
			if (GClass1.int_37 != 7 && GClass1.int_37 != 14 && GClass1.int_37 != 0)
				GClass166.smethod_0().method_40();
			else
				GClass166.smethod_0().method_114();
		}

		private void method_18(int int_9)
		{
			if (int_9 != 0)
			{
				if (int_9 != 2)
				{
					method_13(GClass1.int_23 - 60, method_12(GClass1.int_23 - 60));
					return;
				}
				for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
				{
					GClass59 gClass = (GClass59)GClass154.gclass63_10.method_3(i);
					if (gClass.gclass90_0.int_0 >= 30 && gClass.gclass90_0.int_0 <= 36)
					{
						GClass58.smethod_1().gclass59_0 = gClass;
						method_13(gClass.int_4, gClass.int_5 - 3);
						break;
					}
				}
			}
			else
				method_13(60, method_12(60));
		}
	}
}
