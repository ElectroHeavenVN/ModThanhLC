using System;
using System.Collections.Generic;
using System.Linq;

namespace AssemblyCSharp.Functions
{
	public class GClass166 : GInterface4, GInterface6
	{
		public enum GEnum1
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

		private static GClass166 gclass166_0;

		private static readonly sbyte[] sbyte_1 = new sbyte[5] { 0, 9, 2, 17, 4 };

		private static readonly sbyte[] sbyte_2 = new sbyte[5] { 10, 11, 14, 23, 7 };

		public static bool bool_8;

		private static bool bool_9;

		private static long long_0;

		private static long long_1;

		public static List<GClass64> list_7 = new List<GClass64>();

		private static int int_5 = 0;

		public static long long_2;

		public long long_3;

		public long long_4;

		public static GClass166 smethod_0()
		{
			return (gclass166_0 != null) ? gclass166_0 : (gclass166_0 = new GClass166());
		}

		private void method_0()
		{
			GClass91.smethod_0().string_1 = "Chat";
			GClass91.smethod_0().gclass191_0.string_7 = "chat";
			GClass91.smethod_0().bool_0 = false;
		}

		public void onCancelChat()
		{
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass91.smethod_0().gclass191_0.method_21() == null || GClass91.smethod_0().gclass191_0.method_21().Equals("") || text.Equals("") || text == null)
				GClass91.smethod_0().bool_0 = false;
			else if (GClass91.smethod_0().string_1.Equals((GClass151.int_0 == 0) ? "Nhập giới hạn HP quái" : "Fill mob HP limited"))
			{
				method_5($"/mobhp{int.Parse(GClass91.smethod_0().gclass191_0.method_21())}");
				method_0();
			}
			method_0();
		}

		public void method_1(string text)
		{
			GClass91.smethod_0().string_1 = text;
			GClass91.smethod_0().gclass191_0.string_7 = mResources.CHAT;
			GClass73.gclass76_0.bool_0 = false;
			GClass91.smethod_0().method_5(smethod_0(), "");
		}

		public void method_2()
		{
			GClass88 gClass = new GClass88();
			List<int> list = new List<int>();
			for (int i = 0; i < GClass144.gclass88_9.method_2(); i++)
			{
				GClass194 gClass2 = (GClass194)GClass144.gclass88_9.method_3(i);
				if (!list.Contains(gClass2.method_16().sbyte_0))
				{
					string text = ((!list_1.Contains(gClass2.method_16().sbyte_0)) ? ((GClass151.int_0 == 0) ? "CHƯA CÓ" : "HADN'T") : ((GClass151.int_0 == 0) ? "ĐÃ CÓ" : "HAD"));
					list.Add(gClass2.method_16().sbyte_0);
					gClass.method_0(new GClass87(gClass2.method_16().string_0 + "\n" + text, this, 170202, gClass2));
				}
			}
			GClass73.gclass145_0.bool_1 = true;
			GClass73.gclass145_0.method_2(gClass, 0);
		}

		public void method_3()
		{
			GClass88 gClass = new GClass88();
			for (int i = 0; i < GClass78.smethod_1().gclass176_0.gclass47_0.Length; i++)
			{
				GClass47 gClass2 = GClass78.smethod_1().gclass176_0.gclass47_0[i];
				if (gClass2 != null && gClass2.sbyte_0 != GClass164.smethod_0().int_0[GClass78.smethod_1().int_14])
				{
					string text = ((!list_2.Contains(gClass2.sbyte_0)) ? ((GClass151.int_0 != 0) ? "HADN'T" : "CHƯA CÓ") : ((GClass151.int_0 == 0) ? "ĐÃ CÓ" : "HAD"));
					gClass.method_0(new GClass87(gClass2.string_0 + "\n" + text, this, 170203, gClass2));
				}
			}
			GClass73.gclass145_0.bool_1 = true;
			GClass73.gclass145_0.method_2(gClass, 0);
		}

		public void perform(int idAction, object p)
		{
			if (GClass148.smethod_0().bool_0 || GClass159.smethod_0().bool_18)
				return;
			if (idAction <= 101107)
			{
				if (idAction != 10000)
				{
					switch (idAction)
					{
					case 101101:
						method_2();
						break;
					case 101102:
						method_3();
						break;
					case 101103:
						if (int_0 == 0)
						{
							int_0 = 1;
							GClass149.smethod_1((GClass151.int_0 != 0) ? "Change to mode normal" : "Chuyển sang chế độ THƯỜNG!", 0);
						}
						else
						{
							int_0 = 0;
							GClass149.smethod_1((GClass151.int_0 != 0) ? "Change to mode special" : "Chuyển sang chế độ ĐẶC BIỆT!", 0);
						}
						break;
					case 101104:
						smethod_0().method_1((GClass151.int_0 == 0) ? "Nhập giới hạn HP quái" : "Fill mob HP limited");
						break;
					case 101105:
						method_5("/listmobclr");
						break;
					case 101106:
						bool_2 = !bool_2;
						GClass149.smethod_1((GClass151.int_0 == 0) ? ("Dừng đánh quái theo TĐLt của game: " + GClass154.smethod_0().method_6(bool_2)) : ("Stop attack with game autotrain: " + GClass154.smethod_0().method_6(bool_2)), 0);
						break;
					case 101107:
						GClass7.smethod_0().method_78("/vdh");
						break;
					}
				}
				else
				{
					GClass88 gClass = new GClass88();
					gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "D/s quái\nTrong map" : "List mob\nIn Map", this, 101101, null));
					gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "D/s skill\ndùng khi\nđồ sát" : "List skill\nUse when\nmurdering mob", this, 101102, null));
					gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ("Mode\nTrain:\n" + ((int_0 != 0) ? "Normal" : "Special")) : ("Chế độ\nĐánh quái:\n" + ((int_0 == 0) ? "Đặc biệt" : "Đấm thường")), this, 101103, null));
					gClass.method_0(new GClass87((GClass151.int_0 == 0) ? ("Giới hạn\nHP Quái:\n" + ((int_1 == 0) ? "KO GIỚI HẠN" : GClass65.smethod_9(int_1))) : ("LIMITED\nMOB HP:\n" + ((int_1 == 0) ? "UNLIMITED" : GClass65.smethod_9(int_1))), this, 101104, null));
					if (list_1.Count > 0)
						gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Xóa d/s\nloại quái\nđồ sát" : "Delete list\nType-Mob\nMurdering", this, 101105, null));
					gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ("Stop game\nAuto Train:\n" + GClass154.smethod_0().method_7(bool_2)) : ("Dừng TĐLT\ncủa game:\n" + GClass154.smethod_0().method_7(bool_2)), this, 101106, null));
					gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ("Move cross\nTerrain:\n" + GClass154.smethod_0().method_7(GClass157.smethod_0().bool_5)) : ("Di chuyển\nvượt địa hình:\n" + GClass154.smethod_0().method_7(GClass157.smethod_0().bool_5)), this, 101107, null));
					GClass73.gclass145_0.bool_1 = true;
					GClass73.gclass145_0.method_2(gClass, 0);
				}
			}
			else if (idAction != 170202)
			{
				if (idAction == 170203)
				{
					GClass47 gClass2 = (GClass47)p;
					if (list_2.Contains(gClass2.sbyte_0))
					{
						list_2.Remove(gClass2.sbyte_0);
						GClass144.gclass52_0.method_7((GClass151.int_0 != 0) ? ("Deleted skill " + gClass2.string_0) : ("Đã xóa skill " + gClass2.string_0), 0);
					}
					else
					{
						list_2.Add(gClass2.sbyte_0);
						GClass144.gclass52_0.method_7((GClass151.int_0 != 0) ? ("Added skill " + gClass2.string_0) : ("Đã thêm skill " + gClass2.string_0), 0);
					}
				}
			}
			else
			{
				GClass194 gClass3 = (GClass194)p;
				if (!list_1.Contains(gClass3.method_16().sbyte_0))
				{
					list_1.Add(gClass3.method_16().sbyte_0);
					GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? ("Đã thêm mob " + gClass3.method_16().string_0) : ("Added mob " + gClass3.method_16().string_0), 0);
				}
				else
				{
					list_1.Remove(gClass3.method_16().sbyte_0);
					GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? ("Đã xóa mob " + gClass3.method_16().string_0) : ("Deleted mob " + gClass3.method_16().string_0), 0);
				}
			}
		}

		public bool method_4(int asciiCode)
		{
			if (asciiCode != 110)
			{
				if (asciiCode != 116)
					return false;
				if (!GClass153.smethod_0().method_6())
					smethod_0().method_5("/dsq");
				else
					GClass153.smethod_0().method_18();
			}
			else
				smethod_0().method_5("/anhat");
			return true;
		}

        public bool method_5(string text)
        {
            switch (text)
            {
                case "/listitemclr":
                    list_3.Clear();
                    list_5.Clear();
                    list_4.Clear();
                    list_6.Clear();
                    list_4.AddRange(short_0);
                    GClass149.smethod_1((GClass151.int_0 != 0) ? "List item pick-up set to default" : "Danh sách nhặt item đã được đặt về mặc định", 0);
                    break;
                case "/psq":
                    smethod_0().bool_3 = !smethod_0().bool_3;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Only attack super mob: " + GClass154.smethod_0().method_6(smethod_0().bool_3)) : ("Chỉ đánh siêu quái: " + GClass154.smethod_0().method_6(smethod_0().bool_3)), 0);
                    break;
                case "/dsqskillclr":
                    list_2.Clear();
                    GClass149.smethod_1((GClass151.int_0 != 0) ? "List skill murdering set to default" : "Danh sách skill đồ sát quái đã được đặt về mặc định", 0);
                    break;
                case "/dsq":
                    smethod_0().bool_0 = !smethod_0().bool_0;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Murdering mob: " + GClass154.smethod_0().method_6(smethod_0().bool_0)) : ("Đồ sát quái: " + GClass154.smethod_0().method_6(smethod_0().bool_0)), 0);
                    break;
                case "/listmobclr":
                    list_0.Clear();
                    list_1.Clear();
                    GClass149.smethod_1((GClass151.int_0 == 0) ? "Danh sách quái đồ sát đã được đặt về mặc định" : "List mob murdering set to default", 0);
                    break;
                case "/nsq":
                    smethod_0().bool_4 = !smethod_0().bool_4;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Né siêu quái: " + GClass154.smethod_0().method_6(smethod_0().bool_4)) : ("Only attack normal mob: " + GClass154.smethod_0().method_6(smethod_0().bool_4)), 0);
                    break;
                case "/addmobt":
                    method_9("mob", "type", -1);
                    break;
                case "/pem1hit":
                    smethod_0().bool_1 = !smethod_0().bool_1;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đồ sát quái còn 1HP: " + GClass154.smethod_0().method_6(smethod_0().bool_1)) : ("Attack mob to 1 HP: " + GClass154.smethod_0().method_6(smethod_0().bool_1)), 0);
                    break;
                case "/additemt":
                    method_9("item", "type", -1);
                    break;
                case "/anhat":
                    smethod_0().bool_5 = !smethod_0().bool_5;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động nhặt item: " + GClass154.smethod_0().method_6(smethod_0().bool_5)) : ("Auto pickup item: " + GClass154.smethod_0().method_6(smethod_0().bool_5)), 0);
                    break;
                case "/addmob":
                    method_9("mob", "id", -1);
                    break;
                case "/abf":
                    if (int_3 == 0 && int_4 == 0)
                    {
                        GClass149.smethod_1((GClass151.int_0 != 0) ? "Auto use bean: Off" : "Tự động sử dụng đậu thần: Tắt", 0);
                        break;
                    }
                    int_3 = 20;
                    int_4 = 20;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? $"Tự động sử dụng đậu thần khi HP dưới {int_3}%, MP dưới {int_4}%" : $"Auto use bean when HP lower than {int_3}%, MP lower than {int_4}%", 0);
                    break;
                case "/itemme":
                    smethod_0().bool_6 = !smethod_0().bool_6;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Only pickup my item: " + GClass154.smethod_0().method_6(smethod_0().bool_6)) : ("Chỉ nhặt item của mình: " + GClass154.smethod_0().method_6(smethod_0().bool_6)), 0);
                    break;
                case "/dsqskill":
                    method_9("skill", "id", -1);
                    break;
                default:
                    if (!GClass154.smethod_0().method_11<int>(text, "/additem") || GClass154.smethod_0().method_12<string>(text, "/additem").Contains("drop"))
                    {
                        if (!GClass154.smethod_0().method_11<string>(text, "/additem") || GClass154.smethod_0().method_12<string>(text, "/additem").Contains("drop"))
                        {
                            if (GClass154.smethod_0().method_11<int>(text, "/addmob"))
                                method_9("mob", "id", GClass154.smethod_0().method_12<int>(text, "/addmob"));
                            else if (GClass154.smethod_0().method_11<string>(text, "/addmob"))
                            {
                                string[] array = GClass154.smethod_0().method_12<string>(text, "/addmob").Split(',');
                                for (int i = 0; i < array.Length; i++)
                                {
                                    method_9("mob", "id", int.Parse(array[i]));
                                }
                            }
                            else if (!GClass154.smethod_0().method_11<int>(text, "/additemt") || GClass154.smethod_0().method_12<string>(text, "/additemt").Contains("drop"))
                            {
                                if (GClass154.smethod_0().method_11<string>(text, "/additemt") && !GClass154.smethod_0().method_12<string>(text, "/additemt").Contains("drop"))
                                {
                                    string[] array2 = GClass154.smethod_0().method_12<string>(text, "/additemt").Split(',');
                                    for (int j = 0; j < array2.Length; j++)
                                    {
                                        method_9("item", "type", int.Parse(array2[j]));
                                    }
                                }
                                else if (!GClass154.smethod_0().method_11<int>(text, "/addmobt"))
                                {
                                    if (!GClass154.smethod_0().method_11<string>(text, "/addmobt"))
                                    {
                                        if (GClass154.smethod_0().method_11<int>(text, "/dsqskill"))
                                            method_9("skill", "id", GClass154.smethod_0().method_12<int>(text, "/dsqskill"));
                                        else if (GClass154.smethod_0().method_11<string>(text, "/dsqskill"))
                                        {
                                            string[] array3 = GClass154.smethod_0().method_12<string>(text, "/dsqskill").Split(',');
                                            for (int k = 0; k < array3.Length; k++)
                                            {
                                                method_9("skill", "id", int.Parse(array3[k]));
                                            }
                                        }
                                        else if (!GClass154.smethod_0().method_11<int>(text, "/sln"))
                                        {
                                            if (GClass154.smethod_0().method_11<short>(text, "/blockitem"))
                                            {
                                                short num = GClass154.smethod_0().method_12<short>(text, "/blockitem");
                                                if (list_4.Contains(num))
                                                {
                                                    list_4.Remove(num);
                                                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Xóa " + GClass0.smethod_1(num).string_0 + " khỏi d/s không nhặt item theo ID") : ("Deleted " + GClass0.smethod_1(num).string_0 + " from list don't pick up by ID"), 0);
                                                }
                                                else
                                                {
                                                    list_4.Add(num);
                                                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Added " + GClass0.smethod_1(num).string_0 + " to list don't pick up by ID") : ("Thêm " + GClass0.smethod_1(num).string_0 + " khỏi d/s không nhặt item theo ID"), 0);
                                                }
                                            }
                                            else if (GClass154.smethod_0().method_11<sbyte>(text, "/blockitemt"))
                                            {
                                                sbyte b = GClass154.smethod_0().method_12<sbyte>(text, "/blockitemt");
                                                if (list_6.Contains(b))
                                                {
                                                    list_6.Remove(b);
                                                    GClass149.smethod_1((GClass151.int_0 == 0) ? $"Xóa item [{b}] khỏi d/s không nhặt item theo loại" : $"Deleted [{b}] from list don't pick up by Type", 0);
                                                }
                                                else
                                                {
                                                    list_6.Add(b);
                                                    GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added [{b}] to list don't pick up by Type" : $"Thêm item [{b}] vào d/s không nhặt item theo loại", 0);
                                                }
                                            }
                                            else if (GClass154.smethod_0().method_11<int>(text, "/abf"))
                                            {
                                                int_3 = GClass154.smethod_0().method_12<int>(text, "/abf");
                                                int_4 = 0;
                                                GClass149.smethod_1((GClass151.int_0 == 0) ? $"Tự động sử dụng đậu thần khi HP dưới {int_3}%" : $"Auto use bean when HP lower than {int_3}%", 0);
                                            }
                                            else if (!GClass154.smethod_0().method_10<int>(text, "/abf", 2))
                                            {
                                                if (!GClass154.smethod_0().method_11<int>(text, "/mobhp"))
                                                    return false;
                                                int_1 = GClass154.smethod_0().method_12<int>(text, "/mobhp");
                                                GClass149.smethod_1((GClass151.int_0 != 0) ? ("Only attack mob lower than " + GClass65.smethod_9(int_1) + " HP") : ("Cài đặt chỉ đánh quái dưới " + GClass65.smethod_9(int_1) + " HP"), 0);
                                            }
                                            else
                                            {
                                                int[] array4 = GClass154.smethod_0().method_8<int>(text, "/abf", 2);
                                                int_3 = array4[0];
                                                int_4 = array4[1];
                                                GClass149.smethod_1((GClass151.int_0 != 0) ? $"Auto use bean when HP lower than {int_3}%, MP lower than {int_4}%" : $"Tự động sử dụng đậu thần khi HP dưới {int_3}%, MP dưới {int_4}%", 0);
                                            }
                                        }
                                        else
                                        {
                                            int_2 = GClass154.smethod_0().method_12<int>(text, "/sln");
                                            GClass149.smethod_1((GClass151.int_0 != 0) ? $"Limit time pick {int_2}" : $"Giới hạn số lần nhặt {int_2}", 0);
                                        }
                                    }
                                    else
                                    {
                                        string[] array5 = GClass154.smethod_0().method_12<string>(text, "/addmobt").Split(',');
                                        for (int l = 0; l < array5.Length; l++)
                                        {
                                            method_9("mob", "type", int.Parse(array5[l]));
                                        }
                                    }
                                }
                                else
                                {
                                    method_9("mob", "type", GClass154.smethod_0().method_12<int>(text, "/addmobt"));
                                }
                            }
                            else
                            {
                                method_9("item", "type", GClass154.smethod_0().method_12<int>(text, "/additemt"));
                            }
                        }
                        else
                        {
                            string[] array6 = GClass154.smethod_0().method_12<string>(text, "/additem").Split(',');
                            for (int m = 0; m < array6.Length; m++)
                            {
                                method_9("item", "id", int.Parse(array6[m]));
                            }
                        }
                    }
                    else
                        method_9("item", "id", GClass154.smethod_0().method_12<int>(text, "/additem"));
                    break;
                case "/additem":
                    method_9("item", "id", -1);
                    break;
            }
            return true;
        }

        public bool method_6(GClass64 itemMap)
		{
			return itemMap.gclass117_0.short_0 == 76 || itemMap.gclass117_0.short_0 == 188 || itemMap.gclass117_0.short_0 == 189 || itemMap.gclass117_0.short_0 == 190;
		}

		public void method_7()
		{
			if (GClass20.int_37 != 126 && !GClass159.smethod_0().method_50())
				return;
			for (int i = 0; i < GClass144.gclass88_6.method_2(); i++)
			{
				if (GClass144.gclass88_6.method_3(i) is GClass64 itemMap && method_6(itemMap))
					GClass144.gclass88_6.method_7(i);
			}
		}

		public void method_8()
		{
			method_7();
			if (!GClass148.smethod_0().bool_0)
				method_12();
		}

		public void method_9(string obj, string type, int index)
		{
			if (type == "id")
			{
				switch (obj)
				{
				case "item":
					if (index != -1)
					{
						if (list_3.Contains((short)index))
						{
							list_3.Remove((short)index);
							GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đã xóa item [" + GClass0.smethod_1((short)index).string_0 + "]") : ("Deleted item [" + GClass0.smethod_1((short)index).string_0 + "]"), 0);
						}
						else
						{
							list_3.Add((short)index);
							GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đã thêm item [" + GClass0.smethod_1((short)index).string_0 + "]") : ("Added item [" + GClass0.smethod_1((short)index).string_0 + "]"), 0);
						}
					}
					else if (GClass78.smethod_1().gclass64_0 != null)
					{
						GClass64 gclass64_ = GClass78.smethod_1().gclass64_0;
						if (list_3.Contains(gclass64_.gclass117_0.short_0))
						{
							list_3.Remove(gclass64_.gclass117_0.short_0);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa item [{gclass64_.gclass117_0.short_0}]" : $"Deleted item [{gclass64_.gclass117_0.short_0}]", 0);
						}
						else
						{
							list_3.Add(gclass64_.gclass117_0.short_0);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã thêm item [{gclass64_.gclass117_0.short_0}]" : $"Added item [{gclass64_.gclass117_0.short_0}]", 0);
						}
					}
					break;
				case "skill":
					if (index != -1)
					{
						GClass47 gClass = GClass78.smethod_1().gclass176_0.gclass47_0[index - 1];
						if (!list_2.Contains(gClass.sbyte_0))
						{
							list_2.Add(gClass.sbyte_0);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã thêm skill {gClass.string_0}[{gClass.sbyte_0}]" : $"Added skill {gClass.string_0}[{gClass.sbyte_0}]", 0);
						}
						else
						{
							list_2.Remove(gClass.sbyte_0);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa skill {gClass.string_0}[{gClass.sbyte_0}]" : $"Deleted skill {gClass.string_0}[{gClass.sbyte_0}]", 0);
						}
					}
					else if (GClass78.smethod_1().gclass63_0 != null)
					{
						GClass47 gclass47_ = GClass78.smethod_1().gclass63_0.gclass47_0;
						if (!list_2.Contains(gclass47_.sbyte_0))
						{
							list_2.Add(gclass47_.sbyte_0);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã thêm skill {gclass47_.string_0}[{gclass47_.sbyte_0}]" : $"Added skill {gclass47_.string_0}[{gclass47_.sbyte_0}]", 0);
						}
						else
						{
							list_2.Remove(gclass47_.sbyte_0);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Deleted skill {gclass47_.string_0}[{gclass47_.sbyte_0}]" : $"Đã xóa skill {gclass47_.string_0}[{gclass47_.sbyte_0}]", 0);
						}
					}
					break;
				case "mob":
					if (index != -1)
					{
						if (list_0.Contains(index))
						{
							list_0.Remove(index);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Deleted position {index}" : $"Đã xóa vị trí {index}", 0);
						}
						else
						{
							list_0.Add(index);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã thêm vị trí {index}" : $"Added position {index}", 0);
						}
					}
					else if (GClass78.smethod_1().gclass194_0 != null)
					{
						GClass194 gclass194_ = GClass78.smethod_1().gclass194_0;
						if (list_0.Contains(gclass194_.int_25))
						{
							list_0.Remove(gclass194_.int_25);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa vị trí {gclass194_.int_25}" : $"Deleted mob position {gclass194_.int_25}", 0);
						}
						else
						{
							list_0.Add(gclass194_.int_25);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added mob position {gclass194_.int_25}" : $"Đã thêm vị trí {gclass194_.int_25}", 0);
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
							GClass149.smethod_1((GClass151.int_0 != 0) ? ("Deleted type-mob [" + GClass194.gclass177_0[index].string_0 + "]") : ("Đã xóa loại quái [" + GClass194.gclass177_0[index].string_0 + "]"), 0);
						}
						else
						{
							list_1.Add(index);
							GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đã thêm loại quái [" + GClass194.gclass177_0[index].string_0 + "]") : ("Added type-mob [" + GClass194.gclass177_0[index].string_0 + "]"), 0);
						}
					}
					else if (GClass78.smethod_1().gclass194_0 != null)
					{
						GClass194 gclass194_2 = GClass78.smethod_1().gclass194_0;
						if (!list_1.Contains(gclass194_2.int_26))
						{
							list_1.Add(gclass194_2.int_26);
							GClass149.smethod_1((GClass151.int_0 != 0) ? ("Added type-mob [" + gclass194_2.method_16().string_0 + "]") : ("Đã thêm loại quái [" + gclass194_2.method_16().string_0 + "]"), 0);
						}
						else
						{
							list_1.Remove(gclass194_2.int_26);
							GClass149.smethod_1((GClass151.int_0 != 0) ? ("Deleted type-mob [" + gclass194_2.method_16().string_0 + "]") : ("Đã xóa loại quái [" + gclass194_2.method_16().string_0 + "]"), 0);
						}
					}
				}
				else
				{
					if (!(obj == "item"))
						return;
					if (index != -1)
					{
						if (!list_5.Contains((sbyte)index))
						{
							list_5.Add((sbyte)index);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added item {GClass0.smethod_1((short)index).string_0}[{index}]" : $"Đã thêm item {GClass0.smethod_1((short)index).string_0}[{index}]", 0);
						}
						else
						{
							list_5.Remove((sbyte)index);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Deleted item {GClass0.smethod_1((short)index).string_0}[{index}]" : $"Đã xóa item {GClass0.smethod_1((short)index).string_0}[{index}]", 0);
						}
					}
					else if (GClass78.smethod_1().gclass64_0 != null)
					{
						GClass64 gclass64_2 = GClass78.smethod_1().gclass64_0;
						if (list_5.Contains(gclass64_2.gclass117_0.sbyte_0))
						{
							list_5.Remove(gclass64_2.gclass117_0.sbyte_0);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Deleted item {gclass64_2.gclass117_0.string_0}[{gclass64_2.gclass117_0.sbyte_0}]" : $"Đã xóa item {gclass64_2.gclass117_0.string_0}[{gclass64_2.gclass117_0.sbyte_0}]", 0);
						}
						else
						{
							list_5.Add(gclass64_2.gclass117_0.sbyte_0);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã thêm item {gclass64_2.gclass117_0.string_0}[{gclass64_2.gclass117_0.sbyte_0}]" : $"Added item {gclass64_2.gclass117_0.string_0}[{gclass64_2.gclass117_0.sbyte_0}]", 0);
						}
					}
				}
			}
		}

		public void method_10(object obj)
		{
			GClass194 gClass = (GClass194)obj;
			if (gClass.int_12 != 1 && gClass.int_12 != 0)
			{
				gClass.long_0 = GClass203.smethod_18();
				gClass.int_0++;
				if (gClass.int_0 > 10 && !GClass159.smethod_0().method_50())
					gClass.int_0 = 0;
			}
		}

		public void method_11(GClass194 mob)
		{
			if (mob.sbyte_14 != 0 && !GClass159.smethod_0().method_50())
				mob.int_0 = 0;
		}

		public static void smethod_1(int time)
		{
			bool_9 = true;
			long_0 = GClass203.smethod_18();
			long_1 = time;
		}

		public static bool smethod_2()
		{
			if (bool_9 && GClass203.smethod_18() - long_0 >= long_1)
				bool_9 = false;
			return bool_9;
		}

		public void method_12()
		{
			if ((GClass160.smethod_0().bool_6 && !GClass160.smethod_0().bool_7) || (GClass160.smethod_0().bool_8 && !GClass160.smethod_0().bool_9) || (GClass160.smethod_0().bool_3 && GClass160.smethod_0().method_22() > 0 && GClass144.smethod_8().method_16()))
				return;
			if (GClass164.smethod_0().bool_2)
			{
				for (int i = 0; i < GClass144.gclass63_0.Length; i++)
				{
					GClass63 gClass = GClass144.gclass63_0[i];
					if (gClass != null && gClass.gclass47_0.sbyte_0.Equals(GClass164.smethod_0().int_0[GClass78.smethod_1().int_14]) && GClass203.smethod_18() - gClass.long_1 > gClass.int_1 + 500)
						return;
				}
			}
			try
			{
				if (smethod_2())
					return;
				GClass78 gClass2 = GClass78.smethod_1();
				if (gClass2.int_11 == 14 || gClass2.int_25 <= 0)
					return;
				if (((gClass2.int_25 <= gClass2.int_35 * int_3 / 100 && int_3 != 0) || (gClass2.int_24 <= gClass2.int_36 * int_4 / 100 && int_4 != 0)) && GClass203.smethod_18() - long_3 > 9000L)
				{
					GClass144.smethod_8().method_50();
					long_3 = GClass203.smethod_18();
				}
				bool flag;
				bool flag2 = (flag = GClass19.smethod_0(4387)) && bool_0;
				if (smethod_0().bool_5 && !flag2 && !GClass153.smethod_0().method_6())
				{
					if (GClass20.int_37 == GClass78.smethod_1().int_14 + 21 && GClass144.gclass88_6.method_2() > 0)
					{
						GClass7.smethod_0().method_74(-1);
						smethod_1(1000);
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
						GClass64 gClass3 = list_7[int_5];
						switch (method_14(gClass3))
						{
						case GEnum1.const_0:
							int_5++;
							return;
						case GEnum1.const_1:
							GClass7.smethod_0().method_44();
							GClass7.smethod_0().method_74(gClass3.int_9);
							gClass3.int_0++;
							smethod_1(500);
							int_5++;
							return;
						case GEnum1.const_2:
							gClass2.int_4 = gClass3.int_3;
							gClass2.int_5 = gClass3.int_4;
							GClass7.smethod_0().method_44();
							GClass7.smethod_0().method_74(gClass3.int_9);
							gClass3.int_0++;
							int_5++;
							smethod_1(100);
							return;
						case GEnum1.const_3:
							method_13(gClass3.int_3, gClass3.int_4);
							gClass2.gclass194_0 = null;
							gClass3.int_0++;
							smethod_1(500);
							return;
						}
					}
					list_7.Clear();
					int_5 = 0;
					for (int j = 0; j < GClass144.gclass88_6.method_2(); j++)
					{
						GClass64 gClass4 = (GClass64)GClass144.gclass88_6.method_3(j);
						if (method_14(gClass4) != 0)
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
				if (gClass2.gclass194_0 != null && !method_18(gClass2.gclass194_0))
					gClass2.gclass194_0 = null;
				if (gClass2.gclass194_0 == null)
				{
					gClass2.gclass194_0 = method_16();
					if (flag && gClass2.gclass194_0 != null)
					{
						GClass78.smethod_1().int_4 = gClass2.gclass194_0.int_16 - 24;
						GClass78.smethod_1().int_5 = gClass2.gclass194_0.int_17;
						GClass7.smethod_0().method_44();
					}
				}
				if (gClass2.gclass194_0 != null)
				{
					if (gClass2.method_75() == null)
					{
						GClass63 gClass5 = method_21();
						if (gClass5 != null && !gClass5.bool_0)
						{
							GClass194 gclass194_ = gClass2.gclass194_0;
							gclass194_.int_8 = gclass194_.int_16;
							gclass194_.int_9 = gclass194_.int_17;
							if (GClass78.smethod_1().gclass63_0 != gClass5 || GClass78.smethod_1().int_11 == 5 || GClass78.smethod_1().gclass63_0.gclass47_0.int_3 == 3 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 10 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 11 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 20)
								GClass144.smethod_8().method_62(gClass5, true);
							if (GClass159.smethod_0().bool_4)
							{
								if (GClass78.smethod_1().int_20 < 2000)
									GClass164.smethod_0().method_15();
								return;
							}
							bool flag3 = GClass50.smethod_24(gclass194_.int_16, gclass194_.int_17, gClass2.int_4, gClass2.int_5) > 48;
							bool flag4 = GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 20;
							if (flag3)
							{
								if (!flag4)
								{
									if (flag)
									{
										if (GClass203.smethod_18() - long_2 > 500L && GClass78.smethod_1().int_11 == 1)
										{
											GClass78.smethod_1().int_4 = gclass194_.int_16 - 24;
											GClass78.smethod_1().int_5 = gclass194_.int_17;
											GClass7.smethod_0().method_44();
											long_2 = GClass203.smethod_18();
										}
									}
									else
										method_13(gclass194_.int_16, gclass194_.int_17);
								}
								else
									GClass164.smethod_0().method_15();
								return;
							}
							if (smethod_0().bool_1 && gclass194_.int_6 <= 1)
								return;
							if (int_0 != 0)
							{
								GClass144.smethod_8().method_62(gClass5, true);
								if (GClass50.smethod_24(gclass194_.int_16, gclass194_.int_17, gClass2.int_4, gClass2.int_5) <= 48)
									GClass144.smethod_8().method_44(gclass194_);
								return;
							}
							if (GClass78.smethod_1().int_11 == 5 || GClass78.smethod_1().gclass63_0.gclass47_0.int_3 == 3 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 10 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 11)
								GClass144.smethod_8().method_64(gClass5);
							if (GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 != 20 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 20)
								GClass164.smethod_0().method_15();
						}
					}
				}
				else if (!flag)
				{
					GClass194 gClass6 = method_17();
					if (gClass6 != null)
						method_13(gClass6.int_16 - 24, gClass6.int_17);
				}
				smethod_1(100);
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/startMurderingMob.txt", ex.ToString());
			}
		}

		public void method_13(int x, int y)
		{
			GClass78 gClass = GClass78.smethod_1();
			if (!GClass157.smethod_0().bool_5)
			{
				gClass.gclass29_0 = new GClass29(x, y);
				return;
			}
			int[] array = method_26(gClass.int_4, x);
			if (array[1] >= y || (array[1] >= gClass.int_5 && (gClass.int_11 == 2 || gClass.int_11 == 1)))
			{
				array[0] = x;
				array[1] = y;
			}
			gClass.gclass29_0 = new GClass29(array[0], array[1]);
		}

		public GEnum1 method_14(GClass64 itemMap)
		{
			GClass78 gClass = GClass78.smethod_1();
			bool flag = itemMap.int_8 == gClass.int_13 || itemMap.int_8 == -1;
			if (smethod_0().bool_6 && !flag)
				return GEnum1.const_0;
			if (!smethod_0().bool_7 || itemMap.int_0 <= int_2)
			{
				if (!method_15(itemMap))
					return GEnum1.const_0;
				if (GClass50.smethod_28(gClass.int_4 - itemMap.int_3) >= 60 || GClass50.smethod_28(gClass.int_5 - itemMap.int_4) >= 60)
				{
					if (!GClass19.smethod_0(4387))
					{
						if (smethod_0().bool_0)
							return GEnum1.const_3;
						return GEnum1.const_0;
					}
					return GEnum1.const_2;
				}
				return GEnum1.const_1;
			}
			return GEnum1.const_0;
		}

		public bool method_15(GClass64 itemMap)
		{
			if (list_3.Count == 0 || list_3.Contains(itemMap.gclass117_0.short_0))
			{
				if (list_4.Count != 0 && list_4.Contains(itemMap.gclass117_0.short_0))
					return false;
				if (list_5.Count == 0 || list_5.Contains(itemMap.gclass117_0.sbyte_0))
				{
					if (list_6.Count != 0 && list_6.Contains(itemMap.gclass117_0.sbyte_0))
						return false;
					return true;
				}
				return false;
			}
			return false;
		}

		public GClass194 method_16()
		{
			GClass194 result = null;
			int num = int.MaxValue;
			GClass78 gClass = GClass78.smethod_1();
			for (int i = 0; i < GClass144.gclass88_9.method_2(); i++)
			{
				GClass194 gClass2 = (GClass194)GClass144.gclass88_9.method_3(i);
				int num2 = (gClass2.int_16 - gClass.int_4) * (gClass2.int_16 - gClass.int_4) + (gClass2.int_17 - gClass.int_5) * (gClass2.int_17 - gClass.int_5);
				if (method_18(gClass2) && num2 < num && smethod_0().int_1 == 0)
				{
					result = gClass2;
					num = num2;
				}
				else if (method_18(gClass2) && num2 < num && smethod_0().int_1 != 0 && smethod_0().int_1 >= gClass2.int_6)
				{
					result = gClass2;
					num = num2;
				}
			}
			return result;
		}

		public GClass194 method_17()
		{
			GClass194 result = null;
			long num = GClass203.smethod_18();
			for (int i = 0; i < GClass144.gclass88_9.method_2(); i++)
			{
				GClass194 gClass = (GClass194)GClass144.gclass88_9.method_3(i);
				if (method_19(gClass) && gClass.long_0 < num)
				{
					result = gClass;
					num = gClass.long_0;
				}
			}
			return result;
		}

		public bool method_18(GClass194 mob)
		{
			if (mob.int_12 == 0 || mob.int_12 == 1 || mob.int_6 <= 0 || mob.bool_13)
				return false;
			if (mob.sbyte_14 == 0 || !smethod_0().bool_4)
			{
				if (mob.sbyte_14 == 0 && smethod_0().bool_3)
					return false;
				if (method_20(mob))
				{
					if (smethod_0().int_1 == 0 || smethod_0().int_1 >= mob.int_6)
						return true;
					return false;
				}
				return false;
			}
			return false;
		}

		public bool method_19(GClass194 mob)
		{
			if (!mob.bool_13)
			{
				if (method_20(mob))
				{
					if (smethod_0().bool_4 && !GClass19.smethod_0(4387) && mob.method_16().int_0 >= 3000)
					{
						if (mob.sbyte_14 != 0)
						{
							GClass194 gClass = null;
							bool flag = false;
							for (int i = 0; i < GClass144.gclass88_9.method_2(); i++)
							{
								gClass = (GClass194)GClass144.gclass88_9.method_3(i);
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
			return false;
		}

		public bool method_20(GClass194 mob)
		{
			if (list_0.Count == 0 || list_0.Contains(mob.int_25))
			{
				if (list_1.Count == 0 || list_1.Contains(mob.int_26))
					return true;
				return false;
			}
			return false;
		}

		public GClass63 method_21()
		{
			if (GClass78.smethod_1().int_14 == 2)
			{
				list_2.Remove(0);
				list_2.Remove(2);
				list_2.Remove(17);
			}
			GClass63 gClass = null;
			GClass47 gClass2 = new GClass47();
			foreach (sbyte item in list_2)
			{
				gClass2.sbyte_0 = item;
				GClass63 gClass3 = GClass78.smethod_1().method_16(gClass2);
				if (method_22(gClass3, gClass))
					gClass = gClass3;
			}
			return gClass;
		}

		public bool method_22(GClass63 SkillBetter, GClass63 skill)
		{
			if (SkillBetter == null)
				return false;
			if (!method_23(SkillBetter))
				return false;
			bool flag = (SkillBetter.gclass47_0.sbyte_0 == 17 && skill.gclass47_0.sbyte_0 == 2) || (SkillBetter.gclass47_0.sbyte_0 == 9 && skill.gclass47_0.sbyte_0 == 0);
			if (skill != null && skill.int_1 >= SkillBetter.int_1 && !flag)
				return false;
			return true;
		}

		public bool method_23(GClass63 skill)
		{
			if (GClass203.smethod_18() - skill.long_1 > skill.int_1)
				skill.bool_0 = false;
			if (skill.bool_0 && !sbyte_1.Contains(skill.gclass47_0.sbyte_0))
				return false;
			if (!sbyte_2.Contains(skill.gclass47_0.sbyte_0))
			{
				if (GClass78.smethod_1().int_24 >= method_24(skill))
					return true;
				return false;
			}
			return false;
		}

		public int method_24(GClass63 skill)
		{
			if (skill.gclass47_0.int_2 != 2)
			{
				if (skill.gclass47_0.int_2 != 1)
					return skill.int_5;
				return skill.int_5 * GClass78.smethod_1().int_36 / 100;
			}
			return 1;
		}

		public int method_25(int xsd)
		{
			GClass78 gClass = GClass78.smethod_1();
			int num = GClass20.int_24;
			int result = -1;
			for (int i = 24; i < GClass20.int_24; i += 24)
			{
				if (GClass20.smethod_28(xsd, i, 2))
				{
					int num2 = GClass50.smethod_28(i - gClass.int_5);
					if (num2 < num)
					{
						num = num2;
						result = i;
					}
				}
			}
			return result;
		}

		public int[] method_26(int xStart, int xEnd)
		{
			int num = GClass20.int_24;
			int num2 = -1;
			if (xStart > xEnd)
			{
				for (int i = xEnd; i < xStart; i += 24)
				{
					int num3 = method_25(i);
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
					int num5 = method_25(num4);
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
