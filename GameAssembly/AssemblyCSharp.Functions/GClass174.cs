using System.Collections.Generic;
using System.Text;

namespace AssemblyCSharp.Functions
{
	public class GClass174
	{
		private bool bool_0;

		private long long_0;

		private long long_1;

		public List<GStruct4> list_0;

		public Dictionary<int, List<GStruct0>> dictionary_0;

		public bool bool_1;

		public bool bool_2;

		private static GClass174 gclass174_0;

		private GClass174()
		{
			list_0 = new List<GStruct4>();
			dictionary_0 = null;
			bool_1 = false;
			bool_2 = false;
		}

		public void method_0(int time)
		{
			bool_0 = true;
			long_0 = GClass203.smethod_18();
			long_1 = time;
		}

		private bool method_1()
		{
			if (bool_0 && GClass203.smethod_18() - long_0 >= long_1)
				bool_0 = false;
			return bool_0;
		}

		public static GClass174 smethod_0()
		{
			return (gclass174_0 != null) ? gclass174_0 : (gclass174_0 = new GClass174());
		}

		public void method_2()
		{
			bool_1 = true;
		}

		public void method_3()
		{
			if (method_1())
				return;
			if (!bool_2)
			{
				method_7();
				if (!smethod_13())
				{
					if (smethod_11())
					{
						Class21.smethod_0().method_21();
						bool_2 = true;
					}
					else
						bool_1 = false;
				}
				else
				{
					Class21.smethod_0().method_22();
					bool_2 = true;
				}
			}
			else if (!method_10())
			{
				method_6();
				bool_2 = false;
				bool_1 = false;
			}
		}

		public void method_4()
		{
			list_0.Clear();
			list_0.Add(new GStruct4((mResources.language != 0) ? "Earth" : "Trái đất", new List<int>
			{
				21, 42, 0, 1, 2, 3, 4, 5, 112, 6,
				27, 28, 29, 30, 47, 46, 45, 48, 50, 111,
				146, 24, 84
			}));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Namếc" : "Namek", new List<int>
			{
				22, 43, 7, 8, 9, 11, 12, 13, 10, 31,
				32, 33, 34, 25, 84
			}));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Xayda" : "Sayda", new List<int>
			{
				23, 52, 113, 129, 44, 14, 15, 16, 17, 18,
				20, 19, 35, 36, 37, 38, 26, 84, 104
			}));
			list_0.Add(new GStruct4((mResources.language != 0) ? "Yardart Planet" : "Hành tinh Yardart", new List<int> { 131, 132, 133 }));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Fide" : "Frieza", new List<int>
			{
				68, 69, 70, 71, 72, 64, 65, 63, 66, 67,
				73, 74, 75, 76, 77, 81, 82, 83, 79, 80
			}));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Hành tinh băng giá" : "Cold Planet", new List<int> { 109, 108, 107, 110, 106, 105 }));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Tương lai" : "Future", new List<int> { 102, 92, 93, 94, 96, 97, 98, 99, 100, 103 }));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Ngọc rồng sao đen" : "Black Star Dragon Balls", new List<int> { 85, 86, 87, 88, 89, 90, 91 }));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Khu vực bang hội" : "Clan Area", new List<int> { 153, 156, 157, 158, 159 }));
			list_0.Add(new GStruct4((mResources.language != 0) ? "Plant Planet" : "Hành tinh thực vật", new List<int> { 160, 161, 162, 163 }));
			list_0.Add(new GStruct4((mResources.language != 0) ? "Potaufeu Planet" : "Hành tinh Potaufeu", new List<int> { 139, 140 }));
			list_0.Add(new GStruct4((mResources.language != 0) ? "Prison Planet" : "Hành tinh ngục tù", new List<int> { 154, 155, 166 }));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Khí Gas hủy diệt" : "Destron Gas", new List<int> { 149, 147, 152, 151, 148 }));
			list_0.Add(new GStruct4((mResources.language != 0) ? "Red Ribbon Army" : "Doanh trại độc nhãn", new List<int> { 53, 58, 59, 60, 61, 62, 56, 54, 57 }));
			list_0.Add(new GStruct4((mResources.language != 0) ? "Undersea Treasure" : "Kho báu dưới biến", new List<int> { 135, 138, 136, 137 }));
			list_0.Add(new GStruct4((mResources.language != 0) ? "Snake Way" : "Con đường rắn độc", new List<int> { 143, 142, 141, 144 }));
			list_0.Add(new GStruct4((mResources.language == 0) ? "Sự kiện giỗ tổ Hùng Vương" : "Bear King Event", new List<int> { 176, 177 }));
			method_5();
		}

		private void method_5()
		{
			int int_ = GClass78.smethod_1().int_14;
			foreach (GStruct4 item in list_0)
			{
				int num = int_;
				if (num == 0)
				{
					item.list_0.Remove(22);
					item.list_0.Remove(23);
				}
				else if (num != 1)
				{
					item.list_0.Remove(21);
					item.list_0.Remove(22);
				}
				else
				{
					item.list_0.Remove(21);
					item.list_0.Remove(23);
				}
			}
		}

		private void method_6()
		{
			method_9(GClass20.int_37);
			string[] string_ = GClass73.gclass76_0.string_4;
			for (int i = 0; i < string_.Length; i++)
			{
				int num = smethod_10(string_[i]);
				if (num != -1)
				{
					int[] info = new int[1] { i };
					dictionary_0[GClass20.int_37].Add(new GStruct0(num, GEnum2.const_4, info));
				}
			}
		}

		private void method_7()
		{
			dictionary_0 = new Dictionary<int, List<GStruct0>>();
			method_11();
		}

		public static List<GStruct0> smethod_1(int idMap)
		{
			if (smethod_2(idMap))
				return smethod_0().dictionary_0[idMap];
			return null;
		}

		public static bool smethod_2(int idMap)
		{
			return smethod_0().dictionary_0.ContainsKey(idMap);
		}

		private void method_8(int int_0, int int_1, GEnum2 genum2_0, int[] int_2)
		{
			if (int_0 < 160 || int_0 > 163 || int_1 != 80)
			{
				if (int_1 != 135 || int_0 != 5 || GClass78.smethod_1().sbyte_17 != 0)
				{
					if (int_1 != 135 || int_0 != 5 || GClass78.smethod_1().sbyte_17 == 0)
					{
						if (int_1 != 153 || int_0 != 5)
						{
							if (int_1 != 156 || int_0 != 153)
							{
								if (int_1 >= 85 && int_1 <= 91)
								{
									int_2 = new int[3]
									{
										29,
										0,
										int_1 - 85
									};
									method_9(24 + GClass78.smethod_1().int_14);
									GStruct0 item = new GStruct0(int_1, GEnum2.const_2, int_2);
									dictionary_0[24 + GClass78.smethod_1().int_14].Add(item);
								}
								else
								{
									method_9(int_0);
									dictionary_0[int_0].Add(new GStruct0(int_1, genum2_0, int_2));
								}
							}
							else
							{
								int_2 = new int[2] { 47, 1 };
								method_9(int_0);
								GStruct0 item2 = new GStruct0(int_1, genum2_0, int_2);
								dictionary_0[int_0].Add(item2);
							}
						}
						else
						{
							int_2 = new int[3] { 13, 0, 2 };
							method_9(int_0);
							GStruct0 item3 = new GStruct0(int_1, genum2_0, int_2);
							dictionary_0[int_0].Add(item3);
						}
					}
					else
					{
						int_2 = new int[4] { 13, 0, 3, 2 };
						method_9(int_0);
						GStruct0 item4 = new GStruct0(int_1, genum2_0, int_2);
						dictionary_0[int_0].Add(item4);
					}
				}
				else
				{
					int_2 = new int[4] { 13, 0, 4, 2 };
					method_9(int_0);
					GStruct0 item5 = new GStruct0(int_1, genum2_0, int_2);
					dictionary_0[int_0].Add(item5);
				}
				return;
			}
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass != null && gClass.gclass117_0.short_0 == 992)
				{
					method_9(int_0);
					dictionary_0[int_0].Add(new GStruct0(int_1, genum2_0, int_2));
				}
			}
		}

		private void method_9(int int_0)
		{
			if (!dictionary_0.ContainsKey(int_0))
				dictionary_0.Add(int_0, new List<GStruct0>());
		}

		private bool method_10()
		{
			return !GClass148.smethod_0().bool_2;
		}

		public static int smethod_3(string mapName)
		{
			return int.Parse(mapName.Split(':')[0]);
		}

		public static string smethod_4(GClass45 popUp)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < popUp.string_0.Length; i++)
			{
				stringBuilder.Append(popUp.string_0[i]);
				stringBuilder.Append(" ");
			}
			return stringBuilder.ToString().Trim();
		}

		public static GClass181 smethod_5(int idMap)
		{
			int num = 0;
			GClass181 gClass;
			while (true)
			{
				if (num < GClass20.gclass88_0.method_2())
				{
					gClass = (GClass181)GClass20.gclass88_0.method_3(num);
					if (smethod_4(gClass.gclass45_0).Equals(GClass20.string_2[idMap]))
						break;
					num++;
					continue;
				}
				return null;
			}
			return gClass;
		}

		public static int smethod_6(GClass181 waypoint)
		{
			if (waypoint.short_2 < 60)
				return waypoint.short_0 + 15;
			if (waypoint.short_2 > GClass20.int_23 - 60)
				return waypoint.short_2 - 15;
			return waypoint.short_0 + 15;
		}

		public static int smethod_7(GClass181 waypoint)
		{
			return waypoint.short_3;
		}

		public static bool smethod_8()
		{
			return GClass78.smethod_1().int_11 == 14 || GClass78.smethod_1().int_25 <= 0 || GClass78.smethod_1().bool_62;
		}

		public static bool smethod_9()
		{
			return !GClass78.bool_35 && !GClass78.bool_33 && !GClass12.bool_5;
		}

		public static int smethod_10(string mapName)
		{
			int int_ = GClass78.smethod_1().int_14;
			if (!mapName.Equals((mResources.language == 0) ? "Về nhà" : "Go home"))
			{
				if (!mapName.Equals((mResources.language == 0) ? "Trạm tàu vũ trụ" : "Spaceship station"))
				{
					if (mapName.Contains((mResources.language != 0) ? "Back to:" : "Về chỗ cũ: "))
					{
						mapName = mapName.Replace((mResources.language == 0) ? "Về chỗ cũ: " : "Back to:", "");
						if (Class21.smethod_0().method_6(GClass148.smethod_0().int_0).Equals(mapName))
							return GClass148.smethod_0().int_0;
						if (mapName.Equals((mResources.language == 0) ? "Rừng đá" : "Stone Forest"))
							return -1;
					}
					for (int i = 0; i < GClass20.string_2.Length; i++)
					{
						if (mapName.Equals(Class21.smethod_0().method_6(i)))
							return i;
					}
					return -1;
				}
				return 24 + int_;
			}
			return 21 + int_;
		}

		private static bool smethod_11()
		{
			return !smethod_8() && GClass148.smethod_0().bool_3 && smethod_12();
		}

		private static bool smethod_12()
		{
			GClass128[] gclass128_ = GClass78.smethod_1().gclass128_0;
			int num = 0;
			while (true)
			{
				if (num < gclass128_.Length)
				{
					if (gclass128_[num] != null && gclass128_[num].gclass117_0.short_0 == 193)
						break;
					num++;
					continue;
				}
				return false;
			}
			return true;
		}

		private static bool smethod_13()
		{
			return !smethod_8() && GClass148.smethod_0().bool_4 && smethod_14();
		}

		private static bool smethod_14()
		{
			GClass128[] gclass128_ = GClass78.smethod_1().gclass128_0;
			for (int i = 0; i < gclass128_.Length; i++)
			{
				if (gclass128_[i] != null && gclass128_[i].gclass117_0.short_0 == 194)
					return true;
			}
			return false;
		}

		public void method_11()
		{
			method_8(42, 0, GEnum2.const_0, null);
			method_8(0, 42, GEnum2.const_0, null);
			method_8(0, 1, GEnum2.const_0, null);
			method_8(1, 0, GEnum2.const_0, null);
			method_8(0, 21, GEnum2.const_0, null);
			method_8(21, 0, GEnum2.const_0, null);
			method_8(1, 2, GEnum2.const_0, null);
			method_8(2, 1, GEnum2.const_0, null);
			method_8(2, 3, GEnum2.const_0, null);
			method_8(3, 2, GEnum2.const_0, null);
			method_8(3, 4, GEnum2.const_0, null);
			method_8(4, 3, GEnum2.const_0, null);
			method_8(4, 5, GEnum2.const_0, null);
			method_8(5, 4, GEnum2.const_0, null);
			method_8(5, 6, GEnum2.const_0, null);
			method_8(6, 5, GEnum2.const_0, null);
			method_8(5, 29, GEnum2.const_0, null);
			method_8(29, 5, GEnum2.const_0, null);
			method_8(3, 27, GEnum2.const_0, null);
			method_8(27, 3, GEnum2.const_0, null);
			method_8(27, 28, GEnum2.const_0, null);
			method_8(28, 27, GEnum2.const_0, null);
			method_8(28, 29, GEnum2.const_0, null);
			method_8(29, 28, GEnum2.const_0, null);
			method_8(29, 30, GEnum2.const_0, null);
			method_8(30, 29, GEnum2.const_0, null);
			method_8(2, 24, GEnum2.const_0, null);
			method_8(24, 2, GEnum2.const_0, null);
			method_8(24, 84, GEnum2.const_1, new int[2] { 10, 2 });
			method_8(84, 24 + GClass78.smethod_1().int_14, GEnum2.const_1, new int[2] { 10, 0 });
			method_8(1, 47, GEnum2.const_0, null);
			method_8(47, 1, GEnum2.const_0, null);
			method_8(111, 47, GEnum2.const_0, null);
			method_8(47, 111, GEnum2.const_0, null);
			method_8(47, 46, GEnum2.const_0, null);
			method_8(46, 47, GEnum2.const_3, new int[2] { 107, 576 });
			method_8(46, 45, GEnum2.const_0, null);
			method_8(45, 46, GEnum2.const_3, new int[2] { 107, 576 });
			method_8(45, 48, GEnum2.const_1, new int[2] { 19, 3 });
			method_8(48, 45, GEnum2.const_1, new int[3] { 20, 4, 0 });
			method_8(48, 50, GEnum2.const_1, new int[3] { 20, 3, 1 });
			method_8(50, 48, GEnum2.const_1, new int[2] { 44, 0 });
			method_8(5, 112, GEnum2.const_1, new int[2] { 21, 3 });
			method_8(112, 5, GEnum2.const_1, new int[2] { 21, 3 });
			method_8(48, 143, GEnum2.const_1, new int[4] { 20, 3, 2, 2 });
			method_8(143, 142, GEnum2.const_0, null);
			method_8(142, 143, GEnum2.const_0, null);
			method_8(142, 141, GEnum2.const_0, null);
			method_8(141, 142, GEnum2.const_0, null);
			method_8(141, 45, GEnum2.const_0, new int[2] { 19, 0 });
			method_8(47, 144, GEnum2.const_3, new int[2] { 55, 336 });
			method_8(50, 154, GEnum2.const_1, new int[2] { 44, 1 });
			method_8(154, 50, GEnum2.const_1, new int[2] { 55, 0 });
			method_8(154, 155, GEnum2.const_1, new int[2] { 44, 1 });
			method_8(155, 166, GEnum2.const_0, null);
			method_8(166, 155, GEnum2.const_0, null);
			method_8(43, 7, GEnum2.const_0, null);
			method_8(7, 43, GEnum2.const_0, null);
			method_8(7, 22, GEnum2.const_0, null);
			method_8(22, 7, GEnum2.const_0, null);
			method_8(7, 8, GEnum2.const_0, null);
			method_8(8, 7, GEnum2.const_0, null);
			method_8(8, 9, GEnum2.const_0, null);
			method_8(9, 8, GEnum2.const_0, null);
			method_8(9, 11, GEnum2.const_0, null);
			method_8(11, 9, GEnum2.const_0, null);
			method_8(11, 12, GEnum2.const_0, null);
			method_8(12, 11, GEnum2.const_0, null);
			method_8(12, 13, GEnum2.const_0, null);
			method_8(13, 12, GEnum2.const_0, null);
			method_8(13, 10, GEnum2.const_0, null);
			method_8(10, 13, GEnum2.const_0, null);
			method_8(11, 31, GEnum2.const_0, null);
			method_8(31, 11, GEnum2.const_0, null);
			method_8(31, 32, GEnum2.const_0, null);
			method_8(32, 31, GEnum2.const_0, null);
			method_8(32, 33, GEnum2.const_0, null);
			method_8(33, 32, GEnum2.const_0, null);
			method_8(33, 34, GEnum2.const_0, null);
			method_8(34, 33, GEnum2.const_0, null);
			method_8(9, 25, GEnum2.const_0, null);
			method_8(25, 9, GEnum2.const_0, null);
			method_8(25, 84, GEnum2.const_1, new int[2] { 11, 2 });
			method_8(13, 33, GEnum2.const_0, null);
			method_8(33, 13, GEnum2.const_0, null);
			method_8(27, 53, GEnum2.const_1, new int[2] { 25, 0 });
			method_8(53, 27, GEnum2.const_0, null);
			method_8(53, 58, GEnum2.const_0, null);
			method_8(58, 53, GEnum2.const_0, null);
			method_8(58, 59, GEnum2.const_0, null);
			method_8(59, 58, GEnum2.const_0, null);
			method_8(59, 60, GEnum2.const_0, null);
			method_8(60, 59, GEnum2.const_0, null);
			method_8(60, 61, GEnum2.const_0, null);
			method_8(61, 60, GEnum2.const_0, null);
			method_8(61, 62, GEnum2.const_0, null);
			method_8(62, 61, GEnum2.const_0, null);
			method_8(62, 55, GEnum2.const_0, null);
			method_8(55, 62, GEnum2.const_0, null);
			method_8(55, 56, GEnum2.const_0, null);
			method_8(56, 55, GEnum2.const_0, null);
			method_8(56, 54, GEnum2.const_0, null);
			method_8(54, 56, GEnum2.const_0, null);
			method_8(54, 57, GEnum2.const_0, null);
			method_8(57, 54, GEnum2.const_0, null);
			method_8(52, 113, GEnum2.const_1, new int[2] { 23, 1 });
			method_8(113, 52, GEnum2.const_1, new int[2] { 22, 4 });
			method_8(52, 129, GEnum2.const_1, new int[2] { 23, 2 });
			method_8(129, 52, GEnum2.const_1, new int[2] { 23, 3 });
			method_8(52, 44, GEnum2.const_0, null);
			method_8(44, 52, GEnum2.const_0, null);
			method_8(23, 14, GEnum2.const_0, null);
			method_8(14, 23, GEnum2.const_0, null);
			method_8(44, 14, GEnum2.const_0, null);
			method_8(14, 44, GEnum2.const_0, null);
			method_8(14, 15, GEnum2.const_0, null);
			method_8(15, 14, GEnum2.const_0, null);
			method_8(15, 16, GEnum2.const_0, null);
			method_8(16, 15, GEnum2.const_0, null);
			method_8(16, 17, GEnum2.const_0, null);
			method_8(17, 16, GEnum2.const_0, null);
			method_8(17, 18, GEnum2.const_0, null);
			method_8(18, 17, GEnum2.const_0, null);
			method_8(18, 20, GEnum2.const_0, null);
			method_8(20, 18, GEnum2.const_0, null);
			method_8(20, 19, GEnum2.const_0, null);
			method_8(19, 20, GEnum2.const_0, null);
			method_8(17, 35, GEnum2.const_0, null);
			method_8(35, 17, GEnum2.const_0, null);
			method_8(35, 36, GEnum2.const_0, null);
			method_8(36, 35, GEnum2.const_0, null);
			method_8(36, 37, GEnum2.const_0, null);
			method_8(37, 36, GEnum2.const_0, null);
			method_8(37, 38, GEnum2.const_0, null);
			method_8(38, 37, GEnum2.const_0, null);
			method_8(16, 26, GEnum2.const_0, null);
			method_8(26, 16, GEnum2.const_0, null);
			method_8(26, 84, GEnum2.const_1, new int[2] { 12, 2 });
			method_8(20, 37, GEnum2.const_0, null);
			method_8(37, 20, GEnum2.const_0, null);
			method_8(84, 104, GEnum2.const_0, null);
			method_8(104, 84, GEnum2.const_0, null);
			method_8(24, 139, GEnum2.const_1, new int[2] { 63, 0 });
			method_8(139, 24, GEnum2.const_1, new int[2] { 63, 0 });
			method_8(139, 25, GEnum2.const_1, new int[2] { 63, 1 });
			method_8(139, 26, GEnum2.const_1, new int[2] { 63, 2 });
			method_8(139, 140, GEnum2.const_0, null);
			method_8(140, 139, GEnum2.const_0, null);
			method_8(24, 25, GEnum2.const_1, new int[2] { 10, 0 });
			method_8(24, 26, GEnum2.const_1, new int[2] { 10, 1 });
			method_8(25, 24, GEnum2.const_1, new int[2] { 11, 0 });
			method_8(25, 26, GEnum2.const_1, new int[2] { 11, 1 });
			method_8(26, 24, GEnum2.const_1, new int[2] { 12, 0 });
			method_8(26, 25, GEnum2.const_1, new int[2] { 12, 1 });
			method_8(19, 68, GEnum2.const_1, new int[2] { 12, 1 });
			method_8(68, 19, GEnum2.const_1, new int[2] { 12, 0 });
			method_8(68, 69, GEnum2.const_0, null);
			method_8(69, 68, GEnum2.const_0, null);
			method_8(69, 70, GEnum2.const_0, null);
			method_8(70, 69, GEnum2.const_0, null);
			method_8(70, 71, GEnum2.const_0, null);
			method_8(71, 70, GEnum2.const_0, null);
			method_8(71, 72, GEnum2.const_0, null);
			method_8(72, 71, GEnum2.const_0, null);
			method_8(72, 64, GEnum2.const_0, null);
			method_8(64, 72, GEnum2.const_0, null);
			method_8(64, 65, GEnum2.const_0, null);
			method_8(65, 64, GEnum2.const_0, null);
			method_8(65, 63, GEnum2.const_0, null);
			method_8(63, 65, GEnum2.const_0, null);
			method_8(63, 66, GEnum2.const_0, null);
			method_8(66, 63, GEnum2.const_0, null);
			method_8(66, 67, GEnum2.const_0, null);
			method_8(67, 66, GEnum2.const_0, null);
			method_8(67, 73, GEnum2.const_0, null);
			method_8(73, 67, GEnum2.const_0, null);
			method_8(73, 74, GEnum2.const_0, null);
			method_8(74, 73, GEnum2.const_0, null);
			method_8(74, 75, GEnum2.const_0, null);
			method_8(75, 74, GEnum2.const_0, null);
			method_8(75, 76, GEnum2.const_0, null);
			method_8(76, 75, GEnum2.const_0, null);
			method_8(76, 77, GEnum2.const_0, null);
			method_8(77, 76, GEnum2.const_0, null);
			method_8(77, 81, GEnum2.const_0, null);
			method_8(81, 77, GEnum2.const_0, null);
			method_8(81, 82, GEnum2.const_0, null);
			method_8(82, 81, GEnum2.const_0, null);
			method_8(82, 83, GEnum2.const_0, null);
			method_8(83, 82, GEnum2.const_0, null);
			method_8(83, 79, GEnum2.const_0, null);
			method_8(79, 83, GEnum2.const_0, null);
			method_8(79, 80, GEnum2.const_0, null);
			method_8(80, 79, GEnum2.const_0, null);
			method_8(80, 131, GEnum2.const_1, new int[2] { 60, 0 });
			method_8(131, 80, GEnum2.const_1, new int[2] { 60, 1 });
			method_8(131, 132, GEnum2.const_0, null);
			method_8(132, 131, GEnum2.const_0, null);
			method_8(132, 133, GEnum2.const_0, null);
			method_8(133, 132, GEnum2.const_0, null);
			method_8(27, 102, GEnum2.const_1, new int[2] { 38, 1 });
			method_8(28, 102, GEnum2.const_1, new int[2] { 38, 1 });
			method_8(29, 102, GEnum2.const_1, new int[2] { 38, 1 });
			method_8(102, 24, GEnum2.const_1, new int[2] { 38, 1 });
			method_8(102, 92, GEnum2.const_0, null);
			method_8(92, 102, GEnum2.const_0, null);
			method_8(92, 93, GEnum2.const_0, null);
			method_8(93, 92, GEnum2.const_0, null);
			method_8(93, 94, GEnum2.const_0, null);
			method_8(94, 93, GEnum2.const_0, null);
			method_8(94, 96, GEnum2.const_0, null);
			method_8(96, 94, GEnum2.const_0, null);
			method_8(96, 97, GEnum2.const_0, null);
			method_8(97, 96, GEnum2.const_0, null);
			method_8(97, 98, GEnum2.const_0, null);
			method_8(98, 97, GEnum2.const_0, null);
			method_8(98, 99, GEnum2.const_0, null);
			method_8(99, 98, GEnum2.const_0, null);
			method_8(99, 100, GEnum2.const_0, null);
			method_8(100, 99, GEnum2.const_0, null);
			method_8(100, 103, GEnum2.const_0, null);
			method_8(103, 100, GEnum2.const_0, null);
			method_8(5, 153, GEnum2.const_1, new int[3] { 13, 0, 2 });
			method_8(153, 5, GEnum2.const_1, new int[2] { 10, 1 });
			method_8(153, 156, GEnum2.const_1, new int[2] { 47, 1 });
			method_8(156, 157, GEnum2.const_0, null);
			method_8(157, 156, GEnum2.const_0, null);
			method_8(157, 158, GEnum2.const_0, null);
			method_8(158, 157, GEnum2.const_0, null);
			method_8(158, 159, GEnum2.const_0, null);
			method_8(159, 158, GEnum2.const_0, null);
			method_8(80, 105, GEnum2.const_0, null);
			method_8(105, 80, GEnum2.const_0, null);
			if (GClass78.smethod_1().gclass56_0.short_1 >= 31)
				method_8(19, 109, GEnum2.const_1, new int[2] { 12, 0 });
			method_8(109, 108, GEnum2.const_0, null);
			method_8(108, 109, GEnum2.const_0, null);
			method_8(108, 107, GEnum2.const_0, null);
			method_8(107, 108, GEnum2.const_0, null);
			method_8(107, 110, GEnum2.const_0, null);
			method_8(110, 107, GEnum2.const_0, null);
			method_8(109, 105, GEnum2.const_0, null);
			method_8(105, 109, GEnum2.const_0, null);
			method_8(109, 106, GEnum2.const_0, null);
			method_8(106, 109, GEnum2.const_0, null);
			method_8(106, 107, GEnum2.const_0, null);
			method_8(107, 106, GEnum2.const_0, null);
			method_8(108, 105, GEnum2.const_0, null);
			method_8(105, 108, GEnum2.const_0, null);
			method_8(0, 149, GEnum2.const_1, new int[3] { 67, 3, 0 });
			method_8(149, 147, GEnum2.const_0, null);
			method_8(147, 149, GEnum2.const_0, null);
			method_8(147, 152, GEnum2.const_0, null);
			method_8(152, 147, GEnum2.const_0, null);
			method_8(152, 151, GEnum2.const_0, null);
			method_8(151, 152, GEnum2.const_0, null);
			method_8(151, 148, GEnum2.const_0, null);
			method_8(148, 151, GEnum2.const_0, null);
			method_8(5, 135, GEnum2.const_1, new int[4] { 13, 0, 4, 2 });
			method_8(135, 138, GEnum2.const_0, null);
			method_8(138, 135, GEnum2.const_0, null);
			method_8(138, 136, GEnum2.const_0, null);
			method_8(136, 138, GEnum2.const_0, null);
			method_8(136, 137, GEnum2.const_0, null);
			method_8(137, 136, GEnum2.const_0, null);
			method_8(24 + GClass78.smethod_1().int_14, 85, GEnum2.const_2, null);
			method_8(24 + GClass78.smethod_1().int_14, 86, GEnum2.const_2, null);
			method_8(24 + GClass78.smethod_1().int_14, 87, GEnum2.const_2, null);
			method_8(24 + GClass78.smethod_1().int_14, 88, GEnum2.const_2, null);
			method_8(24 + GClass78.smethod_1().int_14, 89, GEnum2.const_2, null);
			method_8(24 + GClass78.smethod_1().int_14, 90, GEnum2.const_2, null);
			method_8(24 + GClass78.smethod_1().int_14, 91, GEnum2.const_2, null);
			method_8(85, 24 + GClass78.smethod_1().int_14, GEnum2.const_1, new int[2] { 36, 0 });
			method_8(86, 24 + GClass78.smethod_1().int_14, GEnum2.const_1, new int[2] { 30, 0 });
			method_8(87, 24 + GClass78.smethod_1().int_14, GEnum2.const_1, new int[2] { 31, 0 });
			method_8(88, 24 + GClass78.smethod_1().int_14, GEnum2.const_1, new int[2] { 32, 0 });
			method_8(89, 24 + GClass78.smethod_1().int_14, GEnum2.const_1, new int[2] { 33, 0 });
			method_8(90, 24 + GClass78.smethod_1().int_14, GEnum2.const_1, new int[2] { 34, 0 });
			method_8(91, 24 + GClass78.smethod_1().int_14, GEnum2.const_1, new int[2] { 35, 0 });
			method_8(GClass20.int_37, 146, GEnum2.const_5, new int[1] { 726 });
			method_8(GClass20.int_37, 160, GEnum2.const_5, new int[1] { 992 });
			method_8(160, 161, GEnum2.const_0, null);
			method_8(161, 160, GEnum2.const_0, null);
			method_8(161, 162, GEnum2.const_0, null);
			method_8(162, 161, GEnum2.const_0, null);
			method_8(162, 163, GEnum2.const_0, null);
			method_8(163, 162, GEnum2.const_0, null);
			if (!GClass148.smethod_0().bool_4 && !GClass148.smethod_0().bool_3)
			{
				method_8(160, 80, GEnum2.const_5, new int[1] { 992 });
				method_8(161, 80, GEnum2.const_5, new int[1] { 992 });
				method_8(162, 80, GEnum2.const_5, new int[1] { 992 });
				method_8(163, 80, GEnum2.const_5, new int[1] { 992 });
			}
			method_8(GClass20.int_37, 176, GEnum2.const_5, new int[1] { 1540 });
			method_8(GClass20.int_37, 177, GEnum2.const_5, new int[1] { 1565 });
			if (GClass20.int_37 == 176)
				method_8(176, 24, GEnum2.const_1, new int[2] { 10, 0 });
			if (GClass20.int_37 == 177)
				method_8(177, 24, GEnum2.const_1, new int[2] { 52, 0 });
		}
	}
}
