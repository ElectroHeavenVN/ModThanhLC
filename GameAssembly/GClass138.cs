using System;

public class GClass138
{
	public static void smethod_0()
	{
		GClass14.smethod_29();
	}

	public void method_0()
	{
		GClass14.smethod_31(mResources.downloading_data);
	}

	public static int smethod_1(int max)
	{
		return new GClass134().method_1(max);
	}

	public static sbyte[] smethod_2(GClass100 msg)
	{
		try
		{
			int num = msg.method_1().method_8();
			if (num > 1)
			{
				sbyte[] data = new sbyte[num];
				msg.method_1().method_16(ref data);
				return data;
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	public static sbyte[] smethod_3(GClass145 dos)
	{
		try
		{
			sbyte[] data = new sbyte[dos.method_8()];
			dos.method_16(ref data);
			return data;
		}
		catch (Exception)
		{
			GClass92.smethod_2("LOI DOC readByteArray dos  NINJAUTIL");
		}
		return null;
	}

	public static string smethod_4(string text, string regex, string replacement)
	{
		return text.Replace(regex, replacement);
	}

	public static string smethod_5(string number)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		if (number.Equals(string.Empty))
			return text;
		if (number[0] == '-')
		{
			text2 = "-";
			number = number.Substring(1);
		}
		for (int num = number.Length - 1; num >= 0; num--)
		{
			text = (((number.Length - 1 - num) % 3 != 0 || number.Length - 1 - num <= 0) ? (number[num] + text) : (number[num] + "." + text));
		}
		return text2 + text;
	}

	public static string smethod_6(int second)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(new TimeSpan(second * 1000L * 10000L)).ToUniversalTime();
		int hour = dateTime.Hour;
		_ = dateTime.Minute;
		int day = dateTime.Day;
		int month = dateTime.Month;
		int year = dateTime.Year;
		return day + "/" + month + "/" + year + " " + hour + "h";
	}

	public static string smethod_7(long second)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(new TimeSpan((second + 25200000L) * 10000L)).ToUniversalTime();
		int hour = dateTime.Hour;
		int minute = dateTime.Minute;
		return hour + "h" + minute + "m";
	}

	public static string smethod_8(int timeRemainS)
	{
		int num = 0;
		if (timeRemainS > 60)
		{
			num = timeRemainS / 60;
			timeRemainS %= 60;
		}
		int num2 = 0;
		if (num > 60)
		{
			num2 = num / 60;
			num %= 60;
		}
		int num3 = 0;
		if (num2 > 24)
		{
			num3 = num2 / 24;
			num2 %= 24;
		}
		string empty = string.Empty;
		if (num3 <= 0)
		{
			if (num2 <= 0)
			{
				empty = ((num <= 9) ? (empty + "0" + num) : (empty + num)) + ":";
				if (timeRemainS > 9)
					return empty + timeRemainS;
				return empty + "0" + timeRemainS;
			}
			return string.Concat(string.Concat(empty + num2, "h"), num.ToString(), "'");
		}
		return string.Concat(string.Concat(empty + num3, "d"), num2.ToString(), "h");
	}

	public static string smethod_9(long m)
	{
		string text = string.Empty;
		long num = m / 1000L + 1L;
		for (int i = 0; i < num; i++)
		{
			if (m >= 1000L)
			{
				long num2 = m % 1000L;
				text = ((num2 != 0L) ? ((num2 < 10L) ? (".00" + num2 + text) : ((num2 < 100L) ? (".0" + num2 + text) : ("." + num2 + text))) : (".000" + text));
				m /= 1000L;
				continue;
			}
			text = m + text;
			break;
		}
		return text;
	}

	public static string smethod_10(int timeRemainS)
	{
		int num = 0;
		if (timeRemainS > 60)
		{
			num = timeRemainS / 60;
			timeRemainS %= 60;
		}
		int num2 = 0;
		if (num > 60)
		{
			num2 = num / 60;
			num %= 60;
		}
		int num3 = 0;
		if (num2 > 24)
		{
			num3 = num2 / 24;
			num2 %= 24;
		}
		string empty = string.Empty;
		if (num3 <= 0)
		{
			if (num2 > 0)
				return string.Concat(string.Concat(empty + num2, "h"), num.ToString(), "'");
			if (num == 0)
				num = 1;
			return string.Concat(empty + num, "ph");
		}
		return string.Concat(string.Concat(empty + num3, "d"), num2.ToString(), "h");
	}

	public static string[] smethod_11(string original, string separator)
	{
		GClass122 gClass = new GClass122();
		for (int num = original.IndexOf(separator); num >= 0; num = original.IndexOf(separator))
		{
			gClass.method_0(original.Substring(0, num));
			original = original.Substring(num + separator.Length);
		}
		gClass.method_0(original);
		string[] array = new string[gClass.method_2()];
		if (gClass.method_2() > 0)
		{
			for (int i = 0; i < gClass.method_2(); i++)
			{
				array[i] = (string)gClass.method_3(i);
			}
		}
		return array;
	}

	public static bool smethod_12(string numberStr)
	{
		try
		{
			int.Parse(numberStr);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
