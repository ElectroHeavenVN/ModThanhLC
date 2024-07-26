public class GClass59
{
	public static sbyte[] smethod_0(byte[] data)
	{
		sbyte[] array = new sbyte[data.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (sbyte)data[i];
		}
		return array;
	}

	public static byte[] smethod_1(sbyte[] data)
	{
		byte[] array = new byte[data.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)data[i];
		}
		return array;
	}

	public static char[] smethod_2(sbyte[] data)
	{
		char[] array = new char[data.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)data[i];
		}
		return array;
	}
}
