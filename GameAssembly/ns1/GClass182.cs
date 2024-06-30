using System.Reflection;
using UnityEngine;

namespace ns1
{
	public class GClass182
	{
		private static GClass182 gclass182_0;

		public static GClass182 smethod_0()
		{
			if (gclass182_0 == null)
				gclass182_0 = new GClass182();
			return gclass182_0;
		}

		public bool method_0(GClass58 @char)
		{
			bool flag = (bool)typeof(GClass58).GetField("isPet", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(@char);
			bool flag2 = (bool)typeof(GClass58).GetField("isMiniPet", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(@char);
			return !flag && !flag2 && @char.string_3 != "Trọng tài" && char.IsUpper(method_10(@char)[0]) && @char.string_3 != "Arbitration";
		}

		public bool method_1(GClass58 @char)
		{
			return ((bool)typeof(GClass58).GetField("isPet", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(@char) | (bool)typeof(GClass58).GetField("isMiniPet", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(@char)) || @char.string_3.StartsWith("#") || @char.string_3.StartsWith("$");
		}

		public int method_2(GClass58 @char)
		{
			int result = 35;
			try
			{
				if (!@char.bool_10)
				{
					result = 35;
					if (@char.gclass176_0.bool_8 && GClass58.smethod_1().int_14 == 2)
						result = GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[6]).int_0 * 5;
				}
				else if (GClass58.smethod_1().int_14 == 2)
				{
					result = GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[6]).int_0 * 5;
				}
			}
			catch
			{
				result = 35;
			}
			return result;
		}

		public int method_3(GClass58 @char)
		{
			int result = 60;
			try
			{
				if (!@char.bool_10)
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
				else if (GClass58.smethod_1().int_14 == 2)
				{
					result = GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[3]).int_0 * 10 + 50;
				}
			}
			catch
			{
				result = 121;
			}
			return result;
		}

		public int method_4(GClass58 @char)
		{
			try
			{
				if (!@char.bool_10)
					return 45;
				return GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[7]).int_0 * 5 + 10;
			}
			catch
			{
				return 45;
			}
		}

		public int method_5(GClass58 @char)
		{
			int result = 60;
			try
			{
				if (!@char.bool_10)
				{
					int int_ = @char.gclass85_1.int_26;
					if (int_ <= 25)
					{
						if (int_ != 8)
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
							result = 60;
					}
					else if (int_ <= 43)
					{
						if (int_ != 32)
						{
							if (int_ == 43)
								result = 200;
						}
						else
							result = 130;
					}
					else if (int_ != 49)
					{
						if (int_ == 50)
							result = 270;
					}
					else
					{
						result = 235;
					}
				}
				else if (GClass58.smethod_1().int_14 == 1)
				{
					result = (GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[4]).int_0 - 1) * 35 + 60;
				}
			}
			catch
			{
				result = 270;
			}
			return result;
		}

		public int method_6(GClass58 @char)
		{
			int result = 12;
			try
			{
				if (!@char.bool_10)
				{
					result = 12;
					if (@char.gclass176_0.bool_2)
						result = GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[6]).int_0 + 5;
				}
				else if (GClass58.smethod_1().int_14 == 0)
				{
					result = GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[6]).int_0 + 5;
				}
			}
			catch
			{
				result = 12;
			}
			return result;
		}

		public int method_7(GClass58 @char)
		{
			return 5;
		}

		public int method_8(GClass58 @char)
		{
			return 31;
		}

		public int method_9(GClass58 @char)
		{
			return 31;
		}

		public string method_10(GClass58 @char)
		{
			return @char.string_3.Remove(0, @char.string_3.IndexOf(']') + 1).Replace(" ", "");
		}

		public string method_11(GClass58 @char)
		{
			if (@char.int_14 == 0)
				return "TĐ";
			if (@char.int_14 == 1)
				return "NM";
			if (@char.int_14 == 2)
				return "XD";
			return "BĐ";
		}

		public Color method_12(GClass58 @char)
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

		public int method_13(GClass58 @char)
		{
			int result = 880;
			if (@char.bool_10 && @char.int_14 == 2)
			{
				GClass74 gClass = GClass58.smethod_1().method_15(GClass58.smethod_1().gclass109_0.gclass53_0[4]);
				if (gClass == null)
					return 0;
				result = 340 * (gClass.int_0 - 1) / 3 + 200;
			}
			return result;
		}
	}
}
