using System.Runtime.InteropServices;
using UnityEngine;

public class GClass51
{
	public static string string_0;

	public static string string_1;

	[DllImport("__Internal")]
	private static extern void _SMSsend(string string_2, string string_3, int int_0);

	[DllImport("__Internal")]
	private static extern int _unpause();

	[DllImport("__Internal")]
	private static extern int _checkRotation();

	[DllImport("__Internal")]
	private static extern int _back();

	[DllImport("__Internal")]
	private static extern int _Send();

	[DllImport("__Internal")]
	private static extern void _purchaseItem(string string_2, string string_3, string string_4);

	public static int smethod_0()
	{
		if (Application.platform != RuntimePlatform.IPhonePlayer)
		{
			string_0 = GClass184.genum3_0.ToString();
			if ("" + string_0[2] == "h" && string_0.Length > 6)
			{
				string_1 = SystemInfo.operatingSystem.ToString();
				string text = "" + string_1[10];
				if (!(text != "2") || !(text != "3"))
					return 1;
				return 0;
			}
			GClass36.smethod_0(string_0 + "  loai");
			if (!(string_0 == "Unknown") || !(GClass69.float_0 * GClass69.float_1 < 786432f))
				return -1;
			return 0;
		}
		return smethod_1();
	}

	public static int smethod_1()
	{
		if (GClass184.genum3_0 == GEnum3.const_3 || GClass184.genum3_0 == GEnum3.const_8 || GClass184.genum3_0 == GEnum3.const_11 || GClass184.genum3_0 == GEnum3.const_13)
			return 0;
		return -1;
	}

	public static void smethod_2(string phonenumber, string bodytext, int n)
	{
		if (Application.platform != 0)
			_SMSsend(phonenumber, bodytext, n);
	}

	public static void smethod_3()
	{
		if (Application.platform != 0)
			_back();
	}

	public static void smethod_4()
	{
		if (Application.platform != 0)
			_Send();
	}

	public static int smethod_5()
	{
		if (Application.platform == RuntimePlatform.OSXEditor)
			return 0;
		return _unpause();
	}

	public static int smethod_6()
	{
		if (Application.platform != 0)
			return _checkRotation();
		return 0;
	}

	public static void smethod_7(string itemID, string userName, string gameID)
	{
		if (Application.platform != 0)
			_purchaseItem(itemID, userName, gameID);
	}
}
