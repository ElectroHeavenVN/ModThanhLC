using System;
using System.Collections.Generic;
using System.Linq;

namespace ns1
{
	public class GClass197 : GInterface0, GInterface5
	{
		public enum GEnum2
		{
			const_0,
			const_1,
			const_2,
			const_3
		}

		public bool bool_0;

		public int int_0 = 0;

		public bool bool_1;

		public bool bool_2 = true;

		public int int_1;

		public bool bool_3 = false;

		private static readonly sbyte[] sbyte_0 = new sbyte[4] { 0, 2, 17, 4 };

		private static readonly short[] short_0 = new short[11]
		{
			225, 353, 354, 355, 356, 357, 358, 359, 360, 362,
			726
		};

		public bool bool_4 = false;

		public static List<int> list_0 = new List<int>();

		public static List<int> list_1 = new List<int>();

		public static List<sbyte> list_2 = new List<sbyte>(sbyte_0);

		public bool bool_5 = false;

		public bool bool_6 = false;

		public bool bool_7 = false;

		public static int int_2 = 100;

		public static List<short> list_3 = new List<short>();

		public static List<short> list_4 = new List<short>(short_0);

		public static List<sbyte> list_5 = new List<sbyte>();

		public static List<sbyte> list_6 = new List<sbyte>();

		public static int int_3 = 0;

		public static int int_4 = 0;

		private static GClass197 gclass197_0;

		private static readonly sbyte[] sbyte_1 = new sbyte[5] { 0, 9, 2, 17, 4 };

		private static readonly sbyte[] sbyte_2 = new sbyte[5] { 10, 11, 14, 23, 7 };

		public static bool bool_8;

		private static bool bool_9;

		private static long long_0;

		private static long long_1;

		public static List<GClass134> list_7 = new List<GClass134>();

		private static int int_5 = 0;

		public static long long_2;

		public long long_3;

		public static GClass197 smethod_0()
		{
			return (gclass197_0 != null) ? gclass197_0 : (gclass197_0 = new GClass197());
		}

		private void method_0()
		{
			GClass7.smethod_0().string_1 = "Chat";
			GClass7.smethod_0().gclass67_0.string_7 = "chat";
			GClass7.smethod_0().bool_0 = false;
		}

		public void onCancelChat()
		{
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass7.smethod_0().gclass67_0.method_21() == null || GClass7.smethod_0().gclass67_0.method_21().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
				GClass7.smethod_0().bool_0 = false;
			else if (GClass7.smethod_0().string_1.Equals((GClass192.int_0 == 0) ? "Nhập giới hạn HP quái" : "Fill mob HP limited"))
			{
				method_3($"/mobhp{int.Parse(GClass7.smethod_0().gclass67_0.method_21())}");
				method_0();
			}
			method_0();
		}

		public void method_1(string text)
		{
			GClass7.smethod_0().string_1 = text;
			GClass7.smethod_0().gclass67_0.string_7 = mResources.CHAT;
			GClass39.gclass45_0.bool_0 = false;
			GClass7.smethod_0().method_5(smethod_0(), string.Empty);
		}

		public void perform(int idAction, object p)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			if (idAction <= 101107)
			{
				if (idAction != 10000)
				{
					switch (idAction)
					{
					case 101101:
					{
						GClass63 gClass3 = new GClass63();
						List<int> list = new List<int>();
						for (int j = 0; j < GClass154.gclass63_9.method_2(); j++)
						{
							GClass85 gClass4 = (GClass85)GClass154.gclass63_9.method_3(j);
							if (!list.Contains(gClass4.method_16().sbyte_0))
							{
								string text = ((!list_1.Contains(gClass4.method_16().sbyte_0)) ? ((GClass192.int_0 == 0) ? "CHƯA CÓ" : "HADN'T") : ((GClass192.int_0 == 0) ? "ĐÃ CÓ" : "HAD"));
								list.Add(gClass4.method_16().sbyte_0);
								gClass3.method_0(new GClass14(gClass4.method_16().string_0 + "\n" + text, this, 170202, gClass4));
							}
						}
						GClass39.gclass0_0.method_2(gClass3, 0);
						break;
					}
					case 101102:
					{
						GClass63 gClass = new GClass63();
						for (int i = 0; i < GClass58.smethod_1().gclass109_0.gclass53_0.Length; i++)
						{
							GClass53 gClass2 = GClass58.smethod_1().gclass109_0.gclass53_0[i];
							if (gClass2 != null)
								gClass.method_0(new GClass14(string.Concat(str2: (!list_2.Contains(gClass2.sbyte_0)) ? ((GClass192.int_0 == 0) ? "CHƯA CÓ" : "HADN'T") : ((GClass192.int_0 == 0) ? "ĐÃ CÓ" : "HAD"), str0: gClass2.string_0, str1: "\n"), this, 170203, gClass2));
						}
						GClass39.gclass0_0.method_2(gClass, 0);
						break;
					}
					case 101103:
						if (int_0 == 0)
						{
							int_0 = 1;
							GClass188.smethod_1((GClass192.int_0 == 0) ? "Chuyển sang chế độ THƯỜNG!" : "Change to mode normal", 0);
						}
						else
						{
							int_0 = 0;
							GClass188.smethod_1((GClass192.int_0 == 0) ? "Chuyển sang chế độ ĐẶC BIỆT!" : "Change to mode special", 0);
						}
						break;
					case 101104:
						smethod_0().method_1((GClass192.int_0 == 0) ? "Nhập giới hạn HP quái" : "Fill mob HP limited");
						break;
					case 101105:
						method_3("/mclear");
						break;
					case 101106:
						bool_2 = !bool_2;
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Dừng đánh quái theo TĐLt của game: " + GClass193.smethod_0().method_6(bool_2)) : ("Stop attack with game autotrain: " + GClass193.smethod_0().method_6(bool_2)), 0);
						break;
					case 101107:
						GClass166.smethod_0().method_78("/vdh");
						break;
					}
				}
				else
				{
					GClass63 gClass5 = new GClass63();
					gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "D/s quái\nTrong map" : "List mob\nIn Map", this, 101101, null));
					gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "D/s skill\ndùng khi\nđồ sát" : "List skill\nUse when\nmurdering mob", this, 101102, null));
					gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? ("Chế độ\nĐánh quái:\n" + ((int_0 == 0) ? "Đặc biệt" : "Đấm thường")) : ("Mode\nTrain:\n" + ((int_0 == 0) ? "Special" : "Normal")), this, 101103, null));
					gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? ("Giới hạn\nHP Quái:\n" + ((int_1 == 0) ? "KO GIỚI HẠN" : GClass95.smethod_9(int_1))) : ("LIMITED\nMOB HP:\n" + ((int_1 == 0) ? "UNLIMITED" : GClass95.smethod_9(int_1))), this, 101104, null));
					if (list_1.Count > 0)
						gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? "Xóa d/s\nloại quái\nđồ sát" : "Delete list\nType-Mob\nMurdering", this, 101105, null));
					gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? ("Dừng TĐLT\ncủa game:\n" + GClass193.smethod_0().method_7(bool_2)) : ("Stop game\nAuto Train:\n" + GClass193.smethod_0().method_7(bool_2)), this, 101106, null));
					gClass5.method_0(new GClass14((GClass192.int_0 == 0) ? ("Di chuyển\nvượt địa hình:\n" + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_5)) : ("Move cross\nTerrain:\n" + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_5)), this, 101107, null));
					GClass39.gclass0_0.method_2(gClass5, 0);
				}
			}
			else if (idAction != 170202)
			{
				if (idAction == 170203)
				{
					GClass53 gClass6 = (GClass53)p;
					if (list_2.Contains(gClass6.sbyte_0))
					{
						list_2.Remove(gClass6.sbyte_0);
						GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? ("Đã xóa skill " + gClass6.string_0) : ("Deleted skill " + gClass6.string_0), 0);
					}
					else
					{
						list_2.Add(gClass6.sbyte_0);
						GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? ("Đã thêm skill " + gClass6.string_0) : ("Added skill " + gClass6.string_0), 0);
					}
				}
			}
			else
			{
				GClass85 gClass7 = (GClass85)p;
				if (list_1.Contains(gClass7.method_16().sbyte_0))
				{
					list_1.Remove(gClass7.method_16().sbyte_0);
					GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? ("Đã xóa mob " + gClass7.method_16().string_0) : ("Deleted mob " + gClass7.method_16().string_0), 0);
				}
				else
				{
					list_1.Add(gClass7.method_16().sbyte_0);
					GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? ("Đã thêm mob " + gClass7.method_16().string_0) : ("Added mob " + gClass7.method_16().string_0), 0);
				}
			}
		}

		public bool method_2(int asciiCode)
		{
			if (asciiCode != 110)
			{
				if (asciiCode != 116)
					return false;
				if (!GClass177.smethod_0().method_5())
					smethod_0().method_3("/dsq");
				else
					GClass177.smethod_0().method_17();
			}
			else
				smethod_0().method_3("/anhat");
			return true;
		}

		public bool method_3(string text)
		{
			switch (text)
			{
			case "/dsq":
				smethod_0().bool_0 = !smethod_0().bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đồ sát quái: " + GClass193.smethod_0().method_6(smethod_0().bool_0)) : ("Murdering mob: " + GClass193.smethod_0().method_6(smethod_0().bool_0)), 0);
				goto IL_0a2b;
			case "/abf":
				if (int_3 == 0 && int_4 == 0)
					GClass188.smethod_1((GClass192.int_0 == 0) ? "Tự động sử dụng đậu thần: Tắt" : "Auto use bean: Off", 0);
				else
				{
					int_3 = 20;
					int_4 = 20;
					GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động sử dụng đậu thần khi HP dưới {int_3}%, MP dưới {int_4}%" : $"Auto use bean when HP lower than {int_3}%, MP lower than {int_4}%", 0);
				}
				goto IL_0a2b;
			case "/psq":
				smethod_0().bool_3 = !smethod_0().bool_3;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Chỉ đánh siêu quái: " + GClass193.smethod_0().method_6(smethod_0().bool_3)) : ("Only attack super mob: " + GClass193.smethod_0().method_6(smethod_0().bool_3)), 0);
				goto IL_0a2b;
			case "/nsq":
				smethod_0().bool_4 = !smethod_0().bool_4;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Né siêu quái: " + GClass193.smethod_0().method_6(smethod_0().bool_4)) : ("Only attack normal mob: " + GClass193.smethod_0().method_6(smethod_0().bool_4)), 0);
				goto IL_0a2b;
			case "/sadd":
				method_7("skill", "id", -1);
				goto IL_0a2b;
			case "/madd":
				method_7("mob", "id", -1);
				goto IL_0a2b;
			case "/iadd":
				method_7("item", "id", -1);
				goto IL_0a2b;
			case "/maddt":
				method_7("mob", "type", -1);
				goto IL_0a2b;
			case "/iaddt":
				method_7("item", "type", -1);
				goto IL_0a2b;
			case "/anhat":
				smethod_0().bool_5 = !smethod_0().bool_5;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động nhặt item: " + GClass193.smethod_0().method_6(smethod_0().bool_5)) : ("Auto pickup item: " + GClass193.smethod_0().method_6(smethod_0().bool_5)), 0);
				goto IL_0a2b;
			case "/sclear":
				list_2.Clear();
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Danh sách skill đồ sát quái đã được đặt về mặc định" : "List skill murdering set to default", 0);
				goto IL_0a2b;
			case "/mclear":
				list_0.Clear();
				list_1.Clear();
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Danh sách quái đồ sát đã được đặt về mặc định" : "List mob murdering set to default", 0);
				goto IL_0a2b;
			case "/iclear":
				list_4.Clear();
				list_6.Clear();
				list_4.Clear();
				list_6.Clear();
				list_4.AddRange(short_0);
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Danh sách nhặt item đã được đặt về mặc định" : "List item pick-up set to default", 0);
				goto IL_0a2b;
			case "/itemme":
				smethod_0().bool_6 = !smethod_0().bool_6;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Chỉ nhặt item của mình: " + GClass193.smethod_0().method_6(smethod_0().bool_6)) : ("Only pickup my item: " + GClass193.smethod_0().method_6(smethod_0().bool_6)), 0);
				goto IL_0a2b;
			case "/pem1hit":
				smethod_0().bool_1 = !smethod_0().bool_1;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đồ sát quái còn 1HP: " + GClass193.smethod_0().method_6(smethod_0().bool_1)) : ("Attack mob to 1 HP: " + GClass193.smethod_0().method_6(smethod_0().bool_1)), 0);
				goto IL_0a2b;
			default:
				{
					if (GClass193.smethod_0().method_10<int>(text, "/iadd"))
						method_7("item", "id", GClass193.smethod_0().method_11<int>(text, "/iadd"));
					else if (GClass193.smethod_0().method_10<int>(text, "/madd"))
					{
						method_7("mob", "id", GClass193.smethod_0().method_11<int>(text, "/madd"));
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/iaddt"))
					{
						method_7("item", "type", GClass193.smethod_0().method_11<int>(text, "/iaddt"));
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/maddt"))
					{
						method_7("mob", "type", GClass193.smethod_0().method_11<int>(text, "/maddt"));
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/sadd"))
					{
						method_7("skill", "id", GClass193.smethod_0().method_11<int>(text, "/sadd"));
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/sln"))
					{
						int_2 = GClass193.smethod_0().method_11<int>(text, "/sln");
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Giới hạn số lần nhặt {int_2}" : $"Limit time pick {int_2}", 0);
					}
					else if (GClass193.smethod_0().method_10<short>(text, "/iblock"))
					{
						short num = GClass193.smethod_0().method_11<short>(text, "/iblock");
						if (list_4.Contains(num))
						{
							list_4.Remove(num);
							GClass188.smethod_1((GClass192.int_0 == 0) ? ("Xóa " + GClass83.smethod_1(num).string_0 + " khỏi d/s không nhặt item theo ID") : ("Deleted " + GClass83.smethod_1(num).string_0 + " from list don't pick up by ID"), 0);
						}
						else
						{
							list_4.Add(num);
							GClass188.smethod_1((GClass192.int_0 == 0) ? ("Thêm " + GClass83.smethod_1(num).string_0 + " khỏi d/s không nhặt item theo ID") : ("Added " + GClass83.smethod_1(num).string_0 + " to list don't pick up by ID"), 0);
						}
					}
					else if (GClass193.smethod_0().method_10<sbyte>(text, "/iblockt"))
					{
						sbyte b = GClass193.smethod_0().method_11<sbyte>(text, "/iblockt");
						if (list_6.Contains(b))
						{
							list_6.Remove(b);
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Xóa item [{b}] khỏi d/s không nhặt item theo loại" : $"Deleted [{b}] from list don't pick up by Type", 0);
						}
						else
						{
							list_6.Add(b);
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Thêm item [{b}] vào d/s không nhặt item theo loại" : $"Added [{b}] to list don't pick up by Type", 0);
						}
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/abf"))
					{
						int_3 = GClass193.smethod_0().method_11<int>(text, "/abf");
						int_4 = 0;
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động sử dụng đậu thần khi HP dưới {int_3}%" : $"Auto use bean when HP lower than {int_3}%", 0);
					}
					else if (GClass193.smethod_0().method_9<int>(text, "/abf", 2))
					{
						int[] array = GClass193.smethod_0().method_8<int>(text, "/abf", 2);
						int_3 = array[0];
						int_4 = array[1];
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động sử dụng đậu thần khi HP dưới {int_3}%, MP dưới {int_4}%" : $"Auto use bean when HP lower than {int_3}%, MP lower than {int_4}%", 0);
					}
					else
					{
						if (!GClass193.smethod_0().method_10<int>(text, "/mobhp"))
							return false;
						int_1 = GClass193.smethod_0().method_11<int>(text, "/mobhp");
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Cài đặt chỉ đánh quái dưới " + GClass95.smethod_9(int_1) + " HP") : ("Only attack mob lower than " + GClass95.smethod_9(int_1) + " HP"), 0);
					}
					goto IL_0a2b;
				}
				IL_0a2b:
				return true;
			}
		}

		public static void smethod_1(GClass76 g)
		{
		}

		public bool method_4(GClass134 itemMap)
		{
			return itemMap.gclass118_0.short_0 == 76 || itemMap.gclass118_0.short_0 == 188 || itemMap.gclass118_0.short_0 == 189 || itemMap.gclass118_0.short_0 == 190;
		}

		public void method_5()
		{
			if (GClass1.int_37 != 126)
				return;
			for (int i = 0; i < GClass154.gclass63_6.method_2(); i++)
			{
				if (GClass154.gclass63_6.method_3(i) is GClass134 itemMap && method_4(itemMap))
					GClass154.gclass63_6.method_7(i);
			}
		}

		public void method_6()
		{
			method_5();
			if (!GClass171.smethod_0().bool_0)
				method_10();
		}

		public void method_7(string obj, string type, int index)
		{
			if (!(type == "id"))
			{
				if (!(type == "type"))
					return;
				if (!(obj == "mob"))
				{
					if (!(obj == "item"))
						return;
					if (index != -1)
					{
						if (list_5.Contains((sbyte)index))
						{
							list_5.Remove((sbyte)index);
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa item {GClass83.smethod_1((short)index).string_0}[{index}]" : $"Deleted item {GClass83.smethod_1((short)index).string_0}[{index}]", 0);
						}
						else
						{
							list_5.Add((sbyte)index);
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm item {GClass83.smethod_1((short)index).string_0}[{index}]" : $"Added item {GClass83.smethod_1((short)index).string_0}[{index}]", 0);
						}
					}
					else if (GClass58.smethod_1().gclass134_0 != null)
					{
						GClass134 gclass134_ = GClass58.smethod_1().gclass134_0;
						if (list_5.Contains(gclass134_.gclass118_0.sbyte_0))
						{
							list_5.Remove(gclass134_.gclass118_0.sbyte_0);
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa item {gclass134_.gclass118_0.string_0}[{gclass134_.gclass118_0.sbyte_0}]" : $"Deleted item {gclass134_.gclass118_0.string_0}[{gclass134_.gclass118_0.sbyte_0}]", 0);
						}
						else
						{
							list_5.Add(gclass134_.gclass118_0.sbyte_0);
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm item {gclass134_.gclass118_0.string_0}[{gclass134_.gclass118_0.sbyte_0}]" : $"Added item {gclass134_.gclass118_0.string_0}[{gclass134_.gclass118_0.sbyte_0}]", 0);
						}
					}
				}
				else if (index != -1)
				{
					if (list_1.Contains(index))
					{
						list_1.Remove(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã xóa loại quái [" + GClass85.gclass204_0[index].string_0 + "]") : ("Deleted type-mob [" + GClass85.gclass204_0[index].string_0 + "]"), 0);
					}
					else
					{
						list_1.Add(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm loại quái [" + GClass85.gclass204_0[index].string_0 + "]") : ("Added type-mob [" + GClass85.gclass204_0[index].string_0 + "]"), 0);
					}
				}
				else if (GClass58.smethod_1().gclass85_0 != null)
				{
					GClass85 gclass85_ = GClass58.smethod_1().gclass85_0;
					if (list_1.Contains(gclass85_.int_26))
					{
						list_1.Remove(gclass85_.int_26);
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã xóa loại quái [" + gclass85_.method_16().string_0 + "]") : ("Deleted type-mob [" + gclass85_.method_16().string_0 + "]"), 0);
					}
					else
					{
						list_1.Add(gclass85_.int_26);
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm loại quái [" + gclass85_.method_16().string_0 + "]") : ("Added type-mob [" + gclass85_.method_16().string_0 + "]"), 0);
					}
				}
				return;
			}
			switch (obj)
			{
			case "skill":
				if (index != -1)
				{
					GClass53 gClass = GClass58.smethod_1().gclass109_0.gclass53_0[index - 1];
					if (list_2.Contains(gClass.sbyte_0))
					{
						list_2.Remove(gClass.sbyte_0);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa skill {gClass.string_0}[{gClass.sbyte_0}]" : $"Deleted skill {gClass.string_0}[{gClass.sbyte_0}]", 0);
					}
					else
					{
						list_2.Add(gClass.sbyte_0);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm skill {gClass.string_0}[{gClass.sbyte_0}]" : $"Added skill {gClass.string_0}[{gClass.sbyte_0}]", 0);
					}
				}
				else if (GClass58.smethod_1().gclass74_0 != null)
				{
					GClass53 gclass53_ = GClass58.smethod_1().gclass74_0.gclass53_0;
					if (list_2.Contains(gclass53_.sbyte_0))
					{
						list_2.Remove(gclass53_.sbyte_0);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa skill {gclass53_.string_0}[{gclass53_.sbyte_0}]" : $"Deleted skill {gclass53_.string_0}[{gclass53_.sbyte_0}]", 0);
					}
					else
					{
						list_2.Add(gclass53_.sbyte_0);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm skill {gclass53_.string_0}[{gclass53_.sbyte_0}]" : $"Added skill {gclass53_.string_0}[{gclass53_.sbyte_0}]", 0);
					}
				}
				break;
			case "item":
				if (index != -1)
				{
					if (list_3.Contains((short)index))
					{
						list_3.Remove((short)index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã xóa item [" + GClass83.smethod_1((short)index).string_0 + "]") : ("Deleted item [" + GClass83.smethod_1((short)index).string_0 + "]"), 0);
					}
					else
					{
						list_3.Add((short)index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đã thêm item [" + GClass83.smethod_1((short)index).string_0 + "]") : ("Added item [" + GClass83.smethod_1((short)index).string_0 + "]"), 0);
					}
				}
				else if (GClass58.smethod_1().gclass134_0 != null)
				{
					GClass134 gclass134_2 = GClass58.smethod_1().gclass134_0;
					if (list_3.Contains(gclass134_2.gclass118_0.short_0))
					{
						list_3.Remove(gclass134_2.gclass118_0.short_0);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa item [{gclass134_2.gclass118_0.short_0}]" : $"Deleted item [{gclass134_2.gclass118_0.short_0}]", 0);
					}
					else
					{
						list_3.Add(gclass134_2.gclass118_0.short_0);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm item [{gclass134_2.gclass118_0.short_0}]" : $"Added item [{gclass134_2.gclass118_0.short_0}]", 0);
					}
				}
				break;
			case "mob":
				if (index != -1)
				{
					if (list_0.Contains(index))
					{
						list_0.Remove(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa vị trí {index}" : $"Deleted position {index}", 0);
					}
					else
					{
						list_0.Add(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm vị trí {index}" : $"Added position {index}", 0);
					}
				}
				else if (GClass58.smethod_1().gclass85_0 != null)
				{
					GClass85 gclass85_2 = GClass58.smethod_1().gclass85_0;
					if (list_0.Contains(gclass85_2.int_25))
					{
						list_0.Remove(gclass85_2.int_25);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa vị trí {gclass85_2.int_25}" : $"Deleted mob position {gclass85_2.int_25}", 0);
					}
					else
					{
						list_0.Add(gclass85_2.int_25);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm vị trí {gclass85_2.int_25}" : $"Added mob position {gclass85_2.int_25}", 0);
					}
				}
				break;
			}
		}

		public void method_8(object obj)
		{
			GClass85 gClass = (GClass85)obj;
			if (gClass.int_12 != 1 && gClass.int_12 != 0)
			{
				gClass.long_0 = GClass138.smethod_18();
				gClass.int_0++;
				if (gClass.int_0 > 10)
					gClass.int_0 = 0;
			}
		}

		public void method_9(GClass85 mob)
		{
			if (mob.sbyte_14 != 0)
				mob.int_0 = 0;
		}

		public static void smethod_2(int time)
		{
			bool_9 = true;
			long_0 = GClass138.smethod_18();
			long_1 = time;
		}

		public static bool smethod_3()
		{
			if (bool_9 && GClass138.smethod_18() - long_0 >= long_1)
				bool_9 = false;
			return bool_9;
		}

		public void method_10()
		{
			if ((GClass183.smethod_0().bool_5 && !GClass183.smethod_0().bool_6) || (GClass183.smethod_0().bool_7 && !GClass183.smethod_0().bool_8) || (GClass183.smethod_0().bool_3 && GClass183.smethod_0().method_19() > 0))
				return;
			if (GClass196.smethod_0().bool_2)
			{
				for (int i = 0; i < GClass154.gclass74_0.Length; i++)
				{
					GClass74 gClass = GClass154.gclass74_0[i];
					if (gClass != null && gClass.gclass53_0.sbyte_0.Equals(GClass196.smethod_0().int_0[GClass58.smethod_1().int_14]) && GClass138.smethod_18() - gClass.long_1 > gClass.int_1 + 500)
						return;
				}
			}
			try
			{
				if (smethod_3())
					return;
				GClass58 gClass2 = GClass58.smethod_1();
				if (gClass2.int_11 == 14 || gClass2.int_25 <= 0)
					return;
				if (((gClass2.int_25 <= gClass2.int_35 * int_3 / 100 && int_3 != 0) || (gClass2.int_24 <= gClass2.int_36 * int_4 / 100 && int_4 != 0)) && GClass138.smethod_18() - long_3 > 9000L)
				{
					GClass154.smethod_8().method_50();
					long_3 = GClass138.smethod_18();
				}
				bool flag;
				bool flag2 = (flag = GClass82.smethod_0(4387)) && bool_0;
				if (smethod_0().bool_5 && !flag2 && !GClass177.smethod_0().method_5())
				{
					if (GClass1.int_37 == GClass58.smethod_1().int_14 + 21 && GClass154.gclass63_6.method_2() > 0)
					{
						GClass166.smethod_0().method_74(-1);
						smethod_2(1000);
						return;
					}
					int_2 = (smethod_0().bool_6 ? 2 : 100);
					if (bool_8)
					{
						if (int_5 >= list_7.Count)
						{
							bool_8 = false;
							return;
						}
						GClass134 gClass3 = list_7[int_5];
						switch (method_12(gClass3))
						{
						case GEnum2.const_0:
							int_5++;
							return;
						case GEnum2.const_1:
							GClass166.smethod_0().method_44();
							GClass166.smethod_0().method_74(gClass3.int_9);
							gClass3.int_0++;
							smethod_2(500);
							int_5++;
							return;
						case GEnum2.const_2:
							gClass2.int_4 = gClass3.int_3;
							gClass2.int_5 = gClass3.int_4;
							GClass166.smethod_0().method_44();
							GClass166.smethod_0().method_74(gClass3.int_9);
							gClass3.int_0++;
							int_5++;
							smethod_2(100);
							return;
						case GEnum2.const_3:
							method_11(gClass3.int_3, gClass3.int_4);
							gClass2.gclass85_0 = null;
							gClass3.int_0++;
							smethod_2(500);
							return;
						}
					}
					list_7.Clear();
					int_5 = 0;
					for (int j = 0; j < GClass154.gclass63_6.method_2(); j++)
					{
						GClass134 gClass4 = (GClass134)GClass154.gclass63_6.method_3(j);
						if (method_12(gClass4) != 0)
							list_7.Add(gClass4);
					}
					if (list_7.Count > 0)
					{
						bool_8 = true;
						return;
					}
				}
				if (!smethod_0().bool_0)
					return;
				if (gClass2.bool_23)
				{
					smethod_2(500);
					return;
				}
				gClass2.method_102(0);
				if (gClass2.gclass85_0 != null && !method_16(gClass2.gclass85_0))
					gClass2.gclass85_0 = null;
				if (gClass2.gclass85_0 == null)
				{
					gClass2.gclass85_0 = method_14();
					if (flag && gClass2.gclass85_0 != null)
					{
						GClass58.smethod_1().int_4 = gClass2.gclass85_0.int_16 - 24;
						GClass58.smethod_1().int_5 = gClass2.gclass85_0.int_17;
						GClass166.smethod_0().method_44();
					}
				}
				if (gClass2.gclass85_0 != null)
				{
					if (gClass2.method_74() == null)
					{
						GClass74 gClass5 = method_19();
						if (gClass5 != null && !gClass5.bool_0)
						{
							GClass85 gclass85_ = gClass2.gclass85_0;
							gclass85_.int_8 = gclass85_.int_16;
							gclass85_.int_9 = gclass85_.int_17;
							if (GClass58.smethod_1().gclass74_0 != gClass5 || GClass58.smethod_1().int_11 == 5 || GClass58.smethod_1().gclass74_0.gclass53_0.int_3 == 3 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 10 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 11 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 20)
								GClass154.smethod_8().method_62(gClass5, false);
							if (GClass191.smethod_0().bool_3)
							{
								if (GClass58.smethod_1().int_20 < 2000)
									GClass196.smethod_0().method_13();
								return;
							}
							bool flag3 = GClass56.smethod_24(gclass85_.int_16, gclass85_.int_17, gClass2.int_4, gClass2.int_5) > 48;
							bool flag4 = GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 20;
							if (flag3)
							{
								if (flag4)
									GClass196.smethod_0().method_13();
								else if (flag)
								{
									if (GClass138.smethod_18() - long_2 > 500L && GClass58.smethod_1().int_11 == 1)
									{
										GClass58.smethod_1().int_4 = gclass85_.int_16 - 24;
										GClass58.smethod_1().int_5 = gclass85_.int_17;
										GClass166.smethod_0().method_44();
										long_2 = GClass138.smethod_18();
									}
								}
								else
								{
									method_11(gclass85_.int_16, gclass85_.int_17);
								}
								return;
							}
							if (smethod_0().bool_1 && gclass85_.int_6 <= 1)
								return;
							if (int_0 != 0)
							{
								GClass154.smethod_8().method_62(gClass5, true);
								if (GClass56.smethod_24(gclass85_.int_16, gclass85_.int_17, gClass2.int_4, gClass2.int_5) <= 48)
									GClass154.smethod_8().method_44(gclass85_);
								return;
							}
							if (GClass58.smethod_1().int_11 == 5 || GClass58.smethod_1().gclass74_0.gclass53_0.int_3 == 3 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 10 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 11)
								GClass154.smethod_8().method_64(gClass5);
							if (GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 != 20 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 20)
								GClass196.smethod_0().method_13();
						}
					}
				}
				else if (!flag)
				{
					GClass85 gClass6 = method_15();
					if (gClass6 != null)
						method_11(gClass6.int_16 - 24, gClass6.int_17);
				}
				smethod_2(100);
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/startMurderingMob.txt", ex.ToString());
			}
		}

		public void method_11(int x, int y)
		{
			GClass58 gClass = GClass58.smethod_1();
			if (!GClass175.smethod_0().bool_5)
			{
				gClass.gclass136_0 = new GClass136(x, y);
				return;
			}
			int[] array = method_24(gClass.int_4, x);
			if (array[1] >= y || (array[1] >= gClass.int_5 && (gClass.int_11 == 2 || gClass.int_11 == 1)))
			{
				array[0] = x;
				array[1] = y;
			}
			gClass.gclass136_0 = new GClass136(array[0], array[1]);
		}

		public GEnum2 method_12(GClass134 itemMap)
		{
			GClass58 gClass = GClass58.smethod_1();
			bool flag = itemMap.int_8 == gClass.int_13 || itemMap.int_8 == -1;
			if (smethod_0().bool_6 && !flag)
				return GEnum2.const_0;
			if (smethod_0().bool_7 && itemMap.int_0 > int_2)
				return GEnum2.const_0;
			if (!method_13(itemMap))
				return GEnum2.const_0;
			if (GClass56.smethod_28(gClass.int_4 - itemMap.int_3) < 60 && GClass56.smethod_28(gClass.int_5 - itemMap.int_4) < 60)
				return GEnum2.const_1;
			if (GClass82.smethod_0(4387))
				return GEnum2.const_2;
			if (smethod_0().bool_0)
				return GEnum2.const_3;
			return GEnum2.const_0;
		}

		public bool method_13(GClass134 itemMap)
		{
			if (list_3.Count != 0 && !list_3.Contains(itemMap.gclass118_0.short_0))
				return false;
			if (list_4.Count != 0 && list_4.Contains(itemMap.gclass118_0.short_0))
				return false;
			if (list_5.Count != 0 && !list_5.Contains(itemMap.gclass118_0.sbyte_0))
				return false;
			if (list_6.Count != 0 && list_6.Contains(itemMap.gclass118_0.sbyte_0))
				return false;
			return true;
		}

		public GClass85 method_14()
		{
			GClass85 result = null;
			int num = int.MaxValue;
			GClass58 gClass = GClass58.smethod_1();
			for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
			{
				GClass85 gClass2 = (GClass85)GClass154.gclass63_9.method_3(i);
				int num2 = (gClass2.int_16 - gClass.int_4) * (gClass2.int_16 - gClass.int_4) + (gClass2.int_17 - gClass.int_5) * (gClass2.int_17 - gClass.int_5);
				if (method_16(gClass2) && num2 < num && smethod_0().int_1 == 0)
				{
					result = gClass2;
					num = num2;
				}
				else if (method_16(gClass2) && num2 < num && smethod_0().int_1 != 0 && smethod_0().int_1 >= gClass2.int_6)
				{
					result = gClass2;
					num = num2;
				}
			}
			return result;
		}

		public GClass85 method_15()
		{
			GClass85 result = null;
			long num = GClass138.smethod_18();
			for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
			{
				GClass85 gClass = (GClass85)GClass154.gclass63_9.method_3(i);
				if (method_17(gClass) && gClass.long_0 < num)
				{
					result = gClass;
					num = gClass.long_0;
				}
			}
			return result;
		}

		public bool method_16(GClass85 mob)
		{
			if (mob.int_12 == 0 || mob.int_12 == 1 || mob.int_6 <= 0 || mob.bool_13)
				return false;
			if (mob.sbyte_14 != 0 && smethod_0().bool_4)
				return false;
			if (mob.sbyte_14 == 0 && smethod_0().bool_3)
				return false;
			if (!method_18(mob))
				return false;
			if (smethod_0().int_1 != 0 && smethod_0().int_1 < mob.int_6)
				return false;
			return true;
		}

		public bool method_17(GClass85 mob)
		{
			if (mob.bool_13)
				return false;
			if (!method_18(mob))
				return false;
			if (smethod_0().bool_4 && !GClass82.smethod_0(4387) && mob.method_16().int_0 >= 3000)
			{
				if (mob.sbyte_14 != 0)
				{
					GClass85 gClass = null;
					bool flag = false;
					for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
					{
						gClass = (GClass85)GClass154.gclass63_9.method_3(i);
						if (gClass.int_0 == 10 && (gClass.int_12 == 0 || gClass.int_12 == 1))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
						return false;
					mob.long_0 = gClass.long_0;
				}
				else if (mob.int_0 == 10 && (mob.int_12 == 0 || mob.int_12 == 1))
				{
					return false;
				}
			}
			return true;
		}

		public bool method_18(GClass85 mob)
		{
			if (list_0.Count != 0 && !list_0.Contains(mob.int_25))
				return false;
			if (list_1.Count != 0 && !list_1.Contains(mob.int_26))
				return false;
			return true;
		}

		public GClass74 method_19()
		{
			GClass74 gClass = null;
			GClass53 gClass2 = new GClass53();
			foreach (sbyte item in list_2)
			{
				gClass2.sbyte_0 = item;
				GClass74 gClass3 = GClass58.smethod_1().method_15(gClass2);
				if (method_20(gClass3, gClass))
					gClass = gClass3;
			}
			return gClass;
		}

		public bool method_20(GClass74 SkillBetter, GClass74 skill)
		{
			if (SkillBetter == null)
				return false;
			if (!method_21(SkillBetter))
				return false;
			bool flag = (SkillBetter.gclass53_0.sbyte_0 == 17 && skill.gclass53_0.sbyte_0 == 2) || (SkillBetter.gclass53_0.sbyte_0 == 9 && skill.gclass53_0.sbyte_0 == 0);
			if (skill != null && skill.int_1 >= SkillBetter.int_1 && !flag)
				return false;
			return true;
		}

		public bool method_21(GClass74 skill)
		{
			if (GClass138.smethod_18() - skill.long_1 > skill.int_1)
				skill.bool_0 = false;
			if (skill.bool_0 && !sbyte_1.Contains(skill.gclass53_0.sbyte_0))
				return false;
			if (sbyte_2.Contains(skill.gclass53_0.sbyte_0))
				return false;
			if (GClass58.smethod_1().int_24 < method_22(skill))
				return false;
			return true;
		}

		public int method_22(GClass74 skill)
		{
			if (skill.gclass53_0.int_2 == 2)
				return 1;
			if (skill.gclass53_0.int_2 == 1)
				return skill.int_5 * GClass58.smethod_1().int_36 / 100;
			return skill.int_5;
		}

		public int method_23(int xsd)
		{
			GClass58 gClass = GClass58.smethod_1();
			int num = GClass1.int_24;
			int result = -1;
			for (int i = 24; i < GClass1.int_24; i += 24)
			{
				if (GClass1.smethod_27(xsd, i, 2))
				{
					int num2 = GClass56.smethod_28(i - gClass.int_5);
					if (num2 < num)
					{
						num = num2;
						result = i;
					}
				}
			}
			return result;
		}

		public int[] method_24(int xStart, int xEnd)
		{
			int num = GClass1.int_24;
			int num2 = -1;
			if (xStart > xEnd)
			{
				for (int i = xEnd; i < xStart; i += 24)
				{
					int num3 = method_23(i);
					if (num3 < num)
					{
						num = num3;
						num2 = i;
					}
				}
			}
			else
			{
				for (int num4 = xEnd; num4 > xStart; num4 -= 24)
				{
					int num5 = method_23(num4);
					if (num5 < num)
					{
						num = num5;
						num2 = num4;
					}
				}
			}
			return new int[2] { num2, num };
		}
	}
}
