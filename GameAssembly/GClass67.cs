using System;
using System.Threading;
using ns1;

public class GClass67 : GInterface0
{
	public bool bool_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3 = true;

	public const sbyte sbyte_0 = 14;

	public const sbyte sbyte_1 = 15;

	public const sbyte sbyte_2 = 19;

	public static int int_4 = 2;

	private static readonly int[] int_5 = new int[7] { 30, 14, 11, 9, 6, 4, 2 };

	private static int int_6 = 0;

	private static readonly int int_7 = 1;

	private static readonly int int_8 = 5;

	private static readonly int int_9 = 4;

	private static readonly int int_10 = 10;

	public static readonly int int_11 = 0;

	public static readonly int int_12 = 1;

	public static readonly int int_13 = 2;

	public static readonly int int_14 = 3;

	private static string[] string_0 = new string[12]
	{
		" 0", ".,@?!_1\"/$-():*+<=>;%&~#%^&*{}[];'/1", "abc2áàảãạâấầẩẫậăắằẳẵặ2", "def3đéèẻẽẹêếềểễệ3", "ghi4íìỉĩị4", "jkl5", "mno6óòỏõọôốồổỗộơớờởỡợ6", "pqrs7", "tuv8úùủũụưứừửữự8", "wxyz9ýỳỷỹỵ9",
		"*", "#"
	};

	private static string[] string_1 = new string[12]
	{
		"0", "1", "abc2", "def3", "ghi4", "jkl5", "mno6", "pqrs7", "tuv8", "wxyz9",
		"0", "0"
	};

	private static string[] string_2 = new string[17]
	{
		" 0", "er1", "ty2", "ui3", "df4", "gh5", "jk6", "cv7", "bn8", "m9",
		"0", "0", "qw!", "as?", "zx", "op.", "l,"
	};

	private string string_3 = string.Empty;

	private string string_4 = string.Empty;

	private string string_5 = string.Empty;

	private int int_15;

	private int int_16;

	private int int_17 = 500;

	private int int_18;

	private static int int_19 = -1984;

	private int int_20;

	private int int_21;

	private int int_22 = int_10;

	private int int_23 = int_11;

	public static bool bool_4 = true;

	public static int int_24;

	public static int int_25 = 0;

	public static long long_0;

	public static readonly string[] string_6 = new string[4] { "abc", "Abc", "ABC", "123" };

	public static readonly int int_26 = 0;

	public static readonly int int_27 = 1;

	public static readonly int int_28 = 2;

	public static readonly int int_29 = 3;

	public static int int_30 = 11;

	public static readonly sbyte sbyte_3 = 0;

	public static readonly sbyte sbyte_4 = 1;

	public static readonly sbyte sbyte_5 = 2;

	public static readonly sbyte sbyte_6 = 3;

	public static GClass67 gclass67_0;

	public bool bool_5;

	public bool bool_6 = true;

	public string string_7 = string.Empty;

	public string string_8 = string.Empty;

	public string string_9;

	public GClass14 gclass14_0;

	public GClass14 gclass14_1;

	private GClass145 gclass145_0;

	private int int_31;

	private int int_32;

	public static int int_33;

	private int int_34 = -1;

	private int int_35;

	private int int_36;

	private long long_1;

	private static string string_10 = "aáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵ";

	public static GClass2 gclass2_0;

	public int int_37;

	public int int_38;

	public bool bool_7;

	public bool bool_8 = true;

	public static GClass111 gclass111_0;

	public static int[][] int_39 = new int[17][]
	{
		new int[2] { 32, 48 },
		new int[2] { 49, 69 },
		new int[2] { 50, 84 },
		new int[2] { 51, 85 },
		new int[2] { 52, 68 },
		new int[2] { 53, 71 },
		new int[2] { 54, 74 },
		new int[2] { 55, 67 },
		new int[2] { 56, 66 },
		new int[2] { 57, 77 },
		new int[2] { 42, 128 },
		new int[2] { 35, 137 },
		new int[2] { 33, 113 },
		new int[2] { 63, 97 },
		new int[3] { 64, 121, 122 },
		new int[2] { 46, 111 },
		new int[2] { 44, 108 }
	};

	public GClass67(GClass145 parentScr)
	{
		string_3 = string.Empty;
		gclass145_0 = parentScr;
		method_1();
	}

	public GClass67()
	{
		string_3 = string.Empty;
		method_1();
	}

	public GClass67(int x, int y, int w, int h)
	{
		string_3 = string.Empty;
		method_1();
		int_0 = x;
		int_1 = y;
		int_2 = w;
		int_3 = h;
	}

	public GClass67(string text, int maxLen, int inputType)
	{
		string_3 = text;
		int_17 = maxLen;
		int_23 = inputType;
		method_1();
		bool_5 = true;
	}

	public static bool smethod_0(char ch)
	{
		if ((ch < '0' || ch > '9') && (ch < 'A' || ch > 'Z') && (ch < 'a' || ch > 'z'))
			return false;
		return true;
	}

	public void method_0()
	{
	}

	public static void smethod_1(int mode)
	{
		if (mode == int_27)
		{
			string_0[0] = "0";
			string_0[10] = " *";
			string_0[11] = "#";
			int_30 = 35;
		}
		else if (mode == int_26)
		{
			string_0[0] = " 0";
			string_0[10] = "*";
			string_0[11] = "#";
			int_30 = 35;
		}
		else if (mode == int_28)
		{
			string_0[0] = "0";
			string_0[10] = "*";
			string_0[11] = " #";
			int_30 = 42;
		}
	}

	public void method_1()
	{
		int_6 = GClass145.int_0 + 1;
		gclass14_0 = new GClass14(mResources.DELETE, this, 1000, null);
		if (Main.isPC)
			int_4 = 0;
		if (gclass2_0 == null)
			gclass2_0 = GClass39.smethod_43("/mainImage/myTexture2dtf.png");
	}

	public void method_2(int keyCode)
	{
		if (keyCode == -8 && int_31 <= 0)
		{
			if (int_31 <= 0)
				int_31 = 1;
			method_4();
		}
	}

	public void method_3()
	{
		string_3 = string.Empty;
		if (gclass111_0 != null)
			gclass111_0.string_0 = string.Empty;
		int_15 = 0;
		method_11(0);
		method_16();
	}

	public void method_4()
	{
		if (int_15 > 0 && string_3.Length > 0)
		{
			string_3 = string_3.Substring(0, int_15 - 1);
			int_15--;
			method_11(0);
			method_16();
			if (gclass111_0 != null)
				gclass111_0.string_0 = string_3;
		}
	}

	public void method_5()
	{
		if (int_15 > 0 && string_3.Length > 0)
		{
			string_3 = string_3.Substring(0, string_3.Length - 1);
			int_15--;
			method_6();
			method_16();
			method_20(true);
			if (gclass111_0 != null)
				gclass111_0.string_0 = string.Empty;
		}
	}

	public void method_6()
	{
		if (string_5 != null && GClass49.gclass49_21 != null)
		{
			if (int_23 == int_13)
				string_5 = string_4;
			else
				string_5 = string_3;
			if (int_18 < 0 && GClass49.gclass49_21.method_17(string_5) + int_18 < int_2 - int_9 - 13 - int_24)
				int_18 = int_2 - 10 - int_24 - GClass49.gclass49_21.method_17(string_5);
			if (int_18 + GClass49.gclass49_21.method_17(string_5.Substring(0, int_15)) <= 0)
			{
				int_18 = -GClass49.gclass49_21.method_17(string_5.Substring(0, int_15));
				int_18 += 40;
			}
			else if (int_18 + GClass49.gclass49_21.method_17(string_5.Substring(0, int_15)) >= int_2 - 12 - int_24)
			{
				int_18 = int_2 - 10 - int_24 - GClass49.gclass49_21.method_17(string_5.Substring(0, int_15)) - 2 * int_9;
			}
			if (int_18 > 0)
				int_18 = 0;
		}
	}

	private void method_7(int int_40)
	{
		string[] array = ((int_23 == int_13 || int_23 == int_14) ? string_1 : string_0);
		if (int_40 == int_19)
		{
			int_21 = (int_21 + 1) % array[int_40 - 48].Length;
			char c = array[int_40 - 48][int_21];
			string text = string.Concat(arg1: (int_25 == 0) ? char.ToLower(c) : ((int_25 == 1) ? char.ToUpper(c) : ((int_25 != 2) ? array[int_40 - 48][array[int_40 - 48].Length - 1] : char.ToUpper(c))), arg0: string_3.Substring(0, int_15 - 1));
			if (int_15 < string_3.Length)
				text += string_3.Substring(int_15, string_3.Length);
			string_3 = text;
			int_20 = int_5[int_4];
			method_16();
		}
		else if (string_3.Length < int_17)
		{
			if (int_25 == 1 && int_19 != -1984)
				int_25 = 0;
			int_21 = 0;
			char c2 = array[int_40 - 48][int_21];
			string text2 = string.Concat(arg1: (int_25 == 0) ? char.ToLower(c2) : ((int_25 == 1) ? char.ToUpper(c2) : ((int_25 != 2) ? array[int_40 - 48][array[int_40 - 48].Length - 1] : char.ToUpper(c2))), arg0: string_3.Substring(0, int_15));
			if (int_15 < string_3.Length)
				text2 += string_3.Substring(int_15, string_3.Length);
			string_3 = text2;
			int_20 = int_5[int_4];
			int_15++;
			method_16();
			method_6();
		}
		int_19 = int_40;
	}

	private void method_8(int int_40)
	{
		if ((int_23 == int_13 || int_23 == int_14) && (int_40 < 48 || int_40 > 57) && (int_40 < 65 || int_40 > 90) && (int_40 < 97 || int_40 > 122))
			return;
		if (string_3.Length < int_17)
		{
			string text = string_3.Substring(0, int_15) + (char)int_40;
			if (int_15 < string_3.Length)
				text += string_3.Substring(int_15, string_3.Length - int_15);
			string_3 = text;
			int_15++;
			method_16();
			method_11(0);
		}
		if (gclass111_0 != null)
			gclass111_0.string_0 = string_3;
	}

	public static void smethod_2()
	{
		int_25++;
		if (int_25 > 3)
			int_25 = 0;
		int_19 = int_30;
		long_0 = Environment.TickCount / 1000;
	}

	private void method_9()
	{
		long_1 = Environment.TickCount / 100;
		if (int_34 == -1)
		{
			for (int num = int_15; num > 0; num--)
			{
				char c = string_3[num - 1];
				for (int i = 0; i < string_10.Length; i++)
				{
					if (c == string_10[i])
					{
						int_35 = i;
						int_36 = 0;
						int_34 = num - 1;
						return;
					}
				}
			}
			int_34 = -1;
		}
		else
		{
			int_36++;
			if (int_36 >= 6)
				int_36 = 0;
			string_3 = string.Concat(string_3.Substring(0, int_34), str2: string_3.Substring(int_34 + 1), str1: string_10.Substring(int_35 + int_36, 1));
		}
	}

	public bool method_10(int keyCode)
	{
		if (Main.isPC && keyCode == -8)
		{
			method_2(-8);
			return true;
		}
		if (keyCode == 8 || keyCode == -8 || keyCode == 204)
		{
			method_4();
			return true;
		}
		if (bool_4 && keyCode >= 32)
		{
			method_8(keyCode);
			return false;
		}
		if (keyCode == int_33 && int_23 == int_11)
		{
			method_9();
			return false;
		}
		if (keyCode == 42)
			keyCode = 58;
		if (keyCode == 35)
			keyCode = 59;
		if (keyCode >= 48 && keyCode <= 59)
		{
			if (int_23 == int_11 || int_23 == int_13 || int_23 == int_14)
				method_7(keyCode);
			else if (int_23 == int_12)
			{
				method_8(keyCode);
				int_20 = 1;
			}
		}
		else
		{
			int_21 = 0;
			int_19 = -1984;
			if (keyCode == 14 && !bool_1)
			{
				if (int_15 > 0)
				{
					int_15--;
					method_11(0);
					int_22 = int_10;
					return false;
				}
			}
			else if (keyCode == 15 && !bool_1)
			{
				if (int_15 < string_3.Length)
				{
					int_15++;
					method_11(0);
					int_22 = int_10;
					return false;
				}
			}
			else
			{
				if (keyCode == 19)
				{
					method_4();
					return false;
				}
				int_19 = keyCode;
			}
		}
		return true;
	}

	public void method_11(int index)
	{
		if (int_23 == int_13)
			string_5 = string_4;
		else
			string_5 = string_3;
		int num = GClass49.gclass49_21.method_17(string_5.Substring(0, int_15));
		if (index != -1)
		{
			if (index != 1)
				int_18 = -(num - (int_2 - 12));
			else if (num + int_18 > int_2 - 25 && int_15 < string_5.Length && int_15 > 0)
			{
				int_18 -= GClass49.gclass49_21.method_17(string_5.Substring(int_15 - 1, 1));
			}
		}
		else if (num + int_18 < 15 && int_15 > 0 && int_15 < string_5.Length)
		{
			int_18 += GClass49.gclass49_21.method_17(string_5.Substring(int_15, 1));
		}
		if (int_18 > 0)
			int_18 = 0;
		else if (int_18 < 0)
		{
			int num2 = GClass49.gclass49_21.method_17(string_5) - (int_2 - 12);
			if (int_18 < -num2)
				int_18 = -num2;
		}
	}

	public void method_12(GClass76 g, bool iss, int x, int y, int w, int h, int xText, int yText, string text, string info)
	{
		g.method_16(0);
		if (iss)
		{
			g.method_23(gclass2_0, 0, 81, 29, 27, 0, x, y, 0);
			g.method_23(gclass2_0, 0, 135, 29, 27, 0, x + w - 29, y, 0);
			g.method_23(gclass2_0, 0, 108, 29, 27, 0, x + w - 58, y, 0);
			for (int i = 0; i < (w - 58) / 29; i++)
			{
				g.method_23(gclass2_0, 0, 108, 29, 27, 0, x + 29 + i * 29, y, 0);
			}
		}
		else
		{
			g.method_23(gclass2_0, 0, 0, 29, 27, 0, x, y, 0);
			g.method_23(gclass2_0, 0, 54, 29, 27, 0, x + w - 29, y, 0);
			g.method_23(gclass2_0, 0, 27, 29, 27, 0, x + w - 58, y, 0);
			for (int j = 0; j < (w - 58) / 29; j++)
			{
				g.method_23(gclass2_0, 0, 27, 29, 27, 0, x + 29 + j * 29, y, 0);
			}
		}
		g.method_5(x + 3, y + 1, w - 4, h);
		if (text != null && !text.Equals(string.Empty))
			GClass49.gclass49_21.method_6(g, text, xText, yText, 0);
		else if (info != null)
		{
			if (iss)
				GClass49.gclass49_9.method_6(g, info, xText, yText, 0);
			else
				GClass49.gclass49_10.method_6(g, info, xText, yText, 0);
		}
	}

	public void method_13(GClass76 g)
	{
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		bool flag = method_14();
		if (int_23 == int_13)
			string_5 = string_4;
		else
			string_5 = string_3;
		method_12(g, flag, int_0, int_1 - 1, int_2, int_3 + 5, int_9 + int_18 + int_0 + 1, int_1 + (int_3 - GClass49.gclass49_21.method_20()) / 2 + 2, (!GClass193.GClass194.smethod_0().bool_0 || string_5.StartsWith("/")) ? string_5 : GClass193.GClass194.smethod_0().method_0(string_5), string_7);
		g.method_5(int_0 + 3, int_1 + 1, int_2 - 4, int_3 - 2);
		g.method_16(0);
		if (flag && bool_6 && bool_7)
		{
			if (int_20 == 0 && (int_22 > 0 || int_16 / int_8 % 4 == 0))
			{
				g.method_16(7999781);
				g.method_15(int_9 + 1 + int_18 + int_0 + GClass49.gclass49_21.method_17(string_5.Substring(0, int_15) + "a") - int_7 - GClass49.gclass49_21.method_17("a"), int_1 + (int_3 - int_6) / 2 + 5, int_7, int_6);
			}
			GClass39.smethod_6(g);
			if (string_3 != null && string_3.Length > 0 && GClass39.bool_5)
				g.method_31(GClass39.gclass2_7, int_0 + int_2 - 13, int_1 + int_3 / 2 + 3, GClass76.int_1 | GClass76.int_0);
		}
	}

	private bool method_14()
	{
		return bool_0;
	}

	public string method_15(string str, int index, int indexTo)
	{
		if (index >= 0 && indexTo > str.Length - 1)
			return str.Substring(index);
		if (index < 0 || index > str.Length - 1 || indexTo < 0 || indexTo > str.Length - 1)
			return string.Empty;
		string text = string.Empty;
		for (int i = index; i < indexTo; i++)
		{
			text += str[i];
		}
		return text;
	}

	private void method_16()
	{
		if (int_23 == int_13)
		{
			string_4 = string.Empty;
			for (int i = 0; i < string_3.Length; i++)
			{
				string_4 += "*";
			}
			if (int_20 > 0 && int_15 > 0)
				string_4 = string_4.Substring(0, int_15 - 1) + string_3[int_15 - 1] + string_4.Substring(int_15, string_4.Length);
		}
	}

	public void method_17()
	{
		bool_7 = true;
		if (Main.isPC)
		{
			if (int_31 > 0)
				int_31--;
			if (int_31 <= 0)
				int_31 = 0;
		}
		if (gclass111_0 != null && gclass67_0 == this)
		{
			if (gclass111_0.string_0.Length < 40 && bool_0)
				method_23(gclass111_0.string_0);
			if (gclass111_0.bool_2 && gclass14_1 != null)
				gclass14_1.method_1();
		}
		int_16++;
		if (int_20 > 0)
		{
			int_20--;
			if (int_20 == 0)
			{
				int_21 = 0;
				if (int_25 == 1 && int_19 != int_30 && bool_0)
					int_25 = 0;
				int_19 = -1984;
				method_16();
			}
		}
		if (int_22 > 0)
			int_22--;
		if (GClass39.bool_16)
			method_18();
		if (int_34 != -1 && Environment.TickCount / 100 - long_1 > 5L)
			int_34 = -1;
	}

	public void method_18()
	{
		if (GClass39.smethod_24(int_0 + int_2 - 20, int_1, 40, int_3))
		{
			method_3();
			bool_0 = true;
		}
		else if (GClass39.smethod_24(int_0, int_1, int_2 - 20, int_3))
		{
			method_20(true);
		}
		else
		{
			method_19(false);
		}
	}

	public void method_19(bool isFocus)
	{
		if (bool_0 != isFocus)
			int_25 = 0;
		int_19 = -1984;
		long_0 = (int)(DateTime.Now.Ticks / 1000L);
		bool_0 = isFocus;
		if (isFocus)
		{
			gclass67_0 = this;
			if (gclass111_0 != null)
				gclass111_0.string_0 = gclass67_0.string_3;
		}
	}

	public void method_20(bool isFocus)
	{
		if (bool_0 != isFocus)
			int_25 = 0;
		int_19 = -1984;
		long_0 = (int)(DateTime.Now.Ticks / 1000L);
		bool_0 = isFocus;
		if (isFocus)
			gclass67_0 = this;
		else if (gclass67_0 == this)
		{
			gclass67_0 = null;
		}
		if (Thread.CurrentThread.Name == Main.mainThreadName && gclass67_0 != null)
		{
			isFocus = true;
			GClass111.bool_0 = !gclass67_0.bool_8;
			GEnum1 t = GEnum1.const_1;
			if (int_23 == int_12)
				t = GEnum1.const_2;
			bool type = false;
			if (int_23 == int_13)
				type = true;
			gclass111_0 = GClass111.smethod_0(gclass67_0.string_3, t, false, false, type, false, gclass67_0.string_7);
			if (gclass111_0 != null)
				gclass111_0.string_0 = gclass67_0.string_3;
			GClass5.smethod_5("SHOW KEYBOARD FOR " + gclass67_0.string_3);
		}
	}

	public string method_21()
	{
		return string_3;
	}

	public void method_22()
	{
		if (gclass111_0 != null)
			gclass111_0.string_0 = string.Empty;
	}

	public void method_23(string text)
	{
		if (text != null)
		{
			int_19 = -1984;
			int_20 = 0;
			int_21 = 0;
			string_3 = text;
			string_5 = text;
			if (text == string.Empty)
				GClass111.smethod_1();
			method_16();
			int_15 = text.Length;
			method_6();
		}
	}

	public void method_24(string text)
	{
		string_3 = string_3.Substring(0, int_15) + text + string_3.Substring(int_15);
		method_16();
		int_15 += text.Length;
		method_6();
	}

	public int method_25()
	{
		return int_17;
	}

	public void method_26(int maxTextLenght)
	{
		int_17 = maxTextLenght;
	}

	public int method_27()
	{
		return int_23;
	}

	public void method_28(int iputType)
	{
		int_23 = iputType;
		method_26(500);
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
			method_4();
	}
}
