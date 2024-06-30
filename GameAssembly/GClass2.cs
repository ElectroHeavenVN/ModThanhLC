using System;
using System.Threading;
using UnityEngine;

public class GClass2
{
	public Texture2D texture2D_0 = new Texture2D(1, 1);

	public static GClass2 gclass2_0;

	public static string string_0;

	public static byte[] byte_0;

	public static GClass2 gclass2_1;

	public static int int_0;

	public static int int_1;

	public static int int_2;

	public static int int_3;

	public static int int_4;

	public int int_5;

	public int int_6;

	public static int int_7;

	public Color color_0 = Color.black;

	public static GClass2 smethod_0()
	{
		return smethod_21();
	}

	public static GClass2 smethod_1(string filename)
	{
		return smethod_18(filename);
	}

	public static GClass2 smethod_2(byte[] imageData)
	{
		return smethod_19(imageData);
	}

	public static GClass2 smethod_3(GClass2 src, int x, int y, int w, int h, int transform)
	{
		return smethod_20(src, x, y, w, h, transform);
	}

	public static GClass2 smethod_4(int w, int h)
	{
		return smethod_22(w, h);
	}

	public static GClass2 smethod_5(GClass2 img)
	{
		GClass2 gClass = smethod_4(img.int_5, img.int_6);
		gClass.texture2D_0 = img.texture2D_0;
		gClass.texture2D_0.Apply();
		return gClass;
	}

	public static GClass2 smethod_6(sbyte[] imageData, int offset, int lenght)
	{
		if (offset + lenght > imageData.Length)
			return null;
		byte[] array = new byte[lenght];
		for (int i = 0; i < lenght; i++)
		{
			array[i] = smethod_7(imageData[i + offset]);
		}
		return smethod_2(array);
	}

	public static byte smethod_7(sbyte var)
	{
		if (var > 0)
			return (byte)var;
		return (byte)(var + 256);
	}

	public static byte[] smethod_8(sbyte[] var)
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

	public static GClass2 smethod_9(int[] rbg, int w, int h, bool bl)
	{
		GClass2 gClass = smethod_4(w, h);
		Color[] array = new Color[rbg.Length];
		for (int i = 0; i < array.Length; i++)
		{
			ref Color reference = ref array[i];
			reference = smethod_10(rbg[i]);
		}
		gClass.texture2D_0.SetPixels(0, 0, w, h, array);
		gClass.texture2D_0.Apply();
		return gClass;
	}

	public static Color smethod_10(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		return new Color(b: (float)num / 256f, g: (float)num2 / 256f, r: (float)num3 / 256f);
	}

	public static void smethod_11()
	{
		if (int_7 == 2)
		{
			int_7 = 1;
			gclass2_0 = smethod_21();
			int_7 = 0;
		}
		else if (int_7 == 3)
		{
			int_7 = 1;
			gclass2_0 = smethod_18(string_0);
			int_7 = 0;
		}
		else if (int_7 == 4)
		{
			int_7 = 1;
			gclass2_0 = smethod_19(byte_0);
			int_7 = 0;
		}
		else if (int_7 == 5)
		{
			int_7 = 1;
			gclass2_0 = smethod_20(gclass2_1, int_0, int_1, int_2, int_3, int_4);
			int_7 = 0;
		}
		else if (int_7 == 6)
		{
			int_7 = 1;
			gclass2_0 = smethod_22(int_2, int_3);
			int_7 = 0;
		}
	}

	private static GClass2 smethod_12()
	{
		if (int_7 != 0)
		{
			GClass5.smethod_2("CANNOT CREATE EMPTY IMAGE WHEN CREATING OTHER IMAGE");
			return null;
		}
		gclass2_0 = null;
		int_7 = 2;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (int_7 == 0)
				break;
		}
		if (i == 500)
		{
			GClass5.smethod_2("TOO LONG FOR CREATE EMPTY IMAGE");
			int_7 = 0;
		}
		return gclass2_0;
	}

	private static GClass2 smethod_13(string string_1)
	{
		if (int_7 != 0)
		{
			GClass5.smethod_2("CANNOT CREATE IMAGE " + string_1 + " WHEN CREATING OTHER IMAGE");
			return null;
		}
		gclass2_0 = null;
		string_0 = string_1;
		int_7 = 3;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (int_7 == 0)
				break;
		}
		if (i == 500)
		{
			GClass5.smethod_2("TOO LONG FOR CREATE IMAGE " + string_1);
			int_7 = 0;
		}
		return gclass2_0;
	}

	private static GClass2 smethod_14(byte[] byte_1)
	{
		if (int_7 != 0)
		{
			GClass5.smethod_2("CANNOT CREATE IMAGE(FromArray) WHEN CREATING OTHER IMAGE");
			return null;
		}
		gclass2_0 = null;
		byte_0 = byte_1;
		int_7 = 4;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (int_7 == 0)
				break;
		}
		if (i == 500)
		{
			GClass5.smethod_2("TOO LONG FOR CREATE IMAGE(FromArray)");
			int_7 = 0;
		}
		return gclass2_0;
	}

	private static GClass2 smethod_15(GClass2 gclass2_2, int int_8, int int_9, int int_10, int int_11, int int_12)
	{
		if (int_7 != 0)
		{
			GClass5.smethod_2("CANNOT CREATE IMAGE(FromSrcPart) WHEN CREATING OTHER IMAGE");
			return null;
		}
		gclass2_0 = null;
		gclass2_1 = gclass2_2;
		int_0 = int_8;
		int_1 = int_9;
		int_2 = int_10;
		int_3 = int_11;
		int_4 = int_12;
		int_7 = 5;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (int_7 == 0)
				break;
		}
		if (i == 500)
		{
			GClass5.smethod_2("TOO LONG FOR CREATE IMAGE(FromSrcPart)");
			int_7 = 0;
		}
		return gclass2_0;
	}

	private static GClass2 smethod_16(int int_8, int int_9)
	{
		if (int_7 != 0)
		{
			GClass5.smethod_2("CANNOT CREATE IMAGE(w,h) WHEN CREATING OTHER IMAGE");
			return null;
		}
		gclass2_0 = null;
		int_2 = int_8;
		int_3 = int_9;
		int_7 = 6;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (int_7 == 0)
				break;
		}
		if (i == 500)
		{
			GClass5.smethod_2("TOO LONG FOR CREATE IMAGE(w,h)");
			int_7 = 0;
		}
		return gclass2_0;
	}

	public static byte[] smethod_17(string filename)
	{
		new GClass2();
		TextAsset textAsset = (TextAsset)Resources.Load(filename, typeof(TextAsset));
		if (textAsset == null || textAsset.bytes == null || textAsset.bytes.Length == 0)
			throw new Exception("NULL POINTER EXCEPTION AT Image __createImage " + filename);
		Debug.LogError("CHIEU DAI MANG BYTE IMAGE CREAT = " + GClass66.smethod_0(textAsset.bytes).Length);
		return textAsset.bytes;
	}

	private static GClass2 smethod_18(string string_1)
	{
		GClass2 gClass = new GClass2();
		Texture2D texture2D = Resources.Load(string_1) as Texture2D;
		if (texture2D == null)
			throw new Exception("NULL POINTER EXCEPTION AT Image __createImage " + string_1);
		gClass.texture2D_0 = texture2D;
		gClass.int_5 = gClass.texture2D_0.width;
		gClass.int_6 = gClass.texture2D_0.height;
		smethod_25(gClass);
		return gClass;
	}

	private static GClass2 smethod_19(byte[] byte_1)
	{
		if (byte_1 == null || byte_1.Length == 0)
		{
			GClass5.smethod_2("Create Image from byte array fail");
			return null;
		}
		GClass2 gClass = new GClass2();
		try
		{
			gClass.texture2D_0.LoadImage(byte_1);
			gClass.int_5 = gClass.texture2D_0.width;
			gClass.int_6 = gClass.texture2D_0.height;
			smethod_25(gClass);
			return gClass;
		}
		catch (Exception)
		{
			GClass5.smethod_2("CREAT IMAGE FROM ARRAY FAIL \n" + Environment.StackTrace);
			return gClass;
		}
	}

	private static GClass2 smethod_20(GClass2 gclass2_2, int int_8, int int_9, int int_10, int int_11, int int_12)
	{
		GClass2 gClass = new GClass2();
		gClass.texture2D_0 = new Texture2D(int_10, int_11);
		int_9 = gclass2_2.texture2D_0.height - int_9 - int_11;
		for (int i = 0; i < int_10; i++)
		{
			for (int j = 0; j < int_11; j++)
			{
				int num = i;
				if (int_12 == 2)
					num = int_10 - i;
				gClass.texture2D_0.SetPixel(i, j, gclass2_2.texture2D_0.GetPixel(int_8 + num, int_9 + j));
			}
		}
		gClass.texture2D_0.Apply();
		gClass.int_5 = gClass.texture2D_0.width;
		gClass.int_6 = gClass.texture2D_0.height;
		smethod_25(gClass);
		return gClass;
	}

	private static GClass2 smethod_21()
	{
		return new GClass2();
	}

	public static GClass2 smethod_22(int w, int h)
	{
		GClass2 gClass = new GClass2();
		gClass.texture2D_0 = new Texture2D(w, h, TextureFormat.RGBA32, false);
		smethod_25(gClass);
		gClass.int_5 = w;
		gClass.int_6 = h;
		gClass.texture2D_0.Apply();
		return gClass;
	}

	public static int smethod_23(GClass2 image)
	{
		return image.method_0();
	}

	public static int smethod_24(GClass2 image)
	{
		return image.method_1();
	}

	public int method_0()
	{
		return int_5 / GClass76.int_12;
	}

	public int method_1()
	{
		return int_6 / GClass76.int_12;
	}

	private static void smethod_25(GClass2 gclass2_2)
	{
		smethod_26(gclass2_2.texture2D_0);
	}

	public static void smethod_26(Texture2D texture)
	{
		texture.anisoLevel = 0;
		texture.filterMode = FilterMode.Point;
		texture.mipMapBias = 0f;
		texture.wrapMode = TextureWrapMode.Clamp;
	}

	public Color[] method_2()
	{
		return texture2D_0.GetPixels();
	}

	public int method_3()
	{
		return int_5;
	}

	public int method_4()
	{
		return int_6;
	}

	public void method_5(ref int[] data, int x1, int x2, int x, int y, int w, int h)
	{
		Color[] pixels = texture2D_0.GetPixels(x, int_6 - 1 - y, w, h);
		for (int i = 0; i < pixels.Length; i++)
		{
			data[i] = GClass76.smethod_6(pixels[i]);
		}
	}
}
