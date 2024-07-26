using System.Text;

public class GClass185
{
	public sbyte[] sbyte_0 = new sbyte[2048];

	private int int_0;

	private int int_1 = 2048;

	public GClass185()
	{
	}

	public GClass185(int len)
	{
		sbyte_0 = new sbyte[len];
		int_1 = len;
	}

	public void method_0(sbyte value)
	{
		method_20(0);
		sbyte_0[int_0++] = value;
	}

	public void method_1(sbyte value)
	{
		sbyte_0[int_0++] = value;
	}

	public void method_2(sbyte value)
	{
		method_0(value);
	}

	public void method_3(int value)
	{
		method_0((sbyte)value);
	}

	public void method_4(char value)
	{
		method_0(0);
		method_0((sbyte)value);
	}

	public void method_5(byte value)
	{
		method_0((sbyte)value);
	}

	public void method_6(byte[] value)
	{
		method_20(value.Length);
		for (int i = 0; i < value.Length; i++)
		{
			method_1((sbyte)value[i]);
		}
	}

	public void method_7(sbyte[] value)
	{
		method_20(value.Length);
		for (int i = 0; i < value.Length; i++)
		{
			method_1(value[i]);
		}
	}

	public void method_8(short value)
	{
		method_20(2);
		for (int num = 1; num >= 0; num--)
		{
			method_1((sbyte)(value >> num * 8));
		}
	}

	public void method_9(int value)
	{
		method_20(2);
		short num = (short)value;
		for (int num2 = 1; num2 >= 0; num2--)
		{
			method_1((sbyte)(num >> num2 * 8));
		}
	}

	public void method_10(ushort value)
	{
		method_20(2);
		for (int num = 1; num >= 0; num--)
		{
			method_1((sbyte)(value >> num * 8));
		}
	}

	public void method_11(int value)
	{
		method_20(4);
		for (int num = 3; num >= 0; num--)
		{
			method_1((sbyte)(value >> num * 8));
		}
	}

	public void method_12(long value)
	{
		method_20(8);
		for (int num = 7; num >= 0; num--)
		{
			method_1((sbyte)(value >> num * 8));
		}
	}

	public void method_13(bool value)
	{
		method_0((sbyte)(value ? 1 : 0));
	}

	public void method_14(bool value)
	{
		method_0((sbyte)(value ? 1 : 0));
	}

	public void method_15(string value)
	{
		char[] array = value.ToCharArray();
		method_8((short)array.Length);
		method_20(array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			method_1((sbyte)array[i]);
		}
	}

	public void method_16(string value)
	{
		Encoding unicode = Encoding.Unicode;
		byte[] array = Encoding.Convert(unicode, Encoding.GetEncoding(65001), unicode.GetBytes(value));
		method_8((short)array.Length);
		method_20(array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			method_1((sbyte)array[i]);
		}
	}

	public void method_17(ref sbyte[] data, int arg1, int arg2)
	{
		if (data == null)
			return;
		for (int i = 0; i < arg2; i++)
		{
			method_0(data[i + arg1]);
			if (int_0 > sbyte_0.Length)
				break;
		}
	}

	public void method_18(sbyte[] value)
	{
		method_7(value);
	}

	public sbyte[] method_19()
	{
		if (int_0 <= 0)
			return null;
		sbyte[] array = new sbyte[int_0];
		for (int i = 0; i < int_0; i++)
		{
			array[i] = sbyte_0[i];
		}
		return array;
	}

	public void method_20(int ltemp)
	{
		if (int_0 + ltemp > int_1)
		{
			sbyte[] array = new sbyte[int_1 + 1024 + ltemp];
			for (int i = 0; i < int_1; i++)
			{
				array[i] = sbyte_0[i];
			}
			sbyte_0 = null;
			sbyte_0 = array;
			int_1 += 1024 + ltemp;
		}
	}

	public void method_21()
	{
		sbyte_0 = null;
	}

	public void method_22()
	{
		sbyte_0 = null;
	}
}
