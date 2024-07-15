using System;
using System.Text.RegularExpressions;
using UnityEngine;
using Vietpad.InputMethod;

namespace ns1
{
	public class GClass45
	{
		private static GClass45 gclass45_0;

		public static VietKeyHandler vietKeyHandler_0 = new VietKeyHandler();

		public bool bool_0;

		public static GClass45 smethod_0()
		{
			return (gclass45_0 != null) ? gclass45_0 : (gclass45_0 = new GClass45());
		}

		public bool method_0(string text, string caption)
		{
			return Regex.Replace(text, "[^\\w\\s]", " ").Replace(" ", "").ToLower()
				.Replace("\n", "")
				.Replace("\r", "") == caption;
		}

		public void method_1(GClass104 forwardFont, GClass193 g, string text, int x, int y, int align, GClass104 backwardFont)
		{
			backwardFont.method_6(g, text, x - 1, y - 1, align);
			backwardFont.method_6(g, text, x - 1, y + 1, align);
			backwardFont.method_6(g, text, x + 1, y - 1, align);
			backwardFont.method_6(g, text, x + 1, y + 1, align);
			backwardFont.method_6(g, text, x, y - 1, align);
			backwardFont.method_6(g, text, x, y + 1, align);
			backwardFont.method_6(g, text, x - 1, y, align);
			backwardFont.method_6(g, text, x + 1, y, align);
			forwardFont.method_6(g, text, x, y, align);
		}

		public void method_2(GClass104 forwardFont, GClass193 g, string text, int x, int y, int align, GClass104 backwardFont, string type)
		{
			int int_ = GClass193.int_12;
			if (int_ != 1)
			{
				if (int_ == 2)
				{
					switch (type)
					{
					case "underline":
						forwardFont.method_10(g, text, x, y, align, backwardFont);
						break;
					case "noborder":
						forwardFont.method_6(g, text, x, y, align);
						break;
					case "border":
						forwardFont.method_9(g, text, x, y, align, backwardFont);
						break;
					}
				}
			}
			else
			{
				switch (type)
				{
				case "border":
					method_1(forwardFont, g, text, x, y, align, backwardFont);
					break;
				case "underline":
					forwardFont.method_10(g, text, x, y, align, backwardFont);
					break;
				case "noborder":
					forwardFont.method_6(g, text, x, y, align);
					break;
				}
			}
		}

		public void method_3(ref string str, int inputType, int caresPos, char keyChar)
		{
			if (inputType == GClass136.int_11 && ((!str.StartsWith("/") && !str.Contains("/achat")) || str.StartsWith("/achat_")))
				str = vietKeyHandler_0.toVietnamese(str, caresPos);
		}

		internal int method_4(GUIStyle guistyle_0, string string_0)
		{
			return (int)(guistyle_0.CalcSize(new GUIContent(string_0)).x * 1.025f / (float)GClass193.int_12);
		}

		internal int method_5(GUIStyle guistyle_0, string string_0)
		{
			return (int)guistyle_0.CalcSize(new GUIContent(string_0)).y / GClass193.int_12;
		}

		public string method_6(bool check)
		{
			return (GClass62.int_0 != 0) ? (check ? "On" : "Off") : (check ? "Bật" : "Tắt");
		}

		public string method_7(bool check)
		{
			return (GClass62.int_0 != 0) ? (check ? "Is On" : "Is Off") : ((!check) ? "Đang tắt" : "Đang bật");
		}

		public T[] method_8<T>(string text, string s, int n)
		{
			T[] array = new T[n];
			string[] array2 = text.Substring(s.Length).Split(' ');
			for (int i = 0; i < n; i++)
			{
				array[i] = (T)Convert.ChangeType(array2[i], typeof(T));
			}
			return array;
		}

		public T[] method_9<T>(string text, string s, char splitChar)
		{
			string[] array = text.Substring(s.Length).Split(splitChar);
			T[] array2 = new T[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = (T)Convert.ChangeType(array[i], typeof(T));
			}
			return array2;
		}

		public bool method_10<T>(string text, string s, int n)
		{
			if (!text.StartsWith(s))
				return false;
			try
			{
				string[] array = text.Substring(s.Length).Split(' ');
				for (int i = 0; i < n; i++)
				{
					Convert.ChangeType(array[i], typeof(T));
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		public bool method_11<T>(string text, string s)
		{
			if (!text.StartsWith(s))
				return false;
			try
			{
				Convert.ChangeType(text.Substring(s.Length), typeof(T));
			}
			catch
			{
				return false;
			}
			return true;
		}

		public T method_12<T>(string text, string s)
		{
			return (T)Convert.ChangeType(text.Substring(s.Length), typeof(T));
		}
	}
}
