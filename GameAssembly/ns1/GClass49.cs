using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;
using UnityEngine;

namespace ns1
{
	public class GClass49
	{
		public bool bool_0;

		public bool bool_1;

		public long long_0;

		public static GClass20 gclass20_0;

		private static GClass49 gclass49_0;

		private bool bool_2;

		private long long_1;

		private long long_2;

		private bool bool_3;

		public static GClass49 smethod_0()
		{
			return (gclass49_0 != null) ? gclass49_0 : (gclass49_0 = new GClass49());
		}

		public void method_0(int time)
		{
			bool_2 = true;
			long_1 = GClass77.smethod_18();
			long_2 = time;
		}

		public bool method_1()
		{
			if (bool_2 && GClass77.smethod_18() - long_1 >= long_2)
				bool_2 = false;
			return bool_2;
		}

		public bool method_2(string text)
		{
			return GClass42.smethod_0().method_1(text) || GClass54.smethod_0().method_2(text) || GClass65.smethod_0().method_2(text) || GClass57.smethod_0().method_0(text) || GClass41.smethod_0().method_0(text) || GClass58.smethod_0().method_3(text) || GClass47.smethod_0().method_3(text) || GClass48.smethod_0().method_3(text) || GClass61.smethod_0().method_0(text);
		}

		public bool method_3(int asciiCode)
		{
			if (!GClass52.smethod_0().bool_0)
				return GClass42.smethod_0().method_0(asciiCode) || GClass54.smethod_0().method_1(asciiCode) || GClass41.smethod_0().method_1(asciiCode) || GClass58.smethod_0().method_4(asciiCode) || GClass57.smethod_0().method_1(asciiCode) || GClass47.smethod_0().method_2(asciiCode) || GClass48.smethod_0().method_2(asciiCode);
			return GClass52.smethod_3(asciiCode);
		}

		public void method_4()
		{
			GClass41.smethod_0().method_2();
			GClass58.smethod_0().method_5();
			GClass47.smethod_0().method_5();
			GClass61.smethod_0().method_2();
			GClass48.smethod_0().method_6();
			GClass65.smethod_0().method_3();
			GClass54.smethod_0().method_3();
			GClass42.smethod_0().method_32();
			GClass40.smethod_0().method_2();
			Class7.smethod_0().method_1();
			method_21();
			if (GClass55.smethod_0().bool_0 && !bool_3)
			{
				GClass55.smethod_0().method_0(GClass50.int_0);
				bool_3 = true;
			}
		}

		public void method_5(GClass193 g)
		{
			method_8(g);
			if (GClass14.gclass160_0 != GClass162.gclass162_0)
			{
				if (GClass137.int_39 != GClass61.smethod_0().int_0 && GClass61.smethod_0().int_0 > -1)
					GClass45.smethod_0().method_1(GClass104.gclass104_20, g, (GClass62.int_0 == 0) ? $"Đổi khu sau {GClass88.int_24} giây nữa !" : $"Change zone after {GClass88.int_24}s later", GClass14.int_10 / 2, GClass14.int_11 / 2, GClass104.int_2, GClass104.gclass104_11);
				GClass58.smethod_0().method_6(g);
				GClass47.smethod_0().method_6(g);
				GClass65.smethod_0().method_4(g);
				GClass54.smethod_0().method_4(g);
				GClass42.smethod_0().method_3(g);
			}
		}

		public void method_6(string s)
		{
			GClass57.smethod_0().method_3(s);
			GClass41.smethod_0().method_3(s);
			GClass54.smethod_0().method_7(s);
			GClass42.smethod_0().method_25(s);
		}

		public string method_7(long timeDie)
		{
			return ((GClass77.smethod_18() - timeDie) / 1000L).ToString();
		}

		public void method_8(GClass193 g)
		{
			if (GClass137.int_37 != 129)
			{
				if (gclass20_0 != null)
					g.method_23(gclass20_0, 0, 0, GClass193.smethod_0(gclass20_0), GClass193.smethod_1(gclass20_0), 0, (GClass14.int_10 / 2 < GClass193.smethod_0(GClass167.gclass20_28)) ? (GClass193.smethod_0(GClass167.gclass20_28) + 25) : (GClass14.int_10 / 2), 5, (GClass14.int_10 / 2 < GClass193.smethod_0(GClass167.gclass20_28)) ? GClass193.int_2 : GClass193.int_0);
				else
					gclass20_0 = GClass66.smethod_0().method_4(GClass62.bool_2 ? "Data/logo.png" : "logoGameScr", GClass193.int_12);
			}
			if (GClass14.gclass160_0 == GClass162.gclass162_0 || GClass66.smethod_0().bool_3)
				return;
			GUIStyle[] array = new GUIStyle[30];
			GUIStyle[] array2 = new GUIStyle[30];
			int num = 1;
			List<string> list = new List<string>();
			list.Add("[" + GClass137.int_37 + "] " + GClass137.string_1 + "- K" + GClass137.int_39 + " [" + (GClass61.smethod_0().method_8() + 1) + (GClass54.smethod_0().method_5() ? "/20]" : "/15]"));
			list.Add("TG: " + DateTime.Now.ToString("HH:mm:ss - d/M/yyyy"));
			list.Add("X: " + GClass124.smethod_1().int_4 + " Y: " + GClass124.smethod_1().int_5);
			if (GClass41.smethod_0().bool_0)
				list.Add((GClass62.int_0 != 0) ? ("Auto Attack: " + GClass45.smethod_0().method_7(GClass41.smethod_0().bool_0)) : ("Auto đánh: " + GClass45.smethod_0().method_7(GClass41.smethod_0().bool_0)));
			if (GClass48.smethod_0().bool_5)
				list.Add((GClass62.int_0 == 0) ? ("Auto nhặt: " + GClass45.smethod_0().method_7(GClass48.smethod_0().bool_5)) : ("Auto pick-up: " + GClass45.smethod_0().method_7(GClass48.smethod_0().bool_5)));
			if (GClass47.smethod_0().bool_8)
				list.Add((GClass62.int_0 != 0) ? ("Auto Revive: " + GClass45.smethod_0().method_7(GClass47.smethod_0().bool_8)) : ("Auto hồi sinh: " + GClass45.smethod_0().method_7(GClass47.smethod_0().bool_8)));
			if (GClass65.smethod_0().bool_3)
				list.Add("Auto jump: " + GClass45.smethod_0().method_7(GClass65.smethod_0().bool_3));
			if (GClass47.smethod_0().bool_2)
				list.Add((GClass62.int_0 != 0) ? $"Lock ID [{GClass47.smethod_0().int_2}]" : $"Khóa ID [{GClass47.smethod_0().int_2}]");
			if (GClass54.smethod_0().bool_1)
				list.Add((GClass62.int_0 != 0) ? ("Auto get x7: " + GClass45.smethod_0().method_7(GClass54.smethod_0().bool_1)) : ("Auto phù x7: " + GClass45.smethod_0().method_7(GClass54.smethod_0().bool_1)));
			if (GClass54.smethod_0().bool_4)
				list.Add((GClass62.int_0 == 0) ? ("Auto vệ tinh: " + GClass45.smethod_0().method_7(GClass54.smethod_0().bool_4)) : ("Auto satellite: " + GClass45.smethod_0().method_7(GClass54.smethod_0().bool_4)));
			if (GClass54.smethod_0().bool_3)
				list.Add((GClass62.int_0 == 0) ? $"Auto sáo đè [{GClass54.smethod_0().int_1}] khi dưới {GClass54.smethod_0().int_2}% HP" : $"Auto whistle [{GClass54.smethod_0().int_1}] when HP < {GClass54.smethod_0().int_2}% HP");
			if (GClass55.smethod_0().bool_0)
				list.Add((GClass62.int_0 != 0) ? "CONNECTED" : "ĐÃ KẾT NỐI");
			if (GClass124.smethod_1().int_11 == 14)
				list.Add((GClass62.int_0 != 0) ? ("Time die: " + method_7(GClass124.smethod_1().long_14) + "s") : ("T/g chết: " + method_7(GClass124.smethod_1().long_14) + "s"));
			int num2 = ((!GClass54.smethod_0().method_5()) ? 104 : 80);
			if (GClass193.int_12 == 2)
			{
				for (int i = 0; i < list.Count; i++)
				{
					array[i] = new GUIStyle(GUI.skin.label)
					{
						alignment = TextAnchor.UpperLeft,
						fontSize = 7 * GClass193.int_12,
						fontStyle = FontStyle.Bold
					};
					array2[i] = new GUIStyle(GUI.skin.label)
					{
						alignment = TextAnchor.UpperLeft,
						fontSize = 7 * GClass193.int_12,
						fontStyle = FontStyle.Bold
					};
					array[i].normal.textColor = Color.white;
					if (list[i].StartsWith("Khóa ID") || list[i].StartsWith("Auto phù x7") || list[i].StartsWith("Auto vệ tinh:") || list[i].StartsWith("Auto sáo") || list[i].StartsWith("Lock ID") || list[i].StartsWith("Auto get x7") || list[i].StartsWith("Auto satellite") || list[i].StartsWith("Auto whistl") || list[i].StartsWith((GClass62.int_0 != 0) ? "CONNECTED" : "ĐÃ KẾT NỐI"))
						array[i].normal.textColor = Color.red;
					array2[i].normal.textColor = Color.black;
					g.method_19(list[i], 24.5f, (float)(num2 + i * 8) - 0.5f, array2[i]);
					g.method_19(list[i], 24.5f, (float)(num2 + i * 8) + 0.5f, array2[i]);
					g.method_19(list[i], 25.5f, (float)(num2 + i * 8) - 0.5f, array2[i]);
					g.method_19(list[i], 25.5f, (float)(num2 + i * 8) + 0.5f, array2[i]);
					g.method_19(list[i], 25f, (float)(num2 + i * 8) - 0.5f, array2[i]);
					g.method_19(list[i], 25f, (float)(num2 + i * 8) + 0.5f, array2[i]);
					g.method_19(list[i], 24.5f, num2 + i * 8, array2[i]);
					g.method_19(list[i], 25.5f, num2 + i * 8, array2[i]);
					g.method_19(list[i], 25f, num2 + i * 8, array[i]);
					GClass47.smethod_0().int_19 = num2 + list.Count * 8;
					GClass65.smethod_0().int_1 = num2 + list.Count * 8;
					num++;
				}
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					GClass104 gClass = ((list[j].StartsWith("Khóa ID") || list[j].StartsWith("Auto phù x7") || list[j].StartsWith("Auto vệ tinh:") || list[j].StartsWith("Auto sáo") || list[j].StartsWith("Lock ID") || list[j].StartsWith("Auto get x7") || list[j].StartsWith("Auto satellite") || list[j].StartsWith("Auto whistl") || list[j].StartsWith((GClass62.int_0 == 0) ? "ĐÃ KẾT NỐI" : "CONNECTED")) ? GClass104.gclass104_1 : GClass104.gclass104_20);
					GClass104 gClass2 = ((gClass == GClass104.gclass104_1) ? GClass104.gclass104_6 : GClass104.gclass104_11);
					gClass2.method_6(g, list[j], 24, num2 + j * 10 - 1, 0);
					gClass2.method_6(g, list[j], 24, num2 + j * 10 + 1, 0);
					gClass2.method_6(g, list[j], 26, num2 + j * 10 - 1, 0);
					gClass2.method_6(g, list[j], 26, num2 + j * 10 + 1, 0);
					gClass2.method_6(g, list[j], 25, num2 + j * 10 - 1, 0);
					gClass2.method_6(g, list[j], 25, num2 + j * 10 + 1, 0);
					gClass2.method_6(g, list[j], 24, num2 + j * 10, 0);
					gClass2.method_6(g, list[j], 26, num2 + j * 10, 0);
					gClass.method_6(g, list[j], 25, num2 + j * 10, 0);
					GClass47.smethod_0().int_19 = num2 + list.Count * 10;
					GClass65.smethod_0().int_1 = num2 + list.Count * 10;
					num++;
				}
			}
		}

		public void method_9(string data)
		{
			GClass2.smethod_0().method_78(data);
		}

		public void method_10(int skillID)
		{
			GClass95 gClass = GClass167.gclass95_0[skillID - 1];
			Thread.Sleep(100);
			if (gClass != null && GClass124.smethod_1().gclass95_0 != gClass)
				GClass167.smethod_8().method_62(gClass, true);
			Thread.Sleep(100);
			GClass167.smethod_8().method_63(gClass, true);
		}

		public void method_11(string dataKey)
		{
			GClass14.smethod_1().method_10(method_19(dataKey));
		}

		public void method_12()
		{
			if (GClass137.int_37 != GClass44.list_0[GClass44.list_0.Count - 1].int_0)
			{
				if (GClass57.smethod_0().bool_0)
					Class11.smethod_0().method_9();
				Class11.smethod_0().method_8(GClass44.list_0[GClass44.list_0.Count - 1].int_0);
			}
			else
			{
				GClass124.smethod_1().gclass119_0 = null;
				GClass14.smethod_49();
			}
		}

		public void method_13()
		{
			if (GClass124.smethod_1().bool_62)
				GClass2.smethod_0().method_76();
			else
				Class11.smethod_0().method_8(21 + GClass124.smethod_1().int_14);
		}

		public void method_14()
		{
			if (GClass124.smethod_1().int_68 + GClass124.smethod_1().int_69 > 0 && GClass124.smethod_1().bool_62 && GClass124.smethod_1().int_25 <= 0)
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

		public void method_15(bool flag)
		{
			GClass0[] gclass0_ = GClass124.smethod_1().gclass0_0;
			if (flag)
				try
				{
					for (int i = 0; i < gclass0_.Length; i++)
					{
						if (gclass0_[i] != null && gclass0_[i].gclass203_0.short_1 == 4387 && !GClass82.smethod_0(4387))
							GClass2.smethod_0().method_20(0, 1, -1, gclass0_[i].gclass203_0.short_0);
					}
					return;
				}
				catch
				{
					return;
				}
			try
			{
				for (int j = 0; j < gclass0_.Length; j++)
				{
					if (gclass0_[j] != null && gclass0_[j].gclass203_0.short_1 == 4387 && GClass82.smethod_0(4387))
						GClass2.smethod_0().method_20(0, 1, -1, gclass0_[j].gclass203_0.short_0);
				}
			}
			catch
			{
			}
		}

		public void method_16(int itemID)
		{
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass != null && gClass.gclass203_0.short_0 == itemID && !GClass82.smethod_0(gClass.gclass203_0.short_1))
					GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
			}
		}

		public void method_17(int CharID)
		{
			if (!GClass62.bool_3)
			{
				GClass51.smethod_1((GClass62.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
				return;
			}
			Thread.Sleep(500);
			for (int i = 0; i < GClass167.gclass95_0.Length; i++)
			{
				GClass95 gClass = GClass167.gclass95_0[i];
				if (gClass != null && gClass.gclass205_0.sbyte_0 == 14 && !gClass.bool_0 && CharID > 0 && GClass124.smethod_1().int_14 == 2 && GClass124.smethod_1().int_13 != CharID)
					GClass54.smethod_0().int_3 = CharID;
			}
		}

		public void method_18()
		{
			if (GClass62.bool_3)
			{
				if (GClass124.smethod_1().int_14 == 2)
				{
					GClass54.smethod_0().bool_6 = true;
					GClass54.smethod_0().bool_5 = false;
				}
			}
			else
				GClass51.smethod_1((GClass62.int_0 != 0) ? "Contact admin to unlock this function!" : "Liên hệ admin để mở khóa chức năng này!", 1);
		}

		public int method_19(string keyValue)
		{
			switch (keyValue)
			{
				case "up":
                    return -1;
                case "down":
                    return -2;
                case "left":
                    return -3;
                case "right":
                    return -4;
                case "enter":
                    return -5;
                case "f1":
                    return -21;
                case "f2":
                    return -22;
				default:
					return method_20(keyValue);
            }
		}

		public int method_20(string text)
		{
			return char.Parse(text);
		}

		public void method_21()
		{
			if (!GClass124.smethod_1().bool_38)
				return;
			if (bool_0)
			{
				if (!GClass124.smethod_1().bool_4)
				{
					if (GClass77.smethod_18() - long_0 > 1000L)
					{
						GClass14.smethod_1().method_10(102);
						long_0 = GClass77.smethod_18();
					}
				}
				else
					bool_0 = false;
			}
			if (bool_1)
			{
				if (!GClass124.smethod_1().bool_4)
					bool_1 = false;
				else if (GClass77.smethod_18() - long_0 > 1000L)
				{
					GClass14.smethod_1().method_10(102);
					long_0 = GClass77.smethod_18();
				}
			}
		}

		public void method_22()
		{
			GClass14.smethod_1().method_10(99);
			Thread.Sleep(100);
			GClass2.smethod_0().method_126(0);
		}

		public void method_23(vMessage msg)
		{
			try
			{
				switch (msg.cmd)
				{
				case 1:
					Class11.smethod_0().method_8(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 2:
					GClass2.smethod_0().method_42(int.Parse(Encoding.ASCII.GetString(msg.data)), -1);
					Thread.Sleep(500);
					break;
				case 3:
					method_9(Encoding.ASCII.GetString(msg.data));
					break;
				case 4:
					GClass47.smethod_0().method_24(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 5:
					GClass47.smethod_0().int_5 = ((!Encoding.ASCII.GetString(msg.data).ToLower().Split('|')[0].Contains("true")) ? (-1) : int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]));
					GClass47.smethod_0().bool_4 = Encoding.ASCII.GetString(msg.data).ToLower().Split('|')[0].Contains("true");
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
					GClass61.smethod_0().method_9(int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[0]), int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]));
					Thread.Sleep(500);
					break;
				case 10:
					GClass65.smethod_0().bool_0 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 11:
					GClass65.smethod_0().bool_2 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 12:
					GClass65.smethod_0().bool_1 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 13:
					GClass2.smethod_0().method_131(1, (sbyte)(Encoding.ASCII.GetString(msg.data).ToLower().Contains("true") ? 8 : 0));
					Thread.Sleep(500);
					break;
				case 14:
					GClass65.smethod_0().bool_3 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 15:
					GClass66.smethod_0().bool_5 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_6 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_7 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_8 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_9 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_10 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_11 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_13 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_17 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_18 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_20 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_21 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass66.smethod_0().bool_16 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
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
					GClass61.smethod_0().int_0 = ((!Encoding.ASCII.GetString(msg.data).Split('|')[0].ToLower().Contains("true")) ? (-1) : int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]));
					Thread.Sleep(500);
					break;
				case 21:
					GClass61.smethod_0().bool_1 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 22:
					GClass61.smethod_0().bool_2 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
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
					GClass42.smethod_0().method_13();
					Thread.Sleep(500);
					break;
				case 28:
					GClass42.smethod_0().method_12();
					Thread.Sleep(500);
					break;
				case 29:
					GClass42.smethod_0().method_11();
					Thread.Sleep(500);
					break;
				case 30:
					GClass42.smethod_0().method_14();
					Thread.Sleep(500);
					break;
				case 31:
					GClass42.smethod_0().method_15();
					Thread.Sleep(500);
					break;
				}
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/MessageReceiveError.txt", ex.Message + "\n" + ex.ToString());
			}
		}
	}
}
