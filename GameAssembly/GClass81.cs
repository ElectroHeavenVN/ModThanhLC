public class GClass81
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

	public GClass124 gclass124_0;

	public GClass6 gclass6_0;

	public GClass5[] gclass5_0;

	private int[] int_3 = new int[10] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

	private int int_4;

	private long long_0;

	public GClass88 gclass88_0;

	public GClass122 gclass122_0 = new GClass122(string.Empty);

	public void method_0(int id, int no, int idIcon, sbyte rank, sbyte typeMonster, short templateId, string name, string info, GClass124 charInfo, GClass5[] itemOption)
	{
		int_0 = id;
		int_1 = no;
		int_2 = idIcon;
		sbyte_2 = rank;
		sbyte_5 = typeMonster;
		if (templateId != -1)
		{
			gclass6_0 = new GClass6();
			gclass6_0.int_26 = templateId;
		}
		string_0 = name;
		string_1 = info;
		gclass124_0 = charInfo;
		gclass5_0 = itemOption;
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

	public static GClass124 smethod_0(int head, int body, int leg, int bag)
	{
		GClass124 gClass = new GClass124();
		gClass.int_119 = head;
		gClass.int_121 = body;
		gClass.int_120 = leg;
		gClass.int_122 = bag;
		return gClass;
	}

	public static GClass81 smethod_1(GClass122 vec, int id)
	{
		if (vec != null)
		{
			for (int i = 0; i < vec.method_2(); i++)
			{
				GClass81 gClass = (GClass81)vec.method_3(i);
				if (gClass != null && gClass.int_0 == id)
					return gClass;
			}
		}
		return null;
	}

	public void method_4(GClass193 g, int x, int y)
	{
		int_4++;
		if (int_4 > int_3.Length - 1)
			int_4 = 0;
		if (sbyte_5 == 0)
		{
			if (GClass6.gclass76_0[gclass6_0.int_26] != null)
			{
				if (GClass6.gclass76_0[gclass6_0.int_26].gclass194_0 != null)
					GClass6.gclass76_0[gclass6_0.int_26].gclass194_0.method_9(g, int_3[int_4], x, y, 0, 0);
				else if (long_0 - GClass14.long_0 < 0L)
				{
					long_0 = GClass14.long_0 + 1500L;
					gclass6_0.method_1();
				}
			}
		}
		else if (gclass124_0 != null)
		{
			gclass124_0.method_98(g, x, y, 1, int_3[int_4], true);
		}
	}

	public void method_5()
	{
		gclass88_0 = new GClass88();
		string empty = string.Empty;
		string text = string.Concat(string.Empty + "\n|6|" + string_1, "\n--");
		if (gclass5_0 != null)
		{
			int num = 0;
			bool flag = true;
			while (flag)
			{
				int num2 = 0;
				for (int i = 0; i < gclass5_0.Length; i++)
				{
					if (!gclass5_0[i].method_0().Equals(string.Empty) && num == gclass5_0[i].sbyte_1)
					{
						num2++;
						break;
					}
				}
				if (num2 != 0)
				{
					if (num != 0)
					{
						string text2 = text;
						text = text2 + "\n|6|2|--" + mResources.equip + " Lv." + num + "--";
					}
					else
						text = text + "\n|6|2|--" + mResources.unlock + "--";
					for (int j = 0; j < gclass5_0.Length; j++)
					{
						empty = gclass5_0[j].method_0();
						if (empty.Equals(string.Empty) || num != gclass5_0[j].sbyte_1)
							continue;
						string text3 = "1";
						if (sbyte_6 != 0)
						{
							if (gclass5_0[j].sbyte_1 != 0)
							{
								if (sbyte_7 == 0)
									text3 = "2";
								else if (sbyte_6 < gclass5_0[j].sbyte_1)
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
		method_6(gclass88_0, text);
	}

	public void method_6(GClass88 cp, string chat)
	{
		cp.int_0 = GClass166.int_14;
		cp.int_3 = GClass166.int_12;
		cp.string_0 = GClass104.gclass104_11.method_15(chat, cp.int_0 - 8);
		cp.int_1 = 10000000;
		cp.gclass125_0 = null;
		cp.int_5 = cp.string_0.Length * 12;
		cp.int_4 = GClass166.int_13;
		cp.int_19 = 10;
		cp.int_8 = cp.int_5 - GClass166.int_16;
		if (cp.int_8 < 0)
			cp.int_8 = 0;
	}

	public void method_7()
	{
		if (sbyte_3 == sbyte_4 && gclass122_0.method_2() == 0)
		{
			int num = GClass191.smethod_19(1, 5);
			for (int i = 0; i < num; i++)
			{
				GClass198 gClass = new GClass198();
				gClass.int_0 = GClass191.smethod_19(5, 25);
				gClass.int_1 = GClass191.smethod_19(5, 25);
				gClass.int_4 = i * GClass191.smethod_19(0, 8);
				gClass.int_5 = 0;
				gClass.int_2 = -1;
				gclass122_0.method_0(gClass);
			}
		}
	}

	public void method_8(GClass193 g, int x, int y)
	{
		method_7();
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			GClass198 gClass = (GClass198)gclass122_0.method_3(i);
			if (gClass == null)
				continue;
			if (gClass.int_5 < gClass.int_4)
				gClass.int_5++;
			if (gClass.int_5 >= gClass.int_4)
			{
				gClass.int_2 = GClass14.int_8 / 3 % (GClass166.gclass117_2.int_2 + 1);
				if (gClass.int_2 < GClass166.gclass117_2.int_2)
				{
					GClass166.gclass117_2.method_0(gClass.int_2, x + gClass.int_0, y + gClass.int_1, 0, 3, g);
					continue;
				}
				gclass122_0.method_7(i);
				i--;
			}
		}
	}
}
