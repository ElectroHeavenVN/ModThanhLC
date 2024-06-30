public class GClass97
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

	public GClass58 gclass58_0;

	public GClass85 gclass85_0;

	public GClass20[] gclass20_0;

	private int[] int_3 = new int[10] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

	private int int_4;

	private long long_0;

	public GClass70 gclass70_0;

	public GClass63 gclass63_0 = new GClass63(string.Empty);

	public void method_0(int id, int no, int idIcon, sbyte rank, sbyte typeMonster, short templateId, string name, string info, GClass58 charInfo, GClass20[] itemOption)
	{
		int_0 = id;
		int_1 = no;
		int_2 = idIcon;
		sbyte_2 = rank;
		sbyte_5 = typeMonster;
		if (templateId != -1)
		{
			gclass85_0 = new GClass85();
			gclass85_0.int_26 = templateId;
		}
		string_0 = name;
		string_1 = info;
		gclass58_0 = charInfo;
		gclass20_0 = itemOption;
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

	public static GClass58 smethod_0(int head, int body, int leg, int bag)
	{
		GClass58 gClass = new GClass58();
		gClass.int_119 = head;
		gClass.int_121 = body;
		gClass.int_120 = leg;
		gClass.int_122 = bag;
		return gClass;
	}

	public static GClass97 smethod_1(GClass63 vec, int id)
	{
		if (vec != null)
		{
			for (int i = 0; i < vec.method_2(); i++)
			{
				GClass97 gClass = (GClass97)vec.method_3(i);
				if (gClass != null && gClass.int_0 == id)
					return gClass;
			}
		}
		return null;
	}

	public void method_4(GClass76 g, int x, int y)
	{
		int_4++;
		if (int_4 > int_3.Length - 1)
			int_4 = 0;
		if (sbyte_5 == 0)
		{
			if (GClass85.gclass204_0[gclass85_0.int_26] != null)
			{
				if (GClass85.gclass204_0[gclass85_0.int_26].gclass167_0 != null)
					GClass85.gclass204_0[gclass85_0.int_26].gclass167_0.method_9(g, int_3[int_4], x, y, 0, 0);
				else if (long_0 - GClass39.long_0 < 0L)
				{
					long_0 = GClass39.long_0 + 1500L;
					gclass85_0.method_1();
				}
			}
		}
		else if (gclass58_0 != null)
		{
			gclass58_0.method_96(g, x, y, 1, int_3[int_4], true);
		}
	}

	public void method_5()
	{
		gclass70_0 = new GClass70();
		string empty = string.Empty;
		string text = string.Concat(string.Empty + "\n|6|" + string_1, "\n--");
		if (gclass20_0 != null)
		{
			int num = 0;
			bool flag = true;
			while (flag)
			{
				int num2 = 0;
				for (int i = 0; i < gclass20_0.Length; i++)
				{
					if (!gclass20_0[i].method_0().Equals(string.Empty) && num == gclass20_0[i].sbyte_1)
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
					for (int j = 0; j < gclass20_0.Length; j++)
					{
						empty = gclass20_0[j].method_0();
						if (empty.Equals(string.Empty) || num != gclass20_0[j].sbyte_1)
							continue;
						string text3 = "1";
						if (sbyte_6 == 0)
							text3 = "2";
						else if (gclass20_0[j].sbyte_1 != 0)
						{
							if (sbyte_7 == 0)
								text3 = "2";
							else if (sbyte_6 < gclass20_0[j].sbyte_1)
							{
								text3 = "2";
							}
						}
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
		method_6(gclass70_0, text);
	}

	public void method_6(GClass70 cp, string chat)
	{
		cp.int_0 = GClass146.int_14;
		cp.int_3 = GClass146.int_12;
		cp.string_0 = GClass49.gclass49_11.method_15(chat, cp.int_0 - 8);
		cp.int_1 = 10000000;
		cp.gclass59_0 = null;
		cp.int_5 = cp.string_0.Length * 12;
		cp.int_4 = GClass146.int_13;
		cp.int_19 = 10;
		cp.int_8 = cp.int_5 - GClass146.int_16;
		if (cp.int_8 < 0)
			cp.int_8 = 0;
	}

	public void method_7()
	{
		if (sbyte_3 == sbyte_4 && gclass63_0.method_2() == 0)
		{
			int num = GClass56.smethod_19(1, 5);
			for (int i = 0; i < num; i++)
			{
				GClass133 gClass = new GClass133();
				gClass.int_0 = GClass56.smethod_19(5, 25);
				gClass.int_1 = GClass56.smethod_19(5, 25);
				gClass.int_4 = i * GClass56.smethod_19(0, 8);
				gClass.int_5 = 0;
				gClass.int_2 = -1;
				gclass63_0.method_0(gClass);
			}
		}
	}

	public void method_8(GClass76 g, int x, int y)
	{
		method_7();
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			GClass133 gClass = (GClass133)gclass63_0.method_3(i);
			if (gClass == null)
				continue;
			if (gClass.int_5 < gClass.int_4)
				gClass.int_5++;
			if (gClass.int_5 >= gClass.int_4)
			{
				gClass.int_2 = GClass39.int_8 / 3 % (GClass146.gclass125_2.int_2 + 1);
				if (gClass.int_2 >= GClass146.gclass125_2.int_2)
				{
					gclass63_0.method_7(i);
					i--;
				}
				else
					GClass146.gclass125_2.method_0(gClass.int_2, x + gClass.int_0, y + gClass.int_1, 0, 3, g);
			}
		}
	}
}
