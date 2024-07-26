using System;
using System.Text;
using Assets.src.g;

namespace AssemblyCSharp.Functions
{
	public class GClass157 : GInterface6
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

		private static GClass157 gclass157_0;

		private int[] int_5;

		private int[] int_6;

		private int[] int_7;

		public bool bool_5 = true;

		public static int int_8;

		public long long_7 = 500L;

		public static GClass157 smethod_0()
		{
			return (gclass157_0 != null) ? gclass157_0 : (gclass157_0 = new GClass157());
		}

		public void method_0()
		{
			GClass88 gClass = new GClass88();
			gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ((int_1 == -1 || int_2 == -1) ? "Click to save\nPosition" : $"Save position\nX: {int_1}\nY: {int_2}") : ((int_1 == -1 || int_2 == -1) ? "Ấn để lưu\n Vị trí" : $"Lưu vị trí\nX: {int_1}\nY: {int_2}"), smethod_0(), 50231, null));
			gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ((int_3 != -1) ? $"Save zone\nzone: {int_3}" : "Click to save\nZone") : ((int_3 != -1) ? $"Lưu khu\nKhu: {int_3}" : "Ấn để lưu\n Khu"), smethod_0(), 50232, null));
			gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ((int_4 != -1) ? ("Save map\n" + GClass20.string_2[int_4]) : "Click to save\n Map") : ((int_4 != -1) ? ("Lưu map\n" + GClass20.string_2[int_4]) : "Ấn để lưu\n Map"), smethod_0(), 50233, null));
			gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Save all" : "Lưu tất cả", smethod_0(), 50234, null));
			gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Delete\nInformations" : "Xóa \nthông tin", smethod_0(), 50235, null));
			if (GClass151.string_3.Contains("username:9A01EF591420C1A023F1D2A1EE25EDE9") || GClass151.string_3.Contains("username:21232F297A57A5A743894A0E4A801FC3"))
				gClass.method_0(new GClass87("Goback khi\n Hết KI\n" + GClass154.smethod_0().method_7(bool_0), smethod_0(), 50236, null));
			GClass73.gclass145_0.bool_1 = true;
			GClass73.gclass145_0.method_2(gClass, 0);
		}

		public void perform(int idAction, object p)
		{
			if (GClass148.smethod_0().bool_0 || GClass159.smethod_0().bool_18)
				return;
			if (idAction != 10006)
			{
				switch (idAction)
				{
				case 50231:
					if (!GClass148.smethod_0().bool_0)
					{
						method_1("/spos");
						method_0();
					}
					break;
				case 50232:
					if (!GClass148.smethod_0().bool_0)
					{
						method_1("/szone");
						method_0();
					}
					break;
				case 50233:
					if (!GClass148.smethod_0().bool_0)
					{
						method_1("/smap");
						method_0();
					}
					break;
				case 50234:
					if (!GClass148.smethod_0().bool_0)
					{
						int_1 = GClass78.smethod_1().int_4;
						int_2 = GClass78.smethod_1().int_5;
						int_3 = GClass20.int_39;
						int_4 = GClass20.int_37;
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Saved goback informations" : "Đã lưu thông tin Goback", 0);
						method_0();
					}
					break;
				case 50235:
					if (!GClass148.smethod_0().bool_0)
					{
						int_1 = -1;
						int_2 = -1;
						int_3 = -1;
						int_4 = -1;
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Deleted goback informations" : "Đã xóa thông tin Goback", 0);
						method_0();
					}
					break;
				case 50236:
					bool_0 = !bool_0;
					GClass149.smethod_1("Goback khi hết KI: " + GClass154.smethod_0().method_6(bool_0), 0);
					method_0();
					break;
				}
			}
			else
				method_0();
		}

        public bool method_1(string text)
        {
            switch (text)
            {
                case "/kz":
                    int_0 = -1;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? "Turn off auto change zone" : "Đã tắt tự động đổi khu", 0);
                    break;
                case "/smap":
                    if (int_4 != -1)
                    {
                        int_4 = -1;
                        GClass149.smethod_1((GClass151.int_0 != 0) ? "Goback - Delete map" : "Goback - Xóa map", 0);
                    }
                    else
                    {
                        int_4 = GClass20.int_37;
                        GClass149.smethod_1((GClass151.int_0 == 0) ? $"Goback - Lưu map [{int_4}]" : $"Goback - Save map [{int_4}]", 0);
                    }
                    break;
                case "/spos":
                    if (int_1 != -1 || int_2 != -1)
                    {
                        int_1 = -1;
                        int_2 = -1;
                        GClass149.smethod_1((GClass151.int_0 == 0) ? "Goback - Xóa lưu vị trí" : "Goback - Delete position", 0);
                    }
                    else
                    {
                        int_1 = GClass78.smethod_1().int_4;
                        int_2 = GClass78.smethod_1().int_5;
                        GClass149.smethod_1((GClass151.int_0 == 0) ? $"Goback - Lưu vị trí [X: {int_1} -Y: {int_2}]" : $"Goback - Save position [X: {int_1} -Y: {int_2}]", 0);
                    }
                    break;
                case "/lcz":
                    bool_2 = !bool_2;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Lock change zone: " + GClass154.smethod_0().method_6(bool_2)) : ("Khóa chuyển khu: " + GClass154.smethod_0().method_6(bool_2)), 0);
                    break;
                case "/lcm":
                    bool_1 = !bool_1;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Lock change map: " + GClass154.smethod_0().method_6(bool_1)) : ("Khóa chuyển map: " + GClass154.smethod_0().method_6(bool_1)), 0);
                    break;
                case "/vdh":
                    smethod_0().bool_5 = !smethod_0().bool_5;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Di chuyển vượt địa hình: " + GClass154.smethod_0().method_6(smethod_0().bool_5)) : ("Move cross terrain: " + GClass154.smethod_0().method_6(smethod_0().bool_5)), 0);
                    break;
                case "/szone":
                    if (int_3 == -1)
                    {
                        int_3 = GClass20.int_39;
                        GClass149.smethod_1((GClass151.int_0 != 0) ? $"Goback - Save zone [{int_3}]" : $"Goback - Lưu khu [{int_3}]", 0);
                    }
                    else
                    {
                        int_3 = -1;
                        GClass149.smethod_1((GClass151.int_0 != 0) ? "Goback - Delete zone" : "Goback - Xóa lưu khu", 0);
                    }
                    break;
                default:
                    if (!GClass154.smethod_0().method_11<int>(text, "/kz"))
                    {
                        if (GClass154.smethod_0().method_11<int>(text, "/abdkb"))
                        {
                            int_8 = GClass154.smethod_0().method_12<int>(text, "/abdkb");
                            bool_3 = !bool_3;
                            GClass149.smethod_1((GClass151.int_0 != 0) ? $"Auto opten T.U.S Level [{int_8}]: {GClass154.smethod_0().method_6(bool_3)}" : $"Tự động mở BDKB Level [{int_8}]: {GClass154.smethod_0().method_6(bool_3)}", 0);
                            break;
                        }
                        if (!GClass154.smethod_0().method_11<int>(text, "/k"))
                            return false;
                        int num = GClass154.smethod_0().method_12<int>(text, "/k");
                        GClass7.smethod_0().method_42(num, -1);
                        GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đổi khu [{num}]" : $"Change zone [{num}]", 0);
                    }
                    else
                    {
                        int_0 = GClass154.smethod_0().method_12<int>(text, "/kz");
                        GClass149.smethod_1((GClass151.int_0 != 0) ? $"Auto change zone [{int_0}]" : $"Tự động đổi khu [{int_0}]", 0);
                    }
                    break;
            }
            return true;
        }

        public void method_2()
		{
			if (!bool_3 || int_8 <= 0 || GClass73.gclass131_0 == GClass132.gclass132_0 || GClass78.bool_33 || GClass12.bool_5 || GClass78.bool_35)
				return;
			if (GClass20.int_37 != 5)
			{
				int_8 = 0;
				bool_3 = false;
			}
			if (GClass203.smethod_18() - long_5 <= 500L)
				return;
			if (GClass138.gclass138_0 != null)
			{
				for (int i = 0; i < GClass138.gclass138_0.gclass191_0.Length; i++)
				{
					GClass138.gclass138_0.gclass191_0[i].method_23(int_8.ToString());
				}
				GClass7.smethod_0().method_7(GClass138.gclass138_0.gclass191_0);
				GClass144.gclass144_0.switchToMe();
				GClass7.smethod_0().method_59(13, 0);
				GClass162.smethod_0().method_0();
				long_5 = GClass203.smethod_18();
			}
			if (!GClass73.gclass145_0.bool_0 || GClass73.gclass145_0 == null)
			{
				GClass7.smethod_0().method_60(13);
				GClass162.smethod_0().method_0();
				long_5 = GClass203.smethod_18();
			}
			else
			{
				if (GClass73.gclass145_0 == null || !GClass73.gclass145_0.bool_0)
					return;
				for (int j = 0; j < GClass73.gclass145_0.gclass88_0.method_2(); j++)
				{
					GClass87 gClass = (GClass87)GClass73.gclass145_0.gclass88_0.method_3(j);
					if (!GClass154.smethod_0().method_0(gClass.string_0, (mResources.language != 0) ? "talk" : "nóichuyện"))
					{
						if (!GClass154.smethod_0().method_0(gClass.string_0, (mResources.language == 0) ? "khobáudướibiển" : "treasureundersea"))
						{
							if (GClass154.smethod_0().method_0(gClass.string_0, (mResources.language != 0) ? "chooselevel" : "chọncấpđộ"))
							{
								GClass7.smethod_0().method_59(13, (sbyte)j);
								GClass162.smethod_0().method_0();
								long_5 = GClass203.smethod_18();
								break;
							}
							continue;
						}
						GClass7.smethod_0().method_59(13, (sbyte)j);
						GClass162.smethod_0().method_0();
						long_5 = GClass203.smethod_18();
						break;
					}
					GClass7.smethod_0().method_59(13, (sbyte)j);
					GClass162.smethod_0().method_0();
					long_5 = GClass203.smethod_18();
					break;
				}
			}
		}

		public void method_3()
		{
			smethod_1();
			method_11();
			method_7();
			method_6();
			method_2();
			method_5();
		}

		public void method_4()
		{
			if (bool_3 && GClass203.smethod_18() - long_5 > 200L)
			{
				if (GClass20.int_37 == 5)
				{
					GClass7.smethod_0().method_59(13, 0);
					long_5 = GClass203.smethod_18();
				}
				else
					bool_3 = false;
			}
		}

		public void method_5()
		{
			if (bool_4 && GClass203.smethod_18() - long_6 > 100L)
			{
				if (GClass20.int_37 == 27)
				{
					GClass7.smethod_0().method_60(25);
					GClass7.smethod_0().method_59(25, 0);
					long_6 = GClass203.smethod_18();
				}
				else
					bool_4 = false;
			}
		}

		public void method_6()
		{
			try
			{
				if (int_0 == -1)
				{
					if (long_7 != 500L)
						long_7 = 500L;
				}
				else
					long_7 = ((GClass20.int_37 != int_0) ? 100 : 500);
				if (GClass203.smethod_18() - long_4 > long_7)
				{
					GClass7.smethod_0().method_58();
					long_4 = GClass203.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/UpdateZone.txt", ex.ToString());
			}
		}

		public void method_7()
		{
			try
			{
				if ((GClass160.smethod_0().bool_6 && !GClass160.smethod_0().bool_7) || (GClass160.smethod_0().bool_8 && !GClass160.smethod_0().bool_9) || (GClass160.smethod_0().bool_3 && GClass160.smethod_0().method_22() > 0))
					return;
				bool flag = false;
				if (int_1 == -1 && int_2 == -1 && int_3 == -1 && int_4 == -1)
					return;
				if (!GClass78.smethod_1().bool_62)
				{
					if (bool_0 && GClass78.smethod_1().int_24 < GClass78.smethod_1().int_36 * 5 / 100 && GClass20.int_37 != GClass78.smethod_1().int_14 + 21)
					{
						flag = false;
						long_2 = -1L;
						Class21.smethod_0().method_8(21 + GClass78.smethod_1().int_14);
						return;
					}
					if (GClass20.int_37 == GClass78.smethod_1().int_14 + 21 && !flag)
					{
						for (int i = 0; i < GClass144.gclass88_6.method_2(); i++)
						{
							if ((GClass144.gclass88_6.method_3(i) as GClass64).gclass117_0.short_0 == 74)
							{
								GClass7.smethod_0().method_74(-1);
								flag = true;
								long_2 = GClass203.smethod_18();
								return;
							}
						}
					}
					if (int_4 == -1 || GClass20.int_37 == int_4 || long_2 != -1L || flag)
					{
						if (int_4 == -1 || GClass20.int_37 == int_4 || GClass203.smethod_18() - long_2 <= 3000L || long_2 == -1L)
						{
							if (int_4 != -1 && GClass20.int_37 != int_4)
								return;
							if (int_3 == -1 || GClass144.smethod_8().int_63 == null || GClass203.smethod_18() - long_0 <= 1000L || GClass20.int_39 == int_3 || 15 - GClass144.smethod_8().int_63[int_3] <= 0)
							{
								if ((int_3 != -1 && GClass20.int_39 != int_3 && GClass144.smethod_8().int_63 != null) || int_1 == -1 || int_2 == -1)
									return;
								if (GClass78.smethod_1().int_4 != int_1 || GClass78.smethod_1().int_5 != int_2)
								{
									if (long_1 == -1L)
										long_1 = GClass203.smethod_18();
									if (GClass203.smethod_18() - long_1 > 5000L && long_1 != -1L)
										method_10(int_1, int_2);
								}
								if (GClass78.smethod_1().int_4 == int_1 && GClass78.smethod_1().int_5 == int_2)
									long_1 = -1L;
							}
							else
							{
								GClass7.smethod_0().method_42(int_3, -1);
								long_0 = GClass203.smethod_18();
							}
						}
						else
							Class21.smethod_0().method_8(int_4);
					}
					else
						Class21.smethod_0().method_8(int_4);
				}
				else
				{
					flag = false;
					long_2 = -1L;
					GClass7.smethod_0().method_76();
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/Goback.txt", ex.ToString());
			}
		}

		public int method_8(int cx, int cy)
		{
			for (int i = cy; i < GClass20.int_24 - 24; i += 24)
			{
				if (GClass20.smethod_28(cx, i, 2))
					return i - i % 24;
			}
			int num = cy;
			while (num > 24)
			{
				if (!GClass20.smethod_28(cx, num, 2))
				{
					num -= 24;
					continue;
				}
				return num - num % 24;
			}
			return cy;
		}

		public int method_9()
		{
			int num = 0;
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				GClass78 gClass = (GClass78)GClass144.gclass88_5.method_3(i);
				if (gClass != null && gClass.string_3 != null && gClass.string_3 != "" && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.int_13 > 0)
					num++;
			}
			return num;
		}

		public void method_10(int x, int y)
		{
			GClass78.smethod_1().int_4 = x;
			GClass78.smethod_1().int_5 = y;
			GClass7.smethod_0().method_44();
			GClass78.smethod_1().int_4 = x;
			GClass78.smethod_1().int_5 = method_8(x, y) + 12;
			GClass7.smethod_0().method_44();
			GClass78.smethod_1().int_4 = x;
			GClass78.smethod_1().int_5 = y;
			GClass7.smethod_0().method_44();
		}

		public void method_11()
		{
			if (int_0 != -1 && !GClass148.smethod_0().bool_0 && GClass144.smethod_8().int_63 != null && GClass20.int_37 != 21 + GClass78.smethod_1().int_14 && (GClass20.int_37 > 50 || GClass20.int_37 < 45) && GClass20.int_37 != 154 && GClass20.int_37 != 153 && (GClass20.int_37 > 138 || GClass20.int_37 < 135) && GClass203.smethod_18() - long_3 > 1000L && ((GClass153.smethod_0().method_6() && GClass144.smethod_8().int_63[int_0] < 25) || (!GClass153.smethod_0().method_6() && 15 - GClass144.smethod_8().int_63[int_0] > 0)) && GClass20.int_39 != int_0)
			{
				GClass7.smethod_0().method_42(int_0, -1);
				long_3 = GClass203.smethod_18();
			}
		}

		public static void smethod_1()
		{
			try
			{
				if (!smethod_0().bool_5 || (GClass78.smethod_1().int_11 != 2 && GClass78.smethod_1().int_11 != 4 && GClass78.smethod_1().int_11 != 10))
					return;
				int num = GClass78.smethod_1().int_4 + GClass78.smethod_1().int_12 * 24;
				if (GClass20.smethod_27(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5 - 24) != 0 || GClass20.smethod_27(num, GClass78.smethod_1().int_5 - 24) <= 0 || GClass20.smethod_27(num, GClass78.smethod_1().int_5 - 24) >= 14)
					return;
				int num2 = 0;
				for (int i = 6; i < GClass20.int_22; i++)
				{
					if (GClass20.smethod_26(num / GClass20.sbyte_0, i) != 0)
					{
						num2 = i;
						break;
					}
				}
				GClass78.smethod_1().int_4 = num;
				GClass78.smethod_1().int_5 = num2 * GClass20.sbyte_0;
				GClass7.smethod_0().method_44();
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/crossTerrain.txt", ex.ToString());
			}
		}

		private void method_12()
		{
			method_15();
			int num = GClass20.gclass88_0.method_2();
			if (num == 2)
			{
				GClass181 gClass = (GClass181)GClass20.gclass88_0.method_3(0);
				GClass181 gClass2 = (GClass181)GClass20.gclass88_0.method_3(1);
				if ((gClass.short_2 < 60 && gClass2.short_2 < 60) || (gClass.short_0 > GClass20.int_23 - 60 && gClass2.short_0 > GClass20.int_23 - 60))
				{
					int_5[0] = gClass.short_0 + 15;
					int_5[1] = gClass.short_3;
					int_7[0] = gClass2.short_2 - 15;
					int_7[1] = gClass2.short_3;
				}
				else if (gClass.short_2 < gClass2.short_2)
				{
					int_5[0] = gClass.short_0 + 15;
					int_5[1] = gClass.short_3;
					int_7[0] = gClass2.short_2 - 15;
					int_7[1] = gClass2.short_3;
				}
				else
				{
					int_5[0] = gClass2.short_0 + 15;
					int_5[1] = gClass2.short_3;
					int_7[0] = gClass.short_2 - 15;
					int_7[1] = gClass.short_3;
				}
				return;
			}
			for (int i = 0; i < num; i++)
			{
				GClass181 gClass3 = (GClass181)GClass20.gclass88_0.method_3(i);
				if (gClass3.short_2 >= 60)
				{
					if (gClass3.short_2 <= GClass20.int_23 - 60)
					{
						int_6[0] = gClass3.short_0 + 15;
						int_6[1] = gClass3.short_3;
					}
					else
					{
						int_7[0] = gClass3.short_2 - 15;
						int_7[1] = gClass3.short_3;
					}
				}
				else
				{
					int_5[0] = gClass3.short_0 + 15;
					int_5[1] = gClass3.short_3;
				}
			}
		}

		public int method_13(int x)
		{
			int num = 50;
			int num2 = 0;
			while (num2 < 30)
			{
				num2++;
				num += 24;
				if (GClass20.smethod_28(x, num, 2))
				{
					if (num % 24 != 0)
						num -= num % 24;
					break;
				}
			}
			return num;
		}

		public void method_14(int x, int y)
		{
			if (GClass144.bool_69)
			{
				GClass78.smethod_1().int_4 = x;
				GClass78.smethod_1().int_5 = y;
				GClass7.smethod_0().method_44();
				return;
			}
			GClass78.smethod_1().int_4 = x;
			GClass78.smethod_1().int_5 = y;
			GClass7.smethod_0().method_44();
			GClass78.smethod_1().int_4 = x;
			GClass78.smethod_1().int_5 = y + 1;
			GClass7.smethod_0().method_44();
			GClass78.smethod_1().int_4 = x;
			GClass78.smethod_1().int_5 = y;
			GClass7.smethod_0().method_44();
		}

		private void method_15()
		{
			int_5 = new int[2];
			int_6 = new int[2];
			int_7 = new int[2];
		}

		public bool method_16()
		{
			return GClass20.int_37 >= 85 && GClass20.int_37 <= 91;
		}

		public static GClass181 smethod_2(int type)
		{
			if (GClass20.gclass88_0.method_2() == 1)
				return (GClass181)GClass20.gclass88_0.method_3(0);
			int num = 0;
			GClass181 gClass;
			while (true)
			{
				if (num < GClass20.gclass88_0.method_2())
				{
					gClass = (GClass181)GClass20.gclass88_0.method_3(num);
					if (type == 0)
					{
						if ((GClass20.int_37 == 70 && smethod_3(gClass.gclass45_0) == "Vực cấm") || (GClass20.int_37 == 73 && smethod_3(gClass.gclass45_0) == "Vực chết") || (GClass20.int_37 == 110 && smethod_3(gClass.gclass45_0) == "Rừng tuyết"))
							return gClass;
						if (gClass.short_2 < 60)
							return gClass;
					}
					if (type == 1)
					{
						if (((GClass20.int_37 == 106 || GClass20.int_37 == 107) && smethod_3(gClass.gclass45_0) == "Hang băng") || ((GClass20.int_37 == 105 || GClass20.int_37 == 108) && smethod_3(gClass.gclass45_0) == "Rừng băng") || (GClass20.int_37 == 109 && smethod_3(gClass.gclass45_0) == "Cánh đồng tuyết"))
							return gClass;
						if (GClass20.int_37 == 27)
							return null;
						if (gClass.short_0 < GClass20.int_23 - 60 && gClass.short_2 >= 60)
							return gClass;
					}
					if (type == 2)
					{
						if (GClass20.int_37 == 70 && smethod_3(gClass.gclass45_0) == "Căn cứ Raspberry")
							break;
						if (gClass.short_0 > GClass20.int_23 - 60)
							return gClass;
					}
					num++;
					continue;
				}
				return null;
			}
			return gClass;
		}

		public static string smethod_3(GClass45 popUp)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < popUp.string_0.Length; i++)
			{
				stringBuilder.Append(popUp.string_0[i]);
				stringBuilder.Append(" ");
			}
			return stringBuilder.ToString().Trim();
		}

		public void method_17(GClass181 waypoint)
		{
			if (!waypoint.bool_1)
				GClass7.smethod_0().method_40();
			else
				GClass7.smethod_0().method_114();
		}

		public void method_18(int position)
		{
			if (!method_16())
			{
				method_12();
				switch (position)
				{
				case 0:
					if (GClass20.int_37 == 70)
						method_14(10, 192);
					else if (int_5[0] != 0 && int_5[1] != 0)
					{
						method_14(int_5[0], int_5[1]);
					}
					else
					{
						method_14(60, method_13(60));
					}
					break;
				case 1:
					if (int_7[0] == 0 || int_7[1] == 0)
						method_14(GClass20.int_23 - 60, method_13(GClass20.int_23 - 60));
					else
						method_14(int_7[0], int_7[1]);
					break;
				case 2:
					if (int_6[0] == 0 || int_6[1] == 0)
						method_14(GClass20.int_23 / 2, method_13(GClass20.int_23 / 2));
					else
						method_14(int_6[0], int_6[1]);
					break;
				}
				if (GClass20.int_37 == 7 || GClass20.int_37 == 14 || GClass20.int_37 == 0)
					GClass7.smethod_0().method_114();
				else
					GClass7.smethod_0().method_40();
			}
			else
				method_19(position);
		}

		private void method_19(int int_9)
		{
			if (int_9 == 0)
			{
				method_14(60, method_13(60));
				return;
			}
			if (int_9 != 2)
			{
				method_14(GClass20.int_23 - 60, method_13(GClass20.int_23 - 60));
				return;
			}
			for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
			{
				GClass79 gClass = (GClass79)GClass144.gclass88_10.method_3(i);
				if (gClass.gclass127_0.int_0 >= 30 && gClass.gclass127_0.int_0 <= 36)
				{
					GClass78.smethod_1().gclass79_0 = gClass;
					method_14(gClass.int_4, gClass.int_5 - 3);
					break;
				}
			}
		}
	}
}
