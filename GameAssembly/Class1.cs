using System;

internal class Class1 : GClass58
{
	public static GClass167 gclass167_0;

	public static GClass167 gclass167_1;

	private int int_181;

	private int int_182;

	private bool bool_80;

	private GClass33 gclass33_2;

	private GClass58 gclass58_5;

	public int int_183;

	public int int_184;

	public bool bool_81;

	public bool bool_82;

	private GClass58[] gclass58_6;

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

	public Class1()
	{
		method_166();
		method_168();
	}

	public void method_164(int int_194)
	{
		gclass33_2 = new GClass33(105, int_4, int_5 + 20, 2, 1, -1);
		GClass81.smethod_0(gclass33_2);
		if (int_194 == GClass58.smethod_1().int_13)
			gclass58_5 = GClass58.smethod_1();
		else
			gclass58_5 = GClass154.smethod_14(int_194);
	}

	public void method_165(int[] int_194)
	{
		if (sbyte_40 == 0)
		{
			if (int_181 == 11)
			{
				bool_80 = true;
				GClass81.smethod_0(new GClass33(19, int_4, int_5 + 20, 2, 1, -1));
			}
			if (int_181 >= int_194.Length - 1)
			{
				sbyte_40 = 2;
				return;
			}
		}
		if (sbyte_40 == 1 && int_181 == int_194.Length - 1)
		{
			sbyte_40 = 3;
			int_5 -= 15;
			return;
		}
		int_181++;
		if (int_181 > int_194.Length - 1)
			int_181 = 0;
		int_192 = int_194[int_181];
	}

	public void method_166()
	{
		gclass167_0 = null;
		gclass167_0 = new GClass167();
		string patch = "/x" + GClass76.int_12 + "/effectdata/" + 102 + "/data";
		try
		{
			gclass167_0.method_4(patch);
			gclass167_0.gclass2_0 = GClass39.smethod_43("/effectdata/" + 102 + "/img.png");
		}
		catch (Exception)
		{
		}
	}

	public void method_167(sbyte sbyte_41, short short_34, short short_35, GClass58[] gclass58_7, int[] int_194)
	{
		sbyte_40 = sbyte_41;
		int_183 = short_34;
		int_184 = short_35;
		int_182 = int_12;
		int_12 = ((int_183 > int_4) ? 1 : (-1));
		gclass58_6 = gclass58_7;
		int_185 = int_194;
	}

	public void method_168()
	{
		gclass167_1 = null;
		gclass167_1 = new GClass167();
		string patch = "/x" + GClass76.int_12 + "/effectdata/" + 103 + "/data";
		try
		{
			gclass167_1.method_4(patch);
			gclass167_1.gclass2_0 = GClass39.smethod_43("/effectdata/" + 103 + "/img.png");
			GClass56.smethod_8("read xong data");
		}
		catch (Exception)
		{
		}
	}

	public override void update()
	{
		if (gclass58_5 != null)
		{
			if (gclass33_2.int_39 >= 30)
			{
				gclass33_2.int_41 += (int_4 - gclass33_2.int_41) / 4;
				gclass33_2.int_42 += (int_5 - gclass33_2.int_42) / 4;
				gclass58_5.int_4 = gclass33_2.int_41;
				gclass58_5.int_5 = gclass33_2.int_42;
				gclass58_5.bool_50 = true;
			}
			else
			{
				gclass33_2.int_48 = ((gclass33_2.int_41 > gclass58_5.int_4) ? 1 : 0);
				gclass33_2.int_41 += (gclass58_5.int_4 - gclass33_2.int_41) / 3;
				gclass33_2.int_42 += (gclass58_5.int_5 - gclass33_2.int_42) / 3;
			}
		}
		if (sbyte_40 != -1)
		{
			if (sbyte_40 == 0 && bool_80 && GClass39.int_8 % 2 == 0)
			{
				int_186 += ((int_183 <= int_4) ? (-30) : 30);
				GClass33 gClass = new GClass33(103, int_4 + int_186, int_5 + 20, 2, 1, -1);
				gClass.int_48 = ((int_183 <= int_4) ? 1 : 0);
				GClass81.smethod_0(gClass);
				if ((int_12 == 1 && int_4 + int_186 >= int_183) || (int_12 == -1 && int_4 + int_186 <= int_183))
				{
					bool_80 = false;
					sbyte_40 = -1;
					int_186 = 0;
					int_181 = 0;
					int_12 = int_182;
					for (int i = 0; i < gclass58_6.Length; i++)
					{
						gclass58_6[i].method_110(int_185[i], 0, false, false);
					}
				}
			}
			if (sbyte_40 != 3)
				return;
			int_183 = gclass58_6[int_193].int_4;
			int_184 = gclass58_6[int_193].int_5;
			int_4 += (int_183 - int_4) / 3;
			int_5 += (int_184 - int_5) / 3;
			if (GClass39.int_8 % 5 == 0)
				GClass81.smethod_0(new GClass33(19, int_4, int_5, 2, 1, -1));
			if (GClass56.smethod_28(int_4 - int_183) <= 20 && GClass56.smethod_28(int_5 - int_184) <= 20)
			{
				int_4 = int_183;
				int_5 = int_184;
				gclass58_6[int_193].method_110(int_185[int_193], 0, false, false);
				int_193++;
				if (int_193 == gclass58_6.Length)
				{
					sbyte_40 = -1;
					int_193 = 0;
				}
			}
		}
		else
			base.update();
	}

	public override void paint(GClass76 g)
	{
		if (sbyte_40 != -1)
		{
			method_89(g);
			g.method_1(0, GClass39.int_58);
			method_165(int_191[sbyte_40]);
			if (sbyte_40 == 0 || sbyte_40 == 1)
				gclass167_0.method_9(g, int_192, int_4, int_5 + int_113, (int_12 != 1) ? 1 : 0, 2);
			else
				gclass167_1.method_9(g, int_192, int_4, int_5 + int_113, (int_12 != 1) ? 1 : 0, 2);
			g.method_1(0, -GClass39.int_58);
		}
		else
			base.paint(g);
	}
}
