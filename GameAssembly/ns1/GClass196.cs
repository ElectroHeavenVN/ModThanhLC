using System;
using System.Collections.Generic;

namespace ns1
{
	public class GClass196 : GInterface0
	{
		public struct GStruct10
		{
			public int int_0;

			public int int_1;

			public GStruct10(int skillID, int coolDown)
			{
				int_0 = skillID;
				int_1 = coolDown;
			}
		}

		private static GClass196 gclass196_0;

		public long[] long_0 = new long[10];

		public bool bool_0;

		public bool bool_1;

		public GClass63 gclass63_0 = new GClass63();

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

		public List<GStruct10> list_0 = new List<GStruct10>();

		public bool bool_8 = false;

		public bool bool_9 = false;

		public long long_6;

		private static bool bool_10;

		private static long long_7;

		private static long long_8;

		public static GClass196 smethod_0()
		{
			return (gclass196_0 != null) ? gclass196_0 : (gclass196_0 = new GClass196());
		}

		public bool method_0(string text)
		{
			switch (text)
			{
			default:
				if (GClass193.smethod_0().method_10<long>(text, "/ak"))
				{
					if (GClass193.smethod_0().method_11<long>(text, "/ak") == 0L)
					{
						smethod_0().bool_4 = false;
						smethod_0().long_4 = 0L;
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Tự dùng chiêu đã tắt!" : "Turn off auto use skill!", 0);
					}
					else
					{
						smethod_0().long_4 = GClass193.smethod_0().method_11<long>(text, "/ak");
						smethod_0().bool_4 = true;
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự dùng chiêu sau {smethod_0().long_4}ms : {GClass193.smethod_0().method_6(smethod_0().bool_4)}!" : $"Auto use skill after {smethod_0().long_4}ms : {GClass193.smethod_0().method_6(smethod_0().bool_4)}!", 0);
					}
					break;
				}
				if (GClass193.smethod_0().method_10<int>(text, "/frz"))
				{
					if (GClass193.smethod_0().method_11<int>(text, "/frz") == 0)
					{
						GClass58.smethod_1().gclass74_0.int_1 = 0;
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đóng băng: " + GClass58.smethod_1().gclass74_0.gclass53_0.string_0) : ("Freeze skill: " + GClass58.smethod_1().gclass74_0.gclass53_0.string_0), 0);
					}
					else
					{
						GClass58.smethod_1().gclass74_0.int_1 = GClass193.smethod_0().method_11<int>(text, "/frz");
						GClass188.smethod_1((GClass192.int_0 == 0) ? string.Format("Fake time hồi chiêu: {0}: {1}", GClass58.smethod_1().gclass74_0.gclass53_0.string_0, GClass193.smethod_0().method_11<int>(text, "/frz")) : string.Format("Fake skill cooldown: {0}: {1}", GClass58.smethod_1().gclass74_0.gclass53_0.string_0, GClass193.smethod_0().method_11<int>(text, "/frz")), 0);
					}
					break;
				}
				return false;
			case "/ats9g":
				smethod_0().bool_3 = !smethod_0().bool_3;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động luyện tuyệt kĩ bằng vàng: " + GClass193.smethod_0().method_6(smethod_0().bool_3) + "!") : ("Auto train special skill by gold: " + GClass193.smethod_0().method_6(smethod_0().bool_3) + "!"), 0);
				break;
			case "/ats9":
				smethod_0().bool_2 = !smethod_0().bool_2;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động luyện tuyệt kĩ: " + GClass193.smethod_0().method_6(smethod_0().bool_2) + "!") : ("Auto train special skill: " + GClass193.smethod_0().method_6(smethod_0().bool_2) + "!"), 0);
				break;
			case "/rcvs":
				smethod_0().bool_5 = !smethod_0().bool_5;
				smethod_0().bool_6 = false;
				smethod_0().bool_7 = false;
				if (GClass171.smethod_0().bool_0)
					Class14.smethod_0().method_8();
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động đi hồi skill: " + GClass193.smethod_0().method_6(smethod_0().bool_5) + "!") : ("Auto recovering skill: " + GClass193.smethod_0().method_6(smethod_0().bool_5) + "!"), 0);
				break;
			case "/ak":
				smethod_0().bool_4 = false;
				smethod_0().long_4 = 0L;
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Tự dùng chiêu đã tắt!" : "Turn off auto use skill!", 0);
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
					method_4();
			}
			else
			{
				smethod_0().bool_0 = !smethod_0().bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động đánh: " + GClass193.smethod_0().method_6(smethod_0().bool_0)) : ("Auto Attack: " + GClass193.smethod_0().method_6(smethod_0().bool_0)), 0);
			}
			return true;
		}

		public void perform(int idAction, object p)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			if (idAction != 10004)
			{
				if (idAction != 50001)
				{
					switch (idAction)
					{
					case 101501:
						method_9();
						break;
					case 101502:
						bool_1 = !bool_1;
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Chuyển sang trói " + (bool_1 ? "đè mục tiêu" : "lần lượt")) : ("Change to hold " + (bool_1 ? "on object" : "wait object")), 0);
						break;
					case 101503:
						method_0("/ats9");
						break;
					}
				}
				else
				{
					GClass74 gClass = (GClass74)p;
					if (gclass63_0.method_1(gClass))
					{
						gclass63_0.method_8(gClass);
						GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? ("Đã xóa skill " + gClass.gclass53_0.string_0) : ("Deleted skill " + gClass.gclass53_0.string_0), 0);
					}
					else
					{
						gclass63_0.method_0(gClass);
						GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? ("Đã thêm skill " + gClass.gclass53_0.string_0) : ("Added skill " + gClass.gclass53_0.string_0), 0);
					}
				}
				return;
			}
			GClass63 gClass2 = new GClass63();
			gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? "Danh sách\nCác skill\nAuto" : "List Skill\nAuto Use", this, 101501, null));
			if (GClass58.smethod_1().int_14 == 2)
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Chuyển chế\nđộ trói:\n" + (bool_1 ? "Đè m.tiêu" : "lần lượt")) : ("Mode Hold:\n" + (bool_1 ? "On Object" : "Wait Object")), this, 101502, null));
			for (int i = 0; i < GClass154.gclass74_0.Length; i++)
			{
				GClass74 gClass3 = GClass154.gclass74_0[i];
				if (gClass3 != null && gClass3.gclass53_0.sbyte_0 == int_0[GClass58.smethod_1().int_14])
					gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? ("Auto train\ntuyệt kỹ:\n" + GClass193.smethod_0().method_7(bool_2)) : ("Auto train\nSpecial Skill:\n" + GClass193.smethod_0().method_7(bool_2)), this, 101503, null));
			}
			GClass39.gclass0_0.method_2(gClass2, 0);
		}

		public void method_2()
		{
			method_10();
			if (bool_0)
				method_13();
			method_8();
			method_7();
			method_5();
			method_6();
		}

		public void method_3(string s)
		{
			if (s.ToLower().Contains("số thứ tự") && bool_5)
				bool_6 = true;
		}

		public void method_4()
		{
			if (GClass58.smethod_1().gclass74_0.int_1 != 0)
			{
				if (!list_0.Contains(new GStruct10(GClass58.smethod_1().gclass74_0.short_0, GClass58.smethod_1().gclass74_0.int_1)))
					list_0.Add(new GStruct10(GClass58.smethod_1().gclass74_0.short_0, GClass58.smethod_1().gclass74_0.int_1));
				else
					method_0("/frz0");
				return;
			}
			foreach (GStruct10 item in list_0)
			{
				if (item.int_0 == GClass58.smethod_1().gclass74_0.short_0)
				{
					GClass58.smethod_1().gclass74_0.int_1 = item.int_1;
					list_0.Remove(item);
					GClass188.smethod_1((GClass192.int_0 == 0) ? "Skill đã trở về trạng thái bình thường" : "Skill back to normal", 0);
				}
			}
		}

		public void method_5()
		{
			if (!bool_2 || GClass58.smethod_1().bool_47)
				return;
			try
			{
				int num = 0;
				GClass74 gClass;
				while (true)
				{
					if (num >= GClass154.gclass74_0.Length)
						return;
					gClass = GClass154.gclass74_0[num];
					if (gClass != null && gClass.gclass53_0.sbyte_0 == int_0[GClass58.smethod_1().int_14])
					{
						int num2 = ((gClass.gclass53_0.int_2 == 2) ? 1 : ((gClass.gclass53_0.int_2 == 1) ? (gClass.int_5 * GClass58.smethod_1().int_36 / 100) : gClass.int_5));
						if (GClass58.smethod_1().int_24 >= num2 && GClass138.smethod_18() - gClass.long_1 > gClass.int_1 + 500)
						{
							if (GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 != gClass.gclass53_0.sbyte_0)
								break;
							GClass39.smethod_1().method_10(49 + num);
							GClass58.smethod_1().gclass74_0.long_1 = GClass138.smethod_18();
						}
					}
					num++;
				}
				if (GClass138.smethod_18() - long_1 > 1000L)
				{
					GClass154.smethod_8().method_62(gClass, false);
					long_1 = GClass138.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/autoTrainSpecialSkill.txt", ex.ToString());
			}
		}

		public void method_6()
		{
			if (!bool_3)
				return;
			if (GClass1.int_37 != 129)
			{
				bool_8 = false;
				if (!GClass171.smethod_0().bool_0)
					Class14.smethod_0().method_7(129);
				return;
			}
			for (int i = 0; i < GClass154.gclass74_0.Length; i++)
			{
				GClass74 gClass = GClass154.gclass74_0[i];
				if (gClass == null || gClass.gclass53_0.sbyte_0 != int_0[GClass58.smethod_1().int_14])
					continue;
				int num = ((gClass.gclass53_0.int_2 == 2) ? 1 : ((gClass.gclass53_0.int_2 == 1) ? (gClass.int_5 * GClass58.smethod_1().int_36 / 100) : gClass.int_5));
				if (GClass138.smethod_18() - gClass.long_1 <= gClass.int_1 + 200)
				{
					if (!GClass58.smethod_1().bool_77)
					{
						if (GClass58.smethod_1().int_5 == 264)
						{
							for (int j = 0; j < GClass154.gclass63_5.method_2(); j++)
							{
								if (GClass154.gclass63_5.method_3(j) is GClass58 gClass2 && gClass2.int_13 < 0 && gClass2.int_13 != -114 && GClass138.smethod_18() - long_5 > 1000L && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass2.int_4, gClass2.int_5) < 10)
								{
									GClass39.smethod_1().method_10(106);
									long_5 = GClass138.smethod_18();
								}
							}
						}
						for (int k = 0; k < GClass154.gclass63_10.method_2(); k++)
						{
							if (!(GClass154.gclass63_10.method_3(k) is GClass59 gClass3) || gClass3.gclass90_0.int_0 != 23 || GClass58.smethod_1().int_5 != 408 || bool_8 || GClass138.smethod_18() - long_5 <= 1000L)
								continue;
							if (GClass39.gclass0_0.bool_0)
							{
								for (int l = 0; l < GClass39.gclass0_0.gclass63_0.method_2(); l++)
								{
									if (GClass39.gclass0_0.gclass63_0.method_3(l) is GClass14 gClass4 && gClass4.string_0.ToLower().Contains((mResources.language == 0) ? "vàng" : "gold"))
									{
										GClass166.smethod_0().method_59((short)gClass3.gclass90_0.int_0, (sbyte)l);
										GClass198.smethod_0().method_0();
										bool_8 = true;
										long_5 = GClass138.smethod_18();
									}
								}
								continue;
							}
							GClass166.smethod_0().method_60((short)gClass3.gclass90_0.int_0);
							long_5 = GClass138.smethod_18();
							return;
						}
						continue;
					}
					if (GClass39.gclass0_0.bool_0)
						GClass198.smethod_0().method_0();
					break;
				}
				if (GClass58.smethod_1().int_24 < num)
					break;
				if (GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 != gClass.gclass53_0.sbyte_0)
				{
					if (GClass138.smethod_18() - long_1 > 1000L)
					{
						GClass154.smethod_8().method_62(gClass, false);
						long_1 = GClass138.smethod_18();
					}
				}
				else
				{
					GClass39.smethod_1().method_10(49 + i);
					GClass58.smethod_1().gclass74_0.long_1 = GClass138.smethod_18();
					bool_8 = false;
				}
				break;
			}
		}

		public void method_7()
		{
			if (!bool_5 || bool_7)
				return;
			try
			{
				if (GClass1.int_37 != 129)
				{
					if (!GClass171.smethod_0().bool_0)
						Class14.smethod_0().method_7(129);
					return;
				}
				int num = 0;
				GClass59 gClass;
				while (true)
				{
					if (num >= GClass154.gclass63_10.method_2())
						return;
					gClass = GClass154.gclass63_10.method_3(num) as GClass59;
					if (gClass != null && gClass.gclass90_0.int_0 == 23)
					{
						if (GClass58.smethod_1().int_5 > 264)
							break;
						bool_7 = true;
						bool_5 = false;
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Skill đã được hồi!" : "Skills is recovered", 0);
					}
					num++;
				}
				if (bool_6 || GClass138.smethod_18() - long_5 <= 1000L)
					return;
				if (!GClass39.gclass0_0.bool_0)
				{
					GClass166.smethod_0().method_60((short)gClass.gclass90_0.int_0);
					long_5 = GClass138.smethod_18();
					return;
				}
				for (int i = 0; i < GClass39.gclass0_0.gclass63_0.method_2(); i++)
				{
					if (GClass39.gclass0_0.gclass63_0.method_3(i) is GClass14 gClass2 && gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "vàng" : "gold"))
					{
						GClass166.smethod_0().method_59((short)gClass.gclass90_0.int_0, (sbyte)i);
						GClass198.smethod_0().method_0();
						long_5 = GClass138.smethod_18();
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/recoveringSkill.txt", ex.ToString());
			}
		}

		public void method_8()
		{
			try
			{
				if (bool_4 && GClass138.smethod_18() - long_3 > long_4)
				{
					if (GClass58.smethod_1().gclass74_0.gclass53_0.int_3 == 3)
					{
						GClass154.smethod_8().method_64(GClass58.smethod_1().gclass74_0);
						long_3 = GClass138.smethod_18();
					}
					else if (GClass58.smethod_1().gclass85_0 != null)
					{
						GClass63 gClass = new GClass63();
						gClass.method_0(GClass58.smethod_1().gclass85_0);
						GClass166.smethod_0().method_73(gClass, new GClass63(), -1);
						long_3 = GClass138.smethod_18();
					}
					else if (GClass58.smethod_1().gclass58_0 != null)
					{
						GClass63 gClass2 = new GClass63();
						gClass2.method_0(GClass58.smethod_1().gclass58_0);
						GClass166.smethod_0().method_73(new GClass63(), gClass2, -1);
						long_3 = GClass138.smethod_18();
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/autoSkillbyTime.txt", ex.ToString());
			}
		}

		public void method_9()
		{
			GClass63 gClass = new GClass63();
			GClass74[] gclass74_ = GClass154.gclass74_0;
			foreach (GClass74 gClass2 in gclass74_)
			{
				if (gClass2 != null && (gClass2.gclass53_0.int_3 == 3 || gClass2.gclass53_0.int_3 == 2))
					gClass.method_0(new GClass14(gClass2.gclass53_0.string_0 + "\n" + GClass193.smethod_0().method_7(gclass63_0.method_1(gClass2)), this, 50001, gClass2));
			}
			GClass39.gclass0_0.method_2(gClass, 0);
		}

		public void method_10()
		{
			try
			{
				if (GClass138.smethod_18() - long_1 < 1000L || GClass58.smethod_1().bool_47 || GClass58.smethod_1().bool_60 || GClass154.bool_69 || GClass58.smethod_1().int_11 == 14 || GClass58.smethod_1().int_11 == 5 || GClass58.smethod_1().bool_23 || GClass58.smethod_1().bool_46 || GClass58.smethod_1().method_67())
					return;
				GClass74[] array = (GClass39.bool_5 ? GClass154.gclass74_1 : GClass154.gclass74_0);
				foreach (GClass74 gClass in array)
				{
					if (gClass != null && gclass63_0.method_1(gClass) && GClass138.smethod_18() - gClass.long_1 > gClass.int_1 + 100 && gClass.gclass53_0.int_3 != 2)
					{
						int num = 0;
						bool flag = GClass58.smethod_1().gclass176_0.bool_10 && GClass58.smethod_1().gclass176_0.int_8 > 1;
						bool flag2 = GClass58.smethod_1().gclass176_0.bool_6 && GClass58.smethod_1().gclass176_0.int_5 > 1;
						bool flag3 = GClass58.smethod_1().gclass176_0.bool_7;
						bool bool_ = GClass58.smethod_1().gclass176_0.bool_11;
						bool flag4 = GClass58.smethod_1().gclass176_0.bool_1;
						if ((flag && gClass.gclass53_0.sbyte_0 != 19 && gClass.gclass53_0.sbyte_0 != 6 && gClass.gclass53_0.sbyte_0 != 8 && gClass.gclass53_0.sbyte_0 != 13 && gClass.gclass53_0.sbyte_0 != 14 && gClass.gclass53_0.sbyte_0 != 21) || flag2 || flag3 || bool_ || flag4 || GClass58.smethod_1().gclass176_0.bool_7 || (gClass.gclass53_0.sbyte_0 == 19 && GClass58.smethod_1().gclass176_0.bool_5))
							break;
						int num2 = ((gClass.gclass53_0.int_2 == 2) ? 1 : ((gClass.gclass53_0.int_2 == 1) ? (gClass.int_5 * GClass58.smethod_1().int_36 / 100) : gClass.int_5));
						if (GClass58.smethod_1().int_24 >= num2)
						{
							if (gClass != GClass58.smethod_1().gclass74_0)
							{
								GClass154.smethod_8().method_62(gClass, true);
								long_1 = GClass138.smethod_18();
							}
							else if (GClass138.smethod_18() - long_1 > 1000L)
							{
								GClass154.smethod_8().method_64(gClass);
								gClass.long_1 = GClass138.smethod_18();
							}
							break;
						}
					}
					else
					{
						if (gClass == null || !gclass63_0.method_1(gClass) || GClass138.smethod_18() - gClass.long_1 <= gClass.int_1 + 100 || gClass.gclass53_0.int_3 != 2)
							continue;
						int num3 = 0;
						int num4 = ((gClass.gclass53_0.int_2 == 2) ? 1 : ((gClass.gclass53_0.int_2 == 1) ? (gClass.int_5 * GClass58.smethod_1().int_36 / 100) : gClass.int_5));
						if (GClass58.smethod_1().int_24 >= num4)
						{
							if (gClass != GClass58.smethod_1().gclass74_0)
							{
								GClass154.smethod_8().method_62(gClass, true);
								long_1 = GClass138.smethod_18();
								break;
							}
							GClass63 gClass2 = new GClass63();
							gClass2.method_0(GClass58.smethod_1());
							GClass166.smethod_0().method_73(new GClass63(), gClass2, -1);
							gClass.long_1 = GClass138.smethod_18();
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/AutoSkillNotFocus.txt", ex.ToString());
			}
		}

		public static void smethod_1(int time)
		{
			bool_10 = true;
			long_7 = GClass138.smethod_18();
			long_8 = time;
		}

		public static bool smethod_2()
		{
			if (bool_10 && GClass138.smethod_18() - long_7 >= long_8)
				bool_10 = false;
			return bool_10;
		}

		public int method_11()
		{
			int num = 0;
			while (true)
			{
				if (num < GClass154.gclass74_0.Length)
				{
					if (GClass154.gclass74_0[num] == GClass58.smethod_1().gclass74_0)
						break;
					num++;
					continue;
				}
				return 0;
			}
			return num;
		}

		public long method_12(GClass74 skill)
		{
			if (skill.gclass53_0.sbyte_0 != 20 && skill.gclass53_0.sbyte_0 != 22 && skill.gclass53_0.sbyte_0 != 7 && skill.gclass53_0.sbyte_0 != 18 && skill.gclass53_0.sbyte_0 != 23)
			{
				long num = (long)((double)skill.int_1 * 1.2);
				if (num < 415L)
					return 415L;
				return num;
			}
			return skill.int_1 + 500L;
		}

		public void method_13()
		{
			try
			{
				GClass58 gClass = GClass58.smethod_1();
				GClass58 gclass58_ = gClass.gclass58_0;
				GClass85 gclass85_ = gClass.gclass85_0;
				if (GClass58.smethod_1().bool_62 || GClass58.smethod_1().int_25 <= 0 || GClass58.smethod_1().int_11 == 14 || GClass58.smethod_1().int_11 == 5 || GClass58.smethod_1().gclass74_0.gclass53_0.int_3 == 3 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 10 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 11 || (GClass58.smethod_1().gclass74_0.bool_0 && !GClass39.gclass45_0.bool_0))
					return;
				int num = method_11();
				if (!smethod_4(GClass58.smethod_1().gclass74_0))
					return;
				sbyte sbyte_ = gClass.gclass74_0.gclass53_0.sbyte_0;
				if (sbyte_ != 7)
				{
					if (sbyte_ != 23)
					{
						if (GClass138.smethod_18() - long_0[num] > method_12(gClass.gclass74_0) && gClass.gclass74_0.gclass53_0.sbyte_0 != 23)
						{
							if (gclass85_ != null && GClass154.smethod_8().method_31(gclass85_))
							{
								GClass58.smethod_1().gclass74_0.long_1 = GClass138.smethod_18();
								smethod_6();
								long_0[num] = GClass138.smethod_18();
							}
							else if (gclass58_ != null && smethod_3(gclass58_))
							{
								GClass58.smethod_1().gclass74_0.long_1 = GClass138.smethod_18();
								smethod_5();
								long_0[num] = GClass138.smethod_18();
							}
						}
					}
					else
					{
						if (GClass138.smethod_18() - long_0[num] <= method_12(gClass.gclass74_0))
							return;
						if (bool_1)
						{
							if (gclass58_ != null && smethod_3(gclass58_))
							{
								gClass.gclass74_0.long_1 = GClass138.smethod_18();
								smethod_5();
								long_0[num] = GClass138.smethod_18();
							}
						}
						else if (gclass85_ != null && gclass85_.int_5 != 32 && GClass154.smethod_8().method_31(gclass85_))
						{
							gClass.gclass74_0.long_1 = GClass138.smethod_18();
							smethod_6();
							long_0[num] = GClass138.smethod_18();
						}
						else if (gclass58_ != null && gclass58_.int_159 != 32 && smethod_3(gclass58_))
						{
							gClass.gclass74_0.long_1 = GClass138.smethod_18();
							smethod_5();
							long_0[num] = GClass138.smethod_18();
						}
					}
				}
				else if (GClass138.smethod_18() - long_0[num] > method_12(gClass.gclass74_0) && gclass58_ != null)
				{
					gClass.gclass74_0.long_1 = GClass138.smethod_18();
					smethod_5();
					long_0[num] = GClass138.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/SendAttack.txt", ex.ToString());
			}
		}

		public static bool smethod_3(GClass58 ch)
		{
			if (GClass1.int_37 == 113)
			{
				if (ch != null && GClass58.smethod_1().gclass74_0 != null)
				{
					if (ch.sbyte_19 != 5)
						return ch.sbyte_19 == 3;
					return true;
				}
				return false;
			}
			if (ch != null && GClass58.smethod_1().gclass74_0 != null)
			{
				if (ch.int_11 != 14 && ch.int_11 != 5 && GClass58.smethod_1().gclass74_0.gclass53_0.int_3 != 2 && ((GClass58.smethod_1().sbyte_28 == 8 && ch.sbyte_28 != 0) || (GClass58.smethod_1().sbyte_28 != 0 && ch.sbyte_28 == 8) || (GClass58.smethod_1().sbyte_28 != ch.sbyte_28 && GClass58.smethod_1().sbyte_28 != 0 && ch.sbyte_28 != 0) || (ch.sbyte_19 == 3 && GClass58.smethod_1().sbyte_19 == 3) || GClass58.smethod_1().sbyte_19 == 5 || ch.sbyte_19 == 5 || (GClass58.smethod_1().sbyte_19 == 1 && ch.sbyte_19 == 1) || (GClass58.smethod_1().sbyte_19 == 4 && ch.sbyte_19 == 4)))
					return true;
				if (GClass58.smethod_1().gclass74_0.gclass53_0.int_3 == 2)
					return ch.sbyte_19 != 5;
				return false;
			}
			return false;
		}

		private static bool smethod_4(GClass74 gclass74_0)
		{
			if (gclass74_0.gclass53_0.int_2 == 2)
				return true;
			if (gclass74_0.gclass53_0.int_2 != 1)
				return GClass58.smethod_1().int_24 >= gclass74_0.int_5;
			return GClass58.smethod_1().int_24 >= gclass74_0.int_5 * GClass58.smethod_1().int_36 / 100;
		}

		private static void smethod_5()
		{
			try
			{
				GClass63 gClass = new GClass63();
				gClass.method_0(GClass58.smethod_1().gclass58_0);
				GClass166.smethod_0().method_73(new GClass63(), gClass, 2);
			}
			catch
			{
			}
		}

		private static void smethod_6()
		{
			try
			{
				GClass63 gClass = new GClass63();
				gClass.method_0(GClass58.smethod_1().gclass85_0);
				GClass166.smethod_0().method_73(gClass, new GClass63(), 1);
			}
			catch
			{
			}
		}
	}
}
