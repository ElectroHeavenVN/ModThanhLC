using System;
using System.Collections;
using ns1;
using UnityEngine;

public class GClass76
{
	public static int int_0 = 1;

	public static int int_1 = 2;

	public static int int_2 = 4;

	public static int int_3 = 8;

	public static int int_4 = 16;

	public static int int_5 = 32;

	private float float_0;

	private float float_1;

	private float float_2;

	private float float_3;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	private bool bool_0;

	private bool bool_1 = true;

	private int int_10;

	private int int_11;

	private float float_4;

	private float float_5;

	public static int int_12 = 1;

	public const int int_13 = 64;

	public const int int_14 = 0;

	public const int int_15 = 1;

	public const int int_16 = 2;

	public const int int_17 = 1;

	public const int int_18 = 4;

	public const int int_19 = 7;

	public const int int_20 = 0;

	public const int int_21 = 3;

	public const int int_22 = 6;

	public const int int_23 = 5;

	public static Hashtable hashtable_0 = new Hashtable();

	public static int int_24;

	private int int_25;

	private int int_26;

	private int int_27;

	private Vector2 vector2_0 = new Vector2(0f, 0f);

	private Rect rect_0;

	private Matrix4x4 matrix4x4_0;

	private Vector2 vector2_1;

	public Vector2 vector2_2 = new Vector2(128f, 128f);

	public Vector2 vector2_3 = new Vector2(0f, 0f);

	public Color color_0;

	public static Color color_1 = new Color(1f, 1f, 1f, 0f);

	private Material material_0;

	private void method_0(string string_0, Texture texture_0)
	{
		if (hashtable_0.Count > 400)
			hashtable_0.Clear();
		if (texture_0.width * texture_0.height < GClass39.int_10 * GClass39.int_11)
			hashtable_0.Add(string_0, texture_0);
	}

	public void method_1(int tx, int ty)
	{
		tx *= int_12;
		ty *= int_12;
		int_10 += tx;
		int_11 += ty;
		bool_1 = true;
		if (int_10 == 0 && int_11 == 0)
			bool_1 = false;
	}

	public void method_2(float x, float y)
	{
		float_4 += x;
		float_5 += y;
		bool_1 = true;
		if (float_4 == 0f && float_5 == 0f)
			bool_1 = false;
	}

	public int method_3()
	{
		return int_10 / int_12;
	}

	public int method_4()
	{
		return int_11 / int_12 + int_24;
	}

	public void method_5(int x, int y, int w, int h)
	{
		x *= int_12;
		y *= int_12;
		w *= int_12;
		h *= int_12;
		int_25 = int_10;
		int_26 = int_11;
		int_6 = x;
		int_7 = y;
		int_8 = w;
		int_9 = h;
		bool_0 = true;
	}

	public int method_6()
	{
		return GClass154.int_22;
	}

	public int method_7()
	{
		return GClass154.int_23;
	}

	public int method_8()
	{
		return GClass154.int_6;
	}

	public int method_9()
	{
		return GClass154.int_7;
	}

	public void method_10(int x, int y, int w, int h, int color, int alpha)
	{
		method_20(color, 0.5f);
		method_15(x, y, w, h);
	}

	public void method_11(int x1, int y1, int x2, int y2)
	{
		try
		{
			x1 *= int_12;
			y1 *= int_12;
			x2 *= int_12;
			y2 *= int_12;
			if (bool_1)
			{
				x1 += int_10;
				y1 += int_11;
				x2 += int_10;
				y2 += int_11;
			}
			string text = "dl" + float_0 + float_1 + float_2;
			Texture2D texture2D = (Texture2D)hashtable_0[text];
			if (texture2D == null)
			{
				texture2D = new Texture2D(1, 1);
				texture2D.SetPixel(0, 0, new Color(float_0, float_1, float_2));
				texture2D.Apply();
				method_0(text, texture2D);
			}
			Vector2 vector = new Vector2(x1, y1);
			Vector2 vector2 = new Vector2(x2, y2) - vector;
			float num = 57.29578f * Mathf.Atan(vector2.y / vector2.x);
			if (vector2.x < 0f)
				num += 180f;
			int num2 = (int)Mathf.Ceil(0f);
			GUIUtility.RotateAroundPivot(num, vector);
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			if (bool_0)
			{
				num3 = int_6;
				num4 = int_7;
				num5 = int_8;
				num6 = int_9;
				if (bool_1)
				{
					num3 += int_25;
					num4 += int_26;
				}
			}
			if (bool_0)
				GUI.BeginGroup(new Rect(num3, num4, num5, num6));
			Graphics.DrawTexture(new Rect(vector.x - (float)num3, vector.y - (float)num2 - (float)num4, vector2.magnitude, 1.6f), texture2D);
			if (bool_0)
				GUI.EndGroup();
			GUIUtility.RotateAroundPivot(0f - num, vector);
		}
		catch (Exception ex)
		{
			GClass188.smethod_0("Data/Errors/drawLine.txt", ex.ToString());
		}
	}

	public Color method_12(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		return new Color(b: (float)num / 256f, g: (float)num2 / 256f, r: (float)num3 / 256f);
	}

	public float[] method_13(Color cl)
	{
		float num = 256f * cl.r;
		float num2 = 256f * cl.g;
		float num3 = 256f * cl.b;
		return new float[3] { num, num2, num3 };
	}

	public void method_14(int x, int y, int w, int h)
	{
		method_15(x, y, w, 1);
		method_15(x, y, 1, h);
		method_15(x + w, y, 1, h + 1);
		method_15(x, y + h, w + 1, 1);
	}

	public void method_15(int x, int y, int w, int h)
	{
		x *= int_12;
		y *= int_12;
		w *= int_12;
		h *= int_12;
		if (w < 0 || h < 0)
			return;
		if (bool_1)
		{
			x += int_10;
			y += int_11;
		}
		int width = 1;
		int height = 1;
		string text = "fr" + width + height + float_0 + float_1 + float_2 + float_3;
		Texture2D texture2D = (Texture2D)hashtable_0[text];
		if (texture2D == null)
		{
			texture2D = new Texture2D(width, height);
			texture2D.SetPixel(0, 0, new Color(float_0, float_1, float_2, float_3));
			texture2D.Apply();
			method_0(text, texture2D);
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (bool_0)
		{
			num = int_6;
			num2 = int_7;
			num3 = int_8;
			num4 = int_9;
			if (bool_1)
			{
				num += int_25;
				num2 += int_26;
			}
		}
		if (bool_0)
			GUI.BeginGroup(new Rect(num, num2, num3, num4));
		GUI.DrawTexture(new Rect(x - num, y - num2, w, h), texture2D);
		if (bool_0)
			GUI.EndGroup();
	}

	public void method_16(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float_2 = (float)num / 256f;
		float_1 = (float)num2 / 256f;
		float_0 = (float)num3 / 256f;
		float_3 = 255f;
	}

	public void method_17(Color color)
	{
		float_2 = color.b;
		float_1 = color.g;
		float_0 = color.r;
	}

	public void method_18(int rgb)
	{
		if (rgb != int_27)
		{
			int_27 = rgb;
			int num = rgb & 0xFF;
			int num2 = (rgb >> 8) & 0xFF;
			int num3 = (rgb >> 16) & 0xFF;
			float_2 = (float)num / 256f;
			float_1 = (float)num2 / 256f;
			float_0 = (float)num3 / 256f;
			Main.main.GetComponent<Camera>().backgroundColor = new Color(float_0, float_1, float_2);
		}
	}

	public void method_19(string s, float x, float y, GUIStyle style)
	{
		x *= (float)int_12;
		y *= (float)int_12;
		if (bool_1)
		{
			x += (float)int_10;
			y += (float)int_11;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (bool_0)
		{
			num = int_6;
			num2 = int_7;
			num3 = int_8;
			num4 = int_9;
			if (bool_1)
			{
				num += int_25;
				num2 += int_26;
			}
		}
		if (bool_0)
			GUI.BeginGroup(new Rect(num, num2, num3, num4));
		GUI.Label(new Rect(x - (float)num, y - (float)num2, GClass4.float_0, 100f), s, style);
		if (bool_0)
			GUI.EndGroup();
	}

	public void method_20(int rgb, float alpha)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float_2 = (float)num / 256f;
		float_1 = (float)num2 / 256f;
		float_0 = (float)num3 / 256f;
		float_3 = alpha;
	}

	public void method_21(string s, int x, int y, GUIStyle style, int w)
	{
		x *= int_12;
		y *= int_12;
		if (bool_1)
		{
			x += int_10;
			y += int_11;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (bool_0)
		{
			num = int_6;
			num2 = int_7;
			num3 = int_8;
			num4 = int_9;
			if (bool_1)
			{
				num += int_25;
				num2 += int_26;
			}
		}
		if (bool_0)
			GUI.BeginGroup(new Rect(num, num2, num3, num4));
		GUI.Label(new Rect(x - num, y - num2 - 4, w, 100f), s, style);
		if (bool_0)
			GUI.EndGroup();
	}

	private void method_22(int int_28)
	{
		Vector2 vector = new Vector2(0f, 0f);
		if (int_28 <= 17)
		{
			if (int_28 <= 6)
			{
				if (int_28 != 3)
				{
					if (int_28 == 6)
						vector = new Vector2(0f, Screen.height / 2);
				}
				else
					vector = new Vector2(vector2_2.x / 2f, vector2_2.y / 2f);
			}
			else if (int_28 != 10)
			{
				if (int_28 == 17)
					vector = new Vector2(Screen.width / 2, 0f);
			}
			else
			{
				vector = new Vector2(Screen.width, Screen.height / 2);
			}
		}
		else if (int_28 <= 24)
		{
			if (int_28 != 20)
			{
				if (int_28 == 24)
					vector = new Vector2(Screen.width, 0f);
			}
			else
				vector = new Vector2(0f, 0f);
		}
		else if (int_28 != 33)
		{
			if (int_28 != 36)
			{
				if (int_28 == 40)
					vector = new Vector2(Screen.width, Screen.height);
			}
			else
				vector = new Vector2(0f, Screen.height);
		}
		else
		{
			vector = new Vector2(Screen.width / 2, Screen.height);
		}
		vector2_0 = vector + vector2_3;
		rect_0 = new Rect(vector2_0.x - vector2_2.x * 0.5f, vector2_0.y - vector2_2.y * 0.5f, vector2_2.x, vector2_2.y);
		vector2_1 = new Vector2(rect_0.xMin + rect_0.width * 0.5f, rect_0.yMin + rect_0.height * 0.5f);
	}

	public void method_23(GClass2 arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8)
	{
		if (arg0 != null)
		{
			x *= int_12;
			y *= int_12;
			x0 *= int_12;
			y0 *= int_12;
			w0 *= int_12;
			h0 *= int_12;
			method_27(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
		}
	}

	public void method_24(GClass2 arg0, int x0, int y0, int w0, int h0, int arg5, float x, float y, int arg8)
	{
		if (arg0 != null)
		{
			x *= (float)int_12;
			y *= (float)int_12;
			x0 *= int_12;
			y0 *= int_12;
			w0 *= int_12;
			h0 *= int_12;
			method_26(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
		}
	}

	public void method_25(GClass2 arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8, bool isClip)
	{
		method_23(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
	}

	public void method_26(GClass2 image, int x0, int y0, int w, int h, int transform, float x, float y, int anchor)
	{
		if (image == null)
			return;
		if (bool_1)
		{
			x += (float)int_10;
			y += (float)int_11;
		}
		float num = w;
		float num2 = h;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 1f;
		float num8 = 0f;
		int num9 = 1;
		if ((anchor & int_0) == int_0)
			num5 -= num / 2f;
		if ((anchor & int_1) == int_1)
			num6 -= num2 / 2f;
		if ((anchor & int_3) == int_3)
			num5 -= num;
		if ((anchor & int_5) == int_5)
			num6 -= num2;
		x += num5;
		y += num6;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		if (bool_0)
		{
			num10 = int_6;
			num11 = int_7;
			num12 = int_8;
			num13 = int_9;
			if (bool_1)
			{
				num10 += int_25;
				num11 += int_26;
			}
			Rect r = new Rect(x, y, w, h);
			Rect rect = method_38(r2: new Rect(num10, num11, num12, num13), r1: r);
			if (rect.width <= 0f || rect.height <= 0f)
				return;
			num = rect.width;
			num2 = rect.height;
			num3 = rect.x - r.x;
			num4 = rect.y - r.y;
		}
		float num14 = 0f;
		float num15 = 0f;
		switch (transform)
		{
		case 1:
			num9 = -1;
			num15 += num2;
			break;
		case 2:
			num14 += num;
			num7 = -1f;
			if (bool_0)
			{
				if ((float)num10 > x)
					num8 = 0f - num3;
				else if ((float)(num10 + num12) < x + (float)w)
				{
					num8 = 0f - ((float)(num10 + num12) - x - (float)w);
				}
			}
			break;
		case 3:
			num9 = -1;
			num15 += num2;
			num7 = -1f;
			num14 += num;
			break;
		}
		int num16 = 0;
		int num17 = 0;
		if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
		{
			matrix4x4_0 = GUI.matrix;
			vector2_2 = new Vector2(w, h);
			vector2_3 = new Vector2(x, y);
			method_22(3);
			if (transform != 5)
			{
				if (transform == 6)
					method_22(3);
			}
			else
			{
				vector2_2 = new Vector2(w, h);
				method_22(3);
			}
			switch (transform)
			{
			case 4:
				GUIUtility.RotateAroundPivot(270f, vector2_1);
				num14 += num;
				num7 = -1f;
				if (bool_0)
				{
					if ((float)num10 > x)
						num8 = 0f - num3;
					else if ((float)(num10 + num12) < x + (float)w)
					{
						num8 = 0f - ((float)(num10 + num12) - x - (float)w);
					}
				}
				break;
			case 5:
				GUIUtility.RotateAroundPivot(90f, vector2_1);
				break;
			case 6:
				GUIUtility.RotateAroundPivot(270f, vector2_1);
				break;
			case 7:
				GUIUtility.RotateAroundPivot(270f, vector2_1);
				num9 = -1;
				num15 += num2;
				break;
			}
		}
		Graphics.DrawTexture(new Rect(x + num3 + num14 + (float)num16, y + num4 + (float)num17 + num15, num * num7, num2 * (float)num9), image.texture2D_0, new Rect(((float)x0 + num3 + num8) / (float)image.texture2D_0.width, ((float)image.texture2D_0.height - num2 - ((float)y0 + num4)) / (float)image.texture2D_0.height, num / (float)image.texture2D_0.width, num2 / (float)image.texture2D_0.height), 0, 0, 0, 0);
		if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
			GUI.matrix = matrix4x4_0;
	}

	public void method_27(GClass2 image, float x0, float y0, int w, int h, int transform, int x, int y, int anchor)
	{
		if (image == null)
			return;
		if (bool_1)
		{
			x += int_10;
			y += int_11;
		}
		float num = w;
		float num2 = h;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 1f;
		float num8 = 0f;
		int num9 = 1;
		if ((anchor & int_0) == int_0)
			num5 -= num / 2f;
		if ((anchor & int_1) == int_1)
			num6 -= num2 / 2f;
		if ((anchor & int_3) == int_3)
			num5 -= num;
		if ((anchor & int_5) == int_5)
			num6 -= num2;
		x += (int)num5;
		y += (int)num6;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		if (bool_0)
		{
			num10 = int_6;
			num11 = int_7;
			num12 = int_8;
			num13 = int_9;
			if (bool_1)
			{
				num10 += int_25;
				num11 += int_26;
			}
			Rect r = new Rect(x, y, w, h);
			Rect rect = method_38(r2: new Rect(num10, num11, num12, num13), r1: r);
			if (rect.width <= 0f || rect.height <= 0f)
				return;
			num = rect.width;
			num2 = rect.height;
			num3 = rect.x - r.x;
			num4 = rect.y - r.y;
		}
		float num14 = 0f;
		float num15 = 0f;
		switch (transform)
		{
		case 1:
			num9 = -1;
			num15 += num2;
			break;
		case 2:
			num14 += num;
			num7 = -1f;
			if (bool_0)
			{
				if (num10 > x)
					num8 = 0f - num3;
				else if (num10 + num12 < x + w)
				{
					num8 = -(num10 + num12 - x - w);
				}
			}
			break;
		case 3:
			num9 = -1;
			num15 += num2;
			num7 = -1f;
			num14 += num;
			break;
		}
		int num16 = 0;
		int num17 = 0;
		if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
		{
			matrix4x4_0 = GUI.matrix;
			vector2_2 = new Vector2(w, h);
			vector2_3 = new Vector2(x, y);
			method_22(3);
			if (transform != 5)
			{
				if (transform == 6)
					method_22(3);
			}
			else
			{
				vector2_2 = new Vector2(w, h);
				method_22(3);
			}
			switch (transform)
			{
			case 4:
				GUIUtility.RotateAroundPivot(270f, vector2_1);
				num14 += num;
				num7 = -1f;
				if (bool_0)
				{
					if (num10 > x)
						num8 = 0f - num3;
					else if (num10 + num12 < x + w)
					{
						num8 = -(num10 + num12 - x - w);
					}
				}
				break;
			case 5:
				GUIUtility.RotateAroundPivot(90f, vector2_1);
				break;
			case 6:
				GUIUtility.RotateAroundPivot(270f, vector2_1);
				break;
			case 7:
				GUIUtility.RotateAroundPivot(270f, vector2_1);
				num9 = -1;
				num15 += num2;
				break;
			}
		}
		Graphics.DrawTexture(new Rect((float)x + num3 + num14 + (float)num16, (float)y + num4 + (float)num17 + num15, num * num7, num2 * (float)num9), image.texture2D_0, new Rect((x0 + num3 + num8) / (float)image.texture2D_0.width, ((float)image.texture2D_0.height - num2 - (y0 + num4)) / (float)image.texture2D_0.height, num / (float)image.texture2D_0.width, num2 / (float)image.texture2D_0.height), 0, 0, 0, 0);
		if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
			GUI.matrix = matrix4x4_0;
	}

	public void method_28(GClass2 image, float x0, float y0, int w, int h, int transform, float x, float y, int anchor)
	{
		GUI.color = method_12(807956);
		x *= (float)int_12;
		y *= (float)int_12;
		x0 *= (float)int_12;
		y0 *= (float)int_12;
		w *= int_12;
		h *= int_12;
	}

	public void method_29(GClass2 image, float x0, float y0, int w, int h, int transform, int x, int y, int anchor)
	{
		GUI.color = image.color_0;
		if (bool_1)
		{
			x += int_10;
			y += int_11;
		}
		string text = "dg" + x0 + y0 + w + h + transform + image.GetHashCode();
		Texture2D texture2D = (Texture2D)hashtable_0[text];
		if (texture2D == null)
		{
			texture2D = GClass2.smethod_3(image, (int)x0, (int)y0, w, h, transform).texture2D_0;
			method_0(text, texture2D);
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		float num5 = w;
		float num6 = h;
		float num7 = 0f;
		float num8 = 0f;
		if ((anchor & int_0) == int_0)
			num7 -= num5 / 2f;
		if ((anchor & int_1) == int_1)
			num8 -= num6 / 2f;
		if ((anchor & int_3) == int_3)
			num7 -= num5;
		if ((anchor & int_5) == int_5)
			num8 -= num6;
		x += (int)num7;
		y += (int)num8;
		if (bool_0)
		{
			num = int_6;
			num2 = int_7;
			num3 = int_8;
			num4 = int_9;
			if (bool_1)
			{
				num += int_25;
				num2 += int_26;
			}
		}
		if (bool_0)
			GUI.BeginGroup(new Rect(num, num2, num3, num4));
		GUI.DrawTexture(new Rect(x - num, y - num2, w, h), texture2D);
		if (bool_0)
			GUI.EndGroup();
		GUI.color = new Color(1f, 1f, 1f, 1f);
	}

	public void method_30(GClass2 image, float x, float y)
	{
		x *= (float)int_12;
		y *= (float)int_12;
		GUI.DrawTexture(new Rect(x + (float)int_10, y + (float)int_11, image.method_3(), image.method_4()), image.texture2D_0);
	}

	public void method_31(GClass2 image, int x, int y, int anchor)
	{
		if (((image == GClass154.gclass2_28 || image == GClass154.gclass2_29 || image == GClass154.gclass2_39 || image == GClass154.gclass2_40 || image == GClass154.gclass2_9 || image == GClass154.gclass2_10 || image == GClass154.gclass2_30 || image == GClass154.gclass2_16 || image == GClass154.gclass2_17 || image == GClass154.gclass2_18 || image == GClass154.gclass2_19 || image == GClass154.gclass2_11 || image == GClass154.gclass2_31 || image == GClass154.gclass2_34 || image == GClass154.gclass2_28 || image == GClass154.gclass2_29 || image == GClass154.gclass2_14 || image == GClass154.gclass2_15 || image == GClass154.gclass2_33) && GClass173.smethod_0().bool_14) || (image == GClass134.gclass2_0 && (GClass173.smethod_0().bool_7 || GClass173.smethod_0().bool_8)) || (image == GClass1.gclass2_12 && GClass173.smethod_0().bool_9))
			image = null;
		if (image != null)
			method_23(image, 0, 0, smethod_0(image), smethod_1(image), 0, x, y, anchor);
	}

	public void method_32(GClass2 image, int x, int y, int anchor)
	{
		if (image != null)
			method_23(image, 0, 0, image.texture2D_0.width, image.texture2D_0.height, 0, x, y, anchor);
	}

	public void method_33(GClass2 image, int x, int y)
	{
		if (image != null)
			method_23(image, 0, 0, smethod_0(image), smethod_1(image), 0, x, y, int_4 | int_2);
	}

	public void method_34(GClass2 image, float x, float y, int anchor)
	{
		if (image != null)
			method_24(image, 0, 0, smethod_0(image), smethod_1(image), 0, x, y, anchor);
	}

	public void method_35(int x, int y, int w, int h, int arcWidth, int arcHeight)
	{
		method_14(x, y, w, h);
	}

	public void method_36(int x, int y, int width, int height, int arcWidth, int arcHeight)
	{
		method_15(x, y, width, height);
	}

	public void method_37()
	{
		bool_0 = false;
		bool_1 = false;
		int_10 = 0;
		int_11 = 0;
	}

	public Rect method_38(Rect r1, Rect r2)
	{
		float num = r1.x;
		float num2 = r1.y;
		float x = r2.x;
		float y = r2.y;
		float num3 = num + r1.width;
		float num4 = num2 + r1.height;
		float num5 = x + r2.width;
		float num6 = y + r2.height;
		if (num < x)
			num = x;
		if (num2 < y)
			num2 = y;
		if (num3 > num5)
			num3 = num5;
		if (num4 > num6)
			num4 = num6;
		num3 -= num;
		num4 -= num2;
		if (num3 < -30000f)
			num3 = -30000f;
		if (num4 < -30000f)
			num4 = -30000f;
		return new Rect(num, num2, (int)num3, (int)num4);
	}

	public void method_39(GClass2 image, int x, int y, int w, int h, int tranform)
	{
		GUI.color = Color.red;
		x *= int_12;
		y *= int_12;
		w *= int_12;
		h *= int_12;
		if (image != null)
			Graphics.DrawTexture(new Rect(x + int_10, y + int_11, (tranform != 0) ? (-w) : w, h), image.texture2D_0);
	}

	public void method_40(GClass2 image, int x, int y)
	{
		x *= int_12;
		y *= int_12;
		if (image != null)
			Graphics.DrawTexture(new Rect(x, y, image.int_5, image.int_6), image.texture2D_0);
	}

	public static int smethod_0(GClass2 image)
	{
		return image.method_0();
	}

	public static int smethod_1(GClass2 image)
	{
		return image.method_1();
	}

	public static bool smethod_2(Color color)
	{
		if (color == Color.clear || color == color_1)
			return false;
		return true;
	}

	public static GClass2 smethod_3(GClass2 img0, float level, int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		Color color = new Color(b: (float)num / 256f, g: (float)num2 / 256f, r: (float)num3 / 256f);
		Color[] pixels = img0.texture2D_0.GetPixels();
		float r = color.r;
		float g2 = color.g;
		float b2 = color.b;
		for (int i = 0; i < pixels.Length; i++)
		{
			Color color2 = pixels[i];
			if (smethod_2(color2))
			{
				float num4 = (r - color2.r) * level + color2.r;
				float num5 = (g2 - color2.g) * level + color2.g;
				float num6 = (b2 - color2.b) * level + color2.b;
				if (num4 > 255f)
					num4 = 255f;
				if (num4 < 0f)
					num4 = 0f;
				if (num5 > 255f)
					num5 = 255f;
				if (num5 < 0f)
					num5 = 0f;
				if (num6 < 0f)
					num6 = 0f;
				if (num6 > 255f)
					num6 = 255f;
				pixels[i].r = num4;
				pixels[i].g = num5;
				pixels[i].b = num6;
			}
		}
		GClass2 gClass = GClass2.smethod_4(img0.method_3(), img0.method_4());
		gClass.texture2D_0.SetPixels(pixels);
		GClass2.smethod_26(gClass.texture2D_0);
		gClass.texture2D_0.Apply();
		GClass5.smethod_3("BLEND ----------------------------------------------------");
		return gClass;
	}

	public static Color smethod_4(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		return new Color(b: (float)num / 256f, g: (float)num2 / 256f, r: (float)num3 / 256f);
	}

	public void method_41(GClass2 imgTrans, int x, int y, int w, int h)
	{
		method_20(0, 0.5f);
		method_15(x * int_12, y * int_12, w * int_12, h * int_12);
	}

	public static int smethod_5(float level, int color, int colorBlend)
	{
		Color color2 = smethod_4(colorBlend);
		float num = color2.r * 255f;
		float num2 = color2.g * 255f;
		float num3 = color2.b * 255f;
		Color color3 = smethod_4(color);
		float num4 = (num + color3.r) * level + color3.r;
		float num5 = (num2 + color3.g) * level + color3.g;
		float num6 = (num3 + color3.b) * level + color3.b;
		if (num4 > 255f)
			num4 = 255f;
		if (num4 < 0f)
			num4 = 0f;
		if (num5 > 255f)
			num5 = 255f;
		if (num5 < 0f)
			num5 = 0f;
		if (num6 < 0f)
			num6 = 0f;
		if (num6 > 255f)
			num6 = 255f;
		return (int)num6 & (255 + ((int)num5 << 8)) & (255 + ((int)num4 << 16)) & 0xFF;
	}

	public static int smethod_6(Color cl)
	{
		float num = cl.r * 255f;
		float num2 = cl.b * 255f;
		return (((int)num & 0xFF) << 16) | (((int)(cl.g * 255f) & 0xFF) << 8) | ((int)num2 & 0xFF);
	}

	public static int smethod_7(GClass2 img)
	{
		return img.int_5;
	}

	public static int smethod_8(GClass2 img)
	{
		return img.int_6;
	}

	public void method_42(int i, int j, int k, int l, int m, int n)
	{
		method_15(i * int_12, j * int_12, k * int_12, l * int_12);
	}

	public void method_43()
	{
		if (!material_0)
		{
			material_0 = new Material("Shader \"Lines/Colored Blended\" {SubShader { Pass {  Blend SrcAlpha OneMinusSrcAlpha  ZWrite Off Cull Off Fog { Mode Off }  BindChannels { Bind \"vertex\", vertex Bind \"color\", color }} } }");
			material_0.hideFlags = HideFlags.HideAndDontSave;
			material_0.shader.hideFlags = HideFlags.HideAndDontSave;
		}
	}

	public void method_44(GClass63 totalLine)
	{
		material_0.SetPass(0);
		GL.PushMatrix();
		GL.Begin(1);
		for (int i = 0; i < totalLine.method_2(); i++)
		{
			GClass135 gClass = (GClass135)totalLine.method_3(i);
			GL.Color(new Color(gClass.float_0, gClass.float_2, gClass.float_1, gClass.float_3));
			int num = gClass.int_0 * int_12;
			int num2 = gClass.int_2 * int_12;
			int num3 = gClass.int_1 * int_12;
			int num4 = gClass.int_3 * int_12;
			if (bool_1)
			{
				num += int_10;
				num2 += int_11;
				num3 += int_10;
				num4 += int_11;
			}
			for (int j = 0; j < int_12; j++)
			{
				GL.Vertex(new Vector2(num + j, num2 + j));
				GL.Vertex(new Vector2(num3 + j, num4 + j));
				if (j > 0)
				{
					GL.Vertex(new Vector2(num + j, num2));
					GL.Vertex(new Vector2(num3 + j, num4));
					GL.Vertex(new Vector2(num, num2 + j));
					GL.Vertex(new Vector2(num3, num4 + j));
				}
			}
		}
		GL.End();
		GL.PopMatrix();
		totalLine.method_9();
	}

	public void method_45(GClass76 g, int x, int y, int xTo, int yTo, int nLine, int color)
	{
		GClass63 gClass = new GClass63();
		for (int i = 0; i < nLine; i++)
		{
			gClass.method_0(new GClass135(x, y, xTo + i, yTo + i, color));
		}
		g.method_44(gClass);
	}

	internal void method_46(GClass129 gclass129_0, int int_28, int int_29, int int_30, int int_31, int int_32, int int_33, int int_34, int int_35)
	{
		throw new NotImplementedException();
	}
}
