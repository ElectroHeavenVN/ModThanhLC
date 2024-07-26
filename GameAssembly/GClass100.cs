using System;
using System.Text;
using UnityEngine;

public class GClass100
{
	public sbyte[] sbyte_0;

	private int int_0;

	private int int_1;

	private static string string_0;

	private static int int_2;

	public GClass100()
	{
	}

	public GClass100(sbyte[] data)
	{
		sbyte_0 = data;
	}

	public GClass100(string filename)
	{
		sbyte_0 = GClass203.smethod_20(((TextAsset)Resources.Load(filename, typeof(TextAsset))).bytes);
	}

	public sbyte method_0()
	{
		if (int_0 >= sbyte_0.Length)
		{
			int_0 = sbyte_0.Length;
			throw new Exception(" loi doc sbyte eof ");
		}
		return sbyte_0[int_0++];
	}

	public sbyte method_1()
	{
		return method_0();
	}

	public sbyte method_2()
	{
		return method_0();
	}

	public void method_3(int readlimit)
	{
		int_1 = int_0;
	}

	public void method_4()
	{
		int_0 = int_1;
	}

	public byte method_5()
	{
		return smethod_0(method_0());
	}

	public short method_6()
	{
		short num = 0;
		for (int i = 0; i < 2; i++)
		{
			num = (short)((short)(num << 8) | (short)(0xFF & sbyte_0[int_0++]));
		}
		return num;
	}

	public ushort method_7()
	{
		ushort num = 0;
		for (int i = 0; i < 2; i++)
		{
			num = (ushort)((ushort)(num << 8) | (ushort)(0xFFu & (uint)sbyte_0[int_0++]));
		}
		return num;
	}

	public int method_8()
	{
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			num = (num << 8) | (0xFF & sbyte_0[int_0++]);
		}
		return num;
	}

	public long method_9()
	{
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			num = (num << 8) | (0xFF & sbyte_0[int_0++]);
		}
		return num;
	}

	public bool method_10()
	{
		return (method_0() > 0) ? true : false;
	}

	public bool method_11()
	{
		return (method_0() > 0) ? true : false;
	}

	public string method_12()
	{
		short num = method_6();
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = smethod_0(method_0());
		}
		return new UTF8Encoding().GetString(array);
	}

	public string method_13()
	{
		short num = method_6();
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = smethod_0(method_0());
		}
		return new UTF8Encoding().GetString(array);
	}

	public string method_14()
	{
		return method_13();
	}

	public int method_15()
	{
		if (int_0 < sbyte_0.Length)
			return method_0();
		return -1;
	}

	public int method_16(ref sbyte[] data)
	{
		if (data != null)
		{
			int num = 0;
			for (int i = 0; i < data.Length; i++)
			{
				data[i] = method_0();
				if (int_0 <= sbyte_0.Length)
				{
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}
		return 0;
	}

	public void method_17(ref sbyte[] data)
	{
		if (data != null && data.Length + int_0 <= sbyte_0.Length)
		{
			for (int i = 0; i < data.Length; i++)
			{
				data[i] = method_0();
			}
		}
	}

	public int method_18()
	{
		return sbyte_0.Length - int_0;
	}

	public static byte smethod_0(sbyte var)
	{
		if (var > 0)
			return (byte)var;
		return (byte)(var + 256);
	}

	public static byte[] smethod_1(sbyte[] var)
	{
		byte[] array = new byte[var.Length];
		for (int i = 0; i < var.Length; i++)
		{
			if (var[i] > 0)
				array[i] = (byte)var[i];
			else
				array[i] = (byte)(var[i] + 256);
		}
		return array;
	}

	public void method_19()
	{
		sbyte_0 = null;
	}

	public void method_20()
	{
		sbyte_0 = null;
	}

	public void method_21(ref sbyte[] data, int arg1, int arg2)
	{
		if (data == null)
			return;
		for (int i = 0; i < arg2; i++)
		{
			data[i + arg1] = method_0();
			if (int_0 > sbyte_0.Length)
				break;
		}
	}
}
