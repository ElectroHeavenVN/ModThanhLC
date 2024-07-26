using System;
using System.Collections.Generic;

namespace AssemblyCSharp.Functions
{
	public class GClass164 : GInterface6
	{
		public struct GStruct12
		{
			public int int_0;

			public int int_1;

			public GStruct12(int skillID, int coolDown)
			{
				int_0 = skillID;
				int_1 = coolDown;
			}
		}

		private static GClass164 gclass164_0;

		public long[] long_0 = new long[10];

		public bool bool_0;

		public bool bool_1;

		public GClass88 gclass88_0 = new GClass88();

		public long long_1;

		public bool bool_2;

		public bool bool_3;

		public long long_2;

		public int[] int_0 = new int[3] { 24, 26, 25 };

		public bool bool_4;

		public long long_3;

		public long long_4;

		public bool bool_5;

		public bool bool_6;

		public bool bool_7;

		public long long_5;

		public long long_6;

		public bool bool_8;

		public int int_1 = -1;

		public List<GStruct12> list_0 = new List<GStruct12>();

		public bool bool_9 = false;

		public bool bool_10 = false;

		public long long_7;

		public bool bool_11;

		public bool bool_12;

		private static bool bool_13;

		private static long long_8;

		private static long long_9;

		public long long_10 = -1L;

		public static GClass164 smethod_0()
		{
			return (gclass164_0 != null) ? gclass164_0 : (gclass164_0 = new GClass164());
		}

		public bool method_0(string text)
		{
			switch (text)
			{
			case "/lockskill":
				bool_8 = !bool_8;
				int_1 = (bool_8 ? (GClass78.smethod_1().gclass63_0?.gclass47_0.sbyte_0).Value : (-1));
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto lock skill: " + GClass154.smethod_0().method_6(smethod_0().bool_8) + "!") : ("Tự động khóa skill: " + GClass154.smethod_0().method_6(smethod_0().bool_8) + "!"), 0);
				break;
			case "/autoskill":
				smethod_0().bool_4 = false;
				smethod_0().long_4 = 0L;
				GClass149.smethod_1((GClass151.int_0 != 0) ? "Turn off auto use skill!" : "Tự dùng chiêu đã tắt!", 0);
				break;
			default:
				if (GClass154.smethod_0().method_11<long>(text, "/autoskill"))
				{
					if (GClass154.smethod_0().method_12<long>(text, "/autoskill") == 0L)
					{
						smethod_0().bool_4 = false;
						smethod_0().long_4 = 0L;
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Turn off auto use skill!" : "Tự dùng chiêu đã tắt!", 0);
					}
					else
					{
						smethod_0().long_4 = GClass154.smethod_0().method_12<long>(text, "/autoskill");
						smethod_0().bool_4 = true;
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Tự dùng chiêu sau {smethod_0().long_4}ms : {GClass154.smethod_0().method_6(smethod_0().bool_4)}!" : $"Auto use skill after {smethod_0().long_4}ms : {GClass154.smethod_0().method_6(smethod_0().bool_4)}!", 0);
					}
					break;
				}
				if (!GClass154.smethod_0().method_11<int>(text, "/frz"))
					return false;
				if (GClass154.smethod_0().method_12<int>(text, "/frz") != 0)
				{
					GClass78.smethod_1().gclass63_0.int_1 = GClass154.smethod_0().method_12<int>(text, "/frz");
					GClass149.smethod_1((GClass151.int_0 != 0) ? string.Format("Fake skill cooldown: {0}: {1}", GClass78.smethod_1().gclass63_0.gclass47_0.string_0, GClass154.smethod_0().method_12<int>(text, "/frz")) : string.Format("Fake time hồi chiêu: {0}: {1}", GClass78.smethod_1().gclass63_0.gclass47_0.string_0, GClass154.smethod_0().method_12<int>(text, "/frz")), 0);
				}
				else
				{
					GClass78.smethod_1().gclass63_0.int_1 = 0;
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Freeze skill: " + GClass78.smethod_1().gclass63_0.gclass47_0.string_0) : ("Đóng băng: " + GClass78.smethod_1().gclass63_0.gclass47_0.string_0), 0);
				}
				break;
			case "/ats9g":
				smethod_0().bool_3 = !smethod_0().bool_3;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto train special skill by gold: " + GClass154.smethod_0().method_6(smethod_0().bool_3) + "!") : ("Tự động luyện tuyệt kĩ bằng vàng: " + GClass154.smethod_0().method_6(smethod_0().bool_3) + "!"), 0);
				break;
			case "/ats9":
				smethod_0().bool_2 = !smethod_0().bool_2;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto train special skill: " + GClass154.smethod_0().method_6(smethod_0().bool_2) + "!") : ("Tự động luyện tuyệt kĩ: " + GClass154.smethod_0().method_6(smethod_0().bool_2) + "!"), 0);
				break;
			case "/rcvs":
				smethod_0().bool_5 = !smethod_0().bool_5;
				smethod_0().bool_6 = false;
				smethod_0().bool_7 = false;
				if (GClass148.smethod_0().bool_0)
					Class21.smethod_0().method_9();
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto recovering skill: " + GClass154.smethod_0().method_6(smethod_0().bool_5) + "!") : ("Tự động đi hồi skill: " + GClass154.smethod_0().method_6(smethod_0().bool_5) + "!"), 0);
				break;
			case "/faster":
				bool_11 = !bool_11;
				break;
			}
			return true;
		}

		public bool method_1(int asciiCode)
		{
			if (asciiCode != 97)
			{
				if (asciiCode != 111)
				{
					if (asciiCode != 117)
						return false;
					smethod_0().method_0("/rcvs");
				}
				else
					method_5();
			}
			else
			{
				smethod_0().bool_0 = !smethod_0().bool_0;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto Attack: " + GClass154.smethod_0().method_6(smethod_0().bool_0)) : ("Tự động đánh: " + GClass154.smethod_0().method_6(smethod_0().bool_0)), 0);
			}
			return true;
		}

		public void perform(int idAction, object p)
		{
			if (GClass148.smethod_0().bool_0 || GClass159.smethod_0().bool_18)
				return;
			if (idAction != 10004)
			{
				if (idAction != 50001)
				{
					switch (idAction)
					{
					case 101501:
						method_10();
						break;
					case 101502:
						bool_1 = !bool_1;
						GClass149.smethod_1((GClass151.int_0 == 0) ? ("Chuyển sang trói " + ((!bool_1) ? "lần lượt" : "đè mục tiêu")) : ("Change to hold " + (bool_1 ? "on object" : "wait object")), 0);
						break;
					case 101503:
						method_0("/ats9");
						break;
					}
				}
				else if (!GClass159.smethod_0().bool_18)
				{
					GClass63 gClass = (GClass63)p;
					if (gclass88_0.method_1(gClass))
					{
						gclass88_0.method_8(gClass);
						GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? ("Đã xóa skill " + gClass.gclass47_0.string_0) : ("Deleted skill " + gClass.gclass47_0.string_0), 0);
					}
					else
					{
						gclass88_0.method_0(gClass);
						GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? ("Đã thêm skill " + gClass.gclass47_0.string_0) : ("Added skill " + gClass.gclass47_0.string_0), 0);
					}
				}
				return;
			}
			GClass88 gClass2 = new GClass88();
			gClass2.method_0(new GClass87((GClass151.int_0 == 0) ? "Danh sách\nCác skill\nAuto" : "List Skill\nAuto Use", this, 101501, null));
			if (GClass78.smethod_1().int_14 == 2)
				gClass2.method_0(new GClass87((GClass151.int_0 != 0) ? ("Mode Hold:\n" + ((!bool_1) ? "Wait Object" : "On Object")) : ("Chuyển chế\nđộ trói:\n" + ((!bool_1) ? "lần lượt" : "Đè m.tiêu")), this, 101502, null));
			for (int i = 0; i < GClass144.gclass63_0.Length; i++)
			{
				GClass63 gClass3 = GClass144.gclass63_0[i];
				if (gClass3 != null && gClass3.gclass47_0.sbyte_0 == int_0[GClass78.smethod_1().int_14])
					gClass2.method_0(new GClass87((GClass151.int_0 != 0) ? ("Auto train\nSpecial Skill:\n" + GClass154.smethod_0().method_7(bool_2)) : ("Auto train\ntuyệt kỹ:\n" + GClass154.smethod_0().method_7(bool_2)), this, 101503, null));
			}
			GClass73.gclass145_0.bool_1 = true;
			GClass73.gclass145_0.method_2(gClass2, 0);
		}

		public void method_2()
		{
			method_12();
			if (bool_0)
				method_15();
			method_9();
			method_8();
			method_6();
			method_7();
			method_4();
		}

		public void method_3(string s)
		{
			if (s.ToLower().Contains("số thứ tự") && bool_5)
				bool_6 = true;
		}

		public void method_4()
		{
			if (!bool_8 || int_1 < 0)
				return;
			for (int i = 0; i < GClass144.gclass63_0.Length; i++)
			{
				GClass63 gClass = GClass144.gclass63_0[i];
				if (gClass != null && gClass.gclass47_0.sbyte_0 == int_1 && GClass78.smethod_1().gclass63_0 != gClass && GClass203.smethod_18() - long_6 > 3000L)
				{
					GClass144.smethod_8().method_62(gClass, false);
					long_6 = GClass203.smethod_18();
				}
			}
		}

		public void method_5()
		{
			if (GClass78.smethod_1().gclass63_0.int_1 != 0)
			{
				if (!list_0.Contains(new GStruct12(GClass78.smethod_1().gclass63_0.short_0, GClass78.smethod_1().gclass63_0.int_1)))
					list_0.Add(new GStruct12(GClass78.smethod_1().gclass63_0.short_0, GClass78.smethod_1().gclass63_0.int_1));
				else
					method_0("/frz0");
				return;
			}
			foreach (GStruct12 item in list_0)
			{
				if (item.int_0 == GClass78.smethod_1().gclass63_0.short_0)
				{
					GClass78.smethod_1().gclass63_0.int_1 = item.int_1;
					list_0.Remove(item);
					GClass149.smethod_1((GClass151.int_0 != 0) ? "Skill back to normal" : "Skill đã trở về trạng thái bình thường", 0);
				}
			}
		}

		public void method_6()
		{
			if (!bool_2 || GClass78.smethod_1().bool_47)
				return;
			try
			{
				for (int i = 0; i < GClass144.gclass63_0.Length; i++)
				{
					GClass63 gClass = GClass144.gclass63_0[i];
					if (gClass == null || gClass.gclass47_0.sbyte_0 != int_0[GClass78.smethod_1().int_14])
						continue;
					int num = ((gClass.gclass47_0.int_2 == 2) ? 1 : ((gClass.gclass47_0.int_2 == 1) ? (gClass.int_5 * GClass78.smethod_1().int_36 / 100) : gClass.int_5));
					if (GClass78.smethod_1().int_24 < num || GClass203.smethod_18() - gClass.long_1 <= gClass.int_1 + 500)
						continue;
					if (GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == gClass.gclass47_0.sbyte_0)
					{
						GClass73.smethod_1().method_10(49 + i);
						GClass78.smethod_1().gclass63_0.long_1 = GClass203.smethod_18();
						continue;
					}
					if (GClass203.smethod_18() - long_1 > 1000L)
					{
						GClass144.smethod_8().method_62(gClass, false);
						long_1 = GClass203.smethod_18();
					}
					break;
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/autoTrainSpecialSkill.txt", ex.ToString());
			}
		}

		public void method_7()
		{
			if (!bool_3)
				return;
			if (GClass20.int_37 != 129)
			{
				bool_9 = false;
				if (!GClass148.smethod_0().bool_0)
					Class21.smethod_0().method_8(129);
				return;
			}
			for (int i = 0; i < GClass144.gclass63_0.Length; i++)
			{
				GClass63 gClass = GClass144.gclass63_0[i];
				if (gClass == null || gClass.gclass47_0.sbyte_0 != int_0[GClass78.smethod_1().int_14])
					continue;
				int num = ((gClass.gclass47_0.int_2 == 2) ? 1 : ((gClass.gclass47_0.int_2 == 1) ? (gClass.int_5 * GClass78.smethod_1().int_36 / 100) : gClass.int_5));
				if (GClass203.smethod_18() - gClass.long_1 <= gClass.int_1 + 200)
				{
					if (!GClass78.smethod_1().bool_77)
					{
						if (GClass78.smethod_1().int_5 == 264)
						{
							for (int j = 0; j < GClass144.gclass88_5.method_2(); j++)
							{
								if (GClass144.gclass88_5.method_3(j) is GClass78 gClass2 && gClass2.int_13 < 0 && gClass2.int_13 != -114 && GClass203.smethod_18() - long_5 > 1000L && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass2.int_4, gClass2.int_5) < 10)
								{
									GClass73.smethod_1().method_10(106);
									long_5 = GClass203.smethod_18();
								}
							}
						}
						for (int k = 0; k < GClass144.gclass88_10.method_2(); k++)
						{
							if (!(GClass144.gclass88_10.method_3(k) is GClass79 gClass3) || gClass3.gclass127_0.int_0 != 23 || GClass78.smethod_1().int_5 != 408 || bool_9 || GClass203.smethod_18() - long_5 <= 1000L)
								continue;
							if (GClass73.gclass145_0.bool_0)
							{
								for (int l = 0; l < GClass73.gclass145_0.gclass88_0.method_2(); l++)
								{
									if (GClass73.gclass145_0.gclass88_0.method_3(l) is GClass87 gClass4 && gClass4.string_0.ToLower().Contains((mResources.language != 0) ? "gold" : "vàng"))
									{
										GClass7.smethod_0().method_59((short)gClass3.gclass127_0.int_0, (sbyte)l);
										GClass162.smethod_0().method_0();
										bool_9 = true;
										long_5 = GClass203.smethod_18();
									}
								}
								continue;
							}
							GClass7.smethod_0().method_60((short)gClass3.gclass127_0.int_0);
							long_5 = GClass203.smethod_18();
							return;
						}
						continue;
					}
					if (GClass73.gclass145_0.bool_0)
						GClass162.smethod_0().method_0();
					break;
				}
				if (GClass78.smethod_1().int_24 >= num)
				{
					if (GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == gClass.gclass47_0.sbyte_0)
					{
						GClass73.smethod_1().method_10(49 + i);
						GClass78.smethod_1().gclass63_0.long_1 = GClass203.smethod_18();
						bool_9 = false;
					}
					else if (GClass203.smethod_18() - long_1 > 1000L)
					{
						GClass144.smethod_8().method_62(gClass, false);
						long_1 = GClass203.smethod_18();
					}
				}
				break;
			}
		}

		public void method_8()
		{
			if (!bool_5 || bool_7)
				return;
			try
			{
				if (GClass148.smethod_0().bool_0)
					return;
				if (GClass20.int_37 != 129)
				{
					Class21.smethod_0().method_8(129);
					return;
				}
				for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
				{
					if (!(GClass144.gclass88_10.method_3(i) is GClass79 gClass) || gClass.gclass127_0.int_0 != 23)
						continue;
					if (GClass78.smethod_1().int_5 <= 264)
					{
						if (bool_11)
							Class21.smethod_0().method_8(52);
						bool_7 = true;
						bool_5 = false;
						GClass149.smethod_1((GClass151.int_0 == 0) ? "Skill đã được hồi!" : "Skills is recovered", 0);
						continue;
					}
					if (bool_6 || GClass203.smethod_18() - long_5 <= 1000L)
						break;
					if (GClass73.gclass145_0.bool_0)
					{
						for (int j = 0; j < GClass73.gclass145_0.gclass88_0.method_2(); j++)
						{
							if (GClass73.gclass145_0.gclass88_0.method_3(j) is GClass87 gClass2 && gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "vàng" : "gold"))
							{
								GClass7.smethod_0().method_59((short)gClass.gclass127_0.int_0, (sbyte)j);
								GClass162.smethod_0().method_0();
								long_5 = GClass203.smethod_18();
							}
						}
					}
					else
					{
						GClass7.smethod_0().method_60((short)gClass.gclass127_0.int_0);
						long_5 = GClass203.smethod_18();
					}
					break;
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/recoveringSkill.txt", ex.ToString());
			}
		}

		public void method_9()
		{
			try
			{
				if (!bool_4 || GClass203.smethod_18() - long_3 <= long_4)
					return;
				if (GClass78.smethod_1().gclass63_0.gclass47_0.int_3 != 3)
				{
					if (GClass78.smethod_1().gclass194_0 != null)
					{
						GClass88 gClass = new GClass88();
						gClass.method_0(GClass78.smethod_1().gclass194_0);
						GClass7.smethod_0().method_73(gClass, new GClass88(), -1);
						long_3 = GClass203.smethod_18();
					}
					else if (GClass78.smethod_1().gclass78_0 != null)
					{
						GClass88 gClass2 = new GClass88();
						gClass2.method_0(GClass78.smethod_1().gclass78_0);
						GClass7.smethod_0().method_73(new GClass88(), gClass2, -1);
						long_3 = GClass203.smethod_18();
					}
				}
				else
				{
					GClass144.smethod_8().method_64(GClass78.smethod_1().gclass63_0);
					long_3 = GClass203.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/autoSkillbyTime.txt", ex.ToString());
			}
		}

		public void method_10()
		{
			GClass88 gClass = new GClass88();
			GClass63[] gclass63_ = GClass144.gclass63_0;
			foreach (GClass63 gClass2 in gclass63_)
			{
				if (gClass2 != null && (gClass2.gclass47_0.int_3 == 3 || gClass2.gclass47_0.int_3 == 2))
					gClass.method_0(new GClass87(gClass2.gclass47_0.string_0 + "\n" + GClass154.smethod_0().method_7(gclass88_0.method_1(gClass2)), this, 50001, gClass2));
			}
			GClass73.gclass145_0.bool_1 = true;
			GClass73.gclass145_0.method_2(gClass, 0);
		}

		public void method_11()
		{
			for (int i = 0; i < GClass144.gclass63_0.Length; i++)
			{
				GClass63 gClass = GClass144.gclass63_0[i];
				if (gClass == null || gClass.gclass47_0.sbyte_0 != 5)
					continue;
				if (GClass78.smethod_1().gclass63_0 == gClass)
				{
					if (GClass203.smethod_18() - long_1 > 550L)
					{
						if (!GClass153.smethod_0().method_6() && GClass78.smethod_1().gclass78_0 == null)
							break;
						GClass88 gClass2 = new GClass88();
						gClass2.method_0((GClass78.smethod_1().sbyte_28 == 8) ? GClass78.smethod_1() : GClass78.smethod_1().gclass78_0);
						GClass7.smethod_0().method_73(new GClass88(), gClass2, -1);
						gClass.long_1 = GClass203.smethod_18();
						bool_12 = true;
					}
					continue;
				}
				GClass144.smethod_8().method_62(gClass, true);
				long_1 = GClass203.smethod_18();
				break;
			}
		}

		public void method_12()
		{
			try
			{
				if (GClass20.int_37 == 21 + GClass78.smethod_1().int_14 || GClass203.smethod_18() - long_1 < 1000L || GClass78.smethod_1().bool_47 || GClass78.smethod_1().bool_60 || GClass144.bool_70 || GClass78.smethod_1().int_11 == 14 || GClass78.smethod_1().int_11 == 5 || GClass78.smethod_1().bool_23 || GClass78.smethod_1().bool_46 || GClass78.smethod_1().method_68())
					return;
				GClass63[] array = (GClass73.bool_5 ? GClass144.gclass63_1 : GClass144.gclass63_0);
				foreach (GClass63 gClass in array)
				{
					if (GClass159.smethod_0().bool_18 && (GClass159.smethod_0().bool_19 || GClass159.smethod_0().bool_21))
						break;
					if (bool_12 || !GClass78.smethod_1().gclass163_0.bool_3)
					{
						if (gClass == null || !gclass88_0.method_1(gClass) || GClass203.smethod_18() - gClass.long_1 <= gClass.int_1 + 100 || gClass.gclass47_0.int_3 == 2)
						{
							if (gClass == null || !gclass88_0.method_1(gClass) || GClass203.smethod_18() - gClass.long_1 <= gClass.int_1 + 100 || gClass.gclass47_0.int_3 != 2)
								continue;
							int num = 0;
							int num2 = ((gClass.gclass47_0.int_2 == 2) ? 1 : ((gClass.gclass47_0.int_2 == 1) ? (gClass.int_5 * GClass78.smethod_1().int_36 / 100) : gClass.int_5));
							if (GClass78.smethod_1().int_24 >= num2)
							{
								if (gClass == GClass78.smethod_1().gclass63_0)
								{
									GClass88 gClass2 = new GClass88();
									gClass2.method_0(GClass78.smethod_1());
									GClass7.smethod_0().method_73(new GClass88(), gClass2, -1);
									gClass.long_1 = GClass203.smethod_18();
								}
								else
								{
									GClass144.smethod_8().method_62(gClass, true);
									long_1 = GClass203.smethod_18();
								}
								break;
							}
							continue;
						}
						int num3 = 0;
						if (GClass171.smethod_0().method_1())
							break;
						bool flag = GClass78.smethod_1().gclass163_0.bool_10 && GClass78.smethod_1().gclass163_0.int_8 > 1;
						bool flag2 = GClass78.smethod_1().gclass163_0.bool_6 && GClass78.smethod_1().gclass163_0.int_5 > 1;
						bool flag3 = GClass78.smethod_1().gclass163_0.bool_7;
						bool flag4 = GClass78.smethod_1().gclass163_0.bool_11;
						bool flag5 = GClass78.smethod_1().gclass163_0.bool_1;
						if ((flag && gClass.gclass47_0.sbyte_0 != 19 && gClass.gclass47_0.sbyte_0 != 6 && gClass.gclass47_0.sbyte_0 != 8 && gClass.gclass47_0.sbyte_0 != 13 && gClass.gclass47_0.sbyte_0 != 14 && gClass.gclass47_0.sbyte_0 != 21) || flag2 || flag3 || flag4 || flag5 || (GClass78.smethod_1().gclass163_0.bool_3 && gClass.gclass47_0.sbyte_0 == 13 && !gClass.bool_0) || GClass78.smethod_1().gclass163_0.bool_7 || (gClass.gclass47_0.sbyte_0 == 19 && GClass78.smethod_1().gclass163_0.bool_5) || (GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 8 && (GClass78.smethod_1().int_25 > GClass78.smethod_1().int_35 * 50 / 100 || GClass78.smethod_1().int_24 > GClass78.smethod_1().int_36 * 20 / 100)))
							break;
						int num4 = ((gClass.gclass47_0.int_2 == 2) ? 1 : ((gClass.gclass47_0.int_2 == 1) ? (gClass.int_5 * GClass78.smethod_1().int_36 / 100) : gClass.int_5));
						if (GClass78.smethod_1().int_24 < num4)
							continue;
						if (gClass != GClass78.smethod_1().gclass63_0)
						{
							GClass144.smethod_8().method_62(gClass, true);
							GClass171.smethod_0().method_0(200);
							long_1 = GClass203.smethod_18();
						}
						else if (GClass203.smethod_18() - long_1 > 1000L)
						{
							if (gClass.gclass47_0.sbyte_0 == 13)
								bool_12 = false;
							GClass144.smethod_8().method_64(gClass);
							gClass.long_1 = GClass203.smethod_18();
						}
						break;
					}
					method_11();
					break;
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/AutoSkillNotFocus.txt", ex.ToString());
			}
		}

		public static void smethod_1(int time)
		{
			bool_13 = true;
			long_8 = GClass203.smethod_18();
			long_9 = time;
		}

		public static bool smethod_2()
		{
			if (bool_13 && GClass203.smethod_18() - long_8 >= long_9)
				bool_13 = false;
			return bool_13;
		}

		public int method_13()
		{
			for (int i = 0; i < GClass144.gclass63_0.Length; i++)
			{
				if (GClass144.gclass63_0[i] == GClass78.smethod_1().gclass63_0)
					return i;
			}
			return 0;
		}

		public long method_14(GClass63 skill)
		{
			if (skill.gclass47_0.sbyte_0 != 20 && skill.gclass47_0.sbyte_0 != 22 && skill.gclass47_0.sbyte_0 != 7 && skill.gclass47_0.sbyte_0 != 18 && skill.gclass47_0.sbyte_0 != 23)
			{
				long num = (long)((double)skill.int_1 * 1.2);
				if (num >= 415L)
					return num;
				return 415L;
			}
			return skill.int_1;
		}

		public void method_15()
		{
			try
			{
				GClass78 gClass = GClass78.smethod_1();
				GClass78 gclass78_ = gClass.gclass78_0;
				GClass194 gclass194_ = gClass.gclass194_0;
				if (GClass78.smethod_1().bool_62 || GClass78.smethod_1().int_25 <= 0 || GClass78.smethod_1().int_11 == 14 || GClass78.smethod_1().int_11 == 5 || GClass78.smethod_1().gclass63_0.gclass47_0.int_3 == 3 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 10 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 11 || (GClass78.smethod_1().gclass63_0.bool_0 && !GClass73.gclass76_0.bool_0))
					return;
				int num = method_13();
				if (!smethod_4(GClass78.smethod_1().gclass63_0) || (long_10 != -1L && GClass203.smethod_18() - long_10 < 550L))
					return;
				sbyte sbyte_ = gClass.gclass63_0.gclass47_0.sbyte_0;
				if (sbyte_ != 7)
				{
					if (sbyte_ != 23)
					{
						if (GClass203.smethod_18() - long_0[num] <= method_14(gClass.gclass63_0) || gClass.gclass63_0.gclass47_0.sbyte_0 == 23)
							return;
						if (gclass194_ == null || !GClass144.smethod_8().method_31(gclass194_) || !((double)GClass118.smethod_0(GClass78.smethod_1().gclass194_0.int_16 - GClass78.smethod_1().int_4) < (double)GClass78.smethod_1().gclass63_0.int_2 * 3.0))
						{
							if (gclass78_ != null && smethod_3(gclass78_) && (double)GClass118.smethod_0(GClass78.smethod_1().gclass78_0.int_4 - GClass78.smethod_1().int_4) < (double)GClass78.smethod_1().gclass63_0.int_2 * 2.0)
							{
								GClass78.smethod_1().gclass63_0.long_1 = GClass203.smethod_18();
								smethod_5();
								long_0[num] = GClass203.smethod_18();
							}
						}
						else
						{
							GClass78.smethod_1().gclass63_0.long_1 = GClass203.smethod_18();
							smethod_6();
							long_0[num] = GClass203.smethod_18();
						}
					}
					else
					{
						if (GClass203.smethod_18() - long_0[num] <= method_14(gClass.gclass63_0))
							return;
						if (!bool_1)
						{
							if (gclass194_ != null && gclass194_.int_5 != 32 && GClass144.smethod_8().method_31(gclass194_))
							{
								gClass.gclass63_0.long_1 = GClass203.smethod_18();
								smethod_6();
								long_0[num] = GClass203.smethod_18();
							}
							else if (gclass78_ != null && gclass78_.int_159 != 32 && smethod_3(gclass78_))
							{
								gClass.gclass63_0.long_1 = GClass203.smethod_18();
								smethod_5();
								long_0[num] = GClass203.smethod_18();
							}
						}
						else if (gclass78_ != null && smethod_3(gclass78_))
						{
							gClass.gclass63_0.long_1 = GClass203.smethod_18();
							smethod_5();
							long_0[num] = GClass203.smethod_18();
						}
					}
				}
				else if (GClass203.smethod_18() - long_0[num] > method_14(gClass.gclass63_0) && gclass78_ != null)
				{
					gClass.gclass63_0.long_1 = GClass203.smethod_18();
					smethod_5();
					long_0[num] = GClass203.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/SendAttack.txt", ex.ToString());
			}
		}

		public static bool smethod_3(GClass78 ch)
		{
			if (GClass20.int_37 != 113)
			{
				if (ch == null || GClass78.smethod_1().gclass63_0 == null)
					return false;
				if (ch.int_11 != 14 && ch.int_11 != 5 && GClass78.smethod_1().gclass63_0.gclass47_0.int_3 != 2 && ((GClass78.smethod_1().sbyte_28 == 8 && ch.sbyte_28 != 0) || (GClass78.smethod_1().sbyte_28 != 0 && ch.sbyte_28 == 8) || (GClass78.smethod_1().sbyte_28 != ch.sbyte_28 && GClass78.smethod_1().sbyte_28 != 0 && ch.sbyte_28 != 0) || (ch.sbyte_19 == 3 && GClass78.smethod_1().sbyte_19 == 3) || GClass78.smethod_1().sbyte_19 == 5 || ch.sbyte_19 == 5 || (GClass78.smethod_1().sbyte_19 == 1 && ch.sbyte_19 == 1) || (GClass78.smethod_1().sbyte_19 == 4 && ch.sbyte_19 == 4)))
					return true;
				if (GClass78.smethod_1().gclass63_0.gclass47_0.int_3 != 2)
					return false;
				return ch.sbyte_19 != 5;
			}
			if (ch != null && GClass78.smethod_1().gclass63_0 != null)
			{
				if (ch.sbyte_19 == 5)
					return true;
				return ch.sbyte_19 == 3;
			}
			return false;
		}

		private static bool smethod_4(GClass63 gclass63_0)
		{
			if (gclass63_0.gclass47_0.int_2 != 2)
			{
				if (gclass63_0.gclass47_0.int_2 == 1)
					return GClass78.smethod_1().int_24 >= gclass63_0.int_5 * GClass78.smethod_1().int_36 / 100;
				return GClass78.smethod_1().int_24 >= gclass63_0.int_5;
			}
			return true;
		}

		private static void smethod_5()
		{
			try
			{
				GClass88 gClass = new GClass88();
				gClass.method_0(GClass78.smethod_1().gclass78_0);
				GClass7.smethod_0().method_73(new GClass88(), gClass, 2);
				smethod_0().long_10 = -1L;
			}
			catch
			{
			}
		}

		private static void smethod_6()
		{
			try
			{
				GClass88 gClass = new GClass88();
				gClass.method_0(GClass78.smethod_1().gclass194_0);
				GClass7.smethod_0().method_73(gClass, new GClass88(), 1);
				smethod_0().long_10 = -1L;
			}
			catch
			{
			}
		}
	}
}
