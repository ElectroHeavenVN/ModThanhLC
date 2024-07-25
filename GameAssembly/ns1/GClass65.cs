using System.Collections.Generic;
using UnityEngine;

namespace ns1
{
    public class GClass65 : GInterface1, GInterface3
    {
        public bool bool_0;

        public long long_0;

        public bool bool_1;

        public long long_1;

        public List<string> list_0 = new List<string>();

        public bool bool_2;

        public long long_2;

        public long long_3;

        public bool bool_3;

        public long long_4;

        public bool bool_4;

        public int int_0;

        public int int_1 = 0;

        public bool bool_5;

        public bool bool_6;

        public bool bool_7;

        public long long_5;

        public bool bool_8;

        public int int_2;

        public bool bool_9;

        public List<int> list_1 = new List<int>();

        public int int_3 = 0;

        public long long_6;

        public bool bool_10;

        public long long_7 = 0L;

        public bool bool_11;

        public long long_8;

        private static GClass65 gclass65_0;

        public long long_9;

        public static GClass65 smethod_0()
        {
            return (gclass65_0 != null) ? gclass65_0 : (gclass65_0 = new GClass65());
        }

        private void method_0()
        {
            GClass107.smethod_0().string_1 = "Chat";
            GClass107.smethod_0().gclass136_0.string_7 = "chat";
            GClass107.smethod_0().bool_0 = false;
        }

        public void onCancelChat()
        {
        }

        public void onChatFromMe(string text, string to)
        {
            if (GClass107.smethod_0().gclass136_0.method_21() != null && !GClass107.smethod_0().gclass136_0.method_21().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
            {
                if (GClass107.smethod_0().string_1.Equals((GClass62.int_0 == 0) ? "Nhập sức mạnh đệ tử muốn giới hạn" : "Fill power of disciple want to limited"))
                {
                    method_2($"/petsm{int.Parse(GClass107.smethod_0().gclass136_0.method_21())}");
                    method_0();
                }
                else if (GClass107.smethod_0().string_1.Equals((GClass62.int_0 != 0) ? "Fill % HP Disciple auto use bean" : "Nhập % HP đệ tử sử dụng đậu thần"))
                {
                    method_2($"/pethp{int.Parse(GClass107.smethod_0().gclass136_0.method_21())}");
                    method_0();
                }
            }
            else
                GClass107.smethod_0().bool_0 = false;
            method_0();
        }

        public void method_1(string text)
        {
            GClass107.smethod_0().string_1 = text;
            GClass107.smethod_0().gclass136_0.string_7 = mResources.CHAT;
            GClass14.gclass113_0.bool_0 = false;
            GClass107.smethod_0().method_5(smethod_0(), string.Empty);
        }

        public void perform(int idAction, object p)
        {
            if (idAction != 10003)
            {
                switch (idAction)
                {
                    case 101401:
                    {
                        GClass122 gClass = new GClass122();
                        gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Tự động\nxin đậu:\n" + GClass45.smethod_0().method_7(bool_0)) : ("Auto Request\nBean:\n" + GClass45.smethod_0().method_7(bool_0)), this, 1000001, null));
                        gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Tự động\nthu đậu:\n" + GClass45.smethod_0().method_7(bool_2)) : ("Auto Collect\nBean:\n" + GClass45.smethod_0().method_7(bool_2)), this, 1000002, null));
                        gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Tự động\ncho đậu:\n" + GClass45.smethod_0().method_7(bool_1)) : ("Auto Give\nBean:\n" + GClass45.smethod_0().method_7(bool_1)), this, 1000003, null));
                        gClass.method_0(new GClass118((GClass62.int_0 != 0) ? ("Special\nRequest Bean:\n" + GClass45.smethod_0().method_7(bool_8)) : ("Xin đậu\nđặc biệt:\n" + GClass45.smethod_0().method_7(bool_8)), this, 1000004, null));
                        GClass14.gclass116_0.bool_1 = true;
                        GClass14.gclass116_0.method_2(gClass, 0);
                        return;
                    }
                    case 101402:
                        method_2("/ajump");
                        return;
                    case 101403:
                        method_2("/petinfo");
                        return;
                    case 101404:
                        method_2("/aflag");
                        return;
                    case 101405:
                        method_2("/dtnsq");
                        return;
                    case 101406:
                        method_2("/gohome");
                        return;
                    case 101407:
                        method_2("/aheal");
                        return;
                    case 101408:
                        smethod_0().method_1((GClass62.int_0 == 0) ? "Nhập sức mạnh đệ tử muốn giới hạn" : "Fill power of disciple want to limited");
                        return;
                    case 101409:
                        smethod_0().method_1((GClass62.int_0 == 0) ? "Nhập % HP đệ tử sử dụng đậu thần" : "Fill % HP Disciple auto use bean");
                        return;
                }
                switch (idAction)
                {
                    case 1000001:
                        method_2("/xd");
                        break;
                    case 1000002:
                        method_2("/td");
                        break;
                    case 1000003:
                        method_2("/cd");
                        break;
                    case 1000004:
                        method_2("/xddb");
                        break;
                }
            }
            else
            {
                GClass122 gClass2 = new GClass122();
                gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nBean" : "Chức năng\nđậu thần\n", this, 101401, null));
                gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? ("Auto Jump\n" + GClass45.smethod_0().method_7(bool_3)) : ("Auto Jump\n" + GClass45.smethod_0().method_7(bool_3)), this, 101402, null));
                gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? ("Hiển thị\nT.tin Đ.tử:\n" + GClass45.smethod_0().method_7(bool_4)) : ("Show disciple\nInformation:\n" + GClass45.smethod_0().method_7(bool_4)), this, 101403, null));
                gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? ("Auto bật\nCờ xám:\n" + GClass45.smethod_0().method_7(bool_7)) : ("Auto get\ngrey flag:\n" + GClass45.smethod_0().method_7(bool_7)), this, 101404, null));
                gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? ("Train đ.tử\nné s.quái:\n" + GClass45.smethod_0().method_7(bool_6)) : ("Train disciple:\n" + GClass45.smethod_0().method_7(bool_6)), this, 101405, null));
                gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? ("Auto cho\nĐ.tử về:\n" + GClass45.smethod_0().method_7(bool_10)) : ("Auto disciple\nGo home:\n" + GClass45.smethod_0().method_7(bool_10)), this, 101406, null));
                if (GClass124.smethod_1().int_14 == 1 && list_1.Count > 0)
                    gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? ("Trị thương\ntheo d.sách:\n" + GClass45.smethod_0().method_7(bool_9)) : ("Healing\nby list:\n" + GClass45.smethod_0().method_7(bool_9)), this, 101407, null));
                gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? ("G.hạn SM\nĐệ tử:\n" + ((long_7 == 0L) ? "KO G.HẠN" : GClass138.smethod_9(long_7))) : ("LIMITE DISCIPLE\nPOWER:\n" + ((long_7 != 0L) ? GClass138.smethod_9(long_7) : "UNLIMITED")), this, 101408, null));
                gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? ("Sài đậu\n" + ((int_3 != 0) ? $"khi Đệ tử\ndưới {long_7}% HP" : "%HP Đ.tử\nĐang tắt")) : ("Use bean\n" + ((int_3 == 0) ? "%HP Disciple\nIs Off" : $"when Disciple\nlower than{long_7}% HP")), this, 101409, null));
                GClass14.gclass116_0.bool_1 = true;
                GClass14.gclass116_0.method_2(gClass2, 0);
            }
        }

        public bool method_2(string text)
        {
            switch (text)
            {
                case "/aflag":
                    bool_7 = !bool_7;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto get grey flag: " + GClass45.smethod_0().method_6(bool_7)) : ("Tự động bật cờ xám: " + GClass45.smethod_0().method_6(bool_7)), 0);
                    return true;
                case "/addcheal":
                    method_21(-1);
                    return true;
                case "/xddb":
                    smethod_0().bool_8 = !smethod_0().bool_8;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Xin đậu đặc biệt: " + GClass45.smethod_0().method_6(smethod_0().bool_8)) : ("Special Request bean: " + GClass45.smethod_0().method_6(smethod_0().bool_8)), 0);
                    return true;
                case "/petinfo":
                    smethod_0().bool_4 = !smethod_0().bool_4;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Show disciple informations: " + GClass45.smethod_0().method_6(smethod_0().bool_4)) : ("Hiển thị thông tin đệ tử: " + GClass45.smethod_0().method_6(smethod_0().bool_4)), 0);
                    return true;
                case "/td":
                    smethod_0().bool_2 = !smethod_0().bool_2;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động thu đậu: " + GClass45.smethod_0().method_6(smethod_0().bool_2)) : ("Auto collect bean: " + GClass45.smethod_0().method_6(smethod_0().bool_2)), 0);
                    return true;
                case "/aheal":
                    smethod_0().bool_9 = !smethod_0().bool_9;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Healing by List: " + GClass45.smethod_0().method_6(smethod_0().bool_9)) : ("Trị thương theo d/s: " + GClass45.smethod_0().method_6(smethod_0().bool_9)), 0);
                    return true;
                case "/dtnsq":
                    smethod_0().bool_6 = !smethod_0().bool_6;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Up đệ tử né siêu quái: " + GClass45.smethod_0().method_6(smethod_0().bool_6)) : ("Train disciple: " + GClass45.smethod_0().method_6(smethod_0().bool_6)), 0);
                    return true;
                case "/ajump":
                    smethod_0().bool_3 = !smethod_0().bool_3;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động nhảy: " + GClass45.smethod_0().method_6(smethod_0().bool_3)) : ("Auto jump: " + GClass45.smethod_0().method_6(smethod_0().bool_3)), 0);
                    return true;
                case "/xd":
                    smethod_0().bool_0 = !smethod_0().bool_0;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto request bean: " + GClass45.smethod_0().method_6(smethod_0().bool_0)) : ("Tự động xin đậu: " + GClass45.smethod_0().method_6(smethod_0().bool_0)), 0);
                    return true;
                case "/cd":
                    smethod_0().bool_1 = !smethod_0().bool_1;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động cho đậu: " + GClass45.smethod_0().method_6(smethod_0().bool_1)) : ("Auto give bean: " + GClass45.smethod_0().method_6(smethod_0().bool_1)), 0);
                    return true;
                case "/gohome":
                    smethod_0().bool_10 = !smethod_0().bool_10;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động cho đệ về nhà khi tách hợp thể: " + GClass45.smethod_0().method_6(smethod_0().bool_10)) : ("Auto let disciple go home: " + GClass45.smethod_0().method_6(smethod_0().bool_10)), 0);
                    return true;
            }
            if (GClass45.smethod_0().method_11<string>(text, "/addcheal"))
            {
                if (GClass45.smethod_0().method_12<string>(text, "/addcheal").Contains(","))
                {
                    string[] array = GClass45.smethod_0().method_12<string>(text, "/addcheal").Split(',');
                    for (int i = 0; i < array.Length; i++)
                    {
                        method_21(int.Parse(array[i]));
                    }
                }
                else
                    method_21(int.Parse(GClass45.smethod_0().method_12<string>(text, "/addcheal")));
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/pethp"))
            {
                if (GClass45.smethod_0().method_12<int>(text, "/pethp") <= 0)
                {
                    int_3 = GClass45.smethod_0().method_12<int>(text, "/pethp");
                    GClass51.smethod_1((GClass62.int_0 != 0) ? "Turn off auto use bean by disciple %HP" : "Đã tắt tự động dùng đậu theo %HP đệ tử", 0);
                }
                else
                {
                    int_3 = GClass45.smethod_0().method_12<int>(text, "/pethp");
                    GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tự động dùng đậu khi đệ tử dưới [{int_3}%] HP" : $"Auto use bean when disciple lower than [{int_3}%] HP", 0);
                }
            }
            else if (GClass45.smethod_0().method_11<long>(text, "/petsm"))
            {
                if (GClass45.smethod_0().method_12<long>(text, "/petsm") > 0L)
                {
                    long_7 = GClass45.smethod_0().method_12<long>(text, "/petsm");
                    GClass51.smethod_1((GClass62.int_0 == 0) ? $"Giới hạn sức mạnh đệ tử [{long_7}]" : $"Limited disciple power to [{long_7}]", 0);
                }
                else
                {
                    long_7 = GClass45.smethod_0().method_12<long>(text, "/petsm");
                    GClass51.smethod_1((GClass62.int_0 != 0) ? "Turn off limit disciple power" : "Đã tắt giới hạn sức mạnh đệ tử", 0);
                }
            }
            else
                return false;
            return true;
        }

        public void method_3()
        {
            method_13();
            method_14();
            method_15();
            method_12();
            method_20();
            method_9();
            method_22();
            method_23();
            method_24();
            method_25();
            method_8();
            method_7();
        }

        public void method_4(GClass193 g)
        {
            if (GClass54.smethod_0().method_5())
                return;
            if (!GClass14.gclass113_0.bool_0 && GClass124.smethod_1().bool_38 && !GClass66.smethod_0().bool_3 && GClass14.gclass160_0 != GClass162.gclass162_0)
                g.method_31(GClass167.gclass20_11, 0, 150, 0);
            if (!bool_4)
                return;
            string[] array = new string[6]
            {
                (GClass62.int_0 != 0) ? ("- Power: " + GClass138.smethod_9(GClass124.smethod_2().long_2)) : ("- Sức mạnh: " + GClass138.smethod_9(GClass124.smethod_2().long_2)),
                (GClass62.int_0 == 0) ? ("- Tiềm năng: " + GClass138.smethod_9(GClass124.smethod_2().long_4)) : ("- Potential: " + GClass138.smethod_9(GClass124.smethod_2().long_4)),
                (GClass62.int_0 != 0) ? $"- HP: {GClass138.smethod_9(GClass124.smethod_2().int_25)}/{GClass138.smethod_9(GClass124.smethod_2().int_35)} ({GClass13.smethod_0(GClass124.smethod_2().int_25 * 100 / GClass124.smethod_2().int_35)}%)" : $"- HP: {GClass138.smethod_9(GClass124.smethod_2().int_25)}/{GClass138.smethod_9(GClass124.smethod_2().int_35)} ({GClass13.smethod_0(GClass124.smethod_2().int_25 * 100 / GClass124.smethod_2().int_35)}%)",
                (GClass62.int_0 == 0) ? $"- KI: {GClass138.smethod_9(GClass124.smethod_2().int_24)}/{GClass138.smethod_9(GClass124.smethod_2().int_36)} ({GClass13.smethod_0(GClass124.smethod_2().int_24 * 100 / GClass124.smethod_2().int_36)}%)" : $"- MP: {GClass138.smethod_9(GClass124.smethod_2().int_24)}/{GClass138.smethod_9(GClass124.smethod_2().int_36)} ({GClass13.smethod_0(GClass124.smethod_2().int_24 * 100 / GClass124.smethod_2().int_36)}%)",
                (GClass62.int_0 == 0) ? ("- SĐ: " + GClass138.smethod_9(GClass124.smethod_2().int_20) + " - Giáp: " + GClass138.smethod_9(GClass124.smethod_2().int_21)) : ("- DMG: " + GClass138.smethod_9(GClass124.smethod_2().int_20) + " - DEF: " + GClass138.smethod_9(GClass124.smethod_2().int_21)),
                null
            };
            if (GClass124.smethod_2().short_24 > 0)
                array[5] = ((GClass62.int_0 != 0) ? ("- STM: " + GClass138.smethod_9(GClass124.smethod_2().int_77) + "/" + GClass138.smethod_9(GClass124.smethod_2().short_24)) : ("- Thể lực: " + GClass138.smethod_9(GClass124.smethod_2().int_77) + "/" + GClass138.smethod_9(GClass124.smethod_2().short_24)));
            if (GClass193.int_12 == 2)
            {
                GUIStyle[] array2 = new GUIStyle[array.Length];
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = new GUIStyle(GUI.skin.label)
                    {
                        alignment = TextAnchor.UpperLeft,
                        fontSize = 6 * GClass193.int_12,
                        fontStyle = FontStyle.Bold
                    };
                    array2[i].normal.textColor = Color.yellow;
                }
                for (int j = 0; j < array.Length; j++)
                {
                    int_0 = GClass13.smethod_2(GClass45.smethod_0().method_4(array2[j], array[j]), int_0);
                    int num = int_1 + 8 * j;
                    g.method_20(0, 0.8f);
                    g.method_15(10, num + 1, int_0, 7);
                    g.method_19(array[j], 12f, GClass193.int_12 - 3 + num, array2[j]);
                }
            }
            else
            {
                for (int k = 0; k < array.Length; k++)
                {
                    int num2 = int_1 + 10 * k;
                    GClass104.gclass104_15.method_6(g, array[k], 6, GClass193.int_12 - 3 + num2 + 1, GClass104.int_0);
                }
            }
        }

        public void method_5()
        {
            if (GClass54.smethod_0().method_5() || !GClass124.smethod_1().bool_38)
                return;
            try
            {
                if (GClass14.smethod_24(0, 150, GClass193.smethod_0(GClass167.gclass20_11), GClass193.smethod_1(GClass167.gclass20_11)) && !GClass14.bool_14)
                {
                    GClass147.smethod_1().method_35();
                    GClass14.gclass113_0.int_29 = 4;
                    GClass14.gclass113_0.method_40();
                    GClass14.gclass113_0.method_50();
                    GClass2.smethod_0().method_127();
                    GClass14.gclass113_1 = new GClass113();
                    GClass14.gclass113_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
                    GClass14.gclass113_1.method_15();
                    GClass14.gclass113_1.method_50();
                    if (GClass14.gclass113_1.bool_0)
                    {
                        GClass14.gclass113_0.int_29 = 0;
                        GClass14.gclass113_0.string_17[21] = mResources.petMainTab;
                        GClass14.gclass113_0.method_39();
                        GClass14.gclass113_0.method_50();
                    }
                    GClass124.smethod_1().gclass119_0 = null;
                    GClass14.smethod_49();
                }
            }
            catch
            {
            }
        }

        public void method_6(string s)
        {
            if (s.ToLower().Contains((mResources.language != 0) ? "why don't you attack, master?" : "sao sư phụ không đánh"))
            {
                bool_5 = true;
                method_11();
            }
        }

        public void method_7()
        {
            if (!bool_11 || !GClass124.smethod_1().bool_38 || GClass124.smethod_1().bool_4)
                return;
            if (GClass77.smethod_18() - long_8 > 1000L)
            {
                for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
                {
                    GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
                    if (gClass == null || (gClass.gclass203_0.short_0 != 454 && gClass.gclass203_0.short_0 != 921))
                    {
                        bool_11 = false;
                        continue;
                    }
                    GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
                    long_8 = GClass77.smethod_18();
                }
            }
            else
                bool_11 = false;
        }

        public void method_8()
        {
            if (!bool_8 || GClass14.int_8 % 25 != 0)
                return;
            if (int_2 != 0)
            {
                int_2 = 0;
                if (GClass14.gclass173_0 == null)
                    GClass14.gclass173_0 = new GClass173();
                GClass179.smethod_0().close();
                GClass14.gclass160_0 = GClass14.gclass173_0;
            }
            else
            {
                int_2++;
                GClass2.smethod_0().method_19(1, "", -1);
            }
        }

        public void method_9()
        {
            if (bool_7 && GClass124.smethod_1().sbyte_28 != 8 && GClass77.smethod_18() - long_5 > 1000L)
            {
                GClass2.smethod_0().method_131(1, 8);
                long_5 = GClass77.smethod_18();
            }
        }

        public GClass6 method_10()
        {
            GClass6 result = null;
            int num = 9999;
            for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
            {
                GClass6 gClass = (GClass6)GClass167.gclass122_9.method_3(i);
                if (gClass.int_12 != 0 && gClass.int_12 != 1 && gClass.int_6 > 0 && !gClass.bool_13 && gClass.sbyte_14 == 0 && gClass.method_16().sbyte_3 != 4)
                {
                    int num2 = GClass191.smethod_24(gClass.int_8, gClass.int_9, GClass124.smethod_1().int_4, GClass124.smethod_1().int_5);
                    if (num > num2)
                    {
                        num = num2;
                        result = gClass;
                    }
                }
            }
            return result;
        }

        public void method_11()
        {
            if (!bool_5)
                return;
            for (int i = 0; i < GClass167.gclass95_0.Length; i++)
            {
                GClass95 gClass = GClass167.gclass95_0[i];
                if (gClass != null && gClass.gclass205_0.sbyte_0 == 19)
                    GClass167.smethod_8().method_64(gClass);
            }
            GClass122 gClass2 = new GClass122();
            bool_5 = false;
            gClass2.method_0(method_10());
            GClass167.smethod_8().method_64(GClass167.gclass95_1[0]);
            GClass2.smethod_0().method_73(gClass2, new GClass122(), 1);
        }

        public void method_12()
        {
            if (bool_3 && !GClass124.smethod_1().bool_62 && GClass124.smethod_1().int_11 == 1 && !GClass57.smethod_0().bool_0 && GClass124.smethod_1().gclass124_4 == null && GClass77.smethod_18() - long_4 > ((!GClass54.smethod_0().method_5()) ? 1000 : 7000))
            {
                GClass124.smethod_1().int_4 = GClass124.smethod_1().int_4 - 5;
                GClass124.smethod_1().int_5 = GClass124.smethod_1().int_5 - 5;
                GClass2.smethod_0().method_44();
                GClass124.smethod_1().int_4 = GClass124.smethod_1().int_4 + 5;
                GClass124.smethod_1().int_5 = GClass124.smethod_1().int_5 + 5;
                GClass2.smethod_0().method_44();
                long_4 = GClass77.smethod_18();
            }
        }

        public void method_13()
        {
            if (bool_0 && GClass77.smethod_18() - long_0 > 302000L)
            {
                GClass2.smethod_0().method_19(1, "", -1);
                long_0 = GClass77.smethod_18();
            }
        }

        public void method_14()
        {
            if (!bool_1 || GClass77.smethod_18() - long_1 <= 1000L)
                return;
            if (list_0.Count <= 0)
            {
                for (int i = 0; i < GClass22.gclass122_0.method_2(); i++)
                {
                    GClass22 gClass = (GClass22)GClass22.gclass122_0.method_3(i);
                    if (gClass.int_6 != 0 && gClass.string_0 != GClass124.smethod_1().string_3 && gClass.int_5 != gClass.int_6)
                    {
                        for (int j = 0; j < 5 - gClass.int_5; j++)
                        {
                            GClass2.smethod_0().method_18(gClass.int_0);
                        }
                    }
                }
                long_1 = GClass77.smethod_18();
                return;
            }
            for (int k = 0; k < list_0.Count; k++)
            {
                string text = list_0[k];
                for (int l = 0; l < GClass22.gclass122_0.method_2(); l++)
                {
                    GClass22 gClass2 = (GClass22)GClass22.gclass122_0.method_3(l);
                    if (gClass2.int_6 != 0 && gClass2.string_0 == text && gClass2.int_5 != gClass2.int_6)
                    {
                        for (int m = 0; m < 5 - gClass2.int_5; m++)
                        {
                            GClass2.smethod_0().method_18(gClass2.int_0);
                        }
                    }
                }
                long_1 = GClass77.smethod_18();
            }
        }

        public void method_15()
        {
            if (!bool_2 || GClass137.int_37 != 21 + GClass124.smethod_1().int_14 || GClass77.smethod_18() - long_2 <= 1000L)
                return;
            int num = 0;
            for (int i = 0; i < GClass124.smethod_1().gclass0_1.Length; i++)
            {
                GClass0 gClass = GClass124.smethod_1().gclass0_1[i];
                if (gClass != null && gClass.gclass203_0.sbyte_0 == 6)
                    num = gClass.int_30;
            }
            if (num < 20)
            {
                for (int j = 0; j < GClass124.smethod_1().gclass0_0.Length; j++)
                {
                    GClass0 gClass2 = GClass124.smethod_1().gclass0_0[j];
                    if (gClass2 != null && gClass2.gclass203_0.sbyte_0 == 6)
                        GClass2.smethod_0().method_30(1, (sbyte)j);
                }
            }
            if (GClass167.smethod_8().gclass126_0.int_196 > 0 && (GClass167.int_37 < 20 || num < 30))
            {
                GClass2.smethod_0().method_60(4);
                GClass2.smethod_0().method_59(4, 0);
            }
            long_2 = GClass77.smethod_18();
        }

        public bool method_16(GClass6 mob)
        {
            if (mob.int_12 != 0 && mob.int_12 != 1 && mob.int_6 > 0 && !mob.bool_13)
            {
                bool num = bool_6 && !GClass82.smethod_0(4387);
                if (mob.sbyte_14 != 0 && num)
                    return false;
                if (!method_17(mob))
                    return false;
                return true;
            }
            return false;
        }

        public bool method_17(GClass6 mob)
        {
            if (GClass48.list_0.Count != 0 && !GClass48.list_0.Contains(mob.int_25))
                return false;
            if (GClass48.list_1.Count == 0 || GClass48.list_1.Contains(mob.int_26))
                return true;
            return false;
        }

        public GClass6 method_18()
        {
            GClass6 result = null;
            int num = int.MaxValue;
            GClass124 gClass = GClass124.smethod_1();
            for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
            {
                GClass6 gClass2 = (GClass6)GClass167.gclass122_9.method_3(i);
                int num2 = (gClass2.int_16 - gClass.int_4) * (gClass2.int_16 - gClass.int_4) + (gClass2.int_17 - gClass.int_5) * (gClass2.int_17 - gClass.int_5);
                if (method_16(gClass2) && num2 < num && gClass2.method_16().sbyte_3 != 4)
                {
                    result = gClass2;
                    num = num2;
                }
            }
            return result;
        }

        public GClass6 method_19()
        {
            GClass6 result = null;
            long num = GClass77.smethod_18();
            for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
            {
                GClass6 gClass = (GClass6)GClass167.gclass122_9.method_3(i);
                if (method_16(gClass) && gClass.long_0 < num)
                {
                    result = gClass;
                    num = gClass.long_0;
                }
            }
            return result;
        }

        public void method_20()
        {
            if (!bool_6 || !GClass124.smethod_1().bool_38)
                return;
            bool flag = GClass167.smethod_14(-GClass124.smethod_1().int_13) != null;
            bool flag2 = GClass124.smethod_2().sbyte_15 == 1;
            if (GClass77.smethod_18() - long_9 > 1000L)
            {
                if (!flag2)
                {
                    GClass2.smethod_0().method_133(1);
                    long_9 = GClass77.smethod_18();
                    return;
                }
                if (!flag)
                {
                    for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
                    {
                        GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
                        if (gClass == null)
                            continue;
                        if (gClass.gclass203_0.short_0 != 454)
                        {
                            if (gClass.gclass203_0.short_0 != 921)
                            {
                                GClass2.smethod_0().method_42(GClass137.int_39, -1);
                                long_9 = GClass77.smethod_18();
                            }
                            else
                            {
                                GClass2.smethod_0().method_20(0, 1, -1, 921);
                                long_9 = GClass77.smethod_18();
                            }
                        }
                        else
                        {
                            GClass2.smethod_0().method_20(0, 1, -1, 454);
                            long_9 = GClass77.smethod_18();
                        }
                        return;
                    }
                }
            }
            bool flag3 = GClass82.smethod_0(4387);
            GClass124 gClass2 = GClass124.smethod_1();
            gClass2.method_104(0);
            if (gClass2.gclass6_0 != null && !method_16(gClass2.gclass6_0))
                gClass2.gclass6_0 = null;
            if (gClass2.gclass6_0 == null)
            {
                gClass2.gclass6_0 = method_18();
                if (flag3 && gClass2.gclass6_0 != null)
                    GClass47.smethod_0().method_26(gClass2.gclass6_0.int_16 - 24, gClass2.gclass6_0.int_17);
            }
            if (gClass2.gclass6_0 != null)
            {
                GClass6 gclass6_ = gClass2.gclass6_0;
                gclass6_.int_8 = gclass6_.int_16;
                gclass6_.int_9 = gclass6_.int_17;
                if (GClass191.smethod_24(gclass6_.int_16, gclass6_.int_17, gClass2.int_4, gClass2.int_5) > 48 || gclass6_.int_6 <= 1)
                    GClass48.smethod_0().method_11(gclass6_.int_16, gclass6_.int_17);
            }
            else if (!flag3)
            {
                GClass6 gClass3 = method_19();
                if (gClass3 != null)
                    GClass48.smethod_0().method_11(gClass3.int_16 - 24, gClass3.int_17);
            }
        }

        public void method_21(int index)
        {
            if (index != -1)
            {
                if (!list_1.Contains(index))
                {
                    list_1.Add(index);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added [{index}] to list healing" : $"Đã thêm [{index}] vào d/s trị thương", 0);
                }
                else
                {
                    list_1.Remove(index);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? $"Deleted [{index}] from list healing" : $"Đã xóa [{index}] khỏi d/s trị thương", 0);
                }
            }
            else if (GClass124.smethod_1().gclass124_0 != null)
            {
                GClass124 gclass124_ = GClass124.smethod_1().gclass124_0;
                if (list_1.Contains(gclass124_.int_13))
                {
                    list_1.Remove(gclass124_.int_13);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Deleted [" + gclass124_.string_3 + "] from list healing") : ("Đã xóa [" + gclass124_.string_3 + "] khỏi d/s trị thương"), 0);
                }
                else
                {
                    list_1.Add(gclass124_.int_13);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added [" + gclass124_.string_3 + "] to list healing") : ("Đã thêm [" + gclass124_.string_3 + "] vào d/s trị thương"), 0);
                }
            }
        }

        public void method_22()
        {
            if (!bool_9)
                return;
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                if (!(GClass167.gclass122_5.method_3(i) is GClass124 gClass) || !list_1.Contains(gClass.int_13) || (gClass.int_25 >= gClass.int_35 * 10 / 100 && gClass.int_25 > 1 && !gClass.bool_62))
                    continue;
                for (int j = 0; j < GClass167.gclass95_0.Length; j++)
                {
                    GClass95 gClass2 = GClass167.gclass95_0[j];
                    if (gClass2 == null || GClass77.smethod_18() - gClass2.long_1 <= gClass2.int_1 + 100 || gClass2.gclass205_0.int_3 != 2)
                        continue;
                    int num = 0;
                    int num2 = ((gClass2.gclass205_0.int_2 == 2) ? 1 : ((gClass2.gclass205_0.int_2 == 1) ? (gClass2.int_5 * GClass124.smethod_1().int_36 / 100) : gClass2.int_5));
                    if (GClass124.smethod_1().int_24 >= num2)
                    {
                        if (gClass2 == GClass124.smethod_1().gclass95_0)
                        {
                            GClass122 gClass3 = new GClass122();
                            gClass3.method_0(GClass124.smethod_1());
                            GClass2.smethod_0().method_73(new GClass122(), gClass3, -1);
                            gClass2.long_1 = GClass77.smethod_18();
                            break;
                        }
                        GClass167.smethod_8().method_62(gClass2, true);
                        return;
                    }
                }
            }
        }

        public void method_23()
        {
            if (int_3 != 0 && GClass124.smethod_1().bool_38 && GClass77.smethod_18() - long_6 > 5000L && GClass124.smethod_2().int_25 <= GClass124.smethod_2().int_35 * int_3 / 100)
            {
                GClass167.smethod_8().method_50();
                long_6 = GClass77.smethod_18();
            }
        }

        public void method_24()
        {
            if (GClass14.int_8 % 10 == 0 && GClass124.smethod_1().bool_38 && bool_10 && !GClass124.smethod_1().bool_4 && GClass124.smethod_2().sbyte_15 != 3 && GClass124.smethod_2().sbyte_15 != 3)
                GClass2.smethod_0().method_133(3);
        }

        public void method_25()
        {
            if (long_7 != 0L && GClass124.smethod_1().bool_38 && GClass124.smethod_2().long_2 >= long_7)
                Application.Quit();
        }
    }
}
