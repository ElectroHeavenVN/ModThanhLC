using System;
using System.Collections.Generic;
using System.Linq;

namespace ns1
{
	public class GClass189 : GInterface0
	{
		public struct GStruct8
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public GStruct8(int head, int body, int leg)
			{
				int_0 = head;
				int_1 = body;
				int_2 = leg;
			}
		}

		public bool bool_0;

		public static List<GStruct8> list_0 = new List<GStruct8>();

		public static List<GStruct8> list_1 = new List<GStruct8>();

		public int int_0 = 0;

		public bool bool_1;

		public int int_1 = 0;

		public long long_0;

		public List<GClass58> list_2 = new List<GClass58>();

		private static GClass189 UiXllEbhPC;

		public static List<GClass58> list_3 = new List<GClass58>();

		public int int_2 = 0;

		public bool bool_2;

		public static readonly sbyte[] sbyte_0 = new sbyte[4] { 0, 2, 17, 4 };

		public static List<sbyte> list_4 = new List<sbyte>(sbyte_0);

		public static readonly sbyte[] sbyte_1 = new sbyte[5] { 0, 9, 2, 17, 4 };

		public static readonly sbyte[] sbyte_2 = new sbyte[5] { 10, 11, 14, 23, 7 };

		private bool bool_3;

		private long long_1;

		private long long_2;

		public string method_0(GClass58 @char, bool enableRichText = false)
		{
			string text = @char.string_3.Remove(0, @char.string_3.IndexOf(']') + 1).TrimStart(' ', '#', '$');
			if (enableRichText)
				text = (method_2(@char) ? ("<color=cyan>" + text + "</color>") : ((!method_1(@char)) ? ("<color=yellow>" + text + "</color>") : $"<color=red><size={7 * GClass76.int_12}>{text}</size></color>"));
			return text;
		}

		public bool method_1(GClass58 @char)
		{
			return !method_2(@char) && @char.string_3 != ((mResources.language == 0) ? "Trọng tài" : "Arbitration") && char.IsUpper(method_0(@char)[0]);
		}

		public bool method_2(GClass58 @char)
		{
			return @char.method_0() || @char.method_1() || @char.string_3.StartsWith("#") || @char.string_3.StartsWith("$");
		}

		public static GClass189 smethod_0()
		{
			return (UiXllEbhPC != null) ? UiXllEbhPC : (UiXllEbhPC = new GClass189());
		}

		public bool method_3(string text)
		{
			object obj;
			switch (text)
			{
			case "/tbb":
				GClass179.bool_0 = !GClass179.bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("D/s thông báo Boss: " + GClass193.smethod_0().method_6(GClass179.bool_0)) : ("List boss information: " + GClass193.smethod_0().method_6(GClass179.bool_0)), 0);
				goto IL_027c;
			case "/dsb":
				smethod_0().bool_0 = !smethod_0().bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động tàn sát BOSS: " + GClass193.smethod_0().method_6(smethod_0().bool_0)) : ("Auto murdering boss: " + GClass193.smethod_0().method_6(smethod_0().bool_0)), 0);
				goto IL_027c;
			case "/cobj":
				smethod_0().bool_1 = !smethod_0().bool_1;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động chuyển mục tiêu: " + GClass193.smethod_0().method_6(smethod_0().bool_1)) : ("Auto change object: " + GClass193.smethod_0().method_6(smethod_0().bool_1)), 0);
				goto IL_027c;
			case "/badd":
				smethod_0().method_15();
				goto IL_027c;
			case "/bclear":
				list_1.Clear();
				list_0.Clear();
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã xóa d/s tàn sát BOSS" : "Deleted list Boss murdering", 0);
				goto IL_027c;
			case "/bignore":
				smethod_0().method_16();
				goto IL_027c;
			case "/addskill":
				method_14();
				goto IL_027c;
			case "/clearskill":
				list_4.Clear();
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã xóa d/s skill tàn sát BOSS" : "Deleted list Skill murdering Boss", 0);
				goto IL_027c;
			default:
				{
					if (GClass193.smethod_0().method_10<int>(text, "/bosshp"))
					{
						int_0 = GClass193.smethod_0().method_11<int>(text, "/bosshp");
						if (int_0 == 0)
							obj = ((GClass192.int_0 == 0) ? "Tắt giới hạn HP Boss" : "Turn off limited Boss HP");
						else if (GClass192.int_0 != 0)
						{
							obj = "Only attack boss have HP lower than " + GClass95.smethod_9(int_0) + " HP";
							if (obj == null)
								goto IL_02fc;
						}
						else
						{
							obj = "Chỉ đánh boss dưới " + GClass95.smethod_9(int_0) + " HP";
							if (obj == null)
								goto IL_02fc;
						}
						goto IL_0317;
					}
					goto IL_031d;
				}
				IL_02fc:
				obj = "";
				goto IL_0317;
				IL_027c:
				return true;
				IL_0317:
				GClass188.smethod_1((string)obj, 0);
				goto IL_031d;
				IL_031d:
				return false;
			}
		}

		public bool method_4(int asciiCode)
		{
			if (asciiCode != 101)
				return false;
			if (!GClass177.smethod_0().method_5())
				method_8();
			else
				GClass166.smethod_0().method_78("/ahs");
			return true;
		}

		public void perform(int idAction, object p)
		{
			if (GClass171.smethod_0().bool_0)
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
					method_3("/bclear");
					break;
				case 101204:
					bool_2 = !bool_2;
					break;
				}
			}
			else
			{
				GClass63 gClass = new GClass63();
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("D.sách\nT.báo BOSS:\n" + GClass193.smethod_0().method_7(GClass179.bool_0)) : ("List Bosses\nInformation:\n" + GClass193.smethod_0().method_7(GClass179.bool_0)), this, 101201, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Đồ sát\nBOSS:\n" + GClass193.smethod_0().method_7(bool_0)) : ("AutoMurdering\nBOSS:\n" + GClass193.smethod_0().method_7(bool_0)), this, 101202, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Fix Bosses\nLỗi HP:\n" + GClass193.smethod_0().method_7(bool_2)) : ("Fix Bosses\nError HP:\n" + GClass193.smethod_0().method_7(bool_2)), this, 101204, null));
				if (list_0.Count > 0 || list_1.Count > 0)
					gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Xóa d.sách\nBOSS\n đồ sát" : "Delete\nLiss Boss\nMurdering", this, 101203, null));
				GClass39.gclass0_0.method_2(gClass, 0);
			}
		}

		public void method_5()
		{
			method_7();
			method_17();
			method_12();
			method_13();
			method_11();
		}

		public void method_6(GClass76 g)
		{
			GClass179.smethod_5(g);
		}

		public void method_7()
		{
			if (!bool_2 || GClass39.int_8 % 10 != 0)
				return;
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				if (GClass154.gclass63_5.method_3(i) is GClass58 gClass && gClass.int_25 > 0 && gClass.int_13 < 0 && method_1(gClass))
					gClass.sbyte_19 = 5;
			}
		}

		public void method_8()
		{
			List<GClass58> list = list_3;
			if (int_2 > list.Count)
				int_2 = 0;
			if (list.Count <= 0 || int_2 >= list.Count)
				return;
			if (GClass58.smethod_1().gclass58_0 != list[int_2])
			{
				GClass58.smethod_1().gclass85_0 = null;
				GClass58.smethod_1().gclass134_0 = null;
				GClass58.smethod_1().gclass59_0 = null;
				GClass58.smethod_1().gclass58_0 = list[int_2];
			}
			if (GClass58.smethod_1().gclass58_0 == list[int_2])
			{
				GClass191.smethod_0().method_25(list[int_2].int_4, list[int_2].int_5);
				if (list.Count - int_2 > 1)
					int_2++;
				else
					int_2 = 0;
			}
		}

		public void method_9(List<GClass58> myList, int i, int m)
		{
			GClass58 value = myList[i];
			myList[i] = myList[m];
			myList[m] = value;
		}

		public List<GClass58> method_10()
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

		public void method_11()
		{
			try
			{
				for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
				{
					GClass58 gClass = (GClass58)GClass154.gclass63_5.method_3(i);
					if (gClass != null && gClass.int_13 < 0 && !list_3.Contains(gClass) && gClass.int_25 > 0 && method_1(gClass))
					{
						list_3.Add(gClass);
						list_3 = method_10();
					}
					for (int j = 0; j < list_3.Count; j++)
					{
						if (list_3.Count != 0)
						{
							if (GClass154.smethod_14(list_3[j].int_13) == null)
								list_3.RemoveAt(j);
							continue;
						}
						return;
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/addBossInMap.txt", ex.ToString());
			}
		}

		public void method_12()
		{
			try
			{
				if (GClass1.int_37 < 131 || GClass1.int_37 > 133 || !bool_1)
					return;
				for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
				{
					if (GClass154.gclass63_5.method_3(i) is GClass58 gClass && gClass.sbyte_19 == 5 && method_1(gClass) && gClass.int_13 < 0 && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 100 && !list_2.Contains(gClass))
						list_2.Add(gClass);
					for (int j = 0; j < list_2.Count; j++)
					{
						if (GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, list_2[j].int_4, list_2[j].int_5) > 100)
							list_2.RemoveAt(j);
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/addYardartSoldier.txt", ex.ToString());
			}
		}

		public void method_13()
		{
			try
			{
				if (!bool_1 || GClass1.int_37 < 131 || GClass1.int_37 > 133 || GClass138.smethod_18() - long_0 <= 1500L)
					return;
				if (list_2.Count == 1)
				{
					if (list_2[0] == null)
					{
						int_1 = 0;
						return;
					}
					GClass58.smethod_1().gclass134_0 = null;
					GClass58.smethod_1().gclass59_0 = null;
					GClass58.smethod_1().gclass85_0 = null;
					GClass58.smethod_1().gclass58_0 = list_2[0];
					long_0 = GClass138.smethod_18();
				}
				else
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
							GClass58.smethod_1().gclass85_0 = null;
							GClass58.smethod_1().gclass59_0 = null;
							GClass58.smethod_1().gclass134_0 = null;
							GClass58.smethod_1().gclass58_0 = list_2[int_1];
							int_1++;
							long_0 = GClass138.smethod_18();
						}
					}
					if (int_1 >= list_2.Count)
						int_1 = 0;
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/changeObject.txt", ex.ToString());
			}
		}

		public void method_14()
		{
			if (GClass58.smethod_1().gclass74_0 != null)
			{
				GClass74 gclass74_ = GClass58.smethod_1().gclass74_0;
				if (list_4.Contains(gclass74_.gclass53_0.sbyte_0))
				{
					list_4.Remove(gclass74_.gclass53_0.sbyte_0);
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã xóa skill: " + gclass74_.gclass53_0.string_0) : ("Deleted skill: " + gclass74_.gclass53_0.string_0), 0);
				}
				else
				{
					list_4.Add(gclass74_.gclass53_0.sbyte_0);
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm skill: " + gclass74_.gclass53_0.string_0) : ("Added skill: " + gclass74_.gclass53_0.string_0), 0);
				}
			}
		}

		public void method_15()
		{
			if (GClass58.smethod_1().gclass58_0 != null && GClass58.smethod_1().gclass58_0.int_13 <= 0)
			{
				GClass58 gclass58_ = GClass58.smethod_1().gclass58_0;
				if (list_0.Contains(new GStruct8(gclass58_.int_119, gclass58_.int_121, gclass58_.int_120)))
				{
					list_0.Remove(new GStruct8(gclass58_.int_119, gclass58_.int_121, gclass58_.int_120));
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã xóa BOSS: " + gclass58_.string_3) : ("Deleted BOSS: " + gclass58_.string_3), 0);
				}
				else
				{
					list_0.Add(new GStruct8(gclass58_.int_119, gclass58_.int_121, gclass58_.int_120));
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm BOSS: " + gclass58_.string_3) : ("Added BOSS: " + gclass58_.string_3), 0);
				}
			}
		}

		public void method_16()
		{
			if (GClass58.smethod_1().gclass58_0 != null && GClass58.smethod_1().gclass58_0.int_13 <= 0)
			{
				GClass58 gclass58_ = GClass58.smethod_1().gclass58_0;
				if (list_1.Contains(new GStruct8(gclass58_.int_119, gclass58_.int_121, gclass58_.int_120)))
				{
					list_1.Remove(new GStruct8(gclass58_.int_119, gclass58_.int_121, gclass58_.int_120));
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã xóa BOSS: " + gclass58_.string_3) : ("Deleted BOSS: " + gclass58_.string_3), 0);
				}
				else
				{
					list_1.Add(new GStruct8(gclass58_.int_119, gclass58_.int_121, gclass58_.int_120));
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm BOSS: " + gclass58_.string_3) : ("Added BOSS: " + gclass58_.string_3), 0);
				}
			}
		}

		public static bool smethod_1(GClass58 @char)
		{
			if (list_0.Count != 0 && !list_0.Contains(new GStruct8(@char.int_119, @char.int_121, @char.int_120)))
				return false;
			if (list_1.Count != 0 && list_1.Contains(new GStruct8(@char.int_119, @char.int_121, @char.int_120)))
				return false;
			if (@char.int_13 > 0 || @char.sbyte_19 != 5)
				return false;
			return true;
		}

		public static bool smethod_2(GClass58 @char)
		{
			if (!smethod_1(@char))
				return false;
			return true;
		}

		public static GClass58 smethod_3()
		{
			GClass58 result = null;
			int num = int.MaxValue;
			GClass58 gClass = GClass58.smethod_1();
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				GClass58 gClass2 = (GClass58)GClass154.gclass63_5.method_3(i);
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

		public static GClass58 smethod_4()
		{
			GClass58 result = null;
			long num = GClass138.smethod_18();
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				GClass58 gClass = (GClass58)GClass154.gclass63_5.method_3(i);
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

		public static bool smethod_5(GClass58 @char)
		{
			if (!smethod_1(@char))
				return false;
			return true;
		}

		public static GClass74 smethod_6()
		{
			GClass74 gClass = null;
			GClass53 gClass2 = new GClass53();
			foreach (sbyte item in list_4)
			{
				gClass2.sbyte_0 = item;
				GClass74 gClass3 = GClass58.smethod_1().method_15(gClass2);
				if (smethod_7(gClass3, gClass))
					gClass = gClass3;
			}
			return gClass;
		}

		public static bool smethod_7(GClass74 SkillBetter, GClass74 skill)
		{
			if (SkillBetter == null)
				return false;
			if (SkillBetter.bool_0)
				return false;
			if (!smethod_8(SkillBetter))
				return false;
			bool flag = SkillBetter.gclass53_0.sbyte_0 == 17 && skill.gclass53_0.sbyte_0 == 2;
			if (skill != null && skill.int_1 >= SkillBetter.int_1 && !flag)
				return false;
			return true;
		}

		public static bool smethod_8(GClass74 skill)
		{
			if (GClass138.smethod_18() - skill.long_1 > skill.int_1)
				skill.bool_0 = false;
			if (skill.bool_0 && !sbyte_1.Contains(skill.gclass53_0.sbyte_0))
				return false;
			if (sbyte_2.Contains(skill.gclass53_0.sbyte_0))
				return false;
			if (GClass58.smethod_1().int_24 < smethod_9(skill))
				return false;
			return true;
		}

		public static int smethod_9(GClass74 skill)
		{
			if (skill.gclass53_0.int_2 == 2)
				return 1;
			if (skill.gclass53_0.int_2 == 1)
				return skill.int_5 * GClass58.smethod_1().int_36 / 100;
			return skill.int_5;
		}

		public void method_17()
		{
			if (!bool_0 || method_19())
				return;
			GClass58 gClass = GClass58.smethod_1();
			if (gClass.int_11 == 14 || gClass.int_25 <= 0)
				return;
			if (gClass.bool_23)
			{
				method_18(500);
				return;
			}
			gClass.method_102(2);
			bool flag = GClass82.smethod_0(4387);
			if (gClass.gclass58_0 != null && !smethod_2(gClass.gclass58_0))
				gClass.gclass58_0 = null;
			if (gClass.gclass58_0 == null)
			{
				gClass.gclass58_0 = smethod_3();
				if (flag && gClass.gclass58_0 != null)
				{
					int int_ = GClass1.int_23;
					int int_2 = GClass1.int_24;
					bool flag2 = gClass.gclass58_0.int_5 < 0;
					bool flag3 = gClass.gclass58_0.int_4 < 0;
					bool flag4 = gClass.gclass58_0.int_4 > int_;
					bool flag5 = gClass.gclass58_0.int_5 > int_2 || gClass.gclass58_0.int_5 > GClass175.smethod_0().method_12(gClass.gclass58_0.int_4);
					if (flag3)
					{
						GClass58.smethod_1().int_4 = 10;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(10);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag4)
					{
						GClass58.smethod_1().int_4 = int_ - 50;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(int_ - 50);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag5)
					{
						GClass58.smethod_1().int_4 = gClass.gclass58_0.int_4;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(gClass.gclass58_0.int_4);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag2)
					{
						GClass58.smethod_1().int_4 = gClass.gclass58_0.int_4;
						GClass58.smethod_1().int_5 = 10;
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else
					{
						GClass58.smethod_1().int_4 = gClass.gclass58_0.int_4;
						GClass58.smethod_1().int_5 = gClass.gclass58_0.int_5;
						GClass166.smethod_0().method_44();
						method_18(500);
					}
				}
				return;
			}
			if (gClass.method_74() == null)
			{
				GClass74 gClass2 = smethod_6();
				if (gClass2 != null && !gClass2.bool_0)
				{
					GClass58 gclass58_ = gClass.gclass58_0;
					if (gClass.gclass74_0 != gClass2 || gClass.int_11 == 5 || gClass.gclass74_0.gclass53_0.int_3 == 3 || gClass.gclass74_0.gclass53_0.sbyte_0 == 10 || gClass.gclass74_0.gclass53_0.sbyte_0 == 11)
						GClass154.smethod_8().method_62(gClass2, true);
					int int_3 = GClass1.int_23;
					int int_4 = GClass1.int_24;
					bool flag6 = gclass58_.int_5 < 0;
					bool flag7 = gclass58_.int_4 < 0;
					bool flag8 = gclass58_.int_4 > int_3;
					bool flag9 = gclass58_.int_5 > int_4 || gclass58_.int_5 > GClass175.smethod_0().method_12(gclass58_.int_4);
					if (GClass56.smethod_24(gclass58_.int_4, gclass58_.int_5, gClass.int_4, gClass.int_5) <= 48 && gclass58_.int_25 > 0)
						GClass196.smethod_0().method_13();
					else if (flag7)
					{
						GClass58.smethod_1().int_4 = 10;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(10);
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = 10;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(10) + 1;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = 10;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(10);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag8)
					{
						GClass58.smethod_1().int_4 = int_3 - 50;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(int_3 - 50);
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = int_3 - 50;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(int_3 - 50) + 1;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = int_3 - 50;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(int_3 - 50);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag9)
					{
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(gclass58_.int_4);
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(gclass58_.int_4) + 1;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(gclass58_.int_4);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag6)
					{
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = 10;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = 11;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = 10;
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else
					{
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = gclass58_.int_5;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = gclass58_.int_5 + 1;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gclass58_.int_4;
						GClass58.smethod_1().int_5 = gclass58_.int_5;
						GClass166.smethod_0().method_44();
						method_18(500);
					}
				}
			}
			else if (!flag)
			{
				GClass58 gClass3 = smethod_4();
				if (gClass3 != null)
				{
					int int_5 = GClass1.int_23;
					int int_6 = GClass1.int_24;
					bool flag10 = gClass3.int_5 < 0;
					bool flag11 = gClass3.int_4 < 0;
					bool flag12 = gClass3.int_4 > int_5;
					bool flag13 = gClass3.int_5 > int_6 || gClass3.int_5 > GClass175.smethod_0().method_12(gClass3.int_4);
					if (flag11)
					{
						GClass58.smethod_1().int_4 = 10;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(10);
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = 10;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(10) + 1;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = 10;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(10);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag12)
					{
						GClass58.smethod_1().int_4 = int_5 - 50;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(int_5 - 50);
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = int_5 - 50;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(int_5 - 50) + 1;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = int_5 - 50;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(int_5 - 50);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag13)
					{
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(gClass3.int_4);
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(gClass3.int_4) + 1;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = GClass175.smethod_0().method_12(gClass3.int_4);
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else if (flag10)
					{
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = 10;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = 11;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = 10;
						GClass166.smethod_0().method_44();
						method_18(500);
					}
					else
					{
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = gClass3.int_5;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = gClass3.int_5 + 1;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass3.int_4;
						GClass58.smethod_1().int_5 = gClass3.int_5;
						GClass166.smethod_0().method_44();
						method_18(500);
					}
				}
			}
			method_18(200);
		}

		public void method_18(int time)
		{
			bool_3 = true;
			long_1 = GClass138.smethod_18();
			long_2 = time;
		}

		public bool method_19()
		{
			if (bool_3 && GClass138.smethod_18() - long_1 >= long_2)
				bool_3 = false;
			return bool_3;
		}
	}
}
