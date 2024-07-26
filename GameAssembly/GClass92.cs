using AssemblyCSharp.Functions;

public class GClass92 : GInterface6
{
	public GClass88 gclass88_0 = new GClass88();

	public GClass16 gclass16_0;

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

	public GClass70 gclass70_0;

	public static GClass70 gclass70_1 = GClass73.smethod_43("/mainImage/myTexture2dgocnhon.png");

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
		gclass88_0.method_9();
	}

	public void method_1(GClass122 g, int x, int y, int dir)
	{
		if (gclass88_0.method_2() == 0)
			return;
		g.method_1(x, y);
		if (string_0 != null && string_0.Length != 0 && int_18 != 1)
		{
			if (bool_0)
			{
				int_11 -= GClass144.int_22;
				int_12 -= GClass144.int_23;
				int_12 += 35;
			}
			int num = ((GClass122.int_12 != 1) ? 10 : 0);
			if (gclass16_0.gclass78_0 == null)
				GClass45.smethod_4(g, int_19, int_20, int_21, int_22, 16777215, false);
			else
				GClass203.smethod_15(g, int_19 - 23, int_20 - num / 2, int_21 + 15, int_22 + ((!GClass73.bool_5) ? 14 : 0) + num);
			if (gclass16_0.gclass78_0 == null)
				g.method_23(gclass70_1, 0, 0, 9, 8, (dir != 1) ? 2 : 0, int_11 - 3 + ((dir != 1) ? 20 : (-15)), int_12 - int_13 - 20 + int_10 + 2, GClass122.int_4 | GClass122.int_0);
			int num2 = -1;
			for (int i = 0; i < string_0.Length; i++)
			{
				GClass4 gClass = GClass4.gclass4_11;
				string text = string_0[i];
				int num3 = 0;
				if (string_0[i].StartsWith("|"))
				{
					string[] array = GClass50.smethod_30(string_0[i], "|", 0);
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
				}
				if (gclass16_0.gclass78_0 != null)
				{
					int x2 = int_19 - 23;
					int num4 = int_20 - num / 2;
					int num5 = ((GClass203.int_0 != 1) ? (int_21 + 25) : (int_21 + 28));
					int num6 = int_22 + ((!GClass73.bool_5) ? 14 : 0) + num;
					g.method_16(4465169);
					g.method_15(x2, num4 + num6, num5, 2);
					int num7 = gclass16_0.int_1 * num5 / gclass16_0.int_2;
					if (num7 < 0)
						num7 = 0;
					g.method_16(43758);
					g.method_15(x2, num4 + num6, num7, 2);
					if (gclass16_0.int_1 == 0)
						return;
					gclass16_0.gclass78_0.method_96(g, int_19 + 5, int_20 + int_22 / 2, 0);
					((!gclass16_0.bool_0) ? GClass4.gclass4_41 : GClass4.gclass4_38).method_6(g, gclass16_0.gclass78_0.string_3, int_19 + 12, int_20 + 3, 0);
					if (!GClass73.bool_5)
					{
						if (!GClass191.bool_4)
							GClass4.gclass4_39.method_6(g, "Nhấn # để chat", int_19 + int_21 / 2 + 10, int_20 + int_22, GClass4.int_2);
						else
							GClass4.gclass4_39.method_6(g, "Nhấn Y để chat", int_19 + int_21 / 2 + 10, int_20 + int_22, GClass4.int_2);
					}
					GClass123.smethod_1(g, text, int_19 + 14, int_20 + int_22 / 2 + 2, int_21 - 16, int_22, GClass4.gclass4_40);
					GClass73.smethod_6(g);
				}
				else
					gClass.method_6(g, text, int_11, int_12 - int_13 - 15 + int_10 + i * 12 - string_0.Length * 12 - 9, 2);
			}
			if (gclass16_0.gclass78_0 == null)
				;
		}
		g.method_1(-x, -y);
	}

	public void method_2()
	{
		if (gclass88_0.method_2() == 0 || gclass16_0.int_1 != 0)
			return;
		int_16++;
		if (int_16 >= gclass16_0.int_0)
		{
			int_16 = 0;
			gclass88_0.method_7(0);
			if (gclass88_0.method_2() != 0)
			{
				gclass16_0 = (GClass16)gclass88_0.method_11();
				method_3();
			}
		}
	}

	public void method_3()
	{
		int_9 = 100;
		if (GClass73.int_10 == 128)
			int_9 = 128;
		int num;
		if (gclass16_0.gclass78_0 == null)
		{
			string_0 = GClass4.gclass4_11.method_15(gclass16_0.string_0, int_9 - 10);
			num = string_0.Length;
		}
		else
		{
			string_0 = new string[1] { gclass16_0.string_0 };
			num = string_0.Length;
		}
		int_10 = 7;
		int_19 = int_11 - int_9 / 2 - 1;
		int_20 = int_12 - int_13 - 15 + int_10 - num * 12 - 15;
		int_21 = int_9 + 2 + ((gclass16_0.gclass78_0 != null) ? 30 : 0);
		int_22 = (num + 1) * 12 + 1 + ((gclass16_0.gclass78_0 != null) ? 5 : 0);
	}

	public void method_4(string s, int Type, GClass78 cInfo, bool isChatServer)
	{
		if ((cInfo != null && cInfo.int_13 < 0 && GClass167.smethod_0().bool_0) || GClass167.smethod_0().bool_13)
			return;
		int_18 = Type;
		if (GClass73.int_10 == 128)
			int_5 = 1;
		if (gclass88_0.method_2() > 10)
			gclass88_0.method_7(0);
		if (gclass88_0.method_2() <= 0 || !s.Equals(((GClass16)gclass88_0.method_12()).string_0))
			;
		GClass16 gClass = new GClass16(s);
		if (int_18 == 0)
			gClass.int_0 = s.Length;
		if (gClass.int_0 < 70)
			gClass.int_0 = 70;
		if (int_18 == 1)
			gClass.int_0 = 10000000;
		if (int_18 == 3)
		{
			gClass.int_0 = 300;
			gClass.long_0 = GClass203.smethod_18();
			gClass.int_1 = s.Length;
			if (gClass.int_1 < 15)
				gClass.int_1 = 15;
			if (gClass.int_1 > 100)
				gClass.int_1 = 100;
			gClass.int_2 = gClass.int_1;
		}
		if (cInfo != null)
		{
			gClass.gclass78_0 = cInfo;
			gClass.bool_0 = isChatServer;
			GClass73.gclass76_0.method_16(gClass);
			if (GClass73.bool_5 && GClass73.gclass76_0.bool_22)
				GClass144.gclass52_1.gclass87_0 = new GClass87(mResources.CHAT, this, 1000, gClass);
		}
		if ((cInfo != null && GClass73.gclass76_0.bool_22) || cInfo == null)
			gclass88_0.method_0(gClass);
		if (gclass88_0.method_2() == 1)
		{
			gclass16_0 = (GClass16)gclass88_0.method_11();
			method_3();
		}
		if (GClass73.bool_5 && cInfo != null && GClass73.gclass76_0.bool_22 && GClass73.int_10 - 50 > 155 + int_21)
		{
			GClass144.gclass52_1.gclass87_0.int_1 = GClass73.int_10 - int_21 - 50;
			GClass144.gclass52_1.gclass87_0.int_2 = 35;
		}
	}

	public void method_5(string s, int speed, GClass4 f)
	{
		if (GClass73.int_10 == 128)
			int_5 = 1;
		if (gclass88_0.method_2() > 10)
			gclass88_0.method_7(0);
		gclass88_0.method_0(new GClass16(s, f, speed));
	}

	public bool method_6()
	{
		return int_0 == 5 && gclass88_0.method_2() == 0;
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
			GClass91.smethod_0().method_4(GClass144.smethod_8(), mResources.chat_player);
	}

	public void method_7()
	{
	}
}
