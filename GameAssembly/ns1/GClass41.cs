using System;
using System.Collections.Generic;

namespace ns1
{
	public class GClass41 : GInterface1
	{
		public struct GStruct1
		{
			public int int_0;

			public int int_1;

			public GStruct1(int skillID, int coolDown)
			{
				int_0 = skillID;
				int_1 = coolDown;
			}
		}

		private static GClass41 gclass41_0;

		public long[] long_0 = new long[10];

		public bool bool_0;

		public bool bool_1;

		public GClass122 gclass122_0 = new GClass122();

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

		public List<GStruct1> list_0 = new List<GStruct1>();

		public bool bool_9 = false;

		public bool bool_10 = false;

		public long long_7;

		private static bool bool_11;

		private static long long_8;

		private static long long_9;

		public static GClass41 smethod_0()
		{
			return (gclass41_0 != null) ? gclass41_0 : (gclass41_0 = new GClass41());
		}

		public bool method_0(string text)
		{
			switch (text)
			{
			case "/autoskill":
				smethod_0().bool_4 = false;
				smethod_0().long_4 = 0L;
				GClass51.smethod_1((GClass62.int_0 != 0) ? "Turn off auto use skill!" : "Tự dùng chiêu đã tắt!", 0);
				return true;
			case "/ats9g":
				smethod_0().bool_3 = !smethod_0().bool_3;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto train special skill by gold: " + GClass45.smethod_0().method_6(smethod_0().bool_3) + "!") : ("Tự động luyện tuyệt kĩ bằng vàng: " + GClass45.smethod_0().method_6(smethod_0().bool_3) + "!"), 0);
				return true;
			case "/ats9":
				smethod_0().bool_2 = !smethod_0().bool_2;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto train special skill: " + GClass45.smethod_0().method_6(smethod_0().bool_2) + "!") : ("Tự động luyện tuyệt kĩ: " + GClass45.smethod_0().method_6(smethod_0().bool_2) + "!"), 0);
				return true;
			case "/rcvs":
				smethod_0().bool_5 = !smethod_0().bool_5;
				smethod_0().bool_6 = false;
				smethod_0().bool_7 = false;
				if (GClass57.smethod_0().bool_0)
					Class11.smethod_0().method_9();
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto recovering skill: " + GClass45.smethod_0().method_6(smethod_0().bool_5) + "!") : ("Tự động đi hồi skill: " + GClass45.smethod_0().method_6(smethod_0().bool_5) + "!"), 0);
				return true;
			case "/lockskill":
				bool_8 = !bool_8;
				int_1 = ((!bool_8) ? (-1) : (GClass124.smethod_1().gclass95_0?.gclass205_0.sbyte_0).Value);
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động khóa skill: " + GClass45.smethod_0().method_6(smethod_0().bool_5) + "!") : ("Auto lock skill: " + GClass45.smethod_0().method_6(smethod_0().bool_8) + "!"), 0);
				return true;
			}
            if (GClass45.smethod_0().method_11<long>(text, "/autoskill"))
            {
                if (GClass45.smethod_0().method_12<long>(text, "/autoskill") != 0L)
                {
                    smethod_0().long_4 = GClass45.smethod_0().method_12<long>(text, "/autoskill");
                    smethod_0().bool_4 = true;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tự dùng chiêu sau {smethod_0().long_4}ms : {GClass45.smethod_0().method_6(smethod_0().bool_4)}!" : $"Auto use skill after {smethod_0().long_4}ms : {GClass45.smethod_0().method_6(smethod_0().bool_4)}!", 0);
                }
                else
                {
                    smethod_0().bool_4 = false;
                    smethod_0().long_4 = 0L;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? "Tự dùng chiêu đã tắt!" : "Turn off auto use skill!", 0);
                }
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/frz"))
            {
                if (GClass45.smethod_0().method_12<int>(text, "/frz") == 0)
                {
                    GClass124.smethod_1().gclass95_0.int_1 = 0;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Freeze skill: " + GClass124.smethod_1().gclass95_0.gclass205_0.string_0) : ("Đóng băng: " + GClass124.smethod_1().gclass95_0.gclass205_0.string_0), 0);
                }
                else
                {
                    GClass124.smethod_1().gclass95_0.int_1 = GClass45.smethod_0().method_12<int>(text, "/frz");
                    GClass51.smethod_1((GClass62.int_0 != 0) ? string.Format("Fake skill cooldown: {0}: {1}", GClass124.smethod_1().gclass95_0.gclass205_0.string_0, GClass45.smethod_0().method_12<int>(text, "/frz")) : string.Format("Fake time hồi chiêu: {0}: {1}", GClass124.smethod_1().gclass95_0.gclass205_0.string_0, GClass45.smethod_0().method_12<int>(text, "/frz")), 0);
                }
            }
			else 
				return false;
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
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động đánh: " + GClass45.smethod_0().method_6(smethod_0().bool_0)) : ("Auto Attack: " + GClass45.smethod_0().method_6(smethod_0().bool_0)), 0);
			}
			return true;
		}

		public void perform(int idAction, object p)
		{
			if (GClass57.smethod_0().bool_0)
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
						GClass51.smethod_1((GClass62.int_0 != 0) ? ("Change to hold " + ((!bool_1) ? "wait object" : "on object")) : ("Chuyển sang trói " + ((!bool_1) ? "lần lượt" : "đè mục tiêu")), 0);
						break;
					case 101503:
						method_0("/ats9");
						break;
					}
				}
				else
				{
					GClass95 gClass = (GClass95)p;
					if (gclass122_0.method_1(gClass))
					{
						gclass122_0.method_8(gClass);
						GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? ("Deleted skill " + gClass.gclass205_0.string_0) : ("Đã xóa skill " + gClass.gclass205_0.string_0), 0);
					}
					else
					{
						gclass122_0.method_0(gClass);
						GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? ("Added skill " + gClass.gclass205_0.string_0) : ("Đã thêm skill " + gClass.gclass205_0.string_0), 0);
					}
				}
				return;
			}
			GClass122 gClass2 = new GClass122();
			gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "List Skill\nAuto Use" : "Danh sách\nCác skill\nAuto", this, 101501, null));
			if (GClass124.smethod_1().int_14 == 2)
				gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? ("Mode Hold:\n" + (bool_1 ? "On Object" : "Wait Object")) : ("Chuyển chế\nđộ trói:\n" + (bool_1 ? "Đè m.tiêu" : "lần lượt")), this, 101502, null));
			for (int i = 0; i < GClass167.gclass95_0.Length; i++)
			{
				GClass95 gClass3 = GClass167.gclass95_0[i];
				if (gClass3 != null && gClass3.gclass205_0.sbyte_0 == int_0[GClass124.smethod_1().int_14])
					gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? ("Auto train\ntuyệt kỹ:\n" + GClass45.smethod_0().method_7(bool_2)) : ("Auto train\nSpecial Skill:\n" + GClass45.smethod_0().method_7(bool_2)), this, 101503, null));
			}
			GClass14.gclass116_0.bool_1 = true;
			GClass14.gclass116_0.method_2(gClass2, 0);
		}

		public void method_2()
		{
			method_11();
			if (bool_0)
				method_14();
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
			for (int i = 0; i < GClass167.gclass95_0.Length; i++)
			{
				GClass95 gClass = GClass167.gclass95_0[i];
				if (gClass != null && gClass.gclass205_0.sbyte_0 == int_1 && GClass124.smethod_1().gclass95_0 != gClass && GClass77.smethod_18() - long_6 > 3000L)
				{
					GClass167.smethod_8().method_62(gClass, false);
					long_6 = GClass77.smethod_18();
				}
			}
		}

		public void method_5()
		{
			if (GClass124.smethod_1().gclass95_0.int_1 != 0)
			{
				if (list_0.Contains(new GStruct1(GClass124.smethod_1().gclass95_0.short_0, GClass124.smethod_1().gclass95_0.int_1)))
					method_0("/frz0");
				else
					list_0.Add(new GStruct1(GClass124.smethod_1().gclass95_0.short_0, GClass124.smethod_1().gclass95_0.int_1));
				return;
			}
			foreach (GStruct1 item in list_0)
			{
				if (item.int_0 == GClass124.smethod_1().gclass95_0.short_0)
				{
					GClass124.smethod_1().gclass95_0.int_1 = item.int_1;
					list_0.Remove(item);
					GClass51.smethod_1((GClass62.int_0 != 0) ? "Skill back to normal" : "Skill đã trở về trạng thái bình thường", 0);
				}
			}
		}

		public void method_6()
		{
			if (!bool_2 || GClass124.smethod_1().bool_47)
				return;
			try
			{
				for (int i = 0; i < GClass167.gclass95_0.Length; i++)
				{
					GClass95 gClass = GClass167.gclass95_0[i];
					if (gClass == null || gClass.gclass205_0.sbyte_0 != int_0[GClass124.smethod_1().int_14])
						continue;
					int num = ((gClass.gclass205_0.int_2 == 2) ? 1 : ((gClass.gclass205_0.int_2 == 1) ? (gClass.int_5 * GClass124.smethod_1().int_36 / 100) : gClass.int_5));
					if (GClass124.smethod_1().int_24 < num || GClass77.smethod_18() - gClass.long_1 <= gClass.int_1 + 500)
						continue;
					if (GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == gClass.gclass205_0.sbyte_0)
					{
						GClass14.smethod_1().method_10(49 + i);
						GClass124.smethod_1().gclass95_0.long_1 = GClass77.smethod_18();
						continue;
					}
					if (GClass77.smethod_18() - long_1 > 1000L)
					{
						GClass167.smethod_8().method_62(gClass, false);
						long_1 = GClass77.smethod_18();
					}
					break;
				}
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/autoTrainSpecialSkill.txt", ex.ToString());
			}
		}

		public void method_7()
		{
			if (!bool_3)
				return;
			if (GClass137.int_37 != 129)
			{
				bool_9 = false;
				if (!GClass57.smethod_0().bool_0)
					Class11.smethod_0().method_8(129);
				return;
			}
			for (int i = 0; i < GClass167.gclass95_0.Length; i++)
			{
				GClass95 gClass = GClass167.gclass95_0[i];
				if (gClass == null || gClass.gclass205_0.sbyte_0 != int_0[GClass124.smethod_1().int_14])
					continue;
				int num = ((gClass.gclass205_0.int_2 == 2) ? 1 : ((gClass.gclass205_0.int_2 == 1) ? (gClass.int_5 * GClass124.smethod_1().int_36 / 100) : gClass.int_5));
				if (GClass77.smethod_18() - gClass.long_1 <= gClass.int_1 + 200)
				{
					if (!GClass124.smethod_1().bool_77)
					{
						if (GClass124.smethod_1().int_5 == 264)
						{
							for (int j = 0; j < GClass167.gclass122_5.method_2(); j++)
							{
								if (GClass167.gclass122_5.method_3(j) is GClass124 gClass2 && gClass2.int_13 < 0 && gClass2.int_13 != -114 && GClass77.smethod_18() - long_5 > 1000L && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass2.int_4, gClass2.int_5) < 10)
								{
									GClass14.smethod_1().method_10(106);
									long_5 = GClass77.smethod_18();
								}
							}
						}
						for (int k = 0; k < GClass167.gclass122_10.method_2(); k++)
						{
							if (!(GClass167.gclass122_10.method_3(k) is GClass125 gClass3) || gClass3.gclass120_0.int_0 != 23 || GClass124.smethod_1().int_5 != 408 || bool_9 || GClass77.smethod_18() - long_5 <= 1000L)
								continue;
							if (GClass14.gclass116_0.bool_0)
							{
								for (int l = 0; l < GClass14.gclass116_0.gclass122_0.method_2(); l++)
								{
									if (GClass14.gclass116_0.gclass122_0.method_3(l) is GClass118 gClass4 && gClass4.string_0.ToLower().Contains((mResources.language == 0) ? "vàng" : "gold"))
									{
										GClass2.smethod_0().method_59((short)gClass3.gclass120_0.int_0, (sbyte)l);
										GClass53.smethod_0().method_0();
										bool_9 = true;
										long_5 = GClass77.smethod_18();
									}
								}
								continue;
							}
							GClass2.smethod_0().method_60((short)gClass3.gclass120_0.int_0);
							long_5 = GClass77.smethod_18();
							return;
						}
						continue;
					}
					if (GClass14.gclass116_0.bool_0)
						GClass53.smethod_0().method_0();
					break;
				}
				if (GClass124.smethod_1().int_24 >= num)
				{
					if (GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == gClass.gclass205_0.sbyte_0)
					{
						GClass14.smethod_1().method_10(49 + i);
						GClass124.smethod_1().gclass95_0.long_1 = GClass77.smethod_18();
						bool_9 = false;
					}
					else if (GClass77.smethod_18() - long_1 > 1000L)
					{
						GClass167.smethod_8().method_62(gClass, false);
						long_1 = GClass77.smethod_18();
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
				if (GClass57.smethod_0().bool_0)
					return;
				if (GClass137.int_37 != 129)
				{
					Class11.smethod_0().method_8(129);
					return;
				}
				for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
				{
					if (!(GClass167.gclass122_10.method_3(i) is GClass125 gClass) || gClass.gclass120_0.int_0 != 23)
						continue;
					if (GClass124.smethod_1().int_5 <= 264)
					{
						bool_7 = true;
						bool_5 = false;
						GClass51.smethod_1((GClass62.int_0 == 0) ? "Skill đã được hồi!" : "Skills is recovered", 0);
						continue;
					}
					if (bool_6 || GClass77.smethod_18() - long_5 <= 1000L)
						break;
					if (!GClass14.gclass116_0.bool_0)
					{
						GClass2.smethod_0().method_60((short)gClass.gclass120_0.int_0);
						long_5 = GClass77.smethod_18();
						break;
					}
					for (int j = 0; j < GClass14.gclass116_0.gclass122_0.method_2(); j++)
					{
						if (GClass14.gclass116_0.gclass122_0.method_3(j) is GClass118 gClass2 && gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "vàng" : "gold"))
						{
							GClass2.smethod_0().method_59((short)gClass.gclass120_0.int_0, (sbyte)j);
							GClass53.smethod_0().method_0();
							long_5 = GClass77.smethod_18();
						}
					}
					break;
				}
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/recoveringSkill.txt", ex.ToString());
			}
		}

		public void method_9()
		{
			try
			{
				if (!bool_4 || GClass77.smethod_18() - long_3 <= long_4)
					return;
				if (GClass124.smethod_1().gclass95_0.gclass205_0.int_3 == 3)
				{
					GClass167.smethod_8().method_64(GClass124.smethod_1().gclass95_0);
					long_3 = GClass77.smethod_18();
				}
				else if (GClass124.smethod_1().gclass6_0 == null)
				{
					if (GClass124.smethod_1().gclass124_0 != null)
					{
						GClass122 gClass = new GClass122();
						gClass.method_0(GClass124.smethod_1().gclass124_0);
						GClass2.smethod_0().method_73(new GClass122(), gClass, -1);
						long_3 = GClass77.smethod_18();
					}
				}
				else
				{
					GClass122 gClass2 = new GClass122();
					gClass2.method_0(GClass124.smethod_1().gclass6_0);
					GClass2.smethod_0().method_73(gClass2, new GClass122(), -1);
					long_3 = GClass77.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/autoSkillbyTime.txt", ex.ToString());
			}
		}

		public void method_10()
		{
			GClass122 gClass = new GClass122();
			GClass95[] gclass95_ = GClass167.gclass95_0;
			foreach (GClass95 gClass2 in gclass95_)
			{
				if (gClass2 != null && (gClass2.gclass205_0.int_3 == 3 || gClass2.gclass205_0.int_3 == 2))
					gClass.method_0(new GClass118(gClass2.gclass205_0.string_0 + "\n" + GClass45.smethod_0().method_7(gclass122_0.method_1(gClass2)), this, 50001, gClass2));
			}
			GClass14.gclass116_0.bool_1 = true;
			GClass14.gclass116_0.method_2(gClass, 0);
		}

		public void method_11()
		{
			try
			{
				if (GClass77.smethod_18() - long_1 < 1000L || GClass124.smethod_1().bool_47 || GClass124.smethod_1().bool_60 || GClass167.bool_70 || GClass124.smethod_1().int_11 == 14 || GClass124.smethod_1().int_11 == 5 || GClass124.smethod_1().bool_23 || GClass124.smethod_1().bool_46 || GClass124.smethod_1().method_68())
					return;
				GClass95[] array = ((!GClass14.bool_5) ? GClass167.gclass95_0 : GClass167.gclass95_1);
				foreach (GClass95 gClass in array)
				{
					if (gClass != null && gclass122_0.method_1(gClass) && GClass77.smethod_18() - gClass.long_1 > gClass.int_1 + 100 && gClass.gclass205_0.int_3 != 2)
					{
						int num = 0;
						bool flag = GClass124.smethod_1().gclass60_0.bool_10 && GClass124.smethod_1().gclass60_0.int_8 > 1;
						bool flag2 = GClass124.smethod_1().gclass60_0.bool_6 && GClass124.smethod_1().gclass60_0.int_5 > 1;
						bool flag3 = GClass124.smethod_1().gclass60_0.bool_7;
						bool flag4 = GClass124.smethod_1().gclass60_0.bool_11;
						bool flag5 = GClass124.smethod_1().gclass60_0.bool_1;
						if ((flag && gClass.gclass205_0.sbyte_0 != 19 && gClass.gclass205_0.sbyte_0 != 6 && gClass.gclass205_0.sbyte_0 != 8 && gClass.gclass205_0.sbyte_0 != 13 && gClass.gclass205_0.sbyte_0 != 14 && gClass.gclass205_0.sbyte_0 != 21) || flag2 || flag3 || flag4 || flag5 || GClass124.smethod_1().gclass60_0.bool_7 || (gClass.gclass205_0.sbyte_0 == 19 && GClass124.smethod_1().gclass60_0.bool_5))
							break;
						int num2 = ((gClass.gclass205_0.int_2 == 2) ? 1 : ((gClass.gclass205_0.int_2 == 1) ? (gClass.int_5 * GClass124.smethod_1().int_36 / 100) : gClass.int_5));
						if (GClass124.smethod_1().int_24 < num2)
							continue;
						if (gClass == GClass124.smethod_1().gclass95_0)
						{
							if (GClass77.smethod_18() - long_1 > 1000L)
							{
								GClass167.smethod_8().method_64(gClass);
								gClass.long_1 = GClass77.smethod_18();
							}
						}
						else
						{
							GClass167.smethod_8().method_62(gClass, true);
							long_1 = GClass77.smethod_18();
						}
						break;
					}
					if (gClass == null || !gclass122_0.method_1(gClass) || GClass77.smethod_18() - gClass.long_1 <= gClass.int_1 + 100 || gClass.gclass205_0.int_3 != 2)
						continue;
					int num3 = 0;
					int num4 = ((gClass.gclass205_0.int_2 == 2) ? 1 : ((gClass.gclass205_0.int_2 == 1) ? (gClass.int_5 * GClass124.smethod_1().int_36 / 100) : gClass.int_5));
					if (GClass124.smethod_1().int_24 >= num4)
					{
						if (gClass != GClass124.smethod_1().gclass95_0)
						{
							GClass167.smethod_8().method_62(gClass, true);
							long_1 = GClass77.smethod_18();
							break;
						}
						GClass122 gClass2 = new GClass122();
						gClass2.method_0(GClass124.smethod_1());
						GClass2.smethod_0().method_73(new GClass122(), gClass2, -1);
						gClass.long_1 = GClass77.smethod_18();
						break;
					}
				}
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/AutoSkillNotFocus.txt", ex.ToString());
			}
		}

		public static void smethod_1(int time)
		{
			bool_11 = true;
			long_8 = GClass77.smethod_18();
			long_9 = time;
		}

		public static bool smethod_2()
		{
			if (bool_11 && GClass77.smethod_18() - long_8 >= long_9)
				bool_11 = false;
			return bool_11;
		}

		public int method_12()
		{
			for (int i = 0; i < GClass167.gclass95_0.Length; i++)
			{
				if (GClass167.gclass95_0[i] == GClass124.smethod_1().gclass95_0)
					return i;
			}
			return 0;
		}

		public long method_13(GClass95 skill)
		{
			if (skill.gclass205_0.sbyte_0 != 20 && skill.gclass205_0.sbyte_0 != 22 && skill.gclass205_0.sbyte_0 != 7 && skill.gclass205_0.sbyte_0 != 18 && skill.gclass205_0.sbyte_0 != 23)
			{
				long num = (long)((double)skill.int_1 * 1.2);
				if (num >= 415L)
					return num;
				return 415L;
			}
			return skill.int_1 + 500L;
		}

		public void method_14()
		{
			try
			{
				GClass124 gClass = GClass124.smethod_1();
				GClass124 gclass124_ = gClass.gclass124_0;
				GClass6 gclass6_ = gClass.gclass6_0;
				if (GClass124.smethod_1().bool_62 || GClass124.smethod_1().int_25 <= 0 || GClass124.smethod_1().int_11 == 14 || GClass124.smethod_1().int_11 == 5 || GClass124.smethod_1().gclass95_0.gclass205_0.int_3 == 3 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 10 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 11 || (GClass124.smethod_1().gclass95_0.bool_0 && !GClass14.gclass113_0.bool_0))
					return;
				int num = method_12();
				if (!smethod_4((GClass205)(object)GClass124.smethod_1().gclass95_0))
					return;
				sbyte sbyte_ = gClass.gclass95_0.gclass205_0.sbyte_0;
				if (sbyte_ != 7)
				{
					if (sbyte_ != 23)
					{
						if (GClass77.smethod_18() - long_0[num] > method_13(gClass.gclass95_0) && gClass.gclass95_0.gclass205_0.sbyte_0 != 23)
						{
							if (gclass6_ != null && GClass167.smethod_8().method_31(gclass6_) && (double)GClass13.smethod_0(GClass124.smethod_1().gclass6_0.int_16 - GClass124.smethod_1().int_4) < (double)GClass124.smethod_1().gclass95_0.int_2 * 3.0)
							{
								GClass124.smethod_1().gclass95_0.long_1 = GClass77.smethod_18();
								smethod_6();
								long_0[num] = GClass77.smethod_18();
							}
							else if (gclass124_ != null && smethod_3(gclass124_) && (double)GClass13.smethod_0(GClass124.smethod_1().gclass124_0.int_4 - GClass124.smethod_1().int_4) < (double)GClass124.smethod_1().gclass95_0.int_2 * 2.0)
							{
								GClass124.smethod_1().gclass95_0.long_1 = GClass77.smethod_18();
								smethod_5();
								long_0[num] = GClass77.smethod_18();
							}
						}
					}
					else
					{
						if (GClass77.smethod_18() - long_0[num] <= method_13(gClass.gclass95_0))
							return;
						if (!bool_1)
						{
							if (gclass6_ != null && gclass6_.int_5 != 32 && GClass167.smethod_8().method_31(gclass6_))
							{
								gClass.gclass95_0.long_1 = GClass77.smethod_18();
								smethod_6();
								long_0[num] = GClass77.smethod_18();
							}
							else if (gclass124_ != null && gclass124_.int_159 != 32 && smethod_3(gclass124_))
							{
								gClass.gclass95_0.long_1 = GClass77.smethod_18();
								smethod_5();
								long_0[num] = GClass77.smethod_18();
							}
						}
						else if (gclass124_ != null && smethod_3(gclass124_))
						{
							gClass.gclass95_0.long_1 = GClass77.smethod_18();
							smethod_5();
							long_0[num] = GClass77.smethod_18();
						}
					}
				}
				else if (GClass77.smethod_18() - long_0[num] > method_13(gClass.gclass95_0) && gclass124_ != null)
				{
					gClass.gclass95_0.long_1 = GClass77.smethod_18();
					smethod_5();
					long_0[num] = GClass77.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/SendAttack.txt", ex.ToString());
			}
		}

		public static bool smethod_3(GClass124 ch)
		{
			if (GClass137.int_37 == 113)
			{
				if (ch != null && GClass124.smethod_1().gclass95_0 != null)
				{
					if (ch.sbyte_19 != 5)
						return ch.sbyte_19 == 3;
					return true;
				}
				return false;
			}
			if (ch == null || GClass124.smethod_1().gclass95_0 == null)
				return false;
			if (ch.int_11 != 14 && ch.int_11 != 5 && GClass124.smethod_1().gclass95_0.gclass205_0.int_3 != 2 && ((GClass124.smethod_1().sbyte_28 == 8 && ch.sbyte_28 != 0) || (GClass124.smethod_1().sbyte_28 != 0 && ch.sbyte_28 == 8) || (GClass124.smethod_1().sbyte_28 != ch.sbyte_28 && GClass124.smethod_1().sbyte_28 != 0 && ch.sbyte_28 != 0) || (ch.sbyte_19 == 3 && GClass124.smethod_1().sbyte_19 == 3) || GClass124.smethod_1().sbyte_19 == 5 || ch.sbyte_19 == 5 || (GClass124.smethod_1().sbyte_19 == 1 && ch.sbyte_19 == 1) || (GClass124.smethod_1().sbyte_19 == 4 && ch.sbyte_19 == 4)))
				return true;
			if (GClass124.smethod_1().gclass95_0.gclass205_0.int_3 != 2)
				return false;
			return ch.sbyte_19 != 5;
		}

		private static bool smethod_4(GClass205 gclass205_0)
		{
			if (((GClass95)(object)gclass205_0).gclass205_0.int_2 != 2)
			{
				if (((GClass95)(object)gclass205_0).gclass205_0.int_2 == 1)
					return GClass124.smethod_1().int_24 >= ((GClass95)(object)gclass205_0).int_5 * GClass124.smethod_1().int_36 / 100;
				return GClass124.smethod_1().int_24 >= ((GClass95)(object)gclass205_0).int_5;
			}
			return true;
		}

		private static void smethod_5()
		{
			try
			{
				GClass122 gClass = new GClass122();
				gClass.method_0(GClass124.smethod_1().gclass124_0);
				GClass2.smethod_0().method_73(new GClass122(), gClass, 2);
			}
			catch
			{
			}
		}

		private static void smethod_6()
		{
			try
			{
				GClass122 gClass = new GClass122();
				gClass.method_0(GClass124.smethod_1().gclass6_0);
				GClass2.smethod_0().method_73(gClass, new GClass122(), 1);
			}
			catch
			{
			}
		}
	}
}
