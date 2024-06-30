using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;
using UnityEngine;

namespace ns1
{
	public class GClass172
	{
		public static GClass2 gclass2_0;

		private static GClass172 gclass172_0;

		private bool bool_0;

		private long long_0;

		private long long_1;

		public bool bool_1;

		public bool bool_2;

		public long long_2;

		public static GClass172 smethod_0()
		{
			return (gclass172_0 != null) ? gclass172_0 : (gclass172_0 = new GClass172());
		}

		public void method_0(int time)
		{
			bool_0 = true;
			long_0 = GClass138.smethod_18();
			long_1 = time;
		}

		public bool method_1()
		{
			if (bool_0 && GClass138.smethod_18() - long_0 >= long_1)
				bool_0 = false;
			return bool_0;
		}

		public bool method_2(string text)
		{
			return GClass183.smethod_0().method_1(text) || GClass177.smethod_0().method_2(text) || GClass195.smethod_0().method_2(text) || GClass171.smethod_0().method_0(text) || GClass196.smethod_0().method_0(text) || GClass189.smethod_0().method_3(text) || GClass191.smethod_0().method_3(text) || GClass197.smethod_0().method_3(text) || GClass175.smethod_0().method_0(text);
		}

		public bool method_3(int asciiCode)
		{
			if (GClass181.smethod_0().bool_0)
				return GClass181.smethod_3(asciiCode);
			return GClass183.smethod_0().method_0(asciiCode) || GClass177.smethod_0().method_1(asciiCode) || GClass196.smethod_0().method_1(asciiCode) || GClass189.smethod_0().method_4(asciiCode) || GClass171.smethod_0().method_1(asciiCode) || GClass191.smethod_0().method_2(asciiCode) || GClass197.smethod_0().method_2(asciiCode);
		}

		public void method_4()
		{
			GClass196.smethod_0().method_2();
			GClass189.smethod_0().method_5();
			GClass191.smethod_0().method_6();
			GClass175.smethod_0().method_2();
			GClass197.smethod_0().method_6();
			GClass195.smethod_0().method_3();
			GClass177.smethod_0().method_3();
			GClass183.smethod_0().method_30();
			GClass187.smethod_0().method_2();
			Class15.smethod_0().method_3();
			method_21();
		}

		public void method_5(GClass76 g)
		{
			method_7(g);
			if (GClass39.gclass145_0 != GClass150.gclass150_0)
			{
				GClass189.smethod_0().method_6(g);
				GClass191.smethod_0().method_7(g);
				GClass195.smethod_0().method_4(g);
				GClass177.smethod_0().method_4(g);
				GClass183.smethod_0().method_2(g);
			}
		}

		public void method_6(string s)
		{
			GClass171.smethod_0().method_3(s);
			GClass196.smethod_0().method_3(s);
			GClass177.smethod_0().method_7(s);
			GClass183.smethod_0().method_22(s);
		}

		public void method_7(GClass76 g)
		{
			if (GClass1.int_37 != 129)
			{
				if (gclass2_0 == null)
					gclass2_0 = GClass173.smethod_0().method_3(GClass192.bool_2 ? "Data/logo.png" : "logoGameScr", GClass76.int_12);
				else
					g.method_23(gclass2_0, 0, 0, GClass76.smethod_0(gclass2_0), GClass76.smethod_1(gclass2_0), 0, (GClass39.int_10 / 2 < GClass76.smethod_0(GClass154.gclass2_28)) ? (GClass76.smethod_0(GClass154.gclass2_28) + 25) : (GClass39.int_10 / 2), 5, (GClass39.int_10 / 2 < GClass76.smethod_0(GClass154.gclass2_28)) ? GClass76.int_2 : GClass76.int_0);
			}
			if (GClass39.gclass145_0 == GClass150.gclass150_0 || GClass173.smethod_0().bool_2)
				return;
			GUIStyle[] array = new GUIStyle[30];
			GUIStyle[] array2 = new GUIStyle[30];
			int num = 1;
			List<string> list = new List<string>();
			list.Add("[" + GClass1.int_37 + "] " + GClass1.string_1 + "- K" + GClass1.int_39 + " [" + (GClass175.smethod_0().method_8() + 1) + (GClass177.smethod_0().method_5() ? "/20]" : "/15]"));
			list.Add("TG: " + DateTime.Now.ToString("HH:mm:ss - d/M/yyyy"));
			list.Add("X: " + GClass58.smethod_1().int_4 + " Y: " + GClass58.smethod_1().int_5);
			if (GClass196.smethod_0().bool_0)
				list.Add((GClass192.int_0 == 0) ? ("Auto đánh: " + GClass193.smethod_0().method_7(GClass196.smethod_0().bool_0)) : ("Auto Attack: " + GClass193.smethod_0().method_7(GClass196.smethod_0().bool_0)));
			if (GClass197.smethod_0().bool_5)
				list.Add((GClass192.int_0 == 0) ? ("Auto nhặt: " + GClass193.smethod_0().method_7(GClass197.smethod_0().bool_5)) : ("Auto pick-up: " + GClass193.smethod_0().method_7(GClass197.smethod_0().bool_5)));
			if (GClass191.smethod_0().bool_8)
				list.Add((GClass192.int_0 == 0) ? ("Auto hồi sinh: " + GClass193.smethod_0().method_7(GClass191.smethod_0().bool_8)) : ("Auto Revive: " + GClass193.smethod_0().method_7(GClass191.smethod_0().bool_8)));
			if (GClass195.smethod_0().bool_3)
				list.Add("Auto jump: " + GClass193.smethod_0().method_7(GClass195.smethod_0().bool_3));
			if (GClass191.smethod_0().bool_2)
				list.Add((GClass192.int_0 == 0) ? $"Khóa ID [{GClass191.smethod_0().int_2}]" : $"Lock ID [{GClass191.smethod_0().int_2}]");
			if (GClass177.smethod_0().bool_1)
				list.Add((GClass192.int_0 == 0) ? ("Auto phù x7: " + GClass193.smethod_0().method_7(GClass177.smethod_0().bool_1)) : ("Auto get x7: " + GClass193.smethod_0().method_7(GClass177.smethod_0().bool_1)));
			if (GClass177.smethod_0().bool_4)
				list.Add((GClass192.int_0 == 0) ? ("Auto vệ tinh: " + GClass193.smethod_0().method_7(GClass177.smethod_0().bool_4)) : ("Auto satellite: " + GClass193.smethod_0().method_7(GClass177.smethod_0().bool_4)));
			if (GClass177.smethod_0().bool_3)
				list.Add((GClass192.int_0 == 0) ? $"Auto sáo đè [{GClass177.smethod_0().int_1}] khi dưới {GClass177.smethod_0().int_2}% HP" : $"Auto whistle [{GClass177.smethod_0().int_1}] when HP < {GClass177.smethod_0().int_2}% HP");
			if (GClass174.smethod_0().bool_0)
				list.Add((GClass192.int_0 == 0) ? "ĐÃ KẾT NỐI" : "CONNECTED");
			int num2 = 104;
			if (GClass76.int_12 == 2)
			{
				for (int i = 0; i < list.Count; i++)
				{
					array[i] = new GUIStyle(GUI.skin.label)
					{
						alignment = TextAnchor.UpperLeft,
						fontSize = 7 * GClass76.int_12,
						fontStyle = FontStyle.Bold
					};
					array2[i] = new GUIStyle(GUI.skin.label)
					{
						alignment = TextAnchor.UpperLeft,
						fontSize = 7 * GClass76.int_12,
						fontStyle = FontStyle.Bold
					};
					array[i].normal.textColor = Color.black;
					if (list[i].StartsWith("Khóa ID") || list[i].StartsWith("Auto phù x7") || list[i].StartsWith("Auto vệ tinh:") || list[i].StartsWith("Auto sáo") || list[i].StartsWith("Lock ID") || list[i].StartsWith("Auto get x7") || list[i].StartsWith("Auto satellite") || list[i].StartsWith("Auto whistl") || list[i].StartsWith((GClass192.int_0 == 0) ? "ĐÃ KẾT NỐI" : "CONNECTED"))
						array[i].normal.textColor = Color.red;
					array2[i].normal.textColor = Color.white;
					g.method_19(list[i], 24.5f, (float)(num2 + i * 8) - 0.5f, array2[i]);
					g.method_19(list[i], 24.5f, (float)(num2 + i * 8) + 0.5f, array2[i]);
					g.method_19(list[i], 25.5f, (float)(num2 + i * 8) - 0.5f, array2[i]);
					g.method_19(list[i], 25.5f, (float)(num2 + i * 8) + 0.5f, array2[i]);
					g.method_19(list[i], 25f, (float)(num2 + i * 8) - 0.5f, array2[i]);
					g.method_19(list[i], 25f, (float)(num2 + i * 8) + 0.5f, array2[i]);
					g.method_19(list[i], 24.5f, num2 + i * 8, array2[i]);
					g.method_19(list[i], 25.5f, num2 + i * 8, array2[i]);
					g.method_19(list[i], 25f, num2 + i * 8, array[i]);
					GClass191.smethod_0().int_19 = num2 + list.Count * 8;
					GClass195.smethod_0().int_1 = num2 + list.Count * 8;
					num++;
				}
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					GClass49 gClass = ((!list[j].StartsWith("Khóa ID") && !list[j].StartsWith("Auto phù x7") && !list[j].StartsWith("Auto vệ tinh:") && !list[j].StartsWith("Auto sáo") && !list[j].StartsWith("Lock ID") && !list[j].StartsWith("Auto get x7") && !list[j].StartsWith("Auto satellite") && !list[j].StartsWith("Auto whistl") && !list[j].StartsWith((GClass192.int_0 == 0) ? "ĐÃ KẾT NỐI" : "CONNECTED")) ? GClass49.gclass49_20 : GClass49.gclass49_1);
					GClass49 gClass2 = ((gClass == GClass49.gclass49_1) ? GClass49.gclass49_6 : GClass49.gclass49_11);
					gClass2.method_6(g, list[j], 24, num2 + j * 10 - 1, 0);
					gClass2.method_6(g, list[j], 24, num2 + j * 10 + 1, 0);
					gClass2.method_6(g, list[j], 26, num2 + j * 10 - 1, 0);
					gClass2.method_6(g, list[j], 26, num2 + j * 10 + 1, 0);
					gClass2.method_6(g, list[j], 25, num2 + j * 10 - 1, 0);
					gClass2.method_6(g, list[j], 25, num2 + j * 10 + 1, 0);
					gClass2.method_6(g, list[j], 24, num2 + j * 10, 0);
					gClass2.method_6(g, list[j], 26, num2 + j * 10, 0);
					gClass.method_6(g, list[j], 25, num2 + j * 10, 0);
					GClass191.smethod_0().int_19 = num2 + list.Count * 10;
					GClass195.smethod_0().int_1 = num2 + list.Count * 10;
					num++;
				}
			}
		}

		public void method_8(string data)
		{
			if (data.Contains(","))
			{
				string[] array = data.Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					GClass166.smethod_0().method_78(array[i]);
					Thread.Sleep(1000);
				}
			}
			else
				GClass166.smethod_0().method_78(data);
		}

		public void method_9(int skillID)
		{
			GClass74 gClass = GClass154.gclass74_0[skillID - 1];
			Thread.Sleep(100);
			if (gClass != null && GClass58.smethod_1().gclass74_0 != gClass)
				GClass154.smethod_8().method_62(gClass, true);
			Thread.Sleep(100);
			GClass154.smethod_8().method_63(gClass, true);
		}

		public void method_10(string dataKey)
		{
			if (dataKey.Contains("|"))
			{
				string[] array = dataKey.Split('|');
				for (int i = 0; i < array.Length; i++)
				{
					GClass39.smethod_1().method_10(method_19(array[i]));
					Thread.Sleep(1000);
				}
			}
			else
				GClass39.smethod_1().method_10(method_19(dataKey));
		}

		public void method_11()
		{
			if (GClass1.int_37 != GClass179.list_0[GClass179.list_0.Count - 1].int_0)
			{
				if (GClass171.smethod_0().bool_0)
					Class14.smethod_0().method_8();
				Class14.smethod_0().method_7(GClass179.list_0[GClass179.list_0.Count - 1].int_0);
			}
			else
			{
				GClass58.smethod_1().gclass136_0 = null;
				GClass39.smethod_49();
			}
		}

		public void method_12()
		{
			if (GClass58.smethod_1().bool_62)
				GClass166.smethod_0().method_76();
			else
				Class14.smethod_0().method_7(21 + GClass58.smethod_1().int_14);
		}

		public void method_13()
		{
			if (GClass58.smethod_1().int_68 + GClass58.smethod_1().int_69 > 0 && GClass58.smethod_1().bool_62 && GClass58.smethod_1().int_25 <= 0)
			{
				GClass166.smethod_0().method_77();
				GClass58.smethod_1().bool_62 = false;
				GClass58.smethod_1().int_11 = 1;
				GClass58.smethod_1().int_25 = GClass58.smethod_1().int_35;
				GClass58.smethod_1().int_24 = GClass58.smethod_1().int_36;
				GClass58 gClass = GClass58.smethod_1();
				GClass58 gClass2 = GClass58.smethod_1();
				GClass58.smethod_1().int_10 = 0;
				gClass2.int_9 = 0;
				gClass.int_8 = 0;
				GClass71.smethod_3(109, GClass58.smethod_1(), 2);
				GClass154.smethod_8().gclass14_1 = null;
				GClass154.bool_16 = true;
			}
		}

		public void method_14(bool flag)
		{
			GClass121[] gclass121_ = GClass58.smethod_1().gclass121_0;
			if (flag)
				try
				{
					for (int i = 0; i < gclass121_.Length; i++)
					{
						if (gclass121_[i].gclass118_0.short_1 == 4387 && !GClass82.smethod_0(4387))
							GClass166.smethod_0().method_20(0, 1, -1, gclass121_[i].gclass118_0.short_0);
					}
					return;
				}
				catch
				{
					return;
				}
			try
			{
				for (int j = 0; j < gclass121_.Length; j++)
				{
					if (gclass121_[j].gclass118_0.short_1 == 4387 && GClass82.smethod_0(4387))
						GClass166.smethod_0().method_20(0, 1, -1, gclass121_[j].gclass118_0.short_0);
				}
			}
			catch
			{
			}
		}

		public void method_15(int itemID)
		{
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass != null && gClass.gclass118_0.short_0 == itemID && !GClass82.smethod_0(gClass.gclass118_0.short_1))
					GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
			}
		}

		public void method_16(int CharID)
		{
			if (!GClass192.bool_3)
			{
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
				return;
			}
			Thread.Sleep(500);
			for (int i = 0; i < GClass154.gclass74_0.Length; i++)
			{
				GClass74 gClass = GClass154.gclass74_0[i];
				if (gClass != null && gClass.gclass53_0.sbyte_0 == 14 && !gClass.bool_0 && CharID > 0 && GClass58.smethod_1().int_14 == 2 && GClass58.smethod_1().int_13 != CharID)
					GClass177.smethod_0().int_3 = CharID;
			}
		}

		public void method_17()
		{
			if (!GClass192.bool_3)
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
			else if (GClass58.smethod_1().int_14 == 2)
			{
				GClass177.smethod_0().bool_6 = true;
				GClass177.smethod_0().bool_5 = false;
			}
		}

		public void method_18(vMessage msg)
		{
			try
			{
				switch (msg.cmd)
				{
				case 1:
					Class14.smethod_0().method_7(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 2:
					GClass166.smethod_0().method_42(int.Parse(Encoding.ASCII.GetString(msg.data)), -1);
					Thread.Sleep(500);
					break;
				case 3:
					method_8(Encoding.ASCII.GetString(msg.data));
					break;
				case 4:
					GClass191.smethod_0().method_23(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 5:
					GClass191.smethod_0().int_5 = (Encoding.ASCII.GetString(msg.data).ToLower().Split('|')[0].Contains("true") ? int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]) : (-1));
					GClass191.smethod_0().bool_4 = Encoding.ASCII.GetString(msg.data).ToLower().Split('|')[0].Contains("true");
					Thread.Sleep(500);
					break;
				case 6:
					method_9(Convert.ToInt32(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 7:
					method_10(Encoding.ASCII.GetString(msg.data));
					Thread.Sleep(500);
					break;
				case 8:
					method_11();
					Thread.Sleep(500);
					break;
				case 9:
					GClass175.smethod_0().method_9(int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[0]), int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]));
					Thread.Sleep(500);
					break;
				case 10:
					GClass195.smethod_0().bool_0 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 11:
					GClass195.smethod_0().bool_2 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 12:
					GClass195.smethod_0().bool_1 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 13:
					GClass166.smethod_0().method_131(1, (sbyte)(Encoding.ASCII.GetString(msg.data).ToLower().Contains("true") ? 8 : 0));
					Thread.Sleep(500);
					break;
				case 14:
					GClass195.smethod_0().bool_3 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 15:
					GClass173.smethod_0().bool_4 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_5 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_6 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_7 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_8 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_9 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_10 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_11 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_14 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_15 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_17 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					GClass173.smethod_0().bool_18 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 16:
					method_12();
					Thread.Sleep(500);
					break;
				case 17:
					method_13();
					Thread.Sleep(500);
					break;
				case 18:
					method_14(Encoding.ASCII.GetString(msg.data).ToLower().Equals("true"));
					Thread.Sleep(500);
					break;
				case 19:
					method_15(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 20:
					GClass175.smethod_0().int_0 = (Encoding.ASCII.GetString(msg.data).Split('|')[0].ToLower().Contains("true") ? int.Parse(Encoding.ASCII.GetString(msg.data).Split('|')[1]) : (-1));
					Thread.Sleep(500);
					break;
				case 21:
					GClass175.smethod_0().bool_1 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 22:
					GClass175.smethod_0().bool_2 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					Thread.Sleep(500);
					break;
				case 23:
					method_16(int.Parse(Encoding.ASCII.GetString(msg.data)));
					Thread.Sleep(500);
					break;
				case 24:
					method_17();
					Thread.Sleep(500);
					break;
				case 25:
					method_22();
					Thread.Sleep(500);
					break;
				case 26:
					bool_1 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("true");
					bool_2 = Encoding.ASCII.GetString(msg.data).ToLower().Contains("false");
					Thread.Sleep(500);
					break;
				case 27:
					GClass183.smethod_0().method_9();
					Thread.Sleep(500);
					break;
				case 28:
					GClass183.smethod_0().method_8();
					Thread.Sleep(500);
					break;
				case 29:
					GClass183.smethod_0().method_7();
					Thread.Sleep(500);
					break;
				case 30:
					GClass183.smethod_0().method_10();
					Thread.Sleep(500);
					break;
				case 31:
					GClass183.smethod_0().method_11();
					Thread.Sleep(500);
					break;
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/MessageReceiveError.txt", ex.Message + "\n" + ex.ToString());
			}
		}

		public int method_19(string KeyValue)
		{
			switch (KeyValue)
			{
			case "up":
				return -1;
			case "f2":
				return -22;
			case "f1":
				return -21;
			case "left":
				return -3;
			case "down":
				return -2;
			case "right":
				return -4;
			case "enter":
				return -5;
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
			if (!GClass58.smethod_1().bool_38)
				return;
			if (bool_1)
			{
				if (!GClass58.smethod_1().bool_4)
				{
					if (GClass138.smethod_18() - long_2 > 1000L)
					{
						GClass39.smethod_1().method_10(102);
						long_2 = GClass138.smethod_18();
					}
				}
				else
					bool_1 = false;
			}
			if (!bool_2)
				return;
			if (GClass58.smethod_1().bool_4)
			{
				if (GClass138.smethod_18() - long_2 > 1000L)
				{
					GClass39.smethod_1().method_10(102);
					long_2 = GClass138.smethod_18();
				}
			}
			else
				bool_2 = false;
		}

		public void method_22()
		{
			GClass39.smethod_1().method_10(99);
			Thread.Sleep(100);
			GClass166.smethod_0().method_126(0);
		}
	}
}
