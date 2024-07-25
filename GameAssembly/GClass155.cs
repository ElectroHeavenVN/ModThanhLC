using System.Collections.Generic;
using UnityEngine;

public class GClass155
{
	public static bool bool_0;

	public static float float_0;

	public static float float_1;

	private static List<Matrix4x4> list_0 = new List<Matrix4x4>();

	public static void smethod_0()
	{
		GClass92.smethod_0("Init Scale GUI: Screen.w=" + Screen.width + " Screen.h=" + Screen.height);
		float_0 = Screen.width;
		float_1 = Screen.height;
		bool_0 = false;
		if (Screen.width > 1200)
			;
	}

	public static void smethod_1()
	{
		if (bool_0)
		{
			list_0.Add(GUI.matrix);
			Matrix4x4 matrix4x = default(Matrix4x4);
			float num = (float)Screen.width / (float)Screen.height;
			float num2 = 1f;
			Vector3 zero = Vector3.zero;
			float num3 = ((!(num < float_0 / float_1)) ? ((float)Screen.height / float_1) : ((float)Screen.width / float_0));
			matrix4x.SetTRS(zero, Quaternion.identity, Vector3.one * num3);
			GUI.matrix *= matrix4x;
		}
	}

	public static void smethod_2()
	{
		if (bool_0)
		{
			GUI.matrix = list_0[list_0.Count - 1];
			list_0.RemoveAt(list_0.Count - 1);
		}
	}

	public static float smethod_3(float x)
	{
		if (!bool_0)
			return x;
		x = x * float_0 / (float)Screen.width;
		return x;
	}

	public static float smethod_4(float y)
	{
		if (!bool_0)
			return y;
		y = y * float_1 / (float)Screen.height;
		return y;
	}
}
