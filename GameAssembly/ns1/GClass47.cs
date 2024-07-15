using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;
using UnityEngine;
using Vietpad.InputMethod;

namespace ns1
{
    public class GClass47 : GInterface1, GInterface3
    {
        public struct GStruct9
        {
            public int int_0;

            public int int_1;

            public int int_2;

            public int int_3;

            public GStruct9(int mobId, int templateID, int xFirst, int yFirst)
            {
                int_0 = mobId;
                int_1 = templateID;
                int_2 = xFirst;
                int_3 = yFirst;
            }
        }

        public struct GStruct10
        {
            public int int_0;

            public int int_1;

            public int int_2;

            public GStruct10(int headID, int bodyID, int legID)
            {
                int_0 = headID;
                int_1 = bodyID;
                int_2 = legID;
            }
        }

        public bool bool_0;

        public int int_0 = 7;

        public bool bool_1;

        public bool bool_2;

        public int int_1 = 0;

        public int int_2 = -1;

        public int int_3 = -1;

        public int int_4;

        public long long_0;

        public bool bool_3;

        public int int_5 = -1;

        public bool bool_4;

        public long long_1;

        public bool bool_5;

        public bool bool_6;

        public int int_6 = -1;

        public bool bool_7;

        public List<int> list_0 = new List<int>();

        public List<int> list_1 = new List<int>();

        public List<int> list_2 = new List<int>();

        public bool bool_8;

        public bool bool_9;

        public int[] int_7 = new int[3];

        public long long_2;

        public int int_8 = 0;

        public int int_9 = 0;

        public long long_3;

        private static short short_0 = 454;

        private static short short_1 = 921;

        public bool bool_10;

        public int int_10;

        public static List<GClass125> list_3 = new List<GClass125>();

        public bool bool_11;

        public string string_0 = string.Empty;

        public long long_4;

        public long long_5;

        public bool bool_12;

        public int int_11 = 0;

        public long long_6;

        public long long_7;

        public string string_1 = string.Empty;

        private static GClass47 gclass47_0;

        public long long_8;

        public int[] int_12 = new int[4] { 10010100, 10453645, 14447611, 9928083 };

        public List<int> list_4 = new List<int>();

        public static readonly sbyte[] sbyte_0 = new sbyte[7] { 0, 2, 17, 4, 19, 12, 13 };

        public static List<sbyte> list_5 = new List<sbyte>(sbyte_0);

        public static readonly sbyte[] sbyte_1 = new sbyte[5] { 0, 9, 2, 17, 4 };

        public static readonly sbyte[] sbyte_2 = new sbyte[5] { 10, 11, 14, 23, 7 };

        public long long_9;

        public GStruct10 gstruct10_0 = default(GStruct10);

        public bool bool_13;

        public int int_13 = 8;

        public int int_14 = 0;

        public int int_15 = 0;

        public int int_16 = 5;

        public int int_17 = 25;

        public List<GClass124> list_6 = new List<GClass124>();

        public int int_18 = 3;

        public bool bool_14;

        public List<GClass124> list_9 = new List<GClass124>();

        public int int_19;

        public List<GStruct9> list_10 = new List<GStruct9>();

        public int int_20 = 0;

        public bool bool_15;

        public bool bool_16 = false;

        public long long_10;

        public long long_11;

        public bool bool_17;

        public bool bool_18;

        public List<GInterface6> List_0 { get; private set; } = new List<GInterface6>();

        public List<GInterface6> List_1 { get; private set; } = new List<GInterface6>();

        public static GClass47 smethod_0()
        {
            return (gclass47_0 != null) ? gclass47_0 : (gclass47_0 = new GClass47());
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
                if (!GClass107.smethod_0().string_1.Equals((GClass62.int_0 != 0) ? "Fill % HP use porata" : "Nhập % HP sử dụng bông tai"))
                {
                    if (!GClass107.smethod_0().string_1.Equals((GClass62.int_0 == 0) ? "Nhập %HP,%KI sử dụng bông tai" : "Fill %HP,%KI use porata"))
                    {
                        if (!GClass107.smethod_0().string_1.Equals((GClass62.int_0 == 0) ? "Nhập độ trễ sử dụng item (ms)" : "Put time delay use item (ms)"))
                        {
                            if (GClass107.smethod_0().string_1.Equals((GClass62.int_0 == 0) ? "Đồ sát nhân vật dưới mức HP" : "Murdering character have the HP lower than setting"))
                            {
                                int_1 = int.Parse(GClass107.smethod_0().gclass136_0.method_21());
                                method_0();
                            }
                            else if (GClass107.smethod_0().string_1.Equals((GClass62.int_0 != 0) ? "Fill auto global chat content!" : "Nhập nội dung auto chat thế giới !") && GClass107.smethod_0().gclass136_0.method_21() != string.Empty)
                            {
                                string_1 = GClass107.smethod_0().gclass136_0.method_21();
                                bool_12 = true;
                                GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto global Chat: " + GClass45.smethod_0().method_6(bool_12)) : ("Auto chat thế giới: " + GClass45.smethod_0().method_6(bool_12)), 0);
                                method_0();
                            }
                        }
                        else
                        {
                            GClass42.smethod_0().long_9 = long.Parse(GClass107.smethod_0().gclass136_0.method_21());
                            method_0();
                        }
                    }
                    else
                    {
                        method_3("/abt" + GClass107.smethod_0().gclass136_0.method_21());
                        method_0();
                    }
                }
                else
                {
                    method_3($"/abt{int.Parse(GClass107.smethod_0().gclass136_0.method_21())}");
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
            if (GClass57.smethod_0().bool_0)
                return;
            if (idAction > 10248)
            {
                switch (idAction)
                {
                    case 101301:
                        GClass2.smethod_0().method_78("/cobj");
                        return;
                    case 101302:
                        smethod_0().method_1((GClass62.int_0 != 0) ? "Fill %HP,%KI use porata" : "Nhập %HP,%KI sử dụng bông tai");
                        return;
                    case 101303:
                        GClass48.smethod_0().method_7("item", "id", 590);
                        GClass48.smethod_0().method_7("item", "id", 74);
                        return;
                }
                switch (idAction)
                {
                    case 101601:
                        method_3("/dsnv");
                        return;
                    case 101602:
                        if (int_18 < 3)
                            int_18++;
                        else
                            int_18 = 1;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? ("List Character sorted by: " + ((int_18 == 1) ? "flag color" : ((int_18 == 2) ? "clan name" : "default"))) : ("Danh sách nhân vật sắp xếp theo: " + ((int_18 == 1) ? "màu cờ" : ((int_18 == 2) ? "Tên bang hội" : "Mặc định"))), 1);
                        return;
                    case 101603:
                        method_3("/oinf");
                        return;
                    case 101604:
                        method_3("/ahs");
                        return;
                    case 101605:
                        GClass54.smethod_0().bool_7 = !GClass54.smethod_0().bool_7;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto follow char have DragonBall/BlackStarDragonBall: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_7)) : ("Tự động ghim người có NRĐ/Viên NRĐ: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_7)), 0);
                        return;
                    case 101606:
                        GClass54.smethod_0().int_4 = ((GClass54.smethod_0().int_4 != -1) ? (-1) : GClass124.smethod_1().gclass124_0.int_13);
                        GClass54.smethod_0().string_0 = ((GClass54.smethod_0().int_4 != -1) ? string.Empty : ((!GClass124.smethod_1().gclass124_0.string_3.Contains("]")) ? GClass124.smethod_1().gclass124_0.string_3 : GClass124.smethod_1().gclass124_0.string_3.Split(']')[1].Trim()));
                        GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động ghim khi Capsule Bom: " + GClass45.smethod_0().method_6(GClass54.smethod_0().int_4 != -1)) : ("Auto follow char when use Capsule Bom: " + GClass45.smethod_0().method_6(GClass54.smethod_0().int_4 != -1)), 0);
                        return;
                    case 101607:
                        GClass54.smethod_0().bool_8 = !GClass54.smethod_0().bool_8;
                        GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động dùng khiên trước khi Bom: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_8)) : ("Auto use shield before use Bom: " + GClass45.smethod_0().method_6(GClass54.smethod_0().bool_8)), 0);
                        return;
                    case 101608:
                        method_12();
                        return;
                }
                switch (idAction)
                {
                    case 101802:
                        GClass61.smethod_0().bool_4 = !GClass61.smethod_0().bool_4;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto open one eye dungeon: " + GClass45.smethod_0().method_7(GClass61.smethod_0().bool_4)) : ("Tự động mở DTĐN: " + GClass45.smethod_0().method_7(GClass61.smethod_0().bool_4)), 0);
                        break;
                    case 101803:
                        GClass45.smethod_0().bool_0 = !GClass45.smethod_0().bool_0;
                        VietKeyHandler.VietModeEnabled = GClass45.smethod_0().bool_0;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? ("Vietkey: " + GClass45.smethod_0().method_7(GClass45.smethod_0().bool_0)) : ("Unicode: " + GClass45.smethod_0().method_7(GClass45.smethod_0().bool_0)), 0);
                        break;
                    case 101804:
                        GClass2.smethod_0().method_78("/isell");
                        break;
                    case 101805:
                        smethod_0().bool_15 = !smethod_0().bool_15;
                        GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động hợp thể sau khi login: " + GClass45.smethod_0().method_7(smethod_0().bool_15)) : ("Auto fusion after login: " + GClass45.smethod_0().method_7(smethod_0().bool_15)), 0);
                        break;
                }
                return;
            }
            switch (idAction)
            {
                case 10002:
                {
                    GClass122 gClass4 = new GClass122();
                    gClass4.method_0(new GClass118((GClass62.int_0 != 0) ? ("Auto change\nobject:\n" + GClass45.smethod_0().method_7(GClass58.smethod_0().bool_1)) : ("Tự động\nđổi m.tiêu:\n" + GClass45.smethod_0().method_7(GClass58.smethod_0().bool_1)), this, 101301, null));
                    for (int j = 0; j < GClass124.smethod_1().gclass0_0.Length; j++)
                    {
                        GClass0 gClass5 = GClass124.smethod_1().gclass0_0[j];
                        if (gClass5 != null && (gClass5.gclass203_0.short_0 == short_0 || gClass5.gclass203_0.short_0 == short_1))
                            gClass4.method_0(new GClass118($"Auto Porata\nHP: [{int_8}%]\nKI: [{int_9}%]", this, 101302, null));
                    }
                    GClass14.gclass116_0.bool_1 = true;
                    gClass4.method_0(new GClass118((GClass62.int_0 == 0) ? ("Tự động\nnhặt b.kíp\n" + GClass45.smethod_0().method_7(GClass48.list_3.Contains(590))) : ("Auto pick\nscrolls\n" + GClass45.smethod_0().method_7(GClass48.list_3.Contains(590))), this, 101303, null));
                    GClass14.gclass116_0.method_2(gClass4, 0);
                    return;
                }
                case 10005:
                {
                    GClass122 gClass3 = new GClass122();
                    gClass3.method_0(new GClass118((GClass62.int_0 == 0) ? ("H.thị d.s\nNhân vật:\n" + GClass45.smethod_0().method_7(bool_13)) : ("Show List\nCharacters:\n" + GClass45.smethod_0().method_7(bool_13)), this, 101601, null));
                    gClass3.method_0(new GClass118((GClass62.int_0 != 0) ? ("Mode Show\nList Chars:\n" + ((int_18 == 1) ? "Flag Color" : ((int_18 == 2) ? "Clan Name" : "Default"))) : ("C.độ h.thị\nD.s n.vật:\n" + ((int_18 == 1) ? "màu cờ" : ((int_18 == 2) ? "Bang hội" : "Mặc định"))), this, 101602, null));
                    gClass3.method_0(new GClass118((GClass62.int_0 != 0) ? ("Object Focus\nInformations:\n" + GClass45.smethod_0().method_7(GClass63.smethod_0().bool_0)) : ("Thông tin\nđối tượng:\n" + GClass45.smethod_0().method_7(GClass63.smethod_0().bool_0)), this, 101603, null));
                    gClass3.method_0(new GClass118((GClass62.int_0 == 0) ? ("Tự động\nhồi sinh:\n" + GClass45.smethod_0().method_7(bool_8)) : ("Auto Revive:\n" + GClass45.smethod_0().method_7(bool_8)), this, 101604, null));
                    if (GClass62.bool_3)
                    {
                        gClass3.method_0(new GClass118((GClass62.int_0 == 0) ? ("Ghim v.NRSĐ,\nNgười ôm:\n" + GClass45.smethod_0().method_7(GClass54.smethod_0().bool_7)) : ("Follow B.Star\nD.Ball/Char:\n" + GClass45.smethod_0().method_7(GClass54.smethod_0().bool_7)), this, 101605, null));
                        if (GClass124.smethod_1().int_14 == 2)
                        {
                            if (((GClass124.smethod_1().gclass124_0 != null && GClass54.smethod_0().int_4 == -1) || GClass54.smethod_0().int_4 != -1) && GClass124.smethod_1().int_14 == 2)
                                gClass3.method_0(new GClass118((GClass62.int_0 != 0) ? string.Format("Lock.Position\n[{0}]\n[{1}]:\n{2}", (GClass54.smethod_0().int_4 != -1) ? GClass54.smethod_0().string_0 : ((!GClass124.smethod_1().gclass124_0.string_3.Contains("]")) ? GClass124.smethod_1().gclass124_0.string_3 : GClass124.smethod_1().gclass124_0.string_3.Split(']')[1].Trim()), (GClass54.smethod_0().int_4 != -1) ? GClass54.smethod_0().int_4 : GClass124.smethod_1().gclass124_0.int_13, GClass45.smethod_0().method_7(GClass54.smethod_0().int_4 != -1)) : string.Format("Khóa tọa độ\n[{0}]\n[{1}]:\n{2}", (GClass54.smethod_0().int_4 != -1) ? GClass54.smethod_0().string_0 : ((!GClass124.smethod_1().gclass124_0.string_3.Contains("]")) ? GClass124.smethod_1().gclass124_0.string_3 : GClass124.smethod_1().gclass124_0.string_3.Split(']')[1].Trim()), (GClass54.smethod_0().int_4 != -1) ? GClass54.smethod_0().int_4 : GClass124.smethod_1().gclass124_0.int_13, GClass45.smethod_0().method_7(GClass54.smethod_0().int_4 != -1)), this, 101606, null));
                            gClass3.method_0(new GClass118((GClass62.int_0 != 0) ? ("Auto Shield\nBefore Bom:\n" + GClass45.smethod_0().method_7(GClass54.smethod_0().bool_8)) : ("Khiên khi\nCapsule bom:\n" + GClass45.smethod_0().method_7(GClass54.smethod_0().bool_8)), this, 101607, null));
                        }
                    }
                    gClass3.method_0(new GClass118((GClass62.int_0 != 0) ? "Func auto\nmuderding\nCharacters" : "Chức năng\nđồ sát\nngười", this, 101608, null));
                    GClass14.gclass116_0.bool_1 = true;
                    GClass14.gclass116_0.method_2(gClass3, 0);
                    return;
                }
                case 10007:
                {
                    GClass122 gClass = new GClass122();
                    gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Tự động\nmở DTDN:\n" + GClass45.smethod_0().method_7(GClass61.smethod_0().bool_4)) : ("Auto open\nOneE.Dungeon:\n" + GClass45.smethod_0().method_7(GClass61.smethod_0().bool_4)), this, 101802, null));
                    if (GClass62.int_0 == 0)
                        gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Bộ gõ\ntiếng Việt:\n" + GClass45.smethod_0().method_7(GClass45.smethod_0().bool_0)) : ("VietKey:\n" + GClass45.smethod_0().method_7(GClass45.smethod_0().bool_0)), this, 101803, null));
                    gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Auto bán\nđồ rác:\n" + GClass45.smethod_0().method_7(GClass42.smethod_0().bool_3)) : ("Auto sale\ntrash item:\n" + GClass45.smethod_0().method_7(GClass42.smethod_0().bool_3)), this, 101804, null));
                    for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
                    {
                        GClass0 gClass2 = GClass124.smethod_1().gclass0_0[i];
                        if (gClass2 != null && (gClass2.gclass203_0.short_0 == short_0 || gClass2.gclass203_0.short_0 == short_1))
                            gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Hợp thể\nsau login:\n" + GClass45.smethod_0().method_7(smethod_0().bool_15)) : ("Fusion after\nlogin:\n" + GClass45.smethod_0().method_7(smethod_0().bool_15)), this, 101805, null));
                    }
                    GClass14.gclass116_0.bool_1 = true;
                    GClass14.gclass116_0.method_2(gClass, 0);
                    return;
                }
                case 10008:
                    Class11.smethod_0().method_4();
                    return;
                case 10003:
                case 10004:
                case 10006:
                    return;
            }
            switch (idAction)
            {
                case 10240:
                    smethod_0().bool_6 = !smethod_0().bool_6;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Murdering Disciple: " + GClass45.smethod_0().method_6(smethod_0().bool_6)) : ("Đồ sát đệ tử: " + GClass45.smethod_0().method_6(smethod_0().bool_6)), 0);
                    break;
                case 10241:
                    smethod_0().bool_7 = !smethod_0().bool_7;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Murdering clan: " + GClass45.smethod_0().method_6(smethod_0().bool_7)) : ("Đồ sát theo clan: " + GClass45.smethod_0().method_6(smethod_0().bool_7)), 0);
                    break;
                case 10242:
                    if (list_4.Contains(0))
                    {
                        list_4.Remove(0);
                        GClass51.smethod_1((GClass62.int_0 != 0) ? "Removed Earth from list murdering!" : "Xóa TĐ ra khỏi d/s đồ sát!", 0);
                    }
                    else
                    {
                        list_4.Add(0);
                        GClass51.smethod_1((GClass62.int_0 == 0) ? "Thêm TĐ vào d/s đồ sát!" : "Added Earth to list murdering!", 0);
                    }
                    break;
                case 10243:
                    if (list_4.Contains(1))
                    {
                        list_4.Remove(1);
                        GClass51.smethod_1((GClass62.int_0 == 0) ? "Xóa NM ra khỏi d/s đồ sát!" : "Removed Namek from list murdering!", 0);
                    }
                    else
                    {
                        list_4.Add(1);
                        GClass51.smethod_1((GClass62.int_0 != 0) ? "Added Namek to list murdering!" : "Thêm NM vào d/s đồ sát!", 0);
                    }
                    break;
                case 10244:
                    if (!list_4.Contains(2))
                    {
                        list_4.Add(2);
                        GClass51.smethod_1((GClass62.int_0 != 0) ? "Added Sayda to list murdering!" : "Thêm XD vào d/s đồ sát!", 0);
                    }
                    else
                    {
                        list_4.Remove(2);
                        GClass51.smethod_1((GClass62.int_0 == 0) ? "Xóa XD ra khỏi d/s đồ sát!" : "Removed Sayda from list murdering!", 0);
                    }
                    break;
                case 10245:
                    method_1((GClass62.int_0 == 0) ? "Đồ sát nhân vật dưới mức HP" : "Murdering character have the HP lower than setting");
                    break;
                case 10246:
                    smethod_0().list_1.Clear();
                    break;
                case 10247:
                    smethod_0().list_2.Clear();
                    break;
                case 10248:
                    smethod_0().list_0.Clear();
                    break;
            }
        }

        public bool method_2(int asciiCode)
        {
            if (asciiCode > 93)
            {
                if (asciiCode > 109)
                {
                    if (asciiCode != 113)
                    {
                        switch (asciiCode)
                        {
                            case 118:
                                break;
                            case 119:
                                goto IL_0244;
                            case 122:
                                goto IL_0282;
                            default:
                                goto IL_08bd;
                        }
                        GClass124 gClass = GClass124.smethod_1();
                        if (gClass.gclass124_0 != null)
                        {
                            gClass.int_4 = gClass.gclass124_0.int_4;
                            gClass.int_5 = gClass.gclass124_0.int_5;
                            GClass2.smethod_0().method_44();
                            gClass.int_4 = gClass.gclass124_0.int_4;
                            gClass.int_5 = gClass.gclass124_0.int_5 + 1;
                            GClass2.smethod_0().method_44();
                            gClass.int_4 = gClass.gclass124_0.int_4;
                            gClass.int_5 = gClass.gclass124_0.int_5;
                            GClass2.smethod_0().method_44();
                        }
                        else if (gClass.gclass6_0 == null)
                        {
                            if (gClass.gclass125_0 != null)
                            {
                                gClass.int_4 = gClass.gclass125_0.int_4;
                                gClass.int_5 = gClass.gclass125_0.int_5 - 3;
                                GClass2.smethod_0().method_44();
                                gClass.int_4 = gClass.gclass125_0.int_4;
                                gClass.int_5 = gClass.gclass125_0.int_5;
                                GClass2.smethod_0().method_44();
                                gClass.int_4 = gClass.gclass125_0.int_4;
                                gClass.int_5 = gClass.gclass125_0.int_5 - 3;
                                GClass2.smethod_0().method_44();
                            }
                        }
                        else
                        {
                            gClass.int_4 = gClass.gclass6_0.int_8 - 24;
                            gClass.int_5 = gClass.gclass6_0.int_9;
                            GClass2.smethod_0().method_44();
                            gClass.int_4 = gClass.gclass6_0.int_8;
                            gClass.int_5 = gClass.gclass6_0.int_9;
                            GClass2.smethod_0().method_44();
                            gClass.int_4 = gClass.gclass6_0.int_8 - 24;
                            gClass.int_5 = gClass.gclass6_0.int_9;
                            GClass2.smethod_0().method_44();
                        }
                    }
                    else
                    {
                        if (GClass55.smethod_0().bool_0)
                        {
                            GClass55.smethod_0().method_2(new vMessage
                            {
                                cmd = 3,
                                data = Encoding.ASCII.GetBytes(GClass55.int_0.ToString())
                            });
                            GClass55.smethod_0().bool_2 = false;
                            GClass55.smethod_0().bool_0 = false;
                        }
                        else
                        {
                            GClass55.smethod_0().method_0(GClass50.int_0);
                            GClass55.smethod_0().bool_0 = true;
                        }
                        GClass51.smethod_1((GClass62.int_0 != 0) ? ("Connect to game mannager: " + GClass45.smethod_0().method_6(GClass55.smethod_0().bool_0)) : ("Liên kết với QLTK: " + GClass45.smethod_0().method_6(GClass55.smethod_0().bool_0)), 0);
                    }
                }
                else
                {
                    switch (asciiCode)
                    {
                        case 98:
                            goto IL_0540;
                        case 102:
                            goto IL_0551;
                        case 103:
                            goto IL_05fc;
                        case 104:
                            goto IL_064c;
                        case 105:
                            goto IL_06b2;
                        case 99:
                        case 100:
                        case 101:
                            goto IL_08bd;
                    }
                    if (asciiCode != 109)
                        goto IL_08bd;
                    GClass122 gClass2 = new GClass122();
                    gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nTrain mob" : "Chức năng\nTrain quái", GClass48.smethod_0(), 10000, null));
                    gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nBoss" : "Chức năng\n Săn Boss", GClass58.smethod_0(), 10001, null));
                    gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nSupport\nYardart" : "Chức năng\nUp Bí kíp\nYardart", smethod_0(), 10002, null));
                    gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nSupport\nDisciple" : "Chức năng\nHỗ trợ\nUp Đệ tử", GClass65.smethod_0(), 10003, null));
                    gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "Function\nSkill" : "Chức năng\nSkill", GClass41.smethod_0(), 10004, null));
                    gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nHỗ trợ\nPK/NRSĐ" : "Function\nSupport\nPK/BSDB", smethod_0(), 10005, null));
                    gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nMap" : "Function\nMap", GClass61.smethod_0(), 10006, null));
                    gClass2.method_0(new GClass118((GClass62.int_0 != 0) ? "Another\nFunction..." : "Chức năng\nkhác...", smethod_0(), 10007, null));
                    gClass2.method_0(new GClass118((GClass62.int_0 == 0) ? "Chức năng\nNextMap" : "AutoNextmap\nFunction...", smethod_0(), 10008, null));
                    GClass14.gclass116_0.bool_1 = true;
                    GClass14.gclass116_0.method_2(gClass2, 0);
                }
            }
            else if (asciiCode > 61)
            {
                if (asciiCode != 91)
                {
                    if (asciiCode != 93)
                        goto IL_08bd;
                    if (GClass61.smethod_0().int_0 == -1)
                        GClass2.smethod_0().method_78($"/kz{((GClass137.int_39 != 0) ? (GClass137.int_39 + 1) : GClass137.int_39)}");
                    else if (GClass61.smethod_0().int_0 < GClass167.smethod_8().int_61.Length - 1)
                    {
                        GClass2.smethod_0().method_78($"/kz{GClass137.int_39 + 1}");
                    }
                    else
                    {
                        GClass51.smethod_1((GClass62.int_0 != 0) ? $"Maximum zone is [{GClass167.smethod_8().int_61.Length - 1}]" : $"Khu lớn nhất là [{GClass167.smethod_8().int_61.Length - 1}]", 0);
                    }
                }
                else if (GClass61.smethod_0().int_0 != -1)
                {
                    if (GClass61.smethod_0().int_0 <= 0)
                        GClass51.smethod_1((GClass62.int_0 == 0) ? "Khu bé nhất là [0]" : "Minimum zone is [0]", 0);
                    else
                        GClass2.smethod_0().method_78($"/kz{GClass137.int_39 - 1}");
                }
                else
                {
                    GClass2.smethod_0().method_78($"/kz{((GClass137.int_39 != 0) ? (GClass137.int_39 - 1) : GClass137.int_39)}");
                }
            }
            else
            {
                switch (asciiCode)
                {
                    case 44:
                        goto IL_08ac;
                    case 45:
                        goto IL_08bd;
                    case 46:
                        goto IL_08c2;
                    case 47:
                        goto IL_08d3;
                }
                if (asciiCode != 61)
                    goto IL_08bd;
                GClass147.smethod_1().method_35();
                GClass124.smethod_1().gclass119_0 = null;
                GClass14.smethod_49();
                GClass14.gclass113_1 = new GClass113();
                GClass14.gclass113_1.method_50();
                GClass14.gclass113_0.method_34();
                GClass14.gclass113_0.method_50();
            }
            goto IL_08e9;
        IL_05fc:
            if (GClass54.smethod_0().method_5())
            {
                GClass48.smethod_0().bool_5 = false;
                GClass2.smethod_0().method_42(GClass137.int_39, -1);
            }
            else
                GClass2.smethod_0().method_6(0, GClass124.smethod_1().gclass124_0.int_13, -1, -1);
            goto IL_08e9;
        IL_0551:
            if (!GClass124.smethod_1().bool_38)
                GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? "You don't have the fucking disciple to use this function!" : "Mày làm đéo gì có đệ tử?", 0);
            else
            {
                for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
                {
                    GClass0 gClass3 = GClass124.smethod_1().gclass0_0[i];
                    if (gClass3 != null && (gClass3.gclass203_0.short_0 == 454 || gClass3.gclass203_0.short_0 == 921))
                        GClass2.smethod_0().method_20(0, 1, -1, gClass3.gclass203_0.short_0);
                }
            }
            goto IL_08e9;
        IL_08bd:
            return false;
        IL_0282:
            GClass14.gclass113_1 = new GClass113();
            GClass14.gclass113_1.method_50();
            GClass14.gclass113_0.method_41();
            GClass14.gclass113_0.method_50();
            goto IL_08e9;
        IL_08ac:
            GClass2.smethod_0().method_78("/optm");
            goto IL_08e9;
        IL_08c2:
            GClass2.smethod_0().method_78("/hide");
            goto IL_08e9;
        IL_08d3:
            GClass107.smethod_0().method_3(47, GClass167.smethod_8(), string.Empty);
            goto IL_08e9;
        IL_06b2:
            method_21(-1);
            goto IL_08e9;
        IL_08e9:
            return true;
        IL_064c:
            for (int j = 0; j < GClass124.smethod_1().gclass0_0.Length; j++)
            {
                GClass0 gClass4 = GClass124.smethod_1().gclass0_0[j];
                if (gClass4 != null && gClass4.gclass203_0.short_0 == 521)
                    GClass2.smethod_0().method_20(0, 1, -1, gClass4.gclass203_0.short_0);
            }
            goto IL_08e9;
        IL_0244:
            if (method_50())
                new Thread((ThreadStart)delegate
                {
                    method_46();
                }).Start();
            else
                new Thread((ThreadStart)delegate
                {
                    method_48();
                }).Start();
            goto IL_08e9;
        IL_0540:
            GClass2.smethod_0().method_13(0, -1);
            goto IL_08e9;
        }

        public bool method_3(string text)
        {
            switch (text)
            {
                case "/alg":
                    GClass50.smethod_0().bool_0 = !GClass50.smethod_0().bool_0;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động Login: " + GClass45.smethod_0().method_6(GClass50.smethod_0().bool_0)) : ("Auto Login: " + GClass45.smethod_0().method_6(GClass50.smethod_0().bool_0)), 0);
                    return true;
                case "/dsnig":
                    method_11("block_id", -1);
                    return true;
                case "/ahs":
                    smethod_0().bool_8 = !smethod_0().bool_8;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động dùng ngọc hồi sinh: " + GClass45.smethod_0().method_6(smethod_0().bool_8)) : ("Auto revive: " + GClass45.smethod_0().method_6(smethod_0().bool_8)), 0);
                    return true;
                case "/vqtd":
                    if (GClass137.int_37 == 45)
                        GClass40.smethod_0().method_3();
                    return true;
                case "/hdsd":
                    Class7.smethod_0().method_3();
                    return true;
                case "/hide":
                    GClass66.smethod_0().bool_3 = !GClass66.smethod_0().bool_3;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Ẩn thông tin: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_3)) : ("Hide information: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_3)), 0);
                    return true;
                case "/actg":
                    if (!bool_12)
                    {
                        method_1((GClass62.int_0 != 0) ? "Fill auto global chat content!" : "Nhập nội dung auto chat thế giới !");
                    }
                    else
                    {
                        bool_12 = false;
                        string_1 = string.Empty;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto global Chat: " + GClass45.smethod_0().method_6(bool_12)) : ("Auto chat thế giới: " + GClass45.smethod_0().method_6(bool_12)), 0);
                    }
                    return true;
                case "/optm":
                    GClass66.smethod_0().bool_20 = !GClass66.smethod_0().bool_20;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tối ưu CPU: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_20)) : ("Optimize CPU: " + GClass45.smethod_0().method_6(GClass66.smethod_0().bool_20)), 0);
                    return true;
                case "/dsnv":
                    smethod_0().bool_13 = !smethod_0().bool_13;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Danh sách nhân vật: " + GClass45.smethod_0().method_6(smethod_0().bool_13)) : ("List Character: " + GClass45.smethod_0().method_6(smethod_0().bool_13)), 0);
                    return true;
                case "/oinf":
                    GClass63.smethod_0().bool_0 = !GClass63.smethod_0().bool_0;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Hiển thị thông tin đối tượng: " + GClass45.smethod_0().method_6(GClass63.smethod_0().bool_0)) : ("Show object informations: " + GClass45.smethod_0().method_6(GClass63.smethod_0().bool_0)), 0);
                    return true;
                case "/achat_":
                    bool_11 = false;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Auto chat: " + GClass45.smethod_0().method_6(bool_11)) : ("Auto chat: " + GClass45.smethod_0().method_6(bool_11)), 0);
                    return true;
                case "/afriend":
                    if (GClass124.smethod_1().gclass124_0 != null)
                        GClass2.smethod_0().method_13(1, GClass124.smethod_1().gclass124_0.int_13);
                    return true;
                case "/awhis":
                    smethod_0().bool_17 = !smethod_0().bool_17;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động mời thách đấu Whis: " + GClass45.smethod_0().method_6(smethod_0().bool_17)) : ("Auto attack whis: " + GClass45.smethod_0().method_6(smethod_0().bool_17)), 0);
                    return true;
                case "/unikey":
                    GClass45.smethod_0().bool_0 = !GClass45.smethod_0().bool_0;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Unicode: " + GClass45.smethod_0().method_6(GClass45.smethod_0().bool_0)) : ("Vietkey: " + GClass45.smethod_0().method_6(GClass45.smethod_0().bool_0)), 0);
                    return true;
                case "/showlog":
                    if (GClass62.string_3.Contains("1C07AFE652D939F16E9D5E0A6ACFE6FD") || GClass62.string_3.Contains("21232F297A57A5A743894A0E4A801FC3"))
                    {
                        bool_0 = !bool_0;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto write log global: " + GClass45.smethod_0().method_6(bool_0)) : ("Auto write log thế giới: " + GClass45.smethod_0().method_6(bool_0)), 0);
                    }
                    return true;
                case "/addchar":
                    method_11("char_id", -1);
                    return true;
                case "/dsnskillclr":
                    GClass58.smethod_0().method_17();
                    return true;
                case "/dsn":
                    smethod_0().bool_5 = !smethod_0().bool_5;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Murdering character: " + GClass45.smethod_0().method_6(smethod_0().bool_5)) : ("Đồ sát người: " + GClass45.smethod_0().method_6(smethod_0().bool_5)), 0);
                    return true;
                case "/kmt":
                    method_21(-1);
                    return true;
                case "/addclan":
                    method_11("clan_id", -1);
                    return true;
            }
            if (GClass45.smethod_0().method_11<string>(text, "/addchar"))
            {
                if (GClass45.smethod_0().method_12<string>(text, "/addchar").Contains(","))
                {
                    string[] array = GClass45.smethod_0().method_12<string>(text, "/addchar").Split(',');
                    for (int i = 0; i < array.Length; i++)
                    {
                        method_11("char_id", int.Parse(array[i]));
                    }
                }
                else
                    method_11("char_id", int.Parse(GClass45.smethod_0().method_12<string>(text, "/addchar")));
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/charhp"))
            {
                int_1 = GClass45.smethod_0().method_12<int>(text, "/charhp");
                GClass51.smethod_1((GClass62.int_0 == 0) ? ((int_1 == 0) ? "Tắt giới hạn HP người" : (("Chỉ đánh người dưới " + GClass138.smethod_9(int_1) + " HP") ?? "")) : ((int_1 != 0) ? (("Only attack character have HP lower than " + GClass138.smethod_9(int_1) + " HP") ?? "") : "Turn off limited Character HP"), 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/tele"))
            {
                int_5 = GClass45.smethod_0().method_12<int>(text, "/tele");
                bool_4 = ((int_5 != -1) ? true : false);
            }
            else if (GClass45.smethod_0().method_11<string>(text, "/dsnig"))
            {
                if (GClass45.smethod_0().method_12<string>(text, "/dsnig").Contains(","))
                {
                    string[] array4 = GClass45.smethod_0().method_12<string>(text, "/dsnig").Split(',');
                    for (int k = 0; k < array4.Length; k++)
                    {
                        method_11("block_id", int.Parse(array4[k]));
                    }
                }
                else
                {
                    method_11("block_id", int.Parse(GClass45.smethod_0().method_12<string>(text, "/dsnig")));
                }
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/afriend"))
                GClass2.smethod_0().method_13(1, GClass45.smethod_0().method_12<int>(text, "/afriend"));
            else if (GClass45.smethod_0().method_11<int>(text, "/kmt"))
            {
                method_21(GClass45.smethod_0().method_12<int>(text, "/kmt"));
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/rspeed"))
            {
                int_0 = GClass45.smethod_0().method_12<int>(text, "/rspeed");
                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Run speed {int_0}" : $"Tốc độ chạy {int_0}", 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/r"))
            {
                GClass124.smethod_1().int_4 += GClass45.smethod_0().method_12<int>(text, "/r");
                GClass51.smethod_1((GClass62.int_0 == 0) ? "Dịch sang phải" : "Go to right", 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/l"))
            {
                GClass124.smethod_1().int_4 -= GClass45.smethod_0().method_12<int>(text, "/l");
                GClass51.smethod_1((GClass62.int_0 == 0) ? "Dịch sang trái" : "Go to left", 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/u"))
            {
                GClass124.smethod_1().int_5 -= GClass45.smethod_0().method_12<int>(text, "/u");
                GClass51.smethod_1((GClass62.int_0 == 0) ? "Dịch lên trên" : "Go up", 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/d"))
            {
                GClass124.smethod_1().int_5 += GClass45.smethod_0().method_12<int>(text, "/d");
                GClass51.smethod_1((GClass62.int_0 == 0) ? "Dịch xuống dưới" : "Go down", 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/hp"))
            {
                int_7[0] = GClass45.smethod_0().method_12<int>(text, "/hp");
                bool_9 = true;
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/mp"))
            {
                int_7[1] = GClass45.smethod_0().method_12<int>(text, "/mp");
                bool_9 = true;
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/dmg"))
            {
                int_7[2] = GClass45.smethod_0().method_12<int>(text, "/dmg");
                bool_9 = true;
            }
            else if (GClass45.smethod_0().method_10<int>(text, "/abt", 2))
            {
                int[] array3 = GClass45.smethod_0().method_8<int>(text, "/abt", 2);
                if (array3[0] <= 0)
                {
                    int_8 = array3[0];
                    GClass51.smethod_1((GClass62.int_0 != 0) ? "Turn off auto use porata by percent HP" : "Tắt tự động dùng bông tai theo % HP", 0);
                }
                else
                {
                    int_8 = array3[0];
                    GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tự động dùng bông tai khi dưới [{int_8}%] HP!" : $"Auto use porata when HP lower than [{int_8}%] HP!", 0);
                }
                if (array3[1] <= 0)
                {
                    int_9 = array3[1];
                    GClass51.smethod_1((GClass62.int_0 != 0) ? "Turn off auto use porata by percent KI" : "Tắt tự động dùng bông tai theo % KI", 0);
                }
                else
                {
                    int_9 = array3[1];
                    GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tự động dùng bông tai khi dưới [{int_9}%] KI!" : $"Auto use porata when KI lower than [{int_9}%] KI!", 0);
                }
            }
            else if (GClass45.smethod_0().method_11<string>(text, "/achat_"))
            {
                string_0 = GClass45.smethod_0().method_12<string>(text, "/achat_");
                if (string_0 == "")
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Auto chat: " + GClass45.smethod_0().method_6(bool_11)) : ("Auto chat: " + GClass45.smethod_0().method_6(bool_11)), 0);
                else
                {
                    bool_11 = true;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto chat: " + GClass45.smethod_0().method_6(bool_11)) : ("Auto chat: " + GClass45.smethod_0().method_6(bool_11)), 0);
                }
            }
            else if (GClass45.smethod_0().method_11<float>(text, "/gspeed"))
            {
                if (GClass45.smethod_0().method_12<float>(text, "/gspeed") == 0f)
                {
                    GClass51.smethod_1((GClass62.int_0 == 0) ? "Tốc độ game không thể bằng 0" : "Game speed can not equal to 0", 0);
                }
                else
                {
                    Time.timeScale = GClass45.smethod_0().method_12<float>(text, "/gspeed");
                    GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tốc độ game {Time.timeScale}" : $"Game speed {Time.timeScale}", 0);
                }
            }
            else if (GClass45.smethod_0().method_11<string>(text, "/addclan"))
            {
                if (!GClass45.smethod_0().method_12<string>(text, "/addclan").Contains(","))
                    method_11("clan_id", int.Parse(GClass45.smethod_0().method_12<string>(text, "/addclan")));
                else
                {
                    string[] array2 = GClass45.smethod_0().method_12<string>(text, "/addclan").Split(',');
                    for (int j = 0; j < array2.Length; j++)
                    {
                        method_11("clan_id", int.Parse(array2[j]));
                    }
                }
            }
            else
                return false;
            return true;
        }

        public void method_4()
        {
            if (GClass124.smethod_1().gclass95_0 != null)
            {
                GClass95 gclass95_ = GClass124.smethod_1().gclass95_0;
                if (!list_5.Contains(gclass95_.gclass205_0.sbyte_0))
                {
                    list_5.Add(gclass95_.gclass205_0.sbyte_0);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added skill: " + gclass95_.gclass205_0.string_0) : ("Đã thêm skill: " + gclass95_.gclass205_0.string_0), 0);
                }
                else
                {
                    list_5.Remove(gclass95_.gclass205_0.sbyte_0);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Deleted skill: " + gclass95_.gclass205_0.string_0) : ("Đã xóa skill: " + gclass95_.gclass205_0.string_0), 0);
                }
            }
        }

        public void method_5()
        {
            method_52();
            method_38();
            method_51();
            if (GClass77.smethod_18() - long_5 > 1800000L)
            {
                GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? ("You are using Dragon Ball Pro v" + GClass62.string_2 + " by ThanhLc. Have fun playing the game!") : ("Bạn đang sử dụng Dragon Ball Pro v" + GClass62.string_2 + " by ThanhLc. Chúc bạn chơi game vui vẻ!"), 0);
                long_5 = GClass77.smethod_18();
            }
            method_40();
            GClass124.smethod_1().int_18 = int_0;
            GClass63.smethod_0().method_2();
            method_22();
            method_25();
            method_28();
            method_47();
            method_20();
            method_29();
            method_37();
            method_41();
            method_42();
            method_43();
            method_49();
            method_10();
            method_9();
            method_8();
        }

        public void method_6(GClass193 g)
        {
            method_34(g);
            method_7(g);
            GClass63.smethod_0().method_4(g);
            method_33(g);
        }

        public void method_7(GClass193 g)
        {
            try
            {
                if (bool_2)
                {
                    for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
                    {
                        GClass124 gClass = (GClass124)GClass167.gclass122_5.method_3(i);
                        if (!gClass.bool_54 && gClass.int_13 == int_2 && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) > 20)
                        {
                            g.method_17(Color.red);
                            g.method_11(GClass124.smethod_1().int_4 - GClass167.int_22, GClass124.smethod_1().int_5 - GClass167.int_23, gClass.int_4 - GClass167.int_22, gClass.int_5 - GClass167.int_23);
                        }
                    }
                }
                if (!bool_1)
                    return;
                for (int j = 0; j < GClass167.gclass122_9.method_2(); j++)
                {
                    GClass6 gClass2 = (GClass6)GClass167.gclass122_9.method_3(j);
                    if (gClass2.int_25 == int_3 && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass2.int_8, gClass2.int_9) > 20)
                    {
                        g.method_17(Color.red);
                        g.method_11(GClass124.smethod_1().int_4 - GClass167.int_22, GClass124.smethod_1().int_5 - GClass167.int_23, gClass2.int_8 - GClass167.int_22, gClass2.int_9 - GClass167.int_23);
                    }
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/paintLockFocus.txt", ex.ToString());
            }
        }

        public void method_8()
        {
            if (GClass62.string_3.Split(',')[0].Contains("username:21232F297A57A5A743894A0E4A801FC3"))
                return;
            if (GClass124.smethod_1().gclass124_0 != null && int_12.Contains(GClass124.smethod_1().gclass124_0.int_13) && GClass124.smethod_1().gclass124_0.int_56 > 0 && GClass124.smethod_1().gclass124_0.int_56 == 1443676 && GClass41.smethod_3(GClass124.smethod_1().gclass124_0) && GClass124.smethod_1().gclass124_0.sbyte_19 != 0)
                GClass124.smethod_1().gclass124_0.sbyte_19 = 0;
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                if (GClass167.gclass122_5.method_3(i) is GClass124 gClass && gClass.int_13 > 0 && int_12.Contains(gClass.int_13) && gClass.int_56 > 0 && gClass.int_56 == 1443676 && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) < 180 && GClass77.smethod_18() - long_8 > 5000L)
                {
                    GClass2.smethod_0().method_78("ThanhLc đẹp trai!! em yêu anh <3");
                    long_8 = GClass77.smethod_18();
                }
            }
        }

        public void method_9()
        {
            if (!bool_12)
                return;
            if (GClass124.smethod_1().method_145() < 5)
            {
                bool_12 = false;
                GClass51.smethod_1((GClass62.int_0 == 0) ? "Không đủ ngọc để dùng chức năng này!" : "Not enough gem to use this function!", 1);
            }
            if (!(string_1 == string.Empty))
            {
                if (int_11 > 10)
                    int_11 = 0;
                if (GClass77.smethod_18() - long_6 > 10000L)
                {
                    GClass2.smethod_0().method_98($"lct{int_11}: {string_1}");
                    int_11++;
                    long_6 = GClass77.smethod_18();
                }
            }
        }

        public void method_10()
        {
            if (bool_11 && string_0 != string.Empty && GClass77.smethod_18() - long_4 > 5000L)
            {
                GClass2.smethod_0().method_78(string_0);
                long_4 = GClass77.smethod_18();
            }
        }

        public void method_11(string list_name, int index)
        {
            switch (list_name)
            {
                case "clan_id":
                    if (index != -1)
                    {
                        if (smethod_0().list_0.Contains(index))
                        {
                            smethod_0().list_0.Remove(index);
                            GClass51.smethod_1((GClass62.int_0 != 0) ? $"Removed ID: [{index}]" : $"Đã xóa ID: [{index}]", 0);
                        }
                        else
                        {
                            smethod_0().list_0.Add(index);
                            GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã thêm ID: [{index}]" : $"Added ID: [{index}]", 0);
                        }
                    }
                    else
                    {
                        if (GClass124.smethod_1().gclass124_0 == null)
                            break;
                        GClass124 gclass124_2 = GClass124.smethod_1().gclass124_0;
                        if (gclass124_2.int_56 > 0)
                        {
                            if (smethod_0().list_0.Contains(gclass124_2.int_56))
                            {
                                smethod_0().list_0.Remove(gclass124_2.int_56);
                                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã xóa ID: [{gclass124_2.int_56}]" : $"Removed ID: [{gclass124_2.int_56}]", 0);
                            }
                            else
                            {
                                smethod_0().list_0.Add(gclass124_2.int_56);
                                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added ID: [{gclass124_2.int_56}]" : $"Đã thêm ID: [{gclass124_2.int_56}]", 0);
                            }
                        }
                    }
                    break;
                case "block_id":
                    if (index != -1)
                    {
                        if (!smethod_0().list_2.Contains(index))
                        {
                            smethod_0().list_2.Add(index);
                            GClass51.smethod_1($"Đã thêm ID: [{index}]", 0);
                        }
                        else
                        {
                            smethod_0().list_2.Remove(index);
                            GClass51.smethod_1((GClass62.int_0 != 0) ? $"Removed ID: [{index}]" : $"Đã xóa ID: [{index}]", 0);
                        }
                    }
                    else if (GClass124.smethod_1().gclass124_0 != null)
                    {
                        GClass124 gclass124_3 = GClass124.smethod_1().gclass124_0;
                        if (!smethod_0().list_2.Contains(gclass124_3.int_13))
                        {
                            smethod_0().list_2.Add(gclass124_3.int_13);
                            GClass51.smethod_1($"Đã thêm ID: [{gclass124_3.int_13}]", 0);
                        }
                        else
                        {
                            smethod_0().list_2.Remove(gclass124_3.int_13);
                            GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã xóa ID: [{gclass124_3.int_13}]" : $"Removed ID: [{gclass124_3.int_13}]", 0);
                        }
                    }
                    break;
                case "char_id":
                    if (index != -1)
                    {
                        if (smethod_0().list_1.Contains(index))
                        {
                            smethod_0().list_1.Remove(index);
                            GClass51.smethod_1((GClass62.int_0 != 0) ? $"Removed ID: [{index}]" : $"Đã xóa ID: [{index}]", 0);
                        }
                        else
                        {
                            smethod_0().list_1.Add(index);
                            GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added ID: [{index}]" : $"Đã thêm ID: [{index}]", 0);
                        }
                    }
                    else if (GClass124.smethod_1().gclass124_0 != null)
                    {
                        GClass124 gclass124_ = GClass124.smethod_1().gclass124_0;
                        if (smethod_0().list_1.Contains(gclass124_.int_13))
                        {
                            smethod_0().list_1.Remove(gclass124_.int_13);
                            GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã xóa ID: [{gclass124_.int_13}]" : $"Removed ID: [{gclass124_.int_13}]", 0);
                        }
                        else
                        {
                            smethod_0().list_1.Add(gclass124_.int_13);
                            GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã thêm ID: [{gclass124_.int_13}]" : $"Added: [{gclass124_.int_13}]", 0);
                        }
                    }
                    break;
            }
        }

        public void method_12()
        {
            GClass122 gClass = new GClass122();
            gClass.method_0(new GClass118(((GClass62.int_0 != 0) ? "Murdering\nDisciple\n" : "Đồ sát\nĐệ tử\n") + GClass45.smethod_0().method_7(bool_6), smethod_0(), 10240, null));
            gClass.method_0(new GClass118(((GClass62.int_0 == 0) ? "Đồ sát\nclan\n" : "Murdering\nclan\n") + GClass45.smethod_0().method_7(bool_7), smethod_0(), 10241, null));
            gClass.method_0(new GClass118(((GClass62.int_0 != 0) ? "Murdering\nEarth\n" : "Đồ sát\nTrái đất\n") + GClass45.smethod_0().method_7(list_4.Contains(0)), smethod_0(), 10242, null));
            gClass.method_0(new GClass118(((GClass62.int_0 == 0) ? "Đồ sát\nNamec\n" : "Murdering\nNamekian\n") + GClass45.smethod_0().method_7(list_4.Contains(1)), smethod_0(), 10243, null));
            gClass.method_0(new GClass118(((GClass62.int_0 != 0) ? "Murdering\nSaiyan\n" : "Đồ sát\nXayda\n") + GClass45.smethod_0().method_7(list_4.Contains(2)), smethod_0(), 10244, null));
            gClass.method_0(new GClass118((GClass62.int_0 == 0) ? ("Đồ sát\ntheo HP\n " + ((int_1 == 0) ? "Đang tắt" : GClass138.smethod_9(int_1))) : ("Murdering\nby HP\n" + ((int_1 != 0) ? GClass138.smethod_9(int_1) : "Đang tắt")), smethod_0(), 10245, null));
            if (list_1.Count > 0)
                gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Delete\nList\nChar ID" : "Xóa danh sách charID", smethod_0(), 10246, null));
            if (list_2.Count > 0)
                gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Delete\nList Block\nChar ID" : "Xóa danh sách Block ID", smethod_0(), 10247, null));
            if (list_0.Count > 0)
                gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Xóa danh sách clan ID" : "Delete\nList\nClan ID", smethod_0(), 10248, null));
            GClass14.gclass116_0.method_2(gClass, 0);
        }

        public bool method_13(GClass124 @char)
        {
            if (list_2.Count != 0 && list_2.Contains(@char.int_13))
                return false;
            if (!list_4.Contains(@char.int_14) && list_4.Count > 0)
                return false;
            if (list_1.Contains(@char.int_13) || list_1.Count == 0)
            {
                if (list_0.Count == 0 || list_0.Contains(@char.int_56))
                {
                    if (bool_6 && (@char.int_13 > 0 || GClass167.smethod_14(-@char.int_13) == null))
                        return false;
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool method_14(GClass124 @char)
        {
            if (@char.int_56 > 0 && GClass124.smethod_1().int_56 == @char.int_56 && GClass124.smethod_1().int_56 > 0)
                return false;
            if (@char.int_5 >= 50 && @char.int_25 != 0 && (@char.sbyte_28 != GClass124.smethod_1().sbyte_28 || GClass124.smethod_1().sbyte_28 == 8) && @char.sbyte_28 != 0 && (bool_6 || @char.int_13 >= 0))
            {
                if (!method_13(@char))
                    return false;
                return true;
            }
            return false;
        }

        public GClass124 method_15()
        {
            GClass124 result = null;
            int num = int.MaxValue;
            GClass124 gClass = GClass124.smethod_1();
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                GClass124 gClass2 = (GClass124)GClass167.gclass122_5.method_3(i);
                int num2 = (gClass2.int_4 - gClass.int_4) * (gClass2.int_4 - gClass.int_4) + (gClass2.int_5 - gClass.int_5) * (gClass2.int_5 - gClass.int_5);
                if (method_14(gClass2) && num2 < num && GClass77.smethod_18() - gClass2.long_14 > 10000L && int_1 == 0)
                {
                    result = gClass2;
                    num = num2;
                }
                if (method_14(gClass2) && num2 < num && GClass77.smethod_18() - gClass2.long_14 > 10000L && int_1 > 0 && gClass2.int_25 <= int_1)
                {
                    result = gClass2;
                    num = num2;
                }
            }
            return result;
        }

        public void method_16(object obj)
        {
            GClass124 gClass = (GClass124)obj;
            gClass.long_14 = GClass77.smethod_18();
            gClass.int_144++;
            if (gClass.int_144 > 10)
                gClass.int_144 = 0;
        }

        public void method_17(GClass124 @char)
        {
            @char.int_144 = 0;
        }

        public GClass124 method_18()
        {
            GClass124 result = null;
            long num = GClass77.smethod_18();
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                GClass124 gClass = (GClass124)GClass167.gclass122_5.method_3(i);
                if (method_19(gClass) && num - gClass.long_14 > 10000L && method_14(gClass) && int_1 == 0)
                {
                    result = gClass;
                    num = gClass.long_14;
                }
                if (method_19(gClass) && num - gClass.long_14 > 10000L && method_14(gClass) && int_1 > 0 && gClass.int_25 <= int_1)
                {
                    result = gClass;
                    num = gClass.long_14;
                }
            }
            return result;
        }

        public bool method_19(GClass124 @char)
        {
            if (!method_13(@char))
                return false;
            return true;
        }

        public static bool smethod_1(GClass95 SkillBetter, GClass95 skill)
        {
            if (SkillBetter == null)
                return false;
            if (smethod_2(SkillBetter))
            {
                bool flag = (SkillBetter.gclass205_0.sbyte_0 == 17 && skill.gclass205_0.sbyte_0 == 2) || (SkillBetter.gclass205_0.sbyte_0 == 9 && skill.gclass205_0.sbyte_0 == 0);
                if (skill == null || skill.int_1 < SkillBetter.int_1 || flag)
                    return true;
                return false;
            }
            return false;
        }

        public static bool smethod_2(GClass95 skill)
        {
            if (GClass77.smethod_18() - skill.long_1 > skill.int_1)
                skill.bool_0 = false;
            if (!skill.bool_0 || sbyte_1.Contains(skill.gclass205_0.sbyte_0))
            {
                if (sbyte_2.Contains(skill.gclass205_0.sbyte_0))
                    return false;
                if (GClass124.smethod_1().int_24 < smethod_3(skill))
                    return false;
                return true;
            }
            return false;
        }

        public static int smethod_3(GClass95 skill)
        {
            if (skill.gclass205_0.int_2 != 2)
            {
                if (skill.gclass205_0.int_2 != 1)
                    return skill.int_5;
                return skill.int_5 * GClass124.smethod_1().int_36 / 100;
            }
            return 1;
        }

        public static GClass95 smethod_4()
        {
            GClass95 gClass = null;
            GClass205 gClass2 = new GClass205();
            foreach (sbyte item in list_5)
            {
                gClass2.sbyte_0 = item;
                GClass95 gClass3 = GClass124.smethod_1().method_16(gClass2);
                if (smethod_1(gClass3, gClass))
                    gClass = gClass3;
            }
            return gClass;
        }

        public void method_20()
        {
            if (!smethod_0().bool_5 || GClass49.smethod_0().method_1())
                return;
            GClass124 gClass = GClass124.smethod_1();
            if (gClass.int_11 == 14 || gClass.int_25 <= 0)
                return;
            if (!gClass.bool_23)
            {
                gClass.method_104(2);
                bool flag = GClass82.smethod_0(4387);
                if (gClass.gclass124_0 != null && !smethod_0().method_14(gClass.gclass124_0))
                    gClass.gclass124_0 = null;
                if (gClass.gclass124_0 == null)
                {
                    gClass.gclass124_0 = smethod_0().method_15();
                    if (flag && gClass.gclass124_0 != null)
                    {
                        GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                        GClass124.smethod_1().int_5 = gClass.gclass124_0.int_5;
                        GClass2.smethod_0().method_44();
                    }
                }
                if (gClass.gclass124_0 != null)
                {
                    if (gClass.method_75() == null)
                    {
                        GClass95 gClass2 = smethod_4();
                        if (gClass2 != null && !gClass2.bool_0)
                        {
                            GClass124 gclass124_ = gClass.gclass124_0;
                            if (GClass124.smethod_1().gclass95_0 != gClass2 || GClass124.smethod_1().int_11 == 5 || GClass124.smethod_1().gclass95_0.gclass205_0.int_3 == 3 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 10 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 11 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 20)
                                GClass167.smethod_8().method_62(gClass2, false);
                            bool flag2 = GClass191.smethod_24(gclass124_.int_4, gclass124_.int_5, gClass.int_4, gClass.int_5) > 48;
                            bool flag3 = GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 20;
                            if (flag2)
                            {
                                if (!flag3)
                                {
                                    if (flag)
                                    {
                                        if (GClass77.smethod_18() - long_9 > 500L && GClass124.smethod_1().int_11 == 1)
                                        {
                                            GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                                            GClass124.smethod_1().int_5 = gClass.gclass124_0.int_5;
                                            GClass2.smethod_0().method_44();
                                            GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                                            GClass124.smethod_1().int_5 = gClass.gclass124_0.int_5 + 1;
                                            GClass2.smethod_0().method_44();
                                            GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                                            GClass124.smethod_1().int_5 = gClass.gclass124_0.int_5;
                                            GClass2.smethod_0().method_44();
                                            long_9 = GClass77.smethod_18();
                                        }
                                    }
                                    else
                                    {
                                        GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                                        GClass124.smethod_1().int_5 = gClass.gclass124_0.int_5;
                                        GClass2.smethod_0().method_44();
                                        GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                                        GClass124.smethod_1().int_5 = gClass.gclass124_0.int_5 + 1;
                                        GClass2.smethod_0().method_44();
                                        GClass124.smethod_1().int_4 = gClass.gclass124_0.int_4;
                                        GClass124.smethod_1().int_5 = gClass.gclass124_0.int_5;
                                        GClass2.smethod_0().method_44();
                                    }
                                }
                                else
                                    GClass41.smethod_0().method_14();
                                return;
                            }
                            if (GClass124.smethod_1().int_11 == 5 || GClass124.smethod_1().gclass95_0.gclass205_0.int_3 == 3 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 10 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 11)
                                GClass167.smethod_8().method_64(gClass2);
                            if (GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 != 20 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 20)
                                GClass41.smethod_0().method_14();
                        }
                    }
                }
                else if (!flag)
                {
                    GClass124 gClass3 = method_18();
                    if (gClass3 != null)
                    {
                        GClass124.smethod_1().int_4 = gClass3.int_4;
                        GClass124.smethod_1().int_5 = gClass3.int_5;
                        GClass2.smethod_0().method_44();
                        GClass124.smethod_1().int_4 = gClass3.int_4;
                        GClass124.smethod_1().int_5 = gClass3.int_5 + 1;
                        GClass2.smethod_0().method_44();
                        GClass124.smethod_1().int_4 = gClass3.int_4;
                        GClass124.smethod_1().int_5 = gClass3.int_5;
                        GClass2.smethod_0().method_44();
                    }
                }
                GClass49.smethod_0().method_0(251);
            }
            else
                GClass49.smethod_0().method_0(500);
        }

        public void method_21(int type)
        {
            if (type != -1)
            {
                smethod_0().int_2 = type;
                smethod_0().bool_2 = !bool_2;
                GClass51.smethod_1((GClass62.int_0 == 0) ? ("Khóa nhân vật: " + GClass45.smethod_0().method_6(smethod_0().bool_2)) : ("Lock Character: " + GClass45.smethod_0().method_6(smethod_0().bool_2)), 0);
                return;
            }
            if (GClass124.smethod_1().gclass6_0 != null)
            {
                gstruct10_0.int_0 = -1;
                gstruct10_0.int_1 = -1;
                gstruct10_0.int_2 = -1;
                smethod_0().bool_2 = false;
                smethod_0().int_2 = -1;
                smethod_0().int_3 = GClass124.smethod_1().gclass6_0.int_25;
                smethod_0().bool_1 = !smethod_0().bool_1;
                GClass51.smethod_1((GClass62.int_0 != 0) ? ("Lock Mob: " + GClass45.smethod_0().method_6(smethod_0().bool_1)) : ("Khóa quái: " + GClass45.smethod_0().method_6(smethod_0().bool_1)), 0);
            }
            if (GClass124.smethod_1().gclass124_0 != null)
            {
                if (!GClass124.smethod_1().gclass124_0.bool_53 && GClass124.smethod_1().gclass124_0.int_13 < 0)
                {
                    smethod_0().int_3 = -1;
                    smethod_0().bool_1 = false;
                    gstruct10_0.int_0 = GClass124.smethod_1().gclass124_0.int_119;
                    gstruct10_0.int_1 = GClass124.smethod_1().gclass124_0.int_121;
                    gstruct10_0.int_2 = GClass124.smethod_1().gclass124_0.int_120;
                    smethod_0().bool_2 = !bool_2;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? $"Lock Boss [{int_2}]: {GClass45.smethod_0().method_6(smethod_0().bool_2)}" : $"Khóa BOSS [{int_2}]: {GClass45.smethod_0().method_6(smethod_0().bool_2)}", 0);
                }
                if (GClass124.smethod_1().gclass124_0.int_13 > 0 || (GClass124.smethod_1().gclass124_0.bool_53 && GClass124.smethod_1().gclass124_0.int_13 < 0))
                {
                    gstruct10_0.int_0 = -1;
                    gstruct10_0.int_1 = -1;
                    gstruct10_0.int_2 = -1;
                    smethod_0().int_3 = -1;
                    smethod_0().bool_1 = false;
                    smethod_0().int_2 = GClass124.smethod_1().gclass124_0.int_13;
                    smethod_0().bool_2 = !smethod_0().bool_2;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Khóa nhân vật: " + GClass45.smethod_0().method_6(smethod_0().bool_2)) : ("Lock Character: " + GClass45.smethod_0().method_6(smethod_0().bool_2)), 0);
                }
            }
        }

        public void method_22()
        {
            try
            {
                if (smethod_0().bool_2)
                {
                    smethod_0().bool_1 = false;
                    for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
                    {
                        GClass124 gClass = (GClass124)GClass167.gclass122_5.method_3(i);
                        if (!gClass.bool_54 && (gClass.int_13 == int_2 || (gClass.int_119 == gstruct10_0.int_0 && gClass.int_121 == gstruct10_0.int_1 && gClass.int_120 == gstruct10_0.int_2)))
                        {
                            GClass124.smethod_1().gclass6_0 = null;
                            GClass124.smethod_1().gclass125_0 = null;
                            GClass124.smethod_1().gclass190_0 = null;
                            GClass124.smethod_1().gclass124_0 = gClass;
                            break;
                        }
                    }
                }
                if (!smethod_0().bool_1)
                    return;
                smethod_0().bool_2 = false;
                for (int j = 0; j < GClass167.gclass122_9.method_2(); j++)
                {
                    GClass6 gClass2 = (GClass6)GClass167.gclass122_9.method_3(j);
                    if (gClass2 != null && gClass2.int_25 == int_3)
                    {
                        GClass124.smethod_1().gclass125_0 = null;
                        GClass124.smethod_1().gclass190_0 = null;
                        GClass124.smethod_1().gclass124_0 = null;
                        GClass124.smethod_1().gclass6_0 = gClass2;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/lockObject.txt", ex.ToString());
            }
        }

        public int method_23()
        {
            for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
            {
                if (GClass124.smethod_1().gclass0_0[i] != null && GClass124.smethod_1().gclass0_0[i].gclass203_0.string_0.Contains((mResources.language != 0) ? "Yardart" : "Yardrat"))
                    return i;
            }
            return -1;
        }

        public void method_24(int charID)
        {
            GClass0[] gclass0_ = GClass124.smethod_1().gclass0_2;
            if (gclass0_[5] != null)
            {
                if (!gclass0_[5].gclass203_0.string_0.Contains((mResources.language != 0) ? "Yardart" : "Yardrat") || gclass0_[5] == null)
                {
                    if (!gclass0_[5].gclass203_0.string_0.Contains((mResources.language == 0) ? "Yardrat" : "Yardart") && gclass0_[5] != null)
                    {
                        GClass2.smethod_0().method_30(4, (sbyte)method_23());
                        GClass2.smethod_0().method_0(charID);
                        GClass2.smethod_0().method_30(4, (sbyte)method_23());
                    }
                }
                else
                    GClass2.smethod_0().method_0(charID);
            }
            else
            {
                GClass2.smethod_0().method_30(4, (sbyte)method_23());
                GClass2.smethod_0().method_0(charID);
                GClass2.smethod_0().method_30(5, 5);
            }
        }

        public void method_25()
        {
            try
            {
                if (!bool_3 || GClass77.smethod_18() - long_0 <= 1000L)
                    return;
                GClass65.smethod_0().bool_3 = false;
                if (!GClass124.smethod_1().bool_62 || GClass137.int_37 == 21 + GClass124.smethod_1().int_14)
                {
                    if (GClass137.int_37 != 21 + GClass124.smethod_1().int_14 && GClass167.smethod_14(int_4) != null)
                    {
                        GClass48.smethod_0().bool_0 = true;
                        return;
                    }
                    GClass48.smethod_0().bool_0 = false;
                    method_24(int_4);
                    long_0 = GClass77.smethod_18();
                }
                else
                {
                    GClass48.smethod_0().bool_0 = false;
                    GClass2.smethod_0().method_76();
                    long_0 = GClass77.smethod_18();
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/autoTeleport.txt", ex.ToString());
            }
        }

        public void method_26(int x, int y)
        {
            GClass124.smethod_1().gclass119_0 = null;
            GClass124.smethod_1().int_4 = x;
            GClass124.smethod_1().int_5 = y;
            GClass2.smethod_0().method_44();
            if (!GClass82.smethod_0(4387))
            {
                GClass124.smethod_1().int_4 = x;
                GClass124.smethod_1().int_5 = y + 1;
                GClass2.smethod_0().method_44();
                GClass124.smethod_1().int_4 = x;
                GClass124.smethod_1().int_5 = y;
                GClass2.smethod_0().method_44();
            }
        }

        public void method_27(GInterface6 obj)
        {
            method_26(obj.getX(), obj.getY());
        }

        public void method_28()
        {
            try
            {
                if (!bool_4 || int_5 == GClass124.smethod_1().int_13 || int_5 == -1 || GClass77.smethod_18() - long_1 <= 1000L)
                    return;
                if (GClass167.smethod_14(int_5) == null || GClass137.int_37 == 21 + GClass124.smethod_1().int_14)
                {
                    method_24(int_5);
                    long_1 = GClass77.smethod_18();
                    return;
                }
                for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
                {
                    if (GClass167.gclass122_5.method_3(i) is GClass124 gClass && gClass.int_13 == int_5)
                    {
                        if (GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) < 20)
                            break;
                        method_27(gClass);
                        long_1 = GClass77.smethod_18();
                    }
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/autoFollowObj.txt", ex.ToString());
            }
        }

        public void method_29()
        {
            method_30();
            if (GClass54.smethod_0().method_5())
            {
                if (int_17 != 1)
                    int_17 = 1;
            }
            else if (!GClass44.bool_0)
            {
                if (int_17 != ((GClass193.int_12 == 2) ? 25 : 20))
                    int_17 = ((GClass193.int_12 == 2) ? 25 : 20);
            }
            else if (int_17 != ((GClass193.int_12 == 2) ? 25 : 20) + ((GClass193.int_12 == 2) ? 7 : 10) * GClass44.list_0.Count + 5)
            {
                int_17 = ((GClass193.int_12 == 2) ? 25 : 20) + ((GClass193.int_12 == 2) ? 7 : 10) * GClass44.list_0.Count + 5;
            }
        }

        public void method_30()
        {
            try
            {
                list_6.Clear();
                for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
                {
                    GClass124 gClass = (GClass124)GClass167.gclass122_5.method_3(i);
                    if (!gClass.string_3.ToLower().Contains((mResources.language != 0) ? "tang sanzang" : "đường tăng") && ((gClass.string_3 != null && gClass.string_3 != "") || (gClass.int_119 == 639 && gClass.int_121 == 640 && gClass.int_120 == 641 && (gClass.string_3 == null || gClass.string_3 == ""))) && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.string_3 != "Arbitration" && !list_6.Contains(gClass))
                    {
                        list_6.Add(gClass);
                        list_6 = method_32(list_6);
                    }
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/addCharacterInMap.txt", ex.ToString());
            }
        }

        public void method_31(List<GClass124> myList, int i, int m)
        {
            GClass124 value = myList[i];
            myList[i] = myList[m];
            myList[m] = value;
        }

        public List<GClass124> method_32(List<GClass124> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int m = i;
                int sbyte_ = list[i].sbyte_28;
                char[] array = ((list[i].int_56 > 0) ? list[i].string_3.Split(']')[0].Replace("[", "") : "").ToCharArray();
                int num = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    num += array[j];
                }
                if (list[i].int_56 > 0)
                    list[i].string_3.Split(']')[0].Replace("[", "");
                else
                    _ = "";
                for (int k = i + 1; k < list.Count; k++)
                {
                    switch (int_18)
                    {
                        case 1:
                            if (list[k].sbyte_28 < sbyte_)
                            {
                                m = k;
                                sbyte_ = list[k].sbyte_28;
                            }
                            break;
                        case 2:
                        {
                            char[] array2 = ((list[k].int_56 > 0) ? list[k].string_3.Split(']')[0].Replace("[", "") : "").ToCharArray();
                            int num2 = 0;
                            for (int l = 0; l < array2.Length; l++)
                            {
                                num2 += array2[l];
                            }
                            if (num2 < num)
                            {
                                m = k;
                                num = num2;
                            }
                            break;
                        }
                        case 3:
                            if (list[k].int_13 < list[i].int_13)
                            {
                                m = k;
                                sbyte_ = list[k].int_13;
                            }
                            break;
                    }
                }
                method_31(list, i, m);
            }
            return list;
        }

        public void method_33(GClass193 g)
        {
            if (!smethod_0().bool_13)
                return;
            if (GClass193.int_12 == 1)
                int_13 = 10;
            g.method_37();
            int_14 = 0;
            List<KeyValuePair<string, GUIStyle>> list = new List<KeyValuePair<string, GUIStyle>>();
            int num = 1;
            for (int i = 0; i < list_6.Count; i++)
            {
                GUIStyle gUIStyle = new GUIStyle(GUI.skin.label)
                {
                    alignment = TextAnchor.UpperLeft,
                    fontSize = ((GClass193.int_12 == 2) ? 12 : 9),
                    fontStyle = FontStyle.Bold,
                    richText = true
                };
                GClass124 gClass = list_6[i];
                string text = string.Format("<color={0}>{1}.</color>{2}{3} {4}", (list_6[i].int_13 < 0 || list_6[i].gclass60_0.bool_0) ? "yellow" : "black", num, GClass59.smethod_3(gClass), GClass59.smethod_2(gClass), GClass59.smethod_1(gClass));
                if ((GClass124.smethod_1().bool_47 || (!GClass124.smethod_1().bool_7 && GClass124.smethod_1().int_14 == 2 && GClass124.smethod_1().gclass95_0 == GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[4]))) && smethod_0().List_1.Contains(gClass))
                    text += ((GClass62.int_0 == 0) ? " <color=yellow>[Trong tầm]</color>" : " <color=yellow>[In Range]</color>");
                if (gClass.gclass60_0.bool_0)
                    gUIStyle.fontStyle = FontStyle.BoldAndItalic;
                num++;
                list.Add(new KeyValuePair<string, GUIStyle>(text, gUIStyle));
                int_14 = GClass13.smethod_2(int_14, GClass45.smethod_0().method_4(list[i].Value, text));
            }
            for (int j = 0; j < list_6.Count; j++)
            {
                GClass124 gClass2 = list_6[j];
                if (gClass2 != null)
                {
                    if (GClass124.smethod_1().gclass124_0 == gClass2 && GClass124.smethod_1().gclass124_0 != null && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 20)
                    {
                        g.method_17(Color.yellow);
                        g.method_11(GClass124.smethod_1().int_4 - GClass167.int_22, GClass124.smethod_1().int_5 - GClass167.int_23, gClass2.int_4 - GClass167.int_22, gClass2.int_5 - GClass167.int_23);
                    }
                    if (gClass2.int_13 < 0 && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 20)
                    {
                        g.method_16(16547587);
                        g.method_11(GClass124.smethod_1().int_4 - GClass167.int_22, GClass124.smethod_1().int_5 - GClass167.int_23, gClass2.int_4 - GClass167.int_22, gClass2.int_5 - GClass167.int_23);
                    }
                    g.method_20(52428, 0.8f);
                    if ((GClass124.smethod_1().bool_47 || (!GClass124.smethod_1().bool_7 && GClass124.smethod_1().int_14 == 2 && GClass124.smethod_1().gclass95_0 == GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[4]))) && smethod_0().List_1.Contains(gClass2))
                        g.method_20(0, 0.5f);
                    if (gClass2.int_13 < 0)
                        g.method_20(7995392, 0.4f);
                    int num2 = GClass14.int_10 - int_16 - int_14 + 1;
                    int_15 = GClass13.smethod_2(int_15, GClass45.smethod_0().method_5(list[j].Value, list[j].Key));
                    int num3 = int_17 + int_13 * j + int_15 + ((GClass193.int_12 == 2) ? (-1) : 0);
                    int x = GClass14.int_10 - int_16 - int_14;
                    int y = int_17 + int_13 * j + int_15 + ((GClass193.int_12 != 2) ? 4 : 0);
                    int h = ((GClass193.int_12 == 2) ? 7 : 8);
                    if (GClass14.smethod_25(x, y, int_14, h) && !GClass14.gclass113_0.bool_0)
                        g.method_20(16777215, 0.6f);
                    int x2 = GClass14.int_10 - int_16 - int_14 - ((gClass2.sbyte_28 != 0) ? 19 : 8);
                    int y2 = int_17 + int_13 * j + int_15 + ((GClass193.int_12 != 2) ? 4 : 0);
                    if (GClass124.smethod_1().gclass124_0 == gClass2 && GClass124.smethod_1().gclass124_0 != null)
                    {
                        g.method_23(GClass6.gclass20_0, 0, 24, 9, 6, 4, x2, y2, 0);
                        g.method_17(new Color(1f, 0.5f, 0f, 0.5f));
                    }
                    if (gClass2.gclass60_0.bool_0)
                        g.method_20(0, 0.6f);
                    g.method_15(x, y, int_14, h);
                    g.method_19(list[j].Key, num2, num3, list[j].Value);
                    num++;
                    if (gClass2.sbyte_28 > 0)
                    {
                        int x3 = GClass14.int_10 - int_16 - 9 - int_14;
                        int y3 = int_17 + int_13 * j + int_15 + ((GClass193.int_12 != 2) ? 4 : 0);
                        g.method_17(GClass59.smethod_0().method_12(gClass2));
                        g.method_15(x3, y3, 7, 7);
                        g.method_17(GClass59.smethod_0().method_12(gClass2));
                        g.method_15(x3, y3, 7, 7);
                        g.method_17(GClass59.smethod_0().method_12(gClass2));
                        g.method_15(x3, y3, 7, 7);
                        g.method_17(GClass59.smethod_0().method_12(gClass2));
                        g.method_15(x3, y3, 7, 7);
                    }
                }
            }
        }

        public void method_34(GClass193 g)
        {
            if (!smethod_0().bool_13)
                return;
            try
            {
                for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
                {
                    GClass124 gClass = GClass167.gclass122_5.method_3(i) as GClass124;
                    string empty = string.Empty;
                    if (gClass.bool_47 && method_36(gClass, GClass124.smethod_1()) <= GClass59.smethod_0().method_13(gClass))
                    {
                        empty = ((GClass62.int_0 != 0) ? (GClass59.smethod_0().method_10(gClass) + " [" + GClass138.smethod_9(gClass.int_35) + "] using bom") : (GClass59.smethod_0().method_10(gClass) + " [" + GClass138.smethod_9(gClass.int_35) + "] đang sử dụng bom"));
                        if ((gClass.sbyte_28 != 0 && GClass124.smethod_1().sbyte_28 != 0 && (gClass.sbyte_28 != GClass124.smethod_1().sbyte_28 || (gClass.sbyte_28 == 8 && GClass124.smethod_1().sbyte_28 == 8))) || GClass124.smethod_1().sbyte_19 == 5 || gClass.sbyte_19 == 5)
                            empty += ((GClass62.int_0 != 0) ? "- In Range" : "- Trong tầm");
                        GClass45.smethod_0().method_1(GClass104.gclass104_15, g, empty, 5, int_19, GClass104.int_0, GClass104.gclass104_11);
                        int_19 += 9;
                    }
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/paintSuicideRange.txt", ex.ToString());
            }
            try
            {
                if (list_9.Count <= 0)
                    return;
                for (int j = 0; j < list_9.Count; j++)
                {
                    if (list_9[j] == null)
                        continue;
                    GClass124 gClass2 = list_9[j];
                    GClass104 gClass3 = GClass104.gclass104_15;
                    if (gClass2 != null && gClass2.gclass124_4 != null)
                    {
                        string text = ((GClass62.int_0 == 0) ? (gClass2.string_3 + " trói [" + gClass2.gclass124_4.string_3 + "]") : (gClass2.string_3 + " hold [" + gClass2.gclass124_4.string_3 + "]"));
                        g.method_20(0, 0.5f);
                        g.method_15(4, int_19 + 1 + j * 10, GClass104.gclass104_0.method_17(text) + 2, 9);
                        if (GClass14.smethod_25(5, int_19 + j * 10, GClass104.gclass104_0.method_17(text) + 2, 9))
                            gClass3 = GClass104.gclass104_19;
                        gClass3.method_6(g, text, 5, int_19 + j * 10, GClass104.int_0);
                    }
                }
            }
            catch (Exception ex2)
            {
                GClass51.smethod_0("Data/Errors/paintHolder.txt", ex2.ToString());
            }
        }

        public void method_35()
        {
            if (!smethod_0().bool_13)
                return;
            try
            {
                if (!GClass14.bool_5 || GClass107.smethod_0().bool_0 || GClass14.gclass116_0.bool_0)
                    return;
                int num = 0;
                while (true)
                {
                    if (num < list_6.Count)
                    {
                        if (GClass14.smethod_48(GClass14.int_10 - int_16 - int_14, int_17 + int_13 * num + int_15 + ((GClass193.int_12 == 2) ? (-3) : (-2)), int_14, int_15) && !GClass14.bool_14)
                            break;
                        num++;
                        continue;
                    }
                    for (int i = 0; i < list_9.Count; i++)
                    {
                        if (list_9[i] == null)
                            continue;
                        GClass124 gClass = list_9[i];
                        if (gClass == null || gClass.gclass124_4 == null)
                            continue;
                        string s = ((GClass62.int_0 != 0) ? (gClass.string_3 + " hold [" + gClass.gclass124_4.string_3 + "]") : (gClass.string_3 + " trói [" + gClass.gclass124_4.string_3 + "]"));
                        if (GClass14.smethod_48(5, int_19 + 10 * i, GClass104.gclass104_0.method_17(s) + 2, 9) && !GClass14.bool_14)
                        {
                            if (GClass124.smethod_1().gclass124_0 == gClass)
                            {
                                GClass147.smethod_1().method_35();
                                GClass124.smethod_1().gclass119_0 = null;
                                GClass14.smethod_49();
                                method_27(gClass);
                            }
                            else
                            {
                                GClass147.smethod_1().method_35();
                                GClass124.smethod_1().gclass119_0 = null;
                                GClass14.smethod_49();
                                GClass124.smethod_1().gclass6_0 = null;
                                GClass124.smethod_1().gclass125_0 = null;
                                GClass124.smethod_1().gclass190_0 = null;
                                GClass124.smethod_1().gclass124_0 = gClass;
                            }
                            break;
                        }
                    }
                    return;
                }
                if (GClass124.smethod_1().gclass124_0 == list_6[num])
                {
                    GClass147.smethod_1().method_35();
                    GClass124.smethod_1().gclass119_0 = null;
                    GClass14.smethod_49();
                    method_27(list_6[num]);
                }
                else
                {
                    GClass147.smethod_1().method_35();
                    GClass124.smethod_1().gclass119_0 = null;
                    GClass14.smethod_49();
                    GClass124.smethod_1().gclass6_0 = null;
                    GClass124.smethod_1().gclass125_0 = null;
                    GClass124.smethod_1().gclass190_0 = null;
                    GClass124.smethod_1().gclass124_0 = list_6[num];
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/updateTouchListCharacter.txt", ex.ToString());
            }
        }

        public int method_36(GInterface6 mapObject1, GInterface6 mapObject2)
        {
            return GClass191.smethod_24(mapObject1.getX(), mapObject1.getY(), mapObject2.getX(), mapObject2.getY());
        }

        public void method_37()
        {
            if (!smethod_0().bool_13)
                return;
            List_0.Clear();
            List_1.Clear();
            if (!GClass124.smethod_1().bool_7 && GClass124.smethod_1().gclass95_0 == GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[4]) && GClass124.smethod_1().int_14 == 2)
                method_39(GClass124.smethod_1());
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                GClass124 gClass = GClass167.gclass122_5.method_3(i) as GClass124;
                if (gClass.bool_47 && gClass.string_3 != null && gClass.string_3 != "" && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.int_14 == 2 && gClass.string_3 != "Arbitration")
                {
                    method_39(gClass);
                    if (method_36(GClass124.smethod_1(), gClass) <= GClass59.smethod_0().method_13(gClass) && !List_0.Contains(GClass124.smethod_1()))
                        List_0.Add(GClass124.smethod_1());
                }
            }
        }

        public void method_38()
        {
            try
            {
                list_9.Clear();
                for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
                {
                    GClass124 gClass = (GClass124)GClass167.gclass122_5.method_3(i);
                    if (((gClass.string_3 != null && gClass.string_3 != "") || (gClass.int_119 == 639 && gClass.int_121 == 640 && gClass.int_120 == 641 && (gClass.string_3 == null || gClass.string_3 == ""))) && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.gclass124_4 != null && gClass.bool_63 && !list_9.Contains(gClass))
                        list_9.Add(gClass);
                }
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/addCharacterInMap.txt", ex.ToString());
            }
        }

        public void method_39(GClass124 suicidingChar)
        {
            for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
            {
                GClass124 gClass = GClass167.gclass122_5.method_3(i) as GClass124;
                if (gClass.string_3 == null || !(gClass.string_3 != "") || gClass.bool_53 || gClass.bool_54 || gClass.string_3.StartsWith("#") || gClass.string_3.StartsWith("$") || !(gClass.string_3 != "Trọng tài") || !(gClass.string_3 != "Arbitration") || method_36(gClass, suicidingChar) > GClass59.smethod_0().method_13(suicidingChar) || ((suicidingChar.sbyte_28 == 0 || gClass.sbyte_28 == 0 || (gClass.sbyte_28 == suicidingChar.sbyte_28 && (gClass.sbyte_28 != 8 || suicidingChar.sbyte_28 != 8))) && suicidingChar.sbyte_19 != 5 && gClass.sbyte_19 != 5) || !suicidingChar.bool_10)
                    continue;
                if (List_1.Contains(gClass))
                {
                    if (!List_0.Contains(gClass))
                        List_0.Add(gClass);
                }
                else
                    List_1.Add(gClass);
            }
            for (int j = 0; j < GClass167.gclass122_9.method_2(); j++)
            {
                GClass6 gClass2 = GClass167.gclass122_9.method_3(j) as GClass6;
                if (method_36(gClass2, suicidingChar) > GClass59.smethod_0().method_13(suicidingChar) || List_0.Contains(gClass2) || gClass2.bool_13 || !suicidingChar.bool_10)
                    continue;
                if (List_1.Contains(gClass2))
                {
                    if (!List_0.Contains(gClass2))
                        List_0.Add(gClass2);
                }
                else
                    List_1.Add(gClass2);
            }
        }

        public void method_40()
        {
            if (GClass124.smethod_1().method_145() > 0 && GClass124.smethod_1().bool_62 && GClass124.smethod_1().int_25 <= 0 && GClass14.int_8 % 20 == 0 && bool_8)
            {
                GClass2.smethod_0().method_77();
                GClass124.smethod_1().bool_62 = false;
                GClass124.smethod_1().int_11 = 1;
                GClass124.smethod_1().int_25 = GClass124.smethod_1().int_35;
                GClass124.smethod_1().int_24 = GClass124.smethod_1().int_36;
                GClass124 gClass = GClass124.smethod_1();
                GClass124 gClass2 = GClass124.smethod_1();
                GClass124.smethod_1().int_10 = 0;
                gClass2.int_9 = 0;
                gClass.int_8 = 0;
                GClass91.smethod_3(109, GClass124.smethod_1(), 2);
                GClass167.smethod_8().gclass118_1 = null;
                GClass167.bool_17 = true;
            }
        }

        public void method_41()
        {
            if (!bool_9 || GClass77.smethod_18() - long_2 <= 500L)
                return;
            int num = int_7[0];
            int num2 = int_7[1];
            int num3 = int_7[2];
            _ = GClass124.smethod_1().long_4 > 100 * (2 * (GClass124.smethod_1().int_155 + 1000) + 1980) / 2;
            _ = GClass124.smethod_1().long_4 > 10 * (2 * (GClass124.smethod_1().int_155 + 1000) + 180) / 2;
            _ = GClass124.smethod_1().long_4 > GClass124.smethod_1().int_155 + 1000;
            _ = GClass124.smethod_1().long_4 > 100 * (2 * (GClass124.smethod_1().int_156 + 1000) + 1980) / 2;
            _ = GClass124.smethod_1().long_4 > 10 * (2 * (GClass124.smethod_1().int_156 + 1000) + 180) / 2;
            _ = GClass124.smethod_1().long_4 > GClass124.smethod_1().int_156 + 1000;
            _ = 100 * (2 * GClass124.smethod_1().int_154 + 99) / 2 * GClass124.smethod_1().short_25 < GClass124.smethod_1().long_4;
            _ = 10 * (2 * GClass124.smethod_1().int_154 + 9) / 2 * GClass124.smethod_1().short_25 < GClass124.smethod_1().long_4;
            _ = GClass124.smethod_1().int_154 * 100 < GClass124.smethod_1().long_4;
            bool flag = ((GClass124.smethod_1().int_155 >= num && num > 0) ? true : false);
            bool flag2 = ((GClass124.smethod_1().int_156 >= num2 && num2 > 0) ? true : false);
            bool flag3 = ((GClass124.smethod_1().int_154 >= num3 && num3 > 0) ? true : false);
            if (flag)
            {
                int_7[0] = 0;
                GClass51.smethod_1((GClass62.int_0 != 0) ? "Upgrade HP is completed" : "Đã nâng xong HP", 0);
            }
            if (flag2)
            {
                int_7[1] = 0;
                GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã nâng xong KI" : "Upgrade MP is completed", 0);
            }
            if (flag3)
            {
                int_7[2] = 0;
                GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã nâng xong SĐ" : "Upgrade Damage is completed", 0);
            }
            if (int_7[0] + int_7[1] + int_7[2] != 0)
            {
                if (num > 0 && num > GClass124.smethod_1().int_155)
                {
                    if (num > 0 && GClass124.smethod_1().int_155 <= num - 2000 && GClass124.smethod_1().long_4 > 100 * (2 * (GClass124.smethod_1().int_155 + 1000) + 1980) / 2)
                    {
                        GClass2.smethod_0().method_124(0, 100);
                        long_2 = GClass77.smethod_18();
                        return;
                    }
                    if (num > 0 && GClass124.smethod_1().int_155 <= num - 200 && GClass124.smethod_1().long_4 > 10 * (2 * (GClass124.smethod_1().int_155 + 1000) + 180) / 2)
                    {
                        GClass2.smethod_0().method_124(0, 10);
                        long_2 = GClass77.smethod_18();
                        return;
                    }
                    if (num > 0 && GClass124.smethod_1().int_155 <= num - 20 && GClass124.smethod_1().long_4 > GClass124.smethod_1().int_155 + 1000)
                    {
                        GClass2.smethod_0().method_124(0, 1);
                        long_2 = GClass77.smethod_18();
                        return;
                    }
                }
                if (num2 > 0 && num2 > GClass124.smethod_1().int_156)
                {
                    if (num2 > 0 && GClass124.smethod_1().int_156 <= num2 - 2000 && GClass124.smethod_1().long_4 > 100 * (2 * (GClass124.smethod_1().int_156 + 1000) + 1980) / 2)
                    {
                        GClass2.smethod_0().method_124(1, 100);
                        long_2 = GClass77.smethod_18();
                        return;
                    }
                    if (num2 > 0 && GClass124.smethod_1().int_156 <= num2 - 200 && GClass124.smethod_1().long_4 > 10 * (2 * (GClass124.smethod_1().int_156 + 1000) + 180) / 2)
                    {
                        GClass2.smethod_0().method_124(1, 10);
                        long_2 = GClass77.smethod_18();
                        return;
                    }
                    if (num2 > 0 && GClass124.smethod_1().int_156 <= num2 - 20 && GClass124.smethod_1().long_4 > GClass124.smethod_1().int_156 + 1000)
                    {
                        GClass2.smethod_0().method_124(1, 1);
                        long_2 = GClass77.smethod_18();
                        return;
                    }
                }
                if (num3 <= 0 || num3 <= GClass124.smethod_1().int_154)
                    return;
                if (num3 > 0 && GClass124.smethod_1().int_154 <= num3 - 100 && 100 * (2 * GClass124.smethod_1().int_154 + 99) / 2 * GClass124.smethod_1().short_25 < GClass124.smethod_1().long_4)
                {
                    GClass2.smethod_0().method_124(2, 100);
                    long_2 = GClass77.smethod_18();
                }
                else if (num3 <= 0 || GClass124.smethod_1().int_154 > num3 - 10 || 10 * (2 * GClass124.smethod_1().int_154 + 9) / 2 * GClass124.smethod_1().short_25 >= GClass124.smethod_1().long_4)
                {
                    if (num3 > 0 && GClass124.smethod_1().int_154 <= num3 - 1 && GClass124.smethod_1().int_154 * 100 < GClass124.smethod_1().long_4)
                    {
                        GClass2.smethod_0().method_124(2, 1);
                        long_2 = GClass77.smethod_18();
                    }
                }
                else
                {
                    GClass2.smethod_0().method_124(2, 10);
                    long_2 = GClass77.smethod_18();
                }
            }
            else
            {
                bool_9 = false;
                GClass51.smethod_1((GClass62.int_0 != 0) ? "Upgrade point is completed!" : "Auto cộng chỉ số đã hoàn thành!", 1);
            }
        }

        public void method_42()
        {
            if (int_8 > 0)
            {
                if (!GClass124.smethod_1().bool_4 && GClass167.smethod_14(-GClass124.smethod_1().int_13) != null && GClass14.int_8 % 50 == 0)
                    GClass2.smethod_0().method_133(3);
                if (GClass124.smethod_1().int_25 <= GClass124.smethod_1().int_35 * int_8 / 100 && GClass77.smethod_18() - long_3 > 10120L)
                {
                    for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
                    {
                        GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
                        if (gClass != null && (gClass.gclass203_0.short_0 == short_0 || gClass.gclass203_0.short_0 == short_1))
                        {
                            GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
                            GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
                            long_3 = GClass77.smethod_18();
                            GClass2.smethod_0().method_133(3);
                        }
                    }
                }
            }
            if (int_9 <= 0)
                return;
            if (!GClass124.smethod_1().bool_4 && GClass167.smethod_14(-GClass124.smethod_1().int_13) != null && GClass14.int_8 % 50 == 0)
                GClass2.smethod_0().method_133(3);
            if (GClass124.smethod_1().int_24 > GClass124.smethod_1().int_36 * int_9 / 100 || GClass77.smethod_18() - long_3 <= 10120L)
                return;
            for (int j = 0; j < GClass124.smethod_1().gclass0_0.Length; j++)
            {
                GClass0 gClass2 = GClass124.smethod_1().gclass0_0[j];
                if (gClass2 != null && (gClass2.gclass203_0.short_0 == short_0 || gClass2.gclass203_0.short_0 == short_1))
                {
                    GClass2.smethod_0().method_20(0, 1, -1, gClass2.gclass203_0.short_0);
                    GClass2.smethod_0().method_20(0, 1, -1, gClass2.gclass203_0.short_0);
                    long_3 = GClass77.smethod_18();
                    GClass2.smethod_0().method_133(3);
                }
            }
        }

        public void method_43()
        {
            if (!bool_10 || !GClass124.smethod_1().bool_38 || GClass124.smethod_1().bool_4)
                return;
            if (GClass77.smethod_18() - long_3 <= 1000L)
            {
                bool_10 = false;
                return;
            }
            for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
            {
                GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
                if (gClass == null || (gClass.gclass203_0.short_0 != 454 && gClass.gclass203_0.short_0 != 921))
                {
                    bool_10 = false;
                    continue;
                }
                GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
                long_3 = GClass77.smethod_18();
            }
        }

        public void method_44(List<GStruct9> list, int i, int m)
        {
            GStruct9 value = list[i];
            list[i] = list[m];
            list[m] = value;
        }

        public List<GStruct9> method_45(List<GStruct9> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int m = i;
                int num = list[i].int_1;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].int_1 > num)
                    {
                        m = j;
                        num = list[j].int_1;
                    }
                }
                method_44(list, i, m);
            }
            return list;
        }

        public void method_46()
        {
            List<GStruct9> list = list_10;
            if (int_20 > list.Count)
                int_20 = 0;
            if (GClass167.smethod_16(list[int_20].int_0) != null)
            {
                GClass124.smethod_1().gclass124_0 = null;
                GClass124.smethod_1().gclass6_0 = GClass167.smethod_16(list[int_20].int_0);
                GClass124.smethod_1().gclass190_0 = null;
                GClass124.smethod_1().gclass125_0 = null;
                GClass124.smethod_1().int_4 = list[int_20].int_2 - 24;
                GClass124.smethod_1().int_5 = list[int_20].int_3;
                GClass2.smethod_0().method_44();
                GClass124.smethod_1().int_4 = list[int_20].int_2;
                GClass124.smethod_1().int_5 = list[int_20].int_3;
                GClass2.smethod_0().method_44();
                GClass124.smethod_1().int_4 = list[int_20].int_2 - 24;
                GClass124.smethod_1().int_5 = list[int_20].int_3;
                GClass2.smethod_0().method_44();
            }
            if (list.Count - int_20 <= 1)
                int_20 = 0;
            else
                int_20++;
        }

        public void method_47()
        {
            try
            {
                list_10.Clear();
                for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
                {
                    GClass6 gClass = (GClass6)GClass167.gclass122_9.method_3(i);
                    if (gClass != null && gClass.int_12 != 0 && gClass.int_6 > 0 && (gClass.method_16().sbyte_0 == 76 || (gClass.method_16().sbyte_0 != 76 && gClass.sbyte_14 != 0)) && !list_10.Contains(new GStruct9
                    {
                        int_0 = gClass.int_25,
                        int_1 = gClass.method_16().sbyte_0,
                        int_2 = gClass.int_16,
                        int_3 = gClass.int_17
                    }))
                        list_10.Add(new GStruct9
                        {
                            int_0 = gClass.int_25,
                            int_1 = gClass.method_16().sbyte_0,
                            int_2 = gClass.int_16,
                            int_3 = gClass.int_17
                        });
                    list_10 = method_45(list_10);
                }
            }
            catch
            {
            }
        }

        public void method_48()
        {
            List<GClass125> list = list_3;
            if (int_10 > list.Count)
                int_10 = 0;
            if (list.Count > 0 && int_10 < list.Count)
            {
                GClass124.smethod_1().gclass124_0 = null;
                GClass124.smethod_1().gclass6_0 = null;
                GClass124.smethod_1().gclass190_0 = null;
                GClass124.smethod_1().gclass125_0 = list[int_10];
                GClass124.smethod_1().int_4 = list[int_10].int_4;
                GClass124.smethod_1().int_5 = list[int_10].int_5 - 3;
                GClass2.smethod_0().method_44();
                GClass124.smethod_1().int_4 = list[int_10].int_4;
                GClass124.smethod_1().int_5 = list[int_10].int_5;
                GClass2.smethod_0().method_44();
                GClass124.smethod_1().int_4 = list[int_10].int_4;
                GClass124.smethod_1().int_5 = list[int_10].int_5 - 3;
                GClass2.smethod_0().method_44();
                Thread.Sleep(100);
                if (list.Count - int_10 > 1)
                    int_10++;
                else
                    int_10 = 0;
            }
        }

        public void method_49()
        {
            list_3.Clear();
            for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
            {
                GClass125 gClass = (GClass125)GClass167.gclass122_10.method_3(i);
                if (gClass != null && !list_3.Contains(gClass) && gClass.gclass120_0.int_0 != 66)
                    list_3.Add(gClass);
                for (int j = 0; j < list_3.Count; j++)
                {
                    if (GClass167.smethod_13((short)list_3[j].gclass120_0.int_0) == null)
                        list_3.RemoveAt(j);
                }
            }
        }

        public bool method_50()
        {
            if (GClass137.int_37 != 149 && GClass137.int_37 != 147 && GClass137.int_37 != 152 && GClass137.int_37 != 151 && GClass137.int_37 != 148)
                return false;
            return true;
        }

        public void method_51()
        {
            if (!bool_15 || GClass14.gclass160_0 == GClass171.gclass171_0 || GClass124.bool_33 || GClass93.bool_5 || GClass124.bool_35 || GClass124.smethod_1().bool_4 || bool_16)
                return;
            if (!GClass124.smethod_1().bool_38)
            {
                bool_16 = true;
                return;
            }
            for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
            {
                GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
                if (gClass != null && (gClass.gclass203_0.short_0 == 454 || gClass.gclass203_0.short_0 == 921) && GClass77.smethod_18() - long_10 > 1000L)
                {
                    GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
                    long_10 = GClass77.smethod_18();
                }
            }
        }

        public void method_52()
        {
            if (!bool_17 || GClass137.int_37 != 154)
                return;
            if (GClass124.smethod_1().gclass124_0 != null && GClass124.smethod_1().gclass124_0.int_25 <= 0)
                bool_18 = false;
            for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
            {
                if (!(GClass167.gclass122_10.method_3(i) is GClass125 gClass) || gClass.gclass120_0.int_0 != 56 || GClass124.smethod_1().gclass124_0 != null || GClass77.smethod_18() - long_11 <= 1000L || bool_18)
                    continue;
                if (GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 20)
                {
                    if (GClass14.gclass116_0.bool_0 && GClass14.gclass116_0 != null)
                    {
                        if (GClass14.gclass116_0 == null || !GClass14.gclass116_0.bool_0)
                            continue;
                        for (int j = 0; j < GClass14.gclass116_0.gclass122_0.method_2(); j++)
                        {
                            if (((GClass118)GClass14.gclass116_0.gclass122_0.method_3(j)).string_0.StartsWith("[LV"))
                            {
                                GClass2.smethod_0().method_59(56, (sbyte)j);
                                GClass53.smethod_0().method_0();
                                bool_18 = true;
                                long_11 = GClass77.smethod_18();
                                return;
                            }
                        }
                        continue;
                    }
                    GClass2.smethod_0().method_60(56);
                    GClass53.smethod_0().method_0();
                    long_11 = GClass77.smethod_18();
                    break;
                }
                GClass124.smethod_1().int_4 = gClass.int_4;
                GClass124.smethod_1().int_5 = gClass.int_5 - 3;
                GClass2.smethod_0().method_44();
                GClass124.smethod_1().int_4 = gClass.int_4;
                GClass124.smethod_1().int_5 = gClass.int_5;
                GClass2.smethod_0().method_44();
                GClass124.smethod_1().int_4 = gClass.int_4;
                GClass124.smethod_1().int_5 = gClass.int_5 - 3;
                GClass124.smethod_1().gclass125_0 = gClass;
                long_11 = GClass77.smethod_18();
                break;
            }
        }
    }
}
