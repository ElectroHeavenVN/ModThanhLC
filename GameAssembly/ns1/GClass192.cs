using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using UnityEngine;

namespace ns1
{
	public class GClass192 : GInterface0
	{
		private static GClass192 gclass192_0;

		public static int int_0 = int.Parse(File.ReadAllText("Data/QLTK/language.ini"));

		public static string string_0 = "- [Dragon Ball Pro 2.3.7 v1.8] - Released 20/4/2024";

		public static string string_1 = "1.8";

		public static string string_2 = string.Empty;

		public static string string_3;

		public static bool bool_0;

		public static bool bool_1;

		public static bool bool_2;

		public static bool bool_3;

		public static string string_4 = string.Empty;

		public static long long_0 = 0L;

        //21232F297A57A5A743894A0E4A801FC3 is the hash of "admin"
        public static string string_5 = "username:21232F297A57A5A743894A0E4A801FC3|username:00000000000000000000000000000000|";

		public static bool bool_4;

		public static bool bool_5;

		public static GClass192 smethod_0()
		{
			return (gclass192_0 != null) ? gclass192_0 : (gclass192_0 = new GClass192());
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
			if (!(options == string.Empty))
			{
				string[] array = options.Split('|');
				bool_0 = array[0].Contains("T");
				bool_1 = array[1].Contains("T");
				bool_2 = array[2].Contains("T");
				bool_3 = array[3].Contains("T");
			}
		}

		public static string smethod_1(string input)
		{
			using (MD5 mD = MD5.Create())
			{
				byte[] array = mD.ComputeHash(Encoding.ASCII.GetBytes(input));
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("X2"));
				}
				return stringBuilder.ToString();
			}
		}

		public static string smethod_2()
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			int num = 0;
			PhysicalAddress physicalAddress;
			while (true)
			{
				if (num < allNetworkInterfaces.Length)
				{
					physicalAddress = allNetworkInterfaces[num].GetPhysicalAddress();
					if (physicalAddress.ToString() != string.Empty)
						break;
					num++;
					continue;
				}
				return string.Empty;
			}
			return physicalAddress.ToString();
		}

		public void method_1()
		{
			method_0(string_4);
			if (long_0 == 0L)
				long_0 = GClass138.smethod_18();
			if (string_2 == string.Empty)
			{
				if (GClass138.smethod_18() - long_0 > 10000L)
					Application.Quit();
			}
			else
			{
				if (bool_4)
					return;
				string value = string_2.Split(',')[0];
				string text = string_2.Split(',')[1];
				if (!string_5.Contains(value))
					return;
				if (File.ReadAllText("Data/QLTK/key.ini") == text)
				{
					if (!bool_5)
					{
						Thread thread = new Thread((ThreadStart)delegate
						{
							smethod_0().method_2();
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
		}

		public static string smethod_3(string username)
		{
            //Another convoluted switch statement that returns the hardcoded real name of the user based on the hash of the username.
            //To protect the privacy of the users, the original switch statement has been replaced with a simple switch statement.
            switch (username)
            {
                default:
                    return "ElectroHeavenVN";
            }
            return string.Empty;
		}

		public void method_2()
		{
			File.WriteAllText("Data/QLTK/key.ini", Class9.smethod_0("DRAGONBALL237"));
			bool_4 = false;
		}
	}
}
