using System;
using System.Threading;
using UnityEngine;

public class GClass11
{
	public GClass131 gclass131_0;

	public static GClass11 gclass11_0;

	private static int int_0;

	private static string string_0;

	public GClass11(string filename)
	{
		gclass131_0 = new GClass131(GClass66.smethod_0(((TextAsset)Resources.Load(filename, typeof(TextAsset))).bytes));
	}

	public GClass11(sbyte[] data)
	{
		gclass131_0 = new GClass131(data);
	}

	public static void smethod_0()
	{
		if (int_0 == 2)
		{
			int_0 = 1;
			gclass11_0 = smethod_3(string_0);
			int_0 = 0;
		}
	}

	public static GClass11 smethod_1(string filename)
	{
		return smethod_3(filename);
	}

	private static GClass11 smethod_2(string string_1)
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
				Debug.LogError("CANNOT GET INPUTSTREAM " + string_1 + " WHEN GETTING " + string_0);
				return null;
			}
		}
		gclass11_0 = null;
		string_0 = string_1;
		int_0 = 2;
		int j;
		for (j = 0; j < 500; j++)
		{
			Thread.Sleep(5);
			if (int_0 == 0)
				break;
		}
		if (j == 500)
		{
			Debug.LogError("TOO LONG FOR CREATE INPUTSTREAM " + string_1);
			int_0 = 0;
			return null;
		}
		return gclass11_0;
	}

	private static GClass11 smethod_3(string string_1)
	{
		try
		{
			return new GClass11(string_1);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public short method_0()
	{
		return gclass131_0.method_6();
	}

	public int method_1()
	{
		return gclass131_0.method_8();
	}

	public int method_2()
	{
		return gclass131_0.method_5();
	}

	public void method_3(ref sbyte[] data)
	{
		gclass131_0.method_16(ref data);
	}

	public void method_4()
	{
		gclass131_0.method_19();
	}

	public void method_5()
	{
		gclass131_0.method_19();
	}

	public string method_6()
	{
		return gclass131_0.method_14();
	}

	public sbyte method_7()
	{
		return gclass131_0.method_2();
	}

	public long method_8()
	{
		return gclass131_0.method_9();
	}

	public bool method_9()
	{
		return gclass131_0.method_11();
	}

	public int method_10()
	{
		return (byte)gclass131_0.method_2();
	}

	public int method_11()
	{
		return gclass131_0.method_7();
	}

	public void method_12(ref sbyte[] data)
	{
		gclass131_0.method_16(ref data);
	}

	public int method_13()
	{
		return gclass131_0.method_18();
	}

	internal void method_14(ref sbyte[] sbyte_0, int int_1, int int_2)
	{
		throw new NotImplementedException();
	}
}
