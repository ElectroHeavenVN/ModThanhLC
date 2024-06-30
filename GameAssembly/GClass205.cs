public class GClass205 : GInterface0
{
	public GClass63 gclass63_0 = new GClass63();

	public GClass43 gclass43_0;

	public int int_0 = 5;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5 = 2;

	public int int_6 = 20;

	public int int_7;

	public int int_8;

	public int int_9 = 100;

	public int int_10;

	public string[] string_0;

	public int int_11;

	public int int_12;

	public int int_13;

	public bool bool_0;

	public int int_14;

	public int int_15;

	public GClass2 gclass2_0;

	public static GClass2 gclass2_1 = GClass39.smethod_43("/mainImage/myTexture2dgocnhon.png");

	public int int_16;

	public int int_17;

	public int int_18;

	public int int_19;

	public int int_20;

	public int int_21;

	public int int_22;

	public void method_0()
	{
		string_0 = null;
		gclass63_0.method_9();
	}

	public void method_1(GClass76 g, int x, int y, int dir)
	{
		if (gclass63_0.method_2() == 0)
			return;
		g.method_1(x, y);
		if (string_0 != null && string_0.Length != 0 && int_18 != 1)
		{
			if (bool_0)
			{
				int_11 -= GClass154.int_22;
				int_12 -= GClass154.int_23;
				int_12 += 35;
			}
			int num = ((GClass76.int_12 != 1) ? 10 : 0);
			if (gclass43_0.gclass58_0 == null)
				GClass24.smethod_4(g, int_19, int_20, int_21, int_22, 16777215, false);
			else
				GClass138.smethod_15(g, int_19 - 23, int_20 - num / 2, int_21 + 15, int_22 + ((!GClass39.bool_5) ? 14 : 0) + num);
			if (gclass43_0.gclass58_0 == null)
				g.method_23(gclass2_1, 0, 0, 9, 8, (dir != 1) ? 2 : 0, int_11 - 3 + ((dir != 1) ? 20 : (-15)), int_12 - int_13 - 20 + int_10 + 2, GClass76.int_4 | GClass76.int_0);
			int num2 = -1;
			for (int i = 0; i < string_0.Length; i++)
			{
				GClass49 gClass = GClass49.gclass49_11;
				string text = string_0[i];
				int num3 = 0;
				if (string_0[i].StartsWith("|"))
				{
					string[] array = GClass56.smethod_30(string_0[i], "|", 0);
					if (array.Length == 3)
						text = array[2];
					if (array.Length == 4)
					{
						text = array[3];
						int.Parse(array[2]);
					}
					num3 = int.Parse(array[1]);
					num2 = num3;
				}
				else
					num3 = num2;
				switch (num3)
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
				}
				if (gclass43_0.gclass58_0 == null)
				{
					gClass.method_6(g, text, int_11, int_12 - int_13 - 15 + int_10 + i * 12 - string_0.Length * 12 - 9, 2);
					continue;
				}
				int x2 = int_19 - 23;
				int num4 = int_20 - num / 2;
				int num5 = ((GClass138.int_0 != 1) ? (int_21 + 25) : (int_21 + 28));
				int num6 = int_22 + ((!GClass39.bool_5) ? 14 : 0) + num;
				g.method_16(4465169);
				g.method_15(x2, num4 + num6, num5, 2);
				int num7 = gclass43_0.int_1 * num5 / gclass43_0.int_2;
				if (num7 < 0)
					num7 = 0;
				g.method_16(43758);
				g.method_15(x2, num4 + num6, num7, 2);
				if (gclass43_0.int_1 == 0)
					return;
				gclass43_0.gclass58_0.method_94(g, int_19 + 5, int_20 + int_22 / 2, 0);
				((!gclass43_0.bool_0) ? GClass49.gclass49_41 : GClass49.gclass49_38).method_6(g, gclass43_0.gclass58_0.string_3, int_19 + 12, int_20 + 3, 0);
				if (!GClass39.bool_5)
				{
					if (!GClass67.bool_4)
						GClass49.gclass49_39.method_6(g, "Nhấn # để chat", int_19 + int_21 / 2 + 10, int_20 + int_22, GClass49.int_2);
					else
						GClass49.gclass49_39.method_6(g, "Nhấn Y để chat", int_19 + int_21 / 2 + 10, int_20 + int_22, GClass49.int_2);
				}
				GClass164.smethod_1(g, text, int_19 + 14, int_20 + int_22 / 2 + 2, int_21 - 16, int_22, GClass49.gclass49_40);
				GClass39.smethod_6(g);
			}
			if (gclass43_0.gclass58_0 != null)
				;
		}
		g.method_1(-x, -y);
	}

	public void method_2()
	{
		if (gclass63_0.method_2() == 0 || gclass43_0.int_1 != 0)
			return;
		int_16++;
		if (int_16 >= gclass43_0.int_0)
		{
			int_16 = 0;
			gclass63_0.method_7(0);
			if (gclass63_0.method_2() != 0)
			{
				gclass43_0 = (GClass43)gclass63_0.method_11();
				method_3();
			}
		}
	}

	public void method_3()
	{
		int_9 = 100;
		if (GClass39.int_10 == 128)
			int_9 = 128;
		int num;
		if (gclass43_0.gclass58_0 != null)
		{
			string_0 = new string[1] { gclass43_0.string_0 };
			num = string_0.Length;
		}
		else
		{
			string_0 = GClass49.gclass49_11.method_15(gclass43_0.string_0, int_9 - 10);
			num = string_0.Length;
		}
		int_10 = 7;
		int_19 = int_11 - int_9 / 2 - 1;
		int_20 = int_12 - int_13 - 15 + int_10 - num * 12 - 15;
		int_21 = int_9 + 2 + ((gclass43_0.gclass58_0 != null) ? 30 : 0);
		int_22 = (num + 1) * 12 + 1 + ((gclass43_0.gclass58_0 != null) ? 5 : 0);
	}

	public void method_4(string s, int Type, GClass58 cInfo, bool isChatServer)
	{
		int_18 = Type;
		if (GClass39.int_10 == 128)
			int_5 = 1;
		if (gclass63_0.method_2() > 10)
			gclass63_0.method_7(0);
		if (gclass63_0.method_2() <= 0 || s.Equals(((GClass43)gclass63_0.method_12()).string_0))
			;
		GClass43 gClass = new GClass43(s);
		if (int_18 == 0)
			gClass.int_0 = s.Length;
		if (gClass.int_0 < 70)
			gClass.int_0 = 70;
		if (int_18 == 1)
			gClass.int_0 = 10000000;
		if (int_18 == 3)
		{
			gClass.int_0 = 300;
			gClass.long_0 = GClass138.smethod_18();
			gClass.int_1 = s.Length;
			if (gClass.int_1 < 15)
				gClass.int_1 = 15;
			if (gClass.int_1 > 100)
				gClass.int_1 = 100;
			gClass.int_2 = gClass.int_1;
		}
		if (cInfo != null)
		{
			gClass.gclass58_0 = cInfo;
			gClass.bool_0 = isChatServer;
			GClass39.gclass45_0.method_16(gClass);
			if (GClass39.bool_5 && GClass39.gclass45_0.bool_22)
				GClass154.gclass210_1.gclass14_0 = new GClass14(mResources.CHAT, this, 1000, gClass);
		}
		if ((cInfo != null && GClass39.gclass45_0.bool_22) || cInfo == null)
			gclass63_0.method_0(gClass);
		if (gclass63_0.method_2() == 1)
		{
			gclass43_0 = (GClass43)gclass63_0.method_11();
			method_3();
		}
		if (GClass39.bool_5 && cInfo != null && GClass39.gclass45_0.bool_22 && GClass39.int_10 - 50 > 155 + int_21)
		{
			GClass154.gclass210_1.gclass14_0.int_1 = GClass39.int_10 - int_21 - 50;
			GClass154.gclass210_1.gclass14_0.int_2 = 35;
		}
	}

	public void method_5(string s, int speed, GClass49 f)
	{
		if (GClass39.int_10 == 128)
			int_5 = 1;
		if (gclass63_0.method_2() > 10)
			gclass63_0.method_7(0);
		gclass63_0.method_0(new GClass43(s, f, speed));
	}

	public bool method_6()
	{
		return int_0 == 5 && gclass63_0.method_2() == 0;
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
			GClass7.smethod_0().method_4(GClass154.smethod_8(), mResources.chat_player);
	}

	public void method_7()
	{
	}
}
