public class GClass202
{
	public const sbyte sbyte_0 = 0;

	public const sbyte sbyte_1 = 1;

	public sbyte sbyte_2;

	public sbyte sbyte_3;

	public sbyte sbyte_4;

	public sbyte sbyte_5;

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public string string_1;

	public sbyte sbyte_6;

	public sbyte sbyte_7;

	public GClass78 gclass78_0;

	public GClass194 gclass194_0;

	public GClass120[] gclass120_0;

	private int[] int_3 = new int[10] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

	private int int_4;

	private long long_0;

	public GClass96 gclass96_0;

	public GClass88 gclass88_0 = new GClass88("");

	public void method_0(int id, int no, int idIcon, sbyte rank, sbyte typeMonster, short templateId, string name, string info, GClass78 charInfo, GClass120[] itemOption)
	{
		int_0 = id;
		int_1 = no;
		int_2 = idIcon;
		sbyte_2 = rank;
		sbyte_5 = typeMonster;
		if (templateId != -1)
		{
			gclass194_0 = new GClass194();
			gclass194_0.int_26 = templateId;
		}
		string_0 = name;
		string_1 = info;
		gclass78_0 = charInfo;
		gclass120_0 = itemOption;
		method_5();
	}

	public void method_1(sbyte amount, sbyte max_amount)
	{
		sbyte_3 = amount;
		sbyte_4 = max_amount;
	}

	public void method_2(sbyte level)
	{
		sbyte_6 = level;
		method_5();
	}

	public void method_3(sbyte isUse)
	{
		sbyte_7 = isUse;
		method_5();
	}

	public static GClass78 smethod_0(int head, int body, int leg, int bag)
	{
		GClass78 gClass = new GClass78();
		gClass.int_119 = head;
		gClass.int_121 = body;
		gClass.int_120 = leg;
		gClass.int_122 = bag;
		return gClass;
	}

	public static GClass202 smethod_1(GClass88 vec, int id)
	{
		if (vec != null)
		{
			for (int i = 0; i < vec.method_2(); i++)
			{
				GClass202 gClass = (GClass202)vec.method_3(i);
				if (gClass != null && gClass.int_0 == id)
					return gClass;
			}
		}
		return null;
	}

	public void method_4(GClass122 g, int x, int y)
	{
		int_4++;
		if (int_4 > int_3.Length - 1)
			int_4 = 0;
		if (sbyte_5 == 0)
		{
			if (GClass194.gclass177_0[gclass194_0.int_26] == null)
				return;
			if (GClass194.gclass177_0[gclass194_0.int_26].gclass72_0 == null)
			{
				if (long_0 - GClass73.long_0 < 0L)
				{
					long_0 = GClass73.long_0 + 1500L;
					gclass194_0.method_1();
				}
			}
			else
				GClass194.gclass177_0[gclass194_0.int_26].gclass72_0.method_9(g, int_3[int_4], x, y, 0, 0);
		}
		else if (gclass78_0 != null)
		{
			gclass78_0.method_98(g, x, y, 1, int_3[int_4], true);
		}
	}

	public void method_5()
	{
		gclass96_0 = new GClass96();
		string empty = "";
		string text = string.Concat("" + "\n|6|" + string_1, "\n--");
		if (gclass120_0 != null)
		{
			int num = 0;
			bool flag = true;
			while (flag)
			{
				int num2 = 0;
				for (int i = 0; i < gclass120_0.Length; i++)
				{
					if (!gclass120_0[i].method_0().Equals("") && num == gclass120_0[i].sbyte_1)
					{
						num2++;
						break;
					}
				}
				if (num2 != 0)
				{
					if (num == 0)
						text = text + "\n|6|2|--" + mResources.unlock + "--";
					else
					{
						string text2 = text;
						text = text2 + "\n|6|2|--" + mResources.equip + " Lv." + num + "--";
					}
					for (int j = 0; j < gclass120_0.Length; j++)
					{
						empty = gclass120_0[j].method_0();
						if (empty.Equals("") || num != gclass120_0[j].sbyte_1)
							continue;
						string text3 = "1";
						if (sbyte_6 != 0)
						{
							if (gclass120_0[j].sbyte_1 != 0)
							{
								if (sbyte_7 == 0)
									text3 = "2";
								else if (sbyte_6 < gclass120_0[j].sbyte_1)
								{
									text3 = "2";
								}
							}
						}
						else
							text3 = "2";
						string text4 = text;
						text = text4 + "\n|" + text3 + "|1|" + empty;
					}
					if (num2 != 0)
						num++;
					continue;
				}
				flag = false;
				break;
			}
		}
		method_6(gclass96_0, text);
	}

	public void method_6(GClass96 cp, string chat)
	{
		cp.int_0 = GClass135.int_14;
		cp.int_3 = GClass135.int_12;
		cp.string_0 = GClass4.gclass4_11.method_15(chat, cp.int_0 - 8);
		cp.int_1 = 10000000;
		cp.gclass79_0 = null;
		cp.int_5 = cp.string_0.Length * 12;
		cp.int_4 = GClass135.int_13;
		cp.int_19 = 10;
		cp.int_8 = cp.int_5 - GClass135.int_16;
		if (cp.int_8 < 0)
			cp.int_8 = 0;
	}

	public void method_7()
	{
		if (sbyte_3 == sbyte_4 && gclass88_0.method_2() == 0)
		{
			int num = GClass50.smethod_19(1, 5);
			for (int i = 0; i < num; i++)
			{
				GClass125 gClass = new GClass125();
				gClass.int_0 = GClass50.smethod_19(5, 25);
				gClass.int_1 = GClass50.smethod_19(5, 25);
				gClass.int_4 = i * GClass50.smethod_19(0, 8);
				gClass.int_5 = 0;
				gClass.int_2 = -1;
				gclass88_0.method_0(gClass);
			}
		}
	}

	public void method_8(GClass122 g, int x, int y)
	{
		method_7();
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			GClass125 gClass = (GClass125)gclass88_0.method_3(i);
			if (gClass == null)
				continue;
			if (gClass.int_5 < gClass.int_4)
				gClass.int_5++;
			if (gClass.int_5 >= gClass.int_4)
			{
				gClass.int_2 = GClass73.int_8 / 3 % (GClass135.gclass17_2.int_2 + 1);
				if (gClass.int_2 >= GClass135.gclass17_2.int_2)
				{
					gclass88_0.method_7(i);
					i--;
				}
				else
					GClass135.gclass17_2.method_0(gClass.int_2, x + gClass.int_0, y + gClass.int_1, 0, 3, g);
			}
		}
	}
}
