using System;

internal class Class19 : GClass124
{
	public static GClass194 gclass194_0;

	public static GClass194 gclass194_1;

	private int int_181;

	private int int_182;

	private bool bool_80;

	private GClass85 gclass85_2;

	private GClass124 gclass124_5;

	public int int_183;

	public int int_184;

	public bool bool_81;

	public bool bool_82;

	private GClass124[] gclass124_6;

	private int[] int_185;

	private int int_186;

	public static int[] int_187 = new int[30]
	{
		0, 0, 1, 1, 2, 2, 3, 3, 4, 4,
		5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
		5, 5, 5, 5, 5, 5, 5, 5, 5, 5
	};

	public static int[] int_188 = new int[15]
	{
		0, 0, 6, 6, 7, 7, 8, 8, 9, 9,
		9, 9, 9, 10, 10
	};

	public static int[] int_189 = new int[26]
	{
		0, 0, 1, 1, 2, 2, 3, 3, 4, 4,
		5, 5, 6, 6, 7, 7, 8, 8, 9, 9,
		10, 10, 11, 11, 12, 12
	};

	public static int[] int_190 = new int[8] { 13, 13, 14, 14, 15, 15, 16, 16 };

	public static int[][] int_191 = new int[4][] { int_187, int_188, int_189, int_190 };

	public sbyte sbyte_40 = -1;

	private int int_192;

	private int int_193;

	public Class19()
	{
		method_168();
		method_170();
	}

	public void method_166(int int_194)
	{
		gclass85_2 = new GClass85(105, int_4, int_5 + 20, 2, 1, -1);
		GClass98.smethod_0(gclass85_2);
		if (int_194 == GClass124.smethod_1().int_13)
			gclass124_5 = GClass124.smethod_1();
		else
			gclass124_5 = GClass167.smethod_14(int_194);
	}

	public void method_167(int[] int_194)
	{
		if (sbyte_40 == 0)
		{
			if (int_181 == 11)
			{
				bool_80 = true;
				GClass98.smethod_0(new GClass85(19, int_4, int_5 + 20, 2, 1, -1));
			}
			if (int_181 >= int_194.Length - 1)
			{
				sbyte_40 = 2;
				return;
			}
		}
		if (sbyte_40 != 1 || int_181 != int_194.Length - 1)
		{
			int_181++;
			if (int_181 > int_194.Length - 1)
				int_181 = 0;
			int_192 = int_194[int_181];
		}
		else
		{
			sbyte_40 = 3;
			int_5 -= 15;
		}
	}

	public void method_168()
	{
		gclass194_0 = null;
		gclass194_0 = new GClass194();
		string patch = "/x" + GClass193.int_12 + "/effectdata/" + 102 + "/data";
		try
		{
			gclass194_0.method_4(patch);
			gclass194_0.gclass20_0 = GClass14.smethod_43("/effectdata/" + 102 + "/img.png");
		}
		catch (Exception)
		{
		}
	}

	public void method_169(sbyte sbyte_41, short short_34, short short_35, GClass124[] gclass124_7, int[] int_194)
	{
		sbyte_40 = sbyte_41;
		int_183 = short_34;
		int_184 = short_35;
		int_182 = int_12;
		int_12 = ((int_183 > int_4) ? 1 : (-1));
		gclass124_6 = gclass124_7;
		int_185 = int_194;
	}

	public void method_170()
	{
		gclass194_1 = null;
		gclass194_1 = new GClass194();
		string patch = "/x" + GClass193.int_12 + "/effectdata/" + 103 + "/data";
		try
		{
			gclass194_1.method_4(patch);
			gclass194_1.gclass20_0 = GClass14.smethod_43("/effectdata/" + 103 + "/img.png");
			GClass191.smethod_8("read xong data");
		}
		catch (Exception)
		{
		}
	}

	public override void update()
	{
		if (gclass124_5 != null)
		{
			if (gclass85_2.int_39 >= 30)
			{
				gclass85_2.int_41 += (int_4 - gclass85_2.int_41) / 4;
				gclass85_2.int_42 += (int_5 - gclass85_2.int_42) / 4;
				gclass124_5.int_4 = gclass85_2.int_41;
				gclass124_5.int_5 = gclass85_2.int_42;
				gclass124_5.bool_50 = true;
			}
			else
			{
				gclass85_2.int_48 = ((gclass85_2.int_41 > gclass124_5.int_4) ? 1 : 0);
				gclass85_2.int_41 += (gclass124_5.int_4 - gclass85_2.int_41) / 3;
				gclass85_2.int_42 += (gclass124_5.int_5 - gclass85_2.int_42) / 3;
			}
		}
		if (sbyte_40 == -1)
		{
			base.update();
			return;
		}
		if (sbyte_40 == 0 && bool_80 && GClass14.int_8 % 2 == 0)
		{
			int_186 += ((int_183 > int_4) ? 30 : (-30));
			GClass85 gClass = new GClass85(103, int_4 + int_186, int_5 + 20, 2, 1, -1);
			gClass.int_48 = ((int_183 <= int_4) ? 1 : 0);
			GClass98.smethod_0(gClass);
			if ((int_12 == 1 && int_4 + int_186 >= int_183) || (int_12 == -1 && int_4 + int_186 <= int_183))
			{
				bool_80 = false;
				sbyte_40 = -1;
				int_186 = 0;
				int_181 = 0;
				int_12 = int_182;
				for (int i = 0; i < gclass124_6.Length; i++)
				{
					gclass124_6[i].method_112(int_185[i], 0, false, false);
				}
			}
		}
		if (sbyte_40 != 3)
			return;
		int_183 = gclass124_6[int_193].int_4;
		int_184 = gclass124_6[int_193].int_5;
		int_4 += (int_183 - int_4) / 3;
		int_5 += (int_184 - int_5) / 3;
		if (GClass14.int_8 % 5 == 0)
			GClass98.smethod_0(new GClass85(19, int_4, int_5, 2, 1, -1));
		if (GClass191.smethod_28(int_4 - int_183) <= 20 && GClass191.smethod_28(int_5 - int_184) <= 20)
		{
			int_4 = int_183;
			int_5 = int_184;
			gclass124_6[int_193].method_112(int_185[int_193], 0, false, false);
			int_193++;
			if (int_193 == gclass124_6.Length)
			{
				sbyte_40 = -1;
				int_193 = 0;
			}
		}
	}

	public override void paint(GClass193 g)
	{
		if (sbyte_40 != -1)
		{
			method_91(g);
			g.method_1(0, GClass14.int_58);
			method_167(int_191[sbyte_40]);
			if (sbyte_40 == 0 || sbyte_40 == 1)
				gclass194_0.method_9(g, int_192, int_4, int_5 + int_113, (int_12 != 1) ? 1 : 0, 2);
			else
				gclass194_1.method_9(g, int_192, int_4, int_5 + int_113, (int_12 != 1) ? 1 : 0, 2);
			g.method_1(0, -GClass14.int_58);
		}
		else
			base.paint(g);
	}
}
