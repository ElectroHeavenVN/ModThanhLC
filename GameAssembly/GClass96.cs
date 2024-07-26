using System;
using AssemblyCSharp.Functions;

public class GClass96 : GClass93, GInterface6
{
	public int int_0 = 100;

	public int int_1;

	public int int_2;

	public string[] string_0;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public GClass79 gclass79_0;

	private bool bool_0;

	public static long long_0;

	public static long long_1;

	private int int_9;

	private string[] string_1;

	public GClass87 gclass87_0;

	public GClass87 gclass87_1;

	public GClass87 gclass87_2;

	public static GClass96 gclass96_0;

	public static GClass96 gclass96_1;

	public static string string_2;

	public static GClass79 gclass79_1;

	public bool bool_1;

	public sbyte sbyte_0;

	public sbyte sbyte_1;

	public static GClass179 gclass179_0;

	public static bool bool_2;

	public int int_10;

	public static int int_11;

	public int int_12;

	public int int_13;

	public int int_14;

	public static int int_15 = 7;

	private int int_16;

	private int int_17;

	private int int_18;

	private GClass70 gclass70_0;

	public int int_19;

	private int int_20;

	public bool bool_3;

	public static int int_21;

	private int int_22;

	private int int_23;

	public static int int_24;

	public static void smethod_0(string strNext, GClass79 next)
	{
		string_2 = strNext;
		gclass79_1 = next;
		if (gclass96_0 == null)
		{
			smethod_2(string_2, 100000, gclass79_1);
			string_2 = null;
			gclass79_1 = null;
		}
	}

	public static void smethod_1(string chat, int howLong, GClass79 c)
	{
	}

	public static void smethod_2(string chat, int howLong, GClass79 c)
	{
		if (chat.ToLower().StartsWith("có lỗi xảy ra"))
			return;
		if (!chat.ToLower().StartsWith("chưa thể chuyển khu vực lúc này vui lòng chờ"))
		{
			if (chat.ToLower().StartsWith((mResources.language != 0) ? "can not move" : "không thể chuyển khu vực"))
				return;
			if (!chat.ToLower().StartsWith((mResources.language == 0) ? "không thể đến khu vực này" : "you can not travel to this area"))
			{
				if (!chat.ToLower().StartsWith("please wait"))
				{
					string[] array = GClass50.smethod_30(chat, "\n", 0);
					gclass96_0 = smethod_4(array[0], howLong, c);
					gclass96_0.int_9 = 0;
					gclass96_0.string_1 = array;
					string caption = mResources.CONTINUE;
					if (array.Length == 1)
						caption = mResources.CLOSE;
					gclass96_0.gclass87_0 = new GClass87(caption, gclass96_0, 8000, null);
					gclass96_0.gclass87_0.int_1 = GClass73.int_10 / 2 - 35;
					gclass96_0.gclass87_0.int_2 = GClass73.int_11 - 35;
					GClass109.smethod_1().method_42();
				}
				else
				{
					int num = int.Parse(chat.Split('.')[2].Split(' ')[0]);
					GClass144.gclass52_0.method_7((GClass151.int_0 == 0) ? $"Chờ {num} giây nữa" : $"Wait {num} second", 0);
				}
			}
			else
				GClass157.smethod_0().int_0 = -1;
		}
		else
		{
			int_24 = int.Parse(chat.Split(' ')[10]);
			if (GClass157.smethod_0().int_0 == -1)
				GClass144.gclass52_0.method_7((GClass151.int_0 != 0) ? $"Wait {int_24} second" : $"Chờ {int_24} giây nữa", 0);
		}
	}

	public static GClass96 smethod_3(string chat, int howLong, GClass79 c, int idIcon)
	{
		int_11 = 10;
		GClass96 gClass = new GClass96();
		gClass.int_0 = GClass73.int_10 - 30 - (GClass73.gclass145_0.bool_0 ? GClass73.gclass145_0.int_1 : 0);
		if (gClass.int_0 > 320)
			gClass.int_0 = 320;
		if (chat.Length < 10)
			gClass.int_0 = 64;
		if (GClass73.int_10 == 128)
			gClass.int_0 = 128;
		gClass.string_0 = GClass4.gclass4_17.method_15(chat, gClass.int_0 - 10);
		gClass.int_1 = howLong;
		gClass.gclass79_0 = c;
		gClass.int_20 = idIcon;
		GClass78.gclass96_0 = gClass;
		gClass.int_5 = 15 - gClass.int_2 + gClass.string_0.Length * 12 + 10;
		if (gClass.int_5 > GClass73.int_11 - 80)
			gClass.int_5 = GClass73.int_11 - 80;
		gClass.int_10 = 10;
		if (GClass73.gclass145_0.bool_0)
			gClass.int_10 = 0;
		GClass93.gclass88_1.method_0(gClass);
		bool_2 = false;
		if (c != null && c.int_13 == 5)
		{
			bool_2 = true;
			GClass144.gclass52_0.method_7("", 1);
		}
		long_0 = (long_1 = GClass203.smethod_18());
		gClass.int_5 += 15;
		return gClass;
	}

	public static GClass96 smethod_4(string chat, int howLong, GClass79 c)
	{
		int_11 = 10;
		GClass96 gClass = new GClass96();
		gClass.int_0 = GClass73.int_10 - 30 - (GClass73.gclass145_0.bool_0 ? GClass73.gclass145_0.int_1 : 0);
		if (gClass.int_0 > 320)
			gClass.int_0 = 320;
		if (chat.Length < 10)
			gClass.int_0 = 64;
		if (GClass73.int_10 == 128)
			gClass.int_0 = 128;
		gClass.string_0 = GClass4.gclass4_17.method_15(chat, gClass.int_0 - 10);
		gClass.int_1 = howLong;
		gClass.gclass79_0 = c;
		GClass78.gclass96_0 = gClass;
		gClass.int_5 = 15 - gClass.int_2 + gClass.string_0.Length * 12 + 10;
		if (gClass.int_5 > GClass73.int_11 - 80)
			gClass.int_5 = GClass73.int_11 - 80;
		gClass.int_10 = 10;
		if (GClass73.gclass145_0.bool_0)
			gClass.int_10 = 0;
		GClass93.gclass88_1.method_0(gClass);
		bool_2 = false;
		if (c != null && c.int_13 == 5)
		{
			bool_2 = true;
			GClass144.gclass52_0.method_7("", 1);
		}
		long_0 = (long_1 = GClass203.smethod_18());
		return gClass;
	}

	public override void update()
	{
		if (gclass179_0 != null)
		{
			GClass144.gclass52_0.bool_1 = false;
			gclass179_0.method_5();
		}
		else
			GClass144.gclass52_0.bool_1 = true;
		if (GClass73.gclass145_0.bool_0)
		{
			int_19 = 0;
			int_3 = GClass73.int_10 / 2 - int_0 / 2 - 1;
			int_4 = GClass73.gclass145_0.int_2 - int_5;
		}
		else
		{
			int_19 = 0;
			if (GClass144.smethod_8().gclass87_2 != null || GClass144.smethod_8().gclass87_0 != null || GClass144.smethod_8().gclass87_1 != null || gclass87_0 != null || gclass87_1 != null)
			{
				int_19 = 5;
				int_3 = GClass73.int_10 / 2 - int_0 / 2 - 1;
				int_4 = GClass73.int_11 - 20 - int_5;
			}
			else
			{
				int_3 = GClass73.int_10 / 2 - int_0 / 2 - 1;
				int_4 = GClass73.int_11 - 5 - int_5;
			}
		}
		if (int_1 > 0)
			int_1--;
		if (int_11 > 0)
			int_11--;
		else
		{
			GClass144.gclass52_0.gclass92_0.int_16 = 0;
			for (int i = 0; i < GClass144.gclass52_0.gclass92_0.gclass88_0.method_2(); i++)
			{
				if (((GClass16)GClass144.gclass52_0.gclass92_0.gclass88_0.method_3(i)).int_0 != 70)
					((GClass16)GClass144.gclass52_0.gclass92_0.gclass88_0.method_3(i)).int_0 = 10;
			}
		}
		if (int_2 > 1)
			int_2--;
		if ((gclass79_0 != null && GClass78.gclass96_0 != null && GClass78.gclass96_0 != this) || (gclass79_0 != null && GClass78.gclass96_0 == null) || int_1 <= 0)
		{
			GClass93.gclass88_3.method_8(this);
			GClass93.gclass88_1.method_8(this);
		}
	}

	public override void paint(GClass122 g)
	{
		if (GClass144.smethod_8().bool_66 && GClass144.smethod_8().bool_62)
			return;
		GClass73.smethod_6(g);
		int num = int_3;
		int num2 = int_4;
		int num3 = int_0 + 2;
		int num4 = int_5;
		if ((num <= 0 || num2 <= 0) && !GClass73.gclass76_0.bool_0)
			return;
		GClass45.smethod_4(g, num, num2, num3, num4, 16777215, false);
		int num5 = 0;
		if (gclass79_0 != null)
		{
			int num6 = ((GClass73.int_8 % 10 <= 2) ? 1 : 0);
			GClass28.smethod_6(g, gclass79_0.int_70, int_3 + 14, int_4 + num6, 0, GClass188.int_4);
		}
		if (int_20 != 0)
		{
			int num7 = ((GClass73.int_8 % 10 <= 2) ? 1 : 0);
			GClass28.smethod_6(g, int_20, int_3 + num3 / 2, int_4 + int_5 - 15 + num7, 0, GClass188.int_6);
		}
		if (gclass179_0 != null)
		{
			g.method_5(num, num2, num3, num4 - 16);
			g.method_1(0, -gclass179_0.int_3);
		}
		int tx = 0;
		int ty = 0;
		if (bool_3)
		{
			tx = g.method_3();
			ty = g.method_4();
			g.method_5(num, num2 + 1, num3, num4 - 17);
			g.method_1(0, -int_21);
		}
		int num8 = -1;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i].StartsWith("--"))
			{
				g.method_16(0);
				g.method_15(num + 10, int_4 + int_2 + i * 12 + 6, num3 - 20, 1);
				continue;
			}
			GClass4 gClass = GClass4.gclass4_11;
			int num9 = 2;
			string st = string_0[i];
			int num10 = 0;
			if (!string_0[i].StartsWith("|"))
				num10 = num8;
			else
			{
				string[] array = GClass50.smethod_30(string_0[i], "|", 0);
				if (array.Length == 3)
					st = array[2];
				if (array.Length == 4)
				{
					st = array[3];
					num9 = int.Parse(array[2]);
				}
				num10 = int.Parse(array[1]);
				num8 = num10;
			}
			switch (num10)
			{
			case -1:
				gClass = GClass4.gclass4_11;
				break;
			case 0:
				gClass = GClass4.gclass4_6;
				break;
			case 1:
				gClass = GClass4.gclass4_8;
				break;
			case 2:
				gClass = GClass4.gclass4_2;
				break;
			case 3:
				gClass = GClass4.gclass4_17;
				break;
			case 4:
				gClass = GClass4.gclass4_19;
				break;
			case 5:
				gClass = GClass4.gclass4_18;
				break;
			case 7:
				gClass = GClass4.gclass4_1;
				break;
			case 8:
				gClass = GClass4.gclass4_4;
				break;
			}
			if (string_0[i].StartsWith("<"))
			{
				string[] array2 = GClass50.smethod_30(GClass50.smethod_30(string_0[i], "<", 0)[1], ">", 1);
				if (int_14 == 0)
					int_14 = int.Parse(array2[1]);
				else
				{
					long_0 = GClass203.smethod_18();
					if (long_0 - long_1 >= 1000L)
					{
						long_1 = long_0;
						int_14--;
					}
				}
				gClass.method_6(g, int_14 + " " + array2[2], int_3 + int_0 / 2, int_4 + int_2 + i * 12 - int_19 + 12, num9);
			}
			else
			{
				if (num9 == 2)
					gClass.method_6(g, st, int_3 + int_0 / 2, int_4 + int_2 + i * 12 - int_19 + 12, num9);
				if (num9 == 1)
					gClass.method_6(g, st, int_3 + int_0 - 5, int_4 + int_2 + i * 12 - int_19 + 12, num9);
			}
		}
		if (bool_3)
		{
			GClass73.smethod_6(g);
			g.method_1(tx, ty);
		}
		if (sbyte_1 > 4)
		{
			if (sbyte_1 <= 7)
			{
				if (sbyte_1 > 0)
				{
					for (int j = 0; j < sbyte_1; j++)
					{
						g.method_31(GClass76.gclass70_4, num + num3 / 2 - sbyte_1 * 20 / 2 + j * 20 + GClass122.smethod_0(GClass76.gclass70_3), num2 + num4 - 13, 3);
					}
				}
				if (sbyte_0 > 0)
				{
					for (int k = 0; k < sbyte_0; k++)
					{
						g.method_31(GClass76.gclass70_3, num + num3 / 2 - sbyte_1 * 20 / 2 + k * 20 + GClass122.smethod_0(GClass76.gclass70_3), num2 + num4 - 13, 3);
					}
				}
			}
			else
			{
				int_17 = (sbyte_1 + 1) / 2;
				int_16 = sbyte_1 - int_17;
				for (int l = 0; l < int_17; l++)
				{
					g.method_31(GClass76.gclass70_4, num + num3 / 2 - int_17 * 20 / 2 + l * 20 + GClass122.smethod_0(GClass76.gclass70_4), num2 + num4 - 17, 3);
				}
				for (int m = 0; m < int_16; m++)
				{
					g.method_31(GClass76.gclass70_4, num + num3 / 2 - int_16 * 20 / 2 + m * 20 + GClass122.smethod_0(GClass76.gclass70_4), num2 + num4 - 8, 3);
				}
				if (sbyte_0 > 0)
				{
					gclass70_0 = GClass76.gclass70_3;
					if (sbyte_0 < int_17)
					{
						for (int n = 0; n < sbyte_0; n++)
						{
							g.method_31(gclass70_0, num + num3 / 2 - int_17 * 20 / 2 + n * 20 + GClass122.smethod_0(gclass70_0), num2 + num4 - 17, 3);
						}
					}
					else
					{
						int_18 = sbyte_0 - int_17;
						for (int num11 = 0; num11 < int_17; num11++)
						{
							g.method_31(gclass70_0, num + num3 / 2 - int_17 * 20 / 2 + num11 * 20 + GClass122.smethod_0(gclass70_0), num2 + num4 - 17, 3);
						}
						for (int num12 = 0; num12 < int_18; num12++)
						{
							if (num12 + int_17 >= int_15)
								gclass70_0 = GClass76.gclass70_5;
							g.method_31(gclass70_0, num + num3 / 2 - int_16 * 20 / 2 + num12 * 20 + GClass122.smethod_0(gclass70_0), num2 + num4 - 8, 3);
						}
					}
				}
			}
		}
		else
		{
			for (int num13 = 0; num13 < sbyte_1; num13++)
			{
				g.method_31(GClass76.gclass70_4, num + num3 / 2 - sbyte_1 * 20 / 2 + num13 * 20 + GClass122.smethod_0(GClass76.gclass70_4), num2 + num4 - 13, 3);
			}
			if (sbyte_0 > 0)
			{
				for (int num14 = 0; num14 < sbyte_0; num14++)
				{
					g.method_31(GClass76.gclass70_3, num + num3 / 2 - sbyte_1 * 20 / 2 + num14 * 20 + GClass122.smethod_0(GClass76.gclass70_3), num2 + num4 - 13, 3);
				}
			}
		}
		method_3(g);
	}

	public void method_0(GClass122 g, int cmyText)
	{
		int num = int_3;
		int num2 = int_4;
		int num3 = int_0;
		int num4 = 0;
		int num5 = 0;
		num4 = g.method_3();
		num5 = g.method_4();
		g.method_1(0, -cmyText);
		if ((num <= 0 || num2 <= 0) && !GClass73.gclass76_0.bool_0)
			return;
		int num6 = -1;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i].StartsWith("--"))
			{
				g.method_16(16777215);
				g.method_15(num + 10, int_4 + int_2 + i * 12 - 6, num3 - 20, 1);
				continue;
			}
			GClass4 gClass = GClass4.gclass4_20;
			int num7 = 2;
			string st = string_0[i];
			int num8 = 0;
			if (!string_0[i].StartsWith("|"))
				num8 = num6;
			else
			{
				string[] array = GClass50.smethod_30(string_0[i], "|", 0);
				if (array.Length == 3)
					st = array[2];
				if (array.Length == 4)
				{
					st = array[3];
					num7 = int.Parse(array[2]);
				}
				num8 = int.Parse(array[1]);
				num6 = num8;
			}
			switch (num8)
			{
			case -1:
				gClass = GClass4.gclass4_20;
				break;
			case 0:
				gClass = GClass4.gclass4_3;
				break;
			case 1:
				gClass = GClass4.gclass4_8;
				break;
			case 2:
				gClass = GClass4.gclass4_1;
				break;
			}
			if (!string_0[i].StartsWith("<"))
			{
				if (num7 == 2)
					gClass.method_6(g, st, int_3 + int_0 / 2, int_4 + int_2 + i * 12 - int_19, num7);
				if (num7 == 1)
					gClass.method_6(g, st, int_3 + int_0 - 5, int_4 + int_2 + i * 12 - int_19, num7);
				continue;
			}
			string[] array2 = GClass50.smethod_30(GClass50.smethod_30(string_0[i], "<", 0)[1], ">", 1);
			if (int_14 == 0)
				int_14 = int.Parse(array2[1]);
			else
			{
				long_0 = GClass203.smethod_18();
				if (long_0 - long_1 >= 1000L)
				{
					long_1 = long_0;
					int_14--;
				}
			}
			gClass.method_6(g, int_14 + " " + array2[2], int_3 + int_0 / 2, int_4 + int_2 + i * 12 - int_19, num7);
		}
		GClass73.smethod_6(g);
		g.method_1(num4, num5);
	}

	private void method_1(int int_25)
	{
		int_21 += 12 * int_25;
		if (int_21 < 0)
			int_21 = 0;
		if (int_21 > int_8)
			int_21 = int_8;
	}

	public void method_2()
	{
		if (bool_3)
		{
			if (GClass73.bool_11[(!Main.isPC) ? 8 : 22])
			{
				GClass73.bool_11[Main.isPC ? 22 : 8] = false;
				method_1(1);
			}
			if (GClass73.bool_11[(!Main.isPC) ? 2 : 21])
			{
				GClass73.bool_11[Main.isPC ? 21 : 2] = false;
				method_1(-1);
			}
			if (GClass73.smethod_24(int_3, 0, int_0 + 2, int_5))
			{
				if (GClass73.bool_17)
				{
					if (int_23 == 0)
						int_23 = GClass73.int_1;
					int_22 = int_23 - GClass73.int_1;
					if (int_22 != 0)
					{
						int_21 += int_22;
						int_23 = GClass73.int_1;
					}
					if (int_21 < 0)
						int_21 = 0;
					if (int_21 > int_8)
						int_21 = int_8;
				}
				else
				{
					int_23 = 0;
					int_23 = 0;
				}
			}
		}
		if (gclass179_0 != null)
		{
			if (GClass73.bool_5)
				gclass179_0.method_1();
			if (GClass73.bool_13[(!Main.isPC) ? 2 : 21])
			{
				gclass179_0.int_1 -= 12;
				if (gclass179_0.int_1 < 0)
					gclass179_0.int_1 = 0;
			}
			if (GClass73.bool_13[(!Main.isPC) ? 8 : 22])
			{
				GClass73.bool_11[(!Main.isPC) ? 8 : 22] = false;
				gclass179_0.int_1 += 12;
				if (gclass179_0.int_1 > gclass179_0.int_13)
					gclass179_0.int_1 = gclass179_0.int_13;
			}
		}
		if (GClass73.bool_11[(!Main.isPC) ? 5 : 25] || GClass131.smethod_1(GClass73.gclass131_0.gclass87_1))
		{
			GClass73.bool_11[(!Main.isPC) ? 5 : 25] = false;
			GClass131.int_4 = -1;
			if (gclass87_0 == null)
			{
				if (gclass87_1 == null)
				{
					if (gclass87_2 != null)
						gclass87_2.method_1();
				}
				else
					gclass87_1.method_1();
			}
			else
				gclass87_0.method_1();
		}
		if (gclass179_0 == null || !gclass179_0.bool_0)
		{
			if (gclass87_1 != null && (GClass73.bool_11[12] || GClass73.bool_11[Main.isPC ? 25 : 5] || GClass131.smethod_1(gclass87_1)))
			{
				GClass73.bool_11[12] = false;
				GClass73.bool_11[Main.isPC ? 25 : 5] = false;
				GClass73.bool_15 = false;
				GClass73.bool_16 = false;
				gclass87_1.method_1();
				GClass131.int_4 = -1;
			}
			if (gclass87_2 != null && (GClass73.bool_11[13] || GClass131.smethod_1(gclass87_2)))
			{
				GClass73.bool_11[13] = false;
				GClass73.bool_15 = false;
				GClass73.bool_16 = false;
				gclass87_2.method_1();
				GClass131.int_4 = -1;
			}
		}
	}

	public void method_3(GClass122 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass73.int_10, GClass73.int_11);
		GClass73.gclass192_0.method_8(g);
		if (gclass87_0 != null)
			GClass73.gclass192_0.method_7(g, null, gclass87_0, null);
		if (gclass87_1 != null)
			GClass73.gclass192_0.method_7(g, gclass87_1, null, gclass87_2);
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
		{
			try
			{
				GClass187.gclass187_0.method_3((string)p);
			}
			catch (Exception)
			{
			}
			if (!Main.isPC)
				GClass187.gclass187_0.method_2();
			else
				idAction = 1001;
			GClass73.smethod_29();
		}
		if (idAction == 1001)
		{
			gclass179_0 = null;
			GClass78.gclass96_0 = null;
			gclass96_1 = null;
			GClass144.gclass52_0.bool_1 = true;
			GClass78.bool_34 = false;
			if (bool_2)
			{
				GClass144.gclass52_0.gclass92_0.int_16 = 0;
				GClass144.gclass52_0.gclass92_0.gclass16_0.int_0 = 10;
			}
		}
		if (idAction != 8000 || int_11 > 0)
			return;
		int num = gclass96_0.int_9 + 1;
		if (num >= gclass96_0.string_1.Length)
		{
			GClass78.gclass96_0 = null;
			gclass96_0 = null;
			GClass144.gclass52_0.bool_1 = true;
			GClass78.bool_34 = false;
			if (string_2 != null)
			{
				num = 0;
				smethod_2(string_2, 100000, gclass79_1);
				string_2 = null;
				gclass79_1 = null;
			}
			else
			{
				if (!bool_2)
					return;
				GClass144.gclass52_0.gclass92_0.int_16 = 0;
				for (int i = 0; i < GClass144.gclass52_0.gclass92_0.gclass88_0.method_2(); i++)
				{
					if (((GClass16)GClass144.gclass52_0.gclass92_0.gclass88_0.method_3(i)).int_0 == 10000000)
						((GClass16)GClass144.gclass52_0.gclass92_0.gclass88_0.method_3(i)).int_0 = 10;
				}
			}
		}
		else
		{
			GClass96 gClass = smethod_4(gclass96_0.string_1[num], gclass96_0.int_1, gclass96_0.gclass79_0);
			gClass.int_9 = num;
			gClass.string_1 = gclass96_0.string_1;
			gClass.gclass87_0 = gclass96_0.gclass87_0;
			gclass96_0 = gClass;
		}
	}
}
