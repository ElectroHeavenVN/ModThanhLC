using System;
using System.Threading;
using UnityEngine;

public class GClass61
{
	private static int int_0;

	private static int int_1;

	private static string string_0;

	private static string string_1;

	private static bool bool_0;

	private static int int_2;

	public static bool bool_1;

	private static int int_3;

	public static int smethod_0(string content, string to)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
			return smethod_2(content, to);
		return smethod_1(content, to);
	}

	private static int smethod_1(string string_2, string string_3)
	{
		if (int_0 != 0)
		{
			for (int i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (int_0 == 0)
					break;
			}
			if (int_0 != 0)
			{
				GClass36.smethod_2("CANNOT SEND SMS " + string_2 + " WHEN SENDING " + string_1);
				return -1;
			}
		}
		string_1 = string_2;
		string_0 = string_3;
		int_1 = -1;
		int_0 = 2;
		int j;
		for (j = 0; j < 500; j++)
		{
			Thread.Sleep(5);
			if (int_0 == 0)
				break;
		}
		if (j != 500)
			Debug.Log("Send SMS " + string_2 + " done in " + j * 5 + "ms");
		else
		{
			Debug.LogError("TOO LONG FOR SEND SMS " + string_2);
			int_0 = 0;
		}
		return int_1;
	}

	private static int smethod_2(string string_2, string string_3)
	{
		int num = GClass51.smethod_0();
		GClass36.smethod_0("vao sms ko " + num);
		if (num >= 0)
		{
			bool_0 = true;
			bool_1 = true;
			GClass51.smethod_2(string_3, string_2, num);
			Screen.orientation = ScreenOrientation.AutoRotation;
		}
		return num;
	}

	public static void smethod_3()
	{
		if (Time.time - (float)int_2 > 1f)
			int_2++;
		if (bool_0)
			smethod_4();
		if (int_0 == 2)
		{
			int_0 = 1;
			try
			{
				int_1 = smethod_2(string_1, string_0);
			}
			catch (Exception)
			{
				Debug.Log("CANNOT SEND SMS");
			}
			int_0 = 0;
		}
	}

	private static void smethod_4()
	{
		if (bool_1)
		{
			if (GClass51.smethod_6() == 1)
				Screen.orientation = ScreenOrientation.LandscapeLeft;
			else if (GClass51.smethod_6() == -1)
			{
				Screen.orientation = ScreenOrientation.Portrait;
			}
			else if (GClass51.smethod_6() != 0)
			{
				if (GClass51.smethod_6() == 2)
					Screen.orientation = ScreenOrientation.LandscapeRight;
				else if (GClass51.smethod_6() == 3)
				{
					Screen.orientation = ScreenOrientation.PortraitUpsideDown;
				}
			}
			else
			{
				Screen.orientation = ScreenOrientation.AutoRotation;
			}
			if (int_3 >= 5)
			{
				GClass51.smethod_4();
				bool_1 = false;
				int_3 = 0;
			}
			else
				int_3++;
		}
		if (GClass51.smethod_5() == 1)
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
			if (int_3 < 5)
			{
				int_3++;
				return;
			}
			bool_0 = false;
			GClass51.smethod_3();
			int_3 = 0;
		}
	}
}
