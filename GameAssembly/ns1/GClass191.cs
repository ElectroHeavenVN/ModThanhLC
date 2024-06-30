using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;
using UnityEngine;

namespace ns1
{
    public class GClass191 : GInterface0, GInterface5
	{
		public struct GStruct9
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public GStruct9(int headID, int bodyID, int legID)
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

		public static short short_0 = 454;

		public static short short_1 = 921;

		public bool bool_10;

		public int int_10;

		public static List<GClass59> list_3 = new List<GClass59>();

		public bool bool_11;

		public string string_0 = string.Empty;

		public long long_4;

		public long long_5;

		public bool bool_12;

		public int int_11 = 0;

		public long long_6;

		public long long_7;

		public string string_1 = string.Empty;

		private static GClass191 gclass191_0;

		public bool bool_13;

		public long long_8;

		public int[] int_12 = new int[4] { 10010100, 10453645, 14447611, 9928083 };

		public GStruct9 gstruct9_0 = default(GStruct9);

		public bool bool_14;

		public int int_13 = 8;

		public int int_14 = 0;

		public int int_15 = 0;

		public int int_16 = 5;

		public int int_17 = 25;

		public List<GClass58> list_4 = new List<GClass58>();

		public int int_18 = 3;

		public bool bool_15;

		public List<GClass58> list_7 = new List<GClass58>();

		public int int_19;

		public List<int> list_8 = new List<int>();

		public int int_20 = 0;

		public bool bool_16;

		public bool bool_17 = false;

		public long long_9;

		public List<GInterface4> List_0 {  get; set; } = new List<GInterface4>();

        public List<GInterface4> List_1 { get; set; } = new List<GInterface4>();

        public static GClass191 smethod_0()
		{
			return (gclass191_0 != null) ? gclass191_0 : (gclass191_0 = new GClass191());
		}

		private void method_0()
		{
			GClass7.smethod_0().string_1 = "Chat";
			GClass7.smethod_0().gclass67_0.string_7 = "chat";
			GClass7.smethod_0().bool_0 = false;
		}

		public void onCancelChat()
		{
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass7.smethod_0().gclass67_0.method_21() == null || GClass7.smethod_0().gclass67_0.method_21().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
				GClass7.smethod_0().bool_0 = false;
			else if (GClass7.smethod_0().string_1.Equals((GClass192.int_0 == 0) ? "Nhập % HP sử dụng bông tai" : "Fill % HP use porata"))
			{
				method_3($"/abt{int.Parse(GClass7.smethod_0().gclass67_0.method_21())}");
				method_0();
			}
			else if (GClass7.smethod_0().string_1.Equals((GClass192.int_0 == 0) ? "Nhập % KI sử dụng bông tai" : "Fill % KI use porata"))
			{
				method_3($"/abtki{int.Parse(GClass7.smethod_0().gclass67_0.method_21())}");
				method_0();
			}
			else if (GClass7.smethod_0().string_1.Equals((GClass192.int_0 == 0) ? "Nhập nội dung auto chat thế giới !" : "Fill auto global chat content!") && GClass7.smethod_0().gclass67_0.method_21() != string.Empty)
			{
				string_1 = GClass7.smethod_0().gclass67_0.method_21();
				bool_12 = true;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Auto chat thế giới: " + GClass193.smethod_0().method_6(bool_12)) : ("Auto global Chat: " + GClass193.smethod_0().method_6(bool_12)), 0);
				method_0();
			}
			method_0();
		}

		public void method_1(string text)
		{
			GClass7.smethod_0().string_1 = text;
			GClass7.smethod_0().gclass67_0.string_7 = mResources.CHAT;
			GClass39.gclass45_0.bool_0 = false;
			GClass7.smethod_0().method_5(smethod_0(), string.Empty);
		}

		public void perform(int idAction, object p)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			if (idAction <= 10248)
			{
				switch (idAction)
				{
				case 10002:
				{
					GClass63 gClass4 = new GClass63();
					gClass4.method_0(new GClass14((GClass192.int_0 == 0) ? ("Tự động\nđổi m.tiêu:\n" + GClass193.smethod_0().method_7(GClass189.smethod_0().bool_1)) : ("Auto change\nobject:\n" + GClass193.smethod_0().method_7(GClass189.smethod_0().bool_1)), this, 101301, null));
					for (int j = 0; j < GClass58.smethod_1().gclass121_0.Length; j++)
					{
						GClass121 gClass5 = GClass58.smethod_1().gclass121_0[j];
						if (gClass5 != null && (gClass5.gclass118_0.short_0 == short_0 || gClass5.gclass118_0.short_0 == short_1))
						{
							gClass4.method_0(new GClass14((GClass192.int_0 == 0) ? ("[HP]Auto Porata\n" + ((int_8 == 0) ? "Đang tắt" : $"{int_8}% HP\n{GClass193.smethod_0().method_7(int_8 != 0)}") + " ") : ("Auto Porata\n" + ((int_8 == 0) ? "Is Off" : $"{int_8}% HP\n{GClass193.smethod_0().method_7(int_8 != 0)}") + " "), this, 101302, null));
							gClass4.method_0(new GClass14((GClass192.int_0 == 0) ? ("[KI]Auto Porata\n" + ((int_9 == 0) ? "Đang tắt" : $"{int_9}% HP\n{GClass193.smethod_0().method_7(int_9 != 0)}") + " ") : ("Auto Porata\n" + ((int_9 == 0) ? "Is Off" : $"{int_9}% HP\n{GClass193.smethod_0().method_7(int_9 != 0)}") + " "), this, 101304, null));
						}
					}
					gClass4.method_0(new GClass14((GClass192.int_0 == 0) ? ("Tự động\nnhặt b.kíp\n" + GClass193.smethod_0().method_7(GClass197.list_3.Contains(590))) : ("Auto pick\nscrolls\n" + GClass193.smethod_0().method_7(GClass197.list_3.Contains(590))), this, 101303, null));
					GClass39.gclass0_0.method_2(gClass4, 0);
					return;
				}
				case 10005:
				{
					GClass63 gClass3 = new GClass63();
					gClass3.method_0(new GClass14((GClass192.int_0 == 0) ? ("H.thị d.s\nNhân vật:\n" + GClass193.smethod_0().method_7(bool_14)) : ("Show List\nCharacters:\n" + GClass193.smethod_0().method_7(bool_14)), this, 101601, null));
					gClass3.method_0(new GClass14((GClass192.int_0 == 0) ? ("C.độ h.thị\nD.s n.vật:\n" + ((int_18 == 1) ? "màu cờ" : ((int_18 == 2) ? "Bang hội" : "Mặc định"))) : ("Mode Show\nList Chars:\n" + ((int_18 == 1) ? "Flag Color" : ((int_18 == 2) ? "Clan Name" : "Default"))), this, 101602, null));
					gClass3.method_0(new GClass14((GClass192.int_0 == 0) ? ("Thông tin\nđối tượng:\n" + GClass193.smethod_0().method_7(GClass185.smethod_0().bool_0)) : ("Object Focus\nInformations:\n" + GClass193.smethod_0().method_7(GClass185.smethod_0().bool_0)), this, 101603, null));
					gClass3.method_0(new GClass14((GClass192.int_0 == 0) ? ("Tự động\nhồi sinh:\n" + GClass193.smethod_0().method_7(bool_8)) : ("Auto Revive:\n" + GClass193.smethod_0().method_7(bool_8)), this, 101604, null));
					if (GClass192.bool_3)
						gClass3.method_0(new GClass14((GClass192.int_0 == 0) ? ("Ghim v.NRSĐ,\nNgười ôm:\n" + GClass193.smethod_0().method_7(GClass177.smethod_0().bool_7)) : ("Follow B.Star\nD.Ball/Char:\n" + GClass193.smethod_0().method_7(GClass177.smethod_0().bool_7)), this, 101605, null));
					GClass39.gclass0_0.method_2(gClass3, 0);
					return;
				}
				case 10007:
				{
					GClass63 gClass = new GClass63();
					gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Tự động\nmở DTDN:\n" + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_4)) : ("Auto open\nOneE.Dungeon:\n" + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_4)), this, 101802, null));
					if (GClass192.int_0 == 0)
						gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Bộ gõ\ntiếng Việt:\n" + GClass193.smethod_0().method_7(GClass193.GClass194.smethod_0().bool_0)) : ("VietKey:\n" + GClass193.smethod_0().method_7(GClass193.GClass194.smethod_0().bool_0)), this, 101803, null));
					gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Auto bán\nđồ rác:\n" + GClass193.smethod_0().method_7(GClass183.smethod_0().bool_3)) : ("Auto sale\ntrash item:\n" + GClass193.smethod_0().method_7(GClass183.smethod_0().bool_3)), this, 101804, null));
					for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
					{
						GClass121 gClass2 = GClass58.smethod_1().gclass121_0[i];
						if (gClass2 != null && (gClass2.gclass118_0.short_0 == short_0 || gClass2.gclass118_0.short_0 == short_1))
							gClass.method_0(new GClass14((GClass192.int_0 == 0) ? ("Hợp thể\nsau login:\n" + GClass193.smethod_0().method_7(smethod_0().bool_16)) : ("Fusion after\nlogin:\n" + GClass193.smethod_0().method_7(smethod_0().bool_16)), this, 101805, null));
					}
					GClass39.gclass0_0.method_2(gClass, 0);
					return;
				}
				case 10008:
					Class14.smethod_0().method_3();
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
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đồ sát đệ tử: " + GClass193.smethod_0().method_6(smethod_0().bool_6)) : ("Murdering Disciple: " + GClass193.smethod_0().method_6(smethod_0().bool_6)), 0);
					break;
				case 10241:
					smethod_0().bool_7 = !smethod_0().bool_7;
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đồ sát theo clan: " + GClass193.smethod_0().method_6(smethod_0().bool_7)) : ("Murdering clan: " + GClass193.smethod_0().method_6(smethod_0().bool_7)), 0);
					break;
				case 10242:
					smethod_0().int_6 = ((smethod_0().int_6 == 0) ? (-1) : 0);
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đồ sát trái đất: " + GClass193.smethod_0().method_6(smethod_0().int_6 == 0)) : ("Murdering Earth: " + GClass193.smethod_0().method_6(smethod_0().int_6 == 0)), 0);
					break;
				case 10243:
					smethod_0().int_6 = ((smethod_0().int_6 != 1) ? 1 : (-1));
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đồ sát namek: " + GClass193.smethod_0().method_6(smethod_0().int_6 == 1)) : ("Murdering Namekian: " + GClass193.smethod_0().method_6(smethod_0().int_6 == 1)), 0);
					break;
				case 10244:
					smethod_0().int_6 = ((smethod_0().int_6 != 2) ? 2 : (-1));
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đồ sát xayda: " + GClass193.smethod_0().method_6(smethod_0().int_6 == 2)) : ("Murdering Saiyan: " + GClass193.smethod_0().method_6(smethod_0().int_6 == 2)), 0);
					break;
				case 10245:
					smethod_0().bool_5 = !smethod_0().bool_5;
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Đồ sát người: " + GClass193.smethod_0().method_6(smethod_0().bool_5)) : ("Murdering character: " + GClass193.smethod_0().method_6(smethod_0().bool_5)), 0);
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
				return;
			}
			switch (idAction)
			{
			case 101301:
				GClass166.smethod_0().method_78("/cobj");
				return;
			case 101302:
				smethod_0().method_1((GClass192.int_0 == 0) ? "Nhập % HP sử dụng bông tai" : "Fill % HP use porata");
				return;
			case 101303:
				GClass197.smethod_0().method_7("item", "id", 590);
				GClass197.smethod_0().method_7("item", "id", 74);
				return;
			case 101304:
				smethod_0().method_1((GClass192.int_0 == 0) ? "Nhập % KI sử dụng bông tai" : "Fill % KI use porata");
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
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Danh sách nhân vật sắp xếp theo: " + ((int_18 == 1) ? "màu cờ" : ((int_18 == 2) ? "Tên bang hội" : "Mặc định"))) : ("List Character sorted by: " + ((int_18 == 1) ? "flag color" : ((int_18 == 2) ? "clan name" : "default"))), 1);
				return;
			case 101603:
				method_3("/oinf");
				return;
			case 101604:
				method_3("/ahs");
				return;
			case 101605:
				GClass177.smethod_0().bool_7 = !GClass177.smethod_0().bool_7;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động ghim người có NRĐ/Viên NRĐ: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_7)) : ("Auto follow char have DragonBall/BlackStarDragonBall: " + GClass193.smethod_0().method_6(GClass177.smethod_0().bool_7)), 0);
				return;
			}
			switch (idAction)
			{
			case 101802:
				GClass175.smethod_0().bool_4 = !GClass175.smethod_0().bool_4;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động mở DTĐN: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_4)) : ("Auto open one eye dungeon: " + GClass193.smethod_0().method_7(GClass175.smethod_0().bool_4)), 0);
				break;
			case 101803:
				GClass193.GClass194.smethod_0().bool_0 = !GClass193.GClass194.smethod_0().bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Unicode: " + GClass193.smethod_0().method_7(GClass193.GClass194.smethod_0().bool_0)) : ("Vietkey: " + GClass193.smethod_0().method_7(GClass193.GClass194.smethod_0().bool_0)), 0);
				break;
			case 101804:
				GClass166.smethod_0().method_78("/isell");
				break;
			case 101805:
				smethod_0().bool_16 = !smethod_0().bool_16;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động hợp thể sau khi login: " + GClass193.smethod_0().method_7(smethod_0().bool_16)) : ("Auto fusion after login: " + GClass193.smethod_0().method_7(smethod_0().bool_16)), 0);
				break;
			}
		}

		public bool method_2(int asciiCode)
		{
			if (asciiCode <= 93)
			{
				if (asciiCode <= 61)
				{
					switch (asciiCode)
					{
					case 44:
						goto IL_007e;
					case 46:
						goto IL_0092;
					case 47:
						goto IL_00a6;
					case 45:
						goto IL_07a1;
					}
					if (asciiCode != 61)
						goto IL_07a1;
					GClass29.smethod_1().method_35();
					GClass58.smethod_1().gclass136_0 = null;
					GClass39.smethod_49();
					GClass39.gclass45_1 = new GClass45();
					GClass39.gclass45_1.method_50();
					GClass39.gclass45_0.method_34();
					GClass39.gclass45_0.method_50();
				}
				else if (asciiCode != 91)
				{
					if (asciiCode != 93)
						goto IL_07a1;
					if (GClass175.smethod_0().int_0 != -1)
					{
						if (GClass175.smethod_0().int_0 < GClass154.smethod_8().int_61.Length - 1)
							GClass166.smethod_0().method_78($"/kz{GClass1.int_39 + 1}");
						else
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Khu lớn nhất là [{GClass154.smethod_8().int_61.Length - 1}]" : $"Maximum zone is [{GClass154.smethod_8().int_61.Length - 1}]", 0);
					}
					else
						GClass166.smethod_0().method_78($"/kz{((GClass1.int_39 == 0) ? GClass1.int_39 : (GClass1.int_39 + 1))}");
				}
				else if (GClass175.smethod_0().int_0 != -1)
				{
					if (GClass175.smethod_0().int_0 > 0)
						GClass166.smethod_0().method_78($"/kz{GClass1.int_39 - 1}");
					else
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Khu bé nhất là [0]" : "Minimum zone is [0]", 0);
				}
				else
				{
					GClass166.smethod_0().method_78($"/kz{((GClass1.int_39 == 0) ? GClass1.int_39 : (GClass1.int_39 - 1))}");
				}
			}
			else if (asciiCode <= 109)
			{
				switch (asciiCode)
				{
				case 98:
					goto IL_0404;
				case 102:
					goto IL_0415;
				case 103:
					goto IL_04a0;
				case 104:
					goto IL_04f0;
				case 105:
					goto IL_0556;
				case 99:
				case 100:
				case 101:
					goto IL_07a1;
				}
				if (asciiCode != 109)
					goto IL_07a1;
				GClass63 gClass = new GClass63();
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nTrain quái" : "Function\nTrain mob", GClass197.smethod_0(), 10000, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\n Săn Boss" : "Function\nBoss", GClass189.smethod_0(), 10001, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nUp Bí kíp\nYardart" : "Function\nSupport\nYardart", smethod_0(), 10002, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nHỗ trợ\nUp Đệ tử" : "Function\nSupport\nDisciple", GClass195.smethod_0(), 10003, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nSkill" : "Function\nSkill", GClass196.smethod_0(), 10004, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nHỗ trợ\nPK/NRSĐ" : "Function\nSupport\nPK/BSDB", smethod_0(), 10005, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nMap" : "Function\nMap", GClass175.smethod_0(), 10006, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nkhác..." : "Another\nFunction...", smethod_0(), 10007, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Chức năng\nNextMap" : "AutoNextmap\nFunction...", smethod_0(), 10008, null));
				GClass39.gclass0_0.method_2(gClass, 0);
			}
			else if (asciiCode != 113)
			{
				switch (asciiCode)
				{
				case 118:
					break;
				case 119:
					goto IL_0763;
				default:
					goto IL_07a1;
				case 122:
					goto IL_07a9;
				}
				GClass58 gClass2 = GClass58.smethod_1();
				if (gClass2.gclass58_0 != null)
				{
					gClass2.int_4 = gClass2.gclass58_0.int_4;
					gClass2.int_5 = gClass2.gclass58_0.int_5;
					GClass166.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass58_0.int_4;
					gClass2.int_5 = gClass2.gclass58_0.int_5 + 1;
					GClass166.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass58_0.int_4;
					gClass2.int_5 = gClass2.gclass58_0.int_5;
					GClass166.smethod_0().method_44();
				}
				else if (gClass2.gclass85_0 != null)
				{
					gClass2.int_4 = gClass2.gclass85_0.int_8 - 24;
					gClass2.int_5 = gClass2.gclass85_0.int_9;
					GClass166.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass85_0.int_8;
					gClass2.int_5 = gClass2.gclass85_0.int_9;
					GClass166.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass85_0.int_8 - 24;
					gClass2.int_5 = gClass2.gclass85_0.int_9;
					GClass166.smethod_0().method_44();
				}
				else if (gClass2.gclass59_0 != null)
				{
					gClass2.int_4 = gClass2.gclass59_0.int_4;
					gClass2.int_5 = gClass2.gclass59_0.int_5 - 3;
					GClass166.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass59_0.int_4;
					gClass2.int_5 = gClass2.gclass59_0.int_5;
					GClass166.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass59_0.int_4;
					gClass2.int_5 = gClass2.gclass59_0.int_5 - 3;
					GClass166.smethod_0().method_44();
				}
			}
			else
			{
				if (GClass174.smethod_0().bool_0)
				{
					GClass174.smethod_0().method_2(new vMessage
					{
						cmd = 3,
						data = Encoding.ASCII.GetBytes(GClass174.string_0)
					});
					GClass174.smethod_0().bool_2 = false;
					GClass174.smethod_0().bool_0 = false;
				}
				else
				{
					GClass174.smethod_0().method_0(GClass199.int_0);
					GClass174.smethod_0().bool_0 = true;
				}
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Liên kết với QLTK: " + GClass193.smethod_0().method_6(GClass174.smethod_0().bool_0)) : ("Connect to game mannager: " + GClass193.smethod_0().method_6(GClass174.smethod_0().bool_0)), 0);
			}
			goto IL_088a;
			IL_0556:
			method_20(-1);
			goto IL_088a;
			IL_0415:
			if (GClass58.smethod_1().bool_38)
			{
				for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
				{
					GClass121 gClass3 = GClass58.smethod_1().gclass121_0[i];
					if (gClass3 != null && (gClass3.gclass118_0.short_0 == 454 || gClass3.gclass118_0.short_0 == 921))
						GClass166.smethod_0().method_20(0, 1, -1, gClass3.gclass118_0.short_0);
				}
			}
			goto IL_088a;
			IL_0092:
			GClass166.smethod_0().method_78("/hide");
			goto IL_088a;
			IL_04f0:
			for (int j = 0; j < GClass58.smethod_1().gclass121_0.Length; j++)
			{
				GClass121 gClass4 = GClass58.smethod_1().gclass121_0[j];
				if (gClass4 != null && gClass4.gclass118_0.short_0 == 521)
					GClass166.smethod_0().method_20(0, 1, -1, gClass4.gclass118_0.short_0);
			}
			goto IL_088a;
			IL_00a6:
			GClass7.smethod_0().method_3(47, GClass154.smethod_8(), string.Empty);
			goto IL_088a;
			IL_04a0:
			if (!GClass177.smethod_0().method_5())
				GClass166.smethod_0().method_6(0, GClass58.smethod_1().gclass58_0.int_13, -1, -1);
			else
			{
				GClass197.smethod_0().bool_5 = false;
				GClass166.smethod_0().method_42(GClass1.int_39, -1);
			}
			goto IL_088a;
			IL_07a9:
			GClass39.gclass45_1 = new GClass45();
			GClass39.gclass45_1.method_50();
			GClass39.gclass45_0.method_41();
			GClass39.gclass45_0.method_50();
			goto IL_088a;
			IL_0404:
			GClass166.smethod_0().method_13(0, -1);
			goto IL_088a;
			IL_0763:
			if (method_47())
				new Thread((ThreadStart)delegate
				{
					method_43();
				}).Start();
			else
				new Thread((ThreadStart)delegate
				{
					method_45();
				}).Start();
			goto IL_088a;
			IL_07a1:
			return false;
			IL_007e:
			GClass166.smethod_0().method_78("/optm");
			goto IL_088a;
			IL_088a:
			return true;
		}

		public bool method_3(string text)
		{
			switch (text)
			{
			case "/alg":
				GClass199.smethod_0().bool_0 = !GClass199.smethod_0().bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động Login: " + GClass193.smethod_0().method_6(GClass199.smethod_0().bool_0)) : ("Auto Login: " + GClass193.smethod_0().method_6(GClass199.smethod_0().bool_0)), 0);
				goto IL_0e51;
			case "/ahs":
				smethod_0().bool_8 = !smethod_0().bool_8;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động dùng ngọc hồi sinh: " + GClass193.smethod_0().method_6(smethod_0().bool_8)) : ("Auto revive: " + GClass193.smethod_0().method_6(smethod_0().bool_8)), 0);
				goto IL_0e51;
			case "/dsn":
				method_13();
				goto IL_0e51;
			case "/kmt":
				method_20(-1);
				goto IL_0e51;
			case "/cadd":
				method_12("char_id", -1);
				goto IL_0e51;
			case "/actg":
				if (bool_12)
				{
					bool_12 = false;
					string_1 = string.Empty;
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Auto chat thế giới: " + GClass193.smethod_0().method_6(bool_12)) : ("Auto global Chat: " + GClass193.smethod_0().method_6(bool_12)), 0);
				}
				else
					method_1((GClass192.int_0 == 0) ? "Nhập nội dung auto chat thế giới !" : "Fill auto global chat content!");
				goto IL_0e51;
			case "/hdsd":
				Class15.smethod_0().method_5();
				goto IL_0e51;
			case "/autosk":
				bool_13 = !bool_13;
				goto IL_0e51;
			case "/unikey":
				GClass193.GClass194.smethod_0().bool_0 = !GClass193.GClass194.smethod_0().bool_0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Unicode: " + GClass193.smethod_0().method_6(GClass193.GClass194.smethod_0().bool_0)) : ("Vietkey: " + GClass193.smethod_0().method_6(GClass193.GClass194.smethod_0().bool_0)), 0);
				goto IL_0e51;
			case "/achat_":
				bool_11 = false;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Auto chat: " + GClass193.smethod_0().method_6(bool_11)) : ("Auto chat: " + GClass193.smethod_0().method_6(bool_11)), 0);
				goto IL_0e51;
			case "/afriend":
				if (GClass58.smethod_1().gclass58_0 != null)
					GClass166.smethod_0().method_13(1, GClass58.smethod_1().gclass58_0.int_13);
				goto IL_0e51;
			case "/showlog":
				if (GClass192.string_2.Contains("1C07AFE652D939F16E9D5E0A6ACFE6FD") || GClass192.string_2.Contains("21232F297A57A5A743894A0E4A801FC3"))
				{
					bool_0 = !bool_0;
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Auto write log thế giới: " + GClass193.smethod_0().method_6(bool_0)) : ("Auto write log global: " + GClass193.smethod_0().method_6(bool_0)), 0);
				}
				goto IL_0e51;
			case "/cignore":
				method_12("block_id", -1);
				goto IL_0e51;
			case "/clanadd":
				method_12("clan_id", -1);
				goto IL_0e51;
			default:
				{
					if (GClass193.smethod_0().method_10<int>(text, "/cadd"))
						method_12("char_id", GClass193.smethod_0().method_11<int>(text, "/cadd"));
					else if (GClass193.smethod_0().method_10<int>(text, "/charhp"))
					{
						int_1 = GClass193.smethod_0().method_11<int>(text, "/charhp");
						GClass188.smethod_1((GClass192.int_0 != 0) ? ((int_1 == 0) ? "Turn off limited Character HP" : (("Only attack character have HP lower than " + GClass95.smethod_9(int_1) + " HP") ?? "")) : ((int_1 == 0) ? "Tắt giới hạn HP người" : (("Chỉ đánh người dưới " + GClass95.smethod_9(int_1) + " HP") ?? "")), 0);
					}
					if (GClass193.smethod_0().method_10<short>(text, "/txt"))
						GClass166.smethod_0().method_143(GClass58.smethod_1().gclass58_0.int_13, GClass193.smethod_0().method_11<short>(text, "/txt"));
					else if (GClass193.smethod_0().method_10<int>(text, "/tele"))
					{
						int_5 = GClass193.smethod_0().method_11<int>(text, "/tele");
						bool_4 = ((int_5 != -1) ? true : false);
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/cignore"))
					{
						method_12("block_id", GClass193.smethod_0().method_11<int>(text, "/cadd"));
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/afriend"))
					{
						GClass166.smethod_0().method_13(1, GClass193.smethod_0().method_11<int>(text, "/afriend"));
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/clanadd"))
					{
						method_12("clan_id", GClass193.smethod_0().method_11<int>(text, "/cadd"));
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/kmt"))
					{
						method_20(GClass193.smethod_0().method_11<int>(text, "/kmt"));
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/rspeed"))
					{
						int_0 = GClass193.smethod_0().method_11<int>(text, "/rspeed");
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tốc độ chạy {int_0}" : $"Run speed {int_0}", 0);
					}
					else if (GClass193.smethod_0().method_10<float>(text, "/gspeed"))
					{
						if (GClass193.smethod_0().method_11<float>(text, "/gspeed") == 0f)
							GClass188.smethod_1((GClass192.int_0 == 0) ? "Tốc độ game không thể bằng 0" : "Game speed can not equal to 0", 0);
						else
						{
							Time.timeScale = GClass193.smethod_0().method_11<float>(text, "/gspeed");
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tốc độ game {Time.timeScale}" : $"Game speed {Time.timeScale}", 0);
						}
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/r"))
					{
						GClass58.smethod_1().int_4 += GClass193.smethod_0().method_11<int>(text, "/r");
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Dịch sang phải" : "Go to right", 0);
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/l"))
					{
						GClass58.smethod_1().int_4 -= GClass193.smethod_0().method_11<int>(text, "/l");
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Dịch sang trái" : "Go to left", 0);
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/u"))
					{
						GClass58.smethod_1().int_5 -= GClass193.smethod_0().method_11<int>(text, "/u");
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Dịch lên trên" : "Go up", 0);
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/d"))
					{
						GClass58.smethod_1().int_5 += GClass193.smethod_0().method_11<int>(text, "/d");
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Dịch xuống dưới" : "Go down", 0);
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/hp"))
					{
						int_7[0] = GClass193.smethod_0().method_11<int>(text, "/hp");
						bool_9 = true;
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/mp"))
					{
						int_7[1] = GClass193.smethod_0().method_11<int>(text, "/mp");
						bool_9 = true;
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/dmg"))
					{
						int_7[2] = GClass193.smethod_0().method_11<int>(text, "/dmg");
						bool_9 = true;
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/abt"))
					{
						if (GClass193.smethod_0().method_11<int>(text, "/abt") > 0)
						{
							int_8 = GClass193.smethod_0().method_11<int>(text, "/abt");
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động dùng bông tai khi dưới [{int_8}%] HP!" : $"Auto use porata when HP lower than [{int_8}%] HP!", 0);
						}
						else
						{
							int_8 = GClass193.smethod_0().method_11<int>(text, "/abt");
							GClass188.smethod_1((GClass192.int_0 == 0) ? "Tắt tự động dùng bông tai theo % HP" : "Turn off auto use porata by percent HP", 0);
						}
					}
					else if (GClass193.smethod_0().method_10<int>(text, "/abtki"))
					{
						if (GClass193.smethod_0().method_11<int>(text, "/abtki") > 0)
						{
							int_9 = GClass193.smethod_0().method_11<int>(text, "/abtki");
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động dùng bông tai khi dưới [{int_9}%] KI!" : $"Auto use porata when KI lower than [{int_9}%] KI!", 0);
						}
						else
						{
							int_9 = GClass193.smethod_0().method_11<int>(text, "/abtki");
							GClass188.smethod_1((GClass192.int_0 == 0) ? "Tắt tự động dùng bông tai theo % KI" : "Turn off auto use porata by percent KI", 0);
						}
					}
					else
					{
						if (!GClass193.smethod_0().method_10<string>(text, "/achat_"))
							return false;
						string_0 = GClass193.smethod_0().method_11<string>(text, "/achat_");
						if (string_0 == "")
							GClass188.smethod_1((GClass192.int_0 == 0) ? ("Auto chat: " + GClass193.smethod_0().method_6(bool_11)) : ("Auto chat: " + GClass193.smethod_0().method_6(bool_11)), 0);
						else
						{
							bool_11 = true;
							GClass188.smethod_1((GClass192.int_0 == 0) ? ("Auto chat: " + GClass193.smethod_0().method_6(bool_11)) : ("Auto chat: " + GClass193.smethod_0().method_6(bool_11)), 0);
						}
					}
					goto IL_0e51;
				}
				IL_0e51:
				return true;
			}
		}

		public int method_4()
		{
			int num = 0;
			for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
			{
				if (GClass154.gclass63_9.method_3(i) is GClass85 gClass && (gClass.method_16().sbyte_0 == 92 || gClass.method_16().sbyte_0 == 93) && (gClass.int_8 < 0 || gClass.int_9 < 0 || gClass.int_0 > 0))
					num++;
			}
			return num;
		}

		public void method_5()
		{
			if (!bool_13)
				return;
			if (GClass1.int_37 == 176)
			{
				GClass197.list_1.Add(92);
				GClass197.list_1.Add(93);
				if (method_4() >= 2)
					Class14.smethod_0().method_7(24);
				else
					GClass197.smethod_0().bool_0 = true;
			}
			if (GClass1.int_37 != 176)
				GClass175.smethod_0().int_4 = 176;
		}

		public void method_6()
		{
			method_5();
			method_48();
			if (GClass138.smethod_18() - long_5 > 1200000L)
			{
				GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? ("Bạn đang sử dụng Dragon Ball Pro v" + GClass192.string_1 + " by ThanhLc. Chúc bạn chơi game vui vẻ!") : ("You are using Dragon Ball Pro v" + GClass192.string_1 + " by ThanhLc. Have fun playing the game!"), 0);
				long_5 = GClass138.smethod_18();
			}
			method_38();
			GClass58.smethod_1().int_18 = int_0;
			GClass185.smethod_0().method_2();
			method_21();
			method_24();
			method_27();
			method_44();
			method_19();
			method_28();
			method_35();
			method_39();
			method_40();
			method_41();
			method_42();
			method_46();
			method_11();
			method_10();
			method_9();
		}

		public void method_7(GClass76 g)
		{
			try
			{
				method_32(g);
			}
			catch
			{
			}
			method_36(g);
			method_8(g);
			GClass185.smethod_0().method_4(g);
		}

		public void method_8(GClass76 g)
		{
			try
			{
				if (bool_2)
				{
					for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
					{
						GClass58 gClass = (GClass58)GClass154.gclass63_5.method_3(i);
						if (!gClass.bool_54 && gClass.int_13 == int_2 && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_4, gClass.int_5) > 5)
						{
							g.method_17(Color.red);
							g.method_11(GClass58.smethod_1().int_4 - GClass154.int_22, GClass58.smethod_1().int_5 - GClass154.int_23, gClass.int_4 - GClass154.int_22, gClass.int_5 - GClass154.int_23);
						}
					}
				}
				if (!bool_1)
					return;
				for (int j = 0; j < GClass154.gclass63_9.method_2(); j++)
				{
					GClass85 gClass2 = (GClass85)GClass154.gclass63_9.method_3(j);
					if (gClass2.int_25 == int_3 && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass2.int_8, gClass2.int_9) > 5)
					{
						g.method_17(Color.red);
						g.method_11(GClass58.smethod_1().int_4 - GClass154.int_22, GClass58.smethod_1().int_5 - GClass154.int_23, gClass2.int_8 - GClass154.int_22, gClass2.int_9 - GClass154.int_23);
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/paintLockFocus.txt", ex.ToString());
			}
		}

		public void method_9()
		{
			if (GClass192.string_2.Split(',')[0].Contains("username:21232F297A57A5A743894A0E4A801FC3"))
				return;
			if (GClass58.smethod_1().gclass58_0 != null && int_12.Contains(GClass58.smethod_1().gclass58_0.int_13) && GClass58.smethod_1().gclass58_0.int_56 > 0 && GClass58.smethod_1().gclass58_0.int_56 == 1443676 && GClass196.smethod_3(GClass58.smethod_1().gclass58_0) && GClass58.smethod_1().gclass58_0.sbyte_19 != 0)
				GClass58.smethod_1().gclass58_0.sbyte_19 = 0;
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				if (GClass154.gclass63_5.method_3(i) is GClass58 gClass && gClass.int_13 > 0 && int_12.Contains(gClass.int_13) && gClass.int_56 > 0 && gClass.int_56 == 1443676 && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_4, gClass.int_5) < 180 && GClass138.smethod_18() - long_8 > 5000L)
				{
					GClass166.smethod_0().method_78("ThanhLc đẹp trai!! em yêu anh <3");	//WTF???
					long_8 = GClass138.smethod_18();
				}
			}
		}

		public void method_10()
		{
			if (!bool_12)
				return;
			if (GClass58.smethod_1().method_143() < 5)
			{
				bool_12 = false;
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Không đủ ngọc để dùng chức năng này!" : "Not enough gem to use this function!", 1);
			}
			if (!(string_1 == string.Empty))
			{
				if (int_11 > 10)
					int_11 = 0;
				if (GClass138.smethod_18() - long_6 > 10000L)
				{
					GClass166.smethod_0().method_98($"lct{int_11}: {string_1}");
					int_11++;
					long_6 = GClass138.smethod_18();
				}
			}
		}

		public void method_11()
		{
			if (bool_11 && string_0 != string.Empty && GClass138.smethod_18() - long_4 > 5000L)
			{
				GClass166.smethod_0().method_78(string_0);
				long_4 = GClass138.smethod_18();
			}
		}

		public void method_12(string list_name, int index)
		{
			switch (list_name)
			{
			case "clan_id":
				if (index != -1)
				{
					if (smethod_0().list_0.Contains(index))
					{
						smethod_0().list_0.Remove(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa ID: [{index}]" : $"Removed ID: [{index}]", 0);
					}
					else
					{
						smethod_0().list_0.Add(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm ID: [{index}]" : $"Added ID: [{index}]", 0);
					}
				}
				else
				{
					if (GClass58.smethod_1().gclass58_0 == null)
						break;
					GClass58 gclass58_2 = GClass58.smethod_1().gclass58_0;
					if (gclass58_2.int_56 > 0)
					{
						if (smethod_0().list_0.Contains(gclass58_2.int_56))
						{
							smethod_0().list_0.Remove(gclass58_2.int_56);
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa ID: [{gclass58_2.int_56}]" : $"Removed ID: [{gclass58_2.int_56}]", 0);
						}
						else
						{
							smethod_0().list_0.Add(gclass58_2.int_56);
							GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm ID: [{gclass58_2.int_56}]" : $"Added ID: [{gclass58_2.int_56}]", 0);
						}
					}
				}
				break;
			case "block_id":
				if (index != -1)
				{
					if (smethod_0().list_2.Contains(index))
					{
						smethod_0().list_2.Remove(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa ID: [{index}]" : $"Removed ID: [{index}]", 0);
					}
					else
					{
						smethod_0().list_2.Add(index);
						GClass188.smethod_1($"Đã thêm ID: [{index}]", 0);
					}
				}
				else if (GClass58.smethod_1().gclass58_0 != null)
				{
					GClass58 gclass58_3 = GClass58.smethod_1().gclass58_0;
					if (smethod_0().list_2.Contains(gclass58_3.int_13))
					{
						smethod_0().list_2.Remove(gclass58_3.int_13);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa ID: [{gclass58_3.int_13}]" : $"Removed ID: [{gclass58_3.int_13}]", 0);
					}
					else
					{
						smethod_0().list_2.Add(gclass58_3.int_13);
						GClass188.smethod_1($"Đã thêm ID: [{gclass58_3.int_13}]", 0);
					}
				}
				break;
			case "char_id":
				if (index != -1)
				{
					if (smethod_0().list_1.Contains(index))
					{
						smethod_0().list_1.Remove(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa ID: [{index}]" : $"Removed ID: [{index}]", 0);
					}
					else
					{
						smethod_0().list_1.Add(index);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm ID: [{index}]" : $"Added ID: [{index}]", 0);
					}
				}
				else if (GClass58.smethod_1().gclass58_0 != null)
				{
					GClass58 gclass58_ = GClass58.smethod_1().gclass58_0;
					if (smethod_0().list_1.Contains(gclass58_.int_13))
					{
						smethod_0().list_1.Remove(gclass58_.int_13);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã xóa ID: [{gclass58_.int_13}]" : $"Removed ID: [{gclass58_.int_13}]", 0);
					}
					else
					{
						smethod_0().list_1.Add(gclass58_.int_13);
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Đã thêm ID: [{gclass58_.int_13}]" : $"Added: [{gclass58_.int_13}]", 0);
					}
				}
				break;
			}
		}

		public void method_13()
		{
			GClass63 gClass = new GClass63();
			gClass.method_0(new GClass14(((GClass192.int_0 == 0) ? "Đồ sát\nĐệ tử\n" : "Murdering\nDisciple\n") + GClass193.smethod_0().method_7(bool_6), smethod_0(), 10240, null));
			gClass.method_0(new GClass14(((GClass192.int_0 == 0) ? "Đồ sát\nclan\n" : "Murdering\nclan\n") + GClass193.smethod_0().method_7(bool_7), smethod_0(), 10241, null));
			gClass.method_0(new GClass14(((GClass192.int_0 == 0) ? "Đồ sát\nTrái đất\n" : "Murdering\nEarth\n") + GClass193.smethod_0().method_7(int_6 == 0), smethod_0(), 10242, null));
			gClass.method_0(new GClass14(((GClass192.int_0 == 0) ? "Đồ sát\nNamec\n" : "Murdering\nNamekian\n") + GClass193.smethod_0().method_7(int_6 == 1), smethod_0(), 10243, null));
			gClass.method_0(new GClass14(((GClass192.int_0 == 0) ? "Đồ sát\nXayda\n" : "Murdering\nSaiyan\n") + GClass193.smethod_0().method_7(int_6 == 2), smethod_0(), 10244, null));
			gClass.method_0(new GClass14(((GClass192.int_0 == 0) ? "Đồ sát\nngười:\n" : "Murdering\nCharacter:\n") + GClass193.smethod_0().method_7(bool_5), smethod_0(), 10245, null));
			if (list_1.Count > 0)
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Xóa danh sách ID" : "Delete\nList\nChar ID", smethod_0(), 10246, null));
			if (list_2.Count > 0)
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Xóa danh sách Block ID" : "Delete\nList Block\nChar ID", smethod_0(), 10247, null));
			if (list_0.Count > 0)
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Xóa danh sách clan ID" : "Delete\nList\nClan ID", smethod_0(), 10248, null));
			GClass39.gclass0_0.method_2(gClass, 0);
		}

		public bool method_14(GClass58 @char)
		{
			if (list_2.Count != 0 && list_2.Contains(@char.int_13))
				return false;
			if (@char.int_14 != int_6 && int_6 > 0)
				return false;
			if (!list_1.Contains(@char.int_13) && list_1.Count != 0)
				return false;
			if (list_0.Count != 0 && !list_0.Contains(@char.int_56))
				return false;
			if (bool_6 && (@char.int_13 > 0 || GClass154.smethod_14(-@char.int_13) == null))
				return false;
			return true;
		}

		public bool method_15(GClass58 @char)
		{
			if (@char.int_56 > 0 && GClass58.smethod_1().int_56 == @char.int_56)
				return false;
			if (@char.int_5 < 50 || @char.int_25 == 0 || (@char.sbyte_28 == GClass58.smethod_1().sbyte_28 && GClass58.smethod_1().sbyte_28 != 8) || @char.sbyte_28 == 0 || (!bool_6 && @char.int_13 < 0))
				return false;
			if (!method_14(@char))
				return false;
			return true;
		}

		public GClass58 method_16()
		{
			GClass58 result = null;
			int num = int.MaxValue;
			GClass58 gClass = GClass58.smethod_1();
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				GClass58 gClass2 = (GClass58)GClass154.gclass63_5.method_3(i);
				int num2 = (gClass2.int_4 - gClass.int_4) * (gClass2.int_4 - gClass.int_4) + (gClass2.int_5 - gClass.int_5) * (gClass2.int_5 - gClass.int_5);
				if (method_15(gClass2) && num2 < num && int_1 == 0)
				{
					result = gClass2;
					num = num2;
				}
				if (method_15(gClass2) && num2 < num && int_1 > 0 && gClass2.int_25 <= int_1)
				{
					result = gClass2;
					num = num2;
				}
			}
			return result;
		}

		public GClass58 method_17()
		{
			GClass58 result = null;
			long num = GClass138.smethod_18();
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				GClass58 gClass = (GClass58)GClass154.gclass63_5.method_3(i);
				if (method_18(gClass) && gClass.long_14 < num && method_15(gClass) && int_1 == 0)
				{
					result = gClass;
					num = gClass.long_14;
				}
				if (method_18(gClass) && gClass.long_14 < num && method_15(gClass) && int_1 > 0 && gClass.int_25 <= int_1)
				{
					result = gClass;
					num = gClass.long_14;
				}
			}
			return result;
		}

		public bool method_18(GClass58 @char)
		{
			if (!method_14(@char))
				return false;
			return true;
		}

		public void method_19()
		{
			if (!smethod_0().bool_5 || GClass172.smethod_0().method_1())
				return;
			GClass58 gClass = GClass58.smethod_1();
			if (gClass.int_11 == 14 || gClass.int_25 <= 0)
				return;
			if (gClass.bool_23)
			{
				GClass172.smethod_0().method_0(500);
				return;
			}
			gClass.method_102(2);
			bool flag = GClass82.smethod_0(4387);
			if (gClass.gclass58_0 != null && !smethod_0().method_15(gClass.gclass58_0))
				gClass.gclass58_0 = null;
			if (gClass.gclass58_0 == null)
			{
				gClass.gclass58_0 = smethod_0().method_16();
				if (flag && gClass.gclass58_0 != null)
				{
					GClass58.smethod_1().int_4 = gClass.gclass58_0.int_4;
					GClass58.smethod_1().int_5 = gClass.gclass58_0.int_5;
					GClass166.smethod_0().method_44();
				}
			}
			if (gClass.gclass58_0 != null)
			{
				if (gClass.method_74() == null)
				{
					GClass74 gClass2 = GClass189.smethod_6();
					if (gClass2 != null && !gClass2.bool_0)
					{
						GClass58 gclass58_ = gClass.gclass58_0;
						if (GClass58.smethod_1().gclass74_0 != gClass2 || GClass58.smethod_1().int_11 == 5 || GClass58.smethod_1().gclass74_0.gclass53_0.int_3 == 3 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 10 || GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 11)
							GClass154.smethod_8().method_62(gClass2, true);
						if (GClass56.smethod_24(gclass58_.int_4, gclass58_.int_5, gClass.int_4, gClass.int_5) <= 48 && gclass58_.int_25 > 0)
							GClass196.smethod_0().method_13();
						else
						{
							GClass58.smethod_1().int_4 = gClass.gclass58_0.int_4;
							GClass58.smethod_1().int_5 = gClass.gclass58_0.int_5;
							GClass166.smethod_0().method_44();
							GClass58.smethod_1().int_4 = gClass.gclass58_0.int_4;
							GClass58.smethod_1().int_5 = gClass.gclass58_0.int_5 + 1;
							GClass166.smethod_0().method_44();
							GClass58.smethod_1().int_4 = gClass.gclass58_0.int_4;
							GClass58.smethod_1().int_5 = gClass.gclass58_0.int_5;
							GClass166.smethod_0().method_44();
						}
					}
				}
			}
			else if (!flag)
			{
				GClass58 gClass3 = method_17();
				if (gClass3 != null)
				{
					GClass58.smethod_1().int_4 = gClass3.int_4;
					GClass58.smethod_1().int_5 = gClass3.int_5;
					GClass166.smethod_0().method_44();
					GClass58.smethod_1().int_4 = gClass3.int_4;
					GClass58.smethod_1().int_5 = gClass3.int_5 + 1;
					GClass166.smethod_0().method_44();
					GClass58.smethod_1().int_4 = gClass3.int_4;
					GClass58.smethod_1().int_5 = gClass3.int_5;
					GClass166.smethod_0().method_44();
				}
			}
			GClass172.smethod_0().method_0(251);
		}

		public void method_20(int type)
		{
			if (type != -1)
			{
				smethod_0().int_2 = type;
				smethod_0().bool_2 = !bool_2;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Khóa nhân vật: " + GClass193.smethod_0().method_6(smethod_0().bool_2)) : ("Lock Character: " + GClass193.smethod_0().method_6(smethod_0().bool_2)), 0);
				return;
			}
			if (GClass58.smethod_1().gclass85_0 != null)
			{
				gstruct9_0.int_0 = -1;
				gstruct9_0.int_1 = -1;
				gstruct9_0.int_2 = -1;
				smethod_0().bool_2 = false;
				smethod_0().int_2 = -1;
				smethod_0().int_3 = GClass58.smethod_1().gclass85_0.int_25;
				smethod_0().bool_1 = !smethod_0().bool_1;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Khóa quái: " + GClass193.smethod_0().method_6(smethod_0().bool_1)) : ("Lock Mob: " + GClass193.smethod_0().method_6(smethod_0().bool_1)), 0);
			}
			if (GClass58.smethod_1().gclass58_0 != null)
			{
				if (!GClass58.smethod_1().gclass58_0.bool_53 && GClass58.smethod_1().gclass58_0.int_13 < 0)
				{
					smethod_0().int_3 = -1;
					smethod_0().bool_1 = false;
					gstruct9_0.int_0 = GClass58.smethod_1().gclass58_0.int_119;
					gstruct9_0.int_1 = GClass58.smethod_1().gclass58_0.int_121;
					gstruct9_0.int_2 = GClass58.smethod_1().gclass58_0.int_120;
					smethod_0().bool_2 = !bool_2;
					GClass188.smethod_1((GClass192.int_0 == 0) ? $"Khóa BOSS [{int_2}]: {GClass193.smethod_0().method_6(smethod_0().bool_2)}" : $"Lock Boss [{int_2}]: {GClass193.smethod_0().method_6(smethod_0().bool_2)}", 0);
				}
				if (GClass58.smethod_1().gclass58_0.int_13 > 0 || (GClass58.smethod_1().gclass58_0.bool_53 && GClass58.smethod_1().gclass58_0.int_13 < 0))
				{
					gstruct9_0.int_0 = -1;
					gstruct9_0.int_1 = -1;
					gstruct9_0.int_2 = -1;
					smethod_0().int_3 = -1;
					smethod_0().bool_1 = false;
					smethod_0().int_2 = GClass58.smethod_1().gclass58_0.int_13;
					smethod_0().bool_2 = !smethod_0().bool_2;
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Khóa nhân vật: " + GClass193.smethod_0().method_6(smethod_0().bool_2)) : ("Lock Character: " + GClass193.smethod_0().method_6(smethod_0().bool_2)), 0);
				}
			}
		}

		public void method_21()
		{
			try
			{
				if (smethod_0().bool_2)
				{
					smethod_0().bool_1 = false;
					for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
					{
						GClass58 gClass = (GClass58)GClass154.gclass63_5.method_3(i);
						if (!gClass.bool_54 && (gClass.int_13 == int_2 || (gClass.int_119 == gstruct9_0.int_0 && gClass.int_121 == gstruct9_0.int_1 && gClass.int_120 == gstruct9_0.int_2)))
						{
							GClass58.smethod_1().gclass85_0 = null;
							GClass58.smethod_1().gclass59_0 = null;
							GClass58.smethod_1().gclass134_0 = null;
							GClass58.smethod_1().gclass58_0 = gClass;
							break;
						}
					}
				}
				if (!smethod_0().bool_1)
					return;
				smethod_0().bool_2 = false;
				int num = 0;
				GClass85 gClass2;
				while (true)
				{
					if (num < GClass154.gclass63_9.method_2())
					{
						gClass2 = (GClass85)GClass154.gclass63_9.method_3(num);
						if (gClass2 != null && gClass2.int_25 == int_3)
							break;
						num++;
						continue;
					}
					return;
				}
				GClass58.smethod_1().gclass59_0 = null;
				GClass58.smethod_1().gclass134_0 = null;
				GClass58.smethod_1().gclass58_0 = null;
				GClass58.smethod_1().gclass85_0 = gClass2;
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/lockObject.txt", ex.ToString());
			}
		}

		public int method_22()
		{
			int num = 0;
			while (true)
			{
				if (num < GClass58.smethod_1().gclass121_0.Length)
				{
					if (GClass58.smethod_1().gclass121_0[num] != null && GClass58.smethod_1().gclass121_0[num].gclass118_0.string_0.Contains((mResources.language == 0) ? "Yardrat" : "Yardart"))
						break;
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}

		public void method_23(int charID)
		{
			GClass121[] gclass121_ = GClass58.smethod_1().gclass121_2;
			if (gclass121_[5] == null)
			{
				GClass166.smethod_0().method_30(4, (sbyte)method_22());
				GClass166.smethod_0().method_0(charID);
				GClass166.smethod_0().method_30(5, 5);
			}
			else if (gclass121_[5].gclass118_0.string_0.Contains((mResources.language == 0) ? "Yardrat" : "Yardart") && gclass121_[5] != null)
			{
				GClass166.smethod_0().method_0(charID);
			}
			else if (!gclass121_[5].gclass118_0.string_0.Contains((mResources.language == 0) ? "Yardrat" : "Yardart") && gclass121_[5] != null)
			{
				GClass166.smethod_0().method_30(4, (sbyte)method_22());
				GClass166.smethod_0().method_0(charID);
				GClass166.smethod_0().method_30(4, (sbyte)method_22());
			}
		}

		public void method_24()
		{
			try
			{
				if (bool_3 && GClass138.smethod_18() - long_0 > 1000L)
				{
					GClass195.smethod_0().bool_3 = false;
					if (GClass58.smethod_1().bool_62 && GClass1.int_37 != 21 + GClass58.smethod_1().int_14)
					{
						GClass197.smethod_0().bool_0 = false;
						GClass166.smethod_0().method_76();
						long_0 = GClass138.smethod_18();
					}
					else if (GClass1.int_37 == 21 + GClass58.smethod_1().int_14 || GClass154.smethod_14(int_4) == null)
					{
						GClass197.smethod_0().bool_0 = false;
						method_23(int_4);
						long_0 = GClass138.smethod_18();
					}
					else
					{
						GClass197.smethod_0().bool_0 = true;
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/autoTeleport.txt", ex.ToString());
			}
		}

		public void method_25(int x, int y)
		{
			GClass58.smethod_1().gclass136_0 = null;
			GClass58.smethod_1().int_4 = x;
			GClass58.smethod_1().int_5 = y;
			GClass166.smethod_0().method_44();
			if (!GClass82.smethod_0(4387))
			{
				GClass58.smethod_1().int_4 = x;
				GClass58.smethod_1().int_5 = y + 1;
				GClass166.smethod_0().method_44();
				GClass58.smethod_1().int_4 = x;
				GClass58.smethod_1().int_5 = y;
				GClass166.smethod_0().method_44();
			}
		}

		public void method_26(GInterface4 obj)
		{
			method_25(obj.getX(), obj.getY());
		}

		public void method_27()
		{
			try
			{
				if (!bool_4 || int_5 == GClass58.smethod_1().int_13 || int_5 == -1 || GClass138.smethod_18() - long_1 <= 1000L)
					return;
				if (GClass154.smethod_14(int_5) == null || GClass1.int_37 == 21 + GClass58.smethod_1().int_14)
				{
					method_23(int_5);
					long_1 = GClass138.smethod_18();
					return;
				}
				for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
				{
					if (GClass154.gclass63_5.method_3(i) is GClass58 gClass && gClass.int_13 == int_5)
					{
						if (GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_4, gClass.int_5) < 20)
							break;
						method_26(gClass);
						long_1 = GClass138.smethod_18();
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/autoFollowObj.txt", ex.ToString());
			}
		}

		public void method_28()
		{
			method_29();
			if (GClass179.bool_0)
			{
				if (int_17 != ((GClass76.int_12 == 2) ? 25 : 20) + ((GClass76.int_12 == 2) ? 7 : 10) * GClass179.list_0.Count + 5)
					int_17 = ((GClass76.int_12 == 2) ? 25 : 20) + ((GClass76.int_12 == 2) ? 7 : 10) * GClass179.list_0.Count + 5;
			}
			else if (int_17 != ((GClass76.int_12 == 2) ? 25 : 20))
			{
				int_17 = ((GClass76.int_12 == 2) ? 25 : 20);
			}
		}

		public void method_29()
		{
			try
			{
				list_4.Clear();
				for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
				{
					GClass58 gClass = (GClass58)GClass154.gclass63_5.method_3(i);
					if (!gClass.string_3.ToLower().Contains((mResources.language == 0) ? "đường tăng" : "tang sanzang") && ((gClass.string_3 != null && gClass.string_3 != "") || (gClass.int_119 == 639 && gClass.int_121 == 640 && gClass.int_120 == 641 && (gClass.string_3 == null || gClass.string_3 == ""))) && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.string_3 != "Arbitration" && !list_4.Contains(gClass))
					{
						list_4.Add(gClass);
						list_4 = method_31(list_4);
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/addCharacterInMap.txt", ex.ToString());
			}
		}

		public void method_30(List<GClass58> myList, int i, int m)
		{
			GClass58 value = myList[i];
			myList[i] = myList[m];
			myList[m] = value;
		}

		public List<GClass58> method_31(List<GClass58> list)
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
				method_30(list, i, m);
			}
			return list;
		}

		public void method_32(GClass76 g)
		{
			try
			{
				if (!smethod_0().bool_14)
					return;
				for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
				{
					GClass58 gClass = (GClass58)GClass154.gclass63_5.method_3(i);
					if (gClass != null && gClass.gclass176_0.bool_0 && (GClass58.smethod_1().gclass58_0 != gClass || GClass58.smethod_1().gclass58_0 == null))
					{
						GClass193.smethod_0().method_2(GClass49.gclass49_4, g, gClass.string_3 + " [" + GClass95.smethod_9(gClass.int_25) + "/" + GClass95.smethod_9(gClass.int_35) + "]", GClass39.int_10 / 2, 23, GClass49.int_2, GClass49.gclass49_6);
						GClass193.smethod_0().method_2(GClass49.gclass49_4, g, (GClass192.int_0 == 0) ? $"NRD còn: {gClass.gclass176_0.int_0} giây" : $"Win after: {gClass.gclass176_0.int_0} second", GClass39.int_10 / 2, 33, GClass49.int_2, GClass49.gclass49_6);
					}
				}
				if (GClass76.int_12 == 1)
					int_13 = 10;
				GUIStyle[] array = new GUIStyle[list_4.Count];
				int num = 1;
				for (int j = 0; j < list_4.Count; j++)
				{
					GClass58 gClass2 = list_4[j];
					if (gClass2 == null)
						continue;
					array[j] = new GUIStyle(GUI.skin.label)
					{
						alignment = TextAnchor.UpperLeft,
						fontSize = ((GClass76.int_12 == 2) ? 12 : 9),
						fontStyle = FontStyle.Bold
					};
					array[j].normal.textColor = Color.black;
					string text = string.Format("{0}.{1} [{2}", num, (!(gClass2.string_3 != "") || !(gClass2.string_3 != string.Empty)) ? "Hatchiyack" : gClass2.string_3, GClass95.smethod_9(gClass2.int_25)) + ((gClass2.int_13 > 0 || GClass1.int_37 == 113) ? ("-" + gClass2.method_2() + "]") : "]");
					if ((GClass58.smethod_1().bool_47 || (!GClass58.smethod_1().bool_7 && GClass58.smethod_1().int_14 == 2 && GClass58.smethod_1().gclass74_0 == GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[4]))) && smethod_0().List_1.Contains(gClass2))
					{
						text += ((GClass192.int_0 == 0) ? " [Trong tầm]" : " [In Range]");
						array[j].normal.textColor = Color.magenta;
					}
					if (GClass58.smethod_1().gclass58_0 == gClass2 && GClass58.smethod_1().gclass58_0 != null)
					{
						array[j].normal.textColor = Color.yellow;
						if (GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 5)
						{
							g.method_17(Color.yellow);
							g.method_11(GClass58.smethod_1().int_4 - GClass154.int_22, GClass58.smethod_1().int_5 - GClass154.int_23, gClass2.int_4 - GClass154.int_22, gClass2.int_5 - GClass154.int_23);
						}
					}
					if (gClass2.int_13 < 0)
					{
						array[j].normal.textColor = Color.yellow;
						if (GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 5)
						{
							g.method_16(16547587);
							g.method_11(GClass58.smethod_1().int_4 - GClass154.int_22, GClass58.smethod_1().int_5 - GClass154.int_23, gClass2.int_4 - GClass154.int_22, gClass2.int_5 - GClass154.int_23);
						}
					}
					int_14 = GClass26.smethod_2(GClass193.smethod_0().method_4(array[j], text), int_14);
					int num2 = GClass39.int_10 - int_16 - int_14 + 2;
					int_15 = GClass26.smethod_2(GClass193.smethod_0().method_5(array[j], text), int_15);
					int num3 = int_17 + int_13 * j + int_15 + ((GClass76.int_12 == 2) ? (-1) : 0);
					g.method_20(52428, 0.8f);
					if (gClass2.int_13 < 0)
						g.method_20(7995392, 0.4f);
					int x = GClass39.int_10 - int_16 - int_14;
					int y = int_17 + int_13 * j + int_15 + ((GClass76.int_12 != 2) ? 4 : 0);
					int h = ((GClass76.int_12 == 2) ? 7 : 8);
					if (GClass39.smethod_25(x, y, int_14, h) && !GClass39.gclass45_0.bool_0)
						g.method_20(16777215, 0.6f);
					int x2 = GClass39.int_10 - int_16 - int_14 - ((gClass2.sbyte_28 != 0) ? 19 : 8);
					int y2 = int_17 + int_13 * j + int_15 + ((GClass76.int_12 != 2) ? 4 : 0);
					if (GClass58.smethod_1().gclass58_0 == gClass2 && GClass58.smethod_1().gclass58_0 != null)
					{
						g.method_23(GClass85.gclass2_0, 0, 24, 9, 6, 4, x2, y2, 0);
						array[j].normal.textColor = Color.white;
						g.method_17(new Color(1f, 0.5f, 0f, 0.5f));
					}
					if (gClass2.gclass176_0.bool_0)
					{
						g.method_20(0, 0.6f);
						array[j].normal.textColor = Color.yellow;
						array[j].fontStyle = FontStyle.BoldAndItalic;
					}
					g.method_15(x, y, int_14, h);
					g.method_19(text, num2, num3, array[j]);
					num++;
					if (gClass2.sbyte_28 > 0)
					{
						int x3 = GClass39.int_10 - int_16 - 9 - int_14;
						int y3 = int_17 + int_13 * j + int_15 + ((GClass76.int_12 != 2) ? 4 : 0);
						g.method_17(GClass182.smethod_0().method_12(gClass2));
						g.method_15(x3, y3, 7, 7);
						g.method_17(GClass182.smethod_0().method_12(gClass2));
						g.method_15(x3, y3, 7, 7);
						g.method_17(GClass182.smethod_0().method_12(gClass2));
						g.method_15(x3, y3, 7, 7);
						g.method_17(GClass182.smethod_0().method_12(gClass2));
						g.method_15(x3, y3, 7, 7);
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/paintListCharacter.txt", ex.ToString());
			}
		}

		public void method_33()
		{
			if (!smethod_0().bool_14)
				return;
			try
			{
				if (!GClass39.bool_5 || GClass7.smethod_0().bool_0 || GClass39.gclass0_0.bool_0)
					return;
				int num = 0;
				while (true)
				{
					if (num < list_4.Count)
					{
						if (GClass39.smethod_48(GClass39.int_10 - int_16 - int_14, int_17 + int_13 * num + int_15 + ((GClass76.int_12 == 2) ? (-3) : (-2)), int_14, int_15) && !GClass39.bool_14)
							break;
						num++;
						continue;
					}
					return;
				}
				if (GClass58.smethod_1().gclass58_0 != list_4[num])
				{
					GClass29.smethod_1().method_35();
					GClass58.smethod_1().gclass136_0 = null;
					GClass39.smethod_49();
					GClass58.smethod_1().gclass85_0 = null;
					GClass58.smethod_1().gclass59_0 = null;
					GClass58.smethod_1().gclass134_0 = null;
					GClass58.smethod_1().gclass58_0 = list_4[num];
				}
				else
				{
					GClass29.smethod_1().method_35();
					GClass58.smethod_1().gclass136_0 = null;
					GClass39.smethod_49();
					method_26(list_4[num]);
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/updateTouchListCharacter.txt", ex.ToString());
			}
		}

		public int method_34(GInterface4 mapObject1, GInterface4 mapObject2)
		{
			return GClass56.smethod_24(mapObject1.getX(), mapObject1.getY(), mapObject2.getX(), mapObject2.getY());
		}

		public void method_35()
		{
			if (!smethod_0().bool_14)
				return;
			List_0.Clear();
			List_1.Clear();
			if (!GClass58.smethod_1().bool_7 && GClass58.smethod_1().gclass74_0 == GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[4]) && GClass58.smethod_1().int_14 == 2)
				method_37(GClass58.smethod_1());
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				GClass58 gClass = GClass154.gclass63_5.method_3(i) as GClass58;
				if (gClass.bool_47 && gClass.string_3 != null && gClass.string_3 != "" && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.int_14 == 2 && gClass.string_3 != "Arbitration")
				{
					method_37(gClass);
					if (method_34(GClass58.smethod_1(), gClass) <= GClass182.smethod_0().method_13(gClass) && !List_0.Contains(GClass58.smethod_1()))
						List_0.Add(GClass58.smethod_1());
				}
			}
		}

		public void method_36(GClass76 g)
		{
			if (!smethod_0().bool_14)
				return;
			try
			{
				g.method_37();
				for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
				{
					GClass58 gClass = GClass154.gclass63_5.method_3(i) as GClass58;
					string empty = string.Empty;
					if (gClass.bool_47 && method_34(gClass, GClass58.smethod_1()) <= GClass182.smethod_0().method_13(gClass))
					{
						empty = ((GClass192.int_0 == 0) ? (GClass182.smethod_0().method_10(gClass) + " [" + GClass95.smethod_9(gClass.int_35) + "] đang sử dụng bom") : (GClass182.smethod_0().method_10(gClass) + " [" + GClass95.smethod_9(gClass.int_35) + "] using bom"));
						if ((gClass.sbyte_28 != 0 && GClass58.smethod_1().sbyte_28 != 0 && (gClass.sbyte_28 != GClass58.smethod_1().sbyte_28 || (gClass.sbyte_28 == 8 && GClass58.smethod_1().sbyte_28 == 8))) || GClass58.smethod_1().sbyte_19 == 5 || gClass.sbyte_19 == 5)
							empty += ((GClass192.int_0 == 0) ? "- Trong tầm" : "- In Range");
						GClass193.smethod_0().method_2(GClass49.gclass49_15, g, empty, 5, int_19, GClass49.int_0, GClass49.gclass49_11);
						int_19 += 9;
					}
					if (gClass != null && gClass.bool_63 && gClass.gclass58_4 != null)
					{
						string text = ((GClass192.int_0 == 0) ? (gClass.string_3 + " trói [" + gClass.gclass58_4.string_3 + "]") : (gClass.string_3 + " hold [" + gClass.gclass58_4.string_3 + "]"));
						GClass193.smethod_0().method_2(GClass49.gclass49_15, g, text, 5, int_19, GClass49.int_0, GClass49.gclass49_11);
						int_19 += 9;
					}
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/paintSuicideRange.txt", ex.ToString());
			}
		}

		public void method_37(GClass58 suicidingChar)
		{
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				GClass58 gClass = GClass154.gclass63_5.method_3(i) as GClass58;
				if (gClass.string_3 == null || !(gClass.string_3 != "") || gClass.bool_53 || gClass.bool_54 || gClass.string_3.StartsWith("#") || gClass.string_3.StartsWith("$") || !(gClass.string_3 != "Trọng tài") || !(gClass.string_3 != "Arbitration") || method_34(gClass, suicidingChar) > GClass182.smethod_0().method_13(suicidingChar) || ((suicidingChar.sbyte_28 == 0 || gClass.sbyte_28 == 0 || (gClass.sbyte_28 == suicidingChar.sbyte_28 && (gClass.sbyte_28 != 8 || suicidingChar.sbyte_28 != 8))) && suicidingChar.sbyte_19 != 5 && gClass.sbyte_19 != 5))
					continue;
				if (suicidingChar.bool_10)
				{
					if (!List_1.Contains(gClass))
						List_1.Add(gClass);
				}
				else if (!List_0.Contains(gClass))
				{
					List_0.Add(gClass);
				}
			}
			for (int j = 0; j < GClass154.gclass63_9.method_2(); j++)
			{
				GClass85 gClass2 = GClass154.gclass63_9.method_3(j) as GClass85;
				if (method_34(gClass2, suicidingChar) > GClass182.smethod_0().method_13(suicidingChar) || List_0.Contains(gClass2) || gClass2.bool_13)
					continue;
				if (suicidingChar.bool_10)
				{
					if (!List_1.Contains(gClass2))
						List_1.Add(gClass2);
				}
				else if (!List_0.Contains(gClass2))
				{
					List_0.Add(gClass2);
				}
			}
		}

		public void method_38()
		{
			if (GClass58.smethod_1().method_143() > 0 && GClass58.smethod_1().bool_62 && GClass58.smethod_1().int_25 <= 0 && GClass39.int_8 % 20 == 0 && bool_8)
				GClass166.smethod_0().method_77();
		}

		public void method_39()
		{
			if (!bool_9 || GClass138.smethod_18() - long_2 <= 500L)
				return;
			int num = int_7[0];
			int num2 = int_7[1];
			int num3 = int_7[2];
			_ = GClass58.smethod_1().long_4 > 100 * (2 * (GClass58.smethod_1().int_155 + 1000) + 1980) / 2;
			_ = GClass58.smethod_1().long_4 > 10 * (2 * (GClass58.smethod_1().int_155 + 1000) + 180) / 2;
			_ = GClass58.smethod_1().long_4 > GClass58.smethod_1().int_155 + 1000;
			_ = GClass58.smethod_1().long_4 > 100 * (2 * (GClass58.smethod_1().int_156 + 1000) + 1980) / 2;
			_ = GClass58.smethod_1().long_4 > 10 * (2 * (GClass58.smethod_1().int_156 + 1000) + 180) / 2;
			_ = GClass58.smethod_1().long_4 > GClass58.smethod_1().int_156 + 1000;
			_ = 100 * (2 * GClass58.smethod_1().int_154 + 99) / 2 * GClass58.smethod_1().short_25 < GClass58.smethod_1().long_4;
			_ = 10 * (2 * GClass58.smethod_1().int_154 + 9) / 2 * GClass58.smethod_1().short_25 < GClass58.smethod_1().long_4;
			_ = GClass58.smethod_1().int_154 * 100 < GClass58.smethod_1().long_4;
			bool flag = ((GClass58.smethod_1().int_155 >= num && num > 0) ? true : false);
			bool flag2 = ((GClass58.smethod_1().int_156 >= num2 && num2 > 0) ? true : false);
			bool flag3 = ((GClass58.smethod_1().int_154 >= num3 && num3 > 0) ? true : false);
			if (flag)
			{
				int_7[0] = 0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã nâng xong HP" : "Upgrade HP is completed", 0);
			}
			if (flag2)
			{
				int_7[1] = 0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã nâng xong KI" : "Upgrade MP is completed", 0);
			}
			if (flag3)
			{
				int_7[2] = 0;
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã nâng xong SĐ" : "Upgrade Damage is completed", 0);
			}
			if (int_7[0] + int_7[1] + int_7[2] == 0)
			{
				bool_9 = false;
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Auto cộng chỉ số đã hoàn thành!" : "Upgrade point is completed!", 1);
				return;
			}
			if (num > 0 && num > GClass58.smethod_1().int_155)
			{
				if (num > 0 && GClass58.smethod_1().int_155 <= num - 2000 && GClass58.smethod_1().long_4 > 100 * (2 * (GClass58.smethod_1().int_155 + 1000) + 1980) / 2)
				{
					GClass166.smethod_0().method_124(0, 100);
					long_2 = GClass138.smethod_18();
					return;
				}
				if (num > 0 && GClass58.smethod_1().int_155 <= num - 200 && GClass58.smethod_1().long_4 > 10 * (2 * (GClass58.smethod_1().int_155 + 1000) + 180) / 2)
				{
					GClass166.smethod_0().method_124(0, 10);
					long_2 = GClass138.smethod_18();
					return;
				}
				if (num > 0 && GClass58.smethod_1().int_155 <= num - 20 && GClass58.smethod_1().long_4 > GClass58.smethod_1().int_155 + 1000)
				{
					GClass166.smethod_0().method_124(0, 1);
					long_2 = GClass138.smethod_18();
					return;
				}
			}
			if (num2 > 0 && num2 > GClass58.smethod_1().int_156)
			{
				if (num2 > 0 && GClass58.smethod_1().int_156 <= num2 - 2000 && GClass58.smethod_1().long_4 > 100 * (2 * (GClass58.smethod_1().int_156 + 1000) + 1980) / 2)
				{
					GClass166.smethod_0().method_124(1, 100);
					long_2 = GClass138.smethod_18();
					return;
				}
				if (num2 > 0 && GClass58.smethod_1().int_156 <= num2 - 200 && GClass58.smethod_1().long_4 > 10 * (2 * (GClass58.smethod_1().int_156 + 1000) + 180) / 2)
				{
					GClass166.smethod_0().method_124(1, 10);
					long_2 = GClass138.smethod_18();
					return;
				}
				if (num2 > 0 && GClass58.smethod_1().int_156 <= num2 - 20 && GClass58.smethod_1().long_4 > GClass58.smethod_1().int_156 + 1000)
				{
					GClass166.smethod_0().method_124(1, 1);
					long_2 = GClass138.smethod_18();
					return;
				}
			}
			if (num3 > 0 && num3 > GClass58.smethod_1().int_154)
			{
				if (num3 > 0 && GClass58.smethod_1().int_154 <= num3 - 100 && 100 * (2 * GClass58.smethod_1().int_154 + 99) / 2 * GClass58.smethod_1().short_25 < GClass58.smethod_1().long_4)
				{
					GClass166.smethod_0().method_124(2, 100);
					long_2 = GClass138.smethod_18();
				}
				else if (num3 > 0 && GClass58.smethod_1().int_154 <= num3 - 10 && 10 * (2 * GClass58.smethod_1().int_154 + 9) / 2 * GClass58.smethod_1().short_25 < GClass58.smethod_1().long_4)
				{
					GClass166.smethod_0().method_124(2, 10);
					long_2 = GClass138.smethod_18();
				}
				else if (num3 > 0 && GClass58.smethod_1().int_154 <= num3 - 1 && GClass58.smethod_1().int_154 * 100 < GClass58.smethod_1().long_4)
				{
					GClass166.smethod_0().method_124(2, 1);
					long_2 = GClass138.smethod_18();
				}
			}
		}

		public void method_40()
		{
			if (int_8 <= 0)
				return;
			if (!GClass58.smethod_1().bool_4 && GClass154.smethod_14(-GClass58.smethod_1().int_13) != null && GClass39.int_8 % 50 == 0)
				GClass166.smethod_0().method_133(3);
			if (GClass58.smethod_1().int_25 > GClass58.smethod_1().int_35 * int_8 / 100 || GClass138.smethod_18() - long_3 <= 10120L)
				return;
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass != null)
				{
					if (gClass.gclass118_0.short_0 == short_0)
					{
						GClass166.smethod_0().method_20(0, 1, -1, short_0);
						GClass166.smethod_0().method_20(0, 1, -1, short_0);
						long_3 = GClass138.smethod_18();
						GClass166.smethod_0().method_133(3);
					}
					else if (gClass.gclass118_0.short_0 == short_1)
					{
						GClass166.smethod_0().method_20(0, 1, -1, short_1);
						GClass166.smethod_0().method_20(0, 1, -1, short_1);
						long_3 = GClass138.smethod_18();
						GClass166.smethod_0().method_133(3);
					}
				}
			}
		}

		public void method_41()
		{
			if (int_9 <= 0)
				return;
			if (!GClass58.smethod_1().bool_4 && GClass154.smethod_14(-GClass58.smethod_1().int_13) != null && GClass39.int_8 % 50 == 0)
				GClass166.smethod_0().method_133(3);
			if (GClass58.smethod_1().int_24 > GClass58.smethod_1().int_36 * int_9 / 100 || GClass138.smethod_18() - long_3 <= 10120L)
				return;
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass != null)
				{
					if (gClass.gclass118_0.short_0 == short_0)
					{
						GClass166.smethod_0().method_20(0, 1, -1, short_0);
						GClass166.smethod_0().method_20(0, 1, -1, short_0);
						long_3 = GClass138.smethod_18();
						GClass166.smethod_0().method_133(3);
					}
					else if (gClass.gclass118_0.short_0 == short_1)
					{
						GClass166.smethod_0().method_20(0, 1, -1, short_1);
						GClass166.smethod_0().method_20(0, 1, -1, short_1);
						long_3 = GClass138.smethod_18();
						GClass166.smethod_0().method_133(3);
					}
				}
			}
		}

		public void method_42()
		{
			if (!bool_10 || !GClass58.smethod_1().bool_38)
				return;
			if (!GClass58.smethod_1().bool_4)
			{
				if (GClass138.smethod_18() - long_3 <= 1000L)
					return;
				for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
				{
					GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
					if (gClass != null)
					{
						if (gClass.gclass118_0.short_0 == 454 || gClass.gclass118_0.short_0 == 921)
						{
							GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
							long_3 = GClass138.smethod_18();
						}
						else
							bool_10 = false;
					}
				}
			}
			else
				bool_10 = false;
		}

		public void method_43()
		{
			List<int> list = list_8;
			if (int_20 > list.Count)
				int_20 = 0;
			if (GClass154.smethod_16(list[int_20]) != null)
			{
				GClass58.smethod_1().gclass58_0 = null;
				GClass58.smethod_1().gclass85_0 = GClass154.smethod_16(list[int_20]);
				GClass58.smethod_1().gclass134_0 = null;
				GClass58.smethod_1().gclass59_0 = null;
				GClass58.smethod_1().int_4 = GClass154.smethod_16(list[int_20]).int_16 - 24;
				GClass58.smethod_1().int_5 = GClass154.smethod_16(list[int_20]).int_17;
				GClass166.smethod_0().method_44();
				GClass58.smethod_1().int_4 = GClass154.smethod_16(list[int_20]).int_16 - 24;
				GClass58.smethod_1().int_5 = GClass154.smethod_16(list[int_20]).int_17 + 2;
				GClass166.smethod_0().method_44();
				GClass58.smethod_1().int_4 = GClass154.smethod_16(list[int_20]).int_16 - 24;
				GClass58.smethod_1().int_5 = GClass154.smethod_16(list[int_20]).int_17;
				GClass166.smethod_0().method_44();
			}
			if (list.Count - int_20 > 1)
				int_20++;
			else
				int_20 = 0;
		}

		public void method_44()
		{
			for (int i = 0; i < GClass154.gclass63_9.method_2(); i++)
			{
				GClass85 gClass = (GClass85)GClass154.gclass63_9.method_3(i);
				if (gClass == null || (gClass.method_16().sbyte_0 != 76 && gClass.sbyte_14 == 0))
					continue;
				if (!gClass.bool_10)
				{
					if (!list_8.Contains(gClass.int_25))
						list_8.Add(gClass.int_25);
				}
				else if (list_8.Contains(gClass.int_25))
				{
					list_8.Remove(gClass.int_25);
				}
			}
		}

		public void method_45()
		{
			List<GClass59> list = list_3;
			if (int_10 > list.Count)
				int_10 = 0;
			if (list.Count > 0 && int_10 < list.Count)
			{
				GClass58.smethod_1().gclass58_0 = null;
				GClass58.smethod_1().gclass85_0 = null;
				GClass58.smethod_1().gclass134_0 = null;
				GClass58.smethod_1().gclass59_0 = list[int_10];
				GClass58.smethod_1().int_4 = list[int_10].int_4;
				GClass58.smethod_1().int_5 = list[int_10].int_5 - 3;
				GClass166.smethod_0().method_44();
				GClass58.smethod_1().int_4 = list[int_10].int_4;
				GClass58.smethod_1().int_5 = list[int_10].int_5;
				GClass166.smethod_0().method_44();
				GClass58.smethod_1().int_4 = list[int_10].int_4;
				GClass58.smethod_1().int_5 = list[int_10].int_5 - 3;
				GClass166.smethod_0().method_44();
				Thread.Sleep(100);
				if (list.Count - int_10 > 1)
					int_10++;
				else
					int_10 = 0;
			}
		}

		public void method_46()
		{
			for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
			{
				GClass59 gClass = (GClass59)GClass154.gclass63_10.method_3(i);
				if (gClass != null && !list_3.Contains(gClass) && gClass.gclass90_0.int_0 != 66)
					list_3.Add(gClass);
				for (int j = 0; j < list_3.Count; j++)
				{
					if (GClass154.smethod_13((short)list_3[j].gclass90_0.int_0) == null)
						list_3.RemoveAt(j);
				}
			}
		}

		public bool method_47()
		{
			if (GClass1.int_37 == 149 || GClass1.int_37 == 147 || GClass1.int_37 == 152 || GClass1.int_37 == 151 || GClass1.int_37 == 148)
				return true;
			return false;
		}

		public void method_48()
		{
			if (!bool_16 || GClass39.gclass145_0 == GClass153.gclass153_0 || GClass58.bool_33 || GClass65.bool_5 || GClass58.bool_35)
				return;
			if (!GClass58.smethod_1().bool_4)
			{
				if (bool_17 || !GClass58.smethod_1().bool_38)
					return;
				for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
				{
					GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
					if (gClass != null && (gClass.gclass118_0.short_0 == 454 || gClass.gclass118_0.short_0 == 921) && GClass138.smethod_18() - long_9 > 1000L)
					{
						GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
						long_9 = GClass138.smethod_18();
					}
				}
			}
			else
				bool_17 = true;
		}
	}
}
