namespace ns1
{
    public class GClass57
    {
        public bool bool_0;

        public bool bool_1 = false;

        public bool bool_2 = true;

        public bool bool_3 = true;

        public bool bool_4 = true;

        public int int_0 = -1;

        private static GClass57 gclass57_0;

        public static GClass57 smethod_0()
        {
            return (gclass57_0 != null) ? gclass57_0 : (gclass57_0 = new GClass57());
        }

        public bool method_0(string text)
        {
            switch (text)
            {
                case "/xmp":
                    if (!bool_0)
                        Class11.smethod_0().method_3();
                    else
                    {
                        Class11.smethod_0().method_9();
                        GClass51.smethod_1((GClass62.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
                    }
                    return true;
                case "/nrd":
                    if (bool_0)
                    {
                        Class11.smethod_0().int_3 = -1;
                        Class11.smethod_0().method_9();
                    }
                    return true;
                case "/csdb":
                    bool_4 = !bool_4;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Use special capsule: " + GClass45.smethod_0().method_6(bool_4)) : ("Sử dụng capsule đặc biệt: " + GClass45.smethod_0().method_6(bool_4)), 0);
                    return true;
                case "/csb":
                    bool_3 = !bool_3;
                    GClass51.smethod_1((GClass62.int_0 != 0) ? ("Use normal capsule: " + GClass45.smethod_0().method_6(bool_3)) : ("Sử dụng capsule thường: " + GClass45.smethod_0().method_6(bool_3)), 0);
                    return true;
            }
            if (GClass45.smethod_0().method_10<int>(text, "/nrd", 2))
            {
                int[] array = GClass45.smethod_0().method_8<int>(text, "/nrd", 2);
                Class11.smethod_0().int_3 = array[1];
                Class11.smethod_0().method_8(array[0] + 84);
            }
            else if (GClass45.smethod_0().method_11<int>(text, "/xmp"))
            {
                if (bool_0)
                {
                    Class11.smethod_0().method_9();
                    GClass51.smethod_1((GClass62.int_0 != 0) ? "Cancel auto nextmap" : "Đã hủy tự động nextmap", 0);
                }
                else
                {
                    int int_ = GClass45.smethod_0().method_12<int>(text, "/xmp");
                    Class11.smethod_0().method_8(int_);
                }
            }
            else
                return false;
            return true;
        }

        public bool method_1(int asciiCode)
        {
            if (asciiCode != 99)
            {
                switch (asciiCode)
                {
                    default:
                        if (asciiCode != 120)
                            return false;
                        if (!GClass47.smethod_0().bool_3)
                        {
                            if (bool_0)
                            {
                                Class11.smethod_0().method_9();
                                GClass51.smethod_1((GClass62.int_0 != 0) ? "Cancel auto nextmap" : "Đã hủy tự động nextmap", 0);
                            }
                            else
                                Class11.smethod_0().method_3();
                        }
                        else
                        {
                            GClass48.smethod_0().bool_0 = false;
                            GClass47.smethod_0().bool_3 = false;
                            GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động teleport: " + GClass45.smethod_0().method_6(GClass47.smethod_0().bool_3)) : ("Auto teleporting: " + GClass45.smethod_0().method_6(GClass47.smethod_0().bool_3)), 0);
                        }
                        break;
                    case 106:
                        GClass61.smethod_0().method_17(0);
                        break;
                    case 107:
                        if (GClass137.int_37 == 135 || GClass137.int_37 == 138 || GClass137.int_37 == 136)
                        {
                            if (GClass137.int_37 != 135)
                            {
                                if (GClass137.int_37 == 138)
                                    Class11.smethod_0().method_24(360, 336);
                                else if (GClass137.int_37 == 136)
                                {
                                    Class11.smethod_0().method_24(720, 576);
                                }
                            }
                            else
                                Class11.smethod_0().method_24(600, 600);
                        }
                        else
                            GClass61.smethod_0().method_17(2);
                        break;
                    case 108:
                        GClass61.smethod_0().method_17(1);
                        break;
                }
            }
            else
            {
                for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
                {
                    GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
                    if (gClass == null)
                        continue;
                    if (gClass.gclass203_0.short_0 != 193)
                    {
                        if (gClass.gclass203_0.short_0 == 194)
                            GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
                    }
                    else
                        GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
                }
            }
            return true;
        }

        public void method_2()
        {
            if (GClass46.smethod_0().bool_1)
                GClass46.smethod_0().method_3();
            if (bool_0)
                Class11.smethod_0().method_0();
        }

        public void method_3(string text)
        {
            if (bool_0)
            {
                if (text.ToLower().Contains("Không thể chuyển map quá nhanh"))
                    Class11.smethod_0().method_1(1000);
                if (text.ToLower().Contains((mResources.language != 0) ? "please wait" : "vui lòng chờ"))
                {
                    GClass14.gclass113_0.bool_0 = false;
                    GClass14.gclass113_0.method_151();
                    GClass14.smethod_1().method_10(99);
                }
                if (text.Equals((mResources.language == 0) ? "Bạn chưa thể đến khu vực này" : "You can not travel to this area") || text.ToLower().Contains((mResources.language != 0) ? "can not enter this area" : "không thể vào khu vực này"))
                    Class11.smethod_0().method_9();
                if (text.ToLower().Contains((mResources.language == 0) ? "sức mạnh phải dưới" : "power must lower than"))
                    Class11.smethod_0().method_9();
                if (text.ToLower().Contains((mResources.language == 0) ? "yêu cầu sức mạnh lớn hơn" : "require power more than"))
                    Class11.smethod_0().method_9();
            }
        }

        public bool method_4(object obj)
        {
            GClass36 gClass = (GClass36)obj;
            if (!gClass.bool_0)
                return false;
            GClass124.smethod_1().bool_2 = false;
            if (gClass.int_3 == 0)
            {
                GClass93.bool_5 = false;
                GClass124.bool_33 = true;
            }
            GClass36.gclass122_0.method_8(gClass);
            return true;
        }

        public void method_5(int selected)
        {
            if (bool_1)
            {
                Class11.smethod_0().method_23();
                int int_ = GClass46.smethod_3(GClass14.gclass113_0.string_4[selected]);
                Class11.smethod_0().method_8(int_);
            }
            else
            {
                Class11.smethod_0().method_10();
                GClass2.smethod_0().method_126(selected);
            }
        }

        public void method_6()
        {
            bool_1 = false;
            if (bool_2)
            {
                GClass14.gclass113_0.method_6();
                GClass14.gclass113_0.method_50();
            }
            else
                bool_2 = true;
        }

        public void method_7()
        {
            GClass93.smethod_0().method_9(0);
            GClass2.smethod_0().method_117();
            GClass124.bool_35 = false;
        }
    }
}
