using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using UnityEngine;
using Vietpad.InputMethod;

namespace AssemblyCSharp.Functions
{
	public class GClass159 : GInterface4, GInterface6
	{
		public struct GStruct2
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public GStruct2(int headID, int bodyID, int legID)
			{
				int_0 = headID;
				int_1 = bodyID;
				int_2 = legID;
			}
		}

		public struct GStruct3
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public GStruct3(int mobId, int templateID, int xFirst, int yFirst)
			{
				int_0 = mobId;
				int_1 = templateID;
				int_2 = xFirst;
				int_3 = yFirst;
			}
		}

		public bool bool_0;

		public int int_0 = 7;

		public bool bool_1;

		public bool bool_2;

		public bool bool_3;

		public int int_1 = 0;

		public int int_2 = -1;

		public int int_3 = -1;

		public int int_4;

		public long long_0;

		public bool bool_4;

		public int int_5 = -1;

		public bool bool_5;

		public long long_1;

		public bool bool_6;

		public bool bool_7;

		public int int_6 = -1;

		public bool bool_8;

		public List<int> list_0 = new List<int>();

		public List<int> list_1 = new List<int>();

		public List<int> list_2 = new List<int>();

		public List<int> list_3 = new List<int>();

		public bool bool_9;

		public bool bool_10;

		public int[] int_7 = new int[3];

		public long long_2;

		public int int_8 = 0;

		public int int_9 = 0;

		public long long_3;

		private static short short_0 = 454;

		private static short short_1 = 921;

		public bool bool_11;

		public int int_10;

		public static List<GClass79> list_4 = new List<GClass79>();

		public bool bool_12;

		public string string_0 = "";

		public long long_4;

		public long long_5;

		public bool bool_13;

		public int int_11 = 0;

		public long long_6;

		public long long_7;

		public string string_1 = "";

		private static GClass159 gclass159_0;

		public long long_8;

		public int[] int_12 = new int[4] { 10010100, 10453645, 14447611, 9928083 };

		public List<int> list_5 = new List<int>();

		public static readonly sbyte[] sbyte_0 = new sbyte[7] { 0, 2, 17, 4, 19, 12, 13 };

		public static List<sbyte> list_6 = new List<sbyte>(sbyte_0);

		public static readonly sbyte[] sbyte_1 = new sbyte[5] { 0, 9, 2, 17, 4 };

		public static readonly sbyte[] sbyte_2 = new sbyte[5] { 10, 11, 14, 23, 7 };

		public long long_9;

		public GStruct2 gstruct2_0 = default(GStruct2);

		public bool bool_14;

		public int int_13 = 8;

		public int int_14 = 0;

		public int int_15 = 0;

		public int int_16 = 5;

		public int int_17 = 25;

		public List<GClass78> list_7 = new List<GClass78>();

		public int int_18 = 3;

		[CompilerGenerated]
		private List<GInterface1> list_8 = new List<GInterface1>();

		[CompilerGenerated]
		private List<GInterface1> list_9 = new List<GInterface1>();

		public bool bool_15;

		public List<GClass78> list_10 = new List<GClass78>();

		public int int_19;

		public List<GStruct3> list_11 = new List<GStruct3>();

		public int int_20 = 0;

		public bool bool_16;

		public bool bool_17 = false;

		public long long_10;

		public bool bool_18;

		public bool bool_19 = true;

		public bool bool_20;

		public long long_11;

		public bool bool_21 = false;

		public List<GInterface1> List_0
		{
			[CompilerGenerated]
			get
			{
				return list_8;
			}
			[CompilerGenerated]
			private set
			{
				list_8 = value;
			}
		}

		public List<GInterface1> List_1
		{
			[CompilerGenerated]
			get
			{
				return list_9;
			}
			[CompilerGenerated]
			private set
			{
				list_9 = value;
			}
		}

		public static GClass159 smethod_0()
		{
			return (gclass159_0 != null) ? gclass159_0 : (gclass159_0 = new GClass159());
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
			if (GClass91.smethod_0().gclass191_0.method_21() != null && !GClass91.smethod_0().gclass191_0.method_21().Equals("") && !text.Equals("") && text != null)
			{
				if (GClass91.smethod_0().string_1.Equals((GClass151.int_0 != 0) ? "Fill % HP use porata" : "Nhập % HP sử dụng bông tai"))
				{
					method_3($"/abt{int.Parse(GClass91.smethod_0().gclass191_0.method_21())}");
					method_0();
				}
				else if (!GClass91.smethod_0().string_1.Equals((GClass151.int_0 != 0) ? "Fill %HP,%KI use porata" : "Nhập %HP,%KI sử dụng bông tai"))
				{
					if (!GClass91.smethod_0().string_1.Equals((GClass151.int_0 != 0) ? "Put time delay use item (ms)" : "Nhập độ trễ sử dụng item (ms)"))
					{
						if (!GClass91.smethod_0().string_1.Equals((GClass151.int_0 == 0) ? "Đồ sát nhân vật dưới mức HP" : "Murdering character have the HP lower than setting"))
						{
							if (GClass91.smethod_0().string_1.Equals((GClass151.int_0 != 0) ? "Fill auto global chat content!" : "Nhập nội dung auto chat thế giới !") && GClass91.smethod_0().gclass191_0.method_21() != "")
							{
								string_1 = GClass91.smethod_0().gclass191_0.method_21();
								bool_13 = true;
								GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto global Chat: " + GClass154.smethod_0().method_6(bool_13)) : ("Auto chat thế giới: " + GClass154.smethod_0().method_6(bool_13)), 0);
								method_0();
							}
						}
						else
						{
							int_1 = int.Parse(GClass91.smethod_0().gclass191_0.method_21());
							method_0();
						}
					}
					else
					{
						GClass160.smethod_0().long_9 = long.Parse(GClass91.smethod_0().gclass191_0.method_21());
						method_0();
					}
				}
				else
				{
					method_3("/abt" + GClass91.smethod_0().gclass191_0.method_21());
					method_0();
				}
			}
			else
				GClass91.smethod_0().bool_0 = false;
			method_0();
		}

		public void method_1(string text)
		{
			GClass91.smethod_0().string_1 = text;
			GClass91.smethod_0().gclass191_0.string_7 = mResources.CHAT;
			GClass73.gclass76_0.bool_0 = false;
			GClass91.smethod_0().method_5(smethod_0(), "");
		}

		public void perform(int idAction, object p)
		{
			if (GClass148.smethod_0().bool_0 || smethod_0().bool_18)
				return;
			if (idAction <= 10249)
			{
				switch (idAction)
				{
				case 10002:
				{
					GClass88 gClass4 = new GClass88();
					gClass4.method_0(new GClass87((GClass151.int_0 != 0) ? ("Auto change\nobject:\n" + GClass154.smethod_0().method_7(GClass158.smethod_0().bool_1)) : ("Tự động\nđổi m.tiêu:\n" + GClass154.smethod_0().method_7(GClass158.smethod_0().bool_1)), this, 101301, null));
					for (int j = 0; j < GClass78.smethod_1().gclass128_0.Length; j++)
					{
						GClass128 gClass5 = GClass78.smethod_1().gclass128_0[j];
						if (gClass5 != null && (gClass5.gclass117_0.short_0 == short_0 || gClass5.gclass117_0.short_0 == short_1))
							gClass4.method_0(new GClass87($"Auto Porata\nHP: [{int_8}%]\nKI: [{int_9}%]", this, 101302, null));
					}
					GClass73.gclass145_0.bool_1 = true;
					gClass4.method_0(new GClass87((GClass151.int_0 != 0) ? ("Auto pick\nscrolls\n" + GClass154.smethod_0().method_7(GClass166.list_3.Contains(590))) : ("Tự động\nnhặt b.kíp\n" + GClass154.smethod_0().method_7(GClass166.list_3.Contains(590))), this, 101303, null));
					GClass73.gclass145_0.method_2(gClass4, 0);
					return;
				}
				case 10005:
				{
					GClass88 gClass3 = new GClass88();
					gClass3.method_0(new GClass87((GClass151.int_0 != 0) ? ("Show List\nCharacters:\n" + GClass154.smethod_0().method_7(bool_14)) : ("H.thị d.s\nNhân vật:\n" + GClass154.smethod_0().method_7(bool_14)), this, 101601, null));
					gClass3.method_0(new GClass87((GClass151.int_0 == 0) ? ("C.độ h.thị\nD.s n.vật:\n" + ((int_18 == 1) ? "màu cờ" : ((int_18 == 2) ? "Bang hội" : "Mặc định"))) : ("Mode Show\nList Chars:\n" + ((int_18 == 1) ? "Flag Color" : ((int_18 == 2) ? "Clan Name" : "Default"))), this, 101602, null));
					gClass3.method_0(new GClass87((GClass151.int_0 == 0) ? ("Thông tin\nđối tượng:\n" + GClass154.smethod_0().method_7(GClass170.smethod_0().bool_0)) : ("Object Focus\nInformations:\n" + GClass154.smethod_0().method_7(GClass170.smethod_0().bool_0)), this, 101603, null));
					gClass3.method_0(new GClass87((GClass151.int_0 != 0) ? ("Auto Revive:\n" + GClass154.smethod_0().method_7(bool_9)) : ("Tự động\nhồi sinh:\n" + GClass154.smethod_0().method_7(bool_9)), this, 101604, null));
					if (GClass151.bool_3 && GClass78.smethod_1().int_14 == 2)
					{
						if (((GClass78.smethod_1().gclass78_0 != null && GClass153.smethod_0().int_4 == -1) || GClass153.smethod_0().int_4 != -1) && GClass78.smethod_1().int_14 == 2)
							gClass3.method_0(new GClass87((GClass151.int_0 != 0) ? string.Format("Lock.Position\n[{0}]\n[{1}]:\n{2}", (GClass153.smethod_0().int_4 != -1) ? GClass153.smethod_0().string_0 : (GClass78.smethod_1().gclass78_0.string_3.Contains("]") ? GClass78.smethod_1().gclass78_0.string_3.Split(']')[1].Trim() : GClass78.smethod_1().gclass78_0.string_3), (GClass153.smethod_0().int_4 != -1) ? GClass153.smethod_0().int_4 : GClass78.smethod_1().gclass78_0.int_13, GClass154.smethod_0().method_7(GClass153.smethod_0().int_4 != -1)) : string.Format("Khóa tọa độ\n[{0}]\n[{1}]:\n{2}", (GClass153.smethod_0().int_4 != -1) ? GClass153.smethod_0().string_0 : ((!GClass78.smethod_1().gclass78_0.string_3.Contains("]")) ? GClass78.smethod_1().gclass78_0.string_3 : GClass78.smethod_1().gclass78_0.string_3.Split(']')[1].Trim()), (GClass153.smethod_0().int_4 != -1) ? GClass153.smethod_0().int_4 : GClass78.smethod_1().gclass78_0.int_13, GClass154.smethod_0().method_7(GClass153.smethod_0().int_4 != -1)), this, 101606, null));
						gClass3.method_0(new GClass87((GClass151.int_0 == 0) ? ("Khiên khi\nCapsule bom:\n" + GClass154.smethod_0().method_7(GClass153.smethod_0().bool_8)) : ("Auto Shield\nBefore Bom:\n" + GClass154.smethod_0().method_7(GClass153.smethod_0().bool_8)), this, 101607, null));
					}
					gClass3.method_0(new GClass87((GClass151.int_0 != 0) ? "Func auto\nmuderding\nCharacters" : "Chức năng\nđồ sát\nngười", this, 101608, null));
					GClass73.gclass145_0.bool_1 = true;
					GClass73.gclass145_0.method_2(gClass3, 0);
					return;
				}
				case 10007:
				{
					GClass88 gClass = new GClass88();
					gClass.method_0(new GClass87((GClass151.int_0 == 0) ? ("Tự động\nmở DTDN:\n" + GClass154.smethod_0().method_7(GClass157.smethod_0().bool_4)) : ("Auto open\nOneE.Dungeon:\n" + GClass154.smethod_0().method_7(GClass157.smethod_0().bool_4)), this, 101802, null));
					if (GClass151.int_0 == 0)
						gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ("VietKey:\n" + GClass154.smethod_0().method_7(GClass154.smethod_0().bool_0)) : ("Bộ gõ\ntiếng Việt:\n" + GClass154.smethod_0().method_7(GClass154.smethod_0().bool_0)), this, 101803, null));
					gClass.method_0(new GClass87((GClass151.int_0 == 0) ? ("Auto bán\nđồ rác:\n" + GClass154.smethod_0().method_7(GClass160.smethod_0().bool_3)) : ("Auto sale\ntrash item:\n" + GClass154.smethod_0().method_7(GClass160.smethod_0().bool_3)), this, 101804, null));
					for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
					{
						GClass128 gClass2 = GClass78.smethod_1().gclass128_0[i];
						if (gClass2 != null && (gClass2.gclass117_0.short_0 == short_0 || gClass2.gclass117_0.short_0 == short_1))
							gClass.method_0(new GClass87((GClass151.int_0 != 0) ? ("Fusion after\nlogin:\n" + GClass154.smethod_0().method_7(smethod_0().bool_16)) : ("Hợp thể\nsau login:\n" + GClass154.smethod_0().method_7(smethod_0().bool_16)), this, 101805, null));
					}
					GClass73.gclass145_0.bool_1 = true;
					GClass73.gclass145_0.method_2(gClass, 0);
					return;
				}
				case 10008:
					Class21.smethod_0().method_4();
					return;
				case 10003:
				case 10004:
				case 10006:
					return;
				}
				switch (idAction)
				{
				case 10240:
					smethod_0().bool_7 = !smethod_0().bool_7;
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Murdering Disciple: " + GClass154.smethod_0().method_6(smethod_0().bool_7)) : ("Đồ sát đệ tử: " + GClass154.smethod_0().method_6(smethod_0().bool_7)), 0);
					method_12();
					break;
				case 10241:
					smethod_0().bool_8 = !smethod_0().bool_8;
					GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đồ sát theo clan: " + GClass154.smethod_0().method_6(smethod_0().bool_8)) : ("Murdering clan: " + GClass154.smethod_0().method_6(smethod_0().bool_8)), 0);
					method_12();
					break;
				case 10242:
					if (list_5.Contains(0))
					{
						list_5.Remove(0);
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Removed Earth from list murdering!" : "Xóa TĐ ra khỏi d/s đồ sát!", 0);
					}
					else
					{
						list_5.Add(0);
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Added Earth to list murdering!" : "Thêm TĐ vào d/s đồ sát!", 0);
					}
					method_12();
					break;
				case 10243:
					if (!list_5.Contains(1))
					{
						list_5.Add(1);
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Added Namek to list murdering!" : "Thêm NM vào d/s đồ sát!", 0);
					}
					else
					{
						list_5.Remove(1);
						GClass149.smethod_1((GClass151.int_0 == 0) ? "Xóa NM ra khỏi d/s đồ sát!" : "Removed Namek from list murdering!", 0);
					}
					method_12();
					break;
				case 10244:
					if (list_5.Contains(2))
					{
						list_5.Remove(2);
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Removed Sayda from list murdering!" : "Xóa XD ra khỏi d/s đồ sát!", 0);
					}
					else
					{
						list_5.Add(2);
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Added Sayda to list murdering!" : "Thêm XD vào d/s đồ sát!", 0);
					}
					method_12();
					break;
				case 10245:
					method_1((GClass151.int_0 != 0) ? "Murdering character have the HP lower than setting" : "Đồ sát nhân vật dưới mức HP");
					break;
				case 10246:
					smethod_0().list_1.Clear();
					method_12();
					break;
				case 10247:
					smethod_0().list_2.Clear();
					method_12();
					break;
				case 10248:
					smethod_0().list_0.Clear();
					method_12();
					break;
				case 10249:
					bool_1 = !bool_1;
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Skip char had shield: " + GClass154.smethod_0().method_6(bool_1)) : ("Bỏ qua khiên: " + GClass154.smethod_0().method_6(bool_1)), 0);
					method_12();
					break;
				}
				return;
			}
			switch (idAction)
			{
			case 101301:
				GClass7.smethod_0().method_78("/cobj");
				return;
			case 101302:
				smethod_0().method_1((GClass151.int_0 == 0) ? "Nhập %HP,%KI sử dụng bông tai" : "Fill %HP,%KI use porata");
				return;
			case 101303:
				GClass166.smethod_0().method_9("item", "id", 590);
				GClass166.smethod_0().method_9("item", "id", 74);
				return;
			}
			switch (idAction)
			{
			case 101601:
				method_3("/dsnv");
				return;
			case 101602:
				if (int_18 >= 3)
					int_18 = 1;
				else
					int_18++;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("List Character sorted by: " + ((int_18 == 1) ? "flag color" : ((int_18 == 2) ? "clan name" : "default"))) : ("Danh sách nhân vật sắp xếp theo: " + ((int_18 == 1) ? "màu cờ" : ((int_18 == 2) ? "Tên bang hội" : "Mặc định"))), 1);
				return;
			case 101603:
				method_3("/oinf");
				return;
			case 101604:
				method_3("/ahs");
				return;
			case 101606:
				GClass153.smethod_0().int_4 = ((GClass153.smethod_0().int_4 != -1) ? (-1) : GClass78.smethod_1().gclass78_0.int_13);
				GClass153.smethod_0().string_0 = ((GClass153.smethod_0().int_4 != -1) ? "" : ((!GClass78.smethod_1().gclass78_0.string_3.Contains("]")) ? GClass78.smethod_1().gclass78_0.string_3 : GClass78.smethod_1().gclass78_0.string_3.Split(']')[1].Trim()));
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto follow char when use Capsule Bom: " + GClass154.smethod_0().method_6(GClass153.smethod_0().int_4 != -1)) : ("Tự động ghim khi Capsule Bom: " + GClass154.smethod_0().method_6(GClass153.smethod_0().int_4 != -1)), 0);
				return;
			case 101607:
				GClass153.smethod_0().bool_8 = !GClass153.smethod_0().bool_8;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động dùng khiên trước khi Bom: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_8)) : ("Auto use shield before use Bom: " + GClass154.smethod_0().method_6(GClass153.smethod_0().bool_8)), 0);
				return;
			case 101608:
				method_12();
				return;
			case 101605:
				return;
			}
			switch (idAction)
			{
			case 101802:
				GClass157.smethod_0().bool_4 = !GClass157.smethod_0().bool_4;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động mở DTĐN: " + GClass154.smethod_0().method_7(GClass157.smethod_0().bool_4)) : ("Auto open one eye dungeon: " + GClass154.smethod_0().method_7(GClass157.smethod_0().bool_4)), 0);
				break;
			case 101803:
				GClass154.smethod_0().bool_0 = !GClass154.smethod_0().bool_0;
				VietKeyHandler.VietModeEnabled = GClass154.smethod_0().bool_0;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Unicode: " + GClass154.smethod_0().method_7(GClass154.smethod_0().bool_0)) : ("Vietkey: " + GClass154.smethod_0().method_7(GClass154.smethod_0().bool_0)), 0);
				break;
			case 101804:
				GClass7.smethod_0().method_78("/isell");
				break;
			case 101805:
				smethod_0().bool_16 = !smethod_0().bool_16;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động hợp thể sau khi login: " + GClass154.smethod_0().method_7(smethod_0().bool_16)) : ("Auto fusion after login: " + GClass154.smethod_0().method_7(smethod_0().bool_16)), 0);
				break;
			}
		}

		public bool method_2(int asciiCode)
		{
			if (asciiCode <= 93)
			{
				if (asciiCode > 61)
				{
					if (asciiCode != 91)
					{
						if (asciiCode != 93)
							goto IL_080d;
						if (GClass157.smethod_0().int_0 != -1)
						{
							if (GClass157.smethod_0().int_0 < GClass144.smethod_8().int_61.Length - 1)
								GClass7.smethod_0().method_78($"/kz{GClass20.int_39 + 1}");
							else
								GClass149.smethod_1((GClass151.int_0 == 0) ? $"Khu lớn nhất là [{GClass144.smethod_8().int_61.Length - 1}]" : $"Maximum zone is [{GClass144.smethod_8().int_61.Length - 1}]", 0);
						}
						else
							GClass7.smethod_0().method_78($"/kz{((GClass20.int_39 == 0) ? GClass20.int_39 : (GClass20.int_39 + 1))}");
					}
					else if (GClass157.smethod_0().int_0 != -1)
					{
						if (GClass157.smethod_0().int_0 > 0)
							GClass7.smethod_0().method_78($"/kz{GClass20.int_39 - 1}");
						else
							GClass149.smethod_1((GClass151.int_0 == 0) ? "Khu bé nhất là [0]" : "Minimum zone is [0]", 0);
					}
					else
					{
						GClass7.smethod_0().method_78($"/kz{((GClass20.int_39 == 0) ? GClass20.int_39 : (GClass20.int_39 - 1))}");
					}
				}
				else
				{
					switch (asciiCode)
					{
					case 44:
						goto IL_0207;
					case 46:
						goto IL_021b;
					case 47:
						goto IL_022f;
					case 45:
						goto IL_080d;
					}
					if (asciiCode != 61)
						goto IL_080d;
					GClass109.smethod_1().method_35();
					GClass78.smethod_1().gclass29_0 = null;
					GClass73.smethod_49();
					GClass73.gclass76_1 = new GClass76();
					GClass73.gclass76_1.method_50();
					GClass73.gclass76_0.method_34();
					GClass73.gclass76_0.method_50();
				}
			}
			else if (asciiCode <= 109)
			{
				switch (asciiCode)
				{
				case 98:
					goto IL_0426;
				case 102:
					goto IL_0437;
				case 103:
					goto IL_04e2;
				case 104:
					goto IL_0532;
				case 105:
					goto IL_0598;
				case 99:
				case 100:
				case 101:
					goto IL_080d;
				}
				if (asciiCode != 109)
					goto IL_080d;
				GClass88 gClass = new GClass88();
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nTrain quái" : "Function\nTrain mob", GClass166.smethod_0(), 10000, null));
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\n Săn Boss" : "Function\nBoss", GClass158.smethod_0(), 10001, null));
				gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nSupport\nYardart" : "Chức năng\nUp Bí kíp\nYardart", smethod_0(), 10002, null));
				gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nSupport\nDisciple" : "Chức năng\nHỗ trợ\nUp Đệ tử", GClass168.smethod_0(), 10003, null));
				gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nSkill" : "Chức năng\nSkill", GClass164.smethod_0(), 10004, null));
				gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Function\nSupport\nPK/BSDB" : "Chức năng\nHỗ trợ\nPK/NRSĐ", smethod_0(), 10005, null));
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nMap" : "Function\nMap", GClass157.smethod_0(), 10006, null));
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Chức năng\nkhác..." : "Another\nFunction...", smethod_0(), 10007, null));
				gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "AutoNextmap\nFunction..." : "Chức năng\nNextMap", smethod_0(), 10008, null));
				GClass73.gclass145_0.bool_1 = true;
				GClass73.gclass145_0.method_2(gClass, 0);
			}
			else if (asciiCode != 113)
			{
				switch (asciiCode)
				{
				case 118:
					break;
				case 119:
					goto IL_07cf;
				default:
					goto IL_080d;
				case 122:
					goto IL_0815;
				}
				GClass78 gClass2 = GClass78.smethod_1();
				if (gClass2.gclass78_0 != null)
				{
					gClass2.int_4 = gClass2.gclass78_0.int_4;
					gClass2.int_5 = gClass2.gclass78_0.int_5;
					GClass7.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass78_0.int_4;
					gClass2.int_5 = gClass2.gclass78_0.int_5 + 1;
					GClass7.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass78_0.int_4;
					gClass2.int_5 = gClass2.gclass78_0.int_5;
					GClass7.smethod_0().method_44();
				}
				else if (gClass2.gclass194_0 != null)
				{
					gClass2.int_4 = gClass2.gclass194_0.int_8 - 24;
					gClass2.int_5 = gClass2.gclass194_0.int_9;
					GClass7.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass194_0.int_8;
					gClass2.int_5 = gClass2.gclass194_0.int_9;
					GClass7.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass194_0.int_8 - 24;
					gClass2.int_5 = gClass2.gclass194_0.int_9;
					GClass7.smethod_0().method_44();
				}
				else if (gClass2.gclass79_0 != null)
				{
					gClass2.int_4 = gClass2.gclass79_0.int_4;
					gClass2.int_5 = gClass2.gclass79_0.int_5 - 3;
					GClass7.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass79_0.int_4;
					gClass2.int_5 = gClass2.gclass79_0.int_5;
					GClass7.smethod_0().method_44();
					gClass2.int_4 = gClass2.gclass79_0.int_4;
					gClass2.int_5 = gClass2.gclass79_0.int_5 - 3;
					GClass7.smethod_0().method_44();
				}
			}
			else
			{
				if (GClass150.smethod_0().bool_0)
				{
					GClass150.smethod_0().method_2(new vMessage
					{
						cmd = 3,
						data = Encoding.ASCII.GetBytes(GClass150.int_0.ToString())
					});
					GClass150.smethod_0().bool_2 = false;
					GClass150.smethod_0().bool_0 = false;
				}
				else
				{
					GClass150.smethod_0().method_0(GClass172.int_0);
					GClass150.smethod_0().bool_0 = true;
				}
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Connect to game mannager: " + GClass154.smethod_0().method_6(GClass150.smethod_0().bool_0)) : ("Liên kết với QLTK: " + GClass154.smethod_0().method_6(GClass150.smethod_0().bool_0)), 0);
			}
			goto IL_08fb;
			IL_08fb:
			return true;
			IL_0207:
			GClass7.smethod_0().method_78("/optm");
			goto IL_08fb;
			IL_04e2:
			if (GClass153.smethod_0().method_6())
			{
				GClass166.smethod_0().bool_5 = false;
				GClass7.smethod_0().method_42(GClass20.int_39, -1);
			}
			else
				GClass7.smethod_0().method_6(0, GClass78.smethod_1().gclass78_0.int_13, -1, -1);
			goto IL_08fb;
			IL_022f:
			GClass91.smethod_0().method_3(47, GClass144.smethod_8(), "");
			goto IL_08fb;
			IL_07cf:
			if (!method_50())
				new Thread((ThreadStart)delegate
				{
					method_48();
				}).Start();
			else
				new Thread((ThreadStart)delegate
				{
					method_46();
				}).Start();
			goto IL_08fb;
			IL_0437:
			if (GClass78.smethod_1().bool_38)
			{
				for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
				{
					GClass128 gClass3 = GClass78.smethod_1().gclass128_0[i];
					if (gClass3 != null && (gClass3.gclass117_0.short_0 == 454 || gClass3.gclass117_0.short_0 == 921))
						GClass7.smethod_0().method_20(0, 1, -1, gClass3.gclass117_0.short_0);
				}
			}
			else
				GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? "Mày làm đéo gì có đệ tử?" : "You don't have the fucking disciple to use this function!", 0);
			goto IL_08fb;
			IL_0598:
			method_21(-1);
			goto IL_08fb;
			IL_0815:
			GClass73.gclass76_1 = new GClass76();
			GClass73.gclass76_1.method_50();
			GClass73.gclass76_0.method_41();
			GClass73.gclass76_0.method_50();
			goto IL_08fb;
			IL_0426:
			GClass7.smethod_0().method_13(0, -1);
			goto IL_08fb;
			IL_021b:
			GClass7.smethod_0().method_78("/hide");
			goto IL_08fb;
			IL_0532:
			for (int j = 0; j < GClass78.smethod_1().gclass128_0.Length; j++)
			{
				GClass128 gClass4 = GClass78.smethod_1().gclass128_0[j];
				if (gClass4 != null && gClass4.gclass117_0.short_0 == 521)
					GClass7.smethod_0().method_20(0, 1, -1, gClass4.gclass117_0.short_0);
			}
			goto IL_08fb;
			IL_080d:
			return false;
		}


        public bool method_3(string text)
        {
            switch (text)
            {
                case "/alg":
                    GClass172.smethod_0().bool_0 = !GClass172.smethod_0().bool_0;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto Login: " + GClass154.smethod_0().method_6(GClass172.smethod_0().bool_0)) : ("Tự động Login: " + GClass154.smethod_0().method_6(GClass172.smethod_0().bool_0)), 0);
                    break;
                case "/blockchar":
                    method_11("block_id", -1);
                    break;
                case "/hdsd":
                    Class16.k4qKbAJZyI().method_3();
                    break;
                case "/vqtd":
                    if (GClass20.int_37 == 45)
                        GClass155.smethod_0().method_3();
                    break;
                case "/ahs":
                    smethod_0().bool_9 = !smethod_0().bool_9;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto revive: " + GClass154.smethod_0().method_6(smethod_0().bool_9)) : ("Tự động dùng ngọc hồi sinh: " + GClass154.smethod_0().method_6(smethod_0().bool_9)), 0);
                    break;
                case "/dsnv":
                    smethod_0().bool_14 = !smethod_0().bool_14;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("List Character: " + GClass154.smethod_0().method_6(smethod_0().bool_14)) : ("Danh sách nhân vật: " + GClass154.smethod_0().method_6(smethod_0().bool_14)), 0);
                    break;
                case "/actg":
                    if (bool_13)
                    {
                        bool_13 = false;
                        string_1 = string.Empty;
                        GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto global Chat: " + GClass154.smethod_0().method_6(bool_13)) : ("Auto chat thế giới: " + GClass154.smethod_0().method_6(bool_13)), 0);
                    }
                    else
                        method_1((GClass151.int_0 != 0) ? "Fill auto global chat content!" : "Nhập nội dung auto chat thế giới !");
                    break;
                case "/hide":
                    GClass167.smethod_0().bool_3 = !GClass167.smethod_0().bool_3;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Ẩn thông tin: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_3)) : ("Hide information: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_3)), 0);
                    break;
                case "/unikey":
                    GClass154.smethod_0().bool_0 = !GClass154.smethod_0().bool_0;
                    GClass149.smethod_1((GClass151.int_0 != 0) ? ("Vietkey: " + GClass154.smethod_0().method_6(GClass154.smethod_0().bool_0)) : ("Unicode: " + GClass154.smethod_0().method_6(GClass154.smethod_0().bool_0)), 0);
                    break;
                case "/dsnskill":
                    method_4();
                    break;
                case "/optm":
                    GClass167.smethod_0().bool_20 = !GClass167.smethod_0().bool_20;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tối ưu CPU: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_20)) : ((GClass151.int_0 == 0) ? ("Tối ưu CPU: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_20)) : ("Optimize CPU: " + GClass154.smethod_0().method_6(GClass167.smethod_0().bool_20))), 0);
                    break;
                case "/oinf":
                    GClass170.smethod_0().bool_0 = !GClass170.smethod_0().bool_0;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Hiển thị thông tin đối tượng: " + GClass154.smethod_0().method_6(GClass170.smethod_0().bool_0)) : ("Show object informations: " + GClass154.smethod_0().method_6(GClass170.smethod_0().bool_0)), 0);
                    break;
                case "/achat_":
                    bool_12 = false;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Auto chat: " + GClass154.smethod_0().method_6(bool_12)) : ("Auto chat: " + GClass154.smethod_0().method_6(bool_12)), 0);
                    break;
                case "/afriend":
                    if (GClass78.smethod_1().gclass78_0 != null)
                        GClass7.smethod_0().method_13(1, GClass78.smethod_1().gclass78_0.int_13);
                    break;
                case "/addclan":
                    method_11("clan_id", -1);
                    break;
                case "/writemap":
                {
                    string text2 = string.Empty;
                    for (int m = 0; m < 165; m++)
                    {
                        text2 = text2 + Class21.smethod_0().method_6(m) + "|";
                    }
                    File.WriteAllText("ListMapName.txt", text2);
                    break;
                }
                case "/showlog":
                    if (GClass151.string_3.Contains("username:0FE1B45A337DC3C74A9FBCFC1F109B25") || GClass151.string_3.Contains("1C07AFE652D939F16E9D5E0A6ACFE6FD") || GClass151.string_3.Contains("21232F297A57A5A743894A0E4A801FC3"))
                    {
                        bool_0 = !bool_0;
                        GClass149.smethod_1((GClass151.int_0 == 0) ? ("Auto write log thế giới: " + GClass154.smethod_0().method_6(bool_0)) : ("Auto write log global: " + GClass154.smethod_0().method_6(bool_0)), 0);
                    }
                    break;
                case "/blockclan":
                    method_11("block_clan_id", -1);
                    break;
                case "/autowhis":
                    bool_18 = !bool_18;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động thách đấu Whis: " + GClass154.smethod_0().method_6(bool_18)) : ("Auto challenge Whis: " + GClass154.smethod_0().method_6(bool_18)), 0);
                    break;
                case "/kmt":
                    method_21(-1);
                    break;
                case "/addchar":
                    method_11("char_id", -1);
                    break;
                case "/dsnskillclr":
                    GClass158.smethod_0().method_17();
                    break;
                default:
                    if (GClass154.smethod_0().method_11<string>(text, "/addchar"))
                    {
                        if (!GClass154.smethod_0().method_12<string>(text, "/addchar").Contains(","))
                        {
                            method_11("char_id", int.Parse(GClass154.smethod_0().method_12<string>(text, "/addchar")));
                        }
                        else
                        {
                            string[] array5 = GClass154.smethod_0().method_12<string>(text, "/addchar").Split(',');
                            for (int l = 0; l < array5.Length; l++)
                            {
                                method_11("char_id", int.Parse(array5[l]));
                            }
                        }
                    }
                    else
                    {
                        if (GClass154.smethod_0().method_11<int>(text, "/charhp"))
                        {
                            int_1 = GClass154.smethod_0().method_12<int>(text, "/charhp");
                            GClass149.smethod_1((GClass151.int_0 == 0) ? ((int_1 == 0) ? "Tắt giới hạn HP người" : (("Chỉ đánh người dưới " + GClass65.smethod_9(int_1) + " HP") ?? "")) : ((int_1 == 0) ? "Turn off limited Character HP" : (("Only attack character have HP lower than " + GClass65.smethod_9(int_1) + " HP") ?? "")), 0);
                        }
                        else
                        {
                            if (GClass154.smethod_0().method_11<int>(text, "/tele"))
                            {
                                int_5 = GClass154.smethod_0().method_12<int>(text, "/tele");
                                bool_5 = ((int_5 != -1) ? true : false);
                            }
                            else
                            {
                                if (GClass154.smethod_0().method_11<string>(text, "/blockchar"))
                                {
                                    if (!GClass154.smethod_0().method_12<string>(text, "/blockchar").Contains(","))
                                    {
                                        method_11("block_id", int.Parse(GClass154.smethod_0().method_12<string>(text, "/blockchar")));
                                    }
                                    else
                                    {
                                        string[] array4 = GClass154.smethod_0().method_12<string>(text, "/blockchar").Split(',');
                                        for (int k = 0; k < array4.Length; k++)
                                        {
                                            method_11("block_id", int.Parse(array4[k]));
                                        }
                                    }
                                }
                                else
                                {
                                    if (GClass154.smethod_0().method_11<int>(text, "/afriend"))
                                        GClass7.smethod_0().method_13(1, GClass154.smethod_0().method_12<int>(text, "/afriend"));
                                    else
                                    {
                                        if (GClass154.smethod_0().method_11<string>(text, "/addclan"))
                                        {
                                            if (!GClass154.smethod_0().method_12<string>(text, "/addclan").Contains(","))
                                            {
                                                method_11("clan_id", int.Parse(GClass154.smethod_0().method_12<string>(text, "/addclan")));
                                                break;
                                            }
                                            string[] array = GClass154.smethod_0().method_12<string>(text, "/addclan").Split(',');
                                            for (int i = 0; i < array.Length; i++)
                                            {
                                                method_11("clan_id", int.Parse(array[i]));
                                            }
                                        }
                                        else if (!GClass154.smethod_0().method_11<string>(text, "/blockclan"))
                                        {
                                            if (GClass154.smethod_0().method_11<int>(text, "/kmt"))
                                                method_21(GClass154.smethod_0().method_12<int>(text, "/kmt"));
                                            else if (!GClass154.smethod_0().method_11<int>(text, "/rspeed"))
                                            {
                                                if (GClass154.smethod_0().method_11<float>(text, "/gspeed"))
                                                {
                                                    if (GClass154.smethod_0().method_12<float>(text, "/gspeed") == 0f)
                                                    {
                                                        GClass149.smethod_1((GClass151.int_0 != 0) ? "Game speed can not equal to 0" : "Tốc độ game không thể bằng 0", 0);
                                                        break;
                                                    }
                                                    Time.timeScale = GClass154.smethod_0().method_12<float>(text, "/gspeed");
                                                    GClass149.smethod_1((GClass151.int_0 == 0) ? $"Tốc độ game {Time.timeScale}" : $"Game speed {Time.timeScale}", 0);
                                                }
                                                else if (GClass154.smethod_0().method_11<int>(text, "/r"))
                                                {
                                                    GClass78.smethod_1().int_4 += GClass154.smethod_0().method_12<int>(text, "/r");
                                                    GClass149.smethod_1((GClass151.int_0 == 0) ? "Dịch sang phải" : "Go to right", 0);
                                                }
                                                else if (!GClass154.smethod_0().method_11<int>(text, "/l"))
                                                {
                                                    if (!GClass154.smethod_0().method_11<int>(text, "/u"))
                                                    {
                                                        if (!GClass154.smethod_0().method_11<int>(text, "/d"))
                                                        {
                                                            if (!GClass154.smethod_0().method_11<int>(text, "/hp"))
                                                            {
                                                                if (GClass154.smethod_0().method_11<int>(text, "/mp"))
                                                                {
                                                                    int_7[1] = GClass154.smethod_0().method_12<int>(text, "/mp");
                                                                    bool_10 = true;
                                                                }
                                                                else if (GClass154.smethod_0().method_11<int>(text, "/dmg"))
                                                                {
                                                                    int_7[2] = GClass154.smethod_0().method_12<int>(text, "/dmg");
                                                                    bool_10 = true;
                                                                }
                                                                else if (GClass154.smethod_0().method_10<int>(text, "/abt", 2))
                                                                {
                                                                    int[] array2 = GClass154.smethod_0().method_8<int>(text, "/abt", 2);
                                                                    if (array2[0] > 0)
                                                                    {
                                                                        int_8 = array2[0];
                                                                        GClass149.smethod_1((GClass151.int_0 != 0) ? $"Auto use porata when HP lower than [{int_8}%] HP!" : $"Tự động dùng bông tai khi dưới [{int_8}%] HP!", 0);
                                                                    }
                                                                    else
                                                                    {
                                                                        int_8 = array2[0];
                                                                        GClass149.smethod_1((GClass151.int_0 == 0) ? "Tắt tự động dùng bông tai theo % HP" : "Turn off auto use porata by percent HP", 0);
                                                                    }
                                                                    if (array2[1] <= 0)
                                                                    {
                                                                        int_9 = array2[1];
                                                                        GClass149.smethod_1((GClass151.int_0 != 0) ? "Turn off auto use porata by percent KI" : "Tắt tự động dùng bông tai theo % KI", 0);
                                                                    }
                                                                    else
                                                                    {
                                                                        int_9 = array2[1];
                                                                        GClass149.smethod_1((GClass151.int_0 != 0) ? $"Auto use porata when KI lower than [{int_9}%] KI!" : $"Tự động dùng bông tai khi dưới [{int_9}%] KI!", 0);
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (!GClass154.smethod_0().method_11<string>(text, "/achat_"))
                                                                        return false;
                                                                    string_0 = GClass154.smethod_0().method_12<string>(text, "/achat_");
                                                                    if (!(string_0 == ""))
                                                                    {
                                                                        bool_12 = true;
                                                                        GClass149.smethod_1((GClass151.int_0 == 0) ? ("Auto chat: " + GClass154.smethod_0().method_6(bool_12)) : ("Auto chat: " + GClass154.smethod_0().method_6(bool_12)), 0);
                                                                    }
                                                                    else
                                                                        GClass149.smethod_1((GClass151.int_0 == 0) ? ("Auto chat: " + GClass154.smethod_0().method_6(bool_12)) : ("Auto chat: " + GClass154.smethod_0().method_6(bool_12)), 0);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                int_7[0] = GClass154.smethod_0().method_12<int>(text, "/hp");
                                                                bool_10 = true;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            GClass78.smethod_1().int_5 += GClass154.smethod_0().method_12<int>(text, "/d");
                                                            GClass149.smethod_1((GClass151.int_0 != 0) ? "Go down" : "Dịch xuống dưới", 0);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        GClass78.smethod_1().int_5 -= GClass154.smethod_0().method_12<int>(text, "/u");
                                                        GClass149.smethod_1((GClass151.int_0 == 0) ? "Dịch lên trên" : "Go up", 0);
                                                    }
                                                }
                                                else
                                                {
                                                    GClass78.smethod_1().int_4 -= GClass154.smethod_0().method_12<int>(text, "/l");
                                                    GClass149.smethod_1((GClass151.int_0 == 0) ? "Dịch sang trái" : "Go to left", 0);
                                                }
                                            }
                                            else
                                            {
                                                int_0 = GClass154.smethod_0().method_12<int>(text, "/rspeed");
                                                GClass149.smethod_1((GClass151.int_0 != 0) ? $"Run speed {int_0}" : $"Tốc độ chạy {int_0}", 0);
                                            }
                                        }
                                        else if (GClass154.smethod_0().method_12<string>(text, "/blockclan").Contains(","))
                                        {
                                            string[] array3 = GClass154.smethod_0().method_12<string>(text, "/blockclan").Split(',');
                                            for (int j = 0; j < array3.Length; j++)
                                            {
                                                method_11("block_clan_id", int.Parse(array3[j]));
                                            }
                                        }
                                        else
                                        {
                                            method_11("block_clan_id", int.Parse(GClass154.smethod_0().method_12<string>(text, "/blockclan")));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "/dsn":
                    smethod_0().bool_6 = !smethod_0().bool_6;
                    GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đồ sát người: " + GClass154.smethod_0().method_6(smethod_0().bool_6)) : ("Murdering character: " + GClass154.smethod_0().method_6(smethod_0().bool_6)), 0);
                    break;
            }
            return true;
        }

        public void method_4()
		{
			if (GClass78.smethod_1().gclass63_0 != null)
			{
				GClass63 gclass63_ = GClass78.smethod_1().gclass63_0;
				if (list_6.Contains(gclass63_.gclass47_0.sbyte_0))
				{
					list_6.Remove(gclass63_.gclass47_0.sbyte_0);
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Deleted skill: " + gclass63_.gclass47_0.string_0) : ("Đã xóa skill: " + gclass63_.gclass47_0.string_0), 0);
				}
				else
				{
					list_6.Add(gclass63_.gclass47_0.sbyte_0);
					GClass149.smethod_1((GClass151.int_0 == 0) ? ("Đã thêm skill: " + gclass63_.gclass47_0.string_0) : ("Added skill: " + gclass63_.gclass47_0.string_0), 0);
				}
			}
		}

		public void method_5()
		{
			method_52();
			method_38();
			method_51();
			if (GClass203.smethod_18() - long_5 > 1800000L)
			{
				GClass144.gclass52_0.method_7((GClass151.int_0 != 0) ? ("You are using Dragon Ball Pro v" + GClass151.string_2 + " by ThanhLc. Have fun playing the game!") : ("Bạn đang sử dụng Dragon Ball Pro v" + GClass151.string_2 + " by ThanhLc. Chúc bạn chơi game vui vẻ!"), 0);
				long_5 = GClass203.smethod_18();
			}
			method_40();
			GClass78.smethod_1().int_18 = int_0;
			GClass170.smethod_0().method_2();
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

		public void method_6(GClass122 g)
		{
			method_34(g);
			method_7(g);
			GClass170.smethod_0().method_4(g);
			method_33(g);
		}

		public void method_7(GClass122 g)
		{
			try
			{
				if (bool_3)
				{
					for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
					{
						GClass78 gClass = (GClass78)GClass144.gclass88_5.method_3(i);
						if (!gClass.bool_54 && gClass.int_13 == int_2 && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) > 20)
						{
							g.method_17(Color.red);
							g.method_11(GClass78.smethod_1().int_4 - GClass144.int_22, GClass78.smethod_1().int_5 - GClass144.int_23, gClass.int_4 - GClass144.int_22, gClass.int_5 - GClass144.int_23);
						}
					}
				}
				if (!bool_2)
					return;
				for (int j = 0; j < GClass144.gclass88_9.method_2(); j++)
				{
					GClass194 gClass2 = (GClass194)GClass144.gclass88_9.method_3(j);
					if (gClass2.int_25 == int_3 && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass2.int_8, gClass2.int_9) > 20)
					{
						g.method_17(Color.red);
						g.method_11(GClass78.smethod_1().int_4 - GClass144.int_22, GClass78.smethod_1().int_5 - GClass144.int_23, gClass2.int_8 - GClass144.int_22, gClass2.int_9 - GClass144.int_23);
					}
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/paintLockFocus.txt", ex.ToString());
			}
		}

		public void method_8()
		{
			if (GClass151.string_3.Split(',')[0].Contains("username:21232F297A57A5A743894A0E4A801FC3"))
				return;
			if (GClass78.smethod_1().gclass78_0 != null && int_12.Contains(GClass78.smethod_1().gclass78_0.int_13) && GClass78.smethod_1().gclass78_0.int_56 > 0 && GClass78.smethod_1().gclass78_0.int_56 == 1443676 && GClass164.smethod_3(GClass78.smethod_1().gclass78_0) && GClass78.smethod_1().gclass78_0.sbyte_19 != 0)
				GClass78.smethod_1().gclass78_0.sbyte_19 = 0;
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				if (GClass144.gclass88_5.method_3(i) is GClass78 gClass && gClass.int_13 > 0 && int_12.Contains(gClass.int_13) && gClass.int_56 > 0 && gClass.int_56 == 1443676 && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) < 180 && GClass203.smethod_18() - long_8 > 5000L)
				{
					GClass7.smethod_0().method_78("ThanhLc đẹp trai!! em yêu anh <3");
					long_8 = GClass203.smethod_18();
				}
			}
		}

		public void method_9()
		{
			if (!bool_13)
				return;
			if (GClass78.smethod_1().method_145() < 5)
			{
				bool_13 = false;
				GClass149.smethod_1((GClass151.int_0 != 0) ? "Not enough gem to use this function!" : "Không đủ ngọc để dùng chức năng này!", 1);
			}
			if (!(string_1 == ""))
			{
				if (int_11 > 10)
					int_11 = 0;
				if (GClass203.smethod_18() - long_6 > 10000L)
				{
					GClass7.smethod_0().method_98($"lct{int_11}: {string_1}");
					int_11++;
					long_6 = GClass203.smethod_18();
				}
			}
		}

		public void method_10()
		{
			if (bool_12 && string_0 != "" && GClass203.smethod_18() - long_4 > 5000L)
			{
				GClass7.smethod_0().method_78(string_0);
				long_4 = GClass203.smethod_18();
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
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa ID: [{index}]" : $"Removed ID: [{index}]", 0);
					}
					else
					{
						smethod_0().list_0.Add(index);
						GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added ID: [{index}]" : $"Đã thêm ID: [{index}]", 0);
					}
				}
				else
				{
					if (GClass78.smethod_1().gclass78_0 == null)
						break;
					GClass78 gclass78_2 = GClass78.smethod_1().gclass78_0;
					if (gclass78_2.int_56 > 0)
					{
						if (!smethod_0().list_0.Contains(gclass78_2.int_56))
						{
							smethod_0().list_0.Add(gclass78_2.int_56);
							GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added ID: [{gclass78_2.int_56}]" : $"Đã thêm ID: [{gclass78_2.int_56}]", 0);
						}
						else
						{
							smethod_0().list_0.Remove(gclass78_2.int_56);
							GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa ID: [{gclass78_2.int_56}]" : $"Removed ID: [{gclass78_2.int_56}]", 0);
						}
					}
				}
				break;
			case "block_clan_id":
				if (index != -1)
				{
					if (smethod_0().list_3.Contains(index))
					{
						smethod_0().list_3.Remove(index);
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa clanID: [{index}]" : $"Removed clanID: [{index}]", 0);
					}
					else
					{
						smethod_0().list_3.Add(index);
						GClass149.smethod_1($"Đã thêm clanID: [{index}]", 0);
					}
				}
				else if (GClass78.smethod_1().gclass78_0 != null)
				{
					GClass78 gclass78_3 = GClass78.smethod_1().gclass78_0;
					if (!smethod_0().list_3.Contains(gclass78_3.int_56))
					{
						smethod_0().list_3.Add(gclass78_3.int_56);
						GClass149.smethod_1($"Đã thêm clanID: [{gclass78_3.int_56}]", 0);
					}
					else
					{
						smethod_0().list_3.Remove(gclass78_3.int_56);
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa clanID: [{gclass78_3.int_56}]" : $"Removed clanID: [{gclass78_3.int_56}]", 0);
					}
				}
				break;
			case "block_id":
				if (index != -1)
				{
					if (smethod_0().list_2.Contains(index))
					{
						smethod_0().list_2.Remove(index);
						GClass149.smethod_1((GClass151.int_0 != 0) ? $"Removed ID: [{index}]" : $"Đã xóa ID: [{index}]", 0);
					}
					else
					{
						smethod_0().list_2.Add(index);
						GClass149.smethod_1($"Đã thêm ID: [{index}]", 0);
					}
				}
				else if (GClass78.smethod_1().gclass78_0 != null)
				{
					GClass78 gclass78_4 = GClass78.smethod_1().gclass78_0;
					if (smethod_0().list_2.Contains(gclass78_4.int_13))
					{
						smethod_0().list_2.Remove(gclass78_4.int_13);
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa ID: [{gclass78_4.int_13}]" : $"Removed ID: [{gclass78_4.int_13}]", 0);
					}
					else
					{
						smethod_0().list_2.Add(gclass78_4.int_13);
						GClass149.smethod_1($"Đã thêm ID: [{gclass78_4.int_13}]", 0);
					}
				}
				break;
			case "char_id":
				if (index != -1)
				{
					if (smethod_0().list_1.Contains(index))
					{
						smethod_0().list_1.Remove(index);
						GClass149.smethod_1((GClass151.int_0 != 0) ? $"Removed ID: [{index}]" : $"Đã xóa ID: [{index}]", 0);
					}
					else
					{
						smethod_0().list_1.Add(index);
						GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added ID: [{index}]" : $"Đã thêm ID: [{index}]", 0);
					}
				}
				else if (GClass78.smethod_1().gclass78_0 != null)
				{
					GClass78 gclass78_ = GClass78.smethod_1().gclass78_0;
					if (!smethod_0().list_1.Contains(gclass78_.int_13))
					{
						smethod_0().list_1.Add(gclass78_.int_13);
						GClass149.smethod_1((GClass151.int_0 != 0) ? $"Added: [{gclass78_.int_13}]" : $"Đã thêm ID: [{gclass78_.int_13}]", 0);
					}
					else
					{
						smethod_0().list_1.Remove(gclass78_.int_13);
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Đã xóa ID: [{gclass78_.int_13}]" : $"Removed ID: [{gclass78_.int_13}]", 0);
					}
				}
				break;
			}
		}

		public void method_12()
		{
			GClass88 gClass = new GClass88();
			gClass.method_0(new GClass87(((GClass151.int_0 == 0) ? "Đồ sát\nĐệ tử\n" : "Murdering\nDisciple\n") + GClass154.smethod_0().method_7(bool_7), smethod_0(), 10240, null));
			gClass.method_0(new GClass87(((GClass151.int_0 == 0) ? "Đồ sát\nclan\n" : "Murdering\nclan\n") + GClass154.smethod_0().method_7(bool_8), smethod_0(), 10241, null));
			gClass.method_0(new GClass87(((GClass151.int_0 == 0) ? "Đồ sát\nTrái đất\n" : "Murdering\nEarth\n") + GClass154.smethod_0().method_7(list_5.Contains(0)), smethod_0(), 10242, null));
			gClass.method_0(new GClass87(((GClass151.int_0 != 0) ? "Murdering\nNamekian\n" : "Đồ sát\nNamec\n") + GClass154.smethod_0().method_7(list_5.Contains(1)), smethod_0(), 10243, null));
			gClass.method_0(new GClass87(((GClass151.int_0 != 0) ? "Murdering\nSaiyan\n" : "Đồ sát\nXayda\n") + GClass154.smethod_0().method_7(list_5.Contains(2)), smethod_0(), 10244, null));
			gClass.method_0(new GClass87((GClass151.int_0 == 0) ? ("Đồ sát\ntheo HP\n " + ((int_1 == 0) ? "Đang tắt" : GClass65.smethod_9(int_1))) : ("Murdering\nby HP\n" + ((int_1 != 0) ? GClass65.smethod_9(int_1) : "Đang tắt")), smethod_0(), 10245, null));
			if (list_1.Count > 0)
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Xóa danh sách charID" : "Delete\nList\nChar ID", smethod_0(), 10246, null));
			if (list_2.Count > 0)
				gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Delete\nList Block\nChar ID" : "Xóa danh sách Block ID", smethod_0(), 10247, null));
			if (list_0.Count > 0)
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Xóa danh sách clan ID" : "Delete\nList\nClan ID", smethod_0(), 10248, null));
			gClass.method_0(new GClass87(((GClass151.int_0 == 0) ? "Bỏ qua\nKhiên\n" : "Skip\nShield\n") + GClass154.smethod_0().method_7(bool_1), smethod_0(), 10249, null));
			GClass73.gclass145_0.method_2(gClass, 0);
		}

		public bool method_13(GClass78 @char)
		{
			if (bool_1 && @char.gclass163_0.bool_5)
				return false;
			if (@char.int_56 != GClass78.smethod_1().int_56)
			{
				if (list_3.Count != 0 && list_3.Contains(@char.int_56))
					return false;
				if (list_2.Count == 0 || !list_2.Contains(@char.int_13))
				{
					if (list_5.Contains(@char.int_14) || list_5.Count <= 0)
					{
						if (list_1.Contains(@char.int_13) || list_1.Count == 0)
						{
							if (list_0.Count == 0 || list_0.Contains(@char.int_56))
							{
								if (bool_7 && (@char.int_13 > 0 || GClass144.smethod_14(-@char.int_13) == null))
									return false;
								return true;
							}
							return false;
						}
						return false;
					}
					return false;
				}
				return false;
			}
			return false;
		}

		public bool method_14(GClass78 @char)
		{
			if (@char.int_56 > 0 && GClass78.smethod_1().int_56 == @char.int_56 && GClass78.smethod_1().int_56 > 0)
				return false;
			if (@char.int_5 >= 50 && @char.int_25 != 0 && (@char.sbyte_28 != GClass78.smethod_1().sbyte_28 || GClass78.smethod_1().sbyte_28 == 8) && @char.sbyte_28 != 0 && (bool_7 || @char.int_13 >= 0))
			{
				if (!method_13(@char))
					return false;
				return true;
			}
			return false;
		}

		public GClass78 method_15()
		{
			GClass78 result = null;
			int num = int.MaxValue;
			GClass78 gClass = GClass78.smethod_1();
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				GClass78 gClass2 = (GClass78)GClass144.gclass88_5.method_3(i);
				int num2 = (gClass2.int_4 - gClass.int_4) * (gClass2.int_4 - gClass.int_4) + (gClass2.int_5 - gClass.int_5) * (gClass2.int_5 - gClass.int_5);
				if (method_14(gClass2) && num2 < num && GClass203.smethod_18() - gClass2.long_14 > 10000L && int_1 == 0)
				{
					result = gClass2;
					num = num2;
				}
				if (method_14(gClass2) && num2 < num && GClass203.smethod_18() - gClass2.long_14 > 10000L && int_1 > 0 && gClass2.int_25 <= int_1)
				{
					result = gClass2;
					num = num2;
				}
			}
			return result;
		}

		public void method_16(object obj)
		{
			GClass78 gClass = (GClass78)obj;
			gClass.long_14 = GClass203.smethod_18();
			gClass.int_144++;
			if (gClass.int_144 > 10)
				gClass.int_144 = 0;
		}

		public void method_17(GClass78 @char)
		{
			@char.int_144 = 0;
		}

		public GClass78 method_18()
		{
			GClass78 result = null;
			long num = GClass203.smethod_18();
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				GClass78 gClass = (GClass78)GClass144.gclass88_5.method_3(i);
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

		public bool method_19(GClass78 @char)
		{
			if (method_13(@char))
				return true;
			return false;
		}

		public static bool smethod_1(GClass63 SkillBetter, GClass63 skill)
		{
			if (SkillBetter == null)
				return false;
			if (smethod_2(SkillBetter))
			{
				bool flag = (SkillBetter.gclass47_0.sbyte_0 == 17 && skill.gclass47_0.sbyte_0 == 2) || (SkillBetter.gclass47_0.sbyte_0 == 9 && skill.gclass47_0.sbyte_0 == 0);
				if (skill != null && skill.int_1 >= SkillBetter.int_1 && !flag)
					return false;
				return true;
			}
			return false;
		}

		public static bool smethod_2(GClass63 skill)
		{
			if (GClass203.smethod_18() - skill.long_1 > skill.int_1)
				skill.bool_0 = false;
			if (!skill.bool_0 || sbyte_1.Contains(skill.gclass47_0.sbyte_0))
			{
				if (!sbyte_2.Contains(skill.gclass47_0.sbyte_0))
				{
					if (GClass78.smethod_1().int_24 < smethod_3(skill))
						return false;
					return true;
				}
				return false;
			}
			return false;
		}

		public static int smethod_3(GClass63 skill)
		{
			if (skill.gclass47_0.int_2 == 2)
				return 1;
			if (skill.gclass47_0.int_2 == 1)
				return skill.int_5 * GClass78.smethod_1().int_36 / 100;
			return skill.int_5;
		}

		public static GClass63 smethod_4()
		{
			GClass63 gClass = null;
			GClass47 gClass2 = new GClass47();
			foreach (sbyte item in list_6)
			{
				gClass2.sbyte_0 = item;
				GClass63 gClass3 = GClass78.smethod_1().method_16(gClass2);
				if (smethod_1(gClass3, gClass))
					gClass = gClass3;
			}
			return gClass;
		}

		public void method_20()
		{
			if (!smethod_0().bool_6 || GClass171.smethod_0().method_1())
				return;
			GClass78 gClass = GClass78.smethod_1();
			if (gClass.int_11 == 14 || gClass.int_25 <= 0)
				return;
			if (!gClass.bool_23)
			{
				gClass.method_104(2);
				bool flag = GClass19.smethod_0(4387);
				if (gClass.gclass78_0 != null && !smethod_0().method_14(gClass.gclass78_0))
					gClass.gclass78_0 = null;
				if (gClass.gclass78_0 == null)
				{
					gClass.gclass78_0 = smethod_0().method_15();
					if (flag && gClass.gclass78_0 != null)
					{
						GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
						GClass78.smethod_1().int_5 = gClass.gclass78_0.int_5;
						GClass7.smethod_0().method_44();
					}
				}
				if (gClass.gclass78_0 != null)
				{
					if (gClass.method_75() == null)
					{
						GClass63 gClass2 = smethod_4();
						if (gClass2 != null && !gClass2.bool_0)
						{
							GClass78 gclass78_ = gClass.gclass78_0;
							if (GClass78.smethod_1().gclass63_0 != gClass2 || GClass78.smethod_1().int_11 == 5 || GClass78.smethod_1().gclass63_0.gclass47_0.int_3 == 3 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 10 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 11 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 20)
								GClass144.smethod_8().method_62(gClass2, false);
							bool flag2 = GClass50.smethod_24(gclass78_.int_4, gclass78_.int_5, gClass.int_4, gClass.int_5) > 48;
							bool flag3 = GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 20;
							if (flag2)
							{
								if (!flag3)
								{
									if (!flag)
									{
										GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
										GClass78.smethod_1().int_5 = gClass.gclass78_0.int_5;
										GClass7.smethod_0().method_44();
										GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
										GClass78.smethod_1().int_5 = gClass.gclass78_0.int_5 + 1;
										GClass7.smethod_0().method_44();
										GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
										GClass78.smethod_1().int_5 = gClass.gclass78_0.int_5;
										GClass7.smethod_0().method_44();
									}
									else if (GClass203.smethod_18() - long_9 > 500L && GClass78.smethod_1().int_11 == 1)
									{
										GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
										GClass78.smethod_1().int_5 = gClass.gclass78_0.int_5;
										GClass7.smethod_0().method_44();
										GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
										GClass78.smethod_1().int_5 = gClass.gclass78_0.int_5 + 1;
										GClass7.smethod_0().method_44();
										GClass78.smethod_1().int_4 = gClass.gclass78_0.int_4;
										GClass78.smethod_1().int_5 = gClass.gclass78_0.int_5;
										GClass7.smethod_0().method_44();
										long_9 = GClass203.smethod_18();
									}
								}
								else
									GClass164.smethod_0().method_15();
								return;
							}
							if (GClass78.smethod_1().int_11 == 5 || GClass78.smethod_1().gclass63_0.gclass47_0.int_3 == 3 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 10 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 11)
								GClass144.smethod_8().method_64(gClass2);
							if (GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 != 20 || GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 20)
								GClass164.smethod_0().method_15();
						}
					}
				}
				else if (!flag)
				{
					GClass78 gClass3 = method_18();
					if (gClass3 != null)
					{
						GClass78.smethod_1().int_4 = gClass3.int_4;
						GClass78.smethod_1().int_5 = gClass3.int_5;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = gClass3.int_4;
						GClass78.smethod_1().int_5 = gClass3.int_5 + 1;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = gClass3.int_4;
						GClass78.smethod_1().int_5 = gClass3.int_5;
						GClass7.smethod_0().method_44();
					}
				}
				GClass171.smethod_0().method_0(251);
			}
			else
				GClass171.smethod_0().method_0(500);
		}

		public void method_21(int type)
		{
			if (type != -1)
			{
				smethod_0().int_2 = type;
				smethod_0().bool_3 = !bool_3;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Khóa nhân vật: " + GClass154.smethod_0().method_6(smethod_0().bool_3)) : ("Lock Character: " + GClass154.smethod_0().method_6(smethod_0().bool_3)), 0);
				return;
			}
			if (GClass78.smethod_1().gclass194_0 != null)
			{
				gstruct2_0.int_0 = -1;
				gstruct2_0.int_1 = -1;
				gstruct2_0.int_2 = -1;
				smethod_0().bool_3 = false;
				smethod_0().int_2 = -1;
				smethod_0().int_3 = GClass78.smethod_1().gclass194_0.int_25;
				smethod_0().bool_2 = !smethod_0().bool_2;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Khóa quái: " + GClass154.smethod_0().method_6(smethod_0().bool_2)) : ("Lock Mob: " + GClass154.smethod_0().method_6(smethod_0().bool_2)), 0);
			}
			if (GClass78.smethod_1().gclass78_0 != null)
			{
				if (!GClass78.smethod_1().gclass78_0.bool_53 && GClass78.smethod_1().gclass78_0.int_13 < 0)
				{
					smethod_0().int_3 = -1;
					smethod_0().bool_2 = false;
					gstruct2_0.int_0 = GClass78.smethod_1().gclass78_0.int_119;
					gstruct2_0.int_1 = GClass78.smethod_1().gclass78_0.int_121;
					gstruct2_0.int_2 = GClass78.smethod_1().gclass78_0.int_120;
					smethod_0().bool_3 = !bool_3;
					GClass149.smethod_1((GClass151.int_0 == 0) ? $"Khóa BOSS [{int_2}]: {GClass154.smethod_0().method_6(smethod_0().bool_3)}" : $"Lock Boss [{int_2}]: {GClass154.smethod_0().method_6(smethod_0().bool_3)}", 0);
				}
				if (GClass78.smethod_1().gclass78_0.int_13 > 0 || (GClass78.smethod_1().gclass78_0.bool_53 && GClass78.smethod_1().gclass78_0.int_13 < 0))
				{
					gstruct2_0.int_0 = -1;
					gstruct2_0.int_1 = -1;
					gstruct2_0.int_2 = -1;
					smethod_0().int_3 = -1;
					smethod_0().bool_2 = false;
					smethod_0().int_2 = GClass78.smethod_1().gclass78_0.int_13;
					smethod_0().bool_3 = !smethod_0().bool_3;
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Lock Character: " + GClass154.smethod_0().method_6(smethod_0().bool_3)) : ("Khóa nhân vật: " + GClass154.smethod_0().method_6(smethod_0().bool_3)), 0);
				}
			}
		}

		public void method_22()
		{
			try
			{
				if (smethod_0().bool_3)
				{
					smethod_0().bool_2 = false;
					for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
					{
						GClass78 gClass = (GClass78)GClass144.gclass88_5.method_3(i);
						if (!gClass.bool_54 && (gClass.int_13 == int_2 || (gClass.int_119 == gstruct2_0.int_0 && gClass.int_121 == gstruct2_0.int_1 && gClass.int_120 == gstruct2_0.int_2)))
						{
							GClass78.smethod_1().gclass194_0 = null;
							GClass78.smethod_1().gclass79_0 = null;
							GClass78.smethod_1().gclass64_0 = null;
							GClass78.smethod_1().gclass78_0 = gClass;
							break;
						}
					}
				}
				if (!smethod_0().bool_2)
					return;
				smethod_0().bool_3 = false;
				for (int j = 0; j < GClass144.gclass88_9.method_2(); j++)
				{
					GClass194 gClass2 = (GClass194)GClass144.gclass88_9.method_3(j);
					if (gClass2 != null && gClass2.int_25 == int_3)
					{
						GClass78.smethod_1().gclass79_0 = null;
						GClass78.smethod_1().gclass64_0 = null;
						GClass78.smethod_1().gclass78_0 = null;
						GClass78.smethod_1().gclass194_0 = gClass2;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/lockObject.txt", ex.ToString());
			}
		}

		public int method_23()
		{
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				if (GClass78.smethod_1().gclass128_0[i] != null && GClass78.smethod_1().gclass128_0[i].gclass117_0.string_0.Contains((mResources.language != 0) ? "Yardart" : "Yardrat"))
					return i;
			}
			return -1;
		}

		public void method_24(int charID)
		{
			GClass128[] gclass128_ = GClass78.smethod_1().gclass128_2;
			if (gclass128_[5] != null)
			{
				if (!gclass128_[5].gclass117_0.string_0.Contains((mResources.language != 0) ? "Yardart" : "Yardrat") || gclass128_[5] == null)
				{
					if (!gclass128_[5].gclass117_0.string_0.Contains((mResources.language == 0) ? "Yardrat" : "Yardart") && gclass128_[5] != null)
					{
						GClass7.smethod_0().method_30(4, (sbyte)method_23());
						GClass7.smethod_0().method_0(charID);
						GClass7.smethod_0().method_30(4, (sbyte)method_23());
					}
				}
				else
					GClass7.smethod_0().method_0(charID);
			}
			else
			{
				GClass7.smethod_0().method_30(4, (sbyte)method_23());
				GClass7.smethod_0().method_0(charID);
				GClass7.smethod_0().method_30(5, 5);
			}
		}

		public void method_25()
		{
			try
			{
				if (!bool_4 || GClass203.smethod_18() - long_0 <= 1000L)
					return;
				GClass168.smethod_0().bool_3 = false;
				if (!GClass78.smethod_1().bool_62 || GClass20.int_37 == 21 + GClass78.smethod_1().int_14)
				{
					if (GClass20.int_37 != 21 + GClass78.smethod_1().int_14 && GClass144.smethod_14(int_4) != null)
					{
						GClass166.smethod_0().bool_0 = true;
						return;
					}
					GClass166.smethod_0().bool_0 = false;
					method_24(int_4);
					long_0 = GClass203.smethod_18();
				}
				else
				{
					GClass166.smethod_0().bool_0 = false;
					GClass7.smethod_0().method_76();
					long_0 = GClass203.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/autoTeleport.txt", ex.ToString());
			}
		}

		public void method_26(int x, int y)
		{
			GClass78.smethod_1().gclass29_0 = null;
			GClass78.smethod_1().int_4 = x;
			GClass78.smethod_1().int_5 = y;
			GClass7.smethod_0().method_44();
			if (!GClass19.smethod_0(4387))
			{
				GClass78.smethod_1().int_4 = x;
				GClass78.smethod_1().int_5 = y + 1;
				GClass7.smethod_0().method_44();
				GClass78.smethod_1().int_4 = x;
				GClass78.smethod_1().int_5 = y;
				GClass7.smethod_0().method_44();
			}
		}

		public void method_27(GInterface1 obj)
		{
			method_26(obj.getX(), obj.getY());
		}

		public void method_28()
		{
			try
			{
				if (!bool_5 || int_5 == GClass78.smethod_1().int_13 || int_5 == -1 || GClass203.smethod_18() - long_1 <= 1000L)
					return;
				if (GClass144.smethod_14(int_5) != null && GClass20.int_37 != 21 + GClass78.smethod_1().int_14)
				{
					for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
					{
						if (GClass144.gclass88_5.method_3(i) is GClass78 gClass && gClass.int_13 == int_5)
						{
							if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) < 20)
								break;
							method_27(gClass);
							long_1 = GClass203.smethod_18();
						}
					}
				}
				else
				{
					method_24(int_5);
					long_1 = GClass203.smethod_18();
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/autoFollowObj.txt", ex.ToString());
			}
		}

		public void method_29()
		{
			method_30();
			if (GClass153.smethod_0().method_6())
			{
				if (int_17 != 1)
					int_17 = 1;
			}
			else if (!GClass156.bool_0)
			{
				if (int_17 != ((GClass122.int_12 == 2) ? 25 : 20))
					int_17 = ((GClass122.int_12 == 2) ? 25 : 20);
			}
			else if (int_17 != ((GClass122.int_12 == 2) ? 25 : 20) + ((GClass122.int_12 == 2) ? 7 : 10) * GClass156.list_0.Count + 5)
			{
				int_17 = ((GClass122.int_12 == 2) ? 25 : 20) + ((GClass122.int_12 == 2) ? 7 : 10) * GClass156.list_0.Count + 5;
			}
		}

		public void method_30()
		{
			try
			{
				list_7.Clear();
				for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
				{
					GClass78 gClass = (GClass78)GClass144.gclass88_5.method_3(i);
					if (!gClass.string_3.ToLower().Contains((mResources.language == 0) ? "đường tăng" : "tang sanzang") && ((gClass.string_3 != null && gClass.string_3 != "") || (gClass.int_119 == 639 && gClass.int_121 == 640 && gClass.int_120 == 641 && (gClass.string_3 == null || gClass.string_3 == ""))) && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.string_3 != "Arbitration" && !list_7.Contains(gClass))
					{
						list_7.Add(gClass);
						list_7 = method_32(list_7);
					}
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/addCharacterInMap.txt", ex.ToString());
			}
		}

		public void method_31(List<GClass78> myList, int i, int m)
		{
			GClass78 value = myList[i];
			myList[i] = myList[m];
			myList[m] = value;
		}

		public List<GClass78> method_32(List<GClass78> list)
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

		public void method_33(GClass122 g)
		{
			if (!smethod_0().bool_14)
				return;
			if (GClass122.int_12 == 1)
				int_13 = 10;
			g.method_37();
			int_14 = 0;
			List<KeyValuePair<string, GUIStyle>> list = new List<KeyValuePair<string, GUIStyle>>();
			int num = 1;
			for (int i = 0; i < list_7.Count; i++)
			{
				GUIStyle gUIStyle = new GUIStyle(GUI.skin.label)
				{
					alignment = TextAnchor.UpperLeft,
					fontSize = ((GClass122.int_12 == 2) ? 12 : 9),
					fontStyle = FontStyle.Bold,
					richText = true
				};
				GClass78 gClass = list_7[i];
				string text = string.Format("<color={0}>{1}.</color>{2}{3} {4}", (list_7[i].int_13 < 0 || list_7[i].gclass163_0.bool_0) ? "yellow" : "black", num, GClass175.smethod_3(gClass), GClass175.smethod_2(gClass), GClass175.smethod_1(gClass));
				if ((GClass78.smethod_1().bool_47 || (!GClass78.smethod_1().bool_7 && GClass78.smethod_1().int_14 == 2 && GClass78.smethod_1().gclass63_0 == GClass78.smethod_1().method_16(GClass78.smethod_1().gclass176_0.gclass47_0[4]))) && smethod_0().List_1.Contains(gClass))
					text += ((GClass151.int_0 == 0) ? " <color=yellow>[Trong tầm]</color>" : " <color=yellow>[In Range]</color>");
				if (gClass.gclass163_0.bool_0)
					gUIStyle.fontStyle = FontStyle.BoldAndItalic;
				num++;
				list.Add(new KeyValuePair<string, GUIStyle>(text, gUIStyle));
				int_14 = GClass118.smethod_2(int_14, GClass154.smethod_0().method_4(list[i].Value, text));
			}
			for (int j = 0; j < list_7.Count; j++)
			{
				GClass78 gClass2 = list_7[j];
				if (gClass2 != null)
				{
					if (GClass78.smethod_1().gclass78_0 == gClass2 && GClass78.smethod_1().gclass78_0 != null && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 20)
					{
						g.method_17(Color.yellow);
						g.method_11(GClass78.smethod_1().int_4 - GClass144.int_22, GClass78.smethod_1().int_5 - GClass144.int_23, gClass2.int_4 - GClass144.int_22, gClass2.int_5 - GClass144.int_23);
					}
					if (gClass2.int_13 < 0 && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 20)
					{
						g.method_16(16547587);
						g.method_11(GClass78.smethod_1().int_4 - GClass144.int_22, GClass78.smethod_1().int_5 - GClass144.int_23, gClass2.int_4 - GClass144.int_22, gClass2.int_5 - GClass144.int_23);
					}
					g.method_20(52428, 0.8f);
					if ((GClass78.smethod_1().bool_47 || (!GClass78.smethod_1().bool_7 && GClass78.smethod_1().int_14 == 2 && GClass78.smethod_1().gclass63_0 == GClass78.smethod_1().method_16(GClass78.smethod_1().gclass176_0.gclass47_0[4]))) && smethod_0().List_1.Contains(gClass2))
						g.method_20(0, 0.5f);
					if (gClass2.int_13 < 0)
						g.method_20(7995392, 0.4f);
					int num2 = GClass73.int_10 - int_16 - int_14 + 1;
					int_15 = GClass118.smethod_2(int_15, GClass154.smethod_0().method_5(list[j].Value, list[j].Key));
					int num3 = int_17 + int_13 * j + int_15 + ((GClass122.int_12 == 2) ? (-1) : 0);
					int x = GClass73.int_10 - int_16 - int_14;
					int y = int_17 + int_13 * j + int_15 + ((GClass122.int_12 != 2) ? 4 : 0);
					int h = ((GClass122.int_12 == 2) ? 7 : 8);
					if (GClass73.smethod_25(x, y, int_14, h) && !GClass73.gclass76_0.bool_0)
						g.method_20(16777215, 0.6f);
					int x2 = GClass73.int_10 - int_16 - int_14 - ((gClass2.sbyte_28 == 0) ? 8 : 19);
					int y2 = int_17 + int_13 * j + int_15 + ((GClass122.int_12 != 2) ? 4 : 0);
					if (GClass78.smethod_1().gclass78_0 == gClass2 && GClass78.smethod_1().gclass78_0 != null)
					{
						g.method_23(GClass194.gclass70_0, 0, 24, 9, 6, 4, x2, y2, 0);
						g.method_17(new Color(1f, 0.5f, 0f, 0.5f));
					}
					if (gClass2.gclass163_0.bool_0)
						g.method_20(0, 0.6f);
					g.method_15(x, y, int_14, h);
					g.method_19(list[j].Key, num2, num3, list[j].Value);
					num++;
					if (gClass2.sbyte_28 > 0)
					{
						int x3 = GClass73.int_10 - int_16 - 9 - int_14;
						int y3 = int_17 + int_13 * j + int_15 + ((GClass122.int_12 != 2) ? 4 : 0);
						g.method_17(GClass175.smethod_0().method_12(gClass2));
						g.method_15(x3, y3, 7, 7);
						g.method_17(GClass175.smethod_0().method_12(gClass2));
						g.method_15(x3, y3, 7, 7);
						g.method_17(GClass175.smethod_0().method_12(gClass2));
						g.method_15(x3, y3, 7, 7);
						g.method_17(GClass175.smethod_0().method_12(gClass2));
						g.method_15(x3, y3, 7, 7);
					}
				}
			}
		}

		public void method_34(GClass122 g)
		{
			if (!smethod_0().bool_14)
				return;
			try
			{
				for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
				{
					GClass78 gClass = GClass144.gclass88_5.method_3(i) as GClass78;
					string empty = "";
					if (gClass.bool_47 && method_36(gClass, GClass78.smethod_1()) <= GClass175.smethod_0().method_13(gClass))
					{
						empty = ((GClass151.int_0 != 0) ? (GClass175.smethod_0().method_10(gClass) + " [" + GClass65.smethod_9(gClass.int_35) + "] using bom") : (GClass175.smethod_0().method_10(gClass) + " [" + GClass65.smethod_9(gClass.int_35) + "] đang sử dụng bom"));
						if ((gClass.sbyte_28 != 0 && GClass78.smethod_1().sbyte_28 != 0 && (gClass.sbyte_28 != GClass78.smethod_1().sbyte_28 || (gClass.sbyte_28 == 8 && GClass78.smethod_1().sbyte_28 == 8))) || GClass78.smethod_1().sbyte_19 == 5 || gClass.sbyte_19 == 5)
							empty += ((GClass151.int_0 != 0) ? "- In Range" : "- Trong tầm");
						GClass154.smethod_0().method_1(GClass4.gclass4_15, g, empty, 5, int_19, GClass4.int_0, GClass4.gclass4_11);
						int_19 += 9;
					}
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/paintSuicideRange.txt", ex.ToString());
			}
			try
			{
				if (list_10.Count <= 0)
					return;
				for (int j = 0; j < list_10.Count; j++)
				{
					if (list_10[j] == null)
						continue;
					GClass78 gClass2 = list_10[j];
					GClass4 gClass3 = GClass4.gclass4_15;
					if (gClass2 != null && gClass2.gclass78_4 != null)
					{
						string text = ((GClass151.int_0 == 0) ? (gClass2.string_3 + " trói [" + gClass2.gclass78_4.string_3 + "]") : (gClass2.string_3 + " hold [" + gClass2.gclass78_4.string_3 + "]"));
						g.method_20(0, 0.5f);
						g.method_15(4, int_19 + 1 + j * 10, GClass4.gclass4_0.method_17(text) + 2, 9);
						if (GClass73.smethod_25(5, int_19 + j * 10, GClass4.gclass4_0.method_17(text) + 2, 9))
							gClass3 = GClass4.gclass4_19;
						gClass3.method_6(g, text, 5, int_19 + j * 10, GClass4.int_0);
					}
				}
			}
			catch (Exception ex2)
			{
				GClass149.smethod_0("Data/Errors/paintHolder.txt", ex2.ToString());
			}
		}

		public void method_35()
		{
			if (!smethod_0().bool_14)
				return;
			try
			{
				if (!GClass73.bool_5 || GClass91.smethod_0().bool_0 || GClass73.gclass145_0.bool_0)
					return;
				for (int i = 0; i < list_7.Count; i++)
				{
					if (GClass73.smethod_48(GClass73.int_10 - int_16 - int_14, int_17 + int_13 * i + int_15 + ((GClass122.int_12 == 2) ? (-3) : (-2)), int_14, int_15) && !GClass73.bool_14)
					{
						if (GClass78.smethod_1().gclass78_0 == list_7[i])
						{
							GClass109.smethod_1().method_35();
							GClass78.smethod_1().gclass29_0 = null;
							GClass73.smethod_49();
							method_27(list_7[i]);
						}
						else
						{
							GClass109.smethod_1().method_35();
							GClass78.smethod_1().gclass29_0 = null;
							GClass73.smethod_49();
							GClass78.smethod_1().gclass194_0 = null;
							GClass78.smethod_1().gclass79_0 = null;
							GClass78.smethod_1().gclass64_0 = null;
							GClass78.smethod_1().gclass78_0 = list_7[i];
						}
						return;
					}
				}
				int num = 0;
				GClass78 gClass;
				while (true)
				{
					if (num >= list_10.Count)
						return;
					if (list_10[num] != null)
					{
						gClass = list_10[num];
						if (gClass != null && gClass.gclass78_4 != null)
						{
							string s = ((GClass151.int_0 != 0) ? (gClass.string_3 + " hold [" + gClass.gclass78_4.string_3 + "]") : (gClass.string_3 + " trói [" + gClass.gclass78_4.string_3 + "]"));
							if (GClass73.smethod_48(5, int_19 + 10 * num, GClass4.gclass4_0.method_17(s) + 2, 9) && !GClass73.bool_14)
								break;
						}
					}
					num++;
				}
				if (GClass78.smethod_1().gclass78_0 == gClass)
				{
					GClass109.smethod_1().method_35();
					GClass78.smethod_1().gclass29_0 = null;
					GClass73.smethod_49();
					method_27(gClass);
				}
				else
				{
					GClass109.smethod_1().method_35();
					GClass78.smethod_1().gclass29_0 = null;
					GClass73.smethod_49();
					GClass78.smethod_1().gclass194_0 = null;
					GClass78.smethod_1().gclass79_0 = null;
					GClass78.smethod_1().gclass64_0 = null;
					GClass78.smethod_1().gclass78_0 = gClass;
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/updateTouchListCharacter.txt", ex.ToString());
			}
		}

		public int method_36(GInterface1 mapObject1, GInterface1 mapObject2)
		{
			return GClass50.smethod_24(mapObject1.getX(), mapObject1.getY(), mapObject2.getX(), mapObject2.getY());
		}

		public void method_37()
		{
			if (!smethod_0().bool_14)
				return;
			List_0.Clear();
			List_1.Clear();
			if (!GClass78.smethod_1().bool_7 && GClass78.smethod_1().gclass63_0 == GClass78.smethod_1().method_16(GClass78.smethod_1().gclass176_0.gclass47_0[4]) && GClass78.smethod_1().int_14 == 2)
				method_39(GClass78.smethod_1());
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				GClass78 gClass = GClass144.gclass88_5.method_3(i) as GClass78;
				if (gClass.bool_47 && gClass.string_3 != null && gClass.string_3 != "" && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.string_3 != "Trọng tài" && gClass.int_14 == 2 && gClass.string_3 != "Arbitration")
				{
					method_39(gClass);
					if (method_36(GClass78.smethod_1(), gClass) <= GClass175.smethod_0().method_13(gClass) && !List_0.Contains(GClass78.smethod_1()))
						List_0.Add(GClass78.smethod_1());
				}
			}
		}

		public void method_38()
		{
			try
			{
				list_10.Clear();
				for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
				{
					GClass78 gClass = (GClass78)GClass144.gclass88_5.method_3(i);
					if (((gClass.string_3 != null && gClass.string_3 != "") || (gClass.int_119 == 639 && gClass.int_121 == 640 && gClass.int_120 == 641 && (gClass.string_3 == null || gClass.string_3 == ""))) && !gClass.bool_53 && !gClass.bool_54 && !gClass.string_3.StartsWith("#") && !gClass.string_3.StartsWith("$") && gClass.gclass78_4 != null && gClass.bool_63 && !list_10.Contains(gClass))
						list_10.Add(gClass);
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/addCharacterInMap.txt", ex.ToString());
			}
		}

		public void method_39(GClass78 suicidingChar)
		{
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				GClass78 gClass = GClass144.gclass88_5.method_3(i) as GClass78;
				if (gClass.string_3 == null || !(gClass.string_3 != "") || gClass.bool_53 || gClass.bool_54 || gClass.string_3.StartsWith("#") || gClass.string_3.StartsWith("$") || !(gClass.string_3 != "Trọng tài") || !(gClass.string_3 != "Arbitration") || method_36(gClass, suicidingChar) > GClass175.smethod_0().method_13(suicidingChar) || ((suicidingChar.sbyte_28 == 0 || gClass.sbyte_28 == 0 || (gClass.sbyte_28 == suicidingChar.sbyte_28 && (gClass.sbyte_28 != 8 || suicidingChar.sbyte_28 != 8))) && suicidingChar.sbyte_19 != 5 && gClass.sbyte_19 != 5) || !suicidingChar.bool_10)
					continue;
				if (List_1.Contains(gClass))
				{
					if (!List_0.Contains(gClass))
						List_0.Add(gClass);
				}
				else
					List_1.Add(gClass);
			}
			for (int j = 0; j < GClass144.gclass88_9.method_2(); j++)
			{
				GClass194 gClass2 = GClass144.gclass88_9.method_3(j) as GClass194;
				if (method_36(gClass2, suicidingChar) > GClass175.smethod_0().method_13(suicidingChar) || List_0.Contains(gClass2) || gClass2.bool_13 || !suicidingChar.bool_10)
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
			if (GClass78.smethod_1().method_145() > 0 && GClass78.smethod_1().bool_62 && GClass78.smethod_1().int_25 <= 0 && GClass73.int_8 % 20 == 0 && bool_9)
			{
				GClass7.smethod_0().method_77();
				GClass78.smethod_1().bool_62 = false;
				GClass78.smethod_1().int_11 = 1;
				GClass78.smethod_1().int_25 = GClass78.smethod_1().int_35;
				GClass78.smethod_1().int_24 = GClass78.smethod_1().int_36;
				GClass78 gClass = GClass78.smethod_1();
				GClass78 gClass2 = GClass78.smethod_1();
				GClass78.smethod_1().int_10 = 0;
				gClass2.int_9 = 0;
				gClass.int_8 = 0;
				GClass97.smethod_3(109, GClass78.smethod_1(), 2);
				GClass144.smethod_8().gclass87_1 = null;
				GClass144.bool_17 = true;
			}
		}

		public void method_41()
		{
			if (!bool_10 || GClass203.smethod_18() - long_2 <= 500L)
				return;
			int num = int_7[0];
			int num2 = int_7[1];
			int num3 = int_7[2];
			_ = GClass78.smethod_1().long_4 > 100 * (2 * (GClass78.smethod_1().int_155 + 1000) + 1980) / 2;
			_ = GClass78.smethod_1().long_4 > 10 * (2 * (GClass78.smethod_1().int_155 + 1000) + 180) / 2;
			_ = GClass78.smethod_1().long_4 > GClass78.smethod_1().int_155 + 1000;
			_ = GClass78.smethod_1().long_4 > 100 * (2 * (GClass78.smethod_1().int_156 + 1000) + 1980) / 2;
			_ = GClass78.smethod_1().long_4 > 10 * (2 * (GClass78.smethod_1().int_156 + 1000) + 180) / 2;
			_ = GClass78.smethod_1().long_4 > GClass78.smethod_1().int_156 + 1000;
			_ = 100 * (2 * GClass78.smethod_1().int_154 + 99) / 2 * GClass78.smethod_1().short_25 < GClass78.smethod_1().long_4;
			_ = 10 * (2 * GClass78.smethod_1().int_154 + 9) / 2 * GClass78.smethod_1().short_25 < GClass78.smethod_1().long_4;
			_ = GClass78.smethod_1().int_154 * 100 < GClass78.smethod_1().long_4;
			bool flag = ((GClass78.smethod_1().int_155 >= num && num > 0) ? true : false);
			bool flag2 = ((GClass78.smethod_1().int_156 >= num2 && num2 > 0) ? true : false);
			bool flag3 = ((GClass78.smethod_1().int_154 >= num3 && num3 > 0) ? true : false);
			if (flag)
			{
				int_7[0] = 0;
				GClass149.smethod_1((GClass151.int_0 != 0) ? "Upgrade HP is completed" : "Đã nâng xong HP", 0);
			}
			if (flag2)
			{
				int_7[1] = 0;
				GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã nâng xong KI" : "Upgrade MP is completed", 0);
			}
			if (flag3)
			{
				int_7[2] = 0;
				GClass149.smethod_1((GClass151.int_0 != 0) ? "Upgrade Damage is completed" : "Đã nâng xong SĐ", 0);
			}
			if (int_7[0] + int_7[1] + int_7[2] != 0)
			{
				if (num > 0 && num > GClass78.smethod_1().int_155)
				{
					if (num > 0 && GClass78.smethod_1().int_155 <= num - 2000 && GClass78.smethod_1().long_4 > 100 * (2 * (GClass78.smethod_1().int_155 + 1000) + 1980) / 2)
					{
						GClass7.smethod_0().method_124(0, 100);
						long_2 = GClass203.smethod_18();
						return;
					}
					if (num > 0 && GClass78.smethod_1().int_155 <= num - 200 && GClass78.smethod_1().long_4 > 10 * (2 * (GClass78.smethod_1().int_155 + 1000) + 180) / 2)
					{
						GClass7.smethod_0().method_124(0, 10);
						long_2 = GClass203.smethod_18();
						return;
					}
					if (num > 0 && GClass78.smethod_1().int_155 <= num - 20 && GClass78.smethod_1().long_4 > GClass78.smethod_1().int_155 + 1000)
					{
						GClass7.smethod_0().method_124(0, 1);
						long_2 = GClass203.smethod_18();
						return;
					}
				}
				if (num2 > 0 && num2 > GClass78.smethod_1().int_156)
				{
					if (num2 > 0 && GClass78.smethod_1().int_156 <= num2 - 2000 && GClass78.smethod_1().long_4 > 100 * (2 * (GClass78.smethod_1().int_156 + 1000) + 1980) / 2)
					{
						GClass7.smethod_0().method_124(1, 100);
						long_2 = GClass203.smethod_18();
						return;
					}
					if (num2 > 0 && GClass78.smethod_1().int_156 <= num2 - 200 && GClass78.smethod_1().long_4 > 10 * (2 * (GClass78.smethod_1().int_156 + 1000) + 180) / 2)
					{
						GClass7.smethod_0().method_124(1, 10);
						long_2 = GClass203.smethod_18();
						return;
					}
					if (num2 > 0 && GClass78.smethod_1().int_156 <= num2 - 20 && GClass78.smethod_1().long_4 > GClass78.smethod_1().int_156 + 1000)
					{
						GClass7.smethod_0().method_124(1, 1);
						long_2 = GClass203.smethod_18();
						return;
					}
				}
				if (num3 > 0 && num3 > GClass78.smethod_1().int_154)
				{
					if (num3 > 0 && GClass78.smethod_1().int_154 <= num3 - 100 && 100 * (2 * GClass78.smethod_1().int_154 + 99) / 2 * GClass78.smethod_1().short_25 < GClass78.smethod_1().long_4)
					{
						GClass7.smethod_0().method_124(2, 100);
						long_2 = GClass203.smethod_18();
					}
					else if (num3 > 0 && GClass78.smethod_1().int_154 <= num3 - 10 && 10 * (2 * GClass78.smethod_1().int_154 + 9) / 2 * GClass78.smethod_1().short_25 < GClass78.smethod_1().long_4)
					{
						GClass7.smethod_0().method_124(2, 10);
						long_2 = GClass203.smethod_18();
					}
					else if (num3 > 0 && GClass78.smethod_1().int_154 <= num3 - 1 && GClass78.smethod_1().int_154 * 100 < GClass78.smethod_1().long_4)
					{
						GClass7.smethod_0().method_124(2, 1);
						long_2 = GClass203.smethod_18();
					}
				}
			}
			else
			{
				bool_10 = false;
				GClass149.smethod_1((GClass151.int_0 == 0) ? "Auto cộng chỉ số đã hoàn thành!" : "Upgrade point is completed!", 1);
			}
		}

		public void method_42()
		{
			if (int_8 > 0)
			{
				if (!GClass78.smethod_1().bool_4 && GClass144.smethod_14(-GClass78.smethod_1().int_13) != null && GClass73.int_8 % 50 == 0)
					GClass7.smethod_0().method_133(3);
				if (GClass78.smethod_1().int_25 <= GClass78.smethod_1().int_35 * int_8 / 100 && GClass203.smethod_18() - long_3 > 10120L)
				{
					for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
					{
						GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
						if (gClass != null && (gClass.gclass117_0.short_0 == short_0 || gClass.gclass117_0.short_0 == short_1))
						{
							GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
							GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
							long_3 = GClass203.smethod_18();
							GClass7.smethod_0().method_133(3);
						}
					}
				}
			}
			if (int_9 <= 0)
				return;
			if (!GClass78.smethod_1().bool_4 && GClass144.smethod_14(-GClass78.smethod_1().int_13) != null && GClass73.int_8 % 50 == 0)
				GClass7.smethod_0().method_133(3);
			if (GClass78.smethod_1().int_24 > GClass78.smethod_1().int_36 * int_9 / 100 || GClass203.smethod_18() - long_3 <= 10120L)
				return;
			for (int j = 0; j < GClass78.smethod_1().gclass128_0.Length; j++)
			{
				GClass128 gClass2 = GClass78.smethod_1().gclass128_0[j];
				if (gClass2 != null && (gClass2.gclass117_0.short_0 == short_0 || gClass2.gclass117_0.short_0 == short_1))
				{
					GClass7.smethod_0().method_20(0, 1, -1, gClass2.gclass117_0.short_0);
					GClass7.smethod_0().method_20(0, 1, -1, gClass2.gclass117_0.short_0);
					long_3 = GClass203.smethod_18();
					GClass7.smethod_0().method_133(3);
				}
			}
		}

		public void method_43()
		{
			if (!bool_11 || !GClass78.smethod_1().bool_38 || GClass78.smethod_1().bool_4)
				return;
			if (GClass203.smethod_18() - long_3 > 1000L)
			{
				for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
				{
					GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
					if (gClass != null && (gClass.gclass117_0.short_0 == 454 || gClass.gclass117_0.short_0 == 921))
					{
						GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
						long_3 = GClass203.smethod_18();
					}
					else
						bool_11 = false;
				}
			}
			else
				bool_11 = false;
		}

		public void method_44(List<GStruct3> list, int i, int m)
		{
			GStruct3 value = list[i];
			list[i] = list[m];
			list[m] = value;
		}

		public List<GStruct3> method_45(List<GStruct3> list)
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
			List<GStruct3> list = list_11;
			if (int_20 > list.Count)
				int_20 = 0;
			if (GClass144.smethod_16(list[int_20].int_0) != null)
			{
				GClass78.smethod_1().gclass78_0 = null;
				GClass78.smethod_1().gclass194_0 = GClass144.smethod_16(list[int_20].int_0);
				GClass78.smethod_1().gclass64_0 = null;
				GClass78.smethod_1().gclass79_0 = null;
				GClass78.smethod_1().int_4 = list[int_20].int_2 - 24;
				GClass78.smethod_1().int_5 = list[int_20].int_3;
				GClass7.smethod_0().method_44();
				GClass78.smethod_1().int_4 = list[int_20].int_2;
				GClass78.smethod_1().int_5 = list[int_20].int_3;
				GClass7.smethod_0().method_44();
				GClass78.smethod_1().int_4 = list[int_20].int_2 - 24;
				GClass78.smethod_1().int_5 = list[int_20].int_3;
				GClass7.smethod_0().method_44();
			}
			if (list.Count - int_20 > 1)
				int_20++;
			else
				int_20 = 0;
		}

		public void method_47()
		{
			try
			{
				list_11.Clear();
				for (int i = 0; i < GClass144.gclass88_9.method_2(); i++)
				{
					GClass194 gClass = (GClass194)GClass144.gclass88_9.method_3(i);
					if (gClass != null && gClass.int_12 != 0 && gClass.int_6 > 0 && (gClass.method_16().sbyte_0 == 76 || (gClass.method_16().sbyte_0 != 76 && gClass.sbyte_14 != 0)) && !list_11.Contains(new GStruct3
					{
						int_0 = gClass.int_25,
						int_1 = gClass.method_16().sbyte_0,
						int_2 = gClass.int_16,
						int_3 = gClass.int_17
					}))
						list_11.Add(new GStruct3
						{
							int_0 = gClass.int_25,
							int_1 = gClass.method_16().sbyte_0,
							int_2 = gClass.int_16,
							int_3 = gClass.int_17
						});
					list_11 = method_45(list_11);
				}
			}
			catch
			{
			}
		}

		public void method_48()
		{
			List<GClass79> list = list_4;
			if (int_10 > list.Count)
				int_10 = 0;
			if (list.Count > 0 && int_10 < list.Count)
			{
				GClass78.smethod_1().gclass78_0 = null;
				GClass78.smethod_1().gclass194_0 = null;
				GClass78.smethod_1().gclass64_0 = null;
				GClass78.smethod_1().gclass79_0 = list[int_10];
				GClass78.smethod_1().int_4 = list[int_10].int_4;
				GClass78.smethod_1().int_5 = list[int_10].int_5 - 3;
				GClass7.smethod_0().method_44();
				GClass78.smethod_1().int_4 = list[int_10].int_4;
				GClass78.smethod_1().int_5 = list[int_10].int_5;
				GClass7.smethod_0().method_44();
				GClass78.smethod_1().int_4 = list[int_10].int_4;
				GClass78.smethod_1().int_5 = list[int_10].int_5 - 3;
				GClass7.smethod_0().method_44();
				Thread.Sleep(100);
				if (list.Count - int_10 > 1)
					int_10++;
				else
					int_10 = 0;
			}
		}

		public void method_49()
		{
			list_4.Clear();
			for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
			{
				GClass79 gClass = (GClass79)GClass144.gclass88_10.method_3(i);
				if (gClass != null && !list_4.Contains(gClass) && gClass.gclass127_0.int_0 != 66)
					list_4.Add(gClass);
				for (int j = 0; j < list_4.Count; j++)
				{
					if (GClass144.smethod_13((short)list_4[j].gclass127_0.int_0) == null)
						list_4.RemoveAt(j);
				}
			}
		}

		public bool method_50()
		{
			if (GClass20.int_37 != 149 && GClass20.int_37 != 147 && GClass20.int_37 != 152 && GClass20.int_37 != 151 && GClass20.int_37 != 148)
				return false;
			return true;
		}

		public void method_51()
		{
			if (!bool_16 || GClass73.gclass131_0 == GClass132.gclass132_0 || GClass78.bool_33 || GClass12.bool_5 || GClass78.bool_35 || GClass78.smethod_1().bool_4 || bool_17)
				return;
			if (GClass78.smethod_1().bool_38)
			{
				for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
				{
					GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
					if (gClass != null && (gClass.gclass117_0.short_0 == 454 || gClass.gclass117_0.short_0 == 921) && GClass203.smethod_18() - long_10 > 1000L)
					{
						GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
						long_10 = GClass203.smethod_18();
					}
				}
			}
			else
				bool_17 = true;
		}

		public void method_52()
		{
			if (!bool_18 || GClass20.int_37 != 154 || GClass78.smethod_1().sbyte_19 != 0)
				return;
			if (GClass78.smethod_1().sbyte_19 == 0 && !bool_19 && GClass203.smethod_18() - long_11 > 10000L)
				bool_19 = true;
			if (!bool_21)
			{
				if (!bool_19)
					return;
				for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
				{
					if (!(GClass144.gclass88_10.method_3(i) is GClass79 gClass) || gClass.gclass127_0.int_0 != 56)
						continue;
					if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) <= 20 || GClass203.smethod_18() - long_11 <= 1500L)
					{
						if ((GClass73.gclass145_0.bool_0 && GClass73.gclass145_0 != null) || GClass203.smethod_18() - long_11 <= 1500L)
						{
							if (GClass73.gclass145_0 == null || !GClass73.gclass145_0.bool_0)
								continue;
							for (int j = 0; j < GClass73.gclass145_0.gclass88_0.method_2(); j++)
							{
								GClass87 gClass2 = (GClass87)GClass73.gclass145_0.gclass88_0.method_3(j);
								if (!GClass154.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "tặngđồăn" : "givefood") || GClass203.smethod_18() - long_11 <= 1500L)
								{
									if (gClass2.string_0.StartsWith("[LV") && GClass203.smethod_18() - long_11 > 1500L)
									{
										GClass7.smethod_0().method_59(56, (sbyte)j);
										GClass162.smethod_0().method_0();
										bool_19 = false;
										long_11 = GClass203.smethod_18();
										return;
									}
									continue;
								}
								bool_19 = false;
								bool_21 = true;
								long_11 = GClass203.smethod_18();
								return;
							}
							continue;
						}
						GClass7.smethod_0().method_60(56);
						GClass162.smethod_0().method_0();
						long_11 = GClass203.smethod_18();
						break;
					}
					GClass78.smethod_1().int_4 = gClass.int_4;
					GClass78.smethod_1().int_5 = gClass.int_5 - 3;
					GClass7.smethod_0().method_44();
					GClass78.smethod_1().int_4 = gClass.int_4;
					GClass78.smethod_1().int_5 = gClass.int_5;
					GClass7.smethod_0().method_44();
					GClass78.smethod_1().int_4 = gClass.int_4;
					GClass78.smethod_1().int_5 = gClass.int_5 - 3;
					GClass78.smethod_1().gclass79_0 = gClass;
					long_11 = GClass203.smethod_18();
					break;
				}
			}
			else if (GClass160.smethod_0().method_20(880, "id") + GClass160.smethod_0().method_20(881, "id") + GClass160.smethod_0().method_20(882, "id") > 0)
			{
				for (int k = 0; k < GClass144.gclass88_10.method_2(); k++)
				{
					if (!(GClass144.gclass88_10.method_3(k) is GClass79 gClass3) || gClass3.gclass127_0.int_0 != 56)
						continue;
					if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass3.int_4, gClass3.int_5) <= 20 || GClass203.smethod_18() - long_11 <= 1500L)
					{
						if ((GClass73.gclass145_0.bool_0 && GClass73.gclass145_0 != null) || GClass203.smethod_18() - long_11 <= 1500L)
						{
							if (GClass73.gclass145_0 == null || !GClass73.gclass145_0.bool_0)
								continue;
							for (int l = 0; l < GClass73.gclass145_0.gclass88_0.method_2(); l++)
							{
								GClass87 gClass4 = (GClass87)GClass73.gclass145_0.gclass88_0.method_3(l);
								if (!GClass154.smethod_0().method_0(gClass4.string_0, (mResources.language == 0) ? "tặngđồăn" : "givefood") || GClass203.smethod_18() - long_11 <= 1500L)
								{
									if (!GClass154.smethod_0().method_0(gClass4.string_0, (mResources.language != 0) ? "shrimptempura" : "tặngtômtẩmbộtchiênxù") || GClass203.smethod_18() - long_11 <= 1500L)
									{
										if (GClass154.smethod_0().method_0(gClass4.string_0, "ok") && GClass203.smethod_18() - long_11 > 1500L)
										{
											GClass7.smethod_0().method_59(56, (sbyte)l);
											GClass162.smethod_0().method_0();
											bool_21 = false;
											bool_19 = false;
											long_11 = GClass203.smethod_18();
											return;
										}
										continue;
									}
									GClass7.smethod_0().method_59(56, (sbyte)l);
									GClass162.smethod_0().method_0();
									long_11 = GClass203.smethod_18();
									return;
								}
								GClass7.smethod_0().method_59(56, (sbyte)l);
								GClass162.smethod_0().method_0();
								long_11 = GClass203.smethod_18();
								return;
							}
							continue;
						}
						GClass7.smethod_0().method_60(56);
						GClass162.smethod_0().method_0();
						long_11 = GClass203.smethod_18();
						break;
					}
					GClass78.smethod_1().int_4 = gClass3.int_4;
					GClass78.smethod_1().int_5 = gClass3.int_5 - 3;
					GClass7.smethod_0().method_44();
					GClass78.smethod_1().int_4 = gClass3.int_4;
					GClass78.smethod_1().int_5 = gClass3.int_5;
					GClass7.smethod_0().method_44();
					GClass78.smethod_1().int_4 = gClass3.int_4;
					GClass78.smethod_1().int_5 = gClass3.int_5 - 3;
					GClass78.smethod_1().gclass79_0 = gClass3;
					long_11 = GClass203.smethod_18();
					break;
				}
			}
			else
			{
				bool_18 = false;
				bool_21 = false;
			}
		}

		[CompilerGenerated]
		private void method_53()
		{
			method_46();
		}

		[CompilerGenerated]
		private void method_54()
		{
			method_48();
		}
	}
}
