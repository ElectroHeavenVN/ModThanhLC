using System.IO;
using UnityEngine;

namespace ns1
{
	public class GClass199
	{
		public bool bool_0 = true;

		public static string string_0;

		public static string string_1;

		public static string string_2;

		public static string string_3 = "Data/QLTK/GraphicSetting.ini";

		public static string string_4 = "Data/QLTK/FunctionSetting.ini";

		public static string string_5 = "Data/QLTK/Port.ini";

		public static int int_0 = int.Parse(File.ReadAllText(string_5));

		public bool bool_1;

		public static string string_6;

		public static string string_7;

		public static string string_8;

		public int int_1;

		private static GClass199 gclass199_0;

		public bool bool_2;

		public long long_0;

		public bool bool_3;

		public long long_1;

		public bool bool_4;

		public long long_2;

		public bool bool_5 = true;

		public static GClass199 smethod_0()
		{
			return (gclass199_0 != null) ? gclass199_0 : (gclass199_0 = new GClass199());
		}

		public void method_0()
		{
			string_0 = Main.arguments["username"];
			string_1 = Main.arguments["password"];
			string_2 = Main.arguments["server"];
			GClass192.string_4 = Main.arguments["options"];
			if (Main.arguments["uuid"] == null || Main.arguments["uuid"] == string.Empty)
				Application.Quit();
			else
				GClass192.string_2 = Main.arguments["uuid"];
			bool_1 = Main.arguments["isUseProxy"].ToLower().Contains("true");
			if (bool_1)
			{
				string[] array = Main.arguments["proxy"].Split(':');
				string_8 = array[0];
				int_1 = int.Parse(array[1]);
				string_6 = array[2];
				string_7 = array[3];
			}
			if (GClass174.smethod_0().bool_0)
				GClass174.smethod_0().method_0(int_0);
		}

		public void method_1(GClass76 g)
		{
			if (bool_0 && (GClass39.gclass145_0 == GClass39.gclass149_0 || GClass39.gclass145_0 == GClass39.gclass152_0))
				GClass193.smethod_0().method_2(GClass49.gclass49_20, g, (GClass192.int_0 == 0) ? ("Đăng nhập sau " + ((bool_5 ? 2 : 25) - long_1) + "s nữa...") : ("Login after " + ((bool_5 ? 2 : 25) - long_1) + "s..."), 5, 3, 0, GClass49.gclass49_11);
		}

		public bool method_2()
		{
			return GClass58.bool_35 || GClass149.bool_0 || GClass152.bool_3 || GClass152.bool_1 || GClass152.bool_5;
		}

		public void method_3()
		{
			if (!bool_0 || !GClass152.bool_6)
				return;
			if (!method_2())
			{
				if (GClass39.gclass145_0 == GClass39.gclass149_0 || GClass39.gclass145_0 == GClass39.gclass152_0)
				{
					if (GClass195.smethod_0().bool_0)
						GClass195.smethod_0().long_0 = 0L;
					if (GClass191.smethod_0().bool_16)
						GClass191.smethod_0().bool_17 = false;
					GClass183.smethod_0().bool_4 = false;
					if (!bool_2)
					{
						bool_2 = true;
						long_0 = GClass138.smethod_18();
					}
					else if (!bool_3 && GClass138.smethod_18() - long_0 >= ((!bool_5) ? 21000 : 1000))
					{
						if (GClass152.string_0[GClass152.int_14].ToLower().Replace(" ", "") != string_2)
						{
							for (int i = 0; i < GClass152.string_0.Length; i++)
							{
								if (GClass152.string_0[i].ToLower().Replace(" ", "") == string_2)
								{
									GClass120.smethod_9("svselect", i);
									GClass152.int_14 = i;
									GClass39.gclass152_0.method_1();
									return;
								}
							}
						}
						bool_3 = true;
						GClass152.smethod_3();
					}
					else if (GClass138.smethod_18() - long_0 >= ((!bool_5) ? 26000 : 2000))
					{
						bool_2 = false;
						bool_3 = false;
						long_0 = GClass138.smethod_18();
						method_4();
						if (bool_5)
							bool_5 = false;
					}
					long_1 = (GClass138.smethod_18() - long_0) / 1000L;
				}
				else if (bool_2)
				{
					bool_2 = false;
					bool_3 = false;
					long_0 = GClass138.smethod_18();
				}
			}
			else if (GClass138.smethod_18() - long_0 > 30000L)
			{
				GClass58.bool_35 = false;
				GClass149.bool_0 = false;
				GClass152.bool_3 = false;
				GClass152.bool_1 = false;
				GClass39.smethod_1().method_3();
			}
		}

		public void method_4()
		{
			if (GClass39.gclass149_0 == null)
				GClass39.gclass149_0 = new GClass149();
			GClass39.gclass149_0.switchToMe();
			GClass166.smethod_0().method_38(string_0, string_1, GClass113.string_2, 0);
		}

		public bool method_5(string path, int index)
		{
			if (File.Exists(path))
			{
				if (File.ReadAllText(path).Split('|')[index] == "True")
					return true;
				return false;
			}
			return false;
		}

		public void method_6()
		{
			try
			{
				GClass173.smethod_0().bool_4 = method_5(string_3, 0);
				GClass173.smethod_0().bool_6 = method_5(string_3, 1);
				GClass173.smethod_0().bool_7 = method_5(string_3, 2);
				GClass173.smethod_0().bool_15 = method_5(string_3, 3);
				GClass173.smethod_0().bool_5 = method_5(string_3, 4);
				GClass173.smethod_0().bool_8 = method_5(string_3, 5);
				GClass173.smethod_0().bool_9 = method_5(string_3, 6);
				GClass173.smethod_0().bool_10 = method_5(string_3, 7);
				GClass173.smethod_0().bool_11 = method_5(string_3, 8);
				GClass173.smethod_0().bool_3 = method_5(string_3, 9);
				GClass173.smethod_0().bool_14 = method_5(string_3, 10);
				GClass173.smethod_0().bool_18 = method_5(string_3, 11);
				GClass173.smethod_0().bool_2 = method_5(string_3, 12);
				GClass173.smethod_0().bool_16 = method_5(string_3, 13);
				GClass173.smethod_0().bool_13 = method_5(string_3, 14);
				GClass173.smethod_0().bool_19 = method_5(string_3, 15);
				GClass173.smethod_0().bool_12 = method_5(string_3, 16);
				if (File.ReadAllText(string_3).Split('|')[17] != "")
				{
					string[] array = File.ReadAllText(string_3).Split('|')[17].Split(',');
					int num = int.Parse(array[0]);
					int num2 = int.Parse(array[1]);
					int num3 = int.Parse(array[2]);
					GClass173.smethod_0().int_0 = num * 65536 + num2 * 256 + num3;
				}
				GClass191.smethod_0().bool_14 = method_5(string_4, 0);
				GClass179.bool_0 = method_5(string_4, 1);
				GClass185.smethod_0().bool_0 = method_5(string_4, 2);
				GClass195.smethod_0().bool_4 = method_5(string_4, 3);
				GClass195.smethod_0().bool_3 = method_5(string_4, 4);
				if (method_5(string_4, 5))
					GClass197.list_3.Add(74);
				GClass197.smethod_0().bool_5 = method_5(string_4, 6);
				GClass174.smethod_0().bool_0 = method_5(string_4, 7);
				GClass173.smethod_0().bool_17 = method_5(string_4, 8);
				GClass196.smethod_0().bool_1 = method_5(string_4, 9);
				GClass175.smethod_0().bool_5 = method_5(string_4, 10);
				GClass197.smethod_0().bool_6 = method_5(string_4, 11);
				GClass181.smethod_0().bool_0 = method_5(string_4, 12);
				GClass195.smethod_0().bool_11 = method_5(string_4, 13);
				GClass186.smethod_0().bool_0 = method_5(string_4, 14);
				if (File.ReadAllText(string_4).Split('|')[15] != "" && File.ReadAllText(string_4).Split('|')[16] != "")
				{
					Time.timeScale = float.Parse(File.ReadAllText(string_4).Split('|')[15]);
					GClass191.smethod_0().int_0 = int.Parse(File.ReadAllText(string_4).Split('|')[16]);
				}
				if (method_5(string_4, 12))
					GClass181.smethod_2();
				GClass195.smethod_0().bool_10 = method_5(string_4, 17);
				GClass191.smethod_0().int_18 = int.Parse(File.ReadAllText(string_4).Split('|')[18]);
			}
			catch
			{
			}
		}
	}
}
