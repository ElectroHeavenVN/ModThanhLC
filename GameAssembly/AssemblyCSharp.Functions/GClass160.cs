using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Assets.src.g;
using UnityEngine;

namespace AssemblyCSharp.Functions
{
	public class GClass160 : GInterface4, GInterface6
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class19
		{
			public static readonly Class19 class19_0 = new Class19();

			public static ThreadStart threadStart_0;

			public static ThreadStart threadStart_1;

			public static ThreadStart threadStart_2;

			public static ThreadStart threadStart_3;

			internal void method_0()
			{
				smethod_0().method_17(1, 4);
			}

			internal void method_1()
			{
				smethod_0().method_17(2, 4);
			}

			internal void method_2()
			{
				smethod_0().method_17(1, 6);
			}

			internal void method_3()
			{
				smethod_0().method_17(2, 6);
			}
		}

		public struct GStruct5
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct5(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		public struct GStruct6
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct6(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		public struct GStruct7
		{
			public int int_0;

			public string string_0;

			public GStruct7(int id, string name)
			{
				int_0 = id;
				string_0 = name;
			}
		}

		public class GClass161
		{
			public int int_0 = -1;

			public string string_0;

			public int int_1;

			public short short_0;

			public bool bool_0;

			public bool bool_1;

			public int int_2;

			public long long_0;

			public GClass161()
			{
			}

			public GClass161(int int_1, string string_0)
			{
				int_0 = int_1;
				this.string_0 = string_0;
			}

			public GClass161(int int_1, short short_0, bool bool_0, bool bool_1)
			{
				int_0 = int_1;
				this.bool_0 = bool_0;
				this.short_0 = short_0;
				this.bool_1 = bool_1;
			}
		}

		public struct GStruct8
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct8(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		public struct GStruct9
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct9(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		public struct GStruct10
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct10(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		public struct GStruct11
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct11(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		private static GClass160 gclass160_0;

		public static Dictionary<int, int> dictionary_0;

		public int int_0 = 0;

		public static GClass161 gclass161_0;

		private static string[] string_0;

		private static string[] string_1;

		private static string[] string_2;

		public static bool bool_0;

		public long long_0;

		public long long_1;

		public bool bool_1;

		public bool bool_2;

		public List<GStruct10> list_0 = new List<GStruct10>();

		public List<GStruct11> list_1 = new List<GStruct11>();

		public List<GStruct6> list_2 = new List<GStruct6>();

		public List<GStruct9> list_3 = new List<GStruct9>();

		public List<GStruct5> list_4 = new List<GStruct5>();

		public List<GStruct8> list_5 = new List<GStruct8>();

		public int int_1;

		public string string_3;

		public List<GStruct7> list_6 = new List<GStruct7>();

		public long long_2;

		public int int_2 = 0;

		public int int_3 = 0;

		public bool bool_3;

		public long long_3;

		public int int_4 = -1;

		public bool bool_4 = false;

		public long long_4;

		public long long_5;

		public bool bool_5;

		public List<int> list_7 = new List<int> { 17, 18, 19, 20, 225, 226, 1526, 1505 };

		public List<int> list_8 = new List<int> { 1551, 1550 };

		public bool bool_6 = false;

		public bool bool_7 = true;

		public bool bool_8 = false;

		public bool bool_9 = true;

		public long long_6;

		public long long_7;

		public bool bool_10;

		public long long_8;

		public long long_9 = -1L;

		public int int_5 = -1;

		static GClass160()
		{
			dictionary_0 = new Dictionary<int, int>();
			string_0 = new string[2] { "Nhập số lượng bán", "số lượng" };
			string_1 = new string[2] { "Nhập số lượng mua", "số lượng" };
			string_2 = ((GClass151.int_0 == 0) ? new string[2] { "Nhập độ trễ sử dụng", "độ trễ (ms)" } : new string[2] { "Put time delay use", "time delay (ms)" });
		}

		public static GClass160 smethod_0()
		{
			return (gclass160_0 != null) ? gclass160_0 : (gclass160_0 = new GClass160());
		}

		public bool method_0(int asciiCode)
		{
			if (asciiCode != 100)
			{
				if (asciiCode != 115)
					return false;
				GClass88 gClass = new GClass88();
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Mặc Set 1\n[Sư phụ]" : "Wear Set1\n[Master]", smethod_0(), 11821, null));
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Mặc Set 2\n[Sư phụ]" : "Wear Set2\n[Master]", smethod_0(), 11822, null));
				GClass73.gclass145_0.bool_1 = true;
				GClass73.gclass145_0.method_2(gClass, 0);
			}
			else
			{
				GClass88 gClass2 = new GClass88();
				gClass2.method_0(new GClass87((GClass151.int_0 == 0) ? "Mặc Set 1\n[Đệ tử]" : "Wear Set1\n[Disciple]", smethod_0(), 11823, null));
				gClass2.method_0(new GClass87((GClass151.int_0 == 0) ? "Mặc Set 2\n[Đệ tử]" : "Wear Set2\n[Disciple]", smethod_0(), 11824, null));
				GClass73.gclass145_0.bool_1 = true;
				GClass73.gclass145_0.method_2(gClass2, 0);
			}
			return true;
		}

		public bool method_1(string text)
		{
			switch (text)
			{
			case "/autobuykt":
				bool_6 = !bool_6;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động mua khẩu trang: " + GClass154.smethod_0().method_6(bool_6)) : ("Auto buy mask: " + GClass154.smethod_0().method_6(bool_6)), 0);
				break;
			case "/autobuytdlt":
				bool_8 = !bool_8;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động mua TĐLT: " + GClass154.smethod_0().method_6(bool_8)) : ("Auto buy AutoTrain: " + GClass154.smethod_0().method_6(bool_8)), 0);
				break;
			case "/dropitem":
				bool_5 = !bool_5;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động vứt đồ rác: " + GClass154.smethod_0().method_6(bool_5)) : ("Auto drop trash: " + GClass154.smethod_0().method_6(bool_5)), 0);
				break;
			case "/clrlistdrop":
				list_8.Clear();
				list_7.Clear();
				GClass149.smethod_1((GClass151.int_0 != 0) ? "Cleared list item ID drop!" : "Đã xóa danh sách ID item vứt!", 0);
				break;
			default:
			{
				if (!GClass154.smethod_0().method_11<string>(text, "/additemdrop") || GClass154.smethod_0().method_12<string>(text, "/additemdrop").Contains("hsd"))
				{
					if (!GClass154.smethod_0().method_11<string>(text, "/additemdrophsd"))
					{
						if (!GClass154.smethod_0().method_10<int>(text, "/citem", 2))
							return false;
						int[] array = GClass154.smethod_0().method_8<int>(text, "/citem", 2);
						if (array[0] > 0)
							method_2(array[0], array[1]);
					}
					else if (GClass154.smethod_0().method_12<string>(text, "/additemdrophsd").Contains(","))
					{
						int[] array2 = GClass154.smethod_0().method_9<int>(text, "/additemdrophsd", ',');
						for (int i = 0; i < array2.Length; i++)
						{
							if (list_8.Contains(array2[i]))
							{
								list_8.Remove(array2[i]);
								GClass149.smethod_1((GClass151.int_0 != 0) ? $"Removed {GClass0.smethod_1((short)array2[i]).string_0} [{array2[i]}] from list item drop by Expr!" : $"Xóa {GClass0.smethod_1((short)array2[i]).string_0} [{array2[i]}] khỏi d/s item vứt theo HSD!", 0);
							}
							else
							{
								list_8.Add(array2[i]);
								GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added {GClass0.smethod_1((short)array2[i]).string_0} [{array2[i]}] to list item drop by Expr!" : $"Thêm {GClass0.smethod_1((short)array2[i]).string_0} [{array2[i]}] vào d/s item vứt theo HSD!", 0);
							}
						}
					}
					else
					{
						int num = GClass154.smethod_0().method_12<int>(text, "/additemdrophsd");
						if (list_8.Contains(num))
						{
							list_8.Remove(num);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Removed {GClass0.smethod_1((short)num).string_0} [{num}] from list item dropby Expr!" : $"Xóa {GClass0.smethod_1((short)num).string_0} [{num}] khỏi d/s item vứttheo HSD!", 0);
						}
						else
						{
							list_8.Add(num);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added {GClass0.smethod_1((short)num).string_0} [{num}] to list item drop by Expr!" : $"Thêm {GClass0.smethod_1((short)num).string_0} [{num}] vào d/s item vứt theo HSD!", 0);
						}
					}
					break;
				}
				if (!GClass154.smethod_0().method_12<string>(text, "/additemdrop").Contains(","))
				{
					int num2 = GClass154.smethod_0().method_12<int>(text, "/additemdrop");
					if (!list_7.Contains(num2))
					{
						list_7.Add(num2);
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Thêm {GClass0.smethod_1((short)num2).string_0} [{num2}] vào d/s item vứt!" : $"Added {GClass0.smethod_1((short)num2).string_0} [{num2}] to list item drop!", 0);
					}
					else
					{
						list_7.Remove(num2);
						GClass149.smethod_1((GClass151.int_0 != 0) ? $"Removed {GClass0.smethod_1((short)num2).string_0} [{num2}] from list item drop!" : $"Xóa {GClass0.smethod_1((short)num2).string_0} [{num2}] khỏi d/s item vứt!", 0);
					}
					break;
				}
				int[] array3 = GClass154.smethod_0().method_9<int>(text, "/additemdrop", ',');
				for (int j = 0; j < array3.Length; j++)
				{
					if (list_7.Contains(array3[j]))
					{
						list_7.Remove(array3[j]);
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Xóa {GClass0.smethod_1((short)array3[j]).string_0} [{array3[j]}] khỏi d/s item vứt!" : $"Removed {GClass0.smethod_1((short)array3[j]).string_0} [{array3[j]}] from list item drop!", 0);
					}
					else
					{
						list_7.Add(array3[j]);
						GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added {GClass0.smethod_1((short)array3[j]).string_0} [{array3[j]}] to list item drop!" : $"Thêm {GClass0.smethod_1((short)array3[j]).string_0} [{array3[j]}] vào d/s item vứt!", 0);
					}
				}
				break;
			}
			case "/isell":
				bool_3 = !bool_3;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto sell trash item: " + GClass154.smethod_0().method_6(bool_3)) : ("Tự động bán đồ rác: " + GClass154.smethod_0().method_6(bool_3)), 0);
				break;
			case "/getitem":
				smethod_1();
				break;
			}
			return true;
		}

		public void method_2(int itemID, int quantity)
		{
			if (quantity <= 0)
				dictionary_0.Remove(itemID);
			else if (dictionary_0.ContainsKey(itemID))
			{
				dictionary_0[itemID] = method_20(itemID, "id") + quantity;
			}
			else
			{
				dictionary_0.Add(itemID, method_20(itemID, "id") + quantity);
			}
		}

		public void method_3(GClass122 g)
		{
			if (dictionary_0.Count <= 0)
				return;
			foreach (KeyValuePair<int, int> item in dictionary_0)
			{
				GClass154.smethod_0().method_1(GClass4.gclass4_3, g, (GClass151.int_0 != 0) ? string.Format("Pick up {0} [{1}]: {2}/{3}", GClass0.smethod_1((short)item.Key).string_0, item.Key, method_20(item.Key, "id"), item.Value) : string.Format("Nhặt {0} [{1}]: {2}/{3}", GClass0.smethod_1((short)item.Key).string_0, item.Key, method_20(item.Key, "id"), item.Value), GClass73.int_10 / 2, int_0, GClass4.int_2, GClass4.gclass4_6);
				int_0 += 11;
			}
		}

		public int method_4()
		{
			int num = 0;
			if (dictionary_0.Count > 0)
			{
				foreach (KeyValuePair<int, int> item in dictionary_0)
				{
					if (item.Value <= method_20(item.Key, "id"))
						num++;
				}
			}
			return num;
		}

		public void method_5()
		{
			if (dictionary_0.Count > 0 && method_4() == dictionary_0.Count)
				Application.Quit();
		}

		public static void smethod_1()
		{
			string text = "";
			for (int i = 0; i < 2000; i++)
			{
				if (GClass0.smethod_1((short)i) != null)
					text = text + $"{GClass0.smethod_1((short)i).short_0}.{GClass0.smethod_1((short)i).string_0} - {GClass0.smethod_1((short)i).string_2} - {GClass0.smethod_1((short)i).sbyte_0} - {GClass0.smethod_1((short)i).short_1}" + "\n";
			}
			File.WriteAllText("Danh sách item.txt", text);
		}

		public void perform(int idAction, object p)
		{
			if (GClass148.smethod_0().bool_0 || GClass159.smethod_0().bool_18)
				return;
			if (idAction != 3)
			{
				if (idAction != 10206)
				{
					switch (idAction)
					{
					case 11821:
						new Thread((ThreadStart)delegate
						{
							smethod_0().method_17(1, 4);
						}).Start();
						break;
					case 11822:
						new Thread((ThreadStart)delegate
						{
							smethod_0().method_17(2, 4);
						}).Start();
						break;
					case 11823:
						new Thread((ThreadStart)delegate
						{
							smethod_0().method_17(1, 6);
						}).Start();
						break;
					case 11824:
						new Thread((ThreadStart)delegate
						{
							smethod_0().method_17(2, 6);
						}).Start();
						break;
					}
				}
				else
					method_1("/clrvp");
			}
			else
				method_7((GClass161)p);
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass91.smethod_0().gclass191_0.method_21() == null || GClass91.smethod_0().gclass191_0.method_21().Equals("") || text.Equals("") || text == null)
				GClass91.smethod_0().bool_0 = false;
			else if (GClass91.smethod_0().string_1.Equals(string_1[0]))
			{
				try
				{
					int num = int.Parse(GClass91.smethod_0().gclass191_0.method_21());
					gclass161_0.int_1 = num;
					bool_2 = true;
				}
				catch
				{
					GClass144.gclass52_0.method_7("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				method_6();
			}
			else if (GClass91.smethod_0().string_1.Equals(string_0[0]))
			{
				try
				{
					int num2 = int.Parse(GClass91.smethod_0().gclass191_0.method_21());
					gclass161_0.int_1 = num2;
					bool_1 = true;
				}
				catch
				{
					GClass144.gclass52_0.method_7("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				method_6();
			}
		}

		public void onCancelChat()
		{
		}

		private void method_6()
		{
			GClass91.smethod_0().string_1 = "Chat";
			GClass91.smethod_0().gclass191_0.string_7 = "chat";
			GClass91.smethod_0().bool_0 = false;
		}

		private void method_7(GClass161 gclass161_1)
		{
			gclass161_0 = gclass161_1;
			GClass73.gclass76_0.bool_0 = false;
			if (gclass161_1.bool_1)
			{
				GClass91.smethod_0().string_1 = string_0[0];
				GClass91.smethod_0().gclass191_0.string_7 = string_0[1];
			}
			else
			{
				GClass91.smethod_0().string_1 = string_1[0];
				GClass91.smethod_0().gclass191_0.string_7 = string_1[1];
			}
			GClass91.smethod_0().method_5(smethod_0(), "");
		}

		public void method_8(int itemID)
		{
			if (itemID <= 0 || !bool_10 || (GClass144.smethod_8().method_16() && itemID != 380))
				return;
			if (method_20(itemID, "id") == 0)
			{
				bool_10 = false;
				int_5 = -1;
				long_9 = -1L;
			}
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass != null && gClass.gclass117_0.short_0 == itemID && gClass.int_30 > 0 && long_9 != -1L && GClass203.smethod_18() - long_8 > long_9)
				{
					GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
					long_8 = GClass203.smethod_18();
				}
			}
		}

		public void method_9(GClass161 item)
		{
			if (!bool_1 || item == null)
				return;
			short short_ = item.short_0;
			if (item.int_1 == 0)
				bool_1 = false;
			if (item.int_1 <= 0)
				return;
			bool flag = false;
			if (GClass78.smethod_1().gclass128_0[short_] != null && (GClass78.smethod_1().gclass128_0[short_] == null || GClass78.smethod_1().gclass128_0[short_].gclass117_0.short_0 == (short)item.int_0))
			{
				if (!flag && GClass203.smethod_18() - long_1 > 100L)
				{
					GClass7.smethod_0().method_54(0, 1, short_);
					flag = true;
					long_1 = GClass203.smethod_18();
				}
				if (flag && GClass203.smethod_18() - long_1 > 1000L)
				{
					GClass7.smethod_0().method_54(1, 1, short_);
					long_1 = GClass203.smethod_18();
					item.int_1--;
					flag = false;
				}
				if (GClass78.smethod_1().long_6 > 1963100000L)
				{
					item.int_1 = 0;
					bool_1 = false;
				}
			}
			else
			{
				item.int_1 = 0;
				bool_1 = false;
			}
		}

		public void method_10(GClass161 item)
		{
			if (bool_2 && item != null)
			{
				if (item.int_1 == 0 || item.int_0 < 0)
					bool_2 = false;
				if (GClass144.smethod_8().method_16())
				{
					bool_2 = false;
					item.int_1 = 0;
				}
				if (item.int_1 > 0 && !GClass144.smethod_8().method_16() && GClass203.smethod_18() - long_0 > 1000L && long_0 != -1L)
				{
					GClass7.smethod_0().method_55((!item.bool_0) ? ((sbyte)1) : ((sbyte)0), item.int_0, 0);
					long_0 = -1L;
				}
			}
		}

		public void method_11()
		{
			string text = "";
			if (GClass78.smethod_1().gclass128_2[6] == null)
				return;
			if (GClass78.smethod_1().gclass128_2[6].gclass120_0 != null)
			{
				for (int i = 0; i < GClass78.smethod_1().gclass128_2[6].gclass120_0.Length; i++)
				{
					text = text + GClass78.smethod_1().gclass128_2[6].gclass120_0[i].gclass126_0.int_0 + "-";
				}
			}
			if (!list_0.Contains(new GStruct10(GClass78.smethod_1().gclass128_2[6].gclass117_0.short_0, text, GClass78.smethod_1().gclass128_2[6].gclass117_0.sbyte_0)))
				list_0.Add(new GStruct10(GClass78.smethod_1().gclass128_2[6].gclass117_0.short_0, text, GClass78.smethod_1().gclass128_2[6].gclass117_0.sbyte_0));
			if (list_0.Contains(new GStruct10(GClass78.smethod_1().gclass128_2[6].gclass117_0.short_0, text, GClass78.smethod_1().gclass128_2[6].gclass117_0.sbyte_0)))
				GClass7.smethod_0().method_30(5, 6);
		}

		public void method_12()
		{
			foreach (GStruct10 item in list_0)
			{
				GClass128[] gclass128_ = GClass78.smethod_1().gclass128_0;
				try
				{
					for (int i = 0; i < gclass128_.Length; i++)
					{
						GClass128 gClass = gclass128_[i];
						string text = "";
						if (gClass == null || gClass.gclass117_0.short_0 != item.int_0)
							continue;
						if (gClass.gclass120_0 != null)
						{
							for (int j = 0; j < gClass.gclass120_0.Length; j++)
							{
								text = text + gClass.gclass120_0[j].gclass126_0.int_0 + "-";
							}
						}
						if (text == item.string_0)
						{
							GClass7.smethod_0().method_30(4, (sbyte)i);
							Thread.Sleep(100);
						}
					}
				}
				catch
				{
				}
			}
		}

		public void method_13()
		{
			if (GClass78.smethod_1().gclass128_2[5] == null)
			{
				for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
				{
					GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
					if (gClass == null)
						continue;
					for (int j = 0; j < gClass.gclass120_0.Length; j++)
					{
						if (gClass.gclass120_0[j].gclass126_0.int_0 == 106 && GClass78.smethod_1().long_2 >= gClass.gclass117_0.int_2)
							GClass7.smethod_0().method_30(4, (sbyte)i);
					}
				}
				return;
			}
			string text = "";
			if (GClass78.smethod_1().gclass128_2[5].gclass120_0 != null)
			{
				for (int k = 0; k < GClass78.smethod_1().gclass128_2[5].gclass120_0.Length; k++)
				{
					if (!text.Contains(GClass78.smethod_1().gclass128_2[5].gclass120_0[k].gclass126_0.int_0 + "-"))
						text = text + GClass78.smethod_1().gclass128_2[5].gclass120_0[k].gclass126_0.int_0 + "-";
				}
			}
			if (!list_1.Contains(new GStruct11(GClass78.smethod_1().gclass128_2[5].gclass117_0.short_0, text, GClass78.smethod_1().gclass128_2[5].gclass117_0.sbyte_0)) && !text.Contains("106"))
				list_1.Add(new GStruct11(GClass78.smethod_1().gclass128_2[5].gclass117_0.short_0, text, GClass78.smethod_1().gclass128_2[5].gclass117_0.sbyte_0));
			if (!list_1.Contains(new GStruct11(GClass78.smethod_1().gclass128_2[5].gclass117_0.short_0, text, GClass78.smethod_1().gclass128_2[5].gclass117_0.sbyte_0)))
				return;
			for (int l = 0; l < GClass78.smethod_1().gclass128_0.Length; l++)
			{
				GClass128 gClass2 = GClass78.smethod_1().gclass128_0[l];
				if (gClass2 == null)
					continue;
				for (int m = 0; m < gClass2.gclass120_0.Length; m++)
				{
					if (gClass2.gclass120_0[m].gclass126_0.int_0 == 106 && GClass78.smethod_1().long_2 >= gClass2.gclass117_0.int_2)
						GClass7.smethod_0().method_30(4, (sbyte)l);
				}
			}
		}

		public void method_14()
		{
			try
			{
				foreach (GStruct11 item in list_1)
				{
					GClass128[] gclass128_ = GClass78.smethod_1().gclass128_0;
					try
					{
						for (int i = 0; i < gclass128_.Length; i++)
						{
							if (gclass128_[i] == null || gclass128_[i].gclass117_0.short_0 != item.int_0)
								continue;
							string text = "";
							if (gclass128_[i].gclass120_0 != null)
							{
								for (int j = 0; j < gclass128_[i].gclass120_0.Length; j++)
								{
									text = text + gclass128_[i].gclass120_0[j].gclass126_0.int_0 + "-";
								}
							}
							if (text == item.string_0)
							{
								GClass7.smethod_0().method_30(4, (sbyte)i);
								Thread.Sleep(100);
								return;
							}
						}
					}
					catch
					{
					}
				}
				if (GClass78.smethod_1().gclass128_2[5] == null || GClass78.smethod_1().gclass128_2[5].gclass120_0 == null)
					return;
				for (int k = 0; k < GClass78.smethod_1().gclass128_2[5].gclass120_0.Length; k++)
				{
					if (GClass78.smethod_1().gclass128_2[5].gclass120_0[k].gclass126_0.int_0 == 106)
						GClass7.smethod_0().method_30(5, 5);
				}
			}
			catch
			{
			}
		}

		public void method_15()
		{
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass != null && gClass.gclass117_0.short_0 >= 663 && gClass.gclass117_0.short_0 <= 667)
					GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
			}
		}

		public void method_16(GClass128 item, int ListIndex, string type)
		{
			if (ListIndex != 1)
			{
				if (ListIndex != 2)
					return;
				if (!(type == "suphu"))
				{
					if (!(type == "detu"))
						return;
					string text = "";
					if (item.gclass120_0 != null)
					{
						for (int i = 0; i < item.gclass120_0.Length; i++)
						{
							text = text + item.gclass120_0[i].gclass126_0.int_0 + "-";
						}
					}
					foreach (GStruct8 item2 in list_5)
					{
						if (item2.int_0 == item.gclass117_0.short_0 && item2.string_0 == text && item2.int_1 == item.gclass117_0.sbyte_0)
							list_5.Remove(item2);
						if ((item2.int_0 != item.gclass117_0.short_0 || item2.string_0 != text) && item2.int_1 == item.gclass117_0.sbyte_0)
						{
							GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã có loại item này!" : "Already have this item", 0);
							return;
						}
					}
					list_5.Add(new GStruct8(item.gclass117_0.short_0, text, item.gclass117_0.sbyte_0));
					GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đã thêm " + item.gclass117_0.string_0 + " vào set đồ 2 của đệ tử") : ("Added " + item.gclass117_0.string_0 + " to set 2 of disciple"), 0);
					return;
				}
				string text2 = "";
				if (item.gclass120_0 != null)
				{
					for (int j = 0; j < item.gclass120_0.Length; j++)
					{
						text2 = text2 + item.gclass120_0[j].gclass126_0.int_0 + "-";
					}
				}
				foreach (GStruct9 item3 in list_3)
				{
					if (item3.int_0 == item.gclass117_0.short_0 && item3.string_0 == text2 && item3.int_1 == item.gclass117_0.sbyte_0)
						list_3.Remove(item3);
					if ((item3.int_0 != item.gclass117_0.short_0 || item3.string_0 != text2) && item3.int_1 == item.gclass117_0.sbyte_0)
					{
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Already have this item" : "Đã có loại item này!", 0);
						return;
					}
				}
				list_3.Add(new GStruct9(item.gclass117_0.short_0, text2, item.gclass117_0.sbyte_0));
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Added " + item.gclass117_0.string_0 + " to set 2 of master") : ("Đã thêm " + item.gclass117_0.string_0 + " vào set đồ 2 của sư phụ"), 0);
				return;
			}
			if (!(type == "suphu"))
			{
				if (!(type == "detu"))
					return;
				string text3 = "";
				if (item.gclass120_0 != null)
				{
					for (int k = 0; k < item.gclass120_0.Length; k++)
					{
						text3 = text3 + item.gclass120_0[k].gclass126_0.int_0 + "-";
					}
				}
				foreach (GStruct5 item4 in list_4)
				{
					if (item4.int_0 == item.gclass117_0.short_0 && item4.string_0 == text3 && item4.int_1 == item.gclass117_0.sbyte_0)
						list_4.Remove(item4);
					if ((item4.int_0 != item.gclass117_0.short_0 || item4.string_0 == text3) && item4.int_1 == item.gclass117_0.sbyte_0)
					{
						GClass144.gclass52_0.method_7((GClass151.int_0 != 0) ? "Already have this item" : "Đã có loại item này!", 0);
						return;
					}
				}
				list_4.Add(new GStruct5(item.gclass117_0.short_0, text3, item.gclass117_0.sbyte_0));
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Added " + item.gclass117_0.string_0 + " to set 1 of disciple") : ("Đã thêm " + item.gclass117_0.string_0 + " vào set đồ 1 của đệ tử"), 0);
				return;
			}
			string text4 = "";
			if (item.gclass120_0 != null)
			{
				for (int l = 0; l < item.gclass120_0.Length; l++)
				{
					text4 = text4 + item.gclass120_0[l].gclass126_0.int_0 + "-";
				}
			}
			foreach (GStruct6 item5 in list_2)
			{
				if (item5.int_0 == item.gclass117_0.short_0 && item5.string_0 == text4 && item5.int_1 == item.gclass117_0.sbyte_0)
					list_2.Remove(item5);
				if ((item5.int_0 != item.gclass117_0.short_0 || item5.string_0 == text4) && item5.int_1 == item.gclass117_0.sbyte_0)
				{
					GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã có loại item này!" : "Already have this item", 0);
					return;
				}
			}
			list_2.Add(new GStruct6(item.gclass117_0.short_0, text4, item.gclass117_0.sbyte_0));
			GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đã thêm " + item.gclass117_0.string_0 + " vào set đồ 1 của sư phụ") : ("Added " + item.gclass117_0.string_0 + " to set 1 of master"), 0);
		}

		public void method_17(int type, sbyte get)
		{
			if (type != 1)
			{
				if (type != 2)
					return;
				sbyte b = get;
				if (b != 4)
				{
					if (b != 6)
						return;
					{
						foreach (GStruct8 item in list_5)
						{
							GClass128[] gclass128_ = GClass78.smethod_1().gclass128_0;
							try
							{
								for (int i = 0; i < gclass128_.Length; i++)
								{
									GClass128 gClass = gclass128_[i];
									string text = "";
									if (gClass == null || gClass.gclass117_0.short_0 != item.int_0)
										continue;
									if (gclass128_[i].gclass120_0 != null)
									{
										for (int j = 0; j < gclass128_[i].gclass120_0.Length; j++)
										{
											text = text + gclass128_[i].gclass120_0[j].gclass126_0.int_0 + "-";
										}
									}
									if (text == item.string_0)
									{
										GClass7.smethod_0().method_30(get, (sbyte)i);
										Thread.Sleep(100);
									}
								}
							}
							catch
							{
							}
						}
						return;
					}
				}
				{
					foreach (GStruct9 item2 in list_3)
					{
						GClass128[] gclass128_2 = GClass78.smethod_1().gclass128_0;
						try
						{
							for (int k = 0; k < gclass128_2.Length; k++)
							{
								GClass128 gClass2 = gclass128_2[k];
								string text2 = "";
								if (gClass2 == null || gClass2.gclass117_0.short_0 != item2.int_0)
									continue;
								if (gclass128_2[k].gclass120_0 != null)
								{
									for (int l = 0; l < gclass128_2[k].gclass120_0.Length; l++)
									{
										text2 = text2 + gclass128_2[k].gclass120_0[l].gclass126_0.int_0 + "-";
									}
								}
								if (text2 == item2.string_0)
								{
									if (item2.int_1 == 27)
										GClass7.smethod_0().method_20(0, 1, -1, (short)item2.int_0);
									else
										GClass7.smethod_0().method_30(get, (sbyte)k);
									Thread.Sleep(100);
								}
							}
						}
						catch
						{
						}
					}
					return;
				}
			}
			sbyte b2 = get;
			if (b2 != 4)
			{
				if (b2 != 6)
					return;
				{
					foreach (GStruct5 item3 in list_4)
					{
						GClass128[] gclass128_3 = GClass78.smethod_1().gclass128_0;
						try
						{
							for (int m = 0; m < gclass128_3.Length; m++)
							{
								GClass128 gClass3 = gclass128_3[m];
								string text3 = "";
								if (gClass3 == null || gClass3.gclass117_0.short_0 != item3.int_0)
									continue;
								if (gclass128_3[m].gclass120_0 != null)
								{
									for (int n = 0; n < gclass128_3[m].gclass120_0.Length; n++)
									{
										text3 = text3 + gclass128_3[m].gclass120_0[n].gclass126_0.int_0 + "-";
									}
								}
								if (text3 == item3.string_0)
								{
									GClass7.smethod_0().method_30(get, (sbyte)m);
									Thread.Sleep(100);
								}
							}
						}
						catch
						{
						}
					}
					return;
				}
			}
			foreach (GStruct6 item4 in list_2)
			{
				GClass128[] gclass128_4 = GClass78.smethod_1().gclass128_0;
				try
				{
					for (int num = 0; num < gclass128_4.Length; num++)
					{
						GClass128 gClass4 = gclass128_4[num];
						string text4 = "";
						if (gClass4 == null || gClass4.gclass117_0.short_0 != item4.int_0)
							continue;
						if (gclass128_4[num].gclass120_0 != null)
						{
							for (int num2 = 0; num2 < gclass128_4[num].gclass120_0.Length; num2++)
							{
								text4 = text4 + gclass128_4[num].gclass120_0[num2].gclass126_0.int_0 + "-";
							}
						}
						if (text4 == item4.string_0)
						{
							if (item4.int_1 == 27)
								GClass7.smethod_0().method_20(0, 1, -1, (short)item4.int_0);
							else
								GClass7.smethod_0().method_30(get, (sbyte)num);
							Thread.Sleep(100);
						}
					}
				}
				catch
				{
				}
			}
		}

		public void method_18(GClass128 item)
		{
			foreach (GStruct7 item2 in list_6)
			{
				if (item2.int_0 == item.gclass117_0.short_1)
				{
					list_6.Remove(item2);
					GClass149.smethod_1((GClass151.int_0 == 0) ? ("Dừng tự động sử dụng " + item.gclass117_0.string_0) : ("Stop auto using " + item.gclass117_0.string_0 + " "), 0);
				}
			}
			list_6.Add(new GStruct7(item.gclass117_0.short_1, item.gclass117_0.string_0));
			GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động dùng " + item.gclass117_0.string_0) : ("Auto use " + item.gclass117_0.string_0), 0);
		}

		public void method_19()
		{
			if (GClass73.int_8 % 5 != 0 || list_6.Count <= 0)
				return;
			for (int i = 0; i < list_6.Count; i++)
			{
				GStruct7 gStruct = list_6[i];
				if (GClass19.smethod_0(gStruct.int_0))
					continue;
				for (int j = 0; j < GClass78.smethod_1().gclass128_0.Length; j++)
				{
					GClass128 gClass = GClass78.smethod_1().gclass128_0[j];
					if (gClass != null && gClass.gclass117_0.short_1 == gStruct.int_0 && GClass203.smethod_18() - long_2 > 10000L)
					{
						GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
						long_2 = GClass203.smethod_18();
					}
				}
			}
		}

		public int method_20(int id, string type)
		{
			int num = 0;
			GClass128 gClass;
			while (true)
			{
				if (num < GClass78.smethod_1().gclass128_0.Length)
				{
					gClass = GClass78.smethod_1().gclass128_0[num];
					if (!(type == "id"))
					{
						if (type == "iconID" && gClass != null && gClass.gclass117_0.short_1 == id && id != 590 && id != 933)
							return gClass.int_30;
					}
					else
					{
						if (gClass != null && gClass.gclass117_0.short_0 == id && id != 590 && id != 933)
							break;
						if (gClass != null && gClass.gclass117_0.short_0 == id && id == 933)
						{
							string[] array = gClass.gclass120_0[0].method_0().Split(' ');
							if (gClass.gclass120_0[0].method_0().StartsWith("Quantity"))
								return int.Parse(array[1]);
							return int.Parse(array[2]);
						}
						if (gClass != null && gClass.gclass117_0.short_0 == id && id == 590)
							return int.Parse(gClass.gclass120_0[0].method_0().Split(' ')[2]);
					}
					num++;
					continue;
				}
				return 0;
			}
			return gClass.int_30;
		}

		public void method_21()
		{
			if (!bool_3 || GClass203.smethod_18() - long_3 <= 1000L)
				return;
			try
			{
				if (method_22() <= 0)
					return;
				if (GClass20.int_37 == 24 + GClass78.smethod_1().int_14 || !GClass144.smethod_8().method_16())
				{
					if (GClass20.int_37 != 24 + GClass78.smethod_1().int_14)
						return;
					for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
					{
						if (!(GClass144.gclass88_10.method_3(i) is GClass79 gClass) || gClass.gclass127_0.int_0 != 16)
							continue;
						int x = GClass78.smethod_1().int_4;
						int y = GClass78.smethod_1().int_5;
						int x2 = gClass.int_4;
						int num = gClass.int_5;
						if (GClass50.smethod_24(x, y, x2, num) <= 10)
						{
							int num2 = GClass78.smethod_1().gclass128_0.Length - 1;
							while (num2 >= 0)
							{
								GClass128 gClass2 = GClass78.smethod_1().gclass128_0[num2];
								if (gClass2 == null || !((gClass2.gclass117_0.int_2 > 0 && gClass2.gclass117_0.int_2 < 1400000 && !method_23(gClass2) && !method_24(gClass2) && (gClass2.gclass117_0.sbyte_0 == 0 || gClass2.gclass117_0.sbyte_0 == 1 || gClass2.gclass117_0.sbyte_0 == 2 || gClass2.gclass117_0.sbyte_0 == 3 || gClass2.gclass117_0.sbyte_0 == 4)) | (gClass2.gclass117_0.short_0 == 18 || gClass2.gclass117_0.short_0 == 19 || gClass2.gclass117_0.short_0 == 20)))
								{
									num2--;
									continue;
								}
								GClass7.smethod_0().method_54(0, 1, (short)num2);
								GClass171.smethod_0().method_0(1000);
								GClass7.smethod_0().method_54(1, 1, (short)num2);
								GClass171.smethod_0().method_0(1000);
								long_3 = GClass203.smethod_18();
								return;
							}
							continue;
						}
						GClass78.smethod_1().int_4 = x2;
						GClass78.smethod_1().int_5 = num - 3;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = x2;
						GClass78.smethod_1().int_5 = num;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = x2;
						GClass78.smethod_1().int_5 = num - 3;
						GClass7.smethod_0().method_44();
						break;
					}
				}
				else
					Class21.smethod_0().method_8(24 + GClass78.smethod_1().int_14);
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/AutoSellTrashItem.txt", ex.ToString());
			}
		}

		public int method_22()
		{
			int num = 0;
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass != null && ((gClass.gclass117_0.int_2 > 0 && gClass.gclass117_0.int_2 < 1400000 && !method_23(gClass) && !method_24(gClass) && (gClass.gclass117_0.sbyte_0 == 0 || gClass.gclass117_0.sbyte_0 == 1 || gClass.gclass117_0.sbyte_0 == 2 || gClass.gclass117_0.sbyte_0 == 3 || gClass.gclass117_0.sbyte_0 == 4)) | (gClass.gclass117_0.short_0 == 18 || gClass.gclass117_0.short_0 == 19 || gClass.gclass117_0.short_0 == 20)))
					num++;
			}
			return num;
		}

		public bool method_23(GClass128 item)
		{
			if (item.gclass120_0 != null)
			{
				for (int i = 0; i < item.gclass120_0.Length; i++)
				{
					if (item.gclass120_0[i].gclass126_0.string_0.StartsWith("$"))
						return true;
				}
			}
			return false;
		}

		public bool method_24(GClass128 item)
		{
			if (item.gclass120_0 != null)
			{
				for (int i = 0; i < item.gclass120_0.Length; i++)
				{
					if (item.gclass120_0[i].gclass126_0.int_0 == 107 || item.gclass120_0[i].gclass126_0.int_0 == 102)
						return true;
				}
			}
			return false;
		}

		public void method_25(string s)
		{
			if (bool_2)
			{
				if (s.ToLower().StartsWith((mResources.language != 0) ? "buy successful" : "mua thành công") || s.ToLower().StartsWith((mResources.language != 0) ? "you bought" : "bạn đã mua thành công"))
				{
					long_0 = GClass203.smethod_18();
					gclass161_0.int_1--;
				}
				if (s.ToLower().StartsWith("you don't have enough") || s.ToLower().StartsWith("not enough") || s.ToLower().StartsWith("bạn không đủ") || s.ToLower().StartsWith("not enough"))
					gclass161_0.int_1 = 0;
			}
			if (!s.ToLower().StartsWith((mResources.language == 0) ? "thể lực đã cạn" : "go relax a bit"))
				return;
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass == null || gClass.gclass117_0.short_0 != 212)
				{
					if (gClass != null && gClass.gclass117_0.short_0 == 211)
					{
						GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
						break;
					}
					continue;
				}
				GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
				break;
			}
		}

		public void method_26(GClass128 item)
		{
			if (!Directory.Exists("Data/GameData/PetData"))
				Directory.CreateDirectory("Data/GameData/PetData");
			else
				File.WriteAllText($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini", item.gclass117_0.short_0.ToString());
			int_4 = item.gclass117_0.short_0;
			bool_4 = false;
		}

		public void method_27()
		{
			if (GClass73.gclass131_0 != GClass132.gclass132_0 && !GClass78.bool_33 && !GClass12.bool_5 && !GClass78.bool_35 && GClass73.int_8 % 10 == 0)
			{
				if (int_4 < 0 && Directory.Exists("Data/GameData/PetData") && File.Exists($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini") && !string.IsNullOrEmpty(File.ReadAllText($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini")))
					int_4 = int.Parse(File.ReadAllText($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini"));
				if (!bool_4 && int_4 > 0)
				{
					GClass7.smethod_0().method_20(0, 1, -1, (short)int_4);
					bool_4 = true;
				}
			}
		}

		public int method_28()
		{
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass == null || gClass.gclass117_0.short_0 != 521 || gClass.gclass120_0 == null)
					continue;
				for (int j = 0; j < gClass.gclass120_0.Length; j++)
				{
					if (gClass.gclass120_0[j].gclass126_0.int_0 == 1)
						return int.Parse((mResources.language != 0) ? gClass.gclass120_0[j].method_0().Split(' ')[3] : gClass.gclass120_0[j].method_0().Split(' ')[4]);
				}
			}
			return -1;
		}

		public void method_29()
		{
			if (!bool_8)
				return;
			if (method_28() > 0 || GClass19.smethod_0(4387))
				bool_9 = true;
			else
			{
				if (GClass78.smethod_1().method_145() <= 0)
					return;
				bool_9 = false;
				if (GClass20.int_37 == 5)
				{
					for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
					{
						if (!(GClass144.gclass88_10.method_3(i) is GClass79 gClass))
							continue;
						if (gClass.gclass127_0.int_0 != 39 || GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 10)
						{
							if (!GClass73.gclass76_0.bool_0 || GClass73.gclass76_0 == null)
							{
								if (GClass73.gclass145_0 != null && (GClass73.gclass145_0 == null || GClass73.gclass145_0.bool_0))
								{
									if (!GClass73.gclass145_0.bool_0)
										continue;
									for (int j = 0; j < GClass73.gclass145_0.gclass88_0.method_2(); j++)
									{
										GClass87 gClass2 = (GClass87)GClass73.gclass145_0.gclass88_0.method_3(j);
										if (GClass154.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "cửahàng" : "shop") && GClass203.smethod_18() - long_7 > 1000L)
										{
											GClass7.smethod_0().method_59(39, (sbyte)j);
											GClass162.smethod_0().method_0();
											long_7 = GClass203.smethod_18();
										}
									}
									continue;
								}
								if (GClass203.smethod_18() - long_7 > 1000L)
								{
									GClass7.smethod_0().method_60(39);
									long_7 = GClass203.smethod_18();
								}
								break;
							}
							if (GClass203.smethod_18() - long_0 > 1000L)
							{
								if (GClass78.smethod_1().method_145() < 9)
								{
									GClass7.smethod_0().method_55(1, 521, 0);
									long_0 = GClass203.smethod_18();
								}
								if (GClass78.smethod_1().method_145() < 22 && GClass78.smethod_1().method_145() >= 9)
								{
									GClass7.smethod_0().method_55(1, 1523, 0);
									long_0 = GClass203.smethod_18();
								}
								if (GClass78.smethod_1().method_145() >= 22)
								{
									GClass7.smethod_0().method_55(1, 1524, 0);
									long_0 = GClass203.smethod_18();
								}
							}
							break;
						}
						if (GClass203.smethod_18() - long_7 > 500L)
						{
							GClass78.smethod_1().int_4 = gClass.int_4;
							GClass78.smethod_1().int_5 = gClass.int_5 - 3;
							GClass7.smethod_0().method_44();
							GClass78.smethod_1().int_4 = gClass.int_4;
							GClass78.smethod_1().int_5 = gClass.int_5;
							GClass7.smethod_0().method_44();
							GClass78.smethod_1().int_4 = gClass.int_4;
							GClass78.smethod_1().int_5 = gClass.int_5 - 3;
							GClass7.smethod_0().method_44();
							long_7 = GClass203.smethod_18();
						}
						break;
					}
				}
				else
					Class21.smethod_0().method_8(5);
			}
		}

		public void method_30()
		{
			if (!bool_6)
				return;
			if (method_20(764, "id") != ((GClass78.smethod_1().method_145() / 2 >= 10) ? 10 : (GClass78.smethod_1().method_145() / 2)))
			{
				if (method_20(764, "id") >= 10 || GClass78.smethod_1().method_145() < 2)
					return;
				if (method_20(764, "id") == 0)
				{
					if (GClass144.smethod_8().method_16())
						return;
					bool_7 = false;
					if (GClass20.int_37 != 5)
					{
						Class21.smethod_0().method_8(5);
						return;
					}
				}
				if (GClass20.int_37 != 5)
					return;
				for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
				{
					if (!(GClass144.gclass88_10.method_3(i) is GClass79 gClass))
						continue;
					if (gClass.gclass127_0.int_0 != 39 || GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 10)
					{
						if (!GClass73.gclass76_0.bool_0 || GClass73.gclass76_0 == null)
						{
							if (GClass73.gclass145_0 != null && (GClass73.gclass145_0 == null || GClass73.gclass145_0.bool_0))
							{
								if (!GClass73.gclass145_0.bool_0)
									continue;
								for (int j = 0; j < GClass73.gclass145_0.gclass88_0.method_2(); j++)
								{
									GClass87 gClass2 = (GClass87)GClass73.gclass145_0.gclass88_0.method_3(j);
									if (GClass154.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "shop" : "cửahàng"))
									{
										if (GClass203.smethod_18() - long_7 > 1000L)
										{
											GClass7.smethod_0().method_59(39, (sbyte)j);
											GClass162.smethod_0().method_0();
											long_7 = GClass203.smethod_18();
										}
										return;
									}
								}
								continue;
							}
							if (GClass203.smethod_18() - long_7 > 1000L)
							{
								GClass7.smethod_0().method_60(39);
								long_7 = GClass203.smethod_18();
							}
							break;
						}
						if (GClass203.smethod_18() - long_0 > 1000L)
						{
							GClass7.smethod_0().method_55(1, 764, 0);
							long_0 = GClass203.smethod_18();
						}
						break;
					}
					if (GClass203.smethod_18() - long_7 > 500L)
					{
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5 - 3;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5 - 3;
						GClass7.smethod_0().method_44();
						long_7 = GClass203.smethod_18();
					}
					break;
				}
			}
			else
				bool_7 = true;
		}

		public void method_31()
		{
			if (!bool_5 || GClass148.smethod_0().bool_0 || (list_7.Count <= 0 && list_8.Count <= 0))
				return;
			if (GClass203.smethod_18() - long_5 > 4000L)
			{
				GClass144.smethod_8().gclass146_0 = null;
				GClass73.smethod_29();
				long_5 = GClass203.smethod_18();
			}
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass == null)
					continue;
				if (list_8.Contains(gClass.gclass117_0.short_0) && gClass.gclass120_0 != null)
				{
					for (int j = 0; j < gClass.gclass120_0.Length; j++)
					{
						if (gClass.gclass120_0[j].gclass126_0.int_0 != 93)
							continue;
						if (GClass138.gclass138_0 != null && GClass203.smethod_18() - long_4 > 2000L)
						{
							for (int k = 0; k < GClass138.gclass138_0.gclass191_0.Length; k++)
							{
								GClass138.gclass138_0.gclass191_0[k].method_23("ok");
							}
							GClass7.smethod_0().method_7(GClass138.gclass138_0.gclass191_0);
							GClass144.gclass144_0.switchToMe();
							long_4 = GClass203.smethod_18();
						}
						if (GClass203.smethod_18() - long_4 > 2000L)
						{
							GClass7.smethod_0().method_20(1, 1, (sbyte)i, -1);
							GClass7.smethod_0().method_20(2, 1, (sbyte)i, -1);
							long_4 = GClass203.smethod_18();
						}
					}
				}
				if (!list_7.Contains(gClass.gclass117_0.short_0))
					continue;
				if (GClass138.gclass138_0 != null && GClass203.smethod_18() - long_4 > 2000L)
				{
					for (int l = 0; l < GClass138.gclass138_0.gclass191_0.Length; l++)
					{
						GClass138.gclass138_0.gclass191_0[l].method_23("ok");
					}
					GClass7.smethod_0().method_7(GClass138.gclass138_0.gclass191_0);
					GClass144.gclass144_0.switchToMe();
					long_4 = GClass203.smethod_18();
				}
				if (GClass203.smethod_18() - long_4 > 2000L)
				{
					GClass7.smethod_0().method_20(1, 1, (sbyte)i, -1);
					GClass7.smethod_0().method_20(2, 1, (sbyte)i, -1);
					long_4 = GClass203.smethod_18();
				}
			}
		}

		public void method_32()
		{
			if (int_5 > 0)
				method_8(int_5);
			method_31();
			method_29();
			method_5();
			method_30();
			method_27();
			method_21();
			method_19();
			method_9(gclass161_0);
			method_10(gclass161_0);
		}
	}
}
