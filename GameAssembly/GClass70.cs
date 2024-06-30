using System;
using ns1;

public class GClass70 : GClass68, GInterface0
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

	public GClass59 gclass59_0;

	private bool bool_0;

	public static long long_0;

	public static long long_1;

	private int int_9;

	private string[] string_1;

	public GClass14 gclass14_0;

	public GClass14 gclass14_1;

	public GClass14 gclass14_2;

	public static GClass70 gclass70_0;

	public static GClass70 gclass70_1;

	public static string string_2;

	public static GClass59 gclass59_1;

	public bool bool_1;

	public sbyte sbyte_0;

	public sbyte sbyte_1;

	public static GClass105 gclass105_0;

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

	private GClass2 gclass2_0;

	public int int_19;

	private int int_20;

	public bool bool_3;

	public static int int_21;

	private int int_22;

	private int int_23;

	public static void smethod_0(string strNext, GClass59 next)
	{
		string_2 = strNext;
		gclass59_1 = next;
		if (gclass70_0 == null)
		{
			smethod_2(string_2, 100000, gclass59_1);
			string_2 = null;
			gclass59_1 = null;
		}
	}

	public static void smethod_1(string chat, int howLong, GClass59 c)
	{
	}

	public static void smethod_2(string chat, int howLong, GClass59 c)
	{
		if (chat.ToLower().StartsWith("có lỗi xảy ra"))
			return;
		if (chat.ToLower().StartsWith("chưa thể chuyển khu vực lúc này vui lòng chờ"))
		{
			int num = int.Parse(chat.Split(' ')[10]);
			GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? $"Chờ {num} giây nữa" : $"Wait {num} second", 0);
		}
		else
		{
			if (chat.ToLower().StartsWith((mResources.language == 0) ? "không thể chuyển khu vực" : "can not move"))
				return;
			if (chat.ToLower().StartsWith((mResources.language == 0) ? "không thể đến khu vực này" : "you can not travel to this area"))
			{
				GClass175.smethod_0().int_0 = -1;
				return;
			}
			if (chat.ToLower().StartsWith("please wait"))
			{
				int num2 = int.Parse(chat.Split('.')[2].Split(' ')[0]);
				GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? $"Chờ {num2} giây nữa" : $"Wait {num2} second", 0);
				return;
			}
			string[] array = GClass56.smethod_30(chat, "\n", 0);
			gclass70_0 = smethod_4(array[0], howLong, c);
			gclass70_0.int_9 = 0;
			gclass70_0.string_1 = array;
			string caption = mResources.CONTINUE;
			if (array.Length == 1)
				caption = mResources.CLOSE;
			gclass70_0.gclass14_0 = new GClass14(caption, gclass70_0, 8000, null);
			gclass70_0.gclass14_0.int_1 = GClass39.int_10 / 2 - 35;
			gclass70_0.gclass14_0.int_2 = GClass39.int_11 - 35;
			GClass29.smethod_1().method_42();
		}
	}

	public static GClass70 smethod_3(string chat, int howLong, GClass59 c, int idIcon)
	{
		int_11 = 10;
		GClass70 gClass = new GClass70();
		gClass.int_0 = GClass39.int_10 - 30 - (GClass39.gclass0_0.bool_0 ? GClass39.gclass0_0.int_1 : 0);
		if (gClass.int_0 > 320)
			gClass.int_0 = 320;
		if (chat.Length < 10)
			gClass.int_0 = 64;
		if (GClass39.int_10 == 128)
			gClass.int_0 = 128;
		gClass.string_0 = GClass49.gclass49_17.method_15(chat, gClass.int_0 - 10);
		gClass.int_1 = howLong;
		gClass.gclass59_0 = c;
		gClass.int_20 = idIcon;
		GClass58.gclass70_0 = gClass;
		gClass.int_5 = 15 - gClass.int_2 + gClass.string_0.Length * 12 + 10;
		if (gClass.int_5 > GClass39.int_11 - 80)
			gClass.int_5 = GClass39.int_11 - 80;
		gClass.int_10 = 10;
		if (GClass39.gclass0_0.bool_0)
			gClass.int_10 = 0;
		GClass68.gclass63_1.method_0(gClass);
		bool_2 = false;
		if (c != null && c.int_13 == 5)
		{
			bool_2 = true;
			GClass154.gclass210_0.method_7(string.Empty, 1);
		}
		long_0 = (long_1 = GClass138.smethod_18());
		gClass.int_5 += 15;
		return gClass;
	}

	public static GClass70 smethod_4(string chat, int howLong, GClass59 c)
	{
		int_11 = 10;
		GClass70 gClass = new GClass70();
		gClass.int_0 = GClass39.int_10 - 30 - (GClass39.gclass0_0.bool_0 ? GClass39.gclass0_0.int_1 : 0);
		if (gClass.int_0 > 320)
			gClass.int_0 = 320;
		if (chat.Length < 10)
			gClass.int_0 = 64;
		if (GClass39.int_10 == 128)
			gClass.int_0 = 128;
		gClass.string_0 = GClass49.gclass49_17.method_15(chat, gClass.int_0 - 10);
		gClass.int_1 = howLong;
		gClass.gclass59_0 = c;
		GClass58.gclass70_0 = gClass;
		gClass.int_5 = 15 - gClass.int_2 + gClass.string_0.Length * 12 + 10;
		if (gClass.int_5 > GClass39.int_11 - 80)
			gClass.int_5 = GClass39.int_11 - 80;
		gClass.int_10 = 10;
		if (GClass39.gclass0_0.bool_0)
			gClass.int_10 = 0;
		GClass68.gclass63_1.method_0(gClass);
		bool_2 = false;
		if (c != null && c.int_13 == 5)
		{
			bool_2 = true;
			GClass154.gclass210_0.method_7(string.Empty, 1);
		}
		long_0 = (long_1 = GClass138.smethod_18());
		return gClass;
	}

	public override void update()
	{
		if (gclass105_0 != null)
		{
			GClass154.gclass210_0.bool_1 = false;
			gclass105_0.method_5();
		}
		else
			GClass154.gclass210_0.bool_1 = true;
		if (GClass39.gclass0_0.bool_0)
		{
			int_19 = 0;
			int_3 = GClass39.int_10 / 2 - int_0 / 2 - 1;
			int_4 = GClass39.gclass0_0.int_2 - int_5;
		}
		else
		{
			int_19 = 0;
			if (GClass154.smethod_8().gclass14_2 != null || GClass154.smethod_8().gclass14_0 != null || GClass154.smethod_8().gclass14_1 != null || gclass14_0 != null || gclass14_1 != null)
			{
				int_19 = 5;
				int_3 = GClass39.int_10 / 2 - int_0 / 2 - 1;
				int_4 = GClass39.int_11 - 20 - int_5;
			}
			else
			{
				int_3 = GClass39.int_10 / 2 - int_0 / 2 - 1;
				int_4 = GClass39.int_11 - 5 - int_5;
			}
		}
		if (int_1 > 0)
			int_1--;
		if (int_11 > 0)
			int_11--;
		else
		{
			GClass154.gclass210_0.gclass205_0.int_16 = 0;
			for (int i = 0; i < GClass154.gclass210_0.gclass205_0.gclass63_0.method_2(); i++)
			{
				if (((GClass43)GClass154.gclass210_0.gclass205_0.gclass63_0.method_3(i)).int_0 != 70)
					((GClass43)GClass154.gclass210_0.gclass205_0.gclass63_0.method_3(i)).int_0 = 10;
			}
		}
		if (int_2 > 1)
			int_2--;
		if ((gclass59_0 != null && GClass58.gclass70_0 != null && GClass58.gclass70_0 != this) || (gclass59_0 != null && GClass58.gclass70_0 == null) || int_1 <= 0)
		{
			GClass68.gclass63_3.method_8(this);
			GClass68.gclass63_1.method_8(this);
		}
	}

	public override void paint(GClass76 g)
	{
		if (GClass154.smethod_8().bool_65 && GClass154.smethod_8().bool_61)
			return;
		GClass39.smethod_6(g);
		int num = int_3;
		int num2 = int_4;
		int num3 = int_0 + 2;
		int num4 = int_5;
		if ((num <= 0 || num2 <= 0) && !GClass39.gclass45_0.bool_0)
			return;
		GClass24.smethod_4(g, num, num2, num3, num4, 16777215, false);
		int num5 = 0;
		if (gclass59_0 != null)
		{
			int num6 = ((GClass39.int_8 % 10 <= 2) ? 1 : 0);
			GClass96.smethod_6(g, gclass59_0.int_70, int_3 + 14, int_4 + num6, 0, GClass169.int_4);
		}
		if (int_20 != 0)
		{
			int num7 = ((GClass39.int_8 % 10 <= 2) ? 1 : 0);
			GClass96.smethod_6(g, int_20, int_3 + num3 / 2, int_4 + int_5 - 15 + num7, 0, GClass169.int_6);
		}
		if (gclass105_0 != null)
		{
			g.method_5(num, num2, num3, num4 - 16);
			g.method_1(0, -gclass105_0.int_3);
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
			GClass49 gClass = GClass49.gclass49_11;
			int num9 = 2;
			string st = string_0[i];
			int num10 = 0;
			if (string_0[i].StartsWith("|"))
			{
				string[] array = GClass56.smethod_30(string_0[i], "|", 0);
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
			else
				num10 = num8;
			switch (num10)
			{
			case -1:
				gClass = GClass49.gclass49_11;
				break;
			case 0:
				gClass = GClass49.gclass49_6;
				break;
			case 1:
				gClass = GClass49.gclass49_8;
				break;
			case 2:
				gClass = GClass49.gclass49_2;
				break;
			case 3:
				gClass = GClass49.gclass49_17;
				break;
			case 4:
				gClass = GClass49.gclass49_19;
				break;
			case 5:
				gClass = GClass49.gclass49_18;
				break;
			case 7:
				gClass = GClass49.gclass49_1;
				break;
			case 8:
				gClass = GClass49.gclass49_4;
				break;
			}
			if (string_0[i].StartsWith("<"))
			{
				string[] array2 = GClass56.smethod_30(GClass56.smethod_30(string_0[i], "<", 0)[1], ">", 1);
				if (int_14 == 0)
					int_14 = int.Parse(array2[1]);
				else
				{
					long_0 = GClass138.smethod_18();
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
			GClass39.smethod_6(g);
			g.method_1(tx, ty);
		}
		if (sbyte_1 > 4)
		{
			int_17 = (sbyte_1 + 1) / 2;
			int_16 = sbyte_1 - int_17;
			for (int j = 0; j < int_17; j++)
			{
				g.method_31(GClass45.gclass2_4, num + num3 / 2 - int_17 * 20 / 2 + j * 20 + GClass76.smethod_0(GClass45.gclass2_4), num2 + num4 - 17, 3);
			}
			for (int k = 0; k < int_16; k++)
			{
				g.method_31(GClass45.gclass2_4, num + num3 / 2 - int_16 * 20 / 2 + k * 20 + GClass76.smethod_0(GClass45.gclass2_4), num2 + num4 - 8, 3);
			}
			if (sbyte_0 > 0)
			{
				gclass2_0 = GClass45.gclass2_3;
				if (sbyte_0 >= int_17)
				{
					int_18 = sbyte_0 - int_17;
					for (int l = 0; l < int_17; l++)
					{
						g.method_31(gclass2_0, num + num3 / 2 - int_17 * 20 / 2 + l * 20 + GClass76.smethod_0(gclass2_0), num2 + num4 - 17, 3);
					}
					for (int m = 0; m < int_18; m++)
					{
						if (m + int_17 >= int_15)
							gclass2_0 = GClass45.gclass2_5;
						g.method_31(gclass2_0, num + num3 / 2 - int_16 * 20 / 2 + m * 20 + GClass76.smethod_0(gclass2_0), num2 + num4 - 8, 3);
					}
				}
				else
				{
					for (int n = 0; n < sbyte_0; n++)
					{
						g.method_31(gclass2_0, num + num3 / 2 - int_17 * 20 / 2 + n * 20 + GClass76.smethod_0(gclass2_0), num2 + num4 - 17, 3);
					}
				}
			}
		}
		else
		{
			for (int num11 = 0; num11 < sbyte_1; num11++)
			{
				g.method_31(GClass45.gclass2_4, num + num3 / 2 - sbyte_1 * 20 / 2 + num11 * 20 + GClass76.smethod_0(GClass45.gclass2_4), num2 + num4 - 13, 3);
			}
			if (sbyte_0 > 0)
			{
				for (int num12 = 0; num12 < sbyte_0; num12++)
				{
					g.method_31(GClass45.gclass2_3, num + num3 / 2 - sbyte_1 * 20 / 2 + num12 * 20 + GClass76.smethod_0(GClass45.gclass2_3), num2 + num4 - 13, 3);
				}
			}
		}
		method_3(g);
	}

	public void method_0(GClass76 g, int cmyText)
	{
		int num = int_3;
		int num2 = int_4;
		int num3 = int_0;
		int num4 = 0;
		int num5 = 0;
		num4 = g.method_3();
		num5 = g.method_4();
		g.method_1(0, -cmyText);
		if ((num <= 0 || num2 <= 0) && !GClass39.gclass45_0.bool_0)
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
			GClass49 gClass = GClass49.gclass49_20;
			int num7 = 2;
			string st = string_0[i];
			int num8 = 0;
			if (string_0[i].StartsWith("|"))
			{
				string[] array = GClass56.smethod_30(string_0[i], "|", 0);
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
			else
				num8 = num6;
			switch (num8)
			{
			case -1:
				gClass = GClass49.gclass49_20;
				break;
			case 0:
				gClass = GClass49.gclass49_3;
				break;
			case 1:
				gClass = GClass49.gclass49_8;
				break;
			case 2:
				gClass = GClass49.gclass49_1;
				break;
			}
			if (string_0[i].StartsWith("<"))
			{
				string[] array2 = GClass56.smethod_30(GClass56.smethod_30(string_0[i], "<", 0)[1], ">", 1);
				if (int_14 == 0)
					int_14 = int.Parse(array2[1]);
				else
				{
					long_0 = GClass138.smethod_18();
					if (long_0 - long_1 >= 1000L)
					{
						long_1 = long_0;
						int_14--;
					}
				}
				gClass.method_6(g, int_14 + " " + array2[2], int_3 + int_0 / 2, int_4 + int_2 + i * 12 - int_19, num7);
			}
			else
			{
				if (num7 == 2)
					gClass.method_6(g, st, int_3 + int_0 / 2, int_4 + int_2 + i * 12 - int_19, num7);
				if (num7 == 1)
					gClass.method_6(g, st, int_3 + int_0 - 5, int_4 + int_2 + i * 12 - int_19, num7);
			}
		}
		GClass39.smethod_6(g);
		g.method_1(num4, num5);
	}

	private void method_1(int int_24)
	{
		int_21 += 12 * int_24;
		if (int_21 < 0)
			int_21 = 0;
		if (int_21 > int_8)
			int_21 = int_8;
	}

	public void method_2()
	{
		if (bool_3)
		{
			if (GClass39.bool_11[(!Main.isPC) ? 8 : 22])
			{
				GClass39.bool_11[(!Main.isPC) ? 8 : 22] = false;
				method_1(1);
			}
			if (GClass39.bool_11[(!Main.isPC) ? 2 : 21])
			{
				GClass39.bool_11[(!Main.isPC) ? 2 : 21] = false;
				method_1(-1);
			}
			if (GClass39.smethod_24(int_3, 0, int_0 + 2, int_5))
			{
				if (GClass39.bool_17)
				{
					if (int_23 == 0)
						int_23 = GClass39.int_1;
					int_22 = int_23 - GClass39.int_1;
					if (int_22 != 0)
					{
						int_21 += int_22;
						int_23 = GClass39.int_1;
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
		if (gclass105_0 != null)
		{
			if (GClass39.bool_5)
				gclass105_0.method_1();
			if (GClass39.bool_13[(!Main.isPC) ? 2 : 21])
			{
				gclass105_0.int_1 -= 12;
				if (gclass105_0.int_1 < 0)
					gclass105_0.int_1 = 0;
			}
			if (GClass39.bool_13[(!Main.isPC) ? 8 : 22])
			{
				GClass39.bool_11[(!Main.isPC) ? 8 : 22] = false;
				gclass105_0.int_1 += 12;
				if (gclass105_0.int_1 > gclass105_0.int_13)
					gclass105_0.int_1 = gclass105_0.int_13;
			}
		}
		if (GClass39.bool_11[(!Main.isPC) ? 5 : 25] || GClass145.smethod_1(GClass39.gclass145_0.gclass14_1))
		{
			GClass39.bool_11[(!Main.isPC) ? 5 : 25] = false;
			GClass145.int_4 = -1;
			if (gclass14_0 != null)
				gclass14_0.method_1();
			else if (gclass14_1 != null)
			{
				gclass14_1.method_1();
			}
			else if (gclass14_2 != null)
			{
				gclass14_2.method_1();
			}
		}
		if (gclass105_0 == null || !gclass105_0.bool_0)
		{
			if (gclass14_1 != null && (GClass39.bool_11[12] || GClass39.bool_11[(!Main.isPC) ? 5 : 25] || GClass145.smethod_1(gclass14_1)))
			{
				GClass39.bool_11[12] = false;
				GClass39.bool_11[(!Main.isPC) ? 5 : 25] = false;
				GClass39.bool_15 = false;
				GClass39.bool_16 = false;
				gclass14_1.method_1();
				GClass145.int_4 = -1;
			}
			if (gclass14_2 != null && (GClass39.bool_11[13] || GClass145.smethod_1(gclass14_2)))
			{
				GClass39.bool_11[13] = false;
				GClass39.bool_15 = false;
				GClass39.bool_16 = false;
				gclass14_2.method_1();
				GClass145.int_4 = -1;
			}
		}
	}

	public void method_3(GClass76 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		g.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		GClass39.gclass37_0.method_8(g);
		if (gclass14_0 != null)
			GClass39.gclass37_0.method_7(g, null, gclass14_0, null);
		if (gclass14_1 != null)
			GClass39.gclass37_0.method_7(g, gclass14_1, null, gclass14_2);
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
		{
			try
			{
				GClass113.gclass113_0.method_3((string)p);
			}
			catch (Exception)
			{
			}
			if (!Main.isPC)
				GClass113.gclass113_0.method_2();
			else
				idAction = 1001;
			GClass39.smethod_29();
		}
		if (idAction == 1001)
		{
			gclass105_0 = null;
			GClass58.gclass70_0 = null;
			gclass70_1 = null;
			GClass154.gclass210_0.bool_1 = true;
			GClass58.bool_34 = false;
			if (bool_2)
			{
				GClass154.gclass210_0.gclass205_0.int_16 = 0;
				GClass154.gclass210_0.gclass205_0.gclass43_0.int_0 = 10;
			}
		}
		if (idAction != 8000 || int_11 > 0)
			return;
		int num = gclass70_0.int_9 + 1;
		if (num >= gclass70_0.string_1.Length)
		{
			GClass58.gclass70_0 = null;
			gclass70_0 = null;
			GClass154.gclass210_0.bool_1 = true;
			GClass58.bool_34 = false;
			if (string_2 != null)
			{
				num = 0;
				smethod_2(string_2, 100000, gclass59_1);
				string_2 = null;
				gclass59_1 = null;
			}
			else
			{
				if (!bool_2)
					return;
				GClass154.gclass210_0.gclass205_0.int_16 = 0;
				for (int i = 0; i < GClass154.gclass210_0.gclass205_0.gclass63_0.method_2(); i++)
				{
					if (((GClass43)GClass154.gclass210_0.gclass205_0.gclass63_0.method_3(i)).int_0 == 10000000)
						((GClass43)GClass154.gclass210_0.gclass205_0.gclass63_0.method_3(i)).int_0 = 10;
				}
			}
		}
		else
		{
			GClass70 gClass = smethod_4(gclass70_0.string_1[num], gclass70_0.int_1, gclass70_0.gclass59_0);
			gClass.int_9 = num;
			gClass.string_1 = gclass70_0.string_1;
			gClass.gclass14_0 = gclass70_0.gclass14_0;
			gclass70_0 = gClass;
		}
	}
}
