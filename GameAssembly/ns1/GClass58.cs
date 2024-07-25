using System;
using System.Collections.Generic;
using System.Linq;

namespace ns1
{
    public class GClass58 : GInterface1
    {
        protected struct GStruct11
        {
            public int int_0;

            public int int_1;

            public int int_2;

            public GStruct11(int head, int body, int leg)
            {
                int_0 = head;
                int_1 = body;
                int_2 = leg;
            }
        }

        public bool bool_0;

        protected static List<GStruct11> list_0 = new List<GStruct11>();

        protected static List<GStruct11> list_1 = new List<GStruct11>();

        protected int int_0 = 0;

        public bool bool_1;

        protected int int_1 = 0;

        public long long_0;

        protected List<GClass124> list_2 = new List<GClass124>();

        private static GClass58 gclass58_0;

        public static List<GClass124> list_3 = new List<GClass124>();

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

        public string method_0(GClass124 @char, bool enableRichText = false)
        {
            string text = @char.string_3.Remove(0, @char.string_3.IndexOf(']') + 1).TrimStart(' ', '#', '$');
            if (enableRichText)
                text = (method_2(@char) ? ("<color=cyan>" + text + "</color>") : ((!method_1(@char)) ? ("<color=yellow>" + text + "</color>") : $"<color=red><size={7 * GClass193.int_12}>{text}</size></color>"));
            return text;
        }

        public bool method_1(GClass124 @char)
        {
            return @char != null && !method_2(@char) && @char.string_3 != ((mResources.language != 0) ? "Arbitration" : "Trọng tài") && char.IsUpper(method_0(@char)[0]);
        }

        public bool method_2(GClass124 @char)
        {
            return @char.method_1() || @char.method_2() || @char.string_3.StartsWith("#") || @char.string_3.StartsWith("$");
        }

        public static GClass58 smethod_0()
        {
            return (gclass58_0 != null) ? gclass58_0 : (gclass58_0 = new GClass58());
        }

        public bool method_3(string text)
        {
            switch (text)
            {
                case "/dsb":
                    smethod_0().bool_0 = !smethod_0().bool_0;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto murdering boss: " + GClass45.smethod_0().method_6(smethod_0().bool_0)) : ("Tự động tàn sát BOSS: " + GClass45.smethod_0().method_6(smethod_0().bool_0)), 0);
                    return true;
                case "/dsbskillclr":
                    list_4.Clear();
                    GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã xóa d/s skill tàn sát BOSS" : "Deleted list Skill murdering Boss", 0);
                    return true;
                case "/listbossclr":
                    list_1.Clear();
                    list_0.Clear();
                    GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã xóa d/s tàn sát BOSS" : "Deleted list Boss murdering", 0);
                    return true;
                case "/cobj":
                    smethod_0().bool_1 = !smethod_0().bool_1;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động chuyển mục tiêu: " + GClass45.smethod_0().method_6(smethod_0().bool_1)) : ("Auto change object: " + GClass45.smethod_0().method_6(smethod_0().bool_1)), 0);
                    return true;
                case "/tbb":
                    GClass44.bool_0 = !GClass44.bool_0;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("List boss information: " + GClass45.smethod_0().method_6(GClass44.bool_0)) : ("D/s thông báo Boss: " + GClass45.smethod_0().method_6(GClass44.bool_0)), 0);
                    return true;
                case "/dsbskill":
                    method_14();
                    return true;
                case "/dsbig":
                    smethod_0().method_16();
                    return true;
                case "/addboss":
                    smethod_0().method_15();
                    return true;
            }
            if (GClass45.smethod_0().method_11<int>(text, "/bosshp"))
            {
                int_0 = GClass45.smethod_0().method_12<int>(text, "/bosshp");
                if (int_0 == 0)
                    GClass51.smethod_1(GClass62.int_0 == 0 ? "Tắt giới hạn HP Boss" : "Turn off limited Boss HP", 0);
                else if (GClass62.int_0 != 0)
                    GClass51.smethod_1("Only attack boss have HP lower than " + GClass138.smethod_9(int_0) + " HP", 0);
                else
                    GClass51.smethod_1("Chỉ đánh boss dưới " + GClass138.smethod_9(int_0) + " HP", 0);
                return true;
            }
            return false;
        }

        public bool method_4(int asciiCode)
        {
            if (asciiCode != 101)
                return false;
            if (!GClass54.smethod_0().method_5())
                method_8();
            else
                GClass2.smethod_0().method_78("/ahs");
            return true;
        }

        public void perform(int idAction, object p)
        {
            if (GClass57.smethod_0().bool_0)
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
                GClass122 gClass = new GClass122();
                gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("D.sách\nT.báo BOSS:\n" + GClass45.smethod_0().method_7(GClass44.bool_0)) : ("List Bosses\nInformation:\n" + GClass45.smethod_0().method_7(GClass44.bool_0)), this, 101201, null));
                gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Đồ sát\nBOSS:\n" + GClass45.smethod_0().method_7(bool_0)) : ("AutoMurdering\nBOSS:\n" + GClass45.smethod_0().method_7(bool_0)), this, 101202, null));
                gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Fix Bosses\nLỗi HP:\n" + GClass45.smethod_0().method_7(bool_2)) : ("Fix Bosses\nError HP:\n" + GClass45.smethod_0().method_7(bool_2)), this, 101204, null));
                if (list_0.Count > 0 || list_1.Count > 0)
                    gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Xóa d.sách\nBOSS\n đồ sát" : "Delete\nLiss Boss\nMurdering", this, 101203, null));
                GClass14.gclass116_0.bool_1 = true;
                GClass14.gclass116_0.method_2(gClass, 0);
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

        public void method_6(GClass193 g)
        {
            GClass44.smethod_5(g);
        }

        protected void method_7()
        {
            if (!bool_2 || GClass14.int_8 % 10 != 0)
                return;
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                if (GClass167.gclass122_5.method_3(i) is GClass124 gClass && gClass.int_25 > 0 && gClass.int_13 < 0 && method_1(gClass))
                    gClass.sbyte_19 = 5;
            }
        }

        public void method_8()
        {
            List<GClass124> list = list_3;
            if (int_2 >= list.Count)
                int_2 = 0;
            if (list.Count <= 0 || int_2 >= list.Count)
                return;
            if (GClass124.smethod_1().gclass124_0 != list[0] && list.Count == 1)
            {
                GClass124.smethod_1().gclass6_0 = null;
                GClass124.smethod_1().gclass190_0 = null;
                GClass124.smethod_1().gclass125_0 = null;
                GClass124.smethod_1().gclass124_0 = list[0];
            }
            if (GClass124.smethod_1().gclass124_0 != list[int_2])
            {
                GClass124.smethod_1().gclass6_0 = null;
                GClass124.smethod_1().gclass190_0 = null;
                GClass124.smethod_1().gclass125_0 = null;
                GClass124.smethod_1().gclass124_0 = list[int_2];
            }
            if (GClass124.smethod_1().gclass124_0 == list[int_2])
            {
                GClass47.smethod_0().method_26(list[int_2].int_4, list[int_2].int_5);
                if (list.Count - int_2 <= 1)
                    int_2 = 0;
                else
                    int_2++;
            }
        }

        protected void method_9(List<GClass124> myList, int i, int m)
        {
            GClass124 value = myList[i];
            myList[i] = myList[m];
            myList[m] = value;
        }

        protected List<GClass124> method_10()
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
                for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
                {
                    GClass124 gClass = (GClass124)GClass167.gclass122_5.method_3(i);
                    if (gClass != null && gClass.sbyte_19 == 5 && !gClass.bool_54 && !gClass.bool_53 && gClass.int_13 < 0 && gClass.string_3 != ((mResources.language == 0) ? "Trọng tài" : "Arbitration") && !list_3.Contains(gClass))
                    {
                        list_3.Add(gClass);
                        list_3 = method_10();
                    }
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/addBossInMap.txt", ex.ToString());
            }
        }

        protected void method_12()
        {
            try
            {
                if (GClass137.int_37 < 131 || GClass137.int_37 > 133 || !bool_1)
                    return;
                list_2.Clear();
                for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
                {
                    if (GClass167.gclass122_5.method_3(i) is GClass124 gClass && gClass.sbyte_19 == 5 && method_1(gClass) && gClass.int_13 < 0 && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 100 && !list_2.Contains(gClass))
                        list_2.Add(gClass);
                    for (int j = 0; j < list_2.Count; j++)
                    {
                        if (GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, list_2[j].int_4, list_2[j].int_5) > 100)
                            list_2.RemoveAt(j);
                    }
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/addYardartSoldier.txt", ex.ToString());
            }
        }

        protected void method_13()
        {
            try
            {
                if (!bool_1 || GClass137.int_37 < 131 || GClass137.int_37 > 133 || GClass77.smethod_18() - long_0 <= 1500L)
                    return;
                if (list_2.Count == 1)
                {
                    if (list_2[0] != null)
                    {
                        GClass124.smethod_1().gclass190_0 = null;
                        GClass124.smethod_1().gclass125_0 = null;
                        GClass124.smethod_1().gclass6_0 = null;
                        GClass124.smethod_1().gclass124_0 = list_2[0];
                        long_0 = GClass77.smethod_18();
                    }
                    else
                        int_1 = 0;
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
                            GClass124.smethod_1().gclass6_0 = null;
                            GClass124.smethod_1().gclass125_0 = null;
                            GClass124.smethod_1().gclass190_0 = null;
                            GClass124.smethod_1().gclass124_0 = list_2[int_1];
                            int_1++;
                            long_0 = GClass77.smethod_18();
                        }
                    }
                    if (int_1 >= list_2.Count)
                        int_1 = 0;
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/changeObject.txt", ex.ToString());
            }
        }

        protected void method_14()
        {
            if (GClass124.smethod_1().gclass95_0 != null)
            {
                GClass95 gclass95_ = GClass124.smethod_1().gclass95_0;
                if (!list_4.Contains(gclass95_.gclass205_0.sbyte_0))
                {
                    list_4.Add(gclass95_.gclass205_0.sbyte_0);
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Đã thêm skill: " + gclass95_.gclass205_0.string_0) : ("Added skill: " + gclass95_.gclass205_0.string_0), 0);
                }
                else
                {
                    list_4.Remove(gclass95_.gclass205_0.sbyte_0);
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Đã xóa skill: " + gclass95_.gclass205_0.string_0) : ("Deleted skill: " + gclass95_.gclass205_0.string_0), 0);
                }
            }
        }

        protected void method_15()
        {
            if (GClass124.smethod_1().gclass124_0 != null && GClass124.smethod_1().gclass124_0.int_13 <= 0)
            {
                GClass124 gclass124_ = GClass124.smethod_1().gclass124_0;
                if (!list_0.Contains(new GStruct11(gclass124_.int_119, gclass124_.int_121, gclass124_.int_120)))
                {
                    list_0.Add(new GStruct11(gclass124_.int_119, gclass124_.int_121, gclass124_.int_120));
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Đã thêm BOSS: " + gclass124_.string_3) : ("Added BOSS: " + gclass124_.string_3), 0);
                }
                else
                {
                    list_0.Remove(new GStruct11(gclass124_.int_119, gclass124_.int_121, gclass124_.int_120));
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Đã xóa BOSS: " + gclass124_.string_3) : ("Deleted BOSS: " + gclass124_.string_3), 0);
                }
            }
        }

        protected void method_16()
        {
            if (GClass124.smethod_1().gclass124_0 != null && GClass124.smethod_1().gclass124_0.int_13 <= 0)
            {
                GClass124 gclass124_ = GClass124.smethod_1().gclass124_0;
                if (list_1.Contains(new GStruct11(gclass124_.int_119, gclass124_.int_121, gclass124_.int_120)))
                {
                    list_1.Remove(new GStruct11(gclass124_.int_119, gclass124_.int_121, gclass124_.int_120));
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Deleted BOSS: " + gclass124_.string_3) : ("Đã xóa BOSS: " + gclass124_.string_3), 0);
                }
                else
                {
                    list_1.Add(new GStruct11(gclass124_.int_119, gclass124_.int_121, gclass124_.int_120));
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added BOSS: " + gclass124_.string_3) : ("Đã thêm BOSS: " + gclass124_.string_3), 0);
                }
            }
        }

        protected static bool smethod_1(GClass124 @char)
        {
            if (@char.int_5 <= 20)
                return false;
            if (list_0.Count == 0 || list_0.Contains(new GStruct11(@char.int_119, @char.int_121, @char.int_120)))
            {
                if (list_1.Count == 0 || !list_1.Contains(new GStruct11(@char.int_119, @char.int_121, @char.int_120)))
                {
                    if (@char.int_13 > 0 || @char.sbyte_19 != 5)
                        return false;
                    return true;
                }
                return false;
            }
            return false;
        }

        protected static bool smethod_2(GClass124 @char)
        {
            if (smethod_1(@char))
                return true;
            return false;
        }

        protected static GClass124 smethod_3()
        {
            GClass124 result = null;
            int num = int.MaxValue;
            GClass124 gClass = GClass124.smethod_1();
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                GClass124 gClass2 = (GClass124)GClass167.gclass122_5.method_3(i);
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

        protected static GClass124 smethod_4()
        {
            GClass124 result = null;
            long num = GClass77.smethod_18();
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                GClass124 gClass = (GClass124)GClass167.gclass122_5.method_3(i);
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

        protected static bool smethod_5(GClass124 @char)
        {
            if (smethod_1(@char))
                return true;
            return false;
        }

        public void method_17()
        {
            list_4.Clear();
            GClass51.smethod_1((GClass62.int_0 != 0) ? "Deleted list Skill murdering Char" : "Đã xóa d/s skill đồ sát người", 0);
        }

        protected GClass95 method_18()
        {
            GClass95 gClass = null;
            GClass205 gClass2 = new GClass205();
            foreach (sbyte item in list_4)
            {
                gClass2.sbyte_0 = item;
                GClass95 gClass3 = GClass124.smethod_1().method_16(gClass2);
                if (smethod_6(gClass3, gClass))
                    gClass = gClass3;
            }
            return gClass;
        }

        public static bool smethod_6(GClass95 SkillBetter, GClass95 skill)
        {
            if (SkillBetter != null)
            {
                if (!SkillBetter.bool_0)
                {
                    if (smethod_7(SkillBetter))
                    {
                        bool flag = SkillBetter.gclass205_0.sbyte_0 == 17 && skill.gclass205_0.sbyte_0 == 2;
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

        public static bool smethod_7(GClass95 skill)
        {
            if (GClass77.smethod_18() - skill.long_1 > skill.int_1)
                skill.bool_0 = false;
            if (!skill.bool_0 || sbyte_1.Contains(skill.gclass205_0.sbyte_0))
            {
                if (sbyte_2.Contains(skill.gclass205_0.sbyte_0))
                    return false;
                if (GClass124.smethod_1().int_24 < smethod_8(skill))
                    return false;
                return true;
            }
            return false;
        }

        public static int smethod_8(GClass95 skill)
        {
            if (skill.gclass205_0.int_2 != 2)
            {
                if (skill.gclass205_0.int_2 != 1)
                    return skill.int_5;
                return skill.int_5 * GClass124.smethod_1().int_36 / 100;
            }
            return 1;
        }

        public void method_19()
        {
            if (!bool_0 || method_21())
                return;
            GClass124 gClass = GClass124.smethod_1();
            if (gClass.int_11 == 14 || gClass.int_25 <= 0)
                return;
            if (!gClass.bool_23)
            {
                gClass.method_104(2);
                bool flag = GClass82.smethod_0(4387);
                if (gClass.gclass124_0 != null && !smethod_2(gClass.gclass124_0))
                    gClass.gclass124_0 = null;
                if (gClass.gclass124_0 != null)
                {
                    if (gClass.method_75() != null)
                    {
                        if (!flag)
                        {
                            GClass124 gClass2 = smethod_4();
                            if (gClass2 != null)
                                GClass48.smethod_0().method_11(gClass2.int_4, gClass2.int_5);
                        }
                    }
                    else
                    {
                        GClass95 gClass3 = method_18();
                        if (gClass3 != null && !gClass3.bool_0)
                        {
                            GClass124 gclass124_ = gClass.gclass124_0;
                            if (gClass.gclass95_0 != gClass3 || gClass.int_11 == 5 || gClass.gclass95_0.gclass205_0.int_3 == 3 || gClass.gclass95_0.gclass205_0.sbyte_0 == 10 || gClass.gclass95_0.gclass205_0.sbyte_0 == 11)
                                GClass167.smethod_8().method_62(gClass3, true);
                            int int_ = GClass137.int_23;
                            int int_2 = GClass137.int_24;
                            bool flag2 = gclass124_.int_5 < 0;
                            bool flag3 = gclass124_.int_4 < 0;
                            bool flag4 = gclass124_.int_4 > int_;
                            bool flag5 = gclass124_.int_5 > int_2 || gclass124_.int_5 > GClass61.smethod_0().method_12(gclass124_.int_4);
                            if (GClass191.smethod_24(gclass124_.int_4, gclass124_.int_5, gClass.int_4, gClass.int_5) > 48 || gclass124_.int_25 <= 0)
                            {
                                if (flag)
                                {
                                    if (flag3)
                                    {
                                        GClass124.smethod_1().int_4 = 10;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(10);
                                        GClass2.smethod_0().method_44();
                                        GClass124.smethod_1().int_4 = 10;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(10) + 1;
                                        GClass2.smethod_0().method_44();
                                        GClass124.smethod_1().int_4 = 10;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(10);
                                        GClass2.smethod_0().method_44();
                                        method_20(500);
                                    }
                                    else if (flag4)
                                    {
                                        GClass124.smethod_1().int_4 = int_ - 50;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(int_ - 50);
                                        GClass2.smethod_0().method_44();
                                        GClass124.smethod_1().int_4 = int_ - 50;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(int_ - 50) + 1;
                                        GClass2.smethod_0().method_44();
                                        GClass124.smethod_1().int_4 = int_ - 50;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(int_ - 50);
                                        GClass2.smethod_0().method_44();
                                        method_20(500);
                                    }
                                    else if (!flag5)
                                    {
                                        if (flag2)
                                        {
                                            GClass124.smethod_1().int_4 = gclass124_.int_4;
                                            GClass124.smethod_1().int_5 = 10;
                                            GClass2.smethod_0().method_44();
                                            GClass124.smethod_1().int_4 = gclass124_.int_4;
                                            GClass124.smethod_1().int_5 = 11;
                                            GClass2.smethod_0().method_44();
                                            GClass124.smethod_1().int_4 = gclass124_.int_4;
                                            GClass124.smethod_1().int_5 = 10;
                                            GClass2.smethod_0().method_44();
                                            method_20(500);
                                        }
                                        else
                                        {
                                            GClass124.smethod_1().int_4 = gclass124_.int_4;
                                            GClass124.smethod_1().int_5 = gclass124_.int_5;
                                            GClass2.smethod_0().method_44();
                                            GClass124.smethod_1().int_4 = gclass124_.int_4;
                                            GClass124.smethod_1().int_5 = gclass124_.int_5 + 1;
                                            GClass2.smethod_0().method_44();
                                            GClass124.smethod_1().int_4 = gclass124_.int_4;
                                            GClass124.smethod_1().int_5 = gclass124_.int_5;
                                            GClass2.smethod_0().method_44();
                                            method_20(500);
                                        }
                                    }
                                    else
                                    {
                                        GClass124.smethod_1().int_4 = gclass124_.int_4;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(gclass124_.int_4);
                                        GClass2.smethod_0().method_44();
                                        GClass124.smethod_1().int_4 = gclass124_.int_4;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(gclass124_.int_4) + 1;
                                        GClass2.smethod_0().method_44();
                                        GClass124.smethod_1().int_4 = gclass124_.int_4;
                                        GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(gclass124_.int_4);
                                        GClass2.smethod_0().method_44();
                                        method_20(500);
                                    }
                                }
                                else
                                    GClass48.smethod_0().method_11(gclass124_.int_4, gclass124_.int_5);
                            }
                            else
                                GClass41.smethod_0().method_14();
                        }
                    }
                    method_20(200);
                    return;
                }
                gClass.gclass124_0 = smethod_3();
                if (!flag || gClass.gclass124_0 == null)
                    return;
                int int_3 = GClass137.int_23;
                int int_4 = GClass137.int_24;
                bool flag6 = gClass.gclass124_0.int_5 < 0;
                bool flag7 = gClass.gclass124_0.int_4 < 0;
                bool flag8 = gClass.gclass124_0.int_4 > int_3;
                bool flag9 = gClass.gclass124_0.int_5 > int_4 || gClass.gclass124_0.int_5 > GClass61.smethod_0().method_12(gClass.gclass124_0.int_4);
                if (flag7)
                {
                    GClass124.smethod_1().int_4 = 10;
                    GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(10);
                    GClass2.smethod_0().method_44();
                    method_20(500);
                }
                else if (flag8)
                {
                    GClass124.smethod_1().int_4 = int_3 - 50;
                    GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(int_3 - 50);
                    GClass2.smethod_0().method_44();
                    method_20(500);
                }
                else if (!flag9)
                {
                    if (flag6)
                    {
                        GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                        GClass124.smethod_1().int_5 = 10;
                        GClass2.smethod_0().method_44();
                        method_20(500);
                    }
                    else
                    {
                        GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                        GClass124.smethod_1().int_5 = gClass.gclass124_0.int_5;
                        GClass2.smethod_0().method_44();
                        method_20(500);
                    }
                }
                else
                {
                    GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                    GClass124.smethod_1().int_5 = GClass61.smethod_0().method_12(gClass.gclass124_0.int_4);
                    GClass2.smethod_0().method_44();
                    method_20(500);
                }
            }
            else
                method_20(500);
        }

        public void method_20(int time)
        {
            bool_3 = true;
            long_1 = GClass77.smethod_18();
            long_2 = time;
        }

        public bool method_21()
        {
            if (bool_3 && GClass77.smethod_18() - long_1 >= long_2)
                bool_3 = false;
            return bool_3;
        }
    }
}
