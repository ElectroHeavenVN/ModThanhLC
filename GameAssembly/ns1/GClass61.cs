using System;
using System.Text;
using ns0;

namespace ns1
{
    public class GClass61 : GInterface1
    {
        public int int_0 = -1;

        public int int_1 = -1;

        public int int_2 = -1;

        public int int_3 = -1;

        public int int_4 = -1;

        public long long_0;

        public long long_1;

        public long long_2 = -1L;

        public bool bool_0;

        public long long_3;

        public long long_4;

        public bool bool_1;

        public bool bool_2;

        public bool bool_3;

        public long long_5;

        public bool bool_4;

        public long long_6;

        private static GClass61 gclass61_0;

        private int[] int_5;

        private int[] int_6;

        private int[] int_7;

        public bool bool_5 = true;

        public static int int_8;

        public long long_7 = 500L;

        public static GClass61 smethod_0()
        {
            return (gclass61_0 != null) ? gclass61_0 : (gclass61_0 = new GClass61());
        }

        public void perform(int idAction, object p)
        {
            if (idAction != 10006)
            {
                switch (idAction)
                {
                    case 50231:
                        if (!GClass57.smethod_0().bool_0)
                            method_0("/spos");
                        break;
                    case 50232:
                        if (!GClass57.smethod_0().bool_0)
                            method_0("/szone");
                        break;
                    case 50233:
                        if (!GClass57.smethod_0().bool_0)
                            method_0("/smap");
                        break;
                    case 50234:
                        if (!GClass57.smethod_0().bool_0)
                        {
                            int_1 = GClass124.smethod_1().int_4;
                            int_2 = GClass124.smethod_1().int_5;
                            int_3 = GClass137.int_39;
                            int_4 = GClass137.int_37;
                            GClass51.smethod_1((GClass62.int_0 != 0) ? "Saved goback informations" : "Đã lưu thông tin Goback", 0);
                        }
                        break;
                    case 50235:
                        if (!GClass57.smethod_0().bool_0)
                        {
                            int_1 = -1;
                            int_2 = -1;
                            int_3 = -1;
                            int_4 = -1;
                            GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã xóa thông tin Goback" : "Deleted goback informations", 0);
                        }
                        break;
                    case 50236:
                        bool_0 = !bool_0;
                        GClass51.smethod_1("Goback khi hết KI: " + GClass45.smethod_0().method_6(bool_0), 0);
                        break;
                }
            }
            else
            {
                GClass122 gClass = new GClass122();
                gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ((int_1 == -1 || int_2 == -1) ? "Ấn để lưu\n Vị trí" : $"Lưu vị trí\nX: {int_1}\nY: {int_2}") : ((int_1 == -1 || int_2 == -1) ? "Click to save\nPosition" : $"Save position\nX: {int_1}\nY: {int_2}"), smethod_0(), 50231, null));
                gClass.method_0(new GClass118((GClass62.int_0 != 0) ? ((int_3 != -1) ? $"Save zone\nzone: {int_3}" : "Click to save\nZone") : ((int_3 != -1) ? $"Lưu khu\nKhu: {int_3}" : "Ấn để lưu\n Khu"), smethod_0(), 50232, null));
                gClass.method_0(new GClass118((GClass62.int_0 != 0) ? ((int_4 != -1) ? ("Save map\n" + GClass137.string_2[int_4]) : "Click to save\n Map") : ((int_4 != -1) ? ("Lưu map\n" + GClass137.string_2[int_4]) : "Ấn để lưu\n Map"), smethod_0(), 50233, null));
                gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Lưu tất cả" : "Save all", smethod_0(), 50234, null));
                gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Delete\nInformations" : "Xóa \nthông tin", smethod_0(), 50235, null));
                if (GClass62.string_3.Contains("username:9A01EF591420C1A023F1D2A1EE25EDE9") || GClass62.string_3.Contains("username:21232F297A57A5A743894A0E4A801FC3"))
                    gClass.method_0(new GClass118("Goback khi\n Hết KI\n" + GClass45.smethod_0().method_7(bool_0), smethod_0(), 50236, null));
                GClass14.gclass116_0.bool_1 = true;
                GClass14.gclass116_0.method_2(gClass, 0);
            }
        }

        public bool method_0(string text)
        {
            switch (text)
            {
                case "/spos":
                    if (int_1 == -1 && int_2 == -1)
                    {
                        int_1 = GClass124.smethod_1().int_4;
                        int_2 = GClass124.smethod_1().int_5;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? $"Goback - Save position [X: {int_1} -Y: {int_2}]" : $"Goback - Lưu vị trí [X: {int_1} -Y: {int_2}]", 0);
                    }
                    else
                    {
                        int_1 = -1;
                        int_2 = -1;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? "Goback - Delete position" : "Goback - Xóa lưu vị trí", 0);
                    }
                    return true;
                case "/lcz":
                    bool_2 = !bool_2;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Lock change zone: " + GClass45.smethod_0().method_6(bool_2)) : ("Khóa chuyển khu: " + GClass45.smethod_0().method_6(bool_2)), 0);
                    return true;
                case "/kz":
                    int_0 = -1;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã tắt tự động đổi khu" : "Turn off auto change zone", 0);
                    return true;
                case "/smap":
                    if (int_4 == -1)
                    {
                        int_4 = GClass137.int_37;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? $"Goback - Save map [{int_4}]" : $"Goback - Lưu map [{int_4}]", 0);
                    }
                    else
                    {
                        int_4 = -1;
                        GClass51.smethod_1((GClass62.int_0 == 0) ? "Goback - Xóa map" : "Goback - Delete map", 0);
                    }
                    return true;
                case "/lcm":
                    bool_1 = !bool_1;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Lock change map: " + GClass45.smethod_0().method_6(bool_1)) : ("Khóa chuyển map: " + GClass45.smethod_0().method_6(bool_1)), 0);
                    return true;
                case "/vdh":
                    smethod_0().bool_5 = !smethod_0().bool_5;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Di chuyển vượt địa hình: " + GClass45.smethod_0().method_6(smethod_0().bool_5)) : ("Move cross terrain: " + GClass45.smethod_0().method_6(smethod_0().bool_5)), 0);
                    return true;
                case "/szone":
                    if (int_3 != -1)
                    {
                        int_3 = -1;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? "Goback - Delete zone" : "Goback - Xóa lưu khu", 0);
                    }
                    else
                    {
                        int_3 = GClass137.int_39;
                        GClass51.smethod_1((GClass62.int_0 == 0) ? $"Goback - Lưu khu [{int_3}]" : $"Goback - Save zone [{int_3}]", 0);
                    }
                    return true;
            }
            if (GClass45.smethod_0().method_11<int>(text, "/kz"))
            {
                int_0 = GClass45.smethod_0().method_12<int>(text, "/kz");
                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tự động đổi khu [{int_0}]" : $"Auto change zone [{int_0}]", 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/abdkb"))
            {
                int_8 = GClass45.smethod_0().method_12<int>(text, "/abdkb");
                bool_3 = !bool_3;
                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Auto opten T.U.S Level [{int_8}]: {GClass45.smethod_0().method_6(bool_3)}" : $"Tự động mở BDKB Level [{int_8}]: {GClass45.smethod_0().method_6(bool_3)}", 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/k"))
            {
                int num2 = GClass45.smethod_0().method_12<int>(text, "/k");
                GClass2.smethod_0().method_42(num2, -1);
                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Change zone [{num2}]" : $"Đổi khu [{num2}]", 0);
            }
            else 
                return false;
            return true;
        }

        public void method_1()
        {
            if (!bool_3 || int_8 <= 0 || GClass14.gclass160_0 == GClass171.gclass171_0 || GClass124.bool_33 || GClass93.bool_5 || GClass124.bool_35)
                return;
            if (GClass137.int_37 != 5)
            {
                int_8 = 0;
                bool_3 = false;
            }
            if (GClass77.smethod_18() - long_5 <= 500L)
                return;
            if (GClass164.gclass164_0 != null)
            {
                for (int i = 0; i < GClass164.gclass164_0.gclass136_0.Length; i++)
                {
                    GClass164.gclass164_0.gclass136_0[i].method_23(int_8.ToString());
                }
                GClass2.smethod_0().method_7(GClass164.gclass164_0.gclass136_0);
                GClass167.gclass167_0.switchToMe();
                GClass2.smethod_0().method_59(13, 0);
                GClass53.smethod_0().method_0();
                long_5 = GClass77.smethod_18();
            }
            if (!GClass14.gclass116_0.bool_0 || GClass14.gclass116_0 == null)
            {
                GClass2.smethod_0().method_60(13);
                GClass53.smethod_0().method_0();
                long_5 = GClass77.smethod_18();
            }
            else
            {
                if (GClass14.gclass116_0 == null || !GClass14.gclass116_0.bool_0)
                    return;
                for (int j = 0; j < GClass14.gclass116_0.gclass122_0.method_2(); j++)
                {
                    GClass118 gClass = (GClass118)GClass14.gclass116_0.gclass122_0.method_3(j);
                    if (!GClass45.smethod_0().method_0(gClass.string_0, (mResources.language == 0) ? "nóichuyện" : "talk"))
                    {
                        if (!GClass45.smethod_0().method_0(gClass.string_0, (mResources.language != 0) ? "treasureundersea" : "khobáudướibiển"))
                        {
                            if (GClass45.smethod_0().method_0(gClass.string_0, (mResources.language != 0) ? "chooselevel" : "chọncấpđộ"))
                            {
                                GClass2.smethod_0().method_59(13, (sbyte)j);
                                GClass53.smethod_0().method_0();
                                long_5 = GClass77.smethod_18();
                                break;
                            }
                            continue;
                        }
                        GClass2.smethod_0().method_59(13, (sbyte)j);
                        GClass53.smethod_0().method_0();
                        long_5 = GClass77.smethod_18();
                        break;
                    }
                    GClass2.smethod_0().method_59(13, (sbyte)j);
                    GClass53.smethod_0().method_0();
                    long_5 = GClass77.smethod_18();
                    break;
                }
            }
        }

        public void method_2()
        {
            smethod_1();
            method_10();
            method_6();
            method_5();
            method_1();
            method_4();
        }

        public void method_3()
        {
            if (bool_3 && GClass77.smethod_18() - long_5 > 200L)
            {
                if (GClass137.int_37 == 5)
                {
                    GClass2.smethod_0().method_59(13, 0);
                    long_5 = GClass77.smethod_18();
                }
                else
                    bool_3 = false;
            }
        }

        public void method_4()
        {
            if (bool_4 && GClass77.smethod_18() - long_6 > 100L)
            {
                if (GClass137.int_37 != 27)
                {
                    bool_4 = false;
                    return;
                }
                GClass2.smethod_0().method_60(25);
                GClass2.smethod_0().method_59(25, 0);
                long_6 = GClass77.smethod_18();
            }
        }

        public void method_5()
        {
            try
            {
                if (int_0 == -1)
                {
                    if (long_7 != 500L)
                        long_7 = 500L;
                }
                else
                    long_7 = ((GClass137.int_37 != int_0) ? 100 : 500);
                if (GClass77.smethod_18() - long_4 > long_7)
                {
                    GClass2.smethod_0().method_58();
                    long_4 = GClass77.smethod_18();
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/UpdateZone.txt", ex.ToString());
            }
        }

        public void method_6()
        {
            try
            {
                if ((GClass42.smethod_0().bool_6 && !GClass42.smethod_0().bool_7) || (GClass42.smethod_0().bool_8 && !GClass42.smethod_0().bool_9) || (GClass42.smethod_0().bool_3 && GClass42.smethod_0().method_22() > 0))
                    return;
                bool flag = false;
                if (int_1 == -1 && int_2 == -1 && int_3 == -1 && int_4 == -1)
                    return;
                if (!GClass124.smethod_1().bool_62)
                {
                    if (bool_0 && GClass124.smethod_1().int_24 < GClass124.smethod_1().int_36 * 5 / 100 && GClass137.int_37 != GClass124.smethod_1().int_14 + 21)
                    {
                        flag = false;
                        long_2 = -1L;
                        Class11.smethod_0().method_8(21 + GClass124.smethod_1().int_14);
                        return;
                    }
                    if (GClass137.int_37 == GClass124.smethod_1().int_14 + 21 && !flag)
                    {
                        for (int i = 0; i < GClass167.gclass122_6.method_2(); i++)
                        {
                            if ((GClass167.gclass122_6.method_3(i) as GClass190).gclass203_0.short_0 == 74)
                            {
                                GClass2.smethod_0().method_74(-1);
                                flag = true;
                                long_2 = GClass77.smethod_18();
                                return;
                            }
                        }
                    }
                    if (int_4 != -1 && GClass137.int_37 != int_4 && long_2 == -1L && !flag)
                        Class11.smethod_0().method_8(int_4);
                    else if (int_4 != -1 && GClass137.int_37 != int_4 && GClass77.smethod_18() - long_2 > 3000L && long_2 != -1L)
                    {
                        Class11.smethod_0().method_8(int_4);
                    }
                    else
                    {
                        if (int_4 != -1 && GClass137.int_37 != int_4)
                            return;
                        if (int_3 != -1 && GClass167.smethod_8().int_63 != null && GClass77.smethod_18() - long_0 > 1000L && GClass137.int_39 != int_3 && 15 - GClass167.smethod_8().int_63[int_3] > 0)
                        {
                            GClass2.smethod_0().method_42(int_3, -1);
                            long_0 = GClass77.smethod_18();
                        }
                        else
                        {
                            if ((int_3 != -1 && GClass137.int_39 != int_3 && GClass167.smethod_8().int_63 != null) || int_1 == -1 || int_2 == -1)
                                return;
                            if (GClass124.smethod_1().int_4 != int_1 || GClass124.smethod_1().int_5 != int_2)
                            {
                                if (long_1 == -1L)
                                    long_1 = GClass77.smethod_18();
                                if (GClass77.smethod_18() - long_1 > 5000L && long_1 != -1L)
                                    method_9(int_1, int_2);
                            }
                            if (GClass124.smethod_1().int_4 == int_1 && GClass124.smethod_1().int_5 == int_2)
                                long_1 = -1L;
                        }
                    }
                }
                else
                {
                    flag = false;
                    long_2 = -1L;
                    GClass2.smethod_0().method_76();
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/Goback.txt", ex.ToString());
            }
        }

        public int method_7(int cx, int cy)
        {
            for (int i = cy; i < GClass137.int_24 - 24; i += 24)
            {
                if (GClass137.smethod_28(cx, i, 2))
                    return i - i % 24;
            }
            int num = cy;
            while (num > 24)
            {
                if (!GClass137.smethod_28(cx, num, 2))
                {
                    num -= 24;
                    continue;
                }
                return num - num % 24;
            }
            return cy;
        }

        public int method_8()
        {
            int num = 0;
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                GClass124 gClass = (GClass124)GClass167.gclass122_5.method_3(i);
                if (gClass != null && gClass.string_3 != null && gClass.string_3 != "" && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.int_13 > 0)
                    num++;
            }
            return num;
        }

        public void method_9(int x, int y)
        {
            GClass124.smethod_1().int_4 = x;
            GClass124.smethod_1().int_5 = y;
            GClass2.smethod_0().method_44();
            GClass124.smethod_1().int_4 = x;
            GClass124.smethod_1().int_5 = method_7(x, y) + 12;
            GClass2.smethod_0().method_44();
            GClass124.smethod_1().int_4 = x;
            GClass124.smethod_1().int_5 = y;
            GClass2.smethod_0().method_44();
        }

        public void method_10()
        {
            if (int_0 != -1 && !GClass57.smethod_0().bool_0 && GClass167.smethod_8().int_63 != null && GClass137.int_37 != 21 + GClass124.smethod_1().int_14 && (GClass137.int_37 > 50 || GClass137.int_37 < 45) && GClass137.int_37 != 154 && GClass137.int_37 != 153 && (GClass137.int_37 > 138 || GClass137.int_37 < 135) && GClass77.smethod_18() - long_3 > 1000L && ((GClass54.smethod_0().method_5() && GClass167.smethod_8().int_63[int_0] < 25) || (!GClass54.smethod_0().method_5() && 15 - GClass167.smethod_8().int_63[int_0] > 0)) && GClass137.int_39 != int_0)
            {
                GClass2.smethod_0().method_42(int_0, -1);
                long_3 = GClass77.smethod_18();
            }
        }

        public static void smethod_1()
        {
            try
            {
                if (!smethod_0().bool_5 || (GClass124.smethod_1().int_11 != 2 && GClass124.smethod_1().int_11 != 4 && GClass124.smethod_1().int_11 != 10))
                    return;
                int num = GClass124.smethod_1().int_4 + GClass124.smethod_1().int_12 * 24;
                if (GClass137.smethod_27(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5 - 24) != 0 || GClass137.smethod_27(num, GClass124.smethod_1().int_5 - 24) <= 0 || GClass137.smethod_27(num, GClass124.smethod_1().int_5 - 24) >= 14)
                    return;
                int num2 = 0;
                for (int i = 6; i < GClass137.int_22; i++)
                {
                    if (GClass137.smethod_26(num / GClass137.sbyte_0, i) != 0)
                    {
                        num2 = i;
                        break;
                    }
                }
                GClass124.smethod_1().int_4 = num;
                GClass124.smethod_1().int_5 = num2 * GClass137.sbyte_0;
                GClass2.smethod_0().method_44();
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/crossTerrain.txt", ex.ToString());
            }
        }

        private void method_11()
        {
            method_14();
            int num = GClass137.gclass122_0.method_2();
            if (num == 2)
            {
                GClass15 gClass = (GClass15)GClass137.gclass122_0.method_3(0);
                GClass15 gClass2 = (GClass15)GClass137.gclass122_0.method_3(1);
                if ((gClass.short_2 < 60 && gClass2.short_2 < 60) || (gClass.short_0 > GClass137.int_23 - 60 && gClass2.short_0 > GClass137.int_23 - 60))
                {
                    int_5[0] = gClass.short_0 + 15;
                    int_5[1] = gClass.short_3;
                    int_7[0] = gClass2.short_2 - 15;
                    int_7[1] = gClass2.short_3;
                }
                else if (gClass.short_2 < gClass2.short_2)
                {
                    int_5[0] = gClass.short_0 + 15;
                    int_5[1] = gClass.short_3;
                    int_7[0] = gClass2.short_2 - 15;
                    int_7[1] = gClass2.short_3;
                }
                else
                {
                    int_5[0] = gClass2.short_0 + 15;
                    int_5[1] = gClass2.short_3;
                    int_7[0] = gClass.short_2 - 15;
                    int_7[1] = gClass.short_3;
                }
                return;
            }
            for (int i = 0; i < num; i++)
            {
                GClass15 gClass3 = (GClass15)GClass137.gclass122_0.method_3(i);
                if (gClass3.short_2 < 60)
                {
                    int_5[0] = gClass3.short_0 + 15;
                    int_5[1] = gClass3.short_3;
                }
                else if (gClass3.short_2 > GClass137.int_23 - 60)
                {
                    int_7[0] = gClass3.short_2 - 15;
                    int_7[1] = gClass3.short_3;
                }
                else
                {
                    int_6[0] = gClass3.short_0 + 15;
                    int_6[1] = gClass3.short_3;
                }
            }
        }

        public int method_12(int x)
        {
            int num = 50;
            int num2 = 0;
            while (num2 < 30)
            {
                num2++;
                num += 24;
                if (GClass137.smethod_28(x, num, 2))
                {
                    if (num % 24 != 0)
                        num -= num % 24;
                    break;
                }
            }
            return num;
        }

        public void method_13(int x, int y)
        {
            if (GClass167.bool_69)
            {
                GClass124.smethod_1().int_4 = x;
                GClass124.smethod_1().int_5 = y;
                GClass2.smethod_0().method_44();
                return;
            }
            GClass124.smethod_1().int_4 = x;
            GClass124.smethod_1().int_5 = y;
            GClass2.smethod_0().method_44();
            GClass124.smethod_1().int_4 = x;
            GClass124.smethod_1().int_5 = y + 1;
            GClass2.smethod_0().method_44();
            GClass124.smethod_1().int_4 = x;
            GClass124.smethod_1().int_5 = y;
            GClass2.smethod_0().method_44();
        }

        private void method_14()
        {
            int_5 = new int[2];
            int_6 = new int[2];
            int_7 = new int[2];
        }

        public bool method_15()
        {
            return GClass137.int_37 >= 85 && GClass137.int_37 <= 91;
        }

        public static GClass15 smethod_2(int type)
        {
            if (GClass137.gclass122_0.method_2() == 1)
                return (GClass15)GClass137.gclass122_0.method_3(0);
            for (int i = 0; i < GClass137.gclass122_0.method_2(); i++)
            {
                GClass15 gClass = (GClass15)GClass137.gclass122_0.method_3(i);
                if (type == 0)
                {
                    if ((GClass137.int_37 == 70 && smethod_3(gClass.gclass139_0) == "Vực cấm") || (GClass137.int_37 == 73 && smethod_3(gClass.gclass139_0) == "Vực chết") || (GClass137.int_37 == 110 && smethod_3(gClass.gclass139_0) == "Rừng tuyết"))
                        return gClass;
                    if (gClass.short_2 < 60)
                        return gClass;
                }
                if (type == 1)
                {
                    if (((GClass137.int_37 == 106 || GClass137.int_37 == 107) && smethod_3(gClass.gclass139_0) == "Hang băng") || ((GClass137.int_37 == 105 || GClass137.int_37 == 108) && smethod_3(gClass.gclass139_0) == "Rừng băng") || (GClass137.int_37 == 109 && smethod_3(gClass.gclass139_0) == "Cánh đồng tuyết"))
                        return gClass;
                    if (GClass137.int_37 == 27)
                        return null;
                    if (gClass.short_0 < GClass137.int_23 - 60 && gClass.short_2 >= 60)
                        return gClass;
                }
                if (type == 2)
                {
                    if (GClass137.int_37 == 70 && smethod_3(gClass.gclass139_0) == "Căn cứ Raspberry")
                        return gClass;
                    if (gClass.short_0 > GClass137.int_23 - 60)
                        return gClass;
                }
            }
            return null;
        }

        public static string smethod_3(GClass139 popUp)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < popUp.string_0.Length; i++)
            {
                stringBuilder.Append(popUp.string_0[i]);
                stringBuilder.Append(" ");
            }
            return stringBuilder.ToString().Trim();
        }

        public void method_16(GClass15 waypoint)
        {
            if (waypoint.bool_1)
                GClass2.smethod_0().method_114();
            else
                GClass2.smethod_0().method_40();
        }

        public void method_17(int position)
        {
            if (!method_15())
            {
                method_11();
                switch (position)
                {
                    case 0:
                        if (GClass137.int_37 != 70)
                        {
                            if (int_5[0] == 0 || int_5[1] == 0)
                                method_13(60, method_12(60));
                            else
                                method_13(int_5[0], int_5[1]);
                        }
                        else
                            method_13(10, 192);
                        break;
                    case 1:
                        if (int_7[0] != 0 && int_7[1] != 0)
                            method_13(int_7[0], int_7[1]);
                        else
                            method_13(GClass137.int_23 - 60, method_12(GClass137.int_23 - 60));
                        break;
                    case 2:
                        if (int_6[0] == 0 || int_6[1] == 0)
                            method_13(GClass137.int_23 / 2, method_12(GClass137.int_23 / 2));
                        else
                            method_13(int_6[0], int_6[1]);
                        break;
                }
                if (GClass137.int_37 == 7 || GClass137.int_37 == 14 || GClass137.int_37 == 0)
                    GClass2.smethod_0().method_114();
                else
                    GClass2.smethod_0().method_40();
            }
            else
                method_18(position);
        }

        private void method_18(int int_9)
        {
            if (int_9 == 0)
            {
                method_13(60, method_12(60));
                return;
            }
            if (int_9 != 2)
            {
                method_13(GClass137.int_23 - 60, method_12(GClass137.int_23 - 60));
                return;
            }
            for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
            {
                GClass125 gClass = (GClass125)GClass167.gclass122_10.method_3(i);
                if (gClass.gclass120_0.int_0 >= 30 && gClass.gclass120_0.int_0 <= 36)
                {
                    GClass124.smethod_1().gclass125_0 = gClass;
                    method_13(gClass.int_4, gClass.int_5 - 3);
                    break;
                }
            }
        }
    }
}
