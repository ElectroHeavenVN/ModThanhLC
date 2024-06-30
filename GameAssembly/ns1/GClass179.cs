using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ns1
{
	public class GClass179
	{
		public static bool bool_0;

		public string string_0;

		public string string_1;

		public int int_0;

		public int int_1 = -1;

		public DateTime dateTime_0;

		public static List<GClass179> list_0 = new List<GClass179>();

		public static List<GClass179> list_1 = new List<GClass179>();

		public static int int_2 = ((GClass76.int_12 == 2) ? 7 : 10);

		public static int int_3 = 0;

		private static int int_4 = 5;

		private static int int_5 = ((GClass76.int_12 == 2) ? 40 : 35);

		private static int int_6 = 0;

		public static List<GClass179> list_2 = new List<GClass179>();

		public static List<GClass179> list_3 = new List<GClass179>();

		public static List<GClass179> list_4 = new List<GClass179>();

		public static List<GClass179> list_5 = new List<GClass179>();

		public static List<GClass179> list_6 = new List<GClass179>();

		public static List<GClass179> list_7 = new List<GClass179>();

		public static List<GClass179> list_8 = new List<GClass179>();

		public static List<GClass179> list_9 = new List<GClass179>();

		public static List<GClass179> list_10 = new List<GClass179>();

		public static List<GClass179> list_11 = new List<GClass179>();

		public static List<GClass179> list_12 = new List<GClass179>();

		public static List<GClass179> list_13 = new List<GClass179>();

		public static List<GClass179> list_14 = new List<GClass179>();

		public static List<GClass179> list_15 = new List<GClass179>();

		public static List<GClass179> list_16 = new List<GClass179>();

		public static List<GClass179> list_17 = new List<GClass179>();

		public static List<GClass179> list_18 = new List<GClass179>();

		public static List<GClass179> list_19 = new List<GClass179>();

		public static List<GClass179> list_20 = new List<GClass179>();

		public static string[] string_2 = new string[19]
		{
			"[Số 4]", "[Số 3]", "[Số 2]", "[Số 1]", "[Tiểu đội trưởng]", "[Fide Đại Ca]", "[Android 19][Dr.Kôrê]", "[Android 13][Android 14][Android 15]", "[Pic][Poc][Kingkong]", "[Xên bọ hung]",
			"[Xên hoàn thiện]", "[Xên con]", "[Siêu bọ hung]", "[Black Goku]", "[Cooler]", "[Super Broly]", "[Fide Vàng]", "[Biệt đội Bojack]", "[Cumber]"
		};

		public static string[] string_3 = new string[19]
		{
			"[Guldo]", "[Recoome]", "[Jeice]", "[Burter]", "[Captain Ginyu]", "[Frieza]", "[Android 19][Dr.Kôrê]", "[Android 13][Android 14][Android 15]", "[Pic][Poc][Kingkong]", "[Cell]",
			"[Perfect Cell]", "[Cell Jr]", "[Super Cell]", "[Black Goku]", "[Cooler]", "[Super Broly]", "[Golden Frieza]", "[Bojack]", "[Cumber]"
		};

		public static List<GClass179> list_21 = new List<GClass179>();

		private GClass179(string name, string map)
		{
			string_0 = name;
			string_1 = map;
			if (map == ((mResources.language == 0) ? "Trạm tàu vũ trụ" : "Spaceship station"))
			{
				if (name.StartsWith("Số ") || name.StartsWith("Tiểu đội") || name.StartsWith("Captain Ginyu") || name.StartsWith("Guldo") || name.StartsWith("Recoome") || name.StartsWith("Jeice") || name.StartsWith("Burter"))
					int_0 = 25;
				else if (name.Contains("Bojack") || name.StartsWith("Bujin") || name.StartsWith("Bido") || name.StartsWith("Zangya") || name.StartsWith("Bido"))
				{
					int_0 = 24;
				}
			}
			else
				int_0 = smethod_6(map);
			dateTime_0 = DateTime.Now;
		}

		public static void smethod_0(List<GClass179> list, string name, string map)
		{
			list.Add(new GClass179(name, map));
			if (list == list_7 && list.Count > 3)
				list.RemoveAt(0);
			if ((list == list_2 || list == list_3 || list == list_4 || list == list_5 || list == list_6) && list.Count > 2)
				list.RemoveAt(0);
			if (list == list_9 && list.Count > 3)
				list.RemoveAt(0);
			if (list == list_10 && list.Count > 3)
				list.RemoveAt(0);
			if (list == list_8 && list.Count > 2)
				list.RemoveAt(0);
			if (list == list_15 && list.Count > 6)
				list.RemoveAt(0);
			if (list == list_12 && list.Count > 3)
				list.RemoveAt(0);
			if (list == list_13 && list.Count > 7)
				list.RemoveAt(0);
			if (list == list_17 && list.Count > 5)
				list.RemoveAt(0);
			if (list == list_18 && list.Count > 5)
				list.RemoveAt(0);
			if (list == list_16 && list.Count > 2)
				list.RemoveAt(0);
			if (list == list_19 && list.Count > 6)
				list.RemoveAt(0);
		}

		public static void smethod_1(string name, string map)
		{
			sbyte language = mResources.language;
			if (language != 0)
			{
				if (language != 1)
					return;
				if (name != null)
				{
					switch (name.Length)
					{
					case 3:
					{
						char c = name[1];
						if (c != 'i')
						{
							if (c == 'o' && name == "Poc")
							{
								smethod_0(list_10, name, map);
								return;
							}
						}
						else if (name == "Pic")
						{
							smethod_0(list_10, name, map);
							return;
						}
						break;
					}
					case 4:
					{
						char c = name[0];
						if (c != 'B')
						{
							if (c != 'C')
							{
								if (c == 'K' && name == "Kogu")
								{
									smethod_0(list_19, name, map);
									return;
								}
							}
							else if (name == "Cell")
							{
								smethod_0(list_11, name, map);
								return;
							}
						}
						else if (name == "Bido")
						{
							smethod_0(list_19, name, map);
							return;
						}
						break;
					}
					case 5:
					{
						char c = name[0];
						if (c != 'B')
						{
							if (c != 'G')
							{
								if (c == 'J' && name == "Jeice")
								{
									smethod_0(list_4, name, map);
									return;
								}
							}
							else if (name == "Guldo")
							{
								smethod_0(list_2, name, map);
								return;
							}
						}
						else if (name == "Bujin")
						{
							smethod_0(list_19, name, map);
							return;
						}
						break;
					}
					case 6:
					{
						char c = name[2];
						switch (c)
						{
						default:
							if (c != 'r' || !(name == "Burter"))
								break;
							smethod_0(list_5, name, map);
							return;
						case 'j':
							if (name == "Bojack")
							{
								smethod_0(list_19, name, map);
								return;
							}
							break;
						case 'm':
							if (name == "Cumber")
							{
								smethod_0(list_20, name, map);
								return;
							}
							break;
						case 'n':
							if (name == "Zangya")
							{
								smethod_0(list_19, name, map);
								return;
							}
							break;
						case 'k':
						case 'l':
							break;
						}
						break;
					}
					case 7:
					{
						char c = name[0];
						if (c != 'D')
						{
							if (c == 'R' && name == "Recoome")
							{
								smethod_0(list_3, name, map);
								return;
							}
						}
						else if (name == "Dr.Kôrê")
						{
							smethod_0(list_8, name, map);
							return;
						}
						break;
					}
					case 8:
						switch (name[7])
						{
						case '1':
							if (name == "Frieza 1")
							{
								smethod_0(list_7, name, map);
								return;
							}
							break;
						case '2':
							if (name == "Frieza 2")
							{
								smethod_0(list_7, name, map);
								return;
							}
							break;
						case '3':
							if (name == "Frieza 3")
							{
								smethod_0(list_7, name, map);
								return;
							}
							break;
						}
						break;
					case 9:
						if (name == "King kong")
						{
							smethod_0(list_10, name, map);
							return;
						}
						break;
					case 10:
					{
						char c = name[9];
						switch (c)
						{
						default:
							if (c != 'l' || !(name == "Super Cell"))
								break;
							smethod_0(list_14, name, map);
							return;
						case '3':
							if (name == "Android 13")
							{
								smethod_0(list_9, name, map);
								return;
							}
							break;
						case '4':
							if (name == "Android 14")
							{
								smethod_0(list_9, name, map);
								return;
							}
							break;
						case '5':
							if (name == "Android 15")
							{
								smethod_0(list_9, name, map);
								return;
							}
							break;
						case '9':
							if (name == "Android 19")
							{
								smethod_0(list_8, name, map);
								return;
							}
							break;
						case '6':
						case '7':
						case '8':
							break;
						}
						break;
					}
					case 12:
					{
						char c = name[11];
						switch (c)
						{
						default:
							if (c != 'k')
							{
								if (c == 'l' && name == "Perfect Cell")
								{
									smethod_0(list_12, name, map);
									return;
								}
							}
							else if (name == "Super Bojack")
							{
								smethod_0(list_19, name, map);
								return;
							}
							break;
						case '0':
							if (name == "Black Goku 0")
							{
								smethod_0(list_15, name, map);
								return;
							}
							break;
						case '1':
							if (name == "Black Goku 1")
							{
								smethod_0(list_15, name, map);
								return;
							}
							break;
						case '2':
							if (name == "Black Goku 2")
							{
								smethod_0(list_15, name, map);
								return;
							}
							break;
						}
						break;
					}
					case 13:
						if (name == "Captain Ginyu")
						{
							smethod_0(list_6, name, map);
							return;
						}
						break;
					case 18:
						switch (name[17])
						{
						case '0':
							if (name == "Super Black Goku 0")
							{
								smethod_0(list_15, name, map);
								return;
							}
							break;
						case '1':
							if (name == "Super Black Goku 1")
							{
								smethod_0(list_15, name, map);
								return;
							}
							break;
						case '2':
							if (name == "Super Black Goku 2")
							{
								smethod_0(list_15, name, map);
								return;
							}
							break;
						}
						break;
					}
				}
				if (name.StartsWith("Super Broly"))
					smethod_0(list_17, name, map);
				else if (name.StartsWith("Cooler"))
				{
					smethod_0(list_16, name, map);
				}
				else if (map.StartsWith("Cell Jr"))
				{
					smethod_0(list_13, name, map);
				}
				else if (name.ToLower().StartsWith("gold"))
				{
					smethod_0(list_18, name, map);
				}
				return;
			}
			switch (name)
			{
			case "Poc":
				smethod_0(list_10, name, map);
				return;
			case "Pic":
				smethod_0(list_10, name, map);
				return;
			case "Số 1":
				smethod_0(list_5, name, map);
				return;
			case "Số 2":
				smethod_0(list_4, name, map);
				return;
			case "Số 3":
				smethod_0(list_3, name, map);
				return;
			case "Số 4":
				smethod_0(list_2, name, map);
				return;
			case "Bujin":
				smethod_0(list_19, name, map);
				return;
			case "Zangya":
				smethod_0(list_19, name, map);
				return;
			case "Cumber":
				smethod_0(list_20, name, map);
				return;
			case "Bojack":
				smethod_0(list_19, name, map);
				return;
			case "Dr.Kôrê":
				smethod_0(list_8, name, map);
				return;
			case "King kong":
				smethod_0(list_10, name, map);
				return;
			case "Android 13":
				smethod_0(list_9, name, map);
				return;
			case "Android 14":
				smethod_0(list_9, name, map);
				return;
			case "Android 15":
				smethod_0(list_9, name, map);
				return;
			case "Android 19":
				smethod_0(list_8, name, map);
				return;
			case "Xên bọ hung":
				smethod_0(list_11, name, map);
				return;
			case "Siêu Bojack":
				smethod_0(list_19, name, map);
				return;
			case "Black Goku 0":
				smethod_0(list_15, name, map);
				return;
			case "Black Goku 1":
				smethod_0(list_15, name, map);
				return;
			case "Black Goku 2":
				smethod_0(list_15, name, map);
				return;
			case "Fide Đại Ca 1":
				smethod_0(list_7, name, map);
				return;
			case "Fide Đại Ca 2":
				smethod_0(list_7, name, map);
				return;
			case "Fide Đại Ca 3":
				smethod_0(list_7, name, map);
				return;
			case "Xên hoàn thiện":
				smethod_0(list_12, name, map);
				return;
			case "Tiểu đội trưởng":
				smethod_0(list_6, name, map);
				return;
			case "Super Black Goku 0":
				smethod_0(list_15, name, map);
				return;
			case "Super Black Goku 1":
				smethod_0(list_15, name, map);
				return;
			case "Super Black Goku 2":
				smethod_0(list_15, name, map);
				return;
			}
			if (name.StartsWith("Super Broly"))
				smethod_0(list_17, name, map);
			else if (name.StartsWith("Fide Vàng"))
			{
				smethod_0(list_18, name, map);
			}
			else if (name.StartsWith("Cooler"))
			{
				smethod_0(list_16, name, map);
			}
			else if (map.StartsWith("Xên con"))
			{
				smethod_0(list_13, name, map);
			}
		}

		public static void smethod_2(string chatVip)
		{
			if (bool_0 && chatVip.StartsWith("BOSS"))
			{
				chatVip = chatVip.Replace("BOSS ", "").Replace(" vừa xuất hiện tại ", "|").Replace(" appear at ", "|")
					.Replace(" khu vực ", "|")
					.Replace(" zone ", "|");
				string[] array = chatVip.Split('|');
				list_0.Add(new GClass179(array[0].Trim(), array[1].Trim()));
				smethod_1(array[0].Trim(), array[1].Trim());
				if (array.Length == 3)
					list_0.Last().int_1 = int.Parse(array[2].Trim());
				if (list_0.Count > 5)
					list_0.RemoveAt(0);
			}
		}

		public static string smethod_3(GClass179 boss)
		{
			TimeSpan timeSpan = DateTime.Now.Subtract(boss.dateTime_0);
			string text = "[" + boss.string_0 + "] [" + boss.string_1 + "] ";
			int num = (int)Math.Floor((decimal)timeSpan.TotalHours);
			if (num > 0)
				text += $"{num}h";
			if (timeSpan.Minutes > 0)
				text += $"{timeSpan.Minutes}m";
			return text + $"{timeSpan.Seconds}s";
		}

		public static string smethod_4(GClass179 boss)
		{
			TimeSpan timeSpan = DateTime.Now.Subtract(boss.dateTime_0);
			string text = string.Empty;
			int num = (int)Math.Floor((decimal)timeSpan.TotalHours);
			if (num > 0)
				text += $"{num}h";
			if (timeSpan.Minutes > 0)
				text += $"{timeSpan.Minutes}m";
			return text + $"{timeSpan.Seconds}s";
		}

		public static void smethod_5(GClass76 g)
		{
			if (!bool_0 || GClass177.smethod_0().method_5())
				return;
			try
			{
				GUIStyle[] array = new GUIStyle[list_0.Count];
				GUIStyle[] array2 = new GUIStyle[list_0.Count];
				for (int i = 0; i < list_0.Count; i++)
				{
					array[i] = new GUIStyle(GUI.skin.label)
					{
						alignment = TextAnchor.UpperRight,
						fontSize = ((GClass76.int_12 == 2) ? 12 : 9),
						fontStyle = FontStyle.Bold,
						richText = true
					};
					array2[i] = new GUIStyle(GUI.skin.label)
					{
						alignment = TextAnchor.UpperRight,
						fontSize = ((GClass76.int_12 == 2) ? 12 : 9),
						fontStyle = FontStyle.Bold,
						richText = true
					};
					array2[i].normal.textColor = Color.black;
					array[i].normal.textColor = new Color32(254, 169, 0, byte.MaxValue);
					GClass179 gClass = list_0[i];
					if (gClass == null)
						continue;
					if (GClass1.int_37 == gClass.int_0)
					{
						array[i].normal.textColor = Color.green;
						for (int j = 0; j < GClass154.gclass63_5.method_2(); j++)
						{
							if (((GClass58)GClass154.gclass63_5.method_3(j)).string_3 == gClass.string_0)
							{
								array[i].normal.textColor = Color.red;
								break;
							}
						}
					}
					int_6 = GClass26.smethod_2(GClass193.smethod_0().method_4(array[i], (GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]")), int_6);
					int num = GClass39.int_10 - int_4;
					int_3 = GClass26.smethod_2(GClass193.smethod_0().method_5(array[i], (GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]")), int_3);
					int num2 = int_5 + ((GClass76.int_12 == 2) ? 7 : 10) * i + ((GClass76.int_12 == 2) ? 3 : 0);
					g.method_20(13959423, 0.3f);
					g.method_15(num - ((GClass76.int_12 == 2) ? 16 : 23), num2 + ((GClass76.int_12 == 2) ? 1 : 5), (GClass76.int_12 == 2) ? 17 : 23, (GClass76.int_12 == 2) ? 7 : 8);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) - 0.5f, (float)num2 - 0.5f, array2[i]);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) - 0.5f, (float)num2 + 0.5f, array2[i]);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) + 0.5f, (float)num2 - 0.5f, array2[i]);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) + 0.5f, (float)num2 + 0.5f, array2[i]);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), -int_4, (float)num2 - 0.5f, array2[i]);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), -int_4, (float)num2 + 0.5f, array2[i]);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) - 0.5f, num2, array2[i]);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) + 0.5f, num2, array2[i]);
					g.method_19((GClass192.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), -int_4, num2, array[i]);
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/paintListbossinformation.txt", ex.ToString());
			}
		}

		private static int smethod_6(string string_4)
		{
			if (string_4.ToLower().Contains((mResources.language == 0) ? "vách núi moori" : "moori cliff"))
				return 43;
			int num = 0;
			while (true)
			{
				if (num < GClass1.string_2.Length)
				{
					if (GClass1.string_2[num].Equals(string_4))
						break;
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}

		public static void smethod_7()
		{
			if (!bool_0)
				return;
			for (int i = 0; i < list_0.Count; i++)
			{
				if (GClass39.smethod_24(GClass39.int_10 - int_4 - ((GClass76.int_12 == 2) ? 16 : 23), int_5 + ((GClass76.int_12 == 2) ? 7 : 10) * i + ((GClass76.int_12 == 2) ? 4 : 5), (GClass76.int_12 == 2) ? 17 : 23, (GClass76.int_12 == 2) ? 7 : 8) && !GClass39.bool_14 && GClass39.bool_15 && GClass1.int_37 != list_0[i].int_0)
				{
					if (GClass171.smethod_0().bool_0)
						Class14.smethod_0().method_8();
					GClass29.smethod_1().method_35();
					GClass58.smethod_1().gclass136_0 = null;
					GClass39.smethod_49();
					Class14.smethod_0().method_7(list_0[i].int_0);
				}
			}
		}
	}
}
