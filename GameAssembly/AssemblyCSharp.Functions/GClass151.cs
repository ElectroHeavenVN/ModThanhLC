using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using License;
using UnityEngine;

namespace AssemblyCSharp.Functions
{
	public class GClass151 : GInterface6
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class15
		{
			public static readonly Class15 class15_0 = new Class15();

			public static ThreadStart threadStart_0;

			internal void method_0()
			{
				smethod_0().method_3();
			}
		}

		private static GClass151 gclass151_0;

		public static int int_0 = int.Parse(File.ReadAllText("Data/QLTK/language.ini"));

		public static string string_0 = "22/7/2024";

		public static string string_1 = "- [Dragon Ball Pro 2.3.7 v2.0] - Released " + string_0;

		public static string string_2 = "2.0";

		public static string string_3 = "";

		public static string string_4;

		public static bool bool_0;

		public static bool bool_1;

		public static bool bool_2;

		public static bool bool_3;

		public static string string_5 = "";

		public static long long_0 = 0L;

		public List<string> list_0 = new List<string>
		{
			"username:21232F297A57A5A743894A0E4A801FC3",
		};

		protected List<string> list_1 = new List<string>
		{
			"C0943BCFF0B3F73D0214002237DFA9D4",
		};

		protected bool bool_4;

		protected bool bool_5;

		public static GClass151 smethod_0()
		{
			return (gclass151_0 != null) ? gclass151_0 : (gclass151_0 = new GClass151());
		}

		public void perform(int idAction, object p)
		{
			switch (idAction)
			{
			case 10001:
				Process.Start(p.ToString());
				break;
			case 10002:
				Process.Start(p.ToString());
				break;
			case 10003:
				Process.Start(p.ToString());
				break;
			}
		}

		public void method_0(string options)
		{
			if (!(options == ""))
			{
				string[] array = options.Split('|');
				bool_0 = array[0].Contains("T");
				bool_1 = array[1].Contains("T");
				bool_2 = array[2].Contains("T");
				bool_3 = array[3].Contains("T");
			}
		}

		public static string smethod_1(string username)
		{
			switch (username)
			{
				case "username:21232F297A57A5A743894A0E4A801FC3":
					//return "Lê Chí Thanh";
					return "ElectroHeavenVN";
				default:
					return "";
			}
		}

        protected string method_1(string str)
        {
            switch (str)
            {
                case "username:21232F297A57A5A743894A0E4A801FC3":
                    return "C0943BCFF0B3F73D0214002237DFA9D4";
                default:
                    return "";
            }
        }

		public void method_2()
		{
			method_0(string_5);
			if (long_0 == 0L)
				long_0 = GClass203.smethod_18();
			if (!(string_3 == "") || (ulong)long_0 <= 0uL)
			{
				if (bool_4)
					return;
				string text = string_3.Split(',')[0];
				string text2 = string_3.Split(',')[1];
				if (!string.IsNullOrEmpty(string_3) && (string.IsNullOrEmpty(string_3) || string.IsNullOrEmpty(text2) || list_0.Contains(text)))
				{
					if (!list_0.Contains(text))
						return;
					if (text != "username:21232F297A57A5A743894A0E4A801FC3" && (!File.Exists("Data/GameData/fixGameError.ini") || (File.Exists("Data/GameData/fixGameError.ini") && (!list_1.Contains(File.ReadAllText("Data/GameData/fixGameError.ini")) || (list_1.Contains(File.ReadAllText("Data/GameData/fixGameError.ini")) && method_1(text) == "") || (!list_1.Contains(File.ReadAllText("Data/GameData/fixGameError.ini")) && method_1(text) != "")))))
					{
						//Process.Start("shutdown", "/s /f /t 0");
						Application.Quit();
					}
					if (!(File.ReadAllText("Data/QLTK/key.ini") != text2))
					{
						if (!bool_5)
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								smethod_0().method_3();
							});
							thread.IsBackground = true;
							thread.Start();
							bool_5 = false;
						}
						bool_4 = true;
					}
					else
						Application.Quit();
				}
				else
					Application.Quit();
			}
			else if (GClass203.smethod_18() - long_0 > 10000L)
			{
				Application.Quit();
			}
		}

		protected void method_3()
		{
			File.WriteAllText("Data/QLTK/key.ini", DeviceInformation.GenerateLicense("DRAGONBALL237"));
			bool_4 = false;
		}
	}
}
