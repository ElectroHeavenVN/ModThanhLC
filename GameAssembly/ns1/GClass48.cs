using System;
using System.Collections.Generic;
using System.Linq;

namespace ns1
{
    public class GClass48 : GInterface1, GInterface3
    {
        public enum GEnum0
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

        private static GClass48 gclass48_0;

        private static readonly sbyte[] sbyte_1 = new sbyte[5] { 0, 9, 2, 17, 4 };

        private static readonly sbyte[] sbyte_2 = new sbyte[5] { 10, 11, 14, 23, 7 };

        public static bool bool_8;

        private static bool bool_9;

        private static long long_0;

        private static long long_1;

        public static List<GClass190> list_7 = new List<GClass190>();

        private static int int_5 = 0;

        public static long long_2;

        public long long_3;

        public long long_4;

        public static GClass48 smethod_0()
        {
            return (gclass48_0 != null) ? gclass48_0 : (gclass48_0 = new GClass48());
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
                if (GClass107.smethod_0().string_1.Equals((GClass62.int_0 != 0) ? "Fill mob HP limited" : "Nhập giới hạn HP quái"))
                {
                    method_3($"/mobhp{int.Parse(GClass107.smethod_0().gclass136_0.method_21())}");
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
            if (idAction > 101107)
            {
                if (idAction != 170202)
                {
                    if (idAction == 170203)
                    {
                        GClass205 gClass = (GClass205)p;
                        if (!list_2.Contains(gClass.sbyte_0))
                        {
                            list_2.Add(gClass.sbyte_0);
                            GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? ("Added skill " + gClass.string_0) : ("Đã thêm skill " + gClass.string_0), 0);
                        }
                        else
                        {
                            list_2.Remove(gClass.sbyte_0);
                            GClass167.gclass130_0.method_7((GClass62.int_0 == 0) ? ("Đã xóa skill " + gClass.string_0) : ("Deleted skill " + gClass.string_0), 0);
                        }
                    }
                }
                else
                {
                    GClass6 gClass2 = (GClass6)p;
                    if (!list_1.Contains(gClass2.method_16().sbyte_0))
                    {
                        list_1.Add(gClass2.method_16().sbyte_0);
                        GClass167.gclass130_0.method_7((GClass62.int_0 != 0) ? ("Added mob " + gClass2.method_16().string_0) : ("Đã thêm mob " + gClass2.method_16().string_0), 0);
                    }
                    else
                    {
                        list_1.Remove(gClass2.method_16().sbyte_0);
                        GClass167.gclass130_0.method_7((GClass62.int_0 == 0) ? ("Đã xóa mob " + gClass2.method_16().string_0) : ("Deleted mob " + gClass2.method_16().string_0), 0);
                    }
                }
            }
            else if (idAction != 10000)
            {
                switch (idAction)
                {
                    case 101101:
                    {
                        GClass122 gClass5 = new GClass122();
                        List<int> list = new List<int>();
                        for (int j = 0; j < GClass167.gclass122_9.method_2(); j++)
                        {
                            GClass6 gClass6 = (GClass6)GClass167.gclass122_9.method_3(j);
                            if (!list.Contains(gClass6.method_16().sbyte_0))
                            {
                                string text2 = (list_1.Contains(gClass6.method_16().sbyte_0) ? ((GClass62.int_0 != 0) ? "HAD" : "ĐÃ CÓ") : ((GClass62.int_0 == 0) ? "CHƯA CÓ" : "HADN'T"));
                                list.Add(gClass6.method_16().sbyte_0);
                                gClass5.method_0(new GClass118(gClass6.method_16().string_0 + "\n" + text2, this, 170202, gClass6));
                            }
                        }
                        GClass14.gclass116_0.bool_1 = true;
                        GClass14.gclass116_0.method_2(gClass5, 0);
                        break;
                    }
                    case 101102:
                    {
                        GClass122 gClass3 = new GClass122();
                        for (int i = 0; i < GClass124.smethod_1().gclass94_0.gclass205_0.Length; i++)
                        {
                            GClass205 gClass4 = GClass124.smethod_1().gclass94_0.gclass205_0[i];
                            if (gClass4 != null && gClass4.sbyte_0 != GClass41.smethod_0().int_0[GClass124.smethod_1().int_14])
                            {
                                string text = ((!list_2.Contains(gClass4.sbyte_0)) ? ((GClass62.int_0 != 0) ? "HADN'T" : "CHƯA CÓ") : ((GClass62.int_0 == 0) ? "ĐÃ CÓ" : "HAD"));
                                gClass3.method_0(new GClass118(gClass4.string_0 + "\n" + text, this, 170203, gClass4));
                            }
                        }
                        GClass14.gclass116_0.bool_1 = true;
                        GClass14.gclass116_0.method_2(gClass3, 0);
                        break;
                    }
                    case 101103:
                        if (int_0 != 0)
                        {
                            int_0 = 0;
                            GClass51.smethod_1((GClass62.int_0 == 0) ? "Chuyển sang chế độ ĐẶC BIỆT!" : "Change to mode special", 0);
                        }
                        else
                        {
                            int_0 = 1;
                            GClass51.smethod_1((GClass62.int_0 != 0) ? "Change to mode normal" : "Chuyển sang chế độ THƯỜNG!", 0);
                        }
                        break;
                    case 101104:
                        smethod_0().method_1((GClass62.int_0 == 0) ? "Nhập giới hạn HP quái" : "Fill mob HP limited");
                        break;
                    case 101105:
                        method_3("/listmobclr");
                        break;
                    case 101106:
                        bool_2 = !bool_2;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? ("Stop attack with game autotrain: " + GClass45.smethod_0().method_6(bool_2)) : ("Dừng đánh quái theo TĐLt của game: " + GClass45.smethod_0().method_6(bool_2)), 0);
                        break;
                    case 101107:
                        GClass2.smethod_0().method_78("/vdh");
                        break;
                }
            }
            else
            {
                GClass122 gClass7 = new GClass122();
                gClass7.method_0(new GClass118((GClass62.int_0 == 0) ? "D/s quái\nTrong map" : "List mob\nIn Map", this, 101101, null));
                gClass7.method_0(new GClass118((GClass62.int_0 != 0) ? "List skill\nUse when\nmurdering mob" : "D/s skill\ndùng khi\nđồ sát", this, 101102, null));
                gClass7.method_0(new GClass118((GClass62.int_0 == 0) ? ("Chế độ\nĐánh quái:\n" + ((int_0 == 0) ? "Đặc biệt" : "Đấm thường")) : ("Mode\nTrain:\n" + ((int_0 == 0) ? "Special" : "Normal")), this, 101103, null));
                gClass7.method_0(new GClass118((GClass62.int_0 != 0) ? ("LIMITED\nMOB HP:\n" + ((int_1 != 0) ? GClass138.smethod_9(int_1) : "UNLIMITED")) : ("Giới hạn\nHP Quái:\n" + ((int_1 == 0) ? "KO GIỚI HẠN" : GClass138.smethod_9(int_1))), this, 101104, null));
                if (list_1.Count > 0)
                    gClass7.method_0(new GClass118((GClass62.int_0 != 0) ? "Delete list\nType-Mob\nMurdering" : "Xóa d/s\nloại quái\nđồ sát", this, 101105, null));
                gClass7.method_0(new GClass118((GClass62.int_0 == 0) ? ("Dừng TĐLT\ncủa game:\n" + GClass45.smethod_0().method_7(bool_2)) : ("Stop game\nAuto Train:\n" + GClass45.smethod_0().method_7(bool_2)), this, 101106, null));
                gClass7.method_0(new GClass118((GClass62.int_0 != 0) ? ("Move cross\nTerrain:\n" + GClass45.smethod_0().method_7(GClass61.smethod_0().bool_5)) : ("Di chuyển\nvượt địa hình:\n" + GClass45.smethod_0().method_7(GClass61.smethod_0().bool_5)), this, 101107, null));
                GClass14.gclass116_0.bool_1 = true;
                GClass14.gclass116_0.method_2(gClass7, 0);
            }
        }

        public bool method_2(int asciiCode)
        {
            if (asciiCode != 110)
            {
                if (asciiCode != 116)
                    return false;
                if (GClass54.smethod_0().method_5())
                    GClass54.smethod_0().method_16();
                else
                    smethod_0().method_3("/dsq");
            }
            else
                smethod_0().method_3("/anhat");
            return true;
        }

        public bool method_3(string text)
        {
            switch (text)
            {
                case "/itemme":
                    smethod_0().bool_6 = !smethod_0().bool_6;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Chỉ nhặt item của mình: " + GClass45.smethod_0().method_6(smethod_0().bool_6)) : ("Only pickup my item: " + GClass45.smethod_0().method_6(smethod_0().bool_6)), 0);
                    return true;
                case "/dsqskill":
                    method_7("skill", "id", -1);
                    return true;
                case "/additem":
                    method_7("item", "id", -1);
                    return true;
                case "/addmob":
                    method_7("mob", "id", -1);
                    return true;
                case "/abf":
                    if (int_3 != 0 || int_4 != 0)
                    {
                        int_3 = 20;
                        int_4 = 20;
                        GClass51.smethod_1((GClass62.int_0 != 0) ? $"Auto use bean when HP lower than {int_3}%, MP lower than {int_4}%" : $"Tự động sử dụng đậu thần khi HP dưới {int_3}%, MP dưới {int_4}%", 0);
                    }
                    else
                        GClass51.smethod_1((GClass62.int_0 == 0) ? "Tự động sử dụng đậu thần: Tắt" : "Auto use bean: Off", 0);
                    return true;
                case "/additemt":
                    method_7("item", "type", -1);
                    return true;
                case "/anhat":
                    smethod_0().bool_5 = !smethod_0().bool_5;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto pickup item: " + GClass45.smethod_0().method_6(smethod_0().bool_5)) : ("Tự động nhặt item: " + GClass45.smethod_0().method_6(smethod_0().bool_5)), 0);
                    return true;
                case "/dsqskillclr":
                    list_2.Clear();
                    GClass51.smethod_1((GClass62.int_0 != 0) ? "List skill murdering set to default" : "Danh sách skill đồ sát quái đã được đặt về mặc định", 0);
                    return true;
                case "/dsq":
                    smethod_0().bool_0 = !smethod_0().bool_0;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Đồ sát quái: " + GClass45.smethod_0().method_6(smethod_0().bool_0)) : ("Murdering mob: " + GClass45.smethod_0().method_6(smethod_0().bool_0)), 0);
                    return true;
                case "/listitemclr":
                    list_3.Clear();
                    list_5.Clear();
                    list_4.Clear();
                    list_6.Clear();
                    list_4.AddRange(short_0);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? "List item pick-up set to default" : "Danh sách nhặt item đã được đặt về mặc định", 0);
                    return true;
                case "/psq":
                    smethod_0().bool_3 = !smethod_0().bool_3;
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Chỉ đánh siêu quái: " + GClass45.smethod_0().method_6(smethod_0().bool_3)) : ("Only attack super mob: " + GClass45.smethod_0().method_6(smethod_0().bool_3)), 0);
                    return true;
                case "/listmobclr":
                    list_0.Clear();
                    list_1.Clear();
                    GClass51.smethod_1((GClass62.int_0 == 0) ? "Danh sách quái đồ sát đã được đặt về mặc định" : "List mob murdering set to default", 0);
                    return true;
                case "/nsq":
                    smethod_0().bool_4 = !smethod_0().bool_4;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Only attack normal mob: " + GClass45.smethod_0().method_6(smethod_0().bool_4)) : ("Né siêu quái: " + GClass45.smethod_0().method_6(smethod_0().bool_4)), 0);
                    return true;
                case "/addmobt":
                    method_7("mob", "type", -1);
                    return true;
                case "/pem1hit":
                    smethod_0().bool_1 = !smethod_0().bool_1;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Attack mob to 1 HP: " + GClass45.smethod_0().method_6(smethod_0().bool_1)) : ("Đồ sát quái còn 1HP: " + GClass45.smethod_0().method_6(smethod_0().bool_1)), 0);
                    return true;
            }
            if (GClass45.smethod_0().method_11<int>(text, "/additem") && !GClass45.smethod_0().method_12<string>(text, "/additem").Contains("drop"))
                method_7("item", "id", GClass45.smethod_0().method_12<int>(text, "/additem"));
            else if (GClass45.smethod_0().method_11<string>(text, "/additem") && !GClass45.smethod_0().method_12<string>(text, "/additem").Contains("drop"))
            {
                string[] array = GClass45.smethod_0().method_12<string>(text, "/additem").Split(',');
                for (int i = 0; i < array.Length; i++)
                    method_7("item", "id", int.Parse(array[i]));
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/addmob"))
                method_7("mob", "id", GClass45.smethod_0().method_12<int>(text, "/addmob"));
            else if (GClass45.smethod_0().method_11<string>(text, "/addmob"))
            {
                string[] array6 = GClass45.smethod_0().method_12<string>(text, "/addmob").Split(',');
                for (int m = 0; m < array6.Length; m++)
                    method_7("mob", "id", int.Parse(array6[m]));
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/additemt") && !GClass45.smethod_0().method_12<string>(text, "/additemt").Contains("drop"))
                method_7("item", "type", GClass45.smethod_0().method_12<int>(text, "/additemt"));
            else if (GClass45.smethod_0().method_11<string>(text, "/additemt") && !GClass45.smethod_0().method_12<string>(text, "/additemt").Contains("drop"))
            {
                string[] array2 = GClass45.smethod_0().method_12<string>(text, "/additemt").Split(',');
                for (int j = 0; j < array2.Length; j++)
                    method_7("item", "type", int.Parse(array2[j]));
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/addmobt"))
            {
                method_7("mob", "type", GClass45.smethod_0().method_12<int>(text, "/addmobt"));
            }
            else if (GClass45.smethod_0().method_11<string>(text, "/addmobt"))
            {
                string[] array3 = GClass45.smethod_0().method_12<string>(text, "/addmobt").Split(',');
                for (int k = 0; k < array3.Length; k++)
                    method_7("mob", "type", int.Parse(array3[k]));
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/dsqskill"))
            {
                method_7("skill", "id", GClass45.smethod_0().method_12<int>(text, "/dsqskill"));
            }
            else if (GClass45.smethod_0().method_11<string>(text, "/dsqskill"))
            {
                string[] array4 = GClass45.smethod_0().method_12<string>(text, "/dsqskill").Split(',');
                for (int l = 0; l < array4.Length; l++)
                    method_7("skill", "id", int.Parse(array4[l]));
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/sln"))
            {
                int_2 = GClass45.smethod_0().method_12<int>(text, "/sln");
                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Giới hạn số lần nhặt {int_2}" : $"Limit time pick {int_2}", 0);
            }
            else if (GClass45.smethod_0().method_11<short>(text, "/blockitem"))
            {
                short num2 = GClass45.smethod_0().method_12<short>(text, "/blockitem");
                if (!list_4.Contains(num2))
                {
                    list_4.Add(num2);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added " + GClass17.smethod_1(num2).string_0 + " to list don't pick up by ID") : ("Thêm " + GClass17.smethod_1(num2).string_0 + " khỏi d/s không nhặt item theo ID"), 0);
                }
                else
                {
                    list_4.Remove(num2);
                    GClass51.smethod_1((GClass62.int_0 == 0) ? ("Xóa " + GClass17.smethod_1(num2).string_0 + " khỏi d/s không nhặt item theo ID") : ("Deleted " + GClass17.smethod_1(num2).string_0 + " from list don't pick up by ID"), 0);
                }
            }
            else if (GClass45.smethod_0().method_11<sbyte>(text, "/blockitemt"))
            {
                sbyte b = GClass45.smethod_0().method_12<sbyte>(text, "/blockitemt");
                if (!list_6.Contains(b))
                {
                    list_6.Add(b);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added [{b}] to list don't pick up by Type" : $"Thêm item [{b}] vào d/s không nhặt item theo loại", 0);
                }
                else
                {
                    list_6.Remove(b);
                    GClass51.smethod_1((GClass62.int_0 != 0) ? $"Deleted [{b}] from list don't pick up by Type" : $"Xóa item [{b}] khỏi d/s không nhặt item theo loại", 0);
                }
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/abf"))
            {
                int_3 = GClass45.smethod_0().method_12<int>(text, "/abf");
                int_4 = 0;
                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tự động sử dụng đậu thần khi HP dưới {int_3}%" : $"Auto use bean when HP lower than {int_3}%", 0);
            }
            else if (GClass45.smethod_0().method_10<int>(text, "/abf", 2))
            {
                int[] array5 = GClass45.smethod_0().method_8<int>(text, "/abf", 2);
                int_3 = array5[0];
                int_4 = array5[1];
                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tự động sử dụng đậu thần khi HP dưới {int_3}%, MP dưới {int_4}%" : $"Auto use bean when HP lower than {int_3}%, MP lower than {int_4}%", 0);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/mobhp"))
            {
                int_1 = GClass45.smethod_0().method_12<int>(text, "/mobhp");
                GClass51.smethod_1((GClass62.int_0 == 0) ? ("Cài đặt chỉ đánh quái dưới " + GClass138.smethod_9(int_1) + " HP") : ("Only attack mob lower than " + GClass138.smethod_9(int_1) + " HP"), 0);
            }
            else
                return false;
            return false;
        }

        public bool method_4(GClass190 itemMap)
        {
            return itemMap.gclass203_0.short_0 == 76 || itemMap.gclass203_0.short_0 == 188 || itemMap.gclass203_0.short_0 == 189 || itemMap.gclass203_0.short_0 == 190;
        }

        public void method_5()
        {
            if (GClass137.int_37 != 126 && !GClass47.smethod_0().method_50())
                return;
            for (int i = 0; i < GClass167.gclass122_6.method_2(); i++)
            {
                if (GClass167.gclass122_6.method_3(i) is GClass190 itemMap && method_4(itemMap))
                    GClass167.gclass122_6.method_7(i);
            }
        }

        public void method_6()
        {
            method_5();
            if (!GClass57.smethod_0().bool_0)
                method_10();
        }

        public void method_7(string obj, string type, int index)
        {
            if (type == "id")
            {
                switch (obj)
                {
                    case "skill":
                        if (index != -1)
                        {
                            GClass205 gClass = GClass124.smethod_1().gclass94_0.gclass205_0[index - 1];
                            if (list_2.Contains(gClass.sbyte_0))
                            {
                                list_2.Remove(gClass.sbyte_0);
                                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Deleted skill {gClass.string_0}[{gClass.sbyte_0}]" : $"Đã xóa skill {gClass.string_0}[{gClass.sbyte_0}]", 0);
                            }
                            else
                            {
                                list_2.Add(gClass.sbyte_0);
                                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added skill {gClass.string_0}[{gClass.sbyte_0}]" : $"Đã thêm skill {gClass.string_0}[{gClass.sbyte_0}]", 0);
                            }
                        }
                        else if (GClass124.smethod_1().gclass95_0 != null)
                        {
                            GClass205 gclass205_ = GClass124.smethod_1().gclass95_0.gclass205_0;
                            if (list_2.Contains(gclass205_.sbyte_0))
                            {
                                list_2.Remove(gclass205_.sbyte_0);
                                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Deleted skill {gclass205_.string_0}[{gclass205_.sbyte_0}]" : $"Đã xóa skill {gclass205_.string_0}[{gclass205_.sbyte_0}]", 0);
                            }
                            else
                            {
                                list_2.Add(gclass205_.sbyte_0);
                                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã thêm skill {gclass205_.string_0}[{gclass205_.sbyte_0}]" : $"Added skill {gclass205_.string_0}[{gclass205_.sbyte_0}]", 0);
                            }
                        }
                        break;
                    case "item":
                        if (index != -1)
                        {
                            if (list_3.Contains((short)index))
                            {
                                list_3.Remove((short)index);
                                GClass51.smethod_1((GClass62.int_0 != 0) ? ("Deleted item [" + GClass17.smethod_1((short)index).string_0 + "]") : ("Đã xóa item [" + GClass17.smethod_1((short)index).string_0 + "]"), 0);
                            }
                            else
                            {
                                list_3.Add((short)index);
                                GClass51.smethod_1((GClass62.int_0 == 0) ? ("Đã thêm item [" + GClass17.smethod_1((short)index).string_0 + "]") : ("Added item [" + GClass17.smethod_1((short)index).string_0 + "]"), 0);
                            }
                        }
                        else if (GClass124.smethod_1().gclass190_0 != null)
                        {
                            GClass190 gclass190_ = GClass124.smethod_1().gclass190_0;
                            if (!list_3.Contains(gclass190_.gclass203_0.short_0))
                            {
                                list_3.Add(gclass190_.gclass203_0.short_0);
                                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã thêm item [{gclass190_.gclass203_0.short_0}]" : $"Added item [{gclass190_.gclass203_0.short_0}]", 0);
                            }
                            else
                            {
                                list_3.Remove(gclass190_.gclass203_0.short_0);
                                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã xóa item [{gclass190_.gclass203_0.short_0}]" : $"Deleted item [{gclass190_.gclass203_0.short_0}]", 0);
                            }
                        }
                        break;
                    case "mob":
                        if (index != -1)
                        {
                            if (!list_0.Contains(index))
                            {
                                list_0.Add(index);
                                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added position {index}" : $"Đã thêm vị trí {index}", 0);
                            }
                            else
                            {
                                list_0.Remove(index);
                                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã xóa vị trí {index}" : $"Deleted position {index}", 0);
                            }
                        }
                        else if (GClass124.smethod_1().gclass6_0 != null)
                        {
                            GClass6 gclass6_ = GClass124.smethod_1().gclass6_0;
                            if (list_0.Contains(gclass6_.int_25))
                            {
                                list_0.Remove(gclass6_.int_25);
                                GClass51.smethod_1((GClass62.int_0 != 0) ? $"Deleted mob position {gclass6_.int_25}" : $"Đã xóa vị trí {gclass6_.int_25}", 0);
                            }
                            else
                            {
                                list_0.Add(gclass6_.int_25);
                                GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã thêm vị trí {gclass6_.int_25}" : $"Added mob position {gclass6_.int_25}", 0);
                            }
                        }
                        break;
                }
            }
            else
            {
                if (!(type == "type"))
                    return;
                if (obj == "mob")
                {
                    if (index != -1)
                    {
                        if (list_1.Contains(index))
                        {
                            list_1.Remove(index);
                            GClass51.smethod_1((GClass62.int_0 == 0) ? ("Đã xóa loại quái [" + GClass6.gclass76_0[index].string_0 + "]") : ("Deleted type-mob [" + GClass6.gclass76_0[index].string_0 + "]"), 0);
                        }
                        else
                        {
                            list_1.Add(index);
                            GClass51.smethod_1((GClass62.int_0 == 0) ? ("Đã thêm loại quái [" + GClass6.gclass76_0[index].string_0 + "]") : ("Added type-mob [" + GClass6.gclass76_0[index].string_0 + "]"), 0);
                        }
                    }
                    else if (GClass124.smethod_1().gclass6_0 != null)
                    {
                        GClass6 gclass6_2 = GClass124.smethod_1().gclass6_0;
                        if (!list_1.Contains(gclass6_2.int_26))
                        {
                            list_1.Add(gclass6_2.int_26);
                            GClass51.smethod_1((GClass62.int_0 != 0) ? ("Added type-mob [" + gclass6_2.method_16().string_0 + "]") : ("Đã thêm loại quái [" + gclass6_2.method_16().string_0 + "]"), 0);
                        }
                        else
                        {
                            list_1.Remove(gclass6_2.int_26);
                            GClass51.smethod_1((GClass62.int_0 != 0) ? ("Deleted type-mob [" + gclass6_2.method_16().string_0 + "]") : ("Đã xóa loại quái [" + gclass6_2.method_16().string_0 + "]"), 0);
                        }
                    }
                }
                else
                {
                    if (!(obj == "item"))
                        return;
                    if (index != -1)
                    {
                        if (list_5.Contains((sbyte)index))
                        {
                            list_5.Remove((sbyte)index);
                            GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã xóa item {GClass17.smethod_1((short)index).string_0}[{index}]" : $"Deleted item {GClass17.smethod_1((short)index).string_0}[{index}]", 0);
                        }
                        else
                        {
                            list_5.Add((sbyte)index);
                            GClass51.smethod_1((GClass62.int_0 != 0) ? $"Added item {GClass17.smethod_1((short)index).string_0}[{index}]" : $"Đã thêm item {GClass17.smethod_1((short)index).string_0}[{index}]", 0);
                        }
                    }
                    else if (GClass124.smethod_1().gclass190_0 != null)
                    {
                        GClass190 gclass190_2 = GClass124.smethod_1().gclass190_0;
                        if (list_5.Contains(gclass190_2.gclass203_0.sbyte_0))
                        {
                            list_5.Remove(gclass190_2.gclass203_0.sbyte_0);
                            GClass51.smethod_1((GClass62.int_0 != 0) ? $"Deleted item {gclass190_2.gclass203_0.string_0}[{gclass190_2.gclass203_0.sbyte_0}]" : $"Đã xóa item {gclass190_2.gclass203_0.string_0}[{gclass190_2.gclass203_0.sbyte_0}]", 0);
                        }
                        else
                        {
                            list_5.Add(gclass190_2.gclass203_0.sbyte_0);
                            GClass51.smethod_1((GClass62.int_0 == 0) ? $"Đã thêm item {gclass190_2.gclass203_0.string_0}[{gclass190_2.gclass203_0.sbyte_0}]" : $"Added item {gclass190_2.gclass203_0.string_0}[{gclass190_2.gclass203_0.sbyte_0}]", 0);
                        }
                    }
                }
            }
        }

        public void method_8(object obj)
        {
            GClass6 gClass = (GClass6)obj;
            if (gClass.int_12 != 1 && gClass.int_12 != 0)
            {
                gClass.long_0 = GClass77.smethod_18();
                gClass.int_0++;
                if (gClass.int_0 > 10 && !GClass47.smethod_0().method_50())
                    gClass.int_0 = 0;
            }
        }

        public void method_9(GClass6 mob)
        {
            if (mob.sbyte_14 != 0 && !GClass47.smethod_0().method_50())
                mob.int_0 = 0;
        }

        public static void smethod_1(int time)
        {
            bool_9 = true;
            long_0 = GClass77.smethod_18();
            long_1 = time;
        }

        public static bool smethod_2()
        {
            if (bool_9 && GClass77.smethod_18() - long_0 >= long_1)
                bool_9 = false;
            return bool_9;
        }

        public void method_10()
        {
            if ((GClass42.smethod_0().bool_6 && !GClass42.smethod_0().bool_7) || (GClass42.smethod_0().bool_8 && !GClass42.smethod_0().bool_9) || (GClass42.smethod_0().bool_3 && GClass42.smethod_0().method_22() > 0))
                return;
            if (GClass41.smethod_0().bool_2)
            {
                for (int i = 0; i < GClass167.gclass95_0.Length; i++)
                {
                    GClass95 gClass = GClass167.gclass95_0[i];
                    if (gClass != null && gClass.gclass205_0.sbyte_0.Equals(GClass41.smethod_0().int_0[GClass124.smethod_1().int_14]) && GClass77.smethod_18() - gClass.long_1 > gClass.int_1 + 500)
                        return;
                }
            }
            try
            {
                if (smethod_2())
                    return;
                GClass124 gClass2 = GClass124.smethod_1();
                if (gClass2.int_11 == 14 || gClass2.int_25 <= 0)
                    return;
                if (((gClass2.int_25 <= gClass2.int_35 * int_3 / 100 && int_3 != 0) || (gClass2.int_24 <= gClass2.int_36 * int_4 / 100 && int_4 != 0)) && GClass77.smethod_18() - long_3 > 9000L)
                {
                    GClass167.smethod_8().method_50();
                    long_3 = GClass77.smethod_18();
                }
                bool flag;
                bool flag2 = (flag = GClass82.smethod_0(4387)) && bool_0;
                if (smethod_0().bool_5 && !flag2 && !GClass54.smethod_0().method_5())
                {
                    if (GClass137.int_37 == GClass124.smethod_1().int_14 + 21 && GClass167.gclass122_6.method_2() > 0)
                    {
                        GClass2.smethod_0().method_74(-1);
                        smethod_1(1000);
                        return;
                    }
                    int_2 = ((!smethod_0().bool_6) ? 100 : 2);
                    if (bool_8)
                    {
                        if (int_5 >= list_7.Count)
                        {
                            bool_8 = false;
                            return;
                        }
                        GClass190 gClass3 = list_7[int_5];
                        switch (method_12(gClass3))
                        {
                            case GEnum0.const_0:
                                int_5++;
                                return;
                            case GEnum0.const_1:
                                GClass2.smethod_0().method_44();
                                GClass2.smethod_0().method_74(gClass3.int_9);
                                gClass3.int_0++;
                                smethod_1(500);
                                int_5++;
                                return;
                            case GEnum0.const_2:
                                gClass2.int_4 = gClass3.int_3;
                                gClass2.int_5 = gClass3.int_4;
                                GClass2.smethod_0().method_44();
                                GClass2.smethod_0().method_74(gClass3.int_9);
                                gClass3.int_0++;
                                int_5++;
                                smethod_1(100);
                                return;
                            case GEnum0.const_3:
                                method_11(gClass3.int_3, gClass3.int_4);
                                gClass2.gclass6_0 = null;
                                gClass3.int_0++;
                                smethod_1(500);
                                return;
                        }
                    }
                    list_7.Clear();
                    int_5 = 0;
                    for (int j = 0; j < GClass167.gclass122_6.method_2(); j++)
                    {
                        GClass190 gClass4 = (GClass190)GClass167.gclass122_6.method_3(j);
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
                    smethod_1(500);
                    return;
                }
                gClass2.method_104(0);
                if (gClass2.gclass6_0 != null && !method_16(gClass2.gclass6_0))
                    gClass2.gclass6_0 = null;
                if (gClass2.gclass6_0 == null)
                {
                    gClass2.gclass6_0 = method_14();
                    if (flag && gClass2.gclass6_0 != null)
                    {
                        GClass124.smethod_1().int_4 = gClass2.gclass6_0.int_16 - 24;
                        GClass124.smethod_1().int_5 = gClass2.gclass6_0.int_17;
                        GClass2.smethod_0().method_44();
                    }
                }
                if (gClass2.gclass6_0 == null)
                {
                    if (!flag)
                    {
                        GClass6 gClass5 = method_15();
                        if (gClass5 != null)
                            method_11(gClass5.int_16 - 24, gClass5.int_17);
                    }
                }
                else if (gClass2.method_75() == null)
                {
                    GClass95 gClass6 = method_19();
                    if (gClass6 != null && !gClass6.bool_0)
                    {
                        GClass6 gclass6_ = gClass2.gclass6_0;
                        gclass6_.int_8 = gclass6_.int_16;
                        gclass6_.int_9 = gclass6_.int_17;
                        if (GClass124.smethod_1().gclass95_0 != gClass6 || GClass124.smethod_1().int_11 == 5 || GClass124.smethod_1().gclass95_0.gclass205_0.int_3 == 3 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 10 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 11 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 20)
                            GClass167.smethod_8().method_62(gClass6, true);
                        if (GClass47.smethod_0().bool_3)
                        {
                            if (GClass124.smethod_1().int_20 < 2000)
                                GClass41.smethod_0().method_14();
                            return;
                        }
                        bool flag3 = GClass191.smethod_24(gclass6_.int_16, gclass6_.int_17, gClass2.int_4, gClass2.int_5) > 48;
                        bool flag4 = GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 20;
                        if (flag3)
                        {
                            if (flag4)
                                GClass41.smethod_0().method_14();
                            else if (!flag)
                            {
                                method_11(gclass6_.int_16, gclass6_.int_17);
                            }
                            else if (GClass77.smethod_18() - long_2 > 500L && GClass124.smethod_1().int_11 == 1)
                            {
                                GClass124.smethod_1().int_4 = gclass6_.int_16 - 24;
                                GClass124.smethod_1().int_5 = gclass6_.int_17;
                                GClass2.smethod_0().method_44();
                                long_2 = GClass77.smethod_18();
                            }
                            return;
                        }
                        if (smethod_0().bool_1 && gclass6_.int_6 <= 1)
                            return;
                        if (int_0 != 0)
                        {
                            GClass167.smethod_8().method_62(gClass6, true);
                            if (GClass191.smethod_24(gclass6_.int_16, gclass6_.int_17, gClass2.int_4, gClass2.int_5) <= 48)
                                GClass167.smethod_8().method_44(gclass6_);
                            return;
                        }
                        if (GClass124.smethod_1().int_11 == 5 || GClass124.smethod_1().gclass95_0.gclass205_0.int_3 == 3 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 10 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 11)
                            GClass167.smethod_8().method_64(gClass6);
                        if (GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 != 20 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 20)
                            GClass41.smethod_0().method_14();
                    }
                }
                smethod_1(100);
            }
            catch (Exception ex)
            {
                GClass51.smethod_0("Data/Errors/startMurderingMob.txt", ex.ToString());
            }
        }

        public void method_11(int x, int y)
        {
            GClass124 gClass = GClass124.smethod_1();
            if (GClass61.smethod_0().bool_5)
            {
                int[] array = method_24(gClass.int_4, x);
                if (array[1] >= y || (array[1] >= gClass.int_5 && (gClass.int_11 == 2 || gClass.int_11 == 1)))
                {
                    array[0] = x;
                    array[1] = y;
                }
                gClass.gclass119_0 = new GClass119(array[0], array[1]);
            }
            else
                gClass.gclass119_0 = new GClass119(x, y);
        }

        public GEnum0 method_12(GClass190 itemMap)
        {
            GClass124 gClass = GClass124.smethod_1();
            bool flag = itemMap.int_8 == gClass.int_13 || itemMap.int_8 == -1;
            if (!smethod_0().bool_6 || flag)
            {
                if (!smethod_0().bool_7 || itemMap.int_0 <= int_2)
                {
                    if (method_13(itemMap))
                    {
                        if (GClass191.smethod_28(gClass.int_4 - itemMap.int_3) >= 60 || GClass191.smethod_28(gClass.int_5 - itemMap.int_4) >= 60)
                        {
                            if (!GClass82.smethod_0(4387))
                            {
                                if (smethod_0().bool_0)
                                    return GEnum0.const_3;
                                return GEnum0.const_0;
                            }
                            return GEnum0.const_2;
                        }
                        return GEnum0.const_1;
                    }
                    return GEnum0.const_0;
                }
                return GEnum0.const_0;
            }
            return GEnum0.const_0;
        }

        public bool method_13(GClass190 itemMap)
        {
            if (list_3.Count == 0 || list_3.Contains(itemMap.gclass203_0.short_0))
            {
                if (list_4.Count != 0 && list_4.Contains(itemMap.gclass203_0.short_0))
                    return false;
                if (list_5.Count != 0 && !list_5.Contains(itemMap.gclass203_0.sbyte_0))
                    return false;
                if (list_6.Count != 0 && list_6.Contains(itemMap.gclass203_0.sbyte_0))
                    return false;
                return true;
            }
            return false;
        }

        public GClass6 method_14()
        {
            GClass6 result = null;
            int num = int.MaxValue;
            GClass124 gClass = GClass124.smethod_1();
            for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
            {
                GClass6 gClass2 = (GClass6)GClass167.gclass122_9.method_3(i);
                int num2 = (gClass2.int_16 - gClass.int_4) * (gClass2.int_16 - gClass.int_4) + (gClass2.int_17 - gClass.int_5) * (gClass2.int_17 - gClass.int_5);
                if (!method_16(gClass2) || num2 >= num || smethod_0().int_1 != 0)
                {
                    if (method_16(gClass2) && num2 < num && smethod_0().int_1 != 0 && smethod_0().int_1 >= gClass2.int_6)
                    {
                        result = gClass2;
                        num = num2;
                    }
                }
                else
                {
                    result = gClass2;
                    num = num2;
                }
            }
            return result;
        }

        public GClass6 method_15()
        {
            GClass6 result = null;
            long num = GClass77.smethod_18();
            for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
            {
                GClass6 gClass = (GClass6)GClass167.gclass122_9.method_3(i);
                if (method_17(gClass) && gClass.long_0 < num)
                {
                    result = gClass;
                    num = gClass.long_0;
                }
            }
            return result;
        }

        public bool method_16(GClass6 mob)
        {
            if (mob.int_12 == 0 || mob.int_12 == 1 || mob.int_6 <= 0 || mob.bool_13)
                return false;
            if (mob.sbyte_14 != 0 && smethod_0().bool_4)
                return false;
            if (mob.sbyte_14 != 0 || !smethod_0().bool_3)
            {
                if (!method_18(mob))
                    return false;
                if (smethod_0().int_1 != 0 && smethod_0().int_1 < mob.int_6)
                    return false;
                return true;
            }
            return false;
        }

        public bool method_17(GClass6 mob)
        {
            if (mob.bool_13)
                return false;
            if (method_18(mob))
            {
                if (smethod_0().bool_4 && !GClass82.smethod_0(4387) && mob.method_16().int_0 >= 3000)
                {
                    if (mob.sbyte_14 != 0)
                    {
                        GClass6 gClass = null;
                        bool flag = false;
                        for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
                        {
                            gClass = (GClass6)GClass167.gclass122_9.method_3(i);
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
            return false;
        }

        public bool method_18(GClass6 mob)
        {
            if (list_0.Count != 0 && !list_0.Contains(mob.int_25))
                return false;
            if (list_1.Count != 0 && !list_1.Contains(mob.int_26))
                return false;
            return true;
        }

        public GClass95 method_19()
        {
            if (GClass124.smethod_1().int_14 == 2)
            {
                list_2.Remove(0);
                list_2.Remove(2);
                list_2.Remove(17);
            }
            GClass95 gClass = null;
            GClass205 gClass2 = new GClass205();
            foreach (sbyte item in list_2)
            {
                gClass2.sbyte_0 = item;
                GClass95 gClass3 = GClass124.smethod_1().method_16(gClass2);
                if (method_20(gClass3, gClass))
                    gClass = gClass3;
            }
            return gClass;
        }

        public bool method_20(GClass95 SkillBetter, GClass95 skill)
        {
            if (SkillBetter != null)
            {
                if (!method_21(SkillBetter))
                    return false;
                bool flag = (SkillBetter.gclass205_0.sbyte_0 == 17 && skill.gclass205_0.sbyte_0 == 2) || (SkillBetter.gclass205_0.sbyte_0 == 9 && skill.gclass205_0.sbyte_0 == 0);
                if (skill != null && skill.int_1 >= SkillBetter.int_1 && !flag)
                    return false;
                return true;
            }
            return false;
        }

        public bool method_21(GClass95 skill)
        {
            if (GClass77.smethod_18() - skill.long_1 > skill.int_1)
                skill.bool_0 = false;
            if (skill.bool_0 && !sbyte_1.Contains(skill.gclass205_0.sbyte_0))
                return false;
            if (!sbyte_2.Contains(skill.gclass205_0.sbyte_0))
            {
                if (GClass124.smethod_1().int_24 >= method_22(skill))
                    return true;
                return false;
            }
            return false;
        }

        public int method_22(GClass95 skill)
        {
            if (skill.gclass205_0.int_2 != 2)
            {
                if (skill.gclass205_0.int_2 == 1)
                    return skill.int_5 * GClass124.smethod_1().int_36 / 100;
                return skill.int_5;
            }
            return 1;
        }

        public int method_23(int xsd)
        {
            GClass124 gClass = GClass124.smethod_1();
            int num = GClass137.int_24;
            int result = -1;
            for (int i = 24; i < GClass137.int_24; i += 24)
            {
                if (GClass137.smethod_28(xsd, i, 2))
                {
                    int num2 = GClass191.smethod_28(i - gClass.int_5);
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
            int num = GClass137.int_24;
            int num2 = -1;
            if (xStart <= xEnd)
            {
                for (int num3 = xEnd; num3 > xStart; num3 -= 24)
                {
                    int num4 = method_23(num3);
                    if (num4 < num)
                    {
                        num = num4;
                        num2 = num3;
                    }
                }
            }
            else
            {
                for (int i = xEnd; i < xStart; i += 24)
                {
                    int num5 = method_23(i);
                    if (num5 < num)
                    {
                        num = num5;
                        num2 = i;
                    }
                }
            }
            return new int[2] { num2, num };
        }
    }
}
