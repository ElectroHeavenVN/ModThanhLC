using System;
using System.Collections;
using UnityEngine;

public class GClass35
{
	public static GClass9 gclass9_0 = new GClass9();

	public static void smethod_0(string name, GClass2 img, sbyte nFrame)
	{
		gclass9_0.method_4(string.Empty + name, new GClass92(img, nFrame));
	}

	public static GClass92 smethod_1(string nameImg, GClass9 hash)
	{
		GClass92 gClass = (GClass92)hash.method_0(string.Empty + nameImg);
		if (gClass == null)
		{
			gClass = new GClass92();
			GClass92 gClass2 = smethod_2(nameImg);
			if (gClass2 != null)
			{
				gClass.gclass2_0 = gClass2.gclass2_0;
				gClass.sbyte_0 = gClass2.sbyte_0;
			}
			hash.method_4(string.Empty + nameImg, gClass);
		}
		gClass.long_0 = GClass39.long_0 / 1000L;
		if (gClass.gclass2_0 == null)
		{
			gClass.int_0--;
			if (gClass.int_0 <= 0)
			{
				GClass166.smethod_0().method_144(nameImg);
				gClass.int_0 = 200;
			}
		}
		return gClass;
	}

	public static GClass92 smethod_2(string nameImg)
	{
		string text = GClass76.int_12 + "ImgByName_" + nameImg;
		GClass92 result = null;
		sbyte[] array = null;
		array = GClass120.smethod_1(text);
		if (array == null)
			return result;
		try
		{
			result = new GClass92();
			result.sbyte_0 = array[0];
			result.gclass2_0 = GClass2.smethod_6(array, 1, array.Length - 1);
			if (result.gclass2_0 != null)
				return result;
			return result;
		}
		catch (Exception)
		{
			Debug.LogError(text + ">>>>>getFromRms: nulllllllllll 2222");
			return null;
		}
	}

	public static void smethod_3(string nameImg, sbyte nFrame, sbyte[] data)
	{
		string text = GClass76.int_12 + "ImgByName_" + nameImg;
		GClass27 gClass = new GClass27(data.Length + 1);
		int i = 0;
		try
		{
			gClass.method_5(nFrame);
			for (i = 0; i < data.Length; i++)
			{
				gClass.method_5(data[i]);
			}
			GClass120.smethod_0(text, gClass.method_3());
			gClass.method_4();
		}
		catch (Exception ex)
		{
			Debug.LogError(i + ">>Errr save rms: " + text + "  " + ex.ToString());
		}
	}

	public static void smethod_4(GClass9 hash, int minute, bool isTrue)
	{
		GClass63 gClass = new GClass63("checkDelHash");
		if (isTrue)
		{
			hash.method_1();
			return;
		}
		IDictionaryEnumerator dictionaryEnumerator = hash.method_2();
		while (dictionaryEnumerator.MoveNext())
		{
			GClass92 gClass2 = (GClass92)dictionaryEnumerator.Value;
			if (GClass39.long_0 / 1000L - gClass2.long_0 > minute * 60)
				gClass.method_0((string)dictionaryEnumerator.Key);
		}
		for (int i = 0; i < gClass.method_2(); i++)
		{
			hash.method_5((string)gClass.method_3(i));
		}
	}
}
