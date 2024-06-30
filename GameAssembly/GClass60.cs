using System;

public class GClass60 : GClass59, GInterface0
{
	public static GClass2 gclass2_13;

	public static GClass2 gclass2_14 = GClass39.smethod_43("/mainImage/myTexture2dhatdau.png");

	public int int_191;

	public int int_192;

	public int int_193;

	public int int_194;

	public int int_195;

	public int int_196;

	public int int_197;

	public string string_15;

	public string string_16;

	public int int_198;

	public bool bool_83;

	public int[] int_199;

	public int[] int_200;

	private int int_201;

	public GClass24 gclass24_0;

	public bool bool_84;

	public static bool bool_85 = true;

	public bool bool_86;

	public int int_202;

	public long long_20;

	public long long_21;

	private int int_203;

	private bool bool_87;

	private int int_204;

	public GClass60(int npcId, int status, int cx, int cy, int templateId, int iconId)
		: base(npcId, status, cx, cy, templateId, iconId)
	{
		gclass24_0 = new GClass24(string.Empty, 0, 0);
		gclass24_0.gclass14_0 = new GClass14(null, this, 1, null);
		GClass24.smethod_2(gclass24_0);
	}

	public override void paint(GClass76 g)
	{
		if (int_191 == 0)
			return;
		GClass96.smethod_6(g, int_191, int_4, int_5, 0, GClass169.int_3);
		if (GClass58.smethod_1().gclass59_0 != null && GClass58.smethod_1().gclass59_0.Equals(this))
		{
			g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 0, int_4, int_5 - GClass96.int_0[int_191][4] - 1, GClass76.int_5 | GClass76.int_0);
			if (string_16 != null)
				GClass49.gclass49_3.method_10(g, string_16, int_4, int_5 - GClass96.int_0[int_191][4] - 20, GClass49.int_2, GClass49.gclass49_16);
		}
		else if (string_16 != null)
		{
			GClass49.gclass49_3.method_10(g, string_16, int_4, int_5 - GClass96.int_0[int_191][4] - 17, GClass49.int_2, GClass49.gclass49_16);
		}
		try
		{
			for (int i = 0; i < int_195; i++)
			{
				g.method_31(gclass2_14, int_4 + int_199[i] - GClass96.int_0[int_191][3] / 2, int_5 + int_200[i] - GClass96.int_0[int_191][4], 0);
			}
		}
		catch (Exception)
		{
		}
		if (int_125 < 0 || gclass42_1 == null || sbyte_19 != 0)
			return;
		GClass96.smethod_6(g, gclass42_1.gclass142_0[int_125].int_2, int_4 + gclass42_1.gclass142_0[int_125].int_0 + GClass96.int_0[int_191][3] / 2 + 5, int_5 - 15 + gclass42_1.gclass142_0[int_125].int_1, 0, GClass76.int_1 | GClass76.int_0);
		if (GClass39.int_8 % 2 == 0)
		{
			int_125++;
			if (int_125 >= gclass42_1.gclass142_0.Length)
				int_125 = 0;
		}
	}

	public override void update()
	{
		gclass24_0.bool_1 = bool_85;
		long_21 = GClass138.smethod_18();
		if (long_21 - long_20 >= 1000L)
		{
			int_202--;
			long_20 = long_21;
			if (int_202 < 0)
				int_202 = 0;
		}
		if (!bool_83)
		{
			if (int_195 < int_197 && int_202 == 0)
				bool_87 = true;
		}
		else if (int_202 == 0)
		{
			bool_83 = false;
			bool_87 = true;
		}
		if (bool_87)
		{
			int_204++;
			if (int_204 == 20)
			{
				int_204 = 0;
				bool_87 = false;
				GClass166.smethod_0().method_123(2);
			}
		}
		int_201 = ((int_199 != null) ? (int_199.Length * int_195 / int_197) : 0);
		if (bool_84)
		{
			bool_84 = false;
			if ((int_202 >= 0 && int_195 < int_197) || (int_202 >= 0 && bool_83) || bool_86)
				gclass24_0.method_0(new string[2]
				{
					bool_83 ? mResources.UPGRADING : (int_195 + "/" + int_197),
					GClass95.smethod_8(int_202)
				}, int_4, int_5 - 20 - GClass96.int_0[int_191][4]);
			else if (int_195 == int_197 && !bool_83)
			{
				gclass24_0.method_0(new string[2]
				{
					mResources.can_harvest,
					int_195 + "/" + int_197
				}, int_4, int_5 - 20 - GClass96.int_0[int_191][4]);
			}
		}
		if ((int_202 >= 0 && int_195 < int_197) || (int_202 >= 0 && bool_83))
			gclass24_0.string_0[gclass24_0.string_0.Length - 1] = GClass95.smethod_8(int_202);
		if (bool_86)
		{
			gclass24_0.bool_1 = false;
			GClass71.smethod_0(98, int_4 + int_199[int_195 - 1] - GClass96.int_0[int_191][3] / 2, int_5 + int_200[int_195 - 1] - GClass96.int_0[int_191][4], 1);
			int_195--;
			if (GClass39.int_8 % 2 == 0)
				GClass29.smethod_1().method_3();
			if (int_195 == int_196)
			{
				gclass24_0.bool_1 = true;
				bool_84 = true;
				bool_86 = false;
			}
		}
		base.update();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
			GClass166.smethod_0().method_41(1);
	}
}
