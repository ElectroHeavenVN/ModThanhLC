using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using ns0;
using UnityEngine;

namespace ns1
{
	public class GClass42 : GInterface1, GInterface3
	{
		public struct GStruct2
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct2(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		public struct GStruct3
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct3(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		public class GClass43
		{
			public int int_0 = -1;

			public string string_0;

			public int int_1;

			public short short_0;

			public bool bool_0;

			public bool bool_1;

			public int int_2;

			public long long_0;

			public GClass43()
			{
			}

			public GClass43(int int_1, string string_0)
			{
				int_0 = int_1;
				this.string_0 = string_0;
			}

			public GClass43(int int_1, short short_0, bool bool_0, bool bool_1)
			{
				int_0 = int_1;
				this.bool_0 = bool_0;
				this.short_0 = short_0;
				this.bool_1 = bool_1;
			}
		}

		public struct GStruct4
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct4(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
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

			public GStruct6(int id, string name)
			{
				int_0 = id;
				string_0 = name;
			}
		}

		public struct GStruct7
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct7(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
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

		private static GClass42 gclass42_0;

		public static Dictionary<int, int> dictionary_0;

		public int int_0 = 0;

		public static GClass43 gclass43_0;

		private static string[] string_0;

		private static string[] string_1;

		private static string[] string_2;

		public static bool bool_0;

		public long long_0;

		public long long_1;

		public bool bool_1;

		public bool bool_2;

		public List<GStruct3> list_0 = new List<GStruct3>();

		public List<GStruct4> list_1 = new List<GStruct4>();

		public List<GStruct5> list_2 = new List<GStruct5>();

		public List<GStruct2> list_3 = new List<GStruct2>();

		public List<GStruct7> list_4 = new List<GStruct7>();

		public List<GStruct8> list_5 = new List<GStruct8>();

		public int int_1;

		public string string_3;

		public List<GStruct6> list_6 = new List<GStruct6>();

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

		public List<int> list_7 = new List<int> { 17, 18, 19, 20, 225, 211, 212, 226, 1526, 1505 };

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

		static GClass42()
		{
			dictionary_0 = new Dictionary<int, int>();
			string_0 = new string[2] { "Nhập số lượng bán", "số lượng" };
			string_1 = new string[2] { "Nhập số lượng mua", "số lượng" };
			string_2 = ((GClass62.int_0 == 0) ? new string[2] { "Nhập độ trễ sử dụng", "độ trễ (ms)" } : new string[2] { "Put time delay use", "time delay (ms)" });
		}

		public static GClass42 smethod_0()
		{
			return (gclass42_0 != null) ? gclass42_0 : (gclass42_0 = new GClass42());
		}

		public bool method_0(int asciiCode)
		{
			if (asciiCode != 100)
			{
				if (asciiCode != 115)
					return false;
				GClass122 gClass = new GClass122();
				gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Wear Set1\n[Master]" : "Mặc Set 1\n[Sư phụ]", smethod_0(), 11821, null));
				gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Mặc Set 2\n[Sư phụ]" : "Wear Set2\n[Master]", smethod_0(), 11822, null));
				GClass14.gclass116_0.bool_1 = true;
				GClass14.gclass116_0.method_2(gClass, 0);
			}
			else
			{
				GClass122 gClass2 = new GClass122();
				gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? "Mặc Set 1\n[Đệ tử]" : "Wear Set1\n[Disciple]", smethod_0(), 11823, null));
				gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "Wear Set2\n[Disciple]" : "Mặc Set 2\n[Đệ tử]", smethod_0(), 11824, null));
				GClass14.gclass116_0.bool_1 = true;
				GClass14.gclass116_0.method_2(gClass2, 0);
			}
			return true;
		}

		public bool method_1(string text)
		{
			switch (text)
			{
			case "/getitem":
				smethod_1();
				return true;
			case "/isell":
				bool_3 = !bool_3;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto sell trash item: " + GClass45.smethod_0().method_6(bool_3)) : ("Tự động bán đồ rác: " + GClass45.smethod_0().method_6(bool_3)), 0);
				return true;
			case "/dropitem":
				bool_5 = !bool_5;
				GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động vứt đồ rác: " + GClass45.smethod_0().method_6(bool_5)) : ("Auto drop trash: " + GClass45.smethod_0().method_6(bool_5)), 0);
				return true;
			case "/clrlistdrop":
				list_8.Clear();
				list_7.Clear();
				GClass51.smethod_1((GClass62.int_0 != 0) ? "Cleared list item ID drop!" : "Đã xóa danh sách ID item vứt!", 0);
				return true;
			case "/autobuytdlt":
				bool_8 = !bool_8;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto buy AutoTrain: " + GClass45.smethod_0().method_6(bool_8)) : ("Tự động mua TĐLT: " + GClass45.smethod_0().method_6(bool_8)), 0);
				return true;
			case "/autobuykt":
				bool_6 = !bool_6;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto buy mask: " + GClass45.smethod_0().method_6(bool_6)) : ("Tự động mua khẩu trang: " + GClass45.smethod_0().method_6(bool_6)), 0);
				return true;
			}
			if (GClass45.smethod_0().method_11<string>(text, "/additemdrop") && !GClass45.smethod_0().method_12<string>(text, "/additemdrop").Contains("hsd"))
			{
				if (!GClass45.smethod_0().method_12<string>(text, "/additemdrop").Contains(","))
				{
					int num = GClass45.smethod_0().method_12<int>(text, "/additemdrop");
					if (list_7.Contains(num))
					{
						list_7.Remove(num);
						GClass51.smethod_1((GClass62.int_0 != 0) ? $"Removed {GClass17.smethod_1((short)num).string_0} [{num}] from list item drop!" : $"Xóa {GClass17.smethod_1((short)num).string_0} [{num}] khỏi d/s item vứt!", 0);
					}
					else
					{
						list_7.Add(num);
						GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added {GClass17.smethod_1((short)num).string_0} [{num}] to list item drop!" : $"Thêm {GClass17.smethod_1((short)num).string_0} [{num}] vào d/s item vứt!", 0);
					}
					return true;
				}
				int[] array = GClass45.smethod_0().method_9<int>(text, "/additemdrop", ',');
				for (int i = 0; i < array.Length; i++)
				{
					if (list_7.Contains(array[i]))
					{
						list_7.Remove(array[i]);
						GClass51.smethod_1((GClass62.int_0 != 0) ? $"Removed {GClass17.smethod_1((short)array[i]).string_0} [{array[i]}] from list item drop!" : $"Xóa {GClass17.smethod_1((short)array[i]).string_0} [{array[i]}] khỏi d/s item vứt!", 0);
					}
					else
					{
						list_7.Add(array[i]);
						GClass51.smethod_1((GClass62.int_0 == 0) ? $"Thêm {GClass17.smethod_1((short)array[i]).string_0} [{array[i]}] vào d/s item vứt!" : $"Added {GClass17.smethod_1((short)array[i]).string_0} [{array[i]}] to list item drop!", 0);
					}
				}
			}
			else if (GClass45.smethod_0().method_10<int>(text, "/citem", 2))
			{
				int[] array2 = GClass45.smethod_0().method_8<int>(text, "/citem", 2);
				if (array2[0] > 0)
					method_2(array2[0], array2[1]);
			}
			else if (GClass45.smethod_0().method_11<string>(text, "/additemdrophsd"))
			{
				if (GClass45.smethod_0().method_12<string>(text, "/additemdrophsd").Contains(","))
				{
					int[] array3 = GClass45.smethod_0().method_9<int>(text, "/additemdrophsd", ',');
					for (int j = 0; j < array3.Length; j++)
					{
						if (!list_8.Contains(array3[j]))
						{
							list_8.Add(array3[j]);
							GClass51.smethod_1((GClass62.int_0 == 0) ? $"Thêm {GClass17.smethod_1((short)array3[j]).string_0} [{array3[j]}] vào d/s item vứt theo HSD!" : $"Added {GClass17.smethod_1((short)array3[j]).string_0} [{array3[j]}] to list item drop by Expr!", 0);
						}
						else
						{
							list_8.Remove(array3[j]);
							GClass51.smethod_1((GClass62.int_0 == 0) ? $"Xóa {GClass17.smethod_1((short)array3[j]).string_0} [{array3[j]}] khỏi d/s item vứt theo HSD!" : $"Removed {GClass17.smethod_1((short)array3[j]).string_0} [{array3[j]}] from list item drop by Expr!", 0);
						}
					}
				}
				else
				{
					int num2 = GClass45.smethod_0().method_12<int>(text, "/additemdrophsd");
					if (list_8.Contains(num2))
					{
						list_8.Remove(num2);
						GClass51.smethod_1((GClass62.int_0 != 0) ? $"Removed {GClass17.smethod_1((short)num2).string_0} [{num2}] from list item dropby Expr!" : $"Xóa {GClass17.smethod_1((short)num2).string_0} [{num2}] khỏi d/s item vứttheo HSD!", 0);
					}
					else
					{
						list_8.Add(num2);
						GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added {GClass17.smethod_1((short)num2).string_0} [{num2}] to list item drop by Expr!" : $"Thêm {GClass17.smethod_1((short)num2).string_0} [{num2}] vào d/s item vứt theo HSD!", 0);
					}
				}
			}
			else
				return false;
			return true;
        }

		public void method_2(int itemID, int quantity)
		{
			if (quantity <= 0)
				dictionary_0.Remove(itemID);
			else if (!dictionary_0.ContainsKey(itemID))
			{
				dictionary_0.Add(itemID, method_20(itemID, "id") + quantity);
			}
			else
			{
				dictionary_0[itemID] = method_20(itemID, "id") + quantity;
			}
		}

		public void method_3(GClass193 g)
		{
			if (dictionary_0.Count <= 0)
				return;
			foreach (KeyValuePair<int, int> item in dictionary_0)
			{
				GClass45.smethod_0().method_1(GClass104.gclass104_3, g, (GClass62.int_0 != 0) ? string.Format("Pick up {0} [{1}]: {2}/{3}", GClass17.smethod_1((short)item.Key).string_0, item.Key, method_20(item.Key, "id"), item.Value) : string.Format("Nhặt {0} [{1}]: {2}/{3}", GClass17.smethod_1((short)item.Key).string_0, item.Key, method_20(item.Key, "id"), item.Value), GClass14.int_10 / 2, int_0, GClass104.int_2, GClass104.gclass104_6);
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
			string text = string.Empty;
			for (int i = 0; i < 2000; i++)
			{
				if (GClass17.smethod_1((short)i) != null)
					text = text + $"{GClass17.smethod_1((short)i).short_0}.{GClass17.smethod_1((short)i).string_0} - {GClass17.smethod_1((short)i).string_2} - {GClass17.smethod_1((short)i).sbyte_0} - {GClass17.smethod_1((short)i).short_1}" + "\n";
			}
			File.WriteAllText("Danh sách item.txt", text);
		}

		public void perform(int idAction, object p)
		{
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
				method_7((GClass43)p);
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass107.smethod_0().gclass136_0.method_21() != null && !GClass107.smethod_0().gclass136_0.method_21().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
			{
				if (!GClass107.smethod_0().string_1.Equals(string_1[0]))
				{
					if (GClass107.smethod_0().string_1.Equals(string_0[0]))
					{
						try
						{
							int num = int.Parse(GClass107.smethod_0().gclass136_0.method_21());
							gclass43_0.int_1 = num;
							bool_1 = true;
						}
						catch
						{
							GClass167.gclass130_0.method_7("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
						}
						method_6();
					}
				}
				else
				{
					try
					{
						int num2 = int.Parse(GClass107.smethod_0().gclass136_0.method_21());
						gclass43_0.int_1 = num2;
						bool_2 = true;
					}
					catch
					{
						GClass167.gclass130_0.method_7("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
					}
					method_6();
				}
			}
			else
				GClass107.smethod_0().bool_0 = false;
		}

		public void onCancelChat()
		{
		}

		private void method_6()
		{
			GClass107.smethod_0().string_1 = "Chat";
			GClass107.smethod_0().gclass136_0.string_7 = "chat";
			GClass107.smethod_0().bool_0 = false;
		}

		private void method_7(GClass43 gclass43_1)
		{
			gclass43_0 = gclass43_1;
			GClass14.gclass113_0.bool_0 = false;
			if (!gclass43_1.bool_1)
			{
				GClass107.smethod_0().string_1 = string_1[0];
				GClass107.smethod_0().gclass136_0.string_7 = string_1[1];
			}
			else
			{
				GClass107.smethod_0().string_1 = string_0[0];
				GClass107.smethod_0().gclass136_0.string_7 = string_0[1];
			}
			GClass107.smethod_0().method_5(smethod_0(), string.Empty);
		}

		public void method_8(int itemID)
		{
			if (itemID <= 0 || !bool_10 || GClass167.smethod_8().method_16())
				return;
			if (method_20(itemID, "id") == 0)
			{
				bool_10 = false;
				int_5 = -1;
				long_9 = -1L;
			}
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass != null && gClass.gclass203_0.short_0 == itemID && gClass.int_30 > 0 && long_9 != -1L && GClass77.smethod_18() - long_8 > long_9)
				{
					GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
					long_8 = GClass77.smethod_18();
				}
			}
		}

		public void method_9(GClass43 item)
		{
			if (!bool_1 || item == null)
				return;
			short short_ = item.short_0;
			if (item.int_1 == 0)
				bool_1 = false;
			if (item.int_1 <= 0)
				return;
			bool flag = false;
			if (GClass124.smethod_1().gclass0_0[short_] != null && (GClass124.smethod_1().gclass0_0[short_] == null || GClass124.smethod_1().gclass0_0[short_].gclass203_0.short_0 == (short)item.int_0))
			{
				if (!flag && GClass77.smethod_18() - long_1 > 100L)
				{
					GClass2.smethod_0().method_54(0, 1, short_);
					flag = true;
					long_1 = GClass77.smethod_18();
				}
				if (flag && GClass77.smethod_18() - long_1 > 1000L)
				{
					GClass2.smethod_0().method_54(1, 1, short_);
					long_1 = GClass77.smethod_18();
					item.int_1--;
					flag = false;
				}
				if (GClass124.smethod_1().long_6 > 1963100000L)
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

		public void method_10(GClass43 item)
		{
			if (bool_2 && item != null)
			{
				if (item.int_1 == 0 || item.int_0 < 0)
					bool_2 = false;
				if (GClass167.smethod_8().method_16())
				{
					bool_2 = false;
					item.int_1 = 0;
				}
				if (item.int_1 > 0 && !GClass167.smethod_8().method_16() && GClass77.smethod_18() - long_0 > 1000L && long_0 != -1L)
				{
					GClass2.smethod_0().method_55((!item.bool_0) ? ((sbyte)1) : ((sbyte)0), item.int_0, 0);
					long_0 = -1L;
				}
			}
		}

		public void method_11()
		{
			string text = string.Empty;
			if (GClass124.smethod_1().gclass0_2[6] == null)
				return;
			if (GClass124.smethod_1().gclass0_2[6].gclass5_0 != null)
			{
				for (int i = 0; i < GClass124.smethod_1().gclass0_2[6].gclass5_0.Length; i++)
				{
					text = text + GClass124.smethod_1().gclass0_2[6].gclass5_0[i].gclass151_0.int_0 + "-";
				}
			}
			if (!list_0.Contains(new GStruct3(GClass124.smethod_1().gclass0_2[6].gclass203_0.short_0, text, GClass124.smethod_1().gclass0_2[6].gclass203_0.sbyte_0)))
				list_0.Add(new GStruct3(GClass124.smethod_1().gclass0_2[6].gclass203_0.short_0, text, GClass124.smethod_1().gclass0_2[6].gclass203_0.sbyte_0));
			if (list_0.Contains(new GStruct3(GClass124.smethod_1().gclass0_2[6].gclass203_0.short_0, text, GClass124.smethod_1().gclass0_2[6].gclass203_0.sbyte_0)))
				GClass2.smethod_0().method_30(5, 6);
		}

		public void method_12()
		{
			foreach (GStruct3 item in list_0)
			{
				GClass0[] gclass0_ = GClass124.smethod_1().gclass0_0;
				try
				{
					for (int i = 0; i < gclass0_.Length; i++)
					{
						GClass0 gClass = gclass0_[i];
						string text = string.Empty;
						if (gClass == null || gClass.gclass203_0.short_0 != item.int_0)
							continue;
						if (gClass.gclass5_0 != null)
						{
							for (int j = 0; j < gClass.gclass5_0.Length; j++)
							{
								text = text + gClass.gclass5_0[j].gclass151_0.int_0 + "-";
							}
						}
						if (text == item.string_0)
						{
							GClass2.smethod_0().method_30(4, (sbyte)i);
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
			if (GClass124.smethod_1().gclass0_2[5] == null)
			{
				for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
				{
					GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
					if (gClass == null)
						continue;
					for (int j = 0; j < gClass.gclass5_0.Length; j++)
					{
						if (gClass.gclass5_0[j].gclass151_0.int_0 == 106 && GClass124.smethod_1().long_2 >= gClass.gclass203_0.int_2)
							GClass2.smethod_0().method_30(4, (sbyte)i);
					}
				}
				return;
			}
			string text = string.Empty;
			if (GClass124.smethod_1().gclass0_2[5].gclass5_0 != null)
			{
				for (int k = 0; k < GClass124.smethod_1().gclass0_2[5].gclass5_0.Length; k++)
				{
					if (!text.Contains(GClass124.smethod_1().gclass0_2[5].gclass5_0[k].gclass151_0.int_0 + "-"))
						text = text + GClass124.smethod_1().gclass0_2[5].gclass5_0[k].gclass151_0.int_0 + "-";
				}
			}
			if (!list_1.Contains(new GStruct4(GClass124.smethod_1().gclass0_2[5].gclass203_0.short_0, text, GClass124.smethod_1().gclass0_2[5].gclass203_0.sbyte_0)) && !text.Contains("106"))
				list_1.Add(new GStruct4(GClass124.smethod_1().gclass0_2[5].gclass203_0.short_0, text, GClass124.smethod_1().gclass0_2[5].gclass203_0.sbyte_0));
			if (!list_1.Contains(new GStruct4(GClass124.smethod_1().gclass0_2[5].gclass203_0.short_0, text, GClass124.smethod_1().gclass0_2[5].gclass203_0.sbyte_0)))
				return;
			for (int l = 0; l < GClass124.smethod_1().gclass0_0.Length; l++)
			{
				GClass0 gClass2 = GClass124.smethod_1().gclass0_0[l];
				if (gClass2 == null)
					continue;
				for (int m = 0; m < gClass2.gclass5_0.Length; m++)
				{
					if (gClass2.gclass5_0[m].gclass151_0.int_0 == 106 && GClass124.smethod_1().long_2 >= gClass2.gclass203_0.int_2)
						GClass2.smethod_0().method_30(4, (sbyte)l);
				}
			}
		}

		public void method_14()
		{
			try
			{
				foreach (GStruct4 item in list_1)
				{
					GClass0[] gclass0_ = GClass124.smethod_1().gclass0_0;
					try
					{
						for (int i = 0; i < gclass0_.Length; i++)
						{
							if (gclass0_[i] == null || gclass0_[i].gclass203_0.short_0 != item.int_0)
								continue;
							string text = string.Empty;
							if (gclass0_[i].gclass5_0 != null)
							{
								for (int j = 0; j < gclass0_[i].gclass5_0.Length; j++)
								{
									text = text + gclass0_[i].gclass5_0[j].gclass151_0.int_0 + "-";
								}
							}
							if (text == item.string_0)
							{
								GClass2.smethod_0().method_30(4, (sbyte)i);
								Thread.Sleep(100);
								return;
							}
						}
					}
					catch
					{
					}
				}
				if (GClass124.smethod_1().gclass0_2[5] == null || GClass124.smethod_1().gclass0_2[5].gclass5_0 == null)
					return;
				for (int k = 0; k < GClass124.smethod_1().gclass0_2[5].gclass5_0.Length; k++)
				{
					if (GClass124.smethod_1().gclass0_2[5].gclass5_0[k].gclass151_0.int_0 == 106)
						GClass2.smethod_0().method_30(5, 5);
				}
			}
			catch
			{
			}
		}

		public void method_15()
		{
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass != null && gClass.gclass203_0.short_0 >= 663 && gClass.gclass203_0.short_0 <= 667)
					GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
			}
		}

		public void method_16(GClass0 item, int ListIndex, string type)
		{
			if (ListIndex != 1)
			{
				if (ListIndex != 2)
					return;
				if (!(type == "suphu"))
				{
					if (!(type == "detu"))
						return;
					string text = string.Empty;
					if (item.gclass5_0 != null)
					{
						for (int i = 0; i < item.gclass5_0.Length; i++)
						{
							text = text + item.gclass5_0[i].gclass151_0.int_0 + "-";
						}
					}
					foreach (GStruct8 item2 in list_5)
					{
						if (item2.int_0 == item.gclass203_0.short_0 && item2.string_0 == text && item2.int_1 == item.gclass203_0.sbyte_0)
							list_5.Remove(item2);
						if ((item2.int_0 != item.gclass203_0.short_0 || item2.string_0 != text) && item2.int_1 == item.gclass203_0.sbyte_0)
						{
							GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã có loại item này!" : "Already have this item", 0);
							return;
						}
					}
					list_5.Add(new GStruct8(item.gclass203_0.short_0, text, item.gclass203_0.sbyte_0));
					GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added " + item.gclass203_0.string_0 + " to set 2 of disciple") : ("Đã thêm " + item.gclass203_0.string_0 + " vào set đồ 2 của đệ tử"), 0);
					return;
				}
				string text2 = string.Empty;
				if (item.gclass5_0 != null)
				{
					for (int j = 0; j < item.gclass5_0.Length; j++)
					{
						text2 = text2 + item.gclass5_0[j].gclass151_0.int_0 + "-";
					}
				}
				foreach (GStruct2 item3 in list_3)
				{
					if (item3.int_0 == item.gclass203_0.short_0 && item3.string_0 == text2 && item3.int_1 == item.gclass203_0.sbyte_0)
						list_3.Remove(item3);
					if ((item3.int_0 != item.gclass203_0.short_0 || item3.string_0 != text2) && item3.int_1 == item.gclass203_0.sbyte_0)
					{
						GClass51.smethod_1((GClass62.int_0 != 0) ? "Already have this item" : "Đã có loại item này!", 0);
						return;
					}
				}
				list_3.Add(new GStruct2(item.gclass203_0.short_0, text2, item.gclass203_0.sbyte_0));
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added " + item.gclass203_0.string_0 + " to set 2 of master") : ("Đã thêm " + item.gclass203_0.string_0 + " vào set đồ 2 của sư phụ"), 0);
			}
			else if (type == "suphu")
			{
				string text3 = string.Empty;
				if (item.gclass5_0 != null)
				{
					for (int k = 0; k < item.gclass5_0.Length; k++)
					{
						text3 = text3 + item.gclass5_0[k].gclass151_0.int_0 + "-";
					}
				}
				foreach (GStruct5 item4 in list_2)
				{
					if (item4.int_0 == item.gclass203_0.short_0 && item4.string_0 == text3 && item4.int_1 == item.gclass203_0.sbyte_0)
						list_2.Remove(item4);
					if ((item4.int_0 != item.gclass203_0.short_0 || item4.string_0 == text3) && item4.int_1 == item.gclass203_0.sbyte_0)
					{
						GClass51.smethod_1((GClass62.int_0 != 0) ? "Already have this item" : "Đã có loại item này!", 0);
						return;
					}
				}
				list_2.Add(new GStruct5(item.gclass203_0.short_0, text3, item.gclass203_0.sbyte_0));
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added " + item.gclass203_0.string_0 + " to set 1 of master") : ("Đã thêm " + item.gclass203_0.string_0 + " vào set đồ 1 của sư phụ"), 0);
			}
			else
			{
				if (!(type == "detu"))
					return;
				string text4 = string.Empty;
				if (item.gclass5_0 != null)
				{
					for (int l = 0; l < item.gclass5_0.Length; l++)
					{
						text4 = text4 + item.gclass5_0[l].gclass151_0.int_0 + "-";
					}
				}
				foreach (GStruct7 item5 in list_4)
				{
					if (item5.int_0 == item.gclass203_0.short_0 && item5.string_0 == text4 && item5.int_1 == item.gclass203_0.sbyte_0)
						list_4.Remove(item5);
					if ((item5.int_0 != item.gclass203_0.short_0 || item5.string_0 == text4) && item5.int_1 == item.gclass203_0.sbyte_0)
					{
						GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? "Already have this item" : "Đã có loại item này!", 0);
						return;
					}
				}
				list_4.Add(new GStruct7(item.gclass203_0.short_0, text4, item.gclass203_0.sbyte_0));
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added " + item.gclass203_0.string_0 + " to set 1 of disciple") : ("Đã thêm " + item.gclass203_0.string_0 + " vào set đồ 1 của đệ tử"), 0);
			}
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
							GClass0[] gclass0_ = GClass124.smethod_1().gclass0_0;
							try
							{
								for (int i = 0; i < gclass0_.Length; i++)
								{
									GClass0 gClass = gclass0_[i];
									string text = string.Empty;
									if (gClass == null || gClass.gclass203_0.short_0 != item.int_0)
										continue;
									if (gclass0_[i].gclass5_0 != null)
									{
										for (int j = 0; j < gclass0_[i].gclass5_0.Length; j++)
										{
											text = text + gclass0_[i].gclass5_0[j].gclass151_0.int_0 + "-";
										}
									}
									if (text == item.string_0)
									{
										GClass2.smethod_0().method_30(get, (sbyte)i);
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
					foreach (GStruct2 item2 in list_3)
					{
						GClass0[] gclass0_2 = GClass124.smethod_1().gclass0_0;
						try
						{
							for (int k = 0; k < gclass0_2.Length; k++)
							{
								GClass0 gClass2 = gclass0_2[k];
								string text2 = string.Empty;
								if (gClass2 == null || gClass2.gclass203_0.short_0 != item2.int_0)
									continue;
								if (gclass0_2[k].gclass5_0 != null)
								{
									for (int l = 0; l < gclass0_2[k].gclass5_0.Length; l++)
									{
										text2 = text2 + gclass0_2[k].gclass5_0[l].gclass151_0.int_0 + "-";
									}
								}
								if (text2 == item2.string_0)
								{
									if (item2.int_1 != 27)
										GClass2.smethod_0().method_30(get, (sbyte)k);
									else
										GClass2.smethod_0().method_20(0, 1, -1, (short)item2.int_0);
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
					foreach (GStruct7 item3 in list_4)
					{
						GClass0[] gclass0_3 = GClass124.smethod_1().gclass0_0;
						try
						{
							for (int m = 0; m < gclass0_3.Length; m++)
							{
								GClass0 gClass3 = gclass0_3[m];
								string text3 = string.Empty;
								if (gClass3 == null || gClass3.gclass203_0.short_0 != item3.int_0)
									continue;
								if (gclass0_3[m].gclass5_0 != null)
								{
									for (int n = 0; n < gclass0_3[m].gclass5_0.Length; n++)
									{
										text3 = text3 + gclass0_3[m].gclass5_0[n].gclass151_0.int_0 + "-";
									}
								}
								if (text3 == item3.string_0)
								{
									GClass2.smethod_0().method_30(get, (sbyte)m);
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
			foreach (GStruct5 item4 in list_2)
			{
				GClass0[] gclass0_4 = GClass124.smethod_1().gclass0_0;
				try
				{
					for (int num = 0; num < gclass0_4.Length; num++)
					{
						GClass0 gClass4 = gclass0_4[num];
						string text4 = string.Empty;
						if (gClass4 == null || gClass4.gclass203_0.short_0 != item4.int_0)
							continue;
						if (gclass0_4[num].gclass5_0 != null)
						{
							for (int num2 = 0; num2 < gclass0_4[num].gclass5_0.Length; num2++)
							{
								text4 = text4 + gclass0_4[num].gclass5_0[num2].gclass151_0.int_0 + "-";
							}
						}
						if (text4 == item4.string_0)
						{
							if (item4.int_1 != 27)
								GClass2.smethod_0().method_30(get, (sbyte)num);
							else
								GClass2.smethod_0().method_20(0, 1, -1, (short)item4.int_0);
							Thread.Sleep(100);
						}
					}
				}
				catch
				{
				}
			}
		}

		public void method_18(GClass0 item)
		{
			foreach (GStruct6 item2 in list_6)
			{
				if (item2.int_0 == item.gclass203_0.short_1)
				{
					list_6.Remove(item2);
					GClass51.smethod_1((GClass62.int_0 != 0) ? ("Stop auto using " + item.gclass203_0.string_0 + " ") : ("Dừng tự động sử dụng " + item.gclass203_0.string_0), 0);
				}
			}
			list_6.Add(new GStruct6(item.gclass203_0.short_1, item.gclass203_0.string_0));
			GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto use " + item.gclass203_0.string_0) : ("Tự động dùng " + item.gclass203_0.string_0), 0);
		}

		public void method_19()
		{
			if (GClass14.int_8 % 5 != 0 || list_6.Count <= 0)
				return;
			for (int i = 0; i < list_6.Count; i++)
			{
				GStruct6 gStruct = list_6[i];
				if (GClass82.smethod_0(gStruct.int_0))
					continue;
				for (int j = 0; j < GClass124.smethod_1().gclass0_0.Length; j++)
				{
					GClass0 gClass = GClass124.smethod_1().gclass0_0[j];
					if (gClass != null && gClass.gclass203_0.short_1 == gStruct.int_0 && GClass77.smethod_18() - long_2 > 10000L)
					{
						GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
						long_2 = GClass77.smethod_18();
					}
				}
			}
		}

		public int method_20(int id, string type)
		{
			int num = 0;
			GClass0 gClass;
			while (true)
			{
				if (num < GClass124.smethod_1().gclass0_0.Length)
				{
					gClass = GClass124.smethod_1().gclass0_0[num];
					if (!(type == "id"))
					{
						if (type == "iconID" && gClass != null && gClass.gclass203_0.short_1 == id && id != 590 && id != 933)
							return gClass.int_30;
					}
					else
					{
						if (gClass != null && gClass.gclass203_0.short_0 == id && id != 590 && id != 933)
							break;
						if (gClass != null && gClass.gclass203_0.short_0 == id && id == 933)
						{
							string[] array = gClass.gclass5_0[0].method_0().Split(' ');
							if (gClass.gclass5_0[0].method_0().StartsWith("Quantity"))
								return int.Parse(array[1]);
							return int.Parse(array[2]);
						}
						if (gClass != null && gClass.gclass203_0.short_0 == id && id == 590)
							return int.Parse(gClass.gclass5_0[0].method_0().Split(' ')[2]);
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
			if (!bool_3 || GClass77.smethod_18() - long_3 <= 1000L)
				return;
			try
			{
				if (method_22() <= 0)
					return;
				if (GClass137.int_37 == 24 + GClass124.smethod_1().int_14 || !GClass167.smethod_8().method_16())
				{
					if (GClass137.int_37 != 24 + GClass124.smethod_1().int_14)
						return;
					for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
					{
						GClass125 gClass = GClass167.gclass122_10.method_3(i) as GClass125;
						int x = GClass124.smethod_1().int_4;
						int y = GClass124.smethod_1().int_5;
						if (gClass == null || gClass.gclass120_0.int_0 != 16)
							continue;
						int x2 = gClass.int_4;
						int num = gClass.int_5;
						if (GClass191.smethod_24(x, y, x2, num) <= 10)
						{
							for (int num2 = GClass124.smethod_1().gclass0_0.Length - 1; num2 >= 0; num2--)
							{
								GClass0 gClass2 = GClass124.smethod_1().gclass0_0[num2];
								if (gClass2 != null)
								{
									bool flag = gClass2.gclass203_0.int_2 > 0 && gClass2.gclass203_0.int_2 < 1400000 && !method_23(gClass2) && !method_24(gClass2) && (gClass2.gclass203_0.sbyte_0 == 0 || gClass2.gclass203_0.sbyte_0 == 1 || gClass2.gclass203_0.sbyte_0 == 2 || gClass2.gclass203_0.sbyte_0 == 3 || gClass2.gclass203_0.sbyte_0 == 4);
									bool flag2 = gClass2.gclass203_0.short_0 == 18 || gClass2.gclass203_0.short_0 == 19 || gClass2.gclass203_0.short_0 == 20;
									bool flag3 = gClass2.gclass203_0.short_0 == 225;
									bool flag4 = gClass2.gclass203_0.sbyte_0 == 33 && gClass2.gclass203_0.short_0 != 956 && gClass2.gclass203_0.short_0 != 1204;
									bool flag5 = gClass2.gclass203_0.short_0 >= 441 && gClass2.gclass203_0.short_0 <= 447;
									bool flag6 = gClass2.gclass203_0.short_0 == 226;
									if (flag || flag2 || flag3)
									{
										GClass2.smethod_0().method_54(0, 1, (short)num2);
										GClass49.smethod_0().method_0(1000);
										GClass2.smethod_0().method_54(1, 1, (short)num2);
										GClass49.smethod_0().method_0(1000);
										long_3 = GClass77.smethod_18();
										return;
									}
									if (flag4)
									{
										GClass2.smethod_0().method_20(0, 1, -1, gClass2.gclass203_0.short_0);
										long_3 = GClass77.smethod_18();
										return;
									}
									if (flag5 || flag6)
									{
										GClass2.smethod_0().method_20(1, 1, (sbyte)num2, -1);
										GClass49.smethod_0().method_0(1000);
										GClass2.smethod_0().method_20(2, 1, (sbyte)num2, -1);
										GClass49.smethod_0().method_0(1000);
										long_3 = GClass77.smethod_18();
									}
								}
							}
							continue;
						}
						GClass124.smethod_1().int_4 = x2;
						GClass124.smethod_1().int_5 = num - 3;
						GClass2.smethod_0().method_44();
						GClass124.smethod_1().int_4 = x2;
						GClass124.smethod_1().int_5 = num;
						GClass2.smethod_0().method_44();
						GClass124.smethod_1().int_4 = x2;
						GClass124.smethod_1().int_5 = num - 3;
						GClass2.smethod_0().method_44();
						break;
					}
				}
				else
					Class11.smethod_0().method_8(24 + GClass124.smethod_1().int_14);
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/AutoSellTrashItem.txt", ex.ToString());
			}
		}

		public int method_22()
		{
			int num = 0;
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass != null && ((gClass.gclass203_0.int_2 > 0 && gClass.gclass203_0.int_2 < 1400000 && !method_23(gClass) && !method_24(gClass) && (gClass.gclass203_0.sbyte_0 == 0 || gClass.gclass203_0.sbyte_0 == 1 || gClass.gclass203_0.sbyte_0 == 2 || gClass.gclass203_0.sbyte_0 == 3 || gClass.gclass203_0.sbyte_0 == 4)) | (gClass.gclass203_0.short_0 == 18 || gClass.gclass203_0.short_0 == 19 || gClass.gclass203_0.short_0 == 20) | (gClass.gclass203_0.short_0 == 225) | (gClass.gclass203_0.sbyte_0 == 33 && gClass.gclass203_0.short_0 != 956 && gClass.gclass203_0.short_0 != 1204) | (gClass.gclass203_0.short_0 >= 441 && gClass.gclass203_0.short_0 <= 447)))
					num++;
			}
			return num;
		}

		public bool method_23(GClass0 item)
		{
			if (item.gclass5_0 != null)
			{
				for (int i = 0; i < item.gclass5_0.Length; i++)
				{
					if (item.gclass5_0[i].gclass151_0.string_0.StartsWith("$"))
						return true;
				}
			}
			return false;
		}

		public bool method_24(GClass0 item)
		{
			if (item.gclass5_0 != null)
			{
				for (int i = 0; i < item.gclass5_0.Length; i++)
				{
					if (item.gclass5_0[i].gclass151_0.int_0 == 107 || item.gclass5_0[i].gclass151_0.int_0 == 102)
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
					long_0 = GClass77.smethod_18();
					gclass43_0.int_1--;
				}
				if (s.ToLower().StartsWith("you don't have enough") || s.ToLower().StartsWith("not enough") || s.ToLower().StartsWith("bạn không đủ") || s.ToLower().StartsWith("not enough"))
					gclass43_0.int_1 = 0;
			}
			if (!s.ToLower().StartsWith((mResources.language != 0) ? "go relax a bit" : "thể lực đã cạn"))
				return;
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass == null || gClass.gclass203_0.short_0 != 212)
				{
					if (gClass != null && gClass.gclass203_0.short_0 == 211)
					{
						GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
						break;
					}
					continue;
				}
				GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
				break;
			}
		}

		public void method_26(GClass0 item)
		{
			if (Directory.Exists("Data/GameData/PetData"))
				File.WriteAllText($"Data/GameData/PetData/{GClass124.smethod_1().int_13}.ini", item.gclass203_0.short_0.ToString());
			else
				Directory.CreateDirectory("Data/GameData/PetData");
			int_4 = item.gclass203_0.short_0;
			bool_4 = false;
		}

		public void method_27()
		{
			if (GClass14.gclass160_0 != GClass171.gclass171_0 && !GClass124.bool_33 && !GClass93.bool_5 && !GClass124.bool_35 && GClass14.int_8 % 10 == 0)
			{
				if (int_4 < 0 && Directory.Exists("Data/GameData/PetData") && File.Exists($"Data/GameData/PetData/{GClass124.smethod_1().int_13}.ini") && !string.IsNullOrEmpty(File.ReadAllText($"Data/GameData/PetData/{GClass124.smethod_1().int_13}.ini")))
					int_4 = int.Parse(File.ReadAllText($"Data/GameData/PetData/{GClass124.smethod_1().int_13}.ini"));
				if (!bool_4 && int_4 > 0)
				{
					GClass2.smethod_0().method_20(0, 1, -1, (short)int_4);
					bool_4 = true;
				}
			}
		}

		public int method_28()
		{
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass == null || gClass.gclass203_0.short_0 != 521 || gClass.gclass5_0 == null)
					continue;
				for (int j = 0; j < gClass.gclass5_0.Length; j++)
				{
					if (gClass.gclass5_0[j].gclass151_0.int_0 == 1)
						return int.Parse((mResources.language == 0) ? gClass.gclass5_0[j].method_0().Split(' ')[4] : gClass.gclass5_0[j].method_0().Split(' ')[3]);
				}
			}
			return -1;
		}

		public void method_29()
		{
			if (!bool_8)
				return;
			if (method_28() <= 0 && !GClass82.smethod_0(4387))
			{
				if (GClass124.smethod_1().method_145() <= 0)
					return;
				bool_9 = false;
				if (GClass137.int_37 == 5)
				{
					for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
					{
						if (!(GClass167.gclass122_10.method_3(i) is GClass125 gClass))
							continue;
						if (gClass.gclass120_0.int_0 != 39 || GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 10)
						{
							if (!GClass14.gclass113_0.bool_0 || GClass14.gclass113_0 == null)
							{
								if (GClass14.gclass116_0 != null && (GClass14.gclass116_0 == null || GClass14.gclass116_0.bool_0))
								{
									if (!GClass14.gclass116_0.bool_0)
										continue;
									for (int j = 0; j < GClass14.gclass116_0.gclass122_0.method_2(); j++)
									{
										GClass118 gClass2 = (GClass118)GClass14.gclass116_0.gclass122_0.method_3(j);
										if (GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "shop" : "cửahàng") && GClass77.smethod_18() - long_7 > 1000L)
										{
											GClass2.smethod_0().method_59(39, (sbyte)j);
											GClass53.smethod_0().method_0();
											long_7 = GClass77.smethod_18();
										}
									}
									continue;
								}
								if (GClass77.smethod_18() - long_7 > 1000L)
								{
									GClass2.smethod_0().method_60(39);
									long_7 = GClass77.smethod_18();
								}
								break;
							}
							if (GClass77.smethod_18() - long_0 > 1000L)
							{
								if (GClass124.smethod_1().method_145() < 9)
								{
									GClass2.smethod_0().method_55(1, 521, 0);
									long_0 = GClass77.smethod_18();
								}
								if (GClass124.smethod_1().method_145() < 22 && GClass124.smethod_1().method_145() >= 9)
								{
									GClass2.smethod_0().method_55(1, 1523, 0);
									long_0 = GClass77.smethod_18();
								}
								if (GClass124.smethod_1().method_145() >= 22)
								{
									GClass2.smethod_0().method_55(1, 1524, 0);
									long_0 = GClass77.smethod_18();
								}
							}
							break;
						}
						if (GClass77.smethod_18() - long_7 > 500L)
						{
							GClass124.smethod_1().int_4 = gClass.int_4;
							GClass124.smethod_1().int_5 = gClass.int_5 - 3;
							GClass2.smethod_0().method_44();
							GClass124.smethod_1().int_4 = gClass.int_4;
							GClass124.smethod_1().int_5 = gClass.int_5;
							GClass2.smethod_0().method_44();
							GClass124.smethod_1().int_4 = gClass.int_4;
							GClass124.smethod_1().int_5 = gClass.int_5 - 3;
							GClass2.smethod_0().method_44();
							long_7 = GClass77.smethod_18();
						}
						break;
					}
				}
				else
					Class11.smethod_0().method_8(5);
			}
			else
				bool_9 = true;
		}

		public void method_30()
		{
			if (!bool_6)
				return;
			if (method_20(764, "id") == ((GClass124.smethod_1().method_145() / 2 < 10) ? (GClass124.smethod_1().method_145() / 2) : 10))
				bool_7 = true;
			else
			{
				if (method_20(764, "id") >= 10 || GClass124.smethod_1().method_145() < 2)
					return;
				if (method_20(764, "id") == 0)
				{
					if (GClass167.smethod_8().method_16())
						return;
					bool_7 = false;
					if (GClass137.int_37 != 5)
					{
						Class11.smethod_0().method_8(5);
						return;
					}
				}
				if (GClass137.int_37 != 5)
					return;
				for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
				{
					if (!(GClass167.gclass122_10.method_3(i) is GClass125 gClass))
						continue;
					if (gClass.gclass120_0.int_0 != 39 || GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 10)
					{
						if (!GClass14.gclass113_0.bool_0 || GClass14.gclass113_0 == null)
						{
							if (GClass14.gclass116_0 != null && (GClass14.gclass116_0 == null || GClass14.gclass116_0.bool_0))
							{
								if (!GClass14.gclass116_0.bool_0)
									continue;
								for (int j = 0; j < GClass14.gclass116_0.gclass122_0.method_2(); j++)
								{
									GClass118 gClass2 = (GClass118)GClass14.gclass116_0.gclass122_0.method_3(j);
									if (GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "shop" : "cửahàng"))
									{
										if (GClass77.smethod_18() - long_7 > 1000L)
										{
											GClass2.smethod_0().method_59(39, (sbyte)j);
											GClass53.smethod_0().method_0();
											long_7 = GClass77.smethod_18();
										}
										return;
									}
								}
								continue;
							}
							if (GClass77.smethod_18() - long_7 > 1000L)
							{
								GClass2.smethod_0().method_60(39);
								long_7 = GClass77.smethod_18();
							}
							break;
						}
						if (GClass77.smethod_18() - long_0 > 1000L)
						{
							GClass2.smethod_0().method_55(1, 764, 0);
							long_0 = GClass77.smethod_18();
						}
						break;
					}
					if (GClass77.smethod_18() - long_7 > 500L)
					{
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5 - 3;
						GClass2.smethod_0().method_44();
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5;
						GClass2.smethod_0().method_44();
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5 - 3;
						GClass2.smethod_0().method_44();
						long_7 = GClass77.smethod_18();
					}
					break;
				}
			}
		}

		public void method_31()
		{
			if (!bool_5 || GClass57.smethod_0().bool_0 || (list_7.Count <= 0 && list_8.Count <= 0))
				return;
			if (GClass77.smethod_18() - long_5 > 4000L)
			{
				GClass167.smethod_8().gclass200_0 = null;
				GClass14.smethod_29();
				long_5 = GClass77.smethod_18();
			}
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass == null)
					continue;
				if (list_8.Contains(gClass.gclass203_0.short_0) && gClass.gclass5_0 != null)
				{
					for (int j = 0; j < gClass.gclass5_0.Length; j++)
					{
						if (gClass.gclass5_0[j].gclass151_0.int_0 != 93)
							continue;
						if (GClass164.gclass164_0 != null && GClass77.smethod_18() - long_4 > 2000L)
						{
							for (int k = 0; k < GClass164.gclass164_0.gclass136_0.Length; k++)
							{
								GClass164.gclass164_0.gclass136_0[k].method_23("ok");
							}
							GClass2.smethod_0().method_7(GClass164.gclass164_0.gclass136_0);
							GClass167.gclass167_0.switchToMe();
							long_4 = GClass77.smethod_18();
						}
						if (GClass77.smethod_18() - long_4 > 2000L)
						{
							GClass2.smethod_0().method_20(1, 1, (sbyte)i, -1);
							GClass2.smethod_0().method_20(2, 1, (sbyte)i, -1);
							long_4 = GClass77.smethod_18();
						}
					}
				}
				if (!list_7.Contains(gClass.gclass203_0.short_0))
					continue;
				if (GClass164.gclass164_0 != null && GClass77.smethod_18() - long_4 > 2000L)
				{
					for (int l = 0; l < GClass164.gclass164_0.gclass136_0.Length; l++)
					{
						GClass164.gclass164_0.gclass136_0[l].method_23("ok");
					}
					GClass2.smethod_0().method_7(GClass164.gclass164_0.gclass136_0);
					GClass167.gclass167_0.switchToMe();
					long_4 = GClass77.smethod_18();
				}
				if (GClass77.smethod_18() - long_4 > 2000L)
				{
					GClass2.smethod_0().method_20(1, 1, (sbyte)i, -1);
					GClass2.smethod_0().method_20(2, 1, (sbyte)i, -1);
					long_4 = GClass77.smethod_18();
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
			method_9(gclass43_0);
			method_10(gclass43_0);
		}
	}
}
