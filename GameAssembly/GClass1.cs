using System;
using System.IO;
using System.Threading;
using UnityEngine;

public class GClass1
{
	public static int int_0;

	public static sbyte[] sbyte_0;

	public static string string_0;

	public static void smethod_0(string filename, sbyte[] data)
	{
		if (!(Thread.CurrentThread.Name == Main.mainThreadName))
			smethod_5(filename, data);
		else
			smethod_11(filename, data);
	}

	public static sbyte[] smethod_1(string filename)
	{
		if (!(Thread.CurrentThread.Name == Main.mainThreadName))
			return smethod_6(filename);
		return smethod_12(filename);
	}

	public static string smethod_2(string fileName)
	{
		sbyte[] array = smethod_1(fileName);
		if (array == null)
			return null;
		GClass108 gClass = new GClass108(array);
		try
		{
			string result = gClass.method_6();
			gClass.method_4();
			return result;
		}
		catch (Exception ex)
		{
			GClass36.smethod_0(ex.StackTrace);
		}
		return null;
	}

	public static byte[] smethod_3(sbyte[] var)
	{
		byte[] array = new byte[var.Length];
		for (int i = 0; i < var.Length; i++)
		{
			if (var[i] <= 0)
				array[i] = (byte)(var[i] + 256);
			else
				array[i] = (byte)var[i];
		}
		return array;
	}

	public static void smethod_4(string filename, string data)
	{
		GClass46 gClass = new GClass46();
		try
		{
			gClass.method_6(data);
			smethod_0(filename, gClass.method_3());
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass36.smethod_0(ex.StackTrace);
		}
	}

	private static void smethod_5(string string_1, sbyte[] sbyte_1)
	{
		if (int_0 != 0)
		{
			Debug.LogError("Cannot save RMS " + string_1 + " because current is saving " + string_0);
			return;
		}
		string_0 = string_1;
		sbyte_0 = sbyte_1;
		int_0 = 2;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (int_0 == 0)
				break;
		}
		if (i == 500)
			Debug.LogError("TOO LONG TO SAVE RMS " + string_1);
	}

	private static sbyte[] smethod_6(string string_1)
	{
		if (int_0 != 0)
		{
			Debug.LogError("Cannot load RMS " + string_1 + " because current is loading " + string_0);
			return null;
		}
		string_0 = string_1;
		sbyte_0 = null;
		int_0 = 3;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (int_0 == 0)
				break;
		}
		if (i == 500)
			Debug.LogError("TOO LONG TO LOAD RMS " + string_1);
		return sbyte_0;
	}

	public static void smethod_7()
	{
		if (int_0 == 2)
		{
			int_0 = 1;
			smethod_11(string_0, sbyte_0);
			int_0 = 0;
		}
		else if (int_0 == 3)
		{
			int_0 = 1;
			sbyte_0 = smethod_12(string_0);
			int_0 = 0;
		}
	}

	public static int smethod_8(string file)
	{
		sbyte[] array = smethod_1(file);
		return (array == null) ? (-1) : array[0];
	}

	public static void smethod_9(string file, int x)
	{
		try
		{
			smethod_0(file, new sbyte[1] { (sbyte)x });
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_10()
	{
		return (GClass122.int_12 == 2) ? "Data/GameData/RMS2" : "Data/GameData/RMS1";
	}

	private static void smethod_11(string string_1, sbyte[] sbyte_1)
	{
		string text = smethod_10() + "/" + string_1;
		FileStream fileStream = new FileStream(text, FileMode.Create);
		fileStream.Write(GClass59.smethod_1(sbyte_1), 0, sbyte_1.Length);
		fileStream.Flush();
		fileStream.Close();
		Main.setBackupIcloud(text);
	}

	private static sbyte[] smethod_12(string string_1)
	{
		try
		{
			FileStream fileStream = new FileStream(smethod_10() + "/" + string_1, FileMode.Open);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			GClass59.smethod_0(array);
			return GClass59.smethod_0(array);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void smethod_13()
	{
		GClass36.smethod_4("clean rms");
		FileInfo[] files = new DirectoryInfo(smethod_10() + "/").GetFiles();
		for (int i = 0; i < files.Length; i++)
		{
			files[i].Delete();
		}
	}

	public static void smethod_14(string path)
	{
		try
		{
			File.Delete(smethod_10() + "/" + path);
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_15(byte[] ba)
	{
		return BitConverter.ToString(ba).Replace("-", "");
	}

	public static byte[] smethod_16(string hex)
	{
		int length = hex.Length;
		byte[] array = new byte[length / 2];
		for (int i = 0; i < length; i += 2)
		{
			array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
		}
		return array;
	}

	public static void smethod_17(string name)
	{
		try
		{
			PlayerPrefs.DeleteKey(name);
		}
		catch (Exception ex)
		{
			GClass36.smethod_0("loi xoa RMS --------------------------" + ex.ToString());
		}
	}

	public static void smethod_18()
	{
		smethod_17("data");
		smethod_17("dataVersion");
		smethod_17("map");
		smethod_17("mapVersion");
		smethod_17("skill");
		smethod_17("killVersion");
		smethod_17("item");
		smethod_17("itemVersion");
	}

	public static void smethod_19(string strID)
	{
		smethod_4("NRIPlink", strID);
	}

	public static string smethod_20()
	{
		string text = smethod_2("NRIPlink");
		if (text == null)
			return null;
		return text;
	}
}
