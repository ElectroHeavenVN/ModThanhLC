using System;
using System.Collections;
using UnityEngine;

public class GClass55
{
	public static GClass113 gclass113_0 = new GClass113();

	public static void smethod_0(string name, GClass70 img, sbyte nFrame)
	{
		gclass113_0.method_4("" + name, new GClass35(img, nFrame));
	}

	public static GClass35 smethod_1(string nameImg, GClass113 hash)
	{
		GClass35 gClass = (GClass35)hash.method_0("" + nameImg);
		if (gClass == null)
		{
			gClass = new GClass35();
			GClass35 gClass2 = smethod_2(nameImg);
			if (gClass2 != null)
			{
				gClass.gclass70_0 = gClass2.gclass70_0;
				gClass.sbyte_0 = gClass2.sbyte_0;
			}
			hash.method_4("" + nameImg, gClass);
		}
		gClass.long_0 = GClass73.long_0 / 1000L;
		if (gClass.gclass70_0 == null)
		{
			gClass.int_0--;
			if (gClass.int_0 <= 0)
			{
				GClass7.smethod_0().method_144(nameImg);
				gClass.int_0 = 200;
			}
		}
		return gClass;
	}

	public static GClass35 smethod_2(string nameImg)
	{
		string text = GClass122.int_12 + "ImgByName_" + nameImg;
		GClass35 result = null;
		sbyte[] array = null;
		array = GClass1.smethod_1(text);
		if (array != null)
			try
			{
				result = new GClass35();
				result.sbyte_0 = array[0];
				result.gclass70_0 = GClass70.smethod_6(array, 1, array.Length - 1);
				if (result.gclass70_0 != null)
					return result;
				return result;
			}
			catch (Exception)
			{
				Debug.LogError(text + ">>>>>getFromRms: nulllllllllll 2222");
				return null;
			}
		return result;
	}

	public static void smethod_3(string nameImg, sbyte nFrame, sbyte[] data)
	{
		string text = GClass122.int_12 + "ImgByName_" + nameImg;
		GClass46 gClass = new GClass46(data.Length + 1);
		int i = 0;
		try
		{
			gClass.method_5(nFrame);
			for (i = 0; i < data.Length; i++)
			{
				gClass.method_5(data[i]);
			}
			GClass1.smethod_0(text, gClass.method_3());
			gClass.method_4();
		}
		catch (Exception ex)
		{
			Debug.LogError(i + ">>Errr save rms: " + text + "  " + ex.ToString());
		}
	}

	public static void smethod_4(GClass113 hash, int minute, bool isTrue)
	{
		GClass88 gClass = new GClass88("checkDelHash");
		if (!isTrue)
		{
			IDictionaryEnumerator dictionaryEnumerator = hash.method_2();
			while (dictionaryEnumerator.MoveNext())
			{
				GClass35 gClass2 = (GClass35)dictionaryEnumerator.Value;
				if (GClass73.long_0 / 1000L - gClass2.long_0 > minute * 60)
					gClass.method_0((string)dictionaryEnumerator.Key);
			}
			for (int i = 0; i < gClass.method_2(); i++)
			{
				hash.method_5((string)gClass.method_3(i));
			}
		}
		else
			hash.method_1();
	}
}
