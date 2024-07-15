using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ns1
{
    public class GClass44
    {
        public static bool bool_0;

        public string string_0;

        public string string_1;

        public int int_0;

        public int int_1 = -1;

        public DateTime dateTime_0;

        public static List<GClass44> list_0 = new List<GClass44>();

        public static List<GClass44> list_1 = new List<GClass44>();

        public static int int_2 = ((GClass193.int_12 == 2) ? 7 : 10);

        public static int int_3 = 0;

        private static int int_4 = 5;

        private static int int_5 = ((GClass193.int_12 == 2) ? 40 : 35);

        private static int int_6 = 0;

        public static List<GClass44> list_2 = new List<GClass44>();

        public static List<GClass44> list_3 = new List<GClass44>();

        public static List<GClass44> list_4 = new List<GClass44>();

        public static List<GClass44> list_5 = new List<GClass44>();

        public static List<GClass44> list_6 = new List<GClass44>();

        public static List<GClass44> list_7 = new List<GClass44>();

        public static List<GClass44> list_8 = new List<GClass44>();

        public static List<GClass44> list_9 = new List<GClass44>();

        public static List<GClass44> list_10 = new List<GClass44>();

        public static List<GClass44> list_11 = new List<GClass44>();

        public static List<GClass44> list_12 = new List<GClass44>();

        public static List<GClass44> list_13 = new List<GClass44>();

        public static List<GClass44> list_14 = new List<GClass44>();

        public static List<GClass44> list_15 = new List<GClass44>();

        public static List<GClass44> list_16 = new List<GClass44>();

        public static List<GClass44> list_17 = new List<GClass44>();

        public static List<GClass44> list_18 = new List<GClass44>();

        public static List<GClass44> list_19 = new List<GClass44>();

        public static List<GClass44> list_20 = new List<GClass44>();

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

        public static List<GClass44> list_21 = new List<GClass44>();

        private GClass44(string name, string map)
        {
            string_0 = name;
            string_1 = map;
            if (!(map == ((mResources.language == 0) ? "Trạm tàu vũ trụ" : "Spaceship station")))
                int_0 = smethod_6(map);
            else if (name.StartsWith("Số ") || name.StartsWith("Tiểu đội") || name.StartsWith("Captain Ginyu") || name.StartsWith("Guldo") || name.StartsWith("Recoome") || name.StartsWith("Jeice") || name.StartsWith("Burter"))
            {
                int_0 = 25;
            }
            else if (name.Contains("Bojack") || name.StartsWith("Bujin") || name.StartsWith("Bido") || name.StartsWith("Zangya") || name.StartsWith("Bido"))
            {
                int_0 = 24;
            }
            dateTime_0 = DateTime.Now;
        }

        public static void smethod_0(List<GClass44> list, string name, string map)
        {
            list.Add(new GClass44(name, map));
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
            if (language == 0)
            {
                switch (name)
                {
                    case "Black Goku 0":
                        smethod_0(list_15, name, map);
                        return;
                    case "Black Goku 1":
                        smethod_0(list_15, name, map);
                        return;
                    case "Black Goku 2":
                        smethod_0(list_15, name, map);
                        return;
                    case "Siêu bọ hung":
                        smethod_0(list_14, name, map);
                        return;
                    case "Số 4":
                        smethod_0(list_2, name, map);
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
                    case "Xên hoàn thiện":
                        smethod_0(list_12, name, map);
                        return;
                    case "Kogu":
                        smethod_0(list_19, name, map);
                        return;
                    case "Zangya":
                        smethod_0(list_19, name, map);
                        return;
                    case "Tiểu đội trưởng":
                        smethod_0(list_6, name, map);
                        return;
                    case "Fide Đại Ca 3":
                        smethod_0(list_7, name, map);
                        return;
                    case "Fide Đại Ca 1":
                        smethod_0(list_7, name, map);
                        return;
                    case "Bido":
                        smethod_0(list_19, name, map);
                        return;
                    case "Fide Đại Ca 2":
                        smethod_0(list_7, name, map);
                        return;
                    case "Bojack":
                        smethod_0(list_19, name, map);
                        return;
                    case "King kong":
                        smethod_0(list_10, name, map);
                        return;
                    case "Xên bọ hung":
                        smethod_0(list_11, name, map);
                        return;
                    case "Bujin":
                        smethod_0(list_19, name, map);
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
                    case "Siêu Bojack":
                        smethod_0(list_19, name, map);
                        return;
                    case "Android 19":
                        smethod_0(list_8, name, map);
                        return;
                    case "Poc":
                        smethod_0(list_10, name, map);
                        return;
                    case "Android 14":
                        smethod_0(list_9, name, map);
                        return;
                    case "Android 15":
                        smethod_0(list_9, name, map);
                        return;
                    case "Cumber":
                        smethod_0(list_20, name, map);
                        return;
                    case "Dr.Kôrê":
                        smethod_0(list_8, name, map);
                        return;
                    case "Pic":
                        smethod_0(list_10, name, map);
                        return;
                    case "Android 13":
                        smethod_0(list_9, name, map);
                        return;
                }
                if (name.StartsWith("Super Broly"))
                    smethod_0(list_17, name, map);
                else if (name.StartsWith("Fide Vàng"))
                    smethod_0(list_18, name, map);
                else if (name.StartsWith("Cooler"))
                    smethod_0(list_16, name, map);
                else if (map.StartsWith("Xên con"))
                    smethod_0(list_13, name, map);
            }
            else if (language == 1)
            {
                switch (name)
                {
                    case "Black Goku 2":
                        smethod_0(list_15, name, map);
                        return;
                    case "Guldo":
                        smethod_0(list_2, name, map);
                        return;
                    case "Black Goku 1":
                        smethod_0(list_15, name, map);
                        return;
                    case "Black Goku 0":
                        smethod_0(list_15, name, map);
                        return;
                    case "Poc":
                        smethod_0(list_10, name, map);
                        return;
                    case "Perfect Cell":
                        smethod_0(list_12, name, map);
                        return;
                    case "Android 15":
                        smethod_0(list_9, name, map);
                        return;
                    case "Android 19":
                        smethod_0(list_8, name, map);
                        return;
                    case "Zangya":
                        smethod_0(list_19, name, map);
                        return;
                    case "Kogu":
                        smethod_0(list_19, name, map);
                        return;
                    case "Super Bojack":
                        smethod_0(list_19, name, map);
                        return;
                    case "Captain Ginyu":
                        smethod_0(list_6, name, map);
                        return;
                    case "Burter":
                        smethod_0(list_5, name, map);
                        return;
                    case "Bido":
                        smethod_0(list_19, name, map);
                        return;
                    case "Jeice":
                        smethod_0(list_4, name, map);
                        return;
                    case "Super Cell":
                        smethod_0(list_14, name, map);
                        return;
                    case "King kong":
                        smethod_0(list_10, name, map);
                        return;
                    case "Cumber":
                        smethod_0(list_20, name, map);
                        return;
                    case "Cell":
                        smethod_0(list_11, name, map);
                        return;
                    case "Bojack":
                        smethod_0(list_19, name, map);
                        return;
                    case "Super Black Goku 2":
                        smethod_0(list_15, name, map);
                        return;
                    case "Super Black Goku 0":
                        smethod_0(list_15, name, map);
                        return;
                    case "Super Black Goku 1":
                        smethod_0(list_15, name, map);
                        return;
                    case "Bujin":
                        smethod_0(list_19, name, map);
                        return;
                    case "Frieza 1":
                        smethod_0(list_7, name, map);
                        return;
                    case "Frieza 3":
                        smethod_0(list_7, name, map);
                        return;
                    case "Dr.Kôrê":
                        smethod_0(list_8, name, map);
                        return;
                    case "Pic":
                        smethod_0(list_10, name, map);
                        return;
                    case "Android 13":
                        smethod_0(list_9, name, map);
                        return;
                    case "Android 14":
                        smethod_0(list_9, name, map);
                        return;
                    case "Frieza 2":
                        smethod_0(list_7, name, map);
                        return;
                    case "Recoome":
                        smethod_0(list_3, name, map);
                        return;
                }
                if (name.StartsWith("Super Broly"))
                    smethod_0(list_17, name, map);
                else if (name.StartsWith("Cooler"))
                    smethod_0(list_16, name, map);
                else if (map.StartsWith("Cell Jr"))
                    smethod_0(list_13, name, map);
                else if (name.ToLower().StartsWith("gold"))
                    smethod_0(list_18, name, map);
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
                list_0.Add(new GClass44(array[0].Trim(), array[1].Trim()));
                smethod_1(array[0].Trim(), array[1].Trim());
                if (array.Length == 3)
                    list_0.Last().int_1 = int.Parse(array[2].Trim());
                if (list_0.Count > 5)
                    list_0.RemoveAt(0);
            }
        }

        public static string smethod_3(GClass44 boss)
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

        public static string smethod_4(GClass44 boss)
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

        public static void smethod_5(GClass193 g)
        {
            if (!bool_0 || GClass54.smethod_0().method_5())
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
                        fontSize = ((GClass193.int_12 == 2) ? 12 : 9),
                        fontStyle = FontStyle.Bold,
                        richText = true
                    };
                    array2[i] = new GUIStyle(GUI.skin.label)
                    {
                        alignment = TextAnchor.UpperRight,
                        fontSize = ((GClass193.int_12 == 2) ? 12 : 9),
                        fontStyle = FontStyle.Bold,
                        richText = true
                    };
                    array2[i].normal.textColor = Color.black;
                    array[i].normal.textColor = Color.yellow;
                    GClass44 gClass = list_0[i];
                    if (gClass == null)
                        continue;
                    if (GClass137.int_37 == gClass.int_0)
                    {
                        array[i].normal.textColor = Color.green;
                        for (int j = 0; j < GClass167.gclass122_5.method_2(); j++)
                        {
                            if (((GClass124)GClass167.gclass122_5.method_3(j)).string_3 == gClass.string_0)
                            {
                                array[i].normal.textColor = Color.red;
                                break;
                            }
                        }
                    }
                    int_6 = GClass13.smethod_2(GClass45.smethod_0().method_4(array[i], (GClass62.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]")), int_6);
                    int num = GClass14.int_10 - int_4;
                    int_3 = GClass13.smethod_2(GClass45.smethod_0().method_5(array[i], (GClass62.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]")), int_3);
                    int num2 = int_5 + ((GClass193.int_12 == 2) ? 7 : 10) * i + ((GClass193.int_12 == 2) ? 3 : 0);
                    g.method_20(13959423, 0.3f);
                    g.method_15(num - ((GClass193.int_12 == 2) ? 16 : 23), num2 + ((GClass193.int_12 == 2) ? 1 : 5), (GClass193.int_12 == 2) ? 17 : 23, (GClass193.int_12 == 2) ? 7 : 8);
                    g.method_19((GClass62.int_0 != 0) ? (smethod_3(gClass) + " [Goto]") : (smethod_3(gClass) + " [Đến]"), (float)(-int_4) - 0.5f, (float)num2 - 0.5f, array2[i]);
                    g.method_19((GClass62.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) - 0.5f, (float)num2 + 0.5f, array2[i]);
                    g.method_19((GClass62.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) + 0.5f, (float)num2 - 0.5f, array2[i]);
                    g.method_19((GClass62.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) + 0.5f, (float)num2 + 0.5f, array2[i]);
                    g.method_19((GClass62.int_0 != 0) ? (smethod_3(gClass) + " [Goto]") : (smethod_3(gClass) + " [Đến]"), -int_4, (float)num2 - 0.5f, array2[i]);
                    g.method_19((GClass62.int_0 != 0) ? (smethod_3(gClass) + " [Goto]") : (smethod_3(gClass) + " [Đến]"), -int_4, (float)num2 + 0.5f, array2[i]);
                    g.method_19((GClass62.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) - 0.5f, num2, array2[i]);
                    g.method_19((GClass62.int_0 == 0) ? (smethod_3(gClass) + " [Đến]") : (smethod_3(gClass) + " [Goto]"), (float)(-int_4) + 0.5f, num2, array2[i]);
                    g.method_19((GClass62.int_0 != 0) ? (smethod_3(gClass) + " [Goto]") : (smethod_3(gClass) + " [Đến]"), -int_4, num2, array[i]);
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/paintListbossinformation.txt", ex.ToString());
            }
        }

        private static int smethod_6(string string_4)
        {
            if (!string_4.ToLower().Contains((mResources.language == 0) ? "vách núi moori" : "moori cliff"))
            {
                for (int i = 0; i < GClass137.string_2.Length; i++)
                {
                    if (GClass137.string_2[i].Equals(string_4))
                        return i;
                }
                return -1;
            }
            return 43;
        }

        public static void smethod_7()
        {
            if (!bool_0)
                return;
            for (int i = 0; i < list_0.Count; i++)
            {
                if (GClass14.smethod_24(GClass14.int_10 - int_4 - ((GClass193.int_12 == 2) ? 16 : 23), int_5 + ((GClass193.int_12 == 2) ? 7 : 10) * i + ((GClass193.int_12 == 2) ? 4 : 5), (GClass193.int_12 == 2) ? 17 : 23, (GClass193.int_12 == 2) ? 7 : 8) && !GClass14.bool_14 && GClass14.bool_15 && GClass137.int_37 != list_0[i].int_0)
                {
                    if (GClass57.smethod_0().bool_0)
                        Class11.smethod_0().method_9();
                    GClass147.smethod_1().method_35();
                    GClass124.smethod_1().gclass119_0 = null;
                    GClass14.smethod_49();
                    Class11.smethod_0().method_8(list_0[i].int_0);
                }
            }
        }
    }
}
