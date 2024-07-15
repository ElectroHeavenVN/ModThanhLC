using System.IO;
using UnityEngine;
using Vietpad.InputMethod;

namespace ns1
{
	public class GClass50
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

		private static GClass50 gclass50_0;

		public bool bool_2;

		public long long_0;

		public bool bool_3;

		public long long_1;

		public bool bool_4;

		public long long_2;

		public bool bool_5 = true;

		public static GClass50 smethod_0()
		{
			return (gclass50_0 != null) ? gclass50_0 : (gclass50_0 = new GClass50());
		}

		public void method_0()
		{
			string_0 = Main.arguments["username"];
			string_1 = Main.arguments["password"];
			string_2 = Main.arguments["server"];
			GClass62.string_5 = Main.arguments["options"];
			if (Main.arguments["uuid"] != null && !(Main.arguments["uuid"] == string.Empty))
				GClass62.string_3 = Main.arguments["uuid"];
			else
				Application.Quit();
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

		public void method_1(GClass193 g)
		{
			if (bool_0 && (GClass14.gclass160_0 == GClass14.gclass173_0 || GClass14.gclass160_0 == GClass14.gclass170_0))
				GClass45.smethod_0().method_1(GClass104.gclass104_20, g, (GClass62.int_0 == 0) ? ("Đăng nhập sau " + (((!bool_5) ? 25 : 2) - long_1) + "s nữa...") : ("Login after " + ((bool_5 ? 2 : 25) - long_1) + "s..."), 5, 3, 0, GClass104.gclass104_11);
		}

		protected bool method_2()
		{
			return GClass124.bool_35 || GClass173.bool_0 || GClass170.bool_3 || GClass170.bool_1 || GClass170.bool_5;
		}

		public void method_3()
		{
			if (!bool_0 || !GClass170.bool_6)
				return;
			if (!method_2())
			{
				if (GClass14.gclass160_0 == GClass14.gclass173_0 || GClass14.gclass160_0 == GClass14.gclass170_0)
				{
					if (GClass65.smethod_0().bool_0)
						GClass65.smethod_0().long_0 = 0L;
					if (GClass47.smethod_0().bool_15)
						GClass47.smethod_0().bool_16 = false;
					GClass42.smethod_0().bool_4 = false;
					if (bool_2)
					{
						if (!bool_3 && GClass77.smethod_18() - long_0 >= (bool_5 ? 1000 : 21000))
						{
							if (GClass170.string_0[GClass170.int_14].ToLower().Replace(" ", "") != string_2)
							{
								for (int i = 0; i < GClass170.string_0.Length; i++)
								{
									if (GClass170.string_0[i].ToLower().Replace(" ", "") == string_2)
									{
										GClass141.smethod_9("svselect", i);
										GClass170.int_14 = i;
										GClass14.gclass170_0.method_1();
										return;
									}
								}
							}
							bool_3 = true;
							GClass170.smethod_3();
						}
						else if (GClass77.smethod_18() - long_0 >= (bool_5 ? 2000 : 26000))
						{
							bool_2 = false;
							bool_3 = false;
							long_0 = GClass77.smethod_18();
							method_4();
							if (bool_5)
								bool_5 = false;
						}
					}
					else
					{
						bool_2 = true;
						long_0 = GClass77.smethod_18();
					}
					long_1 = (GClass77.smethod_18() - long_0) / 1000L;
				}
				else if (bool_2)
				{
					bool_2 = false;
					bool_3 = false;
					long_0 = GClass77.smethod_18();
				}
			}
			else if (GClass77.smethod_18() - long_0 > 30000L)
			{
				GClass124.bool_35 = false;
				GClass173.bool_0 = false;
				GClass170.bool_3 = false;
				GClass170.bool_1 = false;
				GClass14.smethod_1().method_3();
			}
		}

		protected void method_4()
		{
			if (GClass14.gclass173_0 == null)
				GClass14.gclass173_0 = new GClass173();
			GClass14.gclass173_0.switchToMe();
			GClass2.smethod_0().method_38(string_0, string_1, GClass206.string_2, 0);
		}

		public bool method_5(string path, int index)
		{
			if (!File.Exists(path))
				return false;
			if (!(File.ReadAllText(path).Split('|')[index] == "True"))
				return false;
			return true;
		}

		public void method_6()
		{
			try
			{
				VietKeyHandler.SmartMark = true;
				GClass66.smethod_0().bool_5 = method_5(string_3, 0);
				GClass66.smethod_0().bool_7 = method_5(string_3, 1);
				GClass66.smethod_0().bool_8 = method_5(string_3, 2);
				GClass66.smethod_0().bool_18 = method_5(string_3, 3);
				GClass66.smethod_0().bool_6 = method_5(string_3, 4);
				GClass66.smethod_0().bool_9 = method_5(string_3, 5);
				GClass66.smethod_0().bool_10 = method_5(string_3, 6);
				GClass66.smethod_0().bool_11 = method_5(string_3, 7);
				GClass66.smethod_0().bool_13 = method_5(string_3, 8);
				GClass66.smethod_0().bool_4 = method_5(string_3, 9);
				GClass66.smethod_0().bool_17 = method_5(string_3, 10);
				GClass66.smethod_0().bool_21 = method_5(string_3, 11);
				GClass66.smethod_0().bool_3 = method_5(string_3, 12);
				GClass66.smethod_0().bool_19 = method_5(string_3, 13);
				GClass66.smethod_0().bool_15 = method_5(string_3, 14);
				GClass66.smethod_0().bool_22 = method_5(string_3, 15);
				GClass66.smethod_0().bool_14 = method_5(string_3, 16);
				if (File.ReadAllText(string_3).Split('|')[17] != "")
				{
					string[] array = File.ReadAllText(string_3).Split('|')[17].Split(',');
					int num = int.Parse(array[0]);
					int num2 = int.Parse(array[1]);
					int num3 = int.Parse(array[2]);
					GClass66.smethod_0().int_0 = num * 65536 + num2 * 256 + num3;
				}
				if (!string.IsNullOrEmpty(File.ReadAllText(string_3).Split('|')[18]))
					GClass66.smethod_0().bool_16 = method_5(string_3, 18);
				GClass66.smethod_0().bool_12 = method_5(string_3, 19);
				GClass47.smethod_0().bool_13 = method_5(string_4, 0);
				GClass44.bool_0 = method_5(string_4, 1);
				GClass63.smethod_0().bool_0 = method_5(string_4, 2);
				GClass65.smethod_0().bool_4 = method_5(string_4, 3);
				GClass65.smethod_0().bool_3 = method_5(string_4, 4);
				if (method_5(string_4, 5))
					GClass48.list_3.Add(74);
				GClass48.smethod_0().bool_5 = method_5(string_4, 6);
				GClass55.smethod_0().bool_0 = method_5(string_4, 7);
				GClass66.smethod_0().bool_20 = method_5(string_4, 8);
				GClass41.smethod_0().bool_1 = method_5(string_4, 9);
				GClass61.smethod_0().bool_5 = method_5(string_4, 10);
				GClass48.smethod_0().bool_6 = method_5(string_4, 11);
				GClass52.smethod_0().bool_0 = method_5(string_4, 12);
				GClass65.smethod_0().bool_11 = method_5(string_4, 13);
				GClass56.smethod_0().bool_0 = method_5(string_4, 14);
				if (File.ReadAllText(string_4).Split('|')[15] != "" && File.ReadAllText(string_4).Split('|')[16] != "")
				{
					Time.timeScale = float.Parse(File.ReadAllText(string_4).Split('|')[15]);
					GClass47.smethod_0().int_0 = int.Parse(File.ReadAllText(string_4).Split('|')[16]);
				}
				if (method_5(string_4, 12))
					GClass52.smethod_2();
				GClass65.smethod_0().bool_10 = method_5(string_4, 17);
				GClass47.smethod_0().int_18 = int.Parse(File.ReadAllText(string_4).Split('|')[18]);
				VietKeyHandler.InputMethod = InputMethods.Telex;
				VietKeyHandler.VietModeEnabled = method_5(string_4, 19);
				GClass45.smethod_0().bool_0 = method_5(string_4, 19);
			}
			catch
			{
			}
		}
	}
}
