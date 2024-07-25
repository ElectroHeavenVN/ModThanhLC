using System;
using System.Collections;
using UnityEngine;

public class GClass108
{
	public static GClass175 gclass175_0 = new GClass175();

	public static void smethod_0(string name, GClass20 img, sbyte nFrame)
	{
		gclass175_0.method_4(string.Empty + name, new GClass186(img, nFrame));
	}

	public static GClass186 smethod_1(string nameImg, GClass175 hash)
	{
		GClass186 gClass = (GClass186)hash.method_0(string.Empty + nameImg);
		if (gClass == null)
		{
			gClass = new GClass186();
			GClass186 gClass2 = smethod_2(nameImg);
			if (gClass2 != null)
			{
				gClass.gclass20_0 = gClass2.gclass20_0;
				gClass.sbyte_0 = gClass2.sbyte_0;
			}
			hash.method_4(string.Empty + nameImg, gClass);
		}
		gClass.long_0 = GClass14.long_0 / 1000L;
		if (gClass.gclass20_0 == null)
		{
			gClass.int_0--;
			if (gClass.int_0 <= 0)
			{
				GClass2.smethod_0().method_144(nameImg);
				gClass.int_0 = 200;
			}
		}
		return gClass;
	}

	public static GClass186 smethod_2(string nameImg)
	{
		string text = GClass193.int_12 + "ImgByName_" + nameImg;
		GClass186 result = null;
		sbyte[] array = null;
		array = GClass141.smethod_1(text);
		if (array != null)
			try
			{
				result = new GClass186();
				result.sbyte_0 = array[0];
				result.gclass20_0 = GClass20.smethod_6(array, 1, array.Length - 1);
				if (result.gclass20_0 == null)
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
		string text = GClass193.int_12 + "ImgByName_" + nameImg;
		GClass102 gClass = new GClass102(data.Length + 1);
		int i = 0;
		try
		{
			gClass.method_5(nFrame);
			for (i = 0; i < data.Length; i++)
			{
				gClass.method_5(data[i]);
			}
			GClass141.smethod_0(text, gClass.method_3());
			gClass.method_4();
		}
		catch (Exception ex)
		{
			Debug.LogError(i + ">>Errr save rms: " + text + "  " + ex.ToString());
		}
	}

	public static void smethod_4(GClass175 hash, int minute, bool isTrue)
	{
		GClass122 gClass = new GClass122("checkDelHash");
		if (!isTrue)
		{
			IDictionaryEnumerator dictionaryEnumerator = hash.method_2();
			while (dictionaryEnumerator.MoveNext())
			{
				GClass186 gClass2 = (GClass186)dictionaryEnumerator.Value;
				if (GClass14.long_0 / 1000L - gClass2.long_0 > minute * 60)
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
