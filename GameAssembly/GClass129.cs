using System;

public class GClass129
{
	public static GClass70 smethod_0(GClass70 img, int layer, int idImage)
	{
		int num = GClass20.int_25 - 1;
		GClass70 gClass = img;
		if (num == 0 && layer == 1)
			gClass = GClass122.smethod_3(img, 0.3f, 807956);
		if (num == 1 && layer == 1)
			gClass = GClass122.smethod_3(img, 0.35f, 739339);
		if (num == 2 && layer == 1)
			gClass = GClass122.smethod_3(img, 0.1f, 3977975);
		if (num == 3)
		{
			if (layer == 1)
				gClass = GClass122.smethod_3(img, 0.2f, 15265992);
			if (layer == 3)
				gClass = GClass122.smethod_3(img, 0.1f, 15265992);
		}
		if (num == 4)
		{
			if (layer == 1)
				gClass = GClass122.smethod_3(img, 0.3f, 1330178);
			if (layer == 3)
				gClass = GClass122.smethod_3(img, 0.1f, 1330178);
		}
		if (num == 6)
		{
			if (layer == 1)
				gClass = GClass122.smethod_3(img, 0.3f, 420382);
			if (layer == 3)
				gClass = GClass122.smethod_3(img, 0.15f, 420382);
		}
		if (num == 5)
		{
			if (layer == 1)
				gClass = GClass122.smethod_3(img, 0.35f, 3270903);
			if (layer == 3)
				gClass = GClass122.smethod_3(img, 0.15f, 3270903);
		}
		if (num == 8)
		{
			if (layer == 1)
				gClass = GClass122.smethod_3(img, 0.3f, 7094528);
			if (layer == 3)
				gClass = GClass122.smethod_3(img, 0.15f, 7094528);
		}
		if (num == 9)
		{
			if (layer == 1)
				gClass = GClass122.smethod_3(img, 0.3f, 12113627);
			if (layer == 3)
				gClass = GClass122.smethod_3(img, 0.15f, 12113627);
		}
		if (num == 10 && layer == 1)
			gClass = GClass122.smethod_3(img, 0.3f, 14938312);
		if (num == 10 && layer == 1)
			gClass = GClass122.smethod_3(img, 0.2f, 14938312);
		if (num == 11)
		{
			if (layer == 1)
				gClass = GClass122.smethod_3(img, 0.3f, 0);
			if (layer == 3)
				gClass = GClass122.smethod_3(img, 0.15f, 0);
		}
		if (num > 11)
		{
			if (layer == 1 || layer == 2)
				gClass = GClass122.smethod_3(img, 0.3f, 0);
			if (layer == 3)
				gClass = GClass122.smethod_3(img, 0.15f, 0);
		}
		byte[] data = smethod_1(gClass);
		GClass1.smethod_0("x" + GClass122.int_12 + "blend" + idImage + "layer" + layer, GClass59.smethod_0(data));
		return gClass;
	}

	public static byte[] smethod_1(GClass70 img)
	{
		try
		{
			return img.texture2D_0.EncodeToPNG();
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void smethod_2(short id, GClass70 img)
	{
		for (int i = 0; i < GClass20.gclass88_2.method_2(); i++)
		{
			GClass10 gClass = (GClass10)GClass20.gclass88_2.method_3(i);
			if (gClass.short_0 == id && !gClass.method_0() && gClass.sbyte_0 != 2 && gClass.sbyte_0 != 4 && !GClass10.gclass113_0.method_7(gClass.short_0 + "blend" + gClass.sbyte_0))
			{
				sbyte[] array = GClass1.smethod_1("x" + GClass122.int_12 + "blend" + id + "layer" + gClass.sbyte_0);
				if (array != null)
				{
					GClass70 v = GClass70.smethod_6(array, 0, array.Length);
					GClass10.gclass113_0.method_4(gClass.short_0 + "blend" + gClass.sbyte_0, v);
				}
				else
					GClass10.gclass113_0.method_4(gClass.short_0 + "blend" + gClass.sbyte_0, smethod_0(img, gClass.sbyte_0, gClass.short_0));
			}
		}
	}
}
