using System;
using System.Text.RegularExpressions;
using UnityEngine;

namespace ns1
{
	public class GClass193
	{
		public class GClass194
		{
			private static GClass194 gclass194_0;

			public bool bool_0;

			public string[] string_0 = new string[44]
			{
				"aw", "aa", "uow", "as", "af", "ax", "ar", "aj", "dd", "es",
				"ef", "ex", "ej", "er", "ee", "is", "if", "ir", "ix", "ij",
				"os", "of", "or", "ox", "oj", "oo", "ow", "us", "uf", "ur",
				"ux", "uj", "uuw", "uw", "uyr", "uys", "uyf", "uyj", "uyx", "ys",
				"yf", "yr", "yx", "yj"
			};

			public string[] string_1 = new string[44]
			{
				"ă", "â", "ươ", "á", "à", "ã", "ả", "ạ", "đ", "é",
				"è", "ẽ", "ẹ", "ẻ", "ê", "í", "ì", "ỉ", "ĩ", "ị",
				"ó", "ò", "ỏ", "õ", "ọ", "ô", "ơ", "ú", "ù", "ủ",
				"ũ", "ụ", "ưu", "ư", "uỷ", "uý", "uỳ", "uỵ", "uỹ", "ý",
				"ỳ", "ỷ", "ỹ", "ỵ"
			};

			public static GClass194 smethod_0()
			{
				if (gclass194_0 == null)
					gclass194_0 = new GClass194();
				return gclass194_0;
			}

			public string method_0(string text)
			{
				for (int i = 0; i < string_1.Length; i++)
				{
					text = ((text.LastIndexOf("uows") == -1) ? ((text.LastIndexOf("uowf") == -1) ? ((text.LastIndexOf("uowx") == -1) ? ((text.LastIndexOf("uowj") == -1) ? ((text.LastIndexOf("uowr") == -1) ? ((text.LastIndexOf("uuws") == -1) ? ((text.LastIndexOf("uuwf") == -1) ? ((text.LastIndexOf("uuwr") == -1) ? ((text.LastIndexOf("uuwx") == -1) ? ((text.LastIndexOf("uuwj") == -1) ? ((text.LastIndexOf("ees") == -1) ? ((text.LastIndexOf("eef") == -1) ? ((text.LastIndexOf("eer") == -1) ? ((text.LastIndexOf("eej") == -1) ? ((text.LastIndexOf("eex") == -1) ? ((text.LastIndexOf("oor") == -1) ? ((text.LastIndexOf("oof") == -1) ? ((text.LastIndexOf("oos") == -1) ? ((text.LastIndexOf("oox") == -1) ? ((text.LastIndexOf("ooj") == -1) ? ((text.LastIndexOf("owj") == -1) ? ((text.LastIndexOf("ows") == -1) ? ((text.LastIndexOf("owx") == -1) ? ((text.LastIndexOf("owf") == -1) ? ((text.LastIndexOf("owr") == -1) ? ((text.LastIndexOf("uwr") == -1) ? ((text.LastIndexOf("uwf") == -1) ? ((text.LastIndexOf("uws") == -1) ? ((text.LastIndexOf("uwj") == -1) ? ((text.LastIndexOf("uwx") == -1) ? ((text.LastIndexOf("aas") == -1) ? ((text.LastIndexOf("aaf") == -1) ? ((text.LastIndexOf("aar") == -1) ? ((text.LastIndexOf("aax") == -1) ? ((text.LastIndexOf("aaj") == -1) ? ((text.LastIndexOf("aws") == -1) ? ((text.LastIndexOf("awr") == -1) ? ((text.LastIndexOf("awx") == -1) ? ((text.LastIndexOf("awf") == -1) ? ((text.LastIndexOf("awj") == -1) ? text.Replace(string_0[i], string_1[i]) : text.Replace("awj", "ặ")) : text.Replace("awf", "ằ")) : text.Replace("awx", "ẵ")) : text.Replace("awr", "ẳ")) : text.Replace("aws", "ắ")) : text.Replace("aaj", "ậ")) : text.Replace("aax", "ẫ")) : text.Replace("aar", "ẩ")) : text.Replace("aaf", "ầ")) : text.Replace("aas", "ấ")) : text.Replace("uwx", "ữ")) : text.Replace("uwj", "ự")) : text.Replace("uws", "ứ")) : text.Replace("uwf", "ừ")) : text.Replace("uwr", "ử")) : text.Replace("owr", "ở")) : text.Replace("owf", "ờ")) : text.Replace("owx", "ỡ")) : text.Replace("ows", "ớ")) : text.Replace("owj", "ợ")) : text.Replace("ooj", "ộ")) : text.Replace("oox", "ỗ")) : text.Replace("oos", "ố")) : text.Replace("oof", "ồ")) : text.Replace("oor", "ổ")) : text.Replace("eex", "ễ")) : text.Replace("eej", "ệ")) : text.Replace("eer", "ể")) : text.Replace("eef", "ề")) : text.Replace("ees", "ế")) : text.Replace("uuwj", "ựu")) : text.Replace("uuwx", "ữu")) : text.Replace("uuwr", "ửu")) : text.Replace("uuws", "ừu")) : text.Replace("uuws", "ứu")) : text.Replace("uowr", "ưở")) : text.Replace("uowj", "ượ")) : text.Replace("uowx", "ưỡ")) : text.Replace("uowf", "ườ")) : text.Replace("uows", "ướ"));
				}
				return text;
			}
		}

		private static GClass193 hiLlVkoTaS;

		public static GClass193 smethod_0()
		{
			return (hiLlVkoTaS != null) ? hiLlVkoTaS : (hiLlVkoTaS = new GClass193());
		}

		public string[] method_0(string text)
		{
			if (!string.IsNullOrEmpty(text))
				return text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
			return new string[0];
		}

		public bool method_1(string text, string caption)
		{
			return Regex.Replace(text, "[^\\w\\s]", " ").Replace(" ", "").ToLower()
				.Replace("\n", "")
				.Replace("\r", "") == caption;
		}

		public void method_2(GClass49 forwardFont, GClass76 g, string text, int x, int y, int align, GClass49 backwardFont)
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

		public void method_3(GClass49 forwardFont, GClass76 g, string text, int x, int y, int align, GClass49 backwardFont, string type)
		{
			int int_ = GClass76.int_12;
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
				case "underline":
					forwardFont.method_10(g, text, x, y, align, backwardFont);
					break;
				case "noborder":
					forwardFont.method_6(g, text, x, y, align);
					break;
				case "border":
					method_2(forwardFont, g, text, x, y, align, backwardFont);
					break;
				}
			}
		}

		internal int method_4(GUIStyle guistyle_0, string string_0)
		{
			return (int)(guistyle_0.CalcSize(new GUIContent(string_0)).x * 1.05f / (float)GClass76.int_12);
		}

		internal int method_5(GUIStyle guistyle_0, string string_0)
		{
			return (int)guistyle_0.CalcSize(new GUIContent(string_0)).y / GClass76.int_12;
		}

		public string method_6(bool check)
		{
			return (GClass192.int_0 != 0) ? (check ? "On" : "Off") : (check ? "Bật" : "Tắt");
		}

		public string method_7(bool check)
		{
			return (GClass192.int_0 != 0) ? (check ? "Is On" : "Is Off") : (check ? "Đang bật" : "Đang tắt");
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

		public bool method_9<T>(string text, string s, int n)
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

		public bool method_10<T>(string text, string s)
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

		public T method_11<T>(string text, string s)
		{
			return (T)Convert.ChangeType(text.Substring(s.Length), typeof(T));
		}
	}
}
