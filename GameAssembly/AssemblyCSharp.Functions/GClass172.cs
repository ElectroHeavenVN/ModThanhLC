using System.IO;
using UnityEngine;
using Vietpad.InputMethod;

namespace AssemblyCSharp.Functions
{
	public class GClass172
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

		private static GClass172 gclass172_0;

		public bool bool_2;

		public long long_0;

		public bool bool_3;

		public long long_1;

		public bool bool_4;

		public long long_2;

		public bool bool_5 = true;

		public static GClass172 smethod_0()
		{
			return (gclass172_0 != null) ? gclass172_0 : (gclass172_0 = new GClass172());
		}

		public void method_0()
		{
			string_0 = Main.arguments["username"];
			string_1 = Main.arguments["password"];
			string_2 = Main.arguments["server"];
			GClass151.string_5 = Main.arguments["options"];
			if (Main.arguments["uuid"] == null || Main.arguments["uuid"] == "")
				Application.Quit();
			else
				GClass151.string_3 = Main.arguments["uuid"];
			bool_1 = Main.arguments["isUseProxy"].ToLower().Contains("true");
			if (bool_1)
			{
				string[] array = Main.arguments["proxy"].Split(':');
				string_8 = array[0];
				int_1 = int.Parse(array[1]);
				string_6 = array[2];
				string_7 = array[3];
			}
		}

		public void method_1(GClass122 g)
		{
			if (bool_0 && (GClass73.gclass131_0 == GClass73.gclass133_0 || GClass73.gclass131_0 == GClass73.gclass134_0))
				GClass154.smethod_0().method_1(GClass4.gclass4_20, g, (GClass151.int_0 != 0) ? ("Login after " + ((bool_5 ? 2 : 25) - long_1) + "s...") : ("Đăng nhập sau " + (((!bool_5) ? 25 : 2) - long_1) + "s nữa..."), 5, 3, 0, GClass4.gclass4_11);
		}

		protected bool method_2()
		{
			return GClass78.bool_35 || GClass133.bool_0 || GClass134.bool_3 || GClass134.bool_1 || GClass134.bool_5;
		}

		public void method_3()
		{
			if (!bool_0 || !GClass134.bool_6)
				return;
			if (!method_2())
			{
				if (GClass73.gclass131_0 == GClass73.gclass133_0 || GClass73.gclass131_0 == GClass73.gclass134_0)
				{
					if (GClass168.smethod_0().bool_0)
						GClass168.smethod_0().long_0 = 0L;
					if (GClass159.smethod_0().bool_16)
						GClass159.smethod_0().bool_17 = false;
					GClass160.smethod_0().bool_4 = false;
					if (bool_2)
					{
						if (!bool_3 && GClass203.smethod_18() - long_0 >= ((!bool_5) ? 21000 : 1000))
						{
							if (GClass134.string_0[GClass134.int_14].ToLower().Replace(" ", "") != string_2)
							{
								for (int i = 0; i < GClass134.string_0.Length; i++)
								{
									if (GClass134.string_0[i].ToLower().Replace(" ", "") == string_2)
									{
										GClass1.smethod_9("svselect", i);
										GClass134.int_14 = i;
										GClass73.gclass134_0.method_1();
										return;
									}
								}
							}
							bool_3 = true;
							GClass134.smethod_3();
						}
						else if (GClass203.smethod_18() - long_0 >= (bool_5 ? 2000 : 26000))
						{
							bool_2 = false;
							bool_3 = false;
							long_0 = GClass203.smethod_18();
							method_4();
							if (bool_5)
								bool_5 = false;
						}
					}
					else
					{
						bool_2 = true;
						long_0 = GClass203.smethod_18();
					}
					long_1 = (GClass203.smethod_18() - long_0) / 1000L;
				}
				else if (bool_2)
				{
					bool_2 = false;
					bool_3 = false;
					long_0 = GClass203.smethod_18();
				}
			}
			else if (GClass203.smethod_18() - long_0 > 30000L)
			{
				GClass78.bool_35 = false;
				GClass133.bool_0 = false;
				GClass134.bool_3 = false;
				GClass134.bool_1 = false;
				GClass73.smethod_1().method_3();
			}
		}

		protected void method_4()
		{
			if (GClass73.gclass133_0 == null)
				GClass73.gclass133_0 = new GClass133();
			GClass73.gclass133_0.switchToMe();
			GClass7.smethod_0().method_38(string_0, string_1, GClass187.string_2, 0);
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
				VietKeyHandler.SmartMark = true;
				GClass167.smethod_0().bool_5 = method_5(string_3, 0);
				GClass167.smethod_0().bool_7 = method_5(string_3, 1);
				GClass167.smethod_0().bool_8 = method_5(string_3, 2);
				GClass167.smethod_0().bool_18 = method_5(string_3, 3);
				GClass167.smethod_0().bool_6 = method_5(string_3, 4);
				GClass167.smethod_0().bool_9 = method_5(string_3, 5);
				GClass167.smethod_0().bool_10 = method_5(string_3, 6);
				GClass167.smethod_0().bool_11 = method_5(string_3, 7);
				GClass167.smethod_0().bool_13 = method_5(string_3, 8);
				GClass167.smethod_0().bool_4 = method_5(string_3, 9);
				GClass167.smethod_0().bool_17 = method_5(string_3, 10);
				GClass167.smethod_0().bool_21 = method_5(string_3, 11);
				GClass167.smethod_0().bool_3 = method_5(string_3, 12);
				GClass167.smethod_0().bool_19 = method_5(string_3, 13);
				GClass167.smethod_0().bool_15 = method_5(string_3, 14);
				GClass167.smethod_0().bool_22 = method_5(string_3, 15);
				GClass167.smethod_0().bool_14 = method_5(string_3, 16);
				if (File.ReadAllText(string_3).Split('|')[17] != "")
				{
					string[] array = File.ReadAllText(string_3).Split('|')[17].Split(',');
					int num = int.Parse(array[0]);
					int num2 = int.Parse(array[1]);
					int num3 = int.Parse(array[2]);
					GClass167.smethod_0().int_0 = num * 65536 + num2 * 256 + num3;
				}
				if (!string.IsNullOrEmpty(File.ReadAllText(string_3).Split('|')[18]))
					GClass167.smethod_0().bool_16 = method_5(string_3, 18);
				GClass167.smethod_0().bool_12 = method_5(string_3, 19);
				GClass159.smethod_0().bool_14 = method_5(string_4, 0);
				GClass156.bool_0 = method_5(string_4, 1);
				GClass170.smethod_0().bool_0 = method_5(string_4, 2);
				GClass168.smethod_0().bool_4 = method_5(string_4, 3);
				GClass168.smethod_0().bool_3 = method_5(string_4, 4);
				if (method_5(string_4, 5))
					GClass166.list_3.Add(74);
				GClass166.smethod_0().bool_5 = method_5(string_4, 6);
				GClass150.smethod_0().bool_0 = method_5(string_4, 7);
				GClass167.smethod_0().bool_20 = method_5(string_4, 8);
				GClass164.smethod_0().bool_1 = method_5(string_4, 9);
				GClass157.smethod_0().bool_5 = method_5(string_4, 10);
				GClass166.smethod_0().bool_6 = method_5(string_4, 11);
				GClass169.smethod_0().bool_0 = method_5(string_4, 12);
				GClass168.smethod_0().bool_11 = method_5(string_4, 13);
				GClass165.smethod_0().bool_0 = method_5(string_4, 14);
				if (File.ReadAllText(string_4).Split('|')[15] != "" && File.ReadAllText(string_4).Split('|')[16] != "")
				{
					Time.timeScale = float.Parse(File.ReadAllText(string_4).Split('|')[15]);
					GClass159.smethod_0().int_0 = int.Parse(File.ReadAllText(string_4).Split('|')[16]);
				}
				if (method_5(string_4, 12))
					GClass169.smethod_2();
				GClass168.smethod_0().bool_10 = method_5(string_4, 17);
				GClass159.smethod_0().int_18 = int.Parse(File.ReadAllText(string_4).Split('|')[18]);
				VietKeyHandler.InputMethod = InputMethods.Telex;
				VietKeyHandler.VietModeEnabled = method_5(string_4, 19);
				GClass154.smethod_0().bool_0 = method_5(string_4, 19);
			}
			catch
			{
			}
		}
	}
}
