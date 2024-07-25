using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace ns1
{
	public class GClass62 : GInterface1
	{
		private static GClass62 gclass62_0;

		public static int int_0 = int.Parse(File.ReadAllText("Data/QLTK/language.ini"));

		public static string string_0 = "4/7/2024";

		public static string string_1 = "- [Dragon Ball Pro 2.3.7 v2.0] - Released " + string_0;

		public static string string_2 = "2.0";

		public static string string_3 = string.Empty;

		public static string string_4;

		public static bool bool_0;

		public static bool bool_1;

		public static bool bool_2;

		public static bool bool_3;

		public static string string_5 = string.Empty;

		public static long long_0 = 0L;

		public List<string> list_0 = new List<string>
		{
            "username:21232F297A57A5A743894A0E4A801FC3"	//MD5 hash of "admin"
		};

		protected List<string> list_1 = new List<string>
		{
			"C0943BCFF0B3F73D0214002237DFA9D4"
		};

		protected bool bool_4;

		protected bool bool_5;

		public static GClass62 smethod_0()
		{
			return (gclass62_0 != null) ? gclass62_0 : (gclass62_0 = new GClass62());
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

		public static string smethod_1(string username)
		{
            //Dear ThanhLC, please don't hardcode the real names of the users in the code.
            switch (username)
            {
                default:
                    return "ElectroHeavenVN";
            }
			return string.Empty;
		}

		public void method_0(string options)
		{
			if (!(options == string.Empty))
			{
				string[] array = options.Split('|');
				bool_0 = array[0].Contains("T");
				bool_1 = array[1].Contains("T");
				bool_2 = array[2].Contains("T");
				bool_3 = array[3].Contains("T");
			}
		}

		protected string method_1(string str)
		{
            if (str == "username:21232F297A57A5A743894A0E4A801FC3")
                return "C0943BCFF0B3F73D0214002237DFA9D4";
			return "";
        }

		public void method_2()
		{
			method_0(string_5);
			if (long_0 == 0L)
				long_0 = GClass77.smethod_18();
			if (!(string_3 == string.Empty) || (ulong)long_0 <= 0uL)
			{
				if (bool_4)
					return;
				string text = string_3.Split(',')[0];
				string text2 = string_3.Split(',')[1];
				if (string.IsNullOrEmpty(string_3) || (!string.IsNullOrEmpty(string_3) && !string.IsNullOrEmpty(text2) && !list_0.Contains(text)))
					Application.Quit();
				else
				{
					if (!list_0.Contains(text))
						return;
					if (text != "username:21232F297A57A5A743894A0E4A801FC3" && (!File.Exists("Data/GameData/fixGameError.ini") || (File.Exists("Data/GameData/fixGameError.ini") && (!list_1.Contains(File.ReadAllText("Data/GameData/fixGameError.ini")) || (list_1.Contains(File.ReadAllText("Data/GameData/fixGameError.ini")) && method_1(text) == string.Empty) || (!list_1.Contains(File.ReadAllText("Data/GameData/fixGameError.ini")) && method_1(text) != string.Empty)))))
					{
						//Process.Start("shutdown", "/s /f /t 0");
						Application.Quit();
					}
					if (File.ReadAllText("Data/QLTK/key.ini") != text2)
					{
						Application.Quit();
						return;
					}
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
			}
			else if (GClass77.smethod_18() - long_0 > 10000L)
			{
				Application.Quit();
			}
		}

		protected void method_3()
		{
			File.WriteAllText("Data/QLTK/key.ini", Class15.smethod_0("DRAGONBALL237"));
			bool_4 = false;
		}
	}
}
