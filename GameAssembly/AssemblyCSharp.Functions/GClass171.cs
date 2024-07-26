using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;

namespace AssemblyCSharp.Functions
{
	public class GClass171
	{
		public bool bool_0;

		public bool bool_1;

		public long long_0;

		public static GClass70 gclass70_0;

		private static GClass171 gclass171_0;

		private bool bool_2;

		private long long_1;

		private long long_2;

		private bool bool_3;

		public static GClass171 smethod_0()
		{
			return (gclass171_0 != null) ? gclass171_0 : (gclass171_0 = new GClass171());
		}

		public void method_0(int time)
		{
			bool_2 = true;
			long_1 = GClass203.smethod_18();
			long_2 = time;
		}

		public bool method_1()
		{
			if (bool_2 && GClass203.smethod_18() - long_1 >= long_2)
				bool_2 = false;
			return bool_2;
		}

		public bool method_2(string text)
		{
			return GClass160.smethod_0().method_1(text) || GClass153.smethod_0().method_3(text) || GClass168.smethod_0().method_2(text) || GClass148.smethod_0().method_0(text) || GClass164.smethod_0().method_0(text) || GClass158.smethod_0().method_3(text) || GClass159.smethod_0().method_3(text) || GClass166.smethod_0().method_5(text) || GClass157.smethod_0().method_1(text);
		}

		public bool method_3(int asciiCode)
		{
			if (GClass169.smethod_0().bool_0)
				return GClass169.smethod_3(asciiCode);
			return GClass160.smethod_0().method_0(asciiCode) || GClass153.smethod_0().method_2(asciiCode) || GClass164.smethod_0().method_1(asciiCode) || GClass158.smethod_0().method_4(asciiCode) || GClass148.smethod_0().method_1(asciiCode) || GClass159.smethod_0().method_2(asciiCode) || GClass166.smethod_0().method_4(asciiCode);
		}

		public void method_4()
		{
			GClass164.smethod_0().method_2();
			GClass158.smethod_0().method_5();
			GClass159.smethod_0().method_5();
			GClass157.smethod_0().method_3();
			GClass166.smethod_0().method_8();
			GClass168.smethod_0().method_3();
			GClass153.smethod_0().method_4();
			GClass160.smethod_0().method_32();
			GClass155.smethod_0().method_2();
			Class16.k4qKbAJZyI().method_1();
			method_21();
			if (GClass150.smethod_0().bool_0 && !bool_3)
			{
				GClass150.smethod_0().method_0(GClass172.int_0);
				bool_3 = true;
			}
		}

		public void method_5(GClass122 g)
		{
			method_8(g);
			if (GClass73.gclass131_0 != GClass141.gclass141_0)
			{
				if (GClass20.int_39 != GClass157.smethod_0().int_0 && GClass157.smethod_0().int_0 > -1)
					GClass154.smethod_0().method_1(GClass4.gclass4_20, g, (GClass151.int_0 == 0) ? $"Đổi khu sau {GClass96.int_24} giây nữa !" : $"Change zone after {GClass96.int_24}s later", GClass73.int_10 / 2, GClass73.int_11 / 2, GClass4.int_2, GClass4.gclass4_11);
				GClass158.smethod_0().method_6(g);
				GClass159.smethod_0().method_6(g);
				GClass168.smethod_0().method_4(g);
				GClass153.smethod_0().method_5(g);
				GClass160.smethod_0().method_3(g);
			}
		}

		public void method_6(string s)
		{
			GClass148.smethod_0().method_3(s);
			GClass164.smethod_0().method_3(s);
			GClass153.smethod_0().method_8(s);
			GClass160.smethod_0().method_25(s);
		}

		public string method_7(long timeDie)
		{
			return ((GClass203.smethod_18() - timeDie) / 1000L).ToString();
		}

		public void method_8(GClass122 g)
		{
			if (GClass20.int_37 != 129)
			{
				if (gclass70_0 == null)
					gclass70_0 = GClass167.smethod_0().method_4((!GClass151.bool_2) ? "logoGameScr" : "Data/logo.png", GClass122.int_12);
				else
					g.method_23(gclass70_0, 0, 0, GClass122.smethod_0(gclass70_0), GClass122.smethod_1(gclass70_0), 0, (GClass73.int_10 / 2 < GClass122.smethod_0(GClass144.gclass70_28)) ? (GClass122.smethod_0(GClass144.gclass70_28) + 25) : (GClass73.int_10 / 2), 5, (GClass73.int_10 / 2 < GClass122.smethod_0(GClass144.gclass70_28)) ? GClass122.int_2 : GClass122.int_0);
			}
			if (GClass73.gclass131_0 == GClass141.gclass141_0 || GClass167.smethod_0().bool_3)
				return;
			GUIStyle[] array = new GUIStyle[30];
			GUIStyle[] array2 = new GUIStyle[30];
			int num = 1;
			List<string> list = new List<string>();
			list.Add("[" + GClass20.int_37 + "] " + GClass20.string_1 + "- K" + GClass20.int_39 + " [" + (GClass157.smethod_0().method_9() + 1) + (GClass153.smethod_0().method_6() ? "/20]" : "/15]"));
			list.Add("TG: " + DateTime.Now.ToString("HH:mm:ss - d/M/yyyy"));
			list.Add("X: " + GClass78.smethod_1().int_4 + " Y: " + GClass78.smethod_1().int_5);
			if (GClass164.smethod_0().bool_0)
				list.Add((GClass151.int_0 != 0) ? ("Auto Attack: " + GClass154.smethod_0().method_7(GClass164.smethod_0().bool_0)) : ("Auto đánh: " + GClass154.smethod_0().method_7(GClass164.smethod_0().bool_0)));
			if (GClass166.smethod_0().bool_5)
				list.Add((GClass151.int_0 == 0) ? ("Auto nhặt: " + GClass154.smethod_0().method_7(GClass166.smethod_0().bool_5)) : ("Auto pick-up: " + GClass154.smethod_0().method_7(GClass166.smethod_0().bool_5)));
			if (GClass159.smethod_0().bool_9)
				list.Add((GClass151.int_0 == 0) ? ("Auto hồi sinh: " + GClass154.smethod_0().method_7(GClass159.smethod_0().bool_9)) : ("Auto Revive: " + GClass154.smethod_0().method_7(GClass159.smethod_0().bool_9)));
			if (GClass168.smethod_0().bool_3)
				list.Add("Auto jump: " + GClass154.smethod_0().method_7(GClass168.smethod_0().bool_3));
			if (GClass159.smethod_0().bool_3)
				list.Add((GClass151.int_0 == 0) ? $"Khóa ID [{GClass159.smethod_0().int_2}]" : $"Lock ID [{GClass159.smethod_0().int_2}]");
			if (GClass153.smethod_0().bool_1)
				list.Add((GClass151.int_0 != 0) ? ("Auto get x7: " + GClass154.smethod_0().method_7(GClass153.smethod_0().bool_1)) : ("Auto phù x7: " + GClass154.smethod_0().method_7(GClass153.smethod_0().bool_1)));
			if (GClass153.smethod_0().bool_4)
				list.Add((GClass151.int_0 == 0) ? ("Auto vệ tinh: " + GClass154.smethod_0().method_7(GClass153.smethod_0().bool_4)) : ("Auto satellite: " + GClass154.smethod_0().method_7(GClass153.smethod_0().bool_4)));
			if (GClass153.smethod_0().bool_3)
				list.Add((GClass151.int_0 == 0) ? $"Auto sáo đè [{GClass153.smethod_0().int_1}] khi dưới {GClass153.smethod_0().int_2}% HP" : $"Auto whistle [{GClass153.smethod_0().int_1}] when HP < {GClass153.smethod_0().int_2}% HP");
			if (GClass150.smethod_0().bool_0)
				list.Add((GClass151.int_0 != 0) ? "CONNECTED" : "ĐÃ KẾT NỐI");
			if (GClass78.smethod_1().int_11 == 14)
				list.Add((GClass151.int_0 != 0) ? ("Time die: " + method_7(GClass78.smethod_1().long_14) + "s") : ("T/g chết: " + method_7(GClass78.smethod_1().long_14) + "s"));
			int num2 = ((!GClass153.smethod_0().method_6()) ? 104 : 80);
			if (GClass122.int_12 != 2)
			{
				for (int i = 0; i < list.Count; i++)
				{
					GClass4 gClass = ((!list[i].StartsWith("Khóa ID") && !list[i].StartsWith("Auto phù x7") && !list[i].StartsWith("Auto vệ tinh:") && !list[i].StartsWith("Auto sáo") && !list[i].StartsWith("Lock ID") && !list[i].StartsWith("Auto get x7") && !list[i].StartsWith("Auto satellite") && !list[i].StartsWith("Auto whistl") && !list[i].StartsWith((GClass151.int_0 == 0) ? "ĐÃ KẾT NỐI" : "CONNECTED")) ? GClass4.gclass4_20 : GClass4.gclass4_1);
					GClass4 gClass2 = ((gClass == GClass4.gclass4_1) ? GClass4.gclass4_6 : GClass4.gclass4_11);
					gClass2.method_6(g, list[i], 24, num2 + i * 10 - 1, 0);
					gClass2.method_6(g, list[i], 24, num2 + i * 10 + 1, 0);
					gClass2.method_6(g, list[i], 26, num2 + i * 10 - 1, 0);
					gClass2.method_6(g, list[i], 26, num2 + i * 10 + 1, 0);
					gClass2.method_6(g, list[i], 25, num2 + i * 10 - 1, 0);
					gClass2.method_6(g, list[i], 25, num2 + i * 10 + 1, 0);
					gClass2.method_6(g, list[i], 24, num2 + i * 10, 0);
					gClass2.method_6(g, list[i], 26, num2 + i * 10, 0);
					gClass.method_6(g, list[i], 25, num2 + i * 10, 0);
					GClass159.smethod_0().int_19 = num2 + list.Count * 10;
					GClass168.smethod_0().int_1 = num2 + list.Count * 10;
					num++;
				}
				return;
			}
			for (int j = 0; j < list.Count; j++)
			{
				array[j] = new GUIStyle(GUI.skin.label)
				{
					alignment = TextAnchor.UpperLeft,
					fontSize = 7 * GClass122.int_12,
					fontStyle = FontStyle.Bold
				};
				array2[j] = new GUIStyle(GUI.skin.label)
				{
					alignment = TextAnchor.UpperLeft,
					fontSize = 7 * GClass122.int_12,
					fontStyle = FontStyle.Bold
				};
				array[j].normal.textColor = Color.white;
				if (list[j].StartsWith("Khóa ID") || list[j].StartsWith("Auto phù x7") || list[j].StartsWith("Auto vệ tinh:") || list[j].StartsWith("Auto sáo") || list[j].StartsWith("Lock ID") || list[j].StartsWith("Auto get x7") || list[j].StartsWith("Auto satellite") || list[j].StartsWith("Auto whistl") || list[j].StartsWith((GClass151.int_0 == 0) ? "ĐÃ KẾT NỐI" : "CONNECTED"))
					array[j].normal.textColor = Color.red;
				array2[j].normal.textColor = Color.black;
				g.method_19(list[j], 24.5f, (float)(num2 + j * 8) - 0.5f, array2[j]);
				g.method_19(list[j], 24.5f, (float)(num2 + j * 8) + 0.5f, array2[j]);
				g.method_19(list[j], 25.5f, (float)(num2 + j * 8) - 0.5f, array2[j]);
				g.method_19(list[j], 25.5f, (float)(num2 + j * 8) + 0.5f, array2[j]);
				g.method_19(list[j], 25f, (float)(num2 + j * 8) - 0.5f, array2[j]);
				g.method_19(list[j], 25f, (float)(num2 + j * 8) + 0.5f, array2[j]);
				g.method_19(list[j], 24.5f, num2 + j * 8, array2[j]);
				g.method_19(list[j], 25.5f, num2 + j * 8, array2[j]);
				g.method_19(list[j], 25f, num2 + j * 8, array[j]);
				GClass159.smethod_0().int_19 = num2 + list.Count * 8;
				GClass168.smethod_0().int_1 = num2 + list.Count * 8;
				num++;
			}
		}

		public void method_9(string data)
		{
			GClass7.smethod_0().method_78(data);
		}

		public void method_10(int skillID)
		{
			GClass63 gClass = GClass144.gclass63_0[skillID - 1];
			Thread.Sleep(100);
			if (gClass != null && GClass78.smethod_1().gclass63_0 != gClass)
				GClass144.smethod_8().method_62(gClass, true);
			Thread.Sleep(100);
			GClass144.smethod_8().method_63(gClass, true);
		}

		public void method_11(string dataKey)
		{
			GClass73.smethod_1().method_10(method_19(dataKey));
		}

		public void method_12()
		{
			if (GClass20.int_37 != GClass156.list_0[GClass156.list_0.Count - 1].int_0)
			{
				if (GClass148.smethod_0().bool_0)
					Class21.smethod_0().method_9();
				Class21.smethod_0().method_8(GClass156.list_0[GClass156.list_0.Count - 1].int_0);
			}
			else
			{
				GClass78.smethod_1().gclass29_0 = null;
				GClass73.smethod_49();
			}
		}

		public void method_13()
		{
			if (GClass78.smethod_1().bool_62)
				GClass7.smethod_0().method_76();
			else
				Class21.smethod_0().method_8(21 + GClass78.smethod_1().int_14);
		}

		public void method_14()
		{
			if (GClass78.smethod_1().int_68 + GClass78.smethod_1().int_69 > 0 && GClass78.smethod_1().bool_62 && GClass78.smethod_1().int_25 <= 0)
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

		public void method_15(bool flag)
		{
			GClass128[] gclass128_ = GClass78.smethod_1().gclass128_0;
			if (flag)
				try
				{
					for (int i = 0; i < gclass128_.Length; i++)
					{
						if (gclass128_[i] != null && gclass128_[i].gclass117_0.short_1 == 4387 && !GClass19.smethod_0(4387))
							GClass7.smethod_0().method_20(0, 1, -1, gclass128_[i].gclass117_0.short_0);
					}
					return;
				}
				catch
				{
					return;
				}
			try
			{
				for (int j = 0; j < gclass128_.Length; j++)
				{
					if (gclass128_[j] != null && gclass128_[j].gclass117_0.short_1 == 4387 && GClass19.smethod_0(4387))
						GClass7.smethod_0().method_20(0, 1, -1, gclass128_[j].gclass117_0.short_0);
				}
			}
			catch
			{
			}
		}

		public void method_16(int itemID)
		{
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass != null && gClass.gclass117_0.short_0 == itemID && !GClass19.smethod_0(gClass.gclass117_0.short_1))
					GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
			}
		}

		public void method_17(int CharID)
		{
			if (!GClass151.bool_3)
			{
				GClass149.smethod_1((GClass151.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
				return;
			}
			Thread.Sleep(500);
			for (int i = 0; i < GClass144.gclass63_0.Length; i++)
			{
				GClass63 gClass = GClass144.gclass63_0[i];
				if (gClass != null && gClass.gclass47_0.sbyte_0 == 14 && !gClass.bool_0 && CharID > 0 && GClass78.smethod_1().int_14 == 2 && GClass78.smethod_1().int_13 != CharID)
					GClass153.smethod_0().int_3 = CharID;
			}
		}

		public void method_18()
		{
			if (!GClass151.bool_3)
				GClass149.smethod_1((GClass151.int_0 != 0) ? "Contact admin to unlock this function!" : "Liên hệ admin để mở khóa chức năng này!", 1);
			else if (GClass78.smethod_1().int_14 == 2)
			{
				GClass153.smethod_0().bool_6 = true;
				GClass153.smethod_0().bool_5 = false;
			}
		}

        public int method_19(string KeyValue)
        {
            switch (KeyValue)
            {
                case "up":
                    return -1;
                case "down":
                    return -2;
                case "enter":
                    return -5;
                case "right":
                    return -4;
                case "f2":
                    return -22;
                case "f1":
                    return -21;
                case "left":
                    return -3;
                default:
                    return method_20(KeyValue);
            }
        }

        public int method_20(string text)
		{
			return char.Parse(text);
		}

		public void method_21()
		{
			if (!GClass78.smethod_1().bool_38)
				return;
			if (bool_0)
			{
				if (!GClass78.smethod_1().bool_4)
				{
					if (GClass203.smethod_18() - long_0 > 1000L)
					{
						GClass73.smethod_1().method_10(102);
						long_0 = GClass203.smethod_18();
					}
				}
				else
					bool_0 = false;
			}
			if (bool_1)
			{
				if (!GClass78.smethod_1().bool_4)
					bool_1 = false;
				else if (GClass203.smethod_18() - long_0 > 1000L)
				{
					GClass73.smethod_1().method_10(102);
					long_0 = GClass203.smethod_18();
				}
			}
		}

		public void method_22()
		{
			GClass73.smethod_1().method_10(99);
			Thread.Sleep(100);
			GClass7.smethod_0().method_126(0);
		}

		public void method_23(vMessage msg)
		{
			try
			{
				switch (msg.cmd)
				{
				case 1:
					Class21.smethod_0().method_8(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 2:
					GClass7.smethod_0().method_42(int.Parse(Encoding.ASCII.GetString(msg.data)), -1);
					Thread.Sleep(500);
					break;
				case 3:
					method_9(Encoding.ASCII.GetString(msg.data));
					break;
				case 4:
					GClass159.smethod_0().method_24(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 5:
					GClass159.smethod_0().int_5 = (Encoding.ASCII.GetString(msg.data).ToLower().Split('|')[0].Contains("true") ? int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]) : (-1));
					GClass159.smethod_0().bool_5 = Encoding.ASCII.GetString(msg.data).ToLower().Split('|')[0].Contains("true");
					Thread.Sleep(500);
					break;
				case 6:
					method_10(Convert.ToInt32(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 7:
					method_11(Encoding.ASCII.GetString(msg.data));
					Thread.Sleep(500);
					break;
				case 8:
					method_12();
					Thread.Sleep(500);
					break;
				case 9:
					GClass157.smethod_0().method_10(int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[0]), int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]));
					Thread.Sleep(500);
					break;
				case 10:
					GClass168.smethod_0().bool_0 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 11:
					GClass168.smethod_0().bool_2 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 12:
					GClass168.smethod_0().bool_1 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 13:
					GClass7.smethod_0().method_131(1, (sbyte)(Encoding.ASCII.GetString(msg.data).ToLower().Contains("true") ? 8 : 0));
					Thread.Sleep(500);
					break;
				case 14:
					GClass168.smethod_0().bool_3 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 15:
					GClass167.smethod_0().bool_5 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_6 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_7 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_8 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_9 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_10 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_11 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_13 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_17 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_18 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_20 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_21 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass167.smethod_0().bool_16 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 16:
					method_13();
					Thread.Sleep(500);
					break;
				case 17:
					method_14();
					Thread.Sleep(500);
					break;
				case 18:
					method_15(Encoding.ASCII.GetString(msg.data).ToLower().Equals("true"));
					Thread.Sleep(500);
					break;
				case 19:
					method_16(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 20:
					GClass157.smethod_0().int_0 = ((!Encoding.ASCII.GetString(msg.data).Split('|')[0].ToLower().Contains("true")) ? (-1) : int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]));
					Thread.Sleep(500);
					break;
				case 21:
					GClass157.smethod_0().bool_1 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 22:
					GClass157.smethod_0().bool_2 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 23:
					method_17(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 24:
					method_18();
					Thread.Sleep(500);
					break;
				case 25:
					method_22();
					Thread.Sleep(500);
					break;
				case 26:
					bool_0 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					bool_1 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("false");
					Thread.Sleep(500);
					break;
				case 27:
					GClass160.smethod_0().method_13();
					Thread.Sleep(500);
					break;
				case 28:
					GClass160.smethod_0().method_12();
					Thread.Sleep(500);
					break;
				case 29:
					GClass160.smethod_0().method_11();
					Thread.Sleep(500);
					break;
				case 30:
					GClass160.smethod_0().method_14();
					Thread.Sleep(500);
					break;
				case 31:
					GClass160.smethod_0().method_15();
					Thread.Sleep(500);
					break;
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/MessageReceiveError.txt", ex.Message + "\n" + ex.ToString());
			}
		}
	}
}
