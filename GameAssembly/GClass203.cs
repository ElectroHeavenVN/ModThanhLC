using System;
using System.Text;
using UnityEngine;

public class GClass203
{
	public static bool bool_0;

	public static string string_0;

	public static bool bool_1;

	public static string string_1;

	public static string string_2;

	public static int int_0 = 4;

	public static sbyte sbyte_0;

	public static sbyte sbyte_1;

	public static sbyte sbyte_2 = 5;

	public const int int_1 = 1;

	public const int int_2 = 2;

	public const int int_3 = 3;

	public const int int_4 = 4;

	public const int int_5 = 5;

	public const int int_6 = 6;

	public const int int_7 = 7;

	public static GClass203 gclass203_0;

	internal static bool bool_2;

	public static void smethod_0()
	{
	}

	public static void smethod_1()
	{
		sbyte_1 = 0;
	}

	public static int smethod_2(GClass70 img)
	{
		if (int_0 == 5)
			return img.method_0();
		return img.method_0();
	}

	public static int smethod_3(GClass70 img)
	{
		if (int_0 == 5)
			return img.method_1();
		return img.method_0();
	}

	public static string smethod_4(long timeStart, int secondCount, bool isOnlySecond, bool isShortText)
	{
		string result = "";
		long num = (timeStart + secondCount * 1000 - smethod_18()) / 1000L;
		if (num <= 0L)
			return "";
		long num2 = 0L;
		long num3 = 0L;
		long num4 = num / 60L;
		long num5 = num;
		if (!isOnlySecond)
		{
			if (num >= 86400L)
			{
				num2 = num / 86400L;
				num3 = num % 86400L / 3600L;
			}
			else if (num >= 3600L)
			{
				num3 = num / 3600L;
				num4 = num % 3600L / 60L;
			}
			else if (num >= 60L)
			{
				num4 = num / 60L;
				num5 = num % 60L;
			}
			else
			{
				num5 = num;
			}
			if (isShortText)
			{
				if (num2 > 0L)
					return num2 + "d";
				if (num3 > 0L)
					return num3 + "h";
				if (num4 > 0L)
					return num4 + "m";
				if (num5 > 0L)
					return num5 + "s";
			}
			if (num2 <= 0L)
			{
				if (num3 > 0L)
				{
					if (num3 < 10L)
					{
						if (num3 < 10L)
							result = ((num4 < 1L) ? (num3 + "h") : ((num4 >= 10L) ? (num3 + "h" + num4 + "m") : (num3 + "h0" + num4 + "m")));
					}
					else
						result = ((num4 < 1L) ? (num3 + "h") : ((num4 < 10L) ? (num3 + "h0" + num4 + "m") : (num3 + "h" + num4 + "m")));
				}
				else if (num4 > 0L)
				{
					if (num4 < 10L)
					{
						if (num4 < 10L)
						{
							if (num5 < 10L)
							{
								if (num5 < 10L)
									result = num4 + "m0" + num5 + "";
							}
							else
								result = num4 + "m" + num5 + "";
						}
					}
					else if (num5 < 10L)
					{
						if (num5 < 10L)
							result = num4 + "m0" + num5 + "";
					}
					else
					{
						result = num4 + "m" + num5 + "";
					}
				}
				else
				{
					result = ((num5 >= 10L) ? (num5 + "") : ("0" + num5 + ""));
				}
			}
			else if (num2 >= 10L)
			{
				result = ((num3 < 1L) ? (num2 + "d") : ((num3 >= 10L) ? (num2 + "d" + num3 + "h") : (num2 + "d0" + num3 + "h")));
			}
			else if (num2 < 10L)
			{
				result = ((num3 < 1L) ? (num2 + "d") : ((num3 < 10L) ? (num2 + "d0" + num3 + "h") : (num2 + "d" + num3 + "h")));
			}
			return result;
		}
		return num5 + "";
	}

	public static string smethod_5(int aa)
	{
		try
		{
			string text = "";
			string text2 = "";
			string text3 = aa + "";
			if (!text3.Equals(""))
			{
				if (text3[0] == '-')
				{
					text2 = "-";
					text3 = text3.Substring(1);
				}
				for (int num = text3.Length - 1; num >= 0; num--)
				{
					text = (((text3.Length - 1 - num) % 3 != 0 || text3.Length - 1 - num <= 0) ? (text3[num] + text) : (text3[num] + "." + text));
				}
				return text2 + text;
			}
			return text;
		}
		catch (Exception)
		{
			return aa + "";
		}
	}

	public static string smethod_6(long number)
	{
		string text = "" + number;
		bool flag = false;
		try
		{
			string empty = "";
			if (number < 0L)
			{
				flag = true;
				number = -number;
				text = "" + number;
			}
			int num = 0;
			if (number < 1000000000L)
			{
				if (number >= 1000000L)
				{
					empty = "m";
					number /= 1000000L;
					num = ("" + number).Length;
				}
				else
				{
					if (number < 1000L)
					{
						if (flag)
							return "-" + text;
						return text;
					}
					empty = "k";
					number /= 1000L;
					num = ("" + number).Length;
				}
			}
			else
			{
				empty = "b";
				number /= 1000000000L;
				num = ("" + number).Length;
			}
			int num2 = int.Parse(text.Substring(num, 2));
			text = ((num2 == 0) ? (text.Substring(0, num) + empty) : ((num2 % 10 == 0) ? (text.Substring(0, num) + "," + text.Substring(num, 1) + empty) : (text.Substring(0, num) + "," + text.Substring(num, 2) + empty)));
		}
		catch (Exception)
		{
		}
		if (flag)
			return "-" + text;
		return text;
	}

	public static void smethod_7()
	{
		Application.OpenURL("http://ngocrongonline.com/");
	}

	public static void smethod_8()
	{
	}

	public static void smethod_9()
	{
	}

	public static void smethod_10()
	{
	}

	public static void smethod_11()
	{
	}

	public static void smethod_12()
	{
	}

	public static void smethod_13()
	{
	}

	public static void smethod_14()
	{
	}

	public static void smethod_15(GClass122 g, int x, int y, int w, int h)
	{
		g.method_10(x, y, w + 10, h, 0, 90);
	}

	public static void smethod_16(sbyte[] scr, int scrPos, sbyte[] dest, int destPos, int lenght)
	{
		Array.Copy(scr, scrPos, dest, destPos, lenght);
	}

	public static void smethod_17(sbyte[] scr, int scrPos, ref sbyte[] dest, int destPos, int lenght)
	{
		if (scr != null && dest != null && scrPos + lenght <= scr.Length)
		{
			sbyte[] array = new sbyte[dest.Length + lenght];
			for (int i = 0; i < destPos; i++)
			{
				array[i] = dest[i];
			}
			for (int j = destPos; j < destPos + lenght; j++)
			{
				array[j] = scr[scrPos + j - destPos];
			}
			for (int k = destPos + lenght; k < array.Length; k++)
			{
				array[k] = dest[destPos + k - lenght];
			}
		}
	}

	public static long smethod_18()
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return (DateTime.UtcNow.Ticks - dateTime.Ticks) / 10000L;
	}

	public static void smethod_19()
	{
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	public static sbyte[] smethod_20(byte[] scr)
	{
		sbyte[] array = new sbyte[scr.Length];
		for (int i = 0; i < scr.Length; i++)
		{
			array[i] = (sbyte)scr[i];
		}
		return array;
	}

	public static sbyte[] smethod_21(string scr)
	{
		return smethod_20(new ASCIIEncoding().GetBytes(scr));
	}

	public static byte[] smethod_22(sbyte[] scr)
	{
		byte[] array = new byte[scr.Length];
		for (int i = 0; i < scr.Length; i++)
		{
			if (scr[i] <= 0)
				array[i] = (byte)(scr[i] + 256);
			else
				array[i] = (byte)scr[i];
		}
		return array;
	}

	public static char[] smethod_23(sbyte[] scr)
	{
		char[] array = new char[scr.Length];
		for (int i = 0; i < scr.Length; i++)
		{
			array[i] = (char)scr[i];
		}
		return array;
	}

	public static int smethod_24()
	{
		return DateTime.Now.Hour;
	}

	public static void smethod_25(object str)
	{
		Debug.Log(str);
	}

	public static void smethod_26()
	{
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	public static GClass203 smethod_27()
	{
		if (gclass203_0 == null)
			gclass203_0 = new GClass203();
		return gclass203_0;
	}

	public static void smethod_28()
	{
		GClass12.bool_1 = true;
	}

	public static void smethod_29()
	{
		GClass12.bool_2 = true;
	}

	public static void smethod_30()
	{
		GClass12.bool_3 = true;
	}

	public static void smethod_31()
	{
	}

	public static void smethod_32(GClass122 g)
	{
		for (int i = 0; i < 5; i++)
		{
			if (GClass144.int_155[i] == -1 || !GClass73.smethod_46(GClass144.int_150[i], GClass144.int_151[i]))
				continue;
			if (GClass144.int_156[i] != GClass4.int_3)
			{
				if (GClass144.int_156[i] != GClass4.int_4)
				{
					if (GClass144.int_156[i] != GClass4.int_5)
					{
						if (GClass144.int_156[i] != GClass4.int_6)
						{
							if (GClass144.int_156[i] == GClass4.int_11)
								GClass4.gclass4_30.method_8(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2, GClass4.gclass4_33);
							else if (GClass144.int_156[i] == GClass4.int_7)
							{
								GClass4.gclass4_28.method_8(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2, GClass4.gclass4_16);
							}
							else if (GClass144.int_156[i] != GClass4.int_8)
							{
								if (GClass144.int_156[i] == GClass4.int_9)
									GClass4.gclass4_29.method_8(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2, GClass4.gclass4_33);
								else if (GClass144.int_156[i] != GClass4.int_10)
								{
									if (GClass144.int_156[i] == GClass4.int_12)
										GClass4.gclass4_27.method_8(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2, GClass4.gclass4_33);
									else if (GClass144.int_156[i] == GClass4.int_13)
									{
										GClass4.gclass4_32.method_8(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2, GClass4.gclass4_33);
									}
								}
								else
								{
									GClass4.gclass4_28.method_8(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2, GClass4.gclass4_33);
								}
							}
							else
							{
								GClass4.gclass4_31.method_7(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2);
							}
						}
						else
							GClass4.gclass4_29.method_8(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2, GClass4.gclass4_33);
					}
					else
						GClass4.gclass4_30.method_7(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2);
				}
				else
					GClass4.gclass4_29.method_7(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2);
			}
			else
				GClass4.gclass4_27.method_7(g, GClass144.string_9[i], GClass144.int_150[i], GClass144.int_151[i], GClass4.int_2);
		}
	}

	public static void smethod_33()
	{
	}

	public static GClass17 smethod_34(string nameImg)
	{
		GClass17 result = null;
		GClass35 gClass = null;
		gClass = GClass55.smethod_1(nameImg, GClass55.gclass113_0);
		if (gClass.gclass70_0 != null)
		{
			int num = gClass.gclass70_0.method_1() / gClass.sbyte_0;
			if (num < 1)
				num = 1;
			result = new GClass17(gClass.gclass70_0, gClass.gclass70_0.method_0(), num);
		}
		return result;
	}

	public static GClass70 smethod_35(string path)
	{
		return GClass73.smethod_43(path);
	}
}
