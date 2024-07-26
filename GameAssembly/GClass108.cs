using System;
using System.Threading;
using UnityEngine;

public class GClass108
{
	public GClass100 gclass100_0;

	public static GClass108 gclass108_0;

	private static int int_0;

	private static string string_0;

	public GClass108(string filename)
	{
		gclass100_0 = new GClass100(GClass59.smethod_0(((TextAsset)Resources.Load(filename, typeof(TextAsset))).bytes));
	}

	public GClass108(sbyte[] data)
	{
		gclass100_0 = new GClass100(data);
	}

	public static void smethod_0()
	{
		if (int_0 == 2)
		{
			int_0 = 1;
			gclass108_0 = smethod_3(string_0);
			int_0 = 0;
		}
	}

	public static GClass108 smethod_1(string filename)
	{
		return smethod_3(filename);
	}

	private static GClass108 smethod_2(string string_1)
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
		gclass108_0 = null;
		string_0 = string_1;
		int_0 = 2;
		int j;
		for (j = 0; j < 500; j++)
		{
			Thread.Sleep(5);
			if (int_0 == 0)
				break;
		}
		if (j != 500)
			return gclass108_0;
		Debug.LogError("TOO LONG FOR CREATE INPUTSTREAM " + string_1);
		int_0 = 0;
		return null;
	}

	private static GClass108 smethod_3(string string_1)
	{
		try
		{
			return new GClass108(string_1);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public short method_0()
	{
		return gclass100_0.method_6();
	}

	public int method_1()
	{
		return gclass100_0.method_8();
	}

	public int method_2()
	{
		return gclass100_0.method_5();
	}

	public void method_3(ref sbyte[] data)
	{
		gclass100_0.method_16(ref data);
	}

	public void method_4()
	{
		gclass100_0.method_19();
	}

	public void method_5()
	{
		gclass100_0.method_19();
	}

	public string method_6()
	{
		return gclass100_0.method_14();
	}

	public sbyte method_7()
	{
		return gclass100_0.method_2();
	}

	public long method_8()
	{
		return gclass100_0.method_9();
	}

	public bool method_9()
	{
		return gclass100_0.method_11();
	}

	public int method_10()
	{
		return (byte)gclass100_0.method_2();
	}

	public int method_11()
	{
		return gclass100_0.method_7();
	}

	public void method_12(ref sbyte[] data)
	{
		gclass100_0.method_16(ref data);
	}

	public int method_13()
	{
		return gclass100_0.method_18();
	}

	internal void method_14(ref sbyte[] sbyte_0, int int_1, int int_2)
	{
		throw new NotImplementedException();
	}
}
