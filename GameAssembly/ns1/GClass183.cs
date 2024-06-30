using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;

namespace ns1
{
	public class GClass183 : GInterface0, GInterface5
	{
		public struct GStruct1
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public GStruct1(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

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

		public class GClass184
		{
			public int int_0;

			public string string_0;

			public int int_1;

			public short short_0;

			public bool bool_0;

			public bool bool_1;

			public int int_2;

			public long long_0;

			public GClass184()
			{
			}

			public GClass184(int int_1, string string_0)
			{
				int_0 = int_1;
				this.string_0 = string_0;
			}

			public GClass184(int int_1, short short_0, bool bool_0, bool bool_1)
			{
				int_0 = int_1;
				this.bool_0 = bool_0;
				this.short_0 = short_0;
				this.bool_1 = bool_1;
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

		public struct GStruct4
		{
			public int int_0;

			public string string_0;

			public GStruct4(int id, string name)
			{
				int_0 = id;
				string_0 = name;
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

			public int int_1;

			public GStruct7(int id, string option, int type)
			{
				int_0 = id;
				string_0 = option;
				int_1 = type;
			}
		}

		private static GClass183 gclass183_0;

		public static GClass184 gclass184_0;

		private static string[] string_0;

		private static string[] string_1;

		public static bool bool_0;

		public long long_0;

		public long long_1;

		public bool bool_1;

		public bool bool_2;

		public List<GStruct7> list_0 = new List<GStruct7>();

		public List<GStruct1> list_1 = new List<GStruct1>();

		public List<GStruct3> list_2 = new List<GStruct3>();

		public List<GStruct6> list_3 = new List<GStruct6>();

		public List<GStruct2> list_4 = new List<GStruct2>();

		public List<GStruct5> list_5 = new List<GStruct5>();

		public int int_0;

		public string string_2;

		public List<GStruct4> list_6 = new List<GStruct4>();

		public long long_2;

		public int int_1 = 0;

		public int int_2 = 0;

		public bool bool_3;

		public long long_3;

		public int int_3 = -1;

		public bool bool_4 = false;

		public bool bool_5 = false;

		public bool bool_6 = true;

		public bool bool_7 = false;

		public bool bool_8 = true;

		public long long_4;

		public long long_5;

		public long long_6;

		public bool bool_9;

		public List<int> list_7 = new List<int> { 17, 18, 19, 20, 225, 211, 212, 226, 1526, 1505 };

		public List<int> list_8 = new List<int> { 1551, 1550 };

		static GClass183()
		{
			string_0 = new string[2] { "Nhập số lượng bán", "số lượng" };
			string_1 = new string[2] { "Nhập số lượng mua", "số lượng" };
		}

		public static GClass183 smethod_0()
		{
			return (gclass183_0 != null) ? gclass183_0 : (gclass183_0 = new GClass183());
		}

		public bool method_0(int asciiCode)
		{
			if (asciiCode != 100)
			{
				if (asciiCode != 115)
					return false;
				GClass63 gClass = new GClass63();
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Mặc Set 1\n[Sư phụ]" : "Wear Set1\n[Master]", smethod_0(), 11821, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Mặc Set 2\n[Sư phụ]" : "Wear Set2\n[Master]", smethod_0(), 11822, null));
				GClass39.gclass0_0.method_2(gClass, 0);
			}
			else
			{
				GClass63 gClass2 = new GClass63();
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? "Mặc Set 1\n[Đệ tử]" : "Wear Set1\n[Disciple]", smethod_0(), 11823, null));
				gClass2.method_0(new GClass14((GClass192.int_0 == 0) ? "Mặc Set 2\n[Đệ tử]" : "Wear Set2\n[Disciple]", smethod_0(), 11824, null));
				GClass39.gclass0_0.method_2(gClass2, 0);
			}
			return true;
		}

		public bool method_1(string text)
		{
			switch (text)
			{
			default:
				if (GClass193.smethod_0().method_10<int>(text, "/mvbt"))
				{
					int_2 = 933;
					int_1 = method_16(933, "id") + GClass193.smethod_0().method_11<int>(text, "/mvbt");
					break;
				}
				if (GClass193.smethod_0().method_10<int>(text, "/iddrop"))
				{
					if (list_7.Contains(GClass193.smethod_0().method_11<int>(text, "/iddrop")))
					{
						list_7.Remove(GClass193.smethod_0().method_11<int>(text, "/iddrop"));
						GClass188.smethod_1((GClass192.int_0 == 0) ? string.Format("Xóa {0} [{1}] khỏi d/s item vứt!", GClass83.smethod_1((short)GClass193.smethod_0().method_11<int>(text, "/iddrop")).string_0, GClass193.smethod_0().method_11<int>(text, "/iddrop")) : string.Format("Removed {0} [{1}] from list item drop!", GClass83.smethod_1((short)GClass193.smethod_0().method_11<int>(text, "/iddrop")).string_0, GClass193.smethod_0().method_11<int>(text, "/iddrop")), 0);
					}
					else
					{
						list_7.Add(GClass193.smethod_0().method_11<int>(text, "/iddrop"));
						GClass188.smethod_1((GClass192.int_0 == 0) ? string.Format("Thêm {0} [{1}] vào d/s item vứt!", GClass83.smethod_1((short)GClass193.smethod_0().method_11<int>(text, "/iddrop")).string_0, GClass193.smethod_0().method_11<int>(text, "/iddrop")) : string.Format("Added {0} [{1}] to list item drop!", GClass83.smethod_1((short)GClass193.smethod_0().method_11<int>(text, "/iddrop")).string_0, GClass193.smethod_0().method_11<int>(text, "/iddrop")), 0);
					}
					break;
				}
				if (GClass193.smethod_0().method_10<int>(text, "/iddrophsd"))
				{
					if (list_8.Contains(GClass193.smethod_0().method_11<int>(text, "/iddrophsd")))
					{
						list_8.Remove(GClass193.smethod_0().method_11<int>(text, "/iddrophsd"));
						GClass188.smethod_1((GClass192.int_0 == 0) ? string.Format("Xóa {0} [{1}] khỏi d/s item vứt theo HSD!", GClass83.smethod_1((short)GClass193.smethod_0().method_11<int>(text, "/iddrophsd")).string_0, GClass193.smethod_0().method_11<int>(text, "/iddrophsd")) : string.Format("Removed {0} [{1}] from list item drop by Expr!", GClass83.smethod_1((short)GClass193.smethod_0().method_11<int>(text, "/iddrophsd")).string_0, GClass193.smethod_0().method_11<int>(text, "/iddrophsd")), 0);
					}
					else
					{
						list_8.Add(GClass193.smethod_0().method_11<int>(text, "/iddrophsd"));
						GClass188.smethod_1((GClass192.int_0 == 0) ? string.Format("Thêm {0} [{1}] vào d/s item vứt theo HSD!", GClass83.smethod_1((short)GClass193.smethod_0().method_11<int>(text, "/iddrophsd")).string_0, GClass193.smethod_0().method_11<int>(text, "/iddrophsd")) : string.Format("Added {0} [{1}] to list item drop by Expr!", GClass83.smethod_1((short)GClass193.smethod_0().method_11<int>(text, "/iddrophsd")).string_0, GClass193.smethod_0().method_11<int>(text, "/iddrophsd")), 0);
					}
					break;
				}
				if (GClass193.smethod_0().method_10<int>(text, "/mhbt"))
				{
					int_2 = 934;
					int_1 = method_16(934, "id") + GClass193.smethod_0().method_11<int>(text, "/mhbt");
					break;
				}
				if (GClass193.smethod_0().method_9<int>(text, "/citem", 2))
				{
					int[] array = GClass193.smethod_0().method_8<int>(text, "/citem", 2);
					int_2 = array[0];
					int_1 = array[1];
					break;
				}
				return false;
			case "/clrlistdrop":
				list_8.Clear();
				list_7.Clear();
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã xóa danh sách ID item vứt!" : "Cleared list item ID drop!", 0);
				break;
			case "/dropitem":
				bool_9 = !bool_9;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động vứt đồ rác: " + GClass193.smethod_0().method_6(bool_9)) : ("Auto drop trash: " + GClass193.smethod_0().method_6(bool_9)), 0);
				break;
			case "/autobuytdlt":
				bool_7 = !bool_7;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động mua TĐLT: " + GClass193.smethod_0().method_6(bool_7)) : ("Auto buy AutoTrain: " + GClass193.smethod_0().method_6(bool_7)), 0);
				break;
			case "/autobuykt":
				bool_5 = !bool_5;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động mua khẩu trang: " + GClass193.smethod_0().method_6(bool_5)) : ("Auto buy mask: " + GClass193.smethod_0().method_6(bool_5)), 0);
				break;
			case "/isell":
				bool_3 = !bool_3;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động bán đồ rác: " + GClass193.smethod_0().method_6(bool_3)) : ("Auto sell trash item: " + GClass193.smethod_0().method_6(bool_3)), 0);
				break;
			case "/getitem":
				smethod_1();
				break;
			}
			return true;
		}

		public static void smethod_1()
		{
			string text = string.Empty;
			for (int i = 0; i < 2000; i++)
			{
				if (GClass83.smethod_1((short)i) != null)
					text = text + $"{GClass83.smethod_1((short)i).short_0}.{GClass83.smethod_1((short)i).string_0}" + "\n";
			}
			File.WriteAllText("Danh sách item.txt", text);
		}

		public void method_2(GClass76 g)
		{
			if (int_2 != 0 && int_1 > 0)
				GClass193.smethod_0().method_2(GClass49.gclass49_3, g, (GClass192.int_0 == 0) ? string.Format("Nhặt {0} [{1}]: {2}/{3}", GClass83.smethod_1((short)int_2).string_0, int_2, method_16(int_2, "id"), int_1) : string.Format("Pick up {0} [{1}]: {2}/{3}", GClass83.smethod_1((short)int_2).string_0, int_2, method_16(int_2, "id"), int_1), GClass39.int_10 / 2, 25, GClass49.int_2, GClass49.gclass49_6);
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
							smethod_0().method_13(1, 4);
						}).Start();
						break;
					case 11822:
						new Thread((ThreadStart)delegate
						{
							smethod_0().method_13(2, 4);
						}).Start();
						break;
					case 11823:
						new Thread((ThreadStart)delegate
						{
							smethod_0().method_13(1, 6);
						}).Start();
						break;
					case 11824:
						new Thread((ThreadStart)delegate
						{
							smethod_0().method_13(2, 6);
						}).Start();
						break;
					}
				}
				else
					method_1("/clrvp");
			}
			else
				method_4((GClass184)p);
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass7.smethod_0().gclass67_0.method_21() == null || GClass7.smethod_0().gclass67_0.method_21().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
				GClass7.smethod_0().bool_0 = false;
			else if (GClass7.smethod_0().string_1.Equals(string_1[0]))
			{
				try
				{
					int num = int.Parse(GClass7.smethod_0().gclass67_0.method_21());
					gclass184_0.int_1 = num;
					bool_2 = true;
				}
				catch
				{
					GClass154.gclass210_0.method_7("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				method_3();
			}
			else if (GClass7.smethod_0().string_1.Equals(string_0[0]))
			{
				try
				{
					int num2 = int.Parse(GClass7.smethod_0().gclass67_0.method_21());
					gclass184_0.int_1 = num2;
					bool_1 = true;
				}
				catch
				{
					GClass154.gclass210_0.method_7("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				method_3();
			}
		}

		public void onCancelChat()
		{
		}

		private void method_3()
		{
			GClass7.smethod_0().string_1 = "Chat";
			GClass7.smethod_0().gclass67_0.string_7 = "chat";
			GClass7.smethod_0().bool_0 = false;
		}

		private void method_4(GClass184 gclass184_1)
		{
			gclass184_0 = gclass184_1;
			GClass39.gclass45_0.bool_0 = false;
			if (gclass184_1.bool_1)
			{
				GClass7.smethod_0().string_1 = string_0[0];
				GClass7.smethod_0().gclass67_0.string_7 = string_0[1];
			}
			else
			{
				GClass7.smethod_0().string_1 = string_1[0];
				GClass7.smethod_0().gclass67_0.string_7 = string_1[1];
			}
			GClass7.smethod_0().method_5(smethod_0(), string.Empty);
		}

		public void method_5(GClass184 item)
		{
			if (!bool_1 || item == null)
				return;
			short short_ = item.short_0;
			if (item.int_1 == 0)
				bool_1 = false;
			if (item.int_1 <= 0)
				return;
			bool flag = false;
			if (GClass58.smethod_1().gclass121_0[short_] == null || (GClass58.smethod_1().gclass121_0[short_] != null && GClass58.smethod_1().gclass121_0[short_].gclass118_0.short_0 != (short)item.int_0))
			{
				item.int_1 = 0;
				bool_1 = false;
				return;
			}
			if (!flag && GClass138.smethod_18() - long_1 > 100L)
			{
				GClass166.smethod_0().method_54(0, 1, short_);
				flag = true;
				long_1 = GClass138.smethod_18();
			}
			if (flag && GClass138.smethod_18() - long_1 > 1000L)
			{
				GClass166.smethod_0().method_54(1, 1, short_);
				long_1 = GClass138.smethod_18();
				item.int_1--;
				flag = false;
			}
			if (GClass58.smethod_1().long_6 > 1963100000L)
			{
				item.int_1 = 0;
				bool_1 = false;
			}
		}

		public void method_6(GClass184 item)
		{
			if (bool_2 && item != null)
			{
				if (item.int_1 == 0)
					bool_2 = false;
				if (GClass154.smethod_8().method_16())
				{
					bool_2 = false;
					item.int_1 = 0;
				}
				if (item.int_1 > 0 && !GClass154.smethod_8().method_16() && GClass138.smethod_18() - long_0 > 1000L && long_0 != -1L)
				{
					GClass166.smethod_0().method_55((!item.bool_0) ? ((sbyte)1) : ((sbyte)0), item.int_0, 0);
					long_0 = -1L;
				}
			}
		}

		public void method_7()
		{
			string text = string.Empty;
			if (GClass58.smethod_1().gclass121_2[6] == null)
				return;
			if (GClass58.smethod_1().gclass121_2[6].gclass20_0 != null)
			{
				for (int i = 0; i < GClass58.smethod_1().gclass121_2[6].gclass20_0.Length; i++)
				{
					text = text + GClass58.smethod_1().gclass121_2[6].gclass20_0[i].gclass114_0.int_0 + "-";
				}
			}
			if (!list_0.Contains(new GStruct7(GClass58.smethod_1().gclass121_2[6].gclass118_0.short_0, text, GClass58.smethod_1().gclass121_2[6].gclass118_0.sbyte_0)))
				list_0.Add(new GStruct7(GClass58.smethod_1().gclass121_2[6].gclass118_0.short_0, text, GClass58.smethod_1().gclass121_2[6].gclass118_0.sbyte_0));
			if (list_0.Contains(new GStruct7(GClass58.smethod_1().gclass121_2[6].gclass118_0.short_0, text, GClass58.smethod_1().gclass121_2[6].gclass118_0.sbyte_0)))
				GClass166.smethod_0().method_30(5, 6);
		}

		public void method_8()
		{
			foreach (GStruct7 item in list_0)
			{
				GClass121[] gclass121_ = GClass58.smethod_1().gclass121_0;
				try
				{
					for (int i = 0; i < gclass121_.Length; i++)
					{
						string text = string.Empty;
						if (gclass121_[i].gclass20_0 != null)
						{
							for (int j = 0; j < gclass121_[i].gclass20_0.Length; j++)
							{
								text = text + gclass121_[i].gclass20_0[j].gclass114_0.int_0 + "-";
							}
						}
						if (gclass121_[i].gclass118_0.short_0 == item.int_0 && text == item.string_0)
						{
							GClass166.smethod_0().method_30(4, (sbyte)i);
							Thread.Sleep(100);
						}
					}
				}
				catch
				{
				}
			}
		}

		public void method_9()
		{
			if (GClass58.smethod_1().gclass121_2[5] == null)
			{
				for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
				{
					GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
					if (gClass == null)
						continue;
					for (int j = 0; j < gClass.gclass20_0.Length; j++)
					{
						if (gClass.gclass20_0[j].gclass114_0.int_0 == 106 && GClass58.smethod_1().long_2 >= gClass.gclass118_0.int_2)
							GClass166.smethod_0().method_30(4, (sbyte)i);
					}
				}
				return;
			}
			string text = string.Empty;
			if (GClass58.smethod_1().gclass121_2[5].gclass20_0 != null)
			{
				for (int k = 0; k < GClass58.smethod_1().gclass121_2[5].gclass20_0.Length; k++)
				{
					if (!text.Contains(GClass58.smethod_1().gclass121_2[5].gclass20_0[k].gclass114_0.int_0 + "-"))
						text = text + GClass58.smethod_1().gclass121_2[5].gclass20_0[k].gclass114_0.int_0 + "-";
				}
			}
			if (!list_1.Contains(new GStruct1(GClass58.smethod_1().gclass121_2[5].gclass118_0.short_0, text, GClass58.smethod_1().gclass121_2[5].gclass118_0.sbyte_0)) && !text.Contains("106"))
				list_1.Add(new GStruct1(GClass58.smethod_1().gclass121_2[5].gclass118_0.short_0, text, GClass58.smethod_1().gclass121_2[5].gclass118_0.sbyte_0));
			if (!list_1.Contains(new GStruct1(GClass58.smethod_1().gclass121_2[5].gclass118_0.short_0, text, GClass58.smethod_1().gclass121_2[5].gclass118_0.sbyte_0)))
				return;
			for (int l = 0; l < GClass58.smethod_1().gclass121_0.Length; l++)
			{
				GClass121 gClass2 = GClass58.smethod_1().gclass121_0[l];
				if (gClass2 == null)
					continue;
				for (int m = 0; m < gClass2.gclass20_0.Length; m++)
				{
					if (gClass2.gclass20_0[m].gclass114_0.int_0 == 106 && GClass58.smethod_1().long_2 >= gClass2.gclass118_0.int_2)
						GClass166.smethod_0().method_30(4, (sbyte)l);
				}
			}
		}

		public void method_10()
		{
			try
			{
				foreach (GStruct1 item in list_1)
				{
					GClass121[] gclass121_ = GClass58.smethod_1().gclass121_0;
					try
					{
						for (int i = 0; i < gclass121_.Length; i++)
						{
							string text = string.Empty;
							if (gclass121_[i].gclass20_0 != null)
							{
								for (int j = 0; j < gclass121_[i].gclass20_0.Length; j++)
								{
									text = text + gclass121_[i].gclass20_0[j].gclass114_0.int_0 + "-";
								}
							}
							if (gclass121_[i].gclass118_0.short_0 == item.int_0 && text == item.string_0)
							{
								GClass166.smethod_0().method_30(4, (sbyte)i);
								Thread.Sleep(100);
								return;
							}
						}
					}
					catch
					{
					}
				}
				if (GClass58.smethod_1().gclass121_2[5] == null || GClass58.smethod_1().gclass121_2[5].gclass20_0 == null)
					return;
				for (int k = 0; k < GClass58.smethod_1().gclass121_2[5].gclass20_0.Length; k++)
				{
					if (GClass58.smethod_1().gclass121_2[5].gclass20_0[k].gclass114_0.int_0 == 106)
						GClass166.smethod_0().method_30(5, 5);
				}
			}
			catch
			{
			}
		}

		public void method_11()
		{
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass != null)
				{
					if (gClass.gclass118_0.short_0 == 663)
						GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
					if (gClass.gclass118_0.short_0 == 664)
						GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
					if (gClass.gclass118_0.short_0 == 665)
						GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
					if (gClass.gclass118_0.short_0 == 666)
						GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
					if (gClass.gclass118_0.short_0 == 667)
						GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
				}
			}
		}

		public void method_12(GClass121 item, int ListIndex, string type)
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
					if (item.gclass20_0 != null)
					{
						for (int i = 0; i < item.gclass20_0.Length; i++)
						{
							text = text + item.gclass20_0[i].gclass114_0.int_0 + "-";
						}
					}
					foreach (GStruct5 item2 in list_5)
					{
						if (item2.int_0 == item.gclass118_0.short_0 && item2.string_0 == text && item2.int_1 == item.gclass118_0.sbyte_0)
							list_5.Remove(item2);
						if ((item2.int_0 != item.gclass118_0.short_0 || item2.string_0 != text) && item2.int_1 == item.gclass118_0.sbyte_0)
						{
							GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã có loại item này!" : "Already have this item", 0);
							return;
						}
					}
					list_5.Add(new GStruct5(item.gclass118_0.short_0, text, item.gclass118_0.sbyte_0));
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm " + item.gclass118_0.string_0 + " vào set đồ 2 của đệ tử") : ("Added " + item.gclass118_0.string_0 + " to set 2 of disciple"), 0);
					return;
				}
				string text2 = string.Empty;
				if (item.gclass20_0 != null)
				{
					for (int j = 0; j < item.gclass20_0.Length; j++)
					{
						text2 = text2 + item.gclass20_0[j].gclass114_0.int_0 + "-";
					}
				}
				foreach (GStruct6 item3 in list_3)
				{
					if (item3.int_0 == item.gclass118_0.short_0 && item3.string_0 == text2 && item3.int_1 == item.gclass118_0.sbyte_0)
						list_3.Remove(item3);
					if ((item3.int_0 != item.gclass118_0.short_0 || item3.string_0 != text2) && item3.int_1 == item.gclass118_0.sbyte_0)
					{
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã có loại item này!" : "Already have this item", 0);
						return;
					}
				}
				list_3.Add(new GStruct6(item.gclass118_0.short_0, text2, item.gclass118_0.sbyte_0));
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm " + item.gclass118_0.string_0 + " vào set đồ 2 của sư phụ") : ("Added " + item.gclass118_0.string_0 + " to set 2 of master"), 0);
				return;
			}
			if (!(type == "suphu"))
			{
				if (!(type == "detu"))
					return;
				string text3 = string.Empty;
				if (item.gclass20_0 != null)
				{
					for (int k = 0; k < item.gclass20_0.Length; k++)
					{
						text3 = text3 + item.gclass20_0[k].gclass114_0.int_0 + "-";
					}
				}
				foreach (GStruct2 item4 in list_4)
				{
					if (item4.int_0 == item.gclass118_0.short_0 && item4.string_0 == text3 && item4.int_1 == item.gclass118_0.sbyte_0)
						list_4.Remove(item4);
					if ((item4.int_0 != item.gclass118_0.short_0 || item4.string_0 == text3) && item4.int_1 == item.gclass118_0.sbyte_0)
					{
						GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? "Đã có loại item này!" : "Already have this item", 0);
						return;
					}
				}
				list_4.Add(new GStruct2(item.gclass118_0.short_0, text3, item.gclass118_0.sbyte_0));
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm " + item.gclass118_0.string_0 + " vào set đồ 1 của đệ tử") : ("Added " + item.gclass118_0.string_0 + " to set 1 of disciple"), 0);
				return;
			}
			string text4 = string.Empty;
			if (item.gclass20_0 != null)
			{
				for (int l = 0; l < item.gclass20_0.Length; l++)
				{
					text4 = text4 + item.gclass20_0[l].gclass114_0.int_0 + "-";
				}
			}
			foreach (GStruct3 item5 in list_2)
			{
				if (item5.int_0 == item.gclass118_0.short_0 && item5.string_0 == text4 && item5.int_1 == item.gclass118_0.sbyte_0)
					list_2.Remove(item5);
				if ((item5.int_0 != item.gclass118_0.short_0 || item5.string_0 == text4) && item5.int_1 == item.gclass118_0.sbyte_0)
				{
					GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã có loại item này!" : "Already have this item", 0);
					return;
				}
			}
			list_2.Add(new GStruct3(item.gclass118_0.short_0, text4, item.gclass118_0.sbyte_0));
			GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm " + item.gclass118_0.string_0 + " vào set đồ 1 của sư phụ") : ("Added " + item.gclass118_0.string_0 + " to set 1 of master"), 0);
		}

		public void method_13(int type, sbyte get)
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
						foreach (GStruct5 item in list_5)
						{
							GClass121[] gclass121_ = GClass58.smethod_1().gclass121_0;
							try
							{
								for (int i = 0; i < gclass121_.Length; i++)
								{
									string text = string.Empty;
									if (gclass121_[i].gclass20_0 != null)
									{
										for (int j = 0; j < gclass121_[i].gclass20_0.Length; j++)
										{
											text = text + gclass121_[i].gclass20_0[j].gclass114_0.int_0 + "-";
										}
									}
									if (gclass121_[i].gclass118_0.short_0 == item.int_0 && text == item.string_0)
									{
										GClass166.smethod_0().method_30(get, (sbyte)i);
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
					foreach (GStruct6 item2 in list_3)
					{
						GClass121[] gclass121_2 = GClass58.smethod_1().gclass121_0;
						try
						{
							for (int k = 0; k < gclass121_2.Length; k++)
							{
								string text2 = string.Empty;
								if (gclass121_2[k].gclass20_0 != null)
								{
									for (int l = 0; l < gclass121_2[k].gclass20_0.Length; l++)
									{
										text2 = text2 + gclass121_2[k].gclass20_0[l].gclass114_0.int_0 + "-";
									}
								}
								if (gclass121_2[k].gclass118_0.short_0 == item2.int_0 && text2 == item2.string_0)
								{
									GClass166.smethod_0().method_30(get, (sbyte)k);
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
					foreach (GStruct2 item3 in list_4)
					{
						GClass121[] gclass121_3 = GClass58.smethod_1().gclass121_0;
						try
						{
							for (int m = 0; m < gclass121_3.Length; m++)
							{
								string text3 = string.Empty;
								if (gclass121_3[m].gclass20_0 != null)
								{
									for (int n = 0; n < gclass121_3[m].gclass20_0.Length; n++)
									{
										text3 = text3 + gclass121_3[m].gclass20_0[n].gclass114_0.int_0 + "-";
									}
								}
								if (gclass121_3[m].gclass118_0.short_0 == item3.int_0 && text3 == item3.string_0)
								{
									GClass166.smethod_0().method_30(get, (sbyte)m);
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
			foreach (GStruct3 item4 in list_2)
			{
				GClass121[] gclass121_4 = GClass58.smethod_1().gclass121_0;
				try
				{
					for (int num = 0; num < gclass121_4.Length; num++)
					{
						string text4 = string.Empty;
						if (gclass121_4[num].gclass20_0 != null)
						{
							for (int num2 = 0; num2 < gclass121_4[num].gclass20_0.Length; num2++)
							{
								text4 = text4 + gclass121_4[num].gclass20_0[num2].gclass114_0.int_0 + "-";
							}
						}
						if (gclass121_4[num].gclass118_0.short_0 == item4.int_0 && text4 == item4.string_0)
						{
							GClass166.smethod_0().method_30(get, (sbyte)num);
							Thread.Sleep(100);
						}
					}
				}
				catch
				{
				}
			}
		}

		public void method_14(GClass121 item)
		{
			foreach (GStruct4 item2 in list_6)
			{
				if (item2.int_0 == item.gclass118_0.short_1)
				{
					list_6.Remove(item2);
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Dừng tự động sử dụng " + item.gclass118_0.string_0) : ("Stop auto using " + item.gclass118_0.string_0 + " "), 0);
				}
			}
			list_6.Add(new GStruct4(item.gclass118_0.short_1, item.gclass118_0.string_0));
			GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động dùng " + item.gclass118_0.string_0) : ("Auto use " + item.gclass118_0.string_0), 0);
		}

		public void method_15()
		{
			if (GClass39.int_8 % 5 != 0 || list_6.Count <= 0)
				return;
			for (int i = 0; i < list_6.Count; i++)
			{
				GStruct4 gStruct = list_6[i];
				if (GClass82.smethod_0(gStruct.int_0))
					continue;
				for (int j = 0; j < GClass58.smethod_1().gclass121_0.Length; j++)
				{
					GClass121 gClass = GClass58.smethod_1().gclass121_0[j];
					if (gClass != null && gClass.gclass118_0.short_1 == gStruct.int_0 && GClass138.smethod_18() - long_2 > 10000L)
					{
						GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
						long_2 = GClass138.smethod_18();
					}
				}
			}
		}

		public int method_16(int id, string type)
		{
			int num = 0;
			GClass121 gClass;
			while (true)
			{
				if (num < GClass58.smethod_1().gclass121_0.Length)
				{
					gClass = GClass58.smethod_1().gclass121_0[num];
					if (type == "id")
					{
						if (gClass != null && gClass.gclass118_0.short_0 == id && id != 590 && id != 933)
							return gClass.int_30;
						if (gClass != null && gClass.gclass118_0.short_0 == id && id == 933)
						{
							string[] array = gClass.gclass20_0[0].method_0().Split(' ');
							if (gClass.gclass20_0[0].method_0().StartsWith("Quantity"))
								return int.Parse(array[1]);
							return int.Parse(array[2]);
						}
						if (gClass != null && gClass.gclass118_0.short_0 == id && id == 590)
							return int.Parse(gClass.gclass20_0[0].method_0().Split(' ')[2]);
					}
					else if (type == "iconID" && gClass != null && gClass.gclass118_0.short_1 == id && id != 590 && id != 933)
					{
						break;
					}
					num++;
					continue;
				}
				return 0;
			}
			return gClass.int_30;
		}

		public void method_17()
		{
			if (int_2 != 0 && int_1 != 0 && method_16(int_2, "id") == int_1)
				Application.Quit();
		}

		public void method_18()
		{
			if (!bool_3 || GClass138.smethod_18() - long_3 <= 1000L)
				return;
			try
			{
				if (method_19() <= 0)
					return;
				if (GClass1.int_37 != 24 + GClass58.smethod_1().int_14 && GClass154.smethod_8().method_16())
					Class14.smethod_0().method_7(24 + GClass58.smethod_1().int_14);
				else
				{
					if (GClass1.int_37 != 24 + GClass58.smethod_1().int_14)
						return;
					int num = 0;
					int int_3;
					int int_4;
					while (true)
					{
						if (num >= GClass154.gclass63_10.method_2())
							return;
						GClass59 gClass = GClass154.gclass63_10.method_3(num) as GClass59;
						int int_ = GClass58.smethod_1().int_4;
						int int_2 = GClass58.smethod_1().int_5;
						if (gClass != null && gClass.gclass90_0.int_0 == 16)
						{
							int_3 = gClass.int_4;
							int_4 = gClass.int_5;
							if (GClass56.smethod_24(int_, int_2, int_3, int_4) > 10)
								break;
							for (int num2 = GClass58.smethod_1().gclass121_0.Length - 1; num2 >= 0; num2--)
							{
								GClass121 gClass2 = GClass58.smethod_1().gclass121_0[num2];
								if (gClass2 != null)
								{
									bool flag = gClass2.gclass118_0.int_2 > 0 && gClass2.gclass118_0.int_2 < 1400000 && !method_20(gClass2) && !method_21(gClass2) && (gClass2.gclass118_0.sbyte_0 == 0 || gClass2.gclass118_0.sbyte_0 == 1 || gClass2.gclass118_0.sbyte_0 == 2 || gClass2.gclass118_0.sbyte_0 == 3 || gClass2.gclass118_0.sbyte_0 == 4);
									bool flag2 = gClass2.gclass118_0.short_0 == 18 || gClass2.gclass118_0.short_0 == 19 || gClass2.gclass118_0.short_0 == 20;
									bool flag3 = gClass2.gclass118_0.short_0 == 225;
									bool flag4 = gClass2.gclass118_0.sbyte_0 == 33 && gClass2.gclass118_0.short_0 != 956 && gClass2.gclass118_0.short_0 != 1204;
									bool flag5 = gClass2.gclass118_0.short_0 >= 441 && gClass2.gclass118_0.short_0 <= 447;
									bool flag6 = gClass2.gclass118_0.short_0 == 226;
									if (flag || flag2 || flag3)
									{
										GClass166.smethod_0().method_54(0, 1, (short)num2);
										GClass172.smethod_0().method_0(1000);
										GClass166.smethod_0().method_54(1, 1, (short)num2);
										GClass172.smethod_0().method_0(1000);
										long_3 = GClass138.smethod_18();
										return;
									}
									if (flag4)
									{
										GClass166.smethod_0().method_20(0, 1, -1, gClass2.gclass118_0.short_0);
										long_3 = GClass138.smethod_18();
										return;
									}
									if (flag5 || flag6)
									{
										GClass166.smethod_0().method_20(1, 1, (sbyte)num2, -1);
										GClass172.smethod_0().method_0(1000);
										GClass166.smethod_0().method_20(2, 1, (sbyte)num2, -1);
										GClass172.smethod_0().method_0(1000);
										long_3 = GClass138.smethod_18();
									}
								}
							}
						}
						num++;
					}
					GClass58.smethod_1().int_4 = int_3;
					GClass58.smethod_1().int_5 = int_4 - 3;
					GClass166.smethod_0().method_44();
					GClass58.smethod_1().int_4 = int_3;
					GClass58.smethod_1().int_5 = int_4;
					GClass166.smethod_0().method_44();
					GClass58.smethod_1().int_4 = int_3;
					GClass58.smethod_1().int_5 = int_4 - 3;
					GClass166.smethod_0().method_44();
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/AutoSellTrashItem.txt", ex.ToString());
			}
		}

		public int method_19()
		{
			int num = 0;
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass != null && ((gClass.gclass118_0.int_2 > 0 && gClass.gclass118_0.int_2 < 1400000 && !method_20(gClass) && !method_21(gClass) && (gClass.gclass118_0.sbyte_0 == 0 || gClass.gclass118_0.sbyte_0 == 1 || gClass.gclass118_0.sbyte_0 == 2 || gClass.gclass118_0.sbyte_0 == 3 || gClass.gclass118_0.sbyte_0 == 4)) | (gClass.gclass118_0.short_0 == 18 || gClass.gclass118_0.short_0 == 19 || gClass.gclass118_0.short_0 == 20) | (gClass.gclass118_0.short_0 == 225) | (gClass.gclass118_0.sbyte_0 == 33 && gClass.gclass118_0.short_0 != 956 && gClass.gclass118_0.short_0 != 1204) | (gClass.gclass118_0.short_0 >= 441 && gClass.gclass118_0.short_0 <= 447)))
					num++;
			}
			return num;
		}

		public bool method_20(GClass121 item)
		{
			if (item.gclass20_0 != null)
			{
				for (int i = 0; i < item.gclass20_0.Length; i++)
				{
					if (item.gclass20_0[i].gclass114_0.string_0.StartsWith("$"))
						return true;
				}
			}
			return false;
		}

		public bool method_21(GClass121 item)
		{
			if (item.gclass20_0 != null)
			{
				for (int i = 0; i < item.gclass20_0.Length; i++)
				{
					if (item.gclass20_0[i].gclass114_0.int_0 == 107)
						return true;
				}
			}
			return false;
		}

		public void method_22(string s)
		{
			if (bool_2)
			{
				if (s.ToLower().StartsWith((mResources.language == 0) ? "mua thành công" : "buy successful") || s.ToLower().StartsWith((mResources.language == 0) ? "bạn đã mua thành công" : "you bought"))
				{
					long_0 = GClass138.smethod_18();
					gclass184_0.int_1--;
				}
				if (s.ToLower().StartsWith("you don't have enough") || s.ToLower().StartsWith("not enough") || s.ToLower().StartsWith("bạn không đủ") || s.ToLower().StartsWith("not enough"))
					gclass184_0.int_1 = 0;
			}
			if (!s.ToLower().StartsWith((mResources.language == 0) ? "thể lực đã cạn" : "go relax a bit"))
				return;
			int num = 0;
			GClass121 gClass;
			while (true)
			{
				if (num < GClass58.smethod_1().gclass121_0.Length)
				{
					gClass = GClass58.smethod_1().gclass121_0[num];
					if (gClass != null && gClass.gclass118_0.short_0 == 212)
						break;
					if (gClass == null || gClass.gclass118_0.short_0 != 211)
					{
						num++;
						continue;
					}
					GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
					return;
				}
				return;
			}
			GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
		}

		public bool method_23(int id)
		{
			int num = 0;
			while (true)
			{
				if (num < GClass58.smethod_1().gclass121_0.Length)
				{
					GClass121 gClass = GClass58.smethod_1().gclass121_0[num];
					if (gClass != null && gClass.gclass118_0.short_0 == id)
						break;
					num++;
					continue;
				}
				return false;
			}
			return true;
		}

		public void method_24(GClass121 item)
		{
			GClass120.smethod_9(GClass199.string_0 + "petID", item.gclass118_0.short_0);
			int_3 = item.gclass118_0.short_0;
		}

		public void method_25()
		{
			if (GClass39.gclass145_0 != GClass153.gclass153_0 && !GClass58.bool_33 && !GClass65.bool_5 && !GClass58.bool_35 && GClass39.int_8 % 10 == 0)
			{
				if (int_3 < 0)
					int_3 = GClass120.smethod_8(GClass199.string_0 + "petID");
				if (!bool_4 && int_3 > 0)
				{
					GClass166.smethod_0().method_20(0, 1, -1, (short)int_3);
					bool_4 = true;
				}
			}
		}

		public int method_26()
		{
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass == null || gClass.gclass118_0.short_0 != 521 || gClass.gclass20_0 == null)
					continue;
				for (int j = 0; j < gClass.gclass20_0.Length; j++)
				{
					if (gClass.gclass20_0[j].gclass114_0.int_0 == 1)
						return int.Parse((mResources.language == 0) ? gClass.gclass20_0[j].method_0().Split(' ')[4] : gClass.gclass20_0[j].method_0().Split(' ')[3]);
				}
			}
			return -1;
		}

		public void method_27()
		{
			if (!bool_7)
				return;
			if (method_26() > 0 || GClass82.smethod_0(4387))
				bool_8 = true;
			else
			{
				if (GClass58.smethod_1().method_143() <= 0)
					return;
				bool_8 = false;
				if (GClass1.int_37 != 5)
				{
					Class14.smethod_0().method_7(5);
					return;
				}
				for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
				{
					if (!(GClass154.gclass63_10.method_3(i) is GClass59 gClass))
						continue;
					if (gClass.gclass90_0.int_0 != 39 || GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 10)
					{
						if (!GClass39.gclass45_0.bool_0 || GClass39.gclass45_0 == null)
						{
							if (GClass39.gclass0_0 != null && (GClass39.gclass0_0 == null || GClass39.gclass0_0.bool_0))
							{
								if (!GClass39.gclass0_0.bool_0)
									continue;
								for (int j = 0; j < GClass39.gclass0_0.gclass63_0.method_2(); j++)
								{
									GClass14 gClass2 = (GClass14)GClass39.gclass0_0.gclass63_0.method_3(j);
									if (GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "cửahàng" : "shop"))
									{
										if (GClass138.smethod_18() - long_5 > 1000L)
										{
											GClass166.smethod_0().method_59(39, (sbyte)j);
											GClass198.smethod_0().method_0();
											long_5 = GClass138.smethod_18();
										}
										return;
									}
								}
								continue;
							}
							if (GClass138.smethod_18() - long_5 > 1000L)
							{
								GClass166.smethod_0().method_60(39);
								long_5 = GClass138.smethod_18();
							}
							break;
						}
						if (GClass138.smethod_18() - long_0 > 1000L)
						{
							if (GClass58.smethod_1().method_143() < 9)
							{
								GClass166.smethod_0().method_55(1, 521, 0);
								long_0 = GClass138.smethod_18();
							}
							if (GClass58.smethod_1().method_143() < 22 && GClass58.smethod_1().method_143() >= 9)
							{
								GClass166.smethod_0().method_55(1, 1523, 0);
								long_0 = GClass138.smethod_18();
							}
							if (GClass58.smethod_1().method_143() >= 22)
							{
								GClass166.smethod_0().method_55(1, 1524, 0);
								long_0 = GClass138.smethod_18();
							}
						}
						break;
					}
					if (GClass138.smethod_18() - long_5 > 500L)
					{
						GClass58.smethod_1().int_4 = gClass.int_4;
						GClass58.smethod_1().int_5 = gClass.int_5 - 3;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass.int_4;
						GClass58.smethod_1().int_5 = gClass.int_5;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass.int_4;
						GClass58.smethod_1().int_5 = gClass.int_5 - 3;
						GClass166.smethod_0().method_44();
						long_5 = GClass138.smethod_18();
					}
					break;
				}
			}
		}

		public void method_28()
		{
			if (!bool_5)
				return;
			if (method_16(764, "id") == ((GClass58.smethod_1().method_143() / 2 >= 10) ? 10 : (GClass58.smethod_1().method_143() / 2)))
				bool_6 = true;
			else
			{
				if (method_16(764, "id") >= 10 || GClass58.smethod_1().method_143() < 2)
					return;
				if (method_16(764, "id") == 0)
				{
					if (GClass154.smethod_8().method_16())
						return;
					bool_6 = false;
					if (GClass1.int_37 != 5)
					{
						Class14.smethod_0().method_7(5);
						return;
					}
				}
				if (GClass1.int_37 != 5)
					return;
				for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
				{
					if (!(GClass154.gclass63_10.method_3(i) is GClass59 gClass))
						continue;
					if (gClass.gclass90_0.int_0 != 39 || GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 10)
					{
						if (!GClass39.gclass45_0.bool_0 || GClass39.gclass45_0 == null)
						{
							if (GClass39.gclass0_0 != null && (GClass39.gclass0_0 == null || GClass39.gclass0_0.bool_0))
							{
								if (!GClass39.gclass0_0.bool_0)
									continue;
								for (int j = 0; j < GClass39.gclass0_0.gclass63_0.method_2(); j++)
								{
									GClass14 gClass2 = (GClass14)GClass39.gclass0_0.gclass63_0.method_3(j);
									if (GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "cửahàng" : "shop"))
									{
										if (GClass138.smethod_18() - long_5 > 1000L)
										{
											GClass166.smethod_0().method_59(39, (sbyte)j);
											GClass198.smethod_0().method_0();
											long_5 = GClass138.smethod_18();
										}
										return;
									}
								}
								continue;
							}
							if (GClass138.smethod_18() - long_5 > 1000L)
							{
								GClass166.smethod_0().method_60(39);
								long_5 = GClass138.smethod_18();
							}
							break;
						}
						if (GClass138.smethod_18() - long_0 > 1000L)
						{
							GClass166.smethod_0().method_55(1, 764, 0);
							long_0 = GClass138.smethod_18();
						}
						break;
					}
					if (GClass138.smethod_18() - long_5 > 500L)
					{
						GClass58.smethod_1().int_4 = gClass.int_4;
						GClass58.smethod_1().int_5 = gClass.int_5 - 3;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass.int_4;
						GClass58.smethod_1().int_5 = gClass.int_5;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass.int_4;
						GClass58.smethod_1().int_5 = gClass.int_5 - 3;
						GClass166.smethod_0().method_44();
						long_5 = GClass138.smethod_18();
					}
					break;
				}
			}
		}

		public void method_29()
		{
			if (!bool_9 || GClass171.smethod_0().bool_0 || (list_7.Count <= 0 && list_8.Count <= 0))
				return;
			if (GClass39.int_8 % 50 == 0)
			{
				GClass154.smethod_8().gclass52_0 = null;
				GClass39.smethod_29();
			}
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass == null)
					continue;
				if (list_8.Contains(gClass.gclass118_0.short_0) && gClass.gclass20_0 != null)
				{
					for (int j = 0; j < gClass.gclass20_0.Length; j++)
					{
						if (gClass.gclass20_0[j].gclass114_0.int_0 == 93 && GClass138.smethod_18() - long_6 > 2000L)
						{
							GClass166.smethod_0().method_20(1, 1, (sbyte)i, -1);
							GClass166.smethod_0().method_20(2, 1, (sbyte)i, -1);
							long_6 = GClass138.smethod_18();
						}
					}
				}
				if (list_7.Contains(gClass.gclass118_0.short_0) && GClass138.smethod_18() - long_6 > 2000L)
				{
					GClass166.smethod_0().method_20(1, 1, (sbyte)i, -1);
					GClass166.smethod_0().method_20(2, 1, (sbyte)i, -1);
					long_6 = GClass138.smethod_18();
				}
			}
		}

		public void method_30()
		{
			method_29();
			method_27();
			method_28();
			method_25();
			method_18();
			method_15();
			method_17();
			method_5(gclass184_0);
			method_6(gclass184_0);
		}
	}
}
