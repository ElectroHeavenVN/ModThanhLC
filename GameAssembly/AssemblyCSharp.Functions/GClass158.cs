using System;
using System.Collections.Generic;
using System.Linq;

namespace AssemblyCSharp.Functions
{
	public class GClass158 : GInterface6
	{
		protected struct GStruct1
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public GStruct1(int head, int body, int leg)
			{
				int_0 = head;
				int_1 = body;
				int_2 = leg;
			}
		}

		public bool bool_0;

		protected static List<GStruct1> list_0 = new List<GStruct1>();

		protected static List<GStruct1> list_1 = new List<GStruct1>();

		protected int int_0 = 0;

		public bool bool_1;

		protected int int_1 = 0;

		public long long_0;

		protected List<GClass78> list_2 = new List<GClass78>();

		private static GClass158 gclass158_0;

		public static List<GClass78> list_3 = new List<GClass78>();

		public int int_2 = 0;

		public int int_3 = -1;

		public bool bool_2;

		protected static readonly sbyte[] sbyte_0 = new sbyte[5] { 0, 2, 17, 4, 12 };

		protected static List<sbyte> list_4 = new List<sbyte>(sbyte_0);

		protected static readonly sbyte[] sbyte_1 = new sbyte[5] { 0, 9, 2, 17, 4 };

		protected static readonly sbyte[] sbyte_2 = new sbyte[5] { 10, 11, 14, 23, 7 };

		private bool bool_3;

		private long long_1;

		private long long_2;

		public string method_0(GClass78 @char, bool enableRichText = false)
		{
			string text = @char.string_3.Remove(0, @char.string_3.IndexOf(']') + 1).TrimStart(' ', '#', '$');
			if (enableRichText)
				text = (method_2(@char) ? ("<color=cyan>" + text + "</color>") : ((!method_1(@char)) ? ("<color=yellow>" + text + "</color>") : $"<color=red><size={7 * GClass122.int_12}>{text}</size></color>"));
			return text;
		}

		public bool method_1(GClass78 @char)
		{
			return @char != null && !method_2(@char) && @char.string_3 != ((mResources.language != 0) ? "Arbitration" : "Trọng tài") && char.IsUpper(method_0(@char)[0]);
		}

		public bool method_2(GClass78 @char)
		{
			return @char.method_1() || @char.method_2() || @char.string_3.StartsWith("#") || @char.string_3.StartsWith("$");
		}

		public static GClass158 smethod_0()
		{
			return (gclass158_0 != null) ? gclass158_0 : (gclass158_0 = new GClass158());
		}


        public bool method_3(string text)
        {
            switch (text)
            {
                case "/tbb":
                    GClass156.bool_0 = !GClass156.bool_0;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("List boss information: " + GClass154.smethod_0().method_6(GClass156.bool_0)) : ("D/s thông báo Boss: " + GClass154.smethod_0().method_6(GClass156.bool_0)), 0);
                    return true;
                case "/dsbskill":
                    method_14();
                    return true;
                case "/addboss":
                    smethod_0().method_15();
                    return true;
                case "/blockboss":
                    smethod_0().method_16();
                    return true;
                case "/dsb":
                    smethod_0().bool_0 = !smethod_0().bool_0;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động tàn sát BOSS: " + GClass154.smethod_0().method_6(smethod_0().bool_0)) : ("Auto murdering boss: " + GClass154.smethod_0().method_6(smethod_0().bool_0)), 0);
                    return true;
                case "/dsbskillclr":
                    list_4.Clear();
                    GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã xóa d/s skill tàn sát BOSS" : "Deleted list Skill murdering Boss", 0);
                    return true;
                case "/listbossclr":
                    list_1.Clear();
                    list_0.Clear();
                    GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã xóa d/s tàn sát BOSS" : "Deleted list Boss murdering", 0);
                    return true;
                case "/cobj":
                    smethod_0().bool_1 = !smethod_0().bool_1;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto change object: " + GClass154.smethod_0().method_6(smethod_0().bool_1)) : ("Tự động chuyển mục tiêu: " + GClass154.smethod_0().method_6(smethod_0().bool_1)), 0);
                    return true;
                default:
                {
                    if (GClass154.smethod_0().method_11<int>(text, "/bosshp"))
                    {
						string str;
                        int_0 = GClass154.smethod_0().method_12<int>(text, "/bosshp");
                        if (int_0 == 0)
                            str = ((GClass151.int_0 != 0) ? "Turn off limited Boss HP" : "Tắt giới hạn HP Boss");
                        else if (GClass151.int_0 == 0)
                            str = "Chỉ đánh boss dưới " + GClass65.smethod_9(int_0) + " HP";
                        else
                            str = "Only attack boss have HP lower than " + GClass65.smethod_9(int_0) + " HP";
                        GClass149.smethod_1(str, 0);
                        return true;
                    }
					break;
                }
            }
			return false;
        }

        public bool method_4(int asciiCode)
		{
			if (asciiCode != 101)
				return false;
			if (GClass153.smethod_0().method_6())
				GClass7.smethod_0().method_78("/ahs");
			else
				method_8();
			return true;
		}

		public void perform(int idAction, object p)
		{
			if (GClass148.smethod_0().bool_0 || GClass159.smethod_0().bool_18)
				return;
			if (idAction != 10001)
			{
				switch (idAction)
				{
				case 101201:
					method_3("/tbb");
					break;
				case 101202:
					method_3("/dsb");
					break;
				case 101203:
					method_3("/listbossclr");
					break;
				case 101204:
					bool_2 = !bool_2;
					break;
				}
			}
			else
			{
				GClass88 gClass = new GClass88();
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? ("D.sách\nT.báo BOSS:\n" + GClass154.smethod_0().method_7(GClass156.bool_0)) : ("List Bosses\nInformation:\n" + GClass154.smethod_0().method_7(GClass156.bool_0)), this, 101201, null));
				gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ("AutoMurdering\nBOSS:\n" + GClass154.smethod_0().method_7(bool_0)) : ("Đồ sát\nBOSS:\n" + GClass154.smethod_0().method_7(bool_0)), this, 101202, null));
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? ("Fix Bosses\nLỗi HP:\n" + GClass154.smethod_0().method_7(bool_2)) : ("Fix Bosses\nError HP:\n" + GClass154.smethod_0().method_7(bool_2)), this, 101204, null));
				if (list_0.Count > 0 || list_1.Count > 0)
					gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Xóa d.sách\nBOSS\n đồ sát" : "Delete\nLiss Boss\nMurdering", this, 101203, null));
				GClass73.gclass145_0.bool_1 = true;
				GClass73.gclass145_0.method_2(gClass, 0);
			}
		}

		public void method_5()
		{
			method_7();
			method_19();
			method_12();
			method_13();
			method_11();
		}

		public void method_6(GClass122 g)
		{
			GClass156.smethod_5(g);
		}

		protected void method_7()
		{
			if (!bool_2 || GClass73.int_8 % 10 != 0)
				return;
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				if (GClass144.gclass88_5.method_3(i) is GClass78 gClass && gClass.int_25 > 0 && gClass.int_13 < 0 && method_1(gClass))
					gClass.sbyte_19 = 5;
			}
		}

		public void method_8()
		{
			List<GClass78> list = list_3;
			if (int_2 >= list.Count)
				int_2 = 0;
			if (list.Count <= 0 || int_2 >= list.Count)
				return;
			if (GClass78.smethod_1().gclass78_0 != list[0] && list.Count == 1)
			{
				GClass78.smethod_1().gclass194_0 = null;
				GClass78.smethod_1().gclass64_0 = null;
				GClass78.smethod_1().gclass79_0 = null;
				GClass78.smethod_1().gclass78_0 = list[0];
			}
			if (GClass78.smethod_1().gclass78_0 != list[int_2])
			{
				GClass78.smethod_1().gclass194_0 = null;
				GClass78.smethod_1().gclass64_0 = null;
				GClass78.smethod_1().gclass79_0 = null;
				GClass78.smethod_1().gclass78_0 = list[int_2];
			}
			if (GClass78.smethod_1().gclass78_0 == list[int_2])
			{
				GClass159.smethod_0().method_26(list[int_2].int_4, list[int_2].int_5);
				if (list.Count - int_2 <= 1)
					int_2 = 0;
				else
					int_2++;
			}
		}

		protected void method_9(List<GClass78> myList, int i, int m)
		{
			GClass78 value = myList[i];
			myList[i] = myList[m];
			myList[m] = value;
		}

		protected List<GClass78> method_10()
		{
			for (int i = 0; i < list_3.Count - 1; i++)
			{
				int m = i;
				char[] array = list_3[i].string_3.ToCharArray();
				int num = 0;
				for (int j = 0; j < array.Length; j++)
				{
					num += array[j];
				}
				for (int k = i + 1; k < list_3.Count; k++)
				{
					char[] array2 = list_3[k].string_3.ToCharArray();
					int num2 = 0;
					for (int l = 0; l < array2.Length; l++)
					{
						num2 += array2[l];
					}
					if (num2 > num)
					{
						m = k;
						num = num2;
					}
				}
				method_9(list_3, i, m);
			}
			return list_3;
		}

		protected void method_11()
		{
			try
			{
				list_3.Clear();
				for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
				{
					GClass78 gClass = (GClass78)GClass144.gclass88_5.method_3(i);
					if (gClass != null && gClass.sbyte_19 == 5 && !gClass.bool_54 && !gClass.bool_53 && gClass.int_13 < 0 && gClass.string_3 != ((mResources.language == 0) ? "Trọng tài" : "Arbitration") && !list_3.Contains(gClass))
					{
						list_3.Add(gClass);
						list_3 = method_10();
					}
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/addBossInMap.txt", ex.ToString());
			}
		}

		protected void method_12()
		{
			try
			{
				if (GClass20.int_37 < 131 || GClass20.int_37 > 133 || !bool_1)
					return;
				list_2.Clear();
				for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
				{
					if (GClass144.gclass88_5.method_3(i) is GClass78 gClass && gClass.sbyte_19 == 5 && method_1(gClass) && gClass.int_13 < 0 && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 100 && !list_2.Contains(gClass))
						list_2.Add(gClass);
					for (int j = 0; j < list_2.Count; j++)
					{
						if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, list_2[j].int_4, list_2[j].int_5) > 100)
							list_2.RemoveAt(j);
					}
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/addYardartSoldier.txt", ex.ToString());
			}
		}

		protected void method_13()
		{
			try
			{
				if (!bool_1 || GClass20.int_37 < 131 || GClass20.int_37 > 133 || GClass203.smethod_18() - long_0 <= 1500L)
					return;
				if (list_2.Count != 1)
				{
					if (list_2.Count <= 1)
						return;
					if (int_1 < list_2.Count)
					{
						if (list_2[int_1] == null)
						{
							int_1 = 0;
							return;
						}
						if (list_2[int_1] != null)
						{
							GClass78.smethod_1().gclass194_0 = null;
							GClass78.smethod_1().gclass79_0 = null;
							GClass78.smethod_1().gclass64_0 = null;
							GClass78.smethod_1().gclass78_0 = list_2[int_1];
							int_1++;
							long_0 = GClass203.smethod_18();
						}
					}
					if (int_1 >= list_2.Count)
						int_1 = 0;
				}
				else if (list_2[0] == null)
				{
					int_1 = 0;
				}
				else
				{
					GClass78.smethod_1().gclass64_0 = null;
					GClass78.smethod_1().gclass79_0 = null;
					GClass78.smethod_1().gclass194_0 = null;
					GClass78.smethod_1().gclass78_0 = list_2[0];
					long_0 = GClass203.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/changeObject.txt", ex.ToString());
			}
		}

		protected void method_14()
		{
			if (GClass78.smethod_1().gclass63_0 != null)
			{
				GClass63 gclass63_ = GClass78.smethod_1().gclass63_0;
				if (list_4.Contains(gclass63_.gclass47_0.sbyte_0))
				{
					list_4.Remove(gclass63_.gclass47_0.sbyte_0);
					GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đã xóa skill: " + gclass63_.gclass47_0.string_0) : ("Deleted skill: " + gclass63_.gclass47_0.string_0), 0);
				}
				else
				{
					list_4.Add(gclass63_.gclass47_0.sbyte_0);
					GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đã thêm skill: " + gclass63_.gclass47_0.string_0) : ("Added skill: " + gclass63_.gclass47_0.string_0), 0);
				}
			}
		}

		protected void method_15()
		{
			if (GClass78.smethod_1().gclass78_0 != null && GClass78.smethod_1().gclass78_0.int_13 <= 0)
			{
				GClass78 gclass78_ = GClass78.smethod_1().gclass78_0;
				if (list_0.Contains(new GStruct1(gclass78_.int_119, gclass78_.int_121, gclass78_.int_120)))
				{
					list_0.Remove(new GStruct1(gclass78_.int_119, gclass78_.int_121, gclass78_.int_120));
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Deleted BOSS: " + gclass78_.string_3) : ("Đã xóa BOSS: " + gclass78_.string_3), 0);
				}
				else
				{
					list_0.Add(new GStruct1(gclass78_.int_119, gclass78_.int_121, gclass78_.int_120));
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Added BOSS: " + gclass78_.string_3) : ("Đã thêm BOSS: " + gclass78_.string_3), 0);
				}
			}
		}

		protected void method_16()
		{
			if (GClass78.smethod_1().gclass78_0 != null && GClass78.smethod_1().gclass78_0.int_13 <= 0)
			{
				GClass78 gclass78_ = GClass78.smethod_1().gclass78_0;
				if (list_1.Contains(new GStruct1(gclass78_.int_119, gclass78_.int_121, gclass78_.int_120)))
				{
					list_1.Remove(new GStruct1(gclass78_.int_119, gclass78_.int_121, gclass78_.int_120));
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Deleted BOSS: " + gclass78_.string_3) : ("Đã xóa BOSS: " + gclass78_.string_3), 0);
				}
				else
				{
					list_1.Add(new GStruct1(gclass78_.int_119, gclass78_.int_121, gclass78_.int_120));
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Added BOSS: " + gclass78_.string_3) : ("Đã thêm BOSS: " + gclass78_.string_3), 0);
				}
			}
		}

		protected static bool smethod_1(GClass78 @char)
		{
			if (@char.int_5 <= 20)
				return false;
			if (list_0.Count == 0 || list_0.Contains(new GStruct1(@char.int_119, @char.int_121, @char.int_120)))
			{
				if (list_1.Count == 0 || !list_1.Contains(new GStruct1(@char.int_119, @char.int_121, @char.int_120)))
				{
					if (@char.int_13 > 0 || @char.sbyte_19 != 5)
						return false;
					return true;
				}
				return false;
			}
			return false;
		}

		protected static bool smethod_2(GClass78 @char)
		{
			if (!smethod_1(@char))
				return false;
			return true;
		}

		protected static GClass78 smethod_3()
		{
			GClass78 result = null;
			int num = int.MaxValue;
			GClass78 gClass = GClass78.smethod_1();
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				GClass78 gClass2 = (GClass78)GClass144.gclass88_5.method_3(i);
				int num2 = (gClass2.int_4 - gClass.int_4) * (gClass2.int_4 - gClass.int_4) + (gClass2.int_5 - gClass.int_5) * (gClass2.int_5 - gClass.int_5);
				if (smethod_2(gClass2) && num2 < num && !gClass.bool_53 && !gClass.bool_54 && smethod_0().int_0 > 0 && gClass2.int_25 <= smethod_0().int_0)
				{
					result = gClass2;
					num = num2;
				}
				if (smethod_2(gClass2) && num2 < num && !gClass.bool_53 && !gClass.bool_54 && smethod_0().int_0 == 0)
				{
					result = gClass2;
					num = num2;
				}
			}
			return result;
		}

		protected static GClass78 smethod_4()
		{
			GClass78 result = null;
			long num = GClass203.smethod_18();
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				GClass78 gClass = (GClass78)GClass144.gclass88_5.method_3(i);
				if (smethod_5(gClass) && gClass.long_14 < num && !gClass.bool_53 && !gClass.bool_54 && smethod_2(gClass) && !gClass.bool_54 && smethod_0().int_0 > 0 && gClass.int_25 <= smethod_0().int_0)
				{
					result = gClass;
					num = gClass.long_14;
				}
				if (smethod_5(gClass) && gClass.long_14 < num && !gClass.bool_53 && !gClass.bool_54 && smethod_2(gClass) && smethod_0().int_0 == 0)
				{
					result = gClass;
					num = gClass.long_14;
				}
			}
			return result;
		}

		protected static bool smethod_5(GClass78 @char)
		{
			if (!smethod_1(@char))
				return false;
			return true;
		}

		public void method_17()
		{
			list_4.Clear();
			GClass149.smethod_1((GClass151.int_0 != 0) ? "Deleted list Skill murdering Char" : "Đã xóa d/s skill đồ sát người", 0);
		}

		protected GClass63 method_18()
		{
			GClass63 gClass = null;
			GClass47 gClass2 = new GClass47();
			foreach (sbyte item in list_4)
			{
				gClass2.sbyte_0 = item;
				GClass63 gClass3 = GClass78.smethod_1().method_16(gClass2);
				if (smethod_6(gClass3, gClass))
					gClass = gClass3;
			}
			return gClass;
		}

		public static bool smethod_6(GClass63 SkillBetter, GClass63 skill)
		{
			if (SkillBetter != null)
			{
				if (!SkillBetter.bool_0)
				{
					if (smethod_7(SkillBetter))
					{
						bool flag = SkillBetter.gclass47_0.sbyte_0 == 17 && skill.gclass47_0.sbyte_0 == 2;
						if (skill != null && skill.int_1 >= SkillBetter.int_1 && !flag)
							return false;
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}

		public static bool smethod_7(GClass63 skill)
		{
			if (GClass203.smethod_18() - skill.long_1 > skill.int_1)
				skill.bool_0 = false;
			if (skill.bool_0 && !sbyte_1.Contains(skill.gclass47_0.sbyte_0))
				return false;
			if (!sbyte_2.Contains(skill.gclass47_0.sbyte_0))
			{
				if (GClass78.smethod_1().int_24 < smethod_8(skill))
					return false;
				return true;
			}
			return false;
		}

		public static int smethod_8(GClass63 skill)
		{
			if (skill.gclass47_0.int_2 == 2)
				return 1;
			if (skill.gclass47_0.int_2 != 1)
				return skill.int_5;
			return skill.int_5 * GClass78.smethod_1().int_36 / 100;
		}

		public void method_19()
		{
			if (!bool_0 || method_21())
				return;
			GClass78 gClass = GClass78.smethod_1();
			if (gClass.int_11 == 14 || gClass.int_25 <= 0)
				return;
			if (!gClass.bool_23)
			{
				gClass.method_104(2);
				bool flag = GClass19.smethod_0(4387);
				if (gClass.gclass78_0 != null && !smethod_2(gClass.gclass78_0))
					gClass.gclass78_0 = null;
				if (gClass.gclass78_0 != null)
				{
					if (gClass.method_75() != null)
					{
						if (!flag)
						{
							GClass78 gClass2 = smethod_4();
							if (gClass2 != null)
								GClass166.smethod_0().method_13(gClass2.int_4, gClass2.int_5);
						}
					}
					else
					{
						GClass63 gClass3 = method_18();
						if (gClass3 != null && !gClass3.bool_0)
						{
							GClass78 gclass78_ = gClass.gclass78_0;
							if (gClass.gclass63_0 != gClass3 || gClass.int_11 == 5 || gClass.gclass63_0.gclass47_0.int_3 == 3 || gClass.gclass63_0.gclass47_0.sbyte_0 == 10 || gClass.gclass63_0.gclass47_0.sbyte_0 == 11)
								GClass144.smethod_8().method_62(gClass3, true);
							int int_ = GClass20.int_23;
							int int_2 = GClass20.int_24;
							bool flag2 = gclass78_.int_5 < 0;
							bool flag3 = gclass78_.int_4 < 0;
							bool flag4 = gclass78_.int_4 > int_;
							bool flag5 = gclass78_.int_5 > int_2 || gclass78_.int_5 > GClass157.smethod_0().method_13(gclass78_.int_4);
							if (GClass50.smethod_24(gclass78_.int_4, gclass78_.int_5, gClass.int_4, gClass.int_5) > 48 || gclass78_.int_25 <= 0)
							{
								if (!flag)
									GClass166.smethod_0().method_13(gclass78_.int_4, gclass78_.int_5);
								else if (!flag3)
								{
									if (!flag4)
									{
										if (flag5)
										{
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(gclass78_.int_4);
											GClass7.smethod_0().method_44();
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(gclass78_.int_4) + 1;
											GClass7.smethod_0().method_44();
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(gclass78_.int_4);
											GClass7.smethod_0().method_44();
											method_20(500);
										}
										else if (flag2)
										{
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = 10;
											GClass7.smethod_0().method_44();
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = 11;
											GClass7.smethod_0().method_44();
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = 10;
											GClass7.smethod_0().method_44();
											method_20(500);
										}
										else
										{
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = gclass78_.int_5;
											GClass7.smethod_0().method_44();
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = gclass78_.int_5 + 1;
											GClass7.smethod_0().method_44();
											GClass78.smethod_1().int_4 = gclass78_.int_4;
											GClass78.smethod_1().int_5 = gclass78_.int_5;
											GClass7.smethod_0().method_44();
											method_20(500);
										}
									}
									else
									{
										GClass78.smethod_1().int_4 = int_ - 50;
										GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(int_ - 50);
										GClass7.smethod_0().method_44();
										GClass78.smethod_1().int_4 = int_ - 50;
										GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(int_ - 50) + 1;
										GClass7.smethod_0().method_44();
										GClass78.smethod_1().int_4 = int_ - 50;
										GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(int_ - 50);
										GClass7.smethod_0().method_44();
										method_20(500);
									}
								}
								else
								{
									GClass78.smethod_1().int_4 = 10;
									GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(10);
									GClass7.smethod_0().method_44();
									GClass78.smethod_1().int_4 = 10;
									GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(10) + 1;
									GClass7.smethod_0().method_44();
									GClass78.smethod_1().int_4 = 10;
									GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(10);
									GClass7.smethod_0().method_44();
									method_20(500);
								}
							}
							else
								GClass164.smethod_0().method_15();
						}
					}
					method_20(200);
					return;
				}
				gClass.gclass78_0 = smethod_3();
				if (!flag || gClass.gclass78_0 == null)
					return;
				int int_3 = GClass20.int_23;
				int int_4 = GClass20.int_24;
				bool flag6 = gClass.gclass78_0.int_5 < 0;
				bool flag7 = gClass.gclass78_0.int_4 < 0;
				bool flag8 = gClass.gclass78_0.int_4 > int_3;
				bool flag9 = gClass.gclass78_0.int_5 > int_4 || gClass.gclass78_0.int_5 > GClass157.smethod_0().method_13(gClass.gclass78_0.int_4);
				if (!flag7)
				{
					if (flag8)
					{
						GClass78.smethod_1().int_4 = int_3 - 50;
						GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(int_3 - 50);
						GClass7.smethod_0().method_44();
						method_20(500);
					}
					else if (!flag9)
					{
						if (!flag6)
						{
							GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
							GClass78.smethod_1().int_5 = gClass.gclass78_0.int_5;
							GClass7.smethod_0().method_44();
							method_20(500);
						}
						else
						{
							GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
							GClass78.smethod_1().int_5 = 10;
							GClass7.smethod_0().method_44();
							method_20(500);
						}
					}
					else
					{
						GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
						GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(gClass.gclass78_0.int_4);
						GClass7.smethod_0().method_44();
						method_20(500);
					}
				}
				else
				{
					GClass78.smethod_1().int_4 = 10;
					GClass78.smethod_1().int_5 = GClass157.smethod_0().method_13(10);
					GClass7.smethod_0().method_44();
					method_20(500);
				}
			}
			else
				method_20(500);
		}

		public void method_20(int time)
		{
			bool_3 = true;
			long_1 = GClass203.smethod_18();
			long_2 = time;
		}

		public bool method_21()
		{
			if (bool_3 && GClass203.smethod_18() - long_1 >= long_2)
				bool_3 = false;
			return bool_3;
		}
	}
}
