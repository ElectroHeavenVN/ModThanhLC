using System.Reflection;
using UnityEngine;

namespace ns1
{
	public class GClass59
	{
		private static GClass59 gclass59_0;

		public static GClass59 smethod_0()
		{
			if (gclass59_0 == null)
				gclass59_0 = new GClass59();
			return gclass59_0;
		}

		public static string smethod_1(GClass124 ch)
		{
			string text = "black";
			if ((GClass124.smethod_1().bool_47 || (!GClass124.smethod_1().bool_7 && GClass124.smethod_1().int_14 == 2 && GClass124.smethod_1().gclass95_0 == GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[4]))) && GClass47.smethod_0().List_1.Contains(ch))
				text = "gray";
			if (ch.int_13 < 0 || ch.gclass60_0.bool_0)
				text = "white";
			return "<color=white>[<color=" + text + ">" + GClass138.smethod_9(ch.int_25) + ((ch.int_13 > 0 || GClass137.int_37 == 113) ? ("-" + ch.method_3()) : string.Empty) + "</color>]</color>";
		}

		public bool method_0(GClass124 @char)
		{
			bool flag = (bool)typeof(GClass124).GetField("isPet", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(@char);
			bool flag2 = (bool)typeof(GClass124).GetField("isMiniPet", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(@char);
			return !flag && !flag2 && @char.string_3 != "Trọng tài" && char.IsUpper(method_10(@char)[0]) && @char.string_3 != "Arbitration";
		}

		public static string smethod_2(GClass124 @char, bool enableRichText = true)
		{
			string text = @char.string_3.Remove(0, @char.string_3.IndexOf(']') + 1).TrimStart(' ', '#', '$');
			string text2 = "black";
			if (GClass124.smethod_1().gclass124_0 == @char && GClass124.smethod_1().gclass124_0 != null)
				text2 = "white";
			if (GClass124.smethod_1().gclass124_0 != @char || GClass124.smethod_1().gclass124_0 == null)
				text2 = "black";
			if ((@char.int_13 < 0 && string.IsNullOrEmpty(@char.string_3)) || @char.int_13 < 0)
				text2 = "yellow";
			if (@char.gclass60_0.bool_0)
				text2 = "yellow";
			if ((GClass124.smethod_1().bool_47 || (!GClass124.smethod_1().bool_7 && GClass124.smethod_1().int_14 == 2 && GClass124.smethod_1().gclass95_0 == GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[4]))) && GClass47.smethod_0().List_1.Contains(@char))
				text2 = "yellow";
			if (enableRichText)
				text = "<color=" + text2 + ">" + (string.IsNullOrEmpty(@char.string_3) ? "Hachiyack" : text) + "</color>";
			return text;
		}

		public static string smethod_3(GClass124 @char)
		{
			return (@char.int_13 < 0 || (@char.int_13 > 0 && !@char.string_3.Contains("["))) ? string.Empty : ("<color=yellow>[</color><color=" + ((!@char.gclass60_0.bool_0) ? "black" : "white") + ">" + @char.string_3.Substring(0, @char.string_3.IndexOf(']') + 1).Replace("[", "").Replace("]", "") + "</color><color=yellow>]</color> ");
		}

		public bool method_1(GClass124 @char)
		{
			return ((bool)typeof(GClass124).GetField("isPet", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(@char) | (bool)typeof(GClass124).GetField("isMiniPet", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(@char)) || @char.string_3.StartsWith("#") || @char.string_3.StartsWith("$");
		}

		public int method_2(GClass124 @char)
		{
			int result = 35;
			try
			{
				if (!@char.bool_10)
				{
					result = 35;
					if (@char.gclass60_0.bool_8 && GClass124.smethod_1().int_14 == 2)
						result = GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[6]).int_0 * 5;
				}
				else if (GClass124.smethod_1().int_14 == 2)
				{
					result = GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[6]).int_0 * 5;
				}
			}
			catch
			{
				result = 35;
			}
			return result;
		}

		public int method_3(GClass124 @char)
		{
			int result = 60;
			try
			{
				if (@char.bool_10)
				{
					if (GClass124.smethod_1().int_14 == 2)
						result = GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[3]).int_0 * 10 + 50;
				}
				else
				{
					switch (@char.int_119)
					{
					case 192:
						result = 60;
						break;
					case 195:
						result = 70;
						break;
					case 196:
						result = 80;
						break;
					case 197:
						result = 100;
						break;
					case 198:
						result = 120;
						break;
					case 199:
						result = 90;
						break;
					case 200:
						result = 110;
						break;
					case 193:
					case 194:
						break;
					}
				}
			}
			catch
			{
				result = 121;
			}
			return result;
		}

		public int method_4(GClass124 @char)
		{
			try
			{
				if (!@char.bool_10)
					return 45;
				return GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[7]).int_0 * 5 + 10;
			}
			catch
			{
				return 45;
			}
		}

		public int method_5(GClass124 @char)
		{
			int result = 60;
			try
			{
				if (!@char.bool_10)
				{
					int int_ = @char.gclass6_1.int_26;
					if (int_ > 25)
					{
						if (int_ > 43)
						{
							if (int_ != 49)
							{
								if (int_ == 50)
									result = 270;
							}
							else
								result = 235;
						}
						else if (int_ != 32)
						{
							if (int_ == 43)
								result = 200;
						}
						else
						{
							result = 130;
						}
					}
					else if (int_ != 8)
					{
						if (int_ != 11)
						{
							if (int_ == 25)
								result = 165;
						}
						else
							result = 95;
					}
					else
					{
						result = 60;
					}
				}
				else if (GClass124.smethod_1().int_14 == 1)
				{
					result = (GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[4]).int_0 - 1) * 35 + 60;
				}
			}
			catch
			{
				result = 270;
			}
			return result;
		}

		public int method_6(GClass124 @char)
		{
			int result = 12;
			try
			{
				if (!@char.bool_10)
				{
					result = 12;
					if (@char.gclass60_0.bool_2)
						result = GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[6]).int_0 + 5;
				}
				else if (GClass124.smethod_1().int_14 == 0)
				{
					result = GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[6]).int_0 + 5;
				}
			}
			catch
			{
				result = 12;
			}
			return result;
		}

		public int method_7(GClass124 @char)
		{
			return 5;
		}

		public int method_8(GClass124 @char)
		{
			return 31;
		}

		public int method_9(GClass124 @char)
		{
			return 31;
		}

		public string method_10(GClass124 @char)
		{
			return @char.string_3.Remove(0, @char.string_3.IndexOf(']') + 1).Replace(" ", "");
		}

		public string method_11(GClass124 @char)
		{
			if (@char.int_14 == 0)
				return "TĐ";
			if (@char.int_14 != 1)
			{
				if (@char.int_14 == 2)
					return "XD";
				return "BĐ";
			}
			return "NM";
		}

		public Color method_12(GClass124 @char)
		{
			switch (@char.sbyte_28)
			{
			default:
				return Color.clear;
			case 1:
				return Color.cyan;
			case 2:
				return Color.red;
			case 3:
				return new Color(0.56f, 0.19f, 0.77f);
			case 4:
				return Color.yellow;
			case 5:
				return Color.green;
			case 6:
				return Color.magenta;
			case 7:
				return new Color(1f, 0.5f, 0f);
			case 8:
				return new Color(0.18f, 0.18f, 0.18f);
			case 9:
				return Color.blue;
			case 10:
				return Color.red;
			case 11:
				return Color.blue;
			case 12:
				return Color.white;
			case 13:
				return Color.black;
			}
		}

		public int method_13(GClass124 @char)
		{
			int result = 880;
			if (@char.bool_10 && @char.int_14 == 2)
			{
				GClass95 gClass = GClass124.smethod_1().method_16(GClass124.smethod_1().gclass94_0.gclass205_0[4]);
				if (gClass == null)
					return 0;
				result = 340 * (gClass.int_0 - 1) / 3 + 200;
			}
			return result;
		}
	}
}
